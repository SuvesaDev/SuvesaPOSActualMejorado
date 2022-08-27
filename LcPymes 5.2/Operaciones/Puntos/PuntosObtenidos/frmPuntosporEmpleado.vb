Public Class frmPuntosporEmpleado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New rptPuntosObtenidos
        rpt.Refresh()
        rpt.SetParameterValue(0, Me.dtpDesde.Value)
        rpt.SetParameterValue(1, Me.dtpHasta.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub frmPuntosporEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class