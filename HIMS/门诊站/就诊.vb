'written by:"Nura"
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class 就诊

    Private Sub Btn_患者选择_Click(sender As Object, e As EventArgs) Handles Btn_患者选择.Click
        Dim child As New 挂号 With {
                .MdiParent = 主窗体
                }
        child.Show()
        ' child.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TB_助记码_TextChanged(sender As Object, e As EventArgs) Handles TB_助记码.TextChanged
        DataGridView1.DataSource = Get_药品库存(TB_助记码.Text).Tables(0).DefaultView
        TB_药品名称.Text = DataGridView1.CurrentRow.Cells("药品名").Value.ToString()
        TB_库存.Text = DataGridView1.CurrentRow.Cells("库存").Value.ToString()
        TB_规格.Text = DataGridView1.CurrentRow.Cells("规格").Value.ToString()
        TB_单价.Text = DataGridView1.CurrentRow.Cells("单价").Value.ToString()
    End Sub

    Private Sub 门诊医生工作站_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AlreadyRunning() Then
            MessageBox.Show("另一个实例在运行中!", "不允许新实例", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            DataGridView1.DataSource = Get_药品库存(TB_助记码.Text).Tables(0).DefaultView
            TB_药品名称.DataBindings.Add("text", DataGridView1.DataSource, "药品名")
            TB_库存.DataBindings.Add("text", DataGridView1.DataSource, "库存")
            TB_规格.DataBindings.Add("text", DataGridView1.DataSource, "规格")
            TB_单价.DataBindings.Add("text", DataGridView1.DataSource, "单价")

            'DataGridView5.DataSource = DbaseHelper.Get门诊病历(lbl_参合号.Text).Tables(0).DefaultView
            'DataGridView3.DataSource = DbaseHelper.Get_住院单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
            'DataGridView4.DataSource = DbaseHelper.Get门诊诊断模板.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show("错误:出在:门诊医生工作站,门诊医生工作站_Load 触发器上\n" + ex.Message, "错误")
        End Try
    End Sub

    Private Sub 门诊医生工作站_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If var_患者姓名 IsNot vbNullString Then
            Me.lbl_参合号.Text = var_参合号
            Me.lbl_患者姓名.Text = var_患者姓名
            Me.lbl_结算方式.Text = var_结算方式
            Me.lbl_年龄.Text = var_年龄
            Me.lbl_性别.Text = var_性别
            Me.TabControl1.Visible = True
            Me.TabControl1.SelectedTab = TabPage2
            DataGridView4.DataSource = Get门诊诊断模板.Tables(0).DefaultView

            TB_村.Text = Trim(Mid(lbl_参合号.Text, 3, 2))
            ' Me.TB_助记码.Select()
        Else
        End If
        '  Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Lbl_患者姓名_Click(sender As Object, e As EventArgs) Handles lbl_患者姓名.Click
        If lbl_患者姓名.Text IsNot vbNullString Then
            TabControl1.Visible = True
            ' TB_助记码.Select()
        End If
    End Sub

    Private Sub TB_助记码_GotFocus(sender As Object, e As EventArgs) Handles TB_助记码.GotFocus
        TB_药品名称.DataBindings.Clear()
        TB_库存.DataBindings.Clear()
        TB_规格.DataBindings.Clear()
        TB_单价.DataBindings.Clear()
        TB_药品名称.DataBindings.Add("text", DataGridView1.DataSource, "药品名")
        TB_库存.DataBindings.Add("text", DataGridView1.DataSource, "库存")
        TB_规格.DataBindings.Add("text", DataGridView1.DataSource, "规格")
        TB_单价.DataBindings.Add("text", DataGridView1.DataSource, "单价")
    End Sub

    Private Sub TB_数量_TextChanged(sender As Object, e As EventArgs) Handles TB_数量.TextChanged
        TB_总价.Text = Val(TB_数量.Text) * Val(TB_单价.Text)
    End Sub

    Private Sub Btn_保存诊断_Click(sender As Object, e As EventArgs) Handles Btn_保存诊断.Click
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("[dbo].[DAL_门诊病历_InsertCommand]")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@患者编号", Hex(lbl_参合号.Text))
                sql.Parameters.AddWithValue("@患者姓名", lbl_患者姓名.Text)
                sql.Parameters.AddWithValue("@诊断", TB_诊断.Text)
                sql.Parameters.AddWithValue("@主诉", RTB_主诉.Text)
                sql.Parameters.AddWithValue("@医嘱建议", CB_处理结果.Text)
                sql.Parameters.AddWithValue("@就诊医师", 主窗体.DownMenu_医生.Text)
                sql.Parameters.AddWithValue("@地址组", Convert.ToInt32(TB_村.Text & TB_组.Text))
                Dim result As Integer = sql.ExecuteNonQuery
                '  Console.WriteLine(“影响的行: {0}”, result)
            End Using
            cn.Close()
        End Using

        '在这里更新DGV,病历
        DataGridView5.DataSource = Get门诊病历(Hex(lbl_参合号.Text)).Tables(0).DefaultView

        '处方
        '检查
        '住院
        '其他
        If CB_处理结果.Text = "处方" Then
            TabControl1.SelectedTab = TabPage1
        ElseIf CB_处理结果.Text = "检查" Then
            TabControl1.SelectedTab = TabPage3
        ElseIf CB_处理结果.Text = "住院" Then
            CB_病区名.Select()
        End If
    End Sub

    Private Sub DataGridView4_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) _
        Handles DataGridView4.RowHeaderMouseClick
        If TB_诊断.Text = "" Then
            Me.TB_诊断.Text = DataGridView4.SelectedRows(0).Cells("诊断").Value.ToString
        Else
            Me.TB_诊断.Text = Me.TB_诊断.Text & "," & DataGridView4.SelectedRows(0).Cells("诊断").Value.ToString
        End If
        Me.RTB_主诉.Text = DataGridView4.SelectedRows(0).Cells("主诉").Value.ToString
        Me.CB_处理结果.Text = DataGridView4.SelectedRows(0).Cells("医嘱建议").Value.ToString
    End Sub

    Private Sub TabControl1_VisibleChanged(sender As Object, e As EventArgs) Handles TabControl1.VisibleChanged
        '  If TabControl1.Visible Then
        '  If TabControl1.SelectedTab Is TabControl1.TabPages(1) Then
        ' DataGridView5.DataSource = DbaseHelper.get门诊病历(Hex(lbl_参合号.Text)).Tables(0).DefaultView
        '  DataGridView3.DataSource = bindingSource1
        '  End If
        'End If
    End Sub

    Private Sub Btn_保存为模板_Click(sender As Object, e As EventArgs) Handles Btn_保存为模板.Click
        Add_门诊病历模板(TB_诊断.Text, RTB_主诉.Text, CB_处理结果.Text)
        DataGridView4.DataSource = Get门诊诊断模板().Tables(0).DefaultView()
    End Sub

    Private Sub Btn_住院单打印_Click(sender As Object, e As EventArgs) Handles Btn_住院单打印.Click
        Dim PD As New PrintDocument
        AddHandler PD.PrintPage, AddressOf Me.PD_住院单_PrintPage
        PD.Print()
    End Sub

    Private Sub PD_住院单_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD_住院单.PrintPage
        e.PageSettings.PaperSize = New PaperSize("住院单", 7.16, 10.12)
        ' e.PageSettings.PrinterSettings.
        Dim f As New Font("宋体", 12, FontStyle.Regular)
        Dim b As Brush = Brushes.Black
        For i = 0 To 600 Step 600
            e.Graphics.DrawString(”     荒  地  镇  卫  生  院“, New Font("宋体", 16, FontStyle.Bold), b, 200, 100 + i)
            e.Graphics.DrawString(”住院通知单“, New Font("宋体", 14, FontStyle.Underline), b, 340, 130 + i)
            e.Graphics.DrawString(
                ”患者编号:“ & lbl_参合号.Text & "        患者姓名：" & lbl_患者姓名.Text & "         年龄:" & lbl_年龄.Text, f, b, 50,
                180 + i)
            e.Graphics.DrawString(
                "性别：" & lbl_性别.Text & "         结算方式:" & lbl_结算方式.Text & "        入院时情况:" & CB_入院时情况.Text, f, b, 50,
                220 + i)
            e.Graphics.DrawString("病区名:" & CB_病区名.Text & "                 诊断:" & TB_诊断.Text, f, b, 50, 260 + i)
            Console.WriteLine(“诊断:” + TB_诊断.Text)
            e.Graphics.DrawString("家庭住址:荒地镇 " & TB_村.Text & "村" & TB_组.Text & "组", f, b, 50, 300 + i)
            e.Graphics.DrawString("就诊医师: " & var_就诊医生 & "             就诊科室:" & var_部门, f, b, 100, 340 + i)
            e.Graphics.DrawString("     就诊时间：" & Now, f, b, 200, 450 + i)
        Next
        e.HasMorePages = False
    End Sub

    Private Sub CB_病区名_GotFocus(sender As Object, e As EventArgs) Handles CB_病区名.GotFocus
        CB_病区名.Items.Clear()
        For Each num In Get_病区名()
            CB_病区名.Items.Add(num)
        Next
    End Sub

    Private Sub Btn_入院_Click(sender As Object, e As EventArgs) Handles Btn_入院.Click
        Set_入院单(Hex(lbl_参合号.Text), CB_病区名.Text, TB_诊断.Text)
        Message("已经提交到待收费", 2, "成功！")
        DataGridView3.DataSource = vbNull
        Get_住院单_待收费.Tables(0).Clear()
        DataGridView3.DataSource = Get_住院单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
    End Sub

    Private Sub Btn_退院_Click(sender As Object, e As EventArgs) Handles Btn_退院.Click
        Dim value As String = DataGridView3.SelectedRows(0).Cells("患者编号").Value.ToString
        Del_住院单_待收费(value)
        Message("删除成功！", 2, "成功！")
        DataGridView3.DataSource = vbNull
        DataGridView3.DataSource = Get_住院单(lbl_参合号.Text).Tables(0).DefaultView
    End Sub

    Private Sub TB_诊断_GotFocus(sender As Object, e As EventArgs) Handles TB_诊断.GotFocus
        DataGridView5.DataSource = Get门诊病历(Hex(lbl_参合号.Text)).Tables(0).DefaultView
        DataGridView3.DataSource = Get_住院单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
        Console.WriteLine("HEX:" + Hex(lbl_参合号.Text))
    End Sub

    Private Sub Btn_删除模板_Click(sender As Object, e As EventArgs) Handles Btn_删除模板.Click
        If DataGridView4.SelectedRows.Count = 1 Then
            Dim 诊断 As String = DataGridView4.SelectedRows(0).Cells("诊断").Value.ToString
            Dim 主诉 As String = DataGridView4.SelectedRows(0).Cells("主诉").Value.ToString
            Dim 医嘱建议 As String = DataGridView4.SelectedRows(0).Cells("医嘱建议").Value.ToString
            Dim frow As Integer
            Using cn As New SqlConnection(ConStr)
                cn.Open()
                Using _
                    sql As _
                        New SqlCommand("delete 门诊病历模板 where 诊断='" & 诊断 & "' and 主诉='" & 主诉 & "' and 医嘱建议='" & 医嘱建议 & "'")
                    sql.Connection = cn
                    frow = sql.ExecuteNonQuery
                End Using
                cn.Close()
            End Using
            Message("删除了" & frow & "条行！", 2, "消息")
            DataGridView4.DataSource = vbNull
            DataGridView4.DataSource = Get门诊诊断模板.Tables(0).DefaultView
        Else
            Message("已选择多行或没有选择删除的行！", 3, "错误")
            Exit Sub
        End If
    End Sub

    Private Sub Btn_更新模板_Click(sender As Object, e As EventArgs) Handles Btn_更新模板.Click
        DataGridView4.DataSource = vbNull
        DataGridView4.DataSource = Get门诊诊断模板.Tables(0).DefaultView
    End Sub

    Private Sub Btn_保存处方_Click(sender As Object, e As EventArgs) Handles Btn_保存处方.Click
        Dim 剂量 As String
        If Not (CB_使用方法.Text = "使用方法" And CB_次数.Text = "次数" And CB_单位.Text = "单位") Then
            If Trim(TB_剂量.Text) = "" Then
                剂量 = "按说明服用"
            Else
                剂量 = TB_剂量.Text & CB_剂量单位.Text
            End If
            Add_门诊处方(Hex(lbl_参合号.Text), TB_药品名称.Text, TB_规格.Text, Val(TB_数量.Text), CB_单位.Text, TB_剂量.Text,
                     Convert.ToSingle(TB_单价.Text), Convert.ToDouble(TB_总价.Text), CB_使用方法.Text, var_部门, var_就诊医生).
                ToString()
            Message("新增处方：1条成功！", 2, "结果")
            Btn_更新处方_Click(sender, New EventArgs)
        Else
            Message("没有选择使用方法或使用次数！", 3, "错误")
        End If
    End Sub

    Private Sub Btn_更新处方_Click(sender As Object, e As EventArgs) Handles Btn_更新处方.Click
        DataGridView2.DataSource = vbNull
        DataGridView2.DataSource = Get_门诊处方(Hex(lbl_参合号.Text)).Tables(0).DefaultView
    End Sub

    Private Sub 门诊医生工作站_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        var_患者姓名 = vbNull
        Me.Dispose()
        GC.Collect()
    End Sub

    Private Sub 门诊医生工作站_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GC.Collect()
    End Sub

    Private Sub PD_处方_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD_处方.PrintPage
        On Error GoTo 1
        Dim br As Brush = Brushes.Red
        Dim b As Brush = Brushes.Black

        Dim bl As Brush = Brushes.Blue
        Dim img As Image = Image.FromFile("Resources\处方.jpg")
        Dim f As New Font("宋体", 12, FontStyle.Regular)
        Dim f2 As New Font("宋体", 10, FontStyle.Regular)
        Dim f3 As New Font("微软雅黑", 13, FontStyle.Bold)
        e.Graphics.DrawImage(img, 0, 0, 1012, 716)
        '********************定义区域************************
        Dim 编码, 处方年, 处方月, 处方日, 患者姓名,
         性别, 年龄, 民族, 科别, 合作医疗证号, 临床诊断,
         组村, 医师 As String
        Dim 农合 As Boolean
        '**********************实例化**********************
        编码 = Hex(lbl_参合号.Text)
        处方年 = Date.Today.Year
        处方月 = Date.Today.Month
        处方日 = Date.Today.Day
        患者姓名 = lbl_患者姓名.Text
        性别 = lbl_性别.Text
        年龄 = lbl_年龄.Text

        If Len(lbl_患者姓名.Text) > 5 Then
            民族 = "维"
        Else
            民族 = ""
        End If
        科别 = var_部门
        合作医疗证号 = var_参合号
        临床诊断 = TB_诊断.Text
        If Trim(TB_组.Text) = "" Then
            组村 = TB_村.Text & "村"
        Else
            组村 = TB_村.Text & " 村 " & TB_组.Text & " 小队"
        End If

        医师 = var_就诊医生
        If lbl_结算方式.Text = "合作医疗" Then
            农合 = True
        Else
            农合 = False
        End If
        '**********************第二段copy变量******************
        For cp = 0 To 472 Step 472
            '*******************开始打印***************************
            e.Graphics.DrawString(编码, f, b, 100 + cp, 130)
            e.Graphics.DrawString(处方年, f2, b, 326 + cp, 130)
            e.Graphics.DrawString(处方月, f2, b, 373 + cp, 130)
            e.Graphics.DrawString(处方日, f2, b, 410 + cp, 130)
            e.Graphics.DrawString(患者姓名, f, b, 110 + cp, 160)
            e.Graphics.DrawString(性别, f, b, 330 + cp, 160)
            e.Graphics.DrawString(年龄, f, b, 385 + cp, 160)
            e.Graphics.DrawString(民族, f, b, 440 + cp, 160)
            If 农合 Then
                e.Graphics.DrawString("√", f, b, 388 + cp, 200)
            End If
            e.Graphics.DrawString(科别, f, b, 80 + cp, 235)
            e.Graphics.DrawString(合作医疗证号, f, b, 345 + cp, 232)
            e.Graphics.DrawString(临床诊断 & vbTab & 组村, f, b, 150 + cp, 260)
            e.Graphics.DrawString(医师, f, b, 305 + cp, 615)
            For i = 0 To DataGridView2.Rows.Count - 1
                e.Graphics.DrawString(
                    DataGridView2.Rows(i).Cells("药品名称").Value & vbTab & DataGridView2.Rows(i).Cells("规格").Value & "*" &
                    DataGridView2.Rows(i).Cells("数量").Value & DataGridView2.Rows(i).Cells("单位").Value, f3, b, 80 + cp,
                    330 + (i * 50))
                e.Graphics.DrawString(
                    "用法:" & DataGridView2.Rows(i).Cells("用法").Value & vbTab & "每次剂量:" &
                    DataGridView2.Rows(i).Cells("剂量").Value, f, b, 110 + cp, 355 + (i * 50))
            Next
        Next
        e.HasMorePages = False

