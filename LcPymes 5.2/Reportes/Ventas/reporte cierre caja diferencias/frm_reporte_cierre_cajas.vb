Imports System.Data
Imports System.Data.SqlClient
Public Class frm_reporte_cierre_cajas
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection

    Private Sub frm_reporte_cierre_cajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Reporte_cierres_diferencias
        rpt.SetParameterValue(0, Me.FechaInicio.Value)
        rpt.SetParameterValue(1, Me.FechaFinal.Value)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
        VisorReporte.Show()
    End Sub
End Class