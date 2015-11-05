Public Class MainForm

    Dim frmdkloc As New frmfilter
    Dim rptid As String = ""
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        AddHandler rpt.AfterGetData, AddressOf rpt_AfterGetData
        Dim xct As New clsViDe.DropDownButtonDetail(rpt.conn, Me.ToolStrip1, "rsochitiet", grddetail)
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
        ClsControl2.PropertyOfForm.SetImage4Control("form.bmp", btnmform)
        printer.Text = rpt.cPrint.GetPrinter
        'ClsControl2.PropertyOfForm.SetImage4Control("printer.bmp", lbluser)
        
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
            frmdkloc.Txtden_ngay.Value = Clsql.Reg.GetValue("den_ngay")
            frmdkloc.txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        Catch ex As Exception
        End Try
        

    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.Txtden_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.Txtngay_dau_ky0.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.Txtngay_cuoi_ky0.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(rpt.cPrint.drvForm("idform"))
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_bp.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_phi.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_dt.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_nv.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_hd.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)

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
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.Txtden_ngay.Value)
        rpt.cPrint.SetParameterValue("tu_ngay", frmdkloc.txttu_ngay.Value)

        rpt.cPrint.SetParameterValue("ma_bp", frmdkloc.txtma_bp.Text)
        rpt.cPrint.SetParameterValue("ten_bp", frmdkloc.ten_bp.Text)


        rpt.cPrint.SetParameterValue("ma_phi", frmdkloc.txtma_phi.Text)
        rpt.cPrint.SetParameterValue("ten_phi", frmdkloc.ten_phi.Text)

        rpt.cPrint.SetParameterValue("ma_nv", frmdkloc.txtma_nv.Text)
        rpt.cPrint.SetParameterValue("ten_nv", frmdkloc.ten_nv.Text)

        rpt.cPrint.SetParameterValue("ma_dt", frmdkloc.txtma_dt.Text)
        rpt.cPrint.SetParameterValue("ten_dt", frmdkloc.ten_dt.Text)

        rpt.cPrint.SetParameterValue("ma_kh", frmdkloc.txtma_kh.Text)
        rpt.cPrint.SetParameterValue("ten_kh", frmdkloc.ten_kh.Text)

    End Sub
    Private Sub btnmform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmform.Click
        Dim fmau As New frmkbmau
        fmau.Icon = Me.Icon
        fmau.Show()
    End Sub

    Dim ds As DataSet
    Private Sub rpt_AfterGetData(ByVal dataset As System.Data.DataSet)
        ds = dataset
        ' griddetail.DataSource = ds.Tables(1)
        ClsControl2.PropertyOfGrid.FillGrid(rpt.conn, rptid & "D", grddetail, ds.Tables(1).DefaultView)
        grddetail.AllowUserToAddRows = False
        grddetail.AllowUserToDeleteRows = False
        Try
            ds.Tables(1).DefaultView.RowFilter = "ma_so like '%" & grd.CurrentRow.Cells("ma_so").Value.ToString & "#%'"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        Try
            ds.Tables(1).DefaultView.RowFilter = "ma_so like '%" & grd.CurrentRow.Cells("ma_so").Value.ToString & "#%'"

        Catch ex As Exception

        End Try
    End Sub
End Class
