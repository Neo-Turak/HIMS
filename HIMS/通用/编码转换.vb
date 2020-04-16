'written by:Nura
Public Class 编码转换

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Or TextBox2.Text <> "" Then
            If TextBox1.Text = "" Then
                TextBox1.Text = "0" & Convert.ToInt64(TextBox2.Text, 16)
            ElseIf TextBox2.Text = "" Then
                TextBox2.Text = Hex(TextBox1.Text)
            End If
        Else
            Message("请输入患者编码或者合作医疗证号", 3, "空值错误！")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class