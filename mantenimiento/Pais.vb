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
        Nota = txtnotaP.Text

        Try
            sql = "insert into pais(nombre,comentario)value('" & Nombre & "', '" & Nota & "')"
            da = New MySqlDataAdapter(sql, Conex)
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

    Private Sub Pais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnguardarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarP.Click
        GuardarPais()
        MDIempleado()
        Me.Hide()
    End Sub
End Class