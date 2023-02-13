Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Form5
    Sub tampil_data()
        koneksi()
        '------- Untuk menampilkan data di datagrid -----------
        da = New MySqlDataAdapter("select Kode_Pinjam,Kode_Buku,Nis,Tanggal_Kembali,Jatuh_Tempo,Denda_Perhari,Total_Denda,Tanggal_Pinjam from pengembalian", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengembalian")
        DataGridView1.DataSource = (ds.Tables("pengembalian"))
        conn.Close()
    End Sub
    Sub tampilDataComboBox1()
        koneksi()
        Dim str As String
        str = "select Kode_Pinjam from peminjaman"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBox1.Items.Add(rd.Item(0))
            Loop
        Else
        End If
    End Sub
    Sub bersih()
        ComboBox1.Text = ""
        ComboBox1.Text = "Pilih--"
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        tampil_data()
    End Sub
    Sub Denda()
        Try
            koneksi()
            cmd = New MySqlCommand("select * from peminjaman where denda ='" + TextBox5.Text + "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox5.Text = rd.Item("denda")
            End If
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function HitungDenda()
        Dim jatuh_tempo, denda, total_denda As Integer
        If Integer.TryParse(TextBox4.Text, jatuh_tempo) AndAlso Integer.TryParse(TextBox5.Text, denda) Then
            total_denda = jatuh_tempo * denda
            TextBox6.Text = total_denda
            Return total_denda
        Else
            Return 0
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        ' Menyimpan data ke table1
        Dim simpan As String = "INSERT IGNORE INTO pengembalian (Kode_Pinjam, Kode_Buku, Nis, Tanggal_Kembali, Jatuh_Tempo, Denda_Perhari, Total_Denda, Tanggal_Pinjam) VALUES ('" & ComboBox1.Text & "', " & " ' " & TextBox1.Text & "' , " & " ' " & TextBox2.Text & "' , " & " ' " & Format(DateTimePicker3.Value, "yyyy-MM-dd") & "' , " & " ' " & TextBox4.Text & "', " & " ' " & TextBox5.Text & "', " & " ' " & TextBox6.Text & "', " & " ' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        Using insertCommand As New MySqlCommand(simpan, conn)

            Dim format1 = Format(DateTimePicker3.Value, "yyyy-MM-dd")
            Dim format2 = Format(DateTimePicker1.Value, "yyyy-MM-dd")

            insertCommand.Parameters.AddWithValue("@ComboBox1.Text", ComboBox1.Text)
            insertCommand.Parameters.AddWithValue("@TextBox1.Text", TextBox1.Text)
            insertCommand.Parameters.AddWithValue("@TextBox2.Text", TextBox2.Text)
            insertCommand.Parameters.AddWithValue("@format1", format1)
            insertCommand.Parameters.AddWithValue("@TextBox4.Text", TextBox4.Text)
            insertCommand.Parameters.AddWithValue("@TextBox5.Text", TextBox5.Text)
            insertCommand.Parameters.AddWithValue("@TextBox6.Text", TextBox6.Text)
            insertCommand.Parameters.AddWithValue("@format2", format2)
            insertCommand.ExecuteNonQuery()
        End Using

        ' Menghapus data dari table2
        'Dim hapus As String = "DELETE FROM peminjaman WHERE Kode_Pinjam = '" & Me.ComboBox1.Text & "'"
        'Using deleteCommand As New MySqlCommand(hapus, conn)
        '    deleteCommand.Parameters.AddWithValue("@ComboBox1.Text", ComboBox1.Text)
        '    deleteCommand.ExecuteNonQuery()
        'End Using
        MsgBox("Berhasil berhasil dikembalikan", MsgBoxStyle.Information, "Success")
        bersih()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        koneksi()
        Dim hapus As String
        hapus = "delete from pengembalian where id = '" & Label19.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        bersih()
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_data()
        tampilDataComboBox1()
        TextBox6.Enabled = False
    End Sub
    Private Sub Form5_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampil_data()
        'tampilDataComboBox1()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("Select * from peminjaman where Kode_Pinjam='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox1.Text = rd.Item("Kode_Buku")
            TextBox2.Text = rd.Item("Nis")
            DateTimePicker1.Value = rd.Item("Tanggal_Pinjam")
            DateTimePicker2.Value = rd.Item("Tanggal_Kembali")
            DateTimePicker1.Enabled = False
            TextBox3.Text = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) & " Hari"
        End If
    End Sub
    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        TextBox4.Text = DateDiff(DateInterval.Day, DateTimePicker2.Value, DateTimePicker3.Value)
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        HitungDenda()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form2.Show()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Form3.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form4.Show()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
                If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
                    ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                    koneksi()
                    cmd = New MySqlCommand("select * from pengembalian where Kode_Buku ='" + TextBox1.Text + "'", conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        Label19.Text = rd.Item("id")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        FormLogin.Show()
    End Sub
    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        MenuLaporan.Show()
        MenuLaporan.btnDataAnggota.Enabled = False
        MenuLaporan.btnDataBuku.Enabled = False
        MenuLaporan.btnPeminjaman.Enabled = False
        MenuLaporan.btnPengembalian.Enabled = True
    End Sub
End Class