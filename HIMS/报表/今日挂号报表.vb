Imports Microsoft.Reporting.WinForms

Public Class 今日挂号报表
    Private Sub 今日挂号报表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds1, ds2 As ReportDataSource
        ds1 = New ReportDataSource("今日挂号单_dataset", DbaseHelper.Get_挂号单详情().Tables(0))
        ds2 = New ReportDataSource("今日挂号单_男_女_DataSet", DbaseHelper.Get_挂号单详情_男_女.Tables(0))


        Me.ReportViewer1.LocalReport.DataSources.Clear()
        'Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("\..\..\今日挂号报表.rdlc"))
        Me.ReportViewer1.LocalReport.DataSources.Add(ds1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ds2)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class