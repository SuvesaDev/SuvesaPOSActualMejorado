Imports System.ServiceProcess
Imports System.Data
Imports DevExpress.Utils
Imports System.Drawing.Printing
Imports System.Drawing

Public Class frmConsultaAlbaran
    Inherits FrmPlantilla

    Public Usuario As Usuario_Logeado
    Private IdUsuario As String = ""
    Private MaxDescuento As Decimal = 0
    Private CambiarPrecios As Boolean = False

    Private dlgExportar As New SaveFileDialog With {.Title = "Guardar Documentos", .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments}

    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)
        'exportamos los caracteres de las columnas
        Dim columns As Integer = 0
        For c As Integer = 0 To dgv.Columns.Count - 1
            If dgv.Columns(c).Visible = True Then
                xlWS.cells(1, columns + 1).value = dgv.Columns(c).HeaderText
                columns += 1
            End If
        Next
        'exportamos las cabeceras de columnas
        For r As Integer = 0 To dgv.RowCount - 1
            columns = 0
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Visible = True Then
                    xlWS.cells(r + 2, columns + 1).value = dgv.Item(c, r).Value
                    columns += 1
                End If
            Next
        Next
        'guardamos la hoja de calculo en la ruta especificada
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim frm As New frmReporteAlbaranSinFacturar
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub


    Private Sub Login(_Clave As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre, Porc_Desc, CambiarPrecio from Usuarios where Clave_Interna = '" & _Clave & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.Panel1.Enabled = True
            Me.txtClave.Enabled = False
            Me.MaxDescuento = dt.Rows(0).Item("Porc_Desc")
            Me.CambiarPrecios = dt.Rows(0).Item("CambiarPrecio")
        Else
            Me.txtNombreUsuario.Text = ""
            Me.IdUsuario = ""
            Me.Panel1.Enabled = False
            Me.MaxDescuento = 0
            Me.CambiarPrecios = False
        End If
    End Sub

    Private BanderaGeneralEjecucion As Boolean = False


    Private Function RecursoDisponible() As Boolean
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select * from accesoDLL where Id = 1", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If CBool(dt.Rows(0).Item("Disponible")) = True Then
                Return True
            Else
                MsgBox("Intentelo mas tarde", MsgBoxStyle.Exclamation, "No se puede procesar la operacion.")
                Return False
            End If
        Else
            MsgBox("Intentelo mas tarde", MsgBoxStyle.Exclamation, "No se puede procesar la operacion.")
            Return False
        End If
    End Function

    Private Function ActualizaEstadoRecurso(_Disponible As Boolean) As Boolean
        Dim db As OBSoluciones.SQL.Transaccion
        Try
            db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            db.Ejecutar("update accesoDLL set Disponible = " & IIf(_Disponible = True, 1, 0) & ", Usuario = '" & Me.txtNombreUsuario.Text & "', Equipo = '" & My.Computer.Name & "', Fecha = getdate() where Id = 1", CommandType.Text)
            db.Commit()
            Return True
        Catch ex As Exception
            db.Rollback()
        End Try
        Return False
    End Function

    Private Function Sincronizador() As Boolean
        Dim dlg As WaitDialogForm
        Try

            If Me.RecursoDisponible = True Then
                dlg = New WaitDialogForm("Buscando nuevos albaranes.")
                If Me.ActualizaEstadoRecurso(False) = True Then

                    Dim dll = New APIQVET.main()
                    Dim str = dll.ejecutarAPIQVET(Me.txtNombreUsuario.Text, "1")

                    Me.ActualizaEstadoRecurso(True)
                    If str.Responses() = True Then
                        Me.CargarAlbaranes()
                    Else
                        MsgBox(str.currentException(), MsgBoxStyle.Critical, Me.Text)
                        MsgBox("No se pudo obtener los albaranes", MsgBoxStyle.Critical, Me.Text)
                    End If
                    dlg.Close()
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Me.ActualizaEstadoRecurso(True)
            dlg.Close()
            Return False
        End Try
    End Function

    Private Function ServicioSincronizador() As Boolean
        If Me.BanderaGeneralEjecucion = True Then Exit Function

        Dim dlg As WaitDialogForm
        Try
            dlg = New WaitDialogForm("Buscando nuevos albaranes.")
            Me.btnSincronizacion.Enabled = False
            Dim argumentos As String() = New String(0) {}
            Dim service As ServiceController = New ServiceController("Sincronizador")
            service.Refresh()
            If (service.Status.Equals(ServiceControllerStatus.Stopped)) Then
                BanderaGeneralEjecucion = True
                argumentos(0) = "1," & Me.IdUsuario
                service.Start(argumentos)

                Dim Bandera As Boolean = False
                While Bandera = False
                    service.Refresh()
                    If (service.Status.Equals(ServiceControllerStatus.Stopped)) OrElse (service.Status.Equals(ServiceControllerStatus.StopPending)) Then
                        Bandera = True
                        BanderaGeneralEjecucion = False
                        Me.BackgroundWorker1.RunWorkerAsync()
                        dlg.Close()
                    End If
                End While

                Me.btnSincronizacion.Enabled = False

                Return True
            Else
                service.[Stop]()
                dlg.Close()
                Me.btnSincronizacion.Enabled = True
            End If
        Catch ex As Exception
            BanderaGeneralEjecucion = False
            dlg.Close()
            Me.btnSincronizacion.Enabled = True
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim service As ServiceController = New ServiceController("Sincronizador")
        Dim Bandera As Boolean = False
        While Bandera = False
            service.Refresh()
            If (service.Status.Equals(ServiceControllerStatus.Stopped)) Then
                Bandera = True
                Me.btnSincronizacion.Enabled = True
            End If
        End While
        Me.BackgroundWorker1.Dispose()
    End Sub

    Private Sub CargarAlbaranes()

        'viewDatos

        'If Me.ckFiltrarxFecha.Checked = False And Me.txtMascota.Text = "" And Me.txtCliente.Text = "" Then
        '    MsgBox("Ingrese el nombre del cliente o de la mascotas", MsgBoxStyle.Exclamation, Me.Text)
        '    Exit Sub
        'End If

        Dim dt As New DataTable
        Dim strSQL As String = "Select top 100 Id, Identificacion, Cliente, Mascota, Fecha, Subtotal, Descuento, Impuesto, Total, Facturado, UsuarioClinica as Responsable, cast(0 as bit) as Facturar, cast(0 as bit) as Extranjero from clinica.dbo.viewAlbaran"
        Dim strWhere As String = ""

        If Me.ckSoloPendientes.Checked = True Then
            strWhere = " Where  Facturado = 0 "
        End If

        If Me.ckFiltrarxFecha.Checked = True Then
            If strWhere <> "" Then strWhere += " And " Else strWhere += " Where "
            strWhere += "dbo.dateonly(Fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(Fecha) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.txtCliente.Text <> "" Then
            If strWhere <> "" Then strWhere += " And " Else strWhere += " Where "
            strWhere += "Cliente like '%" & Me.txtCliente.Text & "%'"
        End If

        If Me.txtMascota.Text <> "" Then
            If strWhere <> "" Then strWhere += " And " Else strWhere += " Where "
            strWhere += "Identificacion = '" & Me.txtMascota.Text & "'"
        End If

        dt = New DataTable
        'cFunciones.Llenar_Tabla_Generico(strSQL & strWhere & " Order By Fecha Desc", dt, CadenaConexionSeePOS)

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        dt = db.Ejecutar(strSQL & strWhere & " Order By Fecha Desc", CommandType.Text)

        Try
            Me.viewDatos.DataSource = dt
            Me.ckTodos.Checked = False
            Me.viewDatos.Columns("Id").Visible = False
            'Me.viewDatos.Columns("Identificacion").Visible = False
            Me.viewDatos.Columns("Cliente").ReadOnly = True
            Me.viewDatos.Columns("Mascota").ReadOnly = True

            Me.viewDatos.Columns("Fecha").ReadOnly = True
            'Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"

            Me.viewDatos.Columns("Subtotal").Visible = False
            Me.viewDatos.Columns("Subtotal").ReadOnly = True
            Me.viewDatos.Columns("Subtotal").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.viewDatos.Columns("Descuento").Visible = False
            Me.viewDatos.Columns("Descuento").ReadOnly = True
            Me.viewDatos.Columns("Descuento").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Descuento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.viewDatos.Columns("Impuesto").Visible = False
            Me.viewDatos.Columns("Impuesto").ReadOnly = True
            Me.viewDatos.Columns("Impuesto").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.viewDatos.Columns("Total").ReadOnly = True
            Me.viewDatos.Columns("Total").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            If Me.ckSoloPendientes.Checked = True Then
                Me.viewDatos.Columns("Facturado").Visible = False
                Me.viewDatos.Columns("Facturar").Visible = True
            Else
                Me.viewDatos.Columns("Facturado").ReadOnly = True
                Me.viewDatos.Columns("Facturado").Visible = True
                Me.viewDatos.Columns("Facturar").Visible = False
            End If

            Me.viewDatos.Columns("Responsable").ReadOnly = True

        Catch ex As Exception
        End Try
    End Sub

    Private Sub GenerarFacturas()
        Dim Identificaciones As New System.Collections.Generic.List(Of String)
        Dim Pendientes As New System.Collections.Generic.List(Of DataGridViewRow)

        Identificaciones = (From x As DataGridViewRow In Me.viewDatos.Rows
                            Where x.Cells("Facturar").Value = True
                            Select CStr(x.Cells("Identificacion").Value)).Distinct.ToList

        For Each i As String In Identificaciones
            Pendientes = (From x As DataGridViewRow In Me.viewDatos.Rows
                    Where x.Cells("Facturar").Value = False And x.Cells("Identificacion").Value = i
                    Select x).Distinct.ToList

            If Pendientes.Count > 0 Then
                If MsgBox("Existen " & Pendientes.Count & " albaranes del mismo cliente sin Marcar" & vbCrLf _
                          & " Desea continuar.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Acccion") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        Next

        If Identificaciones.Count > 0 Then
            Dim Nombre As String = ""
            Dim Total As Decimal = 0
            Dim Index As Integer = 0
            Dim frm As New frmConfirmarGenerarFacturas
            frm.Id_Usuario = Me.IdUsuario
            For Each Id As String In Identificaciones
                Nombre = (From x As DataGridViewRow In Me.viewDatos.Rows
                          Where x.Cells("Identificacion").Value = Id And x.Cells("Facturar").Value = True
                          Select CStr(x.Cells("Cliente").Value)).FirstOrDefault()

                Total = (From x As DataGridViewRow In Me.viewDatos.Rows
                         Where x.Cells("Identificacion").Value = Id And x.Cells("Facturar").Value = True
                         Select CDec(x.Cells("Total").Value)).Sum()

                frm.viewDatos.Rows.Add()
                frm.viewDatos.Item("cIdentificacion", Index).Value = Id
                frm.viewDatos.Item("cCliente", Index).Value = Nombre
                frm.viewDatos.Item("cTotal", Index).Value = Total
                frm.viewDatos.Item("cCaja", Index).Value = 1
                frm.viewDatos.Item("cTipo", Index).Value = "TIQUETE"
                Index += 1
            Next

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim frmUsuario As New frmUsuarioFactura
                If frmUsuario.ShowDialog = Windows.Forms.DialogResult.OK Then

                    Dim albaran As Albaran
                    Dim IdFactura As Long = 0
                    For Each Clientes As DataGridViewRow In frm.viewDatos.Rows
                        albaran = New Albaran
                        For Each row As DataGridViewRow In (From x As DataGridViewRow In Me.viewDatos.Rows
                                                            Where x.Cells("Identificacion").Value = Clientes.Cells("cIdentificacion").Value And x.Cells("Facturar").Value = True
                                                            Select x).ToList
                            albaran.Agregar(row.Cells("Id").Value, row.Cells("Extranjero").Value)
                        Next
                        IdFactura = 0
                        IdFactura = albaran.GenerarFactura(frmUsuario.IdUsuario,
                                               Clientes.Cells("cTipo").Value,
                                               Clientes.Cells("cPlazo").Value,
                                               Clientes.Cells("cCaja").Value,
                                               Clientes.Cells("cIdentificacion2").Value,
                                               Clientes.Cells("cCliente").Value,
                                               0)

                        If IdFactura > 0 And Clientes.Cells("cTipo").Value = "CREDITO" Then Me.ImprimirFactura(IdFactura, Clientes.Cells("cCaja").Value)
                    Next
                    Me.CargarAlbaranes()
                    Dim frmOpcionesdePago As New frmBuscarFichasActivas
                    frmOpcionesdePago.CargarPrimerUsuario(frmUsuario.IdUsuario)
                    frmOpcionesdePago.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
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

                Case "CUPONES" 'CUPONES DE RIFAS
                    If PrinterToSelect = 7 Then
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


    Private Sub ImprimirFactura(_Id As Long, _Caja As Integer)
        Dim rptGenerica As New Factura_Generica
        Dim Impresora As String = ImpresoraCredito()

        If Impresora <> "" Then
            CrystalReportsConexion.LoadReportViewer(Nothing, rptGenerica, True)

            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            PrinterSettings1.PrinterName = Impresora

            rptGenerica.SetParameterValue(0, _Id)
            rptGenerica.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            If MsgBox("Desea imprimir una copia", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                rptGenerica.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If            
        End If
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If Me.txtClave.Text <> "" And e.KeyCode = Keys.Enter Then
            Me.Login(Me.txtClave.Text)
        End If
    End Sub
    Private esTermica As Boolean = False
    Private Sub frmConsultaAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpDesde.Value = CDate("01/" & Date.Now.Month & "/" & Date.Now.Year)
        Me.CargarAlbaranes()

        Try
            If GetSetting("SeeSoft", "SeePOS", "estermica") = "" Then
                SaveSetting("SeeSoft", "seepos", "estermica", "false")
                esTermica = False
            Else
                esTermica = GetSetting("SeeSoft", "SeePOS", "estermica")
            End If
        Catch ex As Exception
            SaveSetting("SeeSoft", "seepos", "estermica", "false")
            esTermica = False
        End Try
        Me.Timer1.Start()
    End Sub

    Private Sub NuevoConsultaAlbaran()
        Try
            Dim dll = New APIQVET.main()
            ''Primer parametros = Nombre Usuario'
            ''Segundo parametros = Tipo 1'
            Dim str = dll.ejecutarAPIQVET(Me.txtNombreUsuario.Text, "1")
            MsgBox(str.Responses)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnObtenerDatos_Click(sender As Object, e As EventArgs) Handles btnSincronizacion.Click
        Me.Sincronizador()
    End Sub

    Private Sub btnGenerarFacturas_Click(sender As Object, e As EventArgs) Handles btnGenerarFacturas.Click
        Me.GenerarFacturas()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Dim IdAlbaran As Long = Me.viewDatos.Item("Id", Me.viewDatos.CurrentRow.Index).Value
        Dim frm As New frmEditarAlbaran
        frm.MaxDescuento = Me.MaxDescuento
        frm.CambiarPrecio = Me.CambiarPrecios
        frm.IdAlbaran = IdAlbaran
        frm.IdUsuario = Me.IdUsuario
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            Try
                For Each row As DataGridViewRow In frm.viewDatos.Rows
                    Dim PrecioUnitario As Decimal = (CDec(row.Cells("cTotal").Value) / CDec(row.Cells("cCantidad").Value))
                    'PrecioUnitario = PrecioUnitario * (1 + (CDec(row.Cells("cIva").Value) / 100))

                    If row.Visible = True Then
                        'datos a agregar o modificar
                        If row.Cells("cId").Value > 0 Then
                            'modificar
                            'db.Ejecutar("Update Albaran_Detalle set  CodigoInternoQvet = " & row.Cells("cCodigo").Value & ", Descripcion = '" & row.Cells("cDescripcion").Value & "', Cantidad = " & row.Cells("cCantidad").Value & ", PrecioVenta = " & PrecioUnitario & ", IVA = " & row.Cells("cIva").Value & ", descuento = " & row.Cells("cDescuento").Value & ",Total = " & row.Cells("cTotal").Value & " Where Id = " & row.Cells("cId").Value, CommandType.Text)
                        Else
                            'agregar
                            db.Ejecutar("Insert Into Bitacora_Albaran(Id_Albaran, Usuario_Suvesa, Fecha_Hora, Accion, Observaciones) Values(" & frm.IdAlbaran & ", '" & Me.IdUsuario & "', getdate(), 'Adicion', '" & row.Cells("cDescripcion").Value & ", Cant: " & row.Cells("cCantidad").Value & ", Total: " & row.Cells("cTotal").Value & "')", CommandType.Text)
                            db.Ejecutar("Insert into Albaran_Detalle(idEncabezado, CodigoInternoQvet, Descripcion, Cantidad, PrecioVenta, IVA, descuento, Unidad,Total,Descargar,ResponsableVenta) Values(" & frm.IdAlbaran & ", " & row.Cells("cCodigo").Value & ", '" & row.Cells("cDescripcion").Value & "', " & CDec(row.Cells("cCantidad").Value) & ", " & PrecioUnitario & ", " & CDec(row.Cells("cIva").Value) & ", " & CDec(row.Cells("cDescuento").Value) & ", '" & row.Cells("cUnidad").Value & "', " & CDec(row.Cells("cTotal").Value) & ",1, '" & Me.txtNombreUsuario.Text & "')", CommandType.Text)
                        End If
                    Else
                        'datos a borrar
                        If row.Cells("cMotivo").Value <> "" Then
                            'borrar
                            db.Ejecutar("Insert Into Bitacora_Albaran(Id_Albaran, Usuario_Suvesa, Fecha_Hora, Accion, Observaciones) Values(" & frm.IdAlbaran & ", '" & Me.IdUsuario & "', getdate(), 'Eliminacion', '" & row.Cells("cDescripcion").Value & ", Cant: " & row.Cells("cCantidad").Value & ", Total: " & row.Cells("cTotal").Value & ", Motivo : " & row.Cells("cMotivo").Value & ".')", CommandType.Text)
                            db.Ejecutar("delete from Albaran_Detalle where Id = " & row.Cells("cId").Value, CommandType.Text)
                        End If
                    End If
                Next

                db.Ejecutar("Update Albaran set Extranjero = " & IIf(frm.ckExtranjero.Checked, 1, 0) & " Where Id = " & IdAlbaran, CommandType.Text)

                db.Commit()
            Catch ex As Exception
                db.Rollback()
            End Try

            Me.CargarAlbaranes()
        End If

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs)
        Me.CargarAlbaranes()
    End Sub

    Private Sub ckTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ckTodos.CheckedChanged
        For Each row As DataGridViewRow In Me.viewDatos.Rows
            row.Cells("Facturar").Value = Me.ckTodos.Checked
        Next
    End Sub

    Private Sub txtMascota_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMascota.KeyDown, txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarAlbaranes()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmAgregarDeposito
        frm.Id_Usuario = Me.IdUsuario
        frm.ShowDialog()
    End Sub

    Private Sub CargarForm(ByRef Form As Form)
        Try
            Form.ShowDialog()
        Catch ex As SystemException
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub btnOpcionesdePago_Click(sender As Object, e As EventArgs) Handles btnOpcionesdePago.Click
        'CargarForm(New frmMovimientoCajaPago(Me.Usuario))
        Dim frm As New frmBuscarFichasActivas
        frm.CargarPrimerUsuario(Me.IdUsuario)
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub btnDevoluciones_Click(sender As Object, e As EventArgs) Handles btnDevoluciones.Click
        Dim frm As New MovimientoCaja(Me.Usuario)
        frm.ObligaAnticipo = True
        CargarForm(frm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New FrmDevolucionesVentas
        frm.IsPreDevolucion = True
        CargarForm(frm)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CargarForm(New frmReciboDinero(Me.Usuario))
    End Sub

    Private Sub btnEstadoCuenta_Click(sender As Object, e As EventArgs) Handles btnEstadoCuenta.Click
        Dim frm As New frmEstadoCuentaAlbaran
        frm.ShowDialog()
    End Sub

    Private Sub btnApertura_Click(sender As Object, e As EventArgs) Handles btnApertura.Click
        CargarForm(New AperturaCaja(Me.Usuario))
    End Sub

    Private Sub btnArqueo_Click(sender As Object, e As EventArgs) Handles btnArqueo.Click
        CargarForm(New ArqueoCaja)
    End Sub


    Private Function GetPorcentajeExtranjero() As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select PorcentajeExtranjero from configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("PorcentajeExtranjero")
        End If
        Return 0
    End Function

    Private Sub viewDatos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellValueChanged
        If Me.viewDatos.Columns(e.ColumnIndex).Name = "Extranjero" Then
            Dim Extranjero As Boolean = Me.viewDatos.Item(e.ColumnIndex, e.RowIndex).Value
            Dim Id As Integer = Me.viewDatos.Item("Id", e.RowIndex).Value

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from viewAlbaranDetalle where Id_Albaran = " & Id, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Dim Porcentaje = Me.GetPorcentajeExtranjero
                Dim Subtotal As Decimal = 0
                Dim Descuento As Decimal = 0
                Dim Impuesto As Decimal = 0
                Dim SubtotalTemp As Decimal = 0
                Dim DescuentoTemp As Decimal = 0
                For Each row As DataRow In dt.Rows
                    SubtotalTemp = CDec(row.Item("Cantidad") * row.Item("Precio_Unit"))
                    If Extranjero Then SubtotalTemp = SubtotalTemp * (1 + (Porcentaje / 100))
                    DescuentoTemp = SubtotalTemp * (CDec(row.Item("Descuento") / 100))
                    Subtotal += SubtotalTemp
                    Descuento += DescuentoTemp
                    Impuesto += (SubtotalTemp - DescuentoTemp) * (CDec(row.Item("Impuestos") / 100))
                Next
                Me.viewDatos.Item("Subtotal", e.RowIndex).Value = Subtotal
                Me.viewDatos.Item("Descuento", e.RowIndex).Value = Descuento
                Me.viewDatos.Item("Impuesto", e.RowIndex).Value = Impuesto
                Me.viewDatos.Item("Total", e.RowIndex).Value = Subtotal - Descuento + Impuesto

            End If
        End If
    End Sub

    Private Sub ckExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles ckExtranjero.CheckedChanged
        For Each row As DataGridViewRow In Me.viewDatos.Rows
            row.Cells("Extranjero").Value = Me.ckExtranjero.Checked
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxFecha.CheckedChanged
        Me.dtpDesde.Enabled = Me.ckFiltrarxFecha.Checked
        Me.dtpHasta.Enabled = Me.ckFiltrarxFecha.Checked
    End Sub

    Private Sub btnPedidoWeb_Click(sender As Object, e As EventArgs) Handles btnPedidoWeb.Click
        Dim frm As New frmListaPedidos
        frm.SoloLectura = True
        frm.ShowDialog()
    End Sub

    Private texto As String = "Pedido Web"
    Private Async Sub CargarPedidos()
        Dim cls As New TiendaWeb.apiTienda
        Dim datos As System.Collections.Generic.List(Of TiendaWeb.Pedidos) = Await cls.AllPedidos(1, "processing")
        If IsNothing(datos) Then
            Me.btnPedidoWeb.Text = texto
            Me.btnPedidoWeb.BackColor = System.Drawing.SystemColors.Control
            Me.btnPedidoWeb.ForeColor = Color.Black
        Else
            If datos.Count > 0 Then
                Me.btnPedidoWeb.Text = texto + " (" & datos.Count & ") "
                Me.btnPedidoWeb.BackColor = Color.RoyalBlue
                Me.btnPedidoWeb.ForeColor = Color.Yellow
            Else
                Me.btnPedidoWeb.Text = texto
                Me.btnPedidoWeb.BackColor = System.Drawing.SystemColors.Control
                Me.btnPedidoWeb.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.CargarPedidos()
    End Sub
End Class