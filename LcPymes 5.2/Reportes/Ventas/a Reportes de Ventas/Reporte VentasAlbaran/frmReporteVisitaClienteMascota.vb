Public Class frmReporteVisitaClienteMascota

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            'Entre Fechas
            'Por Mascota
            'Por Responsable
            'Por Cliente
            'Por Laboratorio

            Dim Filtro As String = ""
            Select Case Me.cboFiltro.SelectedIndex
                Case 0 'entre fechas
                    Filtro = ""
                Case 1 'por mascotas
                    Filtro = "{uspObtenerviewVentasAlbaran;1.Mascota} like  ""*" & Me.txtOpcion.Text & "*"""
                Case 2 'por responsable
                    Filtro = "{uspObtenerviewVentasAlbaran;1.ResponsableVenta} like  ""*" & Me.txtOpcion.Text & "*"""
                Case 3 'por cliente
                    Filtro = "{uspObtenerviewVentasAlbaran;1.Nombre_Cliente} like  ""*" & Me.txtOpcion.Text & "*"""
                Case 4 'por categoria
                    Filtro = "{uspObtenerviewVentasAlbaran;1.Laboratorio} = True"
            End Select

            Dim rpt As New rptVentasAlbaran
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.RecordSelectionFormula = Filtro
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub frmReporteVisitaClienteMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
        Me.cboFiltro.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltro.SelectedIndexChanged
        Me.txtOpcion.Enabled = True
        If Me.cboFiltro.SelectedIndex = 0 Or Me.cboFiltro.SelectedIndex = 4 Then
            Me.txtOpcion.Text = ""
            Me.txtOpcion.Enabled = False
        End If
    End Sub

End Class