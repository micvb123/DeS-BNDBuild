﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Des_BNDBuild
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
        Me.txtBNDfile = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRebuild = New System.Windows.Forms.Button()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'txtBNDfile
        '
        Me.txtBNDfile.AllowDrop = true
        Me.txtBNDfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtBNDfile.Location = New System.Drawing.Point(44, 6)
        Me.txtBNDfile.Name = "txtBNDfile"
        Me.txtBNDfile.Size = New System.Drawing.Size(440, 20)
        Me.txtBNDfile.TabIndex = 26
        '
        'lblGAFile
        '
        Me.lblGAFile.AutoSize = true
        Me.lblGAFile.Location = New System.Drawing.Point(12, 9)
        Me.lblGAFile.Name = "lblGAFile"
        Me.lblGAFile.Size = New System.Drawing.Size(26, 13)
        Me.lblGAFile.TabIndex = 28
        Me.lblGAFile.Text = "File:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(487, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 27
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'btnRebuild
        '
        Me.btnRebuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRebuild.Location = New System.Drawing.Point(487, 33)
        Me.btnRebuild.Name = "btnRebuild"
        Me.btnRebuild.Size = New System.Drawing.Size(75, 23)
        Me.btnRebuild.TabIndex = 30
        Me.btnRebuild.Text = "Rebuild"
        Me.btnRebuild.UseVisualStyleBackColor = true
        '
        'btnExtract
        '
        Me.btnExtract.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnExtract.Location = New System.Drawing.Point(409, 33)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(75, 23)
        Me.btnExtract.TabIndex = 29
        Me.btnExtract.Text = "Extract"
        Me.btnExtract.UseVisualStyleBackColor = true
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtInfo.Location = New System.Drawing.Point(12, 62)
        Me.txtInfo.Multiline = true
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(548, 142)
        Me.txtInfo.TabIndex = 31
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Location = New System.Drawing.Point(327, 38)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(76, 13)
        Me.lblVersion.TabIndex = 42
        Me.lblVersion.Text = "2017-04-20-03"
        '
        'Des_BNDBuild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 216)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnRebuild)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.txtBNDfile)
        Me.Controls.Add(Me.lblGAFile)
        Me.Controls.Add(Me.btnBrowse)
        Me.DoubleBuffered = true
        Me.MinimumSize = New System.Drawing.Size(360, 180)
        Me.Name = "Des_BNDBuild"
        Me.Text = "Wulf's BND Rebuilder"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtBNDfile As System.Windows.Forms.TextBox
    Friend WithEvents lblGAFile As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRebuild As System.Windows.Forms.Button
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label

End Class