Imports System.Data

Public Class frmTomaAleatoria


    Private Encargado As String = ""
    Private Codigo As Long = 0
    Private Barras As String = ""
    Private Costo As Decimal = 0
    Private Index As Integer = 0
    Private IdPreTomaDetalle As Long = 0
    Private IdPreToma As Long = 0

    Private Sub Deshabilita()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnBuscar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.lblAnulada.Visible = False
        Me.Encargado = ""
    End Sub

    Private Sub LimpiarDatosArticulo()
        Me.Codigo = 0
        Me.Barras = ""
        Me.Costo = 0
        Me.lblMensaje.Text = ""
        Me.txtDescripcionProducto.Text = ""
        Me.txtCodigo.Text = ""
        Me.txtCantidadContada.Text = "0"
        Me.txtCantidadSistema.Text = "0"
        Me.txtDiferencia.Text = "0"
        Me.txtCodigo.Focus()
        Me.btnIncluirLinea.Enabled = False
    End Sub

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

    Private NuevaLinea As Boolean = False

    Private Function GetCodArticulo(_Barras As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select top 1 Cod_Articulo from Inventario i inner join ControlLotes l on i.Codigo = l.Codigo where i.inhabilitado = 0 and l.Barras = '" & _Barras & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Cod_Articulo")
        Else
            Return _Barras
        End If
    End Function

    Private Sub BuscarArticulo(_Cod_Articulo As String)
        Me.btnIncluirLinea.Enabled = False
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

        If _Cod_Articulo.Contains("_") Then
            Dim barras() As String = _Cod_Articulo.Split("_")
            _Cod_Articulo = barras(1)
        Else
            _Cod_Articulo = Me.GetCodArticulo(_Cod_Articulo)
        End If

        db.AddParametro("@Codigo", _Cod_Articulo)
        dt = db.Ejecutar("select Codigo, Cod_Articulo, Barras, Costo, Descripcion, Existencia, Consignacion from Inventario where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo or Barras2 = @Codigo)", CommandType.Text)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Consignacion") = False Then

                Me.lblMensaje.Text = "Nuevo Conteo"
                Me.lblMensaje.ForeColor = System.Drawing.Color.Blue

                Me.Codigo = dt.Rows(0).Item("Codigo")
                For Each r As DataGridViewRow In Me.viewDatos.Rows
                    Me.viewDatos.CurrentCell = r.Cells("cToma")
                    If r.Cells("cCodigo").Value = Me.Codigo Then
                        Me.txtCantidadContada.Text = r.Cells("cToma").Value
                        r.Selected = True
                        Me.lblMensaje.Text = "Actualizar Conteo"
                        Me.lblMensaje.ForeColor = System.Drawing.Color.Green
                        Exit For
                    Else
                        r.Selected = False
                    End If
                Next

                Me.txtCodigo.Text = dt.Rows(0).Item("Cod_Articulo")
                Me.Barras = dt.Rows(0).Item("Barras")
                Me.Costo = dt.Rows(0).Item("Costo")
                Me.txtDescripcionProducto.Text = dt.Rows(0).Item("Descripcion")
                Me.txtCantidadSistema.Text = dt.Rows(0).Item("Existencia")
                Me.dtpFechaVencimiento.Focus()
                Me.btnIncluirLinea.Enabled = True
            End If
        End If
    End Sub

    Private Sub Contar()
        Dim Row As System.Collections.Generic.List(Of DataGridViewRow) = (From r As DataGridViewRow In Me.viewDatos.Rows Where r.Cells("cCodigo").Value = Me.Codigo Select r).ToList
        If Row.Count > 0 Then
            Row(0).Cells("cToma").Value = CDec(Me.txtCantidadContada.Text)
            Row(0).Cells("cDiferencia").Value = CDec(Me.txtDiferencia.Text)
            Me.LimpiarDatosArticulo()
        Else
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cIdPreTomaDetalle", Me.Index).Value = 0
            Me.viewDatos.Item("cIdPreToma", Me.Index).Value = 0
            Me.viewDatos.Item("cCodigo", Me.Index).Value = Me.Codigo
            Me.viewDatos.Item("cCod_Articulo", Me.Index).Value = Me.txtCodigo.Text
            Me.viewDatos.Item("cBarras", Me.Index).Value = Me.Barras
            Me.viewDatos.Item("cDescripcion", Me.Index).Value = Me.txtDescripcionProducto.Text
            Me.viewDatos.Item("cCosto", Me.Index).Value = Me.Costo
            Me.viewDatos.Item("cVencimiento", Me.Index).Value = Me.dtpFechaVencimiento.Value
            Me.viewDatos.Item("cExistencia", Me.Index).Value = CDec(Me.txtCantidadSistema.Text)
            Me.viewDatos.Item("cToma", Me.Index).Value = CDec(Me.txtCantidadContada.Text)
            Me.viewDatos.Item("cDiferencia", Me.Index).Value = CDec(Me.txtDiferencia.Text)
            Me.viewDatos.Item("cContado", Me.Index).Value = True
            Me.Index += 1
            Me.LimpiarDatosArticulo()
        End If
        For Each r As DataGridViewRow In Me.viewDatos.Rows
            Me.viewDatos.CurrentCell = r.Cells("cToma")
            r.Selected = False
        Next
    End Sub

    Private Sub CalcularDiferencia()
        Try
            If Me.txtCantidadContada.Text <> "" Then
                Dim Toma As Decimal = CDec(Me.txtCantidadContada.Text)
                Dim Sistema As Decimal = CDec(Me.txtCantidadSistema.Text)
                Me.txtDiferencia.Text = CDec(Toma - Sistema).ToString("N2")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Nuevo()
        If Me.viewDatos.Rows.Count > 0 Then
            MsgBox("Desea realizar una nueva PreToma.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion!!!")
        End If
        Me.Deshabilita()
        Me.GroupBox1.Enabled = True
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.txtCodigo.Focus()
        Me.IdPreToma = 0
        Me.IdPreTomaDetalle = 0
        Me.viewDatos.Rows.Clear()
        Me.Index = 0
    End Sub

    Private Sub Guardar(_Encargado As String)
        Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try

            db.AddParametroSalida("@Id", Me.IdPreToma)
            db.SetParametro("@Fecha", Date.Now)
            db.SetParametro("@Encargado", _Encargado)
            db.Ejecutar("Guardar_PreTomaFisica", Me.IdPreToma, 0)

            For Each fila As DataGridViewRow In Me.viewDatos.Rows
                db.SetParametro("@IdPreToma", Me.IdPreToma)
                db.SetParametro("@Codigo", fila.Cells("cCodigo").Value)
                db.SetParametro("@Cod_Articulo", fila.Cells("cCod_Articulo").Value)
                db.SetParametro("@Barras", fila.Cells("cBarras").Value)
                db.SetParametro("@Descripcion", fila.Cells("cDescripcion").Value)
                db.SetParametro("@Costo", fila.Cells("cCosto").Value)
                db.SetParametro("@Existencia", fila.Cells("cExistencia").Value)
                db.SetParametro("@Toma", fila.Cells("cToma").Value)
                db.SetParametro("@Diferencia", fila.Cells("cDiferencia").Value)
                db.SetParametro("@Contado", 1)
                If fila.Cells("cIdPreTomaDetalle").Value = 0 Then
                    db.Ejecutar("Insert into PreTomaGeneralDetalle(IdPreToma,Codigo,Cod_Articulo,Barras,Descripcion,Costo,Existencia,Toma,Diferencia,Contado) Values(@IdPreToma,@Codigo,@Cod_Articulo,@Barras,@Descripcion,@Costo,@Existencia,@Toma,@Diferencia,@Contado)", CommandType.Text)
                Else
                    db.Ejecutar("Update PreTomaGeneralDetalle Set Codigo = @Codigo, Cod_Articulo = @Cod_Articulo, Barras = @Barras, Descripcion = @Descripcion, Costo = @Costo, Existencia = @Existencia, Toma = @Toma, Diferencia = @Diferencia Where IdPreTomaDetalle = " & fila.Cells("cIdPreTomaDetalle").Value, CommandType.Text)
                End If
            Next

            db.Commit()
            Me.viewDatos.Rows.Clear()
            Me.LimpiarDatosArticulo()
            Me.Deshabilita()
            Me.GroupBox1.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnBuscar.Enabled = True
        Catch ex As Exception
            db.Rollback()
        End Try
    End Sub

    Private Sub Buscar()
        Dim frm As New frmBuscarPretomaGeneral
        frm.SoloActivas = False
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dtDetalle As New DataTable
            Dim dtEncabezado As New DataTable

            Me.IdPreToma = frm.viewDatos.Item("IdPreToma", frm.viewDatos.CurrentRow.Index).Value
            cFunciones.Llenar_Tabla_Generico("Select * from PreTomaGeneral Where IdPreToma = " & IdPreToma, dtEncabezado, CadenaConexionSeePOS)
            If dtEncabezado.Rows.Count > 0 Then
                cFunciones.Llenar_Tabla_Generico("Select * from PreTomaGeneralDetalle Where IdPreToma = " & IdPreToma, dtDetalle, CadenaConexionSeePOS)
                If dtDetalle.Rows.Count > 0 Then
                    Me.Index = 0
                    Me.viewDatos.Rows.Clear()
                    For Each r As DataRow In dtDetalle.Rows
                        Me.viewDatos.Rows.Add()
                        Me.viewDatos.Item("cIdPreTomaDetalle", Me.Index).Value = r.Item("IdPreTomaDetalle")
                        Me.viewDatos.Item("cIdPreToma", Me.Index).Value = r.Item("IdPreToma")
                        Me.viewDatos.Item("cCodigo", Me.Index).Value = r.Item("Codigo")
                        Me.viewDatos.Item("cCod_Articulo", Me.Index).Value = r.Item("Cod_Articulo")
                        Me.viewDatos.Item("cBarras", Me.Index).Value = r.Item("Barras")
                        Me.viewDatos.Item("cDescripcion", Me.Index).Value = r.Item("Descripcion")
                        Me.viewDatos.Item("cCosto", Me.Index).Value = r.Item("Costo")
                        Me.viewDatos.Item("cExistencia", Me.Index).Value = r.Item("Existencia")
                        Me.viewDatos.Item("cToma", Me.Index).Value = r.Item("Toma")
                        Me.viewDatos.Item("cDiferencia", Me.Index).Value = r.Item("Diferencia")
                        Me.viewDatos.Item("cContado", Me.Index).Value = True
                        Me.Index += 1
                    Next
                    For Each r As DataGridViewRow In Me.viewDatos.Rows
                        Me.viewDatos.CurrentCell = r.Cells("cToma")
                        r.Selected = False
                    Next
                    Me.LimpiarDatosArticulo()

                    Me.Deshabilita()
                    Me.GroupBox1.Enabled = True
                    Me.btnNuevo.Enabled = True
                    Me.btnGuardar.Enabled = True
                    Me.btnAnular.Enabled = True
                    Me.lblAnulada.Visible = dtEncabezado.Rows(0).Item("Anulado")
                    Me.Encargado = dtEncabezado.Rows(0).Item("Encargado")
                    If Me.lblAnulada.Visible = True Then
                        Me.btnGuardar.Enabled = False
                        Me.GroupBox1.Enabled = False
                        Me.btnAnular.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Editar()
        Me.Deshabilita()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = True
    End Sub

    Private Sub Anular()
        If MsgBox("Desea Anular la Pretoma", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update PreTomaGeneral Set Anulado = 1 Where IdPreToma = " & Me.IdPreToma, CommandType.Text)
            Me.viewDatos.Rows.Clear()
            Me.LimpiarDatosArticulo()
            Me.Deshabilita()
            Me.btnNuevo.Enabled = True
            Me.btnBuscar.Enabled = True
        End If
    End Sub

    Private Sub Imprimir()

    End Sub

    Private Sub Ajustar()
        Me.Deshabilita()
        Me.btnNuevo.Enabled = True
        Me.btnBuscar.Enabled = True
    End Sub

    Private Sub frmTomaFisicaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Deshabilita()
        Me.btnNuevo.Enabled = True
        Me.btnBuscar.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim frm As New frmEncargadoPretoma
        frm.txtEncargado.Text = Me.Encargado
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Guardar(frm.txtEncargado.Text)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Me.Editar()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Me.Anular()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        Me.Imprimir()
    End Sub

    Private Sub btnAjustar_Click(sender As Object, e As EventArgs)
        Me.Ajustar()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtCodigo.Text <> "" Then
            Me.BuscarArticulo(Me.txtCodigo.Text)
        End If
        If e.KeyCode = Keys.F1 Then
            Me.BuscarF1()
        End If
    End Sub

    Private Sub txtCantidadContada_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidadContada.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtCantidadContada.Text <> "" Then
            Me.btnIncluirLinea.Focus()
        End If
    End Sub

    Private Sub txtCantidadContada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadContada.KeyPress
        If e.KeyChar <> "." Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCantidadContada_Leave(sender As Object, e As EventArgs) Handles txtCantidadContada.Leave
        Me.CalcularDiferencia()
    End Sub

    Private Sub btnIncluirLinea_Click(sender As Object, e As EventArgs) Handles btnIncluirLinea.Click
        Me.Contar()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Me.BuscarF1()
    End Sub

    Private Sub viewDatos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles viewDatos.RowsRemoved
        Me.Index -= 1
    End Sub

    Private Sub dtpFechaVencimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaVencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then Me.txtCantidadContada.Focus()
    End Sub
End Class