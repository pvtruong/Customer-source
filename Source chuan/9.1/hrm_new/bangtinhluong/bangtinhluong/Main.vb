﻿Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)

        Dim oLable As Collection = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
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
        lbluser.Text = Clsql.Reg.GetValue("ID")
        lblunit.Text = frmdkloc.cbbma_dvcs.Text
        'ClsControl2.PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        ClsControl2.PropertyOfForm.SetImage4Control("find.bmp", btndkloc)
        ClsControl2.PropertyOfForm.SetImage4Control("refresh.bmp", btnrefresh2)
        printer.Text = rpt.cPrint.GetPrinter
        'ClsControl2.PropertyOfForm.SetImage4Control("printer.bmp", lbluser)
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        ngaycuatuan.Add(0, "CN")
        ngaycuatuan.Add(1, "T2")
        ngaycuatuan.Add(2, "T3")
        ngaycuatuan.Add(3, "T4")
        ngaycuatuan.Add(4, "T5")
        ngaycuatuan.Add(5, "T6")
        ngaycuatuan.Add(6, "T7")
    End Sub
    Dim ngaycuatuan As New Dictionary(Of Integer, String)
    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btndkloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndkloc.Click
        If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GetQuery()

            rpt.Query = query


            lblunit.Text = frmdkloc.cbbma_dvcs.Text
        End If
    End Sub
    

#Region "form dkloc"
    Sub setupdkloc()
        Try
            frmdkloc.txtthang.Value = Now.Month
            frmdkloc.txtnam.Value = Now.Year
        Catch ex As Exception
        End Try
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store & " "
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.txtthang.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_nv.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_bp.Text)
    End Sub

#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
    End Sub
    Sub print(ByVal kieu As Integer)
        grd.EndEdit()
        Dim qr = From r As DataGridViewRow In grd.Rows Where r.Cells("sel").Value = True
        For Each r As DataGridViewRow In qr
            Dim queryprint As String
            Dim ma_nv As String = r.Cells("ma_nv").Value
            queryprint = "exec  inbangluong "
            queryprint = queryprint & rpt.conn.ConvertToSQLType(frmdkloc.txtthang.Value)
            queryprint = queryprint & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
            queryprint = queryprint & "," & rpt.conn.ConvertToSQLType(ma_nv)
            rpt.cPrint.Dataset = rpt.conn.GetDataSet(queryprint)
            Try
                If kieu = 1 Then
                    rpt.cPrint.Print()
                Else
                    rpt.cPrint.RefreshReport()
                    rpt.cPrint.PrintRPT.ShowDialog(Me)
                End If
            Catch ex As Exception

            End Try

        Next
    End Sub
    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click, btnIN.Click
        If grd.Columns.Contains("sel") AndAlso grd.Columns("sel").Visible = True Then
            If sender.name = btnpreview.Name Then
                print(2)
            Else
                print(1)
            End If
        Else
            If sender.name = btnpreview.Name Then
                rpt.cPrint.Show()
            Else
                rpt.cPrint.Print()
            End If
        End If

    End Sub
    Sub SetParas()
        For Each c As DataGridViewColumn In grd.Columns
            If c.Visible = True Then
                rpt.cPrint.SetParameterValue(c.Name, c.HeaderText)
            End If
        Next
    End Sub


End Class
