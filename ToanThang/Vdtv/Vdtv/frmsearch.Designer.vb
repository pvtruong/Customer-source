<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ten_dt = New System.Windows.Forms.Label()
        Me.txtma_dt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDen_ngay = New ClsControl2.TxtDate()
        Me.Txttu_ngay = New ClsControl2.TxtDate()
        Me.ten_bp = New System.Windows.Forms.Label()
        Me.txtma_bp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.txtso_ct = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtso_ct)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ten_dt)
        Me.GroupBox1.Controls.Add(Me.txtma_dt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtDen_ngay)
        Me.GroupBox1.Controls.Add(Me.Txttu_ngay)
        Me.GroupBox1.Controls.Add(Me.ten_bp)
        Me.GroupBox1.Controls.Add(Me.txtma_bp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ten_dt
        '
        Me.ten_dt.AutoSize = True
        Me.ten_dt.Location = New System.Drawing.Point(227, 101)
        Me.ten_dt.Name = "ten_dt"
        Me.ten_dt.Size = New System.Drawing.Size(34, 13)
        Me.ten_dt.TabIndex = 15
        Me.ten_dt.Text = "ten dt"
        '
        'txtma_dt
        '
        Me.txtma_dt.Location = New System.Drawing.Point(124, 97)
        Me.txtma_dt.Name = "txtma_dt"
        Me.txtma_dt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_dt.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Tag = "ma"
        Me.Label7.Text = "Mã đối tượng"
        '
        'TxtDen_ngay
        '
        Me.TxtDen_ngay.Location = New System.Drawing.Point(230, 45)
        Me.TxtDen_ngay.Mask = "00/00/0000"
        Me.TxtDen_ngay.Name = "TxtDen_ngay"
        Me.TxtDen_ngay.Size = New System.Drawing.Size(100, 20)
        Me.TxtDen_ngay.TabIndex = 2
        Me.TxtDen_ngay.Text = "01011910"
        Me.TxtDen_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDen_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Txttu_ngay
        '
        Me.Txttu_ngay.Location = New System.Drawing.Point(124, 45)
        Me.Txttu_ngay.Mask = "00/00/0000"
        Me.Txttu_ngay.Name = "Txttu_ngay"
        Me.Txttu_ngay.Size = New System.Drawing.Size(100, 20)
        Me.Txttu_ngay.TabIndex = 1
        Me.Txttu_ngay.Text = "01011910"
        Me.Txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'ten_bp
        '
        Me.ten_bp.AutoSize = True
        Me.ten_bp.Location = New System.Drawing.Point(227, 75)
        Me.ten_bp.Name = "ten_bp"
        Me.ten_bp.Size = New System.Drawing.Size(37, 13)
        Me.ten_bp.TabIndex = 9
        Me.ten_bp.Text = "ten bp"
        '
        'txtma_bp
        '
        Me.txtma_bp.Location = New System.Drawing.Point(124, 71)
        Me.txtma_bp.Name = "txtma_bp"
        Me.txtma_bp.Size = New System.Drawing.Size(100, 20)
        Me.txtma_bp.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Tag = "ma_bp"
        Me.Label4.Text = "Mã bộ phận"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "232"
        Me.Label1.Text = "tu/den ngay"
        '
        'btntim
        '
        Me.btntim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btntim.Location = New System.Drawing.Point(3, 133)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 1
        Me.btntim.Tag = "233"
        Me.btntim.Text = "Tim"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.Location = New System.Drawing.Point(84, 133)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 2
        Me.btnhuy.Tag = "229"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(124, 19)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Tag = "ma_cn"
        Me.Label2.Text = "Mã cập nhật"
        '
        'frmsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 160)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmsearch"
        Me.Tag = "234"
        Me.Text = "frmsearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents ten_bp As System.Windows.Forms.Label
    Friend WithEvents txtma_bp As System.Windows.Forms.TextBox
    Friend WithEvents TxtDen_ngay As ClsControl2.TxtDate
    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents ten_dt As System.Windows.Forms.Label
    Friend WithEvents txtma_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtso_ct As TextBox
    Friend WithEvents Label2 As Label
End Class
