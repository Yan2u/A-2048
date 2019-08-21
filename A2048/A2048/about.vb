Option Explicit On
Public Class about
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("mailto:WIIINER@outlook.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class