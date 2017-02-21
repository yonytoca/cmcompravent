Imports System.Drawing.Printing
Imports FindNetPrintersLib

Public Class frmFactura
    Dim Factura, Cliente, Usuario, Producto As Integer
    Dim Cantidad, Precio, Descuento, Total As Double
    Dim fecha As Date
    Dim sql As String
    Dim Hora As String
    Dim i As Integer = 1
    Public Property PageSetupDialog1 As Object

    'recoger las variables
    Public Sub Variables()
        Try
            Factura = Val(txtfactura.Text).ToString
            Cliente = Val(txtCocliente.Text).ToString
            Usuario = Val(lblcodigoUsuario.Text).ToString
            Producto = Val(txtCodigoProducto.Text).ToString
            Cantidad = Val(txtCantidad.Text).ToString
            Precio = Val(txtPrecio.Text).ToString
            Descuento = Val(txtDescuento.Text).ToString
            Total = Val(txtTotal.Text).ToString
            'fecha = lblfecha.Text
            Hora = lblhora.Text

        Catch ex As Exception

        End Try
    End Sub

    'link buscar cliente por nombre 
    Private Sub lbBuscarC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbBuscarC.LinkClicked
        Variables()
        txtBuscar.Visible = True
        Dgcliente.Visible = True
        txtBuscar.Focus()
    End Sub

    'filtro para buscar el cliente por nombre
    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dv.RowFilter = String.Format("nombre like '%{0}%'", txtBuscar.Text)
    End Sub

    'filtro para buscar el producto por nombre 
    Private Sub txtBuscarP_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarP.TextChanged
        dv1.RowFilter = String.Format("nombre like '%{0}%'", txtBuscarP.Text)
    End Sub

    'link buscar producto por nombre 
    Private Sub lbBuscarP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbBuscarP.LinkClicked
        Dgproducto.Visible = True
        txtBuscarP.Visible = True
        txtBuscarP.Focus()
    End Sub

    'el evento chen de cantidad
    Private Sub txtCantidad_TextChanged_1(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Variables()
        txtTotal.Text = totalF(Cantidad, Precio, Descuento)
    End Sub

    'metodo para asignar los valores consultado de producto
    Public Sub BuscarPro()
        Try
            txtCodigoProducto.Text = Dgproducto.CurrentRow.Cells.Item(0).Value.ToString
            txtDescripcion.Text = Dgproducto.CurrentRow.Cells.Item(1).Value.ToString
            txtPrecio.Text = Dgproducto.CurrentRow.Cells.Item(2).Value.ToString

            txtBuscarP.Visible = False
            Dgproducto.Visible = False
            txtCantidad.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ProductoId()
        BuscarProductoId(DgProductoId, Producto)

        txtCodigoProducto.Text = DgProductoId.CurrentRow.Cells.Item(0).Value.ToString
        txtDescripcion.Text = DgProductoId.CurrentRow.Cells.Item(1).Value.ToString
        txtPrecio.Text = DgProductoId.CurrentRow.Cells.Item(2).Value.ToString

        txtCantidad.Focus()
    End Sub

    'Recoger los datos del cliente por id
    Public Sub ClienteId()

        BuscarClienteCodigo(DgclienteCodigo, Cliente)

        txtCocliente.Text = DgclienteCodigo.CurrentRow.Cells.Item(0).Value.ToString
        txtNcliente.Text = DgclienteCodigo.CurrentRow.Cells.Item(1).Value.ToString
        lblPaisC.Text = DgclienteCodigo.CurrentRow.Cells.Item(17).Value.ToString
        lblProvinviaC.Text = DgclienteCodigo.CurrentRow.Cells.Item(19).Value.ToString
        lblMunicipioC.Text = DgclienteCodigo.CurrentRow.Cells.Item(22).Value.ToString
        lblSectorC.Text = DgclienteCodigo.CurrentRow.Cells.Item(25).Value.ToString
        lblCalleC.Text = DgclienteCodigo.CurrentRow.Cells.Item(14).Value.ToString
        lblCasaC.Text = DgclienteCodigo.CurrentRow.Cells.Item(15).Value.ToString
        lblTelefonoC.Text = DgclienteCodigo.CurrentRow.Cells.Item(28).Value.ToString
        lblTipoT.Text = DgclienteCodigo.CurrentRow.Cells.Item(31).Value.ToString

        txtCodigoProducto.Focus()
        txtBuscar.Visible = False
        Dgcliente.Visible = False
    End Sub

    'recoger los datos de la empresa
    Public Sub Empresa()
        Try
            lblEmpresa.Text = DgEmpresa.CurrentRow.Cells.Item(1).Value.ToString
            lblSlogan.Text = DgEmpresa.CurrentRow.Cells.Item(3).Value.ToString
            lblTelefonoEm.Text = DgEmpresa.CurrentRow.Cells.Item(6).Value.ToString
            lblPaisE.Text = DgEmpresa.CurrentRow.Cells.Item(16).Value.ToString
            lblProvinciaE.Text = DgEmpresa.CurrentRow.Cells.Item(18).Value.ToString
            lblMunicipioE.Text = DgEmpresa.CurrentRow.Cells.Item(21).Value.ToString
            lblSectorE.Text = DgEmpresa.CurrentRow.Cells.Item(24).Value.ToString
            lblCalleE.Text = DgEmpresa.CurrentRow.Cells.Item(13).Value.ToString
            lblCasaE.Text = DgEmpresa.CurrentRow.Cells.Item(14).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    'metodo para asignar los valores consultado de cliente 
    Public Sub BuscarCli()
        txtCocliente.Text = Dgcliente.CurrentRow.Cells.Item(0).Value.ToString
        txtNcliente.Text = Dgcliente.CurrentRow.Cells.Item(1).Value.ToString

        txtCodigoProducto.Focus()
        txtBuscar.Visible = False
        Dgcliente.Visible = False
    End Sub
    Public Sub Quitar()
        DELETEfactura(DgFactura.CurrentRow.Cells.Item(0).Value.ToString)
    End Sub

    'evento del Dgcliente buscar
    Private Sub Dgproducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgproducto.CellContentClick
        BuscarPro()
    End Sub

    'el load del FRM factura 


    ' buscar cliente por id
    Private Sub txtCocliente_TextChanged(sender As Object, e As EventArgs) Handles txtCocliente.TextChanged
        Variables()
        Try
            dv3.RowFilter = String.Format("idpersona ", Cliente)
        Catch ex As Exception

        End Try
    End Sub

    'evento changed de precio unitario
    Private Sub txtPrecio_TextChanged_1(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        Variables()
        txtTotal.Text = totalF(Cantidad, Precio, Descuento)
    End Sub

    'boton agregar producto
    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Variables()
        If Cantidad <> 0 Then
            Descuento = Cantidad * Precio - Total
            inserFacturaDetalle(Cantidad, Precio, Producto, Factura, Descuento, Total)
            'llamar el detalle nuevamente 
            FacturaDetalle(DgFactura, ultimoIdF())
            DgFactura.Columns.Item("id").Visible = False
            TotalAp()
            ' DgFactura.Columns.Item("Id").Visible = False

        Else
            MsgBox("Falta Cantidad")
            txtCantidad.Focus()
        End If
        ' MsgBox(fTotalAp(Factura).ToString)
    End Sub
    Public Sub LinpiarAgregar()
        txtCodigoProducto.Clear()
        txtDescripcion.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
    End Sub

    'calcular el total a pagar
    Public Sub TotalAp()
        Try
            lblItebis.Text = Sumar("total", DgFactura).ToString * 18 / 100
            lblDescuento.Text = Sumar("descuento", DgFactura).ToString
            lblMonto.Text = Sumar("total", DgFactura).ToString - Sumar("descuento", DgFactura).ToString
            lblTotalPagar.Text = Convert.ToSingle(lblMonto.Text) + Convert.ToSingle(lblItebis.Text)
        Catch ex As Exception

        End Try

    End Sub



    'boton facturar
    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Try
            Validate()
            inserFactura(fecha, Cliente, Usuario, Hora)
            'generar impresion en papel o digital
            InvoiceGenerate()
            txtfactura.Text = pone_ceros(ultimoIdF())
            'FacturaDetalle(DgFactura, ultimoIdF)
            'txtCocliente.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProducto.TextChanged
        Variables()
        Try
            dv5.RowFilter = String.Format("idproducto ", Producto)
        Catch ex As Exception

        End Try
    End Sub

    'evento Dg cliente buscar
    Private Sub Dgcliente_Click(sender As Object, e As EventArgs) Handles Dgcliente.Click
        BuscarCli()
    End Sub

    Private Shared Function FillDgv() As List(Of EArticulo)
        '
        'Cree una lista generica de la entidad EArticulo
        '
        Dim listaArticulos As New List(Of EArticulo)()

        Return listaArticulos
    End Function

    Private Shared Function GenerateNumber() As Integer
        Dim rdm As New Random()

        Return rdm.[Next]()
    End Function

    Private Sub InvoiceGenerate()
        '
        'Hacemos una instancia de la clase EFactura para
        'llenarla con los valores contenidos en los controles del Formulario
        Dim invoice As New EFactura()
        invoice.Numero = Convert.ToString(txtfactura.Text)
        invoice.NumeroCliente = Convert.ToString(txtCocliente.Text)
        invoice.NombreCliente = Convert.ToString(txtNcliente.Text)
        invoice.TelefonoCliente = lblTelefonoC.Text
        invoice.DireccionCliente = lblPaisC.Text & lblProvinciaE.Text & lblMunicipioC.Text & lblSectorC.Text & lblCalleC.Text & lblCasaC.Text
        invoice.FechaFacturacion = lblfecha.Text
        invoice.Subtotal = Convert.ToDecimal(lblMonto.Text)
        invoice.Itebis = Convert.ToDecimal(lblItebis.Text)
        invoice.Total = Convert.ToDecimal(lblTotalPagar.Text)


        'Recorremos los Rows existentes actualmente en el control DataGridView
        'para asignar los datos a las propiedades
        For Each row As DataGridViewRow In DgFactura.Rows
            Dim article As New EArticulo()
            '
            'Vamos tomando los valores de las celdas del row que estamos 
            'recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
            '
            article.Numero = Convert.ToInt32(row.Cells("codigo").Value)
            '   article.Upc = Convert.ToString(row.Cells("codigo").Value)
            article.Descripcion = Convert.ToString(row.Cells("nombre").Value)
            article.Cantidad = Convert.ToDecimal(row.Cells("cantidad").Value)
            article.Descuento = Convert.ToDecimal(row.Cells("descuento").Value)
            article.Precio = Convert.ToDecimal(row.Cells("precio").Value)
            article.Importe = Convert.ToDecimal(row.Cells("total").Value)

            '
            'Vamos agregando el Item a la lista del detalle
            '
            invoice.Detail.Add(article)
        Next

        '
        'Creamos una instancia del Formulario que contiene nuestro
        'ReportViewer
        '
        Dim frm As New FacturaRpt()
        '
        'Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
        'que se mostrara en los parametros creados en el LocalReport, para este ejemplo
        'estamos Seteando los valores directamente pero usted puede usar algun control
        '
        frm.Titulo = "Este es un ejemplo de Factura"
        frm.Empresa = "Este es un ejemplo del Nombre de la Empresa"
        '
        'Recuerde que invoice es una Lista Generica declarada en FacturaRtp, es una lista
        'porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
        'implementen IEnumerable.
        '
        'Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
        frm.Invoice.Add(invoice)
        '
        'Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
        'es un lista del tipo EArticulo bastara con igualarla
        '
        frm.Detail = invoice.Detail
        frm.Show()
    End Sub
    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables()




        'txtCocliente.Text = Lclientes.txtMostrar.Text
        lblnombre.Text = Login.txtUsuario.Text
        lblcodigoUsuario.Text = login1(Login.txtUsuario.Text)
        txtfactura.Text = pone_ceros(ultimoIdF())
        lblfecha.Text = Date.Now.ToString("dd/MM/yyyy")
        lblhora.Text = TimeString


        ' txtfactura.FindForm()
        DgclienteCodigo.Visible = False
        DgProductoId.Visible = False
        DgEmpresa.Visible = False

        Dgcliente.Visible = False
        DgclienteCodigo.Visible = False
        txtBuscar.Visible = False

        Dgproducto.Visible = False
        txtBuscarP.Visible = False

        'buscar cliente
        mostrarlosdatos(Dgcliente)
        'datos de la empresa
        DatosEmpresa(DgEmpresa)
        Empresa()
        'buscar producto por nombre
        BuscarProducto(Dgproducto)
        'buscar producto por id

        'BuscarProductoId(DgProductoId, Producto)
        'BuscarProId()

        ' mantener el cliente de facturas abiertas 
        BuscarClienteFabierta(DgclienteCodigo, ultimoIdF())

        FacturaDetalle(DgFactura, ultimoIdF())


        DgFactura.Columns.Item("id").Visible = False
        'FacturaDetalle(DgFactura, Factura)
        TotalAp()
    End Sub


    'el evento keypress buscar cliente por nombre
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarCli()
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Quitar()
        FacturaDetalle(DgFactura, ultimoIdF())
        TotalAp()
        DgFactura.Columns.Item("id").Visible = False
        btnQuitar.Visible = False
    End Sub

    Private Sub ControlPrint_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' Definimos la fuente que vamos a usar para imprimir
        ' en este caso Arial de 10
        Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 1
        Dim texto As String = ""

        Dim row As System.Windows.Forms.DataGridViewRow

        ' Calculamos el número de líneas que caben en cada página
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

        ' Imprimimos las cabeceras
        Dim header As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In DgFactura.Columns
            header = column.HeaderCell
            texto += vbTab + header.FormattedValue.ToString()
            'DgFactura.Columns.Item("idfacturadetalle").Visible = False
        Next

        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        ' Dejamos una línea de separación
        count += 2

        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < DgFactura.Rows.Count
            row = DgFactura.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then
                    texto += vbTab + celda.Value.ToString()
                End If
            Next

            ' Calculamos la posición en la que se escribe la línea
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

            ' Escribimos la línea con el objeto Graphics
            e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            ' Incrementamos los contadores
            count += 1
            i += 1
        End While

        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        If i < DgFactura.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este
            ' evento como si fuese la primera vez, y si i está con el valor de la
            ' última fila del grid no se imprime nada
            i = 0
        End If




        '  Dim myPaintArgs As New PaintEventArgs(e.Graphics, New Rectangle(New _
        'Point(0, 10), Me.Size))
        'Me.InvokePaint(DgFactura, myPaintArgs)
        'PrintDocument1.PrintPage()
        '  e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

        'PrintDocument1.Print()
    End Sub

    Private Sub Print()
        Throw New NotImplementedException()
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        Variables()
        txtTotal.Text = totalF(Cantidad, Precio, Descuento)
    End Sub

    'el evento keypress buscar cliente por id
    Private Sub txtCocliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCocliente.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                Variables()
                ClienteId()

            End If
        Catch ex As Exception
            ' MsgBox("Cliente no existe")
        End Try
    End Sub

    'el evento Dgcliente 
    Private Sub Dgcliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgcliente.CellContentClick
        BuscarPro()
    End Sub

    'el evento keypress buscar producto
    Private Sub txtBuscarP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPro()
        End If
    End Sub

    Private Sub txtfactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfactura.KeyPress
        Variables()
        FacturaDetalle(DgFactura, Factura)
        TotalAp()
        txtfactura.Text = pone_ceros(Factura)
    End Sub

    Private Sub txtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                Variables()
                ProductoId()

            End If
        Catch ex As Exception
            MsgBox("Producto no existe")
        End Try
    End Sub

    Private Sub DgFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgFactura.CellClick
        btnQuitar.Visible = True
    End Sub
End Class