Module Main
    Public conn As Clsql.SQL
    Public list_lh As ClsList.CompactList
    Public list_hd As ClsList.CompactList
    Public list_gd As ClsList.CompactList
    Public list_dmgiakh As ClsList.CompactList
    Public dv As DataView
    Public listid As String = Clsql.Others.GetArgu(1)
    Public list As ClsList.List2
End Module
