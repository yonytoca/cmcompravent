Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Empresa
    Dim Nombre, Descripcion, Slogan, Calle, Casa, Telefono As String
    Dim Fecha As Date
    Dim Direccion, TelefonoID, Pais, Provincia, Municipio, Sector As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guardar()
    End Sub

    Public Sub Guardar()
        Nombre = txtnombre.Text
        Descripcion = txtdescripcion.Text
        Slogan = txtslogan.Text
        Fecha = Date.Now
        Pais = cbpais.SelectedValue
        Provincia = cbprovincia.SelectedValue
        Municipio = cbmunicipio.SelectedValue
        Sector = cbsector.SelectedValue
        Calle = txtcalleEm.Text
        Casa = txtcasaEm.Text
        Telefono = txttelefono.Text

        Direccion = ultimoIdD()

        InsertDireccion(Pais, Provincia, Municipio, Sector, Calle, Casa)
        InsertEmpresa(Nombre, Descripcion, Slogan, Fecha, Direccion, Telefono)

    End Sub
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

    Public Sub ListaProvincia() ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from provincia", Conex)
            DA.Fill(DT)
            cbprovincia.DataSource = DT
            cbprovincia.DisplayMember = "nombre"
            cbprovincia.ValueMember = "idprovincia"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ListaMunicipio() ' llenar lista de provincia 
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
    Public Sub ListaSector() ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from sector", Conex)
            DA.Fill(DT)
            cbsector.DataSource = DT
            cbsector.DisplayMember = "nombre"
            cbsector.ValueMember = "idsector"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaPais()
        ListaProvincia()
        ListaMunicipio()
        ListaSector()
    End Sub
End Class