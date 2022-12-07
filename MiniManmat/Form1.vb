Public Class Form1
    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newProgress = progress + 1
        progress = newProgress

        If (progress = 100) Then
            Timer1.Stop()
            Me.Hide()


        End If

        ProgressBar1.Value = newProgress
        lbl_loading.Text = "Loading.. " & newProgress & "%"
    End Sub
End Class
