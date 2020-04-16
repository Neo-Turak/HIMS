<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 报表浏览
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HIMS.Reporter.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Padding = New System.Windows.Forms.Padding(1)
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(782, 812)
        Me.ReportViewer1.TabIndex = 0
        '
        '报表浏览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(782, 812)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "报表浏览"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "报表浏览"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
