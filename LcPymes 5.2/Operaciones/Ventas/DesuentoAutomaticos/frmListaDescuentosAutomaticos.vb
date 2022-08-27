Public Class frmListaDescuentosAutomaticos

    Private Sub frmListaDescuentosAutomaticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New rptDescuento_Automaticos
        rpt.Refresh()
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Refresh()
        VisorReporte.Show()
    End Sub

End Class