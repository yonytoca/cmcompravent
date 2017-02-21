Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data.OleDb

Public Class Empleado
    Dim Nombre, Apellido, Cedula, Telefono, Calle, Casa, Usuario, Clave As String
    Dim Pais, Provinvia, IdDireccion, IdTelefono, Tpersona0, Tpersona01, Tpersona02 As Integer
    Dim Municipio, Sector, TipoTelefono As Integer


    Dim da As MySqlDataAdapter

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Dim dt As DataTable
    Dim sql As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Dim comando As MySqlCommand

    Public Sub Variables()
        Nombre = txtnombreEm.Text
        Apellido = txtapellidoEm.Text
        Cedula = txtcedulaEm.Text
        Telefono = txttelefonoEm.Text
        Calle = txtcalleEm.Text
        Casa = txtcasaEm.Text

        Pais = cbpais.SelectedValue
        Provinvia = cbprovincia.SelectedValue
        Municipio = cbmunicipio.SelectedValue
        Sector = cbsector.SelectedValue
        TipoTelefono = cbTipoTelefono.SelectedValue
        IdDireccion = ultimoIdD()
        IdTelefono = ultimoIdT()
    End Sub

    Public Sub Guardar()
        Variables()
        Try
            InsertDireccion(Pais, Provinvia, Municipio, Sector, Calle, Casa)
            InsertTelefono(Telefono, TipoTelefono)

            InsertPersona(Nombre, Apellido, Cedula, IdDireccion, IdTelefono, Tpersona0, Tpersona01, Tpersona02)

            MsgBox("Datos almacenados con exito")
            Me.Close()
            MDIempleado()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Los campos estan vacios")

        End Try

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

    Public Sub ListaProvincia(ByVal Id) ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from provincia where idpais=" & Id, Conex)
            DA.Fill(DT)
            cbprovincia.DataSource = DT
            cbprovincia.DisplayMember = "nombre"
            cbprovincia.ValueMember = "idprovincia"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ListaMunicipio(ByVal Id) ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from municipio where idprovincia=" & Id, Conex)
            DA.Fill(DT)
            cbmunicipio.DataSource = DT
            cbmunicipio.DisplayMember = "nombre"
            cbmunicipio.ValueMember = "idmunicipio"
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ListaSector(ByVal Id) ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from sector where idmunicipio=" & Id, Conex)
            DA.Fill(DT)
            cbsector.DataSource = DT
            cbsector.DisplayMember = "nombre"
            cbsector.ValueMember = "idsector"
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ListaTipoTelefono() ' llenar lista de provincia 
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from tipotelefono", Conex)
            DA.Fill(DT)
            cbTipoTelefono.DataSource = DT
            cbTipoTelefono.DisplayMember = "nombre"
            cbTipoTelefono.ValueMember = "idtipotelefono"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Conectar()
        ListaPais()
        ListaProvincia(cbpais.ValueMember)
        ListaMunicipio(cbprovincia.ValueMember)
        ListaSector(cbmunicipio.ValueMember)
        ListaTipoTelefono()
        mostrarlosdatos(Dgpersona)
    End Sub

    Private Sub btnGuardarEm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEm.Click
        Guardar()
        ' LimpiarVariables(Me)
        'Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MDIpais()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MDIprovincia()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MDImunicipio()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MDIsector()
        Me.Hide()
    End Sub

    Private Sub Dgpersona_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgpersona.CellClick
        Try
            txtnombreEm.Text = Dgpersona.CurrentRow.Cells.Item(1).Value
            txtapellidoEm.Text = Dgpersona.CurrentRow.Cells.Item(2).Value

        Catch ex As Exception

        End Try

    End Sub
End Class