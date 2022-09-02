Imports System.Data
Public Class Albaran

    Private Cod_Cliente As String = ""
    Private Nombre_Cliente As String = ""
    Private SubTotal As Decimal = 0
    Private Descuento As Decimal = 0
    Private Imp_Venta As Decimal = 0
    Private Total As Decimal = 0
    Private Direccion As String = ""
    Private Telefono As String = ""
    Private SubTotalGravado As Decimal = 0
    Private SubTotalExcento As Decimal = 0
    Private TipoCedula As String = ""
    Private Cedula As String = ""
    Private Correo As String = ""
    Private AlbaranDetalle As System.Collections.Generic.List(Of AlbaranDetalle)

    Sub New()
        Me.Cod_Cliente = ""
        Me.Nombre_Cliente = ""
        Me.Direccion = ""
        Me.Telefono = ""
        Me.TipoCedula = ""
        Me.Cedula = ""
        Me.Correo = ""
        Me.AlbaranDetalle = New System.Collections.Generic.List(Of AlbaranDetalle)
    End Sub
    Public Sub Agregar(_IdAlbaran As Long)
        Dim dtEncabezado As New DataTable
        Dim dtDetalle As New DataTable
        'Obtener el encabezado del albaran
        cFunciones.Llenar_Tabla_Generico("Select * From viewAlbaran Where Id = " & _IdAlbaran, dtEncabezado, CadenaConexionSeePOS)
        If dtEncabezado.Rows.Count > 0 Then
            Me.Cod_Cliente = dtEncabezado.Rows(0).Item("Identificacion")
            Me.Nombre_Cliente = dtEncabezado.Rows(0).Item("Cliente")
            Me.Direccion = dtEncabezado.Rows(0).Item("Direccion")
            Me.Telefono = dtEncabezado.Rows(0).Item("Telefono")
            Me.TipoCedula = dtEncabezado.Rows(0).Item("Tipo")
            Me.Cedula = dtEncabezado.Rows(0).Item("Identificacion")
            Me.Correo = dtEncabezado.Rows(0).Item("Correo")

            Me.Cod_Cliente = Me.Cod_Cliente.Replace(" ", "0")
            Me.Cod_Cliente = Me.Cod_Cliente.Replace("-", "")

            Dim parteNumerica As String = ""
            If IsNumeric(Me.Cod_Cliente) = False Then
                For Each c As Char In Me.Cod_Cliente
                    If IsNumeric(c) Then
                        parteNumerica += c
                    End If
                Next

                If parteNumerica <> "" Then
                    Me.Cod_Cliente = parteNumerica
                    Me.Cedula = parteNumerica
                End If
            End If

            'Obtener los detalles del albaran
            cFunciones.Llenar_Tabla_Generico("Select * from viewAlbaranDetalle where Id_Albaran = " & _IdAlbaran, dtDetalle, CadenaConexionSeePOS)
                Dim Detalle As AlbaranDetalle
                For Each row As DataRow In dtDetalle.Rows
                    Detalle = New AlbaranDetalle(row.Item("Id"),
                                             row.Item("Id_Albaran"),
                                             row.Item("Codigo"),
                                             row.Item("CodArticulo"),
                                             row.Item("Descripcion"),
                                             row.Item("Cantidad"),
                                             row.Item("Precio_Costo"),
                                             row.Item("Precio_Base"),
                                             row.Item("Precio_Fletes"),
                                             row.Item("Precio_Otros"),
                                             row.Item("Precio_Unit"),
                                             row.Item("Descuento"),
                                             row.Item("Monto_Descuento"),
                                             row.Item("Impuestos"),
                                             row.Item("Monto_Impuestos"),
                                             row.Item("SubTotalGravado"),
                                             row.Item("SubTotalExcento"),
                                             row.Item("SubTotal"))
                    Me.AlbaranDetalle.Add(Detalle)
                Next

                'Calcular los totales de la venta
                Me.SubTotal = (From x As AlbaranDetalle In Me.AlbaranDetalle Select CDec(x.Subtotal)).Sum
                Me.Descuento = (From x As AlbaranDetalle In Me.AlbaranDetalle Select CDec(x.Monto_Descuento)).Sum
                Me.Imp_Venta = (From x As AlbaranDetalle In Me.AlbaranDetalle Select CDec(x.Monto_Impuestos)).Sum
                Me.SubTotalExcento = (From x As AlbaranDetalle In Me.AlbaranDetalle Select CDec(x.SubTotalExcento)).Sum
                Me.SubTotalGravado = (From x As AlbaranDetalle In Me.AlbaranDetalle Select CDec(x.SubTotalGravado)).Sum
                Me.Total = SubTotal - Descuento + Imp_Venta
            End If
    End Sub

    Private Function ValidarCliente() As Boolean
        Return True

        'antes guardaba el cliente pero no ingresan la info correcta.

        'Dim dt As New DataTable
        'cFunciones.Llenar_Tabla_Generico("select * from Clientes where identificacion = " & Me.Cod_Cliente, dt, CadenaConexionSeePOS)
        'If dt.Rows.Count > 0 Then
        '    'El cliente existe

        '    'podria actualizar? pero por ahora creo que mejor no
        '    Return True
        'Else
        '    'El cliente no existe
        '    Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        '    Try
        '        db.SetParametro("@cedula", Me.Cod_Cliente)
        '        db.SetParametro("@nombre", Me.Nombre_Cliente)
        '        db.SetParametro("@Telefono_01", Me.Telefono)
        '        db.SetParametro("@e_mail", Me.Correo)
        '        db.SetParametro("@direccion", Me.Direccion)
        '        db.SetParametro("@tipo", Me.TipoCedula)
        '        db.Ejecutar("Insertar_Cliente_rapido", CommandType.StoredProcedure)
        '        db.Commit()
        '        Return True
        '    Catch ex As Exception
        '        db.Rollback()
        '        Return False
        '    End Try
        'End If
    End Function

    Public Function GenerarFactura(_IdUsuario As String,
                              _TipoFactura As String,
                              _PlazoCredito As Integer,
                              _NumCaja As Integer,
                              _Cod_Cliente As String,
                              _NombreCliente As String) As Long

        Dim Tipo As String = ""
        Select Case _TipoFactura
            Case "CONTADO" : Tipo = "CON"
            Case "CREDITO" : Tipo = "CRE"
            Case "TIQUETE" : Tipo = "PVE"
            Case Else : Tipo = "PVE"
        End Select


        If _Cod_Cliente = "" Then _Cod_Cliente = Me.Cod_Cliente

        If Me.AlbaranDetalle.Count > 0 Then
            If Me.ValidarCliente() = True Then
                Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)

                Try
                    '**************************************************************************
                    'Crea el encabezado de la factura
                    '**************************************************************************
                    Dim IdFactura As Long = 0
                    db.SetParametro("@Num_Factura", 0)
                    db.SetParametro("@Tipo", Tipo)
                    db.SetParametro("@Nombre_Cliente ", _NombreCliente)
                    db.SetParametro("@Orden", "0")
                    db.SetParametro("@Cedula_Usuario", _IdUsuario)
                    db.SetParametro("@Pago_Comision", 0)
                    db.SetParametro("@SubTotal ", Me.SubTotal)
                    db.SetParametro("@Descuento", Me.Descuento)
                    db.SetParametro("@Imp_Venta ", Me.Imp_Venta)
                    db.SetParametro("@Total", Me.Total)
                    db.SetParametro("@Fecha", Date.Now)
                    db.SetParametro("@Vence", Date.Now.AddDays(_PlazoCredito))
                    db.SetParametro("@Cod_Encargado_Compra", "")
                    db.SetParametro("@Contabilizado", 0)
                    db.SetParametro("@AsientoVenta", 0)
                    db.SetParametro("@ContabilizadoCVenta", 0)
                    db.SetParametro("@AsientoCosto", 0)
                    db.SetParametro("@Anulado", 0)
                    db.SetParametro("@PagoImpuesto", 100)
                    db.SetParametro("@FacturaCancelado", 0)
                    db.SetParametro("@Num_Apertura", 0)
                    db.SetParametro("@Entregado", 0)
                    db.SetParametro("@Cod_Moneda", 1)
                    db.SetParametro("@Moneda_Nombre", "COLON")
                    db.SetParametro("@Direccion", Me.Direccion)
                    db.SetParametro("@Telefono", Me.Telefono)
                    db.SetParametro("@SubTotalGravada", Me.SubTotalGravado)
                    db.SetParametro("@SubTotalExento", Me.SubTotalExcento)
                    db.SetParametro("@Transporte", 0)
                    db.SetParametro("@Tipo_Cambio", 1)
                    db.SetParametro("@Observaciones", "")
                    db.SetParametro("@Exonerar", 0)
                    db.SetParametro("@Taller", 0)
                    db.SetParametro("@Mascotas", 0)
                    db.SetParametro("@Num_Caja", _NumCaja)
                    db.SetParametro("@cod_agente", 0)
                    db.SetParametro("@agente", 0)
                    db.SetParametro("@apartado", 0)
                    db.SetParametro("@Cod_Cliente", _Cod_Cliente)
                    db.SetParametro("@EnviadoMH", 0)
                    db.SetParametro("@TipoCedula", Me.TipoCedula)
                    db.SetParametro("@Cedula", Me.Cedula)
                    IdFactura = db.EjecutarScalar("INSERT INTO [Ventas] ([Num_Factura], [Tipo], [Nombre_Cliente], [Orden], [Cedula_Usuario], [Pago_Comision], [SubTotal], [Descuento], [Imp_Venta], [Total], [Fecha], [Vence], [Cod_Encargado_Compra], [Contabilizado], [AsientoVenta], [ContabilizadoCVenta], [AsientoCosto], [Anulado], [PagoImpuesto], [FacturaCancelado], [Num_Apertura], [Entregado], [Cod_Moneda], [Moneda_Nombre], [Direccion], [Telefono], [SubTotalGravada], [SubTotalExento], [Transporte], [Tipo_Cambio], [Observaciones], [Exonerar], [Taller], [Mascotas], [Num_Caja], [cod_agente], [agente], [apartado], [Cod_Cliente], [EnviadoMH], [TipoCedula], [Cedula]) VALUES (@Num_Factura, @Tipo, @Nombre_Cliente, @Orden, @Cedula_Usuario, @Pago_Comision, @SubTotal, @Descuento, @Imp_Venta, @Total, @Fecha, @Vence, @Cod_Encargado_Compra, @Contabilizado, @AsientoVenta, @ContabilizadoCVenta, @AsientoCosto, @Anulado, @PagoImpuesto, @FacturaCancelado, @Num_Apertura, @Entregado, @Cod_Moneda, @Moneda_Nombre, @Direccion, @Telefono, @SubTotalGravada, @SubTotalExento, @Transporte, @Tipo_Cambio, @Observaciones, @Exonerar, @Taller, @Mascotas, @Num_Caja, @cod_agente, @agente, @apartado, @Cod_Cliente, @EnviadoMH, @TipoCedula, @Cedula); Select SCOPE_IDENTITY();", Data.CommandType.Text)
                    '**************************************************************************
                    'Crea los detalles de la factura
                    '**************************************************************************
                    For Each Detalle As AlbaranDetalle In Me.AlbaranDetalle
                        db.SetParametro("@Id_Factura", IdFactura)
                        db.SetParametro("@Codigo", Detalle.Codigo)
                        db.SetParametro("@Descripcion", Detalle.Descripcion)
                        db.SetParametro("@Cantidad", Detalle.Cantidad)
                        db.SetParametro("@Precio_Costo", Detalle.Precio_Costo)
                        db.SetParametro("@Precio_Base", Detalle.Precio_Base)
                        db.SetParametro("@Precio_Flete", Detalle.Precio_Fletes)
                        db.SetParametro("@Precio_Otros", Detalle.Precio_Otros)
                        db.SetParametro("@Precio_Unit", Detalle.Precio_Unit)
                        db.SetParametro("@Descuento", Detalle.Descuento)
                        db.SetParametro("@Monto_Descuento", Detalle.Monto_Descuento)
                        db.SetParametro("@Impuesto", Detalle.Impuestos)
                        db.SetParametro("@Monto_Impuesto", Detalle.Monto_Impuestos)
                        db.SetParametro("@SubtotalGravado", Detalle.SubTotalGravado)
                        db.SetParametro("@SubTotalExcento", Detalle.SubTotalExcento)
                        db.SetParametro("@SubTotal", Detalle.Subtotal)
                        db.SetParametro("@Devoluciones", 0)
                        db.SetParametro("@Numero_Entrega", 0)
                        db.SetParametro("@Max_Descuento", 0)
                        db.SetParametro("@Tipo_Cambio_ValorCompra", 1)
                        db.SetParametro("@Cod_MonedaVenta", 1)
                        db.SetParametro("@CodArticulo", Detalle.CodArticulo)
                        db.SetParametro("@Lote", 0)
                        db.SetParametro("@CantVet", Detalle.Cantidad)
                        db.SetParametro("@CantBod", 0)
                        db.SetParametro("@empaquetado", 0)
                        db.SetParametro("@nota_pantalla", "")
                        db.SetParametro("@regalias", 0)
                        db.SetParametro("@id_bodega", 0)
                        db.SetParametro("@CostoReal", Detalle.Precio_Costo)
                        db.SetParametro("@IdTipoExoneracion", 1)
                        db.SetParametro("@NumeroDocumento", "")
                        db.SetParametro("@FechaEmision", Date.Now)
                        db.SetParametro("@PorcentajeCompra", 0)
                        db.SetParametro("@IdSerie", 0)
                        db.Ejecutar("INSERT INTO [Ventas_Detalle] ([Id_Factura], [Codigo], [Descripcion], [Cantidad], [Precio_Costo], [Precio_Base], [Precio_Flete], [Precio_Otros], [Precio_Unit], [Descuento], [Monto_Descuento], [Impuesto], [Monto_Impuesto], [SubtotalGravado], [SubTotalExcento], [SubTotal], [Devoluciones], [Numero_Entrega], [Max_Descuento], [Tipo_Cambio_ValorCompra], [Cod_MonedaVenta], [CodArticulo], [Lote], [CantVet], [CantBod], [empaquetado], [nota_pantalla], [regalias], [id_bodega], [CostoReal], [IdTipoExoneracion], [NumeroDocumento], [FechaEmision], [PorcentajeCompra], [IdSerie]) VALUES (@Id_Factura, @Codigo, @Descripcion, @Cantidad, @Precio_Costo, @Precio_Base, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Descuento, @Monto_Descuento, @Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcento, @SubTotal, @Devoluciones, @Numero_Entrega, @Max_Descuento, @Tipo_Cambio_ValorCompra, @Cod_MonedaVenta, @CodArticulo, @Lote, @CantVet, @CantBod, @empaquetado, @nota_pantalla, @regalias, @id_bodega, @CostoReal, @IdTipoExoneracion, @NumeroDocumento, @FechaEmision, @PorcentajeCompra, @IdSerie);", Data.CommandType.Text)
                    Next
                    '**************************************************************************  
                    'Marca los albaranes como facturados
                    'Registra los albaranes facturados en la bitacora
                    '**************************************************************************  
                    For Each IdAlbaran As Long In (From x As AlbaranDetalle In Me.AlbaranDetalle Select CLng(x.Id_Albaran)).Distinct.ToList
                        db.Ejecutar("Update Albaran set Facturado = 1, Id_Factura_suvesa = " & IdFactura & " Where Id = " & IdAlbaran, CommandType.Text)
                        db.Ejecutar("Insert Into Bitacora_Albaran(Id_Albaran, Usuario_Suvesa, Fecha_Hora, Accion, Observaciones) Values(" & IdAlbaran & ", '" & _IdUsuario & "' ,GETDATE(),'Facturacion', '')", CommandType.Text)
                    Next
                    db.Commit()
                    Return IdFactura
                Catch ex As Exception
                    db.Rollback()
                    Return 0
                End Try
            End If
        End If
        Return 0
    End Function

