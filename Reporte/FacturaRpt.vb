Imports Microsoft.Reporting.WinForms
Public Class FacturaRpt
    '
    'Cree dos listas una para el Encabezado y otra para el detalle
    '
    Public Invoice As New List(Of EFactura)()
    Public Detail As New List(Of EArticulo)()
    '
    'Cree las propiedades publicas Titulo y Empresa
    '
    Public Property Titulo() As String '= "Juna1"
    Public Property Empresa() As String '= "juan2"
    Private Sub FacturaRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '
        'Establezcamos los parametros que enviaremos al reporte
        'recuerde que son dos para el titulo del reporte y para el nombre de la empresa
        '
        Dim parameters As ReportParameter() = New ReportParameter(1) {}
        parameters(0) = New ReportParameter("ParametroTitulo", Titulo)
        parameters(1) = New ReportParameter("ParameterEmpresa", Empresa)

        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Invoice))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))

        '
        'Enviemos la lista de parametros
        '
        ReportViewer1.LocalReport.SetParameters(parameters)
        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer1.RefreshReport()

    End Sub
End Class