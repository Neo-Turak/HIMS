'Imports System.Runtime.InteropServices
Public Class 屏保
    '<DllImport("user32.dll", SetLastError:=True)>
    'Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As SetWindowPosFlags) As Boolean
    'End Function
    'Private ReadOnly HWND_BOTTOM As New IntPtr(1)
    'Private ReadOnly HWND_NOTOPMOST As New IntPtr(-2)
    'Private ReadOnly HWND_TOP As New IntPtr(0)
    'Private ReadOnly HWND_TOPMOST As New IntPtr(-1)

    Private Sub 屏保_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DateTime.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - 1000
        Me.DateTime.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - 2800
        主窗体.Hide()
        Me.TopMost = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.DateTime.Text = Now().ToString()
    End Sub

    Private Sub DateTime_Click(sender As Object, e As EventArgs) Handles DateTime.Click
        Me.Close()
    End Sub

    Private Sub 屏保_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        主窗体.Visible = True
    End Sub
End Class