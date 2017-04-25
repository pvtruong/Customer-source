Public Class MainForm
    Dim WithEvents rpt As ClsRpt.rpt
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
            Me.Text = oLable(Me.Tag) & " " & Clsql.Others.GetArgu(3)
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
        'Hiển thị hộp tìm kiếm         
        Dim makh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_kh", False)
        Dim matk As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk", False)
        'Hiển thị tên qua nhãn
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            matk.SetValue("ten_tk", frmdkloc.lblten_tk)
        Else 'Nếu là tiếng Anh
            matk.SetValue("ten_tk2", frmdkloc.lblten_tk)
        End If
        makh.SetValue("ten_kh", frmdkloc.lblten_kh)
        'Lấy giá trị nhớ hiển thị lên TextBox 
        Try
            frmdkloc.txtden_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
            frmdkloc.txtngay_tt.Value = Clsql.Reg.GetValue("ngay_tt")
        Catch ex As Exception
        End Try
    End Sub

    Sub GetQuery() 'SỬA CÂU LỆNH THỰC THI
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtden_ngay.Value) 'Chú ý
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtngay_tt.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtkhoang_tg.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.chbonly_sumary.Checked)
        query = query & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("id"))
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

    Sub SetParas() 'SỬA CÁC BIẾN TRUYỀN VÀO
        For Each c As DataGridViewColumn In grd.Columns
            If c.Visible = True Then
                rpt.cPrint.SetParameterValue(c.Name, c.HeaderText)
            End If
        Next
        'Truyền biến cho thủ tục
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.txtden_ngay.Value)
        rpt.cPrint.SetParameterValue("ngay_tt", frmdkloc.txtngay_tt.Value)
        rpt.cPrint.SetParameterValue("ma_dvcs", frmdkloc.cbbma_dvcs.SelectedValue)
        rpt.cPrint.SetParameterValue("tk", frmdkloc.txttk.Text)
        rpt.cPrint.SetParameterValue("ma_kh", frmdkloc.txtma_kh.Text)
        rpt.cPrint.SetParameterValue("khoang_tg", frmdkloc.txtkhoang_tg.Text)
    End Sub

    Private Sub rpt_AfterGetData(ByVal dataset As System.Data.DataSet) Handles rpt.AfterGetData
        grd.Columns("qua_han_nt1").HeaderText = grd.Columns("qua_han_nt1").HeaderText.Replace("%1", frmdkloc.txtkhoang_tg.Value)
        grd.Columns("qua_han_nt2").HeaderText = grd.Columns("qua_han_nt2").HeaderText.Replace("%1", frmdkloc.txtkhoang_tg.Value + 1).Replace("%2", frmdkloc.txtkhoang_tg.Value * 2)
        grd.Columns("qua_han_nt3").HeaderText = grd.Columns("qua_han_nt3").HeaderText.Replace("%2", frmdkloc.txtkhoang_tg.Value * 2 + 1).Replace("%3", frmdkloc.txtkhoang_tg.Value * 3)
        grd.Columns("qua_han_nt4").HeaderText = grd.Columns("qua_han_nt4").HeaderText.Replace("%3", frmdkloc.txtkhoang_tg.Value * 3)
    End Sub
End Class
