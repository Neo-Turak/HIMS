<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 远程连接服务
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(远程连接服务))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AxMsRdpClient21 = New AxMSTSCLib.AxMsRdpClient2()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        CType(Me.AxMsRdpClient21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "连接"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 44)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "断开"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(99, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "用这个功能您可以远程控制其他电脑"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(21, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(191, 30)
        Me.ListBox1.TabIndex = 2
        '
        'AxMsRdpClient21
        '
        Me.AxMsRdpClient21.Enabled = True
        Me.AxMsRdpClient21.Location = New System.Drawing.Point(12, 82)
        Me.AxMsRdpClient21.Name = "AxMsRdpClient21"
        Me.AxMsRdpClient21.OcxState = CType(resources.GetObject("AxMsRdpClient21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMsRdpClient21.Size = New System.Drawing.Size(402, 316)
        Me.AxMsRdpClient21.TabIndex = 0
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(21, 22)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(153, 20)
        Me.txtServer.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(201, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "连接"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(21, 56)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(152, 20)
        Me.TxtUserName.TabIndex = 3
        '
        'RemoteServer
        '
        Me.ClientSize = New System.Drawing.Size(426, 410)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.AxMsRdpClient21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteServer"
        CType(Me.AxMsRdpClient21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AxMsRdpClient21 As AxMSTSCLib.AxMsRdpClient2
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtUserName As TextBox
End Class
