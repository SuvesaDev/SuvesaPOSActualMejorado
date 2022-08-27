Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Public Class frmAumentarOtro
    Private CodigoInventario As String = ""

    Private Sub CalcularCantidadDescargar()
        Try
            Dim CantDescargar As Decimal = CDec(Me.txtCantidadDescargar.Value)
            Dim DescargaxSaco As Decimal = CDec(Me.txtDescargaxSaco.Text)
            Me.txtCantidadAumentar.Text = CantDescargar * DescargaxSaco
        Catch ex As Exception
            Me.txtCantidadAumentar.Text = 0
        End Try
    End Sub

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

    Private Function Aplica(_Codigo As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Inventario where DescargaOtro = 1 and codigoDescarga = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtCodigoAumentar.Text = dt.Rows(0).Item("Codigo")
            Me.txtDescripcionAumentar.Text = dt.Rows(0).Item("Descripcion")
            Me.txtExistenciaAumentar.Text = dt.Rows(0).Item("Existencia")
            Me.txtDescargaxSaco.Text = dt.Rows(0).Item("CantidadDescarga")
            Me.txtCantidadAumentar.BackColor = Color.Bisque
            Return True
        Else
            Me.CodigoInventario = ""
            Me.txtCodigoAumentar.Text = ""
            Me.txtDescripcionAumentar.Text = ""
            Me.txtExistenciaAumentar.Text = 0
            Me.txtDescargaxSaco.Text = 0
            Me.txtCantidadAumentar.BackColor = Color.Bisque
            Return False
        End If
    End Function

    Private Sub cargar_datos_inventario(Optional ByVal _Descargar As Boolean = True)
        Dim codigo As String = Me.BuscarF1
        If codigo <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Codigo, Descripcion, Existencia, Precio_A, Prestamo from Inventario where Cod_Articulo = '" & codigo & "' and inhabilitado = 0", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If _Descargar = True Then
                    Me.txtCodigoDescargar.Text = ""
                    Me.txtCantidadDescargar.Value = 1
                    Me.CodigoInventario = dt.Rows(0).Item("Codigo")
                    Me.txtCodigoDescargar.Text = dt.Rows(0).Item("Codigo")
                    Me.txtDescripcionDescargar.Text = dt.Rows(0).Item("Descripcion")
                    Me.txtExistenciaDescargar.Text = dt.Rows(0).Item("Existencia")
                    Me.txtCantidadDescargar.Focus()
                    Me.txtCantidadDescargar.BackColor = Color.Bisque
                    If Me.Aplica(dt.Rows(0).Item("Codigo")) Then
                        Me.btnBuscarAumentar.Enabled = False
                        Me.txtDescargaxSaco.ReadOnly = True
                        Me.CalcularCantidadDescargar()
                    Else
                        Me.btnBuscarAumentar.Enabled = True
                        Me.txtDescargaxSaco.ReadOnly = False
                    End If
                Else
                    Me.txtCodigoAumentar.Text = dt.Rows(0).Item("Codigo")
                    Me.txtDescripcionAumentar.Text = dt.Rows(0).Item("Descripcion")
                    Me.txtExistenciaAumentar.Text = dt.Rows(0).Item("Existencia")
                    Me.txtCantidadAumentar.Focus()
                    Me.txtCantidadAumentar.BackColor = Color.Bisque
                    Me.txtDescargaxSaco.Focus()
                    Me.CalcularCantidadDescargar()
                End If
            End If
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoDescargar.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                Me.cargar_datos_inventario()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.btnBuscarAumentar.Enabled = False Then
            If Me.CodigoInventario <> "" And Me.txtCantidadDescargar.Value > 0 Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("exec dbo.aumentaotro " & Me.CodigoInventario & ", " & Me.txtCantidadDescargar.Value, CommandType.Text)
                Me.Close()
            End If
        Else
            If Me.txtCodigoAumentar.Text <> "" And Me.txtCantidadDescargar.Value > 0 And CDec(Me.txtCantidadAumentar.Text) > 0 Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("exec dbo.aumentaotro_Manual " & Me.txtCodigoDescargar.Text & ", " & Me.txtCantidadDescargar.Value & ", " & Me.txtCodigoAumentar.Text & ", " & Me.txtCantidadAumentar.Text, CommandType.Text)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBuscarDescargar_Click(sender As Object, e As EventArgs) Handles btnBuscarDescargar.Click
        Me.cargar_datos_inventario()
    End Sub

    Private Sub btnBuscarAumentar_Click(sender As Object, e As EventArgs) Handles btnBuscarAumentar.Click
        Me.cargar_datos_inventario(False)
    End Sub

    Private Sub txtCantidadDescargar_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidadDescargar.ValueChanged
        Me.CalcularCantidadDescargar()
    End Sub

    Private Sub txtDescargaxSaco_TextChanged(sender As Object, e As EventArgs) Handles txtDescargaxSaco.TextChanged
        Me.CalcularCantidadDescargar()
    End Sub

End Class
