Public Class frminput



  

    Private Sub cbbmcal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbmcal.SelectedValueChanged
        Try

            If cbbmcal.SelectedValue = 0 Then
                ptinh_theo_tk.Enabled = False
                txtcach_tinh.Enabled = True
                txtcach_tinh2.Enabled = True
                txttk_no.Text = ""
            Else
                ptinh_theo_tk.Enabled = True
                txtcach_tinh.Enabled = False
                txtcach_tinh2.Enabled = False
                txtcach_tinh.Text = ""
            End If
        Catch ex As Exception

        End Try
        
    End Sub

   
End Class