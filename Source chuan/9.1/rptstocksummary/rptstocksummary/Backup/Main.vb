Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        Dim oLable As Collection = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon

        'them nut xem chi tiet
        rpt.DrillDown.convert2sql_yn = True
        'load du lieu
        If Clsql.Others.GetArgu(2) <> "" Then
            query = Clsql.Others.GetArgu(2)
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
        'ClsControl2.PropertyOfForm.SetImage4Control("printer.bmp", lbluser)
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        
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
        Try
            frmdkloc.Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
            frmdkloc.TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid,headerV as txt,headerE as txt2 from optgroupby where type =2 and rptid ='rstocksummary'", frmdkloc.cbbnhom_theo, "txt", "txt2", "codeid")
        Catch ex As Exception
        End Try
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store & " "
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_Kho.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_vt.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_nhvt.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtloai_vt.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_ncc.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.chbct_dc.Checked)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.chbton.Checked)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbnhom_theo.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk_vt.Text)
        'xem chi tiet
        Dim xemsokho As String = ""
        xemsokho = xemsokho & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        xemsokho = xemsokho & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        xemsokho = xemsokho & ",'?ma_kho?'"
        xemsokho = xemsokho & ",'?ma_vt?'"
        xemsokho = xemsokho & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        xemsokho = xemsokho & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("Language"))
        rpt.DrillDown.setCondition("thekho", xemsokho)

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
        rpt.cPrint.SetParameterValue("tu_ngay", frmdkloc.Txttu_ngay.Value)
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.TxtDen_ngay.Value)
        rpt.cPrint.SetParameterValue("ma_kho", frmdkloc.txtma_Kho.Text)
        rpt.cPrint.SetParameterValue("ten_kho", frmdkloc.ten_kho.Text)
    End Sub

    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        'If String.IsNullOrEmpty(grd.CurrentRow.Cells("ma_vt").Value.ToString) Then
        '    rpt.DrillDown.Enable(0) = False
        'Else
        '    rpt.DrillDown.Enable(0) = True
        'End If
    End Sub

    Private Sub grd_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grd.DataError

    End Sub
End Class
