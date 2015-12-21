Public Class frmDiemdanh
    Dim conn As New Clsql.SQL

    Private Sub frmDiemdanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClsControl2.PropertyOfForm.SetICon4Control("mainicon.ico", Me)
        ClsLookup.AddItems.AddItemCbb(conn, "select * from  dmkhoahoc where trang_thai =1", cbbma_khoa_hoc, "ten_khoa_hoc", "ma_khoa_hoc")
        If cbbma_khoa_hoc.Items.Count > 0 Then
            cbbma_khoa_hoc.SelectedIndex = 0
        End If
        diemdanh()
        txtma_the.Focus()
    End Sub

    Private Sub cbbma_khoa_hoc_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbma_khoa_hoc.SelectedValueChanged
        If cbbma_khoa_hoc.SelectedValue IsNot Nothing AndAlso TypeOf cbbma_khoa_hoc.SelectedValue Is String Then
            ClsLookup.AddItems.AddItemCbb(conn, "select * from  mpcl where ma_khoa_hoc ='" & cbbma_khoa_hoc.SelectedValue.ToString & "'", cbbma_lop, "ten_lop", "so_ct")
        End If
        txtma_the.Focus()
    End Sub

    Private Sub cbbma_lop_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbma_lop.SelectedValueChanged
        txtma_the.Focus()
    End Sub
    Sub diemdanh()
        Dim dt As DataTable = conn.GetDatatable("exec cdiemdanh '" & txtma_the.Text & "','" & cbbma_lop.SelectedValue & "'")
        ClsControl2.PropertyOfGrid.FillGrid(conn, "diemdanh", grdthongtinthanhvien, dt.DefaultView)
    End Sub

    Private Sub txtma_the_KeyDown(sender As Object, e As KeyEventArgs) Handles txtma_the.KeyDown
        If e.KeyCode = 13 Then
            diemdanh()
            txtma_the.Text = ""
            If grdthongtinthanhvien.Rows.Count = 0 Then
                MsgBox("Thẻ này không tồn tại hoặc hết hạn sử dụng",, Clsql.AboutMe.Name)
            End If
        End If
    End Sub
End Class
