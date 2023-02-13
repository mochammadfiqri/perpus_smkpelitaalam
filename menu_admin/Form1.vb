Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        If Formloading.ShowDialog Then
            Form4.Show()
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        If Formloading.ShowDialog Then
            Form3.Show()
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        If Formloading.ShowDialog Then
            Form2.Show()
        End If
    End Sub
    Private Sub PictureBox5_Click1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        If Formloading.ShowDialog Then
            Form5.Show()
        End If
    End Sub
    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        MsgBox("Dibuat Oleh Mochammad Fiqri A", MsgBoxStyle.Information, "About Me")
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLjam.Text = TimeOfDay
    End Sub
    Private Sub HowToLogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToLogOutToolStripMenuItem.Click
        MsgBox("Silahkan klik kanan untuk memilih tombol log out", MsgBoxStyle.Information, "Information")
    End Sub
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        If MessageBox.Show("Anda yakin akan Log Out?", "Log Out", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MsgBox("Terima Kasih, Anda telah Log Out", MsgBoxStyle.Information, "Information")
            Me.Hide()
            FormLogin.Show()
        Else
        End If
    End Sub

End Class
