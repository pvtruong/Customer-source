Public Class frminput

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ClsControl2.PropertyOfForm.FindAndActiveTabPage(txtcode)
        Me.txtcode.Focus()
    End Sub
    Private Sub txtso_lien_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtso_lien.ValueChanged
        For i As Integer = 1 To 9
            Dim txt As TextBox = ClsControl2.PropertyOfForm.GetControlByName("txtten_lien" & i, Me)
            If i <= txtso_lien.Value Then
                txt.Enabled = True
            Else
                txt.Enabled = False
                txt.Text = ""
            End If
        Next
    End Sub
End Class