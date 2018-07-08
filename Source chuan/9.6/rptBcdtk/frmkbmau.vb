Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class frmkbmau
    Dim listid As String
    Dim WithEvents list As ClsList.List4R
    Dim frmin As New frminput
    Dim conn As Clsql.SQL
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = rpt.cPrint.drvForm("tbform")
        list = New ClsList.List4R(rpt.conn, listid, grd, frmin, , "1=0")
        list.CSearch = "form ='" & rpt.cPrint.drvForm("idform") & "'"
        list.LoadData("1=1")
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)

        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        Me.ContextMenuStrip = list.Contextmenu
        setuplookup()
        conn = list.conn
        ClsControl2.PropertyOfForm.SetLable(oLable, frmin)
        PropertyOfForm.SetLable(oLable, Me)
        frmin.Icon = Me.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        lblcty.Text = Clsql.Others.Options("cty_name", conn)
        PropertyOfForm.SetImage4Control("user.bmp", user)
        'set gia tri mac dinh
        Dim defaultvalue As New Collection
        ' defaultvalue.Add(1, "ts_nv")
        ' defaultvalue.Add(1, "mcal")
        defaultvalue.Add(1, "in_ck")
        defaultvalue.Add(rpt.cPrint.drvForm("idform"), "form")
        list.ValueDefaults = defaultvalue
    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub

    Sub setuplookup()

        If Reg.GetValue("language") = "Vi" Then
            AddItems.AddItemCbb(rpt.conn, "select text,inds from dmitemofcbb where form='" & listid & "' and name ='ts_nv'", frmin.cbbts_nv, "text", "inds")
            AddItems.AddItemCbb(rpt.conn, "select text,inds from dmitemofcbb where form='" & listid & "' and name ='mcal'", frmin.cbbmcal, "text", "inds")

        Else
            AddItems.AddItemCbb(rpt.conn, "select text2,inds from dmitemofcbb where form='" & listid & "' and name ='ts_nv'", frmin.cbbts_nv, "text2", "inds")
            AddItems.AddItemCbb(rpt.conn, "select text2,inds from dmitemofcbb where form='" & listid & "' and name ='mcal'", frmin.cbbmcal, "text2", "inds")

        End If
    End Sub

    Private Sub list_BeforeDeleteItem(ByVal e As System.Data.DataRow) Handles list.BeforeDeleteItem
        'If Clsql.Others.oInStr(e("ma_so"), "270,440") Then
        '    MsgBox(oLable("039"), , Me.Text)
        '    list.DeleteYN = False
        '    Return
        'End If
    End Sub

    Private Sub list_SaveClick() Handles list.SaveClick
        If frmin.txtcach_tinh.Text.Trim <> "" Then
            list.ContinueSave = ClsRpt.Check.CheckFormula(frmin.txtcach_tinh.Text, list.datatable, "ma_so")
        End If
    End Sub
End Class