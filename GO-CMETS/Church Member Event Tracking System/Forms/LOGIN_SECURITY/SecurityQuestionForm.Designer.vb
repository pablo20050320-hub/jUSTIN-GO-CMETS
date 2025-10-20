<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityQuestionForm
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSecurityQuestion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAnswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("LEMON MILK", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(116, 26)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(117, 18)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "Security Question:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("LEMON MILK", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(117, 108)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(54, 18)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Answer:"
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 5
        Me.btnOk.CheckedState.Parent = Me.btnOk
        Me.btnOk.CustomImages.Parent = Me.btnOk
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.HoverState.Parent = Me.btnOk
        Me.btnOk.Location = New System.Drawing.Point(272, 205)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShadowDecoration.Parent = Me.btnOk
        Me.btnOk.Size = New System.Drawing.Size(113, 38)
        Me.btnOk.TabIndex = 179
        Me.btnOk.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(108, 205)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(113, 38)
        Me.btnCancel.TabIndex = 180
        Me.btnCancel.Text = "CANCEL"
        '
        'txtSecurityQuestion
        '
        Me.txtSecurityQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtSecurityQuestion.BorderColor = System.Drawing.Color.Black
        Me.txtSecurityQuestion.BorderRadius = 15
        Me.txtSecurityQuestion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecurityQuestion.DefaultText = ""
        Me.txtSecurityQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecurityQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecurityQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecurityQuestion.DisabledState.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecurityQuestion.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtSecurityQuestion.FocusedState.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityQuestion.ForeColor = System.Drawing.Color.Black
        Me.txtSecurityQuestion.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtSecurityQuestion.HoverState.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.Location = New System.Drawing.Point(106, 49)
        Me.txtSecurityQuestion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSecurityQuestion.Name = "txtSecurityQuestion"
        Me.txtSecurityQuestion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecurityQuestion.PlaceholderText = " Security Question"
        Me.txtSecurityQuestion.ReadOnly = True
        Me.txtSecurityQuestion.SelectedText = ""
        Me.txtSecurityQuestion.ShadowDecoration.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.Size = New System.Drawing.Size(279, 45)
        Me.txtSecurityQuestion.TabIndex = 181
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.Transparent
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
        Me.txtAnswer.Location = New System.Drawing.Point(108, 127)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAnswer.PlaceholderText = "Answer"
        Me.txtAnswer.SelectedText = ""
        Me.txtAnswer.ShadowDecoration.Parent = Me.txtAnswer
        Me.txtAnswer.Size = New System.Drawing.Size(277, 45)
        Me.txtAnswer.TabIndex = 182
        '
        'SecurityQuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.DASHBOARDDD
        Me.ClientSize = New System.Drawing.Size(494, 262)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtSecurityQuestion)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SecurityQuestionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecurityQuestionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSecurityQuestion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAnswer As Guna.UI2.WinForms.Guna2TextBox
End Class
