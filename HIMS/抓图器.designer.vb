<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 抓图器
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(抓图器))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.toolMain = New System.Windows.Forms.ToolStrip()
        Me.tbPlay = New System.Windows.Forms.ToolStripButton()
        Me.tbPause = New System.Windows.Forms.ToolStripButton()
        Me.tbStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbProperties = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuFormatDialog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbMakePhoto = New System.Windows.Forms.ToolStripButton()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.toolMain.SuspendLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(329, 239)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "应用"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'toolMain
        '
        Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbPlay, Me.tbPause, Me.tbStop, Me.ToolStripSeparator1, Me.tbProperties, Me.ToolStripSeparator2, Me.tbMakePhoto})
        Me.toolMain.Location = New System.Drawing.Point(0, 0)
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(475, 25)
        Me.toolMain.TabIndex = 1
        Me.toolMain.Text = "ToolStrip1"
        '
        'tbPlay
        '
        Me.tbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbPlay.Image = CType(resources.GetObject("tbPlay.Image"), System.Drawing.Image)
        Me.tbPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbPlay.Name = "tbPlay"
        Me.tbPlay.Size = New System.Drawing.Size(23, 22)
        Me.tbPlay.Text = "播放"
        '
        'tbPause
        '
        Me.tbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbPause.Enabled = False
        Me.tbPause.Image = CType(resources.GetObject("tbPause.Image"), System.Drawing.Image)
        Me.tbPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbPause.Name = "tbPause"
        Me.tbPause.Size = New System.Drawing.Size(23, 22)
        Me.tbPause.Text = "暂停"
        '
        'tbStop
        '
        Me.tbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbStop.Enabled = False
        Me.tbStop.Image = CType(resources.GetObject("tbStop.Image"), System.Drawing.Image)
        Me.tbStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbStop.Name = "tbStop"
        Me.tbStop.Size = New System.Drawing.Size(23, 22)
        Me.tbStop.Text = "停止"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbProperties
        '
        Me.tbProperties.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFormatDialog, Me.mnuSettings})
        Me.tbProperties.Image = CType(resources.GetObject("tbProperties.Image"), System.Drawing.Image)
        Me.tbProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbProperties.Name = "tbProperties"
        Me.tbProperties.Size = New System.Drawing.Size(62, 22)
        Me.tbProperties.Text = "属性"
        '
        'mnuFormatDialog
        '
        Me.mnuFormatDialog.Name = "mnuFormatDialog"
        Me.mnuFormatDialog.Size = New System.Drawing.Size(180, 22)
        Me.mnuFormatDialog.Text = "视频"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(180, 22)
        Me.mnuSettings.Text = "设置"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbMakePhoto
        '
        Me.tbMakePhoto.Enabled = False
        Me.tbMakePhoto.Image = CType(resources.GetObject("tbMakePhoto.Image"), System.Drawing.Image)
        Me.tbMakePhoto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbMakePhoto.Name = "tbMakePhoto"
        Me.tbMakePhoto.Size = New System.Drawing.Size(53, 22)
        Me.tbMakePhoto.Text = "拍照"
        '
        'pbPreview
        '
        Me.pbPreview.BackColor = System.Drawing.SystemColors.Window
        Me.pbPreview.Location = New System.Drawing.Point(4, 28)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(320, 240)
        Me.pbPreview.TabIndex = 2
        Me.pbPreview.TabStop = False
        '
        'pbPhoto
        '
        Me.pbPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPhoto.BackColor = System.Drawing.SystemColors.Window
        Me.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPhoto.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbPhoto.Location = New System.Drawing.Point(339, 28)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(118, 156)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbPhoto.TabIndex = 125
        Me.pbPhoto.TabStop = False
        '
        '抓图器
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(475, 271)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.pbPreview)
        Me.Controls.Add(Me.toolMain)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "抓图器"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WebCam"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.toolMain.ResumeLayout(False)
        Me.toolMain.PerformLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents toolMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tbPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbPause As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbMakePhoto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbProperties As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFormatDialog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbPreview As System.Windows.Forms.PictureBox
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox

End Class
