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
        Me.Text = "Sistema Control de Caja (08052023)"
        Me.lblUsuario.Text = Me.NombreUsuario
        Me.IniciaFormularioFicha()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.IniciaFormularioFicha()
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

    Private Sub btnResumenCaja_Click(sender As Object, e As EventArgs)

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

    Private Sub FirmadoContadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirmadoContadoToolStripMenuItem.Click
        'If GetSetting("SeeSOFT", "SeePOS", regeditSegura) = "1" Then
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewDiasContadoFirmado where dias > 7 order by dias desc", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If MsgBox("Desea ver el Reporte", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hay Contado Firmado con mas de 7 dias") = MsgBoxResult.Yes Then
                Dim frm As New frmFirmadoContadoViejo
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
        'End If
    End Sub

    Private Sub DetalleTallerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleTallerToolStripMenuItem.Click
        Dim frm As New frmResumenCaja
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Dim frm As New frmImprimirDevoluciones
        frm.Devolucion = True
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        Dim frm As New frmImprimirDevoluciones
        frm.Prestamos = True
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Dim frm As New Credomatic.Configuracion.frmConfiguracionTerminal
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DevolucionesDeHoy()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("exec usp_ObtenerDevoluciones '" & Date.Now.ToShortDateString & "', '" & Date.Now.ToShortDateString & "'", dt, CadenaConexionSeePOS)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class

