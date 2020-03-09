'written by:Nura

Imports System.Text
Imports System.Runtime.InteropServices

Module 模块
    Public var_参合号 As String
    Public var_患者姓名 As String
    Public var_年龄 As String
    Public var_性别 As String
    Public var_结算方式 As String
    Public var_就诊医生 As String
    Public var_医生职务 As String
    Public var_部门 As String

    Public Declare Function Message Lib "skins\UI.dll" (ByVal msgcontext As String, ByVal msgicon As Int32, ByVal title As String) As Long
    '1 red alert
    '2 information
    '3 question
    '4 timer]
    '5 null
    '6 null
    '16 null
    Public Declare Function SkinH_AttachEx Lib "skins\SkinH_Vb6.dll" (ByVal lpSkinFile As String, ByVal lpPasswd As String) As Long
    '
    '下面是另一种引用Lib DLL的方法.效果同上
    '
    <DllImport("skins\SkinH_VB6.dll")> Function SkinH_SetAero(ByVal msg_context As String) As Long

    End Function
    Public Function Md5FromString(ByVal Source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()

        'Check for empty string.
        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If

        'Get bytes from string.
        Bytes = Encoding.Default.GetBytes(Source)

        'Get md5 hash
        Bytes = Security.Cryptography.MD5.Create().ComputeHash(Bytes)
        'Loop though the byte array and convert each byte to hex.
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next

        'Return md5 hash.
        Return sb.ToString()

    End Function

    Public Function AlreadyRunning() As Boolean
        ' Get our process name.
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName

        ' Get information about processes with this name.
        Dim procs() As Process =
            Process.GetProcessesByName(my_name)

        ' If there is only one, it's us.
        If procs.Length = 1 Then Return False

        ' If there is more than one process,
        ' see if one has a StartTime before ours.
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
                Return True
        Next i

        ' If we get here, we were first.
        Return False
    End Function

End Module