﻿Imports MySql.Data.MySqlClient
'Imports System.IO
Public Class FormProfile
    'untuk memuncukan gambar dari url
    'Sub Ketemu()
    '    PictureBox1.ImageLocation = Label5.Text
    'End Sub
    'Sub disable()
    '    nis.Enabled = False
    '    nama.Enabled = False
    '    gender.Enabled = False
    '    kelas.Enabled = False
    '    bid_keahlian.Enabled = False
    '    komp_keahlian.Enabled = False
    '    no_hp.Enabled = False
    '    usrname.Enabled = False
    '    psswrd.Enabled = False
    '    lvl_usr.Enabled = False
    'End Sub
    'fungsi untuk meanmpilkan data anggota ke dalam textboxt
    'Sub Tampildata_Anggota()
    '    Try
    '        koneksi()
    '        cmd = New MySqlCommand("select * from anggota where username ='" + txtAnggota.Text + "'", conn)
    '        rd = cmd.ExecuteReader
    '        rd.Read()
    '        If rd.HasRows Then
    '            usrname.Text = rd.Item("username")
    '            psswrd.Text = rd.Item("password")
    '            lvl_usr.Text = rd.Item("level")
    '            nis.Text = rd.Item("Nis")
    '            nama.Text = rd.Item("Nama")
    '            gender.Text = rd.Item("JenisKelamin")
    '            kelas.Text = rd.Item("Kelas")
    '            bid_keahlian.Text = rd.Item("bid_keahlian")
    '            komp_keahlian.Text = rd.Item("komp_keahlian")
    '            no_hp.Text = rd.Item("no_hp")
    '            img_path()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    'Menampilkan Url ke label
    Sub CariUrl()
        koneksi()
        cmd = New MySqlCommand("select * from anggota where img ='" & Label5.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
    End Sub
    'menampilkan url image
    Sub img_path()
        Try
            koneksi()
            cmd = New MySqlCommand("select * from anggota where username='" + txtAnggota.Text + "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Label5.Text = rd.Item("img")
            End If
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable()
        CariUrl()
        txtAnggota.Text = ""
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    'berfungsi untuk pindah form
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        form_daftarbuku.Show()
    End Sub

    'berfungsi untuk menampilkan data anggota sesuai akun yang login
    Private Sub txtAnggota_TextChanged(sender As Object, e As EventArgs) Handles txtAnggota.TextChanged
        'pertama tampilkan data anggota
        'Tampildata_Anggota()
        'kedua munculkan url image
        '        img_path()
        'lalu jika ketemu, munuculkan gambar
        'If rd.HasRows Then
        '    Ketemu()
        'End If
    End Sub
    Private Sub FormProfile_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CariUrl()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form_detailAnggota.Show()
    End Sub
End Class