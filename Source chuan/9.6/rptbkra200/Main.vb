Imports System.IO
Imports System.Net
Imports System.Text

Public Class MainForm
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
        ClsControl2.PropertyOfForm.SetImage4Control("htkkt.bmp", btnhtkkt)
        printer.Text = rpt.cPrint.GetPrinter
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
        End If
    End Sub


#Region "form dkloc"
    Sub setupdkloc()
        Try
            frmdkloc.Txttu_ngay.Value = My.Settings.tu_ngay
            frmdkloc.TxtDen_ngay.Value = My.Settings.den_ngay

        Catch ex As Exception
        End Try
        frmdkloc.txtma_thue.Text = My.Settings.ma_thue


        Dim oTK As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk", False)
        Dim othue As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmvat", frmdkloc.txtma_thue, "ma_thue", False)
        Dim otkdu As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk_du, "tk", False)
        Dim okh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_kh", False)
        Dim oct As New ClsLookup.GetMultiValueFromList(rpt.conn, "dmct", "ma_ct", frmdkloc.txtma_ct)
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            oTK.SetValue("ten_tk", frmdkloc.ten_tk)
            otkdu.SetValue("ten_tk", frmdkloc.ten_tk_du)
            othue.SetValue("ten_thue", frmdkloc.ten_thue)
            okh.SetValue("ten_kh", frmdkloc.ten_kh)
        Else
            oTK.SetValue("ten_tk2", frmdkloc.ten_tk)
            otkdu.SetValue("ten_tk2", frmdkloc.ten_tk_du)
            othue.SetValue("ten_thue2", frmdkloc.ten_thue)
            okh.SetValue("ten_kh2", frmdkloc.ten_kh)

        End If
        ' ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select ma_dvcs,ten_dvcs from ddv", frmdkloc.cbbma_dvcs, "ten_dvcs", "ma_dvcs")


    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_thue.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk_du.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_ct.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("Language"))

        ClsControl2.PropertyOfGrid.Parameter4Export2Excel = New Dictionary(Of String, Object)
        ClsControl2.PropertyOfGrid.Parameter4Export2Excel.Add("ky", frmdkloc.TxtDen_ngay.Value.Month)
        ClsControl2.PropertyOfGrid.Parameter4Export2Excel.Add("nam", frmdkloc.TxtDen_ngay.Value.Year)
    End Sub

