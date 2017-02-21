<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaRpt
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.EFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EFacturaBindingSource
        '
        Me.EFacturaBindingSource.DataSource = GetType(compravent.EFactura)
        '
        'EArticuloBindingSource
        '
        Me.EArticuloBindingSource.DataSource = GetType(compravent.EArticulo)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Encabezado"
        ReportDataSource1.Value = Me.EFacturaBindingSource
        ReportDataSource2.Name = "Detalles1"
        ReportDataSource2.Value = Me.EArticuloBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "compravent.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(778, 269)
        Me.ReportViewer1.TabIndex = 0
        '
        'FacturaRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 269)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FacturaRpt"
        Me.Text = "FacturaRpt"
        CType(Me.EFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EFacturaBindingSource As BindingSource
    Friend WithEvents EArticuloBindingSource As BindingSource
End Class
