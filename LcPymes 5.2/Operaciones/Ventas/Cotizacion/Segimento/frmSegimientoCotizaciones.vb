Imports System.Data

Public Class frmSegimientoCotizaciones
    Public IdUsuario As String = ""
    Private Function getEstados() As String

        Dim resultado As String = ""

        If Me.ckPendienteEnvio.Checked = True Then
            If resultado = "" Then
                resultado = "'" & ESTADOS.Pendientedeenvio & "'"
            Else
                resultado += ",'" & ESTADOS.Pendientedeenvio & "'"
            End If
        End If

        If Me.ckRevision.Checked = True Then
            If resultado = "" Then
                resultado = "'" & ESTADOS.Revision & "'"
            Else
                resultado += ",'" & ESTADOS.Revision & "'"
            End If
        End If

        If Me.ckEnviadosinConfirmar.Checked = True Then
            If resultado = "" Then
                resultado = "'" & ESTADOS.Enviadosinconfirmar & "'"
            Else
                resultado += ",'" & ESTADOS.Enviadosinconfirmar & "'"
            End If
        End If

        If Me.ckGanada.Checked = True Then
            If resultado = "" Then
                resultado = "'" & ESTADOS.Ganada & "'"
            Else
                resultado += ",'" & ESTADOS.Ganada & "'"
            End If
        End If

        If Me.ckConfirmado.Checked = True Then
            If resultado = "" Then
                resultado = "'" & ESTADOS.Confirmado & "'"
            Else
                resultado += ",'" & ESTADOS.Confirmado & "'"
            End If
        End If

        If Me.ckPerdida.Checked = True Then
            If resultado = "" Then
                resultado = "'" & ESTADOS.Perdida & "'"
            Else
                resultado += ",'" & ESTADOS.Perdida & "'"
            End If
        End If

        Return resultado

    End Function

    Private Sub CargarLista()
        If Me.ckFiltrarxEstado.Checked = True Then
            If Me.ckPendienteEnvio.Checked = False And Me.ckEnviadosinConfirmar.Checked = False And Me.ckConfirmado.Checked = False And Me.ckRevision.Checked = False And Me.ckGanada.Checked = False And Me.ckPerdida.Checked = False Then
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

        Dim strConsulta As String = "Select Cotizacion, Fecha, Nombre_Cliente, Total, EstadoActual, Contacto, Telefono from viewEstadoCotizacion "
        Dim strFiltro As String = ""

        If Me.ckInfoFactura.Checked = True Then
            strConsulta = strConsulta.Replace("EstadoActual", "EstadoActual, NumeroFactura, MontoFactura")
        End If

        If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = True Then
            strFiltro = " Where EstadoActual In(" & Me.getEstados & ") And dbo.dateonly(Fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(Fecha) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = False Then
            strFiltro = " Where dbo.dateonly(Fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(Fecha) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = True Then
            strFiltro = " Where EstadoActual In(" & Me.getEstados & ")"
        End If

        If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = False Then
            strFiltro = ""
        End If

        If Me.ToolStripTextBox1.Text <> "" Then
            If strFiltro = "" Then
                strFiltro = "Where Nombre_Cliente like '%" & Me.ToolStripTextBox1.Text & "%'"
            Else
                strFiltro += " And Nombre_Cliente like '%" & Me.ToolStripTextBox1.Text & "%'"
            End If
        End If

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim dt As New DataTable
        dt = db.Ejecutar(strConsulta & strFiltro & " Order By Nombre_Cliente", CommandType.Text)

        Me.viewDatos.Rows.Clear()
        Dim Index As Integer = 0
        For Each r As DataRow In dt.Rows
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("Cotizacion", Index).Value = r.Item("Cotizacion")
            Me.viewDatos.Item("Fecha", Index).Value = r.Item("Fecha")
            Me.viewDatos.Item("Nombre_Cliente", Index).Value = r.Item("Nombre_Cliente")
            Me.viewDatos.Item("Total", Index).Value = r.Item("Total")
            Me.viewDatos.Item("EstadoActual", Index).Value = r.Item("EstadoActual")
            Me.viewDatos.Item("Contacto", Index).Value = r.Item("Contacto")
            Me.viewDatos.Item("Telefono", Index).Value = r.Item("Telefono")
            If Me.ckInfoFactura.Checked = True Then
                Me.viewDatos.Item("NumeroFactura", Index).Value = r.Item("NumeroFactura")
                Me.viewDatos.Item("MontoFactura", Index).Value = r.Item("MontoFactura")
            Else
                Me.viewDatos.Item("NumeroFactura", Index).Value = 0
                Me.viewDatos.Item("MontoFactura", Index).Value = 0
            End If
            Index += 1
        Next

        Me.viewDatos.Columns("Total").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("Total").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("NumeroFactura").Visible = False
        Me.viewDatos.Columns("MontoFactura").Visible = False

        Me.txtTotalVenta.Text = "0.00"
        If Me.ckInfoFactura.Checked = True Then
            Me.viewDatos.Columns("NumeroFactura").Visible = True
            Me.viewDatos.Columns("NumeroFactura").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("MontoFactura").Visible = True
            Me.viewDatos.Columns("MontoFactura").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("MontoFactura").DefaultCellStyle.Format = "N2"

            Dim Monto As Decimal = (From x As System.Windows.Forms.DataGridViewRow In Me.viewDatos.Rows Select CDec(x.Cells("MontoFactura").Value)).Sum
            Me.txtTotalVenta.Text = Monto.ToString("N2")
        End If

        Dim fila As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewDatos.Rows Select x).ToList
        For Each r As DataGridViewRow In fila
            Select Case r.Cells("EstadoActual").Value
                Case ESTADOS.Pendientedeenvio
                    r.DefaultCellStyle.ForeColor = Me.ckPendienteEnvio.ForeColor
                    r.DefaultCellStyle.BackColor = Me.ckPendienteEnvio.BackColor
                Case ESTADOS.Enviadosinconfirmar
                    r.DefaultCellStyle.ForeColor = Me.ckEnviadosinConfirmar.ForeColor
                    r.DefaultCellStyle.BackColor = Me.ckEnviadosinConfirmar.BackColor
                Case ESTADOS.Confirmado
                    r.DefaultCellStyle.ForeColor = Me.ckConfirmado.ForeColor
                    r.DefaultCellStyle.BackColor = Me.ckConfirmado.BackColor
                Case ESTADOS.Revision
                    r.DefaultCellStyle.ForeColor = Me.ckRevision.ForeColor
                    r.DefaultCellStyle.BackColor = Me.ckRevision.BackColor
                Case ESTADOS.Ganada
                    r.DefaultCellStyle.ForeColor = Me.ckGanada.ForeColor
                    r.DefaultCellStyle.BackColor = Me.ckGanada.BackColor
                Case ESTADOS.Perdida
                    r.DefaultCellStyle.ForeColor = Me.ckPerdida.ForeColor
                    r.DefaultCellStyle.BackColor = Me.ckPerdida.BackColor
            End Select
        Next
    End Sub

    Private Sub CambiarEstado(Optional ByVal _Llamar As Boolean = False)
        Dim frm As New frmCambiarEstadoCotizacion
        frm.IdUsuario = Me.IdUsuario
        frm.Llamar = _Llamar
        frm.txtCotizacion.Text = Me.viewDatos("Cotizacion", Me.viewDatos.CurrentRow.Index).Value
        frm.txtFecha.Text = Me.viewDatos("Fecha", Me.viewDatos.CurrentRow.Index).Value
        frm.txtNombre.Text = Me.viewDatos("Nombre_Cliente", Me.viewDatos.CurrentRow.Index).Value
        frm.txtTotal.Text = Format(CDec(Me.viewDatos("Total", Me.viewDatos.CurrentRow.Index).Value), "N2")
        frm.txtEstado.Text = Me.viewDatos("EstadoActual", Me.viewDatos.CurrentRow.Index).Value
        frm.txtContacto.Text = Me.viewDatos("Contacto", Me.viewDatos.CurrentRow.Index).Value
        frm.txtTelefono.Text = Me.viewDatos("Telefono", Me.viewDatos.CurrentRow.Index).Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Cotizacion Set EstadoActual = '" & frm.cboNuevoEstado.Text & "', ObservacionEstado = '" & frm.txtObseraciones.Text & "' Where Cotizacion = " & frm.txtCotizacion.Text, CommandType.Text)
            db.Ejecutar("Insert into BitacoraEstadoCotizacion(Cotizacion, IdUsuario, Fecha, Estado, Observaciones) Values(" & frm.txtCotizacion.Text & ", '" & frm.IdUsuario & "', getdate(), '" & frm.cboNuevoEstado.Text & "', '" & frm.txtObseraciones.Text & "')", CommandType.Text)
            Me.CargarLista()
        End If
    End Sub

    Private Sub EnviarCorreo()
        Dim IdCotizacion As String = Me.viewDatos.Item("Cotizacion", Me.viewDatos.CurrentRow.Index).Value
        Dim outlook As New Correo
        outlook.EnviarCotizacion(IdCotizacion)

        If Me.viewDatos("EstadoActual", Me.viewDatos.CurrentRow.Index).Value = Pendientedeenvio Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Cotizacion Set EstadoActual = '" & ESTADOS.Enviadosinconfirmar & "', ObservacionEstado = '' Where Cotizacion = " & IdCotizacion, CommandType.Text)
            Me.CargarLista()
        End If

    End Sub

    Private Sub frmSegimientoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarLista()
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub ckFiltrarxFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxFecha.CheckedChanged
        Me.gbFiltrarxFecha.Enabled = Me.ckFiltrarxFecha.Checked
    End Sub

    Private Sub ckFiltrarxEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxEstado.CheckedChanged
        Me.gbFiltrarxEstado.Enabled = Me.ckFiltrarxEstado.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarLista()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.CambiarEstado()
    End Sub

    Private Sub viewDatos_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellClick
        
    End Sub
    
    Private Sub viewDatos_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = Me.Enviar.Index Then
                Me.EnviarCorreo()
            ElseIf e.ColumnIndex = Me.Llamar.Index Then
                Me.CambiarEstado(True)
            End If
        End If
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.CambiarEstado()
    End Sub

    Private Sub viewDatos_CellPainting(sender As Object, e As Windows.Forms.DataGridViewCellPaintingEventArgs) Handles viewDatos.CellPainting
        If e.ColumnIndex = 9 AndAlso e.RowIndex > -1 Then
            Dim img As System.Drawing.Image = My.Resources.email_send_receive1
            e.PaintContent(e.CellBounds)
            e.Graphics.DrawImage(img, e.CellBounds.Location)
            e.Handled = True
        End If

        If e.ColumnIndex = 10 AndAlso e.RowIndex > -1 Then
            Dim img As System.Drawing.Image = My.Resources.phone_handset
            e.PaintContent(e.CellBounds)
            e.Graphics.DrawImage(img, e.CellBounds.Location)
            e.Handled = True
        End If
    End Sub
    
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim frm As New Frm_Cotizacion
        frm.IdCotizacionUsuarioExterno = Me.viewDatos("Cotizacion", Me.viewDatos.CurrentRow.Index).Value
        frm.ShowDialog()
    End Sub

End Class

Public Module ESTADOS
    Public Pendientedeenvio As String = "Pendiente de envio"
    Public Enviadosinconfirmar As String = "Enviada sin confirmar"
    Public Confirmado As String = "Confirmada"
    Public Revision As String = "Revision"
    Public Ganada As String = "Ganada"
    Public Perdida As String = "Perdida"

    Public Function ListaEstado() As Array
        Dim Lista As New System.Collections.Generic.List(Of String)
        Lista.Add(Pendientedeenvio)
        Lista.Add(Enviadosinconfirmar)
        Lista.Add(Confirmado)
        Lista.Add(Revision)
        Lista.Add(Ganada)
        Lista.Add(Perdida)
        Return Lista.ToArray
    End Function

End Module
