Imports Clsql
Imports ClsControl2
Imports ClsLookup
Imports System.ComponentModel

Public Class Frmmain
    Dim frmin As New vt
    Dim strdkloc As String
    Dim isloaded As Boolean = False

 


    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbluser.Text = Reg.GetValue("ID")
        list = New ClsList.List1(listid, grd, frmin, True, "1=0")
        conn = list.conn
        list.AddToolStripMain(ToolStripmain)
        list.AddToolStripFind(ToolStripfind)

        list.TD1.Visible = True
        list.TD1.Text = list.oLable("017")
        PropertyOfForm.SetImage4Control("find.bmp", list.TD1)
        AddHandler list.TD1.Click, AddressOf btnfind_Click

        list.AddContextMenu()
        list.AddMenuItem(mnfile)
        grd.ContextMenuStrip = list.Contextmenu
        'list.Inds.Visible = True
        PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        dkloc.Icon = frmin.Icon
        ' setup()
        loadf()
        setupttgd()
        setlookup()
        If Clsql.Others.GetArgu(2) = "" Then
            list.LoadData("1=1")
        Else
            list.LoadData("ma_vt='" & Clsql.Others.GetArgu(2) & "'")
        End If

        isloaded = True
    End Sub
    
    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            list.LoadData("ma_vt like '%" & Trim(dkloc.txtma_vt.Text) & "%' and ten_vt like N'%" & Trim(dkloc.txtten_vt.Text) & "%' and ten_vt2 like N'%" & dkloc.txtten_vt2.Text.Trim & "%'" _
                          & " and loai_vt like '%" & Trim(dkloc.txtloai_vt.Text) & "%'" _
                          & " and ma_dvt like N'%" & Trim(dkloc.txtma_dvt.Text) & "%'" _
                          & " and nh_vt1 like N'%" & Trim(dkloc.txtnh_vt1.Text) & "%'" _
                           & " and nh_vt2 like N'%" & Trim(dkloc.txtnh_vt2.Text) & "%'" _
                           & " and nh_vt3 like N'%" & Trim(dkloc.txtnh_vt3.Text) & "%'" _
                            & " and tk_vt like N'%" & Trim(dkloc.txttk_vt.Text) & "%'" _
                             & " and tk_gv like N'%" & Trim(dkloc.txttk_gv.Text) & "%'" _
                              & " and tk_dt like N'%" & Trim(dkloc.txttk_dt.Text) & "%'" _
                               & " and tk_ck like N'%" & Trim(dkloc.txttk_ck.Text) & "%'" _
                                 & " and tk_spdd like N'%" & Trim(dkloc.txttk_spdd.Text) & "%'")

        End If
    End Sub


    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter

        If TabControl1.SelectedTab.Name = thong_tin_gd.Name Then
            If list.BindingSource.Count > 0 Then
                list_dvt.LoadData("ma_vt = '" & list.BindingSource.Current("ma_vt") & "'")
            End If
        End If
    End Sub

    Private Sub list_AfterAddItem(ByVal e As System.Data.DataRow)
       
    End Sub

    Private Sub list_AfterDeleteItem(ByVal dk As DataRow)
        conn.Execute("delete " & list_dvt.tablename & " where ma_vt ='" & dk("ma_vt") & "'")

        If list_dvt.datatable IsNot Nothing Then
            list_dvt.datatable.Clear()
        End If

    End Sub
    Private Sub BeforeAddItem()

    End Sub
    
   
#Region "DVT qd"
    Private Sub thong_tin_giao_dich_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_gd.Enter
        If list.BindingSource.Count > 0 Then
            list_dvt.LoadData("ma_vt ='" & list.BindingSource.Current("ma_vt") & "'")
        Else
            list_dvt.LoadData("1=0")
        End If
    End Sub

    Sub setupttgd()
        list_dvt = New ClsList.List1("dqddvt", gridgd, dqddvt, False, "1=0")

        AddHandler list_dvt.BeforeAddItem, AddressOf beforeAddgd

        thong_tin_gd.Text = list_dvt.oLable("000")

        dqddvt.btnhuy.CausesValidation = False
        list_dvt.tat.Visible = False
        list_dvt.AddToolStripMain(bar_qddvt)
    End Sub
    Private Sub beforeAddgd()
        If grd.CurrentRow Is Nothing Then
            list_dvt.ContinueAdd = False
            Return
        End If
        Dim defaults As New Collection
        defaults.Add(grd.Item("ma_dvt", grd.CurrentRow.Index).Value, "ma_dvt_c")
        defaults.Add(grd.Item("ma_vt", grd.CurrentRow.Index).Value, "ma_vt")
        list_dvt.ValueDefaults = defaults
    End Sub
