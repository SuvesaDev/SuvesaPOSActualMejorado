Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmImprimirDevoluciones
    Public Devolucion As Boolean = False
    Public Prestamos As Boolean = False

    Private Sub CargarDatos()
        If Me.Devolucion = True Then
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("exec usp_ObtenerDevoluciones '" & Me.dtpDesde.Value.ToShortDateString & "', '" & Me.dtpHasta.Value.ToShortDateString & "'", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("fecha").DefaultCellStyle.Format = "d"
            Me.viewDatos.Columns("monto").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If Me.Prestamos = True Then            
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select ID, fecha, nombre_destinatario as Origen, nombre_destino as Destino from Prestamo where dbo.DateOnly(fecha) >= '" & Me.dtpDesde.Value.ToShortDateString & "' and dbo.DateOnly(fecha) <= '" & Me.dtpHasta.Value.ToShortDateString & "'", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("fecha").DefaultCellStyle.Format = "d"
        End If
    End Sub

    Dim recibo_reportePVE As New ReporteDevolucionesVentas_PVE

    Private Terminal As New Credomatic.Configuracion.Terminal

    Private Sub Imprimir()
        If Me.Devolucion = True Then
            Try
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Terminal.Impresora
                Dim Devolucion As Long = Me.viewDatos("Devolucion", Me.viewDatos.CurrentRow.Index).Value
                Dim PuntoVenta As String = Me.viewDatos("PV", Me.viewDatos.CurrentRow.Index).Value
                Dim Conexion As String = ""
                If PuntoVenta = "Taller" Then
                    Conexion = CadenaConexionTaller()
                Else
                    Conexion = CadenaConexionSeePOS()
                End If
                recibo_reportePVE.SetParameterValue(0, CDbl(Devolucion))
                CrystalReportsConexion.LoadReportViewer(Nothing, recibo_reportePVE, True, Conexion)
                recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                If MsgBox("Desea imprimir una copia de la devolucion", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                    recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        If Me.Prestamos = True Then
            Try
                Dim PrestamoPVE As New Reporte_prestamoPVE
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                Dim ID As Long = Me.viewDatos("ID", Me.viewDatos.CurrentRow.Index).Value
                PrinterSettings1.PrinterName = Terminal.Impresora
                CrystalReportsConexion.LoadReportViewer(Nothing, PrestamoPVE, True)
                PrestamoPVE.SetParameterValue(0, ID)
                PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                If MsgBox("Desea imprimir una copia del prestamo", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                    PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarDatos()
    End Sub

    Private Sub frmImprimirDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub
End Class