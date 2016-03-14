Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain

    Dim frmin As New kh
    Dim strdkloc As String
    Dim isloaded As Boolean = False
 
    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        lbluser.Text = Reg.GetValue("ID")
        list = New ClsList.List1(listid, grd, frmin, True, "1=0")

        list.AddToolStripMain(ToolStripmain)
        list.AddToolStripFind(ToolStripfind)
        list.TD1.Visible = True
        list.TD1.Text = list.oLable("017")
        PropertyOfForm.SetImage4Control("find.bmp", list.TD1)
        list.Inds.Visible = True
        AddHandler list.TD1.Click, AddressOf btnfind_Click

        list.AddContextMenu()
        list.AddMenuItem(mnfile)
        grd.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        dkloc.Icon = frmin.Icon
        loadf()
        setlookup()
        setupttgd()
        setupttlh()
        setuptthd()


        If Clsql.Others.GetArgu(2) = "" Then

            Dim dk As String = "1=1"
            Try
                dk = My.Settings.history
            Catch ex As Exception

            End Try
            If dk = "" Then
                dk = "1=1"
            End If

            list.LoadData(dk)
        Else
            list.LoadData("ma_kh='" & Clsql.Others.GetArgu(2) & "'")
        End If
        btnPrintBarCode.Enabled = True
        isloaded = True

    End Sub
    Dim col As String
    
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            list.LoadData("ma_tinh_thanh like '%" & Trim(dkloc.txtma_tinh_thanh.Text) & "%' and ma_quan_huyen like '%" & Trim(dkloc.txtma_quan_huyen.Text) & "%' and ma_qg like '%" & dkloc.txtma_qg.Text.Trim & "%'" _
                          & " and ma_loai_kh like '%" & Trim(dkloc.txtma_loai_kh.Text) & "%'" _
                          & " and dia_chi like N'%" & Trim(dkloc.txtdia_chi.Text) & "%'" _
                          & " and ma_so_thue like N'%" & Trim(dkloc.txtma_so_thue.Text) & "%'" _
                           & " and dai_dien_pl like N'%" & Trim(dkloc.txtdai_dien_pl.Text) & "%'" _
                           & " and dien_thoai like N'%" & Trim(dkloc.txtdien_thoai.Text) & "%'" _
                            & " and email like N'%" & Trim(dkloc.txtemail.Text) & "%'" _
                             & " and fax like N'%" & Trim(dkloc.txtfax.Text) & "%'" _
                              & " and htsh like N'%" & Trim(dkloc.txthtsh.Text) & "%'" _
                               & " and lhkd like N'%" & Trim(dkloc.txtlhkd.Text) & "%'" _
                                 & " and lvkd like N'%" & Trim(dkloc.txtlvkd.Text) & "%'" _
                                   & " and website like N'%" & Trim(dkloc.txtwebsite.Text) & "%'" _
                                      & " and ten_dn like N'%" & Trim(dkloc.txtten_dn.Text) & "%'" _
                                         & " and ten_kh like N'%" & Trim(dkloc.txtten_kh.Text) & "%'" _
                                            & " and ten_gd like N'%" & Trim(dkloc.ten_gd.Text) & "%'" _
                                              & " and ma_kh in (select ma_kh from nkcv where dien_giai like N'%" & Trim(dkloc.txtdien_giai.Text) & "%'" _
                                              & " and ma_lcv like N'%" & Trim(dkloc.cbbma_lcv.SelectedValue) & "%'" _
                                                 & " and ma_nv like N'%" & Trim(dkloc.Txtma_nv.Text) & "%'" _
                                                    & " and ghi_chu like N'%" & Trim(dkloc.txtghi_chu.Text) & "%'" _
                                                    & " and ma_ddlv like N'%" & Trim(dkloc.cbbma_ddlv.SelectedValue) & "%'" _
                                                    & " and (ngay between " & conn.ConvertToSQLType(dkloc.Txttu_ngay.Value) & " and " & conn.ConvertToSQLType(dkloc.Txtden_ngay.Value) _
                                                     & ") and ma_tien_do like N'%" & Trim(dkloc.cbbma_tien_do.SelectedValue) & "%')" _
                                                    & " and dai_dien_pl like N'%" & Trim(dkloc.txtdai_dien_pl.Text) & "%'")
            'grd.Columns(0).Width = SplitContainer1.Panel1.Width
        End If
    End Sub


    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter

        If TabControl1.SelectedTab.Name = thong_tin_gd.Name Then
            If list.BindingSource.Count > 0 Then
                list_gd.LoadData("ma_kh = '" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = thong_tin_lien_he.Name Then
            If list.BindingSource.Count > 0 Then
                list_lh.LoadData("ma_kh = '" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = hop_dong.Name Then
            If list.BindingSource.Count > 0 Then
                list_hd.LoadData("ma_kh = '" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
    End Sub

    Private Sub list_AfterDeleteItem(ByVal dk As DataRow)
        

    End Sub
    Private Sub BeforeAddItem()
        
    End Sub

#Region "Thong tin lien he"
    Private Sub thong_tin_lien_he_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_lien_he.Enter
        If list.BindingSource.Count > 0 Then
            list_lh.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_lh.LoadData("1=0")
        End If
    End Sub

    Private Sub beforeAddlh()
        If grd.CurrentRow Is Nothing Then
            list_lh.ContinueAdd = False
            Return
        End If

        Dim iditityMa_kh = conn.GetValue("select cast(max(ma_nguoi_lien_he) as numeric(8,0)) from dlh where ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        If IsDBNull(iditityMa_kh) Then
            iditityMa_kh = 1
        Else
            iditityMa_kh = iditityMa_kh + 1
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(Strings.Format(iditityMa_kh, "00000000"), "ma_nguoi_lien_he")
        keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        list_lh.SetKeys = keydefaul
        Dim valuedefaul As New Collection
        valuedefaul.Add(0, "gioi_tinh")
        valuedefaul.Add(list.BindingSource.Current("dien_thoai"), "dien_thoai_co_quan")
        list_lh.ValueDefaults = valuedefaul


    End Sub
    Sub setupttlh()
        Dim flh As New dlh
        list_lh = New ClsList.List1("dlh", gridlh, flh, False, "1=0")

        thong_tin_lien_he.Text = list_lh.oLable("000")

        ten_gioi_tinh.Text = list_lh.oLable("011")
        list_lh.tat.Visible = False
        list_lh.AddToolStripMain(bar_lh)
        '
        PropertyOfForm.SetLable(list_lh.oLable, panlh)
        PropertyOfForm.BindData(list_lh.BindingSource, panlh)
        PropertyOfForm.Sercurity(panlh)
        '
        AddHandler list_lh.BeforeAddItem, AddressOf beforeAddlh

        AddHandler flh.btnLuu.Click, AddressOf list_lh.Save
        AddHandler flh.btnhuy.Click, AddressOf list_lh.Cancel
    End Sub

#End Region
#Region "Thong tin hop dong"
    Private Sub hop_dong_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles hop_dong.Enter
        If list.BindingSource.Count > 0 Then
            list_hd.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_hd.LoadData("1=0")
        End If

    End Sub
    
    Private Sub beforeaddhd()
        If grd.CurrentRow Is Nothing Then
            list_hd.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        list_hd.SetKeys = keydefaul
    End Sub
   
    Sub setuptthd()
        Dim finhd As New frmhd
        list_hd = New ClsList.List1("dmhd", grdhop_dong, finhd, False, "1=0")


        Dim nv As New ClsLookup.AutoCompleteLookup(conn, "dmnv", finhd.txtma_nvbh, "ma_nv", False)
        nv.SetValue("ten_nv", finhd.ten_nv)
        nv.SetValue("ten_nv", ten_nv)
        Dim bp As New AutoCompleteLookup(conn, "dmbp", finhd.txtma_bp, "ma_bp", False)
        If Reg.GetValue("Language") = "Vi" Then
            bp.SetValue("ten_bp", finhd.ten_bp)
            bp.SetValue("ten_bp", ten_bp)
        Else
            bp.SetValue("ten_bp2", finhd.ten_bp)
            bp.SetValue("ten_bp2", ten_bp)
        End If
        Dim nt As New AutoCompleteLookup(conn, "dmnt", finhd.txtma_nt, "ma_nt")

       
        hop_dong.Text = list_hd.oLable("000")
        
        'set label
        PropertyOfForm.SetLable(list_hd.oLable, Panhd)
        PropertyOfForm.BindData(list_hd.BindingSource, Panhd)
        PropertyOfForm.Sercurity(Panhd)
        list_hd.tat.Visible = False
        list_hd.AddToolStripMain(bar_hd)

        '

        AddHandler list_hd.BeforeAddItem, AddressOf beforeaddhd
        '
        AddHandler finhd.btnLuu.Click, AddressOf list_hd.Save
        AddHandler finhd.btnhuy.Click, AddressOf list_hd.Cancel
    End Sub

#End Region

#Region "Thong tin giao dich"
    Private Sub thong_tin_giao_dich_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_gd.Enter
        If list.BindingSource.Count > 0 Then
            list_gd.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_gd.LoadData("1=0")
        End If
    End Sub
    
    Sub setupttgd()

        Dim frmgd As New frminput
        list_gd = New ClsList.List1("nkcv", gridgd, frmgd, False, "1=0")

        ClsLookup.AddItems.AddItemCbb(conn, "select ma_ddlv,ten,ten2 from dddlv where trang_thai =1", frmgd.cbbma_ddlv, "ten", "ten2", "ma_ddlv")
        ClsLookup.AddItems.AddItemCbb(conn, "select ma_lcv,ten,ten2 from dlcv where trang_thai =1", frmgd.cbbma_lcv, "ten", "ten2", "ma_lcv")
        ClsLookup.AddItems.AddItemCbb(conn, "select trang_thai_xl,ten,ten2 from dxl where trang_thai =1", frmgd.cbbma_tien_do, "ten", "ten2", "trang_thai_xl")

        Dim oKH As New AutoCompleteLookup(conn, "dmkh", frmgd.txtma_kh, "ma_kh", True)
        oKH.SetValue("ten_kh", frmgd.lblten_kh)
        Dim oNV As New ClsLookup.AutoCompleteLookup(conn, "dmnsd", frmgd.Txtma_nv, "id", True)
        oNV.SetValue("idname", frmgd.ten_nv)

        thong_tin_gd.Text = list_gd.oLable("000")

        AddHandler list_gd.BeforeAddItem, AddressOf beforeAddgd
        list_gd.tat.Visible = False
        list_gd.AddToolStripMain(bar_gd)
        '
        AddHandler frmgd.btnLuu.Click, AddressOf list_gd.Save
        AddHandler frmgd.btnhuy.Click, AddressOf list_gd.Cancel

    End Sub
    Private Sub beforeAddgd()
        If grd.CurrentRow Is Nothing Then
            list_lh.ContinueAdd = False
            Return
        End If
        Dim defaultkey As New Collection
        Dim stt_rec As String = Strings.Format(Now, "yyyyMMddhhmmss")
        defaultkey.Add(stt_rec, "stt_rec")
        list_gd.SetKeys = defaultkey
        'set value default
        Dim defaults As New Collection
        defaults.Add("00000001", "ma_ddlv")
        defaults.Add(Now, "ngay")
        defaults.Add(Reg.GetValue("ID"), "ma_nv")
        defaults.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")

        list_gd.ValueDefaults = defaults
    End Sub
#End Region

  

    Private Sub grd_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grd.RowsAdded
        
        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Khách hàng"
        Else
            lbllines.Text = grd.RowCount & " Customer(s)"
        End If

    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved
       
        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Khách hàng"
        Else
            lbllines.Text = grd.RowCount & " Customer(s)"
        End If
    End Sub


    Private Sub CloseMe(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Try
            
            If list.datatable IsNot Nothing Then
                Dim stt_recs As String = ""
                Dim key As String = list.keys.Split(",")(0)
                Dim i As Integer = 0
                For Each r As DataRow In list.datatable.Rows
                    If r.RowState <> DataRowState.Deleted Then
                        If stt_recs <> "" Then
                            stt_recs = stt_recs & "," & conn.ConvertToSQLType(r(key))
                        Else
                            stt_recs = key & " in (" & conn.ConvertToSQLType(r(key))
                        End If
                        i += 1
                        If i > 10 Then
                            Exit For
                        End If
                    End If
                Next
                If stt_recs <> "" Then
                    stt_recs = stt_recs & ")"
                End If

                My.Settings.history = stt_recs
                My.Settings.Save()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub loadf()
        'set gia tri mac dinh cho dmkh
        Dim ValueDefault As New Collection
        ValueDefault.Add(True, "kh_yn")
        ValueDefault.Add(False, "ncc_yn")
        ValueDefault.Add(list.conn.GetValue("select ma_nv from dmnsd where id ='" & Reg.GetValue("id") & "'"), "ma_nv_lh")
        list.ValueDefaults = ValueDefault
        'bind data cho view
        PropertyOfForm.BindData(list.BindingSource, thong_tin_chung)
        PropertyOfForm.BindData(list.BindingSource, thong_tin_pha_tich)

        'sercurity
        PropertyOfForm.Sercurity(thong_tin_chung)
        PropertyOfForm.Sercurity(thong_tin_pha_tich)
        'add button detail
        ' Dim dd As New clsViDe.DropDownButtonDetail(list.conn, ToolStripfind, "ldkh", Me.grd)
        'set up cmd
        frmin.btnhuy.CausesValidation = False
        

       

        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel

        AddHandler gridgd.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler gridlh.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler grd.KeyDown, AddressOf PropertyOfGrid.Filter

        AddHandler list.AfterDeleteItem, AddressOf list_AfterDeleteItem

        AddHandler list.BeforeAddItem, AddressOf BeforeAddItem
    End Sub
    Sub setlookup()
        'kh
        Dim oNCC As New ClsLookup.AutoCompleteLookup(conn, "dmnv", frmin.txtma_nv_lh, "ma_nv", False)
        oNCC.SetValue("ten_nv", frmin.lblten_nv)
        Dim otinh As New ClsLookup.AutoCompleteLookup(conn, "dmtt", frmin.txtma_tinh_thanh, "ma_tinh_thanh", False)
        otinh.SetValue("ten_tinh_thanh", frmin.lblten_tinh_thanh)
        Dim ohuyen As New ClsLookup.AutoCompleteLookup(conn, "dmqh", frmin.txtma_quan_huyen, "ma_quan_huyen", False)
        ohuyen.SetValue("ten_quan_huyen", frmin.lblten_quan_huyen)
        Dim odxl As New ClsLookup.AutoCompleteLookup(conn, "dmtd", frmin.txtma_td, "ma_td", False)
        Dim odldcncc As New ClsLookup.AutoCompleteLookup(conn, "dmldcncc", frmin.txtly_do_c_ncc, "ly_do_c_ncc", False)
        Dim oddtct As New ClsLookup.AutoCompleteLookup(conn, "dmdtct", frmin.txtma_dt_ct, "ma_dt_ct", False)
        Dim odlkh As New ClsLookup.AutoCompleteLookup(conn, "dmlkh", frmin.txtma_loai_kh, "ma_loai_kh", False)
        Dim odqg As New ClsLookup.AutoCompleteLookup(conn, "dmqg", frmin.txtma_qg, "ma_qg", False)
        Dim odmnhkh1 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomkh", frmin.txtnh_kh1, "ma_nhom", False)
        odmnhkh1.oKey = "loai_nhom =1"

        Dim odmnhkh2 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomkh", frmin.txtnh_kh2, "ma_nhom", False)
        odmnhkh2.oKey = "loai_nhom =2"

        Dim odmnhkh3 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomkh", frmin.txtnh_kh3, "ma_nhom", False)
        odmnhkh3.oKey = "loai_nhom =3"



        If Reg.GetValue("Language") = "Vi" Then
            odxl.SetValue("ten", frmin.lblten_td)
            odldcncc.SetValue("ten", frmin.lblten_ly_do_c_ncc)
            oddtct.SetValue("ten", frmin.lblten_dt_ct)
            odlkh.SetValue("ten", frmin.lblten_loai_kh)
            odqg.SetValue("ten", frmin.lblten_qg)

            odmnhkh1.SetValue("ten_nhom", frmin.ten_nh1)
            odmnhkh2.SetValue("ten_nhom", frmin.ten_nh2)
            odmnhkh3.SetValue("ten_nhom", frmin.ten_nh3)
        Else
            odxl.SetValue("ten2", frmin.lblten_td)
            odldcncc.SetValue("ten2", frmin.lblten_ly_do_c_ncc)
            oddtct.SetValue("ten2", frmin.lblten_dt_ct)
            odlkh.SetValue("ten2", frmin.lblten_loai_kh)
            odqg.SetValue("ten2", frmin.lblten_qg)

            odmnhkh1.SetValue("ten_nhom1", frmin.ten_nh1)
            odmnhkh2.SetValue("ten_nhom2", frmin.ten_nh2)
            odmnhkh3.SetValue("ten_nhom3", frmin.ten_nh3)
        End If
        
    End Sub
  
 
    
  

 


    Private Sub btnPrintBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBarCode.Click
        If grd.CurrentRow Is Nothing Then
            Return
        End If

        Dim printbarcode As New ClsRpt.PrintBarCode
        printbarcode.Filter.txtcode.Text = grd.CurrentRow.Cells("ma_kh").Value
        If conn.Lang = SQL.Language.Vietnamese Then
            printbarcode.Filter.txtname.Text = grd.CurrentRow.Cells("ten_kh").Value
        Else
            printbarcode.Filter.txtname.Text = grd.CurrentRow.Cells("ten_kh2").Value
        End If
        printbarcode.print(Me)
        printbarcode.dispose()
    End Sub
End Class
