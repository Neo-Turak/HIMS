Imports Microsoft.Reporting.WinForms

Public Class 今日住院报表
    Private Sub 今日住院报表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds1, ds2, ds3 As ReportDataSource
        ds1 = New ReportDataSource("今日住院报表_DataSet", Get_挂号单详情().Tables(0))
        ds2 = New ReportDataSource("今日住院报表_男_女_DataSet", Get_挂号单详情_男_女.Tables(0))
        ds3 = New ReportDataSource("今日住院报表_结算方式_DataSet", Get_挂号单详情_结算方式.Tables(0))

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        '如果出现报表没有初始化操作,使用下面的动态绑定或在属性里绑定。
        'Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("\..\..\今日挂号报表.rdlc"))
        Me.ReportViewer1.LocalReport.DataSources.Add(ds1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ds2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ds3)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 80
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
    End Sub

    Private Sub ReportViewer1_Resize(sender As Object, e As EventArgs) Handles ReportViewer1.Resize

    End Sub
End Class