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
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chbonly_sumary = New System.Windows.Forms.CheckBox
        Me.txtkhoang_tg = New ClsControl2.TxtNumeric
        Me.lblten_kh = New System.Windows.Forms.Label
        Me.lblten_tk = New System.Windows.Forms.Label
        Me.txtngay_tt = New ClsControl2.TxtDate
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttk = New System.Windows.Forms.TextBox
        Me.txtden_ngay = New ClsControl2.TxtDate
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tabdkloc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.TabPage1)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(623, 265)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chbonly_sumary)
        Me.TabPage1.Controls.Add(Me.txtkhoang_tg)
        Me.TabPage1.Controls.Add(Me.lblten_kh)
        Me.TabPage1.Controls.Add(Me.lblten_tk)
        Me.TabPage1.Controls.Add(Me.txtngay_tt)
        Me.TabPage1.Controls.Add(Me.txtma_kh)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txttk)
        Me.TabPage1.Controls.Add(Me.txtden_ngay)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbbma_dvcs)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(615, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Dieu kien loc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chbonly_sumary
        '
        Me.chbonly_sumary.AutoSize = True
        Me.chbonly_sumary.Location = New System.Drawing.Point(127, 131)
        Me.chbonly_sumary.Name = "chbonly_sumary"
        Me.chbonly_sumary.Size = New System.Drawing.Size(198, 17)
        Me.chbonly_sumary.TabIndex = 5
        Me.chbonly_sumary.Tag = "505"
        Me.chbonly_sumary.Text = "Chỉ xem tổng cộng theo khách hàng"
        Me.chbonly_sumary.UseVisualStyleBackColor = True
        '
        'txtkhoang_tg
        '
        Me.txtkhoang_tg.Location = New System.Drawing.Point(127, 104)
        Me.txtkhoang_tg.MaxLength = 18
        Me.txtkhoang_tg.Name = "txtkhoang_tg"
        Me.txtkhoang_tg.NumberDecimalDigits = -1
        Me.txtkhoang_tg.Size = New System.Drawing.Size(125, 20)
        Me.txtkhoang_tg.TabIndex = 4
        Me.txtkhoang_tg.Text = "30"
        Me.txtkhoang_tg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtkhoang_tg.Value = 30
        Me.txtkhoang_tg.Value2 = 30
        '
        'lblten_kh
        '
        Me.lblten_kh.AutoSize = True
        Me.lblten_kh.Location = New System.Drawing.Point(259, 83)
        Me.lblten_kh.Name = "lblten_kh"
        Me.lblten_kh.Size = New System.Drawing.Size(37, 13)
        Me.lblten_kh.TabIndex = 9
        Me.lblten_kh.Text = "ten kh"
        '
        'lblten_tk
        '
        Me.lblten_tk.AutoSize = True
        Me.lblten_tk.Location = New System.Drawing.Point(259, 58)
        Me.lblten_tk.Name = "lblten_tk"
        Me.lblten_tk.Size = New System.Drawing.Size(34, 13)
        Me.lblten_tk.TabIndex = 8
        Me.lblten_tk.Text = "ten tk"
        '
        'txtngay_tt
        '
        Me.txtngay_tt.Location = New System.Drawing.Point(127, 29)
        Me.txtngay_tt.Mask = "00/00/0000"
        Me.txtngay_tt.Name = "txtngay_tt"
        Me.txtngay_tt.Size = New System.Drawing.Size(125, 20)
        Me.txtngay_tt.TabIndex = 1
        Me.txtngay_tt.Text = "01011910"
        Me.txtngay_tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_tt.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(127, 79)
        Me.txtma_kh.MaxLength = 100
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(125, 20)
        Me.txtma_kh.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Tag = "007"
        Me.Label7.Text = "ma khach"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Tag = "006"
        Me.Label2.Text = "tai khoan"
        '
        'txttk
        '
        Me.txttk.Location = New System.Drawing.Point(127, 54)
        Me.txttk.MaxLength = 100
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(125, 20)
        Me.txttk.TabIndex = 2
        '
        'txtden_ngay
        '
        Me.txtden_ngay.Location = New System.Drawing.Point(127, 4)
        Me.txtden_ngay.Mask = "00/00/0000"
        Me.txtden_ngay.Name = "txtden_ngay"
        Me.txtden_ngay.Size = New System.Drawing.Size(125, 20)
        Me.txtden_ngay.TabIndex = 0
        Me.txtden_ngay.Text = "01011910"
        Me.txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtden_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Tag = "002"
        Me.Label14.Text = "den ngay"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Tag = "003"
        Me.Label13.Text = "ngay thanh toan den"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Tag = "008"
        Me.Label10.Text = "khoang thoi gian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(127, 155)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(476, 21)
        Me.cbbma_dvcs.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Tag = "011"
        Me.Label4.Text = "mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Tag = "012"
        Me.Label3.Text = "tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(127, 207)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(476, 20)
        Me.txttitle.TabIndex = 8
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(127, 181)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(476, 21)
        Me.cbbmau.TabIndex = 7
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 270)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "004"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(93, 270)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "005"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 297)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "Điều kiện lọc"
        Me.tabdkloc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtden_ngay As ClsControl2.TxtDate
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttk As System.Windows.Forms.TextBox
    Friend WithEvents txtngay_tt As ClsControl2.TxtDate
    Friend WithEvents lblten_kh As System.Windows.Forms.Label
    Friend WithEvents lblten_tk As System.Windows.Forms.Label
    Friend WithEvents txtkhoang_tg As ClsControl2.TxtNumeric
    Friend WithEvents chbonly_sumary As System.Windows.Forms.CheckBox
End Class
