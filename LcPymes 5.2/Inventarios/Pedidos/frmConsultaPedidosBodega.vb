Imports System.Windows.Forms
Imports System.Linq
Imports System.Data
Imports System.Collections.Generic

Public Class frmConsultaPedidosBodega

    Private Function getEstados() As String

        Dim resultado As String = ""

        If Me.ckSolicitado.Checked = True Then
            If resultado = "" Then
                resultado = "'SOLICITADO'"
            Else
                resultado += ",'SOLICITADO'"
            End If
        End If

        If Me.ckPedido.Checked = True Then
            If resultado = "" Then
                resultado = "'PEDIDO'"
            Else
                resultado += ",'PEDIDO'"
            End If
        End If

        If Me.ckRecibido.Checked = True Then
            If resultado = "" Then
                resultado = "'RECIBIDO'"
            Else
                resultado += ",'RECIBIDO'"
            End If
        End If

        If Me.ckAnulado.Checked = True Then
            If resultado = "" Then
                resultado = "'ANULADO'"
            Else
                resultado += ",'ANULADO'"
            End If
        End If

        If Me.ckAgotado.Checked = True Then
            If resultado = "" Then
                resultado = "'AGOTADO'"
            Else
                resultado += ",'AGOTADO'"
            End If
        End If

        Return resultado

    End Function

    Private Sub ConsultaBodega()

        If Me.ckFiltrarxEstado.Checked = True Then

            If Me.ckSolicitado.Checked = False And Me.ckPedido.Checked = False And Me.ckRecibido.Checked = False And Me.ckAnulado.Checked = False And Me.ckAgotado.Checked = False Then

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

        Dim strConsulta As String = "Select * from viewPedidosBodega"
        Dim strFiltro As String = ""

        If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = True Then
            strFiltro = " Where Estado In(" & Me.getEstados & ") And dbo.dateonly(FechaSolicitud) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaSolicitud) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = False Then
            strFiltro = " Where dbo.dateonly(FechaSolicitud) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaSolicitud) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
        End If

        If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = True Then
            strFiltro = " Where Estado In(" & Me.getEstados & ")"
        End If

        If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = False Then
            strFiltro = ""
        End If

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim dt As New DataTable
        dt = db.Ejecutar(strConsulta & strFiltro & " Order by CasaComercial", CommandType.Text)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("IdPedido").Visible = False

        Me.pone_color("PEDIDO", Drawing.Color.Yellow)
        Me.pone_color("RECIBIDO", Drawing.Color.LightGreen)
        Me.pone_color("AGOTADO", Drawing.Color.LightSalmon)

    End Sub

    Private Sub pone_color(_Estado As String, _Color As Drawing.Color)
        Dim t As List(Of DataGridViewRow)
        t = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Estado").Value = _Estado Select x).ToList

        For Each r As DataGridViewRow In t
            r.DefaultCellStyle.BackColor = _Color
        Next
    End Sub

    Private Sub ckFiltrarxFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxFecha.CheckedChanged
        Me.gbFiltrarxFecha.Enabled = Me.ckFiltrarxFecha.Checked
    End Sub

    Private Sub ckFiltrarxEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ckFiltrarxEstado.CheckedChanged
        Me.gbFiltrarxEstado.Enabled = Me.ckFiltrarxEstado.Checked
    End Sub

    Private Sub frmConsultaPedidosBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        Me.ConsultaBodega()
        Me.btnPedido.Enabled = False
        Me.btnRecibido.Enabled = False
        Me.btnAnulado.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ConsultaBodega()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            Dim Cod_Aticulo As String = Me.viewDatos.Item("Cod_Articulo", Me.viewDatos.CurrentRow.Index).Value
            Dim frm As New MovimientoArticulos
            frm.txtCodigo.Text = Cod_Aticulo
            frm.BuscarCodigoExterno()
            frm.Show()
            frm.DT_Inicio.EditValue = CDate("01/" & Date.Now.Month & "/" & Date.Now.Year)
            frm.MostrarCompras()
            frm.MostrarVentas()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub viewDatos_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellClick, viewDatos.CellEnter
        Try
            Dim Estado As String = Me.viewDatos.Item("Estado", e.RowIndex).Value

            Me.btnPedido.Enabled = False
            Me.btnRecibido.Enabled = False
            Me.btnAnulado.Enabled = False
            Me.btnAgotado.Enabled = False

            Select Case Estado
                Case "SOLICITADO"
                    Me.btnPedido.Enabled = True
                    Me.btnAnulado.Enabled = True
                    Me.btnAgotado.Enabled = True
                Case "PEDIDO"
                    Me.btnRecibido.Enabled = True
                Case "RECIBIDO"

                Case "ANULADO"

                Case "AGOTADO"
                    Me.btnPedido.Enabled = True
                    Me.btnAnulado.Enabled = True
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private IdUsuario As String = ""
    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        Try

            If Me.viewDatos.SelectedRows.Count > 1 Then
                MsgBox("Solo puede seleccionar una fila", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If

            Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
            Dim frm As New frmRegistrarPedido
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update PedidoBodega  Set FechaPedido = getdate(), Estado = 'PEDIDO', IdUsuarioPidio = '" & Me.IdUsuario & "', CantidadPedido = " & frm.txtCantidad.Value & ", Proveedor = " & frm.CodigoProv & " Where IdPedido = " & Id, CommandType.Text)
                Me.ConsultaBodega()
            End If
        Catch ex As Exception
            Me.ConsultaBodega()
        End Try
    End Sub

    Private Sub btnRecibido_Click(sender As Object, e As EventArgs) Handles btnRecibido.Click
        Try

            If Me.viewDatos.SelectedRows.Count > 1 Then
                MsgBox("Solo puede seleccionar una fila", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If

            Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
            Dim frm As New frmMarcarEstado
            frm.lblEstado.Text = "Cambiar Estado a Recibido"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update PedidoBodega  Set Estado = 'RECIBIDO', FechaRecibido = GetDate(), IdUsuarioRecibio = '" & Me.IdUsuario & "' Where IdPedido = " & Id, CommandType.Text)
                Me.ConsultaBodega()
            End If
        Catch ex As Exception
            Me.ConsultaBodega()
        End Try
    End Sub

    Private Sub btnAnulado_Click(sender As Object, e As EventArgs) Handles btnAnulado.Click
        Try
            Dim frm As New frmMarcarEstado
            frm.lblEstado.Text = "Cambiar Estado a Anulado"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
                For Each row As DataGridViewRow In Me.viewDatos.SelectedRows
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update PedidoBodega  Set Estado = 'ANULADO' Where IdPedido = " & row.Cells("IdPedido").Value, CommandType.Text)
                Next
                Me.ConsultaBodega()
            End If
        Catch ex As Exception
            Me.ConsultaBodega()
        End Try
    End Sub

    Private Sub btnPendientesSolicitud_Click(sender As Object, e As EventArgs) Handles btnPendientesSolicitud.Click
        Dim xestado As Boolean = Me.ckFiltrarxEstado.Checked
        Dim xfecha As Boolean = Me.ckFiltrarxFecha.Checked
        Dim _solicitado As Boolean = Me.ckSolicitado.Checked
        Dim _pedido As Boolean = Me.ckPedido.Checked
        Dim _recibido As Boolean = Me.ckRecibido.Checked
        Dim _anulado As Boolean = Me.ckAnulado.Checked

        Me.ckFiltrarxEstado.Checked = True
        Me.ckSolicitado.Checked = True
        Me.ckFiltrarxFecha.Checked = False
        Me.ckPedido.Checked = False
        Me.btnRecibido.Checked = False
        Me.ckAnulado.Checked = False

        Me.ConsultaBodega()

        'Me.ckFiltrarxEstado.Checked = xestado
        'Me.ckFiltrarxFecha.Checked = xfecha
        'Me.ckSolicitado.Checked = _solicitado
        'Me.ckPedido.Checked = _pedido
        'Me.ckRecibido.Checked = _recibido
        'Me.ckAnulado.Checked = _anulado
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xestado As Boolean = Me.ckFiltrarxEstado.Checked
        Dim xfecha As Boolean = Me.ckFiltrarxFecha.Checked
        Dim _solicitado As Boolean = Me.ckSolicitado.Checked
        Dim _pedido As Boolean = Me.ckPedido.Checked
        Dim _recibido As Boolean = Me.ckRecibido.Checked
        Dim _anulado As Boolean = Me.ckAnulado.Checked

        Me.ckFiltrarxEstado.Checked = True
        Me.ckPedido.Checked = True
        Me.ckFiltrarxFecha.Checked = False
        Me.ckSolicitado.Checked = False
        Me.btnRecibido.Checked = False
        Me.ckAnulado.Checked = False

        Me.ConsultaBodega()

        'Me.ckFiltrarxEstado.Checked = xestado
        'Me.ckFiltrarxFecha.Checked = xfecha
        'Me.ckSolicitado.Checked = _solicitado
        'Me.ckPedido.Checked = _pedido
        'Me.ckRecibido.Checked = _recibido
        'Me.ckAnulado.Checked = _anulado
    End Sub

    Private Sub btnAgotado_Click(sender As Object, e As EventArgs) Handles btnAgotado.Click
        Try

            If Me.viewDatos.SelectedRows.Count > 1 Then
                MsgBox("Solo puede seleccionar una fila", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If

            Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
            Dim frm As New frmMarcarEstado
            frm.lblEstado.Text = "Cambiar Estado a Agotado"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update PedidoBodega  Set Estado = 'AGOTADO' Where IdPedido = " & Id, CommandType.Text)
                Me.ConsultaBodega()
            End If
        Catch ex As Exception
            Me.ConsultaBodega()
        End Try
    End Sub


    Private dlgExportar As New SaveFileDialog With {.Title = "Guardar Documentos", .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments}

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
                    xlWS.cells(r + 2, columns + 1).value = dgv.Item(c, r).Value
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

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.viewDatos.RowCount > 0 Then
                If dlgExportar.ShowDialog = DialogResult.OK Then
                    Me.Exportar_Excel(Me.viewDatos, dlgExportar.FileName)
                    System.Diagnostics.Process.Start(dlgExportar.FileName)
                    MsgBox("Datos Exportados correctamente!!!", MsgBoxStyle.Information, "Exportacion exitosa")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "No se realizo la operacion")
        End Try
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & Me.txtUsuario.Text & "'", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            Me.GroupBox1.Enabled = True
            Me.txtUsuario.Enabled = False
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.lblUsuario.Text = dt.Rows(0).Item("Nombre")
        End If
    End Sub

End Class