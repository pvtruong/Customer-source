Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Clsql.Reg.SetValue("tu_ngay", Txttu_ngay.Value)
        Clsql.Reg.SetValue("den_ngay", TxtDen_ngay.Value)
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

   
   
End Class