Imports System.Data.SqlClient

Public Class RecycleBinForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub RecycleBinForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Recycle Bin"
        LoadRecycledItems()
    End Sub

    Private Sub LoadRecycledItems()
        Try
            Using conn As New SqlConnection(connString)
                ' Kinukuha ang mga records na naka-mark as deleted (is_deleted = 1)
                Dim query As String = "SELECT attendance_id, member_id, full_name, event_name, event_date FROM dbo.Attendance WHERE is_deleted = 1"
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
        Dim query As String = "UPDATE dbo.Attendance SET is_deleted = 0 WHERE attendance_id=@id"

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", attendanceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Record restored successfully!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRecycledItems() ' I-refresh ang listahan
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
            Dim query As String = "DELETE FROM dbo.Attendance WHERE attendance_id=@id"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", attendanceID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Record permanently deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRecycledItems() ' I-refresh ang listahan
            Catch ex As Exception
                MessageBox.Show("Error permanently deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- BAGONG BUTTONS (PARA SA LAHAT NG RECORDS) ---

    Private Sub btnRestoreAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreAll.Click
        ' Tiyakin na may laman ang recycle bin bago magpatuloy
        If dgvRecycled.Rows.Count = 0 Then
            MessageBox.Show("Recycle bin is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Magtanong muna para sigurado ang user
        If MessageBox.Show("Are you sure you want to restore ALL items from the recycle bin?", "Confirm Restore All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Query para i-update ang LAHAT ng records na may is_deleted = 1
            Dim query As String = "UPDATE dbo.Attendance SET is_deleted = 0 WHERE is_deleted = 1"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery() ' Kunin kung ilang records ang naapektuhan
                        MessageBox.Show(rowsAffected.ToString() & " record(s) restored successfully!", "All Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                LoadRecycledItems() ' I-refresh ang grid (dapat wala nang laman)
            Catch ex As Exception
                MessageBox.Show("An error occurred while restoring all items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteAll.Click
        ' Tiyakin na may laman ang recycle bin
        If dgvRecycled.Rows.Count = 0 Then
            MessageBox.Show("Recycle bin is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Magbigay ng mas seryosong babala dahil permanenteng buburahin ang data
        Dim warningMessage As String = "WARNING: This will permanently delete ALL records in the recycle bin." & vbCrLf & vbCrLf & "This action CANNOT be undone. Are you sure you want to proceed?"
        If MessageBox.Show(warningMessage, "Confirm Permanent Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            ' Query para burahin ang LAHAT ng records na may is_deleted = 1
            Dim query As String = "DELETE FROM dbo.Attendance WHERE is_deleted = 1"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected.ToString() & " record(s) permanently deleted.", "All Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                LoadRecycledItems() ' I-refresh ang grid (dapat wala nang laman)
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting all items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- CLOSE BUTTON ---
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class