Imports System.Data.SqlClient

' Ito ang Recycle Bin para sa MEMBER ATTENDANCE
Public Class RecycleAttendanceMemberForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub RecycleAttendanceMemberForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Member Attendance - Recycle Bin"
        LoadRecycledItems()
    End Sub

    Private Sub LoadRecycledItems()
        Try
            Using conn As New SqlConnection(connString)
                ' Kumukuha ng data mula sa "MemberAttendance" table kung saan ang is_deleted = 1
                ' Gumagamit ng alias (AS attendance_id) para maging consistent ang column name sa grid
                Dim query As String = "SELECT member_attendance_id AS attendance_id, member_id, full_name, event_name, event_date FROM dbo.MemberAttendance WHERE is_deleted = 1"
                Using adapter As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRecycled.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recycled items: " & ex.Message)
        End Try
    End Sub

    ' --- PANG-ISANG RECORD LANG ---

    Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestore.Click
        If dgvRecycled.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a record to restore.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim attendanceID As Integer = Convert.ToInt32(dgvRecycled.CurrentRow.Cells("attendance_id").Value)
        Dim query As String = "UPDATE dbo.MemberAttendance SET is_deleted = 0 WHERE member_attendance_id=@id"

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", attendanceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Record restored successfully!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRecycledItems()
        Catch ex As Exception
            MessageBox.Show("Error restoring record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeletePermanently_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeletePermanently.Click
        If dgvRecycled.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a record to delete permanently.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("This action cannot be undone. Are you sure you want to permanently delete this record?", "Confirm Permanent Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim attendanceID As Integer = Convert.ToInt32(dgvRecycled.CurrentRow.Cells("attendance_id").Value)
            Dim query As String = "DELETE FROM dbo.MemberAttendance WHERE member_attendance_id=@id"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", attendanceID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Record permanently deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRecycledItems()
            Catch ex As Exception
                MessageBox.Show("Error permanently deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- BAGONG BUTTONS (PARA SA LAHAT NG RECORDS) ---

    Private Sub btnRestoreAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreAll.Click
        If dgvRecycled.Rows.Count = 0 Then
            MessageBox.Show("Recycle bin is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to restore ALL attendance records from the recycle bin?", "Confirm Restore All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim query As String = "UPDATE dbo.MemberAttendance SET is_deleted = 0 WHERE is_deleted = 1"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected.ToString() & " record(s) restored successfully!", "All Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                LoadRecycledItems() ' I-refresh ang grid
            Catch ex As Exception
                MessageBox.Show("An error occurred while restoring all records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteAll.Click
        If dgvRecycled.Rows.Count = 0 Then
            MessageBox.Show("Recycle bin is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim warningMessage As String = "WARNING: This will permanently delete ALL attendance records in the recycle bin." & vbCrLf & vbCrLf & "This action CANNOT be undone. Are you sure you want to proceed?"
        If MessageBox.Show(warningMessage, "Confirm Permanent Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim query As String = "DELETE FROM dbo.MemberAttendance WHERE is_deleted = 1"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected.ToString() & " record(s) permanently deleted.", "All Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                LoadRecycledItems() ' I-refresh ang grid
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting all records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- CLOSE BUTTON ---
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class