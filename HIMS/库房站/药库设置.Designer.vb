<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 药库设置
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.B_添加 = New System.Windows.Forms.Button()
        Me.B_更新 = New System.Windows.Forms.Button()
        Me.B_删除 = New System.Windows.Forms.Button()
        Me.TB_编号 = New System.Windows.Forms.TextBox()
        Me.TB_名称 = New System.Windows.Forms.TextBox()
        Me.TB_位置 = New System.Windows.Forms.TextBox()
        Me.TB_备注 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(190, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(468, 502)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "编号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "名称"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "位置"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "备注"
        '
        'B_添加
        '
        Me.B_添加.Location = New System.Drawing.Point(42, 329)
        Me.B_添加.Name = "B_添加"
        Me.B_添加.Size = New System.Drawing.Size(92, 37)
        Me.B_添加.TabIndex = 2
        Me.B_添加.Text = "添加"
        Me.B_添加.UseVisualStyleBackColor = True
        '
        'B_更新
        '
        Me.B_更新.Location = New System.Drawing.Point(42, 389)
        Me.B_更新.Name = "B_更新"
        Me.B_更新.Size = New System.Drawing.Size(92, 37)
        Me.B_更新.TabIndex = 2
        Me.B_更新.Text = "更新"
        Me.B_更新.UseVisualStyleBackColor = True
        '
        'B_删除
        '
        Me.B_删除.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.B_删除.Location = New System.Drawing.Point(42, 450)
        Me.B_删除.Name = "B_删除"
        Me.B_删除.Size = New System.Drawing.Size(92, 37)
        Me.B_删除.TabIndex = 2
        Me.B_删除.Text = "删除"
        Me.B_删除.UseVisualStyleBackColor = False
        '
        'TB_编号
        '
        Me.TB_编号.Enabled = False
        Me.TB_编号.Location = New System.Drawing.Point(53, 57)
        Me.TB_编号.Name = "TB_编号"
        Me.TB_编号.Size = New System.Drawing.Size(80, 23)
        Me.TB_编号.TabIndex = 3
        Me.TB_编号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_名称
        '
        Me.TB_名称.Location = New System.Drawing.Point(28, 118)
        Me.TB_名称.Name = "TB_名称"
        Me.TB_名称.Size = New System.Drawing.Size(136, 23)
        Me.TB_名称.TabIndex = 3
        Me.TB_名称.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_位置
        '
        Me.TB_位置.Location = New System.Drawing.Point(28, 186)
        Me.TB_位置.Name = "TB_位置"
        Me.TB_位置.Size = New System.Drawing.Size(136, 23)
        Me.TB_位置.TabIndex = 3
        Me.TB_位置.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_备注
        '
        Me.TB_备注.Location = New System.Drawing.Point(28, 254)
        Me.TB_备注.MaxLength = 256
        Me.TB_备注.Multiline = True
        Me.TB_备注.Name = "TB_备注"
        Me.TB_备注.Size = New System.Drawing.Size(136, 57)
        Me.TB_备注.TabIndex = 3
        Me.TB_备注.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '药库设置
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(658, 502)
        Me.Controls.Add(Me.TB_备注)
        Me.Controls.Add(Me.TB_位置)
        Me.Controls.Add(Me.TB_名称)
        Me.Controls.Add(Me.TB_编号)
        Me.Controls.Add(Me.B_删除)
        Me.Controls.Add(Me.B_更新)
        Me.Controls.Add(Me.B_添加)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "药库设置"
        Me.Text = "药库设置"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents B_添加 As Button
    Friend WithEvents B_更新 As Button
    Friend WithEvents B_删除 As Button
    Friend WithEvents TB_编号 As TextBox
    Friend WithEvents TB_名称 As TextBox
    Friend WithEvents TB_位置 As TextBox
    Friend WithEvents TB_备注 As TextBox
End Class
