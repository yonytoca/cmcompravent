Imports MySql.Data.MySqlClient
Public Class Login
    'declaracion de variable  
    Dim Sql As String 'valieble para query
    Dim Consulta As MySqlDataAdapter 'variable de consulta a BD
    Dim Usuario, Clave As String 'variable de asceso
    Dim i As Integer
    Dim Datos As DataSet
    Dim Lista As Byte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntrar.Click
        Login()
        CMprincipal.Show()
        Me.Hide()
    End Sub
    Private Sub Login()
        Usuario = txtUsuario.Text
        Clave = txtClave.Text

        If Usuario <> "" And Clave <> "" Then
            Sql = "select * from usuario where usuario='" & Usuario & "'and clave='" & Clave & "'"
            Consulta = New MySqlDataAdapter(Sql, Conex)
            Datos = New DataSet
            Consulta.Fill(Datos, "usuario")
            Lista = Datos.Tables("usuario").Rows.Count
        End If
        If Lista <> 0 Then
            CMprincipal.Show()
            Me.Hide()
        Else
            ' MsgBox("Incorrecto")
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conectar()

    End Sub


    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        End
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged

    End Sub

    Private Sub txtClave_Enter(sender As Object, e As EventArgs) Handles txtClave.Enter

    End Sub
End Class
