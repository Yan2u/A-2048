Option Explicit On
Public Class over
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If sav_na.Text = "" Then
            MsgBox("请输入名称", vbOKOnly + vbExclamation, "提示")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub over_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t1.Text = Form1.datx.Text
        Dim x As Long = 0
        For i As Integer = 1 To Form1.mode Step 1
            For j As Integer = 1 To Form1.mode Step 1
                x = Math.Max(x, Form1.data(i, j))
            Next
        Next
        t2.Text = CStr(x)
        If sav_na.Text = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub sav_na_TextChanged(sender As Object, e As EventArgs) Handles sav_na.TextChanged
        If sav_na.Text = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
End Class