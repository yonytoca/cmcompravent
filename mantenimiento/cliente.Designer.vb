<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombreCli = New System.Windows.Forms.TextBox()
        Me.txtapellidoCli = New System.Windows.Forms.TextBox()
        Me.txtcedulaCli = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtcasa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcalle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbsector = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbmunicipio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbprovincia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnguardarCli = New System.Windows.Forms.Button()
        Me.btncancelarCli = New System.Windows.Forms.Button()
        Me.txttelefono1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cedula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'txtnombreCli
        '
        Me.txtnombreCli.Location = New System.Drawing.Point(88, 49)
        Me.txtnombreCli.Name = "txtnombreCli"
        Me.txtnombreCli.Size = New System.Drawing.Size(133, 20)
        Me.txtnombreCli.TabIndex = 5
        '
        'txtapellidoCli
        '
        Me.txtapellidoCli.Location = New System.Drawing.Point(88, 75)
        Me.txtapellidoCli.Name = "txtapellidoCli"
        Me.txtapellidoCli.Size = New System.Drawing.Size(145, 20)
        Me.txtapellidoCli.TabIndex = 6
        '
        'txtcedulaCli
        '
        Me.txtcedulaCli.Location = New System.Drawing.Point(88, 105)
        Me.txtcedulaCli.Name = "txtcedulaCli"
        Me.txtcedulaCli.Size = New System.Drawing.Size(82, 20)
        Me.txtcedulaCli.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbpais)
        Me.GroupBox1.Controls.Add(Me.LinkLabel4)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtcasa)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtcalle)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbsector)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbmunicipio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbprovincia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(239, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 200)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direccion"
        '
        'cbpais
        '
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(91, 23)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(188, 24)
        Me.cbpais.TabIndex = 18
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel4.Location = New System.Drawing.Point(299, 113)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(38, 16)
        Me.LinkLabel4.TabIndex = 17
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "New"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel3.Location = New System.Drawing.Point(254, 83)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(38, 16)
        Me.LinkLabel3.TabIndex = 16
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "New"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel2.Location = New System.Drawing.Point(327, 54)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(38, 16)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "New"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel1.Location = New System.Drawing.Point(281, 25)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 16)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "New"
        '
        'txtcasa
        '
        Me.txtcasa.Location = New System.Drawing.Point(91, 166)
        Me.txtcasa.Name = "txtcasa"
        Me.txtcasa.Size = New System.Drawing.Size(121, 22)
        Me.txtcasa.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Casa"
        '
        'txtcalle
        '
        Me.txtcalle.Location = New System.Drawing.Point(91, 140)
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(270, 22)
        Me.txtcalle.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(15, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Calle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sector"
        '
        'cbsector
        '
        Me.cbsector.FormattingEnabled = True
        Me.cbsector.Location = New System.Drawing.Point(91, 113)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Size = New System.Drawing.Size(206, 24)
        Me.cbsector.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Municipio"
        '
        'cbmunicipio
        '
        Me.cbmunicipio.FormattingEnabled = True
        Me.cbmunicipio.Location = New System.Drawing.Point(91, 83)
        Me.cbmunicipio.Name = "cbmunicipio"
        Me.cbmunicipio.Size = New System.Drawing.Size(160, 24)
        Me.cbmunicipio.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Provincia"
        '
        'cbprovincia
        '
        Me.cbprovincia.FormattingEnabled = True
        Me.cbprovincia.Location = New System.Drawing.Point(91, 54)
        Me.cbprovincia.Name = "cbprovincia"
        Me.cbprovincia.Size = New System.Drawing.Size(233, 24)
        Me.cbprovincia.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pais"
        '
        'btnguardarCli
        '
        Me.btnguardarCli.Location = New System.Drawing.Point(216, 265)
        Me.btnguardarCli.Name = "btnguardarCli"
        Me.btnguardarCli.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarCli.TabIndex = 11
        Me.btnguardarCli.Text = "Guardar"
        Me.btnguardarCli.UseVisualStyleBackColor = True
        '
        'btncancelarCli
        '
        Me.btncancelarCli.Location = New System.Drawing.Point(326, 265)
        Me.btncancelarCli.Name = "btncancelarCli"
        Me.btncancelarCli.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarCli.TabIndex = 12
        Me.btncancelarCli.Text = "Cancelar"
        Me.btncancelarCli.UseVisualStyleBackColor = True
        '
        'txttelefono1
        '
        Me.txttelefono1.Location = New System.Drawing.Point(88, 137)
        Me.txttelefono1.Name = "txttelefono1"
        Me.txttelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txttelefono1.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Tipo Telefono"
        '
        'cboTipoTelefono
        '
        Me.cboTipoTelefono.FormattingEnabled = True
        Me.cboTipoTelefono.Location = New System.Drawing.Point(118, 167)
        Me.cboTipoTelefono.Name = "cboTipoTelefono"
        Me.cboTipoTelefono.Size = New System.Drawing.Size(103, 21)
        Me.cboTipoTelefono.TabIndex = 19
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.compravent.My.Resources.Resources.fondoform
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(641, 316)
        Me.Controls.Add(Me.cboTipoTelefono)
        Me.Controls.Add(Me.txttelefono1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btncancelarCli)
        Me.Controls.Add(Me.btnguardarCli)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtcedulaCli)
        Me.Controls.Add(Me.txtapellidoCli)
        Me.Controls.Add(Me.txtnombreCli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombreCli As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidoCli As System.Windows.Forms.TextBox
    Friend WithEvents txtcedulaCli As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcasa As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcalle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbsector As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbmunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnguardarCli As System.Windows.Forms.Button
    Friend WithEvents btncancelarCli As System.Windows.Forms.Button
    Friend WithEvents txttelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents cbpais As ComboBox
    Friend WithEvents cboTipoTelefono As ComboBox
End Class
