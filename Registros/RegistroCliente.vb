Imports MySql.Data.MySqlClient

Module RegistroCliente

    Private Sub Rcliente()
        Try
            Dim IsertC As New MySqlCommand("insert into cliente('var1','var2','var3','var4','var5','var6')")

        Catch ex As Exception

        End Try
    End Sub

End Module
