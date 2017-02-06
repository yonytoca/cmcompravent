<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lclientes
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.txtMostrar = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de Clientes "
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(12, 66)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(181, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'Datos
        '
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Location = New System.Drawing.Point(12, 102)
        Me.Datos.Name = "Datos"
        Me.Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datos.Size = New System.Drawing.Size(615, 176)
        Me.Datos.TabIndex = 3
        '
        'txtMostrar
        '
        Me.txtMostrar.AutoSize = True
        Me.txtMostrar.Location = New System.Drawing.Point(256, 66)
        Me.txtMostrar.Name = "txtMostrar"
        Me.txtMostrar.Size = New System.Drawing.Size(39, 13)
        Me.txtMostrar.TabIndex = 4
        Me.txtMostrar.Text = "Label2"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(472, 64)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Lclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 318)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtMostrar)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Lclientes"
        Me.Text = "Lclientes"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents txtMostrar As Label
    Friend WithEvents btnMostrar As Button
End Class
