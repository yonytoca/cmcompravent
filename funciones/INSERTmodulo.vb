Imports MySql.Data.MySqlClient
Imports MySql.Data
'usuario 'Tipopersona 'sector 'pais 'provincia 'municipio 'direccion 'persona 'telefono 'tipo telefono
Module INSERTmodulo
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    'usuario
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
    'Tipo de persona 
    Sub insertTipoPersona(ByVal V1, ByVal V2, ByVal V3, ByVal V4)
        Try
            sql = "insert into tipopersona(idcliente,idempleado,idproveedor,idpersona)value('" & V1 & "', '" & V2 & "','" & V3 & "','" & V4 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    'sector 
    Sub insertSector(ByVal V1, ByVal V2, ByVal V3)
        Try
            sql = "insert into sector(nombre,comentario,idmunicipio)value('" & V1 & "','" & V2 & "','" & V3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    'pais 
    Sub InsertPais(ByVal V1, ByVal V2)
        Try
            sql = "insert into pais(nombre,comentario)value('" & V1 & "', '" & V2 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    'provincia 
    Sub InsertProvincia(ByVal V1, ByVal V2, ByVal V3)
        Try
            sql = "insert into provincia(nombre,comentario,idpais)value('" & V1 & "', '" & V2 & "','" & V3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub
    'municipio
    Sub Insertmunicipio(ByVal V1, ByVal V2, ByVal V3)
        Try
            sql = "insert into municipio(nombre,comentario,idprovincia)value('" & V1 & "', '" & V2 & "','" & V3 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub

    'direccion 
    Sub InsertDireccion(ByVal V1, ByVal V2, ByVal V3, ByVal v4, ByVal v5, ByVal v6)
        Try
            sql = "insert into direccion(idpais,idprovincia,idmunicipio,idsector,calle,casa_numero)value('" & V1 & "', '" & V2 & "','" & V3 & "','" & v4 & "', '" & v5 & "','" & v6 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub
    'persona 
    Sub InsertPersona(ByVal V1, ByVal V2, ByVal V3, ByVal V4, ByVal V5)
        Try
            sql = "insert into persona(nombre,apellido,cedula,iddireccion, idtelefono)value('" & V1 & "', '" & V2 & "','" & V3 & "','" & V4 & "','" & V5 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("Datos Almacenados Con exito")
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    'telefono
    Sub InsertTelefono(ByVal V1, ByVal V2)
        Try
            sql = "insert into telefono(numero,idtipotelefono)value('" & V1 & "', '" & V2 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    'tipo telefono
    Sub InsertTipotelefono(ByVal V1)
        Try
            sql = "insert into tipotelefono(nombre)value('" & V1 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub

End Module

