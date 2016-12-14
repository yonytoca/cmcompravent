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
    Sub insertSector(ByVal V1, ByVal V2, ByVal V3)
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
            sql = "insert into provincia(nombre,comentario,idpais)value('" & V1 & "', '" & V2 & "','" & V3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub

    Sub Insertmunicipio(ByVal V1, ByVal V2, ByVal V3)
        Try
            sql = "insert into municipio(nombre,comentario,idprovincia)value('" & V1 & "', '" & V2 & "','" & V3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub

    Sub InsertPersona(ByVal V1, ByVal V2, ByVal V3, ByVal V4, ByVal V5, ByVal V6)
        Try
            sql = "insert into persona(nombre,apellido,cedula,iddireccion,idtelefono,idtipopersona)value('" & V1 & "', '" & V2 & "','" & V3 & "','" & V4 & "','" & V5 & "','" & V6 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("Datos Almacenados Con exito")
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
End Module

