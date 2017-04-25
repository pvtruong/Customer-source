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
        Me.ten_ncc = New System.Windows.Forms.Label
        Me.txtma_ncc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbbnhom_theo = New System.Windows.Forms.ComboBox
        Me.chbct_dc = New System.Windows.Forms.CheckBox
        Me.ten_loai = New System.Windows.Forms.Label
        Me.txtloai_vt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ten_nhom = New System.Windows.Forms.Label
        Me.txtma_nhvt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ten_vt = New System.Windows.Forms.Label
        Me.txtma_vt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ten_kho = New System.Windows.Forms.Label
        Me.txtma_Kho = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chbton = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtDen_ngay = New ClsControl2.TxtDate
        Me.Txttu_ngay = New ClsControl2.TxtDate
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ten_tk_vt = New System.Windows.Forms.Label
        Me.txttk_vt = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
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
        Me.tabdkloc.Size = New System.Drawing.Size(660, 358)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ten_tk_vt)
        Me.TabPage1.Controls.Add(Me.txttk_vt)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.ten_ncc)
        Me.TabPage1.Controls.Add(Me.txtma_ncc)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cbbnhom_theo)
        Me.TabPage1.Controls.Add(Me.chbct_dc)
        Me.TabPage1.Controls.Add(Me.ten_loai)
        Me.TabPage1.Controls.Add(Me.txtloai_vt)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ten_nhom)
        Me.TabPage1.Controls.Add(Me.txtma_nhvt)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ten_vt)
        Me.TabPage1.Controls.Add(Me.txtma_vt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ten_kho)
        Me.TabPage1.Controls.Add(Me.txtma_Kho)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.chbton)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtDen_ngay)
        Me.TabPage1.Controls.Add(Me.Txttu_ngay)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbbma_dvcs)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(652, 332)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Dieu kien loc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ten_ncc
        '
        Me.ten_ncc.AutoSize = True
        Me.ten_ncc.Location = New System.Drawing.Point(288, 163)
        Me.ten_ncc.Name = "ten_ncc"
        Me.ten_ncc.Size = New System.Drawing.Size(75, 13)
        Me.ten_ncc.TabIndex = 54
        Me.ten_ncc.Text = "Nha cung cap"
        '
        'txtma_ncc
        '
        Me.txtma_ncc.Location = New System.Drawing.Point(145, 159)
        Me.txtma_ncc.Name = "txtma_ncc"
        Me.txtma_ncc.Size = New System.Drawing.Size(125, 20)
        Me.txtma_ncc.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Tag = "NCC"
        Me.Label7.Text = "Nhà cung cấp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Tag = "811"
        Me.Label1.Text = "Nhom theo"
        '
        'cbbnhom_theo
        '
        Me.cbbnhom_theo.FormattingEnabled = True
        Me.cbbnhom_theo.Location = New System.Drawing.Point(145, 230)
        Me.cbbnhom_theo.Name = "cbbnhom_theo"
        Me.cbbnhom_theo.Size = New System.Drawing.Size(326, 21)
        Me.cbbnhom_theo.TabIndex = 9
        '
        'chbct_dc
        '
        Me.chbct_dc.AutoSize = True
        Me.chbct_dc.Location = New System.Drawing.Point(145, 183)
        Me.chbct_dc.Name = "chbct_dc"
        Me.chbct_dc.Size = New System.Drawing.Size(141, 17)
        Me.chbct_dc.TabIndex = 7
        Me.chbct_dc.Tag = "007"
        Me.chbct_dc.Text = "In chung tu dieu chuyen"
        Me.chbct_dc.UseVisualStyleBackColor = True
        '
        'ten_loai
        '
        Me.ten_loai.AutoSize = True
        Me.ten_loai.Location = New System.Drawing.Point(288, 114)
        Me.ten_loai.Name = "ten_loai"
        Me.ten_loai.Size = New System.Drawing.Size(41, 13)
        Me.ten_loai.TabIndex = 49
        Me.ten_loai.Text = "ten loai"
        '
        'txtloai_vt
        '
        Me.txtloai_vt.Location = New System.Drawing.Point(145, 110)
        Me.txtloai_vt.Name = "txtloai_vt"
        Me.txtloai_vt.Size = New System.Drawing.Size(125, 20)
        Me.txtloai_vt.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Tag = "006"
        Me.Label10.Text = "Loai vat tu"
        '
        'ten_nhom
        '
        Me.ten_nhom.AutoSize = True
        Me.ten_nhom.Location = New System.Drawing.Point(288, 89)
        Me.ten_nhom.Name = "ten_nhom"
        Me.ten_nhom.Size = New System.Drawing.Size(63, 13)
        Me.ten_nhom.TabIndex = 46
        Me.ten_nhom.Text = "ten nhom vt"
        '
        'txtma_nhvt
        '
        Me.txtma_nhvt.Location = New System.Drawing.Point(145, 85)
        Me.txtma_nhvt.Name = "txtma_nhvt"
        Me.txtma_nhvt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_nhvt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Tag = "005"
        Me.Label6.Text = "nhom vat tu"
        '
        'ten_vt
        '
        Me.ten_vt.AutoSize = True
        Me.ten_vt.Location = New System.Drawing.Point(288, 63)
        Me.ten_vt.Name = "ten_vt"
        Me.ten_vt.Size = New System.Drawing.Size(34, 13)
        Me.ten_vt.TabIndex = 43
        Me.ten_vt.Text = "ten vt"
        '
        'txtma_vt
        '
        Me.txtma_vt.Location = New System.Drawing.Point(145, 59)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_vt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Tag = "004"
        Me.Label2.Text = "ma vat tu"
        '
        'ten_kho
        '
        Me.ten_kho.AutoSize = True
        Me.ten_kho.Location = New System.Drawing.Point(288, 37)
        Me.ten_kho.Name = "ten_kho"
        Me.ten_kho.Size = New System.Drawing.Size(46, 13)
        Me.ten_kho.TabIndex = 40
        Me.ten_kho.Text = "ten_kho"
        '
        'txtma_Kho
        '
        Me.txtma_Kho.Location = New System.Drawing.Point(145, 33)
        Me.txtma_Kho.Name = "txtma_Kho"
        Me.txtma_Kho.Size = New System.Drawing.Size(125, 20)
        Me.txtma_Kho.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Tag = "003"
        Me.Label8.Text = "ma kho"
        '
        'chbton
        '
        Me.chbton.AutoSize = True
        Me.chbton.Location = New System.Drawing.Point(145, 207)
        Me.chbton.Name = "chbton"
        Me.chbton.Size = New System.Drawing.Size(166, 17)
        Me.chbton.TabIndex = 8
        Me.chbton.Tag = "008"
        Me.chbton.Text = "khong in nhung vat tu ton = 0"
        Me.chbton.UseVisualStyleBackColor = True
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 257)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(326, 21)
        Me.cbbma_dvcs.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 308)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 12
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 282)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 11
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 363)
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
        Me.btnCancel.Location = New System.Drawing.Point(93, 363)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ten_tk_vt
        '
        Me.ten_tk_vt.AutoSize = True
        Me.ten_tk_vt.Location = New System.Drawing.Point(288, 138)
        Me.ten_tk_vt.Name = "ten_tk_vt"
        Me.ten_tk_vt.Size = New System.Drawing.Size(99, 13)
        Me.ten_tk_vt.TabIndex = 57
        Me.ten_tk_vt.Text = "ten tai khoan vat tu"
        '
        'txttk_vt
        '
        Me.txttk_vt.Location = New System.Drawing.Point(145, 134)
        Me.txttk_vt.Name = "txttk_vt"
        Me.txttk_vt.Size = New System.Drawing.Size(125, 20)
        Me.txttk_vt.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Tag = "TVT"
        Me.Label11.Text = "Tài khoản vật tư"
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 390)
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
    Friend WithEvents chbton As System.Windows.Forms.CheckBox
    Friend WithEvents ten_kho As System.Windows.Forms.Label
    Friend WithEvents txtma_Kho As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ten_nhom As System.Windows.Forms.Label
    Friend WithEvents txtma_nhvt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ten_vt As System.Windows.Forms.Label
    Friend WithEvents txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chbct_dc As System.Windows.Forms.CheckBox
    Friend WithEvents ten_loai As System.Windows.Forms.Label
    Friend WithEvents txtloai_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbnhom_theo As System.Windows.Forms.ComboBox
    Friend WithEvents ten_ncc As System.Windows.Forms.Label
    Friend WithEvents txtma_ncc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ten_tk_vt As System.Windows.Forms.Label
    Friend WithEvents txttk_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
