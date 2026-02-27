Public Class Form1

    Dim totalIPS As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtIPS.Text = "" Then
            MessageBox.Show("Masukkan IP Semester dulu.")
            Exit Sub
        End If

        Dim ips As Double
        If Not Double.TryParse(txtIPS.Text, ips) Then
            MessageBox.Show("Input harus angka.")
            Exit Sub
        End If

        ' Tambah data
        totalIPS += ips
        jumlahSemester += 1

        ' Hitung IPK
        Dim ipk As Double = totalIPS / jumlahSemester
        txtIPK.Text = ipk.ToString("0.00")

        ' ===== INI BAGIAN PREDIKAT =====
        txtPredikat.Text = HitungPredikat(ipk)

        ' Kosongkan IPS
        txtIPS.Clear()
        txtIPS.Focus()

    End Sub

    Private Function HitungPredikat(ipk As Double) As String
        If ipk >= 2.0 And ipk <= 2.75 Then
            Return "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            Return "Memuaskan"
        ElseIf ipk >= 3.01 Then
            Return "Sangat Memuaskan"
        Else
            Return "-"
        End If
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIPS = 0
        jumlahSemester = 0

        txtIPS.Clear()
        txtIPK.Clear()
        txtIPS.Focus()
    End Sub
End Class