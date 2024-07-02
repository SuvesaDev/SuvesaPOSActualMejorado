Public Class frmReporteMasVendidosxUsuario

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim frm As New frmGenerarReporteMasVendidosxUsuario
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rpt As New rptUsuarioMasVendio
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, My.Computer.Name)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub frmReporteMasVendidosxUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
    End Sub

End Class