Public Class frmDetalleApertura

    Private Sub btnBuscarApertura_Click(sender As Object, e As EventArgs) Handles btnBuscarApertura.Click
        Dim Fx As New cFunciones
        Dim Apertura As String

        Apertura = Fx.Buscar_X_Descripcion_Fecha("SELECT NApertura AS Apertura, Nombre, Fecha, num_caja as Caja FROM aperturacaja Order by NApertura Desc", "Nombre", "Fecha", "Buscar Apertura de Caja", CadenaConexionSeePOS)
        If Apertura <> "" Then
            Dim rpt As New rptDetallaApertura
            rpt.SetParameterValue(0, Apertura)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub


    Private Sub frmDetalleApertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class