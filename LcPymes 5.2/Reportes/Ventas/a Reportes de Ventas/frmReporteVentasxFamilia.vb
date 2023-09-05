Public Class frmReporteVentasxFamilia

    Private Sub frmReporteVentasxFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
        Me.cboOpcion.SelectedIndex = 0
    End Sub


    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            Select Case Me.cboOpcion.SelectedIndex
                Case 0
                    Dim rpt As New rptFamiliaxFamilia
                    rpt.SetParameterValue(0, Me.FechaInicio.Value)
                    rpt.SetParameterValue(1, Me.FechaFinal.Value)
                    rpt.SetParameterValue(2, Me.cboOpcion.SelectedIndex)
                    CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                    VisorReporte.Show()
                Case 1
                    Dim rpt As New rptFamiliaxFamilia2
                    rpt.SetParameterValue(0, Me.FechaInicio.Value)
                    rpt.SetParameterValue(1, Me.FechaFinal.Value)
                    rpt.SetParameterValue(2, Me.cboOpcion.SelectedIndex)
                    CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                    VisorReporte.Show()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

End Class