<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceFillvb
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
        Me.txTFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbEventName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnSaveAttendance = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnAddToList = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNewEvent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTimeIn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DTPEventDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAttendanceID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRaffleID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txTFullName
        '
        Me.txTFullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txTFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txTFullName.DefaultText = ""
        Me.txTFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txTFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txTFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txTFullName.DisabledState.Parent = Me.txTFullName
        Me.txTFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txTFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txTFullName.FocusedState.Parent = Me.txTFullName
        Me.txTFullName.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTFullName.ForeColor = System.Drawing.Color.Black
        Me.txTFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txTFullName.HoverState.Parent = Me.txTFullName
        Me.txTFullName.Location = New System.Drawing.Point(246, 283)
        Me.txTFullName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txTFullName.Name = "txTFullName"
        Me.txTFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txTFullName.PlaceholderText = ""
        Me.txTFullName.SelectedText = ""
        Me.txTFullName.ShadowDecoration.Parent = Me.txTFullName
        Me.txTFullName.Size = New System.Drawing.Size(299, 36)
        Me.txTFullName.TabIndex = 2
        '
        'cmbEventName
        '
        Me.cmbEventName.BackColor = System.Drawing.Color.Transparent
        Me.cmbEventName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEventName.FocusedColor = System.Drawing.Color.Empty
        Me.cmbEventName.FocusedState.Parent = Me.cmbEventName
        Me.cmbEventName.Font = New System.Drawing.Font("LEMON MILK", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEventName.ForeColor = System.Drawing.Color.Black
        Me.cmbEventName.FormattingEnabled = True
        Me.cmbEventName.HoverState.Parent = Me.cmbEventName
        Me.cmbEventName.ItemHeight = 30
        Me.cmbEventName.Items.AddRange(New Object() {"KIDS FELLOWSHEEP", "YOUTH FELLOWSHIP", "MIDWEEK SERVICE", "SUNDAY DIVINE WORSHIP SERVICE"})
        Me.cmbEventName.ItemsAppearance.Parent = Me.cmbEventName
        Me.cmbEventName.Location = New System.Drawing.Point(246, 355)
        Me.cmbEventName.Name = "cmbEventName"
        Me.cmbEventName.ShadowDecoration.Parent = Me.cmbEventName
        Me.cmbEventName.Size = New System.Drawing.Size(299, 36)
        Me.cmbEventName.TabIndex = 4
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStatus.FocusedState.Parent = Me.cmbStatus
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.HoverState.Parent = Me.cmbStatus
        Me.cmbStatus.ItemHeight = 30
        Me.cmbStatus.Items.AddRange(New Object() {"PRESENT", "LATE", "ABSENT"})
        Me.cmbStatus.ItemsAppearance.Parent = Me.cmbStatus
        Me.cmbStatus.Location = New System.Drawing.Point(628, 283)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShadowDecoration.Parent = Me.cmbStatus
        Me.cmbStatus.Size = New System.Drawing.Size(299, 36)
        Me.cmbStatus.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnSaveAttendance)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 563)
        Me.Panel1.TabIndex = 180
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(177, 175)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 178
        Me.PictureBox3.TabStop = False
        '
        'btnSaveAttendance
        '
        Me.btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSaveAttendance.FlatAppearance.BorderSize = 0
        Me.btnSaveAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSaveAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAttendance.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAttendance.ForeColor = System.Drawing.Color.White
        Me.btnSaveAttendance.Image = Global.STUDENTINFO.My.Resources.Resources.add
        Me.btnSaveAttendance.Location = New System.Drawing.Point(-1, 229)
        Me.btnSaveAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveAttendance.Name = "btnSaveAttendance"
        Me.btnSaveAttendance.Size = New System.Drawing.Size(177, 58)
        Me.btnSaveAttendance.TabIndex = 125
        Me.btnSaveAttendance.Text = "         SAVE "
        Me.btnSaveAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveAttendance.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Global.STUDENTINFO.My.Resources.Resources.bin
        Me.btnClear.Location = New System.Drawing.Point(-7, 326)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(198, 58)
        Me.btnClear.TabIndex = 124
        Me.btnClear.Text = "       CLEAR"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.DASHBOARDDD
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.btnAddToList)
        Me.Guna2Panel1.Controls.Add(Me.txtNewEvent)
        Me.Guna2Panel1.Controls.Add(Me.btnBack)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.txtTimeIn)
        Me.Guna2Panel1.Controls.Add(Me.DTPEventDate)
        Me.Guna2Panel1.Controls.Add(Me.lblFullName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.txtAttendanceID)
        Me.Guna2Panel1.Controls.Add(Me.txtRaffleID)
        Me.Guna2Panel1.Location = New System.Drawing.Point(181, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(849, 563)
        Me.Guna2Panel1.TabIndex = 184
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(65, 401)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(147, 19)
        Me.Guna2HtmlLabel5.TabIndex = 220
        Me.Guna2HtmlLabel5.Text = "ADD NEW EVENT NAME:"
        '
        'btnAddToList
        '
        Me.btnAddToList.BackColor = System.Drawing.Color.Transparent
        Me.btnAddToList.BorderRadius = 10
        Me.btnAddToList.CheckedState.Parent = Me.btnAddToList
        Me.btnAddToList.CustomImages.Parent = Me.btnAddToList
        Me.btnAddToList.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAddToList.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToList.ForeColor = System.Drawing.Color.White
        Me.btnAddToList.HoverState.Parent = Me.btnAddToList
        Me.btnAddToList.Image = Global.STUDENTINFO.My.Resources.Resources.add_event
        Me.btnAddToList.Location = New System.Drawing.Point(670, 499)
        Me.btnAddToList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.ShadowDecoration.Parent = Me.btnAddToList
        Me.btnAddToList.Size = New System.Drawing.Size(158, 46)
        Me.btnAddToList.TabIndex = 219
        Me.btnAddToList.Text = "Add New Event"
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
        Me.txtNewEvent.Location = New System.Drawing.Point(65, 419)
        Me.txtNewEvent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewEvent.Name = "txtNewEvent"
        Me.txtNewEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewEvent.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtNewEvent.PlaceholderText = ""
        Me.txtNewEvent.SelectedText = ""
        Me.txtNewEvent.ShadowDecoration.Parent = Me.txtNewEvent
        Me.txtNewEvent.Size = New System.Drawing.Size(299, 36)
        Me.txtNewEvent.TabIndex = 185
        '
        'btnBack
        '
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.Maroon
        Me.btnBack.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBack.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnBack.Location = New System.Drawing.Point(798, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(39, 27)
        Me.btnBack.TabIndex = 183
        Me.btnBack.Text = "X"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(447, 334)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(50, 19)
        Me.Guna2HtmlLabel4.TabIndex = 186
        Me.Guna2HtmlLabel4.Text = "TIME IN:"
        '
        'txtTimeIn
        '
        Me.txtTimeIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeIn.DefaultText = "EX. 12:30 PM"
        Me.txtTimeIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTimeIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTimeIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTimeIn.DisabledState.Parent = Me.txtTimeIn
        Me.txtTimeIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTimeIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTimeIn.FocusedState.Parent = Me.txtTimeIn
        Me.txtTimeIn.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeIn.ForeColor = System.Drawing.Color.Black
        Me.txtTimeIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTimeIn.HoverState.Parent = Me.txtTimeIn
        Me.txtTimeIn.Location = New System.Drawing.Point(447, 355)
        Me.txtTimeIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimeIn.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtTimeIn.PlaceholderText = "ex. 12:30 PM"
        Me.txtTimeIn.SelectedText = ""
        Me.txtTimeIn.SelectionStart = 12
        Me.txtTimeIn.ShadowDecoration.Parent = Me.txtTimeIn
        Me.txtTimeIn.Size = New System.Drawing.Size(299, 36)
        Me.txtTimeIn.TabIndex = 185
        '
        'DTPEventDate
        '
        Me.DTPEventDate.CheckedState.Parent = Me.DTPEventDate
        Me.DTPEventDate.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPEventDate.HoverState.Parent = Me.DTPEventDate
        Me.DTPEventDate.Location = New System.Drawing.Point(447, 406)
        Me.DTPEventDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPEventDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPEventDate.Name = "DTPEventDate"
        Me.DTPEventDate.ShadowDecoration.Parent = Me.DTPEventDate
        Me.DTPEventDate.Size = New System.Drawing.Size(299, 44)
        Me.DTPEventDate.TabIndex = 3
        Me.DTPEventDate.Value = New Date(2025, 8, 30, 12, 20, 58, 231)
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(65, 263)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(76, 19)
        Me.lblFullName.TabIndex = 184
        Me.lblFullName.Text = "FULL NAME:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(447, 258)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(230, 19)
        Me.Guna2HtmlLabel3.TabIndex = 183
        Me.Guna2HtmlLabel3.Text = "STATUS: eg,. Present, Late, Absent"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("LEMON MILK Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(172, 63)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(530, 70)
        Me.Guna2HtmlLabel1.TabIndex = 181
        Me.Guna2HtmlLabel1.Text = "ATTENDANCE FORM"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(65, 334)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(85, 19)
        Me.Guna2HtmlLabel2.TabIndex = 182
        Me.Guna2HtmlLabel2.Text = "EVENT NAME:"
        '
        'txtAttendanceID
        '
        Me.txtAttendanceID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAttendanceID.DefaultText = ""
        Me.txtAttendanceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAttendanceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAttendanceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAttendanceID.DisabledState.Parent = Me.txtAttendanceID
        Me.txtAttendanceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAttendanceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAttendanceID.FocusedState.Parent = Me.txtAttendanceID
        Me.txtAttendanceID.Font = New System.Drawing.Font("LEMON MILK", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttendanceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAttendanceID.HoverState.Parent = Me.txtAttendanceID
        Me.txtAttendanceID.Location = New System.Drawing.Point(65, 215)
        Me.txtAttendanceID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttendanceID.Name = "txtAttendanceID"
        Me.txtAttendanceID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAttendanceID.PlaceholderText = "ID"
        Me.txtAttendanceID.ReadOnly = True
        Me.txtAttendanceID.SelectedText = ""
        Me.txtAttendanceID.ShadowDecoration.Parent = Me.txtAttendanceID
        Me.txtAttendanceID.Size = New System.Drawing.Size(75, 36)
        Me.txtAttendanceID.TabIndex = 0
        '
        'txtRaffleID
        '
        Me.txtRaffleID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRaffleID.DefaultText = ""
        Me.txtRaffleID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRaffleID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRaffleID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRaffleID.DisabledState.Parent = Me.txtRaffleID
        Me.txtRaffleID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRaffleID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRaffleID.FocusedState.Parent = Me.txtRaffleID
        Me.txtRaffleID.Font = New System.Drawing.Font("LEMON MILK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaffleID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRaffleID.HoverState.Parent = Me.txtRaffleID
        Me.txtRaffleID.Location = New System.Drawing.Point(172, 215)
        Me.txtRaffleID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRaffleID.Name = "txtRaffleID"
        Me.txtRaffleID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRaffleID.PlaceholderText = "Raffle ID"
        Me.txtRaffleID.SelectedText = ""
        Me.txtRaffleID.ShadowDecoration.Parent = Me.txtRaffleID
        Me.txtRaffleID.Size = New System.Drawing.Size(89, 36)
        Me.txtRaffleID.TabIndex = 1
        '
        'AttendanceFillvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 563)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbEventName)
        Me.Controls.Add(Me.txTFullName)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceFillvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttendanceFillvb"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAttendanceID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRaffleID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txTFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DTPEventDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbEventName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveAttendance As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTimeIn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNewEvent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddToList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
