Public Class MainForm
    Dim rpt As ClsRpt.rpt

    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim oLable As Collection
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs, True)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        'load du lieu
        If Clsql.Others.GetArgu(4) <> "" Then
            query = Clsql.Others.GetArgu(4)
            ' Me.Text = oLable(Me.Tag) & " " & Clsql.Others.GetArgu(3)
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

        Dim oma_vt As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmvt", frmdkloc.txtma_vt, "ma_vt", False)
        Dim oma_kh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_kh", False)
        Dim oma_ncc As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_ncc, "ma_kh", False)
        Dim oma_dt As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmdt", frmdkloc.txtma_dt, "ma_dt", False)
        Dim oma_kho As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkho", frmdkloc.txtma_kho, "ma_kho", False)

        Dim oma_nv As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmnv", frmdkloc.txtma_nv, "ma_nv", False)


        If Clsql.Reg.GetValue("Language") = "Vi" Then
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select codeid,headerV as txt from optgroupby where type =1 and rptid ='" & rptid & "'", frmdkloc.cbbbctheo, "txt", "codeid")
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select codeid,headerV as txt from optgroupby where type =2 and rptid ='" & rptid & "'", frmdkloc.cbbnhom, "txt", "codeid")
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid,headerV as txt from optgroupby where type =2 and rptid ='" & rptid & "'", frmdkloc.cbbnhomtheo2, "txt", "codeid")
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid,headerV as txt from optgroupby where type =2 and rptid ='" & rptid & "'", frmdkloc.cbbnhomtheo3, "txt", "codeid")

            oma_vt.SetValue("ten_vt", frmdkloc.ten_vt)
            oma_kh.SetValue("ten_kh", frmdkloc.ten_kh)
            oma_ncc.SetValue("ten_kh", frmdkloc.ten_ncc)
            oma_kho.SetValue("ten_kho", frmdkloc.ten_kho)
            oma_dt.SetValue("ten_dt", frmdkloc.ten_dt)
            oma_nv.SetValue("ten_nv", frmdkloc.ten_nv)

        Else
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select codeid,headerE as txt from optgroupby where type =1 and rptid ='" & rptid & "'", frmdkloc.cbbbctheo, "txt", "codeid")
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select codeid,headerE as txt from optgroupby where type =2 and rptid ='" & rptid & "'", frmdkloc.cbbnhom, "txt", "codeid")
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid,headerE as txt from optgroupby where type =2 and rptid ='" & rptid & "'", frmdkloc.cbbnhomtheo2, "txt", "codeid")
            ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select codeid,headerE as txt from optgroupby where type =2 and rptid ='" & rptid & "'", frmdkloc.cbbnhomtheo3, "txt", "codeid")

            oma_vt.SetValue("ten_vt2", frmdkloc.ten_vt)
            oma_kh.SetValue("ten_kh2", frmdkloc.ten_kh)
            oma_ncc.SetValue("ten_kh2", frmdkloc.ten_ncc)
            oma_kho.SetValue("ten_kho2", frmdkloc.ten_kho)
            oma_dt.SetValue("ten_dt2", frmdkloc.ten_dt)
            oma_nv.SetValue("ten_nv", frmdkloc.ten_nv)
        End If


        Try
            frmdkloc.Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
            frmdkloc.TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")
            If Clsql.Reg.GetValue(rptid & "bctheo") <> "" Then
                frmdkloc.cbbbctheo.SelectedValue = Clsql.Reg.GetValue(rptid & "bctheo")
                frmdkloc.cbbnhom.SelectedValue = Clsql.Reg.GetValue(rptid & "nhomtheo")
                frmdkloc.cbbnhomtheo2.SelectedValue = Clsql.Reg.GetValue(rptid & "nhomtheo2")
                frmdkloc.cbbnhomtheo3.SelectedValue = Clsql.Reg.GetValue(rptid & "nhomtheo3")
            End If

        Catch ex As Exception
        End Try

    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & ",''"
        query = query & ",''"
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_vt.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_ncc.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kho.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_dt.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_nv.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.chbchung_tu_dc.Checked)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbbctheo.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbnhom.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbnhomtheo2.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbnhomtheo3.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(rptid)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnh_kh1.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnh_kh2.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnh_kh3.Text)

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
        rpt.cPrint.SetParameterValue("ten_ncc", frmdkloc.ten_ncc.Text)
        rpt.cPrint.SetParameterValue("ten_kh", frmdkloc.ten_kh.Text)

    End Sub

   
End Class
