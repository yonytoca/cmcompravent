Module Calculos
    Public Function totalF(ByVal Precio, ByVal Cantidad, ByVal Desc)
        Dim Total As Double
        Dim Desc1 As Double
        Dim A As Double
        A = (Cantidad * Precio)
        Desc1 = (A * Desc) / 100
        Total = A - Desc1
        Return Total
    End Function

    Public Function Sumar(ByVal Columna As String, ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(Columna.ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function

End Module

