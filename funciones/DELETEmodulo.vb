Imports MySql.Data.MySqlClient
Imports MySql.Data


Module DELETEmodulo
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Sub DELETEfactura(ByVal IDdetalle)
        Try
            MsgBox(IDdetalle)
            sql = "delete from facturadetalle where idfacturadetalle =" & IDdetalle
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("Registro eliminado")
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Module