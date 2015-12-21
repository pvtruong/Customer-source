Public Class MainForm
    Dim WithEvents rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim form As String
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim isloaded As Boolean = False
    Dim oLable As Collection

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        form = Clsql.Others.GetArgu(2)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbmau)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)

        setupdkloc()
        frmdkloc.Icon = Me.Icon

        'load du lieu
        If Clsql.Others.GetArgu(3) <> "" Then
            query = Clsql.Others.GetArgu(3)
        Else
            If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GetQuery()
            Else
                Me.Close()
                Return
            End If
        End If
        rpt.Query = query
        lbluser.Text = Clsql.Reg.GetValue("ID")
        lblunit.Text = frmdkloc.cbbmau.Text
        'ClsControl2.PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        ClsControl2.PropertyOfForm.SetImage4Control("find.bmp", btndkloc)
        ClsControl2.PropertyOfForm.SetImage4Control("refresh.bmp", btnrefresh2)
        printer.Text = rpt.cPrint.GetPrinter
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        isloaded = True
    End Sub

    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btndkloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndkloc.Click
        If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GetQuery()
            rpt.Query = query
            lblunit.Text = frmdkloc.cbbmau.Text
        End If
    End Sub    

#Region "form dkloc"
    Sub setupdkloc()        
        'ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select * from optgroupby where  rptid ='" & rptid & "'", frmdkloc.cbbnhom_theo, "headerv", "headere", "codeid")
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        'query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtden_nam.Value)
        'query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kho.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_nv.Text)
        'query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_ca.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_bp.Text)
        'query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
    End Sub

#End Region
    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click, btnIN.Click
        If sender.name = btnpreview.Name Then
            rpt.cPrint.Show()
        Else
            rpt.cPrint.Print()
        End If
    End Sub
    Sub SetParas()
        For Each c As DataGridViewColumn In grd.Columns
            If c.Visible = True Then
                rpt.cPrint.SetParameterValue(c.Name, c.HeaderText)
            End If
        Next
        rpt.cPrint.SetParameterValue("tu_nam", frmdkloc.txtnam.Value)
        'rpt.cPrint.SetParameterValue("den_nam", frmdkloc.txtden_nam.Value)
        'rpt.cPrint.SetParameterValue("ma_kho", frmdkloc.txtma_kho.Text)
        'rpt.cPrint.SetParameterValue("ten_kho", frmdkloc.ten_kho.Text)
        rpt.cPrint.SetParameterValue("ma_nv", frmdkloc.txtma_nv.Text)
        rpt.cPrint.SetParameterValue("ten_nv", frmdkloc.ten_nv.Text)
        'rpt.cPrint.SetParameterValue("ma_ca", frmdkloc.txtma_ca.Text)
        'rpt.cPrint.SetParameterValue("ten_ca", frmdkloc.ten_ca.Text)
        rpt.cPrint.SetParameterValue("ma_bp", frmdkloc.txtma_bp.Text)
        rpt.cPrint.SetParameterValue("ten_bp", frmdkloc.ten_bp.Text)
    End Sub

    Private Sub btnrefresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
    End Sub
End Class
