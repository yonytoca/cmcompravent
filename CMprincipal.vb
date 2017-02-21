Imports System.Windows.Forms

Public Class CMprincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
    Public Sub Control()
        Dim Usu As String = Login.ScrollStateUserHasScrolled
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click

    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDIusuario()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDIproveedor()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDIempleado()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

    End Sub

    Private Sub CMprincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MDIfactura()
    End Sub


    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        MDIempleado()
    End Sub

    Private Sub UsuarioToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem2.Click
        MDIusuario()
    End Sub

    Private Sub PaisToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem1.Click
        MDIpais()
    End Sub

    Private Sub ProvinciaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProvinciaToolStripMenuItem1.Click
        MDIprovincia()
    End Sub

    Private Sub MunicipioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MunicipioToolStripMenuItem1.Click
        MDImunicipio()
    End Sub

    Private Sub SectorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SectorToolStripMenuItem1.Click
        MDIsector()
    End Sub

    Private Sub TipoTeléfonoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoTeléfonoToolStripMenuItem.Click
        MDItipotelefono()
    End Sub

    Private Sub EmpresaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem2.Click
        MDIempresa()
    End Sub

    Private Sub CMprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "CM-Systems Se ha Autentificado como:  " & Login.txtUsuario.Text
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        MDIproducto()
    End Sub
End Class
