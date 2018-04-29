<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblname.Location = New System.Drawing.Point(157, 119)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(161, 20)
        Me.lblname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(109, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "医院智能管理系统"
        '
        'Btn_OK
        '
        Me.Btn_OK.BackColor = System.Drawing.Color.Transparent
        Me.Btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_OK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_OK.Location = New System.Drawing.Point(86, 243)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(86, 36)
        Me.Btn_OK.TabIndex = 5
        Me.Btn_OK.Text = "确定"
        Me.Btn_OK.UseVisualStyleBackColor = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_Exit.Location = New System.Drawing.Point(241, 243)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(86, 36)
        Me.Btn_Exit.TabIndex = 6
        Me.Btn_Exit.Text = "退出"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_ID
        '
        Me.TB_ID.BackColor = System.Drawing.Color.Green
        Me.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_ID.Location = New System.Drawing.Point(97, 119)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.Size = New System.Drawing.Size(65, 19)
        Me.TB_ID.TabIndex = 9
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.HIMS.My.Resources.Resources.login11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(372, 312)
        Me.Controls.Add(Me.TB_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblname)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_ID As TextBox
End Class
