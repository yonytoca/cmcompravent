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
            MsgBox("Usuario Guardado Con exito")
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
    Sub insertSector(ByVal V1, ByVal V2)
        Try
            sql = "insert into sector(nombre,idmunicipio)value('" & V1 & "','" & V2 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    'pais 
    Sub InsertPais(ByVal V1)
        Try
            sql = "insert into pais(nombre)value('" & V1 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception

        End Try
    End Sub
    'provincia 
    Sub InsertProvincia(ByVal V1, ByVal V2)
        Try
            sql = "insert into provincia(nombre,idpais)value('" & V1 & "', '" & V2 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception

        End Try
    End Sub
    'municipio
    Sub Insertmunicipio(ByVal V1, ByVal V2)
        Try
            sql = "insert into municipio(nombre,idprovincia)value('" & V1 & "', '" & V2 & "')"
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
    Sub InsertPersona(ByVal V1, ByVal V2, ByVal V3, ByVal V4, ByVal V5, ByVal V6, ByVal V7, ByVal V8)
        Try
            sql = "insert into persona(nombre,apellido,cedula,iddireccion, idtelefono,cliente,empleado,proveedor)value('" & V1 & "', '" & V2 & "','" & V3 & "','" & V4 & "','" & V5 & "','" & V6 & "','" & V7 & "','" & V8 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            '  MsgBox("Datos Almacenados Con exito")
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
    'creacion de empresa
    Sub InsertEmpresa(ByVal V1, ByVal V2, ByVal V3, ByVal V4, ByVal V5, ByRef V6)
        Try
            sql = "insert into empresa(nombre,descripcion,eslogan,fechacreacion,iddireccion,telefono)value('" & V1 & "', '" & V2 & "', '" & V3 & "', '" & V4 & "', '" & V5 & "', '" & V6 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            ' MsgBox("V1, V2, V3, V4 V5, V6")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Sub InsertProducto(ByVal V1, ByVal V2)
        Try
            sql = "insert into producto(nombre,descripcion)value('" & V1 & "', '" & V2 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("Almacenamiento Exitoso")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    'Factura detalle
    Sub inserFacturaDetalle(ByVal V1, ByVal V2, ByVal V3, ByVal V4, ByVal V5, ByVal V6)
        Try
            sql = "insert into facturadetalle(cantidad,precio,idproducto,idfactura,descuento,total)value('" & V1 & "', '" & V2 & "', '" & V3 & "', '" & V4 & "', '" & V5 & "', '" & V6 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            'MsgBox("Usuario Guardado Con exito")

        Catch ex As Exception
            ' MsgBox("Proporcione una cantidad o precio")
        End Try
    End Sub
    'Factura
    Sub inserFactura(ByVal V1, ByVal V2, ByVal V3, ByVal V4)
        Try
            sql = "insert into factura(fecha,idpersonaC,idusuario,hora)value('" & V1 & "', '" & V2 & "', '" & V3 & "', '" & V4 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)

            'MsgBox("Usuario Guardado Con exito")
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    'insert inventario 
    Sub inserInventario(ByVal V1, ByVal V2, ByVal V3, ByVal V4)
        Try
            sql = "insert into inventario(precio_compra,precio_venta,idproducto,nota)value('" & V1 & "', '" & V2 & "', '" & V3 & "', '" & V4 & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            'MsgBox("Usuario Guardado Con exito")
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Module

