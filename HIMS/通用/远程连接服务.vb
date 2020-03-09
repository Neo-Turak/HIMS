Imports AxMSTSCLib
Imports MSTSCLib

Public Class 远程连接服务
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rdp As AxMSTSCLib.AxMsRdpClient2
        rdp = New AxMsRdpClient2
        rdp.Server = txtServer.Text
        rdp.UserName = TxtUserName.Text
        Dim secured As IMsTscNonScriptable = CType(rdp.GetOcx(), IMsTscNonScriptable)
        secured.ClearTextPassword = TxtUserName.Text
        rdp.Connect()
    End Sub
End Class