Public Class frmReporteArticulosRelacionados

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptArticulosRelacionados
        rpt.Refresh()
        rpt.SetParameterValue(0, Me.cboOpcion.SelectedIndex)
        rpt.SetParameterValue(1, Me.ckPrecios.Checked)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub frmReporteArticulosRelacionados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.cboOpcion.SelectedIndex = 0
    End Sub

End Class