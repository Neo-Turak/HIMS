'written by:Nura
Imports System.ComponentModel

Public Class MDIForm

    Private Sub MDIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' SkinH_AttachEx("E:\dll\skins\china.she", "yes")
        ' SkinH_SetAero("OK")
        DownMenu_科室.Text = var_部门
        DownMenu_医生.Text = var_就诊医生

    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        '  SkinH_DetachEx("E:\dll\skins\whitefire.she")
        If vbYes = MessageBox.Show("确定要退出吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Application.Exit()
            Dispose(True)
            GC.SuppressFinalize(Me)
            GC.Collect()
        Else

        End If
    End Sub

    Private Sub 就诊ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 就诊ToolStripMenuItem.Click
        Dim 门诊医生工作站 As New 门诊医生工作站 With {
            .MdiParent = Me
        }
        门诊医生工作站.Show()

    End Sub

    Private Sub MDIForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim result As DialogResult
        result = MessageBox.Show(Me, "确定要退出本系统吗?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Application.Exit()
            GC.Collect()
        Else

        End If
    End Sub

    Private Sub 发药ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发药ToolStripMenuItem.Click
        Dim c As New 档案查询 With {
            .MdiParent = Me
        }
        c.Show()
    End Sub

    Private Sub 挂号单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 挂号单ToolStripMenuItem.Click
        Dim 挂号单 As New 挂号单 With {
            .MdiParent = Me
        }
        挂号单.Show()

    End Sub

    Private Sub 编号查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 编号查询ToolStripMenuItem.Click
        Dim d As New 编码转换 With {
            .MdiParent = Me
        }
        d.Show()
    End Sub

    Private Sub 入院单名单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 入院单名单ToolStripMenuItem.Click
        Dim d As New 预入院单名单 With {
        .MdiParent = Me
        }
        d.Show()
    End Sub

End Class