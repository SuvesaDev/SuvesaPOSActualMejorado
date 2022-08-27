Imports LcPymes_5._2.Modulos
Imports System.Data
Imports System.Windows.Forms

Public Class frmFacturaElectronicaCompra
    Public IdCompra As Integer = 0
    Private IdProveedor As String = "0"
    Private Index As Integer = 0
    Private cls As New Modulos.FE.FACTURA_ELECTRONICA_COMPRA

    Private ListaMoneda() As Moneda = New Moneda() {New Moneda("CRC", "COLONES"), New Moneda("UDS", "DOLARES")}
    Private ListaUnidadMedida() As UnidadMedida = New UnidadMedida() {New UnidadMedida("Unid", "UNIDAD"), New UnidadMedida("kg", "KILOGRAMO"), New UnidadMedida("g", "GRAMO"), New UnidadMedida("L", "LITRO"), New UnidadMedida("mL", "MILILITRO"), New UnidadMedida("Oz", "ONZA"), New UnidadMedida("m", "METRO")}
    Private ListaCondicionVenta() As CondicionVenta = New CondicionVenta() {New CondicionVenta("01", "CONTADO"), New CondicionVenta("02", "CREDITO")}
    Private ListaFormaPago() As FormaPagos = New FormaPagos() {New FormaPagos("01", "EFECTIVO"), New FormaPagos("02", "TARJETA"), New FormaPagos("03", "CHEQUE"), New FormaPagos("04", "TRANSFERENCIA")}

    Private Sub CargarDatos_Compra(_IdCompra As Integer)

        Dim dtEncabezado As New DataTable
        Dim dtDetalle As New DataTable

        cFunciones.Llenar_Tabla_Generico("select p.CodigoProv, c.Factura, c.Fecha, Case c.TipoCompra when 'CRE' Then 'CREDITO' When 'CON' Then 'CONTADO' END AS Tipo , p.Cedula, p.nombre as Proveedor, p.Telefono1 as Telefono from compras c inner join Proveedores p on c.codigoprov = p.codigoprov where Id_Compra = " & _IdCompra, dtEncabezado, CadenaConexionSeePOS)
        cFunciones.Llenar_Tabla_Generico("select Impuesto_P, Cantidad, Descripcion, Base, Impuesto, Descuento from articulos_comprados where idcompra = " & _IdCompra, dtDetalle, CadenaConexionSeePOS)

        Me.IdProveedor = dtEncabezado.Rows(0).Item("CodigoProv")
        Me.txtCedula.Text = dtEncabezado.Rows(0).Item("Cedula").ToString.Replace("-", "")
        Me.BuscarCedula()
        Me.cboTipoIdentificacion.Text = ""
        Me.txtNombre.Text = dtEncabezado.Rows(0).Item("Proveedor")
        Me.txtTelefono.Text = dtEncabezado.Rows(0).Item("Telefono")

        Me.txtNumFactura.Text = dtEncabezado.Rows(0).Item("Factura")
        Me.dtpFecha.Value = dtEncabezado.Rows(0).Item("Fecha")
        Me.cboCondicionVenta.Text = dtEncabezado.Rows(0).Item("Tipo")

        Dim ID_IMPUESTO As Integer = 1
        For Each r As DataRow In dtDetalle.Rows
            Select Case CDec(r.Item("Impuesto_P"))
                Case 0 : ID_IMPUESTO = 1
                Case 1 : ID_IMPUESTO = 2
                Case 2 : ID_IMPUESTO = 3
                Case 4 : ID_IMPUESTO = 4
                Case 8 : ID_IMPUESTO = 7
                Case 13 : ID_IMPUESTO = 8
            End Select
            Me.AgregarLinea(r.Item("Cantidad"), "Unid", r.Item("Descripcion"), r.Item("Base"), r.Item("Descuento"), ID_IMPUESTO)
        Next

    End Sub

    Private Function NumeroRandom() As String
        Dim Generator As System.Random = New System.Random()
        Return CStr(Generator.Next(0, 99999999).ToString).PadLeft(8, "0")
    End Function

    Private Function GetCedula() As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select identificacion from Emisor", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("identificacion")
        Else
            Return ""
        End If
    End Function

    Private Sub GuardarFEC()
        'Agregar Validaciones 

        Dim Fecha() As String = Me.dtpFecha.Value.ToShortDateString.Split("/")
        Dim TipoProveedor As String = ""
        Dim Consecutivo As String = "0010000108" & CStr(Me.txtNumFactura.Text).PadLeft(10, "0")
        Dim clave As String = "506" & CStr(Fecha(0)).PadLeft(2, "0") & CStr(Fecha(1)).PadLeft(2, "0") & Fecha(2).Substring(2, 2) & Me.GetCedula.PadLeft(12, "0") & Consecutivo & CStr(1) & Me.NumeroRandom

        Select Case Me.cboTipoIdentificacion.SelectedIndex
            Case 0 : TipoProveedor = "01"
            Case 1 : TipoProveedor = "02"
            Case 2 : TipoProveedor = "03"
        End Select

        Dim db As OBSoluciones.SQL.Transaccion

        Try
            db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            db.Ejecutar("Update dbo.Proveedores set FEC = 1, Id_Provincia = " & Me.cboProvincia.SelectedValue & ", Id_Canton = " & Me.cboCanton.SelectedValue & ", Id_Distrito = " & Me.cboDistrito.SelectedValue & ", OtrasSenas = '" & Me.txtOtrasSenias.Text & "', CodigoActividad = '" & Me.cboActividadEconomica.SelectedValue & "', CorreoElectronico = '" & Me.txtCorreoElectronico.Text & "', TipoProveedor = '" & TipoProveedor & "', Cedula = '" & Me.txtCedula.Text & "', Nombre = '" & Me.txtNombre.Text & "' Where CodigoProv = " & Me.IdProveedor, CommandType.Text)
            db.Ejecutar("Update dbo.Compras Set FEC = 1, CodigoActividad = '" & Me.cboActividadEconomica.SelectedValue & "', EstadoDGT = 'pendiente', ConsecutivoDGT = '" & Consecutivo & "', ClaveDGT = '" & clave & "' Where Id_Compra = " & Me.IdCompra, CommandType.Text)
            db.Commit()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message, Text)
        End Try
    End Sub

    Private Function GetTarifa(_Id As Integer) As Decimal
        Dim dt As New DataTable
        dt = Me.cls.GET_IMPUESTOS
        Return (From x As DataRow In dt.Rows Where x.Item("ID_IMPUESTO") = _Id Select CDec(x.Item("PORCENTAJE"))).FirstOrDefault
    End Function

    Public Sub AgregarLinea(_Cantidad As Decimal, _Medida As String, _Detalle As String, _PrecioUnit As Decimal, _MontoDescuento As Decimal, _IdImpuesto As Integer)
        Dim Tarifa As Decimal = Me.GetTarifa(_IdImpuesto)
        Dim SubTotal As Decimal = (_Cantidad * _PrecioUnit)
        Dim MontoImpuesto As Decimal = SubTotal * (Tarifa / 100)
        Dim Total As Decimal = SubTotal - _MontoDescuento + MontoImpuesto

        With Me.viewDatelle
            .Rows.Add()
            .Item("cNumeroLinea", Me.Index).Value = Me.Index + 1
            .Item("cCantidad", Me.Index).Value = _Cantidad
            .Item("cUnidadMedida", Me.Index).Value = _Medida
            .Item("cDetalle", Me.Index).Value = _Detalle
            .Item("cPrecioUnitario", Me.Index).Value = _PrecioUnit
            .Item("cSubTotal", Me.Index).Value = SubTotal
            .Item("cMontoDescuento", Me.Index).Value = _MontoDescuento
            .Item("cId_Impuesto", Me.Index).Value = _IdImpuesto
            .Item("cTarifa", Me.Index).Value = Tarifa
            .Item("cMontoImpuesto", Me.Index).Value = MontoImpuesto
            .Item("cMontoTotalLinea", Me.Index).Value = Total
        End With
        Me.Index += 1
        Me.CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Dim Total As Decimal = (From x As DataGridViewRow In Me.viewDatelle.Rows Select CDec(x.Cells("cMontoTotalLinea").Value)).Sum
        Me.txtTotalCompra.Text = Total.ToString("N2")
    End Sub

    Private Sub InicializarFormulario()
        Me.cboMoneda.DataSource = Me.ListaMoneda
        Me.cboMoneda.DisplayMember = "Descripcion"
        Me.cboMoneda.ValueMember = "Simbolo"

        Me.cboUnidadMedida.DataSource = Me.ListaUnidadMedida
        Me.cboUnidadMedida.DisplayMember = "Descripcion"
        Me.cboUnidadMedida.ValueMember = "Simbolo"

        Me.cboCondicionVenta.DataSource = Me.ListaCondicionVenta
        Me.cboCondicionVenta.DisplayMember = "Condicion"
        Me.cboCondicionVenta.ValueMember = "Codigo"

        Me.cboFormaPago.DataSource = Me.ListaFormaPago
        Me.cboFormaPago.DisplayMember = "FormaPago"
        Me.cboFormaPago.ValueMember = "Codigo"

        Dim dtIVA As New DataTable
        dtIVA = Me.cls.GET_IMPUESTOS()
        Me.cboIVA.DataSource = dtIVA
        Me.cboIVA.DisplayMember = "IMPUESTO"
        Me.cboIVA.ValueMember = "ID_IMPUESTO"

        Me.Cargar_Provincias()
    End Sub

    Private Sub Cargar_Provincias()
        Dim dt As New DataTable
        dt = Me.cls.Obtener_Provincia
        Me.cboProvincia.DataSource = dt
        Me.cboProvincia.DisplayMember = "PROVINCIA"
        Me.cboProvincia.ValueMember = "ID_PROVINCIA"
        On Error Resume Next
        Me.cboProvincia.SelectedValue = 5
        Cargar_Cantones(Me.cboProvincia.SelectedValue)
    End Sub

    Private Sub Cargar_Cantones(_IdProvincia As Integer)
        Dim dt As New DataTable
        dt = Me.cls.Obtener_Canton(_IdProvincia)
        Me.cboCanton.DataSource = dt
        Me.cboCanton.DisplayMember = "CANTON"
        Me.cboCanton.ValueMember = "ID_CANTON"
        On Error Resume Next
        Cargar_Distrito(Me.cboProvincia.SelectedValue, Me.cboCanton.SelectedValue)
    End Sub

    Private Sub Cargar_Distrito(_IdProvincia As Integer, _IdCanton As Integer)
        Dim dt As New DataTable
        dt = Me.cls.Obtener_Distrito(_IdProvincia, _IdCanton)
        Me.cboDistrito.DataSource = dt
        Me.cboDistrito.DisplayMember = "DISTRITO"
        Me.cboDistrito.ValueMember = "ID_DISTRITO"
    End Sub

    Private Sub frmFacturaElectronicaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InicializarFormulario()
        If Me.IdCompra > 0 Then Me.CargarDatos_Compra(Me.IdCompra)
    End Sub

    Private Sub BuscarCedula()
        Try
            If Me.txtCedula.Text.Length >= 9 And Me.txtCedula.Text.Length <= 12 Then
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(Me.txtCedula.Text)
                Select Case ObtenerDatosCliente.tipoIdentificacion
                    Case "01" : Me.cboTipoIdentificacion.SelectedIndex = 0
                    Case "02" : Me.cboTipoIdentificacion.SelectedIndex = 1
                    Case "03" : Me.cboTipoIdentificacion.SelectedIndex = 2
                End Select

                Dim ListaActividades As New System.Collections.Generic.List(Of api.Hacienda.Actividade)
                Dim ac As New api.Hacienda.Actividade
                For Each a As api.Hacienda.Actividade In ObtenerDatosCliente.actividades
                    ac = New api.Hacienda.Actividade
                    ac.codigo = a.codigo
                    ac.descripcion = a.descripcion
                    ListaActividades.Add(ac)
                Next

                If ListaActividades.Count > 0 Then
                    Me.cboActividadEconomica.DataSource = ListaActividades.ToArray
                    Me.cboActividadEconomica.DisplayMember = "descripcion"
                    Me.cboActividadEconomica.ValueMember = "codigo"
                Else
                    Me.cboActividadEconomica.DataSource = Nothing
                End If

                Me.txtNombre.Text = ObtenerDatosCliente.nombre
                Me.cboTipoIdentificacion.Enabled = False
                Me.txtNombre.ReadOnly = True
            Else
                Me.cboTipoIdentificacion.SelectedIndex = 0
                Me.txtNombre.Text = ""
                Me.cboTipoIdentificacion.Enabled = True
                Me.txtNombre.ReadOnly = False
            End If
        Catch ex As Exception
            Me.cboTipoIdentificacion.SelectedIndex = 0
            Me.txtNombre.Text = ""
            Me.cboTipoIdentificacion.Enabled = True
            Me.txtNombre.ReadOnly = False
        End Try
    End Sub

    Private Sub btnBuscarCedula_Click(sender As Object, e As EventArgs) Handles btnBuscarCedula.Click
        Me.BuscarCedula()
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        On Error Resume Next
        Cargar_Cantones(Me.cboProvincia.SelectedValue)
    End Sub

    Private Sub cboCanton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCanton.SelectedIndexChanged
        On Error Resume Next
        Cargar_Distrito(Me.cboProvincia.SelectedValue, Me.cboCanton.SelectedValue)
    End Sub

    Private Function PasaValidaNumerica(_txt As TextBox, Optional ByVal _PuedeserCero As Boolean = False) As Boolean
        If _txt.Text <> "" Then
            If IsNumeric(_txt.Text) = True Then
                If CDec(_txt.Text) > 0 Then
                    Return True
                End If
                If CDec(_txt.Text) = 0 Then
                    If _PuedeserCero = True Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function
    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        If PasaValidaNumerica(Me.txtCantidad) = False Then
            Me.txtCantidad.Focus()
            Exit Sub
        End If
        If PasaValidaNumerica(Me.txtPrecioUnitario) = False Then
            Me.txtPrecioUnitario.Focus()
            Exit Sub
        End If
        If PasaValidaNumerica(Me.txtMontoDescuento, True) = False Then
            Me.txtMontoDescuento.Focus()
            Exit Sub
        End If
        If Me.txtDetalle.Text = "" Then
            Me.txtDetalle.Focus()
            Exit Sub
        End If
        Me.AgregarLinea(Me.txtCantidad.Text, Me.cboUnidadMedida.SelectedValue, Me.txtDetalle.Text, Me.txtPrecioUnitario.Text, Me.txtMontoDescuento.Text, Me.cboIVA.SelectedValue)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.GuardarFEC()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class

Public Structure Moneda
    Public Property Simbolo As String
    Public Property Descripcion As String
    Sub New(_Simbolo As String, _Descripcion As String)
        Me.Simbolo = _Simbolo
        Me.Descripcion = _Descripcion
    End Sub
End Structure
Public Structure UnidadMedida
    Public Property Simbolo As String
    Public Property Descripcion As String
    Sub New(_Simbolo As String, _Descripcion As String)
        Me.Simbolo = _Simbolo
        Me.Descripcion = _Descripcion
    End Sub
End Structure
Public Structure CondicionVenta
    Public Property Codigo As String
    Public Property Condicion As String
    Sub New(_Codigo As String, _Condicion As String)
        Me.Codigo = _Codigo
        Me.Condicion = _Condicion
    End Sub
End Structure
Public Structure FormaPagos
    Public Property Codigo As String
    Public Property FormaPago As String
    Sub New(_Codigo As String, _FormaPago As String)
        Me.Codigo = _Codigo
        Me.FormaPago = _FormaPago
    End Sub
End Structure
