Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class UserHome
    Dim pathImg As String = ""
    Dim idSepatu As String = ""
    Dim Qty, QtySepatu, harga As Integer

    Sub tampilKode()
        DA = New MySqlDataAdapter("Select * From tbsepatu", CONN)
        DS = New DataSet
        DS.Clear()
        RD.Close()
        DA.Fill(DS, "tbsepatu")
        dgvUser.DataSource = DS.Tables("tbsepatu")
        dgvUser.Refresh()
        Call aturDGV()
    End Sub

    Sub aturDGV()
        dgvUser.Columns(0).HeaderText = "ID Sepatu"
        dgvUser.Columns(1).HeaderText = "Nama Produk"
        dgvUser.Columns(2).HeaderText = "Jenis Sepatu"
        dgvUser.Columns(3).HeaderText = "Quantity"
        dgvUser.Columns(4).HeaderText = "Harga"
        dgvUser.Columns(5).HeaderText = "lokasi gambar"
        dgvUser.Columns(5).Visible = False
    End Sub

    Private Sub UserHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbSepatu.SizeMode = PictureBoxSizeMode.StretchImage
        Call tampilKode()
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
            dgvUser.DataSource = DS.Tables("get")
            dgvUser.ReadOnly = True
        End If
    End Sub

    Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If QtySepatu > Qty Then
            Qty = Qty + 1
            tbQty.Text = Qty
        End If
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        If Not Qty = 1 Then
            Qty = Qty - 1
            tbQty.Text = Qty
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub btnTambahKeranjang_Click(sender As Object, e As EventArgs) Handles btnTambahKeranjang.Click
        Call koneksi()
        Dim hargaTotal As Integer = harga * Qty
        Dim Simpan As String = "INSERT INTO tbcart(idsepatu, username, qty, harga) values('" & idSepatu & "','" & Login.username & "','" & Qty & "','" & hargaTotal & "')"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
        pathImg = ""
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Notifikasi")
    End Sub

    Private Sub dgvUser_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellEnter
        idSepatu = dgvUser.Rows(e.RowIndex).Cells(0).Value.ToString
        QtySepatu = Integer.Parse(dgvUser.Rows(e.RowIndex).Cells(3).Value.ToString)
        harga = Integer.Parse(dgvUser.Rows(e.RowIndex).Cells(4).Value.ToString)
        pbSepatu.ImageLocation = dgvUser.Rows(e.RowIndex).Cells(5).Value.ToString
        pathImg = dgvUser.Rows(e.RowIndex).Cells(5).Value.ToString
        tbQty.Text = 1
        Qty = 1
    End Sub
End Class