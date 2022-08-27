Public Class frmCxCVencer

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim rpt As New rptCxCVence
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

    Private Sub ckIncobrables_CheckedChanged(sender As Object, e As EventArgs) Handles ckIncobrables.CheckedChanged
        If Me.ckIncobrables.Checked = True Then
            Me.dtpDesde.MinDate = CDate("01/10/2014")
            Me.dtpHasta.MinDate = CDate("01/10/2014")

            Me.dtpDesde.Value = CDate("01/01/2015")
            Me.dtpHasta.Value = Date.Now.AddYears(-1)

            Me.dtpDesde.Enabled = False
            Me.dtpHasta.Enabled = False
        Else
            Me.dtpDesde.MinDate = Date.Now
            Me.dtpHasta.MinDate = Date.Now
            Me.dtpDesde.Enabled = True
            Me.dtpHasta.Enabled = True
        End If
    End Sub
End Class