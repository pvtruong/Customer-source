<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.btnhuy = New System.Windows.Forms.Button
        Me.btnpreview = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.Location = New System.Drawing.Point(311, 67)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 18
        Me.btnhuy.Tag = "999"
        Me.btnhuy.Text = "huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnpreview
        '
        Me.btnpreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpreview.Location = New System.Drawing.Point(230, 67)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(75, 23)
        Me.btnpreview.TabIndex = 17
        Me.btnpreview.Tag = "202"
        Me.btnpreview.Text = "Xem"
        Me.btnpreview.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txttitle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbbmau)
        Me.GroupBox1.Location = New System.Drawing.Point(-9, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = "012"
        Me.Label2.Text = "tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(118, 39)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(277, 20)
        Me.txttitle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "011"
        Me.Label1.Text = "mau "
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(118, 12)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(277, 21)
        Me.cbbmau.TabIndex = 1
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(8, 185)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(60, 21)
        Me.cbbma_dvcs.TabIndex = 19
        Me.cbbma_dvcs.Visible = False
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 101)
        Me.Controls.Add(Me.cbbma_dvcs)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "frmPrint"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
End Class
