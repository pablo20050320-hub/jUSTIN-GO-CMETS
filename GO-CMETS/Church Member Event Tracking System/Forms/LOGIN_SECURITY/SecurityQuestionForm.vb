Imports System.Data.SqlClient

Public Class SecurityQuestionForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Sub SecurityQuestionForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ' Step 1: I-load ang security question mula sa database
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT security_question FROM tbl_accounts WHERE username='Admin'"
                Using cmd As New SqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()

                    ' Step 2: I-check kung may nakuhang tanong
                    If result IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(result.ToString()) Then
                        ' Ilagay ang tanong sa TextBox
                        txtSecurityQuestion.Text = result.ToString()

                        ' === User Experience Improvement ===
                        ' Gawing read-only para hindi ma-edit ng user ang tanong
                        txtSecurityQuestion.ReadOnly = True
                        ' Baguhin ang kulay para malaman na hindi ito pwedeng i-type-an
                        txtSecurityQuestion.BackColor = SystemColors.Control

                        ' Ilagay ang cursor sa answer box para makapag-type agad ang user
                        txtAnswer.Focus()
                    Else
                        ' Kung walang naka-set na tanong, magbigay ng error at isara ang form
                        MessageBox.Show("No security question has been set for the Admin account.", "Setup Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("A database error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        ' Step 1: I-check kung may sagot na inilagay
        If String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            MessageBox.Show("Please enter your answer.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Step 2: I-verify ang sagot sa database
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Gumamit ng parameterized query para iwas-SQL injection
                Dim query As String = "SELECT COUNT(*) FROM tbl_accounts WHERE username='Admin' AND security_answer=@ans"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ans", txtAnswer.Text.Trim())

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Step 3: I-check kung tama ang sagot
                    If count > 0 Then
                        ' === TAMANG SAGOT ===
                        MessageBox.Show("Correct answer! You can now reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.Hide() ' Itago muna ang kasalukuyang form

                        ' Buksan ang SetPrivacyPassword form
                        Using setPassForm As New SetPrivacyPassword()
                            setPassForm.ShowDialog()
                        End Using

                        ' Pagkatapos ng lahat, isara na itong form
                        Me.Close()
                    Else
                        ' === MALING SAGOT ===
                        MessageBox.Show("Incorrect answer. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("A database error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        ' Isasara lang nito ang form. Ang Form3 na nagbukas dito ay awtomatikong lalabas ulit.
        Me.Close()
        Form3.Show()
    End Sub
End Class