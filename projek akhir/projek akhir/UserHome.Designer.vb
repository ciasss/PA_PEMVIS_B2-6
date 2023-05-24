<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pbSepatu = New System.Windows.Forms.PictureBox()
        Me.btnTambahKeranjang = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.btnKurang = New Guna.UI2.WinForms.Guna2Button()
        Me.tbQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCari = New Guna.UI2.WinForms.Guna2Button()
        Me.tbCari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.pbSepatu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSepatu
        '
        Me.pbSepatu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pbSepatu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSepatu.Location = New System.Drawing.Point(399, 83)
        Me.pbSepatu.Name = "pbSepatu"
        Me.pbSepatu.Size = New System.Drawing.Size(201, 193)
        Me.pbSepatu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSepatu.TabIndex = 8
        Me.pbSepatu.TabStop = False
        '
        'btnTambahKeranjang
        '
        Me.btnTambahKeranjang.BorderRadius = 3
        Me.btnTambahKeranjang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambahKeranjang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTambahKeranjang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambahKeranjang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTambahKeranjang.FillColor = System.Drawing.Color.Lime
        Me.btnTambahKeranjang.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahKeranjang.ForeColor = System.Drawing.Color.White
        Me.btnTambahKeranjang.Location = New System.Drawing.Point(452, 348)
        Me.btnTambahKeranjang.Name = "btnTambahKeranjang"
        Me.btnTambahKeranjang.Size = New System.Drawing.Size(110, 34)
        Me.btnTambahKeranjang.TabIndex = 9
        Me.btnTambahKeranjang.Text = "Add to Cart"
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUser.Location = New System.Drawing.Point(14, 83)
        Me.dgvUser.MultiSelect = False
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.Size = New System.Drawing.Size(369, 258)
        Me.dgvUser.TabIndex = 10
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblExit.Location = New System.Drawing.Point(582, 8)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(22, 25)
        Me.lblExit.TabIndex = 29
        Me.lblExit.Text = "x"
        '
        'btnTambah
        '
        Me.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTambah.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(556, 293)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(40, 34)
        Me.btnTambah.TabIndex = 63
        Me.btnTambah.Text = "+"
        '
        'btnKurang
        '
        Me.btnKurang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKurang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKurang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKurang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKurang.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKurang.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKurang.ForeColor = System.Drawing.Color.White
        Me.btnKurang.Location = New System.Drawing.Point(416, 294)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(40, 33)
        Me.btnKurang.TabIndex = 62
        Me.btnKurang.Text = "-"
        '
        'tbQty
        '
        Me.tbQty.AutoRoundedCorners = True
        Me.tbQty.BorderColor = System.Drawing.Color.Black
        Me.tbQty.BorderRadius = 16
        Me.tbQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbQty.DefaultText = ""
        Me.tbQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbQty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbQty.Location = New System.Drawing.Point(463, 293)
        Me.tbQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbQty.PlaceholderText = ""
        Me.tbQty.SelectedText = ""
        Me.tbQty.Size = New System.Drawing.Size(86, 34)
        Me.tbQty.TabIndex = 61
        '
        'btnCari
        '
        Me.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCari.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(201, 50)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(50, 25)
        Me.btnCari.TabIndex = 66
        Me.btnCari.Text = "Cari"
        '
        'tbCari
        '
        Me.tbCari.AutoRoundedCorners = True
        Me.tbCari.BorderColor = System.Drawing.Color.Black
        Me.tbCari.BorderRadius = 8
        Me.tbCari.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCari.DefaultText = ""
        Me.tbCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCari.Location = New System.Drawing.Point(14, 56)
        Me.tbCari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCari.PlaceholderText = ""
        Me.tbCari.SelectedText = ""
        Me.tbCari.Size = New System.Drawing.Size(181, 19)
        Me.tbCari.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Cari Data :"
        '
        'UserHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 450)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.btnTambahKeranjang)
        Me.Controls.Add(Me.pbSepatu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserHome"
        Me.Text = "UserHome"
        CType(Me.pbSepatu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbSepatu As PictureBox
    Friend WithEvents btnTambahKeranjang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents lblExit As Label
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnKurang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbCari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
End Class
