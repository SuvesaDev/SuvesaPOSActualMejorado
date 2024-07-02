
Imports System.Windows.Forms
Imports System.Data

Public Class frmDatosPreVenta


    Public Id_PreVenta As Long = 0
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0
    Public BanderaesCliente As Boolean = False
    Public Cod_Cliente As Long = 0

    Public NumCuenta As Integer = 0

    Private Sub Cobrar(_Tipo As String)
        Dim frm As New frmIngresarFomasdePago
        frm.btnPendientes.Enabled = True
        frm.PuntodeVenta = Me.txtPuntoVenta.Text
        frm.Id_PreVenta = Me.Id_PreVenta
        frm.TipoFactura = _Tipo
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtTotalCobro.Text)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Function TipoTiquete() As String
        Return "PVE"
    End Function

    Private Function TipoFactura() As String
        Dim Tipo As String = ""
        'Puede ser CON (parte Agro)
        'Puede ser TCO (parte Taller)
        Tipo = "CON" 'solo para pruebas, despues hay que agregar validacion
        Return Tipo
    End Function

    Public Sub DataGridViewxDefecto(ByRef _view As DataGridView, Optional ByVal _readonly As Boolean = True)
        With _view
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ReadOnly = _readonly
            .MultiSelect = False
            .BackgroundColor = Drawing.Color.White
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub CargarDatosPreventa()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewPreventasActivas Where NumCuenta = " & Me.NumCuenta, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

        End If
    End Sub

    Private Sub frmDatosPreVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridViewxDefecto(Me.viewDatos)
        Me.CalcularTotales()
        Me.HabilitaRenta()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim frm As New frmNumeroFicha
        frm.CargarPrimerUsuario(Me.Id_Usuario)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnTiquete.Click, btnFactura.Click
        If sender.Name = Me.btnFactura.Name Then
            If BanderaesCliente = False Then
                MsgBox("No se puede realizar la operacion. " & vbCrLf _
                   & "Falta informacion de la cedula y correos", MsgBoxStyle.Exclamation, Text)
                Exit Sub
            End If
        End If

        Dim Tipo As String = ""
        Select Case sender.name
            Case btnTiquete.Name : Tipo = Me.TipoTiquete
            Case btnFactura.Name
                Tipo = Me.TipoFactura
            Case btnReciboDinero.Name
                Tipo = ""
        End Select
        Me.Cobrar(Tipo)

    End Sub

    Private Sub frmDatosPreVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.D2
                If btnFactura.Visible = True Then
                    Me.Cobrar(Me.TipoFactura)
                End If
                If btnCobrar.Visible = True Then
                    Me.CobrarUnificado()
                End If
            Case Keys.D3
                If btnTiquete.Visible = True Then
                    Me.Cobrar(Me.TipoTiquete)
                End If
            Case Keys.D4
                If btnReciboDinero.Visible = True Then
                    Me.Cobrar("")
                End If
            Case Keys.D5
                Me.GenerarAdelanto()
            Case Keys.D6
                Me.GenerarApartado()
        End Select
    End Sub

    Public RegistroTodo As Boolean = False
    Private Sub GenerarAdelanto()
        Dim frmPendiente As New frmFacturaPendiente
        frmPendiente.Id_Usuario = Me.Id_Usuario
        If frmPendiente.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim Id_Administrador As String = frmPendiente.Id_Admin
            Dim CedulaCliente As String = frmPendiente.txtCedulaCliente.Text
            Dim NombreCliente As String = frmPendiente.txtNombreCliente.Text

            '***************************************************************************************
            'Aqui se registra el adelanto y la autorizacion
            '***************************************************************************************
            Dim trans As OBSoluciones.SQL.Transaccion
            Me.RegistroTodo = False
            Dim Id_Adelanto, Num_Factura As Long
            Try
                trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                'Registrar Factura
                trans.SetParametro("@IdPreventa", Me.Id_PreVenta)
                trans.SetParametro("@PuntodeVenta", Me.txtPuntoVenta.Text)
                trans.SetParametro("@Tipo", Me.TipoFactura)
                trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                trans.AddParametrosSalidaInt("@Id_Factura", Id_Adelanto)
                trans.AddParametrosSalidaInt("@Num_Factura", Num_Factura)
                trans.Ejecutar("Adelatar_PreVenta", Id_Adelanto, 4, Num_Factura, 5)

                'aqui inserta tabla pendientes
                trans.Ejecutar("Insert Into AutorizacionAdelanto(Id_Adelanto, Id_Cajero, Id_Admin, Cedula_Retira, Nombre_Retira) Values(" & Id_Adelanto & ", '" & Me.Id_Usuario & "', '" & Id_Administrador & "', '" & CedulaCliente & "', '" & NombreCliente & "')", CommandType.Text)

                trans.Commit()
                Me.RegistroTodo = True
            Catch ex As Exception
                trans.Rollback()
                RegistrarLog(ex.StackTrace)
                Me.RegistroTodo = False
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text & " - ")
                Exit Sub
            End Try

            GeneralCaja.clsImpresion.ImprimirAdelanto(Id_Adelanto, True, Me.Numero_Caja, Me.txtPuntoVenta.Text)
            GeneralCaja.clsImpresion.ImprimirAdelanto(Id_Adelanto, True, Me.Numero_Caja, Me.txtPuntoVenta.Text)
            '***************************************************************************************                    
            Dim frmFicha As New frmNumeroFicha
            frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
            frmFicha.MdiParent = Me.MdiParent
            frmFicha.Show()
            Me.Close()

        End If
    End Sub
    Private Sub btnGeneraAdelanto_Click(sender As Object, e As EventArgs) Handles btnGeneraAdelanto.Click
        Me.GenerarAdelanto()
    End Sub

    Private Sub GenerarApartado()
        Dim frmApartado As New frmGenerarApartado
        frmApartado.Numero_Caja = Me.Numero_Caja
        frmApartado.Id_Preventa = Me.Id_PreVenta
        frmApartado.PuntoVenta = Me.txtPuntoVenta.Text
        frmApartado.Tipo = "APA"
        frmApartado.Id_Usuario = Me.Id_Usuario
        frmApartado.NombreUsuario = Me.NombreUsuario
        frmApartado.MontoTotalApartado = CDec(Me.txtTotalCobro.Text)
        If frmApartado.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim frmFicha As New frmNumeroFicha
            frmFicha.CargarPrimerUsuario(Me.Id_Usuario)
            frmFicha.MdiParent = Me.MdiParent
            frmFicha.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btnGenerarApartado_Click(sender As Object, e As EventArgs) Handles btnGenerarApartado.Click
        Me.GenerarApartado()
    End Sub

    Private Sub btnReciboDinero_Click(sender As Object, e As EventArgs) Handles btnReciboDinero.Click
        Dim frm As New frmIngresarFomasdePago
        frm.btnPendientes.Enabled = False
        frm.esReciboDinero = True
        frm.PuntodeVenta = Me.txtPuntoVenta.Text
        frm.Id_PreVenta = Me.Id_PreVenta
        frm.TipoFactura = "ABO"
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtTotalCobro.Text)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ckEsElectronica_CheckedChanged(sender As Object, e As EventArgs) Handles ckEsElectronica.CheckedChanged
        Me.btnFactura.Enabled = True
    End Sub

    Private Sub viewFichas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewFichas.CellDoubleClick
        If Me.viewFichas.Item("cTipo", e.RowIndex).Value = "APA" Then
            Dim frm As New frmMontoAbonoApartado
            frm.txtAbono.Text = Me.viewFichas.Item("cAbono", e.RowIndex).Value
            frm.Tope = Me.viewFichas.Item("cTotal", e.RowIndex).Value
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.viewFichas.Item("cAbono", e.RowIndex).Value = CDec(frm.txtAbono.Text).ToString("N2")
                Me.CalcularTotales()
            End If
        Else
            Dim frm As New frmFacturaElectronica
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Tipo As String = Me.viewFichas.Item("cTipo", e.RowIndex).Value
                Dim BasedeDatos As String = Me.viewFichas.Item("cPuntoVenta", e.RowIndex).Value
                Dim IdFactura As String = Me.viewFichas.Item("cId", e.RowIndex).Value

                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update " & BasedeDatos & ".dbo.PreVentas Set Tipo = 'CON', Cod_Cliente = " & frm.Identificacion & ", Nombre_Cliente = '" & frm.txtNombre.Text & "' Where Id = " & IdFactura, CommandType.Text)
                Me.viewFichas.Item("cTipo", e.RowIndex).Value = "CON"
                Me.viewFichas.Item("cCliente", e.RowIndex).Value = frm.txtNombre.Text
            End If
        End If
    End Sub

    Private SoloEfectivo As Boolean = False

    Private Function DescuentoEspecial() As Boolean
        Return False
    End Function

    Private Sub viewFichas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles viewFichas.CellEnter
        Me.SoloEfectivo = False
        Dim Tipo As String = Me.viewFichas.Item("cTipo", e.RowIndex).Value
        Dim BasedeDatos As String = Me.viewFichas.Item("cPuntoVenta", e.RowIndex).Value
        Dim IdFactura As String = Me.viewFichas.Item("cId", e.RowIndex).Value

        Dim dtdetalle As New DataTable
        If Tipo <> "ABO" Then
            cFunciones.Llenar_Tabla_Generico("select CodArticulo, Descripcion, Cantidad, Precio_Unit, SubTotal, Descuento from " & BasedeDatos & ".dbo.PreVentas_Detalle Where Id_Factura = " & IdFactura, dtdetalle, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dtdetalle

            Dim descuentos As System.Collections.Generic.List(Of DataGridViewRow) = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("Descuento").Value >= 8 Select x).ToList

            If descuentos.Count > 0 And Me.DescuentoEspecial = False Then
                Me.SoloEfectivo = True
            End If
            Me.SoloEfectivo = False

            Try
                Me.viewDatos.Columns("Cantidad").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Cantidad").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Me.viewDatos.Columns("Precio_Unit").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Precio_Unit").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Me.viewDatos.Columns("SubTotal").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("SubTotal").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
            End Try
        Else
            cFunciones.Llenar_Tabla_Generico("select Factura, Monto, Saldo_Ant, Abono, Saldo from " & BasedeDatos & ".dbo.Detalle_PreAbonocCobrar where id_recibo = " & IdFactura, dtdetalle, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dtdetalle
            Try
                Me.viewDatos.Columns("Monto").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Monto").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Me.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Me.viewDatos.Columns("Abono").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Abono").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Me.viewDatos.Columns("Saldo").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Saldo").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Function getTipocambio() As Decimal
        Dim TipoCambio As Decimal = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select ValorVenta from moneda where codmoneda = 2", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then
            TipoCambio = dt.Rows(0).Item("ValorVenta")
        End If
        Return TipoCambio
    End Function

    Private Function getTipoDoc(_Tipo As String) As String
        Select Case _Tipo
            Case "TCO" : Return "FVT"
            Case "MCO" : Return "FVM"
            Case "CON" : Return "FVC"
            Case "MCO" : Return "FVM"
            Case "PVE" : Return "FVP"
            Case "ABR" : Return "ABR"
            Case "" : Return "ABO"
            Case "ABO" : Return "ABO"
            Case "RFC" : Return "RFC" 'Recibo Firmado Contado
            Case "APA" : Return "ABA"
        End Select
    End Function

    Private Id_Administrador As String = ""
    Private CedulaCliente As String = ""
    Private NombreCliente As String = ""
    Private Telefono_Retira As String = ""

    Private Function PasaCondicionesdeUso(_CedulaRetira As String, _Id_ADM As String) As Boolean
        Dim CondicionesdeUso As New DataTable
        Dim Exepciones As New DataTable
        Dim cls As New VALIDA_FIRMADOCONTADO
        '// Obtenemos las condiciones de uso y sus exepciones
        CondicionesdeUso = cls.GET_VALIDACION(1)
        Exepciones = cls.CARGAR_EXEPCION_FIRMADOCONTADO(1)

        '// verificamos si es una exepcion
        Dim exepcionRetira As Decimal = (From x As DataRow In Exepciones.Rows Where x.Item("Cedula") = _CedulaRetira).Count()

        If exepcionRetira = 0 Then
            '// Validacion Tipo Factura
            For Each r As DataGridViewRow In Me.viewFichas.Rows
                If r.Cells("cTipo").Value = "PVE" Then
                    'PVE
                    If CondicionesdeUso.Rows(0).Item("PVE") = False Then
                        MsgBox("Las facturas de Punto de venta no pueden ser firmado contado." & vbCrLf _
                               & "Solo las de contado.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                        Return False
                    End If
                Else
                    'CON TCO MCO
                    If CondicionesdeUso.Rows(0).Item("Contado") = False Then
                        MsgBox("Las facturas de contado no pueden ser firmado contado." & vbCrLf _
                               & "Solo as de PVE.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                        Return False
                    End If
                End If
            Next

            '// Validacion Monto de Factura
            If CDec(CondicionesdeUso.Rows(0).Item("Monto_Maximo")) > 0 Then
                For Each r As DataGridViewRow In Me.viewFichas.Rows
                    If CDec(r.Cells("cTotal").Value) > CDec(CondicionesdeUso.Rows(0).Item("Monto_Maximo")) Then
                        MsgBox("La ficha #" & r.Cells("cFicha").Value & vbCrLf _
                               & "del Cliente:  " & r.Cells("cCliente").Value & "" & vbCrLf _
                               & "por un monto de:  " & CDec(r.Cells("cTotal").Value).ToString("N2") & "" & vbCrLf _
                               & "Supera el monto maximo permitido", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                        Return False
                    End If
                Next
            End If            

            '// Validacion Exigir Nombre
            If CDec(CondicionesdeUso.Rows(0).Item("Exige_Nombre")) = True Then
                For Each r As DataGridViewRow In Me.viewFichas.Rows
                    If r.Cells("cCliente").Value = "CLIENTE DE CONTADO" Then
                        MsgBox("La ficha #" & r.Cells("cFicha").Value & vbCrLf _
                               & "del Cliente:  " & r.Cells("cCliente").Value & "" & vbCrLf _
                               & "por un monto de:  " & CDec(r.Cells("cTotal").Value).ToString("N2") & "" & vbCrLf _
                               & "Debe ingresar un nombre valido.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                        Return False
                    End If
                Next
            End If

            '// Validacion conteo Cliente

            '// Validacion conteo Retira
            Dim dtPendientesRetira As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select COUNT(*) AS REGISTROS from viewAutorizacionFacturasPendientes where Cancelada = 0 and Cedula_Retira = '" & CedulaCliente & "'", dtPendientesRetira, CadenaConexionSeePOS)
            If dtPendientesRetira.Rows.Count > 0 Then
                If CDec(dtPendientesRetira.Rows(0).Item("REGISTROS")) > CDec(CondicionesdeUso.Rows(0).Item("Maximo_Retira")) Then
                    MsgBox(NombreCliente & " Tiene " & CDec(dtPendientesRetira.Rows(0).Item("REGISTROS")) & " facturas pendintes" & vbCrLf _
                           & "No puede sacar mas firmado contado.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                    Return False
                End If
            End If

            '// Validacion conteo Autoriza
            Dim dtPendientesAutoriza As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select COUNT(*) AS REGISTROS from viewAutorizacionFacturasPendientes where Cancelada = 0 and Id_Admin = '" & _Id_ADM & "'", dtPendientesAutoriza, CadenaConexionSeePOS)
            If dtPendientesAutoriza.Rows.Count > 0 Then
                If CDec(dtPendientesAutoriza.Rows(0).Item("REGISTROS")) > CDec(CondicionesdeUso.Rows(0).Item("Maximo_Retira")) Then
                    MsgBox("El administrador que autoriza Tiene " & CDec(dtPendientesAutoriza.Rows(0).Item("REGISTROS")) & " facturas pendintes" & vbCrLf _
                           & "No puede sacar mas firmado contado.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                    Return False
                End If
            End If
        End If

        Return True
    End Function

    Public NoEnviarPideFicha As Boolean = False

    Private Function GetCupones(_IdPreventa As Integer) As Integer
        If IsClinica() = True Then Return 0
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select cupones from PreVentas where id = " & _IdPreventa, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("cupones")
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function GetId(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select identificacion from Clientes where cedula = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("identificacion")
        Else
            Return "-1"
        End If
    End Function

    Private Function CargarSaldoPrepago(_Identificacion As String) As Decimal
        Dim dt As New DataTable
        Dim cedula2 As String = Me.GetId(_Identificacion)
        cFunciones.Llenar_Tabla_Generico("select IsNull(Sum(debitos - creditos),0) as Saldo from viewMovimientosPrepagos where identificacion = " & _Identificacion & " or identificacion = " & cedula2, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Saldo")
        Else
        Return 0
        End If
    End Function

    Private Function TieneCredito(_Identificacion As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select abierto from Clientes where identificacion = " & _Identificacion, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Abierto") = "Si" Then
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function

    Private Sub CobrarUnificado()
        For Each a As DataGridViewRow In Me.viewFichas.Rows
            If a.Cells("cTipo").Value = "APA" Then
                If a.Cells("cAbono").Value = 0 Then
                    Exit Sub
                End If
            End If
        Next

        Dim Id_Factura, Num_Factura, IdRecibo, NumRecibo, IdApartdo, IdAbonoApartado As Long
        If CDec(Me.txtTotalPendiente.Text) > 0 Then

            'If TieneCredito(Me.Cod_Cliente) = True Then
            '    MsgBox("El cliente tiene credito activado", MsgBoxStyle.Exclamation, "No se puede realizar la Factura Firmado Contado")
            '    Exit Sub
            'End If

            Dim frmPendiente As New frmFacturaPendiente
            frmPendiente.Id_Usuario = Me.Id_Usuario
            If frmPendiente.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Id_Administrador = frmPendiente.Id_Admin
                Me.CedulaCliente = frmPendiente.txtCedulaCliente.Text
                Me.NombreCliente = frmPendiente.txtNombreCliente.Text
                Me.Telefono_Retira = frmPendiente.txtTelefono_Retira.Text

                If Me.PasaCondicionesdeUso(Me.CedulaCliente, Me.Id_Administrador) = False Then
                    Exit Sub
                End If

            Else
                Exit Sub
            End If
        End If

        Dim frm As New frmIngresarFomasdePago
        frm.MontoAnticipo = Me.CargarSaldoPrepago(Me.Cod_Cliente)

        If Me.SoloEfectivo = True Then
            frm.btnTarjetaColones.Enabled = False
            frm.btnOtrasTarjetas.Enabled = False
        Else
            frm.btnTarjetaColones.Enabled = True
            frm.btnOtrasTarjetas.Enabled = True
        End If
        frm.IgnoraTodo = True
        frm.NoVuelto = True
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtTotalCobro.Text)
        frm.TipoFactura = "RFC"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dt As New DataTable
            Dim NApertura As String = ""
            Dim Caja As String = ""
            cFunciones.Llenar_Tabla_Generico("select NApertura, Num_Caja from aperturacaja where Estado = 'A' and Cedula = '" & Me.Id_Usuario & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                NApertura = dt.Rows(0).Item("NApertura")
                Caja = dt.Rows(0).Item("Num_Caja")
                Dim DocumentoVitacoraVuelto As String = ""

                Dim trans As OBSoluciones.SQL.Transaccion
                trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    For Each r As DataGridViewRow In Me.viewFichas.Rows
                        If r.Cells("cTipo").Value = "CON" Or r.Cells("cTipo").Value = "MCO" Or r.Cells("cTipo").Value = "TCO" Or r.Cells("cTipo").Value = "PVE" Then
                            Id_Factura = 0
                            Num_Factura = 0
                            trans.SetParametro("@IdPreventa", r.Cells("cId").Value)
                            trans.SetParametro("@PuntodeVenta", r.Cells("cPuntoVenta").Value)
                            trans.SetParametro("@Tipo", r.Cells("cTipo").Value)
                            trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                            trans.AddParametrosSalidaInt("@Id_Factura", Id_Factura)
                            trans.AddParametrosSalidaInt("@Num_Factura", Num_Factura)
                            trans.Ejecutar("Facturar_PreVenta", Id_Factura, 4, Num_Factura, 5)
                            r.Cells("cDocumento").Value = Num_Factura
                            r.Cells("cIdDocumento").Value = Id_Factura

                            If r.Cells("cRenta").Value = True Then
                                trans.Ejecutar("Update Ventas Set Renta = 1 Where Id = " & Id_Factura, CommandType.Text)
                            End If

                            If r.Cells("cPendiente").Value = True Or r.Cells("cExpress").Value = True Then
                                trans.Ejecutar("Insert Into " & r.Cells("cPuntoVenta").Value & ".dbo.AutorizacionVenta(Id_Factura, Id_Cajero, Id_Admin, Cedula_Retira, Nombre_Retira, Telefono_Retira, Express) Values(" & Id_Factura & ", '" & Me.Id_Usuario & "', '" & Me.Id_Administrador & "', '" & Me.CedulaCliente & "', '" & Me.NombreCliente & "', '" & Me.Telefono_Retira & "', " & IIf(r.Cells("cExpress").Value = True, 1, 0) & ")", CommandType.Text)
                            End If
                        End If

                        If r.Cells("cTipo").Value = "ABO" Then
                            IdRecibo = 0
                            NumRecibo = 0
                            trans.SetParametro("@IdPreRecibo", r.Cells("cId").Value)
                            trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                            trans.SetParametro("@PuntodeVenta", r.Cells("cPuntoVenta").Value)
                            trans.AddParametrosSalidaInt("@IdRecibo", IdRecibo)
                            trans.AddParametrosSalidaInt("@NumRecibo", NumRecibo)
                            trans.Ejecutar("Generar_ReciboDinero", IdRecibo, 3, NumRecibo, 4)
                            r.Cells("cDocumento").Value = NumRecibo
                            r.Cells("cIdDocumento").Value = IdRecibo
                        End If

                        If r.Cells("cTipo").Value = "APA" Then
                            IdApartdo = 0
                            IdAbonoApartado = 0
                            trans.SetParametro("@IdPreventa", CLng(r.Cells("cId").Value))
                            trans.SetParametro("@FechaVence", DateAdd(DateInterval.Day, 30, Date.Now))
                            trans.SetParametro("@MontoAbono", CDec(r.Cells("cAbono").Value))
                            trans.SetParametro("@PuntodeVenta", r.Cells("cPuntoVenta").Value)
                            trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
                            trans.AddParametrosSalidaInt("@IdApartado", IdApartdo)
                            trans.AddParametrosSalidaInt("@IdAbonoApartado", IdAbonoApartado)
                            trans.Ejecutar("Apartar_PreVenta", IdApartdo, 5, IdAbonoApartado, 6)
                            r.Cells("cDocumento").Value = IdApartdo
                            r.Cells("cIdDocumento").Value = IdAbonoApartado
                        End If
                    Next

                    Dim PrepagoColon As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "PRE" And x.Cells("cCodMoneda").Value = 1 Select CDec(x.Cells("cMontoPago").Value)).Sum
                    Dim EfectivoColon As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "EFE" And x.Cells("cCodMoneda").Value = 1 Select CDec(x.Cells("cMontoPago").Value)).Sum
                    Dim EfectivoDolar As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "EFE" And x.Cells("cCodMoneda").Value = 2 Select CDec(x.Cells("cMontoPago").Value * x.Cells("cTipoCambio").Value)).Sum
                    Dim Tarjeta As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "TAR" Select CDec(x.Cells("cMontoPago").Value * x.Cells("cTipoCambio").Value)).Sum
                    Dim Cheque As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "CHE" Select CDec(x.Cells("cMontoPago").Value * x.Cells("cTipoCambio").Value)).Sum
                    Dim Transferencia As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "TRA" Select CDec(x.Cells("cMontoPago").Value * x.Cells("cTipoCambio").Value)).Sum

                    Dim TipoDoc As String = ""
                    Dim FormaPago As String = ""
                    Dim MontoPago As Decimal = 0
                    Dim Cod_Moneda As Integer = 1
                    Dim NombreMoneda As String = "COLON"
                    Dim TipoCambio As Decimal = 1                    

                    For Each doc As DataGridViewRow In Me.viewFichas.Rows

                        If DocumentoVitacoraVuelto = "" Then
                            DocumentoVitacoraVuelto = doc.Cells("cDocumento").Value
                        Else
                            DocumentoVitacoraVuelto += ", " & doc.Cells("cDocumento").Value
                        End If

                        If doc.Cells("cPendiente").Value = False Then
                            TipoDoc = getTipoDoc(doc.Cells("cTipo").Value)

                            '************************************************************************************************************
                            'Pagos en Colones
                            '************************************************************************************************************

                            Cod_Moneda = 1
                            NombreMoneda = "COLON"
                            TipoCambio = 1

                            If PrepagoColon > 0 And CDec(doc.Cells("cTotal").Value) > 0 Then
                                FormaPago = "PRE"
                                If CDec(doc.Cells("cTotal").Value) < PrepagoColon Then
                                    MontoPago = CDec(doc.Cells("cTotal").Value)
                                    PrepagoColon -= CDec(doc.Cells("cTotal").Value)
                                    doc.Cells("cTotal").Value = 0
                                Else
                                    doc.Cells("cTotal").Value = CDec(doc.Cells("cTotal").Value) - PrepagoColon
                                    MontoPago = PrepagoColon
                                    PrepagoColon = 0
                                End If
                                trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & FormaPago & "'," & MontoPago & ", '" & Me.Id_Usuario & "','" & Me.NombreUsuario & "'," & Cod_Moneda & ", '" & NombreMoneda & "', " & TipoCambio & ", getdate()," & NApertura & ", 0, '" & "" & "')", CommandType.Text)

                                Select Case TipoDoc
                                    Case "ABO"
                                        trans.Ejecutar("Update " & doc.Cells("cPuntoVenta").Value & ".[dbo].[abonoccobrar] Set Prepago = " & MontoPago & " Where Id_Recibo = " & IdRecibo, CommandType.Text)
                                    Case Else
                                        trans.Ejecutar("Update " & doc.Cells("cPuntoVenta").Value & ".[dbo].[Ventas] Set Prepago = " & MontoPago & " Where Id = " & Id_Factura, CommandType.Text)
                                End Select

                            End If

                            If EfectivoColon > 0 And CDec(doc.Cells("cTotal").Value) > 0 Then
                                FormaPago = "EFE"
                                If CDec(doc.Cells("cTotal").Value) < EfectivoColon Then
                                    MontoPago = CDec(doc.Cells("cTotal").Value)
                                    EfectivoColon -= CDec(doc.Cells("cTotal").Value)
                                    doc.Cells("cTotal").Value = 0
                                Else
                                    doc.Cells("cTotal").Value = CDec(doc.Cells("cTotal").Value) - EfectivoColon
                                    MontoPago = EfectivoColon
                                    EfectivoColon = 0
                                End If
                                trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & FormaPago & "'," & MontoPago & ", '" & Me.Id_Usuario & "','" & Me.NombreUsuario & "'," & Cod_Moneda & ", '" & NombreMoneda & "', " & TipoCambio & ", getdate()," & NApertura & ", 0, '" & "" & "')", CommandType.Text)
                            End If

                            If Tarjeta > 0 And CDec(doc.Cells("cTotal").Value) > 0 Then
                                FormaPago = "TAR"
                                If CDec(doc.Cells("cTotal").Value) < Tarjeta Then
                                    MontoPago = CDec(doc.Cells("cTotal").Value)
                                    Tarjeta -= CDec(doc.Cells("cTotal").Value)
                                    doc.Cells("cTotal").Value = 0
                                Else
                                    doc.Cells("cTotal").Value = CDec(doc.Cells("cTotal").Value) - Tarjeta
                                    MontoPago = Tarjeta
                                    Tarjeta = 0
                                End If
                                trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & FormaPago & "'," & MontoPago & ", '" & Me.Id_Usuario & "','" & Me.NombreUsuario & "'," & Cod_Moneda & ", '" & NombreMoneda & "', " & TipoCambio & ", getdate()," & NApertura & ", 0, '" & "" & "')", CommandType.Text)
                            End If

                            If Cheque > 0 And CDec(doc.Cells("cTotal").Value) > 0 Then
                                FormaPago = "CHE"
                                If CDec(doc.Cells("cTotal").Value) < Cheque Then
                                    MontoPago = CDec(doc.Cells("cTotal").Value)
                                    Cheque -= CDec(doc.Cells("cTotal").Value)
                                    doc.Cells("cTotal").Value = 0
                                Else
                                    doc.Cells("cTotal").Value = CDec(doc.Cells("cTotal").Value) - Cheque
                                    MontoPago = Cheque
                                    Cheque = 0
                                End If
                                trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & FormaPago & "'," & MontoPago & ", '" & Me.Id_Usuario & "','" & Me.NombreUsuario & "'," & Cod_Moneda & ", '" & NombreMoneda & "', " & TipoCambio & ", getdate()," & NApertura & ", 0, '" & "" & "')", CommandType.Text)
                            End If

                            If Transferencia > 0 And CDec(doc.Cells("cTotal").Value) > 0 Then
                                FormaPago = "TRA"
                                For Each pago As DataGridViewRow In (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cFormaPago").Value = "TRA" Select x).ToList

                                    If CDec(doc.Cells("cTotal").Value) < Transferencia Then
                                        MontoPago = CDec(doc.Cells("cTotal").Value)
                                        Transferencia -= CDec(doc.Cells("cTotal").Value)
                                        doc.Cells("cTotal").Value = 0
                                    Else
                                        doc.Cells("cTotal").Value = CDec(doc.Cells("cTotal").Value) - Transferencia
                                        MontoPago = Transferencia
                                        Transferencia = 0
                                    End If

                                    NApertura = pago.Cells("cNumapertura").Value
                                    'trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & FormaPago & "'," & MontoPago & ", '" & Me.Id_Usuario & "','" & Me.NombreUsuario & "'," & Cod_Moneda & ", '" & NombreMoneda & "', " & TipoCambio & ", getdate()," & NApertura & ", 0, '" & "" & "')", CommandType.Text)
                                    trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & pago.Cells("cFormaPago").Value & "'," & MontoPago & ", '" & pago.Cells("cUsuario").Value & "','" & pago.Cells("cNombre").Value & "'," & pago.Cells("cCodMoneda").Value & ", '" & pago.Cells("cNombremoneda").Value & "', " & pago.Cells("cTipoCambio").Value & ", getdate()," & pago.Cells("cNumapertura").Value & ", 0, '" & pago.Cells("cNumeroDocumento").Value & "')", CommandType.Text)
                                Next

                            End If

                            '************************************************************************************************************
                            'Pagos en Dolares
                            '************************************************************************************************************

                            Cod_Moneda = 2
                            NombreMoneda = "DOLAR"
                            TipoCambio = Me.getTipocambio

                            If EfectivoDolar > 0 And CDec(doc.Cells("cTotal").Value) > 0 Then
                                FormaPago = "EFE"
                                If CDec(doc.Cells("cTotal").Value) < EfectivoDolar Then
                                    MontoPago = CDec(doc.Cells("cTotal").Value) / TipoCambio
                                    EfectivoDolar -= CDec(doc.Cells("cTotal").Value)
                                    doc.Cells("cTotal").Value = 0
                                Else
                                    doc.Cells("cTotal").Value = CDec(doc.Cells("cTotal").Value) - EfectivoDolar
                                    MontoPago = CDec(EfectivoDolar / TipoCambio)
                                    EfectivoDolar = 0
                                End If
                                trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & doc.Cells("cDocumento").Value & ", '" & TipoDoc & "'," & MontoPago & ", '" & FormaPago & "'," & MontoPago & ", '" & Me.Id_Usuario & "','" & Me.NombreUsuario & "'," & Cod_Moneda & ", '" & NombreMoneda & "', " & TipoCambio & ", getdate()," & NApertura & ", 0, '" & "" & "')", CommandType.Text)
                            End If
                        End If
                    Next

                    For Each t As PagoTranferencia In frm.ListaPagosTransferencia
                        trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto, Tipo, TipoMovimiento) values(" & 0 & ", " & NApertura & ", '" & t.Banco & "', '" & t.Cuenta & "', '" & t.Moneda & "', '" & t.NumeroDocumento & "', " & t.Monto & ", 'Transferencia', '" & t.TipoMoviminento & "')", CommandType.Text)
                    Next

                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                    RegistrarLog(ex.StackTrace)
                    MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
                End Try

                Try
                    Dim clsImpresion As New ImpresionCaja
                    For Each r As DataGridViewRow In Me.viewFichas.Rows
                        If r.Cells("cTipo").Value = "CON" Or r.Cells("cTipo").Value = "MCO" Or r.Cells("cTipo").Value = "TCO" Or r.Cells("cTipo").Value = "PVE" Then
                            clsImpresion.ImprimirFactura(r.Cells("cIdDocumento").Value, True, r.Cells("cPuntoVenta").Value, Caja)

                            Dim Cupones As Integer = Me.GetCupones(r.Cells("cId").Value)
                            If Cupones > 0 Then
                                Dim index As Integer = 0
                                While index < Cupones
                                    clsImpresion.Imprimir_Tiquete_Rifa(Caja, r.Cells("cIdDocumento").Value, r.Cells("cPuntoVenta").Value)
                                    index += 1
                                End While

                            End If

                        End If
                        If r.Cells("cTipo").Value = "ABO" Then
                            clsImpresion.ImprimirReciboDinero(r.Cells("cIdDocumento").Value, r.Cells("cPuntoVenta").Value, Me.Numero_Caja)
                        End If
                        If r.Cells("cTipo").Value = "APA" Then
                            clsImpresion.ImprimirApartado(r.Cells("cDocumento").Value, r.Cells("cPuntoVenta").Value, Me.Numero_Caja)
                            If CDec(r.Cells("cAbono").Value) > 0 Then
                                clsImpresion.ImprimirAbonoApartado2(r.Cells("cIdDocumento").Value, r.Cells("cPuntoVenta").Value, Me.Numero_Caja)
                            End If
                        End If
                    Next
                Catch ex As Exception
                    RegistrarLog(ex.StackTrace)
                End Try

                If frm.PasaVuelto > 0 Then

                    Dim frmVuelto As New frmVueltoCaja
                    frmVuelto.Vuelto = CDec(frm.PasaVuelto).ToString("N2")
                    frmVuelto.Pendiente = CDec(frm.lblTotalCobro.Text).ToString("N2")
                    frmVuelto.Pagocon = CDec(frm.lblPagado.Text).ToString("N2")

                    Try
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.Ejecutar("Insert into BitacoraVuelto(NApertura, Caja, Fecha, Documento, TotalCobro, TotalPagado, Vuelto) Values(" & NApertura & ", " & Me.Numero_Caja & ", GetDate(), '" & DocumentoVitacoraVuelto & "', " & frmVuelto.Pendiente & ", " & frmVuelto.Pagocon & ", " & frmVuelto.Vuelto & ")", CommandType.Text)
                    Catch ex As Exception
                    End Try

                    frmVuelto.ShowDialog()
                End If

                If NoEnviarPideFicha = False Then
                    Dim frmficha As New frmNumeroFicha
                    frmficha.CargarPrimerUsuario(Me.Id_Usuario)
                    frmficha.MdiParent = Me.MdiParent
                    frmficha.Show()
                End If
                Me.Close()

            End If
        End If
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        For Each row As DataGridViewRow In Me.viewFichas.Rows
            If row.Cells("cTipo").Value = "CRE" Then
                MsgBox("El tipo de documento es Credito, debe volver a generar la ficha.", MsgBoxStyle.Exclamation, "NO se puede realizar la operacion")
                Exit Sub
            End If
        Next
        Me.CobrarUnificado()
    End Sub

    Private CancelaEdicion As Boolean = True
    Private Sub viewFichas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewFichas.CellClick
        On Error Resume Next
        If Me.viewFichas.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False And e.ColumnIndex = Me.viewFichas.Columns("cFE").Index Then
            Dim fe As Boolean = IIf(CBool(Me.viewFichas.Rows(e.RowIndex).Cells("cFE").Value) = True, False, True)
            Me.CancelaEdicion = False
            Me.viewFichas.Rows(e.RowIndex).Cells("cFE").Value = fe
            Me.CancelaEdicion = True
            If fe = True Then
                If Me.viewFichas.Rows(e.RowIndex).Cells("cPuntoVenta").Value.ToString.ToLower = "taller" Then
                    Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "TCO"
                ElseIf Me.viewFichas.Rows(e.RowIndex).Cells("cPuntoVenta").Value.ToString.ToLower = "mascotas" Then
                    Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "MCO"
                Else
                    Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "CON"
                End If
            Else
                Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "PVE"
            End If
        End If

        If e.ColumnIndex = Me.viewFichas.Columns("cRenta").Index Then
            Dim renta As Boolean = IIf(CBool(Me.viewFichas.Rows(e.RowIndex).Cells("cRenta").Value) = True, False, True)
            Me.CancelaEdicion = False
            Me.viewFichas.Rows(e.RowIndex).Cells("cRenta").Value = renta
            Me.CancelaEdicion = True
            Me.CalcularTotales()
        End If

        If e.ColumnIndex = Me.viewFichas.Columns("cPendiente").Index Then
            If Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "MCO" Or Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "PVE" Or Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "TCO" Or Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "CON" Then
                Me.viewFichas.Rows(e.RowIndex).Cells("cPendiente").Value = IIf(Me.viewFichas.Rows(e.RowIndex).Cells("cPendiente").Value = True, False, True)
            End If
            Me.CalcularTotales()
        End If

        If e.ColumnIndex = Me.viewFichas.Columns("cExpress").Index Then
            If Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "MCO" Or Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "PVE" Or Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "TCO" Or Me.viewFichas.Rows(e.RowIndex).Cells("cTipo").Value = "CON" Then
                Me.viewFichas.Rows(e.RowIndex).Cells("cExpress").Value = IIf(Me.viewFichas.Rows(e.RowIndex).Cells("cExpress").Value = True, False, True)
            End If
            Me.CalcularTotales()
        End If
    End Sub

    Private Sub viewFichas_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles viewFichas.CellBeginEdit
        On Error Resume Next
        e.Cancel = Me.CancelaEdicion
    End Sub

    Private Function getRenta(_IdFactura As String)
        'la renta es el 2% del subtotal de la factura
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select (SubTotal - Descuento) * 0.02 as Renta from PreVentas where id = " & _IdFactura, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Renta")
        Else
            Return 0
        End If
    End Function

    Private Sub HabilitaRenta()
        For Each r As DataGridViewRow In Me.viewFichas.Rows
            If r.Cells("cTipo").Value = "PVE" Or _
                    r.Cells("cTipo").Value = "CON" Or _
                    r.Cells("cTipo").Value = "CRE" Or _
                    r.Cells("cTipo").Value = "TCO" Or _
                    r.Cells("cTipo").Value = "TCR" Or _
                    r.Cells("cTipo").Value = "MCO" Or _
                    r.Cells("cTipo").Value = "MCR" Then
                r.Cells("cRenta").ReadOnly = False
            End If
        Next        
    End Sub

    Private Sub CalcularTotales()
        Dim Cobrar, Pendiente, Renta As Decimal
        For Each r As DataGridViewRow In Me.viewFichas.Rows
            If r.Cells("cTipo").Value <> "APA" Then
                Renta = 0
                If r.Cells("cTipo").Value = "PVE" Or _
                    r.Cells("cTipo").Value = "CON" Or _
                    r.Cells("cTipo").Value = "CRE" Or _
                    r.Cells("cTipo").Value = "TCO" Or _
                    r.Cells("cTipo").Value = "TCR" Or _
                    r.Cells("cTipo").Value = "MCO" Or _
                    r.Cells("cTipo").Value = "MCR" Then
                    If r.Cells("cRenta").Value = True Then
                        'es una factura y tiene habilitada la opcion de renta
                        Renta = Me.getRenta(r.Cells("cId").Value)
                    End If
                End If

                If r.Cells("cPendiente").Value = True Or r.Cells("cExpress").Value = True Then
                    Pendiente += (CDec(r.Cells("cTotal").Value) - Renta)
                Else
                    Cobrar += (CDec(r.Cells("cTotal").Value) - Renta)
                End If
            Else
                Cobrar += CDec(r.Cells("cAbono").Value)
            End If
            
        Next
        Me.txtTotalCobro.Text = Cobrar.ToString("N2")
        Me.txtTotalPendiente.Text = Pendiente.ToString("N2")
    End Sub

End Class