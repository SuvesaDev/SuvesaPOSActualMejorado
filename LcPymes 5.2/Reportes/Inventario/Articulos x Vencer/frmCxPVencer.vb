﻿Public Class frmCxPVencer

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim rpt As New rptCxPVence
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.dtpDesde.Value)
            rpt.SetParameterValue(1, Me.dtpHasta.Value)
            CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, rpt, , CadenaConexionSeePOS)
            CrystalReportViewer1.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmArticulosxVencer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.dtpDesde.MinDate = Date.Now
        Me.dtpHasta.MinDate = Date.Now
    End Sub
End Class