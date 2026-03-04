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
        grpInput = New GroupBox()
        btnTambah = New Button()
        Label2 = New Label()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        Label1 = New Label()
        grpHapus = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        Label3 = New Label()
        List = New ListBox()
        lblHeader = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        grpInput.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(38))
        grpInput.Controls.Add(btnTambah)
        grpInput.Controls.Add(Label2)
        grpInput.Controls.Add(txtGenre)
        grpInput.Controls.Add(txtJudul)
        grpInput.Controls.Add(Label1)
        grpInput.FlatStyle = FlatStyle.Flat
        grpInput.Font = New Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpInput.ForeColor = Color.Gold
        grpInput.Location = New Point(12, 101)
        grpInput.Name = "grpInput"
        grpInput.Size = New Size(362, 166)
        grpInput.TabIndex = 1
        grpInput.TabStop = False
        grpInput.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(5), CByte(150), CByte(105))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(152, 118)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Add"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Khaki
        Label2.Location = New Point(27, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.White
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.ForeColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        txtGenre.Location = New Point(121, 72)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(167, 31)
        txtGenre.TabIndex = 2
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = Color.White
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.ForeColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        txtJudul.Location = New Point(121, 34)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(167, 31)
        txtJudul.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Khaki
        Label1.Location = New Point(14, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(38))
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(Label3)
        grpHapus.FlatStyle = FlatStyle.Flat
        grpHapus.Font = New Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHapus.ForeColor = Color.Gold
        grpHapus.Location = New Point(12, 273)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(362, 166)
        grpHapus.TabIndex = 2
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(152, 110)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Delete"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtHapus
        ' 
        txtHapus.BorderStyle = BorderStyle.FixedSingle
        txtHapus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHapus.Location = New Point(121, 41)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(167, 31)
        txtHapus.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Khaki
        Label3.Location = New Point(14, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' List
        ' 
        List.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        List.BorderStyle = BorderStyle.None
        List.Font = New Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List.ForeColor = Color.Khaki
        List.FormattingEnabled = True
        List.Location = New Point(405, 121)
        List.Name = "List"
        List.Size = New Size(379, 320)
        List.TabIndex = 3
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.BackColor = Color.Transparent
        lblHeader.Font = New Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.Gold
        lblHeader.Location = New Point(12, 21)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(271, 53)
        lblHeader.TabIndex = 4
        lblHeader.Text = "Digital Library"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(230), CByte(190), CByte(30))
        Panel1.Location = New Point(394, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(5, 445)
        Panel1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(405, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 26)
        Label4.TabIndex = 6
        Label4.Text = "Buku Tersedia"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(788, 446)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(lblHeader)
        Controls.Add(List)
        Controls.Add(grpInput)
        Controls.Add(grpHapus)
        Name = "Form1"
        Text = "Form1"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents List As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label

End Class
