<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 门诊医生工作站
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
        Me.components = New System.ComponentModel.Container()
        Dim LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_参合号 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_患者姓名 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_性别 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_年龄 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_结算方式 = New System.Windows.Forms.Label()
        Me.Btn_患者选择 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn_更新处方 = New System.Windows.Forms.Button()
        Me.Btn_保存处方 = New System.Windows.Forms.Button()
        Me.B_打印处方 = New System.Windows.Forms.Button()
        Me.Btn_删除处方 = New System.Windows.Forms.Button()
        Me.CB_剂量单位 = New System.Windows.Forms.ComboBox()
        Me.CB_单位 = New System.Windows.Forms.ComboBox()
        Me.CB_次数 = New System.Windows.Forms.ComboBox()
        Me.CB_使用方法 = New System.Windows.Forms.ComboBox()
        Me.TB_单价 = New System.Windows.Forms.TextBox()
        Me.TB_库存 = New System.Windows.Forms.TextBox()
        Me.TB_药品名称 = New System.Windows.Forms.TextBox()
        Me.TB_剂量 = New System.Windows.Forms.TextBox()
        Me.TB_总价 = New System.Windows.Forms.TextBox()
        Me.TB_数量 = New System.Windows.Forms.TextBox()
        Me.TB_规格 = New System.Windows.Forms.TextBox()
        Me.TB_助记码 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Btn_退院 = New System.Windows.Forms.Button()
        Me.Btn_入院 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_更新模板 = New System.Windows.Forms.Button()
        Me.Btn_删除模板 = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Btn_住院单打印 = New System.Windows.Forms.Button()
        Me.CB_入院时情况 = New System.Windows.Forms.ComboBox()
        Me.CB_病区名 = New System.Windows.Forms.ComboBox()
        Me.TB_组 = New System.Windows.Forms.TextBox()
        Me.TB_村 = New System.Windows.Forms.TextBox()
        Me.Btn_保存为模板 = New System.Windows.Forms.Button()
        Me.Btn_保存诊断 = New System.Windows.Forms.Button()
        Me.CB_处理结果 = New System.Windows.Forms.ComboBox()
        Me.TB_诊断 = New System.Windows.Forms.TextBox()
        Me.RTB_主诉 = New System.Windows.Forms.RichTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.Btn_自费打印 = New System.Windows.Forms.Button()
        Me.Btn_医保打印 = New System.Windows.Forms.Button()
        Me.Btn_删除检查 = New System.Windows.Forms.Button()
        Me.Btn_添加检查 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_价格 = New System.Windows.Forms.TextBox()
        Me.TB_项目单位 = New System.Windows.Forms.TextBox()
        Me.TB_项目详情 = New System.Windows.Forms.TextBox()
        Me.CB_检查项目 = New System.Windows.Forms.ComboBox()
        Me.CB_选择科室 = New System.Windows.Forms.ComboBox()
        Me.PD_住院单 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PD_处方 = New System.Drawing.Printing.PrintDocument()
        LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineShape2
        '
        LineShape2.Enabled = False
        LineShape2.Name = "LineShape2"
        LineShape2.X1 = -6
        LineShape2.X2 = 334
        LineShape2.Y1 = 210
        LineShape2.Y2 = 210
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_参合号)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_患者姓名)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_性别)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_年龄)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_结算方式)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_患者选择)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(911, 36)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'lbl_参合号
        '
        Me.lbl_参合号.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_参合号.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_参合号.Location = New System.Drawing.Point(4, 2)
        Me.lbl_参合号.Margin = New System.Windows.Forms.Padding(4, 2, 4, 0)
        Me.lbl_参合号.Name = "lbl_参合号"
        Me.lbl_参合号.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl_参合号.Size = New System.Drawing.Size(122, 26)
        Me.lbl_参合号.TabIndex = 0
        Me.lbl_参合号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(132, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 1, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(79, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "患者姓名："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_患者姓名
        '
        Me.lbl_患者姓名.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_患者姓名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_患者姓名.Location = New System.Drawing.Point(215, 2)
        Me.lbl_患者姓名.Margin = New System.Windows.Forms.Padding(4, 2, 4, 0)
        Me.lbl_患者姓名.Name = "lbl_患者姓名"
        Me.lbl_患者姓名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl_患者姓名.Size = New System.Drawing.Size(217, 26)
        Me.lbl_患者姓名.TabIndex = 2
        Me.lbl_患者姓名.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(436, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "性别："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_性别
        '
        Me.lbl_性别.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_性别.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_性别.Location = New System.Drawing.Point(493, 2)
        Me.lbl_性别.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lbl_性别.Name = "lbl_性别"
        Me.lbl_性别.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl_性别.Size = New System.Drawing.Size(33, 26)
        Me.lbl_性别.TabIndex = 6
        Me.lbl_性别.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(526, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(57, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "年龄:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_年龄
        '
        Me.lbl_年龄.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_年龄.Location = New System.Drawing.Point(583, 2)
        Me.lbl_年龄.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lbl_年龄.Name = "lbl_年龄"
        Me.lbl_年龄.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl_年龄.Size = New System.Drawing.Size(41, 26)
        Me.lbl_年龄.TabIndex = 7
        Me.lbl_年龄.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(624, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(83, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "结算方式："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_结算方式
        '
        Me.lbl_结算方式.BackColor = System.Drawing.Color.LawnGreen
        Me.lbl_结算方式.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_结算方式.Location = New System.Drawing.Point(711, 2)
        Me.lbl_结算方式.Margin = New System.Windows.Forms.Padding(4, 2, 4, 0)
        Me.lbl_结算方式.Name = "lbl_结算方式"
        Me.lbl_结算方式.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl_结算方式.Size = New System.Drawing.Size(73, 26)
        Me.lbl_结算方式.TabIndex = 9
        Me.lbl_结算方式.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_患者选择
        '
        Me.Btn_患者选择.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_患者选择.BackColor = System.Drawing.Color.Salmon
        Me.Btn_患者选择.Location = New System.Drawing.Point(788, 0)
        Me.Btn_患者选择.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_患者选择.Name = "Btn_患者选择"
        Me.Btn_患者选择.Size = New System.Drawing.Size(117, 32)
        Me.Btn_患者选择.TabIndex = 10
        Me.Btn_患者选择.Text = "挂       号"
        Me.Btn_患者选择.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.TabControl1.ItemSize = New System.Drawing.Size(96, 30)
        Me.TabControl1.Location = New System.Drawing.Point(13, 63)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(10, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(911, 488)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.Btn_更新处方)
        Me.TabPage1.Controls.Add(Me.Btn_保存处方)
        Me.TabPage1.Controls.Add(Me.B_打印处方)
        Me.TabPage1.Controls.Add(Me.Btn_删除处方)
        Me.TabPage1.Controls.Add(Me.CB_剂量单位)
        Me.TabPage1.Controls.Add(Me.CB_单位)
        Me.TabPage1.Controls.Add(Me.CB_次数)
        Me.TabPage1.Controls.Add(Me.CB_使用方法)
        Me.TabPage1.Controls.Add(Me.TB_单价)
        Me.TabPage1.Controls.Add(Me.TB_库存)
        Me.TabPage1.Controls.Add(Me.TB_药品名称)
        Me.TabPage1.Controls.Add(Me.TB_剂量)
        Me.TabPage1.Controls.Add(Me.TB_总价)
        Me.TabPage1.Controls.Add(Me.TB_数量)
        Me.TabPage1.Controls.Add(Me.TB_规格)
        Me.TabPage1.Controls.Add(Me.TB_助记码)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(903, 450)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "处      方"
        '
        'Btn_更新处方
        '
        Me.Btn_更新处方.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_更新处方.Location = New System.Drawing.Point(361, 154)
        Me.Btn_更新处方.Name = "Btn_更新处方"
        Me.Btn_更新处方.Size = New System.Drawing.Size(94, 36)
        Me.Btn_更新处方.TabIndex = 20
        Me.Btn_更新处方.Text = "更新记录"
        Me.Btn_更新处方.UseVisualStyleBackColor = False
        '
        'Btn_保存处方
        '
        Me.Btn_保存处方.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_保存处方.Location = New System.Drawing.Point(248, 154)
        Me.Btn_保存处方.Name = "Btn_保存处方"
        Me.Btn_保存处方.Size = New System.Drawing.Size(94, 36)
        Me.Btn_保存处方.TabIndex = 19
        Me.Btn_保存处方.Text = "保存处方"
        Me.Btn_保存处方.UseVisualStyleBackColor = False
        '
        'B_打印处方
        '
        Me.B_打印处方.BackColor = System.Drawing.Color.ForestGreen
        Me.B_打印处方.Location = New System.Drawing.Point(135, 154)
        Me.B_打印处方.Name = "B_打印处方"
        Me.B_打印处方.Size = New System.Drawing.Size(94, 36)
        Me.B_打印处方.TabIndex = 18
        Me.B_打印处方.Text = "打印处方"
        Me.B_打印处方.UseVisualStyleBackColor = False
        '
        'Btn_删除处方
        '
        Me.Btn_删除处方.BackColor = System.Drawing.Color.SandyBrown
        Me.Btn_删除处方.Location = New System.Drawing.Point(22, 154)
        Me.Btn_删除处方.Name = "Btn_删除处方"
        Me.Btn_删除处方.Size = New System.Drawing.Size(94, 36)
        Me.Btn_删除处方.TabIndex = 17
        Me.Btn_删除处方.Text = "删除处方"
        Me.Btn_删除处方.UseVisualStyleBackColor = False
        '
        'CB_剂量单位
        '
        Me.CB_剂量单位.FormattingEnabled = True
        Me.CB_剂量单位.Items.AddRange(New Object() {"克", "ml", "粒", "支", "片", "毫克"})
        Me.CB_剂量单位.Location = New System.Drawing.Point(236, 100)
        Me.CB_剂量单位.Name = "CB_剂量单位"
        Me.CB_剂量单位.Size = New System.Drawing.Size(66, 24)
        Me.CB_剂量单位.TabIndex = 16
        '
        'CB_单位
        '
        Me.CB_单位.FormattingEnabled = True
        Me.CB_单位.Items.AddRange(New Object() {"盒", "瓶", "剂"})
        Me.CB_单位.Location = New System.Drawing.Point(88, 99)
        Me.CB_单位.Name = "CB_单位"
        Me.CB_单位.Size = New System.Drawing.Size(66, 24)
        Me.CB_单位.TabIndex = 14
        Me.CB_单位.Text = "单位"
        '
        'CB_次数
        '
        Me.CB_次数.FormattingEnabled = True
        Me.CB_次数.Items.AddRange(New Object() {"一次/日", "两次/日", "三次/日"})
        Me.CB_次数.Location = New System.Drawing.Point(272, 56)
        Me.CB_次数.Name = "CB_次数"
        Me.CB_次数.Size = New System.Drawing.Size(84, 24)
        Me.CB_次数.TabIndex = 11
        Me.CB_次数.Text = "次数"
        '
        'CB_使用方法
        '
        Me.CB_使用方法.FormattingEnabled = True
        Me.CB_使用方法.Items.AddRange(New Object() {"口服", "注射", "局部用药"})
        Me.CB_使用方法.Location = New System.Drawing.Point(162, 56)
        Me.CB_使用方法.Name = "CB_使用方法"
        Me.CB_使用方法.Size = New System.Drawing.Size(105, 24)
        Me.CB_使用方法.TabIndex = 10
        Me.CB_使用方法.Text = "使用方法"
        '
        'TB_单价
        '
        Me.TB_单价.Enabled = False
        Me.TB_单价.Location = New System.Drawing.Point(436, 14)
        Me.TB_单价.MaxLength = 6
        Me.TB_单价.Name = "TB_单价"
        Me.TB_单价.Size = New System.Drawing.Size(38, 23)
        Me.TB_单价.TabIndex = 8
        '
        'TB_库存
        '
        Me.TB_库存.Enabled = False
        Me.TB_库存.Location = New System.Drawing.Point(349, 14)
        Me.TB_库存.MaxLength = 4
        Me.TB_库存.Name = "TB_库存"
        Me.TB_库存.Size = New System.Drawing.Size(38, 23)
        Me.TB_库存.TabIndex = 7
        '
        'TB_药品名称
        '
        Me.TB_药品名称.Location = New System.Drawing.Point(230, 14)
        Me.TB_药品名称.MaxLength = 20
        Me.TB_药品名称.Name = "TB_药品名称"
        Me.TB_药品名称.Size = New System.Drawing.Size(115, 23)
        Me.TB_药品名称.TabIndex = 6
        '
        'TB_剂量
        '
        Me.TB_剂量.Location = New System.Drawing.Point(203, 100)
        Me.TB_剂量.MaxLength = 2
        Me.TB_剂量.Name = "TB_剂量"
        Me.TB_剂量.Size = New System.Drawing.Size(28, 23)
        Me.TB_剂量.TabIndex = 15
        '
        'TB_总价
        '
        Me.TB_总价.Enabled = False
        Me.TB_总价.Location = New System.Drawing.Point(402, 55)
        Me.TB_总价.Name = "TB_总价"
        Me.TB_总价.Size = New System.Drawing.Size(75, 23)
        Me.TB_总价.TabIndex = 12
        '
        'TB_数量
        '
        Me.TB_数量.Location = New System.Drawing.Point(55, 99)
        Me.TB_数量.MaxLength = 2
        Me.TB_数量.Name = "TB_数量"
        Me.TB_数量.Size = New System.Drawing.Size(28, 23)
        Me.TB_数量.TabIndex = 13
        '
        'TB_规格
        '
        Me.TB_规格.Enabled = False
        Me.TB_规格.Location = New System.Drawing.Point(54, 55)
        Me.TB_规格.MaxLength = 20
        Me.TB_规格.Name = "TB_规格"
        Me.TB_规格.Size = New System.Drawing.Size(100, 23)
        Me.TB_规格.TabIndex = 9
        '
        'TB_助记码
        '
        Me.TB_助记码.Location = New System.Drawing.Point(70, 14)
        Me.TB_助记码.MaxLength = 10
        Me.TB_助记码.Name = "TB_助记码"
        Me.TB_助记码.Size = New System.Drawing.Size(86, 23)
        Me.TB_助记码.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(162, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "剂量："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "数量："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(362, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "总价："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "规格："
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 200)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(891, 211)
        Me.DataGridView2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(485, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(412, 183)
        Me.DataGridView1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(393, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "单价："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "药品名称："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "助记码："
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Btn_退院)
        Me.TabPage2.Controls.Add(Me.Btn_入院)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.DataGridView3)
        Me.TabPage2.Controls.Add(Me.Btn_住院单打印)
        Me.TabPage2.Controls.Add(Me.CB_入院时情况)
        Me.TabPage2.Controls.Add(Me.CB_病区名)
        Me.TabPage2.Controls.Add(Me.TB_组)
        Me.TabPage2.Controls.Add(Me.TB_村)
        Me.TabPage2.Controls.Add(Me.Btn_保存为模板)
        Me.TabPage2.Controls.Add(Me.Btn_保存诊断)
        Me.TabPage2.Controls.Add(Me.CB_处理结果)
        Me.TabPage2.Controls.Add(Me.TB_诊断)
        Me.TabPage2.Controls.Add(Me.RTB_主诉)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.ShapeContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(903, 450)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "门诊病历"
        '
        'Btn_退院
        '
        Me.Btn_退院.BackColor = System.Drawing.Color.Yellow
        Me.Btn_退院.Location = New System.Drawing.Point(108, 252)
        Me.Btn_退院.Name = "Btn_退院"
        Me.Btn_退院.Size = New System.Drawing.Size(97, 36)
        Me.Btn_退院.TabIndex = 13
        Me.Btn_退院.Text = "退      院"
        Me.Btn_退院.UseVisualStyleBackColor = False
        '
        'Btn_入院
        '
        Me.Btn_入院.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_入院.Location = New System.Drawing.Point(6, 252)
        Me.Btn_入院.Name = "Btn_入院"
        Me.Btn_入院.Size = New System.Drawing.Size(97, 36)
        Me.Btn_入院.TabIndex = 13
        Me.Btn_入院.Text = "入     院"
        Me.ToolTip1.SetToolTip(Me.Btn_入院, "录入到待入院名单里，患者直接去住院部报道。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "护士负责录入相关信息，分配床等。")
        Me.Btn_入院.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView5)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 143)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "病历记录"
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(15, 26)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.Size = New System.Drawing.Size(539, 104)
        Me.DataGridView5.TabIndex = 0
        Me.DataGridView5.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_更新模板)
        Me.GroupBox1.Controls.Add(Me.Btn_删除模板)
        Me.GroupBox1.Controls.Add(Me.DataGridView4)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 251)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "参照病历模板"
        '
        'Btn_更新模板
        '
        Me.Btn_更新模板.BackColor = System.Drawing.Color.Aqua
        Me.Btn_更新模板.Location = New System.Drawing.Point(457, 127)
        Me.Btn_更新模板.Name = "Btn_更新模板"
        Me.Btn_更新模板.Size = New System.Drawing.Size(101, 39)
        Me.Btn_更新模板.TabIndex = 1
        Me.Btn_更新模板.Text = "更新记录"
        Me.Btn_更新模板.UseVisualStyleBackColor = False
        '
        'Btn_删除模板
        '
        Me.Btn_删除模板.BackColor = System.Drawing.Color.Yellow
        Me.Btn_删除模板.Location = New System.Drawing.Point(457, 56)
        Me.Btn_删除模板.Name = "Btn_删除模板"
        Me.Btn_删除模板.Size = New System.Drawing.Size(101, 39)
        Me.Btn_删除模板.TabIndex = 1
        Me.Btn_删除模板.Text = "删      除"
        Me.Btn_删除模板.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToOrderColumns = True
        Me.DataGridView4.AllowUserToResizeColumns = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView4.Location = New System.Drawing.Point(14, 27)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(434, 204)
        Me.DataGridView4.TabIndex = 0
        Me.DataGridView4.TabStop = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(3, 294)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(306, 125)
        Me.DataGridView3.TabIndex = 10
        Me.DataGridView3.TabStop = False
        '
        'Btn_住院单打印
        '
        Me.Btn_住院单打印.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_住院单打印.Location = New System.Drawing.Point(212, 222)
        Me.Btn_住院单打印.Name = "Btn_住院单打印"
        Me.Btn_住院单打印.Size = New System.Drawing.Size(98, 40)
        Me.Btn_住院单打印.TabIndex = 10
        Me.Btn_住院单打印.Text = "住院单打印"
        Me.Btn_住院单打印.UseVisualStyleBackColor = False
        '
        'CB_入院时情况
        '
        Me.CB_入院时情况.FormattingEnabled = True
        Me.CB_入院时情况.ItemHeight = 16
        Me.CB_入院时情况.Items.AddRange(New Object() {"危重", "急", "一般"})
        Me.CB_入院时情况.Location = New System.Drawing.Point(108, 222)
        Me.CB_入院时情况.Name = "CB_入院时情况"
        Me.CB_入院时情况.Size = New System.Drawing.Size(100, 24)
        Me.CB_入院时情况.TabIndex = 8
        Me.CB_入院时情况.Text = "入院时情况"
        '
        'CB_病区名
        '
        Me.CB_病区名.FormattingEnabled = True
        Me.CB_病区名.ItemHeight = 16
        Me.CB_病区名.Location = New System.Drawing.Point(6, 222)
        Me.CB_病区名.Name = "CB_病区名"
        Me.CB_病区名.Size = New System.Drawing.Size(96, 24)
        Me.CB_病区名.TabIndex = 7
        Me.CB_病区名.Text = " 病区名"
        '
        'TB_组
        '
        Me.TB_组.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_组.Location = New System.Drawing.Point(129, 175)
        Me.TB_组.MaxLength = 2
        Me.TB_组.Name = "TB_组"
        Me.TB_组.Size = New System.Drawing.Size(32, 24)
        Me.TB_组.TabIndex = 6
        '
        'TB_村
        '
        Me.TB_村.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_村.Location = New System.Drawing.Point(64, 175)
        Me.TB_村.MaxLength = 2
        Me.TB_村.Name = "TB_村"
        Me.TB_村.Size = New System.Drawing.Size(34, 24)
        Me.TB_村.TabIndex = 5
        '
        'Btn_保存为模板
        '
        Me.Btn_保存为模板.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_保存为模板.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_保存为模板.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_保存为模板.Location = New System.Drawing.Point(199, 169)
        Me.Btn_保存为模板.Name = "Btn_保存为模板"
        Me.Btn_保存为模板.Size = New System.Drawing.Size(111, 38)
        Me.Btn_保存为模板.TabIndex = 7
        Me.Btn_保存为模板.Text = "保存为模板"
        Me.Btn_保存为模板.UseVisualStyleBackColor = False
        '
        'Btn_保存诊断
        '
        Me.Btn_保存诊断.BackColor = System.Drawing.Color.Aqua
        Me.Btn_保存诊断.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_保存诊断.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_保存诊断.Location = New System.Drawing.Point(199, 128)
        Me.Btn_保存诊断.Name = "Btn_保存诊断"
        Me.Btn_保存诊断.Size = New System.Drawing.Size(111, 38)
        Me.Btn_保存诊断.TabIndex = 4
        Me.Btn_保存诊断.Text = "保           存"
        Me.Btn_保存诊断.UseVisualStyleBackColor = False
        '
        'CB_处理结果
        '
        Me.CB_处理结果.FormattingEnabled = True
        Me.CB_处理结果.Items.AddRange(New Object() {"处方", "检查", "住院", "其他"})
        Me.CB_处理结果.Location = New System.Drawing.Point(90, 135)
        Me.CB_处理结果.Name = "CB_处理结果"
        Me.CB_处理结果.Size = New System.Drawing.Size(93, 24)
        Me.CB_处理结果.TabIndex = 3
        '
        'TB_诊断
        '
        Me.TB_诊断.Location = New System.Drawing.Point(51, 16)
        Me.TB_诊断.MaxLength = 50
        Me.TB_诊断.Name = "TB_诊断"
        Me.TB_诊断.Size = New System.Drawing.Size(260, 23)
        Me.TB_诊断.TabIndex = 1
        '
        'RTB_主诉
        '
        Me.RTB_主诉.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_主诉.Location = New System.Drawing.Point(51, 51)
        Me.RTB_主诉.MaxLength = 250
        Me.RTB_主诉.Name = "RTB_主诉"
        Me.RTB_主诉.Size = New System.Drawing.Size(260, 63)
        Me.RTB_主诉.TabIndex = 2
        Me.RTB_主诉.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "主诉："
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 178)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "地址：             村            组"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "处理结果："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "诊断："
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(897, 444)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.DataGridView7)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(903, 450)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "申请检查"
        '
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(13, 216)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(875, 187)
        Me.DataGridView7.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView6)
        Me.GroupBox3.Controls.Add(Me.Btn_自费打印)
        Me.GroupBox3.Controls.Add(Me.Btn_医保打印)
        Me.GroupBox3.Controls.Add(Me.Btn_删除检查)
        Me.GroupBox3.Controls.Add(Me.Btn_添加检查)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TB_价格)
        Me.GroupBox3.Controls.Add(Me.TB_项目单位)
        Me.GroupBox3.Controls.Add(Me.TB_项目详情)
        Me.GroupBox3.Controls.Add(Me.CB_检查项目)
        Me.GroupBox3.Controls.Add(Me.CB_选择科室)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(705, 181)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "申请检查"
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(11, 102)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(680, 62)
        Me.DataGridView6.TabIndex = 9
        '
        'Btn_自费打印
        '
        Me.Btn_自费打印.BackColor = System.Drawing.Color.SpringGreen
        Me.Btn_自费打印.Location = New System.Drawing.Point(601, 63)
        Me.Btn_自费打印.Name = "Btn_自费打印"
        Me.Btn_自费打印.Size = New System.Drawing.Size(90, 32)
        Me.Btn_自费打印.TabIndex = 8
        Me.Btn_自费打印.Text = "自费打印"
        Me.Btn_自费打印.UseVisualStyleBackColor = False
        '
        'Btn_医保打印
        '
        Me.Btn_医保打印.BackColor = System.Drawing.Color.Green
        Me.Btn_医保打印.Location = New System.Drawing.Point(477, 64)
        Me.Btn_医保打印.Name = "Btn_医保打印"
        Me.Btn_医保打印.Size = New System.Drawing.Size(90, 32)
        Me.Btn_医保打印.TabIndex = 7
        Me.Btn_医保打印.Text = "医保打印"
        Me.Btn_医保打印.UseVisualStyleBackColor = False
        '
        'Btn_删除检查
        '
        Me.Btn_删除检查.BackColor = System.Drawing.Color.Coral
        Me.Btn_删除检查.Location = New System.Drawing.Point(601, 17)
        Me.Btn_删除检查.Name = "Btn_删除检查"
        Me.Btn_删除检查.Size = New System.Drawing.Size(90, 32)
        Me.Btn_删除检查.TabIndex = 6
        Me.Btn_删除检查.Text = "删       除"
        Me.Btn_删除检查.UseVisualStyleBackColor = False
        '
        'Btn_添加检查
        '
        Me.Btn_添加检查.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn_添加检查.Location = New System.Drawing.Point(477, 16)
        Me.Btn_添加检查.Name = "Btn_添加检查"
        Me.Btn_添加检查.Size = New System.Drawing.Size(90, 32)
        Me.Btn_添加检查.TabIndex = 5
        Me.Btn_添加检查.Text = "添       加"
        Me.Btn_添加检查.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(267, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 17)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "价格："
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(267, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "单位："
        '
        'TB_价格
        '
        Me.TB_价格.Location = New System.Drawing.Point(318, 65)
        Me.TB_价格.MaxLength = 6
        Me.TB_价格.Name = "TB_价格"
        Me.TB_价格.Size = New System.Drawing.Size(103, 23)
        Me.TB_价格.TabIndex = 4
        '
        'TB_项目单位
        '
        Me.TB_项目单位.Location = New System.Drawing.Point(317, 27)
        Me.TB_项目单位.MaxLength = 10
        Me.TB_项目单位.Name = "TB_项目单位"
        Me.TB_项目单位.Size = New System.Drawing.Size(104, 23)
        Me.TB_项目单位.TabIndex = 2
        '
        'TB_项目详情
        '
        Me.TB_项目详情.Location = New System.Drawing.Point(14, 64)
        Me.TB_项目详情.MaxLength = 30
        Me.TB_项目详情.Name = "TB_项目详情"
        Me.TB_项目详情.Size = New System.Drawing.Size(240, 23)
        Me.TB_项目详情.TabIndex = 3
        '
        'CB_检查项目
        '
        Me.CB_检查项目.FormattingEnabled = True
        Me.CB_检查项目.Location = New System.Drawing.Point(137, 27)
        Me.CB_检查项目.Name = "CB_检查项目"
        Me.CB_检查项目.Size = New System.Drawing.Size(118, 24)
        Me.CB_检查项目.TabIndex = 1
        Me.CB_检查项目.Text = "检查项目"
        '
        'CB_选择科室
        '
        Me.CB_选择科室.FormattingEnabled = True
        Me.CB_选择科室.Location = New System.Drawing.Point(13, 27)
        Me.CB_选择科室.Name = "CB_选择科室"
        Me.CB_选择科室.Size = New System.Drawing.Size(118, 24)
        Me.CB_选择科室.TabIndex = 0
        Me.CB_选择科室.Text = "选择科室"
        '
        'PD_住院单
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "说明"
        '
        'PD_处方
        '
        Me.PD_处方.DocumentName = "处方"
        '
        '门诊医生工作站
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(931, 520)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "门诊医生工作站"
        Me.Text = "门诊医生工作站"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_患者姓名 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_性别 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_年龄 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_结算方式 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TB_单价 As TextBox
    Friend WithEvents TB_库存 As TextBox
    Friend WithEvents TB_药品名称 As TextBox
    Friend WithEvents TB_总价 As TextBox
    Friend WithEvents TB_规格 As TextBox
    Friend WithEvents TB_助记码 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Btn_更新处方 As Button
    Friend WithEvents Btn_保存处方 As Button
    Friend WithEvents B_打印处方 As Button
    Friend WithEvents Btn_删除处方 As Button
    Friend WithEvents CB_剂量单位 As ComboBox
    Friend WithEvents CB_单位 As ComboBox
    Friend WithEvents CB_次数 As ComboBox
    Friend WithEvents CB_使用方法 As ComboBox
    Friend WithEvents TB_剂量 As TextBox
    Friend WithEvents TB_数量 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Btn_患者选择 As Button
    Friend WithEvents TB_诊断 As TextBox
    Friend WithEvents RTB_主诉 As RichTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_更新模板 As Button
    Friend WithEvents Btn_删除模板 As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Btn_住院单打印 As Button
    Friend WithEvents CB_入院时情况 As ComboBox
    Friend WithEvents CB_病区名 As ComboBox
    Friend WithEvents TB_组 As TextBox
    Friend WithEvents TB_村 As TextBox
    Friend WithEvents Btn_保存为模板 As Button
    Friend WithEvents Btn_保存诊断 As Button
    Friend WithEvents CB_处理结果 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents Btn_自费打印 As Button
    Friend WithEvents Btn_医保打印 As Button
    Friend WithEvents Btn_删除检查 As Button
    Friend WithEvents Btn_添加检查 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TB_价格 As TextBox
    Friend WithEvents TB_项目单位 As TextBox
    Friend WithEvents TB_项目详情 As TextBox
    Friend WithEvents CB_检查项目 As ComboBox
    Friend WithEvents CB_选择科室 As ComboBox
    Friend WithEvents lbl_参合号 As Label
    Friend WithEvents PD_住院单 As Printing.PrintDocument
    Friend WithEvents Btn_退院 As Button
    Friend WithEvents Btn_入院 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents PD_处方 As Printing.PrintDocument
End Class
