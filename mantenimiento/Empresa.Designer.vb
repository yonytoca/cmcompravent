<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtslogan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.DgEpresa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgEpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 143)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(23, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Sector"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(23, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Municipio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(23, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Provincia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Slogan"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(93, 61)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(243, 50)
        Me.txtdescripcion.TabIndex = 17
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(93, 30)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(191, 20)
        Me.txtnombre.TabIndex = 18
        '
        'txtslogan
        '
        Me.txtslogan.Location = New System.Drawing.Point(340, 30)
        Me.txtslogan.Name = "txtslogan"
        Me.txtslogan.Size = New System.Drawing.Size(128, 20)
        Me.txtslogan.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(274, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Telefono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(398, 64)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 20)
        Me.txttelefono.TabIndex = 23
        '
        'DgEpresa
        '
        Me.DgEpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEpresa.Location = New System.Drawing.Point(526, 30)
        Me.DgEpresa.Name = "DgEpresa"
        Me.DgEpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgEpresa.Size = New System.Drawing.Size(370, 230)
        Me.DgEpresa.TabIndex = 24
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 320)
        Me.Controls.Add(Me.DgEpresa)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtslogan)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Empresa"
        Me.Text = "Empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgEpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcasaEm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcalleEm As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbsector As ComboBox
    Friend WithEvents cbmunicipio As ComboBox
    Friend WithEvents cbprovincia As ComboBox
    Friend WithEvents cbpais As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtslogan As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents DgEpresa As DataGridView
End Class
