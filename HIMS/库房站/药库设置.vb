Public Class 药库设置

    Private Sub 药库设置_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error GoTo 0
        DataGridView1.DataSource = DbaseHelper.Get_药库资料.Tables(0).DefaultView()
        TB_编号.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "编号"))
        TB_名称.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "名称"))
        TB_位置.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "位置"))
        TB_备注.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "备注"))

        Exit Sub
0:
        MessageBox.Show("出现错误：\n" + Err.GetException.Message.ToString() + "\n 在药库设置_Load 事件中", "错误", 0, MessageBoxIcon.Error)
        Resume Next
    End Sub

End Class