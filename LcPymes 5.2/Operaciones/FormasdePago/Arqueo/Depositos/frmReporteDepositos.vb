Public Class frmReporteDepositos

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptDespositos
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub frmReporteDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub
End Class