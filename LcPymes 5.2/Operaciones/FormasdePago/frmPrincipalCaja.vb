Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing
Public Class frmPrincipalCaja

    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""

    Private Sub IniciaFormularioFicha()
        Dim frm As New frmNumeroFicha
        frm.CargarPrimerUsuario(Me.Id_Usuario)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frmPrincipalCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema Control de Caja (04112022)"
        Me.lblUsuario.Text = Me.NombreUsuario
        Me.IniciaFormularioFicha()
        clsImpresion.InicalizaReporte("SeePOS")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.IniciaFormularioFicha()
        GeneralCaja.clsImpresion.InicalizaReporte("SeePOS")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim frm As New frmTipoCambio
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim frm As New Credomatic.Operaciones.frmConsultaVoucher
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnResumenCaja_Click(sender As Object, e As EventArgs) Handles btnResumenCaja.Click
        Dim frm As New frmResumenCaja
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnFichasActivas_Click(sender As Object, e As EventArgs) Handles btnFichasActivas.Click
        Dim frm As New frmBuscarFichasActivas
        frm.CargarPrimerUsuario(Me.Id_Usuario)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnArchivar_Click(sender As Object, e As EventArgs) Handles btnArchivar.Click
        Dim frm As New frmArchivarCredito
        frm.Id_Usuario = Me.Id_Usuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositosToolStripMenuItem.Click
        Dim frm As New frmAgregarDeposito
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.IdArqueo = 0
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ArqueoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArqueoToolStripMenuItem.Click
        Dim frm As New frmArqueoCaja
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Function GetUsuario(_Cedula As String) As Usuario_Logeado
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario as Cedula, Nombre, Clave_Interna, Clave_Entrada from Usuarios where Id_Usuario = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        Dim usua As New Usuario_Logeado
        usua.Cedula = 0
        usua.Nombre = ""
        usua.Clave_Interna = ""
        usua.Clave_Entrada = ""
        usua.Abrir_Credito = 0
        usua.Anu_Cotizacion = False
        usua.Anu_Venta = False
        usua.AnuRecibos = False
        usua.Aplicar_Desc = False
        usua.CambiarPrecio = False
        usua.Exist_Negativa = False
        usua.Perfil = "0"
        usua.Porc_Desc = 0
        usua.Porc_Precio = 0
        usua.RecibosDinero = False
        usua.VariarIntereses = False
        If dt.Rows.Count > 0 Then
            usua.Cedula = dt.Rows(0).Item("Cedula")
            usua.Nombre = dt.Rows(0).Item("Nombre")
            usua.Clave_Interna = dt.Rows(0).Item("Clave_Interna")
            usua.Clave_Entrada = dt.Rows(0).Item("Clave_Entrada")           
        End If
        Return usua
    End Function

    Private Sub CorteDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorteDeCajaToolStripMenuItem.Click
        Dim frm As New MovimientoCaja(Me.GetUsuario(Me.Id_Usuario))
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class

