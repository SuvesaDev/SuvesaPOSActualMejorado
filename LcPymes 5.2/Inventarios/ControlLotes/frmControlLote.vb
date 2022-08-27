Imports System.Data
Public Class frmControlLote

    Private Sub BuscarF1()
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Exit Sub
        End If
        Codigo = BuscarArt.Codigo
        Me.BuscarArticulo(Codigo)
    End Sub


    Private Codigo As String = ""
    Private Sub BuscarArticulo(_Cod_Articulo As String)
        Dim dtInven As New DataTable
        Dim dtLote As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _Cod_Articulo)
        dtInven = db.Ejecutar("select Codigo, Cod_Articulo, Barras, Costo, Descripcion, Existencia, Consignacion from Inventario where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo or Barras2 = @Codigo)", CommandType.Text)
        If dtInven.Rows.Count > 0 Then
            Me.Codigo = dtInven.Rows(0).Item("Codigo")
            Me.lblDescripcion.Text = dtInven.Rows(0).Item("Descripcion")
            Me.txtBarras.Text = dtInven.Rows(0).Item("Barras")

            db.AddParametro("@Codigo", Me.Codigo)
            dtLote = db.Ejecutar("Select Id, Barras, Lote, Vence, Cantidad, Actual from ControlLotes where Actual > 0 and Codigo = @Codigo", CommandType.Text)
            Me.viewDatos.DataSource = dtLote
            Me.viewDatos.Columns("Id").Visible = False
            Me.viewDatos.Columns("Vence").DefaultCellStyle.Format = "d"

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.BuscarF1()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.Codigo = "" Then Exit Sub
        If Me.txtBarras.Text <> "" Then
            If Me.txtLote.Text <> "" Then
                If Me.txtCantidad.Text <> "" Then
                    If IsNumeric(Me.txtCantidad.Text) = True Then
                        If CDec(Me.txtCantidad.Text) > 0 Then

                            Dim dt As New DataTable
                            Dim IdActualizar As Integer = 0
                            cFunciones.Llenar_Tabla_Generico("select * from ControlLotes where barras = '" & Me.txtBarras.Text & "'", dt, CadenaConexionSeePOS)
                            If dt.Rows.Count > 0 Then
                                MsgBox("Ya existe un lote con el mismo codigo de barras", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                                IdActualizar = dt.Rows(0).Item("Id")

                                If MsgBox("Desea Actualizar el lote y aumentar la cantidad en " & Me.txtCantidad.Text & " articulos más.", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Confirmar Accion.") = MsgBoxResult.Yes Then
                                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                                    db.AddParametro("@Lote", Me.txtLote.Text)
                                    db.AddParametro("@Cantidad", CDec(Me.txtCantidad.Text))
                                    db.Ejecutar("Update ControlLotes set Cantidad = Cantidad + @Cantidad, Actual = Actual + @Cantidad, Lote = @Lote Where Id = " & IdActualizar, CommandType.Text)

                                    Dim dtLote As New DataTable
                                    db.AddParametro("@Codigo", Me.Codigo)
                                    dtLote = db.Ejecutar("Select Id, Barras, Lote, Vence, Cantidad, Actual from ControlLotes where Actual > 0 and Codigo = @Codigo", CommandType.Text)
                                    Me.viewDatos.DataSource = dtLote
                                    Me.viewDatos.Columns("Id").Visible = False
                                    Me.viewDatos.Columns("Vence").DefaultCellStyle.Format = "d"

                                    Me.txtLote.Text = ""
                                    Me.dtpVence.Value = Date.Now
                                    Me.txtCantidad.Text = ""
                                    Me.txtBarras.Text = ""

                                    Exit Sub
                                End If

                            Else
                                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                                db.AddParametro("@Lote", Me.txtLote.Text)
                                db.AddParametro("@Vence", Me.dtpVence.Value)
                                db.AddParametro("@Codigo", Me.Codigo)
                                db.AddParametro("@Barras", Me.txtBarras.Text)
                                db.AddParametro("@Cantidad", CDec(Me.txtCantidad.Text))
                                db.Ejecutar("Insert into ControlLotes(IdReferencia, Lote, Vence, Codigo, Barras, Cantidad, Actual) values(0, @Lote, @Vence,@Codigo, @Barras, @Cantidad, @Cantidad)", CommandType.Text)

                                Dim dtLote As New DataTable
                                db.AddParametro("@Codigo", Me.Codigo)
                                dtLote = db.Ejecutar("Select Id, Barras, Lote, Vence, Cantidad, Actual from ControlLotes where Actual > 0 and Codigo = @Codigo", CommandType.Text)
                                Me.viewDatos.DataSource = dtLote
                                Me.viewDatos.Columns("Id").Visible = False
                                Me.viewDatos.Columns("Vence").DefaultCellStyle.Format = "d"

                                Me.txtLote.Text = ""
                                Me.dtpVence.Value = Date.Now
                                Me.txtCantidad.Text = ""
                                Me.txtBarras.Text = ""

                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If
        MsgBox("Debe llenar toda la informacion solicitada.", MsgBoxStyle.Exclamation, Text)
    End Sub

    Private Function NumeroRandom() As String
        Dim Generator As System.Random = New System.Random()
        Return CStr(Generator.Next(0, 999999).ToString).PadLeft(6, "0")
    End Function

    Private Function GenerarCodigoBarras() As String
        Dim Codigo As String = ""
        Dim hora, minuto, segundo, Ramdom As String
        hora = Date.Now.Hour.ToString.PadLeft(2, "0")
        minuto = Date.Now.Minute.ToString.PadLeft(2, "0")
        segundo = Date.Now.Second.ToString.PadLeft(2, "0")
        Codigo = "1" + hora + minuto + segundo + Me.NumeroRandom
        Return Codigo
    End Function

    Private Sub txtBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarras.KeyDown
        If e.KeyCode = Keys.F3 And Me.txtBarras.Text = "" Then
            Me.txtBarras.Text = Me.GenerarCodigoBarras
        End If
    End Sub

    Private Sub viewDatos_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles viewDatos.UserDeletingRow
        Dim id As String = Me.viewDatos.Item("Id", e.Row.Index).Value
        If MsgBox("Desea eliminar el lote", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar accion.") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Delete from ControlLotes where id = " & id, CommandType.Text)
        Else
            e.Cancel = True
        End If
    End Sub
End Class
