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
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtcach_tinh2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ptinh_theo_tk = New System.Windows.Forms.Panel
        Me.txtma_ct = New System.Windows.Forms.TextBox
        Me.txtma_hd = New System.Windows.Forms.TextBox
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.txtma_nv = New System.Windows.Forms.TextBox
        Me.txtma_dt = New System.Windows.Forms.TextBox
        Me.txtma_phi = New System.Windows.Forms.TextBox
        Me.txtma_bp = New System.Windows.Forms.TextBox
        Me.txttk_co = New System.Windows.Forms.TextBox
        Me.txttk_no = New System.Windows.Forms.TextBox
        Me.chbgiam_tru = New System.Windows.Forms.CheckBox
        Me.cbbmcal = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chbbold = New System.Windows.Forms.CheckBox
        Me.chbin_ck = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtchi_tieu2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtchi_tieu = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtma_so = New System.Windows.Forms.TextBox
        Me.Txtstt = New ClsControl2.TxtNumeric
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcach_tinh = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.ptinh_theo_tk.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 510)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 90
        Me.btnLuu.Tag = "037"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(59, 510)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 91
        Me.btnhuy.Tag = "038"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtcach_tinh2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ptinh_theo_tk)
        Me.GroupBox1.Controls.Add(Me.cbbmcal)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtcach_tinh)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 511)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 475)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 13)
        Me.Label16.TabIndex = 79
        Me.Label16.Tag = "400"
        Me.Label16.Text = "Công thức ngoại tệ"
        '
        'txtcach_tinh2
        '
        Me.txtcach_tinh2.Location = New System.Drawing.Point(137, 472)
        Me.txtcach_tinh2.Name = "txtcach_tinh2"
        Me.txtcach_tinh2.Size = New System.Drawing.Size(457, 20)
        Me.txtcach_tinh2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Tag = "406"
        Me.Label9.Text = "Mã chứng từ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 76
        Me.Label15.Tag = "405"
        Me.Label15.Text = "Mã hợp đồng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Tag = "404"
        Me.Label3.Text = "Mã khách hàng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Tag = "403"
        Me.Label6.Text = "Mã nhân viên"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Tag = "402"
        Me.Label8.Text = "Mã đối tượng/vụ việc"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Tag = "401"
        Me.Label13.Text = "Mã phí"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 259)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Tag = "400"
        Me.Label14.Text = "Mã bộ phận"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Tag = "035"
        Me.Label5.Text = "Tai khoan co"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Tag = "033"
        Me.Label11.Text = "Tai khoan no"
        '
        'ptinh_theo_tk
        '
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_ct)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_hd)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_kh)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_nv)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_dt)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_phi)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_bp)
        Me.ptinh_theo_tk.Controls.Add(Me.txttk_co)
        Me.ptinh_theo_tk.Controls.Add(Me.txttk_no)
        Me.ptinh_theo_tk.Controls.Add(Me.chbgiam_tru)
        Me.ptinh_theo_tk.Location = New System.Drawing.Point(126, 189)
        Me.ptinh_theo_tk.Name = "ptinh_theo_tk"
        Me.ptinh_theo_tk.Size = New System.Drawing.Size(478, 251)
        Me.ptinh_theo_tk.TabIndex = 4
        '
        'txtma_ct
        '
        Me.txtma_ct.Location = New System.Drawing.Point(11, 225)
        Me.txtma_ct.Name = "txtma_ct"
        Me.txtma_ct.Size = New System.Drawing.Size(407, 20)
        Me.txtma_ct.TabIndex = 9
        '
        'txtma_hd
        '
        Me.txtma_hd.Location = New System.Drawing.Point(11, 146)
        Me.txtma_hd.Name = "txtma_hd"
        Me.txtma_hd.Size = New System.Drawing.Size(407, 20)
        Me.txtma_hd.TabIndex = 6
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(11, 198)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(407, 20)
        Me.txtma_kh.TabIndex = 8
        '
        'txtma_nv
        '
        Me.txtma_nv.Location = New System.Drawing.Point(11, 172)
        Me.txtma_nv.Name = "txtma_nv"
        Me.txtma_nv.Size = New System.Drawing.Size(407, 20)
        Me.txtma_nv.TabIndex = 7
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(11, 121)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(407, 20)
        Me.txtma_dt.TabIndex = 5
        '
        'txtma_phi
        '
        Me.txtma_phi.Location = New System.Drawing.Point(11, 95)
        Me.txtma_phi.Name = "txtma_phi"
        Me.txtma_phi.Size = New System.Drawing.Size(407, 20)
        Me.txtma_phi.TabIndex = 4
        '
        'txtma_bp
        '
        Me.txtma_bp.Location = New System.Drawing.Point(11, 70)
        Me.txtma_bp.Name = "txtma_bp"
        Me.txtma_bp.Size = New System.Drawing.Size(407, 20)
        Me.txtma_bp.TabIndex = 3
        '
        'txttk_co
        '
        Me.txttk_co.Location = New System.Drawing.Point(11, 29)
        Me.txttk_co.Name = "txttk_co"
        Me.txttk_co.Size = New System.Drawing.Size(407, 20)
        Me.txttk_co.TabIndex = 1
        '
        'txttk_no
        '
        Me.txttk_no.Location = New System.Drawing.Point(11, 5)
        Me.txttk_no.Name = "txttk_no"
        Me.txttk_no.Size = New System.Drawing.Size(407, 20)
        Me.txttk_no.TabIndex = 0
        '
        'chbgiam_tru
        '
        Me.chbgiam_tru.AutoSize = True
        Me.chbgiam_tru.Location = New System.Drawing.Point(11, 53)
        Me.chbgiam_tru.Name = "chbgiam_tru"
        Me.chbgiam_tru.Size = New System.Drawing.Size(83, 17)
        Me.chbgiam_tru.TabIndex = 2
        Me.chbgiam_tru.Tag = "034"
        Me.chbgiam_tru.Text = "tinh giam tru"
        Me.chbgiam_tru.UseVisualStyleBackColor = True
        '
        'cbbmcal
        '
        Me.cbbmcal.FormattingEnabled = True
        Me.cbbmcal.Location = New System.Drawing.Point(137, 163)
        Me.cbbmcal.Name = "cbbmcal"
        Me.cbbmcal.Size = New System.Drawing.Size(457, 21)
        Me.cbbmcal.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chbbold)
        Me.GroupBox2.Controls.Add(Me.chbin_ck)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtchi_tieu2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtchi_tieu)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtma_so)
        Me.GroupBox2.Controls.Add(Me.Txtstt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 148)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'chbbold
        '
        Me.chbbold.AutoSize = True
        Me.chbbold.Location = New System.Drawing.Point(137, 118)
        Me.chbbold.Name = "chbbold"
        Me.chbbold.Size = New System.Drawing.Size(58, 17)
        Me.chbbold.TabIndex = 8
        Me.chbbold.Tag = "031"
        Me.chbbold.Text = "In dam"
        Me.chbbold.UseVisualStyleBackColor = True
        '
        'chbin_ck
        '
        Me.chbin_ck.AutoSize = True
        Me.chbin_ck.Location = New System.Drawing.Point(137, 95)
        Me.chbin_ck.Name = "chbin_ck"
        Me.chbin_ck.Size = New System.Drawing.Size(35, 17)
        Me.chbin_ck.TabIndex = 7
        Me.chbin_ck.Tag = "030"
        Me.chbin_ck.Text = "In"
        Me.chbin_ck.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Tag = "026"
        Me.Label7.Text = "chi tieu 2"
        '
        'txtchi_tieu2
        '
        Me.txtchi_tieu2.Location = New System.Drawing.Point(137, 68)
        Me.txtchi_tieu2.Name = "txtchi_tieu2"
        Me.txtchi_tieu2.Size = New System.Drawing.Size(457, 20)
        Me.txtchi_tieu2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Tag = "025"
        Me.Label4.Text = "Chi tieu"
        '
        'txtchi_tieu
        '
        Me.txtchi_tieu.Location = New System.Drawing.Point(137, 44)
        Me.txtchi_tieu.Name = "txtchi_tieu"
        Me.txtchi_tieu.Size = New System.Drawing.Size(457, 20)
        Me.txtchi_tieu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Tag = "024"
        Me.Label2.Text = "ma so"
        '
        'txtma_so
        '
        Me.txtma_so.Location = New System.Drawing.Point(253, 19)
        Me.txtma_so.Name = "txtma_so"
        Me.txtma_so.Size = New System.Drawing.Size(100, 20)
        Me.txtma_so.TabIndex = 1
        '
        'Txtstt
        '
        Me.Txtstt.Location = New System.Drawing.Point(137, 19)
        Me.Txtstt.MaxLength = 18
        Me.Txtstt.Name = "Txtstt"
        Me.Txtstt.NumberDecimalDigits = 0
        Me.Txtstt.Size = New System.Drawing.Size(29, 20)
        Me.Txtstt.TabIndex = 0
        Me.Txtstt.Text = "0"
        Me.Txtstt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtstt.Value = 0
        Me.Txtstt.Value2 = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "023"
        Me.Label1.Text = "Stt"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 449)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Tag = "036"
        Me.Label12.Text = "Cong thuc"
        '
        'txtcach_tinh
        '
        Me.txtcach_tinh.Location = New System.Drawing.Point(137, 446)
        Me.txtcach_tinh.Name = "txtcach_tinh"
        Me.txtcach_tinh.Size = New System.Drawing.Size(457, 20)
        Me.txtcach_tinh.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Tag = "032"
        Me.Label10.Text = "PP tính"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 546)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "022"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ptinh_theo_tk.ResumeLayout(False)
        Me.ptinh_theo_tk.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtstt As ClsControl2.TxtNumeric
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtchi_tieu2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtchi_tieu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtma_so As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcach_tinh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chbbold As System.Windows.Forms.CheckBox
    Friend WithEvents chbin_ck As System.Windows.Forms.CheckBox
    Friend WithEvents cbbmcal As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ptinh_theo_tk As System.Windows.Forms.Panel
    Friend WithEvents txttk_no As System.Windows.Forms.TextBox
    Friend WithEvents chbgiam_tru As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttk_co As System.Windows.Forms.TextBox
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents txtma_nv As System.Windows.Forms.TextBox
    Friend WithEvents txtma_dt As System.Windows.Forms.TextBox
    Friend WithEvents txtma_phi As System.Windows.Forms.TextBox
    Friend WithEvents txtma_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtma_hd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtma_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcach_tinh2 As System.Windows.Forms.TextBox
End Class
