<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Municipio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbprovinciaMc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelarMc = New System.Windows.Forms.Button()
        Me.btnguardarMc = New System.Windows.Forms.Button()
        Me.txtnombreMc = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbprovinciaMc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btncancelarMc)
        Me.Panel1.Controls.Add(Me.btnguardarMc)
        Me.Panel1.Controls.Add(Me.txtnombreMc)
        Me.Panel1.Location = New System.Drawing.Point(12, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 200)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Provincia"
        '
        'cbprovinciaMc
        '
        Me.cbprovinciaMc.FormattingEnabled = True
        Me.cbprovinciaMc.Location = New System.Drawing.Point(91, 20)
        Me.cbprovinciaMc.Name = "cbprovinciaMc"
        Me.cbprovinciaMc.Size = New System.Drawing.Size(245, 21)
        Me.cbprovinciaMc.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Municipio"
        '
        'btncancelarMc
        '
        Me.btncancelarMc.Location = New System.Drawing.Point(163, 123)
        Me.btncancelarMc.Name = "btncancelarMc"
        Me.btncancelarMc.Size = New System.Drawing.Size(72, 31)
        Me.btncancelarMc.TabIndex = 3
        Me.btncancelarMc.Text = "Cancelar"
        Me.btncancelarMc.UseVisualStyleBackColor = True
        '
        'btnguardarMc
        '
        Me.btnguardarMc.Location = New System.Drawing.Point(83, 123)
        Me.btnguardarMc.Name = "btnguardarMc"
        Me.btnguardarMc.Size = New System.Drawing.Size(53, 31)
        Me.btnguardarMc.TabIndex = 2
        Me.btnguardarMc.Text = "Guardar"
        Me.btnguardarMc.UseVisualStyleBackColor = True
        '
        'txtnombreMc
        '
        Me.txtnombreMc.Location = New System.Drawing.Point(91, 60)
        Me.txtnombreMc.Name = "txtnombreMc"
        Me.txtnombreMc.Size = New System.Drawing.Size(92, 20)
        Me.txtnombreMc.TabIndex = 0
        '
        'Municipio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 251)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Municipio"
        Me.Text = "Municipio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancelarMc As System.Windows.Forms.Button
    Friend WithEvents btnguardarMc As System.Windows.Forms.Button
    Friend WithEvents txtnombreMc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbprovinciaMc As System.Windows.Forms.ComboBox
End Class
