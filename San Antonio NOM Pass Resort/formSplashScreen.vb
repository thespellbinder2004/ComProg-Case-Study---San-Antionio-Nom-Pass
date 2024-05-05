Public Class formSplashScreen


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Hide()
            formBooking.Show()
        Else
            ProgressBar1.PerformStep()

        End If
    End Sub

    Private Sub formSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class