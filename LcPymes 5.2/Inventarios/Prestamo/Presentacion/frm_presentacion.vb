Namespace Prestamos
    Public NotInheritable Class frm_presentacion
        Public contador As Integer
        'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
        '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


        Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


            'Información de Copyright
            Copyright.Text = My.Application.Info.Copyright
        End Sub

        Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
            ProgressBar1.Value = 0.0
            ProgressBar1.Maximum = 100
            Timer1.Interval = 3
            Timer1.Enabled = True
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If contador < 100 Then
                ProgressBar1.Value = contador
                contador = contador + 1
                lbcargar.Text = "Cargando %" & contador
            Else
                Timer1.Enabled = False
                Me.Hide()
                frm_prestamos.Show()
            End If
        End Sub

    End Class

End Namespace
