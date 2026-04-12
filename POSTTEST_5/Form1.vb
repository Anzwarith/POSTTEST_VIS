Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Public Sub TampilData()
        dgvBooking.DataSource = GetAllBooking()
        dgvBooking.Columns("id_booking").Visible = True
        dgvBooking.Columns("id_booking").HeaderText = "ID"
        dgvBooking.Columns("id_booking").Width = 50
    End Sub

    Private Sub dgvBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvBooking.Rows(e.RowIndex)

                FormBooking.txtID.Text = row.Cells("id_booking").Value.ToString()
                FormBooking.txtNama.Text = row.Cells("nama_pelanggan").Value.ToString()
                FormBooking.mkHP.Text = row.Cells("nomor_hp").Value.ToString()
                FormBooking.cbLapangan.Text = row.Cells("lapangan").Value.ToString()
                FormBooking.dtTanggal.Value = Convert.ToDateTime(row.Cells("tanggal_booking").Value)
                FormBooking.txtDurasi.Text = row.Cells("durasi").Value.ToString()
                FormBooking.txtTotal.Text = row.Cells("total_harga").Value.ToString()

                FormBooking.Show()
            Catch ex As Exception
                MessageBox.Show("Gagal mengambil data: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BookingLapanganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingLapanganToolStripMenuItem.Click
        FormBooking.txtID.Clear()
        FormBooking.Bersihkan()
        FormBooking.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class