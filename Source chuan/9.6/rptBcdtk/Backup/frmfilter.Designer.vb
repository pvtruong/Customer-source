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
        Me.btnSuaMau = New System.Windows.Forms.TabPage
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.chbct_sd_tk_th = New System.Windows.Forms.CheckBox
        Me.Txtden_ngay = New ClsControl2.TxtDate
        Me.tabdkloc.SuspendLayout()
        Me.btnSuaMau.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.btnSuaMau)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(660, 163)
        Me.tabdkloc.TabIndex = 0
        '
        'btnSuaMau
        '
        Me.btnSuaMau.Controls.Add(Me.chbct_sd_tk_th)
        Me.btnSuaMau.Controls.Add(Me.Label16)
        Me.btnSuaMau.Controls.Add(Me.Txtden_ngay)
        Me.btnSuaMau.Controls.Add(Me.Label9)
        Me.btnSuaMau.Controls.Add(Me.cbbma_dvcs)
        Me.btnSuaMau.Controls.Add(Me.Label4)
        Me.btnSuaMau.Controls.Add(Me.Label3)
        Me.btnSuaMau.Controls.Add(Me.txttitle)
        Me.btnSuaMau.Controls.Add(Me.cbbmau)
        Me.btnSuaMau.Location = New System.Drawing.Point(4, 22)
        Me.btnSuaMau.Name = "btnSuaMau"
        Me.btnSuaMau.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSuaMau.Size = New System.Drawing.Size(652, 137)
        Me.btnSuaMau.TabIndex = 0
        Me.btnSuaMau.Tag = "001"
        Me.btnSuaMau.Text = "Dieu kien loc"
        Me.btnSuaMau.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Tag = "002"
        Me.Label16.Text = "tu ngay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 57)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(326, 21)
        Me.cbbma_dvcs.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 108)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 10
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 82)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 9
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 168)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "900"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(93, 168)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(536, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Tag = "020"
        Me.Button1.Text = "Sua mau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chbct_sd_tk_th
        '
        Me.chbct_sd_tk_th.AutoSize = True
        Me.chbct_sd_tk_th.Location = New System.Drawing.Point(145, 33)
        Me.chbct_sd_tk_th.Name = "chbct_sd_tk_th"
        Me.chbct_sd_tk_th.Size = New System.Drawing.Size(219, 17)
        Me.chbct_sd_tk_th.TabIndex = 1
        Me.chbct_sd_tk_th.Tag = "003"
        Me.chbct_sd_tk_th.Text = "Lay chi tiet so du mot ve cua tk tong hop"
        Me.chbct_sd_tk_th.UseVisualStyleBackColor = True
        '
        'Txtden_ngay
        '
        Me.Txtden_ngay.Location = New System.Drawing.Point(145, 7)
        Me.Txtden_ngay.Mask = "00/00/0000"
        Me.Txtden_ngay.Name = "Txtden_ngay"
        Me.Txtden_ngay.Size = New System.Drawing.Size(125, 20)
        Me.Txtden_ngay.TabIndex = 0
        Me.Txtden_ngay.Text = "26032010"
        Me.Txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtden_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 195)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "frmfilter"
        Me.tabdkloc.ResumeLayout(False)
        Me.btnSuaMau.ResumeLayout(False)
        Me.btnSuaMau.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents btnSuaMau As System.Windows.Forms.TabPage
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txtden_ngay As ClsControl2.TxtDate
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chbct_sd_tk_th As System.Windows.Forms.CheckBox
End Class
