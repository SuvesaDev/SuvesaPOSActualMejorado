Imports System.Data

Public Class frmTomaFisicaGeneral

    Private IdToma As Long = 0
    Private Index As Integer = 0
    Private Codigo As Long = 0

    Private Sub Deshabilita()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnBuscar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnImprimir.Enabled = False
        Me.btnArticulosSinContar.Enabled = False
        Me.btnAjustar.Enabled = False
    End Sub

    Private Sub LimpiarTotales()
        Me.txtAjusteEntrada.Text = "0"
        Me.txtAjusteSalida.Text = "0"
        Me.txtSaldoAjuste.Text = "0"
        Me.txtTotalArticulos.Text = "0"
        Me.txtArticulosContados.Text = "0"
        Me.txtArticulosnoContados.Text = "0"
    End Sub

    Private Sub LimpiarDatosArticulo()
        Me.Codigo = 0
        Me.txtDescripcionProducto.Text = ""
        Me.txtCodigo.Text = ""
        Me.txtCantidadContada.Text = "0"
        Me.txtCantidadSistema.Text = "0"
        Me.txtDiferencia.Text = "0"
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

    Private Sub BuscarArticulo(_Codigo As String)
        Me.btnIncluirLinea.Enabled = False
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _Codigo)
        dt = db.Ejecutar("select Codigo, Descripcion, Existencia, Consignacion from Inventario where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo)", CommandType.Text)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Consignacion") = False Then
                Me.Codigo = dt.Rows(0).Item("Codigo")
                For Each r As DataGridViewRow In Me.viewDatos.Rows
                    Me.viewDatos.CurrentCell = r.Cells("Toma")
                    If r.Cells("Codigo").Value = Me.Codigo Then
                        Me.txtCantidadContada.Text = r.Cells("Toma").Value
                        r.Selected = True
                        Exit For
                    Else
                        r.Selected = False
                    End If
                Next
                Me.txtDescripcionProducto.Text = dt.Rows(0).Item("Descripcion")
                Me.txtCantidadSistema.Text = dt.Rows(0).Item("Existencia")
                Me.txtCantidadContada.Focus()
                Me.btnIncluirLinea.Enabled = True
            End If
        End If
    End Sub

    Private Sub Contar()
        Dim linea As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Codigo").Value = Me.Codigo Select x).ToList
        If linea.Count = 1 Then
            linea(0).Cells("Toma").Value += CDec(Me.txtCantidadContada.Text)
            linea(0).Cells("Diferencia").Value = CDec(linea(0).Cells("Toma").Value) - CDec(linea(0).Cells("Existencia").Value)
            linea(0).Cells("Contado").Value = True
            Me.CuentaArticulos()
            Me.LimpiarDatosArticulo()
            Me.btnIncluirLinea.Enabled = False
            Me.txtCodigo.Focus()
        Else

        End If
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

    Private Sub CuentaArticulos()
        Dim CantidadTotal As Integer = (From x As DataGridViewRow In Me.viewDatos.Rows Select x.Cells("Codigo").Value).Count
        Dim ArticulosContados As Integer = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Contado").Value = True Select x.Cells("Codigo").Value).Count
        Dim ArticulosnoContados As Integer = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Contado").Value = False Select x.Cells("Codigo").Value).Count

        Me.txtTotalArticulos.Text = CantidadTotal
        Me.txtArticulosContados.Text = ArticulosContados
        Me.txtArticulosnoContados.Text = ArticulosnoContados

        Dim Entrada As Decimal = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Diferencia").Value > 0 Select CDec(x.Cells("Diferencia").Value * x.Cells("Costo").Value)).Sum
        Dim Salida As Decimal = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Diferencia").Value < 0 Select CDec(x.Cells("Diferencia").Value * x.Cells("Costo").Value)).Sum
        Dim Saldo As Decimal = Math.Abs(Entrada) - Math.Abs(Salida)

        Me.txtAjusteEntrada.Text = Entrada.ToString("N2")
        Me.txtAjusteSalida.Text = Salida.ToString("N2")
        Me.txtSaldoAjuste.Text = Saldo.ToString("N2")
    End Sub

    Private Sub Nuevo()
        Me.Deshabilita()
        Me.LimpiarTotales()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.IdToma = 0
        Dim Consulta As String = ""

        Dim frm As New frmOpcionTomaFisicaGeneral
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            If frm.rbTodos.Checked = True Then
                Consulta = "Select 0 as IdTomaDetalle, * from viewTomaGeneral"
            Else
                Consulta = "Select 0 as IdTomaDetalle, * from viewTomaGeneral where SubUbicacion in(select Codigo from SubUbicacion where Cod_Ubicacion = '" & frm.cboUbicacion.SelectedValue & "')"
            End If

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico(Consulta, dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("IdTomaDetalle").Visible = False
            Me.viewDatos.Columns("Codigo").Visible = False
            Me.viewDatos.Columns("Costo").Visible = False
            Me.viewDatos.Columns("Barras").Visible = False

            Me.viewDatos.Columns("Existencia").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Existencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.viewDatos.Columns("Toma").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Toma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.viewDatos.Columns("Diferencia").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Diferencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.CuentaArticulos()
        End If
    End Sub

    Private Sub Guardar()
        Dim frm As New Conecta_Frm
        frm.Show("Espere porfavor, La Operacion puede Tardar varios Minutos", "Procesando...")
        Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            db.AddParametroSalida("@Id", Me.IdToma)
            db.SetParametro("@Fecha", Date.Now)
            db.Ejecutar("Guardar_TomaFisica", Me.IdToma, 0)
            For Each fila As DataGridViewRow In Me.viewDatos.Rows
                db.SetParametro("@IdPreToma", Me.IdToma)
                db.SetParametro("@Codigo", fila.Cells("Codigo").Value)
                db.SetParametro("@Cod_Articulo", fila.Cells("Cod_Articulo").Value)
                db.SetParametro("@Barras", fila.Cells("Barras").Value)
                db.SetParametro("@Descripcion", fila.Cells("Descripcion").Value)
                db.SetParametro("@Costo", fila.Cells("Costo").Value)
                db.SetParametro("@Existencia", fila.Cells("Existencia").Value)
                db.SetParametro("@Toma", fila.Cells("Toma").Value)
                db.SetParametro("@Diferencia", fila.Cells("Diferencia").Value)
                db.SetParametro("@Contado", fila.Cells("Contado").Value)
                If fila.Cells("IdTomaDetalle").Value = 0 Then
                    db.Ejecutar("Insert into TomaGeneralDetalle(IdToma,Codigo,Cod_Articulo,Barras,Descripcion,Costo,Existencia,Toma,Diferencia,Contado) Values(@IdPreToma,@Codigo,@Cod_Articulo,@Barras,@Descripcion,@Costo,@Existencia,@Toma,@Diferencia,@Contado)", CommandType.Text)
                Else
                    db.Ejecutar("Update TomaGeneralDetalle Set Codigo = @Codigo, Cod_Articulo = @Cod_Articulo, Barras = @Barras, Descripcion = @Descripcion, Costo = @Costo, Existencia = @Existencia, Toma = @Toma, Diferencia = @Diferencia, Contado = @Contado Where IdTomaDetalle = " & fila.Cells("IdTomaDetalle").Value, CommandType.Text)
                End If
            Next
            For Each PreToma As String In Me.ListaPretoma
                If IsNumeric(PreToma) = True Then
                    db.Ejecutar("Update PreTomaGeneral Set Aplicado = 1 Where IdPreToma = " & PreToma, CommandType.Text)
                End If
            Next
            db.Commit()
            frm.Close()
            Me.viewDatos.DataSource = Nothing
            Me.LimpiarDatosArticulo()
            Me.Deshabilita()
            Me.LimpiarTotales()
            Me.GroupBox1.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnBuscar.Enabled = True
        Catch ex As Exception
            db.Rollback()
            frm.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub Buscar()
        Dim frm As New frmBuscarTomaGeneral
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dtDetalle As New DataTable
            Dim dtEncabezado As New DataTable

            Me.IdToma = frm.viewDatos.Item("IdToma", frm.viewDatos.CurrentRow.Index).Value
            cFunciones.Llenar_Tabla_Generico("Select * from TomaGeneral Where IdToma = " & IdToma, dtEncabezado, CadenaConexionSeePOS)
            If dtEncabezado.Rows.Count > 0 Then
                cFunciones.Llenar_Tabla_Generico("Select * from TomaGeneralDetalle Where IdToma = " & IdToma, dtDetalle, CadenaConexionSeePOS)
                If dtDetalle.Rows.Count > 0 Then
                    Me.viewDatos.DataSource = dtDetalle
                    Me.viewDatos.Columns("IdTomaDetalle").Visible = False
                    Me.viewDatos.Columns("IdToma").Visible = False
                    Me.viewDatos.Columns("Codigo").Visible = False
                    Me.viewDatos.Columns("Costo").Visible = False
                    Me.viewDatos.Columns("Barras").Visible = False

                    Me.viewDatos.Columns("Existencia").DefaultCellStyle.Format = "N2"
                    Me.viewDatos.Columns("Existencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    Me.viewDatos.Columns("Toma").DefaultCellStyle.Format = "N2"
                    Me.viewDatos.Columns("Toma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    Me.viewDatos.Columns("Diferencia").DefaultCellStyle.Format = "N2"
                    Me.viewDatos.Columns("Diferencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    Me.CuentaArticulos()
                    Me.LimpiarDatosArticulo()

                    Me.Deshabilita()
                    Me.GroupBox1.Enabled = True
                    Me.btnNuevo.Enabled = True
                    Me.btnGuardar.Enabled = True
                    Me.btnImprimir.Enabled = True
                    Me.btnArticulosSinContar.Enabled = True
                    Me.btnAnular.Enabled = True
                    Me.btnAjustar.Enabled = True

                    If dtEncabezado.Rows(0).Item("Anulado") = True Then
                        Me.lblAnulada.Visible = True
                        Me.btnAjustar.Enabled = False
                        Me.btnGuardar.Enabled = False
                        Me.btnAnular.Enabled = False
                        Me.GroupBox1.Enabled = False
                    Else
                        Me.lblAnulada.Visible = False
                    End If

                    If dtEncabezado.Rows(0).Item("Ajustado") = True Then
                        Me.lblAjustado.Visible = True
                        Me.btnAjustar.Enabled = False
                        Me.btnGuardar.Enabled = False
                        Me.GroupBox1.Enabled = False
                        Me.btnAnular.Enabled = False
                    Else
                        Me.lblAjustado.Visible = False
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Anular()
        If MsgBox("Desea Anular la Toma General", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update TomaGeneral Set Anulado = 1 Where IdToma = " & Me.IdToma, CommandType.Text)
            Me.viewDatos.DataSource = Nothing
            Me.LimpiarDatosArticulo()
            Me.Deshabilita()
            Me.btnNuevo.Enabled = True
            Me.btnBuscar.Enabled = True
        End If
    End Sub

    Private Sub Imprimir()
        If Me.IdToma > 0 Then
            Dim rpt As New rptTomaGeneral
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.IdToma)
            CrystalReportsConexion.LoadShow(rpt, MdiParent, CadenaConexionSeePOS)
        End If
    End Sub

    Private Sub ImprimirNoContados()
        If Me.IdToma > 0 Then
            Dim rpt As New rptArticulosSinContar
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.IdToma)
            CrystalReportsConexion.LoadShow(rpt, MdiParent, CadenaConexionSeePOS)
        End If
    End Sub

    Private Sub Ajustar()
        If MsgBox("Desea Aplicar los Ajustes de la Toma General", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
            Dim frm As New Conecta_Frm
            frm.Show("Espere porfavor, La Operacion puede Tardar varios Minutos", "Procesando...")
            Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            Try
                db.SetParametro("@Id", Me.IdToma)
                db.Ejecutar("Aplicar_TomaGeneral")
                db.Commit()
                Me.viewDatos.DataSource = Nothing
                Me.LimpiarDatosArticulo()
                Me.Deshabilita()
                Me.btnNuevo.Enabled = True
                Me.btnBuscar.Enabled = True
                frm.Close()
            Catch ex As Exception
                db.Rollback()
                frm.Close()
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            End Try                     
        End If
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
        If MsgBox("Desea Guardar la Toma.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
            Me.Guardar()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Me.Anular()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub btnAjustar_Click(sender As Object, e As EventArgs) Handles btnAjustar.Click
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
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadContada_Leave(sender As Object, e As EventArgs) Handles txtCantidadContada.Leave
        Me.CalcularDiferencia()
    End Sub

    Private Sub btnIncluirLinea_Click(sender As Object, e As EventArgs) Handles btnIncluirLinea.Click
        Me.Contar()
    End Sub

    Private ListaPretoma As New System.Collections.Generic.List(Of String)
    Private Sub btnCargarPretoma_Click(sender As Object, e As EventArgs) Handles btnCargarPretoma.Click
        Dim frm As New frmCargarPreTomaGeneral
        Dim Lista As String = ""
        For i As Integer = 0 To Me.ListaPretoma.Count - 1
            If i = 0 Then
                Lista = Me.ListaPretoma(i)
            Else
                Lista += ", " & Me.ListaPretoma(i)
            End If
        Next
        frm.ListaPretomas = Lista
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each pre As DataGridViewRow In frm.viewDatos.Rows
                If pre.Cells("Usar").Value = True Then
                    Dim IdPreToma As Long = pre.Cells("IdPreToma").Value
                    Me.ListaPretoma.Add(IdPreToma.ToString)
                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico("select  * from PreTomaGeneralDetalle where IdPreToma = " & IdPreToma, dt, CadenaConexionSeePOS)
                    Dim Fila As System.Collections.Generic.List(Of DataGridViewRow)
                    For Each r As DataRow In dt.Rows
                        Fila = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Codigo").Value = r.Item("Codigo")).ToList
                        If Fila.Count = 1 Then
                            Fila(0).Cells("Toma").Value += r.Item("Toma")
                            Fila(0).Cells("Diferencia").Value = CDec(Fila(0).Cells("Toma").Value - CDec(Fila(0).Cells("Existencia").Value))
                            Fila(0).Cells("Contado").Value = True
                        End If
                    Next
                End If
            Next
            Me.CuentaArticulos()
        End If
    End Sub

    Private Sub btnArticulosSinContar_Click(sender As Object, e As EventArgs) Handles btnArticulosSinContar.Click
        Me.ImprimirNoContados()
    End Sub
End Class