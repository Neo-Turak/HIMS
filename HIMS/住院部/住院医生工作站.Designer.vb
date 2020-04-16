<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 住院医生工作站
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.医嘱处理QToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.医嘱录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.长期医嘱ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.临时医嘱ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.确认医嘱ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停止医嘱ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.我的病人ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.医嘱护理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.医嘱模板管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.长期医嘱模板ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.临时医嘱模板ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.护理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.护理管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.病人信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.以往病历查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.系统设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.常规项目设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.个性化设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改口令ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主题设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_科室 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_医生 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_时间 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.医嘱处理QToolStripMenuItem, Me.医嘱模板管理ToolStripMenuItem, Me.护理ToolStripMenuItem, Me.病人信息ToolStripMenuItem, Me.系统设置ToolStripMenuItem, Me.个性化设置ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(890, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '医嘱处理QToolStripMenuItem
        '
        Me.医嘱处理QToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.医嘱录入ToolStripMenuItem, Me.确认医嘱ToolStripMenuItem, Me.停止医嘱ToolStripMenuItem, Me.我的病人ToolStripMenuItem, Me.ToolStripSeparator1, Me.医嘱护理ToolStripMenuItem, Me.ToolStripSeparator2, Me.退出XToolStripMenuItem})
        Me.医嘱处理QToolStripMenuItem.Name = "医嘱处理QToolStripMenuItem"
        Me.医嘱处理QToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.医嘱处理QToolStripMenuItem.Text = "医嘱处理(&Q)"
        '
        '医嘱录入ToolStripMenuItem
        '
        Me.医嘱录入ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.长期医嘱ToolStripMenuItem, Me.临时医嘱ToolStripMenuItem})
        Me.医嘱录入ToolStripMenuItem.Name = "医嘱录入ToolStripMenuItem"
        Me.医嘱录入ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.医嘱录入ToolStripMenuItem.Text = "医嘱录入"
        '
        '长期医嘱ToolStripMenuItem
        '
        Me.长期医嘱ToolStripMenuItem.Name = "长期医嘱ToolStripMenuItem"
        Me.长期医嘱ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.长期医嘱ToolStripMenuItem.Text = "长期医嘱"
        '
        '临时医嘱ToolStripMenuItem
        '
        Me.临时医嘱ToolStripMenuItem.Name = "临时医嘱ToolStripMenuItem"
        Me.临时医嘱ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.临时医嘱ToolStripMenuItem.Text = "临时医嘱"
        '
        '确认医嘱ToolStripMenuItem
        '
        Me.确认医嘱ToolStripMenuItem.Name = "确认医嘱ToolStripMenuItem"
        Me.确认医嘱ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.确认医嘱ToolStripMenuItem.Text = "确认医嘱"
        '
        '停止医嘱ToolStripMenuItem
        '
        Me.停止医嘱ToolStripMenuItem.Name = "停止医嘱ToolStripMenuItem"
        Me.停止医嘱ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.停止医嘱ToolStripMenuItem.Text = "停止医嘱"
        '
        '我的病人ToolStripMenuItem
        '
        Me.我的病人ToolStripMenuItem.Name = "我的病人ToolStripMenuItem"
        Me.我的病人ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.我的病人ToolStripMenuItem.Text = "我的病人"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        '医嘱护理ToolStripMenuItem
        '
        Me.医嘱护理ToolStripMenuItem.Name = "医嘱护理ToolStripMenuItem"
        Me.医嘱护理ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.医嘱护理ToolStripMenuItem.Text = "医嘱护理"
        '
        '医嘱模板管理ToolStripMenuItem
        '
        Me.医嘱模板管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.长期医嘱模板ToolStripMenuItem, Me.临时医嘱模板ToolStripMenuItem})
        Me.医嘱模板管理ToolStripMenuItem.Name = "医嘱模板管理ToolStripMenuItem"
        Me.医嘱模板管理ToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.医嘱模板管理ToolStripMenuItem.Text = "医嘱模板管理"
        '
        '长期医嘱模板ToolStripMenuItem
        '
        Me.长期医嘱模板ToolStripMenuItem.Name = "长期医嘱模板ToolStripMenuItem"
        Me.长期医嘱模板ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.长期医嘱模板ToolStripMenuItem.Text = "长期医嘱模板"
        '
        '临时医嘱模板ToolStripMenuItem
        '
        Me.临时医嘱模板ToolStripMenuItem.Name = "临时医嘱模板ToolStripMenuItem"
        Me.临时医嘱模板ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.临时医嘱模板ToolStripMenuItem.Text = "临时医嘱模板"
        '
        '护理ToolStripMenuItem
        '
        Me.护理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.护理管理ToolStripMenuItem})
        Me.护理ToolStripMenuItem.Name = "护理ToolStripMenuItem"
        Me.护理ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.护理ToolStripMenuItem.Text = "护理"
        '
        '护理管理ToolStripMenuItem
        '
        Me.护理管理ToolStripMenuItem.Name = "护理管理ToolStripMenuItem"
        Me.护理管理ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.护理管理ToolStripMenuItem.Text = "护理管理"
        '
        '病人信息ToolStripMenuItem
        '
        Me.病人信息ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.以往病历查询ToolStripMenuItem})
        Me.病人信息ToolStripMenuItem.Name = "病人信息ToolStripMenuItem"
        Me.病人信息ToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.病人信息ToolStripMenuItem.Text = "病人信息"
        '
        '以往病历查询ToolStripMenuItem
        '
        Me.以往病历查询ToolStripMenuItem.Name = "以往病历查询ToolStripMenuItem"
        Me.以往病历查询ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.以往病历查询ToolStripMenuItem.Text = "以往病历查询"
        '
        '系统设置ToolStripMenuItem
        '
        Me.系统设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.常规项目设置ToolStripMenuItem})
        Me.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem"
        Me.系统设置ToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.系统设置ToolStripMenuItem.Text = "系统设置"
        '
        '常规项目设置ToolStripMenuItem
        '
        Me.常规项目设置ToolStripMenuItem.Name = "常规项目设置ToolStripMenuItem"
        Me.常规项目设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.常规项目设置ToolStripMenuItem.Text = "常规项目设置"
        '
        '个性化设置ToolStripMenuItem
        '
        Me.个性化设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改口令ToolStripMenuItem, Me.主题设置ToolStripMenuItem})
        Me.个性化设置ToolStripMenuItem.Name = "个性化设置ToolStripMenuItem"
        Me.个性化设置ToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.个性化设置ToolStripMenuItem.Text = "个性化设置"
        '
        '修改口令ToolStripMenuItem
        '
        Me.修改口令ToolStripMenuItem.Name = "修改口令ToolStripMenuItem"
        Me.修改口令ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.修改口令ToolStripMenuItem.Text = "修改口令"
        '
        '主题设置ToolStripMenuItem
        '
        Me.主题设置ToolStripMenuItem.Name = "主题设置ToolStripMenuItem"
        Me.主题设置ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.主题设置ToolStripMenuItem.Text = "主题设置"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TSSL_科室, Me.ToolStripStatusLabel3, Me.TSSL_医生, Me.ToolStripStatusLabel5, Me.TSSL_时间})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(890, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Coral
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 19)
        Me.ToolStripStatusLabel1.Text = "职      务:"
        '
        'TSSL_科室
        '
        Me.TSSL_科室.AutoSize = False
        Me.TSSL_科室.Name = "TSSL_科室"
        Me.TSSL_科室.Size = New System.Drawing.Size(100, 19)
        Me.TSSL_科室.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.ForestGreen
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(100, 19)
        Me.ToolStripStatusLabel3.Text = "医     生:"
        '
        'TSSL_医生
        '
        Me.TSSL_医生.AutoSize = False
        Me.TSSL_医生.Name = "TSSL_医生"
        Me.TSSL_医生.Size = New System.Drawing.Size(200, 19)
        Me.TSSL_医生.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.AutoSize = False
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(250, 19)
        Me.ToolStripStatusLabel5.Text = "荒 地 镇 卫 生 院"
        '
        'TSSL_时间
        '
        Me.TSSL_时间.Font = New System.Drawing.Font("SimHei", 10.0!, System.Drawing.FontStyle.Italic)
        Me.TSSL_时间.Name = "TSSL_时间"
        Me.TSSL_时间.Size = New System.Drawing.Size(154, 19)
        Me.TSSL_时间.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '住院医生工作站
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 521)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "住院医生工作站"
        Me.Text = "住院医生工作站"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 医嘱处理QToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 医嘱录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 长期医嘱ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 临时医嘱ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 确认医嘱ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 停止医嘱ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 我的病人ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 医嘱护理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 医嘱模板管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 长期医嘱模板ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 临时医嘱模板ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 护理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 护理管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 病人信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 以往病历查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 系统设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 常规项目设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 个性化设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改口令ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 主题设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TSSL_科室 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents TSSL_医生 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents TSSL_时间 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 退出XToolStripMenuItem As ToolStripMenuItem
End Class
