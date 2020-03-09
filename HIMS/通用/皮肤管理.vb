Imports System.IO
Imports Sunisoft.IrisSkin.SkinEngine
Public Class 皮肤管理
    Dim SE As New Sunisoft.IrisSkin.SkinEngine
    Dim Skins As List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SE.SkinFile = Skins(ListBox1.SelectedIndex)
        SE.Active = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SE.Active = False
    End Sub

    Private Sub Skins_Load(sender As Object, e As EventArgs) Handles Me.Load, Me.Activated, Button3.Click
        If (ListBox1.Items.Count > 0) Then
        Else
            Try
                Skins = Directory.GetFiles(Global_sub.皮肤路径, "*.ssk").ToList()
                Console.WriteLine(Skins)
                For Each x In Skins
                    ListBox1.Items.Add(CStr(Path.GetFileNameWithoutExtension(x)))
                Next
            Catch msg As Exception
                MessageBox.Show(msg.Message)
            End Try
        End If
    End Sub

End Class