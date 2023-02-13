'imports data mysql dari library VB.net
Imports MySql.Data.MySqlClient
'Imports System.Data
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public dt As DataTable
    Public da As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public db As String
    Public Sub koneksi()
        'untuk koneksi data , server localhost, user id buat aja root (default)
        ' paswword kosongin kalau default, database di sesuaikan

        db = "Server=localhost;port=3306;user id=root;password=;database=perpus_smkpelitaalam"
        'db = "Server=103.112.245.4;port=3306;user id=smkkese2_perpus_smkpelitaalam;password=perpus_smkpelitaalam;database=smkkese2_perpus_smkpelitaalam"
        conn = New MySqlConnection(db)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Koneksi ke database berhasil", MsgBoxStyle.Information, "Informasi")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Function SQLTable(ByVal Source As String) As DataTable
        ' ---fungsi untuk membuat nomor otomatis dengan menghubungkan pada field yang ada di table--
        Try
            Dim adp As New MySqlDataAdapter(Source, conn)
            Dim DT As New DataTable
            adp.Fill(DT)
            SQLTable = DT
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function
End Module