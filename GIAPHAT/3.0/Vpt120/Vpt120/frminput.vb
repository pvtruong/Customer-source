Public Class frminput
    Dim ty_gia_cu As Double
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
    End Sub
    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dvr As DataRowView = cbbma_nt.SelectedItem
        ty_gia_cu = Txtty_gia.Value
        hide_show_control(dvr("ma_nt"))
        isloaded = True
        tinh_tong_tien()
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        End If

    End Sub
#Region "lay ty gia tu dong"
    Dim ngay_ctold As Date
    Private Sub Txtngay_ct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Validated
        If ngay_ctold <> Txtngay_ct.Value Then
            If isloaded Then
                If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
                    Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                End If
            End If
        End If
    End Sub
    Private Sub Txtngay_ct_endter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Enter
        ngay_ctold = Txtngay_ct.Value
    End Sub
#End Region

    Private Sub grddetail_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grddetail.CellBeginEdit
        If IsDBNull(grddetail.Item("stt_rec", e.RowIndex).Value) Then
            grddetail.Item("stt_rec", e.RowIndex).Value = Voucher.Stt_rec
            grddetail.Item("ma_ct", e.RowIndex).Value = Voucherid
        End If

    End Sub
    Private Sub grddetail_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddetail.CellEndEdit
        Dim ty_gia As Double = Txtty_gia.Value
        If grddetail.Rows(e.RowIndex).IsNewRow = False Then


            Select Case grddetail.Columns(e.ColumnIndex).Name
                Case "tk_no"
                    If String.IsNullOrEmpty(grddetail.Item("ma_kh", e.RowIndex).Value.ToString) Then
                        grddetail.Item("ma_kh", e.RowIndex).Value = txtma_kh.Text
                        grddetail.Item("ten_kh", e.RowIndex).Value = txtten_kh.Text
                    End If
                Case "tien_nt"
                    If grddetail.Item("loai_cl_co", e.RowIndex).Value <> 0 Then
                        If grddetail.Item("ty_gia_gs_co", e.RowIndex).Visible = True Then
                            ty_gia = grddetail.Item("ty_gia_gs_co", e.RowIndex).Value
                        End If
                    End If
                    grddetail.Item("tien", e.RowIndex).Value = ty_gia * grddetail("tien_nt", e.RowIndex).Value
                    tinh_tong_tien()
                Case "tien"
                    tinh_tong_tien()
            End Select
        End If
    End Sub


    Private Sub grddetailhd_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grddetailhd.CellBeginEdit
        grddetailhd.Item("stt_rec", e.RowIndex).Value = Voucher.Stt_rec
        grddetailhd.Item("ma_ct", e.RowIndex).Value = Voucherid
        grddetailhd.Item("loai_tt", e.RowIndex).Value = 1

    End Sub

   

    Private Sub grddetailhd_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddetailhd.CellEndEdit
        If grddetailhd.Rows(e.RowIndex).IsNewRow = False Then
            Dim ty_gia As Double = Txtty_gia.Value
            Select Case grddetailhd.Columns(e.ColumnIndex).Name
                Case "tien_nt"
                    grddetailhd.Item("tien", e.RowIndex).Value = ty_gia * grddetailhd("tien_nt", e.RowIndex).Value
                    If cbbma_nt.SelectedValue.ToString.ToLower = grddetailhd.Item("ma_nt_tt", e.RowIndex).Value.ToString.Trim.ToLower Then
                        grddetailhd.Item("tt_qd", e.RowIndex).Value = grddetailhd("tien_nt", e.RowIndex).Value
                    Else
                        grddetailhd.Item("tt_qd", e.RowIndex).Value = grddetailhd("tien", e.RowIndex).Value / grddetailhd("ty_gia_tt", e.RowIndex).Value

                    End If
                    tinh_tong_tien()
                Case "tien"
                    If cbbma_nt.SelectedValue.ToString.ToLower = grddetailhd.Item("ma_nt_tt", e.RowIndex).Value.ToString.Trim.ToLower Then
                        grddetailhd.Item("tt_qd", e.RowIndex).Value = grddetailhd("tien_nt", e.RowIndex).Value
                    Else
                        grddetailhd.Item("tt_qd", e.RowIndex).Value = grddetailhd("tien", e.RowIndex).Value / grddetailhd("ty_gia_tt", e.RowIndex).Value

                    End If
                    tinh_tong_tien()
            End Select
        End If
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
            Case ClsSV.frmTask.Tasks.AddNew
                Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
                Voucher.Mdatatable.AcceptChanges()
                Voucher.News2()
                cbbma_gd.Enabled = True
                txtma_kh.Enabled = True
            Case ClsSV.frmTask.Tasks.Copy

                Voucher.Copy()
            Case ClsSV.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                'printF()
                oPrint.Print()
                Me.Close()
            Case ClsSV.frmTask.Tasks.Close
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

        If grddetail.Visible = True Then

            If Voucher.CheckKeyIn(Voucher.Tabdetails(Voucher.DViewName)) = False Then

                Return False
            End If
            Voucher.Tabdetails("tdttno").Datatable.Clear()
        Else
            If Voucher.CheckKeyIn(Voucher.Tabdetails("tdttno")) = False Then
                Return False
            End If
            Voucher.Tabdetails(Voucher.DViewName).Datatable.Clear()
        End If

        '
        For Each detail As ClsSV.TabDetail20 In Voucher.Tabdetails.Values

            Dim i As Integer = 0


            For Each r As DataGridViewRow In detail.gridview.Rows
                If r.IsNewRow = False Then
                    r.Cells("stt_rec").Value = Voucher.Stt_rec
                    r.Cells("ma_ct").Value = Voucherid
                    r.Cells("ma_nt").Value = cbbma_nt.SelectedValue
                    r.Cells("ty_gia").Value = Txtty_gia.Value
                    r.Cells("so_ct").Value = txtso_ct.Text.Trim
                    r.Cells("ngay_ct").Value = Txtngay_ct.Value
                    r.Cells("line").Value = i

                    '---
                    'If cbbma_gd.SelectedValue <> 1 Then
                    If cbbma_gd.SelectedValue = 0 Then
                        If detail.gridview.Columns.Contains("ty_gia_gs_co") Then
                            If chbtg_gs_dd_yn.Checked = False Then
                                If r.Cells("loai_cl_co").Value = 1 Then
                                    r.Cells("ty_gia_gs_co").Value = 0
                                End If

                            End If
                        End If
                    End If

                    '---

                    If detail.gridview.Columns.Contains("ma_dvcs") Then
                        r.Cells("ma_dvcs").Value = Clsql.Reg.GetValue("unit")
                    End If

                    If detail.gridview.Columns.Contains("status") Then
                        r.Cells("status").Value = cbbstatus.SelectedValue
                    End If

                    'If detail.gridview.Columns.Contains("tat_toan") Then
                    '    sqltattoan = sqltattoan & Chr(13) & "EXEC TatoanNO '" & r.Cells("stt_rec_tt").Value & "','" & r.Cells("ma_ct_tt").Value & "'"
                    'End If

                    i += 1

                Else
                    r.Cells("stt_rec").Value = ""
                End If


            Next
        Next

        querytt = getQuerytattoan()
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            Voucher.Insert()
        Else
            Voucher.Update()
        End If

        'post detail trong truong hop thanh toan theo hoa don
        Dim sqltattoan As String = ""
        If grddetail.Visible = False Then
            sqltattoan = conn.GetInsertQueryFromDatatable(Voucher.Tabdetails("tdttno").Datatable, Voucher.Tabdetails(Voucher.DViewName).TableName)
            conn.Execute(sqltattoan)
            Dim tbdetail As DataTable = conn.GetDatatable("select * from " & Voucher.DViewName & " where stt_rec ='" & Voucher.Stt_rec & "'")
            '  Clsql.Data.CopyTable(Voucher.Tabdetails("tdttno").Datatable, Voucher.Tabdetails("vdpt1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            Clsql.Data.CopyTable(tbdetail, Voucher.Tabdetails("vdpt1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            tbdetail.Dispose()
        End If
        'post
        ClsSV.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)
        '
        Voucher.refreshMaster()
        Return True
    End Function
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        If grddetail.Visible = True Then
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien_nt")
            t_tien = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien")

        Else
            t_tien = ClsControl2.PropertyOfGrid.Sum(grddetailhd, "tien")
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(grddetailhd, "tien_nt")
        End If


        

        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien
    End Sub
    Sub tinh_tien_ht()
        Dim ty_gia As Double = Txtty_gia.Value
        If grddetail.Visible = True Then
            For Each rowid As DataGridViewRow In grddetail.Rows
                If rowid.IsNewRow = False Then
                    grddetail.Item("tien", rowid.Index).Value = ty_gia * grddetail("tien_nt", rowid.Index).Value

                End If
            Next

        Else
            For Each rowid As DataGridViewRow In grddetailhd.Rows
                If rowid.IsNewRow = False Then
                    grddetailhd.Item("tien", rowid.Index).Value = ty_gia * grddetailhd("tien_nt", rowid.Index).Value
                    If cbbma_nt.SelectedValue.ToString.ToLower = grddetailhd.Item("ma_nt_tt", rowid.Index).Value.ToString.Trim.ToLower Then
                        grddetailhd.Item("tt_qd", rowid.Index).Value = grddetailhd("tien_nt", rowid.Index).Value
                    Else
                        grddetailhd.Item("tt_qd", rowid.Index).Value = grddetailhd("tien", rowid.Index).Value / grddetailhd("ty_gia_tt", rowid.Index).Value

                    End If
                End If
            Next

        End If




        tinh_tong_tien()
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
        If Voucher.Action = 1 Then
            Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
        End If
    End Sub


    Private Sub cbbma_nt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_nt.SelectedValueChanged
        If isloaded = False Then
            Exit Sub
        End If
        Try
            If cbbma_nt.SelectedItem IsNot Nothing Then
                Dim dvr As DataRowView = cbbma_nt.SelectedItem
                ty_gia_cu = Txtty_gia.Value
                Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))

                hide_show_control(dvr("ma_nt"))

                Dim ty_gia As Integer = Txtty_gia.Value
                If ty_gia_cu <> ty_gia Then
                    tinh_tien_ht()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txtty_gia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtty_gia.Enter
        ty_gia_cu = Txtty_gia.Value
    End Sub

    Private Sub Txtty_gia_valid(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtty_gia.Validated
        'tinh lai tien vnd
        Dim ty_gia As Integer = Txtty_gia.Value
        If ty_gia <> ty_gia_cu Then
            tinh_tien_ht()
           
        End If
       
    End Sub

    Private Sub grddetail_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddetail.CellEnter
        If grddetail.CurrentRow.IsNewRow = False Then
            Select Case grddetail.Columns(e.ColumnIndex).Name.ToLower
                Case "ma_kh"
                    Voucher.Tabdetails(Voucher.DViewName).lookups("ma_kh")._IsNullAble = True
                    If grddetail.Item("tk_cn_co", e.RowIndex).Value = True Then
                        Voucher.Tabdetails(Voucher.DViewName).lookups("ma_kh")._IsNullAble = False
                    End If
                Case "ty_gia_gs_co"
                    grddetail.Item("ty_gia_gs_co", e.RowIndex).ReadOnly = (grddetail.Item("loai_cl_co", e.RowIndex).Value = 0)

            End Select


        End If
    End Sub
    Private Sub grddetailhd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddetailhd.CellEnter

    End Sub
    Private Sub grddetailpgh_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub grddetailpin_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub cbbma_gd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_gd.SelectedValueChanged
        Try
            If cbbma_gd.SelectedValue = 0 Then
                grddetail.Visible = True


                btngetpgh.Visible = False
                btngetpin.Visible = False

                grddetailhd.Visible = False
                btngethoadon.Visible = False
            End If
        Catch ex As Exception

        End Try
        Try

            If cbbma_gd.SelectedValue = 1 Then
                grddetail.Visible = False


                btngetpgh.Visible = False
                btngetpin.Visible = False

                grddetailhd.Visible = True
                btngethoadon.Visible = True
            End If
        Catch ex As Exception

        End Try

        Try

            If cbbma_gd.SelectedValue = 2 Then
                grddetail.Visible = False


                btngetpgh.Visible = True

                grddetailhd.Visible = True
                btngethoadon.Visible = False
                btngetpin.Visible = False
            End If


        Catch ex As Exception

        End Try


        Try

            If cbbma_gd.SelectedValue = 3 Then
                grddetail.Visible = False


                btngethoadon.Visible = False
                btngetpgh.Visible = False


                btngetpin.Visible = True
                grddetailhd.Visible = True


            End If


        Catch ex As Exception

        End Try
    End Sub
    Dim ma_khold As String
    Private Sub txtma_kh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Enter, cbbma_gd.Enter
        ma_khold = txtma_kh.Text.Trim
        cbbma_gd.Enabled = True
        txtma_kh.ReadOnly = False
        For Each r As DataGridViewRow In grddetailhd.Rows
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
        If ma_nt.Trim.ToUpper = Clsql.Others.Options("a_dtht", conn) Then
            grddetail.Columns("tien").Visible = False
            grddetail.Columns("ty_gia_gs_co").Visible = False


            grddetailhd.Columns("tien").Visible = False

            

            grddetail.Columns("tien_nt").HeaderText = grddetail.Columns("tien").HeaderText
            grddetailhd.Columns("tien_nt").HeaderText = grddetailhd.Columns("tien").HeaderText


            grddetail.Columns("tien_nt").DefaultCellStyle.Format = grddetail.Columns("tien").DefaultCellStyle.Format
            grddetailhd.Columns("tien_nt").DefaultCellStyle.Format = grddetailhd.Columns("tien").DefaultCellStyle.Format
           

            Txtty_gia.ReadOnly = True
            Txtt_tien.Hide() 'Visible = False
            Ltien.Hide() 'Visible = False
            chbtg_gs_dd_yn.Hide()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            
        Else
            grddetail.Columns("tien").Visible = True
            grddetail.Columns("ty_gia_gs_co").Visible = True



            grddetailhd.Columns("tien").Visible = True


            grddetail.Columns("tien_nt").HeaderText = grddetail.Columns("tien").HeaderText.Trim & " " & cbbma_nt.Text   'grddetail.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(0)
            grddetailhd.Columns("tien_nt").HeaderText = grddetailhd.Columns("tien").HeaderText.Trim & " " & cbbma_nt.Text  'grddetailhd.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(0)
           

            grddetail.Columns("tien_nt").DefaultCellStyle.Format = grddetail.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(1)
            grddetailhd.Columns("tien_nt").DefaultCellStyle.Format = grddetailhd.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(1)
           


            Txtty_gia.ReadOnly = False
            Txtt_tien.Show() 'Visible = True
            Ltien.Show() 'Visible = True
            chbtg_gs_dd_yn.Show()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
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

    Private Sub btngetpgh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetpgh.Click
        If laypgh.Show("Exec GetPGH4Rec " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then


            Voucher.Tabdetails("tdttno").Datatable.Clear()
            For Each r As DataRow In laypgh.DataView.Table.Select("sel = false")
                r.Delete()
            Next
            Voucher.Tabdetails("tdttno").Datatable = laypgh.DataView.Table
            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable

            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub btngetpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetpin.Click
        If laypin.Show("Exec GetPIN4Rec " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then


            Voucher.Tabdetails("tdttno").Datatable.Clear()
            For Each r As DataRow In laypin.DataView.Table.Select("sel = false")
                r.Delete()
            Next
            Voucher.Tabdetails("tdttno").Datatable = laypin.DataView.Table
            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable

            SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub grddetail_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grddetail.RowsAdded, grddetailhd.RowsAdded
        If isloaded Then
            tinh_tong_tien()
        End If

    End Sub

    Private Sub grddetail_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grddetail.RowsRemoved, grddetailhd.RowsRemoved
        If isloaded Then
            tinh_tong_tien()
        End If
    End Sub
    
    
End Class