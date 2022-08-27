Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class ModificaFacturacion
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim Cant, PaginaActual As Integer
    Dim Cedula_usuario As String
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

    'SELECCION DEL TIPO DE FACTURA.
    'Dim Factura_reporte As New Factura_Personalizada  'FACTURA PERSONALIZADA
    'Dim Factura_Generica As New Factura_Generica
    Dim facturaPVE As New Reporte_FacturaPVEs
    Dim Factura As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim PMU As New PerfilModulo_Class 'clase de seguridad 

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
    Friend WithEvents txtNombreArt As System.Windows.Forms.TextBox
    Friend WithEvents txtCodArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
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
    Friend WithEvents txtCodigo As ValidText.ValidText
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents DataSet_Facturaciones As DataSet_Facturaciones
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents LabelObs As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ck_Exonerar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents txtCod_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ck_Taller As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbNumero As System.Windows.Forms.ComboBox
    Friend WithEvents LFVencimiento As System.Windows.Forms.Label
    Friend WithEvents LNumero As System.Windows.Forms.Label
    Friend WithEvents LVencimiento As System.Windows.Forms.Label
    Friend WithEvents LOpcion As System.Windows.Forms.Label
    Friend WithEvents AdapterLotes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LAnulada As System.Windows.Forms.Label
    Friend WithEvents txtHecho As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Configuraciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Ck_Mascotas As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ModificaFacturacion))
        Me.txtCostoBase = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtFactura = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtTipo = New System.Windows.Forms.TextBox
        Me.txtMontoImpuesto = New System.Windows.Forms.TextBox
        Me.txtSGravado = New System.Windows.Forms.TextBox
        Me.txtSubFamilia = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CbNumero = New System.Windows.Forms.ComboBox
        Me.LFVencimiento = New System.Windows.Forms.Label
        Me.LNumero = New System.Windows.Forms.Label
        Me.LVencimiento = New System.Windows.Forms.Label
        Me.LOpcion = New System.Windows.Forms.Label
        Me.txtCod_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.DataSet_Facturaciones = New LcPymes_5._2.DataSet_Facturaciones
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNombreArt = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.TxtUtilidad = New DevExpress.XtraEditors.TextEdit
        Me.Label_Costobase = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtSubtotal = New DevExpress.XtraEditors.TextEdit
        Me.txtImpVenta = New DevExpress.XtraEditors.TextEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtPrecioUnit = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCodArticulo = New DevExpress.XtraEditors.TextEdit
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSExcento = New System.Windows.Forms.TextBox
        Me.txtOtros = New System.Windows.Forms.TextBox
        Me.txtFlete = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Ck_Exonerar = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label46 = New DevExpress.XtraEditors.TextEdit
        Me.Label47 = New System.Windows.Forms.Label
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.Label43 = New System.Windows.Forms.Label
        Me.Lb_Subgravado = New DevExpress.XtraEditors.TextEdit
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Lb_SubExento = New DevExpress.XtraEditors.TextEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtImpVentaT = New DevExpress.XtraEditors.TextEdit
        Me.txtDescuentoT = New DevExpress.XtraEditors.TextEdit
        Me.txtSubtotalT = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtSubtotalExcento = New System.Windows.Forms.TextBox
        Me.txtDiasPlazo = New System.Windows.Forms.Label
        Me.opCredito = New System.Windows.Forms.RadioButton
        Me.opContado = New System.Windows.Forms.RadioButton
        Me.CkEntregado = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtEncargado = New System.Windows.Forms.TextBox
        Me.Txtdireccion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.LabelObs = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtTelefono = New ValidText.ValidText
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigo = New ValidText.ValidText
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.TxtMaxdescuento = New System.Windows.Forms.TextBox
        Me.TxtprecioCosto = New System.Windows.Forms.TextBox
        Me.txtmontodescuento = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.ToolBarAnular = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImportar = New System.Windows.Forms.ToolBarButton
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtTipoCambio = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Ck_Mascotas = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtorden = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Ck_Taller = New DevExpress.XtraEditors.CheckEdit
        Me.DtVence = New System.Windows.Forms.Label
        Me.dtFecha = New System.Windows.Forms.Label
        Me.Adapter_Clientes = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSubTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Encargados_Compra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Txtcodmoneda_Venta = New System.Windows.Forms.TextBox
        Me.Txt_TipoCambio_Valor_Compra = New System.Windows.Forms.TextBox
        Me.Adapter_Ventas_Detalles = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Ventas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Coti = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_CotiDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Label48 = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.AdapterLotes = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.LAnulada = New System.Windows.Forms.Label
        Me.txtHecho = New System.Windows.Forms.TextBox
        Me.Adapter_Configuraciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtCod_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Facturaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Ck_Exonerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ck_Mascotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_Taller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtCostoBase.Location = New System.Drawing.Point(128, 16)
        Me.txtCostoBase.Name = "txtCostoBase"
        Me.txtCostoBase.Size = New System.Drawing.Size(32, 15)
        Me.txtCostoBase.TabIndex = 168
        Me.txtCostoBase.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtFactura)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtTipo)
        Me.Panel2.Location = New System.Drawing.Point(-1, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 16)
        Me.Panel2.TabIndex = 182
        '
        'txtFactura
        '
        Me.txtFactura.BackColor = System.Drawing.Color.White
        Me.txtFactura.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.ForeColor = System.Drawing.Color.Red
        Me.txtFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFactura.Location = New System.Drawing.Point(64, 1)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(64, 12)
        Me.txtFactura.TabIndex = 64
        Me.txtFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 12)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Factura N°"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtTipo
        '
        Me.TxtTipo.BackColor = System.Drawing.Color.White
        Me.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipo.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipo.ForeColor = System.Drawing.Color.Red
        Me.TxtTipo.Location = New System.Drawing.Point(141, 1)
        Me.TxtTipo.MaxLength = 25
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(32, 13)
        Me.TxtTipo.TabIndex = 193
        Me.TxtTipo.Text = ""
        '
        'txtMontoImpuesto
        '
        Me.txtMontoImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoImpuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtMontoImpuesto.Location = New System.Drawing.Point(416, 272)
        Me.txtMontoImpuesto.Name = "txtMontoImpuesto"
        Me.txtMontoImpuesto.Size = New System.Drawing.Size(24, 13)
        Me.txtMontoImpuesto.TabIndex = 165
        Me.txtMontoImpuesto.Text = ""
        '
        'txtSGravado
        '
        Me.txtSGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSGravado.ForeColor = System.Drawing.Color.Blue
        Me.txtSGravado.Location = New System.Drawing.Point(224, 272)
        Me.txtSGravado.Name = "txtSGravado"
        Me.txtSGravado.Size = New System.Drawing.Size(40, 13)
        Me.txtSGravado.TabIndex = 166
        Me.txtSGravado.Text = ""
        '
        'txtSubFamilia
        '
        Me.txtSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtSubFamilia.Location = New System.Drawing.Point(448, 272)
        Me.txtSubFamilia.Name = "txtSubFamilia"
        Me.txtSubFamilia.Size = New System.Drawing.Size(24, 13)
        Me.txtSubFamilia.TabIndex = 167
        Me.txtSubFamilia.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.CbNumero)
        Me.GroupBox3.Controls.Add(Me.LFVencimiento)
        Me.GroupBox3.Controls.Add(Me.LNumero)
        Me.GroupBox3.Controls.Add(Me.LVencimiento)
        Me.GroupBox3.Controls.Add(Me.LOpcion)
        Me.GroupBox3.Controls.Add(Me.txtCod_Articulo)
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
        Me.GroupBox3.Controls.Add(Me.txtCodArticulo)
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(6, 136)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 80)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Artículos a Cotizar"
        '
        'CbNumero
        '
        Me.CbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNumero.Enabled = False
        Me.CbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNumero.ForeColor = System.Drawing.Color.Blue
        Me.CbNumero.ItemHeight = 13
        Me.CbNumero.Location = New System.Drawing.Point(168, 56)
        Me.CbNumero.Name = "CbNumero"
        Me.CbNumero.Size = New System.Drawing.Size(160, 21)
        Me.CbNumero.TabIndex = 205
        Me.CbNumero.Visible = False
        '
        'LFVencimiento
        '
        Me.LFVencimiento.BackColor = System.Drawing.SystemColors.Control
        Me.LFVencimiento.Enabled = False
        Me.LFVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFVencimiento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LFVencimiento.Location = New System.Drawing.Point(440, 56)
        Me.LFVencimiento.Name = "LFVencimiento"
        Me.LFVencimiento.Size = New System.Drawing.Size(96, 16)
        Me.LFVencimiento.TabIndex = 204
        Me.LFVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LNumero
        '
        Me.LNumero.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumero.ForeColor = System.Drawing.Color.White
        Me.LNumero.Location = New System.Drawing.Point(88, 56)
        Me.LNumero.Name = "LNumero"
        Me.LNumero.Size = New System.Drawing.Size(76, 12)
        Me.LNumero.TabIndex = 203
        Me.LNumero.Text = "Número"
        Me.LNumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LNumero.Visible = False
        '
        'LVencimiento
        '
        Me.LVencimiento.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVencimiento.ForeColor = System.Drawing.Color.White
        Me.LVencimiento.Location = New System.Drawing.Point(344, 56)
        Me.LVencimiento.Name = "LVencimiento"
        Me.LVencimiento.Size = New System.Drawing.Size(84, 12)
        Me.LVencimiento.TabIndex = 202
        Me.LVencimiento.Text = "Vencimiento"
        Me.LVencimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LVencimiento.Visible = False
        '
        'LOpcion
        '
        Me.LOpcion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOpcion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LOpcion.Location = New System.Drawing.Point(8, 56)
        Me.LOpcion.Name = "LOpcion"
        Me.LOpcion.Size = New System.Drawing.Size(76, 13)
        Me.LOpcion.TabIndex = 201
        Me.LOpcion.Text = "Opcion"
        Me.LOpcion.Visible = False
        '
        'txtCod_Articulo
        '
        Me.txtCod_Articulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCod_Articulo.EditValue = ""
        Me.txtCod_Articulo.Location = New System.Drawing.Point(8, 32)
        Me.txtCod_Articulo.Name = "txtCod_Articulo"
        '
        'txtCod_Articulo.Properties
        '
        Me.txtCod_Articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCod_Articulo.Properties.MaxLength = 19
        Me.txtCod_Articulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCod_Articulo.Size = New System.Drawing.Size(88, 19)
        Me.txtCod_Articulo.TabIndex = 196
        '
        'txtExistencia
        '
        Me.txtExistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExistencia.EditValue = 0
        Me.txtExistencia.Location = New System.Drawing.Point(488, 32)
        Me.txtExistencia.Name = "txtExistencia"
        '
        'txtExistencia.Properties
        '
        Me.txtExistencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtExistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtExistencia.Size = New System.Drawing.Size(40, 17)
        Me.txtExistencia.TabIndex = 195
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(480, 16)
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
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Moneda.Simbolo"))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(328, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 14)
        Me.Label31.TabIndex = 23
        Me.Label31.Text = "M"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataSet_Facturaciones
        '
        Me.DataSet_Facturaciones.DataSetName = "DataSet_Facturaciones"
        Me.DataSet_Facturaciones.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(152, 18)
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
        Me.txtNombreArt.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNombreArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreArt.Font = New System.Drawing.Font("OCR A Extended", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArt.ForeColor = System.Drawing.Color.White
        Me.txtNombreArt.Location = New System.Drawing.Point(120, 0)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(600, 14)
        Me.txtNombreArt.TabIndex = 3
        Me.txtNombreArt.Text = ""
        '
        'Label50
        '
        Me.Label50.AccessibleDescription = ""
        Me.Label50.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label50.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label50.Location = New System.Drawing.Point(176, 18)
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
        Me.TxtUtilidad.Location = New System.Drawing.Point(176, 32)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        '
        'TxtUtilidad.Properties
        '
        Me.TxtUtilidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUtilidad.Properties.DisplayFormat.FormatString = "#,#0.00%"
        Me.TxtUtilidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad.Size = New System.Drawing.Size(72, 17)
        Me.TxtUtilidad.TabIndex = 192
        Me.TxtUtilidad.ToolTip = "Porcentaje de Utilidad."
        Me.TxtUtilidad.Visible = False
        '
        'Label_Costobase
        '
        Me.Label_Costobase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Costobase.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Costobase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Costobase.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_Costobase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Costobase.Location = New System.Drawing.Point(104, 32)
        Me.Label_Costobase.Name = "Label_Costobase"
        Me.Label_Costobase.Size = New System.Drawing.Size(64, 17)
        Me.Label_Costobase.TabIndex = 169
        Me.Label_Costobase.Text = "0"
        Me.Label_Costobase.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(104, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 14)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "P. Base:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Yellow
        Me.Label28.Location = New System.Drawing.Point(8, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 14)
        Me.Label28.TabIndex = 156
        Me.Label28.Text = "Artículo a Facturar"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.EditValue = "0.00"
        Me.txtSubtotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotal.Location = New System.Drawing.Point(599, 32)
        Me.txtSubtotal.Name = "txtSubtotal"
        '
        'txtSubtotal.Properties
        '
        Me.txtSubtotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotal.Properties.Enabled = False
        Me.txtSubtotal.Properties.ReadOnly = True
        Me.txtSubtotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtSubtotal.Size = New System.Drawing.Size(120, 17)
        Me.txtSubtotal.TabIndex = 155
        '
        'txtImpVenta
        '
        Me.txtImpVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImpVenta.EditValue = "0"
        Me.txtImpVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVenta.Location = New System.Drawing.Point(352, 32)
        Me.txtImpVenta.Name = "txtImpVenta"
        '
        'txtImpVenta.Properties
        '
        Me.txtImpVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVenta.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVenta.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtImpVenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVenta.Properties.Enabled = False
        Me.txtImpVenta.Properties.ReadOnly = True
        Me.txtImpVenta.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.txtImpVenta.Size = New System.Drawing.Size(49, 17)
        Me.txtImpVenta.TabIndex = 154
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(705, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 14)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "M"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(599, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 14)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "SubTotal"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(344, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "I.V. (%)"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(416, 18)
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
        Me.txtPrecioUnit.Location = New System.Drawing.Point(256, 32)
        Me.txtPrecioUnit.Name = "txtPrecioUnit"
        '
        'txtPrecioUnit.Properties
        '
        Me.txtPrecioUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.MaxLength = 25
        Me.txtPrecioUnit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtPrecioUnit.Size = New System.Drawing.Size(80, 17)
        Me.txtPrecioUnit.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(256, 18)
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
        Me.txtCantidad.Location = New System.Drawing.Point(532, 32)
        Me.txtCantidad.Name = "txtCantidad"
        '
        'txtCantidad.Properties
        '
        Me.txtCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCantidad.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCantidad.Size = New System.Drawing.Size(56, 17)
        Me.txtCantidad.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(532, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 14)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Cantidad"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodArticulo.EditValue = ""
        Me.txtCodArticulo.Location = New System.Drawing.Point(-96, 32)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        '
        'txtCodArticulo.Properties
        '
        Me.txtCodArticulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCodArticulo.Properties.MaxLength = 19
        Me.txtCodArticulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCodArticulo.Size = New System.Drawing.Size(96, 19)
        Me.txtCodArticulo.TabIndex = 5
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.EditValue = "0"
        Me.txtDescuento.Location = New System.Drawing.Point(416, 32)
        Me.txtDescuento.Name = "txtDescuento"
        '
        'txtDescuento.Properties
        '
        Me.txtDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDescuento.Size = New System.Drawing.Size(64, 17)
        Me.txtDescuento.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Código"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSExcento
        '
        Me.txtSExcento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSExcento.ForeColor = System.Drawing.Color.Blue
        Me.txtSExcento.Location = New System.Drawing.Point(208, 16)
        Me.txtSExcento.Name = "txtSExcento"
        Me.txtSExcento.Size = New System.Drawing.Size(48, 15)
        Me.txtSExcento.TabIndex = 17
        Me.txtSExcento.Text = ""
        '
        'txtOtros
        '
        Me.txtOtros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtros.ForeColor = System.Drawing.Color.Blue
        Me.txtOtros.Location = New System.Drawing.Point(384, 272)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(24, 13)
        Me.txtOtros.TabIndex = 170
        Me.txtOtros.Text = ""
        '
        'txtFlete
        '
        Me.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFlete.ForeColor = System.Drawing.Color.Blue
        Me.txtFlete.Location = New System.Drawing.Point(272, 272)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(32, 13)
        Me.txtFlete.TabIndex = 169
        Me.txtFlete.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.txtImpVentaT)
        Me.GroupBox4.Controls.Add(Me.txtDescuentoT)
        Me.GroupBox4.Controls.Add(Me.txtSubtotalT)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtSubtotalExcento)
        Me.GroupBox4.Controls.Add(Me.txtCostoBase)
        Me.GroupBox4.Controls.Add(Me.txtSExcento)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 54)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Ck_Exonerar
        '
        Me.Ck_Exonerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Exonerar.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Exonerar"))
        Me.Ck_Exonerar.EditValue = False
        Me.Ck_Exonerar.Location = New System.Drawing.Point(440, 0)
        Me.Ck_Exonerar.Name = "Ck_Exonerar"
        '
        'Ck_Exonerar.Properties
        '
        Me.Ck_Exonerar.Properties.Caption = "Exonerar"
        Me.Ck_Exonerar.Properties.Enabled = False
        Me.Ck_Exonerar.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.RoyalBlue, System.Drawing.Color.White)
        Me.Ck_Exonerar.Size = New System.Drawing.Size(72, 17)
        Me.Ck_Exonerar.TabIndex = 192
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(541, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(19, 18)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton1.TabIndex = 191
        Me.SimpleButton1.Text = "T"
        '
        'Label44
        '
        Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label44.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label44.Location = New System.Drawing.Point(516, 33)
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
        Me.Label46.Location = New System.Drawing.Point(532, 33)
        Me.Label46.Name = "Label46"
        '
        'Label46.Properties
        '
        Me.Label46.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Label46.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Label46.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label46.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Label46.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label46.Properties.ReadOnly = True
        Me.Label46.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label46.Size = New System.Drawing.Size(80, 17)
        Me.Label46.TabIndex = 189
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label47.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label47.Location = New System.Drawing.Point(516, 17)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 15)
        Me.Label47.TabIndex = 188
        Me.Label47.Text = "Transporte"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Enabled = False
        Me.SimpleButton2.Location = New System.Drawing.Point(318, 16)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(19, 18)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
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
        Me.Label43.Location = New System.Drawing.Point(8, 32)
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
        Me.Lb_Subgravado.Location = New System.Drawing.Point(24, 32)
        Me.Lb_Subgravado.Name = "Lb_Subgravado"
        '
        'Lb_Subgravado.Properties
        '
        Me.Lb_Subgravado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.ReadOnly = True
        Me.Lb_Subgravado.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Lb_Subgravado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_Subgravado.Size = New System.Drawing.Size(80, 17)
        Me.Lb_Subgravado.TabIndex = 38
        '
        'Label45
        '
        Me.Label45.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(8, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 18)
        Me.Label45.TabIndex = 37
        Me.Label45.Text = "Sub. Gravado"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(106, 32)
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
        Me.Lb_SubExento.Location = New System.Drawing.Point(122, 32)
        Me.Lb_SubExento.Name = "Lb_SubExento"
        '
        'Lb_SubExento.Properties
        '
        Me.Lb_SubExento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Lb_SubExento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.ReadOnly = True
        Me.Lb_SubExento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Lb_SubExento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_SubExento.Size = New System.Drawing.Size(80, 17)
        Me.Lb_SubExento.TabIndex = 35
        '
        'Label42
        '
        Me.Label42.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label42.Location = New System.Drawing.Point(106, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 15)
        Me.Label42.TabIndex = 34
        Me.Label42.Text = "Sub. Exento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(616, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 15)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Total"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(712, 16)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Totales de Facturación"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(616, 33)
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
        Me.Label34.Location = New System.Drawing.Point(413, 33)
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
        Me.Label33.Location = New System.Drawing.Point(309, 33)
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
        Me.Label4.Location = New System.Drawing.Point(208, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.EditValue = "0.00"
        Me.txtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotal.Location = New System.Drawing.Point(632, 33)
        Me.txtTotal.Name = "txtTotal"
        '
        'txtTotal.Properties
        '
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(80, 17)
        Me.txtTotal.TabIndex = 29
        '
        'txtImpVentaT
        '
        Me.txtImpVentaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImpVentaT.EditValue = "0.00"
        Me.txtImpVentaT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVentaT.Location = New System.Drawing.Point(429, 33)
        Me.txtImpVentaT.Name = "txtImpVentaT"
        '
        'txtImpVentaT.Properties
        '
        Me.txtImpVentaT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVentaT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.ReadOnly = True
        Me.txtImpVentaT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtImpVentaT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVentaT.Size = New System.Drawing.Size(80, 17)
        Me.txtImpVentaT.TabIndex = 28
        '
        'txtDescuentoT
        '
        Me.txtDescuentoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoT.EditValue = "0.00"
        Me.txtDescuentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDescuentoT.Location = New System.Drawing.Point(325, 33)
        Me.txtDescuentoT.Name = "txtDescuentoT"
        '
        'txtDescuentoT.Properties
        '
        Me.txtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.ReadOnly = True
        Me.txtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoT.Size = New System.Drawing.Size(80, 17)
        Me.txtDescuentoT.TabIndex = 27
        '
        'txtSubtotalT
        '
        Me.txtSubtotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotalT.EditValue = "0.00"
        Me.txtSubtotalT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotalT.Location = New System.Drawing.Point(224, 33)
        Me.txtSubtotalT.Name = "txtSubtotalT"
        '
        'txtSubtotalT.Properties
        '
        Me.txtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotalT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.ReadOnly = True
        Me.txtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtSubtotalT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotalT.Size = New System.Drawing.Size(80, 17)
        Me.txtSubtotalT.TabIndex = 26
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(413, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 15)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imp. Venta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(309, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 15)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Descuento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(208, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "SubTotal"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.txtSubtotalExcento.Text = ""
        Me.txtSubtotalExcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasPlazo
        '
        Me.txtDiasPlazo.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.txtDiasPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDiasPlazo.ForeColor = System.Drawing.Color.White
        Me.txtDiasPlazo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDiasPlazo.Location = New System.Drawing.Point(145, 3)
        Me.txtDiasPlazo.Name = "txtDiasPlazo"
        Me.txtDiasPlazo.Size = New System.Drawing.Size(32, 10)
        Me.txtDiasPlazo.TabIndex = 157
        Me.txtDiasPlazo.Text = "0"
        Me.txtDiasPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtDiasPlazo.Visible = False
        '
        'opCredito
        '
        Me.opCredito.Enabled = False
        Me.opCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opCredito.ForeColor = System.Drawing.Color.White
        Me.opCredito.Location = New System.Drawing.Point(77, 2)
        Me.opCredito.Name = "opCredito"
        Me.opCredito.Size = New System.Drawing.Size(72, 13)
        Me.opCredito.TabIndex = 1
        Me.opCredito.Text = "Crédito"
        '
        'opContado
        '
        Me.opContado.Checked = True
        Me.opContado.Enabled = False
        Me.opContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opContado.ForeColor = System.Drawing.Color.White
        Me.opContado.Location = New System.Drawing.Point(3, 2)
        Me.opContado.Name = "opContado"
        Me.opContado.Size = New System.Drawing.Size(71, 13)
        Me.opContado.TabIndex = 0
        Me.opContado.TabStop = True
        Me.opContado.Text = "Contado"
        '
        'CkEntregado
        '
        Me.CkEntregado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CkEntregado.BackColor = System.Drawing.SystemColors.Control
        Me.CkEntregado.Enabled = False
        Me.CkEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkEntregado.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.CkEntregado.Location = New System.Drawing.Point(276, 472)
        Me.CkEntregado.Name = "CkEntregado"
        Me.CkEntregado.Size = New System.Drawing.Size(83, 13)
        Me.CkEntregado.TabIndex = 156
        Me.CkEntregado.Text = "Entregado"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(364, 472)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(67, 13)
        Me.CheckBox1.TabIndex = 155
        Me.CheckBox1.Text = "Anulada"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.txtEncargado)
        Me.GroupBox6.Controls.Add(Me.Txtdireccion)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox6.Controls.Add(Me.LabelObs)
        Me.GroupBox6.Controls.Add(Me.Label41)
        Me.GroupBox6.Controls.Add(Me.txtTelefono)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox6.Location = New System.Drawing.Point(5, 32)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(503, 104)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Cliente"
        '
        'txtEncargado
        '
        Me.txtEncargado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEncargado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEncargado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEncargado.Enabled = False
        Me.txtEncargado.ForeColor = System.Drawing.Color.Blue
        Me.txtEncargado.Location = New System.Drawing.Point(80, 64)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(144, 13)
        Me.txtEncargado.TabIndex = 164
        Me.txtEncargado.Text = ""
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdireccion.ForeColor = System.Drawing.Color.Blue
        Me.Txtdireccion.Location = New System.Drawing.Point(232, 63)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(264, 13)
        Me.Txtdireccion.TabIndex = 3
        Me.Txtdireccion.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(232, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Dirección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.TxtObservaciones.Location = New System.Drawing.Point(104, 80)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(392, 13)
        Me.TxtObservaciones.TabIndex = 163
        Me.TxtObservaciones.Text = ""
        '
        'LabelObs
        '
        Me.LabelObs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelObs.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelObs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelObs.Location = New System.Drawing.Point(0, 80)
        Me.LabelObs.Name = "LabelObs"
        Me.LabelObs.Size = New System.Drawing.Size(96, 14)
        Me.LabelObs.TabIndex = 162
        Me.LabelObs.Text = "Observaciones"
        Me.LabelObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(80, 47)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(144, 14)
        Me.Label41.TabIndex = 161
        Me.Label41.Text = "Encargado de Compra"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.FieldReference = Nothing
        Me.txtTelefono.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTelefono.Location = New System.Drawing.Point(8, 60)
        Me.txtTelefono.MaskEdit = ""
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtTelefono.Required = False
        Me.txtTelefono.ShowErrorIcon = True
        Me.txtTelefono.Size = New System.Drawing.Size(64, 13)
        Me.txtTelefono.TabIndex = 2
        Me.txtTelefono.Text = "000 0000"
        Me.txtTelefono.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.txtTelefono.ValidText = ""
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(9, 45)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(63, 14)
        Me.Label38.TabIndex = 159
        Me.Label38.Text = "Teléfono"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(80, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.FieldReference = Nothing
        Me.txtCodigo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodigo.Location = New System.Drawing.Point(14, 30)
        Me.txtCodigo.MaskEdit = ""
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCodigo.Required = False
        Me.txtCodigo.ShowErrorIcon = True
        Me.txtCodigo.Size = New System.Drawing.Size(56, 13)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        Me.txtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtCodigo.ValidText = "No se permiten caracteres"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(80, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(416, 13)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
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
        Me.txtmontodescuento.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(738, 32)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "                  MODIFICA FACTURACION"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(568, 472)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(152, 13)
        Me.txtNombreUsuario.TabIndex = 3
        Me.txtNombreUsuario.Text = ""
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(513, 472)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(55, 13)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Text = ""
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolBarAnular
        '
        Me.ToolBarAnular.Enabled = False
        Me.ToolBarAnular.ImageIndex = 3
        Me.ToolBarAnular.Text = "Anular"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarAnular, Me.ToolBarImprimir, Me.ToolBarImportar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 414)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(738, 58)
        Me.ToolBar1.TabIndex = 0
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarImportar
        '
        Me.ToolBarImportar.Enabled = False
        Me.ToolBarImportar.ImageIndex = 9
        Me.ToolBarImportar.Text = "Importar"
        Me.ToolBarImportar.Visible = False
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=SeePos"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataSet_Facturaciones
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(8, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Moneda.MonedaNombre"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(8, 18)
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
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(136, 33)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(80, 16)
        Me.txtTipoCambio.TabIndex = 70
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Ck_Mascotas)
        Me.GroupBox1.Controls.Add(Me.SimpleButton3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtorden)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Controls.Add(Me.Ck_Taller)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(511, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 104)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones de Factura"
        '
        'Ck_Mascotas
        '
        Me.Ck_Mascotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Mascotas.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Mascotas"))
        Me.Ck_Mascotas.EditValue = False
        Me.Ck_Mascotas.Location = New System.Drawing.Point(83, 80)
        Me.Ck_Mascotas.Name = "Ck_Mascotas"
        '
        'Ck_Mascotas.Properties
        '
        Me.Ck_Mascotas.Properties.Caption = "Mascotas"
        Me.Ck_Mascotas.Properties.Enabled = False
        Me.Ck_Mascotas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.Ck_Mascotas.Size = New System.Drawing.Size(80, 19)
        Me.Ck_Mascotas.TabIndex = 196
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Location = New System.Drawing.Point(95, 17)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(24, 16)
        Me.SimpleButton3.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton3.TabIndex = 192
        Me.SimpleButton3.Text = "..."
        Me.SimpleButton3.ToolTip = "Cambio de la denominación de la moneda"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(136, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 14)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "Tipo Cambio"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtorden
        '
        Me.txtorden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtorden.Enabled = False
        Me.txtorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorden.ForeColor = System.Drawing.Color.Blue
        Me.txtorden.Location = New System.Drawing.Point(136, 64)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(80, 13)
        Me.txtorden.TabIndex = 2
        Me.txtorden.Text = ""
        Me.txtorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label40.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(8, 64)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(112, 14)
        Me.Label40.TabIndex = 77
        Me.Label40.Text = "Orden de Compra ->"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ck_Taller
        '
        Me.Ck_Taller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Taller.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Taller"))
        Me.Ck_Taller.EditValue = False
        Me.Ck_Taller.Location = New System.Drawing.Point(8, 80)
        Me.Ck_Taller.Name = "Ck_Taller"
        '
        'Ck_Taller.Properties
        '
        Me.Ck_Taller.Properties.Caption = "Taller"
        Me.Ck_Taller.Properties.Enabled = False
        Me.Ck_Taller.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.Ck_Taller.Size = New System.Drawing.Size(80, 19)
        Me.Ck_Taller.TabIndex = 193
        '
        'DtVence
        '
        Me.DtVence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DtVence.BackColor = System.Drawing.SystemColors.Control
        Me.DtVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DtVence.ForeColor = System.Drawing.Color.Red
        Me.DtVence.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtVence.Location = New System.Drawing.Point(206, 472)
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
        Me.dtFecha.Location = New System.Drawing.Point(38, 472)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(125, 13)
        Me.dtFecha.TabIndex = 162
        Me.dtFecha.Text = "00/00/0000 hh:mm:ss"
        '
        'Adapter_Clientes
        '
        Me.Adapter_Clientes.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Clientes.InsertCommand = Me.SqlInsertCommand7
        Me.Adapter_Clientes.SelectCommand = Me.SqlSelectCommand9
        Me.Adapter_Clientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("abierto", "abierto"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("max_credito", "max_credito"), New System.Data.Common.DataColumnMapping("Plazo_credito", "Plazo_credito"), New System.Data.Common.DataColumnMapping("descuento", "descuento"), New System.Data.Common.DataColumnMapping("empresa", "empresa"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("sinrestriccion", "sinrestriccion"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("agente", "agente"), New System.Data.Common.DataColumnMapping("CodMonedaCredito", "CodMonedaCredito")})})
        Me.Adapter_Clientes.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Clientes WHERE (identificacion = @Original_identificacion) AND (CodMo" & _
        "nedaCredito = @Original_CodMonedaCredito) AND (Plazo_credito = @Original_Plazo_c" & _
        "redito) AND (Telefono_01 = @Original_Telefono_01) AND (abierto = @Original_abier" & _
        "to) AND (agente = @Original_agente) AND (cedula = @Original_cedula) AND (descuen" & _
        "to = @Original_descuento) AND (direccion = @Original_direccion) AND (e_mail = @O" & _
        "riginal_e_mail) AND (empresa = @Original_empresa) AND (fax_01 = @Original_fax_01" & _
        ") AND (fax_02 = @Original_fax_02) AND (impuesto = @Original_impuesto) AND (max_c" & _
        "redito = @Original_max_credito) AND (nombre = @Original_nombre) AND (nombreusuar" & _
        "io = @Original_nombreusuario) AND (observaciones = @Original_observaciones) AND " & _
        "(sinrestriccion = @Original_sinrestriccion) AND (telefono_02 = @Original_telefon" & _
        "o_02) AND (tipoprecio = @Original_tipoprecio) AND (usuario = @Original_usuario)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO Clientes(identificacion, cedula, nombre, observaciones, Telefono_01, " & _
        "telefono_02, fax_01, fax_02, e_mail, abierto, direccion, impuesto, max_credito, " & _
        "Plazo_credito, descuento, empresa, tipoprecio, sinrestriccion, usuario, nombreus" & _
        "uario, agente, CodMonedaCredito) VALUES (@identificacion, @cedula, @nombre, @obs" & _
        "ervaciones, @Telefono_01, @telefono_02, @fax_01, @fax_02, @e_mail, @abierto, @di" & _
        "reccion, @impuesto, @max_credito, @Plazo_credito, @descuento, @empresa, @tipopre" & _
        "cio, @sinrestriccion, @usuario, @nombreusuario, @agente, @CodMonedaCredito); SEL" & _
        "ECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, fax" & _
        "_01, fax_02, e_mail, abierto, direccion, impuesto, max_credito, Plazo_credito, d" & _
        "escuento, empresa, tipoprecio, sinrestriccion, usuario, nombreusuario, agente, C" & _
        "odMonedaCredito FROM Clientes WHERE (identificacion = @identificacion)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.VarChar, 2, "abierto"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 8, "max_credito"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 4, "Plazo_credito"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 8, "descuento"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 2, "empresa"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.VarChar, 2, "sinrestriccion"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 50, "agente"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 4, "CodMonedaCredito"))
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, f" & _
        "ax_01, fax_02, e_mail, abierto, direccion, impuesto, max_credito, Plazo_credito," & _
        " descuento, empresa, tipoprecio, sinrestriccion, usuario, nombreusuario, agente," & _
        " CodMonedaCredito FROM Clientes"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Clientes SET identificacion = @identificacion, cedula = @cedula, nombre = " & _
        "@nombre, observaciones = @observaciones, Telefono_01 = @Telefono_01, telefono_02" & _
        " = @telefono_02, fax_01 = @fax_01, fax_02 = @fax_02, e_mail = @e_mail, abierto =" & _
        " @abierto, direccion = @direccion, impuesto = @impuesto, max_credito = @max_cred" & _
        "ito, Plazo_credito = @Plazo_credito, descuento = @descuento, empresa = @empresa," & _
        " tipoprecio = @tipoprecio, sinrestriccion = @sinrestriccion, usuario = @usuario," & _
        " nombreusuario = @nombreusuario, agente = @agente, CodMonedaCredito = @CodMoneda" & _
        "Credito WHERE (identificacion = @Original_identificacion) AND (CodMonedaCredito " & _
        "= @Original_CodMonedaCredito) AND (Plazo_credito = @Original_Plazo_credito) AND " & _
        "(Telefono_01 = @Original_Telefono_01) AND (abierto = @Original_abierto) AND (age" & _
        "nte = @Original_agente) AND (cedula = @Original_cedula) AND (descuento = @Origin" & _
        "al_descuento) AND (direccion = @Original_direccion) AND (e_mail = @Original_e_ma" & _
        "il) AND (empresa = @Original_empresa) AND (fax_01 = @Original_fax_01) AND (fax_0" & _
        "2 = @Original_fax_02) AND (impuesto = @Original_impuesto) AND (max_credito = @Or" & _
        "iginal_max_credito) AND (nombre = @Original_nombre) AND (nombreusuario = @Origin" & _
        "al_nombreusuario) AND (observaciones = @Original_observaciones) AND (sinrestricc" & _
        "ion = @Original_sinrestriccion) AND (telefono_02 = @Original_telefono_02) AND (t" & _
        "ipoprecio = @Original_tipoprecio) AND (usuario = @Original_usuario); SELECT iden" & _
        "tificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, fax_01, fax" & _
        "_02, e_mail, abierto, direccion, impuesto, max_credito, Plazo_credito, descuento" & _
        ", empresa, tipoprecio, sinrestriccion, usuario, nombreusuario, agente, CodMoneda" & _
        "Credito FROM Clientes WHERE (identificacion = @identificacion)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.VarChar, 2, "abierto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 8, "max_credito"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 4, "Plazo_credito"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 8, "descuento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 2, "empresa"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.VarChar, 2, "sinrestriccion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 50, "agente"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 4, "CodMonedaCredito"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Ventas.VentasVentas_Detalle"
        Me.GridControl1.DataSource = Me.DataSet_Facturaciones
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(6, 216)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(728, 136)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
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
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
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
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
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
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
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
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
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
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
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
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
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
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
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
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotal.Visible = True
        Me.colSubTotal.Width = 88
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.InsertCommand = Me.SqlInsertCommand10
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = "INSERT INTO Usuarios(Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio," & _
        " Aplicar_Desc, Exist_Negativa, Porc_Desc, Porc_Precio) VALUES (@Cedula, @Nombre," & _
        " @Clave_Entrada, @Clave_Interna, @CambiarPrecio, @Aplicar_Desc, @Exist_Negativa," & _
        " @Porc_Desc, @Porc_Precio); SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna," & _
        " CambiarPrecio, Aplicar_Desc, Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuari" & _
        "os"
        Me.SqlInsertCommand10.Connection = Me.SqlConnection1
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 50, "Cedula"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_Desc," & _
        " Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Adapter_Encargados_Compra
        '
        Me.Adapter_Encargados_Compra.DeleteCommand = Me.SqlDeleteCommand7
        Me.Adapter_Encargados_Compra.InsertCommand = Me.SqlInsertCommand8
        Me.Adapter_Encargados_Compra.SelectCommand = Me.SqlSelectCommand10
        Me.Adapter_Encargados_Compra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "encargadocompras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.Adapter_Encargados_Compra.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM encargadocompras WHERE (Identificacion = @Original_Identificacion) AN" & _
        "D (Cliente = @Original_Cliente) AND (Nombre = @Original_Nombre)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO encargadocompras(Identificacion, Cliente, Nombre) VALUES (@Identifica" & _
        "cion, @Cliente, @Nombre); SELECT Identificacion, Cliente, Nombre FROM encargadoc" & _
        "ompras WHERE (Identificacion = @Identificacion)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection1
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Identificacion, Cliente, Nombre FROM encargadocompras"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE encargadocompras SET Identificacion = @Identificacion, Cliente = @Cliente," & _
        " Nombre = @Nombre WHERE (Identificacion = @Original_Identificacion) AND (Cliente" & _
        " = @Original_Cliente) AND (Nombre = @Original_Nombre); SELECT Identificacion, Cl" & _
        "iente, Nombre FROM encargadocompras WHERE (Identificacion = @Identificacion)"
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'Txtcodmoneda_Venta
        '
        Me.Txtcodmoneda_Venta.Location = New System.Drawing.Point(640, 248)
        Me.Txtcodmoneda_Venta.Name = "Txtcodmoneda_Venta"
        Me.Txtcodmoneda_Venta.Size = New System.Drawing.Size(40, 20)
        Me.Txtcodmoneda_Venta.TabIndex = 188
        Me.Txtcodmoneda_Venta.Text = ""
        '
        'Txt_TipoCambio_Valor_Compra
        '
        Me.Txt_TipoCambio_Valor_Compra.Location = New System.Drawing.Point(688, 248)
        Me.Txt_TipoCambio_Valor_Compra.Name = "Txt_TipoCambio_Valor_Compra"
        Me.Txt_TipoCambio_Valor_Compra.Size = New System.Drawing.Size(32, 20)
        Me.Txt_TipoCambio_Valor_Compra.TabIndex = 189
        Me.Txt_TipoCambio_Valor_Compra.Text = ""
        '
        'Adapter_Ventas_Detalles
        '
        Me.Adapter_Ventas_Detalles.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Ventas_Detalles.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Ventas_Detalles.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Ventas_Detalles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_venta_detalle", "id_venta_detalle"), New System.Data.Common.DataColumnMapping("Id_Factura", "Id_Factura"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("Numero_Entrega", "Numero_Entrega"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("Lote", "Lote")})})
        Me.Adapter_Ventas_Detalles.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Ventas_Detalle WHERE (id_venta_detalle = @Original_id_venta_detalle) " & _
        "AND (Cantidad = @Original_Cantidad) AND (CodArticulo = @Original_CodArticulo) AN" & _
        "D (Cod_MonedaVenta = @Original_Cod_MonedaVenta) AND (Codigo = @Original_Codigo) " & _
        "AND (Descripcion = @Original_Descripcion) AND (Descuento = @Original_Descuento) " & _
        "AND (Devoluciones = @Original_Devoluciones) AND (Id_Factura = @Original_Id_Factu" & _
        "ra) AND (Impuesto = @Original_Impuesto) AND (Lote = @Original_Lote) AND (Max_Des" & _
        "cuento = @Original_Max_Descuento) AND (Monto_Descuento = @Original_Monto_Descuen" & _
        "to) AND (Monto_Impuesto = @Original_Monto_Impuesto) AND (Numero_Entrega = @Origi" & _
        "nal_Numero_Entrega) AND (Precio_Base = @Original_Precio_Base) AND (Precio_Costo " & _
        "= @Original_Precio_Costo) AND (Precio_Flete = @Original_Precio_Flete) AND (Preci" & _
        "o_Otros = @Original_Precio_Otros) AND (Precio_Unit = @Original_Precio_Unit) AND " & _
        "(SubTotal = @Original_SubTotal) AND (SubTotalExcento = @Original_SubTotalExcento" & _
        ") AND (SubtotalGravado = @Original_SubtotalGravado) AND (Tipo_Cambio_ValorCompra" & _
        " = @Original_Tipo_Cambio_ValorCompra)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Lote", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lote", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero_Entrega", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Entrega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Ventas_Detalle(Id_Factura, Codigo, Descripcion, Cantidad, Precio_Cost" & _
        "o, Precio_Base, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_Descue" & _
        "nto, Impuesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, Devol" & _
        "uciones, Numero_Entrega, Max_Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta" & _
        ", CodArticulo, Lote) VALUES (@Id_Factura, @Codigo, @Descripcion, @Cantidad, @Pre" & _
        "cio_Costo, @Precio_Base, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Descuento," & _
        " @Monto_Descuento, @Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcent" & _
        "o, @SubTotal, @Devoluciones, @Numero_Entrega, @Max_Descuento, @Tipo_Cambio_Valor" & _
        "Compra, @Cod_MonedaVenta, @CodArticulo, @Lote); SELECT id_venta_detalle, Id_Fact" & _
        "ura, Codigo, Descripcion, Cantidad, Precio_Costo, Precio_Base, Precio_Flete, Pre" & _
        "cio_Otros, Precio_Unit, Descuento, Monto_Descuento, Impuesto, Monto_Impuesto, Su" & _
        "btotalGravado, SubTotalExcento, SubTotal, Devoluciones, Numero_Entrega, Max_Desc" & _
        "uento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, CodArticulo, Lote FROM Ventas_D" & _
        "etalle WHERE (id_venta_detalle = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 8, "Id_Factura"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 8, "Numero_Entrega"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_venta_detalle, Id_Factura, Codigo, Descripcion, Cantidad, Precio_Costo," & _
        " Precio_Base, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_Descuent" & _
        "o, Impuesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, Devoluc" & _
        "iones, Numero_Entrega, Max_Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, " & _
        "CodArticulo, Lote FROM Ventas_Detalle"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Ventas_Detalle SET Id_Factura = @Id_Factura, Codigo = @Codigo, Descripcion" & _
        " = @Descripcion, Cantidad = @Cantidad, Precio_Costo = @Precio_Costo, Precio_Base" & _
        " = @Precio_Base, Precio_Flete = @Precio_Flete, Precio_Otros = @Precio_Otros, Pre" & _
        "cio_Unit = @Precio_Unit, Descuento = @Descuento, Monto_Descuento = @Monto_Descue" & _
        "nto, Impuesto = @Impuesto, Monto_Impuesto = @Monto_Impuesto, SubtotalGravado = @" & _
        "SubtotalGravado, SubTotalExcento = @SubTotalExcento, SubTotal = @SubTotal, Devol" & _
        "uciones = @Devoluciones, Numero_Entrega = @Numero_Entrega, Max_Descuento = @Max_" & _
        "Descuento, Tipo_Cambio_ValorCompra = @Tipo_Cambio_ValorCompra, Cod_MonedaVenta =" & _
        " @Cod_MonedaVenta, CodArticulo = @CodArticulo, Lote = @Lote WHERE (id_venta_deta" & _
        "lle = @Original_id_venta_detalle) AND (Cantidad = @Original_Cantidad) AND (CodAr" & _
        "ticulo = @Original_CodArticulo) AND (Cod_MonedaVenta = @Original_Cod_MonedaVenta" & _
        ") AND (Codigo = @Original_Codigo) AND (Descripcion = @Original_Descripcion) AND " & _
        "(Descuento = @Original_Descuento) AND (Devoluciones = @Original_Devoluciones) AN" & _
        "D (Id_Factura = @Original_Id_Factura) AND (Impuesto = @Original_Impuesto) AND (L" & _
        "ote = @Original_Lote) AND (Max_Descuento = @Original_Max_Descuento) AND (Monto_D" & _
        "escuento = @Original_Monto_Descuento) AND (Monto_Impuesto = @Original_Monto_Impu" & _
        "esto) AND (Numero_Entrega = @Original_Numero_Entrega) AND (Precio_Base = @Origin" & _
        "al_Precio_Base) AND (Precio_Costo = @Original_Precio_Costo) AND (Precio_Flete = " & _
        "@Original_Precio_Flete) AND (Precio_Otros = @Original_Precio_Otros) AND (Precio_" & _
        "Unit = @Original_Precio_Unit) AND (SubTotal = @Original_SubTotal) AND (SubTotalE" & _
        "xcento = @Original_SubTotalExcento) AND (SubtotalGravado = @Original_SubtotalGra" & _
        "vado) AND (Tipo_Cambio_ValorCompra = @Original_Tipo_Cambio_ValorCompra); SELECT " & _
        "id_venta_detalle, Id_Factura, Codigo, Descripcion, Cantidad, Precio_Costo, Preci" & _
        "o_Base, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_Descuento, Imp" & _
        "uesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, Devoluciones," & _
        " Numero_Entrega, Max_Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, CodArt" & _
        "iculo, Lote FROM Ventas_Detalle WHERE (id_venta_detalle = @id_venta_detalle)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 8, "Id_Factura"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 8, "Numero_Entrega"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Lote", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lote", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero_Entrega", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Entrega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_venta_detalle", System.Data.SqlDbType.BigInt, 8, "id_venta_detalle"))
        '
        'Adapter_Ventas
        '
        Me.Adapter_Ventas.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adapter_Ventas.InsertCommand = Me.SqlInsertCommand4
        Me.Adapter_Ventas.SelectCommand = Me.SqlSelectCommand5
        Me.Adapter_Ventas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Pago_Comision", "Pago_Comision"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("Cod_Encargado_Compra", "Cod_Encargado_Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("AsientoVenta", "AsientoVenta"), New System.Data.Common.DataColumnMapping("ContabilizadoCVenta", "ContabilizadoCVenta"), New System.Data.Common.DataColumnMapping("AsientoCosto", "AsientoCosto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Entregado", "Entregado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Moneda_Nombre", "Moneda_Nombre"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Exonerar", "Exonerar"), New System.Data.Common.DataColumnMapping("Taller", "Taller")})})
        Me.Adapter_Ventas.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Ventas WHERE (Id = @Original_Id) AND (Anulado = @Original_Anulado) AN" & _
        "D (AsientoCosto = @Original_AsientoCosto) AND (AsientoVenta = @Original_AsientoV" & _
        "enta) AND (Cedula_Usuario = @Original_Cedula_Usuario) AND (Cod_Cliente = @Origin" & _
        "al_Cod_Cliente) AND (Cod_Encargado_Compra = @Original_Cod_Encargado_Compra) AND " & _
        "(Cod_Moneda = @Original_Cod_Moneda) AND (Contabilizado = @Original_Contabilizado" & _
        ") AND (ContabilizadoCVenta = @Original_ContabilizadoCVenta) AND (Descuento = @Or" & _
        "iginal_Descuento) AND (Direccion = @Original_Direccion) AND (Entregado = @Origin" & _
        "al_Entregado) AND (Exonerar = @Original_Exonerar) AND (FacturaCancelado = @Origi" & _
        "nal_FacturaCancelado) AND (Fecha = @Original_Fecha) AND (Imp_Venta = @Original_I" & _
        "mp_Venta) AND (Moneda_Nombre = @Original_Moneda_Nombre) AND (Nombre_Cliente = @O" & _
        "riginal_Nombre_Cliente) AND (Num_Apertura = @Original_Num_Apertura) AND (Num_Fac" & _
        "tura = @Original_Num_Factura) AND (Observaciones = @Original_Observaciones) AND " & _
        "(Orden = @Original_Orden) AND (PagoImpuesto = @Original_PagoImpuesto) AND (Pago_" & _
        "Comision = @Original_Pago_Comision) AND (SubTotal = @Original_SubTotal) AND (Sub" & _
        "TotalExento = @Original_SubTotalExento) AND (SubTotalGravada = @Original_SubTota" & _
        "lGravada) AND (Taller = @Original_Taller) AND (Telefono = @Original_Telefono) AN" & _
        "D (Tipo = @Original_Tipo) AND (Tipo_Cambio = @Original_Tipo_Cambio) AND (Total =" & _
        " @Original_Total) AND (Transporte = @Original_Transporte) AND (Vence = @Original" & _
        "_Vence)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AsientoCosto", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AsientoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Encargado_Compra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContabilizadoCVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Entregado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entregado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Apertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Apertura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pago_Comision", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pago_Comision", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Ventas(Num_Factura, Tipo, Cod_Cliente, Nombre_Cliente, Orden, Cedula_" & _
        "Usuario, Pago_Comision, SubTotal, Descuento, Imp_Venta, Total, Fecha, Vence, Cod" & _
        "_Encargado_Compra, Contabilizado, AsientoVenta, ContabilizadoCVenta, AsientoCost" & _
        "o, Anulado, PagoImpuesto, FacturaCancelado, Num_Apertura, Entregado, Cod_Moneda," & _
        " Moneda_Nombre, Direccion, Telefono, SubTotalGravada, SubTotalExento, Transporte" & _
        ", Tipo_Cambio, Observaciones, Exonerar, Taller) VALUES (@Num_Factura, @Tipo, @Co" & _
        "d_Cliente, @Nombre_Cliente, @Orden, @Cedula_Usuario, @Pago_Comision, @SubTotal, " & _
        "@Descuento, @Imp_Venta, @Total, @Fecha, @Vence, @Cod_Encargado_Compra, @Contabil" & _
        "izado, @AsientoVenta, @ContabilizadoCVenta, @AsientoCosto, @Anulado, @PagoImpues" & _
        "to, @FacturaCancelado, @Num_Apertura, @Entregado, @Cod_Moneda, @Moneda_Nombre, @" & _
        "Direccion, @Telefono, @SubTotalGravada, @SubTotalExento, @Transporte, @Tipo_Camb" & _
        "io, @Observaciones, @Exonerar, @Taller); SELECT Id, Num_Factura, Tipo, Cod_Clien" & _
        "te, Nombre_Cliente, Orden, Cedula_Usuario, Pago_Comision, SubTotal, Descuento, I" & _
        "mp_Venta, Total, Fecha, Vence, Cod_Encargado_Compra, Contabilizado, AsientoVenta" & _
        ", ContabilizadoCVenta, AsientoCosto, Anulado, PagoImpuesto, FacturaCancelado, Nu" & _
        "m_Apertura, Entregado, Cod_Moneda, Moneda_Nombre, Direccion, Telefono, SubTotalG" & _
        "ravada, SubTotalExento, Transporte, Tipo_Cambio, Observaciones, Exonerar, Taller" & _
        " FROM Ventas WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 8, "Num_Factura"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 1, "Pago_Comision"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 4, "Vence"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, "Cod_Encargado_Compra"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 8, "AsientoVenta"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, "ContabilizadoCVenta"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 8, "AsientoCosto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 4, "PagoImpuesto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 1, "Entregado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, "Moneda_Nombre"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 50, "Telefono"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 20, "Observaciones"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 1, "Exonerar"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id, Num_Factura, Tipo, Cod_Cliente, Nombre_Cliente, Orden, Cedula_Usuario," & _
        " Pago_Comision, SubTotal, Descuento, Imp_Venta, Total, Fecha, Vence, Cod_Encarga" & _
        "do_Compra, Contabilizado, AsientoVenta, ContabilizadoCVenta, AsientoCosto, Anula" & _
        "do, PagoImpuesto, FacturaCancelado, Num_Apertura, Entregado, Cod_Moneda, Moneda_" & _
        "Nombre, Direccion, Telefono, SubTotalGravada, SubTotalExento, Transporte, Tipo_C" & _
        "ambio, Observaciones, Exonerar, Taller FROM Ventas"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Ventas SET Num_Factura = @Num_Factura, Tipo = @Tipo, Cod_Cliente = @Cod_Cl" & _
        "iente, Nombre_Cliente = @Nombre_Cliente, Orden = @Orden, Cedula_Usuario = @Cedul" & _
        "a_Usuario, Pago_Comision = @Pago_Comision, SubTotal = @SubTotal, Descuento = @De" & _
        "scuento, Imp_Venta = @Imp_Venta, Total = @Total, Fecha = @Fecha, Vence = @Vence," & _
        " Cod_Encargado_Compra = @Cod_Encargado_Compra, Contabilizado = @Contabilizado, A" & _
        "sientoVenta = @AsientoVenta, ContabilizadoCVenta = @ContabilizadoCVenta, Asiento" & _
        "Costo = @AsientoCosto, Anulado = @Anulado, PagoImpuesto = @PagoImpuesto, Factura" & _
        "Cancelado = @FacturaCancelado, Num_Apertura = @Num_Apertura, Entregado = @Entreg" & _
        "ado, Cod_Moneda = @Cod_Moneda, Moneda_Nombre = @Moneda_Nombre, Direccion = @Dire" & _
        "ccion, Telefono = @Telefono, SubTotalGravada = @SubTotalGravada, SubTotalExento " & _
        "= @SubTotalExento, Transporte = @Transporte, Tipo_Cambio = @Tipo_Cambio, Observa" & _
        "ciones = @Observaciones, Exonerar = @Exonerar, Taller = @Taller WHERE (Id = @Ori" & _
        "ginal_Id) AND (Anulado = @Original_Anulado) AND (AsientoCosto = @Original_Asient" & _
        "oCosto) AND (AsientoVenta = @Original_AsientoVenta) AND (Cedula_Usuario = @Origi" & _
        "nal_Cedula_Usuario) AND (Cod_Cliente = @Original_Cod_Cliente) AND (Cod_Encargado" & _
        "_Compra = @Original_Cod_Encargado_Compra) AND (Cod_Moneda = @Original_Cod_Moneda" & _
        ") AND (Contabilizado = @Original_Contabilizado) AND (ContabilizadoCVenta = @Orig" & _
        "inal_ContabilizadoCVenta) AND (Descuento = @Original_Descuento) AND (Direccion =" & _
        " @Original_Direccion) AND (Entregado = @Original_Entregado) AND (Exonerar = @Ori" & _
        "ginal_Exonerar) AND (FacturaCancelado = @Original_FacturaCancelado) AND (Fecha =" & _
        " @Original_Fecha) AND (Imp_Venta = @Original_Imp_Venta) AND (Moneda_Nombre = @Or" & _
        "iginal_Moneda_Nombre) AND (Nombre_Cliente = @Original_Nombre_Cliente) AND (Num_A" & _
        "pertura = @Original_Num_Apertura) AND (Num_Factura = @Original_Num_Factura) AND " & _
        "(Observaciones = @Original_Observaciones) AND (Orden = @Original_Orden) AND (Pag" & _
        "oImpuesto = @Original_PagoImpuesto) AND (Pago_Comision = @Original_Pago_Comision" & _
        ") AND (SubTotal = @Original_SubTotal) AND (SubTotalExento = @Original_SubTotalEx" & _
        "ento) AND (SubTotalGravada = @Original_SubTotalGravada) AND (Taller = @Original_" & _
        "Taller) AND (Telefono = @Original_Telefono) AND (Tipo = @Original_Tipo) AND (Tip" & _
        "o_Cambio = @Original_Tipo_Cambio) AND (Total = @Original_Total) AND (Transporte " & _
        "= @Original_Transporte) AND (Vence = @Original_Vence); SELECT Id, Num_Factura, T" & _
        "ipo, Cod_Cliente, Nombre_Cliente, Orden, Cedula_Usuario, Pago_Comision, SubTotal" & _
        ", Descuento, Imp_Venta, Total, Fecha, Vence, Cod_Encargado_Compra, Contabilizado" & _
        ", AsientoVenta, ContabilizadoCVenta, AsientoCosto, Anulado, PagoImpuesto, Factur" & _
        "aCancelado, Num_Apertura, Entregado, Cod_Moneda, Moneda_Nombre, Direccion, Telef" & _
        "ono, SubTotalGravada, SubTotalExento, Transporte, Tipo_Cambio, Observaciones, Ex" & _
        "onerar, Taller FROM Ventas WHERE (Id = @Id)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 8, "Num_Factura"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 1, "Pago_Comision"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 4, "Vence"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, "Cod_Encargado_Compra"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 8, "AsientoVenta"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, "ContabilizadoCVenta"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 8, "AsientoCosto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 4, "PagoImpuesto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 1, "Entregado"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, "Moneda_Nombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 50, "Telefono"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 20, "Observaciones"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 1, "Exonerar"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AsientoCosto", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AsientoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Encargado_Compra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContabilizadoCVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Entregado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entregado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Apertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Apertura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pago_Comision", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pago_Comision", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Text = "Importar Cotización"
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT Cotizacion, Fecha, Cod_Cliente, Nombre_Cliente, Contacto, Validez, TiempoE" & _
        "ntrega, Contado, Credito, Anulado, Dias, Observaciones, SubTotalGravada, SubTota" & _
        "lExento, Descuento, PagoImpuesto, Total, Cedula, CodMoneda, MonedaNombre, SubTot" & _
        "al, Tipo_Cambio, Imp_Venta, Transporte, Venta FROM Cotizacion"
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
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Cotizacion WHERE (Cotizacion = @Original_Cotizacion) AND (Anulado = @" & _
        "Original_Anulado) AND (Cedula = @Original_Cedula) AND (CodMoneda = @Original_Cod" & _
        "Moneda) AND (Cod_Cliente = @Original_Cod_Cliente) AND (Contacto = @Original_Cont" & _
        "acto) AND (Contado = @Original_Contado) AND (Credito = @Original_Credito) AND (D" & _
        "escuento = @Original_Descuento) AND (Dias = @Original_Dias) AND (Exonerar = @Ori" & _
        "ginal_Exonerar) AND (Fecha = @Original_Fecha) AND (Imp_Venta = @Original_Imp_Ven" & _
        "ta) AND (MonedaNombre = @Original_MonedaNombre) AND (Nombre_Cliente = @Original_" & _
        "Nombre_Cliente) AND (Observaciones = @Original_Observaciones) AND (PagoImpuesto " & _
        "= @Original_PagoImpuesto) AND (SubTotal = @Original_SubTotal) AND (SubTotalExent" & _
        "o = @Original_SubTotalExento) AND (SubTotalGravada = @Original_SubTotalGravada) " & _
        "AND (TiempoEntrega = @Original_TiempoEntrega) AND (Tipo_Cambio = @Original_Tipo_" & _
        "Cambio) AND (Total = @Original_Total) AND (Transporte = @Original_Transporte) AN" & _
        "D (Validez = @Original_Validez) AND (Venta = @Original_Venta)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Cotizacion(Fecha, Cod_Cliente, Nombre_Cliente, Contacto, Validez, Tie" & _
        "mpoEntrega, Contado, Credito, Anulado, Dias, Observaciones, SubTotalGravada, Sub" & _
        "TotalExento, Descuento, PagoImpuesto, Total, Cedula, CodMoneda, MonedaNombre, Su" & _
        "bTotal, Tipo_Cambio, Imp_Venta, Transporte, Venta, Exonerar) VALUES (@Fecha, @Co" & _
        "d_Cliente, @Nombre_Cliente, @Contacto, @Validez, @TiempoEntrega, @Contado, @Cred" & _
        "ito, @Anulado, @Dias, @Observaciones, @SubTotalGravada, @SubTotalExento, @Descue" & _
        "nto, @PagoImpuesto, @Total, @Cedula, @CodMoneda, @MonedaNombre, @SubTotal, @Tipo" & _
        "_Cambio, @Imp_Venta, @Transporte, @Venta, @Exonerar); SELECT Cotizacion, Fecha, " & _
        "Cod_Cliente, Nombre_Cliente, Contacto, Validez, TiempoEntrega, Contado, Credito," & _
        " Anulado, Dias, Observaciones, SubTotalGravada, SubTotalExento, Descuento, PagoI" & _
        "mpuesto, Total, Cedula, CodMoneda, MonedaNombre, SubTotal, Tipo_Cambio, Imp_Vent" & _
        "a, Transporte, Venta, Exonerar FROM Cotizacion WHERE (Cotizacion = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 4, "Validez"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 4, "TiempoEntrega"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 1, "Contado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 4, "Dias"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 8, "PagoImpuesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 1, "Venta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 1, "Exonerar"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Cotizacion, Fecha, Cod_Cliente, Nombre_Cliente, Contacto, Validez, TiempoE" & _
        "ntrega, Contado, Credito, Anulado, Dias, Observaciones, SubTotalGravada, SubTota" & _
        "lExento, Descuento, PagoImpuesto, Total, Cedula, CodMoneda, MonedaNombre, SubTot" & _
        "al, Tipo_Cambio, Imp_Venta, Transporte, Venta, Exonerar FROM Cotizacion"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Cotizacion SET Fecha = @Fecha, Cod_Cliente = @Cod_Cliente, Nombre_Cliente " & _
        "= @Nombre_Cliente, Contacto = @Contacto, Validez = @Validez, TiempoEntrega = @Ti" & _
        "empoEntrega, Contado = @Contado, Credito = @Credito, Anulado = @Anulado, Dias = " & _
        "@Dias, Observaciones = @Observaciones, SubTotalGravada = @SubTotalGravada, SubTo" & _
        "talExento = @SubTotalExento, Descuento = @Descuento, PagoImpuesto = @PagoImpuest" & _
        "o, Total = @Total, Cedula = @Cedula, CodMoneda = @CodMoneda, MonedaNombre = @Mon" & _
        "edaNombre, SubTotal = @SubTotal, Tipo_Cambio = @Tipo_Cambio, Imp_Venta = @Imp_Ve" & _
        "nta, Transporte = @Transporte, Venta = @Venta, Exonerar = @Exonerar WHERE (Cotiz" & _
        "acion = @Original_Cotizacion) AND (Anulado = @Original_Anulado) AND (Cedula = @O" & _
        "riginal_Cedula) AND (CodMoneda = @Original_CodMoneda) AND (Cod_Cliente = @Origin" & _
        "al_Cod_Cliente) AND (Contacto = @Original_Contacto) AND (Contado = @Original_Con" & _
        "tado) AND (Credito = @Original_Credito) AND (Descuento = @Original_Descuento) AN" & _
        "D (Dias = @Original_Dias) AND (Exonerar = @Original_Exonerar) AND (Fecha = @Orig" & _
        "inal_Fecha) AND (Imp_Venta = @Original_Imp_Venta) AND (MonedaNombre = @Original_" & _
        "MonedaNombre) AND (Nombre_Cliente = @Original_Nombre_Cliente) AND (Observaciones" & _
        " = @Original_Observaciones) AND (PagoImpuesto = @Original_PagoImpuesto) AND (Sub" & _
        "Total = @Original_SubTotal) AND (SubTotalExento = @Original_SubTotalExento) AND " & _
        "(SubTotalGravada = @Original_SubTotalGravada) AND (TiempoEntrega = @Original_Tie" & _
        "mpoEntrega) AND (Tipo_Cambio = @Original_Tipo_Cambio) AND (Total = @Original_Tot" & _
        "al) AND (Transporte = @Original_Transporte) AND (Validez = @Original_Validez) AN" & _
        "D (Venta = @Original_Venta); SELECT Cotizacion, Fecha, Cod_Cliente, Nombre_Clien" & _
        "te, Contacto, Validez, TiempoEntrega, Contado, Credito, Anulado, Dias, Observaci" & _
        "ones, SubTotalGravada, SubTotalExento, Descuento, PagoImpuesto, Total, Cedula, C" & _
        "odMoneda, MonedaNombre, SubTotal, Tipo_Cambio, Imp_Venta, Transporte, Venta, Exo" & _
        "nerar FROM Cotizacion WHERE (Cotizacion = @Cotizacion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 4, "Validez"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 4, "TiempoEntrega"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 1, "Contado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 4, "Dias"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 8, "PagoImpuesto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 1, "Venta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 1, "Exonerar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"))
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
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Cotizacion_Detalle WHERE (Numero = @Original_Numero) AND (Cantidad = " & _
        "@Original_Cantidad) AND (CodArticulo = @Original_CodArticulo) AND (Cod_MonedaVen" & _
        "ta = @Original_Cod_MonedaVenta) AND (Codigo = @Original_Codigo) AND (Cotizacion " & _
        "= @Original_Cotizacion) AND (Descripcion = @Original_Descripcion) AND (Descuento" & _
        " = @Original_Descuento) AND (Impuesto = @Original_Impuesto) AND (Max_Descuento =" & _
        " @Original_Max_Descuento) AND (Monto_Descuento = @Original_Monto_Descuento) AND " & _
        "(Monto_Impuesto = @Original_Monto_Impuesto) AND (Precio_Base = @Original_Precio_" & _
        "Base) AND (Precio_Costo = @Original_Precio_Costo) AND (Precio_Flete = @Original_" & _
        "Precio_Flete) AND (Precio_Otros = @Original_Precio_Otros) AND (Precio_Unit = @Or" & _
        "iginal_Precio_Unit) AND (SubFamilia = @Original_SubFamilia) AND (SubTotal = @Ori" & _
        "ginal_SubTotal) AND (SubTotalExcento = @Original_SubTotalExcento) AND (SubtotalG" & _
        "ravado = @Original_SubtotalGravado) AND (Tipo_Cambio_ValorCompra = @Original_Tip" & _
        "o_Cambio_ValorCompra)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubFamilia", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Cotizacion_Detalle(Cotizacion, Codigo, Descripcion, Cantidad, Precio_" & _
        "Costo, Precio_Base, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_De" & _
        "scuento, Impuesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, S" & _
        "ubFamilia, Max_Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, CodArticulo)" & _
        " VALUES (@Cotizacion, @Codigo, @Descripcion, @Cantidad, @Precio_Costo, @Precio_B" & _
        "ase, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Descuento, @Monto_Descuento, @" & _
        "Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcento, @SubTotal, @SubFa" & _
        "milia, @Max_Descuento, @Tipo_Cambio_ValorCompra, @Cod_MonedaVenta, @CodArticulo)" & _
        "; SELECT Numero, Cotizacion, Codigo, Descripcion, Cantidad, Precio_Costo, Precio" & _
        "_Base, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_Descuento, Impu" & _
        "esto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, SubFamilia, Ma" & _
        "x_Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, CodArticulo FROM Cotizaci" & _
        "on_Detalle WHERE (Numero = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Numero, Cotizacion, Codigo, Descripcion, Cantidad, Precio_Costo, Precio_Ba" & _
        "se, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_Descuento, Impuest" & _
        "o, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, SubFamilia, Max_D" & _
        "escuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, CodArticulo FROM Cotizacion_" & _
        "Detalle"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE Cotizacion_Detalle SET Cotizacion = @Cotizacion, Codigo = @Codigo, Descrip" & _
        "cion = @Descripcion, Cantidad = @Cantidad, Precio_Costo = @Precio_Costo, Precio_" & _
        "Base = @Precio_Base, Precio_Flete = @Precio_Flete, Precio_Otros = @Precio_Otros," & _
        " Precio_Unit = @Precio_Unit, Descuento = @Descuento, Monto_Descuento = @Monto_De" & _
        "scuento, Impuesto = @Impuesto, Monto_Impuesto = @Monto_Impuesto, SubtotalGravado" & _
        " = @SubtotalGravado, SubTotalExcento = @SubTotalExcento, SubTotal = @SubTotal, S" & _
        "ubFamilia = @SubFamilia, Max_Descuento = @Max_Descuento, Tipo_Cambio_ValorCompra" & _
        " = @Tipo_Cambio_ValorCompra, Cod_MonedaVenta = @Cod_MonedaVenta, CodArticulo = @" & _
        "CodArticulo WHERE (Numero = @Original_Numero) AND (Cantidad = @Original_Cantidad" & _
        ") AND (CodArticulo = @Original_CodArticulo) AND (Cod_MonedaVenta = @Original_Cod" & _
        "_MonedaVenta) AND (Codigo = @Original_Codigo) AND (Cotizacion = @Original_Cotiza" & _
        "cion) AND (Descripcion = @Original_Descripcion) AND (Descuento = @Original_Descu" & _
        "ento) AND (Impuesto = @Original_Impuesto) AND (Max_Descuento = @Original_Max_Des" & _
        "cuento) AND (Monto_Descuento = @Original_Monto_Descuento) AND (Monto_Impuesto = " & _
        "@Original_Monto_Impuesto) AND (Precio_Base = @Original_Precio_Base) AND (Precio_" & _
        "Costo = @Original_Precio_Costo) AND (Precio_Flete = @Original_Precio_Flete) AND " & _
        "(Precio_Otros = @Original_Precio_Otros) AND (Precio_Unit = @Original_Precio_Unit" & _
        ") AND (SubFamilia = @Original_SubFamilia) AND (SubTotal = @Original_SubTotal) AN" & _
        "D (SubTotalExcento = @Original_SubTotalExcento) AND (SubtotalGravado = @Original" & _
        "_SubtotalGravado) AND (Tipo_Cambio_ValorCompra = @Original_Tipo_Cambio_ValorComp" & _
        "ra); SELECT Numero, Cotizacion, Codigo, Descripcion, Cantidad, Precio_Costo, Pre" & _
        "cio_Base, Precio_Flete, Precio_Otros, Precio_Unit, Descuento, Monto_Descuento, I" & _
        "mpuesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, SubFamilia," & _
        " Max_Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, CodArticulo FROM Cotiz" & _
        "acion_Detalle WHERE (Numero = @Numero)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubFamilia", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(451, 472)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 13)
        Me.Label48.TabIndex = 190
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 472)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(738, 16)
        Me.StatusBar1.TabIndex = 193
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Text = "Fecha"
        Me.StatusBarPanel1.Width = 35
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Width = 130
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Text = "Vence"
        Me.StatusBarPanel3.Width = 36
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Width = 70
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel5.Width = 451
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Panel1.Controls.Add(Me.txtDiasPlazo)
        Me.Panel1.Controls.Add(Me.opCredito)
        Me.Panel1.Controls.Add(Me.opContado)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(528, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 16)
        Me.Panel1.TabIndex = 194
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(178, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 12)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "días"
        Me.Label7.Visible = False
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
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM Lotes WHERE (Id = @Original_Id) AND (Cant_Actual = @Original_Cant_Act" & _
        "ual) AND (Cod_Articulo = @Original_Cod_Articulo) AND (Numero = @Original_Numero)" & _
        " AND (Vencimiento = @Original_Vencimiento)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO Lotes(Numero, Vencimiento, Cant_Actual, Cod_Articulo) VALUES (@Numero" & _
        ", @Vencimiento, @Cant_Actual, @Cod_Articulo); SELECT Id, Numero, Vencimiento, Ca" & _
        "nt_Actual, Cod_Articulo FROM Lotes WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Actual, Cod_Articulo FROM Lotes"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE Lotes SET Numero = @Numero, Vencimiento = @Vencimiento, Cant_Actual = @Can" & _
        "t_Actual, Cod_Articulo = @Cod_Articulo WHERE (Id = @Original_Id) AND (Cant_Actua" & _
        "l = @Original_Cant_Actual) AND (Cod_Articulo = @Original_Cod_Articulo) AND (Nume" & _
        "ro = @Original_Numero) AND (Vencimiento = @Original_Vencimiento); SELECT Id, Num" & _
        "ero, Vencimiento, Cant_Actual, Cod_Articulo FROM Lotes WHERE (Id = @Id)"
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'LAnulada
        '
        Me.LAnulada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LAnulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnulada.ForeColor = System.Drawing.Color.Red
        Me.LAnulada.Location = New System.Drawing.Point(632, 448)
        Me.LAnulada.Name = "LAnulada"
        Me.LAnulada.Size = New System.Drawing.Size(96, 16)
        Me.LAnulada.TabIndex = 196
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
        Me.txtHecho.Location = New System.Drawing.Point(456, 456)
        Me.txtHecho.Name = "txtHecho"
        Me.txtHecho.ReadOnly = True
        Me.txtHecho.Size = New System.Drawing.Size(168, 13)
        Me.txtHecho.TabIndex = 198
        Me.txtHecho.Text = ""
        '
        'Adapter_Configuraciones
        '
        Me.Adapter_Configuraciones.DeleteCommand = Me.SqlDeleteCommand8
        Me.Adapter_Configuraciones.InsertCommand = Me.SqlInsertCommand9
        Me.Adapter_Configuraciones.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Configuraciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("Tel_01", "Tel_01"), New System.Data.Common.DataColumnMapping("Tel_02", "Tel_02"), New System.Data.Common.DataColumnMapping("Fax_01", "Fax_01"), New System.Data.Common.DataColumnMapping("Fax_02", "Fax_02"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Frase", "Frase"), New System.Data.Common.DataColumnMapping("Cajeros", "Cajeros"), New System.Data.Common.DataColumnMapping("Logo", "Logo"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("UnicoConsecutivo", "UnicoConsecutivo"), New System.Data.Common.DataColumnMapping("NumeroConsecutivo", "NumeroConsecutivo"), New System.Data.Common.DataColumnMapping("ConsContado", "ConsContado"), New System.Data.Common.DataColumnMapping("NumeroContado", "NumeroContado"), New System.Data.Common.DataColumnMapping("ConsCredito", "ConsCredito"), New System.Data.Common.DataColumnMapping("NumeroCredito", "NumeroCredito"), New System.Data.Common.DataColumnMapping("ConsPuntoVenta", "ConsPuntoVenta"), New System.Data.Common.DataColumnMapping("NumeroPuntoVenta", "NumeroPuntoVenta"), New System.Data.Common.DataColumnMapping("Taller", "Taller"), New System.Data.Common.DataColumnMapping("TallerContado", "TallerContado"), New System.Data.Common.DataColumnMapping("TallerCredito", "TallerCredito"), New System.Data.Common.DataColumnMapping("Imprimir_en_Factura_Personalizada", "Imprimir_en_Factura_Personalizada"), New System.Data.Common.DataColumnMapping("FormatoCheck", "FormatoCheck"), New System.Data.Common.DataColumnMapping("Contabilidad", "Contabilidad"), New System.Data.Common.DataColumnMapping("CambiaPrecioCredito", "CambiaPrecioCredito"), New System.Data.Common.DataColumnMapping("Mascotas", "Mascotas"), New System.Data.Common.DataColumnMapping("MascotasContado", "MascotasContado"), New System.Data.Common.DataColumnMapping("MascotasCredito", "MascotasCredito")})})
        Me.Adapter_Configuraciones.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM configuraciones WHERE (Cedula = @Original_Cedula) AND (Cajeros = @Ori" & _
        "ginal_Cajeros) AND (CambiaPrecioCredito = @Original_CambiaPrecioCredito) AND (Co" & _
        "nsContado = @Original_ConsContado) AND (ConsCredito = @Original_ConsCredito) AND" & _
        " (ConsPuntoVenta = @Original_ConsPuntoVenta) AND (Contabilidad = @Original_Conta" & _
        "bilidad) AND (Direccion = @Original_Direccion) AND (Empresa = @Original_Empresa)" & _
        " AND (Fax_01 = @Original_Fax_01) AND (Fax_02 = @Original_Fax_02) AND (FormatoChe" & _
        "ck = @Original_FormatoCheck) AND (Frase = @Original_Frase) AND (Imp_Venta = @Ori" & _
        "ginal_Imp_Venta) AND (Imprimir_en_Factura_Personalizada = @Original_Imprimir_en_" & _
        "Factura_Personalizada) AND (Intereses = @Original_Intereses) AND (Mascotas = @Or" & _
        "iginal_Mascotas) AND (MascotasContado = @Original_MascotasContado) AND (Mascotas" & _
        "Credito = @Original_MascotasCredito) AND (NumeroConsecutivo = @Original_NumeroCo" & _
        "nsecutivo) AND (NumeroContado = @Original_NumeroContado) AND (NumeroCredito = @O" & _
        "riginal_NumeroCredito) AND (NumeroPuntoVenta = @Original_NumeroPuntoVenta) AND (" & _
        "Taller = @Original_Taller) AND (TallerContado = @Original_TallerContado) AND (Ta" & _
        "llerCredito = @Original_TallerCredito) AND (Tel_01 = @Original_Tel_01) AND (Tel_" & _
        "02 = @Original_Tel_02) AND (UnicoConsecutivo = @Original_UnicoConsecutivo)"
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cajeros", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajeros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiaPrecioCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsContado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsPuntoVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormatoCheck", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormatoCheck", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imprimir_en_Factura_Personalizada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MascotasContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MascotasCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroConsecutivo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPuntoVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TallerContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TallerCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnicoConsecutivo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO configuraciones(Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Dire" & _
        "ccion, Imp_Venta, Frase, Cajeros, Logo, Intereses, UnicoConsecutivo, NumeroConse" & _
        "cutivo, ConsContado, NumeroContado, ConsCredito, NumeroCredito, ConsPuntoVenta, " & _
        "NumeroPuntoVenta, Taller, TallerContado, TallerCredito, Imprimir_en_Factura_Pers" & _
        "onalizada, FormatoCheck, Contabilidad, CambiaPrecioCredito, Mascotas, MascotasCo" & _
        "ntado, MascotasCredito) VALUES (@Cedula, @Empresa, @Tel_01, @Tel_02, @Fax_01, @F" & _
        "ax_02, @Direccion, @Imp_Venta, @Frase, @Cajeros, @Logo, @Intereses, @UnicoConsec" & _
        "utivo, @NumeroConsecutivo, @ConsContado, @NumeroContado, @ConsCredito, @NumeroCr" & _
        "edito, @ConsPuntoVenta, @NumeroPuntoVenta, @Taller, @TallerContado, @TallerCredi" & _
        "to, @Imprimir_en_Factura_Personalizada, @FormatoCheck, @Contabilidad, @CambiaPre" & _
        "cioCredito, @Mascotas, @MascotasContado, @MascotasCredito); SELECT Cedula, Empre" & _
        "sa, Tel_01, Tel_02, Fax_01, Fax_02, Direccion, Imp_Venta, Frase, Cajeros, Logo, " & _
        "Intereses, UnicoConsecutivo, NumeroConsecutivo, ConsContado, NumeroContado, Cons" & _
        "Credito, NumeroCredito, ConsPuntoVenta, NumeroPuntoVenta, Taller, TallerContado," & _
        " TallerCredito, Imprimir_en_Factura_Personalizada, FormatoCheck, Contabilidad, C" & _
        "ambiaPrecioCredito, Mascotas, MascotasContado, MascotasCredito FROM configuracio" & _
        "nes WHERE (Cedula = @Cedula)"
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 4, "Cajeros"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, "UnicoConsecutivo"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, "NumeroConsecutivo"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 1, "ConsContado"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 8, "NumeroContado"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 1, "ConsCredito"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 8, "NumeroCredito"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, "ConsPuntoVenta"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, "NumeroPuntoVenta"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 8, "TallerContado"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 8, "TallerCredito"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, "Imprimir_en_Factura_Personalizada"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 1, "Contabilidad"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, "CambiaPrecioCredito"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 8, "MascotasContado"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 8, "MascotasCredito"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Direccion, Imp_Venta, Fra" & _
        "se, Cajeros, Logo, Intereses, UnicoConsecutivo, NumeroConsecutivo, ConsContado, " & _
        "NumeroContado, ConsCredito, NumeroCredito, ConsPuntoVenta, NumeroPuntoVenta, Tal" & _
        "ler, TallerContado, TallerCredito, Imprimir_en_Factura_Personalizada, FormatoChe" & _
        "ck, Contabilidad, CambiaPrecioCredito, Mascotas, MascotasContado, MascotasCredit" & _
        "o FROM configuraciones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE configuraciones SET Cedula = @Cedula, Empresa = @Empresa, Tel_01 = @Tel_01" & _
        ", Tel_02 = @Tel_02, Fax_01 = @Fax_01, Fax_02 = @Fax_02, Direccion = @Direccion, " & _
        "Imp_Venta = @Imp_Venta, Frase = @Frase, Cajeros = @Cajeros, Logo = @Logo, Intere" & _
        "ses = @Intereses, UnicoConsecutivo = @UnicoConsecutivo, NumeroConsecutivo = @Num" & _
        "eroConsecutivo, ConsContado = @ConsContado, NumeroContado = @NumeroContado, Cons" & _
        "Credito = @ConsCredito, NumeroCredito = @NumeroCredito, ConsPuntoVenta = @ConsPu" & _
        "ntoVenta, NumeroPuntoVenta = @NumeroPuntoVenta, Taller = @Taller, TallerContado " & _
        "= @TallerContado, TallerCredito = @TallerCredito, Imprimir_en_Factura_Personaliz" & _
        "ada = @Imprimir_en_Factura_Personalizada, FormatoCheck = @FormatoCheck, Contabil" & _
        "idad = @Contabilidad, CambiaPrecioCredito = @CambiaPrecioCredito, Mascotas = @Ma" & _
        "scotas, MascotasContado = @MascotasContado, MascotasCredito = @MascotasCredito W" & _
        "HERE (Cedula = @Original_Cedula) AND (Cajeros = @Original_Cajeros) AND (CambiaPr" & _
        "ecioCredito = @Original_CambiaPrecioCredito) AND (ConsContado = @Original_ConsCo" & _
        "ntado) AND (ConsCredito = @Original_ConsCredito) AND (ConsPuntoVenta = @Original" & _
        "_ConsPuntoVenta) AND (Contabilidad = @Original_Contabilidad) AND (Direccion = @O" & _
        "riginal_Direccion) AND (Empresa = @Original_Empresa) AND (Fax_01 = @Original_Fax" & _
        "_01) AND (Fax_02 = @Original_Fax_02) AND (FormatoCheck = @Original_FormatoCheck)" & _
        " AND (Frase = @Original_Frase) AND (Imp_Venta = @Original_Imp_Venta) AND (Imprim" & _
        "ir_en_Factura_Personalizada = @Original_Imprimir_en_Factura_Personalizada) AND (" & _
        "Intereses = @Original_Intereses) AND (Mascotas = @Original_Mascotas) AND (Mascot" & _
        "asContado = @Original_MascotasContado) AND (MascotasCredito = @Original_Mascotas" & _
        "Credito) AND (NumeroConsecutivo = @Original_NumeroConsecutivo) AND (NumeroContad" & _
        "o = @Original_NumeroContado) AND (NumeroCredito = @Original_NumeroCredito) AND (" & _
        "NumeroPuntoVenta = @Original_NumeroPuntoVenta) AND (Taller = @Original_Taller) A" & _
        "ND (TallerContado = @Original_TallerContado) AND (TallerCredito = @Original_Tall" & _
        "erCredito) AND (Tel_01 = @Original_Tel_01) AND (Tel_02 = @Original_Tel_02) AND (" & _
        "UnicoConsecutivo = @Original_UnicoConsecutivo); SELECT Cedula, Empresa, Tel_01, " & _
        "Tel_02, Fax_01, Fax_02, Direccion, Imp_Venta, Frase, Cajeros, Logo, Intereses, U" & _
        "nicoConsecutivo, NumeroConsecutivo, ConsContado, NumeroContado, ConsCredito, Num" & _
        "eroCredito, ConsPuntoVenta, NumeroPuntoVenta, Taller, TallerContado, TallerCredi" & _
        "to, Imprimir_en_Factura_Personalizada, FormatoCheck, Contabilidad, CambiaPrecioC" & _
        "redito, Mascotas, MascotasContado, MascotasCredito FROM configuraciones WHERE (C" & _
        "edula = @Cedula)"
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 4, "Cajeros"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, "UnicoConsecutivo"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, "NumeroConsecutivo"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 1, "ConsContado"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 8, "NumeroContado"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 1, "ConsCredito"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 8, "NumeroCredito"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, "ConsPuntoVenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, "NumeroPuntoVenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 8, "TallerContado"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 8, "TallerCredito"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, "Imprimir_en_Factura_Personalizada"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 1, "Contabilidad"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, "CambiaPrecioCredito"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 8, "MascotasContado"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 8, "MascotasCredito"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cajeros", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajeros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiaPrecioCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsContado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsPuntoVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormatoCheck", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormatoCheck", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imprimir_en_Factura_Personalizada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MascotasContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MascotasCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroConsecutivo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPuntoVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TallerContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerContado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TallerCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnicoConsecutivo", System.Data.DataRowVersion.Original, Nothing))
        '
        'ModificaFacturacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 488)
        Me.Controls.Add(Me.txtHecho)
        Me.Controls.Add(Me.LAnulada)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.DtVence)
        Me.Controls.Add(Me.CkEntregado)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Txt_TipoCambio_Valor_Compra)
        Me.Controls.Add(Me.Txtcodmoneda_Venta)
        Me.Controls.Add(Me.TxtprecioCosto)
        Me.Controls.Add(Me.txtFlete)
        Me.Controls.Add(Me.txtSGravado)
        Me.Controls.Add(Me.TxtMaxdescuento)
        Me.Controls.Add(Me.txtmontodescuento)
        Me.Controls.Add(Me.txtMontoImpuesto)
        Me.Controls.Add(Me.txtOtros)
        Me.Controls.Add(Me.txtSubFamilia)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(744, 500)
        Me.Name = "ModificaFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Facturación"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txtCod_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Facturaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Ck_Exonerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Ck_Mascotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_Taller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub ModificaFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Adapter_Configuraciones.Fill(DataSet_Facturaciones, "configuraciones")
            Adapter_Moneda.Fill(DataSet_Facturaciones, "Moneda")
            Adapter_Usuarios.Fill(DataSet_Facturaciones, "Usuarios")
            AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")
            ValoresDefecto()
            opContado.Checked = True
            bindings()
            logeado = False
            AgregandoNuevoItem = True
            CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True)

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ValoresDefecto()
        DataSet_Facturaciones.Ventas.IdColumn.AutoIncrement = True
        DataSet_Facturaciones.Ventas.IdColumn.AutoIncrementSeed = -1
        DataSet_Facturaciones.Ventas.IdColumn.AutoIncrementStep = -1

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
        DataSet_Facturaciones.Ventas_Detalle.CantVetColumn.DefaultValue = "0"
        DataSet_Facturaciones.Ventas_Detalle.CantBodColumn.DefaultValue = "0"
    End Sub

    Private Sub bindings()
        TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Tipo"))
        Lb_Subgravado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.SubtotalGravada"))
        Lb_SubExento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.SubTotalExento"))
        Label46.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Transporte"))
        txtEncargado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Cod_Encargado_Compra"))
        txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Num_Factura"))
        txtMontoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Monto_Impuesto"))
        txtSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubTotal"))
        txtImpVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Impuesto"))
        TxtMaxdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Max_Descuento"))
        txtPrecioUnit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Unit"))
        txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Cantidad"))
        txtNombreArt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Descripcion"))
        txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Codigo"))
        txtCod_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.CodArticulo"))
        txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Descuento"))
        txtOtros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Otros"))
        txtFlete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Flete"))
        Txtcodmoneda_Venta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Cod_MonedaVenta"))
        Txt_TipoCambio_Valor_Compra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Tipo_Cambio_ValorCompra"))
        txtCostoBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Base"))
        txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Total"))
        txtImpVentaT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Imp_Venta"))
        txtDescuentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.Descuento"))
        txtSubtotalT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Facturaciones, "Ventas.SubTotal"))
        txtSGravado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubtotalGravado"))
        txtSExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubTotalExcento"))
        CkEntregado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Entregado"))
        CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Facturaciones, "Ventas.Anulado"))
        txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Telefono"))
        Txtdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Direccion"))
        txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Cod_Cliente"))
        txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Nombre_Cliente"))
        TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Observaciones"))
        TxtprecioCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Precio_Costo"))
        txtmontodescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.Monto_Descuento"))
        ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Facturaciones, "Ventas.Moneda_Nombre"))
        dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Fecha"))
        txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Moneda.ValorCompra"))
        txtorden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Orden"))
        DtVence.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Vence"))
        txtSubtotalExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle.SubTotalExcento"))
    End Sub
