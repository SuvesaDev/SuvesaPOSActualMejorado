Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class frmMovimientoCajaPagoAbono
    Inherits System.Windows.Forms.Form
    Public Trans As SqlTransaction
    Public Total As Double
    Public Factura As Double
    Public fecha As DateTime
    Public Tipo As String
    Public codmod As Integer
    Public NApertura As Long
    Public cargando As Boolean
    Public Conversion As Double 'almacena el valor de conversion entre la moneda de la factura y la modeda en que se va a hacer el pago
    Public TipoCambio_Factura As Double
    Public mon As DataRow()
    Public mode As DataRow
    Public Tipo_CambioOpciones As Double
    Public Seleccionado As Integer
    Public Registra As Boolean = False
    Public bandera As Boolean = False
    Public vuelto As Double
    Dim cedu As String
    Dim nombre As String
    Friend WithEvents rbSinpe As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrepago As System.Windows.Forms.RadioButton
    Friend WithEvents lblSaldoPrepago As System.Windows.Forms.Label
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Dim usua

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub


    'Public Sub New(ByVal NFACT As Double, ByVal monto As Double, ByVal fecha As DateTime, ByVal Usuario_Parametro As Object)
    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        usua = Usuario_Parametro
        'Add any initialization after the InitializeComponent() call
        AddHandler Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").PositionChanged, AddressOf Me.Position_Changed
    End Sub



    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtauxcoin As System.Windows.Forms.TextBox
    Friend WithEvents txtauxtipocambio As System.Windows.Forms.TextBox
    Friend WithEvents txtformapago As System.Windows.Forms.TextBox
    Friend WithEvents txttipofact As System.Windows.Forms.TextBox
    Friend WithEvents txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblvuelto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblmontopagado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblmontofact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gbmoneda As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtranferencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbcheque As System.Windows.Forms.RadioButton
    Friend WithEvents rbtarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents rbefectivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Public WithEvents dadetalleopcionpago As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents damoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtreftipo As System.Windows.Forms.TextBox
    Public WithEvents daopcionpago As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtauxformapago As System.Windows.Forms.TextBox
    Friend WithEvents txtauxtipodocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcoin As System.Windows.Forms.TextBox
    Friend WithEvents txttc As System.Windows.Forms.TextBox
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgdetopcpago As DevExpress.XtraGrid.GridControl

    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtnommoneda As System.Windows.Forms.TextBox
    Friend WithEvents colDenominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoCambio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombremoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNumApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Public WithEvents DataSet_Opciones_Pago1 As DataSet_Opciones_Pago
    Friend WithEvents Adapter_apertura As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colDocumento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoPago1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPago1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDenominacion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombremoneda1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPago2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferenciaTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferenciaDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents label_Tipo_Cambio As System.Windows.Forms.Label
    Friend WithEvents TxtDocu As System.Windows.Forms.TextBox
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtdenominacion As System.Windows.Forms.TextBox
    Friend WithEvents Monto_Su_Moneda As System.Windows.Forms.Label
    Friend WithEvents Pagado_Su_Moneda As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TxtMontoPagar_Sumoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TxtReferenciaTipo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocumentoF As System.Windows.Forms.TextBox
    Friend WithEvents TxtReferenciaF As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_Detalle_Pago As System.Windows.Forms.GroupBox
    Friend WithEvents Label_RefTipo As System.Windows.Forms.Label
    Friend WithEvents Label_Referencia As System.Windows.Forms.Label
    Friend WithEvents Label_Documento As System.Windows.Forms.Label
    Friend WithEvents Label_RefDocumento As System.Windows.Forms.Label
    Friend WithEvents Combo_Bancos As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_Tarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoCajaPagoAbono))
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
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo13 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo14 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo15 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo16 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo17 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.txtauxcoin = New System.Windows.Forms.TextBox()
        Me.DataSet_Opciones_Pago1 = New LcPymes_5._2.DataSet_Opciones_Pago()
        Me.txtauxtipocambio = New System.Windows.Forms.TextBox()
        Me.txtformapago = New System.Windows.Forms.TextBox()
        Me.txttipofact = New System.Windows.Forms.TextBox()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.txttotal = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblvuelto = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmontopagado = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblmontofact = New DevExpress.XtraEditors.TextEdit()
        Me.gbmoneda = New System.Windows.Forms.GroupBox()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.rbPrepago = New System.Windows.Forms.RadioButton()
        Me.rbSinpe = New System.Windows.Forms.RadioButton()
        Me.rbtranferencia = New System.Windows.Forms.RadioButton()
        Me.rbcheque = New System.Windows.Forms.RadioButton()
        Me.rbtarjeta = New System.Windows.Forms.RadioButton()
        Me.rbefectivo = New System.Windows.Forms.RadioButton()
        Me.Combo_Tarjeta = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Detalle_Pago = New System.Windows.Forms.GroupBox()
        Me.TxtVoucher = New System.Windows.Forms.TextBox()
        Me.Label_RefTipo = New System.Windows.Forms.Label()
        Me.Label_Referencia = New System.Windows.Forms.Label()
        Me.TxtReferenciaTipo = New System.Windows.Forms.TextBox()
        Me.Combo_Bancos = New System.Windows.Forms.ComboBox()
        Me.TxtDocumentoF = New System.Windows.Forms.TextBox()
        Me.TxtReferenciaF = New System.Windows.Forms.TextBox()
        Me.Label_Documento = New System.Windows.Forms.Label()
        Me.Label_RefDocumento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.dadetalleopcionpago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.damoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.txtreftipo = New System.Windows.Forms.TextBox()
        Me.daopcionpago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.TxtDocu = New System.Windows.Forms.TextBox()
        Me.txtdenominacion = New System.Windows.Forms.TextBox()
        Me.txtauxformapago = New System.Windows.Forms.TextBox()
        Me.txtauxtipodocumento = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtcodcoin = New System.Windows.Forms.TextBox()
        Me.txttc = New System.Windows.Forms.TextBox()
        Me.dgdetopcpago = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFormaPago2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumento2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferenciaTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferenciaDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnommoneda = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtNumApertura = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.colDenominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoCambio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombremoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormaPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDocumento1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoPago1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormaPago1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDenominacion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombremoneda1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Adapter_apertura = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.label_Tipo_Cambio = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Monto_Su_Moneda = New System.Windows.Forms.Label()
        Me.Pagado_Su_Moneda = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TxtMontoPagar_Sumoneda = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaldoPrepago = New System.Windows.Forms.Label()
        CType(Me.DataSet_Opciones_Pago1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblvuelto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblmontopagado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblmontofact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmoneda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_Detalle_Pago.SuspendLayout()
        CType(Me.dgdetopcpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtauxcoin
        '
        Me.txtauxcoin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.Moneda", True))
        Me.txtauxcoin.Location = New System.Drawing.Point(230, 74)
        Me.txtauxcoin.Name = "txtauxcoin"
        Me.txtauxcoin.Size = New System.Drawing.Size(68, 23)
        Me.txtauxcoin.TabIndex = 66
        Me.txtauxcoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataSet_Opciones_Pago1
        '
        Me.DataSet_Opciones_Pago1.DataSetName = "DataSet_Opciones_Pago"
        Me.DataSet_Opciones_Pago1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_Opciones_Pago1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtauxtipocambio
        '
        Me.txtauxtipocambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.TipoCambio", True))
        Me.txtauxtipocambio.Location = New System.Drawing.Point(317, 74)
        Me.txtauxtipocambio.Name = "txtauxtipocambio"
        Me.txtauxtipocambio.Size = New System.Drawing.Size(86, 23)
        Me.txtauxtipocambio.TabIndex = 67
        Me.txtauxtipocambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtformapago
        '
        Me.txtformapago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.FormaPago", True))
        Me.txtformapago.Location = New System.Drawing.Point(19, 74)
        Me.txtformapago.Name = "txtformapago"
        Me.txtformapago.Size = New System.Drawing.Size(154, 23)
        Me.txtformapago.TabIndex = 65
        '
        'txttipofact
        '
        Me.txttipofact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttipofact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.TipoFactura", True))
        Me.txttipofact.ForeColor = System.Drawing.Color.Blue
        Me.txttipofact.Location = New System.Drawing.Point(106, 37)
        Me.txttipofact.Name = "txttipofact"
        Me.txttipofact.Size = New System.Drawing.Size(96, 16)
        Me.txttipofact.TabIndex = 57
        Me.txttipofact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtfactura
        '
        Me.txtfactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.NumeroFactura", True))
        Me.txtfactura.ForeColor = System.Drawing.Color.Blue
        Me.txtfactura.Location = New System.Drawing.Point(19, 37)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(67, 16)
        Me.txtfactura.TabIndex = 55
        Me.txtfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal
        '
        Me.txttotal.EditValue = ""
        Me.txttotal.Location = New System.Drawing.Point(154, 123)
        Me.txttotal.Name = "txttotal"
        '
        '
        '
        Me.txttotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txttotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttotal.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txttotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttotal.Properties.Enabled = False
        Me.txttotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txttotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttotal.Size = New System.Drawing.Size(259, 48)
        Me.txttotal.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(106, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Tipo Factura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(19, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Factura"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(593, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 18)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Vuelto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblvuelto
        '
        Me.lblvuelto.EditValue = "0"
        Me.lblvuelto.Location = New System.Drawing.Point(593, 310)
        Me.lblvuelto.Name = "lblvuelto"
        '
        '
        '
        Me.lblvuelto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblvuelto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.lblvuelto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblvuelto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.lblvuelto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblvuelto.Properties.ReadOnly = True
        Me.lblvuelto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.Blue)
        Me.lblvuelto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblvuelto.Size = New System.Drawing.Size(230, 41)
        Me.lblvuelto.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(306, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 19)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Monto Pagado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblmontopagado
        '
        Me.lblmontopagado.EditValue = "0"
        Me.lblmontopagado.Location = New System.Drawing.Point(306, 312)
        Me.lblmontopagado.Name = "lblmontopagado"
        '
        '
        '
        Me.lblmontopagado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblmontopagado.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.lblmontopagado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblmontopagado.Properties.EditFormat.FormatString = "#,#0.00"
        Me.lblmontopagado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblmontopagado.Properties.ReadOnly = True
        Me.lblmontopagado.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.Blue)
        Me.lblmontopagado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblmontopagado.Size = New System.Drawing.Size(230, 41)
        Me.lblmontopagado.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label10.Location = New System.Drawing.Point(7, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(231, 19)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Monto Total Factura"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblmontofact
        '
        Me.lblmontofact.EditValue = "0"
        Me.lblmontofact.Location = New System.Drawing.Point(7, 312)
        Me.lblmontofact.Name = "lblmontofact"
        '
        '
        '
        Me.lblmontofact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblmontofact.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.lblmontofact.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblmontofact.Properties.EditFormat.FormatString = "#,#0.00"
        Me.lblmontofact.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblmontofact.Properties.ReadOnly = True
        Me.lblmontofact.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.Blue)
        Me.lblmontofact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblmontofact.Size = New System.Drawing.Size(231, 41)
        Me.lblmontofact.TabIndex = 80
        '
        'gbmoneda
        '
        Me.gbmoneda.Controls.Add(Me.cbomoneda)
        Me.gbmoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbmoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbmoneda.Location = New System.Drawing.Point(148, 38)
        Me.gbmoneda.Name = "gbmoneda"
        Me.gbmoneda.Size = New System.Drawing.Size(163, 55)
        Me.gbmoneda.TabIndex = 63
        Me.gbmoneda.TabStop = False
        Me.gbmoneda.Text = "Moneda"
        '
        'cbomoneda
        '
        Me.cbomoneda.DataSource = Me.DataSet_Opciones_Pago1
        Me.cbomoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Location = New System.Drawing.Point(10, 18)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(144, 25)
        Me.cbomoneda.TabIndex = 0
        Me.cbomoneda.ValueMember = "Moneda.CodMoneda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefrescar)
        Me.GroupBox1.Controls.Add(Me.rbPrepago)
        Me.GroupBox1.Controls.Add(Me.rbSinpe)
        Me.GroupBox1.Controls.Add(Me.rbtranferencia)
        Me.GroupBox1.Controls.Add(Me.rbcheque)
        Me.GroupBox1.Controls.Add(Me.rbtarjeta)
        Me.GroupBox1.Controls.Add(Me.rbefectivo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(10, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 193)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma Pago"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Image = Global.LcPymes_5._2.My.Resources.Resources.arrow_refresh1
        Me.btnRefrescar.Location = New System.Drawing.Point(96, 159)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(30, 24)
        Me.btnRefrescar.TabIndex = 169
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'rbPrepago
        '
        Me.rbPrepago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbPrepago.Location = New System.Drawing.Point(10, 158)
        Me.rbPrepago.Name = "rbPrepago"
        Me.rbPrepago.Size = New System.Drawing.Size(115, 28)
        Me.rbPrepago.TabIndex = 56
        Me.rbPrepago.Text = "Anticipo"
        '
        'rbSinpe
        '
        Me.rbSinpe.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbSinpe.Location = New System.Drawing.Point(10, 130)
        Me.rbSinpe.Name = "rbSinpe"
        Me.rbSinpe.Size = New System.Drawing.Size(115, 28)
        Me.rbSinpe.TabIndex = 55
        Me.rbSinpe.Text = "SINPE"
        '
        'rbtranferencia
        '
        Me.rbtranferencia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbtranferencia.Location = New System.Drawing.Point(10, 102)
        Me.rbtranferencia.Name = "rbtranferencia"
        Me.rbtranferencia.Size = New System.Drawing.Size(115, 27)
        Me.rbtranferencia.TabIndex = 54
        Me.rbtranferencia.Text = "Transferencia"
        '
        'rbcheque
        '
        Me.rbcheque.AccessibleName = ""
        Me.rbcheque.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbcheque.Location = New System.Drawing.Point(10, 74)
        Me.rbcheque.Name = "rbcheque"
        Me.rbcheque.Size = New System.Drawing.Size(96, 28)
        Me.rbcheque.TabIndex = 53
        Me.rbcheque.Text = "Cheque"
        '
        'rbtarjeta
        '
        Me.rbtarjeta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbtarjeta.Location = New System.Drawing.Point(10, 46)
        Me.rbtarjeta.Name = "rbtarjeta"
        Me.rbtarjeta.Size = New System.Drawing.Size(96, 28)
        Me.rbtarjeta.TabIndex = 52
        Me.rbtarjeta.Text = "Tarjeta"
        '
        'rbefectivo
        '
        Me.rbefectivo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbefectivo.Location = New System.Drawing.Point(10, 20)
        Me.rbefectivo.Name = "rbefectivo"
        Me.rbefectivo.Size = New System.Drawing.Size(96, 27)
        Me.rbefectivo.TabIndex = 51
        Me.rbefectivo.Text = "Efectivo"
        '
        'Combo_Tarjeta
        '
        Me.Combo_Tarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Tarjeta.ForeColor = System.Drawing.Color.Blue
        Me.Combo_Tarjeta.Location = New System.Drawing.Point(134, 83)
        Me.Combo_Tarjeta.Name = "Combo_Tarjeta"
        Me.Combo_Tarjeta.Size = New System.Drawing.Size(221, 25)
        Me.Combo_Tarjeta.TabIndex = 3
        Me.Combo_Tarjeta.Visible = False
        '
        'GroupBox_Detalle_Pago
        '
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.TxtVoucher)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.Combo_Tarjeta)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.Label_RefTipo)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.Label_Referencia)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.TxtReferenciaTipo)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.Combo_Bancos)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.TxtDocumentoF)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.TxtReferenciaF)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.Label_Documento)
        Me.GroupBox_Detalle_Pago.Controls.Add(Me.Label_RefDocumento)
        Me.GroupBox_Detalle_Pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Detalle_Pago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox_Detalle_Pago.Location = New System.Drawing.Point(10, 253)
        Me.GroupBox_Detalle_Pago.Name = "GroupBox_Detalle_Pago"
        Me.GroupBox_Detalle_Pago.Size = New System.Drawing.Size(364, 87)
        Me.GroupBox_Detalle_Pago.TabIndex = 0
        Me.GroupBox_Detalle_Pago.TabStop = False
        Me.GroupBox_Detalle_Pago.Text = "Detalle Forma Pago"
        Me.GroupBox_Detalle_Pago.Visible = False
        '
        'TxtVoucher
        '
        Me.TxtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.Referencia", True))
        Me.TxtVoucher.ForeColor = System.Drawing.Color.Blue
        Me.TxtVoucher.Location = New System.Drawing.Point(134, 111)
        Me.TxtVoucher.Name = "TxtVoucher"
        Me.TxtVoucher.Size = New System.Drawing.Size(221, 23)
        Me.TxtVoucher.TabIndex = 149
        Me.TxtVoucher.Text = "00000"
        Me.TxtVoucher.Visible = False
        '
        'Label_RefTipo
        '
        Me.Label_RefTipo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label_RefTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RefTipo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_RefTipo.Location = New System.Drawing.Point(14, 83)
        Me.Label_RefTipo.Name = "Label_RefTipo"
        Me.Label_RefTipo.Size = New System.Drawing.Size(116, 19)
        Me.Label_RefTipo.TabIndex = 127
        Me.Label_RefTipo.Text = "Referencia Tipo"
        Me.Label_RefTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Referencia
        '
        Me.Label_Referencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label_Referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Referencia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_Referencia.Location = New System.Drawing.Point(24, 28)
        Me.Label_Referencia.Name = "Label_Referencia"
        Me.Label_Referencia.Size = New System.Drawing.Size(106, 18)
        Me.Label_Referencia.TabIndex = 128
        Me.Label_Referencia.Text = "Referencia"
        Me.Label_Referencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtReferenciaTipo
        '
        Me.TxtReferenciaTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtReferenciaTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.ReferenciaTipo", True))
        Me.TxtReferenciaTipo.ForeColor = System.Drawing.Color.Blue
        Me.TxtReferenciaTipo.Location = New System.Drawing.Point(134, 83)
        Me.TxtReferenciaTipo.Name = "TxtReferenciaTipo"
        Me.TxtReferenciaTipo.Size = New System.Drawing.Size(221, 23)
        Me.TxtReferenciaTipo.TabIndex = 2
        '
        'Combo_Bancos
        '
        Me.Combo_Bancos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.ReferenciaDoc", True))
        Me.Combo_Bancos.ForeColor = System.Drawing.Color.Blue
        Me.Combo_Bancos.Items.AddRange(New Object() {"Banco Bac San Jose", "Banco Banex", "Banco Cathay", "Banco Crédito Agricola de Cartago", "Banco Cuscatlan", "Banco de Costa Rica", "Banco Improsa", "Banco Interfin", "Banco Nacional de Costa Rica", "Banco Popular", "Banco ProAmerica", "Banco ScotianBank", "Banco UNO"})
        Me.Combo_Bancos.Location = New System.Drawing.Point(134, 111)
        Me.Combo_Bancos.Name = "Combo_Bancos"
        Me.Combo_Bancos.Size = New System.Drawing.Size(221, 25)
        Me.Combo_Bancos.TabIndex = 3
        '
        'TxtDocumentoF
        '
        Me.TxtDocumentoF.AcceptsTab = True
        Me.TxtDocumentoF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDocumentoF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.Documento", True))
        Me.TxtDocumentoF.ForeColor = System.Drawing.Color.Blue
        Me.TxtDocumentoF.Location = New System.Drawing.Point(134, 55)
        Me.TxtDocumentoF.Name = "TxtDocumentoF"
        Me.TxtDocumentoF.Size = New System.Drawing.Size(221, 23)
        Me.TxtDocumentoF.TabIndex = 1
        Me.TxtDocumentoF.Text = "00000"
        '
        'TxtReferenciaF
        '
        Me.TxtReferenciaF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtReferenciaF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.Referencia", True))
        Me.TxtReferenciaF.ForeColor = System.Drawing.Color.Blue
        Me.TxtReferenciaF.Location = New System.Drawing.Point(134, 28)
        Me.TxtReferenciaF.Name = "TxtReferenciaF"
        Me.TxtReferenciaF.Size = New System.Drawing.Size(221, 23)
        Me.TxtReferenciaF.TabIndex = 0
        Me.TxtReferenciaF.Text = "00000"
        '
        'Label_Documento
        '
        Me.Label_Documento.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label_Documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Documento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_Documento.Location = New System.Drawing.Point(24, 55)
        Me.Label_Documento.Name = "Label_Documento"
        Me.Label_Documento.Size = New System.Drawing.Size(106, 19)
        Me.Label_Documento.TabIndex = 130
        Me.Label_Documento.Text = "Documento"
        Me.Label_Documento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_RefDocumento
        '
        Me.Label_RefDocumento.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label_RefDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RefDocumento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_RefDocumento.Location = New System.Drawing.Point(13, 114)
        Me.Label_RefDocumento.Name = "Label_RefDocumento"
        Me.Label_RefDocumento.Size = New System.Drawing.Size(115, 19)
        Me.Label_RefDocumento.TabIndex = 129
        Me.Label_RefDocumento.Text = "Referencia Doc"
        Me.Label_RefDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(718, 37)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Movimiento de Pago"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumeroFactura", System.Data.SqlDbType.Float, 8, "NumeroFactura"), New System.Data.SqlClient.SqlParameter("@TipoFactura", System.Data.SqlDbType.VarChar, 3, "TipoFactura"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Referencia", System.Data.SqlDbType.VarChar, 50, "Referencia"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, "ReferenciaTipo"), New System.Data.SqlClient.SqlParameter("@ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, "ReferenciaDoc"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Referencia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Referencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaTipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoFactura", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoFactura", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 50, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Float, 8, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDocumento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 50, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Float, 8, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha")})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Referencia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Referencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaTipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoFactura", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoFactura", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        Me.ImageList2.Images.SetKeyName(8, "")
        Me.ImageList2.Images.SetKeyName(9, "")
        Me.ImageList2.Images.SetKeyName(10, "")
        Me.ImageList2.Images.SetKeyName(11, "")
        Me.ImageList2.Images.SetKeyName(12, "")
        Me.ImageList2.Images.SetKeyName(13, "")
        Me.ImageList2.Images.SetKeyName(14, "")
        Me.ImageList2.Images.SetKeyName(15, "")
        Me.ImageList2.Images.SetKeyName(16, "")
        Me.ImageList2.Images.SetKeyName(17, "")
        Me.ImageList2.Images.SetKeyName(18, "")
        Me.ImageList2.Images.SetKeyName(19, "")
        Me.ImageList2.Images.SetKeyName(20, "")
        Me.ImageList2.Images.SetKeyName(21, "")
        Me.ImageList2.Images.SetKeyName(22, "")
        Me.ImageList2.Images.SetKeyName(23, "")
        Me.ImageList2.Images.SetKeyName(24, "")
        Me.ImageList2.Images.SetKeyName(25, "")
        Me.ImageList2.Images.SetKeyName(26, "")
        Me.ImageList2.Images.SetKeyName(27, "")
        Me.ImageList2.Images.SetKeyName(28, "")
        Me.ImageList2.Images.SetKeyName(29, "")
        Me.ImageList2.Images.SetKeyName(30, "")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumeroFactura", System.Data.SqlDbType.Float, 8, "NumeroFactura"), New System.Data.SqlClient.SqlParameter("@TipoFactura", System.Data.SqlDbType.VarChar, 3, "TipoFactura"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Referencia", System.Data.SqlDbType.VarChar, 50, "Referencia"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, "ReferenciaTipo"), New System.Data.SqlClient.SqlParameter("@ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, "ReferenciaDoc"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDocumento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT NumeroFactura, TipoFactura, FormaPago, Referencia, Documento, ReferenciaTi" & _
    "po, ReferenciaDoc, Moneda, TipoCambio, Id FROM Detalle_pago_caja"
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id, Documento, TipoDocumento, MontoPago, FormaPago, Usuario, Nombre, CodMo" & _
    "neda, TipoCambio, Fecha FROM OpcionesDePago"
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
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 303)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(718, 65)
        Me.ToolBar1.TabIndex = 1
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Eliminar"
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Name = "ToolBarExcel"
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        Me.ToolBarCerrar.Visible = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""TOSHIBA-USER"";packet size=4096;integrated security=SSPI;data sour" & _
    "ce=""."";persist security info=False;initial catalog=SeePOS"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'dadetalleopcionpago
        '
        Me.dadetalleopcionpago.DeleteCommand = Me.SqlDeleteCommand4
        Me.dadetalleopcionpago.InsertCommand = Me.SqlInsertCommand4
        Me.dadetalleopcionpago.SelectCommand = Me.SqlSelectCommand4
        Me.dadetalleopcionpago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Detalle_pago_caja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumeroFactura", "NumeroFactura"), New System.Data.Common.DataColumnMapping("TipoFactura", "TipoFactura"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Referencia", "Referencia"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("ReferenciaTipo", "ReferenciaTipo"), New System.Data.Common.DataColumnMapping("ReferenciaDoc", "ReferenciaDoc"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_ODP", "Id_ODP")})})
        Me.dadetalleopcionpago.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_ODP", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ODP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Referencia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Referencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaTipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoFactura", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoFactura", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumeroFactura", System.Data.SqlDbType.Float, 8, "NumeroFactura"), New System.Data.SqlClient.SqlParameter("@TipoFactura", System.Data.SqlDbType.VarChar, 3, "TipoFactura"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Referencia", System.Data.SqlDbType.VarChar, 50, "Referencia"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, "ReferenciaTipo"), New System.Data.SqlClient.SqlParameter("@ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, "ReferenciaDoc"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Id_ODP", System.Data.SqlDbType.BigInt, 8, "Id_ODP")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT NumeroFactura, TipoFactura, FormaPago, Referencia, Documento, ReferenciaTi" & _
    "po, ReferenciaDoc, Moneda, TipoCambio, Id, Id_ODP FROM Detalle_pago_caja"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumeroFactura", System.Data.SqlDbType.Float, 8, "NumeroFactura"), New System.Data.SqlClient.SqlParameter("@TipoFactura", System.Data.SqlDbType.VarChar, 3, "TipoFactura"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Referencia", System.Data.SqlDbType.VarChar, 50, "Referencia"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, "ReferenciaTipo"), New System.Data.SqlClient.SqlParameter("@ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, "ReferenciaDoc"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Id_ODP", System.Data.SqlDbType.BigInt, 8, "Id_ODP"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_ODP", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ODP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Referencia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Referencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReferenciaTipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReferenciaTipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoFactura", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'damoneda
        '
        Me.damoneda.SelectCommand = Me.SqlSelectCommand5
        Me.damoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'txtreftipo
        '
        Me.txtreftipo.ForeColor = System.Drawing.Color.Blue
        Me.txtreftipo.Location = New System.Drawing.Point(19, 258)
        Me.txtreftipo.Name = "txtreftipo"
        Me.txtreftipo.Size = New System.Drawing.Size(394, 23)
        Me.txtreftipo.TabIndex = 108
        '
        'daopcionpago
        '
        Me.daopcionpago.DeleteCommand = Me.SqlDeleteCommand7
        Me.daopcionpago.InsertCommand = Me.SqlInsertCommand7
        Me.daopcionpago.SelectCommand = Me.SqlSelectCommand7
        Me.daopcionpago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OpcionesDePago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("TipoDocumento", "TipoDocumento"), New System.Data.Common.DataColumnMapping("MontoPago", "MontoPago"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Denominacion", "Denominacion"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Nombremoneda", "Nombremoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Numapertura", "Numapertura")})})
        Me.daopcionpago.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Denominacion", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombremoneda", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombremoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numapertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numapertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDocumento", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.Float, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 3, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Float, 8, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 75, "Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Nombremoneda", System.Data.SqlDbType.VarChar, 50, "Nombremoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Numapertura", System.Data.SqlDbType.BigInt, 8, "Numapertura")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT id, Documento, TipoDocumento, MontoPago, FormaPago, Denominacion, Usuario," & _
    " Nombre, CodMoneda, Nombremoneda, TipoCambio, Fecha, Numapertura FROM OpcionesDe" & _
    "Pago"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.Float, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 3, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Float, 8, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 75, "Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Nombremoneda", System.Data.SqlDbType.VarChar, 50, "Nombremoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Numapertura", System.Data.SqlDbType.BigInt, 8, "Numapertura"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Denominacion", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombremoneda", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombremoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numapertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numapertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDocumento", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'TxtDocu
        '
        Me.TxtDocu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.Documento", True))
        Me.TxtDocu.Location = New System.Drawing.Point(10, 37)
        Me.TxtDocu.Name = "TxtDocu"
        Me.TxtDocu.Size = New System.Drawing.Size(115, 23)
        Me.TxtDocu.TabIndex = 109
        Me.TxtDocu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdenominacion
        '
        Me.txtdenominacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.Denominacion", True))
        Me.txtdenominacion.Location = New System.Drawing.Point(10, 83)
        Me.txtdenominacion.Name = "txtdenominacion"
        Me.txtdenominacion.Size = New System.Drawing.Size(115, 23)
        Me.txtdenominacion.TabIndex = 110
        Me.txtdenominacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtauxformapago
        '
        Me.txtauxformapago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.FormaPago", True))
        Me.txtauxformapago.Location = New System.Drawing.Point(10, 175)
        Me.txtauxformapago.Name = "txtauxformapago"
        Me.txtauxformapago.Size = New System.Drawing.Size(115, 23)
        Me.txtauxformapago.TabIndex = 112
        Me.txtauxformapago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtauxtipodocumento
        '
        Me.txtauxtipodocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.TipoDocumento", True))
        Me.txtauxtipodocumento.Location = New System.Drawing.Point(10, 222)
        Me.txtauxtipodocumento.Name = "txtauxtipodocumento"
        Me.txtauxtipodocumento.Size = New System.Drawing.Size(115, 23)
        Me.txtauxtipodocumento.TabIndex = 113
        Me.txtauxtipodocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtfecha
        '
        Me.txtfecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.Fecha", True))
        Me.txtfecha.Location = New System.Drawing.Point(154, 83)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(115, 23)
        Me.txtfecha.TabIndex = 114
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcodcoin
        '
        Me.txtcodcoin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.CodMoneda", True))
        Me.txtcodcoin.Location = New System.Drawing.Point(154, 129)
        Me.txtcodcoin.Name = "txtcodcoin"
        Me.txtcodcoin.Size = New System.Drawing.Size(115, 23)
        Me.txtcodcoin.TabIndex = 115
        Me.txtcodcoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttc
        '
        Me.txttc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.TipoCambio", True))
        Me.txttc.Location = New System.Drawing.Point(154, 222)
        Me.txttc.Name = "txttc"
        Me.txttc.Size = New System.Drawing.Size(86, 23)
        Me.txttc.TabIndex = 116
        Me.txttc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgdetopcpago
        '
        Me.dgdetopcpago.DataMember = "Detalle_pago_caja"
        Me.dgdetopcpago.DataSource = Me.DataSet_Opciones_Pago1
        '
        '
        '
        Me.dgdetopcpago.EmbeddedNavigator.Name = ""
        Me.dgdetopcpago.Location = New System.Drawing.Point(418, 134)
        Me.dgdetopcpago.MainView = Me.GridView2
        Me.dgdetopcpago.Name = "dgdetopcpago"
        Me.dgdetopcpago.Size = New System.Drawing.Size(451, 138)
        Me.dgdetopcpago.TabIndex = 117
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFormaPago2, Me.colReferencia, Me.colDocumento2, Me.colReferenciaTipo, Me.colReferenciaDoc})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFormaPago2
        '
        Me.colFormaPago2.Caption = "FormaPago"
        Me.colFormaPago2.FieldName = "FormaPago"
        Me.colFormaPago2.FilterInfo = ColumnFilterInfo1
        Me.colFormaPago2.Name = "colFormaPago2"
        Me.colFormaPago2.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFormaPago2.VisibleIndex = 0
        Me.colFormaPago2.Width = 81
        '
        'colReferencia
        '
        Me.colReferencia.Caption = "Ref."
        Me.colReferencia.FieldName = "Referencia"
        Me.colReferencia.FilterInfo = ColumnFilterInfo2
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colReferencia.VisibleIndex = 1
        Me.colReferencia.Width = 67
        '
        'colDocumento2
        '
        Me.colDocumento2.Caption = "Documento"
        Me.colDocumento2.FieldName = "Documento"
        Me.colDocumento2.FilterInfo = ColumnFilterInfo3
        Me.colDocumento2.Name = "colDocumento2"
        Me.colDocumento2.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDocumento2.VisibleIndex = 2
        Me.colDocumento2.Width = 67
        '
        'colReferenciaTipo
        '
        Me.colReferenciaTipo.Caption = "Ref.Tipo"
        Me.colReferenciaTipo.FieldName = "ReferenciaTipo"
        Me.colReferenciaTipo.FilterInfo = ColumnFilterInfo4
        Me.colReferenciaTipo.Name = "colReferenciaTipo"
        Me.colReferenciaTipo.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colReferenciaTipo.VisibleIndex = 3
        Me.colReferenciaTipo.Width = 67
        '
        'colReferenciaDoc
        '
        Me.colReferenciaDoc.Caption = "Ref.Doc"
        Me.colReferenciaDoc.FieldName = "ReferenciaDoc"
        Me.colReferenciaDoc.FilterInfo = ColumnFilterInfo5
        Me.colReferenciaDoc.Name = "colReferenciaDoc"
        Me.colReferenciaDoc.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colReferenciaDoc.VisibleIndex = 4
        Me.colReferenciaDoc.Width = 72
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.Location = New System.Drawing.Point(10, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 19)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "Documento"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(10, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 18)
        Me.Label20.TabIndex = 120
        Me.Label20.Text = "Denominación"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Location = New System.Drawing.Point(10, 157)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 18)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "FormaPago"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(10, 203)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 19)
        Me.Label23.TabIndex = 122
        Me.Label23.Text = "Tipo Documento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.Location = New System.Drawing.Point(154, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 18)
        Me.Label24.TabIndex = 123
        Me.Label24.Text = "Fecha"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(154, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 18)
        Me.Label25.TabIndex = 124
        Me.Label25.Text = "Cod Moneda"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(154, 203)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 19)
        Me.Label26.TabIndex = 125
        Me.Label26.Text = "Tipo Cambio"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnommoneda)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.txtmonto)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txttc)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtdenominacion)
        Me.GroupBox2.Controls.Add(Me.txtauxformapago)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtauxtipodocumento)
        Me.GroupBox2.Controls.Add(Me.txtfecha)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtcodcoin)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.TxtDocu)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txtNumApertura)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 489)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 259)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de Pago"
        '
        'txtnommoneda
        '
        Me.txtnommoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.Nombremoneda", True))
        Me.txtnommoneda.Location = New System.Drawing.Point(154, 175)
        Me.txtnommoneda.Name = "txtnommoneda"
        Me.txtnommoneda.Size = New System.Drawing.Size(115, 23)
        Me.txtnommoneda.TabIndex = 128
        Me.txtnommoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label35.Location = New System.Drawing.Point(154, 157)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(115, 18)
        Me.Label35.TabIndex = 129
        Me.Label35.Text = "Moneda"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmonto
        '
        Me.txtmonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.MontoPago", True))
        Me.txtmonto.Location = New System.Drawing.Point(10, 129)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(115, 23)
        Me.txtmonto.TabIndex = 126
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label34.Location = New System.Drawing.Point(10, 111)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(115, 18)
        Me.Label34.TabIndex = 127
        Me.Label34.Text = "Monto"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label38.Location = New System.Drawing.Point(144, 18)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(125, 19)
        Me.Label38.TabIndex = 137
        Me.Label38.Text = "Num Apertura"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumApertura
        '
        Me.txtNumApertura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.Numapertura", True))
        Me.txtNumApertura.Location = New System.Drawing.Point(144, 37)
        Me.txtNumApertura.Name = "txtNumApertura"
        Me.txtNumApertura.Size = New System.Drawing.Size(120, 23)
        Me.txtNumApertura.TabIndex = 136
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtreftipo)
        Me.GroupBox3.Controls.Add(Me.txtfactura)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txttipofact)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtformapago)
        Me.GroupBox3.Controls.Add(Me.txtauxcoin)
        Me.GroupBox3.Controls.Add(Me.txtauxtipocambio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(442, 480)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 148)
        Me.GroupBox3.TabIndex = 131
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle Pago Caja"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label33.Location = New System.Drawing.Point(317, 55)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(86, 19)
        Me.Label33.TabIndex = 133
        Me.Label33.Text = "Tipo Cambio"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label32.Location = New System.Drawing.Point(230, 55)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 19)
        Me.Label32.TabIndex = 132
        Me.Label32.Text = "Moneda"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.Location = New System.Drawing.Point(19, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(154, 19)
        Me.Label31.TabIndex = 131
        Me.Label31.Text = "FormaPago"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colDenominacion
        '
        Me.colDenominacion.Caption = "Denominación"
        Me.colDenominacion.FieldName = "Denominacion"
        Me.colDenominacion.FilterInfo = ColumnFilterInfo6
        Me.colDenominacion.Name = "colDenominacion"
        Me.colDenominacion.VisibleIndex = 4
        '
        'colTipoCambio
        '
        Me.colTipoCambio.Caption = "Cambio"
        Me.colTipoCambio.FieldName = "TipoCambio"
        Me.colTipoCambio.FilterInfo = ColumnFilterInfo7
        Me.colTipoCambio.Name = "colTipoCambio"
        Me.colTipoCambio.VisibleIndex = 3
        Me.colTipoCambio.Width = 39
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Factura"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.FilterInfo = ColumnFilterInfo8
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.VisibleIndex = 5
        Me.colDocumento.Width = 77
        '
        'colNombremoneda
        '
        Me.colNombremoneda.Caption = "Moneda"
        Me.colNombremoneda.FieldName = "Nombremoneda"
        Me.colNombremoneda.FilterInfo = ColumnFilterInfo9
        Me.colNombremoneda.Name = "colNombremoneda"
        Me.colNombremoneda.VisibleIndex = 2
        Me.colNombremoneda.Width = 71
        '
        'colMontoPago
        '
        Me.colMontoPago.Caption = "Monto"
        Me.colMontoPago.FieldName = "MontoPago"
        Me.colMontoPago.FilterInfo = ColumnFilterInfo10
        Me.colMontoPago.Name = "colMontoPago"
        Me.colMontoPago.VisibleIndex = 0
        '
        'colFormaPago
        '
        Me.colFormaPago.Caption = "Forma Pago"
        Me.colFormaPago.FieldName = "FormaPago"
        Me.colFormaPago.FilterInfo = ColumnFilterInfo11
        Me.colFormaPago.Name = "colFormaPago"
        Me.colFormaPago.VisibleIndex = 1
        Me.colFormaPago.Width = 49
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "OpcionesDePago"
        Me.GridControl1.DataSource = Me.DataSet_Opciones_Pago1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(418, 43)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(451, 229)
        Me.GridControl1.TabIndex = 133
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDocumento1, Me.colTipoDocumento, Me.colMontoPago1, Me.colFormaPago1, Me.colDenominacion1, Me.colNombremoneda1})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowDetailButtons = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDocumento1
        '
        Me.colDocumento1.Caption = "Documento"
        Me.colDocumento1.FieldName = "Documento"
        Me.colDocumento1.FilterInfo = ColumnFilterInfo12
        Me.colDocumento1.Name = "colDocumento1"
        Me.colDocumento1.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDocumento1.VisibleIndex = 0
        '
        'colTipoDocumento
        '
        Me.colTipoDocumento.Caption = "Tipo Doc."
        Me.colTipoDocumento.FieldName = "TipoDocumento"
        Me.colTipoDocumento.FilterInfo = ColumnFilterInfo13
        Me.colTipoDocumento.Name = "colTipoDocumento"
        Me.colTipoDocumento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipoDocumento.VisibleIndex = 1
        '
        'colMontoPago1
        '
        Me.colMontoPago1.Caption = "Monto Pago"
        Me.colMontoPago1.DisplayFormat.FormatString = "#,#0.00"
        Me.colMontoPago1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMontoPago1.FieldName = "MontoPago"
        Me.colMontoPago1.FilterInfo = ColumnFilterInfo14
        Me.colMontoPago1.Name = "colMontoPago1"
        Me.colMontoPago1.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMontoPago1.VisibleIndex = 2
        '
        'colFormaPago1
        '
        Me.colFormaPago1.Caption = "Forma Pago"
        Me.colFormaPago1.FieldName = "FormaPago"
        Me.colFormaPago1.FilterInfo = ColumnFilterInfo15
        Me.colFormaPago1.Name = "colFormaPago1"
        Me.colFormaPago1.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFormaPago1.VisibleIndex = 3
        '
        'colDenominacion1
        '
        Me.colDenominacion1.Caption = "Denominacion"
        Me.colDenominacion1.DisplayFormat.FormatString = "#,#0.00"
        Me.colDenominacion1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDenominacion1.FieldName = "Denominacion"
        Me.colDenominacion1.FilterInfo = ColumnFilterInfo16
        Me.colDenominacion1.Name = "colDenominacion1"
        Me.colDenominacion1.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDenominacion1.VisibleIndex = 4
        '
        'colNombremoneda1
        '
        Me.colNombremoneda1.Caption = "Moneda"
        Me.colNombremoneda1.FieldName = "Nombremoneda"
        Me.colNombremoneda1.FilterInfo = ColumnFilterInfo17
        Me.colNombremoneda1.Name = "colNombremoneda1"
        Me.colNombremoneda1.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNombremoneda1.VisibleIndex = 5
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(19, 674)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(999, 120)
        Me.Label39.TabIndex = 138
        '
        'Adapter_apertura
        '
        Me.Adapter_apertura.SelectCommand = Me.SqlSelectCommand6
        Me.Adapter_apertura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "aperturacaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT NApertura, Fecha, Nombre, Estado, Observaciones, Anulado, Cedula FROM aper" & _
    "turacaja"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'label_Tipo_Cambio
        '
        Me.label_Tipo_Cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "Moneda.ValorCompra", True))
        Me.label_Tipo_Cambio.Location = New System.Drawing.Point(317, 65)
        Me.label_Tipo_Cambio.Name = "label_Tipo_Cambio"
        Me.label_Tipo_Cambio.Size = New System.Drawing.Size(96, 18)
        Me.label_Tipo_Cambio.TabIndex = 140
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(317, 46)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(96, 19)
        Me.Label40.TabIndex = 141
        Me.Label40.Text = "Tipo Cambio"
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(154, 103)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(259, 18)
        Me.Label41.TabIndex = 142
        Me.Label41.Text = "Monto a Pagar"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Monto_Su_Moneda
        '
        Me.Monto_Su_Moneda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Monto_Su_Moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monto_Su_Moneda.ForeColor = System.Drawing.Color.Blue
        Me.Monto_Su_Moneda.Location = New System.Drawing.Point(893, 55)
        Me.Monto_Su_Moneda.Name = "Monto_Su_Moneda"
        Me.Monto_Su_Moneda.Size = New System.Drawing.Size(163, 37)
        Me.Monto_Su_Moneda.TabIndex = 143
        Me.Monto_Su_Moneda.Text = "0"
        Me.Monto_Su_Moneda.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Pagado_Su_Moneda
        '
        Me.Pagado_Su_Moneda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pagado_Su_Moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pagado_Su_Moneda.ForeColor = System.Drawing.Color.Blue
        Me.Pagado_Su_Moneda.Location = New System.Drawing.Point(893, 129)
        Me.Pagado_Su_Moneda.Name = "Pagado_Su_Moneda"
        Me.Pagado_Su_Moneda.Size = New System.Drawing.Size(163, 37)
        Me.Pagado_Su_Moneda.TabIndex = 144
        Me.Pagado_Su_Moneda.Text = "0"
        Me.Pagado_Su_Moneda.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label42.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label42.Location = New System.Drawing.Point(893, 37)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(163, 18)
        Me.Label42.TabIndex = 145
        Me.Label42.Text = "Monto Total Factura"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label43.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label43.Location = New System.Drawing.Point(893, 111)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(163, 18)
        Me.Label43.TabIndex = 146
        Me.Label43.Text = "Monto Pagado Factura"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtMontoPagar_Sumoneda
        '
        Me.TxtMontoPagar_Sumoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMontoPagar_Sumoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoPagar_Sumoneda.ForeColor = System.Drawing.Color.Blue
        Me.TxtMontoPagar_Sumoneda.Location = New System.Drawing.Point(893, 212)
        Me.TxtMontoPagar_Sumoneda.Multiline = True
        Me.TxtMontoPagar_Sumoneda.Name = "TxtMontoPagar_Sumoneda"
        Me.TxtMontoPagar_Sumoneda.Size = New System.Drawing.Size(163, 46)
        Me.TxtMontoPagar_Sumoneda.TabIndex = 147
        Me.TxtMontoPagar_Sumoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label36.Location = New System.Drawing.Point(893, 194)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(163, 18)
        Me.Label36.TabIndex = 148
        Me.Label36.Text = "Monto a Pagar"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.Nombre", True))
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(461, 345)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(245, 15)
        Me.txtNombreUsuario.TabIndex = 168
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(394, 345)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(67, 15)
        Me.txtUsuario.TabIndex = 166
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(317, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Usuario->"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaldoPrepago
        '
        Me.lblSaldoPrepago.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSaldoPrepago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPrepago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSaldoPrepago.Location = New System.Drawing.Point(154, 205)
        Me.lblSaldoPrepago.Name = "lblSaldoPrepago"
        Me.lblSaldoPrepago.Size = New System.Drawing.Size(162, 19)
        Me.lblSaldoPrepago.TabIndex = 150
        Me.lblSaldoPrepago.Text = "0.00"
        Me.lblSaldoPrepago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMovimientoCajaPagoAbono
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(718, 368)
        Me.Controls.Add(Me.lblSaldoPrepago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.TxtMontoPagar_Sumoneda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Pagado_Su_Moneda)
        Me.Controls.Add(Me.Monto_Su_Moneda)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.label_Tipo_Cambio)
        Me.Controls.Add(Me.GroupBox_Detalle_Pago)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.dgdetopcpago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblvuelto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmontopagado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblmontofact)
        Me.Controls.Add(Me.gbmoneda)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label39)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja.ReferenciaTipo", True))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(883, 479)
        Me.MinimizeBox = False
        Me.Name = "frmMovimientoCajaPagoAbono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento Caja de Pago"
        CType(Me.DataSet_Opciones_Pago1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblvuelto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblmontopagado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblmontofact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmoneda.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox_Detalle_Pago.ResumeLayout(False)
        Me.GroupBox_Detalle_Pago.PerformLayout()
        CType(Me.dgdetopcpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "variables"
    Private cConexion As New Conexion
    Private sqlConexion As SqlConnection
#End Region


    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.BindingContext(Me.DataSet_Opciones_Pago1, "Detalle_pago_caja").Count > 0 Then
            bandera = True
            Select Case Me.txtauxformapago.Text
                Case "EFE" : Me.efectivo()

                Case "TAR" : Me.tarjeta()

                Case "TRA" : Me.transferencia()

                Case "CHE" : Me.cheque()

                Case "SIN" : Me.SINPE() 'ZOE

                Case "PRE" : Me.Prepago() 'ZOE

            End Select
            bandera = False
        End If

    End Sub


    Private SaldoPrepago As Decimal = 0
    Public Cod_Cliente As String = "0"
    'gastos cuanto llevamos

    Private Sub CalcularPrepagos()
        Me.SaldoPrepago = Me.CargarSaldoPrepago(Me.Cod_Cliente)
        If Me.SaldoPrepago > 0 Then
            Me.rbPrepago.Enabled = True
            Me.lblSaldoPrepago.Text = Me.SaldoPrepago.ToString("N2")
        Else
            Me.lblSaldoPrepago.Text = "0.00"
            Me.rbPrepago.Enabled = False
        End If
    End Sub

    Public Function PrepagoAplicado() As Decimal
        Try
            Dim SaldoAplicado As Decimal = 0
            Dim Tipo As String = ""
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").CancelCurrentEdit()
            For i As Integer = 0 To Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Count() - 1
                Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Position = i

                Tipo = Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Current("FormaPago")
                If Tipo = "PRE" Then
                    SaldoAplicado += Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Current("MontoPago")
                End If
            Next
            Return SaldoAplicado
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function PasaValidacionPrepagos() As Boolean
        Dim Aplicados As Decimal = Me.PrepagoAplicado
        Me.CargarSaldoPrepago(Me.Cod_Cliente)
        If Aplicados > Me.SaldoPrepago Then
            MsgBox("Saldo de prepagos insuficiente." & vbCrLf _
                   & "Saldo disponible en prepagos es : " & Me.SaldoPrepago.ToString("N2"), MsgBoxStyle.Exclamation, "No se puede procesar la operacion.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmMovimientoCajaPagoAbono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'If Me.SqlConnection1.State <> ConnectionState.Closed Then Me.SqlConnection1.Close()

            SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            Me.DataSet_Opciones_Pago1.OpcionesDePago.idColumn.AutoIncrement = True
            Me.DataSet_Opciones_Pago1.OpcionesDePago.idColumn.AutoIncrementSeed = -1
            Me.DataSet_Opciones_Pago1.OpcionesDePago.idColumn.AutoIncrementStep = -1

            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.IdColumn.AutoIncrement = True
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.IdColumn.AutoIncrementSeed = -1
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.IdColumn.AutoIncrementStep = -1

            Me.txtUsuario.Text = usua.Cedula
            Me.txtNombreUsuario.Text = usua.Nombre
            Me.cedu = usua.Cedula
            Me.nombre = usua.Nombre

            If Not Me.Buscar_Apertura(usua.Cedula) Then
                Me.txtUsuario.Focus()
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
            Else
                inicializar()
            End If

            Me.CalcularPrepagos()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub inicializar()
        Try
            cargando = True

            Me.rbefectivo.Checked = True

            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.Clear()
            Me.DataSet_Opciones_Pago1.OpcionesDePago.Clear()


            Me.damoneda.Fill(Me.DataSet_Opciones_Pago1, "Moneda")
            defaultvalue()
            Nuevo()
            Me.cargando = True
            Me.cbomoneda.SelectedValue = Me.codmod
            Me.Monto_Su_Moneda.Text = Me.Total
            Me.Pagado_Su_Moneda.Text = 0

            recargar()
            sacar_conversion()
            Registra = False
            Me.txttotal.Enabled = True
            Me.cargando = False

            Me.txtUsuario.Enabled = False
            Me.txtNombreUsuario.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbefectivo.CheckedChanged
        If Me.rbefectivo.Checked = True Then
            Me.efectivo()
        End If
    End Sub
    Sub efectivo()
        Try
            Me.Seleccionado = 1

            Me.GroupBox_Detalle_Pago.Visible = False

            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then
                'Me.txtauxformapago.Text = "EFE" 
            Else
                Me.txtauxformapago.Text = "EFE"
            End If
            'Me.txtreftipo.Text = ""

            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").CancelCurrentEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub rbtarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtarjeta.CheckedChanged
        If Me.rbtarjeta.Checked = True Then
            Me.tarjeta()
            Me.PoneValoresDefecto()
        End If
    End Sub

    Private Sub PoneValoresDefecto()
        Me.TxtReferenciaF.Text = "00000"
        Me.TxtDocumentoF.Text = "00000"
        Me.TxtVoucher.Text = "00000"
        Me.GroupBox_Detalle_Pago.Visible = False
        Me.txttotal.Focus()
    End Sub

    Sub tarjeta()
        Try
            Me.Seleccionado = 2
            Me.GroupBox_Detalle_Pago.Visible = True
            Combo_Tarjeta.Visible = True
            Label_RefTipo.Visible = True
            TxtReferenciaTipo.Visible = True
            TxtVoucher.Visible = True

            If bandera = False Then nuevo_detalle()

            Me.GroupBox_Detalle_Pago.Text = "Pago con Tarjeta"
            Label_Referencia.Text = "Nº Tarjeta"
            Label_Documento.Text = "Autorización"
            Label_RefTipo.Text = "Tipo Tarjeta"
            Label_RefDocumento.Text = "Voucher"

            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then

            Else
                Me.txtformapago.Text = "TAR"
                Me.txtauxformapago.Text = "TAR"
            End If


            Me.TxtReferenciaF.Focus()

            'Me.txtreftipo.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub nuevo_detalle()
        Try
            Me.defaul_value_detalle()

            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Position = Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Count

            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").CancelCurrentEdit()
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    'Radio Button de Cheque
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcheque.CheckedChanged
        If Me.rbcheque.Checked = True Then
            Me.cheque()
            Me.PoneValoresDefecto()
        End If
    End Sub

    Sub cheque()
        Try
            Me.GroupBox_Detalle_Pago.Visible = True
            Combo_Tarjeta.Visible = False
            Label_RefTipo.Visible = True
            TxtReferenciaTipo.Visible = True
            TxtVoucher.Visible = False

            Me.Seleccionado = 3
            If bandera = False Then nuevo_detalle()

            Me.GroupBox_Detalle_Pago.Text = "Pago con Cheque"
            Label_Referencia.Text = "Emisor"
            Label_Documento.Text = "Nº Cheque"
            Label_RefTipo.Text = "Teléfono"
            Label_RefDocumento.Text = "Banco"


            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then

            Else
                Me.txtformapago.Text = "CHE"
                Me.txtauxformapago.Text = "CHE"
            End If

            'Me.txtreftipo.Text = Me.cbobancocheq.Text

            Me.TxtReferenciaF.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub rbtranferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtranferencia.CheckedChanged
        If Me.rbtranferencia.Checked = True Then
            Me.transferencia()
            Me.PoneValoresDefecto()
        End If
    End Sub

    Sub transferencia()
        Try
            Me.Seleccionado = 4
            ' Me.txtrefdocumento.Text = ""

            Me.GroupBox_Detalle_Pago.Visible = True
            Combo_Tarjeta.Visible = False
            TxtVoucher.Visible = False
            If bandera = False Then nuevo_detalle()

            Me.GroupBox_Detalle_Pago.Text = "Pago con Transferencia"
            Label_Referencia.Text = "Emisor"
            Label_Documento.Text = "Nº Transf."
            'Label_RefTipo.Text = "Teléfono"
            Label_RefTipo.Visible = False
            TxtReferenciaTipo.Visible = False
            Label_RefDocumento.Text = "Banco"

            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then

            Else
                Me.txtformapago.Text = "TRA"
                Me.txtauxformapago.Text = "TRA"
            End If

            Me.TxtReferenciaF.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SINPE()
        Try
            Me.Seleccionado = 5
            ' Me.txtrefdocumento.Text = ""

            Me.GroupBox_Detalle_Pago.Visible = True
            Combo_Tarjeta.Visible = False
            TxtVoucher.Visible = False
            If bandera = False Then nuevo_detalle()

            Me.GroupBox_Detalle_Pago.Text = "Pago con Transferencia"
            Label_Referencia.Text = "Emisor"
            Label_Documento.Text = "Nº Transf."
            'Label_RefTipo.Text = "Teléfono"
            Label_RefTipo.Visible = False
            TxtReferenciaTipo.Visible = False
            Label_RefDocumento.Text = "Banco"

            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then

            Else
                Me.txtformapago.Text = "SIN"
                Me.txtauxformapago.Text = "SIN"
            End If
            
            Me.TxtReferenciaF.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Prepago()
        Try
            Me.Seleccionado = 6
            Me.GroupBox_Detalle_Pago.Visible = True
            Combo_Tarjeta.Visible = True
            Label_RefTipo.Visible = True
            TxtReferenciaTipo.Visible = True
            TxtVoucher.Visible = True

            If bandera = False Then nuevo_detalle()

            Me.GroupBox_Detalle_Pago.Text = "Pago con Tarjeta"
            Label_Referencia.Text = "Nº Tarjeta"
            Label_Documento.Text = "Autorización"
            Label_RefTipo.Text = "Tipo Tarjeta"
            Label_RefDocumento.Text = "Voucher"

            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then

            Else
                Me.txtformapago.Text = "PRE"
                Me.txtauxformapago.Text = "PRE"
            End If

            Me.TxtReferenciaF.Focus()

            'Me.txtreftipo.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub defaultvalue()
        Try

            Me.DataSet_Opciones_Pago1.OpcionesDePago.TipoDocumentoColumn.DefaultValue = Tipo
            Me.DataSet_Opciones_Pago1.OpcionesDePago.DocumentoColumn.DefaultValue = Factura
            Me.DataSet_Opciones_Pago1.OpcionesDePago.FechaColumn.DefaultValue = fecha
            Me.DataSet_Opciones_Pago1.OpcionesDePago.MontoPagoColumn.DefaultValue = Me.Total

            Me.DataSet_Opciones_Pago1.OpcionesDePago.FormaPagoColumn.DefaultValue = "EFE"
            Me.DataSet_Opciones_Pago1.OpcionesDePago.CodMonedaColumn.DefaultValue = codmod


            Me.DataSet_Opciones_Pago1.OpcionesDePago.UsuarioColumn.DefaultValue = Me.cedu
            Me.DataSet_Opciones_Pago1.OpcionesDePago.NombreColumn.DefaultValue = Me.nombre
            Me.DataSet_Opciones_Pago1.OpcionesDePago.NumaperturaColumn.DefaultValue = NApertura
            Me.DataSet_Opciones_Pago1.OpcionesDePago.MontoPagoColumn.DefaultValue = 0
            Me.DataSet_Opciones_Pago1.OpcionesDePago.DenominacionColumn.DefaultValue = 0
            Me.DataSet_Opciones_Pago1.OpcionesDePago.NombremonedaColumn.DefaultValue = Me.cbomoneda.Text
            Me.DataSet_Opciones_Pago1.OpcionesDePago.TipoCambioColumn.DefaultValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub defaul_value_detalle()
        Try
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.NumeroFacturaColumn.DefaultValue = Factura
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.TipoFacturaColumn.DefaultValue = Tipo
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.FormaPagoColumn.DefaultValue = "EFE"
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.ReferenciaColumn.DefaultValue = ""
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.DocumentoColumn.DefaultValue = ""
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.ReferenciaDocColumn.DefaultValue = ""
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.ReferenciaTipoColumn.DefaultValue = ""
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.MonedaColumn.DefaultValue = Me.cbomoneda.SelectedValue
            Me.DataSet_Opciones_Pago1.Detalle_pago_caja.TipoCambioColumn.DefaultValue = txttc.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Nuevo()
        Try
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").AddNew()
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub recargar()
        'Me.txttotal.Text = Total
        Try
            Me.txttotal.Text = Format(Total, "#,#0.00")
            Me.lblmontofact.Text = CDbl(Me.txttotal.Text)
            'Me.lblcontador.Text = "0"

            Me.lblmontopagado.Text = 0
            Me.lblvuelto.Text = 0
            Me.cbomoneda.Enabled = True

            'Me.txtMontoRestante.Text = Me.txttotal.Text
            Me.txtnommoneda.Text = Me.cbomoneda.Text

            Me.Combo_Tarjeta.Items.Clear()
            Me.Combo_Tarjeta.Items.Add("ATH")
            Me.Combo_Tarjeta.Items.Add("CREDOMATIC")
            Me.Combo_Tarjeta.Items.Add("VISA")
            Me.Combo_Tarjeta.Items.Add("MASTERCARD")


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotal.KeyDown


        If e.KeyCode = Keys.Escape Then
            Cerrar_Opciones()
        End If

        If e.KeyCode = Keys.C Then
            Me.cbomoneda.Focus()
            SendKeys.Send("{F4}")
        End If

        If e.KeyCode = Keys.Enter Then
            Me.pagar()
        End If

        If e.KeyCode = Keys.F2 Then
            If Me.txttotal.Text <> "" Then
                If CDbl(Me.txttotal.Text) = 0 Then
                    Me.registrar()
                End If
            End If
        End If

    End Sub


    Function pagar()

        If rbPrepago.Checked = True And cbomoneda.SelectedValue = 2 Then
            MsgBox("Solo se pueden aplicar prepagos en colones.", MsgBoxStyle.Exclamation, Text)
            Exit Function
        End If

        Try
            If Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2) >= 0 Then
                registrar()
            Else
                Dim editando As Boolean = False
                'conversion
                Dim Monto_Pagar As Double
                vuelto = 0

                If Me.txttotal.Text = "" Then
                    MsgBox("Digite el Monto", MsgBoxStyle.Exclamation)
                    Me.txttotal.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)), 2)
                    Exit Function
                End If

                If CDbl(Me.txttotal.Text) <= 0 Then
                    Me.txttotal.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)), 2)
                    Exit Function
                End If


                If Me.Total = CDbl(Me.Pagado_Su_Moneda.Text) Then
                    Me.txttotal.Text = 0
                    Exit Function
                End If

                If Me.Validar Then
                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").EndCurrentEdit()
                Else
                    Exit Function
                End If



                Monto_Pagar = CDbl(Me.txttotal.Text)

                txtdenominacion.Text = Math.Round(Monto_Pagar + CDbl(Me.txtdenominacion.Text), 2)
                txtcodcoin.Text = Me.cbomoneda.SelectedValue
                Me.txttc.Text = Me.label_Tipo_Cambio.Text
                Me.txtnommoneda.Text = Me.cbomoneda.Text
                txtauxtipodocumento.Text = Me.Tipo


                Me.TxtMontoPagar_Sumoneda.Text = Math.Round(CDbl(Me.txttotal.Text) * (Me.Tipo_CambioOpciones / TipoCambio_Factura), 2)

                Pagado_Su_Moneda.Text = Math.Round(CDbl(Pagado_Su_Moneda.Text) + CDbl(Me.TxtMontoPagar_Sumoneda.Text), 2)

                ' si el monto restante es igual a 0, osea si ya se pago todo
                If CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text) <= 0 Then  ' si con este pago se tremina de cancelar el monto de la factura


                    Me.ToolBar1.Buttons(2).Enabled = True

                    If CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text) < 0 Then
                        vuelto = Math.Round((CDbl(Pagado_Su_Moneda.Text) - Me.Total), 2)
                    Else
                        vuelto = 0.0
                    End If

                    Me.lblvuelto.Text = Math.Round(vuelto, 2)
                    txtmonto.Text = Math.Round(CDbl(Me.txttotal.Text) + CDbl(txtmonto.Text) - CDbl(Me.lblvuelto.Text) * Conversion, 2)

                    Me.txttotal.Text = 0.0
                    Pagado_Su_Moneda.Text = Math.Round(Me.Total, 2)
                    lblmontopagado.Text = Math.Round(CDbl(lblmontofact.Text), 2)
                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()

                    Me.TxtMontoPagar_Sumoneda.Text = 0.0
                    Me.cbomoneda.Enabled = False
                    Me.Label3.Text = "Vuelto"
                    verificar_ultimo()
                    '********************************************************************************************
                    '18 agosto 2022, me parece que debe estar aqui
                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit() 'zoe
                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").EndCurrentEdit()
                    '********************************************************************************************
                    Me.rbefectivo.Checked = True
                Else ' si con este pago no se cancela la factura

                    If CDbl(Me.txtmonto.Text) <> 0 Then editando = True ' si se está editando que se active la bandera
                    txtmonto.Text = Math.Round(CDbl(Me.txttotal.Text) + CDbl(txtmonto.Text), 2)
                    lblmontopagado.Text = Math.Round(CDbl(Pagado_Su_Moneda.Text), 2)
                    vuelto = Math.Round((CDbl(Pagado_Su_Moneda.Text) - Total), 2)
                    Me.lblvuelto.Text = vuelto
                    Me.TxtMontoPagar_Sumoneda.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)), 2)
                    Me.txttotal.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)) * Conversion, 2)
                    Me.Label3.Text = "Faltante"


                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()
                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").EndCurrentEdit()

                    If editando Then
                        Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago.OpcionesDePagoDetalle_pago_caja").EndCurrentEdit()
                        editando = False
                    Else
                        Me.Nuevo()
                    End If
                    Me.rbefectivo.Checked = True
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Function




    Function verificar_ultimo() As Boolean
        Try
            Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Position = Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Count

            If CDbl(Me.txtmonto.Text) = 0 Then ' si el ultimo es el que se esta editando,se elimina
                Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").RemoveAt(Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").Position)
                Me.BindingContext(Me.DataSet_Opciones_Pago1, "OpcionesDePago").EndCurrentEdit()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Function Validar() As Boolean
        Try

            txtauxcoin.Text = cbomoneda.SelectedValue
            Select Case Me.Seleccionado

                Case 1

                Case 2
                    If Me.TxtReferenciaF.Text = "" Then
                        MsgBox("Digite el Nº de Tarjeta", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                    If Me.TxtDocumentoF.Text = "" Then
                        MsgBox("Digite la autorización", MsgBoxStyle.Exclamation)
                        Return False
                    End If


                Case 3
                    If Me.TxtReferenciaF.Text = "" Then
                        MsgBox("Digite el nombre Emisor del Cheque", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                    If Me.TxtDocumentoF.Text = "" Then
                        MsgBox("Digite el Nº de Cheque", MsgBoxStyle.Exclamation)
                        Return False
                    End If


                Case 4
                    If Me.TxtReferenciaF.Text = "" Then
                        MsgBox("Digite el nombre Emisor de la transferencia", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                    If Me.TxtDocumentoF.Text = "" Then
                        MsgBox("Digite el Nº de Transferencia", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                    If Me.Combo_Bancos.Text = "" Then
                        MsgBox("Digite el Nombre del Banco", MsgBoxStyle.Exclamation)
                        Return False
                    End If

            End Select

            Return True



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub cbbancotarj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_Tarjeta.SelectedIndexChanged
        Me.TxtReferenciaTipo.Text = Combo_Tarjeta.Text
    End Sub


    Function Buscar_Apertura(ByVal usuario As String) As Boolean
        Try


            Dim func As New cFunciones

            Dim i As Integer

            func.Cargar_Tabla_Generico(Me.Adapter_apertura, "SELECT * FROM AperturaCaja WHERE (Anulado = 0) AND (Estado = 'A') AND (Cedula = '" & usuario & "')")
            i = Me.Adapter_apertura.Fill(Me.DataSet_Opciones_Pago1.aperturacaja)

            Select Case i
                Case 1
                    NApertura = Me.DataSet_Opciones_Pago1.aperturacaja.Rows(0).Item("NApertura")
                    Me.txtNombreUsuario.Text = Me.DataSet_Opciones_Pago1.aperturacaja.Rows(0).Item("Nombre")
                    Return True
                Case 0
                    MsgBox(usua.Nombre & " " & "No tiene una apertura de caja abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
                Case Else
                    MsgBox(usua.Nombre & " " & "tiene mas de una abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub registrar()
        Try

            If Me.PasaValidacionPrepagos = False Then
                Exit Sub
            End If

            Dim Documento As String = Me.BindingContext(DataSet_Opciones_Pago1, "OpcionesDePago").Current("Documento")
            Dim Tipodocumento As String = Me.BindingContext(DataSet_Opciones_Pago1, "OpcionesDePago").Current("TipoDocumento")
            Dim mensaje As String = ""
            Dim strquery As String = "SELECT id FROM OpcionesDePago WHERE Documento = '" & Documento & "' AND tipoDocumento= '" & Tipodocumento & "'"
            mensaje = cConexion.SlqExecuteScalar(cConexion.Conectar, strquery)
            'If mensaje = "" Then
            Registra = True
            Me.Close()
            'Else

            'MsgBox("Esta Factura ya esta registrada!!", MsgBoxStyle.Exclamation, "Mensaje...")
            'Registra = False

            'cConexion.FacturaCancelada(Documento)

            'Me.Close()
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try

        'Registra = True
        'Me.Close()
    End Sub

    Public Function RegistrarOpcionesPago() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Trans = Me.SqlConnection1.BeginTransaction
        Try

            Me.daopcionpago.InsertCommand.Transaction = Trans
            Me.daopcionpago.UpdateCommand.Transaction = Trans
            Me.daopcionpago.DeleteCommand.Transaction = Trans

            Me.dadetalleopcionpago.InsertCommand.Transaction = Trans
            Me.dadetalleopcionpago.UpdateCommand.Transaction = Trans
            Me.dadetalleopcionpago.DeleteCommand.Transaction = Trans

            'Dim X As String
            'X = Me.BindingContext(Me.DataSet_Opciones_Pago1.Detalle_pago_caja).Current("FormaPago")


            Me.daopcionpago.Update(DataSet_Opciones_Pago1.OpcionesDePago)
            Me.dadetalleopcionpago.Update(DataSet_Opciones_Pago1.Detalle_pago_caja)

            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function


    Private Sub Eliminar_opcionpago()
        Dim resp As Integer

        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSet_Opciones_Pago1, "opcionesdepago").Count > 0 Then  ' si hay opciones de pago

                If CDbl(txtmonto.Text) = 0 Then
                    Exit Sub
                End If
                Conversion = TipoCambio_Factura / Tipo_CambioOpciones
                resp = MessageBox.Show("¿Desea eliminar esta opción de pago?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then

                    Pagado_Su_Moneda.Text = Math.Round(CDbl(Pagado_Su_Moneda.Text) - CDbl(txtmonto.Text) * (Me.Tipo_CambioOpciones / TipoCambio_Factura), 2)

                    lblmontopagado.Text = Math.Round(CDbl(Pagado_Su_Moneda.Text) * Conversion, 2)

                    vuelto = Math.Round((CDbl(Pagado_Su_Moneda.Text) - Me.Total) * Conversion, 2)

                    Me.lblvuelto.Text = vuelto

                    Me.TxtMontoPagar_Sumoneda.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)), 2)
                    Me.Label3.Text = "Faltante"
                    Me.rbefectivo.Checked = True

                    Me.txttotal.Text = Math.Round((CDbl(Me.TxtMontoPagar_Sumoneda.Text)) * Conversion, 2)

                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "opcionesdepago").RemoveAt(Me.BindingContext(Me.DataSet_Opciones_Pago1, "opcionesdepago").Position)
                    Me.BindingContext(Me.DataSet_Opciones_Pago1, "opcionesdepago").EndCurrentEdit()
                    Me.cbomoneda.Enabled = True
                    If Me.BindingContext(Me.DataSet_Opciones_Pago1, "opcionesdepago").Count = 0 Then
                        Me.Nuevo()
                    End If

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 3 : registrar()
            Case 7 : Cerrar_Opciones()
        End Select
    End Sub
    Private Sub Cerrar_Opciones()
        Dim resp As Integer
        resp = MessageBox.Show("¿La opción de pago aún no ha sido registrada; Desea salir sin registrar el documento como cancelado?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If resp = 6 Then
            DataSet_Opciones_Pago1.Detalle_pago_caja.Clear()
            DataSet_Opciones_Pago1.OpcionesDePago.Clear()
            Me.txtUsuario.Enabled = True
            Me.txtNombreUsuario.Enabled = True
            Me.lblmontofact.Text = "0.00"
            Me.txttotal.Text = "0.00"
            Me.Registra = False
            Me.Close()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_opcionpago()
        End If
    End Sub

    Private Sub txtnumtarjeta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReferenciaTipo.KeyPress, TxtDocumentoF.KeyPress, TxtReferenciaF.KeyPress, Combo_Bancos.KeyPress, Combo_Tarjeta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txttotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub



    Private Sub cbomoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomoneda.SelectedIndexChanged
        Try

            Dim TotalFactura As Double


            sacar_conversion()

            If Me.cargando Then
                Me.txttotal.Text = Me.Total
                Me.TxtMontoPagar_Sumoneda.Text = Me.Total
                Me.cargando = False
                lblmontofact.Text = Me.Total
                Me.lblmontopagado.Text = "0.00"

            Else
                '''''''''''''''''''''''Antes
                'Me.TxtMontoPagar_Sumoneda.Text = (CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text))
                'Me.txttotal.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)) * Conversion, 2)
                'lblmontofact.Text = Math.Round(Me.Total * Conversion, 2)

                'Me.lblmontopagado.Text = Math.Round(CDbl(Pagado_Su_Moneda.Text) * Conversion, 2)

                'If Me.Total > CDbl(Me.Pagado_Su_Moneda.Text) Then 'si el monto total y afue cancelado
                '    Me.lblvuelto.Text = Math.Round((CDbl(Me.Pagado_Su_Moneda.Text) - Me.Total) * Conversion, 2)
                'Else
                '    Me.lblvuelto.Text = "0.00"
                'End If

                ''Despues
                Me.TxtMontoPagar_Sumoneda.Text = (CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text))
                Me.txttotal.Text = Math.Round((CDbl(Monto_Su_Moneda.Text) - CDbl(Pagado_Su_Moneda.Text)) * Conversion, 2)
                'lblmontofact.Text = Math.Round(Me.Total * Conversion, 2)

                Me.lblmontopagado.Text = Math.Round(CDbl(Pagado_Su_Moneda.Text), 2)

                If Me.Total > CDbl(Me.Pagado_Su_Moneda.Text) Then 'si el monto total y afue cancelado
                    Me.lblvuelto.Text = Math.Round((CDbl(Me.Pagado_Su_Moneda.Text) - Me.Total), 2)
                Else
                    Me.lblvuelto.Text = "0.00"
                End If

            End If

            Me.txttotal.Focus()


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub sacar_conversion()

        Me.txtnommoneda.Text = Me.cbomoneda.Text
        mon = Me.DataSet_Opciones_Pago1.Moneda.Select("CodMoneda =" & codmod)
        mode = mon(0)
        TipoCambio_Factura = mode("ValorCompra")

        mon = Me.DataSet_Opciones_Pago1.Moneda.Select("CodMoneda =" & Me.cbomoneda.SelectedValue)
        mode = mon(0)
        Tipo_CambioOpciones = mode("ValorCompra")

        'Sacar factor de conversión
        Conversion = TipoCambio_Factura / Tipo_CambioOpciones
    End Sub

    Private Sub label_Tipo_Cambio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles label_Tipo_Cambio.TextChanged
        Me.txttc.Text = Me.label_Tipo_Cambio.Text
    End Sub


    Private Sub TxtVoucher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVoucher.TextChanged
        Me.Combo_Bancos.Text = TxtVoucher.Text
    End Sub



    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                Dim con As New Conexion
                Dim rs As SqlDataReader
                Dim enco As Boolean = False ' determina si el usuario fue o no encontrado

                If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open() ' si la conexion esta cerrada la abre

                rs = con.GetRecorset(Me.SqlConnection1, "Select Cedula, Nombre from usuarios where Clave_Interna = '" & Me.txtUsuario.Text & "'")
                While rs.Read
                    enco = True
                    Me.cedu = rs("Cedula")
                    Me.nombre = rs("Nombre")
                End While
                rs.Close()

                If Not enco Then
                    MsgBox("Clave incorrecta, digetala de nuevo", MsgBoxStyle.Exclamation)
                    Me.txtUsuario.Text = ""
                    Exit Sub
                End If

                If Not Me.Buscar_Apertura(Me.cedu) Then
                    Me.txtUsuario.Focus()
                Else : inicializar()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Sub frmMovimientoCajaPagoAbono_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout

    End Sub

    Private Sub txttotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.EditValueChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub rbSinpe_CheckedChanged(sender As Object, e As EventArgs) Handles rbSinpe.CheckedChanged
        If Me.rbSinpe.Checked = True Then
            Me.SINPE()
            Me.PoneValoresDefecto()
        End If
    End Sub

    Private Function CargarSaldoPrepago(_Identificacion As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select IsNull(Sum(debitos - creditos),0) as Saldo from viewMovimientosPrepagos where identificacion = " & _Identificacion, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Saldo")
        Else
            Return 0
        End If
    End Function

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Me.CalcularPrepagos()
    End Sub

    Private Sub rbPrepago_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrepago.CheckedChanged
        If Me.rbPrepago.Checked = True Then
            Me.Prepago()
            Me.PoneValoresDefecto()
        End If
    End Sub
End Class
