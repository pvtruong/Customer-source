Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click


        If TxtDen_ngay.Text.Replace(" ", "") <> "//" Then
            Clsql.Reg.SetValue("den_ngay", TxtDen_ngay.Value)
        Else
            TxtDen_ngay.Value = DateSerial(2099, 12, 31)
        End If
        If cbbnhom.SelectedValue = cbbbctheo.SelectedValue Then
            MsgBox("Chỉ tiêu 1 phải khác báo cáo theo",, Clsql.AboutMe.Name)
            Return
        End If
        If cbbnhomtheo2.SelectedValue <> "" AndAlso (cbbnhomtheo2.SelectedValue = cbbnhom.SelectedValue OrElse cbbnhomtheo2.SelectedValue = cbbbctheo.SelectedValue) Then
            MsgBox("Chỉ tiêu 2 phải khác Chỉ tiêu 1 và báo cáo theo",, Clsql.AboutMe.Name)
            Return
        End If
        If cbbnhomtheo3.SelectedValue <> "" AndAlso (cbbnhomtheo3.SelectedValue = cbbnhom.SelectedValue OrElse cbbnhomtheo3.SelectedValue = cbbnhomtheo2.SelectedValue OrElse cbbnhomtheo3.SelectedValue = cbbbctheo.SelectedValue) Then
            MsgBox("Chỉ tiêu 3 phải khác Chỉ tiêu 1 và Chỉ tiêu 2",, Clsql.AboutMe.Name)
            Return
        End If
        Clsql.Reg.SetValue(rptid & "bctheo", cbbbctheo.SelectedValue)
        Clsql.Reg.SetValue(rptid & "nhomtheo", cbbnhom.SelectedValue)
        Clsql.Reg.SetValue(rptid & "nhomtheo2", cbbnhomtheo2.SelectedValue)
        Clsql.Reg.SetValue(rptid & "nhomtheo3", cbbnhomtheo3.SelectedValue)

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmfilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class