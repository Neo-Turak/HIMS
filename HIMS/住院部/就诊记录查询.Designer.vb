<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 就诊记录查询
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(就诊记录查询))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTN_打印 = New System.Windows.Forms.Button()
        Me.LBL_就诊医师 = New System.Windows.Forms.Label()
        Me.LBL_就诊时间 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TB_既往史 = New System.Windows.Forms.TextBox()
        Me.TB_现病史 = New System.Windows.Forms.TextBox()
        Me.TB_主诉 = New System.Windows.Forms.TextBox()
        Me.TB_诊断 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LBL_患者信息 = New System.Windows.Forms.Label()
        Me.BTN_查询 = New System.Windows.Forms.Button()
        Me.TB_患者编号 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "患者信息:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BTN_打印)
        Me.GroupBox1.Controls.Add(Me.LBL_就诊医师)
        Me.GroupBox1.Controls.Add(Me.LBL_就诊时间)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TB_既往史)
        Me.GroupBox1.Controls.Add(Me.TB_现病史)
        Me.GroupBox1.Controls.Add(Me.TB_主诉)
        Me.GroupBox1.Controls.Add(Me.TB_诊断)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 601)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "就诊记录:"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(228, 528)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "浏     览"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTN_打印
        '
        Me.BTN_打印.Image = CType(resources.GetObject("BTN_打印.Image"), System.Drawing.Image)
        Me.BTN_打印.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_打印.Location = New System.Drawing.Point(34, 528)
        Me.BTN_打印.Name = "BTN_打印"
        Me.BTN_打印.Size = New System.Drawing.Size(101, 36)
        Me.BTN_打印.TabIndex = 4
        Me.BTN_打印.Text = "打    印"
        Me.BTN_打印.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_打印.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_打印.UseVisualStyleBackColor = True
        '
        'LBL_就诊医师
        '
        Me.LBL_就诊医师.Location = New System.Drawing.Point(607, 548)
        Me.LBL_就诊医师.Name = "LBL_就诊医师"
        Me.LBL_就诊医师.Size = New System.Drawing.Size(154, 18)
        Me.LBL_就诊医师.TabIndex = 3
        '
        'LBL_就诊时间
        '
        Me.LBL_就诊时间.Location = New System.Drawing.Point(607, 503)
        Me.LBL_就诊时间.Name = "LBL_就诊时间"
        Me.LBL_就诊时间.Size = New System.Drawing.Size(154, 27)
        Me.LBL_就诊时间.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(490, 430)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(365, 64)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(490, 360)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(365, 64)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(490, 293)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(365, 61)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(490, 232)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 54)
        Me.TextBox1.TabIndex = 2
        '
        'TB_既往史
        '
        Me.TB_既往史.Location = New System.Drawing.Point(490, 172)
        Me.TB_既往史.Multiline = True
        Me.TB_既往史.Name = "TB_既往史"
        Me.TB_既往史.Size = New System.Drawing.Size(365, 54)
        Me.TB_既往史.TabIndex = 2
        '
        'TB_现病史
        '
        Me.TB_现病史.Location = New System.Drawing.Point(490, 112)
        Me.TB_现病史.Multiline = True
        Me.TB_现病史.Name = "TB_现病史"
        Me.TB_现病史.Size = New System.Drawing.Size(365, 54)
        Me.TB_现病史.TabIndex = 2
        '
        'TB_主诉
        '
        Me.TB_主诉.Location = New System.Drawing.Point(490, 69)
        Me.TB_主诉.Multiline = True
        Me.TB_主诉.Name = "TB_主诉"
        Me.TB_主诉.Size = New System.Drawing.Size(365, 36)
        Me.TB_主诉.TabIndex = 2
        '
        'TB_诊断
        '
        Me.TB_诊断.Location = New System.Drawing.Point(490, 27)
        Me.TB_诊断.Multiline = True
        Me.TB_诊断.Name = "TB_诊断"
        Me.TB_诊断.Size = New System.Drawing.Size(365, 36)
        Me.TB_诊断.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(425, 548)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "就诊医师:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(425, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "就诊时间:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(427, 442)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 49)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "医嘱建议:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(428, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 40)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "诊疗意见:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(425, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 50)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "辅助检查:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(424, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 45)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "体格检查:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "既往史:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "现病史:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "主诉:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "诊断："
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(401, 494)
        Me.DataGridView1.TabIndex = 0
        '
        'LBL_患者信息
        '
        Me.LBL_患者信息.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LBL_患者信息.Location = New System.Drawing.Point(478, 19)
        Me.LBL_患者信息.Name = "LBL_患者信息"
        Me.LBL_患者信息.Size = New System.Drawing.Size(415, 18)
        Me.LBL_患者信息.TabIndex = 2
        '
        'BTN_查询
        '
        Me.BTN_查询.Location = New System.Drawing.Point(274, 13)
        Me.BTN_查询.Name = "BTN_查询"
        Me.BTN_查询.Size = New System.Drawing.Size(91, 30)
        Me.BTN_查询.TabIndex = 3
        Me.BTN_查询.Text = "查   询"
        Me.BTN_查询.UseVisualStyleBackColor = True
        '
        'TB_患者编号
        '
        Me.TB_患者编号.Location = New System.Drawing.Point(105, 17)
        Me.TB_患者编号.MaxLength = 10
        Me.TB_患者编号.Name = "TB_患者编号"
        Me.TB_患者编号.Size = New System.Drawing.Size(152, 24)
        Me.TB_患者编号.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "患者编号:"
        '
        '就诊记录查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(920, 672)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TB_患者编号)
        Me.Controls.Add(Me.BTN_查询)
        Me.Controls.Add(Me.LBL_患者信息)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "就诊记录查询"
        Me.Text = "就诊记录查询"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_就诊医师 As Label
    Friend WithEvents LBL_就诊时间 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TB_既往史 As TextBox
    Friend WithEvents TB_现病史 As TextBox
    Friend WithEvents TB_主诉 As TextBox
    Friend WithEvents TB_诊断 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents BTN_打印 As Button
    Friend WithEvents LBL_患者信息 As Label
    Friend WithEvents BTN_查询 As Button
    Friend WithEvents TB_患者编号 As TextBox
    Friend WithEvents Label12 As Label
End Class
