Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Cliente
    Dim Nombre, Apellido, Cedula, Telefono, Calle, Casa, Usuario, Clave As String
    Dim Pais, Provinvia, IdDireccion, IdTelefono, Tpersona0, Tpersona01, Tpersona02 As Integer
    Dim Municipio, Sector, TipoTelefono As Integer

    Dim varCliente As String = "frmCliente"
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaPais()
        ListaProvincia()
        ListaMunicipio()
        ListaSector()
        ListaTipoTelefono()
    End Sub
    Public Sub ListaTipoTelefono()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from tipotelefono", Conex)
            DA.Fill(DT)
            cboTipoTelefono.DataSource = DT
            cboTipoTelefono.DisplayMember = "nombre"
            cboTipoTelefono.ValueMember = "idtipotelefono"
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ListaPais()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            da = New MySqlDataAdapter("select * from pais", Conex)
            da.Fill(dt)
            cbpais.DataSource = dt
            cbpais.DisplayMember = "nombre"
            cbpais.ValueMember = "idpais"
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ListaProvincia() ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            da = New MySqlDataAdapter("select * from provincia", Conex)
            da.Fill(dt)
            cbprovincia.DataSource = dt
            cbprovincia.DisplayMember = "nombre"
            cbprovincia.ValueMember = "idprovincia"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ListaMunicipio() ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            da = New MySqlDataAdapter("select * from municipio", Conex)
            da.Fill(dt)
            cbmunicipio.DataSource = dt
            cbmunicipio.DisplayMember = "nombre"
            cbmunicipio.ValueMember = "idmunicipio"
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ListaSector() ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            da = New MySqlDataAdapter("select * from sector", Conex)
            da.Fill(dt)
            cbsector.DataSource = dt
            cbsector.DisplayMember = "nombre"
            cbsector.ValueMember = "idsector"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MDIsector()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MDImunicipio()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MDIprovincia()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MDIpais()
    End Sub

    Public Sub RecogerVariables()
        Nombre = txtnombreCli.Text
        Apellido = txtapellidoCli.Text
        Cedula = txtcedulaCli.Text
        Telefono = txttelefono1.Text
        Calle = txtcalle.Text
        Casa = txtcasa.Text
        Pais = cbpais.SelectedValue
        Provinvia = cbprovincia.SelectedValue
        Municipio = cbmunicipio.SelectedValue
        Sector = cbsector.SelectedValue
        TipoTelefono = cboTipoTelefono.SelectedValue
        IdDireccion = ultimoIdD()
        IdTelefono = ultimoIdT()

        Try
            InsertDireccion(Pais, Provinvia, Municipio, Sector, Calle, Casa)
            InsertTelefono(Telefono, TipoTelefono)
            ' InsertPersona(Nombre, Apellido, Cedula, IdDireccion, IdTelefono)

            'MsgBox("Los Tipos de personas " & Tpersona0, Tpersona01, Tpersona02)
            MsgBox("Datos almacenados con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Los campos estan vacios")
            'MsgBox(Nombre + Apellido)
        End Try
    End Sub

    Private Sub btnguardarCli_Click(sender As Object, e As EventArgs) Handles btnguardarCli.Click
        'Conectar()
        RecogerVariables()
    End Sub
End Class