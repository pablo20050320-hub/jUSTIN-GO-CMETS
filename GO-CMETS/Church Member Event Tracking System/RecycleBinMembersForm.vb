Imports System.Data.SqlClient

Public Class RecycleBinMembersForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub RecycleBinMembersForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Members - Recycle Bin"
        LoadRecycledItems()
    End Sub

    Private Sub LoadRecycledItems()
        Try
            Using conn As New SqlConnection(connString)
                ' Kinukuha lang ang mga "deleted" members (is_deleted = 1)
                Dim query As String = "SELECT id, last_name, first_name, Ministry, city FROM dbo.memberinfo WHERE is_deleted = 1"
                Using adapter As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRecycledMembersForm.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recycled items: " & ex.Message)
        End Try
    End Sub

    ' --- PANG-ISANG MIYEMBRO LANG ---

    Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestore.Click
        If dgvRecycledMembersForm.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a member to restore.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim studentID As Integer = Convert.ToInt32(dgvRecycledMembersForm.CurrentRow.Cells("id").Value)
        ' Ibinabalik ang miyembro sa dati (is_deleted = 0)
        Dim query As String = "UPDATE dbo.memberinfo SET is_deleted = 0 WHERE id=@id"

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", studentID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Member restored successfully!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRecycledItems()
        Catch ex As Exception
            MessageBox.Show("Error restoring member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeletePermanently_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeletePermanently.Click
        If dgvRecycledMembersForm.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a member to delete permanently.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("This action cannot be undone. Are you sure you want to permanently delete this member's record?", "Confirm Permanent Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim studentID As Integer = Convert.ToInt32(dgvRecycledMembersForm.CurrentRow.Cells("id").Value)
            ' Ito na ang tunay na DELETE command
            Dim query As String = "DELETE FROM dbo.memberinfo WHERE id=@id"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", studentID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Member permanently deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRecycledItems()
            Catch ex As Exception
                MessageBox.Show("Error permanently deleting member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- BAGONG BUTTONS (PARA SA LAHAT NG MIYEMBRO) ---

    Private Sub btnRestoreAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreAll.Click
        If dgvRecycledMembersForm.Rows.Count = 0 Then
            MessageBox.Show("Recycle bin is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to restore ALL members from the recycle bin?", "Confirm Restore All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Query para i-update ang LAHAT ng miyembro na may is_deleted = 1
            Dim query As String = "UPDATE dbo.memberinfo SET is_deleted = 0 WHERE is_deleted = 1"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected.ToString() & " member(s) restored successfully!", "All Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                LoadRecycledItems() ' I-refresh ang grid
            Catch ex As Exception
                MessageBox.Show("An error occurred while restoring all members: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteAll.Click
        If dgvRecycledMembersForm.Rows.Count = 0 Then
            MessageBox.Show("Recycle bin is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim warningMessage As String = "WARNING: This will permanently delete ALL members in the recycle bin." & vbCrLf & vbCrLf & "This action CANNOT be undone. Are you sure you want to proceed?"
        If MessageBox.Show(warningMessage, "Confirm Permanent Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            ' Query para burahin ang LAHAT ng miyembro na may is_deleted = 1
            Dim query As String = "DELETE FROM dbo.memberinfo WHERE is_deleted = 1"

            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected.ToString() & " member(s) permanently deleted.", "All Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                LoadRecycledItems() ' I-refresh ang grid
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting all members: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- IBA PANG EVENTS ---

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class