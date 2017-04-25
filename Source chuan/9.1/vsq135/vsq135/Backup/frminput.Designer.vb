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
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ma_bp = New System.Windows.Forms.Label
        Me.txtdia_chi_giao = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Txtngay_giao = New ClsControl2.TxtDate
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabother = New System.Windows.Forms.TabPage
        Me.txtghi_chu5 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtghi_chu4 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtghi_chu3 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtghi_chu2 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtghi_chu1 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cbbma_gd = New System.Windows.Forms.ComboBox
        Me.cbbstatus = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtngay_ct = New ClsControl2.TxtDate
        Me.ten_kh = New System.Windows.Forms.Label
        Me.txtdien_giai = New System.Windows.Forms.TextBox
        Me.txtong_ba = New System.Windows.Forms.TextBox
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
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
        Me.Label25 = New System.Windows.Forms.Label
        Me.Txtt_sl = New ClsControl2.TxtNumeric
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabother.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 379)
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
        Me.btnhuy.Location = New System.Drawing.Point(173, 379)
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
        Me.GroupBox1.Controls.Add(Me.ma_bp)
        Me.GroupBox1.Controls.Add(Me.txtdia_chi_giao)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Txtngay_giao)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Txtngay_ct)
        Me.GroupBox1.Controls.Add(Me.ten_kh)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.txtong_ba)
        Me.GroupBox1.Controls.Add(Me.txtma_kh)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtso_ct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, -9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 365)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ma_bp
        '
        Me.ma_bp.AutoSize = True
        Me.ma_bp.Location = New System.Drawing.Point(499, 83)
        Me.ma_bp.Name = "ma_bp"
        Me.ma_bp.Size = New System.Drawing.Size(80, 13)
        Me.ma_bp.TabIndex = 227
        Me.ma_bp.Tag = "035"
        Me.ma_bp.Text = "Nguoi dat hang"
        '
        'txtdia_chi_giao
        '
        Me.txtdia_chi_giao.Location = New System.Drawing.Point(126, 102)
        Me.txtdia_chi_giao.Name = "txtdia_chi_giao"
        Me.txtdia_chi_giao.Size = New System.Drawing.Size(306, 20)
        Me.txtdia_chi_giao.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 219
        Me.Label21.Tag = "034"
        Me.Label21.Text = "Nơi giao"
        '
        'Txtngay_giao
        '
        Me.Txtngay_giao.Location = New System.Drawing.Point(126, 79)
        Me.Txtngay_giao.Mask = "00/00/0000"
        Me.Txtngay_giao.Name = "Txtngay_giao"
        Me.Txtngay_giao.Size = New System.Drawing.Size(100, 20)
        Me.Txtngay_giao.TabIndex = 2
        Me.Txtngay_giao.Text = "01011910"
        Me.Txtngay_giao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_giao.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 217
        Me.Label20.Tag = "033"
        Me.Label20.Text = "ngay giao"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabother)
        Me.TabControl1.Location = New System.Drawing.Point(6, 167)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(908, 192)
        Me.TabControl1.TabIndex = 211
        Me.TabControl1.TabStop = False
        '
        'tabother
        '
        Me.tabother.Controls.Add(Me.txtghi_chu5)
        Me.tabother.Controls.Add(Me.Label28)
        Me.tabother.Controls.Add(Me.txtghi_chu4)
        Me.tabother.Controls.Add(Me.Label27)
        Me.tabother.Controls.Add(Me.txtghi_chu3)
        Me.tabother.Controls.Add(Me.Label26)
        Me.tabother.Controls.Add(Me.txtghi_chu2)
        Me.tabother.Controls.Add(Me.Label24)
        Me.tabother.Controls.Add(Me.txtghi_chu1)
        Me.tabother.Controls.Add(Me.Label23)
        Me.tabother.Location = New System.Drawing.Point(4, 22)
        Me.tabother.Name = "tabother"
        Me.tabother.Size = New System.Drawing.Size(900, 166)
        Me.tabother.TabIndex = 1
        Me.tabother.Tag = "009"
        Me.tabother.Text = "thong tin khac"
        Me.tabother.UseVisualStyleBackColor = True
        '
        'txtghi_chu5
        '
        Me.txtghi_chu5.Location = New System.Drawing.Point(99, 102)
        Me.txtghi_chu5.Name = "txtghi_chu5"
        Me.txtghi_chu5.Size = New System.Drawing.Size(556, 20)
        Me.txtghi_chu5.TabIndex = 235
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(5, 105)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 13)
        Me.Label28.TabIndex = 236
        Me.Label28.Tag = "405"
        Me.Label28.Text = "Ghi chu 5"
        '
        'txtghi_chu4
        '
        Me.txtghi_chu4.Location = New System.Drawing.Point(99, 79)
        Me.txtghi_chu4.Name = "txtghi_chu4"
        Me.txtghi_chu4.Size = New System.Drawing.Size(556, 20)
        Me.txtghi_chu4.TabIndex = 233
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 82)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 234
        Me.Label27.Tag = "207"
        Me.Label27.Text = "Ghi chu 4"
        '
        'txtghi_chu3
        '
        Me.txtghi_chu3.Location = New System.Drawing.Point(99, 55)
        Me.txtghi_chu3.Name = "txtghi_chu3"
        Me.txtghi_chu3.Size = New System.Drawing.Size(556, 20)
        Me.txtghi_chu3.TabIndex = 231
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 232
        Me.Label26.Tag = "208"
        Me.Label26.Text = "Ghi chu 3"
        '
        'txtghi_chu2
        '
        Me.txtghi_chu2.Location = New System.Drawing.Point(99, 32)
        Me.txtghi_chu2.Name = "txtghi_chu2"
        Me.txtghi_chu2.Size = New System.Drawing.Size(556, 20)
        Me.txtghi_chu2.TabIndex = 229
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 230
        Me.Label24.Tag = "411"
        Me.Label24.Text = "Ghi chu 2"
        '
        'txtghi_chu1
        '
        Me.txtghi_chu1.Location = New System.Drawing.Point(99, 9)
        Me.txtghi_chu1.Name = "txtghi_chu1"
        Me.txtghi_chu1.Size = New System.Drawing.Size(556, 20)
        Me.txtghi_chu1.TabIndex = 227
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 228
        Me.Label23.Tag = "401"
        Me.Label23.Text = "Ghi chu 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cbbma_gd)
        Me.GroupBox3.Controls.Add(Me.cbbstatus)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(917, 48)
        Me.GroupBox3.TabIndex = 210
        Me.GroupBox3.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 23)
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
        Me.cbbma_gd.Location = New System.Drawing.Point(134, 19)
        Me.cbbma_gd.Name = "cbbma_gd"
        Me.cbbma_gd.Size = New System.Drawing.Size(333, 21)
        Me.cbbma_gd.TabIndex = 205
        Me.cbbma_gd.TabStop = False
        '
        'cbbstatus
        '
        Me.cbbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbstatus.FormattingEnabled = True
        Me.cbbstatus.Location = New System.Drawing.Point(639, 19)
        Me.cbbstatus.Name = "cbbstatus"
        Me.cbbstatus.Size = New System.Drawing.Size(273, 21)
        Me.cbbstatus.TabIndex = 10
        Me.cbbstatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(519, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Tag = "303"
        Me.Label12.Text = "trang thai"
        '
        'Txtngay_ct
        '
        Me.Txtngay_ct.Location = New System.Drawing.Point(332, 56)
        Me.Txtngay_ct.Mask = "00/00/0000"
        Me.Txtngay_ct.Name = "Txtngay_ct"
        Me.Txtngay_ct.Size = New System.Drawing.Size(100, 20)
        Me.Txtngay_ct.TabIndex = 1
        Me.Txtngay_ct.Text = "01011910"
        Me.Txtngay_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_ct.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'ten_kh
        '
        Me.ten_kh.AutoSize = True
        Me.ten_kh.Location = New System.Drawing.Point(719, 60)
        Me.ten_kh.Name = "ten_kh"
        Me.ten_kh.Size = New System.Drawing.Size(82, 13)
        Me.ten_kh.TabIndex = 226
        Me.ten_kh.Text = "ten khach hang"
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(126, 125)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(306, 20)
        Me.txtdien_giai.TabIndex = 4
        '
        'txtong_ba
        '
        Me.txtong_ba.Location = New System.Drawing.Point(615, 79)
        Me.txtong_ba.MaxLength = 32
        Me.txtong_ba.Name = "txtong_ba"
        Me.txtong_ba.Size = New System.Drawing.Size(290, 20)
        Me.txtong_ba.TabIndex = 8
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(615, 56)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(100, 20)
        Me.txtma_kh.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(499, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 225
        Me.Label22.Tag = "216"
        Me.Label22.Text = "Don vi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "214"
        Me.Label7.Text = "Dien giai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "221"
        Me.Label2.Text = "ngay ct"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(126, 56)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 60)
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
        Me.Label3.Location = New System.Drawing.Point(0, 427)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 427)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 427)
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
        Me.Label6.Location = New System.Drawing.Point(158, 427)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 442)
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
        Me.Label5.Location = New System.Drawing.Point(158, 442)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 442)
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
        Me.Label8.Location = New System.Drawing.Point(0, 442)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'btnluuandmoi
        '
        Me.btnluuandmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnluuandmoi.Location = New System.Drawing.Point(87, 379)
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
        Me.Label25.Location = New System.Drawing.Point(307, 386)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 13)
        Me.Label25.TabIndex = 211
        Me.Label25.Tag = "418"
        Me.Label25.Text = "Tong so luong"
        '
        'Txtt_sl
        '
        Me.Txtt_sl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_sl.Location = New System.Drawing.Point(388, 382)
        Me.Txtt_sl.MaxLength = 0
        Me.Txtt_sl.Name = "Txtt_sl"
        Me.Txtt_sl.NumberDecimalDigits = 2
        Me.Txtt_sl.ReadOnly = True
        Me.Txtt_sl.Size = New System.Drawing.Size(129, 20)
        Me.Txtt_sl.TabIndex = 210
        Me.Txtt_sl.TabStop = False
        Me.Txtt_sl.Text = "0.00"
        Me.Txtt_sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_sl.Value = 0
        Me.Txtt_sl.Value2 = 0
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 461)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Txtt_sl)
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
        Me.TabControl1.ResumeLayout(False)
        Me.tabother.ResumeLayout(False)
        Me.tabother.PerformLayout()
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
    Friend WithEvents Txtngay_ct As ClsControl2.TxtDate
    Friend WithEvents btnluuandmoi As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txtt_sl As ClsControl2.TxtNumeric
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbbma_gd As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabother As System.Windows.Forms.TabPage
    Friend WithEvents txtdia_chi_giao As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txtngay_giao As ClsControl2.TxtDate
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtghi_chu5 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtghi_chu4 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtghi_chu3 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtghi_chu2 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtghi_chu1 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ten_kh As System.Windows.Forms.Label
    Friend WithEvents ma_bp As System.Windows.Forms.Label
    Friend WithEvents txtong_ba As System.Windows.Forms.TextBox
End Class
