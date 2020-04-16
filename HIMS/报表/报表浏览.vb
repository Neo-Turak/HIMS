Imports Microsoft.Reporting.WinForms

Public Class 报表浏览
    Public 患者姓名, 性别, 年龄, 结算方式, 地址, 诊断, 检查项目, 规格, 价格, 自费金额, 自费总金额, 划价员, 申请科室, 申请医师, 收费员, 申请时间 As ReportParameter

    Private Sub 报表浏览_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        Dim rsource As ReportDataSource
        rsource = New ReportDataSource("DataSet1", Get_检查单("10760CCD43").Tables(0))
        ' Dim size As Printing.PaperSize = New Printing.PaperSize
        ' size.RawKind = Printing.PaperKind.B5
        'Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("\..\..\处方.rdlc"))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rsource)
        '患者姓名.Name = "患者姓名"
        '患者姓名.Values.Add("努尔江")
        '患者姓名.Values.Add("hello World")
        Me.ReportViewer1.LocalReport.SetParameters(Me.患者姓名)
        Me.ReportViewer1.LocalReport.SetParameters(Me.性别)
        Me.ReportViewer1.LocalReport.SetParameters(Me.年龄)
        Me.ReportViewer1.LocalReport.SetParameters(Me.结算方式)
        Me.ReportViewer1.LocalReport.SetParameters(Me.地址)
        Me.ReportViewer1.LocalReport.SetParameters(Me.诊断)
        Me.ReportViewer1.LocalReport.SetParameters(Me.检查项目)
        Me.ReportViewer1.LocalReport.SetParameters(Me.规格)
        Me.ReportViewer1.LocalReport.SetParameters(Me.价格)
        Me.ReportViewer1.LocalReport.SetParameters(Me.自费金额)
        Me.ReportViewer1.LocalReport.SetParameters(Me.自费总金额)
        Me.ReportViewer1.LocalReport.SetParameters(Me.划价员)
        Me.ReportViewer1.LocalReport.SetParameters(Me.申请科室)
        Me.ReportViewer1.LocalReport.SetParameters(Me.申请医师)
        Me.ReportViewer1.LocalReport.SetParameters(Me.收费员)
        Me.ReportViewer1.LocalReport.SetParameters(Me.申请时间)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Init()

        患者姓名 = New ReportParameter()
        性别 = New ReportParameter()
        年龄 = New ReportParameter()
        结算方式 = New ReportParameter()
        地址 = New ReportParameter()
        诊断 = New ReportParameter()
        检查项目 = New ReportParameter()
        规格 = New ReportParameter()
        价格 = New ReportParameter()
        自费金额 = New ReportParameter()
        自费总金额 = New ReportParameter()
        划价员 = New ReportParameter()
        申请科室 = New ReportParameter()
        申请医师 = New ReportParameter()
        收费员 = New ReportParameter()
        申请时间 = New ReportParameter()
    End Sub

End Class