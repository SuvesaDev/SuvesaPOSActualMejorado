Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class frmReimprimirRecibo

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

    Private Function GetNumCaja(_Recibo As String) As Integer
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select distinct ac.Num_Caja from autorizacionventa av inner join aperturacaja ac on av.idapertura = ac.napertura where NumRecibo = 3", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Num_Caja")
        Else
            Return 0
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim documento As String = Me.txtNumeroRecibo.Text
        If Me.txtNumeroRecibo.Text <> "" Then
            If IsNumeric(Me.txtNumeroRecibo.Text) = True Then
                If CDec(Me.txtNumeroRecibo.Text) > 0 Then
                    Try
                        Dim caja As String = Me.GetNumCaja(documento)
                        If caja > 0 Then
                            Dim rpt As New rptReciboContadoFirmado
                            CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)
                            If caja = 1 Then
                                Dim PrinterSettings1 As New Printing.PrinterSettings
                                Dim PageSettings1 As New Printing.PageSettings
                                'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                                rpt.SetParameterValue(0, documento)
                                rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                                rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            End If

                            If caja = 2 Then
                                Dim PrinterSettings1 As New Printing.PrinterSettings
                                Dim PageSettings1 As New Printing.PageSettings
                                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                                'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                                rpt.SetParameterValue(0, documento)
                                rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                                rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            End If
                        Else
                            MsgBox("No se encontro informacion del recibo.", MsgBoxStyle.Exclamation, Text)
                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class