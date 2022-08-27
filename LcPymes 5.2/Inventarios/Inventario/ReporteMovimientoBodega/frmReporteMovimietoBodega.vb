Imports System.Data

Public Class frmReporteMovimietoBodega
    Private CodProveedor As String = ""
    Private Buscando As Boolean = False

    Private Sub txtCodigo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Dim dt As New DataTable

        Select Case e.KeyCode

            Case Windows.Forms.Keys.Enter

                cFunciones.Llenar_Tabla_Generico("select Codigo, Cod_Articulo, Descripcion from Inventario where cod_articulo = '" & Me.txtCodigo.Text & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.CodProveedor = dt.Rows(0).Item("Codigo")
                    Me.txtCodigo.Text = dt.Rows(0).Item("Cod_Articulo")
                    Me.lblProveedor.Text = dt.Rows(0).Item("Descripcion")
                End If

            Case Windows.Forms.Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("select Cod_Articulo, Descripcion from CatalogoInventario", "Descripcion", "Buscar Proveedor...")
                Me.Buscando = True
                If valor = "" Then
                    Me.CodProveedor = ""
                    Me.txtCodigo.Text = ""
                    Me.lblProveedor.Text = ""
                Else
                    cFunciones.Llenar_Tabla_Generico("select Codigo, Cod_Articulo, Descripcion from Inventario where cod_articulo = '" & valor & "'", dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.CodProveedor = dt.Rows(0).Item("Codigo")
                        Me.txtCodigo.Text = dt.Rows(0).Item("Cod_Articulo")
                        Me.lblProveedor.Text = dt.Rows(0).Item("Descripcion")
                    End If
                End If
                Me.Buscando = False
        End Select
    End Sub

    Private Sub frmReporteMovimietoBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaFinal.Value = Date.Now
        Me.FechaInicio.Value = Date.Now
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        If Me.lblProveedor.Text <> "" And Me.txtCodigo.Text <> "" Then
            Dim rpt As New rptMovimientoBodega
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, Me.CodProveedor)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If Me.Buscando = False Then
            Me.CodProveedor = "0"
            Me.lblProveedor.Text = ""
        End If
    End Sub
End Class