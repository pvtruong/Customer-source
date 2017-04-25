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
        Me.chung_tu_dc = New System.Windows.Forms.CheckBox
        Me.ten_nv = New System.Windows.Forms.Label
        Me.txtma_nv = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ten_kho = New System.Windows.Forms.Label
        Me.ten_dt = New System.Windows.Forms.Label
        Me.ten_kh = New System.Windows.Forms.Label
        Me.ten_vt = New System.Windows.Forms.Label
        Me.ten_tk_du = New System.Windows.Forms.Label
        Me.ten_tk_vt = New System.Windows.Forms.Label
        Me.txtma_kho = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtma_dt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbbnhom = New System.Windows.Forms.ComboBox
        Me.txttk_du = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbbbctheo = New System.Windows.Forms.ComboBox
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtma_vt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtDen_ngay = New ClsControl2.TxtDate
        Me.Txttu_ngay = New ClsControl2.TxtDate
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.txttk_vt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ten_ncc = New System.Windows.Forms.Label
        Me.txtma_ncc = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.tabdkloc.Size = New System.Drawing.Size(660, 395)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ten_ncc)
        Me.TabPage1.Controls.Add(Me.txtma_ncc)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.chung_tu_dc)
        Me.TabPage1.Controls.Add(Me.ten_nv)
        Me.TabPage1.Controls.Add(Me.txtma_nv)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.ten_kho)
        Me.TabPage1.Controls.Add(Me.ten_dt)
        Me.TabPage1.Controls.Add(Me.ten_kh)
        Me.TabPage1.Controls.Add(Me.ten_vt)
        Me.TabPage1.Controls.Add(Me.ten_tk_du)
        Me.TabPage1.Controls.Add(Me.ten_tk_vt)
        Me.TabPage1.Controls.Add(Me.txtma_kho)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtma_dt)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cbbnhom)
        Me.TabPage1.Controls.Add(Me.txttk_du)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cbbbctheo)
        Me.TabPage1.Controls.Add(Me.txtma_kh)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtma_vt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtDen_ngay)
        Me.TabPage1.Controls.Add(Me.Txttu_ngay)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbbma_dvcs)
        Me.TabPage1.Controls.Add(Me.txttk_vt)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(652, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Dieu kien loc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chung_tu_dc
        '
        Me.chung_tu_dc.AutoSize = True
        Me.chung_tu_dc.Checked = True
        Me.chung_tu_dc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chung_tu_dc.Location = New System.Drawing.Point(145, 220)
        Me.chung_tu_dc.Name = "chung_tu_dc"
        Me.chung_tu_dc.Size = New System.Drawing.Size(160, 17)
        Me.chung_tu_dc.TabIndex = 9
        Me.chung_tu_dc.Tag = "023"
        Me.chung_tu_dc.Text = "lay ca chung tu dieu chuyen"
        Me.chung_tu_dc.UseVisualStyleBackColor = True
        '
        'ten_nv
        '
        Me.ten_nv.AutoSize = True
        Me.ten_nv.Location = New System.Drawing.Point(276, 197)
        Me.ten_nv.Name = "ten_nv"
        Me.ten_nv.Size = New System.Drawing.Size(37, 13)
        Me.ten_nv.TabIndex = 62
        Me.ten_nv.Text = "ten nv"
        '
        'txtma_nv
        '
        Me.txtma_nv.Location = New System.Drawing.Point(145, 193)
        Me.txtma_nv.Name = "txtma_nv"
        Me.txtma_nv.Size = New System.Drawing.Size(125, 20)
        Me.txtma_nv.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Tag = "022"
        Me.Label13.Text = "ma nv"
        '
        'ten_kho
        '
        Me.ten_kho.AutoSize = True
        Me.ten_kho.Location = New System.Drawing.Point(276, 173)
        Me.ten_kho.Name = "ten_kho"
        Me.ten_kho.Size = New System.Drawing.Size(43, 13)
        Me.ten_kho.TabIndex = 59
        Me.ten_kho.Text = "ten kho"
        '
        'ten_dt
        '
        Me.ten_dt.AutoSize = True
        Me.ten_dt.Location = New System.Drawing.Point(276, 149)
        Me.ten_dt.Name = "ten_dt"
        Me.ten_dt.Size = New System.Drawing.Size(34, 13)
        Me.ten_dt.TabIndex = 58
        Me.ten_dt.Text = "ten dt"
        '
        'ten_kh
        '
        Me.ten_kh.AutoSize = True
        Me.ten_kh.Location = New System.Drawing.Point(276, 103)
        Me.ten_kh.Name = "ten_kh"
        Me.ten_kh.Size = New System.Drawing.Size(37, 13)
        Me.ten_kh.TabIndex = 57
        Me.ten_kh.Text = "ten kh"
        '
        'ten_vt
        '
        Me.ten_vt.AutoSize = True
        Me.ten_vt.Location = New System.Drawing.Point(276, 80)
        Me.ten_vt.Name = "ten_vt"
        Me.ten_vt.Size = New System.Drawing.Size(51, 13)
        Me.ten_vt.TabIndex = 56
        Me.ten_vt.Text = "ten ma vt"
        '
        'ten_tk_du
        '
        Me.ten_tk_du.AutoSize = True
        Me.ten_tk_du.Location = New System.Drawing.Point(276, 56)
        Me.ten_tk_du.Name = "ten_tk_du"
        Me.ten_tk_du.Size = New System.Drawing.Size(54, 13)
        Me.ten_tk_du.TabIndex = 55
        Me.ten_tk_du.Text = "tk doi ung"
        '
        'ten_tk_vt
        '
        Me.ten_tk_vt.AutoSize = True
        Me.ten_tk_vt.Location = New System.Drawing.Point(276, 32)
        Me.ten_tk_vt.Name = "ten_tk_vt"
        Me.ten_tk_vt.Size = New System.Drawing.Size(46, 13)
        Me.ten_tk_vt.TabIndex = 54
        Me.ten_tk_vt.Text = "ten tk vt"
        '
        'txtma_kho
        '
        Me.txtma_kho.Location = New System.Drawing.Point(145, 169)
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(125, 20)
        Me.txtma_kho.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Tag = "021"
        Me.Label1.Text = "ma kho"
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(145, 146)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_dt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Tag = "020"
        Me.Label5.Text = "ma dt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Tag = "008"
        Me.Label11.Text = "Nhom theo"
        '
        'cbbnhom
        '
        Me.cbbnhom.FormattingEnabled = True
        Me.cbbnhom.Location = New System.Drawing.Point(145, 269)
        Me.cbbnhom.Name = "cbbnhom"
        Me.cbbnhom.Size = New System.Drawing.Size(501, 21)
        Me.cbbnhom.TabIndex = 11
        '
        'txttk_du
        '
        Me.txttk_du.Location = New System.Drawing.Point(145, 52)
        Me.txttk_du.Name = "txttk_du"
        Me.txttk_du.Size = New System.Drawing.Size(125, 20)
        Me.txttk_du.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Tag = "004"
        Me.Label10.Text = "tk doi ung"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Tag = "007"
        Me.Label7.Text = "bao cao theo"
        '
        'cbbbctheo
        '
        Me.cbbbctheo.FormattingEnabled = True
        Me.cbbbctheo.Location = New System.Drawing.Point(145, 244)
        Me.cbbbctheo.Name = "cbbbctheo"
        Me.cbbbctheo.Size = New System.Drawing.Size(501, 21)
        Me.cbbbctheo.TabIndex = 10
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(145, 99)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(125, 20)
        Me.txtma_kh.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Tag = "006"
        Me.Label6.Text = "ma kh"
        '
        'txtma_vt
        '
        Me.txtma_vt.Location = New System.Drawing.Point(145, 76)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_vt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Tag = "005"
        Me.Label2.Text = "ma vt"
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
        Me.Label9.Location = New System.Drawing.Point(9, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 294)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(501, 21)
        Me.cbbma_dvcs.TabIndex = 12
        '
        'txttk_vt
        '
        Me.txttk_vt.Location = New System.Drawing.Point(145, 29)
        Me.txttk_vt.Name = "txttk_vt"
        Me.txttk_vt.Size = New System.Drawing.Size(125, 20)
        Me.txttk_vt.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Tag = "003"
        Me.Label8.Text = "tk vat tu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 344)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(501, 20)
        Me.txttitle.TabIndex = 14
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 319)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(501, 21)
        Me.cbbmau.TabIndex = 13
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 400)
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
        Me.btnCancel.Location = New System.Drawing.Point(93, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ten_ncc
        '
        Me.ten_ncc.AutoSize = True
        Me.ten_ncc.Location = New System.Drawing.Point(276, 126)
        Me.ten_ncc.Name = "ten_ncc"
        Me.ten_ncc.Size = New System.Drawing.Size(43, 13)
        Me.ten_ncc.TabIndex = 65
        Me.ten_ncc.Text = "ten ncc"
        '
        'txtma_ncc
        '
        Me.txtma_ncc.Location = New System.Drawing.Point(145, 122)
        Me.txtma_ncc.Name = "txtma_ncc"
        Me.txtma_ncc.Size = New System.Drawing.Size(125, 20)
        Me.txtma_ncc.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Tag = "NCC"
        Me.Label14.Text = "Nhà cung cấp"
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 427)
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
    Friend WithEvents txttk_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtDen_ngay As ClsControl2.TxtDate
    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents txttk_du As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbbbctheo As System.Windows.Forms.ComboBox
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbbnhom As System.Windows.Forms.ComboBox
    Friend WithEvents txtma_kho As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtma_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ten_kho As System.Windows.Forms.Label
    Friend WithEvents ten_dt As System.Windows.Forms.Label
    Friend WithEvents ten_kh As System.Windows.Forms.Label
    Friend WithEvents ten_vt As System.Windows.Forms.Label
    Friend WithEvents ten_tk_du As System.Windows.Forms.Label
    Friend WithEvents ten_tk_vt As System.Windows.Forms.Label
    Friend WithEvents ten_nv As System.Windows.Forms.Label
    Friend WithEvents txtma_nv As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chung_tu_dc As System.Windows.Forms.CheckBox
    Friend WithEvents ten_ncc As System.Windows.Forms.Label
    Friend WithEvents txtma_ncc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
