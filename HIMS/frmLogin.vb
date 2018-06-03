'written by:Nura
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Sql

Public Class FrmLogin
    'SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory)

    Public pwd As String

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AlreadyRunning() Then
            MessageBox.Show("Another instance is already running.", "Already Running", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        Else
            TB_ID.Select()
        End If
    End Sub

    Private Sub FrmLogin_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        TB_ID.BackColor = Color.FromArgb(19, 108, 152)
        TB_ID.Parent = Me
        MTB_pwd.BackColor = Color.FromArgb(19, 108, 152)
        ' SkinH_SetAero("YES")

    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        If pwd = MTB_pwd.Text Then
            var_就诊医生 = lblname.Text
            var_医生职务 = lbl_职务.Text
            var_部门 = lbl_部门.Text
            Me.Hide()
            GC.Collect()
            MDIForm.Show()

        End If

    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Message("确定要退出吗？", 3, "警告")
        Application.Exit()
        '1 red alert
        '2 information
        '3 question
        '4 timer]
        '5 null
        '6 null
        '16 null
        'Application.Exit()
    End Sub

    Private Sub TB_ID_Leave(sender As Object, e As EventArgs) Handles TB_ID.Leave
        If TB_ID.Text = "" Then
        Else
            lblname.Text = DbaseHelper.CheckID(TB_ID.Text).Item(0)
            pwd = DbaseHelper.CheckID(TB_ID.Text).Item(1)
            lbl_部门.Text = DbaseHelper.CheckID(TB_ID.Text).Item(2)
            lbl_职务.Text = DbaseHelper.CheckID(TB_ID.Text).Item(3)
        End If

    End Sub

    Private Sub TB_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            MTB_pwd.Select()

        End If
    End Sub

End Class