﻿Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtloai_yt.Text = "" Then
            txtloai_yt.Focus()
            Return
        End If

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
   
End Class