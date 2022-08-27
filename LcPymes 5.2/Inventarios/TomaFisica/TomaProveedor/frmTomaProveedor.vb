Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class frmTomaProveedor

    Private WithEvents cls As New OBSoluciones.Inventario.TomaProveedor
    Private Id_TomaProveedor As Long = 0

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

    Sub limpiar()
        Me.Id_TomaProveedor = 0
        Me.btnActualizarExistencia.Enabled = True
        Me.btnBuscarProveedor.Enabled = True
        Me.btnGenerarToma.Enabled = True
        Me.btnCargarPretoma.Enabled = True
        dt_fecha.Text = Date.Now
        gp_2.Enabled = True
        Me.bt_guardar.Enabled = True
        Me.bt_buscar.Enabled = True
        Me.bt_eliminar.Enabled = False
        Me.btnImprimir.Enabled = False
        Me.viewDatos.Rows.Clear()
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

    Private Sub Guardar(Optional ByVal _Aplicar As Boolean = False)
        cls = New OBSoluciones.Inventario.TomaProveedor
        cls.Id = Me.Id_TomaProveedor
        cls.Id_UsuarioCreo = Me.Id_UsuarioCreo
        cls.CodigoProv = Me.txtCodigoProv.Text
        cls.Fecha = Me.dt_fecha.Value
        cls.Anulado = False
        cls.Aplicado = _Aplicar
        If cls.Guardar(Me.viewDatos, Me.listapretoma) = True Then
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

        ReporteDocumento = New rtpTomaProveedor
        ReporteDocumento.SetParameterValue(0, _Id)
        CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, CadenaConexionSeePOS)
    End Sub

    Private Sub cls_Guardado(_Id As Long) Handles cls.Guardado
        Me.limpiar()
        MsgBox("Guardado correctamente", MsgBoxStyle.Information, Text)
        Me.Imprimir(_Id)
    End Sub

    Private Sub cls_setAplicado(_Id As Long) Handles cls.setAplicado
        Me.limpiar()
        MsgBox("Toma Aplicada correctamente", MsgBoxStyle.Information, Text)
        Me.Imprimir(_id)
    End Sub

    Private Sub cls_setError(_msg As String) Handles cls.setError
        MsgBox(_msg, MsgBoxStyle.Critical, Text)
    End Sub

    Private Sub cls_TraladoAnulado(_Id As Long) Handles cls.TraladoAnulado
        Me.limpiar()
        MsgBox("Anulado correctamente", MsgBoxStyle.Information, Text)
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Guardar()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Try
            Dim frm As New frmBuscarTomaProveedor
            frm.Tabla = "viewTomaProveedor"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Id As String = frm.viewDatos.Item("Id", frm.viewDatos.CurrentRow.Index).Value
                cargar_informacion_prestamo(Id)
                Me.Id_TomaProveedor = Id
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub cargar_informacion_prestamo(_Id_PreTomaProveedor As String)

        Dim dtEncabezado As New DataTable
        Dim dtDetalle As New DataTable

        Try
            cFunciones.Llenar_Tabla_Generico("select * from viewTomaProveedor where id = " & _Id_PreTomaProveedor, dtEncabezado, CadenaConexionSeePOS)
            cFunciones.Llenar_Tabla_Generico("select * from TomaProveedorDetalle where Id_TomaProveedor = " & _Id_PreTomaProveedor, dtDetalle, CadenaConexionSeePOS)

            If dtEncabezado.Rows.Count > 0 Then
                Me.Id_TomaProveedor = _Id_PreTomaProveedor
                Me.btnAplicarAjustes.Enabled = True
                Me.btnGenerarToma.Enabled = False
                Me.btnCargarPretoma.Enabled = True
                Me.btnActualizarExistencia.Enabled = True

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
                    Me.btnActualizarExistencia.Enabled = False
                    Me.btnCargarPretoma.Enabled = False
                    Me.btnAplicarAjustes.Enabled = False
                    Me.bt_guardar.Enabled = False
                    Me.bt_eliminar.Enabled = False
                    Me.lblAnulado.Text = "Anulado"
                    Me.lblAnulado.Visible = True
                End If

                If dtEncabezado.Rows(0).Item("Aplicado") = True Or dtEncabezado.Rows(0).Item("Aplicado") = 1 Then
                    Me.btnActualizarExistencia.Enabled = False
                    Me.btnCargarPretoma.Enabled = False
                    Me.btnAplicarAjustes.Enabled = False
                    Me.bt_guardar.Enabled = False
                    Me.bt_eliminar.Enabled = False
                    Me.lblAnulado.Text = "Aplicado"
                    Me.lblAnulado.Visible = True
                End If

                Me.viewDatos.Rows.Clear()
                Dim codigo, cod_articulo, descripcion, existencia, toma, diferencia, id As String
                For Each r As DataRow In dtDetalle.Rows
                    codigo = r.Item("Codigo")
                    cod_articulo = r.Item("CodArticulo")
                    descripcion = r.Item("Descripicon")
                    existencia = r.Item("Existencia")
                    toma = r.Item("Toma")
                    diferencia = r.Item("Diferencia")
                    id = r.Item("Id")
                    viewDatos.Rows.Add(codigo, cod_articulo, descripcion, existencia, toma, diferencia, id)
                Next

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        If MsgBox("Desea Anular la Toma ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.Yes Then
            cls.Anular(Me.Id_TomaProveedor)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Me.Imprimir(Me.Id_TomaProveedor)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Me.CargarCodigoProv()
    End Sub

    Sub agregar_producto(_Codigo As String, _CCodigo As String, _Descripcion As String, _Exitencia As Decimal)
        Try
            viewDatos.Rows.Add(_Codigo, _CCodigo, _Descripcion, _Exitencia, 0, 0, 0)
            Me.btnBuscarProveedor.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnGenerarToma_Click(sender As Object, e As EventArgs) Handles btnGenerarToma.Click
        Dim dt As New DataTable
        Dim CodigoProv As String = "0"
        CodigoProv = Me.txtCodigoProv.Text
        cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion, Existencia from Inventario where inhabilitado = 0 and proveedor = " & CodigoProv, dt, CadenaConexionSeePOS)

        Me.viewDatos.Rows.Clear()
        For Each Fila As DataRow In dt.Rows
            Me.agregar_producto(Fila.Item("Codigo"), Fila.Item("Cod_Articulo"), Fila.Item("Descripcion"), Fila.Item("Existencia"))
        Next
        Me.CalcularDif()
    End Sub

    Private Function GetExistencia(_Cod As String) As Decimal
        Dim resultado As Decimal = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Existencia from Inventario where codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("Existencia")
        End If
        Return resultado
    End Function

    Private Sub Actualizar_Existencia()
        For Each fila As DataGridViewRow In Me.viewDatos.Rows
            fila.Cells("Existencia").Value = Me.GetExistencia(fila.Cells("codigo").Value)
        Next
    End Sub

    Private Sub LimpiarToma()
        For Each fila As DataGridViewRow In Me.viewDatos.Rows
            fila.Cells("toma").Value = 0
        Next
    End Sub

    Private Sub btnActualizarExistencia_Click(sender As Object, e As EventArgs) Handles btnActualizarExistencia.Click
        Me.Actualizar_Existencia()
    End Sub

    Private Sub viewDatos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellValueChanged
        On Error Resume Next
        Dim toma As String = "0"
        Dim existencia As String = "0"
        Dim diferencia As String = "0"
        existencia = Me.viewDatos.Item("existencia", e.RowIndex).Value
        toma = Me.viewDatos.Item("toma", e.RowIndex).Value
        If IsNumeric(toma) = True Then
            diferencia = CDec(toma) - CDec(existencia)
        Else
            Me.viewDatos.Item("toma", e.RowIndex).Value = "0.00"
            diferencia = "0"
        End If
        Me.viewDatos.Item("cDiferencia", e.RowIndex).Value = diferencia
    End Sub

    Private Sub CalcularDif()
        For Each fila As DataGridViewRow In Me.viewDatos.Rows
            fila.Cells("cDiferencia").Value = CDec(fila.Cells("toma").Value) - CDec(fila.Cells("existencia").Value)
        Next
    End Sub

    Private listapretoma As New List(Of Integer)
    Private Sub btnCargarPretoma_Click(sender As Object, e As EventArgs) Handles btnCargarPretoma.Click
        Dim frm As New frmBuscarTomaProveedor
        frm.Tabla = "viewPreTomaProveedor"
        frm.sinAplicar = True
        frm.CodigoProv = Me.txtCodigoProv.Text
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Id As Integer = frm.viewDatos.Item("Id", frm.viewDatos.CurrentRow.Index).Value
            Me.listapretoma.Add(Id)

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from PreTomaProveedorDetalle Where Id_PreTomaProveedor = " & Id, dt, CadenaConexionSeePOS)

            For Each r As DataRow In dt.Rows
                For Each fila As DataGridViewRow In Me.viewDatos.Rows
                    If r.Item("Codigo") = fila.Cells("codigo").Value Then
                        fila.Cells("toma").Value = r.Item("Cantidad")
                    End If
                Next
            Next
            Me.CalcularDif()
        End If
    End Sub

    Private Sub btnAplicarAjustes_Click(sender As Object, e As EventArgs) Handles btnAplicarAjustes.Click
        If MsgBox("Desea Aplicar la Toma ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.Yes Then
            Me.Guardar(True)
        End If
    End Sub

End Class




