Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Xml.Serialization
Imports System
Imports System.IO
Imports System.Xml
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Net
Imports System.Collections.Generic
Imports System.Threading

Public Class Facturacion
    Inherits System.Windows.Forms.Form


#Region "Variables"
    Dim Cant, PaginaActual As Integer
    Dim Cedula_usuario, TclCaja As String
    Dim Anula_Venta As Boolean
    Dim porcentaje_descuento As Double
    Dim Existencia As Double
    Dim perfil_administrador As Boolean
    Dim cliente_cargado As Boolean
    Dim Imp_Conf As Double ' almacena el impuesto d eventa traido de la tabla configuraciones
    Dim vende_existecias_negativas As Boolean
    Dim impuesto_cliente As Double
    Dim variacion_Punit As Double
    Dim Monto_Adeudado As Double
    Dim ayuda As Boolean
    Dim usua
    Dim max_aplicar As Double 'almacena el maximo porcentaje de descuento que se puede aplicar a determinado articulo
    Dim AgregandoNuevoItem As Boolean
    Dim buscando As Boolean = False
    'varibles de articulos
    Dim PrecioBase As Double
    Dim PrecioCosto As Double
    Dim Flete As Double
    Dim OtrosMontos As Double
    Dim PrecioA As Double
    Dim PrecioB As Double
    Dim PrecioC As Double
    Dim PrecioD As Double
    Dim ValorCosto As Double
    Dim ValorVenta As Double
    Dim MonedaCosto As Integer
    Dim MonedaVenta As Integer
    Dim MonedaBase As Integer
    Dim ValorBase As Double
    Dim MontoImpuesto As Double
    Dim precio_unitario As Double
    Dim Max_Descuento_Articulo As Double
    Dim promo_activa_valor As Boolean
    Dim precio_promo_valor As Double
    Dim monto_Perdido As Double
    Dim CConexion As New Conexion
    Dim mensaje As String ' almacena el mensaje de los descuentos
    Dim password_antiguo As String
    Dim logeado As Boolean
    Dim coti As Boolean
    Dim Importando As Boolean
    Dim Lote As Boolean = False
    Dim Cant_Actual As Double = 0
    Dim Id As Integer = 0
    Dim num_fact As Integer = 0
    Dim tipo_fact As String = ""
    'SELECCION DEL TIPO DE FACTURA.
    Dim Factura_reporte As New Factura_Personalizada  'FACTURA PERSONALIZADA
    Dim facturaPVE As New Reporte_FacturaPVEs
    Private rptGenerica As New Factura_Generica
    Dim rptTiquete As New rptTiqueteRifa2
    Dim cliente_normal As Boolean
    'Dim Factura As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim PMU As New PerfilModulo_Class 'clase de seguridad 
    Dim reimprimir As Boolean = False
    Dim esregalia As Boolean = False
    Dim codigo_cliente As String
    Dim nombre_cliente As String
    Dim imprime_cupon As Boolean
    Dim cantidad_cupon As Integer = 0




#Region " Variable "                 'Definicion de Variable 
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
    Private PorcCambiarPrecio As Double
    Private PorcDescuento As Double
    Private Anula As Boolean
    Private abierto As Boolean
    Private impuesto As Double
    Private max_credito As Double
    Private plazo_credito As Integer
    Private descuento As Double
    Private tipoprecio As Integer
    Private sinrestriccion As Boolean
    Private Exento As Double
    Private Gravado As Double
    Private DescuentoCalc As Double
    Friend WithEvents cbo_tipo_cliente As ComboBox
    Friend WithEvents txtNombreArt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ckFrecuente As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btn_cliente_nuevo As Button
    Friend WithEvents SqlDeleteCommand As SqlCommand
    Friend WithEvents SqlInsertCommand As SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlCommand
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lblListaPromocion As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAgregarExoneracion As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoComprobantes As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ckPedido As System.Windows.Forms.CheckBox
    Friend WithEvents txtMontoCupon As System.Windows.Forms.TextBox
    Friend WithEvents lblFicha As System.Windows.Forms.Label
    Friend WithEvents txtFicha As System.Windows.Forms.TextBox
    Friend WithEvents ckPD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnBuscarFicha As System.Windows.Forms.Button
    Friend WithEvents btnApliarCupon As System.Windows.Forms.Button
    Friend WithEvents btnRemplazar As System.Windows.Forms.Button
    Friend WithEvents opApartado As System.Windows.Forms.RadioButton
    Friend WithEvents btnCartaExoneracion As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnMAG As System.Windows.Forms.Button
    Private ImpuestoCalc As Double
#End Region

#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        AddHandler Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").PositionChanged, AddressOf Me.Position_Changed
        AddHandler Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CurrentChanged, AddressOf Me.Current_Changed
    End Sub


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtCostoBase As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtSGravado As System.Windows.Forms.TextBox
    Friend WithEvents txtSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImpVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCodArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImpVentaT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubtotalT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents opCredito As System.Windows.Forms.RadioButton
    Friend WithEvents opContado As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtSubtotalExcento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtmontodescuento As System.Windows.Forms.TextBox
    Friend WithEvents ToolBarAnular As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton

    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection

    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtFactura As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CkEntregado As System.Windows.Forms.CheckBox
    Friend WithEvents txtTelefono As ValidText.ValidText
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtorden As System.Windows.Forms.TextBox
    Friend WithEvents Txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Adapter_Clientes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtprecioCosto As System.Windows.Forms.TextBox

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl

    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMaxdescuento As System.Windows.Forms.TextBox
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Lb_SubExento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lb_Subgravado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Adapter_Encargados_Compra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label46 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtDiasPlazo As System.Windows.Forms.Label
    Friend WithEvents DtVence As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Txtcodmoneda_Venta As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TipoCambio_Valor_Compra As System.Windows.Forms.TextBox
    Friend WithEvents Label_Costobase As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Adapter_Ventas_Detalles As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Ventas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImportar As System.Windows.Forms.ToolBarButton

    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Configuraciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_Facturaciones As DataSet_Facturaciones
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Coti As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_CotiDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TxtUtilidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecio_Unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMonto_Descuento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMonto_Impuesto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubtotalGravado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubTotalExcento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LabelObs As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ck_Exonerar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents txtCod_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ck_Taller As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CbNumero As System.Windows.Forms.ComboBox
    Friend WithEvents LFVencimiento As System.Windows.Forms.Label
    Friend WithEvents LNumero As System.Windows.Forms.Label
    Friend WithEvents LVencimiento As System.Windows.Forms.Label
    Friend WithEvents LOpcion As System.Windows.Forms.Label
    Friend WithEvents AdapterLotes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LAnulada As System.Windows.Forms.Label
    Friend WithEvents txtHecho As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelado As System.Windows.Forms.Label
    Friend WithEvents Ck_Mascotas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtExisBod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblOpcionElegida As System.Windows.Forms.Label
    Friend WithEvents ToolBarExportar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ckpantalla As System.Windows.Forms.CheckBox
    Friend WithEvents adapter_clientes_frecuentes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ck_agente As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtagente As System.Windows.Forms.TextBox
    Friend WithEvents ck_promo3x1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtregalias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ToolBarDesanular As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.txtCostoBase = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBuscarFicha = New System.Windows.Forms.Button()
        Me.btnApliarCupon = New System.Windows.Forms.Button()
        Me.btnRemplazar = New System.Windows.Forms.Button()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.txtFicha = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.Label()
        Me.DataSet_Facturaciones = New LcPymes_5._2.DataSet_Facturaciones()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.txtMontoImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSGravado = New System.Windows.Forms.TextBox()
        Me.txtSubFamilia = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarExoneracion = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtregalias = New DevExpress.XtraEditors.TextEdit()
        Me.ck_promo3x1 = New System.Windows.Forms.CheckBox()
        Me.txtExisBod = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbNumero = New System.Windows.Forms.ComboBox()
        Me.LFVencimiento = New System.Windows.Forms.Label()
        Me.LNumero = New System.Windows.Forms.Label()
        Me.LVencimiento = New System.Windows.Forms.Label()
        Me.LOpcion = New System.Windows.Forms.Label()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreArt = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TxtUtilidad = New DevExpress.XtraEditors.TextEdit()
        Me.Label_Costobase = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtImpVenta = New DevExpress.XtraEditors.TextEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrecioUnit = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCod_Articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.ckPedido = New System.Windows.Forms.CheckBox()
        Me.ckpantalla = New System.Windows.Forms.CheckBox()
        Me.txtSExcento = New System.Windows.Forms.TextBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.txtFlete = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtMontoCupon = New System.Windows.Forms.TextBox()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.Ck_Exonerar = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New DevExpress.XtraEditors.TextEdit()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Lb_Subgravado = New DevExpress.XtraEditors.TextEdit()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Lb_SubExento = New DevExpress.XtraEditors.TextEdit()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImpVentaT = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoT = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubtotalT = New DevExpress.XtraEditors.TextEdit()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSubtotalExcento = New System.Windows.Forms.TextBox()
        Me.txtDiasPlazo = New System.Windows.Forms.Label()
        Me.opCredito = New System.Windows.Forms.RadioButton()
        Me.opContado = New System.Windows.Forms.RadioButton()
        Me.CkEntregado = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnMAG = New System.Windows.Forms.Button()
        Me.btnCartaExoneracion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCorreoComprobantes = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.btn_cliente_nuevo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckFrecuente = New DevExpress.XtraEditors.CheckEdit()
        Me.cbo_tipo_cliente = New System.Windows.Forms.ComboBox()
        Me.txtEncargado = New System.Windows.Forms.TextBox()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.LabelObs = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtTelefono = New ValidText.ValidText()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtMaxdescuento = New System.Windows.Forms.TextBox()
        Me.TxtprecioCosto = New System.Windows.Forms.TextBox()
        Me.txtmontodescuento = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolBarAnular = New System.Windows.Forms.ToolBarButton()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImportar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarExportar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarDesanular = New System.Windows.Forms.ToolBarButton()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtorden = New System.Windows.Forms.TextBox()
        Me.txtCancelado = New System.Windows.Forms.Label()
        Me.ckPD = New DevExpress.XtraEditors.CheckEdit()
        Me.txtagente = New System.Windows.Forms.TextBox()
        Me.ck_agente = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Ck_Taller = New DevExpress.XtraEditors.CheckEdit()
        Me.Ck_Mascotas = New DevExpress.XtraEditors.CheckEdit()
        Me.DtVence = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.Label()
        Me.Adapter_Clientes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Encargados_Compra = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.Txtcodmoneda_Venta = New System.Windows.Forms.TextBox()
        Me.Txt_TipoCambio_Valor_Compra = New System.Windows.Forms.TextBox()
        Me.Adapter_Ventas_Detalles = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Ventas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Configuraciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Coti = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_CotiDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.opApartado = New System.Windows.Forms.RadioButton()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.AdapterLotes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.LAnulada = New System.Windows.Forms.Label()
        Me.txtHecho = New System.Windows.Forms.TextBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblOpcionElegida = New System.Windows.Forms.Label()
        Me.adapter_clientes_frecuentes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblListaPromocion = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet_Facturaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtregalias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExisBod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_Exonerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ckFrecuente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ckPD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_agente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_Taller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_Mascotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCostoBase
        '
        Me.txtCostoBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostoBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoBase.Enabled = False
        Me.txtCostoBase.ForeColor = System.Drawing.Color.Blue
        Me.txtCostoBase.Location = New System.Drawing.Point(-367, 377)
        Me.txtCostoBase.Name = "txtCostoBase"
        Me.txtCostoBase.Size = New System.Drawing.Size(32, 16)
        Me.txtCostoBase.TabIndex = 168
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnBuscarFicha)
        Me.Panel2.Controls.Add(Me.btnApliarCupon)
        Me.Panel2.Controls.Add(Me.btnRemplazar)
        Me.Panel2.Controls.Add(Me.lblFicha)
        Me.Panel2.Controls.Add(Me.txtFicha)
        Me.Panel2.Controls.Add(Me.txtFactura)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtTipo)
        Me.Panel2.Location = New System.Drawing.Point(5, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(610, 39)
        Me.Panel2.TabIndex = 182
        '
        'btnBuscarFicha
        '
        Me.btnBuscarFicha.Image = Global.LcPymes_5._2.My.Resources.Resources.find
        Me.btnBuscarFicha.Location = New System.Drawing.Point(449, 3)
        Me.btnBuscarFicha.Name = "btnBuscarFicha"
        Me.btnBuscarFicha.Size = New System.Drawing.Size(36, 34)
        Me.btnBuscarFicha.TabIndex = 204
        Me.btnBuscarFicha.UseVisualStyleBackColor = True
        '
        'btnApliarCupon
        '
        Me.btnApliarCupon.Image = Global.LcPymes_5._2.My.Resources.Resources.money_delete1
        Me.btnApliarCupon.Location = New System.Drawing.Point(500, 3)
        Me.btnApliarCupon.Name = "btnApliarCupon"
        Me.btnApliarCupon.Size = New System.Drawing.Size(45, 34)
        Me.btnApliarCupon.TabIndex = 204
        Me.btnApliarCupon.UseVisualStyleBackColor = True
        '
        'btnRemplazar
        '
        Me.btnRemplazar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_refresh
        Me.btnRemplazar.Location = New System.Drawing.Point(560, 3)
        Me.btnRemplazar.Name = "btnRemplazar"
        Me.btnRemplazar.Size = New System.Drawing.Size(45, 34)
        Me.btnRemplazar.TabIndex = 204
        Me.btnRemplazar.UseVisualStyleBackColor = True
        '
        'lblFicha
        '
        Me.lblFicha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFicha.BackColor = System.Drawing.Color.White
        Me.lblFicha.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFicha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFicha.Location = New System.Drawing.Point(284, 5)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(87, 28)
        Me.lblFicha.TabIndex = 203
        Me.lblFicha.Text = "Ficha #"
        Me.lblFicha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFicha
        '
        Me.txtFicha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFicha.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFicha.Location = New System.Drawing.Point(373, 5)
        Me.txtFicha.Name = "txtFicha"
        Me.txtFicha.Size = New System.Drawing.Size(70, 30)
        Me.txtFicha.TabIndex = 202
        Me.txtFicha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFactura
        '
        Me.txtFactura.BackColor = System.Drawing.Color.White
        Me.txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Num_Factura", True))
        Me.txtFactura.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.ForeColor = System.Drawing.Color.Red
        Me.txtFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFactura.Location = New System.Drawing.Point(120, 5)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(152, 26)
        Me.txtFactura.TabIndex = 64
        Me.txtFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataSet_Facturaciones
        '
        Me.DataSet_Facturaciones.DataSetName = "DataSet_Facturaciones"
        Me.DataSet_Facturaciones.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_Facturaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 28)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Factura N°"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTipo
        '
        Me.TxtTipo.BackColor = System.Drawing.Color.White
        Me.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Tipo", True))
        Me.TxtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipo.ForeColor = System.Drawing.Color.Red
        Me.TxtTipo.Location = New System.Drawing.Point(141, 12)
        Me.TxtTipo.MaxLength = 25
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(32, 14)
        Me.TxtTipo.TabIndex = 193
        '
        'txtMontoImpuesto
        '
        Me.txtMontoImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoImpuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtMontoImpuesto.Location = New System.Drawing.Point(416, 272)
        Me.txtMontoImpuesto.Name = "txtMontoImpuesto"
        Me.txtMontoImpuesto.Size = New System.Drawing.Size(24, 13)
        Me.txtMontoImpuesto.TabIndex = 165
        '
        'txtSGravado
        '
        Me.txtSGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSGravado.ForeColor = System.Drawing.Color.Blue
        Me.txtSGravado.Location = New System.Drawing.Point(224, 272)
        Me.txtSGravado.Name = "txtSGravado"
        Me.txtSGravado.Size = New System.Drawing.Size(40, 13)
        Me.txtSGravado.TabIndex = 166
        '
        'txtSubFamilia
        '
        Me.txtSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtSubFamilia.Location = New System.Drawing.Point(448, 272)
        Me.txtSubFamilia.Name = "txtSubFamilia"
        Me.txtSubFamilia.Size = New System.Drawing.Size(24, 13)
        Me.txtSubFamilia.TabIndex = 167
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btnAgregarExoneracion)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtregalias)
        Me.GroupBox3.Controls.Add(Me.ck_promo3x1)
        Me.GroupBox3.Controls.Add(Me.txtExisBod)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.CbNumero)
        Me.GroupBox3.Controls.Add(Me.LFVencimiento)
        Me.GroupBox3.Controls.Add(Me.LNumero)
        Me.GroupBox3.Controls.Add(Me.LVencimiento)
        Me.GroupBox3.Controls.Add(Me.LOpcion)
        Me.GroupBox3.Controls.Add(Me.txtExistencia)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtNombreArt)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.TxtUtilidad)
        Me.GroupBox3.Controls.Add(Me.Label_Costobase)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Controls.Add(Me.txtImpVenta)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPrecioUnit)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtCod_Articulo)
        Me.GroupBox3.Controls.Add(Me.txtCodArticulo)
        Me.GroupBox3.Controls.Add(Me.ckPedido)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(7, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(885, 86)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Artículos a Cotizar"
        '
        'btnAgregarExoneracion
        '
        Me.btnAgregarExoneracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarExoneracion.Enabled = False
        Me.btnAgregarExoneracion.Location = New System.Drawing.Point(543, 18)
        Me.btnAgregarExoneracion.Name = "btnAgregarExoneracion"
        Me.btnAgregarExoneracion.Size = New System.Drawing.Size(26, 14)
        Me.btnAgregarExoneracion.TabIndex = 202
        Me.btnAgregarExoneracion.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(637, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 14)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = "Regalias"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtregalias
        '
        Me.txtregalias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtregalias.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas_Detalle.regalias", True))
        Me.txtregalias.EditValue = "0"
        Me.txtregalias.Location = New System.Drawing.Point(693, 56)
        Me.txtregalias.Name = "txtregalias"
        '
        '
        '
        Me.txtregalias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtregalias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtregalias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtregalias.Properties.Enabled = False
        Me.txtregalias.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtregalias.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtregalias.Size = New System.Drawing.Size(56, 18)
        Me.txtregalias.TabIndex = 209
        '
        'ck_promo3x1
        '
        Me.ck_promo3x1.Location = New System.Drawing.Point(624, 96)
        Me.ck_promo3x1.Name = "ck_promo3x1"
        Me.ck_promo3x1.Size = New System.Drawing.Size(104, 16)
        Me.ck_promo3x1.TabIndex = 208
        Me.ck_promo3x1.Text = "Promo3x1"
        '
        'txtExisBod
        '
        Me.txtExisBod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExisBod.EditValue = 0
        Me.txtExisBod.Location = New System.Drawing.Point(837, 56)
        Me.txtExisBod.Name = "txtExisBod"
        '
        '
        '
        Me.txtExisBod.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtExisBod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExisBod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExisBod.Properties.ReadOnly = True
        Me.txtExisBod.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Purple, System.Drawing.Color.White)
        Me.txtExisBod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExisBod.Size = New System.Drawing.Size(40, 18)
        Me.txtExisBod.TabIndex = 207
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Purple
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(765, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 206
        Me.Label8.Text = "Exist. Bod."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CbNumero
        '
        Me.CbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNumero.Enabled = False
        Me.CbNumero.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbNumero.ItemHeight = 16
        Me.CbNumero.Location = New System.Drawing.Point(168, 56)
        Me.CbNumero.Name = "CbNumero"
        Me.CbNumero.Size = New System.Drawing.Size(160, 24)
        Me.CbNumero.TabIndex = 205
        Me.CbNumero.Visible = False
        '
        'LFVencimiento
        '
        Me.LFVencimiento.BackColor = System.Drawing.SystemColors.Control
        Me.LFVencimiento.Enabled = False
        Me.LFVencimiento.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFVencimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LFVencimiento.Location = New System.Drawing.Point(440, 56)
        Me.LFVencimiento.Name = "LFVencimiento"
        Me.LFVencimiento.Size = New System.Drawing.Size(96, 16)
        Me.LFVencimiento.TabIndex = 204
        Me.LFVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LNumero
        '
        Me.LNumero.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LNumero.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LNumero.Location = New System.Drawing.Point(88, 56)
        Me.LNumero.Name = "LNumero"
        Me.LNumero.Size = New System.Drawing.Size(76, 17)
        Me.LNumero.TabIndex = 203
        Me.LNumero.Text = "Número"
        Me.LNumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LNumero.Visible = False
        '
        'LVencimiento
        '
        Me.LVencimiento.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LVencimiento.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVencimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LVencimiento.Location = New System.Drawing.Point(344, 56)
        Me.LVencimiento.Name = "LVencimiento"
        Me.LVencimiento.Size = New System.Drawing.Size(84, 17)
        Me.LVencimiento.TabIndex = 202
        Me.LVencimiento.Text = "Vencimiento"
        Me.LVencimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LVencimiento.Visible = False
        '
        'LOpcion
        '
        Me.LOpcion.BackColor = System.Drawing.Color.White
        Me.LOpcion.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOpcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LOpcion.Location = New System.Drawing.Point(8, 56)
        Me.LOpcion.Name = "LOpcion"
        Me.LOpcion.Size = New System.Drawing.Size(76, 13)
        Me.LOpcion.TabIndex = 201
        Me.LOpcion.Text = "Opcion"
        Me.LOpcion.Visible = False
        '
        'txtExistencia
        '
        Me.txtExistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExistencia.EditValue = 0
        Me.txtExistencia.Location = New System.Drawing.Point(645, 32)
        Me.txtExistencia.Name = "txtExistencia"
        '
        '
        '
        Me.txtExistencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtExistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtExistencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExistencia.Size = New System.Drawing.Size(40, 18)
        Me.txtExistencia.TabIndex = 195
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(637, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Exist."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Moneda.Simbolo", True))
        Me.Label31.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(485, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 14)
        Me.Label31.TabIndex = 23
        Me.Label31.Text = "M"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(309, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 190
        Me.Label11.Text = "M"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreArt.BackColor = System.Drawing.Color.Green
        Me.txtNombreArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreArt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArt.ForeColor = System.Drawing.Color.White
        Me.txtNombreArt.Location = New System.Drawing.Point(120, 0)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(765, 16)
        Me.txtNombreArt.TabIndex = 3
        '
        'Label50
        '
        Me.Label50.AccessibleDescription = ""
        Me.Label50.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label50.Location = New System.Drawing.Point(333, 18)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 14)
        Me.Label50.TabIndex = 193
        Me.Label50.Text = "Utilidad (%)"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label50.Visible = False
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUtilidad.EditValue = "0"
        Me.TxtUtilidad.Location = New System.Drawing.Point(333, 32)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        '
        '
        '
        Me.TxtUtilidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUtilidad.Properties.DisplayFormat.FormatString = "#,#0.00%"
        Me.TxtUtilidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.TxtUtilidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidad.Size = New System.Drawing.Size(72, 18)
        Me.TxtUtilidad.TabIndex = 192
        Me.TxtUtilidad.ToolTip = "Porcentaje de Utilidad."
        Me.TxtUtilidad.Visible = False
        '
        'Label_Costobase
        '
        Me.Label_Costobase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Costobase.BackColor = System.Drawing.Color.White
        Me.Label_Costobase.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Costobase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_Costobase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Costobase.Location = New System.Drawing.Point(261, 32)
        Me.Label_Costobase.Name = "Label_Costobase"
        Me.Label_Costobase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_Costobase.Size = New System.Drawing.Size(64, 17)
        Me.Label_Costobase.TabIndex = 169
        Me.Label_Costobase.Text = "0"
        Me.Label_Costobase.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(261, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 14)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "P. Base:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Green
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(0, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 16)
        Me.Label28.TabIndex = 156
        Me.Label28.Text = "Artículo a Facturar"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.EditValue = "0.00"
        Me.txtSubtotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotal.Location = New System.Drawing.Point(756, 32)
        Me.txtSubtotal.Name = "txtSubtotal"
        '
        '
        '
        Me.txtSubtotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotal.Properties.Enabled = False
        Me.txtSubtotal.Properties.ReadOnly = True
        Me.txtSubtotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(120, 18)
        Me.txtSubtotal.TabIndex = 155
        '
        'txtImpVenta
        '
        Me.txtImpVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImpVenta.EditValue = "0"
        Me.txtImpVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVenta.Location = New System.Drawing.Point(509, 32)
        Me.txtImpVenta.Name = "txtImpVenta"
        '
        '
        '
        Me.txtImpVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVenta.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVenta.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtImpVenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVenta.Properties.Enabled = False
        Me.txtImpVenta.Properties.ReadOnly = True
        Me.txtImpVenta.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtImpVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVenta.Size = New System.Drawing.Size(58, 18)
        Me.txtImpVenta.TabIndex = 154
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(862, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 14)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "M"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(756, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 14)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "SubTotal"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(501, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "I.V.(%)"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(573, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 14)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Desc. (%)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPrecioUnit
        '
        Me.txtPrecioUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioUnit.EditValue = 0
        Me.txtPrecioUnit.Location = New System.Drawing.Point(413, 32)
        Me.txtPrecioUnit.Name = "txtPrecioUnit"
        '
        '
        '
        Me.txtPrecioUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.MaxLength = 25
        Me.txtPrecioUnit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtPrecioUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrecioUnit.Size = New System.Drawing.Size(80, 18)
        Me.txtPrecioUnit.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(413, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 14)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Precio Unit."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.EditValue = 0
        Me.txtCantidad.Location = New System.Drawing.Point(693, 32)
        Me.txtCantidad.Name = "txtCantidad"
        '
        '
        '
        Me.txtCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCantidad.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCantidad.Size = New System.Drawing.Size(56, 18)
        Me.txtCantidad.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(689, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 14)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Cantidad"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.EditValue = "0"
        Me.txtDescuento.Location = New System.Drawing.Point(573, 32)
        Me.txtDescuento.Name = "txtDescuento"
        '
        '
        '
        Me.txtDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuento.Size = New System.Drawing.Size(64, 18)
        Me.txtDescuento.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(7, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Código"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCod_Articulo
        '
        Me.txtCod_Articulo.EditValue = ""
        Me.txtCod_Articulo.Location = New System.Drawing.Point(8, 34)
        Me.txtCod_Articulo.Name = "txtCod_Articulo"
        '
        '
        '
        Me.txtCod_Articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCod_Articulo.Properties.MaxLength = 19
        Me.txtCod_Articulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtCod_Articulo.Size = New System.Drawing.Size(156, 20)
        Me.txtCod_Articulo.TabIndex = 196
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodArticulo.EditValue = ""
        Me.txtCodArticulo.Location = New System.Drawing.Point(8, 32)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        '
        '
        '
        Me.txtCodArticulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCodArticulo.Properties.MaxLength = 19
        Me.txtCodArticulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtCodArticulo.Size = New System.Drawing.Size(398, 18)
        Me.txtCodArticulo.TabIndex = 5
        '
        'ckPedido
        '
        Me.ckPedido.AutoSize = True
        Me.ckPedido.Font = New System.Drawing.Font("Trebuchet MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPedido.Location = New System.Drawing.Point(107, 17)
        Me.ckPedido.Name = "ckPedido"
        Me.ckPedido.Size = New System.Drawing.Size(54, 19)
        Me.ckPedido.TabIndex = 211
        Me.ckPedido.Text = "Pedido"
        Me.ckPedido.UseVisualStyleBackColor = True
        '
        'ckpantalla
        '
        Me.ckpantalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckpantalla.BackColor = System.Drawing.SystemColors.Control
        Me.ckpantalla.Enabled = False
        Me.ckpantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckpantalla.ForeColor = System.Drawing.Color.Red
        Me.ckpantalla.Location = New System.Drawing.Point(746, 282)
        Me.ckpantalla.Name = "ckpantalla"
        Me.ckpantalla.Size = New System.Drawing.Size(56, 13)
        Me.ckpantalla.TabIndex = 200
        Me.ckpantalla.Text = "Notas"
        Me.ckpantalla.UseVisualStyleBackColor = False
        '
        'txtSExcento
        '
        Me.txtSExcento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSExcento.ForeColor = System.Drawing.Color.Blue
        Me.txtSExcento.Location = New System.Drawing.Point(-287, 377)
        Me.txtSExcento.Name = "txtSExcento"
        Me.txtSExcento.Size = New System.Drawing.Size(48, 16)
        Me.txtSExcento.TabIndex = 17
        '
        'txtOtros
        '
        Me.txtOtros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtros.ForeColor = System.Drawing.Color.Blue
        Me.txtOtros.Location = New System.Drawing.Point(384, 272)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(24, 13)
        Me.txtOtros.TabIndex = 170
        '
        'txtFlete
        '
        Me.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFlete.ForeColor = System.Drawing.Color.Blue
        Me.txtFlete.Location = New System.Drawing.Point(272, 272)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(32, 13)
        Me.txtFlete.TabIndex = 169
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtMontoCupon)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.Ck_Exonerar)
        Me.GroupBox4.Controls.Add(Me.SimpleButton1)
        Me.GroupBox4.Controls.Add(Me.Label44)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Controls.Add(Me.Label47)
        Me.GroupBox4.Controls.Add(Me.SimpleButton2)
        Me.GroupBox4.Controls.Add(Me.Label43)
        Me.GroupBox4.Controls.Add(Me.Lb_Subgravado)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Lb_SubExento)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtImpVentaT)
        Me.GroupBox4.Controls.Add(Me.txtDescuentoT)
        Me.GroupBox4.Controls.Add(Me.txtSubtotalT)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtSubtotalExcento)
        Me.GroupBox4.Controls.Add(Me.txtCostoBase)
        Me.GroupBox4.Controls.Add(Me.txtSExcento)
        Me.GroupBox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(897, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 414)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'txtMontoCupon
        '
        Me.txtMontoCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtMontoCupon.Location = New System.Drawing.Point(15, 268)
        Me.txtMontoCupon.Name = "txtMontoCupon"
        Me.txtMontoCupon.ReadOnly = True
        Me.txtMontoCupon.Size = New System.Drawing.Size(188, 22)
        Me.txtMontoCupon.TabIndex = 193
        Me.txtMontoCupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.EditValue = "0.00"
        Me.txtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotal.Location = New System.Drawing.Point(12, 368)
        Me.txtTotal.Name = "txtTotal"
        '
        '
        '
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)))
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(202, 41)
        Me.txtTotal.TabIndex = 29
        '
        'Ck_Exonerar
        '
        Me.Ck_Exonerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Exonerar.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Exonerar", True))
        Me.Ck_Exonerar.EditValue = False
        Me.Ck_Exonerar.Location = New System.Drawing.Point(13, 312)
        Me.Ck_Exonerar.Name = "Ck_Exonerar"
        '
        '
        '
        Me.Ck_Exonerar.Properties.Caption = "Exonerar"
        Me.Ck_Exonerar.Properties.Enabled = False
        Me.Ck_Exonerar.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Red)
        Me.Ck_Exonerar.Size = New System.Drawing.Size(82, 21)
        Me.Ck_Exonerar.TabIndex = 192
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(13, 298)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(19, 19)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.Gray)
        Me.SimpleButton1.TabIndex = 191
        Me.SimpleButton1.Text = "T"
        Me.SimpleButton1.Visible = False
        '
        'Label44
        '
        Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label44.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label44.Location = New System.Drawing.Point(38, 390)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(16, 18)
        Me.Label44.TabIndex = 190
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label46
        '
        Me.Label46.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label46.EditValue = "0.00"
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(97, 298)
        Me.Label46.Name = "Label46"
        '
        '
        '
        Me.Label46.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Label46.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Label46.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label46.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Label46.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label46.Properties.ReadOnly = True
        Me.Label46.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label46.Size = New System.Drawing.Size(40, 22)
        Me.Label46.TabIndex = 189
        Me.Label46.Visible = False
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label47.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label47.Location = New System.Drawing.Point(17, 247)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 17)
        Me.Label47.TabIndex = 188
        Me.Label47.Text = "Monto Cupon"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Enabled = False
        Me.SimpleButton2.Location = New System.Drawing.Point(13, 155)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(19, 19)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.Gray)
        Me.SimpleButton2.TabIndex = 187
        Me.SimpleButton2.Text = "D"
        '
        'Label43
        '
        Me.Label43.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label43.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label43.Location = New System.Drawing.Point(-487, 393)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 18)
        Me.Label43.TabIndex = 39
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lb_Subgravado
        '
        Me.Lb_Subgravado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Subgravado.EditValue = "0.00"
        Me.Lb_Subgravado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_Subgravado.Location = New System.Drawing.Point(14, 44)
        Me.Lb_Subgravado.Name = "Lb_Subgravado"
        '
        '
        '
        Me.Lb_Subgravado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.ReadOnly = True
        Me.Lb_Subgravado.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.Lb_Subgravado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_Subgravado.Size = New System.Drawing.Size(189, 22)
        Me.Lb_Subgravado.TabIndex = 38
        '
        'Label45
        '
        Me.Label45.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(11, 25)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 18)
        Me.Label45.TabIndex = 37
        Me.Label45.Text = "Sub. Gravado"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(-389, 393)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 18)
        Me.Label29.TabIndex = 36
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lb_SubExento
        '
        Me.Lb_SubExento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_SubExento.EditValue = "0.00"
        Me.Lb_SubExento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_SubExento.Location = New System.Drawing.Point(14, 87)
        Me.Lb_SubExento.Name = "Lb_SubExento"
        '
        '
        '
        Me.Lb_SubExento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Lb_SubExento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.ReadOnly = True
        Me.Lb_SubExento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.Lb_SubExento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_SubExento.Size = New System.Drawing.Size(189, 22)
        Me.Lb_SubExento.TabIndex = 35
        '
        'Label42
        '
        Me.Label42.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label42.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label42.Location = New System.Drawing.Point(11, 70)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(110, 17)
        Me.Label42.TabIndex = 34
        Me.Label42.Text = "Sub. Exento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(12, 337)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(202, 30)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "TOTAL"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(147, 385)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 18)
        Me.Label35.TabIndex = 33
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(-82, 394)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 18)
        Me.Label34.TabIndex = 32
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(-186, 394)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 18)
        Me.Label33.TabIndex = 31
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(-287, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtImpVentaT
        '
        Me.txtImpVentaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImpVentaT.EditValue = "0.00"
        Me.txtImpVentaT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVentaT.Location = New System.Drawing.Point(14, 219)
        Me.txtImpVentaT.Name = "txtImpVentaT"
        '
        '
        '
        Me.txtImpVentaT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtImpVentaT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.ReadOnly = True
        Me.txtImpVentaT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtImpVentaT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVentaT.Size = New System.Drawing.Size(189, 22)
        Me.txtImpVentaT.TabIndex = 28
        '
        'txtDescuentoT
        '
        Me.txtDescuentoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoT.EditValue = "0.00"
        Me.txtDescuentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDescuentoT.Location = New System.Drawing.Point(14, 177)
        Me.txtDescuentoT.Name = "txtDescuentoT"
        '
        '
        '
        Me.txtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.ReadOnly = True
        Me.txtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoT.Size = New System.Drawing.Size(189, 22)
        Me.txtDescuentoT.TabIndex = 27
        '
        'txtSubtotalT
        '
        Me.txtSubtotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotalT.EditValue = "0.00"
        Me.txtSubtotalT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotalT.Location = New System.Drawing.Point(14, 130)
        Me.txtSubtotalT.Name = "txtSubtotalT"
        '
        '
        '
        Me.txtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtSubtotalT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.ReadOnly = True
        Me.txtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.txtSubtotalT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotalT.Size = New System.Drawing.Size(189, 22)
        Me.txtSubtotalT.TabIndex = 26
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(12, 199)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 18)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imp. Venta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(30, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 18)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "escuento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(11, 113)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "SubTotal"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotalExcento
        '
        Me.txtSubtotalExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotalExcento.Enabled = False
        Me.txtSubtotalExcento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalExcento.ForeColor = System.Drawing.Color.Blue
        Me.txtSubtotalExcento.Location = New System.Drawing.Point(80, -28)
        Me.txtSubtotalExcento.Name = "txtSubtotalExcento"
        Me.txtSubtotalExcento.Size = New System.Drawing.Size(48, 13)
        Me.txtSubtotalExcento.TabIndex = 177
        Me.txtSubtotalExcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasPlazo
        '
        Me.txtDiasPlazo.BackColor = System.Drawing.Color.Transparent
        Me.txtDiasPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDiasPlazo.ForeColor = System.Drawing.Color.Gray
        Me.txtDiasPlazo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDiasPlazo.Location = New System.Drawing.Point(274, 3)
        Me.txtDiasPlazo.Name = "txtDiasPlazo"
        Me.txtDiasPlazo.Size = New System.Drawing.Size(32, 20)
        Me.txtDiasPlazo.TabIndex = 157
        Me.txtDiasPlazo.Text = "0"
        Me.txtDiasPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtDiasPlazo.Visible = False
        '
        'opCredito
        '
        Me.opCredito.AutoSize = True
        Me.opCredito.BackColor = System.Drawing.Color.Transparent
        Me.opCredito.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.opCredito.Location = New System.Drawing.Point(186, 1)
        Me.opCredito.Name = "opCredito"
        Me.opCredito.Size = New System.Drawing.Size(78, 24)
        Me.opCredito.TabIndex = 1
        Me.opCredito.Text = "Crédito"
        Me.opCredito.UseVisualStyleBackColor = False
        '
        'opContado
        '
        Me.opContado.AutoSize = True
        Me.opContado.BackColor = System.Drawing.Color.Transparent
        Me.opContado.Checked = True
        Me.opContado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opContado.ForeColor = System.Drawing.Color.Red
        Me.opContado.Location = New System.Drawing.Point(100, 1)
        Me.opContado.Name = "opContado"
        Me.opContado.Size = New System.Drawing.Size(84, 24)
        Me.opContado.TabIndex = 0
        Me.opContado.TabStop = True
        Me.opContado.Text = "Contado"
        Me.opContado.UseVisualStyleBackColor = False
        '
        'CkEntregado
        '
        Me.CkEntregado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CkEntregado.BackColor = System.Drawing.SystemColors.Control
        Me.CkEntregado.Enabled = False
        Me.CkEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkEntregado.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.CkEntregado.Location = New System.Drawing.Point(276, 531)
        Me.CkEntregado.Name = "CkEntregado"
        Me.CkEntregado.Size = New System.Drawing.Size(83, 16)
        Me.CkEntregado.TabIndex = 156
        Me.CkEntregado.Text = "Entregado"
        Me.CkEntregado.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(364, 531)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 16)
        Me.CheckBox1.TabIndex = 155
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.btnMAG)
        Me.GroupBox6.Controls.Add(Me.btnCartaExoneracion)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.txtCorreoComprobantes)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Controls.Add(Me.txt_cedula)
        Me.GroupBox6.Controls.Add(Me.btn_cliente_nuevo)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.ckFrecuente)
        Me.GroupBox6.Controls.Add(Me.cbo_tipo_cliente)
        Me.GroupBox6.Controls.Add(Me.txtEncargado)
        Me.GroupBox6.Controls.Add(Me.Txtdireccion)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox6.Controls.Add(Me.LabelObs)
        Me.GroupBox6.Controls.Add(Me.Label41)
        Me.GroupBox6.Controls.Add(Me.txtTelefono)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtcodigo)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(5, 44)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(630, 133)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Cliente"
        '
        'btnMAG
        '
        Me.btnMAG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMAG.BackColor = System.Drawing.SystemColors.Control
        Me.btnMAG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMAG.ForeColor = System.Drawing.Color.White
        Me.btnMAG.Image = Global.LcPymes_5._2.My.Resources.Resources.icons8_vaca_16
        Me.btnMAG.Location = New System.Drawing.Point(551, 26)
        Me.btnMAG.Name = "btnMAG"
        Me.btnMAG.Size = New System.Drawing.Size(23, 26)
        Me.btnMAG.TabIndex = 195
        Me.btnMAG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMAG.UseVisualStyleBackColor = False
        '
        'btnCartaExoneracion
        '
        Me.btnCartaExoneracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCartaExoneracion.BackColor = System.Drawing.SystemColors.Control
        Me.btnCartaExoneracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCartaExoneracion.ForeColor = System.Drawing.Color.White
        Me.btnCartaExoneracion.Image = Global.LcPymes_5._2.My.Resources.Resources.iconfinder_65_5027859
        Me.btnCartaExoneracion.Location = New System.Drawing.Point(577, 26)
        Me.btnCartaExoneracion.Name = "btnCartaExoneracion"
        Me.btnCartaExoneracion.Size = New System.Drawing.Size(23, 26)
        Me.btnCartaExoneracion.TabIndex = 194
        Me.btnCartaExoneracion.Text = "+"
        Me.btnCartaExoneracion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCartaExoneracion.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.LcPymes_5._2.My.Resources.Resources.page_edit
        Me.Button1.Location = New System.Drawing.Point(597, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 26)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "+"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtCorreoComprobantes
        '
        Me.txtCorreoComprobantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreoComprobantes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreoComprobantes.Enabled = False
        Me.txtCorreoComprobantes.ForeColor = System.Drawing.Color.Blue
        Me.txtCorreoComprobantes.Location = New System.Drawing.Point(364, 108)
        Me.txtCorreoComprobantes.Name = "txtCorreoComprobantes"
        Me.txtCorreoComprobantes.Size = New System.Drawing.Size(228, 20)
        Me.txtCorreoComprobantes.TabIndex = 172
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gray
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(364, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(172, 14)
        Me.Label19.TabIndex = 171
        Me.Label19.Text = "Correo Comprobantes"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gray
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(101, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 14)
        Me.Label18.TabIndex = 170
        Me.Label18.Text = "Telefono"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Nombre_Cliente", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Red
        Me.txtNombre.Location = New System.Drawing.Point(240, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(305, 21)
        Me.txtNombre.TabIndex = 1
        '
        'txt_cedula
        '
        Me.txt_cedula.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_cedula.Location = New System.Drawing.Point(13, 30)
        Me.txt_cedula.MaxLength = 20
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(120, 20)
        Me.txt_cedula.TabIndex = 169
        '
        'btn_cliente_nuevo
        '
        Me.btn_cliente_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cliente_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cliente_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cliente_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_cliente_nuevo.Image = Global.LcPymes_5._2.My.Resources.Resources.page_add
        Me.btn_cliente_nuevo.Location = New System.Drawing.Point(604, 26)
        Me.btn_cliente_nuevo.Name = "btn_cliente_nuevo"
        Me.btn_cliente_nuevo.Size = New System.Drawing.Size(22, 26)
        Me.btn_cliente_nuevo.TabIndex = 168
        Me.btn_cliente_nuevo.Text = "+"
        Me.btn_cliente_nuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cliente_nuevo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(8, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 14)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Cedula"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckFrecuente
        '
        Me.ckFrecuente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckFrecuente.EditValue = False
        Me.ckFrecuente.Location = New System.Drawing.Point(55, 12)
        Me.ckFrecuente.Name = "ckFrecuente"
        '
        '
        '
        Me.ckFrecuente.Properties.Caption = "Frecuente"
        Me.ckFrecuente.Properties.Enabled = False
        Me.ckFrecuente.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Gray)
        Me.ckFrecuente.Size = New System.Drawing.Size(78, 20)
        Me.ckFrecuente.TabIndex = 193
        '
        'cbo_tipo_cliente
        '
        Me.cbo_tipo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_cliente.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_cliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbo_tipo_cliente.FormattingEnabled = True
        Me.cbo_tipo_cliente.Items.AddRange(New Object() {"FISICA", "JURIDICA", "DIMEX"})
        Me.cbo_tipo_cliente.Location = New System.Drawing.Point(135, 28)
        Me.cbo_tipo_cliente.Name = "cbo_tipo_cliente"
        Me.cbo_tipo_cliente.Size = New System.Drawing.Size(104, 24)
        Me.cbo_tipo_cliente.TabIndex = 165
        '
        'txtEncargado
        '
        Me.txtEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEncargado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEncargado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Cod_Encargado_Compra", True))
        Me.txtEncargado.Enabled = False
        Me.txtEncargado.ForeColor = System.Drawing.Color.Blue
        Me.txtEncargado.Location = New System.Drawing.Point(521, 71)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(101, 20)
        Me.txtEncargado.TabIndex = 164
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Direccion", True))
        Me.Txtdireccion.ForeColor = System.Drawing.Color.Blue
        Me.Txtdireccion.Location = New System.Drawing.Point(80, 71)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(436, 20)
        Me.Txtdireccion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(77, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(398, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Dirección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Observaciones", True))
        Me.TxtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.TxtObservaciones.Location = New System.Drawing.Point(11, 108)
        Me.TxtObservaciones.MaxLength = 500
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(349, 20)
        Me.TxtObservaciones.TabIndex = 163
        '
        'LabelObs
        '
        Me.LabelObs.BackColor = System.Drawing.Color.Transparent
        Me.LabelObs.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObs.ForeColor = System.Drawing.Color.Gray
        Me.LabelObs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelObs.Location = New System.Drawing.Point(6, 92)
        Me.LabelObs.Name = "LabelObs"
        Me.LabelObs.Size = New System.Drawing.Size(96, 14)
        Me.LabelObs.TabIndex = 162
        Me.LabelObs.Text = "Observaciones"
        Me.LabelObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Gray
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(517, 55)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(102, 14)
        Me.Label41.TabIndex = 161
        Me.Label41.Text = "Encargado"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Telefono", True))
        Me.txtTelefono.FieldReference = Nothing
        Me.txtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTelefono.Location = New System.Drawing.Point(10, 71)
        Me.txtTelefono.MaskEdit = ""
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtTelefono.Required = False
        Me.txtTelefono.ShowErrorIcon = True
        Me.txtTelefono.Size = New System.Drawing.Size(64, 20)
        Me.txtTelefono.TabIndex = 2
        Me.txtTelefono.Text = "000 0000"
        Me.txtTelefono.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.txtTelefono.ValidText = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(243, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(398, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(136, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Cod_Cliente", True))
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(13, 30)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtcodigo.TabIndex = 167
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Gray
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(884, -7)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(63, 14)
        Me.Label38.TabIndex = 159
        Me.Label38.Text = "Teléfono"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMaxdescuento
        '
        Me.TxtMaxdescuento.Location = New System.Drawing.Point(176, 272)
        Me.TxtMaxdescuento.Name = "TxtMaxdescuento"
        Me.TxtMaxdescuento.Size = New System.Drawing.Size(40, 20)
        Me.TxtMaxdescuento.TabIndex = 160
        Me.TxtMaxdescuento.Text = "TextBox1"
        '
        'TxtprecioCosto
        '
        Me.TxtprecioCosto.Location = New System.Drawing.Point(312, 272)
        Me.TxtprecioCosto.Name = "TxtprecioCosto"
        Me.TxtprecioCosto.Size = New System.Drawing.Size(32, 20)
        Me.TxtprecioCosto.TabIndex = 183
        Me.TxtprecioCosto.Text = "TextBox1"
        '
        'txtmontodescuento
        '
        Me.txtmontodescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmontodescuento.ForeColor = System.Drawing.Color.Blue
        Me.txtmontodescuento.Location = New System.Drawing.Point(352, 272)
        Me.txtmontodescuento.Name = "txtmontodescuento"
        Me.txtmontodescuento.Size = New System.Drawing.Size(24, 13)
        Me.txtmontodescuento.TabIndex = 181
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "008-invoice.png")
        Me.ImageList1.Images.SetKeyName(1, "007-search.png")
        Me.ImageList1.Images.SetKeyName(2, "006-diskette.png")
        Me.ImageList1.Images.SetKeyName(3, "005-browser.png")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "002-door.png")
        Me.ImageList1.Images.SetKeyName(7, "004-printer.png")
        Me.ImageList1.Images.SetKeyName(8, "close.png")
        Me.ImageList1.Images.SetKeyName(9, "003-tap.png")
        Me.ImageList1.Images.SetKeyName(10, "001-tap-1.png")
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(1061, 532)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(158, 13)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(976, 532)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(80, 13)
        Me.txtUsuario.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolBarAnular
        '
        Me.ToolBarAnular.Enabled = False
        Me.ToolBarAnular.ImageIndex = 3
        Me.ToolBarAnular.Name = "ToolBarAnular"
        Me.ToolBarAnular.Text = "Anular"
        Me.ToolBarAnular.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarAnular, Me.ToolBarImprimir, Me.ToolBarImportar, Me.ToolBarExportar, Me.ToolBarCerrar, Me.ToolBarDesanular})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 463)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1130, 61)
        Me.ToolBar1.TabIndex = 0
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        Me.ToolBarRegistrar.Visible = False
        '
        'ToolBarImportar
        '
        Me.ToolBarImportar.Enabled = False
        Me.ToolBarImportar.ImageIndex = 9
        Me.ToolBarImportar.Name = "ToolBarImportar"
        Me.ToolBarImportar.Text = "Importar"
        '
        'ToolBarExportar
        '
        Me.ToolBarExportar.Enabled = False
        Me.ToolBarExportar.ImageIndex = 10
        Me.ToolBarExportar.Name = "ToolBarExportar"
        Me.ToolBarExportar.Text = "Exportar"
        '
        'ToolBarDesanular
        '
        Me.ToolBarDesanular.ImageIndex = 3
        Me.ToolBarDesanular.Name = "ToolBarDesanular"
        Me.ToolBarDesanular.Text = "Des-Anular"
        Me.ToolBarDesanular.Visible = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Moneda.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.Adapter_Moneda.UpdateCommand = Me.SqlUpdateCommand3
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataSet_Facturaciones
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.ItemHeight = 16
        Me.ComboBox1.Location = New System.Drawing.Point(26, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Moneda.MonedaNombre"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Gray
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(26, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(112, 14)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(146, 39)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(80, 16)
        Me.txtTipoCambio.TabIndex = 70
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtorden)
        Me.GroupBox1.Controls.Add(Me.txtCancelado)
        Me.GroupBox1.Controls.Add(Me.ckPD)
        Me.GroupBox1.Controls.Add(Me.txtagente)
        Me.GroupBox1.Controls.Add(Me.ck_agente)
        Me.GroupBox1.Controls.Add(Me.SimpleButton3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Controls.Add(Me.Ck_Taller)
        Me.GroupBox1.Controls.Add(Me.Ck_Mascotas)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(640, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones de Factura"
        '
        'txtorden
        '
        Me.txtorden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtorden.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorden.ForeColor = System.Drawing.Color.Blue
        Me.txtorden.Location = New System.Drawing.Point(146, 71)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(80, 13)
        Me.txtorden.TabIndex = 2
        Me.txtorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCancelado
        '
        Me.txtCancelado.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelado.ForeColor = System.Drawing.Color.Red
        Me.txtCancelado.Location = New System.Drawing.Point(149, 64)
        Me.txtCancelado.Name = "txtCancelado"
        Me.txtCancelado.Size = New System.Drawing.Size(85, 13)
        Me.txtCancelado.TabIndex = 194
        Me.txtCancelado.Text = "CANCELADO"
        '
        'ckPD
        '
        Me.ckPD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckPD.EditValue = False
        Me.ckPD.Location = New System.Drawing.Point(81, 109)
        Me.ckPD.Name = "ckPD"
        '
        '
        '
        Me.ckPD.Properties.Caption = "PD"
        Me.ckPD.Properties.Enabled = False
        Me.ckPD.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Gray)
        Me.ckPD.Size = New System.Drawing.Size(64, 20)
        Me.ckPD.TabIndex = 198
        '
        'txtagente
        '
        Me.txtagente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.cod_agente", True))
        Me.txtagente.Enabled = False
        Me.txtagente.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagente.Location = New System.Drawing.Point(152, 89)
        Me.txtagente.Name = "txtagente"
        Me.txtagente.Size = New System.Drawing.Size(88, 20)
        Me.txtagente.TabIndex = 197
        '
        'ck_agente
        '
        Me.ck_agente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ck_agente.EditValue = False
        Me.ck_agente.Location = New System.Drawing.Point(81, 89)
        Me.ck_agente.Name = "ck_agente"
        '
        '
        '
        Me.ck_agente.Properties.Caption = "Agente"
        Me.ck_agente.Properties.Enabled = False
        Me.ck_agente.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Gray)
        Me.ck_agente.Size = New System.Drawing.Size(64, 20)
        Me.ck_agente.TabIndex = 196
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Location = New System.Drawing.Point(114, 24)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(24, 16)
        Me.SimpleButton3.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton3.TabIndex = 192
        Me.SimpleButton3.Text = "..."
        Me.SimpleButton3.ToolTip = "Cambio de la denominación de la moneda"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(146, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 14)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "Tipo Cambio"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Gray
        Me.Label40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(26, 71)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(112, 14)
        Me.Label40.TabIndex = 77
        Me.Label40.Text = "Orden de Compra ->"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ck_Taller
        '
        Me.Ck_Taller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Taller.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Taller", True))
        Me.Ck_Taller.EditValue = False
        Me.Ck_Taller.Location = New System.Drawing.Point(20, 89)
        Me.Ck_Taller.Name = "Ck_Taller"
        '
        '
        '
        Me.Ck_Taller.Properties.Caption = "Taller"
        Me.Ck_Taller.Properties.Enabled = False
        Me.Ck_Taller.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Gray)
        Me.Ck_Taller.Size = New System.Drawing.Size(56, 20)
        Me.Ck_Taller.TabIndex = 193
        '
        'Ck_Mascotas
        '
        Me.Ck_Mascotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Mascotas.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Mascotas", True))
        Me.Ck_Mascotas.EditValue = False
        Me.Ck_Mascotas.Location = New System.Drawing.Point(20, 107)
        Me.Ck_Mascotas.Name = "Ck_Mascotas"
        '
        '
        '
        Me.Ck_Mascotas.Properties.Caption = "Mascotas"
        Me.Ck_Mascotas.Properties.Enabled = False
        Me.Ck_Mascotas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Gray)
        Me.Ck_Mascotas.Size = New System.Drawing.Size(80, 20)
        Me.Ck_Mascotas.TabIndex = 195
        '
        'DtVence
        '
        Me.DtVence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DtVence.BackColor = System.Drawing.SystemColors.Control
        Me.DtVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DtVence.ForeColor = System.Drawing.Color.Red
        Me.DtVence.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtVence.Location = New System.Drawing.Point(206, 533)
        Me.DtVence.Name = "DtVence"
        Me.DtVence.Size = New System.Drawing.Size(65, 13)
        Me.DtVence.TabIndex = 164
        Me.DtVence.Text = "00/00/0000"
        Me.DtVence.Visible = False
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.BackColor = System.Drawing.SystemColors.Control
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtFecha.ForeColor = System.Drawing.Color.RoyalBlue
        Me.dtFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFecha.Location = New System.Drawing.Point(38, 533)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(125, 13)
        Me.dtFecha.TabIndex = 162
        Me.dtFecha.Text = "00/00/0000 hh:mm:ss"
        '
        'Adapter_Clientes
        '
        Me.Adapter_Clientes.DeleteCommand = Me.SqlDeleteCommand
        Me.Adapter_Clientes.InsertCommand = Me.SqlInsertCommand
        Me.Adapter_Clientes.SelectCommand = Me.SqlSelectCommand9
        Me.Adapter_Clientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("abierto", "abierto"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("max_credito", "max_credito"), New System.Data.Common.DataColumnMapping("Plazo_credito", "Plazo_credito"), New System.Data.Common.DataColumnMapping("descuento", "descuento"), New System.Data.Common.DataColumnMapping("empresa", "empresa"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("sinrestriccion", "sinrestriccion"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("agente", "agente"), New System.Data.Common.DataColumnMapping("CodMonedaCredito", "CodMonedaCredito"), New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("Cliente_Moroso", "Cliente_Moroso"), New System.Data.Common.DataColumnMapping("PrecioSugerido", "PrecioSugerido"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("notificar", "notificar"), New System.Data.Common.DataColumnMapping("tipo_cedula", "tipo_cedula"), New System.Data.Common.DataColumnMapping("OrdenCompra", "OrdenCompra")})})
        Me.Adapter_Clientes.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = "DELETE FROM [Clientes] WHERE (([identificacion] = @Original_identificacion))"
        Me.SqlDeleteCommand.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 0, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 0, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 0, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 0, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 0, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.[Char], 0, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 0, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 0, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.BigInt, 0, "identificacion"), New System.Data.SqlClient.SqlParameter("@Cliente_Moroso", System.Data.SqlDbType.Bit, 0, "Cliente_Moroso"), New System.Data.SqlClient.SqlParameter("@PrecioSugerido", System.Data.SqlDbType.Bit, 0, "PrecioSugerido"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@notificar", System.Data.SqlDbType.Bit, 0, "notificar"), New System.Data.SqlClient.SqlParameter("@tipo_cedula", System.Data.SqlDbType.NVarChar, 0, "tipo_cedula"), New System.Data.SqlClient.SqlParameter("@OrdenCompra", System.Data.SqlDbType.Bit, 0, "OrdenCompra")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = resources.GetString("SqlSelectCommand9.CommandText")
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 0, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 0, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 0, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 0, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 0, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.[Char], 0, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 0, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 0, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.BigInt, 0, "identificacion"), New System.Data.SqlClient.SqlParameter("@Cliente_Moroso", System.Data.SqlDbType.Bit, 0, "Cliente_Moroso"), New System.Data.SqlClient.SqlParameter("@PrecioSugerido", System.Data.SqlDbType.Bit, 0, "PrecioSugerido"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@notificar", System.Data.SqlDbType.Bit, 0, "notificar"), New System.Data.SqlClient.SqlParameter("@tipo_cedula", System.Data.SqlDbType.NVarChar, 0, "tipo_cedula"), New System.Data.SqlClient.SqlParameter("@OrdenCompra", System.Data.SqlDbType.Bit, 0, "OrdenCompra"), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Ventas.VentasVentas_Detalle"
        Me.GridControl1.DataSource = Me.DataSet_Facturaciones
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(7, 271)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(885, 185)
        Me.GridControl1.TabIndex = 183
        Me.GridControl1.Text = "GridControl1"
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colPrecio_Unit, Me.colMonto_Descuento, Me.colMonto_Impuesto, Me.colSubtotalGravado, Me.colSubTotalExcento, Me.colSubTotal})
        Me.BandedGridView1.GroupPanelText = "Detalle de Cotización"
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.BandedGridView1.OptionsView.ShowBands = False
        Me.BandedGridView1.OptionsView.ShowGroupedColumns = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colCantidad)
        Me.GridBand1.Columns.Add(Me.colPrecio_Unit)
        Me.GridBand1.Columns.Add(Me.colMonto_Descuento)
        Me.GridBand1.Columns.Add(Me.colMonto_Impuesto)
        Me.GridBand1.Columns.Add(Me.colSubtotalGravado)
        Me.GridBand1.Columns.Add(Me.colSubTotalExcento)
        Me.GridBand1.Columns.Add(Me.colSubTotal)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 619
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "CodArticulo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 63
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 245
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo3
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 46
        '
        'colPrecio_Unit
        '
        Me.colPrecio_Unit.Caption = "P.Unit"
        Me.colPrecio_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Unit.FieldName = "Precio_Unit"
        Me.colPrecio_Unit.FilterInfo = ColumnFilterInfo4
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Unit.Visible = True
        Me.colPrecio_Unit.Width = 59
        '
        'colMonto_Descuento
        '
        Me.colMonto_Descuento.Caption = "% Desc"
        Me.colMonto_Descuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Descuento.FieldName = "Descuento"
        Me.colMonto_Descuento.FilterInfo = ColumnFilterInfo5
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Descuento.SummaryItem.FieldName = "Monto_Descuento"
        Me.colMonto_Descuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Descuento.Visible = True
        Me.colMonto_Descuento.Width = 59
        '
        'colMonto_Impuesto
        '
        Me.colMonto_Impuesto.Caption = "M. Imp."
        Me.colMonto_Impuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Impuesto.FieldName = "Monto_Impuesto"
        Me.colMonto_Impuesto.FilterInfo = ColumnFilterInfo6
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Impuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Impuesto.Visible = True
        Me.colMonto_Impuesto.Width = 59
        '
        'colSubtotalGravado
        '
        Me.colSubtotalGravado.Caption = "S. Grav."
        Me.colSubtotalGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubtotalGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotalGravado.FieldName = "SubtotalGravado"
        Me.colSubtotalGravado.FilterInfo = ColumnFilterInfo7
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubtotalGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubtotalGravado.Width = 59
        '
        'colSubTotalExcento
        '
        Me.colSubTotalExcento.Caption = "S.Exc."
        Me.colSubTotalExcento.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotalExcento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotalExcento.FieldName = "SubTotalExcento"
        Me.colSubTotalExcento.FilterInfo = ColumnFilterInfo8
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotalExcento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotalExcento.Width = 66
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SubTotal"
        Me.colSubTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.FilterInfo = ColumnFilterInfo9
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotal.Visible = True
        Me.colSubTotal.Width = 88
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplica" &
    "r_Desc, Exist_Negativa, Porc_Desc, Porc_Precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Usuarios"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Adapter_Encargados_Compra
        '
        Me.Adapter_Encargados_Compra.SelectCommand = Me.SqlSelectCommand11
        Me.Adapter_Encargados_Compra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "encargadocompras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Identificacion, Cliente, Nombre FROM encargadocompras"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'Txtcodmoneda_Venta
        '
        Me.Txtcodmoneda_Venta.Location = New System.Drawing.Point(640, 248)
        Me.Txtcodmoneda_Venta.Name = "Txtcodmoneda_Venta"
        Me.Txtcodmoneda_Venta.Size = New System.Drawing.Size(40, 20)
        Me.Txtcodmoneda_Venta.TabIndex = 188
        '
        'Txt_TipoCambio_Valor_Compra
        '
        Me.Txt_TipoCambio_Valor_Compra.Location = New System.Drawing.Point(688, 248)
        Me.Txt_TipoCambio_Valor_Compra.Name = "Txt_TipoCambio_Valor_Compra"
        Me.Txt_TipoCambio_Valor_Compra.Size = New System.Drawing.Size(32, 20)
        Me.Txt_TipoCambio_Valor_Compra.TabIndex = 189
        '
        'Adapter_Ventas_Detalles
        '
        Me.Adapter_Ventas_Detalles.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Ventas_Detalles.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Ventas_Detalles.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Ventas_Detalles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_venta_detalle", "id_venta_detalle"), New System.Data.Common.DataColumnMapping("Id_Factura", "Id_Factura"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("Numero_Entrega", "Numero_Entrega"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("Lote", "Lote"), New System.Data.Common.DataColumnMapping("CantVet", "CantVet"), New System.Data.Common.DataColumnMapping("CantBod", "CantBod"), New System.Data.Common.DataColumnMapping("empaquetado", "empaquetado"), New System.Data.Common.DataColumnMapping("nota_pantalla", "nota_pantalla"), New System.Data.Common.DataColumnMapping("regalias", "regalias"), New System.Data.Common.DataColumnMapping("id_bodega", "id_bodega"), New System.Data.Common.DataColumnMapping("CostoReal", "CostoReal"), New System.Data.Common.DataColumnMapping("IdTipoExoneracion", "IdTipoExoneracion"), New System.Data.Common.DataColumnMapping("NumeroDocumento", "NumeroDocumento"), New System.Data.Common.DataColumnMapping("FechaEmision", "FechaEmision"), New System.Data.Common.DataColumnMapping("PorcentajeCompra", "PorcentajeCompra")})})
        Me.Adapter_Ventas_Detalles.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [Ventas_Detalle] WHERE (([id_venta_detalle] = @Original_id_venta_deta" &
    "lle))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 0, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 0, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 0, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 0, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 0, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 0, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 0, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 0, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 0, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 0, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 0, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 0, "Numero_Entrega"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 0, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 0, "Lote"), New System.Data.SqlClient.SqlParameter("@CantVet", System.Data.SqlDbType.Float, 0, "CantVet"), New System.Data.SqlClient.SqlParameter("@CantBod", System.Data.SqlDbType.Float, 0, "CantBod"), New System.Data.SqlClient.SqlParameter("@empaquetado", System.Data.SqlDbType.Bit, 0, "empaquetado"), New System.Data.SqlClient.SqlParameter("@nota_pantalla", System.Data.SqlDbType.VarChar, 0, "nota_pantalla"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Float, 0, "regalias"), New System.Data.SqlClient.SqlParameter("@id_bodega", System.Data.SqlDbType.BigInt, 0, "id_bodega"), New System.Data.SqlClient.SqlParameter("@CostoReal", System.Data.SqlDbType.Float, 0, "CostoReal"), New System.Data.SqlClient.SqlParameter("@IdTipoExoneracion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "IdTipoExoneracion", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@NumeroDocumento", System.Data.SqlDbType.VarChar, 0, "NumeroDocumento"), New System.Data.SqlClient.SqlParameter("@FechaEmision", System.Data.SqlDbType.DateTime, 0, "FechaEmision"), New System.Data.SqlClient.SqlParameter("@PorcentajeCompra", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "PorcentajeCompra", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@IdSerie", System.Data.SqlDbType.BigInt, 0, "IdSerie")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 0, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 0, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 0, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 0, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 0, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 0, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 0, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 0, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 0, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 0, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 0, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 0, "Numero_Entrega"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 0, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 0, "Lote"), New System.Data.SqlClient.SqlParameter("@CantVet", System.Data.SqlDbType.Float, 0, "CantVet"), New System.Data.SqlClient.SqlParameter("@CantBod", System.Data.SqlDbType.Float, 0, "CantBod"), New System.Data.SqlClient.SqlParameter("@empaquetado", System.Data.SqlDbType.Bit, 0, "empaquetado"), New System.Data.SqlClient.SqlParameter("@nota_pantalla", System.Data.SqlDbType.VarChar, 0, "nota_pantalla"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Float, 0, "regalias"), New System.Data.SqlClient.SqlParameter("@id_bodega", System.Data.SqlDbType.BigInt, 0, "id_bodega"), New System.Data.SqlClient.SqlParameter("@CostoReal", System.Data.SqlDbType.Float, 0, "CostoReal"), New System.Data.SqlClient.SqlParameter("@IdTipoExoneracion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "IdTipoExoneracion", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@NumeroDocumento", System.Data.SqlDbType.VarChar, 0, "NumeroDocumento"), New System.Data.SqlClient.SqlParameter("@FechaEmision", System.Data.SqlDbType.DateTime, 0, "FechaEmision"), New System.Data.SqlClient.SqlParameter("@PorcentajeCompra", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "PorcentajeCompra", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@IdSerie", System.Data.SqlDbType.BigInt, 0, "IdSerie"), New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_venta_detalle", System.Data.SqlDbType.BigInt, 8, "id_venta_detalle")})
        '
        'Adapter_Ventas
        '
        Me.Adapter_Ventas.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adapter_Ventas.InsertCommand = Me.SqlInsertCommand4
        Me.Adapter_Ventas.SelectCommand = Me.SqlSelectCommand5
        Me.Adapter_Ventas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Pago_Comision", "Pago_Comision"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("Cod_Encargado_Compra", "Cod_Encargado_Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("AsientoVenta", "AsientoVenta"), New System.Data.Common.DataColumnMapping("ContabilizadoCVenta", "ContabilizadoCVenta"), New System.Data.Common.DataColumnMapping("AsientoCosto", "AsientoCosto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Entregado", "Entregado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Moneda_Nombre", "Moneda_Nombre"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Exonerar", "Exonerar"), New System.Data.Common.DataColumnMapping("Taller", "Taller"), New System.Data.Common.DataColumnMapping("Mascotas", "Mascotas"), New System.Data.Common.DataColumnMapping("Num_Caja", "Num_Caja"), New System.Data.Common.DataColumnMapping("cod_agente", "cod_agente"), New System.Data.Common.DataColumnMapping("agente", "agente"), New System.Data.Common.DataColumnMapping("apartado", "apartado"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("EnviadoMH", "EnviadoMH"), New System.Data.Common.DataColumnMapping("TipoCedula", "TipoCedula"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        Me.Adapter_Ventas.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM [Ventas] WHERE (([Num_Factura] = @Original_Num_Factura) AND ([Tipo] =" &
    " @Original_Tipo) AND ([Num_Caja] = @Original_Num_Caja))"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Num_Factura", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Caja", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Caja", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 0, "Num_Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 0, "Orden"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 0, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 0, "Pago_Comision"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.SmallDateTime, 0, "Vence"), New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 0, "Cod_Encargado_Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 0, "AsientoVenta"), New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 0, "ContabilizadoCVenta"), New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 0, "AsientoCosto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 0, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 0, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 0, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 0, "Entregado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 0, "Moneda_Nombre"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 0, "Transporte"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 0, "Exonerar"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 0, "Taller"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 0, "Mascotas"), New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 0, "Num_Caja"), New System.Data.SqlClient.SqlParameter("@cod_agente", System.Data.SqlDbType.BigInt, 0, "cod_agente"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.Bit, 0, "agente"), New System.Data.SqlClient.SqlParameter("@apartado", System.Data.SqlDbType.BigInt, 0, "apartado"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@EnviadoMH", System.Data.SqlDbType.Bit, 0, "EnviadoMH"), New System.Data.SqlClient.SqlParameter("@TipoCedula", System.Data.SqlDbType.VarChar, 0, "TipoCedula"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 0, "Num_Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 0, "Orden"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 0, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 0, "Pago_Comision"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.SmallDateTime, 0, "Vence"), New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 0, "Cod_Encargado_Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 0, "AsientoVenta"), New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 0, "ContabilizadoCVenta"), New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 0, "AsientoCosto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 0, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 0, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 0, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 0, "Entregado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 0, "Moneda_Nombre"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 0, "Transporte"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 0, "Exonerar"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 0, "Taller"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 0, "Mascotas"), New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 0, "Num_Caja"), New System.Data.SqlClient.SqlParameter("@cod_agente", System.Data.SqlDbType.BigInt, 0, "cod_agente"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.Bit, 0, "agente"), New System.Data.SqlClient.SqlParameter("@apartado", System.Data.SqlDbType.BigInt, 0, "apartado"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@EnviadoMH", System.Data.SqlDbType.Bit, 0, "EnviadoMH"), New System.Data.SqlClient.SqlParameter("@TipoCedula", System.Data.SqlDbType.VarChar, 0, "TipoCedula"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@Original_Num_Factura", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Caja", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Caja", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Importar Cotización"
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = resources.GetString("SqlSelectCommand12.CommandText")
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        '
        'Adapter_Configuraciones
        '
        Me.Adapter_Configuraciones.DeleteCommand = Me.SqlDeleteCommand7
        Me.Adapter_Configuraciones.InsertCommand = Me.SqlInsertCommand7
        Me.Adapter_Configuraciones.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Configuraciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("Tel_01", "Tel_01"), New System.Data.Common.DataColumnMapping("Tel_02", "Tel_02"), New System.Data.Common.DataColumnMapping("Fax_01", "Fax_01"), New System.Data.Common.DataColumnMapping("Fax_02", "Fax_02"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Frase", "Frase"), New System.Data.Common.DataColumnMapping("Cajeros", "Cajeros"), New System.Data.Common.DataColumnMapping("Logo", "Logo"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("UnicoConsecutivo", "UnicoConsecutivo"), New System.Data.Common.DataColumnMapping("NumeroConsecutivo", "NumeroConsecutivo"), New System.Data.Common.DataColumnMapping("ConsContado", "ConsContado"), New System.Data.Common.DataColumnMapping("NumeroContado", "NumeroContado"), New System.Data.Common.DataColumnMapping("ConsCredito", "ConsCredito"), New System.Data.Common.DataColumnMapping("NumeroCredito", "NumeroCredito"), New System.Data.Common.DataColumnMapping("ConsPuntoVenta", "ConsPuntoVenta"), New System.Data.Common.DataColumnMapping("NumeroPuntoVenta", "NumeroPuntoVenta"), New System.Data.Common.DataColumnMapping("Taller", "Taller"), New System.Data.Common.DataColumnMapping("TallerContado", "TallerContado"), New System.Data.Common.DataColumnMapping("TallerCredito", "TallerCredito"), New System.Data.Common.DataColumnMapping("Imprimir_en_Factura_Personalizada", "Imprimir_en_Factura_Personalizada"), New System.Data.Common.DataColumnMapping("FormatoCheck", "FormatoCheck"), New System.Data.Common.DataColumnMapping("Contabilidad", "Contabilidad"), New System.Data.Common.DataColumnMapping("CambiaPrecioCredito", "CambiaPrecioCredito"), New System.Data.Common.DataColumnMapping("Mascotas", "Mascotas"), New System.Data.Common.DataColumnMapping("MascotasContado", "MascotasContado"), New System.Data.Common.DataColumnMapping("MascotasCredito", "MascotasCredito"), New System.Data.Common.DataColumnMapping("regalias", "regalias")})})
        Me.Adapter_Configuraciones.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM dbo.configuraciones WHERE (Cedula = @Original_Cedula)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"), New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"), New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"), New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"), New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"), New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 4, "Cajeros"), New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"), New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, "UnicoConsecutivo"), New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, "NumeroConsecutivo"), New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 1, "ConsContado"), New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 8, "NumeroContado"), New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 1, "ConsCredito"), New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 8, "NumeroCredito"), New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, "ConsPuntoVenta"), New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, "NumeroPuntoVenta"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"), New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 8, "TallerContado"), New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 8, "TallerCredito"), New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, "Imprimir_en_Factura_Personalizada"), New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"), New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 1, "Contabilidad"), New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, "CambiaPrecioCredito"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"), New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 8, "MascotasContado"), New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 8, "MascotasCredito"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Bit, 1, "regalias")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"), New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"), New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"), New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"), New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"), New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 4, "Cajeros"), New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"), New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, "UnicoConsecutivo"), New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, "NumeroConsecutivo"), New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 1, "ConsContado"), New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 8, "NumeroContado"), New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 1, "ConsCredito"), New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 8, "NumeroCredito"), New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, "ConsPuntoVenta"), New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, "NumeroPuntoVenta"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"), New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 8, "TallerContado"), New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 8, "TallerCredito"), New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, "Imprimir_en_Factura_Personalizada"), New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"), New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 1, "Contabilidad"), New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, "CambiaPrecioCredito"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"), New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 8, "MascotasContado"), New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 8, "MascotasCredito"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Bit, 1, "regalias"), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Coti
        '
        Me.Adapter_Coti.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Coti.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Coti.SelectCommand = Me.SqlSelectCommand6
        Me.Adapter_Coti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cotizacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cotizacion", "Cotizacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Contacto", "Contacto"), New System.Data.Common.DataColumnMapping("Validez", "Validez"), New System.Data.Common.DataColumnMapping("TiempoEntrega", "TiempoEntrega"), New System.Data.Common.DataColumnMapping("Contado", "Contado"), New System.Data.Common.DataColumnMapping("Credito", "Credito"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Dias", "Dias"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("Venta", "Venta"), New System.Data.Common.DataColumnMapping("Exonerar", "Exonerar")})})
        Me.Adapter_Coti.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 4, "Validez"), New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 4, "TiempoEntrega"), New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 1, "Contado"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 4, "Dias"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 8, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 1, "Venta"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 1, "Exonerar")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 4, "Validez"), New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 4, "TiempoEntrega"), New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 1, "Contado"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 4, "Dias"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 8, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 1, "Venta"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 1, "Exonerar"), New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion")})
        '
        'Adapter_CotiDetalle
        '
        Me.Adapter_CotiDetalle.DeleteCommand = Me.SqlDeleteCommand5
        Me.Adapter_CotiDetalle.InsertCommand = Me.SqlInsertCommand5
        Me.Adapter_CotiDetalle.SelectCommand = Me.SqlSelectCommand7
        Me.Adapter_CotiDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cotizacion_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Cotizacion", "Cotizacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("SubFamilia", "SubFamilia"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo")})})
        Me.Adapter_CotiDetalle.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubFamilia", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubFamilia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = resources.GetString("SqlSelectCommand7.CommandText")
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubFamilia", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubFamilia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero")})
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label48.BackColor = System.Drawing.Color.Red
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(880, 533)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(91, 13)
        Me.Label48.TabIndex = 190
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 524)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1130, 26)
        Me.StatusBar1.TabIndex = 193
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Fecha"
        Me.StatusBarPanel1.Width = 35
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 130
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "Vence"
        Me.StatusBarPanel3.Width = 36
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 70
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 842
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.opApartado)
        Me.Panel1.Controls.Add(Me.txtDiasPlazo)
        Me.Panel1.Controls.Add(Me.opCredito)
        Me.Panel1.Controls.Add(Me.opContado)
        Me.Panel1.Controls.Add(Me.lblDia)
        Me.Panel1.Location = New System.Drawing.Point(775, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 26)
        Me.Panel1.TabIndex = 194
        '
        'opApartado
        '
        Me.opApartado.AutoSize = True
        Me.opApartado.BackColor = System.Drawing.Color.Transparent
        Me.opApartado.Enabled = False
        Me.opApartado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opApartado.ForeColor = System.Drawing.Color.Blue
        Me.opApartado.Location = New System.Drawing.Point(7, 1)
        Me.opApartado.Name = "opApartado"
        Me.opApartado.Size = New System.Drawing.Size(91, 24)
        Me.opApartado.TabIndex = 196
        Me.opApartado.Text = "Apartado"
        Me.opApartado.UseVisualStyleBackColor = False
        '
        'lblDia
        '
        Me.lblDia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.ForeColor = System.Drawing.Color.Gray
        Me.lblDia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDia.Location = New System.Drawing.Point(307, 3)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(28, 19)
        Me.lblDia.TabIndex = 195
        Me.lblDia.Text = "días"
        Me.lblDia.Visible = False
        '
        'AdapterLotes
        '
        Me.AdapterLotes.DeleteCommand = Me.SqlDeleteCommand6
        Me.AdapterLotes.InsertCommand = Me.SqlInsertCommand6
        Me.AdapterLotes.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterLotes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo")})})
        Me.AdapterLotes.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo")})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Actual, Cod_Articulo FROM Lotes"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'LAnulada
        '
        Me.LAnulada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LAnulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnulada.ForeColor = System.Drawing.Color.Red
        Me.LAnulada.Location = New System.Drawing.Point(1142, 499)
        Me.LAnulada.Name = "LAnulada"
        Me.LAnulada.Size = New System.Drawing.Size(96, 20)
        Me.LAnulada.TabIndex = 195
        Me.LAnulada.Text = "ANULADA"
        Me.LAnulada.Visible = False
        '
        'txtHecho
        '
        Me.txtHecho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHecho.BackColor = System.Drawing.SystemColors.Control
        Me.txtHecho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHecho.Enabled = False
        Me.txtHecho.ForeColor = System.Drawing.Color.Blue
        Me.txtHecho.Location = New System.Drawing.Point(464, 531)
        Me.txtHecho.Name = "txtHecho"
        Me.txtHecho.ReadOnly = True
        Me.txtHecho.Size = New System.Drawing.Size(398, 13)
        Me.txtHecho.TabIndex = 197
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.BackColor = System.Drawing.Color.Black
        Me.lblMensaje.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.SystemColors.Window
        Me.lblMensaje.Location = New System.Drawing.Point(0, 32)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(1249, 0)
        Me.lblMensaje.TabIndex = 198
        Me.lblMensaje.Text = "Usted eligio la opcion"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOpcionElegida
        '
        Me.lblOpcionElegida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpcionElegida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpcionElegida.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblOpcionElegida.Location = New System.Drawing.Point(692, 498)
        Me.lblOpcionElegida.Name = "lblOpcionElegida"
        Me.lblOpcionElegida.Size = New System.Drawing.Size(272, 22)
        Me.lblOpcionElegida.TabIndex = 199
        Me.lblOpcionElegida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'adapter_clientes_frecuentes
        '
        Me.adapter_clientes_frecuentes.DeleteCommand = Me.SqlDeleteCommand8
        Me.adapter_clientes_frecuentes.InsertCommand = Me.SqlInsertCommand8
        Me.adapter_clientes_frecuentes.SelectCommand = Me.SqlSelectCommand10
        Me.adapter_clientes_frecuentes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes_frecuentes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.adapter_clientes_frecuentes.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = resources.GetString("SqlInsertCommand8.CommandText")
        Me.SqlInsertCommand8.Connection = Me.SqlConnection1
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado")})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'lblListaPromocion
        '
        Me.lblListaPromocion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListaPromocion.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaPromocion.Location = New System.Drawing.Point(434, 468)
        Me.lblListaPromocion.Name = "lblListaPromocion"
        Me.lblListaPromocion.Size = New System.Drawing.Size(804, 26)
        Me.lblListaPromocion.TabIndex = 201
        Me.lblListaPromocion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer2
        '
        Me.Timer2.Interval = 50500
        '
        'Facturacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1130, 550)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblListaPromocion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblOpcionElegida)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtHecho)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Txt_TipoCambio_Valor_Compra)
        Me.Controls.Add(Me.Txtcodmoneda_Venta)
        Me.Controls.Add(Me.TxtprecioCosto)
        Me.Controls.Add(Me.txtFlete)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtSGravado)
        Me.Controls.Add(Me.TxtMaxdescuento)
        Me.Controls.Add(Me.txtmontodescuento)
        Me.Controls.Add(Me.txtMontoImpuesto)
        Me.Controls.Add(Me.txtOtros)
        Me.Controls.Add(Me.txtSubFamilia)
        Me.Controls.Add(Me.LAnulada)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.DtVence)
        Me.Controls.Add(Me.CkEntregado)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ckpantalla)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(744, 500)
        Me.Name = "Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataSet_Facturaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtregalias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExisBod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_Exonerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ckFrecuente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ckPD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_agente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_Taller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_Mascotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"

    Private Sub OcultaMAG()
        Dim MAG As String = ""
        Try
            MAG = GetSetting("SeeSOFT", "SeePOS", "MAG")
            If MAG = "" Then
                MAG = "0"
                SaveSetting("SeeSOFT", "SeePOS", "MAG", "0")
            End If
            If MAG = "0" Then
                Me.btnMAG.Enabled = False
                Me.btnMAG.Visible = False
            Else
                Me.btnMAG.Enabled = True
                Me.btnMAG.Visible = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Me.OcultaMAG()
        Me.InsertEncabezado = Me.Adapter_Ventas.InsertCommand.CommandText.Replace("Ventas", "?")
        Me.UpdateEncabezado = Me.Adapter_Ventas.UpdateCommand.CommandText.Replace("Ventas", "?")
        Me.DeleteEncabezado = Me.Adapter_Ventas.DeleteCommand.CommandText.Replace("Ventas", "?")

        Me.InsertDetalle = Me.Adapter_Ventas_Detalles.InsertCommand.CommandText.Replace("Ventas", "?")
        Me.UpdateDetalle = Me.Adapter_Ventas_Detalles.UpdateCommand.CommandText.Replace("Ventas", "?")
        Me.DeleteDetalle = Me.Adapter_Ventas_Detalles.DeleteCommand.CommandText.Replace("Ventas", "?")

        Try
            If Me.AplicaCambioenCaja = False Then
                Me.lblFicha.Visible = False
                Me.txtFicha.Visible = False
                Me.btnBuscarFicha.Visible = False
                Me.opApartado.Visible = False
            End If

            Me.Obtener_Promo()

            Me.lblMensaje.Height = 0
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()

            Adapter_Configuraciones.Fill(DataSet_Facturaciones, "configuraciones")
            Adapter_Moneda.Fill(DataSet_Facturaciones, "Moneda")
            Adapter_Usuarios.Fill(DataSet_Facturaciones, "Usuarios")
            AdapterLotes.Fill(DataSet_Facturaciones, "Lotes") 'ojo se puede quitar esto

            DataSet_Facturaciones.Ventas.IdColumn.AutoIncrement = True
            DataSet_Facturaciones.Ventas.IdColumn.AutoIncrementSeed = -1
            DataSet_Facturaciones.Ventas.IdColumn.AutoIncrementStep = -1
            DataSet_Facturaciones.Ventas.Num_CajaColumn.DefaultValue = 1

            DataSet_Facturaciones.Ventas_Detalle.id_venta_detalleColumn.AutoIncrement = True
            DataSet_Facturaciones.Ventas_Detalle.id_venta_detalleColumn.AutoIncrementSeed = -1
            DataSet_Facturaciones.Ventas_Detalle.id_venta_detalleColumn.AutoIncrementStep = -1

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' establecer valores por defecto
            DataSet_Facturaciones.Ventas.TipoColumn.DefaultValue = "CON"
            DataSet_Facturaciones.Ventas.Cod_ClienteColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.Nombre_ClienteColumn.DefaultValue = "CLIENTE CONTADO"
            DataSet_Facturaciones.Ventas.OrdenColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.SubTotalColumn.DefaultValue = "0.00"
            DataSet_Facturaciones.Ventas.DescuentoColumn.DefaultValue = "0.00"
            DataSet_Facturaciones.Ventas.Imp_VentaColumn.DefaultValue = "0.00"
            DataSet_Facturaciones.Ventas.Tipo_CambioColumn.DefaultValue = "1"
            DataSet_Facturaciones.Ventas.TotalColumn.DefaultValue = "0.00"
            DataSet_Facturaciones.Ventas.Num_FacturaColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas.FechaColumn.DefaultValue = Date.Now
            DataSet_Facturaciones.Ventas.VenceColumn.DefaultValue = Date.Now
            DataSet_Facturaciones.Ventas.TransporteColumn.DefaultValue = "0.00"
            DataSet_Facturaciones.Ventas.Cod_Encargado_CompraColumn.DefaultValue = "NINGUNO"
            DataSet_Facturaciones.Ventas.ContabilizadoColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.AsientoCostoColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.AsientoVentaColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.ContabilizadoCVentaColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.AnuladoColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.PagoImpuestoColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.FacturaCanceladoColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.Num_AperturaColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.EntregadoColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.DireccionColumn.DefaultValue = ""
            DataSet_Facturaciones.Ventas.TelefonoColumn.DefaultValue = ""
            DataSet_Facturaciones.Ventas.Pago_ComisionColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.ObservacionesColumn.DefaultValue = ""
            DataSet_Facturaciones.Ventas.ExonerarColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.TallerColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.SubTotalExentoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas.SubTotalGravadaColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas.MascotasColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.Cedula_UsuarioColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas.cod_agenteColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas.agenteColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas.apartadoColumn.DefaultValue = "0"

            'valores por defecto en Ventas_Detalles
            DataSet_Facturaciones.Ventas_Detalle.Precio_UnitColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.CodigoColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.CodArticuloColumn.DefaultValue = ""
            DataSet_Facturaciones.Ventas_Detalle.DevolucionesColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.Numero_EntregaColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.CantidadColumn.DefaultValue = 1
            DataSet_Facturaciones.Ventas_Detalle.DescuentoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.Monto_DescuentoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.SubTotalExcentoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.SubtotalGravadoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.ImpuestoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.Monto_ImpuestoColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.SubTotalColumn.DefaultValue = 0.0
            DataSet_Facturaciones.Ventas_Detalle.LoteColumn.DefaultValue = "0"
            DataSet_Facturaciones.Ventas_Detalle.CantVetColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.CantBodColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.empaquetadoColumn.DefaultValue = False
            DataSet_Facturaciones.Ventas_Detalle.nota_pantallaColumn.DefaultValue = ""
            DataSet_Facturaciones.Ventas_Detalle.regaliasColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.id_bodegaColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.IdTipoExoneracionColumn.DefaultValue = 1
            DataSet_Facturaciones.Ventas_Detalle.NumeroDocumentoColumn.DefaultValue = ""
            DataSet_Facturaciones.Ventas_Detalle.FechaEmisionColumn.DefaultValue = Date.Now
            DataSet_Facturaciones.Ventas_Detalle.PorcentajeCompraColumn.DefaultValue = 0
            DataSet_Facturaciones.Ventas_Detalle.CostoRealColumn.DefaultValue = 0

            opContado.Checked = True
            bindings()
            logeado = False
            AgregandoNuevoItem = True

            CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True)
            CrystalReportsConexion.LoadReportViewer(Nothing, rptTiquete, True)
            CrystalReportsConexion.LoadReportViewer(Nothing, rptGenerica, True)

            Me.Ck_Taller.Enabled = False
            Me.Ck_Mascotas.Enabled = False
            Me.Ck_Taller.Visible = True
            Me.Ck_Mascotas.Visible = True

            Try
                '*****************************************************************************
                'Configuraciones para Taller
                '*****************************************************************************
                If GetSetting("seesoft", "seepos", "sistema_taller") = "" Then
                    SaveSetting("seesoft", "seepos", "sistema_taller", "0")
                End If

                If GetSetting("seesoft", "seepos", "sistema_taller") = "1" Then
                    Me.Ck_Taller.Checked = True
                    Me.Ck_Taller.Visible = True
                    Me.Ck_Taller.Enabled = False
                End If
            Catch ex As Exception
            End Try

            Try
                '*****************************************************************************
                'Configuraciones para Mascotas
                '*****************************************************************************
                If GetSetting("seesoft", "seepos", "sistema_mascotas") = "" Then
                    SaveSetting("seesoft", "seepos", "sistema_mascotas", "0")
                End If

                If GetSetting("seesoft", "seepos", "sistema_mascotas") = "1" Then
                    Me.Ck_Mascotas.Checked = True
                    Me.Ck_Mascotas.Visible = True
                    Me.Ck_Mascotas.Enabled = False
                End If
            Catch ex As Exception
            End Try

            Try
                If GetSetting("SeeSoft", "SeePOS", "estermica") = "" Then
                    SaveSetting("SeeSoft", "seepos", "estermica", "false")
                    esTermica = False
                Else
                    esTermica = GetSetting("SeeSoft", "SeePOS", "estermica")
                End If
            Catch ex As Exception
                SaveSetting("SeeSoft", "seepos", "estermica", "false")
                esTermica = False
            End Try

            Dim VETE As Double
            Try
                If GetSetting("seesoft", "seepos", "EsVeterinaria") = "" Then
                    SaveSetting("seesoft", "seepos", "EsVeterinaria", "1")
                End If
            Catch ex As Exception
            End Try

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try


        Try
            If GetSetting("SeeSOFT", "SeePOS", "SoloPVE") = "" Then
                SaveSetting("SeeSOFT", "SeePOS", "SoloPVE", "0")
            End If
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOS", "SoloPVE", "0")
        End Try

    End Sub
#End Region

    Public Sub ValidarExistenciaBodega2()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("", dt, CadenaConexionSeePOS)

    End Sub

    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then
            Exit Sub
        End If

        If Not Me.buscando And Me.txtNombreArt.Text <> "" Then
            Buscar_datos_articulo(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo"))
        End If

        If Me.txtCostoBase.Text <> "" And Me.txtPrecioUnit.Text <> "" And Me.txtFlete.Text <> "0" And Me.txtOtros.Text <> "" Then
            TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
        End If

    End Sub

    Private Sub Current_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then
            Me.SimpleButton3.Enabled = True
        Else
            Me.SimpleButton3.Enabled = False
        End If
    End Sub

    Private PromoCON As Boolean = False
    Private PromoCRE As Boolean = False
    Private PrecioContado As Decimal
    Private PrecioCredito As Decimal


    Private YaEstaFacturando As Boolean = False

    Private Sub Buscar_datos_articulo(ByVal codigo As String)
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean

        If codigo <> Nothing Then
            sqlConexion = CConexion.Conectar

            If Not IsNumeric(codigo) Then
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, PromoCRE, PromoCON, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio, Minima from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & codigo & "'")
            Else
                Dim a() As String = codigo.Split(".")
                If a.Length > 1 Then
                    rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, PromoCRE, PromoCON, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio, Minima from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & codigo & "'")
                Else
                    rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, PromoCRE, PromoCON, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio, Minima from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE Inhabilitado = 0 and (Codigo ='" & codigo & "' or Barras = '" & codigo & "')")
                End If
            End If
            Encontrado = False

            While rs.Read
                Try
                    Encontrado = True

                    If rs("Servicio") Then
                        Me.Existencia = 100
                    Else
                        Me.Existencia = rs("Existencia")
                    End If

                    txtExistencia.Text = Existencia
                    txtExisBod.Text = rs("ExistenciaBodega")

                    If rs("PreguntaPrecio") Then
                        PrecioA = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        PrecioB = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        PrecioC = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        PrecioD = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                    Else
                        PrecioA = rs("Precio_A")
                        PrecioB = rs("Precio_B")
                        PrecioC = rs("Precio_C")
                        PrecioD = rs("Precio_D")
                    End If

                    Me.precio_promo_valor = rs("Precio_Promo")
                    MonedaCosto = rs("MonedaVenta")
                    Me.MonedaBase = rs("MonedaCosto")
                    MonedaVenta = Me.BindingContext(Me.DataSet_Facturaciones, "Moneda").Current("CodMoneda")


                    If rs("Promo_Activa") = True Then ' si el articulo esta en promocion
                        Me.promo_activa_valor = True
                        Me.txtDescuento.Enabled = False
                        Me.PromoCON = rs("PromoCON")
                        Me.PromoCRE = rs("PromoCRE")
                    Else
                        Me.promo_activa_valor = False ' se habilita el text
                        Me.txtDescuento.Enabled = True
                        Me.PromoCON = False
                        Me.PromoCRE = False
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End While
            rs.Close()
            If Not Encontrado Then
                If YaEstaFacturando = False Then
                    MsgBox("No existe un artìculo con este código", MsgBoxStyle.Exclamation)
                    txtCodArticulo.Text = "0"
                    txtCod_Articulo.Text = "0"
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                    Me.txtCod_Articulo.Focus()
                    CConexion.DesConectar(CConexion.sQlconexion)
                End If
                Exit Sub
            End If

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaCosto)
            While rs.Read
                Try
                    ValorCosto = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End While
            rs.Close()

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaBase)
            While rs.Read
                Try
                    ValorBase = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End While
            rs.Close()


            ValorVenta = CDbl(Me.txtTipoCambio.Text)

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaBase)
            While rs.Read
                Try
                    ValorBase = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End While
            rs.Close()
            'Calculo_precio_unitario()
            Try

                If Me.opCredito.Checked = True Then
                    If Me.promo_activa_valor And Me.PromoCRE = True Then ' si el articulo esta actualmente en promoción 
                        Me.precio_unitario = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)
                        Exit Sub
                    End If
                End If

                If Me.opContado.Checked = True Then
                    If Me.promo_activa_valor And Me.PromoCON = True Then ' si el articulo esta actualmente en promoción 
                        Me.precio_unitario = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)
                        Exit Sub
                    End If
                End If



                If Me.tipoprecio = 0 Then
                    Me.tipoprecio = 1
                End If

                'Calculos para el Precio Unitario
                Select Case tipoprecio
                    Case 1 : Me.precio_unitario = Math.Round((PrecioA * (ValorCosto / ValorVenta)), 2)
                    Case 2 : Me.precio_unitario = Math.Round((PrecioB * (ValorCosto / ValorVenta)), 2)
                    Case 3 : Me.precio_unitario = Math.Round((PrecioC * (ValorCosto / ValorVenta)), 2)
                    Case 4 : Me.precio_unitario = Math.Round((PrecioD * (ValorCosto / ValorVenta)), 2)
                End Select

                'DataSet_Facturaciones.ArticulosXBodega.Clear()
                'Carga_Bodega(codigo)
                'If CBBodega.Items.Count < 0 Then
                '    MsgBox("Este Articulo no esta en ninguna Bodega", MsgBoxStyle.Critical)
                '    BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                '    txtCodArticulo.Focus()
                '    Exit Sub
                'End If

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        Else ' si no se recupero ningun articulo, se termina la edicion
            Try
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                Me.txtCod_Articulo.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Finally
                CConexion.DesConectar(CConexion.sQlconexion)
            End Try
        End If
    End Sub

    'Public Sub Carga_Bodega(ByVal Arti As Integer)
    '    Dim cnnv As SqlConnection = Nothing
    '    Dim dt As New DataTable
    '    '
    '    ' Dentro de un Try/Catch por si se produce un error
    '    Try
    '        ' Obtenemos la cadena de conexión adecuada
    '        Dim sConn As String = CadenaConexionSeePOS
    '        cnnv = New SqlConnection(sConn)
    '        cnnv.Open()
    '        ' Creamos el comando para la consulta
    '        Dim cmdv As SqlCommand = New SqlCommand
    '        Dim sel As String = "SELECT ArticulosXBodega.Cod_Articulo, ArticulosXBodega.Id_Bodega, ArticulosXBodega.Existencia, Bodegas.Nombre_Bodega FROM ArticulosXBodega INNER JOIN Bodegas ON ArticulosXBodega.Id_Bodega = Bodegas.ID_Bodega WHERE (ArticulosXBodega.Cod_Articulo = @Id_Factura) AND Existencia > 0"

    '        cmdv.CommandText = sel
    '        cmdv.Connection = cnnv
    '        cmdv.CommandType = CommandType.Text
    '        cmdv.CommandTimeout = 90
    '        ' Los parámetros usados en la cadena de la consulta 
    '        cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.Int))

    '        cmdv.Parameters("@Id_Factura").Value = Arti

    '        ' Creamos el dataAdapter y asignamos el comando de selección
    '        Dim dv As New SqlDataAdapter
    '        dv.SelectCommand = cmdv
    '        ' Llenamos la tabla
    '        dv.Fill(Me.DataSet_Facturaciones, "ArticulosXBodega")

    '    Catch ex As System.Exception
    '        ' Si hay error, devolvemos un valor nulo.
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
    '    Finally
    '        ' Por si se produce un error,
    '        ' comprobamos si en realidad el objeto Connection está iniciado,
    '        ' de ser así, lo cerramos.
    '        If Not cnnv Is Nothing Then
    '            cnnv.Close()
    '        End If
    '    End Try
    'End Sub

    'Public Sub TipoImpresora(ByVal PVE As Boolean)
    '    'IMPRESION VERIFICA QUE TIPO DE IMPRESION ESTA CONFIGURADA
    '    'PARA ASI INVOCAR A factura peresonalizada o reporte facturaPVEs.rpt
    '    If PVE = False Then
    '        Factura = Me.facturaPVE
    '    Else
    '        Factura = Me.Factura_reporte
    '    End If
    '    CrystalReportsConexion.LoadReportViewer(Nothing, Factura, True)
    'End Sub

    Private Sub bindings()

        'Me.TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Tipo"))

        Me.Lb_Subgravado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.SubtotalGravada"))

        Me.Lb_SubExento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.SubTotalExento"))

        Me.Label46.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Transporte"))

        ' Me.txtEncargado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Cod_Encargado_Compra"))

        ' Me.txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Num_Factura"))

        Me.txtMontoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Monto_Impuesto"))

        Me.txtSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubTotal"))

        Me.txtImpVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Impuesto"))

        Me.TxtMaxdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Max_Descuento"))

        Me.txtPrecioUnit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Unit"))

        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Cantidad"))

        Me.txtNombreArt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Descripcion"))

        txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Codigo"))

        txtCod_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.CodArticulo"))

        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Descuento"))

        Me.txtOtros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Otros"))

        Me.txtFlete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Flete"))

        Me.Txtcodmoneda_Venta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Cod_MonedaVenta"))

        Me.Txt_TipoCambio_Valor_Compra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Tipo_Cambio_ValorCompra"))

        Me.txtCostoBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Base"))


        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Total"))

        Me.txtImpVentaT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Imp_Venta"))

        Me.txtDescuentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Descuento"))

        Me.txtSubtotalT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.SubTotal"))

        Me.txtSGravado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubtotalGravado"))

        Me.txtSExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubTotalExcento"))

        Me.CkEntregado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Entregado"))

        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Anulado"))

        'Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Telefono"))

        'Me.Txtdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Direccion"))

        ' Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Cod_Cliente"))


        'Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Nombre_Cliente"))

        ' Me.TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Observaciones"))

        Me.TxtprecioCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Costo"))

        Me.txtmontodescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Monto_Descuento"))

        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Facturaciones, "Ventas.Moneda_Nombre"))

        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Fecha"))

        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Moneda.ValorVenta"))

        Me.txtorden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Orden"))

        Me.DtVence.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Vence"))

        Me.txtSubtotalExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubTotalExcento"))

        '        Me.txtDiasPlazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.SubTotalExcento"))
        Me.txtCancelado.Visible = False
        '_verificar_fact_canc()


    End Sub

    Public Sub Loggin_Usuario()
        Try

            If BindingContext(Me.DataSet_Facturaciones.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = DataSet_Facturaciones.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas..", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If

                    txtHecho.Text = ""
                    logeado = True
                    txtNombreUsuario.Text = Usua("Nombre")
                    Cedula_usuario = Usua("Cedula")
                    If devuelve_anulados(Cedula_usuario, Date.Now.ToShortDateString) >= 3 Then
                        MsgBox("Estimado " & txtNombreUsuario.Text & " se le informa que ha llegado al limite de Anulaciones, por el día de hoy no podra facturar más!", MsgBoxStyle.Information, "Atencion...!")
                        Me.Close()
                        Exit Sub
                    End If

                    IngresoTemperatura()

                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                    ToolBar1.Buttons(0).Text = "Cancelar"
                    ToolBar1.Buttons(0).ImageIndex = 8
                    ToolBar1.Buttons(3).Enabled = PMU.Delete
                    ToolBar1.Buttons(0).Enabled = True
                    ToolBar1.Buttons(1).Enabled = True
                    ToolBar1.Buttons(5).Enabled = True
                    ToolBar1.Buttons(6).Enabled = False
                    ToolBar1.Buttons(2).Enabled = False

                    TxtUtilidad.Text = ""
                    Anula_Venta = PMU.Delete 'Validar si el usuario puede o no anular una venta, en el caso de las facturas solo se permite anular no eliminar anulan
                    txtPrecioUnit.Enabled = Usua("CambiarPrecio")
                    txtPrecioUnit.Properties.ReadOnly = Not Usua("CambiarPrecio")
                    variacion_Punit = IIf(Usua("CambiarPrecio"), Usua("Porc_Precio"), 0)
                    SimpleButton2.Enabled = Usua("Aplicar_Desc") 'si el usuario no puede dar descuento
                    txtDescuento.Enabled = Usua("Aplicar_Desc")
                    txtDescuento.Properties.ReadOnly = Not Usua("Aplicar_Desc")

                    porcentaje_descuento = Usua("Porc_Desc")

                    perfil_administrador = PMU.Others
                    Label10.Visible = False
                    Label11.Visible = False
                    Label_Costobase.Visible = False
                    Label50.Visible = False
                    TxtUtilidad.Visible = False
                    Ck_Exonerar.Enabled = PMU.Others
                    vende_existecias_negativas = Usua("Exist_Negativa") ' si el vendedor puede vender con existencias negativas
                    ComboBox1.Enabled = True
                    Nueva_Factura()
                    'ComboBox1.Focus()
                    Me.txt_cedula.Focus()
                    inicializar()
                    Me.txtcodigo.Text = ""
                    Me.txtNombre.Text = ""
                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    logeado = False
                    txtUsuario.Text = ""
                End If

            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Public Function devuelve_anulados(ByVal ced As String, ByVal fecha As Date)

        Dim CuentaAnulados As Integer = 0
        Dim SQL As New GestioDatos
        Dim sentencia As String = "SELECT COUNT(*) AS Anulados FROM registro_anulaciones WHERE (cedula_usuario = '" & ced & "') AND (fecha = dbo.dateonly(getdate()) AND (justificacion = 0) AND (permiso = 0))"
        CuentaAnulados = SQL.Ejecuta(sentencia).Rows(0).Item(0)
        Return CuentaAnulados

    End Function

    Private Sub Reloggin_Usuario()
        'SAJ 28032007 MEJORAS EN EL RELOGGIN DEBIDO A NUEVAS POLITICAS DE SEGURIDAD
        'MEJORAS Y SIMPLIFICACION DE CODIDO
        Try

            If BindingContext(Me.DataSet_Facturaciones.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = DataSet_Facturaciones.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                    'Dim tipo As String = Usua("Perfil")
                    'If tipo <> "VENTAS" And tipo <> "ADMINISTRADOR" And tipo <> "CAJA" Then
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas...", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If
                    SimpleButton2.Enabled = Usua("Aplicar_Desc")
                    txtDescuento.Enabled = Usua("Aplicar_Desc")
                    GroupBox6.Enabled = True
                    GroupBox3.Enabled = True
                    txtPrecioUnit.Properties.ReadOnly = Not Usua("CambiarPrecio")
                    txtPrecioUnit.Properties.Enabled = Usua("CambiarPrecio")
                    txtDescuento.Properties.ReadOnly = Not Usua("Aplicar_Desc")
                    txtDescuento.Properties.Enabled = Usua("Aplicar_Desc")
                    txtorden.Enabled = True
                    txtNombreUsuario.Text = Usua("Nombre")
                    'Validar si el usuario puede o no anular una venta
                    Anula_Venta = PMU.Delete
                    txtPrecioUnit.Enabled = Usua("CambiarPrecio")
                    variacion_Punit = IIf(Usua("CambiarPrecio"), Usua("Porc_Precio"), 0)
                    porcentaje_descuento = Usua("Porc_Desc")
                    txtHecho.Text = ""
                    perfil_administrador = PMU.Others
                    Label10.Visible = False
                    Label11.Visible = False
                    Label_Costobase.Visible = False
                    Label50.Visible = False
                    TxtUtilidad.Visible = False
                    Ck_Exonerar.Enabled = PMU.Others
                    vende_existecias_negativas = Usua("Exist_Negativa") ' si el vendedor puede vender con existencias negativas
                    If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                        txtDescuento.Focus()
                    Else
                        txtCod_Articulo.Focus()
                    End If
                Else ' si no existe una contraseña como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    txtUsuario.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not logeado Then Loggin_Usuario() Else Me.Reloggin_Usuario()
        End If
    End Sub

    Private Pedido As New List(Of PedidoEditado)

    Private Sub Nueva_Factura()
        Me.IniciaTiempo()
        Me.ActualizaModo()
        Me.ckFrecuente.Checked = False
        Me.YaEstaFacturando = False

        Me.EstadoPreventa = "PreVenta"
        Me.txtFicha.Text = ""
        Me.IngresoIdentificacion = False
        Me.buscar_rifa()
        Me.ObligaOrdenCompra = False
        Me.txtCorreoComprobantes.Text = ""
        Me.txt_cedula.Text = ""
        Me.borrar()
        Me.Pedido.Clear()
        Try
            cbo_tipo_cliente.Text = "Fisica"
            txtcodigo.Text = 0
            Me.lblOpcionElegida.Text = ""
            Me.lblMensaje.Height = 0
            Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            Me.DataSet_Facturaciones.Ventas.Clear()

            Me.DataSet_Facturaciones.Cotizacion_Detalle.Clear()
            Me.DataSet_Facturaciones.Cotizacion.Clear()

            Me.txtExistencia.Text = "0"
            Me.Label41.Visible = False
            Me.txtEncargado.Visible = False
            Me.txtDiasPlazo.Visible = False
            Me.lblDia.Visible = False
            CbNumero.Items.Clear()
            ck_agente.Checked = False

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.DataSet_Facturaciones.Ventas.FechaColumn.DefaultValue = Date.Now
            Me.DataSet_Facturaciones.Ventas.VenceColumn.DefaultValue = Date.Now
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").AddNew()
            Me.opContado.Checked = True
            opCredito.Enabled = False
            Verificar_Consecutivos(False)
            'Me.txtFactura.Text = Label39.Text
            Me.impuesto_cliente = 100
            Me.tipoprecio = 1
            Me.ComboBox1.SelectedIndex = 0
            Me.coti = False

            If Me.buscando Then buscando = False ' si se estaba buscando, buscando se pone en falso

            If Me.perfil_administrador = True Then


                Me.colCodigo.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)


                Me.colCantidad.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)


                Me.colSubTotalExcento.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)



                Me.colSubtotalGravado.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)



                Me.colDescripcion.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

                Me.colPrecio_Unit.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                            Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

                Me.colMonto_Descuento.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)


                Me.colSubTotal.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

                Me.colMonto_Impuesto.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                                                Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

            End If

            ck_agente.Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub Verificar_Consecutivos(ByVal PVE As Boolean)

        Dim Tabla As String = ""
        If Me.AplicaCambioenCaja = True And Me.opCredito.Checked = False Then
            Tabla = "PreVentas"
        Else
            Tabla = "Ventas"
        End If

        If GetSetting("seesoft", "seepos", "sistema_taller") = "1" Then
            Me.Ck_Taller.Checked = True
            Me.Ck_Mascotas.Checked = False
        End If

        If GetSetting("seesoft", "seepos", "sistema_mascotas") = "1" Then
            Me.Ck_Mascotas.Checked = True
            Me.Ck_Taller.Checked = False
        End If

        Try
            If Me.buscando Then Exit Sub
            Dim func As New Conexion
            Dim Configuracion As System.Data.DataRow
            Configuracion = Me.DataSet_Facturaciones.configuraciones.Rows(0)

            If Configuracion("UnicoConsecutivo") = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & "")
                If CInt(txtFactura.Text) < Configuracion("NumeroConsecutivo") Then
                    txtFactura.Text = Configuracion("NumeroConsecutivo")
                End If
                num_fact = txtFactura.Text
                Exit Sub
            End If

            ''-------------------------------------------------
            If Configuracion("Mascotas") = True And opCredito.Checked = True And Ck_Mascotas.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'MCR') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("MascotasCredito") Then
                    txtFactura.Text = Configuracion("MascotasCredito")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "MCR"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If Configuracion("Taller") = True And opCredito.Checked = True And Ck_Taller.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'TCR') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("TallerCredito") Then
                    txtFactura.Text = Configuracion("TallerCredito")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "TCR"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If Configuracion("ConsPuntoVenta") = True And PVE = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'PVE') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("NumeroPuntoVenta") Then
                    txtFactura.Text = Configuracion("NumeroPuntoVenta")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "PVE"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If Configuracion("Mascotas") = True And opContado.Checked = True And Ck_Mascotas.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'MCO') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("MascotasContado") Then
                    txtFactura.Text = Configuracion("MascotasContado")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "MCO"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If Configuracion("Taller") = True And opContado.Checked = True And Ck_Taller.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'TCO') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("TallerContado") Then
                    txtFactura.Text = Configuracion("TallerContado")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "TCO"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If Configuracion("ConsContado") = True And opContado.Checked = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'CON') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("NumeroContado") Then
                    txtFactura.Text = Configuracion("NumeroContado")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "CON"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If Configuracion("ConsCredito") = True And Me.opCredito.Checked = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'CRE') And Num_Caja < 10")
                If CInt(txtFactura.Text) < Configuracion("NumeroCredito") Then
                    txtFactura.Text = Configuracion("NumeroCredito")
                End If
                num_fact = txtFactura.Text
                TxtTipo.Text = "CRE"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

            If opApartado.Checked = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM " & Tabla & " WHERE (Tipo = 'APA') And Num_Caja < 10")
                num_fact = txtFactura.Text
                TxtTipo.Text = "APA"
                tipo_fact = TxtTipo.Text
                Exit Sub
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Function UsoInterno(_Cod As String) As Boolean
        Dim dt As New DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("select SoloUsoInterno from Inventario where Codigo = " & _Cod, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("SoloUsoInterno") = True Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try        
    End Function

    Private Function ClienteUsoInterno(_CodCliente As String) As Boolean
        Dim dt As New DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("select UsoInterno from Clientes where identificacion =  " & _CodCliente, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("UsoInterno") = True Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function PuedeVenderDecimal(_Cod As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select SinDecimal from Inventario where Codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("SinDecimal") = True Then
                Return False
            Else
                Return True
            End If
        End If
        Return True
    End Function

    Private Sub NuevaEntrada()
        Try
            Me.ActualizaModo()
            Me.txtFicha.Text = ""
            Me.txtHecho.Text = ""
            Me.EstadoPreventa = "PreVenta"
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.IniciaTiempo()
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(6).Enabled = False
                Me.GroupBox6.Enabled = False
                Me.GroupBox3.Enabled = False
                Ck_Exonerar.Enabled = False
                Me.dtFecha.Enabled = False
                Me.txtorden.Enabled = True
                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.txtUsuario.Focus()
                Me.logeado = False
                Me.SimpleButton3.Enabled = False
                Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                Me.DataSet_Facturaciones.Ventas.Clear()
                Me.DataSet_Facturaciones.Cotizacion_Detalle.Clear()
                Me.DataSet_Facturaciones.Cotizacion.Clear()
                DataSet_Facturaciones.Lotes.Clear()
                AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")
                Me.Label41.Visible = False
                Me.txtEncargado.Visible = False
                Me.txtDiasPlazo.Visible = False
                Me.lblDia.Visible = False
                Me.opContado.Checked = True

                'Ck_Taller.Enabled = True
                'Ck_Mascotas.Enabled = True

                ck_agente.Enabled = True
                ck_agente.Checked = False
                txt_cedula.Text = ""
                Me.reimprimir = False
                LAnulada.Visible = False
                CbNumero.Items.Clear()
                Me.coti = False
            Else
                Me.DetenerTiempo()
                If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then 'Si la factura no tiene detalle
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").CancelCurrentEdit()
                    Me.SimpleButton1.Enabled = False
                    Me.SimpleButton2.Enabled = False
                    Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                    Me.DataSet_Facturaciones.Ventas.Clear()
                    DataSet_Facturaciones.Lotes.Clear()
                    AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.GroupBox6.Enabled = False
                    Me.GroupBox3.Enabled = False
                    Ck_Exonerar.Enabled = False
                    Me.Label10.Visible = False
                    Me.Label11.Visible = False
                    Me.Label_Costobase.Visible = False
                    Me.txtorden.Enabled = True
                    Me.dtFecha.Enabled = False
                    Me.logeado = False
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.SimpleButton3.Enabled = False
                    Ck_Taller.Enabled = False
                    Ck_Mascotas.Enabled = False
                    ck_agente.Enabled = False
                    CbNumero.Items.Clear()
                    Me.txtUsuario.Focus()
                    Exit Sub
                End If

                If PMU.Update = True Then
                    If MessageBox.Show("Desea Guardar esta Factura", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Me.Registrar(False, 1)
                    Else
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").CancelCurrentEdit()
                        Me.SimpleButton1.Enabled = False
                        Me.SimpleButton2.Enabled = False
                        LAnulada.Visible = False
                        Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                        Me.DataSet_Facturaciones.Ventas.Clear()
                        DataSet_Facturaciones.Lotes.Clear()
                        AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = True
                        Me.GroupBox6.Enabled = False
                        Ck_Exonerar.Enabled = False
                        Me.GroupBox3.Enabled = False
                        Me.Label10.Visible = False
                        Me.Label11.Visible = False
                        Me.Label_Costobase.Visible = False
                        Me.dtFecha.Enabled = False
                        Me.logeado = False
                        Me.SimpleButton3.Enabled = False
                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        CbNumero.Items.Clear()
                        Me.txtUsuario.Focus()
                    End If
                Else
                    MsgBox("No tiene permiso para registrar datos...", MsgBoxStyle.Information, "Atención...")
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ImprimirFactura()
        Dim nota As New frmNota
        Dim conec As New Conexion
        Dim gd As GestioDatos
        Dim cadena As String
        Try
            If DataSet_Facturaciones.Ventas(0).Cedula_Usuario = Me.Cedula_usuario Or VerificandoAcceso_a_Modulos("Reimprime_factura", "Reimprime Factura", Cedula_usuario, "Administración") = True Then

                Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id") ' se envia  aimprimir la factura actual
                Me.ToolBar1.Buttons(4).Enabled = False

                nota.ShowDialog()
                If nota.resultado = False Then
                    Exit Sub
                End If

                cadena = "'" & txtNombreUsuario.Text & "','" & Me.Cedula_usuario & "','" & Date.Now.Date & "'," & txtFactura.Text & ", ' " & nota.txt_observacion.Text & " '"
                If (MsgBox("Desea Imprimir en Punto Venta?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                    conec.AddNewRecord("Bitacora_reimpresiones", "usuario,cedula,fecha,factura,Motivo", cadena)
                    Imprimir(id, True, Me.DataSet_Facturaciones.Ventas(0).Num_Caja)
                Else
                    conec.AddNewRecord("Bitacora_reimpresiones", "usuario,cedula,fecha,factura,Motivo", cadena)
                    Imprimir(id, False, Me.DataSet_Facturaciones.Ventas(0).Num_Caja)
                End If
                Me.ToolBar1.Buttons(4).Enabled = True
            Else
                MsgBox("Usted no puede Reimprimir la factura", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevaEntrada()
            Case 2 : If PMU.Find Then Me.BuscarFactura() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text : Registrar(False, 1) Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : MsgBox("Las facturas no se pueden anular, Debe realizar una devolucion.", MsgBoxStyle.Information, "Operacion Invalida") 'If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then ImprimirFactura() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : BuscarCotizacion_importar()
            Case 7 : vistaenpantalla()
            Case 8 : If MessageBox.Show("¿Desea Cerrar el Módulo de Facturación?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
            Case 9 : If PMU.Delete Then desanular() Else MsgBox("No tiene permiso para desanular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
        End Select
    End Sub

    Private Sub vistaenpantalla()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            'Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id")
            'Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            'ReporteDocumento = New Factura_Generica

            'ReporteDocumento.SetParameterValue(0, CDbl(id))
            ''ReporteDocumento.SetParameterValue(1, False)
            'CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent)


            Dim file As New SaveFileDialog
            file.Filter = "Archivo PDF|*.pdf"
            file.Title = "Guardar Archivo PDF"
            If file.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim PDF As New OBSoluciones.Utilidades.PDF

                Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
                Me.BasedeDatos = Me.BuscaDatos(Conexion(1))

                Dim dtEncabezado As New DataTable
                Dim dtDetalle As New DataTable
                Dim Clave As String = ""
                Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id")

                dtEncabezado = Me.Obtener_Factura(id)
                dtDetalle = Me.Obtener_DetallesFactura(id)
                Clave = dtEncabezado.Rows(0).Item("ClaveMH")

                PDF.Autor = "OBSoluciones"
                PDF.Titulo = "Comprobantes Electronicos"
                PDF.CrearFactura(Clave, dtEncabezado, dtDetalle, file.FileName)
            End If

            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Function BuscaDatos(ByVal _Texto As String) As String
        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In _Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado
    End Function

    Private BasedeDatos As String = ""
    Public Function Obtener_Factura(_IdFactura As String) As DataTable
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
        db.AddParametro("@IdFactura", _IdFactura)
        db.AddParametro("@BasedeDatos", Me.BasedeDatos)
        dt = db.Ejecutar("Obtener_Factura")
        Return dt
    End Function

    Public Function Obtener_DetallesFactura(_IdFactura As String) As DataTable
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
        db.AddParametro("@IdFactura", _IdFactura)
        db.AddParametro("@BasedeDatos", Me.BasedeDatos)
        dt = db.Ejecutar("Obtener_DetallesFactura")
        Return dt
    End Function

    Private Sub BuscarCotizacion_importar()
        Try
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una venta, si continúa se perderan los datos de la venta actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            Me.DataSet_Facturaciones.Ventas.Clear()
            Me.DataSet_Facturaciones.Cotizacion_Detalle.Clear()
            Me.DataSet_Facturaciones.Cotizacion.Clear()
            DataSet_Facturaciones.Lotes.Clear()
            AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")
            Me.opCredito.Checked = False
            Me.opContado.Checked = True
            LAnulada.Visible = False
            txtHecho.Text = ""
            Dim identificador As Double

            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Cotizacion, Fecha, Nombre_Cliente, Total from Cotizacion where Anulado = 0 and Venta = 0 Order by Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Cotizacion"))
            'buscando = True

            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                'Me.buscando = False
                Exit Sub
            End If

            Importando = True
            importar(identificador) 'se importa la cotización

            Dim valid As Integer = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Validez")
            Dim Fecha_Cotizacion As Date = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Fecha")

            If Fecha_Cotizacion.AddDays(valid) < Now.Today Then
                If MsgBox("La Cotización ha vencido, Desea actualizar los precios", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ''llamar a la funcion para actualizar precios
                    Cambiar_Precios()
                Else
                    Mantener_Precios()
                End If
            ElseIf ((MsgBox("¿Desea actualizar los precios?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes) Then
                ''llamar a la funcion para actualizar precios
                Cambiar_Precios()
            Else
                ''llamar a la funcion para dejarlos igual
                Mantener_Precios()
            End If

            'Me.ToolBar1.Buttons(4).Enabled = True
            Me.coti = True
            Importando = False
            Verificar_Consecutivos(False)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Function GetImpuesto(_Codigo As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select IVenta, MAG From Inventario where codigo = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If Me.ClienteRegistradoMAG = True And dt.Rows(0).Item("MAG") = True Then
                Return 1
            Else
                Return dt.Rows(0).Item("IVenta")
            End If
        End If
    End Function

    Private Sub Mantener_Precios()
        Try
            Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            Me.DataSet_Facturaciones.Ventas.Clear()

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").AddNew()

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cod_Cliente")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Nombre_Cliente")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cedula")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("PagoImpuesto") = 100 'Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("PagoImpuesto")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Moneda") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("CodMoneda")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Moneda_Nombre") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("MonedaNombre")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Transporte") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Transporte")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Exonerar") = False
            Me.impuesto_cliente = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("PagoImpuesto")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            carga_datos_basicos_cliente()

            'recargar_Cliente()

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            If Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Contado") = True Then
                Me.TxtTipo.Text = "CON"
                Me.opContado.Checked = True
                Me.opCredito.Checked = False
            Else
                Me.TxtTipo.Text = "CRE"
                Me.opCredito.Checked = True
                Me.opContado.Checked = False
            End If


            '''''''''''Meter cotizacion detalle

            Dim i As Integer
            Dim IVA As Decimal = 0
            Dim SubTotal As Decimal = 0
            Dim Descuento As Decimal = 0
            Me.YaEstaFacturando = True
            For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1
                Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Position = i

                Try
                    Dim des As String = ""
                    Dim dts As New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select * from inventario where codigo = " & Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"), dts, CadenaConexionSeePOS)
                    If dts.Rows.Count > 0 Then
                        If dts.Rows(0).Item("Id_Bodega") > 0 Or dts.Rows(0).Item("Consignacion") = True Then
                            des = dts.Rows(0).Item("Descripcion")
                            Me.Existencia = dts.Rows(0).Item("Existencia")
                            Me.BodegaConsignacion = True
                            Me.ExistenciaConsignacion = dts.Rows(0).Item("ExistenciaBodega")
                            If dts.Rows(0).Item("bloqueado") = True Then
                                GoTo Fin
                            End If
                        End If
                    End If

                    If Me.BodegaConsignacion = True Then
                        If (CDec(Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")) + YaAdentro(Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"))) > (exi() + Me.ExistenciaConsignacion) Then
                            If MsgBox("La Cantidad a vender es mayor a la cantidad en bodega de consignacion, Desea Continuar", MsgBoxStyle.YesNo + MsgBoxStyle.Question, des) = MsgBoxResult.Yes Then
                                If VerificandoAcceso_a_Modulos("ConsignacionNegativa", "ConsignacionNegativa", Cedula_usuario, "Administración") = False Then
                                    Dim frm As New frmValidaConsignacionNegativa
                                    frm.ShowDialog()
                                    If frm.Resultado = False Then
                                        GoTo Fin
                                    End If
                                End If
                            Else
                                GoTo Fin
                            End If
                        End If
                    End If
                Catch ex As Exception
                End Try

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()

                IVA = Me.GetImpuesto(Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"))
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CodArticulo") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("CodArticulo")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cantidad") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Costo") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Costo")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Base") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Base")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Flete") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Flete")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Otros") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Otros")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Unit")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descuento") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descuento")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Descuento") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Monto_Descuento")

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Impuesto") = IVA
                SubTotal = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("SubTotal")
                Descuento = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Monto_Descuento")

                If IVA > 0 Then
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Impuesto") = (SubTotal - Descuento) * (IVA / 100)
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubtotalGravado") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("SubtotalGravado")
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotalExcento") = 0
                Else
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Impuesto") = 0
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubtotalGravado") = 0
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotalExcento") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("SubTotalExcento")
                End If

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("IdSerie") = "0"
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotal") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("SubTotal")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Max_Descuento") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Max_Descuento")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Tipo_Cambio_ValorCompra") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Tipo_Cambio_ValorCompra")
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cod_MonedaVenta") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cod_MonedaVenta")
                Dim cantVet As Double = 0 : Dim cantBod As Double = 0
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select * FROM Inventario Where Codigo = " & Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"), dt)
                If dt.Rows.Count > 0 Then
                    If CDbl(Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")) _
                    <= CDbl(dt.Rows(0).Item("Existencia")) Then
                        cantVet = txtCantidad.Text
                    Else
                        If CDbl(dt.Rows(0).Item("Existencia")) <= 0 Then
                            cantVet = 0
                            cantBod = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")
                        Else
                            cantVet = dt.Rows(0).Item("Existencia")
                            cantBod = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad") - dt.Rows(0).Item("Existencia")
                        End If
                    End If

                    BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CantVet") = cantVet
                    BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CantBod") = cantBod
                End If
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
Fin:
            Next
            Me.GroupBox1.Enabled = True
            'Me.GroupBox2.Enabled = True

            Me.GroupBox3.Enabled = True
            If Me.txtDescuento.Properties.ReadOnly = True Then Me.txtDescuento.Properties.Enabled = False
            If Me.txtPrecioUnit.Properties.ReadOnly = True Then Me.txtPrecioUnit.Properties.Enabled = False


            Me.ToolBar1.Buttons(4).Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = True
            Me.SimpleButton1.Enabled = True
            Me.SimpleButton2.Enabled = True

            Calcular_totales()
            Me.GridControl1.Enabled = True
            Me.YaEstaFacturando = False
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Function CorreoComprobantes(_Id As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from " & IIf(Me.ckFrecuente.Checked = False, "Clientes", "Clientes_frecuentes") & " Where identificacion = '" & _Id & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If Me.ckFrecuente.Checked = False Then
                Return dt.Rows(0).Item("CorreoComprobante")
            Else
                Return dt.Rows(0).Item("e_mail")
            End If
        Else
            Return ""
        End If
    End Function

    Sub carga_datos_basicos_cliente()
        Try
            If Me.txtcodigo.Text <> "0" Then
                Cargar_Cliente(CDbl(Me.txtcodigo.Text))
                Dim rss() As System.Data.DataRow
                Dim rs As System.Data.DataRow

                rss = Me.DataSet_Facturaciones.Clientes.Select("Identificacion ='" & Me.txtcodigo.Text & "'")

                If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

                    rs = rss(0)
                    Me.tipoprecio = rs("tipoprecio")
                    Me.Txtdireccion.Text = rs("direccion")
                    Me.txtTelefono.Text = rs("Telefono_01")
                    Me.txtCorreoComprobantes.Text = Me.CorreoComprobantes(Me.txtcodigo.Text)

                    descuento = rs("descuento")

                End If

            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Sub Cambiar_Precios()
        Try

            Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            Me.DataSet_Facturaciones.Ventas.Clear()

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").AddNew()


            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cod_Cliente")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Nombre_Cliente")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cedula")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("PagoImpuesto") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("PagoImpuesto")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Moneda") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("CodMoneda")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Moneda_Nombre") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("MonedaNombre")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Transporte") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Transporte")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Exonerar") = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Exonerar")
            Me.impuesto_cliente = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("PagoImpuesto")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            carga_datos_basicos_cliente()
            'recargar_Cliente()

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            If Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Contado") = True Then
                If GetSetting("seesoft", "seepos", "esveterinaria") = 1 Then
                    Me.TxtTipo.Text = "CON"
                    Me.opContado.Checked = True
                    Me.opCredito.Checked = False
                Else
                    Me.TxtTipo.Text = "TCO"
                    Me.opContado.Checked = True
                    Me.opCredito.Checked = False
                End If

            Else
                If GetSetting("seesoft", "seepos", "esveterinaria") = 1 Then
                    Me.TxtTipo.Text = "CRE"
                    Me.opCredito.Checked = True
                    Me.opContado.Checked = False
                Else
                    Me.TxtTipo.Text = "TCR"
                    Me.opCredito.Checked = True
                    Me.opContado.Checked = False
                End If

            End If


            '''''''''''Meter cotizacion detalle

            Dim i As Integer

            For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1
                Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Position = i


                Try
                    Dim des As String = ""
                    Dim dts As New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select * from inventario where codigo = " & Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"), dts, CadenaConexionSeePOS)
                    If dts.Rows.Count > 0 Then
                        If dts.Rows(0).Item("Id_Bodega") > 0 Or dts.Rows(0).Item("Consignacion") = True Then
                            des = dts.Rows(0).Item("Descripcion")
                            Me.Existencia = dts.Rows(0).Item("Existencia")
                            Me.BodegaConsignacion = True
                            Me.ExistenciaConsignacion = dts.Rows(0).Item("ExistenciaBodega")
                            If dts.Rows(0).Item("bloqueado") = True Then
                                GoTo Fin
                            End If
                        End If
                    End If

                    If Me.BodegaConsignacion = True Then
                        If (CDec(Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")) + YaAdentro(Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"))) > (exi() + Me.ExistenciaConsignacion) Then
                            If MsgBox("La Cantidad a vender es mayor a la cantidad en bodega de consignacion, Desea Continuar", MsgBoxStyle.YesNo + MsgBoxStyle.Question, des) = MsgBoxResult.Yes Then
                                If VerificandoAcceso_a_Modulos("ConsignacionNegativa", "ConsignacionNegativa", Cedula_usuario, "Administración") = False Then
                                    Dim frm As New frmValidaConsignacionNegativa
                                    frm.ShowDialog()
                                    If frm.Resultado = False Then
                                        GoTo Fin
                                    End If
                                End If
                            Else
                                GoTo Fin
                            End If
                        End If
                    End If
                Catch ex As Exception
                End Try

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()

                Dim cod = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")
                Dim cod_Art = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("CodArticulo")
                txtCodArticulo.Text = cod
                txtCod_Articulo.Text = cod_Art
                Me.CargarInformacionArticulo(cod_Art.ToString)
                Me.txtCantidad.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")
                Me.meter_al_detalle_cambiando()
Fin:
            Next

            Me.GroupBox1.Enabled = True
            'Me.GroupBox2.Enabled = True
            Me.GroupBox3.Enabled = True
            If Me.txtDescuento.Properties.ReadOnly = True Then Me.txtDescuento.Properties.Enabled = False
            If Me.txtPrecioUnit.Properties.ReadOnly = True Then Me.txtPrecioUnit.Properties.Enabled = False

            Me.ToolBar1.Buttons(4).Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = True
            Me.SimpleButton1.Enabled = True
            Me.SimpleButton2.Enabled = True
            Me.GridControl1.Enabled = True
            'Calcular_totales()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try


    End Sub

    Private Sub recargar_Cliente()
        Dim rsm As SqlDataReader
        Dim cambio As Double
        Dim cod_mod As Integer
        sqlConexion = CConexion.Conectar

        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow

        Dim codigo As String '= Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        codigo = Me.txtcodigo.Text

        rss = Me.DataSet_Facturaciones.Clientes.Select("Identificacion ='" & codigo & "'")

        If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

            Try
                rs = rss(0)
                Me.tipoprecio = rs("tipoprecio")

                cod_mod = rs("CodMonedaCredito")
                If rs("abierto") = "NO" Then

                    Me.opCredito.Enabled = False
                    Me.opCredito.Checked = False
                    'Me.opContado.Checked = True

                Else

                    Me.opCredito.Enabled = True
                    Me.opContado.Enabled = True
                    'Me.opContado.Checked = True
                    Me.txtDiasPlazo.Enabled = True

                End If

                If rs("sinrestriccion") = "SI" Then
                    sinrestriccion = True
                Else
                    sinrestriccion = False
                End If


                rsm = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & cod_mod)
                While rsm.Read
                    Try
                        cambio = rsm("ValorCompra")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.sQlconexion)
                    End Try
                End While
                rsm.Close()
                CConexion.DesConectar(CConexion.sQlconexion)


                max_credito = rs("max_credito") * (cambio / (CDbl(Me.txtTipoCambio.Text)))
                plazo_credito = rs("plazo_credito")
                txtDiasPlazo.Text = plazo_credito
                descuento = rs("descuento")

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        Else
            Me.opCredito.Enabled = False
        End If

    End Sub

    Private Sub Ingresar_Importado()
        Dim frm_leyenda As New frm_leyenda
        Try
            Dim resp As Integer
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Sub
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo a la factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                Me.txtCod_Articulo.Focus()
                Exit Sub
            End If

            'If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 14 Then
            '    MsgBox("Ha alcanzado el límite de la factura", MsgBoxStyle.Information)
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            '    Exit Sub
            'End If


            If CDbl(Me.txtCantidad.Text) > Me.Existencia And BodegaConsignacion = False Then 'si la cantidad digitada es mayor que la existencia

                MsgBox("No Existen " + txtCantidad.Text + " artículos, la Existencia en el inventario es de " + Me.Existencia.ToString + " ,debe hacer un pedido", MsgBoxStyle.Exclamation)

                If Not Me.vende_existecias_negativas Then
                    MsgBox("Usted no puede vender con existencias negativas", MsgBoxStyle.Critical)

                    If Me.Existencia <= 0 Then  ' si en el inventario ese articulo tiene existencias negativas
                        Me.txtCantidad.Text = 0 ' se vende solo lo que hay en el inventario
                    Else
                        Me.txtCantidad.Text = Me.Existencia '' se vende solo lo que hay en el inventario
                    End If


                    If Existencia = 0 Then ' si no hay articulos de ese tipo en el inventario
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Exit Sub
                    End If
                End If

            ElseIf CDbl(Me.txtCantidad.Text) = Me.Existencia Then 'si con esta venta el inventario la existencia sera 0
                MsgBox("Con esta Venta, la existencia de este artículo será 0, se debe hacer un pedido", MsgBoxStyle.Information)
            End If

            Me.Calculos_Articulo()
            Validar_Punitario()

            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()


            Calcular_totales()

            Me.txtCod_Articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Public Sub AbreDesdeAfuera(identificador As String)
        Me.Modo = "Ventas"

        Me.LlenarVentas(identificador)

        If Me.AplicaCambioenCaja = True Then
            Me.ToolBar1.Buttons(2).Enabled = True
            Me.GroupBox6.Enabled = True
            Me.GroupBox3.Enabled = True
            Ck_Exonerar.Enabled = True
            Me.txtorden.Enabled = True
        Else
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.GroupBox6.Enabled = False
            Me.GroupBox3.Enabled = False
            Ck_Exonerar.Enabled = False
            Me.txtorden.Enabled = True
        End If

        If Me.CheckBox1.Checked Then
            LAnulada.Visible = True
        Else
            LAnulada.Visible = False
        End If

        Dim i As Integer

        For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones.Ventas_Detalle).Count - 1 ' busca si en el detalle de la factura existen devolucines
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
            If (Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Devoluciones")) <> 0 Then
                Me.ToolBar1.Buttons(3).Enabled = False
                Exit For
            End If
        Next

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("exec GetDocumentosVenta " & identificador, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If MsgBox("Desea ver los documentos relacionados a esta factura.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
                Dim frm As New frmDocumentosRelacionados
                frm.IdFactura = identificador
                frm.ShowDialog()
            End If
        End If

        HechoPor()
        Me.ToolBar1.Buttons(6).Enabled = True
        Me.ToolBar1.Buttons(4).Enabled = True
        Me.opContado.Enabled = False
        Me.opCredito.Enabled = False
        Me.txtorden.Enabled = True
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton2.Enabled = False
        _verificar_fact_canc(identificador)
        Me.reimprimir = True

        If Me.AplicaCambioenCaja = True Then
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            txtCod_Articulo.Focus()
        End If
    End Sub

    Private Function EstaPendiete(_IdFactura As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Total from viewAutorizacionFacturasPendientes where Id_Factura = " & _IdFactura & " and Total > 10", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Total") > 10 Then
                Dim frm As New frmSaldoPendiente
                frm.Text = "Factura con un saldo pendiete"
                frm.lblSaldoPendiete.Text = "Saldo pendiente de " & CDec(dt.Rows(0).Item("Total")).ToString("N2")
                frm.ShowDialog()
            End If
        End If
    End Function

    Private Sub BuscarFactura()
        Try
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una venta, si continúa se perderan los datos de la venta actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.ToolBar1.Buttons(0).Enabled = True

            Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            Me.DataSet_Facturaciones.Ventas.Clear()

            Me.DataSet_Facturaciones.Cotizacion_Detalle.Clear()
            Me.DataSet_Facturaciones.Cotizacion.Clear()
            LAnulada.Visible = False
            txtHecho.Text = ""

            Dim Codigo As String
            Dim Codigos() As String
            Dim identificador As Double

            Dim Fx As New cFunciones
            'LLamo a la funcion Buscar_X_Descripcion_Fecha1 para buscar por nombre del documento y por 
            If Me.AplicaCambioenCaja = True Then
                Codigo = (Fx.BuscarFactura("Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from PreVentas where Estado = 'PreVenta' And dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC ", "[Nombre del Cliente]", "Fecha", "Buscar Factura de Venta", CadenaConexionSeePOS, True))
                If Codigo <> "" Then
                    Codigos = Codigo.Split(";")
                    identificador = Codigos(0)
                    Me.Modo = Codigos(1)
                Else
                    identificador = 0.0
                    Me.Modo = "PreVentas"
                End If
            Else
                Codigo = (Fx.BuscarFactura("Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC ", "[Nombre del Cliente]", "Fecha", "Buscar Factura de Venta", CadenaConexionSeePOS, True, True))
                If Codigo <> "" Then
                    Codigos = Codigo.Split(";")
                    identificador = Codigos(0)
                    Me.Modo = Codigos(1)
                Else
                    identificador = 0.0
                    Me.Modo = "Ventas"
                End If
            End If

            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Me.reimprimir = False
                Me.EstadoPreventa = "PreVenta"
                Exit Sub
            End If

            If Me.Modo = "PreVentas" Then
                Dim dtestado As New DataTable
                cFunciones.Llenar_Tabla_Generico("select * from PreVentas where Id = " & identificador, dtestado, CadenaConexionSeePOS)
                If dtestado.Rows.Count > 0 Then
                    Me.EstadoPreventa = dtestado.Rows(0).Item("Estado")
                Else
                    Me.EstadoPreventa = "PreVenta"
                End If
            End If

            Me.LlenarVentas(identificador)

            If Me.AplicaCambioenCaja = True Then
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.GroupBox6.Enabled = True
                Me.GroupBox3.Enabled = True
                Ck_Exonerar.Enabled = True
                Me.txtorden.Enabled = True
            Else
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.GroupBox6.Enabled = False
                Me.GroupBox3.Enabled = False
                Ck_Exonerar.Enabled = False
                Me.txtorden.Enabled = True
            End If
            
            If usua.Anu_Venta = True And Me.CheckBox1.Checked = False Then
                Me.ToolBar1.Buttons(3).Enabled = True
            Else
                Me.ToolBarDesanular.Visible = True
            End If

            If Me.CheckBox1.Checked Then
                LAnulada.Visible = True
            Else
                LAnulada.Visible = False
            End If

            Dim i As Integer

            For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones.Ventas_Detalle).Count - 1 ' busca si en el detalle de la factura existen devolucines
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
                If (Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Devoluciones")) <> 0 Then
                    Me.ToolBar1.Buttons(3).Enabled = False
                    Exit For
                End If
            Next

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("exec GetDocumentosVenta " & identificador, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If MsgBox("Desea ver los documentos relacionados a esta factura.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
                    Dim frm As New frmDocumentosRelacionados
                    frm.IdFactura = identificador
                    frm.ShowDialog()
                End If
            End If

            Me.EstaPendiete(identificador)

            HechoPor()
            Me.ToolBar1.Buttons(6).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.opContado.Enabled = False
            Me.opCredito.Enabled = False
            Me.txtorden.Enabled = True
            Me.SimpleButton1.Enabled = False
            Me.SimpleButton2.Enabled = False
            _verificar_fact_canc(identificador)
            Me.reimprimir = True

            If Me.AplicaCambioenCaja = True Then
                BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                txtCod_Articulo.Focus()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ponetipoidentificacion(_Id As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select TipoCliente from " & IIf(Me.ckFrecuente.Checked = False, "Clientes", "Clientes_frecuentes") & " where identificacion = '" & _Id & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.BanderaPuedeCambiarTipoCliente = True
            Me.cbo_tipo_cliente.Text = dt.Rows(0).Item("TipoCliente")
            Me.BanderaPuedeCambiarTipoCliente = False
        End If
    End Sub

    Private ClienteRegistradoMAG As Boolean = False
    Private Function EstaRegistrado(_Id As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Clientes Where identificacion = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.ClienteRegistradoMAG = dt.Rows(0).Item("MAG")
        Else
            Me.ClienteRegistradoMAG = False
        End If

        If Me.ClienteRegistradoMAG = True Then
            Me.btnMAG.BackColor = Drawing.Color.Yellow
        Else
            Me.btnMAG.BackColor = System.Drawing.SystemColors.Control
        End If

        Return Me.ClienteRegistradoMAG
    End Function

    Public Function ClienteInactivado(_Identificacion As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Anulado, Cliente_Moroso, Fallecido from Clientes where identificacion = " & _Identificacion, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If CBool(dt.Rows(0).Item("Fallecido")) = True Then
                Me.lblMensaje.Text = "El cliente esta marcado como Fallecido" & vbCrLf _
                & "No se puede Facturar."
                Me.lblMensaje.Height = 105
                MsgBox("Cliente " & Me.txtNombre.Text & " esta marcado como Fallecido!!!." & vbCrLf _
                & " Consulte al departamento administrativo.", MsgBoxStyle.Exclamation, "NO SE PUEDE REALIZAR LA OPERACION.")
                Me.lblMensaje.Height = 0
                Me.txt_cedula.Text = ""
                Me.borrar()
                Exit Function
            End If

            If CBool(dt.Rows(0).Item("Anulado")) = True Then
                Me.lblMensaje.Text = "El cliente esta inactivado" & vbCrLf _
                & "No se puede Facturar."
                Me.lblMensaje.Height = 105
                MsgBox("Cliente " & Me.txtNombre.Text & " esta INACTIVADO!!!." & vbCrLf _
                & " Consulte al departamento administrativo.", MsgBoxStyle.Exclamation, "NO SE PUEDE REALIZAR LA OPERACION.")
                Me.lblMensaje.Height = 0
                Me.txt_cedula.Text = ""
                Me.borrar()
            End If

            If CBool(dt.Rows(0).Item("Cliente_Moroso")) = True Then
                Me.DetenerTiempo()
                Dim frm As New frmMensajeClienteMoroso
                frm.ShowDialog()
                Me.IniciaTiempo()
            End If
        End If
    End Function

    Private Sub Cargar_Cliente(ByVal Id As String)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM " & IIf(Me.ckFrecuente.Checked = False, "Clientes", "Clientes_frecuentes") & " WHERE (identificacion = @cedula) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@cedula", SqlDbType.NVarChar))

            cmdv.Parameters("@cedula").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSet_Facturaciones, "Clientes")

            If Me.ckFrecuente.Checked = False Then
                Me.ObligaOrdenCompra = Me.DataSet_Facturaciones.Clientes(0).OrdenCompra
            Else
                Me.ObligaOrdenCompra = False
            End If

            Me.txtCorreoComprobantes.CharacterCasing = CharacterCasing.Normal
            Me.txtCorreoComprobantes.Text = Me.CorreoComprobantes(Id)
            Me.EstaRegistrado(Id)
            Me.IngresoIdentificacion = True
            Me.ponetipoidentificacion(Id)
            Me.ClienteInactivado(Id)


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            ' MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub

    Private ObligaOrdenCompra As Boolean = False

    Private Sub Cargar_Cliente_frecuente(ByVal Id As String)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Clientes_frecuentes WHERE (identificacion = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.Int))

            cmdv.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSet_Facturaciones, "Clientes_frecuentes")

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub
    Private Sub importar(ByVal Id As Double)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Cotizacion WHERE (Cotizacion = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cmdv.Parameters("@Id_Factura").Value = Id

            If GetSetting("seesoft", "seepos", "esveterinaria") = 1 Then

            End If
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSet_Facturaciones, "Cotizacion")


            'If Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Contado") = True Then
            '    Me.opContado.Checked = True
            '    Me.opCredito.Checked = False
            'Else
            '    Me.opCredito.Checked = True
            '    Me.opContado.Checked = False

            'End If

            '''''''''LLENAR COTIZACION DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM Cotizacion_Detalle WHERE (Cotizacion = @Id_Factura) "

            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cmd.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DataSet_Facturaciones.Cotizacion_Detalle)


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub

    Private Sub GetNumFicha(_Id As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Ficha from PreVentas where id = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtFicha.Text = dt.Rows(0).Item("Ficha")
        End If
    End Sub

    Private Function GetTablaDetalle() As String
        Select Case Me.Modo
            Case "PreVentas" : Return "PreVentas_Detalle"
            Case "Ventas" : Return "Ventas_Detalle"
            Case "AdelantoVentas" : Return "AdelantoVentas_Detalle"
        End Select
    End Function

    Private Sub LlenarVentas(ByVal Id As Double)

        If Me.AplicaCambioenCaja = True Then
            Me.GetNumFicha(Id)
        End If

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM " & Me.GetTabla & " WHERE (Id = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cmdv.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSet_Facturaciones, "Ventas")

            If TxtTipo.Text = "CON" Or TxtTipo.Text = "TCO" Or TxtTipo.Text = "PVE" Then
                Me.opContado.Checked = True
                Me.opCredito.Checked = False
            Else
                Me.opCredito.Checked = True
                Me.opContado.Checked = False
            End If

            Me.lblOpcionElegida.Text = "Caja # " & Me.DataSet_Facturaciones.Ventas(0).Num_Caja

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") <> "NINGUNO" Then
                Me.Label41.Visible = True
                Me.txtEncargado.Visible = True
            Else
                Me.Label41.Visible = False
                Me.txtEncargado.Visible = False
            End If

            '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            'Dim sConn As String = CadenaConexionSeePOS
            'cnn = New SqlConnection(sConn)
            'cnn.Open()

            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM " & IIf(Me.AplicaCambioenCaja = True, Me.GetTablaDetalle, "Ventas_Detalle") & " WHERE (Id_Factura = @Id_Factura) "

            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cmd.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DataSet_Facturaciones.Ventas_Detalle)


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub

    Private Sub Anular()
        Dim fecha As DateTime
        fecha = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("fecha")
        fecha = Format(fecha, "short Date")
        Try
            If usua.Anu_Venta = False Then
                MsgBox("Usted no tiene permisos de anular ventas", MsgBoxStyle.Information)
                Exit Sub
            End If
            If fecha <> Now.Date Then
                MsgBox("La factura NO es del día de hoy, NO se puede Anular.", MsgBoxStyle.Information, "Mensaje")
                Exit Sub
            End If
            Dim resp As Integer

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count > 0 Then


                resp = MessageBox.Show("¿Desea Anular esta Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then

                    Dim fr As New Anular_Factura
                    fr.ShowDialog()
                    If fr.resultado = False Then
                        Exit Sub
                    Else
                        Dim id = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("id")
                        insertar_anulacion(fr.cedu_usuario, Date.Now.ToShortDateString, fr.txt_observacion.Text, id, fr.justificaAnulacion, fr.Cedu_Admin)
                    End If
                    CheckBox1.Checked = True
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

                    If Me.insertar_bitacora() And Registrar_Anulacion_Venta() Then

                        Me.DataSet_Facturaciones.AcceptChanges()
                        MsgBox("La Factura ha sido anulada correctamente", MsgBoxStyle.Information)
                        Registrar_opcion_pago()

                        Me.reimprimir = False
                        Me.Imprimir(Me.DataSet_Facturaciones.Ventas(0).Id, True, Me.DataSet_Facturaciones.Ventas(0).Num_Caja)

                        Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                        Me.DataSet_Facturaciones.Ventas.Clear()

                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.SimpleButton1.Enabled = False
                        Me.SimpleButton2.Enabled = False

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                        txtHecho.Text = ""
                        Me.GroupBox6.Enabled = False
                        Me.GroupBox3.Enabled = False
                        Ck_Exonerar.Enabled = False
                        Me.txtorden.Enabled = True
                        Me.Label10.Visible = False
                        Me.Label11.Visible = False
                        Me.Label_Costobase.Visible = False
                        LAnulada.Visible = False

                        Me.logeado = False

                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()


                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                    End If

                Else : Exit Sub

                End If

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function insertar_bitacora() As Boolean
        Dim funciones As New Conexion
        Dim datos, Tipo As String

        If Ck_Taller.Checked = True Then
            Tipo = "FVT"
        ElseIf Ck_Mascotas.Checked = True Then
            Tipo = "FVM"
        ElseIf TxtTipo.Text = "PVE" Then
            Tipo = "FVP"
        Else
            Tipo = "FVC"
        End If

        datos = "'VENTAS','" & Me.txtFactura.Text & "-" & TxtTipo.Text & "','" & Me.txtNombre.Text & "','FACTURA DE VENTA ANULADA','" & usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
        If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" And funciones.UpdateRecords("OpcionesDePago", "FormaPago = 'ANU'", "(Documento = " & txtFactura.Text & ") AND (TipoDocumento = '" & Tipo & "')") <> "" Then
            MsgBox("Problemas al Anular la venta", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub desanular()
        Try
            If usua.Anu_Venta = False Then
                MsgBox("Usted no tiene permisos desanular ventas", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim resp As Integer

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count > 0 Then

                resp = MessageBox.Show("¿Desea Desanular esta Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then

                    Dim id = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("id")
                    ' insertar_anulacion(fr.cedu_usuario, Date.Now.ToShortDateString, fr.txt_observacion.Text, id, fr.justificaAnulacion, fr.Cedu_Admin)

                    CheckBox1.Checked = True
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

                    If registrar_desanular() Then

                        Me.DataSet_Facturaciones.AcceptChanges()
                        MsgBox("La Factura ha sido desanulada correctamente", MsgBoxStyle.Information)

                        Me.reimprimir = False
                        Me.Imprimir(Me.DataSet_Facturaciones.Ventas(0).Id, True, Me.DataSet_Facturaciones.Ventas(0).Num_Caja)

                        Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                        Me.DataSet_Facturaciones.Ventas.Clear()

                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.SimpleButton1.Enabled = False
                        Me.SimpleButton2.Enabled = False

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                        Me.ToolBarDesanular.Visible = False

                        txtHecho.Text = ""
                        Me.GroupBox6.Enabled = False
                        Me.GroupBox3.Enabled = False
                        Ck_Exonerar.Enabled = False
                        Me.txtorden.Enabled = True
                        Me.Label10.Visible = False
                        Me.Label11.Visible = False
                        Me.Label_Costobase.Visible = False
                        LAnulada.Visible = False

                        Me.logeado = False

                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()


                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                    End If

                Else : Exit Sub

                End If

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Function registrar_desanular() As Boolean
        Dim Cx As New Conexion
        Try
            Cx.UpdateRecords("Ventas", "Anulado = 0", "Id = " & BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id"), "SeePos")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
    Function Registrar_opcion_pago() As Boolean

        Dim Cx As New Conexion
        Dim factura As String
        Dim tipo As String

        factura = BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_factura")
        tipo = BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("tipo")

        If tipo = "PVE" Then
            tipo = "FVP"
        ElseIf tipo = "CON" Then
            tipo = "FVC"
        ElseIf tipo = "MCO" Then
            tipo = "FVM"
        End If

        Try
            Cx.UpdateRecords("opcionesdepago", "Formapago = 'ANU'", "Documento = " & factura & " and formapago = '" & tipo & "'", "SeePos")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
    Function Registrar_Anulacion_Venta() As Boolean
        Dim Cx As New Conexion
        Try
            Cx.UpdateRecords("Ventas", "Anulado = 1", "Id = " & BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id"), "SeePos")

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    Private Sub PoneTexto()
        Dim caja As String
        Select Case Me.TclCaja
            Case "F2"
                caja = "Caja 1"
            Case "F3"
                caja = "Caja 1"
            Case "F4"
                caja = "Caja 2"
            Case "F5"
                caja = "Caja 2"
        End Select
        Me.lblMensaje.Text = "Usted eligio la opcion : " & Me.TclCaja & vbCrLf _
        & caja
        Me.lblMensaje.Height = 105
    End Sub

    Private Function CajaAbierta(ByVal _caja) As Boolean
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from aperturacaja where Estado = 'A' and Anulado = 0 and Num_Caja = " & _caja, dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetExistencia(ByVal _cod As String) As Decimal
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Existencia from inventario where codigo = '" & _cod & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        End If
    End Function

    Private Function esQuimicoRestringido(_Cod As String) As Boolean
        Dim resultado As Boolean = False
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Receta from Inventario where Codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("Receta")
        End If
        Return resultado
    End Function

    Private Function ValidaNombreQuimicos(_Nombre As String) As Boolean
        Dim Resultado As Boolean = True

        Dim Nombre As String = _Nombre
        Dim PasaNombre As Boolean = True

        If Nombre = "CLIENTE DE CONTADO" Or Nombre.Length < 7 Then
            PasaNombre = False
        End If

        With BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")
            .EndCurrentEdit()
            For i As Integer = 0 To .Count() - 1
                .Position = i
                If Me.esQuimicoRestringido(.Current("Codigo")) = True And PasaNombre = False Then
                    Resultado = False
                End If
            Next
        End With

        If Resultado = False Then
            MsgBox("Debe ingresar el nombre completo.", MsgBoxStyle.Exclamation, "Producto Quimico con Receta")
        End If

        Return Resultado
    End Function

    Private Sub Revisa_Error_Bodegas_VeterinariaLiberia()
        With BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")
            .EndCurrentEdit()
            For i As Integer = 0 To .Count() - 1
                .Position = i
                If Me.Consignacion(.Current("Codigo")) = True Then
                    If CDec(.Current("Cantidad")) <> CDec((.Current("CantVet") + .Current("CantBod"))) Then
                        Dim Existencia As Decimal = GetExistencia(.Current("Codigo"))
                        If CDbl(.Current("Cantidad")) <= Existencia Then
                            .Current("CantVet") = .Current("Cantidad")
                            .Current("CantBod") = 0
                            .EndCurrentEdit()
                        Else
                            If CDbl(txtExistencia.Text) <= 0 Then
                                .Current("CantVet") = 0
                                .Current("CantBod") = .Current("Cantidad")
                                .EndCurrentEdit()
                            Else
                                .Current("CantVet") = Existencia
                                .Current("CantBod") = .Current("Cantidad") - Existencia
                                .EndCurrentEdit()
                            End If
                        End If
                    End If
                Else
                    .Current("CantVet") = .Current("Cantidad")
                    .Current("CantBod") = 0
                    .EndCurrentEdit()
                End If
            Next
        End With
    End Sub

    Private IngresoIdentificacion As Boolean = False

    Private Function ValidaDGT() As Boolean
        Select Case Me.TclCaja
            Case "F2" 'Factura, OjO Validar la cedula
                Return Me.IngresoIdentificacion
            Case "F3" ' Tiquete No importa si ingresa la cedula o no
                Return True
            Case "F4" 'Factura, OjO Validar la cedula
                Return Me.IngresoIdentificacion
            Case "F5" ' Tiquete No importa si ingresa la cedula o no
                Return True
            Case "F6" ' Tiquete No importa si ingresa la cedula o no
                Return Me.IngresoIdentificacion
            Case "F7" ' Tiquete No importa si ingresa la cedula o no
                Return True
        End Select
    End Function

    Private Function FacturaElectronica() As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select FacturaElectronica From configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("FacturaElectronica")
        Else
            Return False
        End If
    End Function

    Private Function PasaFormatoCedula() As Boolean
        Dim Pasa As Boolean = False

        Dim Cod_Cliente As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")

        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        dt = db.Ejecutar("select cedula, tipocliente from clientes where identificacion = '" & Cod_Cliente & "'", CommandType.Text)
        If dt.Rows.Count > 0 Then
            Dim tipo As String = dt.Rows(0).Item("tipocliente")
            Dim cedula As String = dt.Rows(0).Item("cedula")
            Select Case tipo
                Case "FISICA" 'formato de cedula fisica
                    Pasa = IIf(cedula.Length = 9, True, False)
                Case "JURIDICA" 'formato de cedula juridica
                    Pasa = IIf(cedula.Length = 10, True, False)
                Case "DIMEX" 'formato de cedula extrangera
                    If cedula.Length = 11 Or cedula.Length = 12 Then
                        Pasa = True
                    Else
                        Pasa = False
                    End If
            End Select
        End If

        Return Pasa
    End Function

    Private Function GetActualizado() As Boolean
        Dim dt As New DataTable
        Dim Cedula As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        cFunciones.Llenar_Tabla_Generico("select Actualizado from clientes where identificacion = '" & Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim actualizado As Boolean = dt.Rows(0).Item("Actualizado")
            Return actualizado
        End If
        Return True
    End Function

    Private db As OBSoluciones.SQL.Transaccion
    Private Consecutivo As Integer
    Private Sub GuardarPedido()
        Me.db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Me.Consecutivo = 0
        Try
            For Each item As PedidoEditado In Me.Pedido
                Me.InsertarPedidoBodega(Date.Now, Me.Cedula_usuario, item.Codigo, item.Cantidad, "", item.PrecioUnid)
            Next
            db.Commit()
            Me.Pedido.Clear()
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarPedidoBodega(_FechaSolicitud As Date, _IdUsuarioSolicitud As String, _Codigo As String, _CantidadSolicitud As Decimal, _Observaciones As String, _PrecioUnid As Decimal)
        db.SetParametro("@fechaSolicitud", _FechaSolicitud)
        db.SetParametro("@IdUsuarioSolicitud", _IdUsuarioSolicitud)
        db.SetParametro("@Codigo", _Codigo)
        db.SetParametro("@CantidadSolicitud", _CantidadSolicitud)
        db.AddParametrosSalidaInt("@Consecutivo", Me.Consecutivo)
        db.SetParametro("@Observaciones", _Observaciones)
        db.SetParametro("@PrecioUnid", _PrecioUnid)
        db.SetParametro("@CantidadPuntos", _CantidadSolicitud)
        db.Ejecutar("Insertar_PedidoBodega", Me.Consecutivo, 4)
    End Sub

    Private Function pasaFicha() As Boolean

        If Me.AplicaCambioenCaja = False Then
            Return True
        End If

        Dim resultado As Boolean = False
        If Me.txtFicha.Text <> "" Then
            If IsNumeric(Me.txtFicha.Text) = True Then
                If CDec(Me.txtFicha.Text) > 0 Then
                    resultado = True
                Else
                    resultado = False
                End If
            Else
                resultado = False
            End If
        Else
            resultado = False
        End If

        If resultado = False Then
            MsgBox("Debe ingresar un numero de ficha valido", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
        End If
        Return resultado
    End Function

    Private Function GetPuntoVenta() As String
        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Return Me.BuscaDatos(Conexion(1))
    End Function

    Private Sub QuitaLineasenBlanco()
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
        For i As Integer = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo").ToString = "0" Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").RemoveAt(i)
            End If
        Next
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
    End Sub

    Private Function PasaValidacionFicha(_Ficha As String) As Boolean

        If Me.AplicaCambioenCaja = True Then
            Dim num As String = _Ficha
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * From viewpreventasactivas Where Ficha = " & num, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                MsgBox("El numero de ficha esta activa, favor cambie el numero.", MsgBoxStyle.Exclamation, "No se puede procesar la operacion.")
                Return False
            End If
            Return True
        End If
        Return True
    End Function

    Private Function PuedeCambiarPrecio(_Cedula As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select CambiarPrecio from Usuarios where cedula = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return CBool(dt.Rows(0).Item("CambiarPrecio"))
        End If
        Return False
    End Function
    Private Function ValidaPrecio() As Boolean
        'zoe
        Dim CambiarPrecio As Boolean = Me.PuedeCambiarPrecio(Cedula_usuario)
        Dim Descripcion As String = ""
        Dim pasaValidacion As Boolean = True
        Dim dif As Decimal = 0
        If coti = True Then Return pasaValidacion
        If Me.ckPD.Checked = True Then Return pasaValidacion
        If CambiarPrecio = False Then
            With BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")
                .EndCurrentEdit()
                For i As Integer = 0 To .Count() - 1
                    .Position = i
                    dif = CDec(.Current("Precio_Unit")) - Me.GetPrecio_Unit(.Current("Codigo"))
                    If Math.Abs(dif) > 50 Then
                        Descripcion = .Current("descripcion")
                        MsgBox("Favor revisar el precio del producto " & Descripcion, MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                        pasaValidacion = False
                    End If
                Next
            End With
        End If

        Return pasaValidacion
        'esto no debe estar cambiando precios
        'With BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")
        '    .EndCurrentEdit()
        '    For i As Integer = 0 To .Count() - 1
        '        .Position = i
        '        Dim dif As Decimal = CDec((.Current("SubTotal") / .Current("Cantidad"))) - CDec(.Current("Precio_Unit"))
        '        If Math.Abs(dif) > 1 Then
        '            .Current("Precio_Unit") = CDec((.Current("SubTotal") / .Current("Cantidad")))
        '            .EndCurrentEdit()
        '        End If
        '    Next
        'End With
    End Function

    Private Function PuedeRealizarVentaCredito() As Boolean
        Dim Respuesta As Boolean = True
        Dim Codigo As String = ""
        Dim Descripcion As String = ""
        Dim dt As New DataTable
        Try
            For i As Integer = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i

                Codigo = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo")
                Descripcion = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")

                cFunciones.Llenar_Tabla_Generico("Select * from Inventario Where Codigo = " & Codigo, dt, CadenaConexionSeePOS)

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("SoloContado") = True Then
                        MsgBox("La venta de '" & Descripcion & "' esta restringida a solo de Contado", MsgBoxStyle.Exclamation, Text)
                        Respuesta = False
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
        Return Respuesta
    End Function

    Public Function IngresarFormasdePago() As Boolean
        '************************************************************************************************************
        'OjO
        '************************************************************************************************************
        'solucion temporal
        'lo mejor es agregar una columna en la tabla configuraciones
        'que determine si se piden formas de pago o no
        'ademas modificar el desencadenador de venta para que depende de esta columna, guarde o no las formas de pago
        '************************************************************************************************************
        'If GetRegistroSeePOS("PideFormaPago") = 1 Then
        '    Return True
        'Else
        '    Return False
        'End If
        Return IsClinica()
    End Function

    Function RegistraOpcionesDePago()
        If Me.DataSet_Facturaciones.Ventas(0).Tipo <> "CRE" Or Me.DataSet_Facturaciones.Ventas(0).Tipo <> "TCR" Or Me.DataSet_Facturaciones.Ventas(0).Tipo <> "MCR" Then
            Try
                Dim Movimiento_Pago_Factura As New frmMovimientoCajaPagoAbono(usua)
                Movimiento_Pago_Factura.Factura = Me.DataSet_Facturaciones.Ventas(0).Num_Factura
                Movimiento_Pago_Factura.fecha = "" & Me.DataSet_Facturaciones.Ventas(0).Fecha
                Movimiento_Pago_Factura.Total = Me.DataSet_Facturaciones.Ventas(0).Total
                Movimiento_Pago_Factura.Tipo = Me.DataSet_Facturaciones.Ventas(0).Tipo
                Movimiento_Pago_Factura.codmod = Me.DataSet_Facturaciones.Ventas(0).Cod_Moneda
                Movimiento_Pago_Factura.Cod_Cliente = Me.DataSet_Facturaciones.Ventas(0).Cod_Cliente
                Movimiento_Pago_Factura.ShowDialog()

                While Movimiento_Pago_Factura.Registra = False
                    Movimiento_Pago_Factura.ShowDialog()
                End While

                If Movimiento_Pago_Factura.Registra Then
                    Dim Cx As New Conexion
                    Dim PrepagoAplicado As Decimal = Movimiento_Pago_Factura.PrepagoAplicado
                    'Cx.UpdateRecords("Ventas", "FacturaCancelado = 1, Prepago = " & PrepagoAplicado & ", Num_Apertura = " & Movimiento_Pago_Factura.NApertura, " Id = " & Me.DataSet_Facturaciones.Ventas(0).Id)

                    If Movimiento_Pago_Factura.RegistrarOpcionesPago() And (Cx.UpdateRecords("Ventas", "FacturaCancelado = 1, Prepago = " & PrepagoAplicado & ", Num_Apertura = " & Movimiento_Pago_Factura.NApertura, " Id = " & Me.DataSet_Facturaciones.Ventas(0).Id)) = "" Then
                        'Movimiento_Pago_Factura.DataSet_Opciones_Pago1.Detalle_pago_caja.Clear()
                        'Movimiento_Pago_Factura.DataSet_Opciones_Pago1.OpcionesDePago.Clear()
                        'MsgBox("Factura registrada satisfactoriamente...")
                        Dim strFactura As String = Movimiento_Pago_Factura.Factura
                        ''cConexion.FacturaCancelada(strFactura)
                        Cx.FacturaCancelada(strFactura)
                    End If
                    'Else
                    '    Movimiento_Pago_Factura.Close()
                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Function


    Private Function PuedeRegistrarVenta(_PVE As Boolean) As Boolean
        Dim Resultado As Boolean = True

        If Me.ClienteRegistradoMAG And _PVE Then
            Resultado = False
        End If

        If Me.Ck_Exonerar.Checked And _PVE Then
            Resultado = False        
        End If

        If Resultado = False Then
            MsgBox("La factura debe ser registrada con F2 o F4", MsgBoxStyle.Exclamation, Me.Text)
        End If

        Return Resultado
    End Function

    Private Sub Registrar(ByVal PV As Boolean, _NumCaja As Integer)
        If PuedeRegistrarVenta(PV) = False Then
            Exit Sub
        End If

        Me.YaEstaFacturando = True
        Me.codigo_cliente = txtcodigo.Text
        Me.nombre_cliente = txtNombre.Text

        If Me.ck_agente.Checked = True Then
            If Me.txtagente.Text <> "" Then
                If IsNumeric(Me.txtagente.Text) Then
                    If CDec(Me.txtagente.Text) > 0 Then
                        Me.txtagente.Text = Me.CodAgente
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("agente") = Me.ck_agente.Checked
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("cod_agente") = Me.CodAgente
                    End If
                End If
            End If
        Else
            Me.CodAgente = 0
        End If


        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = _NumCaja
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = Me.txt_cedula.Text
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = Me.codigo_cliente
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.nombre_cliente
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

        If Me.txtcodigo.Text <> "0" And (Me.txtNombre.Text.ToLower = "cliente de contado" Or Me.txtNombre.Text = "" Or Me.txtNombre.Text.ToLower = "cliente contado") Then
            MsgBox("Ingrese el cliente porfavor.", MsgBoxStyle.Exclamation, Text)
            Me.lblMensaje.Height = 0
            Me.YaEstaFacturando = False
            Exit Sub
        End If

        If Me.txt_cedula.Text <> "0" And Me.txtCorreoComprobantes.Text <> "" And PV = True Then
            If MsgBox("Desea realizar un tiquete electronico al cliente." & vbCrLf _
                      & "Los tiquetes electronicos no llegan al correo." & vbCrLf _
                      & "Desea continuar con el tiquete.", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Confirmar Accion!!!") = MsgBoxResult.No Then
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If
        End If

        If Me.txt_cedula.Text.Length < 9 And PV = False Then
            MsgBox("La identificacion del cliente no es valida", MsgBoxStyle.Exclamation, Text)
            Me.lblMensaje.Height = 0
            Me.YaEstaFacturando = False
            Exit Sub
        End If

        If ckFrecuente.Checked = True And btn_cliente_nuevo.Enabled = True Then
            MsgBox("Para facturar el cliente frecuente debe estar registrado.", MsgBoxStyle.Exclamation, "El cliente frecuente no esta registrado")
            Me.lblMensaje.Height = 0
            Me.YaEstaFacturando = False
            Exit Sub
        End If

        If Me.opApartado.Checked = True And PV = True Then
            MsgBox("Los apartados solo se pueden registrar con F2 o F4", MsgBoxStyle.Exclamation, Text)
            Me.lblMensaje.Height = 0
            Me.YaEstaFacturando = False
            Exit Sub
        End If

        If Me.txt_cedula.Text = "0" And PV = False Then
            MsgBox("Debe ingresar la identificacion del cliente", MsgBoxStyle.Exclamation, "La operacion no se puedo procesar.")
            Me.lblMensaje.Height = 0
            Me.YaEstaFacturando = False
            Exit Sub
        End If

        If Me.opCredito.Checked = True Then
            If Me.PuedeRealizarVentaCredito = False Then
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If
        End If

        Try
            If PV = True And Me.opApartado.Checked = True Then
                MsgBox("Los apartados solo pueden salir con F2 o F4", MsgBoxStyle.Exclamation, Text)
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            Me.ToolBar1.Buttons(2).Enabled = False
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            Me.QuitaLineasenBlanco()

            If Me.ValidaNombreQuimicos(Me.nombre_cliente) = False Then
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            If Me.AplicaCambioenCaja = True And Me.opCredito.Checked = False Then
                If Me.Modo = "PreVentas" Then
                    If Me.EstadoPreventa <> "PreVenta" Then
                        MsgBox("No se puede registrar la preventa, el estado es " & Me.EstadoPreventa & "", MsgBoxStyle.Exclamation, Me.Text)
                        Me.lblMensaje.Height = 0
                        Me.YaEstaFacturando = False
                        Exit Sub
                    End If

                    Dim frm As New frmIngresarNumerodeFicha
                    frm.IdUsuario = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario")
                    frm.txtNumero.Text = Me.txtFicha.Text
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.txtFicha.Text = frm.txtNumero.Text
                        If PasaValidacionFicha(Me.txtFicha.Text) = False Then
                            Me.lblMensaje.Height = 0
                            Me.YaEstaFacturando = False
                            Exit Sub
                        End If
                    Else
                        Me.lblMensaje.Height = 0
                        Me.YaEstaFacturando = False
                        Exit Sub
                    End If
                End If
            End If

            If buscando = True And Me.AplicaCambioenCaja = False Then
                MsgBox("No se puede modificar esta factura, solo reimprimirla", MsgBoxStyle.Information)
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then 'Si la factura no tiene detalle
                MsgBox("No se Puede Registrar una venta si no contiene artículos", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = False
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                txtCod_Articulo.Focus()
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            Me.Revisa_Error_Bodegas_VeterinariaLiberia()
            If Me.ValidaPrecio() = False Then
                Exit Sub
            End If

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            Me.txtcodigo.Text = codigo_cliente
            Me.txtNombre.Text = nombre_cliente

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = codigo_cliente
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("nombre_cliente") = nombre_cliente
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()

            If Me.txtorden.Text.Length < 3 And Me.ObligaOrdenCompra = True And Me.opCredito.Checked = True Then
                MsgBox("Debe de ingresar la orden de compra para este cliente", MsgBoxStyle.Exclamation, "Favor Ingresar la orden de compra")
                Me.txtorden.Focus()
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            If Me.txtNombre.Text = "" Or txtNombre.Text = "INGRESE EL NOMBRE" Then
                MsgBox("Debe de Digitar el Nombre del Cliente, Solicitelo con amabilidad por favor....!", MsgBoxStyle.Information)
                Me.lblMensaje.Height = 0
                txtNombre.SelectAll()
                Me.txtNombre.Focus()
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            If Me.CajaAbierta(BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Num_Caja")) = False Then
                MsgBox("La caja no esta abierta, No se puede facturar, pruebe en otra caja!!!", MsgBoxStyle.Exclamation, Text)
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            If Me.ValidaDGT = False Then
                MsgBox("Debe ingresar la identificacion del cliente", MsgBoxStyle.Exclamation, Text)
                Me.lblMensaje.Height = 0
                Exit Sub
            End If

            If PV = False Then
                Dim dt As New DataTable
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                dt = db.Ejecutar("Select TipoCliente, Cedula, Nombre, Telefono_01, CorreoComprobante, Direccion From Clientes Where Identificacion = '" & Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") & "'", CommandType.Text)

                If dt.Rows.Count > 0 Then
                    If Me.PasaFormatoCedula = False Or Me.GetActualizado() = False Then
                        MsgBox("La informacion del cliente esta incorrecta o desactualizada, Favor Actualizar Datos", MsgBoxStyle.Information, Text)
                        Dim frm As New frm_cliente_rapido
                        frm.BanderaActualizar = True
                        frm.Cod_Cliente = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
                        frm.cbo_tipo_cliente.Text = dt.Rows(0).Item("TipoCliente")
                        frm.txtCodigo.Text = dt.Rows(0).Item("Cedula")
                        frm.txtNombre.Text = dt.Rows(0).Item("Nombre")
                        frm.txtTelefono.Text = dt.Rows(0).Item("Telefono_01")
                        frm.txt_email.Text = dt.Rows(0).Item("CorreoComprobante")
                        frm.Txtdireccion.Text = dt.Rows(0).Item("Direccion")
                        If frm.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                            Me.lblMensaje.Height = 0
                            Me.YaEstaFacturando = False
                            Exit Sub
                        End If
                    End If
                Else
                    'debe hacer algo???
                End If
            End If

            Me.PoneTexto()

            If PV = True And Me.opCredito.Checked = True Then
                MsgBox("La factura es de credito, precione F2 o F4 para registrarla.", MsgBoxStyle.Exclamation, "No se puede procesar la operacion!!!")
                Me.lblMensaje.Height = 0
                Me.YaEstaFacturando = False
                Exit Sub
            End If

            'valida que la ficha no este activa para no  repetirla 
            If Me.opCredito.Checked = False Then
                If PasaValidacionFicha(Me.txtFicha.Text) = False Then
                    Me.lblMensaje.Height = 0
                    Me.YaEstaFacturando = False
                    Exit Sub
                End If
            End If

            If MessageBox.Show("¿Desea Registrar esta Factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(2).Enabled = True

                txtCod_Articulo.Focus()
                Me.lblMensaje.Height = 0
                Me.TclCaja = ""
                Me.YaEstaFacturando = False
                Exit Sub
            End If
            Dim mascotas As Boolean = Me.Ck_Mascotas.Checked
            Dim taller As Boolean = Me.Ck_Taller.Checked

            BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Mascotas") = mascotas
            BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Taller") = taller

            If opCredito.Checked Then
                Dim Firma As New Firma
                Firma.Encargado = ""
                Firma.Cliente = BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
                Firma.ShowDialog()
                If Firma.DialogResult = DialogResult.OK Then
                    BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = Firma.Encargado
                Else
                    Me.lblMensaje.Height = 0
                    Me.YaEstaFacturando = False
                    Exit Sub
                End If
                Firma.Dispose()
            Else
                BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = "NINGUNO"
            End If
            BindingContext(DataSet_Facturaciones, "Ventas").Current("pagoImpuesto") = impuesto_cliente
            BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            Verificar_Consecutivos(PV)
            If num_fact <> 0 Then
                BindingContext(DataSet_Facturaciones, "Ventas").Current("Num_Factura") = num_fact
            End If
            If tipo_fact <> "" Then
                BindingContext(DataSet_Facturaciones, "Ventas").Current("Tipo") = tipo_fact
            End If

            dtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            '***********************************************************************************
            'Ojo Rifa
            Me.buscar_rifa()
            '***********************************************************************************

            If Me.RegistrarVenta() Then 'se registra en la base de datos then
                Me.IngresoIdentificacion = False
                buscar_rifa()
                Me.GuardarPedido()
                Me.DataSet_Facturaciones.AcceptChanges()

                Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id")
                Dim Tipo As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo")

                If Me.CodigoCupon > 0 Then
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update CuponDetalle Set Id_Factura = " & id & " Where Codigo = " & Me.CodigoCupon, CommandType.Text)
                End If

                If coti = True Then
                    If Me.AplicaCambioenCaja = True And opCredito.Checked = False Then
                        Dim IdCotizacion As String = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cotizacion")
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.Ejecutar("Update Preventas set IdCotizacion = " & IdCotizacion & " where id = " & id, CommandType.Text)
                    Else
                        Dim IdCotizacion As String = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cotizacion")
                        Dim erroren As String = ""
                        Try
                            Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Venta") = True
                            Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").EndCurrentEdit()
                            Me.Adapter_Coti.Update(Me.DataSet_Facturaciones, "Cotizacion")
                        Catch ex As Exception
                            erroren = "1 "
                        End Try
                        Try
                            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                            db.Ejecutar("Update Cotizacion set Venta = 1, EstadoActual = 'Ganada', ObservacionEstado = 'cambio estado automatico por sistema', Id_Factura = " & id & " where Cotizacion = " & IdCotizacion, CommandType.Text)
                            coti = False
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Problemas al actualizar cotizacion " & erroren & " 2")
                        End Try
                    End If
                End If

                If Me.AplicaCambioenCaja = True Then
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update Preventas set Id_FacturaRemplaza = " & Me.IdFacturaRemplaza & ", Ficha = " & Me.txtFicha.Text & ", Frecuente = " & IIf(Me.ckFrecuente.Checked = False, 0, 1) & " where Id = " & id, CommandType.Text)
                    Me.txtFicha.Text = ""
                    Try
                        If Me.cantidad_cupon > 0 Then
                            db.Ejecutar("Update Preventas set Cupones = " & Me.cantidad_cupon & " Where Id = " & id, CommandType.Text)
                        End If
                    Catch ex As Exception
                    End Try
                Else
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update ventas set Id_FacturaRemplaza = " & Me.IdFacturaRemplaza & ", Frecuente = " & IIf(Me.ckFrecuente.Checked = False, 0, 1) & " where id = " & id, CommandType.Text)
                End If

                If Tipo = "CRE" Then
                    If Me.AplicaCambioenCaja = True Then
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.AddParametro("@IdFactura", id)
                        db.AddParametro("@PuntodeVenta", Me.GetPuntoVenta)
                        db.Ejecutar("PreVenta_Factura")
                    End If
                End If

                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True

                Me.SimpleButton1.Enabled = False
                Me.SimpleButton2.Enabled = False

                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False

                Me.GroupBox6.Enabled = False
                Me.GroupBox3.Enabled = False
                Me.txtorden.Enabled = True
                Me.Label10.Visible = False
                Me.Label11.Visible = False
                Me.Label_Costobase.Visible = False
                Me.ComboBox1.Enabled = False
                Ck_Exonerar.Enabled = False
                txtHecho.Text = ""
                txtExistencia.Text = "0"
                txtExistencia.EditValue = 0
                Me.logeado = False

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""

                Me.txtUsuario.Focus()
                Me.SimpleButton3.Enabled = False
                Me.TxtUtilidad.Text = ""
                Ck_Taller.Enabled = False
                Ck_Mascotas.Enabled = False
                Me.Label41.Visible = False
                Me.txtEncargado.Visible = False

                If Me.IngresarFormasdePago() And Me.opCredito.Checked = False Then
                    'si ocupa pedir las formas de pago
                    If AplicaCambioenCaja() = True Then
                        Dim frm As New frmBuscarFichasActivas
                        frm.CargarPrimerUsuario(Me.Cedula_usuario)
                        frm.MdiParent = Me.MdiParent
                        frm.Show()
                    Else
                        Me.RegistraOpcionesDePago()
                    End If
                End If
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                txt_cedula.Text = ""
                Me.reimprimir = False
                Me.YaEstaFacturando = False
                'Solo imprime si no esta activado el modo caja o si la opcion de credito esta activa
                If Me.AplicaCambioenCaja = False Or Me.opCredito.Checked = True Then
                    Select Case Me.TclCaja
                        Case "F2"
                            Imprimir(id, PV, 1)
                        Case "F3"
                            Imprimir(id, PV, 1)
                        Case "F4"
                            Imprimir(id, PV, 2)
                        Case "F5"
                            Imprimir(id, PV, 2)
                        Case "F6"
                            Imprimir(id, PV, 1) 'caja 3
                        Case "F7"
                            Imprimir(id, PV, 1) 'caja 3
                    End Select
                End If
                Me.imprime_cupon = False

                If buscando = True Then buscando = False

                Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                Me.DataSet_Facturaciones.Ventas.Clear()
                DataSet_Facturaciones.Lotes.Clear()
                AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")

                Me.ToolBar1.Buttons(2).Enabled = True
                Me.ToolBar1.Buttons(5).Enabled = False

            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.lblMensaje.Height = 0
                Me.TclCaja = ""
            End If
            Me.lblMensaje.Height = 0
            Me.TclCaja = ""
        Catch ex As System.Exception
            Me.lblMensaje.Height = 0
            Me.TclCaja = ""
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
        Me.ActualizaModo()
    End Sub
    Sub agregar_regalias()

    End Sub

    Function Registrar_SinRestricciones() As Boolean
        Try
            If Me.sinrestriccion Then
                Dim funciones As New Conexion
                Dim mens As String
                mens = funciones.UpdateRecords("Clientes", "sinrestriccion = 'NO'", "identificacion =" & Me.txtcodigo.Text)

                If mens <> "" Then
                    MsgBox(mens)
                    Return False
                Else
                    Return True
                End If

            Else
                Return True
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Return False
        End Try
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

    Private Modo As String

    Private Sub ActualizaModo()
        'vuelve al estado inicial
        If Me.AplicaCambioenCaja = True Then
            Me.Modo = "PreVentas"
        Else
            Me.Modo = "Ventas"
        End If
    End Sub

    Private Function GetTabla()
        Dim Tabla As String = ""
        'Tabla = "Ventas"
        'Tabla = "AdelantoVentas"
        'Tabla = "PreVentas"
        Tabla = Me.Modo
        If Tabla = "" Then Tabla = "Ventas"
        Return Tabla
    End Function

    Private InsertEncabezado As String = ""
    Private UpdateEncabezado As String = ""
    Private DeleteEncabezado As String = ""

    Private InsertDetalle As String = ""
    Private UpdateDetalle As String = ""
    Private DeleteDetalle As String = ""

    Function RegistrarVenta() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            'existencia_bodega()
            Me.Adapter_Ventas.InsertCommand.Transaction = Trans
            Me.Adapter_Ventas.UpdateCommand.Transaction = Trans
            Me.Adapter_Ventas.DeleteCommand.Transaction = Trans

            Me.Adapter_Ventas_Detalles.InsertCommand.Transaction = Trans
            Me.Adapter_Ventas_Detalles.UpdateCommand.Transaction = Trans
            Me.Adapter_Ventas_Detalles.DeleteCommand.Transaction = Trans

            'AdapterLotes.InsertCommand.Transaction = Trans
            'AdapterLotes.UpdateCommand.Transaction = Trans

            If Me.AplicaCambioenCaja = True Then
                Dim Tabla As String = Me.GetTabla
                If Tabla = "PreVentas" And Me.opCredito.Checked = True Then Tabla = "Ventas" 'No existen preventas de credito
                Me.Adapter_Ventas.InsertCommand.CommandText = Me.InsertEncabezado.Replace("?", Tabla)
                Me.Adapter_Ventas.UpdateCommand.CommandText = Me.UpdateEncabezado.Replace("?", "PreVentas")
                Me.Adapter_Ventas.DeleteCommand.CommandText = Me.DeleteEncabezado.Replace("?", "PreVentas")

                Me.Adapter_Ventas_Detalles.InsertCommand.CommandText = Me.InsertDetalle.Replace("?", Tabla)
                Me.Adapter_Ventas_Detalles.UpdateCommand.CommandText = Me.UpdateDetalle.Replace("?", "PreVentas")
                Me.Adapter_Ventas_Detalles.DeleteCommand.CommandText = Me.DeleteDetalle.Replace("?", "PreVentas")
            End If

            Adapter_Ventas.Update(Me.DataSet_Facturaciones, "Ventas")
            Adapter_Ventas_Detalles.Update(Me.DataSet_Facturaciones.Ventas_Detalle)
            'AdapterLotes.Update(DataSet_Facturaciones.Lotes)

            Trans.Commit()

            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox("v " & ex.ToString, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

#Region "Imprimir"
    'Function Imprimir(ByVal Id_Factura As Double, ByRef Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument)   'MOD SAJ 01092006
    Private Sub Imprimir2()
        Try
            Try
                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
                Dim rpt As New Reporte_FacturaPVEs

                Dim myTables As Tables = rpt.Database.Tables

                For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                    Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                    myConnectionInfo.ServerName = "."
                    myConnectionInfo.DatabaseName = "Seepos"
                    myConnectionInfo.UserID = "sa"
                    myConnectionInfo.Password = "123"
                    myTableLogonInfo.ConnectionInfo = myConnectionInfo
                    myTable.ApplyLogOnInfo(myTableLogonInfo)
                Next
                'frmReportViewer.CrystalReportViewer1.ReportSource = rpt

                rpt.SetParameterValue("id_factura", txtFactura.Text)
                rpt.SetParameterValue("reimpresion", reimprimir)
                rpt.PrintToPrinter(1, False, 0, 0)
                rpt.Close()
                rpt.Dispose()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

            '' \\endreport
            'Me.ToolBar1.Buttons(4).Enabled = False
            ''EL MODULO ANALIZA SI EXISTE  EN LA RUTA ESPECIFICADA EL REPORTE EN CUESTION, DADO EL CASO DE QUE EL REPORTE NO EXISTA CARGA EL STANDAR DEL SISTEMA
            'Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize

            'If System.IO.File.Exists(Application.StartupPath & "\Reportes\Reporte_FacturaPVEs.rpt") = True Then
            '    ReporteDocumento.Load(Application.StartupPath & "\Reportes\Reporte_FacturaPVEs.rpt")
            'Else
            '    If MessageBox.Show("¿Desea imprimir en grande?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            '        ReporteDocumento = New Reporte_Cotizacion
            '        'ReporteDocumento.SetParameterValue(0, CDbl(txtCotizacion.Text))
            '        ReporteDocumento.SetParameterValue(1, False)
            '        CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent)
            '    Else
            '        ReporteDocumento = New Reporte_FacturaPVEs
            '        ReporteDocumento.SetParameterValue("id_factura", txtFactura.Text)
            '        ReporteDocumento.SetParameterValue("reimpresion", reimprimir)
            '        ReporteDocumento.PrintOptions.PrinterName = Automatic_Printer_Dialog(3)
            '        CrystalReportsConexion.LoadReportViewer(Nothing, ReporteDocumento, True, CadenaConexionSeePOS)
            '        ReporteDocumento.PrintToPrinter(1, True, 0, 0)
            '    End If

            'End If

            'Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub FRViolators_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Public Sub ShowReport(ByVal strReportPath As String)

        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New ReportDocument

        rptDoc.Load(strReportPath)
        rptDoc.SetParameterValue(0, txtFactura.Text)
        rptDoc.SetParameterValue(1, reimprimir)
        rptDoc.SetDatabaseLogon("seesoft", "12345", "192.168.0.101", "seepos")
    End Sub

    Private Function ImprimeSiempreenPVE() As Boolean
        Dim resultado As Boolean = False

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select SoloPVE from configuraciones", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("SoloPVE")
        Else
            resultado = False
        End If

        Return resultado
    End Function

    Private Function ImprimeCreditoenPVP() As Boolean
        Dim resultado As Boolean = False

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select ImprimeCreditoPVE from configuraciones", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("ImprimeCreditoPVE")
        Else
            resultado = False
        End If

        Return resultado
    End Function

    Private Function ImprimeContadoenPVP() As Boolean
        Dim resultado As Boolean = False

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select ImprimeContadoPVE from configuraciones", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("ImprimeContadoPVE")
        Else
            resultado = False
        End If

        Return resultado
    End Function

    Private Function TokenNegativo() As Boolean
        Dim resultado As Boolean = False

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select TokenNegativo from configuraciones", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("TokenNegativo")
        Else
            resultado = False
        End If

        Return resultado
    End Function

    Private esTermica As Boolean = False

    Private Sub Imprimir(ByVal Id_Factura As Double, ByVal PVE As Boolean, Optional ByVal Caja As Integer = 1) 'MOD SAJ 01092006

        If IsClinica() Then
            'solo para guanavet clinica
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo") = "CRE" Then

                Dim Impresora As String = ImpresoraCredito()

                If Impresora <> "" Then
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Impresora

                    rptGenerica.Refresh()
                    rptGenerica.SetParameterValue(0, Id_Factura)
                    rptGenerica.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    rptGenerica.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                End If
                Exit Sub
            Else
                Caja = 1
                PVE = True
            End If
        End If

        Try

            If Me.imprime_cupon = True Then
                Dim cod As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
                If esEmpresaInterna(cod) = False Then
                    Dim temp As Integer = 0
                    While temp < Me.cantidad_cupon
                        Me.Imprimir_Tiquete_Rifa(Caja, Id_Factura)
                        temp += 1
                    End While
                End If
            End If


            If PVE Then
                If Caja = 1 Or Caja = 11 Then
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                    facturaPVE.Refresh()
                    facturaPVE.SetParameterValue(0, reimprimir)
                    facturaPVE.SetParameterValue(1, False)
                    facturaPVE.SetParameterValue(2, Id_Factura)
                    facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    If esTermica = True Then
                        facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If
                End If
                If Caja = 2 Or Caja = 12 Then
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                    facturaPVE.SetParameterValue(0, reimprimir)
                    facturaPVE.SetParameterValue(1, False)
                    facturaPVE.SetParameterValue(2, Id_Factura)
                    facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    If esTermica = True Then
                        facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If
                End If
            Else
                '*************************************************************************************************************************
                If ImprimeSiempreenPVE() = True Then 'Imprime todo en PVE
                    '*********************************************************************************************************************
                    If Caja = 1 Or Caja = 1 Then
                        Dim PrinterSettings1 As New Printing.PrinterSettings
                        Dim PageSettings1 As New Printing.PageSettings
                        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                        facturaPVE.SetParameterValue(0, reimprimir)
                        facturaPVE.SetParameterValue(1, False)
                        facturaPVE.SetParameterValue(2, Id_Factura)
                        facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                        If esTermica = True Then
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                        End If
                    End If
                    If Caja = 2 Or Caja = 12 Then
                        Dim PrinterSettings1 As New Printing.PrinterSettings
                        Dim PageSettings1 As New Printing.PageSettings
                        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                        facturaPVE.SetParameterValue(0, reimprimir)
                        facturaPVE.SetParameterValue(1, False)
                        facturaPVE.SetParameterValue(2, Id_Factura)
                        facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                        If esTermica = True Then
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                        End If
                    End If
                    '*********************************************************************************************************************
                ElseIf ImprimeCreditoenPVP() = True Then 'Imprime las de credito en grande y el resto en PVE
                    '*********************************************************************************************************************
                    If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo") = "CRE" Then
                        If Caja = 1 Or Caja = 11 Then
                            Dim PrinterSettings1 As New Printing.PrinterSettings
                            Dim PageSettings1 As New Printing.PageSettings
                            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(0)

                            facturaPVE.SetParameterValue(0, reimprimir)
                            facturaPVE.SetParameterValue(1, False)
                            facturaPVE.SetParameterValue(2, Id_Factura)
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            'If esTermica = True Then
                            '    facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            'End If
                        End If
                        If Caja = 2 Or Caja = 12 Then
                            Dim PrinterSettings1 As New Printing.PrinterSettings
                            Dim PageSettings1 As New Printing.PageSettings
                            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(6)

                            facturaPVE.SetParameterValue(0, reimprimir)
                            facturaPVE.SetParameterValue(1, False)
                            facturaPVE.SetParameterValue(2, Id_Factura)
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            'If esTermica = True Then
                            '    facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            'End If
                        End If
                    Else
                        If Caja = 1 Or Caja = 11 Then
                            Dim PrinterSettings1 As New Printing.PrinterSettings
                            Dim PageSettings1 As New Printing.PageSettings
                            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                            facturaPVE.SetParameterValue(0, reimprimir)
                            facturaPVE.SetParameterValue(1, False)
                            facturaPVE.SetParameterValue(2, Id_Factura)
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            If esTermica = True Then
                                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            End If
                        End If
                        If Caja = 2 Or Caja = 12 Then
                            Dim PrinterSettings1 As New Printing.PrinterSettings
                            Dim PageSettings1 As New Printing.PageSettings
                            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                            facturaPVE.SetParameterValue(0, reimprimir)
                            facturaPVE.SetParameterValue(1, False)
                            facturaPVE.SetParameterValue(2, Id_Factura)
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            If esTermica = True Then
                                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            End If
                        End If
                    End If
                    '*********************************************************************************************************************
                ElseIf ImprimeContadoenPVP() = True Then 'Imprime las de credito en grande y el resto en PVE
                    '*********************************************************************************************************************
                    If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo") = "CRE" Then
                        Me.Imprime(Caja)
                    Else
                        If Caja = 1 Or Caja = 11 Then
                            Dim PrinterSettings1 As New Printing.PrinterSettings
                            Dim PageSettings1 As New Printing.PageSettings
                            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                            facturaPVE.SetParameterValue(0, reimprimir)
                            facturaPVE.SetParameterValue(1, False)
                            facturaPVE.SetParameterValue(2, Id_Factura)
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            If esTermica = True Then
                                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            End If
                        End If
                        If Caja = 2 Or Caja = 12 Then
                            Dim PrinterSettings1 As New Printing.PrinterSettings
                            Dim PageSettings1 As New Printing.PageSettings
                            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                            facturaPVE.SetParameterValue(0, reimprimir)
                            facturaPVE.SetParameterValue(1, False)
                            facturaPVE.SetParameterValue(2, Id_Factura)
                            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            If esTermica = True Then
                                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                            End If
                        End If
                    End If
                    '*********************************************************************************************************************
                Else 'Imprime Contado y Credito en Grande
                    '*********************************************************************************************************************
                    Imprime(Caja)
                End If

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Imprimir_Tiquete_Rifa(ByVal _Caja As Integer, ByVal _IdFactura As String)

        Dim NombreImpresoraCupones As String = ""

        If NombreImpresoraCupones = "" Then
            If _Caja = 1 Then
                NombreImpresoraCupones = Automatic_Printer_Dialog(3)
                'NombreImpresoraCupones = Automatic_Printer_Dialog(5)
            End If

            If _Caja = 2 Then
                NombreImpresoraCupones = Automatic_Printer_Dialog(5)
            End If
        End If

        Dim PrinterSettings1 As New Printing.PrinterSettings
        Dim PageSettings1 As New Printing.PageSettings
        PrinterSettings1.PrinterName = NombreImpresoraCupones

        rptTiquete.SetParameterValue(0, _IdFactura)
        rptTiquete.PrintToPrinter(PrinterSettings1, PageSettings1, False)

        'Select Case _Caja
        '    Case 1
        '        Dim PrinterSettings1 As New Printing.PrinterSettings
        '        Dim PageSettings1 As New Printing.PageSettings
        '        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

        '        rptTiquete.SetParameterValue(0, _IdFactura)
        '        rptTiquete.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        '    Case 2
        '        Dim PrinterSettings1 As New Printing.PrinterSettings
        '        Dim PageSettings1 As New Printing.PageSettings
        '        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

        '        rptTiquete.SetParameterValue(0, _IdFactura)
        '        rptTiquete.PrintToPrinter(PrinterSettings1, PageSettings1, False)
        'End Select
    End Sub

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION" 'FACTURACION
                    If PrinterToSelect = 0 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CONTADO"
                    If PrinterToSelect = 1 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CREDITO"
                    If PrinterToSelect = 2 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA"
                    If PrinterToSelect = 3 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FAX"
                    If PrinterToSelect = 4 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA02"
                    If PrinterToSelect = 5 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FACTURACION02" 'FACTURACION
                    If PrinterToSelect = 6 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If

                Case "CUPONES" 'CUPONES DE RIFAS
                    If PrinterToSelect = 7 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If

            End Select
        Next

        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If PrinterDialog.ShowDialog.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        Else
            Return ""
        End If
    End Function

    Private Function valida_permisos_impresion() As Boolean
        If VerificandoAcceso_a_Modulos("ReimprimirFactura", "ReimprimirFactura", usua.Cedula, "Operaciones Ventas") = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Imprime(Optional ByVal Caja As Integer = 1)
        Try
            Dim pd As New System.Drawing.Printing.PrintDocument
            Dim impresora As String = Automatic_Printer_Dialog(0)
            If impresora <> "" Then
                If Caja = 1 Then
                    pd.PrinterSettings.PrinterName = Automatic_Printer_Dialog(0)
                End If
                If Caja = 2 Then
                    pd.PrinterSettings.PrinterName = Automatic_Printer_Dialog(6)
                End If
                Cant = 0 : PaginaActual = 1
                AddHandler pd.PrintPage, AddressOf pd_PrintPage
                pd.Print()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Configurar_Hoja_CrystalReport()
        'Se obtiene el informe a configurar            
        Dim rdInforme As New Reporte_ABC

        'Obtener nombre de impresora
        Dim print_name As String = "Impresora"
        'Obtener nombre de hoja personalizada
        Dim print_paper As String = "HojaPersonalizada"

        'Opciones del Crystal Report
        Dim repOptions As CrystalDecisions.CrystalReports.Engine.PrintOptions
        'Se aplican al informe
        With rdInforme
            'Se obtienen la opciones de impresion
            repOptions = .PrintOptions
            'Se setean las opciones
            With repOptions
                'Obtiene el id del papel --> utiliza una función especial
                .PaperSize = GetPapersizeID(print_name, print_paper)
                'Señala la impresora a utilizar
                .PrinterName = print_name
            End With
        End With
    End Sub
    Public Function GetPapersizeID(ByVal PrinterName As String, ByVal PaperSizeName As String) As Integer
        Dim pdprint As New System.Drawing.Printing.PrintDocument
        Dim PaperSizeID As Integer = 0
        Dim ppname As String = ""
        pdprint.PrinterSettings.PrinterName = PrinterName
        For i As Integer = 0 To pdprint.PrinterSettings.PaperSizes.Count - 1
            Dim rawKind As Integer
            ppname = PaperSizeName
            If pdprint.PrinterSettings.PaperSizes(i).PaperName = ppname Then
                rawKind = CInt(pdprint.PrinterSettings.PaperSizes(i).Kind)
                PaperSizeID = rawKind
                Exit For
            End If
        Next
        Return PaperSizeID

    End Function
    Private Function DevuelveNum_Factura() As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Num_Factura from Ventas where Id = " & Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id"), dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Num_Factura")
        End If
    End Function

    Private Function Devuelve_TipoFactura() As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Tipo from Ventas where Id = " & Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id"), dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo")
        End If
    End Function

    Private ConsecutivoMh, ClaveMH As String

    Private Sub CargarConsecutivos(_Id As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select ConsecutivoMH, ClaveMH from Ventas Where Id = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.ConsecutivoMh = dt.Rows(0).Item("ConsecutivoMH")
            Me.ClaveMH = dt.Rows(0).Item("ClaveMH")
        End If
    End Sub

    Private Function GetCorreoFactura(_IdFactura As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select isnull(c.CorreoComprobante,'') as Correo from Ventas v left join Clientes c on v.Cod_Cliente = c.identificacion where v.Id = " & _IdFactura, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return " Correo: " & dt.Rows(0).Item("Correo")
        End If
        Return ""
    End Function

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As System.Drawing.Printing.PrintPageEventArgs)
        Try
            Dim Vendedor As String
            Dim Func As New Conexion
            Dim Posicion, Paginas, Can As Integer
            Dim Doub As Double = 0
            Dim Centrar As New StringFormat
            Dim Derecha As New StringFormat
            Centrar.Alignment = StringAlignment.Center
            Derecha.Alignment = StringAlignment.Far
            Dim simbolo As String = ""
            If DataSet_Facturaciones.Ventas(0).Moneda_Nombre = "COLON" Then
                simbolo = "¢"
            End If
            If DataSet_Facturaciones.Ventas(0).Moneda_Nombre = "DOLAR" Then
                simbolo = "$"
            End If

            Dim Letra As String = ""
            If DataSet_Facturaciones.Ventas(0).Num_Caja = 1 Then
                Letra = "A"
            ElseIf DataSet_Facturaciones.Ventas(0).Num_Caja = 2 Then
                Letra = "B"
            ElseIf DataSet_Facturaciones.Ventas(0).Num_Caja = 3 Then
                Letra = "C"
            End If

            Me.CargarConsecutivos(Me.DataSet_Facturaciones.Ventas(0).Id)
            Dim CorreoFactura As String = Me.GetCorreoFactura(Me.DataSet_Facturaciones.Ventas(0).Id)

            If ClaveMH = "" Then
                MsgBox("no se pudo obtener la factura.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                Exit Sub
            End If

            '-------------------------------------------------------------------------------
            'DEFINE CANTIDAD DE PAGINAS
            Doub = (DataSet_Facturaciones.Ventas_Detalle.Count / 10)
            If (Doub - Int(Doub)) <> 0 And (Doub - Int(Doub)) < 0.5 Then
                Paginas = Doub + 1
            Else
                Paginas = Doub
            End If
            '////// POR MEDIO DE REGISTRO SE SELECCIONA EL TIPO DE REPORTE YA QUE PARA LA 
            'GUANAVET EL ORDEN EN LA FACTURA ES DISTINTO
            If GetSetting("seesoft", "seepos", "Esveterinaria") = 1 Then 'SUPER VETERINARIA LIBERIA
                Dim XX As RectangleF = New RectangleF(620, 495, 150, 20) : ev.Graphics.DrawString("XXXXXXX", New System.Drawing.Font("Arial", 16, FontStyle.Bold), Brushes.Black, XX, New StringFormat)

                If Me.reimprimir = True Then
                    Dim RI As RectangleF = New RectangleF(85, 10, 220, 20) : ev.Graphics.DrawString("R", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, RI, New StringFormat)
                End If

                Dim tipo As String = Devuelve_TipoFactura()

                If tipo.IndexOf("CR") >= 0 Then
                    Dim TipoCre As RectangleF = New RectangleF(635, 30, 50, 20) : ev.Graphics.DrawString("X", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, TipoCre, New StringFormat)
                Else
                    Dim TipoCon As RectangleF = New RectangleF(555, 30, 50, 20) : ev.Graphics.DrawString("X", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, TipoCon, New StringFormat)
                End If

                Dim Dia As RectangleF = New RectangleF(480, 85, 75, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Day, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Dia, Centrar)
                Dim Mes As RectangleF = New RectangleF(550, 85, 75, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Month, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Mes, Centrar)
                Dim Anno As RectangleF = New RectangleF(630, 85, 100, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Year, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Anno, Centrar)
                Dim Hora As RectangleF = New RectangleF(540, 100, 100, 15) : ev.Graphics.DrawString(Format(DataSet_Facturaciones.Ventas(0).Fecha, "hh:mm:ss tt"), New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Hora, Centrar)
                Dim Factura As RectangleF = New RectangleF(450, 5, 220, 20) : ev.Graphics.DrawString("Interno " & Letra & "" & Me.DevuelveNum_Factura & " - " & tipo, New System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, Factura, Derecha)
                Dim Cliente As RectangleF = New RectangleF(70, 115, 400, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Nombre_Cliente & " (" & DataSet_Facturaciones.Ventas(0).Cod_Cliente & ")", New System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, Cliente, New StringFormat)
                Dim Direccion As RectangleF = New RectangleF(70, 137, 400, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Direccion, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Direccion, New StringFormat)
                Vendedor = Func.SQLExeScalar("SELECT Nombre FROM Usuarios WHERE (Cedula = '" & DataSet_Facturaciones.Ventas(0).Cedula_Usuario & "')")
                Dim Atendido As RectangleF = New RectangleF(70, 154, 150, 15) : ev.Graphics.DrawString(Vendedor, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Atendido, New StringFormat)
                Dim Caja As RectangleF = New RectangleF(650, 154, 150, 15) : ev.Graphics.DrawString("Caja #" & DataSet_Facturaciones.Ventas(0).Num_Caja, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Caja, New StringFormat)
                Dim Observaciones As RectangleF = New RectangleF(312, 154, 200, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Observaciones, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Observaciones, New StringFormat)
                'SI TIENE NUMERO DE ORDEN
                If DataSet_Facturaciones.Ventas(0).Orden > 0 Then
                    Dim Orden As RectangleF = New RectangleF(540, 137, 90, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Orden, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Orden, New StringFormat)
                End If
                'SI TIENE VENCIMIENTO
                If tipo.IndexOf("CR") >= 0 Then
                    Dim Vence As RectangleF = New RectangleF(525, 154, 200, 15) : ev.Graphics.DrawString(Format(DataSet_Facturaciones.Ventas(0).Vence, "dd/MM/yyyy"), New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, Vence, New StringFormat)
                End If
                'SI ESTA ANULADA
                If DataSet_Facturaciones.Ventas(0).Anulado Then
                    Dim Anulado As RectangleF = New RectangleF(312, 137, 200, 15) : ev.Graphics.DrawString("ANULADO", New System.Drawing.Font("ARIAL", 10, FontStyle.Bold), Brushes.Black, Anulado, New StringFormat)
                End If
                '-------------------------------------------------------------------------------

                '-------------------------------------------------------------------------------
                '------------------------------- DETALLES - ORA --------------------------------
                ''AGREGA LOS ARTICULOS
                Posicion = 187

                Dim Articulo As RectangleF = New RectangleF(150, Posicion, 294, 15) : Dim SubtotalDet As RectangleF = New RectangleF(630, Posicion, 100, 15)
                Dim DescuentoD As RectangleF = New RectangleF(555, Posicion, 75, 15) : Dim CantDet As RectangleF = New RectangleF(-15, Posicion, 70, 15)
                Dim PrecioUnit As RectangleF = New RectangleF(490, Posicion, 75, 15) : Dim Codigo As RectangleF = New RectangleF(40, Posicion, 90, 15)
                Dim Grabado As RectangleF = New RectangleF(458, Posicion, 75, 15)

                Can = IIf((DataSet_Facturaciones.Ventas_Detalle.Count - Cant) > 10, 10, DataSet_Facturaciones.Ventas_Detalle.Count - Cant)
                For x As Integer = 0 To Can - 1
                    CantDet.Y = Posicion : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Cantidad, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, CantDet, Derecha)
                    Codigo.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).CodArticulo, New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Codigo, Derecha)
                    Articulo.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Descripcion, New System.Drawing.Font("Arial", 9, FontStyle.Regular), Brushes.Black, Articulo, New StringFormat)
                    If DataSet_Facturaciones.Ventas_Detalle(x + Cant).SubtotalGravado > 0 Then
                        Grabado.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Impuesto, New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Grabado, New StringFormat)
                    End If
                    PrecioUnit.Y = Posicion : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Precio_Unit, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, PrecioUnit, Derecha)
                    DescuentoD.Y = Posicion : ev.Graphics.DrawString("" & Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Descuento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoD, Derecha)
                    SubtotalDet.Y = Posicion : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).SubTotal, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, SubtotalDet, Derecha)
                    Posicion = Posicion + 20
                Next
                ''-------------------------------------------------------------------------------

                ''-------------------------------------------------------------------------------
                ''------------------------------ ULTIMA LINEA - ORA -----------------------------
                If (DataSet_Facturaciones.Ventas_Detalle.Count - Cant) <= 8 Then
                    Dim MExento As RectangleF = New RectangleF(40, Posicion, 200, 15) : ev.Graphics.DrawString("(*) EXCENTO", New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, MExento, New StringFormat)
                    Dim Ultima As RectangleF = New RectangleF(80, Posicion, 500, 15) : ev.Graphics.DrawString("= = = = > ULTIMA LINEA < = = = =", New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, Ultima, Centrar)
                    Posicion = Posicion + 16
                    Dim Clave As RectangleF = New RectangleF(105, Posicion, 500, 15) : ev.Graphics.DrawString("Clave Nº " & Me.ClaveMH, New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Clave, New StringFormat)
                    Posicion = Posicion + 16
                    Dim Consecutivo As RectangleF = New RectangleF(105, Posicion, 650, 15) : ev.Graphics.DrawString("Consecutivo Nº " & Me.ConsecutivoMh & CorreoFactura, New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Consecutivo, New StringFormat)
                    ev.HasMorePages = False 'NO IMPRIME MAS PAGINAS
                Else
                    ev.HasMorePages = True  'MANDA A IMPRIMIR OTRA PAGINA
                End If
                ''------------------------------------------------------------------------------

                ''------------------------------------------------------------------------------
                ''-------------------------------- TOTALES - ORA -------------------------------
                If (DataSet_Facturaciones.Ventas_Detalle.Count - Cant) <= 8 Then
                    Dim Gravado As RectangleF = New RectangleF(630, 404, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).SubTotalGravada, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Gravado, Derecha)
                    Dim Exento As RectangleF = New RectangleF(630, 421, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).SubTotalExento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Exento, Derecha)
                    Dim DescuentoM As RectangleF = New RectangleF(630, 438, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).Descuento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoM, Derecha)
                    Dim Impuesto As RectangleF = New RectangleF(630, 454, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).Imp_Venta, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Impuesto, Derecha)
                    Dim Total As RectangleF = New RectangleF(630, 470, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).Total, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Total, Derecha)
                Else
                    Dim Gravado As RectangleF = New RectangleF(630, 404, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Gravado, Derecha)
                    Dim Exento As RectangleF = New RectangleF(630, 421, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Exento, Derecha)
                    Dim DescuentoM As RectangleF = New RectangleF(630, 438, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoM, Derecha)
                    Dim Impuesto As RectangleF = New RectangleF(630, 454, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Impuesto, Derecha)
                    Dim Total As RectangleF = New RectangleF(630, 470, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Total, Derecha)

                End If

            Else '///GUANAVET

                '-------------------------------------------------------------------------------

                '-------------------------------------------------------------------------------
                '------------------------------ ENCABEZADO - ORA -------------------------------
                'Dim Pagina As RectangleF = New RectangleF(600, 16, 100, 15) : ev.Graphics.DrawString("Pagina " & PaginaActual & " de " & Paginas, New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Pagina, New StringFormat)
                Dim XX As RectangleF = New RectangleF(630, 475, 150, 20) : ev.Graphics.DrawString("XXXXXXX", New System.Drawing.Font("Arial", 16, FontStyle.Bold), Brushes.Black, XX, New StringFormat)

                If Me.reimprimir = True Then
                    Dim RI As RectangleF = New RectangleF(250, 3, 220, 20) : ev.Graphics.DrawString("R", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, RI, New StringFormat)
                End If

                Dim tipo As String = Devuelve_TipoFactura()

                If tipo.IndexOf("CR") >= 0 Then
                    Dim TipoCre As RectangleF = New RectangleF(734, 74, 50, 20) : ev.Graphics.DrawString("X", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, TipoCre, New StringFormat)
                Else
                    Dim TipoCon As RectangleF = New RectangleF(620, 74, 50, 20) : ev.Graphics.DrawString("X", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, TipoCon, New StringFormat)
                End If

                Dim Dia As RectangleF = New RectangleF(560, 32, 75, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Day, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Dia, Centrar)
                Dim Mes As RectangleF = New RectangleF(630, 32, 75, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Month, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Mes, Centrar)
                Dim Anno As RectangleF = New RectangleF(680, 32, 100, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Year, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Anno, Centrar)
                Dim Hora As RectangleF = New RectangleF(630, 50, 100, 15) : ev.Graphics.DrawString(Format(DataSet_Facturaciones.Ventas(0).Fecha, "hh:mm:ss tt"), New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Hora, Centrar)
                Dim Factura As RectangleF = New RectangleF(388, 5, 220, 20) : ev.Graphics.DrawString("Interno " & DevuelveNum_Factura() & " - " & tipo, New System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, Factura, Derecha)
                Dim Cliente As RectangleF = New RectangleF(70, 106, 400, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Nombre_Cliente & " (" & txt_cedula.Text & ")", New System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, Cliente, New StringFormat)
                Dim Direccion As RectangleF = New RectangleF(100, 127, 400, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Direccion, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Direccion, New StringFormat)
                Vendedor = Func.SQLExeScalar("SELECT Nombre FROM Usuarios WHERE (Cedula = '" & DataSet_Facturaciones.Ventas(0).Cedula_Usuario & "')")
                Dim Atendido As RectangleF = New RectangleF(90, 142, 150, 15) : ev.Graphics.DrawString(Vendedor, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Atendido, New StringFormat)
                Dim Caja As RectangleF = New RectangleF(700, 140, 150, 15) : ev.Graphics.DrawString("Caja #" & DataSet_Facturaciones.Ventas(0).Num_Caja, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Caja, New StringFormat)
                'SI TIENE NUMERO DE ORDEN
                If DataSet_Facturaciones.Ventas(0).Orden > 0 Then
                    Dim Orden As RectangleF = New RectangleF(565, 120, 150, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Orden, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Orden, New StringFormat)
                End If
                'SI TIENE VENCIMIENTO
                If tipo.IndexOf("CR") >= 0 Then
                    Dim Vence As RectangleF = New RectangleF(565, 142, 150, 15) : ev.Graphics.DrawString(Format(DataSet_Facturaciones.Ventas(0).Vence, "dd/MM/yyyy"), New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, Vence, New StringFormat)
                End If
                'SI ESTA ANULADA
                If DataSet_Facturaciones.Ventas(0).Anulado Then
                    Dim Anulado As RectangleF = New RectangleF(312, 137, 200, 15) : ev.Graphics.DrawString("ANULADO", New System.Drawing.Font("ARIAL", 10, FontStyle.Bold), Brushes.Black, Anulado, New StringFormat)
                End If
                '-------------------------------------------------------------------------------

                '-------------------------------------------------------------------------------
                '------------------------------- DETALLES - ORA --------------------------------
                ''AGREGA LOS ARTICULOS
                Posicion = 187

                Dim Articulo As RectangleF = New RectangleF(160, Posicion, 294, 15) : Dim SubtotalDet As RectangleF = New RectangleF(640, Posicion, 100, 15)
                Dim DescuentoD As RectangleF = New RectangleF(565, Posicion, 75, 15) : Dim CantDet As RectangleF = New RectangleF(15, Posicion, 70, 15)
                Dim PrecioUnit As RectangleF = New RectangleF(510, Posicion, 75, 15) : Dim Codigo As RectangleF = New RectangleF(50, Posicion, 90, 15)
                Dim Grabado As RectangleF = New RectangleF(488, Posicion, 75, 15)

                Can = IIf((DataSet_Facturaciones.Ventas_Detalle.Count - Cant) > 10, 10, DataSet_Facturaciones.Ventas_Detalle.Count - Cant)
                For x As Integer = 0 To Can - 1
                    CantDet.Y = Posicion : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Cantidad, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, CantDet, Derecha)
                    Codigo.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).CodArticulo, New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Codigo, Derecha)
                    Articulo.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Descripcion, New System.Drawing.Font("Arial", 9, FontStyle.Regular), Brushes.Black, Articulo, New StringFormat)
                    'If DataSet_Facturaciones.Ventas_Detalle(x + Cant).SubtotalGravado > 0 Then
                    Grabado.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Impuesto, New System.Drawing.Font("Arial", 11, FontStyle.Bold), Brushes.Black, Grabado, New StringFormat)
                    'End If
                    PrecioUnit.Y = Posicion : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Precio_Unit, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, PrecioUnit, Derecha)
                    DescuentoD.Y = Posicion : ev.Graphics.DrawString("" & Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Descuento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoD, Derecha)
                    SubtotalDet.Y = Posicion : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).SubTotal, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, SubtotalDet, Derecha)
                    Posicion = Posicion + 20
                Next
                ''-------------------------------------------------------------------------------

                ''-------------------------------------------------------------------------------
                ''------------------------------ ULTIMA LINEA - ORA -----------------------------
                If (DataSet_Facturaciones.Ventas_Detalle.Count - Cant) <= 10 Then
                    Dim MExento As RectangleF = New RectangleF(40, Posicion, 200, 15) : ev.Graphics.DrawString("(*) EXCENTO", New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, MExento, New StringFormat)
                    Dim Ultima As RectangleF = New RectangleF(80, Posicion, 500, 15) : ev.Graphics.DrawString("= = = = > ULTIMA LINEA < = = = =", New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, Ultima, Centrar)
                    Posicion = Posicion + 16
                    Dim Clave As RectangleF = New RectangleF(105, Posicion, 500, 15) : ev.Graphics.DrawString("Clave Nº " & Me.ClaveMH, New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Clave, New StringFormat)
                    Posicion = Posicion + 16
                    Dim Consecutivo As RectangleF = New RectangleF(105, Posicion, 650, 15) : ev.Graphics.DrawString("Consecutivo Nº " & Me.ConsecutivoMh & CorreoFactura, New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Consecutivo, New StringFormat)
                    If DataSet_Facturaciones.Ventas(0).Observaciones <> "" Then
                        Posicion = Posicion + 17
                        Dim Observaciones As RectangleF = New RectangleF(125, Posicion, 600, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Observaciones, New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, Observaciones, New StringFormat)
                    End If                    
                    ev.HasMorePages = False 'NO IMPRIME MAS PAGINAS
                Else
                    ev.HasMorePages = True  'MANDA A IMPRIMIR OTRA PAGINA
                End If
                ''------------------------------------------------------------------------------

                ''------------------------------------------------------------------------------
                ''-------------------------------- TOTALES - ORA -------------------------------
                If (DataSet_Facturaciones.Ventas_Detalle.Count - Cant) <= 10 Then
                    Dim Gravado As RectangleF = New RectangleF(639, 388, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).SubTotalGravada, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Gravado, Derecha)
                    Dim Exento As RectangleF = New RectangleF(639, 404, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).SubTotalExento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Exento, Derecha)
                    Dim DescuentoM As RectangleF = New RectangleF(639, 421, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).Descuento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoM, Derecha)
                    Dim Impuesto As RectangleF = New RectangleF(639, 438, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).Imp_Venta, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Impuesto, Derecha)
                    Dim Total As RectangleF = New RectangleF(639, 454, 100, 17) : ev.Graphics.DrawString(simbolo & Format(Math.Round(DataSet_Facturaciones.Ventas(0).Total, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Total, Derecha)
                Else
                    Dim Gravado As RectangleF = New RectangleF(639, 388, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Gravado, Derecha)
                    Dim Exento As RectangleF = New RectangleF(639, 404, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Exento, Derecha)
                    Dim DescuentoM As RectangleF = New RectangleF(639, 421, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoM, Derecha)
                    Dim Impuesto As RectangleF = New RectangleF(639, 438, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Impuesto, Derecha)
                    Dim Total As RectangleF = New RectangleF(639, 454, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Total, Derecha)

                End If
            End If

            ''------------------------------------------------------------------------------

            '-------------------------------------------------------------------------------
            'DEFINE LA PAGINA ACTUAL
            PaginaActual += 1
            '-------------------------------------------------------------------------------

            '-------------------------------------------------------------------------------
            'DEFINE POR CUAL ARTICULO VA AL IMPRIMIR
            Cant += Can
            '-------------------------------------------------------------------------------

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            inicializar()
        End If
    End Sub

    Private Sub inicializar()
        Try
            If Me.ComboBox1.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar la Moneda en la que se va a cotizar", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.GroupBox6.Enabled = True
            Me.GroupBox1.Enabled = True
            'Me.GroupBox2.Enabled = True
            Me.dtFecha.Enabled = True
            Me.DtVence.Enabled = True
            Ck_Exonerar.Enabled = PMU.Others

            'Ck_Taller.Enabled = True
            'Ck_Mascotas.Enabled = True

            Me.ComboBox1.Enabled = False
            Me.SimpleButton3.Enabled = True
            'Me.cbo_tipo_cliente.Focus()
            Me.IngresoIdentificacion = False
            Me.txt_cedula.Focus()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub enter_cod_cliente()

        impuesto_cliente = 100

        If Me.txtcodigo.Text <> "" And Me.txtcodigo.Text <> "0" Then
            CargarInformacionCliente(txtcodigo.Text)
            If Me.GroupBox3.Enabled = False Then Me.iniciar_factura()
            Me.txtCod_Articulo.Focus()
        Else

            Me.txtTelefono.Text = ""
            Me.Txtdireccion.Text = ""
            Me.txtCorreoComprobantes.Text = ""
            Me.txtcodigo.Text = "0"
            Me.opCredito.Checked = False
            Me.opContado.Checked = True
            Me.opCredito.Enabled = False
            Me.impuesto_cliente = 100
            Me.txtCod_Articulo.Focus()
            Exit Sub
        End If
        Me.txtCod_Articulo.Focus()
    End Sub
    Private Sub CargarInformacionCliente(ByVal codigo As Int64)
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim rsm As SqlDataReader
        Dim cod_mod As Integer
        Dim cambio As Double
        Try

            sqlConexion = CConexion.Conectar
            If codigo <> Nothing Then
                If Me.ckFrecuente.Checked = False Then
                    rss = Me.DataSet_Facturaciones.Clientes.Select("identificacion ='" & codigo & "'")
                Else
                    rss = Me.DataSet_Facturaciones.Clientes.Select("identificacion ='" & codigo & "'")
                    If rss.Count > 0 Then
                        rs = rss(0)
                        txtcodigo.Text = rs("identificacion")
                        txt_cedula.Text = rs("cedula")
                        ''''''''''''''''
                        txtNombre.Text = rs("nombre")
                        txtNombre.Enabled = False
                        IngresoIdentificacion = True
                        Me.Txtdireccion.Text = rs("direccion")
                        Me.txtTelefono.Text = rs("Telefono_01")
                        Me.txtCorreoComprobantes.Text = Me.CorreoComprobantes(rs("identificacion"))
                    End If
                    Exit Sub
                End If

                If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

                    Try
                        rs = rss(0)
                        'txtcodigo.Text = rs("cedula")

                        ''''''''''''''''
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = codigo
                        txtNombre.Text = rs("nombre")
                        txt_cedula.Text = rs("cedula")
                        txtNombre.Enabled = False
                        IngresoIdentificacion = True
                        Me.Txtdireccion.Text = rs("direccion")
                        Me.txtTelefono.Text = rs("Telefono_01")
                        cod_mod = rs("CodMonedaCredito")
                        If rs("abierto") = "NO" Then

                            Me.opCredito.Enabled = False
                            Me.opCredito.Checked = False
                            Me.opContado.Checked = True

                        Else

                            Me.opCredito.Enabled = True
                            Me.opContado.Enabled = True
                            If Not Me.Importando Then Me.opContado.Checked = True
                            Me.txtDiasPlazo.Enabled = True

                        End If

                        If rs("sinrestriccion") = "SI" Then
                            sinrestriccion = True
                        Else
                            sinrestriccion = False
                        End If


                        rsm = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & cod_mod)
                        While rsm.Read
                            Try
                                cambio = rsm("ValorCompra")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                                CConexion.DesConectar(CConexion.sQlconexion)
                            End Try
                        End While
                        rsm.Close()
                        CConexion.DesConectar(CConexion.sQlconexion)


                        max_credito = rs("max_credito") * (cambio / (CDbl(Me.txtTipoCambio.Text)))
                        plazo_credito = rs("plazo_credito")
                        txtDiasPlazo.Text = plazo_credito
                        descuento = rs("descuento")
                        tipoprecio = rs("tipoprecio")
                        impuesto_cliente = 100
                        'si actualmente esta cotizacion tiene artìculos                        
                        If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                            If Me.coti = True Then
                                Exit Sub
                            Else
                                Me.recalcular_cotizacion_cambio_cliente()
                                MsgBox("Factura actualizada de acuerdo al cliente", MsgBoxStyle.Information)
                            End If
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else ' si no se encontro el cliente
                    'MsgBox("No existe un cliente con ese código", MsgBoxStyle.Exclamation)
                    If buscar_cedula_cliente(txt_cedula.Text) Then
                        'Dim frm_cliente As New frm_cliente_rapido
                        'If MsgBox("El cliente no se encuentra registrado, ¿Desea Registrarlo?", MsgBoxStyle.YesNo, "Cliente Nuevo") = vbYes Then
                        '    frm_cliente.cedula = txtcodigo.Text
                        '    frm_cliente.nombre = txtNombre.Text
                        '    frm_cliente.tipo = cbo_tipo_cliente.SelectedIndex
                        '    frm_cliente.ShowDialog()
                        '    Cargar_Cliente(txtcodigo.Text)
                        '    CargarInformacionCliente(txtcodigo.Text)
                        'End If
                    Else
                        'Me.txtcodigo.Text = "0"
                        'Me.txtTelefono.Text = ""
                        'Me.Txtdireccion.Text = ""
                        'Me.txtNombre.Text = "CLIENTE CONTADO"
                        Me.txtcodigo.Focus()
                        abierto = False
                        sinrestriccion = False
                        impuesto_cliente = 100
                        max_credito = 0
                        plazo_credito = 0
                        descuento = 0
                        tipoprecio = 1
                        'txtNombre.Enabled = False
                        Me.opCredito.Enabled = False
                        Me.opCredito.Checked = False
                        Me.opContado.Checked = True
                    End If

                End If


            Else 'se dio el boton de cancelar o no se selecciono ninguno

                Me.txtcodigo.Text = ""
                Me.txtTelefono.Text = ""
                Me.Txtdireccion.Text = ""
                Me.txtCorreoComprobantes.Text = ""
                ' Me.txtNombre.Text = "CLIENTE CONTADO"

                abierto = False
                sinrestriccion = False
                impuesto_cliente = 100
                max_credito = 0
                plazo_credito = 0
                descuento = 0
                tipoprecio = 1
                txtNombre.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'Private Sub Cargar_Encargados_Compra(ByVal codigo As String)
    '    Dim rss() As System.Data.DataRow
    '    Dim rs As System.Data.DataRow
    '    Dim i As Integer
    '    Me.Combo_Encargado.Items.Clear() ' limpia el combo
    '    Try
    '        If codigo <> Nothing Then

    '            rss = Me.DataSet_Facturaciones.encargadocompras.Select("Cliente ='" & codigo & "'")

    '            If rss.Length <> 0 Then ' si existe un cliente con ese còdigo


    '                For i = 0 To rss.Length - 1 'mientras encargados de compra
    '                    rs = rss(i)
    '                    Me.Combo_Encargado.Items.Add(rs("Nombre"))

    '                Next i

    '                If Me.Combo_Encargado.SelectedIndex = -1 Then
    '                    Me.Combo_Encargado.SelectedIndex = 0
    '                End If


    '                Me.Label41.Visible = True
    '                Me.Combo_Encargado.Visible = True

    '            Else
    '                Me.Label41.Visible = False
    '                Me.Combo_Encargado.Visible = False

    '            End If


    '        Else 'si ese cliente no tiene clientes encargados
    '            Me.Label41.Visible = False
    '            Me.Combo_Encargado.Visible = False

    '        End If
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")

    '    End Try

    'End Sub



    Private Sub recalcular_cotizacion_cambio_cliente()
        Dim i As Integer
        Try

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()

            If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
                    If Me.txtCod_Articulo.Text <> "" Then
                        Me.CargarInformacionArticulo(Me.txtCod_Articulo.Text, True)
                        Me.Calculos_Articulo() ' se calcula  de nuevo los datos del articulo cotizado

                        If mensaje <> "" Then
                            MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                            mensaje = ""
                        End If
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    End If
                Next

                Calcular_Totales_Cotizacion()
            End If

            'BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            'BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            'BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub recalcular_cotizacion(ByVal nuev_des)
        Dim i As Integer
        Try


            If CDec(nuev_des) >= 8 And opCredito.Checked = False Then
                Dim frm As New frmMaxDescuentoVenta
                frm.ShowDialog()
            End If

            Me.MuestraAdvertenciaDescuento = False

            For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i

                If nuev_des < Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Max_Descuento") Then
                    Me.txtDescuento.Text = nuev_des
                Else
                    Me.txtDescuento.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Max_Descuento")
                End If

                Me.Calculos_Articulo() ' se calcula de nuevo los datos del articulo cotizado
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            Next
            Me.MuestraAdvertenciaDescuento = True
            Calcular_Totales_Cotizacion()
            MsgBox("Descuentos sobre artìculos han sido Actualizados", MsgBoxStyle.Information)

        Catch ex As System.Exception
            Me.MuestraAdvertenciaDescuento = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub txtorden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtorden.KeyDown

        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            iniciar_factura()
        End If

        If e.KeyCode = Keys.F2 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If


        If e.KeyCode = Keys.F4 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If

    End Sub

    Private Sub iniciar_factura()
        Try
            Dim nom As String = Me.txtNombre.Text
            Dim orden As String = txtorden.Text

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Moneda") = Me.BindingContext(Me.DataSet_Facturaciones, "Moneda").Current("CodMoneda")
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario") = Me.Cedula_usuario
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("pagoImpuesto") = 100
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo_Cambio") = CDbl(txtTipoCambio.Text)
            Me.txtNombre.Text = nom
            Me.txtorden.Text = orden

            If Me.txtcodigo.Text = "" Then
                Me.txtcodigo.Text = "0"
            End If

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count = 1 Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                dias_credito()
            End If

            Me.GridControl1.Enabled = True
            Me.SimpleButton1.Enabled = True

            Me.ToolBar1.Buttons(2).Enabled = True 'se activa el botond e guardar

            Me.GroupBox3.Enabled = True
            If Me.txtDescuento.Properties.ReadOnly = True Then Me.txtDescuento.Properties.Enabled = False
            If Me.txtPrecioUnit.Properties.ReadOnly = True Then Me.txtPrecioUnit.Properties.Enabled = False

            Me.GroupBox4.Enabled = True

            Me.txtCod_Articulo.Focus()


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.SoloSinBarras = True
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Codigo = BuscarArt.Codigo
            Exit Function
        End If
        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function

    Private Function GetCodArticulo(_Barras As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select top 1 Cod_Articulo from Inventario i inner join ControlLotes l on i.Codigo = l.Codigo where i.inhabilitado = 0 and l.Barras = '" & _Barras & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Cod_Articulo")
        Else
            Return _Barras
        End If
    End Function

    Private Sub txtCodArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod_Articulo.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Try
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()

                        Me.DetenerTiempo()
                        Dim CodigoBuscador As String = BuscarF1()

                        If Not IsNothing(CodigoBuscador) And CodigoBuscador <> "0" And CodigoBuscador <> "0.00" Then
                            CargarInformacionArticulo(CodigoBuscador)
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                    End Try
                    Me.IniciaTiempo()
                Case Keys.Enter
                    Try
                        If Me.txtCod_Articulo.Text = "" Or Me.txtCod_Articulo.Text = "0" Then Exit Sub
                        Dim cod_art As String


                        Dim cant As String = "1"
                        If Me.txtCod_Articulo.Text.Contains("_") = True Then
                            'es codigo de barras
                            Dim barras() As String = Me.txtCod_Articulo.Text.Split("_")
                            cant = barras(0)
                            Me.txtCod_Articulo.Text = barras(1)
                        Else
                            Me.txtCod_Articulo.Text = Me.GetCodArticulo(txtCod_Articulo.Text)
                        End If

                        cod_art = Me.txtCod_Articulo.Text
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                        CargarInformacionArticulo(cod_art)
                        Me.txtCantidad.Text = cant

                    Catch ex As SystemException
                        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                    End Try

                Case Keys.F2
                    'codigo_cliente = txtcodigo.Text
                    'nombre_cliente = txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                    Me.TclCaja = "F2"
                    Me.Registrar(False, 1)
                Case Keys.F3
                    'codigo_cliente = txtcodigo.Text
                    'nombre_cliente = txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                    Me.TclCaja = "F3"
                    Me.Registrar(True, 1)
                Case Keys.F4
                    'codigo_cliente = txtcodigo.Text
                    'nombre_cliente = txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                    Me.TclCaja = "F4"
                    Me.Registrar(False, 2)
                Case Keys.F5
                    'codigo_cliente = txtcodigo.Text
                    'nombre_cliente = txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
                    'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                    Me.TclCaja = "F5"
                    Me.Registrar(True, 2)
                Case Keys.F6
                    'electronica
                    Me.TclCaja = "F6"
                    Me.Registrar(False, 3)
                Case Keys.F7
                    'tiquete
                    Me.TclCaja = "F7"
                    Me.Registrar(True, 3)

                Case Keys.Escape
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                    Me.txtCod_Articulo.Focus()
                    Me.GridControl1.Enabled = True
                    Exit Sub
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim ExistenciaConsignacion As Decimal
    Dim BodegaConsignacion As Boolean
    Dim Bloqueado As Boolean

    Private Sub UsaGalon(_Codigo As String)
        If _Codigo <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select UsaGalon from Inventario Where Codigo = " & _Codigo, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("UsaGalon") = 1 Or dt.Rows(0).Item("UsaGalon") = True Then
                    Dim frm As New frmUsaGalon
                    If frm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        Dim CodArticulo As String = "2011.94"
                        Me.CargarInformacionArticulo(CodArticulo)
                        Me.meter_al_detalle()
                    End If
                End If
            End If            
        End If       
    End Sub

    Private Sub CargarInformacionArticulo(ByVal codigo As String, Optional ByVal recargar As Boolean = False)
        Try
            Dim rs As SqlDataReader
            Dim Encontrado As Boolean
            Dim ValidaExistencia As Boolean = False
            Me.Lote = False
            Me.LOpcion.Text = "Opcion"
            Me.CbNumero.Enabled = False
            Me.LFVencimiento.Text = ""

            If codigo <> Nothing Or codigo <> "" Then
                sqlConexion = CConexion.Conectar

                Me.existencia_enbodega(codigo) '// comprobamos la existencia actual en bodega

                'rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "'")
                rs = CConexion.GetRecorset(sqlConexion, "SELECT ValidaExistencia, Max_Descuento, Precio_Promo, Promo_Activa, PromoCRE, PromoCON, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote, Consignacion , Id_Bodega, ExistenciaBodega, bloqueado,pantalla,rifa from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE Inhabilitado = 0 and (Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "' or barras2 = '" & codigo & "' or barras3 = '" & codigo & "')")
                Encontrado = False

                While rs.Read
                    Try
                        ValidaExistencia = rs("ValidaExistencia")
                        If ValidaExistencia = True Then
                            'valida que tenga existencia
                            If CDec(rs("Existencia")) <= 0 Then
                                MsgBox("El articulo no tiene Existencias", "No se puede realizar la operacion")
                                Exit Sub
                            End If
                        End If

                        Encontrado = True

                        txtCodArticulo.Text = rs("Codigo")

                        Dim DescuentoAutomatico As Decimal = GetDescuentoAutomatico(txtCodArticulo.Text)
                        If DescuentoAutomatico > 0 Then
                            Me.txtDescuento.Text = DescuentoAutomatico
                        End If

                        If rs("Id_Bodega") > 0 Or rs("Consignacion") = True Then
                            Me.BodegaConsignacion = True
                            Me.ExistenciaConsignacion = rs("ExistenciaBodega")
                        Else
                            Me.BodegaConsignacion = False
                            Me.ExistenciaConsignacion = 0
                        End If
                        Me.Bloqueado = rs("bloqueado")

                        txtCod_Articulo.Text = rs("Cod_Articulo")
                        Me.AgregandoNuevoItem = True

                        If Excento(CDbl(txtCodArticulo.Text)) = True Then
                            txtNombreArt.Text = "*  " & rs("Descripcion")
                        Else
                            txtNombreArt.Text = rs("Descripcion")
                        End If

                        If Me.ClienteRegistradoMAG = True And rs("MAG") = True Then
                            'si el producto esta en la lista del mag
                            'y si el cliente esta registrado en el mag
                            txtImpVenta.Text = Format(1, "#,#0.00")
                        Else
                            txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                        End If

                        txtSubFamilia.Text = rs("SubFamilia")
                        PrecioBase = rs("PrecioBase")
                        Me.txtCostoBase.Text = PrecioBase
                        Me.Max_Descuento_Articulo = rs("Max_Descuento")
                        Me.TxtMaxdescuento.Text = Me.Max_Descuento_Articulo
                        Me.Max_Descuento_Articulo = rs("Max_Descuento")
                        PrecioCosto = rs("Costo")
                        Me.TxtprecioCosto.Text = rs("Costo")
                        Flete = rs("Fletes")
                        Me.txtFlete.Text = Flete
                        OtrosMontos = rs("OtrosCargos")
                        Me.txtOtros.Text = OtrosMontos

                        If rs("Servicio") Then
                            Me.Existencia = 100
                        Else
                            Me.Existencia = rs("Existencia")
                        End If

                        If recargar = False Then
                            If Existencia <= rs("Minima") Then
                                MsgBox("Existencia del artículo esta por debajo del minimo! Favor hacer pedido!", MsgBoxStyle.Critical, "Revisar Existencia del Artículo!")
                            End If
                        End If

                        txtExistencia.Text = Existencia
                        txtExisBod.Text = rs("ExistenciaBodega")

                        Me.ckpantalla.Checked = rs("pantalla")

                        If rs("PreguntaPrecio") Then
                            If recargar = False Then
                                Dim Precio As New Monto_Transporte_Ventas
                                Precio.Text = "Establecer Precio"
                                Precio.GroupBox1.Text = "Digite el precio del articulo"
                                If tipoprecio = 1 Then
                                    Precio.TextNumero.Text = rs("Precio_A") * (1 + (CDbl(txtImpVenta.Text) / 100))
                                ElseIf tipoprecio = 2 Then
                                    Precio.TextNumero.Text = rs("Precio_B") * (1 + (CDbl(txtImpVenta.Text) / 100))
                                ElseIf tipoprecio = 3 Then
                                    Precio.TextNumero.Text = rs("Precio_C") * (1 + (CDbl(txtImpVenta.Text) / 100))
                                ElseIf tipoprecio = 4 Then
                                    Precio.TextNumero.Text = rs("Precio_D") * (1 + (CDbl(txtImpVenta.Text) / 100))
                                End If
                                Precio.ShowDialog()

                                If Precio.DialogResult = DialogResult.OK Then
                                    PrecioA = Precio.Monto '(Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                    PrecioB = Precio.Monto '(Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                    PrecioC = Precio.Monto '(Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                    PrecioD = Precio.Monto '(Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                Else
                                    Precio.Dispose()
                                    rs.Close()
                                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                                    Me.txtCod_Articulo.Focus()
                                    CConexion.DesConectar(CConexion.sQlconexion)
                                End If
                                Precio.Dispose()
                            Else
                                PrecioA = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                                PrecioB = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                                PrecioC = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                                PrecioD = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            End If
                        Else
                            PrecioA = rs("Precio_A")
                            PrecioB = rs("Precio_B")
                            PrecioC = rs("Precio_C")
                            PrecioD = rs("Precio_D")

                            If Me.ckPD.Checked = True Then
                                Dim IdAgente As String = Me.txtagente.Text
                                Dim dtPD As New DataTable
                                Dim Tipo As String
                                Dim Pocentaje As Decimal
                                Dim casa As String = Me.GetCasa(rs("Codigo"))
                                cFunciones.Llenar_Tabla_Generico("select * from PrecioDiferenciado where IdAgente = " & IdAgente & " and CodProveedor = " & casa, dtPD, CadenaConexionSeePOS)
                                If dtPD.Rows.Count > 0 Then
                                    Tipo = dtPD.Rows(0).Item("Tipo")
                                    Pocentaje = dtPD.Rows(0).Item("Porcentaje")

                                    If Tipo.ToLower = "aumento" Then
                                        PrecioA = PrecioA * (1 + (Pocentaje / 100))
                                    End If

                                    If Tipo.ToLower = "descuento" Then
                                        PrecioA -= PrecioA * (Pocentaje / 100)
                                    End If
                                End If
                                'hay que aplicar el nuevo precio

                            End If

                        End If

                        Me.precio_promo_valor = rs("Precio_Promo")
                        ' Me.ck_promo3x1.Checked = rs("promo3x1")

                        MonedaCosto = rs("MonedaVenta")
                        Me.Txtcodmoneda_Venta.Text = rs("MonedaVenta")
                        Me.MonedaBase = rs("MonedaCosto")
                        MonedaVenta = Me.BindingContext(Me.DataSet_Facturaciones, "Moneda").Current("CodMoneda")

                        Lote = False
                        LOpcion.Text = "Opcion"

                        If rs("Lote") = True Then
                            'ActivaLote()
                        Else
                            ActivaNinguno()
                        End If


                        If rs("Promo_Activa") = True Then ' si el articulo esta en promocion
                            Me.promo_activa_valor = True
                            Me.txtDescuento.Enabled = False
                            Me.PromoCON = rs("PromoCON")
                            Me.PromoCRE = rs("PromoCRE")
                            MsgBox("Este artículo está en promoción", MsgBoxStyle.Information)
                        Else
                            Me.promo_activa_valor = False ' se habilita el text
                            Me.PromoCON = False
                            Me.PromoCRE = False
                            If Me.txtDescuento.Properties.ReadOnly = False Then Me.txtDescuento.Enabled = True
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.sQlconexion)
                    End Try
                End While

                rs.Close()
                If Not Encontrado Then
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                    Me.txtCod_Articulo.Focus()
                    CConexion.DesConectar(CConexion.sQlconexion)
                    MsgBox("No existe o está inhabilitado un artículo con este código")
                    Exit Sub
                End If

                rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaCosto)
                While rs.Read
                    Try
                        ValorCosto = rs("ValorCompra")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.sQlconexion)
                    End Try
                End While
                rs.Close()

                'Consulta el Tipo de Cambio de la Moneda usada para la Venta
                rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & CInt(Me.Txtcodmoneda_Venta.Text))
                While rs.Read
                    Try
                        Txt_TipoCambio_Valor_Compra.Text = rs("ValorCompra")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.sQlconexion)
                    End Try
                End While
                rs.Close()
                ValorVenta = CDbl(Me.txtTipoCambio.Text)

                rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaBase)
                While rs.Read
                    Try
                        ValorBase = rs("ValorCompra")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.sQlconexion)
                    End Try
                End While
                rs.Close()

                Calculo_precio_unitario()

                If Me.txtNombreArt.Text <> "" Then 'si se recuperaron los datos de un articulo
                    If Lote = True Then
                        CbNumero.Focus()
                    ElseIf txtPrecioUnit.Enabled = True Then                         'si el usuario puede disminuir o aumentar el costo del articulo
                        Me.txtPrecioUnit.Focus()
                    Else
                        If txtDescuento.Enabled = True Then
                            txtDescuento.Focus()
                        Else
                            txtCantidad.Focus()
                        End If
                    End If
                End If

            Else ' si no se recupero ningun articulo, se termina la edicion
                Try

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                    Me.txtCod_Articulo.Focus()

                Catch ex As SystemException
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                Finally
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End If
            Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
            AgregandoNuevoItem = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function buscar_rifa()
        Dim dts As New DataTable
        Dim dts_rifa As New DataTable
        Dim fi As Date
        Dim ff As Date
        Dim Monto_Minimo As Decimal
        Dim Monto_venta As Decimal
        Dim producto As Integer
        Dim Proveedor As Integer
        Dim productos_patrocinadores As Decimal = 0

        'Me.txtMontoCupon.BackColor = SystemColors.Control

        Try
            With BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")
                Me.imprime_cupon = False
                For i As Integer = 0 To .Count - 1

                    .Position = i
                    producto = .Current("codigo")
                    Monto_venta = .Current("SubTotal") - .Current("Monto_Descuento")

                    cFunciones.Llenar_Tabla_Generico("Select Case paq.DescargaOtro when 0 then paq.Proveedor else sac.Proveedor end as Proveedor From Inventario paq Left Join Inventario sac on paq.CodigoDescarga = sac.Codigo where paq.Codigo = " & producto, dts_rifa)
                    Proveedor = dts_rifa.Rows(0).Item("Proveedor")

                    If Proveedor > 0 Then
                        cFunciones.Llenar_Tabla_Generico("Select r.* From rifa r Inner Join Rifa_Detalle rd on r.id = rd.idrifa where finalizada = 0 and anulada = 0 and rd.IdProveedor = " & Proveedor, dts)
                        If dts.Rows.Count > 0 Then

                            fi = dts.Rows(0).Item("fecha_inicio")
                            ff = dts.Rows(0).Item("fecha_fin")
                            Monto_Minimo = dts.Rows(0).Item("cant_min")

                            If Date.Today >= fi And Date.Today <= ff Then
                                productos_patrocinadores += Monto_venta
                                If productos_patrocinadores > Monto_Minimo Then
                                    imprime_cupon = True
                                End If
                            End If

                        End If
                    End If
                Next

                If Me.imprime_cupon = True Then
                    Me.cantidad_cupon = productos_patrocinadores / Monto_Minimo
                    'Me.txtMontoCupon.BackColor = Color.Green
                Else
                    Me.cantidad_cupon = 0
                    'Me.txtMontoCupon.BackColor = Color.Red
                End If

                If Me.opCredito.Checked = True Then
                    Me.cantidad_cupon = 0
                    Me.imprime_cupon = False
                    productos_patrocinadores = 0
                End If

                Me.txtMontoCupon.Text = Format(CDec(productos_patrocinadores), "N2")

                productos_patrocinadores = 0
                Return Me.imprime_cupon
            End With
        Catch ex As Exception

        End Try

    End Function
    Public Function Excento(ByVal cod As String) As Boolean
        Dim cnnv As SqlConnection = Nothing
        Dim dt As SqlDataReader
        Dim dime As Boolean
        Dim ex As Integer = 0

        Dim sConn As String = CadenaConexionSeePOS()
        cnnv = New SqlConnection(sConn)
        cnnv.Open()
        ' Creamos el comando para la consulta
        Dim cmdv As SqlCommand = New SqlCommand("SELECT IVenta FROM Inventario WHERE (Codigo='" & cod & "') ", cnnv)
        dt = cmdv.ExecuteReader()
        While (dt.Read)
            If Ck_Exonerar.Checked Then
                dime = True
            Else
                If (dt.Item("IVenta") = 0) Then
                    dime = True
                End If
            End If

        End While
        cnnv.Close()
        Return dime
    End Function

    Private Function AplicaCambio() As Boolean
        Return False
    End Function

    Private Sub Calculo_precio_unitario()
        Try

            If Me.AplicaCambio = True Then

                If Me.opContado.Checked = True And Me.PrecioContado > 0 Then
                    txtPrecioUnit.Text = Math.Round((Me.PrecioContado * (ValorCosto / ValorVenta)), 2)
                    txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                    PrecioBase = txtCostoBase.Text
                    txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                    txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                    Me.precio_unitario = txtPrecioUnit.Text
                End If

                If Me.opCredito.Checked = True And Me.PrecioCredito > 0 Then
                    txtPrecioUnit.Text = Math.Round((Me.PrecioCredito * (ValorCosto / ValorVenta)), 2)
                    txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                    PrecioBase = txtCostoBase.Text
                    txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                    txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                    Me.precio_unitario = txtPrecioUnit.Text
                End If

            End If

            If Me.opContado.Checked = True Then
                If Me.promo_activa_valor And Me.PromoCON = True Then ' si el articulo esta actualmente en promoción 
                    txtPrecioUnit.Text = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)
                    'Calculo de Costo
                    txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                    PrecioBase = txtCostoBase.Text
                    txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                    txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                    Me.precio_unitario = txtPrecioUnit.Text
                    'Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
                    Exit Sub
                End If
            End If

            If Me.opCredito.Checked = True Then
                If Me.promo_activa_valor And Me.PromoCRE = True Then ' si el articulo esta actualmente en promoción 
                    txtPrecioUnit.Text = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)
                    'Calculo de Costo
                    txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                    PrecioBase = txtCostoBase.Text
                    txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                    txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                    Me.precio_unitario = txtPrecioUnit.Text
                    'Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
                    Exit Sub
                End If
            End If

            If Me.tipoprecio = 0 Then
                Me.tipoprecio = 1
            End If

            'Calculos para el Precio Unitario
            Select Case tipoprecio

                Case 1 : txtPrecioUnit.Text = Math.Round((PrecioA * (ValorCosto / ValorVenta)), 2)
                Case 2 : txtPrecioUnit.Text = Math.Round((PrecioB * (ValorCosto / ValorVenta)), 2)
                Case 3 : txtPrecioUnit.Text = Math.Round((PrecioC * (ValorCosto / ValorVenta)), 2)
                Case 4 : txtPrecioUnit.Text = Math.Round((PrecioD * (ValorCosto / ValorVenta)), 2)
            End Select
            'Calculo de Costo
            txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
            PrecioBase = txtCostoBase.Text
            txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
            txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
            Me.TxtprecioCosto.Text = (CDbl(Me.TxtprecioCosto.Text) * (ValorBase / ValorVenta))
            Me.precio_unitario = txtPrecioUnit.Text
            'Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try


    End Sub

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown

        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            If Me.txtCantidad.Text = "" Then Exit Sub
            If Lote = True Then
                If VerificaLote() = False Then
                    meter_al_detalle()
                End If
            Else
                meter_al_detalle()
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If

        If e.KeyCode = Keys.F6 Then
            Me.password_antiguo = Me.txtUsuario.Text
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Enabled = True
            Me.txtNombreUsuario.Text = ""
            Me.GroupBox3.Enabled = False
            txtorden.Enabled = True
            Me.txtUsuario.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Me.txtCod_Articulo.Focus()
            Me.GridControl1.Enabled = True
        End If
    End Sub

    Private Function exi() As Decimal
        If Me.Existencia > 0 Then
            Return Me.Existencia
        Else
            Return 0
        End If
    End Function

    Private Function YaAdentro(ByVal _codigo As String) As Decimal
        Dim Adentro As Decimal = 0
        Dim fila() As DataSet_Facturaciones.Ventas_DetalleRow
        fila = Me.DataSet_Facturaciones.Ventas_Detalle.Select("Codigo = " & _codigo & "")
        For i As Integer = 0 To fila.Length - 1
            Adentro += fila(i).Cantidad
        Next
        Return Adentro
    End Function

    Private Function YaAdentro() As Decimal
        Dim Adentro As Decimal = 0
        Dim fila() As DataSet_Facturaciones.Ventas_DetalleRow
        fila = Me.DataSet_Facturaciones.Ventas_Detalle.Select("Codigo = " & Me.txtCodArticulo.Text & "")
        For i As Integer = 0 To fila.Length - 1
            Adentro += fila(i).Cantidad
        Next
        Return Adentro
    End Function

    Private Function GetCostoReal(ByVal _Codigo As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select CostoReal from Inventario where codigo = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Private Function Consignacion(_Codigo As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select consignacion from inventario where codigo = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim consigna As Boolean = dt.Rows(0).Item("consignacion")
            Return consigna
        End If
        Return False
    End Function

    Private Sub meter_al_detalle()
        Dim frm_leyenda As New frm_leyenda

        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("IdSerie") = 0
        Dim dtSeries As New DataTable
        Dim CodigoInventario As String = Me.txtCodArticulo.Text
        cFunciones.Llenar_Tabla_Generico("select s.id, s.serie from Inventario i inner join Serie s on s.codigo = i.Codigo and s.vendido = 0 where i.serie = 1 and i.Codigo = " & CodigoInventario, dtSeries, CadenaConexionSeePOS)
        If dtSeries.Rows.Count > 0 Then
            'el producto tiene serie
            Me.DetenerTiempo()
            Dim frm As New frmSeleccionarSerie
            frm.cboSeriesDisponibles.DataSource = dtSeries
            frm.cboSeriesDisponibles.DisplayMember = "serie"
            frm.cboSeriesDisponibles.ValueMember = "id"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("IdSerie") = frm.cboSeriesDisponibles.SelectedValue
            Else
                Exit Sub
            End If
            Me.IniciaTiempo()
        End If

        '********************************************************************************************************
        'Valida los productos que no se puede vender en negativo
        Try
            Dim dtnegativo As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select SoloConExistencia, Existencia from Inventario where Codigo = " & CodigoInventario, dtnegativo, CadenaConexionSeePOS)
            If dtnegativo.Rows.Count > 0 Then
                If CBool(dtnegativo.Rows(0).Item("SoloConExistencia")) = True Then
                    Dim Otros As Decimal = 0
                    Dim Cantidad As Decimal = CDec(Me.txtCantidad.Text)
                    Dim Existencia As Decimal = CDec(dtnegativo.Rows(0).Item("Existencia"))

                    Otros = (From x As DataSet_Facturaciones.Ventas_DetalleRow In Me.DataSet_Facturaciones.Ventas_Detalle.Rows
                             Where x.Codigo = CodigoInventario
                             Select CDec(x.Cantidad)).Sum

                    If (Existencia - (Cantidad + Otros)) < 0 Then
                        MsgBox("Este Producto no se puede vender en negativo!!!", MsgBoxStyle.Exclamation, Text)
                        If TokenNegativo() = True Then
                            Me.DetenerTiempo()
                            Dim frm As New frmIngreseTokenValidacion
                            frm.IdUsuario = Me.Cedula_usuario
                            frm.Codigo = CodigoInventario
                            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                'si acepta es porque el token esta correcto
                            Else
                                Exit Sub
                            End If
                            Me.IniciaTiempo()
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try        
        '********************************************************************************************************

        '********************************************************************************************************
        'Valida los productos que no se puede vender en fracciones
        Try

            Dim VentaNegativo As Boolean = Me.PuedeVenderDecimal(CodigoInventario)
            Dim Cantidad As String = CDec(Me.txtCantidad.Text).ToString("N2")
            If Cantidad.LastIndexOf(".") > 0 Then
                Dim Fraccion As String = Cantidad.Split(".")(1)
                If VentaNegativo = False And CDec(Fraccion) > 0 Then
                    MsgBox("Este Producto no se puede vender Fraccionado!!!", MsgBoxStyle.Exclamation, Text)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
        '********************************************************************************************************

        '********************************************************************************************************
        'UsoInterno
        Dim CodCliente As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        Dim UsoInterno As Boolean = Me.UsoInterno(CodigoInventario)
        Dim UsoInternoCliente As Boolean = Me.ClienteUsoInterno(CodCliente)

        If UsoInterno = True And UsoInternoCliente = False Then
            MsgBox("Este Producto solo es para uso Interno de la Veterinaria!!!", MsgBoxStyle.Exclamation, "No se puede Realizar la Venta.")
            Exit Sub
        End If
        '********************************************************************************************************

        If Me.Ck_Exonerar.Checked = True Then
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("PorcentajeCompra") = 0 And CDec(Me.txtImpVenta.Text) > 0 Then
                Me.DetenerTiempo()
                Dim frm As New frmExonerarLineaFactura
                frm.Identificacion = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtImpVenta.Text = frm.txtIV.Text
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("IdTipoExoneracion") = frm.IdTipoExoneracion
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("NumeroDocumento") = frm.NumeroDocumento
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("FechaEmision") = frm.FechaEmision
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("PorcentajeCompra") = frm.PorcentajeCompra
                Else
                    Exit Sub
                End If
                Me.IniciaTiempo()
            End If
        End If

        Try
            Dim resp As Integer
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Sub
            End If

            If Me.Bloqueado = True Then
                MsgBox("El articulo esta Bloqueado, consulte al encargado del control del inventario", MsgBoxStyle.Critical, "Imposible realizar operacion!!!!!!")
                Exit Sub
            End If

            resp = MessageBox.Show("¿Desea agregar este artículo a la factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If Me.BodegaConsignacion = True Then
                If (CDec(Me.txtCantidad.Text) + YaAdentro()) > (exi() + Me.ExistenciaConsignacion) Then
                    If MsgBox("La Cantidad a vender es mayor a la cantidad en bodega de consignacion, Desea Continuar", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Text) = MsgBoxResult.Yes Then
                        If VerificandoAcceso_a_Modulos("ConsignacionNegativa", "ConsignacionNegativa", Cedula_usuario, "Administración") = False Then
                            Dim frm As New frmValidaConsignacionNegativa
                            frm.ShowDialog()
                            If frm.Resultado = False Then
                                Exit Sub
                            End If
                        End If
                    Else
                        Exit Sub
                    End If
                End If
            End If

            If resp <> 6 Then
                Me.GridControl1.Enabled = True
                Me.txtCantidad.Focus()
                Exit Sub
            End If

            If CDbl(Me.txtCantidad.Text) > Me.Existencia And BodegaConsignacion = False Then 'si la cantidad digitada es mayor que la existencia
                frm_leyenda.cantidad = Me.txtCantidad.Text
                frm_leyenda.existencia = Me.Existencia.ToString
                frm_leyenda.ShowDialog()
                'MsgBox("No Existen " + txtCantidad.Text + " artículos, la Existencia en el inventario es de " + Me.Existencia.ToString + " ,debe hacer un pedido", MsgBoxStyle.Exclamation)

                If Not Me.vende_existecias_negativas Then
                    MsgBox("Usted no puede vender con existencias negativas", MsgBoxStyle.Critical)

                    If Me.Existencia <= 0 Then  ' si en el inventario ese articulo tiene existencias negativas
                        Me.txtCantidad.Text = 0 ' se vende solo lo que hay en el inventario
                    Else
                        Me.txtCantidad.Text = Me.Existencia '' se vende solo lo que hay en el inventario
                    End If

                    If Existencia = 0 Then ' si no hay articulos de ese tipo en el inventario
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        txtCod_Articulo.Focus()
                        Exit Sub
                    End If
                End If

            ElseIf CDbl(Me.txtCantidad.Text) = Me.Existencia Then 'si con esta venta el inventario la existencia sera 0
                MsgBox("Con esta Venta, la existencia de este artículo será 0, se debe hacer un pedido", MsgBoxStyle.Information)

            End If

            ''ojo Aqui
            'Dim CodCliente As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
            'If CodCliente = 0 Then
            '    Me.txtDescuento.Text = "0"
            'End If


            Dim DescuentoAutomatico As Decimal = GetDescuentoAutomatico(txtCodArticulo.Text)
            If DescuentoAutomatico > 0 Then
                Me.txtDescuento.Text = DescuentoAutomatico
            End If

            Me.Calculos_Articulo()
            Validar_Punitario()

            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If

            If Lote = True Then
                ActualizaLote()
            End If
            'Cálcula cuanta cantidad se vendio de veterinaria o otra bodega
            Dim CantVet As Double = 0
            Dim CantBod As Double = 0
            Dim Diferencia As Double = 0

            '*******************************************************************************************************************
            'hay que validar que el producto este en una bodega.
            '*******************************************************************************************************************
            If Consignacion(txtCodArticulo.Text) = True Then
                If CDbl(txtCantidad.Text) <= CDbl(txtExistencia.Text) Then
                    CantVet = txtCantidad.Text
                Else
                    If CDbl(txtExistencia.Text) <= 0 Then
                        CantVet = 0
                        CantBod = txtCantidad.Text
                    Else
                        CantVet = txtExistencia.Text
                        CantBod = txtCantidad.Text - txtExistencia.Text
                    End If
                End If
            Else
                CantVet = txtCantidad.Text
                CantBod = 0
            End If            
            '*******************************************************************************************************************

            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CantVet") = CantVet
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CantBod") = CantBod
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CostoReal") = GetCostoReal(Me.txtCodArticulo.Text)

            If Me.ckpantalla.Checked = True Then
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("empaquetado") = False
            Else
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("empaquetado") = True
            End If

            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()

            Calcular_totales()
            If BindingContext(DataSet_Facturaciones, "configuraciones").Current("regalias") Then
                regalias()
            End If

            If Me.ckPedido.Checked = True Then
                'zoe
                Me.Pedido.Add(New PedidoEditado(BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo"), BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cantidad"), BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")))
                Me.ckPedido.Checked = False
            End If

            Dim CodigoTemporal As String = BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo")

            'aqui saque
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            txtCod_Articulo.Focus()
            GridControl1.Enabled = True
            AgregandoNuevoItem = False
            Me.btnAgregarExoneracion.Enabled = False

            Me.buscar_rifa()

            Me.UsaGalon(CodigoTemporal)

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub meter_al_detalle_cambiando()
        Dim frm_leyenda As New frm_leyenda
        Try

            'If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 14 Then
            '    MsgBox("Ha alcanzado el límite de la factura", MsgBoxStyle.Information)
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            '    Exit Sub
            'End If


            If CDbl(Me.txtCantidad.Text) > Me.Existencia And BodegaConsignacion = False Then 'si la cantidad digitada es mayor que la existencia
                MsgBox("No Existen " + txtCantidad.Text + " artículos, la Existencia en el inventario es de " + Me.Existencia.ToString + " ,debe hacer un pedido", MsgBoxStyle.Exclamation)

                If Not Me.vende_existecias_negativas Then
                    MsgBox("Usted no puede vender con existencias negativas", MsgBoxStyle.Critical)

                    If Me.Existencia <= 0 Then  ' si en el inventario ese articulo tiene existencias negativas
                        Me.txtCantidad.Text = 0 ' se vende solo lo que hay en el inventario
                    Else
                        Me.txtCantidad.Text = Me.Existencia '' se vende solo lo que hay en el inventario
                    End If


                    If Existencia = 0 Then ' si no hay articulos de ese tipo en el inventario
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Exit Sub
                    End If

                End If

            ElseIf CDbl(Me.txtCantidad.Text) = Me.Existencia Then 'si con esta venta el inventario la existencia sera 0
                frm_leyenda.cantidad = Me.txtCantidad.Text
                frm_leyenda.existencia = Me.Existencia.ToString
                frm_leyenda.ShowDialog()
                'MsgBox("Con esta Venta, la existencia de este artículo será 0, se debe hacer un pedido", MsgBoxStyle.Information)

            End If

            Me.Calculos_Articulo()
            Validar_Punitario()


            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If
            'Cálcula cuanta cantidad se vendio de veterinaria o otra bodega
            Dim CantVet As Double
            Dim CantBod As Double
            Dim Diferencia As Double

            If BodegaConsignacion = True Then
                If CDbl(txtCantidad.Text) <= CDbl(txtExistencia.Text) Then
                    CantVet = txtCantidad.Text
                Else
                    If CDbl(txtExistencia.Text) <= 0 Then
                        CantVet = 0
                        CantBod = txtCantidad.Text
                    Else
                        CantVet = txtExistencia.Text
                        CantBod = txtCantidad.Text - txtExistencia.Text
                    End If
                End If
            Else
                CantVet = txtCantidad.Text
                CantBod = 0
            End If
            

            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CantVet") = CantVet
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CantBod") = CantBod
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CostoReal") = GetCostoReal(Me.txtCodArticulo.Text)
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()


            Calcular_totales()

            Me.txtCod_Articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private MuestraAdvertenciaDescuento As Boolean = True
    Private Sub calculo_descuento_articulo()
        Try

            'Descuento por Casa Comercial
            Dim DescuentoAutomatico As Decimal = GetDescuentoAutomatico(Me.txtCodArticulo.Text)
            Dim DescuentoCasa As Boolean = False
            If DescuentoAutomatico > 0 Then
                DescuentoCasa = True
                Me.txtDescuento.Text = DescuentoAutomatico
            Else
                DescuentoCasa = False
            End If

            If CDbl(Me.txtDescuento.Text) > 0 Then 'si el articulo tiene un descuento
                '''''''''''''''''''''''''''''PROMO'''''''''''''''''''''' ACTIVA''''''''''''''''''''''''''''''''''''''''''
                If Me.opContado.Checked = True And DescuentoCasa = False Then
                    If Me.promo_activa_valor And Me.PromoCON = True Then 'si el articulo esta en promocion 
                        Me.txtDescuento.Text = 0.0
                        DescuentoCalc = 0
                        Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo está en promoción" + vbCrLf
                        Exit Sub
                    End If
                End If

                If Me.opCredito.Checked = True And DescuentoCasa = False Then
                    If Me.promo_activa_valor And Me.PromoCRE = True Then 'si el articulo esta en promocion 
                        Me.txtDescuento.Text = 0.0
                        DescuentoCalc = 0
                        Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo está en promoción" + vbCrLf
                        Exit Sub
                    End If
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'SI EL ARTICULO NO PERMITE DESCUENTO
                If CDbl(TxtMaxdescuento.Text) = 0 And DescuentoCasa = False Then
                    'Si el articulo  no permite que se le realize un descuento
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo no permite descuento" + vbCrLf
                    Exit Sub
                End If


                'SI EL USUARIO NO PUEDE DAR DESCUENTO
                If Me.porcentaje_descuento = 0 And DescuentoCasa = False Then
                    MsgBox("Usted no puede realizar descuentos", MsgBoxStyle.Critical)
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    Exit Sub
                End If


                'Aplicamos como maximo descuento, el descuento del usuario..
                'max_aplicar = Me.porcentaje_descuento
                If DescuentoCasa = True Then
                    max_aplicar = DescuentoAutomatico
                Else
                    max_aplicar = TxtMaxdescuento.Text
                End If

                ' validar si el descuento se puede aplicar o no el descuento
                ''''''''''''''''''''''''''''''''''''''''''''''''''''
                'If Me.porcentaje_descuento <= Double.Parse(TxtMaxdescuento.Text) Then
                '¿max_aplicar = Me.porcentaje_descuento
                'Else ' 
                'max_aplicar = Double.Parse(TxtMaxdescuento.Text)
                'End If
                'max_aplicar = CDbl(Me.TxtMaxdescuento.Text) * Me.porcentaje_descuento / 100

                'SI EL DESCUENTO DESEADO ES TOTALMENTE APLICABLE AL ARTICULO
                If CDbl(Me.txtDescuento.Text) <= max_aplicar Then

                    If Me.MuestraAdvertenciaDescuento = True Then
                        If Me.txtDescuento.Text <> "" Then
                            If CDec(Me.txtDescuento.Text) >= 8 And opCredito.Checked = False Then

                                Dim frm As New frmMaxDescuentoVenta
                                frm.ShowDialog()
                            End If
                        End If
                    End If                    

                    'si el descuento que se desea aplicar, el usuario lo puede aplicar
                    'es aplicable al cliente
                    'se asigna el maximo porcentaje que el usuaio puede dar
                    If perdiendo() Then
                        Exit Sub
                    End If

                    If Me.descuento = 0 Then ' si el cliente no tiene predefinido un descuento
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        Exit Sub
                    End If

                    If Me.descuento <> 0 And Me.txtDescuento.Text <= descuento Then
                        'si el Cliente tiene un descuento predefinido, y lo que se desea aplicar es <= que lo permitido por el cliente
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        Exit Sub
                    End If
                End If


                'SI NO LO PUEDE APLICAR EL USUARIO, PERO SI EL CLIENTE
                If CDbl(Me.txtDescuento.Text) > max_aplicar Then
                    'si el descuento que se desea aplicar
                    'es mayor que el que el usuario puede aplicar

                    Me.txtDescuento.Text = max_aplicar

                    If perdiendo() Then
                        Exit Sub
                    End If

                    If descuento = 0 Then ' si el cliente no tiene predefinido un descuento
                        Me.txtDescuento.Text = max_aplicar
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Máximo permitido por el usuario" + vbCrLf
                        Exit Sub
                    End If

                    If Me.descuento <> 0 And Me.txtDescuento.Text <= descuento Then
                        Me.txtDescuento.Text = descuento 'aplico el descuento del cliente
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Máximo permitido para el cliente" + vbCrLf
                        Exit Sub
                    End If

                End If

            Else 'si el campo de descuento esta en cero
                DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")

        End Try


    End Sub

    Function perdiendo() As Boolean
        Try
            Dim pre_unit As Double
            pre_unit = CDbl(Me.txtPrecioUnit.Text) - CDbl(Me.txtPrecioUnit.Text) * CDbl(Me.txtDescuento.Text) / 100
            If pre_unit < CDbl(Me.TxtprecioCosto.Text) Then
                Me.monto_Perdido = CDbl(Me.TxtprecioCosto.Text) - pre_unit
                If (Me.perfil_administrador) Then 'si es un administrador, quien está haciedo la facturacion
                    DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                    Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Con esta venta se está perdiendo " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                Else
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Usted no puede vender perdiendo, +con esta venta se estaria perdiendo " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf

                End If

                Return True
            Else

                Return False

            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Function


    Function perdiendo_PUnit() As Boolean
        Try
            If (CDbl(Me.txtPrecioUnit.Text) < CDbl(Me.TxtprecioCosto.Text)) Then
                Me.monto_Perdido = CDbl(Me.TxtprecioCosto.Text) - CDbl(Me.txtPrecioUnit.Text)
                If (Me.perfil_administrador) Then 'si es un administrador, quien está haciedo la facturacion

                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se disminuyó el P.unit. en " + Label31.Text + (CDbl(Me.precio_unitario - Me.txtPrecioUnit.Text)).ToString + " ,Con esta venta se está perdiendo " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                Else
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Usted no puede vender perdiendo, la disminución del P.unit. en " + Label31.Text + (CDbl(Me.precio_unitario - Me.txtPrecioUnit.Text)) + " provocaria una perdida de " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                End If
                Return True

            Else
                Return False

            End If


        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Function

    Private Sub Calculos_Articulo()
        Try
            calculo_descuento_articulo()
            Me.txtImpVenta.Text = 100 * CDbl(Me.txtImpVenta.Text) / 100
            If txtImpVenta.Text <> 0 Then 'si tiene impuesto de venta
                txtFlete.Text = 0
                txtOtros.Text = 0
                Gravado = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text))
                txtMontoImpuesto.Text = (Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(txtImpVenta.Text) / 100)
                txtSGravado.Text = Gravado
                Exento = 0
            Else 'si no tiene impuesto de venta
                txtFlete.Text = 0
                txtOtros.Text = 0
                Exento = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text))
                Gravado = 0
                txtMontoImpuesto.Text = 0
                txtSGravado.Text = 0
                txtSExcento.Text = Exento
            End If
            txtSubtotal.Text = CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text) '- CDbl(Me.txtmontodescuento.Text)
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Sub regalias()
        '/////////////////////////////REGALIAS/////////////////////////////////////////
        Dim cuantos As Double
        Dim con As Double
        Dim valor As Integer
        Dim dts As New DataTable

        With Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")

            If Me.ck_promo3x1.Checked Then
                cuantos = Fix(Me.txtCantidad.Text / 3)
                .EndCurrentEdit()
                For i As Integer = 0 To .Count - 1
                    .Position = i
                    If .Current("codigo") = Me.txtCodArticulo.Text Then

                        con += .Current("cantidad")
                    End If
                Next
                .Current("regalias") = cuantos
                .EndCurrentEdit()
                valor = Fix(con / 3)
                If valor >= 1 Then
                    txtregalias.Text = valor
                    For i As Integer = 0 To .Count - 1
                        .Position = i
                        If .Current("codigo") = Me.txtCodArticulo.Text Then
                            .Current("cantidad") += valor
                            Exit For
                        End If
                    Next

                End If
            End If
        End With
        '/////////////////////////////////////////////////////////////////////////////
    End Sub
    Private Sub Calcular_totales()
        Try

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            Calcular_Totales_Cotizacion()


            BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").AddNew()
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").CancelCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count
            If Me.opCredito.Checked = True Then
                busca_Facturas_Pendientes()
            End If

            Me.buscar_rifa()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try


    End Sub

    Private Sub Calcular_Totales_Cotizacion()  ' calcula el monto Total de la cotización
        Try
            txtSubtotalT.Text = Math.Round(Me.colSubTotal.SummaryItem.SummaryValue, 2)
            Lb_Subgravado.Text = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
            Lb_SubExento.Text = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
            txtDescuentoT.Text = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
            txtImpVentaT.Text = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
            txtTotal.Text = Math.Round(CDbl(txtSubtotalT.Text) - CDbl(Me.txtDescuentoT.Text) + CDbl(Me.txtImpVentaT.Text) + CDbl(Me.Label46.Text), 2)

            Me.txtSubtotalT.Text = CDec(Me.txtSubtotalT.Text).ToString("N2")
            Me.Lb_Subgravado.Text = CDec(Me.Lb_Subgravado.Text).ToString("N2")
            Me.Lb_SubExento.Text = CDec(Me.Lb_SubExento.Text).ToString("N2")
            Me.txtDescuentoT.Text = CDec(Me.txtDescuentoT.Text).ToString("N2")
            Me.txtImpVentaT.Text = CDec(Me.txtImpVentaT.Text).ToString("N2")
            Me.txtTotal.Text = CDec(Me.txtTotal.Text).ToString("N2")

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescuento.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txtDescuento.Text = "" Then
                    MsgBox("No puede estar vacío", MsgBoxStyle.Exclamation)
                    Me.txtDescuento.Text = "0"
                    Exit Sub
                Else
                    If (CDbl(Me.txtDescuento.Text) > 100) Then Me.txtDescuento.Text = 100
                End If

                Me.Calculos_Articulo()

                If mensaje <> "" Then
                    MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                    mensaje = ""
                End If

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    Calcular_totales()
                End If
                Me.txtCantidad.Focus()
            End If

            If e.KeyCode = Keys.F5 Then
                Me.password_antiguo = Me.txtUsuario.Text
                Me.txtUsuario.Text = ""
                Me.txtUsuario.Enabled = True
                Me.txtNombreUsuario.Text = ""

                Me.GroupBox6.Enabled = False
                Me.GroupBox3.Enabled = False
                txtorden.Enabled = True
                Me.txtUsuario.Focus()
            End If

            If e.KeyCode = Keys.F2 Then
                'codigo_cliente = txtcodigo.Text
                'nombre_cliente = txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                Me.TclCaja = "F2"
                Me.Registrar(False, 1)
            End If

            If e.KeyCode = Keys.F3 Then
                'codigo_cliente = txtcodigo.Text
                'nombre_cliente = txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                Me.TclCaja = "F3"
                Me.Registrar(True, 1)
            End If

            If e.KeyCode = Keys.F4 Then
                'codigo_cliente = txtcodigo.Text
                'nombre_cliente = txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                Me.TclCaja = "F4"
                Me.Registrar(False, 2)
            End If

            If e.KeyCode = Keys.F5 Then
                'codigo_cliente = txtcodigo.Text
                'nombre_cliente = txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
                'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                Me.TclCaja = "F5"
                Me.Registrar(True, 2)
            End If

            If e.KeyCode = Keys.F6 Then
                Me.password_antiguo = Me.txtUsuario.Text
                Me.txtUsuario.Text = ""
                Me.txtUsuario.Enabled = True
                Me.txtNombreUsuario.Text = ""
                Me.GroupBox3.Enabled = False
                txtorden.Enabled = True
                Me.txtUsuario.Focus()
            End If

            If e.KeyCode = Keys.Escape Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                Me.txtCod_Articulo.Focus()
                Me.GridControl1.Enabled = True
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub Label31_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label31.TextChanged
        Me.Label4.Text = Me.Label31.Text
        Me.Label32.Text = Me.Label31.Text
        Me.Label33.Text = Me.Label31.Text
        Me.Label34.Text = Me.Label31.Text
        Me.Label35.Text = Me.Label31.Text
        Me.Label29.Text = Me.Label31.Text
        Label44.Text = Label31.Text
        Label11.Text = Label31.Text
        Label43.Text = Label31.Text

    End Sub
    'Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    '    'Try
    '    '    If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
    '    '        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
    '    '            e.Handled = True  ' esto invalida la tecla pulsada
    '    '        End If
    '    '    End If
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
    '    'End Try
    'End Sub
    Private Sub txtorden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorden.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    'Private Sub txtCodArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodArticulo.KeyPress
    '    If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
    '        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
    '            e.Handled = True  ' esto invalida la tecla pulsada
    '        End If
    '    End If
    'End Sub


    Private Sub Validar_Punitario()
        Try
            Dim max_precio_unit As Double

            max_precio_unit = ((variacion_Punit / 100) * precio_unitario)    ' se calcula la variacioon maxima que se puede hacer sobre ese articulo

            If CDbl(txtPrecioUnit.Text) < precio_unitario Then
                If perdiendo_PUnit() Then
                    Exit Sub
                End If

                If (precio_unitario - CDbl(txtPrecioUnit.Text)) > (max_precio_unit) Then ' si se bajo el precio mas de lo posible
                    MsgBox("Precio unitario inválido, solo puede variar el precio en un " + variacion_Punit.ToString + "% = " + Label31.Text.ToString + " " + max_precio_unit.ToString, MsgBoxStyle.Exclamation)
                    txtPrecioUnit.Text = precio_unitario
                    Exit Sub
                End If
            End If

            'If CDbl(txtPrecioUnit.Text) > Me.precio_unitario Then ' si se esta subiendo el precio unitario

            '    If (CDbl(Me.txtPrecioUnit.Text - Me.precio_unitario)) > (max_precio_unit) Then ' si se subio el precio mas de lo posible
            '        MsgBox("Precio unitario inválido, solo puede variar el precio en un " + variacion_Punit.ToString + "% = " + Me.Label31.Text.ToString + " " + max_precio_unit.ToString, MsgBoxStyle.Exclamation)
            '        txtPrecioUnit.Text = Me.precio_unitario
            '        Exit Function
            '    End If
            'End If


        Catch ex As SystemException
            txtPrecioUnit.Text = precio_unitario
            'MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub SoloNumericos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress, txtDescuento.KeyPress, txtPrecioUnit.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If

    End Sub


    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txtdireccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtdireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtorden.Enabled = False Then txtorden.Enabled = True
            txtorden.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If

        If e.KeyCode = Keys.Escape Then
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            txtCod_Articulo.Focus()
            GridControl1.Enabled = True
        End If
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Ariculo_Detalle()
        End If

        If e.KeyCode = Keys.F2 Then
            If buscando = True Then Exit Sub
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            If buscando = True Then Exit Sub
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            If buscando = True Then Exit Sub
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            If buscando = True Then Exit Sub
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If

        If e.KeyCode = Keys.F6 Then
            If buscando = True Then Exit Sub
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            password_antiguo = txtUsuario.Text
            txtUsuario.Text = ""
            txtUsuario.Enabled = True
            txtNombreUsuario.Text = ""
            GroupBox3.Enabled = False
            txtorden.Enabled = True
            txtUsuario.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            txtCod_Articulo.Focus()
            GridControl1.Enabled = True
        End If
    End Sub

    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este artículo de la Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    If Lote = True Then
                        EliminaLote()
                    End If

                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").RemoveAt(BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position)
                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()

                    Calcular_totales()
                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                Else
                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Artìculos para eliminar en la Factura", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Recalcular_Precios()
        If Me.coti = True Then Exit Sub

        Dim i As Integer = 0
        Dim dt As New DataTable

        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()

        For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i

            cFunciones.Llenar_Tabla_Generico("select Promo_Activa, Precio_Promo, PromoCON, PromoCRE, Precio_A, Precio_B from inventario where codigo = " & Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo"), dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.promo_activa_valor = dt.Rows(0).Item("Promo_Activa")
                Me.precio_promo_valor = dt.Rows(0).Item("Precio_Promo")
                Me.PromoCON = dt.Rows(0).Item("PromoCON")
                Me.PromoCRE = dt.Rows(0).Item("PromoCRE")
                Me.PrecioContado = dt.Rows(0).Item("Precio_A")
                Me.PrecioCredito = dt.Rows(0).Item("Precio_B")

                Me.Calculo_precio_unitario()
                Me.Calculos_Articulo() ' se calcula de nuevo los datos del articulo 
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            End If
        Next

        Calcular_Totales_Cotizacion()
    End Sub

    Private Sub opCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opCredito.CheckedChanged, opContado.CheckedChanged
        Try

            Me.txtDiasPlazo.Visible = Me.opCredito.Checked
            Me.lblDia.Visible = Me.opCredito.Checked

            If opCredito.Checked = True And txtcodigo.Text = "0" And Not Importando Then
                MsgBox("Este es un Cliente de Contado, no se le puede dar crédito", MsgBoxStyle.Information)
                opCredito.Checked = False
                opContado.Checked = True
                dias_credito()
                Exit Sub
            End If

            If opCredito.Checked = True And buscando = False Then ' si esta marcada la opcion de credito
                Cargar_Cliente(txtcodigo.Text)
                recargar_Cliente()
                busca_Facturas_Pendientes()
                dias_credito()
            End If

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                Verificar_Consecutivos(False)
                Me.Recalcular_Precios()
            End If

            Me.buscar_rifa()

            txtCod_Articulo.Focus()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub dias_credito()
        Try

            If BindingContext(DataSet_Facturaciones, "Ventas").Count > 0 Then  ' si hay ventas
                If opContado.Checked = False Then 'Si esta marcada la opcion de credito
                    txtDiasPlazo.Visible = True
                    lblDia.Visible = True
                    txtDiasPlazo.Text = plazo_credito
                    If BindingContext(DataSet_Facturaciones, "Ventas").Count > 0 Then TxtTipo.Text = "CRE"
                    Dim Fecha As Date
                    Fecha = dtFecha.Text
                    DtVence.Text = Fecha.AddDays(txtDiasPlazo.Text)
                    DtVence.Visible = True

                    If Not buscando Then txtorden.Enabled = True

                Else 'la opcion de contado esta marcada
                    txtDiasPlazo.Text = 0
                    txtDiasPlazo.Visible = False
                    lblDia.Visible = False

                    If BindingContext(DataSet_Facturaciones, "Ventas").Count > 0 Then TxtTipo.Text = "CON" 'BindingContext(DataSet_Facturaciones, "Ventas").Current("Tipo") = "CON"
                    BindingContext(DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = "NINGUNO"

                    Label41.Visible = False
                    txtorden.Text = 0
                    txtorden.Enabled = True
                    DtVence.Text = dtFecha.Text
                    DtVence.Visible = False
                End If
            End If
            BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtTelefono.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            Me.txtTelefono.Focus()
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            Me.txtTelefono.Focus()
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            Me.txtTelefono.Focus()
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            ' Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            Me.txtTelefono.Focus()
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Me.txtCod_Articulo.Focus()
            Me.GridControl1.Enabled = True
        End If

    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then
                MsgBox("No se puede aplicar descuento, aún no hay artículos", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim maximo_descuento As Double = Me.porcentaje_descuento
            Dim ajustar_descuento_general_objero As New Ajuste_Descuento_Factura(maximo_descuento, Me.descuento)
            ajustar_descuento_general_objero.ShowDialog()
            Dim nuevo_descuento As Double = ajustar_descuento_general_objero.nuevo_porc_descuento

            If nuevo_descuento < 0 Then txtCod_Articulo.Focus() : Exit Sub ' si se digito 0 en el descuento 

            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            GridControl1.Enabled = True
            GridControl1.Focus()

            recalcular_cotizacion(nuevo_descuento)
            Calcular_totales()

            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If

            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            txtCod_Articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'Dim trans As Double
        'Dim mont_trans As New Monto_Transporte_Ventas
        'Try

        '    mont_trans.ShowDialog()
        '    trans = mont_trans.Monto

        '    Label46.Text = trans

        '    Me.Calcular_Totales_Cotizacion()
        '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()


        'Catch ex As System.Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        'End Try
    End Sub



    Private Sub txtPrecioUnit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioUnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.txtPrecioUnit.Text = "" Then Exit Sub
                Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))

                Me.Calculos_Articulo()
                Validar_Punitario()

                If mensaje <> "" Then
                    MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                    mensaje = ""
                End If

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    Calcular_totales()
                End If


                If Me.txtDescuento.Enabled = True Then
                    Me.txtDescuento.Focus()
                Else
                    Me.txtCantidad.Focus()
                End If

            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        End If

        If e.KeyCode = Keys.F2 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If

        If e.KeyCode = Keys.F6 Then
            Me.password_antiguo = Me.txtUsuario.Text
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Enabled = True
            Me.txtNombreUsuario.Text = ""
            Me.GroupBox3.Enabled = False
            txtorden.Enabled = True
            Me.txtUsuario.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Me.txtCod_Articulo.Focus()
            Me.GridControl1.Enabled = True
        End If
    End Sub

    Private Function Utilidad(ByVal Costo As Double, ByVal Precio As Double) As Double
        Utilidad = ((Precio / Costo) - 1) * 100
        Return Utilidad
    End Function

    Private Sub txtCantidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCantidad.Validating
        Try

            If Me.txtCantidad.Text = "" Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "Debes cotizar almenos un artículo")
                txtCantidad.Text = 1
            Else
                ErrorProvider1.SetError(sender, "")
            End If

            If CDbl(Me.txtCantidad.Text) = 0 Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "Debes cotizar almenos un artículo")
                txtCantidad.Text = 1
            Else
                ErrorProvider1.SetError(sender, "")
            End If

        Catch ex As SystemException
            txtCantidad.Text = 1
            ErrorProvider1.SetError(sender, "")
        End Try
    End Sub


    Private Sub txtDescuento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescuento.Validating
        Try

            If Me.txtDescuento.Text = "" Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "Digite el descuento")
                txtCantidad.Text = 0

            Else
                ErrorProvider1.SetError(sender, "")
            End If


        Catch ex As SystemException
            txtDescuento.Text = 0
            ErrorProvider1.SetError(sender, "")
        End Try

    End Sub

    Private Sub txtPrecioUnit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrecioUnit.Validating
        Try
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count = 0 Then
                Exit Sub
            End If
            If Me.txtPrecioUnit.Text = "" Then 'si el campo está vacío
                'ErrorProvider1.SetError(sender, "Debes digitar el precio unitario")
                'txtPrecioUnit.Text = Me.precio_unitario

                Exit Sub
            Else
                ErrorProvider1.SetError(sender, "")
                Exit Sub
            End If


            If CDbl(Me.txtPrecioUnit.Text) = 0 Then  'si el campo está vacío
                'ErrorProvider1.SetError(sender, "Debes digitar el precio unitario")
                'txtPrecioUnit.Text = Me.precio_unitario

                Exit Sub
            Else
                ErrorProvider1.SetError(sender, "")
                Exit Sub
            End If


        Catch ex As SystemException
            'txtPrecioUnit.Text = Me.precio_unitario
            txtPrecioUnit.Text = 0
        End Try

    End Sub


    Private Sub valid_cambios_Punit_Desc_Cant()


        'If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descuento") <> CDbl(Me.txtDescuento.Text) Then

        '    ''''''Descuento

        '    If Me.txtDescuento.Text = "" Then
        '        MsgBox("No puede estar vacío", MsgBoxStyle.Exclamation)
        '        Me.txtDescuento.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descuento")
        '        Exit Function
        '    Else

        '        If (CDbl(Me.txtDescuento.Text) > 100) Then Me.txtDescuento.Text = 100

        '    End If

        '    Me.Calculos_Articulo()
        '    If mensaje <> "" Then
        '        MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
        '        mensaje = ""
        '    End If

        '    If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
        '        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
        '        Calcular_totales()
        '    End If

        '    'Me.txtCantidad.Focus()

        'End If


        'If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit") <> CDbl(Me.txtPrecioUnit.Text) Then

        '    '''''Precio Unitario
        '    Me.Calculos_Articulo()
        '    Validar_Punitario()

        '    If mensaje <> "" Then
        '        MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
        '        mensaje = ""
        '    End If

        '    If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
        '        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
        '        Calcular_totales()
        '    End If

        'End If


        'If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cantidad") <> CDbl(Me.txtCantidad.Text) Then
        '    '''''''''''Cantidad
        '    Me.meter_al_detalle()
        'End If


    End Sub

    Private Sub busca_Facturas_Pendientes()
        Try
            Dim cConexion As New Conexion
            Dim sqlConexion As New SqlConnection
            Dim ConexionLocal As New Conexion
            Dim rs As SqlDataReader
            Dim id_Factura As Long
            Dim num_Fac As Double
            Dim monto_Fact As Double
            Dim TCambio As Double
            Dim Ven As Date
            sqlConexion = cConexion.Conectar
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT id, Num_Factura, Total, Tipo_Cambio,dbo.dateOnly(Vence) as Vence, Tipo from Ventas where (Tipo = 'CRE' Or Tipo = 'TCR' Or Tipo = 'MCR') and FacturaCancelado = 0 and dbo.SaldoFactura(getdate(),num_factura,tipo,cod_cliente) > 0 and Anulado = 0 and Cod_Cliente =" & txtcodigo.Text)


            While rs.Read
                id_Factura = rs("Id")
                num_Fac = rs("Num_Factura")
                monto_Fact = rs("Total")
                TCambio = rs("Tipo_Cambio")
                '************************************************************+
                Ven = Format("dd/MM/yyyy", rs("Vence")) '  rs("Vence")
                'Evaluo las fechas, si el resultado el negativo me indica que la fecha actual es menor 
                ' que la fecha de vencimiento de la factura
                'JCGA 10 DE JULIO 2007
                Dim intervalo As Long = DateDiff(DateInterval.Day, CDate(Today), CDate(Ven))
                intervalo = intervalo
                '************************************************************+
                'If Today > CDate(Ven.Date) And Not Me.sinrestriccion Then
                If intervalo < 0 And Not Me.sinrestriccion Then
                    MsgBox("El Cliente tiene una(s) Facura(s) pendiente(s), la factura solo puede ser de contado", MsgBoxStyle.Critical)
                    Me.opContado.Checked = True
                    Exit Sub
                End If

                Me.Monto_Adeudado += Me.CConexion.SlqExecuteScalar(cConexion.Conectar, "Select dbo.SaldoFactura(getdate()," & num_Fac & ", '" & rs("Tipo") & "' ," & Me.txtcodigo.Text & " )")
                cConexion.DesConectar(cConexion.sQlconexion)
            End While

            If (Monto_Adeudado + Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Total")) > Me.max_credito Then

                If (Me.sinrestriccion) Then ' si el cliente es sin restricciones
                    MsgBox("Con esta Factura el Cliente sobrepasará el límite de crédito, permitido ", MsgBoxStyle.Information)

                Else
                    If usua.Perfil = "Administrador" Then MsgBox("Con esta Factura el Cliente sobrepasará el límite de crédito ( " + Label31.Text + Me.max_credito.ToString + "), Cliente tiene un monto Adeudado de " + Label31.Text + Me.Monto_Adeudado.ToString + ", la factura solo puede ser de contado", MsgBoxStyle.Critical)
                    MsgBox("Este Cliente Sobrepasa el límite de crédito con estaºfactura, la factura solo puedeser de contado", MsgBoxStyle.Critical)
                    Me.opContado.Checked = True
                End If

            End If

            cConexion.DesConectar(sqlConexion)

            ' MsgBox(Monto_Adeudado.ToString)

            Me.Monto_Adeudado = 0


        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Public Function Saldo_Facturas(ByVal FacturaNo As Long, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal id As Long) As Double
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim MontoDevoluciones As Double
        Dim MontoAbonos As Double
        Dim MontoNCredito As Double
        Dim MontoNDebito As Double
        Dim InteresCob As Double
        Dim Saldo_de_Factura As Double

        Try
            sqlConexion = cConexion.Conectar
            MontoDevoluciones = 0

            'Cálcula Devoluciones
            MontoDevoluciones = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Monto) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & id & " AND Anulado = 0")
            'Cálcula los Abonos
            MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "select  SUM(detalle_abonoccobrar.Abono_SuMoneda) AS TotalAbono FROM detalle_abonoccobrar INNER JOIN  abonoccobrar ON detalle_abonoccobrar.Id_Recibo = abonoccobrar.Id_Recibo WHERE (detalle_abonoccobrar.Tipo = 'CRE') AND and Factura =" & FacturaNo & " AND abonoccobrar.Anula = 0")

            'NOTAS DE CREDITO
            MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(detalle_ajustesccobrar.Ajuste) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE (detalle_ajustesccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND (detalle_ajustesccobrar.Tipo = 'CRE')")

            'NOTAS DE DEBITO
            cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(detalle_ajustesccobrar.Ajuste) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE (detalle_ajustesccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND (detalle_ajustesccobrar.Tipo = 'DEB')")
            'Obtener el saldo final de la factura
            Saldo_de_Factura = MontoFactura + ((MontoNDebito - MontoNCredito - MontoAbonos) * TipoCambFact)

            cConexion.DesConectar(sqlConexion)
            Return Saldo_de_Factura

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Private Sub txtTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyDown
        If e.KeyCode = Keys.F2 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If
    End Sub

    Private Sub Combo_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F2"
            Me.Registrar(False, 1)
        End If

        If e.KeyCode = Keys.F3 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 1
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F3"
            Me.Registrar(True, 1)
        End If

        If e.KeyCode = Keys.F4 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F4"
            Me.Registrar(False, 2)
        End If

        If e.KeyCode = Keys.F5 Then
            'codigo_cliente = txtcodigo.Text
            'nombre_cliente = txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Nombre_Cliente") = Me.txtNombre.Text
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("num_caja") = 2
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.TclCaja = "F5"
            Me.Registrar(True, 2)
        End If
    End Sub


    Private Sub TxtprecioCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtprecioCosto.TextChanged
        Label_Costobase.Text = Me.TxtprecioCosto.Text
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim frm As New frmAdvertenciaTipodeCambio
        frm.ShowDialog()
        Me.ComboBox1.Enabled = True
        Me.ComboBox1.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        If Me.opContado.Checked = True Then
            '    Me.iniciar_factura()
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
        GridControl1.Enabled = True
        Dim nota As String
        If Me.ckpantalla.Checked = True Then
            nota = InputBox("Ingrese la nota para el producto", "Nota en pantalla", "")
            If nota = "" Then
                nota = "0"
            End If
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("nota_pantalla") = nota
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
        End If
    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        If Me.txtCantidad.Text = "" Then
            Exit Sub
        End If
        If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
            If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            End If
        End If
    End Sub

    Private Sub txtPrecioUnit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioUnit.Leave
        Try
            If Me.txtPrecioUnit.Text = "" Then  'si el campo está vacío
                'txtPrecioUnit.Text = Me.precio_unitario
                Exit Sub
            End If

            If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtDescuento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuento.Leave
        Try
            If Me.txtDescuento.Text = "" Then
                'MsgBox("No puede estar vacío", MsgBoxStyle.Exclamation)
                ' Me.txtDescuento.Text = "0"
                Exit Sub
            Else

                If (CDbl(Me.txtDescuento.Text) > 100) Then Me.txtDescuento.Text = 100

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                End If

            End If
        Catch EX As SystemException
            MsgBox(EX.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtCodArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCod_Articulo.GotFocus
        'Me.GridControl1.Enabled = False
        txtCod_Articulo.SelectAll()
    End Sub

    Private Sub TxtUtilidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUtilidad.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then
                Dim PosActual As Integer = 0
                Try
                    PosActual = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position

                    If Me.TxtUtilidad.Text = "" Then Exit Sub
                    Me.txtPrecioUnit.Text = CDbl(Me.txtCostoBase.Text) * (Me.TxtUtilidad.Text / 100) + Me.txtFlete.Text + Me.txtOtros.Text + CDbl(txtCostoBase.Text)

                    Me.Calculos_Articulo()
                    Validar_Punitario()

                    If mensaje <> "" Then
                        MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                        mensaje = ""
                    End If
                    If Not IsDBNull(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descripcion")) Then
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                        Calcular_totales()
                    End If
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = PosActual
                Catch ex As SystemException
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub TxtUtilidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUtilidad.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtCodArticulo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCod_Articulo.LostFocus
        Try
            If AgregandoNuevoItem = False Then
                If DataSet_Facturaciones.Ventas_Detalle.Rows.Count > 0 Then
                    txtCodArticulo.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo")
                    txtCod_Articulo.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CodArticulo")
                End If

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas_Detalle").CancelCurrentEdit()
            Else
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas_Detalle").EndCurrentEdit()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtCodArticulo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod_Articulo.EditValueChanged
        AgregandoNuevoItem = False
    End Sub

    Private Sub TxtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCod_Articulo.Focus()
        End If
    End Sub

    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus
        BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
    End Sub

    Private Sub Ck_Exonerar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ck_Exonerar.CheckedChanged
        If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
            If buscando = False Then
                If Me.Ck_Exonerar.Checked = True Then
                    MsgBox("Debe marcar primero la opcion de exoneracion y luego agregar los articulos a la factura." & vbCrLf _
                           & "Los articulos que estan en la lista no seran exonerados, debe eliminarlos y volverlos a agregar.", MsgBoxStyle.Exclamation, Text)
                End If

                '    recalcular_cotizacion_cambio_cliente()
                '    txtCod_Articulo.Focus()
            End If
        End If
    End Sub

    Private Sub txtExistencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExistencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub Ck_Taller_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ck_Taller.CheckedChanged
        ' BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Taller") = Me.Ck_Taller.Checked        
        If BindingContext(DataSet_Facturaciones, "Ventas").Count > 0 Then
            Verificar_Consecutivos(False)
        End If
    End Sub

#Region "Lotes - Serie"

#Region "Controles Lotes"
    Private Sub ActivaLote()
        Me.LOpcion.Text = "Lote ->"
        Me.LOpcion.Visible = True
        Me.LNumero.Visible = True
        Me.CbNumero.Visible = True
        Me.LVencimiento.Visible = True
        Me.LFVencimiento.Visible = True
        Me.Lote = True
        Me.CargarCbNumero()
    End Sub

    Private Sub ActivaNinguno()
        Me.LOpcion.Text = "Opcion"
        Me.LOpcion.Visible = False
        Me.LNumero.Visible = False
        Me.CbNumero.Visible = False
        Me.LVencimiento.Visible = False
        Me.LFVencimiento.Visible = False
        Me.Lote = False
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote") = "0"
    End Sub
#End Region

#Region "Funciones"
    Private Sub CargarCbNumero()
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim i As Integer
        CbNumero.Items.Clear() ' limpia el combo

        Try
            If txtCodArticulo.Text <> Nothing Then
                rss = DataSet_Facturaciones.Lotes.Select("Cod_Articulo = " & CInt(Me.txtCodArticulo.Text) & " And Cant_Actual > 0 and Vencimiento >= '" & Now.Date & "'")

                If rss.Length <> 0 Then ' si existe lote con cantidad disponible
                    For i = 0 To rss.Length - 1
                        rs = rss(i)
                        CbNumero.Items.Add(rs("Numero"))
                    Next i

                    If Me.CbNumero.SelectedIndex = -1 Then
                        Me.CbNumero.SelectedIndex = 0
                    End If
                    CbNumero.Enabled = True

                Else
                    MsgBox("No hay lotes o series disponibles en inventario para este artículo", MsgBoxStyle.Critical)
                    txtCodArticulo.Focus()
                End If
            Else
                MsgBox("Debe escribir el Código del Artículo", MsgBoxStyle.Critical)
                txtCodArticulo.Focus()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Function VerificaLote() As Boolean
        VerificaLote = False
        If Cant_Actual < CDbl(Me.txtCantidad.Text) Then
            VerificaLote = True
            MsgBox("La cantidad digitada del artículo no esta disponible", MsgBoxStyle.Critical, "Cantidad Incorrecta")
        End If
        If Now.Date > CDate(Me.LFVencimiento.Text) Then
            VerificaLote = True
            MsgBox("El articulo esta vencido", MsgBoxStyle.Critical, "Fecha De Vencimiento Incorrecta")
        End If
    End Function


    Private Sub ActualizaLote()
        Dim pos As Integer
        Dim vista As DataView

        Try
            If CbNumero.SelectedItem <> Nothing Then
                If BindingContext(DataSet_Facturaciones, "Lotes").Count > 0 Then
                    BindingContext(DataSet_Facturaciones, "Lotes").CancelCurrentEdit()
                End If

                BindingContext(DataSet_Facturaciones, "Lotes").EndCurrentEdit()
                vista = DataSet_Facturaciones.Lotes.DefaultView
                vista.Sort = "Id"
                pos = vista.Find(Id)
                BindingContext(DataSet_Facturaciones, "Lotes").Position = pos
                BindingContext(DataSet_Facturaciones, "Lotes").Current("Cant_Actual") = Cant_Actual - CDbl(txtCantidad.Text)
                BindingContext(DataSet_Facturaciones, "Lotes").EndCurrentEdit()
                BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote") = CbNumero.SelectedItem

            Else
                MsgBox("Debe Seleccionar un Número", MsgBoxStyle.Critical)
                CbNumero.Focus()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub EliminaLote()
        Dim DrElimina() As System.Data.DataRow
        Dim DrElim As System.Data.DataRow
        Dim pos As Integer
        Dim vista As DataView
        Dim i As Integer

        Try
            If CbNumero.SelectedItem <> Nothing Then
                DrElimina = DataSet_Facturaciones.Lotes.Select("Numero = '" & BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Numero") & "' And Cod_Articulo = " & CInt(txtCodArticulo.Text))

                If DrElimina.Length <> 0 Then 'Si existe
                    For i = 0 To DrElimina.Length - 1
                        DrElim = DrElimina(i)
                        Me.Id = DrElim("Id")
                    Next i

                    BindingContext(DataSet_Facturaciones, "Lotes").EndCurrentEdit()
                    vista = DataSet_Facturaciones.Lotes.DefaultView
                    vista.Sort = "Id"
                    pos = vista.Find(Id)
                    BindingContext(DataSet_Facturaciones, "Lotes").Position = pos
                    BindingContext(DataSet_Facturaciones, "Lotes").Current("Cant_Actual") += BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cantidad")
                    BindingContext(DataSet_Facturaciones, "Lotes").EndCurrentEdit()

                Else
                    MsgBox("Error en la Actualizacion del Lote", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe Seleccionar un Número", MsgBoxStyle.Critical)
                CbNumero.Focus()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Public Sub BuscaArticulo()
        Dim ConNumero As New Conexion
        Dim rs As SqlDataReader

        If txtCodArticulo.Text <> "" Then
            rs = ConNumero.GetRecorset(ConNumero.Conectar("SeePos"), "SELECT Lote from Inventario where Codigo =" & Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo"))
            While rs.Read
                Try
                    If rs("Lote") = True Then
                        'ActivaLote()
                    Else
                        'ActivaNinguno()
                    End If

                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()
            ConNumero.DesConectar(ConNumero.Conectar)
        Else
            MsgBox("Debe de digitar el Número", MsgBoxStyle.Exclamation)
        End If
    End Sub
#End Region

#Region "Busca Vencimiento y Cantidad"
    Private Sub CbNumero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbNumero.SelectedIndexChanged
        Dim DrFecha() As System.Data.DataRow
        Dim DrVencimiento As System.Data.DataRow
        Dim i As Integer
        Me.LFVencimiento.Text = ""
        Cant_Actual = 0

        Try
            If Me.CbNumero.SelectedItem <> Nothing Then
                DrFecha = DataSet_Facturaciones.Lotes.Select("Numero = '" & CbNumero.SelectedItem & "' And Cod_Articulo = " & CInt(Me.txtCodArticulo.Text))

                If DrFecha.Length <> 0 Then 'Si existe
                    For i = 0 To DrFecha.Length - 1
                        DrVencimiento = DrFecha(i)
                        LFVencimiento.Text = DrVencimiento("Vencimiento")
                        Cant_Actual = DrVencimiento("Cant_Actual")
                        Id = DrVencimiento("Id")
                        If DateDiff(DateInterval.Day, Now.Date, CDate(LFVencimiento.Text)) < 45 Then
                            MsgBox("El artículo esta pronto a vencerse!!", MsgBoxStyle.Exclamation)
                        End If
                    Next
                Else
                    MsgBox("Error en la Fecha de Vencimento!", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe Seleccionar un Lote!", MsgBoxStyle.Critical)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region


    Private Sub CbNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPrecioUnit.Enabled = True Then  'si el usuario puede disminuir o aumentar el costo del articulo
                txtPrecioUnit.Focus()
            ElseIf txtDescuento.Enabled = True Then
                txtDescuento.Focus()
            Else
                txtCantidad.Focus()
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            txtCodArticulo.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        Dim dts As New DataTable
        If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
            If coti = False Then
                If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote") <> "0" Then
                    ActivaLote()
                    CbNumero.SelectedItem = BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote")
                Else

                    Me.btnAgregarExoneracion.Enabled = True

                    ActivaNinguno()

                    cFunciones.Llenar_Tabla_Generico("select * from inventario where codigo = " & BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("codigo"), dts, CadenaConexionSeePOS)
                    If dts.Rows.Count > 0 Then
                        Me.ckpantalla.Checked = dts.Rows(0).Item("pantalla")
                    End If
                End If
            ElseIf coti = True And BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote") = "0" Then
                Me.btnAgregarExoneracion.Enabled = True
                BuscaArticulo()
            End If
        End If
    End Sub
#End Region

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub HechoPor()
        Dim Cx As New Conexion
        Try
            txtHecho.Text = Cx.SlqExecuteScalar(Cx.Conectar(), "SELECT Nombre FROM Usuarios WHERE cedula = '" & BindingContext(DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario") & "'")
        Catch ex As Exception
        Finally
            Cx.DesConectar(Cx.sQlconexion)
        End Try
    End Sub

    Private Sub _verificar_fact_canc(ByVal id As Double)
        Dim Cx As New Conexion
        Dim respuesta As Integer = 0
        Try
            respuesta = Cx.SlqExecuteScalar(Cx.Conectar(), "SELECT 1 AS Expr1 FROM Ventas WHERE (FacturaCancelado = '1') AND (id = '" & id & "')")
        Catch ex As Exception
        Finally
            Cx.DesConectar(Cx.sQlconexion)
        End Try
        If respuesta = 1 Then
            Me.txtCancelado.Visible = True
            txtCancelado.Text = "CANCELADO"
        Else
            Me.txtCancelado.Visible = True
            txtCancelado.Text = ""
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_Mascotas.CheckedChanged
        If BindingContext(DataSet_Facturaciones, "Ventas").Count > 0 Then
            Verificar_Consecutivos(False)
        End If
    End Sub

    Public Sub insertar_anulacion(ByVal ced As String, ByVal fecha As Date, ByVal descrip As String, ByVal id_fac As Integer, ByVal justifica As Boolean, ByVal _CedAdmin As String)
        Dim just As Integer
        If justifica = True Then
            just = 1
        Else
            just = 0
        End If
        Dim sentencia = "INSERT INTO registro_anulaciones (cedula_usuario, fecha, descripcion,id_factura,justificacion,Administrador)VALUES('" & ced & "','" & fecha & "','" & descrip & "'," & id_fac & "," & just & ",'" & _CedAdmin & "')"
        Dim SQL As New GestioDatos
        SQL.Ejecuta(sentencia)

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Sub existencia_enbodega(ByVal cod As String)
        Dim dts As New DataTable
        Dim codigo As String
        Dim bodega As String
        Dim existenciaBodega As Double
        Dim funciones As New Conexion
        Dim existenciab As Double

        Dim i As Integer

        codigo = cod
        cFunciones.Llenar_Tabla_Generico("select codigo,id_bodega,ExistenciaBodega,Existencia,dbo.ReporteBodega_SaldoInicial(GETDATE(),codigo,Id_Bodega)as exisbod  from Inventario where Consignacion = 1 and cod_articulo = '" & codigo & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            codigo = dts.Rows(0).Item("codigo")
            existenciaBodega = dts.Rows(0).Item("exisbod")
            Existencia = dts.Rows(0).Item("existenciabodega")
            If Existencia <> existenciaBodega Then
                funciones.UpdateRecords("inventario", "existenciaBodega = " & existenciaBodega, "codigo = " & codigo, "SeePos")
            End If
        End If

    End Sub
    Sub existencia_bodega()
        Dim dts As New DataTable
        Dim codigo As String
        Dim bodega As String
        Dim existenciaBodega As Double
        Dim funciones As New Conexion

        Dim i As Integer

        For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones.Ventas_Detalle).Count - 1
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
            codigo = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("codigo")
            cFunciones.Llenar_Tabla_Generico("select codigo,id_bodega,ExistenciaBodega,Existencia,dbo.ReporteBodega_SaldoInicial(GETDATE(),codigo,Id_Bodega)as exisbod  from Inventario where Consignacion = 1 and codigo = " & codigo, dts, CadenaConexionSeePOS)
            If dts.Rows.Count > 0 Then
                codigo = dts.Rows(0).Item("codigo")
                existenciaBodega = dts.Rows(0).Item("exisbod")
                funciones.UpdateRecords("inventario", "existenciaBodega = " & existenciaBodega, "codigo = " & codigo, "SeePos")
            End If
        Next
    End Sub

    Private Function AutoActivaPD(_id As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from [dbo].[PrecioDiferenciado] where idagente = " & _id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private CodAgente As Long = 0
    Private Sub ck_agente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_agente.CheckedChanged
        Dim cFunciones As New cFunciones
        Dim c As String
        If Me.ck_agente.Checked = True Then
            Me.DetenerTiempo()
            c = cFunciones.BuscarDatos("select id as id,nombre as Nombre from agente_ventas where Activo = 1 and anulado = 0", "Nombre")
            If c <> "" Then
                Me.CodAgente = c
                Me.txtagente.Text = c
                If c = 8 Then 'solo para huber
                    Me.ckPD.Checked = Me.AutoActivaPD(c)
                End If
            Else
                Me.ck_agente.Checked = False
                Exit Sub
            End If
            Me.IniciaTiempo()
        End If
        Me.ckPD.Enabled = Me.ck_agente.Checked
        If Me.ckPD.Enabled = False Then
            Me.ckPD.Checked = False
        End If
    End Sub

    Private Sub cbo_tipo_cliente_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cbo_tipo_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cedula.Focus()
        End If
    End Sub

    Dim BanderaPuedeCambiarTipoCliente As Boolean = False
    Private Sub cbo_tipo_cliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_tipo_cliente.SelectedIndexChanged
        If BanderaPuedeCambiarTipoCliente = False Then
            txtcodigo.Text = ""
            txtNombre.Text = ""
            txtTelefono.Text = ""
            TxtObservaciones.Text = ""
            txtEncargado.Text = ""
            Txtdireccion.Text = ""
            Me.txtCorreoComprobantes.Text = ""
            txt_cedula.Text = ""
        End If
    End Sub

    Private Sub cbo_tipo_cliente_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cbo_tipo_cliente.KeyPress
        If Keys.Enter Then
            txtcodigo.Focus()
        End If
    End Sub

    Private Sub txt_cedula_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_cedula.TextChanged
        Me.IngresoIdentificacion = False
        borrar()
    End Sub

    Sub borrar()
        If txt_cedula.Text = "" Then
            Me.IngresoIdentificacion = False
            txtcodigo.Text = ""
            txtNombre.Text = ""
            txtTelefono.Text = ""
            TxtObservaciones.Text = ""
            txtEncargado.Text = ""
            Txtdireccion.Text = ""
            Me.txtCorreoComprobantes.Text = ""
            txtNombre.Enabled = False
        End If
    End Sub

    Private Sub btn_cliente_nuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cliente_nuevo.Click
        Try
            Me.DetenerTiempo()
            Dim frm_cliente As New frm_cliente_rapido
            frm_cliente.Frecuente = Me.ckFrecuente.Checked
            frm_cliente.cedula = txtcodigo.Text
            frm_cliente.nombre = txtNombre.Text
            frm_cliente.tipo = cbo_tipo_cliente.SelectedIndex

            frm_cliente.txtCodigo.Enabled = True
            frm_cliente.txtNombre.Enabled = True
            frm_cliente.cbo_tipo_cliente.Enabled = True

            frm_cliente.ShowDialog()
            If frm_cliente.bandera = True Then
                txtcodigo.Text = frm_cliente.txtCodigo.Text
                If txtcodigo.Text <> "" Then
                    Cargar_Cliente(txtcodigo.Text)
                    CargarInformacionCliente(txtcodigo.Text)
                    existe_cedula(txtcodigo.Text)
                Else
                    txtcodigo.Text = 0
                    Cargar_Cliente(txtcodigo.Text)
                    CargarInformacionCliente(txtcodigo.Text)
                    existe_cedula(txtcodigo.Text)
                End If
            End If
            txtCod_Articulo.SelectAll()
            txtCod_Articulo.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.IniciaTiempo()
    End Sub

    Function buscar_cedula_cliente(ByVal cedula As String)
        'Try
        '    Dim dts As New DataTable
        '    Dim cfunciones As cFunciones
        '    If cbo_tipo_cliente.SelectedIndex = 0 Then
        '        cfunciones.Llenar_Tabla_Generico("select NOMBRECOMPLETO2 from ENTIDADES_FISICAS where cedula2 = " & txt_cedula.Text, dts, GetSetting("seesoft", "seepos", "datos_Cedulas"))
        '        If dts.Rows.Count > 0 Then
        '            txtNombre.Text = dts.Rows(0).Item("NOMBRECOMPLETO2")
        '            txtNombre.Enabled = False
        '            IngresoIdentificacion = True
        '            Return True
        '        Else
        '            MsgBox("La cédula No se encontro o se encuentra en un tipo diferente, compruebe si la cédula es Fisica o Juridica", vbCritical, "Cédula Fisica")
        '            txtNombre.Text = ""
        '            txtTelefono.Text = ""
        '            Txtdireccion.Text = ""
        '            Me.txtCorreoComprobantes.Text = ""
        '            txtEncargado.Text = ""
        '            txtNombre.Text = "INGRESE EL NOMBRE"
        '            nombre_editable()
        '        End If
        '    ElseIf cbo_tipo_cliente.SelectedIndex = 1 Then
        '        cfunciones.Llenar_Tabla_Generico("select NOMBRE from ENTIDADES_JURIDICAS where cedula2 = " & txt_cedula.Text, dts, GetSetting("seesoft", "seepos", "datos_Cedulas"))
        '        If dts.Rows.Count > 0 Then
        '            txtNombre.Text = dts.Rows(0).Item("NOMBRE")
        '            txtNombre.Enabled = False
        '            IngresoIdentificacion = True
        '            Return True
        '        Else
        '            MsgBox("La cédula No se encontro o se encuentra en un tipo diferente, compruebe si la cédula es Fisica o Juridica", vbCritical, "Cédula Juridica")
        '            txtNombre.Text = ""
        '            txtTelefono.Text = ""
        '            Txtdireccion.Text = ""
        '            Me.txtCorreoComprobantes.Text = ""
        '            txtEncargado.Text = ""
        '            nombre_editable()
        '        End If
        '    ElseIf cbo_tipo_cliente.SelectedIndex = 2 Then
        '        Dim servicio As New Wscedulas.Service1
        '        Dim tbl As New DataTable
        '        Dim nombre As String
        '        Dim apellido As String
        '        Dim nombre_completo As String
        '        If My.Computer.Network.IsAvailable = True Then
        '            'tbl = servicio.ObtenerDatosAsync(2, cedula, "", "", "", "", "", "")
        '            If tbl.Rows.Count > 0 Then
        '                nombre = tbl.Rows(0).Item("NOMBRE1")
        '                apellido = tbl.Rows(0).Item("APELLIDO1")
        '                nombre_completo = nombre + apellido
        '                txtNombre.Text = nombre_completo
        '            End If
        '        Else
        '            MsgBox("No hay conexión a Internet")
        '        End If
        '    End If
        '    Return False
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Function

    Private Sub BuscarCliente()
        'creado 10 de sep 2019
        Me.BuscarIdentificacion()

        If txt_cedula.Text = "" Then
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = 0
            txtcodigo.Text = 0
            txt_cedula.Text = 0
        End If

        If existe_cedula(txt_cedula.Text) = False Then
            Me.txtcodigo.Text = txt_cedula.Text
        End If

        If txt_cedula.Text = "0" Then
            txtcodigo.Text = 0
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = 0
        End If

        If txtcodigo.Text = 0 Then
            btn_cliente_nuevo.Enabled = True
            txtNombre.Text = "Cliente de Contado"
            nombre_editable()
        End If

        Me.cliente_normal = True
        If Me.txtcodigo.Text <> "" Then
            Me.Cargar_Cliente(txtcodigo.Text)
        End If
        enter_cod_cliente()
        Me.txtCod_Articulo.SelectAll()
        Application.DoEvents()
        If Me.GroupBox3.Enabled = False Then Me.iniciar_factura()
        Me.txtCod_Articulo.Focus()

        Me.CambiaImpuestos()
    End Sub

    Private Sub txt_cedula_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txt_cedula.KeyDown

        Try
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            End If
        Catch ex As Exception
        End Try

        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Me.DetenerTiempo()
                    borrar()
                    cliente_normal = True
                    Dim cFunciones As New cFunciones
                    nombre_editable()
                    'c = cFunciones.BuscarDatos("select identificacion as id,cedula as identificacion,nombre as Nombre from Clientes where anulado = 0", "Nombre")
                    Dim frmBuscarCliente As New frm_buscar_cliente
                    frmBuscarCliente.txt_nombre.Focus()

                    If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = frmBuscarCliente.id
                        txtcodigo.Text = frmBuscarCliente.id
                        txt_cedula.Text = frmBuscarCliente.cedula
                        btn_cliente_nuevo.Enabled = False
                        Me.cliente_normal = True
                        If Me.txtcodigo.Text <> "" Then
                            Me.Cargar_Cliente(txtcodigo.Text)
                        End If
                        enter_cod_cliente()
                        Me.CambiaImpuestos()
                        Me.txtCod_Articulo.SelectAll()
                        Application.DoEvents()
                        If Me.GroupBox3.Enabled = False Then Me.iniciar_factura()
                        Me.txtCod_Articulo.Focus()
                    End If
                    Me.IniciaTiempo()
                Case Keys.Enter
                    Me.BuscarCliente()

                Case Keys.F2
                    Me.TclCaja = "F2"
                    Me.Registrar(False, 1)

                Case Keys.F3
                    Me.TclCaja = "F3"
                    Me.Registrar(True, 1)

                Case Keys.F4
                    Me.TclCaja = "F4"
                    Me.Registrar(False, 2)

                Case Keys.F5
                    Me.TclCaja = "F5"
                    Me.Registrar(True, 2)

                Case Keys.F6
                    'electronica
                    Me.TclCaja = "F6"
                    Me.Registrar(False, 3)
                Case Keys.F7
                    'tiquete
                    Me.TclCaja = "F7"
                    Me.Registrar(True, 3)

            End Select
        Catch ex As System.Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function nombre_editable()
        Dim dts_config As New DataTable
        Dim cf As New cFunciones
        cf.Llenar_Tabla_Generico("select * from configuraciones", dts_config, CadenaConexionSeePOS)
        If dts_config.Rows(0).Item("editar_nombre") Then
            txtNombre.Enabled = True
            Return True
        Else
            txtNombre.Enabled = False
            Return False
        End If
    End Function

    Function existe_cedula(ByVal cedula As String)
        Try
            Dim dts As New DataTable
            If Me.ckFrecuente.Checked = False Then
                cFunciones.Llenar_Tabla_Generico("select * from clientes where cedula = '" & cedula & "'", dts, CadenaConexionSeePOS)
            Else
                cFunciones.Llenar_Tabla_Generico("select * from Clientes_frecuentes where cedula = '" & cedula & "'", dts, CadenaConexionSeePOS)
            End If

            If dts.Rows.Count > 0 Then
                txtcodigo.Text = dts.Rows(0).Item("identificacion")
                Me.cliente_normal = True
                btn_cliente_nuevo.Enabled = False
                Return True
            End If
            btn_cliente_nuevo.Enabled = True
            Return False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub txt_cedula_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private ListaenPromocion As New List(Of String)

    Private Function NuevoTexto(ByVal _texto As String) As String
        Dim resultado As String
        Dim ciclo As Integer = 20
        resultado = _texto
        For i As Integer = 0 To ciclo
            resultado += " "
        Next

        Return resultado
    End Function
    Private Sub Obtener_Promo()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Descripcion + '  ' + cast(round(((Precio_A - Precio_Promo) / PrecioBase ) * 100,2) as varchar) + '% DESCUENTO'  AS Promocion from Inventario  where Promo_Activa = 1 and Existencia > 0 and GETDATE() between Promo_Inicio and Promo_Finaliza", dt, CadenaConexionSeePOS)
        Dim Texto As String
        For Each r As DataRow In dt.Rows
            Texto = Me.NuevoTexto(r.Item("Promocion"))
            Me.ListaenPromocion.Add(Texto)
        Next

        If Me.ListaenPromocion.Count > 0 Then
            Me.TITULO = Me.ListaenPromocion(0)
            Me.Timer1.Start()
        End If
        dt.Dispose()
    End Sub

    Private ContadorTitulo As Integer = 0
    Private ContadorPromocion As Integer = 0
    Private TITULO As String = ""
    Private ContadorError As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo Contador

        If Me.ContadorError = 5 Then Exit Sub

        Me.lblListaPromocion.Text = Microsoft.VisualBasic.Mid(TITULO, 1, ContadorTitulo)
        ContadorTitulo = ContadorTitulo + 1

        If ContadorTitulo = Microsoft.VisualBasic.Len(TITULO) Then
            ContadorTitulo = 1

            If Me.ContadorPromocion >= Me.ListaenPromocion.Count - 1 Then
                Me.ContadorPromocion = 0
            Else
                Me.ContadorPromocion += 1
            End If

            Me.TITULO = Me.ListaenPromocion(Me.ContadorPromocion)
        End If

        Exit Sub
Contador:
        Me.ContadorError += 1
    End Sub

    Private Sub btnExoneracion_Click(sender As Object, e As EventArgs)
        Dim PorcentajeExoneracion As String = InputBox("Ingrese el porcentaje de exoneracion", "Exonerar linea")
        If IsNumeric(PorcentajeExoneracion) Then

            If PorcentajeExoneracion > 100 Or PorcentajeExoneracion < 0 Then
                MsgBox("Porcentaje Exoneracion invalido", MsgBoxStyle.Exclamation, Text)
                Exit Sub
            End If

            Dim PorcentajeVenta As Decimal = 13 - (13 * (PorcentajeExoneracion / 100))

            Me.txtImpVenta.Text = PorcentajeVenta
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarExoneracion.Click
        If Me.txtImpVenta.Text > 0 Then
            Dim frm As New frmExonerarLineaFactura
            frm.Identificacion = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtImpVenta.Text = frm.txtIV.Text
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("IdTipoExoneracion") = frm.IdTipoExoneracion
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("NumeroDocumento") = frm.NumeroDocumento
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("FechaEmision") = frm.FechaEmision
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("PorcentajeCompra") = frm.PorcentajeCompra
                Me.meter_al_detalle()
            Else
                If Me.txtImpVenta.Text > 0 Then Me.txtImpVenta.Text = 13
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("IdTipoExoneracion") = 1
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("NumeroDocumento") = ""
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("FechaEmision") = Date.Now
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("PorcentajeCompra") = "0"
                Me.meter_al_detalle()
            End If
        End If
    End Sub

    Private Function esEmpresaInterna(_Cod As String) As Boolean
        Dim strSQL As String = "select * from viewEmpresasInternas Where Identificacion = '" & _Cod & "'"
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private IdFacturaRemplaza As Long = 0
    Private Sub btnRemplazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemplazar.Click
        Dim Fx As New cFunciones
        Dim Codigo As String = "0"
        Codigo = (Fx.BuscarFactura("Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC ", "[Nombre del Cliente]", "Fecha", "Buscar Factura de Venta", CadenaConexionSeePOS, True))
        If Codigo <> "" Then
            Me.IdFacturaRemplaza = Codigo.Split(";")(0)
        Else
            Me.IdFacturaRemplaza = 0
        End If
    End Sub

    Dim CodigoCupon As Long = 0
    Private Sub btnApliarCupon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApliarCupon.Click
        Dim PDescuento As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim frm As New frmAplicarCupon
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CodigoCupon = frm.Codigo
            PDescuento = frm.Descuento
            Try
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                For i As Integer = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i

                    If PDescuento > 0 Then
                        SubTotal = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotal")
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descuento") = PDescuento
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Descuento") = SubTotal * (PDescuento / 100)
                    End If

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    Me.Calcular_totales()
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            End Try
        Else
            Me.CodigoCupon = 0
        End If
    End Sub

    Private Function GetDescuentoAutomatico(_Codigo As String) As Decimal
        Dim dt As New DataTable
        Dim CodCliente As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        If Me.ckFrecuente.Checked = False Then
            cFunciones.Llenar_Tabla_Generico("select DescuentoEspecial from Clientes WHERE identificacion = " & CodCliente, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Dim DescuentoEspecial As Decimal = dt.Rows(0).Item("DescuentoEspecial")
                If DescuentoEspecial > 0 Then
                    Return DescuentoEspecial
                End If
            End If
        End If

        If Me.opCredito.Checked = True Then
            Return 0
        Else
            If esEmpresaInterna(CodCliente) = True Then Return 0
            Dim strSQL As String = "select isnull(d.Descuento,0) as Descuento from Inventario i inner join Descuentos d on i.Proveedor = d.IdProveedor Where Codigo = " & _Codigo & " and dbo.DateOnly(GETDATE()) >= dbo.DateOnly(d.Desde) and dbo.DateOnly(GETDATE()) <= dbo.DateOnly(d.Hasta)"
            cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Descuento")
            Else
                Return 0
            End If
        End If
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DetenerTiempo()
        Try
            Dim Id As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
            If Id <> "0" And Id <> "" Then
                Dim frm As New frmCambiarCorreo
                frm.CargarCorreos(Me.txtCorreoComprobantes.Text)
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update Clientes set Correocomprobante = '" & frm.txtCorreos.Text & "' where Identificacion = " & Id, CommandType.Text)
                    Me.txtCorreoComprobantes.Text = Me.CorreoComprobantes(Id)
                End If
            End If
        Catch ex As Exception
        End Try
        Me.IniciaTiempo()
    End Sub

    Private Function AplicaCambioTemperatura() As Boolean
        Dim resultado As Boolean = False
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select AplicaTemperatura from Configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            resultado = dt.Rows(0).Item("AplicaTemperatura")
        End If
        Return resultado
    End Function

    Private Sub IngresoTemperatura()

        If Me.AplicaCambioTemperatura = False Then
            Exit Sub
        End If

        Dim dt As New DataTable
        Dim strSQL As String = ""
        Dim dia As Date = Date.Now
        Dim Horario As String = ""

        If dia.ToString("tt").Replace(".", "").ToLower = "am" Then
            Horario = "AM"    'es de mañana
        Else
            Horario = "PM" 'es de tarde
        End If

        strSQL = "Select * from TemperaturaCamara Where dbo.dateonly(fecha) = dbo.dateonly(getdate()) and horario = '" & Horario & "'"
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then

        Else
            If MsgBox("Aun no se a registrado la temperatura de la camara, Desea Registrarla", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Text) = MsgBoxResult.Yes Then
                Dim frm As New frmIngresoTemperaturaRapido
                frm.Id_Usuario = Cedula_usuario
                frm.txtNombreUsuario.Text = txtNombreUsuario.Text
                frm.txtHorario.Text = Horario
                frm.txtFecha.Text = Date.Now.ToShortDateString
                frm.txtTemperatura.Focus()
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Function GetCasa(_Cod As String) As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Proveedor, Precio_A from Inventario where codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Proveedor")
        End If
        Return 0
    End Function

    Private Function GetPrecio_Unit(_Cod As String) As Decimal
        'zoe
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Proveedor, Precio_A, Promo_Activa, Promo_Finaliza, Precio_Promo from Inventario where codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If CBool(dt.Rows(0).Item("Promo_Activa")) = True Then
                Return CDec(dt.Rows(0).Item("Precio_Promo"))
            Else
                Return CDec(dt.Rows(0).Item("Precio_A"))
            End If
        End If

        Return 0
    End Function

    Private Sub CambiarPrecios_PrecioDiferenciado()
        Dim IdAgente As String = Me.txtagente.Text
        Dim Cod As String
        Dim Casa As String = "0"
        Dim Tipo As String
        Dim Pocentaje As String
        Dim Precio, Cantidad, PImpuesto, PDescuento As Decimal
        Dim dtPD As New DataTable

        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()

        If Me.ckPD.Checked = True Then
            'Cambia el precio de venta segun el pd            
            For i As Integer = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
                Cod = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo")
                Casa = Me.GetCasa(Cod)
                cFunciones.Llenar_Tabla_Generico("select * from PrecioDiferenciado where IdAgente = " & IdAgente & " and CodProveedor = " & Casa, dtPD, CadenaConexionSeePOS)
                If dtPD.Rows.Count > 0 Then
                    'hay que aplicar el nuevo precio
                    Tipo = dtPD.Rows(0).Item("Tipo")
                    Pocentaje = dtPD.Rows(0).Item("Porcentaje")
                    Precio = Me.GetPrecio_Unit(Cod)
                    Cantidad = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cantidad")
                    PImpuesto = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Impuesto")
                    PDescuento = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descuento")

                    If Tipo.ToLower = "aumento" Then
                        Precio = Precio * (1 + (Pocentaje / 100))
                    End If

                    If Tipo.ToLower = "descuento" Then
                        Precio -= Precio * (Pocentaje / 100)
                    End If

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit") = Precio

                    If PImpuesto > 0 Then
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubtotalGravado") = Precio * Cantidad
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Impuesto") = (Precio * Cantidad) * (PImpuesto / 100)
                    Else
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotalExcento") = Precio * Cantidad
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Impuesto") = 0
                    End If

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotal") = Precio * Cantidad

                    If PDescuento > 0 Then
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Descuento") = (Precio * Cantidad) * (PDescuento / 100)
                    End If

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    Me.Calcular_totales()
                Else
                    'mantiene el precio
                End If
            Next
        Else
            'Restablece el precio de venta a la normalidad
            For i As Integer = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i

                Cod = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo")
                Casa = Me.GetCasa(Cod)
                cFunciones.Llenar_Tabla_Generico("select * from PrecioDiferenciado where IdAgente = " & IdAgente & " and CodProveedor = " & Casa, dtPD, CadenaConexionSeePOS)
                If dtPD.Rows.Count > 0 Then
                    'hay que corregir el precio
                    Tipo = dtPD.Rows(0).Item("Tipo")
                    Pocentaje = dtPD.Rows(0).Item("Porcentaje")
                    Precio = Me.GetPrecio_Unit(Cod)
                    Cantidad = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Cantidad")
                    PImpuesto = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Impuesto")
                    PDescuento = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Descuento")

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Precio_Unit") = Precio

                    If PImpuesto > 0 Then
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubtotalGravado") = Precio * Cantidad
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Impuesto") = (Precio * Cantidad) * (PImpuesto / 100)
                    Else
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotalExcento") = Precio * Cantidad
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Impuesto") = 0
                    End If

                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("SubTotal") = Precio * Cantidad

                    If PDescuento > 0 Then
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Monto_Descuento") = (Precio * Cantidad) * (PDescuento / 100)
                    End If
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    Me.Calcular_totales()
                Else
                    'mantiene el precio
                End If

            Next
        End If
    End Sub

    Private Sub ckPD_CheckedChanged(sender As Object, e As EventArgs) Handles ckPD.CheckedChanged
        Me.CambiarPrecios_PrecioDiferenciado()
    End Sub

    Private Sub BuscarIdentificacion()
        Try
            If Me.txt_cedula.Text.Length >= 9 And Me.txt_cedula.Text.Length <= 12 Then
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(Me.txt_cedula.Text)
                Me.BanderaPuedeCambiarTipoCliente = True
                Select Case ObtenerDatosCliente.tipoIdentificacion
                    Case "01" : Me.cbo_tipo_cliente.SelectedIndex = 0
                    Case "02" : Me.cbo_tipo_cliente.SelectedIndex = 1
                    Case "03" : Me.cbo_tipo_cliente.SelectedIndex = 2
                End Select
                Me.BanderaPuedeCambiarTipoCliente = False
                Me.txtNombre.Text = ObtenerDatosCliente.nombre

                IngresoIdentificacion = True
            Else
                Me.cbo_tipo_cliente.SelectedIndex = 0
                Me.txtNombre.Text = ""
                IngresoIdentificacion = False
            End If
        Catch ex As Exception
            Me.cbo_tipo_cliente.SelectedIndex = 0
            Me.txtNombre.Text = ""
            IngresoIdentificacion = False
        End Try
    End Sub

    Dim EstadoPreventa As String = "PreVenta"
    Private Sub btnBuscarFicha_Click(sender As Object, e As EventArgs) Handles btnBuscarFicha.Click
        Try
            If Me.txtFicha.Text <> "" And IsNumeric(Me.txtFicha.Text) Then
                If CDec(Me.txtFicha.Text) > 0 Then
                    If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count > 0 Then
                        If (MsgBox("Actualmente se está realizando una venta, si continúa se perderan los datos de la venta actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    End If

                    Me.Modo = "PreVentas"
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(0).Enabled = True

                    Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                    Me.DataSet_Facturaciones.Ventas.Clear()

                    Me.DataSet_Facturaciones.Cotizacion_Detalle.Clear()
                    Me.DataSet_Facturaciones.Cotizacion.Clear()
                    LAnulada.Visible = False
                    txtHecho.Text = ""
                    Dim identificador As Double

                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico("select * from PreVentas where Ficha = " & Me.txtFicha.Text & " and Estado = 'Preventa'", dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        identificador = dt.Rows(0).Item("Id")
                        Me.EstadoPreventa = dt.Rows(0).Item("Estado")
                    Else
                        identificador = 0.0
                        Me.EstadoPreventa = "PreVenta"
                    End If

                    buscando = True
                    If identificador = 0.0 Then ' si se dio en el boton de cancelar
                        Me.buscando = False
                        Me.reimprimir = False
                        Exit Sub
                    End If

                    Me.LlenarVentas(identificador)

                    If Me.AplicaCambioenCaja = True Then
                        Me.ToolBar1.Buttons(2).Enabled = True
                        Me.GroupBox6.Enabled = True
                        Me.GroupBox3.Enabled = True
                        Ck_Exonerar.Enabled = True
                        Me.txtorden.Enabled = True
                    Else
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.GroupBox6.Enabled = False
                        Me.GroupBox3.Enabled = False
                        Ck_Exonerar.Enabled = False
                        Me.txtorden.Enabled = True
                    End If

                    If usua.Anu_Venta = True And Me.CheckBox1.Checked = False Then
                        Me.ToolBar1.Buttons(3).Enabled = True
                    Else
                        Me.ToolBarDesanular.Visible = True
                    End If

                    If Me.CheckBox1.Checked Then
                        LAnulada.Visible = True
                    Else
                        LAnulada.Visible = False
                    End If

                    Dim i As Integer

                    For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones.Ventas_Detalle).Count - 1 ' busca si en el detalle de la factura existen devolucines
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
                        If (Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Devoluciones")) <> 0 Then
                            MsgBox("Esta Factura no puede ser anulada, porque tiene devoluciones", MsgBoxStyle.Information)
                            Me.ToolBar1.Buttons(3).Enabled = False
                            Exit For
                        End If
                    Next
                    HechoPor()
                    Me.ToolBar1.Buttons(6).Enabled = True
                    Me.ToolBar1.Buttons(4).Enabled = True
                    Me.opContado.Enabled = False
                    Me.opCredito.Enabled = False
                    Me.opApartado.Enabled = False
                    Me.txtorden.Enabled = True
                    Me.SimpleButton1.Enabled = False
                    Me.SimpleButton2.Enabled = False
                    _verificar_fact_canc(identificador)
                    Me.reimprimir = True

                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                    BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                    txtCod_Articulo.Focus()

                    Exit Sub
                End If
            End If
            MsgBox("Ficha invalida, debe ser un valor numerico y mayor a cero", MsgBoxStyle.Exclamation, Me.Text)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ckFrecuente_CheckedChanged(sender As Object, e As EventArgs) Handles ckFrecuente.CheckedChanged
        If Me.ckFrecuente.Checked = False Then
            Me.opApartado.Checked = False
        Else
            Me.opCredito.Checked = False
            Me.opCredito.Enabled = False
        End If
        Me.opApartado.Enabled = Me.ckFrecuente.Checked
        If Me.txt_cedula.Text <> "" Then Me.BuscarCliente()
    End Sub

    Private Sub btnCartaExoneracion_Click(sender As Object, e As EventArgs) Handles btnCartaExoneracion.Click
        Me.DetenerTiempo()
        Dim frm As New frmCartaExoneracionSoloLectura
        frm.Identificacion = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        frm.ShowDialog()
        Me.IniciaTiempo()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If IsNumeric(Me.txtTotal.Text) And Me.txtNombreUsuario.Text <> "" Then
            If CDec(Me.txtTotal.Text) = 0 Then
                If IsClinica() = False Then
                    Me.NuevaEntrada()
                    Me.DetenerTiempo()
                Else
                    'para clinica no hay tiempo limite.
                End If
            End If
        End If
    End Sub

    Private Function NoDebeUsarMag(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from NoMAG where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ProductoAgricola(_Codigo As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select MAG from Inventario where codigo = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return CBool(dt.Rows(0).Item("MAG"))
        Else
            Return False
        End If
    End Function

    Private Function ImpuestoArticulo(_Codigo As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select IVenta from Inventario where codigo = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return CDec(dt.Rows(0).Item("IVenta"))
        Else
            Return False
        End If
    End Function

    Private Sub CambiaImpuestos()
        Dim Codigo As String = "0"
        Dim IVAArticulo As Decimal = 0
        Dim esAgricola As Boolean = False
        Dim MAG As Boolean = False
        Dim Cod_Cliente As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        Dim IdTipoExoneracion, NumeroDocumento As String
        Dim PorcentajeCompra As Decimal
        Dim FechaEmision As DateTime

        MAG = Me.EstaRegistrado(Cod_Cliente)

        Dim dtExoneracion As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewCartaExoneracion where identificacion = '" & Cod_Cliente & "'", dtExoneracion, CadenaConexionSeePOS)
        If dtExoneracion.Rows.Count > 0 Then
            '*****************************************************************************************************
            'En el caso de guanavet, lo mejor es que el usuario marque que productos se deben exonerar y cuales no
            'a futuro lo mejor seria ligarlo con el cabys pero el problema es que el cabys siempre esta perdido
            '*****************************************************************************************************
            Me.Ck_Exonerar.Checked = True
            'IdTipoExoneracion = dtExoneracion.Rows(0).Item("Id")
            'NumeroDocumento = dtExoneracion.Rows(0).Item("NumeroDocumento")
            'PorcentajeCompra = dtExoneracion.Rows(0).Item("PorcentajeCompra")
            'FechaEmision = dtExoneracion.Rows(0).Item("FechaEmision")
            '*****************************************************************************************************
        Else
            Me.Ck_Exonerar.Checked = False
        End If

        For i As Integer = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
            With Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle")
                .Position = i
                Codigo = .Current("Codigo")
                IVAArticulo = Me.ImpuestoArticulo(Codigo)

                .Current("IdTipoExoneracion") = 1
                .Current("NumeroDocumento") = ""
                .Current("PorcentajeCompra") = 0
                .Current("FechaEmision") = Date.Now

                If Ck_Exonerar.Checked = True Then
                    'el cliente tiene exoneracion por carta

                    '*****************************************************************************************************
                    'En el caso de guanavet, lo mejor es que el usuario marque que productos se deben exonerar y cuales no
                    'a futuro lo mejor seria ligarlo con el cabys pero el problema es que el cabys siempre esta perdido
                    '*****************************************************************************************************
                    '.Current("IdTipoExoneracion") = IdTipoExoneracion
                    '.Current("NumeroDocumento") = NumeroDocumento
                    '.Current("PorcentajeCompra") = PorcentajeCompra
                    '.Current("FechaEmision") = FechaEmision
                    '.Current("Impuesto") = IIf(IVAArticulo >= PorcentajeCompra, IVAArticulo - PorcentajeCompra, 0)
                Else
                    esAgricola = Me.ProductoAgricola(Codigo)
                    If esAgricola = True And MAG = True Then
                        'aplica tarifa reducida al 1% del IVA
                        .Current("Impuesto") = 1
                    Else
                        'aplica tarifa normal 
                        .Current("Impuesto") = IVAArticulo
                    End If
                End If
                .Current("Monto_Impuesto") = (.Current("SubtotalGravado") - .Current("Monto_Descuento")) * (.Current("Impuesto") / 100)
                .EndCurrentEdit()
            End With
        Next
        Me.Calcular_totales()
    End Sub

    Private Sub btnMAG_Click(sender As Object, e As EventArgs) Handles btnMAG.Click
        Dim Identificador As String = Me.txtcodigo.Text
        If Identificador <> "0" Then

            If Me.NoDebeUsarMag(Identificador) = True Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update Clientes set MAG = 0 where Identificacion = " & Identificador, CommandType.Text)
                Me.Ck_Exonerar.Checked = True
                MsgBox("Este cliente no usa esta opcion." & vbNewLine _
                       & "Debe usar una carta para exonerarlo", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                Exit Sub
            End If

            Me.DetenerTiempo()
            Dim frm As New frmValidarRegistroMAG
            frm.Identificacion = Me.txt_cedula.Text
            frm.ShowDialog()
            If frm.ckMAG.Checked = True Or frm.ckVenta1.Checked = True Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update Clientes set MAG = 1 where Identificacion = " & Identificador, CommandType.Text)
                Me.BuscarCliente()
            End If
            Me.CambiaImpuestos()
        End If
        Me.IniciaTiempo()
    End Sub

    Private Sub DetenerTiempo()
        If IsClinica() = False Then
            Me.Timer2.Stop()
        End If
    End Sub

    Private Sub IniciaTiempo()
        If IsClinica() = False Then
            Me.Timer2.Stop()
            Me.Timer2.Start()
        End If
    End Sub

End Class


Public Class PedidoEditado
    Public Property Codigo As String
    Public Property Cantidad As Decimal
    Public Property PrecioUnid As Decimal

    Sub New(_codigo As String, _cantidad As Decimal, _preciounid As Decimal)
        Me.Codigo = _codigo
        Me.Cantidad = _cantidad
        Me.PrecioUnid = _preciounid
    End Sub

End Class