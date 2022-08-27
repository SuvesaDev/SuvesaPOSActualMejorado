Public Class frmMetasGeneral

    Private Sub frmMetasGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaFinal.Value = Date.Now
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptMetasGeneral
        rpt.SetParameterValue(0, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub
End Class