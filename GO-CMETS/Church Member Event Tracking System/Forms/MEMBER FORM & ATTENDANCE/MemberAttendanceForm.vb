Imports System.Data.SqlClient

Public Class MemberAttendanceForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

#Region "Variables Para sa UI Scaling"
    Private originalFormSize As Size
    Private controlOriginalBounds As New Dictionary(Of String, Rectangle)
    Private controlOriginalFonts As New Dictionary(Of String, Single)
#End Region

    Private Sub MemberAttendanceForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Member Events & Attendance"

        originalFormSize = Me.ClientSize
        For Each ctrl As Control In Me.Controls
            RecordInitialStateRecursive(ctrl)
        Next

        RemoveHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged
        DTPDate.Value = DateTime.Today
        AddHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged

        PopulateEventFilterMenu()
        LoadMemberAttendance()
        Timer1.Start()
    End Sub

#Region "Dynamic Menu Generation"
    Private Sub PopulateEventFilterMenu()
        Try
            For i As Integer = SelectEventToolStripMenuItem.DropDownItems.Count - 1 To 0 Step -1
                Dim item As ToolStripItem = SelectEventToolStripMenuItem.DropDownItems(i)
                If item IsNot ALLToolStripMenuItem AndAlso Not TypeOf item Is ToolStripSeparator Then
                    SelectEventToolStripMenuItem.DropDownItems.Remove(item)
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
                SelectEventToolStripMenuItem.DropDownItems.Add(newItem)
            Next
        Catch ex As Exception
            Console.WriteLine("Failed to build dynamic event menu: " & ex.Message)
        End Try
    End Sub

    Private Sub EventMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim clickedItem = CType(sender, ToolStripMenuItem)
        FilterByEvent(clickedItem.Text)
    End Sub
#End Region

#Region "UI Scaling Logic (Adjustable UI)"
    Private Sub MemberAttendanceForm_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Return
        If originalFormSize.Width = 0 Or originalFormSize.Height = 0 Then Return

        Dim xRatio As Single = CSng(Me.ClientSize.Width) / originalFormSize.Width
        Dim yRatio As Single = CSng(Me.ClientSize.Height) / originalFormSize.Height

        For Each ctrl As Control In Me.Controls
            ScaleControlRecursive(ctrl, xRatio, yRatio)
        Next
    End Sub

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

#Region "Data Loading, Filtering, and Actions"
    Private Sub LoadMemberAttendance(Optional ByVal filterQuery As String = "", Optional ByVal parameters As List(Of SqlParameter) = Nothing)
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT member_attendance_id AS attendance_id, member_id, full_name, event_name, event_date, status, time_in FROM dbo.MemberAttendance WHERE is_deleted = 0"
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
                        dt.Columns.Add("TimeInFormatted", GetType(String))
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("time_in")) Then
                                Dim timeValue As TimeSpan = CType(row("time_in"), TimeSpan)
                                row("TimeInFormatted") = DateTime.Today.Add(timeValue).ToString("hh:mm tt")
                            Else
                                row("TimeInFormatted") = ""
                            End If
                        Next
                        dgvAttendance1.DataSource = dt
                        If dgvAttendance1.Columns.Contains("time_in") Then
                            dgvAttendance1.Columns("time_in").Visible = False
                        End If
                        If dgvAttendance1.Columns.Contains("TimeInFormatted") Then
                            dgvAttendance1.Columns("TimeInFormatted").HeaderText = "TIME_IN"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If searchText <> "" Then
            Dim filter As String = "full_name LIKE @search OR status LIKE @search OR member_id LIKE @search OR event_name LIKE @search"
            Dim parameters As New List(Of SqlParameter) From {New SqlParameter("@search", "%" & searchText & "%")}
            LoadMemberAttendance(filter, parameters)
        Else
            LoadMemberAttendance()
        End If
    End Sub

    Private Sub DTPDate_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DTPDate.ValueChanged
        Dim selectedDate As String = DTPDate.Value.ToString("yyyy-MM-dd")
        Dim filter As String = "CONVERT(date, event_date) = @date"
        Dim parameters As New List(Of SqlParameter) From {New SqlParameter("@date", selectedDate)}
        LoadMemberAttendance(filter, parameters)
    End Sub

    Private Sub FilterByEvent(ByVal eventName As String)
        Dim filter As String = "event_name = @event"
        Dim parameters As New List(Of SqlParameter) From {New SqlParameter("@event", eventName)}
        LoadMemberAttendance(filter, parameters)
    End Sub

    ' === ITO ANG INAYOS NA BAHAGI ===
    Private Sub ALLToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ALLToolStripMenuItem.Click
        LoadMemberAttendance()
        txtSearch.Clear()
        ' Itinuturo na nito ang tamang PANGALAN NG METHOD
        RemoveHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged
        DTPDate.Value = DateTime.Today
        ' Itinuturo na nito ang tamang PANGALAN NG METHOD
        AddHandler DTPDate.ValueChanged, AddressOf DTPDate_ValueChanged
    End Sub

    Private Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScan.Click
        Me.Hide()
        Using scanner As New ScannerForm()
            scanner.ShowDialog()
        End Using
        Me.Show()
        LoadMemberAttendance()
        PopulateEventFilterMenu()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvAttendance1.CurrentRow IsNot Nothing Then
            Dim attendanceID As Integer = Convert.ToInt32(dgvAttendance1.CurrentRow.Cells("attendance_id").Value)
            If MessageBox.Show("Move this record to the Recycle Bin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Dim query As String = "UPDATE dbo.MemberAttendance SET is_deleted = 1 WHERE member_attendance_id=@id"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", attendanceID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Record moved to Recycle Bin.", "Moved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMemberAttendance()
                PopulateEventFilterMenu()
            End If
        End If
    End Sub

    Private Sub btnRecycle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecycle.Click
        Using recycleForm As New RecycleAttendanceMemberForm()
            recycleForm.ShowDialog()
        End Using
        LoadMemberAttendance()
        PopulateEventFilterMenu()
    End Sub

    Private Sub btnBackToMembers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBackToMembers.Click
        Dim memberListForm As New Form2()
        memberListForm.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        TIMECLOCK.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Datelbl.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
    End Sub

#End Region

End Class