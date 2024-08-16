Imports System.Data
Public Class PedidoWeb

    Public Cod_Cliente As String = ""
    Public Nombre_Cliente As String = ""
    Public SubTotal As Decimal = 0
    Public Descuento As Decimal = 0
    Public Imp_Venta As Decimal = 0
    Public Total As Decimal = 0
    Public Direccion As String = ""
    Public Telefono As String = ""
    Public SubTotalGravado As Decimal = 0
    Public SubTotalExcento As Decimal = 0
    Public TipoCedula As String = ""
    Public Cedula As String = ""
    Public Correo As String = ""
    Public Mascota As String = ""
    Public DetalleClinica As System.Collections.Generic.List(Of DetallePedidoWeb)
    Public DetalleAgro As System.Collections.Generic.List(Of DetallePedidoWeb)

    Sub New()
        Me.Cod_Cliente = ""
        Me.Nombre_Cliente = ""
        Me.Direccion = ""
        Me.Telefono = ""
        Me.TipoCedula = ""
        Me.Cedula = ""
        Me.Correo = ""
        Me.Mascota = ""
        Me.DetalleClinica = New System.Collections.Generic.List(Of DetallePedidoWeb)
        Me.DetalleAgro = New System.Collections.Generic.List(Of DetallePedidoWeb)
    End Sub

    Private Function ValidarCliente() As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from Clientes where identificacion = " & Me.Cod_Cliente & " or Cedula = '" & Me.Cod_Cliente & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            'El cliente existe
            Return True
        Else
            'El cliente no existe
            Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            Try
                db.SetParametro("@cedula", Me.Cod_Cliente)
                db.SetParametro("@nombre", Me.Nombre_Cliente)
                db.SetParametro("@Telefono_01", "")
                db.SetParametro("@e_mail", "")
                db.SetParametro("@direccion", Me.Direccion)
                db.SetParametro("@tipo", "FISICA")
                db.Ejecutar("Insertar_Cliente_rapido", CommandType.StoredProcedure)
                db.Commit()
            Catch ex As Exception
                db.Rollback()
            End Try
        End If

        Return True 'Simpre debe continuar
    End Function

    Private Function AplicaCambioenCaja() As Boolean
        Dim dt As New DataTable
        Dim Modocaja As Boolean = False
        cFunciones.Llenar_Tabla_Generico("Select ModoCaja from Configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Modocaja = dt.Rows(0).Item("ModoCaja")
        End If
        Return Modocaja
    End Function

    Private Function EstaLibre(_Ficha As String, _IdUsuario As String) As Boolean
        Dim dt As New DataTable
        Dim IdUsuario As String = _IdUsuario
        Dim Ficha As String = _Ficha
        cFunciones.Llenar_Tabla_Generico("select COUNT(*) FichaValida from fichasxusuario where idusuario = " & IdUsuario & " and " & Ficha & " between desde and hasta and " & Ficha & " not in(select Ficha from viewPreventasActivas)", dt, CadenaConexionSeePOS)
        If dt.Rows(0).Item("FichaValida") = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GetFicha(_IdUsuario As String) As String
        Dim dt As New DataTable
        Dim Fichas As New Collections.Generic.List(Of Integer)
        Dim Desde As Integer = 0
        Dim Hasta As Integer = 0
        Dim Ficha As String = ""
        cFunciones.Llenar_Tabla_Generico("select * from fichasxusuario where idusuario = " & _IdUsuario, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Ficha = ""
            Desde = dt.Rows(0).Item("Desde")
            Hasta = dt.Rows(0).Item("Hasta")
            For i As Integer = Desde To Hasta
                Fichas.Add(i)
            Next

            For Each f As Integer In Fichas
                If EstaLibre(f, _IdUsuario) = True Then
                    Ficha = f
                    Exit For
                End If
            Next

            If Ficha = "" Then
                MsgBox("No se encontraron fichas validas.", MsgBoxStyle.Exclamation, "Favor consultar con el encargado.")
            End If

        End If
        Return Ficha
    End Function

    Public Function GenerarFacturaClinica(_IdUsuario As String,
                              _TipoFactura As String,
                              _PlazoCredito As Integer,
                              _NumCaja As Integer,
                              _Cod_Cliente As String,
                              _NombreCliente As String,
                              _CodAgente As Integer) As Long

        Dim Tipo As String = ""
        Select Case _TipoFactura
            Case "CONTADO" : Tipo = "CON"
            Case "CREDITO" : Tipo = "CRE"
            Case "TIQUETE" : Tipo = "PVE"
            Case Else : Tipo = "PVE"
        End Select

        Dim Ficha As String = GetFicha(_IdUsuario)
        _NombreCliente = _NombreCliente.ToUpper
        SubTotal = (From x As DetallePedidoWeb In Me.DetalleClinica Select x.Subtotal).Sum
        Descuento = (From x As DetallePedidoWeb In Me.DetalleClinica Select x.Monto_Descuento).Sum
        Imp_Venta = (From x As DetallePedidoWeb In Me.DetalleClinica Select x.Monto_Impuestos).Sum
        SubTotalExcento = (From x As DetallePedidoWeb In Me.DetalleClinica Select x.SubTotalExcento).Sum
        SubTotalGravado = (From x As DetallePedidoWeb In Me.DetalleClinica Select x.SubTotalGravado).Sum
        Total = SubTotal - Descuento + Imp_Venta

        'If Me.AplicaCambioenCaja = True Then
        '    TablaEncabezado = "PreVentas"
        '    TablaDetalle = "PreVentas_Detalle"
        '    Ficha = GetFicha(_IdUsuario)
        'Else
        '    TablaEncabezado = "Ventas"
        '    TablaDetalle = "Ventas_Detalle"
        '    Ficha = ""
        'End If

        'If Tipo = "CRE" And Me.AplicaCambioenCaja = True Then
        '    TablaEncabezado = "Ventas"
        '    TablaDetalle = "Ventas_Detalle"
        '    Ficha = ""
        'End If

        If _Cod_Cliente = "" Then _Cod_Cliente = Me.Cod_Cliente

        If Me.DetalleClinica.Count > 0 Then
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
                db.SetParametro("@cod_agente", _CodAgente)
                If _CodAgente > 0 Then
                    db.SetParametro("@agente", True)
                Else
                    db.SetParametro("@agente", False)
                End If
                db.SetParametro("@apartado", 0)
                db.SetParametro("@Cod_Cliente", _Cod_Cliente)
                db.SetParametro("@EnviadoMH", 0)
                db.SetParametro("@TipoCedula", Me.TipoCedula)
                db.SetParametro("@Cedula", Me.Cedula)
                IdFactura = db.EjecutarScalar("INSERT INTO clinica.dbo.PreVentas ([Num_Factura], [Tipo], [Nombre_Cliente], [Orden], [Cedula_Usuario], [Pago_Comision], [SubTotal], [Descuento], [Imp_Venta], [Total], [Fecha], [Vence], [Cod_Encargado_Compra], [Contabilizado], [AsientoVenta], [ContabilizadoCVenta], [AsientoCosto], [Anulado], [PagoImpuesto], [FacturaCancelado], [Num_Apertura], [Entregado], [Cod_Moneda], [Moneda_Nombre], [Direccion], [Telefono], [SubTotalGravada], [SubTotalExento], [Transporte], [Tipo_Cambio], [Observaciones], [Exonerar], [Taller], [Mascotas], [Num_Caja], [cod_agente], [agente], [apartado], [Cod_Cliente], [EnviadoMH], [TipoCedula], [Cedula]) VALUES (@Num_Factura, @Tipo, @Nombre_Cliente, @Orden, @Cedula_Usuario, @Pago_Comision, @SubTotal, @Descuento, @Imp_Venta, @Total, @Fecha, @Vence, @Cod_Encargado_Compra, @Contabilizado, @AsientoVenta, @ContabilizadoCVenta, @AsientoCosto, @Anulado, @PagoImpuesto, @FacturaCancelado, @Num_Apertura, @Entregado, @Cod_Moneda, @Moneda_Nombre, @Direccion, @Telefono, @SubTotalGravada, @SubTotalExento, @Transporte, @Tipo_Cambio, @Observaciones, @Exonerar, @Taller, @Mascotas, @Num_Caja, @cod_agente, @agente, @apartado, @Cod_Cliente, @EnviadoMH, @TipoCedula, @Cedula); Select SCOPE_IDENTITY();", Data.CommandType.Text)

                If IsNumeric(Ficha) Then
                    If CInt(Ficha) > 0 Then
                        db.Ejecutar("Update clinica.dbo.PreVentas Set Ficha = " & Ficha & " where Id = " & IdFactura, CommandType.Text)
                    End If
                End If

                '**************************************************************************
                'Crea los detalles de la factura
                '**************************************************************************
                For Each Detalle As DetallePedidoWeb In Me.DetalleClinica
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
                    db.SetParametro("@Descargar", Detalle.Descargar)
                    db.SetParametro("@ResponsableVenta", Detalle.Responsable)
                    db.SetParametro("@Propetario", Detalle.Propetario)
                    db.SetParametro("@Mascota", Detalle.Mascota)
                    db.Ejecutar("INSERT INTO clinica.dbo.PreVentas_Detalle([Id_Factura], [Codigo], [Descripcion], [Cantidad], [Precio_Costo], [Precio_Base], [Precio_Flete], [Precio_Otros], [Precio_Unit], [Descuento], [Monto_Descuento], [Impuesto], [Monto_Impuesto], [SubtotalGravado], [SubTotalExcento], [SubTotal], [Devoluciones], [Numero_Entrega], [Max_Descuento], [Tipo_Cambio_ValorCompra], [Cod_MonedaVenta], [CodArticulo], [Lote], [CantVet], [CantBod], [empaquetado], [nota_pantalla], [regalias], [id_bodega], [CostoReal], [IdTipoExoneracion], [NumeroDocumento], [FechaEmision], [PorcentajeCompra], [IdSerie], Descargar, ResponsableVenta, Propetario, Mascota) VALUES (@Id_Factura, @Codigo, @Descripcion, @Cantidad, @Precio_Costo, @Precio_Base, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Descuento, @Monto_Descuento, @Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcento, @SubTotal, @Devoluciones, @Numero_Entrega, @Max_Descuento, @Tipo_Cambio_ValorCompra, @Cod_MonedaVenta, @CodArticulo, @Lote, @CantVet, @CantBod, @empaquetado, @nota_pantalla, @regalias, @id_bodega, @CostoReal, @IdTipoExoneracion, @NumeroDocumento, @FechaEmision, @PorcentajeCompra, @IdSerie, @Descargar, @ResponsableVenta, @Propetario, @Mascota);", Data.CommandType.Text)
                Next

                db.Commit()
                Return IdFactura
            Catch ex As Exception
                db.Rollback()
                MsgBox(ex.Message)
                Return 0
            End Try

        End If
        Return 0
    End Function
    Public Function GenerarFacturaAgro(_IdUsuario As String,
                              _TipoFactura As String,
                              _PlazoCredito As Integer,
                              _NumCaja As Integer,
                              _Cod_Cliente As String,
                              _NombreCliente As String,
                              _CodAgente As Integer) As Long

        Dim Tipo As String = ""
        Select Case _TipoFactura
            Case "CONTADO" : Tipo = "CON"
            Case "CREDITO" : Tipo = "CRE"
            Case "TIQUETE" : Tipo = "PVE"
            Case Else : Tipo = "PVE"
        End Select

        Dim Ficha As String = GetFicha(_IdUsuario)
        _NombreCliente = _NombreCliente.ToUpper
        SubTotal = (From x As DetallePedidoWeb In Me.DetalleAgro Select x.Subtotal).Sum
        Descuento = (From x As DetallePedidoWeb In Me.DetalleAgro Select x.Monto_Descuento).Sum
        Imp_Venta = (From x As DetallePedidoWeb In Me.DetalleAgro Select x.Monto_Impuestos).Sum
        SubTotalExcento = (From x As DetallePedidoWeb In Me.DetalleAgro Select x.SubTotalExcento).Sum
        SubTotalGravado = (From x As DetallePedidoWeb In Me.DetalleAgro Select x.SubTotalGravado).Sum
        Total = SubTotal - Descuento + Imp_Venta

        If _Cod_Cliente = "" Then _Cod_Cliente = Me.Cod_Cliente

        If Me.DetalleAgro.Count > 0 Then
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
                db.SetParametro("@cod_agente", _CodAgente)
                If _CodAgente > 0 Then
                    db.SetParametro("@agente", True)
                Else
                    db.SetParametro("@agente", False)
                End If
                db.SetParametro("@apartado", 0)
                db.SetParametro("@Cod_Cliente", _Cod_Cliente)
                db.SetParametro("@EnviadoMH", 0)
                db.SetParametro("@TipoCedula", Me.TipoCedula)
                db.SetParametro("@Cedula", Me.Cedula)
                IdFactura = db.EjecutarScalar("INSERT INTO seepos.dbo.PreVentas ([Num_Factura], [Tipo], [Nombre_Cliente], [Orden], [Cedula_Usuario], [Pago_Comision], [SubTotal], [Descuento], [Imp_Venta], [Total], [Fecha], [Vence], [Cod_Encargado_Compra], [Contabilizado], [AsientoVenta], [ContabilizadoCVenta], [AsientoCosto], [Anulado], [PagoImpuesto], [FacturaCancelado], [Num_Apertura], [Entregado], [Cod_Moneda], [Moneda_Nombre], [Direccion], [Telefono], [SubTotalGravada], [SubTotalExento], [Transporte], [Tipo_Cambio], [Observaciones], [Exonerar], [Taller], [Mascotas], [Num_Caja], [cod_agente], [agente], [apartado], [Cod_Cliente], [EnviadoMH], [TipoCedula], [Cedula]) VALUES (@Num_Factura, @Tipo, @Nombre_Cliente, @Orden, @Cedula_Usuario, @Pago_Comision, @SubTotal, @Descuento, @Imp_Venta, @Total, @Fecha, @Vence, @Cod_Encargado_Compra, @Contabilizado, @AsientoVenta, @ContabilizadoCVenta, @AsientoCosto, @Anulado, @PagoImpuesto, @FacturaCancelado, @Num_Apertura, @Entregado, @Cod_Moneda, @Moneda_Nombre, @Direccion, @Telefono, @SubTotalGravada, @SubTotalExento, @Transporte, @Tipo_Cambio, @Observaciones, @Exonerar, @Taller, @Mascotas, @Num_Caja, @cod_agente, @agente, @apartado, @Cod_Cliente, @EnviadoMH, @TipoCedula, @Cedula); Select SCOPE_IDENTITY();", Data.CommandType.Text)

                If IsNumeric(Ficha) Then
                    If CInt(Ficha) > 0 Then
                        db.Ejecutar("Update seepos.dbo.PreVentas Set Ficha = " & Ficha & " where Id = " & IdFactura, CommandType.Text)
                    End If
                End If

                '**************************************************************************
                'Crea los detalles de la factura
                '**************************************************************************
                For Each Detalle As DetallePedidoWeb In Me.DetalleAgro
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
                    db.SetParametro("@Descargar", Detalle.Descargar)
                    db.SetParametro("@ResponsableVenta", Detalle.Responsable)
                    db.SetParametro("@Propetario", Detalle.Propetario)
                    db.SetParametro("@Mascota", Detalle.Mascota)
                    db.Ejecutar("INSERT INTO seepos.dbo.PreVentas_Detalle([Id_Factura], [Codigo], [Descripcion], [Cantidad], [Precio_Costo], [Precio_Base], [Precio_Flete], [Precio_Otros], [Precio_Unit], [Descuento], [Monto_Descuento], [Impuesto], [Monto_Impuesto], [SubtotalGravado], [SubTotalExcento], [SubTotal], [Devoluciones], [Numero_Entrega], [Max_Descuento], [Tipo_Cambio_ValorCompra], [Cod_MonedaVenta], [CodArticulo], [Lote], [CantVet], [CantBod], [empaquetado], [nota_pantalla], [regalias], [id_bodega], [CostoReal], [IdTipoExoneracion], [NumeroDocumento], [FechaEmision], [PorcentajeCompra], [IdSerie], Descargar, ResponsableVenta, Propetario, Mascota) VALUES (@Id_Factura, @Codigo, @Descripcion, @Cantidad, @Precio_Costo, @Precio_Base, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Descuento, @Monto_Descuento, @Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcento, @SubTotal, @Devoluciones, @Numero_Entrega, @Max_Descuento, @Tipo_Cambio_ValorCompra, @Cod_MonedaVenta, @CodArticulo, @Lote, @CantVet, @CantBod, @empaquetado, @nota_pantalla, @regalias, @id_bodega, @CostoReal, @IdTipoExoneracion, @NumeroDocumento, @FechaEmision, @PorcentajeCompra, @IdSerie, @Descargar, @ResponsableVenta, @Propetario, @Mascota);", Data.CommandType.Text)
                Next

                db.Commit()
                Return IdFactura
            Catch ex As Exception
                db.Rollback()
                MsgBox(ex.Message)
                Return 0
            End Try

        End If
        Return 0
    End Function

    
End Class

Public Class DetallePedidoWeb
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
    Property Descargar As Decimal
    Property Responsable As String
    Property Propetario As String
    Property Mascota As String

    Sub New()
        Me.Id = 0
        Me.Id_Albaran = 0
        Me.Codigo = 0
        Me.CodArticulo = ""
        Me.Descripcion = ""
        Me.Cantidad = 0
        Me.Precio_Costo = 0
        Me.Precio_Base = 0
        Me.Precio_Fletes = 0
        Me.Precio_Otros = 0
        Me.Precio_Unit = 0
        Me.Descuento = 0
        Me.Monto_Descuento = 0
        Me.Impuestos = 0
        Me.Monto_Impuestos = 0
        Me.SubTotalGravado = 0
        Me.SubTotalExcento = 0
        Me.Subtotal = 0
        Me.Descargar = 0
        Me.Responsable = ""
        Me.Propetario = ""
        Me.Mascota = ""
    End Sub

    Sub New(id As Long, id_albaran As Long, codigo As Long, codarticulo As String, descripcion As String, cantidad As Decimal, precio_costo As Decimal, precio_base As Decimal, precio_flete As Decimal, precio_otros As Decimal, precio_unit As Decimal, descuento As Decimal, monto_descuento As Decimal, impuesto As Decimal, monto_impuesto As Decimal, subtotalgravado As Decimal, subtotalexcento As Decimal, subtotal As Decimal, descargar As Boolean, responsable As String, propetario As String, mascota As String)
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
        Me.Descargar = descargar
        Me.Responsable = responsable
        Me.Propetario = propetario
        Me.Mascota = mascota
    End Sub

End Class

