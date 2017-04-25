Public Class frmfilter
    Public conn As Clsql.SQL
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim ngay_ks_luong As Date = conn.GetValue("select ngay_ks_luong from dmstt")
        If ngay_ks_luong <> Nothing AndAlso DateSerial(txtnam.Value, txtthang.Value, 1) < ngay_ks_luong Then
            MsgBox("Dữ liệu lương đã được khóa đến ngày " & Strings.Format(ngay_ks_luong, "dd/MM/yyyy"),, Clsql.AboutMe.Name)
            Return
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmfilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class