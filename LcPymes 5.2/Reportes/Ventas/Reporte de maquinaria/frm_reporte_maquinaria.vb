Public Class frm_reporte_maquinaria
    Private Katty As Boolean = False
    Private Sub esKatty()

        Dim katty As String = ""
        katty = GetSetting("SeeSOFT", "SeePOS", "Katty")

        If katty = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "Katty", "0")
            katty = 0
        End If

        If katty = "1" Then 'si es katty
            'Cambia las descripciones
            Me.Katty = True
            Me.Text = "Reporte de Correas"
        Else 'de lo contrario
            'todo queda normal
            Me.Katty = False
        End If
    End Sub
    Private Sub frm_reporte_maquinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.esKatty()
        SqlConnection1.ConnectionString = CadenaConexionSeePOS()
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Reporte_ventas_maquinaria
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        rpt.SetParameterValue(2, Me.Katty)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
        VisorReporte.Show()
    End Sub

End Class