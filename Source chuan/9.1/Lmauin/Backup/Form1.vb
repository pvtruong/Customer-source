Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim conn As Clsql.SQL
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = Clsql.Others.GetArgu(1)
        Try
            list = New ClsList.List1(listid, grd, frmin, , "1=0")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        'disable or enable cac  tinh nang
        '  list.moi.Visible = False
        ' list.xoa.Visible = False
        'them menu
        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        '
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        Me.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        lblcty.Text = Clsql.Others.Options("cty_name", conn)
        PropertyOfForm.SetImage4Control("user.bmp", user)
        list.LoadData("mau_so<>''")
        frmin.txtso_lien.Minimum = 1
        frmin.txtso_lien.Maximum = 9
        Dim lookup As New Threading.Thread(AddressOf setuplookup)
        lookup.Start()
        ''set default value
        'Dim df As New Collection
        'df.Add(conn.GetValue("select nam_bd from dmstt"), "nam")
        'list.ValueDefaults = df
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub

    Private Sub list_AfterAddItem(ByVal row As System.Data.DataRow) Handles list.AfterAddItem, list.AfterEditItem
        If IO.File.Exists(Application.StartupPath & "\sysdata\rpts\" & row("code") & ".xml") Then
            IO.File.Delete(Application.StartupPath & "\sysdata\rpts\" & row("code") & ".xml")
        End If
        Dim dtgridinfo As DataTable = conn.GetDatatable("select * from rpts where code ='" & row("code") & "'")
        dtgridinfo.WriteXml(Application.StartupPath & "\sysdata\rpts\" & row("code") & ".xml", XmlWriteMode.WriteSchema)
        dtgridinfo.Dispose()
        'luu logo
        If IO.File.Exists(Application.StartupPath & "\sysdata\rpts\" & row("code") & row("stt") & ".xml") Then
            IO.File.Delete(Application.StartupPath & "\sysdata\rpts\" & row("code") & row("stt") & ".xml")
        End If
        dtgridinfo = conn.GetDatatable("select * from rpts where code ='" & row("code") & "' and stt ='" & row("stt") & "'")
        dtgridinfo.TableName = row("code") & row("stt")
        dtgridinfo.WriteXml(Application.StartupPath & "\sysdata\rpts\" & row("code") & row("stt") & ".xml", XmlWriteMode.WriteSchema)
        dtgridinfo.Dispose()
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

    End Sub
    Sub setuplookup()

    End Sub
End Class
