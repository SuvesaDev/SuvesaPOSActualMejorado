Public Class frmReporteSinVentaxFamilia

    Private Sub CargarUbicaciones()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select Codigo, Descripcion from Familia", dt, CadenaConexionSeePOS)
        Me.cboOpcion.DataSource = dt
        Me.cboOpcion.DisplayMember = "Descripcion"
        Me.cboOpcion.ValueMember = "Codigo"
    End Sub

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Try
            Dim rpt As New rptSinVentaxFamilia
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFin.Value)
            rpt.SetParameterValue(2, 1)
            rpt.SetParameterValue(3, Me.cboOpcion.SelectedValue)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FechaInicio.Value = Now.Date
        FechaFin.Value = Now.Date
        Me.cboOpcion.SelectedIndex = 0
        Me.CargarUbicaciones()
        Me.WindowState = FormWindowState.Maximized
    End Sub


End Class