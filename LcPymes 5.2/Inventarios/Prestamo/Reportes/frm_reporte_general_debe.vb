Imports System.Windows.Forms
Imports System.Data
Namespace Prestamos
    Public Class frm_reporte_general_debe
        Public codigo As String
        Private Sub frm_reporte_general_debe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Dim rpt As New reporte_debe
                Dim cr As New Crystal_Reports
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                'rpt.SetParameterValue("id", codigo)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
