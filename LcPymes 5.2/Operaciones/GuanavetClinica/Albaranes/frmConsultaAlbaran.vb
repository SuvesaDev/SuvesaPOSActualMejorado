Imports System.ServiceProcess
Imports System.Data
Imports DevExpress.Utils
Imports System.Drawing.Printing
Imports System.Drawing

Public Class frmConsultaAlbaran
    Inherits FrmPlantilla

    Private IdUsuario As String = ""
    Private MaxDescuento As Decimal = 0
    Private CambiarPrecios As Boolean = False

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
    Private Function ServicioSincronizador() As Boolean
        If Me.BanderaGeneralEjecucion = True Then Exit Function

        Dim dlg As WaitDialogForm
        Try
            dlg = New WaitDialogForm("Buscando nuevos albaranes.")
            Me.btnSincronizacion.Enabled = False
            Dim argumentos As String() = New String(0) {}
            Dim service As ServiceController = New ServiceController("Sincronizador")
            service.Refresh()
            If (service.Status.Equals(ServiceControllerStatus.Stopped)) OrElse (service.Status.Equals(ServiceControllerStatus.StopPending)) Then
                BanderaGeneralEjecucion = True
                argumentos(0) = "1," & Me.IdUsuario
                service.Start(argumentos)

                Dim Bandera As Boolean = False
                While Bandera = False
                    service.Refresh()
                    If (service.Status.Equals(ServiceControllerStatus.Stopped)) OrElse (service.Status.Equals(ServiceControllerStatus.StopPending)) Then
                        Bandera = True
                        BanderaGeneralEjecucion = False
                        Me.btnSincronizacion.Enabled = True
                        dlg.Close()
                    End If
                End While
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

    Private Sub CargarAlbaranes()

        Dim dt As New DataTable
        Dim strSQL As String = "Select Id, Identificacion, Cliente, Mascota, Fecha, Subtotal, Descuento, Impuesto, Total, Facturado, UsuarioClinica as Responsable, cast(0 as bit) as Facturar  from viewAlbaran"
        Dim strWhere As String = ""

        strWhere = " Where dbo.dateonly(Fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(Fecha) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')" & IIf(Me.ckSoloPendientes.Checked = True, " And Facturado = 0 ", "")

        If Me.txtCliente.Text <> "" Then
            strWhere += " And Cliente like '%" & Me.txtCliente.Text & "%'"
        End If

        If Me.txtMascota.Text <> "" Then
            strWhere += " And Mascota like '%" & Me.txtMascota.Text & "%'"
        End If

        cFunciones.Llenar_Tabla_Generico(strSQL & strWhere & " Order By Fecha Desc", dt, CadenaConexionSeePOS)
        Try
            Me.viewDatos.DataSource = dt
            Me.ckTodos.Checked = False
            Me.viewDatos.Columns("Id").Visible = False
            Me.viewDatos.Columns("Identificacion").Visible = False
            Me.viewDatos.Columns("Cliente").ReadOnly = True
            Me.viewDatos.Columns("Mascota").ReadOnly = True

            Me.viewDatos.Columns("Fecha").ReadOnly = True
            Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"

            Me.viewDatos.Columns("Subtotal").ReadOnly = True
            Me.viewDatos.Columns("Subtotal").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.viewDatos.Columns("Descuento").ReadOnly = True
            Me.viewDatos.Columns("Descuento").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Descuento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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

        Catch ex As Exception
        End Try
    End Sub

    Private Sub GenerarFacturas()
        Dim Identificaciones As New System.Collections.Generic.List(Of String)
        Identificaciones = (From x As DataGridViewRow In Me.viewDatos.Rows
                            Where x.Cells("Facturar").Value = True
                            Select CStr(x.Cells("Identificacion").Value)).Distinct.ToList

        If Identificaciones.Count > 0 Then
            Dim Nombre As String = ""
            Dim Total As Decimal = 0
            Dim Index As Integer = 0
            Dim frm As New frmConfirmarGenerarFacturas
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
                frm.viewDatos.Item("cTipo", Index).Value = "CONTADO"
                Index += 1
            Next

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim albaran As Albaran
                Dim IdFactura As Long = 0
                For Each Clientes As DataGridViewRow In frm.viewDatos.Rows
                    albaran = New Albaran
                    For Each row As DataGridViewRow In (From x As DataGridViewRow In Me.viewDatos.Rows
                                                        Where x.Cells("Identificacion").Value = Clientes.Cells("cIdentificacion").Value And x.Cells("Facturar").Value = True
                                                        Select x).ToList
                        albaran.Agregar(row.Cells("Id").Value)
                    Next
                    IdFactura = 0
                    IdFactura = albaran.GenerarFactura(Me.IdUsuario,
                                           Clientes.Cells("cTipo").Value,
                                           Clientes.Cells("cPlazo").Value,
                                           Clientes.Cells("cCaja").Value,
                                           Clientes.Cells("cIdentificacion2").Value,
                                           Clientes.Cells("cCliente").Value)

                    If IdFactura > 0 And Clientes.Cells("cTipo").Value = "CREDITO" Then Me.ImprimirFactura(IdFactura, Clientes.Cells("cCaja").Value)
                Next
                Me.CargarAlbaranes()
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
            rptGenerica.PrintToPrinter(PrinterSettings1, PageSettings1, False)
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

    End Sub

    Private Sub btnObtenerDatos_Click(sender As Object, e As EventArgs) Handles btnSincronizacion.Click

        If Me.ServicioSincronizador() = True Then
            Me.CargarAlbaranes()
        End If
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
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            Try
                For Each row As DataGridViewRow In frm.viewDatos.Rows

                    If row.Visible = True Then
                        'datos a agregar o modificar
                        If row.Cells("cId").Value > 0 Then
                            'modificar
                        Else
                            'agregar
                            db.Ejecutar("Insert Into Bitacora_Albaran(Id_Albaran, Usuario_Suvesa, Fecha_Hora, Accion, Observaciones) Values(" & frm.IdAlbaran & ", '" & Me.IdUsuario & "', getdate(), 'Adicion', '" & row.Cells("cDescripcion").Value & ", Cant: " & row.Cells("cCantidad").Value & ", Total: " & row.Cells("cTotal").Value & "')", CommandType.Text)
                            db.Ejecutar("Insert into Albaran_Detalle(idEncabezado, CodigoInternoQvet, Descripcion, Cantidad, PrecioVenta, IVA, descuento, Unidad,Total) Values(" & frm.IdAlbaran & ", " & row.Cells("cCodigo").Value & ", '" & row.Cells("cDescripcion").Value & "', " & CDec(row.Cells("cCantidad").Value) & ", " & CDec(row.Cells("cPrecio").Value) & ", " & CDec(row.Cells("cIva").Value) & ", " & CDec(row.Cells("cDescuento").Value) & ", '" & row.Cells("cUnidad").Value & "', " & CDec(row.Cells("cTotal").Value) & ")", CommandType.Text)
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
End Class