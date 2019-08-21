Option Explicit On
Imports System.IO
Public Class help
    Dim x As Integer

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim sw As New StreamWriter(Form1.mypth + "\A2048初级使用手册.html", False, System.Text.Encoding.UTF8)
        sw.Write(My.Resources.basichelp)
        sw.Close()
        Process.Start(Form1.mypth + "\A2048初级使用手册.html")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim sw As New StreamWriter(Form1.mypth + "\A2048进阶使用手册.html", False, System.Text.Encoding.UTF8)
        sw.Write(My.Resources.advanhelp)
        sw.Close()
        Process.Start(Form1.mypth + "\A2048进阶使用手册.html")
    End Sub
End Class