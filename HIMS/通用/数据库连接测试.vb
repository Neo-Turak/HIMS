
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class 数据库连接测试

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim provider As String = Trim(TextBox1.Text)
        Dim UID As String = Trim(TextBox2.Text)
        Dim PWD As String = Trim(TextBox3.Text)
        Dim server As String = Trim(TextBox4.Text)
        Dim database As String = Trim(TextBox5.Text)
        Try
            Dim constr As String = "PROVIDER=" & provider & ";UID=" & UID & ";PWD=" & PWD & ";database=" & database & ";SERVER=" & server & ";"
            Dim oledbcon As OleDbConnection
            oledbcon = New OleDbConnection(constr)
            oledbcon.Open()
            If oledbcon.State = 1 Then
                MessageBox.Show("连接成功!", "结果")
            Else
                MessageBox.Show(oledbcon.State, "结果")
            End If
            'state 的值如下:
            ' Broken  16  The connection to the data source Is broken.
            'Closed  0   The connection Is Closed.
            'Connecting  2    The connection object Is connecting to the data source.
            'Executing   4    The connection object Is executing a command. (This value Is reserved for future versions of the product.)
            'Fetching    8   The connection object Is retrieving data. (This value Is reserved for future versions of the product.)
            'Open    1       The connection Is open.
            oledbcon.Close()
        Catch Ex As OleDbException
            MessageBox.Show(Ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub 数据库连接测试_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2) - ((登录.Size.Width / 2) + 25), (Screen.PrimaryScreen.Bounds.Height / 2) + ((登录.Size.Height / 2) - 20))

    End Sub
End Class
