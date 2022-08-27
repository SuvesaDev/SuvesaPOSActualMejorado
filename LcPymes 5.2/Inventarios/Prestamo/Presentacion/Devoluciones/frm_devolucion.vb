Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Prestamos
    Public Class frm_devolucion

        Sub cargar_informacion_prestamo(codigo As String, Optional ByVal _ConsultaBoleta As Boolean = False)
            Dim dts As New vprestamo
            Dim func As New fprestamo
            Dim func_detalles As New fprestamo_detalle
            Dim dt As DataTable
            Dim dt_detalles As DataTable

            Dim dt_empresa As New vempresa
            Dim func_empresa As New fempresas

            Try
                dt = func.buscar(codigo, _ConsultaBoleta)
                If dt.Rows.Count > 0 Then
                    dts.gid = dt.Rows(0).Item("ID")
                    dt_detalles = func_detalles.buscar(dts.gid)

                    If dt.Rows.Count > 0 Then

                        lb_id.Text = dt.Rows(0).Item("id")
                        lb_destinatario.Text = dt.Rows(0).Item("nombre_destinatario")
                        lb_destino.Text = dt.Rows(0).Item("nombre_destino")
                        ck_anulado.Checked = dt.Rows(0).Item("anulado")
                        ck_estado.Checked = dt.Rows(0).Item("estado")
                        txt_boleta.Text = dt.Rows(0).Item("boleta")

                        If ck_anulado.Checked = True Then
                            lblanulado.Visible = True
                            bt_eliminar.Enabled = False
                            gp_detalles.Enabled = False
                            gp_devoluciones.Enabled = False
                            gb_devolucion.Enabled = False
                        Else
                            lblanulado.Visible = False
                            bt_eliminar.Enabled = True
                        End If

                        If ck_estado.Checked = True Then
                            lb_entregado.Visible = True
                            bt_eliminar.Enabled = False
                            gp_detalles.Enabled = False
                            gp_devoluciones.Enabled = False
                            gb_devolucion.Enabled = False
                            bt_guardar.Enabled = False
                        ElseIf ck_anulado.Checked = True Then
                            gp_detalles.Enabled = False
                            gp_devoluciones.Enabled = False
                            gb_devolucion.Enabled = False
                            gb_devolucion.Enabled = False
                            bt_guardar.Enabled = False
                        ElseIf ck_anulado.Checked = False Or ck_estado.Checked = False Then
                            lb_entregado.Visible = False
                            bt_eliminar.Enabled = True
                            gp_detalles.Enabled = True
                            gp_devoluciones.Enabled = True
                            gb_devolucion.Enabled = True
                            bt_guardar.Enabled = True
                        End If
                        datalistado.DataSource = dt_detalles
                    Else
                        MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
                    End If

                Else
                    MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
                End If            
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
        Sub cargar_informacion_prestamo_detalle(codigo As String)
            Dim dts As New vprestamo_detalle
            Dim func As New fprestamo_detalle
            Dim dt As DataTable

            Try
                dts.gid = codigo
                dt = func.buscar_producto(codigo)

                If dt.Rows.Count > 0 Then
                    txt_prestamo.Text = CDbl(dt.Rows(0).Item("cantidad")) - CDbl(dt.Rows(0).Item("devuelto"))
                    txt_devueltos.Text = dt.Rows(0).Item("devuelto")
                    txt_devolvieron.Maximum = CDbl(txt_prestamo.Text)
                    lb_producto.Text = dt.Rows(0).Item("descripcion")
                Else
                    MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Private Sub txt_boleta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_boleta.KeyDown
            If e.KeyCode = Keys.F1 Then
                Dim frm As New frm_buscar_prestamo
                limpiar()
                frm.ShowDialog()
                txt_boleta.Text = frm.codigo
                If frm.codigo = "" Then
                    Exit Sub
                End If
                cargar_informacion_prestamo(frm.codigo)
            End If
            If e.KeyCode = Keys.Enter And Me.txt_boleta.Text <> "" Then
                cargar_informacion_prestamo(Me.txt_boleta.Text, True)
            End If
        End Sub

        Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick

        End Sub

        Private Sub bt_guardar_dev_Click(sender As Object, e As EventArgs) Handles bt_guardar_dev.Click
            If txt_devolvieron.Text <> "" Then
                If txt_prestamo.Text = "" Then
                    MsgBox("Seleccione el producto en la tabla de arriba para continuar", MsgBoxStyle.Information, "Agregar Producto")
                    Exit Sub
                End If
                If verificar_listado(Me.datalistado.SelectedCells.Item(2).Value) Then
                    agregar_producto()
                End If
            Else
                MsgBox("Agregar producto", MsgBoxStyle.Information, "Agregar Producto")
            End If
        End Sub
        Sub agregar_producto()
            Try
                Dim id_detalle, prestamo, codigo, descripcion, cantidad As String

                If txt_devolvieron.Value > txt_prestamo.Text Or txt_devolvieron.Value = 0 Then
                    MsgBox("No se puede prestar esta cantidad porque es mayor a lo que existe en inventario", MsgBoxStyle.Exclamation, "Cantidad sobrepasa el limite")
                    Exit Sub
                End If
                id_detalle = Me.datalistado.SelectedCells.Item(0).Value
                prestamo = Me.datalistado.SelectedCells.Item(1).Value
                codigo = Me.datalistado.SelectedCells.Item(2).Value
                descripcion = Me.datalistado.SelectedCells.Item(3).Value
                cantidad = txt_devolvieron.Value

                datalistado2.Rows.Add(prestamo, codigo, descripcion, cantidad, id_detalle)
                'limpiar_valores()
                'txt_codigo.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End Sub
        Sub guardar()
            Try
                Dim dts_detalle As New vdevolucion
                Dim func_detalle As New fdevolucion
                If datalistado2.RowCount <= 0 Then
                    MsgBox("No se han realizado cambios para guardar", MsgBoxStyle.Critical, "Guardar")
                    Exit Sub
                End If
                dts_detalle.gprestamo = lb_id.Text

                For i As Integer = 0 To datalistado2.Rows.Count - 1
                    dts_detalle.gcodigo = datalistado2.Rows(i).Cells(1).Value
                    dts_detalle.gdescripcion = datalistado2.Rows(i).Cells(2).Value
                    dts_detalle.gcantidad = datalistado2.Rows(i).Cells(3).Value
                    dts_detalle.gdetalleprestamo = datalistado2.Rows(i).Cells(4).Value
                    dts_detalle.gfecha = dt_fecha.Text
                    dts_detalle.ganulado = ck_anulado.Checked
                    func_detalle.insertar(dts_detalle)
                Next
                MsgBox("Guardado Correctamente", MsgBoxStyle.Information, "Guardado")
                verificar_prestamo() ' se revisa el prestamo si ya se devolvio todo
                limpiar()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End Sub
        Sub verificar_prestamo()
            Try
                Dim dts As New vprestamo
                Dim func As New fprestamo
                Dim dts_detalle As New DataTable

                dts.gid = lb_id.Text

                cFunciones.Llenar_Tabla_Generico("select * from detalle_prestamo where id_prestamo = " & lb_id.Text, dts_detalle, CadenaConexionSeePOS)
                entregado()

                For i As Integer = 0 To dts_detalle.Rows.Count - 1
                    If dts_detalle.Rows(i).Item("cantidad") <> dts_detalle.Rows(i).Item("devuelto") Then
                        Exit Sub
                    End If
                Next
                MsgBox("El prestamo ya se devolvio en su totalidad, se marcara como devuelto", MsgBoxStyle.Information, "Prestamo")
                func.cambiar_estado(dts)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Function verificar_listado(codigo As String)
            'revisamos la lista de los productos para validar cantidades
            Dim cantidad As Double
            Dim acumulado As Double

            For i As Integer = 0 To datalistado2.Rows.Count - 1
                If datalistado2.Rows(i).Cells(1).Value = codigo Then
                    cantidad = datalistado2.Rows(i).Cells(3).Value
                    cantidad += txt_devolvieron.Value
                    acumulado += cantidad
                    If acumulado > txt_prestamo.Text Then
                        MsgBox("No se puede agregar mas a superado el numero para devolver", MsgBoxStyle.Critical, "Agregar Productos")
                        Return False
                    End If

                End If
            Next
            Return True
        End Function
        Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
            guardar()
        End Sub

        Private Sub frm_devolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            dt_fecha.Text = Date.Now
        End Sub

        Sub limpiar()

            txt_boleta.Text = ""
            txt_devolvieron.Text = ""
            txt_prestamo.Text = ""
            txt_devueltos.Text = ""
            lblanulado.Visible = False
            lb_destinatario.Text = ""
            lb_destino.Text = ""
            lb_id.Text = 0
            gp_detalles.Enabled = True
            gp_devoluciones.Enabled = True
            lb_entregado.Visible = False
            ck_anulado.Checked = False
            ck_estado.Checked = False
            gb_devolucion.Enabled = True
            lb_producto.Text = "Producto"
            While (datalistado.Rows.Count >= 1)
                datalistado.Rows.Remove(datalistado.CurrentRow)
            End While

            While (datalistado2.Rows.Count >= 1)
                datalistado2.Rows.Remove(datalistado2.CurrentRow)
            End While
        End Sub

        Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
            limpiar()
        End Sub

        Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
            Try
                Dim id As String
                id = Me.datalistado.SelectedCells.Item(0).Value
                cargar_informacion_prestamo_detalle(id)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
        Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
            Dim frm As New frm_buscar_devolucion
            frm.ShowDialog()
        End Sub
        Sub entregado()
            Try
                Dim dts As New vprestamo
                Dim func As New fprestamo
                Dim dts_detalle As New DataTable


                cFunciones.Llenar_Tabla_Generico("select * from detalle_prestamo where id_prestamo = " & lb_id.Text, dts_detalle, CadenaConexionSeePOS)
                For i As Integer = 0 To dts_detalle.Rows.Count - 1
                    dts.gid = dts_detalle.Rows(i).Item("id")
                    If dts_detalle.Rows(i).Item("cantidad") = dts_detalle.Rows(i).Item("devuelto") Then
                        func.entregado(dts)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        Dim usua As Usuario_Logeado
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
                                Me.GroupBox1.Enabled = False
                                Me.gb_devolucion.Enabled = False
                                Me.gp_detalles.Enabled = False
                                Me.gp_devoluciones.Enabled = False

                                PMU = VSM(rs("Cedula"), "DevolucionPrestamosBodega") 'Carga los privilegios del usuario con el modulo
                                If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                                Me.ToolStrip1.Enabled = True
                                Me.GroupBox1.Enabled = True
                                Me.gb_devolucion.Enabled = True
                                Me.gp_detalles.Enabled = True
                                Me.gp_devoluciones.Enabled = True

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
    End Class
End Namespace
