Imports System.Data.SqlClient

Public Class Form3
    ' === Para sa Logo Animation ===
    Private rotateAngle As Integer = 0

    ' === Para sa Typing Effect ===
    Dim message As String = "HELLO!"
    Dim index As Integer = 0
    Dim typingForward As Boolean = True

    ' === Connection String ===
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=memberInfo; Trusted_Connection=True;"

    ' === Para sa pag-drag ng borderless form ===
    Private isDragging As Boolean = False
    Private mouseOffset As Point

#Region "Variables Para sa UI Scaling"
    Private originalFormSize As Size
    Private controlOriginalBounds As New Dictionary(Of String, Rectangle)
    Private controlOriginalFonts As New Dictionary(Of String, Single)
#End Region

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        originalFormSize = Me.ClientSize
        RecordInitialStateRecursive(LogoPic)
        RecordInitialStateRecursive(pnlLogin)

        LogoPic.Location = New Point(LogoPic.Location.X, Me.Height)
        LogoPic.Visible = True
        LogoPic.Parent = Panel3

        tmrPopUp.Enabled = True
        lblHello.Text = ""
        tmrHello.Interval = 300
        tmrHello.Enabled = True

        ShowHide.Visible = False
        txtPassword.UseSystemPasswordChar = True
        ShowHide.Image = My.Resources.show

        UpdateMaximizeButtonImage()
    End Sub

#Region "Custom Window Controls, Dragging, at UI Scaling Logic"

    Private Sub Form3_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Return
        UpdateMaximizeButtonImage()

        Dim xRatio As Single = CSng(Me.ClientSize.Width) / originalFormSize.Width
        Dim yRatio As Single = CSng(Me.ClientSize.Height) / originalFormSize.Height

        ScaleControlRecursive(LogoPic, xRatio, yRatio)
        ScaleControlRecursive(pnlLogin, xRatio, yRatio)
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

    Private Sub btnMinimize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMinimizeMaximize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinimizeMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub UpdateMaximizeButtonImage()
        If Me.WindowState = FormWindowState.Maximized Then
            btnMinimizeMaximize.Image = My.Resources.minimize
        Else
            btnMinimizeMaximize.Image = My.Resources.maximize
        End If
    End Sub

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
#End Region

#Region "Application Logic (Animations, Login, etc.)"

    Private Sub tmrPopUp_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrPopUp.Tick
        If controlOriginalBounds.ContainsKey(LogoPic.Name) Then
            Dim finalY As Integer = controlOriginalBounds(LogoPic.Name).Y
            If LogoPic.Location.Y > finalY Then
                LogoPic.Location = New Point(LogoPic.Location.X, LogoPic.Location.Y - 15)
            Else
                tmrPopUp.Enabled = False
                Form3_Resize(Nothing, Nothing)
            End If
        Else
            tmrPopUp.Enabled = False
        End If
    End Sub

    Private Sub tmrHello_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrHello.Tick
        If typingForward Then
            If lblHello.Text.Length < message.Length Then
                lblHello.Text = message.Substring(0, lblHello.Text.Length + 1)
            Else
                typingForward = False
            End If
        Else
            If lblHello.Text.Length > 0 Then
                lblHello.Text = lblHello.Text.Substring(0, lblHello.Text.Length - 1)
            Else
                typingForward = True
            End If
        End If
    End Sub

    Private Sub ShowHide_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShowHide.Click
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
            ShowHide.Image = My.Resources.hide
        Else
            txtPassword.UseSystemPasswordChar = True
            ShowHide.Image = My.Resources.show
        End If
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.Enter
        ShowHide.Visible = True
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.Leave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            ShowHide.Visible = False
            txtPassword.UseSystemPasswordChar = True
            ShowHide.Image = My.Resources.show
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        If username = "" OrElse password = "" Then
            ShowError("Please enter username and password.", "Error")
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM dbo.tbl_accounts WHERE username=@uname AND password=@pass"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uname", "Admin")
                    cmd.Parameters.AddWithValue("@pass", password)
                    If CInt(cmd.ExecuteScalar()) > 0 Then
                        ShowInfo("Login successful!", "Success")
                        Me.Hide()
                        Dim dash As New DashboardForm()
                        dash.Show()
                    Else
                        ShowError("Invalid Admin password. Please try again.", "Login Failed")
                        txtPassword.Clear()
                        txtUsername.Text = "Admin"
                        txtUsername.Enabled = False
                        txtPassword.Focus()
                        ShowHide.Visible = False
                        txtPassword.UseSystemPasswordChar = True
                        ShowHide.Image = My.Resources.show
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowError("Database Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub

    Private Sub lblForgetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblForgetPassword.Click
        Me.Hide()
        Using securityForm As New SecurityQuestionForm()
            securityForm.ShowDialog()
        End Using
        txtPassword.Clear()
        ShowHide.Visible = False
        txtPassword.UseSystemPasswordChar = True
        ShowHide.Image = My.Resources.show
        Me.Show()
        txtPassword.Focus()
    End Sub

    Private Sub ShowInfo(ByVal msg As String, ByVal title As String)
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowError(ByVal msg As String, ByVal title As String)
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region

End Class