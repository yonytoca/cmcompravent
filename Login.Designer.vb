<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.cmdEntrar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(135, 62)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(157, 15)
        Me.txtUsuario.TabIndex = 2
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(134, 103)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(158, 15)
        Me.txtClave.TabIndex = 3
        Me.txtClave.UseSystemPasswordChar = True
        '
        'cmdEntrar
        '
        Me.cmdEntrar.Location = New System.Drawing.Point(131, 136)
        Me.cmdEntrar.Name = "cmdEntrar"
        Me.cmdEntrar.Size = New System.Drawing.Size(66, 29)
        Me.cmdEntrar.TabIndex = 4
        Me.cmdEntrar.Text = "Entrar"
        Me.cmdEntrar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(215, 136)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 28)
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.compravent.My.Resources.Resources.fondo_login1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(399, 207)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdEntrar)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents cmdEntrar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button

End Class
