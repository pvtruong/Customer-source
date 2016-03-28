Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim oLable As Collection
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs, False, False)
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
        grd.Columns("ten_kh").Frozen = True
        ds = dataset
        importdata()
    End Sub
    Sub importdata()
        Dim query As String = "delete from phicanho where thang=" & frmdkloc.txtky.Value & " and nam =" & frmdkloc.txtnam.Value
        If frmdkloc.txtma_kh.Text <> "" Then
            query = query & " and ma_kh='" & frmdkloc.txtma_kh.Text & "'"
        End If
        query = query & Chr(13) & rpt.conn.GetInsertQueryFromDatatable(ds.Tables(0), "phicanho")
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
        frmdkloc.txtky.Maximum = 12
        frmdkloc.txtky.Value = Now.Month
        frmdkloc.txtnam.Value = Now.Year

    End Sub

    Sub GetQuery()

        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(False)
    End Sub

#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
    End Sub
    Sub print(ByVal kieu As Integer)
        grd.EndEdit()
        Dim qr = From r As DataGridViewRow In grd.Rows Where r.Cells("sel").Value = True
        For Each r As DataGridViewRow In qr
            Dim ds As New DataSet
            Dim rd As DataRow = r.DataBoundItem.row
            Dim dt As DataTable = rd.Table.Clone
            Dim nr As DataRow = dt.NewRow
            dt.Rows.Add(nr)
            For Each c As DataColumn In dt.Columns
                nr(c.ColumnName) = rd(c.ColumnName)
            Next
            ds.Tables.Add(dt)
            rpt.cPrint.Dataset = ds
            Try
                If kieu = 1 Then
                    rpt.cPrint.Print()
                Else
                    rpt.cPrint.RefreshReport()
                    rpt.cPrint.PrintRPT.ShowDialog(Me)
                End If
            Catch ex As Exception

            End Try

        Next



    End Sub
    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click, btnIN.Click
        If sender.name = btnpreview.Name Then
            print(2)
        Else
            print(1)
        End If
    End Sub
    Sub SetParas()
        For Each c As DataGridViewColumn In grd.Columns
            If c.Visible = True Then
                rpt.cPrint.SetParameterValue(c.Name, c.HeaderText)
            End If
        Next
        rpt.cPrint.SetParameterValue("thang", frmdkloc.txtky.Value)
        rpt.cPrint.SetParameterValue("nam", frmdkloc.txtnam.Value)

    End Sub
    Dim old_value
    Private Sub grd_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellValidated
        If (grd.Columns(e.ColumnIndex).Name = "sel") Then
            Return
        End If
        Dim new_value = grd.CurrentRow.Cells(e.ColumnIndex).Value
        If new_value <> old_value Then
            ds.AcceptChanges()
            'save to database
            Try
                Dim query As String = "update phicanho set " & grd.Columns(e.ColumnIndex).Name & "=" & rpt.conn.ConvertToSQLType(new_value)
                query = query & " where thang=" & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
                query = query & " and nam = " & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
                query = query & " and ma_kh = " & rpt.conn.ConvertToSQLType(grd.CurrentRow.Cells("ma_kh").Value)
                rpt.conn.Execute(query)
                'refresh
                query = "exec  " & rpt.cPrint.Store
                query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
                query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
                query = query & "," & rpt.conn.ConvertToSQLType(grd.CurrentRow.Cells("ma_kh").Value)
                query = query & "," & rpt.conn.ConvertToSQLType(True)
                Dim dt_tmp As DataTable = rpt.conn.GetDatatable(query)

                If dt_tmp.Rows.Count > 0 Then
                    Dim current_row As DataRow = grd.CurrentRow.DataBoundItem.row
                    Dim source = grd.DataSource
                    grd.DataSource = Nothing
                    For Each c As DataColumn In dt_tmp.Columns
                        Dim c_name As String = c.ColumnName
                        current_row.Item(c_name) = dt_tmp.Rows(0).Item(c_name)
                    Next
                    grd.DataSource = source
                End If
            Catch ex As Exception
                MsgBox(ex.Message )
            End Try



        End If

    End Sub

    Private Sub grd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellEnter
        old_value = grd.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnGhiCongNo.Click
        query = "exec  postglchiphi"
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("unit"))

        Dim ds As DataSet = rpt.conn.GetDataSet(query)
        query = ""
        For Each tb As DataTable In ds.Tables
            query = query & Chr(13) & rpt.conn.GetInsertQueryFromDatatable(tb, "socai")
        Next
        rpt.conn.Execute(query)
        MsgBox("Chương trình đã thực hiện xong",, Clsql.AboutMe.Name)
    End Sub

    Private Sub tinhlai_Click(sender As Object, e As EventArgs) Handles btnTinhLai.Click
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtky.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(True)
        btnrefresh2.PerformClick()
    End Sub

    Private Sub btnInphieu_Click(sender As Object, e As EventArgs)

    End Sub

End Class
