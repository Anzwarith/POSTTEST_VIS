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
        lblIPS = New Label()
        lblIPK = New Label()
        lblPredikat = New Label()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtPredikat = New TextBox()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.BackColor = Color.Transparent
        lblIPS.Location = New Point(290, 246)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(86, 20)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(444, 245)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(89, 20)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.Anchor = AnchorStyles.Top
        lblPredikat.AutoSize = True
        lblPredikat.FlatStyle = FlatStyle.Popup
        lblPredikat.Location = New Point(381, 146)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(63, 20)
        lblPredikat.TabIndex = 2
        lblPredikat.Text = "Predikat"
        lblPredikat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(272, 216)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(125, 27)
        txtIPS.TabIndex = 3
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(425, 215)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(125, 27)
        txtIPK.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.DodgerBlue
        btnTambah.BackgroundImageLayout = ImageLayout.None
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.ForeColor = SystemColors.ButtonHighlight
        btnTambah.Location = New Point(172, 216)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.LightBlue
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Location = New Point(556, 214)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtPredikat
        ' 
        txtPredikat.Anchor = AnchorStyles.Top
        txtPredikat.BackColor = SystemColors.ButtonHighlight
        txtPredikat.Location = New Point(283, 169)
        txtPredikat.Name = "txtPredikat"
        txtPredikat.ReadOnly = True
        txtPredikat.Size = New Size(250, 27)
        txtPredikat.TabIndex = 7
        txtPredikat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(800, 450)
        Controls.Add(txtPredikat)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(lblPredikat)
        Controls.Add(lblIPK)
        Controls.Add(lblIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtPredikat As TextBox

End Class
