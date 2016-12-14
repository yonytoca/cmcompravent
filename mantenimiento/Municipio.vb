
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Municipio
    Dim Nombre, Nota As String
    Dim Provincia As Integer
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Public Sub ListaProvincia()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from provincia", Conex)
            DA.Fill(DT)
            cbprovinciaMc.DataSource = DT
            cbprovinciaMc.DisplayMember = "nombre"
            cbprovinciaMc.ValueMember = "idprovincia"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btncancelarMc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarMc.Click
        MDIempleado()
        Me.Close()
    End Sub
    Public Sub RecogerVariables()
        Nombre = txtnombreMc.Text
        Nota = txtnotaMc.Text
        Provincia = cbprovinciaMc.SelectedValue
        Try
            Insertmunicipio(Nombre, Nota, Provincia)
            ' MsgBox("Datos almacenados con exito")
        Catch ex As Exception
            MsgBox(ex.Message)

            MsgBox("Existen campos vacios")
            'MsgBox(Nombre + Apellido)
        End Try

    End Sub
    Private Sub btnguardarMc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarMc.Click
        RecogerVariables()
        MDIempleado()
    End Sub

    Private Sub Municipio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListaProvincia()
    End Sub
End Class