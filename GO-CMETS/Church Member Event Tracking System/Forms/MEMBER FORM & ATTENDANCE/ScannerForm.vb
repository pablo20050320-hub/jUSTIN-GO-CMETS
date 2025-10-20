Imports System.Data.SqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports System.ComponentModel

Public Class ScannerForm
    ' --- DATABASE CONNECTION ---
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    ' --- CAMERA AND SCANNER OBJECTS ---
    Private videoDevices As FilterInfoCollection
    Private videoSource As IVideoSource
    Private barcodeReader As BarcodeReader

    ' --- STATE MANAGEMENT FLAGS ---
    Private isClosing As Boolean = False
    Private isProcessingFrame As Boolean = False ' <--- MAHALAGANG FLAG: Para maiwasan ang sabay-sabay na pag-scan

#Region "Form Events (Load, Shown, Closing)"

    Private Sub ScannerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "QR Code Attendance Scanner"
        lblName.Text = "---"
        lblStatus.Text = "Camera is off. Click 'Open Camera' to start."
        btnOpenCloseCamera.Text = "Open Camera"
        picCameraFeed.BackColor = Color.Gainsboro

        InitializeBarcodeReader()
        PopulateEventComboBox()
    End Sub

    Private Sub ScannerForm_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        ' Hanapin ang camera sa background para hindi mag-freeze ang UI pagbukas
        Dim bgWorker As New BackgroundWorker()
        AddHandler bgWorker.DoWork, AddressOf InitializeCamera_DoWork
        AddHandler bgWorker.RunWorkerCompleted, AddressOf InitializeCamera_Completed
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub ScannerForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosing Then Return

        e.Cancel = True
        isClosing = True
        StopCamera()

        ' Gumamit ng timer para masigurong maayos na napatay ang camera bago isara ang form
        Dim closeTimer As New Timer()
        closeTimer.Interval = 500
        AddHandler closeTimer.Tick, Sub(s, ev)
                                        Dim timer = CType(s, Timer)
                                        timer.Stop()
                                        timer.Dispose()
                                        Me.Close()
                                    End Sub
        closeTimer.Start()
    End Sub

#End Region

