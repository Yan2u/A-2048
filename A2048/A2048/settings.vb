Option Explicit On
Imports System.IO
Public Class settings
    Public cusborder, cusrect As Color
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        slabel.Text = "贴图数字最大为 " + CStr(Form1.maxn / 2)
        fpre.Font = Form1.nfont
        fpre.Text = Form1.nfont.Name
        cb1.Text = CStr(Form1.mode) + "×" + CStr(Form1.mode)
        For Each cdb As RadioButton In pl1.Controls.OfType(Of RadioButton)
            If InStr(cdb.Name, Form1.bgTheme) <> 0 Then
                cdb.Checked = True
            Else
                cdb.Checked = False
            End If
        Next
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If fd1.ShowDialog = DialogResult.OK Then
            Form1.ftset(fd1.Font.Name)
            fpre.Font = Form1.nfont
            fpre.Text = Form1.nfont.Name
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim tmp() As String = Split(cb1.Text, "×")
        Form1.mode = CInt(tmp(0))
        Form1.modeset()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form1.LoadResource()
    End Sub
    Public Sub updColor()
        If cusborder = Nothing Or cusrect = Nothing Then Exit Sub
        Form1.bgTheme = CStr(cusborder.ToArgb) + "," + CStr(cusrect.ToArgb)
        Form1.updTheme()
    End Sub
    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rb_orange.CheckedChanged, rb_normal.CheckedChanged, rb_grey.CheckedChanged, rb_green.CheckedChanged, rb_blue.CheckedChanged, rb_brush.CheckedChanged
        For Each cdb As RadioButton In pl1.Controls.OfType(Of RadioButton)
            If cdb.Checked = True Then
                If cdb.Name = "rb_brush" Then
                    If cf1.ShowDialog() = DialogResult.OK Then
                        cusborder = cf1.Color
                    Else
                        cusborder = Nothing
                    End If
                    If cf1.ShowDialog() = DialogResult.OK Then
                        cusrect = cf1.Color
                    Else
                        cusrect = Nothing
                    End If
                    cdb.Checked = False
                    updColor()
                    Exit For
                End If
                Form1.bgTheme = Replace(cdb.Name, "rb_", "")
                Form1.updTheme()
                Exit For
            End If
        Next
    End Sub

    Private Sub settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.saveconfig()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://downsc.chinaz.net/Files/DownLoad/font4/201711/font1048.rar")
    End Sub

    Private Sub cub_Click(sender As Object, e As EventArgs) Handles cub.Click
        updColor()
    End Sub
End Class