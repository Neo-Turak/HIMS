Public Class 住院医生工作站


    Private Sub 住院医生工作站_Load(sender As Object, e As EventArgs) Handles Me.Load
        TSSL_时间.Text = DateTime.Now()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TSSL_时间.Text = DateTime.Now()
    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class