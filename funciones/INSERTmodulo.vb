Imports MySql.Data.MySqlClient
Imports MySql.Data

Module INSERTmodulo
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    Sub insertUsuario(ByVal Usuario, ByVal Clave)
        Try
            sql = "insert into usuario(usuario,clave,idtipousuario,idpermiso)value('" & Usuario & "', '" & Clave & "','1','1')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Sub InsertSector(ByVal V1, ByVal V2, ByVal V3)
        Try
            sql = "insert into sector(nombre,comentario,idmunicipio)value('" & V1 & "','" & V2 & "','" & V3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    Sub InsertPais(ByVal V1, ByVal V2)
        Try
            sql = "insert into pais(nombre,comentario)value('" & V1 & "', '" & V2 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    Sub InsertProvincia(ByVal V1, ByVal V2, ByVal V3)
        Try
            sql = "insert into provincia(nombre,comentario,idpais)value('" & V1 & "', '" & V2 & "','" & v3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub
End Module
