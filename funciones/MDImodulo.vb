Module MDImodulo
    Sub MDIempleado()
        Dim frmpempleado As New Empleado
        frmpempleado.MdiParent = CMprincipal
        frmpempleado.Show()
    End Sub
    Sub MDIpais()
        Dim frmpais As New Pais
        frmpais.MdiParent = CMprincipal
        frmpais.Show()
    End Sub
    Sub MDIprovincia()
        Dim frmprovincia As New Provincia
        frmprovincia.MdiParent = CMprincipal
        frmprovincia.Show()
    End Sub
    Sub MDImunicipio()
        Dim frmmunicipio As New Municipio
        frmmunicipio.MdiParent = CMprincipal
        frmmunicipio.Show()
    End Sub
    Sub MDIsector()
        Dim frmsector As New Sector
        frmsector.MdiParent = CMprincipal
        frmsector.Show()
    End Sub
    Sub MDIfactura()
        Dim frmfactura As New frmFactura
        frmfactura.MdiParent = CMprincipal
        frmfactura.Show()
    End Sub
    Sub MDILcliente()
        Dim frmcliente As New Lclientes
        frmcliente.MdiParent = CMprincipal
        frmcliente.Show()
    End Sub

    Sub MDIusuario()
        Dim frmusuario As New Usuario
        frmusuario.MdiParent = CMprincipal
        frmusuario.Show()
    End Sub
    Sub MDIproveedor()
        Dim frmproveedor As New proveedor
        frmproveedor.MdiParent = CMprincipal
        frmproveedor.Show()
    End Sub
    Sub MDItipotelefono()
        Dim frmtipotelefono As New TipoTelefono
        frmtipotelefono.MdiParent = CMprincipal
        frmtipotelefono.Show()
    End Sub
    Sub MDIempresa()
        Dim frmempresa As New Empresa
        frmempresa.MdiParent = CMprincipal
        frmempresa.Show()
    End Sub
    Sub MDIproducto()
        Dim frmproducto As New Producto
        frmproducto.MdiParent = CMprincipal
        frmproducto.Show()
    End Sub

End Module
