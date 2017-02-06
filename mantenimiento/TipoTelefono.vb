Public Class TipoTelefono
    Dim nombre As String
    Public Sub Guardar()
        nombre = txtTipoTelefono.Text
        InsertTipotelefono(nombre)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guardar()
    End Sub
End Class