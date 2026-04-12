Public Class FormBooking

    Dim hargaPerJam As Integer = 0

    Public Sub Bersihkan()
        txtID.Clear()
        txtID.Clear()
        txtNama.Clear()
        mkHP.Clear()
        txtDurasi.Clear()
        txtTotal.Clear()
        cbLapangan.SelectedIndex = -1
        dtTanggal.Value = DateTime.Now
        txtNama.Focus()
    End Sub

    Private Sub HitungTotal()

        If cbLapangan.Text = "Lapangan Indoor" Then
            hargaPerJam = 250000
        ElseIf cbLapangan.Text = "Lapangan Outdoor" Then
            hargaPerJam = 150000
        Else
            hargaPerJam = 0
        End If

        Dim durasi As Integer
        If Integer.TryParse(txtDurasi.Text, durasi) AndAlso hargaPerJam > 0 Then
            txtTotal.Text = (hargaPerJam * durasi).ToString()
        Else
            txtTotal.Text = "0"
        End If

    End Sub

    Private Sub cbLapangan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLapangan.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub txtDurasi_TextChanged(sender As Object, e As EventArgs) Handles txtDurasi.TextChanged
        HitungTotal()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.Text.Trim() = "" Then
            Form1.TampilData()
        Else
            Form1.dgvBooking.DataSource = SearchBooking(txtID.Text.Trim())
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text.Trim() = "" Or cbLapangan.Text = "" Or txtDurasi.Text.Trim() = "" Then
            MessageBox.Show("Lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If SimpanBooking(txtNama.Text.Trim(), mkHP.Text, cbLapangan.Text, dtTanggal.Value.ToString("yyyy-MM-dd"), txtDurasi.Text, txtTotal.Text) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.TampilData()
            Bersihkan()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtID.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UbahBooking(txtID.Text.Trim(), txtNama.Text.Trim(), mkHP.Text, cbLapangan.Text, dtTanggal.Value.ToString("yyyy-MM-dd"), txtDurasi.Text, txtTotal.Text) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.TampilData()
            Bersihkan()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusBooking(txtID.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.TampilData()
                Bersihkan()
            Else
                MessageBox.Show("Data gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub txtDurasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDurasi.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bersihkan()
    End Sub

End Class