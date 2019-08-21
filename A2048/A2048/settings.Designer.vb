<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fpre = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.fd1 = New System.Windows.Forms.FontDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.slabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rb_normal = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rb_blue = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rb_green = New System.Windows.Forms.RadioButton()
        Me.rb_grey = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.rb_orange = New System.Windows.Forms.RadioButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pl1 = New System.Windows.Forms.Panel()
        Me.rb_brush = New System.Windows.Forms.RadioButton()
        Me.op2 = New System.Windows.Forms.OpenFileDialog()
        Me.cub = New System.Windows.Forms.PictureBox()
        Me.cf1 = New System.Windows.Forms.ColorDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl1.SuspendLayout()
        CType(Me.cub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "选项菜单："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(639, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "----------------------------------------------------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "字体设置："
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(123, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(101, 30)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "更改字体"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(11, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "字体预览："
        '
        'fpre
        '
        Me.fpre.AutoSize = True
        Me.fpre.Font = New System.Drawing.Font("微软雅黑", 25.0!, System.Drawing.FontStyle.Bold)
        Me.fpre.Location = New System.Drawing.Point(123, 97)
        Me.fpre.Name = "fpre"
        Me.fpre.Size = New System.Drawing.Size(156, 45)
        Me.fpre.TabIndex = 7
        Me.fpre.Text = "字体预览"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(230, 58)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(313, 30)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "（推荐使用Montserrat字体）"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(11, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 30)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "模式选项："
        '
        'cb1
        '
        Me.cb1.BackColor = System.Drawing.SystemColors.Control
        Me.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb1.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"4×4", "5×5", "8×8", "10×10", "16×16", "20×20"})
        Me.cb1.Location = New System.Drawing.Point(128, 209)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(138, 40)
        Me.cb1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(13, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(639, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "----------------------------------------------------------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(12, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(453, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "统计时将不会显示与当前模式不同的玩家的得分"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(295, 211)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(101, 30)
        Me.LinkLabel3.TabIndex = 13
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "更改模式"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(12, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(639, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "----------------------------------------------------------------------"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(12, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 30)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "贴图选项："
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel4.Location = New System.Drawing.Point(496, 300)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(145, 30)
        Me.LinkLabel4.TabIndex = 16
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "重新载入贴图"
        Me.LinkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(12, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(507, 28)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "贴图文件需要放人和程序同一目录下的images文件夹"
        '
        'slabel
        '
        Me.slabel.AutoSize = True
        Me.slabel.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.slabel.Location = New System.Drawing.Point(126, 300)
        Me.slabel.Name = "slabel"
        Me.slabel.Size = New System.Drawing.Size(174, 30)
        Me.slabel.TabIndex = 18
        Me.slabel.Text = "贴图数字最大为 "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(12, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 28)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "设置的字体仅用于显示分数"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(12, 370)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(639, 19)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "----------------------------------------------------------------------"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(12, 389)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 30)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "背景选项："
        '
        'rb_normal
        '
        Me.rb_normal.AutoSize = True
        Me.rb_normal.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.rb_normal.Location = New System.Drawing.Point(14, 8)
        Me.rb_normal.Name = "rb_normal"
        Me.rb_normal.Size = New System.Drawing.Size(70, 31)
        Me.rb_normal.TabIndex = 22
        Me.rb_normal.TabStop = True
        Me.rb_normal.Text = "默认"
        Me.rb_normal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A2048.My.Resources.Resources.theme_normal
        Me.PictureBox1.Location = New System.Drawing.Point(17, 473)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'rb_blue
        '
        Me.rb_blue.AutoSize = True
        Me.rb_blue.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.rb_blue.Location = New System.Drawing.Point(107, 8)
        Me.rb_blue.Name = "rb_blue"
        Me.rb_blue.Size = New System.Drawing.Size(70, 31)
        Me.rb_blue.TabIndex = 24
        Me.rb_blue.TabStop = True
        Me.rb_blue.Text = "蓝色"
        Me.rb_blue.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(124, 473)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'rb_green
        '
        Me.rb_green.AutoSize = True
        Me.rb_green.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.rb_green.Location = New System.Drawing.Point(218, 8)
        Me.rb_green.Name = "rb_green"
        Me.rb_green.Size = New System.Drawing.Size(70, 31)
        Me.rb_green.TabIndex = 26
        Me.rb_green.TabStop = True
        Me.rb_green.Text = "绿色"
        Me.rb_green.UseVisualStyleBackColor = True
        '
        'rb_grey
        '
        Me.rb_grey.AutoSize = True
        Me.rb_grey.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.rb_grey.Location = New System.Drawing.Point(321, 8)
        Me.rb_grey.Name = "rb_grey"
        Me.rb_grey.Size = New System.Drawing.Size(70, 31)
        Me.rb_grey.TabIndex = 27
        Me.rb_grey.TabStop = True
        Me.rb_grey.Text = "灰色"
        Me.rb_grey.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.A2048.My.Resources.Resources.theme_green
        Me.PictureBox3.Location = New System.Drawing.Point(231, 473)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.A2048.My.Resources.Resources.theme_grey
        Me.PictureBox4.Location = New System.Drawing.Point(338, 473)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'rb_orange
        '
        Me.rb_orange.AutoSize = True
        Me.rb_orange.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.rb_orange.Location = New System.Drawing.Point(428, 8)
        Me.rb_orange.Name = "rb_orange"
        Me.rb_orange.Size = New System.Drawing.Size(70, 31)
        Me.rb_orange.TabIndex = 30
        Me.rb_orange.TabStop = True
        Me.rb_orange.Text = "橙色"
        Me.rb_orange.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.A2048.My.Resources.Resources.theme_orange
        Me.PictureBox5.Location = New System.Drawing.Point(445, 473)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'pl1
        '
        Me.pl1.Controls.Add(Me.rb_brush)
        Me.pl1.Controls.Add(Me.rb_normal)
        Me.pl1.Controls.Add(Me.rb_blue)
        Me.pl1.Controls.Add(Me.rb_green)
        Me.pl1.Controls.Add(Me.rb_grey)
        Me.pl1.Controls.Add(Me.rb_orange)
        Me.pl1.Location = New System.Drawing.Point(17, 422)
        Me.pl1.Name = "pl1"
        Me.pl1.Size = New System.Drawing.Size(636, 45)
        Me.pl1.TabIndex = 34
        '
        'rb_brush
        '
        Me.rb_brush.AutoSize = True
        Me.rb_brush.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.rb_brush.Location = New System.Drawing.Point(535, 8)
        Me.rb_brush.Name = "rb_brush"
        Me.rb_brush.Size = New System.Drawing.Size(70, 31)
        Me.rb_brush.TabIndex = 33
        Me.rb_brush.TabStop = True
        Me.rb_brush.Text = "自订"
        Me.rb_brush.UseVisualStyleBackColor = True
        '
        'op2
        '
        Me.op2.FileName = "OpenFileDialog1"
        Me.op2.Filter = "png文件(.png)|*.png"
        '
        'cub
        '
        Me.cub.Location = New System.Drawing.Point(552, 473)
        Me.cub.Name = "cub"
        Me.cub.Size = New System.Drawing.Size(101, 101)
        Me.cub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cub.TabIndex = 35
        Me.cub.TabStop = False
        '
        'cf1
        '
        Me.cf1.FullOpen = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 584)
        Me.Controls.Add(Me.cub)
        Me.Controls.Add(Me.pl1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.slabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.fpre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选项"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl1.ResumeLayout(False)
        Me.pl1.PerformLayout()
        CType(Me.cub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents fpre As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents fd1 As FontDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents slabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents rb_normal As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rb_blue As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents rb_green As RadioButton
    Friend WithEvents rb_grey As RadioButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents rb_orange As RadioButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pl1 As Panel
    Friend WithEvents op2 As OpenFileDialog
    Friend WithEvents rb_brush As RadioButton
    Friend WithEvents cub As PictureBox
    Friend WithEvents cf1 As ColorDialog
End Class
