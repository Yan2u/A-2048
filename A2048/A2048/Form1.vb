Option Explicit On
Imports System.IO
Imports System.Math
Public Class Form1
    Public mypth As String = Application.StartupPath, bgTheme As String
    Public mode As Integer = 4
    Public nfont As Font
    Public bmp, bg As Bitmap
    Dim img() As Image
    Dim g, h As Graphics
    Public drawx(), drawy() As Integer
    Public data(,) As Long
    Dim offx() As Integer = {1, -1, 0, 0}
    Dim offy() As Integer = {0, 0, 1, -1}
    Dim emp() As Integer
    Dim pscore, pti As Integer
    Public started, moved As Boolean
    Public bborder, brect As Brush
    Public record As String, maxn As Long
    Public Class pdata : Implements IComparable
        Public datmd As Integer
        Public datn, datsc As Long
        Public datname As String
        Public Function print() As String
            Return datname + " | " + CStr(datsc) + " | " + CStr(datn) + " | " + CStr(datmd)
        End Function
        Public Sub New(a As String, b As Long, c As Long, ByVal d As Integer)
            datsc = b
            datn = c
            datmd = d
            datname = a
        End Sub
        Public Sub New(str As String)
            Dim s() As String = Split(str, "|")
            datname = Trim(s(0))
            datsc = CLng(Trim(s(1)))
            datn = CLng(Trim(s(2)))
            datmd = CInt(Trim(s(3)))
        End Sub
        Public Function CompareTo(ByVal x As Object) As Integer Implements IComparable.CompareTo
            Dim ex As pdata = CType(x, pdata)
            If datsc > ex.datsc Then Return -1
            If datsc < ex.datsc Then Return 1
            If datn > ex.datn Then Return -1
            If datn < ex.datn Then Return 1
            If datname < ex.datname Then Return -1
            If datname > ex.datname Then Return 1
            If datmd < ex.datmd Then Return -1
            If datmd > ex.datmd Then Return 1
            Return 0
        End Function
        Public Function Equalwith(ByVal x As pdata) As Boolean
            Return datname = x.datname And datn = x.datn And datsc = x.datsc And datmd = x.datmd
        End Function
    End Class

    Public dats As List(Of pdata)
    Public total As Integer
    Public scnt As Integer

    Private Function GetID(ByVal x As Long) As Integer
        Return CInt(Log10(x) / Log10(2))
    End Function
    Private Function GetPOS(ByVal x As Integer, ByVal y As Integer) As Integer
        Return mode * (x - 1) + y
    End Function
    Private Sub swap(ByRef a As Integer, ByRef b As Integer)
        a = a Xor b
        b = a Xor b
        a = a Xor b
    End Sub
    Public Sub Stat()
        crazy.Enabled = False
        If over.ShowDialog = DialogResult.OK Then
            Dim tmp As pdata = New pdata(over.sav_na.Text, CInt(datx.Text), CInt(over.t2.Text), mode)
            AddSc(tmp)
        End If
    End Sub
    Public Sub AddSc(ByVal p As pdata)
        For i As Integer = 1 To total Step 1
            If dats(i - 1).datname = p.datname And dats(i - 1).datmd = p.datmd Then
                dats(i - 1) = p
                dats.Sort()
                datsgrid()
                Return
            End If
        Next
        total += 1
        dats.Insert(total - 1, p)
        dats.Sort()
        datsgrid()
    End Sub
    Public Sub readfile(ByVal S As String)
        Try
            record = S
            datsins(S)
        Catch ex As Exception
            dats.Clear()
            record = ""
            datsgrid()
        End Try
    End Sub
    Public Sub updbrush(ByVal bor As Color, ByVal rct As Color)
        bborder = New SolidBrush(bor)
        brect = New SolidBrush(rct)
    End Sub
    Public Sub updTheme()
        Select Case bgTheme
            Case "normal"
                bborder = New SolidBrush(Color.FromArgb(187, 173, 160))
                brect = New SolidBrush(Color.FromArgb(205, 193, 180))
                updbmp()
            Case "blue"
                bborder = New SolidBrush(Color.FromArgb(112, 146, 190))
                brect = New SolidBrush(Color.FromArgb(153, 217, 234))
                updbmp()
            Case "green"
                bborder = New SolidBrush(Color.FromArgb(0, 128, 128))
                brect = New SolidBrush(Color.FromArgb(3, 207, 162))
                updbmp()
            Case "grey"
                bborder = New SolidBrush(Color.FromArgb(127, 127, 127))
                brect = New SolidBrush(Color.FromArgb(195, 195, 195))
                updbmp()
            Case "orange"
                bborder = New SolidBrush(Color.FromArgb(255, 128, 64))
                brect = New SolidBrush(Color.FromArgb(244, 174, 11))
                updbmp()
            Case Else
                Try
                    Dim tmp() As String = Split(bgTheme, ",")
                    bborder = New SolidBrush(Color.FromArgb(CInt(tmp(0))))
                    brect = New SolidBrush(Color.FromArgb(CInt(tmp(1))))
                    updbmp()
                    settings.cusborder = Color.FromArgb(CInt(tmp(0)))
                    settings.cusrect = Color.FromArgb(CInt(tmp(1)))
                    settings.cub.Image = bg
                Catch ex As Exception
                    bgTheme = "normal"
                    updTheme()
                    Exit Sub
                End Try
        End Select
    End Sub
    Public Sub updbmp()
        Dim bordwidth As Integer = 8
        Dim sqwidth As Integer = (808 - (mode + 1) * bordwidth) / mode
        Dim x As Integer = 0, y As Integer = 0
        bg = New Bitmap(808, 808)
        h = Graphics.FromImage(bg)
        '绘制纵边
        For i As Integer = 0 To mode Step 1
            h.FillRectangle(bborder, x, y, bordwidth, 808)
            x += bordwidth + sqwidth
        Next
        x = 0
        y = 0
        '绘制横边
        For i As Integer = 0 To mode Step 1
            h.FillRectangle(bborder, x, y, 808, bordwidth)
            y += bordwidth + sqwidth
        Next
        '填充矩形
        x = 8
        y = 8
        For i As Integer = 1 To mode Step 1
            x = 8
            For j As Integer = 1 To mode Step 1
                h.FillRectangle(brect, x, y, sqwidth, sqwidth)
                x += bordwidth + sqwidth
            Next
            y += bordwidth + sqwidth
        Next
        DrawBoard()
    End Sub
    Public Sub LoadResource()
        maxn = 2
        ReDim img(34)
        scnt = 0
        While My.Computer.FileSystem.FileExists(mypth + "\images\_" + CStr(maxn) + ".png") And scnt <= 31
            scnt += 1
            img(scnt) = Image.FromFile(mypth + "\images\_" + CStr(maxn) + ".png")
            maxn *= 2
        End While
        If maxn <= 2048 Then
            MsgBox("缺失基础贴图 _" + CStr(maxn) + ".png", vbOKOnly + vbExclamation, "提示")
            Me.Close()
        End If
        settings.slabel.Text = "贴图数字最大为 " + CStr(maxn / 2)
        modeset()
    End Sub
    Private Sub clearall()
        crazy.Enabled = False
        ReDim data(25, 25)
        datx.Text = "0"
        datp.Text = ""
        pic.Image = bmp
        DrawBoard()
    End Sub
    Public Sub ftset(ByVal str As String)
        nfont = New Font(str, 25, FontStyle.Bold)
        datx.Font = nfont
        datp.Font = nfont
        For Each tb As TextBox In over.Controls.OfType(Of TextBox)
            tb.Font = nfont
        Next
        over.sav_na.Font = New Font("微软雅黑", 25, FontStyle.Bold)
    End Sub
    Public Sub modeset()
        clearall()
        Dim st As Integer = 8
        Dim dsize As Integer = (808 - (mode + 1) * st) / mode
        Dim interv As Integer = dsize + st
        Dim x As Integer = st
        Dim y As Integer = st
        For i As Integer = 1 To mode Step 1
            x = st
            For j As Integer = 1 To mode Step 1
                drawx(GetPOS(i, j)) = x
                drawy(GetPOS(i, j)) = y
                x += interv
            Next
            y += interv
        Next
        started = False
        datsgrid()
        updbmp()
        DrawBoard()
    End Sub
    Private Sub DrawBoard()
        Dim sz As Integer = (808 - (mode + 1) * 8) / mode
        bmp = New Bitmap(bg)
        g = Graphics.FromImage(bmp)
        Dim IDS As Integer = 0
        For i As Integer = 1 To mode Step 1
            For j As Integer = 1 To mode Step 1
                If data(i, j) <> 0 Then
                    IDS = GetPOS(i, j)
                    g.DrawImage(img(GetID(data(i, j))), drawx(IDS), drawy(IDS), sz, sz)
                End If
            Next
        Next
        pic.Image = bmp
    End Sub
    Private Sub Create()
        '随机生成1个数字
        Dim empn As Integer = 0
        For i As Integer = 1 To mode Step 1
            For j As Integer = 1 To mode Step 1
                If data(i, j) = 0 Then
                    empn += 1
                    emp(empn) = GetPOS(i, j)
                End If
            Next
        Next
        If empn = 0 Then Return
        Dim rans = CInt(Rnd() * (empn - 1 + 1) + 1) Mod empn + 1
        Dim rval = CInt(Rnd() * (300 - 1 + 1) + 1) Mod 300 + 1
        rans = emp(rans)
        Dim rrow As Integer = 1
        While rans > mode
            rrow += 1
            rans -= mode
        End While
        If rval <= 100 Then
            data(rrow, rans) = 4
        Else
            data(rrow, rans) = 2
        End If
    End Sub
    Private Function check() As Boolean
        Dim x, y As Integer
        For i As Integer = 1 To mode Step 1
            For j As Integer = 1 To mode Step 1
                For k As Integer = 0 To 3 Step 1
                    x = i + offx(k)
                    y = j + offy(k)
                    If x >= 1 And x <= mode And y >= 1 And y <= mode Then
                        If data(x, y) = 0 Or data(x, y) = data(i, j) Then Return True
                    End If
                Next
            Next
        Next
        Return False
    End Function
    Private Sub MovUp()
        '往上移动
        For j As Integer = 1 To mode Step 1
            For i As Integer = 1 To mode Step 1
                If data(i, j) <> 0 Then
                    For k As Integer = i + 1 To mode Step 1
                        If data(k, j) = data(i, j) Then
                            data(k, j) = 0
                            data(i, j) *= 2
                            moved = True
                            pscore += data(i, j)
                        ElseIf data(k, j) <> 0 Then
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
        For j As Integer = 1 To mode Step 1
            For i As Integer = 1 To mode Step 1
                If data(i, j) = 0 Then
                    For k As Integer = i + 1 To mode Step 1
                        If data(k, j) <> 0 Then
                            swap(data(k, j), data(i, j))
                            moved = True
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub MovDown()
        '往上移动
        For j As Integer = 1 To mode Step 1
            For i As Integer = mode To 1 Step -1
                If data(i, j) <> 0 Then
                    For k As Integer = i - 1 To 1 Step -1
                        If data(k, j) = data(i, j) Then
                            data(k, j) = 0
                            data(i, j) *= 2
                            moved = True
                            pscore += data(i, j)
                        ElseIf data(k, j) <> 0 Then
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
        For j As Integer = 1 To mode Step 1
            For i As Integer = mode To 1 Step -1
                If data(i, j) = 0 Then
                    For k As Integer = i - 1 To 1 Step -1
                        If data(k, j) <> 0 Then
                            swap(data(k, j), data(i, j))
                            moved = True
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub MovLeft()
        '往左移动
        For i As Integer = 1 To mode Step 1
            For j As Integer = 1 To mode Step 1
                If data(i, j) <> 0 Then
                    For k As Integer = j + 1 To mode Step 1
                        If data(i, k) = data(i, j) Then
                            data(i, k) = 0
                            data(i, j) *= 2
                            moved = True
                            pscore += data(i, j)
                        ElseIf data(i, k) <> 0 Then
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
        For i As Integer = 1 To mode Step 1
            For j As Integer = 1 To mode Step 1
                If data(i, j) = 0 Then
                    For k As Integer = j + 1 To mode Step 1
                        If data(i, k) <> 0 Then
                            swap(data(i, k), data(i, j))
                            moved = True
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub MovRight()
        '往右移动
        For i As Integer = 1 To mode Step 1
            For j As Integer = mode To 1 Step -1
                If data(i, j) <> 0 Then
                    For k As Integer = j - 1 To 1 Step -1
                        If data(i, k) = data(i, j) Then
                            data(i, k) = 0
                            data(i, j) *= 2
                            moved = True
                            pscore += data(i, j)
                        ElseIf data(i, k) <> 0 Then
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
        For i As Integer = 1 To mode Step 1
            For j As Integer = mode To 1 Step -1
                If data(i, j) = 0 Then
                    For k As Integer = j - 1 To 1 Step -1
                        If data(i, k) <> 0 Then
                            swap(data(i, k), data(i, j))
                            moved = True
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Public Sub LoadConfig(ByVal S As String)
        Dim strs() As String = Split(S, vbCrLf)
        Dim tmp(9) As String
        For Each str As String In strs
            Try
                tmp = Split(str, "==")
                Select Case tmp(0)
                    Case "Fonts" : ftset(tmp(1))
                    Case "Theme"
                        bgTheme = tmp(1)
                        updTheme()
                    Case "Mode"
                        mode = CInt(tmp(1))
                        modeset()
                    Case "Record"
                        readfile(tmp(1))
                End Select
            Catch ex As Exception
                GoTo Label
            End Try
