Public Class frmEntradasAnticipos

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            Dim Reporte As New rptEntradaAnticipo
            Reporte.SetParameterValue(0, Me.dtpDesde.Value)
            Reporte.SetParameterValue(1, Me.dtpHasta.Value)
            CrystalReportsConexion.LoadReportViewer(Me.VisorReporte, Reporte)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub frmEntradasAnticipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.dtpDesde.Value = Date.Now
        Me.dtpHasta.Value = Date.Now
    End Sub
End Class