#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
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
        rpt.cPrint.SetParameterValue("tu_ngay", frmdkloc.Txttu_ngay.Value)
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.TxtDen_ngay.Value)
        rpt.cPrint.SetParameterValue("ma_thue", frmdkloc.txtma_thue.Text)
        rpt.cPrint.SetParameterValue("ten_thue", frmdkloc.ten_thue.Text)
    End Sub

    Sub export2htkkt()
        Dim fbd As New FolderBrowserDialog
        fbd.ShowNewFolderButton = False
        Dim path As String = Clsql.Reg.GetValue("htkkt_path")
        If path = "" Then
            path = "C:\Program Files\"
        End If
        fbd.SelectedPath = path
        If fbd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            path = fbd.SelectedPath
        Else
            Return
        End If
        Clsql.Reg.SetValue("htkkt_path", path)
        Dim rowbigin As Integer = 8
        'xac dinh thang hoac quy bao cao
        Dim name_file_data As String = path & "/01_1_GTGT_"
        If frmdkloc.Txttu_ngay.Value.Month = frmdkloc.TxtDen_ngay.Value.Month Then
            name_file_data = name_file_data & Strings.Format(frmdkloc.TxtDen_ngay.Value.Month, "00") & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
        Else
            If frmdkloc.TxtDen_ngay.Value.Month <= 3 Then
                name_file_data = name_file_data & "Q01" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
            Else
                If frmdkloc.TxtDen_ngay.Value.Month <= 6 And frmdkloc.TxtDen_ngay.Value.Month > 3 Then
                    name_file_data = name_file_data & "Q02" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
                Else
                    If frmdkloc.TxtDen_ngay.Value.Month <= 9 And frmdkloc.TxtDen_ngay.Value.Month > 6 Then
                        name_file_data = name_file_data & "Q03" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
                    Else
                        name_file_data = name_file_data & "Q04" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
                    End If
                End If
            End If
        End If
        '
        Dim stream As New IO.StreamWriter(name_file_data)
        stream.WriteLine("<!-- Created with STP Accounting (http://saotienphong.com.vn) by Truongpv-->")
        stream.WriteLine("<!DOCTYPE Sections SYSTEM " & Chr(34) & "..\..\InterfaceTemplates\Schema.dtd" & Chr(34) & ">")
        stream.WriteLine("<Sections Version=" & Chr(34) & "321" & Chr(34) & ">")
        'khong thue
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        Dim i As Integer = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_thue ='KT' and sysorder =5")
            stream.WriteLine("      <Cells>")
            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            '  stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")



            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")

            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")
        '0%
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_thue ='00' and sysorder =5")
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            ' stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0%" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")



            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")

            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")
        '5%
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_thue = '05' and sysorder =5")
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            ' stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "05%" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")



            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")

            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")

        '10%
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_thue = '10'  and sysorder =5")
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            ' stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "10%" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")



            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")

            rowbigin += 1
            i += 1
        Next
        stream.WriteLine("  </Section>")
        'KK
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        While (i = 0)
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")

            rowbigin += 1
            i += 1
        End While
        stream.WriteLine("  </Section>")
        'dong tong cong
        rowbigin = rowbigin + 3
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "0" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        For Each r As DataRow In rpt.dv.Table.Select("sysorder =0")
            stream.WriteLine("      <Cells>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "V_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & "/>")
            rowbigin += 1
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "V_" & (rowbigin + 13) & Chr(34) & " Encode=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & "/>")
            rowbigin += 1
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "V_" & (rowbigin + 10) & Chr(34) & " Encode=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")
        Next
        stream.WriteLine("  </Section>")
        'ket thuc
        stream.WriteLine("</Sections>")
        stream.Close()
        MsgBox("Chương trình đã thực hiện xong", , Me.Text)
    End Sub
    Private Sub btnhtkkt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtkkt.Click
        export2htkkt()
    End Sub


    Function importInvVNPT(stt_rec As String) As String
        Dim conn As Clsql.SQL = rpt.conn
        Dim url As String = Clsql.Others.Options("VNPT_URL", conn)
        Dim user As String = Clsql.Others.Options("VNPT_USER", conn)
        Dim password As String = Clsql.Others.Options("VNPT_PASSWORD", conn)

        If String.IsNullOrEmpty(url) Or String.IsNullOrEmpty(user) Or String.IsNullOrEmpty(password) Then Throw New Exception("Bạn phải khai báo thông tin kết nối tới VNPT Service trong tùy chọn hệ thống")

        Dim vatra As DataTable = conn.GetDatatable("select * from vatra where stt_rec ='" & stt_rec & "'")
        If vatra.Rows.Count = 0 Then
            Throw New Exception("Hóa đơn này không tồn tại")
        End If
        Dim invoice_string As String = "<Invoices><Inv>"
        'header
        invoice_string = invoice_string & Chr(13) & "<key>" & stt_rec & "</key>"
        invoice_string = invoice_string & Chr(13) & "<Invoice>"
        'invoice_string = invoice_string & Chr(13) & "<OrderNo></OrderNo>"
        'invoice_string = invoice_string & Chr(13) & "<OrderDate></OrderDate>"
        invoice_string = invoice_string & Chr(13) & "<CusCode>" & vatra.Rows(0).Item("ma_kh") & "</CusCode>"
        invoice_string = invoice_string & Chr(13) & "<CusName><![CDATA[" & vatra.Rows(0).Item("ten_kh") & "]]></CusName>"
        'invoice_string = invoice_string & Chr(13) & "<CusCom><![CDATA[" & vatra.Rows(0).Item("ten_kh") & "]]></CusCom>"
        invoice_string = invoice_string & Chr(13) & "<CusAddress><![CDATA[" & vatra.Rows(0).Item("dia_chi") & "]]></CusAddress>"
        invoice_string = invoice_string & Chr(13) & "<CusPhone></CusPhone>"
        invoice_string = invoice_string & Chr(13) & "<CusTaxCode>" & vatra.Rows(0).Item("ma_so_thue") & "</CusTaxCode>"
        invoice_string = invoice_string & Chr(13) & "<PaymentMethod></PaymentMethod>"
        'detail
        invoice_string = invoice_string & Chr(13) & "<Products>"
        invoice_string = invoice_string & Chr(13) & "<Product>"
        'invoice_string = invoice_string & Chr(13) & "<Code></Code>"
        invoice_string = invoice_string & Chr(13) & "<ProdName><![CDATA[" & vatra.Rows(0).Item("ten_vt") & "]]></ProdName>"
        invoice_string = invoice_string & Chr(13) & "<ProdUnit></ProdUnit>"
        invoice_string = invoice_string & Chr(13) & "<ProdQuantity></ProdQuantity>"
        invoice_string = invoice_string & Chr(13) & "<ProdPrice></ProdPrice>"
        'invoice_string = invoice_string & Chr(13) & "<Total>" & vatra.Rows(0).Item("t_tien") & "</Total >"
        'invoice_string = invoice_string & Chr(13) & "<VATRate>" & vatra.Rows(0).Item("thue_suat") & "</VATRate>"
        'invoice_string = invoice_string & Chr(13) & "<VATAmount >" & vatra.Rows(0).Item("t_thue") & "</VATAmount>"
        invoice_string = invoice_string & Chr(13) & "<Amount>" & Math.Round(vatra.Rows(0).Item("t_tien") + vatra.Rows(0).Item("t_thue"), 0) & "</Amount>"
        invoice_string = invoice_string & Chr(13) & "</Product> </Products>"
        'footer
        'Select Case vatra.Rows(0).Item("ma_thue")
        '    Case "KT"
        '        invoice_string = invoice_string & Chr(13) & "<GrossValue>" & vatra.Rows(0).Item("t_tien") & "</GrossValue>"
        '    Case "00"
        '        invoice_string = invoice_string & Chr(13) & "<VatAmount0>" & vatra.Rows(0).Item("t_thue") & "</VatAmount0>"
        '        invoice_string = invoice_string & Chr(13) & "<GrossValue0>" & vatra.Rows(0).Item("t_tien") & "</GrossValue0>"
        '    Case "05"
        '        invoice_string = invoice_string & Chr(13) & "<VatAmount5 >" & vatra.Rows(0).Item("t_thue") & "</VatAmount5>"
        '        invoice_string = invoice_string & Chr(13) & "<GrossValue5>" & vatra.Rows(0).Item("t_tien") & "</GrossValue5>"
        '    Case "10"
        '        invoice_string = invoice_string & Chr(13) & "<VatAmount10 >" & vatra.Rows(0).Item("t_thue") & "</VatAmount10>"
        '        invoice_string = invoice_string & Chr(13) & "<GrossValue10>" & vatra.Rows(0).Item("t_tien") & "</GrossValue10>"
        'End Select

        invoice_string = invoice_string & Chr(13) & "<Total>" & Math.Round(vatra.Rows(0).Item("t_tien"), 0) & "</Total>"
        invoice_string = invoice_string & Chr(13) & "<VATRate>" & Math.Round(vatra.Rows(0).Item("thue_suat"), 0) & "</VATRate>"
        invoice_string = invoice_string & Chr(13) & "<VATAmount>" & Math.Round(vatra.Rows(0).Item("t_thue"), 0) & "</VATAmount>"
        invoice_string = invoice_string & Chr(13) & "<Amount>" & Math.Round(vatra.Rows(0).Item("t_tien") + vatra.Rows(0).Item("t_thue"), 0) & "</Amount>"
        invoice_string = invoice_string & Chr(13) & "<AmountInWords><![CDATA[" & ClPrint.ByWord.Number2TextV(vatra.Rows(0).Item("t_tien") + vatra.Rows(0).Item("t_thue")) & " đồng]]></AmountInWords>"
        'invoice_string = invoice_string & Chr(13) & "<ArisingDate>" & Strings.Format(vatra.Rows(0).Item("ngay_hd"), "dd/MM/yyyy") & "</ArisingDate>"
        invoice_string = invoice_string & Chr(13) & "<EmailDeliver></EmailDeliver>"
        invoice_string = invoice_string & Chr(13) & "<SMSDeliver></SMSDeliver>"
        invoice_string = invoice_string & Chr(13) & "</Invoice>"
        invoice_string = invoice_string & Chr(13) & "</Inv>"
        invoice_string = invoice_string & Chr(13) & "</Invoices>"

        'Dim request As HttpWebRequest = DirectCast(HttpWebRequest.Create(url), HttpWebRequest)
        'Dim xmlString As String = "<?xml version=""1.0"" encoding=""utf-8""?>"
        'xmlString = xmlString & Chr(13) & "<soap:Envelope xmlns: xsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soap = ""http://schemas.xmlsoap.org/soap/envelope/"" >"
        'xmlString = xmlString & Chr(13) & "<soap:Body>"
        'xmlString = xmlString & Chr(13) & "<ImportInv xmlns=""http://tempuri.org/"">"
        'xmlString = xmlString & Chr(13) & "<xmlInvData>" & invoice_string & "</xmlInvData>"
        'xmlString = xmlString & Chr(13) & "<username>" & user & "</username>"
        'xmlString = xmlString & Chr(13) & "<password>" & password & "</password>"
        'xmlString = xmlString & Chr(13) & "<convert>0</convert>"
        'xmlString = xmlString & Chr(13) & "</ImportInv>"
        'xmlString = xmlString & Chr(13) & "</soap:Body>"
        'xmlString = xmlString & Chr(13) & "</soap:Envelope>"


        'Dim encoding As New UTF8Encoding()

        'Dim bytesToWrite As Byte() = encoding.GetBytes(xmlString)

        'request.Method = "POST"
        'request.ContentLength = bytesToWrite.Length

        'request.Headers.Add("SOAPAction: ""http://tempuri.org/ImportInv""")

        'request.ContentType = "text/xml; charset=utf-8"

        'Dim newStream As Stream = request.GetRequestStream()
        'newStream.Write(bytesToWrite, 0, bytesToWrite.Length)
        'newStream.Close()

        'Try
        '    Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
        '    Dim dataStream As Stream = response.GetResponseStream()
        '    Dim reader As New StreamReader(dataStream)

        '    Dim responseFromServer As String = reader.ReadToEnd()

        '    response.Close()
        '    response = Nothing
        '    Return responseFromServer
        'Catch ex As Net.WebException
        '    Dim er As Net.HttpWebResponse = ex.Response
        '    Dim str As New IO.StreamReader(er.GetResponseStream)
        '    Dim err_message As String = str.ReadToEnd
        '    str.Close()
        '    er.Close()

        '    rpt.conn.Server.writeError(xmlString)
        '    If err_message = "" Then
        '        err_message = ex.Message
        '    End If
        '    Throw New Exception(err_message)
        'End Try
        Dim vnpt As New vnpt.PublishService
        vnpt.Url = url
        Dim kq As String = vnpt.ImportInv(invoice_string, user, password, 0)
        If kq.Contains("ERR") Then
            rpt.conn.Server.writeError(invoice_string)
            Throw New Exception(kq)
        End If
        Return kq
    End Function
    Private Sub vnpt_Click(sender As Object, e As EventArgs)
        rpt.dv.Table.AcceptChanges()
        For Each r As DataRow In rpt.dv.Table.Select("sel=true and is_exp =false")
            Try
                If Not String.IsNullOrEmpty(r("stt_rec")) Then
                    importInvVNPT(r("stt_rec"))
                    r("is_exp") = True
                    rpt.conn.Execute("update vatra set is_exp=1 where stt_rec = '" & r("stt_rec") & "'")
                End If

            Catch ex As Exception
                MsgBox("Lỗi khi xuất hóa đơn điện tử VNPT:" & ex.Message,, Clsql.AboutMe.Name)
                Return
            End Try
        Next
        MsgBox("Chương trình đã thực hiện xong",, Clsql.AboutMe.Name)
    End Sub
End Class
