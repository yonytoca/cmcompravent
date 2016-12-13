<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pais
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
        Me.txtnombreP = New System.Windows.Forms.TextBox()
        Me.txtnotaP = New System.Windows.Forms.TextBox()
        Me.btnguardarP = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardarP)
        Me.Panel1.Controls.Add(Me.txtnotaP)
        Me.Panel1.Controls.Add(Me.txtnombreP)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 125)
        Me.Panel1.TabIndex = 0
        '
        'txtnombreP
        '
        Me.txtnombreP.Location = New System.Drawing.Point(64, 19)
        Me.txtnombreP.Name = "txtnombreP"
        Me.txtnombreP.Size = New System.Drawing.Size(92, 20)
        Me.txtnombreP.TabIndex = 0
        '
        'txtnotaP
        '
        Me.txtnotaP.Location = New System.Drawing.Point(65, 50)
        Me.txtnotaP.Name = "txtnotaP"
        Me.txtnotaP.Size = New System.Drawing.Size(137, 20)
        Me.txtnotaP.TabIndex = 1
        '
        'btnguardarP
        '
        Me.btnguardarP.Location = New System.Drawing.Point(69, 82)
        Me.btnguardarP.Name = "btnguardarP"
        Me.btnguardarP.Size = New System.Drawing.Size(53, 31)
        Me.btnguardarP.TabIndex = 2
        Me.btnguardarP.Text = "Guardar"
        Me.btnguardarP.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(149, 82)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(72, 31)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nota"
        '
        'Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 185)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Pais"
        Me.Text = "Pais"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardarP As System.Windows.Forms.Button
    Friend WithEvents txtnotaP As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreP As System.Windows.Forms.TextBox
End Class
