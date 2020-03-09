Public Class Global_sub
    Public Const 皮肤路径 As String = "C:\Users\Hugo\Desktop\skins\skins\"

    Public Function 数字(sender As Object, e As EventArgs) As Boolean
        If (System.Text.RegularExpressions.Regex.IsMatch(TryCast(sender, String), "  ^ [0-9]")) Then '这里判定是否数字.
            Return True
        Else
            Return False
        End If
    End Function

End Class