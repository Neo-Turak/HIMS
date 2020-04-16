'written by:Nura
Imports System.Threading
Public Class 挂号列表

    Private Sub 挂号单_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaximizeBox = False
        MinimizeBox = False
        WindowState = FormWindowState.Normal
        DataGridView1.DataSource = Get_挂号单详情.Tables(0).AsDataView

        'Dim modif As Integer = 0
        'Do Until DataGridView1.Controls.OfType(Of HScrollBar).First.Visible = False
        '    Size = New Size(300 + modif, 300)
        '    modif += 20
        '    Console.WriteLine(modif)
        'Loop
        'Me.Refresh()

    End Sub

End Class