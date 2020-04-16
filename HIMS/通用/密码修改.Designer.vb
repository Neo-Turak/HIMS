<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 密码修改
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B_确定 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TB_当前密码 = New System.Windows.Forms.TextBox()
        Me.TB_新密码 = New System.Windows.Forms.TextBox()
        Me.TB_密码重复 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用   户  名:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "当前密码:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "新密码："
        '
        'B_确定
        '
        Me.B_确定.Location = New System.Drawing.Point(121, 257)
        Me.B_确定.Name = "B_确定"
        Me.B_确定.Size = New System.Drawing.Size(112, 35)
        Me.B_确定.TabIndex = 1
        Me.B_确定.Text = "确  定"
        Me.B_确定.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "新密码："
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(170, 61)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TB_当前密码
        '
        Me.TB_当前密码.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_当前密码.Location = New System.Drawing.Point(160, 104)
        Me.TB_当前密码.MaxLength = 10
        Me.TB_当前密码.Name = "TB_当前密码"
        Me.TB_当前密码.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_当前密码.Size = New System.Drawing.Size(97, 26)
        Me.TB_当前密码.TabIndex = 3
        '
        'TB_新密码
        '
        Me.TB_新密码.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_新密码.Location = New System.Drawing.Point(156, 148)
        Me.TB_新密码.MaxLength = 10
        Me.TB_新密码.Name = "TB_新密码"
        Me.TB_新密码.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_新密码.Size = New System.Drawing.Size(97, 26)
        Me.TB_新密码.TabIndex = 3
        '
        'TB_密码重复
        '
        Me.TB_密码重复.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_密码重复.Location = New System.Drawing.Point(156, 191)
        Me.TB_密码重复.MaxLength = 10
        Me.TB_密码重复.Name = "TB_密码重复"
        Me.TB_密码重复.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_密码重复.Size = New System.Drawing.Size(97, 26)
        Me.TB_密码重复.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "注:新密码修改后系统关闭"
        '
        '密码修改
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(395, 371)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_密码重复)
        Me.Controls.Add(Me.TB_新密码)
        Me.Controls.Add(Me.TB_当前密码)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_确定)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "密码修改"
        Me.Text = "密码修改"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents B_确定 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TB_当前密码 As TextBox
    Friend WithEvents TB_新密码 As TextBox
    Friend WithEvents TB_密码重复 As TextBox
    Friend WithEvents Label5 As Label
End Class
