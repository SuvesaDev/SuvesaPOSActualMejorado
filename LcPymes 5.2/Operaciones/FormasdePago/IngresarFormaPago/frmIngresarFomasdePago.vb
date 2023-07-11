Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmIngresarFomasdePago

    Public Id_Factura As Long = 0
    Public Num_Factura As Long = 0
    Public Id_PreVenta As Long
    Public Id_Apartado As Long
    Public Id_AbonoApartado As Long
    Public ReciboAbono As Long
    Public Id_Adelanto As Long
    Public PuntodeVenta As String = ""
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0
    Public TipoFactura As String = ""
    Public SoloCobrar As Boolean = False
    Public EsAbono As Boolean = False
    Public EsAdelanto As Boolean = False
    Public FechaAbono As Date
    Public MontoAbono As Decimal
    Public IdFacturaAbono As Long
    Public EsApartado As Boolean = False
    Public FechaVence As Date
    Public MontoApartado As Decimal
    Public TotalCobro As Decimal = 0
    Private MontoPagado As Decimal = 0
    Public esReciboDinero As Boolean = False
    Public IdRecibo As Long
    Public NumRecibo As Long
    Public IgnoraTodo As Boolean = False
    Public NoVuelto As Boolean = False
    Public PasaVuelto As Decimal = 0

    Public esSoloAbonoApartado As Boolean = False
    Public MontoAbonoApartado As Decimal

    Private index As Integer = 0
    Private Vuelto As Decimal = 0

    Private Function GetApertura() As Integer
        Dim NApertura As Integer = 0
        Dim dt As New DataTable
        If cFunciones.Llenar_Tabla_Generico("select NApertura from aperturacaja where Estado = 'A' and Cedula = '" & Me.Id_Usuario & "'", dt, CadenaConexionSeePOS) = Nothing Then
            Return NApertura
        Else
            If dt.Rows.Count > 0 Then
                NApertura = dt.Rows(0).Item("NApertura")
            End If
            Return NApertura
        End If
    End Function
    Private Sub Agregar_Forma_Pago(ByVal _MontoPago As Decimal, _FormaPago As String, _CodMoneda As Integer, _NumeroDocumento As String)
        Try

            Dim Monto As Decimal = _MontoPago

            If _CodMoneda = 1 Then
                If (Me.MontoPagado + _MontoPago) > Me.TotalCobro Then
                    If Me.MontoPagado = 0 Then
                        Monto = Me.TotalCobro
                    Else
                        Dim diferencia As Decimal = Me.TotalCobro - Me.MontoPagado
                        Monto = diferencia
                    End If
                End If
            End If

            If _CodMoneda = 2 Then
                Dim montopendientedolar As Decimal = (Me.TotalCobro - Me.MontoPagado) / Me.getTipocambio
                'Dim totalcobrodolar As Decimal = Me.TotalCobro / Me.getTipocambio

                If _MontoPago > montopendientedolar Then
                    Monto = montopendientedolar
                End If
            End If

            Dim dt As New DataTable
            Dim NombreMoneda As String = ""
            Dim TipoCambio As Decimal = 0
            Dim NApertura As Integer = 0
            Dim TipoDocumento As String = ""
            If cFunciones.Llenar_Tabla_Generico("Select MonedaNombre, ValorVenta from Moneda where CodMoneda = " & _CodMoneda, dt, CadenaConexionSeePOS) = Nothing Then
                If Credomatic.Operaciones.General.LogVentas.Count > 0 Then
                    Credomatic.Operaciones.General.RevertirLogVentas()
                End If
                _MontoPago = 0
                Me.Close()
            Else
                If dt.Rows.Count > 0 Then
                    NombreMoneda = dt.Rows(0).Item("MonedaNombre")
                    TipoCambio = dt.Rows(0).Item("ValorVenta")
                End If
            End If

            If cFunciones.Llenar_Tabla_Generico("select NApertura from aperturacaja where Estado = 'A' and Cedula = '" & Me.Id_Usuario & "'", dt, CadenaConexionSeePOS) = Nothing Then
                If Credomatic.Operaciones.General.LogVentas.Count > 0 Then
                    Credomatic.Operaciones.General.RevertirLogVentas()
                End If
                _MontoPago = 0
                Me.Close()
            Else
                If dt.Rows.Count > 0 Then
                    NApertura = dt.Rows(0).Item("NApertura")
                End If
            End If


            Select Case Me.TipoFactura
                Case "TCO" : TipoDocumento = "FVT"
                Case "MCO" : TipoDocumento = "FVM"
                Case "CON" : TipoDocumento = "FVC"
                Case "PVE" : TipoDocumento = "FVP"
                Case "ABR" : TipoDocumento = "ABR"
                Case "" : TipoDocumento = "ABO"
                Case "ABO" : TipoDocumento = "ABO"
                Case "RFC" : TipoDocumento = "RFC" 'Recibo Firmado Contado
                Case "APA" : TipoDocumento = "ABA"
            End Select

            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cDocumento", Me.index).Value = 0
            Me.viewDatos.Item("cTipoDocumento", Me.index).Value = TipoDocumento
            Me.viewDatos.Item("cMontoPago", Me.index).Value = Monto
            Me.viewDatos.Item("cFormaPago", Me.index).Value = _FormaPago
            Me.viewDatos.Item("cDenominacion", Me.index).Value = Monto
            Me.viewDatos.Item("cUsuario", Me.index).Value = Me.Id_Usuario
            Me.viewDatos.Item("cNombre", Me.index).Value = Me.NombreUsuario
            Me.viewDatos.Item("cCodMoneda", Me.index).Value = _CodMoneda
            Me.viewDatos.Item("cNombremoneda", Me.index).Value = NombreMoneda
            Me.viewDatos.Item("cTipoCambio", Me.index).Value = TipoCambio
            Me.viewDatos.Item("cFecha", Me.index).Value = Date.Now
            Me.viewDatos.Item("cNumapertura", Me.index).Value = NApertura
            Me.viewDatos.Item("cNumeroDocumento", Me.index).Value = _NumeroDocumento
            Me.index += 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            Me.Close()
        End Try
    End Sub

    Private Function PendienteCobro() As Decimal
        Dim pendiente As Decimal = 0

        pendiente = TotalCobro - MontoPagado
        Return pendiente
    End Function

    Private Sub PoneMontos()
        Me.lblTotalCobro.Text = Me.TotalCobro.ToString("N2")
        Me.lblPagado.Text = Me.MontoPagado.ToString("N2")
        Me.lblPendienteCobro.Text = Me.PendienteCobro.ToString("N2")
        Me.TitulobtnAnticcipo()
    End Sub

    'Private Sub LlenarVentas(ByVal Id As Double)
    '    Dim cnnv As SqlConnection = Nothing
    '    Dim dt As New DataTable
    '    '
    '    ' Dentro de un Try/Catch por si se produce un error
    '    Try
    '        '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        ' Obtenemos la cadena de conexión adecuada
    '        Dim sConn As String = CadenaConexionSeePOS()
    '        cnnv = New SqlConnection(sConn)
    '        cnnv.Open()
    '        ' Creamos el comando para la consulta
    '        Dim cmdv As SqlCommand = New SqlCommand
    '        Dim sel As String = "SELECT * FROM Ventas WHERE (Id = @Id_Factura) "
    '        cmdv.CommandText = sel
    '        cmdv.Connection = cnnv
    '        cmdv.CommandType = CommandType.Text
    '        cmdv.CommandTimeout = 90
    '        ' Los parámetros usados en la cadena de la consulta 
    '        cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
    '        cmdv.Parameters("@Id_Factura").Value = Id
    '        ' Creamos el dataAdapter y asignamos el comando de selección
    '        Dim dv As New SqlDataAdapter
    '        dv.SelectCommand = cmdv
    '        ' Llenamos la tabla
    '        dv.Fill(Me.DataSet_Facturaciones1, "Ventas")
    '        '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        ' Obtenemos la cadena de conexión adecuada
    '        'Dim sConn As String = CadenaConexionSeePOS
    '        'cnn = New SqlConnection(sConn)
    '        'cnn.Open()
    '        ' Creamos el comando para la consulta
    '        Dim cmd As SqlCommand = New SqlCommand
    '        sel = "SELECT * FROM Ventas_Detalle WHERE (Id_Factura = @Id_Factura) "
    '        cmd.CommandText = sel
    '        cmd.Connection = cnnv
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandTimeout = 90
    '        ' Los parámetros usados en la cadena de la consulta 
    '        cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
    '        cmd.Parameters("@Id_Factura").Value = Id
    '        ' Creamos el dataAdapter y asignamos el comando de selección
    '        Dim da As New SqlDataAdapter
    '        da.SelectCommand = cmd
    '        ' Llenamos la tabla
    '        da.Fill(Me.DataSet_Facturaciones1.Ventas_Detalle)
    '    Catch ex As System.Exception
    '        ' Si hay error, devolvemos un valor nulo.
    '        MsgBox(ex.ToString)
    '    Finally
    '        ' Por si se produce un error,
    '        ' comprobamos si en realidad el objeto Connection está iniciado,
    '        ' de ser así, lo cerramos.
    '        If Not cnnv Is Nothing Then
    '            cnnv.Close()
    '        End If
    '    End Try
    'End Sub

    Public RegistroTodo As Boolean = False

    Private Sub RegistrarFactura(_PagoTransferencia As System.Collections.Generic.List(Of PagoTranferencia))
        If IgnoraTodo = False Then

            Dim trans As OBSoluciones.SQL.Transaccion
            Me.RegistroTodo = False
            trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            Try
                If esReciboDinero = False And esSoloAbonoApartado = False And EsApartado = False And EsAdelanto = False And SoloCobrar = False And EsAbono = False Then
                    Me.Id_Factura = 0
                    Me.Num_Factura = 0
                    'Registrar Factura
                    trans.SetParametro("@IdPreventa", Me.Id_PreVenta)
                    trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
                    trans.SetParametro("@Tipo", Me.TipoFactura)
                    trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                    trans.AddParametrosSalidaInt("@Id_Factura", Id_Factura)
                    trans.AddParametrosSalidaInt("@Num_Factura", Num_Factura)
                    trans.Ejecutar("Facturar_PreVenta", Id_Factura, 4, Num_Factura, 5)
                End If
                If esReciboDinero = True Then
                    trans.SetParametro("@IdPreRecibo", Me.Id_PreVenta)
                    trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                    trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
                    trans.AddParametrosSalidaInt("@IdRecibo", Me.IdRecibo)
                    trans.AddParametrosSalidaInt("@NumRecibo", Me.NumRecibo)
                    trans.Ejecutar("Generar_ReciboDinero", Me.IdRecibo, 3, Me.NumRecibo, 4)
                    Me.Num_Factura = Me.NumRecibo
                End If
                If EsAdelanto = True Then
                    Me.Id_Factura = 0
                    Me.Num_Factura = 0
                    'Registrar Factura
                    trans.SetParametro("@IdAdelanto", Me.Id_Adelanto)
                    trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
                    trans.SetParametro("@Tipo", Me.TipoFactura)
                    trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                    trans.AddParametrosSalidaInt("@Id_Factura", Id_Factura)
                    trans.AddParametrosSalidaInt("@Num_Factura", Num_Factura)
                    trans.Ejecutar("Facturar_AdelantoVenta", Id_Factura, 4, Num_Factura, 5)
                End If
                If EsApartado = True Then
                    Me.Id_Apartado = 0
                    trans.SetParametro("@IdPreventa", Me.Id_PreVenta)
                    trans.SetParametro("@FechaVence", Me.FechaVence.ToShortDateString)
                    trans.SetParametro("@MontoAbono", Me.MontoApartado)
                    trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
                    trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                    trans.AddParametrosSalidaInt("@IdApartado", Id_Apartado)
                    trans.AddParametrosSalidaInt("@IdAbonoApartado", Id_AbonoApartado)
                    trans.Ejecutar("Apartar_PreVenta", Id_Apartado, 5, Me.Id_AbonoApartado, 6)
                    Me.Num_Factura = Id_Apartado
                End If
                If esSoloAbonoApartado = True Then
                    'abono a partado
                    'trans.SetParametro("@BaseDatos", Me.PuntodeVenta)
                    trans.SetParametro("@IdApartado", Me.Id_Apartado)
                    trans.SetParametro("@MontoAbonoApartado", Me.MontoApartado)
                    trans.SetParametro("@Ced_Usuario", Me.Id_Usuario)
                    trans.AddParametrosSalidaInt("@Id_AbonoApartado", Id_AbonoApartado)
                    trans.AddParametrosSalidaInt("@NumRecibo", ReciboAbono)
                    trans.Ejecutar("Generar_AbonoApartado", Me.Id_AbonoApartado, 3, Me.ReciboAbono, 4)
                    Me.Num_Factura = Me.ReciboAbono
                End If
                'Registra formas de Pago
                If viewDatos.Rows.Count > 0 Then
                    Dim NApertura As String = "0"
                    If Me.EsAbono = True Then
                        trans.AddParametroSalida("@Id", Me.Num_Factura)
                        trans.SetParametro("@IdFactura", Me.IdFacturaAbono)
                        trans.SetParametro("@Fecha", Me.FechaAbono)
                        trans.SetParametro("@Monto", Me.MontoAbono)
                        trans.Ejecutar("InsertAbonoReintegro", Num_Factura, 0)
                    End If

                    For Each pago As DataGridViewRow In Me.viewDatos.Rows
                        NApertura = pago.Cells("cNumapertura").Value                        
                        trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & Num_Factura & ", '" & pago.Cells("cTipoDocumento").Value & "'," & pago.Cells("cMontoPago").Value & ", '" & pago.Cells("cFormaPago").Value & "'," & pago.Cells("cDenominacion").Value & ", '" & pago.Cells("cUsuario").Value & "','" & pago.Cells("cNombre").Value & "'," & pago.Cells("cCodMoneda").Value & ", '" & pago.Cells("cNombremoneda").Value & "', " & pago.Cells("cTipoCambio").Value & ", getdate()," & pago.Cells("cNumapertura").Value & ", 0, '" & pago.Cells("cNumeroDocumento").Value & "')", CommandType.Text)

                        If esReciboDinero = True And Me.IdRecibo > 0 Then
                            If pago.Cells("cFormaPago").Value = "CHE" Or pago.Cells("cFormaPago").Value = "TRA" Then
                                trans.Ejecutar("Update abonoccobrar set Cheque = '" & pago.Cells("cNumeroDocumento").Value & "' where Id_Recibo = " & Me.IdRecibo, CommandType.Text)
                            End If
                        End If
                    Next

                    For Each t As PagoTranferencia In _PagoTransferencia
                        trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto, Tipo) values(" & 0 & ", " & Me.GetApertura & ", '" & t.Banco & "', '" & t.Cuenta & "', '" & t.Moneda & "', '" & t.NumeroDocumento & "', " & t.Monto & ", 'Transferencia')", CommandType.Text)
                    Next

                    If Me.SoloCobrar = True Then
                        'Se esta pagando una factura pendiente
                        trans.Ejecutar("Update " & Me.PuntodeVenta & ".dbo.AutorizacionVenta set Cancelada = 1, FechaCancelacion = GETDATE(), IdApertura = " & NApertura & " where Id_Factura = " & Me.Id_Factura, CommandType.Text)
                    End If
                Else
                    'aqui inserta tabla pendientes
                    trans.Ejecutar("Insert Into " & Me.PuntodeVenta & ".dbo.AutorizacionVenta(Id_Factura, Id_Cajero, Id_Admin, Cedula_Retira, Nombre_Retira) Values(" & Id_Factura & ", '" & Me.Id_Usuario & "', '" & Me.Id_Administrador & "', '" & Me.CedulaCliente & "', '" & Me.NombreCliente & "')", CommandType.Text)
                End If

                trans.Commit()
                Me.RegistroTodo = True
                Credomatic.Operaciones.General.LimpiarLogVentas()
            Catch ex As Exception
                Me.RegistroTodo = False
                Credomatic.Operaciones.General.RevertirLogVentas()
                trans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text & " - ")
                Exit Sub
            End Try

            If EsAbono = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            End If

            If EsApartado = True Then
                GeneralCaja.clsImpresion.ImprimirApartado(Me.Id_Apartado, Me.PuntodeVenta, Me.Numero_Caja)
                If MontoApartado > 0 Then
                    GeneralCaja.clsImpresion.ImprimirAbonoApartado2(Me.Id_AbonoApartado, Me.PuntodeVenta, Me.Numero_Caja)
                End If

                GeneralCaja.clsImpresion.ImprimirApartado(Me.Id_Apartado, Me.PuntodeVenta, Me.Numero_Caja)
                If MontoApartado > 0 Then
                    GeneralCaja.clsImpresion.ImprimirAbonoApartado2(Me.Id_AbonoApartado, Me.PuntodeVenta, Me.Numero_Caja)
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            End If

            If esSoloAbonoApartado = True Then
                GeneralCaja.clsImpresion.ImprimirAbonoApartado2(Me.Id_AbonoApartado, Me.PuntodeVenta, Me.Numero_Caja)

                Dim IdFacturaAbono As Long = Me.IdFactura(Me.Id_Apartado)
                If IdFacturaAbono > 0 Then
                    GeneralCaja.clsImpresion.ImprimirFactura(IdFacturaAbono, True, Me.PuntodeVenta, Me.Numero_Caja)
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            End If

            If esReciboDinero = True Then
                GeneralCaja.clsImpresion.ImprimirReciboDinero(IdRecibo, Me.PuntodeVenta, Me.Numero_Caja)
                GeneralCaja.clsImpresion.ImprimirReciboDinero(IdRecibo, Me.PuntodeVenta, Me.Numero_Caja)
                Exit Sub
            End If

            GeneralCaja.clsImpresion.ImprimirFactura(Id_Factura, True, Me.PuntodeVenta, Me.Numero_Caja)
        End If
    End Sub

    Private Function IdFactura(ByVal Apartado As Double) As Integer
        Dim cConexion As New Conexion
        Try
            IdFactura = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT ISNULL(Id,0) FROM " & Me.PuntodeVenta & ".dbo.Ventas WHERE Apartado = " & Apartado))
            Return IdFactura
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cConexion.DesConectar(cConexion.Conectar)
        End Try
    End Function

    Private Id_Administrador As String = ""
    Private CedulaCliente As String = ""
    Private NombreCliente As String = ""
    Public ListaPagosTransferencia As New System.Collections.Generic.List(Of PagoTranferencia)
    Public MontoAnticipo As Decimal = 0
    Private clsTermina As New Credomatic.Configuracion.Terminal
    Private Sub btnEfectivo_Click(sender As Object, e As EventArgs) Handles btnTarjetaColones.Click, btnEfectivoColones.Click, btnTransferencia.Click, btnChequeColones.Click, btnPendientes.Click, btnEfectivoDolares.Click, btnOtrasTarjetas.Click, btnAnticipo.Click

        If sender.name = Me.btnPendientes.Name Then

            Dim frmPendiente As New frmFacturaPendiente
            frmPendiente.Id_Usuario = Me.Id_Usuario
            If frmPendiente.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.viewDatos.Rows.Clear()
                'Me.MontoPagado = TotalCobro

                Me.Id_Administrador = frmPendiente.Id_Admin
                Me.CedulaCliente = frmPendiente.txtCedulaCliente.Text
                Me.NombreCliente = frmPendiente.txtNombreCliente.Text

                Me.PoneMontos()
                'If Me.TotalCobro <= Me.MontoPagado Then
                '***************************************************************************************
                'Aqui se registra la factura, las formas de pago y se procesa la factura electronica
                '***************************************************************************************
                Me.ListaPagosTransferencia.Clear()
                Me.RegistrarFactura(Me.ListaPagosTransferencia)
                '***************************************************************************************                    
                Dim frmFicha As New frmNumeroFicha
                frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
                frmFicha.MdiParent = Me.MdiParent
                frmFicha.Show()
                Me.Close()
                'End If

            End If

        ElseIf sender.Name = Me.btnAnticipo.Name Then

            If Me.MontoAnticipo > 0 Then

                If Me.TotalCobro - (Me.MontoPagado + Me.MontoAnticipo) < 0 Then
                    'estoy pagando demas
                    Dim Justo As Decimal = (Me.TotalCobro - Me.MontoPagado)
                    Me.Agregar_Forma_Pago(Justo, "PRE", 1, "0")
                    Me.MontoPagado += Justo
                    MontoAnticipo = Me.MontoAnticipo - Justo
                    Me.PoneMontos()
                Else
                    'estoy pagano lo justo o menos
                    Me.Agregar_Forma_Pago(MontoAnticipo, "PRE", 1, "0")
                    Me.MontoPagado += MontoAnticipo
                    MontoAnticipo = 0
                    Me.PoneMontos()
                End If

               

                If Me.TotalCobro <= Me.MontoPagado Then
                    '***************************************************************************************
                    'Aqui se registra la factura, las formas de pago y se procesa la factura electronica
                    '***************************************************************************************
                    Me.RegistrarFactura(Me.ListaPagosTransferencia)
                    '***************************************************************************************

                    'If Me.MontoPagado > Me.TotalCobro Then
                    '    Dim frmVuelto As New frmVueltoCaja
                    '    frmVuelto.Vuelto = Me.MontoPagado - Me.TotalCobro
                    '    frmVuelto.ShowDialog()
                    'End If

                    If Me.NoVuelto = False Then
                        Me.PasaVuelto = 0
                        If Me.MontoPagado > Me.TotalCobro Then
                            Dim frmVuelto As New frmVueltoCaja
                            frmVuelto.Vuelto = Me.MontoPagado - Me.TotalCobro
                            frmVuelto.ShowDialog()
                        End If
                    Else
                        Me.PasaVuelto = Me.MontoPagado - Me.TotalCobro
                    End If
                    'select * from invenario where select * from 
                    If Me.IgnoraTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    If Me.EsAbono = True And Me.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    If Me.EsApartado = True And Me.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    Dim frmFicha As New frmNumeroFicha
                    frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
                    frmFicha.MdiParent = Me.MdiParent
                    frmFicha.Show()
                    Me.Close()
                End If

            End If
            'zoe

        ElseIf sender.Name = Me.btnTransferencia.Name Then
            Dim frm As New frmFormaPagoTranferencia
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim CodMoneda As Integer = 1
                Dim MontoPago As Decimal = CDec(frm.txtMontoDeposito.Text)
                'Select Case sender.Name
                '    Case btnEfectivoColones.Name
                '        Me.Agregar_Forma_Pago(MontoPago, "EFE", 1, "0")
                '    Case btnEfectivoDolares.Name
                '        CodMoneda = 2
                '        Me.Agregar_Forma_Pago(MontoPago, "EFE", 2, "0")
                '    Case btnChequeColones.Name
                '        Me.Agregar_Forma_Pago(MontoPago, "CHE", 1, frm.txtNumeroDeposito.Text)
                '    Case btnChequeDolares.Name
                '        CodMoneda = 2
                '        Me.Agregar_Forma_Pago(MontoPago, "CHE", 2, frm.txtNumeroDeposito.Text)
                '    Case btnTarjetaColones.Name
                '        Me.Agregar_Forma_Pago(MontoPago, "TAR", 1, "0")
                '    Case btnOtrasTarjetas.Name
                '        Me.Agregar_Forma_Pago(MontoPago, "TAR", 1, "0")
                '    Case btnTransferencia.Name                
                Me.Agregar_Forma_Pago(MontoPago, "TRA", 1, frm.txtNumeroDeposito.Text)
                Dim PagoTransferencia As New PagoTranferencia(False, frm.cboBanco.Text, frm.cboCuenta.Text, frm.txtMoneda.Text, frm.txtNumeroDeposito.Text, CDec(frm.txtMontoDeposito.Text), frm.cboTipoMovimiento.Text)
                Me.ListaPagosTransferencia.Add(PagoTransferencia)
                'End Select

                If CodMoneda = 1 Then
                    Me.MontoPagado += MontoPago
                End If

                If CodMoneda = 2 Then
                    Me.MontoPagado += CDec(MontoPago * Me.getTipocambio)
                End If

                Me.PoneMontos()
                If Me.TotalCobro <= Me.MontoPagado Then
                    '***************************************************************************************
                    'Aqui se registra la factura, las formas de pago y se procesa la factura electronica
                    '***************************************************************************************                   
                    Me.RegistrarFactura(Me.ListaPagosTransferencia)
                    '***************************************************************************************

                    If Me.NoVuelto = False Then
                        Me.PasaVuelto = 0
                        If Me.MontoPagado > Me.TotalCobro Then
                            Dim frmVuelto As New frmVueltoCaja
                            frmVuelto.Vuelto = Me.MontoPagado - Me.TotalCobro
                            frmVuelto.ShowDialog()
                        End If
                    Else
                        Me.PasaVuelto = Me.MontoPagado - Me.TotalCobro
                    End If

                    If Me.IgnoraTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    If Me.EsAbono = True And Me.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    If Me.EsApartado = True And Me.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    Dim frmFicha As New frmNumeroFicha
                    frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
                    frmFicha.MdiParent = Me.MdiParent
                    frmFicha.Show()
                    Me.Close()
                End If
            End If

        Else

            Dim frm As New frmIngresarMontoPago
            If sender.Name = Me.btnTarjetaColones.Name Then
                If clsTermina.Datafono = True Then
                    frm.txtMonto.Text = Me.lblPendienteCobro.Text
                    frm.esTarjeta = True
                Else
                    MsgBox("Seleccione Otras Tarjetas", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                    Exit Sub
                End If
            Else
                frm.esTarjeta = False
            End If
            If sender.Name = Me.btnOtrasTarjetas.Name Then
                frm.txtMonto.Text = Me.lblPendienteCobro.Text
                frm.esTarjeta = False
            End If
            If sender.Name = Me.btnTransferencia.Name Then
                frm.Tipo = "TRA"
            End If
            If sender.Name = Me.btnChequeColones.Name Or sender.Name = Me.btnChequeDolares.Name Then
                frm.Tipo = "CHE"
            End If
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim CodMoneda As Integer = 1
                Dim MontoPago As Decimal = CDec(frm.txtMonto.Text)
                Select Case sender.Name
                    Case btnEfectivoColones.Name
                        Me.Agregar_Forma_Pago(MontoPago, "EFE", 1, "0")
                    Case btnEfectivoDolares.Name
                        CodMoneda = 2
                        Me.Agregar_Forma_Pago(MontoPago, "EFE", 2, "0")
                    Case btnChequeColones.Name
                        Me.Agregar_Forma_Pago(MontoPago, "CHE", 1, frm.txtNumDocumento.Text)
                    Case btnChequeDolares.Name
                        CodMoneda = 2
                        Me.Agregar_Forma_Pago(MontoPago, "CHE", 2, frm.txtNumDocumento.Text)
                    Case btnTarjetaColones.Name
                        Me.Agregar_Forma_Pago(MontoPago, "TAR", 1, "0")
                    Case btnOtrasTarjetas.Name
                        Me.Agregar_Forma_Pago(MontoPago, "TAR", 1, "0")
                    Case btnTransferencia.Name
                        Me.Agregar_Forma_Pago(MontoPago, "TRA", 1, frm.txtNumDocumento.Text)
                End Select

                If CodMoneda = 1 Then
                    Me.MontoPagado += MontoPago
                End If

                If CodMoneda = 2 Then
                    Me.MontoPagado += CDec(MontoPago * Me.getTipocambio)
                End If

                Me.PoneMontos()
                If Me.TotalCobro <= Me.MontoPagado Then
                    '***************************************************************************************
                    'Aqui se registra la factura, las formas de pago y se procesa la factura electronica
                    '***************************************************************************************
                    Me.RegistrarFactura(Me.ListaPagosTransferencia)
                    '***************************************************************************************

                    'If Me.MontoPagado > Me.TotalCobro Then
                    '    Dim frmVuelto As New frmVueltoCaja
                    '    frmVuelto.Vuelto = Me.MontoPagado - Me.TotalCobro
                    '    frmVuelto.ShowDialog()
                    'End If

                    If Me.NoVuelto = False Then
                        Me.PasaVuelto = 0
                        If Me.MontoPagado > Me.TotalCobro Then
                            Dim frmVuelto As New frmVueltoCaja
                            frmVuelto.Vuelto = Me.MontoPagado - Me.TotalCobro
                            frmVuelto.ShowDialog()
                        End If
                    Else
                        Me.PasaVuelto = Me.MontoPagado - Me.TotalCobro
                    End If

                    If Me.IgnoraTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    If Me.EsAbono = True And Me.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    If Me.EsApartado = True And Me.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Exit Sub
                    End If

                    Dim frmFicha As New frmNumeroFicha
                    frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
                    frmFicha.MdiParent = Me.MdiParent
                    frmFicha.Show()
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub frmIngresarFomasdePago_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IgnoraTodo = False Then
            If Credomatic.Operaciones.General.LogVentas.Count > 0 Then
                Credomatic.Operaciones.General.LimpiarLogVentas()
                Credomatic.Operaciones.General.LimpiarLogAnulacion()
            End If
            If CDec(Me.lblPendienteCobro.Text) > 0 Then
                If esSoloAbonoApartado = True Then Exit Sub
                Dim frmFicha As New frmNumeroFicha
                frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
                frmFicha.MdiParent = Me.MdiParent
                frmFicha.Show()
            End If
        End If        
    End Sub

    Private Sub TitulobtnAnticcipo()
        Me.btnAnticipo.Text = "Anticipo"
        If Me.MontoAnticipo > 0 Then
            Me.btnAnticipo.Text = "Anticipo" & vbCrLf _
                & "₡ " & Me.MontoAnticipo.ToString("N2")
        End If
    End Sub

    Private Sub frmIngresarFomasdePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsClinica() = True Then
            Me.btnTarjetaColones.Enabled = False
        Else
            Me.btnTarjetaColones.Enabled = True
        End If

        Credomatic.Operaciones.General.LimpiarLogVentas()
        Credomatic.Operaciones.General.LimpiarLogAnulacion()
        Me.Vuelto = 0
        Me.PoneMontos()
        Me.lblTipodeCambio.Text = "Tipo de Cambio del Dolar : " & Me.getTipocambio.ToString("N2")
        If CDec(Me.lblPendienteCobro.Text) = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        If Me.MontoAnticipo > 0 Then
            Me.btnAnticipo.Enabled = True
            Me.TitulobtnAnticcipo()
        Else
            Me.btnAnticipo.Enabled = False
        End If
    End Sub

    Private Function getTipocambio() As Decimal
        Dim TipoCambio As Decimal = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select ValorCompra from moneda where codmoneda = 2", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then
            TipoCambio = dt.Rows(0).Item("ValorCompra")
        End If
        Return TipoCambio
    End Function

    Private Sub btnChequeDolares_Click(sender As Object, e As EventArgs) Handles btnChequeDolares.Click

    End Sub

    Private Sub btnAnticipo_Click(sender As Object, e As EventArgs) Handles btnAnticipo.Click

    End Sub
End Class

Public Structure PagoTranferencia
    Public Vacio As Boolean
    Public Banco As String
    Public Cuenta As String
    Public Moneda As String
    Public NumeroDocumento As String
    Public Monto As Decimal
    Public TipoMoviminento As String
    Sub New(_Vacio As Boolean, _IdBanco As String, _IdCuenta As String, _Moneda As String, _NumeroDocumento As String, _Monto As Decimal, _TipoMovimiento As String)
        Me.Vacio = _Vacio
        Me.Banco = _IdBanco
        Me.Cuenta = _IdCuenta
        Me.Moneda = _Moneda
        Me.NumeroDocumento = _NumeroDocumento
        Me.Monto = _Monto
        'If _TipoMovimiento = "Transferencia" Then _TipoMovimiento = "Deposito"
        Me.TipoMoviminento = _TipoMovimiento
    End Sub

End Structure
