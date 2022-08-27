Public Class NotificacionesFE
    Private CantidadMaximaPendiente As Decimal = 30
    Private CantidadMaximaRechazo As Decimal = 15

    Private Sub Revisar_envio_FE()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select BasedeDatos, TipoDoc, Tipo, EstadoMH, COUNT(*) as Cantidad from " & TablaSeguridad() & ".dbo.viewFacturas where EstadoMH = 'pendiente' group by BasedeDatos, TipoDoc, Tipo, EstadoMH", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then

        End If
    End Sub

End Class
