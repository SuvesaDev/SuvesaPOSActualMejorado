'Imports System.Data.SqlClient
'Imports System.Data
'Imports System.Windows.Forms
'Imports System.Drawing.Printing
Imports Microsoft.Office.Interop
Imports System.Diagnostics
Imports Microsoft.Office

Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing
Public Class Frm_Cotizacion
    Inherits System.Windows.Forms.Form

    Public IdCotizacionUsuarioExterno As Long = 0
    Public maximo_porc_descuento As Double
    Public nuevo_porc_descuento As Double
    Public Maximo_Porcentaje_Credito_Cliente As Double
    Public Edit_Cotizacion As Boolean
    Dim PosActual As Integer = 0
    Dim Cedula_usuario As String
    Dim Anula_Cotizacion As Boolean
    Dim busqueda As Boolean = False
    Dim porcentaje_descuento As Double
    Dim Existencia As Double
    Dim perfil_administrador As Boolean
    Dim cliente_cargado As Boolean
    Dim Imp_Conf As Double ' almacena el impuesto d eventa traido de la tabla configuraciones
    Dim vende_existecias_negativas As Boolean
    Dim impuesto_cliente As Double
    Dim variacion_Punit As Double
    Dim Monto_Adeudado As Double
    Dim AgregandoNuevoItem As Boolean
    Dim max_aplicar As Double 'almacena el maximo porcentaje de descuento que se puede aplicar a determinado articulo
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
    Dim MonedaBase As Integer
    Dim ValorBase As Double
    Dim ValorCosto As Double
    Dim ValorVenta As Double
    Dim MonedaCosto As Integer
    Dim MonedaVenta As Integer
    Dim MontoImpuesto As Double
    Dim precio_unitario As Double
    Dim Max_Descuento_Articulo As Double
    Dim promo_activa_valor As Boolean
    Dim precio_promo_valor As Double
    Dim monto_Perdido As Double
    Dim CConexion As New Conexion
    Dim CConexion2 As New Conexion
    Dim mensaje As String ' almacena el mensaje de los descuentos
    Dim password_antiguo As String
    Dim logeado As Boolean
    Dim usua
    Friend WithEvents SqlDeleteCommand As SqlCommand
    Friend WithEvents SqlInsertCommand As SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlCommand
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnMAG As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula As System.Windows.Forms.TextBox
    Friend WithEvents colUtilidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblUtilidadGeneral As System.Windows.Forms.Label
    Dim PMU As New PerfilModulo_Class


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
        AddHandler Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CurrentChanged, AddressOf Me.Current_Changed
        AddHandler Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").PositionChanged, AddressOf Me.Position_Changed

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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



    Friend WithEvents Adapter_Clientes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Cotizacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Cotizacion_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet_Cotizaciones21 As DataSet_Cotizaciones2
    Friend WithEvents dtFecha As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label_Costobase As System.Windows.Forms.Label
    Friend WithEvents Label_Transporte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Lb_SubExento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lb_Subgravado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents opContado As System.Windows.Forms.RadioButton
    Friend WithEvents opCredito As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarAnular As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Txt_TipoCambio_Valor_Compra As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As ValidText.ValidText
    Friend WithEvents Txtcodmoneda_Venta As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoBase As System.Windows.Forms.TextBox
    Friend WithEvents txtCotizacion As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiasEntrega As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasPlazo As System.Windows.Forms.Label
    Friend WithEvents txtDiasValidez As System.Windows.Forms.TextBox
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents txtImpVenta As System.Windows.Forms.Label
    Friend WithEvents txtImpVentaT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaxdescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtmontodescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreArt As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtprecioCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtSGravado As System.Windows.Forms.TextBox
    Friend WithEvents txtSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubtotalExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotalGravado As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotalT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ValidText2 As ValidText.ValidText
    Private WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TxtUtilidad As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ToolBarActualizaPrecios As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ck_Exonerar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCod_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ck_confirmada As System.Windows.Forms.CheckBox
    Friend WithEvents txtconfirmadapor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cotizacion))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataSet_Cotizaciones21 = New LcPymes_5._2.DataSet_Cotizaciones2()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUtilidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.txtSubtotalGravado = New System.Windows.Forms.TextBox()
        Me.txtSubtotalExcento = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarAnular = New System.Windows.Forms.ToolBarButton()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarActualizaPrecios = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDiasPlazo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.opCredito = New System.Windows.Forms.RadioButton()
        Me.opContado = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Ck_Exonerar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCod_Articulo = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreArt = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TxtUtilidad = New DevExpress.XtraEditors.TextEdit()
        Me.Label_Costobase = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtImpVenta = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrecioUnit = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.txtSExcento = New System.Windows.Forms.TextBox()
        Me.txtmontodescuento = New System.Windows.Forms.TextBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.txtFlete = New System.Windows.Forms.TextBox()
        Me.txtSGravado = New System.Windows.Forms.TextBox()
        Me.txtMontoImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSubFamilia = New System.Windows.Forms.TextBox()
        Me.txtCostoBase = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ValidText2 = New ValidText.ValidText()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiasEntrega = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiasValidez = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_Cotizacion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbo_tipo_cliente = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnMAG = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New ValidText.ValidText()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCotizacion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Adapter_Clientes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblUtilidadGeneral = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_Transporte = New DevExpress.XtraEditors.TextEdit()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Lb_Subgravado = New DevExpress.XtraEditors.TextEdit()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Lb_SubExento = New DevExpress.XtraEditors.TextEdit()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtImpVentaT = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoT = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubtotalT = New DevExpress.XtraEditors.TextEdit()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Adapter_Cotizacion_Detalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Txt_TipoCambio_Valor_Compra = New System.Windows.Forms.TextBox()
        Me.Txtcodmoneda_Venta = New System.Windows.Forms.TextBox()
        Me.TxtMaxdescuento = New System.Windows.Forms.TextBox()
        Me.TxtprecioCosto = New System.Windows.Forms.TextBox()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.ck_confirmada = New System.Windows.Forms.CheckBox()
        Me.txtconfirmadapor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Cotizaciones21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Ck_Exonerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Label_Transporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Cotizacion.CotizacionCotizacion_Detalle"
        Me.GridControl1.DataSource = Me.DataSet_Cotizaciones21
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 184)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(861, 162)
        Me.GridControl1.TabIndex = 81
        Me.GridControl1.Text = "GridControl1"
        '
        'DataSet_Cotizaciones21
        '
        Me.DataSet_Cotizaciones21.DataSetName = "DataSet_Cotizaciones2"
        Me.DataSet_Cotizaciones21.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_Cotizaciones21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colPrecio_Unit, Me.colUtilidad, Me.colMonto_Descuento, Me.colMonto_Impuesto, Me.colSubtotalGravado, Me.colSubTotalExcento, Me.colSubTotal})
        Me.BandedGridView1.GroupPanelText = "Detalle de Cotización"
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.BandedGridView1.Name = "BandedGridView1"
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
        Me.GridBand1.Columns.Add(Me.colUtilidad)
        Me.GridBand1.Columns.Add(Me.colMonto_Descuento)
        Me.GridBand1.Columns.Add(Me.colMonto_Impuesto)
        Me.GridBand1.Columns.Add(Me.colSubtotalGravado)
        Me.GridBand1.Columns.Add(Me.colSubTotalExcento)
        Me.GridBand1.Columns.Add(Me.colSubTotal)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 779
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "CodArticulo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 60
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 258
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo3
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 60
        '
        'colPrecio_Unit
        '
        Me.colPrecio_Unit.Caption = "P. Unit"
        Me.colPrecio_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Unit.FieldName = "Precio_Unit"
        Me.colPrecio_Unit.FilterInfo = ColumnFilterInfo4
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Unit.Visible = True
        Me.colPrecio_Unit.Width = 71
        '
        'colUtilidad
        '
        Me.colUtilidad.Caption = "Utilidad"
        Me.colUtilidad.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colUtilidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colUtilidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUtilidad.FieldName = "Utilidad"
        Me.colUtilidad.FilterInfo = ColumnFilterInfo5
        Me.colUtilidad.Name = "colUtilidad"
        Me.colUtilidad.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colUtilidad.Visible = True
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AllowFocused = False
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        Me.RepositoryItemTextEdit1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Yellow, System.Drawing.Color.RoyalBlue)
        '
        'colMonto_Descuento
        '
        Me.colMonto_Descuento.Caption = "%. Desc."
        Me.colMonto_Descuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Descuento.FieldName = "Descuento"
        Me.colMonto_Descuento.FilterInfo = ColumnFilterInfo6
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Descuento.SummaryItem.FieldName = "Monto_Descuento"
        Me.colMonto_Descuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Descuento.Visible = True
        Me.colMonto_Descuento.Width = 71
        '
        'colMonto_Impuesto
        '
        Me.colMonto_Impuesto.Caption = "M. Imp."
        Me.colMonto_Impuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Impuesto.FieldName = "Monto_Impuesto"
        Me.colMonto_Impuesto.FilterInfo = ColumnFilterInfo7
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Impuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Impuesto.Visible = True
        Me.colMonto_Impuesto.Width = 71
        '
        'colSubtotalGravado
        '
        Me.colSubtotalGravado.Caption = "S. Grav."
        Me.colSubtotalGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubtotalGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotalGravado.FieldName = "SubtotalGravado"
        Me.colSubtotalGravado.FilterInfo = ColumnFilterInfo8
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubtotalGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubtotalGravado.Width = 60
        '
        'colSubTotalExcento
        '
        Me.colSubTotalExcento.Caption = "S. Exc."
        Me.colSubTotalExcento.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotalExcento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotalExcento.FieldName = "SubTotalExcento"
        Me.colSubTotalExcento.FilterInfo = ColumnFilterInfo9
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotalExcento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotalExcento.Width = 68
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SubTotal"
        Me.colSubTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.FilterInfo = ColumnFilterInfo10
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotal.Visible = True
        Me.colSubTotal.Width = 113
        '
        'txtSubtotalGravado
        '
        Me.txtSubtotalGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotalGravado.Enabled = False
        Me.txtSubtotalGravado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalGravado.ForeColor = System.Drawing.Color.Blue
        Me.txtSubtotalGravado.Location = New System.Drawing.Point(216, 0)
        Me.txtSubtotalGravado.Name = "txtSubtotalGravado"
        Me.txtSubtotalGravado.Size = New System.Drawing.Size(48, 13)
        Me.txtSubtotalGravado.TabIndex = 87
        Me.txtSubtotalGravado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotalExcento
        '
        Me.txtSubtotalExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotalExcento.Enabled = False
        Me.txtSubtotalExcento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalExcento.ForeColor = System.Drawing.Color.Blue
        Me.txtSubtotalExcento.Location = New System.Drawing.Point(136, 0)
        Me.txtSubtotalExcento.Name = "txtSubtotalExcento"
        Me.txtSubtotalExcento.Size = New System.Drawing.Size(48, 13)
        Me.txtSubtotalExcento.TabIndex = 86
        Me.txtSubtotalExcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(121, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(428, 13)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
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
        '
        'ToolBarAnular
        '
        Me.ToolBarAnular.Enabled = False
        Me.ToolBarAnular.ImageIndex = 3
        Me.ToolBarAnular.Name = "ToolBarAnular"
        Me.ToolBarAnular.Text = "Anular"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarAnular, Me.ToolBarImprimir, Me.ToolBarCerrar, Me.ToolBarActualizaPrecios})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 464)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(878, 58)
        Me.ToolBar1.TabIndex = 85
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ToolBarActualizaPrecios
        '
        Me.ToolBarActualizaPrecios.ImageIndex = 9
        Me.ToolBarActualizaPrecios.Name = "ToolBarActualizaPrecios"
        Me.ToolBarActualizaPrecios.Text = "Actualizar Precios"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(878, 35)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Formulario de Cotizaciones"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(9, 49)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 14)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataSet_Cotizaciones21
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.Location = New System.Drawing.Point(78, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Moneda.MonedaNombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtDiasPlazo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.opCredito)
        Me.GroupBox2.Controls.Add(Me.opContado)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(764, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 88)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'txtDiasPlazo
        '
        Me.txtDiasPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDiasPlazo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDiasPlazo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDiasPlazo.Location = New System.Drawing.Point(10, 53)
        Me.txtDiasPlazo.Name = "txtDiasPlazo"
        Me.txtDiasPlazo.Size = New System.Drawing.Size(32, 12)
        Me.txtDiasPlazo.TabIndex = 158
        Me.txtDiasPlazo.Text = "0"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(49, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "días"
        '
        'opCredito
        '
        Me.opCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opCredito.Location = New System.Drawing.Point(9, 33)
        Me.opCredito.Name = "opCredito"
        Me.opCredito.Size = New System.Drawing.Size(80, 14)
        Me.opCredito.TabIndex = 1
        Me.opCredito.Text = "Crédito"
        '
        'opContado
        '
        Me.opContado.Checked = True
        Me.opContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opContado.Location = New System.Drawing.Point(9, 14)
        Me.opContado.Name = "opContado"
        Me.opContado.Size = New System.Drawing.Size(80, 14)
        Me.opContado.TabIndex = 0
        Me.opContado.TabStop = True
        Me.opContado.Text = "Contado"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(353, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 34)
        Me.Button1.TabIndex = 174
        Me.Button1.Text = "%"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(204, 518)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 13)
        Me.CheckBox1.TabIndex = 155
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.Ck_Exonerar)
        Me.GroupBox3.Controls.Add(Me.txtCod_Articulo)
        Me.GroupBox3.Controls.Add(Me.txtExistencia)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtNombreArt)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.TxtUtilidad)
        Me.GroupBox3.Controls.Add(Me.Label_Costobase)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Controls.Add(Me.txtImpVenta)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPrecioUnit)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtCodArticulo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Controls.Add(Me.txtSExcento)
        Me.GroupBox3.Controls.Add(Me.txtmontodescuento)
        Me.GroupBox3.Controls.Add(Me.txtOtros)
        Me.GroupBox3.Controls.Add(Me.txtFlete)
        Me.GroupBox3.Controls.Add(Me.txtSGravado)
        Me.GroupBox3.Controls.Add(Me.txtMontoImpuesto)
        Me.GroupBox3.Controls.Add(Me.txtSubFamilia)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(861, 52)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Artículos a Cotizar"
        '
        'Ck_Exonerar
        '
        Me.Ck_Exonerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_Exonerar.EditValue = False
        Me.Ck_Exonerar.Location = New System.Drawing.Point(8, 31)
        Me.Ck_Exonerar.Name = "Ck_Exonerar"
        '
        '
        '
        Me.Ck_Exonerar.Properties.Caption = "Exonerar"
        Me.Ck_Exonerar.Properties.Enabled = False
        Me.Ck_Exonerar.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.RoyalBlue, System.Drawing.Color.White)
        Me.Ck_Exonerar.Size = New System.Drawing.Size(72, 17)
        Me.Ck_Exonerar.TabIndex = 193
        '
        'txtCod_Articulo
        '
        Me.txtCod_Articulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCod_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod_Articulo.ForeColor = System.Drawing.Color.Blue
        Me.txtCod_Articulo.Location = New System.Drawing.Point(86, 35)
        Me.txtCod_Articulo.Name = "txtCod_Articulo"
        Me.txtCod_Articulo.Size = New System.Drawing.Size(64, 14)
        Me.txtCod_Articulo.TabIndex = 199
        '
        'txtExistencia
        '
        Me.txtExistencia.EditValue = "0.00"
        Me.txtExistencia.Location = New System.Drawing.Point(468, 31)
        Me.txtExistencia.Name = "txtExistencia"
        '
        '
        '
        Me.txtExistencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtExistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtExistencia.Size = New System.Drawing.Size(48, 17)
        Me.txtExistencia.TabIndex = 198
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(468, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "Exist."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreArt.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNombreArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArt.ForeColor = System.Drawing.Color.Yellow
        Me.txtNombreArt.Location = New System.Drawing.Point(128, 0)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(727, 13)
        Me.txtNombreArt.TabIndex = 3
        Me.txtNombreArt.Text = "DESCRIPCIÓN DEL ARTICULO A COTIZAR"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label50.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label50.Location = New System.Drawing.Point(236, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 14)
        Me.Label50.TabIndex = 196
        Me.Label50.Text = "Utilidad (%)"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label50.Visible = False
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.EditValue = "0.00"
        Me.TxtUtilidad.Location = New System.Drawing.Point(236, 32)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        '
        '
        '
        Me.TxtUtilidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUtilidad.Properties.DisplayFormat.FormatString = "#,#0.0000"
        Me.TxtUtilidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad.Size = New System.Drawing.Size(72, 17)
        Me.TxtUtilidad.TabIndex = 195
        Me.TxtUtilidad.Visible = False
        '
        'Label_Costobase
        '
        Me.Label_Costobase.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Costobase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Costobase.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_Costobase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Costobase.Location = New System.Drawing.Point(156, 32)
        Me.Label_Costobase.Name = "Label_Costobase"
        Me.Label_Costobase.Size = New System.Drawing.Size(64, 16)
        Me.Label_Costobase.TabIndex = 192
        Me.Label_Costobase.Visible = False
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(156, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(64, 14)
        Me.Label38.TabIndex = 191
        Me.Label38.Text = "Prec. Base"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label38.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(8, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(847, 16)
        Me.Label28.TabIndex = 156
        Me.Label28.Text = "Artículo a Cotizar ->"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.EditValue = "0.00"
        Me.txtSubtotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotal.Location = New System.Drawing.Point(676, 32)
        Me.txtSubtotal.Name = "txtSubtotal"
        '
        '
        '
        Me.txtSubtotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(112, 17)
        Me.txtSubtotal.TabIndex = 155
        '
        'txtImpVenta
        '
        Me.txtImpVenta.BackColor = System.Drawing.SystemColors.Control
        Me.txtImpVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpVenta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtImpVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVenta.Location = New System.Drawing.Point(596, 32)
        Me.txtImpVenta.Name = "txtImpVenta"
        Me.txtImpVenta.Size = New System.Drawing.Size(56, 16)
        Me.txtImpVenta.TabIndex = 154
        Me.txtImpVenta.Text = "0.00"
        Me.txtImpVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(660, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 16)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "M"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(668, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 14)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "SubTotal"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(596, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "I.V. (%)"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(396, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 14)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Desc. (%) "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPrecioUnit
        '
        Me.txtPrecioUnit.EditValue = "0.00"
        Me.txtPrecioUnit.Location = New System.Drawing.Point(316, 32)
        Me.txtPrecioUnit.Name = "txtPrecioUnit"
        '
        '
        '
        Me.txtPrecioUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.Enabled = False
        Me.txtPrecioUnit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtPrecioUnit.Size = New System.Drawing.Size(64, 17)
        Me.txtPrecioUnit.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(316, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 14)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Precio Unit."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.EditValue = "0.00"
        Me.txtCantidad.Location = New System.Drawing.Point(521, 32)
        Me.txtCantidad.Name = "txtCantidad"
        '
        '
        '
        Me.txtCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCantidad.Size = New System.Drawing.Size(72, 17)
        Me.txtCantidad.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(521, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 14)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Cantidad"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArticulo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodArticulo.Location = New System.Drawing.Point(-88, 33)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(78, 14)
        Me.txtCodArticulo.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(86, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Código"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDescuento
        '
        Me.txtDescuento.EditValue = "0.00"
        Me.txtDescuento.Location = New System.Drawing.Point(388, 32)
        Me.txtDescuento.Name = "txtDescuento"
        '
        '
        '
        Me.txtDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDescuento.Size = New System.Drawing.Size(72, 17)
        Me.txtDescuento.TabIndex = 7
        '
        'txtSExcento
        '
        Me.txtSExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSExcento.ForeColor = System.Drawing.Color.Blue
        Me.txtSExcento.Location = New System.Drawing.Point(86, 19)
        Me.txtSExcento.Name = "txtSExcento"
        Me.txtSExcento.Size = New System.Drawing.Size(24, 13)
        Me.txtSExcento.TabIndex = 17
        '
        'txtmontodescuento
        '
        Me.txtmontodescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmontodescuento.ForeColor = System.Drawing.Color.Blue
        Me.txtmontodescuento.Location = New System.Drawing.Point(264, 3)
        Me.txtmontodescuento.Name = "txtmontodescuento"
        Me.txtmontodescuento.Size = New System.Drawing.Size(24, 13)
        Me.txtmontodescuento.TabIndex = 154
        '
        'txtOtros
        '
        Me.txtOtros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtros.ForeColor = System.Drawing.Color.Blue
        Me.txtOtros.Location = New System.Drawing.Point(448, 3)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(24, 13)
        Me.txtOtros.TabIndex = 22
        '
        'txtFlete
        '
        Me.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFlete.ForeColor = System.Drawing.Color.Blue
        Me.txtFlete.Location = New System.Drawing.Point(235, 3)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(24, 13)
        Me.txtFlete.TabIndex = 21
        '
        'txtSGravado
        '
        Me.txtSGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSGravado.ForeColor = System.Drawing.Color.Blue
        Me.txtSGravado.Location = New System.Drawing.Point(136, 3)
        Me.txtSGravado.Name = "txtSGravado"
        Me.txtSGravado.Size = New System.Drawing.Size(24, 13)
        Me.txtSGravado.TabIndex = 18
        '
        'txtMontoImpuesto
        '
        Me.txtMontoImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoImpuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtMontoImpuesto.Location = New System.Drawing.Point(312, 3)
        Me.txtMontoImpuesto.Name = "txtMontoImpuesto"
        Me.txtMontoImpuesto.Size = New System.Drawing.Size(24, 13)
        Me.txtMontoImpuesto.TabIndex = 16
        '
        'txtSubFamilia
        '
        Me.txtSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtSubFamilia.Location = New System.Drawing.Point(434, 3)
        Me.txtSubFamilia.Name = "txtSubFamilia"
        Me.txtSubFamilia.Size = New System.Drawing.Size(24, 13)
        Me.txtSubFamilia.TabIndex = 19
        '
        'txtCostoBase
        '
        Me.txtCostoBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoBase.ForeColor = System.Drawing.Color.Blue
        Me.txtCostoBase.Location = New System.Drawing.Point(552, 224)
        Me.txtCostoBase.Name = "txtCostoBase"
        Me.txtCostoBase.Size = New System.Drawing.Size(24, 13)
        Me.txtCostoBase.TabIndex = 20
        '
        'Label29
        '
        Me.Label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(8, 354)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(228, 12)
        Me.Label29.TabIndex = 153
        Me.Label29.Text = "Observaciones:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValidText2
        '
        Me.ValidText2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ValidText2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValidText2.Enabled = False
        Me.ValidText2.FieldReference = Nothing
        Me.ValidText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidText2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText2.Location = New System.Drawing.Point(104, 354)
        Me.ValidText2.MaskEdit = ""
        Me.ValidText2.Multiline = True
        Me.ValidText2.Name = "ValidText2"
        Me.ValidText2.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText2.Required = False
        Me.ValidText2.ShowErrorIcon = False
        Me.ValidText2.Size = New System.Drawing.Size(764, 16)
        Me.ValidText2.TabIndex = 0
        Me.ValidText2.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText2.ValidText = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.SimpleButton3)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDiasEntrega)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDiasValidez)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(535, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones de Cotización"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Location = New System.Drawing.Point(176, 45)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(24, 18)
        Me.SimpleButton3.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton3.TabIndex = 193
        Me.SimpleButton3.Text = "..."
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(6, 68)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 15)
        Me.Label41.TabIndex = 165
        Me.Label41.Text = "Tipo Cambio"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(172, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 12)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Días"
        '
        'txtDiasEntrega
        '
        Me.txtDiasEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiasEntrega.Enabled = False
        Me.txtDiasEntrega.ForeColor = System.Drawing.Color.Blue
        Me.txtDiasEntrega.Location = New System.Drawing.Point(128, 29)
        Me.txtDiasEntrega.Name = "txtDiasEntrega"
        Me.txtDiasEntrega.Size = New System.Drawing.Size(40, 13)
        Me.txtDiasEntrega.TabIndex = 4
        Me.txtDiasEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(8, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 12)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Tiempo de Entrega"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(173, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 12)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Días"
        '
        'txtDiasValidez
        '
        Me.txtDiasValidez.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiasValidez.Enabled = False
        Me.txtDiasValidez.ForeColor = System.Drawing.Color.Blue
        Me.txtDiasValidez.Location = New System.Drawing.Point(128, 13)
        Me.txtDiasValidez.Name = "txtDiasValidez"
        Me.txtDiasValidez.Size = New System.Drawing.Size(40, 13)
        Me.txtDiasValidez.TabIndex = 2
        Me.txtDiasValidez.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(8, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Validez"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(80, 68)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(112, 15)
        Me.txtTipoCambio.TabIndex = 164
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtFecha.ForeColor = System.Drawing.Color.RoyalBlue
        Me.dtFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFecha.Location = New System.Drawing.Point(402, 47)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(112, 11)
        Me.dtFecha.TabIndex = 163
        Me.dtFecha.Text = "00/00/0000"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(360, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 12)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Cotización N°"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Cotizacion
        '
        Me.Adapter_Cotizacion.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Cotizacion.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Cotizacion.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Cotizacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cotizacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cotizacion", "Cotizacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Contacto", "Contacto"), New System.Data.Common.DataColumnMapping("Validez", "Validez"), New System.Data.Common.DataColumnMapping("TiempoEntrega", "TiempoEntrega"), New System.Data.Common.DataColumnMapping("Contado", "Contado"), New System.Data.Common.DataColumnMapping("Credito", "Credito"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Dias", "Dias"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Venta", "Venta"), New System.Data.Common.DataColumnMapping("Exonerar", "Exonerar"), New System.Data.Common.DataColumnMapping("confirmada", "confirmada"), New System.Data.Common.DataColumnMapping("confirmada_por", "confirmada_por"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente")})})
        Me.Adapter_Cotizacion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_confirmada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "confirmada", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_confirmada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "confirmada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_confirmada_por", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "confirmada_por", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_confirmada_por", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "confirmada_por", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 0, "Contacto"), New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 0, "Validez"), New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 0, "TiempoEntrega"), New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 0, "Contado"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 0, "Credito"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 0, "Dias"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 0, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 0, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 0, "Transporte"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 0, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 0, "Venta"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 0, "Exonerar"), New System.Data.SqlClient.SqlParameter("@confirmada", System.Data.SqlDbType.Bit, 0, "confirmada"), New System.Data.SqlClient.SqlParameter("@confirmada_por", System.Data.SqlDbType.NVarChar, 0, "confirmada_por"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.NVarChar, 0, "Cod_Cliente")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 0, "Contacto"), New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 0, "Validez"), New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 0, "TiempoEntrega"), New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 0, "Contado"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 0, "Credito"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 0, "Dias"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 0, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 0, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 0, "Transporte"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 0, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 0, "Venta"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 0, "Exonerar"), New System.Data.SqlClient.SqlParameter("@confirmada", System.Data.SqlDbType.Bit, 0, "confirmada"), New System.Data.SqlClient.SqlParameter("@confirmada_por", System.Data.SqlDbType.NVarChar, 0, "confirmada_por"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.NVarChar, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exonerar", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exonerar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_confirmada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "confirmada", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_confirmada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "confirmada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_confirmada_por", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "confirmada_por", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_confirmada_por", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "confirmada_por", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion")})
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.txt_cedula)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.cbo_tipo_cliente)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.btnMAG)
        Me.GroupBox6.Controls.Add(Me.txtTelefono)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Controls.Add(Me.txtContacto)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtSubtotalGravado)
        Me.GroupBox6.Controls.Add(Me.dtFecha)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox6.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(524, 87)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Cliente"
        '
        'Label37
        '
        Me.Label37.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(10, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(506, 16)
        Me.Label37.TabIndex = 157
        Me.Label37.Text = "Datos del Clientes"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cedula
        '
        Me.txt_cedula.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_cedula.Location = New System.Drawing.Point(10, 28)
        Me.txt_cedula.MaxLength = 20
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(123, 20)
        Me.txt_cedula.TabIndex = 173
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gray
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(8, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 17)
        Me.Label19.TabIndex = 172
        Me.Label19.Text = "Cedula"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_tipo_cliente
        '
        Me.cbo_tipo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbo_tipo_cliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbo_tipo_cliente.FormattingEnabled = True
        Me.cbo_tipo_cliente.Items.AddRange(New Object() {"FISICA", "JURIDICA", "DIMEX"})
        Me.cbo_tipo_cliente.Location = New System.Drawing.Point(136, 27)
        Me.cbo_tipo_cliente.Name = "cbo_tipo_cliente"
        Me.cbo_tipo_cliente.Size = New System.Drawing.Size(104, 21)
        Me.cbo_tipo_cliente.TabIndex = 171
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Gray
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(137, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 15)
        Me.Label22.TabIndex = 170
        Me.Label22.Text = "Tipo"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMAG
        '
        Me.btnMAG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMAG.Image = Global.LcPymes_5._2.My.Resources.Resources.icons8_vaca_16
        Me.btnMAG.Location = New System.Drawing.Point(487, 16)
        Me.btnMAG.Name = "btnMAG"
        Me.btnMAG.Size = New System.Drawing.Size(31, 30)
        Me.btnMAG.TabIndex = 166
        Me.btnMAG.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.ForeColor = System.Drawing.Color.Blue
        Me.txtTelefono.Location = New System.Drawing.Point(240, 62)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(115, 13)
        Me.txtTelefono.TabIndex = 164
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(240, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 12)
        Me.Label18.TabIndex = 165
        Me.Label18.Text = "Telefono"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(246, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.FieldReference = Nothing
        Me.txtCodigo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodigo.Location = New System.Drawing.Point(11, 31)
        Me.txtCodigo.MaskEdit = ""
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCodigo.Required = False
        Me.txtCodigo.ShowErrorIcon = True
        Me.txtCodigo.Size = New System.Drawing.Size(21, 13)
        Me.txtCodigo.TabIndex = 0
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
        Me.txtNombre.Location = New System.Drawing.Point(246, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(239, 13)
        Me.txtNombre.TabIndex = 1
        '
        'txtContacto
        '
        Me.txtContacto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContacto.ForeColor = System.Drawing.Color.Blue
        Me.txtContacto.Location = New System.Drawing.Point(8, 62)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(227, 13)
        Me.txtContacto.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Contacto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCotizacion
        '
        Me.txtCotizacion.BackColor = System.Drawing.Color.White
        Me.txtCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCotizacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCotizacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCotizacion.Location = New System.Drawing.Point(80, 1)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Size = New System.Drawing.Size(80, 15)
        Me.txtCotizacion.TabIndex = 156
        Me.txtCotizacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtSubtotalExcento)
        Me.Panel1.Location = New System.Drawing.Point(309, 517)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 13)
        Me.Panel1.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(-9, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCotizacion)
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 16)
        Me.Panel2.TabIndex = 158
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Adapter_Clientes
        '
        Me.Adapter_Clientes.DeleteCommand = Me.SqlDeleteCommand
        Me.Adapter_Clientes.InsertCommand = Me.SqlInsertCommand
        Me.Adapter_Clientes.SelectCommand = Me.SqlSelectCommand5
        Me.Adapter_Clientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("abierto", "abierto"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("max_credito", "max_credito"), New System.Data.Common.DataColumnMapping("Plazo_credito", "Plazo_credito"), New System.Data.Common.DataColumnMapping("descuento", "descuento"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("sinrestriccion", "sinrestriccion"), New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("CodMonedaCredito", "CodMonedaCredito"), New System.Data.Common.DataColumnMapping("cedula", "cedula")})})
        Me.Adapter_Clientes.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.BigInt, 0, "identificacion"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT        nombre, abierto, impuesto, max_credito, Plazo_credito, descuento, t" & _
    "ipoprecio, sinrestriccion, identificacion, CodMonedaCredito, cedula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM       " & _
    "     Clientes"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.BigInt, 0, "identificacion"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cedula, Nombre, Clave_Interna, Porc_Desc, Porc_Precio, CambiarPrecio, Apli" & _
    "car_Desc FROM Usuarios"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox4.Controls.Add(Me.lblUtilidadGeneral)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.SimpleButton1)
        Me.GroupBox4.Controls.Add(Me.Label_Transporte)
        Me.GroupBox4.Controls.Add(Me.Label47)
        Me.GroupBox4.Controls.Add(Me.SimpleButton2)
        Me.GroupBox4.Controls.Add(Me.Lb_Subgravado)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.Lb_SubExento)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.txtImpVentaT)
        Me.GroupBox4.Controls.Add(Me.txtDescuentoT)
        Me.GroupBox4.Controls.Add(Me.txtSubtotalT)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox4.Location = New System.Drawing.Point(8, 370)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(861, 55)
        Me.GroupBox4.TabIndex = 159
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'lblUtilidadGeneral
        '
        Me.lblUtilidadGeneral.Location = New System.Drawing.Point(309, 18)
        Me.lblUtilidadGeneral.Name = "lblUtilidadGeneral"
        Me.lblUtilidadGeneral.Size = New System.Drawing.Size(42, 34)
        Me.lblUtilidadGeneral.TabIndex = 192
        Me.lblUtilidadGeneral.Text = "0.00"
        Me.lblUtilidadGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(20, 18)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton1.TabIndex = 191
        Me.SimpleButton1.Text = "T"
        '
        'Label_Transporte
        '
        Me.Label_Transporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Transporte.EditValue = ""
        Me.Label_Transporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Transporte.Location = New System.Drawing.Point(655, 35)
        Me.Label_Transporte.Name = "Label_Transporte"
        '
        '
        '
        Me.Label_Transporte.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Label_Transporte.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Label_Transporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label_Transporte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label_Transporte.Properties.ReadOnly = True
        Me.Label_Transporte.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Label_Transporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_Transporte.Size = New System.Drawing.Size(96, 17)
        Me.Label_Transporte.TabIndex = 189
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label47.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label47.Location = New System.Drawing.Point(656, 19)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 15)
        Me.Label47.TabIndex = 188
        Me.Label47.Text = "Transporte"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Enabled = False
        Me.SimpleButton2.Location = New System.Drawing.Point(459, 17)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(20, 18)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton2.TabIndex = 187
        Me.SimpleButton2.Text = "D"
        '
        'Lb_Subgravado
        '
        Me.Lb_Subgravado.EditValue = ""
        Me.Lb_Subgravado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_Subgravado.Location = New System.Drawing.Point(7, 35)
        Me.Lb_Subgravado.Name = "Lb_Subgravado"
        '
        '
        '
        Me.Lb_Subgravado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.ReadOnly = True
        Me.Lb_Subgravado.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Lb_Subgravado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_Subgravado.Size = New System.Drawing.Size(96, 17)
        Me.Lb_Subgravado.TabIndex = 38
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(8, 18)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 15)
        Me.Label45.TabIndex = 37
        Me.Label45.Text = "Sub. Gravado"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_SubExento
        '
        Me.Lb_SubExento.EditValue = ""
        Me.Lb_SubExento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_SubExento.Location = New System.Drawing.Point(105, 35)
        Me.Lb_SubExento.Name = "Lb_SubExento"
        '
        '
        '
        Me.Lb_SubExento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Lb_SubExento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.ReadOnly = True
        Me.Lb_SubExento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Lb_SubExento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_SubExento.Size = New System.Drawing.Size(96, 17)
        Me.Lb_SubExento.TabIndex = 35
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label42.Location = New System.Drawing.Point(106, 18)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 15)
        Me.Label42.TabIndex = 34
        Me.Label42.Text = "Sub. Exento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(760, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 15)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Total"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(7, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(845, 16)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Totales de Cotización"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.EditValue = ""
        Me.txtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotal.Location = New System.Drawing.Point(760, 35)
        Me.txtTotal.Name = "txtTotal"
        '
        '
        '
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(96, 17)
        Me.txtTotal.TabIndex = 29
        '
        'txtImpVentaT
        '
        Me.txtImpVentaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImpVentaT.EditValue = ""
        Me.txtImpVentaT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVentaT.Location = New System.Drawing.Point(554, 35)
        Me.txtImpVentaT.Name = "txtImpVentaT"
        '
        '
        '
        Me.txtImpVentaT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVentaT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.ReadOnly = True
        Me.txtImpVentaT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtImpVentaT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVentaT.Size = New System.Drawing.Size(96, 17)
        Me.txtImpVentaT.TabIndex = 28
        '
        'txtDescuentoT
        '
        Me.txtDescuentoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoT.EditValue = ""
        Me.txtDescuentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDescuentoT.Location = New System.Drawing.Point(449, 35)
        Me.txtDescuentoT.Name = "txtDescuentoT"
        '
        '
        '
        Me.txtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.ReadOnly = True
        Me.txtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoT.Size = New System.Drawing.Size(96, 17)
        Me.txtDescuentoT.TabIndex = 27
        '
        'txtSubtotalT
        '
        Me.txtSubtotalT.EditValue = ""
        Me.txtSubtotalT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotalT.Location = New System.Drawing.Point(208, 35)
        Me.txtSubtotalT.Name = "txtSubtotalT"
        '
        '
        '
        Me.txtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotalT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.ReadOnly = True
        Me.txtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtSubtotalT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotalT.Size = New System.Drawing.Size(96, 17)
        Me.txtSubtotalT.TabIndex = 26
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(554, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 15)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imp. Venta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(449, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 15)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Descuento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(208, 19)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(96, 15)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "SubTotal"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Adapter_Cotizacion_Detalle
        '
        Me.Adapter_Cotizacion_Detalle.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Cotizacion_Detalle.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Cotizacion_Detalle.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Cotizacion_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cotizacion_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Cotizacion", "Cotizacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("SubFamilia", "SubFamilia"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo")})})
        Me.Adapter_Cotizacion_Detalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Cotizacion_Detalle WHERE (Numero = @Original_Numero)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo")})
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
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 8, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 4, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero")})
        '
        'Txt_TipoCambio_Valor_Compra
        '
        Me.Txt_TipoCambio_Valor_Compra.Location = New System.Drawing.Point(480, 256)
        Me.Txt_TipoCambio_Valor_Compra.Name = "Txt_TipoCambio_Valor_Compra"
        Me.Txt_TipoCambio_Valor_Compra.Size = New System.Drawing.Size(56, 20)
        Me.Txt_TipoCambio_Valor_Compra.TabIndex = 191
        '
        'Txtcodmoneda_Venta
        '
        Me.Txtcodmoneda_Venta.Location = New System.Drawing.Point(608, 256)
        Me.Txtcodmoneda_Venta.Name = "Txtcodmoneda_Venta"
        Me.Txtcodmoneda_Venta.Size = New System.Drawing.Size(56, 20)
        Me.Txtcodmoneda_Venta.TabIndex = 190
        '
        'TxtMaxdescuento
        '
        Me.TxtMaxdescuento.Location = New System.Drawing.Point(544, 256)
        Me.TxtMaxdescuento.Name = "TxtMaxdescuento"
        Me.TxtMaxdescuento.Size = New System.Drawing.Size(56, 20)
        Me.TxtMaxdescuento.TabIndex = 192
        '
        'TxtprecioCosto
        '
        Me.TxtprecioCosto.Location = New System.Drawing.Point(416, 256)
        Me.TxtprecioCosto.Name = "TxtprecioCosto"
        Me.TxtprecioCosto.Size = New System.Drawing.Size(56, 20)
        Me.TxtprecioCosto.TabIndex = 193
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 522)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(878, 16)
        Me.StatusBar1.TabIndex = 194
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 561
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=s" & _
    "eepos"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'ck_confirmada
        '
        Me.ck_confirmada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ck_confirmada.BackColor = System.Drawing.Color.Red
        Me.ck_confirmada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_confirmada.ForeColor = System.Drawing.Color.White
        Me.ck_confirmada.Location = New System.Drawing.Point(8, 434)
        Me.ck_confirmada.Name = "ck_confirmada"
        Me.ck_confirmada.Size = New System.Drawing.Size(88, 13)
        Me.ck_confirmada.TabIndex = 195
        Me.ck_confirmada.Text = "Se confirmo"
        Me.ck_confirmada.UseVisualStyleBackColor = False
        '
        'txtconfirmadapor
        '
        Me.txtconfirmadapor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtconfirmadapor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconfirmadapor.Enabled = False
        Me.txtconfirmadapor.Location = New System.Drawing.Point(176, 434)
        Me.txtconfirmadapor.MaxLength = 150
        Me.txtconfirmadapor.Name = "txtconfirmadapor"
        Me.txtconfirmadapor.Size = New System.Drawing.Size(232, 20)
        Me.txtconfirmadapor.TabIndex = 196
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(104, 434)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 197
        Me.Label14.Text = "Nombre:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Cotizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(878, 538)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtconfirmadapor)
        Me.Controls.Add(Me.ck_confirmada)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TxtprecioCosto)
        Me.Controls.Add(Me.TxtMaxdescuento)
        Me.Controls.Add(Me.Txt_TipoCambio_Valor_Compra)
        Me.Controls.Add(Me.Txtcodmoneda_Venta)
        Me.Controls.Add(Me.ValidText2)
        Me.Controls.Add(Me.txtCostoBase)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.MinimumSize = New System.Drawing.Size(744, 500)
        Me.Name = "Frm_Cotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizaciones"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Cotizaciones21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Ck_Exonerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Label_Transporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '        Me.txtPrecioUnit.Focus()
        If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count = 0 Then
            Exit Sub
        End If

        If Not buscando And txtNombreArt.Text <> "" Then
            Buscar_datos_articulo(BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"))
        End If

        If Me.txtCostoBase.Text <> "" And Me.txtPrecioUnit.Text <> "" And Me.txtFlete.Text <> "0" And Me.txtOtros.Text <> "" Then
            TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
        End If


        'MsgBox("cAMBIO" & Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position)
        ' Try

        'BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
        'Me.precio_unitario = txtPrecioUnit.Text


        ' Catch ex As System.Exception
        '   MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")

        ' End Try
    End Sub

    Private Sub Current_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count = 0 Then
            Me.SimpleButton3.Enabled = True
        Else
            Me.SimpleButton3.Enabled = False
        End If
    End Sub


    Private Sub Buscar_datos_articulo(ByVal codigo As String)
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean


        If codigo <> Nothing Then
            sqlConexion = CConexion.Conectar
            If Not IsNumeric(codigo) Then
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, 0 as Fletes, 0 as OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & codigo & "'")
            Else
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, 0 as Fletes, 0 as OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Codigo ='" & codigo & "' or Barras = '" & codigo & "'")
            End If
            Encontrado = False

            While rs.Read
                Try
                    Encontrado = True

                    'If Ck_Exonerar.Checked Then
                    '    'txtImpVenta.Text = Format(0, "#,#0.00")
                    '    txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                    'Else
                    '    'txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                    '    If Me.ClienteRegistradoMAG = True And rs("MAG") = True Then
                    '        'si el producto esta en la lista del mag
                    '        'y si el cliente esta registrado en el mag
                    '        txtImpVenta.Text = Format(1, "#,#0.00")
                    '    Else
                    '        txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                    '    End If
                    'End If

                    If rs("Servicio") Then
                        Me.Existencia = 100
                    Else
                        Me.Existencia = rs("Existencia")
                    End If

                    txtExistencia.Text = Existencia

                    If rs("PreguntaPrecio") Then
                        PrecioA = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        PrecioB = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        PrecioC = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        PrecioD = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                    Else
                        PrecioA = rs("Precio_A")
                        PrecioB = rs("Precio_B")
                        PrecioC = rs("Precio_C")
                        PrecioD = rs("Precio_D")
                    End If

                    Me.precio_promo_valor = rs("Precio_Promo")
                    MonedaCosto = rs("MonedaVenta")

                    MonedaVenta = Me.BindingContext(Me.DataSet_Cotizaciones21, "Moneda").Current("CodMoneda")


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
                Me.txtCod_Articulo.Text = ""
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                Me.txtCodArticulo.Focus()
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


            ValorVenta = CDbl(Me.txtTipoCambio.Text)


            'Calculo_precio_unitario()

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Try


                If Me.promo_activa_valor Then ' si el articulo esta actualmente en promoción 
                    Me.precio_unitario = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)

                    ''Calculo de Costo
                    'txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                    'PrecioBase = txtCostoBase.Text
                    'txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                    'txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                    'Me.precio_unitario = txtPrecioUnit.Text

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

                ''Calculo de Costo
                'txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                'PrecioBase = txtCostoBase.Text
                'txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                'txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                'Me.TxtprecioCosto.Text = (CDbl(Me.TxtprecioCosto.Text) * (ValorBase / ValorVenta))
                'Me.precio_unitario = txtPrecioUnit.Text

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If Me.txtNombreArt.Text <> "" Then 'si se recuperaron los datos de un articulo
                If Me.txtPrecioUnit.Enabled = True Then 'si el usuario puede disminuir o aumentar el costo del articulo
                    Me.txtPrecioUnit.Focus()
                Else
                    If Me.txtDescuento.Enabled = True Then
                        txtDescuento.Focus()

                    Else
                        Me.txtCantidad.Focus()

                    End If

                End If



                'txtCantidad.Focus()
            End If


        Else ' si no se recupero ningun articulo, se termina la edicion

            Try

                BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                txtCod_Articulo.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                CConexion.DesConectar(CConexion.sQlconexion)
            End Try
            CConexion.DesConectar(CConexion.sQlconexion)

        End If

    End Sub



