'written by:Nura
Imports System.ComponentModel

Public Class 主窗体

    Private Sub MDIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinH_AttachEx("\skins\skins\china.she", "yes")
        SkinH_SetAero("OK")
        DownMenu_科室.Text = var_部门
        DownMenu_医生.Text = var_就诊医生
        TSPB_服务器状态.Value = DbaseHelper.Get_客户端连接数
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        'SkinH_DetachEx("skins\whitefire.she")
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

    Private Sub 屏保ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 屏保ToolStripMenuItem.Click
        Dim d As New 屏保 With {
      .MdiParent = Me
      }
        d.Show()
    End Sub

    Private Sub TSPB_服务器状态_Click(sender As Object, e As EventArgs) Handles TSPB_服务器状态.Click
        Message(Me.TSPB_服务器状态.ToolTipText, 1, "当前连接数")
    End Sub

    Private Sub 今日挂号单总表_Click(sender As Object, e As EventArgs) Handles 今日挂号单总表.Click
        今日挂号报表.Show()
    End Sub
End Class