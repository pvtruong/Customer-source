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
        Me.components = New System.ComponentModel.Container
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtline_min = New ClsControl2.TxtNumeric
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtstt = New ClsControl2.TxtNumeric
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtrpt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtuser_permit_print12 = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtuser_permit_print1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txttitle2 = New System.Windows.Forms.TextBox
        Me.txtname2 = New System.Windows.Forms.TextBox
        Me.txttitle0 = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtso_lien = New System.Windows.Forms.NumericUpDown
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtten_lien9 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtten_lien8 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtten_lien7 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtten_lien6 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtten_lien5 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtten_lien4 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtten_lien3 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtten_lien2 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtten_lien1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtgridid = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtrpt_chart = New System.Windows.Forms.TextBox
        Me.txtstore = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtmau_so = New System.Windows.Forms.TextBox
        Me.ImgLogo = New ClsControl2.imgPictureBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.txtso_lien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 319)
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
        Me.btnhuy.Location = New System.Drawing.Point(59, 319)
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
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 313)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(714, 305)
        Me.TabControl1.TabIndex = 110
        Me.TabControl1.Tag = "300"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.txtmau_so)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtcode)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtline_min)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtstt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtrpt)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtuser_permit_print12)
        Me.TabPage1.Controls.Add(Me.txtname)
        Me.TabPage1.Controls.Add(Me.txtuser_permit_print1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txttitle2)
        Me.TabPage1.Controls.Add(Me.txtname2)
        Me.TabPage1.Controls.Add(Me.txttitle0)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(706, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "300"
        Me.TabPage1.Text = "Chính"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "001"
        Me.Label1.Text = "ma chuc nang"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 233)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(174, 13)
        Me.Label17.TabIndex = 109
        Me.Label17.Tag = "013"
        Me.Label17.Text = "nguoi su dung duoc phep sua lan 2"
        '
        'txtcode
        '
        Me.txtcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcode.Location = New System.Drawing.Point(210, 9)
        Me.txtcode.MaxLength = 16
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(123, 20)
        Me.txtcode.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 209)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(174, 13)
        Me.Label16.TabIndex = 109
        Me.Label16.Tag = "012"
        Me.Label16.Text = "nguoi su dung duoc phep sua lan 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "003"
        Me.Label4.Text = "ten mau in"
        '
        'txtline_min
        '
        Me.txtline_min.Location = New System.Drawing.Point(210, 182)
        Me.txtline_min.Margin = New System.Windows.Forms.Padding(2)
        Me.txtline_min.MaxLength = 18
        Me.txtline_min.Name = "txtline_min"
        Me.txtline_min.NumberDecimalDigits = -1
        Me.txtline_min.Size = New System.Drawing.Size(123, 20)
        Me.txtline_min.TabIndex = 11
        Me.txtline_min.Text = "0"
        Me.txtline_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtline_min.Value = 0
        Me.txtline_min.Value2 = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Tag = "004"
        Me.Label2.Text = "ten mau in 2"
        '
        'txtstt
        '
        Me.txtstt.Location = New System.Drawing.Point(210, 34)
        Me.txtstt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstt.MaxLength = 18
        Me.txtstt.Name = "txtstt"
        Me.txtstt.NumberDecimalDigits = -1
        Me.txtstt.Size = New System.Drawing.Size(123, 20)
        Me.txtstt.TabIndex = 2
        Me.txtstt.Text = "0"
        Me.txtstt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtstt.Value = 0
        Me.txtstt.Value2 = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Tag = "005"
        Me.Label7.Text = "tieu de in "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Tag = "011"
        Me.Label15.Text = "so dong toi thieu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Tag = "002"
        Me.Label10.Text = "stt"
        '
        'txtrpt
        '
        Me.txtrpt.Location = New System.Drawing.Point(210, 156)
        Me.txtrpt.MaxLength = 64
        Me.txtrpt.Name = "txtrpt"
        Me.txtrpt.Size = New System.Drawing.Size(123, 20)
        Me.txtrpt.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Tag = "006"
        Me.Label9.Text = "tieu de in 2"
        '
        'txtuser_permit_print12
        '
        Me.txtuser_permit_print12.Location = New System.Drawing.Point(210, 231)
        Me.txtuser_permit_print12.MaxLength = 128
        Me.txtuser_permit_print12.Name = "txtuser_permit_print12"
        Me.txtuser_permit_print12.Size = New System.Drawing.Size(410, 20)
        Me.txtuser_permit_print12.TabIndex = 13
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(210, 58)
        Me.txtname.MaxLength = 128
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(410, 20)
        Me.txtname.TabIndex = 4
        '
        'txtuser_permit_print1
        '
        Me.txtuser_permit_print1.Location = New System.Drawing.Point(210, 207)
        Me.txtuser_permit_print1.MaxLength = 128
        Me.txtuser_permit_print1.Name = "txtuser_permit_print1"
        Me.txtuser_permit_print1.Size = New System.Drawing.Size(410, 20)
        Me.txtuser_permit_print1.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Tag = "007"
        Me.Label11.Text = "file report"
        '
        'txttitle2
        '
        Me.txttitle2.Location = New System.Drawing.Point(210, 131)
        Me.txttitle2.MaxLength = 128
        Me.txttitle2.Name = "txttitle2"
        Me.txttitle2.Size = New System.Drawing.Size(410, 20)
        Me.txttitle2.TabIndex = 7
        '
        'txtname2
        '
        Me.txtname2.Location = New System.Drawing.Point(210, 82)
        Me.txtname2.MaxLength = 128
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(410, 20)
        Me.txtname2.TabIndex = 5
        '
        'txttitle0
        '
        Me.txttitle0.Location = New System.Drawing.Point(210, 107)
        Me.txttitle0.MaxLength = 128
        Me.txttitle0.Name = "txttitle0"
        Me.txttitle0.Size = New System.Drawing.Size(410, 20)
        Me.txttitle0.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtso_lien)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.txtten_lien9)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.txtten_lien8)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.txtten_lien7)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.txtten_lien6)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.txtten_lien5)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.txtten_lien4)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txtten_lien3)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.txtten_lien2)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtten_lien1)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(706, 279)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "301"
        Me.TabPage2.Text = "Số liên"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtso_lien
        '
        Me.txtso_lien.Location = New System.Drawing.Point(175, 5)
        Me.txtso_lien.Name = "txtso_lien"
        Me.txtso_lien.Size = New System.Drawing.Size(71, 20)
        Me.txtso_lien.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 241)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 13)
        Me.Label27.TabIndex = 33
        Me.Label27.Tag = "208"
        Me.Label27.Text = "ten lien 9"
        '
        'txtten_lien9
        '
        Me.txtten_lien9.Location = New System.Drawing.Point(175, 238)
        Me.txtten_lien9.MaxLength = 128
        Me.txtten_lien9.Name = "txtten_lien9"
        Me.txtten_lien9.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien9.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 215)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 31
        Me.Label26.Tag = "207"
        Me.Label26.Text = "ten lien 8"
        '
        'txtten_lien8
        '
        Me.txtten_lien8.Location = New System.Drawing.Point(175, 212)
        Me.txtten_lien8.MaxLength = 128
        Me.txtten_lien8.Name = "txtten_lien8"
        Me.txtten_lien8.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien8.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 189)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 29
        Me.Label25.Tag = "206"
        Me.Label25.Text = "ten lien 7"
        '
        'txtten_lien7
        '
        Me.txtten_lien7.Location = New System.Drawing.Point(175, 186)
        Me.txtten_lien7.MaxLength = 128
        Me.txtten_lien7.Name = "txtten_lien7"
        Me.txtten_lien7.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien7.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 163)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 27
        Me.Label24.Tag = "205"
        Me.Label24.Text = "ten lien 6"
        '
        'txtten_lien6
        '
        Me.txtten_lien6.Location = New System.Drawing.Point(175, 160)
        Me.txtten_lien6.MaxLength = 128
        Me.txtten_lien6.Name = "txtten_lien6"
        Me.txtten_lien6.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien6.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 137)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 25
        Me.Label23.Tag = "204"
        Me.Label23.Text = "ten lien 5"
        '
        'txtten_lien5
        '
        Me.txtten_lien5.Location = New System.Drawing.Point(175, 134)
        Me.txtten_lien5.MaxLength = 128
        Me.txtten_lien5.Name = "txtten_lien5"
        Me.txtten_lien5.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien5.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 111)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Tag = "203"
        Me.Label22.Text = "ten lien 4"
        '
        'txtten_lien4
        '
        Me.txtten_lien4.Location = New System.Drawing.Point(175, 108)
        Me.txtten_lien4.MaxLength = 128
        Me.txtten_lien4.Name = "txtten_lien4"
        Me.txtten_lien4.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien4.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Tag = "202"
        Me.Label21.Text = "ten lien 3"
        '
        'txtten_lien3
        '
        Me.txtten_lien3.Location = New System.Drawing.Point(175, 82)
        Me.txtten_lien3.MaxLength = 128
        Me.txtten_lien3.Name = "txtten_lien3"
        Me.txtten_lien3.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien3.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Tag = "201"
        Me.Label20.Text = "ten lien 2"
        '
        'txtten_lien2
        '
        Me.txtten_lien2.Location = New System.Drawing.Point(175, 56)
        Me.txtten_lien2.MaxLength = 128
        Me.txtten_lien2.Name = "txtten_lien2"
        Me.txtten_lien2.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien2.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Tag = "200"
        Me.Label19.Text = "ten lien 1"
        '
        'txtten_lien1
        '
        Me.txtten_lien1.Location = New System.Drawing.Point(175, 30)
        Me.txtten_lien1.MaxLength = 128
        Me.txtten_lien1.Name = "txtten_lien1"
        Me.txtten_lien1.Size = New System.Drawing.Size(410, 20)
        Me.txtten_lien1.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Tag = "014"
        Me.Label18.Text = "so lien"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.ImgLogo)
        Me.TabPage3.Controls.Add(Me.txtgridid)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.txtrpt_chart)
        Me.TabPage3.Controls.Add(Me.txtstore)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(706, 279)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Tag = "302"
        Me.TabPage3.Text = "Khác"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtgridid
        '
        Me.txtgridid.Location = New System.Drawing.Point(182, 6)
        Me.txtgridid.MaxLength = 64
        Me.txtgridid.Name = "txtgridid"
        Me.txtgridid.Size = New System.Drawing.Size(123, 20)
        Me.txtgridid.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Tag = "010"
        Me.Label14.Text = "gridid"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Tag = "008"
        Me.Label12.Text = "file report do thi"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Tag = "009"
        Me.Label13.Text = "store khi in"
        '
        'txtrpt_chart
        '
        Me.txtrpt_chart.Location = New System.Drawing.Point(182, 32)
        Me.txtrpt_chart.MaxLength = 64
        Me.txtrpt_chart.Name = "txtrpt_chart"
        Me.txtrpt_chart.Size = New System.Drawing.Size(123, 20)
        Me.txtrpt_chart.TabIndex = 1
        '
        'txtstore
        '
        Me.txtstore.Location = New System.Drawing.Point(182, 56)
        Me.txtstore.MaxLength = 64
        Me.txtstore.Name = "txtstore"
        Me.txtstore.Size = New System.Drawing.Size(123, 20)
        Me.txtstore.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 356)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 356)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 356)
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
        Me.Label6.Location = New System.Drawing.Point(158, 356)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 371)
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
        Me.Label5.Location = New System.Drawing.Point(158, 371)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 371)
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
        Me.Label8.Location = New System.Drawing.Point(0, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(344, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(41, 13)
        Me.Label28.TabIndex = 111
        Me.Label28.Tag = "303"
        Me.Label28.Text = "mau so"
        '
        'txtmau_so
        '
        Me.txtmau_so.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmau_so.Location = New System.Drawing.Point(425, 34)
        Me.txtmau_so.MaxLength = 16
        Me.txtmau_so.Name = "txtmau_so"
        Me.txtmau_so.Size = New System.Drawing.Size(123, 20)
        Me.txtmau_so.TabIndex = 3
        '
        'ImgLogo
        '
        Me.ImgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgLogo.Buffer = Nothing
        Me.ImgLogo.Location = New System.Drawing.Point(182, 82)
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Size = New System.Drawing.Size(202, 124)
        Me.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLogo.TabIndex = 160
        Me.ImgLogo.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 82)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 13)
        Me.Label29.TabIndex = 161
        Me.Label29.Tag = "304"
        Me.Label29.Text = "Logo"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 390)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.txtso_lien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtname2 As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtstt As ClsControl2.TxtNumeric
    Friend WithEvents txtline_min As ClsControl2.TxtNumeric
    Friend WithEvents txtrpt_chart As System.Windows.Forms.TextBox
    Friend WithEvents txtrpt As System.Windows.Forms.TextBox
    Friend WithEvents txttitle2 As System.Windows.Forms.TextBox
    Friend WithEvents txttitle0 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgridid As System.Windows.Forms.TextBox
    Friend WithEvents txtstore As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtuser_permit_print12 As System.Windows.Forms.TextBox
    Friend WithEvents txtuser_permit_print1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien9 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien8 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien7 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien6 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien5 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien4 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien3 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtten_lien1 As System.Windows.Forms.TextBox
    Friend WithEvents txtso_lien As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtmau_so As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ImgLogo As ClsControl2.imgPictureBox
End Class
