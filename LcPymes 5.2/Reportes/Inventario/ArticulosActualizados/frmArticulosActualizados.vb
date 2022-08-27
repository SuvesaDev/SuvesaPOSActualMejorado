Public Class frmArticulosActualizados

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptActualizados
        rpt.SetParameterValue(0, Me.ComboBox1.SelectedIndex)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub


    Private Sub frmArticulosActualizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.SelectedIndex = 0
    End Sub
End Class
