Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class frmNuevoPedido
    Private Index As Integer = 0


    Private Function BuscarF1() As String
        Dim BuscarArt As New FrmBuscarArticulo2
        Dim Codigo As String = ""
        BuscarArt.Codigo = ""
        BuscarArt.CheckBoxInHabilitados.Enabled = True
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

    Private CodArticulo As String = ""
    Private PrecioUnit As Decimal = 0
    Private Sub cargar_datos_inventario()

        Dim codigo As String = Me.BuscarF1
        If codigo <> "" Then
            txt_codigo.Text = ""

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion, Existencia, Precio_A, Prestamo from Inventario where Cod_Articulo = '" & codigo & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then

                Me.CodArticulo = dt.Rows(0).Item("Cod_Articulo")
                Me.PrecioUnit = dt.Rows(0).Item("Precio_A")
                Me.txt_codigo.Text = dt.Rows(0).Item("Codigo")
                Me.txt_descripcion.Text = dt.Rows(0).Item("Descripcion")
                Me.txt_cantidad.Value = 1

            End If
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                Me.cargar_datos_inventario()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim usua As Usuario_Logeado
    Dim IdUsuario As String = ""
    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cConexion As New LcPymes_5._2.Conexion
            Dim rs As SqlDataReader
            If e.KeyCode = Keys.Enter Then
                If txtUsuario.Text <> "" Then
                    rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                    If rs.HasRows = False Then
                        MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                        txtUsuario.Focus()
                    End If
                    While rs.Read
                        Try

                            Me.ToolStrip1.Enabled = True
                            Me.GroupBox1.Enabled = True
                            Me.IdUsuario = rs("Cedula")
                            Me.txtUsuarioSolicita.Text = rs("Nombre")

                            PMU = VSM(rs("Cedula"), "PedidosBodega") 'Carga los privilegios del usuario con el modulo
                            'If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                            Me.ToolStrip1.Enabled = True
                            Me.GroupBox1.Enabled = True

                        Catch ex As SystemException
                            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                        End Try
                    End While
                    rs.Close()
                    cConexion.DesConectar(cConexion.sQlconexion)
                Else
                    MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                    txtUsuario.Focus()
                End If
            End If
        End If
    End Sub

    Public Sub AgregarLinea(_Codigo As String, _CodArticulo As String, _Descripcion As String, _Cantidad As Decimal, _Observaciones As String, _PrecioUnid As Decimal)
        Try
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cCodigo", Me.Index).Value = _Codigo
            Me.viewDatos.Item("cCodArticulo", Me.Index).Value = _CodArticulo
            Me.viewDatos.Item("cPrecioUnid", Me.Index).Value = _PrecioUnid
            Me.viewDatos.Item("cDescripcion", Me.Index).Value = _Descripcion
            Me.viewDatos.Item("cCantidad", Me.Index).Value = _Cantidad
            Me.viewDatos.Item("cObservaciones", Me.Index).Value = _Observaciones
            Me.Index += 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        Try
            If Me.txt_descripcion.Text <> "" Then
                Dim codigo As String = Me.txt_codigo.Text
                Dim codarticulo As String = Me.CodArticulo
                Dim descripcion As String = Me.txt_descripcion.Text
                Dim cantidad As Decimal = Me.txt_cantidad.Value
                Dim obs As String = Me.txtObservaciones.Text
                Me.AgregarLinea(codigo, codarticulo, descripcion, cantidad, obs, Me.PrecioUnit)
                Me.CodArticulo = ""
                Me.txt_codigo.Text = ""
                Me.txt_descripcion.Text = ""
                Me.txtObservaciones.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Guardar()
        Me.db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Me.Consecutivo = 0
        Try            

            For i As Integer = 0 To Me.viewDatos.Rows.Count - 1
                Me.InsertarPedidoBodega(Me.dtpFechaSolicitud.Value, _
                                        Me.IdUsuario, _
                                        Me.viewDatos.Item("cCodigo", i).Value, _
                                        Me.viewDatos.Item("cCantidad", i).Value, _
                                        Me.viewDatos.Item("cObservaciones", i).Value, _
                                        Me.viewDatos.Item("cPrecioUnid", i).Value)

            Next
            db.Commit()
            Me.Close()
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub    
    Private db As OBSoluciones.SQL.Transaccion
    Private Consecutivo As Integer

    '***************************************************************************
    '***************************************************************************
    '***************************************************************************

    Private Sub InsertarPedidoBodega(_FechaSolicitud As Date, _IdUsuarioSolicitud As String, _Codigo As String, _CantidadSolicitud As Decimal, _Observaciones As String, _PrecioUnid As Decimal)
        db.SetParametro("@fechaSolicitud", _FechaSolicitud)
        db.SetParametro("@IdUsuarioSolicitud", _IdUsuarioSolicitud)
        db.SetParametro("@Codigo", _Codigo)
        db.SetParametro("@CantidadSolicitud", _CantidadSolicitud)
        db.AddParametrosSalidaInt("@Consecutivo", Me.Consecutivo)
        db.SetParametro("@Observaciones", _Observaciones)
        db.SetParametro("@PrecioUnid", _PrecioUnid)
        db.SetParametro("@CantidadPuntos", 1)
        db.Ejecutar("Insertar_PedidoBodega", Me.Consecutivo, 4)
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        If Me.viewDatos.RowCount > 0 Then Me.Guardar()
    End Sub

End Class