#End Region

#Region "Funciones de Formulario"
    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then
            Exit Sub
        End If

        If Not Me.buscando And Me.txtNombreArt.Text <> "" Then
            Buscar_datos_articulo(Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo"))
        End If
        TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
    End Sub

    Private Sub Current_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then
            Me.SimpleButton3.Enabled = True
        Else
            Me.SimpleButton3.Enabled = False
        End If
    End Sub
#End Region

    Private Sub Buscar_datos_articulo(ByVal codigo As String)
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean


        If codigo <> Nothing Then
            sqlConexion = CConexion.Conectar

            If Not IsNumeric(codigo) Then
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & codigo & "'")
            Else
                Dim a() As String = codigo.Split(".")
                If a.Length > 1 Then
                    rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & codigo & "'")
                Else
                    rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Codigo ='" & codigo & "' or Barras = '" & codigo & "'")
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

                    Else
                        Me.promo_activa_valor = False ' se habilita el text
                        Me.txtDescuento.Enabled = True
                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End While
            rs.Close()
            If Not Encontrado Then
                MsgBox("No existe un artìculo con este código", MsgBoxStyle.Exclamation)
                txtCodArticulo.Text = "0"
                txtCod_Articulo.Text = "0"
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                Me.txtCod_Articulo.Focus()
                CConexion.DesConectar(CConexion.sQlconexion)
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
                If Me.promo_activa_valor Then ' si el articulo esta actualmente en promoción 
                    Me.precio_unitario = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)
                    Exit Sub
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

    Private Sub Loggin_Usuario()
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
                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                    ToolBarBuscar.Enabled = True
                    ToolBarRegistrar.Enabled = False
                    ToolBarAnular.Enabled = False
                    ToolBarImprimir.Enabled = False
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
                    Nueva_Factura()

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
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas...", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If

                    txtHecho.Text = ""
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
        If e.KeyCode = Keys.Enter Then If Not logeado Then Loggin_Usuario() Else Me.Reloggin_Usuario()
    End Sub

    Private Sub Nueva_Factura()
        Try
            Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            Me.DataSet_Facturaciones.Ventas.Clear()

            Me.DataSet_Facturaciones.Cotizacion_Detalle.Clear()
            Me.DataSet_Facturaciones.Cotizacion.Clear()

            Me.Label41.Visible = False
            Me.txtEncargado.Visible = False
            Me.txtDiasPlazo.Visible = False
            Me.Label7.Visible = False
            CbNumero.Items.Clear()


            Me.DataSet_Facturaciones.Ventas.FechaColumn.DefaultValue = Date.Now
            Me.DataSet_Facturaciones.Ventas.VenceColumn.DefaultValue = Date.Now
            Me.opContado.Checked = True
            opCredito.Enabled = False
            Me.impuesto_cliente = 100
            Me.tipoprecio = 1
            Me.ComboBox1.SelectedIndex = 0

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
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Verificar_Consecutivos(ByVal PVE As Boolean)
        Try
            If Me.buscando Then Exit Sub
            Dim func As New Conexion
            Dim Configuracion As System.Data.DataRow
            Configuracion = Me.DataSet_Facturaciones.configuraciones.Rows(0)

            If Configuracion("UnicoConsecutivo") = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas")
                If CInt(txtFactura.Text) < Configuracion("NumeroConsecutivo") Then
                    txtFactura.Text = Configuracion("NumeroConsecutivo")
                End If
                Exit Sub
            End If

            If Configuracion("Taller") = True And opContado.Checked = True And Ck_Taller.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'TCO')")
                If CInt(txtFactura.Text) < Configuracion("TallerContado") Then
                    txtFactura.Text = Configuracion("TallerContado")
                End If
                TxtTipo.Text = "TCO"
                Exit Sub
            End If

            If Configuracion("Taller") = True And opCredito.Checked = True And Ck_Taller.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'TCR')")
                If CInt(txtFactura.Text) < Configuracion("TallerCredito") Then
                    txtFactura.Text = Configuracion("TallerCredito")
                End If
                TxtTipo.Text = "TCR"
                Exit Sub
            End If
            ''--------------- Consecutivo Mascotas------------
            If Configuracion("Mascotas") = True And opContado.Checked = True And Ck_Mascotas.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'MCO')")
                If CInt(txtFactura.Text) < Configuracion("MascotasContado") Then
                    txtFactura.Text = Configuracion("MascotasContado")
                End If
                TxtTipo.Text = "MCO"
                Exit Sub
            End If

            If Configuracion("Mascotas") = True And opCredito.Checked = True And Ck_Mascotas.Checked = True Then
                txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'MCR')")
                If CInt(txtFactura.Text) < Configuracion("MascotasCredito") Then
                    txtFactura.Text = Configuracion("MascotasCredito")
                End If
                TxtTipo.Text = "MCR"
                Exit Sub
            End If
            ''-------------------------------------------------

            If Configuracion("ConsPuntoVenta") = True And PVE = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'PVE')")
                If CInt(txtFactura.Text) < Configuracion("NumeroPuntoVenta") Then
                    txtFactura.Text = Configuracion("NumeroPuntoVenta")
                End If
                TxtTipo.Text = "PVE"
                Exit Sub
            End If

            If Configuracion("ConsContado") = True And opContado.Checked = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'CON')")
                If CInt(txtFactura.Text) < Configuracion("NumeroContado") Then
                    txtFactura.Text = Configuracion("NumeroContado")
                End If
                TxtTipo.Text = "CON"
                Exit Sub
            End If

            If Configuracion("ConsCredito") = True And Me.opCredito.Checked = True Then
                Me.txtFactura.Text = func.SQLExeScalar("SELECT ISNULL(MAX(Num_Factura), 0) + 1 AS Num_Nueva_Factura FROM Ventas WHERE (Tipo = 'CRE')")
                If CInt(txtFactura.Text) < Configuracion("NumeroCredito") Then
                    txtFactura.Text = Configuracion("NumeroCredito")
                End If
                TxtTipo.Text = "CRE"
                Exit Sub
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ImprimirFactura()
        Try
            Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id") ' se envia  aimprimir la factura actual
            Me.ToolBar1.Buttons(4).Enabled = False

            If (MsgBox("Desea Imprimir en Punto Venta?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                Imprimir(id, True)
            Else
                Imprimir(id, False)
            End If

            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 'NuevaEntrada()
            Case 2 : If PMU.Find Then BuscarFactura() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar(False) Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then ImprimirFactura() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 'BuscarCotizacion_importar()
            Case 7 : If MessageBox.Show("¿Desea Cerrar el Módulo de Facturación?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub

    Private Sub recargar_Cliente()
        Dim rsm As SqlDataReader
        Dim cambio As Double
        Dim cod_mod As Integer
        sqlConexion = CConexion.Conectar

        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow

        Dim codigo As Integer '= Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
        codigo = Me.txtCodigo.Text

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
                    Me.opCredito.Enabled = False
                    Me.opContado.Enabled = False
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

    Private Sub BuscarFactura()
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
            LAnulada.Visible = False
            txtHecho.Text = ""

            Dim identificador As Double

            Dim Fx As New cFunciones
            'LLamo a la funcion Buscar_X_Descripcion_Fecha1 para buscar por nombre del documento y por 
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id, Nombre_Cliente AS [Nombre del Cliente], cast(num_factura as varchar) + '-' + TIPO As Factura,Fecha,Total  from Ventas Order by Id DESC", "[Nombre del Cliente]", "Fecha", "Buscar Factura de Venta"))

            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            LlenarVentas(identificador)

            GroupBox6.Enabled = True
            GroupBox3.Enabled = True
            Ck_Exonerar.Enabled = True
            txtorden.Enabled = True
            ToolBar1.Buttons(2).Enabled = True
            If usua.Anu_Venta = True Then ToolBar1.Buttons(3).Enabled = True
            If CheckBox1.Checked = True Then ToolBarAnular.Text = "DesAnular" Else ToolBarAnular.Text = "Anular"
            Ck_Taller.Enabled = False
            Ck_Mascotas.Enabled = False

            If CheckBox1.Checked Then
                LAnulada.Visible = True
            Else
                LAnulada.Visible = False
            End If

            Dim i As Integer

            For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones.Ventas_Detalle).Count - 1 ' busca si en el detalle de la factura existen devolucines
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
                If (Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Devoluciones")) <> 0 Then
                    MsgBox("Esta Factura no puede ser anulada, porque tiene devoluciones", MsgBoxStyle.Information)
                    ToolBar1.Buttons(3).Enabled = False
                    Exit For
                End If
            Next

            HechoPor()
            ToolBar1.Buttons(4).Enabled = True
            opContado.Enabled = False
            opCredito.Enabled = False
            txtorden.Enabled = True
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub Cargar_Cliente(ByVal Id As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Clientes WHERE (identificacion = @Id_Factura) "

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
            dv.Fill(Me.DataSet_Facturaciones, "Clientes")

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


    Private Sub LlenarVentas(ByVal Id As Double)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Ventas WHERE (Id = @Id_Factura) "

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

            If TxtTipo.Text = "CON" Or TxtTipo.Text = "PVE" Or TxtTipo.Text = "TCO" Then
                Me.opContado.Checked = True
                Me.opCredito.Checked = False
            Else
                Me.opCredito.Checked = True
                Me.opContado.Checked = False
            End If

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
            sel = "SELECT * FROM Ventas_Detalle WHERE (Id_Factura = @Id_Factura) "

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
        Try
            If usua.Anu_Venta = False Then
                MsgBox("Usted no tiene permisos de anular ventas", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim resp As Integer
            Dim Accion As String
            If CheckBox1.Checked Then
                Accion = "Desanular"
            Else
                Accion = "Anular"
            End If

            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Count > 0 Then

                resp = MessageBox.Show("¿Desea " & Accion & " esta Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    If CheckBox1.Checked Then
                        CheckBox1.Checked = False
                    Else
                        CheckBox1.Checked = True
                    End If
                    BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()

                    If insertar_bitacora() And Registrar_Anulacion_Venta() Then

                        Me.DataSet_Facturaciones.AcceptChanges()
                        MsgBox("La Factura ha sido " & Accion & " correctamente!", MsgBoxStyle.Information)
                        Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                        Me.DataSet_Facturaciones.Ventas.Clear()

                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = False
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
                        Me.txtorden.Enabled = False
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
        Dim datos, FormaPago, Accion, Tipo As String

        If CheckBox1.Checked = True Then
            FormaPago = "ANU"
            Accion = "ANULADA"
        Else
            FormaPago = "EFE"
            Accion = "DESANULADA"
        End If

        'If Ck_Taller.Checked = True Then
        '    Tipo = "FVT"
        'ElseIf TxtTipo.Text = "PVE" Then
        '    Tipo = "FVP"
        'Else
        '    Tipo = "FVC"
        'End If
        If Ck_Taller.Checked = True Then
            Tipo = "FVT"
        ElseIf Ck_Mascotas.Checked = True Then
            Tipo = "FVM"
        ElseIf TxtTipo.Text = "PVE" Then
            Tipo = "FVP"
        Else
            Tipo = "FVC"
        End If


        datos = "'MODIFICA FACTURA','" & Me.txtFactura.Text & "-" & TxtTipo.Text & "','" & Me.txtNombre.Text & "','FACTURA DE VENTA " & Accion & "','" & usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
        If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" And funciones.UpdateRecords("OpcionesDePago", "FormaPago = '" & FormaPago & "'", "(Documento = " & txtFactura.Text & ") AND (TipoDocumento = '" & Tipo & "')") <> "" Then
            MsgBox("Problemas al Anular la venta", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Function insertar_bitacora_Modifica() As Boolean
        Dim funciones As New Conexion
        Dim datos As String

        datos = "'MODIFICA FACTURA','" & Me.txtFactura.Text & "-" & TxtTipo.Text & "','" & Me.txtNombre.Text & "','FACTURA DE VENTA MODIFICADA','" & usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
        If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
            MsgBox("Problemas al actualizar la venta", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Function Registrar_Anulacion_Venta() As Boolean
        Dim Cx As New Conexion
        Try
            Cx.UpdateRecords("Ventas", "Anulado = " & CheckBox1.CheckState, "Id = " & BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id"), "SeePos")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    Private Sub Registrar(ByVal PV As Boolean)
        Try
            Me.ToolBar1.Buttons(2).Enabled = False

            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then 'Si la factura no tiene detalle
                MsgBox("No se Puede Registrar una venta si no contiene artículos", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = False
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                txtCod_Articulo.Focus()
                Exit Sub
            End If

            If MessageBox.Show("¿Desea Registrar esta Factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(2).Enabled = True
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                txtCod_Articulo.Focus()
                Exit Sub
            End If

            If opCredito.Checked Then
                Dim Firma As New Firma
                Firma.Cliente = BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
                Firma.ShowDialog()
                If Firma.DialogResult = DialogResult.OK Then
                    BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = Firma.Encargado
                Else
                    Exit Sub
                End If
                Firma.Dispose()
            Else
                BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = "NINGUNO"
            End If

            BindingContext(DataSet_Facturaciones, "Ventas").Current("pagoImpuesto") = impuesto_cliente
            BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            'Verificar_Consecutivos(Not PV)
            BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            If insertar_bitacora_Modifica() And RegistrarVenta() Then 'se registra en la base de datos then

                Me.DataSet_Facturaciones.AcceptChanges()

                If coti = True Then
                    Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Venta") = True
                    Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").EndCurrentEdit()
                    Me.Adapter_Coti.Update(Me.DataSet_Facturaciones, "Cotizacion")
                    coti = False
                End If


                Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id")

                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = False


                Me.SimpleButton1.Enabled = False
                Me.SimpleButton2.Enabled = False

                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                ToolBarRegistrar.Enabled = False
                LAnulada.Visible = False
                txtHecho.Text = ""

                Me.GroupBox6.Enabled = False
                Me.GroupBox3.Enabled = False
                Me.txtorden.Enabled = False
                Me.Label10.Visible = False
                Me.Label11.Visible = False
                Me.Label_Costobase.Visible = False
                Me.ComboBox1.Enabled = False
                Ck_Exonerar.Enabled = False


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

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                'TipoImpresora(PV)
                'Imprimir(id)

                If buscando = True Then buscando = False

                Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
                Me.DataSet_Facturaciones.Ventas.Clear()
                DataSet_Facturaciones.Lotes.Clear()
                AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")

                Me.ToolBar1.Buttons(5).Enabled = False

            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True
            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function Registrar_SinRestricciones() As Boolean
        Try
            If Me.sinrestriccion Then
                Dim funciones As New Conexion
                Dim mens As String
                mens = funciones.UpdateRecords("Clientes", "sinrestriccion = 'NO'", "identificacion =" & Me.txtCodigo.Text)

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

    Function RegistrarVenta() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            Adapter_Ventas.SelectCommand.Transaction = Trans
            Adapter_Ventas.InsertCommand.Transaction = Trans
            Adapter_Ventas.UpdateCommand.Transaction = Trans
            Adapter_Ventas.DeleteCommand.Transaction = Trans

            Adapter_Ventas_Detalles.SelectCommand.Transaction = Trans
            Adapter_Ventas_Detalles.InsertCommand.Transaction = Trans
            Adapter_Ventas_Detalles.UpdateCommand.Transaction = Trans
            Adapter_Ventas_Detalles.DeleteCommand.Transaction = Trans

            Adapter_Ventas.Update(DataSet_Facturaciones, "Ventas")
            Adapter_Ventas_Detalles.Update(DataSet_Facturaciones.Ventas_Detalle)
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

    Private Sub Imprimir(ByVal Id_Factura As Double, ByVal PVE As Boolean)    'MOD SAJ 01092006
        Try
            If PVE Then
                facturaPVE.SetParameterValue(0, Id_Factura)
                facturaPVE.PrintOptions.PrinterName = Automatic_Printer_Dialog(3) 'PUNTO VENTA
                facturaPVE.PrintToPrinter(1, True, 0, 0)
            Else
                Imprime()
                'Factura_reporte.SetParameterValue(0, Id_Factura)
                'Factura_reporte.PrintOptions.PrinterName = Automatic_Printer_Dialog(0) 'FACTURACION
                'Factura_reporte.PrintToPrinter(1, True, 0, 0)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
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
        End If
    End Function

    Private Sub Imprime()
        Try
            Dim pd As New System.Drawing.Printing.PrintDocument
            pd.PrinterSettings.PrinterName = Automatic_Printer_Dialog(0) 'FACTURACION
            Cant = 0 : PaginaActual = 1
            AddHandler pd.PrintPage, AddressOf pd_PrintPage
            pd.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

            '-------------------------------------------------------------------------------
            'DEFINE CANTIDAD DE PAGINAS
            Doub = (DataSet_Facturaciones.Ventas_Detalle.Count / 10)
            If (Doub - Int(Doub)) <> 0 And (Doub - Int(Doub)) < 0.5 Then
                Paginas = Doub + 1
            Else
                Paginas = Doub
            End If
            '-------------------------------------------------------------------------------

            '-------------------------------------------------------------------------------
            '------------------------------ ENCABEZADO - ORA -------------------------------
            Dim Pagina As RectangleF = New RectangleF(600, 16, 100, 15) : ev.Graphics.DrawString("Pagina " & PaginaActual & " de " & Paginas, New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Pagina, New StringFormat)
            Dim XX As RectangleF = New RectangleF(580, 31, 150, 20) : ev.Graphics.DrawString("XXXXXXX", New System.Drawing.Font("Arial", 16, FontStyle.Bold), Brushes.Black, XX, New StringFormat)
            If DataSet_Facturaciones.Ventas(0).Tipo = "CRE" Or DataSet_Facturaciones.Ventas(0).Tipo = "TCR" Then
                Dim TipoCre As RectangleF = New RectangleF(304, 87, 50, 20) : ev.Graphics.DrawString("X", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, TipoCre, New StringFormat)
            Else
                Dim TipoCon As RectangleF = New RectangleF(304, 52, 50, 20) : ev.Graphics.DrawString("X", New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, TipoCon, New StringFormat)
            End If
            Dim Dia As RectangleF = New RectangleF(480, 85, 75, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Day, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Dia, Centrar)
            Dim Mes As RectangleF = New RectangleF(550, 85, 75, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Month, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Mes, Centrar)
            Dim Anno As RectangleF = New RectangleF(630, 85, 100, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Fecha.Year, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Anno, Centrar)
            Dim Hora As RectangleF = New RectangleF(540, 100, 100, 15) : ev.Graphics.DrawString(Format(DataSet_Facturaciones.Ventas(0).Fecha, "hh:mm:ss tt"), New System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, Hora, Centrar)
            Dim Factura As RectangleF = New RectangleF(70, 102, 400, 20) : ev.Graphics.DrawString("Fact. Nº " & DataSet_Facturaciones.Ventas(0).Num_Factura & " - " & DataSet_Facturaciones.Ventas(0).Tipo, New System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, Factura, Derecha)
            Dim Cliente As RectangleF = New RectangleF(45, 122, 400, 20) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Nombre_Cliente & " (" & DataSet_Facturaciones.Ventas(0).Cod_Cliente & ")", New System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, Cliente, New StringFormat)
            Dim Direccion As RectangleF = New RectangleF(70, 137, 400, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Direccion, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Direccion, New StringFormat)
            Vendedor = Func.SQLExeScalar("SELECT Nombre FROM Usuarios WHERE (Cedula = '" & DataSet_Facturaciones.Ventas(0).Cedula_Usuario & "')")
            Dim Atendido As RectangleF = New RectangleF(70, 154, 150, 15) : ev.Graphics.DrawString(Vendedor, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Atendido, New StringFormat)
            Dim Observaciones As RectangleF = New RectangleF(312, 154, 200, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Observaciones, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Observaciones, New StringFormat)
            'SI TIENE NUMERO DE ORDEN
            If DataSet_Facturaciones.Ventas(0).Orden > 0 Then
                Dim Orden As RectangleF = New RectangleF(535, 137, 90, 15) : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas(0).Orden, New System.Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, Orden, New StringFormat)
            End If
            'SI TIENE VENCIMIENTO
            If DataSet_Facturaciones.Ventas(0).Tipo = "CRE" Or DataSet_Facturaciones.Ventas(0).Tipo = "TCR" Then
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
            Dim Articulo As RectangleF = New RectangleF(187, Posicion, 294, 15) : Dim SubtotalDet As RectangleF = New RectangleF(630, Posicion, 100, 15)
            Dim DescuentoD As RectangleF = New RectangleF(555, Posicion, 75, 15) : Dim CantDet As RectangleF = New RectangleF(-15, Posicion, 70, 15)
            Dim PrecioUnit As RectangleF = New RectangleF(490, Posicion, 75, 15) : Dim Codigo As RectangleF = New RectangleF(90, Posicion, 90, 15)

            Can = IIf((DataSet_Facturaciones.Ventas_Detalle.Count - Cant) > 10, 10, DataSet_Facturaciones.Ventas_Detalle.Count - Cant)
            For x As Integer = 0 To Can - 1
                CantDet.Y = Posicion : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Cantidad, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, CantDet, Derecha)
                Codigo.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).CodArticulo, New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Codigo, Derecha)
                Articulo.Y = Posicion : ev.Graphics.DrawString(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Descripcion, New System.Drawing.Font("Arial", 9, FontStyle.Regular), Brushes.Black, Articulo, New StringFormat)
                PrecioUnit.Y = Posicion : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Precio_Unit, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, PrecioUnit, Derecha)
                DescuentoD.Y = Posicion : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).Descuento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoD, Derecha)
                SubtotalDet.Y = Posicion : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas_Detalle(x + Cant).SubTotal, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, SubtotalDet, Derecha)
                Posicion = Posicion + 20
            Next
            ''-------------------------------------------------------------------------------

            ''-------------------------------------------------------------------------------
            ''------------------------------ ULTIMA LINEA - ORA -----------------------------
            If (DataSet_Facturaciones.Ventas_Detalle.Count - Cant) <= 10 Then
                Dim MExento As RectangleF = New RectangleF(40, Posicion, 200, 15) : ev.Graphics.DrawString("(*) EXCENTO", New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, MExento, New StringFormat)
                Dim Ultima As RectangleF = New RectangleF(80, Posicion, 500, 15) : ev.Graphics.DrawString("= = = = > ULTIMA LINEA < = = = =", New System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, Ultima, Centrar)
                ev.HasMorePages = False 'NO IMPRIME MAS PAGINAS
            Else
                ev.HasMorePages = True  'MANDA A IMPRIMIR OTRA PAGINA
            End If
            ''------------------------------------------------------------------------------

            ''------------------------------------------------------------------------------
            ''-------------------------------- TOTALES - ORA -------------------------------
            If (DataSet_Facturaciones.Ventas_Detalle.Count - Cant) <= 10 Then
                Dim Gravado As RectangleF = New RectangleF(630, 404, 100, 17) : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas(0).SubTotalGravada, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Gravado, Derecha)
                Dim Exento As RectangleF = New RectangleF(630, 421, 100, 17) : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas(0).SubTotalExento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Exento, Derecha)
                Dim DescuentoM As RectangleF = New RectangleF(630, 438, 100, 17) : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas(0).Descuento, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoM, Derecha)
                Dim Impuesto As RectangleF = New RectangleF(630, 454, 100, 17) : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas(0).Imp_Venta, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Impuesto, Derecha)
                Dim Total As RectangleF = New RectangleF(630, 470, 100, 17) : ev.Graphics.DrawString(Format(Math.Round(DataSet_Facturaciones.Ventas(0).Total, 2), "#,##0.00"), New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Total, Derecha)
            Else
                Dim Gravado As RectangleF = New RectangleF(630, 404, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Gravado, Derecha)
                Dim Exento As RectangleF = New RectangleF(630, 421, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Exento, Derecha)
                Dim DescuentoM As RectangleF = New RectangleF(630, 438, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, DescuentoM, Derecha)
                Dim Impuesto As RectangleF = New RectangleF(630, 454, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Impuesto, Derecha)
                Dim Total As RectangleF = New RectangleF(630, 470, 100, 17) : ev.Graphics.DrawString("----------", New System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, Total, Derecha)
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

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            inicializar()
        End If
    End Sub

    Private Sub inicializar()
        Try
            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar la Moneda en la que se va a cotizar", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            GroupBox6.Enabled = True
            GroupBox1.Enabled = True
            dtFecha.Enabled = True
            DtVence.Enabled = True
            Ck_Exonerar.Enabled = PMU.Others
            Ck_Taller.Enabled = False
            Ck_Mascotas.Enabled = False

            ComboBox1.Enabled = False
            SimpleButton3.Enabled = True
            txtCodigo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Dim cFunciones As New cFunciones
                    Dim c As String
                    c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

                    If c <> "" Then
                        Me.txtCodigo.Text = c
                    Else
                        Exit Sub
                    End If

                    If Me.txtCodigo.Text <> "" And Me.txtCodigo.Text <> "0" Then
                        sqlConexion = CConexion.Conectar
                        ayuda = True
                        Me.Cargar_Cliente(CInt(txtCodigo.Text))
                        CargarInformacionCliente(txtCodigo.Text)
                    Else
                        Exit Sub
                    End If

                    If Me.GroupBox3.Enabled = False Then Me.iniciar_factura()
                    Me.txtCod_Articulo.Focus()

                Case Keys.Enter
                    Me.Cargar_Cliente(CInt(txtCodigo.Text))
                    enter_cod_cliente()
                    Me.txtCod_Articulo.SelectAll()
                    Application.DoEvents()
                    Me.txtCod_Articulo.Focus()

                Case Keys.F2
                    Me.Registrar(False)

                Case Keys.F3
                    Me.Registrar(True)

            End Select
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub enter_cod_cliente()
        Me.txtNombre.Text = ""
        Me.txtNombre.Enabled = True
        impuesto_cliente = 100

        If Me.txtCodigo.Text <> "" And Me.txtCodigo.Text <> "0" Then
            CargarInformacionCliente(txtCodigo.Text)
            If Me.GroupBox3.Enabled = False Then Me.iniciar_factura()
            Me.txtCod_Articulo.Focus()
        Else
            Me.txtNombre.Text = "CLIENTE CONTADO"
            Me.txtTelefono.Text = ""
            Me.Txtdireccion.Text = ""
            Me.txtCodigo.Text = "0"
            Me.opCredito.Checked = False
            Me.opContado.Checked = True
            Me.opCredito.Enabled = False
            Me.impuesto_cliente = 100
            Me.txtCod_Articulo.Focus()
            Exit Sub
        End If
        Me.txtCod_Articulo.Focus()
    End Sub


    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim rsm As SqlDataReader
        Dim cod_mod As Integer
        Dim cambio As Double


        sqlConexion = CConexion.Conectar
        If codigo <> Nothing Then

            rss = Me.DataSet_Facturaciones.Clientes.Select("Identificacion ='" & codigo & "'")

            If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

                Try
                    rs = rss(0)
                    txtCodigo.Text = rs("Identificacion")

                    ''''''''''''''''
                    txtNombre.Text = rs("nombre")
                    txtNombre.Enabled = False
                    Me.Txtdireccion.Text = rs("direccion")
                    Me.txtTelefono.Text = rs("Telefono_01")
                    cod_mod = rs("CodMonedaCredito")

                    If rs("abierto") = "NO" Then
                        opCredito.Enabled = False
                        opCredito.Checked = False
                        opContado.Checked = True
                    Else
                        opCredito.Enabled = False
                        opContado.Enabled = False
                        If Not Me.Importando Then Me.opContado.Checked = True
                        txtDiasPlazo.Enabled = True

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
                    impuesto_cliente = rs("impuesto")
                    'si actualmente esta cotizacion tiene artìculos
                    If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                        Me.recalcular_cotizacion_cambio_cliente()
                        MsgBox("Factura actualizada de acuerdo al cliente", MsgBoxStyle.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else ' si no se encontro el cliente

                MsgBox("No existe un cliente con ese código", MsgBoxStyle.Exclamation)
                Me.txtCodigo.Text = ""
                Me.txtTelefono.Text = ""
                Me.Txtdireccion.Text = ""
                Me.txtNombre.Text = "CLIENTE CONTADO"
                Me.txtCodigo.Focus()
                abierto = False
                sinrestriccion = False
                impuesto_cliente = 100
                max_credito = 0
                plazo_credito = 0
                descuento = 0
                tipoprecio = 1
                txtNombre.Enabled = True
                Me.opCredito.Enabled = False
                Me.opCredito.Checked = False
                Me.opContado.Checked = True
            End If


        Else 'se dio el boton de cancelar o no se selecciono ninguno

            Me.txtCodigo.Text = ""
            Me.txtTelefono.Text = ""
            Me.Txtdireccion.Text = ""
            Me.txtNombre.Text = "CLIENTE CONTADO"

            abierto = False
            sinrestriccion = False
            impuesto_cliente = 100
            max_credito = 0
            plazo_credito = 0
            descuento = 0
            tipoprecio = 1
            txtNombre.Enabled = True
        End If
    End Sub


    Private Sub recalcular_cotizacion_cambio_cliente()
        Dim i As Integer
        Try
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()

            If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
                For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i
                    Me.CargarInformacionArticulo(Me.txtCod_Articulo.Text, True)
                    Me.Calculos_Articulo() ' se calcula  de nuevo los datos del articulo cotizado

                    If mensaje <> "" Then
                        MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                        mensaje = ""
                    End If
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                Next

                Calcular_Totales_Cotizacion()
            End If

            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub recalcular_cotizacion(ByVal nuev_des)
        Dim i As Integer
        Try

            For i = 0 To Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1

                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = i

                Me.txtDescuento.Text = nuev_des

                Me.Calculos_Articulo() ' se calcula de nuevo los datos del articulo cotizado
                Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            Next

            Calcular_Totales_Cotizacion()
            MsgBox("Descuentos sobre artìculos han sido Actualizados", MsgBoxStyle.Information)

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub


    Private Sub txtorden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtorden.KeyDown
        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            iniciar_factura()
        End If

        If e.KeyCode = Keys.F2 Then
            Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Registrar(True)
        End If
    End Sub

    Private Sub iniciar_factura()
        Try
            Dim nom As String = Me.txtNombre.Text
            Dim orden As Double = txtorden.Text

            BindingContext(DataSet_Facturaciones, "Ventas").Current("Cod_Moneda") = Me.BindingContext(Me.DataSet_Facturaciones, "Moneda").Current("CodMoneda")
            BindingContext(DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario") = Me.Cedula_usuario
            BindingContext(DataSet_Facturaciones, "Ventas").Current("pagoImpuesto") = impuesto_cliente
            BindingContext(DataSet_Facturaciones, "Ventas").Current("Tipo_Cambio") = CDbl(txtTipoCambio.Text)
            txtNombre.Text = nom
            txtorden.Text = orden

            If txtCodigo.Text = "" Then
                txtCodigo.Text = "0"
            End If

            If BindingContext(DataSet_Facturaciones, "Ventas").Count = 1 Then
                BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()
                dias_credito()
            End If

            GridControl1.Enabled = True
            SimpleButton1.Enabled = True

            ToolBar1.Buttons(2).Enabled = True 'se activa el botond e guardar

            GroupBox3.Enabled = True
            If txtDescuento.Properties.ReadOnly = True Then txtDescuento.Properties.Enabled = False
            If txtPrecioUnit.Properties.ReadOnly = True Then txtPrecioUnit.Properties.Enabled = False

            GroupBox4.Enabled = True
            txtCod_Articulo.Focus()


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
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

    Private Sub txtCodArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod_Articulo.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Try
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()

                        Dim CodigoBuscador As String = BuscarF1()

                        If Not IsNothing(CodigoBuscador) And CodigoBuscador <> "0" And CodigoBuscador <> "0.00" Then
                            CargarInformacionArticulo(CodigoBuscador)
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                    End Try

                Case Keys.Enter
                    Try
                        If Me.txtCod_Articulo.Text = "" Or Me.txtCod_Articulo.Text = "0" Then Exit Sub
                        Dim cod_art As String
                        cod_art = Me.txtCod_Articulo.Text
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
                        CargarInformacionArticulo(cod_art)
                    Catch ex As SystemException
                        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                    End Try

                Case Keys.F2
                    Me.Registrar(False)

                Case Keys.F3
                    Me.Registrar(True)

                Case Keys.F5
                    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                    Me.password_antiguo = Me.txtUsuario.Text
                    Me.txtUsuario.Text = ""
                    Me.txtUsuario.Enabled = True
                    Me.txtNombreUsuario.Text = ""
                    Me.GroupBox3.Enabled = False
                    txtorden.Enabled = False
                    Me.txtUsuario.Focus()

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


    Private Sub CargarInformacionArticulo(ByVal codigo As String, Optional ByVal recargar As Boolean = False)
        Try
            Dim rs As SqlDataReader
            Dim Encontrado As Boolean
            Me.Lote = False
            Me.LOpcion.Text = "Opcion"
            Me.CbNumero.Enabled = False
            Me.LFVencimiento.Text = ""

            If codigo <> Nothing Or codigo <> "" Then
                sqlConexion = CConexion.Conectar

                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "'")
                Encontrado = False

                While rs.Read
                    Try
                        Encontrado = True
                        txtCodArticulo.Text = rs("Codigo")
                        txtCod_Articulo.Text = rs("Cod_Articulo")
                        Me.AgregandoNuevoItem = True

                        If Excento(CDbl(txtCodArticulo.Text)) = True Then
                            txtNombreArt.Text = "*  " & rs("Descripcion")
                        Else
                            txtNombreArt.Text = rs("Descripcion")
                        End If

                        If Ck_Exonerar.Checked Then
                            txtImpVenta.Text = Format(0, "#,#0.00")
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
                                    PrecioA = (Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                    PrecioB = (Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                    PrecioC = (Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
                                    PrecioD = (Precio.Monto / (1 + (CDbl(txtImpVenta.Text) / 100)))
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
                        End If

                        Me.precio_promo_valor = rs("Precio_Promo")
                        MonedaCosto = rs("MonedaVenta") 'rs("MonedaCosto")
                        Me.Txtcodmoneda_Venta.Text = rs("MonedaVenta")
                        Me.MonedaBase = rs("MonedaCosto")
                        MonedaVenta = Me.BindingContext(Me.DataSet_Facturaciones, "Moneda").Current("CodMoneda")

                        Lote = False
                        LOpcion.Text = "Opcion"

                        If rs("Lote") = True Then
                            ActivaLote()
                        Else
                            ActivaNinguno()
                        End If

                        If rs("Promo_Activa") = True Then ' si el articulo esta en promocion
                            Me.promo_activa_valor = True
                            Me.txtDescuento.Enabled = False
                            MsgBox("Este artículo está en promoción", MsgBoxStyle.Information)
                        Else
                            Me.promo_activa_valor = False ' se habilita el text
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

    Public Function Excento(ByVal cod As String) As Boolean
        Dim cnnv As SqlConnection = Nothing
        Dim dt As SqlDataReader
        Dim dime As Boolean
        Dim ex As Integer = 0

        Dim sConn As String = CadenaConexionSeePOS
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

    Private Sub Calculo_precio_unitario()
        Try
            If Me.promo_activa_valor Then ' si el articulo esta actualmente en promoción 
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
            Me.Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Me.Registrar(True)
        End If

        If e.KeyCode = Keys.F5 Then
            Me.password_antiguo = Me.txtUsuario.Text
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Enabled = True
            Me.txtNombreUsuario.Text = ""
            Me.GroupBox3.Enabled = False
            txtorden.Enabled = False
            Me.txtUsuario.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            Me.txtCod_Articulo.Focus()
            Me.GridControl1.Enabled = True
        End If
    End Sub

    Private Sub meter_al_detalle()
        Try
            Dim resp As Integer
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Sub
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo a la factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.GridControl1.Enabled = True
                Me.txtCantidad.Focus()
                Exit Sub
            End If

            If CDbl(Me.txtCantidad.Text) > Me.Existencia Then 'si la cantidad digitada es mayor que la existencia
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
                        txtCod_Articulo.Focus()
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

            If Lote = True Then
                ActualizaLote()
            End If

            BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()

            Calcular_totales()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            txtCod_Articulo.Focus()
            GridControl1.Enabled = True
            AgregandoNuevoItem = False

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub meter_al_detalle_cambiando()
        Try

            If CDbl(Me.txtCantidad.Text) > Me.Existencia Then 'si la cantidad digitada es mayor que la existencia
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

            txtCod_Articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub calculo_descuento_articulo()
        Try

            If CDbl(Me.txtDescuento.Text) > 0 Then 'si el articulo tiene un descuento

                '''''''''''''''''''''''''''''PROMO'''''''''''''''''''''' ACTIVA''''''''''''''''''''''''''''''''''''''''''
                If Me.promo_activa_valor Then 'si el articulo esta en promocion 
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo está en promoción" + vbCrLf
                    Exit Sub
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'SI EL ARTICULO NO PERMITE DESCUENTO
                If CDbl(TxtMaxdescuento.Text) = 0 Then
                    'Si el articulo  no permite que se le realize un descuento
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo no permite descuento" + vbCrLf
                    Exit Sub
                End If


                'SI EL USUARIO NO PUEDE DAR DESCUENTO

                If Me.porcentaje_descuento = 0 Then
                    MsgBox("Usted no puede realizar descuentos", MsgBoxStyle.Critical)
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    Exit Sub
                End If


                ' validar si el descuento se puede aplicar o no el descuento

                ''''''''''''''''''''''''''''''''''''''''''''''''''''
                max_aplicar = CDbl(Me.TxtMaxdescuento.Text) * Me.porcentaje_descuento / 100



                'SI EL DESCUENTO DESEADO ES TOTALMENTE APLICABLE AL ARTICULO
                If CDbl(Me.txtDescuento.Text) <= max_aplicar Then
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

            Me.txtImpVenta.Text = Me.impuesto_cliente * CDbl(Me.txtImpVenta.Text) / 100

            If txtImpVenta.Text <> 0 Then 'si tiene impuesto de venta
                If (CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) > CDbl(txtPrecioUnit.Text) Then
                    txtFlete.Text = 0
                    txtOtros.Text = 0
                End If
                'Gravado = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
                Gravado = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
                'txtMontoImpuesto.Text = Gravado * (CDbl(txtImpVenta.Text) / 100)
                txtMontoImpuesto.Text = (Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(txtImpVenta.Text) / 100)
                txtSGravado.Text = Gravado
                Exento = 0

            Else 'si no tiene impuesto de venta
                'Exento = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
                Exento = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
                Gravado = 0
                txtMontoImpuesto.Text = 0
                txtSGravado.Text = 0
                txtSExcento.Text = Exento
            End If

            Exento = Exento + ((CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
            txtSExcento.Text = Exento
            txtSubtotal.Text = CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text) '+ CDbl(Me.txtmontodescuento.Text)

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub Calcular_totales()
        Try

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            Calcular_Totales_Cotizacion()
            BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count
            If Me.opCredito.Checked = True Then
                busca_Facturas_Pendientes()
            End If

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
                txtorden.Enabled = False
                Me.txtUsuario.Focus()
            End If

            If e.KeyCode = Keys.F2 Then
                Me.Registrar(False)
            End If

            If e.KeyCode = Keys.F3 Then
                Me.Registrar(True)
            End If

            If e.KeyCode = Keys.F5 Then
                Me.password_antiguo = Me.txtUsuario.Text
                Me.txtUsuario.Text = ""
                Me.txtUsuario.Enabled = True
                Me.txtNombreUsuario.Text = ""
                Me.GroupBox3.Enabled = False
                txtorden.Enabled = False
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


    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try

            If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
                If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                    e.Handled = True  ' esto invalida la tecla pulsada
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub txtorden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorden.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub


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

        Catch ex As SystemException
            txtPrecioUnit.Text = precio_unitario
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
            Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Registrar(True)
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
            Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            If buscando = True Then Exit Sub
            Registrar(True)
        End If

        If e.KeyCode = Keys.F5 Then
            If buscando = True Then Exit Sub
            BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            password_antiguo = txtUsuario.Text
            txtUsuario.Text = ""
            txtUsuario.Enabled = True
            txtNombreUsuario.Text = ""
            GroupBox3.Enabled = False
            txtorden.Enabled = False
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


    Private Sub opCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opCredito.CheckedChanged, opContado.CheckedChanged
        Try
            If opCredito.Checked = True And txtCodigo.Text = "0" And Not Importando Then
                MsgBox("Este es un Cliente de Contado, no se le puede dar crédito", MsgBoxStyle.Information)
                opCredito.Checked = False
                opContado.Checked = True
                dias_credito()
                Exit Sub
            End If

            If opCredito.Checked = True And buscando = False Then ' si esta marcada la opcion de credito
                Cargar_Cliente(CInt(txtCodigo.Text))
                recargar_Cliente()
                busca_Facturas_Pendientes()
                dias_credito()
            End If

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
                    Label7.Visible = True
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
                    Label7.Visible = False


                    If BindingContext(DataSet_Facturaciones, "Ventas").Count > 0 Then TxtTipo.Text = "CON" 'BindingContext(DataSet_Facturaciones, "Ventas").Current("Tipo") = "CON"
                    BindingContext(DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = "NINGUNO"

                    Label41.Visible = False
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
            Me.Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Me.Registrar(True)
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
        Dim trans As Double
        Dim mont_trans As New Monto_Transporte_Ventas
        Try

            mont_trans.ShowDialog()
            trans = mont_trans.Monto

            Label46.Text = trans

            Me.Calcular_Totales_Cotizacion()
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").EndCurrentEdit()


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
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
            Me.Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Me.Registrar(True)
        End If

        If e.KeyCode = Keys.F5 Then
            Me.password_antiguo = Me.txtUsuario.Text
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Enabled = True
            Me.txtNombreUsuario.Text = ""
            Me.GroupBox3.Enabled = False
            txtorden.Enabled = False
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
                Exit Sub
            Else
                ErrorProvider1.SetError(sender, "")
                Exit Sub
            End If


            If CDbl(Me.txtPrecioUnit.Text) = 0 Then  'si el campo está vacío
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
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT id, Num_Factura, Total, Tipo_Cambio,dbo.dateOnly(Vence) as Vence, Tipo from Ventas where (Tipo = 'CRE' Or Tipo = 'TCR') and FacturaCancelado = 0 and Anulado = 0 and Cod_Cliente =" & txtCodigo.Text)


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

                Me.Monto_Adeudado += Me.CConexion.SlqExecuteScalar(cConexion.Conectar, "Select dbo.SaldoFactura(getdate()," & num_Fac & ", '" & rs("Tipo") & "')")
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

#Region "Funciones Con troles"
    Private Sub txtTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Me.Registrar(True)
        End If
    End Sub

    Private Sub Combo_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            Me.Registrar(False)
        End If

        If e.KeyCode = Keys.F3 Then
            Registrar(True)
        End If
    End Sub

    Private Sub TxtprecioCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtprecioCosto.TextChanged
        Label_Costobase.Text = Me.TxtprecioCosto.Text
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.ComboBox1.Enabled = True
        Me.ComboBox1.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        If Me.opContado.Checked = True Then
            Me.iniciar_factura()
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
        GridControl1.Enabled = True
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
            MsgBox(EX.Message, MsgBoxStyle.Information, "Atención...")
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
        If AgregandoNuevoItem = False Then
            If Me.DataSet_Facturaciones.Ventas_Detalle.Rows.Count > 0 Then
                Me.txtCodArticulo.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Codigo")
                Me.txtCod_Articulo.Text = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("CodArticulo")
            End If

            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas_Detalle").CancelCurrentEdit()
        Else
            Me.BindingContext(Me.DataSet_Facturaciones, "Ventas_Detalle").EndCurrentEdit()
        End If
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
                recalcular_cotizacion_cambio_cliente()
                txtCod_Articulo.Focus()
            End If
        End If
    End Sub

    Private Sub txtExistencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExistencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantidad.Focus()
        End If
    End Sub
#End Region


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
                DrElimina = DataSet_Facturaciones.Lotes.Select("Lote = '" & BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Numero") & "' And Cod_Articulo = " & CInt(txtCodArticulo.Text))

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
                MsgBox("Debe Seleccionar un Lote!", MsgBoxStyle.Critical)
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
                    If rs("Lotes") = True Then
                        ActivaLote()
                    Else
                        ActivaNinguno()
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
        If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count > 0 Then
            If coti = False Then
                If BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote") <> "0" Then
                    ActivaLote()
                    CbNumero.SelectedItem = BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote")
                Else
                    ActivaNinguno()
                End If
            ElseIf coti = True And BindingContext(DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Current("Lote") = "0" Then
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

    Private Sub Ck_Taller_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck_Taller.CheckedChanged

    End Sub
End Class
