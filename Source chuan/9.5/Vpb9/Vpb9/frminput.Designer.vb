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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Txtngay_ct = New ClsControl2.TxtDate()
        Me.txtdien_giai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtso_ct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbstatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Txtt_tien_nt = New ClsControl2.TxtNumeric()
        Me.Txtt_tien = New ClsControl2.TxtNumeric()
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txttk_dt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 298)
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
        Me.btnhuy.Location = New System.Drawing.Point(173, 298)
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
        Me.GroupBox1.Controls.Add(Me.txttk_dt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Txtngay_ct)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtso_ct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 263)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(9, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 183)
        Me.TabControl1.TabIndex = 19
        Me.TabControl1.TabStop = False
        '
        'Txtngay_ct
        '
        Me.Txtngay_ct.Location = New System.Drawing.Point(299, 20)
        Me.Txtngay_ct.Mask = "00/00/0000"
        Me.Txtngay_ct.Name = "Txtngay_ct"
        Me.Txtngay_ct.Size = New System.Drawing.Size(100, 20)
        Me.Txtngay_ct.TabIndex = 1
        Me.Txtngay_ct.Text = "01011910"
        Me.Txtngay_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_ct.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(126, 42)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(694, 20)
        Me.txtdien_giai.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "214"
        Me.Label7.Text = "Dien giai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "221"
        Me.Label2.Text = "ngay ct"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(126, 20)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
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
        Me.cbbstatus.Location = New System.Drawing.Point(123, 2)
        Me.cbbstatus.Name = "cbbstatus"
        Me.cbbstatus.Size = New System.Drawing.Size(191, 21)
        Me.cbbstatus.TabIndex = 10
        Me.cbbstatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label12.Location = New System.Drawing.Point(3, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Tag = "303"
        Me.Label12.Text = "trang thai"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 346)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 346)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 346)
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
        Me.Label6.Location = New System.Drawing.Point(158, 346)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 361)
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
        Me.Label5.Location = New System.Drawing.Point(158, 361)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 361)
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
        Me.Label8.Location = New System.Drawing.Point(0, 361)
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
        Me.Label10.Location = New System.Drawing.Point(431, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Tag = "412"
        Me.Label10.Text = "Tien"
        '
        'btnluuandmoi
        '
        Me.btnluuandmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnluuandmoi.Location = New System.Drawing.Point(87, 298)
        Me.btnluuandmoi.Name = "btnluuandmoi"
        Me.btnluuandmoi.Size = New System.Drawing.Size(82, 48)
        Me.btnluuandmoi.TabIndex = 100
        Me.btnluuandmoi.Tag = "219"
        Me.btnluuandmoi.Text = "Luu va them moi"
        Me.btnluuandmoi.UseVisualStyleBackColor = True
        '
        'Txtt_tien_nt
        '
        Me.Txtt_tien_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien_nt.Location = New System.Drawing.Point(547, 277)
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
        Me.Txtt_tien.Location = New System.Drawing.Point(681, 277)
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
        Me.toolbar.Size = New System.Drawing.Size(816, 25)
        Me.toolbar.TabIndex = 214
        Me.toolbar.Text = "toolbar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(696, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Tag = "BPB"
        Me.Button1.Text = "Phân bổ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txttk_dt
        '
        Me.txttk_dt.Location = New System.Drawing.Point(523, 20)
        Me.txttk_dt.Name = "txttk_dt"
        Me.txttk_dt.Size = New System.Drawing.Size(100, 20)
        Me.txttk_dt.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Tag = "TDT"
        Me.Label4.Text = "TK doanh thu"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 380)
        Me.Controls.Add(Me.cbbstatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.toolbar)
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "000"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Txtt_tien As ClsControl2.TxtNumeric
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_nt As ClsControl2.TxtNumeric
    Friend WithEvents btnluuandmoi As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents txttk_dt As TextBox
    Friend WithEvents Label4 As Label
End Class
