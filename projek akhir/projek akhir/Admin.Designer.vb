<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.btnLogoutAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCartUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHomeUser = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGantiProfilAdmin = New System.Windows.Forms.Label()
        Me.pbAdminProfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbAdminProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogoutAdmin
        '
        Me.btnLogoutAdmin.BorderColor = System.Drawing.Color.White
        Me.btnLogoutAdmin.BorderThickness = 1
        Me.btnLogoutAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogoutAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogoutAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogoutAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogoutAdmin.FillColor = System.Drawing.Color.Transparent
        Me.btnLogoutAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogoutAdmin.ForeColor = System.Drawing.Color.White
        Me.btnLogoutAdmin.Location = New System.Drawing.Point(2, 623)
        Me.btnLogoutAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogoutAdmin.Name = "btnLogoutAdmin"
        Me.btnLogoutAdmin.Size = New System.Drawing.Size(280, 69)
        Me.btnLogoutAdmin.TabIndex = 9
        Me.btnLogoutAdmin.Text = "LOGOUT"
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
        Me.btnCartUser.Location = New System.Drawing.Point(2, 243)
        Me.btnCartUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCartUser.Name = "btnCartUser"
        Me.btnCartUser.Size = New System.Drawing.Size(280, 69)
        Me.btnCartUser.TabIndex = 7
        Me.btnCartUser.Text = "Data Pejualan"
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
        Me.btnHomeUser.Location = New System.Drawing.Point(2, 178)
        Me.btnHomeUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHomeUser.Name = "btnHomeUser"
        Me.btnHomeUser.Size = New System.Drawing.Size(280, 69)
        Me.btnHomeUser.TabIndex = 6
        Me.btnHomeUser.Text = "Manajemen Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(282, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 692)
        Me.Panel1.TabIndex = 5
        '
        'lblGantiProfilAdmin
        '
        Me.lblGantiProfilAdmin.AutoSize = True
        Me.lblGantiProfilAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGantiProfilAdmin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGantiProfilAdmin.ForeColor = System.Drawing.Color.White
        Me.lblGantiProfilAdmin.Location = New System.Drawing.Point(98, 137)
        Me.lblGantiProfilAdmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGantiProfilAdmin.Name = "lblGantiProfilAdmin"
        Me.lblGantiProfilAdmin.Size = New System.Drawing.Size(95, 23)
        Me.lblGantiProfilAdmin.TabIndex = 11
        Me.lblGantiProfilAdmin.Text = "Ganti Profil"
        '
        'pbAdminProfil
        '
        Me.pbAdminProfil.ImageRotate = 0!
        Me.pbAdminProfil.Location = New System.Drawing.Point(96, 32)
        Me.pbAdminProfil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbAdminProfil.Name = "pbAdminProfil"
        Me.pbAdminProfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbAdminProfil.Size = New System.Drawing.Size(96, 98)
        Me.pbAdminProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdminProfil.TabIndex = 10
        Me.pbAdminProfil.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.lblGantiProfilAdmin)
        Me.Controls.Add(Me.pbAdminProfil)
        Me.Controls.Add(Me.btnLogoutAdmin)
        Me.Controls.Add(Me.btnCartUser)
        Me.Controls.Add(Me.btnHomeUser)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.pbAdminProfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogoutAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCartUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHomeUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGantiProfilAdmin As Label
    Friend WithEvents pbAdminProfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
