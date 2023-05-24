Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Dispose()

    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub tbConPassword_TextChanged(sender As Object, e As EventArgs) Handles tbConPassword.TextChanged
        tbConPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked = True Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub cbConPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbConPassword.CheckedChanged
        If cbConPassword.Checked = True Then
            tbConPassword.UseSystemPasswordChar = False
        Else
            tbConPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If tbUsername.Text = "" Or tbName.Text = "" Or dtpTTL.Text = "" Or tbPassword.Text = "" Or tbConPassword.Text = "" Then
            MsgBox("Data Belum Lengkap! Silahkan Lengkapi Data!")
            tbUsername.Focus()
            Exit Sub

        ElseIf tbPassword.Text = tbConPassword.Text Then
            Call koneksi()
            CMD = New MySqlCommand("Select * From tbAkun Where username='" & tbUsername.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()
            If Not RD.HasRows Then
                Dim selectedDate As DateTime = dtpTTL.Value
                Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")
                Dim Simpan As String = "Insert INTO tbAkun values('" & tbUsername.Text & "','" & tbName.Text & "','" & formattedDate & "','" & tbPassword.Text & "','')"
                MsgBox(formattedDate)
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!")
                tbPassword.Text = ""
                tbConPassword.Text = ""
                tbUsername.Text = ""
                tbName.Text = ""
                cbPassword.Checked = False
                cbConPassword.Checked = False
                Me.Dispose()
            End If
        Else
            MsgBox("Pastikan Data Yang Anda Masukkan Sudah Benar!")
            tbConPassword.Focus()

        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub
End Class