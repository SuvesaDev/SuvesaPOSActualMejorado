Imports System.Windows.Forms
Imports System.Linq
Imports System.Data
Imports System.Collections.Generic
Public Class frmConsultasComprobantesReceptor

#Region "Exportar Excel"

    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)
        'exportamos los caracteres de las columnas
        Dim columns As Integer = 0
        For c As Integer = 0 To dgv.Columns.Count - 1
            If dgv.Columns(c).Visible = True Then
                xlWS.cells(1, columns + 1).value = dgv.Columns(c).HeaderText
                columns += 1
            End If
        Next
        'exportamos las cabeceras de columnas
        For r As Integer = 0 To dgv.RowCount - 1
            columns = 0
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Visible = True Then
                    xlWS.cells(r + 2, columns + 1).value = dgv.Item(c, r).Value.ToString
                    columns += 1
                End If
            Next
        Next
        'guardamos la hoja de calculo en la ruta especificada
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub
#End Region

    Private Function GetTipos() As String
        Dim resultado As String = ""

        If Me.ckCompra.Checked = True Then
            resultado = "'COMPRA'"
        End If

        If Me.ckGasto.Checked = True Then
            If resultado = "" Then
                resultado = "'GASTO'"
            Else
                resultado += ", 'GASTO'"
            End If
        End If
        Return resultado
    End Function

    Private Function getEstados() As String

        Dim resultado As String = ""

        If Me.ckPendiente.Checked = True Then
            If resultado = "" Then
                resultado = "'PENDIENTE'"
            Else
                resultado += ",'PENDIENTE'"
            End If
        End If

        If Me.ckAceptado.Checked = True Then
            If resultado = "" Then
                resultado = "'ACEPTADO'"
            Else
                resultado += ",'ACEPTADO'"
            End If
        End If

        If Me.ckRechazado.Checked = True Then
            If resultado = "" Then
                resultado = "'RECHAZADO'"
            Else
                resultado += ",'RECHAZADO'"
            End If
        End If

        Return resultado

    End Function

    Private Sub CargarDatos()

        If Me.ckFiltrarxEstado.Checked = True Then
            If Me.ckPendiente.Checked = False And Me.ckAceptado.Checked = False And Me.ckRechazado.Checked = False Then
                MsgBox("Para filtrar por estado debe marcar almenos un estado", MsgBoxStyle.Exclamation, "No se puedo procesar la operacion")
                Exit Sub
            End If
        End If

        If Me.ckFiltrarxFecha.Checked = True Then
            If Me.dtpHasta.Value < Me.dtpDesde.Value Then
                MsgBox("El rango de fechas a filtrar es invalido", MsgBoxStyle.Exclamation, "No se puedo procesar la operacion")
                Exit Sub
            End If
        End If

        If Me.ckTipos.Checked = True Then
            If Me.ckCompra.Checked = False And Me.ckGasto.Checked = False Then
                MsgBox("Para filtrar por Tipo debe marcar almenos un Opcion (Compra o Gasto)", MsgBoxStyle.Exclamation, "No se puedo procesar la operacion")
                Exit Sub
            End If
        End If

        Dim SQL As String = "select Consecutivo as ConsecutivoAceptacion, FechaEmisionDoc as FechaEmisionAceptacion, Mensaje as TipoDocAceptacion, Proveedor as NombreEmisor, DetalleMensaje as DetalleAceptacion, Estado as EstadoHacienda, MontoTotalDeGastoAplicable as TotalDeGastoAplicable, MontoTotalImpuestoAcreditar as TotalImpuestoAcreditar, TotalFactura - MontoTotalImpuesto as TotalNeto, MontoTotalImpuesto as TotalImpuesto, TotalFactura as TotalComprobante, Moneda as CodigoMoneda from MensajeReceptor "
        Dim Filtro As String = ""

        If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = True Then
            Filtro = " Where Mensaje In(" & Me.getEstados & ") And dbo.dateonly(FechaEmisionDoc) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaEmisionDoc) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = False Then
            Filtro = " Where dbo.dateonly(FechaEmisionDoc) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaEmisionDoc) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = True Then
            Filtro = " Where Mensaje In(" & Me.getEstados & ")"
        End If

        If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = False Then
            Filtro = ""
        End If

        If Me.ckTipos.Checked = True Then
            If Filtro = "" Then
                Filtro = " Where Tipo In(" & Me.GetTipos & ")"
            Else
                Filtro += " And Tipo In(" & Me.GetTipos & ")"
            End If
        End If


        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim dt As New DataTable
        dt = db.Ejecutar(SQL & Filtro & " Order by FechaEmisionDoc", CommandType.Text)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("NombreEmisor").ReadOnly = True

        Me.viewDatos.Columns("TotalDeGastoAplicable").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalDeGastoAplicable").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewDatos.Columns("TotalImpuestoAcreditar").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalImpuestoAcreditar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewDatos.Columns("TotalNeto").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalNeto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewDatos.Columns("TotalImpuesto").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalImpuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewDatos.Columns("TotalComprobante").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalComprobante").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarDatos()
    End Sub

    Private Sub frmConsultasComprobantesReceptor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        Me.ckFiltrarxFecha.Checked = True
        Me.CargarDatos()
    End Sub

    Private Sub ckFiltrarxFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxFecha.CheckedChanged
        Me.gbFiltrarxFecha.Enabled = Me.ckFiltrarxFecha.Checked
    End Sub

    Private Sub ckFiltrarxEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxEstado.CheckedChanged
        Me.gbFiltrarxEstado.Enabled = Me.ckFiltrarxEstado.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim frm As New frmAgregarRespuestaReceptor
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        'Dim URL As String = Me.viewDatos.Item("PDF", e.RowIndex).Value
        'If URL <> "" Then
        '    Try
        '        Dim frm As New frmVisorHTML
        '        frm.URL = URL
        '        frm.WindowState = Windows.Forms.FormWindowState.Maximized
        '        frm.Show()
        '    Catch ex As Exception
        '    End Try
        'Else
        '    MsgBox("Problemas para obtener el pdf", MsgBoxStyle.Exclamation, Text)
        'End If
    End Sub

    Private Sub Procesar_Marcados(_MSG As String)

        Dim lista As New List(Of DataGridViewRow)
        lista = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Marcar").Value = True Select x).ToList

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

        For Each fila As DataGridViewRow In lista
            If fila.Cells("Estado").Value = "PENDIENTE" Then
                fila.Cells("MENSAJE").Value = _MSG
                fila.Cells("Marcar").Value = False
                db.Ejecutar("Update MensajeReceptor Set Mensaje = '" & _MSG & "', FechaEmisionDoc = getdate() Where Id = " & fila.Cells("Id").Value, CommandType.Text)
            End If
        Next
    End Sub

    Private Sub ckTipos_CheckedChanged(sender As Object, e As EventArgs) Handles ckTipos.CheckedChanged
        Me.gbFiltroxTipo.Enabled = Me.ckTipos.Checked
    End Sub

    Private dlgExportar As New SaveFileDialog With {.Title = "Guardar Documentos", .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments}
    Private Sub btnExportar_Click_1(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.viewDatos.RowCount > 0 Then
                If dlgExportar.ShowDialog = DialogResult.OK Then
                    Me.Exportar_Excel(Me.viewDatos, dlgExportar.FileName)
                    'SetInfomacion("Datos Exportados correctamente!!!", "Exportacion exitosa")
                End If
            End If
        Catch ex As Exception
            'SetAdvertencia(ex.Message, "No se realizo la operacion")
        End Try
    End Sub
End Class
