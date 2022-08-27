Imports System.Windows.Forms
Imports System.Data
Namespace Prestamos
    Public Class frm_visor
        Public codigo06082018test As String

        Private Sub frm_visor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Dim rpt As New Reporte_prestamo
                Dim cr As New Crystal_Reports
                cr.LoadReportViewer(rptVisor, rpt, , CadenaConexionSeePOS)
                rpt.SetParameterValue("id", codigo06082018test)
                rptVisor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

End Namespace
