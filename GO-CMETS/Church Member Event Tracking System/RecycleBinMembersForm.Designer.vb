<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecycleBinMembersForm
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
        Me.dgvRecycledMembersForm = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeletePermanently = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestoreAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteAll = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvRecycledMembersForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecycledMembersForm
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRecycledMembersForm.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecycledMembersForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecycledMembersForm.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvRecycledMembersForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecycledMembersForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecycledMembersForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecycledMembersForm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecycledMembersForm.ColumnHeadersHeight = 25
        Me.dgvRecycledMembersForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecycledMembersForm.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecycledMembersForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecycledMembersForm.EnableHeadersVisualStyles = False
        Me.dgvRecycledMembersForm.GridColor = System.Drawing.Color.Black
        Me.dgvRecycledMembersForm.Location = New System.Drawing.Point(0, 0)
        Me.dgvRecycledMembersForm.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRecycledMembersForm.Name = "dgvRecycledMembersForm"
        Me.dgvRecycledMembersForm.ReadOnly = True
        Me.dgvRecycledMembersForm.RowHeadersVisible = False
        Me.dgvRecycledMembersForm.RowTemplate.Height = 28
        Me.dgvRecycledMembersForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecycledMembersForm.Size = New System.Drawing.Size(893, 676)
        Me.dgvRecycledMembersForm.TabIndex = 181
        Me.dgvRecycledMembersForm.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRecycledMembersForm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecycledMembersForm.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecycledMembersForm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecycledMembersForm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecycledMembersForm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecycledMembersForm.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvRecycledMembersForm.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvRecycledMembersForm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgvRecycledMembersForm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecycledMembersForm.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecycledMembersForm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecycledMembersForm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRecycledMembersForm.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvRecycledMembersForm.ThemeStyle.ReadOnly = True
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("LEMON MILK Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.Height = 28
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecycledMembersForm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.btnClose.Location = New System.Drawing.Point(747, 619)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(126, 46)
        Me.btnClose.TabIndex = 222
        Me.btnClose.Text = "Close"
        '
        'btnDeletePermanently
        '
        Me.btnDeletePermanently.BackColor = System.Drawing.Color.Transparent
        Me.btnDeletePermanently.BorderRadius = 10
        Me.btnDeletePermanently.CheckedState.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.CustomImages.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDeletePermanently.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePermanently.ForeColor = System.Drawing.Color.White
        Me.btnDeletePermanently.HoverState.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.Image = Global.STUDENTINFO.My.Resources.Resources.trash
        Me.btnDeletePermanently.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDeletePermanently.Location = New System.Drawing.Point(181, 619)
        Me.btnDeletePermanently.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeletePermanently.Name = "btnDeletePermanently"
        Me.btnDeletePermanently.ShadowDecoration.Parent = Me.btnDeletePermanently
        Me.btnDeletePermanently.Size = New System.Drawing.Size(191, 46)
        Me.btnDeletePermanently.TabIndex = 221
        Me.btnDeletePermanently.Text = "Delete Permanently"
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnRestore.BorderRadius = 10
        Me.btnRestore.CheckedState.Parent = Me.btnRestore
        Me.btnRestore.CustomImages.Parent = Me.btnRestore
        Me.btnRestore.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRestore.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.HoverState.Parent = Me.btnRestore
        Me.btnRestore.Image = Global.STUDENTINFO.My.Resources.Resources.curve_arrow
        Me.btnRestore.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnRestore.Location = New System.Drawing.Point(34, 619)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.ShadowDecoration.Parent = Me.btnRestore
        Me.btnRestore.Size = New System.Drawing.Size(137, 46)
        Me.btnRestore.TabIndex = 220
        Me.btnRestore.Text = "RESTORE"
        '
        'btnRestoreAll
        '
        Me.btnRestoreAll.BackColor = System.Drawing.Color.Transparent
        Me.btnRestoreAll.BorderRadius = 10
        Me.btnRestoreAll.CheckedState.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.CustomImages.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRestoreAll.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreAll.ForeColor = System.Drawing.Color.White
        Me.btnRestoreAll.HoverState.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.Image = Global.STUDENTINFO.My.Resources.Resources.curve_arrow
        Me.btnRestoreAll.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnRestoreAll.Location = New System.Drawing.Point(382, 619)
        Me.btnRestoreAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestoreAll.Name = "btnRestoreAll"
        Me.btnRestoreAll.ShadowDecoration.Parent = Me.btnRestoreAll
        Me.btnRestoreAll.Size = New System.Drawing.Size(150, 46)
        Me.btnRestoreAll.TabIndex = 223
        Me.btnRestoreAll.Text = "RESTORE ALL"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.BorderRadius = 10
        Me.btnDeleteAll.CheckedState.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.CustomImages.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDeleteAll.Font = New System.Drawing.Font("LEMON MILK Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.HoverState.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.Image = Global.STUDENTINFO.My.Resources.Resources.curve_arrow
        Me.btnDeleteAll.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.btnDeleteAll.Location = New System.Drawing.Point(543, 619)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.ShadowDecoration.Parent = Me.btnDeleteAll
        Me.btnDeleteAll.Size = New System.Drawing.Size(191, 46)
        Me.btnDeleteAll.TabIndex = 224
        Me.btnDeleteAll.Text = "DELETE ALL"
        '
        'RecycleBinMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 676)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnRestoreAll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeletePermanently)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.dgvRecycledMembersForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecycleBinMembersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecycleBinMembersForm"
        CType(Me.dgvRecycledMembersForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRecycledMembersForm As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeletePermanently As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestoreAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteAll As Guna.UI2.WinForms.Guna2Button
End Class
