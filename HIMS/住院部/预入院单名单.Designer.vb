<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 预入院单名单
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
        Me.btn_删除 = New System.Windows.Forms.Button()
        Me.Btn_更新 = New System.Windows.Forms.Button()
        Me.Btn_退出 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 6)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(683, 266)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_删除
        '
        Me.btn_删除.BackColor = System.Drawing.Color.Yellow
        Me.btn_删除.Location = New System.Drawing.Point(13, 294)
        Me.btn_删除.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_删除.Name = "btn_删除"
        Me.btn_删除.Size = New System.Drawing.Size(162, 50)
        Me.btn_删除.TabIndex = 1
        Me.btn_删除.Text = "删除记录"
        Me.btn_删除.UseVisualStyleBackColor = False
        '
        'Btn_更新
        '
        Me.Btn_更新.BackColor = System.Drawing.Color.Green
        Me.Btn_更新.Location = New System.Drawing.Point(262, 294)
        Me.Btn_更新.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_更新.Name = "Btn_更新"
        Me.Btn_更新.Size = New System.Drawing.Size(162, 50)
        Me.Btn_更新.TabIndex = 1
        Me.Btn_更新.Text = "更新"
        Me.Btn_更新.UseVisualStyleBackColor = False
        '
        'Btn_退出
        '
        Me.Btn_退出.Location = New System.Drawing.Point(518, 294)
        Me.Btn_退出.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_退出.Name = "Btn_退出"
        Me.Btn_退出.Size = New System.Drawing.Size(162, 50)
        Me.Btn_退出.TabIndex = 1
        Me.Btn_退出.Text = "退出"
        Me.Btn_退出.UseVisualStyleBackColor = True
        '
        '预入院单名单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(703, 353)
        Me.Controls.Add(Me.Btn_退出)
        Me.Controls.Add(Me.Btn_更新)
        Me.Controls.Add(Me.btn_删除)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "预入院单名单"
        Me.Text = "入院单名单"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_删除 As Button
    Friend WithEvents Btn_更新 As Button
    Friend WithEvents Btn_退出 As Button
End Class
