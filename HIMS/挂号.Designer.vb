<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 挂号
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_添加档案 = New System.Windows.Forms.Button()
        Me.Btn_查询 = New System.Windows.Forms.Button()
        Me.TB_查询内容 = New System.Windows.Forms.TextBox()
        Me.CB_查询条件 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_就诊 = New System.Windows.Forms.Button()
        Me.CB_结算方式 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_年龄 = New System.Windows.Forms.Label()
        Me.Lbl_患者姓名 = New System.Windows.Forms.Label()
        Me.Lbl_性别 = New System.Windows.Forms.Label()
        Me.Lbl_合作医疗证号 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SlateGray
        Me.GroupBox1.Controls.Add(Me.Btn_添加档案)
        Me.GroupBox1.Controls.Add(Me.Btn_查询)
        Me.GroupBox1.Controls.Add(Me.TB_查询内容)
        Me.GroupBox1.Controls.Add(Me.CB_查询条件)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "查     询"
        '
        'Btn_添加档案
        '
        Me.Btn_添加档案.Location = New System.Drawing.Point(453, 17)
        Me.Btn_添加档案.Name = "Btn_添加档案"
        Me.Btn_添加档案.Size = New System.Drawing.Size(76, 31)
        Me.Btn_添加档案.TabIndex = 3
        Me.Btn_添加档案.Text = "添加档案"
        Me.Btn_添加档案.UseVisualStyleBackColor = true
        '
        'Btn_查询
        '
        Me.Btn_查询.Location = New System.Drawing.Point(358, 17)
        Me.Btn_查询.Name = "Btn_查询"
        Me.Btn_查询.Size = New System.Drawing.Size(76, 31)
        Me.Btn_查询.TabIndex = 2
        Me.Btn_查询.Text = "查询"
        Me.Btn_查询.UseVisualStyleBackColor = true
        '
        'TB_查询内容
        '
        Me.TB_查询内容.Enabled = false
        Me.TB_查询内容.Location = New System.Drawing.Point(156, 22)
        Me.TB_查询内容.MaxLength = 32
        Me.TB_查询内容.Name = "TB_查询内容"
        Me.TB_查询内容.Size = New System.Drawing.Size(191, 23)
        Me.TB_查询内容.TabIndex = 1
        Me.TB_查询内容.Tag = "查询内容"
        '
        'CB_查询条件
        '
        Me.CB_查询条件.FormattingEnabled = true
        Me.CB_查询条件.Items.AddRange(New Object() {"患者编号", "合作医疗号", "患者姓名", "身份证号"})
        Me.CB_查询条件.Location = New System.Drawing.Point(6, 21)
        Me.CB_查询条件.Name = "CB_查询条件"
        Me.CB_查询条件.Size = New System.Drawing.Size(144, 24)
        Me.CB_查询条件.TabIndex = 0
        Me.CB_查询条件.Text = "查询条件"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Green
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Btn_就诊)
        Me.GroupBox2.Controls.Add(Me.CB_结算方式)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Lbl_年龄)
        Me.GroupBox2.Controls.Add(Me.Lbl_患者姓名)
        Me.GroupBox2.Controls.Add(Me.Lbl_性别)
        Me.GroupBox2.Controls.Add(Me.Lbl_合作医疗证号)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 136)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "基本信息"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(444, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "挂          号"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Btn_就诊
        '
        Me.Btn_就诊.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_就诊.Enabled = false
        Me.Btn_就诊.Location = New System.Drawing.Point(444, 82)
        Me.Btn_就诊.Name = "Btn_就诊"
        Me.Btn_就诊.Size = New System.Drawing.Size(88, 36)
        Me.Btn_就诊.TabIndex = 6
        Me.Btn_就诊.Text = "就     诊"
        Me.Btn_就诊.UseVisualStyleBackColor = false
        '
        'CB_结算方式
        '
        Me.CB_结算方式.FormattingEnabled = true
        Me.CB_结算方式.Items.AddRange(New Object() {"合作医疗", "自费"})
        Me.CB_结算方式.Location = New System.Drawing.Point(99, 94)
        Me.CB_结算方式.Name = "CB_结算方式"
        Me.CB_结算方式.Size = New System.Drawing.Size(133, 24)
        Me.CB_结算方式.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "【结算方式】"
        '
        'Lbl_年龄
        '
        Me.Lbl_年龄.BackColor = System.Drawing.Color.Silver
        Me.Lbl_年龄.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Lbl_年龄.Location = New System.Drawing.Point(358, 65)
        Me.Lbl_年龄.Name = "Lbl_年龄"
        Me.Lbl_年龄.Size = New System.Drawing.Size(71, 17)
        Me.Lbl_年龄.TabIndex = 0
        Me.Lbl_年龄.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_患者姓名
        '
        Me.Lbl_患者姓名.BackColor = System.Drawing.Color.Silver
        Me.Lbl_患者姓名.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Lbl_患者姓名.Location = New System.Drawing.Point(98, 65)
        Me.Lbl_患者姓名.Name = "Lbl_患者姓名"
        Me.Lbl_患者姓名.Size = New System.Drawing.Size(195, 17)
        Me.Lbl_患者姓名.TabIndex = 0
        Me.Lbl_患者姓名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_性别
        '
        Me.Lbl_性别.BackColor = System.Drawing.Color.Silver
        Me.Lbl_性别.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Lbl_性别.Location = New System.Drawing.Point(358, 31)
        Me.Lbl_性别.Name = "Lbl_性别"
        Me.Lbl_性别.Size = New System.Drawing.Size(71, 17)
        Me.Lbl_性别.TabIndex = 0
        Me.Lbl_性别.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_合作医疗证号
        '
        Me.Lbl_合作医疗证号.BackColor = System.Drawing.Color.Silver
        Me.Lbl_合作医疗证号.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Lbl_合作医疗证号.Location = New System.Drawing.Point(126, 31)
        Me.Lbl_合作医疗证号.Name = "Lbl_合作医疗证号"
        Me.Lbl_合作医疗证号.Size = New System.Drawing.Size(167, 17)
        Me.Lbl_合作医疗证号.TabIndex = 0
        Me.Lbl_合作医疗证号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(14, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "【合作医疗证号】"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "【患者姓名】"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(299, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "【年龄】"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(299, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "【性别】"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = false
        Me.DataGridView2.AllowUserToDeleteRows = false
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(19, 354)
        Me.DataGridView2.MultiSelect = false
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = true
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(541, 131)
        Me.DataGridView2.TabIndex = 1
        Me.DataGridView2.TabStop = false
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 81)
        Me.DataGridView1.MultiSelect = false
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.RowHeadersVisible = false
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(536, 115)
        Me.DataGridView1.TabIndex = 4
        '
        '挂号
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(575, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "挂号"
        Me.Text = "挂号"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_添加档案 As Button
    Friend WithEvents Btn_查询 As Button
    Friend WithEvents TB_查询内容 As TextBox
    Friend WithEvents CB_查询条件 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_就诊 As Button
    Friend WithEvents CB_结算方式 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_年龄 As Label
    Friend WithEvents Lbl_患者姓名 As Label
    Friend WithEvents Lbl_性别 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Lbl_合作医疗证号 As Label
    Friend WithEvents Button1 As Button
End Class
