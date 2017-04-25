Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim oLable As Collection
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        AddHandler rpt.AfterGetData, AddressOf aftergetdata
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        'load du lieu
        If Clsql.Others.GetArgu(2) <> "" Then
            query = Clsql.Others.GetArgu(2)
            Me.Text = oLable(Me.Tag) & " " & Clsql.Others.GetArgu(3) & " " & Clsql.Others.GetArgu(4)
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
        lblunit.Text = frmdkloc.cbbma_dvcs.Text
        'ClsControl2.PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        ClsControl2.PropertyOfForm.SetImage4Control("find.bmp", btndkloc)
        ClsControl2.PropertyOfForm.SetImage4Control("refresh.bmp", btnrefresh2)
        printer.Text = rpt.cPrint.GetPrinter
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas

    End Sub
    Dim ds As DataSet
    Private Sub aftergetdata(dataset As DataSet)
        ds = dataset
        importdata()
    End Sub
    Sub importdata()
        Dim query As String = rpt.conn.GetInsertQueryFromDatatable(ds.Tables(0), "thsdhoadon")
        query = "delete from thsdhoadon where ky=" & frmdkloc.txtky.Value & " and nam =" & frmdkloc.txtnam.Value & Chr(13) & query
        rpt.conn.Execute(query)
    End Sub

    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btndkloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndkloc.Click
        If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GetQuery()
            rpt.Query = query
            lblunit.Text = frmdkloc.cbbma_dvcs.Text
        End If
    End Sub
    

#Region "form dkloc"
    Sub setupdkloc()
        If Clsql.Reg.GetValue("kieu_bc_thue") <> "" Then
            frmdkloc.cbbkieu.SelectedIndex = 0
        Else
            frmdkloc.cbbkieu.SelectedIndex = Clsql.Reg.GetValue("kieu_bc_thue")
        End If

        If frmdkloc.cbbkieu.SelectedIndex = 0 Then
            frmdkloc.txtky.Maximum = 12
            frmdkloc.txtky.Value = Now.Month - 1
        Else
            frmdkloc.txtky.Maximum = 4

        End If
        frmdkloc.txtnam.Value = Now.Year

    End Sub

    Sub GetQuery()
        Dim kieu As String = "T"
        If frmdkloc.cbbkieu.SelectedIndex = 1 Then
            kieu = "Q"
        End If
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(kieu)
    End Sub

#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
    End Sub

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

    End Sub
    Dim old_value
    Private Sub grd_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellValidated
        Dim new_value = grd.Item(e.ColumnIndex, e.RowIndex).Value
        If new_value <> old_value Then
            ds.AcceptChanges()
            'save to database
            importdata()
            'refresh
            Dim kieu As String = "T"
            If frmdkloc.cbbkieu.SelectedIndex = 1 Then
                kieu = "Q"
            End If
            Dim query As String = "exec  " & rpt.cPrint.Store
            query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
            query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
            query = query & "," & rpt.conn.ConvertToSQLType(kieu)
            query = query & "," & rpt.conn.ConvertToSQLType(grd.Item("ma_hoa_don", e.RowIndex).Value)
            query = query & "," & rpt.conn.ConvertToSQLType(grd.Item("ky_hieu_hoa_don", e.RowIndex).Value)
            query = query & "," & rpt.conn.ConvertToSQLType(grd.Item("kh_hoa_don", e.RowIndex).Value)
            Dim dt_tmp As DataTable = rpt.conn.GetDatatable(query)
            If dt_tmp.Rows.Count > 0 Then
                For Each c As DataColumn In dt_tmp.Columns
                    grd.Item(c.ColumnName, e.RowIndex).Value = dt_tmp.Rows(0).Item(c.ColumnName)
                Next
            End If


        End If

    End Sub

    Private Sub grd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellEnter
        old_value = grd.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub
End Class
