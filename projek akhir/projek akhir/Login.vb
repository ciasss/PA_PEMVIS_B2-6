Imports System.Web.Security
Imports MySql.Data.MySqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login
    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked = True Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Public username As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbAkun where username = '" & tbUsername.Text & "' and password= '" & tbPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If tbUsername.Text = "admin01" And tbPassword.Text = "admin123" Then
            username = tbUsername.Text
            tbPassword.Text = ""
            tbUsername.Text = ""
            cbPassword.Checked = False
            Landing.Hide()
            Admin.Show()
        ElseIf RD.HasRows Then
            username = tbUsername.Text
            tbPassword.Text = ""
            tbUsername.Text = ""
            cbPassword.Checked = False
            Landing.Hide()
            User.Show()
            RD.Close()
        Else
            RD.Close()
            MessageBox.Show("Login Failed! Username atau Pasword Salah! Masukkan data login dengan benar! ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPassword.Text = ""
            tbUsername.Text = ""
            cbPassword.Checked = False
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub
End Class