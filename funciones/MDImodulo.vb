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

End Module
