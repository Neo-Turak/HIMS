'written by:Nura
Public Class 挂号单

    Private Sub 挂号单_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.WindowState = FormWindowState.Normal
        Me.DataGridView1.DataSource = DbaseHelper.Get_挂号单详情.Tables(0).AsDataView
    End Sub

End Class