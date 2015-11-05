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
        Me.Label12 = New System.Windows.Forms.Label
        Me.ten_kh = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ten_nv = New System.Windows.Forms.Label
        Me.txtma_nv = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ten_dt = New System.Windows.Forms.Label
        Me.txtma_dt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ten_phi = New System.Windows.Forms.Label
        Me.txtma_phi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ten_bp = New System.Windows.Forms.Label
        Me.txtma_bp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtngay_cuoi_ky0 = New ClsControl2.TxtDate
        Me.Txtngay_dau_ky0 = New ClsControl2.TxtDate
        Me.txttu_ngay = New ClsControl2.TxtDate
        Me.Label16 = New System.Windows.Forms.Label
        Me.Txtden_ngay = New ClsControl2.TxtDate
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.ten_hd = New System.Windows.Forms.Label
        Me.txtma_hd = New System.Windows.Forms.TextBox
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
        Me.tabdkloc.Size = New System.Drawing.Size(660, 320)
        Me.tabdkloc.TabIndex = 0
        '
        'btnSuaMau
        '
        Me.btnSuaMau.Controls.Add(Me.Label6)
        Me.btnSuaMau.Controls.Add(Me.ten_hd)
        Me.btnSuaMau.Controls.Add(Me.txtma_hd)
        Me.btnSuaMau.Controls.Add(Me.Label12)
        Me.btnSuaMau.Controls.Add(Me.ten_kh)
        Me.btnSuaMau.Controls.Add(Me.txtma_kh)
        Me.btnSuaMau.Controls.Add(Me.Label10)
        Me.btnSuaMau.Controls.Add(Me.ten_nv)
        Me.btnSuaMau.Controls.Add(Me.txtma_nv)
        Me.btnSuaMau.Controls.Add(Me.Label7)
        Me.btnSuaMau.Controls.Add(Me.ten_dt)
        Me.btnSuaMau.Controls.Add(Me.txtma_dt)
        Me.btnSuaMau.Controls.Add(Me.Label5)
        Me.btnSuaMau.Controls.Add(Me.ten_phi)
        Me.btnSuaMau.Controls.Add(Me.txtma_phi)
        Me.btnSuaMau.Controls.Add(Me.Label2)
        Me.btnSuaMau.Controls.Add(Me.ten_bp)
        Me.btnSuaMau.Controls.Add(Me.txtma_bp)
        Me.btnSuaMau.Controls.Add(Me.Label1)
        Me.btnSuaMau.Controls.Add(Me.Txtngay_cuoi_ky0)
        Me.btnSuaMau.Controls.Add(Me.Txtngay_dau_ky0)
        Me.btnSuaMau.Controls.Add(Me.txttu_ngay)
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
        Me.btnSuaMau.Size = New System.Drawing.Size(652, 294)
        Me.btnSuaMau.TabIndex = 0
        Me.btnSuaMau.Tag = "001"
        Me.btnSuaMau.Text = "Dieu kien loc"
        Me.btnSuaMau.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Tag = "404"
        Me.Label12.Text = "Mã khách hàng"
        '
        'ten_kh
        '
        Me.ten_kh.AutoSize = True
        Me.ten_kh.Location = New System.Drawing.Point(257, 189)
        Me.ten_kh.Name = "ten_kh"
        Me.ten_kh.Size = New System.Drawing.Size(26, 13)
        Me.ten_kh.TabIndex = 54
        Me.ten_kh.Text = "Ten"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(145, 186)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(100, 20)
        Me.txtma_kh.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Tag = "403"
        Me.Label10.Text = "Mã nhân viên"
        '
        'ten_nv
        '
        Me.ten_nv.AutoSize = True
        Me.ten_nv.Location = New System.Drawing.Point(257, 163)
        Me.ten_nv.Name = "ten_nv"
        Me.ten_nv.Size = New System.Drawing.Size(26, 13)
        Me.ten_nv.TabIndex = 51
        Me.ten_nv.Text = "Ten"
        '
        'txtma_nv
        '
        Me.txtma_nv.Location = New System.Drawing.Point(145, 160)
        Me.txtma_nv.Name = "txtma_nv"
        Me.txtma_nv.Size = New System.Drawing.Size(100, 20)
        Me.txtma_nv.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Tag = "402"
        Me.Label7.Text = "Mã đối tượng/vụ việc"
        '
        'ten_dt
        '
        Me.ten_dt.AutoSize = True
        Me.ten_dt.Location = New System.Drawing.Point(257, 110)
        Me.ten_dt.Name = "ten_dt"
        Me.ten_dt.Size = New System.Drawing.Size(29, 13)
        Me.ten_dt.TabIndex = 48
        Me.ten_dt.Text = "Ten "
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(145, 107)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_dt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Tag = "401"
        Me.Label5.Text = "Mã phí"
        '
        'ten_phi
        '
        Me.ten_phi.AutoSize = True
        Me.ten_phi.Location = New System.Drawing.Point(257, 84)
        Me.ten_phi.Name = "ten_phi"
        Me.ten_phi.Size = New System.Drawing.Size(29, 13)
        Me.ten_phi.TabIndex = 45
        Me.ten_phi.Text = "Ten "
        '
        'txtma_phi
        '
        Me.txtma_phi.Location = New System.Drawing.Point(145, 81)
        Me.txtma_phi.Name = "txtma_phi"
        Me.txtma_phi.Size = New System.Drawing.Size(100, 20)
        Me.txtma_phi.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Tag = "400"
        Me.Label2.Text = "Mã bộ phận"
        '
        'ten_bp
        '
        Me.ten_bp.AutoSize = True
        Me.ten_bp.Location = New System.Drawing.Point(257, 59)
        Me.ten_bp.Name = "ten_bp"
        Me.ten_bp.Size = New System.Drawing.Size(29, 13)
        Me.ten_bp.TabIndex = 42
        Me.ten_bp.Text = "Ten "
        '
        'txtma_bp
        '
        Me.txtma_bp.Location = New System.Drawing.Point(145, 56)
        Me.txtma_bp.Name = "txtma_bp"
        Me.txtma_bp.Size = New System.Drawing.Size(100, 20)
        Me.txtma_bp.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Tag = "003"
        Me.Label1.Text = "ngay dau ky truoc"
        '
        'Txtngay_cuoi_ky0
        '
        Me.Txtngay_cuoi_ky0.Location = New System.Drawing.Point(276, 30)
        Me.Txtngay_cuoi_ky0.Mask = "00/00/0000"
        Me.Txtngay_cuoi_ky0.Name = "Txtngay_cuoi_ky0"
        Me.Txtngay_cuoi_ky0.Size = New System.Drawing.Size(125, 20)
        Me.Txtngay_cuoi_ky0.TabIndex = 3
        Me.Txtngay_cuoi_ky0.Text = "26032010"
        Me.Txtngay_cuoi_ky0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_cuoi_ky0.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Txtngay_dau_ky0
        '
        Me.Txtngay_dau_ky0.Location = New System.Drawing.Point(145, 30)
        Me.Txtngay_dau_ky0.Mask = "00/00/0000"
        Me.Txtngay_dau_ky0.Name = "Txtngay_dau_ky0"
        Me.Txtngay_dau_ky0.Size = New System.Drawing.Size(125, 20)
        Me.Txtngay_dau_ky0.TabIndex = 2
        Me.Txtngay_dau_ky0.Text = "26032010"
        Me.Txtngay_dau_ky0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_dau_ky0.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'txttu_ngay
        '
        Me.txttu_ngay.Location = New System.Drawing.Point(145, 6)
        Me.txttu_ngay.Mask = "00/00/0000"
        Me.txttu_ngay.Name = "txttu_ngay"
        Me.txttu_ngay.Size = New System.Drawing.Size(125, 20)
        Me.txttu_ngay.TabIndex = 0
        Me.txttu_ngay.Text = "26032010"
        Me.txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttu_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Tag = "002"
        Me.Label16.Text = "tu ngay"
        '
        'Txtden_ngay
        '
        Me.Txtden_ngay.Location = New System.Drawing.Point(276, 6)
        Me.Txtden_ngay.Mask = "00/00/0000"
        Me.Txtden_ngay.Name = "Txtden_ngay"
        Me.Txtden_ngay.Size = New System.Drawing.Size(125, 20)
        Me.Txtden_ngay.TabIndex = 1
        Me.Txtden_ngay.Text = "26032010"
        Me.Txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtden_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 212)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(326, 21)
        Me.cbbma_dvcs.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 263)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 12
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 237)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 11
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 325)
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
        Me.btnCancel.Location = New System.Drawing.Point(93, 325)
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
        Me.Button1.Location = New System.Drawing.Point(536, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Tag = "020"
        Me.Button1.Text = "Sua mau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Tag = "402"
        Me.Label6.Text = "Mã hợp đồng"
        '
        'ten_hd
        '
        Me.ten_hd.AutoSize = True
        Me.ten_hd.Location = New System.Drawing.Point(257, 136)
        Me.ten_hd.Name = "ten_hd"
        Me.ten_hd.Size = New System.Drawing.Size(29, 13)
        Me.ten_hd.TabIndex = 57
        Me.ten_hd.Text = "Ten "
        '
        'txtma_hd
        '
        Me.txtma_hd.Location = New System.Drawing.Point(145, 133)
        Me.txtma_hd.Name = "txtma_hd"
        Me.txtma_hd.Size = New System.Drawing.Size(100, 20)
        Me.txtma_hd.TabIndex = 7
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 352)
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
    Friend WithEvents Txtngay_cuoi_ky0 As ClsControl2.TxtDate
    Friend WithEvents Txtngay_dau_ky0 As ClsControl2.TxtDate
    Friend WithEvents txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ten_kh As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ten_nv As System.Windows.Forms.Label
    Friend WithEvents txtma_nv As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ten_dt As System.Windows.Forms.Label
    Friend WithEvents txtma_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ten_phi As System.Windows.Forms.Label
    Friend WithEvents txtma_phi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ten_bp As System.Windows.Forms.Label
    Friend WithEvents txtma_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ten_hd As System.Windows.Forms.Label
    Friend WithEvents txtma_hd As System.Windows.Forms.TextBox
End Class
