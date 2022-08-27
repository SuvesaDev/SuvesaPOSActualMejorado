Public Class frmHistoricoSerie

    Private IdSerie As String = "0"

    Private Sub btnBuscarSerie_Click(sender As Object, e As EventArgs) Handles btnBuscarSerie.Click
        Dim frm As New frmBuscarSerie
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.IdSerie = frm.viewDatos.Item("Id", frm.viewDatos.CurrentRow.Index).Value
            Me.txtSerie.Text = frm.viewDatos.Item("Serie", frm.viewDatos.CurrentRow.Index).Value
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If Me.txtSerie.Text <> "" Then
            Dim rpt As New rptHistoricoxSerie
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.IdSerie)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub frmHistoricoSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class