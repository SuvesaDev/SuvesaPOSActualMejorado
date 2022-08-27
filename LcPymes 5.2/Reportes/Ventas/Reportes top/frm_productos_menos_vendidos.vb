Public Class frm_productos_menos_vendidos
    Private Sub frm_productos_menos_vendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
        fulldata()
    End Sub
    Private Sub fulldata()
        'Condiciones
        Me.cbxCondicion.Items.Add("<")
        Me.cbxCondicion.Items.Add(">")
        Me.cbxCondicion.Items.Add("<=")
        Me.cbxCondicion.Items.Add(">=")
        Me.cbxCondicion.Items.Add("<>")
        Me.cbxCondicion.Items.Add("=")
        'Llena moneda
    End Sub
    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Ventasxproductos_top_20_menos_vendidos
        If ComboBox2.SelectedIndex = 0 Then
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        Else
            rpt.RecordSelectionFormula = "{reporte_producto_menos_vendido;1.total} " & Me.cbxCondicion.Text & " " & txtCantidad.Text
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 1 Then
            txtCantidad.Visible = True
            cbxCondicion.Visible = True
        End If
        If ComboBox2.SelectedIndex = 0 Then
            txtCantidad.Visible = False
            cbxCondicion.Visible = False
        End If
    End Sub
End Class