Imports ClsLookup

Module Genaral
    Public Voucherid As String = Clsql.Others.GetArgu(1)
    Public Voucher As ClsSV.Voucher20
    Public conn As Clsql.SQL
    Public f_tien As String
    Public f_tien_nt As String
    Public f_so_luong As String
    Public oPrint As ClsSV.Print20
    Public formtask As New ClsSV.frmTask
    Public fPrintDialog As New frmPrint
    'Public Sub post(ByVal stt_rec As String, ByVal status As Integer)
    '    Dim query As String
    '    query = "Delete socai where stt_rec = '" & stt_rec & "'"
    '    query = query & Chr(13) & "Delete vatra where stt_rec = '" & stt_rec & "'"
    '    query = query & Chr(13) & "Delete tdttno where right(stt_rec,9) = '" & stt_rec.Substring(4) & "' and ma_ct ='" & Voucherid & "'"

    '    Voucher.conn.Execute(query)
    '    Select Case status
    '        Case 4
    '            'query = "Update " & Voucher.tenbangchung & " set status = 4 where stt_rec = '" & stt_rec & "'"
    '            'Voucher.conn.Execute(query)

    '            ' Dim PostSK As String = "Exec PostSKPNK '#stt_rec#'" & ",'" & Voucherid & "','" & Voucher.tenbangchung & "','" & Voucher.tenbangchitiet & "'"
    '            ' ClsVno.Others.DeleteCH(Voucher.conn, stt_rec, Voucherid, "sokho")
    '            ' ClsVno.Others.DeleteCH(Voucher.conn, stt_rec, Voucherid, "socai")

    '            '  ClsVno.Others.PostCH(Voucher.conn, 4, stt_rec, Voucherid, PostSK.Replace("#stt_rec#", stt_rec), "sokho")
    '        Case 5
    '            ' query = "Update " & Voucher.tenbangchung & " set status = 5 where stt_rec = '" & stt_rec & "'"

    '            ' Voucher.conn.Execute(query)

    '            'Dim PostSK As String = "Exec PostSKPNK '#stt_rec#'" & ",'" & Voucherid & "','" & Voucher.tenbangchung & "','" & Voucher.tenbangchitiet & "'"
    '            Dim PostSC As String = "Exec PostGLHD1 '#stt_rec#'"
    '            Dim PostVATra As String = "Exec PostVATra '#stt_rec#'" & ",'" & Voucherid & "','" & Voucher.tenbangchung & "','" & Voucher.tenbangchitiet & "'"
    '            Dim PostTDTTNO As String = "Exec PostTDTTNOHD1 '#stt_rec#','" & Voucherid & "'"

    '            'ClsVno.Others.DeleteCH(Voucher.conn, stt_rec, Voucherid, "sokho")
    '            ' ClsVno.Others.DeleteCH(Voucher.conn, stt_rec, Voucherid, "socai")
    '            'ClsVno.Others.PostCH(Voucher.conn, 5, stt_rec, Voucherid, PostSK.Replace("#stt_rec#", stt_rec), "sokho")
    '            ClsVno.Others.PostCH(conn, 5, stt_rec, Voucherid, PostVATra.Replace("#stt_rec#", stt_rec), "vatra")
    '            ClsVno.Others.PostCH(Voucher.conn, 5, stt_rec, Voucherid, PostSC.Replace("#stt_rec#", stt_rec), "socai")
    '            ClsVno.Others.PostCH(Voucher.conn, 5, stt_rec, Voucherid, PostTDTTNO.Replace("#stt_rec#", stt_rec), "tdttno")

    '        Case Else

    '    End Select
    'End Sub
  
End Module
