Public Class MainForm

    Dim frmdkloc As New frmfilter
    Dim rptid As String = ""
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        'load du lieu
        If Clsql.Others.GetArgu(2) <> "" Then
            query = Clsql.Others.GetArgu(2)
        Else
            If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GetQuery()
            Else
                Me.Close()
                Return
            End If
        End If
        rpt.Query = query
        'Try
        '    lbltts.Text = Strings.Format(rpt.dv.Table.Select("ma_so='270'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))
        '    lbltnv.Text = Strings.Format(rpt.dv.Table.Select("ma_so='440'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))

        'Catch ex As Exception
        '    lbltts.Text = "" 'Strings.Format(rpt.dv.Table.Select("ma_so='270'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))
        '    lbltnv.Text = "" 'Strings.Format(rpt.dv.Table.Select("ma_so='440'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))

        'End Try

        lbluser.Text = Clsql.Reg.GetValue("ID")
        lblunit.Text = frmdkloc.cbbma_dvcs.Text
        'ClsControl2.PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        ClsControl2.PropertyOfForm.SetImage4Control("find.bmp", btndkloc)
        ClsControl2.PropertyOfForm.SetImage4Control("refresh.bmp", btnrefresh2)
        ClsControl2.PropertyOfForm.SetImage4Control("form.bmp", btnmform)
        printer.Text = rpt.cPrint.GetPrinter
        'ClsControl2.PropertyOfForm.SetImage4Control("printer.bmp", lbluser)
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas

    End Sub

    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btndkloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndkloc.Click
        If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GetQuery()
            rpt.Query = query
            lblunit.Text = frmdkloc.cbbma_dvcs.Text
            'Try
            '    lbltts.Text = Strings.Format(rpt.dv.Table.Select("ma_so='270'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))
            '    lbltnv.Text = Strings.Format(rpt.dv.Table.Select("ma_so='440'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))

            'Catch ex As Exception
            '    lbltts.Text = "" 'Strings.Format(rpt.dv.Table.Select("ma_so='270'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))
            '    lbltnv.Text = "" 'Strings.Format(rpt.dv.Table.Select("ma_so='440'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))

            'End Try

        End If
    End Sub
    

#Region "form dkloc"
    Sub setupdkloc()
        Try
            frmdkloc.Txtden_ngay.Value = Clsql.Reg.GetValue("den_ngay")
        Catch ex As Exception
        End Try
        
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txtden_ngay.Value)
        query = query & ",0"
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(rpt.cPrint.drvForm("idform"))
    End Sub

#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
        'Try
        '    lbltts.Text = Strings.Format(rpt.dv.Table.Select("ma_so='270'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))
        '    lbltnv.Text = Strings.Format(rpt.dv.Table.Select("ma_so='440'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))

        'Catch ex As Exception
        '    lbltts.Text = "" 'Strings.Format(rpt.dv.Table.Select("ma_so='270'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))
        '    lbltnv.Text = "" 'Strings.Format(rpt.dv.Table.Select("ma_so='440'")(0)("tien"), Clsql.Format.GetFormatNumeric(rpt.conn))

        'End Try

    End Sub

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click, btnIN.Click
        If sender.name = btnpreview.Name Then
            rpt.cPrint.Show()
        Else
            rpt.cPrint.Print()
        End If
    End Sub
    Sub SetParas()
        For Each c As DataGridViewColumn In grd.Columns
            If c.Visible = True Then
                rpt.cPrint.SetParameterValue(c.Name, c.HeaderText)
            End If
        Next
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.Txtden_ngay.Value)

    End Sub
    Private Sub btnmform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmform.Click
        Dim fmau As New frmkbmau
        fmau.Icon = Me.Icon
        fmau.Show()
    End Sub
End Class
