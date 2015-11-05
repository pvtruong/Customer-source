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
        Me.lblten_kh = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblten_dt = New System.Windows.Forms.Label
        Me.txtma_dt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtDen_ngay = New ClsControl2.TxtDate
        Me.Txttu_ngay = New ClsControl2.TxtDate
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbnhom_theo = New System.Windows.Forms.ComboBox
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
        Me.tabdkloc.Size = New System.Drawing.Size(660, 215)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblten_kh)
        Me.TabPage1.Controls.Add(Me.txtma_kh)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lblten_dt)
        Me.TabPage1.Controls.Add(Me.txtma_dt)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtDen_ngay)
        Me.TabPage1.Controls.Add(Me.Txttu_ngay)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbbnhom_theo)
        Me.TabPage1.Controls.Add(Me.cbbma_dvcs)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(652, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Dieu kien loc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblten_kh
        '
        Me.lblten_kh.AutoSize = True
        Me.lblten_kh.Location = New System.Drawing.Point(274, 38)
        Me.lblten_kh.Name = "lblten_kh"
        Me.lblten_kh.Size = New System.Drawing.Size(37, 13)
        Me.lblten_kh.TabIndex = 42
        Me.lblten_kh.Text = "ten kh"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(145, 34)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(125, 20)
        Me.txtma_kh.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Tag = "003"
        Me.Label5.Text = "ma khach hang"
        '
        'lblten_dt
        '
        Me.lblten_dt.AutoSize = True
        Me.lblten_dt.Location = New System.Drawing.Point(274, 65)
        Me.lblten_dt.Name = "lblten_dt"
        Me.lblten_dt.Size = New System.Drawing.Size(37, 13)
        Me.lblten_dt.TabIndex = 39
        Me.lblten_dt.Text = "ten vv"
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(145, 61)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_dt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Tag = "004"
        Me.Label6.Text = "ma dt"
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
        'TxtDen_ngay
        '
        Me.TxtDen_ngay.Culture = New System.Globalization.CultureInfo("en-US")
        Me.TxtDen_ngay.Location = New System.Drawing.Point(276, 7)
        Me.TxtDen_ngay.Mask = "00/00/0000"
        Me.TxtDen_ngay.Name = "TxtDen_ngay"
        Me.TxtDen_ngay.Size = New System.Drawing.Size(125, 20)
        Me.TxtDen_ngay.TabIndex = 1
        Me.TxtDen_ngay.Text = "26032010"
        Me.TxtDen_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDen_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Txttu_ngay
        '
        Me.Txttu_ngay.Location = New System.Drawing.Point(145, 7)
        Me.Txttu_ngay.Mask = "00/00/0000"
        Me.Txttu_ngay.Name = "Txttu_ngay"
        Me.Txttu_ngay.Size = New System.Drawing.Size(125, 20)
        Me.Txttu_ngay.TabIndex = 0
        Me.Txttu_ngay.Text = "26032010"
        Me.Txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "007"
        Me.Label1.Text = "nhom theo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbnhom_theo
        '
        Me.cbbnhom_theo.FormattingEnabled = True
        Me.cbbnhom_theo.Location = New System.Drawing.Point(145, 85)
        Me.cbbnhom_theo.Name = "cbbnhom_theo"
        Me.cbbnhom_theo.Size = New System.Drawing.Size(481, 21)
        Me.cbbnhom_theo.TabIndex = 4
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 110)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(481, 21)
        Me.cbbma_dvcs.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 160)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(481, 20)
        Me.txttitle.TabIndex = 7
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 135)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(481, 21)
        Me.cbbmau.TabIndex = 6
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 220)
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
        Me.btnCancel.Location = New System.Drawing.Point(93, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 247)
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtDen_ngay As ClsControl2.TxtDate
    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents lblten_kh As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbnhom_theo As System.Windows.Forms.ComboBox
    Friend WithEvents lblten_dt As System.Windows.Forms.Label
    Friend WithEvents txtma_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
