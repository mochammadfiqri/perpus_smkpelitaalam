<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuLaporan))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnDataAnggota = New System.Windows.Forms.Button()
        Me.btnDataBuku = New System.Windows.Forms.Button()
        Me.btnPeminjaman = New System.Windows.Forms.Button()
        Me.btnPengembalian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(936, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnDataAnggota
        '
        Me.btnDataAnggota.BackColor = System.Drawing.SystemColors.Control
        Me.btnDataAnggota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataAnggota.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen
        Me.btnDataAnggota.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataAnggota.Location = New System.Drawing.Point(34, 98)
        Me.btnDataAnggota.Name = "btnDataAnggota"
        Me.btnDataAnggota.Size = New System.Drawing.Size(125, 33)
        Me.btnDataAnggota.TabIndex = 1
        Me.btnDataAnggota.Text = "Data Anggota"
        Me.btnDataAnggota.UseVisualStyleBackColor = False
        '
        'btnDataBuku
        '
        Me.btnDataBuku.BackColor = System.Drawing.SystemColors.Control
        Me.btnDataBuku.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataBuku.Location = New System.Drawing.Point(34, 170)
        Me.btnDataBuku.Name = "btnDataBuku"
        Me.btnDataBuku.Size = New System.Drawing.Size(125, 33)
        Me.btnDataBuku.TabIndex = 1
        Me.btnDataBuku.Text = "Data Buku"
        Me.btnDataBuku.UseVisualStyleBackColor = False
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.BackColor = System.Drawing.SystemColors.Control
        Me.btnPeminjaman.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeminjaman.Location = New System.Drawing.Point(34, 241)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Size = New System.Drawing.Size(125, 33)
        Me.btnPeminjaman.TabIndex = 1
        Me.btnPeminjaman.Text = "Data Peminjaman"
        Me.btnPeminjaman.UseVisualStyleBackColor = False
        '
        'btnPengembalian
        '
        Me.btnPengembalian.BackColor = System.Drawing.SystemColors.Control
        Me.btnPengembalian.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengembalian.Location = New System.Drawing.Point(34, 310)
        Me.btnPengembalian.Name = "btnPengembalian"
        Me.btnPengembalian.Size = New System.Drawing.Size(125, 33)
        Me.btnPengembalian.TabIndex = 1
        Me.btnPengembalian.Text = "Data Pengembalian"
        Me.btnPengembalian.UseVisualStyleBackColor = False
        '
        'MenuLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 450)
        Me.Controls.Add(Me.btnPengembalian)
        Me.Controls.Add(Me.btnPeminjaman)
        Me.Controls.Add(Me.btnDataBuku)
        Me.Controls.Add(Me.btnDataAnggota)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuLaporan"
        Me.Text = "MenuLaporan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnDataAnggota As Button
    Friend WithEvents btnDataBuku As Button
    Friend WithEvents btnPeminjaman As Button
    Friend WithEvents btnPengembalian As Button
End Class