Public Class ImpresionCaja
    Public facturaPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public rptTiquete As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public adelantoPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public apartadoPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public abonoapartadoPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public recibodineroPVE As New ReciboDineroPV
    Private reimprimir As Boolean = False

    Sub New()
        Dim raiz As String = "C:\rpt\"

        Me.rptTiquete = New rptTiqueteRifa2

        If IO.File.Exists(raiz & "facturaPVE.rpt") = True Then
            Me.facturaPVE.Load(raiz & "facturaPVE.rpt")
        Else
            Me.facturaPVE = New Reporte_FacturaPVEs
        End If

        If IO.File.Exists(raiz & "adelantoPVE.rpt") = True Then
            Me.adelantoPVE.Load(raiz & "adelantoPVE.rpt")
        Else
            Me.adelantoPVE = New Reporte_AdelantosPVEs
        End If

        If IO.File.Exists(raiz & "apartadoPVE.rpt") = True Then
            Me.apartadoPVE.Load(raiz & "apartadoPVE.rpt")
        Else
            Me.apartadoPVE = New Repoteapartado
        End If

        If IO.File.Exists(raiz & "abonoapartadoPVE.rpt") = True Then
            Me.abonoapartadoPVE.Load(raiz & "abonoapartadoPVE.rpt")
        Else
            Me.abonoapartadoPVE = New AbonoApartado
        End If

        If IO.File.Exists(raiz & "recibodineroPVE.rpt") = True Then
            Me.recibodineroPVE.Load(raiz & "recibodineroPVE.rpt")
        Else
            Me.recibodineroPVE = New ReciboDineroPV
        End If

        CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True)
        CrystalReportsConexion.LoadReportViewer(Nothing, rptTiquete, True)
        CrystalReportsConexion.LoadReportViewer(Nothing, adelantoPVE, True)
        CrystalReportsConexion.LoadReportViewer(Nothing, apartadoPVE, True)
        CrystalReportsConexion.LoadReportViewer(Nothing, abonoapartadoPVE, True)
        CrystalReportsConexion.LoadReportViewer(Nothing, recibodineroPVE, True)
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

    Public Sub InicalizaReporte(_PuntoVenta As String)
        If _PuntoVenta.ToUpper = "SEEPOS" Then
            CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True, CadenaConexionSeePOS)
            CrystalReportsConexion.LoadReportViewer(Nothing, rptTiquete, True, CadenaConexionSeePOS)
            CrystalReportsConexion.LoadReportViewer(Nothing, adelantoPVE, True, CadenaConexionSeePOS)
            CrystalReportsConexion.LoadReportViewer(Nothing, apartadoPVE, True, CadenaConexionSeePOS)
            CrystalReportsConexion.LoadReportViewer(Nothing, abonoapartadoPVE, True, CadenaConexionSeePOS)
            CrystalReportsConexion.LoadReportViewer(Nothing, recibodineroPVE, True, CadenaConexionSeePOS)
        End If
        If _PuntoVenta.ToUpper = "TALLER" Then
            CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True, CadenaConexionTaller)
            CrystalReportsConexion.LoadReportViewer(Nothing, rptTiquete, True, CadenaConexionTaller)
            CrystalReportsConexion.LoadReportViewer(Nothing, adelantoPVE, True, CadenaConexionTaller)
            CrystalReportsConexion.LoadReportViewer(Nothing, apartadoPVE, True, CadenaConexionTaller)
            CrystalReportsConexion.LoadReportViewer(Nothing, abonoapartadoPVE, True, CadenaConexionTaller)
            CrystalReportsConexion.LoadReportViewer(Nothing, recibodineroPVE, True, CadenaConexionTaller)
        End If
    End Sub

    Public Sub ImprimirReciboDinero(_IdRecibo As Double, Optional ByVal _Caja As Integer = 1)
        Try
            If IsClinica() = True Then _Caja = 1

            If _Caja = 1 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                recibodineroPVE.SetParameterValue(0, _IdRecibo)
                recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If

            If _Caja = 2 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                recibodineroPVE.SetParameterValue(0, _IdRecibo)
                recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ImprimirApartado(_IdApartado As Double, Optional ByVal _Caja As Integer = 1)
        Try
            If IsClinica() = True Then _Caja = 1

            If _Caja = 1 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                apartadoPVE.SetParameterValue(0, _IdApartado)
                apartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                apartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If

            If _Caja = 2 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                apartadoPVE.SetParameterValue(0, _IdApartado)
                apartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                apartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ImprimirAbonoApartado(_IdAbonoApartado As Double, Optional ByVal _Caja As Integer = 1)
        Try
            If IsClinica() = True Then _Caja = 1

            If _Caja = 1 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                abonoapartadoPVE.SetParameterValue(0, _IdAbonoApartado)
                abonoapartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                abonoapartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If

            If _Caja = 2 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                abonoapartadoPVE.SetParameterValue(0, _IdAbonoApartado)
                abonoapartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                abonoapartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub Imprimir_Tiquete_Rifa(ByVal _Caja As Integer, ByVal _IdFactura As String)

        Dim NombreImpresoraCupones As String = ""

        If NombreImpresoraCupones = "" Then
            If _Caja = 1 Then
                NombreImpresoraCupones = Automatic_Printer_Dialog(3)
                'NombreImpresoraCupones = Automatic_Printer_Dialog(5)
            End If

            If _Caja = 2 Then
                NombreImpresoraCupones = Automatic_Printer_Dialog(5)
            End If
        End If

        Dim PrinterSettings1 As New Printing.PrinterSettings
        Dim PageSettings1 As New Printing.PageSettings
        PrinterSettings1.PrinterName = NombreImpresoraCupones

        rptTiquete.SetParameterValue(0, _IdFactura)
        rptTiquete.PrintToPrinter(PrinterSettings1, PageSettings1, False)
    End Sub

    Public Sub ImprimirFactura(ByVal Id_Factura As Double, ByVal PVE As Boolean, Optional ByVal Caja As Integer = 1) 'MOD SAJ 01092006
        Try

            If IsClinica() = True Then Caja = 1

            If Caja = 1 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                facturaPVE.SetParameterValue(0, reimprimir)
                facturaPVE.SetParameterValue(1, False)
                facturaPVE.SetParameterValue(2, Id_Factura)
                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
            If Caja = 2 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                facturaPVE.SetParameterValue(0, reimprimir)
                facturaPVE.SetParameterValue(1, False)
                facturaPVE.SetParameterValue(2, Id_Factura)
                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Public Sub ImprimirAdelanto(ByVal Id_Factura As Double, ByVal PVE As Boolean, ByVal Caja As Integer) 'MOD SAJ 01092006
        Try
            If IsClinica() = True Then Caja = 1

            If Caja = 1 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                'PrinterSettings1.Copies = 2
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                adelantoPVE.SetParameterValue(0, reimprimir)
                adelantoPVE.SetParameterValue(1, False)
                adelantoPVE.SetParameterValue(2, Id_Factura)
                adelantoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
            If Caja = 2 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                'PrinterSettings1.Copies = 2

                adelantoPVE.SetParameterValue(0, reimprimir)
                adelantoPVE.SetParameterValue(1, False)
                adelantoPVE.SetParameterValue(2, Id_Factura)
                adelantoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


End Class

Public Module GeneralCaja

    Public clsImpresion As New ImpresionCaja

End Module
