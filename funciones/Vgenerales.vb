Module Vgenerales

    'completar ceros a la iZquierda
    Public Function pone_ceros(F As Integer)

        Dim A As String
        Dim B, i As Integer
        A = F
        B = 10 - Len(A) ' sacamos el n de ceros
        For i = 1 To B
            A = "0" + A ' añadimos Ceros
        Next
        Return A
    End Function

    'Dim fecha As DateTime = DateTime.Now
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function
    'en el evnto keypres del texboxt
    Function SoloNumero(KeyAscii As Integer) As Boolean
        If Not (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 127 Or KeyAscii = 8) Then
            KeyAscii = 0
            ' El 48 es 0 y el 57 es 9, 127 es SUPR y 8 es Backspace
            MsgBox("Ingrese solo números por favor")
        End If
        Return SoloNumero
    End Function

End Module
