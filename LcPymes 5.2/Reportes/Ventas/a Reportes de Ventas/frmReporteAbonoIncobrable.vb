Public Class frmReporteAbonoIncobrable

    Private Sub frmReporteAbonoIncobrable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
    End Sub



    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptAbonoIncobrables
        rpt.Refresh()
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

End Class