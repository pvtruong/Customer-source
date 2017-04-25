<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Grpbox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnam = New ClsControl2.TxtNumeric()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtserver = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtdatabase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progressbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Grpbox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(6, 316)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Tag = "900"
        Me.btnOK.Text = "Xóa"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(87, 316)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Hủy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Grpbox
        '
        Me.Grpbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grpbox.Controls.Add(Me.Label1)
        Me.Grpbox.Controls.Add(Me.DataGridView1)
        Me.Grpbox.Controls.Add(Me.Label2)
        Me.Grpbox.Controls.Add(Me.Txtnam)
        Me.Grpbox.Location = New System.Drawing.Point(-9, -27)
        Me.Grpbox.Name = "Grpbox"
        Me.Grpbox.Size = New System.Drawing.Size(672, 337)
        Me.Grpbox.TabIndex = 13
        Me.Grpbox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Chọn chứng từ"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(627, 233)
        Me.DataGridView1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "003"
        Me.Label2.Text = "Đến hết năm"
        '
        'Txtnam
        '
        Me.Txtnam.Location = New System.Drawing.Point(15, 52)
        Me.Txtnam.MaxLength = 4
        Me.Txtnam.Name = "Txtnam"
        Me.Txtnam.NumberDecimalDigits = -1
        Me.Txtnam.Size = New System.Drawing.Size(70, 20)
        Me.Txtnam.TabIndex = 1
        Me.Txtnam.Text = "0"
        Me.Txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtnam.Value = 0R
        Me.Txtnam.Value2 = 0R
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtserver, Me.txtdatabase, Me.lblstatus, Me.ToolStripStatusLabel1, Me.progressbar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 344)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(645, 24)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtserver
        '
        Me.txtserver.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(43, 19)
        Me.txtserver.Text = "Server"
        '
        'txtdatabase
        '
        Me.txtdatabase.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.txtdatabase.Name = "txtdatabase"
        Me.txtdatabase.Size = New System.Drawing.Size(59, 19)
        Me.txtdatabase.Text = "Database"
        '
        'lblstatus
        '
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(36, 19)
        Me.lblstatus.Text = "ready"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(390, 19)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'progressbar
        '
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Size = New System.Drawing.Size(100, 18)
        Me.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 368)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Grpbox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "Xóa dữ liệu"
        Me.Grpbox.ResumeLayout(False)
        Me.Grpbox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progressbar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtnam As ClsControl2.TxtNumeric
    Friend WithEvents txtserver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtdatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
