<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Provincia
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
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardarPro = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.txtnotaPro = New System.Windows.Forms.TextBox()
        Me.txtnombrePro = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardarPro)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbpais)
        Me.Panel1.Controls.Add(Me.txtnotaPro)
        Me.Panel1.Controls.Add(Me.txtnombrePro)
        Me.Panel1.Location = New System.Drawing.Point(59, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 207)
        Me.Panel1.TabIndex = 0
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(220, 166)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "Button2"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardarPro
        '
        Me.btnguardarPro.Location = New System.Drawing.Point(75, 161)
        Me.btnguardarPro.Name = "btnguardarPro"
        Me.btnguardarPro.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarPro.TabIndex = 6
        Me.btnguardarPro.Text = "Guardar"
        Me.btnguardarPro.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Provincia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pais"
        '
        'cbpais
        '
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(85, 18)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(245, 21)
        Me.cbpais.TabIndex = 2
        '
        'txtnotaPro
        '
        Me.txtnotaPro.Location = New System.Drawing.Point(85, 101)
        Me.txtnotaPro.Name = "txtnotaPro"
        Me.txtnotaPro.Size = New System.Drawing.Size(164, 20)
        Me.txtnotaPro.TabIndex = 1
        '
        'txtnombrePro
        '
        Me.txtnombrePro.Location = New System.Drawing.Point(85, 60)
        Me.txtnombrePro.Name = "txtnombrePro"
        Me.txtnombrePro.Size = New System.Drawing.Size(100, 20)
        Me.txtnombrePro.TabIndex = 0
        '
        'Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 310)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Provincia"
        Me.Text = "Provincia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtnotaPro As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrePro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbpais As System.Windows.Forms.ComboBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardarPro As System.Windows.Forms.Button
End Class
