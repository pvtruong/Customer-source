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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ptinh_theo_tk = New System.Windows.Forms.Panel()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.chbkhong_am = New System.Windows.Forms.CheckBox()
        Me.cbbmcal = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbngoai_bang = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbbts_nv = New System.Windows.Forms.ComboBox()
        Me.chbbold = New System.Windows.Forms.CheckBox()
        Me.chbin_ck = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtthuyet_minh = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtchi_tieu2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtchi_tieu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtma_so = New System.Windows.Forms.TextBox()
        Me.Txtstt = New ClsControl2.TxtNumeric()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcach_tinh = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ptinh_theo_tk.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 370)
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
        Me.btnhuy.Location = New System.Drawing.Point(59, 370)
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
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ptinh_theo_tk)
        Me.GroupBox1.Controls.Add(Me.cbbmcal)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtcach_tinh)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 371)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Tag = "033"
        Me.Label11.Text = "Tai khoan"
        '
        'ptinh_theo_tk
        '
        Me.ptinh_theo_tk.Controls.Add(Me.txttk)
        Me.ptinh_theo_tk.Controls.Add(Me.chbkhong_am)
        Me.ptinh_theo_tk.Location = New System.Drawing.Point(115, 265)
        Me.ptinh_theo_tk.Name = "ptinh_theo_tk"
        Me.ptinh_theo_tk.Size = New System.Drawing.Size(489, 56)
        Me.ptinh_theo_tk.TabIndex = 4
        '
        'txttk
        '
        Me.txttk.Location = New System.Drawing.Point(11, 5)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(100, 20)
        Me.txttk.TabIndex = 0
        '
        'chbkhong_am
        '
        Me.chbkhong_am.AutoSize = True
        Me.chbkhong_am.Location = New System.Drawing.Point(11, 31)
        Me.chbkhong_am.Name = "chbkhong_am"
        Me.chbkhong_am.Size = New System.Drawing.Size(134, 17)
        Me.chbkhong_am.TabIndex = 2
        Me.chbkhong_am.Tag = "035"
        Me.chbkhong_am.Text = "chi lay gia tri khong am"
        Me.chbkhong_am.UseVisualStyleBackColor = True
        '
        'cbbmcal
        '
        Me.cbbmcal.FormattingEnabled = True
        Me.cbbmcal.Location = New System.Drawing.Point(126, 239)
        Me.cbbmcal.Name = "cbbmcal"
        Me.cbbmcal.Size = New System.Drawing.Size(468, 21)
        Me.cbbmcal.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chbngoai_bang)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cbbts_nv)
        Me.GroupBox2.Controls.Add(Me.chbbold)
        Me.GroupBox2.Controls.Add(Me.chbin_ck)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtthuyet_minh)
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
        Me.GroupBox2.Size = New System.Drawing.Size(621, 212)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'chbngoai_bang
        '
        Me.chbngoai_bang.AutoSize = True
        Me.chbngoai_bang.Location = New System.Drawing.Point(126, 144)
        Me.chbngoai_bang.Name = "chbngoai_bang"
        Me.chbngoai_bang.Size = New System.Drawing.Size(117, 17)
        Me.chbngoai_bang.TabIndex = 6
        Me.chbngoai_bang.Tag = "029"
        Me.chbngoai_bang.Text = "Chi tieu ngoai bang"
        Me.chbngoai_bang.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Tag = "028"
        Me.Label14.Text = "Phan loai"
        '
        'cbbts_nv
        '
        Me.cbbts_nv.FormattingEnabled = True
        Me.cbbts_nv.Location = New System.Drawing.Point(126, 117)
        Me.cbbts_nv.Name = "cbbts_nv"
        Me.cbbts_nv.Size = New System.Drawing.Size(468, 21)
        Me.cbbts_nv.TabIndex = 5
        '
        'chbbold
        '
        Me.chbbold.AutoSize = True
        Me.chbbold.Location = New System.Drawing.Point(126, 186)
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
        Me.chbin_ck.Location = New System.Drawing.Point(126, 163)
        Me.chbin_ck.Name = "chbin_ck"
        Me.chbin_ck.Size = New System.Drawing.Size(35, 17)
        Me.chbin_ck.TabIndex = 7
        Me.chbin_ck.Tag = "030"
        Me.chbin_ck.Text = "In"
        Me.chbin_ck.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Tag = "027"
        Me.Label9.Text = "Thuyet minh"
        '
        'txtthuyet_minh
        '
        Me.txtthuyet_minh.Location = New System.Drawing.Point(126, 93)
        Me.txtthuyet_minh.Name = "txtthuyet_minh"
        Me.txtthuyet_minh.Size = New System.Drawing.Size(100, 20)
        Me.txtthuyet_minh.TabIndex = 4
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
        Me.txtchi_tieu2.Location = New System.Drawing.Point(126, 68)
        Me.txtchi_tieu2.Name = "txtchi_tieu2"
        Me.txtchi_tieu2.Size = New System.Drawing.Size(468, 20)
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
        Me.txtchi_tieu.Location = New System.Drawing.Point(126, 44)
        Me.txtchi_tieu.Name = "txtchi_tieu"
        Me.txtchi_tieu.Size = New System.Drawing.Size(468, 20)
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
        Me.Txtstt.Location = New System.Drawing.Point(126, 19)
        Me.Txtstt.MaxLength = 18
        Me.Txtstt.Name = "Txtstt"
        Me.Txtstt.NumberDecimalDigits = 0
        Me.Txtstt.Size = New System.Drawing.Size(40, 20)
        Me.Txtstt.TabIndex = 0
        Me.Txtstt.Text = "0"
        Me.Txtstt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtstt.Value = 0R
        Me.Txtstt.Value2 = 0R
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
        Me.Label12.Location = New System.Drawing.Point(9, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Tag = "036"
        Me.Label12.Text = "Cong thuc"
        '
        'txtcach_tinh
        '
        Me.txtcach_tinh.Location = New System.Drawing.Point(126, 329)
        Me.txtcach_tinh.Name = "txtcach_tinh"
        Me.txtcach_tinh.Size = New System.Drawing.Size(468, 20)
        Me.txtcach_tinh.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 242)
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
        Me.ClientSize = New System.Drawing.Size(609, 406)
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtthuyet_minh As System.Windows.Forms.TextBox
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbbts_nv As System.Windows.Forms.ComboBox
    Friend WithEvents chbngoai_bang As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ptinh_theo_tk As System.Windows.Forms.Panel
    Friend WithEvents txttk As System.Windows.Forms.TextBox
    Friend WithEvents chbkhong_am As System.Windows.Forms.CheckBox
End Class
