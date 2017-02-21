Imports System.Drawing.Printing

Module Imprimir
    Public Property prtSettings As Object

    'selecionar impresora 
    Public Function seleccionarImpresora() As Boolean
        Dim prtDialog As New PrintDialog
        If prtSettings Is Nothing Then
            prtSettings = New PrinterSettings
        End If

        With prtDialog
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = True

            .PrinterSettings = prtSettings

            If .ShowDialog() = DialogResult.OK Then
                prtSettings = .PrinterSettings
            Else
                Return False
            End If

        End With

        Return True
    End Function


    'comfiguracion Del papel
    Public Sub print_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 24, FontStyle.Bold)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        ' imprimimos la cadena
        e.Graphics.DrawString("Encabezado", prFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString("Encabezado", prFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString("Encabezado", prFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString("Encabezado", prFont, Brushes.Black, xPos, yPos)


        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminsado de esta propiedad es False)
        e.HasMorePages = False

    End Sub


    Public Declare Function BitBlt Lib "gdi32.dll" Alias "BitBlt" (ByVal _
   hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As _
   Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal _
   hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer,
   ByVal dwRop As System.Int32) As Long
    Public memoryImage As Bitmap

    Public Sub CaptureScreen(Frm As Form)
        Dim mygraphics As Graphics = Frm.CreateGraphics()
        Dim s As Size = Frm.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc
        Dim dc2 As IntPtr = memoryGraphics.GetHdc
        BitBlt(dc2, 0, 0, Frm.ClientRectangle.Width,
           Frm.ClientRectangle.Height, dc1, 0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub

    ' Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object,
    '   ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _
    ' PrintDocument1.PrintPage
    ' e.Graphics.DrawImage(memoryImage, 0, 0)
    'End Sub
    'Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As _
    '  System.EventArgs) Handles PrintButton.Click
    '  CaptureScreen()
    ' PrintDocument1.Print()
    'End Sub

End Module
