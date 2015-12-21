Public Class frmGetSO1

    Private Sub btntim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntim.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmGetSO1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")
        Dim lkh As New ClsLookup.AutoCompleteLookup(conn, "dmkh", txtma_kh, "ma_kh", False)
        If conn.Lang = Clsql.SQL.Language.Vietnamese Then
            lkh.SetValue("ten_kh", ten_kh)
        Else
            lkh.SetValue("ten_kh2", ten_kh)
        End If

    End Sub
End Class