Label:  Next
    End Sub
    Public Sub saveconfig()
        Dim sw As StreamWriter = New StreamWriter(mypth + "\images\config.ini", False, System.Text.Encoding.UTF8)
        With sw
            .WriteLine("A2048 Settings Stored at " + Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            .WriteLine("Fonts==" + nfont.Name)
            .WriteLine("Theme==" + bgTheme)
            .WriteLine("Mode==" + CStr(mode))
            If total > 0 Then
                .Write("Record==")
                .Write(dats(0).print())
                For i As Integer = 2 To total Step 1
                    .Write(" & " + dats(i - 1).print())
                Next
            End If
        End With
        sw.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '初始化
        Randomize()
        Dim tmp As String = ""
        ReDim drawx(455), drawy(455), data(25, 25)
        ReDim emp(455)
        bmp = New Bitmap(808, 808)
        bg = New Bitmap(808, 808)
        bgTheme = "normal"
        updTheme()
        started = moved = False
        dats = New List(Of pdata)
        Try
            ftset("Montserrat")
        Catch ex As Exception
            ftset("consolas")
        End Try
        '加载贴图
        LoadResource()
        '加载预设
        If My.Computer.FileSystem.FileExists(mypth + "\images\config.ini") Then
            Dim sr As StreamReader = New StreamReader(mypth + "\images\config.ini", System.Text.Encoding.UTF8)
            tmp = sr.ReadToEnd()
            sr.Close()
            LoadConfig(tmp)
        Else
            saveconfig()
        End If
        DrawBoard()
    End Sub
    Public Sub datsins(ByVal S As String)
        total = 0
        dats.Clear()
        Dim tmp As pdata
        Dim strs() As String = Split(S, "&")
        For Each str As String In strs
            If str <> "" Then
                total += 1
                tmp = New pdata(str)
                dats.Insert(total - 1, tmp)
            End If
        Next
        dats.Sort()
        datsgrid()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        about.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearall()
        Create()
        Create()
        started = True
        DrawBoard()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        dats.Clear()
        total = 0
        record = ""
        datsgrid()
    End Sub

    Private Sub dat1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dat1.CellDoubleClick
        If MsgBox("确定要删除此玩家的信息吗？", vbOKCancel + vbExclamation, "提示") = DialogResult.OK Then
            Dim format As String = CStr(dat1.Rows(e.RowIndex).Cells(1).Value)
            For i As Integer = 2 To 3 Step 1
                format += " | "
                format += CStr(dat1.Rows(e.RowIndex).Cells(i).Value)
            Next
            format += " | " + CStr(mode)
            Dim tmp As pdata = New pdata(format)
            For i As Integer = 1 To total Step 1
                If dats(i - 1).Equalwith(tmp) Then
                    dats.RemoveAt(i - 1)
                    Exit For
                End If
            Next
            total -= 1
            datsgrid()
        End If
    End Sub


    Private Sub crazy_Tick(sender As Object, e As EventArgs) Handles crazy.Tick
        tr1.Enabled = False
        datp.Text = ""
        pti = 0
        moved = False
        pscore = 0
        Dim ran = CInt(Rnd() * (4 - 1 + 1) + 1) Mod 4 + 1
        Select Case ran
            Case 1 : MovUp()
            Case 2 : MovDown()
            Case 3 : MovLeft()
            Case 4 : MovRight()
        End Select
        If moved Then Create()
        DrawBoard()
        datx.Text = CStr(CLng(datx.Text) + pscore)
        If pscore > 0 Then
            datp.Text = "+ " + CStr(pscore)
            tr1.Enabled = True
        End If
        If Not check() Then
            crazy.Enabled = False
            started = False
            Stat()
        End If
    End Sub

    Private Sub pic_DoubleClick(sender As Object, e As EventArgs) Handles pic.DoubleClick
        If Not started Then Exit Sub
        crazy.Enabled = Not crazy.Enabled
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        saveconfig()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        help.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        settings.Show()
    End Sub

    Private Sub dat1_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dat1.RowStateChanged
        If e.Row.Index + 1 = 1 Then
            dat1.Rows(e.Row.Index).DefaultCellStyle.BackColor = Color.Gold
        ElseIf e.Row.Index + 1 = 2 Then
            dat1.Rows(e.Row.Index).DefaultCellStyle.BackColor = Color.Silver
        ElseIf e.Row.Index + 1 = 3 Then
            dat1.Rows(e.Row.Index).DefaultCellStyle.BackColor = Color.Brown
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If total = 0 Then Exit Sub
        If sf1.ShowDialog = DialogResult.OK Then
            Dim cnt As Integer = 0
            Dim strout As String = My.Resources.html
            Dim strcus As String = ""
            strout = Replace(strout, "模式：4×4", "模式：" + CStr(mode) + "×" + CStr(mode))
            For i As Integer = 1 To total Step 1
                If dats(i - 1).datmd = mode Then
                    cnt += 1
                    strcus += "<tr style='text-align:center;' >"
                    strcus += "<td style='text-align:center;' ><span>"
                    strcus += CStr(cnt)
                    strcus += "</span></td>"

                    strcus += "<td style='text-align:center;' ><span>"
                    strcus += dats(i - 1).datname
                    strcus += "</span></td>"

                    strcus += "<td style='text-align:center;' ><span>"
                    strcus += CStr(dats(i - 1).datsc)
                    strcus += "</span></td>"

                    strcus += "<td style='text-align:center;' ><span>"
                    strcus += CStr(dats(i - 1).datn)
                    strcus += "</span></td>"

                    strcus += "</tr>"
                End If
            Next
            strout = Replace(strout, "<!--EDIT START-->", strcus)
            Dim sw As StreamWriter = New StreamWriter(sf1.FileName, False, System.Text.Encoding.UTF8)
            sw.Write(strout)
            sw.Close()
            Process.Start(sf1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not started Then Return
        started = False
        Stat()
    End Sub

    Private Sub tr1_Tick(sender As Object, e As EventArgs) Handles tr1.Tick
        pti += 1
        If pti >= 1 Then
            tr1.Enabled = False
            datp.Text = ""
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not started Then Return
        tr1.Enabled = False
        datp.Text = ""
        pti = 0
        moved = False
        pscore = 0
        Select Case (e.KeyCode)
            Case Keys.W : MovUp()
            Case Keys.A : MovLeft()
            Case Keys.S : MovDown()
            Case Keys.D : MovRight()
        End Select
        If moved Then Create()
        DrawBoard()
        datx.Text = CStr(CLng(datx.Text) + pscore)
        If pscore > 0 Then
            datp.Text = "+ " + CStr(pscore)
            tr1.Enabled = True
        End If
        If Not check() Then
            started = False
            Stat()
        End If
    End Sub

    Public Sub datsgrid()
        dat1.Rows.Clear()
        Dim x As Integer = 0
        If total = 0 Then Return
        For i As Integer = 1 To total Step 1
            If dats(i - 1).datmd = mode Then
                x += 1
                dat1.Rows.Add(CStr(x), CStr(dats(i - 1).datname), CStr(dats(i - 1).datsc), CStr(dats(i - 1).datn))
            End If
        Next
        saveconfig()
    End Sub

End Class
