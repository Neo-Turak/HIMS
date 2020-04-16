Public Class 就诊记录查询
    Private Sub BTN_查询_Click(sender As Object, e As EventArgs) Handles BTN_查询.Click
        'On Error Resume Next '不处理错误
        DataGridView1.DataSource = DbaseHelper.Get_住院病历(Trim(TextBox1.Text)).Tables(0).DefaultView
        Dim result() = DbaseHelper.Get_患者信息(TB_患者编号.Text)
        LBL_患者信息.Text = result(0) + "   " + result(1) + "    " + result(2)

    End Sub
End Class