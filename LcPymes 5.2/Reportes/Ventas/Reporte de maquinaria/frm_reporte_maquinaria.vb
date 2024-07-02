Public Class frm_reporte_maquinaria
    Private Katty As Boolean = False

    Public Titulo As String = "Maquinaria"
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
        Me.Text = "Reporte de " & Me.Titulo
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        If Me.ckMes.Checked = False Then
            If Me.Titulo = "Clinica" Then
                Dim rpt As New Reporte_ventas_maquinariaClinica
                rpt.SetParameterValue(0, Me.Katty)
                rpt.SetParameterValue(1, Me.Titulo.ToUpper)
                rpt.SetParameterValue(2, Me.FechaInicio.Value)
                rpt.SetParameterValue(3, Me.FechaFinal.Value)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
            Else
                Dim rpt As New Reporte_ventas_maquinaria
                rpt.SetParameterValue(0, Me.FechaInicio.Value)
                rpt.SetParameterValue(1, Me.FechaFinal.Value)
                rpt.SetParameterValue(2, Me.Katty)
                rpt.SetParameterValue(3, Me.Titulo.ToUpper)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
            End If
        Else
            Dim rpt As New rptMaquinariaMes
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, Me.Katty)
            rpt.SetParameterValue(3, Me.Titulo.ToUpper)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        End If
    End Sub

End Class