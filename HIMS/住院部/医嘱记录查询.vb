Public Class 医嘱记录查询

    Private Sub 医嘱记录查询_Load(Sender As Object, e As EventArgs) Handles Me.Load

        DataGridView1.DataSource = DbaseHelper.Get_已执行医嘱.Tables(0).DefaultView()

    End Sub

End Class