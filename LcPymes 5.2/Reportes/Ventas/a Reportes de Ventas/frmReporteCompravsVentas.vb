Imports System.Data
Public Class frmReporteCompravsVentas


    Private CodProveedor As String = ""

    Private Sub txtCodigo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Dim dt As New DataTable

        Select Case e.KeyCode

            Case Windows.Forms.Keys.Enter


                cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & Me.txtCodigo.Text, dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.CodProveedor = dt.Rows(0).Item("CodigoProv")
                    Me.txtCodigo.Text = dt.Rows(0).Item("CodigoProv")
                    Me.lblProveedor.Text = dt.Rows(0).Item("Nombre")
                End If

            Case Windows.Forms.Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                If valor = "" Then
                    Me.CodProveedor = ""
                    Me.txtCodigo.Text = ""
                    Me.lblProveedor.Text = ""
                Else
                    cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.CodProveedor = dt.Rows(0).Item("CodigoProv")
                        Me.txtCodigo.Text = dt.Rows(0).Item("CodigoProv")
                        Me.lblProveedor.Text = dt.Rows(0).Item("Nombre")
                    End If
                End If
        End Select
    End Sub

    Private Sub ckTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ckTodos.CheckedChanged
        If Me.ckTodos.Checked = True Then
            Me.txtCodigo.Text = "0"
            Me.CodProveedor = "0"
            Me.lblProveedor.Text = "Todos los Proveedores"
            Me.txtCodigo.Enabled = False
        Else
            Me.CodProveedor = "0"
            Me.txtCodigo.Text = ""
            Me.lblProveedor.Text = ""
            Me.txtCodigo.Enabled = True
        End If
    End Sub

    Private Sub frmReporteAbonoIncobrable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ckTodos.Checked = True
        Me.WindowState = FormWindowState.Maximized
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
        Me.cboTipoReporte.SelectedIndex = 0
    End Sub

    Private Function GetSaldoActual(_Codigo As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select isnull(sum(dbo.SaldoFacturaCompra(getdate(), Factura, CodigoProv)),0) as Saldo from compras where codigoprov = " & _Codigo & " and tipocompra = 'CRE' and facturacancelado = 0", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return CDec(dt.Rows(0).Item("Saldo"))
        End If
    End Function


    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            If Me.cboTipoReporte.SelectedIndex = 0 Then
                Dim rpt As New rptVentaCompraArticuloResumen
                rpt.Refresh()
                rpt.SetParameterValue(0, Me.FechaInicio.Value)
                rpt.SetParameterValue(1, Me.FechaFinal.Value)
                rpt.SetParameterValue(2, Me.CodProveedor)
                rpt.SetParameterValue(3, Me.lblProveedor.Text)
                rpt.SetParameterValue(4, Me.GetSaldoActual(Me.CodProveedor))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            End If

            If Me.cboTipoReporte.SelectedIndex = 1 Then
                Dim rpt As New rptVentaCompraArticulo
                rpt.Refresh()
                rpt.SetParameterValue(0, Me.FechaInicio.Value)
                rpt.SetParameterValue(1, Me.FechaFinal.Value)
                rpt.SetParameterValue(2, Me.CodProveedor)
                rpt.SetParameterValue(3, Me.lblProveedor.Text)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            End If

            If Me.cboTipoReporte.SelectedIndex = 2 Then
                Dim rpt As New ComprasvsVentasResumenProveedor
                rpt.Refresh()
                rpt.SetParameterValue(0, Me.FechaInicio.Value)
                rpt.SetParameterValue(1, Me.FechaFinal.Value)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
                VisorReporte.Show()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub cboTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoReporte.SelectedIndexChanged
        If Me.cboTipoReporte.SelectedIndex = 2 Then
            Me.ckTodos.Checked = True
            Me.ckTodos.Enabled = False
        Else
            Me.ckTodos.Enabled = True
        End If
    End Sub
End Class