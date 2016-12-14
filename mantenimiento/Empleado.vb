Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data.OleDb

Public Class Empleado
    Dim Nombre, Apellido, Cedula, Telefono, Calle, Casa, Usuario, Clave As String
    Dim Pais, Provinvia, Municipio, Sector As Integer
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Public Sub RecogerVariables()
        Nombre = txtnombreEm.Text
        Apellido = txtapellidoEm.Text
        Cedula = txtcedulaEm.Text
        Telefono = txttelefonoEm.Text
        Calle = txtcalleEm.Text
        Casa = txtcasaEm.Text
        Usuario = txtusuarioEm.Text
        Clave = txtclaveEm.Text
        Pais = Val(cbpais.Text).ToString
        Provinvia = Val(cbprovincia.Text).ToString
        Municipio = Val(cbmunicipio.Text).ToString
        Sector = Val(cbsector.Text).ToString

        Try
<<<<<<< HEAD
            sql = "insert into usuario(usuario,clave,idtipousuario,idpermiso)value('" & Usuario & "', '" & Clave & "','1','1')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            'Datos.DataSource = dt
=======
            insertUsuario(Usuario, Clave)
            InsertDireccion(Pais, Provinvia, Municipio, Sector, Calle, Casa)
>>>>>>> origin/master
            MsgBox("Datos almacenados con exito")
        Catch ex As Exception
            MsgBox(ex.Message)

            MsgBox("Los campos estan vacios")
            'MsgBox(Nombre + Apellido)

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
            cbsector.ValueMember = "idmunicipio"
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Conectar()
        ListaPais()
        ListaProvincia()
        ListaMunicipio()
        ListaSector()
    End Sub

    Private Sub btnGuardarEm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEm.Click
        RecogerVariables()
        InsertDireccion(Pais, Provinvia, Municipio, Sector, Calle, Casa)

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
End Class