Public Class ImpresionCaja

    Private reimprimir As Boolean = False

    Sub New()
        'CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True)
        'CrystalReportsConexion.LoadReportViewer(Nothing, adelantoPVE, True)
        'CrystalReportsConexion.LoadReportViewer(Nothing, apartadoPVE, True)
        'CrystalReportsConexion.LoadReportViewer(Nothing, abonoapartadoPVE, True)
        'CrystalReportsConexion.LoadReportViewer(Nothing, recibodineroPVE, True)
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

    Public Sub ImprimirReciboDinero(_IdRecibo As Double, _PuntoVenta As String, ByVal _Caja As Integer)
        Try
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            Dim raiz As String = "C:\rpt\"
            Dim recibodineroPVE As New ReciboDineroPV
            If IsClinica() = True Then _Caja = 1

            If IO.File.Exists(raiz & "recibodineroPVE.rpt") = True Then
                recibodineroPVE.Load(raiz & "recibodineroPVE.rpt")
            Else
                recibodineroPVE = New ReciboDineroPV
                recibodineroPVE.Refresh()
            End If

            If _PuntoVenta.ToUpper = "SEEPOS" Or _PuntoVenta = "MASCOTAS" Or _PuntoVenta = "SANTACRUZ" Or _PuntoVenta = "CLINICA" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, recibodineroPVE, True, CadenaConexionSeePOS)
            End If
            If _PuntoVenta.ToUpper = "TALLER" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, recibodineroPVE, True, CadenaConexionTaller)
            End If

            If _Caja = 1 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)
            End If
            If _Caja = 2 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            End If

            recibodineroPVE.SetParameterValue(0, _IdRecibo)
            recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        Catch ex As Exception
            RegistrarLog(ex.StackTrace)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ImprimirApartado(_IdApartado As Double, _PuntoVenta As String, ByVal _Caja As Integer)
        Try
            Dim raiz As String = "C:\rpt\"
            Dim apartadoPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            If IsClinica() = True Then _Caja = 1

            If IO.File.Exists(raiz & "apartadoPVE.rpt") = True Then
                apartadoPVE.Load(raiz & "apartadoPVE.rpt")
            Else
                apartadoPVE = New Repoteapartado
                apartadoPVE.Refresh()
            End If

            If _PuntoVenta.ToUpper = "SEEPOS" Or _PuntoVenta = "MASCOTAS" Or _PuntoVenta = "SANTACRUZ" Or _PuntoVenta = "CLINICA" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, apartadoPVE, True, CadenaConexionSeePOS)
            End If
            If _PuntoVenta.ToUpper = "TALLER" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, apartadoPVE, True, CadenaConexionTaller)
            End If

            If _Caja = 1 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)
            End If

            If _Caja = 2 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            End If

            apartadoPVE.SetParameterValue(0, _IdApartado)
            apartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            apartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        Catch ex As Exception
            RegistrarLog(ex.StackTrace)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ImprimirAbonoApartado2(_IdAbonoApartado As Double, _PuntoVenta As String, ByVal _Caja As Integer)
        Try
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            Dim raiz As String = "C:\rpt\"
            Dim abonoapartadoPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            If IsClinica() = True Then _Caja = 1

            If IO.File.Exists(raiz & "abonoapartadoPVE.rpt") = True Then
                abonoapartadoPVE.Load(raiz & "abonoapartadoPVE.rpt")
            Else
                abonoapartadoPVE = New AbonoApartado
                abonoapartadoPVE.Refresh()
            End If

            If _PuntoVenta.ToUpper = "SEEPOS" Or _PuntoVenta = "MASCOTAS" Or _PuntoVenta = "SANTACRUZ" Or _PuntoVenta = "CLINICA" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, abonoapartadoPVE, True, CadenaConexionSeePOS)
            End If
            If _PuntoVenta.ToUpper = "TALLER" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, abonoapartadoPVE, True, CadenaConexionTaller)
            End If

            If _Caja = 1 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)
            End If
            If _Caja = 2 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            End If

            abonoapartadoPVE.SetParameterValue(0, _IdAbonoApartado)
            abonoapartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            abonoapartadoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        Catch ex As Exception
            RegistrarLog(ex.StackTrace)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub Imprimir_Tiquete_Rifa(ByVal _Caja As Integer, ByVal _IdFactura As String, _PuntoVenta As String)
        Dim rptTiquete As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptTiquete = New rptTiqueteRifa2

        If _PuntoVenta.ToUpper = "SEEPOS" Or _PuntoVenta = "SANTACRUZ" Or _PuntoVenta = "CLINICA" Then
            CrystalReportsConexion.LoadReportViewer(Nothing, rptTiquete, True, CadenaConexionSeePOS)
        End If
        If _PuntoVenta.ToUpper = "TALLER" Then
            CrystalReportsConexion.LoadReportViewer(Nothing, rptTiquete, True, CadenaConexionTaller)
        End If

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

    Public Sub ImprimirFactura(ByVal Id_Factura As Double, ByVal PVE As Boolean, _PuntoVenta As String, ByVal Caja As Integer) 'MOD SAJ 01092006
        Dim Proceso As String = ""
        Try
            Dim raiz As String = "C:\rpt\"
            Dim facturaPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            If IsClinica() = True Then Caja = 1

            Proceso = "cargando reporte"
            If IO.File.Exists(raiz & "facturaPVE.rpt") = True Then
                facturaPVE.Load(raiz & "facturaPVE.rpt")
            Else
                facturaPVE = New Reporte_FacturaPVEs
                facturaPVE.Refresh()
            End If

            Proceso = "inicializando reporte"
            If _PuntoVenta.ToUpper = "SEEPOS" Or _PuntoVenta = "MASCOTAS" Or _PuntoVenta = "SANTACRUZ" Or _PuntoVenta = "CLINICA" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True, CadenaConexionSeePOS)
            End If
            If _PuntoVenta.ToUpper = "TALLER" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True, CadenaConexionTaller)
            End If

            Proceso = "Asignando Impresora"
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            If Caja = 1 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)
            End If
            If Caja = 2 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            End If

            Proceso = "Imprimiendo"
            facturaPVE.SetParameterValue(0, reimprimir)
            facturaPVE.SetParameterValue(1, False)
            facturaPVE.SetParameterValue(2, Id_Factura)
            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            facturaPVE.Close()
            facturaPVE.Dispose()
        Catch ex As System.Exception
            RegistrarLog(ex.StackTrace)
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "ImprimirFactura-" & Proceso)
        End Try
    End Sub

    Public Sub ImprimirAdelanto(ByVal Id_Factura As Double, ByVal PVE As Boolean, ByVal Caja As Integer, _PuntoVenta As String) 'MOD SAJ 01092006
        Try
            Dim adelantoPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim raiz As String = "C:\rpt\"
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            If IsClinica() = True Then Caja = 1

            If IO.File.Exists(raiz & "adelantoPVE.rpt") = True Then
                adelantoPVE.Load(raiz & "adelantoPVE.rpt")
            Else
                adelantoPVE = New Reporte_AdelantosPVEs
                adelantoPVE.Refresh()
            End If

            If _PuntoVenta.ToUpper = "SEEPOS" Or _PuntoVenta = "MASCOTAS" Or _PuntoVenta = "SANTACRUZ" Or _PuntoVenta = "CLINICA" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, adelantoPVE, True, CadenaConexionSeePOS)
            End If
            If _PuntoVenta.ToUpper = "TALLER" Then
                CrystalReportsConexion.LoadReportViewer(Nothing, adelantoPVE, True, CadenaConexionTaller)
            End If

            If Caja = 1 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)
            End If
            If Caja = 2 Then
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            End If

            adelantoPVE.SetParameterValue(0, reimprimir)
            adelantoPVE.SetParameterValue(1, False)
            adelantoPVE.SetParameterValue(2, Id_Factura)
            adelantoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        Catch ex As System.Exception
            RegistrarLog(ex.StackTrace)
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


End Class

Public Module GeneralCaja

    Public clsImpresion As New ImpresionCaja

End Module
