<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrPopUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHello = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimizeMaximize = New Guna.UI2.WinForms.Guna2Button()
        Me.LogoPic = New System.Windows.Forms.PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblForgetPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ShowHide = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlTitleBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel3.SuspendLayout()
        CType(Me.LogoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        CType(Me.ShowHide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPopUp
        '
        Me.tmrPopUp.Interval = 10
        '
        'tmrHello
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnMinimize)
        Me.Panel3.Controls.Add(Me.btnMinimizeMaximize)
        Me.Panel3.Controls.Add(Me.LogoPic)
        Me.Panel3.Controls.Add(Me.Guna2Button1)
        Me.Panel3.Controls.Add(Me.pnlLogin)
        Me.Panel3.Controls.Add(Me.pnlTitleBar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 641)
        Me.Panel3.TabIndex = 135
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.CheckedState.Parent = Me.btnMinimize
        Me.btnMinimize.CustomImages.Parent = Me.btnMinimize
        Me.btnMinimize.FillColor = System.Drawing.Color.DarkRed
        Me.btnMinimize.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.HoverState.Parent = Me.btnMinimize
        Me.btnMinimize.Image = Global.STUDENTINFO.My.Resources.Resources.minimize__1_
        Me.btnMinimize.Location = New System.Drawing.Point(934, 3)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.PressedColor = System.Drawing.Color.Red
        Me.btnMinimize.ShadowDecoration.Parent = Me.btnMinimize
        Me.btnMinimize.Size = New System.Drawing.Size(31, 22)
        Me.btnMinimize.TabIndex = 138
        '
        'btnMinimizeMaximize
        '
        Me.btnMinimizeMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizeMaximize.CheckedState.Parent = Me.btnMinimizeMaximize
        Me.btnMinimizeMaximize.CustomImages.Parent = Me.btnMinimizeMaximize
        Me.btnMinimizeMaximize.FillColor = System.Drawing.Color.DarkRed
        Me.btnMinimizeMaximize.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizeMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMinimizeMaximize.HoverState.Parent = Me.btnMinimizeMaximize
        Me.btnMinimizeMaximize.Location = New System.Drawing.Point(979, 3)
        Me.btnMinimizeMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizeMaximize.Name = "btnMinimizeMaximize"
        Me.btnMinimizeMaximize.PressedColor = System.Drawing.Color.Red
        Me.btnMinimizeMaximize.ShadowDecoration.Parent = Me.btnMinimizeMaximize
        Me.btnMinimizeMaximize.Size = New System.Drawing.Size(31, 22)
        Me.btnMinimizeMaximize.TabIndex = 137
        '
        'LogoPic
        '
        Me.LogoPic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoPic.BackColor = System.Drawing.Color.Transparent
        Me.LogoPic.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.LogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPic.Location = New System.Drawing.Point(64, 78)
        Me.LogoPic.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoPic.Name = "LogoPic"
        Me.LogoPic.Size = New System.Drawing.Size(490, 479)
        Me.LogoPic.TabIndex = 136
        Me.LogoPic.TabStop = False
        Me.LogoPic.Visible = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2Button1.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(1023, 3)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Red
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(31, 22)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "X"
        '
        'pnlLogin
        '
        Me.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogin.BorderRadius = 25
        Me.pnlLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.pnlLogin.Controls.Add(Me.lblForgetPassword)
        Me.pnlLogin.Controls.Add(Me.ShowHide)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.lblHello)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlLogin.Location = New System.Drawing.Point(610, 137)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.ShadowDecoration.BorderRadius = 50
        Me.pnlLogin.ShadowDecoration.Parent = Me.pnlLogin
        Me.pnlLogin.Size = New System.Drawing.Size(412, 396)
        Me.pnlLogin.TabIndex = 1
        '
        'lblForgetPassword
        '
        Me.lblForgetPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgetPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblForgetPassword.Location = New System.Drawing.Point(167, 366)
        Me.lblForgetPassword.Name = "lblForgetPassword"
        Me.lblForgetPassword.Size = New System.Drawing.Size(95, 17)
        Me.lblForgetPassword.TabIndex = 136
        Me.lblForgetPassword.Text = "Forget Password"
        '
        'ShowHide
        '
        Me.ShowHide.Location = New System.Drawing.Point(302, 229)
        Me.ShowHide.Name = "ShowHide"
        Me.ShowHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ShowHide.ShadowDecoration.Parent = Me.ShowHide
        Me.ShowHide.Size = New System.Drawing.Size(34, 29)
        Me.ShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ShowHide.TabIndex = 135
        Me.ShowHide.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 13
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.Maroon
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(133, 304)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(157, 41)
        Me.btnLogin.TabIndex = 129
        Me.btnLogin.Text = "Login"
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.White
        Me.lblHello.Font = New System.Drawing.Font("LEMON MILK Bold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblHello.Location = New System.Drawing.Point(75, 37)
        Me.lblHello.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(289, 91)
        Me.lblHello.TabIndex = 134
        Me.lblHello.Text = "HELLO!"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(67, 221)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(279, 44)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Black
        Me.txtUsername.BorderRadius = 15
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(67, 160)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(279, 45)
        Me.txtUsername.TabIndex = 0
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTitleBar.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlTitleBar.Controls.Add(Me.Guna2PictureBox3)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.ShadowDecoration.Parent = Me.pnlTitleBar
        Me.pnlTitleBar.Size = New System.Drawing.Size(1062, 30)
        Me.pnlTitleBar.TabIndex = 139
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(38, 25)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 218
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(44, 5)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(36, 19)
        Me.Guna2HtmlLabel1.TabIndex = 219
        Me.Guna2HtmlLabel1.Text = "Login"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1062, 641)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel3.ResumeLayout(False)
        CType(Me.LogoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.ShowHide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPic As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPopUp As System.Windows.Forms.Timer
    Friend WithEvents tmrHello As System.Windows.Forms.Timer
    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ShowHide As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblForgetPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnMinimizeMaximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTitleBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
