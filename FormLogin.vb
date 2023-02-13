Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Bersih()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtLevel.Text = "Pilih--"
        txtUsername.Focus()
    End Sub
    Sub Hak_level()
        txtLevel.Items.Add("Admin")
        txtLevel.Items.Add("Anggota")
        txtLevel.Text = "Pilih--"
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hak_level()
        Dim ColorHint As Color
        Dim ColorText As Color
        ColorHint = Color.FromArgb(210, 210, 210)
        ColorText = Color.Black
        txtPassword.UseSystemPasswordChar = True
        Bersih()
        txtUsername.Focus()
    End Sub
    Private Sub TxtUsername_MouseEnter(sender As Object, e As EventArgs) Handles txtUsername.MouseEnter
        Dim ColorText As Color
        ColorText = Color.Black
        If txtUsername.Text = "Enter Your Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = ColorText
        End If
    End Sub
    Private Sub TxtPassword_MouseEnter(sender As Object, e As EventArgs) Handles txtPassword.MouseEnter
        Dim ColorText As Color
        ColorText = Color.Black
        If txtPassword.Text = "Enter Your Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = ColorText
        End If
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            koneksi()
            cmd = New MySqlCommand("SELECT * FROM anggota WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "' AND level='" + txtLevel.Text + "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd("level").ToString = "Admin" Then
                    Hide()
                    Form1.Show()
                    Form_MenuAwal.Hide()
                    Form1.LBLuser.Text = txtUsername.Text
                ElseIf rd("level").ToString = "Anggota" Then
                    Hide()
                    FormProfile.Show()
                    Form_MenuAwal.Hide()
                    FormProfile.txtAnggota.Text = txtUsername.Text
                End If
            Else
                rd.Close()
                MessageBox.Show("Kombinasi Username, Password, dan Hak Akses Salah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Bersih()
                txtUsername.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form_MenuAwal.Show()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MessageBox.Show("Untuk saat ini, harap hubungi admin terlebih dahulu untuk membuat akun", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MessageBox.Show("Untuk saat ini, harap hubungi admin terlebih dahulu untuk me-reset password", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class