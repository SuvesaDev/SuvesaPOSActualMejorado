Public Class frmConsultaLaboratorio

    Private Sub frmConsultaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now

    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try

            If Me.rbPorEstado.Checked = True Then
                Dim rpt As New rptLaboratorio
                rpt.SetParameterValue(0, Me.FechaInicio.Value)
                rpt.SetParameterValue(1, Me.FechaFinal.Value)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            End If

            If Me.rbPorBitacora.Checked = True Then
                Dim rpt As New rptBitacoraLaboratorio
                rpt.SetParameterValue(0, Me.FechaInicio.Value)
                rpt.SetParameterValue(1, Me.FechaFinal.Value)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class