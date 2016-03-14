Public Class dmgiakh
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        list_dmgiakh.Save(sender, e)
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        list_dmgiakh.Cancel(sender, e)
    End Sub

End Class