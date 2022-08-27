Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmPagarVariasJuntas

    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0

    Private Index As Integer = 0
    Private Sub CargarFacturasPendientes()
        Dim frm As New frmBuscarFacturaPendiente
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim filas As System.Collections.Generic.List(Of DataGridViewRow) = (From r As DataGridViewRow In frm.viewDatos.Rows Where r.Cells("Usar").Value = True Select r).ToList()
            If filas.Count > 0 Then
                For Each r As DataGridViewRow In filas

                    Dim FilaExiste As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewDatos.Rows
                                                         Where x.Cells("cId").Value = r.Cells("Id_Factura").Value
                                                         Select x).ToList()

                    If Not FilaExiste.Count > 0 Then
                        Dim Id As String = r.Cells("Id_Factura").Value
                        Dim PuntodeVenta As String = r.Cells("PuntoVenta").Value
                        Dim BasedeDatos As String = r.Cells("Basededatos").Value
                        Dim Factura As String = r.Cells("Num_Factura").Value
                        Dim Cliente As String = r.Cells("Cliente").Value
                        Dim Total As String = r.Cells("Total").Value 'aqui debe de cargar el saldo

                        Me.viewDatos.Rows.Add()
                        Me.viewDatos.Item("cId", Me.Index).Value = Id
                        Me.viewDatos.Item("cPuntoVenta", Me.Index).Value = PuntodeVenta
                        Me.viewDatos.Item("cBasedeDatos", Me.Index).Value = BasedeDatos
                        Me.viewDatos.Item("cNumFactura", Me.Index).Value = Factura
                        Me.viewDatos.Item("cCliente", Me.Index).Value = Cliente
                        Me.viewDatos.Item("cTotal", Me.Index).Value = CDec(Total)
                        Me.viewDatos.Item("cAbono", Me.Index).Value = CDec(Total)

                        Me.Index += 1
                        Me.CalcularTotal()
                    End If
                Next
            Else
                Dim FilaExiste As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewDatos.Rows
                                                        Where x.Cells("cId").Value = frm.viewDatos.Item("Id_Factura", frm.viewDatos.CurrentRow.Index).Value
                                                        Select x).ToList()

                If Not FilaExiste.Count > 0 Then
                    Dim Id As String = frm.viewDatos.Item("Id_Factura", frm.viewDatos.CurrentRow.Index).Value
                    Dim PuntodeVenta As String = frm.viewDatos.Item("PuntoVenta", frm.viewDatos.CurrentRow.Index).Value
                    Dim BasedeDatos As String = frm.viewDatos.Item("Basededatos", frm.viewDatos.CurrentRow.Index).Value
                    Dim Factura As String = frm.viewDatos.Item("Num_Factura", frm.viewDatos.CurrentRow.Index).Value
                    Dim Cliente As String = frm.viewDatos.Item("Cliente", frm.viewDatos.CurrentRow.Index).Value
                    Dim Total As String = frm.viewDatos.Item("Total", frm.viewDatos.CurrentRow.Index).Value 'aqui debe de cargar el saldo

                    Me.viewDatos.Rows.Add()
                    Me.viewDatos.Item("cId", Me.Index).Value = Id
                    Me.viewDatos.Item("cPuntoVenta", Me.Index).Value = PuntodeVenta
                    Me.viewDatos.Item("cBasedeDatos", Me.Index).Value = BasedeDatos
                    Me.viewDatos.Item("cNumFactura", Me.Index).Value = Factura
                    Me.viewDatos.Item("cCliente", Me.Index).Value = Cliente
                    Me.viewDatos.Item("cTotal", Me.Index).Value = CDec(Total)
                    Me.viewDatos.Item("cAbono", Me.Index).Value = CDec(Total)

                    Me.Index += 1
                    Me.CalcularTotal()
                End If
            End If
        End If
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = (From x As DataGridViewRow In Me.viewDatos.Rows Select CDec(x.Cells("cAbono").Value)).Sum
        Me.txtTotalCobro.Text = total.ToString("N2")
        If total > 0 Then
            Me.lblTexto.Text = "Facturas Agregadas = " & Me.Index
        Else
            Me.lblTexto.Text = ""
        End If
    End Sub

    Private Function GetNumRecibo() As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select isnull(max(Recibo),0) + 1 as NumRecibo from ConsecutivoReciboReintegro", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0).Item("NumRecibo"))
        Else
            Return 1
        End If
    End Function

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

    Private Sub Cobrar()
        Dim frm As New frmIngresarFomasdePago
        frm.IgnoraTodo = True
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtTotalCobro.Text)
        frm.TipoFactura = "RFC"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim PuntodeVenta As String = ""
            Dim Id_Factura As String = ""
            Dim Documento As String = Me.GetNumRecibo

            Dim dt As New DataTable
            Dim NApertura As String = ""
            Dim Caja As String = ""
            cFunciones.Llenar_Tabla_Generico("select NApertura, Num_Caja from aperturacaja where Estado = 'A' and Cedula = '" & Me.Id_Usuario & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                NApertura = dt.Rows(0).Item("NApertura")
                Caja = dt.Rows(0).Item("Num_Caja")

                Dim NumeroAbono As String = "0"
                Dim trans As OBSoluciones.SQL.Transaccion
                trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try

                    For Each pago As DataGridViewRow In frm.viewDatos.Rows
                        trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & Documento & ", '" & pago.Cells("cTipoDocumento").Value & "'," & CDec(pago.Cells("cMontoPago").Value) & ", '" & pago.Cells("cFormaPago").Value & "'," & pago.Cells("cDenominacion").Value & ", '" & pago.Cells("cUsuario").Value & "','" & pago.Cells("cNombre").Value & "'," & pago.Cells("cCodMoneda").Value & ", '" & pago.Cells("cNombremoneda").Value & "', " & pago.Cells("cTipoCambio").Value & ", getdate()," & pago.Cells("cNumapertura").Value & ", 0, '" & pago.Cells("cNumeroDocumento").Value & "')", CommandType.Text)
                    Next

                    For Each t As PagoTranferencia In frm.ListaPagosTransferencia
                        trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto, Tipo) values(" & 0 & ", " & NApertura & ", '" & t.Banco & "', '" & t.Cuenta & "', '" & t.Moneda & "', '" & t.NumeroDocumento & "', " & CDec(t.Monto) & ", 'Transferencia')", CommandType.Text)
                    Next

                    For Each f As DataGridViewRow In Me.viewDatos.Rows
                        PuntodeVenta = f.Cells("cBasededatos").Value
                        Id_Factura = f.Cells("cId").Value

                        trans.AddParametroSalida("@Id", NumeroAbono)
                        trans.SetParametro("@IdFactura", Id_Factura)
                        trans.SetParametro("@Fecha", Date.Now)
                        trans.SetParametro("@Monto", CDec(f.Cells("cAbono").Value))
                        trans.SetParametro("@NumRecibo", Documento)
                        trans.SetParametro("@NumApertura", NApertura)
                        trans.Ejecutar("InsertAbonoReintegro", NumeroAbono, 0)

                        If CDec(f.Cells("cAbono").Value) >= CDec(f.Cells("cTotal").Value) Then
                            trans.Ejecutar("Update " & PuntodeVenta & ".dbo.AutorizacionVenta set Cancelada = 1, FechaCancelacion = GETDATE(), IdApertura = " & NApertura & ", NumRecibo = " & Documento & " where Id_Factura = " & Id_Factura, CommandType.Text)
                        End If
                    Next
                    trans.Ejecutar("Update ConsecutivoReciboReintegro Set Recibo = Recibo + 1", CommandType.Text)
                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text & " - ")
                    Exit Sub
                End Try

                Try
                    Dim rpt As New rptReciboContadoFirmado
                    CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)
                    If Caja = 1 Then
                        Dim PrinterSettings1 As New Printing.PrinterSettings
                        Dim PageSettings1 As New Printing.PageSettings
                        'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                        rpt.SetParameterValue(0, Documento)
                        rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                        rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If

                    If Caja = 2 Then
                        Dim PrinterSettings1 As New Printing.PrinterSettings
                        Dim PageSettings1 As New Printing.PageSettings
                        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                        'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                        rpt.SetParameterValue(0, Documento)
                        rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                        rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If
                Catch ex As Exception
                End Try

                Dim frmficha As New frmNumeroFicha
                frmficha.CargarPrimerUsuario(Me.Id_Usuario)
                frmficha.MdiParent = Me.MdiParent
                frmficha.Show()
                Me.Close()

            Else
                MsgBox("No se pudo obtener la informacion de la apertura de caja", MsgBoxStyle.Exclamation, "No se puede procesar la operacion")
                Exit Sub
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        If Me.txtTotalCobro.Text <> "" Then
            If IsNumeric(Me.txtTotalCobro.Text) = True Then
                If CDec(Me.txtTotalCobro.Text) > 0 Then
                    If sender.Name = Me.btnCobrar.Name Then
                        Me.Cobrar()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarFacturasPendientes()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmPagarVariasJuntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.viewDatos.Columns("cTotal").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("cTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("cAbono").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("cAbono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmNumeroFicha
        frm.CargarPrimerUsuario(Me.Id_Usuario)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmReimprimirRecibo
        frm.ShowDialog()
    End Sub

    Private Sub viewDatos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellValueChanged
        
    End Sub

    Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
        If e.KeyCode = Keys.Back Then
            Try
                Me.viewDatos.Rows.Remove(Me.viewDatos.CurrentRow)
                Me.Index -= 1
                Me.CalcularTotal()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub viewDatos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEndEdit
        Dim Total As Decimal = Me.viewDatos.Item("cTotal", e.RowIndex).Value
        Dim val As String = Me.viewDatos.Item("cAbono", e.RowIndex).Value
        If val <> "" Then
            If IsNumeric(val) = True Then
                If CDec(val) > 0 Then
                    If CDec(val) > Total Then
                        Me.viewDatos.Item("cAbono", e.RowIndex).Value = Total
                    End If
                Else
                    Me.viewDatos.Item("cAbono", e.RowIndex).Value = Total
                End If
            Else
                Me.viewDatos.Item("cAbono", e.RowIndex).Value = Total
            End If
        Else
            Me.viewDatos.Item("cAbono", e.RowIndex).Value = Total
        End If
        Me.CalcularTotal()
    End Sub

End Class