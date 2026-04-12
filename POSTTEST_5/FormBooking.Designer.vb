<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBooking))
        txtTotal = New TextBox()
        txtDurasi = New TextBox()
        txtNama = New TextBox()
        cbLapangan = New ComboBox()
        btnSimpan = New Button()
        btnKembali = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        mkHP = New MaskedTextBox()
        txtID = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        dtTanggal = New DateTimePicker()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(105, 326)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(250, 27)
        txtTotal.TabIndex = 1
        ' 
        ' txtDurasi
        ' 
        txtDurasi.Location = New Point(105, 283)
        txtDurasi.Name = "txtDurasi"
        txtDurasi.Size = New Size(250, 27)
        txtDurasi.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(105, 83)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 4
        ' 
        ' cbLapangan
        ' 
        cbLapangan.FormattingEnabled = True
        cbLapangan.Items.AddRange(New Object() {"Lapangan Indoor", "Lapangan Outdoor"})
        cbLapangan.Location = New Point(105, 232)
        cbLapangan.Name = "cbLapangan"
        cbLapangan.Size = New Size(250, 28)
        cbLapangan.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.LawnGreen
        btnSimpan.FlatStyle = FlatStyle.Popup
        btnSimpan.Location = New Point(14, 400)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.DimGray
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Location = New Point(383, 400)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Location = New Point(261, 400)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.DimGray
        btnUbah.FlatStyle = FlatStyle.Popup
        btnUbah.Location = New Point(136, 400)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 10
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(14, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 11
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.LightGray
        Label2.Location = New Point(14, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 12
        Label2.Text = "Total"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.LightGray
        Label3.Location = New Point(14, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 13
        Label3.Text = "Durasi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.LightGray
        Label4.Location = New Point(12, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 14
        Label4.Text = "Lapangan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.LightGray
        Label5.Location = New Point(14, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 15
        Label5.Text = "Nomor Hp"
        ' 
        ' mkHP
        ' 
        mkHP.Location = New Point(105, 136)
        mkHP.Mask = " 0000-0000-0000"
        mkHP.Name = "mkHP"
        mkHP.Size = New Size(250, 27)
        mkHP.TabIndex = 16
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(491, 29)
        txtID.Name = "txtID"
        txtID.Size = New Size(128, 27)
        txtID.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.LightGray
        Label6.Location = New Point(383, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 18
        Label6.Text = "Search Info"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.LightGray
        Label7.Location = New Point(16, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 20)
        Label7.TabIndex = 19
        Label7.Text = "Tanggal"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Location = New Point(105, 187)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(250, 27)
        dtTanggal.TabIndex = 20
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(361, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 307)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' FormBooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(622, 450)
        Controls.Add(PictureBox1)
        Controls.Add(dtTanggal)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtID)
        Controls.Add(mkHP)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnKembali)
        Controls.Add(btnSimpan)
        Controls.Add(cbLapangan)
        Controls.Add(txtNama)
        Controls.Add(txtDurasi)
        Controls.Add(txtTotal)
        Name = "FormBooking"
        Text = "FormBooking"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDurasi As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbLapangan As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mkHP As MaskedTextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
End Class
