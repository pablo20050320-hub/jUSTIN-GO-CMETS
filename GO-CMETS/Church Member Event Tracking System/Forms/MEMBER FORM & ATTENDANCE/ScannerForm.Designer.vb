<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScannerForm
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
        Me.picCameraFeed = New System.Windows.Forms.PictureBox()
        Me.cmbCurrentEvent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.scanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnOpenCloseCamera = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNewEvent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddEvent = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.picCameraFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCameraFeed
        '
        Me.picCameraFeed.BackColor = System.Drawing.Color.Black
        Me.picCameraFeed.Location = New System.Drawing.Point(207, 160)
        Me.picCameraFeed.Name = "picCameraFeed"
        Me.picCameraFeed.Size = New System.Drawing.Size(569, 390)
        Me.picCameraFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCameraFeed.TabIndex = 0
        Me.picCameraFeed.TabStop = False
        '
        'cmbCurrentEvent
        '
        Me.cmbCurrentEvent.BackColor = System.Drawing.Color.Transparent
        Me.cmbCurrentEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCurrentEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurrentEvent.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCurrentEvent.FocusedState.Parent = Me.cmbCurrentEvent
        Me.cmbCurrentEvent.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurrentEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCurrentEvent.FormattingEnabled = True
        Me.cmbCurrentEvent.HoverState.Parent = Me.cmbCurrentEvent
        Me.cmbCurrentEvent.ItemHeight = 30
        Me.cmbCurrentEvent.ItemsAppearance.Parent = Me.cmbCurrentEvent
        Me.cmbCurrentEvent.Location = New System.Drawing.Point(207, 94)
        Me.cmbCurrentEvent.Name = "cmbCurrentEvent"
        Me.cmbCurrentEvent.ShadowDecoration.Parent = Me.cmbCurrentEvent
        Me.cmbCurrentEvent.Size = New System.Drawing.Size(249, 36)
        Me.cmbCurrentEvent.TabIndex = 2
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(207, 65)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(118, 23)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "Select Event"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(440, 603)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(133, 22)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Guna2HtmlLabel3"
        Me.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(442, 567)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(27, 27)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "---"
        Me.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scanTimer
        '
        Me.scanTimer.Interval = 500
        '
        'btnOpenCloseCamera
        '
        Me.btnOpenCloseCamera.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenCloseCamera.BorderRadius = 10
        Me.btnOpenCloseCamera.CheckedState.Parent = Me.btnOpenCloseCamera
        Me.btnOpenCloseCamera.CustomImages.Parent = Me.btnOpenCloseCamera
        Me.btnOpenCloseCamera.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnOpenCloseCamera.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCloseCamera.ForeColor = System.Drawing.Color.White
        Me.btnOpenCloseCamera.HoverState.Parent = Me.btnOpenCloseCamera
        Me.btnOpenCloseCamera.Location = New System.Drawing.Point(781, 615)
        Me.btnOpenCloseCamera.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpenCloseCamera.Name = "btnOpenCloseCamera"
        Me.btnOpenCloseCamera.ShadowDecoration.Parent = Me.btnOpenCloseCamera
        Me.btnOpenCloseCamera.Size = New System.Drawing.Size(163, 46)
        Me.btnOpenCloseCamera.TabIndex = 220
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(483, 74)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(161, 19)
        Me.Guna2HtmlLabel5.TabIndex = 222
        Me.Guna2HtmlLabel5.Text = "ADD NEW EVENT NAME:"
        '
        'txtNewEvent
        '
        Me.txtNewEvent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewEvent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewEvent.DefaultText = ""
        Me.txtNewEvent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewEvent.DisabledState.Parent = Me.txtNewEvent
        Me.txtNewEvent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewEvent.FocusedState.Parent = Me.txtNewEvent
        Me.txtNewEvent.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewEvent.ForeColor = System.Drawing.Color.Black
        Me.txtNewEvent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewEvent.HoverState.Parent = Me.txtNewEvent
        Me.txtNewEvent.Location = New System.Drawing.Point(483, 94)
        Me.txtNewEvent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewEvent.Name = "txtNewEvent"
        Me.txtNewEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewEvent.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtNewEvent.PlaceholderText = ""
        Me.txtNewEvent.SelectedText = ""
        Me.txtNewEvent.ShadowDecoration.Parent = Me.txtNewEvent
        Me.txtNewEvent.Size = New System.Drawing.Size(240, 36)
        Me.txtNewEvent.TabIndex = 221
        '
        'btnAddEvent
        '
        Me.btnAddEvent.BackColor = System.Drawing.Color.Transparent
        Me.btnAddEvent.BorderRadius = 10
        Me.btnAddEvent.CheckedState.Parent = Me.btnAddEvent
        Me.btnAddEvent.CustomImages.Parent = Me.btnAddEvent
        Me.btnAddEvent.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAddEvent.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEvent.ForeColor = System.Drawing.Color.White
        Me.btnAddEvent.HoverState.Parent = Me.btnAddEvent
        Me.btnAddEvent.Image = Global.STUDENTINFO.My.Resources.Resources.add_event
        Me.btnAddEvent.Location = New System.Drawing.Point(729, 94)
        Me.btnAddEvent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.ShadowDecoration.Parent = Me.btnAddEvent
        Me.btnAddEvent.Size = New System.Drawing.Size(144, 36)
        Me.btnAddEvent.TabIndex = 223
        Me.btnAddEvent.Text = "Add New Event"
        '
        'ScannerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(984, 686)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.txtNewEvent)
        Me.Controls.Add(Me.btnOpenCloseCamera)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.cmbCurrentEvent)
        Me.Controls.Add(Me.picCameraFeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ScannerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScannerForm"
        CType(Me.picCameraFeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCameraFeed As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCurrentEvent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents scanTimer As System.Windows.Forms.Timer
    Friend WithEvents btnOpenCloseCamera As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNewEvent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddEvent As Guna.UI2.WinForms.Guna2Button
End Class
