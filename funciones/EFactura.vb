Imports System.Collections.Generic
Public Class EFactura
    Public Property Numero() As String
    Public Property NumeroCliente() As String
    Public Property NombreCliente() As String
    Public Property TelefonoCliente() As String
    Public Property DireccionCliente() As String
    Public Property Subtotal() As Decimal
    Public Property Itebis() As Decimal
    Public Property Total() As Decimal
    Public Property FechaFacturacion() As DateTime

    'Creamos una lista con una nueva Instancia de la clase Articulo
    'esta lista contendra el detalle de la factura
    Public Detail As New List(Of EArticulo)()
End Class
