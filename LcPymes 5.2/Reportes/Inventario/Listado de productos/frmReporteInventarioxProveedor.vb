Imports System.Data
Public Class frmReporteInventarioxProveedor
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

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If Me.lblProveedor.Text <> "" And Me.txtCodigo.Text <> "" Then
            Try
                Dim rpt As New rptInventarioxProveedor
                rpt.SetParameterValue(0, "Reporte de Articulos por Proveedor  " & Me.lblProveedor.Text)
                rpt.SetParameterValue(1, Me.ckExistencias.Checked)
                rpt.SetParameterValue(2, Me.CodProveedor)
                CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, rpt, , CadenaConexionSeePOS)
                CrystalReportViewer1.Show()
            Catch ex As Exception
                MsgBox(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub frmReporteInventarioxProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub

End Class