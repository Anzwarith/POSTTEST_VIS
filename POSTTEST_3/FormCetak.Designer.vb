<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetak))
        lblJudul = New Label()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        lblTanggal = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        txtAlamat = New TextBox()
        dtTanggal = New DateTimePicker()
        grpKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        chkSeni = New CheckBox()
        chkMemasak = New CheckBox()
        chkFilm = New CheckBox()
        chkFotografi = New CheckBox()
        chkCoding = New CheckBox()
        chkTravel = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMembaca = New CheckBox()
        chkGaming = New CheckBox()
        chkMusik = New CheckBox()
        btnCetak = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.BackColor = Color.DarkSlateBlue
        lblJudul.Font = New Font("Gabriola", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Gold
        lblJudul.Location = New Point(272, 13)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(371, 57)
        lblJudul.TabIndex = 0
        lblJudul.Text = "X o u l  C o m m u n i t y"
        lblJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.SlateBlue
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(40, 100)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(160, 180)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 1
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.SeaGreen
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(62, 290)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 35)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.ForeColor = Color.Lavender
        lblNama.Location = New Point(231, 113)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.ForeColor = Color.Lavender
        lblUmur.Location = New Point(235, 150)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(45, 20)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.ForeColor = Color.Lavender
        lblTelepon.Location = New Point(235, 190)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(113, 20)
        lblTelepon.TabIndex = 5
        lblTelepon.Text = "Nomor Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.ForeColor = Color.Lavender
        lblAlamat.Location = New Point(235, 230)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.ForeColor = Color.Lavender
        lblTanggal.Location = New Point(235, 270)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(97, 20)
        lblTanggal.TabIndex = 7
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.GhostWhite
        txtNama.ForeColor = Color.DarkSlateGray
        txtNama.Location = New Point(355, 113)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.GhostWhite
        txtUmur.ForeColor = Color.DarkSlateGray
        txtUmur.Location = New Point(355, 150)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(200, 27)
        txtUmur.TabIndex = 9
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.GhostWhite
        txtTelepon.ForeColor = Color.DarkSlateGray
        txtTelepon.Location = New Point(355, 190)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(200, 27)
        txtTelepon.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.GhostWhite
        txtAlamat.ForeColor = Color.DarkSlateGray
        txtAlamat.Location = New Point(355, 230)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 27)
        txtAlamat.TabIndex = 11
        ' 
        ' dtTanggal
        ' 
        dtTanggal.CalendarTitleBackColor = SystemColors.ControlText
        dtTanggal.CalendarTitleForeColor = Color.AliceBlue
        dtTanggal.Location = New Point(355, 270)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(200, 27)
        dtTanggal.TabIndex = 12
        ' 
        ' grpKelamin
        ' 
        grpKelamin.BackColor = Color.SlateBlue
        grpKelamin.Controls.Add(rbPerempuan)
        grpKelamin.Controls.Add(rbLaki)
        grpKelamin.ForeColor = Color.Lavender
        grpKelamin.Location = New Point(601, 100)
        grpKelamin.Name = "grpKelamin"
        grpKelamin.Size = New Size(260, 70)
        grpKelamin.TabIndex = 13
        grpKelamin.TabStop = False
        grpKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = Color.Lavender
        rbPerempuan.Location = New Point(137, 30)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.ForeColor = Color.Lavender
        rbLaki.Location = New Point(20, 30)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(96, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = Color.SlateBlue
        grpHobby.Controls.Add(chkSeni)
        grpHobby.Controls.Add(chkMemasak)
        grpHobby.Controls.Add(chkFilm)
        grpHobby.Controls.Add(chkFotografi)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkTravel)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Controls.Add(chkMusik)
        grpHobby.ForeColor = Color.Lavender
        grpHobby.Location = New Point(601, 176)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(260, 173)
        grpHobby.TabIndex = 14
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' chkSeni
        ' 
        chkSeni.AutoSize = True
        chkSeni.Location = New Point(162, 114)
        chkSeni.Name = "chkSeni"
        chkSeni.Size = New Size(59, 24)
        chkSeni.TabIndex = 24
        chkSeni.Text = "Seni"
        chkSeni.UseVisualStyleBackColor = True
        ' 
        ' chkMemasak
        ' 
        chkMemasak.AutoSize = True
        chkMemasak.Location = New Point(162, 84)
        chkMemasak.Name = "chkMemasak"
        chkMemasak.Size = New Size(73, 24)
        chkMemasak.TabIndex = 23
        chkMemasak.Text = "Masak"
        chkMemasak.UseVisualStyleBackColor = True
        ' 
        ' chkFilm
        ' 
        chkFilm.AutoSize = True
        chkFilm.Location = New Point(162, 54)
        chkFilm.Name = "chkFilm"
        chkFilm.Size = New Size(59, 24)
        chkFilm.TabIndex = 22
        chkFilm.Text = "Film"
        chkFilm.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(162, 27)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(92, 24)
        chkFotografi.TabIndex = 21
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(162, 144)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(79, 24)
        chkCoding.TabIndex = 20
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkTravel
        ' 
        chkTravel.AutoSize = True
        chkTravel.Location = New Point(19, 144)
        chkTravel.Name = "chkTravel"
        chkTravel.Size = New Size(91, 24)
        chkTravel.TabIndex = 19
        chkTravel.Text = "Traveling"
        chkTravel.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(19, 114)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(92, 24)
        chkOlahraga.TabIndex = 18
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(19, 84)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(97, 24)
        chkMembaca.TabIndex = 17
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(19, 54)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(83, 24)
        chkGaming.TabIndex = 16
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Location = New Point(19, 26)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(69, 24)
        chkMusik.TabIndex = 15
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Goldenrod
        btnCetak.FlatAppearance.BorderColor = Color.Gold
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.ForeColor = Color.DarkSlateBlue
        btnCetak.Location = New Point(355, 333)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(200, 40)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Mencetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LemonChiffon
        Label1.Location = New Point(12, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(20, 28)
        Label1.TabIndex = 16
        Label1.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LemonChiffon
        Label2.Location = New Point(660, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 28)
        Label2.TabIndex = 17
        Label2.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.LemonChiffon
        Label3.Location = New Point(144, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 17)
        Label3.TabIndex = 18
        Label3.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.LemonChiffon
        Label4.Location = New Point(328, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 28)
        Label4.TabIndex = 19
        Label4.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.LemonChiffon
        Label5.Location = New Point(753, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(20, 28)
        Label5.TabIndex = 20
        Label5.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.LemonChiffon
        Label6.Location = New Point(841, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 28)
        Label6.TabIndex = 21
        Label6.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.LemonChiffon
        Label8.Location = New Point(355, 70)
        Label8.Name = "Label8"
        Label8.Size = New Size(13, 17)
        Label8.TabIndex = 23
        Label8.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.LemonChiffon
        Label7.Location = New Point(447, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(13, 17)
        Label7.TabIndex = 24
        Label7.Text = "*"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(738, 350)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-73, 331)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(205, 180)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 26
        PictureBox2.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.LemonChiffon
        Label9.Location = New Point(76, 4)
        Label9.Name = "Label9"
        Label9.Size = New Size(20, 28)
        Label9.TabIndex = 27
        Label9.Text = "*"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.LemonChiffon
        Label10.Location = New Point(535, 70)
        Label10.Name = "Label10"
        Label10.Size = New Size(20, 28)
        Label10.TabIndex = 28
        Label10.Text = "*"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.LemonChiffon
        Label11.Location = New Point(440, 70)
        Label11.Name = "Label11"
        Label11.Size = New Size(20, 28)
        Label11.TabIndex = 29
        Label11.Text = "*"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.LemonChiffon
        Label12.Location = New Point(260, 61)
        Label12.Name = "Label12"
        Label12.Size = New Size(20, 28)
        Label12.TabIndex = 30
        Label12.Text = "*"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.LemonChiffon
        Label13.Location = New Point(601, 13)
        Label13.Name = "Label13"
        Label13.Size = New Size(13, 17)
        Label13.TabIndex = 31
        Label13.Text = "*"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.LemonChiffon
        Label14.Location = New Point(267, 13)
        Label14.Name = "Label14"
        Label14.Size = New Size(13, 17)
        Label14.TabIndex = 32
        Label14.Text = "*"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.LemonChiffon
        Label15.Location = New Point(397, 70)
        Label15.Name = "Label15"
        Label15.Size = New Size(13, 17)
        Label15.TabIndex = 33
        Label15.Text = "*"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.LemonChiffon
        Label16.Location = New Point(486, 13)
        Label16.Name = "Label16"
        Label16.Size = New Size(13, 17)
        Label16.TabIndex = 34
        Label16.Text = "*"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.LemonChiffon
        Label17.Location = New Point(500, 81)
        Label17.Name = "Label17"
        Label17.Size = New Size(13, 17)
        Label17.TabIndex = 35
        Label17.Text = "*"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.LemonChiffon
        Label18.Location = New Point(312, 72)
        Label18.Name = "Label18"
        Label18.Size = New Size(20, 28)
        Label18.TabIndex = 36
        Label18.Text = "*"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.LemonChiffon
        Label19.Location = New Point(397, 7)
        Label19.Name = "Label19"
        Label19.Size = New Size(20, 28)
        Label19.TabIndex = 37
        Label19.Text = "*"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.LemonChiffon
        Label20.Location = New Point(581, 70)
        Label20.Name = "Label20"
        Label20.Size = New Size(20, 28)
        Label20.TabIndex = 38
        Label20.Text = "*"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.LemonChiffon
        Label21.Location = New Point(535, 9)
        Label21.Name = "Label21"
        Label21.Size = New Size(20, 28)
        Label21.TabIndex = 39
        Label21.Text = "*"
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(887, 477)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetak)
        Controls.Add(grpHobby)
        Controls.Add(grpKelamin)
        Controls.Add(dtTanggal)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblTanggal)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Controls.Add(lblJudul)
        Name = "FormCetak"
        Text = "Form1"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpKelamin.ResumeLayout(False)
        grpKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents grpKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkFilm As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkSeni As CheckBox
    Friend WithEvents chkMemasak As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label

End Class
