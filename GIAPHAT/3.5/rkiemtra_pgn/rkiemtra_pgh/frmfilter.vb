Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        My.Settings.tu_ngay = Txttu_ngay.Value
        My.Settings.den_ngay = Txtden_ngay.Value
       

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    
   
End Class