Imports FindNetPrintersLib

Public Class frmFactura
    Dim Factura, Cliente, Usuario, Producto As Integer
    Dim Cantidad, Precio, Descuento, Total As Double
    Dim fecha As Date
    Dim sql As String
    Dim Hora As String

    'recoger las variables
    Public Sub Variables()
        Try
            Factura = Val(txtfactura.Text).ToString
            Cliente = Val(txtCocliente.Text).ToString
            Usuario = Val(lblcodigoUsuario.Text).ToString
            Producto = Val(txtCodigoProducto.Text).ToString
            Cantidad = Val(txtCantidad.Text).ToString
            Precio = Val(txtPrecio.Text).ToString
            Descuento = Val(txtDecuento.Text).ToString
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
        Cantidad = Val(txtCantidad.Text).ToString
        Precio = Val(txtPrecio.Text).ToString
        txtTotal.Text = totalF(Cantidad, Precio)
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
        Cantidad = Val(txtCantidad.Text).ToString
        Precio = Val(txtPrecio.Text).ToString
        txtTotal.Text = totalF(Cantidad, Precio)
    End Sub

    'boton agregar producto
    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Variables()
        If Cantidad <> 0 Then
            inserFacturaDetalle(Cantidad, Precio, Producto, Factura, Total)
            FacturaDetalle(DgFactura, ultimoIdF())
            TotalAp()
            DgFactura.Columns.Item("idfacturadetalle").Visible = False
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
            Dim Total As Single
            Dim Col As Integer = DgFactura.CurrentCell.ColumnIndex
            Col = 5
            For Each row As DataGridViewRow In DgFactura.Rows
                Total += Val(row.Cells(Col).Value)
            Next
            lblTotalPagar.Text = Total.ToString
        Catch ex As Exception

        End Try

    End Sub



    'boton facturar
    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        FacturaImprimir.Show()

        Try
            Validate()
            inserFactura(fecha, Cliente, Usuario, Hora)
            txtfactura.Text = pone_ceros(ultimoIdF())
            FacturaDetalle(DgFactura, ultimoIdF)
            txtCocliente.Focus()
            lblTotalPagar.Text = 0



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
        BuscarClienteFabierta(DgclienteCodigo, Factura)

        FacturaDetalle(DgFactura, ultimoIdF())
        DgFactura.Columns.Item("idfacturadetalle").Visible = False
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
        DgFactura.Columns.Item("idfacturadetalle").Visible = False
        btnQuitar.Visible = False
    End Sub

    Private Sub ControlPrint_Load(sender As Object, e As EventArgs)

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