1:
        MessageBox.Show("在打印处方是出现错误,门诊医生工作站,PD_处方.PrintPage\n", "打印出错")
    End Sub

    Private Sub B_打印处方_Click(sender As Object, e As EventArgs) Handles B_打印处方.Click
        Dim papersize = New PaperSize("Custom Paper Size", 1012, 716)
        'custom papersize
        Dim PD As New PrintDocument
        PD.DefaultPageSettings.PaperSize = papersize
        PD.DefaultPageSettings.Landscape = False
        'set the landscape to other sides
        AddHandler PD.PrintPage, AddressOf Me.PD_处方_PrintPage
        PD.Print()
    End Sub

    Private Sub Btn_删除处方_Click(sender As Object, e As EventArgs) Handles Btn_删除处方.Click
        Dim 患者编号, 药品名称 As String
        Dim 日期 As Date
        Dim 时间 As TimeSpan
        Dim value As Integer
        患者编号 = Hex(lbl_参合号.Text)
        If DataGridView2.CurrentCell.Selected Then
            药品名称 = DataGridView2.SelectedRows(0).Cells("药品名称").Value.ToString
            日期 = CDate(DataGridView2.SelectedRows(0).Cells("日期").Value)
            时间 = DataGridView2.SelectedRows(0).Cells("时间").Value
            value = Del_门诊处方(患者编号, 药品名称, 日期, 时间)
            Message("成功删除" & value & "条记录！", 3, "删除处方成功！")
            Btn_更新处方_Click(sender, New EventArgs)
        End If
    End Sub

    Private Sub CB_选择科室_GotFocus(sender As Object, e As EventArgs) Handles CB_选择科室.GotFocus
        CB_选择科室.Items.Clear()
        For Each d In Get_检查科室()
            CB_选择科室.Items.Add(d)
        Next
    End Sub

    Private Sub CB_检查项目_GotFocus(sender As Object, e As EventArgs) Handles CB_检查项目.GotFocus
        If CB_选择科室.Text IsNot "选择科室" Then
            CB_检查项目.Items.Clear()
            For Each item In Get_检查项目名称(Trim(CB_选择科室.Text))
                CB_检查项目.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub CB_检查项目_TextChanged(sender As Object, e As EventArgs) Handles CB_检查项目.TextChanged
        If CB_检查项目.Text IsNot "检查项目" And CB_选择科室.Text IsNot "选择科室" Then
            DataGridView6.DataSource = vbNull
            DataGridView6.DataSource = Get_检查项(CB_选择科室.Text, CB_检查项目.Text).Tables(0).DefaultView
            TB_项目单位.DataBindings.Clear()
            TB_项目单位.DataBindings.Add(New Binding("text", DataGridView6.DataSource, "单位"))
            TB_价格.DataBindings.Clear()
            TB_价格.DataBindings.Add(New Binding("text", DataGridView6.DataSource, "价格"))
        End If
    End Sub

    Private Sub CB_选择科室_TextChanged(sender As Object, e As EventArgs) Handles CB_选择科室.TextChanged
        CB_检查项目.Items.Clear()
        CB_检查项目.Text = "检查项目"
        TB_项目单位.Text = ""
        TB_价格.Text = ""
    End Sub

    Private Sub Btn_添加检查_Click(sender As Object, e As EventArgs) Handles Btn_添加检查.Click
        If CB_检查项目.Text IsNot "检查项目" And CB_选择科室.Text IsNot "选择科室" Then
            Add_检查单(Hex(lbl_参合号.Text), CB_选择科室.Text, CB_检查项目.Text, TB_项目单位.Text, TB_价格.Text, var_部门, var_就诊医生, "待划价")
            Message("添加检查项目成功！", 2, "成功")
        Else
            Message("不能添加空的检查项目", 3, "失败")
        End If
        DataGridView7.DataSource = Get_检查单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
    End Sub

    Private Sub PD_检查单_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD_检查单_参合.PrintPage
        '*********定义区域*********
        Dim 基本信息 As String = "流水号:" & var_参合号 & Space(4) & "患者姓名：" & var_患者姓名 & Space(4) & "性别:" & var_性别 & Space(2) &
                             "年龄:" & var_年龄
        Dim 合作信息 As String = "结算方式:" & var_结算方式 & Space(8) & "地址：" & TB_村.Text & "村" & TB_组.Text & "组" & Space(8) &
                             "诊断:" & TB_诊断.Text
        Dim 检查项目 As String = "检查项目:" & DataGridView7.Rows(0).Cells("检查项目").Value & Space(8) & "规格:" &
                             DataGridView7.Rows(0).Cells("单位").Value & Space(8) & "价格:" &
                             DataGridView7.Rows(0).Cells("价格").Value & "元"
        Dim b As Brush = Brushes.Black
        Dim f = New Font("宋体", 12)
        Dim 分支线 = "------------------------------------------------------------------------------------"
        '***********结束***************
        '***********打印区域***********
        For i = 0 To 506 Step 506
            e.Graphics.DrawImage(My.Resources.hospital, 200, 40 + i, 48, 48)
            e.Graphics.DrawImage(My.Resources.hospital, 510, 40 + i, 48, 48)
            e.Graphics.DrawString("莎 车 县 荒 地 镇 卫 生 院", New Font("宋体", 14, FontStyle.Bold), b, 250, 38 + i)
            e.Graphics.DrawString(DataGridView7.SelectedRows(0).Cells("检查科室").Value & "检查申请单",
                                  New Font("楷体", 12, FontStyle.Underline), b, 280, 68 + i)
            e.Graphics.DrawLine(Pens.Black, 50, 102 + i, 700, 102 + i）
            e.Graphics.DrawLine(Pens.Black, 50, 105 + i, 700, 105 + i）
            e.Graphics.DrawString(基本信息, f, b, 60, 115 + i)
            e.Graphics.DrawString(合作信息, f, b, 60, 155 + i)
            e.Graphics.DrawString(检查项目, f, b, 60, 195 + i)
            e.Graphics.DrawLine(Pens.Black, 50, 220 + i, 700, 220 + i)
            e.Graphics.DrawString("总金额：      合作医疗报销金额：          自费金额：", f, b, 50, 245 + i)
            e.Graphics.DrawString("申请科室：" & var_部门 & Space(5) & "申请医师：" & var_就诊医生 & Space(5) & "划价员:        收费员：", f, b, 50,
                              285 + i)
            e.Graphics.DrawString("申请时间:" & Now.ToString, f, b, 220, 335 + i)
            e.Graphics.DrawString("注：盖章后有效!", New Font("黑体", 14, FontStyle.Bold), b, 250, 390 + i)
        Next
        '*************打印结束********
        e.Graphics.DrawString(分支线, f, b, 0, 500)
        e.HasMorePages = False
    End Sub

    Private Sub Btn_医保打印_Click(sender As Object, e As EventArgs) Handles B_合作医疗打印.Click
        If DataGridView7.Rows.Count > 0 Then
            Dim p As New PrintDocument
            '自定义纸张尺寸
            Dim papersize = New PaperSize("B5(JIS)", 717, 1012)
            p.DefaultPageSettings.PaperSize = papersize
            p.DefaultPageSettings.Landscape = False
            AddHandler p.PrintPage, AddressOf PD_检查单_PrintPage
            p.Print()
        Else

        End If
    End Sub

    Private Sub lbl_参合号_TextChanged(sender As Object, e As EventArgs) Handles lbl_参合号.TextChanged
        DataGridView5.DataSource = Get门诊病历(lbl_参合号.Text).Tables(0).DefaultView
        DataGridView3.DataSource = Get_住院单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
        DataGridView4.DataSource = Get门诊诊断模板.Tables(0).DefaultView
    End Sub

    Private Sub TB_诊断_TextChanged(sender As Object, e As EventArgs) Handles TB_诊断.TextChanged
        DataGridView3.DataSource = Get_住院单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        TB_药品名称.Text = DataGridView1.CurrentRow.Cells("药品名").Value.ToString()
        TB_库存.Text = DataGridView1.CurrentRow.Cells("库存").Value.ToString()
        TB_规格.Text = DataGridView1.CurrentRow.Cells("规格").Value.ToString()
        TB_单价.Text = DataGridView1.CurrentRow.Cells("单价").Value.ToString()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            DataGridView7.DataSource = Get_检查单(Hex(lbl_参合号.Text)).Tables(0).DefaultView
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
    End Sub

    Private Sub Btn_自费打印_Click(sender As Object, e As EventArgs) Handles Btn_自费打印.Click
        If DataGridView7.Rows.Count > 0 Then
            Dim p As New PrintDocument
            Dim paper_size = New PaperSize("B5(JIS)", 717, 1012)
            p.DefaultPageSettings.PaperSize = paper_size
            p.DefaultPageSettings.Landscape = False
            AddHandler p.PrintPage, AddressOf PD_检查单_自费_PrintPage
            p.Print()
        End If
    End Sub

    Private Sub PD_检查单_自费_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD_检查单_自费.PrintPage
        '*********定义区域*********
        Dim 基本信息 As String = "流水号:" & var_参合号 & Space(4) & "患者姓名：" & var_患者姓名 & Space(4) & "性别:" & var_性别 & Space(2) &
                             "年龄:" & var_年龄
        Dim 合作信息 As String = "结算方式:" & var_结算方式 & Space(8) & "地址：" & TB_村.Text & "村" & TB_组.Text & "组" & Space(8) &
                             "诊断:" & TB_诊断.Text
        Dim 检查项目 As String = "检查项目:" & DataGridView7.Rows(0).Cells("检查项目").Value & Space(8) & "规格:" &
                             DataGridView7.Rows(0).Cells("单位").Value & Space(8) & "价格:" &
                             DataGridView7.Rows(0).Cells("价格").Value & "元"
        Dim b As Brush = Brushes.Black
        Dim f = New Font("宋体", 12)
        Dim 分支线 = "------------------------------------------------------------------------------------"
        '***********结束***************
        '***********打印区域***********
        For i = 0 To 506 Step 506
            e.Graphics.DrawImage(My.Resources.hospital, 200, 40 + i, 48, 48)
            e.Graphics.DrawImage(My.Resources.hospital, 510, 40 + i, 48, 48)
            e.Graphics.DrawString("莎 车 县 荒 地 镇 卫 生 院", New Font("宋体", 14, FontStyle.Bold), b, 250, 38 + i)
            e.Graphics.DrawString(DataGridView7.SelectedRows(0).Cells("检查科室").Value & "检查申请单",
                                  New Font("楷体", 12, FontStyle.Underline), b, 280, 68 + i)
            e.Graphics.DrawLine(Pens.Black, 50, 102 + i, 700, 102 + i)
            e.Graphics.DrawLine(Pens.Black, 50, 105 + i, 700, 105 + i)
            e.Graphics.DrawString(基本信息, f, b, 60, 115 + i)
            e.Graphics.DrawString(合作信息, f, b, 60, 155 + i)
            e.Graphics.DrawString(检查项目, f, b, 60, 195 + i)
            e.Graphics.DrawLine(Pens.Black, 50, 220 + i, 700, 220 + i)
            e.Graphics.DrawString("总金额：      合作医疗报销金额：          自费金额：", f, b, 50, 245 + i)
            e.Graphics.DrawString("申请科室：" & var_部门 & Space(5) & "申请医师：" & var_就诊医生 & Space(5) & "划价员:        收费员：", f, b, 50,
                              285 + i)
            e.Graphics.DrawString("申请时间:" & Now.ToString, f, b, 220, 335 + i)
            e.Graphics.DrawString("注：盖章后有效!", New Font("黑体", 14, FontStyle.Bold), b, 250, 390 + i)
        Next
        '*************打印结束********
        e.Graphics.DrawString(分支线, f, b, 0, 500)
        e.HasMorePages = False
    End Sub

    Private Sub Btn_删除检查_Click(sender As Object, e As EventArgs) Handles Btn_删除检查.Click
        'Dim lr As LocalReport = New LocalReport
        'Dim rv As ReportViewer = New ReportViewer
        'lr.DataSources.Add(New ReportDataSource("\..\..\Reporter.rdlc"))
        'rv.LocalReport.DataSources.Add(New ReportDataSource("\..\..\reporter.rdlc"))
        'rv.Show()
        报表浏览.Show()
    End Sub

End Class