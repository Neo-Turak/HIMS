Public Class 诊断参考管理

    Private Sub 诊断参考管理_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView1.DataSource = DbaseHelper.Get_门诊病历模板.Tables(0).DefaultView
        RichTextBox1.DataBindings.Add(New Binding("Text", DataGridView1.DataSource, "诊断"))
        RichTextBox2.DataBindings.Add(New Binding("Text", DataGridView1.DataSource, "主诉"))
        Label1.DataBindings.Add(New Binding("Text", DataGridView1.DataSource, "ID"))
        DataGridView1.SelectionMode = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DbaseHelper.Update_门诊病历模板(Label1.Text, RichTextBox1.Text.Trim, RichTextBox2.Text.Trim)
        DataGridView1.DataSource = DbaseHelper.Get_门诊病历模板.Tables(0).DefaultView
        DataGridView1.Refresh()
        MsgBox("更新成功！")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DbaseHelper.Add_门诊病历模板(RichTextBox1.Text.Trim, RichTextBox2.Text.Trim, "")
        MessageBox.Show("已添加")
        DataGridView1.DataSource = DbaseHelper.Get_门诊病历模板.Tables(0).DefaultView
        DataGridView1.Refresh()
        Dim c As Int32 = DataGridView1.Rows.Count - 1
        DataGridView1.CurrentCell = DataGridView1.Rows(c).Cells(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            DbaseHelper.Delete_门诊病历模板(Label1.Text)
            DataGridView1.DataSource = DbaseHelper.Get_门诊病历模板.Tables(0).DefaultView
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class