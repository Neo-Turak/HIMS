<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_用户名 = New System.Windows.Forms.TextBox()
        Me.TB_密码 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.B_登录 = New System.Windows.Forms.Button()
        Me.B_退出 = New System.Windows.Forms.Button()
        Me.L_职位 = New System.Windows.Forms.Label()
        Me.L_部门 = New System.Windows.Forms.Label()
        Me.L_姓名 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic Semilight", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(108, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "荒 地 镇 卫 生 院"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(131, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "住院医生工作站"
        '
        'TB_用户名
        '
        Me.TB_用户名.Location = New System.Drawing.Point(135, 160)
        Me.TB_用户名.MaxLength = 16
        Me.TB_用户名.Name = "TB_用户名"
        Me.TB_用户名.Size = New System.Drawing.Size(153, 23)
        Me.TB_用户名.TabIndex = 1
        '
        'TB_密码
        '
        Me.TB_密码.Location = New System.Drawing.Point(135, 207)
        Me.TB_密码.MaxLength = 8
        Me.TB_密码.Name = "TB_密码"
        Me.TB_密码.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_密码.Size = New System.Drawing.Size(153, 23)
        Me.TB_密码.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(69, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "密    码:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(72, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "用户名:"
        '
        'B_登录
        '
        Me.B_登录.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.B_登录.Location = New System.Drawing.Point(151, 287)
        Me.B_登录.Name = "B_登录"
        Me.B_登录.Size = New System.Drawing.Size(104, 35)
        Me.B_登录.TabIndex = 3
        Me.B_登录.Text = "登     录"
        Me.B_登录.UseVisualStyleBackColor = True
        '
        'B_退出
        '
        Me.B_退出.BackColor = System.Drawing.Color.Transparent
        Me.B_退出.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_退出.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.B_退出.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.B_退出.Location = New System.Drawing.Point(362, 12)
        Me.B_退出.Name = "B_退出"
        Me.B_退出.Size = New System.Drawing.Size(35, 25)
        Me.B_退出.TabIndex = 4
        Me.B_退出.TabStop = False
        Me.B_退出.Text = "X"
        Me.B_退出.UseVisualStyleBackColor = False
        '
        'L_职位
        '
        Me.L_职位.AutoSize = True
        Me.L_职位.BackColor = System.Drawing.Color.Transparent
        Me.L_职位.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.L_职位.Location = New System.Drawing.Point(86, 325)
        Me.L_职位.Name = "L_职位"
        Me.L_职位.Size = New System.Drawing.Size(0, 17)
        Me.L_职位.TabIndex = 5
        '
        'L_部门
        '
        Me.L_部门.AutoSize = True
        Me.L_部门.BackColor = System.Drawing.Color.Transparent
        Me.L_部门.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.L_部门.Location = New System.Drawing.Point(255, 325)
        Me.L_部门.Name = "L_部门"
        Me.L_部门.Size = New System.Drawing.Size(0, 17)
        Me.L_部门.TabIndex = 5
        '
        'L_姓名
        '
        Me.L_姓名.BackColor = System.Drawing.Color.Transparent
        Me.L_姓名.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.L_姓名.ForeColor = System.Drawing.Color.Coral
        Me.L_姓名.Location = New System.Drawing.Point(73, 245)
        Me.L_姓名.Name = "L_姓名"
        Me.L_姓名.Size = New System.Drawing.Size(252, 24)
        Me.L_姓名.TabIndex = 6
        Me.L_姓名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HIMS.My.Resources.Resources.Login
        Me.ClientSize = New System.Drawing.Size(413, 393)
        Me.Controls.Add(Me.L_姓名)
        Me.Controls.Add(Me.L_部门)
        Me.Controls.Add(Me.L_职位)
        Me.Controls.Add(Me.B_退出)
        Me.Controls.Add(Me.B_登录)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_密码)
        Me.Controls.Add(Me.TB_用户名)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_用户名 As TextBox
    Friend WithEvents TB_密码 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents B_登录 As Button
    Friend WithEvents B_退出 As Button
    Friend WithEvents L_职位 As Label
    Friend WithEvents L_部门 As Label
    Friend WithEvents L_姓名 As Label
End Class
