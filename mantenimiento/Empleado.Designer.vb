﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.btnGuardarEm = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tpersona2 = New System.Windows.Forms.RadioButton()
        Me.Tpersona1 = New System.Windows.Forms.RadioButton()
        Me.Tpersona = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Dgpersona = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgpersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtnombreEm
        '
        resources.ApplyResources(Me.txtnombreEm, "txtnombreEm")
        Me.txtnombreEm.Name = "txtnombreEm"
        '
        'txtapellidoEm
        '
        resources.ApplyResources(Me.txtapellidoEm, "txtapellidoEm")
        Me.txtapellidoEm.Name = "txtapellidoEm"
        '
        'txtcedulaEm
        '
        resources.ApplyResources(Me.txtcedulaEm, "txtcedulaEm")
        Me.txtcedulaEm.Name = "txtcedulaEm"
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
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel4
        '
        resources.ApplyResources(Me.LinkLabel4, "LinkLabel4")
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.TabStop = True
        '
        'LinkLabel3
        '
        resources.ApplyResources(Me.LinkLabel3, "LinkLabel3")
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.TabStop = True
        '
        'LinkLabel2
        '
        resources.ApplyResources(Me.LinkLabel2, "LinkLabel2")
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.TabStop = True
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtcasaEm
        '
        resources.ApplyResources(Me.txtcasaEm, "txtcasaEm")
        Me.txtcasaEm.Name = "txtcasaEm"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtcalleEm
        '
        resources.ApplyResources(Me.txtcalleEm, "txtcalleEm")
        Me.txtcalleEm.Name = "txtcalleEm"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'cbsector
        '
        Me.cbsector.FormattingEnabled = True
        resources.ApplyResources(Me.cbsector, "cbsector")
        Me.cbsector.Name = "cbsector"
        '
        'cbmunicipio
        '
        Me.cbmunicipio.FormattingEnabled = True
        resources.ApplyResources(Me.cbmunicipio, "cbmunicipio")
        Me.cbmunicipio.Name = "cbmunicipio"
        '
        'cbprovincia
        '
        Me.cbprovincia.FormattingEnabled = True
        resources.ApplyResources(Me.cbprovincia, "cbprovincia")
        Me.cbprovincia.Name = "cbprovincia"
        '
        'cbpais
        '
        Me.cbpais.FormattingEnabled = True
        resources.ApplyResources(Me.cbpais, "cbpais")
        Me.cbpais.Name = "cbpais"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txttelefonoEm
        '
        resources.ApplyResources(Me.txttelefonoEm, "txttelefonoEm")
        Me.txttelefonoEm.Name = "txttelefonoEm"
        '
        'btnGuardarEm
        '
        resources.ApplyResources(Me.btnGuardarEm, "btnGuardarEm")
        Me.btnGuardarEm.Name = "btnGuardarEm"
        Me.btnGuardarEm.UseVisualStyleBackColor = True
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'cbTipoTelefono
        '
        Me.cbTipoTelefono.FormattingEnabled = True
        resources.ApplyResources(Me.cbTipoTelefono, "cbTipoTelefono")
        Me.cbTipoTelefono.Name = "cbTipoTelefono"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tpersona2)
        Me.GroupBox2.Controls.Add(Me.Tpersona1)
        Me.GroupBox2.Controls.Add(Me.Tpersona)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Tpersona2
        '
        resources.ApplyResources(Me.Tpersona2, "Tpersona2")
        Me.Tpersona2.Name = "Tpersona2"
        Me.Tpersona2.TabStop = True
        Me.Tpersona2.UseVisualStyleBackColor = True
        '
        'Tpersona1
        '
        resources.ApplyResources(Me.Tpersona1, "Tpersona1")
        Me.Tpersona1.Name = "Tpersona1"
        Me.Tpersona1.TabStop = True
        Me.Tpersona1.UseVisualStyleBackColor = True
        '
        'Tpersona
        '
        resources.ApplyResources(Me.Tpersona, "Tpersona")
        Me.Tpersona.Name = "Tpersona"
        Me.Tpersona.TabStop = True
        Me.Tpersona.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dgpersona
        '
        Me.Dgpersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.Dgpersona, "Dgpersona")
        Me.Dgpersona.Name = "Dgpersona"
        Me.Dgpersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Empleado
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Dgpersona)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbTipoTelefono)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnGuardarEm)
        Me.Controls.Add(Me.txttelefonoEm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtcedulaEm)
        Me.Controls.Add(Me.txtapellidoEm)
        Me.Controls.Add(Me.txtnombreEm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Empleado"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dgpersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents btnGuardarEm As System.Windows.Forms.Button
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbTipoTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Tpersona2 As RadioButton
    Friend WithEvents Tpersona1 As RadioButton
    Friend WithEvents Tpersona As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Dgpersona As DataGridView
End Class
