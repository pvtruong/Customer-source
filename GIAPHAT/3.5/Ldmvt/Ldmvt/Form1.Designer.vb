<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnfile = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbllines = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripmain = New System.Windows.Forms.ToolStrip
        Me.ToolStripfind = New System.Windows.Forms.ToolStrip
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grd = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.thong_tin_chung = New System.Windows.Forms.TabPage
        Me.chbvt_ton_kho = New System.Windows.Forms.CheckBox
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ImgImage = New ClsControl2.imgPictureBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtma_thue = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbbgia_ton = New System.Windows.Forms.ComboBox
        Me.txtloai_vt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnh_vt3 = New System.Windows.Forms.TextBox
        Me.txtnh_vt2 = New System.Windows.Forms.TextBox
        Me.txtma_vt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnh_vt1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtma_dvt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtten_vt2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtten_vt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.thong_tin_pha_tich = New System.Windows.Forms.TabPage
        Me.txttk_dl = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.chbsua_tk_vt = New System.Windows.Forms.CheckBox
        Me.txttk_cl_gv = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txttk_tl = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txttk_spdd = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txttk_ck = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txttk_dt = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txttk_gv = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txttk_vt = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.thong_tin_gd = New System.Windows.Forms.TabPage
        Me.gridgd = New System.Windows.Forms.DataGridView
        Me.bar_qddvt = New System.Windows.Forms.ToolStrip
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.thong_tin_chung.SuspendLayout()
        CType(Me.ImgImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thong_tin_pha_tich.SuspendLayout()
        Me.thong_tin_gd.SuspendLayout()
        CType(Me.gridgd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnfile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnfile
        '
        Me.mnfile.Name = "mnfile"
        Me.mnfile.Size = New System.Drawing.Size(77, 20)
        Me.mnfile.Tag = "100"
        Me.mnfile.Text = "Chuc nang"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbluser, Me.ToolStripStatusLabel1, Me.lbllines})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1040, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(29, 17)
        Me.lbluser.Text = "user"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(996, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'lbllines
        '
        Me.lbllines.Name = "lbllines"
        Me.lbllines.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripmain
        '
        Me.ToolStripmain.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripmain.Name = "ToolStripmain"
        Me.ToolStripmain.Size = New System.Drawing.Size(1040, 25)
        Me.ToolStripmain.TabIndex = 2
        Me.ToolStripmain.Text = "ToolStrip1"
        '
        'ToolStripfind
        '
        Me.ToolStripfind.Location = New System.Drawing.Point(0, 49)
        Me.ToolStripfind.Name = "ToolStripfind"
        Me.ToolStripfind.Size = New System.Drawing.Size(1040, 25)
        Me.ToolStripfind.TabIndex = 3
        Me.ToolStripfind.Text = "ToolStrip2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 74)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1040, 444)
        Me.SplitContainer1.SplitterDistance = 346
        Me.SplitContainer1.TabIndex = 6
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.GridColor = System.Drawing.SystemColors.Control
        Me.grd.Location = New System.Drawing.Point(0, 0)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd.Size = New System.Drawing.Size(346, 444)
        Me.grd.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.thong_tin_chung)
        Me.TabControl1.Controls.Add(Me.thong_tin_pha_tich)
        Me.TabControl1.Controls.Add(Me.thong_tin_gd)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(688, 443)
        Me.TabControl1.TabIndex = 23
        '
        'thong_tin_chung
        '
        Me.thong_tin_chung.AutoScroll = True
        Me.thong_tin_chung.BackColor = System.Drawing.Color.White
        Me.thong_tin_chung.Controls.Add(Me.chbvt_ton_kho)
        Me.thong_tin_chung.Controls.Add(Me.chbtrang_thai)
        Me.thong_tin_chung.Controls.Add(Me.Label13)
        Me.thong_tin_chung.Controls.Add(Me.ImgImage)
        Me.thong_tin_chung.Controls.Add(Me.Label24)
        Me.thong_tin_chung.Controls.Add(Me.txtma_thue)
        Me.thong_tin_chung.Controls.Add(Me.Label12)
        Me.thong_tin_chung.Controls.Add(Me.cbbgia_ton)
        Me.thong_tin_chung.Controls.Add(Me.txtloai_vt)
        Me.thong_tin_chung.Controls.Add(Me.Label10)
        Me.thong_tin_chung.Controls.Add(Me.Label4)
        Me.thong_tin_chung.Controls.Add(Me.Label1)
        Me.thong_tin_chung.Controls.Add(Me.txtnh_vt3)
        Me.thong_tin_chung.Controls.Add(Me.txtnh_vt2)
        Me.thong_tin_chung.Controls.Add(Me.txtma_vt)
        Me.thong_tin_chung.Controls.Add(Me.Label2)
        Me.thong_tin_chung.Controls.Add(Me.txtnh_vt1)
        Me.thong_tin_chung.Controls.Add(Me.Label18)
        Me.thong_tin_chung.Controls.Add(Me.txtma_dvt)
        Me.thong_tin_chung.Controls.Add(Me.Label14)
        Me.thong_tin_chung.Controls.Add(Me.txtten_vt2)
        Me.thong_tin_chung.Controls.Add(Me.Label11)
        Me.thong_tin_chung.Controls.Add(Me.txtten_vt)
        Me.thong_tin_chung.Controls.Add(Me.Label7)
        Me.thong_tin_chung.Location = New System.Drawing.Point(4, 22)
        Me.thong_tin_chung.Name = "thong_tin_chung"
        Me.thong_tin_chung.Padding = New System.Windows.Forms.Padding(3)
        Me.thong_tin_chung.Size = New System.Drawing.Size(680, 417)
        Me.thong_tin_chung.TabIndex = 0
        Me.thong_tin_chung.Tag = "115"
        Me.thong_tin_chung.Text = "Thông tin chính"
        '
        'chbvt_ton_kho
        '
        Me.chbvt_ton_kho.AutoSize = True
        Me.chbvt_ton_kho.Location = New System.Drawing.Point(157, 274)
        Me.chbvt_ton_kho.Name = "chbvt_ton_kho"
        Me.chbvt_ton_kho.Size = New System.Drawing.Size(98, 17)
        Me.chbvt_ton_kho.TabIndex = 182
        Me.chbvt_ton_kho.Tag = "109"
        Me.chbvt_ton_kho.Text = "Theo doi vat tu"
        Me.chbvt_ton_kho.UseVisualStyleBackColor = True
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(157, 302)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(74, 17)
        Me.chbtrang_thai.TabIndex = 183
        Me.chbtrang_thai.Tag = "008"
        Me.chbtrang_thai.Text = "Trang thai"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(409, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 180
        Me.Label13.Tag = "029"
        Me.Label13.Text = "Hinh vat tu"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgImage
        '
        Me.ImgImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgImage.Buffer = Nothing
        Me.ImgImage.Location = New System.Drawing.Point(333, 108)
        Me.ImgImage.Name = "ImgImage"
        Me.ImgImage.Size = New System.Drawing.Size(202, 124)
        Me.ImgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgImage.TabIndex = 179
        Me.ImgImage.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 177
        Me.Label24.Tag = "022"
        Me.Label24.Text = "Ma thue"
        '
        'txtma_thue
        '
        Me.txtma_thue.Location = New System.Drawing.Point(157, 234)
        Me.txtma_thue.Name = "txtma_thue"
        Me.txtma_thue.Size = New System.Drawing.Size(100, 20)
        Me.txtma_thue.TabIndex = 176
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 175
        Me.Label12.Tag = "118"
        Me.Label12.Text = "PP tinh gia TB"
        '
        'cbbgia_ton
        '
        Me.cbbgia_ton.FormattingEnabled = True
        Me.cbbgia_ton.Location = New System.Drawing.Point(157, 78)
        Me.cbbgia_ton.Name = "cbbgia_ton"
        Me.cbbgia_ton.Size = New System.Drawing.Size(378, 21)
        Me.cbbgia_ton.TabIndex = 154
        '
        'txtloai_vt
        '
        Me.txtloai_vt.Location = New System.Drawing.Point(157, 130)
        Me.txtloai_vt.Name = "txtloai_vt"
        Me.txtloai_vt.Size = New System.Drawing.Size(100, 20)
        Me.txtloai_vt.TabIndex = 156
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Tag = "105"
        Me.Label10.Text = "loai vt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 168
        Me.Label4.Tag = "108"
        Me.Label4.Text = "nhom 3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 167
        Me.Label1.Tag = "107"
        Me.Label1.Text = "nhom 2"
        '
        'txtnh_vt3
        '
        Me.txtnh_vt3.Location = New System.Drawing.Point(157, 208)
        Me.txtnh_vt3.Name = "txtnh_vt3"
        Me.txtnh_vt3.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_vt3.TabIndex = 159
        '
        'txtnh_vt2
        '
        Me.txtnh_vt2.Location = New System.Drawing.Point(157, 182)
        Me.txtnh_vt2.Name = "txtnh_vt2"
        Me.txtnh_vt2.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_vt2.TabIndex = 158
        '
        'txtma_vt
        '
        Me.txtma_vt.Location = New System.Drawing.Point(157, 4)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_vt.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 166
        Me.Label2.Tag = "001"
        Me.Label2.Text = "Ma vat tu"
        '
        'txtnh_vt1
        '
        Me.txtnh_vt1.Location = New System.Drawing.Point(157, 156)
        Me.txtnh_vt1.Name = "txtnh_vt1"
        Me.txtnh_vt1.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_vt1.TabIndex = 157
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 165
        Me.Label18.Tag = "106"
        Me.Label18.Text = "nhom 1"
        '
        'txtma_dvt
        '
        Me.txtma_dvt.Location = New System.Drawing.Point(157, 104)
        Me.txtma_dvt.Name = "txtma_dvt"
        Me.txtma_dvt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_dvt.TabIndex = 155
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 164
        Me.Label14.Tag = "004"
        Me.Label14.Text = "dvt chuan"
        '
        'txtten_vt2
        '
        Me.txtten_vt2.Location = New System.Drawing.Point(157, 54)
        Me.txtten_vt2.Name = "txtten_vt2"
        Me.txtten_vt2.Size = New System.Drawing.Size(378, 20)
        Me.txtten_vt2.TabIndex = 153
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 163
        Me.Label11.Tag = "003"
        Me.Label11.Text = "Ten vt2"
        '
        'txtten_vt
        '
        Me.txtten_vt.Location = New System.Drawing.Point(157, 29)
        Me.txtten_vt.Name = "txtten_vt"
        Me.txtten_vt.Size = New System.Drawing.Size(378, 20)
        Me.txtten_vt.TabIndex = 152
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 162
        Me.Label7.Tag = "002"
        Me.Label7.Text = "Ten vt"
        '
        'thong_tin_pha_tich
        '
        Me.thong_tin_pha_tich.BackColor = System.Drawing.Color.White
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_dl)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label23)
        Me.thong_tin_pha_tich.Controls.Add(Me.chbsua_tk_vt)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_cl_gv)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label17)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_tl)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label16)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_spdd)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label9)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_ck)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label19)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_dt)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label20)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_gv)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label21)
        Me.thong_tin_pha_tich.Controls.Add(Me.txttk_vt)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label22)
        Me.thong_tin_pha_tich.Location = New System.Drawing.Point(4, 22)
        Me.thong_tin_pha_tich.Name = "thong_tin_pha_tich"
        Me.thong_tin_pha_tich.Size = New System.Drawing.Size(680, 417)
        Me.thong_tin_pha_tich.TabIndex = 2
        Me.thong_tin_pha_tich.Tag = "116"
        Me.thong_tin_pha_tich.Text = "TK"
        '
        'txttk_dl
        '
        Me.txttk_dl.Location = New System.Drawing.Point(127, 208)
        Me.txttk_dl.Name = "txttk_dl"
        Me.txttk_dl.Size = New System.Drawing.Size(100, 20)
        Me.txttk_dl.TabIndex = 157
        Me.txttk_dl.Tag = "020"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 212)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 158
        Me.Label23.Tag = "021"
        Me.Label23.Text = "tk dai ly"
        '
        'chbsua_tk_vt
        '
        Me.chbsua_tk_vt.AutoSize = True
        Me.chbsua_tk_vt.Location = New System.Drawing.Point(127, 33)
        Me.chbsua_tk_vt.Name = "chbsua_tk_vt"
        Me.chbsua_tk_vt.Size = New System.Drawing.Size(82, 17)
        Me.chbsua_tk_vt.TabIndex = 144
        Me.chbsua_tk_vt.Tag = "018"
        Me.chbsua_tk_vt.Text = "sua tk va tu"
        Me.chbsua_tk_vt.UseVisualStyleBackColor = True
        '
        'txttk_cl_gv
        '
        Me.txttk_cl_gv.Location = New System.Drawing.Point(127, 185)
        Me.txttk_cl_gv.Name = "txttk_cl_gv"
        Me.txttk_cl_gv.Size = New System.Drawing.Size(100, 20)
        Me.txttk_cl_gv.TabIndex = 154
        Me.txttk_cl_gv.Tag = "020"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 156
        Me.Label17.Tag = "020"
        Me.Label17.Text = "tk cl gia von"
        '
        'txttk_tl
        '
        Me.txttk_tl.Location = New System.Drawing.Point(127, 161)
        Me.txttk_tl.Name = "txttk_tl"
        Me.txttk_tl.Size = New System.Drawing.Size(100, 20)
        Me.txttk_tl.TabIndex = 153
        Me.txttk_tl.Tag = "019"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 155
        Me.Label16.Tag = "019"
        Me.Label16.Text = "tk tra lai"
        '
        'txttk_spdd
        '
        Me.txttk_spdd.Location = New System.Drawing.Point(127, 135)
        Me.txttk_spdd.Name = "txttk_spdd"
        Me.txttk_spdd.Size = New System.Drawing.Size(100, 20)
        Me.txttk_spdd.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 152
        Me.Label9.Tag = "114"
        Me.Label9.Text = "tk spdd"
        '
        'txttk_ck
        '
        Me.txttk_ck.Location = New System.Drawing.Point(127, 109)
        Me.txttk_ck.Name = "txttk_ck"
        Me.txttk_ck.Size = New System.Drawing.Size(100, 20)
        Me.txttk_ck.TabIndex = 149
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 150
        Me.Label19.Tag = "113"
        Me.Label19.Text = "Tk CK"
        '
        'txttk_dt
        '
        Me.txttk_dt.Location = New System.Drawing.Point(127, 83)
        Me.txttk_dt.Name = "txttk_dt"
        Me.txttk_dt.Size = New System.Drawing.Size(100, 20)
        Me.txttk_dt.TabIndex = 147
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 148
        Me.Label20.Tag = "112"
        Me.Label20.Text = "TK dt"
        '
        'txttk_gv
        '
        Me.txttk_gv.Location = New System.Drawing.Point(127, 57)
        Me.txttk_gv.Name = "txttk_gv"
        Me.txttk_gv.Size = New System.Drawing.Size(100, 20)
        Me.txttk_gv.TabIndex = 145
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 61)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 146
        Me.Label21.Tag = "111"
        Me.Label21.Text = "TK gv"
        '
        'txttk_vt
        '
        Me.txttk_vt.Location = New System.Drawing.Point(127, 7)
        Me.txttk_vt.Name = "txttk_vt"
        Me.txttk_vt.Size = New System.Drawing.Size(100, 20)
        Me.txttk_vt.TabIndex = 143
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 13)
        Me.Label22.TabIndex = 144
        Me.Label22.Tag = "110"
        Me.Label22.Text = "TK vt"
        '
        'thong_tin_gd
        '
        Me.thong_tin_gd.Controls.Add(Me.gridgd)
        Me.thong_tin_gd.Controls.Add(Me.bar_qddvt)
        Me.thong_tin_gd.Location = New System.Drawing.Point(4, 22)
        Me.thong_tin_gd.Name = "thong_tin_gd"
        Me.thong_tin_gd.Size = New System.Drawing.Size(680, 417)
        Me.thong_tin_gd.TabIndex = 4
        Me.thong_tin_gd.Tag = "117"
        Me.thong_tin_gd.Text = "dvt qd"
        Me.thong_tin_gd.UseVisualStyleBackColor = True
        '
        'gridgd
        '
        Me.gridgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridgd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridgd.Location = New System.Drawing.Point(0, 25)
        Me.gridgd.Name = "gridgd"
        Me.gridgd.Size = New System.Drawing.Size(680, 392)
        Me.gridgd.TabIndex = 2
        '
        'bar_qddvt
        '
        Me.bar_qddvt.Location = New System.Drawing.Point(0, 0)
        Me.bar_qddvt.Name = "bar_qddvt"
        Me.bar_qddvt.Size = New System.Drawing.Size(680, 25)
        Me.bar_qddvt.TabIndex = 1
        Me.bar_qddvt.Text = "ToolStrip1"
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 540)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStripfind)
        Me.Controls.Add(Me.ToolStripmain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "Danh mục khách hàng"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.thong_tin_chung.ResumeLayout(False)
        Me.thong_tin_chung.PerformLayout()
        CType(Me.ImgImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thong_tin_pha_tich.ResumeLayout(False)
        Me.thong_tin_pha_tich.PerformLayout()
        Me.thong_tin_gd.ResumeLayout(False)
        Me.thong_tin_gd.PerformLayout()
        CType(Me.gridgd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripmain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripfind As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents thong_tin_chung As System.Windows.Forms.TabPage
    Friend WithEvents thong_tin_pha_tich As System.Windows.Forms.TabPage
    Friend WithEvents thong_tin_gd As System.Windows.Forms.TabPage
    Friend WithEvents gridgd As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbllines As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txttk_spdd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttk_ck As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txttk_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txttk_gv As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txttk_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbbgia_ton As System.Windows.Forms.ComboBox
    Friend WithEvents txtloai_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnh_vt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtnh_vt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnh_vt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtma_dvt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtten_vt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtten_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttk_cl_gv As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txttk_tl As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chbsua_tk_vt As System.Windows.Forms.CheckBox
    Friend WithEvents txttk_dl As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtma_thue As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ImgImage As ClsControl2.imgPictureBox
    Friend WithEvents chbvt_ton_kho As System.Windows.Forms.CheckBox
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents bar_qddvt As System.Windows.Forms.ToolStrip



End Class
