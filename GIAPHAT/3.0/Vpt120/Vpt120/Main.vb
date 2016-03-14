Imports Clsql
Imports ClsControl2
Imports ClsControl2.PropertyOfForm
Imports ClsLookup
Imports ClsSV
Imports System.ComponentModel

Public Class Frmmain
    Dim frmin As New frminput
    'Dim WithEvents oKH As ClsLookup.AutoCompleteLookup
    Dim WithEvents bgwk As New BackgroundWorker
    Delegate Sub delegateloadf()
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'kiem tra dang ky
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        txtuser.Text = Clsql.Reg.GetValue("ID")
        '
        Voucher = New Voucher20(Voucherid, grd, frmin.grddetail, frmin)
        'Voucher.autoRefreshMaster = False
        conn = Voucher.conn

        Voucher.btnpostGL.Visible = False
        Voucher.btnPostStock.Visible = False
        SetLable(Voucher.oLan, Me)
        Me.Icon = frmin.Icon
        Voucher.AddToolStrip(ToolStrip1)
        Dim ctm As New ContextMenuStrip
        Voucher.AddContextMenuStrip(ctm)
        Me.ContextMenuStrip = ctm
        'khai bao lookup
        bgwk.RunWorkerAsync()
        '
    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuthoat.Click
        Voucher = Nothing
        Me.Close()
    End Sub
    Private Sub tim()
        Dim search As New frmsearch
        search.Icon = Me.Icon
        search.StartPosition = FormStartPosition.CenterParent
        If search.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Clsql.Reg.SetValue("tu_ngay", search.Txttu_ngay.Value)
            Clsql.Reg.SetValue("den_ngay", search.TxtDen_ngay.Value)
            Clsql.Reg.SetValue("ma_kh", search.txtma_kh.Text)

            Dim query As String
            Dim strdk As String = " ngay_ct between " & Voucher.conn.ConvertToSQLType(search.Txttu_ngay.Value) & " and " & Voucher.conn.ConvertToSQLType(search.TxtDen_ngay.Value)
            strdk = strdk & " and  ma_kh like '" & search.txtma_kh.Text & "%'"
            strdk = strdk & " and  so_ct like '" & search.txtso_ct.Text & "%'"


            query = Voucher.QueryLoad & " and " & strdk & " and stt_rec in " & "(select stt_rec from " & Voucher.Tabdetails(Voucher.DViewName).TableName & " where "

            query = query & " ma_bp like '" & search.txtma_bp.Text
            query = query & "%' and ma_phi like '" & search.txtma_phi.Text
            query = query & "%' and ma_dt like '" & search.txtma_dt.Text & "%')"


            Voucher.LoadData(query.Replace("#*#", "cast(0 as bit) as sel,*"))
        End If

    End Sub
 
    Private Sub grd_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grd.RowsAdded
        txtt_tien_nt.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(grd, "t_tien_nt"), f_tien_nt)
    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved
        txtt_tien_nt.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(grd, "t_tien_nt"), f_tien_nt)
    End Sub
    Sub beforeadd(ByVal e As String)
        Dim defaultvalue As New Collection
        defaultvalue.Add("VND", "ma_nt")
        defaultvalue.Add(Now, "ngay_ct")
        Voucher.ValueDefaults = defaultvalue

    End Sub
    Sub detailHD_load(ByVal e As String)
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            frmin.Txtngay_ct.Value = Now
        Else
            frmin.Txtngay_ct.Value = grd.Item("ngay_ct", grd.CurrentRow.Index).Value
            frmin.txtma_kh.Text = grd.Item("ma_kh", grd.CurrentRow.Index).Value
        End If
        Voucher.Tabdetails("tdttno").Datatable = conn.GetDatatable("Exec GetInvoice4Rec ''," & conn.ConvertToSQLType(frmin.Txtngay_ct.Value) & "," & Voucher.Action & "," & conn.ConvertToSQLType(e))
     
        Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable
        frmin.Txtt_tien_nt.Value = ClsControl2.PropertyOfGrid.Sum(frmin.grddetailhd, "tien_nt")
        frmin.Txtt_tien.Value = ClsControl2.PropertyOfGrid.Sum(frmin.grddetailhd, "tien")
    End Sub

    Sub detailpgh_load(ByVal e As String)
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            frmin.Txtngay_ct.Value = Now
        Else
            frmin.Txtngay_ct.Value = grd.Item("ngay_ct", grd.CurrentRow.Index).Value
            frmin.txtma_kh.Text = grd.Item("ma_kh", grd.CurrentRow.Index).Value
        End If
        Voucher.Tabdetails("tdttno").Datatable = conn.GetDatatable("Exec GetPGH4Rec ''," & conn.ConvertToSQLType(frmin.Txtngay_ct.Value) & "," & Voucher.Action & "," & conn.ConvertToSQLType(e))

        Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable
        frmin.Txtt_tien_nt.Value = ClsControl2.PropertyOfGrid.Sum(frmin.grddetailhd, "tien_nt")
        frmin.Txtt_tien.Value = ClsControl2.PropertyOfGrid.Sum(frmin.grddetailhd, "tien")
    End Sub
    Sub detailpin_load(ByVal e As String)
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            frmin.Txtngay_ct.Value = Now
        Else
            frmin.Txtngay_ct.Value = grd.Item("ngay_ct", grd.CurrentRow.Index).Value
            frmin.txtma_kh.Text = grd.Item("ma_kh", grd.CurrentRow.Index).Value
        End If
        Voucher.Tabdetails("tdttno").Datatable = conn.GetDatatable("Exec GetPIN4Rec ''," & conn.ConvertToSQLType(frmin.Txtngay_ct.Value) & "," & Voucher.Action & "," & conn.ConvertToSQLType(e))

        Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable
        frmin.Txtt_tien_nt.Value = ClsControl2.PropertyOfGrid.Sum(frmin.grddetailhd, "tien_nt")
        frmin.Txtt_tien.Value = ClsControl2.PropertyOfGrid.Sum(frmin.grddetailhd, "tien")
    End Sub

    Sub SetUpLookup()
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'status'", frmin.cbbstatus, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'ma_gd'", frmin.cbbma_gd, "text", "text2", "inds")


        'oKH = New ClsLookup.AutoCompleteLookup(Voucher.conn, "ldkh", frmin.txtma_kh, "ma_kh")
        'oKH.SetValue("ten_kh", frmin.txtten_kh)
        'oKH.SetValue("dia_chi", frmin.txtdia_chi)
        AddHandler Voucher.FormLookups("txtma_kh").AfterLookup, AddressOf oKH_AfterLookup

        layhd = New GetDataByStore(Voucher.conn, "dpt1_ghd", "TTHD")
        AddHandler layhd.BeforeShow, AddressOf BeforeShowInvoide

        '
        laypgh = New GetDataByStore(Voucher.conn, "pt1_gpgh", "TTPGH")
        AddHandler laypgh.BeforeShow, AddressOf BeforeShowPGH
        '
        laypin = New GetDataByStore(Voucher.conn, "pt1_gpin", "TTPIN")
        AddHandler laypin.BeforeShow, AddressOf BeforeShowPIN


        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "exec s_dmnt", frmin.cbbma_nt, "ten_nt", "ma_nt")

    End Sub


    Sub AfterDeleted(ByVal e As String)
        If querytt <> "" Then
            conn.Execute(querytt)
        End If
        '
        conn.Execute("Update DeletedVoucher set nguoi_sua= '" & txtuser.Text & "',ngay_sua= getdate() where stt_rec ='" & e & "'")

    End Sub
    Sub BeforeDelete(ByVal e As String)
        Dim dt As DataTable = conn.GetDatatable("select stt_rec_tt,ma_ct_tt from tdttno where stt_rec ='" & e & "'")
        For Each r As DataRow In dt.Rows
            querytt = querytt & Chr(13) & "EXEC Tatoanno '" & r("stt_rec_tt") & "','" & r("ma_ct_tt") & "'"
        Next
    End Sub
    Sub BeforeShowInvoide(ByVal dv As DataView)
        For Each r As DataRow In dv.Table.Select("tien_nt<>0")
            r("sel") = True
        Next

    End Sub
    Sub BeforeShowPGH(ByVal dv As DataView)
        For Each r As DataRow In dv.Table.Select("tien_nt<>0")
            r("sel") = True
        Next

    End Sub
    Sub BeforeShowPIN(ByVal dv As DataView)
        For Each r As DataRow In dv.Table.Select("tien_nt<>0")
            r("sel") = True
        Next

    End Sub
    Sub loadf()
       
        'thanh toan theo hoa don
        Voucher.Tabdetails("tdttno").gridview = frmin.grddetailhd

        Voucher.Tabdetails("tdttno").AutoLoad = False
        AddHandler Voucher.Tabdetails("tdttno").Load, AddressOf detailHD_load


       

        '
        f_tien = Clsql.Format.GetFormatNumeric(conn)
        f_tien_nt = Clsql.Format.GetFormatNumeric(conn, "f_tien_nt")
        f_so_luong = Clsql.Format.GetFormatNumeric(conn, "f_sl")
        ma_nt_ht = Clsql.Others.Options("a_dtht", conn)
        '
        grd.ReadOnly = False
        Voucher.btnCancel = frmin.btnhuy
        AddHandler Voucher.btnFind.Click, AddressOf tim
        AddHandler Voucher.BeforeAdd, AddressOf beforeadd
        AddHandler Voucher.BeforeDelete, AddressOf BeforeDelete
        AddHandler Voucher.AfterDelete, AddressOf AfterDeleted
        AddHandler Voucher.Tabdetails(Voucher.DViewName).lookups("tk_co").AfterLookup, AddressOf Aftertk_colookup

        AddHandler ClsSV.Functions.BeforePost, AddressOf BeforePost
        AddHandler ClsSV.Functions.AfterPost, AddressOf AfterPost
        AddHandler Voucher.AfterImportFromExcel, AddressOf postimportfromexcel

        'SetUpLookup()
        SetLable(Voucher.oLan, fPrintDialog)
        fPrintDialog.Icon = frmin.Icon
        'print
        oPrint = New ClsSV.Print20(Voucher, fPrintDialog.cbbmau, fPrintDialog.txttieu_de, fPrintDialog.Txtso_lien)  'New ClPrint.Print(conn, Voucherid, fPrintDialog.cbbmau, fPrintDialog.txttieu_de)
        AddHandler oPrint.BeforeShowReport, AddressOf beforePrintpt
        AddHandler Voucher.btnPrint.Click, AddressOf oPrint.Print  'printF
        fPrintDialog.StartPosition = FormStartPosition.CenterParent
        fPrintDialog.Txtso_lien.Value = Voucher.Voucherinfo("d_so_lien")
        'set up formtask
        SetLable(Voucher.oLan, formtask)
        formtask.Icon = Me.Icon
        'load data
        Voucher.LoadFirst()
        
    End Sub
    Private Sub bgwk_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwk.DoWork
        SetUpLookup()
        grd.BeginInvoke(New delegateloadf(AddressOf loadf))
    End Sub
    Sub Aftertk_colookup(ByVal row As DataRow, ByVal gridrow As DataGridViewRow)
        gridrow.Cells("tk_co").Tag = row("tk_cn")
        If row("loai_cl_co") = 0 Then
            gridrow.Cells("ty_gia_gs_co").Value = 0
        End If
        If row("tk_cn") = True Then
            gridrow.Cells("ma_kh").Tag = "NOTNULL"
        Else
             gridrow.Cells("ma_kh").Tag = ""
        End If
    End Sub

    Private Sub oKH_AfterLookup(ByVal row As ClsStpService.StpTableRow)

        If frmin.grddetail.Visible = True Then
            For Each r As DataGridViewRow In frmin.grddetail.Rows

                If r.IsNewRow = False Then
                    r.Cells("ma_kh").Value = row("ma_kh")
                End If
            Next
        End If
    End Sub

    Sub BeforePost(ByVal ma_ct As String, ByVal stt_rec As String, ByVal status As Integer)
        If querytt <> "" Then
            conn.Execute(querytt)
        End If
    End Sub
    Sub AfterPost(ByVal ma_ct As String, ByVal stt_rec As String, ByVal status As Integer)
        querytt = getQuerytattoan()
        If querytt <> "" Then
            conn.Execute(querytt)
        End If
    End Sub
    Sub beforePrintpt()
        oPrint.oPrint.SetParameterValue("sctkt", fPrintDialog.Txtsctkt.Value)
        oPrint.oPrint.SetParameterValue("dien_giai_ctg", fPrintDialog.txtdien_giai_ctg.Text)
    End Sub
    Sub postimportfromexcel(ByVal dicstt_rec As Dictionary(Of String, String), ByVal status As Integer)
        For Each stt_rec As String In dicstt_rec.Keys
            ClsSV.Functions.Post(conn, Voucherid, Voucher.tenbangchung, Voucher.Stt_rec, status)
        Next
    End Sub
End Class
