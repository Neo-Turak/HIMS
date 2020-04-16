Imports System.Drawing.Printing

Public Class 医嘱浏览
    Private Sub 医嘱浏览_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.PageSettings.PaperSize = New Printing.PaperSize("住院单", 7.16, 10.12)
        Dim f As Font = New Font("楷体", 10)
        Dim B As SolidBrush = New SolidBrush(Color.Black)
        ' Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
        e.Graphics.DrawImage(PictureBox1.Image, 50, -20)
        For c As Int16 = 0 To 700 Step 25
            e.Graphics.DrawString(c / 25, New Font("宋体", 12), B, c, 0)
        Next
        For d As Int16 = 0 To 1100 Step 25
            e.Graphics.DrawString(d / 25, New Font("宋体", 12), B, 0, d)
        Next
        e.HasMorePages = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New PrintDocument
        AddHandler p.PrintPage, AddressOf PrintDocument1_PrintPage
        p.Print()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim b As SolidBrush
        b = New SolidBrush(Color.Black)
        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
            For c As Int16 = 0 To 2000 Step 100
                g.DrawString(c / 100, New Font("宋体", 12), b, c, 100)
            Next
            For d As Int16 = 0 To 3000 Step 100
                g.DrawString(d / 100, New Font("宋体", 12), b, 100, d)
            Next
        End Using
    End Sub
End Class