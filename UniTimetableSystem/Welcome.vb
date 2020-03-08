Public Class Welcome
    Dim load As Integer = 0
    Public loginflag As Integer = 0 'to determine the user type
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If load < 10 Then
            load += 1
            ProgressBar1.PerformStep()
        Else
            Timer1.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub


End Class