Public Class frminput

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabControl1.SelectedTab = tabthong_tin_chinh
        Me.txtma_phi.Focus()
    End Sub

   
End Class