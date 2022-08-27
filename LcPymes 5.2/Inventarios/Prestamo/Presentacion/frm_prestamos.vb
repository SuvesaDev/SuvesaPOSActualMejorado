Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Namespace Prestamos
    Public Class frm_prestamos

        Public Property IdSPrestamo As Long = 0
        Public Property SPrestamo As Boolean = True

        Private Sub AbrirSolicitud()
            Dim Logica As New OBSoluciones.LogisticaPrestamo
            Dim prestamo As New OBSoluciones.Prestamo
            prestamo = Logica.MostrarSolicitud(Me.IdSPrestamo)

            Me.lb_id.Text = 0
            Me.numero_boleta()
            Me.cbo_destinatario.SelectedValue = prestamo.Destinatario
            Me.cbo_destino.SelectedValue = prestamo.Destino
            Me.txt_transportista.Text = ""
            Me.dt_fecha.Text = prestamo.Fecha
            Me.rb_entrada.Checked = prestamo.Entrada
            Me.rb_salida.Checked = prestamo.Salida
            Me.ck_anulado.Checked = prestamo.Anulado
            Me.ck_estado.Checked = prestamo.Estado
            Me.txtBoletaProveedor.Text = prestamo.Boleta

            If ck_anulado.Checked = True Then
                lblanulado.Visible = True
                gp_1.Enabled = False
                gp_2.Enabled = False
                bt_eliminar.Enabled = False
                bt_devolucion.Enabled = False
            Else
                lblanulado.Visible = False
                gp_1.Enabled = True
                gp_2.Enabled = True
                bt_eliminar.Enabled = True
            End If

            If ck_estado.Checked = True Then
                lb_entregado.Visible = True
                gp_1.Enabled = False
                gp_2.Enabled = False
                bt_eliminar.Enabled = False
                bt_devolucion.Enabled = False

            ElseIf ck_anulado.Checked = False Then
                lb_entregado.Visible = False
                gp_1.Enabled = False
                gp_2.Enabled = False
                bt_eliminar.Enabled = True
                bt_devolucion.Enabled = True
            End If

            For Each P As OBSoluciones.Detalle_Prestamo In prestamo.Detalle_Prestamo
                datalistado.Rows.Add(P.CodigoPrestamo, lb_id.Text, P.Descripcion, P.Cantidad, P.Precio)
            Next
        End Sub

        Private Sub bt_guardar_Click(sender As Object, e As EventArgs)
            guardar()
        End Sub

        Sub limpiar()
            lb_id.Text = 0
            txt_boleta.Text = ""
            txt_transportista.Text = ""
            txt_observaciones.Text = ""
            ck_anulado.Checked = False
            ck_estado.Checked = False
            rb_entrada.Checked = False
            rb_salida.Checked = False
            dt_fecha.Text = Date.Now
            lblanulado.Visible = False
            gp_1.Enabled = True
            gp_2.Enabled = True
            bt_eliminar.Enabled = True
            bt_guardar.Enabled = True
            lb_entregado.Visible = False
            limpiar_valores()
            limpiar_datagrid()
        End Sub
        Sub limpiar_datagrid()
            While (datalistado.Rows.Count >= 1)
                datalistado.Rows.Remove(datalistado.CurrentRow)
            End While
        End Sub

        Private Id_Empresa_Actual As Integer = 0
        Private Sub Cargar_Empresa_Actual()
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Id from empresa where actual = 1", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.Id_Empresa_Actual = dt.Rows(0).Item("Id")
            End If
        End Sub

        Sub llenar_empresas()
            Try
                Dim func As New fempresas
                Dim dts As DataTable = func.mostrar
                Dim dt As DataTable = func.mostrar
                Me.cbo_destinatario.DataSource = dts
                Me.cbo_destinatario.DisplayMember = "empresa"
                Me.cbo_destinatario.ValueMember = "id"
                Me.cbo_destino.DataSource = dt
                Me.cbo_destino.DisplayMember = "empresa"
                Me.cbo_destino.ValueMember = "id"
                Me.Cargar_Empresa_Actual()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function validacion()
            If cbo_destino.SelectedValue = cbo_destinatario.SelectedValue Then
                MsgBox("Verifique que el destino y el destinatario no sea el mismo", MsgBoxStyle.Critical, "Error de validación")
                Return True
            End If
            If txt_boleta.Text = "" Or txt_transportista.Text = "" Or datalistado.Rows.Count = 0 Then
                MsgBox("No se puede guardar, verifique que no falten campos que rellenar", MsgBoxStyle.Critical, "Guardar")
                Return True
            End If
            If rb_entrada.Checked = False And rb_salida.Checked = False Then
                MsgBox("Seleccionar si el prestamo es de salida o entrada", MsgBoxStyle.Critical, "Guardar")
                Return True
            End If
            Return False
        End Function
        Sub guardar()

            If Me.txtBoletaProveedor.Text = "" Then
                Me.txtBoletaProveedor.Text = "0"
            End If

            If Me.txtBoletaProveedor.ReadOnly = False Then
                If Me.txtBoletaProveedor.Text = "" Then
                    MsgBox("Debe de Asignar la boleta del proveedor", MsgBoxStyle.Exclamation, Text)
                    Me.txtBoletaProveedor.Focus()
                    Exit Sub
                End If
            End If

            Try
                Dim dts_prestamo As New vprestamo
                Dim func As New fprestamo
                If validacion() Then
                    Exit Sub
                End If
                '--------------encabezado del prestamo-------------------
                dts_prestamo.gid = lb_id.Text
                dts_prestamo.gboleta = txt_boleta.Text
                dts_prestamo.gdestino = cbo_destino.SelectedValue
                dts_prestamo.gdestinatario = cbo_destinatario.SelectedValue
                dts_prestamo.gtransportista = txt_transportista.Text
                dts_prestamo.gobservacion = txt_observaciones.Text
                dts_prestamo.gId_UsuariCreo = Me.Id_Usuario
                dts_prestamo.ganulado = ck_anulado.Checked
                dts_prestamo.gestado = ck_estado.Checked
                dts_prestamo.gentrada = rb_entrada.Checked
                dts_prestamo.gsalida = rb_salida.Checked
                dts_prestamo.gfecha = dt_fecha.Text
                dts_prestamo.gnombre_destinatario = cbo_destinatario.Text
                dts_prestamo.gnombre_destino = cbo_destino.Text

                If bt_guardar.Text = "Actualizar" Then
                    If func.editar(dts_prestamo, Id_Usuario, Me.txtBoletaProveedor.Text, Me.SPrestamo) Then
                        MsgBox(" Modificado Correctamente")
                        frm_visor.codigo06082018test = obtener_num_id()
                        frm_visor.Show()
                        limpiar()
                    Else
                        MsgBox("Error al intentar Modificar")
                    End If
                Else
                    If func.insertar(dts_prestamo, Id_Usuario, Me.txtBoletaProveedor.Text, Me.SPrestamo) Then
                        guardar_detalle()
                        MsgBox("Guardado Correctamente")

                        If Me.SPrestamo = False Then
                            Try
                                Dim PrestamoPVE As New Reporte_prestamoPVE
                                Dim PrinterSettings1 As New Printing.PrinterSettings
                                Dim PageSettings1 As New Printing.PageSettings
                                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                                CrystalReportsConexion.LoadReportViewer(Nothing, PrestamoPVE, True)
                                PrestamoPVE.SetParameterValue(0, obtener_num_id())
                                PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                                If MsgBox("Desea imprimir una copia del prestamo", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                                    PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                                End If
                            Catch ex As Exception
                            End Try

                            If Me.IdSPrestamo > 0 Then
                                'debe actualizar el prestamo en la nube
                                'para marcarlo como aceptado.
                                OBSoluciones.db.Ejecutar("Update Prestamo Set Aceptado = 1 Where ID = " & Me.IdSPrestamo, CommandType.Text)
                                Me.Close()
                            End If

                        Else
                            Try
                                Dim Enviar As New OBSoluciones.LogisticaPrestamo
                                Enviar.EnviarSolicitud(obtener_num_id)
                            Catch ex As Exception
                            End Try
                        End If
                        
                        limpiar()
                    Else
            MsgBox("Error al intentar guardar")
                    End If
                    End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
            Dim PrintDocument1 As New PrintDocument
            Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
            Dim PrinterInstalled As String
            'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA

            If PrinterToSelect = 15 Then
                Dim PrinterDialog As New PrintDialog
                Dim DocPrint As New PrintDocument
                PrinterDialog.Document = DocPrint
                PrinterDialog.ShowDialog()
                If PrinterDialog.ShowDialog.Yes Then
                    Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
                Else
                    Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
                End If
            End If

            For Each PrinterInstalled In PrinterSettings.InstalledPrinters
                Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                    Case "FACTURACION" 'FACTURACION
                        If PrinterToSelect = 0 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                    Case "CONTADO"
                        If PrinterToSelect = 1 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                    Case "CREDITO"
                        If PrinterToSelect = 2 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                    Case "PUNTOVENTA"
                        If PrinterToSelect = 3 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                    Case "FAX"
                        If PrinterToSelect = 4 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                    Case "PUNTOVENTA02"
                        If PrinterToSelect = 5 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                    Case "FACTURACION02" 'FACTURACION
                        If PrinterToSelect = 6 Then
                            Return PrinterInstalled.ToString
                            Exit Function
                        End If
                End Select
            Next

            If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
                Dim PrinterDialog As New PrintDialog
                Dim DocPrint As New PrintDocument
                PrinterDialog.Document = DocPrint
                PrinterDialog.ShowDialog()
                If PrinterDialog.ShowDialog.Yes Then
                    Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
                Else
                    Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
                End If
            Else
                Return ""
            End If
        End Function

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

        Private Sub CargarDatosInventaro_x_CodArticulos(_Codigo As String)
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select i.Codigo, i.Cod_Articulo, i.Descripcion+ ' (' + cast(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones + ')' as Descripcion, i.Existencia, i.Precio_A, i.Prestamo from Inventario i inner join Presentaciones p on i.CodPresentacion = p.CodPres where inhabilitado = 0 And Cod_Articulo = '" & _Codigo & "' ", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then

                txtCodArticulo.Text = dt.Rows(0).Item("Cod_Articulo")
                txt_codigo.Text = dt.Rows(0).Item("Codigo")
                txt_descripcion.Text = dt.Rows(0).Item("Descripcion")
                txt_existencia_act.Text = dt.Rows(0).Item("Existencia")
                txt_precio.Text = dt.Rows(0).Item("Precio_A")
                txt_prestamo.Text = dt.Rows(0).Item("Prestamo")
                txt_cantidad.Focus()
                txt_cantidad.BackColor = Color.Bisque

            End If
        End Sub

        Private Sub cargar_datos_inventario()

            Dim codigo As String = Me.BuscarF1
            If codigo <> "" Then
                txt_codigo.Text = ""
                txt_cantidad.Value = 1
                Me.CargarDatosInventaro_x_CodArticulos(codigo)
            End If
        End Sub

        Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown

        End Sub
        Sub numero_boleta()
            Dim dts As New DataTable
            Dim strSQL As String = ""
            If Me.SPrestamo = True Then
                strSQL = "select  isnull(count(boleta),0)boleta from SPrestamo "
            Else
                strSQL = "select  isnull(count(boleta),0)boleta from Prestamo "
            End If
            cFunciones.Llenar_Tabla_Generico(strSQL, dts, CadenaConexionSeePOS)
            If dts.Rows.Count > 0 Then
                txt_boleta.Text = CInt(dts.Rows(0).Item("boleta")) + 1
            End If
        End Sub

        Private Function ProductoPrestamo(_Codigo As String) As Boolean
            Dim resultado As Boolean = False
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select CodigoPrestamo from Inventario where Codigo = " & _Codigo, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If CDec(dt.Rows(0).Item("CodigoPrestamo")) > 0 Then
                    resultado = True
                End If
            End If
            Return resultado
        End Function

        Sub agregar_producto()
            Try
                'If Me.ProductoPrestamo(Me.txt_codigo.Text) = False Then
                '    MsgBox("El producto no se puede prestar, no esta registrado para prestarlo.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                '    Exit Sub
                'End If

                Dim codigo, descripcion, cantidad, precio As String
                'If txt_cantidad.Value > txt_existencia_act.Text And rb_salida.Checked = True Then
                '    MsgBox("No se puede prestar esta cantidad porque es mayor a lo que existe en inventario", MsgBoxStyle.Exclamation, "Cantidad sobrepasa el limite")
                '    Exit Sub
                'End If
                codigo = txt_codigo.Text
                descripcion = txt_descripcion.Text
                cantidad = txt_cantidad.Text
                precio = txt_precio.Text

                If IsNumeric(cantidad) = True Then
                    If CDec(cantidad) > 0 Then
                        datalistado.Rows.Add(codigo, lb_id.Text, descripcion, cantidad, precio)
                        limpiar_valores()
                        txtCodArticulo.Focus()
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
        Sub limpiar_valores()
            txtCodArticulo.Text = ""
            txt_codigo.Text = ""
            txt_prestamo.Text = ""
            txt_precio.Text = ""
            txt_cantidad.Text = ""
            txt_descripcion.Text = ""
            txt_existencia_act.Text = ""
            txt_cantidad.BackColor = Color.White
        End Sub
        Private Sub frm_prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txt_codigo.Focus()
            llenar_empresas()
            numero_boleta()

            Me.btnAceptarSolicitud.Enabled = False
            Me.btnAceptarSolicitud.Visible = False
            Me.btnRechazarSolicitud.Enabled = False
            Me.btnRechazarSolicitud.Visible = False

            If Me.IdSPrestamo > 0 Then
                SPrestamo = False
                Me.btnAceptarSolicitud.Enabled = True
                Me.btnAceptarSolicitud.Visible = True
                Me.btnRechazarSolicitud.Enabled = True
                Me.btnRechazarSolicitud.Visible = True
                Me.bt_nuevo.Enabled = False
                Me.bt_nuevo.Visible = False
                Me.bt_guardar.Enabled = False
                Me.bt_guardar.Visible = False
                Me.bt_editar.Enabled = False
                Me.bt_editar.Visible = False
                Me.bt_buscar.Enabled = False
                Me.bt_buscar.Visible = False
                Me.bt_eliminar.Enabled = False
                Me.bt_eliminar.Visible = False
                Me.ToolStripButton2.Enabled = False
                Me.ToolStripButton2.Visible = False
                Me.AbrirSolicitud()
            End If

            If SPrestamo = True Then
                Me.txtBoletaProveedor.Text = "0"
                Me.txtBoletaProveedor.Enabled = False
                Me.cbo_destino.SelectedValue = Me.Id_Empresa_Actual
                Me.cbo_destino.Enabled = False
                Me.txt_transportista.Text = "  "
                Me.txt_transportista.Enabled = False
            End If

        End Sub
        Function obtener_num_id()
            Dim dt As New DataTable
            Dim id As Integer
            Dim Tabla As String = IIf(Me.SPrestamo = True, "SPrestamo", "Prestamo")
            cFunciones.Llenar_Tabla_Generico("SELECT isnull(MAX(id),0)as id from " & Tabla & "", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                id = dt.Rows(0).Item("id")
                Return id
            Else
            End If
        End Function
        Sub guardar_detalle()
            Dim dts_detalle As New vprestamo_detalle
            Dim func_detalle As New fprestamo_detalle

            dts_detalle.gid_prestamo = obtener_num_id()

            For i As Integer = 0 To datalistado.Rows.Count - 1

                dts_detalle.gcodigo = datalistado.Rows(i).Cells(0).Value
                dts_detalle.gdescripcion = datalistado.Rows(i).Cells(2).Value
                dts_detalle.gcantidad = datalistado.Rows(i).Cells(3).Value
                dts_detalle.gprecio = datalistado.Rows(i).Cells(4).Value
                dts_detalle.gdevuelto = 0
                dts_detalle.gentregado = 0
                func_detalle.insertar(dts_detalle, Me.SPrestamo)

            Next
        End Sub
        Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
            If rb_entrada.Checked = False And rb_salida.Checked = False Then
                MsgBox("Primero seleccione el tipo de prestamo si es de entrada o salida", MsgBoxStyle.Exclamation, "Agregar producto")
                Exit Sub
            End If

            If txt_codigo.Text <> "" Then
                agregar_producto()
            Else
                MsgBox("Agregar producto", MsgBoxStyle.Information, "Agregar Producto")
                txtCodArticulo.Focus()
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

        Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
            guardar()
        End Sub
        Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
            End
        End Sub
        Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs)

        End Sub
        Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
            limpiar()
            numero_boleta()
        End Sub

        Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
            Dim frm As New frm_buscar_prestamo
            Try
                frm.ShowDialog()
                lb_id.Text = frm.codigo
                If frm.codigo = "" Then
                    Exit Sub
                End If
                cargar_informacion_prestamo(frm.codigo)
                bt_guardar.Enabled = False : bt_guardar.Text = "Guardar"
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End Sub
        Sub cargar_informacion_prestamo(codigo As String)
            Dim dts As New vprestamo
            Dim func As New fprestamo
            Dim func_detalles As New fprestamo_detalle
            Dim dt As DataTable
            Dim dt_detalles As DataTable
            Try
                dts.gid = codigo
                dt = func.buscar(codigo, False, Me.SPrestamo)
                dt_detalles = func_detalles.buscar(codigo, Me.SPrestamo)

                If dt.Rows.Count > 0 Then


                    lb_id.Text = dt.Rows(0).Item("id")
                    txt_boleta.Text = dt.Rows(0).Item("boleta")
                    cbo_destinatario.SelectedValue = dt.Rows(0).Item("destinatario")
                    cbo_destino.SelectedValue = dt.Rows(0).Item("destino")
                    txt_transportista.Text = dt.Rows(0).Item("transportista")
                    dt_fecha.Text = dt.Rows(0).Item("fecha")
                    rb_entrada.Checked = dt.Rows(0).Item("entrada")
                    rb_salida.Checked = dt.Rows(0).Item("salida")
                    ck_anulado.Checked = dt.Rows(0).Item("anulado")
                    ck_estado.Checked = dt.Rows(0).Item("estado")
                    Me.txtBoletaProveedor.Text = dt.Rows(0).Item("BoletaProveedor")

                    If ck_anulado.Checked = True Then
                        lblanulado.Visible = True
                        gp_1.Enabled = False
                        gp_2.Enabled = False
                        bt_eliminar.Enabled = False
                        bt_devolucion.Enabled = False
                    Else
                        lblanulado.Visible = False
                        gp_1.Enabled = True
                        gp_2.Enabled = True
                        bt_eliminar.Enabled = True
                    End If

                    If ck_estado.Checked = True Then
                        lb_entregado.Visible = True
                        gp_1.Enabled = False
                        gp_2.Enabled = False
                        bt_eliminar.Enabled = False
                        bt_devolucion.Enabled = False

                    ElseIf ck_anulado.Checked = False Then
                        lb_entregado.Visible = False
                        gp_1.Enabled = False
                        gp_2.Enabled = False
                        bt_eliminar.Enabled = True
                        bt_devolucion.Enabled = True
                    End If

                    datalistado.DataSource = dt_detalles
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
                dt = func.buscar(codigo)

                If dt.Rows.Count > 0 Then

                    txt_codigo.Text = dt.Rows(0).Item("codigo")
                    txt_descripcion.Text = dt.Rows(0).Item("descripcion")
                    txt_prestamo.Text = dt.Rows(0).Item("cantidad")
                    txt_precio.Text = dt.Rows(0).Item("precio")

                Else
                    MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
            'Try
            '    Dim id As String
            '    id = Me.datalistado.SelectedCells.Item(0).Value
            '    cargar_informacion_prestamo_detalle(id)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try
        End Sub

        Private Sub bt_guardar_dev_Click(sender As Object, e As EventArgs)
            Dim func As New Conexion
            'func.actualizar("inventario", "")
        End Sub

        Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
            Try
                Dim dts As New vprestamo
                Dim func As New fprestamo
                Dim dts_prestamo As New DataTable

                dts.gid = lb_id.Text
                cFunciones.Llenar_Tabla_Generico("select * from devolucion_prestamo where id_prestamo = " & lb_id.Text, dts_prestamo, CadenaConexionSeePOS)

                If dts_prestamo.Rows.Count > 0 Then
                    MsgBox("No se puede Anular el prestamo porque este ya tiene devoluciones, primero anular las devoluciones, para luego poder anular el prestamo", MsgBoxStyle.Exclamation, "Anulación")
                    Exit Sub
                End If
                If MsgBox("Desea anular este registro?", MsgBoxStyle.YesNo, "Anular") = MsgBoxResult.Yes Then
                    If func.eliminar(dts, Me.SPrestamo) Then
                        MsgBox("Eliminado Correctamente")
                        limpiar()
                    Else
                        MsgBox("Error al intentar Eliminar ")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
            Try
                Dim PrestamoPVE As New Reporte_prestamoPVE
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings

                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(15)

                CrystalReportsConexion.LoadReportViewer(Nothing, PrestamoPVE, True)
                PrestamoPVE.SetParameterValue(0, lb_id.Text)
                PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            End Try
        End Sub

        Private Sub DevoluciónToolStripMenuItem_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub frm_prestamos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
            frm_presentacion.Close()
        End Sub

        Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub HabilitaInhabilita()

        End Sub

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        Dim usua As Usuario_Logeado
        Dim Id_Usuario As String = ""
        Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
            If e.KeyCode = Keys.Enter Then
                Dim cConexion As New LcPymes_5._2.Conexion
                Dim rs As SqlDataReader
                If e.KeyCode = Keys.Enter Then
                    If txtUsuario.Text <> "" Then
                        rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                        If rs.HasRows = False Then
                            Me.Id_Usuario = ""
                            MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                            txtUsuario.Focus()
                        End If
                        While rs.Read
                            Try
                                Me.ToolStrip1.Enabled = False
                                Me.gp_1.Enabled = False
                                Me.gp_2.Enabled = False

                                Me.Id_Usuario = rs("Cedula")
                                PMU = VSM(rs("Cedula"), "PrestamosBodega") 'Carga los privilegios del usuario con el modulo
                                If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                                Me.ToolStrip1.Enabled = True
                                Me.gp_1.Enabled = True
                                Me.gp_2.Enabled = True

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

        Private Sub cbo_destino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_destino.SelectedIndexChanged, cbo_destinatario.SelectedIndexChanged
            On Error Resume Next
            If Me.cbo_destinatario.SelectedValue = Me.Id_Empresa_Actual Then
                Me.rb_salida.Checked = True
            End If
            If Me.cbo_destino.SelectedValue = Me.Id_Empresa_Actual Then
                Me.rb_entrada.Checked = True
            End If
            If Me.cbo_destinatario.SelectedValue <> Me.Id_Empresa_Actual And Me.cbo_destino.SelectedValue <> Me.Id_Empresa_Actual Then
                Me.rb_entrada.Checked = False
                Me.rb_salida.Checked = False
            End If
            If Me.cbo_destinatario.SelectedValue = Me.Id_Empresa_Actual And Me.cbo_destino.SelectedValue = Me.Id_Empresa_Actual Then
                Me.rb_entrada.Checked = False
                Me.rb_salida.Checked = False
            End If
        End Sub

        Private Sub txtCodArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodArticulo.KeyDown
            If e.KeyCode = Keys.Enter Then
                If Me.txtCodArticulo.Text <> "" Then
                    Me.CargarDatosInventaro_x_CodArticulos(Me.txtCodArticulo.Text)
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

        Private Sub datalistado_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellValueChanged
            Try
                Dim Cantidad As String = Me.datalistado.Item("cantidad", e.RowIndex).Value
                If Cantidad <> "" Then
                    If IsNumeric(Cantidad) = True Then
                        If CDec(Cantidad) > 0 Then
                            Exit Sub
                        End If
                    End If
                End If
                Me.datalistado.Item("cantidad", e.RowIndex).Value = 1
            Catch ex As Exception
            End Try
        End Sub

        Private Sub btnAceptarSolicitud_Click(sender As Object, e As EventArgs) Handles btnAceptarSolicitud.Click
            guardar()
        End Sub

        Private Sub btnRechazarSolicitud_Click(sender As Object, e As EventArgs) Handles btnRechazarSolicitud.Click
            'debe marcar el prestamo en la nube
            'para marcarlo como rechazado.
            Me.Close()
        End Sub
    End Class

End Namespace
