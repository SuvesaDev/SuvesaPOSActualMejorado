Public Class frmReportesOT

    Private Sub frmReportesOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboReporte.SelectedIndex = 0
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Select Case Me.cboReporte.SelectedIndex
            Case 0
                'abiertas
                Dim rpt As New rptOTAbiertas
                rpt.Refresh()
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            Case 1
                'seguimieto
                Dim rpt As New rptVisitaxSerie
                rpt.Refresh()
                rpt.SetParameterValue(0, Me.txtSerie.Text)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
        End Select
    End Sub

    Private Sub cboReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReporte.SelectedIndexChanged
        Select Case Me.cboReporte.SelectedIndex
            Case 0
                Me.lblSerie.Visible = False
                Me.txtSerie.Visible = False
                Me.txtSerie.Text = ""
            Case 1
                Me.lblSerie.Visible = True
                Me.txtSerie.Visible = True
        End Select
    End Sub
End Class