Public Class frmControlAlbaran
    Private Codigo_Articulo As String = ""

    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Return ""
        End If
        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function

    Private Sub frmControlAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaInicio.Value = Date.Now
        Me.FechaFinal.Value = Date.Now
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        If Me.lblProveedor.Text <> "" And Me.txtCodigo.Text <> "" Then
            Dim rpt As New rptControlAlbaran
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, Me.Codigo_Articulo)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Dim dt As New System.Data.DataTable

        Select Case e.KeyCode

            Case Windows.Forms.Keys.Enter
                If Me.txtCodigo.Text <> "" Then
                    cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion from inventario where Cod_Articulo = '" & Me.txtCodigo.Text & "' or Barras = '" & Me.txtCodigo.Text & "' or or Barras2 = '" & Me.txtCodigo.Text & "' or or Barras3 = '" & Me.txtCodigo.Text & "'", dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.Codigo_Articulo = dt.Rows(0).Item("Codigo")
                        Me.lblProveedor.Text = dt.Rows(0).Item("Descripcion")
                    End If
                End If

            Case Windows.Forms.Keys.F1

                Dim CodigoBuscador As String = BuscarF1()
                If CodigoBuscador <> "" Then
                    cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion from inventario where Cod_Articulo = '" & CodigoBuscador & "'", dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.Codigo_Articulo = dt.Rows(0).Item("Codigo")
                        Me.txtCodigo.Text = dt.Rows(0).Item("Cod_Articulo")
                        Me.lblProveedor.Text = dt.Rows(0).Item("Descripcion")
                    End If
                End If

        End Select
    End Sub
End Class