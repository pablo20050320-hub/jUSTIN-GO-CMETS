<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewMember = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEventsAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMemberAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRecycle = New Guna.UI2.WinForms.Guna2Button()
        Me.TIMECLOCK = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGenerateID = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WORSHIPTEAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YOUTHMINISTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KIDSMINISTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WOMENSMINISTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENSMINISTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLMINISTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvInfo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnViewMember)
        Me.Panel1.Controls.Add(Me.btnEventsAttendance)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 1080)
        Me.Panel1.TabIndex = 172
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
        Me.btnDashboard.TabIndex = 187
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
        Me.btnViewMember.TabIndex = 186
        Me.btnViewMember.Text = "VIEW MEMBER"
        Me.btnViewMember.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnEventsAttendance
        '
        Me.btnEventsAttendance.CheckedState.Parent = Me.btnEventsAttendance
        Me.btnEventsAttendance.CustomImages.Parent = Me.btnEventsAttendance
        Me.btnEventsAttendance.FillColor = System.Drawing.Color.Maroon
        Me.btnEventsAttendance.Font = New System.Drawing.Font("LEMON MILK Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEventsAttendance.ForeColor = System.Drawing.Color.White
        Me.btnEventsAttendance.HoverState.Parent = Me.btnEventsAttendance
        Me.btnEventsAttendance.Image = Global.STUDENTINFO.My.Resources.Resources.availability__3_
        Me.btnEventsAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEventsAttendance.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnEventsAttendance.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnEventsAttendance.Location = New System.Drawing.Point(0, 545)
        Me.btnEventsAttendance.Name = "btnEventsAttendance"
        Me.btnEventsAttendance.ShadowDecoration.Parent = Me.btnEventsAttendance
        Me.btnEventsAttendance.Size = New System.Drawing.Size(214, 72)
        Me.btnEventsAttendance.TabIndex = 185
        Me.btnEventsAttendance.Text = "EVENTS & ATTENDANCE"
        Me.btnEventsAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEventsAttendance.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.btnLogout.TabIndex = 184
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.TextOffset = New System.Drawing.Point(10, 0)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(-15, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(242, 222)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 178
        Me.PictureBox3.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Panel1.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.DASHBOARDDD
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.btnView)
        Me.Guna2Panel1.Controls.Add(Me.btnMemberAttendance)
        Me.Guna2Panel1.Controls.Add(Me.btnRecycle)
        Me.Guna2Panel1.Controls.Add(Me.TIMECLOCK)
        Me.Guna2Panel1.Controls.Add(Me.btnAdd)
        Me.Guna2Panel1.Controls.Add(Me.btnDelete)
        Me.Guna2Panel1.Controls.Add(Me.btnGenerateID)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel1.Controls.Add(Me.ToolStripContainer1)
        Me.Guna2Panel1.Controls.Add(Me.dgvInfo)
        Me.Guna2Panel1.Controls.Add(Me.txtSearch)
        Me.Guna2Panel1.Location = New System.Drawing.Point(231, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1711, 1090)
        Me.Guna2Panel1.TabIndex = 179
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.BorderRadius = 10
        Me.btnView.CheckedState.Parent = Me.btnView
        Me.btnView.CustomImages.Parent = Me.btnView
        Me.btnView.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnView.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.HoverState.Parent = Me.btnView
        Me.btnView.Image = Global.STUDENTINFO.My.Resources.Resources.details
        Me.btnView.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnView.Location = New System.Drawing.Point(1192, 239)
        Me.btnView.Margin = New System.Windows.Forms.Padding(2)
        Me.btnView.Name = "btnView"
        Me.btnView.ShadowDecoration.Parent = Me.btnView
        Me.btnView.Size = New System.Drawing.Size(191, 46)
        Me.btnView.TabIndex = 223
        Me.btnView.Text = "VIEW INFORMATION"
        '
        'btnMemberAttendance
        '
        Me.btnMemberAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnMemberAttendance.BorderRadius = 10
        Me.btnMemberAttendance.CheckedState.Parent = Me.btnMemberAttendance
        Me.btnMemberAttendance.CustomImages.Parent = Me.btnMemberAttendance
        Me.btnMemberAttendance.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnMemberAttendance.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberAttendance.ForeColor = System.Drawing.Color.White
        Me.btnMemberAttendance.HoverState.Parent = Me.btnMemberAttendance
        Me.btnMemberAttendance.Image = Global.STUDENTINFO.My.Resources.Resources.add_group
        Me.btnMemberAttendance.Location = New System.Drawing.Point(1446, 88)
        Me.btnMemberAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMemberAttendance.Name = "btnMemberAttendance"
        Me.btnMemberAttendance.ShadowDecoration.Parent = Me.btnMemberAttendance
        Me.btnMemberAttendance.Size = New System.Drawing.Size(200, 49)
        Me.btnMemberAttendance.TabIndex = 222
        Me.btnMemberAttendance.Text = "Member Attendance"
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
        Me.btnRecycle.Location = New System.Drawing.Point(1532, 239)
        Me.btnRecycle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecycle.Name = "btnRecycle"
        Me.btnRecycle.ShadowDecoration.Parent = Me.btnRecycle
        Me.btnRecycle.Size = New System.Drawing.Size(137, 46)
        Me.btnRecycle.TabIndex = 221
        Me.btnRecycle.Text = "RECYLE BIN"
        '
        'TIMECLOCK
        '
        Me.TIMECLOCK.BackColor = System.Drawing.Color.Transparent
        Me.TIMECLOCK.Font = New System.Drawing.Font("LEMON MILK Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIMECLOCK.Location = New System.Drawing.Point(43, 67)
        Me.TIMECLOCK.Name = "TIMECLOCK"
        Me.TIMECLOCK.Size = New System.Drawing.Size(243, 70)
        Me.TIMECLOCK.TabIndex = 216
        Me.TIMECLOCK.Text = "MEMBERS"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Image = Global.STUDENTINFO.My.Resources.Resources.add_group
        Me.btnAdd.Location = New System.Drawing.Point(908, 239)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(137, 46)
        Me.btnAdd.TabIndex = 215
        Me.btnAdd.Text = "ADD MEMBER"
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
        Me.btnDelete.Location = New System.Drawing.Point(1389, 239)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(137, 46)
        Me.btnDelete.TabIndex = 214
        Me.btnDelete.Text = "DELETE"
        '
        'btnGenerateID
        '
        Me.btnGenerateID.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerateID.BorderRadius = 5
        Me.btnGenerateID.CheckedState.Parent = Me.btnGenerateID
        Me.btnGenerateID.CustomImages.Parent = Me.btnGenerateID
        Me.btnGenerateID.FillColor = System.Drawing.Color.Maroon
        Me.btnGenerateID.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateID.ForeColor = System.Drawing.Color.White
        Me.btnGenerateID.HoverState.Parent = Me.btnGenerateID
        Me.btnGenerateID.Image = Global.STUDENTINFO.My.Resources.Resources.driver_license__2_
        Me.btnGenerateID.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGenerateID.ImageOffset = New System.Drawing.Point(7, 0)
        Me.btnGenerateID.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnGenerateID.Location = New System.Drawing.Point(1446, 25)
        Me.btnGenerateID.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerateID.Name = "btnGenerateID"
        Me.btnGenerateID.ShadowDecoration.Parent = Me.btnGenerateID
        Me.btnGenerateID.Size = New System.Drawing.Size(200, 46)
        Me.btnGenerateID.TabIndex = 178
        Me.btnGenerateID.Text = "       Generate ID"
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
        Me.btnUpdate.Location = New System.Drawing.Point(1050, 239)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(137, 46)
        Me.btnUpdate.TabIndex = 213
        Me.btnUpdate.Text = "UPDATE"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(73, 0)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(20, 273)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(73, 29)
        Me.ToolStripContainer1.TabIndex = 180
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 25)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip
        '
        Me.MenuStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Font = New System.Drawing.Font("LEMON MILK Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ForeColor = System.Drawing.Color.Black
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(61, 23)
        Me.MenuStrip.Text = "MENU"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WORSHIPTEAMToolStripMenuItem, Me.YOUTHMINISTRYToolStripMenuItem, Me.KIDSMINISTRYToolStripMenuItem, Me.WOMENSMINISTRYToolStripMenuItem, Me.MENSMINISTRYToolStripMenuItem, Me.ALLMINISTRYToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'WORSHIPTEAMToolStripMenuItem
        '
        Me.WORSHIPTEAMToolStripMenuItem.Name = "WORSHIPTEAMToolStripMenuItem"
        Me.WORSHIPTEAMToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.WORSHIPTEAMToolStripMenuItem.Text = "WORSHIP TEAM MINISTRY"
        '
        'YOUTHMINISTRYToolStripMenuItem
        '
        Me.YOUTHMINISTRYToolStripMenuItem.Name = "YOUTHMINISTRYToolStripMenuItem"
        Me.YOUTHMINISTRYToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.YOUTHMINISTRYToolStripMenuItem.Text = "YOUTH MINISTRY"
        '
        'KIDSMINISTRYToolStripMenuItem
        '
        Me.KIDSMINISTRYToolStripMenuItem.Name = "KIDSMINISTRYToolStripMenuItem"
        Me.KIDSMINISTRYToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.KIDSMINISTRYToolStripMenuItem.Text = "KIDS MINISTRY"
        '
        'WOMENSMINISTRYToolStripMenuItem
        '
        Me.WOMENSMINISTRYToolStripMenuItem.Name = "WOMENSMINISTRYToolStripMenuItem"
        Me.WOMENSMINISTRYToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.WOMENSMINISTRYToolStripMenuItem.Text = "WOMEN'S MINISTRY"
        '
        'MENSMINISTRYToolStripMenuItem
        '
        Me.MENSMINISTRYToolStripMenuItem.Name = "MENSMINISTRYToolStripMenuItem"
        Me.MENSMINISTRYToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.MENSMINISTRYToolStripMenuItem.Text = "MEN'S MINISTRY"
        '
        'ALLMINISTRYToolStripMenuItem
        '
        Me.ALLMINISTRYToolStripMenuItem.Name = "ALLMINISTRYToolStripMenuItem"
        Me.ALLMINISTRYToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.ALLMINISTRYToolStripMenuItem.Text = "ALL MINISTRY"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'dgvInfo
        '
        Me.dgvInfo.AllowUserToAddRows = False
        Me.dgvInfo.AllowUserToResizeColumns = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInfo.BackgroundColor = System.Drawing.Color.White
        Me.dgvInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInfo.ColumnHeadersHeight = 30
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInfo.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvInfo.EnableHeadersVisualStyles = False
        Me.dgvInfo.GridColor = System.Drawing.Color.Black
        Me.dgvInfo.Location = New System.Drawing.Point(20, 301)
        Me.dgvInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.RowHeadersVisible = False
        Me.dgvInfo.RowTemplate.Height = 28
        Me.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInfo.Size = New System.Drawing.Size(1649, 768)
        Me.dgvInfo.TabIndex = 179
        Me.dgvInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInfo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInfo.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvInfo.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgvInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInfo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInfo.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvInfo.ThemeStyle.ReadOnly = True
        Me.dgvInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInfo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvInfo.ThemeStyle.RowsStyle.Height = 28
        Me.dgvInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.txtSearch.Location = New System.Drawing.Point(20, 225)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(840, 41)
        Me.txtSearch.TabIndex = 177
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGenerateID As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvInfo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents WORSHIPTEAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YOUTHMINISTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KIDSMINISTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WOMENSMINISTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MENSMINISTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ALLMINISTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEventsAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewMember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TIMECLOCK As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnRecycle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMemberAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
End Class
