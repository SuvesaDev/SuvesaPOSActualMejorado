Public Class frmReporteServiciosVendidos

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptServiciosVendidos
        rpt.Refresh()
        rpt.SetParameterValue(0, Me.dtpDesde.Value)
        rpt.SetParameterValue(1, Me.dtpHasta.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub frmReporteServiciosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class