Imports MySql.Data
Imports MySql.Data.MySqlClient

Module conexion

    Public Conex As New MySqlConnection

    Sub Conectar()
        Try
            Conex.ConnectionString = "server=localhost;user id=root; password=''; database=compraventa"
            Conex.Open()
            ' MsgBox("conexion exitosa")
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
End Module
