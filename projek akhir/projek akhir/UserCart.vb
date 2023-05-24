Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class UserCart
    Dim idcart As Integer

    Sub tampilKode()
        DA = New MySqlDataAdapter("Select idcart, nama, jenis, tbcart.qty, tbsepatu.harga, tbcart.harga From tbcart Join tbsepatu On tbcart.idsepatu = tbsepatu.idsepatu Where username = '" & Login.username & "'", CONN)
        DS = New DataSet
        DS.Clear()
        RD.Close()
        DA.Fill(DS, "tbcart")
        dgvCartSepatu.DataSource = DS.Tables("tbcart")
        dgvCartSepatu.Refresh()
        Call aturDGV()
    End Sub

    Sub aturDGV()
        dgvCartSepatu.Columns(0).HeaderText = "ID Cart"
        dgvCartSepatu.Columns(1).HeaderText = "Nama Produk"
        dgvCartSepatu.Columns(2).HeaderText = "Jenis Sepatu"
        dgvCartSepatu.Columns(3).HeaderText = "Quantity"
        dgvCartSepatu.Columns(4).HeaderText = "Harga"
        dgvCartSepatu.Columns(5).HeaderText = "Harga Total"
        dgvCartSepatu.Columns(0).Visible = False
    End Sub

    Private Sub TotalPesanan()
        If dgvCartSepatu IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvCartSepatu.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvCartSepatu.Rows(indeks).Cells(5).Value
                indeks = indeks + 1
            End While
            tbTotal.Text = totalPembayaran
        Else
            tbTotal.Text = 0
        End If
    End Sub

    Private Sub UserCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilKode()
        Call TotalPesanan()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin Menghapus Data Sepatu?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CMD = New MySqlCommand("Delete From tbcart where idcart = " & idcart, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Notifikasi")
            Call tampilKode()
            Call TotalPesanan()
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub dgvCartSepatu_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartSepatu.CellEnter
        idcart = dgvCartSepatu.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btnCO_Click(sender As Object, e As EventArgs) Handles btnCO.Click

    End Sub
End Class