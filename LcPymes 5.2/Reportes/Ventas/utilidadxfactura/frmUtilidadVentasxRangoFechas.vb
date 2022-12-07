Imports System.Data
Public Class frmUtilidadVentasxRangoFechas

    Private Function FormulaSeleccion() As String
        Dim ResultadoAgente As String = ""
        Dim ResultadoCliente As String = ""
        Dim ResultadoFinal As String

        If Me.ckFiltrarAgente.Checked = False Then
            ResultadoAgente = ""
        Else
            Dim selected As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewAgentes.Rows Where x.Cells("cMarcarAgente").Value = True).ToList
            If selected.Count > 0 Then
                ResultadoAgente = ""
                If Me.rbMostrarAgente.Checked = True Then
                    ResultadoAgente = "{spDesmenuzarFactura;1.cod_agente} in(["
                    For i As Integer = 0 To selected.Count - 1
                        If i = 0 Then
                            ResultadoAgente += selected(i).Cells("cIdAgente").Value.ToString
                        Else
                            ResultadoAgente += "," & selected(i).Cells("cIdAgente").Value.ToString
                        End If
                    Next
                    ResultadoAgente += "])"
                Else
                    ResultadoAgente = "not({spDesmenuzarFactura;1.cod_agente} in(["
                    For i As Integer = 0 To selected.Count - 1
                        If i = 0 Then
                            ResultadoAgente += selected(i).Cells("cIdAgente").Value.ToString
                        Else
                            ResultadoAgente += "," & selected(i).Cells("cIdAgente").Value.ToString
                        End If
                    Next
                    ResultadoAgente += "]))"
                End If                
            Else
                ResultadoAgente = ""
            End If
        End If

        'WMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMW

        If Me.ckFiltrarCliente.Checked = False Then
            ResultadoCliente = ""
        Else
            Dim selected As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewClientes.Rows Where x.Cells("cMarcarCliente").Value = True).ToList
            If selected.Count > 0 Then
                ResultadoCliente = ""
                If Me.rbMostrarCliente.Checked = True Then
                    ResultadoCliente = "{spDesmenuzarFactura;1.Cod_Cliente} in(["
                    For i As Integer = 0 To selected.Count - 1
                        If i = 0 Then
                            ResultadoCliente += selected(i).Cells("cIdCliente").Value.ToString
                        Else
                            ResultadoCliente += "," & selected(i).Cells("cIdCliente").Value.ToString
                        End If
                    Next
                    ResultadoCliente += "])"
                Else
                    ResultadoCliente = "not({spDesmenuzarFactura;1.Cod_Cliente} in(["
                    For i As Integer = 0 To selected.Count - 1
                        If i = 0 Then
                            ResultadoCliente += selected(i).Cells("cIdCliente").Value.ToString
                        Else
                            ResultadoCliente += "," & selected(i).Cells("cIdCliente").Value.ToString
                        End If
                    Next
                    ResultadoCliente += "]))"
                End If
            Else
                ResultadoCliente = ""
            End If
        End If

        If SplitContainer1.Panel1Collapsed = False Then
            Return ResultadoAgente
        Else
            Return ResultadoCliente
        End If

    End Function


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim huber As Boolean = False
            If Me.SplitContainer1.Panel2Collapsed = True And Me.ckFiltrarAgente.Checked = True And Me.rbMostrarAgente.Checked = True Then
                'mensual
                For Each fila As DataGridViewRow In Me.viewAgentes.Rows
                    If fila.Cells("cIdAgente").Value = 8 Then
                        huber = fila.Cells("cMarcarAgente").Value
                    End If
                Next

                Dim Formula As String = Me.FormulaSeleccion
                Dim rpt As New rptUlitidadesRangoFechaMensual
                rpt.SetParameterValue(0, Me.dtpDesde.Value)
                rpt.SetParameterValue(1, Me.dtpHasta.Value)
                rpt.SetParameterValue(2, huber)
                rpt.SetParameterValue(3, Me.ckSoloServicios.Checked)
                rpt.RecordSelectionFormula = Formula
                CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, rpt, , CadenaConexionSeePOS)
                'Me.CrystalReportViewer1.SelectionFormula = Formula
                CrystalReportViewer1.Show()

            Else
                'normal
                Dim Formula As String = Me.FormulaSeleccion
                Dim rpt As New rptUlitidadesRangoFecha
                rpt.SetParameterValue(0, Me.dtpDesde.Value)
                rpt.SetParameterValue(1, Me.dtpHasta.Value)
                rpt.SetParameterValue(2, Me.ckSoloServicios.Checked)
                'rpt.SetParameterValue(2, huber)
                rpt.RecordSelectionFormula = Formula
                CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, rpt, , CadenaConexionSeePOS)
                'Me.CrystalReportViewer1.SelectionFormula = Formula
                CrystalReportViewer1.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarAgentes()
        Dim Index As Integer = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select id, nombre from agente_ventas where activo = 1", dt, CadenaConexionSeePOS)
        Me.viewAgentes.Rows.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            Me.viewAgentes.Rows.Add()
            Me.viewAgentes.Item("cIdAgente", Index).Value = dt.Rows(i).Item("id")
            Me.viewAgentes.Item("cMarcarAgente", Index).Value = False
            Me.viewAgentes.Item("cAgente", Index).Value = dt.Rows(i).Item("nombre")
            Index += 1
        Next
    End Sub

    Private Sub frmUtilidadVentasxRangoFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.CargarAgentes()
        Me.MostrarFiltrosAgentes()
    End Sub

    Private Sub ckFiltrarAgente_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarAgente.CheckedChanged
        Me.rbMostrarAgente.Enabled = Me.ckFiltrarAgente.Checked
        Me.rbExcluirAgente.Enabled = Me.ckFiltrarAgente.Checked
        Me.viewAgentes.Enabled = Me.ckFiltrarAgente.Checked
        For Each r As DataGridViewRow In Me.viewAgentes.Rows
            r.Cells("cMarcarAgente").Value = False
        Next
    End Sub

    Private Sub MostrarFiltrosAgentes()
        SplitContainer1.Panel2Collapsed = True
        SplitContainer1.Panel1Collapsed = False
    End Sub

    Private Sub MostrarFiltrosClientes()
        SplitContainer1.Panel2Collapsed = False
        SplitContainer1.Panel1Collapsed = True
    End Sub

    Private Sub btnAgente_Click(sender As Object, e As EventArgs) Handles btnAgente.Click
        Me.MostrarFiltrosAgentes()
        Me.ckFiltrarCliente.Checked = False
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Me.MostrarFiltrosClientes()
        Me.ckFiltrarAgente.Checked = False
    End Sub

    Private Sub ckFiltrarCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarCliente.CheckedChanged
        Me.rbMostrarCliente.Enabled = Me.ckFiltrarCliente.Checked
        Me.rbExcluirCliente.Enabled = Me.ckFiltrarCliente.Checked
        Me.btnBuscarCliente.Enabled = Me.ckFiltrarCliente.Checked
        Me.viewClientes.Enabled = Me.ckFiltrarCliente.Checked
        Me.btnCargarVeterinarias.Enabled = Me.ckFiltrarCliente.Checked
        For Each r As DataGridViewRow In Me.viewClientes.Rows
            r.Cells("cMarcarCliente").Value = False
        Next
    End Sub

    Private IndexCliente As Integer = 0
    Private Sub AgregarCliente(_Id As String)
        Dim cliente As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewClientes.Rows Where x.Cells("cIdCliente").Value = _Id).ToList
        If Not cliente.Count > 0 Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Nombre from Clientes where identificacion = " & _Id, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.viewClientes.Rows.Add()
                Me.viewClientes.Item("cIdCliente", IndexCliente).Value = _Id
                Me.viewClientes.Item("cMarcarCliente", IndexCliente).Value = True
                Me.viewClientes.Item("cCliente", IndexCliente).Value = dt.Rows(0).Item("Nombre")
                Me.IndexCliente += 1
            End If
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim frmBuscarCliente As New frm_buscar_cliente
        frmBuscarCliente.txt_nombre.Focus()
        If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.AgregarCliente(frmBuscarCliente.id)
        End If
    End Sub

    Private Sub viewClientes_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles viewClientes.UserDeletedRow
        Me.IndexCliente -= 1
    End Sub

    Private Sub btnCargarVeterinarias_Click(sender As Object, e As EventArgs) Handles btnCargarVeterinarias.Click
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewEmpresasInternas", dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            Me.AgregarCliente(r.Item("Identificacion"))
        Next
    End Sub

End Class