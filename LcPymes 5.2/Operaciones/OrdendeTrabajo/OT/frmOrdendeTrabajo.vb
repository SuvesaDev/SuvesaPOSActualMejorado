Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmOrdendeTrabajo
    Private cls As New OrdendeTrabajo
    Private rptOT As New rptBoletaOT_PVE

    Private Sub SetAdvertencia(_cuerpo As String, _titulo As String)
        MsgBox(_cuerpo, MsgBoxStyle.Exclamation, _titulo)
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

    Private Sub Imprimir(_IdOT As String)
        Dim PrinterSettings1 As New Printing.PrinterSettings
        Dim PageSettings1 As New Printing.PageSettings
        Dim Impresora As Integer = 0
        If MsgBox("Desea imprimir en una de las cajas", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Dim frm As New frmOpcionCaja
            frm.ShowDialog()
            Dim Caja As Integer = frm.Caja
            Select Case Caja
                Case 1 : Impresora = 3
                Case 2 : Impresora = 5
            End Select
        Else
            Impresora = 100
        End If

        rptOT.Refresh()
        rptOT.SetParameterValue(0, _IdOT)
        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(Impresora)
        rptOT.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        If MsgBox("Desea imprimir una copia de la boleta", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
            rptOT.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        End If
    End Sub

    Private Sub Nuevo()
        Dim frm As New frmRegistrarOrdenTrabajo
        frm.Text = "Ingresar nueva orden de trabajo"
        frm.IdOrden = 0
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.cls.IdOrden = 0
            Me.cls.IdUsuario = frm.IdUsuario
            Me.cls.FechaIngreso = frm.dtpFecha.Value
            Me.cls.Serie = frm.txtSerie.Text
            Me.cls.Identificacion = frm.txtIdentificacion.Text
            Me.cls.Nombre = frm.txtNombreCliente.Text
            Me.cls.Telefono = frm.txtTelefono.Text
            Me.cls.Direccion = frm.txtDireccion.Text
            Me.cls.Correo = frm.txtCorreo.Text
            Me.cls.Estado = "ABIERTA"
            Me.cls.Observaciones = frm.txtObservaciones.Text
            Me.cls.TrabajoSolicitados = frm.txtDetalleServicio.Text
            If Me.cls.Registrar = True Then
                Me.Imprimir(cls.IdOrden)
                Me.Buscar()
            Else
                MsgBox("No se pudo registrar la orden", MsgBoxStyle.Critical, Text)
            End If
        End If
    End Sub

    Private Sub Editar()
        Dim frm As New frmRegistrarOrdenTrabajo
        frm.Text = "Editar una orden de trabajo"
        frm.IdOrden = Me.viewDatos.Item("IdOrden", Me.viewDatos.CurrentRow.Index).Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.cls.IdOrden = frm.IdOrden
            Me.cls.IdUsuario = frm.IdUsuario
            Me.cls.FechaIngreso = frm.dtpFecha.Value
            Me.cls.Serie = frm.txtSerie.Text
            Me.cls.Identificacion = frm.txtIdentificacion.Text
            Me.cls.Nombre = frm.txtNombreCliente.Text
            Me.cls.Telefono = frm.txtTelefono.Text
            Me.cls.Direccion = frm.txtDireccion.Text
            Me.cls.Correo = frm.txtCorreo.Text
            Me.cls.Estado = "ABIERTA"
            Me.cls.Observaciones = frm.txtObservaciones.Text
            Me.cls.TrabajoSolicitados = frm.txtDetalleServicio.Text
            If Me.cls.Registrar = True Then
                Me.Buscar()
            Else
                MsgBox("No se pudo registrar la orden", MsgBoxStyle.Critical, Text)
            End If
        End If
    End Sub

    Private Sub Buscar()
        Me.viewDatos.DataSource = cls.AllOrdendeTrabajo(Me.txtBuscar.Text)
        Me.viewDatos.Columns("IdUsuario").Visible = False
        Me.viewDatos.Columns("Identificacion").Visible = False
        Me.viewDatos.Columns("Direccion").Visible = False
        Me.viewDatos.Columns("Correo").Visible = False
        Me.viewDatos.Columns("Estado").Visible = False
        Me.viewDatos.Columns("Observaciones").Visible = False
        Me.viewDatos.Columns("TrabajoSolicitados").Visible = False
    End Sub

    Private Sub Eliminar()

    End Sub

    Private Sub frmControlCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Buscar()
        CrystalReportsConexion.LoadReportViewer(Nothing, rptOT, True)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.Buscar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Editar()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.Editar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Me.Eliminar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If MsgBox("Desea Imprimir la boleta de ingreso", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim id As String = Me.viewDatos.Item("IdOrden", Me.viewDatos.CurrentRow.Index).Value
            Me.Imprimir(id)
        End If
    End Sub
End Class
