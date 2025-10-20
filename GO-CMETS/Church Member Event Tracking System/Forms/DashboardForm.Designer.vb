<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTitleBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimizeMaximize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel13 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlStatistics = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblHighestTurnoutEvent = New System.Windows.Forms.Label()
        Me.lblAverageTurnout = New System.Windows.Forms.Label()
        Me.lblTotalAttendanceMonth = New System.Windows.Forms.Label()
        Me.lblEventsThisMonth = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlUpcomingEvents = New Guna.UI2.WinForms.Guna2Panel()
        Me.lstUpcomingEvents = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlMenMinistry = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalMensMinistry = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlWomenMinistry = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalWomensMinistry = New System.Windows.Forms.Label()
        Me.pnlKidsMinistry = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalKidsMinistry = New System.Windows.Forms.Label()
        Me.btnRecords = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlWorshipTeam = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalWorshipTeam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTotalMember = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalMember = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTotalMale = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalMale = New System.Windows.Forms.Label()
        Me.pnlYouthMinistry = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalYouthMinistry = New System.Windows.Forms.Label()
        Me.pnlTotalFemale = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalFemale = New System.Windows.Forms.Label()
        Me.Guna2Panel8.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        Me.Guna2Panel13.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel9.SuspendLayout()
        Me.pnlStatistics.SuspendLayout()
        Me.pnlUpcomingEvents.SuspendLayout()
        Me.pnlMenMinistry.SuspendLayout()
        Me.pnlWomenMinistry.SuspendLayout()
        Me.pnlKidsMinistry.SuspendLayout()
        Me.pnlWorshipTeam.SuspendLayout()
        Me.pnlTotalMember.SuspendLayout()
        Me.pnlTotalMale.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlYouthMinistry.SuspendLayout()
        Me.pnlTotalFemale.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'animationTimer
        '
        Me.animationTimer.Interval = 15
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.LOGIN_BACKGROUND
        Me.Guna2Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel8.Controls.Add(Me.pnlTitleBar)
        Me.Guna2Panel8.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel8.Controls.Add(Me.Label10)
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel8.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(1055, 189)
        Me.Guna2Panel8.TabIndex = 212
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTitleBar.Controls.Add(Me.btnMinimize)
        Me.pnlTitleBar.Controls.Add(Me.btnMinimizeMaximize)
        Me.pnlTitleBar.Controls.Add(Me.btnExit)
        Me.pnlTitleBar.Controls.Add(Me.Guna2Panel13)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.ShadowDecoration.Parent = Me.pnlTitleBar
        Me.pnlTitleBar.Size = New System.Drawing.Size(1055, 30)
        Me.pnlTitleBar.TabIndex = 216
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
        Me.btnMinimize.Location = New System.Drawing.Point(930, 4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.PressedColor = System.Drawing.Color.Red
        Me.btnMinimize.ShadowDecoration.Parent = Me.btnMinimize
        Me.btnMinimize.Size = New System.Drawing.Size(31, 22)
        Me.btnMinimize.TabIndex = 142
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
        Me.btnMinimizeMaximize.Location = New System.Drawing.Point(973, 4)
        Me.btnMinimizeMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizeMaximize.Name = "btnMinimizeMaximize"
        Me.btnMinimizeMaximize.PressedColor = System.Drawing.Color.Red
        Me.btnMinimizeMaximize.ShadowDecoration.Parent = Me.btnMinimizeMaximize
        Me.btnMinimizeMaximize.Size = New System.Drawing.Size(31, 22)
        Me.btnMinimizeMaximize.TabIndex = 141
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.CustomImages.Parent = Me.btnExit
        Me.btnExit.FillColor = System.Drawing.Color.DarkRed
        Me.btnExit.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Location = New System.Drawing.Point(1014, 4)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedColor = System.Drawing.Color.Red
        Me.btnExit.ShadowDecoration.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(31, 22)
        Me.btnExit.TabIndex = 140
        Me.btnExit.Text = "X"
        '
        'Guna2Panel13
        '
        Me.Guna2Panel13.BackColor = System.Drawing.Color.SteelBlue
        Me.Guna2Panel13.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel13.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel13.Name = "Guna2Panel13"
        Me.Guna2Panel13.ShadowDecoration.Parent = Me.Guna2Panel13
        Me.Guna2Panel13.Size = New System.Drawing.Size(1055, 30)
        Me.Guna2Panel13.TabIndex = 143
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(46, 6)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(69, 19)
        Me.Guna2HtmlLabel1.TabIndex = 220
        Me.Guna2HtmlLabel1.Text = "Dashboard"
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(38, 25)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 217
        Me.Guna2PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STUDENTINFO.My.Resources.Resources.logo_no_background
        Me.PictureBox1.Location = New System.Drawing.Point(3, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 215
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("LEMON MILK Medium", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(434, 77)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(335, 67)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "DASHBOARD"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.BackgroundImage = Global.STUDENTINFO.My.Resources.Resources.DASHBOARDDD
        Me.Guna2Panel9.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.Controls.Add(Me.pnlStatistics)
        Me.Guna2Panel9.Controls.Add(Me.pnlUpcomingEvents)
        Me.Guna2Panel9.Controls.Add(Me.pnlMenMinistry)
        Me.Guna2Panel9.Controls.Add(Me.pnlWomenMinistry)
        Me.Guna2Panel9.Controls.Add(Me.pnlKidsMinistry)
        Me.Guna2Panel9.Controls.Add(Me.btnRecords)
        Me.Guna2Panel9.Controls.Add(Me.pnlWorshipTeam)
        Me.Guna2Panel9.Controls.Add(Me.pnlTotalMember)
        Me.Guna2Panel9.Controls.Add(Me.pnlTotalMale)
        Me.Guna2Panel9.Controls.Add(Me.pnlYouthMinistry)
        Me.Guna2Panel9.Controls.Add(Me.pnlTotalFemale)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel9.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 194)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(1055, 594)
        Me.Guna2Panel9.TabIndex = 213
        '
        'pnlStatistics
        '
        Me.pnlStatistics.BackColor = System.Drawing.Color.Transparent
        Me.pnlStatistics.BorderColor = System.Drawing.Color.Black
        Me.pnlStatistics.BorderRadius = 10
        Me.pnlStatistics.BorderThickness = 1
        Me.pnlStatistics.Controls.Add(Me.Label12)
        Me.pnlStatistics.Controls.Add(Me.Label13)
        Me.pnlStatistics.Controls.Add(Me.Label14)
        Me.pnlStatistics.Controls.Add(Me.Label15)
        Me.pnlStatistics.Controls.Add(Me.lblHighestTurnoutEvent)
        Me.pnlStatistics.Controls.Add(Me.lblAverageTurnout)
        Me.pnlStatistics.Controls.Add(Me.lblTotalAttendanceMonth)
        Me.pnlStatistics.Controls.Add(Me.lblEventsThisMonth)
        Me.pnlStatistics.Controls.Add(Me.Label8)
        Me.pnlStatistics.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlStatistics.Location = New System.Drawing.Point(17, 195)
        Me.pnlStatistics.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlStatistics.Name = "pnlStatistics"
        Me.pnlStatistics.ShadowDecoration.Parent = Me.pnlStatistics
        Me.pnlStatistics.Size = New System.Drawing.Size(414, 187)
        Me.pnlStatistics.TabIndex = 211
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("LEMON MILK Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 145)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 17)
        Me.Label12.TabIndex = 216
        Me.Label12.Text = "Pinakamaraming Dumalo :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 116)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 19)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "Average na Dumadalo :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("LEMON MILK Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(14, 93)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 16)
        Me.Label14.TabIndex = 214
        Me.Label14.Text = "TotaL Attendance THIS Month :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(41, 64)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 19)
        Me.Label15.TabIndex = 213
        Me.Label15.Text = "EVENTS THIS MONTH :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHighestTurnoutEvent
        '
        Me.lblHighestTurnoutEvent.AutoSize = True
        Me.lblHighestTurnoutEvent.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestTurnoutEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblHighestTurnoutEvent.Location = New System.Drawing.Point(223, 144)
        Me.lblHighestTurnoutEvent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHighestTurnoutEvent.Name = "lblHighestTurnoutEvent"
        Me.lblHighestTurnoutEvent.Size = New System.Drawing.Size(118, 19)
        Me.lblHighestTurnoutEvent.TabIndex = 212
        Me.lblHighestTurnoutEvent.Text = "WORSHIP TEAM"
        Me.lblHighestTurnoutEvent.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAverageTurnout
        '
        Me.lblAverageTurnout.AutoSize = True
        Me.lblAverageTurnout.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTurnout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblAverageTurnout.Location = New System.Drawing.Point(223, 117)
        Me.lblAverageTurnout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageTurnout.Name = "lblAverageTurnout"
        Me.lblAverageTurnout.Size = New System.Drawing.Size(118, 19)
        Me.lblAverageTurnout.TabIndex = 211
        Me.lblAverageTurnout.Text = "WORSHIP TEAM"
        Me.lblAverageTurnout.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalAttendanceMonth
        '
        Me.lblTotalAttendanceMonth.AutoSize = True
        Me.lblTotalAttendanceMonth.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAttendanceMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalAttendanceMonth.Location = New System.Drawing.Point(223, 91)
        Me.lblTotalAttendanceMonth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalAttendanceMonth.Name = "lblTotalAttendanceMonth"
        Me.lblTotalAttendanceMonth.Size = New System.Drawing.Size(118, 19)
        Me.lblTotalAttendanceMonth.TabIndex = 210
        Me.lblTotalAttendanceMonth.Text = "WORSHIP TEAM"
        Me.lblTotalAttendanceMonth.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEventsThisMonth
        '
        Me.lblEventsThisMonth.AutoSize = True
        Me.lblEventsThisMonth.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventsThisMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblEventsThisMonth.Location = New System.Drawing.Point(224, 64)
        Me.lblEventsThisMonth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEventsThisMonth.Name = "lblEventsThisMonth"
        Me.lblEventsThisMonth.Size = New System.Drawing.Size(118, 19)
        Me.lblEventsThisMonth.TabIndex = 209
        Me.lblEventsThisMonth.Text = "WORSHIP TEAM"
        Me.lblEventsThisMonth.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("LEMON MILK Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(134, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 30)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "statistics"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlUpcomingEvents
        '
        Me.pnlUpcomingEvents.BackColor = System.Drawing.Color.Transparent
        Me.pnlUpcomingEvents.BorderColor = System.Drawing.Color.Black
        Me.pnlUpcomingEvents.BorderRadius = 10
        Me.pnlUpcomingEvents.BorderThickness = 1
        Me.pnlUpcomingEvents.Controls.Add(Me.lstUpcomingEvents)
        Me.pnlUpcomingEvents.Controls.Add(Me.Label9)
        Me.pnlUpcomingEvents.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlUpcomingEvents.Location = New System.Drawing.Point(17, 391)
        Me.pnlUpcomingEvents.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlUpcomingEvents.Name = "pnlUpcomingEvents"
        Me.pnlUpcomingEvents.ShadowDecoration.Parent = Me.pnlUpcomingEvents
        Me.pnlUpcomingEvents.Size = New System.Drawing.Size(414, 187)
        Me.pnlUpcomingEvents.TabIndex = 210
        '
        'lstUpcomingEvents
        '
        Me.lstUpcomingEvents.BackColor = System.Drawing.Color.White
        Me.lstUpcomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstUpcomingEvents.Font = New System.Drawing.Font("LEMON MILK Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUpcomingEvents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lstUpcomingEvents.FormattingEnabled = True
        Me.lstUpcomingEvents.ItemHeight = 19
        Me.lstUpcomingEvents.Location = New System.Drawing.Point(5, 56)
        Me.lstUpcomingEvents.Name = "lstUpcomingEvents"
        Me.lstUpcomingEvents.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstUpcomingEvents.Size = New System.Drawing.Size(406, 114)
        Me.lstUpcomingEvents.TabIndex = 209
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("LEMON MILK Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(90, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 30)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "UPCOMING EVENTS "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlMenMinistry
        '
        Me.pnlMenMinistry.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenMinistry.BorderColor = System.Drawing.Color.Black
        Me.pnlMenMinistry.BorderRadius = 10
        Me.pnlMenMinistry.BorderThickness = 1
        Me.pnlMenMinistry.Controls.Add(Me.lblTotalMensMinistry)
        Me.pnlMenMinistry.Controls.Add(Me.Label11)
        Me.pnlMenMinistry.FillColor = System.Drawing.Color.White
        Me.pnlMenMinistry.Location = New System.Drawing.Point(449, 407)
        Me.pnlMenMinistry.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMenMinistry.Name = "pnlMenMinistry"
        Me.pnlMenMinistry.ShadowDecoration.Parent = Me.pnlMenMinistry
        Me.pnlMenMinistry.Size = New System.Drawing.Size(579, 71)
        Me.pnlMenMinistry.TabIndex = 209
        '
        'lblTotalMensMinistry
        '
        Me.lblTotalMensMinistry.AutoSize = True
        Me.lblTotalMensMinistry.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMensMinistry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalMensMinistry.Location = New System.Drawing.Point(496, 9)
        Me.lblTotalMensMinistry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalMensMinistry.Name = "lblTotalMensMinistry"
        Me.lblTotalMensMinistry.Size = New System.Drawing.Size(77, 53)
        Me.lblTotalMensMinistry.TabIndex = 201
        Me.lblTotalMensMinistry.Text = "00"
        Me.lblTotalMensMinistry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("LEMON MILK Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 34)
        Me.Label11.TabIndex = 208
        Me.Label11.Text = "MEN'S MINISTRY"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlWomenMinistry
        '
        Me.pnlWomenMinistry.BackColor = System.Drawing.Color.Transparent
        Me.pnlWomenMinistry.BorderColor = System.Drawing.Color.Black
        Me.pnlWomenMinistry.BorderRadius = 10
        Me.pnlWomenMinistry.BorderThickness = 1
        Me.pnlWomenMinistry.Controls.Add(Me.Label7)
        Me.pnlWomenMinistry.Controls.Add(Me.lblTotalWomensMinistry)
        Me.pnlWomenMinistry.FillColor = System.Drawing.Color.White
        Me.pnlWomenMinistry.Location = New System.Drawing.Point(449, 328)
        Me.pnlWomenMinistry.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlWomenMinistry.Name = "pnlWomenMinistry"
        Me.pnlWomenMinistry.ShadowDecoration.Parent = Me.pnlWomenMinistry
        Me.pnlWomenMinistry.Size = New System.Drawing.Size(579, 71)
        Me.pnlWomenMinistry.TabIndex = 210
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("LEMON MILK Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(2, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 34)
        Me.Label7.TabIndex = 211
        Me.Label7.Text = "WOMEN'S MINISTRY"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalWomensMinistry
        '
        Me.lblTotalWomensMinistry.AutoSize = True
        Me.lblTotalWomensMinistry.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWomensMinistry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalWomensMinistry.Location = New System.Drawing.Point(497, 8)
        Me.lblTotalWomensMinistry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalWomensMinistry.Name = "lblTotalWomensMinistry"
        Me.lblTotalWomensMinistry.Size = New System.Drawing.Size(77, 53)
        Me.lblTotalWomensMinistry.TabIndex = 204
        Me.lblTotalWomensMinistry.Text = "00"
        Me.lblTotalWomensMinistry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlKidsMinistry
        '
        Me.pnlKidsMinistry.BackColor = System.Drawing.Color.Transparent
        Me.pnlKidsMinistry.BorderColor = System.Drawing.Color.Black
        Me.pnlKidsMinistry.BorderRadius = 10
        Me.pnlKidsMinistry.BorderThickness = 1
        Me.pnlKidsMinistry.Controls.Add(Me.Label6)
        Me.pnlKidsMinistry.Controls.Add(Me.lblTotalKidsMinistry)
        Me.pnlKidsMinistry.FillColor = System.Drawing.Color.White
        Me.pnlKidsMinistry.Location = New System.Drawing.Point(449, 247)
        Me.pnlKidsMinistry.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlKidsMinistry.Name = "pnlKidsMinistry"
        Me.pnlKidsMinistry.ShadowDecoration.Parent = Me.pnlKidsMinistry
        Me.pnlKidsMinistry.Size = New System.Drawing.Size(579, 71)
        Me.pnlKidsMinistry.TabIndex = 209
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("LEMON MILK Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 34)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "KIDS MINISTRY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalKidsMinistry
        '
        Me.lblTotalKidsMinistry.AutoSize = True
        Me.lblTotalKidsMinistry.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalKidsMinistry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalKidsMinistry.Location = New System.Drawing.Point(497, 9)
        Me.lblTotalKidsMinistry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalKidsMinistry.Name = "lblTotalKidsMinistry"
        Me.lblTotalKidsMinistry.Size = New System.Drawing.Size(77, 53)
        Me.lblTotalKidsMinistry.TabIndex = 203
        Me.lblTotalKidsMinistry.Text = "00"
        Me.lblTotalKidsMinistry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRecords
        '
        Me.btnRecords.BorderRadius = 10
        Me.btnRecords.CheckedState.Parent = Me.btnRecords
        Me.btnRecords.CustomImages.Parent = Me.btnRecords
        Me.btnRecords.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRecords.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.White
        Me.btnRecords.HoverState.Parent = Me.btnRecords
        Me.btnRecords.Location = New System.Drawing.Point(901, 525)
        Me.btnRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.ShadowDecoration.Parent = Me.btnRecords
        Me.btnRecords.Size = New System.Drawing.Size(129, 46)
        Me.btnRecords.TabIndex = 211
        Me.btnRecords.Text = "RECORDS"
        '
        'pnlWorshipTeam
        '
        Me.pnlWorshipTeam.BackColor = System.Drawing.Color.Transparent
        Me.pnlWorshipTeam.BorderColor = System.Drawing.Color.Black
        Me.pnlWorshipTeam.BorderRadius = 15
        Me.pnlWorshipTeam.BorderThickness = 1
        Me.pnlWorshipTeam.Controls.Add(Me.lblTotalWorshipTeam)
        Me.pnlWorshipTeam.Controls.Add(Me.Label4)
        Me.pnlWorshipTeam.FillColor = System.Drawing.Color.White
        Me.pnlWorshipTeam.Location = New System.Drawing.Point(449, 87)
        Me.pnlWorshipTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlWorshipTeam.Name = "pnlWorshipTeam"
        Me.pnlWorshipTeam.ShadowDecoration.Parent = Me.pnlWorshipTeam
        Me.pnlWorshipTeam.Size = New System.Drawing.Size(579, 71)
        Me.pnlWorshipTeam.TabIndex = 208
        '
        'lblTotalWorshipTeam
        '
        Me.lblTotalWorshipTeam.AutoSize = True
        Me.lblTotalWorshipTeam.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWorshipTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalWorshipTeam.Location = New System.Drawing.Point(496, 8)
        Me.lblTotalWorshipTeam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalWorshipTeam.Name = "lblTotalWorshipTeam"
        Me.lblTotalWorshipTeam.Size = New System.Drawing.Size(77, 53)
        Me.lblTotalWorshipTeam.TabIndex = 201
        Me.lblTotalWorshipTeam.Text = "00"
        Me.lblTotalWorshipTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("LEMON MILK Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 34)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "WORSHIP TEAM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlTotalMember
        '
        Me.pnlTotalMember.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotalMember.BorderColor = System.Drawing.Color.Black
        Me.pnlTotalMember.BorderRadius = 10
        Me.pnlTotalMember.BorderThickness = 1
        Me.pnlTotalMember.Controls.Add(Me.lblTotalMember)
        Me.pnlTotalMember.Controls.Add(Me.Label1)
        Me.pnlTotalMember.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlTotalMember.Location = New System.Drawing.Point(17, 33)
        Me.pnlTotalMember.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTotalMember.Name = "pnlTotalMember"
        Me.pnlTotalMember.ShadowDecoration.Parent = Me.pnlTotalMember
        Me.pnlTotalMember.Size = New System.Drawing.Size(135, 149)
        Me.pnlTotalMember.TabIndex = 207
        '
        'lblTotalMember
        '
        Me.lblTotalMember.AutoSize = True
        Me.lblTotalMember.Font = New System.Drawing.Font("LEMON MILK Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalMember.Location = New System.Drawing.Point(24, 62)
        Me.lblTotalMember.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalMember.Name = "lblTotalMember"
        Me.lblTotalMember.Size = New System.Drawing.Size(87, 57)
        Me.lblTotalMember.TabIndex = 200
        Me.lblTotalMember.Text = "00"
        Me.lblTotalMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "TOTAL MEMBER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlTotalMale
        '
        Me.pnlTotalMale.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotalMale.BorderColor = System.Drawing.Color.Black
        Me.pnlTotalMale.BorderRadius = 10
        Me.pnlTotalMale.BorderThickness = 1
        Me.pnlTotalMale.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlTotalMale.Controls.Add(Me.Label2)
        Me.pnlTotalMale.Controls.Add(Me.lblTotalMale)
        Me.pnlTotalMale.CustomBorderColor = System.Drawing.Color.White
        Me.pnlTotalMale.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlTotalMale.Location = New System.Drawing.Point(156, 33)
        Me.pnlTotalMale.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTotalMale.Name = "pnlTotalMale"
        Me.pnlTotalMale.ShadowDecoration.Depth = 15
        Me.pnlTotalMale.ShadowDecoration.Parent = Me.pnlTotalMale
        Me.pnlTotalMale.Size = New System.Drawing.Size(135, 149)
        Me.pnlTotalMale.TabIndex = 207
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.STUDENTINFO.My.Resources.Resources.man
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(32, 27)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 208
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("LEMON MILK Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "MALE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalMale
        '
        Me.lblTotalMale.AutoSize = True
        Me.lblTotalMale.Font = New System.Drawing.Font("LEMON MILK Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalMale.Location = New System.Drawing.Point(28, 61)
        Me.lblTotalMale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalMale.Name = "lblTotalMale"
        Me.lblTotalMale.Size = New System.Drawing.Size(87, 57)
        Me.lblTotalMale.TabIndex = 205
        Me.lblTotalMale.Text = "00"
        Me.lblTotalMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlYouthMinistry
        '
        Me.pnlYouthMinistry.BackColor = System.Drawing.Color.Transparent
        Me.pnlYouthMinistry.BorderColor = System.Drawing.Color.Black
        Me.pnlYouthMinistry.BorderRadius = 10
        Me.pnlYouthMinistry.BorderThickness = 1
        Me.pnlYouthMinistry.Controls.Add(Me.Label5)
        Me.pnlYouthMinistry.Controls.Add(Me.lblTotalYouthMinistry)
        Me.pnlYouthMinistry.FillColor = System.Drawing.Color.White
        Me.pnlYouthMinistry.Location = New System.Drawing.Point(449, 167)
        Me.pnlYouthMinistry.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlYouthMinistry.Name = "pnlYouthMinistry"
        Me.pnlYouthMinistry.ShadowDecoration.Parent = Me.pnlYouthMinistry
        Me.pnlYouthMinistry.Size = New System.Drawing.Size(579, 71)
        Me.pnlYouthMinistry.TabIndex = 209
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("LEMON MILK Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 34)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "YOUTH MINISTRY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalYouthMinistry
        '
        Me.lblTotalYouthMinistry.AutoSize = True
        Me.lblTotalYouthMinistry.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalYouthMinistry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalYouthMinistry.Location = New System.Drawing.Point(496, 8)
        Me.lblTotalYouthMinistry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalYouthMinistry.Name = "lblTotalYouthMinistry"
        Me.lblTotalYouthMinistry.Size = New System.Drawing.Size(77, 53)
        Me.lblTotalYouthMinistry.TabIndex = 202
        Me.lblTotalYouthMinistry.Text = "00"
        Me.lblTotalYouthMinistry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTotalFemale
        '
        Me.pnlTotalFemale.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotalFemale.BorderColor = System.Drawing.Color.Black
        Me.pnlTotalFemale.BorderRadius = 10
        Me.pnlTotalFemale.BorderThickness = 1
        Me.pnlTotalFemale.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlTotalFemale.Controls.Add(Me.Label3)
        Me.pnlTotalFemale.Controls.Add(Me.lblTotalFemale)
        Me.pnlTotalFemale.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlTotalFemale.Location = New System.Drawing.Point(296, 33)
        Me.pnlTotalFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTotalFemale.Name = "pnlTotalFemale"
        Me.pnlTotalFemale.ShadowDecoration.Parent = Me.pnlTotalFemale
        Me.pnlTotalFemale.Size = New System.Drawing.Size(135, 149)
        Me.pnlTotalFemale.TabIndex = 209
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.STUDENTINFO.My.Resources.Resources.woman_avatar
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(9, 18)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(32, 27)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 209
        Me.Guna2PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "FEMALE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalFemale
        '
        Me.lblTotalFemale.AutoSize = True
        Me.lblTotalFemale.Font = New System.Drawing.Font("LEMON MILK Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFemale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTotalFemale.Location = New System.Drawing.Point(30, 62)
        Me.lblTotalFemale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalFemale.Name = "lblTotalFemale"
        Me.lblTotalFemale.Size = New System.Drawing.Size(87, 57)
        Me.lblTotalFemale.TabIndex = 206
        Me.lblTotalFemale.Text = "00"
        Me.lblTotalFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 788)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardForm"
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel8.PerformLayout()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.Guna2Panel13.ResumeLayout(False)
        Me.Guna2Panel13.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel9.ResumeLayout(False)
        Me.pnlStatistics.ResumeLayout(False)
        Me.pnlStatistics.PerformLayout()
        Me.pnlUpcomingEvents.ResumeLayout(False)
        Me.pnlUpcomingEvents.PerformLayout()
        Me.pnlMenMinistry.ResumeLayout(False)
        Me.pnlMenMinistry.PerformLayout()
        Me.pnlWomenMinistry.ResumeLayout(False)
        Me.pnlWomenMinistry.PerformLayout()
        Me.pnlKidsMinistry.ResumeLayout(False)
        Me.pnlKidsMinistry.PerformLayout()
        Me.pnlWorshipTeam.ResumeLayout(False)
        Me.pnlWorshipTeam.PerformLayout()
        Me.pnlTotalMember.ResumeLayout(False)
        Me.pnlTotalMember.PerformLayout()
        Me.pnlTotalMale.ResumeLayout(False)
        Me.pnlTotalMale.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlYouthMinistry.ResumeLayout(False)
        Me.pnlYouthMinistry.PerformLayout()
        Me.pnlTotalFemale.ResumeLayout(False)
        Me.pnlTotalFemale.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTotalMember As System.Windows.Forms.Label
    Friend WithEvents lblTotalMale As System.Windows.Forms.Label
    Friend WithEvents lblTotalFemale As System.Windows.Forms.Label
    Friend WithEvents pnlTotalMale As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlTotalMember As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlTotalFemale As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlWorshipTeam As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalWorshipTeam As System.Windows.Forms.Label
    Friend WithEvents pnlKidsMinistry As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalKidsMinistry As System.Windows.Forms.Label
    Friend WithEvents pnlWomenMinistry As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalWomensMinistry As System.Windows.Forms.Label
    Friend WithEvents pnlYouthMinistry As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalYouthMinistry As System.Windows.Forms.Label
    Friend WithEvents btnRecords As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents animationTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pnlMenMinistry As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalMensMinistry As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pnlUpcomingEvents As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstUpcomingEvents As System.Windows.Forms.ListBox
    Friend WithEvents pnlStatistics As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblHighestTurnoutEvent As System.Windows.Forms.Label
    Friend WithEvents lblAverageTurnout As System.Windows.Forms.Label
    Friend WithEvents lblTotalAttendanceMonth As System.Windows.Forms.Label
    Friend WithEvents lblEventsThisMonth As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlTitleBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimizeMaximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel13 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
