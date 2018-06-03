﻿'written by:Nura
Imports System.Windows.Forms

Public Class 抓图器
    Private bmpFrame As Bitmap
    Private rectX, rectY, dX, dY As Integer
    Private rectSelection As Rectangle
    Private bInPhotoMode, bDragging As Boolean

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        新增档案.PB_相片.Image = Me.pbPhoto.Image
        新增档案.PB_相片.SizeMode = PictureBoxSizeMode.CenterImage
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmMakePhoto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        WebCamVFW.CloseVideo()
        If Not bmpFrame Is Nothing Then bmpFrame.Dispose()
    End Sub

    Private Sub frmMakePhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebCamVFW.Init(, , pbPreview)
        EnableToolbar("Stopped")
    End Sub

    Private Sub tbPropertires_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) _
                                                  Handles tbProperties.DropDownItemClicked,
                                                  toolMain.ItemClicked
        If e.ClickedItem.OwnerItem Is tbProperties Then
            tbProperties.DropDown.Close()
        End If
        bInPhotoMode = False
        Select Case e.ClickedItem.Name
            Case mnuSettings.Name
                WebCamVFW.ShowDeviceDialog()
            Case mnuFormatDialog.Name
                WebCamVFW.ShowFormatDialog()
                'WebCamVFW.ShowDisplayDialog()
            Case tbPlay.Name
                If Not WebCamVFW.PlayVideo Then
                    MessageBox.Show("No camera detected.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    EnableToolbar("Stopped")
                    Return
                End If
                If Not WebCamVFW.Visible Then WebCamVFW.Visible = True
                EnableToolbar("Playing")
            Case tbPause.Name
                WebCamVFW.StopVideo()
                bmpFrame = WebCamVFW.GetFrame
                EnableToolbar("Paused")
            Case tbStop.Name
                WebCamVFW.CloseVideo()
                EnableToolbar("Stopped")
            Case tbMakePhoto.Name
                bInPhotoMode = True
                rectX = CInt(pbPreview.Width / 2 - pbPhoto.Width / 2)
                rectY = CInt(pbPreview.Height / 2 - pbPhoto.Height / 2)
                rectSelection = New Rectangle(rectX, rectY, pbPhoto.Width, pbPhoto.Height)
                DrawSelectionRectangle()
                OK_Button.Enabled = True
        End Select
    End Sub

    Private Sub EnableToolbar(ByVal strAction As String)
        tbPlay.Enabled = Not strAction = "Playing"
        tbPause.Enabled = Not tbPlay.Enabled
        tbStop.Enabled = Not strAction = "Stopped"
        mnuSettings.Enabled = Not tbPlay.Enabled
        mnuFormatDialog.Enabled = Not tbPlay.Enabled
        tbMakePhoto.Enabled = strAction = "Paused"
        tbProperties.Enabled = (mnuSettings.Enabled AndAlso mnuFormatDialog.Enabled)
    End Sub

    Private Sub DrawSelectionRectangle()
        If WebCamVFW.Visible Then
            WebCamVFW.Visible = False
            pbPreview.BackgroundImage = bmpFrame
        End If
        pbPreview.Image = New Bitmap(pbPreview.Width, pbPreview.Height)
        Dim g As Graphics = Graphics.FromImage(pbPreview.Image)
        g.DrawRectangle(Pens.AliceBlue, rectSelection)
        g.Dispose()
        pbPreview.Invalidate()
        pbPhoto.Image = bmpFrame.Clone(rectSelection, Imaging.PixelFormat.DontCare)
    End Sub

    Private Sub pbPreview_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPreview.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            bDragging = True
            dX = e.X : dY = e.Y
        End If
    End Sub

    Private Sub pbPreview_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPreview.MouseMove
        If Not bInPhotoMode Then Return
        If bDragging Then
            With rectSelection
                .X = rectX + e.X - dX
                .Y = rectY + e.Y - dY
                If .X < 0 Then .X = 0
                If .Y < 0 Then .Y = 0
                If .X + .Width > pbPreview.ClientRectangle.Width Then
                    .X = pbPreview.ClientRectangle.Width - .Width
                End If
                If .Y + .Height > pbPreview.ClientRectangle.Height Then
                    .Y = pbPreview.ClientRectangle.Height - .Height
                End If
            End With
            DrawSelectionRectangle()
        End If
        Dim pt As Point = e.Location
        If rectSelection.Contains(pt) Then
            pbPreview.Cursor = Cursors.SizeAll
        Else
            pbPreview.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub pbPreview_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPreview.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then bDragging = False
    End Sub

End Class