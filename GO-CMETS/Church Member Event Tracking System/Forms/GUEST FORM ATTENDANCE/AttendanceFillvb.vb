Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization

Public Class AttendanceFillvb
    Public Property AttendanceID As Integer = 0
    Private ReadOnly connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub AttendanceFillvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTPEventDate.Format = DateTimePickerFormat.Short
        PopulateEventComboBox()

        If AttendanceID > 0 Then
            Me.Text = "Update Guest Attendance"
            btnSaveAttendance.Text = "Update"
            LoadAttendanceData()
        Else
            Me.Text = "Add Guest Attendance"
            btnSaveAttendance.Text = "Save"
            ClearFields()
        End If
    End Sub

    Private Sub PopulateEventComboBox()
        Try
            Dim currentText As String = cmbEventName.Text
            cmbEventName.Items.Clear()
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT event_name FROM dbo.Events WHERE is_active = 1 ORDER BY event_name"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbEventName.Items.Add(reader("event_name").ToString())
                        End While
                    End Using
                End Using
            End Using
            cmbEventName.Text = currentText
        Catch ex As Exception
            Console.WriteLine("Error populating event list: " & ex.Message)
        End Try
    End Sub

    ' Para sa pag-add ng bagong event sa master list
    Private Sub btnAddEvent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddToList.Click
        Dim newEventName As String = txtNewEvent.Text.Trim()
        If String.IsNullOrWhiteSpace(newEventName) Then
            MessageBox.Show("Please enter a new event name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO dbo.Events (event_name) VALUES (@event_name)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@event_name", newEventName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("'" & newEventName & "' has been added to the master list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewEvent.Clear()
            PopulateEventComboBox()
            cmbEventName.Text = newEventName
        Catch ex As SqlException
            If ex.Number = 2627 Or ex.Number = 2601 Then
                MessageBox.Show("'" & newEventName & "' already exists in the master list.", "Duplicate Event", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' === ITO ANG INAYOS NA SAVE BUTTON ===
    Private Sub btnSaveAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAttendance.Click
        ' --- Step 1: Basic Validation ---
        If String.IsNullOrWhiteSpace(txtRaffleID.Text) OrElse String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please fill in both Raffle ID and Full Name.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(cmbEventName.Text) Then
            MessageBox.Show("Please select an event.", "Event Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Step 2: Advanced Validation ---
        Dim raffleId As Integer
        If Not Integer.TryParse(txtRaffleID.Text, raffleId) Then
            MessageBox.Show("Raffle ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TAWAGIN ANG INAYOS NA FUNCTION DITO!
        ' Ipinapasa na natin ngayon ang petsa.
        If IsRaffleIdDuplicate(raffleId, cmbEventName.Text, DTPEventDate.Value, Me.AttendanceID) Then
            MessageBox.Show("Raffle ID '" & raffleId & "' already exists for the event '" & cmbEventName.Text & "' on this date. Please use a different ID.", "Duplicate Raffle ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Itigil ang proseso
        End If

        ' --- Step 3: Parse Time and Save ---
        Dim parsedDateTime As DateTime
        Dim timeToSave As TimeSpan
        If DateTime.TryParse(txtTimeIn.Text, parsedDateTime) Then
            timeToSave = parsedDateTime.TimeOfDay
        Else
            MessageBox.Show("Invalid time format. Please use a valid time like '9:30 AM' or '14:00'.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String
                If AttendanceID = 0 Then
                    query = "INSERT INTO dbo.Attendance (raffle_id, full_name, event_name, event_date, status, time_in) VALUES (@raffle_id, @full_name, @event_name, @event_date, @status, @time_in)"
                Else
                    query = "UPDATE dbo.Attendance SET raffle_id=@raffle_id, full_name=@full_name, event_name=@event_name, event_date=@event_date, status=@status, time_in=@time_in WHERE attendance_id=@attendance_id"
                End If
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@raffle_id", SqlDbType.Int).Value = raffleId
                    cmd.Parameters.Add("@full_name", SqlDbType.VarChar).Value = txtFullName.Text
                    cmd.Parameters.Add("@event_name", SqlDbType.VarChar).Value = cmbEventName.Text
                    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = cmbStatus.Text
                    cmd.Parameters.Add("@event_date", SqlDbType.Date).Value = DTPEventDate.Value.Date
                    cmd.Parameters.Add("@time_in", SqlDbType.Time).Value = timeToSave
                    If AttendanceID > 0 Then
                        cmd.Parameters.Add("@attendance_id", SqlDbType.Int).Value = AttendanceID
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            If AttendanceID = 0 Then
                MessageBox.Show("✅ Guest Attendance saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("✅ Guest Attendance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' === ITO ANG INAYOS NA DUPLICATE CHECK FUNCTION ===
    Private Function IsRaffleIdDuplicate(ByVal raffleId As Integer, ByVal eventName As String, ByVal eventDate As DateTime, ByVal currentAttendanceId As Integer) As Boolean
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' BINAGO: Idinagdag ang pag-check sa petsa
                Dim query As String = "SELECT COUNT(*) FROM dbo.Attendance WHERE raffle_id = @raffle_id AND event_name = @event_name AND CONVERT(date, event_date) = @event_date"

                ' Kung nag-a-update, i-exclude ang sarili sa check
                If currentAttendanceId > 0 Then
                    query &= " AND attendance_id <> @attendance_id"
                End If

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@raffle_id", raffleId)
                    cmd.Parameters.AddWithValue("@event_name", eventName)
                    ' Siguraduhing Date lang ang ipapasa, hindi kasama ang oras
                    cmd.Parameters.Add("@event_date", SqlDbType.Date).Value = eventDate.Date
                    If currentAttendanceId > 0 Then
                        cmd.Parameters.AddWithValue("@attendance_id", currentAttendanceId)
                    End If

                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking for duplicate Raffle ID: " & ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Maging ligtas, ituring na duplicate kung may error
        End Try
    End Function

    Private Sub LoadAttendanceData()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM dbo.Attendance WHERE attendance_id=@id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", AttendanceID)
                    Using r = cmd.ExecuteReader()
                        If r.Read() Then
                            txtAttendanceID.Text = r("attendance_id").ToString()
                            txtRaffleID.Text = r("raffle_id").ToString()
                            txtFullName.Text = r("full_name").ToString()
                            cmbEventName.Text = r("event_name").ToString()
                            cmbStatus.Text = r("status").ToString()
                            Dim eventDateValue As DateTime
                            If DateTime.TryParse(r("event_date").ToString(), eventDateValue) Then
                                DTPEventDate.Value = eventDateValue
                            End If
                            If Not IsDBNull(r("time_in")) Then
                                Dim timeString As String = r("time_in").ToString()
                                Dim parsedTime As TimeSpan
                                If TimeSpan.TryParse(timeString, parsedTime) Then
                                    Dim tempDateTime As DateTime = DateTime.Today.Add(parsedTime)
                                    txtTimeIn.Text = tempDateTime.ToString("hh:mm tt")
                                Else
                                    txtTimeIn.Text = timeString
                                End If
                            Else
                                txtTimeIn.Clear()
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading attendance data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        AttendanceID = 0
        txtAttendanceID.Text = GetNextAttendanceID().ToString()
        txtRaffleID.Clear()
        txtFullName.Clear()
        cmbEventName.SelectedIndex = -1
        cmbEventName.Text = ""
        cmbStatus.SelectedIndex = -1
        DTPEventDate.Value = DateTime.Now
        txtTimeIn.Text = DateTime.Now.ToString("hh:mm tt")
        txtNewEvent.Clear()
        txtRaffleID.Focus()
    End Sub

    Private Function GetNextAttendanceID() As Integer
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT ISNULL(MAX(attendance_id), 0) + 1 FROM dbo.Attendance"
                Using cmd As New SqlCommand(query, conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error getting next Attendance ID: " & ex.Message)
            Return 1
        End Try
    End Function

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class