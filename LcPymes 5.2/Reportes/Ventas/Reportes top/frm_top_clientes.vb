Public Class frm_top_clientes
    Private Sub frm_top_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Ventasxproductos_top_clientes

        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
        VisorReporte.Show()
    End Sub
End Class