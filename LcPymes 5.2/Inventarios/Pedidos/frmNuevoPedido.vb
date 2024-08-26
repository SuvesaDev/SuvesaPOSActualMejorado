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

    Private Sub CargarSolicitara()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select 0 as id, 'Seleccione una Opcion' as nombre union select id, nombre  from solicitara ", dt, CadenaConexionSeePOS)
            If dt.Rows.Count = 0 Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Insert into solicitara(nombre, predeterminada) values('Proveeduria',1)", CommandType.Text)
                cFunciones.Llenar_Tabla_Generico("select id, nombre  from solicitara order by predeterminada desc, nombre", dt, CadenaConexionSeePOS)
            End If
            Me.cboSolicitarA.DataSource = dt
            Me.cboSolicitarA.DisplayMember = "nombre"
            Me.cboSolicitarA.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private CodArticulo As String = ""
    Private PrecioUnit As Decimal = 0
    Private Sub cargar_datos_inventario()

        Dim codigo As String = Me.BuscarF1
        If codigo <> "" Then
            txt_codigo.Text = ""
            Me.CargarEnter(codigo)            
        End If
    End Sub

    Private Sub CargarEnter(_CodArticulo As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion, Existencia, Precio_A, Prestamo from Inventario where Cod_Articulo = '" & _CodArticulo & "' or Barras = '" & _CodArticulo & "' or barras2 = '" & _CodArticulo & "' or barras3 = '" & _CodArticulo & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

            Me.CodArticulo = dt.Rows(0).Item("Cod_Articulo")
            Me.PrecioUnit = dt.Rows(0).Item("Precio_A")
            Me.txt_codigo.Text = dt.Rows(0).Item("Codigo")
            Me.txt_descripcion.Text = dt.Rows(0).Item("Descripcion")
            Me.txt_cantidad.Value = 1
            Me.txt_cantidad.Focus()

        End If
    End Sub


    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                Me.cargar_datos_inventario()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf e.KeyCode = Keys.Enter Then
            Me.CargarEnter(Me.txt_codigo.Text)
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
                            Me.txtNombreUsuario.Text = rs("Nombre")                            

                            PMU = VSM(rs("Cedula"), "PedidosBodega") 'Carga los privilegios del usuario con el modulo
                            'If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                            Me.ToolStrip1.Enabled = True
                            Me.GroupBox1.Enabled = True
                            Me.txt_codigo.Focus()
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
                Me.txt_codigo.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Imprimir()
        Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        ReporteDocumento = New rptPedidoBodega
        ReporteDocumento.SetParameterValue(0, Me.Consecutivo)
        CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, CadenaConexionSeePOS)
    End Sub

    Private Sub Guardar()
        If Me.cboSolicitarA.SelectedValue = 0 Then
            MsgBox("Selecciones una opcion", MsgBoxStyle.Exclamation, Me.Text)
            Me.cboSolicitarA.Focus()
            Exit Sub
        End If

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
            Me.Imprimir()
            Me.Close()
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private db As OBSoluciones.SQL.Transaccion
    Private Consecutivo As Long

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
        db.SetParametro("@IdSolicitara", Me.cboSolicitarA.SelectedValue)
        db.Ejecutar("Insertar_PedidoBodega", Me.Consecutivo, 4)
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        If Me.viewDatos.RowCount > 0 Then Me.Guardar()
    End Sub

    Private Sub frmNuevoPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarSolicitara()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If Me.Consecutivo > 0 Then
            Me.Imprimir()
        End If
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Try
            Dim frm As New frmBuscarPedido
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim dt As New System.Data.DataTable
                cFunciones.Llenar_Tabla_Generico("select * from viewPedidosBodega where Consecutivo = '" & frm.Consecutivo & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then

                    Me.Consecutivo = frm.Consecutivo
                    Me.dtpFechaSolicitud.Value = dt.Rows(0).Item("FechaSolicitud")
                    Me.txtUsuarioSolicita.Text = dt.Rows(0).Item("UsuarioSolicito")
                    Me.cboSolicitarA.SelectedText = dt.Rows(0).Item("SolicitarA")

                    Me.Index = 0
                    Me.viewDatos.Rows.Clear()
                    For Each r As DataRow In dt.Rows
                        Me.AgregarLinea(r.Item("Cod_Articulo"), r.Item("Cod_Articulo"), r.Item("Descripcion"), r.Item("CantidadSolicitud"), r.Item("Observaciones"), 0)
                    Next

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        Dim frm As New frmNuevoPedido
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.bt_agregar.Focus()
        End If
    End Sub

    Private Sub viewDatos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles viewDatos.RowsRemoved
        Me.Index -= 1
    End Sub

End Class
