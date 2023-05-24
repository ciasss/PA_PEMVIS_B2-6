<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHomeUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCartUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistoryUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogoutUser = New Guna.UI2.WinForms.Guna2Button()
        Me.pbUserProfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblGantiProfilUser = New System.Windows.Forms.Label()
        Me.dgvManajemen = New System.Windows.Forms.DataGridView()
        Me.btnCari = New Guna.UI2.WinForms.Guna2Button()
        Me.tbCari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbManajemen = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnKurang = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pbUserProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvManajemen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManajemen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.btnKurang)
        Me.Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.pbManajemen)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.tbCari)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dgvManajemen)
        Me.Panel1.Location = New System.Drawing.Point(188, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 450)
        Me.Panel1.TabIndex = 0
        '
        'btnHomeUser
        '
        Me.btnHomeUser.BorderColor = System.Drawing.Color.White
        Me.btnHomeUser.BorderThickness = 1
        Me.btnHomeUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHomeUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHomeUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHomeUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHomeUser.FillColor = System.Drawing.Color.Transparent
        Me.btnHomeUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHomeUser.ForeColor = System.Drawing.Color.White
        Me.btnHomeUser.Location = New System.Drawing.Point(1, 116)
        Me.btnHomeUser.Name = "btnHomeUser"
        Me.btnHomeUser.Size = New System.Drawing.Size(187, 45)
        Me.btnHomeUser.TabIndex = 1
        Me.btnHomeUser.Text = "HOME"
        '
        'btnCartUser
        '
        Me.btnCartUser.BorderColor = System.Drawing.Color.White
        Me.btnCartUser.BorderThickness = 1
        Me.btnCartUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCartUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCartUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCartUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCartUser.FillColor = System.Drawing.Color.Transparent
        Me.btnCartUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCartUser.ForeColor = System.Drawing.Color.White
        Me.btnCartUser.Location = New System.Drawing.Point(1, 158)
        Me.btnCartUser.Name = "btnCartUser"
        Me.btnCartUser.Size = New System.Drawing.Size(187, 45)
        Me.btnCartUser.TabIndex = 2
        Me.btnCartUser.Text = "CART"
        '
        'btnHistoryUser
        '
        Me.btnHistoryUser.BorderColor = System.Drawing.Color.White
        Me.btnHistoryUser.BorderThickness = 1
        Me.btnHistoryUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistoryUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistoryUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistoryUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistoryUser.FillColor = System.Drawing.Color.Transparent
        Me.btnHistoryUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHistoryUser.ForeColor = System.Drawing.Color.White
        Me.btnHistoryUser.Location = New System.Drawing.Point(1, 200)
        Me.btnHistoryUser.Name = "btnHistoryUser"
        Me.btnHistoryUser.Size = New System.Drawing.Size(187, 45)
        Me.btnHistoryUser.TabIndex = 3
        Me.btnHistoryUser.Text = "HISTORY"
        '
        'btnLogoutUser
        '
        Me.btnLogoutUser.BorderColor = System.Drawing.Color.White
        Me.btnLogoutUser.BorderThickness = 1
        Me.btnLogoutUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogoutUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogoutUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogoutUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogoutUser.FillColor = System.Drawing.Color.Transparent
        Me.btnLogoutUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogoutUser.ForeColor = System.Drawing.Color.White
        Me.btnLogoutUser.Location = New System.Drawing.Point(1, 405)
        Me.btnLogoutUser.Name = "btnLogoutUser"
        Me.btnLogoutUser.Size = New System.Drawing.Size(187, 45)
        Me.btnLogoutUser.TabIndex = 4
        Me.btnLogoutUser.Text = "LOGOUT"
        '
        'pbUserProfil
        '
        Me.pbUserProfil.ImageRotate = 0!
        Me.pbUserProfil.Location = New System.Drawing.Point(61, 27)
        Me.pbUserProfil.Name = "pbUserProfil"
        Me.pbUserProfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbUserProfil.Size = New System.Drawing.Size(64, 64)
        Me.pbUserProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserProfil.TabIndex = 5
        Me.pbUserProfil.TabStop = False
        '
        'lblGantiProfilUser
        '
        Me.lblGantiProfilUser.AutoSize = True
        Me.lblGantiProfilUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGantiProfilUser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGantiProfilUser.ForeColor = System.Drawing.Color.White
        Me.lblGantiProfilUser.Location = New System.Drawing.Point(62, 95)
        Me.lblGantiProfilUser.Name = "lblGantiProfilUser"
        Me.lblGantiProfilUser.Size = New System.Drawing.Size(65, 13)
        Me.lblGantiProfilUser.TabIndex = 6
        Me.lblGantiProfilUser.Text = "Ganti Profil"
        '
        'dgvManajemen
        '
        Me.dgvManajemen.AllowUserToAddRows = False
        Me.dgvManajemen.AllowUserToResizeColumns = False
        Me.dgvManajemen.AllowUserToResizeRows = False
        Me.dgvManajemen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvManajemen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManajemen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvManajemen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvManajemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvManajemen.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvManajemen.Location = New System.Drawing.Point(39, 66)
        Me.dgvManajemen.MultiSelect = False
        Me.dgvManajemen.Name = "dgvManajemen"
        Me.dgvManajemen.RowHeadersVisible = False
        Me.dgvManajemen.RowHeadersWidth = 51
        Me.dgvManajemen.Size = New System.Drawing.Size(273, 353)
        Me.dgvManajemen.TabIndex = 42
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
        Me.btnCari.Location = New System.Drawing.Point(226, 33)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(50, 25)
        Me.btnCari.TabIndex = 55
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
        Me.tbCari.Location = New System.Drawing.Point(39, 39)
        Me.tbCari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCari.PlaceholderText = ""
        Me.tbCari.SelectedText = ""
        Me.tbCari.Size = New System.Drawing.Size(181, 19)
        Me.tbCari.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(35, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Cari Data :"
        '
        'pbManajemen
        '
        Me.pbManajemen.BackColor = System.Drawing.Color.White
        Me.pbManajemen.FillColor = System.Drawing.Color.LightGray
        Me.pbManajemen.ImageRotate = 0!
        Me.pbManajemen.Location = New System.Drawing.Point(384, 106)
        Me.pbManajemen.Name = "pbManajemen"
        Me.pbManajemen.Size = New System.Drawing.Size(152, 150)
        Me.pbManajemen.TabIndex = 56
        Me.pbManajemen.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(411, 337)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 57
        Me.btnSave.Text = "Add to cart"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.BorderRadius = 16
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(420, 282)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(86, 34)
        Me.Guna2TextBox1.TabIndex = 58
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
        Me.btnKurang.Location = New System.Drawing.Point(373, 283)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(40, 33)
        Me.btnKurang.TabIndex = 59
        Me.btnKurang.Text = "-"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(513, 282)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(40, 34)
        Me.Guna2Button1.TabIndex = 60
        Me.Guna2Button1.Text = "+"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGantiProfilUser)
        Me.Controls.Add(Me.pbUserProfil)
        Me.Controls.Add(Me.btnLogoutUser)
        Me.Controls.Add(Me.btnHistoryUser)
        Me.Controls.Add(Me.btnCartUser)
        Me.Controls.Add(Me.btnHomeUser)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.Text = "User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbUserProfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvManajemen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManajemen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHomeUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCartUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistoryUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogoutUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbUserProfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblGantiProfilUser As Label
    Friend WithEvents dgvManajemen As DataGridView
    Friend WithEvents btnCari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbCari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pbManajemen As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnKurang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
