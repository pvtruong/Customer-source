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
        Me.tabdkloc = New System.Windows.Forms.TabControl()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbbmau = New System.Windows.Forms.ComboBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtden_ngay = New ClsControl2.TxtDate()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txttu_ngay = New ClsControl2.TxtDate()
        Me.txtma_dt = New System.Windows.Forms.TextBox()
        Me.ten_dt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtma_bp = New System.Windows.Forms.TextBox()
        Me.ten_bp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtma_cp = New System.Windows.Forms.TextBox()
        Me.ten_cp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSuaMau = New System.Windows.Forms.TabPage()
        Me.tabdkloc.SuspendLayout()
        Me.btnSuaMau.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.btnSuaMau)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(502, 232)
        Me.tabdkloc.TabIndex = 0
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 237)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "900"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(93, 237)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(378, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Tag = "020"
        Me.Button1.Text = "Sua mau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 137)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 11
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 164)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 110)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(326, 21)
        Me.cbbma_dvcs.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'Txtden_ngay
        '
        Me.Txtden_ngay.Location = New System.Drawing.Point(276, 6)
        Me.Txtden_ngay.Mask = "00/00/0000"
        Me.Txtden_ngay.Name = "Txtden_ngay"
        Me.Txtden_ngay.Size = New System.Drawing.Size(125, 20)
        Me.Txtden_ngay.TabIndex = 1
        Me.Txtden_ngay.Text = "26032010"
        Me.Txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtden_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Tag = "002"
        Me.Label16.Text = "tu ngay"
        '
        'txttu_ngay
        '
        Me.txttu_ngay.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txttu_ngay.Location = New System.Drawing.Point(145, 6)
        Me.txttu_ngay.Mask = "00/00/0000"
        Me.txttu_ngay.Name = "txttu_ngay"
        Me.txttu_ngay.Size = New System.Drawing.Size(125, 20)
        Me.txttu_ngay.TabIndex = 0
        Me.txttu_ngay.Text = "26032010"
        Me.txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttu_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(145, 32)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_dt.TabIndex = 6
        '
        'ten_dt
        '
        Me.ten_dt.AutoSize = True
        Me.ten_dt.Location = New System.Drawing.Point(257, 35)
        Me.ten_dt.Name = "ten_dt"
        Me.ten_dt.Size = New System.Drawing.Size(29, 13)
        Me.ten_dt.TabIndex = 48
        Me.ten_dt.Text = "Ten "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Tag = "402"
        Me.Label7.Text = "Mã đối tượng/vụ việc"
        '
        'txtma_bp
        '
        Me.txtma_bp.Location = New System.Drawing.Point(145, 58)
        Me.txtma_bp.Name = "txtma_bp"
        Me.txtma_bp.Size = New System.Drawing.Size(100, 20)
        Me.txtma_bp.TabIndex = 50
        '
        'ten_bp
        '
        Me.ten_bp.AutoSize = True
        Me.ten_bp.Location = New System.Drawing.Point(257, 61)
        Me.ten_bp.Name = "ten_bp"
        Me.ten_bp.Size = New System.Drawing.Size(37, 13)
        Me.ten_bp.TabIndex = 51
        Me.ten_bp.Text = "ten bp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Tag = "ma_bp"
        Me.Label1.Text = "Mã bộ phận"
        '
        'txtma_cp
        '
        Me.txtma_cp.Location = New System.Drawing.Point(145, 84)
        Me.txtma_cp.Name = "txtma_cp"
        Me.txtma_cp.Size = New System.Drawing.Size(100, 20)
        Me.txtma_cp.TabIndex = 53
        '
        'ten_cp
        '
        Me.ten_cp.AutoSize = True
        Me.ten_cp.Location = New System.Drawing.Point(257, 87)
        Me.ten_cp.Name = "ten_cp"
        Me.ten_cp.Size = New System.Drawing.Size(37, 13)
        Me.ten_cp.TabIndex = 54
        Me.ten_cp.Text = "ten cp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Tag = "ma_cp"
        Me.Label5.Text = "Mã chi phí"
        '
        'btnSuaMau
        '
        Me.btnSuaMau.Controls.Add(Me.Label5)
        Me.btnSuaMau.Controls.Add(Me.ten_cp)
        Me.btnSuaMau.Controls.Add(Me.txtma_cp)
        Me.btnSuaMau.Controls.Add(Me.Label1)
        Me.btnSuaMau.Controls.Add(Me.ten_bp)
        Me.btnSuaMau.Controls.Add(Me.txtma_bp)
        Me.btnSuaMau.Controls.Add(Me.Label7)
        Me.btnSuaMau.Controls.Add(Me.ten_dt)
        Me.btnSuaMau.Controls.Add(Me.txtma_dt)
        Me.btnSuaMau.Controls.Add(Me.txttu_ngay)
        Me.btnSuaMau.Controls.Add(Me.Label16)
        Me.btnSuaMau.Controls.Add(Me.Txtden_ngay)
        Me.btnSuaMau.Controls.Add(Me.Label9)
        Me.btnSuaMau.Controls.Add(Me.cbbma_dvcs)
        Me.btnSuaMau.Controls.Add(Me.Label4)
        Me.btnSuaMau.Controls.Add(Me.Label3)
        Me.btnSuaMau.Controls.Add(Me.txttitle)
        Me.btnSuaMau.Controls.Add(Me.cbbmau)
        Me.btnSuaMau.Location = New System.Drawing.Point(4, 22)
        Me.btnSuaMau.Name = "btnSuaMau"
        Me.btnSuaMau.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSuaMau.Size = New System.Drawing.Size(494, 206)
        Me.btnSuaMau.TabIndex = 0
        Me.btnSuaMau.Tag = "001"
        Me.btnSuaMau.Text = "Dieu kien loc"
        Me.btnSuaMau.UseVisualStyleBackColor = True
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 264)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "frmfilter"
        Me.tabdkloc.ResumeLayout(False)
        Me.btnSuaMau.ResumeLayout(False)
        Me.btnSuaMau.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSuaMau As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents ten_cp As Label
    Friend WithEvents txtma_cp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ten_bp As Label
    Friend WithEvents txtma_bp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ten_dt As Label
    Friend WithEvents txtma_dt As TextBox
    Friend WithEvents txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents Label16 As Label
    Friend WithEvents Txtden_ngay As ClsControl2.TxtDate
    Friend WithEvents Label9 As Label
    Friend WithEvents cbbma_dvcs As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttitle As TextBox
    Friend WithEvents cbbmau As ComboBox
End Class
