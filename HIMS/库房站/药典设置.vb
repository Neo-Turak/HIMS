Option Explicit Off
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class 药典设置
    Private Const w = 814
    Private adapter As SqlDataAdapter
    Private Sub 药典设置_Load(sender As Object, e As EventArgs) Handles Me.Load
        DbaseHelper.Get_药典.Fill(DataGridView1.DataSource)
        TB_药品类别.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "药品类别"))
        TB_药品规格.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "药库规格"))
        TB_通用名.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "通用名"))
        TB_流水号.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "流水号"))
        TB_速记码.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "速记码"))
        RTB_生产企业.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "生产企业_总代理商"))
        TB_剂型.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "剂型"))
        TB_采购价.DataBindings.Add(New Binding("text", DataGridView1.DataSource, "采购价"))

    End Sub

    Private Sub 药典设置_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 271
    End Sub

    Private Sub B_删除_Click(sender As Object, e As EventArgs) Handles B_删除.Click
        Try
            d = DataGridView1.SelectedCells("ID").Value
            DbaseHelper.Del_药典(d)
        Catch ex As Exception
            MessageBox.Show("出现错误:" + ex.Message, "错误")
        End Try
    End Sub

    Private Sub B_添加_Click(sender As Object, e As EventArgs) Handles B_添加.Click
        Try
            DbaseHelper.Add_药典(TB_流水号.Text, TB_通用名.Text, TB_药品类别.Text, TB_速记码.Text, RTB_生产企业.Text, TB_药品规格.Text, TB_剂型.Text, TB_采购价.Text)
        Catch ex As Exception
            MessageBox.Show("出现错误:" + ex.Message, "错误")
        End Try
    End Sub

    Private Sub B_自动整理_Click(sender As Object, e As EventArgs) Handles B_自动整理.Click
        Dim a As Integer
        a = DataGridView1.Rows.Count
        DataGridView1.Rows(0).Selected = True
        For c As Integer = 0 To a
            DataGridView1.SelectedCells("速记码").Value = 汉字to拼音(DataGridView1.SelectedCells("通用名").Value)
            DataGridView1.Rows(c).Selected = True
            Threading.Thread.Sleep(500)
        Next
        DataGridView1.SelectedRows.Clear()
    End Sub
End Class