Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim oLable As Collection
    Dim kieu As Integer
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        kieu = Clsql.Others.GetArgu(2)
        'load du lieu
        If Clsql.Others.GetArgu(3) <> "" Then
            query = Clsql.Others.GetArgu(3)
            Me.Text = oLable(Me.Tag) & " " & Clsql.Others.GetArgu(4)
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
            frmdkloc.Txtden_ngay.Value = Clsql.Reg.GetValue("du_ngay")

        Catch ex As Exception
        End Try
        frmdkloc.txttk.Text = rpt.conn.GetValue("select textv from forminfo where textid ='mtk' and formid='" & rptid & "'")

        'Dim oTK As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk", False, False)
        'If Clsql.Reg.GetValue("Language") = "Vi" Then
        '    oTK.SetValue("ten_tk", frmdkloc.ten_tk)
        'Else
        '    oTK.SetValue("ten_tk2", frmdkloc.ten_tk)
        'End If

        ' ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select ma_dvcs,ten_dvcs from ddv", frmdkloc.cbbma_dvcs, "ten_dvcs", "ma_dvcs")
       

    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(kieu)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk.Text)
        'xem chi tiet
        Dim xemsocai As String = rpt.conn.ConvertToSQLType(kieu)
        xemsocai = xemsocai & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        xemsocai = xemsocai & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        xemsocai = xemsocai & ",'?tk_du?'"
        rpt.DrillDown.convert2sql_yn = True
        rpt.DrillDown.setCondition("sodu", xemsocai)
        Me.Text = oLable(Me.Tag) & " " & frmdkloc.txttk.Text
        rpt.conn.Execute("update forminfo set textv = '" & frmdkloc.txttk.Text & "', texte ='" & frmdkloc.txttk.Text & "' where textid ='mtk' and formid='" & rptid & "'")

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
        rpt.cPrint.SetParameterValue("tu_ngay", frmdkloc.Txtden_ngay.Value)
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.TxtDen_ngay.Value)
        rpt.cPrint.SetParameterValue("tk", frmdkloc.txttk.Text)
        'rpt.cPrint.SetParameterValue("ten_tk", frmdkloc.ten_tk.Text)
    End Sub

   
End Class
