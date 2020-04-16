Public Class 密码修改

    Private Sub B_确定_Click(Sender As Object, e As EventArgs) Handles B_确定.Click
        If 密码验证(Trim(TextBox1.Text), Trim(TB_当前密码.Text)) Then
            If Trim(TB_新密码.Text) = Trim(TB_密码重复.Text) Then
                MessageBox.Show("新密码两次输入不匹配，重新输入", "错误")
                TB_密码重复.Text = ""
                TB_新密码.Text = ""
            Else
                Update_密码(TextBox1.Text, Trim(TB_新密码.Text))
                MessageBox.Show("更新密码成功！", "成功")
                Application.Exit()
            End If
        Else
            MessageBox.Show("密码错误，请重新输入", "错误")
            TextBox1.Text = ""
        End If
    End Sub
End Class