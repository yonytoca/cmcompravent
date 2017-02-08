Imports MySql.Data.MySqlClient
Imports MySql.Data

Module SELECTmodulo
    Dim resultado As Integer = 0
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Public dv As New DataView
    Public dv1 As New DataView
    Public dv2 As New DataView
    Public dv3 As New DataView
    Public dv4 As New DataView
    Public dv5 As New DataView

    'recoger id de direccion
    Public Function ultimoIdD() As Integer
        Dim query As String = "SELECT MAX(iddireccion)FROM direccion"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado + 1
    End Function

    'recoger id de telefono
    Public Function ultimoIdT() As Integer
        Dim query As String = "SELECT MAX(idtelefono)FROM telefono"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado + 1
    End Function

    ' ultimo id de la factura 
    Public Function ultimoIdF() As Integer
        Dim query As String = "SELECT MAX(idfactura)FROM factura"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()

        Return resultado + 1
    End Function

    ' End If
    'ultimo id de los producto
    Public Function ultimoIdP() As Integer
        Dim query As String = "SELECT MAX(idproducto)FROM producto"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado + 1
    End Function

    'comprobar usuario login 
    Public Function login1(ByVal V1)
        Dim query As String = "SELECT idusuario FROM usuario where usuario='" & V1 & "'"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado
    End Function

    'lista de personas 
    Public Sub mostrarlosdatos(Dato As DataGridView)
        Try
            Dim DS As New DataSet
            Dim query As String
            query = "SELECT *  FROM persona AS pe, direccion AS d, pais AS pa, provincia AS pr, municipio AS m, sector AS s, telefono AS t, tipotelefono AS ti
                                        WHERE pe.iddireccion = d.iddireccion
                                        AND d.idpais = pa.idpais
                                        AND d.idprovincia = pr.idprovincia
                                        AND d.idmunicipio = m.idmunicipio
                                        AND d.idsector = s.idsector
                                        AND pe.idtelefono = t.idtelefono
                                        AND t.idtipotelefono = ti.idtipotelefono"
            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "persona,pais,provincia,municipio,sector,telefono,tipotelefono")
            Dato.DataSource = DS
            Dato.DataMember = "persona,pais,provincia,municipio,sector,telefono,tipotelefono"
            dv.Table = DS.Tables(0)
            Dato.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Buscar cliente en factura
    Public Sub BuscarClienteCodigo(Dato As DataGridView, Id As Integer)
        Try
            Dim DS As New DataSet
            Dim query As String
            query = "SELECT *  FROM persona AS pe, direccion AS d, pais AS pa, provincia AS pr, municipio AS m, sector AS s,telefono AS t,telefono AS ti
                                        WHERE pe.iddireccion = d.iddireccion
                                        AND d.idpais = pa.idpais
                                        AND d.idprovincia = pr.idprovincia
                                        AND d.idmunicipio = m.idmunicipio
                                        AND d.idsector = s.idsector
                                        AND pe.idtelefono=t.idtelefono
                                        AND t.idtipotelefono=ti.idtipotelefono
                                        AND pe.idpersona=" & Id
            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "persona,pais,provincia,municipio,sector,telefono,tipotelefono")
            Dato.DataSource = DS
            Dato.DataMember = "persona,pais,provincia,municipio,sector,telefono,tipotelefono"
            dv3.Table = DS.Tables(0)
            Dato.DataSource = dv3
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try

    End Sub

    'Mostrar cliente con relacion a las facturas abiertas
    Public Sub BuscarClienteFabierta(Dato As DataGridView, Id As Integer)
        Try
            Dim DS As New DataSet
            Dim query As String
            query = "SELECT *  FROM persona AS pe, direccion AS d, pais AS pa, provincia AS pr, municipio AS m, sector AS s,telefono AS t,telefono AS ti, facturadetalle AS f
                                        WHERE pe.iddireccion = d.iddireccion
                                        AND d.idpais = pa.idpais
                                        AND d.idprovincia = pr.idprovincia
                                        AND d.idmunicipio = m.idmunicipio
                                        AND d.idsector = s.idsector
                                        AND pe.idtelefono=t.idtelefono
                                        AND t.idtipotelefono=ti.idtipotelefono
                                        AND f.idfactura=" & Id
            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "persona,pais,provincia,municipio,sector,telefono,tipotelefono")
            Dato.DataSource = DS
            Dato.DataMember = "persona,pais,provincia,municipio,sector,telefono,tipotelefono"
            dv3.Table = DS.Tables(0)
            Dato.DataSource = dv3
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try

    End Sub

    'Buscar producto en factura por nombre
    Public Sub BuscarProducto(Dato As DataGridView)
        Try
            Dim DS As New DataSet
            Dim query As String = "select producto.idproducto,producto.nombre, inventario.precio_venta 
                                        from producto,inventario where producto.idproducto=inventario.idproducto"

            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "producto, inventario")
            Dato.DataSource = DS
            Dato.DataMember = "producto, inventario"
            dv1.Table = DS.Tables(0)
            Dato.DataSource = dv1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'buscar producto en factura por id
    Public Sub BuscarProductoId(Dato As DataGridView, IdProducto As Integer)
        Try
            Dim DS As New DataSet
            Dim query As String = "select producto.idproducto,producto.nombre, inventario.precio_venta 
                                        from producto,inventario where producto.idproducto=inventario.idproducto and producto.idproducto=" & IdProducto

            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "producto, inventario")
            Dato.DataSource = DS
            Dato.DataMember = "producto, inventario"
            dv5.Table = DS.Tables(0)
            Dato.DataSource = dv5
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Factura detalle
    Public Sub FacturaDetalle(Dato As DataGridView, IDfactura As Integer)
        Try
            Dim DS As New DataSet
            Dim query As String = "select facturadetalle.idfacturadetalle,
                                          facturadetalle.idproducto, 
                                          producto.nombre,
                                          facturadetalle.cantidad,
                                          facturadetalle.precio,
                                          facturadetalle.total          
                                      from facturadetalle, producto where                                           
                                          producto.idproducto=facturadetalle.idproducto
                                      and    
                                          facturadetalle.idfactura=" & IDfactura
            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "facturadetalle, producto")
            Dato.DataSource = DS
            Dato.DataMember = "facturadetalle, producto"
            dv2.Table = DS.Tables(0)
            Dato.DataSource = dv2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'buscar producto en frm producto
    Public Sub BuscarProductoFrmP(Dato As DataGridView)
        Try
            Dim DS As New DataSet
            Dim query As String = "select 
                                        producto.idproducto,
                                        producto.nombre,
                                        producto.descripcion, 
                                        inventario.precio_venta, 
                                        inventario.precio_compra,
                                        inventario.nota
                                      from 
                                        producto,inventario 
                                      where 
                                        producto.idproducto=inventario.idproducto"

            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "producto, inventario")
            Dato.DataSource = DS
            Dato.DataMember = "producto, inventario"
            dv4.Table = DS.Tables(0)
            Dato.DataSource = dv4
        Catch ex As Exception
            MsgBox(ex.Message, "Error 45")
        End Try
    End Sub
    'select datos de la empresa 
    Public Sub DatosEmpresa(Dato As DataGridView)
        Try
            Dim DS As New DataSet
            Dim query As String = "SELECT * 
                                     FROM empresa AS e, direccion AS d, pais AS pa, provincia AS pr, municipio AS m, sector AS s
                                        WHERE e.iddireccion = d.iddireccion
                                        AND d.idpais = pa.idpais
                                        AND d.idprovincia = pr.idprovincia
                                        AND d.idmunicipio = m.idmunicipio
                                        AND d.idsector = s.idsector"

            Dim DA As New MySqlDataAdapter(query, Conex)
            DA.Fill(DS, "empresa,direccion,pais,provincia,municipio,sector")
            Dato.DataSource = DS
            Dato.DataMember = "empresa,direccion,pais,provincia,municipio,sector"
            dv4.Table = DS.Tables(0)
            Dato.DataSource = dv4
        Catch ex As Exception
            MsgBox(ex.Message,)
        End Try
    End Sub
    Public Function fTotalAp(ByVal V1)
        Dim query As String = "SELECT sum(total)FROM facturadetalle where idfactura=" & V1
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        Return lector
    End Function
End Module
