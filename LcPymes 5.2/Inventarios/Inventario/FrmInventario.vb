Imports DevExpress.Utils
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Windows.Forms

Public Class FrmInventario
    Inherits System.Windows.Forms.Form
    Dim usua As Usuario_Logeado
    Dim PMU As New PerfilModulo_Class
    Dim perfil_administrador As Boolean
    Dim strNuevo As String = ""
    Dim codPresent As Integer
    Dim Cedula_usuario As String
    Dim logeado As Boolean
    Friend WithEvents ckMaquinaria As System.Windows.Forms.CheckBox
    Friend WithEvents ckProductosOrganicos As System.Windows.Forms.CheckBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtcosto_real As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbo_rifa As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ckCredito As System.Windows.Forms.CheckBox
    Friend WithEvents ckContado As System.Windows.Forms.CheckBox
    Friend WithEvents ckValidaExistencia As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents viewRelacionados As System.Windows.Forms.DataGridView
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionRelacion As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarRelacion As System.Windows.Forms.Button
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoRelacion As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadRelacion As System.Windows.Forms.TextBox
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ckActualizado As System.Windows.Forms.CheckBox
    Friend WithEvents lblFechaActualizacion As System.Windows.Forms.Label
    Friend WithEvents cboTipoImpuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaBodega2 As System.Windows.Forms.TextBox
    Friend WithEvents ckActivarBodega As System.Windows.Forms.CheckBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents ckMAG As System.Windows.Forms.CheckBox
    Friend WithEvents ckSinDecimales As System.Windows.Forms.CheckBox
    Friend WithEvents ckMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents ckSoloContado As System.Windows.Forms.CheckBox
    Friend WithEvents lblUltimaCompra As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents ckHabilitaFamilia As System.Windows.Forms.CheckBox
    Friend WithEvents TxtUtilidadR_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidadR_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidadR_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidadR_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidadR_P As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDuplicar As Button
    Friend WithEvents ckLaboratorio As System.Windows.Forms.CheckBox
    Friend WithEvents btnRelacionados As System.Windows.Forms.Button
    Friend WithEvents ckListaNegra As System.Windows.Forms.CheckBox
    Friend WithEvents txtCostoTienda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label58 As System.Windows.Forms.Label

