Public Class Form1
    Dim conn As New Clsql.SQL
    Dim ap_gia_tri_cl_pxc As String
    Dim dmct As DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        If Not Clsql.SystemSTP.CheckLogin Then
            Application.Exit()
            Return
        End If
        If Not conn.GetValue("select admin from dmnsd where id='" & Clsql.Reg.GetValue("id") & "'") Then
            MsgBox("Chỉ người dùng có quyền quản trị mới thực hiện được tác vụ này",, Clsql.AboutMe.Name)
            Application.Exit()
            Return
        End If
        txtdatabase.Text = conn.database
        txtserver.Text = conn.IP
        Txtnam.Value = Now.Year
        progressbar.Visible = False
        dmct = conn.GetDatatable("select cast(0 as bit) as sel,* from dmct")
        ClsControl2.PropertyOfGrid.FillGrid(conn, "dmct", DataGridView1, dmct.DefaultView)
    End Sub
    Dim olan As Collection
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        BackgroundWorker1.CancelAsync()
        Application.Exit()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Sub Exec()
        If MsgBox("Dữ liệu sẽ không thể được phục hồi sau khi xóa. Bạn có chắc chắn xóa không?", MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
            If MsgBox("Hãy kiểm tra lại các chứng từ cần xóa một lần nữa. Dữ liệu sẽ không thể được phục hồi sau khi xóa. Bạn có chắc chắn xóa không?", MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
                conn.Server.writeLog("Dữ liệu đã được xóa đến hết năm " & Txtnam.Value & " bởi " & Clsql.Reg.GetValue("id") & " lúc " & conn.Server.GetDate.ToString, "delete_data")
                btnOK.Enabled = False
                btnCancel.Enabled = True
                progressbar.Visible = True
                lblstatus.Text = "Chương trình đang thực hiện..."
                calc()
            End If
        End If
    End Sub
    Private Sub calc()
        Dim ds As New DataSet
        dmct.AcceptChanges()
        'xoa so du dau ky
        Dim query As String = "exec delete_dauky " & Txtnam.Value
        conn.Execute(query)
        'xoa chung tu
        For Each r As DataRow In dmct.Select("sel=true")
            deleteCt(r("ma_ct"))
        Next
        ds.Dispose()
        lblstatus.Text = "Đã hoàn thành"
    End Sub
    Private Sub deleteCt(ma_ct As String)
        Dim ngay_cuoi_nam As Date = DateSerial(Txtnam.Value, 12, 31)
        Dim master_table_name As String = conn.GetValue("select mastertable From voucherinfo where voucherid='" & ma_ct & "'")
        If String.IsNullOrEmpty(master_table_name) Then Return
        Dim dtmaster As DataTable = conn.GetDatatable("select * from " & master_table_name & " where ma_ct='" & ma_ct & "' and  ngay_ct<=" & conn.ConvertToSQLType(ngay_cuoi_nam))
        For Each m As DataRow In dtmaster.Rows
            Dim query As String = ""
            'delete book
            Dim dtstore As DataTable = conn.GetDatatable("select * from voucherstore where voucherid='" & ma_ct & "'")
            For Each r As DataRow In dtstore.Rows
                query = query & Chr(13) & "delete from " & r("tablename") & " where " & r("delete_condition")
            Next
            'delete detail
            Dim dtdetail As DataTable = conn.GetDatatable("select tablename From voucherdetailinfo where voucherid='" & ma_ct & "'")

            For Each r As DataRow In dtdetail.Rows
                query = query & Chr(13) & "delete From " & r("tablename") & " where stt_rec='" & m("stt_rec") & "'"
            Next
            'delete master
            query = query & Chr(13) & "delete From " & master_table_name & " where stt_rec ='" & m("stt_rec") & "'"
            '
            For Each c As DataColumn In dtmaster.Columns
                query = query.Replace("#" & c.ColumnName & "#", conn.ConvertToSQLType(m(c)))
            Next
            conn.Execute(query)
        Next

    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Exec()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        progressbar.Visible = False
        btnOK.Enabled = True
        btnCancel.Enabled = False
        MsgBox("Chương trình đã thực hiện xong", , Clsql.AboutMe.Name)
    End Sub
End Class
