<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtBuscarP = New System.Windows.Forms.TextBox()
        Me.Dgproducto = New System.Windows.Forms.DataGridView()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.lblItebis = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcodigoUsuario = New System.Windows.Forms.Label()
        Me.DgFactura = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbBuscarP = New System.Windows.Forms.LinkLabel()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDecuento = New System.Windows.Forms.TextBox()
        Me.DgclienteCodigo = New System.Windows.Forms.DataGridView()
        Me.lbBuscarC = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCocliente = New System.Windows.Forms.TextBox()
        Me.txtNcliente = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTipoT = New System.Windows.Forms.Label()
        Me.lblCasaC = New System.Windows.Forms.Label()
        Me.lblTelefonoC = New System.Windows.Forms.Label()
        Me.lblCalleC = New System.Windows.Forms.Label()
        Me.lblSectorC = New System.Windows.Forms.Label()
        Me.lblMunicipioC = New System.Windows.Forms.Label()
        Me.lblProvinviaC = New System.Windows.Forms.Label()
        Me.lblPaisC = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCasaE = New System.Windows.Forms.Label()
        Me.lblCalleE = New System.Windows.Forms.Label()
        Me.lblSectorE = New System.Windows.Forms.Label()
        Me.lblMunicipioE = New System.Windows.Forms.Label()
        Me.lblProvinciaE = New System.Windows.Forms.Label()
        Me.lblPaisE = New System.Windows.Forms.Label()
        Me.lblTelefonoEm = New System.Windows.Forms.Label()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgProductoId = New System.Windows.Forms.DataGridView()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DgEmpresa = New System.Windows.Forms.DataGridView()
        Me.Dgcliente = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.Dgproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgclienteCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgProductoId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarP
        '
        Me.txtBuscarP.Location = New System.Drawing.Point(74, 228)
        Me.txtBuscarP.Name = "txtBuscarP"
        Me.txtBuscarP.Size = New System.Drawing.Size(213, 20)
        Me.txtBuscarP.TabIndex = 70
        '
        'Dgproducto
        '
        Me.Dgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgproducto.Location = New System.Drawing.Point(74, 228)
        Me.Dgproducto.Name = "Dgproducto"
        Me.Dgproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgproducto.Size = New System.Drawing.Size(663, 127)
        Me.Dgproducto.TabIndex = 69
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(3, 171)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(75, 23)
        Me.btnFacturar.TabIndex = 66
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.AutoSize = True
        Me.lblTotalPagar.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalPagar.Location = New System.Drawing.Point(820, 305)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(24, 25)
        Me.lblTotalPagar.TabIndex = 65
        Me.lblTotalPagar.Text = "0"
        '
        'lblItebis
        '
        Me.lblItebis.AutoSize = True
        Me.lblItebis.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItebis.Location = New System.Drawing.Point(820, 278)
        Me.lblItebis.Name = "lblItebis"
        Me.lblItebis.Size = New System.Drawing.Size(24, 25)
        Me.lblItebis.TabIndex = 64
        Me.lblItebis.Text = "0"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(820, 256)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(24, 25)
        Me.lblDescuento.TabIndex = 63
        Me.lblDescuento.Text = "0"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(820, 230)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(24, 25)
        Me.lblMonto.TabIndex = 62
        Me.lblMonto.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(754, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 25)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Total"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(749, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 25)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "ITBIS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(753, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 25)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Desc"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(744, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 25)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Monto"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(149, 145)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(52, 13)
        Me.lblnombre.TabIndex = 55
        Me.lblnombre.Text = "Label13"
        '
        'lblcodigoUsuario
        '
        Me.lblcodigoUsuario.AutoSize = True
        Me.lblcodigoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigoUsuario.Location = New System.Drawing.Point(88, 143)
        Me.lblcodigoUsuario.Name = "lblcodigoUsuario"
        Me.lblcodigoUsuario.Size = New System.Drawing.Size(52, 13)
        Me.lblcodigoUsuario.TabIndex = 54
        Me.lblcodigoUsuario.Text = "Label12"
        '
        'DgFactura
        '
        Me.DgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgFactura.Location = New System.Drawing.Point(13, 228)
        Me.DgFactura.Name = "DgFactura"
        Me.DgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgFactura.Size = New System.Drawing.Size(724, 188)
        Me.DgFactura.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbBuscarP)
        Me.GroupBox1.Controls.Add(Me.txtCodigoProducto)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtDecuento)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 58)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(693, 29)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 23
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        Me.btnQuitar.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(612, 29)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(530, 32)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtTotal.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(533, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Desc %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Codigo"
        '
        'lbBuscarP
        '
        Me.lbBuscarP.AutoSize = True
        Me.lbBuscarP.Location = New System.Drawing.Point(278, 35)
        Me.lbBuscarP.Name = "lbBuscarP"
        Me.lbBuscarP.Size = New System.Drawing.Size(40, 13)
        Me.lbBuscarP.TabIndex = 22
        Me.lbBuscarP.TabStop = True
        Me.lbBuscarP.Text = "Buscar"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCodigoProducto.Location = New System.Drawing.Point(1, 32)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigoProducto.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDescripcion.HideSelection = False
        Me.txtDescripcion.Location = New System.Drawing.Point(61, 32)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(213, 20)
        Me.txtDescripcion.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Descripción"
        '
        'txtCantidad
        '
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCantidad.Location = New System.Drawing.Point(322, 32)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(55, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPrecio.Location = New System.Drawing.Point(383, 32)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'txtDecuento
        '
        Me.txtDecuento.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDecuento.Location = New System.Drawing.Point(460, 32)
        Me.txtDecuento.Name = "txtDecuento"
        Me.txtDecuento.Size = New System.Drawing.Size(64, 20)
        Me.txtDecuento.TabIndex = 5
        '
        'DgclienteCodigo
        '
        Me.DgclienteCodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgclienteCodigo.Location = New System.Drawing.Point(353, 145)
        Me.DgclienteCodigo.Name = "DgclienteCodigo"
        Me.DgclienteCodigo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgclienteCodigo.Size = New System.Drawing.Size(42, 20)
        Me.DgclienteCodigo.TabIndex = 72
        '
        'lbBuscarC
        '
        Me.lbBuscarC.AutoSize = True
        Me.lbBuscarC.Location = New System.Drawing.Point(252, 16)
        Me.lbBuscarC.Name = "lbBuscarC"
        Me.lbBuscarC.Size = New System.Drawing.Size(40, 13)
        Me.lbBuscarC.TabIndex = 47
        Me.lbBuscarC.TabStop = True
        Me.lbBuscarC.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Vendedor"
        '
        'txtCocliente
        '
        Me.txtCocliente.Location = New System.Drawing.Point(21, 50)
        Me.txtCocliente.Name = "txtCocliente"
        Me.txtCocliente.Size = New System.Drawing.Size(58, 20)
        Me.txtCocliente.TabIndex = 43
        '
        'txtNcliente
        '
        Me.txtNcliente.Location = New System.Drawing.Point(85, 50)
        Me.txtNcliente.Name = "txtNcliente"
        Me.txtNcliente.Size = New System.Drawing.Size(175, 20)
        Me.txtNcliente.TabIndex = 71
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnFacturar)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(743, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 199)
        Me.Panel1.TabIndex = 73
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTipoT)
        Me.GroupBox2.Controls.Add(Me.lblCasaC)
        Me.GroupBox2.Controls.Add(Me.lblTelefonoC)
        Me.GroupBox2.Controls.Add(Me.lblCalleC)
        Me.GroupBox2.Controls.Add(Me.lblSectorC)
        Me.GroupBox2.Controls.Add(Me.lblMunicipioC)
        Me.GroupBox2.Controls.Add(Me.lblProvinviaC)
        Me.GroupBox2.Controls.Add(Me.lblPaisC)
        Me.GroupBox2.Controls.Add(Me.lbBuscarC)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 99)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'lblTipoT
        '
        Me.lblTipoT.AutoSize = True
        Me.lblTipoT.Location = New System.Drawing.Point(199, 51)
        Me.lblTipoT.Name = "lblTipoT"
        Me.lblTipoT.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoT.TabIndex = 76
        Me.lblTipoT.Text = "Tipot"
        '
        'lblCasaC
        '
        Me.lblCasaC.AutoSize = True
        Me.lblCasaC.Location = New System.Drawing.Point(201, 77)
        Me.lblCasaC.Name = "lblCasaC"
        Me.lblCasaC.Size = New System.Drawing.Size(31, 13)
        Me.lblCasaC.TabIndex = 75
        Me.lblCasaC.Text = "Casa"
        '
        'lblTelefonoC
        '
        Me.lblTelefonoC.AutoSize = True
        Me.lblTelefonoC.Location = New System.Drawing.Point(197, 37)
        Me.lblTelefonoC.Name = "lblTelefonoC"
        Me.lblTelefonoC.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefonoC.TabIndex = 52
        Me.lblTelefonoC.Text = "Teléfono"
        '
        'lblCalleC
        '
        Me.lblCalleC.AutoSize = True
        Me.lblCalleC.Location = New System.Drawing.Point(201, 63)
        Me.lblCalleC.Name = "lblCalleC"
        Me.lblCalleC.Size = New System.Drawing.Size(30, 13)
        Me.lblCalleC.TabIndex = 74
        Me.lblCalleC.Text = "Calle"
        '
        'lblSectorC
        '
        Me.lblSectorC.AutoSize = True
        Me.lblSectorC.Location = New System.Drawing.Point(6, 74)
        Me.lblSectorC.Name = "lblSectorC"
        Me.lblSectorC.Size = New System.Drawing.Size(38, 13)
        Me.lblSectorC.TabIndex = 51
        Me.lblSectorC.Text = "Sector"
        '
        'lblMunicipioC
        '
        Me.lblMunicipioC.AutoSize = True
        Me.lblMunicipioC.Location = New System.Drawing.Point(6, 61)
        Me.lblMunicipioC.Name = "lblMunicipioC"
        Me.lblMunicipioC.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipioC.TabIndex = 50
        Me.lblMunicipioC.Text = "Municipio"
        '
        'lblProvinviaC
        '
        Me.lblProvinviaC.AutoSize = True
        Me.lblProvinviaC.Location = New System.Drawing.Point(6, 48)
        Me.lblProvinviaC.Name = "lblProvinviaC"
        Me.lblProvinviaC.Size = New System.Drawing.Size(51, 13)
        Me.lblProvinviaC.TabIndex = 49
        Me.lblProvinviaC.Text = "Provincia"
        '
        'lblPaisC
        '
        Me.lblPaisC.AutoSize = True
        Me.lblPaisC.Location = New System.Drawing.Point(6, 36)
        Me.lblPaisC.Name = "lblPaisC"
        Me.lblPaisC.Size = New System.Drawing.Size(27, 13)
        Me.lblPaisC.TabIndex = 48
        Me.lblPaisC.Text = "Pais"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCasaE)
        Me.GroupBox3.Controls.Add(Me.lblCalleE)
        Me.GroupBox3.Controls.Add(Me.lblSectorE)
        Me.GroupBox3.Controls.Add(Me.lblMunicipioE)
        Me.GroupBox3.Controls.Add(Me.lblProvinciaE)
        Me.GroupBox3.Controls.Add(Me.lblPaisE)
        Me.GroupBox3.Controls.Add(Me.lblTelefonoEm)
        Me.GroupBox3.Controls.Add(Me.lblSlogan)
        Me.GroupBox3.Controls.Add(Me.lblEmpresa)
        Me.GroupBox3.Controls.Add(Me.lblfecha)
        Me.GroupBox3.Controls.Add(Me.lblhora)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(583, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 153)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Empresa"
        '
        'lblCasaE
        '
        Me.lblCasaE.AutoSize = True
        Me.lblCasaE.Location = New System.Drawing.Point(178, 106)
        Me.lblCasaE.Name = "lblCasaE"
        Me.lblCasaE.Size = New System.Drawing.Size(31, 13)
        Me.lblCasaE.TabIndex = 73
        Me.lblCasaE.Text = "Casa"
        '
        'lblCalleE
        '
        Me.lblCalleE.AutoSize = True
        Me.lblCalleE.Location = New System.Drawing.Point(22, 106)
        Me.lblCalleE.Name = "lblCalleE"
        Me.lblCalleE.Size = New System.Drawing.Size(30, 13)
        Me.lblCalleE.TabIndex = 72
        Me.lblCalleE.Text = "Calle"
        '
        'lblSectorE
        '
        Me.lblSectorE.AutoSize = True
        Me.lblSectorE.Location = New System.Drawing.Point(20, 92)
        Me.lblSectorE.Name = "lblSectorE"
        Me.lblSectorE.Size = New System.Drawing.Size(38, 13)
        Me.lblSectorE.TabIndex = 71
        Me.lblSectorE.Text = "Sector"
        '
        'lblMunicipioE
        '
        Me.lblMunicipioE.AutoSize = True
        Me.lblMunicipioE.Location = New System.Drawing.Point(20, 79)
        Me.lblMunicipioE.Name = "lblMunicipioE"
        Me.lblMunicipioE.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipioE.TabIndex = 70
        Me.lblMunicipioE.Text = "Municipio"
        '
        'lblProvinciaE
        '
        Me.lblProvinciaE.AutoSize = True
        Me.lblProvinciaE.Location = New System.Drawing.Point(20, 65)
        Me.lblProvinciaE.Name = "lblProvinciaE"
        Me.lblProvinciaE.Size = New System.Drawing.Size(51, 13)
        Me.lblProvinciaE.TabIndex = 69
        Me.lblProvinciaE.Text = "Provincia"
        '
        'lblPaisE
        '
        Me.lblPaisE.AutoSize = True
        Me.lblPaisE.Location = New System.Drawing.Point(20, 51)
        Me.lblPaisE.Name = "lblPaisE"
        Me.lblPaisE.Size = New System.Drawing.Size(27, 13)
        Me.lblPaisE.TabIndex = 68
        Me.lblPaisE.Text = "Pais"
        '
        'lblTelefonoEm
        '
        Me.lblTelefonoEm.AutoSize = True
        Me.lblTelefonoEm.Location = New System.Drawing.Point(174, 57)
        Me.lblTelefonoEm.Name = "lblTelefonoEm"
        Me.lblTelefonoEm.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefonoEm.TabIndex = 66
        Me.lblTelefonoEm.Text = "Teléfono"
        '
        'lblSlogan
        '
        Me.lblSlogan.AutoSize = True
        Me.lblSlogan.Location = New System.Drawing.Point(91, 27)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(40, 13)
        Me.lblSlogan.TabIndex = 65
        Me.lblSlogan.Text = "Slogan"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(109, 9)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(44, 13)
        Me.lblEmpresa.TabIndex = 64
        Me.lblEmpresa.Text = "Nombre"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(211, 75)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(45, 13)
        Me.lblfecha.TabIndex = 63
        Me.lblfecha.Text = "Label13"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(208, 91)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(45, 13)
        Me.lblhora.TabIndex = 62
        Me.lblhora.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(177, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Hora"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Fecha"
        '
        'DgProductoId
        '
        Me.DgProductoId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProductoId.Location = New System.Drawing.Point(488, 144)
        Me.DgProductoId.Name = "DgProductoId"
        Me.DgProductoId.Size = New System.Drawing.Size(31, 20)
        Me.DgProductoId.TabIndex = 77
        '
        'txtfactura
        '
        Me.txtfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Location = New System.Drawing.Point(150, 12)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(155, 31)
        Me.txtfactura.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 25)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Factura No"
        '
        'DgEmpresa
        '
        Me.DgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEmpresa.Location = New System.Drawing.Point(452, 145)
        Me.DgEmpresa.Name = "DgEmpresa"
        Me.DgEmpresa.Size = New System.Drawing.Size(30, 19)
        Me.DgEmpresa.TabIndex = 76
        '
        'Dgcliente
        '
        Me.Dgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgcliente.Location = New System.Drawing.Point(178, 73)
        Me.Dgcliente.Name = "Dgcliente"
        Me.Dgcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgcliente.Size = New System.Drawing.Size(399, 109)
        Me.Dgcliente.TabIndex = 67
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(178, 73)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(153, 20)
        Me.txtBuscar.TabIndex = 68
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 440)
        Me.Controls.Add(Me.DgProductoId)
        Me.Controls.Add(Me.DgEmpresa)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DgclienteCodigo)
        Me.Controls.Add(Me.txtNcliente)
        Me.Controls.Add(Me.txtBuscarP)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Dgcliente)
        Me.Controls.Add(Me.Dgproducto)
        Me.Controls.Add(Me.lblTotalPagar)
        Me.Controls.Add(Me.lblItebis)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblcodigoUsuario)
        Me.Controls.Add(Me.DgFactura)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCocliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.KeyPreview = True
        Me.Name = "frmFactura"
        Me.Text = "Factura"
        CType(Me.Dgproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgclienteCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgProductoId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarP As TextBox
    Friend WithEvents Dgproducto As DataGridView
    Friend WithEvents btnFacturar As Button
    Friend WithEvents lblTotalPagar As Label
    Friend WithEvents lblItebis As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcodigoUsuario As Label
    Friend WithEvents DgFactura As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbBuscarP As LinkLabel
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDecuento As TextBox
    Friend WithEvents lbBuscarC As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCocliente As TextBox
    Friend WithEvents txtNcliente As TextBox
    Friend WithEvents DgclienteCodigo As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSectorC As Label
    Friend WithEvents lblMunicipioC As Label
    Friend WithEvents lblProvinviaC As Label
    Friend WithEvents lblPaisC As Label
    Friend WithEvents lblTelefonoC As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTelefonoEm As Label
    Friend WithEvents lblSlogan As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfactura As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DgEmpresa As DataGridView
    Friend WithEvents lblCasaC As Label
    Friend WithEvents lblCalleC As Label
    Friend WithEvents lblCasaE As Label
    Friend WithEvents lblCalleE As Label
    Friend WithEvents lblSectorE As Label
    Friend WithEvents lblMunicipioE As Label
    Friend WithEvents lblProvinciaE As Label
    Friend WithEvents lblPaisE As Label
    Friend WithEvents DgProductoId As DataGridView
    Friend WithEvents lblTipoT As Label
    Friend WithEvents Dgcliente As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnQuitar As Button
End Class
