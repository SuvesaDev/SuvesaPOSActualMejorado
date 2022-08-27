Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class frmReenvioCorreo

    Private Sub CargarFacturas_x_Fechas()
        Dim PVE As String = IIf(Me.ckPVE.Checked = False, "PVE", "")
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id, Fecha, Num_Factura, Cod_Cliente, Nombre_Cliente, Tipo, Total, ConsecutivoMH, ClaveMH, EstadoMH, isnull(CorreoComprobante,'') as Correo from Ventas left join Clientes  on Ventas.Cod_Cliente = Clientes.identificacion where dbo.DateOnly(Fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.DateOnly(Fecha) <= dbo.DateOnly('" & Me.dtpHasta.Value.ToShortDateString & "') and Tipo not in('APA','" & PVE & "') and Nombre_Cliente like '%" & Me.txtDetalle.Text & "%'", dt, CadenaConexionSeePOS)

        Me.viewComprobantes.Columns.Clear()
        Me.viewComprobantes.Columns.Add("Id", "Id")
        Me.viewComprobantes.Columns("Id").Visible = False
        Me.viewComprobantes.Columns.Add("Fecha", "Fecha")
        Me.viewComprobantes.Columns.Add("Nombre_Cliente", "Cliente")
        Me.viewComprobantes.Columns.Add("Tipo", "Tipo")
        Me.viewComprobantes.Columns.Add("Total", "Total")
        Me.viewComprobantes.Columns("Total").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.viewComprobantes.Columns("Total").DefaultCellStyle.Format = "N2"
        Me.viewComprobantes.Columns.Add("ConsecutivoMH", "Consecutivo")
        Me.viewComprobantes.Columns.Add("EstadoMH", "Estado")
        Me.viewComprobantes.Columns.Add("Correo", "Correo")
        Me.viewComprobantes.Columns("Correo").Visible = False
        Me.viewComprobantes.Columns.Add("Cod_Cliente", "Cod_Cliente")
        Me.viewComprobantes.Columns("Cod_Cliente").Visible = False

        Dim Index As Integer = 0
        Me.viewComprobantes.Rows.Clear()

        For Each r As DataRow In dt.Rows

            Me.viewComprobantes.Rows.Add()
            Me.viewComprobantes.Item("Id", Index).Value = r.Item("Id")
            Me.viewComprobantes.Item("Fecha", Index).Value = r.Item("Fecha")
            Me.viewComprobantes.Item("Cod_Cliente", Index).Value = r.Item("Cod_Cliente")
            Me.viewComprobantes.Item("Nombre_Cliente", Index).Value = r.Item("Nombre_Cliente")
            Me.viewComprobantes.Item("Tipo", Index).Value = r.Item("Tipo")
            Me.viewComprobantes.Item("Total", Index).Value = r.Item("Total")
            Me.viewComprobantes.Item("ConsecutivoMH", Index).Value = r.Item("ConsecutivoMH")
            Me.viewComprobantes.Item("EstadoMH", Index).Value = r.Item("EstadoMH")
            Me.viewComprobantes.Item("Correo", Index).Value = r.Item("Correo")
            Index += 1

        Next

    End Sub

    Private Sub ReenviarCorreo(_Id As String)
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Ventas set EnviadoMH = 0, EstadoMH = 'procesando' Where Id = " & _Id, CommandType.Text)
            Me.CargarFacturas_x_Fechas()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub frmReenvioCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarFacturas_x_Fechas()
        CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.CargarFacturas_x_Fechas()
    End Sub

    Private Sub viewComprobantes_CellEnter(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewComprobantes.CellEnter
        Dim estado As String = Me.viewComprobantes.Item("EstadoMH", e.RowIndex).Value
        Dim id As String = Me.viewComprobantes.Item("Id", Me.viewComprobantes.CurrentRow.Index).Value
        Dim cod_cliente As String = Me.viewComprobantes.Item("Cod_Cliente", e.RowIndex).Value
        Dim tipo As String = Me.viewComprobantes.Item("Tipo", e.RowIndex).Value

        If estado = "aceptado" And tipo <> "PVE" Then
            Me.btnReenviar.Enabled = True
        Else
            Me.btnReenviar.Enabled = False
        End If
        Me.btnNotaCredito.Enabled = True

        If cod_cliente <> "0" And cod_cliente <> "" And tipo <> "PVE" Then
            Me.btnCanbiarCorreo.Enabled = True
        Else
            Me.btnCanbiarCorreo.Enabled = False
        End If

        Me.lblCorreo.Text = Me.CorreoComprobantes(cod_cliente)
    End Sub

    Private Sub btnReenviar_Click(sender As Object, e As EventArgs) Handles btnReenviar.Click
        Dim id As String = Me.viewComprobantes.Item("Id", Me.viewComprobantes.CurrentRow.Index).Value
        Me.ReenviarCorreo(id)
    End Sub

    Private Function CorreoComprobantes(_Id As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from clientes Where identificacion = '" & _Id & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("CorreoComprobante")
        Else
            Return ""
        End If
    End Function

    Private Sub btnCanbiarCorreo_Click(sender As Object, e As EventArgs) Handles btnCanbiarCorreo.Click
        Try
            Dim Id As String = Me.viewComprobantes.Item("Cod_Cliente", Me.viewComprobantes.CurrentRow.Index).Value
            If Id <> "0" And Id <> "" Then
                Dim frm As New frmCambiarCorreo
                frm.CargarCorreos(Me.lblCorreo.Text)
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update Clientes set Correocomprobante = '" & frm.txtCorreos.Text & "' where Identificacion = " & Id, CommandType.Text)
                    Me.lblCorreo.Text = Me.CorreoComprobantes(Id)

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Num_Caja As Integer = 0
    Private Caja_Factura As Integer = 0

    Private Function CajaAbierta(ByVal _caja As Integer) As Boolean
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * from aperturacaja where estado = 'A' and anulado = 0 and num_caja = " & _caja, dts, CadenaConexionSeePOS)
            If dts.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            Return False
        End Try
    End Function

    Private Sub btnNotaCredito_Click(sender As Object, e As EventArgs) Handles btnNotaCredito.Click
        If MsgBox("Desea Generar la Devolucion Total de la Factura", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim frmEncargado As New frmSeleccionarEncargadoDevolucion
        If frmEncargado.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim IdUsuarioEncargado As String = frmEncargado.cboEncargado.Text
            Dim NotasDevolucion As String = frmEncargado.txtNotasDevolucion.Text

            Dim Tipo As String = Me.viewComprobantes.Item("Tipo", Me.viewComprobantes.CurrentRow.Index).Value

            If Tipo = "CON" Or Tipo = "PVE" Or Tipo = "TCO" Or Tipo = "MCO" Then
                Dim frm As New frmOpcionCaja
                frm.ShowDialog()
                Me.Caja_Factura = frm.Caja
                '*****************************************SELECCIONA CAJA **********************************************************
                If CajaAbierta(Caja_Factura) = False Then
                    MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
                    Exit Sub
                End If
            Else
                Me.Caja_Factura = 0
            End If

            Dim Id As String = Me.viewComprobantes.Item("Id", Me.viewComprobantes.CurrentRow.Index).Value
            Dim Generar As New OBSoluciones.Utilidades.RegenerarComprobantes(OBSoluciones.TipoComprobante.Factura, Id, Me.Caja_Factura)
            Dim IdDevolucion As String = Generar.NotaCredito(IdUsuarioEncargado, NotasDevolucion)

            If CDec(IdDevolucion) > 0 Then
                Dim visor As New frmVisorReportes
                Dim recibo_reportePVE As New ReporteDevolucionesVentas_PVE
                Dim opcaja As New frmOpcionCaja
                opcaja.Text = "Elija a la caja que desea mandar la impresión"
                opcaja.ShowDialog()
                If opcaja.Caja = 1 Then
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                    recibo_reportePVE.SetParameterValue(0, CDbl(IdDevolucion))
                    CrystalReportsConexion.LoadReportViewer(Nothing, recibo_reportePVE, True, CadenaConexionSeePOS)
                    recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    If MsgBox("Desea imprimir una copia de la devolucion", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                        recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If
                Else
                    opcaja.Caja = 2
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                    recibo_reportePVE.SetParameterValue(0, CDbl(IdDevolucion))
                    CrystalReportsConexion.LoadReportViewer(Nothing, recibo_reportePVE, True, CadenaConexionSeePOS)
                    recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    If MsgBox("Desea imprimir una copia de la devolucion", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                        recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If
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

    Dim facturaPVE As New Reporte_FacturaPVEs
    Private Sub btnImprimirPVE_Click(sender As Object, e As EventArgs) Handles btnImprimirPVE.Click
        Dim id As String = "0"
        For Each row As DataGridViewRow In Me.viewComprobantes.Rows
            id = row.Cells("Id").Value 'Me.viewComprobantes.Item("Id", Me.viewComprobantes.CurrentRow.Index).Value
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

            facturaPVE.Refresh()
            facturaPVE.SetParameterValue(0, False)
            facturaPVE.SetParameterValue(1, False)
            facturaPVE.SetParameterValue(2, id)
            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            If MsgBox("Desea Continuar imprimiendo", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.No Then
                Exit For
            End If
        Next
    End Sub

    Private Sub viewComprobantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewComprobantes.CellDoubleClick
        Dim id As String = Me.viewComprobantes.Item("Id", Me.viewComprobantes.CurrentRow.Index).Value
        Dim frm As New Facturacion
        frm.MdiParent = Me.ParentForm
        frm.Show()
        frm.AbreDesdeAfuera(id)
    End Sub

End Class