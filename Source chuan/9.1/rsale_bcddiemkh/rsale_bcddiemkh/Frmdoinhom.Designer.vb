<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdoinhom
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
        Me.btnok = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnh_kh1 = New System.Windows.Forms.TextBox
        Me.ten_nh_kh1 = New System.Windows.Forms.Label
        Me.ten_nh_kh2 = New System.Windows.Forms.Label
        Me.txtnh_kh2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ten_nh_kh3 = New System.Windows.Forms.Label
        Me.txtnh_kh3 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(13, 103)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 0
        Me.btnok.Text = "Đổi"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btncancel.Location = New System.Drawing.Point(94, 103)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 1
        Me.btncancel.Text = "Hủy"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Loại nhóm 1"
        '
        'txtnh_kh1
        '
        Me.txtnh_kh1.Location = New System.Drawing.Point(104, 13)
        Me.txtnh_kh1.Name = "txtnh_kh1"
        Me.txtnh_kh1.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_kh1.TabIndex = 3
        '
        'ten_nh_kh1
        '
        Me.ten_nh_kh1.AutoSize = True
        Me.ten_nh_kh1.Location = New System.Drawing.Point(210, 16)
        Me.ten_nh_kh1.Name = "ten_nh_kh1"
        Me.ten_nh_kh1.Size = New System.Drawing.Size(39, 13)
        Me.ten_nh_kh1.TabIndex = 4
        Me.ten_nh_kh1.Text = "Label2"
        '
        'ten_nh_kh2
        '
        Me.ten_nh_kh2.AutoSize = True
        Me.ten_nh_kh2.Location = New System.Drawing.Point(210, 42)
        Me.ten_nh_kh2.Name = "ten_nh_kh2"
        Me.ten_nh_kh2.Size = New System.Drawing.Size(39, 13)
        Me.ten_nh_kh2.TabIndex = 7
        Me.ten_nh_kh2.Text = "Label3"
        '
        'txtnh_kh2
        '
        Me.txtnh_kh2.Location = New System.Drawing.Point(104, 39)
        Me.txtnh_kh2.Name = "txtnh_kh2"
        Me.txtnh_kh2.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_kh2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Loại nhóm 2"
        '
        'ten_nh_kh3
        '
        Me.ten_nh_kh3.AutoSize = True
        Me.ten_nh_kh3.Location = New System.Drawing.Point(210, 68)
        Me.ten_nh_kh3.Name = "ten_nh_kh3"
        Me.ten_nh_kh3.Size = New System.Drawing.Size(39, 13)
        Me.ten_nh_kh3.TabIndex = 10
        Me.ten_nh_kh3.Text = "Label5"
        '
        'txtnh_kh3
        '
        Me.txtnh_kh3.Location = New System.Drawing.Point(104, 65)
        Me.txtnh_kh3.Name = "txtnh_kh3"
        Me.txtnh_kh3.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_kh3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Loại nhóm 3"
        '
        'Frmdoinhom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 130)
        Me.Controls.Add(Me.ten_nh_kh3)
        Me.Controls.Add(Me.txtnh_kh3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ten_nh_kh2)
        Me.Controls.Add(Me.txtnh_kh2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ten_nh_kh1)
        Me.Controls.Add(Me.txtnh_kh1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Name = "Frmdoinhom"
        Me.Text = "Chọn nhóm khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh1 As System.Windows.Forms.TextBox
    Friend WithEvents ten_nh_kh1 As System.Windows.Forms.Label
    Friend WithEvents ten_nh_kh2 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ten_nh_kh3 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
