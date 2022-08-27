Imports System.Windows.Forms
Imports System.Data
Namespace Prestamos
    Public Class frm_reporte
        Private Sub frm_reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            llenar_empresas()
        End Sub

        Sub llenar_empresas()
            Try
                Dim func As New fempresas
                Dim dt As DataTable = func.mostrar

                Me.cbo_empresa.DataSource = dt
                Me.cbo_empresa.DisplayMember = "empresa"
                Me.cbo_empresa.ValueMember = "id"

                Me.cbo_empresa2.DataSource = dt
                Me.cbo_empresa2.DisplayMember = "empresa"
                Me.cbo_empresa2.ValueMember = "id"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Try
                Dim rpt As New reporte_debe_empresa
                Dim cr As New Crystal_Reports
                rpt.Refresh()
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                rpt.SetParameterValue("empresa", cbo_empresa.SelectedValue)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            Try
                Dim rpt As New reporte_debo_empresa
                Dim cr As New Crystal_Reports
                rpt.Refresh()
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                rpt.SetParameterValue("empresa", cbo_empresa.SelectedValue)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Try
                Dim rpt As New reporte_debo
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
