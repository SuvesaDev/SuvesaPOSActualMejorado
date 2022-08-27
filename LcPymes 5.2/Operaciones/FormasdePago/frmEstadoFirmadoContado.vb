Public Class frmEstadoFirmadoContado


    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptEstadoContadoFirmado
        rpt.SetParameterValue(0, "0")
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        rpt.SetParameterValue(2, Me.ComboBox1.Text)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
        VisorReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.GroupTree
    End Sub

    Private Sub frmReporteTemperaturaCamara_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        FechaFinal.Value = Now.Date
        Me.ComboBox1.SelectedIndex = 0
    End Sub

End Class