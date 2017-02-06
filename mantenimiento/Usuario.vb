Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Usuario
    Dim Nombre, Clave As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guardar()
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Guardar()
        Nombre = txtusuario.Text
        Clave = txtclave.Text
        insertUsuario(Nombre, Clave)
        txtusuario.Clear()
        txtclave.Clear()
    End Sub
End Class