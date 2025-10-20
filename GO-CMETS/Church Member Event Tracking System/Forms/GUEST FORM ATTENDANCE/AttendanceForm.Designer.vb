<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnRecycle = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Datelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TIMECLOCK = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DTPDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KidsFellowSheepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouthFellowShipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MidWeekServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SundayWorshipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvAttendance = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewMember = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEventsAndAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.DASHBOARDDD
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.btnRecycle)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.btnAttendance)
        Me.Guna2Panel1.Controls.Add(Me.btnDelete)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel1.Controls.Add(Me.Datelbl)
        Me.Guna2Panel1.Controls.Add(Me.TIMECLOCK)
        Me.Guna2Panel1.Controls.Add(Me.DTPDate)
        Me.Guna2Panel1.Controls.Add(Me.ToolStripContainer1)
        Me.Guna2Panel1.Controls.Add(Me.dgvAttendance)
        Me.Guna2Panel1.Controls.Add(Me.txtSearch)
        Me.Guna2Panel1.Location = New System.Drawing.Point(227, -19)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1719, 1110)
        Me.Guna2Panel1.TabIndex = 180
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
        Me.btnRecycle.Location = New System.Drawing.Point(1531, 246)
        Me.btnRecycle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecycle.Name = "btnRecycle"
        Me.btnRecycle.ShadowDecoration.Parent = Me.btnRecycle
        Me.btnRecycle.Size = New System.Drawing.Size(137, 46)
        Me.btnRecycle.TabIndex = 220
        Me.btnRecycle.Text = "RECYLE BIN"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("LEMON MILK Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(49, 96)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(782, 70)
        Me.Guna2HtmlLabel1.TabIndex = 219
        Me.Guna2HtmlLabel1.Text = "GUEST EVENTS & ATTENDANCE"
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnAttendance.BorderRadius = 10
        Me.btnAttendance.CheckedState.Parent = Me.btnAttendance
        Me.btnAttendance.CustomImages.Parent = Me.btnAttendance
        Me.btnAttendance.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAttendance.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.HoverState.Parent = Me.btnAttendance
        Me.btnAttendance.Image = Global.STUDENTINFO.My.Resources.Resources.check
        Me.btnAttendance.Location = New System.Drawing.Point(1067, 248)
        Me.btnAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.ShadowDecoration.Parent = Me.btnAttendance
        Me.btnAttendance.Size = New System.Drawing.Size(137, 46)
        Me.btnAttendance.TabIndex = 218
        Me.btnAttendance.Text = "ATTENDANCE"
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
        Me.btnDelete.Location = New System.Drawing.Point(1377, 246)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(137, 46)
        Me.btnDelete.TabIndex = 217
        Me.btnDelete.Text = "DELETE"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderRadius = 10
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Image = Global.STUDENTINFO.My.Resources.Resources.updating
        Me.btnUpdate.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnUpdate.Location = New System.Drawing.Point(1222, 248)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(137, 46)
        Me.btnUpdate.TabIndex = 216
        Me.btnUpdate.Text = "UPDATE"
        '
        'Datelbl
        '
        Me.Datelbl.BackColor = System.Drawing.Color.Transparent
        Me.Datelbl.Font = New System.Drawing.Font("LEMON MILK Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.Location = New System.Drawing.Point(1232, 130)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(174, 36)
        Me.Datelbl.TabIndex = 183
        Me.Datelbl.Text = "00:00:00 PM"
        '
        'TIMECLOCK
        '
        Me.TIMECLOCK.BackColor = System.Drawing.Color.Transparent
        Me.TIMECLOCK.Font = New System.Drawing.Font("LEMON MILK Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIMECLOCK.Location = New System.Drawing.Point(1304, 53)
        Me.TIMECLOCK.Name = "TIMECLOCK"
        Me.TIMECLOCK.Size = New System.Drawing.Size(333, 70)
        Me.TIMECLOCK.TabIndex = 182
        Me.TIMECLOCK.Text = "00:00:00 PM"
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
        Me.DTPDate.Location = New System.Drawing.Point(1398, 197)
        Me.DTPDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPDate.Name = "DTPDate"
        Me.DTPDate.ShadowDecoration.Parent = Me.DTPDate
        Me.DTPDate.Size = New System.Drawing.Size(266, 33)
        Me.DTPDate.TabIndex = 181
        Me.DTPDate.Value = New Date(2025, 8, 30, 10, 27, 31, 131)
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(122, 4)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(20, 295)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(122, 29)
        Me.ToolStripContainer1.TabIndex = 180
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(122, 25)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip
        '
        Me.MenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Font = New System.Drawing.Font("LEMON MILK Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ForeColor = System.Drawing.Color.Black
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(118, 23)
        Me.MenuStrip.Text = "SELECT EVENT"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KidsFellowSheepToolStripMenuItem, Me.YouthFellowShipToolStripMenuItem, Me.MidWeekServiceToolStripMenuItem, Me.SundayWorshipToolStripMenuItem, Me.ALLToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'KidsFellowSheepToolStripMenuItem
        '
        Me.KidsFellowSheepToolStripMenuItem.Name = "KidsFellowSheepToolStripMenuItem"
        Me.KidsFellowSheepToolStripMenuItem.Size = New System.Drawing.Size(309, 24)
        Me.KidsFellowSheepToolStripMenuItem.Text = "KIDS FELLOWSHEEP"
        '
        'YouthFellowShipToolStripMenuItem
        '
        Me.YouthFellowShipToolStripMenuItem.Name = "YouthFellowShipToolStripMenuItem"
        Me.YouthFellowShipToolStripMenuItem.Size = New System.Drawing.Size(309, 24)
        Me.YouthFellowShipToolStripMenuItem.Text = "YOUTH FELLOWSHIP"
        '
        'MidWeekServiceToolStripMenuItem
        '
        Me.MidWeekServiceToolStripMenuItem.Name = "MidWeekServiceToolStripMenuItem"
        Me.MidWeekServiceToolStripMenuItem.Size = New System.Drawing.Size(309, 24)
        Me.MidWeekServiceToolStripMenuItem.Text = "MIDWEEK SERVICE"
        '
        'SundayWorshipToolStripMenuItem
        '
        Me.SundayWorshipToolStripMenuItem.Name = "SundayWorshipToolStripMenuItem"
        Me.SundayWorshipToolStripMenuItem.Size = New System.Drawing.Size(309, 24)
        Me.SundayWorshipToolStripMenuItem.Text = "SUNDAY DIVINE WORSHIP SERVICE"
        '
        'ALLToolStripMenuItem
        '
        Me.ALLToolStripMenuItem.Name = "ALLToolStripMenuItem"
        Me.ALLToolStripMenuItem.Size = New System.Drawing.Size(309, 24)
        Me.ALLToolStripMenuItem.Text = "ALL "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'dgvAttendance
        '
        Me.dgvAttendance.AllowUserToAddRows = False
        Me.dgvAttendance.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvAttendance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAttendance.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAttendance.ColumnHeadersHeight = 25
        Me.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAttendance.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvAttendance.EnableHeadersVisualStyles = False
        Me.dgvAttendance.GridColor = System.Drawing.Color.Black
        Me.dgvAttendance.Location = New System.Drawing.Point(20, 323)
        Me.dgvAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.ReadOnly = True
        Me.dgvAttendance.RowHeadersVisible = False
        Me.dgvAttendance.RowTemplate.Height = 28
        Me.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAttendance.Size = New System.Drawing.Size(1644, 755)
        Me.dgvAttendance.TabIndex = 179
        Me.dgvAttendance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttendance.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAttendance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttendance.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgvAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAttendance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAttendance.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvAttendance.ThemeStyle.ReadOnly = True
        Me.dgvAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttendance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvAttendance.ThemeStyle.RowsStyle.Height = 28
        Me.dgvAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.txtSearch.Location = New System.Drawing.Point(20, 246)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(1022, 41)
        Me.txtSearch.TabIndex = 177
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnViewMember)
        Me.Panel1.Controls.Add(Me.btnEventsAndAttendance)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 1080)
        Me.Panel1.TabIndex = 173
        '
        'btnDashboard
        '
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.Maroon
        Me.btnDashboard.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.STUDENTINFO.My.Resources.Resources.dashboard1
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDashboard.Location = New System.Drawing.Point(-1, 304)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(214, 72)
        Me.btnDashboard.TabIndex = 191
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Text = "DASHBOARD"
        Me.btnDashboard.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnViewMember
        '
        Me.btnViewMember.CheckedState.Parent = Me.btnViewMember
        Me.btnViewMember.CustomImages.Parent = Me.btnViewMember
        Me.btnViewMember.FillColor = System.Drawing.Color.Maroon
        Me.btnViewMember.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMember.ForeColor = System.Drawing.Color.White
        Me.btnViewMember.HoverState.Parent = Me.btnViewMember
        Me.btnViewMember.Image = Global.STUDENTINFO.My.Resources.Resources.people
        Me.btnViewMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewMember.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnViewMember.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnViewMember.Location = New System.Drawing.Point(0, 424)
        Me.btnViewMember.Name = "btnViewMember"
        Me.btnViewMember.ShadowDecoration.Parent = Me.btnViewMember
        Me.btnViewMember.Size = New System.Drawing.Size(214, 72)
        Me.btnViewMember.TabIndex = 190
        Me.btnViewMember.Text = "VIEW MEMBER"
        Me.btnViewMember.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnEventsAndAttendance
        '
        Me.btnEventsAndAttendance.CheckedState.Parent = Me.btnEventsAndAttendance
        Me.btnEventsAndAttendance.CustomImages.Parent = Me.btnEventsAndAttendance
        Me.btnEventsAndAttendance.FillColor = System.Drawing.Color.Maroon
        Me.btnEventsAndAttendance.Font = New System.Drawing.Font("LEMON MILK Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEventsAndAttendance.ForeColor = System.Drawing.Color.White
        Me.btnEventsAndAttendance.HoverState.Parent = Me.btnEventsAndAttendance
        Me.btnEventsAndAttendance.Image = Global.STUDENTINFO.My.Resources.Resources.availability__3_
        Me.btnEventsAndAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEventsAndAttendance.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnEventsAndAttendance.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnEventsAndAttendance.Location = New System.Drawing.Point(0, 545)
        Me.btnEventsAndAttendance.Name = "btnEventsAndAttendance"
        Me.btnEventsAndAttendance.ShadowDecoration.Parent = Me.btnEventsAndAttendance
        Me.btnEventsAndAttendance.Size = New System.Drawing.Size(214, 72)
        Me.btnEventsAndAttendance.TabIndex = 189
        Me.btnEventsAndAttendance.Text = "EVENTS & ATTENDANCE"
        Me.btnEventsAndAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEventsAndAttendance.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnLogout
        '
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.Maroon
        Me.btnLogout.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = Global.STUDENTINFO.My.Resources.Resources.logout__2_
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnLogout.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnLogout.Location = New System.Drawing.Point(0, 807)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(214, 72)
        Me.btnLogout.TabIndex = 188
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.TextOffset = New System.Drawing.Point(10, 0)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(-9, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(234, 211)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 178
        Me.PictureBox3.TabStop = False
        '
        'AttendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttendanceForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents dgvAttendance As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DTPDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TIMECLOCK As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Datelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewMember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEventsAndAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KidsFellowSheepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YouthFellowShipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MidWeekServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SundayWorshipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRecycle As Guna.UI2.WinForms.Guna2Button
End Class
