Public Class Producto
    Dim Nombre, descripcion, Nota As String
    Dim Precio_Costo, Precio_Venta, Margen As Single
    Dim CodigoP As Integer
    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = ultimoIdP()
        BuscarProductoFrmP(Dgproductofrm)
    End Sub
    'recoger las variables 
    Public Sub Variables()
        Nombre = txtNombre.Text
        descripcion = txtDescripcion.Text
        Precio_Costo = Val(txtPcompra.Text).ToString
        Precio_Venta = Val(txtPventa.Text).ToString
        CodigoP = Val(txtCodigo.Text).ToString
        Nota = txtNota.Text
    End Sub
    'guardar el producto
    Public Sub Guardar()
        Variables()
        InsertProducto(Nombre, descripcion)
        inserInventario(Precio_Costo, Precio_Venta, CodigoP, Nota)
    End Sub
    'buscar producto y asignar valores 
    Public Sub BuscarProP()
        txtCodigo.Text = Dgproductofrm.CurrentRow.Cells.Item(0).Value.ToString
        txtNombre.Text = Dgproductofrm.CurrentRow.Cells.Item(1).Value.ToString
        txtDescripcion.Text = Dgproductofrm.CurrentRow.Cells.Item(2).Value.ToString
        txtPventa.Text = Dgproductofrm.CurrentRow.Cells.Item(3).Value.ToString
        txtPcompra.Text = Dgproductofrm.CurrentRow.Cells.Item(4).Value.ToString
        txtNota.Text = Dgproductofrm.CurrentRow.Cells.Item(5).Value.ToString
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dv4.RowFilter = String.Format("nombre like '%{0}%'", txtBuscar.Text)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
    End Sub

    Private Sub Dgproductofrm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgproductofrm.CellClick
        BuscarProP()
    End Sub

    Private Sub Dgproductofrm_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgproductofrm.CellEnter
        BuscarProP()
    End Sub
End Class