<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        lblID = New Label()
        lblPeran = New Label()
        lblDivisi = New Label()
        lblKontak = New Label()
        lblAlamat = New Label()
        lblHobi = New Label()
        PictureBox2 = New PictureBox()
        btnClose = New Button()
        lblNama = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(214, 207)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(378, 328)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.Red
        lblID.Location = New Point(24, 224)
        lblID.Name = "lblID"
        lblID.Size = New Size(79, 20)
        lblID.TabIndex = 2
        lblID.Text = "Student ID"
        ' 
        ' lblPeran
        ' 
        lblPeran.AutoSize = True
        lblPeran.ForeColor = Color.Red
        lblPeran.Location = New Point(24, 260)
        lblPeran.Name = "lblPeran"
        lblPeran.Size = New Size(39, 20)
        lblPeran.TabIndex = 3
        lblPeran.Text = "Role"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.ForeColor = Color.Red
        lblDivisi.Location = New Point(24, 297)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(62, 20)
        lblDivisi.TabIndex = 4
        lblDivisi.Text = "Division"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.ForeColor = Color.Red
        lblKontak.Location = New Point(26, 334)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(60, 20)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Contact"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.ForeColor = Color.Red
        lblAlamat.Location = New Point(24, 373)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(62, 20)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Address"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.ForeColor = Color.Red
        lblHobi.Location = New Point(26, 409)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(54, 20)
        lblHobi.TabIndex = 7
        lblHobi.Text = "Hobby"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Location = New Point(26, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(157, 155)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Cyan
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = Color.DarkMagenta
        btnClose.Location = New Point(24, 475)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.Aqua
        lblNama.Location = New Point(24, 169)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(79, 36)
        lblNama.TabIndex = 1
        lblNama.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Red
        Label1.Location = New Point(12, 207)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 2)
        Label1.TabIndex = 10
        Label1.Text = "Label1"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(264, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(288, 155)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(564, 544)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Controls.Add(PictureBox2)
        Controls.Add(lblHobi)
        Controls.Add(lblAlamat)
        Controls.Add(lblKontak)
        Controls.Add(lblDivisi)
        Controls.Add(lblPeran)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPeran As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
