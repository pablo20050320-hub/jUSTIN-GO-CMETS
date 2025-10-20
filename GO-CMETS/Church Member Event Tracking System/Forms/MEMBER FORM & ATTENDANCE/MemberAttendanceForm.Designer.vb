<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberAttendanceForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAttendance1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DTPDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TIMECLOCK = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Datelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SelectEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KIDSFELLOWSHEEPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YOUTHFELLOWSHIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIDWEEKSERVICEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnBackToMembers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRecycle = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnScan = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvAttendance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAttendance1
        '
        Me.dgvAttendance1.AllowUserToAddRows = False
        Me.dgvAttendance1.AllowUserToDeleteRows = False
        Me.dgvAttendance1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAttendance1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAttendance1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAttendance1.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttendance1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttendance1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttendance1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttendance1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAttendance1.ColumnHeadersHeight = 30
        Me.dgvAttendance1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAttendance1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAttendance1.EnableHeadersVisualStyles = False
        Me.dgvAttendance1.GridColor = System.Drawing.Color.Black
        Me.dgvAttendance1.Location = New System.Drawing.Point(24, 303)
        Me.dgvAttendance1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAttendance1.Name = "dgvAttendance1"
        Me.dgvAttendance1.ReadOnly = True
        Me.dgvAttendance1.RowHeadersVisible = False
        Me.dgvAttendance1.RowTemplate.Height = 28
        Me.dgvAttendance1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAttendance1.Size = New System.Drawing.Size(1856, 716)
        Me.dgvAttendance1.TabIndex = 180
        Me.dgvAttendance1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAttendance1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttendance1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAttendance1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAttendance1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAttendance1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAttendance1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttendance1.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvAttendance1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgvAttendance1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAttendance1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAttendance1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAttendance1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAttendance1.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvAttendance1.ThemeStyle.ReadOnly = True
        Me.dgvAttendance1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttendance1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttendance1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAttendance1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvAttendance1.ThemeStyle.RowsStyle.Height = 28
        Me.dgvAttendance1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAttendance1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DTPDate
        '
        Me.DTPDate.BackColor = System.Drawing.Color.Transparent
        Me.DTPDate.BorderRadius = 15
        Me.DTPDate.BorderThickness = 1
        Me.DTPDate.CheckedState.Parent = Me.DTPDate
        Me.DTPDate.FillColor = System.Drawing.Color.White
        Me.DTPDate.Font = New System.Drawing.Font("LEMON MILK Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPDate.HoverState.Parent = Me.DTPDate
        Me.DTPDate.Location = New System.Drawing.Point(1602, 176)
        Me.DTPDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPDate.Name = "DTPDate"
        Me.DTPDate.ShadowDecoration.Parent = Me.DTPDate
        Me.DTPDate.Size = New System.Drawing.Size(266, 33)
        Me.DTPDate.TabIndex = 182
        Me.DTPDate.Value = New Date(2025, 8, 30, 10, 27, 31, 131)
        '
        'TIMECLOCK
        '
        Me.TIMECLOCK.BackColor = System.Drawing.Color.Transparent
        Me.TIMECLOCK.Font = New System.Drawing.Font("LEMON MILK Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIMECLOCK.Location = New System.Drawing.Point(1392, 43)
        Me.TIMECLOCK.Name = "TIMECLOCK"
        Me.TIMECLOCK.Size = New System.Drawing.Size(333, 70)
        Me.TIMECLOCK.TabIndex = 223
        Me.TIMECLOCK.Text = "00:00:00 PM"
        '
        'Datelbl
        '
        Me.Datelbl.BackColor = System.Drawing.Color.Transparent
        Me.Datelbl.Font = New System.Drawing.Font("LEMON MILK Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.Location = New System.Drawing.Point(1381, 119)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(174, 36)
        Me.Datelbl.TabIndex = 224
        Me.Datelbl.Text = "00:00:00 PM"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SelectEventToolStripMenuItem
        '
        Me.SelectEventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KIDSFELLOWSHEEPToolStripMenuItem, Me.YOUTHFELLOWSHIPToolStripMenuItem, Me.MIDWEEKSERVICEToolStripMenuItem, Me.SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem, Me.ALLToolStripMenuItem})
        Me.SelectEventToolStripMenuItem.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectEventToolStripMenuItem.Name = "SelectEventToolStripMenuItem"
        Me.SelectEventToolStripMenuItem.Size = New System.Drawing.Size(121, 23)
        Me.SelectEventToolStripMenuItem.Text = "Select Event"
        '
        'KIDSFELLOWSHEEPToolStripMenuItem
        '
        Me.KIDSFELLOWSHEEPToolStripMenuItem.Name = "KIDSFELLOWSHEEPToolStripMenuItem"
        Me.KIDSFELLOWSHEEPToolStripMenuItem.Size = New System.Drawing.Size(317, 24)
        Me.KIDSFELLOWSHEEPToolStripMenuItem.Text = "KIDS FELLOWSHEEP"
        '
        'YOUTHFELLOWSHIPToolStripMenuItem
        '
        Me.YOUTHFELLOWSHIPToolStripMenuItem.Name = "YOUTHFELLOWSHIPToolStripMenuItem"
        Me.YOUTHFELLOWSHIPToolStripMenuItem.Size = New System.Drawing.Size(317, 24)
        Me.YOUTHFELLOWSHIPToolStripMenuItem.Text = "YOUTH FELLOWSHIP"
        '
        'MIDWEEKSERVICEToolStripMenuItem
        '
        Me.MIDWEEKSERVICEToolStripMenuItem.Name = "MIDWEEKSERVICEToolStripMenuItem"
        Me.MIDWEEKSERVICEToolStripMenuItem.Size = New System.Drawing.Size(317, 24)
        Me.MIDWEEKSERVICEToolStripMenuItem.Text = "MIDWEEK SERVICE"
        '
        'SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem
        '
        Me.SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem.Name = "SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem"
        Me.SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem.Size = New System.Drawing.Size(317, 24)
        Me.SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem.Text = "SUNDAY DIVINE WORSHIP SERVICE"
        '
        'ALLToolStripMenuItem
        '
        Me.ALLToolStripMenuItem.Name = "ALLToolStripMenuItem"
        Me.ALLToolStripMenuItem.Size = New System.Drawing.Size(317, 24)
        Me.ALLToolStripMenuItem.Text = "ALL"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectEventToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(24, 269)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(129, 27)
        Me.MenuStrip1.TabIndex = 183
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 99)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("LEMON MILK Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 58)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(826, 70)
        Me.Guna2HtmlLabel1.TabIndex = 226
        Me.Guna2HtmlLabel1.Text = "MEMBER EVENTS & ATTENDANCE"
        '
        'btnBackToMembers
        '
        Me.btnBackToMembers.BackColor = System.Drawing.Color.Transparent
        Me.btnBackToMembers.BorderRadius = 10
        Me.btnBackToMembers.CheckedState.Parent = Me.btnBackToMembers
        Me.btnBackToMembers.CustomImages.Parent = Me.btnBackToMembers
        Me.btnBackToMembers.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnBackToMembers.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMembers.ForeColor = System.Drawing.Color.White
        Me.btnBackToMembers.HoverState.Parent = Me.btnBackToMembers
        Me.btnBackToMembers.Image = Global.STUDENTINFO.My.Resources.Resources.check
        Me.btnBackToMembers.Location = New System.Drawing.Point(1649, 238)
        Me.btnBackToMembers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackToMembers.Name = "btnBackToMembers"
        Me.btnBackToMembers.ShadowDecoration.Parent = Me.btnBackToMembers
        Me.btnBackToMembers.Size = New System.Drawing.Size(219, 46)
        Me.btnBackToMembers.TabIndex = 225
        Me.btnBackToMembers.Text = "BACK TO MEMBER LIST"
        '
        'btnRecycle
        '
        Me.btnRecycle.BackColor = System.Drawing.Color.Transparent
        Me.btnRecycle.BorderRadius = 10
        Me.btnRecycle.CheckedState.Parent = Me.btnRecycle
        Me.btnRecycle.CustomImages.Parent = Me.btnRecycle
        Me.btnRecycle.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRecycle.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecycle.ForeColor = System.Drawing.Color.White
        Me.btnRecycle.HoverState.Parent = Me.btnRecycle
        Me.btnRecycle.Image = Global.STUDENTINFO.My.Resources.Resources.recycle
        Me.btnRecycle.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnRecycle.Location = New System.Drawing.Point(1500, 238)
        Me.btnRecycle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecycle.Name = "btnRecycle"
        Me.btnRecycle.ShadowDecoration.Parent = Me.btnRecycle
        Me.btnRecycle.Size = New System.Drawing.Size(137, 46)
        Me.btnRecycle.TabIndex = 222
        Me.btnRecycle.Text = "RECYLE BIN"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderRadius = 10
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Image = Global.STUDENTINFO.My.Resources.Resources.delete
        Me.btnDelete.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnDelete.Location = New System.Drawing.Point(1349, 238)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(137, 46)
        Me.btnDelete.TabIndex = 221
        Me.btnDelete.Text = "DELETE"
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.Transparent
        Me.btnScan.BorderRadius = 10
        Me.btnScan.CheckedState.Parent = Me.btnScan
        Me.btnScan.CustomImages.Parent = Me.btnScan
        Me.btnScan.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnScan.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.ForeColor = System.Drawing.Color.White
        Me.btnScan.HoverState.Parent = Me.btnScan
        Me.btnScan.Image = Global.STUDENTINFO.My.Resources.Resources.check
        Me.btnScan.Location = New System.Drawing.Point(1173, 238)
        Me.btnScan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.ShadowDecoration.Parent = Me.btnScan
        Me.btnScan.Size = New System.Drawing.Size(163, 46)
        Me.btnScan.TabIndex = 219
        Me.btnScan.Text = "SCAN ATTENDANCE"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderColor = System.Drawing.Color.Black
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = Global.STUDENTINFO.My.Resources.Resources.search_icon_png_0
        Me.txtSearch.IconLeftSize = New System.Drawing.Size(30, 20)
        Me.txtSearch.Location = New System.Drawing.Point(24, 214)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(1079, 41)
        Me.txtSearch.TabIndex = 181
        '
        'MemberAttendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnBackToMembers)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.TIMECLOCK)
        Me.Controls.Add(Me.btnRecycle)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.DTPDate)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvAttendance1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MemberAttendanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberAttendanceForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAttendance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAttendance1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DTPDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnScan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRecycle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TIMECLOCK As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Datelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnBackToMembers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SelectEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KIDSFELLOWSHEEPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YOUTHFELLOWSHIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MIDWEEKSERVICEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUNDAYDIVINEWORSHIPSERVICEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
