Imports MySql.Data.MySqlClient
Public Class form_daftarbuku
    Dim table As DataTable
    Sub databaru()
        On Error Resume Next
        TextBox2.Clear()
        search.Clear()
        TextBox2.Focus()
        'pdf_reader.src = (TextBox2.Text)
    End Sub
    Sub Kosongkan()
        On Error Resume Next
        TextBox1.Clear()
        TextBox2.Clear()
        search.Clear()
        'TextBox1.Focus()
        'pdf_reader.src = (TextBox2.Text)
    End Sub
    Sub Ketemu()
        'On Error Resume Next
        TextBox1.Text = rd(0)
        TextBox2.Text = rd(10)
        Dim frm_baca As New Form_bacabuku
        frm_baca.Show()
        frm_baca.pdf_reader.src = (TextBox2.Text)
        'pdf_reader.src = (TextBox2.Text)
    End Sub
    Sub Carikode()
        koneksi()
        cmd = New MySqlCommand("select * from buku where Kode_Buku='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
    End Sub
    Sub tampil_data()
        koneksi()
        '------- Untuk menampilkan data di datagrid -----------
        da = New MySqlDataAdapter("Select * from buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "buku")
        DataGridView1.DataSource = (ds.Tables("buku"))
        conn.Close()
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub form_daftarbuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'koneksi()
        'Kosongkan()
        tampil_data()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
                If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
                    TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
                    Carikode()
                    If rd.HasRows Then
                        Ketemu()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, search.TextChanged
        koneksi()
        '----------- menyaring di datagrid---------
        da = New MySqlDataAdapter("select * from buku where Judul like '%" & Me.search.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "buku")
        DataGridView1.DataSource = (ds.Tables("buku"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        FormLogin.Show()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        FormProfile.Show()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        TextBox1.MaxLength = 10 'batas max digit
        If e.KeyCode = Keys.Enter Then
            Carikode()
            If rd.HasRows Then
                Ketemu()
            Else
                databaru()
            End If
        End If
    End Sub
End Class