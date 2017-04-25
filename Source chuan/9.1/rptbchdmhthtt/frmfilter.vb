Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Clsql.Reg.SetValue("tu_ngay", txtden_ngay.Value) 'Nhớ giá trị tu_ngay
        Clsql.Reg.SetValue("ngay_tt", txtngay_tt.Value) 'Nhớ giá trị den_ngay
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

  
   
End Class