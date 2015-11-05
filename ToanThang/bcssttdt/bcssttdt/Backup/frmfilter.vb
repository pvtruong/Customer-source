Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        If Txtden_ngay.Text.Replace(" ", "") <> "//" Then
            Clsql.Reg.SetValue("den_ngay", Txtden_ngay.Value)
        Else
            Txtden_ngay.Value = DateSerial(2099, 12, 31)
        End If

        If txttu_ngay.Text.Replace(" ", "") <> "//" Then
            Clsql.Reg.SetValue("tu_ngay", txttu_ngay.Value)
        Else
            txttu_ngay.Value = DateSerial(1901, 1, 1)
        End If
        'Clsql.Reg.SetValue("tk", txttk.Text)

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fmau As New frmkbmau
        fmau.Icon = Me.Icon
        fmau.Show()
    End Sub

   
   
End Class