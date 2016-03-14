Imports Clsql

Public Class dgd
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtten_cv.Focus()
    End Sub
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        list_gd.Save(sender, e)
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        list_gd.Cancel(sender, e)
    End Sub
    Private Sub dgd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim odxl As New ClsLookup.AutoCompleteLookup(conn, "dmxl", txttrang_thai_xl, "trang_thai_xl", True)
        If Reg.GetValue("Language") = "Vi" Then
            odxl.SetValue("ten", ten_trang_thai)
            ClsLookup.AddItems.AddItemCbb(conn, "select ma_lcv,ten from dlcv where trang_thai =1", cbbma_lcv, "ten", "ma_lcv")

        Else
            odxl.SetValue("ten2", ten_trang_thai)
            ClsLookup.AddItems.AddItemCbb(conn, "select ma_lcv,ten2 from dlcv where trang_thai =1", cbbma_lcv, "ten2", "ma_lcv")

        End If
        Dim oNCC As New ClsLookup.AutoCompleteLookup(conn, "dmnv", txtma_nv, "ma_nv", False)
        oNCC.SetValue("ten_nv", ten_nv)
    End Sub
End Class