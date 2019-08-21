<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class over
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(over))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sav_na = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "游戏结束！"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(531, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "----------------------------------------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "你的分数："
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.SystemColors.Control
        Me.t1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t1.Font = New System.Drawing.Font("Consolas", 25.0!)
        Me.t1.Location = New System.Drawing.Point(17, 91)
        Me.t1.Multiline = True
        Me.t1.Name = "t1"
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(518, 54)
        Me.t1.TabIndex = 4
        Me.t1.Text = "0"
        Me.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "最大数字："
        '
        't2
        '
        Me.t2.BackColor = System.Drawing.SystemColors.Control
        Me.t2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t2.Font = New System.Drawing.Font("Consolas", 25.0!)
        Me.t2.Location = New System.Drawing.Point(17, 181)
        Me.t2.Multiline = True
        Me.t2.Name = "t2"
        Me.t2.ReadOnly = True
        Me.t2.Size = New System.Drawing.Size(518, 54)
        Me.t2.TabIndex = 6
        Me.t2.Text = "0"
        Me.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "下方输入名称以保存："
        '
        'sav_na
        '
        Me.sav_na.BackColor = System.Drawing.SystemColors.Control
        Me.sav_na.Font = New System.Drawing.Font("微软雅黑", 25.0!, System.Drawing.FontStyle.Bold)
        Me.sav_na.Location = New System.Drawing.Point(17, 271)
        Me.sav_na.Multiline = True
        Me.sav_na.Name = "sav_na"
        Me.sav_na.Size = New System.Drawing.Size(518, 49)
        Me.sav_na.TabIndex = 8
        Me.sav_na.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.Button1.Location = New System.Drawing.Point(17, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 53)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "取消"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.Button2.Location = New System.Drawing.Point(307, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 53)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "确定"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'over
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 391)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sav_na)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(562, 430)
        Me.MinimumSize = New System.Drawing.Size(562, 430)
        Me.Name = "over"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "结算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents t1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents t2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sav_na As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
