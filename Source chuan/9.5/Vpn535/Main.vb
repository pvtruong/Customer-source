﻿Imports Clsql
Imports ClsControl2
Imports ClsControl2.PropertyOfForm
Imports ClsLookup
Imports ClsSV31
Imports System.ComponentModel

Public Class Frmmain
    Implements ExecImp
    Dim frmin As New frminput
    Private _def_condition As String = Nothing
    Public Property def_condition As String Implements ExecImp.def_condition
        Get
            Return _def_condition
        End Get
        Set(value As String)
            _def_condition = value
        End Set
    End Property
    Private _defaultFields As Dictionary(Of String, Object) = Nothing
    Public Property defaultFields As Dictionary(Of String, Object) Implements ExecImp.defaultFields
        Get
            Return _defaultFields
        End Get
        Set(value As Dictionary(Of String, Object))
            _defaultFields = value
        End Set
    End Property
    Private _addNewWhenLoadFirst As Boolean = False
    Public Property addNewWhenLoadFirst As Boolean Implements ExecImp.addNewWhenLoadFirst
        Get
            Return _addNewWhenLoadFirst
        End Get
        Set(value As Boolean)
            _addNewWhenLoadFirst = value
        End Set
    End Property
    Public Sub setId(_voucherid As String) Implements ExecImp.SetId
    End Sub
    Public Sub Add(defaultFields As Dictionary(Of String, Object)) Implements ExecImp.Add
        Voucher.add_first_argument = defaultFields
        If Voucher.add_first_argument Is Nothing Then
            Voucher.add_first_argument = New Dictionary(Of String, Object)
        End If
        Voucher.News()
    End Sub

    Public Sub Search(condition As String) Implements ExecImp.Search
        If condition <> Me.def_condition Then
            Voucher.Search(condition)
        End If
    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtuser.Text = Clsql.Reg.GetValue("ID")
        '
        Voucher = New Voucher20(Voucherid, grd, frmin.TabControl1, frmin)
        conn = Voucher.conn
        Voucher.AddToolStrip(ToolStrip1)
        Voucher.btnpostGL.Visible = False
        Voucher.btnPostStock.Visible = False
        SetLable(Voucher.oLan, Me)
        Me.Icon = frmin.Icon
        'tao menu
        Dim ctm As New ContextMenuStrip
        Voucher.AddContextMenuStrip(ctm)
        Me.ContextMenuStrip = ctm
        'load
        SetUpLookup()
        loadf()

    End Sub
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
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
            Clsql.Reg.SetValue("tk_no", search.txttk_no.Text)
            Clsql.Reg.SetValue("tk_vt", search.txttk_vt.Text)
            Dim query As String
            Dim strdk As String = " ngay_ct between " & Voucher.conn.ConvertToSQLType(search.Txttu_ngay.Value) & " and " & Voucher.conn.ConvertToSQLType(search.TxtDen_ngay.Value)
            strdk = strdk & " and  ma_kh like '" & search.txtma_kh.Text & "%'"
            strdk = strdk & " and ma_nv like '" & search.txtma_nv.Text & "%'"
            strdk = strdk & " and so_ct like '" & search.txtso_ct.Text & "%'"

            query = Voucher.QueryLoad & " and " & strdk & " and stt_rec in " & "(select stt_rec from " & Voucher.Tabdetails(Voucher.TabFirst).TableName & " where ma_vt like '" & search.txtma_vt.Text
            query = query & "%' and tk_du like '" & search.txttk_no.Text

            query = query & "%' and ma_bp like '" & search.txtma_bp.Text
            query = query & "%' and ma_phi like '" & search.txtma_phi.Text
            query = query & "%' and ma_dt like '" & search.txtma_dt.Text

            query = query & "%' and tk_vt like '" & search.txttk_vt.Text & "%')"
            Voucher.LoadData(query.Replace("#*#", "cast(0 as bit) as sel,*"))
        End If

    End Sub
    Sub beforeadd(ByVal e As String)
        Dim defaultvalue As New Collection

        defaultvalue.Add(Now, "ngay_ct")
        Voucher.ValueDefaults = defaultvalue
        Voucher.Tabdetails(Voucher.TabFirst).lookups("ma_kho").oKey = "ma_dvcs='" & Reg.GetValue("unit") & "'"
    End Sub
    Sub BeforeEdit()
        Voucher.Tabdetails(Voucher.TabFirst).lookups("ma_kho").oKey = "ma_dvcs='" & grd.CurrentRow.Cells("ma_dvcs").Value & "'"
    End Sub
    Sub beforedelete(ByVal e As String)
        Voucher.delete_yn = conn.GetValue("if  exists(select stt_rec from tdttno where status = 5 and stt_rec_tt='" & e & "') select 0 else select 1 ")
        If Voucher.delete_yn = False Then
            MsgBox(Voucher.oLan("416"), MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

    Sub SetUpLookup()
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'status' order by inds", frmin.cbbstatus, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "exec s_dmnt", frmin.cbbma_nt, "ten_nt", "ma_nt")

        layhd = New GetDataByStoreMD(Voucher.conn, "mpn1", "dpn1_return", , "CTHD")
    End Sub
    Sub loadf()
        '
        f_tien = Clsql.Format.GetFormatNumeric(conn)
        f_tien_nt = Clsql.Format.GetFormatNumeric(conn, "f_tien_nt")
        f_so_luong = Clsql.Format.GetFormatNumeric(conn, "f_sl")
        ma_nt_ht = Clsql.Others.Options("a_dtht", conn)
        '
        grd.ReadOnly = False
        Voucher.btnCancel = frmin.btnhuy
        'Dim oLable As Collection = SetLable(Voucher.conn, frmin, Voucherid)

        SetLable(Voucher.oLan, fPrintDialog)
        fPrintDialog.Icon = frmin.Icon
        AddHandler Voucher.btnFind.Click, AddressOf tim
        AddHandler Voucher.BeforeAdd, AddressOf beforeadd
        AddHandler Voucher.BeforeDelete, AddressOf beforedelete
        AddHandler Voucher.BeforeEdit, AddressOf BeforeEdit

        AddHandler ClsSV31.Functions.BeforePost, AddressOf BeforePost
        AddHandler ClsSV31.Functions.AfterPost, AddressOf AfterPost
        AddHandler Voucher.AfterImportFromExcel, AddressOf postimportfromexcel
        'print
        oPrint = New ClsSV31.Print20(Voucher, fPrintDialog.cbbmau, fPrintDialog.txttieu_de, fPrintDialog.Txtso_lien)
        AddHandler Voucher.btnPrint.Click, AddressOf oPrint.Print
        fPrintDialog.StartPosition = FormStartPosition.CenterParent
        fPrintDialog.Txtso_lien.Value = Voucher.Voucherinfo("d_so_lien")
        'set up formtask
        SetLable(Voucher.oLan, formtask)
        formtask.Icon = Me.Icon
        'load data
        'Voucher.LoadFirst()

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

    Sub postimportfromexcel(ByVal dicstt_rec As Dictionary(Of String, String), ByVal status As Integer)
        For Each stt_rec As String In dicstt_rec.Keys
            ClsSV31.Functions.Post(conn, Voucherid, Voucher.tenbangchung, Voucher.Stt_rec, status)
        Next
    End Sub
End Class
