<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetPN
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
        Me.Txttu_ngay = New ClsControl2.TxtDate()
        Me.Txtden_ngay = New ClsControl2.TxtDate()
        Me.txtma_vt = New System.Windows.Forms.TextBox()
        Me.ten_vt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtso_ct = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txttu_ngay
        '
        Me.Txttu_ngay.Location = New System.Drawing.Point(128, 9)
        Me.Txttu_ngay.Mask = "00/00/0000"
        Me.Txttu_ngay.Name = "Txttu_ngay"
        Me.Txttu_ngay.Size = New System.Drawing.Size(100, 20)
        Me.Txttu_ngay.TabIndex = 0
        Me.Txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Txtden_ngay
        '
        Me.Txtden_ngay.Location = New System.Drawing.Point(128, 35)
        Me.Txtden_ngay.Mask = "00/00/0000"
        Me.Txtden_ngay.Name = "Txtden_ngay"
        Me.Txtden_ngay.Size = New System.Drawing.Size(100, 20)
        Me.Txtden_ngay.TabIndex = 1
        Me.Txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtden_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'txtma_vt
        '
        Me.txtma_vt.Location = New System.Drawing.Point(128, 61)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_vt.TabIndex = 2
        '
        'ten_vt
        '
        Me.ten_vt.AutoSize = True
        Me.ten_vt.Location = New System.Drawing.Point(234, 65)
        Me.ten_vt.Name = "ten_vt"
        Me.ten_vt.Size = New System.Drawing.Size(37, 13)
        Me.ten_vt.TabIndex = 3
        Me.ten_vt.Text = "ten_vt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "VTU"
        Me.Label2.Text = "Vật tư"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Tag = "TNG"
        Me.Label3.Text = "Từ ngày"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Tag = "DNG"
        Me.Label4.Text = "Đến ngày"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Tag = "BOK"
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(209, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Tag = "BCN"
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Tag = "SPN"
        Me.Label1.Text = "Số phiếu nhập"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(128, 87)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 3
        '
        'frmGetPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 150)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtso_ct)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ten_vt)
        Me.Controls.Add(Me.txtma_vt)
        Me.Controls.Add(Me.Txtden_ngay)
        Me.Controls.Add(Me.Txttu_ngay)
        Me.Name = "frmGetPN"
        Me.Tag = "GPN"
        Me.Text = "Lấy phiếu nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents Txtden_ngay As ClsControl2.TxtDate
    Friend WithEvents txtma_vt As TextBox
    Friend WithEvents ten_vt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtso_ct As TextBox
End Class
