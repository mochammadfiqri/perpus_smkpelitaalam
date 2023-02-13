<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_detailAnggota
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvl_usr = New System.Windows.Forms.TextBox()
        Me.psswrd = New System.Windows.Forms.TextBox()
        Me.usrname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kelas = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.no_hp = New System.Windows.Forms.TextBox()
        Me.komp_keahlian = New System.Windows.Forms.TextBox()
        Me.bid_keahlian = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.nis = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnggota = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(148, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 289)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvl_usr)
        Me.GroupBox2.Controls.Add(Me.psswrd)
        Me.GroupBox2.Controls.Add(Me.usrname)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 148)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA AKUN"
        '
        'lvl_usr
        '
        Me.lvl_usr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvl_usr.Location = New System.Drawing.Point(106, 108)
        Me.lvl_usr.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lvl_usr.Name = "lvl_usr"
        Me.lvl_usr.Size = New System.Drawing.Size(236, 27)
        Me.lvl_usr.TabIndex = 17
        '
        'psswrd
        '
        Me.psswrd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psswrd.Location = New System.Drawing.Point(106, 69)
        Me.psswrd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.psswrd.Name = "psswrd"
        Me.psswrd.Size = New System.Drawing.Size(236, 27)
        Me.psswrd.TabIndex = 17
        '
        'usrname
        '
        Me.usrname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrname.Location = New System.Drawing.Point(106, 31)
        Me.usrname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(236, 27)
        Me.usrname.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(7, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 19)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "JENIS USER"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(7, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 19)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "PASSWORD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(7, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "USERNAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.kelas)
        Me.GroupBox1.Controls.Add(Me.gender)
        Me.GroupBox1.Controls.Add(Me.no_hp)
        Me.GroupBox1.Controls.Add(Me.komp_keahlian)
        Me.GroupBox1.Controls.Add(Me.bid_keahlian)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.nis)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 297)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA ANGGOTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "NO. HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 208)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 38)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "KOMPETENSI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KEAHLIAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 162)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 38)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "BIDANG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KEAHLIAN"
        '
        'kelas
        '
        Me.kelas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelas.Location = New System.Drawing.Point(118, 125)
        Me.kelas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(61, 27)
        Me.kelas.TabIndex = 33
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(118, 92)
        Me.gender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(129, 27)
        Me.gender.TabIndex = 33
        '
        'no_hp
        '
        Me.no_hp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_hp.Location = New System.Drawing.Point(118, 247)
        Me.no_hp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Size = New System.Drawing.Size(167, 27)
        Me.no_hp.TabIndex = 33
        '
        'komp_keahlian
        '
        Me.komp_keahlian.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.komp_keahlian.Location = New System.Drawing.Point(118, 209)
        Me.komp_keahlian.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.komp_keahlian.Name = "komp_keahlian"
        Me.komp_keahlian.Size = New System.Drawing.Size(241, 27)
        Me.komp_keahlian.TabIndex = 33
        '
        'bid_keahlian
        '
        Me.bid_keahlian.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bid_keahlian.Location = New System.Drawing.Point(118, 163)
        Me.bid_keahlian.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bid_keahlian.Name = "bid_keahlian"
        Me.bid_keahlian.Size = New System.Drawing.Size(241, 27)
        Me.bid_keahlian.TabIndex = 33
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(118, 61)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(199, 27)
        Me.nama.TabIndex = 33
        '
        'nis
        '
        Me.nis.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nis.Location = New System.Drawing.Point(118, 28)
        Me.nis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nis.Name = "nis"
        Me.nis.Size = New System.Drawing.Size(114, 27)
        Me.nis.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 129)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 19)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "KELAS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 96)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 19)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "GENDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "NIS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(11, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'txtAnggota
        '
        Me.txtAnggota.AutoSize = True
        Me.txtAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAnggota.Location = New System.Drawing.Point(41, 275)
        Me.txtAnggota.Name = "txtAnggota"
        Me.txtAnggota.Size = New System.Drawing.Size(81, 13)
        Me.txtAnggota.TabIndex = 31
        Me.txtAnggota.Text = "Nama_Anggota"
        Me.txtAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtAnggota.Visible = False
        '
        'Form_detailAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 313)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAnggota)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_detailAnggota"
        Me.Text = "Form_detailAnggota"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lvl_usr As TextBox
    Friend WithEvents psswrd As TextBox
    Friend WithEvents usrname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents kelas As TextBox
    Friend WithEvents gender As TextBox
    Friend WithEvents no_hp As TextBox
    Friend WithEvents komp_keahlian As TextBox
    Friend WithEvents bid_keahlian As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents nis As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnggota As Label
End Class
