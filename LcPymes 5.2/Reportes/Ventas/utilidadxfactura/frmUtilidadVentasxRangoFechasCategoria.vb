Public Class frmUtilidadVentasxRangoFechasCategoria

    Private Function FormulaSeleccion() As String
        Return ""
    End Function



    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Categoria As Integer = 0
        If Me.rbGroomer.Checked = True Then Categoria = 1
        If Me.rbTienda.Checked = True Then Categoria = 2
        If Me.rbClinia.Checked = True Then Categoria = 3

        Dim Formula As String = Me.FormulaSeleccion
        Dim rpt As New rptUlitidadesRangoFechaAgenteClinicaCategoria 'rptUlitidadesRangoFechaMensual
        rpt.SetParameterValue(0, Me.dtpDesde.Value)
        rpt.SetParameterValue(1, Me.dtpHasta.Value)
        'rpt.SetParameterValue(2, huber)
        rpt.SetParameterValue(2, Categoria)
        rpt.RecordSelectionFormula = Formula
        CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, rpt, , CadenaConexionSeePOS)
        'Me.CrystalReportViewer1.SelectionFormula = Formula
        CrystalReportViewer1.Show()
    End Sub

    Private Sub frmUtilidadVentasxRangoFechasCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class