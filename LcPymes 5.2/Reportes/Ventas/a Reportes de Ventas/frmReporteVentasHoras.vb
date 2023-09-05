Public Class frmReporteVentasHoras

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptVentasHoras
        rpt.Refresh()

        rpt.SetParameterValue(0, "REPORTE DE VENTAS BRUTAS DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
        rpt.SetParameterValue(1, 1) 'tipo de cambio
        rpt.SetParameterValue(2, "COLON")
        rpt.SetParameterValue(3, CDate(Me.FechaInicio.Value))
        rpt.SetParameterValue(4, CDate(Me.FechaFinal.Value))
        rpt.SetParameterValue(5, 0) ' caja
        rpt.SetParameterValue(6, Me.dtpDesdeHora.Value)
        rpt.SetParameterValue(7, Me.dtpHastaHora.Value)

        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub


    Private Sub frmReporteVentasHoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
        Me.dtpDesdeHora.Value = Date.Now
        Me.dtpHastaHora.Value = Date.Now
    End Sub

End Class