#Region "Initialization (Camera, Barcode Reader, ComboBox)"

    Private Sub InitializeBarcodeReader()
        barcodeReader = New BarcodeReader()
        barcodeReader.Options.PossibleFormats = {BarcodeFormat.QR_CODE}
        barcodeReader.Options.TryHarder = True ' Mas pagbubutihin ang paghahanap
    End Sub

    ' Ang function na ito ay tama na, kumukuha na ito mula sa dbo.Events
    Private Sub PopulateEventComboBox()
        Try
            ' Itabi ang kasalukuyang pinili para maibalik mamaya
            Dim currentSelection As String = cmbCurrentEvent.Text
            cmbCurrentEvent.Items.Clear()
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT event_name FROM dbo.Events WHERE is_active = 1 ORDER BY event_name"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbCurrentEvent.Items.Add(reader("event_name").ToString())
                        End While
                    End Using
                End Using
            End Using
            ' Subukang ibalik ang dating selection
            If cmbCurrentEvent.Items.Contains(currentSelection) Then
                cmbCurrentEvent.Text = currentSelection
            ElseIf cmbCurrentEvent.Items.Count > 0 Then
                cmbCurrentEvent.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading events: " & ex.Message)
        End Try
    End Sub

    Private Sub InitializeCamera_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
    End Sub

    Private Sub InitializeCamera_Completed(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If videoDevices Is Nothing OrElse videoDevices.Count = 0 Then
            MessageBox.Show("No webcam found.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnOpenCloseCamera.Enabled = False
            lblStatus.Text = "No camera detected."
        End If
    End Sub

#End Region

#Region "Camera Control (Start, Stop, NewFrame)"

    Private Sub StartCamera(ByVal deviceIndex As Integer)
        If videoDevices Is Nothing OrElse deviceIndex >= videoDevices.Count Then Return
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then Return

        videoSource = New VideoCaptureDevice(videoDevices(deviceIndex).MonikerString)
        AddHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
        videoSource.Start()
        scanTimer.Start() ' <--- Simulan ang timer para sa pag-scan
        lblStatus.Text = "Please show your QR Code..."
    End Sub

    Private Sub StopCamera()
        scanTimer.Stop() ' <--- Itigil ang timer
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            RemoveHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
            videoSource = Nothing
        End If
    End Sub

    Private Sub videoSource_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        If isClosing Then Return
        Try
            ' I-update lang ang PictureBox, wala nang iba
            If Me.IsHandleCreated AndAlso Not Me.IsDisposed Then
                Me.Invoke(Sub()
                              If picCameraFeed IsNot Nothing AndAlso Not picCameraFeed.IsDisposed Then
                                  ' Iwasan ang madalas na pag-Dispose at Clone para bumilis
                                  Dim oldImage = picCameraFeed.Image
                                  picCameraFeed.Image = CType(eventArgs.Frame.Clone(), Bitmap)
                                  If oldImage IsNot Nothing Then
                                      oldImage.Dispose()
                                  End If
                              End If
                          End Sub)
            End If
        Catch ex As Exception
            ' Huwag pansinin
        End Try
    End Sub

#End Region

#Region "Core Scanning Logic (Optimized for No Lag)"

    ' Step 1: Ang Timer ay magti-trigger lang ng proseso.
    Private Sub scanTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles scanTimer.Tick
        ' Huwag mag-scan kung:
        ' 1. Walang image sa PictureBox
        ' 2. Mayroon nang kasalukuyang proseso ng pag-scan
        If picCameraFeed.Image Is Nothing OrElse isProcessingFrame Then
            Return
        End If

        ' I-set ang flag para hindi na muna ulit mag-scan sa susunod na tick
        isProcessingFrame = True

        ' Gumawa ng kopya ng image na i-scan
        Dim imageToScan As Bitmap
        Try
            ' I-lock ang image para siguradong hindi ito nagagalaw habang kinokopya
            SyncLock picCameraFeed
                imageToScan = CType(picCameraFeed.Image.Clone(), Bitmap)
            End SyncLock
        Catch ex As Exception
            ' Kung magka-error sa pag-clone, itigil muna
            isProcessingFrame = False
            Return
        End Try

        ' Gamit ang BackgroundWorker para ilipat ang mabigat na trabaho sa background
        Dim scannerWorker As New BackgroundWorker()
        AddHandler scannerWorker.DoWork, AddressOf ScanAndProcess_DoWork
        AddHandler scannerWorker.RunWorkerCompleted, AddressOf ScanAndProcess_Completed

        ' Simulan ang background work at ipasa ang image na i-scan
        scannerWorker.RunWorkerAsync(imageToScan)
    End Sub

    ' Step 2: Ang BackgroundWorker ang gagawa ng mabigat na trabaho.
    Private Sub ScanAndProcess_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim imageToScan = CType(e.Argument, Bitmap)
        Dim resultText As String = ""

        ' --- HEAVY WORK 1: DECODING QR CODE ---
        Try
            Dim result As Result = barcodeReader.Decode(imageToScan)
            If result IsNot Nothing Then
                resultText = result.Text
            End If
        Catch ex As Exception
            ' Error sa pag-decode
        Finally
            ' I-dispose ang kinopyang image pagkatapos gamitin
            imageToScan.Dispose()
        End Try

        If String.IsNullOrEmpty(resultText) Then
            ' Walang nahanap na QR code, itigil na
            e.Result = Nothing
            Return
        End If

        ' --- HEAVY WORK 2: DATABASE ACCESS ---
        Dim currentEvent As String = ""
        Me.Invoke(Sub() currentEvent = cmbCurrentEvent.Text) ' Kunin ang event name mula sa UI

        ' I-package ang resulta para ipadala pabalik sa UI thread
        Dim processResult As New Dictionary(Of String, Object)
        processResult.Add("ID", resultText) ' Itago ang ID

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Check if member exists
                Dim memberName As String = ""
                Using cmdGetName As New SqlCommand("SELECT first_name + ' ' + last_name FROM memberinfo WHERE id = @id AND is_deleted = 0", conn)
                    cmdGetName.Parameters.AddWithValue("@id", resultText)
                    Dim resultName = cmdGetName.ExecuteScalar()
                    If resultName IsNot Nothing Then memberName = resultName.ToString()
                End Using

                If String.IsNullOrEmpty(memberName) Then
                    processResult.Add("Status", "NotFound")
                    e.Result = processResult
                    Return
                End If

                processResult.Add("Name", memberName) ' Itago ang pangalan

                ' Check if already timed-in for today's event
                Using cmdCheck As New SqlCommand("SELECT COUNT(*) FROM dbo.MemberAttendance WHERE member_id = @id AND event_name = @event AND CONVERT(date, event_date) = CONVERT(date, GETDATE())", conn)
                    cmdCheck.Parameters.AddWithValue("@id", resultText)
                    cmdCheck.Parameters.AddWithValue("@event", currentEvent)
                    If CInt(cmdCheck.ExecuteScalar()) > 0 Then
                        processResult.Add("Status", "AlreadyExists")
                        e.Result = processResult
                        Return
                    End If
                End Using

                ' Insert new attendance record
                Using cmdInsert As New SqlCommand("INSERT INTO dbo.MemberAttendance (member_id, full_name, event_name, event_date, status, time_in) VALUES (@id, @name, @event, GETDATE(), 'PRESENT', GETDATE())", conn)
                    cmdInsert.Parameters.AddWithValue("@id", resultText)
                    cmdInsert.Parameters.AddWithValue("@name", memberName)
                    cmdInsert.Parameters.AddWithValue("@event", currentEvent)
                    cmdInsert.ExecuteNonQuery()
                    processResult.Add("Status", "Success")
                End Using
            End Using
        Catch ex As Exception
            processResult.Add("Status", "DBError")
            processResult.Add("Message", ex.Message)
        End Try

        e.Result = processResult
    End Sub

    ' Step 3: Kapag tapos na ang background work, i-update ang UI nang walang lag.
    Private Sub ScanAndProcess_Completed(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Result Is Nothing Then
            ' Walang QR na nahanap, payagan na ulit mag-scan
            isProcessingFrame = False
            Return
        End If

        ' Itigil muna ang master scan timer habang pinapakita ang resulta
        scanTimer.Stop()

        Dim result = CType(e.Result, Dictionary(Of String, Object))
        Dim status As String = result("Status").ToString()

        ' Ipakita ang resulta sa UI
        Select Case status
            Case "Success"
                UpdateStatus(result("Name").ToString(), "Attendance Recorded!", Color.Green, 1200)
            Case "AlreadyExists"
                UpdateStatus(result("Name").ToString(), "Already Timed-In", Color.Orange, 800)
            Case "NotFound"
                UpdateStatus("Member Not Found", "ID: " & result("ID").ToString(), Color.Red, 500)
            Case "DBError"
                UpdateStatus("Database Error!", result("Message").ToString(), Color.Red, 500)
        End Select

        ' Gumamit ng maikling timer para i-reset ang display bago mag-scan ulit
        Dim resetTimer As New Timer()
        resetTimer.Interval = 1800 ' 1.8 segundo
        AddHandler resetTimer.Tick, Sub(s, ev)
                                        Dim timer = CType(s, Timer)
                                        timer.Stop()
                                        timer.Dispose()

                                        ' Ibalik sa default state
                                        UpdateStatus("---", "Please show your QR Code...", Color.Black, 0)

                                        ' Payagan na ulit mag-scan
                                        isProcessingFrame = False
                                        scanTimer.Start()
                                    End Sub
        resetTimer.Start()
    End Sub

#End Region

#Region "UI Controls (Button Click, Update Status)"

    Private Sub btnOpenCloseCamera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenCloseCamera.Click
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            StopCamera()
            picCameraFeed.Image = Nothing
            picCameraFeed.BackColor = Color.Gainsboro
            lblStatus.Text = "Camera is off."
            btnOpenCloseCamera.Text = "Open Camera"
        Else
            If videoDevices IsNot Nothing AndAlso videoDevices.Count > 0 Then
                StartCamera(0)
                btnOpenCloseCamera.Text = "Close Camera"
            Else
                MessageBox.Show("No webcam found to open.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub UpdateStatus(ByVal nameText As String, ByVal statusText As String, ByVal statusColor As Color, ByVal beepFrequency As Integer)
        If Me.IsHandleCreated AndAlso Not Me.IsDisposed Then
            Me.Invoke(Sub()
                          lblName.Text = nameText
                          lblStatus.Text = statusText
                          lblStatus.ForeColor = statusColor
                      End Sub)
        End If
        If beepFrequency > 0 Then
            Console.Beep(beepFrequency, 300)
        End If
    End Sub

#End Region

    Private Sub btnAddEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEvent.Click
        Dim newEventName As String = txtNewEvent.Text.Trim()
        If String.IsNullOrWhiteSpace(newEventName) Then
            MessageBox.Show("Please enter the new event name in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Query para mag-insert sa master list (dbo.Events)
                Dim query As String = "INSERT INTO dbo.Events (event_name) VALUES (@event_name)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@event_name", newEventName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("'" & newEventName & "' has been successfully added to the master list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewEvent.Clear() ' Linisin ang text box

            ' I-refresh ang ComboBox para lumabas agad ang bago
            PopulateEventComboBox()

            ' Awtomatikong piliin ang bagong event
            cmbCurrentEvent.Text = newEventName

        Catch ex As SqlException
            ' Kung ang error ay dahil duplicate na ang event name
            If ex.Number = 2627 Or ex.Number = 2601 Then
                MessageBox.Show("'" & newEventName & "' already exists in the master list.", "Duplicate Event", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Piliin na lang natin ito para sa user
                cmbCurrentEvent.Text = newEventName
            Else
                MessageBox.Show("A database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class