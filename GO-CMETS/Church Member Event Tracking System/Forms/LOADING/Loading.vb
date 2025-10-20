Public Class Loading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Guna2Panel2.Width += 65

        If Guna2Panel2.Width >= 600 Then
            Timer1.Stop()
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2Panel2.Width = 0
        Timer1.Interval = 100
        Timer1.Start()
    End Sub
End Class