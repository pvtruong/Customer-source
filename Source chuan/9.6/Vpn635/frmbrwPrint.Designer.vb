﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbrwPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbrwPrint))
        Me.grd = New System.Windows.Forms.DataGridView
        Me.btnpreview = New System.Windows.Forms.ToolStripButton
        Me.btnrefresh2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btndkloc = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnIN = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblunit = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel
        Me.printer = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnu = New System.Windows.Forms.MenuStrip
        Me.ChucNangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.statusbar = New System.Windows.Forms.StatusStrip
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.statusbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.Location = New System.Drawing.Point(0, 49)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(836, 329)
        Me.grd.TabIndex = 7
        '
        'btnpreview
        '
        Me.btnpreview.Image = CType(resources.GetObject("btnpreview.Image"), System.Drawing.Image)
        Me.btnpreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(47, 22)
        Me.btnpreview.Tag = "202"
        Me.btnpreview.Text = "Xem"
        '
        'btnrefresh2
        '
        Me.btnrefresh2.Image = CType(resources.GetObject("btnrefresh2.Image"), System.Drawing.Image)
        Me.btnrefresh2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrefresh2.Name = "btnrefresh2"
        Me.btnrefresh2.Size = New System.Drawing.Size(64, 22)
        Me.btnrefresh2.Tag = "203"
        Me.btnrefresh2.Text = "lam tuoi"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btndkloc
        '
        Me.btndkloc.Image = CType(resources.GetObject("btndkloc.Image"), System.Drawing.Image)
        Me.btndkloc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndkloc.Name = "btndkloc"
        Me.btndkloc.Size = New System.Drawing.Size(54, 22)
        Me.btndkloc.Tag = "001"
        Me.btndkloc.Text = "dk loc"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnIN
        '
        Me.btnIN.Image = CType(resources.GetObject("btnIN.Image"), System.Drawing.Image)
        Me.btnIN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(37, 22)
        Me.btnIN.Tag = "201"
        Me.btnIN.Text = "In"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIN, Me.btnpreview, Me.btnrefresh2, Me.ToolStripSeparator2, Me.btndkloc, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(836, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ThoatToolStripMenuItem.Tag = "999"
        Me.ThoatToolStripMenuItem.Text = "Thoat"
        '
        'lblunit
        '
        Me.lblunit.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(30, 17)
        Me.lblunit.Text = "Unit"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(29, 17)
        Me.lbluser.Text = "User"
        '
        'printer
        '
        Me.printer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.printer.Name = "printer"
        Me.printer.Size = New System.Drawing.Size(43, 17)
        Me.printer.Text = "Printer"
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChucNangToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(836, 24)
        Me.mnu.TabIndex = 5
        Me.mnu.Text = "MenuStrip1"
        '
        'ChucNangToolStripMenuItem
        '
        Me.ChucNangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoatToolStripMenuItem})
        Me.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem"
        Me.ChucNangToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ChucNangToolStripMenuItem.Tag = "200"
        Me.ChucNangToolStripMenuItem.Text = "Chuc nang"
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblunit, Me.lbluser, Me.printer})
        Me.statusbar.Location = New System.Drawing.Point(0, 378)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(836, 22)
        Me.statusbar.TabIndex = 4
        Me.statusbar.Text = "StatusStrip1"
        '
        'frmbrwPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 400)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnu)
        Me.Controls.Add(Me.statusbar)
        Me.Name = "frmbrwPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "frmbrwPrint"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents btnpreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnrefresh2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btndkloc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnIN As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblunit As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents printer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents ChucNangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
End Class