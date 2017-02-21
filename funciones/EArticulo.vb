Public Class EArticulo
    Public Property Numero() As Integer
    Public Property Descripcion() As String
    Public Property Cantidad() As Decimal
    Public Property Precio() As Decimal
    Public Property Descuento() As Decimal
    Public Property Importe() As Decimal
    'Creamos una lista con una nueva Instancia de la clase Articulo
    'esta lista contendra el detalle de la factura
    Public Detail As New List(Of EArticulo)()
End Class
