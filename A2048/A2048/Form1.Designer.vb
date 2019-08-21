<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dat1 = New System.Windows.Forms.DataGridView()
        Me.dat_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dat_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dat_score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dat_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.datp = New System.Windows.Forms.TextBox()
        Me.datx = New System.Windows.Forms.TextBox()
        Me.op1 = New System.Windows.Forms.OpenFileDialog()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.sf1 = New System.Windows.Forms.SaveFileDialog()
        Me.tr1 = New System.Windows.Forms.Timer(Me.components)
        Me.crazy = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(826, 521)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 292)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "选项"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(8, 140)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(224, 45)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "清除数据"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(159, 228)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(145, 45)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "选项"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(310, 228)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 45)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "关于……"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 228)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 45)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "帮助"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "其他："
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(238, 140)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(224, 45)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "导出数据（HTML）"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "数据："
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(238, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "结束游戏"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "游戏："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "新游戏"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dat1)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(826, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 402)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "统计"
        '
        'dat1
        '
        Me.dat1.AllowUserToAddRows = False
        Me.dat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dat1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dat_id, Me.dat_name, Me.dat_score, Me.dat_num})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dat1.DefaultCellStyle = DataGridViewCellStyle24
        Me.dat1.Location = New System.Drawing.Point(6, 28)
        Me.dat1.Name = "dat1"
        Me.dat1.ReadOnly = True
        Me.dat1.RowHeadersVisible = False
        Me.dat1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dat1.RowTemplate.Height = 40
        Me.dat1.RowTemplate.ReadOnly = True
        Me.dat1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dat1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dat1.Size = New System.Drawing.Size(463, 368)
        Me.dat1.TabIndex = 0
        '
        'dat_id
        '
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.dat_id.DefaultCellStyle = DataGridViewCellStyle21
        Me.dat_id.HeaderText = "名次"
        Me.dat_id.Name = "dat_id"
        Me.dat_id.ReadOnly = True
        Me.dat_id.Width = 75
        '
        'dat_name
        '
        Me.dat_name.HeaderText = "名称"
        Me.dat_name.Name = "dat_name"
        Me.dat_name.ReadOnly = True
        Me.dat_name.Width = 165
        '
        'dat_score
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.dat_score.DefaultCellStyle = DataGridViewCellStyle22
        Me.dat_score.HeaderText = "分数"
        Me.dat_score.Name = "dat_score"
        Me.dat_score.ReadOnly = True
        Me.dat_score.Width = 110
        '
        'dat_num
        '
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.dat_num.DefaultCellStyle = DataGridViewCellStyle23
        Me.dat_num.HeaderText = "最大数字"
        Me.dat_num.Name = "dat_num"
        Me.dat_num.ReadOnly = True
        Me.dat_num.Width = 110
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.datp)
        Me.GroupBox3.Controls.Add(Me.datx)
        Me.GroupBox3.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(826, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "分数"
        '
        'datp
        '
        Me.datp.BackColor = System.Drawing.SystemColors.Control
        Me.datp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datp.Font = New System.Drawing.Font("Consolas", 25.0!)
        Me.datp.ForeColor = System.Drawing.Color.Teal
        Me.datp.Location = New System.Drawing.Point(268, 40)
        Me.datp.Multiline = True
        Me.datp.Name = "datp"
        Me.datp.ReadOnly = True
        Me.datp.Size = New System.Drawing.Size(201, 54)
        Me.datp.TabIndex = 1
        Me.datp.Text = "0"
        Me.datp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datx
        '
        Me.datx.BackColor = System.Drawing.SystemColors.Control
        Me.datx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datx.Font = New System.Drawing.Font("Consolas", 25.0!)
        Me.datx.Location = New System.Drawing.Point(15, 40)
        Me.datx.Multiline = True
        Me.datx.Name = "datx"
        Me.datx.ReadOnly = True
        Me.datx.Size = New System.Drawing.Size(247, 54)
        Me.datx.TabIndex = 0
        Me.datx.Text = "0"
        Me.datx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'op1
        '
        Me.op1.FileName = "OpenFileDialog1"
        Me.op1.Filter = "所有文件(*.*)|*.*"
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.SystemColors.Control
        Me.pic.Location = New System.Drawing.Point(12, 12)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(808, 808)
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'sf1
        '
        Me.sf1.Filter = "html文件(*.html)|*.html"
        '
        'tr1
        '
        Me.tr1.Interval = 1000
        '
        'crazy
        '
        Me.crazy.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 823)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1325, 862)
        Me.MinimumSize = New System.Drawing.Size(1325, 862)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A2048"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents datx As TextBox
    Friend WithEvents op1 As OpenFileDialog
    Friend WithEvents dat1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents sf1 As SaveFileDialog
    Friend WithEvents dat_id As DataGridViewTextBoxColumn
    Friend WithEvents dat_name As DataGridViewTextBoxColumn
    Friend WithEvents dat_score As DataGridViewTextBoxColumn
    Friend WithEvents dat_num As DataGridViewTextBoxColumn
    Friend WithEvents datp As TextBox
    Friend WithEvents tr1 As Timer
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents crazy As Timer
End Class
