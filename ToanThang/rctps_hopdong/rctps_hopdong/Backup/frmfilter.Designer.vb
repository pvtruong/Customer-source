<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfilter
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
        Me.tabdkloc = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblten_dt = New System.Windows.Forms.Label
        Me.txtma_dt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tabdkloc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.TabPage1)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(575, 151)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblten_dt)
        Me.TabPage1.Controls.Add(Me.txtma_dt)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbbma_dvcs)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 125)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Dieu kien loc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblten_dt
        '
        Me.lblten_dt.AutoSize = True
        Me.lblten_dt.Location = New System.Drawing.Point(281, 17)
        Me.lblten_dt.Name = "lblten_dt"
        Me.lblten_dt.Size = New System.Drawing.Size(69, 13)
        Me.lblten_dt.TabIndex = 51
        Me.lblten_dt.Text = "ten doi tuong"
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(145, 13)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_dt.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Tag = "019"
        Me.Label14.Text = "ma doi tuong"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 37)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(419, 21)
        Me.cbbma_dvcs.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 88)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(419, 20)
        Me.txttitle.TabIndex = 3
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 62)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(419, 21)
        Me.cbbmau.TabIndex = 2
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 156)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "004"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(93, 156)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "005"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 183)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "frmfilter"
        Me.tabdkloc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents lblten_dt As System.Windows.Forms.Label
    Friend WithEvents txtma_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
