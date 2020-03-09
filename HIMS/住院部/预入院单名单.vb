'written by:Nura
Public Class 预入院单名单

    Private Sub Btn_更新_Click(sender As Object, e As EventArgs) Handles Btn_更新.Click
        DataGridView1.DataSource = vbNull
        DataGridView1.DataSource = DbaseHelper.Get_住院单_待就诊().Tables(0).DefaultView

    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
    End Sub

    Private Sub Btn_删除_Click(sender As Object, e As EventArgs) Handles btn_删除.Click
        Try
            If DataGridView1.CurrentRow.Selected Then
                DbaseHelper.Del_住院单(DataGridView1.SelectedRows(0).Cells("ID").Value, DataGridView1.SelectedRows(0).Cells("患者编号").Value.ToString)
                Message("删除1条记录成功！"， 3， "删除记录")
                Btn_更新_Click(sender, New EventArgs)
            End If
        Catch ex As Exception
            Message("出现错误：" & ex.Message, 4, "错误")
        End Try
    End Sub

    Private Sub 预入院单名单_Load(sender As Object, e As EventArgs) Handles Me.Load
        Btn_更新_Click(sender, New EventArgs)
    End Sub

    Private Sub Btn_退出_Click(sender As Object, e As EventArgs) Handles Btn_退出.Click
        End
    End Sub

End Class