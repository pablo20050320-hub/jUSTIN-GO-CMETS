Imports System.Data.SqlClient

Public Class DashboardForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

#Region "Variables Para sa UI Scaling at Window Dragging"
    Private originalFormSize As Size
    Private controlOriginalBounds As New Dictionary(Of String, Rectangle)
    Private controlOriginalFonts As New Dictionary(Of String, Single)
    ' -- Para sa pag-drag ng borderless form --
    Private isDragging As Boolean = False
    Private mouseOffset As Point
#End Region

    Private Sub DashboardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        originalFormSize = Me.ClientSize
        For Each ctrl As Control In Me.Controls
            RecordInitialStateRecursive(ctrl)
        Next

        ' === BAGONG DAGDAG: Itakda ang paunang itsura ng Maximize button ===
        UpdateMaximizeButtonImage()

        LoadDashboardData()
    End Sub

#Region "Custom Window Controls, Dragging, at UI Scaling"

    ' ==== FORM RESIZE EVENT ====
    Private Sub DashboardForm_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Return

        ' === BAGONG DAGDAG: I-update ang itsura ng Maximize button ===
        UpdateMaximizeButtonImage()

        Dim xRatio As Single = CSng(Me.ClientSize.Width) / originalFormSize.Width
        Dim yRatio As Single = CSng(Me.ClientSize.Height) / originalFormSize.Height
        For Each ctrl As Control In Me.Controls
            ScaleControlRecursive(ctrl, xRatio, yRatio)
        Next
    End Sub

    ' === BAGONG DAGDAG: MGA CLICK EVENTS PARA SA MGA BUTTONS ===

    ' Palitan ang "btnMinimize" kung iba ang pangalan
    Private Sub btnMinimize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Palitan ang "btnMinimizeMaximize" kung iba ang pangalan
    Private Sub btnMinimizeMaximize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinimizeMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    ' Palitan ang "btnExit" kung iba ang pangalan
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' === BAGONG DAGDAG: Helper method para palitan ang image ng maximize button ===
    Private Sub UpdateMaximizeButtonImage()
        ' Siguraduhing mayroon kang btnMinimizeMaximize sa form
        If btnMinimizeMaximize IsNot Nothing Then
            If Me.WindowState = FormWindowState.Maximized Then
                btnMinimizeMaximize.Image = My.Resources.minimize ' O kung anuman ang pangalan ng restore icon mo
            Else
                btnMinimizeMaximize.Image = My.Resources.maximize
            End If
        End If
    End Sub

    ' === BAGONG DAGDAG: CODE PARA SA PAG-DRAG NG WINDOW ===
    ' Ikabit ang mga event na ito sa isang Panel na nagsisilbing Title Bar (hal. pnlTitleBar)
    Private Sub pnlTitleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitleBar.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub pnlTitleBar_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitleBar.MouseMove
        If isDragging Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub pnlTitleBar_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitleBar.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    ' === UI SCALING LOGIC (Walang binago dito) ===
    Private Sub RecordInitialStateRecursive(ByVal parentCtrl As Control)
        If String.IsNullOrEmpty(parentCtrl.Name) Then Return
        If Not controlOriginalBounds.ContainsKey(parentCtrl.Name) Then
            controlOriginalBounds.Add(parentCtrl.Name, parentCtrl.Bounds)
            controlOriginalFonts.Add(parentCtrl.Name, parentCtrl.Font.Size)
        End If
        For Each childCtrl As Control In parentCtrl.Controls
            RecordInitialStateRecursive(childCtrl)
        Next
    End Sub

    Private Sub ScaleControlRecursive(ByVal parentCtrl As Control, ByVal xRatio As Single, ByVal yRatio As Single)
        If controlOriginalBounds.ContainsKey(parentCtrl.Name) Then
            Dim originalBounds = controlOriginalBounds(parentCtrl.Name)
            Dim originalFontSize = controlOriginalFonts(parentCtrl.Name)
            parentCtrl.Bounds = New Rectangle(
                CInt(originalBounds.X * xRatio), CInt(originalBounds.Y * yRatio),
                CInt(originalBounds.Width * xRatio), CInt(originalBounds.Height * yRatio)
            )
            Dim newFontSize = originalFontSize * Math.Min(xRatio, yRatio)
            If newFontSize > 1 Then
                parentCtrl.Font = New Font(parentCtrl.Font.FontFamily, newFontSize, parentCtrl.Font.Style)
            End If
        End If
        For Each childCtrl As Control In parentCtrl.Controls
            ScaleControlRecursive(childCtrl, xRatio, yRatio)
        Next
    End Sub

#End Region

