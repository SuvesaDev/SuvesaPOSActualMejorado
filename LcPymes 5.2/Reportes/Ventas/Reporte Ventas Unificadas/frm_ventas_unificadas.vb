Public Class frm_ventas_unificadas
    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New VentasUnificadas

        If ck_cliente.Checked = False And ck_tipo.Checked = False Then
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        ElseIf ck_cliente.Checked = False And ck_tipo.Checked = True Then

            If cbo_tipo.Text = "CON" Then
                rpt.RecordSelectionFormula = "{ventas_unidas;1.Tipo} = 'CON' or {ventas_unidas;1.Tipo} = 'MCO' or {ventas_unidas;1.Tipo} = 'TCO' "
            ElseIf cbo_tipo.Text = "CRE" Then
                rpt.RecordSelectionFormula = "{ventas_unidas;1.Tipo} = 'CRE' or {ventas_unidas;1.Tipo} = 'MCR' or {ventas_unidas;1.Tipo} = 'TCR' "
            ElseIf cbo_tipo.Text = "PVE" Then
                rpt.RecordSelectionFormula = "{ventas_unidas;1.Tipo} = 'PVE' "
            End If

            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()

        ElseIf ck_cliente.Checked = True And ck_tipo.Checked = False Then
            rpt.RecordSelectionFormula = "{ventas_unidas;1.Cod_Cliente} = " & Me.txt_cliente.Text
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        ElseIf ck_cliente.Checked = True And ck_tipo.Checked = True Then
            If cbo_tipo.Text = "CON" Then
                rpt.RecordSelectionFormula = "{ventas_unidas;1.Tipo} = 'CON' or {ventas_unidas;1.Tipo} = 'MCO' or {ventas_unidas;1.Tipo} = 'TCO' "
            ElseIf cbo_tipo.Text = "CRE" Then
                rpt.RecordSelectionFormula = "{ventas_unidas;1.Tipo} = 'CRE' or {ventas_unidas;1.Tipo} = 'MCRE' or {ventas_unidas;1.Tipo} = 'TCRE' "
            ElseIf cbo_tipo.Text = "PVE" Then
                rpt.RecordSelectionFormula = "{ventas_unidas;1.Tipo} = 'PVE' "
            End If

            rpt.RecordSelectionFormula = "{ventas_unidas;1.Cod_Cliente} = " & Me.txt_cliente.Text & " and " & "{ventas_unidas;1.Tipo} = '" & Me.cbo_tipo.Text & "'"
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        End If




    End Sub

    Private Sub frm_ventas_unificadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub
End Class