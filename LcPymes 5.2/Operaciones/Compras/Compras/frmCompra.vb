Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports GenCode128


Public Class frmCompra
    Inherits FrmPlantilla

#Region "Variables"
    Dim Finalizado_Importacion As Boolean = False
    Dim Importando As Boolean = False
    Private Indicador_Posicion As Integer
    Dim Usua As New Object
    Dim PMU As New PerfilModulo_Class
    Dim f As Boolean = False
    Dim s(50) As Integer
    Dim w(50) As Integer
    Dim z(50) As Integer
    Dim strCedula As String = ""
    Friend WithEvents txtSubtotalBonificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtCostoBonificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadBonificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBonificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ckBonificado As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodArticuloBonificacion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtTrans As System.Windows.Forms.TextBox
    Friend WithEvents ckTrans As System.Windows.Forms.CheckBox
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents txtCodCabys As ValidText.ValidText
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents colCodCabys As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Dim txtComboTipoF As String = ""

#End Region

#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        InitializeComponent() 'This call is required by the Windows Form Designer.
    End Sub

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()
        InitializeComponent() 'This call is required by the Windows Form Designer.
        Usua = Usuario_Parametro

        PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo 
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        Me.WindowState = FormWindowState.Minimized
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
    Friend WithEvents AdapterArticulos_Comprados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCompras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterMonedaDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterProveedores As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ButtonAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CBMonedaVenta As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxUtilidadFija As System.Windows.Forms.CheckBox
    Friend WithEvents chkbconsignacion As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxProvedor As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMonedaCompra As System.Windows.Forms.ComboBox
    Friend WithEvents ComboTipoF As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetCompras As DataSetCompras
    Friend WithEvents Descuento_Porcentaje_Detalle As ValidText.ValidText
    Friend WithEvents DTP_FechaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FechaVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridControlDetalleCompra As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDetalleArticulo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxOpcionesCompras As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnLote As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelMonedaCompra As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommandProveedores As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMonedaCompra As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxValorMonedaEnVenta As System.Windows.Forms.TextBox
    Friend WithEvents TxtBase As ValidText.ValidText
    Friend WithEvents TxtCantidad As ValidText.ValidText
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodArt As System.Windows.Forms.TextBox
    Friend WithEvents TxtCosto As ValidText.ValidText
    Friend WithEvents TxtCostoReal As ValidText.ValidText
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDescuento_Monto As ValidText.ValidText
    Friend WithEvents TxtDias As System.Windows.Forms.TextBox
    Friend WithEvents TxtExento As ValidText.ValidText
    Friend WithEvents TxtFacturaCompraN As System.Windows.Forms.TextBox
    Friend WithEvents TxtGravado As ValidText.ValidText
    Friend WithEvents TxtIDUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtimpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtImpuesto_Monto As ValidText.ValidText
    Friend WithEvents TxtImpuesto_Porcentaje As ValidText.ValidText
    Friend WithEvents txtmontofact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents TxtOtros As ValidText.ValidText
    Friend WithEvents TxtPrecioVenta_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotalCompra As ValidText.ValidText
    Friend WithEvents TxtTotalFactura As ValidText.ValidText
    Friend WithEvents txttransporte As ValidText.ValidText
    Friend WithEvents TxtUtilidad_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidadFija As ValidText.ValidText
    Friend WithEvents ValidText1 As ValidText.ValidText
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtCostoEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtOtrosCargosEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtFleteEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtBaseEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxValorMonedaEnCosto As System.Windows.Forms.TextBox
    Friend WithEvents TxtFlete As ValidText.ValidText
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtsubgra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextBox2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Adapter_OrdenCompra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_DetalleOrdenCompra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label_Tipo As System.Windows.Forms.Label

    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents TxtSubExc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGravado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescuento_P As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colImpuesto_P As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colImpuesto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LookUpEdit_Proveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents LNumero As System.Windows.Forms.Label
    Friend WithEvents TbNumero As System.Windows.Forms.TextBox
    Friend WithEvents LVencimiento As System.Windows.Forms.Label
    Friend WithEvents DTPVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LOpcion As System.Windows.Forms.Label
    Friend WithEvents AdapterLotes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colLote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TxtRegalias As ValidText.ValidText
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents colRegalias As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CK_impuesto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Ck_Mascotas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents labelCanceladoFactura As System.Windows.Forms.Label
    Friend WithEvents CbNumero As System.Windows.Forms.ComboBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txt_num_orden As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand



    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotalFactura = New ValidText.ValidText()
        Me.GroupBoxOpcionesCompras = New System.Windows.Forms.GroupBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.txtTrans = New System.Windows.Forms.TextBox()
        Me.ckTrans = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_num_orden = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Ck_Mascotas = New DevExpress.XtraEditors.CheckEdit()
        Me.DataSetCompras = New LcPymes_5._2.DataSetCompras()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.TextBoxMonedaCompra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboMonedaCompra = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFacturaCompraN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboTipoF = New System.Windows.Forms.ComboBox()
        Me.TxtDias = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.DTP_FechaVence = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMonedaCompra = New System.Windows.Forms.Label()
        Me.Label_Tipo = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBoxDetalleArticulo = New System.Windows.Forms.GroupBox()
        Me.txtCodCabys = New ValidText.ValidText()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtCodArticuloBonificacion = New System.Windows.Forms.TextBox()
        Me.txtSubtotalBonificacion = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtCostoBonificacion = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtCantidadBonificacion = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtCodigoBonificacion = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.ckBonificado = New System.Windows.Forms.CheckBox()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TxtRegalias = New ValidText.ValidText()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtDescuento_Monto = New ValidText.ValidText()
        Me.TxtImpuesto_Monto = New ValidText.ValidText()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodArt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New ValidText.ValidText()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtImpuesto_Porcentaje = New ValidText.ValidText()
        Me.Descuento_Porcentaje_Detalle = New ValidText.ValidText()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtTotalCompra = New ValidText.ValidText()
        Me.TxtCosto = New ValidText.ValidText()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnLote = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TxtOtros = New ValidText.ValidText()
        Me.TxtFlete = New ValidText.ValidText()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtBase = New ValidText.ValidText()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CbNumero = New System.Windows.Forms.ComboBox()
        Me.LNumero = New System.Windows.Forms.Label()
        Me.TbNumero = New System.Windows.Forms.TextBox()
        Me.LVencimiento = New System.Windows.Forms.Label()
        Me.DTPVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LOpcion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CK_impuesto = New DevExpress.XtraEditors.CheckEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmontofact = New DevExpress.XtraEditors.TextEdit()
        Me.txtimpuesto = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescuento = New DevExpress.XtraEditors.TextEdit()
        Me.TxtSubExc = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsubgra = New DevExpress.XtraEditors.TextEdit()
        Me.TextBox2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNombreUsuario = New System.Windows.Forms.Label()
        Me.ComboBoxProvedor = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.AdapterCompras = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterProveedores = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterArticulos_Comprados = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta_IV_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_B = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_B = New DevExpress.XtraEditors.TextEdit()
        Me.TextBoxValorMonedaEnVenta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CBMonedaVenta = New System.Windows.Forms.ComboBox()
        Me.TxtUtilidad_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_B = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCostoReal = New ValidText.ValidText()
        Me.TxtBaseEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtFleteEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtOtrosCargosEquivalente = New System.Windows.Forms.TextBox()
        Me.ButtonAgregarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckBoxUtilidadFija = New System.Windows.Forms.CheckBox()
        Me.TxtUtilidadFija = New ValidText.ValidText()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.TxtGravado = New ValidText.ValidText()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtExento = New ValidText.ValidText()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridControlDetalleCompra = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodCabys = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCosto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRegalias = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGravado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescuento_P = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colImpuesto_P = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colImpuesto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.AdapterMonedaDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.TxtIDUsuario = New System.Windows.Forms.TextBox()
        Me.ValidText1 = New ValidText.ValidText()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LookUpEdit_Proveedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.AdapterUsuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.TxtCostoEquivalente = New System.Windows.Forms.TextBox()
        Me.TextBoxValorMonedaEnCosto = New System.Windows.Forms.TextBox()
        Me.Adapter_OrdenCompra = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_DetalleOrdenCompra = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.AdapterLotes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.labelCanceladoFactura = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxOpcionesCompras.SuspendLayout()
        CType(Me.Ck_Mascotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDetalleArticulo.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.CK_impuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmontofact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtimpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubExc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubgra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtPrecioVenta_IV_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlDetalleCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LookUpEdit_Proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.ImageIndex = 4
        Me.ToolBarExcel.Text = "Etiquetas"
        Me.ToolBarExcel.Visible = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 60)
        Me.ToolBar1.Location = New System.Drawing.Point(0, 396)
        Me.ToolBar1.Size = New System.Drawing.Size(1062, 56)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(920, 424)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(1062, 32)
        Me.TituloModulo.Text = "Registro de Compras"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(468, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Proveedor "
        '
        'TxtTotalFactura
        '
        Me.TxtTotalFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotalFactura.FieldReference = Nothing
        Me.TxtTotalFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalFactura.ForeColor = System.Drawing.Color.Blue
        Me.TxtTotalFactura.Location = New System.Drawing.Point(322, 122)
        Me.TxtTotalFactura.MaskEdit = ""
        Me.TxtTotalFactura.Name = "TxtTotalFactura"
        Me.TxtTotalFactura.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtTotalFactura.Required = False
        Me.TxtTotalFactura.ShowErrorIcon = False
        Me.TxtTotalFactura.Size = New System.Drawing.Size(152, 13)
        Me.TxtTotalFactura.TabIndex = 3
        Me.TxtTotalFactura.Text = "0.00"
        Me.TxtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalFactura.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtTotalFactura.ValidText = "#0"
        '
        'GroupBoxOpcionesCompras
        '
        Me.GroupBoxOpcionesCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxOpcionesCompras.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.btnAplicar)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.txtTrans)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.ckTrans)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Button2)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.txt_num_orden)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label49)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Ck_Mascotas)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.CheckEdit1)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.TextBoxMonedaCompra)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label5)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.ComboMonedaCompra)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label39)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label1)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.TxtFacturaCompraN)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label3)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.ComboTipoF)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.TxtDias)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label41)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.DTP_FechaVence)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.DTP_FechaCompra)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.Label4)
        Me.GroupBoxOpcionesCompras.Controls.Add(Me.LabelMonedaCompra)
        Me.GroupBoxOpcionesCompras.Enabled = False
        Me.GroupBoxOpcionesCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpcionesCompras.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBoxOpcionesCompras.Location = New System.Drawing.Point(490, 31)
        Me.GroupBoxOpcionesCompras.Name = "GroupBoxOpcionesCompras"
        Me.GroupBoxOpcionesCompras.Size = New System.Drawing.Size(564, 81)
        Me.GroupBoxOpcionesCompras.TabIndex = 100
        Me.GroupBoxOpcionesCompras.TabStop = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(486, 54)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(76, 23)
        Me.btnAplicar.TabIndex = 903
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'txtTrans
        '
        Me.txtTrans.Enabled = False
        Me.txtTrans.Location = New System.Drawing.Point(347, 55)
        Me.txtTrans.Name = "txtTrans"
        Me.txtTrans.Size = New System.Drawing.Size(135, 20)
        Me.txtTrans.TabIndex = 902
        '
        'ckTrans
        '
        Me.ckTrans.AutoSize = True
        Me.ckTrans.Location = New System.Drawing.Point(283, 58)
        Me.ckTrans.Name = "ckTrans"
        Me.ckTrans.Size = New System.Drawing.Size(58, 17)
        Me.ckTrans.TabIndex = 901
        Me.ckTrans.Text = "Trans"
        Me.ckTrans.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(528, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 900
        Me.Button2.Text = "RS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_num_orden
        '
        Me.txt_num_orden.BackColor = System.Drawing.Color.White
        Me.txt_num_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_orden.ForeColor = System.Drawing.Color.Blue
        Me.txt_num_orden.Location = New System.Drawing.Point(456, 32)
        Me.txt_num_orden.Name = "txt_num_orden"
        Me.txt_num_orden.Size = New System.Drawing.Size(72, 20)
        Me.txt_num_orden.TabIndex = 899
        Me.txt_num_orden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label49.Location = New System.Drawing.Point(456, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(72, 15)
        Me.Label49.TabIndex = 84
        Me.Label49.Text = "Orden"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Ck_Mascotas
        '
        Me.Ck_Mascotas.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetCompras, "compras.Mascotas", True))
        Me.Ck_Mascotas.EditValue = False
        Me.Ck_Mascotas.Location = New System.Drawing.Point(431, -1)
        Me.Ck_Mascotas.Name = "Ck_Mascotas"
        '
        '
        '
        Me.Ck_Mascotas.Properties.Caption = "Mascotas"
        Me.Ck_Mascotas.Properties.Enabled = False
        Me.Ck_Mascotas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.ControlLight, System.Drawing.Color.RoyalBlue)
        Me.Ck_Mascotas.Size = New System.Drawing.Size(80, 19)
        Me.Ck_Mascotas.TabIndex = 83
        Me.Ck_Mascotas.Visible = False
        '
        'DataSetCompras
        '
        Me.DataSetCompras.DataSetName = "DataSetCompras"
        Me.DataSetCompras.Locale = New System.Globalization.CultureInfo("")
        Me.DataSetCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetCompras, "compras.Taller", True))
        Me.CheckEdit1.EditValue = False
        Me.CheckEdit1.Location = New System.Drawing.Point(345, 0)
        Me.CheckEdit1.Name = "CheckEdit1"
        '
        '
        '
        Me.CheckEdit1.Properties.Caption = "Taller"
        Me.CheckEdit1.Properties.Enabled = False
        Me.CheckEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.ControlLight, System.Drawing.Color.RoyalBlue)
        Me.CheckEdit1.Size = New System.Drawing.Size(80, 19)
        Me.CheckEdit1.TabIndex = 82
        Me.CheckEdit1.Visible = False
        '
        'TextBoxMonedaCompra
        '
        Me.TextBoxMonedaCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMonedaCompra.Enabled = False
        Me.TextBoxMonedaCompra.Location = New System.Drawing.Point(185, 60)
        Me.TextBoxMonedaCompra.Name = "TextBoxMonedaCompra"
        Me.TextBoxMonedaCompra.ReadOnly = True
        Me.TextBoxMonedaCompra.Size = New System.Drawing.Size(92, 13)
        Me.TextBoxMonedaCompra.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(283, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Días"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboMonedaCompra
        '
        Me.ComboMonedaCompra.DataSource = Me.DataSetCompras
        Me.ComboMonedaCompra.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMonedaCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMonedaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMonedaCompra.ForeColor = System.Drawing.Color.Blue
        Me.ComboMonedaCompra.ItemHeight = 13
        Me.ComboMonedaCompra.Location = New System.Drawing.Point(67, 57)
        Me.ComboMonedaCompra.Name = "ComboMonedaCompra"
        Me.ComboMonedaCompra.Size = New System.Drawing.Size(109, 21)
        Me.ComboMonedaCompra.TabIndex = 9
        Me.ComboMonedaCompra.ValueMember = "Moneda.CodMoneda"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label39.Location = New System.Drawing.Point(118, 17)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(58, 15)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Opciones de Compra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtFacturaCompraN
        '
        Me.TxtFacturaCompraN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFacturaCompraN.ForeColor = System.Drawing.Color.Blue
        Me.TxtFacturaCompraN.Location = New System.Drawing.Point(8, 34)
        Me.TxtFacturaCompraN.Name = "TxtFacturaCompraN"
        Me.TxtFacturaCompraN.Size = New System.Drawing.Size(101, 20)
        Me.TxtFacturaCompraN.TabIndex = 4
        Me.TxtFacturaCompraN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Numero Factura"
        '
        'ComboTipoF
        '
        Me.ComboTipoF.DisplayMember = "CON"
        Me.ComboTipoF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTipoF.ForeColor = System.Drawing.Color.Blue
        Me.ComboTipoF.Items.AddRange(New Object() {"CON", "CRE"})
        Me.ComboTipoF.Location = New System.Drawing.Point(115, 34)
        Me.ComboTipoF.Name = "ComboTipoF"
        Me.ComboTipoF.Size = New System.Drawing.Size(61, 21)
        Me.ComboTipoF.TabIndex = 5
        Me.ComboTipoF.ValueMember = "CON"
        '
        'TxtDias
        '
        Me.TxtDias.Enabled = False
        Me.TxtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDias.Location = New System.Drawing.Point(283, 33)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.Size = New System.Drawing.Size(60, 20)
        Me.TxtDias.TabIndex = 7
        Me.TxtDias.Text = "0.00"
        Me.TxtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label41.Location = New System.Drawing.Point(354, 17)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(94, 15)
        Me.Label41.TabIndex = 9
        Me.Label41.Text = "Vencimiento"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DTP_FechaVence
        '
        Me.DTP_FechaVence.Enabled = False
        Me.DTP_FechaVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FechaVence.Location = New System.Drawing.Point(354, 32)
        Me.DTP_FechaVence.Name = "DTP_FechaVence"
        Me.DTP_FechaVence.Size = New System.Drawing.Size(94, 20)
        Me.DTP_FechaVence.TabIndex = 8
        '
        'DTP_FechaCompra
        '
        Me.DTP_FechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FechaCompra.Location = New System.Drawing.Point(180, 34)
        Me.DTP_FechaCompra.Name = "DTP_FechaCompra"
        Me.DTP_FechaCompra.Size = New System.Drawing.Size(97, 20)
        Me.DTP_FechaCompra.TabIndex = 6
        Me.DTP_FechaCompra.Value = New Date(2006, 3, 5, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(180, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelMonedaCompra
        '
        Me.LabelMonedaCompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelMonedaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelMonedaCompra.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelMonedaCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelMonedaCompra.Location = New System.Drawing.Point(8, 57)
        Me.LabelMonedaCompra.Name = "LabelMonedaCompra"
        Me.LabelMonedaCompra.Size = New System.Drawing.Size(59, 21)
        Me.LabelMonedaCompra.TabIndex = 11
        Me.LabelMonedaCompra.Text = "Moneda"
        Me.LabelMonedaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Tipo
        '
        Me.Label_Tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCompras, "compras.TipoCompra", True))
        Me.Label_Tipo.Location = New System.Drawing.Point(88, 0)
        Me.Label_Tipo.Name = "Label_Tipo"
        Me.Label_Tipo.Size = New System.Drawing.Size(50, 17)
        Me.Label_Tipo.TabIndex = 16
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(2, 457)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 14)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Cambiar Monto"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(803, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(59, 13)
        Me.TextBox1.TabIndex = 11
        '
        'GroupBoxDetalleArticulo
        '
        Me.GroupBoxDetalleArticulo.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtCodCabys)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label54)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtCodArticuloBonificacion)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtSubtotalBonificacion)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label53)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtCostoBonificacion)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label52)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtCantidadBonificacion)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label51)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtCodigoBonificacion)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label50)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.ckBonificado)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtCodArticulo)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label46)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtRegalias)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label14)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtDescuento_Monto)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtImpuesto_Monto)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.txtdescripcion)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtCodArt)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label6)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtCantidad)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label25)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label21)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label23)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtImpuesto_Porcentaje)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Descuento_Porcentaje_Detalle)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label24)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtTotalCompra)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtCosto)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label26)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.btnLote)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label43)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtOtros)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtFlete)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label22)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TxtBase)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label20)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.Label19)
        Me.GroupBoxDetalleArticulo.Controls.Add(Me.TextBox1)
        Me.GroupBoxDetalleArticulo.Enabled = False
        Me.GroupBoxDetalleArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDetalleArticulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBoxDetalleArticulo.Location = New System.Drawing.Point(1, 118)
        Me.GroupBoxDetalleArticulo.Name = "GroupBoxDetalleArticulo"
        Me.GroupBoxDetalleArticulo.Size = New System.Drawing.Size(1053, 90)
        Me.GroupBoxDetalleArticulo.TabIndex = 100
        Me.GroupBoxDetalleArticulo.TabStop = False
        '
        'txtCodCabys
        '
        Me.txtCodCabys.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodCabys.FieldReference = Nothing
        Me.txtCodCabys.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCabys.ForeColor = System.Drawing.Color.Blue
        Me.txtCodCabys.Location = New System.Drawing.Point(637, 46)
        Me.txtCodCabys.MaskEdit = ""
        Me.txtCodCabys.Name = "txtCodCabys"
        Me.txtCodCabys.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCodCabys.Required = True
        Me.txtCodCabys.ShowErrorIcon = True
        Me.txtCodCabys.Size = New System.Drawing.Size(132, 13)
        Me.txtCodCabys.TabIndex = 10
        Me.txtCodCabys.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodCabys.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtCodCabys.ValidText = "#0.00"
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(637, 30)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(132, 12)
        Me.Label54.TabIndex = 103
        Me.Label54.Text = "Cabys"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtCodArticuloBonificacion
        '
        Me.txtCodArticuloBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodArticuloBonificacion.Enabled = False
        Me.txtCodArticuloBonificacion.Location = New System.Drawing.Point(184, 67)
        Me.txtCodArticuloBonificacion.Name = "txtCodArticuloBonificacion"
        Me.txtCodArticuloBonificacion.Size = New System.Drawing.Size(82, 13)
        Me.txtCodArticuloBonificacion.TabIndex = 101
        '
        'txtSubtotalBonificacion
        '
        Me.txtSubtotalBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotalBonificacion.Enabled = False
        Me.txtSubtotalBonificacion.Location = New System.Drawing.Point(714, 66)
        Me.txtSubtotalBonificacion.Name = "txtSubtotalBonificacion"
        Me.txtSubtotalBonificacion.Size = New System.Drawing.Size(82, 13)
        Me.txtSubtotalBonificacion.TabIndex = 99
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label53.Enabled = False
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label53.Location = New System.Drawing.Point(634, 65)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(76, 14)
        Me.Label53.TabIndex = 100
        Me.Label53.Text = "Subtotal"
        '
        'txtCostoBonificacion
        '
        Me.txtCostoBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoBonificacion.Enabled = False
        Me.txtCostoBonificacion.Location = New System.Drawing.Point(536, 66)
        Me.txtCostoBonificacion.Name = "txtCostoBonificacion"
        Me.txtCostoBonificacion.Size = New System.Drawing.Size(82, 13)
        Me.txtCostoBonificacion.TabIndex = 97
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label52.Enabled = False
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label52.Location = New System.Drawing.Point(456, 65)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(76, 14)
        Me.Label52.TabIndex = 98
        Me.Label52.Text = "Costo"
        '
        'txtCantidadBonificacion
        '
        Me.txtCantidadBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadBonificacion.Enabled = False
        Me.txtCantidadBonificacion.Location = New System.Drawing.Point(352, 67)
        Me.txtCantidadBonificacion.Name = "txtCantidadBonificacion"
        Me.txtCantidadBonificacion.Size = New System.Drawing.Size(82, 13)
        Me.txtCantidadBonificacion.TabIndex = 95
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label51.Enabled = False
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label51.Location = New System.Drawing.Point(272, 66)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(76, 14)
        Me.Label51.TabIndex = 96
        Me.Label51.Text = "Cantidad"
        '
        'txtCodigoBonificacion
        '
        Me.txtCodigoBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoBonificacion.Enabled = False
        Me.txtCodigoBonificacion.Location = New System.Drawing.Point(810, 97)
        Me.txtCodigoBonificacion.Name = "txtCodigoBonificacion"
        Me.txtCodigoBonificacion.Size = New System.Drawing.Size(82, 13)
        Me.txtCodigoBonificacion.TabIndex = 93
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label50.Enabled = False
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label50.Location = New System.Drawing.Point(104, 65)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 14)
        Me.Label50.TabIndex = 94
        Me.Label50.Text = "Código ->"
        '
        'ckBonificado
        '
        Me.ckBonificado.AutoSize = True
        Me.ckBonificado.Location = New System.Drawing.Point(8, 65)
        Me.ckBonificado.Name = "ckBonificado"
        Me.ckBonificado.Size = New System.Drawing.Size(86, 17)
        Me.ckBonificado.TabIndex = 92
        Me.ckBonificado.Text = "Bonificado"
        Me.ckBonificado.UseVisualStyleBackColor = True
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodArticulo.Location = New System.Drawing.Point(88, 16)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(82, 13)
        Me.txtCodArticulo.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(80, 48)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(24, 12)
        Me.Label46.TabIndex = 91
        Me.Label46.Text = "+"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtRegalias
        '
        Me.TxtRegalias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRegalias.FieldReference = Nothing
        Me.TxtRegalias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegalias.ForeColor = System.Drawing.Color.Blue
        Me.TxtRegalias.Location = New System.Drawing.Point(112, 48)
        Me.TxtRegalias.MaskEdit = ""
        Me.TxtRegalias.Name = "TxtRegalias"
        Me.TxtRegalias.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtRegalias.Required = True
        Me.TxtRegalias.ShowErrorIcon = True
        Me.TxtRegalias.Size = New System.Drawing.Size(56, 13)
        Me.TxtRegalias.TabIndex = 2
        Me.TxtRegalias.Text = "0.00"
        Me.TxtRegalias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtRegalias.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtRegalias.ValidText = "#0.00"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1043, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Artículos en Detalle de Compra"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescuento_Monto
        '
        Me.TxtDescuento_Monto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescuento_Monto.FieldReference = Nothing
        Me.TxtDescuento_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuento_Monto.ForeColor = System.Drawing.Color.Blue
        Me.TxtDescuento_Monto.Location = New System.Drawing.Point(536, 46)
        Me.TxtDescuento_Monto.MaskEdit = ""
        Me.TxtDescuento_Monto.Name = "TxtDescuento_Monto"
        Me.TxtDescuento_Monto.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtDescuento_Monto.Required = True
        Me.TxtDescuento_Monto.ShowErrorIcon = False
        Me.TxtDescuento_Monto.Size = New System.Drawing.Size(92, 13)
        Me.TxtDescuento_Monto.TabIndex = 9
        Me.TxtDescuento_Monto.Text = "0.00"
        Me.TxtDescuento_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDescuento_Monto.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtDescuento_Monto.ValidText = "#0"
        '
        'TxtImpuesto_Monto
        '
        Me.TxtImpuesto_Monto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtImpuesto_Monto.Enabled = False
        Me.TxtImpuesto_Monto.FieldReference = Nothing
        Me.TxtImpuesto_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto_Monto.ForeColor = System.Drawing.Color.Blue
        Me.TxtImpuesto_Monto.Location = New System.Drawing.Point(771, 47)
        Me.TxtImpuesto_Monto.MaskEdit = ""
        Me.TxtImpuesto_Monto.Name = "TxtImpuesto_Monto"
        Me.TxtImpuesto_Monto.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtImpuesto_Monto.Required = True
        Me.TxtImpuesto_Monto.ShowErrorIcon = False
        Me.TxtImpuesto_Monto.Size = New System.Drawing.Size(101, 13)
        Me.TxtImpuesto_Monto.TabIndex = 11
        Me.TxtImpuesto_Monto.Text = "0.00"
        Me.TxtImpuesto_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtImpuesto_Monto.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtImpuesto_Monto.ValidText = "#0"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(176, 15)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(824, 13)
        Me.txtdescripcion.TabIndex = 10
        '
        'TxtCodArt
        '
        Me.TxtCodArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodArt.Location = New System.Drawing.Point(-88, 15)
        Me.TxtCodArt.Name = "TxtCodArt"
        Me.TxtCodArt.Size = New System.Drawing.Size(88, 13)
        Me.TxtCodArt.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(8, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Código ->"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCantidad.FieldReference = Nothing
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.ForeColor = System.Drawing.Color.Blue
        Me.TxtCantidad.Location = New System.Drawing.Point(8, 46)
        Me.TxtCantidad.MaskEdit = ""
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCantidad.Required = True
        Me.TxtCantidad.ShowErrorIcon = True
        Me.TxtCantidad.Size = New System.Drawing.Size(64, 13)
        Me.TxtCantidad.TabIndex = 1
        Me.TxtCantidad.Text = "0.00"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCantidad.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCantidad.ValidText = "#0.00"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(8, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(168, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Cantidad"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.Location = New System.Drawing.Point(440, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Costo"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(706, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 75
        Me.Label23.Text = "Impuesto"
        '
        'TxtImpuesto_Porcentaje
        '
        Me.TxtImpuesto_Porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtImpuesto_Porcentaje.FieldReference = Nothing
        Me.TxtImpuesto_Porcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto_Porcentaje.ForeColor = System.Drawing.Color.Blue
        Me.TxtImpuesto_Porcentaje.Location = New System.Drawing.Point(827, 32)
        Me.TxtImpuesto_Porcentaje.MaskEdit = ""
        Me.TxtImpuesto_Porcentaje.Name = "TxtImpuesto_Porcentaje"
        Me.TxtImpuesto_Porcentaje.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtImpuesto_Porcentaje.Required = True
        Me.TxtImpuesto_Porcentaje.ShowErrorIcon = False
        Me.TxtImpuesto_Porcentaje.Size = New System.Drawing.Size(42, 13)
        Me.TxtImpuesto_Porcentaje.TabIndex = 11
        Me.TxtImpuesto_Porcentaje.Text = "0.00"
        Me.TxtImpuesto_Porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtImpuesto_Porcentaje.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtImpuesto_Porcentaje.ValidText = "#0"
        '
        'Descuento_Porcentaje_Detalle
        '
        Me.Descuento_Porcentaje_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Descuento_Porcentaje_Detalle.FieldReference = Nothing
        Me.Descuento_Porcentaje_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento_Porcentaje_Detalle.ForeColor = System.Drawing.Color.Blue
        Me.Descuento_Porcentaje_Detalle.Location = New System.Drawing.Point(592, 31)
        Me.Descuento_Porcentaje_Detalle.MaskEdit = ""
        Me.Descuento_Porcentaje_Detalle.Name = "Descuento_Porcentaje_Detalle"
        Me.Descuento_Porcentaje_Detalle.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.Descuento_Porcentaje_Detalle.Required = True
        Me.Descuento_Porcentaje_Detalle.ShowErrorIcon = False
        Me.Descuento_Porcentaje_Detalle.Size = New System.Drawing.Size(42, 13)
        Me.Descuento_Porcentaje_Detalle.TabIndex = 8
        Me.Descuento_Porcentaje_Detalle.Text = "0.00"
        Me.Descuento_Porcentaje_Detalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Descuento_Porcentaje_Detalle.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.Descuento_Porcentaje_Detalle.ValidText = "#0"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.Location = New System.Drawing.Point(536, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Desc."
        '
        'TxtTotalCompra
        '
        Me.TxtTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotalCompra.Enabled = False
        Me.TxtTotalCompra.FieldReference = Nothing
        Me.TxtTotalCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCompra.ForeColor = System.Drawing.Color.Blue
        Me.TxtTotalCompra.Location = New System.Drawing.Point(886, 46)
        Me.TxtTotalCompra.MaskEdit = ""
        Me.TxtTotalCompra.Name = "TxtTotalCompra"
        Me.TxtTotalCompra.ReadOnly = True
        Me.TxtTotalCompra.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtTotalCompra.Required = False
        Me.TxtTotalCompra.ShowErrorIcon = False
        Me.TxtTotalCompra.Size = New System.Drawing.Size(109, 13)
        Me.TxtTotalCompra.TabIndex = 12
        Me.TxtTotalCompra.Text = "0.00"
        Me.TxtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalCompra.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtTotalCompra.ValidText = "#0"
        '
        'TxtCosto
        '
        Me.TxtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCosto.Enabled = False
        Me.TxtCosto.FieldReference = Nothing
        Me.TxtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCosto.ForeColor = System.Drawing.Color.Blue
        Me.TxtCosto.Location = New System.Drawing.Point(440, 46)
        Me.TxtCosto.MaskEdit = ""
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.ReadOnly = True
        Me.TxtCosto.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCosto.Required = True
        Me.TxtCosto.ShowErrorIcon = False
        Me.TxtCosto.Size = New System.Drawing.Size(92, 13)
        Me.TxtCosto.TabIndex = 7
        Me.TxtCosto.Text = "0.00"
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCosto.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCosto.ValidText = "#0.00"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(886, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 13)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Total de Compra"
        '
        'btnLote
        '
        Me.btnLote.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLote.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnLote.Location = New System.Drawing.Point(1001, 27)
        Me.btnLote.Name = "btnLote"
        Me.btnLote.Size = New System.Drawing.Size(50, 20)
        Me.btnLote.TabIndex = 13
        Me.btnLote.Text = "Lote"
        Me.btnLote.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label43.Location = New System.Drawing.Point(771, 32)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(59, 13)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "Imp."
        '
        'TxtOtros
        '
        Me.TxtOtros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOtros.FieldReference = Nothing
        Me.TxtOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOtros.ForeColor = System.Drawing.Color.Blue
        Me.TxtOtros.Location = New System.Drawing.Point(352, 48)
        Me.TxtOtros.MaskEdit = ""
        Me.TxtOtros.Name = "TxtOtros"
        Me.TxtOtros.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtOtros.Required = True
        Me.TxtOtros.ShowErrorIcon = True
        Me.TxtOtros.Size = New System.Drawing.Size(84, 13)
        Me.TxtOtros.TabIndex = 5
        Me.TxtOtros.Text = "0.00"
        Me.TxtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtOtros.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtOtros.ValidText = "#0.00"
        '
        'TxtFlete
        '
        Me.TxtFlete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFlete.FieldReference = Nothing
        Me.TxtFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFlete.ForeColor = System.Drawing.Color.Blue
        Me.TxtFlete.Location = New System.Drawing.Point(264, 48)
        Me.TxtFlete.MaskEdit = ""
        Me.TxtFlete.Name = "TxtFlete"
        Me.TxtFlete.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtFlete.Required = True
        Me.TxtFlete.ShowErrorIcon = True
        Me.TxtFlete.Size = New System.Drawing.Size(84, 13)
        Me.TxtFlete.TabIndex = 4
        Me.TxtFlete.Text = "0.00"
        Me.TxtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtFlete.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtFlete.ValidText = "#0.00"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(352, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 12)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Otros"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtBase
        '
        Me.TxtBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBase.FieldReference = Nothing
        Me.TxtBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBase.ForeColor = System.Drawing.Color.Blue
        Me.TxtBase.Location = New System.Drawing.Point(184, 46)
        Me.TxtBase.MaskEdit = ""
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtBase.Required = True
        Me.TxtBase.ShowErrorIcon = True
        Me.TxtBase.Size = New System.Drawing.Size(76, 13)
        Me.TxtBase.TabIndex = 3
        Me.TxtBase.Text = "0.00"
        Me.TxtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtBase.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtBase.ValidText = "#0.00"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(264, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 12)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Fletes"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(184, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 12)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Base"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CbNumero
        '
        Me.CbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNumero.Location = New System.Drawing.Point(467, 224)
        Me.CbNumero.Name = "CbNumero"
        Me.CbNumero.Size = New System.Drawing.Size(88, 23)
        Me.CbNumero.TabIndex = 193
        Me.CbNumero.Visible = False
        '
        'LNumero
        '
        Me.LNumero.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumero.ForeColor = System.Drawing.Color.White
        Me.LNumero.Location = New System.Drawing.Point(91, 232)
        Me.LNumero.Name = "LNumero"
        Me.LNumero.Size = New System.Drawing.Size(76, 12)
        Me.LNumero.TabIndex = 88
        Me.LNumero.Text = "Número"
        Me.LNumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LNumero.Visible = False
        '
        'TbNumero
        '
        Me.TbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNumero.Location = New System.Drawing.Point(179, 232)
        Me.TbNumero.Name = "TbNumero"
        Me.TbNumero.Size = New System.Drawing.Size(82, 14)
        Me.TbNumero.TabIndex = 87
        Me.TbNumero.Visible = False
        '
        'LVencimiento
        '
        Me.LVencimiento.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVencimiento.ForeColor = System.Drawing.Color.White
        Me.LVencimiento.Location = New System.Drawing.Point(275, 232)
        Me.LVencimiento.Name = "LVencimiento"
        Me.LVencimiento.Size = New System.Drawing.Size(84, 12)
        Me.LVencimiento.TabIndex = 86
        Me.LVencimiento.Text = "Vencimiento"
        Me.LVencimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LVencimiento.Visible = False
        '
        'DTPVencimiento
        '
        Me.DTPVencimiento.Enabled = False
        Me.DTPVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVencimiento.Location = New System.Drawing.Point(363, 224)
        Me.DTPVencimiento.Name = "DTPVencimiento"
        Me.DTPVencimiento.Size = New System.Drawing.Size(94, 21)
        Me.DTPVencimiento.TabIndex = 85
        Me.DTPVencimiento.Value = New Date(2008, 9, 30, 0, 0, 0, 0)
        Me.DTPVencimiento.Visible = False
        '
        'LOpcion
        '
        Me.LOpcion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOpcion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LOpcion.Location = New System.Drawing.Point(11, 232)
        Me.LOpcion.Name = "LOpcion"
        Me.LOpcion.Size = New System.Drawing.Size(76, 13)
        Me.LOpcion.TabIndex = 84
        Me.LOpcion.Text = "Opcion"
        Me.LOpcion.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(616, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 14)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Monto Factura"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.CK_impuesto)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txtmontofact)
        Me.GroupBox7.Controls.Add(Me.txtimpuesto)
        Me.GroupBox7.Controls.Add(Me.txtdescuento)
        Me.GroupBox7.Controls.Add(Me.TxtSubExc)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.txtsubgra)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox7.Location = New System.Drawing.Point(310, 344)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(752, 53)
        Me.GroupBox7.TabIndex = 71
        Me.GroupBox7.TabStop = False
        '
        'CK_impuesto
        '
        Me.CK_impuesto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetCompras, "compras.CambioImpuesto", True))
        Me.CK_impuesto.EditValue = False
        Me.CK_impuesto.Location = New System.Drawing.Point(480, 0)
        Me.CK_impuesto.Name = "CK_impuesto"
        '
        '
        '
        Me.CK_impuesto.Properties.Caption = "Cambiar Imp."
        Me.CK_impuesto.Properties.Enabled = False
        Me.CK_impuesto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.RoyalBlue, System.Drawing.Color.White)
        Me.CK_impuesto.Size = New System.Drawing.Size(96, 19)
        Me.CK_impuesto.TabIndex = 81
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(752, 15)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Totales de Compra"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(316, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 14)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Descuento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(480, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 14)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Impuesto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(10, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 14)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "SubTotal Exc."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtmontofact
        '
        Me.txtmontofact.EditValue = "0.00"
        Me.txtmontofact.Location = New System.Drawing.Point(614, 29)
        Me.txtmontofact.Name = "txtmontofact"
        '
        '
        '
        Me.txtmontofact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtmontofact.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtmontofact.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmontofact.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtmontofact.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmontofact.Properties.ReadOnly = True
        Me.txtmontofact.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtmontofact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmontofact.Size = New System.Drawing.Size(135, 20)
        Me.txtmontofact.TabIndex = 75
        '
        'txtimpuesto
        '
        Me.txtimpuesto.EditValue = "0.00"
        Me.txtimpuesto.Location = New System.Drawing.Point(481, 29)
        Me.txtimpuesto.Name = "txtimpuesto"
        '
        '
        '
        Me.txtimpuesto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtimpuesto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtimpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtimpuesto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtimpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtimpuesto.Properties.ReadOnly = True
        Me.txtimpuesto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtimpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtimpuesto.Size = New System.Drawing.Size(124, 20)
        Me.txtimpuesto.TabIndex = 73
        '
        'txtdescuento
        '
        Me.txtdescuento.EditValue = "0.00"
        Me.txtdescuento.Location = New System.Drawing.Point(316, 29)
        Me.txtdescuento.Name = "txtdescuento"
        '
        '
        '
        Me.txtdescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtdescuento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtdescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtdescuento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtdescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtdescuento.Properties.ReadOnly = True
        Me.txtdescuento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtdescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtdescuento.Size = New System.Drawing.Size(144, 20)
        Me.txtdescuento.TabIndex = 72
        '
        'TxtSubExc
        '
        Me.TxtSubExc.EditValue = "0.00"
        Me.TxtSubExc.Location = New System.Drawing.Point(10, 29)
        Me.TxtSubExc.Name = "TxtSubExc"
        '
        '
        '
        Me.TxtSubExc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubExc.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubExc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubExc.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubExc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubExc.Properties.ReadOnly = True
        Me.TxtSubExc.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtSubExc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSubExc.Size = New System.Drawing.Size(134, 20)
        Me.TxtSubExc.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(164, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 14)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "SubTotal Gra."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtsubgra
        '
        Me.txtsubgra.EditValue = "0.00"
        Me.txtsubgra.Location = New System.Drawing.Point(163, 29)
        Me.txtsubgra.Name = "txtsubgra"
        '
        '
        '
        Me.txtsubgra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtsubgra.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtsubgra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtsubgra.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtsubgra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtsubgra.Properties.ReadOnly = True
        Me.txtsubgra.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtsubgra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsubgra.Size = New System.Drawing.Size(135, 20)
        Me.txtsubgra.TabIndex = 73
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCompras, "Moneda.Simbolo", True))
        Me.TextBox2.EditValue = ""
        Me.TextBox2.Location = New System.Drawing.Point(32, 296)
        Me.TextBox2.Name = "TextBox2"
        '
        '
        '
        Me.TextBox2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextBox2.Properties.ReadOnly = True
        Me.TextBox2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ActiveCaption)
        Me.TextBox2.Size = New System.Drawing.Size(16, 24)
        Me.TextBox2.TabIndex = 106
        Me.TextBox2.Visible = False
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(137, 0)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(176, 13)
        Me.TxtNombreUsuario.TabIndex = 2
        '
        'ComboBoxProvedor
        '
        Me.ComboBoxProvedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxProvedor.DataSource = Me.DataSetCompras
        Me.ComboBoxProvedor.DisplayMember = "Proveedores.Nombre"
        Me.ComboBoxProvedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxProvedor.Enabled = False
        Me.ComboBoxProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProvedor.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxProvedor.ItemHeight = 13
        Me.ComboBoxProvedor.Location = New System.Drawing.Point(56, 49)
        Me.ComboBoxProvedor.Name = "ComboBoxProvedor"
        Me.ComboBoxProvedor.Size = New System.Drawing.Size(420, 20)
        Me.ComboBoxProvedor.TabIndex = 2
        Me.ComboBoxProvedor.ValueMember = "Proveedores.CodigoProv"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(210, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Orden de Compra"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Usuario->"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TxtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtClave)
        Me.Panel1.Location = New System.Drawing.Point(728, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 15)
        Me.Panel1.TabIndex = 0
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Blue
        Me.txtClave.Location = New System.Drawing.Point(78, 0)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(59, 13)
        Me.txtClave.TabIndex = 0
        '
        'AdapterCompras
        '
        Me.AdapterCompras.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterCompras.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterCompras.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterCompras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "compras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("TotalFactura", "TotalFactura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("FechaIngreso", "FechaIngreso"), New System.Data.Common.DataColumnMapping("MotivoGasto", "MotivoGasto"), New System.Data.Common.DataColumnMapping("Compra", "Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Consignacion", "Consignacion"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("ContaInve", "ContaInve"), New System.Data.Common.DataColumnMapping("AsientoInve", "AsientoInve"), New System.Data.Common.DataColumnMapping("TipoCompra", "TipoCompra"), New System.Data.Common.DataColumnMapping("CedulaUsuario", "CedulaUsuario"), New System.Data.Common.DataColumnMapping("Cod_MonedaCompra", "Cod_MonedaCompra"), New System.Data.Common.DataColumnMapping("Id_Compra", "Id_Compra"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado"), New System.Data.Common.DataColumnMapping("CambioImpuesto", "CambioImpuesto"), New System.Data.Common.DataColumnMapping("Taller", "Taller"), New System.Data.Common.DataColumnMapping("Mascotas", "Mascotas"), New System.Data.Common.DataColumnMapping("num_orden", "num_orden")})})
        Me.AdapterCompras.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AsientoInve", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambioImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambioImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CedulaUsuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CedulaUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Compra", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Consignacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consignacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContaInve", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContaInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MotivoGasto", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MotivoGasto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCompra", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_num_orden", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "num_orden", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "Data Source=.;Initial Catalog=SeePos;Integrated Security=True"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@TotalFactura", System.Data.SqlDbType.Float, 8, "TotalFactura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 8, "Vence"), New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"), New System.Data.SqlClient.SqlParameter("@MotivoGasto", System.Data.SqlDbType.VarChar, 255, "MotivoGasto"), New System.Data.SqlClient.SqlParameter("@Compra", System.Data.SqlDbType.Bit, 1, "Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Consignacion", System.Data.SqlDbType.Bit, 1, "Consignacion"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.Float, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@ContaInve", System.Data.SqlDbType.Bit, 1, "ContaInve"), New System.Data.SqlClient.SqlParameter("@AsientoInve", System.Data.SqlDbType.Float, 8, "AsientoInve"), New System.Data.SqlClient.SqlParameter("@TipoCompra", System.Data.SqlDbType.[Char], 3, "TipoCompra"), New System.Data.SqlClient.SqlParameter("@CedulaUsuario", System.Data.SqlDbType.VarChar, 75, "CedulaUsuario"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, "Cod_MonedaCompra"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@CambioImpuesto", System.Data.SqlDbType.Float, 8, "CambioImpuesto"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"), New System.Data.SqlClient.SqlParameter("@num_orden", System.Data.SqlDbType.Float, 8, "num_orden"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@TotalFactura", System.Data.SqlDbType.Float, 8, "TotalFactura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 8, "Vence"), New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"), New System.Data.SqlClient.SqlParameter("@MotivoGasto", System.Data.SqlDbType.VarChar, 255, "MotivoGasto"), New System.Data.SqlClient.SqlParameter("@Compra", System.Data.SqlDbType.Bit, 1, "Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Consignacion", System.Data.SqlDbType.Bit, 1, "Consignacion"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.Float, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@ContaInve", System.Data.SqlDbType.Bit, 1, "ContaInve"), New System.Data.SqlClient.SqlParameter("@AsientoInve", System.Data.SqlDbType.Float, 8, "AsientoInve"), New System.Data.SqlClient.SqlParameter("@TipoCompra", System.Data.SqlDbType.VarChar, 3, "TipoCompra"), New System.Data.SqlClient.SqlParameter("@CedulaUsuario", System.Data.SqlDbType.VarChar, 75, "CedulaUsuario"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, "Cod_MonedaCompra"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@CambioImpuesto", System.Data.SqlDbType.Float, 8, "CambioImpuesto"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"), New System.Data.SqlClient.SqlParameter("@num_orden", System.Data.SqlDbType.Float, 8, "num_orden"), New System.Data.SqlClient.SqlParameter("@Original_Id_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AsientoInve", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambioImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambioImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CedulaUsuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CedulaUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Compra", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Consignacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consignacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContaInve", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContaInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MotivoGasto", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MotivoGasto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCompra", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_num_orden", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "num_orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Compra", System.Data.SqlDbType.BigInt, 8, "Id_Compra")})
        '
        'AdapterProveedores
        '
        Me.AdapterProveedores.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterProveedores.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Utilidad_Fija", "Utilidad_Fija"), New System.Data.Common.DataColumnMapping("Utilidad_Inventario", "Utilidad_Inventario"), New System.Data.Common.DataColumnMapping("Plazo", "Plazo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodigoProv, Nombre, Utilidad_Fija, Utilidad_Inventario, Plazo FROM Proveed" & _
    "ores"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'AdapterArticulos_Comprados
        '
        Me.AdapterArticulos_Comprados.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterArticulos_Comprados.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterArticulos_Comprados.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterArticulos_Comprados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos_comprados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_ArticuloComprados", "Id_ArticuloComprados"), New System.Data.Common.DataColumnMapping("IdCompra", "IdCompra"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Base", "Base"), New System.Data.Common.DataColumnMapping("Monto_Flete", "Monto_Flete"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Gravado", "Gravado"), New System.Data.Common.DataColumnMapping("Exento", "Exento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Descuento_P", "Descuento_P"), New System.Data.Common.DataColumnMapping("Impuesto_P", "Impuesto_P"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("Precio_B", "Precio_B"), New System.Data.Common.DataColumnMapping("Precio_C", "Precio_C"), New System.Data.Common.DataColumnMapping("Precio_D", "Precio_D"), New System.Data.Common.DataColumnMapping("CodMonedaVenta", "CodMonedaVenta"), New System.Data.Common.DataColumnMapping("NuevoCostoBase", "NuevoCostoBase"), New System.Data.Common.DataColumnMapping("Lote", "Lote"), New System.Data.Common.DataColumnMapping("Regalias", "Regalias"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("Bonificado", "Bonificado"), New System.Data.Common.DataColumnMapping("CodigoBonificado", "CodigoBonificado"), New System.Data.Common.DataColumnMapping("CantidadBonificado", "CantidadBonificado"), New System.Data.Common.DataColumnMapping("CostoBonificado", "CostoBonificado"), New System.Data.Common.DataColumnMapping("SubTotalBonificado", "SubTotalBonificado"), New System.Data.Common.DataColumnMapping("CodArticuloBonificacion", "CodArticuloBonificacion")})})
        Me.AdapterArticulos_Comprados.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [articulos_comprados] WHERE (([Id_ArticuloComprados] = @Original_Id_A" & _
    "rticuloComprados))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdCompra", System.Data.SqlDbType.BigInt, 0, "IdCompra"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Base", System.Data.SqlDbType.Float, 0, "Base"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 0, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 0, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 0, "Costo"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 0, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 0, "Exento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Descuento_P", System.Data.SqlDbType.Float, 0, "Descuento_P"), New System.Data.SqlClient.SqlParameter("@Impuesto_P", System.Data.SqlDbType.Float, 0, "Impuesto_P"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 0, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 0, "Precio_A"), New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 0, "Precio_B"), New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 0, "Precio_C"), New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 0, "Precio_D"), New System.Data.SqlClient.SqlParameter("@CodMonedaVenta", System.Data.SqlDbType.Int, 0, "CodMonedaVenta"), New System.Data.SqlClient.SqlParameter("@NuevoCostoBase", System.Data.SqlDbType.Float, 0, "NuevoCostoBase"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 0, "Lote"), New System.Data.SqlClient.SqlParameter("@Regalias", System.Data.SqlDbType.Float, 0, "Regalias"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 0, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@Bonificado", System.Data.SqlDbType.Bit, 0, "Bonificado"), New System.Data.SqlClient.SqlParameter("@CodigoBonificado", System.Data.SqlDbType.BigInt, 0, "CodigoBonificado"), New System.Data.SqlClient.SqlParameter("@CantidadBonificado", System.Data.SqlDbType.Float, 0, "CantidadBonificado"), New System.Data.SqlClient.SqlParameter("@CostoBonificado", System.Data.SqlDbType.Float, 0, "CostoBonificado"), New System.Data.SqlClient.SqlParameter("@SubTotalBonificado", System.Data.SqlDbType.Float, 0, "SubTotalBonificado"), New System.Data.SqlClient.SqlParameter("@CodArticuloBonificacion", System.Data.SqlDbType.VarChar, 0, "CodArticuloBonificacion"), New System.Data.SqlClient.SqlParameter("@CodCabys", System.Data.SqlDbType.VarChar, 0, "CodCabys")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdCompra", System.Data.SqlDbType.BigInt, 8, "IdCompra"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Base", System.Data.SqlDbType.Float, 8, "Base"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Descuento_P", System.Data.SqlDbType.Float, 8, "Descuento_P"), New System.Data.SqlClient.SqlParameter("@Impuesto_P", System.Data.SqlDbType.Float, 8, "Impuesto_P"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"), New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"), New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"), New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"), New System.Data.SqlClient.SqlParameter("@CodMonedaVenta", System.Data.SqlDbType.Int, 4, "CodMonedaVenta"), New System.Data.SqlClient.SqlParameter("@NuevoCostoBase", System.Data.SqlDbType.Float, 8, "NuevoCostoBase"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote"), New System.Data.SqlClient.SqlParameter("@Regalias", System.Data.SqlDbType.Float, 8, "Regalias"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@Bonificado", System.Data.SqlDbType.Bit, 1, "Bonificado"), New System.Data.SqlClient.SqlParameter("@CodigoBonificado", System.Data.SqlDbType.BigInt, 8, "CodigoBonificado"), New System.Data.SqlClient.SqlParameter("@CantidadBonificado", System.Data.SqlDbType.Float, 8, "CantidadBonificado"), New System.Data.SqlClient.SqlParameter("@CostoBonificado", System.Data.SqlDbType.Float, 8, "CostoBonificado"), New System.Data.SqlClient.SqlParameter("@SubTotalBonificado", System.Data.SqlDbType.Float, 8, "SubTotalBonificado"), New System.Data.SqlClient.SqlParameter("@CodArticuloBonificacion", System.Data.SqlDbType.VarChar, 250, "CodArticuloBonificacion"), New System.Data.SqlClient.SqlParameter("@CodCabys", System.Data.SqlDbType.NVarChar, 255, "CodCabys"), New System.Data.SqlClient.SqlParameter("@Original_Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.ButtonAgregarDetalle)
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Location = New System.Drawing.Point(-309, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 208)
        Me.Panel2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio de Venta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_D)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_C)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_D)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_C)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_B)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_A)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_B)
        Me.GroupBox2.Controls.Add(Me.TextBoxValorMonedaEnVenta)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.CBMonedaVenta)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_C)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_D)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_B)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_A)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_A)
        Me.GroupBox2.Controls.Add(Me.TxtCostoReal)
        Me.GroupBox2.Controls.Add(Me.TxtBaseEquivalente)
        Me.GroupBox2.Controls.Add(Me.TxtFleteEquivalente)
        Me.GroupBox2.Controls.Add(Me.TxtOtrosCargosEquivalente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 184)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precio de Venta"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(13, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Nuevo Costo"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(88, 39)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 13)
        Me.Label48.TabIndex = 103
        Me.Label48.Text = "> Reg."
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPrecioVenta_IV_D
        '
        Me.TxtPrecioVenta_IV_D.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_D.Location = New System.Drawing.Point(188, 132)
        Me.TxtPrecioVenta_IV_D.Name = "TxtPrecioVenta_IV_D"
        '
        '
        '
        Me.TxtPrecioVenta_IV_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_D.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_D.TabIndex = 12
        '
        'TxtPrecioVenta_IV_C
        '
        Me.TxtPrecioVenta_IV_C.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_C.Location = New System.Drawing.Point(188, 114)
        Me.TxtPrecioVenta_IV_C.Name = "TxtPrecioVenta_IV_C"
        '
        '
        '
        Me.TxtPrecioVenta_IV_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_C.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_C.TabIndex = 11
        '
        'TxtPrecioVenta_D
        '
        Me.TxtPrecioVenta_D.EditValue = "0.00"
        Me.TxtPrecioVenta_D.Location = New System.Drawing.Point(85, 132)
        Me.TxtPrecioVenta_D.Name = "TxtPrecioVenta_D"
        '
        '
        '
        Me.TxtPrecioVenta_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_D.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_D.TabIndex = 8
        '
        'TxtPrecioVenta_C
        '
        Me.TxtPrecioVenta_C.EditValue = "0.00"
        Me.TxtPrecioVenta_C.Location = New System.Drawing.Point(85, 114)
        Me.TxtPrecioVenta_C.Name = "TxtPrecioVenta_C"
        '
        '
        '
        Me.TxtPrecioVenta_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_C.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_C.TabIndex = 7
        '
        'TxtPrecioVenta_IV_B
        '
        Me.TxtPrecioVenta_IV_B.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_B.Location = New System.Drawing.Point(188, 95)
        Me.TxtPrecioVenta_IV_B.Name = "TxtPrecioVenta_IV_B"
        '
        '
        '
        Me.TxtPrecioVenta_IV_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_B.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_B.TabIndex = 10
        '
        'TxtPrecioVenta_IV_A
        '
        Me.TxtPrecioVenta_IV_A.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_A.Location = New System.Drawing.Point(188, 76)
        Me.TxtPrecioVenta_IV_A.Name = "TxtPrecioVenta_IV_A"
        '
        '
        '
        Me.TxtPrecioVenta_IV_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_A.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_A.TabIndex = 9
        '
        'TxtPrecioVenta_B
        '
        Me.TxtPrecioVenta_B.EditValue = "0.00"
        Me.TxtPrecioVenta_B.Location = New System.Drawing.Point(85, 95)
        Me.TxtPrecioVenta_B.Name = "TxtPrecioVenta_B"
        '
        '
        '
        Me.TxtPrecioVenta_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_B.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_B.TabIndex = 6
        '
        'TextBoxValorMonedaEnVenta
        '
        Me.TextBoxValorMonedaEnVenta.AcceptsTab = True
        Me.TextBoxValorMonedaEnVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorMonedaEnVenta.Enabled = False
        Me.TextBoxValorMonedaEnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxValorMonedaEnVenta.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxValorMonedaEnVenta.Location = New System.Drawing.Point(185, 19)
        Me.TextBoxValorMonedaEnVenta.Name = "TextBoxValorMonedaEnVenta"
        Me.TextBoxValorMonedaEnVenta.ReadOnly = True
        Me.TextBoxValorMonedaEnVenta.Size = New System.Drawing.Size(84, 13)
        Me.TextBoxValorMonedaEnVenta.TabIndex = 75
        Me.TextBoxValorMonedaEnVenta.Text = "0.00"
        Me.TextBoxValorMonedaEnVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(8, 59)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 13)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Utilidad"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(186, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Precio + I.V."
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(85, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 13)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "Precio Venta"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.Blue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(171, 137)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 48
        Me.Label30.Text = "+"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(171, 118)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 12)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "+"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(171, 98)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 12)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "+"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(64, 78)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 12)
        Me.Label33.TabIndex = 40
        Me.Label33.Text = "A"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(64, 116)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 13)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "C"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(64, 96)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 13)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "B"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(64, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 13)
        Me.Label36.TabIndex = 44
        Me.Label36.Text = "D"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(171, 80)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 12)
        Me.Label37.TabIndex = 45
        Me.Label37.Text = "+"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(8, 19)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 15)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Moneda"
        '
        'CBMonedaVenta
        '
        Me.CBMonedaVenta.DataSource = Me.DataSetCompras
        Me.CBMonedaVenta.DisplayMember = "Monedas.MonedaNombre"
        Me.CBMonedaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMonedaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMonedaVenta.ForeColor = System.Drawing.Color.Blue
        Me.CBMonedaVenta.ItemHeight = 13
        Me.CBMonedaVenta.Location = New System.Drawing.Point(84, 15)
        Me.CBMonedaVenta.Name = "CBMonedaVenta"
        Me.CBMonedaVenta.Size = New System.Drawing.Size(84, 21)
        Me.CBMonedaVenta.TabIndex = 0
        Me.CBMonedaVenta.ValueMember = "Monedas.CodMoneda"
        '
        'TxtUtilidad_C
        '
        Me.TxtUtilidad_C.EditValue = "0.00"
        Me.TxtUtilidad_C.Location = New System.Drawing.Point(8, 114)
        Me.TxtUtilidad_C.Name = "TxtUtilidad_C"
        '
        '
        '
        Me.TxtUtilidad_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_C.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_C.TabIndex = 3
        '
        'TxtUtilidad_D
        '
        Me.TxtUtilidad_D.EditValue = "0.00"
        Me.TxtUtilidad_D.Location = New System.Drawing.Point(8, 132)
        Me.TxtUtilidad_D.Name = "TxtUtilidad_D"
        '
        '
        '
        Me.TxtUtilidad_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_D.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_D.TabIndex = 4
        '
        'TxtUtilidad_B
        '
        Me.TxtUtilidad_B.EditValue = "0.00"
        Me.TxtUtilidad_B.Location = New System.Drawing.Point(8, 95)
        Me.TxtUtilidad_B.Name = "TxtUtilidad_B"
        '
        '
        '
        Me.TxtUtilidad_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_B.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_B.TabIndex = 2
        '
        'TxtUtilidad_A
        '
        Me.TxtUtilidad_A.EditValue = "0.00"
        Me.TxtUtilidad_A.Location = New System.Drawing.Point(8, 76)
        Me.TxtUtilidad_A.Name = "TxtUtilidad_A"
        '
        '
        '
        Me.TxtUtilidad_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_A.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_A.TabIndex = 1
        '
        'TxtPrecioVenta_A
        '
        Me.TxtPrecioVenta_A.EditValue = "0.00"
        Me.TxtPrecioVenta_A.Location = New System.Drawing.Point(85, 76)
        Me.TxtPrecioVenta_A.Name = "TxtPrecioVenta_A"
        '
        '
        '
        Me.TxtPrecioVenta_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_A.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_A.TabIndex = 5
        '
        'TxtCostoReal
        '
        Me.TxtCostoReal.BackColor = System.Drawing.Color.White
        Me.TxtCostoReal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCostoReal.Enabled = False
        Me.TxtCostoReal.FieldReference = Nothing
        Me.TxtCostoReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoReal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCostoReal.Location = New System.Drawing.Point(185, 39)
        Me.TxtCostoReal.MaskEdit = ""
        Me.TxtCostoReal.Name = "TxtCostoReal"
        Me.TxtCostoReal.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCostoReal.Required = False
        Me.TxtCostoReal.ShowErrorIcon = False
        Me.TxtCostoReal.Size = New System.Drawing.Size(84, 13)
        Me.TxtCostoReal.TabIndex = 101
        Me.TxtCostoReal.Text = "0.00"
        Me.TxtCostoReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCostoReal.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCostoReal.ValidText = "#0"
        '
        'TxtBaseEquivalente
        '
        Me.TxtBaseEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBaseEquivalente.Enabled = False
        Me.TxtBaseEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBaseEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtBaseEquivalente.Location = New System.Drawing.Point(8, 160)
        Me.TxtBaseEquivalente.Name = "TxtBaseEquivalente"
        Me.TxtBaseEquivalente.ReadOnly = True
        Me.TxtBaseEquivalente.Size = New System.Drawing.Size(72, 13)
        Me.TxtBaseEquivalente.TabIndex = 101
        Me.TxtBaseEquivalente.Text = "0.00"
        Me.TxtBaseEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFleteEquivalente
        '
        Me.TxtFleteEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFleteEquivalente.Enabled = False
        Me.TxtFleteEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtFleteEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtFleteEquivalente.Location = New System.Drawing.Point(96, 160)
        Me.TxtFleteEquivalente.Name = "TxtFleteEquivalente"
        Me.TxtFleteEquivalente.ReadOnly = True
        Me.TxtFleteEquivalente.Size = New System.Drawing.Size(72, 13)
        Me.TxtFleteEquivalente.TabIndex = 102
        Me.TxtFleteEquivalente.Text = "0.00"
        Me.TxtFleteEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOtrosCargosEquivalente
        '
        Me.TxtOtrosCargosEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOtrosCargosEquivalente.Enabled = False
        Me.TxtOtrosCargosEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtOtrosCargosEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtOtrosCargosEquivalente.Location = New System.Drawing.Point(176, 160)
        Me.TxtOtrosCargosEquivalente.Name = "TxtOtrosCargosEquivalente"
        Me.TxtOtrosCargosEquivalente.ReadOnly = True
        Me.TxtOtrosCargosEquivalente.Size = New System.Drawing.Size(89, 13)
        Me.TxtOtrosCargosEquivalente.TabIndex = 103
        Me.TxtOtrosCargosEquivalente.Text = "0.00"
        Me.TxtOtrosCargosEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonAgregarDetalle
        '
        Me.ButtonAgregarDetalle.Location = New System.Drawing.Point(46, 184)
        Me.ButtonAgregarDetalle.Name = "ButtonAgregarDetalle"
        Me.ButtonAgregarDetalle.Size = New System.Drawing.Size(84, 20)
        Me.ButtonAgregarDetalle.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonAgregarDetalle.TabIndex = 1
        Me.ButtonAgregarDetalle.Text = "Agregar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(177, 183)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(84, 20)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Cancelar"
        '
        'CheckBoxUtilidadFija
        '
        Me.CheckBoxUtilidadFija.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxUtilidadFija.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxUtilidadFija.Enabled = False
        Me.CheckBoxUtilidadFija.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxUtilidadFija.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxUtilidadFija.Location = New System.Drawing.Point(154, 457)
        Me.CheckBoxUtilidadFija.Name = "CheckBoxUtilidadFija"
        Me.CheckBoxUtilidadFija.Size = New System.Drawing.Size(96, 14)
        Me.CheckBoxUtilidadFija.TabIndex = 2
        Me.CheckBoxUtilidadFija.Text = "Utilidad Fija"
        Me.CheckBoxUtilidadFija.UseVisualStyleBackColor = False
        '
        'TxtUtilidadFija
        '
        Me.TxtUtilidadFija.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtUtilidadFija.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUtilidadFija.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUtilidadFija.FieldReference = Nothing
        Me.TxtUtilidadFija.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUtilidadFija.ForeColor = System.Drawing.Color.Blue
        Me.TxtUtilidadFija.Location = New System.Drawing.Point(259, 458)
        Me.TxtUtilidadFija.MaskEdit = ""
        Me.TxtUtilidadFija.Name = "TxtUtilidadFija"
        Me.TxtUtilidadFija.ReadOnly = True
        Me.TxtUtilidadFija.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtUtilidadFija.Required = False
        Me.TxtUtilidadFija.ShowErrorIcon = False
        Me.TxtUtilidadFija.Size = New System.Drawing.Size(84, 13)
        Me.TxtUtilidadFija.TabIndex = 3
        Me.TxtUtilidadFija.Text = "0.00"
        Me.TxtUtilidadFija.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtUtilidadFija.ValidText = "#0"
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand4
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        CodMoneda, MonedaNombre, TCCompra AS ValorCompra, TCCompra AS Valor" & _
    "Venta, Simbolo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Moneda"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection
        '
        'TxtGravado
        '
        Me.TxtGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtGravado.FieldReference = Nothing
        Me.TxtGravado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGravado.ForeColor = System.Drawing.Color.Blue
        Me.TxtGravado.Location = New System.Drawing.Point(88, 40)
        Me.TxtGravado.MaskEdit = ""
        Me.TxtGravado.Name = "TxtGravado"
        Me.TxtGravado.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtGravado.Required = False
        Me.TxtGravado.ShowErrorIcon = False
        Me.TxtGravado.Size = New System.Drawing.Size(96, 13)
        Me.TxtGravado.TabIndex = 83
        Me.TxtGravado.Text = "0.00"
        Me.TxtGravado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGravado.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtGravado.ValidText = "#0"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(8, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Gravado"
        '
        'TxtExento
        '
        Me.TxtExento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtExento.FieldReference = Nothing
        Me.TxtExento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExento.ForeColor = System.Drawing.Color.Blue
        Me.TxtExento.Location = New System.Drawing.Point(88, 56)
        Me.TxtExento.MaskEdit = ""
        Me.TxtExento.Name = "TxtExento"
        Me.TxtExento.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtExento.Required = False
        Me.TxtExento.ShowErrorIcon = False
        Me.TxtExento.Size = New System.Drawing.Size(96, 13)
        Me.TxtExento.TabIndex = 85
        Me.TxtExento.Text = "0.00"
        Me.TxtExento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtExento.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtExento.ValidText = "#0"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(8, 56)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 11)
        Me.Label42.TabIndex = 84
        Me.Label42.Text = "Exento"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GridControlDetalleCompra
        '
        Me.GridControlDetalleCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControlDetalleCompra.DataMember = "compras.comprasarticulos_comprados"
        Me.GridControlDetalleCompra.DataSource = Me.DataSetCompras
        '
        '
        '
        Me.GridControlDetalleCompra.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GridControlDetalleCompra.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GridControlDetalleCompra.EmbeddedNavigator.Name = ""
        Me.GridControlDetalleCompra.Location = New System.Drawing.Point(8, 211)
        Me.GridControlDetalleCompra.MainView = Me.BandedGridView1
        Me.GridControlDetalleCompra.Name = "GridControlDetalleCompra"
        Me.GridControlDetalleCompra.Size = New System.Drawing.Size(1051, 125)
        Me.GridControlDetalleCompra.TabIndex = 100
        Me.GridControlDetalleCompra.Text = "GridControl"
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colCodCabys, Me.colDescripcion, Me.colCosto, Me.colLote, Me.GridColumn1, Me.colCantidad, Me.colRegalias, Me.colGravado, Me.colExento, Me.colDescuento_P, Me.colImpuesto_P, Me.colDescuento, Me.colImpuesto, Me.colTotal})
        Me.BandedGridView1.GroupPanelText = ""
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsView.ShowBands = False
        Me.BandedGridView1.OptionsView.ShowGroupedColumns = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.OptionsView.ShowHorzLines = False
        Me.BandedGridView1.OptionsView.ShowIndicator = False
        Me.BandedGridView1.PaintStyleName = "WindowsXP"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colCodCabys)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colLote)
        Me.GridBand1.Columns.Add(Me.colCosto)
        Me.GridBand1.Columns.Add(Me.GridColumn1)
        Me.GridBand1.Columns.Add(Me.colCantidad)
        Me.GridBand1.Columns.Add(Me.colRegalias)
        Me.GridBand1.Columns.Add(Me.colGravado)
        Me.GridBand1.Columns.Add(Me.colExento)
        Me.GridBand1.Columns.Add(Me.colDescuento_P)
        Me.GridBand1.Columns.Add(Me.colImpuesto_P)
        Me.GridBand1.Columns.Add(Me.colDescuento)
        Me.GridBand1.Columns.Add(Me.colImpuesto)
        Me.GridBand1.Columns.Add(Me.colTotal)
        Me.GridBand1.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1051
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "CodArticulo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 70
        '
        'colCodCabys
        '
        Me.colCodCabys.AutoFillDown = True
        Me.colCodCabys.Caption = "Utilidad"
        Me.colCodCabys.FieldName = "Utilidad"
        Me.colCodCabys.FilterInfo = ColumnFilterInfo2
        Me.colCodCabys.Name = "colCodCabys"
        Me.colCodCabys.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodCabys.Visible = True
        Me.colCodCabys.Width = 103
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo3
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 219
        '
        'colLote
        '
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "Lote"
        Me.colLote.FilterInfo = ColumnFilterInfo4
        Me.colLote.Name = "colLote"
        Me.colLote.Width = 86
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo Compra"
        Me.colCosto.DisplayFormat.FormatString = "#,#0.00"
        Me.colCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCosto.FieldName = "Costo"
        Me.colCosto.FilterInfo = ColumnFilterInfo5
        Me.colCosto.Name = "colCosto"
        Me.colCosto.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCosto.Visible = True
        Me.colCosto.Width = 88
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nue. Base"
        Me.GridColumn1.FieldName = "NuevoCostoBase"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo6
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.Width = 91
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo7
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 55
        '
        'colRegalias
        '
        Me.colRegalias.Caption = "Regalias"
        Me.colRegalias.DisplayFormat.FormatString = "#,#0.00"
        Me.colRegalias.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRegalias.FieldName = "Regalias"
        Me.colRegalias.FilterInfo = ColumnFilterInfo8
        Me.colRegalias.Name = "colRegalias"
        Me.colRegalias.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colRegalias.Visible = True
        Me.colRegalias.Width = 60
        '
        'colGravado
        '
        Me.colGravado.Caption = "Gravado"
        Me.colGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGravado.FieldName = "Gravado"
        Me.colGravado.FilterInfo = ColumnFilterInfo9
        Me.colGravado.Name = "colGravado"
        Me.colGravado.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colGravado.SummaryItem.DisplayFormat = "#,#0.00"
        Me.colGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colGravado.Visible = True
        Me.colGravado.Width = 112
        '
        'colExento
        '
        Me.colExento.Caption = "Exento"
        Me.colExento.DisplayFormat.FormatString = "#,#0.00"
        Me.colExento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExento.FieldName = "Exento"
        Me.colExento.FilterInfo = ColumnFilterInfo10
        Me.colExento.Name = "colExento"
        Me.colExento.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colExento.Visible = True
        Me.colExento.Width = 90
        '
        'colDescuento_P
        '
        Me.colDescuento_P.Caption = "%D."
        Me.colDescuento_P.DisplayFormat.FormatString = "#,#0.00"
        Me.colDescuento_P.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuento_P.FieldName = "Descuento_P"
        Me.colDescuento_P.FilterInfo = ColumnFilterInfo11
        Me.colDescuento_P.Name = "colDescuento_P"
        Me.colDescuento_P.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescuento_P.Visible = True
        Me.colDescuento_P.Width = 32
        '
        'colImpuesto_P
        '
        Me.colImpuesto_P.Caption = "%I.V."
        Me.colImpuesto_P.DisplayFormat.FormatString = "#,#0.00"
        Me.colImpuesto_P.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImpuesto_P.FieldName = "Impuesto_P"
        Me.colImpuesto_P.FilterInfo = ColumnFilterInfo12
        Me.colImpuesto_P.Name = "colImpuesto_P"
        Me.colImpuesto_P.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colImpuesto_P.Visible = True
        Me.colImpuesto_P.Width = 36
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Desc."
        Me.colDescuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.FilterInfo = ColumnFilterInfo13
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDescuento.Width = 54
        '
        'colImpuesto
        '
        Me.colImpuesto.Caption = "Impuesto"
        Me.colImpuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colImpuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImpuesto.FieldName = "Impuesto"
        Me.colImpuesto.FilterInfo = ColumnFilterInfo14
        Me.colImpuesto.Name = "colImpuesto"
        Me.colImpuesto.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colImpuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colImpuesto.Width = 62
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.FilterInfo = ColumnFilterInfo15
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.Width = 95
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label44.Location = New System.Drawing.Point(720, 8)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 12)
        Me.Label44.TabIndex = 96
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdapterMonedaDetalle
        '
        Me.AdapterMonedaDetalle.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterMonedaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monedas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta FROM Monedas"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection
        '
        'TxtIDUsuario
        '
        Me.TxtIDUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TxtIDUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIDUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtIDUsuario.Location = New System.Drawing.Point(56, 88)
        Me.TxtIDUsuario.Name = "TxtIDUsuario"
        Me.TxtIDUsuario.ReadOnly = True
        Me.TxtIDUsuario.Size = New System.Drawing.Size(128, 13)
        Me.TxtIDUsuario.TabIndex = 98
        '
        'ValidText1
        '
        Me.ValidText1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText1.FieldReference = Nothing
        Me.ValidText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidText1.ForeColor = System.Drawing.Color.Blue
        Me.ValidText1.Location = New System.Drawing.Point(88, 72)
        Me.ValidText1.MaskEdit = ""
        Me.ValidText1.Name = "ValidText1"
        Me.ValidText1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText1.Required = False
        Me.ValidText1.ShowErrorIcon = False
        Me.ValidText1.Size = New System.Drawing.Size(96, 13)
        Me.ValidText1.TabIndex = 99
        Me.ValidText1.Text = "0.00"
        Me.ValidText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValidText1.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.ValidText1.ValidText = "#0"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(8, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(68, 13)
        Me.Label40.TabIndex = 100
        Me.Label40.Text = "Fact. Conv."
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(8, 24)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(176, 12)
        Me.Label45.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LookUpEdit_Proveedor)
        Me.GroupBox1.Controls.Add(Me.ComboBoxProvedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtTotalFactura)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(1, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 79)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'LookUpEdit_Proveedor
        '
        Me.LookUpEdit_Proveedor.Location = New System.Drawing.Point(8, 48)
        Me.LookUpEdit_Proveedor.Name = "LookUpEdit_Proveedor"
        '
        '
        '
        Me.LookUpEdit_Proveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LookUpEdit_Proveedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoProv", "CodigoProv", 100, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit_Proveedor.Properties.DataSource = Me.DataSetCompras.Proveedores
        Me.LookUpEdit_Proveedor.Properties.DisplayMember = "CodigoProv"
        Me.LookUpEdit_Proveedor.Properties.NullString = ""
        Me.LookUpEdit_Proveedor.Properties.PopupCellStyle = New DevExpress.Utils.ViewStyle("PopupCell", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                Or DevExpress.Utils.StyleOptions.UseFont) _
                Or DevExpress.Utils.StyleOptions.UseForeColor) _
                Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                Or DevExpress.Utils.StyleOptions.UseImage) _
                Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.LookUpEdit_Proveedor.Properties.PopupWidth = 500
        Me.LookUpEdit_Proveedor.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.LookUpEdit_Proveedor.Properties.ValueMember = "CodigoProv"
        Me.LookUpEdit_Proveedor.Size = New System.Drawing.Size(48, 23)
        Me.LookUpEdit_Proveedor.TabIndex = 1
        '
        'AdapterUsuarios
        '
        Me.AdapterUsuarios.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Nombre, Clave_Interna FROM Usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'TxtCostoEquivalente
        '
        Me.TxtCostoEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCostoEquivalente.Enabled = False
        Me.TxtCostoEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtCostoEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtCostoEquivalente.Location = New System.Drawing.Point(34, 324)
        Me.TxtCostoEquivalente.Name = "TxtCostoEquivalente"
        Me.TxtCostoEquivalente.ReadOnly = True
        Me.TxtCostoEquivalente.Size = New System.Drawing.Size(88, 13)
        Me.TxtCostoEquivalente.TabIndex = 104
        Me.TxtCostoEquivalente.Text = "0.00"
        Me.TxtCostoEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxValorMonedaEnCosto
        '
        Me.TextBoxValorMonedaEnCosto.AcceptsTab = True
        Me.TextBoxValorMonedaEnCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorMonedaEnCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCompras, "Moneda.ValorCompra", True))
        Me.TextBoxValorMonedaEnCosto.Enabled = False
        Me.TextBoxValorMonedaEnCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxValorMonedaEnCosto.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxValorMonedaEnCosto.Location = New System.Drawing.Point(160, 316)
        Me.TextBoxValorMonedaEnCosto.Name = "TextBoxValorMonedaEnCosto"
        Me.TextBoxValorMonedaEnCosto.ReadOnly = True
        Me.TextBoxValorMonedaEnCosto.Size = New System.Drawing.Size(84, 13)
        Me.TextBoxValorMonedaEnCosto.TabIndex = 105
        Me.TextBoxValorMonedaEnCosto.Text = "0.00"
        Me.TextBoxValorMonedaEnCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Adapter_OrdenCompra
        '
        Me.Adapter_OrdenCompra.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_OrdenCompra.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_OrdenCompra.SelectCommand = Me.SqlSelectCommand6
        Me.Adapter_OrdenCompra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ordencompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Proveedor", "Proveedor"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("contado", "contado"), New System.Data.Common.DataColumnMapping("credito", "credito"), New System.Data.Common.DataColumnMapping("diascredito", "diascredito"), New System.Data.Common.DataColumnMapping("Plazo", "Plazo"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("entregar", "entregar"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.Adapter_OrdenCompra.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"), New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"), New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"), New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"), New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden")})
        '
        'Adapter_DetalleOrdenCompra
        '
        Me.Adapter_DetalleOrdenCompra.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adapter_DetalleOrdenCompra.InsertCommand = Me.SqlInsertCommand4
        Me.Adapter_DetalleOrdenCompra.SelectCommand = Me.SqlSelectCommand8
        Me.Adapter_DetalleOrdenCompra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_ordencompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CostoUnitario", "CostoUnitario"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("TotalCompra", "TotalCompra"), New System.Data.Common.DataColumnMapping("Porc_Descuento", "Porc_Descuento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Porc_Impuesto", "Porc_Impuesto"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Monto_Flete", "Monto_Flete"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Gravado", "Gravado"), New System.Data.Common.DataColumnMapping("Exento", "Exento"), New System.Data.Common.DataColumnMapping("Vendidos", "Vendidos"), New System.Data.Common.DataColumnMapping("Exist_Actual", "Exist_Actual")})})
        Me.Adapter_DetalleOrdenCompra.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exist_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vendidos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"), New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Vendidos", System.Data.SqlDbType.Float, 8, "Vendidos"), New System.Data.SqlClient.SqlParameter("@Exist_Actual", System.Data.SqlDbType.Float, 8, "Exist_Actual")})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = resources.GetString("SqlSelectCommand8.CommandText")
        Me.SqlSelectCommand8.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"), New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Vendidos", System.Data.SqlDbType.Float, 8, "Vendidos"), New System.Data.SqlClient.SqlParameter("@Exist_Actual", System.Data.SqlDbType.Float, 8, "Exist_Actual"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exist_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vendidos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 452)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1062, 18)
        Me.StatusBar1.TabIndex = 106
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 150
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 895
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtExento)
        Me.Panel3.Controls.Add(Me.Label_Tipo)
        Me.Panel3.Controls.Add(Me.TxtIDUsuario)
        Me.Panel3.Controls.Add(Me.ValidText1)
        Me.Panel3.Controls.Add(Me.TxtGravado)
        Me.Panel3.Controls.Add(Me.Label45)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label40)
        Me.Panel3.Controls.Add(Me.Label42)
        Me.Panel3.Location = New System.Drawing.Point(-201, 248)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 128)
        Me.Panel3.TabIndex = 109
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.White
        Me.Label47.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCompras, "compras.Id_Compra", True))
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label47.Location = New System.Drawing.Point(8, 18)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(160, 12)
        Me.Label47.TabIndex = 110
        Me.Label47.Text = "0000"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 5
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Calcular "
        '
        'AdapterLotes
        '
        Me.AdapterLotes.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterLotes.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterLotes.SelectCommand = Me.SqlSelectCommand9
        Me.AdapterLotes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Inicial", "Cant_Inicial"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Fecha_Entrada", "Fecha_Entrada"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterLotes.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, Cod_Art" & _
    "iculo, Documento, Tipo FROM Lotes"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'labelCanceladoFactura
        '
        Me.labelCanceladoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelCanceladoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCanceladoFactura.Location = New System.Drawing.Point(8, 344)
        Me.labelCanceladoFactura.Name = "labelCanceladoFactura"
        Me.labelCanceladoFactura.Size = New System.Drawing.Size(107, 48)
        Me.labelCanceladoFactura.TabIndex = 111
        Me.labelCanceladoFactura.Text = "CANCELADA"
        Me.labelCanceladoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(479, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 55)
        Me.Button1.TabIndex = 194
        Me.Button1.Text = "Importar Factura Electronica"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1062, 470)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GridControlDetalleCompra)
        Me.Controls.Add(Me.CbNumero)
        Me.Controls.Add(Me.labelCanceladoFactura)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LNumero)
        Me.Controls.Add(Me.GroupBoxDetalleArticulo)
        Me.Controls.Add(Me.TbNumero)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LVencimiento)
        Me.Controls.Add(Me.DTPVencimiento)
        Me.Controls.Add(Me.LOpcion)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.TxtUtilidadFija)
        Me.Controls.Add(Me.TxtCostoEquivalente)
        Me.Controls.Add(Me.TextBoxValorMonedaEnCosto)
        Me.Controls.Add(Me.CheckBoxUtilidadFija)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.GroupBoxOpcionesCompras)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Name = "frmCompra"
        Me.Text = "Registro de Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.GroupBoxOpcionesCompras, 0)
        Me.Controls.SetChildIndex(Me.Label44, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox7, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.CheckBoxUtilidadFija, 0)
        Me.Controls.SetChildIndex(Me.TextBoxValorMonedaEnCosto, 0)
        Me.Controls.SetChildIndex(Me.TxtCostoEquivalente, 0)
        Me.Controls.SetChildIndex(Me.TxtUtilidadFija, 0)
        Me.Controls.SetChildIndex(Me.Label47, 0)
        Me.Controls.SetChildIndex(Me.LOpcion, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.DTPVencimiento, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.LVencimiento, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.TbNumero, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxDetalleArticulo, 0)
        Me.Controls.SetChildIndex(Me.LNumero, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.labelCanceladoFactura, 0)
        Me.Controls.SetChildIndex(Me.CbNumero, 0)
        Me.Controls.SetChildIndex(Me.GridControlDetalleCompra, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.GroupBoxOpcionesCompras.ResumeLayout(False)
        Me.GroupBoxOpcionesCompras.PerformLayout()
        CType(Me.Ck_Mascotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDetalleArticulo.ResumeLayout(False)
        Me.GroupBoxDetalleArticulo.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.CK_impuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmontofact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtimpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubExc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubgra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtPrecioVenta_IV_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlDetalleCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LookUpEdit_Proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "variables"
    Private nuevo As Boolean = True
    Dim Calcular As Boolean
    Dim Salto As Boolean
    Dim cargando As Boolean
    Dim buscando As Boolean
    Dim Lote As Boolean = False
    Dim Ver As Boolean = False
    Dim pbuscar As String = ""
#End Region

#Region "Load"

    Private Function ValidaCodCabys(_CodCabys As String)
        _CodCabys = Trim(_CodCabys)
        If _CodCabys = "" Or _CodCabys = "0" Then
            'puede dejar el campo vacio
            Return True
        End If
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select description from Seguridad.dbo.cabys where code = '" & _CodCabys & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Me.txtCodCabys.Focus()
            Return False
        End If
        Return False
    End Function


    Private Sub frmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection.ConnectionString = CadenaConexionSeePOS()
            AsignandoBinding()
            CargarAdaptadores()
            Valores_Defecto()

            Me.IdCompraTran = 0
            Me.txtTrans.Enabled = False
            Me.ckTrans.Enabled = False
            Me.btnAplicar.Enabled = False

            If GetSetting("seesoft", "seepos", "ver_tallerymascotas") = "0" Then

            End If

            If BindingContext(DataSetCompras, "Compras").Count = 0 Then Nueva_Compra()
            DataSetCompras.articulos_comprados.CodMonedaVentaColumn.DefaultValue = DataSetCompras.Monedas.Rows(0).Item("CodMoneda")

            If PMU.Others Then
                TxtImpuesto_Porcentaje.ReadOnly = False
                TxtUtilidad_A.Visible = True
                TxtUtilidad_B.Visible = True
                TxtUtilidad_C.Visible = True
                TxtUtilidad_D.Visible = True
                Label29.Visible = True
                TxtBase.ReadOnly = False

            Else
                TxtImpuesto_Porcentaje.ReadOnly = True
                TxtUtilidad_A.Visible = False
                TxtUtilidad_B.Visible = False
                TxtUtilidad_C.Visible = False
                TxtUtilidad_D.Visible = False
                Label29.Visible = False
                TxtBase.ReadOnly = True
            End If

            ToolBarExcel.Visible = VerificandoAcceso_a_Modulos("frmEtiquetasProductos", "Etiquetas de Artículos", Usua.Cedula, "Inventarios")
            txtClave.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub CargarAdaptadores()
        Try
            AdapterMoneda.Fill(DataSetCompras, "Moneda")
            AdapterLotes.Fill(DataSetCompras, "Lotes")
            AdapterMonedaDetalle.Fill(DataSetCompras, "Monedas")
            AdapterProveedores.Fill(DataSetCompras, "Proveedores")
            AdapterUsuarios.Fill(DataSetCompras, "Usuarios")

            DataSetCompras.compras.Id_CompraColumn.AutoIncrement = True
            DataSetCompras.compras.Id_CompraColumn.AutoIncrementSeed = -1
            DataSetCompras.compras.Id_CompraColumn.AutoIncrementStep = -1

            DataSetCompras.articulos_comprados.Id_ArticuloCompradosColumn.AutoIncrement = True
            DataSetCompras.articulos_comprados.Id_ArticuloCompradosColumn.AutoIncrementSeed = -1
            DataSetCompras.articulos_comprados.Id_ArticuloCompradosColumn.AutoIncrementStep = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Valores_Defecto()
        Try
            DataSetCompras.compras.FacturaColumn.DefaultValue = 0
            DataSetCompras.compras.SubTotalGravadoColumn.DefaultValue = 0
            DataSetCompras.compras.SubTotalExentoColumn.DefaultValue = 0
            DataSetCompras.compras.DescuentoColumn.DefaultValue = 0
            DataSetCompras.compras.ImpuestoColumn.DefaultValue = 0
            DataSetCompras.compras.TotalFacturaColumn.DefaultValue = 0
            DataSetCompras.compras.FechaColumn.DefaultValue = Date.Now
            DataSetCompras.compras.VenceColumn.DefaultValue = Date.Now
            DataSetCompras.compras.FechaIngresoColumn.DefaultValue = Date.Now
            DataSetCompras.compras.MotivoGastoColumn.DefaultValue = ""
            DataSetCompras.compras.FacturaColumn.DefaultValue = 0
            DataSetCompras.compras.FacturaCanceladoColumn.DefaultValue = False
            DataSetCompras.compras.CompraColumn.DefaultValue = 0
            DataSetCompras.compras.ContabilizadoColumn.DefaultValue = 0
            DataSetCompras.compras.ConsignacionColumn.DefaultValue = 0
            DataSetCompras.compras.AsientoColumn.DefaultValue = 0
            DataSetCompras.compras.ContaInveColumn.DefaultValue = 0
            DataSetCompras.compras.AsientoInveColumn.DefaultValue = 0
            DataSetCompras.compras.TipoCompraColumn.DefaultValue = "CRE"
            DataSetCompras.compras.CedulaUsuarioColumn.DefaultValue = 0
            DataSetCompras.compras.CambioImpuestoColumn.DefaultValue = False
            DataSetCompras.compras.TallerColumn.DefaultValue = False
            DataSetCompras.compras.MascotasColumn.DefaultValue = False
            DataSetCompras.compras.num_ordenColumn.DefaultValue = 0

            DataSetCompras.compras.Cod_MonedaCompraColumn.DefaultValue = DataSetCompras.Moneda.Rows(0).Item("CodMoneda")

            'VALORES POR DEFECTO PARA LA TABLA ARTICULOS COMPRADOS 
            DataSetCompras.articulos_comprados.DescuentoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Descuento_PColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.DevolucionesColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_AColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_BColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_CColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_DColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.NuevoCostoBaseColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.RegaliasColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.BonificadoColumn.DefaultValue = False
            DataSetCompras.articulos_comprados.CodigoBonificadoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.CantidadBonificadoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.CostoBonificadoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.SubTotalBonificadoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.CodArticuloBonificacionColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.LoteColumn.DefaultValue = 0

            'VALORES POR DEFECTO PARA LA TABLA ARTICULOS LOTES
            Me.DataSetCompras.Lotes.IdColumn.AutoIncrement = True
            Me.DataSetCompras.Lotes.IdColumn.AutoIncrementStep = -1
            Me.DataSetCompras.Lotes.IdColumn.AutoIncrementSeed = -1

            Me.DataSetCompras.Lotes.NumeroColumn.DefaultValue = 0
            Me.DataSetCompras.Lotes.VencimientoColumn.DefaultValue = Now.Date
            Me.DataSetCompras.Lotes.Fecha_EntradaColumn.DefaultValue = Date.Now
            Me.DataSetCompras.Lotes.Cant_InicialColumn.DefaultValue = 0
            Me.DataSetCompras.Lotes.Cant_ActualColumn.DefaultValue = 0
            Me.DataSetCompras.Lotes.Cod_ArticuloColumn.DefaultValue = 0
            Me.DataSetCompras.Lotes.DocumentoColumn.DefaultValue = 0
            Me.DataSetCompras.Lotes.TipoColumn.DefaultValue = "COM"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTipoF.SelectedIndexChanged
        Try
            If ComboTipoF.Text = "CRE" Then
                TxtDias.Enabled = True
                TxtDias.Text = BindingContext(DataSetCompras, "Proveedores").Current("Plazo")
                Label_Tipo.Text = "CRE"
            ElseIf ComboTipoF.Text = "CON" Then
                TxtDias.Enabled = False
                TxtDias.Text = "0.00"
                Label_Tipo.Text = "CON"
                BindingContext(DataSetCompras, "compras").EndCurrentEdit()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub

    Private Sub TxtDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDias.KeyPress
        Try

            If Asc(e.KeyChar) = Keys.Enter Then
                DTP_FechaVence.Value = DateAdd(DateInterval.Day, CInt(TxtDias.Text), DTP_FechaCompra.Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub txtcodart_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodArt.KeyPress, TxtDias.KeyPress, ComboBoxProvedor.KeyPress, ComboMonedaCompra.KeyPress, DTP_FechaCompra.KeyPress, txtCodArticulo.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                Select Case sender.name

                    Case txtCodArticulo.Name : CargarInformacion_articulos(sender.text)
                        If txtdescripcion.Text = "" Then MsgBox("Debe de digitar un artículo... o la descripción no puede estar vacia..", MsgBoxStyle.Critical, "") Else TxtCantidad.Focus()

                    Case ComboMonedaCompra.Name
                        BindingContext(DataSetCompras, "compras").EndCurrentEdit()

                    Case DTP_FechaCompra.Name
                        If ComboTipoF.Text = "CON" Then
                            ComboMonedaCompra.Focus()
                        Else
                            TxtDias.Focus()
                        End If

                    Case TxtDias.Name
                        ComboMonedaCompra.Focus()

                    Case Else
                        SendKeys.Send("{TAB}")
                End Select
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Mensaje")
        End Try
    End Sub

    Private Sub CargarInformacion_articulos(ByVal codigo As String)
        Dim Link As New Conexion
        Dim Articulo As SqlDataReader
        Dim FactorConversion As Decimal
        Dim encontrado As Boolean = False
        If codigo = "" Then
            txtCodArticulo.Focus()
            Exit Sub
        End If

        Articulo = Link.GetRecorset(Link.Conectar, "SELECT Inventario.Codigo, Inventario.Cod_Articulo, Inventario.Barras, Inventario.Descripcion, Inventario.PrecioBase, Inventario.Fletes, Inventario.OtrosCargos, Inventario.Costo,  Inventario.MonedaVenta, Inventario.IVenta, Inventario.Precio_A, Inventario.Precio_B, Inventario.Precio_C, Inventario.Precio_D, Moneda.ValorCompra AS TipoCambio, Inventario.Lote, Inventario.CodCabys FROM Inventario INNER JOIN Moneda ON Inventario.MonedaVenta = Moneda.CodMoneda where (cast(Cod_Articulo as varchar) = '" & codigo & "' or  Barras = '" & codigo & "')" & "and  Servicio = 0")

        Try
            DataSetCompras.articulos_comprados.BaseColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.CantidadColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.CodigoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.CostoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.DescripcionColumn.DefaultValue = ""
            DataSetCompras.articulos_comprados.Descuento_PColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.DescuentoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.DevolucionesColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.ExentoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.GravadoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Impuesto_PColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.ImpuestoColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Monto_FleteColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.NuevoCostoBaseColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.OtrosCargosColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_AColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_BColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_CColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.Precio_DColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.TotalColumn.DefaultValue = 0
            DataSetCompras.articulos_comprados.LoteColumn.DefaultValue = "0"

            DataSetCompras.compras.SubTotalGravadoColumn.DefaultValue = 0
            DataSetCompras.compras.SubTotalExentoColumn.DefaultValue = 0
            DataSetCompras.compras.ImpuestoColumn.DefaultValue = 0
            DataSetCompras.compras.DescuentoColumn.DefaultValue = 0
            DataSetCompras.compras.TotalFacturaColumn.DefaultValue = 0

            BindingContext(DataSetCompras, "compras").EndCurrentEdit()
            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").CancelCurrentEdit()
            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").AddNew()

            If Articulo.Read Then

                Me.txtCodCabys.Text = Articulo!CodCabys
                FactorConversion = Articulo!tipocambio / TextBoxMonedaCompra.Text
                TxtCodArt.Text = Articulo!codigo
                txtCodArticulo.Text = Articulo!Cod_Articulo
                txtdescripcion.Text = Articulo!Descripcion
                txtdescuento.Text = "0.00"
                TxtDescuento_Monto.Text = "0.00"
                TxtImpuesto_Porcentaje.Text = Articulo!Iventa
                TxtImpuesto_Monto.Text = "0.00"
                TxtGravado.Text = "0.00"
                TxtCantidad.Text = "1.00"
                TxtRegalias.Text = "0.00"
                TxtFlete.Text = Articulo!fletes * FactorConversion
                TxtOtros.Text = Articulo!otrosCargos * FactorConversion
                TxtBase.Text = Articulo!Preciobase * FactorConversion
                TxtCosto.Text = Articulo!costo * FactorConversion
                DataSetCompras.Monedas.Select("CodMoneda =" & Articulo!monedaventa)
                CBMonedaVenta.SelectedValue = Articulo!monedaventa
                DataSetCompras.articulos_comprados.CodMonedaVentaColumn.DefaultValue = Articulo!monedaventa

                Ver = False
                Lote = False
                LOpcion.Text = "Opcion"

                If Articulo!Lote = True Then
                    ActivaLote()
                Else
                    ActivaNinguno()
                End If

                TxtPrecioVenta_IV_A.Text = 0
                TxtPrecioVenta_IV_B.Text = 0
                TxtPrecioVenta_IV_C.Text = 0
                TxtPrecioVenta_IV_D.Text = 0

                TxtPrecioVenta_A.Text = Articulo!precio_A
                TxtPrecioVenta_B.Text = Articulo!precio_B
                TxtPrecioVenta_C.Text = Articulo!precio_C
                TxtPrecioVenta_D.Text = Articulo!precio_d

                txtCodArticulo.Focus()
            Else
                BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").CancelCurrentEdit()
                MsgBox("No existe un artículo con ese código o está inhabilitado", MsgBoxStyle.Exclamation)
                txtCodArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Link.DesConectar(Link.sQlconexion)
        End Try
        Link.DesConectar(Link.sQlconexion)
    End Sub
    Private Function Utilidad(ByVal Costo As Double, ByVal Precio As Double) As Double
        Try
            Utilidad = Math.Round(((Precio / Costo) - 1) * 100, 2)
            Return Utilidad
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
    Private Sub txtcodart_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodArticulo.KeyDown, TxtCantidad.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Try
                        BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").CancelCurrentEdit()
                        BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").AddNew()
                        Dim BuscarArt As New FrmBuscarArticulo2
                        BuscarArt.StartPosition = FormStartPosition.CenterParent
                        BuscarArt.CheckBoxInHabilitados.Enabled = True
                        BuscarArt.Cod_Articulo = True
                        BuscarArt.ShowDialog()
                        If BuscarArt.Cancelado Then Exit Sub
                        txtCodArticulo.Text = BuscarArt.Codigo
                        BuscarArt.Dispose()
                        sender.SelectionStart = 0
                        sender.SelectionLength = Len(sender.Text)
                        CargarInformacion_articulos(txtCodArticulo.Text)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                    End Try
                Case Keys.F2
                    Registrar()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Private Sub TxtCodArt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArticulo.GotFocus, TxtCantidad.GotFocus, TxtRegalias.GotFocus, TxtCosto.GotFocus, TxtImpuesto_Monto.GotFocus, TxtImpuesto_Porcentaje.GotFocus, TxtDescuento_Monto.GotFocus, TxtFacturaCompraN.GotFocus, TxtDias.GotFocus, TxtTotalFactura.GotFocus, TxtBase.GotFocus, TxtOtros.GotFocus, Descuento_Porcentaje_Detalle.GotFocus, TxtUtilidad_A.GotFocus, TxtUtilidad_B.GotFocus, TxtUtilidad_C.GotFocus, TxtUtilidad_D.GotFocus, TxtPrecioVenta_A.GotFocus, TxtPrecioVenta_B.GotFocus, TxtPrecioVenta_C.GotFocus, TxtPrecioVenta_D.GotFocus, TxtPrecioVenta_IV_A.GotFocus, TxtPrecioVenta_IV_B.GotFocus, TxtPrecioVenta_IV_C.GotFocus, TxtPrecioVenta_IV_D.GotFocus, TxtFlete.GotFocus
        Try
            sender.SelectionStart = 0
            sender.SelectionLength = Len(sender.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Calcular_Monto(Optional ByVal CalcularPocentaje As Boolean = True)
        Try
            If Not IsNumeric(TxtBase.Text) Then TxtBase.Text = "0.00"
            If Not IsNumeric(TxtOtros.Text) Then TxtOtros.Text = "0.00"
            If Not IsNumeric(TxtFlete.Text) Then TxtFlete.Text = "0.00"
            If Not IsNumeric(TxtCantidad.Text) Then TxtCantidad.Text = "0.00"
            If Not IsNumeric(TxtRegalias.Text) Then TxtRegalias.Text = "0.00"
            If Not IsNumeric(Descuento_Porcentaje_Detalle.Text) Then Descuento_Porcentaje_Detalle.Text = "0.00"
            If Not IsNumeric(TxtImpuesto_Porcentaje.Text) Then
                TxtImpuesto_Porcentaje.Text = "0.00"
            End If

            TxtCosto.Text = CDbl(TxtBase.Text) + CDbl(TxtOtros.Text) + CDbl(TxtFlete.Text)
            Dim CostoGravado As Double = TxtBase.Text
            Dim CostoExento As Double = 0 'CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text)

            TxtDescuento_Monto.Text = Format(TxtCantidad.Text * (CostoGravado * (Descuento_Porcentaje_Detalle.Text / 100)), "#,#0.00")

            TxtCostoReal.Text = TxtBase.Text + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text)
            'TxtCostoReal.Text = TxtBase.Text + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text) - (TxtBase.Text * (Descuento_Porcentaje_Detalle.Text / 100))
            Dim SubTotalBonificacion As Decimal = 0
            If TxtImpuesto_Porcentaje.Text <> 0 Then
                If CDec(Me.TxtCantidad.Text) = 0 And CDec(Me.TxtRegalias.Text) > 0 Then
                    SubTotalBonificacion = (CostoGravado * TxtRegalias.Text) - TxtDescuento_Monto.Text
                End If
                TxtGravado.Text = ((CostoGravado + CDec(Me.TxtFlete.Text)) * TxtCantidad.Text) - TxtDescuento_Monto.Text
                TxtExento.Text = "0.00"
            Else
                TxtGravado.Text = CDec(Me.TxtFlete.Text)
                TxtExento.Text = (CostoGravado * TxtCantidad.Text) - TxtDescuento_Monto.Text + (CostoExento * TxtCantidad.Text)
            End If
            'Me.TxtGravado.Text += (CDec(Me.TxtFlete.Text) * CDec(Me.TxtCantidad.Text))
            TxtImpuesto_Monto.Text = IIf(Not IsNumeric(TxtGravado.Text), (0 + SubTotalBonificacion), (TxtGravado.Text + SubTotalBonificacion)) * (IIf(Not IsNumeric(TxtImpuesto_Porcentaje.Text), 0, TxtImpuesto_Porcentaje.Text) / 100)
            '*************************************************************************************************
            'OJO, Hay que sumar los fletes y otros cargos luego de calcular los impuestos para no varias los 
            '*************************************************************************************************
            'Aqui debo sumarlos
            '*************************************************************************************************
            TxtTotalCompra.Text = Format(CDbl(TxtGravado.Text) + CDbl(TxtExento.Text), "#,#0.00")
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.Source, MsgBoxStyle.Exclamation, "Atención...")
        End Try
    End Sub
    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged, TxtRegalias.TextChanged, TxtBase.TextChanged, TxtOtros.TextChanged, TxtOtros.TextChanged, TxtDescuento_Monto.TextChanged, TxtFlete.TextChanged
        Try
            If TxtDescuento_Monto.Text = "" Then TxtDescuento_Monto.Text = "0.00"
            If TxtBase.Text = "" Then TxtBase.Text = "0.00"
            Calcular_Monto()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub Nueva_Compra()
        Try
            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()
            Me.Lote = False
            Me.Ver = False
            Me.LOpcion.Text = "Opcion"
            Me.TbNumero.Text = ""
            Me.DTPVencimiento.Value = Now.Date
            Me.IdCompraTran = 0
            Me.txtTrans.Enabled = False
            Me.ckTrans.Enabled = False
            Me.btnAplicar.Enabled = False

            If ToolBar1.Buttons(0).Text = "Nuevo" Then
                txtClave.Enabled = True
                GroupBoxDetalleArticulo.Enabled = False
                GroupBox1.Enabled = False
                GroupBoxOpcionesCompras.Enabled = False
                ComboMonedaCompra.Enabled = True
                GroupBox1.Enabled = False
                GroupBoxOpcionesCompras.Enabled = False
                GroupBoxDetalleArticulo.Enabled = False
                txtClave.Focus()
                Valores_Defecto()
                TxtFacturaCompraN.Text = 0
                TxtDias.Text = 0
                CK_impuesto.Enabled = True
                BindingContext(DataSetCompras, "compras").EndCurrentEdit()
                BindingContext(DataSetCompras, "compras").AddNew()
                ToolBar1.Buttons(0).Text = "Cancelar"
                ToolBar1.Buttons(0).ImageIndex = 8
                Me.labelCanceladoFactura.Visible = False


                '                ErrorProvider.Dispose()
            Else
                txtClave.Enabled = False
                CK_impuesto.Enabled = False
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                BindingContext(DataSetCompras, "compras").CancelCurrentEdit()
                DataSetCompras.articulos_comprados.Clear()
                DataSetCompras.Lotes.Clear()
                DataSetCompras.compras.Clear()
                txtClave.Focus()
            End If


            If Not Importando Then
                'Me.txtClave.Enabled = True
                txtClave.Text = ""
                TxtNombreUsuario.Text = ""
                DataSetCompras.detalle_ordencompra.Clear()
                DataSetCompras.ordencompra.Clear()
            End If
            'Limpia la validacion de Errores..
            ErrorProvider.SetError(TxtFacturaCompraN, "")
            ErrorProvider.SetError(ComboTipoF, "")
            ErrorProvider.SetError(ComboBoxProvedor, "")
            ErrorProvider.SetError(ComboMonedaCompra, "")
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub TxtImpuesto_Porcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpuesto_Porcentaje.KeyPress
        Try

            'TxtCostoReal.Text = TxtBase.Text - (TxtBase.Text * (Descuento_Porcentaje_Detalle.Text / 100)) + CDbl(TxtFlete.Text) - CDbl(TxtOtros.Text)
            TxtCostoReal.Text = TxtBase.Text + CDbl(TxtFlete.Text) - CDbl(TxtOtros.Text)

            If CheckBoxUtilidadFija.Checked = True Then
                TxtUtilidad_A.Text = TxtUtilidadFija.Text
                TxtUtilidad_B.Text = TxtUtilidadFija.Text
                TxtUtilidad_C.Text = TxtUtilidadFija.Text
                TxtUtilidad_D.Text = TxtUtilidadFija.Text
            Else
                Asignar_Utilidad_Anterior() 'Me.TxtUtilidad_A.Text = Utilidad(CDbl(TxtBase.Text), CDbl(TxtPrecioVenta_A.Text))
            End If
            CalcularPrecios(TxtCostoReal.Text, CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Asignar_Utilidad_Anterior()
        Try
            Dim Registros As SqlDataReader
            Dim Link As New Conexion
            Registros = Link.GetRecorset(Link.Conectar, "Select * from inventario where codigo ='" & TxtCodArt.Text & "'")
            If Registros.Read Then
                CBMonedaVenta.SelectedValue = Registros!MonedaVenta
                TxtUtilidad_A.Text = Format(((Registros!Precio_A / Registros!PrecioBase) - 1) * 100, "#,#0.00")
                TxtUtilidad_B.Text = Format(((Registros!Precio_b / Registros!PrecioBase) - 1) * 100, "#,#0.00")
                TxtUtilidad_C.Text = Format(((Registros!Precio_c / Registros!PrecioBase) - 1) * 100, "#,#0.00")
                TxtUtilidad_D.Text = Format(((Registros!Precio_d / Registros!PrecioBase) - 1) * 100, "#,#0.00")
            End If
            Link.DesConectar(Link.sQlconexion)
            Registros = Nothing
            Link.DesConectar(Link.sQlconexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Sub CalcularPrecios(ByVal PrecioCosto As Double, ByVal Otros As Double)
        Try
            PrecioCosto = PrecioCosto - Otros
            TxtPrecioVenta_A.Text = PrecioCosto + (PrecioCosto * (TxtUtilidad_A.Text / 100)) + Otros
            TxtPrecioVenta_B.Text = PrecioCosto + (PrecioCosto * (TxtUtilidad_B.Text / 100)) + Otros
            TxtPrecioVenta_C.Text = PrecioCosto + (PrecioCosto * (TxtUtilidad_C.Text / 100)) + Otros
            TxtPrecioVenta_D.Text = PrecioCosto + (PrecioCosto * (TxtUtilidad_D.Text / 100)) + Otros
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Descuento_Porcentaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descuento_Porcentaje_Detalle.TextChanged
        Try
            If Not IsNumeric(Descuento_Porcentaje_Detalle.Text) Then _
                TxtDescuento_Monto.Text = 0 _
            Else _
            TxtDescuento_Monto.Text = Format(TxtCantidad.Text * CDbl(TxtBase.Text) * (Descuento_Porcentaje_Detalle.Text / 100), "#,#0.00")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub AsignandoBinding()
        Try

            'ENLACE CON LA TABLA COMPRAS
            CheckBoxUtilidadFija.DataBindings.Add(New System.Windows.Forms.Binding("Checked", DataSetCompras, "Proveedores.Utilidad_Fija"))
            ComboBoxProvedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DataSetCompras, "compras.CodigoProv"))
            ComboMonedaCompra.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DataSetCompras, "compras.Cod_MonedaCompra"))
            ComboTipoF.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.TipoCompra"))
            DTP_FechaCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.Fecha"))
            DTP_FechaVence.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.Vence"))
            Label44.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.Id_Compra"))
            Label45.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.CodigoProv"))
            TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "Moneda.CodMoneda"))
            TextBoxMonedaCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "Moneda.ValorCompra"))
            TextBoxValorMonedaEnVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "Monedas.ValorCompra"))
            txt_num_orden.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.num_orden"))


            Me.txtCodCabys.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCompras, "compras.ComprasArticulos_Comprados.CodCabys", True))
            TxtDescuento_Monto.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Descuento"))
            TxtFacturaCompraN.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.Factura"))
            TxtIDUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.CedulaUsuario"))
            TxtUtilidadFija.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "Proveedores.Utilidad_Inventario"))
            txtmontofact.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.TotalFactura"))
            txtimpuesto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.Impuesto"))
            txtdescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.Descuento"))
            txtsubgra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.SubTotalGravado"))
            TxtSubExc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.SubTotalExento"))


            ' ENLACE DE ARTICULOS COMPRADOS
            TxtBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Base"))
            TxtCodArt.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.comprasarticulos_comprados.Codigo"))
            txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.comprasarticulos_comprados.CodArticulo"))
            TxtImpuesto_Monto.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Impuesto"))
            txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Descripcion"))
            TxtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Cantidad"))
            TxtRegalias.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Regalias"))
            TxtImpuesto_Porcentaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Impuesto_P"))
            TxtTotalCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Total"))
            TxtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Costo"))
            TxtOtros.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.OtrosCargos"))
            TxtFlete.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Monto_Flete"))
            TxtPrecioVenta_D.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.comprasarticulos_comprados.Precio_D"))
            TxtPrecioVenta_C.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.comprasarticulos_comprados.Precio_C"))
            TxtPrecioVenta_B.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.comprasarticulos_comprados.Precio_B"))
            CBMonedaVenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DataSetCompras, "compras.comprasarticulos_comprados.CodMonedaVenta"))
            TxtPrecioVenta_A.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCompras, "compras.comprasarticulos_comprados.Precio_A"))
            TxtGravado.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.comprasarticulos_comprados.Gravado"))
            TxtExento.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Exento"))
            Descuento_Porcentaje_Detalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.Descuento_P"))
            TxtCostoReal.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.NuevoCostoBase"))

            Me.ckBonificado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", DataSetCompras, "compras.ComprasArticulos_Comprados.Bonificado"))
            Me.txtCodArticuloBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.CodArticuloBonificacion"))
            Me.txtCodigoBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.CodigoBonificado"))
            Me.txtCantidadBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.CantidadBonificado"))
            Me.txtCostoBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.CostoBonificado"))
            Me.txtSubtotalBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCompras, "compras.ComprasArticulos_Comprados.SubTotalBonificado"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Panel_Centrar()
        Panel2.Left = (Width - Panel2.Width) \ 2
        Panel2.Top = (Height - Panel2.Height) \ 2
    End Sub

    Private Sub Panel_Ocultar()
        Panel2.Left = -Panel2.Width
    End Sub

    Private Sub ButtonAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarDetalle.Click
        Try
            boton_agregar_Detalle()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub boton_agregar_Detalle()
        Try
            If TxtCostoReal.Text = 0 Then
                MsgBox("nuevo costo en cero")
            End If

            GuardaLote()

            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").AddNew()
            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").CancelCurrentEdit()

            ToolBar1.Buttons(2).Enabled = True
            Panel_Ocultar()

            Calcular_Totales_Compras()
            txtCodArticulo.Focus()
            'Me.cerrado = True
            If Importando = True And Finalizado_Importacion = False Then
                Timer1.Enabled = True
                Timer1.Start()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub PoneUtilidad()

        For i As Integer = 0 To BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Count - 1
            BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Position = i


            Dim Descripccion As String = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Descripcion")
            Dim Base As Decimal = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Base")
            Dim MontoDescuento As Decimal = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Descuento")
            Dim Cantidad As Decimal = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Cantidad")
            Dim Precio As Decimal = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Precio_A")
            Try
                If Cantidad > 0 And Base > 0 Then
                    Dim CostoReal As Decimal = Base - (MontoDescuento / Cantidad)
                    If CostoReal > 0 Then
                        Dim Utilidad As Decimal = ((Precio / CostoReal) - 1) * 100

                        BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Utilidad") = Math.Round(Utilidad, 2)
                        BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
                    Else
                        BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Utilidad") = 0
                        BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
                    End If

                Else
                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Utilidad") = 0
                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
                End If
            Catch ex As Exception
                MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, Descripccion)
            End Try
            
        Next

    End Sub

    Private Sub CorrigeImpuestos()
        If Me.CK_impuesto.Checked = f Then
            Dim Imp As Decimal = 0
            Dim SubtotalBonificacion As Decimal = 0
            For i As Integer = 0 To BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Count - 1
                BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Position = i
                If BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Cantidad") = 0 And BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Regalias") > 0 Then
                    'si es una bonificacion, calculo el subtotal
                    SubtotalBonificacion = (BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Regalias") * BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Base")) - BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Descuento")
                Else
                    SubtotalBonificacion = 0
                End If



                If BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto_P") < 13 And BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Monto_Flete") > 0 Then
                    'si el producto es excento pero tienen flete
                    '    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto") = (BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Gravado") + SubtotalBonificacion) * (13 / 100)
                    '    Imp += BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto")
                    '    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
                    'ElseIf BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto_P") >= 0 And BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto_P") < 13 And BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Monto_Flete") > 0 Then
                    'si el producto tiene impuesto reducido y tienen flete
                    Dim subTotal As Decimal = CDec(BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Gravado")) - CDec(BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Monto_Flete"))
                    Dim ImpuestoProducto As Decimal = (subTotal + SubtotalBonificacion) * (BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto_P") / 100)
                    Dim ImpuestoFlete As Decimal = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Monto_Flete") * (13 / 100)
                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto") = ImpuestoProducto + ImpuestoFlete
                    Imp += BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto")
                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
                Else

                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto") = (BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Gravado") + SubtotalBonificacion) * (BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto_P") / 100)
                    Imp += BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Impuesto")
                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").EndCurrentEdit()
                End If
            Next i
            BindingContext(DataSetCompras, "compras").Current("Impuesto") = Imp
        End If
    End Sub

    Private Sub Calcular_Totales_Compras()   ' calcula el monto Total de la cotización
        If Me.ImportandoXMLCompra = True Then Exit Sub
        TxtSubExc.Properties.DisplayFormat.FormatString = TextBox2.Text & "#,#0.00"
        txtsubgra.Properties.DisplayFormat.FormatString = TextBox2.Text & "#,#0.00"
        txtdescuento.Properties.DisplayFormat.FormatString = TextBox2.Text & "#,#0.00"
        txtimpuesto.Properties.DisplayFormat.FormatString = TextBox2.Text & "#,#0.00"
        txtmontofact.Properties.DisplayFormat.FormatString = TextBox2.Text & "#,#0.00"

        Try
            If CK_impuesto.Checked = True Then
                Me.CorrigeImpuestos()
            Else
                Me.CorrigeImpuestos()
            End If

            Me.PoneUtilidad()

            If CheckBox1.Checked = False Then
                BindingContext(DataSetCompras, "compras").Current("TotalFactura") = Math.Round(colGravado.SummaryItem.SummaryValue + colExento.SummaryItem.SummaryValue + BindingContext(DataSetCompras, "compras").Current("Impuesto"), 2)
            Else
                BindingContext(DataSetCompras, "compras").Current("TotalFactura") = Me.txtmontofact.Text
            End If

            'BindingContext(DataSetCompras, "compras").Current("Impuesto") = Math.Round(colImpuesto.SummaryItem.SummaryValue, 2)
            BindingContext(DataSetCompras, "compras").Current("SubTotalGravado") = Math.Round(colGravado.SummaryItem.SummaryValue, 2)
            BindingContext(DataSetCompras, "compras").Current("SubTotalExento") = Math.Round(colExento.SummaryItem.SummaryValue, 2)
            BindingContext(DataSetCompras, "compras").Current("Descuento") = Math.Round(colDescuento.SummaryItem.SummaryValue, 2)
            BindingContext(DataSetCompras, "compras").EndCurrentEdit()


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        boton_Cancelar_Agregar_Detalle()
    End Sub
    Private Sub boton_Cancelar_Agregar_Detalle()
        'Panel2.Visible = False
        Try


            Panel_Ocultar()

            If Importando = True And Finalizado_Importacion = False Then
                Timer1.Enabled = True
                Timer1.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nueva_Compra()
            Case 2 : If PMU.Find Then BuscarFactura_Compra() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Eliminar_Factura_Compra() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : Etiquetas()
            Case 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Close()
            Case 12 : BuscarOrdenCompra_importar()
            Case 8 : Calcular_Totales_Compras()
            Case 11 : If MessageBox.Show("¿Desea Cerrar el módulo " & Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Close()
        End Select
    End Sub
    Private Sub CerrarMe()
        Try

            If ToolBarNuevo.Text = "Cancelar" Then

            End If



            If MsgBox("Desea Cerrar este módulo...[" & Text & "]", MsgBoxStyle.YesNo, "Atención..") = MsgBoxResult.Yes Then
                ComboBoxProvedor.Enabled = False
                BindingContext(DataSetCompras, "Compras").CancelCurrentEdit()
                ErrorProvider.Dispose()
                ErrorProvider.SetError(TxtFacturaCompraN, "")
                ErrorProvider.SetError(ComboTipoF, "")
                ErrorProvider.SetError(ComboBoxProvedor, "")
                ErrorProvider.SetError(ComboMonedaCompra, "")
                Close()
            Else
                ComboBoxProvedor.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try

    End Sub
    Private Sub BuscarOrdenCompra_importar()
        Try
            If BindingContext(DataSetCompras, "compras").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una Compra, si continúa se perderan los datos de la Compra actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()
            DataSetCompras.detalle_ordencompra.Clear()
            DataSetCompras.ordencompra.Clear()
            Dim identificador As Double

            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Orden, Nombre,Fecha from ordencompra Order by Fecha DESC", "Nombre", "Fecha", "Buscar Orden de Compra"))
            ' buscando = True

            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Importando = False
                Exit Sub
            End If
            Importando = True
            Fx.Llenar_Tabla_Generico("SELECT * FROM ordencompra WHERE Orden =" & identificador, DataSetCompras.ordencompra)
            Fx.Llenar_Tabla_Generico("SELECT * FROM detalle_ordencompra WHERE Orden =" & identificador, DataSetCompras.detalle_ordencompra)
            Ingresar_Datos()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Ingresar_Datos()
        Try

            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()

            BindingContext(DataSetCompras, "compras").EndCurrentEdit()
            BindingContext(DataSetCompras, "compras").AddNew()
            ToolBar1.Buttons(0).ImageIndex = 8

            ComboBoxProvedor.SelectedIndex = 0
            Dim a As Integer
            a = DataSetCompras.ordencompra.Rows(0).Item("Proveedor")
            If a <> 0 Then
                BindingContext(DataSetCompras, "compras").Current("CodigoProv") = a
            Else : ComboBoxProvedor.SelectedIndex = 1
            End If
            Indicador_Posicion = 0
            Finalizado_Importacion = False

            BindingContext(DataSetCompras, "compras").Current("SubTotalGravado") = BindingContext(DataSetCompras, "ordencompra").Current("SubTotalGravado")
            BindingContext(DataSetCompras, "compras").Current("SubTotalExento") = BindingContext(DataSetCompras, "ordencompra").Current("SubTotalExento")
            BindingContext(DataSetCompras, "compras").Current("Descuento") = BindingContext(DataSetCompras, "ordencompra").Current("Descuento")
            BindingContext(DataSetCompras, "compras").Current("Impuesto") = BindingContext(DataSetCompras, "ordencompra").Current("Impuesto")
            BindingContext(DataSetCompras, "compras").Current("TotalFactura") = BindingContext(DataSetCompras, "ordencompra").Current("Total")
            BindingContext(DataSetCompras, "compras").Current("Cod_MonedaCompra") = BindingContext(DataSetCompras, "ordencompra").Current("Cod_Moneda")
            buscar_datos_usuario()

            If BindingContext(DataSetCompras, "ordencompra").Current("Contado") = True Then
                ComboTipoF.Text = "CON"
            Else
                ComboTipoF.Text = "CRE"
            End If
            GroupBoxOpcionesCompras.Enabled = True
            BindingContext(DataSetCompras, "compras").EndCurrentEdit()
            GroupBoxDetalleArticulo.Enabled = True
            ComboMonedaCompra.Enabled = False



            'Calcular_Totales_Compras()

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(2).Enabled = True

            Timer1.Enabled = True
            Timer1.Start()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Function GetProveedor(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select CodigoProv from Proveedores where Cedula = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("CodigoProv")
        Else
            Return "0"
        End If
    End Function

    Private Function GetNumFactura(_Consecutivo As String) As String
        Return CInt(_Consecutivo.Substring(10, 10))
    End Function

    Private Function ValidarPrecios() As Boolean
        Dim PrecioUnit As Decimal = 0
        Dim Codigo As Long = 0
        Dim Descripcion As String = ""
        For i As Integer = 0 To Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Count - 1
            Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Position = i
            PrecioUnit = Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Precio_A")
            Codigo = Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo")
            Descripcion = Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo")

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("exec [usp_GetArticulosRelaccionados] " & Codigo & ", " & PrecioUnit, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Try
                    Dim frm As New frmProductosRelacionados
                    frm.Codigo = Codigo
                    frm.PrecioUnit = PrecioUnit
                    frm.txtDescripcion.Text = Me.txtdescripcion.Text
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim Trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                        Try
                            Trans.Ejecutar("Update ArticulosRelacionados Set Precio_Unit = " & PrecioUnit & " Where Codigo = " & Codigo, CommandType.Text)
                            For Each row As DataGridViewRow In frm.viewDatos.Rows

                                If row.Cells("cTipo").Value = 2 Then 'DescargaOtro
                                    Trans.Ejecutar("Update Inventario set PrecioDescargaOtro = " & PrecioUnit & " Where Codigo = " & row.Cells("cCodigo").Value, CommandType.Text)
                                End If

                                If row.Cells("cAplicar").Value = True Then
                                    Trans.Ejecutar("Update Inventario set Precio_A = " & CDec(row.Cells("cNuevoPrecio").Value) & " Where Codigo = " & row.Cells("cCodigo").Value, CommandType.Text)
                                End If
                            Next
                        Catch ex As Exception
                            Trans.Rollback()
                        End Try
                        Trans.Commit()
                        Return True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Return True
            End If

        Next
        Return False
    End Function

    Private ImportandoXMLCompra As Boolean = False
    Private Sub Cargar_XML_Factura()
        Try            
            Dim frm As New frmImportarFacturaElectronica(Me.Usua)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                DataSetCompras.articulos_comprados.Clear()
                DataSetCompras.Lotes.Clear()
                DataSetCompras.compras.Clear()

                BindingContext(DataSetCompras, "compras").EndCurrentEdit()
                BindingContext(DataSetCompras, "compras").AddNew()
                ToolBar1.Buttons(0).ImageIndex = 8

                ComboBoxProvedor.SelectedIndex = 0

                If frm.NoExisteCedula = False Then
                    Dim a As String
                    a = Me.GetProveedor(frm.txtCedula.Text)
                    If a <> "0" Then
                        Me.LookUpEdit_Proveedor.Text = a
                        Me.LookUpEdit_Proveedor.CancelPopup()
                        BindingContext(DataSetCompras, "compras").Current("CodigoProv") = a
                    Else
                        ComboBoxProvedor.SelectedIndex = 1
                    End If
                Else
                    Dim Fx As New cFunciones
                    Dim valor As String
                    valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                    If valor = "" Then
                        LookUpEdit_Proveedor.EditValue = Nothing
                        ComboBoxProvedor.SelectedIndex = -1
                    Else
                        ComboBoxProvedor.SelectedValue = valor
                        LookUpEdit_Proveedor.EditValue = valor
                        LookUpEdit_Proveedor.Text = valor

                        BindingContext(DataSetCompras, "compras").Current("CodigoProv") = valor
                    End If
                End If

                BindingContext(DataSetCompras, "compras").Current("SubTotalGravado") = 0
                BindingContext(DataSetCompras, "compras").Current("SubTotalExento") = 0
                BindingContext(DataSetCompras, "compras").Current("Descuento") = 0
                BindingContext(DataSetCompras, "compras").Current("Impuesto") = 0
                BindingContext(DataSetCompras, "compras").Current("TotalFactura") = 0
                BindingContext(DataSetCompras, "compras").Current("Cod_MonedaCompra") = 1
                buscar_datos_usuario()

                Me.DTP_FechaCompra.Value = CDate(frm.txtFecha.Text)
                Me.TxtFacturaCompraN.Text = Me.GetNumFactura(frm.txtConsecutivo.Text)

                If frm.CondicionVenta = "01" Then
                    ComboTipoF.Text = "CON"
                Else
                    ComboTipoF.Text = "CRE"
                    Me.DTP_FechaVence.Value = DateAdd(DateInterval.Day, frm.PlazoCredito, Me.DTP_FechaCompra.Value)
                End If

                GroupBoxOpcionesCompras.Enabled = True
                BindingContext(DataSetCompras, "compras").EndCurrentEdit()
                Me.ImportandoXMLCompra = True
                GroupBoxDetalleArticulo.Enabled = True
                ComboMonedaCompra.Enabled = False


                GroupBox1.Enabled = True
                GroupBox2.Enabled = True

                ToolBar1.Buttons(4).Enabled = False
                ToolBar1.Buttons(2).Enabled = True

                '********************************************************************************************************************************
                'Inica el detalle de la compra
                '********************************************************************************************************************************
                Dim cant, regalia, costo, nuevocosto, descuento, montodescuento, subtotal As Decimal
                cant = 0
                regalia = 0
                costo = 0
                nuevocosto = 0
                descuento = 0
                montodescuento = 0
                subtotal = 0

                Dim Flete As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows
                                        Where x.Cells("cFlete").Value = True
                                        Select CDec(x.Cells("cCosto").Value) - CDec(x.Cells("cMontoDescuento").Value)).Sum

                Dim CantidadProductos As Decimal = (From x As DataGridViewRow In frm.viewDatos.Rows
                                                    Where x.Cells("cFlete").Value = False
                                                    Select CDec(x.Cells("cCantidad").Value)).Sum

                Dim FleteUnitario As Decimal = 0

                If Flete > 0 Then
                    FleteUnitario = Flete / CantidadProductos
                End If

                For Each r As DataGridViewRow In frm.viewDatos.Rows
                    If r.Cells("cFlete").Value = False Then


                        cant = CDec(r.Cells("cCantidad").Value) * CDec(r.Cells("cCantidadxPresentacion").Value)
                        costo = (CDec(r.Cells("cCosto").Value) * CDec(r.Cells("cCantidad").Value)) / cant

                        montodescuento = CDec(r.Cells("cMontoDescuento").Value)
                        If montodescuento > 0 Then
                            descuento = Math.Round(100 * (montodescuento / (costo * cant)), 4)
                        Else
                            descuento = 0
                        End If

                        nuevocosto = costo - (montodescuento / cant)
                        subtotal = cant * nuevocosto

                        If costo > 0 Then

                            regalia = (From x As DataGridViewRow In frm.viewDatos.Rows Where x.Cells("cCodigoProveedor").Value = r.Cells("cCodigoProveedor").Value And x.Cells("cCosto").Value = 0 Select CDec(x.Cells("cCantidad").Value)).Sum

                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").EndCurrentEdit()
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").AddNew()

                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("CodCabys") = r.Cells("cCabys").Value
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") = r.Cells("cId_ArticuloInterno").Value
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("CodArticulo") = r.Cells("cCodigoInterno").Value
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descripcion") = r.Cells("cDescripcionInterno").Value
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Base") = costo
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Monto_Flete") = FleteUnitario
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("OtrosCargos") = 0
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Costo") = nuevocosto
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("NuevoCostoBase") = nuevocosto
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Cantidad") = cant
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Regalias") = regalia

                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Precio_A") = CDec(r.Cells("cPrecioIva1").Value)
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Precio_B") = CDec(r.Cells("cPrecioIva1").Value)
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Precio_C") = CDec(r.Cells("cPrecioIva1").Value)
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Precio_D") = 0


                            If CDec(r.Cells("cImpuesto").Value) > 0 Then
                                Me.CK_impuesto.Checked = True
                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Gravado") = subtotal + FleteUnitario
                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Exento") = 0
                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto") = subtotal * (CDec(r.Cells("cImpuesto").Value) / 100)
                                txtimpuesto.Text = BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto")
                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto_P") = CDec(r.Cells("cImpuesto").Value)
                                Me.TxtImpuesto_Porcentaje.Text = CDec(r.Cells("cImpuesto").Value)
                                Me.TxtImpuesto_Monto.Text = CDec(Me.txtimpuesto.Text)
                            Else
                                txtimpuesto.Text = 0
                                Me.TxtImpuesto_Porcentaje.Text = 0
                                Me.TxtImpuesto_Monto.Text = 0
                                Me.CK_impuesto.Checked = False

                                If FleteUnitario > 0 Then
                                    'por ley el flete es gravado al 13%
                                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Gravado") = FleteUnitario
                                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto") = Flete * 0.13
                                Else

                                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Gravado") = 0
                                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto") = 0
                                End If

                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Exento") = subtotal
                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto") = 0
                                BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto_P") = 0
                            End If

                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descuento") = montodescuento
                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descuento_P") = descuento

                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Total") = subtotal + FleteUnitario + BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto_P")

                            'Dim Link As New Conexion
                            'Dim Articulo As SqlDataReader
                            'Articulo = Link.GetRecorset(Link.Conectar, "SELECT Inventario.Precio_A, Inventario.Precio_B, Inventario.Precio_C, Inventario.Precio_D FROM Inventario where  (cast(codigo as varchar) = '" & BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") & "' or  Barras = '" & BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") & "')" & "and Inhabilitado = 0 and Servicio = 0")
                            'If Articulo.Read Then
                            '    TxtPrecioVenta_A.Text = Articulo!precio_A
                            '    TxtPrecioVenta_B.Text = Articulo!precio_B
                            '    TxtPrecioVenta_C.Text = Articulo!precio_C
                            '    TxtPrecioVenta_D.Text = Articulo!precio_d
                            'Else

                            '    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").CancelCurrentEdit()
                            '    MsgBox("No existe un artículo con ese código o está inhabilitado", MsgBoxStyle.Exclamation)
                            'End If

                            'Link.DesConectar(Link.sQlconexion)

                            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").EndCurrentEdit()                          
                        End If
                    End If
                Next
                Me.ImportandoXMLCompra = False
                Calcular_Totales_Compras()
                Calcular_Totales_Compras()
                Me.PoneUtilidad()

            End If
            Me.ImportandoXMLCompra = False
        Catch ex As SystemException
            Me.ImportandoXMLCompra = False
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Cargar_Detalle_Importacion_orden_Compra()
        Try
            If Indicador_Posicion > (BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Count - 1) Then
                Finalizado_Importacion = True
                Exit Sub
            End If

            BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Position = Indicador_Posicion
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").EndCurrentEdit()
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").AddNew()
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Codigo")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descripcion") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Descripcion")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Base") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Monto_Flete") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Monto_Flete")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("OtrosCargos") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("OtrosCargos")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Costo") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Costo")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Cantidad") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Cantidad")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Gravado") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Gravado")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Exento") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Exento")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descuento_P") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Descuento")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descuento") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Descuento")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto_P") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Impuesto")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Impuesto") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("Impuesto")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Total") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("TotalCompra")
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("NuevoCostoBase") = BindingContext(DataSetCompras, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario")


            Dim Link As New Conexion
            Dim Articulo As SqlDataReader
            Articulo = Link.GetRecorset(Link.Conectar, "SELECT Inventario.Precio_A, Inventario.Precio_B, Inventario.Precio_C, Inventario.Precio_D FROM Inventario where  (cast(codigo as varchar) = '" & BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") & "' or  Barras = '" & BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") & "')" & "and Inhabilitado = 0 and Servicio = 0")
            If Articulo.Read Then
                TxtPrecioVenta_A.Text = Articulo!precio_A
                TxtPrecioVenta_B.Text = Articulo!precio_B
                TxtPrecioVenta_C.Text = Articulo!precio_C
                TxtPrecioVenta_D.Text = Articulo!precio_d
            Else

                BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").CancelCurrentEdit()
                MsgBox("No existe un artículo con ese código o está inhabilitado", MsgBoxStyle.Exclamation)
            End If

            Link.DesConectar(Link.sQlconexion)
            BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").EndCurrentEdit()
            Calcular_Totales_Compras()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cargar_Detalle_Importacion_orden_Compra()
        Indicador_Posicion = Indicador_Posicion + 1

        If Finalizado_Importacion Then Exit Sub

        Timer1.Enabled = False
        Try
            If Me.Lote Then
                Me.TbNumero.Focus()
            Else
                CBMonedaVenta.SelectedIndex = 1
                CBMonedaVenta.SelectedIndex = 0

                Panel_Centrar()
                CBMonedaVenta.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Timer1.Enabled = False
        End Try

        Timer1.Enabled = False
    End Sub
    Private Sub imprimir()
        Try

            If Me.Lotes.Count > 0 Then
                If MsgBox("Desea Imprimir los codigos de barras y sus lotes.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Me.ImprimirLotes()
                End If
            End If

            ToolBar1.Buttons(4).Enabled = False
            Dim compra_reporte As New Reporte_Compra
            compra_reporte.SetParameterValue(0, CDbl(Label44.Text))
            CrystalReportsConexion.LoadShow(compra_reporte, MdiParent)
            ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Eliminar_Factura_Compra()
        Dim resp As Integer
        Dim con As New Conexion
        Try 'se intenta hacer
            If BindingContext(DataSetCompras, "compras").Count > 0 Then   ' si hay ubicaciones

                If BindingContext(DataSetCompras.compras).Current("FacturaCancelado") = True Then
                    MsgBox("Esta Factura de Compra ya ha sido Cancelada, No se puede eliminar porque forma parte del Historial", MsgBoxStyle.Exclamation)
                    Exit Sub
                    ' si el saldo de la factura es distindo del total, osea si la factura ya tiene movimientos
                End If
                If BindingContext(DataSetCompras.compras).Current("TipoCompra") = "CRE" And Math.Round(CDbl(con.SQLExeScalar("Select dbo.SaldoFacturaCompra ('" & Now.Date & "'," & TxtFacturaCompraN.Text & "," & ComboBoxProvedor.SelectedValue & ")")), 2) <> CDbl(txtmontofact.Text) Then
                    MsgBox("Esta Factura de Compra tiene abonos, no se puede eliminar", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                resp = MessageBox.Show("¿Desea eliminar esta Factura de compra ?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Dim Transaccion As SqlTransaction
                    Try

                        ToolBar1.Buttons(2).Enabled = False
                        If SqlConnection.State <> SqlConnection.State.Open Then SqlConnection.Open()
                        Transaccion = SqlConnection.BeginTransaction
                        'Se crea la transaccion & se asigna a los commandos
                        AdapterCompras.UpdateCommand.Transaction = Transaccion
                        AdapterCompras.DeleteCommand.Transaction = Transaccion

                        'Transacciones en Articulos comprados 
                        AdapterArticulos_Comprados.UpdateCommand.Transaction = Transaccion
                        AdapterArticulos_Comprados.DeleteCommand.Transaction = Transaccion

                        'Transacciones en Lotes 
                        Me.AdapterLotes.UpdateCommand.Transaction = Transaccion
                        Me.AdapterLotes.DeleteCommand.Transaction = Transaccion

                        BindingContext(DataSetCompras, "compras").RemoveAt(BindingContext(DataSetCompras, "compras").Position)
                        BindingContext(DataSetCompras, "compras").EndCurrentEdit()

                        Me.AdapterLotes.Update(DataSetCompras, "Lotes")
                        AdapterArticulos_Comprados.Update(DataSetCompras, "articulos_comprados")
                        AdapterCompras.Update(DataSetCompras, "compras")

                        Transaccion.Commit()
                        MsgBox("Los datos se Eliminaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
                        DataSetCompras.articulos_comprados.Clear()
                        DataSetCompras.Lotes.Clear()
                        DataSetCompras.compras.Clear()
                        DataSetCompras.detalle_ordencompra.Clear()
                        ComboBoxProvedor.Text = ""
                        TxtTotalFactura.Text = "0.00"
                        ToolBar1.Buttons(2).Enabled = True
                        txtClave.Text = ""
                        TxtNombreUsuario.Text = ""
                        txtClave.Focus()
                        txtClave.Enabled = False
                        GroupBox1.Enabled = False
                        GroupBoxOpcionesCompras.Enabled = False
                        GroupBoxDetalleArticulo.Enabled = False
                        ComboMonedaCompra.Enabled = True
                        Importando = False
                        Finalizado_Importacion = False
                        'ErrorProvider.Dispose()

                    Catch ex As Exception
                        Transaccion.Rollback()
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta...")
                    End Try

                End If
            Else
                MsgBox("No ha seleccionado facturas de compras para eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub RegistrarEliminar()
        Dim Transaccion As SqlTransaction
        Try
            ToolBar1.Buttons(2).Enabled = False
            If SqlConnection.State <> SqlConnection.State.Open Then SqlConnection.Open()
            Transaccion = SqlConnection.BeginTransaction
            'Se crea la transaccion & se asigna a los commandos

            'Me.AdapterCompras.UpdateCommand.Transaction = Transaccion
            'Me.AdapterCompras.DeleteCommand.Transaction = Transaccion

            'Me.AdapterArticulos_Comprados.UpdateCommand.Transaction = Transaccion  'Transacciones en Articulos comprados 
            'Me.AdapterArticulos_Comprados.DeleteCommand.Transaction = Transaccion

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            BindingContext(DataSetCompras, "compras").RemoveAt(BindingContext(DataSetCompras, "compras").Position)
            Me.AdapterLotes.Update(DataSetCompras, "Compras")
            AdapterArticulos_Comprados.Update(DataSetCompras, "Compras")
            AdapterCompras.Update(DataSetCompras, "compras")
            '-----------------------------------------------------------------------------------
            Transaccion.Commit()
            DataSetCompras.AcceptChanges()

            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()

            Transaccion.Dispose()
            ToolBar1.Buttons(2).Enabled = True
            txtClave.Text = ""
            TxtNombreUsuario.Text = ""
            txtClave.Focus()
            txtClave.Enabled = False
            GroupBox1.Enabled = False
            GroupBoxOpcionesCompras.Enabled = False
            GroupBoxDetalleArticulo.Enabled = False
            ComboMonedaCompra.Enabled = True
            Importando = False
            Finalizado_Importacion = False


        Catch ex As Exception
            Transaccion.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            ToolBar1.Buttons(2).Enabled = True
        End Try
    End Sub



    'LFCHG 13/12/2006
    'AGREGUE LA FUNCION DE REGISTARDB PARA SEPARAR EN CASO DE ERROR.
    Function ResgistrarDb() As Boolean
        Dim Transaccion As SqlTransaction
        Try
            If SqlConnection.State <> SqlConnection.State.Open Then SqlConnection.Open()

            Transaccion = SqlConnection.BeginTransaction
            Calcular_Totales_Compras()
            BindingContext(DataSetCompras, "compras").EndCurrentEdit()

            AdapterCompras.UpdateCommand.Transaction = Transaccion
            AdapterCompras.InsertCommand.Transaction = Transaccion
            AdapterCompras.DeleteCommand.Transaction = Transaccion

            AdapterLotes.UpdateCommand.Transaction = Transaccion
            AdapterLotes.DeleteCommand.Transaction = Transaccion
            AdapterLotes.InsertCommand.Transaction = Transaccion

            AdapterArticulos_Comprados.UpdateCommand.Transaction = Transaccion
            AdapterArticulos_Comprados.DeleteCommand.Transaction = Transaccion
            AdapterArticulos_Comprados.InsertCommand.Transaction = Transaccion

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....

            pbuscar = TxtFacturaCompraN.Text
            txtComboTipoF = ComboTipoF.Text

            AdapterCompras.Update(DataSetCompras.compras)
            'AdapterLotes.Update(DataSetCompras.Lotes)
            AdapterArticulos_Comprados.Update(DataSetCompras.articulos_comprados)
            '-----------------------------------------------------------------------------------
            Transaccion.Commit()

            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim IdCompra As String = BindingContext(DataSetCompras, "Compras").Current("Id_Compra")

            For Each r As Lote In Me.Lotes
                If r.Id > 0 Then
                    'db.Ejecutar("", CommandType.Text)
                Else
                    db.Ejecutar("Insert into ControlLotes(IdReferencia, Lote, Barras, Vence, Codigo, Cantidad, Actual) Values(" & IdCompra & ", '" & r.Lote & "', '" & r.Barras & "', '" & r.Vence & "', " & r.Codigo & ", " & r.Cantidad & ", " & r.Cantidad & ")", CommandType.Text)
                    'db.Ejecutar("Update Inventario Set Barras = '" & r.Barras & "' Where Codigo = " & r.Codigo, CommandType.Text)
                End If
            Next

            Dim dtLotes As New DataTable
            Me.Lotes.Clear()
            cFunciones.Llenar_Tabla_Generico("Select c.Id, c.Lote, c.Vence, c.Codigo, i.Descripcion, CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones as Presentacion , c.Barras, c.Cantidad from ControlLotes c inner join Inventario i on c.Codigo = i.Codigo inner join Presentaciones p on i.CodPresentacion = p.CodPres Where c.IdReferencia = " & IdCompra, dtLotes, CadenaConexionSeePOS)
            For Each r As DataRow In dtLotes.Rows
                Me.Lotes.Add(New Lote(r.Item("Id"), r.Item("Lote"), r.Item("Vence"), r.Item("Codigo"), r.Item("Descripcion"), r.Item("Presentacion"), r.Item("Barras"), r.Item("Cantidad"), r.Item("Cantidad")))
            Next

            MsgBox("Los datos se actualiazaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            Return True
        Catch ex As Exception
            Transaccion.Rollback()
            'If Err.Number = 5 Then
            '    MsgBox("Esta Factura ya existe!", MsgBoxStyle.Information)
            '    ToolBar1.Buttons(2).Enabled = True
            '    Return False
            '    Exit Try
            'End If
            MsgBox(ex.ToString, MsgBoxStyle.Information)
            ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try

    End Function

    Private Sub Rutina_SumarProductosXlotes()
        Try
            Dim dataTBL As New DataTable
            Dim sdDataAdapter As New SqlDataAdapter
            Dim Fx As New cFunciones
            Dim Ejecutar As New Conexion

            Dim Sql As String = "select lote,Vence,sum(Cantidad) as Cantidad ,sum(Cantidad) as Cantidad,FechaIngreso, Codigo,compras.Factura   from compras, articulos_comprados where compras.Id_Compra = articulos_comprados.IdCompra   and compras.Factura =" & pbuscar & "  group by lote,Vence,FechaIngreso, Codigo,compras.Factura "
            Fx.Llenar_Tabla_Generico(Sql, dataTBL, "")

            For nfila As Integer = 0 To dataTBL.Rows.Count - 1
                Dim IdLote As String = dataTBL.Rows(nfila)("lote").ToString
                Dim vence As String = dataTBL.Rows(nfila)("Vence").ToString
                Dim Cantidad As String = dataTBL.Rows(nfila)("Cantidad").ToString
                Dim Cantidad2 As String = dataTBL.Rows(nfila)("Cantidad").ToString
                Dim FechaIngreso As String = dataTBL.Rows(nfila)("FechaIngreso").ToString
                Dim Codigo As String = dataTBL.Rows(nfila)("Codigo").ToString
                Dim Factura As String = dataTBL.Rows(nfila)("Factura").ToString
                Dim strconexion As String = CadenaConexionSeePOS()
                Dim SrtDatos As String = "'" & IdLote & "','" & vence & "'," & Cantidad & "," & Cantidad & ",'" & FechaIngreso & "'," & Codigo & "," & Factura & ",'" & txtComboTipoF & "'"
                Ejecutar.AddNewRecord("Lotes", "Numero,Vencimiento,Cant_Inicial,Cant_Actual,Fecha_Entrada,Cod_Articulo,Documento,Tipo", SrtDatos)

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Registrar()

        If Me.ValidarPrecios() = False Then
            Exit Sub
        End If

        Try
            If buscar_con_orden() = False Then
                Exit Sub
            End If
            If MsgBox("Desea Proceder a registrar la factura de Compra...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.No Then Exit Sub

            If IsNumeric(TxtPrecioVenta_A.Text) And IsNumeric(TxtPrecioVenta_B.Text) And IsNumeric(TxtPrecioVenta_C.Text) And IsNumeric(TxtPrecioVenta_D.Text) Then

                BindingContext(DataSetCompras, "compras").Current("TipoCambio") = CDec(TextBoxMonedaCompra.Text)
                BindingContext(DataSetCompras, "compras").EndCurrentEdit()

                ToolBar1.Buttons(2).Enabled = False
                If Not ResgistrarDb() Then
                    Exit Sub
                End If
                actualizar_prov()
                DataSetCompras.Lotes.AcceptChanges()
                DataSetCompras.articulos_comprados.AcceptChanges()
                DataSetCompras.compras.AcceptChanges()

                DataSetCompras.articulos_comprados.Clear()
                DataSetCompras.Lotes.Clear()
                DataSetCompras.compras.Clear()
                DataSetCompras.detalle_ordencompra.Clear()
                ComboBoxProvedor.Text = ""
                TxtTotalFactura.Text = "0.00"
                ToolBar1.Buttons(2).Enabled = True
                txtClave.Text = ""
                TxtNombreUsuario.Text = ""
                txtClave.Focus()
                txtClave.Enabled = False
                GroupBox1.Enabled = False
                GroupBoxOpcionesCompras.Enabled = False
                GroupBoxDetalleArticulo.Enabled = False
                ComboMonedaCompra.Enabled = True
                Importando = False
                Finalizado_Importacion = False
                'ErrorProvider.Dispose()

                Nueva_Compra()
                Rutina_SumarProductosXlotes()

                If Me.Lotes.Count > 0 Then
                    If MsgBox("Desea Imprimir las Etiquetas con sus Lotes", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                        Me.ImprimirLotes()
                    End If
                End If

            Else
                MsgBox("Existen valores no numéricos en los precios de venta, debe corregirlos", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            ToolBar1.Buttons(2).Enabled = True
        End Try


    End Sub
    Private Sub Txthechox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                Dim Link As New Conexion
                Dim Registros As SqlDataReader

                Registros = Link.GetRecorset(Link.Conectar, "Select Cedula,Nombre from usuarios where Clave_Interna ='" & txtClave.Text & "'")

                If Registros.Read Then
                    TxtNombreUsuario.Text = Registros!Nombre
                    TxtIDUsuario.Text = Registros!cedula
                End If

                Link.DesConectar(Link.sQlconexion)
                Registros = Nothing
            Else
                txtClave.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try


    End Sub

    Private Sub ComboBoxProvedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxProvedor.KeyDown
        Try
            Select Case e.KeyCode
                Case txtCodArticulo.Name : CargarInformacion_articulos(sender.text)
                    If txtdescripcion.Text = "" Then MsgBox("Debe de digitar un artículo... o la descripción no puede estar vacia..", MsgBoxStyle.Critical, "") Else SendKeys.Send("{TAB}")
                Case Keys.F1
                    Dim Fx As New cFunciones
                    Dim valor As String
                    valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                    If valor = "" Then
                        ComboBoxProvedor.SelectedIndex = -1
                    Else
                        ComboBoxProvedor.SelectedValue = valor
                        BindingContext(DataSetCompras, "compras").Current("CodigoProv") = valor
                    End If
                Case Keys.Enter
                    Me.txt_num_orden.Focus()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try

    End Sub
    Private Sub Eliminar_Articulo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Count > 0 Then   ' si hay ubicaciones
                'resp = MessageBox.Show("¿Desea eliminar este artículo de la Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").RemoveAt(BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Position)
                    'BindingContext(DataSetCompras, "Lotes").RemoveAt(BindingContext(DataSetCompras, "Lotes").Position)
                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").EndCurrentEdit()
                    BindingContext(DataSetCompras, "Lotes").EndCurrentEdit()
                    Calcular_Totales_Compras()
                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").EndCurrentEdit()
                    'BindingContext(DataSetCompras, "Lotes").EndCurrentEdit()
                Else
                    BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").CancelCurrentEdit()
                    BindingContext(DataSetCompras, "Lotes").CancelCurrentEdit()
                End If
            Else
                MsgBox("El item seleccionado ya no existe en registros...", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub GridControlDetalleCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControlDetalleCompra.KeyDown
        Try

            If e.KeyCode = Keys.Delete Then Eliminar_Articulo_Detalle()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If ToolBarNuevo.Text = "Cancelar" Then
            If Keys.Enter = Asc(e.KeyChar) Then
                buscar_datos_usuario()
            End If
        End If
    End Sub
    Private Sub buscar_datos_usuario()
        Try
            Dim Datos(), Dato As DataRow
            Dim DV As DataView
            Datos = DataSetCompras.Usuarios.Select("Clave_Interna ='" & txtClave.Text & "'")
            If Datos.Length <> 0 Then
                Dato = Datos(0)
                TxtNombreUsuario.Text = Dato("Nombre")
                TxtIDUsuario.Text = Dato("Cedula")
                strCedula = Dato("Cedula")
                GroupBox1.Enabled = True
                ToolBar1.Buttons(5).Enabled = True
                ToolBarExcel.Visible = VerificandoAcceso_a_Modulos("frmEtiquetasProductos", "Etiquetas de Artículos", strCedula, "Inventarios")
                'Me.ComboBoxProvedor.Focus()
                LookUpEdit_Proveedor.Focus()
            Else
                txtClave.Text = ""
                txtClave.Focus()
            End If

            ErrorProvider.SetError(TxtFacturaCompraN, "")
            ErrorProvider.SetError(ComboTipoF, "")
            ErrorProvider.SetError(ComboBoxProvedor, "")
            ErrorProvider.SetError(ComboMonedaCompra, "")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub TxtTotalFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalFactura.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            GroupBox2.Enabled = True
            ' TxtFacturaCompraN.Focus()
            ' SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub ComboTipoF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboTipoF.KeyPress
        Try
            If Keys.Enter = Asc(e.KeyChar) Then
                DTP_FechaCompra.Focus()
                Exit Sub
            End If
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Function GetPorcentajeImpuesto(_Cod As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select IVenta from inventario where codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("IVenta")
        End If
    End Function

    Private Sub TxtPrecioVenta_A_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioVenta_A.KeyPress, TxtPrecioVenta_B.KeyPress, TxtPrecioVenta_C.KeyPress, TxtPrecioVenta_D.KeyPress, TxtPrecioVenta_IV_A.KeyPress, TxtPrecioVenta_IV_B.KeyPress, TxtPrecioVenta_IV_C.KeyPress, TxtPrecioVenta_IV_D.KeyPress, TxtUtilidad_A.KeyPress, TxtUtilidad_B.KeyPress, TxtUtilidad_C.KeyPress, TxtUtilidad_D.KeyPress, TxtBase.KeyPress, TxtFlete.KeyPress, TxtOtros.KeyPress
        Dim TempFleOtros As Double
        Try

            Dim PorcentajeImpuestos As Decimal = Me.GetPorcentajeImpuesto(TxtCodArt.Text)

            TempFleOtros = (CDbl(TxtFleteEquivalente.Text) + CDbl(TxtOtrosCargosEquivalente.Text))          'If cargando = True Then Exit Sub
            If Keys.Enter = Asc(e.KeyChar) Then
                Select Case sender.Name
                    Case TxtUtilidad_A.Name
                        'TxtPrecioVenta_A.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_A.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_A.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_A.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_A.Text = (TxtPrecioVenta_A.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_A.Text
                        SendKeys.Send("{TAB}")
                    Case TxtUtilidad_B.Name
                        'TxtPrecioVenta_B.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_B.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_B.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_B.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_B.Text = (TxtPrecioVenta_B.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_B.Text
                        SendKeys.Send("{TAB}")
                    Case TxtUtilidad_C.Name
                        'TxtPrecioVenta_C.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_C.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_C.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_C.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_C.Text = (TxtPrecioVenta_C.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_C.Text
                        SendKeys.Send("{TAB}")
                    Case TxtUtilidad_D.Name
                        'TxtPrecioVenta_D.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_D.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_D.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_D.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_D.Text = (TxtPrecioVenta_D.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_D.Text
                        SendKeys.Send("{TAB}")

                        'calculo de de utilidad por el precio A y calculo del precio com I.V.
                    Case TxtPrecioVenta_A.Name
                        'TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_A.Text = (TxtPrecioVenta_A.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + (TxtPrecioVenta_A.Text)
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_B.Name
                        TxtUtilidad_B.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_B.Text = (TxtPrecioVenta_B.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_B.Text
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_C.Name
                        TxtUtilidad_C.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_C.Text = (TxtPrecioVenta_C.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_C.Text
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_D.Name
                        TxtUtilidad_D.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_D.Text = (TxtPrecioVenta_D.Text - TempFleOtros) * (PorcentajeImpuestos / 100) + TxtPrecioVenta_D.Text
                        SendKeys.Send("{TAB}")
                        'CALCULO DE PRECIO DE VENTA Y RECALCULAR LA  UTILIDAD CON BASE A LOS NUEVOS PRECIOS 
                    Case TxtPrecioVenta_IV_A.Name
                        TxtPrecioVenta_A.Text = (TxtPrecioVenta_IV_A.Text - TempFleOtros) / (1 + (PorcentajeImpuestos / 100)) + TempFleOtros
                        TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_IV_B.Name
                        TxtPrecioVenta_B.Text = (TxtPrecioVenta_IV_B.Text - TempFleOtros) / (1 + (PorcentajeImpuestos / 100)) + TempFleOtros
                        TxtUtilidad_B.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_IV_C.Name
                        TxtPrecioVenta_C.Text = (TxtPrecioVenta_IV_C.Text - TempFleOtros) / (1 + (PorcentajeImpuestos / 100)) + TempFleOtros
                        TxtUtilidad_C.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_IV_D.Name
                        TxtPrecioVenta_D.Text = (TxtPrecioVenta_IV_D.Text - TempFleOtros) / (1 + (PorcentajeImpuestos / 100)) + TempFleOtros
                        TxtUtilidad_D.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                        'calculo de precios por la utilidad
                    Case TxtBase.Name
                        TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        CalcularEquivalenciaMoneda()

                    Case TxtFlete.Name
                        TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        CalcularEquivalenciaMoneda()

                    Case TxtOtros.Name
                        TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        CalcularEquivalenciaMoneda()


                End Select

                'If Salto Then SendKeys.Send("{TAB}")
            End If


            If Not IsNumeric(sender.text & e.KeyChar) Then
                If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                    e.Handled = True  ' esto invalida la tecla pulsada
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Private Sub EjecutarCalculos()
        Try
            If cargando = True Then Exit Sub

            Dim Evento As New System.Windows.Forms.KeyPressEventArgs(Chr(Keys.Enter))
            Salto = False
            DolarVenta()
            TxtPrecioVenta_A_KeyPress(TxtPrecioVenta_A, Evento)
            TxtPrecioVenta_A_KeyPress(TxtPrecioVenta_B, Evento)
            TxtPrecioVenta_A_KeyPress(TxtPrecioVenta_C, Evento)
            TxtPrecioVenta_A_KeyPress(TxtPrecioVenta_D, Evento)

            Salto = True
            'TxtImpuesto.Enabled = IIf(CheckBox1.Checked, False, True)

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub DolarVenta()
        Try

            Dim Link As New Conexion
            TextBoxValorMonedaEnVenta.Clear()
            TextBoxValorMonedaEnVenta.Text = CDbl(Link.SQLExeScalar("Select isnull(max(ValorCompra),0) from moneda where codmoneda = " & CBMonedaVenta.SelectedValue))
            Link.DesConectar(Link.sQlconexion)
            CalcularEquivalenciaMoneda()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Private Sub TxtPrecioVenta_A_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrecioVenta_A.LostFocus, TxtPrecioVenta_B.LostFocus, TxtPrecioVenta_C.LostFocus, TxtPrecioVenta_D.LostFocus, TxtPrecioVenta_IV_A.LostFocus, TxtPrecioVenta_IV_B.LostFocus, TxtPrecioVenta_IV_C.LostFocus, TxtPrecioVenta_IV_D.LostFocus, TxtUtilidad_A.LostFocus, TxtUtilidad_B.LostFocus, TxtUtilidad_C.LostFocus, TxtUtilidad_D.LostFocus, TxtBase.LostFocus, TxtFlete.LostFocus, TxtOtros.LostFocus
        'Try

        '    Select Case sender.Name
        '        Case TxtBase.Name
        '            TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
        '            CalcularEquivalenciaMoneda()
        '            TxtFlete.Focus()
        '            ' SendKeys.Send("{TAB}")
        '        Case TxtFlete.Name
        '            TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
        '            CalcularEquivalenciaMoneda()
        '            TxtOtros.Focus()
        '        Case TxtOtros.Name
        '            TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
        '            CalcularEquivalenciaMoneda()
        '            Descuento_Porcentaje_Detalle.Focus()


        '            'calculo de precios por la utilidad
        '        Case TxtUtilidad_A.Name
        '            TxtPrecioVenta_A.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_A.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
        '            TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_A.Text

        '        Case TxtUtilidad_B.Name
        '            TxtPrecioVenta_B.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_B.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
        '            TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_B.Text

        '        Case TxtUtilidad_C.Name
        '            TxtPrecioVenta_C.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_C.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
        '            TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_C.Text

        '        Case TxtUtilidad_D.Name
        '            TxtPrecioVenta_D.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_D.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
        '            TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_D.Text


        '            'calculo de de utilidad por el precio A y calculo del precio com I.V.
        '        Case TxtPrecioVenta_A.Name
        '            TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
        '            TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_A.Text

        '        Case TxtPrecioVenta_B.Name
        '            TxtUtilidad_B.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
        '            TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_B.Text

        '        Case TxtPrecioVenta_C.Name
        '            TxtUtilidad_C.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
        '            TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_C.Text

        '        Case TxtPrecioVenta_D.Name
        '            TxtUtilidad_D.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
        '            TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_D.Text


        '            'CALCULO DE PRECIO DE VENTA Y RECALCULAR LA  UTILIDAD CON BASE A LOS NUEVOS PRECIOS 
        '        Case TxtPrecioVenta_IV_A.Name
        '            TxtPrecioVenta_A.Text = TxtPrecioVenta_IV_A.Text / (1 + (TxtImpuesto_Porcentaje.Text / 100))
        '            TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

        '        Case TxtPrecioVenta_IV_B.Name
        '            TxtPrecioVenta_B.Text = TxtPrecioVenta_IV_B.Text / (1 + (TxtImpuesto_Porcentaje.Text / 100))
        '            TxtUtilidad_B.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

        '        Case TxtPrecioVenta_IV_C.Name
        '            TxtPrecioVenta_C.Text = TxtPrecioVenta_IV_C.Text / (1 + (TxtImpuesto_Porcentaje.Text / 100))
        '            TxtUtilidad_C.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

        '        Case TxtPrecioVenta_IV_D.Name
        '            TxtPrecioVenta_D.Text = TxtPrecioVenta_IV_D.Text / (1 + (TxtImpuesto_Porcentaje.Text / 100))
        '            TxtUtilidad_D.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

        '    End Select
        '    'If Salto Then SendKeys.Send("{TAB}")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        'End Try
    End Sub
    Private Sub CalcularEquivalenciaMoneda()
        If cargando = True Then Exit Sub
        Try
            TxtBaseEquivalente.Text = TxtBase.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
            TxtFleteEquivalente.Text = TxtFlete.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
            TxtOtrosCargosEquivalente.Text = TxtOtros.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
            TxtCostoEquivalente.Text = TxtCosto.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub CBMonedaVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMonedaVenta.SelectedIndexChanged
        If CBMonedaVenta.SelectedIndex > -1 Then DolarVenta()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try

            If CheckBox1.Checked = True Then
                txtmontofact.Properties.ReadOnly = False
            Else
                txtmontofact.Properties.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Private Sub TxtImpuesto_Porcentaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImpuesto_Porcentaje.TextChanged
        TxtImpuesto_Monto.Text = IIf(Not IsNumeric(TxtGravado.Text), 0, TxtGravado.Text) * (IIf(Not IsNumeric(TxtImpuesto_Porcentaje.Text), 0, TxtImpuesto_Porcentaje.Text) / 100)
    End Sub

    Private Sub TxtImpuesto_Porcentaje_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtImpuesto_Porcentaje.KeyDown
        Try
            'Meteraldetalle
            Calcular_Monto()

            If e.KeyCode = Keys.Enter Then

                If Me.ValidaCodCabys(Me.txtCodCabys.Text) = False Then
                    MsgBox("Codigo cabys ingresado no existe", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                    Exit Sub
                End If

                If CDec(Me.TxtCantidad.Text) = 0 And CDec(Me.TxtRegalias.Text) > 0 Then
                    'es una bonificacion
                    Me.boton_agregar_Detalle()
                Else
                    If Me.Ver = False Then
                        If Me.Lote Then
                            Me.TbNumero.Focus()
                        Else
                            Me.Ver = False
                            Panel_Centrar()
                            VerificarAntiguoPrecioCosto()
                            CBMonedaVenta.Focus()
                        End If
                    Else
                        Me.Ver = False
                        Panel_Centrar()
                        VerificarAntiguoPrecioCosto()
                        CBMonedaVenta.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    ' SAJ Verifica el precio de costo para avisar el este vario con referente al registrado en el Inventario.
    Private Sub VerificarAntiguoPrecioCosto()
        Try
            Dim CostoAnterior As Double
            Dim x As New Conexion
            CostoAnterior = Math.Round(CDbl(x.SlqExecuteScalar(x.Conectar, "SELECT Costo FROM Inventario WHERE Codigo = " & TxtCodArt.Text)), 5)
            Select Case Math.Round(CDbl(TxtCostoReal.Text), 5)
                Case Is < CostoAnterior
                    Label48.BackColor = System.Drawing.Color.Green
                    Label48.Text = "< Reg. Inv."
                Case Is > CostoAnterior
                    Label48.BackColor = System.Drawing.Color.Red
                    Label48.Text = "> Reg. Inv."
                Case Is = CostoAnterior
                    Label48.BackColor = System.Drawing.Color.RoyalBlue
                    Label48.Text = ""
            End Select
            x.DesConectar(x.sQlconexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Public Sub CargarCompradesdeAfuera(Id_Compra As String)
        Try
            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()
            ToolBar1.Buttons(2).Enabled = True
            ToolBar1.Buttons(3).Enabled = True
            ToolBar1.Buttons(4).Enabled = True
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            BindingContext(DataSetCompras, "compras").CancelCurrentEdit()

            GroupBox1.Enabled = True
            GroupBoxOpcionesCompras.Enabled = True
            GroupBoxDetalleArticulo.Enabled = True

            Llenar_Compras(Id_Compra)
            TxtDias.Text = DateDiff(DateInterval.Day, DTP_FechaCompra.Value, DTP_FechaVence.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private IdCompraTran As Long = 0
    Private Sub BuscarFactura_Compra()
        Try
            If BindingContext(DataSetCompras, "compras").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una factura de compra, si continúa se perderan los datos de la misma, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()

            Dim identificador As Double

            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (convert(Varchar, convert(Bigint,Factura,0),1) + '-' + TipoCompra)as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra"))

            buscando = True

            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Me.IdCompraTran = 0
                Me.txtTrans.Enabled = False
                Me.ckTrans.Enabled = False
                Me.btnAplicar.Enabled = False
                Exit Sub
            End If

            Me.IdCompraTran = identificador
            Me.txtTrans.Enabled = True
            Me.ckTrans.Enabled = True
            Me.btnAplicar.Enabled = True

            Dim dtLotes As New DataTable
            Me.Lotes.Clear()
            cFunciones.Llenar_Tabla_Generico("Select c.Id, c.Lote, c.Vence, c.Codigo, i.Descripcion, CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones as Presentacion , c.Barras, c.Cantidad from ControlLotes c inner join Inventario i on c.Codigo = i.Codigo inner join Presentaciones p on i.CodPresentacion = p.CodPres Where c.IdReferencia = " & identificador, dtLotes, CadenaConexionSeePOS)
            For Each r As DataRow In dtLotes.Rows
                Me.Lotes.Add(New Lote(r.Item("Id"), r.Item("Lote"), r.Item("Vence"), r.Item("Codigo"), r.Item("Descripcion"), r.Item("Presentacion"), r.Item("Barras"), r.Item("Cantidad"), r.Item("Cantidad")))
            Next

            Dim dtTrans As New DataTable
            Try
                cFunciones.Llenar_Tabla_Generico("Select Trans, NumTrans from Compras Where Id_Compra = " & identificador, dtTrans, CadenaConexionSeePOS)
                If dtTrans.Rows.Count > 0 Then
                    Me.txtTrans.Text = dtTrans.Rows(0).Item("NumTrans")
                    Me.ckTrans.Checked = dtTrans.Rows(0).Item("Trans")
                End If
            Catch ex As Exception
            End Try

            DataSetCompras.articulos_comprados.Clear()
            DataSetCompras.Lotes.Clear()
            DataSetCompras.compras.Clear()
            ToolBar1.Buttons(2).Enabled = True
            ToolBar1.Buttons(3).Enabled = True
            ToolBar1.Buttons(4).Enabled = True
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            BindingContext(DataSetCompras, "compras").CancelCurrentEdit()

            GroupBox1.Enabled = True
            GroupBoxOpcionesCompras.Enabled = True
            GroupBoxDetalleArticulo.Enabled = True

            Llenar_Compras(identificador)
            Me.PoneUtilidad()
            TxtDias.Text = DateDiff(DateInterval.Day, DTP_FechaCompra.Value, DTP_FechaVence.Value)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Llenar_Compras(ByVal Id As Double)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR COMPRAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Compras WHERE (Id_Compra = @Id_Factura) "

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
            dv.Fill(DataSetCompras, "compras")
            LookUpEdit_Proveedor.EditValue = ComboBoxProvedor.SelectedValue
            LookUpEdit_Proveedor.ClosePopup()

            '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            'Dim sConn As String = CadenaConexionSeePOS
            'cnn = New SqlConnection(sConn)
            'cnn.Open()

            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM articulos_comprados WHERE (IdCompra = @Id_Factura) "

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
            da.Fill(DataSetCompras.articulos_comprados)

            'Lotes
            Dim cml As SqlCommand = New SqlCommand
            sel = "SELECT * FROM Lotes WHERE (Tipo = 'COM' AND Documento = @Id_Factura) "

            cml.CommandText = sel
            cml.Connection = cnnv
            cml.CommandType = CommandType.Text
            cml.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cml.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cml.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dal As New SqlDataAdapter
            dal.SelectCommand = cml
            ' Llenamos la tabla
            dal.Fill(DataSetCompras.Lotes)


            'En caso de estar ya facturada la factura, entonces lo indicamos..
            If DataSetCompras.compras.Rows(0)("facturaCancelado") = True Then
                Me.labelCanceladoFactura.Visible = True
            Else
                Me.labelCanceladoFactura.Visible = False
            End If


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
    Private Sub txtimpuesto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtimpuesto.Leave
        Try
            Calcular_Totales_Compras()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub ComboMonedaCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboMonedaCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboMonedaCompra.Enabled = False
            GroupBoxDetalleArticulo.Enabled = True
            txtCodArticulo.Focus()
        End If
    End Sub
    Private Sub TxtTotalFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotalFactura.KeyDown
        If e.KeyCode = Keys.Enter Then
            GroupBoxOpcionesCompras.Enabled = True
            TxtFacturaCompraN.Focus()
            ' SendKeys.Send("{TAB}")
        End If
    End Sub
#Region "Validacion de datos..."
    Private Sub ComboMonedaCompra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboMonedaCompra.Validating
        If ComboMonedaCompra.Text = "" And Me.ComboMonedaCompra.Enabled = True Then
            ErrorProvider.SetError(sender, "Debe de seleccionar una Moneda de Compra...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
        End If
    End Sub
    Private Sub ComboBoxProvedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBoxProvedor.Validating
        If ComboBoxProvedor.Text = "" And ComboBoxProvedor.Enabled = True Then
            ErrorProvider.SetError(sender, "Debe de seleccionar un Proveedor...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
        End If
    End Sub
    Private Sub TxtFacturaCompraN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtFacturaCompraN.Validating
        If Not IsNumeric(TxtFacturaCompraN.Text) Then
            ErrorProvider.SetError(sender, "Digite un numero de factura de compra Válido...")
            TxtFacturaCompraN.Focus()

        ElseIf CDbl(TxtFacturaCompraN.Text) <= 0 Then
            ErrorProvider.SetError(sender, "Digite un numero de factura de compra Válido...")
            TxtFacturaCompraN.Focus()

        Else
            ErrorProvider.SetError(sender, "")
        End If
    End Sub
    Private Sub ComboTipoF_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboTipoF.Validating
        If ComboTipoF.Enabled = True Then
            If ComboTipoF.Text = "" Then
                ErrorProvider.SetError(sender, "Debe de seleccionar un Proveedor...")
                e.Cancel = True
            Else
                ErrorProvider.SetError(sender, "")
            End If
        End If
    End Sub
#End Region
    Private Sub TxtFacturaCompraN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFacturaCompraN.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If validar_num_factura() Then
                    ComboTipoF.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Function validar_num_factura()
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from compras where Factura = " & Me.TxtFacturaCompraN.Text & " and CodigoProv = " & LookUpEdit_Proveedor.Text, dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            MsgBox("El número de factura ya existe con este proveedor, por favor verificar la información.", MsgBoxStyle.Critical, "Número de factura invalido")
            Return False
        End If
        Return True
    End Function
    Private Sub LookUpEdit_Proveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdit_Proveedor.EditValueChanged
        Try
            If LookUpEdit_Proveedor.Text <> "" Then
                ComboBoxProvedor.SelectedValue = LookUpEdit_Proveedor.Text
                BindingContext(DataSetCompras, "compras").Current("CodigoProv") = LookUpEdit_Proveedor.Text
                LookUpEdit_Proveedor.EditValue = LookUpEdit_Proveedor.Text
            Else
                SendKeys.Send("{F4}")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub LookUpEdit_Proveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LookUpEdit_Proveedor.KeyDown
        Try

            Select Case e.KeyCode
                Case Keys.Enter

                    'Me.ComboBoxProvedor.Focus()

                    If LookUpEdit_Proveedor.Text = "" Then
                        SendKeys.Send("{F4}")
                    Else
                        Dim strCodigo As String = LookUpEdit_Proveedor.EditValue

                        ComboBoxProvedor.SelectedValue = LookUpEdit_Proveedor.EditValue

                        BindingContext(DataSetCompras, "compras").Current("CodigoProv") = LookUpEdit_Proveedor.EditValue

                        TxtTotalFactura.Focus()
                        LookUpEdit_Proveedor.EditValue = CInt(strCodigo)

                    End If



                Case Keys.F1
                    Dim Fx As New cFunciones
                    Dim valor As String
                    valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                    If valor = "" Then
                        LookUpEdit_Proveedor.EditValue = Nothing
                        ComboBoxProvedor.SelectedIndex = -1
                    Else
                        ComboBoxProvedor.SelectedValue = valor
                        LookUpEdit_Proveedor.EditValue = valor
                        LookUpEdit_Proveedor.Text = valor

                        BindingContext(DataSetCompras, "compras").Current("CodigoProv") = valor
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

#Region "Etiquetas"
    Private Sub Etiquetas()
        Try

            If (MsgBox("¿Desea Generar las Etiquetas de estos artículos?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                Dim i As Integer
                Dim cod(150) As Integer
                Dim can(150) As Integer
                Dim CodPro(150) As Integer

                For i = 0 To BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Count - 1
                    BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Position = i
                    cod(i) = TxtCodArt.Text
                    can(i) = TxtCantidad.Text
                    CodPro(i) = ComboBoxProvedor.SelectedValue
                Next i

                Dim frm_Autoetiquetas As New frmEtiquetasProductos(True, cod, can, CodPro)
                frm_Autoetiquetas.Show()
                frm_Autoetiquetas.BringToFront()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Mensaje")
        End Try
    End Sub
#End Region

    Private Sub GroupBoxOpcionesCompras_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBoxOpcionesCompras.EnabledChanged
        If GroupBoxOpcionesCompras.Enabled = True Then
            TxtFacturaCompraN.Focus()
        Else
            TxtFacturaCompraN.Focus()
        End If
    End Sub

#Region "Lotes"

#Region "Activa Manejo"
    Private Sub ActivaLote()
        Me.LOpcion.Text = "Lote ->"
        Me.LOpcion.Visible = True
        Me.LNumero.Visible = True
        Me.TbNumero.Visible = True
        Me.LVencimiento.Visible = True
        Me.DTPVencimiento.Visible = True
        Me.DTPVencimiento.Enabled = True
        CargarCbNumero()
        Me.Lote = True
    End Sub

    Private Sub ActivaNinguno()
        Me.LOpcion.Text = ""
        Me.LOpcion.Visible = False
        Me.LNumero.Visible = False
        Me.TbNumero.Visible = False
        Me.TbNumero.Text = "0"
        Me.LVencimiento.Visible = False
        Me.DTPVencimiento.Visible = False
        Me.Lote = False
    End Sub
#End Region

#Region "Funciones"
    Private Sub CargarCbNumero()
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim i As Integer
        CbNumero.Items.Clear() ' limpia el combo

        Try
            If Me.TxtCodArt.Text <> Nothing Then
                rss = Me.DataSetCompras.Lotes.Select("Cod_Articulo = " & CInt(Me.TxtCodArt.Text) & " AND Vencimiento >= '" & Now.Date & "'")

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
                End If
            Else
                MsgBox("Debe escribir el Código del Artículo", MsgBoxStyle.Critical)
                txtCodArticulo.Focus()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub GuardaLote()
        If Me.Lote = True Then
            BindingContext(DataSetCompras, "Lotes").EndCurrentEdit()
            BindingContext(DataSetCompras, "Lotes").AddNew()
            BindingContext(DataSetCompras, "Lotes").Current("Numero") = TbNumero.Text
            BindingContext(DataSetCompras, "Lotes").Current("Vencimiento") = DTPVencimiento.Value
            BindingContext(DataSetCompras, "Lotes").Current("Cant_Inicial") = CDbl(Me.TxtCantidad.Text) + CDbl(TxtRegalias.Text)
            BindingContext(DataSetCompras, "Lotes").Current("Cant_Actual") = CDbl(Me.TxtCantidad.Text) + CDbl(TxtRegalias.Text)
            BindingContext(DataSetCompras, "Lotes").Current("Fecha_Entrada") = Now
            BindingContext(DataSetCompras, "Lotes").Current("Cod_Articulo") = CInt(Me.TxtCodArt.Text)
            BindingContext(DataSetCompras, "Lotes").Current("Documento") = BindingContext(DataSetCompras, "Compras").Current("Id_Compra")
            BindingContext(DataSetCompras, "Lotes").Current("Tipo") = "COM"
            BindingContext(DataSetCompras, "Lotes").EndCurrentEdit()
        End If
    End Sub


    Function VerificaNumeroBD() As Boolean
        Dim ConNumero As New Conexion
        Dim rs As SqlDataReader

        VerificaNumeroBD = False
        If Me.TbNumero.Text <> "" Then
            rs = ConNumero.GetRecorset(ConNumero.Conectar("SeePos"), "SELECT Numero from Lotes where Cod_Articulo =" & CInt(Me.TxtCodArt.Text))
            While rs.Read
                Try
                    If Me.TbNumero.Text = rs("Numero") Then
                        VerificaNumeroBD = True
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
    End Function

    Function VerificaDataSet() As Boolean
        Dim DrNum() As System.Data.DataRow
        Dim DrNumero As System.Data.DataRow
        Dim i As Integer
        VerificaDataSet = False

        Try
            If Me.DataSetCompras.Lotes.Count > 0 Then
                DrNum = Me.DataSetCompras.Lotes.Select("Cod_Articulo = " & CInt(Me.TxtCodArt.Text))

                If DrNum.Length <> 0 Then 'Si existe
                    For i = 0 To DrNum.Length - 1
                        DrNumero = DrNum(i)
                        If Me.TbNumero.Text = DrNumero("Numero") Then
                            VerificaDataSet = True
                        End If
                    Next i
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Public Sub BuscaArticulo()
        Dim ConNumero As New Conexion
        Dim rs As SqlDataReader

        If Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo") <> 0 Then
            rs = ConNumero.GetRecorset(ConNumero.Conectar("SeePos"), "SELECT Lote from Inventario where Codigo =" & BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo"))
            While rs.Read
                Try
                    If rs("Lotes") = True Then
                        Me.ActivaLote()
                    Else
                        Me.ActivaNinguno()
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


    Private Sub BuscaFecha()
        Dim DrFecha() As System.Data.DataRow
        Dim DrVencimiento As System.Data.DataRow
        Dim i As Integer

        Try
            If Me.TbNumero.Text <> Nothing Then
                DrFecha = Me.DataSetCompras.Lotes.Select("Numero = '" & Me.BindingContext(Me.DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Lote") & "' And Cod_Articulo = " & CInt(Me.TxtCodArt.Text))

                If DrFecha.Length <> 0 Then 'Si existe
                    For i = 0 To DrFecha.Length - 1
                        DrVencimiento = DrFecha(i)
                        Me.DTPVencimiento.Value = DrVencimiento("Vencimiento")
                    Next i
                End If

            Else
                MsgBox("Debe Seleccionar un Número", MsgBoxStyle.Critical)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

    Private Sub TbNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TbNumero.Text <> "" Then
                If VerificaNumeroBD() = False And VerificaDataSet() = False Then
                    Me.BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Lote") = Me.TbNumero.Text
                    Me.DTPVencimiento.Focus()
                Else
                    MsgBox("El número ya existe para este Artículo!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Debe Digitar un Número!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub


    Private Sub DTPVencimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPVencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ver = True
            Panel_Centrar()
            VerificarAntiguoPrecioCosto()
            TxtUtilidad_A.Focus()
        End If
    End Sub


    Private Sub GridControlDetalleCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControlDetalleCompra.Click
        If BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Count > 0 Then
            If BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Lote") <> 0 Then
                ActivaLote()
                TbNumero.Text = BindingContext(DataSetCompras, "compras.ComprasArticulos_Comprados").Current("Lote")
                BuscaFecha()
            Else
                ActivaNinguno()
            End If
        End If
    End Sub
#End Region

    Private Sub CK_impuesto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CK_impuesto.CheckedChanged
        If BindingContext(DataSetCompras, "compras").Count > 0 Then
            txtimpuesto.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtimpuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtimpuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Calcular_Totales_Compras()
        End If
    End Sub
    Private Sub CheckEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckEdit1.Click
        Me.Ck_Mascotas.Checked = False
    End Sub

    Private Sub Ck_Mascotas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ck_Mascotas.Click
        Me.CheckEdit1.Checked = False
    End Sub
    Function buscar_con_orden()
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select codigo,cod_articulo, orden from inventario where Inhabilitado = 0 ", dts, CadenaConexionSeePOS)
        For i As Integer = 0 To BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Count - 1
            For x As Integer = 0 To dts.Rows.Count - 1
                If dts.Rows(x).Item("cod_articulo") = BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("codarticulo") Then
                    If dts.Rows(x).Item("orden") = True Then
                        If Me.txt_num_orden.Text = 0 Or Me.txt_num_orden.Text = "" Then
                            MsgBox("Esta ingresando un producto que necesita número de orden. Por favor ingresar el número de orden.")
                            Me.txt_num_orden.Focus()
                            Me.txt_num_orden.BackColor = System.Drawing.Color.Red
                            Me.txt_num_orden.ForeColor = System.Drawing.Color.White
                            Return False
                            Me.txt_num_orden.BackColor = System.Drawing.Color.White
                        End If
                    End If
                End If
            Next
        Next
        Return True
    End Function

    Private Sub TxtFacturaCompraN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFacturaCompraN.TextChanged

    End Sub
    Public Sub actualizar_prov()
        Dim gd As New GestioDatos
        Try
            For i As Integer = 0 To Me.BindingContext(Me.DataSetCompras.articulos_comprados).Count - 1
                Me.BindingContext(Me.DataSetCompras, "compras.ComprasArticulos_Comprados").Position = i

                With Me.BindingContext(Me.DataSetCompras, "compras.ComprasArticulos_Comprados")
                    gd.Ejecuta("update inventario set proveedor = " & LookUpEdit_Proveedor.EditValue & " Where codigo = " & .Current("codigo"))

                End With
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ckBonificado_CheckedChanged(sender As Object, e As EventArgs) Handles ckBonificado.CheckedChanged
        Me.txtCodArticuloBonificacion.Enabled = Me.ckBonificado.Checked
        Me.txtCodigoBonificacion.Enabled = Me.ckBonificado.Checked
        Me.txtCantidadBonificacion.Enabled = Me.ckBonificado.Checked
        Me.txtCostoBonificacion.Enabled = Me.ckBonificado.Checked
        Me.txtSubtotalBonificacion.Enabled = Me.ckBonificado.Checked
        If Me.ckBonificado.Checked = False Then
            Me.txtCodArticuloBonificacion.Text = ""
            Me.txtCodigoBonificacion.Text = "0"
            Me.txtCantidadBonificacion.Text = "0"
            Me.txtCostoBonificacion.Text = "0"
            Me.txtSubtotalBonificacion.Text = "0"
        End If
    End Sub

    Private CodigoBonificacion As String = ""
    Private Sub txtCodArticuloBonificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodArticuloBonificacion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim BuscarArt As New FrmBuscarArticulo2
            BuscarArt.StartPosition = FormStartPosition.CenterParent
            BuscarArt.CheckBoxInHabilitados.Enabled = True
            BuscarArt.Cod_Articulo = True
            BuscarArt.ShowDialog()
            If BuscarArt.Cancelado Then Exit Sub

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Codigo, Cod_Articulo, Costo from Inventario where Cod_Articulo = '" & BuscarArt.Codigo & "'", dt, CadenaConexionSeePOS)

            If dt.Rows.Count > 0 Then
                Me.txtCantidadBonificacion.Focus()
                Me.txtCodigoBonificacion.Text = dt.Rows(0).Item("Codigo")
                Me.txtCodArticuloBonificacion.Text = dt.Rows(0).Item("Cod_Articulo")
                Me.TxtCantidad.Text = "1"
                Me.txtCostoBonificacion.Text = dt.Rows(0).Item("Costo")
                Me.txtSubtotalBonificacion.Text = (CDec(Me.txtCantidadBonificacion.Text) * CDec(Me.txtCostoBonificacion.Text))
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Codigo, Cod_Articulo, Costo from Inventario where Cod_Articulo = '" & Me.txtCodigoBonificacion.Text & "'", dt, CadenaConexionSeePOS)

            If dt.Rows.Count > 0 Then
                Me.txtCantidadBonificacion.Focus()
                Me.txtCodigoBonificacion.Text = dt.Rows(0).Item("Codigo")
                Me.TxtCantidad.Text = "1"
                Me.txtCostoBonificacion.Text = dt.Rows(0).Item("Costo")
                Me.txtSubtotalBonificacion.Text = (CDec(Me.txtCantidadBonificacion.Text) * CDec(Me.txtCostoBonificacion.Text))
            End If
        End If

    End Sub

    Private Sub txtCantidadBonificacion_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadBonificacion.TextChanged
        On Error Resume Next
        Me.txtSubtotalBonificacion.Text = (CDec(Me.txtCantidadBonificacion.Text) * CDec(Me.txtCostoBonificacion.Text))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cargar_XML_Factura()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmFacturaElectronicaCompra
        frm.IdCompra = BindingContext(DataSetCompras, "Compras").Current("Id_Compra")
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Function getBarras(_Cod As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Barras from Inventario where Codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Barras")
        Else
            Return ""
        End If
    End Function

    Private Function getPresentacion(_Cod As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select cast(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones as Presentacion from inventario i inner join presentaciones p on i.CodPresentacion = p.CodPres where Codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Presentacion")
        Else
            Return ""
        End If
    End Function

    Private Lotes As New System.Collections.Generic.List(Of Lote)
    Private LotesImprimir As New System.Collections.Generic.List(Of Lote)

    Private Sub ImprimirLotes()
        Me.LotesImprimir.Clear()
        Dim lotetemp As Lote
        Dim Lista As System.Collections.Generic.List(Of Lote) = (From x As Lote In Me.Lotes Where x.CantidadImprimir > 0 Select x).ToList()
        For Each l As Lote In Lista
            lotetemp = New Lote(l.Id, l.Lote, l.Vence, l.Codigo, l.Descripcion, l.Presentacion, l.Barras, 1, 1)
            For I As Integer = 0 To l.CantidadImprimir - 1
                Me.LotesImprimir.Add(lotetemp)
            Next
        Next

        Me.I = 0
        printDocument1.Print()
    End Sub
    Private Sub btnLote_Click(sender As Object, e As EventArgs) Handles btnLote.Click
        If Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descripcion") <> "" Then
            If MsgBox("Desea incluir lotes al articulo", MsgBoxStyle.Question + vbYesNo) = MsgBoxResult.Yes Then
                Dim Codigo As String = Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Codigo")
                Dim ListaLotes As System.Collections.Generic.List(Of Lote) = (From x As Lote In Me.Lotes Where x.Codigo = Codigo Select x).ToList
                Dim frm As New frmCrearLote
                For Each l As Lote In ListaLotes
                    frm.Agregar(l.Id, l.Lote, l.Vence, l.Cantidad, l.CantidadImprimir, l.Barras)
                Next
                frm.Barras = Me.getBarras(Codigo)
                frm.Presentacion = Me.getPresentacion(Codigo)
                frm.Descripcion = Me.BindingContext(DataSetCompras, "Compras.Comprasarticulos_comprados").Current("Descripcion")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    For Each l As Lote In ListaLotes
                        Me.Lotes.Remove(l)
                    Next
                    For Each r As DataGridViewRow In frm.viewDatos.Rows
                        Me.Lotes.Add(New Lote(r.Cells("cId").Value, r.Cells("cLote").Value, r.Cells("cVence").Value, Codigo, frm.Descripcion, frm.Presentacion, r.Cells("cBarras").Value, r.Cells("cCantidad").Value, r.Cells("cCantidadImprimir").Value))
                    Next
                End If
            End If
        End If
    End Sub


    Private WithEvents printDocument1 As New System.Drawing.Printing.PrintDocument
    Private pictBarcode As New PictureBox
    Private I As Integer = 0

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim caption As String = ""
        Dim tamanyo As Integer = 0
        Dim pos As Integer = 0

        Dim g As Graphics = e.Graphics
        Dim fnt As Font = New Font("Arial", 7)

        pos = 15
        caption = Me.LotesImprimir(I).Descripcion
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 55, pos)

        pos = 27
        Try
            Dim myimg As Image = Code128Rendering.MakeBarcodeImage(Me.LotesImprimir(I).Barras, Integer.Parse(1), True)
            pictBarcode.Image = myimg
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text)
        End Try
        g.DrawImage(pictBarcode.Image, 50, pos, 190, 50)

        pos = 80
        caption = "COD: " & Me.txtCodArticulo.Text & "     Lote:" & Me.LotesImprimir(I).Lote
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 55, pos)

        pos = 90
        caption = Me.LotesImprimir(I).Presentacion
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 55, pos)

        I += 1
        e.HasMorePages = I < CInt(Me.LotesImprimir.Count)
    End Sub

    Private Sub ckTrans_CheckedChanged(sender As Object, e As EventArgs) Handles ckTrans.CheckedChanged
        Me.txtTrans.Enabled = Me.ckTrans.Checked
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim IdCompra As Long = Me.IdCompraTran
            db.Ejecutar("Update Compras set Trans = " & IIf(Me.ckTrans.Checked = True, 1, 0) & ", NumTrans = '" & Me.txtTrans.Text & "' Where Id_Compra = " & IdCompra, CommandType.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "No se pudo realizar la operacion.")
        End Try
    End Sub
End Class

Public Class Lote
    Public Property Id As Integer
    Public Property Lote As String
    Public Property Vence As Date
    Public Property Codigo As Long
    Public Property Descripcion As String
    Public Property Presentacion As String
    Public Property Barras As String
    Public Property Cantidad As Decimal
    Public Property CantidadImprimir As Decimal

    Public Property Cod_Articulo As String

    Sub New(_Id As Integer, _Lote As String, _Vence As Date, _Codigo As Long, _Descripcion As String, _Presentacion As String, _Barras As String, _Cantidad As Decimal, _CantidadImprimir As Decimal, Optional ByVal _Cod_Articulo As String = "")
        Me.Id = _Id
        Me.Lote = _Lote
        Me.Vence = _Vence
        Me.Codigo = _Codigo
        Me.Descripcion = _Descripcion
        Me.Presentacion = _Presentacion
        Me.Barras = _Barras
        Me.Cantidad = _Cantidad
        Me.CantidadImprimir = _CantidadImprimir
        Me.Cod_Articulo = _Cod_Articulo
    End Sub
End Class