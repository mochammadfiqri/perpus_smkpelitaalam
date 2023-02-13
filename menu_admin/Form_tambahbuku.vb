Imports System.ComponentModel
Imports MySql.Data.MySqlClient
'Imports System.IO
Public Class Form_tambahbuku
    Sub bersih()
        TextBox2.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox1.Text = ""
        tipe_buku.Text = "Pilih--"
        '--------- Untuk mematikan tombol
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Form3.Show()
    End Sub
    Sub tampildata_combobox()
        'Dim dataArray As String() = {"Buku", "Jurnal"}
        'ComboBox1.DataSource = dataArray
        tipe_buku.Items.Add("Buku")
        tipe_buku.Items.Add("Jurnal")
        tipe_buku.Text = "Pilih--"
    End Sub
    Private Sub Form_tambahbuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'koneksi()
        tampildata_combobox()
        Panel1.AutoScroll = True
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox10.Text = TextBox10.Text.Replace("\", "\\")
        'TextBox1.Text = TextBox1.Text.Replace("'", "''")
        '------- Coding Simpan --------
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox4.Text = "" Or Me.tipe_buku.Text = "" Or Me.TextBox5.Text = "" Or Me.TextBox7.Text = "" Then
            MsgBox("Harap Lengkapi data buku!", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Select Case Button2.Text
                Case "Simpan"
                    koneksi()
                    Dim simpan As String
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information, "Success")
                    simpan = "insert into buku (Kode_Buku,tipe_buku,Judul,Penulis,Tahun_Terbit,halaman,asal_kota,Penerbit,url,isbn_issn,file) values('" & Me.TextBox1.Text _
                    & "','" & Me.tipe_buku.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" &
                    Me.TextBox6.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "','" & Me.TextBox9.Text & "','" & Me.TextBox10.Text & "')"
                    cmd = New MySqlCommand(simpan, conn) ' untuk menghubungkan ke database dan table lalu simpan
                    cmd.ExecuteNonQuery() ' mengeksekusi datanya
                    bersih()
                    Close()
                Case "Edit"
                    koneksi()
                    ' ------- Coding update data --------
                    MsgBox("Data telah di update", MsgBoxStyle.Information, "Success")
                    Dim edit As String
                    edit = "update buku set tipe_buku = '" & tipe_buku.Text & "',Judul ='" & TextBox2.Text &
                        "',Penulis ='" & TextBox3.Text & "',Tahun_Terbit ='" & TextBox4.Text & "',halaman ='" &
                        TextBox5.Text & "',asal_kota ='" & TextBox6.Text & "',Penerbit ='" & TextBox7.Text &
                        "',url ='" & TextBox8.Text & "',isbn_issn ='" & TextBox9.Text & "',file ='" & TextBox10.Text &
                        "' where Kode_Buku = '" & TextBox1.Text & "'"
                    cmd = New MySqlCommand(edit, conn) ' untuk menghubungkan ke database dan table lalu update
                    cmd.ExecuteNonQuery() ' mengeksekusi datanya
                    Close()
            End Select
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bersih()
    End Sub
    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        OpenFileDialog1.Filter = "*.pdf|*.pdf"
        TextBox10.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        OpenFileDialog1.ShowDialog()
        TextBox10.Text = OpenFileDialog1.FileName
        'form_daftarbuku.pdf_reader.src = TextBox10.Text
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        'Untuk memvalidasi hanya angka
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        'Untuk memvalidasi hanya angka
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox8_Validating(sender As Object, e As CancelEventArgs) Handles TextBox8.Validating
        If Not Uri.IsWellFormedUriString(TextBox8.Text, UriKind.Absolute) Then
            MessageBox.Show("Masukkan URL yang valid.")
            If e.Cancel = False Then
                TextBox8.Text = ""
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class