Public Class frmSaldosAnticiposActual

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            Dim Reporte As New rptSaldosPrepago
            Reporte.Refresh()
            CrystalReportsConexion.LoadReportViewer(Me.VisorReporte, Reporte)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub frmSaldosAnticiposActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class