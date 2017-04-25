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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnguoi_tao = New System.Windows.Forms.Label()
        Me.txtngay_tao = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtngay_sua = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnguoi_sua = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabthong_tin_chinh = New System.Windows.Forms.TabPage()
        Me.ten_nh_phi1 = New System.Windows.Forms.Label()
        Me.txtnh_phi1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtten_phi2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtloai = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtma_phi = New System.Windows.Forms.TextBox()
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox()
        Me.txtten_phi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtghi_chu = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttk_cp = New System.Windows.Forms.TextBox()
        Me.txtdon_gia = New ClsControl2.TxtNumeric()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabthong_tin_chinh.SuspendLayout()
        CType(Me.txtloai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 226)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 90
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(59, 226)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 91
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 270)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 270)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 270)
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
        Me.Label6.Location = New System.Drawing.Point(158, 270)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 285)
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
        Me.Label5.Location = New System.Drawing.Point(158, 285)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 285)
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
        Me.Label8.Location = New System.Drawing.Point(0, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabthong_tin_chinh)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-4, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(499, 221)
        Me.TabControl1.TabIndex = 92
        '
        'tabthong_tin_chinh
        '
        Me.tabthong_tin_chinh.Controls.Add(Me.Label12)
        Me.tabthong_tin_chinh.Controls.Add(Me.txtdon_gia)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label11)
        Me.tabthong_tin_chinh.Controls.Add(Me.txttk_cp)
        Me.tabthong_tin_chinh.Controls.Add(Me.ten_nh_phi1)
        Me.tabthong_tin_chinh.Controls.Add(Me.txtnh_phi1)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label10)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label9)
        Me.tabthong_tin_chinh.Controls.Add(Me.txtten_phi2)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label7)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label4)
        Me.tabthong_tin_chinh.Controls.Add(Me.txtloai)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label2)
        Me.tabthong_tin_chinh.Controls.Add(Me.txtma_phi)
        Me.tabthong_tin_chinh.Controls.Add(Me.chbtrang_thai)
        Me.tabthong_tin_chinh.Controls.Add(Me.txtten_phi)
        Me.tabthong_tin_chinh.Controls.Add(Me.Label1)
        Me.tabthong_tin_chinh.Location = New System.Drawing.Point(4, 22)
        Me.tabthong_tin_chinh.Name = "tabthong_tin_chinh"
        Me.tabthong_tin_chinh.Padding = New System.Windows.Forms.Padding(3)
        Me.tabthong_tin_chinh.Size = New System.Drawing.Size(491, 195)
        Me.tabthong_tin_chinh.TabIndex = 0
        Me.tabthong_tin_chinh.Tag = "200"
        Me.tabthong_tin_chinh.Text = "TabPage1"
        Me.tabthong_tin_chinh.UseVisualStyleBackColor = True
        '
        'ten_nh_phi1
        '
        Me.ten_nh_phi1.AutoSize = True
        Me.ten_nh_phi1.Location = New System.Drawing.Point(286, 154)
        Me.ten_nh_phi1.Name = "ten_nh_phi1"
        Me.ten_nh_phi1.Size = New System.Drawing.Size(51, 13)
        Me.ten_nh_phi1.TabIndex = 24
        Me.ten_nh_phi1.Text = "ten nhom"
        '
        'txtnh_phi1
        '
        Me.txtnh_phi1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnh_phi1.Location = New System.Drawing.Point(162, 150)
        Me.txtnh_phi1.Name = "txtnh_phi1"
        Me.txtnh_phi1.Size = New System.Drawing.Size(117, 20)
        Me.txtnh_phi1.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Tag = "401"
        Me.Label10.Text = "Nhom phi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Tag = "006"
        Me.Label9.Text = "Ten 2"
        '
        'txtten_phi2
        '
        Me.txtten_phi2.Location = New System.Drawing.Point(162, 75)
        Me.txtten_phi2.Name = "txtten_phi2"
        Me.txtten_phi2.Size = New System.Drawing.Size(310, 20)
        Me.txtten_phi2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Tag = "400"
        Me.Label7.Text = "1-Doanh thu, 2- Chi phi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Tag = "005"
        Me.Label4.Text = "Loai"
        '
        'txtloai
        '
        Me.txtloai.Location = New System.Drawing.Point(162, 4)
        Me.txtloai.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtloai.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtloai.Name = "txtloai"
        Me.txtloai.Size = New System.Drawing.Size(43, 20)
        Me.txtloai.TabIndex = 0
        Me.txtloai.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Tag = "002"
        Me.Label2.Text = "Ten"
        '
        'txtma_phi
        '
        Me.txtma_phi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_phi.Location = New System.Drawing.Point(162, 27)
        Me.txtma_phi.Name = "txtma_phi"
        Me.txtma_phi.Size = New System.Drawing.Size(117, 20)
        Me.txtma_phi.TabIndex = 1
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(162, 173)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(74, 17)
        Me.chbtrang_thai.TabIndex = 7
        Me.chbtrang_thai.Tag = "003"
        Me.chbtrang_thai.Text = "Trang thai"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'txtten_phi
        '
        Me.txtten_phi.Location = New System.Drawing.Point(162, 51)
        Me.txtten_phi.Name = "txtten_phi"
        Me.txtten_phi.Size = New System.Drawing.Size(310, 20)
        Me.txtten_phi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "001"
        Me.Label1.Text = "Ma"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtghi_chu)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(491, 147)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "300"
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtghi_chu
        '
        Me.txtghi_chu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtghi_chu.Location = New System.Drawing.Point(3, 3)
        Me.txtghi_chu.Multiline = True
        Me.txtghi_chu.Name = "txtghi_chu"
        Me.txtghi_chu.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtghi_chu.Size = New System.Drawing.Size(485, 141)
        Me.txtghi_chu.TabIndex = 0
        Me.txtghi_chu.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Tag = ""
        Me.Label11.Text = "TK chi phí"
        '
        'txttk_cp
        '
        Me.txttk_cp.Location = New System.Drawing.Point(162, 99)
        Me.txttk_cp.Name = "txttk_cp"
        Me.txttk_cp.Size = New System.Drawing.Size(117, 20)
        Me.txttk_cp.TabIndex = 4
        '
        'txtdon_gia
        '
        Me.txtdon_gia.Location = New System.Drawing.Point(162, 124)
        Me.txtdon_gia.MaxLength = 18
        Me.txtdon_gia.Name = "txtdon_gia"
        Me.txtdon_gia.NumberDecimalDigits = 2
        Me.txtdon_gia.Size = New System.Drawing.Size(117, 20)
        Me.txtdon_gia.TabIndex = 5
        Me.txtdon_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtdon_gia.Value = 0R
        Me.txtdon_gia.Value2 = 0R
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Tag = ""
        Me.Label12.Text = "Đơn giá"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 304)
        Me.Controls.Add(Me.TabControl1)
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
        Me.Name = "frminput"
        Me.Tag = "004"
        Me.Text = "frminput"
        Me.TabControl1.ResumeLayout(False)
        Me.tabthong_tin_chinh.ResumeLayout(False)
        Me.tabthong_tin_chinh.PerformLayout()
        CType(Me.txtloai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_tao As System.Windows.Forms.Label
    Friend WithEvents txtngay_tao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtngay_sua As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_sua As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabthong_tin_chinh As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtma_phi As System.Windows.Forms.TextBox
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents txtten_phi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtloai As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtghi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtten_phi2 As System.Windows.Forms.TextBox
    Friend WithEvents ten_nh_phi1 As System.Windows.Forms.Label
    Friend WithEvents txtnh_phi1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtdon_gia As ClsControl2.TxtNumeric
    Friend WithEvents Label11 As Label
    Friend WithEvents txttk_cp As TextBox
End Class
