Public Class frmPedidoWeb

    Public Id As Integer = 0
    Public SoloLectura As Boolean = False
    Public Preventa As New PedidoWeb


    Private Async Sub Actualizar()
        Dim cls As New TiendaWeb.apiTienda
        Dim resultado As Boolean = Await cls.UdatePedido(Me.Id, Me.cboEstado.Text)
        If resultado = False Then
            MsgBox("No se pudo actualizar ", MsgBoxStyle.Critical, Me.Text)
        Else
            MsgBox("Listo ", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Async Sub CargarPedido()
        Try
            Dim cls As New TiendaWeb.apiTienda
            Dim Pedido As TiendaWeb.Pedidos = Await cls.GetPedido(Me.Id)

            If IsNothing(Pedido) Then
                Me.Close()
            Else
                'Factura
                Me.txtNombreFactura.Text = Pedido.billing.first_name
                Me.txtApellidoFactura.Text = Pedido.billing.last_name
                Me.txtCiudadFactura.Text = Pedido.billing.city
                Me.txtCorreoFactura.Text = Pedido.billing.email
                Me.txtDireccionEnvio.Text = Pedido.billing.address_1

                Me.Preventa.Cod_Cliente = "0"
                Me.Preventa.Nombre_Cliente = Pedido.billing.first_name & " " & Pedido.billing.last_name
                Me.Preventa.Cedula = "0"
                Me.Preventa.Direccion = Pedido.billing.address_1
                Me.Preventa.Telefono = Pedido.billing.phone
                Me.Preventa.TipoCedula = "FISICA"
                Me.Preventa.Correo = Pedido.billing.email
                Me.Preventa.Mascota = ""

                Me.Preventa.SubTotal = 0
                Me.Preventa.Descuento = 0
                Me.Preventa.Imp_Venta = 0
                Me.Preventa.Total = 0
                Me.Preventa.SubTotalGravado = 0
                Me.Preventa.SubTotalExcento = 0


                'Envio
                Me.txtNombreEnvio.Text = Pedido.shipping.first_name
                Me.txtApellidoEnvio.Text = Pedido.shipping.last_name
                Me.txtCiudadEnvio.Text = Pedido.shipping.city
                Me.txtTelefonoEnvio.Text = Pedido.shipping.phone
                Me.txtDireccionEnvio.Text = Pedido.shipping.address_1

                Me.cboEstado.Text = Pedido.status

                Dim Index As Integer = 0
                Me.viewDatos.Rows.Clear()
                Dim Product As New TiendaWeb.Products
                Dim Variation As New TiendaWeb.Variacion
                For Each r As TiendaWeb.LineItem In Pedido.line_items

                    Me.viewDatos.Rows.Add()
                    Me.viewDatos.Item("cid", Index).Value = r.id
                    Me.viewDatos.Item("cvariation_id", Index).Value = r.variation_id
                    Me.viewDatos.Item("cname", Index).Value = r.name
                    Me.viewDatos.Item("cquantity", Index).Value = CDec(r.quantity)
                    Me.viewDatos.Item("csubtotal", Index).Value = 0
                    Me.viewDatos.Item("csubtotal_tax", Index).Value = 0
                    Me.viewDatos.Item("ctotal", Index).Value = CDec(r.subtotal) + CDec(r.total_tax)


                    If r.variation_id = 0 Then
                        Product = Await cls.GetProducto(r.product_id)
                        Product.Calcular()

                        Me.viewDatos.Item("cPV", Index).Value = IIf(Product.BaseDatos = "clinica", "Clinica", "Agro")

                        Dim p As New DetallePedidoWeb
                        Dim PrecioIVA As Decimal = (CDec(r.subtotal) + CDec(r.subtotal_tax)) / r.quantity
                        p.Id = r.id
                        p.Id_Albaran = 0
                        p.Codigo = Product.Codigo
                        p.CodArticulo = Product.sku
                        p.Descripcion = r.name.ToUpper
                        p.Cantidad = r.quantity
                        p.Precio_Costo = Product.Costo
                        p.Precio_Base = Product.Costo
                        p.Impuestos = Product.Impuesto
                        p.Precio_Fletes = 0
                        p.Precio_Otros = 0
                        p.Descuento = 0
                        p.Monto_Descuento = 0
                        p.Precio_Unit = PrecioIVA / (1 + (p.Impuestos / 100))
                        p.Subtotal = p.Cantidad * p.Precio_Unit

                        If p.Impuestos > 0 Then
                            p.Monto_Impuestos = p.Subtotal * (p.Impuestos / 100)
                            p.SubTotalGravado = p.Subtotal
                            p.SubTotalExcento = 0
                        Else
                            p.Monto_Impuestos = 0
                            p.SubTotalGravado = 0
                            p.SubTotalExcento = p.Subtotal
                        End If

                        p.Descargar = 1
                        p.Responsable = ""
                        p.Propetario = ""
                        p.Mascota = ""

                        If Product.BaseDatos = "seepos" Then
                            Preventa.DetalleAgro.Add(p)
                        Else
                            Preventa.DetalleClinica.Add(p)
                        End If


                    Else
                        Variation = Await cls.GetVariacion(r.product_id, r.variation_id)
                        Variation.Calcular()

                        Me.viewDatos.Item("cPV", Index).Value = IIf(Variation.BaseDatos = "clinica", "Clinica", "Agro")

                        Dim p As New DetallePedidoWeb
                        Dim PrecioIVA As Decimal = (CDec(r.subtotal) + CDec(r.subtotal_tax)) / r.quantity
                        p.Id = r.id
                        p.Id_Albaran = 0
                        p.Codigo = Variation.Codigo
                        p.CodArticulo = Variation.sku
                        p.Descripcion = r.name.ToUpper
                        p.Cantidad = r.quantity
                        p.Precio_Costo = Variation.Costo
                        p.Precio_Base = Variation.Costo
                        p.Impuestos = Variation.Impuesto
                        p.Precio_Fletes = 0
                        p.Precio_Otros = 0
                        p.Descuento = 0
                        p.Monto_Descuento = 0
                        p.Precio_Unit = PrecioIVA / (1 + (p.Impuestos / 100))
                        p.Subtotal = p.Cantidad * p.Precio_Unit

                        If p.Impuestos > 0 Then
                            p.SubTotalGravado = p.Subtotal
                            p.SubTotalExcento = 0
                            p.Monto_Impuestos = p.Subtotal * (p.Impuestos / 100)
                        Else
                            p.SubTotalGravado = 0
                            p.SubTotalExcento = p.Subtotal
                            p.Monto_Impuestos = 0
                        End If

                        p.Descargar = 1
                        p.Responsable = ""
                        p.Propetario = ""
                        p.Mascota = ""

                        If Variation.BaseDatos = "seepos" Then
                            Preventa.DetalleAgro.Add(p)
                        Else
                            Preventa.DetalleClinica.Add(p)
                        End If

                    End If

                    Index += 1

                Next

                If Pedido.shipping_lines.Count > 0 Then
                    Me.lblEnvio.Text = Pedido.shipping_lines(0).method_title
                End If

                Me.lblNotas.Text = Pedido.customer_note

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmPedidoWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarPedido()
        If Me.SoloLectura = True Then
            Me.cboEstado.Enabled = False
            Me.btnActualizar.Enabled = False
        Else
            Me.cboEstado.Enabled = True
            Me.btnActualizar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.SoloLectura = False Then
            Me.Actualizar()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmGenerarFichaPedidoWeb
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each r As DetallePedidoWeb In Me.Preventa.DetalleClinica
                r.Responsable = frm.txtNombreUsuario.Text
            Next

            For Each r As DetallePedidoWeb In Me.Preventa.DetalleAgro
                r.Responsable = frm.txtNombreUsuario.Text
            Next

            Dim Resultado As Boolean = True
            If Me.Preventa.DetalleClinica.Count > 0 Then

                Dim id As Long = Me.Preventa.GenerarFacturaClinica(frm.IdUsuario, "PVE", 0, frm.cboNumeroCaja.Text, "0", Me.txtNombreFactura.Text & " " & Me.txtApellidoFactura.Text, 13)
                If id > 0 Then

                Else
                    MsgBox("No se puedo registrar la preventa en Clinica", MsgBoxStyle.Critical, Me.Text)
                    Resultado = False
                End If

            End If

            If Me.Preventa.DetalleAgro.Count > 0 Then

                Dim id As Long = Me.Preventa.GenerarFacturaAgro(frm.IdUsuario, "PVE", 0, frm.cboNumeroCaja.Text, "0", Me.txtNombreFactura.Text & " " & Me.txtApellidoFactura.Text, 13)
                If id > 0 Then

                Else
                    MsgBox("No se puedo registrar la preventa en Agro", MsgBoxStyle.Critical, Me.Text)
                    Resultado = False
                End If

            End If

            If Resultado = True Then
                MsgBox("Preventa generada correctamente. ", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            Else
                MsgBox("No se puedo registrar la preventa", MsgBoxStyle.Critical, Me.Text)
            End If

        End If
    End Sub

End Class
