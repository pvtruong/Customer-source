﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnkhaibao = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtnam = New System.Windows.Forms.NumericUpDown
        Me.txtden_ky = New System.Windows.Forms.NumericUpDown
        Me.txttu_ky = New System.Windows.Forms.NumericUpDown
        Me.btntao = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbbstatus = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Txtty_gia = New ClsControl2.TxtNumeric
        Me.Txtngay_ct = New ClsControl2.TxtDate
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbbma_nt = New System.Windows.Forms.ComboBox
        Me.txtdien_giai = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtso_ct = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnluuandmoi = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txtt_tien_nt = New ClsControl2.TxtNumeric
        Me.Txtt_tien = New ClsControl2.TxtNumeric
        Me.txtt_tt_nt = New ClsControl2.TxtNumeric
        Me.txtt_tt = New ClsControl2.TxtNumeric
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtden_ky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttu_ky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 321)
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
        Me.btnhuy.Location = New System.Drawing.Point(173, 321)
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
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Txtty_gia)
        Me.GroupBox1.Controls.Add(Me.Txtngay_ct)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbbma_nt)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtso_ct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-6, -8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(949, 326)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnkhaibao)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtnam)
        Me.GroupBox2.Controls.Add(Me.txtden_ky)
        Me.GroupBox2.Controls.Add(Me.txttu_ky)
        Me.GroupBox2.Controls.Add(Me.btntao)
        Me.GroupBox2.Location = New System.Drawing.Point(485, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "k03"
        Me.GroupBox2.Text = "Tao but toan ket chuyen tu dong"
        '
        'btnkhaibao
        '
        Me.btnkhaibao.Location = New System.Drawing.Point(105, 68)
        Me.btnkhaibao.Name = "btnkhaibao"
        Me.btnkhaibao.Size = New System.Drawing.Size(75, 23)
        Me.btnkhaibao.TabIndex = 5
        Me.btnkhaibao.Tag = "K07"
        Me.btnkhaibao.Text = "Khai bao"
        Me.btnkhaibao.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Tag = "K08"
        Me.Label13.Text = "Nam"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(139, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Tag = "K05"
        Me.Label9.Text = "Den ky"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Tag = "K04"
        Me.Label4.Text = "Tu ky"
        '
        'txtnam
        '
        Me.txtnam.Location = New System.Drawing.Point(268, 42)
        Me.txtnam.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.txtnam.Minimum = New Decimal(New Integer() {1901, 0, 0, 0})
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(120, 20)
        Me.txtnam.TabIndex = 3
        Me.txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnam.Value = New Decimal(New Integer() {1901, 0, 0, 0})
        '
        'txtden_ky
        '
        Me.txtden_ky.Location = New System.Drawing.Point(142, 42)
        Me.txtden_ky.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtden_ky.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtden_ky.Name = "txtden_ky"
        Me.txtden_ky.Size = New System.Drawing.Size(120, 20)
        Me.txtden_ky.TabIndex = 2
        Me.txtden_ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtden_ky.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txttu_ky
        '
        Me.txttu_ky.Location = New System.Drawing.Point(16, 42)
        Me.txttu_ky.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txttu_ky.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txttu_ky.Name = "txttu_ky"
        Me.txttu_ky.Size = New System.Drawing.Size(120, 20)
        Me.txttu_ky.TabIndex = 1
        Me.txttu_ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttu_ky.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btntao
        '
        Me.btntao.Location = New System.Drawing.Point(16, 68)
        Me.btntao.Name = "btntao"
        Me.btntao.Size = New System.Drawing.Size(75, 23)
        Me.btntao.TabIndex = 4
        Me.btntao.Tag = "K06"
        Me.btntao.Text = "Tao"
        Me.btntao.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox3.Controls.Add(Me.cbbstatus)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(-46, -7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1040, 48)
        Me.GroupBox3.TabIndex = 211
        Me.GroupBox3.TabStop = False
        '
        'cbbstatus
        '
        Me.cbbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbstatus.FormattingEnabled = True
        Me.cbbstatus.Location = New System.Drawing.Point(172, 19)
        Me.cbbstatus.Name = "cbbstatus"
        Me.cbbstatus.Size = New System.Drawing.Size(333, 21)
        Me.cbbstatus.TabIndex = 10
        Me.cbbstatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Tag = "303"
        Me.Label12.Text = "trang thai"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(4, 142)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(943, 181)
        Me.TabControl1.TabIndex = 40
        Me.TabControl1.TabStop = False
        '
        'Txtty_gia
        '
        Me.Txtty_gia.Enabled = False
        Me.Txtty_gia.Location = New System.Drawing.Point(306, 101)
        Me.Txtty_gia.MaxLength = 18
        Me.Txtty_gia.Name = "Txtty_gia"
        Me.Txtty_gia.NumberDecimalDigits = 0
        Me.Txtty_gia.Size = New System.Drawing.Size(153, 20)
        Me.Txtty_gia.TabIndex = 4
        Me.Txtty_gia.Text = "0"
        Me.Txtty_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtty_gia.Value = 0
        Me.Txtty_gia.Value2 = 0
        '
        'Txtngay_ct
        '
        Me.Txtngay_ct.Location = New System.Drawing.Point(320, 53)
        Me.Txtngay_ct.Mask = "00/00/0000"
        Me.Txtngay_ct.Name = "Txtngay_ct"
        Me.Txtngay_ct.Size = New System.Drawing.Size(139, 20)
        Me.Txtngay_ct.TabIndex = 1
        Me.Txtngay_ct.Text = "12042010"
        Me.Txtngay_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_ct.Value = New Date(2010, 4, 12, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Tag = "215"
        Me.Label11.Text = "ngoai te"
        '
        'cbbma_nt
        '
        Me.cbbma_nt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbma_nt.Enabled = False
        Me.cbbma_nt.FormattingEnabled = True
        Me.cbbma_nt.Location = New System.Drawing.Point(126, 101)
        Me.cbbma_nt.Name = "cbbma_nt"
        Me.cbbma_nt.Size = New System.Drawing.Size(159, 21)
        Me.cbbma_nt.TabIndex = 3
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(126, 77)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(333, 20)
        Me.txtdien_giai.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "214"
        Me.Label7.Text = "Dien giai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "221"
        Me.Label2.Text = "ngay ct"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(126, 53)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "220"
        Me.Label1.Text = "So chung tu"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 369)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 369)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 369)
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
        Me.Label6.Location = New System.Drawing.Point(158, 369)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 384)
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
        Me.Label5.Location = New System.Drawing.Point(158, 384)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 384)
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
        Me.Label8.Location = New System.Drawing.Point(0, 384)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'btnluuandmoi
        '
        Me.btnluuandmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnluuandmoi.Location = New System.Drawing.Point(87, 321)
        Me.btnluuandmoi.Name = "btnluuandmoi"
        Me.btnluuandmoi.Size = New System.Drawing.Size(82, 48)
        Me.btnluuandmoi.TabIndex = 100
        Me.btnluuandmoi.Tag = "219"
        Me.btnluuandmoi.Text = "Luu va them moi"
        Me.btnluuandmoi.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(570, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 206
        Me.Label10.Tag = "409"
        Me.Label10.Text = "Tien chua thue"
        '
        'Txtt_tien_nt
        '
        Me.Txtt_tien_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien_nt.Location = New System.Drawing.Point(669, 321)
        Me.Txtt_tien_nt.MaxLength = 0
        Me.Txtt_tien_nt.Name = "Txtt_tien_nt"
        Me.Txtt_tien_nt.NumberDecimalDigits = 2
        Me.Txtt_tien_nt.ReadOnly = True
        Me.Txtt_tien_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien_nt.TabIndex = 205
        Me.Txtt_tien_nt.Text = "0.00"
        Me.Txtt_tien_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien_nt.Value = 0
        Me.Txtt_tien_nt.Value2 = 0
        '
        'Txtt_tien
        '
        Me.Txtt_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien.Location = New System.Drawing.Point(805, 321)
        Me.Txtt_tien.MaxLength = 0
        Me.Txtt_tien.Name = "Txtt_tien"
        Me.Txtt_tien.NumberDecimalDigits = 0
        Me.Txtt_tien.ReadOnly = True
        Me.Txtt_tien.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien.TabIndex = 207
        Me.Txtt_tien.Text = "0"
        Me.Txtt_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien.Value = 0
        Me.Txtt_tien.Value2 = 0
        '
        'txtt_tt_nt
        '
        Me.txtt_tt_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt_nt.Location = New System.Drawing.Point(669, 347)
        Me.txtt_tt_nt.MaxLength = 0
        Me.txtt_tt_nt.Name = "txtt_tt_nt"
        Me.txtt_tt_nt.NumberDecimalDigits = 2
        Me.txtt_tt_nt.ReadOnly = True
        Me.txtt_tt_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt_nt.TabIndex = 210
        Me.txtt_tt_nt.Text = "0.00"
        Me.txtt_tt_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt_nt.Value = 0
        Me.txtt_tt_nt.Value2 = 0
        '
        'txtt_tt
        '
        Me.txtt_tt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt.Location = New System.Drawing.Point(805, 347)
        Me.txtt_tt.MaxLength = 0
        Me.txtt_tt.Name = "txtt_tt"
        Me.txtt_tt.NumberDecimalDigits = 0
        Me.txtt_tt.ReadOnly = True
        Me.txtt_tt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt.TabIndex = 211
        Me.txtt_tt.Text = "0"
        Me.txtt_tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt.Value = 0
        Me.txtt_tt.Value2 = 0
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 403)
        Me.Controls.Add(Me.txtt_tt_nt)
        Me.Controls.Add(Me.txtt_tt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtt_tien_nt)
        Me.Controls.Add(Me.Txtt_tien)
        Me.Controls.Add(Me.btnluuandmoi)
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "000"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtden_ky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttu_ky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtso_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbbma_nt As System.Windows.Forms.ComboBox
    Friend WithEvents Txtngay_ct As ClsControl2.TxtDate
    Friend WithEvents btnluuandmoi As System.Windows.Forms.Button
    Friend WithEvents Txtty_gia As ClsControl2.TxtNumeric
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_nt As ClsControl2.TxtNumeric
    Friend WithEvents Txtt_tien As ClsControl2.TxtNumeric
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnam As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtden_ky As System.Windows.Forms.NumericUpDown
    Friend WithEvents txttu_ky As System.Windows.Forms.NumericUpDown
    Friend WithEvents btntao As System.Windows.Forms.Button
    Friend WithEvents btnkhaibao As System.Windows.Forms.Button
    Friend WithEvents txtt_tt_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_tt As ClsControl2.TxtNumeric
End Class