Public Class frminput

    Dim isloaded As Boolean = False
    Dim t_tien, t_tien_nt As Double

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            Me.txtso_ct.Focus()
            Me.txtso_ct.SelectionStart = txtso_ct.Text.Length
            txtma_kh.ReadOnly = False
            cbbma_gd.Enabled = True
        End If
    End Sub
    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        isloaded = False
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            RemoveHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
        RemoveHandler Voucher.Tabdetails("tdttno").gridDetailKeyin.CellBeginEdit, AddressOf grddetailhd_CellBeginEdit

    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next

        AddHandler Voucher.Tabdetails("tdttno").gridDetailKeyin.CellBeginEdit, AddressOf grddetailhd_CellBeginEdit

    End Sub
    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dvr As DataRowView = cbbma_nt.SelectedItem

        hide_show_control(dvr("ma_nt"))
        isloaded = True
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        End If



        Try
            If isloaded Then
                If cbbma_gd.SelectedValue = 0 Then
                    Voucher.Tabdetails("vdpt1").status = True
                    Voucher.Tabdetails("tdttno").status = False
                    btngetpgh.Visible = False
                    btngetpin.Visible = False
                    btngethoadon.Visible = False
                End If

                If cbbma_gd.SelectedValue = 1 Then
                    Voucher.Tabdetails("vdpt1").status = False
                    Voucher.Tabdetails("tdttno").status = True
                    btngetpgh.Visible = False
                    btngetpin.Visible = False
                    btngethoadon.Visible = True
                End If

                If cbbma_gd.SelectedValue = 2 Then
                    Voucher.Tabdetails("vdpt1").status = False
                    Voucher.Tabdetails("tdttno").status = True
                    btngetpgh.Visible = True
                    btngethoadon.Visible = False
                    btngetpin.Visible = False
                End If

                If cbbma_gd.SelectedValue = 3 Then
                    Voucher.Tabdetails("vdpt1").status = False
                    Voucher.Tabdetails("tdttno").status = True
                    btngethoadon.Visible = False
                    btngetpgh.Visible = False
                    btngetpin.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try

        Voucher.CreateFormKeyIn(True)

    End Sub
#Region "lay ty gia tu dong"
    Dim ngay_ctold As Date
    Private Sub Txtngay_ct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Validated
        If ngay_ctold <> Txtngay_ct.Value Then
            If isloaded Then
                If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
                    Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                End If
            End If
        End If
    End Sub
    Private Sub Txtngay_ct_endter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Enter
        ngay_ctold = Txtngay_ct.Value
    End Sub
