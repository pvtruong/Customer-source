Public Class frminput

    Dim isloaded As Boolean = False

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            Me.txtso_ct.Focus()
            Me.txtso_ct.SelectionStart = txtso_ct.Text.Length
        End If
    End Sub

   

    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        isloaded = False
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            RemoveHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next

    End Sub
    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Dim dvr As DataRowView = cbbma_nt.SelectedItem

        hide_show_control(dvr("ma_nt"))
        isloaded = True

        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        End If
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
            Case ClsSV31.frmTask.Tasks.AddNew
                Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
                Voucher.Mdatatable.AcceptChanges()
                Voucher.News2()
            Case ClsSV31.frmTask.Tasks.Copy
                Voucher.Copy()
            Case ClsSV31.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                oPrint.Print()
                Me.Close()
            Case ClsSV31.frmTask.Tasks.Close
                Me.DialogResult = DialogResult.OK
                Me.Close()
        End Select
    End Sub
    Function save() As Boolean

        For Each item As ToolStripItem In Voucher.toolbar_status.Items
            Dim status As Integer = cbbstatus.SelectedValue
            If item.Name = "status" & status Then
                If item.Visible = False Then
                    MsgBox("Bạn không có quyền sử dụng trạng thái này", , "Thông báo")
                    Return False
                End If
            End If
        Next
        ''''kiem tra chi tiet
        'If Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("dai2").Visible = True And Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("rong2").Visible = True Then
        '    For Each rowid As DataGridViewRow In Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Rows
        '        If rowid.IsNewRow = False Then
        '            If Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Item("dai", rowid.Index).Value <> Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Item("dai2", rowid.Index).Value Or Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Item("rong", rowid.Index).Value <> Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Item("rong2", rowid.Index).Value Then
        '                MsgBox("Không cho phép KCS duyệt", MsgBoxStyle.Exclamation, "Thông báo")

        '                Return False
        '            End If
        '        End If
        '    Next
        'End If


        'If Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("so_lan").Visible = True Then
        '    For Each rowid As DataGridViewRow In Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Rows
        '        If rowid.IsNewRow = False Then
        '            If Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Item("so_lan", rowid.Index).Value < 1 Then
        '                MsgBox("Số lần không hợp lệ", MsgBoxStyle.Exclamation, "Thông báo")

        '                Return False
        '            End If
        '        End If
        '    Next
        'End If

        '''''kiem tra kem
        'If Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("dai2").Visible = True And Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("rong2").Visible = True Then
        '    For Each rowid As DataGridViewRow In Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Rows
        '        If rowid.IsNewRow = False Then
        '            If Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Item("dai", rowid.Index).Value <> Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Item("dai2", rowid.Index).Value Or Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Item("rong", rowid.Index).Value <> Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Item("rong2", rowid.Index).Value Then
        '                MsgBox("Không cho phép KCS duyệt", MsgBoxStyle.Exclamation, "Thông báo")

        '                Return False
        '            End If
        '        End If
        '    Next
        'End If

        ''
        'If Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("so_lan").Visible = True Then
        '    For Each rowid As DataGridViewRow In Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Rows
        '        If rowid.IsNewRow = False Then
        '            If Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Item("so_lan", rowid.Index).Value < 1 Then
        '                MsgBox("Số lần không hợp lệ", MsgBoxStyle.Exclamation, "Thông báo")

        '                Return False
        '            End If
        '        End If
        '    Next
        'End If


        'kiem tra da nhap chi tiet chua
        'If Voucher.CheckKeyIn = False Then
        '    Return False
        'End If
        'kiem tra so chung tu
        If Voucher.CheckSoCT(Txtngay_ct.Value, txtso_ct.Text) = False Then
            Return False
            Exit Function
        End If
        'ket thuc kiem tra
        Voucher.BindingSource.EndEdit()
        'dien cac gia tri cu m vao d
        Voucher.SynMD()
        If Voucher.Action = 1 Then
            Voucher.Insert()
        Else
            Voucher.Update()
        End If
        'post
        ClsSV31.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)
        '
        Return True
    End Function
    Dim t_tien, t_ck, t_thue, t_tt, t_cp, t_sl, t_tien_von, t_tien_nt, t_ck_nt, t_thue_nt, t_tt_nt, t_sl_nt, t_tien_von_nt, t_cp_nt As Double

    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If

        t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_nt") + ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdcanmang").gridDetailKeyin, "tien_nt")
        t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien") + ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdcanmang").gridDetailKeyin, "tien")


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
        If Voucher.Action = 1 Then
            Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
        End If
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


    Sub hide_show_control(ByVal ma_nt As String)




        'Dim ag As String = Clsql.Others.GetArgu(1) & Clsql.Others.GetArgu(2) & Clsql.Others.GetArgu(3) & Clsql.Others.GetArgu(4)

        ''
        'If ag = "PGHstatus=0B4" Or ag = "PGHstatus=0B0" Then
        '    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("dai2").Visible = False
        '    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("rong2").Visible = False

        '    Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("dai2").Visible = False
        '    Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("rong2").Visible = False
        'Else
        '    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("dai2").Visible = True
        '    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("rong2").Visible = True

        '    Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("dai2").Visible = True
        '    Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("rong2").Visible = True
        'End If
        ''
        'If ag = "PGHstatus=0B0" Then
        '    txtkcs_duyet.Visible = False
        '    txtkt_duyet.Visible = False
        '    kcs.Visible = False
        '    kt.Visible = False
        '    txtso_ct.ReadOnly = True



        'End If
        ''
        'If ag = "PGHstatus=0B4" Then
        '    txtkcs_duyet.ReadOnly = True
        '    txtkt_duyet.ReadOnly = False
        '    txtso_ct.ReadOnly = True

        'End If

        ''
        'If ag = "PGHstatus=4B5" And conn.GetValue("select admin from dmnsd where id ='" & Frmmain.txtuser.Text & "'") = False Then
        '    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("dai").ReadOnly = True
        '    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("rong").ReadOnly = True

        '    Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("dai").ReadOnly = True
        '    Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("rong").ReadOnly = True

        '    txtnoi_giao.ReadOnly = True
        '    'txtma_nv.ReadOnly = True
        '    txtma_kh.ReadOnly = True
        '    'txtong_ba.ReadOnly = True
        '    Txtngay_ct.ReadOnly = True
        '    cbbma_nt.Enabled = False
        '    '
        '    txtso_ct.ReadOnly = True
        '    txtkt_duyet.ReadOnly = True
        '    '
        
        'Else
        'Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("dai").ReadOnly = False
        'Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Columns("rong").ReadOnly = False

        'Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("dai").ReadOnly = False
        'Voucher.Tabdetails("vdcanmang").gridDetailKeyin.Columns("rong").ReadOnly = False

        'txtnoi_giao.ReadOnly = False
        ''txtma_nv.ReadOnly = False
        'txtma_kh.ReadOnly = False
        ''txtong_ba.ReadOnly = False
        'Txtngay_ct.ReadOnly = False
        'cbbma_nt.Enabled = True
        ''
        'txtso_ct.ReadOnly = False
        'txtkt_duyet.ReadOnly = False

        'End If



        For Each t As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            t.ma_nt = ma_nt
        Next
        If ma_nt.Trim.ToUpper = ma_nt_ht.Trim.ToUpper Then
           
            '

            Txtty_gia.ReadOnly = True

            Txtt_tien_nt.Hide() 'Visible = False
         
            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
          
        Else

            'Txtty_gia.ReadOnly = False
            
            Txtt_tien_nt.Hide() 'Visible = False

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
           
        End If
    End Sub
   
   
End Class