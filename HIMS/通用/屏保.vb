Public Class 屏保

    Private Sub 屏保_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.DateTime.Text = DateAndTime.Now().ToString()
    End Sub

    Private Sub DateTime_Click(sender As Object, e As EventArgs) Handles DateTime.Click
        Me.Close()
    End Sub

End Class