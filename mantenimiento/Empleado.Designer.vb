<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombreEm = New System.Windows.Forms.TextBox()
        Me.txtapellidoEm = New System.Windows.Forms.TextBox()
        Me.txtcedulaEm = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcasaEm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcalleEm = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbsector = New System.Windows.Forms.ComboBox()
        Me.cbmunicipio = New System.Windows.Forms.ComboBox()
        Me.cbprovincia = New System.Windows.Forms.ComboBox()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttelefonoEm = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtclaveEm = New System.Windows.Forms.TextBox()
        Me.txtusuarioEm = New System.Windows.Forms.TextBox()
        Me.btnGuardarEm = New System.Windows.Forms.Button()
        Me.btnCancelarEm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cedula"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nombre"
        '
        'txtnombreEm
        '
        Me.txtnombreEm.Location = New System.Drawing.Point(115, 14)
        Me.txtnombreEm.Name = "txtnombreEm"
        Me.txtnombreEm.Size = New System.Drawing.Size(122, 20)
        Me.txtnombreEm.TabIndex = 8
        '
        'txtapellidoEm
        '
        Me.txtapellidoEm.Location = New System.Drawing.Point(115, 43)
        Me.txtapellidoEm.Name = "txtapellidoEm"
        Me.txtapellidoEm.Size = New System.Drawing.Size(171, 20)
        Me.txtapellidoEm.TabIndex = 9
        '
        'txtcedulaEm
        '
        Me.txtcedulaEm.Location = New System.Drawing.Point(115, 69)
        Me.txtcedulaEm.Name = "txtcedulaEm"
        Me.txtcedulaEm.Size = New System.Drawing.Size(122, 20)
        Me.txtcedulaEm.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel4)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcasaEm)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcalleEm)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbsector)
        Me.GroupBox1.Controls.Add(Me.cbmunicipio)
        Me.GroupBox1.Controls.Add(Me.cbprovincia)
        Me.GroupBox1.Controls.Add(Me.cbpais)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 168)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(217, 118)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel4.TabIndex = 15
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "New"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(217, 90)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel3.TabIndex = 14
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "New"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(217, 58)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel2.TabIndex = 13
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "New"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(341, 27)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "New"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Casa"
        '
        'txtcasaEm
        '
        Me.txtcasaEm.Location = New System.Drawing.Point(397, 111)
        Me.txtcasaEm.Name = "txtcasaEm"
        Me.txtcasaEm.Size = New System.Drawing.Size(100, 20)
        Me.txtcasaEm.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Calle"
        '
        'txtcalleEm
        '
        Me.txtcalleEm.Location = New System.Drawing.Point(397, 69)
        Me.txtcalleEm.Name = "txtcalleEm"
        Me.txtcalleEm.Size = New System.Drawing.Size(100, 20)
        Me.txtcalleEm.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Sector"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Municipio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Provincia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pais"
        '
        'cbsector
        '
        Me.cbsector.FormattingEnabled = True
        Me.cbsector.Location = New System.Drawing.Point(90, 118)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Size = New System.Drawing.Size(121, 21)
        Me.cbsector.TabIndex = 3
        '
        'cbmunicipio
        '
        Me.cbmunicipio.FormattingEnabled = True
        Me.cbmunicipio.Location = New System.Drawing.Point(90, 87)
        Me.cbmunicipio.Name = "cbmunicipio"
        Me.cbmunicipio.Size = New System.Drawing.Size(121, 21)
        Me.cbmunicipio.TabIndex = 2
        '
        'cbprovincia
        '
        Me.cbprovincia.FormattingEnabled = True
        Me.cbprovincia.Location = New System.Drawing.Point(90, 55)
        Me.cbprovincia.Name = "cbprovincia"
        Me.cbprovincia.Size = New System.Drawing.Size(121, 21)
        Me.cbprovincia.TabIndex = 1
        '
        'cbpais
        '
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(90, 19)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(245, 21)
        Me.cbpais.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Telefono"
        '
        'txttelefonoEm
        '
        Me.txttelefonoEm.Location = New System.Drawing.Point(115, 98)
        Me.txttelefonoEm.Name = "txttelefonoEm"
        Me.txttelefonoEm.Size = New System.Drawing.Size(122, 20)
        Me.txttelefonoEm.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtclaveEm)
        Me.GroupBox2.Controls.Add(Me.txtusuarioEm)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 103)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Usuario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Clave"
        '
        'txtclaveEm
        '
        Me.txtclaveEm.Location = New System.Drawing.Point(87, 56)
        Me.txtclaveEm.Name = "txtclaveEm"
        Me.txtclaveEm.Size = New System.Drawing.Size(100, 20)
        Me.txtclaveEm.TabIndex = 1
        '
        'txtusuarioEm
        '
        Me.txtusuarioEm.Location = New System.Drawing.Point(87, 19)
        Me.txtusuarioEm.Name = "txtusuarioEm"
        Me.txtusuarioEm.Size = New System.Drawing.Size(100, 20)
        Me.txtusuarioEm.TabIndex = 0
        '
        'btnGuardarEm
        '
        Me.btnGuardarEm.Location = New System.Drawing.Point(228, 297)
        Me.btnGuardarEm.Name = "btnGuardarEm"
        Me.btnGuardarEm.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarEm.TabIndex = 16
        Me.btnGuardarEm.Text = "Guardar"
        Me.btnGuardarEm.UseVisualStyleBackColor = True
        '
        'btnCancelarEm
        '
        Me.btnCancelarEm.Location = New System.Drawing.Point(346, 297)
        Me.btnCancelarEm.Name = "btnCancelarEm"
        Me.btnCancelarEm.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarEm.TabIndex = 17
        Me.btnCancelarEm.Text = "Cancelar"
        Me.btnCancelarEm.UseVisualStyleBackColor = True
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 343)
        Me.Controls.Add(Me.btnCancelarEm)
        Me.Controls.Add(Me.btnGuardarEm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txttelefonoEm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtcedulaEm)
        Me.Controls.Add(Me.txtapellidoEm)
        Me.Controls.Add(Me.txtnombreEm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnombreEm As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidoEm As System.Windows.Forms.TextBox
    Friend WithEvents txtcedulaEm As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcasaEm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcalleEm As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbsector As System.Windows.Forms.ComboBox
    Friend WithEvents cbmunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents cbpais As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttelefonoEm As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtclaveEm As System.Windows.Forms.TextBox
    Friend WithEvents txtusuarioEm As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarEm As System.Windows.Forms.Button
    Friend WithEvents btnCancelarEm As System.Windows.Forms.Button
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
