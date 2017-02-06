Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Pais
    Dim Nombre, Nota As String
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Public Sub GuardarPais()
        Nombre = txtnombreP.Text
        InsertPais(Nombre)

    End Sub

    Private Sub Pais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnguardarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarP.Click
        GuardarPais()
        MDIprovincia()
        Me.Hide()
    End Sub
End Class