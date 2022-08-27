Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing

Public Class frmCierreOrden
    Private rptCierreOT As New rptBoletaOT_Cierre
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

    Private Sub Imprimir(_IdOT As String)
        Dim PrinterSettings1 As New Printing.PrinterSettings
        Dim PageSettings1 As New Printing.PageSettings

        Dim frm As New frmOpcionCaja
        frm.ShowDialog()
        Dim Caja As Integer = frm.Caja
        Dim Impresora As Integer = 0

        Select Case Caja
            Case 1 : Impresora = 3
            Case 2 : Impresora = 5
        End Select

        rptCierreOT.Refresh()
        rptCierreOT.SetParameterValue(0, _IdOT)
        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(Impresora)        
        rptCierreOT.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        If MsgBox("Desea imprimir una copia de la boleta", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
            rptCierreOT.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmAsistenteCierre
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Imprimir(frm.IdCierre)
            CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Dim dt As New DataTable
        Dim cls As New CierreOrdenTrabajo
        dt = cls.CierreOrden(Me.txtBuscar.Text)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
    End Sub

    Private Sub frmCierreOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
        CrystalReportsConexion.LoadReportViewer(Nothing, rptCierreOT, True)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.CargarDatos()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If MsgBox("Desea Imprimir la boleta de salida", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim id As String = Me.viewDatos.Item("IdCierre", Me.viewDatos.CurrentRow.Index).Value
            Me.Imprimir(id)
        End If
    End Sub
End Class