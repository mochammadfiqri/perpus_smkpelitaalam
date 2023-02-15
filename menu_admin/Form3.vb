Imports MySql.Data.MySqlClient
Public Class Form3
    Sub tampildata_buku()
        koneksi()
        '------- Untuk menampilkan data di datagrid -----------
        da = New MySqlDataAdapter("Select Kode_Buku,tipe_buku,Judul,Penulis,Tahun_Terbit,halaman,asal_kota,Penerbit,url,isbn_issn from buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "buku")
        DataGridView1.DataSource = (ds.Tables("buku"))
        conn.Close()
    End Sub
    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampildata_buku()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label1.Text = "" Then
            MsgBox("Silahkan pilih data yang akan dihapus", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            ' ------- Coding hapus data --------
            If MessageBox.Show("Anda yakin akan menghapus datanya ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                koneksi()
                Dim hapus As String
                hapus = "delete from buku where Kode_Buku = '" & Me.Label1.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                'Label1.Text = ""
                tampildata_buku()
            Else

            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
                koneksi()
                Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
                Dim index As Integer = e.RowIndex
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)
                Dim frm As New Form_tambahbuku()
                If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
                    Label1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    frm.TextBox1.Text = selectedRow.Cells(0).Value.ToString()
                    frm.tipe_buku.Text = selectedRow.Cells(1).Value.ToString()
                    frm.TextBox2.Text = selectedRow.Cells(2).Value.ToString()
                    frm.TextBox3.Text = selectedRow.Cells(3).Value.ToString()
                    frm.TextBox4.Text = selectedRow.Cells(4).Value.ToString()
                    frm.TextBox5.Text = selectedRow.Cells(5).Value.ToString()
                    frm.TextBox6.Text = selectedRow.Cells(6).Value.ToString()
                    frm.TextBox7.Text = selectedRow.Cells(7).Value.ToString()
                    frm.TextBox8.Text = selectedRow.Cells(8).Value.ToString()
                    frm.TextBox9.Text = selectedRow.Cells(9).Value.ToString()

                    frm.Show()
                    frm.Button2.Text = "Edit"
                    frm.TextBox1.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        '----------- menyaring di datagrid---------
        da = New MySqlDataAdapter("select * from buku where Judul like '%" & Me.TextBox6.Text & "%' or tipe_buku like '%" _
                                  & Me.TextBox6.Text & "%' or Tahun_terbit like '%" & Me.TextBox6.Text & "%' or Penulis like '%" &
                                  Me.TextBox6.Text & "%' or Penerbit like '%" & Me.TextBox6.Text & "%' or isbn_issn like '%" & Me.TextBox6.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "buku")
        DataGridView1.DataSource = (ds.Tables("buku"))
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form_tambahbuku.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        tampildata_buku()
        TextBox6.Text = ""
    End Sub
    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        MsgBox("Dibuat Oleh Mochammad Fiqri A", MsgBoxStyle.Information, "About Me")
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Form5.Show()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.hide()
        Form2.Show()
    End Sub
    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        MenuLaporan.Show()
        MenuLaporan.btnDataAnggota.Enabled = False
        MenuLaporan.btnDataBuku.Enabled = True
        MenuLaporan.btnPeminjaman.Enabled = False
        MenuLaporan.btnPengembalian.Enabled = False
    End Sub
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        FormLogin.Show()
    End Sub
End Class