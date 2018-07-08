Public Class frmGetPN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmGetPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txttu_ngay.Value = Date.Now
        Txtden_ngay.Value = Date.Now
    End Sub
End Class