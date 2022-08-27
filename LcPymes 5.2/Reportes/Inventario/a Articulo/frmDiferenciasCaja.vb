Public Class frmDiferenciasCaja
    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptReporteCaja
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        rpt.SetParameterValue(2, Me.ComboBox1.SelectedIndex)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
        Me.ComboBox1.SelectedIndex = 0
    End Sub
End Class