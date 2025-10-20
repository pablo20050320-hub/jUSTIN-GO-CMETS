Imports System.Data.SqlClient

Public Class SetPrivacyPassword
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If txtNewPassword.Text <> txtReTypePassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtMakeSecurityQuestion.Text) OrElse String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            MessageBox.Show("Please provide a security question and answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Upsert logic: UPDATE kung mayroon, INSERT kung wala.
                Dim query As String = "IF EXISTS (SELECT 1 FROM tbl_accounts WHERE username='Admin') " &
                                      "UPDATE tbl_accounts SET password=@pass, security_question=@q, security_answer=@ans WHERE username='Admin' " &
                                      "ELSE " &
                                      "INSERT INTO tbl_accounts (username, password, security_question, security_answer) VALUES ('Admin', @pass, @q, @ans)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pass", txtNewPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@q", txtMakeSecurityQuestion.Text.Trim())
                    cmd.Parameters.AddWithValue("@ans", txtAnswer.Text.Trim())
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Password and Security Question saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Isara ang form. Awtomatikong babalik sa dati.
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        ' Isara lang ang form.
        Me.Close()
        Form3.Show()
    End Sub
End Class