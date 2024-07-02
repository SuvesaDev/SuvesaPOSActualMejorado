Imports System.Data
Public Class frmReporteAlbaranSinFacturar

    Private Sub CargarResponsable()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("exec usp_CargarResponsable", dt, CadenaConexionSeePOS)
        Me.cboResponsable.DataSource = dt
        Me.cboResponsable.DisplayMember = "Responsable"
    End Sub

    Private Sub frmReporteAlbaranSinFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarResponsable()
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptAlbaranSinFacturar
        rpt.Refresh()
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        rpt.SetParameterValue(2, Me.cboResponsable.Text)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

End Class