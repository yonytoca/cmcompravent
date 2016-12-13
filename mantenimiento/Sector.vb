Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Sector
    Dim Nombre, Nota As String
    Dim Municipio As Integer
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Public Sub ListaPais()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from municipio", Conex)
            DA.Fill(DT)
            cbmunicipio.DataSource = DT
            cbmunicipio.DisplayMember = "nombre"
            cbmunicipio.ValueMember = "idsector"
        Catch ex As Exception

        End Try

    End Sub
    Public Sub RecogerVariables()

        Nombre = txtsector.Text
        Nota = txtnota.Text
        Municipio = Val(cbmunicipio.Text).ToString
               Try
            sql = "insert into municipio(nombre,comentario,idmunicipio)value('" & Nombre & "', '" & Nota & "','" & Municipio & "')"
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

    Private Sub btnguardarPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarPro.Click
        RecogerVariables()
        MDIempleado()
        Me.Hide()
    End Sub
End Class