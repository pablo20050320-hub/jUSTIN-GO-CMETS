<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIDCard
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
        Me.studentNameLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cityLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studentIDLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MemberLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentPic = New System.Windows.Forms.PictureBox()
        Me.qrCodepic = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.studentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrCodepic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'studentNameLabel1
        '
        Me.studentNameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.studentNameLabel1.Font = New System.Drawing.Font("LEMON MILK Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNameLabel1.Location = New System.Drawing.Point(178, 319)
        Me.studentNameLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.studentNameLabel1.Name = "studentNameLabel1"
        Me.studentNameLabel1.Size = New System.Drawing.Size(187, 32)
        Me.studentNameLabel1.TabIndex = 3
        Me.studentNameLabel1.Text = "JUSTIN PAUL GO"
        Me.studentNameLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cityLabel2
        '
        Me.cityLabel2.BackColor = System.Drawing.Color.Transparent
        Me.cityLabel2.Font = New System.Drawing.Font("LEMON MILK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLabel2.Location = New System.Drawing.Point(110, 513)
        Me.cityLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.cityLabel2.Name = "cityLabel2"
        Me.cityLabel2.Size = New System.Drawing.Size(221, 32)
        Me.cityLabel2.TabIndex = 4
        Me.cityLabel2.Text = "Guna2HtmlLabel2"
        Me.cityLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studentIDLabel3
        '
        Me.studentIDLabel3.BackColor = System.Drawing.Color.Transparent
        Me.studentIDLabel3.Font = New System.Drawing.Font("LEMON MILK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDLabel3.Location = New System.Drawing.Point(110, 420)
        Me.studentIDLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.studentIDLabel3.Name = "studentIDLabel3"
        Me.studentIDLabel3.Size = New System.Drawing.Size(220, 32)
        Me.studentIDLabel3.TabIndex = 5
        Me.studentIDLabel3.Text = "Guna2HtmlLabel3"
        Me.studentIDLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MemberLabel4
        '
        Me.MemberLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MemberLabel4.Font = New System.Drawing.Font("LEMON MILK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberLabel4.Location = New System.Drawing.Point(131, 465)
        Me.MemberLabel4.Margin = New System.Windows.Forms.Padding(2)
        Me.MemberLabel4.Name = "MemberLabel4"
        Me.MemberLabel4.Size = New System.Drawing.Size(221, 32)
        Me.MemberLabel4.TabIndex = 6
        Me.MemberLabel4.Text = "Guna2HtmlLabel4"
        Me.MemberLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 422)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 515)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "City:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 467)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ministry:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'studentPic
        '
        Me.studentPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.studentPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.studentPic.Location = New System.Drawing.Point(132, 116)
        Me.studentPic.Margin = New System.Windows.Forms.Padding(2)
        Me.studentPic.Name = "studentPic"
        Me.studentPic.Size = New System.Drawing.Size(272, 190)
        Me.studentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentPic.TabIndex = 8
        Me.studentPic.TabStop = False
        '
        'qrCodepic
        '
        Me.qrCodepic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.qrCodepic.Location = New System.Drawing.Point(671, 42)
        Me.qrCodepic.Margin = New System.Windows.Forms.Padding(2)
        Me.qrCodepic.Name = "qrCodepic"
        Me.qrCodepic.Size = New System.Drawing.Size(290, 214)
        Me.qrCodepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qrCodepic.TabIndex = 7
        Me.qrCodepic.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox2.Image = Global.STUDENTINFO.My.Resources.Resources._2
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(562, 23)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(486, 589)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.Image = Global.STUDENTINFO.My.Resources.Resources._1
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(14, 23)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(518, 589)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND2
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.qrCodepic)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1059, 685)
        Me.Panel1.TabIndex = 12
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BorderRadius = 5
        Me.btnExport.CheckedState.Parent = Me.btnExport
        Me.btnExport.CustomImages.Parent = Me.btnExport
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.HoverState.Parent = Me.btnExport
        Me.btnExport.Location = New System.Drawing.Point(935, 623)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.ShadowDecoration.Parent = Me.btnExport
        Me.btnExport.Size = New System.Drawing.Size(110, 48)
        Me.btnExport.TabIndex = 179
        Me.btnExport.Text = "EXPORT ID"
        '
        'FormIDCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 685)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studentPic)
        Me.Controls.Add(Me.MemberLabel4)
        Me.Controls.Add(Me.studentIDLabel3)
        Me.Controls.Add(Me.cityLabel2)
        Me.Controls.Add(Me.studentNameLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormIDCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormIDCard"
        CType(Me.studentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrCodepic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents qrCodePictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents studentNameLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cityLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentIDLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MemberLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentPictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents qrCodepic As System.Windows.Forms.PictureBox
    Friend WithEvents studentPic As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
