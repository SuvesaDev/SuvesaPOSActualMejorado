Imports System.Data
Public Class frmEditarAlbaran

    Public IdUsuario As String = ""
    Public IdAlbaran As Long
    Public MaxDescuento As Decimal = 0
    Public CambiarPrecio As Decimal = 0
    Private CodigoArticulo As Long
    Private Index As Integer = 0

    '*************************************************************************************
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
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

        If _Cod_Articulo.Contains("_") Then
            Dim barras() As String = _Cod_Articulo.Split("_")
            _Cod_Articulo = barras(1)
        Else
            _Cod_Articulo = Me.GetCodArticulo(_Cod_Articulo)
        End If

        Me.CargarArticulo(_Cod_Articulo)
    End Sub
    '*******************************************************************************************

    Public Sub AgregarLinea(_Id As Long, _
                            _IdAlbaran As Long, _
                            _Codigo As Long, _
                            _Descripcion As String, _
                            _Cantidad As Decimal, _
                            _Precio As Decimal, _
                            _Impuesto As Decimal, _
                            _Descuento As Decimal, _
                            _Unidad As String, _
                            _Total As Decimal)
        Me.viewDatos.Rows.Add()
        Me.viewDatos.Item("cId", Index).Value = _Id
        Me.viewDatos.Item("cIdAlbaran", Index).Value = _IdAlbaran
        Me.viewDatos.Item("cCodigo", Index).Value = _Codigo
        Me.viewDatos.Item("cDescripcion", Index).Value = _Descripcion
        Me.viewDatos.Item("cCantidad", Index).Value = _Cantidad
        Me.viewDatos.Item("cPrecio", Index).Value = _Precio
        Me.viewDatos.Item("cIva", Index).Value = _Impuesto
        Me.viewDatos.Item("cDescuento", Index).Value = _Descuento
        Me.viewDatos.Item("cUnidad", Index).Value = _Unidad
        Me.viewDatos.Item("cTotal", Index).Value = _Total
        Index += 1
        Me.CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Try
            Me.txtTotalAlbaran.Text = (From x As DataGridViewRow In Me.viewDatos.Rows
                                       Where x.Visible = True
                                       Select CDec(x.Cells("cTotal").Value)).Sum.ToString("N2")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CargarAlbaran()
        Dim dtEncabezado As New DataTable
        Dim dtDetalle As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewAlbaran Where Id = " & Me.IdAlbaran, dtEncabezado, CadenaConexionSeePOS)
        If dtEncabezado.Rows.Count > 0 Then
            Me.txtCliente.Text = dtEncabezado.Rows(0).Item("Cliente")
            Me.txtMascota.Text = dtEncabezado.Rows(0).Item("Mascota")
            Me.txtFecha.Text = CDate(dtEncabezado.Rows(0).Item("Fecha")).ToShortDateString

            cFunciones.Llenar_Tabla_Generico("select id, id_albaran as IdEncabezado, descripcion, codarticulo as CodigoInternoQvet, Cantidad, Impuestos as IVA, Descuento, Precio_Unit as PrecioVenta, (subtotal - Monto_Descuento + Monto_Impuestos) as Total, '' as Unidad  from viewAlbaranDetalle where id_albaran = " & Me.IdAlbaran, dtDetalle, CadenaConexionSeePOS)

            Me.Index = 0
            Me.viewDatos.Rows.Clear()
            For Each row As DataRow In dtDetalle.Rows
                With row
                    Me.AgregarLinea(.Item("Id"), .Item("idencabezado"), .Item("codigointernoqvet"), .Item("descripcion"), .Item("cantidad"), .Item("precioventa"), .Item("iva"), .Item("descuento"), .Item("unidad"), .Item("total"))
                End With
            Next

        End If

    End Sub

    Private Sub MeteralDetalle()
        Try

            If Me.CodigoArticulo > 0 And
                IsNumeric(Me.txtPrecio.Text) And
                IsNumeric(Me.txtCantidad.Text) And
                IsNumeric(Me.txtDescuento.Text) And
                IsNumeric(Me.txtIVA.Text) Then

                If CDec(Me.txtDescuento.Text) > Me.MaxDescuento Then
                    MsgBox("No puede aplicar este descuento," & vbCrLf _
                       & "Maximo descuento " & Me.MaxDescuento & "%", MsgBoxStyle.Exclamation, "No se puede procesar la operacion.")
                    Exit Sub
                End If

                Dim Subtotal As Decimal = CDec(Me.txtCantidad.Text) * CDec(Me.txtPrecio.Text)
                Dim Descuento As Decimal = Subtotal * (CDec(Me.txtDescuento.Text) / 100)
                Dim Impuestos As Decimal = (Subtotal - Descuento) * (CDec(Me.txtIVA.Text) / 100)
                Dim Total As Decimal = Subtotal - Descuento + Impuestos

                Me.AgregarLinea(0,
                                Me.IdAlbaran,
                                Me.CodigoArticulo,
                                Me.lblDescripcion.Text,
                                Me.txtCantidad.Text,
                                (Total / CDec(Me.txtCantidad.Text)),
                                Me.txtIVA.Text,
                                Me.txtDescuento.Text,
                                "UNIDAD",
                                Total)

                Me.CodigoArticulo = 0
                Me.txtCodigo.Text = ""
                Me.lblDescripcion.Text = ""
                Me.txtCantidad.Text = "1"
                Me.txtIVA.Text = "13"
                Me.txtDescuento.Text = "0"
                Me.txtCodigo.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarArticulo(_CodArticulo As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select i.Codigo, i.Cod_Articulo, (Descripcion + ' ' + CAST(i.PresentaCant As Nvarchar) + ' ' + p.Presentaciones) as Descripcion, Precio_A, IVenta, Max_Descuento, i.Consignacion From Inventario i Inner Join Presentaciones p On i.CodPresentacion = p.CodPres Where i.Inhabilitado = 0 and (i.Cod_Articulo = '" & _CodArticulo & "' or i.Barras = '" & _CodArticulo & "' or i.barras2 = '" & _CodArticulo & "' or i.barras3 = '" & _CodArticulo & "')", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Consignacion") = True Then
                Dim frm As New frmMensajeConsignacion
                frm.ShowDialog()
                Exit Sub
            Else
                Me.txtCodigo.Text = _CodArticulo
                Me.CodigoArticulo = dt.Rows(0).Item("Cod_Articulo")
                Me.lblDescripcion.Text = dt.Rows(0).Item("Descripcion")
                Me.txtPrecio.Text = Math.Round(CDec(dt.Rows(0).Item("Precio_A")), 4)
                Me.txtCantidad.Text = "1"
                Me.txtIVA.Text = dt.Rows(0).Item("IVenta")
                Me.txtDescuento.Text = "0"
                Me.txtCantidad.Focus()
            End If
        Else
            MsgBox("El producto no existe o esta deshabilitado!!!", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

    Private Sub frmEditarAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtPrecio.ReadOnly = IIf(Me.CambiarPrecio, False, True)
        Me.txtDescuento.ReadOnly = IIf(Me.MaxDescuento > 0, False, True)
        Me.txtIVA.ReadOnly = True
        Me.CargarAlbaran()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        For Each row As DataGridViewRow In Me.viewDatos.Rows
            If row.Cells("cPrecio").Value <= 0 Then
                MsgBox("No se puede vender articulos con precio cero.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.MeteralDetalle()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.BuscarF1()
        End If

        If e.KeyCode = Keys.Enter And Me.txtCodigo.Text <> "" Then
            Me.CargarArticulo(Me.txtCodigo.Text)
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown, txtIVA.KeyDown, txtDescuento.KeyDown, txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter And sender.Text <> "" Then SendKeys.Send("{Tab}")
    End Sub

    Dim Intento As Integer = 0

    Private Sub Eliminar()
        'Dim Row As Integer = Me.viewDatos.CurrentRow.Index
        'Dim Id As Long = Me.viewDatos.Item("cId", Row).Value

        Dim frm As New frmMovitoEliminacion
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each r As DataGridViewRow In Me.viewDatos.SelectedRows
                r.Cells("cMotivo").Value = frm.txtMotivo.Text
                r.Visible = False
                Me.CalcularTotal()
                'Me.viewDatos.Item("cMotivo", Row).Value = frm.txtMotivo.Text
                'Me.viewDatos.Rows(Row).Visible = False
                'Me.CalcularTotal()
            Next
        End If
    End Sub

    Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
        If e.KeyCode = Keys.Delete Then

            If IdUsuario = "502250594" Or IdUsuario = "117420903" Or IdUsuario = "Vitolo" Then
                Me.Eliminar()
            Else
                MsgBox("No se pueden eliminar lineas.", MsgBoxStyle.Critical, Me.Text)
                Intento += 1

                If Intento < 9 Then
                    Exit Sub
                Else
                    Me.Eliminar()
                End If
            End If
        End If
    End Sub

    Private Sub btnDescuentoTeleton_Click(sender As Object, e As EventArgs) Handles btnDescuentoTeleton.Click
        Dim frm As New frmDescuentoTeleton
        Dim Total As Decimal = (From x As DataGridViewRow In Me.viewDatos.Rows
                                Where x.Cells("cDescripcion").Value.ToString.Contains("TELETÓN") = True
                                Select CDec(x.Cells("cCantidad").Value)).Sum
        frm.CantidadMaxima = Total
        frm.CantidadDevolver = Total
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each row As DataGridViewRow In (From x As DataGridViewRow In Me.viewDatos.Rows
                                                Where x.Cells("cDescripcion").Value.ToString.Contains("Servicio") = True
                                                Select x).ToList

                If CDec(row.Cells("cPrecio").Value) > (frm.CantidadDevolver * 500) Then
                    row.Cells("cPrecio").Value = CDec(row.Cells("cPrecio").Value) - (frm.CantidadDevolver * 500)
                    Dim Subtotal As Decimal = CDec(row.Cells("cCantidad").Value) * CDec(row.Cells("cPrecio").Value)
                    Dim Descuento As Decimal = Subtotal * (CDec(row.Cells("cDescuento").Value) / 100)
                    Dim Impuestos As Decimal = (Subtotal - Descuento) * (CDec(row.Cells("cIva").Value) / 100)
                    row.Cells("cTotal").Value = Subtotal - Descuento + Impuestos
                    Exit For
                End If
                
            Next

            Dim eliminadas As Integer = 0
            For Each row As DataGridViewRow In (From x As DataGridViewRow In Me.viewDatos.Rows
                                                Where x.Cells("cDescripcion").Value.ToString.Contains("TELETÓN") = True
                                                Select x).ToList
                If eliminadas < frm.CantidadDevolver Then
                    row.Cells("cMotivo").Value = " El cliente no quiere donar a la Teleton."
                    row.Visible = False
                    eliminadas += 1
                End If
                
            Next

            Me.CalcularTotal()
        End If
    End Sub


End Class