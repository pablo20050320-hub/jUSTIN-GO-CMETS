<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberHistoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblNameHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pbStudentPic = New System.Windows.Forms.PictureBox()
        Me.lblMinistry = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNameHeader
        '
        Me.lblNameHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblNameHeader.Font = New System.Drawing.Font("LEMON MILK Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameHeader.Location = New System.Drawing.Point(30, 65)
        Me.lblNameHeader.Name = "lblNameHeader"
        Me.lblNameHeader.Size = New System.Drawing.Size(145, 40)
        Me.lblNameHeader.TabIndex = 217
        Me.lblNameHeader.Text = "MEMBERS"
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHistory.ColumnHeadersHeight = 30
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHistory.EnableHeadersVisualStyles = False
        Me.dgvHistory.GridColor = System.Drawing.Color.Black
        Me.dgvHistory.Location = New System.Drawing.Point(11, 236)
        Me.dgvHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.RowTemplate.Height = 28
        Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistory.Size = New System.Drawing.Size(1174, 456)
        Me.dgvHistory.TabIndex = 218
        Me.dgvHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistory.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvHistory.ThemeStyle.ReadOnly = True
        Me.dgvHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvHistory.ThemeStyle.RowsStyle.Height = 28
        Me.dgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(1059, 704)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(126, 46)
        Me.btnClose.TabIndex = 224
        Me.btnClose.Text = "Close"
        '
        'pbStudentPic
        '
        Me.pbStudentPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbStudentPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbStudentPic.Location = New System.Drawing.Point(913, 19)
        Me.pbStudentPic.Margin = New System.Windows.Forms.Padding(2)
        Me.pbStudentPic.Name = "pbStudentPic"
        Me.pbStudentPic.Size = New System.Drawing.Size(272, 190)
        Me.pbStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStudentPic.TabIndex = 225
        Me.pbStudentPic.TabStop = False
        '
        'lblMinistry
        '
        Me.lblMinistry.BackColor = System.Drawing.Color.Transparent
        Me.lblMinistry.Font = New System.Drawing.Font("LEMON MILK Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinistry.Location = New System.Drawing.Point(30, 142)
        Me.lblMinistry.Name = "lblMinistry"
        Me.lblMinistry.Size = New System.Drawing.Size(145, 40)
        Me.lblMinistry.TabIndex = 226
        Me.lblMinistry.Text = "MEMBERS"
        '
        'MemberHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1209, 761)
        Me.Controls.Add(Me.lblMinistry)
        Me.Controls.Add(Me.pbStudentPic)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.lblNameHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemberHistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberHistoryForm"
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNameHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbStudentPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblMinistry As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
