Public Class frminput
    Dim ty_gia_cu As Double
    Dim isloaded As Boolean = False
    Dim t_tien, t_ck, t_thue, t_tt, t_tien_nt, t_ck_nt, t_thue_nt, t_tt_nt As Double

    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RemoveHandler Voucher.Tabdetails(Voucher.DViewName).ProcessOnGrid.AfterCalcOnCell, AddressOf tinh_tong_tien
    End Sub
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dvr As DataRowView = cbbma_nt.SelectedItem
        ty_gia_cu = Txtty_gia.Value
        'hide_show_control(dvr("ma_nt"))
        isloaded = True
        tinh_tong_tien()
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            'Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        End If
        AddHandler Voucher.Tabdetails(Voucher.DViewName).ProcessOnGrid.AfterCalcOnCell, AddressOf tinh_tong_tien
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
    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            'Me.txtso_ct.Focus()
            'Me.txtso_ct.SelectionStart = txtso_ct.Text.Length

        End If

    End Sub

    Private Sub grddetail_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grddetail.CellBeginEdit
        If IsDBNull(grddetail.Item("stt_rec", e.RowIndex).Value) Then
            grddetail.Item("stt_rec", e.RowIndex).Value = Voucher.Stt_rec
            grddetail.Item("ma_ct", e.RowIndex).Value = Voucherid

        End If

    End Sub
    'Private Sub grddetail_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddetail.CellEndEdit
    '    Dim ty_gia As Double = Txtty_gia.Value
    '    If grddetail.Rows(e.RowIndex).IsNewRow = False Then
    '        Select Case grddetail.Columns(e.ColumnIndex).Name
    '            Case "tk_no"
    '                If String.IsNullOrEmpty(grddetail.Item("tk_du", e.RowIndex).Value.ToString) Then
    '                    grddetail.Item("tk_du", e.RowIndex).Value = grddetail.Item("tk_no", e.RowIndex).Value
    '                End If
    '                If String.IsNullOrEmpty(grddetail.CurrentRow.Cells("ma_kh").Value.ToString) Then
    '                    grddetail.CurrentRow.Cells("ma_kh").Value = txtma_kh.Text
    '                    grddetail.CurrentRow.Cells("ten_kh").Value = txtten_kh.Text
    '                End If

    '            Case "tien_nt"
    '                grddetail.Item("tien", e.RowIndex).Value = grddetail.Item("tien_nt", e.RowIndex).Value * ty_gia

    '                grddetail.Item("tien_ck_nt", e.RowIndex).Value = grddetail.Item("tien_nt", e.RowIndex).Value * grddetail.Item("ty_le_ck", e.RowIndex).Value / 100
    '                grddetail.Item("tien_ck", e.RowIndex).Value = grddetail.Item("tien_ck_nt", e.RowIndex).Value * ty_gia

    '                grddetail.Item("tien_thue_nt", e.RowIndex).Value = (grddetail.Item("tien_nt", e.RowIndex).Value - grddetail.Item("tien_ck_nt", e.RowIndex).Value) * grddetail.Item("thue_suat", e.RowIndex).Value / 100
    '                grddetail.Item("tien_thue", e.RowIndex).Value = grddetail.Item("tien_thue_nt", e.RowIndex).Value * ty_gia

    '                ''''
    '                tinh_tong_tien()
    '                kiem_tra_tk_ck(e.RowIndex)
    '            Case "tien"
    '                grddetail.Item("tien_ck", e.RowIndex).Value = grddetail.Item("tien", e.RowIndex).Value * grddetail.Item("ty_le_ck", e.RowIndex).Value / 100

    '                grddetail.Item("tien_thue", e.RowIndex).Value = (grddetail.Item("tien", e.RowIndex).Value - grddetail.Item("tien_ck", e.RowIndex).Value) * grddetail.Item("thue_suat", e.RowIndex).Value / 100
    '                ''''
    '                tinh_tong_tien()
    '                kiem_tra_tk_ck(e.RowIndex)

    '            Case "ty_le_ck"
    '                If String.IsNullOrEmpty(grddetail.Item("ty_le_ck", e.RowIndex).Value.ToString) Then
    '                    grddetail.Item("tk_ck", e.RowIndex).Value = ""
    '                    grddetail.Item("ty_le_ck", e.RowIndex).Value = 0

    '                End If
    '                grddetail.Item("tien_ck_nt", e.RowIndex).Value = grddetail.Item("tien_nt", e.RowIndex).Value * grddetail.Item("ty_le_ck", e.RowIndex).Value / 100
    '                grddetail.Item("tien_ck", e.RowIndex).Value = grddetail.Item("tien_ck_nt", e.RowIndex).Value * ty_gia

    '                grddetail.Item("tien_thue_nt", e.RowIndex).Value = (grddetail.Item("tien_nt", e.RowIndex).Value - grddetail.Item("tien_ck_nt", e.RowIndex).Value) * grddetail.Item("thue_suat", e.RowIndex).Value / 100
    '                grddetail.Item("tien_thue", e.RowIndex).Value = grddetail.Item("tien_thue_nt", e.RowIndex).Value * ty_gia
    '                tinh_tong_tien()
    '                kiem_tra_tk_ck(e.RowIndex)
    '            Case "tien_ck_nt"
    '                grddetail.Item("tien_ck", e.RowIndex).Value = grddetail.Item("tien_ck_nt", e.RowIndex).Value * ty_gia

    '                grddetail.Item("tien_thue_nt", e.RowIndex).Value = (grddetail.Item("tien_nt", e.RowIndex).Value - grddetail.Item("tien_ck_nt", e.RowIndex).Value) * grddetail.Item("thue_suat", e.RowIndex).Value / 100
    '                grddetail.Item("tien_thue", e.RowIndex).Value = grddetail.Item("tien_thue_nt", e.RowIndex).Value * ty_gia
    '                tinh_tong_tien()
    '                kiem_tra_tk_ck(e.RowIndex)
    '            Case "tien_ck"
    '                grddetail.Item("tien_thue", e.RowIndex).Value = (grddetail.Item("tien", e.RowIndex).Value - grddetail.Item("tien_ck", e.RowIndex).Value) * grddetail.Item("thue_suat", e.RowIndex).Value / 100
    '                tinh_tong_tien()
    '                kiem_tra_tk_ck(e.RowIndex)
    '            Case "ma_thue"

    '                If String.IsNullOrEmpty(grddetail.Item("ma_thue", e.RowIndex).Value.ToString) Then
    '                    grddetail.Item("tk_thue_co", e.RowIndex).Value = ""
    '                    grddetail.Item("tk_du", e.RowIndex).Value = ""
    '                    grddetail.Item("thue_suat", e.RowIndex).Value = 0
    '                    grddetail.Item("tien_thue", e.RowIndex).Value = 0
    '                    grddetail.Item("tien_thue_nt", e.RowIndex).Value = 0

    '                    '  grddetail.Item("tk_thue_co", e.RowIndex).ReadOnly = True
    '                    grddetail.Item("tk_du", e.RowIndex).ReadOnly = True
    '                    '  grddetail.Item("thue_suat", e.RowIndex).ReadOnly = True
    '                    grddetail.Item("tien_thue", e.RowIndex).ReadOnly = True
    '                    grddetail.Item("tien_thue_nt", e.RowIndex).ReadOnly = True
    '                Else
    '                    grddetail.Item("tk_du", e.RowIndex).Value = grddetail.Item("tk_no", e.RowIndex).Value
    '                    'grddetail.Item("tk_thue_co", e.RowIndex).ReadOnly = False
    '                    grddetail.Item("tk_du", e.RowIndex).ReadOnly = False
    '                    'grddetail.Item("thue_suat", e.RowIndex).ReadOnly = False
    '                    grddetail.Item("tien_thue", e.RowIndex).ReadOnly = False
    '                    grddetail.Item("tien_thue_nt", e.RowIndex).ReadOnly = False
    '                End If

    '                grddetail.Item("tien_thue_nt", e.RowIndex).Value = (grddetail.Item("tien_nt", e.RowIndex).Value - grddetail.Item("tien_ck_nt", e.RowIndex).Value) * grddetail.Item("thue_suat", e.RowIndex).Value / 100
    '                grddetail.Item("tien_thue", e.RowIndex).Value = grddetail.Item("tien_thue_nt", e.RowIndex).Value * ty_gia
    '                tinh_tong_tien()
    '                kiem_tra_tk_du_vat(e.RowIndex)
    '            Case "tien_thue_nt"
    '                grddetail.Item("tien_thue", e.RowIndex).Value = grddetail.Item("tien_thue_nt", e.RowIndex).Value * ty_gia
    '                tinh_tong_tien()
    '            Case "tien_thue"
    '                tinh_tong_tien()
    '        End Select

    '    End If
    'End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If save() = False Then
            Exit Sub
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
            Case ClsSV.frmTask.Tasks.Copy
                Voucher.Copy()
            Case ClsSV.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                oPrint.Print()
                Me.Close()
            Case ClsSV.frmTask.Tasks.Close
                Me.DialogResult = DialogResult.OK
                Me.Close()
        End Select
    End Sub
    Function save() As Boolean
        'Voucher.BindingSource.Current("t_tien_nt") = t_tien_nt
        'Voucher.BindingSource.Current("t_tien") = t_tien
        'Voucher.BindingSource.Current("t_thue_nt") = t_thue_nt
        'Voucher.BindingSource.Current("t_thue") = t_thue

        'Voucher.BindingSource.Current("t_ck_nt") = t_ck_nt
        'Voucher.BindingSource.Current("t_ck") = t_ck
        'Voucher.BindingSource.Current("t_tt_nt") = t_tt_nt
        'Voucher.BindingSource.Current("t_tt") = t_tt
        'kiem tra so chung tu
        If Voucher.CheckSoCT(Txtngay_ct.Value, txtso_ct.Text) = False Then
            Return False
            Exit Function
        End If

        Voucher.BindingSource.EndEdit()
        If conn.GetValue("if  exists(select stt_rec from tdttno where status = 5 and stt_rec_tt='" & Voucher.Stt_rec & "') select 0 else select 1 ") = False Then
            MsgBox(Voucher.oLan("417"), MsgBoxStyle.Exclamation, Text)
            Return False
            Exit Function
        End If
        
        If Voucher.CheckKeyIn = False Then
            Return False
        End If
        '  If ClsControl2.PropertyOfGrid.CheckBlankField(grddetail,   
        'dien cac gia tri cu m vao d

        For Each detail As ClsSV.TabDetail20 In Voucher.Tabdetails.Values

            Dim i As Integer = 0
            For Each r As DataRow In detail.Datatable.Rows
                If r.RowState <> DataRowState.Deleted Then
                    r("stt_rec") = Voucher.Stt_rec
                    r("ma_ct") = Voucherid
                    'r("ma_nt") = cbbma_nt.SelectedValue
                    'r("ty_gia") = Txtty_gia.Value
                    r("so_ct") = txtso_ct.Text.Trim
                    r("ngay_ct") = Txtngay_ct.Value
                    r("line") = i
                    i += 1
                End If
            Next
        Next

        If Voucher.Action = 1 Then

            Voucher.Insert()
        Else
            Voucher.Update()
        End If
        'post
        'post(Voucher.Stt_rec, cbbstatus.SelectedValue)
        ClsSV.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)

        'update ton dau, ton cuoi cac phieu lon hon phieu nay
        conn.Execute("EXEC vqvt_updateton '" + Voucher.Stt_rec + "'," + conn.ConvertToSQLType(Txtngay_ct.Value) + "," + conn.ConvertToSQLType(cbbca.SelectedValue) + ",'" + txtso_ct.Text + "'")
        Return True
    End Function
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        't_tien_nt = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien_nt")
        't_tien = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien")
        't_ck_nt = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien_ck_nt")
        't_ck = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien_ck")
        't_thue_nt = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien_thue_nt")
        't_thue = ClsControl2.PropertyOfGrid.Sum(grddetail, "tien_thue")
        't_tt_nt = t_tien_nt - t_ck_nt + t_thue_nt
        't_tt = t_tien - t_ck + t_thue

        'Txtt_tien_nt.Value = t_tien_nt
        'Txtt_tien.Value = t_tien

        'Txtt_ck_nt.Value = t_ck_nt
        'Txtt_ck.Value = t_ck

        'txtt_thue_nt.Value = t_thue_nt
        'txtt_thue.Value = t_thue

        'txtt_tt_nt.Value = t_tt_nt
        'txtt_tt.Value = t_tt


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

    
    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Voucher.Action = ClsSV.Voucher20.Actions.ADD Then
            cbbca.Enabled = True
        Else
            cbbca.Enabled = False
        End If
        isloaded = True

    End Sub

    Private Sub cbbca_SelectedvalueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbca.SelectedValueChanged
        If isloaded = False Then
            Exit Sub
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

                hide_show_control(dvr("ma_nt").ToString.Trim.ToUpper)


                Dim ty_gia As Integer = Txtty_gia.Value
                If ty_gia_cu <> ty_gia Then
                    For Each rowid As DataGridViewRow In grddetail.Rows
                        If rowid.IsNewRow = False Then
                            grddetail.Item("tien", rowid.Index).Value = grddetail.Item("tien_nt", rowid.Index).Value * ty_gia
                            grddetail.Item("tien_ck", rowid.Index).Value = grddetail.Item("tien_ck_nt", rowid.Index).Value * ty_gia
                            grddetail.Item("tien_thue", rowid.Index).Value = grddetail.Item("tien_thue_nt", rowid.Index).Value * ty_gia
                        End If
                    Next
                    ''''
                    tinh_tong_tien()
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
            For Each rowid As DataGridViewRow In grddetail.Rows
                If rowid.IsNewRow = False Then
                    grddetail.Item("tien", rowid.Index).Value = grddetail.Item("tien_nt", rowid.Index).Value * ty_gia
                    grddetail.Item("tien_ck", rowid.Index).Value = grddetail.Item("tien_ck_nt", rowid.Index).Value * ty_gia
                    grddetail.Item("tien_thue", rowid.Index).Value = grddetail.Item("tien_thue_nt", rowid.Index).Value * ty_gia
                End If
            Next
            ''''
            tinh_tong_tien()
        End If

    End Sub

    Private Sub grddetail_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddetail.CellEnter
        If grddetail.CurrentRow.IsNewRow = False Then
            Select Case grddetail.Columns(e.ColumnIndex).Name.ToLower
                Case "ma_kh"
                    kiem_tra_ma_kh(e.RowIndex)
                Case "tk_du"
                    kiem_tra_tk_du_vat(e.RowIndex)
                Case "tk_ck"

                    kiem_tra_tk_ck(e.RowIndex)

            End Select
        End If
    End Sub

    Sub kiem_tra_tk_ck(ByVal inds As Integer)
        Voucher.Tabdetails(Voucher.DViewName).lookups("tk_ck")._IsNullAble = True
        grddetail.Item("tk_ck", inds).ReadOnly = True
        If grddetail.Item("tien_ck", inds).Value + grddetail.Item("tien_ck_nt", inds).Value <> 0 Then
            grddetail.Item("tk_ck", inds).ReadOnly = False
            Voucher.Tabdetails(Voucher.DViewName).lookups("tk_ck")._IsNullAble = False
            grddetail.Item("tk_ck", inds).Tag = "NOTNULL"
        Else
            grddetail.Item("tk_ck", inds).Value = ""
            grddetail.Item("tk_ck", inds).Tag = ""
        End If


    End Sub
    Sub kiem_tra_tk_du_vat(ByVal inds As Integer)
        Voucher.Tabdetails(Voucher.DViewName).lookups("tk_du")._IsNullAble = True
        If Not String.IsNullOrEmpty(grddetail.Item("ma_thue", inds).Value.ToString) Then
            Voucher.Tabdetails(Voucher.DViewName).lookups("tk_du")._IsNullAble = False
            grddetail.Item("tk_du", inds).Tag = "NOTNULL"
        Else
            grddetail.Item("tk_du", inds).Tag = ""
            grddetail.Item("tk_du", inds).Value = ""
        End If
    End Sub
    Sub kiem_tra_ma_kh(ByVal inds As Integer)
        Voucher.Tabdetails(Voucher.DViewName).lookups("ma_kh")._IsNullAble = True
        Dim tmp As Object = conn.GetValue("select tk_cn from dmtk where tk ='" & grddetail.Item("tk_no", inds).Value & "'")
        If tmp.ToString <> "" Then
            If tmp = True Then
                Voucher.Tabdetails(Voucher.DViewName).lookups("ma_kh")._IsNullAble = False
            End If
        End If
        If Voucher.Tabdetails(Voucher.DViewName).lookups("ma_kh")._IsNullAble = True Then
            tmp = conn.GetValue("select tk_cn from dmtk where tk ='" & grddetail.Item("tk_co", inds).Value & "'")
            If tmp.ToString <> "" Then
                If tmp = True Then
                    Voucher.Tabdetails(Voucher.DViewName).lookups("ma_kh")._IsNullAble = False
                End If
            End If
        End If
    End Sub

    Private Sub grddetail_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grddetail.RowsAdded
        tinh_tong_tien()

    End Sub

    Private Sub grddetail_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grddetail.RowsRemoved
        tinh_tong_tien()
    End Sub
    Sub hide_show_control(ByVal ma_nt As String)
        If ma_nt.Trim.ToUpper = Clsql.Others.Options("a_dtht", conn) Then
            'grddetail.Columns("tien").Visible = False
            'grddetail.Columns("tien_ck").Visible = False
            'grddetail.Columns("tien_thue").Visible = False

            'grddetail.Columns("tien_nt").HeaderText = grddetail.Columns("tien").HeaderText
            'grddetail.Columns("tien_ck_nt").HeaderText = grddetail.Columns("tien_ck").HeaderText
            'grddetail.Columns("tien_thue_nt").HeaderText = grddetail.Columns("tien_thue").HeaderText

            'grddetail.Columns("tien_nt").DefaultCellStyle.Format = grddetail.Columns("tien").DefaultCellStyle.Format
            'grddetail.Columns("tien_ck_nt").DefaultCellStyle.Format = grddetail.Columns("tien_ck").DefaultCellStyle.Format
            'grddetail.Columns("tien_thue_nt").DefaultCellStyle.Format = grddetail.Columns("tien_thue").DefaultCellStyle.Format


            Txtty_gia.ReadOnly = True
            'Txtt_tien.Hide() 'Visible = False
            'Txtt_ck.Hide() 'Visible = False
            'txtt_thue.Hide() 'Visible = False
            'txtt_tt.Hide() 'Visible = False

            'Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            'Txtt_ck_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            'txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            'txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
        Else
            'grddetail.Columns("tien").Visible = True
            'grddetail.Columns("tien_ck").Visible = True
            'grddetail.Columns("tien_thue").Visible = True

            'grddetail.Columns("tien_nt").HeaderText = grddetail.Columns("tien").HeaderText.Trim & " " & cbbma_nt.Text
            'grddetail.Columns("tien_ck_nt").HeaderText = grddetail.Columns("tien_ck").HeaderText.Trim & " " & cbbma_nt.Text
            'grddetail.Columns("tien_thue_nt").HeaderText = grddetail.Columns("tien_thue").HeaderText.Trim & " " & cbbma_nt.Text

            'grddetail.Columns("tien_nt").DefaultCellStyle.Format = grddetail.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(1)
            'grddetail.Columns("tien_ck_nt").DefaultCellStyle.Format = grddetail.Columns("tien_ck_nt").HeaderCell.Tag.ToString.Split("?")(1)
            'grddetail.Columns("tien_thue_nt").DefaultCellStyle.Format = grddetail.Columns("tien_thue_nt").HeaderCell.Tag.ToString.Split("?")(1)


            Txtty_gia.ReadOnly = False
            'Txtt_tien.Show() 'Visible = True
            'Txtt_ck.Show() 'Visible = True
            'txtt_thue.Show() 'Visible = True
            'txtt_tt.Show() 'Visible = True

            'Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            'Txtt_ck_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            'txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            'txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
        End If
    End Sub
    Sub hide_show_field(ByVal ca As Integer)
        'Select Case ca
        '    Case 0
        '        Txtky_kh00.Enabled = False
        '        Txtty_le_kh.Enabled = False
        '        Txttong_sl.Enabled = False
        '    Case 1
        '        Txtky_kh00.Enabled = False
        '        Txtty_le_kh.Enabled = False
        '        Txttong_sl.Enabled = True
        '    Case 2
        '        Txtky_kh00.Enabled = True
        '        Txtty_le_kh.Enabled = True
        '        Txttong_sl.Enabled = False
        'End Select
    End Sub

    Private Sub frminput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbma_nt.Hide()
        Txtty_gia.Hide()

    End Sub
End Class