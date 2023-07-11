Public Class frmIncobrableGeneral

    Private Sub frmIncobrableGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboTipo.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Select Case Me.cboTipo.SelectedIndex
            Case 0
                Dim rpt As New rptIncobrableGeneral
                rpt.Refresh()
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            Case 1
                Dim rpt As New rptIncobrableEntreFechas
                rpt.Refresh()
                rpt.SetParameterValue(0, Me.dtpDesde.Value)
                rpt.SetParameterValue(1, Me.dtpHasta.Value)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
        End Select
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.SelectedIndex = 1 Then
            Me.dtpDesde.Enabled = True
            Me.dtpHasta.Enabled = True
        Else
            Me.dtpDesde.Enabled = False
            Me.dtpHasta.Enabled = False
        End If
    End Sub

End Class