Imports MySql.Data.MySqlClient
Imports MySql.Data

Module SELECTmodulo
    Dim resultado As Integer = 0
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    'recoger id de direccion
    Public Function ultimoIdD() As Integer
        Dim query As String = "SELECT MAX(iddireccion)FROM direccion"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado + 1
    End Function

    'recoger id de telefono
    Public Function ultimoIdT() As Integer
        Dim query As String = "SELECT MAX(idtelefono)FROM telefono"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado + 1
    End Function
    ' ultimo id de la factura 
    Public Function ultimoIdF() As Integer
        Dim query As String = "SELECT MAX(idfactura)FROM factura"
        comando = New MySqlCommand(query, Conex)
        lector = comando.ExecuteReader
        If lector.Read Then
            resultado = Val(lector(0).ToString)
        End If
        lector.Close()
        Return resultado + 1
    End Function
End Module
