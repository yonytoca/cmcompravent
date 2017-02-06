Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Provincia
    Dim Nombre, Nota As String
    Dim Pais As Integer
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Public Sub ListaPais()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from pais", Conex)
            DA.Fill(DT)
            cbpais.DataSource = DT
            cbpais.DisplayMember = "nombre"
            cbpais.ValueMember = "idpais"
        Catch ex As Exception

        End Try

    End Sub
    Public Sub Guardar()
        Nombre = txtnombrePro.Text
        Pais = cbpais.SelectedValue

        InsertProvincia(Nombre, Pais)

    End Sub


    Private Sub Provincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListaPais()
    End Sub

    Private Sub btnguardarPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarPro.Click
        Guardar()
        MDImunicipio()
        Me.Hide()
    End Sub
End Class