Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing

Public Class frmPretomaProveedor
    Private WithEvents cls As New OBSoluciones.Inventario.PreTomaProveedor
    Private Id_PreTomaProveedor As Long = 0

    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim usua As Usuario_Logeado
    Private Id_UsuarioCreo As String = ""

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

    Private CodigoInterno As Long = 0
    Private Sub cargar_datos_inventario()
        Dim codigo As String = Me.BuscarF1
        If codigo <> "" Then
            txt_codigo.Text = ""
            txt_cantidad.Value = 1
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion, Existencia, Precio_A, Prestamo from Inventario where Cod_Articulo = '" & codigo & "' and inhabilitado = 0", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.CodigoInterno = dt.Rows(0).Item("Codigo")
                txt_codigo.Text = dt.Rows(0).Item("Cod_Articulo")
                txt_descripcion.Text = dt.Rows(0).Item("Descripcion")
                txt_existencia_act.Text = dt.Rows(0).Item("Existencia")
                txt_precio.Text = dt.Rows(0).Item("Precio_A")
                txt_prestamo.Text = dt.Rows(0).Item("Prestamo")
                txt_cantidad.Value = 1
                txt_cantidad.Focus()
                txt_cantidad.BackColor = Color.Bisque
            End If
        End If
    End Sub

    Private Sub CargarCodigoProv()
        Dim Fx As New cFunciones
        Dim valor As String
        valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
        If valor = "" Then
            Me.txtCodigoProv.Text = ""
            Me.txtNombreProveedor.Text = ""
        Else
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select CodigoProv,Nombre from Proveedores Where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
            Me.txtCodigoProv.Text = dt.Rows(0).Item("CodigoProv")
            Me.txtNombreProveedor.Text = dt.Rows(0).Item("Nombre")
        End If
    End Sub

    Sub agregar_producto()
        Try
            Dim codigo, descripcion, cantidad, precio As String
            codigo = txt_codigo.Text
            descripcion = txt_descripcion.Text
            cantidad = txt_cantidad.Value
            precio = txt_precio.Text
            viewDatos.Rows.Add(Me.CodigoInterno, codigo, 0, descripcion, cantidad, 0)
            limpiar_valores()
            txt_codigo.Focus()
            Me.btnBuscarProveedor.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub limpiar()
        Me.Id_PreTomaProveedor = 0
        Me.btnBuscarProveedor.Enabled = True
        dt_fecha.Text = Date.Now
        gp_2.Enabled = True
        Me.bt_guardar.Enabled = True
        Me.bt_buscar.Enabled = True
        Me.bt_eliminar.Enabled = False
        Me.btnImprimir.Enabled = False
        limpiar_valores()
        Me.viewDatos.Rows.Clear()
    End Sub

    Sub limpiar_valores()
        txt_codigo.Text = ""
        txt_prestamo.Text = ""
        txt_precio.Text = ""
        txt_cantidad.Text = ""
        txt_descripcion.Text = ""
        txt_existencia_act.Text = ""
        txt_cantidad.BackColor = Color.White
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim codigo As String = Me.txt_codigo.Text
            If codigo <> "" Then
                txt_codigo.Text = ""
                txt_cantidad.Value = 1
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion, Existencia, Precio_A, Prestamo, Proveedor from Inventario where (Cod_Articulo = '" & codigo & "' or Barras = '" & codigo & "') and inhabilitado = 0", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then

                    Dim prov As String = dt.Rows(0).Item("Proveedor")

                    If prov = Me.txtCodigoProv.Text Then
                        Me.CodigoInterno = dt.Rows(0).Item("Codigo")
                        txt_codigo.Text = dt.Rows(0).Item("Cod_Articulo")
                        txt_descripcion.Text = dt.Rows(0).Item("Descripcion")
                        txt_existencia_act.Text = dt.Rows(0).Item("Existencia")
                        txt_precio.Text = dt.Rows(0).Item("Precio_A")
                        txt_prestamo.Text = dt.Rows(0).Item("Prestamo")
                        txt_cantidad.Value = 1
                        txt_cantidad.Focus()
                        txt_cantidad.BackColor = Color.Bisque
                    Else
                        MsgBox("El articulo no pertenece al proveedor", MsgBoxStyle.Exclamation, Text)
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            Try
                Me.cargar_datos_inventario()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

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
                            Me.ToolStrip1.Enabled = False
                            Me.gp_2.Enabled = False
                            Me.Id_UsuarioCreo = rs("Cedula")
                            Me.txtNombreUsuario.Text = rs("Nombre")
                            PMU = VSM(rs("Cedula"), "PrestamosBodega") 'Carga los privilegios del usuario con el modulo
                            If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
                            Me.ToolStrip1.Enabled = True
                            Me.gp_2.Enabled = True
                            Me.limpiar()
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

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        If txt_codigo.Text <> "" Then
            agregar_producto()
        Else
            MsgBox("Agregar producto", MsgBoxStyle.Information, "Agregar Producto")
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_codigo.Text <> "" Then
                    agregar_producto()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Private Sub Guardar()
        cls = New OBSoluciones.Inventario.PreTomaProveedor
        cls.Id = Me.Id_PreTomaProveedor
        cls.Id_UsuarioCreo = Me.Id_UsuarioCreo
        cls.CodigoProv = Me.txtCodigoProv.Text
        cls.Fecha = Me.dt_fecha.Value
        cls.Anulado = False
        cls.Usado = False
        If cls.Guardar(Me.viewDatos) = True Then
            Me.limpiar()
            Me.txtUsuario.Text = ""
            Me.txtNombreUsuario.Text = ""
            Me.txtCodigoProv.Text = ""
            Me.txtNombreProveedor.Text = ""
        End If
    End Sub

    Private Sub Imprimir(_Id As Long)
        Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize

        ReporteDocumento = New rptPretomaProveedor
        ReporteDocumento.SetParameterValue(0, _Id)
        CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, CadenaConexionSeePOS)
    End Sub

    Private Sub cls_Guardado(_Id As Long) Handles cls.Guardado
        Me.limpiar()
        MsgBox("Guardado correctamente", MsgBoxStyle.Information, Text)
        
        Me.Imprimir(_Id)
    End Sub

    Private Sub cls_setError(_msg As String) Handles cls.setError
        MsgBox(_msg, MsgBoxStyle.Critical, Text)
    End Sub

    Private Sub cls_TraladoAnulado(_Id As Long) Handles cls.TraladoAnulado
        Me.limpiar()
        MsgBox("Anulado correctamente", MsgBoxStyle.Information, Text)
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        guardar()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Try
            Dim frm As New frmBuscarTomaProveedor
            frm.Tabla = "viewPreTomaProveedor"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Id As String = frm.viewDatos.Item("Id", frm.viewDatos.CurrentRow.Index).Value
                cargar_informacion_prestamo(Id)
                Me.Id_PreTomaProveedor = Id
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub cargar_informacion_prestamo(_Id_PreTomaProveedor As String)

        Dim dtEncabezado As New DataTable
        Dim dtDetalle As New DataTable

        Try
            cFunciones.Llenar_Tabla_Generico("select * from viewPreTomaProveedor where id = " & _Id_PreTomaProveedor, dtEncabezado, CadenaConexionSeePOS)
            cFunciones.Llenar_Tabla_Generico("select * from PreTomaProveedorDetalle where Id_PreTomaProveedor = " & _Id_PreTomaProveedor, dtDetalle, CadenaConexionSeePOS)

            If dtEncabezado.Rows.Count > 0 Then
                Me.Id_PreTomaProveedor = _Id_PreTomaProveedor

                Me.txtCodigoProv.Text = dtEncabezado.Rows(0).Item("CodigoProv")
                Me.txtNombreProveedor.Text = dtEncabezado.Rows(0).Item("Proveedor")
                Me.txtUsuario.Text = dtEncabezado.Rows(0).Item("Usuario")
                Me.Id_UsuarioCreo = dtEncabezado.Rows(0).Item("Id_UsuarioCreo")
                Me.dt_fecha.Value = dtEncabezado.Rows(0).Item("Fecha")

                Me.btnImprimir.Enabled = True
                Me.bt_eliminar.Enabled = True
                Me.bt_guardar.Enabled = True
                Me.lblAnulado.Visible = False

                If dtEncabezado.Rows(0).Item("Anulado") = True Or dtEncabezado.Rows(0).Item("Anulado") = 1 Then
                    Me.bt_guardar.Enabled = False
                    Me.bt_eliminar.Enabled = False
                    Me.lblAnulado.Text = "Anulado"
                    Me.lblAnulado.Visible = True
                End If

                If dtEncabezado.Rows(0).Item("Usado") = True Or dtEncabezado.Rows(0).Item("Usado") = 1 Then
                    Me.bt_guardar.Enabled = False
                    Me.bt_eliminar.Enabled = False
                    Me.lblAnulado.Text = "Aplicado"
                    Me.lblAnulado.Visible = True
                End If

                Me.viewDatos.Rows.Clear()
                Dim codigo, cod_articulo, descripcion, cantidad, id As String
                For Each r As DataRow In dtDetalle.Rows
                    codigo = r.Item("Codigo")
                    cod_articulo = r.Item("CodArticulo")
                    descripcion = r.Item("Descripicon")
                    cantidad = r.Item("Cantidad")
                    id = r.Item("Id")
                    viewDatos.Rows.Add(codigo, cod_articulo, 0, descripcion, cantidad, id)
                Next

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        If MsgBox("Desea Anular la PreToma ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.Yes Then
            cls.Anular(Me.Id_PreTomaProveedor)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Me.Imprimir(Me.Id_PreTomaProveedor)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Me.CargarCodigoProv()
    End Sub

End Class