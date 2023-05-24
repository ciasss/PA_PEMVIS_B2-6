Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class AdminManajemen
    Dim pathImg As String = ""
    Dim idSepatu As String = ""

    Sub Clear()
        tbNamaSepatu.Clear()
        tbJenis.Clear()
        tbQty.Clear()
        tbHarga.Clear()
        pbManajemen.Text = ""
        pbManajemen.Image = Nothing
        tbNamaSepatu.Focus()
    End Sub
    Sub tampilKode()
        DA = New MySqlDataAdapter("Select * From tbsepatu", CONN)
        DS = New DataSet
        DS.Clear()
        RD.Close()
        DA.Fill(DS, "tbsepatu")
        dgvManajemen.DataSource = DS.Tables("tbsepatu")
        dgvManajemen.Refresh()
        Call aturDGV()
    End Sub

    Sub aturDGV()
        dgvManajemen.Columns(0).HeaderText = "ID Sepatu"
        dgvManajemen.Columns(1).HeaderText = "Nama Produk"
        dgvManajemen.Columns(2).HeaderText = "Jenis Sepatu"
        dgvManajemen.Columns(3).HeaderText = "Quantity"
        dgvManajemen.Columns(4).HeaderText = "Harga"
        dgvManajemen.Columns(5).HeaderText = "lokasi gambar"
        dgvManajemen.Columns(5).Visible = False
    End Sub
    Private Sub AdminManajemen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbManajemen.SizeMode = PictureBoxSizeMode.StretchImage
        Call tampilKode()

    End Sub

    Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub tbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHarga.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If tbNamaSepatu.Text = "" Then
            MsgBox("Nama Sepatu Belum Diisi", MsgBoxStyle.Information, "Notifikasi")
            tbNamaSepatu.Focus()
        Else
            If MessageBox.Show("Yakin Menghapus Data Sepatu?" & tbNamaSepatu.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbsepatu where nama = " & tbNamaSepatu.Text, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Notifikasi")
                Call tampilKode()
                Call Clear()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If tbNamaSepatu.Text = "" Or tbJenis.Text = "" Or tbQty.Text = "" Or tbHarga.Text = "" Or pathImg = "" Then
            MsgBox("Data Belum Lengkap! Silahkan Lengkapi Data!", MsgBoxStyle.Information, "Notifikasi")
            tbNamaSepatu.Focus()
            Exit Sub
        Else
            Call koneksi()
            Dim cekData As String = "SELECT * FROM tbsepatu WHERE nama = '" & tbNamaSepatu.Text & "'"
            CMD = New MySqlCommand(cekData, CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Nama Sepatu Telah Digunakan!", MsgBoxStyle.Information, "Notifikasi")
            Else
                Call koneksi()
                Dim Simpan As String = "INSERT INTO tbsepatu(nama, jenis, qty, harga, gambar) values('" & tbNamaSepatu.Text & "','" & tbJenis.Text & "','" & tbQty.Text & "','" & tbHarga.Text & "', '" & pathImg & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                pathImg = ""
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Notifikasi")
                Call tampilKode()
                Call Clear()
            End If
            RD.Close()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If tbNamaSepatu.Text = "" Or tbJenis.Text = "" Or tbQty.Text = "" Or tbHarga.Text = "" Or pathImg = "" Then
            MsgBox("Data Belum Lengkap! Silahkan Lengkapi Data!", MsgBoxStyle.Information, "Notifikasi")
            tbNamaSepatu.Focus()
            Exit Sub
        Else
            RD.Close()
            Dim update As String = "UPDATE tbsepatu SET nama = '" & tbNamaSepatu.Text & "', jenis = '" & tbJenis.Text & "', qty = '" & tbQty.Text & "',  harga = '" & tbHarga.Text & "',  gambar = '" & pathImg & "' WHERE idsepatu = '" & idSepatu & "'"
            CMD = New MySqlCommand(update, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Notifikasi")
            Call tampilKode()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call Clear()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Dim Ex As String
        Ex = MessageBox.Show("Yakin Ingin Keluar Dari Program?", "Notifikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Ex = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Images|*.Jpg;*.png;*.bmp"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog1.FileName

            ' Membaca gambar dari file
            Dim image As Image = Image.FromFile(imagePath)

            If imagePath = "" Then
                MsgBox("Foto Profil Belum Diubah", MsgBoxStyle.Information, "Notifikasi")
                Exit Sub
            Else
                pbManajemen.Image = image
                pathImg = imagePath.Replace("\", "\\").Replace("/", "\\")
            End If
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        CMD = New MySqlCommand("SELECT * FROM tbsepatu WHERE nama like '%" & tbCari.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call koneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tbsepatu WHERE nama like '%" & tbCari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "get")
            dgvManajemen.DataSource = DS.Tables("get")
            dgvManajemen.ReadOnly = True
        End If
    End Sub

    Private Sub dgvManajemen_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManajemen.CellEnter
        idSepatu = dgvManajemen.Rows(e.RowIndex).Cells(0).Value.ToString
        tbNamaSepatu.Text = dgvManajemen.Rows(e.RowIndex).Cells(1).Value.ToString
        tbJenis.Text = dgvManajemen.Rows(e.RowIndex).Cells(2).Value.ToString
        tbQty.Text = dgvManajemen.Rows(e.RowIndex).Cells(3).Value.ToString
        tbHarga.Text = dgvManajemen.Rows(e.RowIndex).Cells(4).Value.ToString
        pbManajemen.ImageLocation = dgvManajemen.Rows(e.RowIndex).Cells(5).Value.ToString
        pathImg = dgvManajemen.Rows(e.RowIndex).Cells(5).Value.ToString
    End Sub
End Class