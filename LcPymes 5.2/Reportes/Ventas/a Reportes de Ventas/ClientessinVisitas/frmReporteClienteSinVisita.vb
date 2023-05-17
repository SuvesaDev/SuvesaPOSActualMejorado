Public Class frmReporteClienteSinVisita

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        If IsNumeric(Me.txtVentas.Text) Then
            Dim rpt As New rptClientesSinVenta
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.txtVentas.Text)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        FechaInicio.Value = Now.Date        
    End Sub
End Class