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
        Me.txtma_dvcs = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chbdai_ly_yn = New System.Windows.Forms.CheckBox
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox
        Me.txtghi_chu = New System.Windows.Forms.TextBox
        Me.txtdia_chi = New System.Windows.Forms.TextBox
        Me.txtong_ba = New System.Windows.Forms.TextBox
        Me.txtten_kho2 = New System.Windows.Forms.TextBox
        Me.txtten_kho = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ten_dvcs = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtma_kho = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtma_dvcs
        '
        Me.txtma_dvcs.Enabled = False
        Me.txtma_dvcs.Location = New System.Drawing.Point(129, 12)
        Me.txtma_dvcs.Name = "txtma_dvcs"
        Me.txtma_dvcs.ReadOnly = True
        Me.txtma_dvcs.Size = New System.Drawing.Size(123, 20)
        Me.txtma_dvcs.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = "004"
        Me.Label2.Text = "Don vi"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 272)
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
        Me.btnhuy.Location = New System.Drawing.Point(59, 272)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 91
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chbdai_ly_yn)
        Me.GroupBox1.Controls.Add(Me.chbtrang_thai)
        Me.GroupBox1.Controls.Add(Me.txtghi_chu)
        Me.GroupBox1.Controls.Add(Me.txtdia_chi)
        Me.GroupBox1.Controls.Add(Me.txtong_ba)
        Me.GroupBox1.Controls.Add(Me.txtten_kho2)
        Me.GroupBox1.Controls.Add(Me.txtten_kho)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ten_dvcs)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtma_kho)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtma_dvcs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 266)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'chbdai_ly_yn
        '
        Me.chbdai_ly_yn.AutoSize = True
        Me.chbdai_ly_yn.Location = New System.Drawing.Point(129, 205)
        Me.chbdai_ly_yn.Name = "chbdai_ly_yn"
        Me.chbdai_ly_yn.Size = New System.Drawing.Size(71, 17)
        Me.chbdai_ly_yn.TabIndex = 7
        Me.chbdai_ly_yn.Tag = "009"
        Me.chbdai_ly_yn.Text = "kho dai ly"
        Me.chbdai_ly_yn.UseVisualStyleBackColor = True
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(129, 228)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(74, 17)
        Me.chbtrang_thai.TabIndex = 8
        Me.chbtrang_thai.Tag = "003"
        Me.chbtrang_thai.Text = "Trang thai"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'txtghi_chu
        '
        Me.txtghi_chu.Location = New System.Drawing.Point(129, 175)
        Me.txtghi_chu.Name = "txtghi_chu"
        Me.txtghi_chu.Size = New System.Drawing.Size(410, 20)
        Me.txtghi_chu.TabIndex = 6
        '
        'txtdia_chi
        '
        Me.txtdia_chi.Location = New System.Drawing.Point(129, 146)
        Me.txtdia_chi.Name = "txtdia_chi"
        Me.txtdia_chi.Size = New System.Drawing.Size(410, 20)
        Me.txtdia_chi.TabIndex = 5
        '
        'txtong_ba
        '
        Me.txtong_ba.Location = New System.Drawing.Point(129, 118)
        Me.txtong_ba.Name = "txtong_ba"
        Me.txtong_ba.Size = New System.Drawing.Size(410, 20)
        Me.txtong_ba.TabIndex = 4
        '
        'txtten_kho2
        '
        Me.txtten_kho2.Location = New System.Drawing.Point(129, 92)
        Me.txtten_kho2.Name = "txtten_kho2"
        Me.txtten_kho2.Size = New System.Drawing.Size(410, 20)
        Me.txtten_kho2.TabIndex = 3
        '
        'txtten_kho
        '
        Me.txtten_kho.Location = New System.Drawing.Point(129, 64)
        Me.txtten_kho.Name = "txtten_kho"
        Me.txtten_kho.Size = New System.Drawing.Size(410, 20)
        Me.txtten_kho.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Tag = "002"
        Me.Label10.Text = "Ten kho"
        '
        'ten_dvcs
        '
        Me.ten_dvcs.AutoSize = True
        Me.ten_dvcs.Location = New System.Drawing.Point(262, 15)
        Me.ten_dvcs.Name = "ten_dvcs"
        Me.ten_dvcs.Size = New System.Drawing.Size(54, 13)
        Me.ten_dvcs.TabIndex = 104
        Me.ten_dvcs.Text = "ten don vi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Tag = "008"
        Me.Label11.Text = "Ghi chu"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 98
        Me.Label12.Tag = "007"
        Me.Label12.Text = "Dia chi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Tag = "006"
        Me.Label7.Text = "Nguoi phu trach"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "005"
        Me.Label4.Text = "Ten kho 2"
        '
        'txtma_kho
        '
        Me.txtma_kho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_kho.Location = New System.Drawing.Point(129, 38)
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(123, 20)
        Me.txtma_kho.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "001"
        Me.Label1.Text = "Ma kho"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 309)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 309)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 309)
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
        Me.Label6.Location = New System.Drawing.Point(158, 309)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 324)
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
        Me.Label5.Location = New System.Drawing.Point(158, 324)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 324)
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
        Me.Label8.Location = New System.Drawing.Point(0, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 343)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtma_dvcs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents txtma_kho As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ten_dvcs As System.Windows.Forms.Label
    Friend WithEvents txtten_kho As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtten_kho2 As System.Windows.Forms.TextBox
    Friend WithEvents txtghi_chu As System.Windows.Forms.TextBox
    Friend WithEvents txtdia_chi As System.Windows.Forms.TextBox
    Friend WithEvents txtong_ba As System.Windows.Forms.TextBox
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents chbdai_ly_yn As System.Windows.Forms.CheckBox
End Class