End Class

Public Class AlbaranDetalle
    Property Id As Long
    Property Id_Albaran As Long
    Property Codigo As Long
    Property CodArticulo As String
    Property Descripcion As String
    Property Cantidad As Decimal
    Property Precio_Costo As Decimal
    Property Precio_Base As Decimal
    Property Precio_Fletes As Decimal
    Property Precio_Otros As Decimal
    Property Precio_Unit As Decimal
    Property Descuento As Decimal
    Property Monto_Descuento As Decimal
    Property Impuestos As Decimal
    Property Monto_Impuestos As Decimal
    Property SubTotalGravado As Decimal
    Property SubTotalExcento As Decimal
    Property Subtotal As Decimal

    Sub New(id As Long, id_albaran As Long, codigo As Long, codarticulo As String, descripcion As String, cantidad As Decimal, precio_costo As Decimal, precio_base As Decimal, precio_flete As Decimal, precio_otros As Decimal, precio_unit As Decimal, descuento As Decimal, monto_descuento As Decimal, impuesto As Decimal, monto_impuesto As Decimal, subtotalgravado As Decimal, subtotalexcento As Decimal, subtotal As Decimal)
        Me.Id = id
        Me.Id_Albaran = id_albaran
        Me.Codigo = codigo
        Me.CodArticulo = codarticulo
        Me.Descripcion = descripcion
        Me.Cantidad = cantidad
        Me.Precio_Costo = precio_costo
        Me.Precio_Base = precio_base
        Me.Precio_Fletes = precio_flete
        Me.Precio_Otros = precio_otros
        Me.Precio_Unit = precio_unit
        Me.Descuento = descuento
        Me.Monto_Descuento = monto_descuento
        Me.Impuestos = impuesto
        Me.Monto_Impuestos = monto_impuesto
        Me.SubTotalGravado = subtotalgravado
        Me.SubTotalExcento = subtotalexcento
        Me.Subtotal = subtotal
    End Sub
End Class

