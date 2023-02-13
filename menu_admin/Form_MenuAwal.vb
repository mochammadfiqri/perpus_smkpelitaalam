Imports MySql.Data.MySqlClient
Public Class Form_MenuAwal
    Sub btnDisable()
        TextBox1.Enabled = False
        TextBox12.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox11.Enabled = False

        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
    End Sub
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
    Private Sub Form_MenuAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampildata_buku()
        btnDisable()
        Panel3.AutoScroll = True
    End Sub
    Private Sub Form_MenuAwal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampildata_buku()
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
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FormLogin.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
                If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
                    TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    TextBox12.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                    TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                    TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                    TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
                    TextBox11.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                    TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
                    TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
                    TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
                    TextBox9.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class