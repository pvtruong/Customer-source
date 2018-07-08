Public Class frmbrwPrint
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = "pn6_print"
    Dim frmdkloc As New frmPrint
    Dim query As String = ""
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rpt = New ClsRpt.rpt(conn, rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        Dim oLable As Collection = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        'load du lieu
        If Clsql.Others.GetArgu(2) <> "" Then
            query = Clsql.Others.GetArgu(2)
        Else
            If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GetQuery()
                If query = "" Then
                    Me.Close()
                    Return
                End If
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


    End Sub

    Sub GetQuery()
        query = ""
        If Voucher.Stt_rec IsNot Nothing Then
            query = "exec  " & rpt.cPrint.Store
            query = query & " " & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("Language"))
            query = query & "," & rpt.conn.ConvertToSQLType(Voucherid)
            query = query & "," & rpt.conn.ConvertToSQLType(Voucher.Stt_rec)
        End If
        
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
        '
        rpt.cPrint.SetParameterValue(Voucherid, Voucher.Mdatatable.Select("stt_rec='" & Voucher.Stt_rec & "'")(0))
    End Sub

    Private Sub grd_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEndEdit
        rpt.DataSource.EndEdit()
    End Sub
End Class