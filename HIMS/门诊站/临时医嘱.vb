Imports System.Data.SqlClient

Public Class 临时医嘱

    Public gsub As Global_sub
    Private Sub 临时医嘱_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Ds As List(Of String)
        Ds = DbaseHelper.Get_检查科室()
        CB_检查科室.Items.Add(Ds) '加检查科室清单
        LB_到_子项.SelectedValue = 4

    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TB_从_子项.TextChanged, TB_到_子项.TextChanged
        If (gsub.数字(sender, e) = False) Then
            TB_从_子项.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_分类.KeyPress
        On Error Resume Next

        If Keys.KeyCode = Keys.Enter And CB_分类.Text = "药品" Then
            TB_助记码.Select()
        End If

        If Keys.KeyCode = Keys.Enter And CB_分类.Text = "检查项目" Then
            CB_检查科室.Visible = True
            CB_检查科室.Select()
        End If
    End Sub

    Private Sub ComboBox1_LostFocus(sender As Object, e As EventArgs) Handles CB_分类.LostFocus
        On Error Resume Next

        If CB_分类.Text = "药品" Then
            CB_检查科室.Visible = True
            DGV_药品库.Visible = True
            DGV_项目库.Visible = False
            L_数量.Visible = True
            TB_数量.Visible = True
            CB_标志.Visible = False
            CB_检查科室.Visible = False
            CB_用法.Visible = True
            L_库存S.Visible = True
            L_库存.Visible = True
            L_金额S.Visible = True
            TB_助记码.Select()

        End If

        If CB_分类.Text = "检查项目" Then
            DGV_项目库.Visible = True
            DGV_药品库.Visible = False
            L_数量.Visible = False
            TB_数量.Visible = False
            CB_检查科室.Visible = True
            L_库存S.Visible = False
            L_库存.Visible = False
            CB_标志.Visible = False
            CB_用法.Visible = False

            CB_检查科室.Select()
            L_金额S.Visible = False
            L_金额.Visible = False

        End If
    End Sub

    Private Sub CB_标志_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_标志.KeyPress
        On Error Resume Next
        If Keys.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub CB_用法_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_用法.KeyPress
        On Error Resume Next
        If Keys.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub


    Private Sub B_查询_Click(sender As Object, e As EventArgs) Handles B_查询.Click
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim sqlcon As String

        sqlcon = DbaseHelper.ConStr

        If (RB_已执行.Checked = True And RB_本次遗嘱.Checked = True) Then
            con = New SqlClient.SqlConnection(sqlcon)
            con.Open()

            cmd = New SqlCommand("select * from 临时遗嘱 where 姓名=@姓名  and 住院号=@住院号 and 状态='完成'  order by 遗嘱日期,遗嘱时间", con)
            Dim 姓名 As New SqlParameter("@姓名", SqlDbType.Text)
            Dim 住院号 As New SqlParameter("@住院号", SqlDbType.Text)

            姓名.Value = Trim(TB_姓名.Text)
            住院号.Value = Trim(TB_住院号.Text)

            cmd.Parameters.Add(姓名)
            cmd.Parameters.Add(住院号)

            reader = cmd.ExecuteReader()
            reader.Read()
            ' 
            DGV_存单.DataSource = reader
            DGV_存单.Refresh()

            con.Close()
            reader.Close()
        End If
    End Sub
End Class