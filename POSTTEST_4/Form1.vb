Imports System.IO

Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        Module1.HanyaHuruf(sender, e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        Module1.HanyaAngka(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim tanya As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Or cbDivisi.SelectedIndex = -1 Then
            MessageBox.Show("Input cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hobi As String = ""
        Dim adaHobi As Boolean = False
        For Each ctrl As Control In gbAktivitas.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobi &= "- " & DirectCast(ctrl, CheckBox).Text & " "
                adaHobi = True
            End If
        Next

        If Not adaHobi Then
            MessageBox.Show("Select at least 1 activity/hobby!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim peran As String = ""
        If RadioButton1.Checked Then
            peran = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            peran = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            peran = RadioButton3.Text
        ElseIf RadioButton4.Checked Then
            peran = RadioButton4.Text
        ElseIf RadioButton5.Checked Then
            peran = RadioButton5.Text
        ElseIf RadioButton6.Checked Then
            peran = RadioButton6.Text
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Print Card Now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Form2.lblNama.Text = "Name: " & txtNama.Text.ToUpper()
            Form2.lblID.Text = "ID: " & txtID.Text
            Form2.lblPeran.Text = "Role: " & peran
            Form2.lblDivisi.Text = "Division: " & cbDivisi.Text & " (" & If(rbLaki.Checked, "M", "F") & ")"
            Form2.lblKontak.Text = "Phone Number: " & txtTelepon.Text & vbCrLf & "Email: " & txtEmail.Text
            Form2.lblAlamat.Text = "Address: " & txtAlamat.Text
            Form2.lblHobi.Text = "Activity:" & vbCrLf & hobi

            If pbFoto.Image IsNot Nothing Then
                Form2.PictureBox2.Image = pbFoto.Image
            End If
            Form2.Show()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = "Name: " & txtNama.Text & vbCrLf & "ID: " & txtID.Text
            File.WriteAllText(SaveFileDialog1.FileName, isi)
            MessageBox.Show("Data berhasil disimpan!")
        End If
    End Sub
End Class