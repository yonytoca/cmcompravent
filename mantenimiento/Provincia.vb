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
    Public Sub RecogerVariables()
        'Nombre = txtnombreEm.Text
        'Apellido = txtapellidoEm.Text
        'Cedula = txtcedulaEm.Text
        'Telefono = txttelefonoEm.Text
        'Calle = txtcalleEm.Text
        'Casa = txtcasaEm.Text
        Nombre = txtnombrePro.Text
        Nota = txtnotaPro.Text
        Pais = Val(cbpais.Text).ToString
        'Provinvia = cbprovincia.Text
        'Municipio = cbmunicipio.Text
        'Sector = cbsector.Text
        Try
            sql = "insert into provincia(nombre,comentario,idpais)value('" & Nombre & "', '" & Nota & "','" & Pais & "')"
            da = New MySqlDataAdapter(Sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            'Datos.DataSource = dt
            MsgBox("Datos almacenados con exito")
        Catch ex As Exception
            MsgBox(ex.Message)

            MsgBox("Los campos estan vacios")
            'MsgBox(Nombre + Apellido)

        End Try

    End Sub


    Private Sub Provincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListaPais()
    End Sub

    Private Sub btnguardarPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarPro.Click
        RecogerVariables()
        MDIempleado()
        Me.Hide()
    End Sub
End Class