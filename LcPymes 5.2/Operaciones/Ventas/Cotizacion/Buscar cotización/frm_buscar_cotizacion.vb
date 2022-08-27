Imports System.Data
Public Class frm_buscar_cotizacion

    Private Sub frm_buscar_cotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Sub buscar()
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from vista_productos_cotizados_x_cliente where cod_cliente = '" & txt_cliente.Text & "' and codarticulo = '" & txt_codigo.Text & "'", dts)
        If dts.Rows.Count > 0 Then
            dt_listado.DataSource = dts
        Else
            MsgBox("No se encontraron registros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()
    End Sub

    Private Sub txt_cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then
            Try
                lblcliente.Text = ""
                frm_buscar_cliente.ShowDialog()
                txt_cliente.Text = frm_buscar_cliente.id
                lblcliente.Text = frm_buscar_cliente.nombre
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub txt_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cliente.TextChanged
        If txt_cliente.Text = "" Then
            lblcliente.Text = ""
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then
            BuscarF1()
        End If
    End Sub
    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            txt_codigo.Text = BuscarArt.Codigo
            Exit Function
        End If
        txt_codigo.Text = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function
    Private Sub txt_codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged

    End Sub
End Class