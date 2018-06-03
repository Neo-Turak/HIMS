'written by:Nura
Imports System.Data.SqlClient

Public Class 挂号

    'Public Shared var_参合号 As String
    'Public Shared var_患者姓名 As String
    'Public Shared var_年龄 As String
    'Public Shared var_性别 As String
    'Public Shared var_结算方式 As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_添加档案.Click
        Dim child As New 新增档案 With {
            .MdiParent = MDIForm
        }
        child.Show()
        child.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Btn_查询_Click(sender As Object, e As EventArgs) Handles Btn_查询.Click
        If TB_查询内容.Text = "" Or CB_查询条件.Text = "查询条件" Then

            Message("请输入查询内容和选择查询条件"， 1， “缺少条件”)
            TB_查询内容.Select()
            Btn_就诊.Enabled = False
        Else
            Try
                Using cn As New SqlConnection(ConStr)
                    cn.Open()
                    Using cmd As New SqlCommand("select * from 患者总表 where " + CB_查询条件.Text + " like '%" + TB_查询内容.Text + "%'", cn)
                        cmd.ExecuteNonQuery()
                        ' Console.WriteLine(cmd.CommandText.ToString)
                        Using tb As New SqlDataAdapter
                            tb.SelectCommand = cmd
                            Dim table As New DataTable("患者总表")
                            tb.Fill(table)
                            DataGridView1.DataSource = table.DefaultView
                            DataGridView1.AllowUserToAddRows = False
                            DataGridView1.AllowUserToDeleteRows = False
                        End Using
                    End Using
                End Using
            Catch ex As SqlException
                MessageBox.Show("数据处理错误！" + ex.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

            End Try

            Try
                If DataGridView1.Rows.Count >= 1 Then
                    Lbl_合作医疗证号.DataBindings.Add("text", DataGridView1.DataSource, "合作医疗号")
                    Lbl_患者姓名.DataBindings.Add("text", DataGridView1.DataSource, "患者姓名")
                    Lbl_年龄.DataBindings.Add("text", DataGridView1.DataSource, "年龄")
                    Lbl_性别.DataBindings.Add("text", DataGridView1.DataSource, "性别")
                    CB_结算方式.DataBindings.Add("text", DataGridView1.DataSource, "结算方式")
                End If
            Catch ex As System.ArgumentException
                MessageBox.Show("出现异常！" + ex.Message.ToString, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged
        If DataGridView1.Rows.Count = 2 Then
            Lbl_合作医疗证号.Text = DataGridView1.Rows(0).Cells(1).Value.ToString
            Lbl_患者姓名.Text = DataGridView1.Rows(0).Cells(2).Value.ToString
            Lbl_年龄.Text = DataGridView1.Rows(0).Cells(6).Value.ToString
            Lbl_性别.Text = DataGridView1.Rows(0).Cells(4).Value.ToString
            CB_结算方式.Text = "合作医疗"
            Btn_查询.Select()
        End If

    End Sub

    Private Sub CB_查询条件_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_查询条件.SelectedIndexChanged
        If Not Me.CB_查询条件.Text = "查询条件" Then
            TB_查询内容.Enabled = True

        End If
    End Sub

    Private Sub Lbl_患者姓名_TextChanged(sender As Object, e As EventArgs) Handles Lbl_患者姓名.TextChanged

        Btn_就诊.Enabled = True

    End Sub

    Private Sub Btn_就诊_Click(sender As Object, e As EventArgs) Handles Btn_就诊.Click

        var_参合号 = Lbl_合作医疗证号.Text
        var_年龄 = Lbl_年龄.Text
        var_性别 = Lbl_性别.Text
        var_患者姓名 = Lbl_患者姓名.Text
        var_结算方式 = CB_结算方式.Text
        Me.Close()
        'HIMS.门诊医生工作站.Activate()
        ' HIMS.门诊医生工作站.WindowState = FormWindowState.Maximized
        GC.Collect()
    End Sub

    Private Sub 挂号_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.DataSource = DbaseHelper.Get_挂号单详情.Tables(0).DefaultView
        ' DataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Lbl_合作医疗证号.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        Lbl_患者姓名.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        Lbl_年龄.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
        Lbl_性别.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
        CB_结算方式.Text = "合作医疗"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DbaseHelper.Add_挂号单(Hex(Lbl_合作医疗证号.Text), CB_结算方式.Text, "待诊断")
        Message("添加到每日挂号单成功！", 2, "消息")
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Lbl_合作医疗证号.Text = DataGridView2.SelectedRows(0).Cells(2).Value.ToString
        Lbl_患者姓名.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString
        Lbl_年龄.Text = DataGridView2.SelectedRows(0).Cells(4).Value.ToString
        Lbl_性别.Text = DataGridView2.SelectedRows(0).Cells(3).Value.ToString
        CB_结算方式.Text = DataGridView2.SelectedRows(0).Cells(5).Value.ToString
    End Sub

End Class