Imports MySql.Data.MySqlClient
Public Class Form4
    Dim table As DataTable
    Sub tampil_data()
        '------- Untuk menampilkan data di datagrid -----------
        koneksi()
        da = New MySqlDataAdapter("select * from peminjaman", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "peminjaman")
        DataGridView1.DataSource = (ds.Tables("peminjaman"))
        DataGridView1.ReadOnly = True
        conn.Close()
    End Sub
    Sub tampilDataComboBox1()
        koneksi()
        Dim str As String
        str = "select Kode_Buku from buku"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBox1.Items.Add(rd("Kode_Buku"))
            Loop
        Else

        End If
    End Sub
    Sub tampilDataComboBox2()
        koneksi()
        Dim str As String
        str = "select Nis from anggota"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBox2.Items.Add(rd("Nis"))
            Loop
        Else

        End If
    End Sub
    Sub bersih()
        TextBox1.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Text = "Pilih--"
        ComboBox2.Text = ""
        ComboBox2.Text = "Pilih--"
        tampil_data()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampilDataComboBox1()
        tampilDataComboBox2()
    End Sub
    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        bersih()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '------- Coding Simpan --------
        If Me.TextBox1.Text = "" Or Me.ComboBox1.Text = "" Or Me.ComboBox2.Text = "" Then
            MsgBox("Maaf data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            koneksi()
            cmd = New MySqlCommand("select * from peminjaman where Kode_Pinjam='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Kode Pinjam sudah ada, Silahkan masukan Kode Pinjam yang berbeda", MsgBoxStyle.Exclamation, "Peringatan")
                TextBox1.Text = ""
            Else
                koneksi()
                Dim simpan As String = "insert into peminjaman" & "(Kode_Pinjam, Kode_Buku, Nis, Tanggal_Pinjam, Tanggal_Kembali)" & "values('" & TextBox1.Text & "', " & " ' " & ComboBox1.Text & "' , " & " ' " & ComboBox2.Text & "' , " & " ' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' , " & " ' " & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "')"
                cmd = New MySqlCommand(simpan, conn) ' untuk menghubungkan ke database dan table lalu simpan
                cmd.ExecuteNonQuery() ' mengeksekusi datanya
                MsgBox("Berhasil berhasil di pinjam", MsgBoxStyle.Information, "Success")
                bersih()
            End If
            'bersih()
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        '----------- menyaring di datagrid---------
        da = New MySqlDataAdapter("select * from peminjaman where Kode_Pinjam like '%" _
                                  & Me.TextBox2.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "peminjaman")
        DataGridView1.DataSource = (ds.Tables("peminjaman"))
    End Sub
    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        MsgBox("Dibuat Oleh Mochammad Fiqri A", MsgBoxStyle.Information, "About Me")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Form3.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        Form5.Show()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form2.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bersih()
    End Sub
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        FormLogin.Show()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        Dim str As String
        str = "select Kode_Buku from buku"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        Dim str As String
        str = "select Kode_Buku from buku"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
    End Sub
    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        MenuLaporan.Show()
        MenuLaporan.btnDataAnggota.Enabled = False
        MenuLaporan.btnDataBuku.Enabled = False
        MenuLaporan.btnPeminjaman.Enabled = True
        MenuLaporan.btnPengembalian.Enabled = False
    End Sub
End Class