Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Gender As String
    Sub Ketemu()
        If rd.Item("JenisKelamin") = "Pria" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub
    Sub jenis_user()
        lvl_usr.Items.Add("Admin")
        lvl_usr.Items.Add("Anggota")
        lvl_usr.Text = "Pilih--"
    End Sub
    Sub tambahbidkeahlian()
        bid_keahlian.Items.Add("Kesehatan dan Pekerjaan Sosial")
        bid_keahlian.Items.Add("Teknologi Informasi")
        bid_keahlian.Items.Add("Bisnis dan Manajemen")
        bid_keahlian.Text = "Pilih--"
    End Sub
    Sub tampildata_anggota()
        koneksi()
        '------- Untuk menampilkan data di datagrid -----------
        da = New MySqlDataAdapter("Select Nis,Nama,JenisKelamin,Kelas,bid_keahlian,komp_keahlian,No_Hp,img from anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "anggota")
        DataGridView1.DataSource = (ds.Tables("anggota"))
        DataGridView2.DataSource = (ds.Tables("anggota"))
        conn.Close()
    End Sub
    Sub tampildata_user()
        koneksi()
        '------- Untuk menampilkan data akun di datagrid -----------
        da = New MySqlDataAdapter("Select username,password,level from anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "anggota")
        DataGridView2.DataSource = (ds.Tables("anggota"))
        conn.Close()
    End Sub
    Sub bersih()
        nis.Text = ""
        nama.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        bid_keahlian.Text = "Pilih--"
        komp_keahlian.Text = "Pilih--"
        kelas.Text = "Pilih--"
        no_hp.Text = ""
        usrname.Text = ""
        psswrd.Text = ""
        lvl_usr.Text = "Pilih--"
        img_path.Text = ""
        '--------- Untuk mematikan tombol
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        tampildata_anggota()
        tampildata_user()
    End Sub
    Sub arrayKelas()
        Dim arrayKelas(2) As String
        arrayKelas(0) = "10"
        arrayKelas(1) = "11"
        arrayKelas(2) = "12"
        For Each dataKelas As String In arrayKelas
            kelas.Items.Add(dataKelas)
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tambahbidkeahlian()
        bersih()
        arrayKelas()
        jenis_user()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        'agar Url gambar ada slash/daring nya
        img_path.Text = img_path.Text.Replace("\", "\\")
        '------- Coding Simpan --------
        If Me.nis.Text = "" Or Me.nama.Text = "" Or Me.bid_keahlian.Text = "" Or Me.komp_keahlian.Text = "" Or Me.kelas.Text = "" Or Me.no_hp.Text = "" Then
            MsgBox("Maaf data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            'koneksi()
            If RadioButton1.Checked = True Then
                Gender = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                Gender = RadioButton2.Text
            End If

            If nis.Text.Length < 10 Then
                MessageBox.Show("Masukan 10 karakter yang diperlukan!")
            End If

            Dim simpan As String
            MsgBox("Data berhasil di simpan", MsgBoxStyle.Information, "Success")
            simpan = "insert into anggota (username,password,level,Nis,Nama,JenisKelamin,Kelas,bid_keahlian,komp_keahlian,No_Hp,img) 
            values('" & Me.usrname.Text & "','" & Me.psswrd.Text & "','" & Me.lvl_usr.Text & "','" & Me.nis.Text _
            & "','" & Me.nama.Text & "','" & Gender & "','" & Me.kelas.Text & "','" & Me.bid_keahlian.Text & "','" &
            Me.komp_keahlian.Text & "','" & Me.no_hp.Text & "','" & img_path.Text & "')"

            cmd = New MySqlCommand(simpan, conn) ' untuk menghubungkan ke database dan table lalu simpan
            cmd.ExecuteNonQuery() ' mengeksekusi datanya
            bersih()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        koneksi()
        img_path.Text = img_path.Text.Replace("\", "\\")
        ' ------- Coding update data --------
        If Me.usrname.Text = "" Or Me.psswrd.Text = "" Or Me.lvl_usr.Text = "" Or Me.nis.Text = "" Or nama.Text = "" Or bid_keahlian.Text = "" Or komp_keahlian.Text = "" Or no_hp.Text = "" Or img_path.Text = "" Then
            MsgBox("Maaf tidak ada data/gambar yang di update", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            MsgBox("Data telah di update", MsgBoxStyle.Information, "Success")
            If RadioButton1.Checked = True Then
                Gender = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                Gender = RadioButton2.Text
            End If
            Dim edit As String
            edit = "update anggota set username ='" & usrname.Text _
                & "', password = '" & psswrd.Text & "', level = '" & lvl_usr.Text _
                & "', Nis = '" & nis.Text & "', Nama = '" & nama.Text & "',JenisKelamin ='" & Gender _
                & "',Kelas ='" & kelas.Text & "',bid_keahlian ='" & bid_keahlian.Text & "',komp_keahlian ='" & komp_keahlian.Text _
                & "',No_Hp ='" & no_hp.Text & "',img ='" & img_path.Text & "' where Nis = '" & nis.Text & "'"
            cmd = New MySqlCommand(edit, conn) ' untuk menghubungkan ke database dan table lalu update
            cmd.ExecuteNonQuery() ' mengeksekusi datanya
            bersih()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        koneksi()
        If Me.nis.Text = "" Or Me.nama.Text = "" Or Me.bid_keahlian.Text = "" Or Me.komp_keahlian.Text = "" Or Me.kelas.Text = "" Or Me.no_hp.Text = "" Then
            MsgBox("Maaf tidak ada data yang di hapus", MsgBoxStyle.Exclamation, "Peringatan")
            bersih()
        Else
            ' ------- Coding hapus data --------
            If MessageBox.Show("Anda yakin akan menghapus datanya ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String
                hapus = "delete from anggota where username = '" & Me.usrname.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                bersih()
            Else
            End If
        End If
        bersih()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        nis.Enabled = False
        koneksi()
        Try
            If DataGridView1.Rows.Count > 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
                If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
                    nis.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    nama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                    Gender = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                    kelas.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                    bid_keahlian.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
                    komp_keahlian.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                    no_hp.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
                    img_path.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value

                    usrname.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
                    psswrd.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
                    lvl_usr.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
                    cmd = New MySqlCommand("select * from anggota where Nis ='" & nis.Text & "'", conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        Ketemu()
                        PictureBox1.ImageLocation = img_path.Text
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        '----------- menyaring di datagrid---------
        da = New MySqlDataAdapter("select * from anggota where username like '%" & Me.TextBox6.Text & "%'", conn)
        ds = New DataSet
        ' ds.Clear()
        da.Fill(ds, "anggota")
        DataGridView1.DataSource = (ds.Tables("anggota"))
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tambahbidkeahlian()
        bersih()
        arrayKelas()
        jenis_user()
        nis.Enabled = True
    End Sub
    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        MsgBox("Dibuat Oleh Mochammad Fiqri A", MsgBoxStyle.Information, "About Me")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Form3.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form4.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        Form5.Show()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bid_keahlian.SelectedIndexChanged
        komp_keahlian.Items.Clear()
        Select Case bid_keahlian.SelectedItem
            Case "Kesehatan dan Pekerjaan Sosial"
                komp_keahlian.Items.Add("Farmasi Klinis & Komunitas")
                komp_keahlian.Items.Add("Asisten Keperawatan & Caregiver")

            Case "Teknologi Informasi"
                komp_keahlian.Items.Add("Teknik Komputer dan Jaringan")
                komp_keahlian.Items.Add("Rekayasa Perangkat Lunak")

            Case "Bisnis dan Manajemen"
                komp_keahlian.Items.Add("Akutansi")
                komp_keahlian.Items.Add("Pemasaran")
        End Select
    End Sub
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        Form_MenuAwal.Show()
    End Sub
    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        OpenFileDialog1.Filter = “JPEG images(*.jgp,*.jpeg)|*.jpg;*.jpeg”
        OpenFileDialog1.ShowDialog()
        img_path.Text = OpenFileDialog1.FileName
        PictureBox1.ImageLocation = img_path.Text
    End Sub
    Private Sub img_path_TextChanged(sender As Object, e As EventArgs) Handles img_path.TextChanged
        'Ketemu()
        PictureBox1.ImageLocation = img_path.Text
    End Sub
    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        MenuLaporan.Show()
        MenuLaporan.btnDataAnggota.Enabled = True
        MenuLaporan.btnDataBuku.Enabled = False
        MenuLaporan.btnPeminjaman.Enabled = False
        MenuLaporan.btnPengembalian.Enabled = False
    End Sub
    Private Sub nis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nis.KeyPress
        'Untuk memvalidasi hanya angka
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If nis.Text.Length >= 10 Then
            e.Handled = True
        End If
    End Sub
    Private Sub nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nama.KeyPress
        'Untuk memvalidasi hanya huruf
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub no_hp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles no_hp.KeyPress
        'Untuk memvalidasi hanya angka
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class