Public Class frmCxCEntreFechas

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptCxCentreFechas
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        If Me.ckSoloPendientes.Checked = True Then
            rpt.RecordSelectionFormula = "{usp_CxC_EntreFecha;1.Saldo} > 1"
        Else
            rpt.RecordSelectionFormula = "{usp_CxC_EntreFecha;1.Saldo} >= 0"
        End If
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub frmReporteProductosRentalbes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

End Class