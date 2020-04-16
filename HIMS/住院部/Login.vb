Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Global_sub.圆角窗体(Me)
        'Global_sub.圆角按钮(B_登录)
    End Sub

    Private Sub B_退出_Click(sender As Object, e As EventArgs) Handles B_退出.Click
        Application.Exit()
    End Sub

    Private Sub B_登录_Click(sender As Object, e As EventArgs) Handles B_登录.Click
        Dim result As String() = DbaseHelper.检验用户(Trim(TB_用户名.Text), Trim(TB_密码.Text))
        L_姓名.Text = result(0)
        L_部门.Text = result(1)
        L_职位.Text = result(2)
        If (L_部门.Text = "内科" Or L_部门.Text = "外科") And (L_职位.Text = "医生" Or L_职位.Text = "护士") Then
            Me.Hide()
            住院医生工作站.Show()
            住院医生工作站.TSSL_医生.Text = L_姓名.Text
            住院医生工作站.TSSL_科室.Text = L_职位.Text

        Else
            Message("请使用有关的客户端", 1, "登录错误")
            clear()
            TB_用户名.Select()
        End If
    End Sub
    Private Sub clear()
        L_职位.Text = ""
        L_部门.Text = ""
        L_姓名.Text = ""
        TB_密码.Text = ""
        TB_用户名.Text = ""
    End Sub
End Class