#End Region

   

    Private Sub grddetailhd_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        Voucher.Tabdetails("tdttno").gridDetailKeyin.Item("stt_rec", e.RowIndex).Value = Voucher.Stt_rec
        Voucher.Tabdetails("tdttno").gridDetailKeyin.Item("ma_ct", e.RowIndex).Value = Voucherid
        Voucher.Tabdetails("tdttno").gridDetailKeyin.Item("loai_tt", e.RowIndex).Value = 1

    End Sub
    
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If save() = False Then
            Exit Sub
        End If
        If cbbma_gd.SelectedValue = 1 Then
            formtask.btncopy.Enabled = False
        Else
            formtask.btncopy.Enabled = True
        End If
        formtask.btnnew.Enabled = Voucher.rights.NewRight
        If formtask.btncopy.Enabled = True Then
            formtask.btncopy.Enabled = Voucher.rights.NewRight
        End If
        formtask.btnprint.Enabled = Voucher.rights.PrintRight
        formtask.ShowDialog(Me)
        Select Case formtask.task
            Case ClsSV31.frmTask.Tasks.AddNew
                Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
                Voucher.Mdatatable.AcceptChanges()
                Voucher.News2()
                cbbma_gd.Enabled = True
                txtma_kh.Enabled = True
            Case ClsSV31.frmTask.Tasks.Copy

                Voucher.Copy()
            Case ClsSV31.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                'printF()
                oPrint.Print()
                Me.Close()
            Case ClsSV31.frmTask.Tasks.Close
                Me.DialogResult = DialogResult.OK
                Me.Close()
        End Select
    End Sub
    Function save() As Boolean
        'kiem tra so chung tu
        If Voucher.CheckSoCT(Txtngay_ct.Value, txtso_ct.Text) = False Then
            Return False
            Exit Function
        End If

        'ket thuc nhap lieu
        Voucher.BindingSource.EndEdit()

        'xoa cac hoa don khong thanh toan
        For Each r As DataRow In Voucher.Tabdetails("tdttno").Datatable.Select("tien_nt =0")
            r.Delete()
        Next

        'kiem tra da nhap chi tiet chua
        If Voucher.CheckKeyIn = False Then
            Return False
        End If

        '
        For Each detail As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values

            Dim i As Integer = 0
            For Each r As DataGridViewRow In detail.gridDetailKeyin.Rows
                If r.IsNewRow = False Then
                    r.Cells("stt_rec").Value = Voucher.Stt_rec
                    r.Cells("ma_ct").Value = Voucherid
                    r.Cells("ma_nt").Value = cbbma_nt.SelectedValue
                    r.Cells("ty_gia").Value = Txtty_gia.Value
                    r.Cells("so_ct").Value = txtso_ct.Text.Trim
                    r.Cells("ngay_ct").Value = Txtngay_ct.Value
                    r.Cells("line").Value = i

                    '---
                    If cbbma_gd.SelectedValue <> 1 Then
                        If detail.gridDetailKeyin.Columns.Contains("ty_gia_gs_co") Then
                            If chbtg_gs_dd_yn.Checked = False Then
                                If r.Cells("loai_cl_co").Value = 1 Then
                                    r.Cells("ty_gia_gs_co").Value = 0
                                End If

                            End If
                        End If
                    End If

                    '---

                    If detail.gridDetailKeyin.Columns.Contains("ma_dvcs") Then
                        r.Cells("ma_dvcs").Value = Clsql.Reg.GetValue("unit")
                    End If

                    If detail.gridDetailKeyin.Columns.Contains("status") Then
                        r.Cells("status").Value = cbbstatus.SelectedValue
                    End If


                    i += 1

                Else
                    r.Cells("stt_rec").Value = ""
                End If


            Next
        Next

        querytt = getQuerytattoan()
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Voucher.Insert()
        Else
            Voucher.Update()
        End If

        'post detail trong truong hop thanh toan theo hoa don
        Dim sqltattoan As String = ""
        If Voucher.Tabdetails("vdpt1").status = False Then
            sqltattoan = conn.GetInsertQueryFromDatatable(Voucher.Tabdetails("tdttno").Datatable, Voucher.Tabdetails("vdpt1").TableName)
            conn.Execute(sqltattoan)
            Dim tbdetail As DataTable = conn.GetDatatable("select * from vdpt1 where stt_rec ='" & Voucher.Stt_rec & "'")
            '  Clsql.Data.CopyTable(Voucher.Tabdetails("tdttno").Datatable, Voucher.Tabdetails("vdpt1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            Clsql.Data.CopyTable(tbdetail, Voucher.Tabdetails("vdpt1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            tbdetail.Dispose()
        End If
        'post
        ClsSV31.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)
        '
        Voucher.refreshMaster()
        Return True
    End Function
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        If Voucher.Tabdetails("vdpt1").status Then
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdpt1").gridDetailKeyin, "tien_nt")
            t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdpt1").gridDetailKeyin, "tien")

        Else
            t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("tdttno").gridDetailKeyin, "tien")
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("tdttno").gridDetailKeyin, "tien_nt")
        End If

        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien
    End Sub

    Private Sub btnluuandmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluuandmoi.Click
        If save() = False Then
            Exit Sub
        End If
        Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
        Voucher.Mdatatable.AcceptChanges()
        Voucher.News2()
        Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        txtso_ct.Focus()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        'If Voucher.Action = 1 Then
        '    Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
        'End If
        isloaded = False
    End Sub


    Private Sub cbbma_nt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_nt.SelectedValueChanged
        If isloaded = False Then
            Exit Sub
        End If
        Try
            TabControl1.SelectedTab = TabControl1.TabPages(0)
            If cbbma_nt.SelectedItem IsNot Nothing Then
                Dim dvr As DataRowView = cbbma_nt.SelectedItem

                Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                hide_show_control(dvr("ma_nt"))
            End If

        Catch ex As Exception

        End Try
    End Sub

    

    Private Sub cbbma_gd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_gd.SelectedValueChanged

        Try
            If isloaded Then

                If cbbma_gd.SelectedValue = 0 Then
                    Voucher.Tabdetails("vdpt1").status = True
                    Voucher.Tabdetails("tdttno").status = False
                    btngetpgh.Visible = False
                    btngetpin.Visible = False
                    btngethoadon.Visible = False
                End If


                If cbbma_gd.SelectedValue = 1 Then              
                    Voucher.Tabdetails("vdpt1").status = False
                    Voucher.Tabdetails("tdttno").status = True
                    btngetpgh.Visible = False
                    btngetpin.Visible = False
                    btngethoadon.Visible = True
                End If

                If cbbma_gd.SelectedValue = 2 Then
                    Voucher.Tabdetails("vdpt1").status = False
                    Voucher.Tabdetails("tdttno").status = True
                    btngetpgh.Visible = True
                    btngethoadon.Visible = False
                    btngetpin.Visible = False
                End If

                If cbbma_gd.SelectedValue = 3 Then
                    Voucher.Tabdetails("vdpt1").status = False
                    Voucher.Tabdetails("tdttno").status = True
                    btngethoadon.Visible = False
                    btngetpgh.Visible = False
                    btngetpin.Visible = True
                End If

                Voucher.CreateFormKeyIn(True)
            End If
        Catch ex As Exception
        End Try

    End Sub
    Dim ma_khold As String
    Private Sub txtma_kh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Enter, cbbma_gd.Enter
        ma_khold = txtma_kh.Text.Trim
        cbbma_gd.Enabled = True
        txtma_kh.ReadOnly = False
        For Each r As DataGridViewRow In Voucher.Tabdetails("tdttno").gridDetailKeyin.Rows
            If Not r.IsNewRow Then
                If r.Cells("stt_rec_tt").Value <> "" Then
                    txtma_kh.ReadOnly = True
                    cbbma_gd.Enabled = False
                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub txtma_kh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Validated
        If ma_khold.ToUpper <> txtma_kh.Text.Trim.ToUpper Then
            ma_khold = txtma_kh.Text
        End If

    End Sub

    Sub hide_show_control(ByVal ma_nt As String)
        For Each t As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            t.ma_nt = ma_nt
        Next
        If ma_nt.Trim.ToUpper = Clsql.Others.Options("a_dtht", conn) Then

            Voucher.Tabdetails("vdpt1").gridDetailKeyin.Columns("ty_gia_gs_co").Visible = False

            Txtty_gia.ReadOnly = True
            Txtt_tien.Hide() 'Visible = False
            Ltien.Hide() 'Visible = False
            chbtg_gs_dd_yn.Hide()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)

        Else

            Voucher.Tabdetails("vdpt1").gridDetailKeyin.Columns("ty_gia_gs_co").Visible = True
            Txtty_gia.ReadOnly = False
            Txtt_tien.Show() 'Visible = True
            Ltien.Show() 'Visible = True
            chbtg_gs_dd_yn.Show()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()
        End If
    End Sub

    Private Sub btngethoadon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngethoadon.Click
        If layhd.Show("Exec GetInvoice4Rec " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then
           

            Voucher.Tabdetails("tdttno").Datatable.Clear()
            For Each r As DataRow In layhd.DataView.Table.Select("sel = false")
                r.Delete()
            Next
            Voucher.Tabdetails("tdttno").Datatable = layhd.DataView.Table
            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable
            
            SendKeys.Send("{tab}")
        End If
    End Sub

    
   
    Private Sub btngetpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetpin.Click
        If layhd.Show("Exec GetPIN4Rec " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then


            Voucher.Tabdetails("tdttno").Datatable.Clear()
            For Each r As DataRow In layhd.DataView.Table.Select("sel = false")
                r.Delete()
            Next
            Voucher.Tabdetails("tdttno").Datatable = layhd.DataView.Table
            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable

            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub btngetpgh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetpgh.Click
        If layhd.Show("Exec GetPGH4Rec " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then


            Voucher.Tabdetails("tdttno").Datatable.Clear()
            For Each r As DataRow In layhd.DataView.Table.Select("sel = false")
                r.Delete()
            Next
            Voucher.Tabdetails("tdttno").Datatable = layhd.DataView.Table
            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable

            SendKeys.Send("{tab}")
        End If
    End Sub
End Class