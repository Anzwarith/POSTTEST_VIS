<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        DataInputToolStripMenuItem = New ToolStripMenuItem()
        CheckTheCardToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PictureBox3 = New PictureBox()
        cbDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        lblDivisi = New Label()
        lblGender = New Label()
        lblTanggal = New Label()
        lblID = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        PictureBox2 = New PictureBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        txtTelepon = New MaskedTextBox()
        lblAlamat = New Label()
        lblEmail = New Label()
        lblNomor = New Label()
        TabPage3 = New TabPage()
        gbAktivitas = New GroupBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        gbHobi = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        Button1 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        gbAktivitas.SuspendLayout()
        gbHobi.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DataInputToolStripMenuItem, CheckTheCardToolStripMenuItem, SaveToolStripMenuItem, OpenToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(832, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' DataInputToolStripMenuItem
        ' 
        DataInputToolStripMenuItem.Name = "DataInputToolStripMenuItem"
        DataInputToolStripMenuItem.Size = New Size(93, 24)
        DataInputToolStripMenuItem.Text = "Data Input"
        ' 
        ' CheckTheCardToolStripMenuItem
        ' 
        CheckTheCardToolStripMenuItem.Name = "CheckTheCardToolStripMenuItem"
        CheckTheCardToolStripMenuItem.Size = New Size(90, 24)
        CheckTheCardToolStripMenuItem.Text = "View Card"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(54, 24)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(59, 24)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(415, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(373, 45)
        Label1.TabIndex = 1
        Label1.Text = "REPUBLIC REGISTRATION"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(317, 132)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(45, 162)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(747, 338)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(34))
        TabPage1.Controls.Add(PictureBox3)
        TabPage1.Controls.Add(cbDivisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(lblDivisi)
        TabPage1.Controls.Add(lblGender)
        TabPage1.Controls.Add(lblTanggal)
        TabPage1.Controls.Add(lblID)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Controls.Add(txtNama)
        TabPage1.ForeColor = Color.White
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(10)
        TabPage1.Size = New Size(739, 305)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Primary Data"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(404, -29)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(339, 344)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' cbDivisi
        ' 
        cbDivisi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cbDivisi.DropDownStyle = ComboBoxStyle.DropDownList
        cbDivisi.ForeColor = Color.Cyan
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Jedi Order", "Imperial Navy", "Rebel Alliance", "Inquisitorius", "Trade Federation", "Science Bureau"})
        cbDivisi.Location = New Point(151, 195)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(250, 28)
        cbDivisi.TabIndex = 10
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = Color.Yellow
        rbPerempuan.Location = New Point(267, 157)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(78, 24)
        rbPerempuan.TabIndex = 9
        rbPerempuan.Text = "Female"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Checked = True
        rbLaki.ForeColor = Color.Yellow
        rbLaki.Location = New Point(148, 157)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(63, 24)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Male"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(151, 110)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(250, 27)
        dtpLahir.TabIndex = 7
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.ForeColor = Color.Cyan
        txtID.Location = New Point(148, 66)
        txtID.Name = "txtID"
        txtID.Size = New Size(253, 27)
        txtID.TabIndex = 6
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.ForeColor = Color.Lavender
        lblDivisi.Location = New Point(15, 203)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(62, 20)
        lblDivisi.TabIndex = 5
        lblDivisi.Text = "Division"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.ForeColor = Color.Lavender
        lblGender.Location = New Point(15, 161)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(57, 20)
        lblGender.TabIndex = 4
        lblGender.Text = "Gender"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.ForeColor = Color.Lavender
        lblTanggal.Location = New Point(15, 117)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(94, 20)
        lblTanggal.TabIndex = 3
        lblTanggal.Text = "Date of Birth"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = Color.Lavender
        lblID.Location = New Point(15, 73)
        lblID.Name = "lblID"
        lblID.Size = New Size(79, 20)
        lblID.TabIndex = 2
        lblID.Text = "Student ID"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.ForeColor = Color.Lavender
        lblNama.Location = New Point(13, 30)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(109, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Member Name"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.Cyan
        txtNama.Location = New Point(148, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(253, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(34))
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtTelepon)
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(lblNomor)
        TabPage2.ForeColor = Color.White
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(739, 305)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Contact"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(394, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(349, 309)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.Cyan
        txtAlamat.Location = New Point(183, 152)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(166, 27)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.ForeColor = Color.Cyan
        txtEmail.Location = New Point(183, 106)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(166, 27)
        txtEmail.TabIndex = 4
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtTelepon.BorderStyle = BorderStyle.FixedSingle
        txtTelepon.ForeColor = Color.Cyan
        txtTelepon.Location = New Point(183, 53)
        txtTelepon.Mask = "0000-0000-0000"
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(166, 27)
        txtTelepon.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.ForeColor = Color.Lavender
        lblAlamat.Location = New Point(15, 159)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(62, 20)
        lblAlamat.TabIndex = 2
        lblAlamat.Text = "Address"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.Lavender
        lblEmail.Location = New Point(15, 113)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.ForeColor = Color.Lavender
        lblNomor.Location = New Point(15, 66)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(108, 20)
        lblNomor.TabIndex = 0
        lblNomor.Text = "Phone Number"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(34))
        TabPage3.Controls.Add(gbAktivitas)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbFoto)
        TabPage3.ForeColor = Color.White
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(739, 305)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profile"
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(CheckBox8)
        gbAktivitas.Controls.Add(CheckBox7)
        gbAktivitas.Controls.Add(CheckBox6)
        gbAktivitas.Controls.Add(CheckBox5)
        gbAktivitas.Controls.Add(CheckBox4)
        gbAktivitas.Controls.Add(CheckBox3)
        gbAktivitas.Controls.Add(CheckBox2)
        gbAktivitas.Controls.Add(CheckBox1)
        gbAktivitas.FlatStyle = FlatStyle.Flat
        gbAktivitas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbAktivitas.ForeColor = Color.FromArgb(CByte(255), CByte(232), CByte(31))
        gbAktivitas.Location = New Point(416, 26)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(317, 273)
        gbAktivitas.TabIndex = 3
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Choose Activity"
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(16, 127)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(129, 24)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Cantina Music"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(158, 97)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(146, 24)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Starship piloting"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(14, 97)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(119, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Droid Repair"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(158, 37)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(152, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Lighsaber Duelist"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(158, 65)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(139, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Holocron Study"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(158, 127)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(135, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Target Practice"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(15, 67)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(76, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Slicing"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(15, 37)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(101, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Podracing"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(RadioButton6)
        gbHobi.Controls.Add(RadioButton5)
        gbHobi.Controls.Add(RadioButton4)
        gbHobi.Controls.Add(RadioButton3)
        gbHobi.Controls.Add(RadioButton2)
        gbHobi.Controls.Add(RadioButton1)
        gbHobi.FlatStyle = FlatStyle.Flat
        gbHobi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHobi.ForeColor = Color.FromArgb(CByte(255), CByte(232), CByte(31))
        gbHobi.Location = New Point(190, 26)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(192, 273)
        gbHobi.TabIndex = 2
        gbHobi.TabStop = False
        gbHobi.Text = "Choose Role"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(16, 176)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(97, 24)
        RadioButton6.TabIndex = 5
        RadioButton6.TabStop = True
        RadioButton6.Text = "Smuggler"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(16, 146)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(128, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "Clone Trooper"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(16, 116)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(143, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "Galactic Senator"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(16, 86)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(134, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Bounty Hunter"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(16, 56)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Sith Lord"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(16, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(109, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Jedi Knight"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.Highlight
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(46, 212)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(15, 19)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(157, 177)
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(308, 512)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 29)
        Button1.TabIndex = 4
        Button1.Text = "Save and Print Card"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(605, 516)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 20)
        Label2.TabIndex = 5
        Label2.Text = "SYSTEM VERSION: 2077.04.02"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Red
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(360, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(472, 2)
        Label3.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(832, 553)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Galactic Identity System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataInputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckTheCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelepon As MaskedTextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton

End Class
