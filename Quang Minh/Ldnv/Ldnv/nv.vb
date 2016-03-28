Imports Clsql

Public Class nv

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabControl1.SelectedTab = thong_tin_chung
        txtma_nv.Focus()
    End Sub

    Private Sub txths_luong_cp_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txths_luong_cp.Validated, txtluong_tt.Validated, txtphu_cap_cv.Validated
        txttien_luong_cp.Value = txths_luong_cp.Value * txtluong_tt.Value + txtphu_cap_cv.Value * txtluong_tt.Value
    End Sub

    Private Sub txths_luong_dn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txths_luong_dn.Validated, txtluong_cb.Validated
        txttien_luong_dn.Value = txtluong_cb.Value * txths_luong_dn.Value
        txttien_bh_xh.Value = txttien_luong_dn.Value * txths_bhxh.Value / 100
        txttien_bh_yt.Value = txttien_luong_dn.Value * txths_bhyt.Value / 100
        txttien_bh_tn.Value = txttien_luong_dn.Value * txths_bhtn.Value / 100
    End Sub



    Private Sub txttien_bh_xh_Valuechanged() Handles txttien_bh_xh.ValueChanged, txttien_bh_tn.ValueChanged, txttien_bh_yt.ValueChanged
        txttong_tien_dong_bh.Value = txttien_bh_xh.Value + txttien_bh_tn.Value + txttien_bh_yt.Value
    End Sub

    

    Private Sub txths_bhxh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txths_bhxh.Validated
        txttien_bh_xh.Value = txttien_luong_dn.Value * txths_bhxh.Value / 100

    End Sub
    Private Sub txths_bhyt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txths_bhyt.Validated
        txttien_bh_yt.Value = txttien_luong_dn.Value * txths_bhyt.Value / 100

    End Sub
    Private Sub txths_bhtn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txths_bhtn.Validated
        txttien_bh_tn.Value = txttien_luong_dn.Value * txths_bhtn.Value / 100

    End Sub




    Private Sub txtngay_nghi_viec_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtngay_nghi_viec.Validated
        If txtngay_nghi_viec.Text.Replace("/", "").Replace(" ", "") = "" Then
            chbdang_lam_viec.Checked = True
        Else
            chbdang_lam_viec.Checked = False
        End If


    End Sub
End Class