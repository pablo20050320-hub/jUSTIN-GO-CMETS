<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecycleAttendanceMemberForm
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRecycled = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeletePermanently = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestoreAll = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvRecycled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecycled
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvRecycled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRecycled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecycled.BackgroundColor = System.Drawing.Color.Salmon
        Me.dgvRecycled.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecycled.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecycled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecycled.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRecycled.ColumnHeadersHeight = 25
        Me.dgvRecycled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecycled.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRecycled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecycled.EnableHeadersVisualStyles = False
        Me.dgvRecycled.GridColor = System.Drawing.Color.Black
        Me.dgvRecycled.Location = New System.Drawing.Point(0, 0)
        Me.dgvRecycled.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRecycled.Name = "dgvRecycled"
        Me.dgvRecycled.ReadOnly = True
        Me.dgvRecycled.RowHeadersVisible = False
        Me.dgvRecycled.RowTemplate.Height = 28
        Me.dgvRecycled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecycled.Size = New System.Drawing.Size(877, 637)
        Me.dgvRecycled.TabIndex = 182
        Me.dgvRecycled.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRecycled.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecycled.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecycled.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecycled.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecycled.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecycled.ThemeStyle.BackColor = System.Drawing.Color.Salmon
        Me.dgvRecycled.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvRecycled.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgvRecycled.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecycled.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecycled.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecycled.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRecycled.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvRecycled.ThemeStyle.ReadOnly = True
        Me.dgvRecycled.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecycled.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecycled.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecycled.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRecycled.ThemeStyle.RowsStyle.Height = 28
        Me.dgvRecycled.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecycled.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.LightCoral
        Me.btnRestore.BorderRadius = 10
        Me.btnRestore.CheckedState.Parent = Me.btnRestore
        Me.btnRestore.CustomImages.Parent = Me.btnRestore
        Me.btnRestore.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRestore.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.HoverState.Parent = Me.btnRestore
        Me.btnRestore.Image = Global.STUDENTINFO.My.Resources.Resources.curve_arrow
        Me.btnRestore.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnRestore.Location = New System.Drawing.Point(41, 580)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.ShadowDecoration.Parent = Me.btnRestore
        Me.btnRestore.Size = New System.Drawing.Size(137, 46)
        Me.btnRestore.TabIndex = 221
        Me.btnRestore.Text = "RESTORE"
        '
        'btnDeletePermanently
        '
        Me.btnDeletePermanently.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeletePermanently.BorderRadius = 10
        Me.btnDeletePermanently.CheckedState.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnDeletePermanently.CustomImages.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDeletePermanently.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePermanently.ForeColor = System.Drawing.Color.White
        Me.btnDeletePermanently.HoverState.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.Image = Global.STUDENTINFO.My.Resources.Resources.trash
        Me.btnDeletePermanently.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDeletePermanently.Location = New System.Drawing.Point(184, 580)
        Me.btnDeletePermanently.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeletePermanently.Name = "btnDeletePermanently"
        Me.btnDeletePermanently.ShadowDecoration.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.Size = New System.Drawing.Size(191, 46)
        Me.btnDeletePermanently.TabIndex = 222
        Me.btnDeletePermanently.Text = "Delete Permanently"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCoral
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(740, 580)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(126, 46)
        Me.btnClose.TabIndex = 223
        Me.btnClose.Text = "Close"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteAll.BorderRadius = 10
        Me.btnDeleteAll.CheckedState.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.CustomImages.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDeleteAll.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.HoverState.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.Image = Global.STUDENTINFO.My.Resources.Resources.curve_arrow
        Me.btnDeleteAll.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnDeleteAll.Location = New System.Drawing.Point(541, 580)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.ShadowDecoration.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.Size = New System.Drawing.Size(191, 46)
        Me.btnDeleteAll.TabIndex = 225
        Me.btnDeleteAll.Text = "DELETE ALL"
        '
        'btnRestoreAll
        '
        Me.btnRestoreAll.BackColor = System.Drawing.Color.LightCoral
        Me.btnRestoreAll.BorderRadius = 10
        Me.btnRestoreAll.CheckedState.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.CustomImages.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRestoreAll.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreAll.ForeColor = System.Drawing.Color.White
        Me.btnRestoreAll.HoverState.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.Image = Global.STUDENTINFO.My.Resources.Resources.curve_arrow
        Me.btnRestoreAll.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnRestoreAll.Location = New System.Drawing.Point(383, 580)
        Me.btnRestoreAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestoreAll.Name = "btnRestoreAll"
        Me.btnRestoreAll.ShadowDecoration.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.Size = New System.Drawing.Size(150, 46)
        Me.btnRestoreAll.TabIndex = 226
        Me.btnRestoreAll.Text = "RESTORE ALL"
        '
        'RecycleAttendanceMemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 637)
        Me.Controls.Add(Me.btnRestoreAll)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeletePermanently)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.dgvRecycled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecycleAttendanceMemberForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReycleMemberForm"
        CType(Me.dgvRecycled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRecycled As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeletePermanently As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestoreAll As Guna.UI2.WinForms.Guna2Button
End Class
