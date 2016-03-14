Imports Clsql
Imports ClsControl2
Imports ClsLookup
Imports System.ComponentModel

Public Class Frmmain
    Dim frmgd As New frminput
    Dim frmdmgiakh As New dmgiakh
    Dim frmin As New kh
    Dim strdkloc As String
    Dim isloaded As Boolean = False
    Dim WithEvents bgwk1 As New BackgroundWorker
    Dim WithEvents bgwk2 As New BackgroundWorker
    Dim WithEvents bgwk3 As New BackgroundWorker
    Dim WithEvents bgwk0 As New BackgroundWorker
    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False

        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        lbluser.Text = Reg.GetValue("ID")
        list = New ClsList.List2(listid, frmin)

        list.AddToolStripMain(ToolStripmain)
        list.AddToolStripFind(ToolStripfind)
        list.TD1.Visible = True
        list.TD1.Text = list.oLable("017")
        PropertyOfForm.SetImage4Control("find.bmp", list.TD1)
        AddHandler list.TD1.Click, AddressOf btnfind_Click
        AddHandler grd.KeyDown, AddressOf ClsControl2.PropertyOfGrid.ExportToExcel
        list.AddContextMenu()
        list.AddMenuItem(mnfile)
        Me.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        dkloc.Icon = frmin.Icon

        bgwk3.RunWorkerAsync()
        bgwk2.RunWorkerAsync()
        bgwk1.RunWorkerAsync()
        bgwk0.RunWorkerAsync()
        If Clsql.Others.GetArgu(2) = "" Then
          
            Dim dk As String = "1=1"
            If IO.File.Exists(Application.StartupPath & "\AppData\List\" & list.dvname.Trim & ".vnt") Then
                Dim file As New IO.StreamReader(Application.StartupPath & "\AppData\List\" & list.dvname.Trim & ".vnt")
                dk = file.ReadToEnd
                file.Close()
                If dk.Trim = "" Then dk = "1=1"
            End If
            loadData(dk)
        Else
            'loadf()
            'setupttgd()
            'setupttlh()
            'setlookup()

            loadData("ma_kh='" & Clsql.Others.GetArgu(2) & "'")
        End If
        isloaded = True

    End Sub
    Dim col As String
    Sub loadData(ByVal dk As String)
        Dim xnk As Boolean = list.rights.Right("XemNK")

        If Reg.GetValue("Language") = "Vi" Then
            col = conn.GetValue("select columnsV from gridinfo where gridid='" & list.gridid & "'")
        Else
            col = conn.GetValue("select columnsE from gridinfo where gridid='" & list.gridid & "'")
        End If
        If xnk = False Then
            dv = conn.GetDataView("select " & col & " from " & list.dvname & "  where " & list.nguoi_taoYN & " and " & dk)
        Else
            dv = conn.GetDataView("select " & col & "  from " & list.dvname & "  where " & dk)
        End If
        PropertyOfGrid.FillGrid(conn, list.gridid, grd, dv)

        ' grd.Columns(0).Width = SplitContainer1.Panel1.Width
        If grd.RowCount = 0 Then
            list.LoadData("1=0")
        End If
    End Sub
    Sub AfterLoadDataDetail(ByVal table As DataTable)
        ' thong_tin_pha_tich.BindingContext(list.BindingSource).Position = list.BindingSource.Count - 1
        ' thong_tin_chung.BindingContext(list.BindingSource).Position = list.BindingSource.Count - 1

        If TabControl1.SelectedTab.Name = thong_tin_lien_he.Name Then
            If list.BindingSource.Count > 0 Then
                list_lh.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If

        If TabControl1.SelectedTab.Name = thong_tin_gd.Name Then
            If list.BindingSource.Count > 0 Then
                list_gd.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If

        If TabControl1.SelectedTab.Name = hop_dong.Name Then
            If list.BindingSource.Count > 0 Then
                list_hd.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = dmgiakh.Name Then
            If list.BindingSource.Count > 0 Then
                list_dmgiakh.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
    End Sub
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            loadData("ma_tinh_thanh like '%" & Trim(dkloc.txtma_tinh_thanh.Text) & "%' and ma_quan_huyen like '%" & Trim(dkloc.txtma_quan_huyen.Text) & "%' and ma_qg like '%" & dkloc.txtma_qg.Text.Trim & "%'" _
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

    Private Sub grd_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellDoubleClick
        If grd.RowCount > 0 Then
            list.sua.PerformClick()
        End If
    End Sub

    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        list.LoadData("ma_kh='" & grd.Item("ma_kh", e.RowIndex).Value & "'")
    End Sub

    Private Sub list_AfterAddItem(ByVal e As System.Data.DataRow)
        Dim r As DataRow
        r = dv.Table.NewRow
        For Each c As String In col.Split(",")
            r(c) = e(c)
        Next
       
        dv.Table.Rows.Add(r)
        grd.CurrentCell = grd.Item(grd.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index, grd.Rows.GetLastRow(DataGridViewElementStates.Visible))
    End Sub

    Private Sub list_AfterDeleteItem(ByVal dk As DataRow)
        list_lh.Delete("ma_kh='" & dk("ma_kh") & "'") 'xoa cac lien he 
        list_gd.Delete("ma_kh='" & dk("ma_kh") & "'") 'xoa cac gd
        list_dmgiakh.Delete("ma_kh='" & dk("ma_kh") & "'") 'xoa cac dmgiakh


        If list_lh.datatable IsNot Nothing Then
            list_lh.datatable.Clear()
        End If
        If list_gd.datatable IsNot Nothing Then
            list_gd.datatable.Clear()
        End If
        If list_dmgiakh.datatable IsNot Nothing Then
            list_dmgiakh.datatable.Clear()
        End If


        Try
            grd.Rows.RemoveAt(grd.CurrentRow.Index)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BeforeAddItem()
        'Dim iditityMa_kh = conn.GetValue("select cast(max(ma_kh) as numeric(16,0)) from dkh")
        'If IsDBNull(iditityMa_kh) Then
        '    iditityMa_kh = 1
        'Else
        '    iditityMa_kh = iditityMa_kh + 1
        'End If
        'Dim keydefaul As New Collection
        'keydefaul.Add(Strings.Format(iditityMa_kh, "0000000000000000"), "ma_kh")
        'list.SetKeys = keydefaul
    End Sub
    Private Sub list_AfterEditItem(ByVal e As Object)
        For Each c As String In col.Split(",")
            grd.Item(c, grd.CurrentRow.Index).Value = list.BindingSource.Current(c)
        Next
    End Sub
    Private Sub list_AfterFind(ByVal e As String)
        loadData(e)
    End Sub

#Region "Thong tin lien he"
    Private Sub thong_tin_lien_he_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_lien_he.Enter
        If list.BindingSource.Count > 0 Then
            list_lh.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_lh.LoadData("1=0")
        End If

    End Sub
    Private Sub btnmoi_lh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi_lh.Click
        If list.BindingSource.Count = 0 Then
            Exit Sub
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
        list_lh.ADD(sender, e)
    End Sub

    Private Sub btnsua_lh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua_lh.Click
        list_lh.Edit(sender, e)
    End Sub

    Private Sub btnxoa_lh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa_lh.Click
        list_lh.Delete(sender, e)
    End Sub
    Private Sub gridlh_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridlh.MouseDoubleClick
        list_lh.Edit(sender, e)
    End Sub
    Sub setupttlh()
        list_lh = New ClsList.CompactList(conn, "dlh", dlh, gridlh, True, "1=0")
        btnmoi_lh.Image = list.moi.Image
        btnmoi_lh.Text = list.moi.Text
        btnsua_lh.Image = list.sua.Image
        btnsua_lh.Text = list.sua.Text
        btnxoa_lh.Image = list.xoa.Image
        btnxoa_lh.Text = list.xoa.Text
        thong_tin_lien_he.Text = list_lh.oLable("000")
        Dim contextmenu As New ContextMenuStrip
        Dim mnmoi As New ToolStripMenuItem(btnmoi_lh.Text, btnmoi_lh.Image)
        AddHandler mnmoi.Click, AddressOf btnmoi_lh_Click
        contextmenu.Items.Add(mnmoi)
        Dim mnsua As New ToolStripMenuItem(btnsua_lh.Text, btnsua_lh.Image)
        AddHandler mnsua.Click, AddressOf btnsua_lh_Click
        contextmenu.Items.Add(mnsua)
        Dim mnxoa As New ToolStripMenuItem(btnxoa_lh.Text, btnxoa_lh.Image)
        AddHandler mnxoa.Click, AddressOf btnxoa_lh_Click
        contextmenu.Items.Add(mnxoa)
        gridlh.ContextMenuStrip = contextmenu
        'phan quyen
        btnmoi_lh.Enabled = list_lh.rights.NewRight
        mnmoi.Enabled = btnmoi_lh.Enabled

        btnsua_lh.Enabled = list_lh.rights.EditRight
        mnsua.Enabled = btnsua_lh.Enabled

        btnxoa_lh.Enabled = list_lh.rights.DeleteRight
        mnxoa.Enabled = btnxoa_lh.Enabled
        ten_gioi_tinh.Text = list_lh.oLable("011")

        '
        PropertyOfForm.SetLable(list_lh.oLable, panlh)
        PropertyOfForm.BindData(list_lh.BindingSource, panlh)
        PropertyOfForm.Sercurity(panlh)
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
    Private Sub btnmoi_hd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi_hd.Click
        If list.BindingSource.Count = 0 Then
            Exit Sub
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        list_hd.SetKeys = keydefaul
        list_hd.ADD(sender, e)
    End Sub

    Private Sub btnsua_hd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua_hd.Click
        list_hd.Edit(sender, e)
    End Sub

    Private Sub btnxoa_hd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa_hd.Click

        list_hd.Delete(sender, e)
    End Sub
    Private Sub gridhd_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdhop_dong.MouseDoubleClick
        list_hd.Edit(sender, e)
    End Sub
    Sub setuptthd()
        Dim finhd As New frmhd
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

        list_hd = New ClsList.CompactList(conn, "dmhd", finhd, grdhop_dong, True, "1=0")

        btnmoi_hd.Image = list.moi.Image
        btnmoi_hd.Text = list.moi.Text
        btnsua_hd.Image = list.sua.Image
        btnsua_hd.Text = list.sua.Text
        btnxoa_hd.Image = list.xoa.Image
        btnxoa_hd.Text = list.xoa.Text
        hop_dong.Text = list_hd.oLable("000")
        'tao menu
        Dim contextmenu As New ContextMenuStrip
        Dim mnmoi As New ToolStripMenuItem(btnmoi_hd.Text, btnmoi_hd.Image)
        AddHandler mnmoi.Click, AddressOf btnmoi_hd_Click
        contextmenu.Items.Add(mnmoi)
        Dim mnsua As New ToolStripMenuItem(btnsua_hd.Text, btnsua_hd.Image)
        AddHandler mnsua.Click, AddressOf btnsua_hd_Click
        contextmenu.Items.Add(mnsua)
        Dim mnxoa As New ToolStripMenuItem(btnxoa_hd.Text, btnxoa_hd.Image)
        AddHandler mnxoa.Click, AddressOf btnxoa_hd_Click
        contextmenu.Items.Add(mnxoa)
        grdhop_dong.ContextMenuStrip = contextmenu
        'phan quyen
        btnmoi_hd.Enabled = list_hd.rights.NewRight
        mnmoi.Enabled = btnmoi_hd.Enabled

        btnsua_hd.Enabled = list_hd.rights.EditRight
        mnsua.Enabled = btnsua_hd.Enabled

        btnxoa_hd.Enabled = list_hd.rights.DeleteRight
        mnxoa.Enabled = btnxoa_hd.Enabled
        'set label
        PropertyOfForm.SetLable(list_hd.oLable, Panhd)
        PropertyOfForm.BindData(list_hd.BindingSource, Panhd)
        PropertyOfForm.Sercurity(Panhd)
    End Sub

#End Region

#Region "Thong tin dmgiakh"
    Private Sub dmgiakh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dmgiakh.Enter
        Try
            
            If list.BindingSource.Count > 0 Then

                list_dmgiakh.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
            Else
                list_dmgiakh.LoadData("1=0")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub
    Private Sub btnmoi_dmgiakh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi_dmgiakh.Click
        If list.BindingSource.Count = 0 Then
            Exit Sub
        End If


        'Dim iditityMa_kh = conn.GetValue("select cast(max(ma_cv) as numeric(2,0)) from dgd where ma_kh='" & grd.Item("ma_kh", grd.CurrentRow.Index).Value & "'")
        'If IsDBNull(iditityMa_kh) Then
        '    iditityMa_kh = 1
        'Else
        '    iditityMa_kh = iditityMa_kh + 1
        'End If
        'beforeAddgd()
        Dim keydefaul As New Collection
        ''keydefaul.Add(Strings.Format(iditityMa_kh, "00"), "ma_cv")
        keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        list_dmgiakh.SetKeys = keydefaul
        list_dmgiakh.ADD(sender, e)
    End Sub

    Private Sub btnsua_dmgiakh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua_dmgiakh.Click
        list_dmgiakh.Edit(sender, e)
    End Sub

    Private Sub btnxoa_dmgiakh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa_dmgiakh.Click
        list_dmgiakh.Delete(sender, e)
    End Sub
    Private Sub griddmgiakh_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grddmgiakh.MouseDoubleClick
        list_dmgiakh.Edit(sender, e)
    End Sub
    Sub setupttdmgiakh()

        Dim vt As New ClsLookup.AutoCompleteLookup(conn, "dmkem", frmdmgiakh.txtma_vt, "ma_kem", False)
        vt.SetValue("ten_kem", frmdmgiakh.ten_vt)
        'list_gd = New ClsList.CompactList(conn, "dgd", dgd, gridgd, True, "1=0")

        list_dmgiakh = New ClsList.CompactList(conn, "dmgiakh", frmdmgiakh, grddmgiakh, True, "1=0")
        btnmoi_dmgiakh.Image = list.moi.Image
        btnmoi_dmgiakh.Text = list.moi.Text
        btnsua_dmgiakh.Image = list.sua.Image
        btnsua_dmgiakh.Text = list.sua.Text
        btnxoa_dmgiakh.Image = list.xoa.Image
        btnxoa_dmgiakh.Text = list.xoa.Text
        dmgiakh.Text = list_dmgiakh.oLable("000")

        Dim contextmenu As New ContextMenuStrip
        Dim mnmoi As New ToolStripMenuItem(btnmoi_dmgiakh.Text, btnmoi_dmgiakh.Image)
        AddHandler mnmoi.Click, AddressOf btnmoi_dmgiakh_Click
        contextmenu.Items.Add(mnmoi)
        Dim mnsua As New ToolStripMenuItem(btnsua_dmgiakh.Text, btnsua_dmgiakh.Image)
        AddHandler mnsua.Click, AddressOf btnsua_dmgiakh_Click
        contextmenu.Items.Add(mnsua)
        Dim mnxoa As New ToolStripMenuItem(btnxoa_dmgiakh.Text, btnxoa_dmgiakh.Image)
        AddHandler mnxoa.Click, AddressOf btnxoa_dmgiakh_Click
        contextmenu.Items.Add(mnxoa)
        gridgd.ContextMenuStrip = contextmenu
        'phan quyen
        btnmoi_dmgiakh.Enabled = list_dmgiakh.rights.NewRight
        mnmoi.Enabled = btnsua_dmgiakh.Enabled

        btnsua_dmgiakh.Enabled = list_dmgiakh.rights.EditRight
        mnsua.Enabled = btnsua_dmgiakh.Enabled

        btnxoa_dmgiakh.Enabled = list_dmgiakh.rights.DeleteRight
        mnxoa.Enabled = btnxoa_dmgiakh.Enabled

        'Dim defaul As New Collection
        'defaul.Add(conn.GetValue("select ma_nv from dmnsd where id ='" & Reg.GetValue("ID") & "'"), "ma_nv")
        'list_gd.ValueDefaults = defaul
    End Sub
    'Private Sub beforeAdddmgiakh()
    '    Dim defaultkey As New Collection
    '    Dim stt_rec As String = Strings.Format(Now, "yyyyMMddhhmmss")
    '    defaultkey.Add(stt_rec, "stt_rec")
    '    list_gd.SetKeys = defaultkey
    '    'set value default
    '    Dim defaults As New Collection
    '    defaults.Add("00000001", "ma_ddlv")
    '    defaults.Add(Now, "ngay")
    '    defaults.Add(Reg.GetValue("ID"), "ma_nv")
    '    defaults.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")

    '    list_gd.ValueDefaults = defaults
    'End Sub
#End Region

#Region "Thong tin giao dich"
    Private Sub thong_tin_giao_dich_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_gd.Enter
        If list.BindingSource.Count > 0 Then
            list_gd.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_gd.LoadData("1=0")
        End If
    End Sub
    Private Sub btnmoi_gd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi_gd.Click
        If list.BindingSource.Count = 0 Then
            Exit Sub
        End If
        Dim iditityMa_kh = conn.GetValue("select cast(max(ma_cv) as numeric(2,0)) from dgd where ma_kh='" & grd.Item("ma_kh", grd.CurrentRow.Index).Value & "'")
        If IsDBNull(iditityMa_kh) Then
            iditityMa_kh = 1
        Else
            iditityMa_kh = iditityMa_kh + 1
        End If
        beforeAddgd()
        'Dim keydefaul As New Collection
        'keydefaul.Add(Strings.Format(iditityMa_kh, "00"), "ma_cv")
        'keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        'list_gd.SetKeys = keydefaul
        list_gd.ADD(sender, e)
    End Sub

    Private Sub btnsua_gd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua_gd.Click
        list_gd.Edit(sender, e)
    End Sub

    Private Sub btnxoa_gd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa_gd.Click
        list_gd.Delete(sender, e)
    End Sub
    Private Sub gridgd_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridgd.MouseDoubleClick
        list_gd.Edit(sender, e)
    End Sub
    Sub setupttgd()
        'list_gd = New ClsList.CompactList(conn, "dgd", dgd, gridgd, True, "1=0")

        list_gd = New ClsList.CompactList(conn, "nkcv", frmgd, gridgd, True, "1=0")
        btnmoi_gd.Image = list.moi.Image
        btnmoi_gd.Text = list.moi.Text
        btnsua_gd.Image = list.sua.Image
        btnsua_gd.Text = list.sua.Text
        btnxoa_gd.Image = list.xoa.Image
        btnxoa_gd.Text = list.xoa.Text
        thong_tin_gd.Text = list_gd.oLable("000")
        Dim contextmenu As New ContextMenuStrip
        Dim mnmoi As New ToolStripMenuItem(btnmoi_gd.Text, btnmoi_gd.Image)
        AddHandler mnmoi.Click, AddressOf btnmoi_gd_Click
        contextmenu.Items.Add(mnmoi)
        Dim mnsua As New ToolStripMenuItem(btnsua_gd.Text, btnsua_gd.Image)
        AddHandler mnsua.Click, AddressOf btnsua_gd_Click
        contextmenu.Items.Add(mnsua)
        Dim mnxoa As New ToolStripMenuItem(btnxoa_gd.Text, btnxoa_gd.Image)
        AddHandler mnxoa.Click, AddressOf btnxoa_gd_Click
        contextmenu.Items.Add(mnxoa)
        gridgd.ContextMenuStrip = contextmenu
        'phan quyen
        btnmoi_gd.Enabled = list_gd.rights.NewRight
        mnmoi.Enabled = btnmoi_gd.Enabled

        btnsua_gd.Enabled = list_gd.rights.EditRight
        mnsua.Enabled = btnsua_gd.Enabled

        btnxoa_gd.Enabled = list_gd.rights.DeleteRight
        mnxoa.Enabled = btnxoa_gd.Enabled

        'Dim defaul As New Collection
        'defaul.Add(conn.GetValue("select ma_nv from dmnsd where id ='" & Reg.GetValue("ID") & "'"), "ma_nv")
        'list_gd.ValueDefaults = defaul
    End Sub
    Private Sub beforeAddgd()
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
        'For Each r As DataGridViewRow In grd.Rows
        '    If r.Index Mod 2 = 0 Then
        '        ClsControl2.PropertyOfGrid.FormatRow(grd, r, grd.Font.Size, FontStyle.Bold, Color.Blue, Color.Cornsilk)
        '    Else
        '        ClsControl2.PropertyOfGrid.FormatRow(grd, r, grd.Font.Size, FontStyle.Bold, Color.Blue, grd.BackgroundColor)
        '    End If
        'Next
        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Khách hàng"
        Else
            lbllines.Text = grd.RowCount & " Customer(s)"
        End If

    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved
        'For Each r As DataGridViewRow In grd.Rows
        '    If r.Index Mod 2 = 0 Then
        '        ClsControl2.PropertyOfGrid.FormatRow(grd, r, grd.Font.Size, FontStyle.Bold, Color.Blue, Color.Cornsilk)
        '    Else
        '        ClsControl2.PropertyOfGrid.FormatRow(grd, r, grd.Font.Size, FontStyle.Bold, Color.Blue, grd.BackgroundColor)
        '    End If
        'Next
        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Khách hàng"
        Else
            lbllines.Text = grd.RowCount & " Customer(s)"
        End If
    End Sub


    Private Sub CloseMe(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        If Not IO.Directory.Exists(Application.StartupPath & "\AppData\List\") Then
            IO.Directory.CreateDirectory(Application.StartupPath & "\AppData\List\")
        End If
        If list.datatable IsNot Nothing Then
            Dim stt_recs As String = ""
            Dim key As String = list.keys.Split(",")(0)
            For Each r As DataRow In list.datatable.Rows
                If r.RowState <> DataRowState.Deleted Then
                    If stt_recs <> "" Then
                        stt_recs = stt_recs & "," & conn.ConvertToSQLType(r(key))
                    Else
                        stt_recs = key & " in (" & conn.ConvertToSQLType(r(key))
                    End If
                End If
            Next
            If stt_recs <> "" Then
                stt_recs = stt_recs & ")"
            End If
            Dim file As New IO.StreamWriter(Application.StartupPath & "\AppData\List\" & list.dvname.Trim & ".vnt")
            file.Write(stt_recs)
            file.Close()
        End If
    End Sub
    Sub loadf()
        'set gia tri mac dinh cho dmkh
        Dim ValueDefault As New Collection
        ValueDefault.Add(True, "kh_yn")
        ValueDefault.Add(False, "ncc_yn")
        ValueDefault.Add(list.conn.GetValue("select ma_nv from dmnsd where id ='" & Reg.GetValue("id") & "'"), "ma_nv_lh")
        list.ValueDefaults = ValueDefault
        ''load du lieu
        'Select Case Clsql.Others.GetArgu(1)
        '    Case "L"
        '        strdkloc = Clsql.Others.GetArgu(2)
        '        If strdkloc = "" Then
        '            strdkloc = "1=1"
        '        End If
        '        list.SetData(strdkloc)
        '    Case Else
        '        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '            list.SetData("ma_tinh_thanh like '%" & Trim(dkloc.txttinh.Text) & "%' and ma_quan_huyen like '%" & Trim(dkloc.txthuyen.Text) & "%' and ma_nv_lh like '%" & dkloc.txtma_nv_lh.Text.Trim & "%'")
        '        Else
        '            Me.Close()
        '        End If
        'End Select
        'bind data cho view
        PropertyOfForm.BindData(list.BindingSource, thong_tin_chung)
        PropertyOfForm.BindData(list.BindingSource, thong_tin_pha_tich)
        thong_tin_chung.ContextMenuStrip = list.Contextmenu
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
        AddHandler grddmgiakh.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler grd.KeyDown, AddressOf PropertyOfGrid.Filter

        AddHandler list.AfterAddItem, AddressOf list_AfterAddItem
        AddHandler list.AfterDeleteItem, AddressOf list_AfterDeleteItem
        AddHandler list.AfterEditItem, AddressOf list_AfterEditItem
        AddHandler list.AfterFind, AddressOf list_AfterFind
        AddHandler list.BeforeAddItem, AddressOf BeforeAddItem
        AddHandler list.AfterLoadData, AddressOf AfterLoadDataDetail
    End Sub
    Sub setlookup()
        'kh
        Dim oNCC As New ClsLookup.AutoCompleteLookup(conn, "dmnv", frmin.txtma_nv_lh, "ma_nv", False)
        oNCC.SetValue("ten_nv", frmin.lblten_nv)
        Dim otinh As New ClsLookup.AutoCompleteLookup(conn, "dmtt", frmin.txtma_tinh_thanh, "ma_tinh_thanh", False)
        otinh.SetValue("ten_tinh_thanh", frmin.lblten_tinh_thanh)
        Dim ohuyen As New ClsLookup.AutoCompleteLookup(conn, "dmqh", frmin.txtma_quan_huyen, "ma_quan_huyen", False)
        ohuyen.SetValue("ten_quan_huyen", frmin.lblten_quan_huyen)
        Dim odxl As New ClsLookup.AutoCompleteLookup(conn, "dmtd", frmin.txtma_td, "ma_td", True)
        Dim odldcncc As New ClsLookup.AutoCompleteLookup(conn, "dmldcncc", frmin.txtly_do_c_ncc, "ly_do_c_ncc", False)
        Dim oddtct As New ClsLookup.AutoCompleteLookup(conn, "dmdtct", frmin.txtma_dt_ct, "ma_dt_ct", False)
        Dim odlkh As New ClsLookup.AutoCompleteLookup(conn, "dmlkh", frmin.txtma_loai_kh, "ma_loai_kh", True)
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
        'gd
        'set combobox
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            ClsLookup.AddItems.AddItemCbb(conn, "select ma_ddlv,ten from dddlv where trang_thai =1", frmgd.cbbma_ddlv, "ten", "ma_ddlv")
            ClsLookup.AddItems.AddItemCbb(conn, "select ma_lcv,ten from dlcv where trang_thai =1", frmgd.cbbma_lcv, "ten", "ma_lcv")
            ClsLookup.AddItems.AddItemCbb(conn, "select trang_thai_xl,ten from dxl where trang_thai =1", frmgd.cbbma_tien_do, "ten", "trang_thai_xl")
        Else
            ClsLookup.AddItems.AddItemCbb(conn, "select ma_ddlv,ten2 from dddlv where trang_thai =1", frmgd.cbbma_ddlv, "ten2", "ma_ddlv")
            ClsLookup.AddItems.AddItemCbb(conn, "select ma_lcv,ten2 from dlcv where trang_thai =1", frmgd.cbbma_lcv, "ten2", "ma_lcv")
            ClsLookup.AddItems.AddItemCbb(conn, "select trang_thai_xl,ten2 from dxl where trang_thai =1", frmgd.cbbma_tien_do, "ten2", "trang_thai_xl")
        End If
        Dim oKH As New AutoCompleteLookup(conn, "dmkh", frmgd.txtma_kh, "ma_kh", True)
        oKH.SetValue("ten_kh", frmgd.lblten_kh)
        Dim oNV As New ClsLookup.AutoCompleteLookup(conn, "dmnsd", frmgd.Txtma_nv, "id", True)
        oNV.SetValue("idname", frmgd.ten_nv)
    End Sub
    Delegate Sub delegatelh()
    Delegate Sub delegategd()
    Delegate Sub delegatehd()
    Delegate Sub delegateloadf()
    Delegate Sub delegatedmgiakh()
    Private Sub bgwk1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwk1.DoWork
        gridlh.BeginInvoke(New delegatelh(AddressOf setupttlh))
        gridlh.BeginInvoke(New delegatehd(AddressOf setuptthd))
        gridlh.BeginInvoke(New delegatedmgiakh(AddressOf setupttdmgiakh))
        'setupttlh()
    End Sub
    Private Sub bgwk2_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwk2.DoWork
        'setupttgd()
        gridgd.BeginInvoke(New delegategd(AddressOf setupttgd))
    End Sub
    Private Sub bgwk3_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwk3.DoWork
        setlookup()
    End Sub

    Private Sub bgwk0_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwk0.DoWork
        grd.BeginInvoke(New delegateloadf(AddressOf loadf))
    End Sub
End Class
