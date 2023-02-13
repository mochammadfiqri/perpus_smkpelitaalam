Imports MySql.Data.MySqlClient
Public Class MenuLaporan
    Sub viewdatabuku()
        da = New MySqlDataAdapter("select * from buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "buku")
        conn.Close()
        conn.Dispose()
    End Sub
    Sub viewdataanggota()
        da = New MySqlDataAdapter("select username,password,level,Nis,Nama,JenisKelamin,Kelas,bid_keahlian,komp_keahlian,No_Hp from anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "anggota")
        conn.Close()
        conn.Dispose()
    End Sub
    Sub viewdatapeminjaman()
        da = New MySqlDataAdapter("select * from peminjaman", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "peminjaman")
        conn.Close()
        conn.Dispose()
    End Sub
    Sub viewdatapengembalian()
        da = New MySqlDataAdapter("select * from pengembalian", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengembalian")
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub btnDataAnggota_Click(sender As Object, e As EventArgs) Handles btnDataAnggota.Click
        'ds.Clear()
        db = "Server=103.112.245.4;port=3306;user id=smkkese2_perpus_smkpelitaalam;password=perpus_smkpelitaalam;database=smkkese2_perpus_smkpelitaalam"
        conn = New MySqlConnection(db)
        Dim myrpt As New myreport
        viewdataanggota()
        myrpt.Database.Tables("anggota").SetDataSource(ds)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
    Private Sub btnDataBuku_Click(sender As Object, e As EventArgs) Handles btnDataBuku.Click
        db = "Server=103.112.245.4;port=3306;user id=smkkese2_perpus_smkpelitaalam;password=perpus_smkpelitaalam;database=smkkese2_perpus_smkpelitaalam"
        conn = New MySqlConnection(db)
        Dim myrpt As New myrptBuku
        viewdatabuku()
        myrpt.Database.Tables("buku").SetDataSource(ds)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        db = "Server=103.112.245.4;port=3306;user id=smkkese2_perpus_smkpelitaalam;password=perpus_smkpelitaalam;database=smkkese2_perpus_smkpelitaalam"
        conn = New MySqlConnection(db)
        Dim myrpt As New myrptPeminjaman
        viewdatapeminjaman()
        myrpt.Database.Tables("peminjaman").SetDataSource(ds)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        db = "Server=103.112.245.4;port=3306;user id=smkkese2_perpus_smkpelitaalam;password=perpus_smkpelitaalam;database=smkkese2_perpus_smkpelitaalam"
        conn = New MySqlConnection(db)
        Dim myrpt As New myrptPengembalian
        viewdatapengembalian()
        myrpt.Database.Tables("pengembalian").SetDataSource(ds)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class