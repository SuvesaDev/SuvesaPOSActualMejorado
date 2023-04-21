Public Class frmReporteVentaSugerida

    Private Sub frmReporteVentaSugerida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptVentaSugerida
        rpt.Refresh()
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub
End Class