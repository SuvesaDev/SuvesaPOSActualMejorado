Public Class frmReporteSinVenta

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptArticulosSinMovimiento
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFin.Value)
        rpt.SetParameterValue(2, Me.cboOpcion.SelectedIndex)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FechaInicio.Value = Now.Date
        FechaFin.Value = Now.Date
        Me.cboOpcion.SelectedIndex = 0
    End Sub

End Class