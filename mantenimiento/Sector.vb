Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Sector
    Dim Nombre, Nota As String
    Dim Municipio As Integer
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    
    Public Sub ListaMunicipio()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from municipio", Conex)
            DA.Fill(DT)
            cbmunicipio.DataSource = DT
            cbmunicipio.DisplayMember = "nombre"
            cbmunicipio.ValueMember = "idmunicipio"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnguardarPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarPro.Click
        Nombre = txtsector.Text
        Nota = txtnota.Text
        Municipio = Val(cbmunicipio.Text).ToString
        InsertSector(Nombre, Nota, Municipio)
        MDIempleado()
        Me.Hide()
    End Sub

    Private Sub Sector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListaMunicipio()
    End Sub
End Class