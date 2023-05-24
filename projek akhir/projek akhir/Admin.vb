Imports MySql.Data.MySqlClient

Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminManajemen.TopLevel = False
        Panel1.Controls.Add(AdminManajemen)
        AdminManajemen.BringToFront()
        AdminManajemen.Show()
        pbAdminProfil.SizeMode = PictureBoxSizeMode.StretchImage
        Call koneksi()
        CMD = New MySqlCommand("Select gambar From tbAkun Where username='" & Login.username & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        RD.Close()
        Dim nilai As Object = CMD.ExecuteScalar
        Dim nilaii As String = nilai.ToString()
        If Not nilaii = "" Then
            Dim image As Image = Image.FromFile(nilai)
            pbAdminProfil.Image = image
        End If

    End Sub
    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        AdminManajemen.TopLevel = False
        Panel1.Controls.Add(AdminManajemen)
        AdminManajemen.BringToFront()
        AdminManajemen.Show()
    End Sub
    Private Sub btnCartUser_Click(sender As Object, e As EventArgs) Handles btnCartUser.Click
        AdminDataPenjualan.TopLevel = False
        Panel1.Controls.Add(AdminDataPenjualan)
        AdminDataPenjualan.BringToFront()
        AdminDataPenjualan.Show()
    End Sub
    Private Sub btnLogoutAdmin_Click(sender As Object, e As EventArgs) Handles btnLogoutAdmin.Click
        Dim keluar As String
        keluar = MessageBox.Show("Lanjutkan untuk keluar?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = MsgBoxResult.Yes Then
            Me.Dispose()
            Landing.Show()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub lbGantiProfilAdmin_Click(sender As Object, e As EventArgs) Handles lblGantiProfilAdmin.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Images|*.Jpg;*.png;*.bmp"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog1.FileName
            Dim image As Image = Image.FromFile(imagePath)

            If imagePath = "" Then
                MsgBox("Foto profil tidak diubah!")
                Exit Sub
            Else
                pbAdminProfil.Image = image
                Dim escapeImgPath As String = imagePath.Replace("\", "\\").Replace("/", "\\")
                Dim update As String = "UPDATE tbAkun SET gambar = '" & escapeImgPath & "' WHERE username = '" & Login.username & "'"
                CMD = New MySqlCommand(update, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil mengubah foto profil! ", MsgBoxStyle.Information, "Notifikasi")
            End If
        End If
    End Sub
End Class