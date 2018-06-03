<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_部门 = New System.Windows.Forms.Label()
        Me.lbl_职务 = New System.Windows.Forms.Label()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.MTB_pwd = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Microsoft JhengHei", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.Location = New System.Drawing.Point(157, 119)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(161, 20)
        Me.lblname.TabIndex = 2
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(109, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "医院智能管理系统"
        '
        'Btn_OK
        '
        Me.Btn_OK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Btn_OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_OK.Location = New System.Drawing.Point(86, 243)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(86, 36)
        Me.Btn_OK.TabIndex = 5
        Me.Btn_OK.Text = "确定"
        Me.Btn_OK.UseVisualStyleBackColor = false
        '
        'Btn_Exit
        '
        Me.Btn_Exit.AutoEllipsis = true
        Me.Btn_Exit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Exit.Location = New System.Drawing.Point(241, 243)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(86, 36)
        Me.Btn_Exit.TabIndex = 6
        Me.Btn_Exit.Text = "退出"
        Me.Btn_Exit.UseVisualStyleBackColor = false
        '
        'lbl_部门
        '
        Me.lbl_部门.BackColor = System.Drawing.Color.Transparent
        Me.lbl_部门.Font = New System.Drawing.Font("Microsoft JhengHei", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.lbl_部门.ForeColor = System.Drawing.Color.Black
        Me.lbl_部门.Location = New System.Drawing.Point(93, 188)
        Me.lbl_部门.Name = "lbl_部门"
        Me.lbl_部门.Size = New System.Drawing.Size(90, 30)
        Me.lbl_部门.TabIndex = 7
        Me.lbl_部门.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_职务
        '
        Me.lbl_职务.BackColor = System.Drawing.Color.Transparent
        Me.lbl_职务.Font = New System.Drawing.Font("Microsoft JhengHei", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.lbl_职务.ForeColor = System.Drawing.Color.Black
        Me.lbl_职务.Location = New System.Drawing.Point(212, 188)
        Me.lbl_职务.Name = "lbl_职务"
        Me.lbl_职务.Size = New System.Drawing.Size(90, 30)
        Me.lbl_职务.TabIndex = 8
        Me.lbl_职务.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_ID
        '
        Me.TB_ID.BackColor = System.Drawing.Color.Teal
        Me.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.TB_ID.Location = New System.Drawing.Point(97, 119)
        Me.TB_ID.MaxLength = 3
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.Size = New System.Drawing.Size(65, 19)
        Me.TB_ID.TabIndex = 9
        '
        'MTB_pwd
        '
        Me.MTB_pwd.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MTB_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MTB_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.MTB_pwd.Location = New System.Drawing.Point(95, 155)
        Me.MTB_pwd.Name = "MTB_pwd"
        Me.MTB_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MTB_pwd.Size = New System.Drawing.Size(157, 19)
        Me.MTB_pwd.TabIndex = 10
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.HIMS.My.Resources.Resources.login11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(372, 312)
        Me.Controls.Add(Me.MTB_pwd)
        Me.Controls.Add(Me.TB_ID)
        Me.Controls.Add(Me.lbl_职务)
        Me.Controls.Add(Me.lbl_部门)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblname)
        Me.DoubleBuffered = true
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmLogin"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents lbl_部门 As Label
    Friend WithEvents lbl_职务 As Label
    Friend WithEvents TB_ID As TextBox
    Friend WithEvents MTB_pwd As MaskedTextBox
End Class
