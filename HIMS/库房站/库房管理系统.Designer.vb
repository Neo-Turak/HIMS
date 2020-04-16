<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 库房管理系统
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.日常工作ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.药品入库ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.药品出口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.库存管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出口管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.药品报损ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.盘点ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.资料管理RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.药店设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息提示器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.收入管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.总收支ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.部门收支ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.报表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.每日报表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.供药单位设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.取药单位设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.警报器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.密码修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSL_日期 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_时间 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_用户名 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_部门 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_职位 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_医院名称 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.日常工作ToolStripMenuItem, Me.资料管理RToolStripMenuItem, Me.收入管理ToolStripMenuItem, Me.报表ToolStripMenuItem, Me.设置ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '日常工作ToolStripMenuItem
        '
        Me.日常工作ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.药品入库ToolStripMenuItem, Me.药品出口ToolStripMenuItem, Me.库存管理ToolStripMenuItem, Me.出口管理ToolStripMenuItem, Me.药品报损ToolStripMenuItem, Me.盘点ToolStripMenuItem})
        Me.日常工作ToolStripMenuItem.Name = "日常工作ToolStripMenuItem"
        Me.日常工作ToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.日常工作ToolStripMenuItem.Text = "日常工作(&F)"
        '
        '药品入库ToolStripMenuItem
        '
        Me.药品入库ToolStripMenuItem.Name = "药品入库ToolStripMenuItem"
        Me.药品入库ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.药品入库ToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.药品入库ToolStripMenuItem.Text = "药品入库"
        '
        '药品出口ToolStripMenuItem
        '
        Me.药品出口ToolStripMenuItem.Name = "药品出口ToolStripMenuItem"
        Me.药品出口ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.药品出口ToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.药品出口ToolStripMenuItem.Text = "药品出口"
        '
        '库存管理ToolStripMenuItem
        '
        Me.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem"
        Me.库存管理ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.库存管理ToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.库存管理ToolStripMenuItem.Text = "库存管理"
        '
        '出口管理ToolStripMenuItem
        '
        Me.出口管理ToolStripMenuItem.Name = "出口管理ToolStripMenuItem"
        Me.出口管理ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.出口管理ToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.出口管理ToolStripMenuItem.Text = "出口管理"
        '
        '药品报损ToolStripMenuItem
        '
        Me.药品报损ToolStripMenuItem.Name = "药品报损ToolStripMenuItem"
        Me.药品报损ToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.药品报损ToolStripMenuItem.Text = "药品报损"
        '
        '盘点ToolStripMenuItem
        '
        Me.盘点ToolStripMenuItem.Name = "盘点ToolStripMenuItem"
        Me.盘点ToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.盘点ToolStripMenuItem.Text = "盘点"
        '
        '资料管理RToolStripMenuItem
        '
        Me.资料管理RToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.药店设置ToolStripMenuItem, Me.信息提示器ToolStripMenuItem})
        Me.资料管理RToolStripMenuItem.Name = "资料管理RToolStripMenuItem"
        Me.资料管理RToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.资料管理RToolStripMenuItem.Text = "资料管理(&R)"
        '
        '药店设置ToolStripMenuItem
        '
        Me.药店设置ToolStripMenuItem.Name = "药店设置ToolStripMenuItem"
        Me.药店设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.药店设置ToolStripMenuItem.Text = "药库设置"
        '
        '信息提示器ToolStripMenuItem
        '
        Me.信息提示器ToolStripMenuItem.Name = "信息提示器ToolStripMenuItem"
        Me.信息提示器ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.信息提示器ToolStripMenuItem.Text = "信息提示器"
        '
        '收入管理ToolStripMenuItem
        '
        Me.收入管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.总收支ToolStripMenuItem, Me.部门收支ToolStripMenuItem})
        Me.收入管理ToolStripMenuItem.Name = "收入管理ToolStripMenuItem"
        Me.收入管理ToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.收入管理ToolStripMenuItem.Text = "收入管理"
        '
        '总收支ToolStripMenuItem
        '
        Me.总收支ToolStripMenuItem.Name = "总收支ToolStripMenuItem"
        Me.总收支ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.总收支ToolStripMenuItem.Text = "总收支"
        '
        '部门收支ToolStripMenuItem
        '
        Me.部门收支ToolStripMenuItem.Name = "部门收支ToolStripMenuItem"
        Me.部门收支ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.部门收支ToolStripMenuItem.Text = "部门收支"
        '
        '报表ToolStripMenuItem
        '
        Me.报表ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.每日报表ToolStripMenuItem})
        Me.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem"
        Me.报表ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.报表ToolStripMenuItem.Text = "报表"
        '
        '每日报表ToolStripMenuItem
        '
        Me.每日报表ToolStripMenuItem.Name = "每日报表ToolStripMenuItem"
        Me.每日报表ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.每日报表ToolStripMenuItem.Text = "每日报表"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.供药单位设置ToolStripMenuItem, Me.取药单位设置ToolStripMenuItem, Me.警报器ToolStripMenuItem, Me.密码修改ToolStripMenuItem})
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '供药单位设置ToolStripMenuItem
        '
        Me.供药单位设置ToolStripMenuItem.Name = "供药单位设置ToolStripMenuItem"
        Me.供药单位设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.供药单位设置ToolStripMenuItem.Text = "供药单位设置"
        '
        '取药单位设置ToolStripMenuItem
        '
        Me.取药单位设置ToolStripMenuItem.Name = "取药单位设置ToolStripMenuItem"
        Me.取药单位设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.取药单位设置ToolStripMenuItem.Text = "取药单位设置"
        '
        '警报器ToolStripMenuItem
        '
        Me.警报器ToolStripMenuItem.Name = "警报器ToolStripMenuItem"
        Me.警报器ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.警报器ToolStripMenuItem.Text = "警报器"
        '
        '密码修改ToolStripMenuItem
        '
        Me.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem"
        Me.密码修改ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.密码修改ToolStripMenuItem.Text = "密码修改"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_日期, Me.TSSL_时间, Me.TSSL_用户名, Me.TSSL_部门, Me.TSSL_职位, Me.TSSL_医院名称})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 601)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(754, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL_日期
        '
        Me.TSSL_日期.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TSSL_日期.Name = "TSSL_日期"
        Me.TSSL_日期.Size = New System.Drawing.Size(128, 17)
        Me.TSSL_日期.Text = "ToolStripStatusLabel1"
        '
        'TSSL_时间
        '
        Me.TSSL_时间.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TSSL_时间.Name = "TSSL_时间"
        Me.TSSL_时间.Size = New System.Drawing.Size(128, 17)
        Me.TSSL_时间.Text = "ToolStripStatusLabel1"
        '
        'TSSL_用户名
        '
        Me.TSSL_用户名.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TSSL_用户名.Name = "TSSL_用户名"
        Me.TSSL_用户名.Size = New System.Drawing.Size(128, 17)
        Me.TSSL_用户名.Text = "ToolStripStatusLabel1"
        '
        'TSSL_部门
        '
        Me.TSSL_部门.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TSSL_部门.Name = "TSSL_部门"
        Me.TSSL_部门.Size = New System.Drawing.Size(128, 17)
        Me.TSSL_部门.Text = "ToolStripStatusLabel1"
        '
        'TSSL_职位
        '
        Me.TSSL_职位.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TSSL_职位.Name = "TSSL_职位"
        Me.TSSL_职位.Size = New System.Drawing.Size(128, 17)
        Me.TSSL_职位.Text = "ToolStripStatusLabel1"
        '
        'TSSL_医院名称
        '
        Me.TSSL_医院名称.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TSSL_医院名称.Name = "TSSL_医院名称"
        Me.TSSL_医院名称.Size = New System.Drawing.Size(91, 17)
        Me.TSSL_医院名称.Text = "荒地镇卫生院"
        '
        '库房管理系统
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 623)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "库房管理系统"
        Me.Text = "库房管理系统"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 日常工作ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 药品入库ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 药品出口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 库存管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 出口管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 药品报损ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 盘点ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 资料管理RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 药店设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 信息提示器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 收入管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 总收支ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 部门收支ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 报表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 每日报表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 供药单位设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 取药单位设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 警报器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 密码修改ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSL_日期 As ToolStripStatusLabel
    Friend WithEvents TSSL_时间 As ToolStripStatusLabel
    Friend WithEvents TSSL_用户名 As ToolStripStatusLabel
    Friend WithEvents TSSL_部门 As ToolStripStatusLabel
    Friend WithEvents TSSL_职位 As ToolStripStatusLabel
    Friend WithEvents TSSL_医院名称 As ToolStripStatusLabel
End Class
