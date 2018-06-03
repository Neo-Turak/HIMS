'written by:Nura
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.VisualBasic.Strings

Public Class 新增档案

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TB_患者编号.TextChanged
        If TB_患者编号.Text = "" Then
            Me.TB_患者编号.Text = String.Format("YYYYMMDDHHMMSS", Now())
        End If
    End Sub

    Private Sub TB_合作医疗证号_TextChanged(sender As Object, e As EventArgs) Handles TB_合作医疗证号.TextChanged

        Dim hzylzh As String
        hzylzh = Trim(Me.TB_合作医疗证号.Text)
        TB_患者编号.Text = Strings.UCase(Hex(hzylzh))
        CB_结算方式.Text = “合作医疗”

        If Strings.Len(TB_合作医疗证号.Text) >= 10 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            Using con As New SqlConnection(ConStr)
                con.Open()
                Using mrc As New SqlCommand("select 姓名,合作医疗号 from 参合名单 where 合作医疗号 like'%" & hzylzh & "%'", con)
                    Using RDR = mrc.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read
                                ListBox2.Items.Add(RDR.Item("姓名").ToString())
                                ListBox1.Items.Add(Mid((RDR.Item("合作医疗号").ToString()), 11, 2))
                            Loop
                        End If
                    End Using
                End Using
                con.Close()
            End Using
        End If

        If Strings.Len(TB_合作医疗证号.Text) = 12 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            Using con As New SqlConnection(ConStr)
                con.Open()
                Using cmd As New SqlCommand("select * from 参合名单 where 合作医疗号=@id", con)
                    cmd.Parameters.AddWithValue("@id", hzylzh)
                    Using RDR = cmd.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read()
                                ListBox2.Items.Add(RDR.Item("姓名").ToString())
                                TB_患者姓名.Text = RDR.Item("姓名").ToString()
                                TB_身份证号.Text = RDR.Item("身份证号").ToString()
                                'ListBox1.Items.Add(Strings.Mid(RDR.Item("合作医疗号").ToString(), 11, 2))
                            Loop
                            CB_结算方式.Text = "合作医疗"
                        Else
                            ListBox2.Items.Add("此人不存在！")
                        End If
                    End Using
                End Using
            End Using
        End If

        If Len(hzylzh) = 12 And Strings.Left(hzylzh, 2) = "07" Then
            TB_家庭住址.Text = "荒地镇" & Strings.Mid(TB_合作医疗证号.Text, 3, 2) & "村  组"

        ElseIf Len(hzylzh) = 12 And Strings.Left(hzylzh, 2) = "08" Then
            TB_家庭住址.Text = "敦巴格乡" & Strings.Mid(TB_合作医疗证号.Text, 3, 2) & "村  组"

        ElseIf Len(hzylzh) = 12 Then
            TB_家庭住址.Text = "外乡镇" & Strings.Mid(TB_合作医疗证号.Text, 3, 2) & "村  组"
        End If

    End Sub

    Private Sub 新增档案_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DbaseHelper.患者总表_14days_select().Tables(0).DefaultView
        ' DataGridView1.AutoResizeColumnHeadersHeight()
        'DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TB_合作医疗证号.Select()

    End Sub

    Private Sub TB_身份证号_TextChanged(sender As Object, e As EventArgs) Handles TB_身份证号.TextChanged
        Dim c, y, z As Integer
        Dim sfzh As String
        sfzh = TB_身份证号.Text
        If Strings.Len(sfzh) = 18 Then

            c = Val(Mid(sfzh, 7, 4))
            y = Mid(sfzh, 7, 8)
            z = Mid(sfzh, 17, 1)
            TB_年龄.Text = (Now().Year - c).ToString()
            DTP_出生日期.Value = CDate(Format(y, "####-##-##"))

            If z Mod 2 = 1 Then
                CB_性别.Text = "男"
            Else
                CB_性别.Text = "女"
            End If

            CB_婚姻状态.Select()

        End If
    End Sub

    Private Sub 新增档案_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub CB_婚姻状态_GotFocus(sender As Object, e As EventArgs) Handles CB_婚姻状态.GotFocus
        Dim list1, list2 As ListBox
        list1 = ListBox1
        list2 = ListBox2
        list1.Items.Clear()
        list2.Items.Clear()

        For c As Int32 = 1 To 5
            list1.Items.Add(c)
        Next
        list2.Items.Add("已婚")
        list2.Items.Add("离婚")
        list2.Items.Add("未婚")
        list2.Items.Add("丧偶")
        list2.Items.Add("未说明的婚姻状况")

    End Sub

    Private Sub CB_婚姻状态_LostFocus(sender As Object, e As EventArgs) Handles CB_婚姻状态.LostFocus
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Btn_添加_Click(sender As Object, e As EventArgs) Handles Btn_添加.Click
        '相片的处理
        Dim mStream As MemoryStream = New MemoryStream()
        If Not PB_相片.Image Is Nothing Then
            PB_相片.Image.Save(mStream, ImageFormat.Jpeg)
        End If

        '相片处理结束
        Try

            Using con As New SqlConnection(ConStr)
                con.Open()
                Using sql As New SqlCommand("dbo.DAL_患者总表_InsertCommand", con)
                    sql.CommandType = CommandType.StoredProcedure
                    sql.Parameters.AddWithValue("@患者编号", TB_患者编号.Text)
                    sql.Parameters.AddWithValue("@合作医疗号", TB_合作医疗证号.Text)
                    sql.Parameters.AddWithValue("@患者姓名", TB_患者姓名.Text)
                    sql.Parameters.AddWithValue("@身份证号", TB_身份证号.Text)
                    sql.Parameters.AddWithValue("@性别", CB_性别.Text)
                    sql.Parameters.AddWithValue("@出生日期", Convert.ToDateTime(DTP_出生日期.Text))
                    sql.Parameters.AddWithValue("@年龄", Convert.ToInt32(TB_年龄.Text))
                    sql.Parameters.AddWithValue("@婚姻状况", CB_婚姻状态.Text)
                    sql.Parameters.AddWithValue("@民族", CB_民族.Text)
                    sql.Parameters.AddWithValue("@联系电话", TB_联系电话.Text)
                    sql.Parameters.AddWithValue("@家庭住址", TB_家庭住址.Text)
                    sql.Parameters.AddWithValue("@有无过敏史", "")
                    sql.Parameters.AddWithValue("@结算方式", CB_结算方式.Text)
                    sql.Parameters.AddWithValue("@建档日期", DateTime.Now)
                    sql.Parameters.AddWithValue("@相片", mStream.GetBuffer)
                    sql.Parameters.AddWithValue("@备注", "")
                    sql.ExecuteNonQuery()
                End Using
                con.Close()
            End Using
            MessageBox.Show(Me, "新增档案成功！", "成功")
        Catch ex As SqlException
            MessageBox.Show(Me, "出现错误：" + ex.Message)
        End Try
        DataGridView1.DataSource = DbaseHelper.患者总表_14days_select().Tables(0).DefaultView
    End Sub

    Private Sub TB_民族_GotFocus(sender As Object, e As EventArgs)

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox2.Items.Add("维吾尔族")
        ListBox2.Items.Add("汉族")
        ListBox2.Items.Add("哈萨克族")
        ListBox2.Items.Add("回族")
        ListBox2.Items.Add("柯尔克孜族")
        ListBox2.Items.Add("蒙古族")
        ListBox2.Items.Add("塔吉克族")
        ListBox2.Items.Add("锡伯族")
        ListBox2.Items.Add("满族")
        ListBox2.Items.Add("乌孜别克族")
        ListBox2.Items.Add("俄罗斯族")
        ListBox2.Items.Add("达斡尔族")
        ListBox2.Items.Add("塔塔尔族")
        ListBox2.Items.Add("其他")
    End Sub

    Private Sub CB_性别_GotFocus(sender As Object, e As EventArgs) Handles CB_性别.GotFocus
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim c As Integer = 1
        For Each ite As String In CB_性别.Items
            ListBox1.Items.Add(c)
            ListBox2.Items.Add(ite)
            c = c + 1
        Next

    End Sub

    Private Sub CB_民族_GotFocus(sender As Object, e As EventArgs) Handles CB_民族.GotFocus
        Dim int As Int32 = 1
        For Each item As String In CB_民族.Items
            ListBox1.Items.Add(int)
            ListBox2.Items.Add(item)
            int = int + 1
        Next
    End Sub

    Private Sub CB_民族_LostFocus(sender As Object, e As EventArgs) Handles CB_民族.LostFocus
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub

    Private Sub CB_性别_LostFocus(sender As Object, e As EventArgs) Handles CB_性别.LostFocus
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub

    Private Sub btn_从本地导入_Click(sender As Object, e As EventArgs) Handles btn_从本地导入.Click
        OpenFileDialog1.Filter = "图像|*.jpg;*.jpeg|便携式网络图形|*.png|标准图形|*.bmp|动态图形|*.gif|位图|*.TIFF"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Try
                PB_相片.Image = System.Drawing.Image.FromFile(path)
            Catch ex As Exception
                Console.WriteLine(ex.Message())
            End Try
        End If
    End Sub

    Private Sub Btn_清除相片_Click(sender As Object, e As EventArgs) Handles Btn_清除相片.Click
        PB_相片.Image = Nothing

    End Sub

    Private Sub Btn_摄像头_Click(sender As Object, e As EventArgs) Handles Btn_摄像头.Click
        抓图器.Show()
        抓图器.Activate()

    End Sub

    Private Sub PB_相片_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PB_相片.LoadCompleted
        PB_相片.SizeMode = PictureBoxSizeMode.CenterImage

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_网址载入.Click
        Dim value As String = InputBox("请输入图片网址", "从网址载入")
        Try
            If value IsNot "" Then
                PB_相片.Load(value)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "出现错误：" + ex.Message)
        End Try
    End Sub

    Private Sub Btn_更新相片_Click(sender As Object, e As EventArgs)
        DbaseHelper.store_pic_Sql(PB_相片.Image, TB_患者编号.Text.ToString())
    End Sub

    Private Sub Selector(sender As Object, e As EventArgs) Handles CB_婚姻状态.TextChanged, CB_民族.TextChanged, CB_性别.TextChanged, CB_结算方式.TextChanged
        Dim c As String
        Dim t As Short
        Dim 触发器 As ComboBox
        触发器 = CType(sender, ComboBox)
        c = Strings.Left(触发器.Text, 1)
        If Int32.TryParse(c, t) Then
            触发器.Text = ListBox2.Items(t - 1)
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub CB_结算方式_GotFocus(sender As Object, e As EventArgs) Handles CB_结算方式.GotFocus
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        ListBox1.Items.Add(1)
        ListBox1.Items.Add(2)

        ListBox2.Items.Add("合作医疗")
        ListBox2.Items.Add("自费")

    End Sub

    Private Sub CB_结算方式_LostFocus(sender As Object, e As EventArgs) Handles CB_结算方式.LostFocus
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Btn_删除_Click(sender As Object, e As EventArgs) Handles Btn_删除.Click
        '删除一个已经选择的对象
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim par1, par2, par3 As String
            par1 = DataGridView1.SelectedRows.Item(0).Cells(0).Value
            par2 = DataGridView1.SelectedRows.Item(0).Cells(1).Value
            par3 = DataGridView1.SelectedRows.Item(0).Cells(2).Value
            If DbaseHelper.患者总表_删除(par1, par2, par3) Then
                Message("记录删除成功！", 2, "消息")
                DataGridView1.DataSource = DbaseHelper.患者总表_14days_select.Tables(0).DefaultView
            Else
                Message("删除失败！", 1, "请重试")
            End If
        Else
            Message("请选择要删除的记录！", 1, "错误")
        End If

    End Sub

    Private Sub TB_年龄_TextChanged(sender As Object, e As EventArgs) Handles TB_年龄.TextChanged
        If Val(TB_年龄.Text) < 18 Then
            CB_婚姻状态.Text = "未婚"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Dim i As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DbaseHelper.修改ID_患者总表() Then
            i = i + 1
            Label13.Text = "执行：" & i & " 次"
            Label14.Text = "时间：" & (i / 10) & " 秒钟"
        Else
            Timer1.Enabled = False
            Application.Exit()

            ' MessageBox.Show("完成！")
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class