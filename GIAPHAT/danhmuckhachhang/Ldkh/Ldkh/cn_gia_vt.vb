Public Class cn_gia_vt


    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtma_vt.Focus()
    End Sub
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        list_cn_gia_vt.Save(sender, e)
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        list_cn_gia_vt.Cancel(sender, e)
    End Sub
End Class