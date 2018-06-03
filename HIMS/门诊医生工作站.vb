'written by:Nura
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class 门诊医生工作站

    Private Sub Btn_患者选择_Click(sender As Object, e As EventArgs) Handles Btn_患者选择.Click
        Dim child As New 挂号 With {
            .MdiParent = MDIForm
        }
        child.Show()
        ' child.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TB_助记码_TextChanged(sender As Object, e As EventArgs) Handles TB_助记码.TextChanged
        DataGridView1.DataSource = DbaseHelper.助记码_查询(TB_助记码.Text).Tables(0).DefaultView

    End Sub

    Private Sub 门诊医生工作站_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GhglDataSet.门诊病历模板' table. You can move, or remove it, as needed.

        Try
            DataGridView1.DataSource = DbaseHelper.助记码_查询(TB_助记码.Text).Tables(0).DefaultView
            TB_药品名称.DataBindings.Add("text", DataGridView1.DataSource, "药品名")
            TB_库存.DataBindings.Add("text", DataGridView1.DataSource, "库存")
            TB_规格.DataBindings.Add("text", DataGridView1.DataSource, "规格")
            TB_单价.DataBindings.Add("text", DataGridView1.DataSource, "单价")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
            DataGridView4.DataSource = DbaseHelper.Get门诊诊断模板.Tables(0).DefaultView

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
                sql.Parameters.AddWithValue("@患者姓名"， lbl_患者姓名.Text)
                sql.Parameters.AddWithValue("@诊断", TB_诊断.Text)
                sql.Parameters.AddWithValue("@主诉", RTB_主诉.Text)
                sql.Parameters.AddWithValue("@医嘱建议", CB_处理结果.Text)
                sql.Parameters.AddWithValue("@就诊医师", MDIForm.DownMenu_医生.Text)
                sql.Parameters.AddWithValue("@地址组", Convert.ToInt32(TB_村.Text & TB_组.Text))
                Dim result As Integer = sql.ExecuteNonQuery
                '  Console.WriteLine(“影响的行:{0}”, result)
            End Using
            cn.Close()
        End Using
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

    Private Sub DataGridView4_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView4.RowHeaderMouseClick
        If TB_诊断.Text = "" Then
            Me.TB_诊断.Text = DataGridView4.SelectedRows(0).Cells("诊断").Value.ToString
        Else
            Me.TB_诊断.Text = Me.TB_诊断.Text & "，" & DataGridView4.SelectedRows(0).Cells("诊断").Value.ToString
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
        DbaseHelper.Add_门诊病历模板(TB_诊断.Text, RTB_主诉.Text, CB_处理结果.Text)
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

        e.Graphics.DrawString(”     荒  地  镇  卫  生  院“, New Font("宋体", 16, FontStyle.Bold), b, 200, 100)
        e.Graphics.DrawString(”住院通知单“, New Font("宋体", 14, FontStyle.Underline), b, 340, 130)
        e.Graphics.DrawString(”患者编号:“ & lbl_参合号.Text & "        患者姓名：" & lbl_患者姓名.Text & "         年龄:" & lbl_年龄.Text, f, b, 50, 180)
        e.Graphics.DrawString("性别：" & lbl_性别.Text & "         结算方式:" & lbl_结算方式.Text & "        入院时情况:" & CB_入院时情况.Text, f, b, 50, 220)
        e.Graphics.DrawString("病区名:" & CB_病区名.Text & "                 诊断:" & TB_诊断.Text, f, b, 50, 260)
        e.Graphics.DrawString("家庭住址:荒地镇 " & TB_村.Text & "村" & TB_组.Text & "组", f, b, 50, 300)
        e.Graphics.DrawString("就诊医师: " & var_就诊医生 & "             就诊科室:" & var_部门, f, b, 100, 340)
        e.Graphics.DrawString("     就诊时间：" & Now, f, b, 200, 450)

        e.HasMorePages = False
    End Sub

    Private Sub CB_病区名_GotFocus(sender As Object, e As EventArgs) Handles CB_病区名.GotFocus
        CB_病区名.Items.Clear()

        For Each num In DbaseHelper.Get_病区名
            CB_病区名.Items.Add(num)
        Next

    End Sub

    Private Sub Btn_入院_Click(sender As Object, e As EventArgs) Handles Btn_入院.Click
        DbaseHelper.Set_入院单(Hex(lbl_参合号.Text), CB_病区名.Text, TB_诊断.Text)
        Message("已经提交到待收费"， 2， "成功！")
        DataGridView3.DataSource = vbNull
        DataGridView3.DataSource = DbaseHelper.Get_住院单_待收费.Tables(0).DefaultView
    End Sub

    Private Sub Btn_退院_Click(sender As Object, e As EventArgs) Handles Btn_退院.Click
        Dim value As String = DataGridView3.SelectedRows(0).Cells("患者编号").Value.ToString
        DbaseHelper.Del_住院单_待收费(value)
        Message("删除成功！"， 2， "成功！")
        DataGridView3.DataSource = vbNull
        DataGridView3.DataSource = DbaseHelper.Get_住院单_待收费.Tables(0).DefaultView
    End Sub

    Private Sub TB_诊断_GotFocus(sender As Object, e As EventArgs) Handles TB_诊断.GotFocus
        DataGridView5.DataSource = DbaseHelper.Get门诊病历(Hex(lbl_参合号.Text)).Tables(0).DefaultView
        DataGridView3.DataSource = DbaseHelper.Get_住院单_待收费.Tables(0).DefaultView
    End Sub

    Private Sub Btn_删除模板_Click(sender As Object, e As EventArgs) Handles Btn_删除模板.Click
        If DataGridView4.SelectedRows.Count = 1 Then
            Dim 诊断 As String = DataGridView4.SelectedRows(0).Cells("诊断").Value.ToString
            Dim 主诉 As String = DataGridView4.SelectedRows(0).Cells("主诉").Value.ToString
            Dim 医嘱建议 As String = DataGridView4.SelectedRows(0).Cells("医嘱建议").Value.ToString
            Dim frow As Integer
            Using cn As New SqlConnection(ConStr)
                cn.Open()
                Using sql As New SqlCommand("delete 门诊病历模板 where 诊断='" & 诊断 & "' and 主诉='" & 主诉 & "' and 医嘱建议='" & 医嘱建议 & "'")
                    sql.Connection = cn
                    frow = sql.ExecuteNonQuery
                End Using
                cn.Close()
            End Using
            Message("删除了" & frow & "条行！", 2, "消息")
            DataGridView4.DataSource = vbNull
            DataGridView4.DataSource = DbaseHelper.Get门诊诊断模板.Tables(0).DefaultView
        Else
            Message("已选择多行或没有选择删除的行！", 3, "错误")
            Exit Sub
        End If

    End Sub

    Private Sub Btn_更新模板_Click(sender As Object, e As EventArgs) Handles Btn_更新模板.Click
        DataGridView4.DataSource = vbNull
        DataGridView4.DataSource = DbaseHelper.Get门诊诊断模板.Tables(0).DefaultView
    End Sub

    Private Sub Btn_保存处方_Click(sender As Object, e As EventArgs) Handles Btn_保存处方.Click
        Dim 剂量 As String
        If Not (CB_使用方法.Text = "使用方法" And CB_次数.Text = "次数" And CB_单位.Text = "单位") Then
            If Trim(TB_剂量.Text) = "" Then
                剂量 = "按说明服用"
            Else
                剂量 = TB_剂量.Text & CB_剂量单位.Text
            End If
            DbaseHelper.Add_门诊处方(Hex(lbl_参合号.Text), TB_药品名称.Text, TB_规格.Text, Val(TB_数量.Text), CB_单位.Text, TB_剂量.Text, Convert.ToSingle(TB_单价.Text), Convert.ToDouble(TB_总价.Text), CB_使用方法.Text, var_部门, var_就诊医生).ToString()
            Message("新增处方：1条成功！", 2, "结果")
            Btn_更新处方_Click(sender, New EventArgs)
        Else
            Message("没有选择使用方法或使用次数！", 3, "错误")
        End If
    End Sub

    Private Sub Btn_更新处方_Click(sender As Object, e As EventArgs) Handles Btn_更新处方.Click
        DataGridView2.DataSource = vbNull
        DataGridView2.DataSource = DbaseHelper.Get_门诊处方(Hex(lbl_参合号.Text)).Tables(0).DefaultView

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
        Dim br As Brush = Brushes.Red
        Dim b As Brush = Brushes.Black

        Dim bl As Brush = Brushes.Blue
        Dim img As Image = Image.FromFile("D:\Hospital System\门诊医生工作站\HIMS\HIMS\Resources\处方.jpg")
        Dim f As New Font("宋体", 12, FontStyle.Regular)
        Dim f2 As New Font("宋体", 10, FontStyle.Regular)
        Dim f3 As New Font("微软雅黑", 13, FontStyle.Bold)
        e.Graphics.DrawImage(img, 0, 0, 1012, 716)
        '********************定义区域************************
        Dim 编码, 处方年, 处方月, 处方日, 患者姓名， 性别， 年龄， 民族， 科别, 合作医疗证号, 临床诊断， 组村， 医师 As String
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
        组村 = TB_村.Text & "-" & TB_组.Text
        医师 = var_就诊医生
        If lbl_结算方式.Text = "合作医疗" Then
            农合 = True
        Else
            农合 = False
        End If
        '**********************第二段copy变量******************
        For cp As Integer = 0 To 472 Step 472
            '*******************开始打印***************************
            e.Graphics.DrawString(编码, f, b, 100 + cp, 130)
            e.Graphics.DrawString(处方年， f2, b, 326 + cp, 130)
            e.Graphics.DrawString(处方月， f2, b, 373 + cp, 130)
            e.Graphics.DrawString(处方日， f2, b, 410 + cp, 130)
            e.Graphics.DrawString(患者姓名， f, b, 120 + cp, 160)
            e.Graphics.DrawString(性别， f, b, 330 + cp, 160)
            e.Graphics.DrawString(年龄， f, b, 385 + cp, 160)
            e.Graphics.DrawString(民族， f, b, 440 + cp, 160)
            If 农合 Then
                e.Graphics.DrawString("√"， f, b, 388 + cp, 200)
            End If
            e.Graphics.DrawString(科别， f, b, 80 + cp, 235)
            e.Graphics.DrawString(合作医疗证号， f, b, 345 + cp, 232)
            e.Graphics.DrawString(临床诊断 & vbTab & 组村， f, b, 150 + cp, 260)
            e.Graphics.DrawString(医师， f, b, 310 + cp, 620)
            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                e.Graphics.DrawString(DataGridView2.Rows(i).Cells("药品名称").Value & vbTab & DataGridView2.Rows(i).Cells("规格").Value & "*" & DataGridView2.Rows(i).Cells("数量").Value & DataGridView2.Rows(i).Cells("单位").Value, f3, b, 80 + cp, 330 + (i * 50))
                e.Graphics.DrawString("用法:" & DataGridView2.Rows(i).Cells("用法").Value & vbTab & "每次剂量:" & DataGridView2.Rows(i).Cells("剂量").Value, f, b, 110 + cp, 355 + (i * 50))
            Next
        Next
        e.HasMorePages = False
    End Sub

    Private Sub B_打印处方_Click(sender As Object, e As EventArgs) Handles B_打印处方.Click
        Dim papersize As PaperSize = New PaperSize("Custom Paper Size", 1012, 716)
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
            value = DbaseHelper.Del_门诊处方(患者编号, 药品名称, 日期, 时间)
            Message("成功删除" & value & "条记录！", 3, "删除处方成功！")
            Btn_更新处方_Click(sender, New EventArgs)
        End If
    End Sub

End Class