#Region " Variable "                 'Definicion de Variable 
    Private sqlConexion As SqlConnection
    Private sqlConexion2 As SqlConnection
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


#Region "General"
    Function Binding_Detalles()

        Me.txtCotizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Cotizacion"))
        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Moneda.ValorCompra"))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Cotizaciones21, "Cotizacion.MonedaNombre"))
        Me.txtDiasPlazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Dias"))
        opCredito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Cotizaciones21, "Cotizacion.Credito"))
        opContado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Cotizaciones21, "Cotizacion.Contado"))
        Me.ValidText2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Observaciones"))
        Me.txtDiasEntrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.TiempoEntrega"))
        Me.txtDiasValidez.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Validez"))
        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Fecha"))
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Cod_Cliente"))
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Nombre_Cliente"))
        Me.txtContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.Contacto"))

        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.Total"))
        Me.txtSubtotalT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.SubTotal"))
        Me.txtDescuentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.Descuento"))
        Me.txtImpVentaT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.Imp_Venta"))
        Me.Label_Transporte.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.Transporte"))
        Me.Lb_Subgravado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.SubTotalGravada"))
        Me.Lb_SubExento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Cotizaciones21, "Cotizacion.SubTotalExento"))


        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Cotizaciones21, "Cotizacion.Anulado"))
        Me.Ck_Exonerar.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Cotizaciones21, "Cotizacion.Exonerar"))
        Me.ck_confirmada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Cotizaciones21, "Cotizacion.confirmada"))
        Me.txtconfirmadapor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.confirmada_por"))

        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Moneda.Simbolo"))


        'binding detalle cotizacion
        Me.txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Codigo"))
        txtCod_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.CodArticulo"))
        Me.txtNombreArt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Descripcion"))
        Me.txtPrecioUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Precio_Unit"))
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Cantidad"))
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Descuento"))
        Me.txtmontodescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Monto_Descuento"))
        Me.txtImpVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Impuesto"))
        Me.txtMontoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Monto_Impuesto"))
        Me.txtSGravado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.SubtotalGravado"))
        Me.txtSExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.SubTotalExcento"))
        Me.txtSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.SubFamilia"))
        Me.txtCostoBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Precio_Base"))
        Me.txtFlete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Precio_Flete"))
        Me.txtOtros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Precio_Otros"))
        Me.txtSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.SubTotal"))
        Me.TxtMaxdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Max_Descuento"))
        Me.TxtprecioCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Precio_Costo"))
        Me.Txtcodmoneda_Venta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Cod_MonedaVenta"))
        Me.Txt_TipoCambio_Valor_Compra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle.Tipo_Cambio_ValorCompra"))
    End Function
    Private Sub NuevaCotizacion()
        Try
            Ck_Exonerar.Enabled = False
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.GroupBox6.Enabled = False
                Me.GroupBox3.Enabled = False

                '-------------------------------------------------------------------------
                'Variable que indica si la factura fue buscada para despues ser modificada
                busqueda = False
                '-------------------------------------------------------------------------

                Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
                Me.DataSet_Cotizaciones21.Cotizacion.Clear()

                Me.dtFecha.Enabled = False

                txtDiasValidez.Enabled = False
                txtDiasEntrega.Enabled = False
                ValidText2.Enabled = False

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.TxtUtilidad.Text = "0.00"
                Me.txtUsuario.Focus()
                Me.logeado = False
                Me.SimpleButton3.Enabled = False

            Else
                If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count = 0 Then 'Si la factura no tiene detalle
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").CancelCurrentEdit()
                    Edit_Cotizacion = False
                    Me.SimpleButton1.Enabled = False
                    Me.SimpleButton2.Enabled = False
                    Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
                    Me.DataSet_Cotizaciones21.Cotizacion.Clear()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    'Me.ToolBar1.Buttons(3).Enabled = True
                    Me.GroupBox6.Enabled = False
                    Me.GroupBox3.Enabled = False

                    Me.Label10.Visible = False
                    Me.Label11.Visible = False
                    Me.Label_Costobase.Visible = False
                    'Me.txtorden.Enabled = False
                    '-------------------------------------------------------------------------
                    'Variable que indica si la factura fue buscada para despues ser modificada
                    busqueda = False
                    '-------------------------------------------------------------------------

                    Me.dtFecha.Enabled = False

                    Me.logeado = False

                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.SimpleButton3.Enabled = False
                    Me.txtUsuario.Focus()
                    Exit Sub
                End If

                If MessageBox.Show("Desea Guardar esta Cotización", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                    Me.Registrar() ' se guarda en la base de datos
                    Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True

                Else
                    Edit_Cotizacion = False
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").CancelCurrentEdit()
                    Me.SimpleButton1.Enabled = False
                    Me.SimpleButton2.Enabled = False
                    Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
                    Me.DataSet_Cotizaciones21.Cotizacion.Clear()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True
                    Me.GroupBox6.Enabled = False
                    Me.GroupBox3.Enabled = False

                    Me.Label10.Visible = False
                    Me.Label11.Visible = False
                    Me.Label_Costobase.Visible = False

                    Me.SimpleButton3.Enabled = False
                    txtDiasValidez.Enabled = False
                    txtDiasEntrega.Enabled = False
                    ValidText2.Enabled = False
                    Me.dtFecha.Enabled = False
                    Me.logeado = False
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : If PMU.Execute Then NuevaCotizacion() Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 2 : If PMU.Find Then Me.BuscarFactura() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If MessageBox.Show("¿Desea Cerrar el modulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
            Case 7 : If MessageBox.Show("¿Desea Actualizar los precios de los articulos..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then ActualizaPrecioArticulo()

        End Select
    End Sub

    Private Sub CargarInfoExterno(_Cotizacion As Long)
        Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
        Me.DataSet_Cotizaciones21.Cotizacion.Clear()
        Ck_Exonerar.Enabled = False
        Edit_Cotizacion = False

        Me.LlenarVentas(_Cotizacion)
        ' si esta venta aun no ha sido anulada
        'If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Anulado") = False Then Me.ToolBar1.Buttons(3).Enabled = True


        recargar_Cliente()
        Edit_Cotizacion = True
        txtUsuario.Text = ""
        txtUsuario.Enabled = True
        txtNombreUsuario.Text = ""

        Me.GridControl1.Enabled = False
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = False
        Me.GroupBox6.Enabled = False
        ValidText2.Enabled = False
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton2.Enabled = False
        Me.ToolBar1.Buttons(4).Enabled = True
        'Me.ToolBar1.Buttons(0).Enabled = True
        'Me.ToolBar1.Buttons(2).Enabled = True

        'JCGA 25 DE JULIO 2007
        Dim valid As Integer = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Validez")
        Dim Fecha_Cotizacion As Date = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Fecha")

        If Fecha_Cotizacion.AddDays(valid) < Now.Today Then
            MsgBox("Su Cotización ha vencido, si desea actualizar los precios presione " & vbCrLf & "el botón actulizar precios", MsgBoxStyle.Information, "Cotizacion Vencida")
        End If
    End Sub

    Private Sub BuscarFactura()
        Try
            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una Cotizacion, si continúa se perderan los datos de la Cotización actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            '-------------------------------------------------------------------------
            'Variable que indicara si factura fue buscada
            busqueda = True
            '-------------------------------------------------------------------------

            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
            Me.DataSet_Cotizaciones21.Cotizacion.Clear()
            Dim identificador As Double
            Ck_Exonerar.Enabled = False
            Edit_Cotizacion = False
            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Cotizacion, Fecha, Nombre_Cliente AS Cliente, Total as [Total Cotización] from Cotizacion Order by Fecha DESC", "Cliente", "Fecha", "Buscar Cotizacion"))
            'buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                '   Me.buscando = False
                Exit Sub
            End If

            Me.LlenarVentas(identificador)
            ' si esta venta aun no ha sido anulada
            'If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Anulado") = False Then Me.ToolBar1.Buttons(3).Enabled = True


            recargar_Cliente()
            Edit_Cotizacion = True
            txtUsuario.Text = ""
            txtUsuario.Enabled = True
            txtNombreUsuario.Text = ""

            Me.GridControl1.Enabled = False
            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.GroupBox6.Enabled = False
            ValidText2.Enabled = False
            Me.SimpleButton1.Enabled = False
            Me.SimpleButton2.Enabled = False
            Me.ToolBar1.Buttons(4).Enabled = True
            'Me.ToolBar1.Buttons(0).Enabled = True
            'Me.ToolBar1.Buttons(2).Enabled = True

            'JCGA 25 DE JULIO 2007
            Dim valid As Integer = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Validez")
            Dim Fecha_Cotizacion As Date = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Fecha")

            If Fecha_Cotizacion.AddDays(valid) < Now.Today Then
                MsgBox("Su Cotización ha vencido, si desea actualizar los precios presione " & vbCrLf & "el botón actulizar precios", MsgBoxStyle.Information, "Cotizacion Vencida")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try


    End Sub

    Function recargar_Cliente()
        Dim rsm As SqlDataReader
        Dim cambio As Double
        Dim cod_mod As Integer
        sqlConexion = CConexion.Conectar



        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow

        Dim codigo As Long = Me.txtCodigo.Text

        Me.EstaRegistrado(codigo)

        rss = Me.DataSet_Cotizaciones21.Clientes.Select("Identificacion ='" & codigo & "'")

        If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

            Try
                rs = rss(0)
                Me.tipoprecio = rs("tipoprecio")

                cod_mod = rs("CodMonedaCredito")
                If rs("abierto") = "NO" Then

                    Me.opCredito.Enabled = False
                    Me.opCredito.Checked = False
                Else
                    Me.opCredito.Enabled = True
                    Me.opContado.Enabled = True
                    Me.txtDiasPlazo.Enabled = True
                End If
                If rs("sinrestriccion") = "SI" Then sinrestriccion = True Else sinrestriccion = False
                rsm = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & cod_mod)
                While rsm.Read
                    Try
                        cambio = rsm("ValorCompra")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.Conectar)
                    End Try
                End While
                rsm.Close()
                CConexion.DesConectar(CConexion.Conectar)

                max_credito = rs("max_credito") * (cambio / (CDbl(Me.txtTipoCambio.Text)))
                plazo_credito = rs("plazo_credito")
                txtDiasPlazo.Text = plazo_credito
                descuento = rs("descuento")
                Me.impuesto_cliente = rs("impuesto")

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try

        Else
            Me.opCredito.Enabled = False
            Me.impuesto_cliente = 100
        End If

    End Function

    Private Sub CargarTelefono(_Id As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Telefono, CedulaCliente, TipoCedula from Cotizacion where Cotizacion = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtTelefono.Text = dt.Rows(0).Item("Telefono")
            Me.txt_cedula.Text = dt.Rows(0).Item("CedulaCliente")
            Me.cbo_tipo_cliente.Text = dt.Rows(0).Item("TipoCedula")
        Else
            Me.txtTelefono.Text = ""
            Me.txt_cedula.Text = ""
            Me.cbo_tipo_cliente.Text = ""
        End If
    End Sub

    Function LlenarVentas(ByVal Id As Double)
        Me.CargarTelefono(Id)
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
            Dim sel As String = "SELECT * FROM Cotizacion WHERE (Cotizacion = @Id_Factura) "

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
            dv.Fill(Me.DataSet_Cotizaciones21, "Cotizacion")


            '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            'Dim sConn As String = CadenaConexionSeePOS
            'cnn = New SqlConnection(sConn)
            'cnn.Open()

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
            da.Fill(Me.DataSet_Cotizaciones21.Cotizacion_Detalle)


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
    End Function

    'Function imprimir()
    '    Try
    '        Me.ToolBar1.Buttons(4).Enabled = False
    '        Dim coti_reporte As New Reporte_Cotizacion
    '        coti_reporte.SetParameterValue(0, CDbl(txtCotizacion.Text))
    '        If PMU.Others Then
    '            'ESTA LINEAS DE CODIGO SE SUPRIMIERON PARA REALIZAR UN MODIFICACION SOLICITADA POR DEPOSITO EL LIBERIANO YA QUE 
    '            'ELLOS NO QUERIAN MOSTRAR EL COSTO DE LOS ARTICULOS
    '            'If MsgBox("Desea Mostrar los Costos de los artículos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            '    coti_reporte.SetParameterValue(1, True)
    '            'Else
    '            '    coti_reporte.SetParameterValue(1, False)
    '            'End If
    '            coti_reporte.SetParameterValue(1, False)
    '        Else
    '            coti_reporte.SetParameterValue(1, False)
    '        End If
    '        CrystalReportsConexion.LoadShow(coti_reporte, MdiParent)
    '        Me.ToolBar1.Buttons(4).Enabled = True
    '    Catch ex As SystemException
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
    '    End Try
    'End Function

    Private Sub Imprimir()
        Me.ToolBar1.Buttons(4).Enabled = False
        'PARA EL PROXIMO QUE ANDE CON ESTA VARA.. SAJ 28112007 
        'EL MODULO ANALIZA SI EXISTE  EN LA RUTA ESPECIFICADA EL REPORTE EN CUESTION, DADO EL CASO DE QUE EL REPORTE NO EXISTA CARGA EL STANDAR DEL SISTEMA
        Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize


        If System.IO.File.Exists(Application.StartupPath & "\Reportes\Reporte_Cotizacion_Personalizada.rpt") = True Then
            ReporteDocumento.Load(Application.StartupPath & "\Reportes\Reporte_Cotizacion_Personalizada.rpt")
        Else
            If MessageBox.Show("¿Desea imprimir en grande?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                ReporteDocumento = New Reporte_Cotizacion
                ReporteDocumento.SetParameterValue(0, CDbl(txtCotizacion.Text))
                ReporteDocumento.SetParameterValue(1, False)
                CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, CadenaConexionSeePOS, CDbl(txtCotizacion.Text))
            Else
                ReporteDocumento = New Reporte_CotizacionPVEs
                ReporteDocumento.SetParameterValue(0, CDbl(txtCotizacion.Text))
                ReporteDocumento.PrintOptions.PrinterName = Automatic_Printer_Dialog(3)
                CrystalReportsConexion.LoadReportViewer(Nothing, ReporteDocumento, True, CadenaConexionSeePOS)
                ReporteDocumento.PrintToPrinter(1, True, 0, 0)
            End If

        End If

        Me.ToolBar1.Buttons(4).Enabled = True
    End Sub

    '    Private Sub Imprimir()
    '        Me.ToolBar1.Buttons(4).Enabled = False
    '        'PARA EL PROXIMO QUE ANDE CON ESTA VARA.. SAJ 28112007 
    '        'EL MODULO ANALIZA SI EXISTE  EN LA RUTA ESPECIFICADA EL REPORTE EN CUESTION, DADO EL CASO DE QUE EL REPORTE NO EXISTA CARGA EL STANDAR DEL SISTEMA
    '        Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '        ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize

    '        If System.IO.File.Exists(Application.StartupPath & "\Reportes\Reporte_Cotizacion_Personalizada.rpt") = True Then
    '            ReporteDocumento.Load(Application.StartupPath & "\Reportes\Reporte_Cotizacion_Personalizada.rpt")
    '        Else
    '            If MessageBox.Show("¿Desea imprimir en grande?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
    '                ReporteDocumento = New Reporte_Cotizacion
    '                ReporteDocumento.SetParameterValue(0, CDbl(txtCotizacion.Text))
    '                ReporteDocumento.SetParameterValue(1, False)
    '                CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, , txtCotizacion.Text)
    '            Else
    '                ReporteDocumento = New Reporte_CotizacionPVEs
    '                ReporteDocumento.SetParameterValue(0, CDbl(txtCotizacion.Text))
    '                ReporteDocumento.PrintOptions.PrinterName = Automatic_Printer_Dialog(3)
    '                CrystalReportsConexion.LoadReportViewer(Nothing, ReporteDocumento, True, CadenaConexionSeePOS)
    '                ReporteDocumento.PrintToPrinter(1, True, 0, 0)
    '            End If

    '        End If

    '        Me.ToolBar1.Buttons(4).Enabled = True
    '    End Sub

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

    Function Anular()
        Try
            Dim resp As Integer

            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Count > 0 Then
                If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Anular esta Cotización?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()

                        If Registrar_Anulacion_Venta() Then

                            Me.DataSet_Cotizaciones21.AcceptChanges()
                            MsgBox("La Cotizacion ha sido anulada correctamente", MsgBoxStyle.Information)
                            Nueva_Cotizacion()
                            'Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
                            ' Me.DataSet_Cotizaciones21.Cotizacion.Clear()

                            Edit_Cotizacion = False
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

                            Ck_Exonerar.Enabled = False
                            txtDiasValidez.Enabled = False
                            txtDiasEntrega.Enabled = False
                            ValidText2.Enabled = False

                            Me.Label10.Visible = False
                            Me.Label11.Visible = False
                            Me.Label_Costobase.Visible = False

                            Me.logeado = False

                            Me.txtUsuario.Enabled = True
                            Me.txtUsuario.Text = ""
                            Me.txtNombreUsuario.Text = ""
                            Me.txtUsuario.Focus()

                            Me.ToolBar1.Buttons(3).Enabled = False
                            Me.ToolBar1.Buttons(4).Enabled = False

                        End If

                    Else : Exit Function

                    End If
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function


    Function Registrar_Anulacion_Venta() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            Me.SqlUpdateCommand1.Transaction = Trans

            Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")

            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    'Private Sub CargarAgentesActivos()
    '    Dim dt As New DataTable
    '    cFunciones.Llenar_Tabla_Generico("select 0 as Id, 'Sin Agente' as Nombre union select Id, nombre from agente_ventas where activo = 1", dt, CadenaConexionSeePOS)
    '    Me.cboAgentes.DataSource = dt
    '    Me.cboAgentes.DisplayMember = "Nombre"
    '    Me.cboAgentes.ValueMember = "Id"        
    'End Sub

    Private PuedeCambiarPrecios As Boolean = False

    Private Sub Frm_Cotizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim adm As String = 0
            Try
                adm = GetSetting("SeeSOFT", "SeePOS", "adm")
                If adm = "" Then
                    SaveSetting("SeeSOFT", "SeePOS", "adm", "0")
                    adm = "0"
                End If
            Catch ex As Exception
                SaveSetting("SeeSOFT", "SeePOS", "adm", "0")
                adm = "0"
            End Try

            If adm = "1" Then
                Me.Button1.Visible = True
                Me.Button1.Enabled = True
            Else
                Me.Button1.Visible = False
                Me.Button1.Enabled = False
            End If
            Me.colUtilidad.Visible = False
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()

            Me.Adapter_Usuarios.Fill(Me.DataSet_Cotizaciones21, "Usuarios")
            Me.Adapter_Clientes.Fill(Me.DataSet_Cotizaciones21, "Clientes")
            Me.Adapter_Moneda.Fill(Me.DataSet_Cotizaciones21, "Moneda")

            Me.DataSet_Cotizaciones21.Cotizacion.CotizacionColumn.AutoIncrement = True
            Me.DataSet_Cotizaciones21.Cotizacion.CotizacionColumn.AutoIncrementSeed = -1
            Me.DataSet_Cotizaciones21.Cotizacion.CotizacionColumn.AutoIncrementStep = -1


            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.NumeroColumn.AutoIncrement = True
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.NumeroColumn.AutoIncrementSeed = -1
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.NumeroColumn.AutoIncrementStep = -1


            'establecer valores por defecto
            Me.DataSet_Cotizaciones21.Cotizacion.AnuladoColumn.DefaultValue = False
            Me.DataSet_Cotizaciones21.Cotizacion.ContadoColumn.DefaultValue = True
            Me.DataSet_Cotizaciones21.Cotizacion.CreditoColumn.DefaultValue = False
            Me.DataSet_Cotizaciones21.Cotizacion.VentaColumn.DefaultValue = False

            Me.DataSet_Cotizaciones21.Cotizacion.Nombre_ClienteColumn.DefaultValue = "CLIENTE CONTADO"
            Me.DataSet_Cotizaciones21.Cotizacion.Cod_ClienteColumn.DefaultValue = "0"
            Me.DataSet_Cotizaciones21.Cotizacion.SubTotalGravadaColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion.SubTotalExentoColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion.DescuentoColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion.Imp_VentaColumn.DefaultValue = 0
            Me.DataSet_Cotizaciones21.Cotizacion.ExonerarColumn.DefaultValue = False

            Me.DataSet_Cotizaciones21.Cotizacion.TotalColumn.DefaultValue = "0.00"

            Me.DataSet_Cotizaciones21.Cotizacion.FechaColumn.DefaultValue = Date.Now
            Me.DataSet_Cotizaciones21.Cotizacion.ObservacionesColumn.DefaultValue = ""
            Me.DataSet_Cotizaciones21.Cotizacion.ContactoColumn.DefaultValue = ""
            Me.DataSet_Cotizaciones21.Cotizacion.DiasColumn.DefaultValue = "0"
            Me.DataSet_Cotizaciones21.Cotizacion.ValidezColumn.DefaultValue = "1"
            Me.DataSet_Cotizaciones21.Cotizacion.TiempoEntregaColumn.DefaultValue = "0"
            Me.DataSet_Cotizaciones21.Cotizacion.SubTotalColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion.TransporteColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion.PagoImpuestoColumn.DefaultValue = 0


            'valores por defecto del detalle
            DataSet_Cotizaciones21.Cotizacion_Detalle.CodigoColumn.DefaultValue = 0
            DataSet_Cotizaciones21.Cotizacion_Detalle.CodArticuloColumn.DefaultValue = ""
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.DescuentoColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Monto_ImpuestoColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.SubTotalExcentoColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.SubtotalGravadoColumn.DefaultValue = "0.00"
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.CantidadColumn.DefaultValue = "1"
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.SubTotalColumn.DefaultValue = 0

            Me.DataSet_Cotizaciones21.Cotizacion.confirmadaColumn.DefaultValue = False
            Me.DataSet_Cotizaciones21.Cotizacion.confirmada_porColumn.DefaultValue = ""

            'Me.CargarAgentesActivos()

            Me.opContado.Checked = True
            Me.logeado = False

            Binding_Detalles()

            AgregandoNuevoItem = False
            txtUsuario.Focus()

            If Me.IdCotizacionUsuarioExterno > 0 Then
                Me.CargarInfoExterno(Me.IdCotizacionUsuarioExterno)
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub


#End Region


#Region "Validacion Usuario"
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Ck_Exonerar.Enabled = True
            If Edit_Cotizacion Then
                Editar_Cotizacion()
                Exit Sub
            End If
            If Not logeado Then ' si es la primera vez que se logea un usuario
                Loggin_Usuario()
            Else : Me.Reloggin_Usuario()

            End If
        End If

    End Sub

#End Region

    Sub Editar_Cotizacion()
        Try

            If Me.BindingContext(Me.DataSet_Cotizaciones21.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSet_Cotizaciones21.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    'busqueda = False
                    Usua = Usuario_autorizadores(0)

                    Me.logeado = True

                    txtNombreUsuario.Text = Usua("Nombre")

                    If busqueda = False Then
                        Me.Cedula_usuario = Usua("Cedula")
                    Else
                        If Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion").Count > 0 Then
                            Me.Cedula_usuario = Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion").Current("Cedula")
                        Else
                            Me.Cedula_usuario = Usua("Cedula")
                        End If
                    End If

                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña

                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8

                    ''''''''''''''''''''
                    Me.GridControl1.Enabled = True
                    Me.GroupBox1.Enabled = True
                    Me.GroupBox2.Enabled = True
                    Me.GroupBox3.Enabled = True
                    Me.GroupBox6.Enabled = True
                    ValidText2.Enabled = True
                    Me.SimpleButton1.Enabled = True
                    Me.SimpleButton2.Enabled = True
                    Me.ToolBar1.Buttons(4).Enabled = True
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = True

                    If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Anulado") = False Then Me.ToolBar1.Buttons(3).Enabled = True

                    '''''''''''''''''''''''''''''''''''''''''''
                    Me.TxtUtilidad.Text = ""

                    If Usua("CambiarPrecio") = True Then
                        txtPrecioUnit.Enabled = True
                        variacion_Punit = Usua("Porc_Precio")
                    Else
                        txtPrecioUnit.Enabled = False
                        variacion_Punit = 0
                    End If


                    Me.porcentaje_descuento = Usua("Porc_Desc")

                    If Usua("Aplicar_Desc") = False Then 'si el usuario no puede dar descuento
                        Me.SimpleButton2.Enabled = False
                        Me.txtDescuento.Enabled = False

                    Else
                        Me.SimpleButton2.Enabled = True
                        Me.txtDescuento.Enabled = True

                    End If

                    Me.perfil_administrador = PMU.Others
                    Me.Label38.Visible = False
                    Me.Label_Costobase.Visible = False
                    Label50.Visible = False
                    TxtUtilidad.Visible = False


                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    Me.logeado = False
                    txtUsuario.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")

            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub Loggin_Usuario()
        Try

            If Me.BindingContext(Me.DataSet_Cotizaciones21.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSet_Cotizaciones21.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)


                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                    Me.logeado = True

                    txtNombreUsuario.Text = Usua("Nombre")
                    '=====================================================
                    'JCGA 03 DE JULIO 2007
                    If busqueda = False Then
                        Me.Cedula_usuario = Usua("Cedula")
                    Else
                        If Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion").Count > 0 Then
                            Me.Cedula_usuario = Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion").Current("Cedula")
                        Else
                            Me.Cedula_usuario = Usua("Cedula")
                        End If
                    End If
                    '=====================================================

                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña

                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8
                    Me.ToolBar1.Buttons(3).Enabled = False

                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = False

                    Me.TxtUtilidad.Text = ""
                    'Validar si el usuario puede o no anular una cotización
                    Me.Anula_Cotizacion = PMU.Delete
                    Me.PuedeCambiarPrecios = Usua("CambiarPrecio")
                    txtPrecioUnit.Enabled = PuedeCambiarPrecios
                    variacion_Punit = IIf(Usua("CambiarPrecio"), Usua("Porc_Precio"), 0)
                    Me.porcentaje_descuento = Usua("Porc_Desc")
                    Me.SimpleButton2.Enabled = Usua("Aplicar_Desc") 'si el usuario no puede dar descuento
                    Me.txtDescuento.Enabled = Usua("Aplicar_Desc") 'si el usuario no puede dar descuento
                    Me.perfil_administrador = PMU.Others ' si el usuario tiene perfil de administrador 
                    Me.Label38.Visible = False
                    Me.Label_Costobase.Visible = False
                    Label50.Visible = False
                    TxtUtilidad.Visible = False
                    Ck_Exonerar.Enabled = PMU.Others
                    txtCod_Articulo.Width = IIf(False, 64, Me.txtPrecioUnit.Location.X - Me.txtCod_Articulo.Location.X - 10)

                    Me.ComboBox1.Enabled = True
                    Me.Nueva_Cotizacion()
                    Me.ComboBox1.Focus()
                    Me.Inicializar()
                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    Me.logeado = False
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
        Try

            If Me.BindingContext(Me.DataSet_Cotizaciones21.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSet_Cotizaciones21.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then  Else MsgBox("No tiene permiso sobre este módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
                    'si el usuario no puede dar descuento
                    Me.SimpleButton2.Enabled = Usua("Aplicar_Desc")
                    Me.txtDescuento.Enabled = Usua("Aplicar_Desc")
                    Me.GroupBox6.Enabled = True
                    Me.GroupBox3.Enabled = True
                    Me.GroupBox1.Enabled = True
                    txtNombreUsuario.Text = Usua("Nombre")
                    Me.Anula_Cotizacion = PMU.Delete 'Validar si el usuario puede o no anular una cotizacion

                    txtPrecioUnit.Enabled = Usua("CambiarPrecio")
                    variacion_Punit = IIf(Usua("CambiarPrecio"), Usua("Porc_Precio"), 0)
                    Me.porcentaje_descuento = Usua("Porc_Desc")

                    Me.perfil_administrador = PMU.Others ' si el usuario tiene perfil de administrador
                    Me.Label38.Visible = False ' si el usuario tiene perfil de administrador
                    Me.Label_Costobase.Visible = False ' si el usuario tiene perfil de administrador
                    Ck_Exonerar.Enabled = PMU.Others
                    Me.txtDescuento.Focus()

                Else ' si no existe una contraseñla como esta
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

    Private Sub Nueva_Cotizacion()
        Try
            Me.colUtilidad.Visible = False
            Me.txtTelefono.Text = ""
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
            Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()

            Me.DataSet_Cotizaciones21.Cotizacion.FechaColumn.DefaultValue = Date.Now
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").AddNew()


            Me.impuesto_cliente = 100
            Me.tipoprecio = 1
            Me.ComboBox1.SelectedIndex = 0

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
            'Verificar_Consecutivos()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try


    End Sub



#Region "Cotizacion"

    Private Sub opContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opContado.CheckedChanged
        dias_credito()
    End Sub

    Private Sub Codigo_Barras()
        Dim dts As New DataTable
        Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
        For i As Integer = 0 To Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i
            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("CodArticulo") = "" Then
                cFunciones.Llenar_Tabla_Generico("select Cod_Articulo from inventario where codigo = " & Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo"), dts, CadenaConexionSeePOS)
                If dts.Rows.Count > 0 Then
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("CodArticulo") = dts.Rows(0).Item("Cod_Articulo")
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
                End If
            End If
        Next
    End Sub

    'Private Telefono As String = ""

    Function Registrar()
        Try
            Dim Contacto As String = ""
            Dim frm As New frmContactoCotizacion
            frm.txtContacto.Text = Me.txtContacto.Text
            frm.txtTelefono.Text = Me.txtTelefono.Text
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtTelefono.Text = frm.txtTelefono.Text
                Contacto = frm.txtContacto.Text
            Else
                Exit Function
            End If

            If Me.ck_confirmada.Checked And Me.txtconfirmadapor.Text = "" Then
                MsgBox("Marco la opción de confirmada, por favor ingrese el nombre de la persona con la que confirmo la cotización.", MsgBoxStyle.Critical, "Cotizaciones")
                Me.txtconfirmadapor.Focus()
                Exit Function
            Else
                BindingContext(DataSet_Cotizaciones21, "Cotizacion").Current("confirmada_por") = Me.txtconfirmadapor.Text
                BindingContext(DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
            End If

            ToolBar1.Buttons(2).Enabled = False
            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count = 0 Then 'Si la factura no tiene detalle
                MsgBox("No se Puede Registrar una Cotización si no contiene artículos", MsgBoxStyle.Critical)
                Exit Function
            End If
            If Not PMU.Update Then MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Function

            If MessageBox.Show("¿Desea Registrar esta Cotización?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                ToolBar1.Buttons(2).Enabled = True
                Exit Function
            End If

            Me.Codigo_Barras()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("pagoImpuesto") = impuesto_cliente
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()

            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()

            If Me.RegistrarVenta() Then 'se registra en la base de datos then
                Edit_Cotizacion = False
                Me.DataSet_Cotizaciones21.AcceptChanges()

                Try
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    'Ojo aqui agregar tipocedula y cedula
                    db.Ejecutar("Update Cotizacion set TipoCedula = '" & cbo_tipo_cliente.Text & "', CedulaCliente = '" & Me.txt_cedula.Text & "', Contacto = '" & Contacto & "', Telefono = '" & txtTelefono.Text & "' Where Cotizacion = " & CDbl(txtCotizacion.Text), CommandType.Text)
                    Me.txtTelefono.Text = ""
                Catch ex As Exception
                End Try

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
                Me.GroupBox1.Enabled = False
                txtDiasValidez.Enabled = False
                txtDiasEntrega.Enabled = False
                ValidText2.Enabled = False
                Ck_Exonerar.Enabled = False

                Me.Label10.Visible = False
                Me.Label11.Visible = False
                Me.Label_Costobase.Visible = False

                Me.logeado = False

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""

                Me.TxtUtilidad.Text = "0.00"

                Me.txtUsuario.Focus()

                Me.SimpleButton3.Enabled = False

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = True

                If MessageBox.Show("¿Desea imprimir esta Cotización?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Imprimir()
                End If

                Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Clear()
                Me.DataSet_Cotizaciones21.Cotizacion.Clear()

            Else
                MsgBox("error")



                Me.ToolBar1.Buttons(2).Enabled = True
                'Me.txtUsuario.Enabled = True



            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub test()
        Try
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()

            For i As Integer = 0 To Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cotizacion") = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Cotizacion")
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
            Next
        Catch ex As Exception

        End Try
    End Sub

    Function RegistrarVenta() As Boolean

        Me.test()

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.SqlInsertCommand1.Transaction = Trans
            Me.SqlUpdateCommand1.Transaction = Trans
            Me.SqlDeleteCommand1.Transaction = Trans

            Me.SqlInsertCommand2.Transaction = Trans
            Me.SqlUpdateCommand2.Transaction = Trans
            Me.SqlDeleteCommand2.Transaction = Trans

            'Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")
            Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")
            Me.Adapter_Cotizacion_Detalle.Update(Me.DataSet_Cotizaciones21, "Cotizacion_Detalle")
            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
    Private Sub txtDiasEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiasEntrega.KeyDown
        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            'If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Count = 0 Then
            Me.Iniciar_Cotizacion()
            'End If
            'Me.txtCodArticulo.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If
    End Sub

    Function Inicializar()
        Try
            If Me.ComboBox1.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar la Moneda en la que se va a cotizar", MsgBoxStyle.Exclamation)
                Exit Function
            End If

            Me.GroupBox6.Enabled = True

            Me.GroupBox1.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.dtFecha.Enabled = True
            txtDiasValidez.Enabled = True
            txtDiasEntrega.Enabled = True
            Me.ValidText2.Enabled = True
            'Me.txtCodigo.Focus()
            Me.txt_cedula.Focus()
            Me.ComboBox1.Enabled = False
            Me.SimpleButton3.Enabled = True
            Ck_Exonerar.Enabled = PMU.Others

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function Iniciar_Cotizacion()
        Try
            Dim nom As String = Me.txtNombre.Text
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("CodMoneda") = Me.BindingContext(Me.DataSet_Cotizaciones21, "Moneda").Current("CodMoneda")
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Cedula") = Me.Cedula_usuario
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("pagoImpuesto") = impuesto_cliente
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Tipo_Cambio") = CDbl(txtTipoCambio.Text)

            Me.txtNombre.Text = nom
            If Me.txtCodigo.Text = "" Then Me.txtCodigo.Text = "0"


            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()

            Me.SimpleButton1.Enabled = True

            Me.ToolBar1.Buttons(2).Enabled = True 'se activa el botond e guardar

            Me.GroupBox3.Enabled = True
            Me.GroupBox4.Enabled = True

            'Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            'Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
            txtCod_Articulo.Focus()


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function



    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Me.Inicializar()

            'If Me.ComboBox1.SelectedIndex = -1 Then
            '    MsgBox("Debe Seleccionar la Moneda en la que se va a cotizar", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            'Me.GroupBox6.Enabled = True

            'Me.GroupBox1.Enabled = True
            'Me.GroupBox2.Enabled = True
            'Me.dtFecha.Enabled = True
            'txtDiasValidez.Enabled = True
            'txtDiasEntrega.Enabled = True
            'Me.ValidText2.Enabled = True
            'Me.ComboBox1.Enabled = False

            'Me.txtCodigo.Focus()
        End If
    End Sub

#End Region


#Region "Artículos"
    '=======================================================================================
    'JCGA 03 AGOSTO 2007
    'METODO ENCARGADO DE ACTUALIZAR LOS PRECIOS DE LOS ARTICULO DE UNA COTIZACION
    'ESTE ES MUY PARECIDO AL METODO CargarInformacionArticulo CON LA DIFERENCIA QUE ESTE SELECCIONA MENOS CAMPOS QUE EL MENCIONADO
    ' Y ESTE METODO ACTUALIZA LOS DATOS MIENTRAS QUE CargarInformacionArticulo ASIGNA VALORES A LOS NUEVOS CAMPOS, EL METODO CargarInformacionArticulo
    ' FUE LA BASE DE ESTE NADA MAS QUE SE MODIFICO PARA LO QUE SE NECESITABA EN ESE MOMENTO
    Private Sub CargarInformacionActualizaPrecios(ByVal Codigo As String)

        Dim rs As SqlDataReader
        Dim Encontrado As Boolean
        If Codigo <> Nothing Then
            sqlConexion = CConexion.Conectar

            If Not IsNumeric(Codigo) Then
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, 0 as Fletes, 0 as OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & Codigo & "'")
            Else
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, 0 as Fletes, 0 as OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Codigo ='" & Codigo & "' or Barras = '" & Codigo & "'")
            End If
            Encontrado = False

            Dim i As Integer = 0

            While rs.Read
                Try

                    If Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo") = Codigo Then
                        '********************************************************************************************************
                        Encontrado = True

                        If Ck_Exonerar.Checked Then
                            'txtImpVenta.Text = Format(0, "#,#0.00")
                            txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                        Else
                            'txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                            If Me.ClienteRegistradoMAG = True And rs("MAG") = True Then
                                'si el producto esta en la lista del mag
                                'y si el cliente esta registrado en el mag
                                txtImpVenta.Text = Format(1, "#,#0.00")
                            Else
                                txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                            End If
                        End If

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
                        txtExistencia.Text = Existencia

                        If rs("PreguntaPrecio") Then
                            PrecioA = BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Unit")
                            PrecioB = BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Unit")
                            PrecioC = BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Unit")
                            PrecioD = BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Unit")
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
                        MonedaVenta = Me.BindingContext(Me.DataSet_Cotizaciones21, "Moneda").Current("CodMoneda")
                        If rs("Promo_Activa") = True Then ' si el articulo esta en promocion
                            Me.promo_activa_valor = True
                            Me.txtDescuento.Enabled = False

                            MsgBox("Este artículo está en promoción", MsgBoxStyle.Information)

                        Else
                            Me.promo_activa_valor = False ' se habilita el text
                            Me.txtDescuento.Enabled = True
                        End If
                        '*********************************************************************************************************
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While

            rs.Close()


            If Not Encontrado Then
                MsgBox("No existe o esta inhabilitado un artículo con este código", MsgBoxStyle.Exclamation)
                txtCod_Articulo.Focus()
                CConexion.DesConectar(CConexion.Conectar)
                Exit Sub
            End If

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaCosto)
            While rs.Read
                Try
                    ValorCosto = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
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
                    CConexion.DesConectar(CConexion.Conectar)
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
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()



            Calculo_precio_unitario()



            If Me.txtNombreArt.Text <> "" Then 'si se recuperaron los datos de un articulo
                If Me.txtPrecioUnit.Enabled = True Then 'si el usuario puede disminuir o aumentar el costo del articulo

                    If Me.TxtUtilidad.Visible = True Then
                        Me.TxtUtilidad.Focus()
                    Else
                        Me.txtPrecioUnit.Focus()
                    End If

                Else
                    If Me.txtDescuento.Enabled = True Then
                        txtDescuento.Focus()

                    Else
                        Me.txtCantidad.Focus()

                    End If

                End If
            End If


        Else ' si no se recupero ningun articulo, se termina la edicion

            Try

                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                txtCod_Articulo.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                CConexion.DesConectar(CConexion.sQlconexion)
            End Try

            CConexion.DesConectar(CConexion.sQlconexion)

        End If
        Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
        Me.AgregandoNuevoItem = True
    End Sub

    'Private Sub CargarPrecioAgente()
    '    Dim dt As New DataTable
    '    cFunciones.Llenar_Tabla_Generico("Select TipoPrecio from agente_ventas where id = " & Me.cboAgentes.SelectedValue, dt, CadenaConexionSeePOS)
    '    If dt.Rows.Count > 0 Then
    '        Me.tipoprecio = dt.Rows(0).Item("TipoPrecio")
    '    End If
    'End Sub

    Private Sub CargarInformacionArticulo(ByVal codigo As String, Optional ByVal recargar As Boolean = False)
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean

        If codigo <> Nothing Then
            sqlConexion = CConexion.Conectar

            rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, 0 as Fletes, 0 as OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, MAG, PreguntaPrecio, Servicio, Minima, Cod_Articulo from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE Inhabilitado = 0 and (Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "' or barras2 = '" & codigo & "' or barras3 = '" & codigo & "')")
            Encontrado = False

            While rs.Read
                Try

                    Encontrado = True
                    txtCodArticulo.Text = rs("Codigo")
                    txtCod_Articulo.Text = rs("Cod_Articulo")
                    AgregandoNuevoItem = True

                    If Excento(CDbl(txtCodArticulo.Text)) = True Then
                        txtNombreArt.Text = "*  " & rs("Descripcion")
                    Else
                        txtNombreArt.Text = rs("Descripcion")
                    End If

                    If Ck_Exonerar.Checked Then
                        'txtImpVenta.Text = Format(0, "#,#0.00")
                        txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                    Else
                        'txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                        If Me.ClienteRegistradoMAG = True And rs("MAG") = True Then
                            'si el producto esta en la lista del mag
                            'y si el cliente esta registrado en el mag
                            txtImpVenta.Text = Format(1, "#,#0.00")
                        Else
                            txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                        End If
                    End If

                    BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Impuesto") = txtImpVenta.Text
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
                                BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                                BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").AddNew()
                                txtCod_Articulo.Focus()
                                CConexion.DesConectar(CConexion.sQlconexion)
                            End If
                            Precio.Dispose()
                        Else
                            PrecioA = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            PrecioB = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            PrecioC = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            PrecioD = BindingContext(DataSet_Cotizaciones21, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
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

                    MonedaVenta = Me.BindingContext(Me.DataSet_Cotizaciones21, "Moneda").Current("CodMoneda")

                    If rs("Promo_Activa") = True Then ' si el articulo esta en promocion
                        Me.promo_activa_valor = True
                        Me.txtDescuento.Enabled = False

                        MsgBox("Este artículo está en promoción", MsgBoxStyle.Information)

                    Else
                        Me.promo_activa_valor = False ' se habilita el text
                        Me.txtDescuento.Enabled = True
                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()


            If Not Encontrado Then
                MsgBox("No existe o esta inhabilitado un artículo con este código", MsgBoxStyle.Exclamation)
                BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                txtCod_Articulo.Focus()
                CConexion.DesConectar(CConexion.Conectar)
                Exit Sub
            End If

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaCosto)
            While rs.Read
                Try
                    ValorCosto = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
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
                    CConexion.DesConectar(CConexion.Conectar)
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
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()



            Calculo_precio_unitario()



            If Me.txtNombreArt.Text <> "" Then 'si se recuperaron los datos de un articulo
                If Me.txtPrecioUnit.Enabled = True Then 'si el usuario puede disminuir o aumentar el costo del articulo

                    If Me.TxtUtilidad.Visible = True Then
                        Me.TxtUtilidad.Focus()
                    Else
                        Me.txtPrecioUnit.Focus()
                    End If

                Else
                    If Me.txtDescuento.Enabled = True Then
                        txtDescuento.Focus()

                    Else
                        Me.txtCantidad.Focus()

                    End If

                End If
            End If
        Else ' si no se recupero ningun articulo, se termina la edicion

            Try

                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                txtCod_Articulo.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                CConexion.DesConectar(CConexion.sQlconexion)
            End Try

            CConexion.DesConectar(CConexion.sQlconexion)

        End If
        Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
        Me.AgregandoNuevoItem = True
    End Sub

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

    Function Calculo_precio_unitario()
        Try

            'Me.CargarPrecioAgente()

            If Me.promo_activa_valor Then ' si el articulo esta actualmente en promoción 
                txtPrecioUnit.Text = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)

                'Calculo de Costo
                txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                PrecioBase = txtCostoBase.Text
                txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                Me.precio_unitario = txtPrecioUnit.Text

                Exit Function
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

            If txtPrecioUnit.Text <> "" Then
                txtPrecioUnit.Text = Math.Round(CDbl(txtPrecioUnit.Text), 2)
                Me.precio_unitario = txtPrecioUnit.Text
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Function

    Private Sub txtCodArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod_Articulo.KeyDown
        Dim cod_art As String
        Dim BuscarArt As New FrmBuscarArticulo2
        Select Case e.KeyCode
            Case Keys.F1
                Try
                    BuscarArt.StartPosition = FormStartPosition.CenterParent
                    BuscarArt.Cod_Articulo = True
                    BuscarArt.SoloSinBarras = True
                    BuscarArt.ShowDialog()
                    cod_art = BuscarArt.Codigo

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()

                    If BuscarArt.Cancelado Then
                        BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                        BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                        Exit Sub
                    End If

                    BuscarArt.Dispose()
                    CargarInformacionArticulo(cod_art)
                    txtPrecioUnit.Enabled = PuedeCambiarPrecios
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                End Try

            Case Keys.F2 : Me.Registrar()

            Case Keys.Enter
                'aqui
                Try
                    If Me.txtCod_Articulo.Text = "" Or Me.txtCod_Articulo.Text = "0" Then Exit Sub
                    cod_art = Me.txtCod_Articulo.Text
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                    CargarInformacionArticulo(cod_art)
                    txtPrecioUnit.Enabled = PuedeCambiarPrecios

                Catch ex As SystemException
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                End Try


        End Select
    End Sub
#End Region

    Private Sub ActualizaPrecioArticulo()
        Try

            If Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion_Detalle").Count > 0 Then



                Dim dtrDetalle As System.Data.DataRow
                Dim i As Integer = 0
                'Cargo los códigos de los productos que estan en la cotización y los almaceno en la tabla Detalle_Articulo la cual después me permitira 
                'asignar los productos que se encontraban en la cotización
                'RECORRO LA TABLA COTIZACION_DETALLE Y ALMACENO LOS DATOS EN LA TABLA DETALLE_ARTICULO
                For i = 0 To Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1

                    Dim strCodigoArticulo As String = ""
                    Dim strCantidad1 As String = ""
                    Dim strUtilidad As String = ""
                    Dim strDescuento As String = ""
                    Dim strMontoDescuento As String = ""

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i

                    strCodigoArticulo = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")
                    strCantidad1 = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")
                    strDescuento = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descuento")
                    strMontoDescuento = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Monto_Descuento")

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").EndCurrentEdit()
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").AddNew()
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").Current("Codigo") = strCodigoArticulo
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").Current("Cantidad") = CDbl(strCantidad1)
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").Current("Descuento") = CDbl(strDescuento)
                    ' Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").Current("Monto_Descuento") = CDbl(strMontoDescuento)

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Detalle_Articulo").EndCurrentEdit()

                Next

                Dim strCod_art As String = ""
                Dim strCantidad As String = ""

                'AGREGO LOS ARTICULOS DE LA COTIZACION CON LOS NUEVOS PRECIOS
                For i = 0 To Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1

                    Dim strUtilidad As String = ""
                    Dim strDescuento As String = ""

                    Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i
                    strCod_art = Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")
                    strCantidad = Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Cantidad")
                    strDescuento = Me.BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Monto_Descuento")

                    CargarInformacionActualizaPrecios(strCod_art)
                    Me.txtCantidad.Text = CDbl(strCantidad)
                    Me.txtDescuento.Text = CDbl(strDescuento)

                    Calculos_Articulo()
                    Validar_Punitario()
                    Calcular_totales()

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()

                Next
                'Limpio la tabla Detalle_Articulo
                Me.DataSet_Cotizaciones21.Detalle_Articulo.Clear()
                MsgBox("Datos Actualizados con exito...!!", MsgBoxStyle.Information, "Datos Actualizados")

            Else
                MsgBox("No hay sufientes datos para realizar esta accion", MsgBoxStyle.Critical, "Atencion..")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Problemas al actualzar los precios de los productos..")
        End Try
    End Sub

#Region "Cliente"

    Private Sub txtCodigo_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim cFunciones As New cFunciones
                Dim c As String

                c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

                If c <> "" Then
                    Me.txtCodigo.Text = c
                Else
                    Exit Sub
                End If

                If Me.txtCodigo.Text <> "" And Me.txtCodigo.Text <> "0" Then
                    'sqlConexion = CConexion.Conectar
                    CargarInformacionCliente(txtCodigo.Text)
                Else
                    Exit Sub
                End If
            End If


            If e.KeyCode = Keys.Enter Then ' si se digito enter
                Me.txtNombre.Text = ""
                Me.txtNombre.Enabled = True
                impuesto_cliente = 100

                If Me.txtCodigo.Text <> "" And Me.txtCodigo.Text <> "0" Then
                    CargarInformacionCliente(txtCodigo.Text)
                    'txtCod_Articulo.Focus()
                Else
                    Me.txtNombre.Text = "CLIENTE CONTADO"
                    Me.txtCodigo.Text = "0"
                    Me.opCredito.Checked = False
                    Me.opContado.Checked = True
                    Me.opCredito.Enabled = False
                    Me.impuesto_cliente = 100
                    Exit Sub
                End If
            End If

            If e.KeyCode = Keys.F2 Then
                Me.Registrar()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub BuscarIdentificacion()
        Try
            If Me.txt_cedula.Text.Length >= 9 And Me.txt_cedula.Text.Length <= 12 Then
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(Me.txt_cedula.Text)
                'Me.BanderaPuedeCambiarTipoCliente = True
                Select Case ObtenerDatosCliente.tipoIdentificacion
                    Case "01" : Me.cbo_tipo_cliente.SelectedIndex = 0
                    Case "02" : Me.cbo_tipo_cliente.SelectedIndex = 1
                    Case "03" : Me.cbo_tipo_cliente.SelectedIndex = 2
                End Select
                'Me.BanderaPuedeCambiarTipoCliente = False
                Me.txtNombre.Text = ObtenerDatosCliente.nombre
                'IngresoIdentificacion = True
            Else
                Me.cbo_tipo_cliente.SelectedIndex = 0
                Me.txtNombre.Text = ""
                'IngresoIdentificacion = False
            End If
        Catch ex As Exception
            Me.cbo_tipo_cliente.SelectedIndex = 0
            Me.txtNombre.Text = ""
            'IngresoIdentificacion = False
        End Try
    End Sub

    Function existe_cedula(ByVal cedula As String)
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from clientes where cedula = '" & cedula & "'", dts, CadenaConexionSeePOS)

            If dts.Rows.Count > 0 Then
                txtCodigo.Text = dts.Rows(0).Item("identificacion")
                'Me.cliente_normal = True
                'Me.btn_cliente_nuevo.Enabled = False
                Return True
            End If
            'Me.btn_cliente_nuevo.Enabled = True
            Return False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub BuscarCliente()
        'creado 10 de sep 2019
        Me.BuscarIdentificacion()

        If txt_cedula.Text = "" Then
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = 0
            txtCodigo.Text = 0
            txt_cedula.Text = 0
        End If

        If existe_cedula(txt_cedula.Text) = False Then
            Me.txtCodigo.Text = txt_cedula.Text
        End If

        If txt_cedula.Text = "0" Then
            txtCodigo.Text = 0
        End If

        If txtCodigo.Text = 0 Then
            'btn_cliente_nuevo.Enabled = True
            txtNombre.Text = "Cliente de Contado"
            'nombre_editable()
        End If

        'Me.cliente_normal = True
        If Me.txtCodigo.Text <> "" Then
            'Me.Cargar_Cliente(txtcodigo.Text)
        End If
        'enter_cod_cliente()
        Me.txtCod_Articulo.SelectAll()
        Application.DoEvents()
        'If Me.GroupBox3.Enabled = False Then Me.iniciar_factura()
        Me.txtCod_Articulo.Focus()
    End Sub

    Private Sub CargarInformacionCliente(ByVal codigo As String)
        '''Dim rss() As System.Data.DataRow
        '''Dim rs As System.Data.DataRow
        '''Dim rsm As SqlDataReader
        '''Dim cod_mod As Integer
        '''Dim cambio As Double


        '''sqlConexion = CConexion.Conectar
        '''If codigo <> Nothing Then

        '''    rss = Me.DataSet_Cotizaciones21.Clientes.Select("Identificacion ='" & codigo & "'")

        '''    If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

        '''        Try
        '''            rs = rss(0)
        '''            txtCodigo.Text = rs("Identificacion")

        '''            ''''''''''''''''
        '''            txtNombre.Text = rs("nombre")
        '''            txtNombre.Enabled = False

        '''            cod_mod = rs("CodMonedaCredito")
        '''            If rs("abierto") = "NO" Then

        '''                Me.opCredito.Enabled = False
        '''                Me.opCredito.Checked = False
        '''                Me.opContado.Checked = True

        '''            Else

        '''                Me.opCredito.Enabled = True
        '''                Me.opContado.Enabled = True
        '''                Me.opContado.Checked = True
        '''                Me.txtDiasPlazo.Enabled = True

        '''            End If

        '''            If rs("sinrestriccion") = "SI" Then
        '''                sinrestriccion = True
        '''            Else
        '''                sinrestriccion = False
        '''            End If


        '''            rsm = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & cod_mod)
        '''            While rsm.Read
        '''                Try
        '''                    cambio = rsm("ValorCompra")
        '''                Catch ex As Exception
        '''                    MessageBox.Show(ex.Message)
        '''                    CConexion.DesConectar(CConexion.Conectar)
        '''                End Try
        '''            End While
        '''            rsm.Close()
        '''            CConexion.DesConectar(CConexion.Conectar)


        '''            max_credito = rs("max_credito") * (cambio / (CDbl(Me.txtTipoCambio.Text)))
        '''            plazo_credito = rs("plazo_credito")
        '''            txtDiasPlazo.Text = plazo_credito
        '''            descuento = rs("descuento")
        '''            tipoprecio = rs("tipoprecio")
        '''            impuesto_cliente = rs("impuesto")


        '''            'Me.txtContacto.Focus()


        '''            ''''''''''''''''

        '''            'si actualmente esta cotizacion tiene artìculos
        '''            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then
        '''                Me.recalcular_cotizacion_cambio_cliente()
        '''            End If

        '''        Catch ex As Exception
        '''            MessageBox.Show(ex.Message)
        '''        End Try
        '''    Else ' si no se encontro el cliente

        '''        MsgBox("No existe un cliente con ese código", MsgBoxStyle.Exclamation)
        '''        Me.txtCodigo.Text = ""
        '''        Me.txtNombre.Text = "CLIENTE CONTADO"
        '''        Me.txtCodigo.Focus()
        '''        abierto = False
        '''        sinrestriccion = False
        '''        impuesto_cliente = 100
        '''        max_credito = 0
        '''        plazo_credito = 0
        '''        descuento = 0
        '''        tipoprecio = 1
        '''        txtNombre.Enabled = True
        '''        Me.opCredito.Enabled = False
        '''        Me.opCredito.Checked = False
        '''        Me.opContado.Checked = True
        '''    End If


        '''Else 'se dio el boton de cancelar o no se selecciono ninguno

        '''    Me.txtCodigo.Text = ""

        '''    Me.txtNombre.Text = "CLIENTE CONTADO"
        '''    ' Me.txtCodigo.Focus()
        '''    abierto = False
        '''    sinrestriccion = False
        '''    impuesto_cliente = 100
        '''    max_credito = 0
        '''    plazo_credito = 0
        '''    descuento = 0
        '''    tipoprecio = 1
        '''    txtNombre.Enabled = True
        '''End If

        '*********************************************************************************************************
        '*********************************************************************************************************
        '*********************************************************************************************************

        'Dim rss() As System.Data.DataRow
        Dim rs As SqlDataReader
        Dim rsm As SqlDataReader
        Dim Encontrado As Boolean
        Dim cod_mod As Integer
        Dim cambio As Double

        If codigo <> Nothing Then

            Me.EstaRegistrado(codigo)
            sqlConexion = CConexion.Conectar
            rs = CConexion.GetRecorset(sqlConexion, "SELECT cedula, nombre, abierto, impuesto, max_credito, Plazo_credito, descuento, tipoprecio, sinrestriccion, identificacion, CodMonedaCredito, TipoCliente FROM Clientes where identificacion = '" & codigo & "' or cedula = '" & codigo & "'")

            Encontrado = False

            'rss = Me.DataSet_Cotizaciones21.Clientes.Select("Identificacion ='" & codigo & "'")

            'If rss.Length <> 0 Then ' si existe un cliente con ese còdigo
            While rs.Read
                Try
                    'rs = rss(0)
                    Encontrado = True

                    Me.cbo_tipo_cliente.Text = rs("TipoCliente")
                    txtCodigo.Text = rs("Identificacion")

                    ''''''''''''''''
                    Me.txt_cedula.Text = rs("cedula")
                    txtNombre.Text = rs("nombre")
                    txtNombre.Enabled = False

                    cod_mod = rs("CodMonedaCredito")
                    If rs("abierto") = "NO" Then

                        Me.opCredito.Enabled = False
                        Me.opCredito.Checked = False
                        Me.opContado.Checked = True

                    Else

                        Me.opCredito.Enabled = True
                        Me.opContado.Enabled = True
                        Me.opContado.Checked = True
                        Me.txtDiasPlazo.Enabled = True

                    End If

                    If rs("sinrestriccion") = "SI" Then
                        sinrestriccion = True
                    Else
                        sinrestriccion = False
                    End If

                    sqlConexion2 = CConexion2.Conectar
                    rsm = CConexion2.GetRecorset(sqlConexion2, "Select ValorCompra from Moneda where CodMoneda = " & cod_mod)
                    While rsm.Read
                        Try
                            cambio = rsm("ValorCompra")
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            CConexion.DesConectar(CConexion.Conectar)
                        End Try
                    End While
                    rsm.Close()
                    CConexion2.DesConectar(CConexion2.Conectar)


                    max_credito = rs("max_credito") * (cambio / (CDbl(Me.txtTipoCambio.Text)))
                    plazo_credito = rs("plazo_credito")
                    txtDiasPlazo.Text = plazo_credito
                    descuento = rs("descuento")
                    tipoprecio = rs("tipoprecio")
                    impuesto_cliente = rs("impuesto")
                    Me.txtContacto.Focus()

                    'Me.txtContacto.Focus()


                    ''''''''''''''''

                    ''si actualmente esta cotizacion tiene artìculos
                    'If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then
                    '    Me.recalcular_cotizacion_cambio_cliente()
                    'End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End While
            rs.Close()

            If Not Encontrado Then

                Me.txtCodigo.Text = ""
                Me.txtNombre.Text = "CLIENTE CONTADO"
                'Me.txtCodigo.Focus()

                Me.BuscarIdentificacion()
                Me.txtNombre.Focus()

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
                CConexion.DesConectar(CConexion.Conectar)
                Exit Sub

            End If

            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then
                Me.recalcular_cotizacion_cambio_cliente()
                MsgBox("Cotización actualizada de acuerdo al cliente", MsgBoxStyle.Information)
            End If


        Else 'se dio el boton de cancelar o no se selecciono ninguno

            Me.txtCodigo.Text = ""

            Me.txtNombre.Text = "CLIENTE CONTADO"
            ' Me.txtCodigo.Focus()
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


    Function recalcular_cotizacion_cambio_cliente()
        Dim i As Integer

        BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()

        If BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then
            For i = 0 To Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1
                BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i
                CargarInformacionArticulo(txtCod_Articulo.Text, True)
                Calculos_Articulo() ' se calcula de nuevo los datos del articulo cotizado
                BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
            Next
            Calcular_Totales_Cotizacion()
        End If

        BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
        BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
        BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
    End Function
#End Region




#Region "Calculos Artículos"

    'Private Sub Calculos_Articulo()

    '    Try
    '        calculo_descuento_articulo()

    '        Me.txtImpVenta.Text = Me.impuesto_cliente * CDbl(Me.txtImpVenta.Text) / 100

    '        If txtImpVenta.Text <> 0 Then 'si tiene impuesto de venta
    '            If (CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) > CDbl(txtPrecioUnit.Text) Then
    '                txtFlete.Text = 0
    '                txtOtros.Text = 0
    '            End If
    '            Gravado = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
    '            txtMontoImpuesto.Text = Gravado * (CDbl(txtImpVenta.Text) / 100)
    '            txtSGravado.Text = Gravado
    '            Exento = 0

    '        Else 'si no tiene impuesto de venta
    '            Exento = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
    '            Gravado = 0
    '            txtMontoImpuesto.Text = 0
    '            txtSGravado.Text = 0
    '            txtSExcento.Text = Exento
    '        End If

    '        Exento = Exento + ((CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
    '        txtSExcento.Text = Exento
    '        txtSubtotal.Text = CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text) + CDbl(Me.txtmontodescuento.Text)


    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Private Sub Calculos_Articulo()

        Try
            PosActual = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position
            calculo_descuento_articulo()
            txtImpVenta.Text = Me.impuesto_cliente * CDbl(Me.txtImpVenta.Text) / 100

            If txtImpVenta.Text <> 0 Then 'si tiene impuesto de venta
                If (CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) > CDbl(txtPrecioUnit.Text) Then
                    txtFlete.Text = 0
                    txtOtros.Text = 0
                End If
                'Gravado = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
                Gravado = ((Math.Round(CDbl(txtPrecioUnit.Text), 2) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
                txtMontoImpuesto.Text = (Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(txtImpVenta.Text) / 100)
                txtSGravado.Text = Gravado
                Exento = 0

            Else 'si no tiene impuesto de venta
                'Exento = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
                Exento = ((Math.Round(CDbl(txtPrecioUnit.Text), 2) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
                Gravado = 0
                txtMontoImpuesto.Text = 0
                txtSGravado.Text = 0
                txtSExcento.Text = Exento
            End If

            Exento = Exento + ((CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text))
            txtSExcento.Text = Exento
            txtSubtotal.Text = CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text) '+ CDbl(Me.txtmontodescuento.Text)


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Function calculo_descuento_articulo()
        Try

            If CDbl(Me.txtDescuento.Text) > 0 Then 'si el articulo tiene un descuento

                '''''''''''''''''''''''''''''PROMO'''''''''''''''''''''' ACTIVA''''''''''''''''''''''''''''''''''''''''''
                If Me.promo_activa_valor Then 'si el articulo esta en promocion 
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo está en promoción" + vbCrLf
                    Exit Function
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'SI EL ARTICULO NO PERMITE DESCUENTO
                If CDbl(TxtMaxdescuento.Text) = 0 Then
                    'Si el articulo  no permite que se le realize un descuento
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo no permite descuento" + vbCrLf
                    Exit Function
                End If


                'SI EL USUARIO NO PUEDE DAR DESCUENTO

                If Me.porcentaje_descuento = 0 Then
                    MsgBox("Usted no puede realizar descuentos", MsgBoxStyle.Critical)
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    Exit Function
                End If


                ' validar si el descuento se puede aplicar o no el descuento

                ''''''''''''''''''''''''''''''''''''''''''''''''''''
                'max_aplicar = CDbl(Me.TxtMaxdescuento.Text) * Me.porcentaje_descuento / 100
                max_aplicar = TxtMaxdescuento.Text

                'SI EL DESCUENTO DESEADO ES TOTALMENTE APLICABLE AL ARTICULO
                If CDbl(Me.txtDescuento.Text) <= max_aplicar Then
                    'si el descuento que se desea aplicar, el usuario lo puede aplicar
                    'es aplicable al cliente
                    'se asigna el maximo porcentaje que el usuaio puede dar
                    If perdiendo() Then
                        Exit Function
                    End If

                    If Me.descuento = 0 Then ' si el cliente no tiene predefinido un descuento
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        Exit Function
                    End If

                    If Me.descuento <> 0 And Me.txtDescuento.Text <= descuento Then
                        'si el Cliente tiene un descuento predefinido, y lo que se desea aplicar es <= que lo permitido por el cliente
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        Exit Function
                    End If

                End If


                'SI NO LO PUEDE APLICAR EL USUARIO, PERO SI EL CLIENTE
                If CDbl(Me.txtDescuento.Text) > max_aplicar Then
                    'si el descuento que se desea aplicar
                    'es mayor que el que el usuario puede aplicar

                    If perdiendo() Then
                        Exit Function
                    End If

                    If descuento = 0 Then ' si el cliente no tiene predefinido un descuento
                        Me.txtDescuento.Text = max_aplicar
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Máximo permitido por el usuario" + vbCrLf
                        Exit Function
                    End If

                    If Me.descuento <> 0 And Me.txtDescuento.Text <= descuento Then
                        Me.txtDescuento.Text = descuento 'aplico el descuento del cliente
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txtCod_Articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Máximo permitido para el cliente" + vbCrLf
                        Exit Function
                    End If

                End If

            Else 'si el campo de descuento esta en cero
                DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try


    End Function






    'Private Sub txtDescuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuento.LostFocus

    '    If CInt(Me.txtDescuento.Text) > Me.porcentaje_descuento Then
    '        MsgBox("Usted Puede Aplicar solo hasta un " + Me.porcentaje_descuento.ToString + "% de descuento")
    '        Me.txtDescuento.Text = Me.porcentaje_descuento
    '    End If

    '    If CInt(Me.txtDescuento.Text) > Me.descuento Then
    '        MsgBox("A este Cliente se le puede asignar hasta un " + Me.descuento.ToString + "% de descuento")
    '        Me.txtDescuento.Text = Me.descuento
    '    End If

    '    Calculos_Articulo()
    '    Calcular_totales()

    'End Sub



#End Region



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim maximo_descuento As Double = Me.porcentaje_descuento

        Dim ajustar_descuento_general_objero As New Frm_AjustarDescuento(maximo_descuento, Me.descuento)
        ajustar_descuento_general_objero.ShowDialog()
        Dim nuevo_descuento As Double = ajustar_descuento_general_objero.nuevo_porc_descuento

        recalcular_cotizacion(nuevo_descuento)

    End Sub

    Private Sub recalcular_cotizacion(ByVal nuev_des)
        Dim i As Integer

        For i = 0 To BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count - 1
            BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i
            txtDescuento.Text = nuev_des
            Calculos_Articulo() ' se calcula de nuevo los datos del articulo cotizado
            BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
        Next
        Calcular_Totales_Cotizacion()
        MsgBox("Descuento Actualizado", MsgBoxStyle.OkOnly)
    End Sub


    Private Sub Calcular_totales()

        Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
        Calcular_Totales_Cotizacion()

        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").AddNew()
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").CancelCurrentEdit()
        Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count

        validar_descuento()

        Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
        Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = PosActual
    End Sub


    Private Sub Calcular_Totales_Cotizacion()  ' calcula el monto Total de la cotización
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("SubTotal") = Math.Round(Me.colSubTotal.SummaryItem.SummaryValue, 2)
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("SubTotalGravada") = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("SubTotalExento") = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Descuento") = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Imp_Venta") = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
        'Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Total") = Math.Round(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("SubTotal") - Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Descuento") + Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Imp_Venta") + +Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Transporte"), 2)

        txtSubtotalT.EditValue = Math.Round(Me.colSubTotal.SummaryItem.SummaryValue, 2)
        Lb_Subgravado.EditValue = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
        Lb_SubExento.EditValue = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
        txtDescuentoT.EditValue = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
        txtImpVentaT.EditValue = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
        txtTotal.EditValue = Math.Round(txtSubtotalT.EditValue - Me.txtDescuentoT.EditValue + Me.txtImpVentaT.EditValue + Me.Label_Transporte.EditValue, 2)

        txtSubtotalT.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
        txtSubtotal.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
        Lb_Subgravado.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
        Lb_SubExento.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
        txtDescuentoT.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
        txtImpVentaT.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
        txtTotal.Properties.DisplayFormat.FormatString = Me.Label31.Text & "#,#0.00"
    End Sub

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            Me.meter_al_detalle()
        End If

        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If
    End Sub

    Private Sub meter_al_detalle()
        Try

            If Me.Ck_Exonerar.Checked = True Then
                If CDec(Me.txtImpVenta.Text) > 0 Then
                    Dim frm As New frmExonerarLineaFactura
                    frm.Identificacion = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").Current("Cod_Cliente")
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.txtImpVenta.Text = frm.txtIV.Text
                    Else
                        Exit Sub
                    End If
                End If
            End If

            txtPrecioUnit.Enabled = PuedeCambiarPrecios

            Dim resp As Integer
            If txtCod_Articulo.Text = "" Then
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                txtCod_Articulo.Focus()
                MsgBox("El Codigo del Articulo no puede ser Nulo!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Sub
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo a la Cotización?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                txtCod_Articulo.Focus()
                Exit Sub
            End If

            'Sin limite.
            'If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 14 Then
            '    MsgBox("Ha alcanzado el límite de la Cotización", MsgBoxStyle.Information)
            '    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            '    Me.GridControl1.Enabled = True
            '    Exit Sub
            'End If


            If CDbl(Me.txtCantidad.Text) > Me.Existencia Then 'si la cantidad digitada es mayor que la existencia
                MsgBox("No Existen " + txtCantidad.Text + " artículos, la Existencia en el inventario es de " + Me.Existencia.ToString + " ,debe hacer un pedido", MsgBoxStyle.Exclamation)

            End If


            If CDbl(Me.txtCantidad.Text) = Me.Existencia Then 'si con esta venta el inventario la existencia sera 0
                MsgBox("Con esta Cotización, la existencia de este artículo será 0, se debe hacer un pedido", MsgBoxStyle.Information)
            End If

            Calculos_Articulo()
            Validar_Punitario()
            '======================================================
            'JCGA 03 DE AGOSTO 2007
            If txtPrecioUnit.Text <> "" Then
                txtPrecioUnit.Text = Math.Round(CDbl(txtPrecioUnit.Text), 2)
            End If
            '=======================================================


            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If

            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()

            Calcular_totales()

            BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
            txtCod_Articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


#Region "validacines"

    Private Sub txtDiasPlazo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        If Me.opCredito.Checked = True Then ' si la cotización es a crédito

            If Me.txtDiasPlazo.Text = "" Then

                Me.txtDiasPlazo.Text = plazo_credito
                ErrorProvider1.SetError(sender, "Debe ener un plazo")
                e.Cancel = True
            Else
                ErrorProvider1.SetError(sender, "")

            End If



            If Me.txtDiasPlazo.Text <> "" Then

                If CInt(Me.txtDiasPlazo.Text) > plazo_credito Then

                    Me.txtDiasPlazo.Text = plazo_credito
                    ErrorProvider1.SetError(sender, "Este Cliente solo cuenta con " + Me.plazo_credito.ToString + " días de plazo")
                    e.Cancel = True
                Else
                    ErrorProvider1.SetError(sender, "")

                End If
            End If

        End If
    End Sub


    Private Sub txtContacto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtDiasValidez.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If
    End Sub


    Private Sub txtDiasValidez_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiasValidez.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtDiasEntrega.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If

    End Sub


    Private Sub txtDescuento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescuento.Validating
        If Me.txtDescuento.Text = "" Then
            ErrorProvider1.SetError(sender, "El Campo no puede estar vacío")


        Else
            ErrorProvider1.SetError(sender, "")
        End If

    End Sub


    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
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


    Private Sub SoloNumericos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress, txtDescuento.KeyPress, txtPrecioUnit.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If

    End Sub

    'Private Sub txtPrecioUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioUnit.KeyPress
    '    If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
    '        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
    '            e.Handled = True  ' esto invalida la tecla pulsada
    '        End If

    '    End If

    'End Sub


    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        'If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
        '    '  If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
        '    If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
        '        e.Handled = True  ' esto invalida la tecla pulsada
        '    End If

        'End If
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If


    End Sub

    Private Sub txtDiasValidez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasValidez.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub txtDiasEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasEntrega.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

#End Region

    Private Sub txtDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescuento.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txtDescuento.Text = "" Then

                    Exit Sub

                Else

                    If (CDbl(Me.txtDescuento.Text) > 100) Then Me.txtDescuento.Text = 100

                End If

                Me.Calculos_Articulo()
                If mensaje <> "" Then
                    MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                    mensaje = ""
                End If

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
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
                Me.txtDiasEntrega.Enabled = False
                Me.txtDiasValidez.Enabled = False

                Me.txtUsuario.Focus()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try



        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If

    End Sub

    Private Sub validar_descuento()
        If CDbl(Me.txtSubtotal.Text) / CDbl(Me.txtCantidad.Text) < CDbl(Me.txtCostoBase.Text) And Me.perfil_administrador Then  ' si el precio es menor que el precio base pero si el usuario es el administrador

            MsgBox("Precio unitario de este artículo es menor que su precio base", MsgBoxStyle.Exclamation)
        End If

        If CDbl(Me.txtSubtotal.Text) / CDbl(Me.txtCantidad.Text) < CDbl(Me.txtCostoBase.Text) And Not Me.perfil_administrador Then ' si el precio es menor que el precio base pero si el usuario no es el administrador

            MsgBox("Precio unitario de este artículo es menor que su precio base, solo el administrador lo puede autorizar", MsgBoxStyle.Exclamation)
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").RemoveAt(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position)
        End If

    End Sub


    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Ariculo_Detalle()
        End If
    End Sub
    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este artículo de la cotización?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").RemoveAt(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position)
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
                    Calcular_Totales_Cotizacion()

                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()

                    BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                    BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()

                Else
                    BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                    BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
                End If
                txtCod_Articulo.Focus()
            Else
                MsgBox("No Existen Artìculos para eliminar de la cotización", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub


    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtContacto.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If
    End Sub



    Private Sub txtPrecioUnit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrecioUnit.Validating
        If Me.txtPrecioUnit.Text = "" Then
            ErrorProvider1.SetError(sender, "no puede estar vacío")


        Else
            ErrorProvider1.SetError(sender, "")

        End If

    End Sub

    Private Sub txtDiasPlazo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub


    Private Sub txtDiasValidez_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiasValidez.Validating
        If Me.txtDiasValidez.Text = "" Then
            ErrorProvider1.SetError(sender, "El Campo no puede estar vacío")
            e.Cancel = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtDiasEntrega_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiasEntrega.Validating
        If Me.txtDiasEntrega.Text = "" Then
            ErrorProvider1.SetError(sender, "El Campo no puede estar vacío")
            e.Cancel = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If

    End Sub


    Private Sub txtPrecioUnit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioUnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.txtPrecioUnit.Text = "" Then
                    Exit Sub
                End If

                Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
                Me.Calculos_Articulo()
                Validar_Punitario()

                '=============================================
                'JCGA 03 DE AGOSTO 2007
                If txtPrecioUnit.Text <> "" Then
                    txtPrecioUnit.Text = Math.Round(CDbl(txtPrecioUnit.Text), 2)
                End If
                '=============================================

                If mensaje <> "" Then
                    MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                    mensaje = ""
                End If

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
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
            Me.Registrar()
        End If

    End Sub

    Private Sub Validar_Punitario()
        Try
            Dim max_precio_unit As Double
            'Buscar_datos_articulo(Me.txtCodArticulo.Text)
            'ta ta ta tan!!!!!!!
            If Me.precio_unitario = 0 Then
                precio_unitario = Me.txtPrecioUnit.Text
            End If

            max_precio_unit = (Me.variacion_Punit / 100) * Me.precio_unitario ' se calcula la variacioon maxima que se puede hacer sobre ese articulo

            If CDbl(Me.txtPrecioUnit.Text) < Me.precio_unitario Then
                If perdiendo_PUnit() Then
                    Exit Sub
                End If

                If (Me.precio_unitario - CDbl(Me.txtPrecioUnit.Text)) > (max_precio_unit) Then ' si se bajo el precio mas de lo posible
                    MsgBox("Precio unitario inválido, solo puede variar el precio en un " + variacion_Punit.ToString + "% = " + Me.Label31.Text.ToString + " " + max_precio_unit.ToString, MsgBoxStyle.Exclamation)
                    txtPrecioUnit.Text = Math.Round(Me.precio_unitario, 2)
                    Exit Sub
                End If
            End If

            If CDbl(Me.txtPrecioUnit.Text) > Me.precio_unitario Then ' si se esta subiendo el precio unitario
                'If perdiendo_PUnit() Then
                '    Exit Function
                'End If

                If (CDbl(Me.txtPrecioUnit.Text - Me.precio_unitario)) > (max_precio_unit) Then ' si se subio el precio mas de lo posible
                    MsgBox("Precio unitario inválido, solo puede variar el precio en un " + variacion_Punit.ToString + "% = " + Me.Label31.Text.ToString + " " + max_precio_unit.ToString, MsgBoxStyle.Exclamation)
                    txtPrecioUnit.Text = Math.Round(Me.precio_unitario, 2)
                    Exit Sub
                End If
            End If

        Catch ex As SystemException
            txtPrecioUnit.Text = Me.precio_unitario
            'MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
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
                    mensaje = mensaje & "Cod: " & Me.txtCod_Articulo.Text & " Se Aplicó un: (" & Me.txtDescuento.Text & " %) Con esta venta se está perdiendo " & Me.Label31.Text & Me.monto_Perdido.ToString & vbCrLf
                Else
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje & "Cod: " & Me.txtCod_Articulo.Text & " Se Aplicó un: (" & Me.txtDescuento.Text & " %) Usted no puede vender perdiendo, con esta venta se estaria perdiendo " & Me.Label31.Text & Me.monto_Perdido.ToString & vbCrLf

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

                    mensaje = mensaje & "Cod: " & Me.txtCod_Articulo.Text & " Se disminuyó el P.unit. en " & Label31.Text & (CDbl(Me.precio_unitario - Me.txtPrecioUnit.Text)).ToString & " ,Con esta venta se está perdiendo " & Me.Label31.Text & Me.monto_Perdido.ToString & vbCrLf
                Else
                    mensaje = mensaje & "Cod: " & Me.txtCod_Articulo.Text & " Usted no puede vender perdiendo, la disminución del P.unit. en " & Label31.Text & (CDbl(Me.precio_unitario - Me.txtPrecioUnit.Text)) & " provocaria una perdida de " & Me.Label31.Text & Me.monto_Perdido.ToString & vbCrLf
                End If
                Return True

            Else
                Return False

            End If


        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Function


    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim trans As Double
        Dim mont_trans As New Monto_Transporte_Ventas
        Try

            mont_trans.ShowDialog()
            trans = mont_trans.Monto

            Label_Transporte.Text = trans

            Me.Calcular_Totales_Cotizacion()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            If Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count = 0 Then
                MsgBox("No se puede aplicar descuento, aún no hay artículos", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim maximo_descuento As Double = Me.porcentaje_descuento
            Dim ajustar_descuento_general_objero As New Ajuste_Descuento_Factura(maximo_descuento, Me.descuento)
            ajustar_descuento_general_objero.ShowDialog()
            Dim nuevo_descuento As Double = ajustar_descuento_general_objero.nuevo_porc_descuento

            If nuevo_descuento < 0 Then Exit Sub ' si se digito 0 en el descuento 

            GridControl1.Enabled = True
            GridControl1.Focus()

            recalcular_cotizacion(nuevo_descuento)
            Calcular_totales()

            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If

            BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
            BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").AddNew()
            txtCod_Articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub opCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opCredito.CheckedChanged
        dias_credito()
    End Sub
    Private Sub dias_credito()
        Try
            If Me.opContado.Checked = False Then
                txtDiasPlazo.Enabled = True
                txtDiasPlazo.Text = Me.plazo_credito
                Label7.Visible = True
                Me.txtDiasPlazo.Visible = True
            Else
                txtDiasPlazo.Text = 0
                txtDiasPlazo.Enabled = False
                Me.txtDiasPlazo.Visible = False
                Me.Label7.Visible = False
            End If

            txtCod_Articulo.Focus()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub



    Private Sub txtCostoBase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostoBase.TextChanged
        Label_Costobase.Text = Me.txtCostoBase.Text
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.ComboBox1.Enabled = True
        Me.ComboBox1.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        If Me.opContado.Checked = True Then
            Me.Iniciar_Cotizacion()
        End If
    End Sub

    Private Sub txtPrecioUnit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioUnit.Leave
        Try
            If Me.txtPrecioUnit.Text = "" Then  'si el campo está vacío
                txtPrecioUnit.Text = Me.precio_unitario
                Exit Sub
            End If


            If Not IsDBNull(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")) Then
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            End If


        Catch ex As SystemException
            txtPrecioUnit.Text = Me.precio_unitario
        End Try
    End Sub


    Private Sub txtDescuento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuento.Leave
        Try
            If Me.txtDescuento.Text = "" Then
                MsgBox("No puede estar vacío", MsgBoxStyle.Exclamation)
                Me.txtDescuento.Text = "0"
                Exit Sub

            Else

                If (CDbl(Me.txtDescuento.Text) > 100) Then Me.txtDescuento.Text = 100

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
                End If

            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        Try
            If Not IsDBNull(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")) Then
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub TxtprecioCosto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtprecioCosto.TextChanged
        Try
            Label_Costobase.Text = Me.TxtprecioCosto.Text

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtCodArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodArticulo.GotFocus, txtCod_Articulo.GotFocus
        txtCod_Articulo.SelectAll()
    End Sub

    Private Function Utilidad(ByVal Costo As Double, ByVal Precio As Double) As Double
        Utilidad = ((Precio / Costo) - 1) * 100
        Return Utilidad
    End Function
    Private Sub TxtUtilidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUtilidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.TxtUtilidad.Text = "" Then Exit Sub
                Me.txtPrecioUnit.Text = CDbl(Me.txtCostoBase.Text) * (Me.TxtUtilidad.Text / 100) + Me.txtFlete.Text + Me.txtOtros.Text + CDbl(txtCostoBase.Text)

                Me.Calculos_Articulo()
                Validar_Punitario()
                '==============================================
                'JCGA 03 DE AGOSTO 2007
                If txtPrecioUnit.Text <> "" Then
                    txtPrecioUnit.Text = Math.Round(CDbl(txtPrecioUnit.Text), 2)
                End If
                '==============================================

                If mensaje <> "" Then
                    MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                    mensaje = ""
                End If

                If Not IsDBNull(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descripcion")) Then
                    Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
                    Calcular_totales()
                End If
                Me.txtPrecioUnit.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        End If
    End Sub

    Private Sub TxtUtilidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUtilidad.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtCodArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArticulo.TextChanged, txtCod_Articulo.TextChanged
        AgregandoNuevoItem = False
    End Sub

    Private Sub txtCodArticulo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodArticulo.LostFocus, txtCod_Articulo.LostFocus
        If AgregandoNuevoItem = False Then
            If Me.DataSet_Cotizaciones21.Cotizacion_Detalle.Rows.Count > 0 Then
                txtCodArticulo.Text = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")
                txtCod_Articulo.Text = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("CodArticulo")
            End If
        Else

        End If
    End Sub

    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus
        BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").CancelCurrentEdit()
    End Sub

    Private Sub txtExistencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExistencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub Ck_Exonerar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ck_Exonerar.CheckedChanged
        'If BindingContext(DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count > 0 Then
        '    If buscando = False Then
        '        recalcular_cotizacion_cambio_cliente()
        '        txtCod_Articulo.Focus()
        '    End If
        'End If
    End Sub

    Private Sub txtCantidad_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.EditValueChanged

    End Sub

    Private Sub ck_confirmada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_confirmada.CheckedChanged
        Try
            If Me.ck_confirmada.Checked = True Then
                BindingContext(DataSet_Cotizaciones21, "Cotizacion").Current("confirmada") = True
                BindingContext(DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
                Me.txtconfirmadapor.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Function GetCedula(_Codigo As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select cedula from clientes where identificacion = " & _Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("cedula")
        Else
            Return ""
        End If
    End Function

    Private Sub btnMAG_Click(sender As Object, e As EventArgs) Handles btnMAG.Click
        Dim frm As New frmValidarRegistroMAG
        frm.Identificacion = Me.txt_cedula.Text
        If frm.Identificacion <> "" Then
            frm.ShowDialog()
            Me.ClienteRegistradoMAG = frm.ckVenta1.Checked
            'If frm.ckMAG.Checked = True Or frm.ckVenta1.Checked = True Then
            '    Dim Identificador As String = Me.txtCodigo.Text
            '    If Identificador <> "0" Then
            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        db.Ejecutar("Update Clientes set MAG = 1 where Identificacion = " & Identificador, CommandType.Text)
            '        Me.EstaRegistrado(Identificador)
            '    End If
            'End If
        End If

    End Sub

    Private Sub txt_cedula_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cedula.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim cFunciones As New cFunciones
                Dim c As String

                c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

                If c <> "" Then
                    Me.txtCodigo.Text = c
                Else
                    Exit Sub
                End If

                Me.btnMAG.BackColor = Drawing.SystemColors.Control
                If Me.txtCodigo.Text <> "" And Me.txtCodigo.Text <> "0" Then
                    'sqlConexion = CConexion.Conectar
                    CargarInformacionCliente(txtCodigo.Text)
                Else
                    Exit Sub
                End If
            End If


            If e.KeyCode = Keys.Enter Then ' si se digito enter
                Me.btnMAG.BackColor = Drawing.SystemColors.Control
                Me.txtNombre.Text = ""
                Me.txtNombre.Enabled = True
                impuesto_cliente = 100

                If Me.txt_cedula.Text <> "" And Me.txt_cedula.Text <> "0" Then
                    CargarInformacionCliente(Me.txt_cedula.Text)
                    'txtCod_Articulo.Focus()
                Else
                    Me.txtNombre.Text = "CLIENTE CONTADO"
                    Me.txtCodigo.Text = "0"
                    Me.opCredito.Checked = False
                    Me.opContado.Checked = True
                    Me.opCredito.Enabled = False
                    Me.impuesto_cliente = 100
                    Exit Sub
                End If
            End If

            If e.KeyCode = Keys.F2 Then
                Me.Registrar()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GetPrecio_Costo(_Cod As String, Optional ByVal _Real As Boolean = False) As Decimal
        'zoe
        Dim dt As New DataTable
        Dim strSQL As String = "select costo, dbo.precio_final(codigo) as costoreal from Inventario where codigo = " & _Cod
        Dim Resultado As Decimal = 0
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If _Real = True Then
                Resultado = dt.Rows(0).Item("costoreal")
                If Resultado = 0 Then Resultado = dt.Rows(0).Item("costo")
                Return Resultado
            Else
                Resultado = dt.Rows(0).Item("costo")
                Return Resultado
            End If

        End If
        Return 0
    End Function

    Private Function GetUtilidadProducto(_CostoReal As Boolean)
        Dim Codigo As String = "0"
        Dim CostoProducto As Decimal = 0
        Dim PrecioUnit As Decimal = 0
        Dim Descuento As Decimal = 0
        Dim MontoDescuento As Decimal = 0
        Dim Utilidad As Decimal = 0
        Dim SumaPrecioUnit, SumaCostoProducto, UtilidadGeneral As Decimal
        'Me.DataSet_Cotizaciones21.Cotizacion_Detalle(0).Utilidad
        For i As Integer = 0 To Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Count()
            Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Position = i
            If IsNumeric(Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")) Then
                Codigo = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Codigo")
                PrecioUnit = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Precio_Unit")
                Descuento = Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Descuento")
                MontoDescuento = PrecioUnit * (Descuento / 100)
                PrecioUnit = PrecioUnit - MontoDescuento
                CostoProducto = Me.GetPrecio_Costo(Codigo, _CostoReal)
                SumaCostoProducto += CostoProducto
                SumaPrecioUnit += PrecioUnit
                '//Calculo de Utilidad
                Utilidad = ((PrecioUnit / CostoProducto) - 1) * 100
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").Current("Utilidad") = Utilidad
                Me.BindingContext(Me.DataSet_Cotizaciones21, "Cotizacion.CotizacionCotizacion_Detalle").EndCurrentEdit()
            End If
        Next
        If SumaCostoProducto > 0 And SumaPrecioUnit > 0 Then
            UtilidadGeneral = ((SumaPrecioUnit / SumaCostoProducto) - 1) * 100
            Me.lblUtilidadGeneral.Text = UtilidadGeneral.ToString("N2")
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmEligeCosto
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblUtilidadGeneral.Text = ""
            Dim CostoReal As Boolean = False
            Select Case frm.CualEligio
                Case CostoEligio.Costo : CostoReal = False
                Case CostoEligio.CostoReal : CostoReal = True
            End Select
            Me.GetUtilidadProducto(CostoReal)
            Me.colUtilidad.Visible = True
            Me.txtCod_Articulo.Focus()
        End If
    End Sub

End Class


Public Class Correo

    Public Sub EnviarCotizacion(_id As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select cc.Nombre_Cliente as Cliente , ISNULL(c.e_mail,'') as Correo from Cotizacion cc left join Clientes c on c.identificacion = cc.Cod_Cliente where cc.Cotizacion = " & _id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

            Dim Carpeta As String = "C:\temporales\Cotizacion"
            Dim Archivo As String = Carpeta & "\" & _id & ".pdf"
            Dim rpt As New Reporte_Cotizacion
            rpt.SetParameterValue(0, CDbl(_id))
            rpt.SetParameterValue(1, False)
            CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)

            If IO.Directory.Exists(Carpeta) = False Then
                IO.Directory.CreateDirectory(Carpeta)
            End If

            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo)

            If IO.File.Exists(Archivo) Then
                Me.Enviar(dt.Rows(0).Item("Cliente") & " " & "Cotizacion  #" & _id, "Cotizacion", dt.Rows(0).Item("Correo"), Archivo, _id & ".pdf")
            Else
                Me.Enviar(dt.Rows(0).Item("Cliente") & " " & "Cotizacion  #" & _id, "Cotizacion", dt.Rows(0).Item("Correo"), Archivo, _id & ".pdf")
            End If
        End If
    End Sub

    Public Sub EnviarEstadoCxC(_Identificacion As String, _Nombre As String, _Correo As String, _Subject As String, _Body As String)
        Dim Carpeta As String = "C:\temporales\CxC"
        Dim Archivo As String = Carpeta & "\" & _Nombre & ".pdf"

        If IO.File.Exists(Archivo) Then
            IO.File.Delete(Archivo)
        End If

        If IO.Directory.Exists(Carpeta) = False Then
            IO.Directory.CreateDirectory(Carpeta)
        End If

        Dim Reporte As New Estado_Actual_FechaCorte
        Reporte.SetParameterValue(0, 1)      ' TIPO DE CAMBIO $ - c
        Reporte.SetParameterValue(1, CStr("FACTURAS Por Cliente - Colones"))
        Reporte.SetParameterValue(2, 0)    'TIPO D EREPORTE
        Reporte.SetParameterValue(3, Date.Now)  'DateAdd(DateInterval.Day, 1, Me.DateTimePicker1.Value))
        Reporte.SetParameterValue(4, _Identificacion)
        CrystalReportsConexion.LoadReportViewer(Nothing, Reporte, True)

        Reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo)
        Me.Enviar(_Subject, _Body, _Correo, Archivo, _Nombre & ".pdf")
    End Sub

    Private Sub Enviar(_Subject As String, _Body As String, _To As String, _Filename As String, _Displayname As String)
        If _Body = "" Then _Body = "  "
        Try
            Dim oApp As Interop.Outlook._Application
            oApp = New Interop.Outlook.Application

            Dim oMsg As Interop.Outlook._MailItem
            oMsg = oApp.CreateItem(Interop.Outlook.OlItemType.olMailItem)

            oMsg.Subject = _Subject
            oMsg.Body = _Body
            oMsg.To = _To

            Dim strS As String = _Filename
            Dim strN As String = _Displayname

            Dim sBodyLen As Integer = Int(_Body.Length)
            Dim oAttachs As Interop.Outlook.Attachments = oMsg.Attachments
            Dim oAttach As Interop.Outlook.Attachment
            oAttach = oAttachs.Add(strS, , sBodyLen, strN)
            oMsg.Display()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

   

End Class