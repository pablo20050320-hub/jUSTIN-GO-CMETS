<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetPrivacyPassword
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAnswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMakeSecurityQuestion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtReTypePassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Guna2Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(-78, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1078, 604)
        Me.Panel3.TabIndex = 136
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 25
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Panel1.Controls.Add(Me.btnCancel)
        Me.Guna2Panel1.Controls.Add(Me.txtAnswer)
        Me.Guna2Panel1.Controls.Add(Me.txtMakeSecurityQuestion)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.btnSave)
        Me.Guna2Panel1.Controls.Add(Me.txtReTypePassword)
        Me.Guna2Panel1.Controls.Add(Me.txtNewPassword)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Guna2Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.Location = New System.Drawing.Point(247, 36)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 50
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(641, 527)
        Me.Guna2Panel1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 13
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(135, 410)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(157, 41)
        Me.btnCancel.TabIndex = 139
        Me.btnCancel.Text = "Cancel"
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderColor = System.Drawing.Color.Black
        Me.txtAnswer.BorderRadius = 15
        Me.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer.DefaultText = ""
        Me.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer.DisabledState.Parent = Me.txtAnswer
        Me.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtAnswer.FocusedState.Parent = Me.txtAnswer
        Me.txtAnswer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtAnswer.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtAnswer.HoverState.Parent = Me.txtAnswer
        Me.txtAnswer.Location = New System.Drawing.Point(183, 312)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAnswer.PlaceholderText = "Answer"
        Me.txtAnswer.SelectedText = ""
        Me.txtAnswer.ShadowDecoration.Parent = Me.txtAnswer
        Me.txtAnswer.Size = New System.Drawing.Size(279, 45)
        Me.txtAnswer.TabIndex = 138
        '
        'txtMakeSecurityQuestion
        '
        Me.txtMakeSecurityQuestion.BorderColor = System.Drawing.Color.Black
        Me.txtMakeSecurityQuestion.BorderRadius = 15
        Me.txtMakeSecurityQuestion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMakeSecurityQuestion.DefaultText = ""
        Me.txtMakeSecurityQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMakeSecurityQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMakeSecurityQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMakeSecurityQuestion.DisabledState.Parent = Me.txtMakeSecurityQuestion
        Me.txtMakeSecurityQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMakeSecurityQuestion.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtMakeSecurityQuestion.FocusedState.Parent = Me.txtMakeSecurityQuestion
        Me.txtMakeSecurityQuestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMakeSecurityQuestion.ForeColor = System.Drawing.Color.Black
        Me.txtMakeSecurityQuestion.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtMakeSecurityQuestion.HoverState.Parent = Me.txtMakeSecurityQuestion
        Me.txtMakeSecurityQuestion.Location = New System.Drawing.Point(183, 247)
        Me.txtMakeSecurityQuestion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMakeSecurityQuestion.Name = "txtMakeSecurityQuestion"
        Me.txtMakeSecurityQuestion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMakeSecurityQuestion.PlaceholderText = "Make Security Question"
        Me.txtMakeSecurityQuestion.SelectedText = ""
        Me.txtMakeSecurityQuestion.ShadowDecoration.Parent = Me.txtMakeSecurityQuestion
        Me.txtMakeSecurityQuestion.Size = New System.Drawing.Size(279, 45)
        Me.txtMakeSecurityQuestion.TabIndex = 137
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(418, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PictureBox1.ShadowDecoration.Parent = Me.PictureBox1
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(418, 191)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PictureBox2.ShadowDecoration.Parent = Me.PictureBox2
        Me.PictureBox2.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 135
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 13
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(343, 410)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(157, 41)
        Me.btnSave.TabIndex = 129
        Me.btnSave.Text = "Save"
        '
        'txtReTypePassword
        '
        Me.txtReTypePassword.BorderColor = System.Drawing.Color.Black
        Me.txtReTypePassword.BorderRadius = 15
        Me.txtReTypePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReTypePassword.DefaultText = ""
        Me.txtReTypePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReTypePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReTypePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReTypePassword.DisabledState.Parent = Me.txtReTypePassword
        Me.txtReTypePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReTypePassword.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtReTypePassword.FocusedState.Parent = Me.txtReTypePassword
        Me.txtReTypePassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReTypePassword.ForeColor = System.Drawing.Color.Black
        Me.txtReTypePassword.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtReTypePassword.HoverState.Parent = Me.txtReTypePassword
        Me.txtReTypePassword.Location = New System.Drawing.Point(183, 183)
        Me.txtReTypePassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReTypePassword.Name = "txtReTypePassword"
        Me.txtReTypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReTypePassword.PlaceholderText = "Re-type new password"
        Me.txtReTypePassword.SelectedText = ""
        Me.txtReTypePassword.ShadowDecoration.Parent = Me.txtReTypePassword
        Me.txtReTypePassword.Size = New System.Drawing.Size(279, 44)
        Me.txtReTypePassword.TabIndex = 1
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderColor = System.Drawing.Color.Black
        Me.txtNewPassword.BorderRadius = 15
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.Parent = Me.txtNewPassword
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtNewPassword.FocusedState.Parent = Me.txtNewPassword
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtNewPassword.HoverState.Parent = Me.txtNewPassword
        Me.txtNewPassword.Location = New System.Drawing.Point(183, 119)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPassword.PlaceholderText = "New password"
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.ShadowDecoration.Parent = Me.txtNewPassword
        Me.txtNewPassword.Size = New System.Drawing.Size(279, 45)
        Me.txtNewPassword.TabIndex = 0
        '
        'txtAswer
        '
        Me.txtAswer.BorderColor = System.Drawing.Color.Black
        Me.txtAswer.BorderRadius = 15
        Me.txtAswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAswer.DefaultText = ""
        Me.txtAswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAswer.DisabledState.Parent = Me.txtAswer
        Me.txtAswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAswer.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtAswer.FocusedState.Parent = Me.txtAswer
        Me.txtAswer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAswer.ForeColor = System.Drawing.Color.Black
        Me.txtAswer.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtAswer.HoverState.Parent = Me.txtAswer
        Me.txtAswer.Location = New System.Drawing.Point(183, 312)
        Me.txtAswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAswer.Name = "txtAswer"
        Me.txtAswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAswer.PlaceholderText = "Answer"
        Me.txtAswer.SelectedText = ""
        Me.txtAswer.ShadowDecoration.Parent = Me.txtAswer
        Me.txtAswer.Size = New System.Drawing.Size(279, 45)
        Me.txtAswer.TabIndex = 138
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 13
        Me.btnOk.CheckedState.Parent = Me.btnOk
        Me.btnOk.CustomImages.Parent = Me.btnOk
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.HoverState.Parent = Me.btnOk
        Me.btnOk.Location = New System.Drawing.Point(242, 411)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShadowDecoration.Parent = Me.btnOk
        Me.btnOk.Size = New System.Drawing.Size(157, 41)
        Me.btnOk.TabIndex = 129
        Me.btnOk.Text = "OK"
        '
        'SetPrivacyPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 604)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetPrivacyPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SetPrivacyPassword"
        Me.Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtReTypePassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtAnswer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMakeSecurityQuestion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAswer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
