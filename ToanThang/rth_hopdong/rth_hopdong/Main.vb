Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim oLable As Collection
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
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
        Catch ex As Exception
        End Try

       

        If Clsql.Reg.GetValue("Language") = "Vi" Then
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid as value,headerV as txt from optgroupby where rptid ='" & rptid & "'", frmdkloc.cbbnhom_theo, "txt", "value")
        Else
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid as value,headerE as txt from optgroupby where rptid ='" & rptid & "'", frmdkloc.cbbnhom_theo, "txt", "value")
        End If
        ' ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select ma_dvcs,ten_dvcs from ddv", frmdkloc.cbbma_dvcs, "ten_dvcs", "ma_dvcs")

    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)

        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)

        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_dt.Text)


        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbnhom_theo.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)


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

        rpt.cPrint.SetParameterValue("ma_kh", frmdkloc.txtma_kh.Text)
        rpt.cPrint.SetParameterValue("ten_kh", frmdkloc.lblten_kh.Text)

        rpt.cPrint.SetParameterValue("ma_dt", frmdkloc.txtma_dt.Text)
        rpt.cPrint.SetParameterValue("ten_dt", frmdkloc.lblten_dt.Text)
    End Sub
   
End Class
