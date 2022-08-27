Imports System.Data
Public Class frmMovimientoCompras


    '*************************************************
    '*************************************************
    'Reporte de Ventas Por Proveeedor
    '*************************************************
    '*************************************************
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

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        If Me.lblProveedor.Text <> "" And Me.txtCodigo.Text <> "" Then
            Dim rpt As New rptObtenerCompras
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, Me.CodProveedor)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

    Private Sub ckTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ckTodos.CheckedChanged
        If Me.ckTodos.Checked = True Then
            Me.txtCodigo.Text = "0"
            Me.CodProveedor = "0"
            Me.lblProveedor.Text = "Mostrar Todos los Proveedores"
            Me.txtCodigo.Enabled = False
        Else
            Me.CodProveedor = "0"
            Me.txtCodigo.Text = ""
            Me.lblProveedor.Text = ""
            Me.txtCodigo.Enabled = True
        End If
    End Sub
End Class