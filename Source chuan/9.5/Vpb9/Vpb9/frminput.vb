Public Class frminput

    Dim isloaded As Boolean = False
    Dim t_tien, t_ck, t_thue, t_tt, t_tien_nt, t_ck_nt, t_thue_nt, t_tt_nt As Double
    Dim _parent As Frmmain, voucher As ClsSV31.Voucher20
    Public Sub setParent(_p As Frmmain)
        _parent = _p
        voucher = _p.Voucher
    End Sub
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

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
        voucher.Tabdetails(voucher.TabFirst).gridDetailKeyin.AllowUserToAddRows = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txttk_dt.Text = "" Then
            Dim _msg As String = "Please update revenue account before allocating"
            If conn.Lang = Clsql.SQL.Language.Vietnamese Then
                _msg = "Bạn phải cập nhật tài khoản doanh thu trước khi phân bổ"
            End If
            txttk_dt.Focus()
            MsgBox(_msg,, Clsql.AboutMe.Name)
            Return
        End If
        Dim query As String = "exec allocateRevenue " & Txtngay_ct.Value.Month & "," & Txtngay_ct.Value.Year & ",'" & txttk_dt.Text & "','" & voucher.Stt_rec & "'"
        Dim dt As DataTable = conn.GetDatatable(query)
        Clsql.Data.CopyTable(dt, voucher.Tabdetails(voucher.TabFirst).Datatable, "1=1")

        voucher.Tabdetails(voucher.TabFirst).Datatable.AcceptChanges()

    End Sub

    Private formtask As ClsSV31.frmTask
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If save() = False Then
            Exit Sub
        End If
        'set up formtask
        If formtask Is Nothing Then
            formtask = New ClsSV31.frmTask
            ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, formtask)
            formtask.Icon = Me.Icon
            formtask.btnnew.Enabled = voucher.rights.NewRight
            If formtask.btncopy.Enabled = True Then
                formtask.btncopy.Enabled = voucher.rights.NewRight
            End If
            formtask.btnprint.Enabled = voucher.rights.PrintRight
        End If

        formtask.ShowDialog(Me)
        Select Case formtask.task
            Case ClsSV31.frmTask.Tasks.AddNew
                Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
                Voucher.Mdatatable.AcceptChanges()
                Voucher.News2()
            Case ClsSV31.frmTask.Tasks.Copy
                Voucher.Copy()
            Case ClsSV31.frmTask.Tasks.TD1

                Me.Close()
            Case ClsSV31.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                _parent.getPrint.Print()
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

        Voucher.BindingSource.EndEdit()


        If Voucher.CheckKeyIn = False Then
            Return False
        End If

        'dien cac gia tri cu m vao d
        voucher.SynMD()
        If Voucher.Action = 1 Then

            Voucher.Insert()
        Else
            Voucher.Update()
        End If
        'post
        ClsSV31.Functions.Post(conn, voucher.voucherID, voucher.Mviewname, voucher.Stt_rec, cbbstatus.SelectedValue)
        '
        Return True
    End Function
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_nt")
        t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien")



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

        txtso_ct.Focus()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        If Voucher.Action = 1 Then
            Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
        End If
    End Sub

    Sub hide_show_control(ByVal ma_nt As String)


    End Sub
    Dim so_hd, so_seri As String, ngay_hd As Date




End Class