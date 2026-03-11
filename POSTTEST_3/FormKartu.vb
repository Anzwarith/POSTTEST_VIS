Public Class FormKartu
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = "Nama : " & ModuleData.nama
        lblUmur.Text = "Umur : " & ModuleData.umur
        lblTelepon.Text = "Telepon : " & ModuleData.telepon
        lblAlamat.Text = "Alamat : " & ModuleData.alamat
        lblTanggal.Text = "Tanggal Lahir : " & ModuleData.tanggal
        lblHobby.Text = "Hobby : " & ModuleData.hobby

        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.Image = Image.FromFile(ModuleData.foto)
    End Sub
End Class