#Region "Data Loading at Iba pang Functions"

    Private Function GetConnection() As SqlConnection
        Return New SqlConnection(connString)
    End Function

    Private Sub LoadDashboardData()
        Using con As SqlConnection = GetConnection()
            Try
                con.Open()
                LoadMemberCounts(con)
                LoadEventStatistics(con)
                LoadUpcomingEvents(con)
            Catch ex As Exception
                MessageBox.Show("Error loading dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadMemberCounts(ByVal con As SqlConnection)
        Dim queries As New Dictionary(Of String, Label) From {
            {"SELECT COUNT(*) FROM memberinfo", lblTotalMember},
            {"SELECT COUNT(*) FROM memberinfo WHERE gender = 'Male'", lblTotalMale},
            {"SELECT COUNT(*) FROM memberinfo WHERE gender = 'Female'", lblTotalFemale},
            {"SELECT COUNT(*) FROM memberinfo WHERE Ministry = 'WORSHIP TEAM MINISTRY'", lblTotalWorshipTeam},
            {"SELECT COUNT(*) FROM memberinfo WHERE Ministry = 'YOUTH MINISTRY'", lblTotalYouthMinistry},
            {"SELECT COUNT(*) FROM memberinfo WHERE Ministry = 'KIDS MINISTRY'", lblTotalKidsMinistry},
            {"SELECT COUNT(*) FROM memberinfo WHERE Ministry = 'WOMENS MINISTRY'", lblTotalWomensMinistry},
            {"SELECT COUNT(*) FROM memberinfo WHERE Ministry = 'MENS MINISTRY'", lblTotalMensMinistry}
        }
        For Each item In queries
            item.Value.Text = GetCount(item.Key, con).ToString("00")
        Next
    End Sub

    Private Sub LoadEventStatistics(ByVal con As SqlConnection)
        Dim eventsThisMonthQuery As String = "SELECT COUNT(DISTINCT event_date) FROM dbo.Attendance WHERE MONTH(event_date) = MONTH(GETDATE()) AND YEAR(event_date) = YEAR(GETDATE())"
        lblEventsThisMonth.Text = GetCount(eventsThisMonthQuery, con).ToString()
        Dim totalAttendanceQuery As String = "SELECT COUNT(*) FROM dbo.Attendance WHERE MONTH(event_date) = MONTH(GETDATE()) AND YEAR(event_date) = YEAR(GETDATE())"
        Dim totalAttendees As Integer = GetCount(totalAttendanceQuery, con)
        lblTotalAttendanceMonth.Text = totalAttendees.ToString()
        Dim totalEvents As Integer
        Integer.TryParse(lblEventsThisMonth.Text, totalEvents)
        If totalEvents > 0 Then
            Dim average As Double = CDbl(totalAttendees) / CDbl(totalEvents)
            lblAverageTurnout.Text = Math.Round(average, 1).ToString()
        Else
            lblAverageTurnout.Text = "0"
        End If
        Using newCon As SqlConnection = GetConnection()
            newCon.Open()
            Dim highestTurnoutQuery As String = "SELECT TOP 1 event_name, COUNT(*) AS AttendeeCount " &
                                                "FROM dbo.Attendance " &
                                                "WHERE MONTH(event_date) = MONTH(GETDATE()) AND YEAR(event_date) = YEAR(GETDATE()) " &
                                                "GROUP BY event_name " &
                                                "ORDER BY AttendeeCount DESC"
            Using cmd As New SqlCommand(highestTurnoutQuery, newCon)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lblHighestTurnoutEvent.Text = reader("event_name").ToString() & " (" & reader("AttendeeCount").ToString() & ")"
                    Else
                        lblHighestTurnoutEvent.Text = "N/A"
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadUpcomingEvents(ByVal con As SqlConnection)
        lstUpcomingEvents.Items.Clear()
        Dim query As String = "SELECT DISTINCT TOP 5 event_name, event_date " &
                               "FROM dbo.Attendance " &
                               "WHERE event_date >= CAST(GETDATE() AS DATE) " &
                               "ORDER BY event_date ASC"
        Using cmd As New SqlCommand(query, con)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If Not reader.HasRows Then
                    lstUpcomingEvents.Items.Add("No upcoming events found.")
                Else
                    While reader.Read()
                        Dim eventName As String = reader("event_name").ToString()
                        Dim eventDate As DateTime = Convert.ToDateTime(reader("event_date"))
                        Dim displayText As String = "• " & eventName & " - " & eventDate.ToString("MMMM dd, yyyy")
                        lstUpcomingEvents.Items.Add(displayText)
                    End While
                End If
            End Using
        End Using
    End Sub

    Private Function GetCount(ByVal query As String, ByVal con As SqlConnection) As Integer
        Using cmd As New SqlCommand(query, con)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            Else
                Return 0
            End If
        End Using
    End Function

    Private Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click
        Dim recordsForm As New Form2()
        recordsForm.Show()
        Me.Close()
    End Sub

#End Region

   
End Class