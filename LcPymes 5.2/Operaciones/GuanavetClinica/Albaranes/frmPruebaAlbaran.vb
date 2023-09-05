Imports APIQVET
Public Class frmPruebaAlbaran

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dll = New APIQVET.main()
        ''Primer parametros = Nombre Usuario'
        ''Segundo parametros = Tipo 1'
        Dim str = dll.ejecutarAPIQVET("Prueba", "1")
        MsgBox(str.Responses)
    End Sub
End Class