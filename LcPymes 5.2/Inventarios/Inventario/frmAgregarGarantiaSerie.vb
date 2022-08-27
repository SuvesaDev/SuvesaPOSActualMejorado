Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmAgregarGarantiaSerie

    Private IdUsuario As String = "0"
    Private IdSerie As String = "0"

    Private Sub Limpiar()
        Me.btnAceptar.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.btnBuscarSerie.Enabled = False
        Me.txtSerie.Enabled = False
        Me.dtpFecha.Enabled = False
    End Sub

    Private Sub Login()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.btnAceptar.Enabled = True
            Me.txtObservaciones.Enabled = True
            Me.txtSerie.Enabled = True
            Me.btnBuscarSerie.Enabled = True
            Me.dtpFecha.Enabled = True
            Me.txtClave.Enabled = False
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.lblUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.txtSerie.Focus()
        End If
    End Sub

    Private Sub GuardarHistorial()
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Id", 0)
        db.AddParametro("@Boleta", 0)
        db.AddParametro("@IdSerie", Me.IdSerie)
        db.AddParametro("@Fecha", Me.dtpFecha.Value)
        db.AddParametro("@IdUsuario", Me.IdUsuario)
        db.AddParametro("@Observacion", Me.txtObservaciones.Text)
        db.Ejecutar("spGuardarHistorialSerie")

        Dim PrestamoPVE As New rptGarantiaPVE
        PrestamoPVE.Refresh()
        Dim PrinterSettings1 As New Printing.PrinterSettings
        Dim PageSettings1 As New Printing.PageSettings
        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

        CrystalReportsConexion.LoadReportViewer(Nothing, PrestamoPVE, True)
        PrestamoPVE.SetParameterValue(0, obtener_num_id())
        PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        If MsgBox("Desea imprimir una copia del recibo", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
            PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        End If

        Me.Close()
    End Sub

    Function obtener_num_id()
        Dim dt As New DataTable
        Dim id As Integer
        cFunciones.Llenar_Tabla_Generico("SELECT isnull(MAX(id),0)as id from historicoserie", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            id = dt.Rows(0).Item("id")
            Return id
        Else
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


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.GuardarHistorial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarGarantiaSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Limpiar()
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Login()
        End If
    End Sub

    Private Sub btnBuscarSerie_Click(sender As Object, e As EventArgs) Handles btnBuscarSerie.Click
        Dim frm As New frmBuscarSerie
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.IdSerie = frm.viewDatos.Item("Id", frm.viewDatos.CurrentRow.Index).Value
            Me.txtSerie.Text = frm.viewDatos.Item("Serie", frm.viewDatos.CurrentRow.Index).Value
            Me.txtCliente.Text = frm.viewDatos.Item("Nombre_Cliente", frm.viewDatos.CurrentRow.Index).Value
        End If
    End Sub

End Class