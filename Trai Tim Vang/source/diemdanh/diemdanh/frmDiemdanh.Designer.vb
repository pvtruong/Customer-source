<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiemdanh
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
        Me.cbbma_khoa_hoc = New System.Windows.Forms.ComboBox()
        Me.cbbma_lop = New System.Windows.Forms.ComboBox()
        Me.txtma_the = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdthongtinthanhvien = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grdthongtinthanhvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbbma_khoa_hoc
        '
        Me.cbbma_khoa_hoc.FormattingEnabled = True
        Me.cbbma_khoa_hoc.Location = New System.Drawing.Point(12, 22)
        Me.cbbma_khoa_hoc.Name = "cbbma_khoa_hoc"
        Me.cbbma_khoa_hoc.Size = New System.Drawing.Size(457, 21)
        Me.cbbma_khoa_hoc.TabIndex = 0
        '
        'cbbma_lop
        '
        Me.cbbma_lop.FormattingEnabled = True
        Me.cbbma_lop.Location = New System.Drawing.Point(12, 66)
        Me.cbbma_lop.Name = "cbbma_lop"
        Me.cbbma_lop.Size = New System.Drawing.Size(457, 21)
        Me.cbbma_lop.TabIndex = 1
        '
        'txtma_the
        '
        Me.txtma_the.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtma_the.Location = New System.Drawing.Point(12, 106)
        Me.txtma_the.Name = "txtma_the"
        Me.txtma_the.Size = New System.Drawing.Size(457, 50)
        Me.txtma_the.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Chọn khóa học"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Chọn lớp học"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mã thẻ"
        '
        'grdthongtinthanhvien
        '
        Me.grdthongtinthanhvien.AllowUserToAddRows = False
        Me.grdthongtinthanhvien.AllowUserToDeleteRows = False
        Me.grdthongtinthanhvien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdthongtinthanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdthongtinthanhvien.Location = New System.Drawing.Point(12, 180)
        Me.grdthongtinthanhvien.Name = "grdthongtinthanhvien"
        Me.grdthongtinthanhvien.ReadOnly = True
        Me.grdthongtinthanhvien.Size = New System.Drawing.Size(796, 115)
        Me.grdthongtinthanhvien.TabIndex = 3
        Me.grdthongtinthanhvien.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Thông tin học viên"
        '
        'frmDiemdanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 307)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdthongtinthanhvien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtma_the)
        Me.Controls.Add(Me.cbbma_lop)
        Me.Controls.Add(Me.cbbma_khoa_hoc)
        Me.Name = "frmDiemdanh"
        Me.Text = "Điểm danh"
        CType(Me.grdthongtinthanhvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbbma_khoa_hoc As ComboBox
    Friend WithEvents cbbma_lop As ComboBox
    Friend WithEvents txtma_the As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grdthongtinthanhvien As DataGridView
    Friend WithEvents Label4 As Label
End Class
