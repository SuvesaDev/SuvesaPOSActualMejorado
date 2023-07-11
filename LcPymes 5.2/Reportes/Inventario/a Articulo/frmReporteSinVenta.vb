Public Class frmReporteSinVenta
    Private CodProveedor As String = "0"

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Try
            Dim rpt As New rptArticulosSinMovimiento
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFin.Value)
            rpt.SetParameterValue(2, Me.cboOpcion.SelectedIndex)


            If Me.ckPorProveedor.Checked Then
                If IsNumeric(Me.CodProveedor) Then
                    If CDec(Me.CodProveedor) > 0 Then
                        rpt.RecordSelectionFormula = "{spGetInventariosinVenta;1.Proveedor} = " & CodProveedor
                    End If
                End If
            End If

            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)

            VisorReporte.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FechaInicio.Value = Now.Date
        FechaFin.Value = Now.Date
        Me.cboOpcion.SelectedIndex = 0
    End Sub

    Private Sub ckPorProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles ckPorProveedor.CheckedChanged
        If Me.ckPorProveedor.Checked = True Then
            Me.txtCodigo.Enabled = True
            Me.txtCodigo.Text = ""
            Me.lblProveedor.Text = ""
        Else
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Text = ""
            Me.lblProveedor.Text = ""
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Dim dt As New System.Data.DataTable

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
End Class