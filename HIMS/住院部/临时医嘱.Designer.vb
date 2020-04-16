<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 临时医嘱
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GB_病人信息 = New System.Windows.Forms.GroupBox()
        Me.TB_患者编号 = New System.Windows.Forms.TextBox()
        Me.TB_住院日期 = New System.Windows.Forms.TextBox()
        Me.TB_诊断 = New System.Windows.Forms.TextBox()
        Me.TB_住院号 = New System.Windows.Forms.TextBox()
        Me.TB_床号 = New System.Windows.Forms.TextBox()
        Me.TB_年龄 = New System.Windows.Forms.TextBox()
        Me.TB_性别 = New System.Windows.Forms.TextBox()
        Me.L_患者编号 = New System.Windows.Forms.Label()
        Me.L_住院日期 = New System.Windows.Forms.Label()
        Me.L_诊断 = New System.Windows.Forms.Label()
        Me.L_住院号 = New System.Windows.Forms.Label()
        Me.L_床号 = New System.Windows.Forms.Label()
        Me.L_年龄 = New System.Windows.Forms.Label()
        Me.L_性别 = New System.Windows.Forms.Label()
        Me.TB_姓名 = New System.Windows.Forms.TextBox()
        Me.L_姓名 = New System.Windows.Forms.Label()
        Me.GB_遗嘱筛选 = New System.Windows.Forms.GroupBox()
        Me.RB_全部遗嘱 = New System.Windows.Forms.RadioButton()
        Me.RB_本次遗嘱 = New System.Windows.Forms.RadioButton()
        Me.GB_遗嘱状态 = New System.Windows.Forms.GroupBox()
        Me.RB_未执行 = New System.Windows.Forms.RadioButton()
        Me.RB_已执行 = New System.Windows.Forms.RadioButton()
        Me.GB_遗嘱专区 = New System.Windows.Forms.GroupBox()
        Me.DGV_药品库 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.用法 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_快速打印 = New System.Windows.Forms.Button()
        Me.B_打印 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.NUD_到_子项 = New System.Windows.Forms.NumericUpDown()
        Me.NUD_从_子项 = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TB_从_子项 = New System.Windows.Forms.TextBox()
        Me.TB_到_子项 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CB_续页打印 = New System.Windows.Forms.CheckBox()
        Me.CB_新页打印 = New System.Windows.Forms.CheckBox()
        Me.DGV_存单 = New System.Windows.Forms.DataGridView()
        Me.DGV_项目库 = New System.Windows.Forms.DataGridView()
        Me.项目名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.单位 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.所属科室 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.价格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.备注 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_加空行 = New System.Windows.Forms.Button()
        Me.B_保存 = New System.Windows.Forms.Button()
        Me.B_审核 = New System.Windows.Forms.Button()
        Me.B_删除 = New System.Windows.Forms.Button()
        Me.B_添加 = New System.Windows.Forms.Button()
        Me.CB_用法 = New System.Windows.Forms.ComboBox()
        Me.CB_标志 = New System.Windows.Forms.ComboBox()
        Me.GB_药品信息 = New System.Windows.Forms.GroupBox()
        Me.L_金额 = New System.Windows.Forms.Label()
        Me.L_单价 = New System.Windows.Forms.Label()
        Me.L_库存 = New System.Windows.Forms.Label()
        Me.L_金额S = New System.Windows.Forms.Label()
        Me.L_单价S = New System.Windows.Forms.Label()
        Me.L_库存S = New System.Windows.Forms.Label()
        Me.TB_规格 = New System.Windows.Forms.TextBox()
        Me.TB_药品名称 = New System.Windows.Forms.TextBox()
        Me.TB_数量 = New System.Windows.Forms.TextBox()
        Me.TB_助记码 = New System.Windows.Forms.TextBox()
        Me.L_规格 = New System.Windows.Forms.Label()
        Me.L_药品名称 = New System.Windows.Forms.Label()
        Me.L_数量 = New System.Windows.Forms.Label()
        Me.L_助记码 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_检查科室 = New System.Windows.Forms.ComboBox()
        Me.CB_分类 = New System.Windows.Forms.ComboBox()
        Me.B_重置 = New System.Windows.Forms.Button()
        Me.B_查询 = New System.Windows.Forms.Button()
        Me.PD_打印 = New System.Drawing.Printing.PrintDocument()
        Me.PD_快速打印 = New System.Drawing.Printing.PrintDocument()
        Me.GB_病人信息.SuspendLayout()
        Me.GB_遗嘱筛选.SuspendLayout()
        Me.GB_遗嘱状态.SuspendLayout()
        Me.GB_遗嘱专区.SuspendLayout()
        CType(Me.DGV_药品库, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.NUD_到_子项, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_从_子项, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGV_存单, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_项目库, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_药品信息.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_病人信息
        '
        Me.GB_病人信息.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GB_病人信息.Controls.Add(Me.TB_患者编号)
        Me.GB_病人信息.Controls.Add(Me.TB_住院日期)
        Me.GB_病人信息.Controls.Add(Me.TB_诊断)
        Me.GB_病人信息.Controls.Add(Me.TB_住院号)
        Me.GB_病人信息.Controls.Add(Me.TB_床号)
        Me.GB_病人信息.Controls.Add(Me.TB_年龄)
        Me.GB_病人信息.Controls.Add(Me.TB_性别)
        Me.GB_病人信息.Controls.Add(Me.L_患者编号)
        Me.GB_病人信息.Controls.Add(Me.L_住院日期)
        Me.GB_病人信息.Controls.Add(Me.L_诊断)
        Me.GB_病人信息.Controls.Add(Me.L_住院号)
        Me.GB_病人信息.Controls.Add(Me.L_床号)
        Me.GB_病人信息.Controls.Add(Me.L_年龄)
        Me.GB_病人信息.Controls.Add(Me.L_性别)
        Me.GB_病人信息.Controls.Add(Me.TB_姓名)
        Me.GB_病人信息.Controls.Add(Me.L_姓名)
        Me.GB_病人信息.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GB_病人信息.Location = New System.Drawing.Point(22, 23)
        Me.GB_病人信息.Name = "GB_病人信息"
        Me.GB_病人信息.Size = New System.Drawing.Size(277, 307)
        Me.GB_病人信息.TabIndex = 0
        Me.GB_病人信息.TabStop = False
        Me.GB_病人信息.Text = "病人信息"
        '
        'TB_患者编号
        '
        Me.TB_患者编号.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_患者编号.Location = New System.Drawing.Point(95, 268)
        Me.TB_患者编号.MaxLength = 32
        Me.TB_患者编号.Name = "TB_患者编号"
        Me.TB_患者编号.Size = New System.Drawing.Size(170, 24)
        Me.TB_患者编号.TabIndex = 3
        '
        'TB_住院日期
        '
        Me.TB_住院日期.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_住院日期.Location = New System.Drawing.Point(95, 230)
        Me.TB_住院日期.MaxLength = 32
        Me.TB_住院日期.Name = "TB_住院日期"
        Me.TB_住院日期.Size = New System.Drawing.Size(170, 24)
        Me.TB_住院日期.TabIndex = 3
        '
        'TB_诊断
        '
        Me.TB_诊断.Location = New System.Drawing.Point(71, 196)
        Me.TB_诊断.Name = "TB_诊断"
        Me.TB_诊断.Size = New System.Drawing.Size(194, 24)
        Me.TB_诊断.TabIndex = 3
        '
        'TB_住院号
        '
        Me.TB_住院号.Location = New System.Drawing.Point(83, 161)
        Me.TB_住院号.Name = "TB_住院号"
        Me.TB_住院号.Size = New System.Drawing.Size(88, 24)
        Me.TB_住院号.TabIndex = 3
        '
        'TB_床号
        '
        Me.TB_床号.Location = New System.Drawing.Point(71, 126)
        Me.TB_床号.Name = "TB_床号"
        Me.TB_床号.Size = New System.Drawing.Size(33, 24)
        Me.TB_床号.TabIndex = 3
        '
        'TB_年龄
        '
        Me.TB_年龄.Location = New System.Drawing.Point(71, 91)
        Me.TB_年龄.Name = "TB_年龄"
        Me.TB_年龄.Size = New System.Drawing.Size(33, 24)
        Me.TB_年龄.TabIndex = 3
        '
        'TB_性别
        '
        Me.TB_性别.Location = New System.Drawing.Point(71, 58)
        Me.TB_性别.Name = "TB_性别"
        Me.TB_性别.Size = New System.Drawing.Size(33, 24)
        Me.TB_性别.TabIndex = 3
        '
        'L_患者编号
        '
        Me.L_患者编号.AutoSize = True
        Me.L_患者编号.Location = New System.Drawing.Point(18, 271)
        Me.L_患者编号.Name = "L_患者编号"
        Me.L_患者编号.Size = New System.Drawing.Size(83, 18)
        Me.L_患者编号.TabIndex = 2
        Me.L_患者编号.Text = "患者编号："
        '
        'L_住院日期
        '
        Me.L_住院日期.AutoSize = True
        Me.L_住院日期.Location = New System.Drawing.Point(18, 233)
        Me.L_住院日期.Name = "L_住院日期"
        Me.L_住院日期.Size = New System.Drawing.Size(83, 18)
        Me.L_住院日期.TabIndex = 2
        Me.L_住院日期.Text = "住院日期："
        '
        'L_诊断
        '
        Me.L_诊断.AutoSize = True
        Me.L_诊断.Location = New System.Drawing.Point(18, 199)
        Me.L_诊断.Name = "L_诊断"
        Me.L_诊断.Size = New System.Drawing.Size(53, 18)
        Me.L_诊断.TabIndex = 2
        Me.L_诊断.Text = "诊断："
        '
        'L_住院号
        '
        Me.L_住院号.AutoSize = True
        Me.L_住院号.Location = New System.Drawing.Point(18, 164)
        Me.L_住院号.Name = "L_住院号"
        Me.L_住院号.Size = New System.Drawing.Size(68, 18)
        Me.L_住院号.TabIndex = 2
        Me.L_住院号.Text = "住院号："
        '
        'L_床号
        '
        Me.L_床号.AutoSize = True
        Me.L_床号.Location = New System.Drawing.Point(18, 132)
        Me.L_床号.Name = "L_床号"
        Me.L_床号.Size = New System.Drawing.Size(53, 18)
        Me.L_床号.TabIndex = 2
        Me.L_床号.Text = "床号："
        '
        'L_年龄
        '
        Me.L_年龄.AutoSize = True
        Me.L_年龄.Location = New System.Drawing.Point(18, 97)
        Me.L_年龄.Name = "L_年龄"
        Me.L_年龄.Size = New System.Drawing.Size(53, 18)
        Me.L_年龄.TabIndex = 2
        Me.L_年龄.Text = "年龄："
        '
        'L_性别
        '
        Me.L_性别.AutoSize = True
        Me.L_性别.Location = New System.Drawing.Point(18, 61)
        Me.L_性别.Name = "L_性别"
        Me.L_性别.Size = New System.Drawing.Size(53, 18)
        Me.L_性别.TabIndex = 2
        Me.L_性别.Text = "性别："
        '
        'TB_姓名
        '
        Me.TB_姓名.Location = New System.Drawing.Point(71, 24)
        Me.TB_姓名.MaxLength = 32
        Me.TB_姓名.Name = "TB_姓名"
        Me.TB_姓名.Size = New System.Drawing.Size(194, 24)
        Me.TB_姓名.TabIndex = 1
        '
        'L_姓名
        '
        Me.L_姓名.AutoSize = True
        Me.L_姓名.Location = New System.Drawing.Point(18, 28)
        Me.L_姓名.Name = "L_姓名"
        Me.L_姓名.Size = New System.Drawing.Size(53, 18)
        Me.L_姓名.TabIndex = 0
        Me.L_姓名.Text = "姓名："
        '
        'GB_遗嘱筛选
        '
        Me.GB_遗嘱筛选.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GB_遗嘱筛选.Controls.Add(Me.RB_全部遗嘱)
        Me.GB_遗嘱筛选.Controls.Add(Me.RB_本次遗嘱)
        Me.GB_遗嘱筛选.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GB_遗嘱筛选.Location = New System.Drawing.Point(24, 344)
        Me.GB_遗嘱筛选.Name = "GB_遗嘱筛选"
        Me.GB_遗嘱筛选.Size = New System.Drawing.Size(274, 92)
        Me.GB_遗嘱筛选.TabIndex = 1
        Me.GB_遗嘱筛选.TabStop = False
        Me.GB_遗嘱筛选.Text = "遗嘱筛选"
        '
        'RB_全部遗嘱
        '
        Me.RB_全部遗嘱.AutoSize = True
        Me.RB_全部遗嘱.Location = New System.Drawing.Point(147, 40)
        Me.RB_全部遗嘱.Name = "RB_全部遗嘱"
        Me.RB_全部遗嘱.Size = New System.Drawing.Size(86, 22)
        Me.RB_全部遗嘱.TabIndex = 0
        Me.RB_全部遗嘱.TabStop = True
        Me.RB_全部遗嘱.Text = "全部遗嘱"
        Me.RB_全部遗嘱.UseVisualStyleBackColor = True
        '
        'RB_本次遗嘱
        '
        Me.RB_本次遗嘱.AutoSize = True
        Me.RB_本次遗嘱.Location = New System.Drawing.Point(25, 40)
        Me.RB_本次遗嘱.Name = "RB_本次遗嘱"
        Me.RB_本次遗嘱.Size = New System.Drawing.Size(86, 22)
        Me.RB_本次遗嘱.TabIndex = 0
        Me.RB_本次遗嘱.TabStop = True
        Me.RB_本次遗嘱.Text = "本次遗嘱"
        Me.RB_本次遗嘱.UseVisualStyleBackColor = True
        '
        'GB_遗嘱状态
        '
        Me.GB_遗嘱状态.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GB_遗嘱状态.Controls.Add(Me.RB_未执行)
        Me.GB_遗嘱状态.Controls.Add(Me.RB_已执行)
        Me.GB_遗嘱状态.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GB_遗嘱状态.Location = New System.Drawing.Point(25, 455)
        Me.GB_遗嘱状态.Name = "GB_遗嘱状态"
        Me.GB_遗嘱状态.Size = New System.Drawing.Size(274, 92)
        Me.GB_遗嘱状态.TabIndex = 2
        Me.GB_遗嘱状态.TabStop = False
        Me.GB_遗嘱状态.Text = "遗嘱状态"
        '
        'RB_未执行
        '
        Me.RB_未执行.AutoSize = True
        Me.RB_未执行.Location = New System.Drawing.Point(146, 36)
        Me.RB_未执行.Name = "RB_未执行"
        Me.RB_未执行.Size = New System.Drawing.Size(71, 22)
        Me.RB_未执行.TabIndex = 0
        Me.RB_未执行.TabStop = True
        Me.RB_未执行.Text = "未执行"
        Me.RB_未执行.UseVisualStyleBackColor = True
        '
        'RB_已执行
        '
        Me.RB_已执行.AutoSize = True
        Me.RB_已执行.Location = New System.Drawing.Point(21, 36)
        Me.RB_已执行.Name = "RB_已执行"
        Me.RB_已执行.Size = New System.Drawing.Size(71, 22)
        Me.RB_已执行.TabIndex = 0
        Me.RB_已执行.TabStop = True
        Me.RB_已执行.Text = "已执行"
        Me.RB_已执行.UseVisualStyleBackColor = True
        '
        'GB_遗嘱专区
        '
        Me.GB_遗嘱专区.BackColor = System.Drawing.Color.SlateGray
        Me.GB_遗嘱专区.Controls.Add(Me.DGV_药品库)
        Me.GB_遗嘱专区.Controls.Add(Me.B_快速打印)
        Me.GB_遗嘱专区.Controls.Add(Me.B_打印)
        Me.GB_遗嘱专区.Controls.Add(Me.GroupBox7)
        Me.GB_遗嘱专区.Controls.Add(Me.GroupBox6)
        Me.GB_遗嘱专区.Controls.Add(Me.DGV_存单)
        Me.GB_遗嘱专区.Controls.Add(Me.DGV_项目库)
        Me.GB_遗嘱专区.Controls.Add(Me.B_加空行)
        Me.GB_遗嘱专区.Controls.Add(Me.B_保存)
        Me.GB_遗嘱专区.Controls.Add(Me.B_审核)
        Me.GB_遗嘱专区.Controls.Add(Me.B_删除)
        Me.GB_遗嘱专区.Controls.Add(Me.B_添加)
        Me.GB_遗嘱专区.Controls.Add(Me.CB_用法)
        Me.GB_遗嘱专区.Controls.Add(Me.CB_标志)
        Me.GB_遗嘱专区.Controls.Add(Me.GB_药品信息)
        Me.GB_遗嘱专区.Controls.Add(Me.TB_规格)
        Me.GB_遗嘱专区.Controls.Add(Me.TB_药品名称)
        Me.GB_遗嘱专区.Controls.Add(Me.TB_数量)
        Me.GB_遗嘱专区.Controls.Add(Me.TB_助记码)
        Me.GB_遗嘱专区.Controls.Add(Me.L_规格)
        Me.GB_遗嘱专区.Controls.Add(Me.L_药品名称)
        Me.GB_遗嘱专区.Controls.Add(Me.L_数量)
        Me.GB_遗嘱专区.Controls.Add(Me.L_助记码)
        Me.GB_遗嘱专区.Controls.Add(Me.Button1)
        Me.GB_遗嘱专区.Controls.Add(Me.CB_检查科室)
        Me.GB_遗嘱专区.Controls.Add(Me.CB_分类)
        Me.GB_遗嘱专区.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GB_遗嘱专区.Location = New System.Drawing.Point(314, 24)
        Me.GB_遗嘱专区.Name = "GB_遗嘱专区"
        Me.GB_遗嘱专区.Size = New System.Drawing.Size(742, 629)
        Me.GB_遗嘱专区.TabIndex = 3
        Me.GB_遗嘱专区.TabStop = False
        Me.GB_遗嘱专区.Text = "遗嘱专区"
        '
        'DGV_药品库
        '
        Me.DGV_药品库.AllowUserToDeleteRows = False
        Me.DGV_药品库.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_药品库.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_药品库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_药品库.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.用法})
        Me.DGV_药品库.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_药品库.Location = New System.Drawing.Point(20, 297)
        Me.DGV_药品库.Name = "DGV_药品库"
        Me.DGV_药品库.ReadOnly = True
        Me.DGV_药品库.Size = New System.Drawing.Size(587, 88)
        Me.DGV_药品库.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DividerWidth = 2
        Me.DataGridViewTextBoxColumn1.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "药品名"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "规格"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 63
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "单位"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 63
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "库存"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 63
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "单价"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 63
        '
        '用法
        '
        Me.用法.HeaderText = "用法"
        Me.用法.Name = "用法"
        Me.用法.ReadOnly = True
        Me.用法.Width = 63
        '
        'B_快速打印
        '
        Me.B_快速打印.BackColor = System.Drawing.Color.Green
        Me.B_快速打印.Location = New System.Drawing.Point(617, 549)
        Me.B_快速打印.Name = "B_快速打印"
        Me.B_快速打印.Size = New System.Drawing.Size(111, 45)
        Me.B_快速打印.TabIndex = 12
        Me.B_快速打印.Text = "快 速  打 印"
        Me.B_快速打印.UseVisualStyleBackColor = False
        '
        'B_打印
        '
        Me.B_打印.BackColor = System.Drawing.Color.Cyan
        Me.B_打印.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_打印.Location = New System.Drawing.Point(488, 548)
        Me.B_打印.Name = "B_打印"
        Me.B_打印.Size = New System.Drawing.Size(108, 45)
        Me.B_打印.TabIndex = 12
        Me.B_打印.Text = "打     印"
        Me.B_打印.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_打印.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.NUD_到_子项)
        Me.GroupBox7.Controls.Add(Me.NUD_从_子项)
        Me.GroupBox7.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Location = New System.Drawing.Point(251, 537)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(213, 57)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "子项选项"
        '
        'NUD_到_子项
        '
        Me.NUD_到_子项.Location = New System.Drawing.Point(98, 22)
        Me.NUD_到_子项.Name = "NUD_到_子项"
        Me.NUD_到_子项.Size = New System.Drawing.Size(33, 24)
        Me.NUD_到_子项.TabIndex = 4
        Me.NUD_到_子项.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'NUD_从_子项
        '
        Me.NUD_从_子项.Location = New System.Drawing.Point(36, 22)
        Me.NUD_从_子项.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_从_子项.Name = "NUD_从_子项"
        Me.NUD_从_子项.Size = New System.Drawing.Size(38, 24)
        Me.NUD_从_子项.TabIndex = 3
        Me.NUD_从_子项.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_从_子项)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_到_子项)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(136, 19)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(69, 30)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'TB_从_子项
        '
        Me.TB_从_子项.Location = New System.Drawing.Point(3, 3)
        Me.TB_从_子项.MaxLength = 1
        Me.TB_从_子项.Name = "TB_从_子项"
        Me.TB_从_子项.Size = New System.Drawing.Size(28, 24)
        Me.TB_从_子项.TabIndex = 0
        '
        'TB_到_子项
        '
        Me.TB_到_子项.Location = New System.Drawing.Point(37, 3)
        Me.TB_到_子项.MaxLength = 1
        Me.TB_到_子项.Name = "TB_到_子项"
        Me.TB_到_子项.Size = New System.Drawing.Size(28, 24)
        Me.TB_到_子项.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "从           到"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CB_续页打印)
        Me.GroupBox6.Controls.Add(Me.CB_新页打印)
        Me.GroupBox6.Location = New System.Drawing.Point(21, 538)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 58)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "打印选项"
        '
        'CB_续页打印
        '
        Me.CB_续页打印.AutoSize = True
        Me.CB_续页打印.Location = New System.Drawing.Point(137, 26)
        Me.CB_续页打印.Name = "CB_续页打印"
        Me.CB_续页打印.Size = New System.Drawing.Size(87, 22)
        Me.CB_续页打印.TabIndex = 0
        Me.CB_续页打印.Text = "续页打印"
        Me.CB_续页打印.UseVisualStyleBackColor = True
        '
        'CB_新页打印
        '
        Me.CB_新页打印.AutoSize = True
        Me.CB_新页打印.Location = New System.Drawing.Point(17, 26)
        Me.CB_新页打印.Name = "CB_新页打印"
        Me.CB_新页打印.Size = New System.Drawing.Size(87, 22)
        Me.CB_新页打印.TabIndex = 0
        Me.CB_新页打印.Text = "新页打印"
        Me.CB_新页打印.UseVisualStyleBackColor = True
        '
        'DGV_存单
        '
        Me.DGV_存单.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_存单.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_存单.Location = New System.Drawing.Point(16, 391)
        Me.DGV_存单.Name = "DGV_存单"
        Me.DGV_存单.Size = New System.Drawing.Size(723, 132)
        Me.DGV_存单.TabIndex = 10
        '
        'DGV_项目库
        '
        Me.DGV_项目库.AllowUserToDeleteRows = False
        Me.DGV_项目库.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_项目库.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_项目库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_项目库.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.项目名称, Me.单位, Me.所属科室, Me.价格, Me.备注})
        Me.DGV_项目库.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_项目库.Location = New System.Drawing.Point(20, 187)
        Me.DGV_项目库.Name = "DGV_项目库"
        Me.DGV_项目库.ReadOnly = True
        Me.DGV_项目库.Size = New System.Drawing.Size(587, 104)
        Me.DGV_项目库.TabIndex = 9
        '
        '项目名称
        '
        Me.项目名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.项目名称.DividerWidth = 1
        Me.项目名称.Frozen = True
        Me.项目名称.HeaderText = "项目名称"
        Me.项目名称.MaxInputLength = 32
        Me.项目名称.Name = "项目名称"
        Me.项目名称.ReadOnly = True
        Me.项目名称.Width = 94
        '
        '单位
        '
        Me.单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.单位.HeaderText = "单位"
        Me.单位.MaxInputLength = 32
        Me.单位.Name = "单位"
        Me.单位.ReadOnly = True
        Me.单位.Width = 63
        '
        '所属科室
        '
        Me.所属科室.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.所属科室.HeaderText = "所属科室"
        Me.所属科室.MaxInputLength = 32
        Me.所属科室.Name = "所属科室"
        Me.所属科室.ReadOnly = True
        Me.所属科室.Width = 93
        '
        '价格
        '
        Me.价格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.价格.HeaderText = "价格"
        Me.价格.Name = "价格"
        Me.价格.ReadOnly = True
        Me.价格.Width = 63
        '
        '备注
        '
        Me.备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.备注.HeaderText = "备注"
        Me.备注.Name = "备注"
        Me.备注.ReadOnly = True
        Me.备注.Width = 63
        '
        'B_加空行
        '
        Me.B_加空行.Location = New System.Drawing.Point(517, 113)
        Me.B_加空行.Name = "B_加空行"
        Me.B_加空行.Size = New System.Drawing.Size(69, 50)
        Me.B_加空行.TabIndex = 8
        Me.B_加空行.Text = "加空行"
        Me.B_加空行.UseVisualStyleBackColor = True
        '
        'B_保存
        '
        Me.B_保存.Location = New System.Drawing.Point(389, 136)
        Me.B_保存.Name = "B_保存"
        Me.B_保存.Size = New System.Drawing.Size(118, 27)
        Me.B_保存.TabIndex = 7
        Me.B_保存.Text = "保  存"
        Me.B_保存.UseVisualStyleBackColor = True
        '
        'B_审核
        '
        Me.B_审核.Location = New System.Drawing.Point(265, 136)
        Me.B_审核.Name = "B_审核"
        Me.B_审核.Size = New System.Drawing.Size(118, 27)
        Me.B_审核.TabIndex = 7
        Me.B_审核.Text = "审  核"
        Me.B_审核.UseVisualStyleBackColor = True
        '
        'B_删除
        '
        Me.B_删除.Location = New System.Drawing.Point(141, 137)
        Me.B_删除.Name = "B_删除"
        Me.B_删除.Size = New System.Drawing.Size(118, 27)
        Me.B_删除.TabIndex = 7
        Me.B_删除.Text = "删  除"
        Me.B_删除.UseVisualStyleBackColor = True
        '
        'B_添加
        '
        Me.B_添加.Location = New System.Drawing.Point(17, 136)
        Me.B_添加.Name = "B_添加"
        Me.B_添加.Size = New System.Drawing.Size(118, 27)
        Me.B_添加.TabIndex = 7
        Me.B_添加.Text = "添  加"
        Me.B_添加.UseVisualStyleBackColor = True
        '
        'CB_用法
        '
        Me.CB_用法.FormattingEnabled = True
        Me.CB_用法.Items.AddRange(New Object() {"口服", "局部用药", "静脉点滴", "注射"})
        Me.CB_用法.Location = New System.Drawing.Point(293, 97)
        Me.CB_用法.Name = "CB_用法"
        Me.CB_用法.Size = New System.Drawing.Size(121, 26)
        Me.CB_用法.TabIndex = 6
        Me.CB_用法.Text = "用   法"
        '
        'CB_标志
        '
        Me.CB_标志.FormattingEnabled = True
        Me.CB_标志.Items.AddRange(New Object() {"┌", "|", "└ "})
        Me.CB_标志.Location = New System.Drawing.Point(166, 97)
        Me.CB_标志.Name = "CB_标志"
        Me.CB_标志.Size = New System.Drawing.Size(121, 26)
        Me.CB_标志.TabIndex = 5
        Me.CB_标志.Text = "标志"
        '
        'GB_药品信息
        '
        Me.GB_药品信息.Controls.Add(Me.L_金额)
        Me.GB_药品信息.Controls.Add(Me.L_单价)
        Me.GB_药品信息.Controls.Add(Me.L_库存)
        Me.GB_药品信息.Controls.Add(Me.L_金额S)
        Me.GB_药品信息.Controls.Add(Me.L_单价S)
        Me.GB_药品信息.Controls.Add(Me.L_库存S)
        Me.GB_药品信息.Location = New System.Drawing.Point(603, 60)
        Me.GB_药品信息.Name = "GB_药品信息"
        Me.GB_药品信息.Size = New System.Drawing.Size(125, 121)
        Me.GB_药品信息.TabIndex = 4
        Me.GB_药品信息.TabStop = False
        Me.GB_药品信息.Text = "药品信息"
        '
        'L_金额
        '
        Me.L_金额.AutoSize = True
        Me.L_金额.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.L_金额.Location = New System.Drawing.Point(60, 86)
        Me.L_金额.Name = "L_金额"
        Me.L_金额.Size = New System.Drawing.Size(0, 18)
        Me.L_金额.TabIndex = 1
        '
        'L_单价
        '
        Me.L_单价.AutoSize = True
        Me.L_单价.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.L_单价.Location = New System.Drawing.Point(61, 53)
        Me.L_单价.Name = "L_单价"
        Me.L_单价.Size = New System.Drawing.Size(0, 18)
        Me.L_单价.TabIndex = 1
        '
        'L_库存
        '
        Me.L_库存.AutoSize = True
        Me.L_库存.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.L_库存.Location = New System.Drawing.Point(61, 25)
        Me.L_库存.Name = "L_库存"
        Me.L_库存.Size = New System.Drawing.Size(0, 18)
        Me.L_库存.TabIndex = 1
        '
        'L_金额S
        '
        Me.L_金额S.AutoSize = True
        Me.L_金额S.Location = New System.Drawing.Point(11, 86)
        Me.L_金额S.Name = "L_金额S"
        Me.L_金额S.Size = New System.Drawing.Size(53, 18)
        Me.L_金额S.TabIndex = 0
        Me.L_金额S.Text = "金额："
        '
        'L_单价S
        '
        Me.L_单价S.AutoSize = True
        Me.L_单价S.Location = New System.Drawing.Point(11, 53)
        Me.L_单价S.Name = "L_单价S"
        Me.L_单价S.Size = New System.Drawing.Size(53, 18)
        Me.L_单价S.TabIndex = 0
        Me.L_单价S.Text = "单价："
        '
        'L_库存S
        '
        Me.L_库存S.AutoSize = True
        Me.L_库存S.Location = New System.Drawing.Point(11, 24)
        Me.L_库存S.Name = "L_库存S"
        Me.L_库存S.Size = New System.Drawing.Size(53, 18)
        Me.L_库存S.TabIndex = 0
        Me.L_库存S.Text = "库存："
        '
        'TB_规格
        '
        Me.TB_规格.Location = New System.Drawing.Point(450, 61)
        Me.TB_规格.Name = "TB_规格"
        Me.TB_规格.Size = New System.Drawing.Size(137, 24)
        Me.TB_规格.TabIndex = 3
        '
        'TB_药品名称
        '
        Me.TB_药品名称.Location = New System.Drawing.Point(238, 62)
        Me.TB_药品名称.Name = "TB_药品名称"
        Me.TB_药品名称.Size = New System.Drawing.Size(145, 24)
        Me.TB_药品名称.TabIndex = 3
        '
        'TB_数量
        '
        Me.TB_数量.Location = New System.Drawing.Point(74, 98)
        Me.TB_数量.Name = "TB_数量"
        Me.TB_数量.Size = New System.Drawing.Size(83, 24)
        Me.TB_数量.TabIndex = 3
        '
        'TB_助记码
        '
        Me.TB_助记码.Location = New System.Drawing.Point(74, 62)
        Me.TB_助记码.Name = "TB_助记码"
        Me.TB_助记码.Size = New System.Drawing.Size(83, 24)
        Me.TB_助记码.TabIndex = 3
        '
        'L_规格
        '
        Me.L_规格.AutoSize = True
        Me.L_规格.Location = New System.Drawing.Point(403, 65)
        Me.L_规格.Name = "L_规格"
        Me.L_规格.Size = New System.Drawing.Size(53, 18)
        Me.L_规格.TabIndex = 2
        Me.L_规格.Text = "规格："
        '
        'L_药品名称
        '
        Me.L_药品名称.AutoSize = True
        Me.L_药品名称.Location = New System.Drawing.Point(163, 65)
        Me.L_药品名称.Name = "L_药品名称"
        Me.L_药品名称.Size = New System.Drawing.Size(83, 18)
        Me.L_药品名称.TabIndex = 2
        Me.L_药品名称.Text = "药品名称："
        '
        'L_数量
        '
        Me.L_数量.AutoSize = True
        Me.L_数量.Location = New System.Drawing.Point(15, 101)
        Me.L_数量.Name = "L_数量"
        Me.L_数量.Size = New System.Drawing.Size(53, 18)
        Me.L_数量.TabIndex = 2
        Me.L_数量.Text = "数量："
        '
        'L_助记码
        '
        Me.L_助记码.AutoSize = True
        Me.L_助记码.Location = New System.Drawing.Point(15, 65)
        Me.L_助记码.Name = "L_助记码"
        Me.L_助记码.Size = New System.Drawing.Size(57, 18)
        Me.L_助记码.TabIndex = 2
        Me.L_助记码.Text = "助记码:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "导入模板"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_检查科室
        '
        Me.CB_检查科室.FormattingEnabled = True
        Me.CB_检查科室.Items.AddRange(New Object() {"药品", "检查项目"})
        Me.CB_检查科室.Location = New System.Drawing.Point(117, 27)
        Me.CB_检查科室.Name = "CB_检查科室"
        Me.CB_检查科室.Size = New System.Drawing.Size(134, 26)
        Me.CB_检查科室.TabIndex = 0
        Me.CB_检查科室.Text = "检查科室"
        '
        'CB_分类
        '
        Me.CB_分类.FormattingEnabled = True
        Me.CB_分类.Items.AddRange(New Object() {"药品", "检查项目"})
        Me.CB_分类.Location = New System.Drawing.Point(16, 27)
        Me.CB_分类.Name = "CB_分类"
        Me.CB_分类.Size = New System.Drawing.Size(95, 26)
        Me.CB_分类.TabIndex = 0
        Me.CB_分类.Text = "分类"
        '
        'B_重置
        '
        Me.B_重置.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_重置.Location = New System.Drawing.Point(171, 562)
        Me.B_重置.Name = "B_重置"
        Me.B_重置.Size = New System.Drawing.Size(107, 40)
        Me.B_重置.TabIndex = 4
        Me.B_重置.Text = "重  置"
        Me.B_重置.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_重置.UseVisualStyleBackColor = True
        '
        'B_查询
        '
        Me.B_查询.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.B_查询.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_查询.Location = New System.Drawing.Point(27, 562)
        Me.B_查询.Name = "B_查询"
        Me.B_查询.Size = New System.Drawing.Size(107, 40)
        Me.B_查询.TabIndex = 4
        Me.B_查询.Text = "查    询"
        Me.B_查询.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_查询.UseVisualStyleBackColor = False
        '
        'PD_打印
        '
        '
        '临时医嘱
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 665)
        Me.Controls.Add(Me.B_重置)
        Me.Controls.Add(Me.B_查询)
        Me.Controls.Add(Me.GB_遗嘱专区)
        Me.Controls.Add(Me.GB_遗嘱状态)
        Me.Controls.Add(Me.GB_遗嘱筛选)
        Me.Controls.Add(Me.GB_病人信息)
        Me.Name = "临时医嘱"
        Me.Text = "临时医嘱"
        Me.GB_病人信息.ResumeLayout(False)
        Me.GB_病人信息.PerformLayout()
        Me.GB_遗嘱筛选.ResumeLayout(False)
        Me.GB_遗嘱筛选.PerformLayout()
        Me.GB_遗嘱状态.ResumeLayout(False)
        Me.GB_遗嘱状态.PerformLayout()
        Me.GB_遗嘱专区.ResumeLayout(False)
        Me.GB_遗嘱专区.PerformLayout()
        CType(Me.DGV_药品库, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.NUD_到_子项, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_从_子项, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DGV_存单, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_项目库, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_药品信息.ResumeLayout(False)
        Me.GB_药品信息.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_病人信息 As GroupBox
    Friend WithEvents TB_姓名 As TextBox
    Friend WithEvents L_姓名 As Label
    Friend WithEvents TB_年龄 As TextBox
    Friend WithEvents TB_性别 As TextBox
    Friend WithEvents L_年龄 As Label
    Friend WithEvents L_性别 As Label
    Friend WithEvents TB_患者编号 As TextBox
    Friend WithEvents TB_住院日期 As TextBox
    Friend WithEvents TB_诊断 As TextBox
    Friend WithEvents TB_住院号 As TextBox
    Friend WithEvents TB_床号 As TextBox
    Friend WithEvents L_患者编号 As Label
    Friend WithEvents L_住院日期 As Label
    Friend WithEvents L_诊断 As Label
    Friend WithEvents L_住院号 As Label
    Friend WithEvents L_床号 As Label
    Friend WithEvents GB_遗嘱筛选 As GroupBox
    Friend WithEvents GB_遗嘱状态 As GroupBox
    Friend WithEvents RB_全部遗嘱 As RadioButton
    Friend WithEvents RB_本次遗嘱 As RadioButton
    Friend WithEvents RB_未执行 As RadioButton
    Friend WithEvents RB_已执行 As RadioButton
    Friend WithEvents GB_遗嘱专区 As GroupBox
    Friend WithEvents CB_检查科室 As ComboBox
    Friend WithEvents CB_分类 As ComboBox
    Friend WithEvents GB_药品信息 As GroupBox
    Friend WithEvents L_库存S As Label
    Friend WithEvents TB_规格 As TextBox
    Friend WithEvents TB_药品名称 As TextBox
    Friend WithEvents TB_助记码 As TextBox
    Friend WithEvents L_规格 As Label
    Friend WithEvents L_药品名称 As Label
    Friend WithEvents L_助记码 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV_存单 As DataGridView
    Friend WithEvents DGV_项目库 As DataGridView
    Friend WithEvents B_加空行 As Button
    Friend WithEvents B_保存 As Button
    Friend WithEvents B_审核 As Button
    Friend WithEvents B_删除 As Button
    Friend WithEvents B_添加 As Button
    Friend WithEvents CB_用法 As ComboBox
    Friend WithEvents CB_标志 As ComboBox
    Friend WithEvents L_金额 As Label
    Friend WithEvents L_单价 As Label
    Friend WithEvents L_库存 As Label
    Friend WithEvents L_金额S As Label
    Friend WithEvents L_单价S As Label
    Friend WithEvents TB_数量 As TextBox
    Friend WithEvents L_数量 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CB_续页打印 As CheckBox
    Friend WithEvents CB_新页打印 As CheckBox
    Friend WithEvents B_查询 As Button
    Friend WithEvents B_重置 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TB_从_子项 As TextBox
    Friend WithEvents TB_到_子项 As TextBox
    Friend WithEvents B_快速打印 As Button
    Friend WithEvents B_打印 As Button
    Friend WithEvents DGV_药品库 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents 用法 As DataGridViewTextBoxColumn
    Friend WithEvents 项目名称 As DataGridViewTextBoxColumn
    Friend WithEvents 单位 As DataGridViewTextBoxColumn
    Friend WithEvents 所属科室 As DataGridViewTextBoxColumn
    Friend WithEvents 价格 As DataGridViewTextBoxColumn
    Friend WithEvents 备注 As DataGridViewTextBoxColumn
    Friend WithEvents PD_打印 As Printing.PrintDocument
    Friend WithEvents PD_快速打印 As Printing.PrintDocument
    Friend WithEvents NUD_到_子项 As NumericUpDown
    Friend WithEvents NUD_从_子项 As NumericUpDown
End Class