#Region " Windows Form Designer generated code "
    Dim dlg As WaitDialogForm
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        dlg = New WaitDialogForm("Cargando Componentes ...")
        dlg.Text = ""
        dlg.Caption = "Inicializando Módulo...."
        InitializeComponent()
        dlg.Caption = "Módulo Cargado...."
        ' Add any initialization after the InitializeComponent() call
        PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DataSetInventario, "Inventario.Imagen"))
        dlg.Close()
        'AddHandler Me.BindingContext(Me.DataSetInventario, "Inventario2").PositionChanged, AddressOf Me.Position_Changed
    End Sub

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.

        InitializeComponent()
        usua = Usuario_Parametro
        AddHandler Me.BindingContext(Me.DataSetInventario, "Inventario2").PositionChanged, AddressOf Me.Position_Changed
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        'Asigna la imagen al imagenbox
        PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DataSetInventario, "Inventario.Imagen"))

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
    Friend WithEvents AdapterAUbicacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCasaConsignante As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterFamilia As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterMarcas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterPresentacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ComboBox_Ubicacion_SubUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBodegas As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator

    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    'Friend WithEvents ckHabilitaFamilia As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtBarras As System.Windows.Forms.TextBox

    Friend WithEvents TxtCodigo As System.Windows.Forms.Label

    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents TxtMax As System.Windows.Forms.TextBox
    Friend WithEvents TxtMed As System.Windows.Forms.TextBox
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecioVenta_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetInventario As DataSetInventario
    Friend WithEvents AdapterInventario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtCanPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxMonedaVenta As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterArticulosXproveedor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents colFechaUltimaCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoProveedor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUltimoCosto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents TextBoxValorMonedaEnVenta As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TxtUtilidad_P As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_P As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_P As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents Adapter_cod_Inventario As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Adaptador_Inventraio_AUX As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Text_Cod_AUX As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtMin As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterBitacora As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ToolBarEliminador As System.Windows.Forms.ToolBarButton
    Friend WithEvents lblCodigoProveedor As System.Windows.Forms.Label
    Friend WithEvents daProveedores As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents cmboxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents ckVerCodBarraInv As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtPorSugerido As System.Windows.Forms.TextBox
    Friend WithEvents txtVentaSugerido As System.Windows.Forms.TextBox
    Friend WithEvents txtSugeridoIV As System.Windows.Forms.TextBox
    Friend WithEvents Ck_Consignacion As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents AdapterLote As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtExistenciaBodega As ValidText.ValidText
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtCostoEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtOtrosCargosEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtFleteEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxValorMonedaEnCosto As System.Windows.Forms.TextBox
    Friend WithEvents TxtBaseEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtFlete As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtOtros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtBase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Ck_Lote As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_PreguntaPrecio As System.Windows.Forms.CheckBox
    Friend WithEvents Check_Inhabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents Check_Servicio As System.Windows.Forms.CheckBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Check_Promo As System.Windows.Forms.CheckBox
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TxtMaxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabLotes As System.Windows.Forms.TabPage
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProveedor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCant_Actual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCod_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents ChkOtro As System.Windows.Forms.CheckBox
    Friend WithEvents TxtCodOtro As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesOtro As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantOtro As System.Windows.Forms.TextBox
    Friend WithEvents LbCantidad As System.Windows.Forms.Label
    Friend WithEvents LbPresOtro As System.Windows.Forms.Label
    Friend WithEvents LbCodOtro As System.Windows.Forms.Label
    Friend WithEvents LbDescOtro As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ckpantalla As System.Windows.Forms.CheckBox
    Friend WithEvents ckclinica As System.Windows.Forms.CheckBox
    Friend WithEvents ckmascotas As System.Windows.Forms.CheckBox
    Friend WithEvents ck_receta As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ck_peces As System.Windows.Forms.CheckBox
    Friend WithEvents ck_taller As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ck_promo3x1 As System.Windows.Forms.CheckBox
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ck_orden As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents contenedor As System.Windows.Forms.Panel
    Friend WithEvents adUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ck_bonificado As System.Windows.Forms.CheckBox
    Friend WithEvents cboencargado As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents adserie As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ckarmamento As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ck_tienda As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo13 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo14 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo15 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.TxtCodigo = New System.Windows.Forms.Label()
        Me.DataSetInventario = New LcPymes_5._2.DataSetInventario()
        Me.TxtBarras = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtMed = New System.Windows.Forms.TextBox()
        Me.TxtMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_B = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_C = New DevExpress.XtraEditors.TextEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta_D = New DevExpress.XtraEditors.TextEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUltimaCompra = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TxtUtilidadR_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidadR_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidadR_B = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidadR_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidadR_P = New DevExpress.XtraEditors.TextEdit()
        Me.TextBoxValorMonedaEnVenta = New System.Windows.Forms.TextBox()
        Me.TxtUtilidad_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_B = New DevExpress.XtraEditors.TextEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta_IV_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_B = New DevExpress.XtraEditors.TextEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtUtilidad_A = New DevExpress.XtraEditors.TextEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ComboBoxMonedaVenta = New System.Windows.Forms.ComboBox()
        Me.TxtUtilidad_P = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_P = New DevExpress.XtraEditors.TextEdit()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta_P = New DevExpress.XtraEditors.TextEdit()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.ckHabilitaFamilia = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRelacionados = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtExistencia = New System.Windows.Forms.TextBox()
        Me.TxtMin = New System.Windows.Forms.TextBox()
        Me.ComboBoxBodegas = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminador = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.AdapterMarcas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.ComboBoxFamilia = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Ubicacion_SubUbicacion = New System.Windows.Forms.ComboBox()
        Me.AdapterFamilia = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterPresentacion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterCasaConsignante = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.AdapterAUbicacion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterInventario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.TxtCanPresentacion = New System.Windows.Forms.TextBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.AdapterArticulosXproveedor = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.colFechaUltimaCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoProveedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUltimoCosto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Text_Cod_AUX = New System.Windows.Forms.TextBox()
        Me.Adaptador_Inventraio_AUX = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Ck_Consignacion = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ckSoloContado = New System.Windows.Forms.CheckBox()
        Me.ckMostrar = New System.Windows.Forms.CheckBox()
        Me.ckSinDecimales = New System.Windows.Forms.CheckBox()
        Me.lblFechaActualizacion = New System.Windows.Forms.Label()
        Me.ckActualizado = New System.Windows.Forms.CheckBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ckpantalla = New System.Windows.Forms.CheckBox()
        Me.TxtPresentacion = New System.Windows.Forms.TextBox()
        Me.ChkOtro = New System.Windows.Forms.CheckBox()
        Me.TxtCodOtro = New System.Windows.Forms.TextBox()
        Me.TxtDesOtro = New System.Windows.Forms.TextBox()
        Me.TxtCantOtro = New System.Windows.Forms.TextBox()
        Me.LbCantidad = New System.Windows.Forms.Label()
        Me.LbPresOtro = New System.Windows.Forms.Label()
        Me.LbCodOtro = New System.Windows.Forms.Label()
        Me.LbDescOtro = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCod_Articulo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmboxProveedor = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lblCodigoProveedor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterBitacora = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daProveedores = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.ckVerCodBarraInv = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPorSugerido = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtVentaSugerido = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtSugeridoIV = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtExistenciaBodega = New ValidText.ValidText()
        Me.AdapterLote = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtCostoTienda = New DevExpress.XtraEditors.TextEdit()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.ckMAG = New System.Windows.Forms.CheckBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cboTipoImpuesto = New System.Windows.Forms.ComboBox()
        Me.txtcosto_real = New DevExpress.XtraEditors.TextEdit()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TxtCostoEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtOtrosCargosEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtFleteEquivalente = New System.Windows.Forms.TextBox()
        Me.TextBoxValorMonedaEnCosto = New System.Windows.Forms.TextBox()
        Me.TxtBaseEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtImpuesto = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtFlete = New DevExpress.XtraEditors.TextEdit()
        Me.TxtOtros = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxMoneda = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtBase = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ckCredito = New System.Windows.Forms.CheckBox()
        Me.ckContado = New System.Windows.Forms.CheckBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cbo_rifa = New System.Windows.Forms.ComboBox()
        Me.ck_bonificado = New System.Windows.Forms.CheckBox()
        Me.ck_orden = New System.Windows.Forms.CheckBox()
        Me.ck_promo3x1 = New System.Windows.Forms.CheckBox()
        Me.ck_receta = New System.Windows.Forms.CheckBox()
        Me.Ck_Lote = New System.Windows.Forms.CheckBox()
        Me.Ck_PreguntaPrecio = New System.Windows.Forms.CheckBox()
        Me.Check_Inhabilitado = New System.Windows.Forms.CheckBox()
        Me.Check_Servicio = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Check_Promo = New System.Windows.Forms.CheckBox()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtMaxDesc = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabLotes = New System.Windows.Forms.TabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtExistenciaBodega2 = New System.Windows.Forms.TextBox()
        Me.ckActivarBodega = New System.Windows.Forms.CheckBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ckProductosOrganicos = New System.Windows.Forms.CheckBox()
        Me.ckMaquinaria = New System.Windows.Forms.CheckBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cboencargado = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ck_taller = New System.Windows.Forms.CheckBox()
        Me.ck_peces = New System.Windows.Forms.CheckBox()
        Me.ckmascotas = New System.Windows.Forms.CheckBox()
        Me.ckclinica = New System.Windows.Forms.CheckBox()
        Me.ckarmamento = New System.Windows.Forms.CheckBox()
        Me.ck_tienda = New System.Windows.Forms.CheckBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.viewRelacionados = New System.Windows.Forms.DataGridView()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtDescripcionRelacion = New System.Windows.Forms.TextBox()
        Me.btnAgregarRelacion = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtCodigoRelacion = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtCantidadRelacion = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.colCodigoProveedor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCant_Actual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.contenedor = New System.Windows.Forms.Panel()
        Me.adUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.adserie = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ckValidaExistencia = New System.Windows.Forms.CheckBox()
        Me.btnDuplicar = New System.Windows.Forms.Button()
        Me.ckLaboratorio = New System.Windows.Forms.CheckBox()
        Me.ckListaNegra = New System.Windows.Forms.CheckBox()
        CType(Me.DataSetInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtUtilidadR_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidadR_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidadR_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidadR_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidadR_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.txtCostoTienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcosto_real.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFlete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOtros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLotes.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.viewRelacionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.White
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Codigo", True))
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Red
        Me.TxtCodigo.Location = New System.Drawing.Point(39, 11)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(82, 15)
        Me.TxtCodigo.TabIndex = 2
        Me.TxtCodigo.Text = "0"
        Me.TxtCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSetInventario
        '
        Me.DataSetInventario.DataSetName = "DataSetInventario"
        Me.DataSetInventario.Locale = New System.Globalization.CultureInfo("es")
        Me.DataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtBarras
        '
        Me.TxtBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBarras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Barras", True))
        Me.TxtBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarras.ForeColor = System.Drawing.Color.Blue
        Me.TxtBarras.Location = New System.Drawing.Point(4, 64)
        Me.TxtBarras.Name = "TxtBarras"
        Me.TxtBarras.Size = New System.Drawing.Size(79, 13)
        Me.TxtBarras.TabIndex = 1
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Descripcion", True))
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.TxtDescripcion.Location = New System.Drawing.Point(92, 24)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(408, 13)
        Me.TxtDescripcion.TabIndex = 3
        '
        'TxtMed
        '
        Me.TxtMed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.PuntoMedio", True))
        Me.TxtMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMed.ForeColor = System.Drawing.Color.Red
        Me.TxtMed.Location = New System.Drawing.Point(76, 32)
        Me.TxtMed.Name = "TxtMed"
        Me.TxtMed.Size = New System.Drawing.Size(52, 19)
        Me.TxtMed.TabIndex = 3
        Me.TxtMed.Text = "0.00"
        Me.TxtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMax
        '
        Me.TxtMax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Maxima", True))
        Me.TxtMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMax.ForeColor = System.Drawing.Color.Red
        Me.TxtMax.Location = New System.Drawing.Point(140, 32)
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.Size = New System.Drawing.Size(52, 19)
        Me.TxtMax.TabIndex = 5
        Me.TxtMax.Text = "0.00"
        Me.TxtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(6, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(92, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(504, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Presentación"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(180, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Familia"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(88, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Pantalla"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(12, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mínima"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SlateGray
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.ErrorProvider.SetIconAlignment(Me.Label9, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(698, 32)
        Me.Label9.TabIndex = 0
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxPresentacion
        '
        Me.ComboBoxPresentacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.CodPresentacion", True))
        Me.ComboBoxPresentacion.DataSource = Me.DataSetInventario
        Me.ComboBoxPresentacion.DisplayMember = "Presentaciones.Presentaciones"
        Me.ComboBoxPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPresentacion.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxPresentacion.ItemHeight = 13
        Me.ComboBoxPresentacion.Location = New System.Drawing.Point(536, 20)
        Me.ComboBoxPresentacion.Name = "ComboBoxPresentacion"
        Me.ComboBoxPresentacion.Size = New System.Drawing.Size(138, 21)
        Me.ComboBoxPresentacion.TabIndex = 6
        Me.ComboBoxPresentacion.ValueMember = "Presentaciones.CodPres"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(76, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Media"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(140, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Máxima"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(4, 488)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(333, 11)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Observaciones"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(180, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Ubicación"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Observaciones", True))
        Me.TxtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.TxtObservaciones.Location = New System.Drawing.Point(4, 576)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(333, 16)
        Me.TxtObservaciones.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(134, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 12)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "C"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(134, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 12)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "B"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(134, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 16)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "A"
        '
        'TxtPrecioVenta_A
        '
        Me.TxtPrecioVenta_A.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Precio_A", True))
        Me.TxtPrecioVenta_A.EditValue = "0.00"
        Me.TxtPrecioVenta_A.Location = New System.Drawing.Point(150, 60)
        Me.TxtPrecioVenta_A.Name = "TxtPrecioVenta_A"
        '
        '
        '
        Me.TxtPrecioVenta_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_A.Size = New System.Drawing.Size(76, 19)
        Me.TxtPrecioVenta_A.TabIndex = 4
        '
        'TxtPrecioVenta_B
        '
        Me.TxtPrecioVenta_B.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Precio_B", True))
        Me.TxtPrecioVenta_B.EditValue = "0.00"
        Me.TxtPrecioVenta_B.Location = New System.Drawing.Point(150, 83)
        Me.TxtPrecioVenta_B.Name = "TxtPrecioVenta_B"
        '
        '
        '
        Me.TxtPrecioVenta_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_B.Size = New System.Drawing.Size(76, 19)
        Me.TxtPrecioVenta_B.TabIndex = 8
        '
        'TxtPrecioVenta_C
        '
        Me.TxtPrecioVenta_C.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Precio_C", True))
        Me.TxtPrecioVenta_C.EditValue = "0.00"
        Me.TxtPrecioVenta_C.Location = New System.Drawing.Point(150, 106)
        Me.TxtPrecioVenta_C.Name = "TxtPrecioVenta_C"
        '
        '
        '
        Me.TxtPrecioVenta_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_C.Size = New System.Drawing.Size(76, 19)
        Me.TxtPrecioVenta_C.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(134, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 12)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "D"
        '
        'TxtPrecioVenta_D
        '
        Me.TxtPrecioVenta_D.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Precio_D", True))
        Me.TxtPrecioVenta_D.EditValue = "0.00"
        Me.TxtPrecioVenta_D.Location = New System.Drawing.Point(150, 128)
        Me.TxtPrecioVenta_D.Name = "TxtPrecioVenta_D"
        '
        '
        '
        Me.TxtPrecioVenta_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_D.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_D.Size = New System.Drawing.Size(76, 19)
        Me.TxtPrecioVenta_D.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(230, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(12, 12)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Beige
        Me.GroupBox2.Controls.Add(Me.lblUltimaCompra)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label57)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidadR_D)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidadR_C)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidadR_B)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidadR_A)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidadR_P)
        Me.GroupBox2.Controls.Add(Me.TextBoxValorMonedaEnVenta)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_D)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_C)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_B)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_D)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_A)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_C)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_B)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_D)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_A)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_C)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_B)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_A)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.ComboBoxMonedaVenta)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_P)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_P)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_P)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(352, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 199)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precio de Venta"
        '
        'lblUltimaCompra
        '
        Me.lblUltimaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaCompra.ForeColor = System.Drawing.Color.Red
        Me.lblUltimaCompra.Location = New System.Drawing.Point(9, 172)
        Me.lblUltimaCompra.Name = "lblUltimaCompra"
        Me.lblUltimaCompra.Size = New System.Drawing.Size(308, 17)
        Me.lblUltimaCompra.TabIndex = 22
        Me.lblUltimaCompra.Text = "Ya pasaron mas de 30 dias de la ultima compra"
        Me.lblUltimaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(76, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Utilidad"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label57.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label57.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label57.Location = New System.Drawing.Point(6, 40)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(72, 16)
        Me.Label57.TabIndex = 31
        Me.Label57.Text = "Uti. Real"
        '
        'TxtUtilidadR_D
        '
        Me.TxtUtilidadR_D.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtUtilidadR_D.Location = New System.Drawing.Point(8, 128)
        Me.TxtUtilidadR_D.Name = "TxtUtilidadR_D"
        '
        '
        '
        Me.TxtUtilidadR_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_D.Properties.ReadOnly = True
        Me.TxtUtilidadR_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidadR_D.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidadR_D.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidadR_D.TabIndex = 14
        '
        'TxtUtilidadR_C
        '
        Me.TxtUtilidadR_C.EditValue = 0
        Me.TxtUtilidadR_C.Location = New System.Drawing.Point(8, 106)
        Me.TxtUtilidadR_C.Name = "TxtUtilidadR_C"
        '
        '
        '
        Me.TxtUtilidadR_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_C.Properties.ReadOnly = True
        Me.TxtUtilidadR_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidadR_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidadR_C.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidadR_C.TabIndex = 10
        '
        'TxtUtilidadR_B
        '
        Me.TxtUtilidadR_B.EditValue = 0
        Me.TxtUtilidadR_B.Location = New System.Drawing.Point(8, 83)
        Me.TxtUtilidadR_B.Name = "TxtUtilidadR_B"
        '
        '
        '
        Me.TxtUtilidadR_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_B.Properties.ReadOnly = True
        Me.TxtUtilidadR_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidadR_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidadR_B.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidadR_B.TabIndex = 6
        '
        'TxtUtilidadR_A
        '
        Me.TxtUtilidadR_A.EditValue = "0.00"
        Me.TxtUtilidadR_A.Location = New System.Drawing.Point(8, 60)
        Me.TxtUtilidadR_A.Name = "TxtUtilidadR_A"
        '
        '
        '
        Me.TxtUtilidadR_A.Properties.DisplayFormat.FormatString = "#,#0.0000"
        Me.TxtUtilidadR_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_A.Properties.EditFormat.FormatString = "#,#0.0000"
        Me.TxtUtilidadR_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_A.Properties.MaskData.EditMask = "#,#0.0000"
        Me.TxtUtilidadR_A.Properties.ReadOnly = True
        Me.TxtUtilidadR_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidadR_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidadR_A.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidadR_A.TabIndex = 2
        '
        'TxtUtilidadR_P
        '
        Me.TxtUtilidadR_P.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtUtilidadR_P.Location = New System.Drawing.Point(8, 150)
        Me.TxtUtilidadR_P.Name = "TxtUtilidadR_P"
        '
        '
        '
        Me.TxtUtilidadR_P.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_P.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_P.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidadR_P.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidadR_P.Properties.Enabled = False
        Me.TxtUtilidadR_P.Properties.ReadOnly = True
        Me.TxtUtilidadR_P.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidadR_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidadR_P.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidadR_P.TabIndex = 18
        '
        'TextBoxValorMonedaEnVenta
        '
        Me.TextBoxValorMonedaEnVenta.AcceptsTab = True
        Me.TextBoxValorMonedaEnVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorMonedaEnVenta.Enabled = False
        Me.TextBoxValorMonedaEnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxValorMonedaEnVenta.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxValorMonedaEnVenta.Location = New System.Drawing.Point(254, 20)
        Me.TextBoxValorMonedaEnVenta.Name = "TextBoxValorMonedaEnVenta"
        Me.TextBoxValorMonedaEnVenta.ReadOnly = True
        Me.TextBoxValorMonedaEnVenta.Size = New System.Drawing.Size(72, 13)
        Me.TextBoxValorMonedaEnVenta.TabIndex = 2
        Me.TextBoxValorMonedaEnVenta.Text = "0.00"
        Me.TextBoxValorMonedaEnVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtUtilidad_D
        '
        Me.TxtUtilidad_D.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtUtilidad_D.Location = New System.Drawing.Point(76, 128)
        Me.TxtUtilidad_D.Name = "TxtUtilidad_D"
        '
        '
        '
        Me.TxtUtilidad_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_D.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidad_D.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidad_D.TabIndex = 15
        '
        'TxtUtilidad_C
        '
        Me.TxtUtilidad_C.EditValue = 0
        Me.TxtUtilidad_C.Location = New System.Drawing.Point(76, 106)
        Me.TxtUtilidad_C.Name = "TxtUtilidad_C"
        '
        '
        '
        Me.TxtUtilidad_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidad_C.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidad_C.TabIndex = 11
        '
        'TxtUtilidad_B
        '
        Me.TxtUtilidad_B.EditValue = 0
        Me.TxtUtilidad_B.Location = New System.Drawing.Point(76, 83)
        Me.TxtUtilidad_B.Name = "TxtUtilidad_B"
        '
        '
        '
        Me.TxtUtilidad_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidad_B.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidad_B.TabIndex = 7
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(246, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 16)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Precio + I.V."
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(150, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 16)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Precio Venta"
        '
        'TxtPrecioVenta_IV_D
        '
        Me.TxtPrecioVenta_IV_D.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_D.Location = New System.Drawing.Point(246, 128)
        Me.TxtPrecioVenta_IV_D.Name = "TxtPrecioVenta_IV_D"
        '
        '
        '
        Me.TxtPrecioVenta_IV_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_D.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_IV_D.Size = New System.Drawing.Size(80, 19)
        Me.TxtPrecioVenta_IV_D.TabIndex = 17
        '
        'TxtPrecioVenta_IV_A
        '
        Me.TxtPrecioVenta_IV_A.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_A.Location = New System.Drawing.Point(246, 60)
        Me.TxtPrecioVenta_IV_A.Name = "TxtPrecioVenta_IV_A"
        '
        '
        '
        Me.TxtPrecioVenta_IV_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_IV_A.Size = New System.Drawing.Size(80, 19)
        Me.TxtPrecioVenta_IV_A.TabIndex = 5
        '
        'TxtPrecioVenta_IV_C
        '
        Me.TxtPrecioVenta_IV_C.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_C.Location = New System.Drawing.Point(246, 106)
        Me.TxtPrecioVenta_IV_C.Name = "TxtPrecioVenta_IV_C"
        '
        '
        '
        Me.TxtPrecioVenta_IV_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_IV_C.Size = New System.Drawing.Size(80, 19)
        Me.TxtPrecioVenta_IV_C.TabIndex = 13
        '
        'TxtPrecioVenta_IV_B
        '
        Me.TxtPrecioVenta_IV_B.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_B.Location = New System.Drawing.Point(246, 83)
        Me.TxtPrecioVenta_IV_B.Name = "TxtPrecioVenta_IV_B"
        '
        '
        '
        Me.TxtPrecioVenta_IV_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_IV_B.Size = New System.Drawing.Size(80, 19)
        Me.TxtPrecioVenta_IV_B.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(230, 128)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(12, 12)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "+"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(230, 106)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(12, 12)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "+"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(230, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(12, 12)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "+"
        '
        'TxtUtilidad_A
        '
        Me.TxtUtilidad_A.EditValue = "0.00"
        Me.TxtUtilidad_A.Location = New System.Drawing.Point(76, 60)
        Me.TxtUtilidad_A.Name = "TxtUtilidad_A"
        '
        '
        '
        Me.TxtUtilidad_A.Properties.DisplayFormat.FormatString = "#,#0.0000"
        Me.TxtUtilidad_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_A.Properties.EditFormat.FormatString = "#,#0.0000"
        Me.TxtUtilidad_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_A.Properties.MaskData.EditMask = "#,#0.0000"
        Me.TxtUtilidad_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidad_A.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidad_A.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(76, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 16)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Moneda"
        '
        'ComboBoxMonedaVenta
        '
        Me.ComboBoxMonedaVenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.MonedaVenta", True))
        Me.ComboBoxMonedaVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Moneda.ValorCompra", True))
        Me.ComboBoxMonedaVenta.DataSource = Me.DataSetInventario.Moneda
        Me.ComboBoxMonedaVenta.DisplayMember = "MonedaNombre"
        Me.ComboBoxMonedaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMonedaVenta.Enabled = False
        Me.ComboBoxMonedaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMonedaVenta.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxMonedaVenta.ItemHeight = 13
        Me.ComboBoxMonedaVenta.Location = New System.Drawing.Point(148, 16)
        Me.ComboBoxMonedaVenta.Name = "ComboBoxMonedaVenta"
        Me.ComboBoxMonedaVenta.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxMonedaVenta.TabIndex = 1
        Me.ComboBoxMonedaVenta.ValueMember = "Moneda.CodMoneda"
        '
        'TxtUtilidad_P
        '
        Me.TxtUtilidad_P.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtUtilidad_P.Location = New System.Drawing.Point(76, 150)
        Me.TxtUtilidad_P.Name = "TxtUtilidad_P"
        '
        '
        '
        Me.TxtUtilidad_P.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_P.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_P.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_P.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_P.Properties.Enabled = False
        Me.TxtUtilidad_P.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUtilidad_P.Size = New System.Drawing.Size(56, 19)
        Me.TxtUtilidad_P.TabIndex = 18
        '
        'TxtPrecioVenta_IV_P
        '
        Me.TxtPrecioVenta_IV_P.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_P.Location = New System.Drawing.Point(246, 150)
        Me.TxtPrecioVenta_IV_P.Name = "TxtPrecioVenta_IV_P"
        '
        '
        '
        Me.TxtPrecioVenta_IV_P.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_P.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_P.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_P.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_P.Properties.Enabled = False
        Me.TxtPrecioVenta_IV_P.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_IV_P.Size = New System.Drawing.Size(80, 19)
        Me.TxtPrecioVenta_IV_P.TabIndex = 21
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(230, 150)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(12, 12)
        Me.Label35.TabIndex = 29
        Me.Label35.Text = "+"
        '
        'TxtPrecioVenta_P
        '
        Me.TxtPrecioVenta_P.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Precio_Promo", True))
        Me.TxtPrecioVenta_P.EditValue = "0.00"
        Me.TxtPrecioVenta_P.Location = New System.Drawing.Point(150, 150)
        Me.TxtPrecioVenta_P.Name = "TxtPrecioVenta_P"
        '
        '
        '
        Me.TxtPrecioVenta_P.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_P.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_P.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_P.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_P.Properties.Enabled = False
        Me.TxtPrecioVenta_P.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioVenta_P.Size = New System.Drawing.Size(76, 19)
        Me.TxtPrecioVenta_P.TabIndex = 20
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(134, 151)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(11, 12)
        Me.Label36.TabIndex = 27
        Me.Label36.Text = "P"
        '
        'ckHabilitaFamilia
        '
        Me.ckHabilitaFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckHabilitaFamilia.ForeColor = System.Drawing.Color.White
        Me.ckHabilitaFamilia.Location = New System.Drawing.Point(248, 44)
        Me.ckHabilitaFamilia.Name = "ckHabilitaFamilia"
        Me.ckHabilitaFamilia.Size = New System.Drawing.Size(20, 16)
        Me.ckHabilitaFamilia.TabIndex = 2
        Me.ckHabilitaFamilia.Text = "..."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Peru
        Me.GroupBox3.Controls.Add(Me.btnRelacionados)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.TxtExistencia)
        Me.GroupBox3.Controls.Add(Me.TxtMin)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtMed)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TxtMax)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(352, 405)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 60)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Existencias"
        '
        'btnRelacionados
        '
        Me.btnRelacionados.Location = New System.Drawing.Point(284, 29)
        Me.btnRelacionados.Name = "btnRelacionados"
        Me.btnRelacionados.Size = New System.Drawing.Size(46, 23)
        Me.btnRelacionados.TabIndex = 8
        Me.btnRelacionados.Text = "..."
        Me.btnRelacionados.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(204, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 12)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Actual"
        '
        'TxtExistencia
        '
        Me.TxtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Existencia", True))
        Me.TxtExistencia.Enabled = False
        Me.TxtExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExistencia.ForeColor = System.Drawing.Color.Red
        Me.TxtExistencia.Location = New System.Drawing.Point(204, 32)
        Me.TxtExistencia.Name = "TxtExistencia"
        Me.TxtExistencia.Size = New System.Drawing.Size(72, 19)
        Me.TxtExistencia.TabIndex = 7
        Me.TxtExistencia.Text = "0.00"
        Me.TxtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMin
        '
        Me.TxtMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Minima", True))
        Me.TxtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMin.ForeColor = System.Drawing.Color.Red
        Me.TxtMin.Location = New System.Drawing.Point(12, 32)
        Me.TxtMin.Name = "TxtMin"
        Me.TxtMin.Size = New System.Drawing.Size(52, 19)
        Me.TxtMin.TabIndex = 1
        Me.TxtMin.Text = "0.00"
        Me.TxtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBoxBodegas
        '
        Me.ComboBoxBodegas.BackColor = System.Drawing.Color.Red
        Me.ComboBoxBodegas.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.Id_Bodega", True))
        Me.ComboBoxBodegas.DataSource = Me.DataSetInventario
        Me.ComboBoxBodegas.DisplayMember = "Bodegas.Nombre_Bodega"
        Me.ComboBoxBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBodegas.Enabled = False
        Me.ComboBoxBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBodegas.ForeColor = System.Drawing.Color.White
        Me.ComboBoxBodegas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBoxBodegas.ItemHeight = 20
        Me.ComboBoxBodegas.Location = New System.Drawing.Point(8, 29)
        Me.ComboBoxBodegas.Name = "ComboBoxBodegas"
        Me.ComboBoxBodegas.Size = New System.Drawing.Size(248, 28)
        Me.ComboBoxBodegas.TabIndex = 1
        Me.ComboBoxBodegas.ValueMember = "Bodegas.ID_Bodega"
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
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarEliminador, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 509)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(698, 52)
        Me.ToolBar1.TabIndex = 11
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Actualizar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Inhabilitar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarEliminador
        '
        Me.ToolBarEliminador.ImageIndex = 9
        Me.ToolBarEliminador.Name = "ToolBarEliminador"
        Me.ToolBarEliminador.Text = "Eliminar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.CodMarca", True))
        Me.ComboBoxMarca.DataSource = Me.DataSetInventario
        Me.ComboBoxMarca.DisplayMember = "Marcas.Marca"
        Me.ComboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxMarca.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxMarca.ItemHeight = 13
        Me.ComboBoxMarca.Location = New System.Drawing.Point(172, 112)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(502, 21)
        Me.ComboBoxMarca.TabIndex = 14
        Me.ComboBoxMarca.ValueMember = "Marcas.CodMarca"
        '
        'AdapterMarcas
        '
        Me.AdapterMarcas.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMarcas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Marcas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMarca", "CodMarca"), New System.Data.Common.DataColumnMapping("Marca", "Marca")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMarca, Marca FROM Marcas"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-NCOO4KP"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""."";persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ComboBoxFamilia
        '
        Me.ComboBoxFamilia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.SubFamilia", True))
        Me.ComboBoxFamilia.DataSource = Me.DataSetInventario
        Me.ComboBoxFamilia.DisplayMember = "SubFamilias.Familiares"
        Me.ComboBoxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxFamilia.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxFamilia.ItemHeight = 13
        Me.ComboBoxFamilia.Location = New System.Drawing.Point(268, 40)
        Me.ComboBoxFamilia.Name = "ComboBoxFamilia"
        Me.ComboBoxFamilia.Size = New System.Drawing.Size(406, 21)
        Me.ComboBoxFamilia.TabIndex = 8
        Me.ComboBoxFamilia.ValueMember = "SubFamilias.Codigo"
        '
        'ComboBox_Ubicacion_SubUbicacion
        '
        Me.ComboBox_Ubicacion_SubUbicacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.SubUbicacion", True))
        Me.ComboBox_Ubicacion_SubUbicacion.DataSource = Me.DataSetInventario
        Me.ComboBox_Ubicacion_SubUbicacion.DisplayMember = "SubUbicacion.Ubicaciones"
        Me.ComboBox_Ubicacion_SubUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Ubicacion_SubUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_Ubicacion_SubUbicacion.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox_Ubicacion_SubUbicacion.ItemHeight = 13
        Me.ComboBox_Ubicacion_SubUbicacion.Location = New System.Drawing.Point(268, 64)
        Me.ComboBox_Ubicacion_SubUbicacion.Name = "ComboBox_Ubicacion_SubUbicacion"
        Me.ComboBox_Ubicacion_SubUbicacion.Size = New System.Drawing.Size(406, 21)
        Me.ComboBox_Ubicacion_SubUbicacion.TabIndex = 10
        Me.ComboBox_Ubicacion_SubUbicacion.ValueMember = "SubUbicacion.Codigo"
        '
        'AdapterFamilia
        '
        Me.AdapterFamilia.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterFamilia.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SubFamilias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Familiares", "Familiares")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT SubFamilias.Codigo, Familia.Descripcion + '/' + SubFamilias.Descripcion AS" & _
    " Familiares FROM SubFamilias INNER JOIN Familia ON SubFamilias.CodigoFamilia = F" & _
    "amilia.Codigo"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'AdapterPresentacion
        '
        Me.AdapterPresentacion.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterPresentacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Presentaciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Presentaciones", "Presentaciones"), New System.Data.Common.DataColumnMapping("CodPres", "CodPres")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Presentaciones, CodPres FROM Presentaciones"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'AdapterCasaConsignante
        '
        Me.AdapterCasaConsignante.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterCasaConsignante.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bodegas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre_Bodega", "Nombre_Bodega"), New System.Data.Common.DataColumnMapping("ID_Bodega", "ID_Bodega")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Nombre_Bodega, ID_Bodega FROM Bodegas where Inactiva = 0 and Consignacion " & _
    "= 1"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Inventario2"
        Me.DataNavigator1.DataSource = Me.DataSetInventario
        Me.DataNavigator1.Location = New System.Drawing.Point(559, 520)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(134, 21)
        Me.DataNavigator1.TabIndex = 68
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'AdapterAUbicacion
        '
        Me.AdapterAUbicacion.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterAUbicacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SubUbicacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Ubicaciones", "Ubicaciones")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT SubUbicacion.Codigo, Ubicaciones.Descripcion + '/' + SubUbicacion.Descripc" & _
    "ionD AS Ubicaciones FROM SubUbicacion INNER JOIN Ubicaciones ON SubUbicacion.Cod" & _
    "_Ubicacion = Ubicaciones.Codigo"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT        CodMoneda, MonedaNombre, TCCompra AS ValorCompra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            M" & _
    "oneda"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'AdapterInventario
        '
        Me.AdapterInventario.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterInventario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterInventario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Barras", "Barras"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("PresentaCant", "PresentaCant"), New System.Data.Common.DataColumnMapping("CodPresentacion", "CodPresentacion"), New System.Data.Common.DataColumnMapping("CodMarca", "CodMarca"), New System.Data.Common.DataColumnMapping("SubFamilia", "SubFamilia"), New System.Data.Common.DataColumnMapping("Minima", "Minima"), New System.Data.Common.DataColumnMapping("PuntoMedio", "PuntoMedio"), New System.Data.Common.DataColumnMapping("Maxima", "Maxima"), New System.Data.Common.DataColumnMapping("SubUbicacion", "SubUbicacion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("MonedaCosto", "MonedaCosto"), New System.Data.Common.DataColumnMapping("PrecioBase", "PrecioBase"), New System.Data.Common.DataColumnMapping("Fletes", "Fletes"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("MonedaVenta", "MonedaVenta"), New System.Data.Common.DataColumnMapping("IVenta", "IVenta"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("Precio_B", "Precio_B"), New System.Data.Common.DataColumnMapping("Precio_C", "Precio_C"), New System.Data.Common.DataColumnMapping("Precio_D", "Precio_D"), New System.Data.Common.DataColumnMapping("Precio_Promo", "Precio_Promo"), New System.Data.Common.DataColumnMapping("Promo_Activa", "Promo_Activa"), New System.Data.Common.DataColumnMapping("Promo_Inicio", "Promo_Inicio"), New System.Data.Common.DataColumnMapping("Promo_Finaliza", "Promo_Finaliza"), New System.Data.Common.DataColumnMapping("Max_Comision", "Max_Comision"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("FechaIngreso", "FechaIngreso"), New System.Data.Common.DataColumnMapping("Servicio", "Servicio"), New System.Data.Common.DataColumnMapping("Inhabilitado", "Inhabilitado"), New System.Data.Common.DataColumnMapping("Imagen", "Imagen"), New System.Data.Common.DataColumnMapping("Proveedor", "Proveedor"), New System.Data.Common.DataColumnMapping("Precio_Sugerido", "Precio_Sugerido"), New System.Data.Common.DataColumnMapping("SugeridoIV", "SugeridoIV"), New System.Data.Common.DataColumnMapping("PreguntaPrecio", "PreguntaPrecio"), New System.Data.Common.DataColumnMapping("Existencia", "Existencia"), New System.Data.Common.DataColumnMapping("Lote", "Lote"), New System.Data.Common.DataColumnMapping("Consignacion", "Consignacion"), New System.Data.Common.DataColumnMapping("Id_Bodega", "Id_Bodega"), New System.Data.Common.DataColumnMapping("ExistenciaBodega", "ExistenciaBodega"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("CantidadDescarga", "CantidadDescarga"), New System.Data.Common.DataColumnMapping("CodigoDescarga", "CodigoDescarga"), New System.Data.Common.DataColumnMapping("DescargaOtro", "DescargaOtro"), New System.Data.Common.DataColumnMapping("Cod_PresentOtro", "Cod_PresentOtro"), New System.Data.Common.DataColumnMapping("CantidadPresentOtro", "CantidadPresentOtro"), New System.Data.Common.DataColumnMapping("pantalla", "pantalla"), New System.Data.Common.DataColumnMapping("clinica", "clinica"), New System.Data.Common.DataColumnMapping("mascotas", "mascotas"), New System.Data.Common.DataColumnMapping("receta", "receta"), New System.Data.Common.DataColumnMapping("peces", "peces"), New System.Data.Common.DataColumnMapping("taller", "taller"), New System.Data.Common.DataColumnMapping("barras2", "barras2"), New System.Data.Common.DataColumnMapping("barras3", "barras3"), New System.Data.Common.DataColumnMapping("promo3x1", "promo3x1"), New System.Data.Common.DataColumnMapping("Apartado", "Apartado"), New System.Data.Common.DataColumnMapping("orden", "orden"), New System.Data.Common.DataColumnMapping("bonificado", "bonificado"), New System.Data.Common.DataColumnMapping("encargado", "encargado"), New System.Data.Common.DataColumnMapping("serie", "serie"), New System.Data.Common.DataColumnMapping("armamento", "armamento"), New System.Data.Common.DataColumnMapping("tienda", "tienda"), New System.Data.Common.DataColumnMapping("maquinaria", "maquinaria"), New System.Data.Common.DataColumnMapping("productos_organicos", "productos_organicos"), New System.Data.Common.DataColumnMapping("rifa", "rifa")})})
        Me.AdapterInventario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Inventario] WHERE (([Codigo] = @Original_Codigo))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 0, "Barras"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@PresentaCant", System.Data.SqlDbType.Float, 0, "PresentaCant"), New System.Data.SqlClient.SqlParameter("@CodPresentacion", System.Data.SqlDbType.Int, 0, "CodPresentacion"), New System.Data.SqlClient.SqlParameter("@CodMarca", System.Data.SqlDbType.Int, 0, "CodMarca"), New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 0, "SubFamilia"), New System.Data.SqlClient.SqlParameter("@Minima", System.Data.SqlDbType.Float, 0, "Minima"), New System.Data.SqlClient.SqlParameter("@PuntoMedio", System.Data.SqlDbType.Float, 0, "PuntoMedio"), New System.Data.SqlClient.SqlParameter("@Maxima", System.Data.SqlDbType.Float, 0, "Maxima"), New System.Data.SqlClient.SqlParameter("@SubUbicacion", System.Data.SqlDbType.VarChar, 0, "SubUbicacion"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@MonedaCosto", System.Data.SqlDbType.Int, 0, "MonedaCosto"), New System.Data.SqlClient.SqlParameter("@PrecioBase", System.Data.SqlDbType.Float, 0, "PrecioBase"), New System.Data.SqlClient.SqlParameter("@Fletes", System.Data.SqlDbType.Float, 0, "Fletes"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 0, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 0, "Costo"), New System.Data.SqlClient.SqlParameter("@MonedaVenta", System.Data.SqlDbType.Int, 0, "MonedaVenta"), New System.Data.SqlClient.SqlParameter("@IVenta", System.Data.SqlDbType.Float, 0, "IVenta"), New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 0, "Precio_A"), New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 0, "Precio_B"), New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 0, "Precio_C"), New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 0, "Precio_D"), New System.Data.SqlClient.SqlParameter("@Precio_Promo", System.Data.SqlDbType.Float, 0, "Precio_Promo"), New System.Data.SqlClient.SqlParameter("@Promo_Activa", System.Data.SqlDbType.Bit, 0, "Promo_Activa"), New System.Data.SqlClient.SqlParameter("@Promo_Inicio", System.Data.SqlDbType.SmallDateTime, 0, "Promo_Inicio"), New System.Data.SqlClient.SqlParameter("@Promo_Finaliza", System.Data.SqlDbType.SmallDateTime, 0, "Promo_Finaliza"), New System.Data.SqlClient.SqlParameter("@Max_Comision", System.Data.SqlDbType.Float, 0, "Max_Comision"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 0, "FechaIngreso"), New System.Data.SqlClient.SqlParameter("@Servicio", System.Data.SqlDbType.Bit, 0, "Servicio"), New System.Data.SqlClient.SqlParameter("@Inhabilitado", System.Data.SqlDbType.Bit, 0, "Inhabilitado"), New System.Data.SqlClient.SqlParameter("@Imagen", System.Data.SqlDbType.Image, 0, "Imagen"), New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 0, "Proveedor"), New System.Data.SqlClient.SqlParameter("@Precio_Sugerido", System.Data.SqlDbType.Float, 0, "Precio_Sugerido"), New System.Data.SqlClient.SqlParameter("@SugeridoIV", System.Data.SqlDbType.Float, 0, "SugeridoIV"), New System.Data.SqlClient.SqlParameter("@PreguntaPrecio", System.Data.SqlDbType.Bit, 0, "PreguntaPrecio"), New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Float, 0, "Existencia"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.Bit, 0, "Lote"), New System.Data.SqlClient.SqlParameter("@Consignacion", System.Data.SqlDbType.Bit, 0, "Consignacion"), New System.Data.SqlClient.SqlParameter("@Id_Bodega", System.Data.SqlDbType.Int, 0, "Id_Bodega"), New System.Data.SqlClient.SqlParameter("@ExistenciaBodega", System.Data.SqlDbType.Float, 0, "ExistenciaBodega"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.VarChar, 0, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@CantidadDescarga", System.Data.SqlDbType.Float, 0, "CantidadDescarga"), New System.Data.SqlClient.SqlParameter("@CodigoDescarga", System.Data.SqlDbType.VarChar, 0, "CodigoDescarga"), New System.Data.SqlClient.SqlParameter("@DescargaOtro", System.Data.SqlDbType.Bit, 0, "DescargaOtro"), New System.Data.SqlClient.SqlParameter("@Cod_PresentOtro", System.Data.SqlDbType.Int, 0, "Cod_PresentOtro"), New System.Data.SqlClient.SqlParameter("@CantidadPresentOtro", System.Data.SqlDbType.Float, 0, "CantidadPresentOtro"), New System.Data.SqlClient.SqlParameter("@pantalla", System.Data.SqlDbType.Bit, 0, "pantalla"), New System.Data.SqlClient.SqlParameter("@clinica", System.Data.SqlDbType.Bit, 0, "clinica"), New System.Data.SqlClient.SqlParameter("@mascotas", System.Data.SqlDbType.Bit, 0, "mascotas"), New System.Data.SqlClient.SqlParameter("@receta", System.Data.SqlDbType.Bit, 0, "receta"), New System.Data.SqlClient.SqlParameter("@peces", System.Data.SqlDbType.Bit, 0, "peces"), New System.Data.SqlClient.SqlParameter("@taller", System.Data.SqlDbType.Bit, 0, "taller"), New System.Data.SqlClient.SqlParameter("@barras2", System.Data.SqlDbType.VarChar, 0, "barras2"), New System.Data.SqlClient.SqlParameter("@barras3", System.Data.SqlDbType.VarChar, 0, "barras3"), New System.Data.SqlClient.SqlParameter("@promo3x1", System.Data.SqlDbType.Bit, 0, "promo3x1"), New System.Data.SqlClient.SqlParameter("@Apartado", System.Data.SqlDbType.Float, 0, "Apartado"), New System.Data.SqlClient.SqlParameter("@orden", System.Data.SqlDbType.Bit, 0, "orden"), New System.Data.SqlClient.SqlParameter("@bonificado", System.Data.SqlDbType.Bit, 0, "bonificado"), New System.Data.SqlClient.SqlParameter("@encargado", System.Data.SqlDbType.NVarChar, 0, "encargado"), New System.Data.SqlClient.SqlParameter("@serie", System.Data.SqlDbType.BigInt, 0, "serie"), New System.Data.SqlClient.SqlParameter("@armamento", System.Data.SqlDbType.Bit, 0, "armamento"), New System.Data.SqlClient.SqlParameter("@tienda", System.Data.SqlDbType.Bit, 0, "tienda"), New System.Data.SqlClient.SqlParameter("@maquinaria", System.Data.SqlDbType.Bit, 0, "maquinaria"), New System.Data.SqlClient.SqlParameter("@productos_organicos", System.Data.SqlDbType.Bit, 0, "productos_organicos"), New System.Data.SqlClient.SqlParameter("@rifa", System.Data.SqlDbType.BigInt, 0, "rifa")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 255, "Barras"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@PresentaCant", System.Data.SqlDbType.Float, 8, "PresentaCant"), New System.Data.SqlClient.SqlParameter("@CodPresentacion", System.Data.SqlDbType.Int, 4, "CodPresentacion"), New System.Data.SqlClient.SqlParameter("@CodMarca", System.Data.SqlDbType.Int, 4, "CodMarca"), New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"), New System.Data.SqlClient.SqlParameter("@Minima", System.Data.SqlDbType.Float, 8, "Minima"), New System.Data.SqlClient.SqlParameter("@PuntoMedio", System.Data.SqlDbType.Float, 8, "PuntoMedio"), New System.Data.SqlClient.SqlParameter("@Maxima", System.Data.SqlDbType.Float, 8, "Maxima"), New System.Data.SqlClient.SqlParameter("@SubUbicacion", System.Data.SqlDbType.VarChar, 10, "SubUbicacion"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@MonedaCosto", System.Data.SqlDbType.Int, 4, "MonedaCosto"), New System.Data.SqlClient.SqlParameter("@PrecioBase", System.Data.SqlDbType.Float, 8, "PrecioBase"), New System.Data.SqlClient.SqlParameter("@Fletes", System.Data.SqlDbType.Float, 8, "Fletes"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@MonedaVenta", System.Data.SqlDbType.Int, 4, "MonedaVenta"), New System.Data.SqlClient.SqlParameter("@IVenta", System.Data.SqlDbType.Float, 8, "IVenta"), New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"), New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"), New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"), New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"), New System.Data.SqlClient.SqlParameter("@Precio_Promo", System.Data.SqlDbType.Float, 8, "Precio_Promo"), New System.Data.SqlClient.SqlParameter("@Promo_Activa", System.Data.SqlDbType.Bit, 1, "Promo_Activa"), New System.Data.SqlClient.SqlParameter("@Promo_Inicio", System.Data.SqlDbType.SmallDateTime, 4, "Promo_Inicio"), New System.Data.SqlClient.SqlParameter("@Promo_Finaliza", System.Data.SqlDbType.SmallDateTime, 4, "Promo_Finaliza"), New System.Data.SqlClient.SqlParameter("@Max_Comision", System.Data.SqlDbType.Float, 8, "Max_Comision"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"), New System.Data.SqlClient.SqlParameter("@Servicio", System.Data.SqlDbType.Bit, 1, "Servicio"), New System.Data.SqlClient.SqlParameter("@Inhabilitado", System.Data.SqlDbType.Bit, 1, "Inhabilitado"), New System.Data.SqlClient.SqlParameter("@Imagen", System.Data.SqlDbType.Image, 2147483647, "Imagen"), New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"), New System.Data.SqlClient.SqlParameter("@Precio_Sugerido", System.Data.SqlDbType.Float, 8, "Precio_Sugerido"), New System.Data.SqlClient.SqlParameter("@SugeridoIV", System.Data.SqlDbType.Float, 8, "SugeridoIV"), New System.Data.SqlClient.SqlParameter("@PreguntaPrecio", System.Data.SqlDbType.Bit, 1, "PreguntaPrecio"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.Bit, 1, "Lote"), New System.Data.SqlClient.SqlParameter("@Consignacion", System.Data.SqlDbType.Bit, 1, "Consignacion"), New System.Data.SqlClient.SqlParameter("@Id_Bodega", System.Data.SqlDbType.Int, 4, "Id_Bodega"), New System.Data.SqlClient.SqlParameter("@ExistenciaBodega", System.Data.SqlDbType.Float, 8, "ExistenciaBodega"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.VarChar, 255, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@CantidadDescarga", System.Data.SqlDbType.Float, 8, "CantidadDescarga"), New System.Data.SqlClient.SqlParameter("@CodigoDescarga", System.Data.SqlDbType.VarChar, 255, "CodigoDescarga"), New System.Data.SqlClient.SqlParameter("@DescargaOtro", System.Data.SqlDbType.Bit, 1, "DescargaOtro"), New System.Data.SqlClient.SqlParameter("@Cod_PresentOtro", System.Data.SqlDbType.Int, 4, "Cod_PresentOtro"), New System.Data.SqlClient.SqlParameter("@CantidadPresentOtro", System.Data.SqlDbType.Float, 8, "CantidadPresentOtro"), New System.Data.SqlClient.SqlParameter("@pantalla", System.Data.SqlDbType.Bit, 1, "pantalla"), New System.Data.SqlClient.SqlParameter("@clinica", System.Data.SqlDbType.Bit, 1, "clinica"), New System.Data.SqlClient.SqlParameter("@mascotas", System.Data.SqlDbType.Bit, 1, "mascotas"), New System.Data.SqlClient.SqlParameter("@receta", System.Data.SqlDbType.Bit, 1, "receta"), New System.Data.SqlClient.SqlParameter("@peces", System.Data.SqlDbType.Bit, 1, "peces"), New System.Data.SqlClient.SqlParameter("@taller", System.Data.SqlDbType.Bit, 1, "taller"), New System.Data.SqlClient.SqlParameter("@barras2", System.Data.SqlDbType.VarChar, 255, "barras2"), New System.Data.SqlClient.SqlParameter("@barras3", System.Data.SqlDbType.VarChar, 255, "barras3"), New System.Data.SqlClient.SqlParameter("@promo3x1", System.Data.SqlDbType.Bit, 1, "promo3x1"), New System.Data.SqlClient.SqlParameter("@Apartado", System.Data.SqlDbType.Float, 8, "Apartado"), New System.Data.SqlClient.SqlParameter("@orden", System.Data.SqlDbType.Bit, 1, "orden"), New System.Data.SqlClient.SqlParameter("@bonificado", System.Data.SqlDbType.Bit, 1, "bonificado"), New System.Data.SqlClient.SqlParameter("@encargado", System.Data.SqlDbType.NVarChar, 50, "encargado"), New System.Data.SqlClient.SqlParameter("@serie", System.Data.SqlDbType.BigInt, 8, "serie"), New System.Data.SqlClient.SqlParameter("@armamento", System.Data.SqlDbType.Bit, 1, "armamento"), New System.Data.SqlClient.SqlParameter("@tienda", System.Data.SqlDbType.Bit, 1, "tienda"), New System.Data.SqlClient.SqlParameter("@maquinaria", System.Data.SqlDbType.Bit, 1, "maquinaria"), New System.Data.SqlClient.SqlParameter("@productos_organicos", System.Data.SqlDbType.Bit, 1, "productos_organicos"), New System.Data.SqlClient.SqlParameter("@rifa", System.Data.SqlDbType.BigInt, 8, "rifa"), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""DESKTOP-NCOO4KP"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""."";persist security info=False;initial catalog=Seepos"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'TxtCanPresentacion
        '
        Me.TxtCanPresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCanPresentacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.PresentaCant", True))
        Me.TxtCanPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCanPresentacion.ForeColor = System.Drawing.Color.Blue
        Me.TxtCanPresentacion.Location = New System.Drawing.Point(504, 20)
        Me.TxtCanPresentacion.Name = "TxtCanPresentacion"
        Me.TxtCanPresentacion.Size = New System.Drawing.Size(32, 20)
        Me.TxtCanPresentacion.TabIndex = 5
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Agregar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Eliminar"
        '
        'AdapterArticulosXproveedor
        '
        Me.AdapterArticulosXproveedor.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterArticulosXproveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Articulos x Proveedor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoArticulo", "CodigoArticulo"), New System.Data.Common.DataColumnMapping("CodigoProveedor", "CodigoProveedor"), New System.Data.Common.DataColumnMapping("FechaUltimaCompra", "FechaUltimaCompra"), New System.Data.Common.DataColumnMapping("UltimoCosto", "UltimoCosto"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = resources.GetString("SqlSelectCommand8.CommandText")
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'colFechaUltimaCompra
        '
        Me.colFechaUltimaCompra.Caption = "Fecha Compra"
        Me.colFechaUltimaCompra.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFechaUltimaCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaUltimaCompra.FieldName = "FechaUltimaCompra"
        Me.colFechaUltimaCompra.FilterInfo = ColumnFilterInfo10
        Me.colFechaUltimaCompra.Name = "colFechaUltimaCompra"
        Me.colFechaUltimaCompra.Visible = True
        Me.colFechaUltimaCompra.Width = 48
        '
        'colCodigoProveedor
        '
        Me.colCodigoProveedor.Caption = "Proveedor"
        Me.colCodigoProveedor.FieldName = "CodigoProveedor"
        Me.colCodigoProveedor.FilterInfo = ColumnFilterInfo11
        Me.colCodigoProveedor.Name = "colCodigoProveedor"
        Me.colCodigoProveedor.Visible = True
        Me.colCodigoProveedor.Width = 205
        '
        'colUltimoCosto
        '
        Me.colUltimoCosto.Caption = "Costo"
        Me.colUltimoCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUltimoCosto.FieldName = "CodigoArticulo"
        Me.colUltimoCosto.FilterInfo = ColumnFilterInfo12
        Me.colUltimoCosto.Name = "colUltimoCosto"
        Me.colUltimoCosto.Visible = True
        Me.colUltimoCosto.Width = 63
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colCodigoProveedor)
        Me.GridBand1.Columns.Add(Me.colFechaUltimaCompra)
        Me.GridBand1.Columns.Add(Me.colUltimoCosto)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Visible = False
        Me.GridBand1.Width = 10
        '
        'Text_Cod_AUX
        '
        Me.Text_Cod_AUX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_Cod_AUX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario2.Codigo", True))
        Me.Text_Cod_AUX.Location = New System.Drawing.Point(53, 12)
        Me.Text_Cod_AUX.Name = "Text_Cod_AUX"
        Me.Text_Cod_AUX.ReadOnly = True
        Me.Text_Cod_AUX.Size = New System.Drawing.Size(85, 13)
        Me.Text_Cod_AUX.TabIndex = 61
        Me.Text_Cod_AUX.TabStop = False
        '
        'Adaptador_Inventraio_AUX
        '
        Me.Adaptador_Inventraio_AUX.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adaptador_Inventraio_AUX.InsertCommand = Me.SqlInsertCommand3
        Me.Adaptador_Inventraio_AUX.SelectCommand = Me.SqlSelectCommand9
        Me.Adaptador_Inventraio_AUX.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo")})})
        Me.Adaptador_Inventraio_AUX.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Inventario WHERE (Codigo = @Original_Codigo)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Inventario(Codigo) VALUES (@Codigo); SELECT Codigo FROM Inventario WH" & _
    "ERE (Codigo = @Codigo) ORDER BY Codigo"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Codigo FROM Inventario ORDER BY Codigo"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Inventario SET Codigo = @Codigo WHERE (Codigo = @Original_Codigo); SELECT " & _
    "Codigo FROM Inventario WHERE (Codigo = @Codigo) ORDER BY Codigo"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Ck_Consignacion
        '
        Me.Ck_Consignacion.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.Consignacion", True))
        Me.Ck_Consignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_Consignacion.ForeColor = System.Drawing.Color.White
        Me.Ck_Consignacion.Location = New System.Drawing.Point(8, 14)
        Me.Ck_Consignacion.Name = "Ck_Consignacion"
        Me.Ck_Consignacion.Size = New System.Drawing.Size(152, 16)
        Me.Ck_Consignacion.TabIndex = 2
        Me.Ck_Consignacion.Text = "Consignación"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.ckSoloContado)
        Me.Panel2.Controls.Add(Me.ckMostrar)
        Me.Panel2.Controls.Add(Me.ckSinDecimales)
        Me.Panel2.Controls.Add(Me.lblFechaActualizacion)
        Me.Panel2.Controls.Add(Me.ckActualizado)
        Me.Panel2.Controls.Add(Me.Label46)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.ckpantalla)
        Me.Panel2.Controls.Add(Me.TxtPresentacion)
        Me.Panel2.Controls.Add(Me.ChkOtro)
        Me.Panel2.Controls.Add(Me.TxtCodOtro)
        Me.Panel2.Controls.Add(Me.TxtDesOtro)
        Me.Panel2.Controls.Add(Me.TxtCantOtro)
        Me.Panel2.Controls.Add(Me.LbCantidad)
        Me.Panel2.Controls.Add(Me.LbPresOtro)
        Me.Panel2.Controls.Add(Me.LbCodOtro)
        Me.Panel2.Controls.Add(Me.LbDescOtro)
        Me.Panel2.Controls.Add(Me.TxtCantidad)
        Me.Panel2.Controls.Add(Me.txtCod_Articulo)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.cmboxProveedor)
        Me.Panel2.Controls.Add(Me.Label41)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ckHabilitaFamilia)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ComboBoxFamilia)
        Me.Panel2.Controls.Add(Me.ComboBoxMarca)
        Me.Panel2.Controls.Add(Me.TxtDescripcion)
        Me.Panel2.Controls.Add(Me.TxtCanPresentacion)
        Me.Panel2.Controls.Add(Me.TxtBarras)
        Me.Panel2.Controls.Add(Me.ComboBoxPresentacion)
        Me.Panel2.Controls.Add(Me.ComboBox_Ubicacion_SubUbicacion)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblCodigoProveedor)
        Me.Panel2.Location = New System.Drawing.Point(4, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 188)
        Me.Panel2.TabIndex = 0
        '
        'ckSoloContado
        '
        Me.ckSoloContado.AutoSize = True
        Me.ckSoloContado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckSoloContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSoloContado.Location = New System.Drawing.Point(387, 4)
        Me.ckSoloContado.Name = "ckSoloContado"
        Me.ckSoloContado.Size = New System.Drawing.Size(105, 17)
        Me.ckSoloContado.TabIndex = 78
        Me.ckSoloContado.Text = "Solo de Contado"
        Me.ckSoloContado.UseVisualStyleBackColor = False
        '
        'ckMostrar
        '
        Me.ckMostrar.AutoSize = True
        Me.ckMostrar.Location = New System.Drawing.Point(5, 83)
        Me.ckMostrar.Name = "ckMostrar"
        Me.ckMostrar.Size = New System.Drawing.Size(61, 17)
        Me.ckMostrar.TabIndex = 22
        Me.ckMostrar.Text = "Mostrar"
        Me.ckMostrar.UseVisualStyleBackColor = True
        '
        'ckSinDecimales
        '
        Me.ckSinDecimales.AutoSize = True
        Me.ckSinDecimales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckSinDecimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSinDecimales.Location = New System.Drawing.Point(264, 3)
        Me.ckSinDecimales.Name = "ckSinDecimales"
        Me.ckSinDecimales.Size = New System.Drawing.Size(117, 17)
        Me.ckSinDecimales.TabIndex = 77
        Me.ckSinDecimales.Text = "articulos Completos"
        Me.ckSinDecimales.UseVisualStyleBackColor = False
        '
        'lblFechaActualizacion
        '
        Me.lblFechaActualizacion.AutoSize = True
        Me.lblFechaActualizacion.Location = New System.Drawing.Point(265, 5)
        Me.lblFechaActualizacion.Name = "lblFechaActualizacion"
        Me.lblFechaActualizacion.Size = New System.Drawing.Size(0, 13)
        Me.lblFechaActualizacion.TabIndex = 76
        '
        'ckActualizado
        '
        Me.ckActualizado.AutoSize = True
        Me.ckActualizado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckActualizado.Enabled = False
        Me.ckActualizado.Location = New System.Drawing.Point(177, 4)
        Me.ckActualizado.Name = "ckActualizado"
        Me.ckActualizado.Size = New System.Drawing.Size(81, 17)
        Me.ckActualizado.TabIndex = 75
        Me.ckActualizado.Text = "Actualizado"
        Me.ckActualizado.UseVisualStyleBackColor = False
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label46.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(92, 80)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(78, 14)
        Me.Label46.TabIndex = 74
        Me.Label46.Text = "Cod Barras 3"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.barras3", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(92, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 13)
        Me.TextBox2.TabIndex = 73
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label42.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label42.Location = New System.Drawing.Point(92, 44)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 14)
        Me.Label42.TabIndex = 72
        Me.Label42.Text = "Cod Barras 2"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.barras2", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(92, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 13)
        Me.TextBox1.TabIndex = 71
        '
        'ckpantalla
        '
        Me.ckpantalla.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckpantalla.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.pantalla", True))
        Me.ckpantalla.Location = New System.Drawing.Point(152, 116)
        Me.ckpantalla.Name = "ckpantalla"
        Me.ckpantalla.Size = New System.Drawing.Size(16, 16)
        Me.ckpantalla.TabIndex = 70
        Me.ckpantalla.UseVisualStyleBackColor = False
        '
        'TxtPresentacion
        '
        Me.TxtPresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPresentacion.Enabled = False
        Me.TxtPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPresentacion.ForeColor = System.Drawing.Color.Blue
        Me.TxtPresentacion.Location = New System.Drawing.Point(597, 153)
        Me.TxtPresentacion.Name = "TxtPresentacion"
        Me.TxtPresentacion.ReadOnly = True
        Me.TxtPresentacion.Size = New System.Drawing.Size(72, 20)
        Me.TxtPresentacion.TabIndex = 66
        Me.TxtPresentacion.Visible = False
        '
        'ChkOtro
        '
        Me.ChkOtro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ChkOtro.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.DescargaOtro", True))
        Me.ChkOtro.Location = New System.Drawing.Point(4, 108)
        Me.ChkOtro.Name = "ChkOtro"
        Me.ChkOtro.Size = New System.Drawing.Size(80, 28)
        Me.ChkOtro.TabIndex = 63
        Me.ChkOtro.Text = "Rebaja otro Articulo"
        Me.ChkOtro.UseVisualStyleBackColor = False
        '
        'TxtCodOtro
        '
        Me.TxtCodOtro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodOtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodOtro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.CodigoDescarga", True))
        Me.TxtCodOtro.Enabled = False
        Me.TxtCodOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodOtro.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodOtro.Location = New System.Drawing.Point(4, 156)
        Me.TxtCodOtro.Name = "TxtCodOtro"
        Me.TxtCodOtro.Size = New System.Drawing.Size(79, 13)
        Me.TxtCodOtro.TabIndex = 62
        Me.TxtCodOtro.Visible = False
        '
        'TxtDesOtro
        '
        Me.TxtDesOtro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDesOtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesOtro.Enabled = False
        Me.TxtDesOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesOtro.ForeColor = System.Drawing.Color.Blue
        Me.TxtDesOtro.Location = New System.Drawing.Point(88, 156)
        Me.TxtDesOtro.Name = "TxtDesOtro"
        Me.TxtDesOtro.ReadOnly = True
        Me.TxtDesOtro.Size = New System.Drawing.Size(471, 13)
        Me.TxtDesOtro.TabIndex = 59
        Me.TxtDesOtro.Visible = False
        '
        'TxtCantOtro
        '
        Me.TxtCantOtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantOtro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.CantidadPresentOtro", True))
        Me.TxtCantOtro.Enabled = False
        Me.TxtCantOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantOtro.ForeColor = System.Drawing.Color.Blue
        Me.TxtCantOtro.Location = New System.Drawing.Point(565, 153)
        Me.TxtCantOtro.Name = "TxtCantOtro"
        Me.TxtCantOtro.ReadOnly = True
        Me.TxtCantOtro.Size = New System.Drawing.Size(32, 20)
        Me.TxtCantOtro.TabIndex = 61
        Me.TxtCantOtro.Visible = False
        '
        'LbCantidad
        '
        Me.LbCantidad.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbCantidad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LbCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCantidad.Location = New System.Drawing.Point(4, 172)
        Me.LbCantidad.Name = "LbCantidad"
        Me.LbCantidad.Size = New System.Drawing.Size(148, 14)
        Me.LbCantidad.TabIndex = 64
        Me.LbCantidad.Text = "Cantidad por presentación"
        Me.LbCantidad.Visible = False
        '
        'LbPresOtro
        '
        Me.LbPresOtro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPresOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbPresOtro.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LbPresOtro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbPresOtro.Location = New System.Drawing.Point(565, 137)
        Me.LbPresOtro.Name = "LbPresOtro"
        Me.LbPresOtro.Size = New System.Drawing.Size(112, 14)
        Me.LbPresOtro.TabIndex = 60
        Me.LbPresOtro.Text = "Presentación"
        Me.LbPresOtro.Visible = False
        '
        'LbCodOtro
        '
        Me.LbCodOtro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCodOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbCodOtro.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LbCodOtro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCodOtro.Location = New System.Drawing.Point(4, 136)
        Me.LbCodOtro.Name = "LbCodOtro"
        Me.LbCodOtro.Size = New System.Drawing.Size(78, 14)
        Me.LbCodOtro.TabIndex = 57
        Me.LbCodOtro.Text = "Código"
        Me.LbCodOtro.Visible = False
        '
        'LbDescOtro
        '
        Me.LbDescOtro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDescOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbDescOtro.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LbDescOtro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbDescOtro.Location = New System.Drawing.Point(88, 136)
        Me.LbDescOtro.Name = "LbDescOtro"
        Me.LbDescOtro.Size = New System.Drawing.Size(416, 14)
        Me.LbDescOtro.TabIndex = 58
        Me.LbDescOtro.Text = "Descripción"
        Me.LbDescOtro.Visible = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.CantidadDescarga", True))
        Me.TxtCantidad.Enabled = False
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.ForeColor = System.Drawing.Color.Blue
        Me.TxtCantidad.Location = New System.Drawing.Point(160, 172)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(84, 13)
        Me.TxtCantidad.TabIndex = 65
        Me.TxtCantidad.Visible = False
        '
        'txtCod_Articulo
        '
        Me.txtCod_Articulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCod_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCod_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Cod_Articulo", True))
        Me.txtCod_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod_Articulo.ForeColor = System.Drawing.Color.Blue
        Me.txtCod_Articulo.Location = New System.Drawing.Point(4, 24)
        Me.txtCod_Articulo.Name = "txtCod_Articulo"
        Me.txtCod_Articulo.Size = New System.Drawing.Size(79, 13)
        Me.txtCod_Articulo.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(4, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 14)
        Me.Label31.TabIndex = 30
        Me.Label31.Text = "Cod Barras"
        '
        'cmboxProveedor
        '
        Me.cmboxProveedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.Proveedor", True))
        Me.cmboxProveedor.DataSource = Me.DataSetInventario
        Me.cmboxProveedor.DisplayMember = "Proveedores.Nombre"
        Me.cmboxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmboxProveedor.ForeColor = System.Drawing.Color.Blue
        Me.cmboxProveedor.ItemHeight = 13
        Me.cmboxProveedor.Location = New System.Drawing.Point(268, 88)
        Me.cmboxProveedor.Name = "cmboxProveedor"
        Me.cmboxProveedor.Size = New System.Drawing.Size(406, 21)
        Me.cmboxProveedor.TabIndex = 12
        Me.cmboxProveedor.ValueMember = "Proveedores.CodigoProv"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(180, 92)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 16)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "Proveedor "
        '
        'lblCodigoProveedor
        '
        Me.lblCodigoProveedor.Location = New System.Drawing.Point(444, 116)
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Size = New System.Drawing.Size(100, 16)
        Me.lblCodigoProveedor.TabIndex = 29
        Me.lblCodigoProveedor.Text = "Label42"
        Me.lblCodigoProveedor.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cód. Int."
        '
        'AdapterBitacora
        '
        Me.AdapterBitacora.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterBitacora.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterBitacora.SelectCommand = Me.SqlSelectCommand11
        Me.AdapterBitacora.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bitacora", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Secuencia", "Secuencia"), New System.Data.Common.DataColumnMapping("Tabla", "Tabla"), New System.Data.Common.DataColumnMapping("Campo_Clave", "Campo_Clave"), New System.Data.Common.DataColumnMapping("DescripcionCampo", "DescripcionCampo"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("VentaA", "VentaA"), New System.Data.Common.DataColumnMapping("VentaB", "VentaB"), New System.Data.Common.DataColumnMapping("VentaC", "VentaC"), New System.Data.Common.DataColumnMapping("VentaD", "VentaD")})})
        Me.AdapterBitacora.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Secuencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Secuencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Campo_Clave", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Campo_Clave", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionCampo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCampo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tabla", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tabla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaA", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaB", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaC", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaD", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 75, "Tabla"), New System.Data.SqlClient.SqlParameter("@Campo_Clave", System.Data.SqlDbType.VarChar, 75, "Campo_Clave"), New System.Data.SqlClient.SqlParameter("@DescripcionCampo", System.Data.SqlDbType.VarChar, 250, "DescripcionCampo"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 75, "Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 150, "Usuario"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@VentaA", System.Data.SqlDbType.Float, 8, "VentaA"), New System.Data.SqlClient.SqlParameter("@VentaB", System.Data.SqlDbType.Float, 8, "VentaB"), New System.Data.SqlClient.SqlParameter("@VentaC", System.Data.SqlDbType.Float, 8, "VentaC"), New System.Data.SqlClient.SqlParameter("@VentaD", System.Data.SqlDbType.Float, 8, "VentaD")})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Secuencia, Tabla, Campo_Clave, DescripcionCampo, Accion, Fecha, Usuario, C" & _
    "osto, VentaA, VentaB, VentaC, VentaD FROM Bitacora"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 75, "Tabla"), New System.Data.SqlClient.SqlParameter("@Campo_Clave", System.Data.SqlDbType.VarChar, 75, "Campo_Clave"), New System.Data.SqlClient.SqlParameter("@DescripcionCampo", System.Data.SqlDbType.VarChar, 250, "DescripcionCampo"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 75, "Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 150, "Usuario"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@VentaA", System.Data.SqlDbType.Float, 8, "VentaA"), New System.Data.SqlClient.SqlParameter("@VentaB", System.Data.SqlDbType.Float, 8, "VentaB"), New System.Data.SqlClient.SqlParameter("@VentaC", System.Data.SqlDbType.Float, 8, "VentaC"), New System.Data.SqlClient.SqlParameter("@VentaD", System.Data.SqlDbType.Float, 8, "VentaD"), New System.Data.SqlClient.SqlParameter("@Original_Secuencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Secuencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Campo_Clave", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Campo_Clave", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionCampo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCampo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tabla", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tabla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaA", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaB", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaC", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.BigInt, 8, "Secuencia")})
        '
        'daProveedores
        '
        Me.daProveedores.SelectCommand = Me.SqlSelectCommand12
        Me.daProveedores.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT CodigoProv, Nombre FROM Proveedores"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        '
        'ckVerCodBarraInv
        '
        Me.ckVerCodBarraInv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckVerCodBarraInv.Location = New System.Drawing.Point(437, 515)
        Me.ckVerCodBarraInv.Name = "ckVerCodBarraInv"
        Me.ckVerCodBarraInv.Size = New System.Drawing.Size(118, 16)
        Me.ckVerCodBarraInv.TabIndex = 69
        Me.ckVerCodBarraInv.Text = "Verificar Cód. Barra"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtPorSugerido)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.txtVentaSugerido)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.txtSugeridoIV)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox5.Location = New System.Drawing.Point(356, 572)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(333, 52)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Precio Venta Sugerido:"
        Me.GroupBox5.Visible = False
        '
        'txtPorSugerido
        '
        Me.txtPorSugerido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorSugerido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorSugerido.ForeColor = System.Drawing.Color.Blue
        Me.txtPorSugerido.Location = New System.Drawing.Point(12, 32)
        Me.txtPorSugerido.Name = "txtPorSugerido"
        Me.txtPorSugerido.Size = New System.Drawing.Size(52, 13)
        Me.txtPorSugerido.TabIndex = 1
        Me.txtPorSugerido.Text = "0.00"
        Me.txtPorSugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label43.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label43.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label43.Location = New System.Drawing.Point(88, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(96, 12)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Venta Sugerido"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtVentaSugerido
        '
        Me.txtVentaSugerido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVentaSugerido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Precio_Sugerido", True))
        Me.txtVentaSugerido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaSugerido.ForeColor = System.Drawing.Color.Blue
        Me.txtVentaSugerido.Location = New System.Drawing.Point(88, 32)
        Me.txtVentaSugerido.Name = "txtVentaSugerido"
        Me.txtVentaSugerido.Size = New System.Drawing.Size(96, 13)
        Me.txtVentaSugerido.TabIndex = 3
        Me.txtVentaSugerido.Text = "0.00"
        Me.txtVentaSugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label44.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label44.Location = New System.Drawing.Point(197, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(120, 12)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Venta Sugerido + I.V."
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSugeridoIV
        '
        Me.txtSugeridoIV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSugeridoIV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.SugeridoIV", True))
        Me.txtSugeridoIV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSugeridoIV.ForeColor = System.Drawing.Color.Blue
        Me.txtSugeridoIV.Location = New System.Drawing.Point(197, 32)
        Me.txtSugeridoIV.Name = "txtSugeridoIV"
        Me.txtSugeridoIV.Size = New System.Drawing.Size(120, 13)
        Me.txtSugeridoIV.TabIndex = 5
        Me.txtSugeridoIV.Text = "0.00"
        Me.txtSugeridoIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label45.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(12, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(52, 12)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Porc."
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Teal
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.TxtExistenciaBodega)
        Me.GroupBox6.Controls.Add(Me.Ck_Consignacion)
        Me.GroupBox6.Controls.Add(Me.ComboBoxBodegas)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(8, 404)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(336, 62)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bodega"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(264, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Existencia"
        '
        'TxtExistenciaBodega
        '
        Me.TxtExistenciaBodega.BackColor = System.Drawing.Color.White
        Me.TxtExistenciaBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtExistenciaBodega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.ExistenciaBodega", True))
        Me.TxtExistenciaBodega.FieldReference = Nothing
        Me.TxtExistenciaBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExistenciaBodega.ForeColor = System.Drawing.Color.Red
        Me.TxtExistenciaBodega.Location = New System.Drawing.Point(264, 28)
        Me.TxtExistenciaBodega.MaskEdit = ""
        Me.TxtExistenciaBodega.Name = "TxtExistenciaBodega"
        Me.TxtExistenciaBodega.ReadOnly = True
        Me.TxtExistenciaBodega.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtExistenciaBodega.Required = False
        Me.TxtExistenciaBodega.ShowErrorIcon = False
        Me.TxtExistenciaBodega.Size = New System.Drawing.Size(60, 29)
        Me.TxtExistenciaBodega.TabIndex = 5
        Me.TxtExistenciaBodega.Text = "0.00"
        Me.TxtExistenciaBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtExistenciaBodega.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.TxtExistenciaBodega.ValidText = ""
        '
        'AdapterLote
        '
        Me.AdapterLote.SelectCommand = Me.SqlSelectCommand13
        Me.AdapterLote.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT Numero, Vencimiento, Cant_Actual, Cod_Articulo, Id FROM Lotes"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.BurlyWood
        Me.TabPage1.Controls.Add(Me.txtCostoTienda)
        Me.TabPage1.Controls.Add(Me.Label58)
        Me.TabPage1.Controls.Add(Me.ckMAG)
        Me.TabPage1.Controls.Add(Me.Label54)
        Me.TabPage1.Controls.Add(Me.cboTipoImpuesto)
        Me.TabPage1.Controls.Add(Me.txtcosto_real)
        Me.TabPage1.Controls.Add(Me.Label49)
        Me.TabPage1.Controls.Add(Me.TxtCostoEquivalente)
        Me.TabPage1.Controls.Add(Me.TxtOtrosCargosEquivalente)
        Me.TabPage1.Controls.Add(Me.TxtFleteEquivalente)
        Me.TabPage1.Controls.Add(Me.TextBoxValorMonedaEnCosto)
        Me.TabPage1.Controls.Add(Me.TxtBaseEquivalente)
        Me.TabPage1.Controls.Add(Me.TxtImpuesto)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TxtFlete)
        Me.TabPage1.Controls.Add(Me.TxtOtros)
        Me.TabPage1.Controls.Add(Me.TxtCosto)
        Me.TabPage1.Controls.Add(Me.ComboBoxMoneda)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.TxtBase)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(331, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Último Costo"
        '
        'txtCostoTienda
        '
        Me.txtCostoTienda.EditValue = "0.00"
        Me.txtCostoTienda.Location = New System.Drawing.Point(99, 152)
        Me.txtCostoTienda.Name = "txtCostoTienda"
        '
        '
        '
        Me.txtCostoTienda.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtCostoTienda.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostoTienda.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtCostoTienda.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostoTienda.Properties.Enabled = False
        Me.txtCostoTienda.Properties.ReadOnly = True
        Me.txtCostoTienda.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCostoTienda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostoTienda.Size = New System.Drawing.Size(80, 19)
        Me.txtCostoTienda.TabIndex = 23
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label58.Location = New System.Drawing.Point(7, 154)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(82, 12)
        Me.Label58.TabIndex = 22
        Me.Label58.Text = "Costo Tienda"
        '
        'ckMAG
        '
        Me.ckMAG.AutoSize = True
        Me.ckMAG.Location = New System.Drawing.Point(196, 131)
        Me.ckMAG.Name = "ckMAG"
        Me.ckMAG.Size = New System.Drawing.Size(130, 17)
        Me.ckMAG.TabIndex = 21
        Me.ckMAG.Text = "Registrado en el MAG"
        Me.ckMAG.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label54.Location = New System.Drawing.Point(10, 32)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(66, 16)
        Me.Label54.TabIndex = 20
        Me.Label54.Text = "Impuesto"
        '
        'cboTipoImpuesto
        '
        Me.cboTipoImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoImpuesto.FormattingEnabled = True
        Me.cboTipoImpuesto.Location = New System.Drawing.Point(136, 29)
        Me.cboTipoImpuesto.Name = "cboTipoImpuesto"
        Me.cboTipoImpuesto.Size = New System.Drawing.Size(145, 21)
        Me.cboTipoImpuesto.TabIndex = 19
        Me.cboTipoImpuesto.TabStop = False
        '
        'txtcosto_real
        '
        Me.txtcosto_real.EditValue = "0.00"
        Me.txtcosto_real.Location = New System.Drawing.Point(100, 130)
        Me.txtcosto_real.Name = "txtcosto_real"
        '
        '
        '
        Me.txtcosto_real.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtcosto_real.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtcosto_real.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtcosto_real.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtcosto_real.Properties.Enabled = False
        Me.txtcosto_real.Properties.ReadOnly = True
        Me.txtcosto_real.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtcosto_real.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcosto_real.Size = New System.Drawing.Size(80, 19)
        Me.txtcosto_real.TabIndex = 18
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label49.Location = New System.Drawing.Point(8, 132)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(72, 12)
        Me.Label49.TabIndex = 17
        Me.Label49.Text = "Costo real"
        '
        'TxtCostoEquivalente
        '
        Me.TxtCostoEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCostoEquivalente.Enabled = False
        Me.TxtCostoEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtCostoEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtCostoEquivalente.Location = New System.Drawing.Point(196, 116)
        Me.TxtCostoEquivalente.Name = "TxtCostoEquivalente"
        Me.TxtCostoEquivalente.ReadOnly = True
        Me.TxtCostoEquivalente.Size = New System.Drawing.Size(84, 13)
        Me.TxtCostoEquivalente.TabIndex = 0
        Me.TxtCostoEquivalente.Text = "0.00"
        Me.TxtCostoEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOtrosCargosEquivalente
        '
        Me.TxtOtrosCargosEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOtrosCargosEquivalente.Enabled = False
        Me.TxtOtrosCargosEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtOtrosCargosEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtOtrosCargosEquivalente.Location = New System.Drawing.Point(196, 95)
        Me.TxtOtrosCargosEquivalente.Name = "TxtOtrosCargosEquivalente"
        Me.TxtOtrosCargosEquivalente.ReadOnly = True
        Me.TxtOtrosCargosEquivalente.Size = New System.Drawing.Size(84, 13)
        Me.TxtOtrosCargosEquivalente.TabIndex = 14
        Me.TxtOtrosCargosEquivalente.Text = "0.00"
        Me.TxtOtrosCargosEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFleteEquivalente
        '
        Me.TxtFleteEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFleteEquivalente.Enabled = False
        Me.TxtFleteEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtFleteEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtFleteEquivalente.Location = New System.Drawing.Point(196, 76)
        Me.TxtFleteEquivalente.Name = "TxtFleteEquivalente"
        Me.TxtFleteEquivalente.ReadOnly = True
        Me.TxtFleteEquivalente.Size = New System.Drawing.Size(84, 13)
        Me.TxtFleteEquivalente.TabIndex = 11
        Me.TxtFleteEquivalente.Text = "0.00"
        Me.TxtFleteEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxValorMonedaEnCosto
        '
        Me.TextBoxValorMonedaEnCosto.AcceptsTab = True
        Me.TextBoxValorMonedaEnCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorMonedaEnCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Moneda.ValorCompra", True))
        Me.TextBoxValorMonedaEnCosto.Enabled = False
        Me.TextBoxValorMonedaEnCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxValorMonedaEnCosto.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxValorMonedaEnCosto.Location = New System.Drawing.Point(199, 11)
        Me.TextBoxValorMonedaEnCosto.Name = "TextBoxValorMonedaEnCosto"
        Me.TextBoxValorMonedaEnCosto.ReadOnly = True
        Me.TextBoxValorMonedaEnCosto.Size = New System.Drawing.Size(80, 13)
        Me.TextBoxValorMonedaEnCosto.TabIndex = 3
        Me.TextBoxValorMonedaEnCosto.Text = "0.00"
        Me.TextBoxValorMonedaEnCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBaseEquivalente
        '
        Me.TxtBaseEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBaseEquivalente.Enabled = False
        Me.TxtBaseEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBaseEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtBaseEquivalente.Location = New System.Drawing.Point(196, 55)
        Me.TxtBaseEquivalente.Name = "TxtBaseEquivalente"
        Me.TxtBaseEquivalente.ReadOnly = True
        Me.TxtBaseEquivalente.Size = New System.Drawing.Size(84, 13)
        Me.TxtBaseEquivalente.TabIndex = 8
        Me.TxtBaseEquivalente.Text = "0.00"
        Me.TxtBaseEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.IVenta", True))
        Me.TxtImpuesto.EditValue = "0.00"
        Me.TxtImpuesto.Location = New System.Drawing.Point(100, 30)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        '
        '
        '
        Me.TxtImpuesto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtImpuesto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtImpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtImpuesto.Properties.ReadOnly = True
        Me.TxtImpuesto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtImpuesto.Size = New System.Drawing.Size(35, 19)
        Me.TxtImpuesto.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(10, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Moneda"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(8, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 12)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Costo"
        '
        'TxtFlete
        '
        Me.TxtFlete.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Fletes", True))
        Me.TxtFlete.EditValue = "0.00"
        Me.TxtFlete.Location = New System.Drawing.Point(100, 71)
        Me.TxtFlete.Name = "TxtFlete"
        '
        '
        '
        Me.TxtFlete.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtFlete.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFlete.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtFlete.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFlete.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtFlete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtFlete.Size = New System.Drawing.Size(80, 19)
        Me.TxtFlete.TabIndex = 10
        '
        'TxtOtros
        '
        Me.TxtOtros.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.OtrosCargos", True))
        Me.TxtOtros.EditValue = "0.00"
        Me.TxtOtros.Location = New System.Drawing.Point(100, 90)
        Me.TxtOtros.Name = "TxtOtros"
        '
        '
        '
        Me.TxtOtros.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtOtros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtOtros.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtOtros.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtOtros.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtOtros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtOtros.Size = New System.Drawing.Size(80, 19)
        Me.TxtOtros.TabIndex = 13
        '
        'TxtCosto
        '
        Me.TxtCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.Costo", True))
        Me.TxtCosto.EditValue = "0.00"
        Me.TxtCosto.Location = New System.Drawing.Point(100, 110)
        Me.TxtCosto.Name = "TxtCosto"
        '
        '
        '
        Me.TxtCosto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCosto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCosto.Properties.Enabled = False
        Me.TxtCosto.Properties.ReadOnly = True
        Me.TxtCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCosto.Size = New System.Drawing.Size(80, 19)
        Me.TxtCosto.TabIndex = 16
        '
        'ComboBoxMoneda
        '
        Me.ComboBoxMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.MonedaCosto", True))
        Me.ComboBoxMoneda.DataSource = Me.DataSetInventario
        Me.ComboBoxMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxMoneda.ItemHeight = 13
        Me.ComboBoxMoneda.Location = New System.Drawing.Point(100, 7)
        Me.ComboBoxMoneda.Name = "ComboBoxMoneda"
        Me.ComboBoxMoneda.Size = New System.Drawing.Size(84, 21)
        Me.ComboBoxMoneda.TabIndex = 1
        Me.ComboBoxMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox1.Location = New System.Drawing.Point(-79, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Exento"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(8, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 12)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Base"
        '
        'TxtBase
        '
        Me.TxtBase.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetInventario, "Inventario.PrecioBase", True))
        Me.TxtBase.EditValue = "0.00"
        Me.TxtBase.Location = New System.Drawing.Point(100, 51)
        Me.TxtBase.Name = "TxtBase"
        '
        '
        '
        Me.TxtBase.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtBase.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtBase.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtBase.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtBase.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtBase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBase.Size = New System.Drawing.Size(80, 19)
        Me.TxtBase.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(8, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 12)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Fletes"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(8, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 12)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Otro Cargo"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage4.Controls.Add(Me.ckCredito)
        Me.TabPage4.Controls.Add(Me.ckContado)
        Me.TabPage4.Controls.Add(Me.Label50)
        Me.TabPage4.Controls.Add(Me.cbo_rifa)
        Me.TabPage4.Controls.Add(Me.ck_bonificado)
        Me.TabPage4.Controls.Add(Me.ck_orden)
        Me.TabPage4.Controls.Add(Me.ck_promo3x1)
        Me.TabPage4.Controls.Add(Me.ck_receta)
        Me.TabPage4.Controls.Add(Me.Ck_Lote)
        Me.TabPage4.Controls.Add(Me.Ck_PreguntaPrecio)
        Me.TabPage4.Controls.Add(Me.Check_Inhabilitado)
        Me.TabPage4.Controls.Add(Me.Check_Servicio)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Hasta)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.Check_Promo)
        Me.TabPage4.Controls.Add(Me.Desde)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.TxtMaxDesc)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(331, 177)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Varios"
        '
        'ckCredito
        '
        Me.ckCredito.AutoSize = True
        Me.ckCredito.Location = New System.Drawing.Point(71, 24)
        Me.ckCredito.Name = "ckCredito"
        Me.ckCredito.Size = New System.Drawing.Size(48, 17)
        Me.ckCredito.TabIndex = 94
        Me.ckCredito.Text = "CRE"
        Me.ckCredito.UseVisualStyleBackColor = True
        '
        'ckContado
        '
        Me.ckContado.AutoSize = True
        Me.ckContado.Location = New System.Drawing.Point(16, 24)
        Me.ckContado.Name = "ckContado"
        Me.ckContado.Size = New System.Drawing.Size(49, 17)
        Me.ckContado.TabIndex = 93
        Me.ckContado.Text = "CON"
        Me.ckContado.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(13, 158)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(38, 18)
        Me.Label50.TabIndex = 92
        Me.Label50.Text = "Rifa"
        Me.Label50.Visible = False
        '
        'cbo_rifa
        '
        Me.cbo_rifa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.rifa", True))
        Me.cbo_rifa.FormattingEnabled = True
        Me.cbo_rifa.Location = New System.Drawing.Point(57, 158)
        Me.cbo_rifa.Name = "cbo_rifa"
        Me.cbo_rifa.Size = New System.Drawing.Size(263, 21)
        Me.cbo_rifa.TabIndex = 91
        Me.cbo_rifa.Visible = False
        '
        'ck_bonificado
        '
        Me.ck_bonificado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.bonificado", True))
        Me.ck_bonificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_bonificado.ForeColor = System.Drawing.Color.Red
        Me.ck_bonificado.Location = New System.Drawing.Point(16, 52)
        Me.ck_bonificado.Name = "ck_bonificado"
        Me.ck_bonificado.Size = New System.Drawing.Size(108, 24)
        Me.ck_bonificado.TabIndex = 90
        Me.ck_bonificado.Text = "Bonificado"
        '
        'ck_orden
        '
        Me.ck_orden.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.orden", True))
        Me.ck_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_orden.ForeColor = System.Drawing.Color.Red
        Me.ck_orden.Location = New System.Drawing.Point(16, 129)
        Me.ck_orden.Name = "ck_orden"
        Me.ck_orden.Size = New System.Drawing.Size(136, 24)
        Me.ck_orden.TabIndex = 89
        Me.ck_orden.Text = "Orden"
        '
        'ck_promo3x1
        '
        Me.ck_promo3x1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.promo3x1", True))
        Me.ck_promo3x1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ck_promo3x1.Location = New System.Drawing.Point(208, 73)
        Me.ck_promo3x1.Name = "ck_promo3x1"
        Me.ck_promo3x1.Size = New System.Drawing.Size(104, 24)
        Me.ck_promo3x1.TabIndex = 88
        Me.ck_promo3x1.Text = "Promo 3x1"
        Me.ck_promo3x1.Visible = False
        '
        'ck_receta
        '
        Me.ck_receta.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.receta", True))
        Me.ck_receta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_receta.ForeColor = System.Drawing.Color.Red
        Me.ck_receta.Location = New System.Drawing.Point(16, 108)
        Me.ck_receta.Name = "ck_receta"
        Me.ck_receta.Size = New System.Drawing.Size(136, 24)
        Me.ck_receta.TabIndex = 87
        Me.ck_receta.Text = "Solo con receta"
        '
        'Ck_Lote
        '
        Me.Ck_Lote.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.Lote", True))
        Me.Ck_Lote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_Lote.Location = New System.Drawing.Point(190, 97)
        Me.Ck_Lote.Name = "Ck_Lote"
        Me.Ck_Lote.Size = New System.Drawing.Size(62, 16)
        Me.Ck_Lote.TabIndex = 86
        Me.Ck_Lote.Text = "Lote"
        '
        'Ck_PreguntaPrecio
        '
        Me.Ck_PreguntaPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.PreguntaPrecio", True))
        Me.Ck_PreguntaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_PreguntaPrecio.Location = New System.Drawing.Point(252, 97)
        Me.Ck_PreguntaPrecio.Name = "Ck_PreguntaPrecio"
        Me.Ck_PreguntaPrecio.Size = New System.Drawing.Size(78, 16)
        Me.Ck_PreguntaPrecio.TabIndex = 85
        Me.Ck_PreguntaPrecio.Text = "Requiere Precio"
        '
        'Check_Inhabilitado
        '
        Me.Check_Inhabilitado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.Inhabilitado", True))
        Me.Check_Inhabilitado.Enabled = False
        Me.Check_Inhabilitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Inhabilitado.Location = New System.Drawing.Point(190, 134)
        Me.Check_Inhabilitado.Name = "Check_Inhabilitado"
        Me.Check_Inhabilitado.Size = New System.Drawing.Size(88, 16)
        Me.Check_Inhabilitado.TabIndex = 84
        Me.Check_Inhabilitado.Text = "Inhabilitado"
        '
        'Check_Servicio
        '
        Me.Check_Servicio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.Servicio", True))
        Me.Check_Servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Servicio.Location = New System.Drawing.Point(190, 115)
        Me.Check_Servicio.Name = "Check_Servicio"
        Me.Check_Servicio.Size = New System.Drawing.Size(88, 16)
        Me.Check_Servicio.TabIndex = 83
        Me.Check_Servicio.Text = "Servicio"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label34.Enabled = False
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(226, 3)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 12)
        Me.Label34.TabIndex = 76
        Me.Label34.Text = "Hasta"
        '
        'Hasta
        '
        Me.Hasta.CalendarForeColor = System.Drawing.Color.RoyalBlue
        Me.Hasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Promo_Finaliza", True))
        Me.Hasta.Enabled = False
        Me.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Hasta.Location = New System.Drawing.Point(227, 19)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(88, 20)
        Me.Hasta.TabIndex = 75
        Me.Hasta.Value = New Date(2010, 1, 18, 11, 52, 19, 600)
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label33.Enabled = False
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(130, 6)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(41, 12)
        Me.Label33.TabIndex = 74
        Me.Label33.Text = "Desde"
        '
        'Check_Promo
        '
        Me.Check_Promo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.Promo_Activa", True))
        Me.Check_Promo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Promo.Location = New System.Drawing.Point(16, 3)
        Me.Check_Promo.Name = "Check_Promo"
        Me.Check_Promo.Size = New System.Drawing.Size(108, 20)
        Me.Check_Promo.TabIndex = 72
        Me.Check_Promo.Text = "Promo Activa"
        '
        'Desde
        '
        Me.Desde.CalendarForeColor = System.Drawing.Color.RoyalBlue
        Me.Desde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Promo_Inicio", True))
        Me.Desde.Enabled = False
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Desde.Location = New System.Drawing.Point(133, 19)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(88, 20)
        Me.Desde.TabIndex = 73
        Me.Desde.Value = New Date(2010, 1, 18, 11, 52, 19, 640)
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(16, 73)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(104, 12)
        Me.Label37.TabIndex = 77
        Me.Label37.Text = "Máximo Descuento"
        '
        'TxtMaxDesc
        '
        Me.TxtMaxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMaxDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Max_Descuento", True))
        Me.TxtMaxDesc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtMaxDesc.Location = New System.Drawing.Point(136, 72)
        Me.TxtMaxDesc.Name = "TxtMaxDesc"
        Me.TxtMaxDesc.Size = New System.Drawing.Size(28, 13)
        Me.TxtMaxDesc.TabIndex = 78
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(168, 73)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(16, 12)
        Me.Label38.TabIndex = 79
        Me.Label38.Text = "%"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label39.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label39.Location = New System.Drawing.Point(168, 89)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(16, 12)
        Me.Label39.TabIndex = 82
        Me.Label39.Text = "%"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Max_Comision", True))
        Me.TextBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox4.Location = New System.Drawing.Point(136, 89)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(28, 13)
        Me.TextBox4.TabIndex = 81
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label40.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(16, 89)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(104, 12)
        Me.Label40.TabIndex = 80
        Me.Label40.Text = "Máximo Comisión"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridControl1)
        Me.TabPage2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(331, 177)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle Artículos por Proveedor"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Inventario.InventarioArticulos_x0020_x_x0020_Proveedor"
        Me.GridControl1.DataSource = Me.DataSetInventario
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(328, 144)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView1.GroupPanelText = ""
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha"
        Me.GridColumn6.DisplayFormat.FormatString = "d"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "FechaUltimaCompra"
        Me.GridColumn6.FilterInfo = ColumnFilterInfo2
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn6.Width = 62
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Id P."
        Me.GridColumn7.FieldName = "CodigoProveedor"
        Me.GridColumn7.FilterInfo = ColumnFilterInfo3
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn7.Width = 34
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Proveedor"
        Me.GridColumn8.FieldName = "Nombre"
        Me.GridColumn8.FilterInfo = ColumnFilterInfo4
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 111
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "M"
        Me.GridColumn9.FieldName = "Simbolo"
        Me.GridColumn9.FilterInfo = ColumnFilterInfo5
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 20
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Costo"
        Me.GridColumn10.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "UltimoCosto"
        Me.GridColumn10.FilterInfo = ColumnFilterInfo6
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn10.VisibleIndex = 0
        Me.GridColumn10.Width = 87
        '
        'TabLotes
        '
        Me.TabLotes.Controls.Add(Me.GridControl3)
        Me.TabLotes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabLotes.Location = New System.Drawing.Point(4, 22)
        Me.TabLotes.Name = "TabLotes"
        Me.TabLotes.Size = New System.Drawing.Size(331, 177)
        Me.TabLotes.TabIndex = 5
        Me.TabLotes.Text = "Lotes"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "Inventario.InventarioLotes"
        Me.GridControl3.DataSource = Me.DataSetInventario
        '
        '
        '
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(8, 8)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(320, 136)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.Text = "GridControl3"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Lote"
        Me.GridColumn1.FieldName = "Numero"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo7
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Vencimiento"
        Me.GridColumn2.DisplayFormat.FormatString = "d"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Vencimiento"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo8
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Existencia"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Cant_Actual"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo9
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureEdit1)
        Me.TabPage3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(331, 177)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Imagen"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(56, 8)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(216, 128)
        Me.PictureEdit1.TabIndex = 72
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabLotes)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabControl1.ItemSize = New System.Drawing.Size(71, 18)
        Me.TabControl1.Location = New System.Drawing.Point(8, 200)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(339, 203)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage8.Controls.Add(Me.Label56)
        Me.TabPage8.Controls.Add(Me.txtExistenciaBodega2)
        Me.TabPage8.Controls.Add(Me.ckActivarBodega)
        Me.TabPage8.Controls.Add(Me.Label55)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(331, 177)
        Me.TabPage8.TabIndex = 9
        Me.TabPage8.Text = "Bodega 2"
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label56.Location = New System.Drawing.Point(20, 49)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(113, 12)
        Me.Label56.TabIndex = 73
        Me.Label56.Text = "Existencia Actual"
        '
        'txtExistenciaBodega2
        '
        Me.txtExistenciaBodega2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExistenciaBodega2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetInventario, "Inventario.Existencia", True))
        Me.txtExistenciaBodega2.Enabled = False
        Me.txtExistenciaBodega2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistenciaBodega2.ForeColor = System.Drawing.Color.Red
        Me.txtExistenciaBodega2.Location = New System.Drawing.Point(20, 65)
        Me.txtExistenciaBodega2.Name = "txtExistenciaBodega2"
        Me.txtExistenciaBodega2.ReadOnly = True
        Me.txtExistenciaBodega2.Size = New System.Drawing.Size(113, 19)
        Me.txtExistenciaBodega2.TabIndex = 74
        Me.txtExistenciaBodega2.Text = "0.00"
        Me.txtExistenciaBodega2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ckActivarBodega
        '
        Me.ckActivarBodega.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckActivarBodega.Location = New System.Drawing.Point(140, 22)
        Me.ckActivarBodega.Name = "ckActivarBodega"
        Me.ckActivarBodega.Size = New System.Drawing.Size(16, 16)
        Me.ckActivarBodega.TabIndex = 72
        Me.ckActivarBodega.UseVisualStyleBackColor = False
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label55.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label55.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label55.Location = New System.Drawing.Point(17, 22)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(130, 16)
        Me.Label55.TabIndex = 71
        Me.Label55.Text = "Activar Bodega 2 :"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ckProductosOrganicos)
        Me.TabPage5.Controls.Add(Me.ckMaquinaria)
        Me.TabPage5.Controls.Add(Me.Label47)
        Me.TabPage5.Controls.Add(Me.cboencargado)
        Me.TabPage5.Controls.Add(Me.PictureBox1)
        Me.TabPage5.Controls.Add(Me.ck_taller)
        Me.TabPage5.Controls.Add(Me.ck_peces)
        Me.TabPage5.Controls.Add(Me.ckmascotas)
        Me.TabPage5.Controls.Add(Me.ckclinica)
        Me.TabPage5.Controls.Add(Me.ckarmamento)
        Me.TabPage5.Controls.Add(Me.ck_tienda)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(331, 177)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Categoría "
        '
        'ckProductosOrganicos
        '
        Me.ckProductosOrganicos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckProductosOrganicos.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.productos_organicos", True))
        Me.ckProductosOrganicos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckProductosOrganicos.ForeColor = System.Drawing.Color.Crimson
        Me.ckProductosOrganicos.Location = New System.Drawing.Point(205, 40)
        Me.ckProductosOrganicos.Name = "ckProductosOrganicos"
        Me.ckProductosOrganicos.Size = New System.Drawing.Size(115, 44)
        Me.ckProductosOrganicos.TabIndex = 95
        Me.ckProductosOrganicos.Text = "Productos organicos"
        '
        'ckMaquinaria
        '
        Me.ckMaquinaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckMaquinaria.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.maquinaria", True))
        Me.ckMaquinaria.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMaquinaria.ForeColor = System.Drawing.Color.Crimson
        Me.ckMaquinaria.Location = New System.Drawing.Point(206, 17)
        Me.ckMaquinaria.Name = "ckMaquinaria"
        Me.ckMaquinaria.Size = New System.Drawing.Size(115, 24)
        Me.ckMaquinaria.TabIndex = 94
        Me.ckMaquinaria.Text = "Maquinaria"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(72, 104)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(72, 23)
        Me.Label47.TabIndex = 93
        Me.Label47.Text = "Encargado"
        '
        'cboencargado
        '
        Me.cboencargado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetInventario, "Inventario.encargado", True))
        Me.cboencargado.DataSource = Me.DataSetInventario.Usuarios
        Me.cboencargado.DisplayMember = "Nombre"
        Me.cboencargado.Location = New System.Drawing.Point(144, 104)
        Me.cboencargado.Name = "cboencargado"
        Me.cboencargado.Size = New System.Drawing.Size(176, 21)
        Me.cboencargado.TabIndex = 92
        Me.cboencargado.ValueMember = "Cedula"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'ck_taller
        '
        Me.ck_taller.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.taller", True))
        Me.ck_taller.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_taller.ForeColor = System.Drawing.Color.Crimson
        Me.ck_taller.Location = New System.Drawing.Point(117, 40)
        Me.ck_taller.Name = "ck_taller"
        Me.ck_taller.Size = New System.Drawing.Size(136, 24)
        Me.ck_taller.TabIndex = 90
        Me.ck_taller.Text = "Taller"
        '
        'ck_peces
        '
        Me.ck_peces.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.peces", True))
        Me.ck_peces.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_peces.ForeColor = System.Drawing.Color.Crimson
        Me.ck_peces.Location = New System.Drawing.Point(16, 40)
        Me.ck_peces.Name = "ck_peces"
        Me.ck_peces.Size = New System.Drawing.Size(136, 24)
        Me.ck_peces.TabIndex = 89
        Me.ck_peces.Text = "Peces"
        '
        'ckmascotas
        '
        Me.ckmascotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckmascotas.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.mascotas", True))
        Me.ckmascotas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckmascotas.ForeColor = System.Drawing.Color.Crimson
        Me.ckmascotas.Location = New System.Drawing.Point(16, 16)
        Me.ckmascotas.Name = "ckmascotas"
        Me.ckmascotas.Size = New System.Drawing.Size(89, 24)
        Me.ckmascotas.TabIndex = 71
        Me.ckmascotas.Text = "Maceteras"
        '
        'ckclinica
        '
        Me.ckclinica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckclinica.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.clinica", True))
        Me.ckclinica.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckclinica.ForeColor = System.Drawing.Color.Crimson
        Me.ckclinica.Location = New System.Drawing.Point(117, 16)
        Me.ckclinica.Name = "ckclinica"
        Me.ckclinica.Size = New System.Drawing.Size(136, 24)
        Me.ckclinica.TabIndex = 70
        Me.ckclinica.Text = "Clinica"
        '
        'ckarmamento
        '
        Me.ckarmamento.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.armamento", True))
        Me.ckarmamento.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckarmamento.ForeColor = System.Drawing.Color.Crimson
        Me.ckarmamento.Location = New System.Drawing.Point(16, 64)
        Me.ckarmamento.Name = "ckarmamento"
        Me.ckarmamento.Size = New System.Drawing.Size(100, 24)
        Me.ckarmamento.TabIndex = 90
        Me.ckarmamento.Text = "Armamento"
        '
        'ck_tienda
        '
        Me.ck_tienda.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.tienda", True))
        Me.ck_tienda.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_tienda.ForeColor = System.Drawing.Color.Crimson
        Me.ck_tienda.Location = New System.Drawing.Point(117, 64)
        Me.ck_tienda.Name = "ck_tienda"
        Me.ck_tienda.Size = New System.Drawing.Size(136, 24)
        Me.ck_tienda.TabIndex = 90
        Me.ck_tienda.Text = "Tienda"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.viewRelacionados)
        Me.TabPage7.Controls.Add(Me.Label53)
        Me.TabPage7.Controls.Add(Me.txtDescripcionRelacion)
        Me.TabPage7.Controls.Add(Me.btnAgregarRelacion)
        Me.TabPage7.Controls.Add(Me.Label52)
        Me.TabPage7.Controls.Add(Me.txtCodigoRelacion)
        Me.TabPage7.Controls.Add(Me.Label51)
        Me.TabPage7.Controls.Add(Me.txtCantidadRelacion)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(331, 177)
        Me.TabPage7.TabIndex = 8
        Me.TabPage7.Text = "Relacionados"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'viewRelacionados
        '
        Me.viewRelacionados.AllowUserToAddRows = False
        Me.viewRelacionados.AllowUserToResizeColumns = False
        Me.viewRelacionados.AllowUserToResizeRows = False
        Me.viewRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewRelacionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cCodArticulo, Me.cDescripcion, Me.cCantidad})
        Me.viewRelacionados.Location = New System.Drawing.Point(3, 50)
        Me.viewRelacionados.Name = "viewRelacionados"
        Me.viewRelacionados.ReadOnly = True
        Me.viewRelacionados.RowHeadersVisible = False
        Me.viewRelacionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewRelacionados.Size = New System.Drawing.Size(325, 101)
        Me.viewRelacionados.TabIndex = 8
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        '
        'cCodArticulo
        '
        Me.cCodArticulo.HeaderText = "CodArticulo"
        Me.cCodArticulo.Name = "cCodArticulo"
        Me.cCodArticulo.ReadOnly = True
        Me.cCodArticulo.Width = 80
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.ReadOnly = True
        Me.cDescripcion.Width = 155
        '
        'cCantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.cCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        Me.cCantidad.Width = 70
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(78, 6)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(63, 13)
        Me.Label53.TabIndex = 7
        Me.Label53.Text = "Descripcion"
        '
        'txtDescripcionRelacion
        '
        Me.txtDescripcionRelacion.Location = New System.Drawing.Point(80, 24)
        Me.txtDescripcionRelacion.Name = "txtDescripcionRelacion"
        Me.txtDescripcionRelacion.ReadOnly = True
        Me.txtDescripcionRelacion.Size = New System.Drawing.Size(136, 20)
        Me.txtDescripcionRelacion.TabIndex = 6
        '
        'btnAgregarRelacion
        '
        Me.btnAgregarRelacion.Location = New System.Drawing.Point(271, 21)
        Me.btnAgregarRelacion.Name = "btnAgregarRelacion"
        Me.btnAgregarRelacion.Size = New System.Drawing.Size(57, 23)
        Me.btnAgregarRelacion.TabIndex = 5
        Me.btnAgregarRelacion.Text = "Agregar"
        Me.btnAgregarRelacion.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(3, 6)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(40, 13)
        Me.Label52.TabIndex = 4
        Me.Label52.Text = "Codigo"
        '
        'txtCodigoRelacion
        '
        Me.txtCodigoRelacion.Location = New System.Drawing.Point(6, 24)
        Me.txtCodigoRelacion.Name = "txtCodigoRelacion"
        Me.txtCodigoRelacion.Size = New System.Drawing.Size(68, 20)
        Me.txtCodigoRelacion.TabIndex = 3
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(219, 7)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(49, 13)
        Me.Label51.TabIndex = 2
        Me.Label51.Text = "Cantidad"
        '
        'txtCantidadRelacion
        '
        Me.txtCantidadRelacion.Location = New System.Drawing.Point(222, 24)
        Me.txtCantidadRelacion.Name = "txtCantidadRelacion"
        Me.txtCantidadRelacion.Size = New System.Drawing.Size(46, 20)
        Me.txtCantidadRelacion.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GridControl2)
        Me.TabPage6.Controls.Add(Me.txtserie)
        Me.TabPage6.Controls.Add(Me.Button1)
        Me.TabPage6.Controls.Add(Me.CheckBox2)
        Me.TabPage6.Controls.Add(Me.Button2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(331, 177)
        Me.TabPage6.TabIndex = 7
        Me.TabPage6.Text = "Series"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu1
        Me.GridControl2.DataMember = "serie"
        Me.GridControl2.DataSource = Me.DataSetInventario
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 44)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(316, 96)
        Me.GridControl2.TabIndex = 9
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4})
        Me.GridView2.GroupPanelText = "Agrupe de acuerdo a la columna deseada"
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Serie"
        Me.GridColumn4.FieldName = "serie"
        Me.GridColumn4.FilterInfo = ColumnFilterInfo1
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 0
        '
        'txtserie
        '
        Me.txtserie.Enabled = False
        Me.txtserie.Location = New System.Drawing.Point(124, 12)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(108, 20)
        Me.txtserie.TabIndex = 3
        Me.txtserie.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(284, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetInventario, "Inventario.serie", True))
        Me.CheckBox2.Location = New System.Drawing.Point(8, 12)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 20)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "Tiene N° de serie"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(240, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'colCodigoProveedor1
        '
        Me.colCodigoProveedor1.Caption = "Id P."
        Me.colCodigoProveedor1.FieldName = "CodigoProveedor"
        Me.colCodigoProveedor1.FilterInfo = ColumnFilterInfo13
        Me.colCodigoProveedor1.Name = "colCodigoProveedor1"
        Me.colCodigoProveedor1.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigoProveedor1.VisibleIndex = 1
        Me.colCodigoProveedor1.Width = 34
        '
        'colLote
        '
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "Numero"
        Me.colLote.FilterInfo = ColumnFilterInfo14
        Me.colLote.Name = "colLote"
        Me.colLote.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colLote.VisibleIndex = 0
        '
        'colCant_Actual
        '
        Me.colCant_Actual.Caption = "Existencia"
        Me.colCant_Actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCant_Actual.FieldName = "Cant_Actual"
        Me.colCant_Actual.FilterInfo = ColumnFilterInfo15
        Me.colCant_Actual.Name = "colCant_Actual"
        Me.colCant_Actual.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCant_Actual.VisibleIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(420, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(55, 13)
        Me.txtUsuario.TabIndex = 217
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(476, 16)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(216, 13)
        Me.txtNombreUsuario.TabIndex = 218
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label48.BackColor = System.Drawing.Color.SlateGray
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(356, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 13)
        Me.Label48.TabIndex = 219
        Me.Label48.Text = "Usuario"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contenedor
        '
        Me.contenedor.BackColor = System.Drawing.Color.White
        Me.contenedor.Controls.Add(Me.GroupBox3)
        Me.contenedor.Controls.Add(Me.TabControl1)
        Me.contenedor.Controls.Add(Me.Panel2)
        Me.contenedor.Controls.Add(Me.GroupBox6)
        Me.contenedor.Controls.Add(Me.GroupBox2)
        Me.contenedor.Location = New System.Drawing.Point(4, 32)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(696, 471)
        Me.contenedor.TabIndex = 220
        '
        'adUsuario
        '
        Me.adUsuario.InsertCommand = Me.SqlInsertCommand2
        Me.adUsuario.SelectCommand = Me.SqlSelectCommand14
        Me.adUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 50, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"), New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"), New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"), New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"), New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio")})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_D" & _
    "esc, Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        '
        'adserie
        '
        Me.adserie.DeleteCommand = Me.SqlDeleteCommand2
        Me.adserie.InsertCommand = Me.SqlInsertCommand6
        Me.adserie.SelectCommand = Me.SqlSelectCommand15
        Me.adserie.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "serie", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo", "codigo"), New System.Data.Common.DataColumnMapping("serie", "serie"), New System.Data.Common.DataColumnMapping("vendido", "vendido"), New System.Data.Common.DataColumnMapping("factura", "factura")})})
        Me.adserie.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_factura", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_serie", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "serie", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_vendido", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendido", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO serie(codigo, serie, vendido, factura) VALUES (@codigo, @serie, @vend" & _
    "ido, @factura); SELECT id, codigo, serie, vendido, factura FROM serie WHERE (id " & _
    "= @@IDENTITY)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@codigo", System.Data.SqlDbType.BigInt, 8, "codigo"), New System.Data.SqlClient.SqlParameter("@serie", System.Data.SqlDbType.NVarChar, 50, "serie"), New System.Data.SqlClient.SqlParameter("@vendido", System.Data.SqlDbType.NVarChar, 50, "vendido"), New System.Data.SqlClient.SqlParameter("@factura", System.Data.SqlDbType.NVarChar, 50, "factura")})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT id, codigo, serie, vendido, factura FROM serie"
        Me.SqlSelectCommand15.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@codigo", System.Data.SqlDbType.BigInt, 8, "codigo"), New System.Data.SqlClient.SqlParameter("@serie", System.Data.SqlDbType.NVarChar, 50, "serie"), New System.Data.SqlClient.SqlParameter("@vendido", System.Data.SqlDbType.NVarChar, 50, "vendido"), New System.Data.SqlClient.SqlParameter("@factura", System.Data.SqlDbType.NVarChar, 50, "factura"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_factura", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_serie", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "serie", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_vendido", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendido", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'ckValidaExistencia
        '
        Me.ckValidaExistencia.AutoSize = True
        Me.ckValidaExistencia.BackColor = System.Drawing.Color.SlateGray
        Me.ckValidaExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckValidaExistencia.ForeColor = System.Drawing.Color.White
        Me.ckValidaExistencia.Location = New System.Drawing.Point(231, 11)
        Me.ckValidaExistencia.Name = "ckValidaExistencia"
        Me.ckValidaExistencia.Size = New System.Drawing.Size(134, 20)
        Me.ckValidaExistencia.TabIndex = 221
        Me.ckValidaExistencia.Text = "Validar Existencia"
        Me.ckValidaExistencia.UseVisualStyleBackColor = False
        '
        'btnDuplicar
        '
        Me.btnDuplicar.Location = New System.Drawing.Point(-17, 6)
        Me.btnDuplicar.Name = "btnDuplicar"
        Me.btnDuplicar.Size = New System.Drawing.Size(0, 23)
        Me.btnDuplicar.TabIndex = 222
        Me.btnDuplicar.Text = "Duplicar "
        Me.btnDuplicar.UseVisualStyleBackColor = True
        '
        'ckLaboratorio
        '
        Me.ckLaboratorio.AutoSize = True
        Me.ckLaboratorio.BackColor = System.Drawing.Color.SlateGray
        Me.ckLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckLaboratorio.ForeColor = System.Drawing.Color.White
        Me.ckLaboratorio.Location = New System.Drawing.Point(131, 10)
        Me.ckLaboratorio.Name = "ckLaboratorio"
        Me.ckLaboratorio.Size = New System.Drawing.Size(96, 20)
        Me.ckLaboratorio.TabIndex = 223
        Me.ckLaboratorio.Text = "Laboratorio"
        Me.ckLaboratorio.UseVisualStyleBackColor = False
        '
        'ckListaNegra
        '
        Me.ckListaNegra.AutoSize = True
        Me.ckListaNegra.Location = New System.Drawing.Point(437, 536)
        Me.ckListaNegra.Name = "ckListaNegra"
        Me.ckListaNegra.Size = New System.Drawing.Size(80, 17)
        Me.ckListaNegra.TabIndex = 224
        Me.ckListaNegra.Text = "Lista Negra"
        Me.ckListaNegra.UseVisualStyleBackColor = True
        '
        'FrmInventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(698, 561)
        Me.Controls.Add(Me.ckListaNegra)
        Me.Controls.Add(Me.ckLaboratorio)
        Me.Controls.Add(Me.btnDuplicar)
        Me.Controls.Add(Me.ckValidaExistencia)
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.ckVerCodBarraInv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Text_Cod_AUX)
        Me.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventarios"
        CType(Me.DataSetInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtUtilidadR_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidadR_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidadR_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidadR_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidadR_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.txtCostoTienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcosto_real.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFlete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOtros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLotes.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.viewRelacionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contenedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Function isBloqueado(ByVal _cod As String) As Boolean
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select bloqueado from inventario where Codigo = '" & _cod & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return False
        End If
    End Function
    'Public Sub Loggin_Usuario()
    '    Try

    '        If BindingContext(Me.DataSetInventario.Usuarios).Count > 0 Then
    '            Dim Usuario_autorizadores() As System.Data.DataRow
    '            Dim Usua As System.Data.DataRow

    '            Usuario_autorizadores = DataSetInventario.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
    '            If Usuario_autorizadores.Length <> 0 Then
    '                Usua = Usuario_autorizadores(0)
    '                PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
    '                If Not PMU.Execute Then
    '                    MsgBox("Usted no tiene permisos para realizar ventas..", MsgBoxStyle.Exclamation)
    '                    txtUsuario.Text = ""
    '                    txtUsuario.Focus()
    '                    Exit Sub
    '                End If

    '                logeado = True
    '                txtNombreUsuario.Text = Usua("Nombre")
    '                Cedula_usuario = Usua("Cedula")

    '                txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
    '                ToolBar1.Buttons(0).Text = "Cancelar"
    '                ToolBar1.Buttons(0).ImageIndex = 8
    '                ToolBar1.Buttons(3).Enabled = PMU.Delete
    '                ToolBar1.Buttons(0).Enabled = True
    '                ToolBar1.Buttons(1).Enabled = True
    '                ToolBar1.Buttons(5).Enabled = True
    '                ToolBar1.Buttons(6).Enabled = False
    '                ToolBar1.Buttons(2).Enabled = False

    '                NuevoRegistros()

    '                Me.TxtCodigo.Text = ""
    '                Me.txtNombre.Text = ""
    '            Else ' si no existe una contraseñla como esta
    '                MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
    '                logeado = False
    '                txtUsuario.Text = ""
    '            End If

    '        Else
    '            MsgBox("No Existen Usuarios, ingrese datos")
    '        End If

    '    Catch ex As SystemException
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
    '    End Try
    'End Sub
    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.Text_Cod_AUX.Text = "" Then Exit Sub
            cargando = True
            If Me.LlenarInventario(CDbl(Me.Text_Cod_AUX.Text)) Then
                cargando = False
                EjecutarCalculos()
            End If
            Application.DoEvents()
            Me.TxtBarras.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region " Variable "
    '  Dim Salto As Boolean
    Dim cargando As Boolean

#End Region

    Private Sub CargarAdaptadores()
        Try
            Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            Me.Adaptador_Inventraio_AUX.Fill(Me.DataSetInventario, "Inventario2")
            Me.AdapterMarcas.Fill(Me.DataSetInventario, "Marcas")
            Me.AdapterCasaConsignante.Fill(Me.DataSetInventario, "Bodegas")
            Me.AdapterAUbicacion.Fill(Me.DataSetInventario, "Sububicacion")
            Me.AdapterFamilia.Fill(Me.DataSetInventario, "SubFamilias")
            Me.AdapterPresentacion.Fill(Me.DataSetInventario, "Presentaciones")
            Me.daProveedores.Fill(Me.DataSetInventario, "Proveedores")

            Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad()
            Me.AdapterMoneda.Fill(Me.DataSetInventario, "Moneda")
            Me.adUsuario.Fill(Me.DataSetInventario, "Usuarios")
            Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub esKatty()

        Dim katty As String = ""
        katty = GetSetting("SeeSOFT", "SeePOS", "Katty")

        If katty = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "Katty", "0")
            katty = 0
        End If

        If katty = "1" Then 'si es katty
            'Cambia las descripciones
            Me.ckclinica.Text = "Peluqueria"
            Me.ckMaquinaria.Text = "Correas"
            Me.ck_taller.Text = "Shampoo"
            Me.ckProductosOrganicos.Text = "Accesorios"
            Me.ckarmamento.Text = "Alimentos"
            Me.ck_tienda.Text = "Aves"
        Else 'de lo contrario
            'todo queda normal
        End If
    End Sub

    Public cCodigoTienda As Integer = 0

    Private Sub FrmInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ckHabilitaFamilia.Checked = False
            Me.ComboBoxFamilia.Enabled = False
            Me.esKatty()
            PMU = VSM(usua.Cedula, Me.Name)
            VerificandoAcceso_a_Modulos("inventarios", "Inhabilitar", usua.Cedula, "Inventario")
            contenedor.Enabled = False
            Me.cargarImpuestos()

            Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            CargarAdaptadores()
            Me.DataSetInventario.Inventario.BarrasColumn.DefaultValue = ""
            Me.DataSetInventario.Inventario.SubFamiliaColumn.DefaultValue = DataSetInventario.SubFamilias.Rows(0).Item(0)
            Me.DataSetInventario.Inventario.SubUbicacionColumn.DefaultValue = Me.DataSetInventario.SubUbicacion.Rows(0).Item(0)
            Me.DataSetInventario.Inventario.CodMarcaColumn.DefaultValue = Me.DataSetInventario.Marcas.Rows(0).Item(0)
            Me.DataSetInventario.Inventario.MinimaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.MaximaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.PuntoMedioColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.PrecioBaseColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.OtrosCargosColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.FletesColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.CostoColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Precio_AColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Precio_BColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Precio_CColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Precio_DColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.IVentaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.ObservacionesColumn.DefaultValue = ""
            Me.DataSetInventario.Inventario.Promo_ActivaColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.Precio_PromoColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Promo_InicioColumn.DefaultValue = Now
            Me.DataSetInventario.Inventario.Promo_FinalizaColumn.DefaultValue = Now
            Me.DataSetInventario.Inventario.Max_DescuentoColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Max_ComisionColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.ServicioColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.InhabilitadoColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.ProveedorColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Precio_SugeridoColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.SugeridoIVColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.PreguntaPrecioColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.LoteColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.ConsignacionColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.Id_BodegaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.ExistenciaBodegaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.Cod_ArticuloColumn.DefaultValue = ""
            Me.DataSetInventario.Inventario.Cod_PresentOtroColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.CodigoDescargaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.DescargaOtroColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.CantidadPresentOtroColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.CantidadDescargaColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.pantallaColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.mascotasColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.clinicaColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.recetaColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.pecesColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.tallerColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.barras2Column.DefaultValue = ""
            Me.DataSetInventario.Inventario.barras3Column.DefaultValue = ""
            Me.DataSetInventario.Inventario.ApartadoColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.promo3x1Column.DefaultValue = False
            Me.DataSetInventario.Inventario.ordenColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.bonificadoColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.encargadoColumn.DefaultValue = 0
            Me.DataSetInventario.Inventario.armamentoColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.tiendaColumn.DefaultValue = False
            Me.DataSetInventario.Inventario.maquinariaColumn.DefaultValue = False

            Me.DataSetInventario.serie.idColumn.AutoIncrement = True
            Me.DataSetInventario.serie.idColumn.AutoIncrementStep = -1
            Me.DataSetInventario.serie.idColumn.AutoIncrementSeed = -1

            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from rifa where anulada = 0 and finalizada = 0", dts)
            cbo_rifa.DataSource = dts
            cbo_rifa.DisplayMember = "descripcion"
            cbo_rifa.ValueMember = "id"

            ComboBoxMonedaVenta.SelectedItem = 0
            'Me.CenterToScreen()

            Me.TxtImpuesto.Properties.ReadOnly = True

            If PMU.Others Then
                TxtUtilidad_A.Visible = True
                TxtUtilidad_B.Visible = True
                TxtUtilidad_C.Visible = True
                TxtUtilidad_D.Visible = True
                Label29.Visible = True
            Else
                TxtUtilidad_A.Visible = False
                TxtUtilidad_B.Visible = False
                TxtUtilidad_C.Visible = False
                TxtUtilidad_D.Visible = False
                Label29.Visible = False
            End If

            If Me.Text_Cod_AUX.Text = "" Then Exit Sub
            cargando = True
            If Me.LlenarInventario(CDbl(Me.Text_Cod_AUX.Text)) Then
                cargando = False
                EjecutarCalculos()
            End If

            'SAJ 041207 VERIFICA SI SE DEBE DE CHECHEAR EL CODIGO DE BARRAS 
            If GetSetting("SeeSOFT", "SeePOS", "VerCodBarraInv") = "" Then
                SaveSetting("SeeSOFT", "SeePOS", "VerCodBarraInv", "0")
            End If
            Me.ckVerCodBarraInv.Checked = GetSetting("SeeSOFT", "SeePOS", "VerCodBarraInv")

            ToolBar1.Buttons(0).Enabled = False
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(5).Enabled = False
            Me.txtUsuario.Focus()

            If Me.Obtener_BasedeDatos.ToLower = "mascotas".ToLower Then
                Me.ck_taller.Text = "Groomer"
            End If

            If Me.Obtener_BasedeDatos.ToLower = "seepos".ToLower Then
                Me.ck_peces.Text = "Poliducto"
            End If

            If Me.Obtener_BasedeDatos.ToLower = "clinica".ToLower Then
                'Opciones Libres
                Me.ckclinica.Text = "--"
                Me.ckarmamento.Text = "--"
                Me.ckProductosOrganicos.Text = "--"

                'Opciones Usadas
                Me.ck_taller.Text = "Grooming"
                Me.ckMaquinaria.Text = "Clinica"
                Me.ck_tienda.Text = "Tienda"
                Me.ckmascotas.Text = "Laboratori"
                Me.ck_peces.Text = "Imagenes" '"Ultrasonido" 'Imagenes
                Me.Label20.Text = "W"
                Me.Label20.BackColor = System.Drawing.Color.RoyalBlue
                Me.Label20.ForeColor = System.Drawing.Color.Yellow
                Me.Label20.Width = Me.Label20.Width + 4
                Me.Label20.Left = Me.Label20.Left - 1

            End If

            If Me.cCodigoTienda > 0 Then
                Me.LlenarInventario(Me.cCodigoTienda)
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress, TxtCanPresentacion.KeyPress, TxtMed.KeyPress, TxtMax.KeyPress, TxtPrecioVenta_A.KeyPress, TxtPrecioVenta_B.KeyPress, TxtPrecioVenta_C.KeyPress, TxtPrecioVenta_D.KeyPress, TxtUtilidad_D.KeyPress, TxtUtilidad_A.KeyPress, TxtUtilidad_C.KeyPress, TxtUtilidad_B.KeyPress, TxtPrecioVenta_IV_D.KeyPress, TxtPrecioVenta_IV_A.KeyPress, TxtPrecioVenta_IV_C.KeyPress, TxtPrecioVenta_IV_B.KeyPress, TxtExistencia.KeyPress, ComboBoxMonedaVenta.KeyPress, TxtUtilidad_P.KeyPress, TxtPrecioVenta_P.KeyPress, TxtPrecioVenta_IV_P.KeyPress, TxtMin.KeyPress, TxtImpuesto.KeyPress, TxtFlete.KeyPress, TxtOtros.KeyPress, TxtCosto.KeyPress, ComboBoxMoneda.KeyPress, CheckBox1.KeyPress, TxtBase.KeyPress, TxtUtilidadR_A.KeyPress, TxtUtilidadR_B.KeyPress, TxtUtilidadR_C.KeyPress, TxtUtilidadR_D.KeyPress, TxtUtilidadR_P.KeyPress
        'REALIZA LOS CALCULOS PARA LAS DIFERENTES CAJAS DE TEXTO DEPENDIENDO DEL OBJETO ENTRANTE. SAJ 
        Try
            ' If cargando = True Then Exit Sub

            If Keys.Enter = Asc(e.KeyChar) Then
                Select Case sender.Name
                    Case TxtBase.Name, TxtFlete.Name, TxtOtros.Name
                        If TxtBase.Text = "" Then TxtBase.Text = 0
                        If TxtFlete.Text = "" Then TxtFlete.Text = 0
                        If TxtOtros.Text = "" Then TxtOtros.Text = 0
                        TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        CalcularEquivalenciaMoneda()
                        'calculo de precios por la utilidad
                        '******************************************************************************************************************************************
                        'Utilidades Reales
                    Case TxtUtilidadR_A.Name
                        If TxtUtilidadR_A.Text = "" Then TxtUtilidadR_A.Text = 0
                        TxtPrecioVenta_A.Text = txtcosto_real.Text * (TxtUtilidadR_A.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + txtcosto_real.Text
                        TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_A.Text
                        TxtUtilidad_A.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidadR_B.Name
                        If TxtUtilidadR_B.Text = "" Then TxtUtilidad_B.Text = 0
                        TxtPrecioVenta_B.Text = txtcosto_real.Text * (TxtUtilidadR_B.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + txtcosto_real.Text
                        TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_B.Text
                        TxtUtilidad_B.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidadR_C.Name
                        If TxtUtilidadR_C.Text = "" Then TxtUtilidadR_C.Text = 0
                        TxtPrecioVenta_C.Text = txtcosto_real.Text * (TxtUtilidadR_C.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + txtcosto_real.Text
                        TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_C.Text
                        TxtUtilidad_C.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidadR_D.Name
                        If TxtUtilidadR_D.Text = "" Then TxtUtilidadR_D.Text = 0
                        TxtPrecioVenta_D.Text = txtcosto_real.Text * (TxtUtilidadR_D.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + txtcosto_real.Text
                        TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_D.Text
                        TxtUtilidad_D.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidadR_P.Name
                        If TxtUtilidadR_P.Text = "" Then TxtUtilidadR_P.Text = 0
                        TxtPrecioVenta_P.Text = txtcosto_real.Text * (TxtUtilidadR_P.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + txtcosto_real.Text
                        TxtPrecioVenta_IV_P.Text = TxtPrecioVenta_P.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_P.Text
                        TxtUtilidad_P.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        '******************************************************************************************************************************************
                    Case TxtUtilidad_A.Name
                        If TxtUtilidad_A.Text = "" Then TxtUtilidad_A.Text = 0
                        TxtPrecioVenta_A.Text = TxtBaseEquivalente.Text * (TxtUtilidad_A.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                        TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_A.Text
                        TxtUtilidadR_A.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidad_B.Name
                        If TxtUtilidad_B.Text = "" Then TxtUtilidad_B.Text = 0
                        TxtPrecioVenta_B.Text = TxtBaseEquivalente.Text * (TxtUtilidad_B.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                        TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_B.Text
                        TxtUtilidadR_B.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidad_C.Name
                        If TxtUtilidad_C.Text = "" Then TxtUtilidad_C.Text = 0
                        TxtPrecioVenta_C.Text = TxtBaseEquivalente.Text * (TxtUtilidad_C.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                        TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_C.Text
                        TxtUtilidadR_C.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidad_D.Name
                        If TxtUtilidad_D.Text = "" Then TxtUtilidad_D.Text = 0
                        TxtPrecioVenta_D.Text = TxtBaseEquivalente.Text * (TxtUtilidad_D.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                        TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_D.Text
                        TxtUtilidadR_D.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtUtilidad_P.Name
                        If TxtUtilidad_P.Text = "" Then TxtUtilidad_P.Text = 0
                        TxtPrecioVenta_P.Text = TxtBaseEquivalente.Text * (TxtUtilidad_P.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                        TxtPrecioVenta_IV_P.Text = TxtPrecioVenta_P.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_P.Text
                        TxtUtilidadR_P.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                        'calculo de de utilidad por el precio A y calculo del precio com I.V.
                    Case TxtPrecioVenta_A.Name
                        If TxtPrecioVenta_A.Text = "" Then TxtPrecioVenta_A.Text = 0
                        TxtUtilidad_A.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_A.Text
                        TxtUtilidadR_A.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_B.Name
                        If TxtPrecioVenta_B.Text = "" Then TxtPrecioVenta_B.Text = 0
                        TxtUtilidad_B.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_B.Text
                        TxtUtilidadR_B.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_C.Name
                        If TxtPrecioVenta_C.Text = "" Then TxtPrecioVenta_C.Text = 0
                        TxtUtilidad_C.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_C.Text
                        TxtUtilidadR_C.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_D.Name
                        If TxtPrecioVenta_D.Text = "" Then TxtPrecioVenta_D.Text = 0
                        TxtUtilidad_D.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_D.Text
                        TxtUtilidadR_D.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_P.Name
                        If TxtPrecioVenta_P.Text = "" Then TxtPrecioVenta_P.Text = 0
                        TxtUtilidad_P.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_P.Text = TxtPrecioVenta_P.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_P.Text
                        TxtUtilidadR_P.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                        'CALCULO DE PRECIO DE VENTA Y RECALCULAR LA  UTILIDAD CON BASE A LOS NUEVOS PRECIOS 
                    Case TxtPrecioVenta_IV_A.Name
                        If TxtPrecioVenta_IV_A.Text = "" Then TxtPrecioVenta_IV_A.Text = 0
                        TxtPrecioVenta_A.Text = TxtPrecioVenta_IV_A.Text / (1 + (TxtImpuesto.Text / 100))
                        TxtUtilidad_A.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidadR_A.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_IV_B.Name
                        If TxtPrecioVenta_IV_B.Text = "" Then TxtPrecioVenta_IV_B.Text = 0
                        TxtPrecioVenta_B.Text = TxtPrecioVenta_IV_B.Text / (1 + (TxtImpuesto.Text / 100))
                        TxtUtilidad_B.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidadR_B.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_IV_C.Name
                        If TxtPrecioVenta_IV_C.Text = "" Then TxtPrecioVenta_IV_C.Text = 0
                        TxtPrecioVenta_C.Text = TxtPrecioVenta_IV_C.Text / (1 + (TxtImpuesto.Text / 100))
                        TxtUtilidad_C.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidadR_C.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_IV_D.Name
                        If TxtPrecioVenta_IV_D.Text = "" Then TxtPrecioVenta_IV_D.Text = 0
                        TxtPrecioVenta_D.Text = TxtPrecioVenta_IV_D.Text / (1 + (TxtImpuesto.Text / 100))
                        TxtUtilidad_D.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidadR_D.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                    Case TxtPrecioVenta_IV_P.Name
                        If TxtPrecioVenta_IV_P.Text = "" Then TxtPrecioVenta_IV_P.Text = 0
                        TxtPrecioVenta_P.Text = TxtPrecioVenta_IV_P.Text / (1 + (TxtImpuesto.Text / 100))
                        TxtUtilidad_P.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidadR_P.Text = Utilidad(txtcosto_real.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                End Select

                Select Case sender.Name 'SAJ 04122006 Eventos enter para el avance de los campos despues de los calculos  
                    Case Me.TxtBase.Name, Me.TxtOtros.Name, Me.TxtPrecioVenta_A.Name, Me.TxtPrecioVenta_B.Name, Me.TxtPrecioVenta_C.Name, Me.TxtPrecioVenta_D.Name,
                    Me.TxtPrecioVenta_P.Name, Me.TxtPrecioVenta_IV_A.Name, Me.TxtPrecioVenta_IV_B.Name, Me.TxtPrecioVenta_IV_C.Name, Me.TxtPrecioVenta_IV_D.Name, Me.TxtPrecioVenta_IV_P.Name,
                    Me.TxtMin.Name, TxtMax.Name, TxtMed.Name, Me.TxtExistencia.Name, Me.TxtUtilidad_P.Name, txtVentaSugerido.Name
                        If Asc(e.KeyChar) = Keys.Enter Then SendKeys.Send("{TAB}")
                End Select
            End If
            ' esto invalida la tecla pulsada CUANDO NO ES NUMERICO SAJ:190906
            If Not IsNumeric(sender.text & e.KeyChar) Then If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then e.Handled = True

        Catch ex As SystemException
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Function Utilidad(ByVal Costo As Double, ByVal Precio As Double) As Double
        Utilidad = IIf(Costo = 0, 0, Math.Round(((Precio / Costo) - 1) * 100, 5))
        Return Utilidad
    End Function

    Private Sub BuscarRegistros()
        Try
            Me.ckHabilitaFamilia.Checked = False
            If Me.BindingContext(Me.DataSetInventario, "Inventario").Count > 0 Then
                Me.BindingContext(Me.DataSetInventario, "Inventario").CancelCurrentEdit()
                BindingContext(Me.DataSetInventario, "Inventario2").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                Me.DataNavigator1.Enabled = True
            End If

            Dim BuscarArt As New FrmBuscarArticulo2
            BuscarArt.StartPosition = FormStartPosition.CenterParent
            BuscarArt.CheckBoxInHabilitados.Enabled = True
            BuscarArt.TCodigo = FrmBuscarArticulo2.TipoCodigo.Codigo
            BuscarArt.Cod_Articulo = True
            BuscarArt.ShowDialog()

            cargando = True
            If BuscarArt.Cancelado Then
                cargando = False
                Exit Sub
            End If
            Me.existencia_enbodega(BuscarArt.Codigo) '// comprobamos la existencia actual en bodega

            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            Me.ToolBarRegistrar.Text = "Actualizar"
            vista = Me.DataSetInventario.Inventario2.DefaultView
            vista.Sort = "Codigo"
            pos = vista.Find(CDbl(BuscarArt.CodigoArticulo))
            Me.BindingContext(Me.DataSetInventario, "Inventario2").Position = pos

            If Me.DataSetInventario.Inventario.Rows(0).Item("Inhabilitado") = False Then
                Me.ToolBar1.Buttons(3).Text = "Inhabilitar"
            Else
                Me.ToolBar1.Buttons(3).Text = "Habilitar"
            End If
            Me.ToolBarEliminar.Enabled = True
            Me.ToolBarImprimir.Enabled = True
            cargando = False
            txtCod_Articulo.Focus()
            consultar_costo_real()
            CargarActualizado(TxtCodigo.Text)
            Me.EjecutarCalculos()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub existencia_enbodega(ByVal cod As String)
        Dim dts As New DataTable
        Dim codigo As String
        Dim bodega As String
        Dim existenciaBodega As Double
        Dim funciones As New Conexion
        Dim existenciab As Double
        Dim existencia As Double
        Dim i As Integer

        codigo = cod
        cFunciones.Llenar_Tabla_Generico("select codigo,id_bodega,ExistenciaBodega,Existencia,dbo.ReporteBodega_SaldoInicial(GETDATE(),codigo,Id_Bodega)as exisbod  from Inventario where Consignacion = 1 and cod_articulo = '" & codigo & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            codigo = dts.Rows(0).Item("codigo")
            existenciaBodega = dts.Rows(0).Item("exisbod")
            existencia = dts.Rows(0).Item("ExistenciaBodega")
            If existencia <> existenciaBodega Then
                funciones.UpdateRecords("inventario", "existenciaBodega = " & existenciaBodega, "codigo = " & codigo, "SeePos")
            End If
        End If

    End Sub

    Private Sub CargarValidaExistencia(_id As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Inventario where codigo =" & _id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.ckValidaExistencia.Checked = dt.Rows(0).Item("ValidaExistencia")
        End If

        'Me.DataSetInventario.serie.Rows.Clear()
        'If Me.CheckBox2.Checked = True Then
        cFunciones.Llenar_Tabla_Generico("Select * from Serie Where Vendido = 0 and Codigo = " & _id, Me.DataSetInventario.serie, CadenaConexionSeePOS)
        'End If

    End Sub

    Private DiasValidar As Integer = 20
    Private Sub RevisaUltimaCompra(_Codigo As String)
        Dim UltimaCompra As Integer = Me.DiasUltimaCompra(_Codigo)
        Me.lblUltimaCompra.Text = ""
        If UltimaCompra >= 0 Then
            If UltimaCompra > Me.DiasValidar Then
                Me.lblUltimaCompra.Text = "Ya pasaron mas de " & UltimaCompra - 1 & " dias de la ultima compra."
            End If
            If UltimaCompra <= Me.DiasValidar Then
                Me.lblUltimaCompra.Text = ""
            End If
        Else
            Me.lblUltimaCompra.Text = "No hay compras ingresadas."
        End If
    End Sub

    Private Function DiasUltimaCompra(_Codigo As String) As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select top 1 DATEDIFF(day,FechaUltimaCompra,getdate())  from [Articulos x Proveedor] where CodigoArticulo = " & _Codigo & " order by FechaUltimaCompra desc", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return -1
        End If
    End Function

    Function LlenarInventario(ByVal Id As Double) As Boolean

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        Try
            DataSetInventario.Lotes.Clear()
            DataSetInventario.Articulos_x_Proveedor.Clear()
            DataSetInventario.Inventario.Clear()
            cFunciones.Cargar_Tabla_Generico(AdapterInventario, "Select * from Inventario where codigo =" & Id)
            AdapterInventario.Fill(DataSetInventario.Inventario)

            Me.RevisaUltimaCompra(Id)
            '*************************************************************************************************************************
            Dim dtPromo As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Muestra, SinDecimal, SoloContado, MAG, PromoCON, PromoCRE, Id_Impuesto, ImprimeCopia, ListaNegra from Inventario where Codigo = " & Id, dtPromo, CadenaConexionSeePOS)
            If dtPromo.Rows.Count > 0 Then
                Me.ckLaboratorio.Checked = dtPromo.Rows(0).Item("ImprimeCopia")
                'Lista negra = son articulos que no hay que pedir mucho o no pedir
                Me.ckListaNegra.Checked = dtPromo.Rows(0).Item("ListaNegra")
                Me.ckSinDecimales.Checked = dtPromo.Rows(0).Item("SinDecimal")
                Me.ckSoloContado.Checked = dtPromo.Rows(0).Item("SoloContado")
                Me.ckMostrar.Checked = dtPromo.Rows(0).Item("Muestra")
                Me.ckMAG.Checked = dtPromo.Rows(0).Item("MAG")
                Me.ckContado.Checked = dtPromo.Rows(0).Item("PromoCON")
                Me.ckCredito.Checked = dtPromo.Rows(0).Item("PromoCRE")
                Me.cboTipoImpuesto.SelectedValue = dtPromo.Rows(0).Item("Id_Impuesto")
            End If

            consultar_costo_real()
            '*************************************************************************************************************************
16:
            If DataSetInventario.Inventario.Rows.Count() = 0 Then
                MsgBox("No existe un artículo con ese código en el inventario", MsgBoxStyle.Information)
                Return False
            End If
            '''''''''LLENAR ARTICULOS    PROVEEDOR'''''''''''''''''''''''''''''''''''''''
            cFunciones.Cargar_Tabla_Generico(AdapterArticulosXproveedor, "SELECT CodigoArticulo,CodigoProveedor,FechaUltimaCompra,UltimoCosto, Moneda.Simbolo,Proveedores.Nombre  FROM [Articulos x Proveedor] INNER JOIN Moneda ON  [Articulos x Proveedor].Moneda = Moneda.CodMoneda INNER JOIN Proveedores ON [Articulos x Proveedor].CodigoProveedor = Proveedores.CodigoProv and CodigoArticulo =" & Id)
            AdapterArticulosXproveedor.Fill(DataSetInventario.Articulos_x_Proveedor)

            '''''''''LLENAR ARTICULOS X LOTE'''''''''''''''''''''''''''''''''''''''
            cFunciones.Cargar_Tabla_Generico(AdapterLote, "SELECT Id, Numero, Vencimiento, Cant_Actual, Cod_Articulo FROM Lotes WHERE Cant_Actual <> 0 AND Vencimiento >= Getdate() AND Cod_Articulo =" & Id)
            AdapterLote.Fill(DataSetInventario.Lotes)
            '--------------------------------------------------------------------------

            If Me.Check_Inhabilitado.Checked = False Then
                Me.ToolBar1.Buttons(3).Text = "Inhabilitar"
            Else
                Me.ToolBar1.Buttons(3).Text = "Habilitar"
            End If
            If PMU.Others Then
                CheckBox1.Enabled = True
                'TxtImpuesto.Properties.ReadOnly = False
            Else
                CheckBox1.Enabled = False
                TxtImpuesto.Properties.ReadOnly = True
            End If
            Eliminar_Articulo_Validacion()

            If isBloqueado(Id) = True Then
                GroupBox6.Enabled = False
                GroupBox6.Text = "Datos de la Bodega (Articulo Bloqueado)"
            Else
                GroupBox6.Enabled = True
                GroupBox6.Text = "Datos de la Bodega"
            End If

            Me.CargarValidaExistencia(Id)
            Me.CargarProductosRelacionados(Id)
            Me.CargarActualizado(TxtCodigo.Text)

            Return True

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención...")
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        PMU = VSM(usua.Cedula, Me.Name)  'Carga los privilegios del usuario con el modulo  

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevosDatos()
            Case 2 : If PMU.Find Then Me.BuscarRegistros() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then RegistrarDatos() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Habilitar_Inhabilitar() Else MsgBox("No tiene permiso para desactivar items...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If PMU.Delete Then Eliminar_Articulo() Else MsgBox("No tiene permiso para desactivar items...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el modulo actual..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub

    Private Sub Eliminar_Articulo_Validacion()
        Dim Items(1) As Integer
        Dim Cx As New Conexion
        'Items(0) = Cx.SlqExecuteScalar(Cx.Conectar, "SELECT COUNT(Ventas_Detalle.Cantidad) FROM Ventas_Detalle INNER JOIN  Ventas ON Ventas_Detalle.Id_Factura = Ventas.Id WHERE (Ventas.Anulado = 0) and codigo = " & Text_Cod_AUX.Text & "GROUP BY Ventas_Detalle.Codigo")
        'Items(1) = Cx.SlqExecuteScalar(Cx.Conectar, "SELECT COUNT(Cantidad) FROM articulos_comprados GROUP BY Codigo HAVING Codigo = " & Text_Cod_AUX.Text)
        Items(0) = 0
        Items(1) = 0

        Me.ToolBarEliminador.Enabled = IIf((Items(0) + Items(1)) > 0, False, True)
        Cx.DesConectar(Cx.sQlconexion)
    End Sub
    Private Sub Eliminar_Articulo()
        Dim Items(1) As Integer
        Dim Cx As New Conexion
        Items(0) = Cx.SlqExecuteScalar(Cx.Conectar, "SELECT COUNT(Ventas_Detalle.Cantidad) FROM Ventas_Detalle INNER JOIN  Ventas ON Ventas_Detalle.Id_Factura = Ventas.Id WHERE (Ventas.Anulado = 0) and codigo = " & Me.TxtCodigo.Text & "GROUP BY Ventas_Detalle.Codigo")
        Items(1) = Cx.SlqExecuteScalar(Cx.Conectar, "SELECT COUNT(Cantidad) FROM articulos_comprados GROUP BY Codigo HAVING Codigo = " & Me.TxtCodigo.Text)

        If Items(0) = 0 And Items(1) = 0 Then
            If MsgBox("Esta seguro que desea proceder con la ELIMINACION del artículo seleccionado...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
                Me.BindingContext(Me.DataSetInventario, "Inventario").RemoveAt(Me.BindingContext(Me.DataSetInventario, "Inventario").Position)
                Me.BindingContext(Me.DataSetInventario, "Inventario").EndCurrentEdit()
                Me.AdapterInventario.Update(Me.DataSetInventario, "Inventario")

                Me.DataSetInventario.Inventario2.Clear()
                Me.Adaptador_Inventraio_AUX.Fill(Me.DataSetInventario, "Inventario2")

                MsgBox("Se ha eliminado el registro del inventario.", MsgBoxStyle.Information, "Atención...")
                Me.NuevoRegistros()
            End If
        Else
            MsgBox("Existen movimientos registrados para para el artículo " & Me.TxtDescripcion.Text & vbCrLf & "Cantidad de items Vendidos.. " & Items(0) & vbCrLf & "Cantidad de Items Comprados.. " & Items(1), MsgBoxStyle.Critical, "Atención...")
        End If
        Cx.DesConectar(Cx.sQlconexion)
    End Sub
    Function Imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Articulo_reporte As New Reporte_Ficha_Articulo
            Articulo_reporte.SetParameterValue(0, CDbl(Me.TxtCodigo.Text))
            CrystalReportsConexion.LoadShow(Articulo_reporte, MdiParent)
            'Dim Visor As New frmVisorReportes
            'CrystalReportsConexion.LoadReportViewer(Visor.rptViewer, Articulo_reporte, False, Me.SqlConnection1.ConnectionString)
            'Visor.rptViewer.ReportSource = Articulo_reporte
            'Visor.MdiParent = MdiParent
            'Visor.rptViewer.Visible = True
            'Visor.Show()


            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub NuevosDatos()

        If ToolBar1.Buttons(0).Text = "Nuevo" Then

            ToolBar1.Buttons(0).Text = "Cancelar"
            'SAJ 07122006 CAMBIO DE NOMBRE DE REGISTAR A ACTUALIZA SEGUN 
            Me.ToolBarRegistrar.Text = "Registrar"
            ToolBar1.Buttons(0).ImageIndex = 8
            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBarEliminar.Enabled = True
            strNuevo = "1"
            Try
                Me.DataSetInventario.Inventario.FechaIngresoColumn.DefaultValue = Now
                Me.BindingContext(DataSetInventario, "Inventario").CancelCurrentEdit()
                Me.BindingContext(DataSetInventario, "Inventario").EndCurrentEdit()
                Me.BindingContext(DataSetInventario, "Inventario").AddNew()
                NuevoRegistros()
                'LFCHG 07122006
                'CONTROLAR LA NAVEGACION ENTRE REGISTROS
                Me.DataNavigator1.Enabled = False
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
            'guanavet clinica
            'txtCod_Articulo.Enabled = False
        Else
            Me.BindingContext(Me.DataSetInventario, "Inventario").CancelCurrentEdit()
            'LFCHG 07122006
            'CONTROLAR LA NAVEGACION ENTRE REGISTROS
            Me.DataNavigator1.Enabled = False
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.DataNavigator1.Enabled = True
            Me.ToolBarRegistrar.Text = "Actualizar"
            Me.ToolBarRegistrar.Enabled = True
            Me.ToolBarImprimir.Enabled = True
            contenedor.Enabled = False
            Me.logeado = False
            Me.txtUsuario.Text = ""
            Me.txtNombreUsuario.Text = ""
            txtUsuario.Enabled = True
            txtUsuario.Focus()
            strNuevo = ""

            'guanavet clinica
            'txtCod_Articulo.Enabled = False
        End If
    End Sub

    'Private Sub ActualizarDatos()
    '    Try
    '        If Me.BindingContext(Me.DataSetInventario, "inventario").Count > 0 Then
    '            Me.BindingContext(Me.DataSetInventario, "inventario").EndCurrentEdit()
    '            MsgBox("Los datos se actualiazaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
    '            ToolBar1.Buttons(0).Text = "Nuevo"
    '            ToolBar1.Buttons(0).ImageIndex = 0
    '        Else
    '            MsgBox("No existen datos a ser actualizados...", MsgBoxStyle.Information, "Atención...")
    '        End If
    '    Catch ex As SystemException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Sub insertar_PermisoAjuste(ByVal ced As String, ByVal fecha As Date, ByVal descrip As String, ByVal id_Mov As Integer, ByVal _CedAdmin As String)
        Dim sentencia = "INSERT INTO registro_Permisohabilitar (cedula_usuario, fecha, descripcion,codigo,Administrador)VALUES('" & ced & "','" & fecha & "','" & descrip & "'," & id_Mov & ",'" & _CedAdmin & "')"
        Dim SQL As New GestioDatos
        SQL.Ejecuta(sentencia)
    End Sub

    Private Function PuedeInhabilitar(_Cod As String) As Boolean
        Dim dt As New System.Data.DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        dt = db.Ejecutar("select i.Codigo, i.Cod_Articulo, i.Descripcion from ArticulosRelacionados a inner join Inventario i on i.Codigo = a.CodigoPrincipal where a.Codigo = " & _Cod, CommandType.Text)

        If dt.Rows.Count > 0 Then

            MsgBox("El articulo esta relacionado a otros articulos o servicios", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")

            Dim frm As New frmDetalleArticulosRelacionados
            frm.Codigo = _Cod
            frm.txtDescripcion.Text = Me.TxtDescripcion.Text
            frm.ShowDialog()

            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Habilitar_Inhabilitar()
        Dim resp As Integer
        Dim funciones As New Conexion
        Dim mensaje As String
        Dim Descripcion_Accion As String
        Dim mensaje2 As String

        If Me.BindingContext(Me.DataSetInventario, "Inventario").Current("inhabilitado") = False Then
            If PuedeInhabilitar(Me.TxtCodigo.Text) = False Then
                Exit Sub
            End If
        End If

        If logeado = False Then
            MsgBox("Debe estar logeado para realizar cualquier operación en este modulo.", MsgBoxStyle.Information, "Login")
            Me.txtUsuario.Focus()
            Exit Sub
        End If

        If Me.BindingContext(Me.DataSetInventario, "Inventario").Current("inhabilitado") = True Then
            Dim fr As New frmpermiso
            fr.ShowDialog()
            If fr.resultado = False Then
                Exit Sub
            Else
            End If
        End If

        If Me.Check_Inhabilitado.Checked = False Then
            mensaje = "Desea Inhabilitar este artículo en el inventario"
            mensaje2 = "INHABILITADO"
            Descripcion_Accion = "ARTICULO INHABILITADO"
            Ck_Consignacion.Checked = False
        Else
            mensaje = "Desea Habilitar este artículo en el inventario"
            mensaje2 = "HABILITADO"
            Descripcion_Accion = "ARTICULO HABILITADO"
        End If

        If MsgBox(mensaje, MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
            Try 'se intenta hacer
                If Me.BindingContext(Me.DataSetInventario, "Inventario").Count > 0 Then

                    Dim datos As String
                    Dim Nombre_Tabla As String


                    Nombre_Tabla = "INVENTARIO"
                    'datos = "" & Nombre_Tabla & "','" & Me.TxtCodigo.Text & "','" & Me.TxtDescripcion.Text & "', 'ARTICULO  " & mensaje2 & "','" & usua.Nombre & "'," & CDbl(Me.TxtCosto.Text) & "," & CDbl(Me.TxtPrecioVenta_A.Text) & "," & CDbl(Me.TxtPrecioVenta_B.Text) & "," & CDbl(Me.TxtPrecioVenta_C.Text) & "," & CDbl(Me.TxtPrecioVenta_D.Text)
                    'datos = "" & Nombre_Tabla & "','" & Me.TxtCodigo.Text & "','" & Me.TxtDescripcion.Text & "','" & Descripcion_Accion & "','" & Date.Now & "','" & usua.Nombre & "','" & CDbl(Me.TxtCosto.Text) & "','" & CDbl(Me.TxtPrecioVenta_A.Text) & "','" & CDbl(Me.TxtPrecioVenta_B.Text) & "','" & CDbl(Me.TxtPrecioVenta_C.Text) & "','" & CDbl(Me.TxtPrecioVenta_D.Text)
                    'If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Fecha,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
                    '    MsgBox("Problemas al Inhabilitar el artículo", MsgBoxStyle.Critical)
                    '    'MsgBox(s)
                    '    Exit Sub
                    'End If

                    '+++++++++++++++++++++++++++++++++++++++++Esto es una prueba++++++++++++++++++++++++++++++++++++++++++'

                    Me.BindingContext(Me.DataSetInventario, "Bitacora").AddNew()
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Tabla") = "INVENTARIO"
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Campo_Clave") = Me.TxtCodigo.Text
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("DescripcionCampo") = Me.TxtDescripcion.Text
                    'Se especifica que tipo de accion es si es un nuevo articulo o una actualizacion'
                    'If Me.ToolBarNuevo.Text = "Cancelar" Then
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = Descripcion_Accion
                    'Else
                    '   Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO ACTUALIZADO"
                    '               End If
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Usuario") = Me.txtNombreUsuario.Text
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Fecha") = Now
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Costo") = CDbl(Me.TxtCosto.Text)
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaA") = CDbl(Me.TxtPrecioVenta_A.Text)
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaB") = CDbl(Me.TxtPrecioVenta_B.Text)
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaC") = CDbl(Me.TxtPrecioVenta_C.Text)
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaD") = CDbl(Me.TxtPrecioVenta_D.Text)
                    Me.BindingContext(Me.DataSetInventario, "Bitacora").EndCurrentEdit()
                    '+++++++++++++++++++++++++++++++++++++++++Esto es una prueba++++++++++++++++++++++++++++++++++++++++++'

                    If Me.Check_Inhabilitado.Checked = True Then
                        Me.Check_Inhabilitado.Checked = False
                        Me.ToolBar1.Buttons(3).Text = "Inhabilitar"
                        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Inhabilitado") = False
                    Else
                        Me.Check_Inhabilitado.Checked = True
                        Me.ToolBar1.Buttons(3).Text = "Habilitar"
                        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Inhabilitado") = True
                    End If

                    'Me.BindingContext(Me.DataSetInventario, "Inventario").RemoveAt(Me.BindingContext(Me.DataSetInventario, "Inventario").Position)
                    Me.BindingContext(Me.DataSetInventario, "Inventario").EndCurrentEdit()
                    'Me.AdapterInventario.Update(Me.DataSetInventario, "Inventario")
                    Dim estado As String
                    If Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Inhabilitado") = True Then
                        estado = 1
                    Else
                        estado = 0
                    End If
                    funciones.UpdateRecords("INVENTARIO", "Inhabilitado = " & estado, "codigo = " & Me.TxtCodigo.Text)

                    MsgBox("El artículo fue " & mensaje2 & " satisfactoriamente", MsgBoxStyle.Information)

                Else
                    MsgBox("No existen datos a ser Habilitados/Habilitados", MsgBoxStyle.Information)
                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Function buscarCodigoBarra2() As String  'JCGA 12042007

        Try

            Dim strCodigoBarras As String = TxtBarras.Text
            Dim strCodigoArticulo As String = TxtCodigo.Text
            Dim strQuery As String = "SELECT Descripcion FROM inventario WHERE barras = '" & strCodigoBarras & "' and Codigo= '" & strCodigoArticulo & "'"
            Dim strArticulo As String = ""
            Dim strMensaje As String = ""

            'Evaluo si el ariculo conserva el mismo codigo de barras 
            strArticulo = cFunciones.BuscaString(strQuery, Me.SqlConnection1.ConnectionString)

            'Si articulo no trae informacion indica que el articulo cambio el codigo de barras
            If strArticulo = "" Then

                'Evaluo si algun articulo tiene asignado el codigo de barras que se le acaba de asignar al articulo
                strQuery = "SELECT Descripcion FROM inventario WHERE barras = '" & strCodigoBarras & "'"

                strArticulo = cFunciones.BuscaString(strQuery, Me.SqlConnection1.ConnectionString)
                'Si no trae nada indica que no hay ariculo con el codigo de barras
                If strArticulo = "" Then
                    Return strMensaje
                Else
                    'Si se encontro algun articulo con ese codigo de barras se enviara el la decripcion de este
                    strMensaje = strArticulo
                    Return strMensaje
                End If

            Else
                'Si el articulo conserva el mismo codigo de barra se envia el mensaje de igual
                strMensaje = "Igual"
                Return strMensaje

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Private Function buscarCodigoBarra() As String  'JCGA 12042007

        Try
            Dim strCodigoBarras As String = TxtBarras.Text
            Dim strQuery As String = "SELECT Descripcion FROM inventario WHERE barras = '" & strCodigoBarras & "'"
            Dim strArticulo As String = ""
            Dim strMensaje As String = ""
            strArticulo = cFunciones.BuscaString(strQuery, Me.SqlConnection1.ConnectionString)
            If strArticulo = "" Then
                Return strMensaje
            Else
                strMensaje = strArticulo
                Return strMensaje
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function buscarCodigoArticulo(Optional ByVal Actualiza As Boolean = False) As String  'ORA 02/02/10

        Try
            Dim strCodigo As String = txtCod_Articulo.Text
            Dim strQuery As String = "SELECT Descripcion FROM inventario WHERE Codigo <> " & TxtCodigo.Text & " AND Cod_Articulo = '" & strCodigo & "'"
            Dim strArticulo As String = ""
            Dim strMensaje As String = ""
            strArticulo = cFunciones.BuscaString(strQuery, Me.SqlConnection1.ConnectionString)
            If strArticulo = "" Then
                Return strMensaje
            Else
                strMensaje = strArticulo
                Return strMensaje
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub GuardarValidaExistencia(_Id As String)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.Ejecutar("Update Inventario set serie = " & IIf(CheckBox2.Checked = True, 1, 0) & ", SoloConExistencia = " & IIf(Me.ckValidaExistencia.Checked = True, 1, 0) & ", ValidaExistencia = " & IIf(Me.ckValidaExistencia.Checked = True, 1, 0) & " Where Codigo = " & _Id, CommandType.Text)
        Try
            db.Ejecutar("Update Inventario Set ActivarBodega2 = " & IIf(Me.ckActivarBodega.Checked = True, 1, 0) & " Where Codigo = " & _Id, CommandType.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RegistrarDatos()
        Try
            Dim funciones As New Conexion
            Dim datos As String
            Dim strActualiza As String = ""

            If IsClinica() = True Then
                If Me.txtCod_Articulo.Text.IndexOf(".") > 0 And Me.Ck_Consignacion.Checked = False Then
                    MsgBox("El codigo del produto debe ser un valor numerico", MsgBoxStyle.Exclamation, Me.Text)
                    Exit Sub
                End If
                If Me.txtCod_Articulo.Text.IndexOf(" ") > 0 Then
                    MsgBox("El codigo del produto debe ser un valor numerico", MsgBoxStyle.Exclamation, Me.Text)
                    Exit Sub
                End If
                If IsNumeric(Me.txtCod_Articulo.Text) = False Then
                    MsgBox("El codigo del produto debe ser un valor numerico", MsgBoxStyle.Exclamation, Me.Text)
                    Exit Sub
                End If
            End If

            Me.AdapterInventario.SelectCommand.Connection = Me.SqlConnection1
            Me.AdapterInventario.UpdateCommand.Connection = Me.SqlConnection1
            Me.AdapterInventario.DeleteCommand.Connection = Me.SqlConnection1
            Me.AdapterInventario.InsertCommand.Connection = Me.SqlConnection1
            Me.AdapterBitacora.SelectCommand.Connection = Me.SqlConnection1
            Me.AdapterBitacora.UpdateCommand.Connection = Me.SqlConnection1
            Me.AdapterBitacora.DeleteCommand.Connection = Me.SqlConnection1
            Me.AdapterBitacora.InsertCommand.Connection = Me.SqlConnection1

            If txtCod_Articulo.Text = "" Then
                MsgBox("Debe de ingresar el código del artículo!", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Me.TxtCantidad.Text = "" And Me.ChkOtro.Checked = True Then
                Dim cnat As Integer
                cnat = CInt(Me.TxtCantidad.Text)
                If cnat = 0 Then
                    MsgBox("Debe de ingresar la Cantidad por presentación en Kilogramos!", MsgBoxStyle.Information)
                End If
                Exit Sub
            End If

            If Me.TxtCodOtro.Text = "" And Me.ChkOtro.Checked = True Then
                MsgBox("Debe de ingresar el producto a descargar!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If CDbl(Me.TxtCosto.Text) = 0 Or CDbl(Me.TxtCosto.Text) < 0 Then
                MsgBox("El costo del artículo no puede ser 0, corrigalo", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim strExiste As String = buscarCodigoArticulo()
            If strExiste <> "" Then
                MsgBox("El Codigo del artículo asignado pertenece a :[" & strExiste & "] introduzca otro codigo!!")
                Exit Sub
            End If

            If ckVerCodBarraInv.Checked = True Then
                '-------------------------------------------------------------------------------------------------
                'Variable que indica si se ha presionado el boton de nuevo
                If strNuevo <> "" Then
                    Dim strExistencia As String = buscarCodigoBarra()
                    If strExistencia <> "" Then
                        MsgBox("El Codigo asignado pertenece a :[" & strExistencia & "] introduzca otro codigo!!")
                        Exit Sub
                    End If
                End If

                '-Si se realiza una actualizacion la aplicacion realiza una busqueda del Codigo de Barras--------------------

                strActualiza = buscarCodigoBarra2()

                If strActualiza <> "" Then
                    If strActualiza <> "Igual" Then
                        MsgBox("El Codigo de Barras asignado pertenece a :[" & strActualiza & "] introduzca otro codigo!!")
                        Exit Sub
                    End If
                End If

                '------------------------------------------------------------------------------------------------------------
            End If
            '********************************************************************************************
            'LFCHG 07122006 
            'DESCRIPCION DEL CAMBIO:
            'ELIMINACION DE LA VARIABLE NUEVO
            'VALIDACION EN CASO DE HABER UN CAMBIO EN LA TABLA INVENTARIO
            'INCLUIR EN UNA TRASSACCION EL PROCEDIMIENTO DE REGISTAR

            'If Me.ToolBarNuevo.Text = "Cancelar" Then
            Me.BindingContext(Me.DataSetInventario, "Bitacora").AddNew()
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Tabla") = "INVENTARIO"
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Campo_Clave") = Me.TxtCodigo.Text
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("DescripcionCampo") = Me.TxtDescripcion.Text
            'Se especifica que tipo de accion es si es un nuevo articulo o una actualizacion'
            If Me.ToolBarNuevo.Text = "Cancelar" Then
                Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO AGREGADO"
            Else
                Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO ACTUALIZADO"
            End If
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Usuario") = Me.txtNombreUsuario.Text
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Fecha") = Now
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Costo") = CDbl(Me.TxtCosto.Text)
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaA") = CDbl(Me.TxtPrecioVenta_A.Text)
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaB") = CDbl(Me.TxtPrecioVenta_B.Text)
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaC") = CDbl(Me.TxtPrecioVenta_C.Text)
            Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaD") = CDbl(Me.TxtPrecioVenta_D.Text)
            Me.BindingContext(Me.DataSetInventario, "Bitacora").EndCurrentEdit()
            'Else

            If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            Try
                Me.AdapterInventario.InsertCommand.Transaction = Trans
                Me.AdapterInventario.SelectCommand.Transaction = Trans
                Me.AdapterInventario.DeleteCommand.Transaction = Trans
                Me.AdapterInventario.UpdateCommand.Transaction = Trans
                Me.AdapterBitacora.SelectCommand.Transaction = Trans
                Me.AdapterBitacora.InsertCommand.Transaction = Trans
                Me.AdapterBitacora.DeleteCommand.Transaction = Trans
                Me.AdapterBitacora.UpdateCommand.Transaction = Trans
                '**************************************************************************
                Try
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Subfamilia") = ComboBoxFamilia.SelectedValue.ToString
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("serie") = CheckBox2.Checked
                Catch ex As Exception
                    MsgBox("Problemas al asignar SubFamilia, Favor revisar", MsgBoxStyle.Information, Text)
                    Me.ComboBoxFamilia.Focus()
                    Exit Sub
                End Try

                Try
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("CodMarca") = ComboBoxMarca.SelectedValue.ToString
                Catch ex As Exception
                    MsgBox("Problemas al asignar Marca, Favor revisar", MsgBoxStyle.Information, Text)
                    Me.ComboBoxMarca.Focus()
                    Exit Sub
                End Try

                Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Proveedor") = CInt(cmboxProveedor.SelectedValue)
                If Me.Ck_Consignacion.Checked = False Then
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("id_bodega") = 0
                End If

                Me.BindingContext(Me.DataSetInventario, "Inventario").Position -= 1
                Me.BindingContext(Me.DataSetInventario, "Inventario").Position += 1
                Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Precio_Sugerido") = 0
                Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SugeridoIV") = 0

                '**************************************************************************

                Me.AdapterInventario.Update(Me.DataSetInventario, "Inventario")
                Me.AdapterBitacora.Update(Me.DataSetInventario.Bitacora)
                Trans.Commit()
                Me.GuardarValidaExistencia(Me.TxtCodigo.Text)
                Me.RegistrarProductoRelacionados(Me.TxtCodigo.Text)
                Me.DataSetInventario.AcceptChanges()
            Catch ex As Exception
                Trans.Rollback()
                If Me.ToolBarNuevo.Text = "Cancelar" Then
                    MsgBox("Error al intentar Guardar el articulo en inventario" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                Else
                    MsgBox("Error al intentar Actualizar el articulo en inventario" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                End If

            End Try

            'UNA VEZ QUE SE REALIZARON LOS CAMBIOS EN EL INVENTARIO
            'LLAMAMOS A LA FUNCION PARA CARGAR EL INVENTARIO

            'NUEVO REGISTRO
            If Me.ToolBarNuevo.ImageIndex = 8 Then
                Me.Adaptador_Inventraio_AUX.Fill(Me.DataSetInventario, "Inventario2")
                Me.BindingContext(Me.DataSetInventario, "Inventario2").Position = Me.BindingContext(Me.DataSetInventario, "Inventario2").Count - 1
            Else
                'EDICION
            End If

            GuardaDescarga(Me.BindingContext(Me.DataSetInventario, "Inventario").Current("codigo"))

            Try
                Dim db As New GestioDatos
                db.Ejecuta("Update Inventario set Muestra = " & IIf(Me.ckMostrar.Checked = True, 1, 0) & ", ListaNegra = " & IIf(Me.ckListaNegra.Checked = True, 1, 0) & ", ImprimeCopia = " & IIf(Me.ckLaboratorio.Checked = True, 1, 0) & ", SinDecimal = " & IIf(Me.ckSinDecimales.Checked = True, 1, 0) & ", SoloContado = " & IIf(Me.ckSoloContado.Checked = True, 1, 0) & ", MAG = " & IIf(Me.ckMAG.Checked = True, 1, 0) & ", PromoCON = " & IIf(Me.ckContado.Checked = True, 1, 0) & ", PromoCRE = " & IIf(Me.ckCredito.Checked = True, 1, 0) & ", Id_Impuesto = " & Me.cboTipoImpuesto.SelectedValue & " Where Codigo = " & Me.BindingContext(Me.DataSetInventario, "Inventario").Current("codigo"))
            Catch ex As Exception
            End Try

            Try
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.AddParametro("@Codigo", Me.BindingContext(Me.DataSetInventario, "Inventario").Current("codigo"))
                db.Ejecutar("ActualizaPorcentajeImpuesto")

                'db.Ejecutar("update Inventario set FechaModificacion = getdate(), IdUsuarioModificacion = '" & Me.txtNombreUsuario.Text & "' where Codigo = " & Me.BindingContext(Me.DataSetInventario, "Inventario").Current("codigo"), CommandType.Text)
            Catch ex As Exception
            End Try

            'FIN DE CAMBIOS
            '************************************************************************************

            MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            Me.DataNavigator1.Enabled = True
            Me.ToolBarRegistrar.Text = "Actualizar"
            strNuevo = ""

        Catch ex As SystemException
            MsgBox(ex.Message)
            MsgBox("No se han detectado cambios en este item del Inventario para ser actualizados...", MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub NuevoRegistros()
        Try
            Me.CargarProductosRelacionados(0)
            Dim Link As New Conexion
            TxtCodigo.Text = CDbl(Link.SQLExeScalar("SELECT isnull(MAX(Codigo),0) FROM Inventario") + 1)
            Me.Text_Cod_AUX.Text = TxtCodigo.Text
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            TxtBarras.Text = ""
            TxtDescripcion.Text = ""
            TxtCanPresentacion.Text = "1"
            ComboBoxPresentacion.SelectedIndex = -1

            'ComboBoxMarca.SelectedIndex = -1
            'ComboBox_Ubicacion_SubUbicacion.SelectedIndex = -1
            'ComboBoxFamilia.SelectedIndex = -1
            ComboBoxMonedaVenta.SelectedIndex = 0
            ComboBoxMoneda.SelectedIndex = 0

            ComboBoxMarca.SelectedValue = Me.DataSetInventario.Marcas.Rows(0).Item(0)
            ComboBox_Ubicacion_SubUbicacion.SelectedValue = Me.DataSetInventario.SubUbicacion.Rows(0).Item(0)
            ComboBoxFamilia.SelectedValue = DataSetInventario.SubFamilias.Rows(0).Item(0)
            cmboxProveedor.SelectedValue = DataSetInventario.Proveedores.Rows(0).Item(0)

            CheckBox1.Checked = False
            TxtImpuesto.Enabled = IIf(CheckBox1.Checked, False, True)
            Me.BindingContext(DataSetInventario, "Inventario").Current("IVenta") = CDbl(Link.SQLExeScalar("SELECT Imp_Venta FROM  configuraciones"))
            Me.TxtImpuesto.Text = Me.BindingContext(DataSetInventario, "Inventario").Current("IVenta")
            TxtMin.Text = "0.00"
            TxtMax.Text = "0.00"
            TxtMed.Text = "0.00"
            TxtBase.Text = "0.00"
            TxtFlete.Text = "0.00"
            TxtCosto.Text = "0.00"
            TxtOtros.Text = "0.00"
            TxtPrecioVenta_A.Text = "0.00"
            TxtPrecioVenta_B.Text = "0.00"
            TxtPrecioVenta_C.Text = "0.00"
            TxtPrecioVenta_D.Text = "0.00"
            TxtPrecioVenta_IV_A.Text = "0.00"
            TxtPrecioVenta_IV_B.Text = "0.00"
            TxtPrecioVenta_IV_C.Text = "0.00"
            TxtPrecioVenta_IV_D.Text = "0.00"
            TxtObservaciones.Text = ""
            TxtExistencia.Text = "0.00"


            Me.txtCod_Articulo.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub TxtCanPresentacion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Select Case sender.NAME
            Case TxtCanPresentacion.Name
        End Select

        If TxtCanPresentacion.Text = "" Then
            ErrorProvider.SetError(sender, "Debe de digitar una cantidad...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
        End If

    End Sub

    Private Sub TxtCodigo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarras.GotFocus, TxtDescripcion.GotFocus, TxtCanPresentacion.GotFocus, TxtMed.GotFocus, TxtMax.GotFocus, TxtPrecioVenta_A.GotFocus, TxtPrecioVenta_B.GotFocus, TxtPrecioVenta_C.GotFocus, TxtPrecioVenta_D.GotFocus, TxtUtilidad_D.GotFocus, TxtUtilidad_A.GotFocus, TxtUtilidad_C.GotFocus, TxtUtilidad_B.GotFocus, TxtPrecioVenta_IV_D.GotFocus, TxtPrecioVenta_IV_A.GotFocus, TxtPrecioVenta_IV_C.GotFocus, TxtPrecioVenta_IV_B.GotFocus, TxtExistencia.GotFocus, TxtObservaciones.GotFocus, ComboBoxMonedaVenta.GotFocus, TxtMin.GotFocus, TxtImpuesto.GotFocus, TxtFlete.GotFocus, TxtOtros.GotFocus, TxtCosto.GotFocus, TxtBase.GotFocus
        If sender.name = ComboBoxMonedaVenta.Name Then
            DolarVenta()
        Else
            sender.SelectionStart = 0
            sender.SelectionLength = Len(sender.Text)
        End If
    End Sub

    Private Sub ComboBoxMonedaVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMonedaVenta.SelectedIndexChanged
        DolarVenta()
    End Sub

    Private Sub DolarVenta()
        Dim Link As New Conexion
        If Me.ComboBoxMonedaVenta.Text <> "" Then
            TextBoxValorMonedaEnVenta.Clear()
            TextBoxValorMonedaEnVenta.Text = CDbl(Link.SQLExeScalar("Select isnull(max(ValorCompra),0) from moneda where codmoneda = " & ComboBoxMonedaVenta.SelectedValue))
            Link.DesConectar(Link.Conectar)
            CalcularEquivalenciaMoneda()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim Link As New Conexion
        TxtImpuesto.Enabled = IIf(CheckBox1.Checked, False, True)
        'TxtImpuesto.Text = IIf(CheckBox1.Checked, "0.00", CDbl(Link.SQLExeScalar("SELECT Imp_Venta FROM  configuraciones")))
        Me.BindingContext(DataSetInventario.Inventario).Current("IVenta") = IIf(CheckBox1.Checked, "0.00", CDbl(Link.SQLExeScalar("SELECT Imp_Venta FROM  configuraciones")))
        Me.TxtImpuesto.Text = Me.BindingContext(DataSetInventario.Inventario).Current("IVenta")
        Link.DesConectar(Link.Conectar)
        EjecutarCalculos()
        If TxtImpuesto.Enabled = True Then TxtImpuesto.Focus() Else TxtBase.Focus()
    End Sub

    Private Sub CalcularEquivalenciaMoneda()
        If cargando = True Then Exit Sub
        Try
            TxtBaseEquivalente.Text = TxtBase.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
            TxtFleteEquivalente.Text = TxtFlete.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
            TxtOtrosCargosEquivalente.Text = TxtOtros.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
            TxtCostoEquivalente.Text = TxtCosto.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EjecutarCalculos()
        If cargando = True Then Exit Sub
        Try
            Dim Evento As New System.Windows.Forms.KeyPressEventArgs(Chr(Keys.Enter))
            ' Salto = False
            DolarVenta()
            TextBox1_KeyPress(TxtPrecioVenta_A, Evento)
            TextBox1_KeyPress(TxtPrecioVenta_B, Evento)
            TextBox1_KeyPress(TxtPrecioVenta_C, Evento)
            TextBox1_KeyPress(TxtPrecioVenta_D, Evento)
            TextBox1_KeyPress(TxtPrecioVenta_P, Evento)
            TextBox1_KeyPress(txtVentaSugerido, Evento)
            ' Salto = True
            TxtImpuesto.Enabled = IIf(CheckBox1.Checked, False, True)

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtUtilidad_A_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.LostFocus, TxtBarras.LostFocus, TxtCanPresentacion.LostFocus, TxtMed.LostFocus, TxtMax.LostFocus, TxtPrecioVenta_A.LostFocus, TxtPrecioVenta_B.LostFocus, TxtPrecioVenta_C.LostFocus, TxtPrecioVenta_D.LostFocus, TxtUtilidad_D.LostFocus, TxtUtilidad_A.LostFocus, TxtUtilidad_C.LostFocus, TxtUtilidad_B.LostFocus, TxtPrecioVenta_IV_D.LostFocus, TxtPrecioVenta_IV_A.LostFocus, TxtPrecioVenta_IV_C.LostFocus, TxtPrecioVenta_IV_B.LostFocus, TxtExistencia.LostFocus, TxtObservaciones.LostFocus, ComboBoxBodegas.LostFocus, ComboBoxPresentacion.LostFocus, ComboBox_Ubicacion_SubUbicacion.LostFocus, ComboBoxFamilia.LostFocus, ComboBoxMonedaVenta.LostFocus, ComboBoxMarca.LostFocus, TxtUtilidad_P.LostFocus, TxtPrecioVenta_P.LostFocus, TxtPrecioVenta_IV_P.LostFocus, TxtMin.LostFocus, TxtImpuesto.LostFocus, TxtFlete.LostFocus, TxtOtros.LostFocus, TxtCosto.LostFocus, ComboBoxMoneda.LostFocus, CheckBox1.LostFocus, TxtBase.LostFocus
        Try

            If cargando = True Then Exit Sub
            Select Case sender.Name
                Case TxtBase.Name, TxtFlete.Name, TxtOtros.Name
                    If TxtBase.Text = "" Then TxtBase.Text = 0
                    If TxtFlete.Text = "" Then TxtFlete.Text = 0
                    If TxtOtros.Text = "" Then TxtOtros.Text = 0
                    TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                    CalcularEquivalenciaMoneda()
                    'calculo de precios por la utilidad
                Case TxtUtilidad_A.Name
                    If TxtUtilidad_A.Text = "" Then TxtUtilidad_A.Text = 0
                    TxtPrecioVenta_A.Text = TxtBaseEquivalente.Text * (TxtUtilidad_A.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                    TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_A.Text

                Case TxtUtilidad_B.Name
                    If TxtUtilidad_B.Text = "" Then TxtUtilidad_B.Text = 0
                    TxtPrecioVenta_B.Text = TxtBaseEquivalente.Text * (TxtUtilidad_B.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                    TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_B.Text

                Case TxtUtilidad_C.Name
                    If TxtUtilidad_C.Text = "" Then TxtUtilidad_C.Text = 0
                    TxtPrecioVenta_C.Text = TxtBaseEquivalente.Text * (TxtUtilidad_C.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                    TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_C.Text

                Case TxtUtilidad_D.Name
                    If TxtUtilidad_D.Text = "" Then TxtUtilidad_D.Text = 0
                    TxtPrecioVenta_D.Text = TxtBaseEquivalente.Text * (TxtUtilidad_D.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                    TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_D.Text

                Case TxtUtilidad_P.Name
                    If TxtUtilidad_P.Text = "" Then TxtUtilidad_P.Text = 0
                    TxtPrecioVenta_P.Text = TxtBaseEquivalente.Text * (TxtUtilidad_P.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + TxtBaseEquivalente.Text
                    TxtPrecioVenta_IV_P.Text = TxtPrecioVenta_P.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_P.Text


                    'calculo de de utilidad por el precio A y calculo del precio com I.V.
                Case TxtPrecioVenta_A.Name
                    If TxtPrecioVenta_A.Text = "" Then TxtPrecioVenta_A.Text = 0
                    TxtUtilidad_A.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                    TxtPrecioVenta_IV_A.Text = TxtPrecioVenta_A.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_A.Text

                Case TxtPrecioVenta_B.Name
                    If TxtPrecioVenta_B.Text = "" Then TxtPrecioVenta_B.Text = 0
                    TxtUtilidad_B.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                    TxtPrecioVenta_IV_B.Text = TxtPrecioVenta_B.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_B.Text

                Case TxtPrecioVenta_C.Name
                    If TxtPrecioVenta_C.Text = "" Then TxtPrecioVenta_C.Text = 0
                    TxtUtilidad_C.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                    TxtPrecioVenta_IV_C.Text = TxtPrecioVenta_C.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_C.Text

                Case TxtPrecioVenta_D.Name
                    If TxtPrecioVenta_D.Text = "" Then TxtPrecioVenta_D.Text = 0
                    TxtUtilidad_D.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                    TxtPrecioVenta_IV_D.Text = TxtPrecioVenta_D.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_D.Text

                Case TxtPrecioVenta_P.Name
                    If TxtPrecioVenta_P.Text = "" Then TxtPrecioVenta_P.Text = 0
                    TxtUtilidad_P.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                    TxtPrecioVenta_IV_P.Text = TxtPrecioVenta_P.Text * (TxtImpuesto.Text / 100) + TxtPrecioVenta_P.Text

                    'CALCULO DE PRECIO DE VENTA Y RECALCULAR LA  UTILIDAD CON BASE A LOS NUEVOS PRECIOS 
                Case TxtPrecioVenta_IV_A.Name
                    If TxtPrecioVenta_IV_A.Text = "" Then TxtPrecioVenta_IV_A.Text = 0
                    TxtPrecioVenta_A.Text = TxtPrecioVenta_IV_A.Text / (1 + (TxtImpuesto.Text / 100))
                    TxtUtilidad_A.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                Case TxtPrecioVenta_IV_B.Name
                    If TxtPrecioVenta_IV_B.Text = "" Then TxtPrecioVenta_IV_B.Text = 0
                    TxtPrecioVenta_B.Text = TxtPrecioVenta_IV_B.Text / (1 + (TxtImpuesto.Text / 100))
                    TxtUtilidad_B.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                Case TxtPrecioVenta_IV_C.Name
                    If TxtPrecioVenta_IV_C.Text = "" Then TxtPrecioVenta_IV_C.Text = 0
                    TxtPrecioVenta_C.Text = TxtPrecioVenta_IV_C.Text / (1 + (TxtImpuesto.Text / 100))
                    TxtUtilidad_C.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                Case TxtPrecioVenta_IV_D.Name
                    If TxtPrecioVenta_IV_D.Text = "" Then TxtPrecioVenta_IV_D.Text = 0
                    TxtPrecioVenta_D.Text = TxtPrecioVenta_IV_D.Text / (1 + (TxtImpuesto.Text / 100))
                    TxtUtilidad_D.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))

                Case TxtPrecioVenta_IV_P.Name
                    If TxtPrecioVenta_IV_P.Text = "" Then TxtPrecioVenta_IV_P.Text = 0
                    TxtPrecioVenta_P.Text = TxtPrecioVenta_IV_P.Text / (1 + (TxtImpuesto.Text / 100))
                    TxtUtilidad_P.Text = Utilidad(TxtBaseEquivalente.Text, (TxtPrecioVenta_P.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Check_Promo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Promo.CheckedChanged
        If Me.Check_Promo.Checked = True Then
            Me.Desde.Value = Date.Now
            Me.Hasta.Value = Date.Now
            Me.Desde.Enabled = True
            Me.Hasta.Enabled = True
            Me.Label33.Enabled = True
            Me.Label34.Enabled = True
            Me.TxtPrecioVenta_P.Enabled = True
            Me.TxtUtilidad_P.Enabled = True
            TxtPrecioVenta_IV_P.Enabled = True
        Else
            Me.Desde.Enabled = False
            Me.Hasta.Enabled = False
            Me.Label33.Enabled = False
            Me.Label34.Enabled = False
            Me.TxtPrecioVenta_P.Enabled = False
            Me.TxtUtilidad_P.Enabled = False
            TxtPrecioVenta_IV_P.Enabled = False
        End If
    End Sub

    Private Sub Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desde.ValueChanged
        Me.Validate()
    End Sub

    Private Sub Desde_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Desde.Validating
        If CType(Desde.Value, Date) > CType(Hasta.Value, Date) Then
            ErrorProvider.SetError(sender, "La fecha Inicial no puede ser mayor que la fecha Final...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hasta.ValueChanged
        Me.Validate()
    End Sub

    Private Sub Hasta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Hasta.Validating
        If CType(Desde.Value, Date) > CType(Hasta.Value, Date) Then
            ErrorProvider.SetError(sender, "La fecha Inicial no puede ser mayor que la fecha Final...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub TxtBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarras.TextChanged
        If Len(Me.TxtBarras.Text) = 5 Then
            If Me.TxtBarras.Text.Chars(4) = "%" Then Buscar_Codigo()
        End If
    End Sub

    Private Sub TxtBarras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarras.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : ComboBoxFamilia.Focus()
            Case Keys.F1 : BuscarRegistros()
            Case Keys.F3
                If Me.TxtBarras.Text = "" Then
                    Me.TxtBarras.Text = Me.GenerarCodigoBarras
                End If
        End Select
    End Sub
    Private Sub TxtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCanPresentacion.Focus()
        End If

        If e.KeyCode = Keys.F1 Then
            BuscarRegistros()
        End If
    End Sub

    Private Sub TxtCanPresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCanPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxPresentacion.Focus()
        End If

        If e.KeyCode = Keys.F1 Then
            BuscarRegistros()
        End If
    End Sub

    Private Sub ComboBoxPresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBarras.Focus()
        End If
    End Sub

    Private Sub ComboBoxFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxFamilia.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("SELECT SubFamilias.Codigo, Familia.Descripcion + '/' + SubFamilias.Descripcion AS Familiares FROM SubFamilias INNER JOIN Familia ON SubFamilias.CodigoFamilia = Familia.Codigo", "Familia.Descripcion + '/' + SubFamilias.Descripcion", "Buscar Familia...")

                If valor = "" Then
                    Me.ComboBoxFamilia.SelectedIndex = -1
                Else
                    Me.ComboBoxFamilia.SelectedValue = valor
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SubFamilia") = valor
                    Dim p As Integer = Me.BindingContext(Me.DataSetInventario, "SubFamilias").Position
                    Me.BindingContext(Me.DataSetInventario, "SubFamilias").Position += 1
                    Me.BindingContext(Me.DataSetInventario, "SubFamilias").Position = p
                End If
            End If


            If e.KeyCode = Keys.Enter Then

                Dim valor As String
                valor = Me.ComboBoxFamilia.SelectedValue
                Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SubFamilia") = valor
                Dim p As Integer = Me.BindingContext(Me.DataSetInventario, "SubFamilias").Position
                Me.BindingContext(Me.DataSetInventario, "SubFamilias").Position += 1
                Me.BindingContext(Me.DataSetInventario, "SubFamilias").Position = p

                Me.ComboBox_Ubicacion_SubUbicacion.Focus()


            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox_Ubicacion_SubUbicacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Ubicacion_SubUbicacion.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("SELECT SubUbicacion.Codigo, Ubicaciones.Descripcion + '/' + SubUbicacion.DescripcionD AS Ubicaciones FROM SubUbicacion INNER JOIN Ubicaciones ON SubUbicacion.Cod_Ubicacion = Ubicaciones.Codigo", "Ubicaciones.Descripcion + '/' + SubUbicacion.DescripcionD", "Buscar Ubicación...")
                If valor = "" Then
                    Me.ComboBox_Ubicacion_SubUbicacion.SelectedIndex = -1
                Else
                    Me.ComboBox_Ubicacion_SubUbicacion.SelectedValue = valor
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SubUbicacion") = valor
                End If

            End If

            If e.KeyCode = Keys.Enter Then
                Dim valor As String

                valor = Me.ComboBox_Ubicacion_SubUbicacion.SelectedValue
                Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SubUbicacion") = valor
                cmboxProveedor.Focus()

            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComboBoxMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxMarca.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("Select CodMarca,Marca from Marcas", "Marca", "Buscar Marca...")

                If valor = "" Then
                    Me.ComboBoxMarca.SelectedIndex = -1
                Else
                    Me.ComboBoxMarca.SelectedValue = CInt(valor)
                    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("CodMarca") = valor
                End If

            End If

            If e.KeyCode = Keys.Enter Then

                Dim valor As String
                valor = Me.ComboBoxMarca.SelectedValue
                Me.BindingContext(Me.DataSetInventario, "Inventario").Current("CodMarca") = valor
                ComboBoxMoneda.Focus()

            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxMoneda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            'TxtImpuesto.Focus()
            Me.cboTipoImpuesto.Focus()
        End If
    End Sub

    Private Sub TxtImpuesto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtImpuesto.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.TxtBase.Focus()

                If Me.TxtImpuesto.Text <> "" Then TxtBase.Focus() Else Me.TxtImpuesto.Text = "0"

            End If

        Catch ex As SyntaxErrorException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCosto.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If Me.TxtCosto.Text <> "" And Me.TxtCosto.Text <> "0" Then
                    ComboBoxMonedaVenta.Focus()
                Else
                    Me.TxtCosto.Text = "0"
                End If
            End If

        Catch ex As SyntaxErrorException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxMonedaVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxMonedaVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtUtilidad_A.Focus()
        End If
    End Sub

    Private Sub TxtUtilidad_A_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUtilidad_A.KeyDown, TxtUtilidad_B.KeyDown, TxtUtilidad_C.KeyDown, TxtUtilidad_D.KeyDown, TxtUtilidadR_A.KeyDown, TxtUtilidadR_B.KeyDown, TxtUtilidadR_C.KeyDown, TxtUtilidadR_D.KeyDown, TxtUtilidadR_P.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub TxtMaxDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMaxDesc.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtBarras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBarras.KeyPress
        Try

            If (Not e.KeyChar.IsDigit(e.KeyChar)) And (Not e.KeyChar.IsLetter(e.KeyChar)) Then   ' valida que en este campo solo se digiten numeros y/o "-"
                If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "%"c) Then
                    e.Handled = True  ' esto invalida la tecla pulsada
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Buscar_Codigo()
        Dim func As New Conexion
        Dim func2 As New Conexion
        Dim retorna As String
        Dim Nuevo_Codigo As String
        Dim cod As Integer
        Dim rs As SqlDataReader
        Dim Codigo_Subfamilia As String
        Dim existe As Boolean

        rs = func.GetRecorset(func.Conectar, "SELECT RIGHT('00' + CAST(CodigoFamilia AS varchar), 2) + RIGHT('00' + CAST(SubCodigo AS varchar), 2) AS Codigo_Ceros, Codigo FROM SubFamilias WHERE (RIGHT('00' + CAST(CodigoFamilia AS varchar), 2) + RIGHT('00' + CAST(SubCodigo AS varchar), 2) = '" & Mid(Me.TxtBarras.Text, 1, 4) & "')")
        While rs.Read
            Codigo_Subfamilia = rs("Codigo")

            cod = func.SlqExecuteScalar(func2.Conectar, "SELECT max(ISNULL(CodConsFam, 0)) AS Maximo FROM Vista_Generador_Barras WHERE (CodBarrasArticulo LIKE '" & Me.TxtBarras.Text & "') GROUP BY CodigoSubFamilia")
            cod = cod + 1
            func2.DesConectar(func2.Conectar)

            Nuevo_Codigo = Mid(Me.TxtBarras.Text, 1, 4) & Format(cod, "0000")

            'mientras ya exista un articulo en el inventario con ese código de barras
            Do While func.SlqExecuteScalar(func2.Conectar, "select Barras from Inventario where Barras ='" & Nuevo_Codigo & "'") <> Nothing
                cod = cod + 1
                Nuevo_Codigo = Mid(Me.TxtBarras.Text, 1, 4) & Format(cod, "0000")
            Loop
            Me.TxtBarras.Text = Nuevo_Codigo
            ComboBoxFamilia.SelectedValue = Codigo_Subfamilia
            existe = True
            Me.TxtDescripcion.Focus()

        End While

        func.DesConectar(func.Conectar)
        func2.DesConectar(func2.Conectar)


        If existe = False Then
            MsgBox("No existe una subfamilia con ese código", MsgBoxStyle.Information)
            Me.TxtBarras.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            Select Case sender.name
                Case CheckBox1.Name
                    TxtImpuesto.Focus()
            End Select
        End If
    End Sub

    Private Sub TxtFlete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFlete.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub ComboBoxBodegas_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxBodegas.GotFocus, ComboBoxMonedaVenta.GotFocus, ComboBoxMoneda.GotFocus
        SendKeys.Send("{F4}")
    End Sub

    Private Sub ComboBoxBodegas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxBodegas.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub cmboxProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmboxProveedor.KeyDown
        Try

            If e.KeyCode = Keys.F1 Then
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("SELECT CodigoProv, Nombre FROM Proveedores", "Nombre", "Buscar Proveedor...")
                If valor = "" Then
                    Me.cmboxProveedor.SelectedIndex = -1
                Else
                    Me.cmboxProveedor.SelectedValue = valor
                    Me.BindingContext(Me.DataSetInventario, "Proveedores").Current("CodigoProv") = valor
                    Dim p As Integer = Me.BindingContext(Me.DataSetInventario, "Proveedores").Position

                    Me.BindingContext(Me.DataSetInventario, "Proveedores").Position += 1
                    Me.BindingContext(Me.DataSetInventario, "Proveedores").Position = p

                End If

            End If
            If e.KeyCode = Keys.Enter Then

                Dim valor As String
                valor = Me.cmboxProveedor.SelectedValue
                Me.BindingContext(Me.DataSetInventario, "Proveedores").Current("CodigoProv") = valor
                Dim p As Integer = Me.BindingContext(Me.DataSetInventario, "Proveedores").Position

                BindingContext(DataSetInventario, "Proveedores").Position += 1
                BindingContext(DataSetInventario, "Proveedores").Position = p
                ComboBoxMarca.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje")
        End Try
    End Sub

    Private Sub ckVerCodBarraInv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckVerCodBarraInv.CheckedChanged
        SaveSetting("SeeSOFT", "SeePOS", "VerCodBarraInv", Me.ckVerCodBarraInv.Checked)
    End Sub

    Private Sub Ck_Consignacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ck_Consignacion.CheckedChanged
        'ComboBoxBodegas.Enabled = Ck_Consignacion.Checked
        If Me.Ck_Consignacion.Checked = True Then
            Me.ComboBoxBodegas.Enabled = True
        Else
            Me.ComboBoxBodegas.SelectedItem = 0
            Me.ComboBoxBodegas.Enabled = False

        End If
    End Sub

    Private Sub txtCod_Articulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod_Articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescripcion.Focus()
        End If

        If e.KeyCode = Keys.F1 Then
            BuscarRegistros()
        End If
    End Sub

    Private Function Buscacodigo(ByVal Codigo As String) As String
        Dim func As New Conexion
        Dim cod As Double
        Try
I:
            cod = func.SlqExecuteScalar(func.Conectar, "SELECT ISNULL(MAX(CAST(Cod_Articulo as float)),0) AS Maximo FROM Inventario WHERE (Cod_Articulo LIKE '" & Codigo & ".%')")
            If cod = Codigo & ".999" Then
                cod = cod + 0.001
                Codigo = CInt(cod)
                GoTo I
            ElseIf cod = 0 Then
                Return Codigo & ".001"
            Else
                cod = cod + 0.001
                Return (cod)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al generar código!")
            Return 0
        Finally
            func.DesConectar(func.Conectar)
        End Try
    End Function

    Private Sub txtCod_Articulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod_Articulo.KeyPress
        If IsNumeric(sender.text & e.KeyChar) Then
            If (e.KeyChar = ".") Then
                txtCod_Articulo.Text = Buscacodigo(txtCod_Articulo.Text)
                e.Handled = True  ' esto invalida la tecla pulsada
                txtCod_Articulo.SelectAll()
            End If
        End If
    End Sub

    Private Sub TxtCodOtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodOtro.TextChanged
        If Me.TxtCodOtro.Text <> "" Then CargarInformacionDescarga(Me.TxtCodOtro.Text)
    End Sub

    Private Sub ChkOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOtro.CheckedChanged

        'If MessageBox.Show("Al Cambiar el estado de esta casilla podria ver afectadas las Existencias, ya que se reducira de un producto o de otro en especifico! ¿Esta seguro de Cambiar?", "Precaución...!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

        If ChkOtro.Checked = True Then

            Me.LbCodOtro.Visible = True
            Me.LbCantidad.Visible = True
            Me.LbDescOtro.Visible = True
            Me.LbPresOtro.Visible = True
            Me.TxtCodOtro.Visible = True
            Me.TxtDesOtro.Visible = True
            Me.TxtCantOtro.Visible = True
            Me.TxtCantidad.Visible = True
            Me.TxtPresentacion.Visible = True

            Me.TxtCodOtro.Enabled = True
            Me.TxtDesOtro.Enabled = True
            Me.TxtCantOtro.Enabled = True
            Me.TxtCantidad.Enabled = True
            Me.TxtPresentacion.Enabled = True

        Else
            Me.LbCantidad.Visible = False
            Me.TxtCantidad.Visible = False
            Me.LbCodOtro.Visible = False
            Me.LbDescOtro.Visible = False
            Me.LbPresOtro.Visible = False
            Me.TxtCodOtro.Visible = False
            Me.TxtDesOtro.Visible = False
            Me.TxtCantOtro.Visible = False
            Me.TxtPresentacion.Visible = False
            Me.TxtDesOtro.Text = ""
            Me.TxtCodOtro.Enabled = False
            Me.TxtDesOtro.Enabled = False
            Me.TxtCantOtro.Enabled = False
            Me.TxtCantidad.Enabled = False
            Me.TxtPresentacion.Enabled = False

        End If
        'End If
    End Sub

    Private Sub TxtCodOtro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodOtro.KeyDown
        Dim CConexion As New Conexion
        If e.KeyCode = Keys.Enter Then
            TxtDescripcion.Focus()
        End If

        If e.KeyCode = Keys.F1 Then
            Dim BuscarDescarga As New cFunciones
            Dim c As String
            c = BuscarDescarga.BuscarDatos("SELECT   Inventario.Codigo, Inventario.Descripcion +'      '+  Cast( Inventario.PresentaCant as varchar)  +  cast(Presentaciones.Presentaciones as varchar) FROM  Inventario INNER JOIN Presentaciones ON Inventario.CodPresentacion = Presentaciones.CodPres where inhabilitado=0", "Descripcion")

            If c <> "" Then
                Me.TxtCodOtro.Text = c
            Else
                Exit Sub
            End If

            If Me.TxtCodOtro.Text <> "" And Me.TxtCodOtro.Text <> "0" Then
                Me.SqlConnection1 = CConexion.Conectar
                CargarInformacionDescarga(TxtCodOtro.Text)
            Else
                Exit Sub
            End If

        End If
    End Sub

    Private Sub GuardaDescarga(ByVal _id As Integer)
        Dim SQL As New GestioDatos
        If Me.ChkOtro.Checked = True Then
            SQL.Ejecuta("update dbo.Inventario set CantidadDescarga = " & Me.TxtCantidad.Text & ", CodigoDescarga= '" & Me.TxtCodOtro.Text & "',CantidadPresentOtro = " & Me.TxtCantOtro.Text & ",Cod_PresentOtro = " & codPresent & ", DescargaOtro = 1 where Codigo = " & _id)
        Else
            SQL.Ejecuta("update dbo.Inventario set CantidadDescarga = 0 , CodigoDescarga= 0,Cod_PresentOtro = 0,CantidadPresentOtro = 0, DescargaOtro = 0 where Codigo = " & _id)
        End If
    End Sub

    Private Sub CargarInformacionDescarga(ByVal _codigo As String)


        Dim Dt As New DataTable
        Dim Dtp As New DataTable

        cFunciones.Llenar_Tabla_Generico(" select * from inventario where codigo = " & _codigo, Dt, CadenaConexionSeePOS)

        If Dt.Rows.Count > 0 Then
            Me.TxtDesOtro.Text = Dt.Rows(0).Item("Descripcion")
            Me.TxtCantOtro.Text = Dt.Rows(0).Item("PresentaCant")
            codPresent = Dt.Rows(0).Item("CodPresentacion")
            cFunciones.Llenar_Tabla_Generico("select Presentaciones from dbo.Presentaciones where  CodPres = " & codPresent, Dtp, CadenaConexionSeePOS)

            Me.TxtPresentacion.Text = Dtp.Rows(0).Item("Presentaciones")

        End If

    End Sub
    Private Sub Reloggin_Usuario()
        Try
            If BindingContext(Me.DataSetInventario.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = DataSetInventario.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 

                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas...", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If

                    'Me.NuevoRegistros()

                    txtNombreUsuario.Text = Usua("Nombre")
                    'Validar si el usuario puede o no anular una venta

                    txtCod_Articulo.Focus()

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


    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Dim serie As String = InputBox("")
        'Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        'If MsgBox("Desea seguir", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then

        '    db.Ejecutar("Insert into Serie(codigo, serie, vendido, factura) values(" & Me.TxtCodigo.Text & ",'" & serie & "',0,0)", CommandType.Text)

        'End If
        'Exit Sub

        Try
            'zoe
            Me.BindingContext(Me.DataSetInventario, "serie").AddNew()
            Me.BindingContext(Me.DataSetInventario, "serie").Current("codigo") = Me.TxtCodigo.Text
            Me.BindingContext(Me.DataSetInventario, "serie").Current("vendido") = False
            Me.BindingContext(Me.DataSetInventario, "serie").Current("factura") = 0
            Me.BindingContext(Me.DataSetInventario, "serie").Current("serie") = Me.txtserie.Text

            Me.BindingContext(Me.DataSetInventario, "serie").EndCurrentEdit()
            Me.BindingContext(Me.DataSetInventario, "serie").AddNew()
            Me.BindingContext(Me.DataSetInventario, "serie").CancelCurrentEdit()
            Me.txtserie.Text = ""

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Me.adserie.Update(Me.DataSetInventario.serie)

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarActualizado(_Id As String)
        If _Id = "" Then _Id = "0"
        Me.ckActualizado.Checked = False
        Me.ckActivarBodega.Checked = False
        Me.txtExistenciaBodega2.Text = ""
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select actualizado, isnull(FechaActualizacion,'') as FechaActualizacion, ActivarBodega2, ExistenciaBodega2, ImprimeCopia, ListaNegra from inventario where codigo = " & _Id, dts)
            If dts.Rows.Count > 0 Then
                Me.ckActualizado.Checked = dts.Rows(0).Item("actualizado")
                Me.ckLaboratorio.Checked = dts.Rows(0).Item("ImprimeCopia")
                Me.ckListaNegra.Checked = dts.Rows(0).Item("ListaNegra")
                Dim fecha As String = CDate(dts.Rows(0).Item("FechaActualizacion")).ToString("d")
                Me.lblFechaActualizacion.Text = IIf(fecha = "1/1/1900", "", fecha)
                Me.ckActivarBodega.Checked = dts.Rows(0).Item("ActivarBodega2")
                Me.txtExistenciaBodega2.Text = dts.Rows(0).Item("ExistenciaBodega2")
                If CDec(Me.txtExistenciaBodega2.Text) > 0 Then
                    Me.ckActivarBodega.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub consultar_costo_real()
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select round(dbo.precio_final(codigo),2)as costo, round(dbo.precio_finalEcommer(codigo),2)as costoTienda from inventario where codigo = " & TxtCodigo.Text, dts)
        If dts.Rows.Count > 0 Then
            Me.txtcosto_real.Text = dts.Rows(0).Item("costo")
            Me.txtCostoTienda.Text = dts.Rows(0).Item("costoTienda")
        End If
    End Sub

    Private Function GetPrecioUnitarioArticuloRelaccionado(_Cod As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Precio_A from Inventario where Codigo = " & _Cod, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Precio_A")
        Else
            Return 0
        End If
    End Function

    Private Sub RegistrarProductoRelacionados(_Id As String)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim Id As String = _Id
        Dim PrecioUnit As Decimal = Me.TxtPrecioVenta_A.Text

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("exec [usp_GetArticulosRelaccionados] " & Id & ", " & PrecioUnit, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Try
                Dim frm As New frmProductosRelacionados
                frm.Codigo = Id
                frm.PrecioUnit = PrecioUnit
                frm.txtDescripcion.Text = Me.TxtDescripcion.Text
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                    Try
                        Trans.Ejecutar("Update ArticulosRelacionados Set Precio_Unit = " & PrecioUnit & " Where Codigo = " & Id, CommandType.Text)
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
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        db.Ejecutar("Delete from ArticulosRelacionados where CodigoPrincipal = " & Id, CommandType.Text)
        Dim Codigo, CodArticulo, Descripcion, Cantidad As String
        Dim PrecioUnitario As Decimal = 0
        For Each f As DataGridViewRow In Me.viewRelacionados.Rows
            Codigo = f.Cells("cCodigo").Value
            CodArticulo = f.Cells("cCodArticulo").Value
            Descripcion = f.Cells("cDescripcion").Value
            Cantidad = f.Cells("cCantidad").Value
            PrecioUnitario = Me.GetPrecioUnitarioArticuloRelaccionado(Codigo)
            db.Ejecutar("Insert into ArticulosRelacionados(CodigoPrincipal, Codigo, CodArticulo, Descripcion, Cantidad, Precio_Unit) Values(" & Id & ", " & Codigo & ", '" & CodArticulo & "', '" & Descripcion & "', " & Cantidad & ", " & PrecioUnitario & ")", CommandType.Text)
        Next

    End Sub

    Private Sub CargarProductosRelacionados(_Id As String)
        Dim dt As New DataTable
        Me.viewRelacionados.Rows.Clear()
        Me.IndesxRelacionados = 0
        cFunciones.Llenar_Tabla_Generico("Select * from ArticulosRelacionados Where CodigoPrincipal = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                Me.AgregarProductosRelacionados(r.Item("Codigo"), r.Item("CodArticulo"), r.Item("Descripcion"), r.Item("Cantidad"))
            Next
        End If
    End Sub

    Private IndesxRelacionados As Integer = 0
    Private Sub AgregarProductosRelacionados(_Codigo As String, _CodArticulso As String, _Descripcion As String, _Cant As Decimal)
        Me.viewRelacionados.Rows.Add()
        Me.viewRelacionados.Item("cCodigo", Me.IndesxRelacionados).Value = _Codigo
        Me.viewRelacionados.Item("cCodArticulo", Me.IndesxRelacionados).Value = _CodArticulso
        Me.viewRelacionados.Item("cDescripcion", Me.IndesxRelacionados).Value = _Descripcion
        Me.viewRelacionados.Item("cCantidad", Me.IndesxRelacionados).Value = _Cant
        Me.IndesxRelacionados += 1
    End Sub

    Private Function Obtener_BasedeDatos() As String
        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Dim Texto As String = Conexion(1)

        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado
    End Function

    Private CodigoRelacion As String = "0"
    Private CodArticuloRelacion As String = ""
    Private DescripcionRelacion As String = ""

    Private Sub btnAgregarRelacion_Click(sender As Object, e As EventArgs) Handles btnAgregarRelacion.Click
        If Me.txtCodigoRelacion.Text <> "" And Me.txtDescripcionRelacion.Text <> "" And Me.txtCantidadRelacion.Text <> "" Then
            If IsNumeric(Me.txtCantidadRelacion.Text) Then
                Me.AgregarProductosRelacionados(Me.CodigoRelacion, Me.CodArticuloRelacion, Me.DescripcionRelacion, Me.txtCantidadRelacion.Text)
                Me.txtCodigoRelacion.Text = ""
                Me.txtDescripcionRelacion.Text = ""
                Me.txtCantidadRelacion.Text = ""
                Me.CodigoRelacion = ""
                Me.CodArticuloRelacion = ""
                Me.DescripcionRelacion = ""
            Else
                MsgBox("La cantidad debe ser un valor numerico mayor a cero", MsgBoxStyle.Exclamation, Text)
            End If
        Else
            MsgBox("Faltan datos por digitar", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Return ""
        End If
        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function

    Private Sub txtCodigoRelacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoRelacion.KeyDown
        If e.KeyCode = Keys.F1 Then

            Dim codigo As String = Me.BuscarF1
            If codigo <> "" Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Consignacion, ExistenciaBodega, Codigo, Cod_Articulo, Descripcion from Inventario where Cod_Articulo = '" & codigo & "' and inhabilitado = 0", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    'If dt.Rows(0).Item("Consignacion") = 0 Then
                    Me.CodigoRelacion = dt.Rows(0).Item("Codigo")
                    Me.CodArticuloRelacion = dt.Rows(0).Item("Cod_Articulo")
                    Me.txtCodigoRelacion.Text = Me.CodArticuloRelacion
                    Me.DescripcionRelacion = dt.Rows(0).Item("Descripcion")
                    Me.txtDescripcionRelacion.Text = dt.Rows(0).Item("Descripcion")
                    Me.TxtCanPresentacion.Focus()
                    'Else
                    'MsgBox("No se puede relacionar un producto que sea de consignacion", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                    'End If
                End If
            End If

        End If

        If e.KeyCode = Keys.Enter And Me.txtCodigoRelacion.Text <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Consignacion, ExistenciaBodega, Codigo, Cod_Articulo, Descripcion from inventario where cod_articulo = '" & Me.txtCodigoRelacion.Text & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                'If dt.Rows(0).Item("Consignacion") = 0 Then
                Me.CodigoRelacion = dt.Rows(0).Item("Codigo")
                Me.CodArticuloRelacion = dt.Rows(0).Item("Cod_Articulo")
                Me.DescripcionRelacion = dt.Rows(0).Item("Descripcion")
                Me.txtDescripcionRelacion.Text = dt.Rows(0).Item("Descripcion")
                Me.TxtCanPresentacion.Focus()
                'Else
                'MsgBox("No se puede relacionar un producto que sea de consignacion", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                'End If
            End If
        End If
    End Sub
    Private dtImpuestos As New DataTable
    Private Sub cargarImpuestos()
        cFunciones.Llenar_Tabla_Generico("Select * from viewImpuestos", dtImpuestos, CadenaConexionSeePOS)
        Me.cboTipoImpuesto.DataSource = dtImpuestos
        Me.cboTipoImpuesto.DisplayMember = "Impuesto"
        Me.cboTipoImpuesto.ValueMember = "Id_Impuesto"
    End Sub

    Private Sub CargarIVenta()
        Try
            Dim id As Integer = Me.cboTipoImpuesto.SelectedValue
            Dim Impuesto As New System.Collections.Generic.List(Of DataRow)
            Impuesto = (From x As DataRow In Me.dtImpuestos Where x.Item("Id_Impuesto") = id Select x).ToList()
            Me.TxtImpuesto.EditValue = Impuesto(0).Item("Porcentaje")
            EjecutarCalculos()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub viewRelacionados_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles viewRelacionados.RowsRemoved
        Me.IndesxRelacionados -= 1
    End Sub

    Private Sub cboTipoImpuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoImpuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBase.Focus()
        End If
    End Sub

    Private Sub cboTipoImpuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoImpuesto.SelectedIndexChanged
        CargarIVenta()
    End Sub

    Public Sub Loggin_Usuario()
        Try
            If BindingContext(Me.DataSetInventario.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSetInventario.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Id_Usuario"), Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar prestamos..", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If
                    logeado = True
                    txtNombreUsuario.Text = Usua("Nombre")
                    Cedula_usuario = Usua("Id_Usuario")

                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                    'ToolBar1.Buttons(0).Text = "Cancelar"
                    'ToolBar1.Buttons(0).ImageIndex = 8
                    'ToolBar1.Buttons(3).Enabled = PMU.Delete
                    ToolBar1.Buttons(0).Enabled = True
                    ToolBar1.Buttons(1).Enabled = True
                    ToolBar1.Buttons(5).Enabled = True
                    ToolBar1.Buttons(2).Enabled = True

                    perfil_administrador = PMU.Others

                    Me.contenedor.Enabled = True
                    Me.txtCod_Articulo.Focus()
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

    Private Function NumeroRandom() As String
        Dim Generator As System.Random = New System.Random()
        Return CStr(Generator.Next(0, 999999).ToString).PadLeft(6, "0")
    End Function

    Private Function GenerarCodigoBarras() As String
        Dim Codigo As String = ""
        Dim hora, minuto, segundo, Ramdom As String
        hora = Date.Now.Hour.ToString.PadLeft(2, "0")
        minuto = Date.Now.Minute.ToString.PadLeft(2, "0")
        segundo = Date.Now.Second.ToString.PadLeft(2, "0")
        Codigo = "1" + hora + minuto + segundo + Me.NumeroRandom
        Return Codigo
    End Function

    Private Sub ckMAG_KeyDown(sender As Object, e As KeyEventArgs) Handles ckMAG.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtUtilidadR_A.Focus()
        End If
    End Sub

    Private Sub txtcosto_real_TextChanged(sender As Object, e As EventArgs) Handles txtcosto_real.TextChanged
        Me.TxtUtilidadR_A.Enabled = False
        Me.TxtUtilidadR_B.Enabled = False
        Me.TxtUtilidadR_C.Enabled = False
        Me.TxtUtilidadR_D.Enabled = False
        If IsNumeric(Me.txtcosto_real.Text) Then
            If CDec(Me.txtcosto_real.Text) > 0 Then
                Me.TxtUtilidadR_A.Enabled = True
                Me.TxtUtilidadR_B.Enabled = True
                Me.TxtUtilidadR_C.Enabled = True
                Me.TxtUtilidadR_D.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnDuplicar_Click(sender As Object, e As EventArgs) Handles btnDuplicar.Click
        If Me.TxtCodigo.Text <> "" Then
            If IsNumeric(Me.TxtCodigo.Text) Then
                If CDec(Me.TxtCodigo.Text) > 0 Then
                    If MsgBox("Desea duplicar el articulo.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.Yes Then
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.Ejecutar("exec spDuplicarCodigo " & Me.TxtCodigo.Text, CommandType.Text)
                        MsgBox("Listo", MsgBoxStyle.Information, "Operacion realizada satifactoriamente.")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub ckHabilitaFamilia_CheckedChanged(sender As Object, e As EventArgs) Handles ckHabilitaFamilia.CheckedChanged
        Me.ComboBoxFamilia.Enabled = Me.ckHabilitaFamilia.Checked
    End Sub

    Private Sub btnRelacionados_Click(sender As Object, e As EventArgs) Handles btnRelacionados.Click
        Try
            Dim frm As New frmDetalleArticulosRelacionados
            frm.Codigo = Me.TxtCodigo.Text
            frm.txtDescripcion.Text = Me.TxtDescripcion.Text
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If IsClinica() = True Then
            MsgBox("Tipo de precio para la pagina Web", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
End Class
