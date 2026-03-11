Public Class FormCetak
    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFoto As New OpenFileDialog
        openFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFoto.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFoto.FileName)
            ModuleData.foto = openFoto.FileName
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or
           txtUmur.Text = "" Or
           txtTelepon.Text = "" Or
           txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If picFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If chkMusik.Checked = False And
           chkGaming.Checked = False And
           chkMembaca.Checked = False And
           chkOlahraga.Checked = False And
           chkCoding.Checked = False And
           chkTravel.Checked = False And
           chkFotografi.Checked = False And
           chkFilm.Checked = False And
           chkMemasak.Checked = False And
           chkSeni.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        Dim hobi As String = ""
        If chkMusik.Checked Then
            hobi = hobi & "Musik "
        End If
        If chkGaming.Checked Then
            hobi = hobi & "Gaming "
        End If
        If chkMembaca.Checked Then
            hobi = hobi & "Membaca "
        End If
        If chkOlahraga.Checked Then
            hobi = hobi & "Olahraga "
        End If
        If chkCoding.Checked Then
            hobi = hobi & "Coding "
        End If
        If chkTravel.Checked Then
            hobi = hobi & "Travel "
        End If
        If chkFotografi.Checked Then
            hobi = hobi & "Fotografi "
        End If
        If chkFilm.Checked Then
            hobi = hobi & "Film "
        End If
        If chkMemasak.Checked Then
            hobi = hobi & "Memasak "
        End If
        If chkSeni.Checked Then
            hobi = hobi & "Seni "
        End If


        Dim kelamin As String = ""
        If rbLaki.Checked Then
            kelamin = "Laki-laki"
        Else
            kelamin = "Perempuan"
        End If

        ModuleData.nama = txtNama.Text
        ModuleData.umur = txtUmur.Text
        ModuleData.telepon = txtTelepon.Text
        ModuleData.alamat = txtAlamat.Text
        ModuleData.tanggal = dtTanggal.Text
        ModuleData.hobby = hobi
        ModuleData.kelamin = kelamin
        FormKartu.Show()
    End Sub
End Class