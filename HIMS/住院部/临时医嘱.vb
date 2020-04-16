Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class 临时医嘱
    Public gsub As Global_sub

    Private Sub 临时医嘱_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Ds As List(Of String)
        Ds = Get_检查科室()
        CB_检查科室.Items.Add(Ds) '加检查科室清单
        NUD_到_子项.Value = 4
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TB_从_子项.TextChanged, TB_到_子项.TextChanged
        '   If (gsub.数字(sender, e) = False) Then
        '  TB_从_子项.Text = ""
        '  End If
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

        sqlcon = ConStr

        If (RB_已执行.Checked = True And RB_本次遗嘱.Checked = True) Then
            con = New SqlConnection(sqlcon)
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

    Private Sub B_打印_Click(sender As Object, e As EventArgs) Handles B_打印.Click
        Dim p As New PrintDocument
        Dim s As PaperSize = New PaperSize("B5Transverse", 716, 1012) '3.9   
        p.DefaultPageSettings.PaperSize = s
        AddHandler p.PrintPage, AddressOf PD_打印_PrintPage
        p.Print()
    End Sub

    Private Sub PD_打印_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD_打印.PrintPage
        Dim ks As Integer = NUD_从_子项.Value
        Dim js As Integer = NUD_到_子项.Value
        Dim q As Int16 = 4
        Dim kw As Integer = Integer.Parse(TB_从_子项.Text)
        Dim jw As Integer = Integer.Parse(TB_到_子项.Text)
        Dim counter As Int16 = 0
        Dim img As Image = Image.FromFile("Resources\临时医嘱单.jpg") 'Bug 调试

        '定义打印参数
        Dim font As Font = New Font("楷体", 12)
        Dim b As Brush = Brushes.Black

        'For xh = 2 To ks
        '    DGV_存单.Rows(counter).Selected = True '移动数据到下一行
        counter += 1 '计行

        If CB_新页打印.Checked Then
            e.Graphics.DrawImage(img, 0, 0)
            e.Graphics.DrawString(TB_姓名.Text, font, b, 25, 36)
            e.Graphics.DrawString(TB_性别.Text, font, b, 63, 36)
            e.Graphics.DrawString(TB_年龄.Text, font, b, 80, 36)
            e.Graphics.DrawString(TB_住院号.Text, font, b, 110, 36)
            e.Graphics.DrawString(TB_床号.Text, font, b, 60, 115)
        End If
        ' Next


        e.HasMorePages = False

    End Sub
End Class