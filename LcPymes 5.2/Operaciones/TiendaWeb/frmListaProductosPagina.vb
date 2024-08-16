Public Class frmListaProductosPagina

    Private Pagina As Integer = 1
    Private TextoTitulo As String = ""

    Private Async Sub Actualizar(r As DataGridViewRow)
        If IsNumeric(r.Cells("Precio").Value) Then
            Dim cls As New TiendaWeb.apiTienda
            Dim IdArticulo As Integer = r.Cells("id").Value
            Dim IdVariacion As Integer = r.Cells("IdVariacion").Value
            Dim PrecioFinal As Decimal = r.Cells("Precio").Value
            Dim Descripcion As String = r.Cells("names").Value

            If r.Cells("type").Value = "simple" Then
                Dim resultado As Boolean = Await cls.UdateProducto(IdArticulo, PrecioFinal)
                If resultado = False Then
                    MsgBox("No se actualizo el producto :"" " & Me.viewDatos.Item("names", Me.viewDatos.CurrentRow.Index).Value & " """)
                End If
            Else
                Dim resultado As Boolean = Await cls.UdateVariacion(IdArticulo, IdVariacion, PrecioFinal)
                If resultado = False Then
                    MsgBox("No se actualizo el producto :"" " & Descripcion & " """)
                End If
            End If
        End If
    End Sub
    Private Async Sub CargarProductos()
        Dim cls As New TiendaWeb.apiTienda
        Dim datos As System.Collections.Generic.List(Of TiendaWeb.Products) = Await cls.AllProductos(Me.Pagina, Me.cboTipo.Text)
        If IsNothing(datos) Then
            Me.viewDatos.Rows.Clear()
        Else
            Me.MostrarDatos(datos)
        End If
    End Sub
    Private Async Sub FiltrarProductos()
        Dim cls As New TiendaWeb.apiTienda
        Dim datos As System.Collections.Generic.List(Of TiendaWeb.Products)
        If Me.rbDescripcion.Checked = True Then
            If Me.txtBuscar.Text <> "" Then
                datos = Await cls.GetProductosDescripcion(Me.txtBuscar.Text)
            End If
        End If
        If Me.rbSku.Checked = True Then
            If Me.txtBuscar.Text <> "" Then
                datos = Await cls.GetProductosSku(Me.txtBuscar.Text)
            End If            
        End If
        If IsNothing(datos) Then
            Me.viewDatos.Rows.Clear()
        Else
            Me.MostrarDatos(datos)
        End If
    End Sub
    Private Async Sub MostrarDatos(Datos As System.Collections.Generic.List(Of TiendaWeb.Products))
        Try
            Dim cls As New TiendaWeb.apiTienda
            Dim Index As Integer = 0
            Me.viewDatos.Rows.Clear()
            Me.lblPagina.Text = Me.Pagina

            Me.viewDatos.Columns("id").Visible = False
            Me.viewDatos.Columns("status").Visible = False
            Me.viewDatos.Columns("names").HeaderText = "Descripcion"
            Me.viewDatos.Columns("type").HeaderText = "Tipo"
            Me.viewDatos.Columns("status").HeaderText = "Estado"
            Me.viewDatos.Columns("sku").HeaderText = "SKU"
            Me.viewDatos.Columns("Costo").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("price").Visible = False
            Me.viewDatos.Columns("Precio").HeaderText = "Precio Final"
            Me.viewDatos.Columns("Precio").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("PrecioUnitario").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("PrecioUnitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("cImpuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("cImpuesto").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Utilidad").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Utilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.Text = Me.TextoTitulo & " (Cargando espere)"

            Me.viewDatos.BackgroundColor = Drawing.Color.Silver

            For Each products As TiendaWeb.Products In Datos

                products.Calcular()

                If products.type = "simple" Then
                    Me.viewDatos.Rows.Add()
                    Me.viewDatos.Item("id", Index).Value = products.id
                    Me.viewDatos.Item("names", Index).Value = products.name
                    Me.viewDatos.Item("type", Index).Value = products.type
                    Me.viewDatos.Item("status", Index).Value = products.status
                    Me.viewDatos.Item("Costo", Index).Value = products.Costo
                    Me.viewDatos.Item("sku", Index).Value = products.sku
                    Me.viewDatos.Item("Price", Index).Value = products.price
                    Me.viewDatos.Item("PrecioUnitario", Index).Value = products.PrecioUnit
                    Me.viewDatos.Item("cImpuesto", Index).Value = products.Impuesto
                    Me.viewDatos.Item("Utilidad", Index).Value = products.Utilidad
                    Me.viewDatos.Item("Precio", Index).Value = products.Precio
                    Me.viewDatos.Item("IdVariacion", Index).Value = 0
                    Me.viewDatos.Item("cActualizar", Index).Value = 0
                    Me.viewDatos.Item("cCodigo", Index).Value = products.Codigo
                    Index += 1
                Else
                    For Each idVariation As String In products.variations
                        Dim variation As TiendaWeb.Variacion = Await cls.GetVariacion(products.id, idVariation)
                        variation.Calcular()
                        Me.viewDatos.Rows.Add()
                        Me.viewDatos.Item("id", Index).Value = products.id
                        Me.viewDatos.Item("names", Index).Value = products.name & " " & variation.name
                        Me.viewDatos.Item("type", Index).Value = products.type
                        Me.viewDatos.Item("status", Index).Value = variation.status
                        Me.viewDatos.Item("Costo", Index).Value = variation.Costo
                        Me.viewDatos.Item("sku", Index).Value = variation.sku
                        Me.viewDatos.Item("Price", Index).Value = variation.price
                        Me.viewDatos.Item("PrecioUnitario", Index).Value = variation.PrecioUnit
                        Me.viewDatos.Item("cImpuesto", Index).Value = variation.Impuesto
                        Me.viewDatos.Item("Utilidad", Index).Value = variation.Utilidad
                        Me.viewDatos.Item("Precio", Index).Value = variation.Precio
                        Me.viewDatos.Item("IdVariacion", Index).Value = variation.id
                        Me.viewDatos.Item("cActualizar", Index).Value = 0
                        Me.viewDatos.Item("cCodigo", Index).Value = variation.Codigo
                        Index += 1
                    Next
                End If
            Next

            Me.Text = Me.TextoTitulo
            Me.viewDatos.BackgroundColor = Drawing.Color.White
        Catch ex As Exception
            Me.Text = Me.TextoTitulo
            Me.viewDatos.BackgroundColor = Drawing.Color.White
        End Try
    End Sub

    Private Sub CambiarUtilidad()
        Dim NUtilidad As String = InputBox("Digite el monto de utilidad deseada", "Utilidad")
        If IsNumeric(NUtilidad) Then
            Dim Utilidad As Decimal = CDec(NUtilidad)
            For Each row As DataGridViewRow In Me.viewDatos.Rows
                If CDec(row.Cells("Costo").Value) > 0 Then
                    row.Cells("PrecioUnitario").Value = CDec(row.Cells("Costo").Value) * (1 + (Utilidad / 100))
                    row.Cells("Utilidad").Value = Utilidad
                    row.Cells("Precio").Value = CDec(row.Cells("PrecioUnitario").Value) * (1 + (CDec(row.Cells("cImpuesto").Value) / 100))                    
                End If
            Next
        End If
    End Sub

    Private Sub frmListaProductosPagina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextoTitulo = Me.Text
        Me.cboTipo.SelectedIndex = 0
        Me.CargarProductos()
    End Sub

    Private Sub btnAntes_Click(sender As Object, e As EventArgs) Handles btnAntes.Click
        If Pagina > 1 Then
            Pagina -= 1
            Me.CargarProductos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Pagina += 1
        Me.CargarProductos()

    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtBuscar.Text <> "" Then
            Me.Pagina = 1
            Me.FiltrarProductos()
        End If
        If e.KeyCode = Keys.Enter And Me.txtBuscar.Text = "" Then
            Me.Pagina = 1
            Me.CargarProductos()
        End If
    End Sub

    Private Sub rbDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescripcion.CheckedChanged, rbSku.CheckedChanged
        Me.txtBuscar.Focus()
    End Sub

    Private Sub cboTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Pagina = 1
            Me.CargarProductos()
        End If
    End Sub

    Private Sub btnCambiarUtilidad_Click(sender As Object, e As EventArgs) Handles btnCambiarUtilidad.Click
        Me.CambiarUtilidad()
    End Sub

    Private Sub lblPagina_DoubleClick(sender As Object, e As EventArgs) Handles lblPagina.DoubleClick
        If MsgBox("Desea abrir la configuracion de conexion.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar accion") = MsgBoxResult.Yes Then
            Dim frm As New frmSetting
            frm.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In Me.viewDatos.Rows
            Actualizar(row)
        Next
        MsgBox("Listo", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub viewDatos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEndEdit
        Dim precio As String = Me.viewDatos.Item(e.ColumnIndex, e.RowIndex).Value

        If IsNumeric(precio) Then

            If CDec(Me.viewDatos.Item("Costo", e.RowIndex).Value) > 0 Then

                Dim Costo As Decimal = Me.viewDatos.Item("Costo", e.RowIndex).Value
                Dim PrecioFinal As Decimal = CDec(precio)
                Dim Impuesto As Decimal = Me.viewDatos.Item("cImpuesto", e.RowIndex).Value
                Dim PrecioUnit As Decimal = PrecioFinal / (1 + (Impuesto / 100))
                Dim Utilidad As Decimal = ((PrecioUnit / Costo) - 1) * 100

                Me.viewDatos.Item("Utilidad", e.RowIndex).Value = Utilidad

            End If

        Else
            MsgBox("Debe ingresar un valor numerico.", MsgBoxStyle.Exclamation, Me.Text)
            Me.viewDatos.Item(e.ColumnIndex, e.RowIndex).Value = 0
        End If

    End Sub

    Public usua As Usuario_Logeado

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            Dim codigo As String = Me.viewDatos.Item("cCodigo", Me.viewDatos.CurrentRow.Index).Value
            If IsNumeric(codigo) Then
                If CDec(codigo) > 0 Then
                    Dim frm As New FrmInventario(Me.usua)
                    frm.cCodigoTienda = codigo
                    frm.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class