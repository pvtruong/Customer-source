<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminput
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
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txthan_gc = New ClsControl2.TxtDate()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblso_ct_so = New System.Windows.Forms.Label()
        Me.txtstt_rec_so = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Txtty_gia = New ClsControl2.TxtNumeric()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ten_kho = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtma_kho = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttk_co = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttk_no = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ten_sp = New System.Windows.Forms.Label()
        Me.Txtso_luong = New ClsControl2.TxtNumeric()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtma_sp = New System.Windows.Forms.TextBox()
        Me.ten_kh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtma_kh = New System.Windows.Forms.TextBox()
        Me.Txtngay_ct = New ClsControl2.TxtDate()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbbma_nt = New System.Windows.Forms.ComboBox()
        Me.txtdien_giai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtso_ct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbstatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbbma_gd = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnguoi_tao = New System.Windows.Forms.Label()
        Me.txtngay_tao = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtngay_sua = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnguoi_sua = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnluuandmoi = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Txtt_sl = New ClsControl2.TxtNumeric()
        Me.Txtt_tien_nt = New ClsControl2.TxtNumeric()
        Me.Txtt_tien = New ClsControl2.TxtNumeric()
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtt_gc_nt = New ClsControl2.TxtNumeric()
        Me.txtt_gc = New ClsControl2.TxtNumeric()
        Me.txtt_tt = New ClsControl2.TxtNumeric()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtt_tt_nt = New ClsControl2.TxtNumeric()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 344)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(81, 48)
        Me.btnLuu.TabIndex = 99
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(173, 344)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(78, 48)
        Me.btnhuy.TabIndex = 200
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txthan_gc)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblso_ct_so)
        Me.GroupBox1.Controls.Add(Me.txtstt_rec_so)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Txtty_gia)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Txtngay_ct)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbbma_nt)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtso_ct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 321)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txthan_gc
        '
        Me.txthan_gc.Location = New System.Drawing.Point(126, 98)
        Me.txthan_gc.Mask = "00/00/0000"
        Me.txthan_gc.Name = "txthan_gc"
        Me.txthan_gc.Size = New System.Drawing.Size(100, 20)
        Me.txthan_gc.TabIndex = 6
        Me.txthan_gc.Text = "01011910"
        Me.txthan_gc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txthan_gc.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 216
        Me.Label20.Tag = "221"
        Me.Label20.Text = "Hạn gia công"
        '
        'lblso_ct_so
        '
        Me.lblso_ct_so.AutoSize = True
        Me.lblso_ct_so.Location = New System.Drawing.Point(234, 81)
        Me.lblso_ct_so.Name = "lblso_ct_so"
        Me.lblso_ct_so.Size = New System.Drawing.Size(67, 13)
        Me.lblso_ct_so.TabIndex = 214
        Me.lblso_ct_so.Text = "số đơn hàng"
        '
        'txtstt_rec_so
        '
        Me.txtstt_rec_so.Location = New System.Drawing.Point(126, 77)
        Me.txtstt_rec_so.Name = "txtstt_rec_so"
        Me.txtstt_rec_so.Size = New System.Drawing.Size(100, 20)
        Me.txtstt_rec_so.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 213
        Me.Label17.Tag = "SO"
        Me.Label17.Text = "Đơn hàng"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(6, 124)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(916, 197)
        Me.TabControl1.TabIndex = 211
        Me.TabControl1.TabStop = False
        '
        'Txtty_gia
        '
        Me.Txtty_gia.Location = New System.Drawing.Point(299, 55)
        Me.Txtty_gia.MaxLength = 18
        Me.Txtty_gia.Name = "Txtty_gia"
        Me.Txtty_gia.NumberDecimalDigits = 0
        Me.Txtty_gia.Size = New System.Drawing.Size(155, 20)
        Me.Txtty_gia.TabIndex = 4
        Me.Txtty_gia.Text = "0"
        Me.Txtty_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtty_gia.Value = 0R
        Me.Txtty_gia.Value2 = 0R
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ten_kho)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtma_kho)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txttk_co)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txttk_no)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ten_sp)
        Me.GroupBox2.Controls.Add(Me.Txtso_luong)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtma_sp)
        Me.GroupBox2.Controls.Add(Me.ten_kh)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtma_kh)
        Me.GroupBox2.Location = New System.Drawing.Point(470, -5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 143)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "217"
        Me.GroupBox2.Text = "Khach hang"
        '
        'ten_kho
        '
        Me.ten_kho.AutoSize = True
        Me.ten_kho.Location = New System.Drawing.Point(265, 106)
        Me.ten_kho.Name = "ten_kho"
        Me.ten_kho.Size = New System.Drawing.Size(47, 13)
        Me.ten_kho.TabIndex = 221
        Me.ten_kho.Text = "Ten kho"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 220
        Me.Label22.Tag = "KHO"
        Me.Label22.Text = "Mã kho"
        '
        'txtma_kho
        '
        Me.txtma_kho.Location = New System.Drawing.Point(130, 102)
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(129, 20)
        Me.txtma_kho.TabIndex = 219
        Me.txtma_kho.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(264, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 218
        Me.Label15.Tag = "TK_CO"
        Me.Label15.Text = "TK có"
        '
        'txttk_co
        '
        Me.txttk_co.Location = New System.Drawing.Point(319, 81)
        Me.txttk_co.Name = "txttk_co"
        Me.txttk_co.Size = New System.Drawing.Size(129, 20)
        Me.txttk_co.TabIndex = 4
        Me.txttk_co.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 216
        Me.Label14.Tag = "TK_NO"
        Me.Label14.Text = "TK nợ"
        '
        'txttk_no
        '
        Me.txttk_no.Location = New System.Drawing.Point(130, 81)
        Me.txttk_no.Name = "txttk_no"
        Me.txttk_no.Size = New System.Drawing.Size(129, 20)
        Me.txttk_no.TabIndex = 3
        Me.txttk_no.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 214
        Me.Label9.Tag = "SL"
        Me.Label9.Text = "Số lượng"
        '
        'ten_sp
        '
        Me.ten_sp.AutoSize = True
        Me.ten_sp.Location = New System.Drawing.Point(265, 43)
        Me.ten_sp.Name = "ten_sp"
        Me.ten_sp.Size = New System.Drawing.Size(40, 13)
        Me.ten_sp.TabIndex = 9
        Me.ten_sp.Text = "Ten sp"
        '
        'Txtso_luong
        '
        Me.Txtso_luong.Location = New System.Drawing.Point(130, 60)
        Me.Txtso_luong.MaxLength = 0
        Me.Txtso_luong.Name = "Txtso_luong"
        Me.Txtso_luong.NumberDecimalDigits = 2
        Me.Txtso_luong.Size = New System.Drawing.Size(129, 20)
        Me.Txtso_luong.TabIndex = 2
        Me.Txtso_luong.Text = "0.00"
        Me.Txtso_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtso_luong.Value = 0R
        Me.Txtso_luong.Value2 = 0R
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Tag = "MSP"
        Me.Label13.Text = "Mã sản phẩm"
        '
        'txtma_sp
        '
        Me.txtma_sp.Location = New System.Drawing.Point(130, 39)
        Me.txtma_sp.Name = "txtma_sp"
        Me.txtma_sp.Size = New System.Drawing.Size(129, 20)
        Me.txtma_sp.TabIndex = 1
        Me.txtma_sp.Tag = ""
        '
        'ten_kh
        '
        Me.ten_kh.AutoSize = True
        Me.ten_kh.Location = New System.Drawing.Point(265, 22)
        Me.ten_kh.Name = "ten_kh"
        Me.ten_kh.Size = New System.Drawing.Size(41, 13)
        Me.ten_kh.TabIndex = 6
        Me.ten_kh.Text = "Ten kh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Tag = "001"
        Me.Label4.Text = "Ma khach"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(130, 18)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(129, 20)
        Me.txtma_kh.TabIndex = 0
        Me.txtma_kh.Tag = ""
        '
        'Txtngay_ct
        '
        Me.Txtngay_ct.Location = New System.Drawing.Point(354, 13)
        Me.Txtngay_ct.Mask = "00/00/0000"
        Me.Txtngay_ct.Name = "Txtngay_ct"
        Me.Txtngay_ct.Size = New System.Drawing.Size(100, 20)
        Me.Txtngay_ct.TabIndex = 1
        Me.Txtngay_ct.Text = "01011910"
        Me.Txtngay_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_ct.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Tag = "215"
        Me.Label11.Text = "ngoai te"
        '
        'cbbma_nt
        '
        Me.cbbma_nt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbma_nt.FormattingEnabled = True
        Me.cbbma_nt.Location = New System.Drawing.Point(126, 55)
        Me.cbbma_nt.Name = "cbbma_nt"
        Me.cbbma_nt.Size = New System.Drawing.Size(159, 21)
        Me.cbbma_nt.TabIndex = 3
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(126, 34)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(328, 20)
        Me.txtdien_giai.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "214"
        Me.Label7.Text = "Dien giai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "221"
        Me.Label2.Text = "ngay ct"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(126, 13)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "220"
        Me.Label1.Text = "So chung tu"
        '
        'cbbstatus
        '
        Me.cbbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbstatus.FormattingEnabled = True
        Me.cbbstatus.Location = New System.Drawing.Point(380, 1)
        Me.cbbstatus.Name = "cbbstatus"
        Me.cbbstatus.Size = New System.Drawing.Size(196, 21)
        Me.cbbstatus.TabIndex = 10
        Me.cbbstatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label12.Location = New System.Drawing.Point(297, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Tag = "303"
        Me.Label12.Text = "trang thai"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label16.Location = New System.Drawing.Point(1, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 206
        Me.Label16.Tag = "423"
        Me.Label16.Text = "Loai phieu xuat"
        '
        'cbbma_gd
        '
        Me.cbbma_gd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbma_gd.FormattingEnabled = True
        Me.cbbma_gd.Location = New System.Drawing.Point(103, 1)
        Me.cbbma_gd.Name = "cbbma_gd"
        Me.cbbma_gd.Size = New System.Drawing.Size(188, 21)
        Me.cbbma_gd.TabIndex = 205
        Me.cbbma_gd.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Tag = "090"
        Me.Label3.Text = "Nguoi tao:"
        '
        'txtnguoi_tao
        '
        Me.txtnguoi_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_tao.AutoSize = True
        Me.txtnguoi_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 392)
        Me.txtnguoi_tao.Name = "txtnguoi_tao"
        Me.txtnguoi_tao.Size = New System.Drawing.Size(51, 13)
        Me.txtnguoi_tao.TabIndex = 14
        Me.txtnguoi_tao.Text = "nguoi tao"
        '
        'txtngay_tao
        '
        Me.txtngay_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_tao.AutoSize = True
        Me.txtngay_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 392)
        Me.txtngay_tao.Name = "txtngay_tao"
        Me.txtngay_tao.Size = New System.Drawing.Size(48, 13)
        Me.txtngay_tao.TabIndex = 16
        Me.txtngay_tao.Text = "ngay tao"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(158, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Tag = "092"
        Me.Label6.Text = "Ngay tao:"
        '
        'txtngay_sua
        '
        Me.txtngay_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_sua.AutoSize = True
        Me.txtngay_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 407)
        Me.txtngay_sua.Name = "txtngay_sua"
        Me.txtngay_sua.Size = New System.Drawing.Size(50, 13)
        Me.txtngay_sua.TabIndex = 20
        Me.txtngay_sua.Text = "ngay sua"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(158, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Tag = "093"
        Me.Label5.Text = "Ngay sua:"
        '
        'txtnguoi_sua
        '
        Me.txtnguoi_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_sua.AutoSize = True
        Me.txtnguoi_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 407)
        Me.txtnguoi_sua.Name = "txtnguoi_sua"
        Me.txtnguoi_sua.Size = New System.Drawing.Size(53, 13)
        Me.txtnguoi_sua.TabIndex = 18
        Me.txtnguoi_sua.Text = "nguoi sua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(0, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(530, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Tag = "412"
        Me.Label10.Text = "Tien"
        '
        'btnluuandmoi
        '
        Me.btnluuandmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnluuandmoi.Location = New System.Drawing.Point(87, 344)
        Me.btnluuandmoi.Name = "btnluuandmoi"
        Me.btnluuandmoi.Size = New System.Drawing.Size(82, 48)
        Me.btnluuandmoi.TabIndex = 100
        Me.btnluuandmoi.Tag = "219"
        Me.btnluuandmoi.Text = "Luu va them moi"
        Me.btnluuandmoi.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(310, 353)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 13)
        Me.Label25.TabIndex = 211
        Me.Label25.Tag = "418"
        Me.Label25.Text = "Tong so luong"
        '
        'Txtt_sl
        '
        Me.Txtt_sl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_sl.Location = New System.Drawing.Point(391, 349)
        Me.Txtt_sl.MaxLength = 0
        Me.Txtt_sl.Name = "Txtt_sl"
        Me.Txtt_sl.NumberDecimalDigits = 2
        Me.Txtt_sl.ReadOnly = True
        Me.Txtt_sl.Size = New System.Drawing.Size(129, 20)
        Me.Txtt_sl.TabIndex = 210
        Me.Txtt_sl.Text = "0.00"
        Me.Txtt_sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_sl.Value = 0R
        Me.Txtt_sl.Value2 = 0R
        '
        'Txtt_tien_nt
        '
        Me.Txtt_tien_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien_nt.Location = New System.Drawing.Point(646, 349)
        Me.Txtt_tien_nt.MaxLength = 0
        Me.Txtt_tien_nt.Name = "Txtt_tien_nt"
        Me.Txtt_tien_nt.NumberDecimalDigits = 2
        Me.Txtt_tien_nt.ReadOnly = True
        Me.Txtt_tien_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien_nt.TabIndex = 107
        Me.Txtt_tien_nt.Text = "0.00"
        Me.Txtt_tien_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien_nt.Value = 0R
        Me.Txtt_tien_nt.Value2 = 0R
        '
        'Txtt_tien
        '
        Me.Txtt_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien.Location = New System.Drawing.Point(780, 349)
        Me.Txtt_tien.MaxLength = 0
        Me.Txtt_tien.Name = "Txtt_tien"
        Me.Txtt_tien.NumberDecimalDigits = 0
        Me.Txtt_tien.ReadOnly = True
        Me.Txtt_tien.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien.TabIndex = 108
        Me.Txtt_tien.Text = "0"
        Me.Txtt_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien.Value = 0R
        Me.Txtt_tien.Value2 = 0R
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolbar.Size = New System.Drawing.Size(915, 25)
        Me.toolbar.TabIndex = 212
        Me.toolbar.Text = "toolbar"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(530, 376)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 214
        Me.Label18.Tag = "TGC"
        Me.Label18.Text = "Tổng gia công"
        '
        'txtt_gc_nt
        '
        Me.txtt_gc_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_gc_nt.Location = New System.Drawing.Point(646, 372)
        Me.txtt_gc_nt.MaxLength = 0
        Me.txtt_gc_nt.Name = "txtt_gc_nt"
        Me.txtt_gc_nt.NumberDecimalDigits = 2
        Me.txtt_gc_nt.ReadOnly = True
        Me.txtt_gc_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_gc_nt.TabIndex = 213
        Me.txtt_gc_nt.Text = "0.00"
        Me.txtt_gc_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_gc_nt.Value = 0R
        Me.txtt_gc_nt.Value2 = 0R
        '
        'txtt_gc
        '
        Me.txtt_gc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_gc.Location = New System.Drawing.Point(780, 372)
        Me.txtt_gc.MaxLength = 0
        Me.txtt_gc.Name = "txtt_gc"
        Me.txtt_gc.NumberDecimalDigits = 2
        Me.txtt_gc.ReadOnly = True
        Me.txtt_gc.Size = New System.Drawing.Size(130, 20)
        Me.txtt_gc.TabIndex = 215
        Me.txtt_gc.Text = "0.00"
        Me.txtt_gc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_gc.Value = 0R
        Me.txtt_gc.Value2 = 0R
        '
        'txtt_tt
        '
        Me.txtt_tt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt.Location = New System.Drawing.Point(780, 395)
        Me.txtt_tt.MaxLength = 0
        Me.txtt_tt.Name = "txtt_tt"
        Me.txtt_tt.NumberDecimalDigits = 2
        Me.txtt_tt.ReadOnly = True
        Me.txtt_tt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt.TabIndex = 218
        Me.txtt_tt.Text = "0.00"
        Me.txtt_tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt.Value = 0R
        Me.txtt_tt.Value2 = 0R
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(530, 399)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 217
        Me.Label19.Tag = "TC"
        Me.Label19.Text = "Tổng cộng"
        '
        'txtt_tt_nt
        '
        Me.txtt_tt_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt_nt.Location = New System.Drawing.Point(646, 395)
        Me.txtt_tt_nt.MaxLength = 0
        Me.txtt_tt_nt.Name = "txtt_tt_nt"
        Me.txtt_tt_nt.NumberDecimalDigits = 2
        Me.txtt_tt_nt.ReadOnly = True
        Me.txtt_tt_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt_nt.TabIndex = 216
        Me.txtt_tt_nt.Text = "0.00"
        Me.txtt_tt_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt_nt.Value = 0R
        Me.txtt_tt_nt.Value2 = 0R
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 426)
        Me.Controls.Add(Me.txtt_tt)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtt_tt_nt)
        Me.Controls.Add(Me.txtt_gc)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtt_gc_nt)
        Me.Controls.Add(Me.cbbstatus)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbbma_gd)
        Me.Controls.Add(Me.Txtt_sl)
        Me.Controls.Add(Me.btnluuandmoi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtt_tien_nt)
        Me.Controls.Add(Me.Txtt_tien)
        Me.Controls.Add(Me.txtngay_sua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnguoi_sua)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtngay_tao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnguoi_tao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "000"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_tao As System.Windows.Forms.Label
    Friend WithEvents txtngay_tao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtngay_sua As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_sua As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtso_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbbma_nt As System.Windows.Forms.ComboBox
    Friend WithEvents Txtngay_ct As ClsControl2.TxtDate
    Friend WithEvents Txtt_tien As ClsControl2.TxtNumeric
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_nt As ClsControl2.TxtNumeric
    Friend WithEvents btnluuandmoi As System.Windows.Forms.Button
    Friend WithEvents Txtty_gia As ClsControl2.TxtNumeric
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txtt_sl As ClsControl2.TxtNumeric
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbbma_gd As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents txthan_gc As ClsControl2.TxtDate
    Friend WithEvents Label20 As Label
    Friend WithEvents lblso_ct_so As Label
    Friend WithEvents txtstt_rec_so As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txttk_co As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txttk_no As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ten_sp As Label
    Friend WithEvents Txtso_luong As ClsControl2.TxtNumeric
    Friend WithEvents Label13 As Label
    Friend WithEvents txtma_sp As TextBox
    Friend WithEvents ten_kh As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtt_gc_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_gc As ClsControl2.TxtNumeric
    Friend WithEvents txtt_tt As ClsControl2.TxtNumeric
    Friend WithEvents Label19 As Label
    Friend WithEvents txtt_tt_nt As ClsControl2.TxtNumeric
    Friend WithEvents ten_kho As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtma_kho As TextBox
End Class
