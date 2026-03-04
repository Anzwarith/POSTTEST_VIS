Public Class Form1
    Private Sub RefreshList()
        List.Items.Clear()
        For i As Integer = 0 To jumlah - 1
            List.Items.Add(
                dataBuku(i, 0) & " (" &
                dataBuku(i, 1) & ")"
            )
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim j As String = txtJudul.Text.Trim
        Dim g As String = txtGenre.Text.Trim

        If j = "" Or g = "" Then
            MessageBox.Show("Data belum lengkap")
            Exit Sub
        End If

        TambahBuku(j, g, jumlah)
        txtJudul.Clear()
        txtGenre.Clear()
        RefreshList()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim target As String = txtHapus.Text.Trim
        Dim idx As Integer = CariBuku(target)

        If idx = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
            Exit Sub
        End If

        For i As Integer = idx To jumlah - 2
            dataBuku(i, 0) = dataBuku(i + 1, 0)
            dataBuku(i, 1) = dataBuku(i + 1, 1)
        Next
        jumlah -= 1
        txtHapus.Clear()
        RefreshList()
    End Sub
End Class
