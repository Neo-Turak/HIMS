<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 编码转换
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(127, 39)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.MaxLength = 12
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 29)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.TextBox2.Location = New System.Drawing.Point(127, 91)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 29)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "医疗证号："
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(28, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "患者编码："
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(5, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "备注:本功能医疗证号和患者编码之间的互相转换。"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.Location = New System.Drawing.Point(287, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "转换"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BurlyWood
        Me.Button2.Location = New System.Drawing.Point(287, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "清除"
        Me.Button2.UseVisualStyleBackColor = false
        '
        '编码转换
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 211)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "编码转换"
        Me.Text = "编码转换"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
