Module Limpiarcampos
    Sub LimpiarVariables(ByRef Frm As Form)
        Dim Text As Object
        For Each Text In Frm.Controls
            If TypeOf Text Is TextBox Then
                Dim txtTempo As TextBox = CType(Text, TextBox)
                txtTempo.Text = ""
            End If
        Next
    End Sub
End Module
