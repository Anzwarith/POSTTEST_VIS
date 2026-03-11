<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        Label1 = New Label()
        picHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        lblHobby = New Label()
        lblTanggal = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(6, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 23)
        Label1.TabIndex = 0
        Label1.Text = "Xoul Community Card"
        ' 
        ' picHasil
        ' 
        picHasil.BorderStyle = BorderStyle.FixedSingle
        picHasil.Location = New Point(35, 50)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(120, 172)
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.TabIndex = 1
        picHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(182, 50)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(182, 80)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(45, 20)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(182, 110)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(113, 20)
        lblTelepon.TabIndex = 4
        lblTelepon.Text = "Nomor Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(182, 140)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(182, 170)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(54, 20)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(182, 200)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(61, 20)
        lblTanggal.TabIndex = 7
        lblTanggal.Text = "Tanggal"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(407, 131)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-17, 35)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 353)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.LemonChiffon
        Label11.Location = New Point(407, 11)
        Label11.Name = "Label11"
        Label11.Size = New Size(20, 28)
        Label11.TabIndex = 30
        Label11.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LemonChiffon
        Label2.Location = New Point(484, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 28)
        Label2.TabIndex = 31
        Label2.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.LemonChiffon
        Label3.Location = New Point(325, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 28)
        Label3.TabIndex = 32
        Label3.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.LemonChiffon
        Label8.Location = New Point(484, 1)
        Label8.Name = "Label8"
        Label8.Size = New Size(13, 17)
        Label8.TabIndex = 33
        Label8.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.LemonChiffon
        Label4.Location = New Point(282, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 17)
        Label4.TabIndex = 34
        Label4.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.LemonChiffon
        Label5.Location = New Point(367, 1)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 17)
        Label5.TabIndex = 35
        Label5.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.LemonChiffon
        Label6.Location = New Point(448, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(13, 17)
        Label6.TabIndex = 36
        Label6.Text = "*"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(509, 234)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Controls.Add(PictureBox2)
        Controls.Add(lblTanggal)
        Controls.Add(lblHobby)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picHasil)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "FormKartu"
        Text = "Form2"
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
