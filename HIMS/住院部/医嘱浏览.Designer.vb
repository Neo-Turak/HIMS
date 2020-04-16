<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 医嘱浏览
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.HIMS.My.Resources.Resources.长期医嘱单
        Me.PictureBox1.Location = New System.Drawing.Point(10, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(597, 742)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "长期医嘱"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "打   印"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(519, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "打   印  参  数"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '医嘱浏览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(617, 792)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "医嘱浏览"
        Me.Padding = New System.Windows.Forms.Padding(10, 40, 10, 10)
        Me.Text = "医嘱浏览"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
