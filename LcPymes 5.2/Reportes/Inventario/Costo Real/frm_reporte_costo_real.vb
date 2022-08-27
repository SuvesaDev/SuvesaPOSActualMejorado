Public Class frm_reporte_costo_real

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Reporte_costo_real
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
        VisorReporte.Show()
    End Sub

    Private Sub frm_reporte_costo_real_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
    End Sub

    Private Sub VisorReporte_Load(sender As Object, e As EventArgs) Handles VisorReporte.Load

    End Sub
End Class