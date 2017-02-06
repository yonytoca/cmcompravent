Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Lclientes

    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    Private Sub Lclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrarlosdatos(Datos, "select * from persona")
    End Sub

    Private Sub txtBuscarC_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dv.RowFilter = String.Format("nombre like '%{0}%'", txtBuscar.Text)

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        'txtMostrar.Text = Datos.CurrentRow.Cells.Item(0).Value.ToString
    End Sub

    Private Sub Datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellDoubleClick
        txtMostrar.Text = Datos.CurrentRow.Cells.Item(0).Value.ToString
        MDIfactura()
    End Sub
End Class