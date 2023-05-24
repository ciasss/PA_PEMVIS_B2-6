Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class User
    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        UserHome.TopLevel = False
        Panel1.Controls.Add(UserHome)
        UserHome.BringToFront()
        UserHome.Show()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserHome.TopLevel = False
        Panel1.Controls.Add(UserHome)
        UserHome.BringToFront()
        UserHome.Show()
        Call koneksi()
        CMD = New MySqlCommand("Select gambar From tbAkun Where username='" & Login.username & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        RD.Close()
        Dim nilai As Object = CMD.ExecuteScalar
        Dim nilaii As String = nilai.ToString()
        If Not nilaii = "" Then
            Dim image As Image = Image.FromFile(nilai)
            pbUserProfil.Image = image
        End If
    End Sub

    Private Sub btnCartUser_Click(sender As Object, e As EventArgs) Handles btnCartUser.Click
        UserCart.TopLevel = False
        Panel1.Controls.Add(UserCart)
        UserCart.BringToFront()
        UserCart.Show()
    End Sub

    Private Sub btnHistoryUser_Click(sender As Object, e As EventArgs) Handles btnHistoryUser.Click
        UserHistory.TopLevel = False
        Panel1.Controls.Add(UserHistory)
        UserHistory.BringToFront()
        UserHistory.Show()
    End Sub
    Private Sub btnLogoutUser_Click(sender As Object, e As EventArgs) Handles btnLogoutUser.Click
        Dim keluar As String
        keluar = MessageBox.Show("Lanjutkan untuk keluar?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = MsgBoxResult.Yes Then
            Me.Dispose()
            Landing.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lblGantiProfilUser_Click(sender As Object, e As EventArgs) Handles lblGantiProfilUser.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Images|*.Jpg;*.png;*.bmp"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog1.FileName

            ' Membaca gambar dari file
            Dim image As Image = Image.FromFile(imagePath)

            If imagePath = "" Then
                MsgBox("Foto profil tidak diubah!")
                Exit Sub
            Else
                pbUserProfil.Image = image
                Dim escapeImgPath As String = imagePath.Replace("\", "\\").Replace("/", "\\")
                Dim update As String = "UPDATE tbAkun SET gambar = '" & escapeImgPath & "' WHERE username = '" & Login.username & "'"
                CMD = New MySqlCommand(update, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil mengubah foto profil! ", MsgBoxStyle.Information, "Notifikasi")

            End If
        End If
    End Sub
End Class