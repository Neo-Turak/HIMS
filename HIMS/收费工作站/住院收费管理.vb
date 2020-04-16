Public Class 住院收费管理
    Private 患者编号 As String
    Private Sub 住院收费管理_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView1.DataSource = DbaseHelper.Get_住院单().Tables(0).DefaultView()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        患者编号 = DataGridView1.Rows(e.RowIndex).Cells("患者编号").Value.ToString()
        DataGridView2.DataSource = DbaseHelper.Get_收费记录(患者编号).Tables(0).DefaultView()
    End Sub

    Private Sub TB_金额_LostFocus(sender As Object, e As EventArgs) Handles TB_金额.LostFocus
        Dim 金额 As Single = Single.Parse(TB_金额.Text)
        TB_金额.Text = String.Format("{0:C}", 金额)
    End Sub
End Class