#End Region

    Private Sub grd_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grd.RowsAdded

        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Vật tư"
        Else
            lbllines.Text = grd.RowCount & " Item(s)"
        End If

    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved

        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Vật tư"
        Else
            lbllines.Text = grd.RowCount & " Item(s)"
        End If
    End Sub

    Sub setup()
        AddItems.AddItemCbb(conn, "select ma_pp,ten_pp,ten_pp2 from dmpp where loai_pp =2", cbbgia_ton, "ten_pp", "ten_pp2", "ma_pp")
        frmin.cbbgia_ton.DataSource = cbbgia_ton.DataSource
        frmin.cbbgia_ton.DisplayMember = cbbgia_ton.DisplayMember
        frmin.cbbgia_ton.ValueMember = cbbgia_ton.ValueMember
        frmin.cbbgia_ton.DropDownStyle = ComboBoxStyle.DropDownList
        ''set gia tri mac dinh cho dmkh
        Dim ValueDefault As New Collection
        ValueDefault.Add(True, "vt_ton_kho")
        ValueDefault.Add(1, "gia_ton")
        list.ValueDefaults = ValueDefault
    End Sub
    Sub setlookup()

        ' Lookup()
        Dim otkvt As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_vt, "tk", True)
        otkvt.oKey = "loai_tk = 0"


        Dim otkgv As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_gv, "tk", False)
        otkgv.oKey = "loai_tk =0"
        Dim otkdt As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_dt, "tk", False)
        otkdt.oKey = "loai_tk =0"
        Dim otkck As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_ck, "tk", False)
        otkck.oKey = "loai_tk =0"
        Dim otkspdd As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_spdd, "tk", False)
        otkspdd.oKey = "loai_tk =0"
        Dim otkclgv As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_cl_gv, "tk", False)
        otkclgv.oKey = "loai_tk =0"
        Dim otktl As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_tl, "tk", False)
        otktl.oKey = "loai_tk =0"
        Dim otkdl As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk_dl, "tk", False)
        otkdl.oKey = "loai_tk =0"

        Dim othue As New ClsLookup.AutoCompleteLookup(conn, "dmvat", frmin.txtma_thue, "ma_thue", False)
        othue.SetValue("thue_suat", frmin.ma_so_thue)

        Dim odvt As New ClsLookup.AutoCompleteLookup(conn, "dmdvt0", frmin.txtma_dvt, "ma_dvt", True)
        Dim okho As New ClsLookup.AutoCompleteLookup(conn, "dmkho", frmin.txtma_kho, "ma_kho", False)
        okho.oKey = "ma_dvcs = '" & Reg.GetValue("unit") & "'"
        Dim oloaivt As New ClsLookup.AutoCompleteLookup(conn, "dmloaivt", frmin.txtloai_vt, "ma_loai_vt", True)


        Dim onhomvt1 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomvt", frmin.txtnh_vt1, "ma_nhom", False)
        onhomvt1.oKey = "loai_nhom = 1"

        Dim onhomvt2 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomvt", frmin.txtnh_vt2, "ma_nhom", False)
        onhomvt2.oKey = "loai_nhom = 2"

        Dim onhomvt3 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomvt", frmin.txtnh_vt3, "ma_nhom", False)
        onhomvt3.oKey = "loai_nhom = 3"

        If Reg.GetValue("Language") = "Vi" Then
            otkvt.SetValue("ten_tk", frmin.ten_tk_vt)
            otkgv.SetValue("ten_tk", frmin.ten_tk_gv)
            otkdt.SetValue("ten_tk", frmin.ten_tk_dt)
            otkck.SetValue("ten_tk", frmin.ten_tk_ck)
            otkspdd.SetValue("ten_tk", frmin.ten_tk_spdd)

            otkclgv.SetValue("ten_tk", frmin.tk_cl_gv)
            otktl.SetValue("ten_tk", frmin.tk_tra_lai)
            otkdl.SetValue("ten_tk", frmin.tk_dl)



            odvt.SetValue("ten_dvt", frmin.ten_dvt)

            okho.SetValue("ten_kho", frmin.ten_kho)

            onhomvt1.SetValue("ten_nhom", frmin.ten_nh_vt1)
            onhomvt2.SetValue("ten_nhom", frmin.ten_nh_vt2)
            onhomvt3.SetValue("ten_nhom", frmin.ten_nh_vt3)

            oloaivt.SetValue("ten_loai_vt", frmin.ten_loai_vt)
        Else
            otkvt.SetValue("ten_tk2", frmin.ten_tk_vt)
            otkgv.SetValue("ten_tk2", frmin.ten_tk_gv)
            otkdt.SetValue("ten_tk2", frmin.ten_tk_dt)
            otkck.SetValue("ten_tk2", frmin.ten_tk_ck)
            otkspdd.SetValue("ten_tk2", frmin.ten_tk_spdd)

            otkclgv.SetValue("ten_tk2", frmin.tk_cl_gv)
            otktl.SetValue("ten_tk2", frmin.tk_tra_lai)
            otkdl.SetValue("ten_tk2", frmin.tk_dl)


            odvt.SetValue("ten_dvt2", frmin.ten_dvt)
            okho.SetValue("ten_kho2", frmin.ten_kho)
            onhomvt1.SetValue("ten_nhom2", frmin.ten_nh_vt1)
            onhomvt2.SetValue("ten_nhom2", frmin.ten_nh_vt2)
            onhomvt3.SetValue("ten_nhom2", frmin.ten_nh_vt3)

            oloaivt.SetValue("ten_loai_vt2", frmin.ten_loai_vt)
        End If
    End Sub
    Sub loadf()
       
        setup()


        'bind data cho view
        PropertyOfForm.BindData(list.BindingSource, thong_tin_chung)
        PropertyOfForm.BindData(list.BindingSource, thong_tin_pha_tich)

        'sercurity
        PropertyOfForm.Sercurity(thong_tin_chung)
        PropertyOfForm.Sercurity(thong_tin_pha_tich)
        ' setupttgd()
        'set up cmd
        frmin.btnhuy.CausesValidation = False
       


        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        AddHandler gridgd.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler grd.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler list.AfterAddItem, AddressOf list_AfterAddItem
        AddHandler list.AfterDeleteItem, AddressOf list_AfterDeleteItem
        AddHandler list.BeforeAddItem, AddressOf BeforeAddItem
    End Sub
    
End Class
