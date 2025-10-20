Imports System.Data.SqlClient

Public Class AttendanceForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub AttendanceForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Guest Attendance" ' Pinalitan ang title
        TIMECLOCK.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Datelbl.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")

        RemoveHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged
        DTPDate.Value = DateTime.Today
        AddHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged

        PopulateEventFilterMenu()
        LoadAttendance()
        Timer1.Start()
    End Sub

    Private Sub PopulateEventFilterMenu()
        Try
            For i As Integer = FilterToolStripMenuItem.DropDownItems.Count - 1 To 0 Step -1
                Dim item As ToolStripItem = FilterToolStripMenuItem.DropDownItems(i)
                If item IsNot ALLToolStripMenuItem AndAlso Not TypeOf item Is ToolStripSeparator Then
                    FilterToolStripMenuItem.DropDownItems.Remove(item)
                End If
            Next

            Dim eventList As New List(Of String)()
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT event_name FROM dbo.Events WHERE is_active = 1 ORDER BY event_name"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            eventList.Add(reader("event_name").ToString())
                        End While
                    End Using
                End Using
            End Using

            For Each eventName As String In eventList
                Dim newItem As New ToolStripMenuItem(eventName)
                AddHandler newItem.Click, AddressOf EventMenuItem_Click
                FilterToolStripMenuItem.DropDownItems.Add(newItem)
            Next
        Catch ex As Exception
            Console.WriteLine("Failed to build dynamic event menu: " & ex.Message)
        End Try
    End Sub

    Private Sub EventMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim clickedItem = CType(sender, ToolStripMenuItem)
        FilterByEvent(clickedItem.Text)
    End Sub

    Private Sub LoadAttendance(Optional ByVal filterQuery As String = "", Optional ByVal parameters As List(Of SqlParameter) = Nothing)
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' BINAGO: pinalitan ang member_id ng raffle_id
                Dim query As String = "SELECT attendance_id, raffle_id, full_name, event_name, event_date, status, time_in FROM dbo.Attendance WHERE is_deleted = 0"

                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND (" & filterQuery & ")"
                End If

                query &= " ORDER BY event_date DESC, time_in DESC"

                Using cmd As New SqlCommand(query, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters.ToArray())
                    End If
                    Using da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvAttendance.DataSource = dt
                        If dgvAttendance.Columns.Contains("time_in") Then
                            dgvAttendance.Columns("time_in").DefaultCellStyle.Format = "hh:mm tt"
                        End If
                        ' Opsyonal: Para mas maganda ang header text
                        If dgvAttendance.Columns.Contains("raffle_id") Then
                            dgvAttendance.Columns("raffle_id").HeaderText = "Raffle ID"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If searchText <> "" Then
            ' BINAGO: Idinagdag ang raffle_id sa search
            Dim filter As String = "full_name LIKE @search OR status LIKE @search OR event_name LIKE @search OR raffle_id LIKE @search"
            Dim parameters As New List(Of SqlParameter) From {New SqlParameter("@search", "%" & searchText & "%")}
            LoadAttendance(filter, parameters)
        Else
            LoadAttendance()
        End If
    End Sub

    Private Sub DTPDate_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DTPDate.ValueChanged
        Dim selectedDate As String = DTPDate.Value.ToString("yyyy-MM-dd")
        Dim filter As String = "CONVERT(date, event_date) = @date"
        Dim parameters As New List(Of SqlParameter) From {New SqlParameter("@date", selectedDate)}
        LoadAttendance(filter, parameters)
    End Sub

    Private Sub FilterByEvent(ByVal eventName As String)
        Dim filter As String = "event_name = @event"
        Dim parameters As New List(Of SqlParameter) From {New SqlParameter("@event", eventName)}
        LoadAttendance(filter, parameters)
    End Sub

#Region "Menu and Navigation Buttons"
    Private Sub ALLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLToolStripMenuItem.Click
        LoadAttendance()
        txtSearch.Clear()
        RemoveHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged
        DTPDate.Value = DateTime.Today
        AddHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        TimeClock.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Datelbl.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
    End Sub

    Private Sub btnAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendance.Click
        Using frm As New AttendanceFillvb()
            If frm.ShowDialog() = DialogResult.OK Then
                LoadAttendance()
                PopulateEventFilterMenu()
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If dgvAttendance.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim attendanceID As Object = dgvAttendance.CurrentRow.Cells("attendance_id").Value
        If attendanceID Is Nothing OrElse IsDBNull(attendanceID) Then
            MessageBox.Show("Selected row has an invalid attendance ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using frm As New AttendanceFillvb()
            frm.AttendanceID = Convert.ToInt32(attendanceID)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadAttendance()
                PopulateEventFilterMenu()
            End If
        End Using
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvAttendance.CurrentRow IsNot Nothing Then
            Dim attendanceID As Integer = Convert.ToInt32(dgvAttendance.CurrentRow.Cells("attendance_id").Value)
            If MessageBox.Show("Are you sure you want to move this record to the Recycle Bin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Dim query As String = "UPDATE dbo.Attendance SET is_deleted = 1 WHERE attendance_id=@id"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", attendanceID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Record moved to Recycle Bin successfully!", "Moved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadAttendance()
                PopulateEventFilterMenu()
            End If
        Else
            MessageBox.Show("Please select a record to move to the Recycle Bin.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
        Me.Close()
    End Sub

    Private Sub btnViewMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewMember.Click
        Dim memberListForm As New Form2()
        memberListForm.Show()
        Me.Close()
    End Sub

    Private Sub btnEventsAndAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventsAndAttendance.Click
        LoadAttendance()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim loginForm As New Form3()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnRecycle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecycle.Click
        Using recycleForm As New RecycleBinForm()
            recycleForm.ShowDialog()
        End Using
        LoadAttendance()
        PopulateEventFilterMenu()
    End Sub
#End Region

End Class