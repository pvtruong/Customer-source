Public Class Frmdoinhom
    Public conn As Clsql.SQL
    Private Sub Frmdoinhom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nh_kh1 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomkh", txtnh_kh1, "ma_nhom", False)
        nh_kh1.oKey = "loai_nhom=1"
        nh_kh1.SetValue("ten_nhom", ten_nh_kh1)

        Dim nh_kh2 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomkh", txtnh_kh2, "ma_nhom", False)
        nh_kh2.oKey = "loai_nhom=2"
        nh_kh2.SetValue("ten_nhom", ten_nh_kh2)

        Dim nh_kh3 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomkh", txtnh_kh3, "ma_nhom", False)
        nh_kh3.oKey = "loai_nhom=3"
        nh_kh3.SetValue("ten_nhom", ten_nh_kh3)
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class