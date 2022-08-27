Imports System.Data
Public Class frmGraficoVentasAnuales
    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        If Me.cboTipo.SelectedIndex = 0 Then
            Dim rpt As New rptGraficoVentasAnuales
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value.Year)
            rpt.SetParameterValue(1, Me.FechaFinal.Value.Year)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()

        ElseIf Me.cboTipo.SelectedIndex = 1 Then
            Dim rpt As New rptReporteMensual
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
        
    End Sub


    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        Me.cboTipo.SelectedIndex = 0
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If Me.cboTipo.SelectedIndex = 0 Then
            Me.FechaFinal.CustomFormat = "yyyy"
            Me.FechaInicio.CustomFormat = "yyyy"
        ElseIf Me.cboTipo.SelectedIndex = 1 Then
            Me.FechaFinal.CustomFormat = "dd/MM/yyyy"
            Me.FechaInicio.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub
End Class