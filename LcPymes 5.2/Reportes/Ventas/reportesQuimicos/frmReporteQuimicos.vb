Public Class frmReporteQuimicos


    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New reporteparaquimicos
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub FrmReporte_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

End Class