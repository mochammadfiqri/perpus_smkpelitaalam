Public Class Formloading
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Close()
            'MessageBox.Show("Progress bar selesai")
            'If vbOK = MsgBoxResult.Ok Then
            '    Me.Close()
            'End If
        End If
    End Sub
End Class