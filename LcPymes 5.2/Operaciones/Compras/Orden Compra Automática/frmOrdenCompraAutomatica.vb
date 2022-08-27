Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class frmOrdenCompraAutomatica
    Inherits System.Windows.Forms.Form

    Dim cod_pro As Integer = 0
    Dim Cod_Mod As Integer = 0
    Dim Valor_Compra_Ultima_Compra As Double = 0
    Dim Valor_Conversion As Double
    Dim dt As New DataTable
    Dim Cant_Pedir As Double = 0
    Dim Vendidos As Integer = 0
    Dim dtview As DataView
    Dim Nombre_Usuario As String
    Dim Cedula_Usuario As String
    Dim Generando As Boolean = False
    Dim pos_actual As Integer = 0
    Dim PMU As New PerfilModulo_Class
    Dim Usua As Object




#Region " Código generado por el Diseñador de Windows Forms "

    'Public Sub New()
    '    MyBase.New()
    '    'El Diseñador de Windows Forms requiere esta llamada.
    '    InitializeComponent()
    '    'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    'End Sub

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        AddHandler Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").PositionChanged, AddressOf Me.Position_Changed
        Usua = Usuario_Parametro
        PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo 

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
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label_Tipo_Cambio As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtOtros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtFletes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Tex_Porc_Imp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_Descri_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodigo_art As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPorcDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEntrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDias_Entrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtImpuestoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre_Proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daordencompra As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtSubExentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtSubGravadoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSExcento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtSGravado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtmontodescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMontoImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSubtotalT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents OpContado As System.Windows.Forms.RadioButton
    Friend WithEvents OpCredito As System.Windows.Forms.RadioButton
    Friend WithEvents Txt_cedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daOrdenCompras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsOrdenAutomatica As DsOrdenAutomatica
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daDetalleOrdenCompra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtPrecioUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Option_Proveedor As System.Windows.Forms.RadioButton
    Friend WithEvents Option_Ubicacion As System.Windows.Forms.RadioButton
    Friend WithEvents Option_Sububicacion As System.Windows.Forms.RadioButton
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Fecha_Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Fecha_Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCompra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colimpuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGravado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExist_Actual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Adapter_Ubicaciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Ubicacion_Sububicacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Boton_Generar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Combo_Ubicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Seleccione As System.Windows.Forms.Label
    Friend WithEvents ComboBo_Ubica_Sububica As System.Windows.Forms.ComboBox
    Friend WithEvents Label_cod_ubicacion As System.Windows.Forms.Label
    Friend WithEvents Label_Codigo_Sububicacion As System.Windows.Forms.Label
    Friend WithEvents Panel_Opciones As System.Windows.Forms.Panel
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel_Ordenes_Imprimir As System.Windows.Forms.Panel
    Friend WithEvents Boton_Imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarControl2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Text_Orden As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents ItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents daProveedores As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LookUpEdit_Proveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOrdenCompraAutomatica))
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.DsOrdenAutomatica = New DsOrdenAutomatica
        Me.Txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label_Tipo_Cambio = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LookUpEdit_Proveedor = New DevExpress.XtraEditors.LookUpEdit
        Me.Label33 = New System.Windows.Forms.Label
        Me.TxtCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtOtros = New DevExpress.XtraEditors.TextEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtFletes = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.Tex_Porc_Imp = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_Descri_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.TxtCodigo_art = New DevExpress.XtraEditors.TextEdit
        Me.TxtPorcDesc = New DevExpress.XtraEditors.TextEdit
        Me.TxtCant = New DevExpress.XtraEditors.TextEdit
        Me.TxtPrecioUnit = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtEntrega = New DevExpress.XtraEditors.TextEdit
        Me.TxtDias_Entrega = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtImpuestoT = New DevExpress.XtraEditors.TextEdit
        Me.TxtDescuentoT = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtNombre_Proveedor = New DevExpress.XtraEditors.TextEdit
        Me.TxtCodigo = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.TxtMonto = New DevExpress.XtraEditors.TextEdit
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daordencompra = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtSubExentoT = New DevExpress.XtraEditors.TextEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.TxtSubGravadoT = New DevExpress.XtraEditors.TextEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSExcento = New DevExpress.XtraEditors.TextEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtSGravado = New DevExpress.XtraEditors.TextEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtmontodescuento = New DevExpress.XtraEditors.TextEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMontoImpuesto = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSubtotalT = New DevExpress.XtraEditors.TextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCosto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGravado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colimpuesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalCompra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVendidos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExist_Actual = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDias = New DevExpress.XtraEditors.TextEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.OpContado = New System.Windows.Forms.RadioButton
        Me.OpCredito = New System.Windows.Forms.RadioButton
        Me.Txt_cedulaUsuario = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daUsuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daOrdenCompras = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daDetalleOrdenCompra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Option_Ubicacion = New System.Windows.Forms.RadioButton
        Me.Option_Proveedor = New System.Windows.Forms.RadioButton
        Me.Option_Sububicacion = New System.Windows.Forms.RadioButton
        Me.Fecha_Desde = New DevExpress.XtraEditors.DateEdit
        Me.Fecha_Hasta = New DevExpress.XtraEditors.DateEdit
        Me.Panel_Opciones = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label_Codigo_Sububicacion = New System.Windows.Forms.Label
        Me.Label_cod_ubicacion = New System.Windows.Forms.Label
        Me.ComboBo_Ubica_Sububica = New System.Windows.Forms.ComboBox
        Me.Label_Seleccione = New System.Windows.Forms.Label
        Me.Boton_Generar = New DevExpress.XtraEditors.SimpleButton
        Me.Combo_Ubicacion = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.Adapter_Ubicaciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Ubicacion_Sububicacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.Panel_Ordenes_Imprimir = New System.Windows.Forms.Panel
        Me.ProgressBarControl2 = New DevExpress.XtraEditors.ProgressBarControl
        Me.Label35 = New System.Windows.Forms.Label
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.Boton_Imprimir = New DevExpress.XtraEditors.SimpleButton
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.Text_Orden = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.daProveedores = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        CType(Me.DsOrdenAutomatica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LookUpEdit_Proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOtros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFletes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tex_Porc_Imp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPorcDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TxtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDias_Entrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImpuestoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtNombre_Proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubExentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubGravadoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSExcento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSGravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmontodescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoImpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Opciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Ordenes_Imprimir.SuspendLayout()
        CType(Me.ProgressBarControl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsOrdenAutomatica, "ordencompra.NombreUsuario"))
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(424, 463)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(144, 13)
        Me.txtNombreUsuario.TabIndex = 50
        Me.txtNombreUsuario.Text = ""
        '
        'DsOrdenAutomatica
        '
        Me.DsOrdenAutomatica.DataSetName = "dsOrdenAutomatica"
        Me.DsOrdenAutomatica.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Txtobservaciones
        '
        Me.Txtobservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtobservaciones.Enabled = False
        Me.Txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobservaciones.ForeColor = System.Drawing.Color.Blue
        Me.Txtobservaciones.Location = New System.Drawing.Point(116, 350)
        Me.Txtobservaciones.Name = "Txtobservaciones"
        Me.Txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtobservaciones.Size = New System.Drawing.Size(592, 13)
        Me.Txtobservaciones.TabIndex = 8
        Me.Txtobservaciones.Text = ""
        '
        'Label_Tipo_Cambio
        '
        Me.Label_Tipo_Cambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Tipo_Cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsOrdenAutomatica, "Moneda.ValorCompra"))
        Me.Label_Tipo_Cambio.Location = New System.Drawing.Point(608, 101)
        Me.Label_Tipo_Cambio.Name = "Label_Tipo_Cambio"
        Me.Label_Tipo_Cambio.Size = New System.Drawing.Size(104, 14)
        Me.Label_Tipo_Cambio.TabIndex = 50
        Me.Label_Tipo_Cambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsOrdenAutomatica, "ordencompra.Cod_Moneda"))
        Me.ComboBox1.DataSource = Me.DsOrdenAutomatica
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(477, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(477, 85)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(127, 14)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Location = New System.Drawing.Point(304, 463)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(56, 13)
        Me.Label48.TabIndex = 50
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(57, Byte), CType(93, Byte), CType(173, Byte))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(-6, -4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(726, 32)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Orden de Compra  Automática"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LookUpEdit_Proveedor)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.TxtCosto)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TxtOtros)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TxtFletes)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Tex_Porc_Imp)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Txt_Descri_Articulo)
        Me.GroupBox3.Controls.Add(Me.TxtCodigo_art)
        Me.GroupBox3.Controls.Add(Me.TxtPorcDesc)
        Me.GroupBox3.Controls.Add(Me.TxtCant)
        Me.GroupBox3.Controls.Add(Me.TxtPrecioUnit)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(2, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 96)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Articulo"
        '
        'LookUpEdit_Proveedor
        '
        Me.LookUpEdit_Proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LookUpEdit_Proveedor.Location = New System.Drawing.Point(592, 72)
        Me.LookUpEdit_Proveedor.Name = "LookUpEdit_Proveedor"
        '
        'LookUpEdit_Proveedor.Properties
        '
        Me.LookUpEdit_Proveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Proveedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoProv", "Código", 100, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre del Proveedor", 400, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit_Proveedor.Properties.DataSource = Me.DsOrdenAutomatica.Proveedores
        Me.LookUpEdit_Proveedor.Properties.DisplayMember = "CodigoProv"
        Me.LookUpEdit_Proveedor.Properties.NullString = "0"
        Me.LookUpEdit_Proveedor.Properties.PopupCellStyle = New DevExpress.Utils.ViewStyle("PopupCell", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.LookUpEdit_Proveedor.Properties.PopupWidth = 500
        Me.LookUpEdit_Proveedor.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.LookUpEdit_Proveedor.Properties.ValueMember = "CodigoProv"
        Me.LookUpEdit_Proveedor.Size = New System.Drawing.Size(112, 19)
        Me.LookUpEdit_Proveedor.TabIndex = 57
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label33.Location = New System.Drawing.Point(592, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 14)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "Cambiar Proveedor"
        '
        'TxtCosto
        '
        Me.TxtCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Costo"))
        Me.TxtCosto.EditValue = "0.00"
        Me.TxtCosto.Location = New System.Drawing.Point(240, 72)
        Me.TxtCosto.Name = "TxtCosto"
        '
        'TxtCosto.Properties
        '
        Me.TxtCosto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCosto.Size = New System.Drawing.Size(72, 17)
        Me.TxtCosto.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.Location = New System.Drawing.Point(240, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 14)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Costo"
        '
        'TxtOtros
        '
        Me.TxtOtros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOtros.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.OtrosCargos"))
        Me.TxtOtros.EditValue = "0.00"
        Me.TxtOtros.Location = New System.Drawing.Point(174, 72)
        Me.TxtOtros.Name = "TxtOtros"
        '
        'TxtOtros.Properties
        '
        Me.TxtOtros.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtOtros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtOtros.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtOtros.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtOtros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtOtros.Size = New System.Drawing.Size(64, 17)
        Me.TxtOtros.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(174, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 14)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Otros"
        '
        'TxtFletes
        '
        Me.TxtFletes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFletes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Monto_Flete"))
        Me.TxtFletes.EditValue = "0.00"
        Me.TxtFletes.Location = New System.Drawing.Point(104, 72)
        Me.TxtFletes.Name = "TxtFletes"
        '
        'TxtFletes.Properties
        '
        Me.TxtFletes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtFletes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFletes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFletes.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtFletes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtFletes.Size = New System.Drawing.Size(64, 17)
        Me.TxtFletes.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Location = New System.Drawing.Point(104, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 14)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Fletes"
        '
        'Tex_Porc_Imp
        '
        Me.Tex_Porc_Imp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tex_Porc_Imp.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Porc_Impuesto"))
        Me.Tex_Porc_Imp.EditValue = "0.00"
        Me.Tex_Porc_Imp.Location = New System.Drawing.Point(367, 72)
        Me.Tex_Porc_Imp.Name = "Tex_Porc_Imp"
        '
        'Tex_Porc_Imp.Properties
        '
        Me.Tex_Porc_Imp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Tex_Porc_Imp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tex_Porc_Imp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tex_Porc_Imp.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.Tex_Porc_Imp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tex_Porc_Imp.Size = New System.Drawing.Size(45, 17)
        Me.Tex_Porc_Imp.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(367, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "% Imp."
        '
        'Txt_Descri_Articulo
        '
        Me.Txt_Descri_Articulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Descri_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Descripcion"))
        Me.Txt_Descri_Articulo.EditValue = ""
        Me.Txt_Descri_Articulo.Location = New System.Drawing.Point(104, 32)
        Me.Txt_Descri_Articulo.Name = "Txt_Descri_Articulo"
        '
        'Txt_Descri_Articulo.Properties
        '
        Me.Txt_Descri_Articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Txt_Descri_Articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descri_Articulo.Properties.ReadOnly = True
        Me.Txt_Descri_Articulo.Size = New System.Drawing.Size(600, 17)
        Me.Txt_Descri_Articulo.TabIndex = 13
        '
        'TxtCodigo_art
        '
        Me.TxtCodigo_art.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Codigo"))
        Me.TxtCodigo_art.EditValue = ""
        Me.TxtCodigo_art.Location = New System.Drawing.Point(8, 32)
        Me.TxtCodigo_art.Name = "TxtCodigo_art"
        '
        'TxtCodigo_art.Properties
        '
        Me.TxtCodigo_art.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtCodigo_art.Size = New System.Drawing.Size(88, 17)
        Me.TxtCodigo_art.TabIndex = 12
        '
        'TxtPorcDesc
        '
        Me.TxtPorcDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPorcDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Porc_Descuento"))
        Me.TxtPorcDesc.EditValue = "0.00"
        Me.TxtPorcDesc.Location = New System.Drawing.Point(315, 72)
        Me.TxtPorcDesc.Name = "TxtPorcDesc"
        '
        'TxtPorcDesc.Properties
        '
        Me.TxtPorcDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtPorcDesc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPorcDesc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPorcDesc.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPorcDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPorcDesc.Size = New System.Drawing.Size(48, 17)
        Me.TxtPorcDesc.TabIndex = 18
        '
        'TxtCant
        '
        Me.TxtCant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCant.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Cantidad"))
        Me.TxtCant.EditValue = "0.00"
        Me.TxtCant.Location = New System.Drawing.Point(417, 72)
        Me.TxtCant.Name = "TxtCant"
        '
        'TxtCant.Properties
        '
        Me.TxtCant.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtCant.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtCant.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCant.Size = New System.Drawing.Size(64, 17)
        Me.TxtCant.TabIndex = 20
        '
        'TxtPrecioUnit
        '
        Me.TxtPrecioUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrecioUnit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.CostoUnitario"))
        Me.TxtPrecioUnit.EditValue = "0.00"
        Me.TxtPrecioUnit.Location = New System.Drawing.Point(8, 70)
        Me.TxtPrecioUnit.Name = "TxtPrecioUnit"
        '
        'TxtPrecioUnit.Properties
        '
        Me.TxtPrecioUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtPrecioUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUnit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrecioUnit.Size = New System.Drawing.Size(88, 17)
        Me.TxtPrecioUnit.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(104, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(600, 14)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Descripción"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(486, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 14)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Subtotal"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(315, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 14)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "% Desc"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(8, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 14)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Precio Unit"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(7, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 14)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Código"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(417, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Cantidad:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.TotalCompra"))
        Me.TxtTotal.EditValue = "0.00"
        Me.TxtTotal.Location = New System.Drawing.Point(486, 72)
        Me.TxtTotal.Name = "TxtTotal"
        '
        'TxtTotal.Properties
        '
        Me.TxtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTotal.Size = New System.Drawing.Size(97, 17)
        Me.TxtTotal.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TxtEntrega)
        Me.GroupBox4.Controls.Add(Me.TxtDias_Entrega)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox4.Location = New System.Drawing.Point(1, 82)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(471, 56)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones de Orden"
        '
        'TxtEntrega
        '
        Me.TxtEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEntrega.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.entregar"))
        Me.TxtEntrega.EditValue = ""
        Me.TxtEntrega.Location = New System.Drawing.Point(121, 32)
        Me.TxtEntrega.Name = "TxtEntrega"
        '
        'TxtEntrega.Properties
        '
        Me.TxtEntrega.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtEntrega.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrega.Size = New System.Drawing.Size(343, 17)
        Me.TxtEntrega.TabIndex = 7
        '
        'TxtDias_Entrega
        '
        Me.TxtDias_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.Plazo"))
        Me.TxtDias_Entrega.EditValue = ""
        Me.TxtDias_Entrega.Location = New System.Drawing.Point(8, 32)
        Me.TxtDias_Entrega.Name = "TxtDias_Entrega"
        '
        'TxtDias_Entrega.Properties
        '
        Me.TxtDias_Entrega.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtDias_Entrega.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDias_Entrega.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDias_Entrega.Properties.StyleBorder = New DevExpress.Utils.ViewStyle("ControlStyleBorder", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 7.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), False, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control)
        Me.TxtDias_Entrega.Size = New System.Drawing.Size(64, 17)
        Me.TxtDias_Entrega.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(121, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(343, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Entregar a:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = " Entrega "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(72, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "día(s)"
        '
        'TxtImpuestoT
        '
        Me.TxtImpuestoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtImpuestoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.Impuesto"))
        Me.TxtImpuestoT.EditValue = ""
        Me.TxtImpuestoT.Location = New System.Drawing.Point(509, 381)
        Me.TxtImpuestoT.Name = "TxtImpuestoT"
        '
        'TxtImpuestoT.Properties
        '
        Me.TxtImpuestoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtImpuestoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtImpuestoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtImpuestoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtImpuestoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtImpuestoT.Properties.ReadOnly = True
        Me.TxtImpuestoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.TxtImpuestoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtImpuestoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtImpuestoT.TabIndex = 55
        '
        'TxtDescuentoT
        '
        Me.TxtDescuentoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.Descuento"))
        Me.TxtDescuentoT.EditValue = ""
        Me.TxtDescuentoT.Location = New System.Drawing.Point(405, 381)
        Me.TxtDescuentoT.Name = "TxtDescuentoT"
        '
        'TxtDescuentoT.Properties
        '
        Me.TxtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDescuentoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtDescuentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDescuentoT.Properties.ReadOnly = True
        Me.TxtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.TxtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDescuentoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtDescuentoT.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtNombre_Proveedor)
        Me.GroupBox2.Controls.Add(Me.TxtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(2, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 56)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Proveedor"
        '
        'TxtNombre_Proveedor
        '
        Me.TxtNombre_Proveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre_Proveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.Nombre"))
        Me.TxtNombre_Proveedor.EditValue = ""
        Me.TxtNombre_Proveedor.Location = New System.Drawing.Point(112, 32)
        Me.TxtNombre_Proveedor.Name = "TxtNombre_Proveedor"
        '
        'TxtNombre_Proveedor.Properties
        '
        Me.TxtNombre_Proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtNombre_Proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre_Proveedor.Size = New System.Drawing.Size(352, 17)
        Me.TxtNombre_Proveedor.TabIndex = 2
        '
        'TxtCodigo
        '
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.Proveedor"))
        Me.TxtCodigo.EditValue = "0"
        Me.TxtCodigo.Location = New System.Drawing.Point(7, 32)
        Me.TxtCodigo.Name = "TxtCodigo"
        '
        'TxtCodigo.Properties
        '
        Me.TxtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtCodigo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCodigo.Size = New System.Drawing.Size(96, 17)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(112, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nombre Proveedor"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(7, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Código"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.BackColor = System.Drawing.Color.LightGray
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 404)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(714, 52)
        Me.ToolBar1.TabIndex = 50
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'TxtMonto
        '
        Me.TxtMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.Total"))
        Me.TxtMonto.EditValue = ""
        Me.TxtMonto.Location = New System.Drawing.Point(613, 381)
        Me.TxtMonto.Name = "TxtMonto"
        '
        'TxtMonto.Properties
        '
        Me.TxtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtMonto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Properties.ReadOnly = True
        Me.TxtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.TxtMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtMonto.Size = New System.Drawing.Size(96, 19)
        Me.TxtMonto.TabIndex = 55
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Orden, Proveedor, Nombre, Fecha, contado, credito, diascredito, Plazo, Des" & _
        "cuento, Impuesto, Total, Observaciones, Usuario, NombreUsuario, entregar, Cod_Mo" & _
        "neda, SubTotalGravado, SubTotalExento, SubTotal FROM ordencompra"
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE ordencompra SET Proveedor = @Proveedor, Nombre = @Nombre, Fecha = @Fecha, " & _
        "contado = @contado, credito = @credito, diascredito = @diascredito, Plazo = @Pla" & _
        "zo, Descuento = @Descuento, Impuesto = @Impuesto, Total = @Total, Observaciones " & _
        "= @Observaciones, Usuario = @Usuario, NombreUsuario = @NombreUsuario, entregar =" & _
        " @entregar, Cod_Moneda = @Cod_Moneda, SubTotalGravado = @SubTotalGravado, SubTot" & _
        "alExento = @SubTotalExento, SubTotal = @SubTotal WHERE (Orden = @Original_Orden)" & _
        " AND (Cod_Moneda = @Original_Cod_Moneda) AND (Descuento = @Original_Descuento) A" & _
        "ND (Fecha = @Original_Fecha) AND (Impuesto = @Original_Impuesto) AND (Nombre = @" & _
        "Original_Nombre) AND (NombreUsuario = @Original_NombreUsuario) AND (Observacione" & _
        "s = @Original_Observaciones) AND (Plazo = @Original_Plazo) AND (Proveedor = @Ori" & _
        "ginal_Proveedor) AND (SubTotal = @Original_SubTotal) AND (SubTotalExento = @Orig" & _
        "inal_SubTotalExento) AND (SubTotalGravado = @Original_SubTotalGravado) AND (Tota" & _
        "l = @Original_Total) AND (Usuario = @Original_Usuario) AND (contado = @Original_" & _
        "contado) AND (credito = @Original_credito) AND (diascredito = @Original_diascred" & _
        "ito) AND (entregar = @Original_entregar); SELECT Orden, Proveedor, Nombre, Fecha" & _
        ", contado, credito, diascredito, Plazo, Descuento, Impuesto, Total, Observacione" & _
        "s, Usuario, NombreUsuario, entregar, Cod_Moneda, SubTotalGravado, SubTotalExento" & _
        ", SubTotal FROM ordencompra WHERE (Orden = @Orden)"
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO ordencompra(Proveedor, Nombre, Fecha, contado, credito, diascredito, " & _
        "Plazo, Descuento, Impuesto, Total, Observaciones, Usuario, NombreUsuario, entreg" & _
        "ar, Cod_Moneda, SubTotalGravado, SubTotalExento, SubTotal) VALUES (@Proveedor, @" & _
        "Nombre, @Fecha, @contado, @credito, @diascredito, @Plazo, @Descuento, @Impuesto," & _
        " @Total, @Observaciones, @Usuario, @NombreUsuario, @entregar, @Cod_Moneda, @SubT" & _
        "otalGravado, @SubTotalExento, @SubTotal); SELECT Orden, Proveedor, Nombre, Fecha" & _
        ", contado, credito, diascredito, Plazo, Descuento, Impuesto, Total, Observacione" & _
        "s, Usuario, NombreUsuario, entregar, Cod_Moneda, SubTotalGravado, SubTotalExento" & _
        ", SubTotal FROM ordencompra WHERE (Orden = @@IDENTITY)"
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, Perfil FROM Usuarios"
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM ordencompra WHERE (Orden = @Original_Orden) AND (Cod_Moneda = @Origin" & _
        "al_Cod_Moneda) AND (Descuento = @Original_Descuento) AND (Fecha = @Original_Fech" & _
        "a) AND (Impuesto = @Original_Impuesto) AND (Nombre = @Original_Nombre) AND (Nomb" & _
        "reUsuario = @Original_NombreUsuario) AND (Observaciones = @Original_Observacione" & _
        "s) AND (Plazo = @Original_Plazo) AND (Proveedor = @Original_Proveedor) AND (SubT" & _
        "otal = @Original_SubTotal) AND (SubTotalExento = @Original_SubTotalExento) AND (" & _
        "SubTotalGravado = @Original_SubTotalGravado) AND (Total = @Original_Total) AND (" & _
        "Usuario = @Original_Usuario) AND (contado = @Original_contado) AND (credito = @O" & _
        "riginal_credito) AND (diascredito = @Original_diascredito) AND (entregar = @Orig" & _
        "inal_entregar)"
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM detalle_ordencompra WHERE (Id = @Original_Id) AND (Cantidad = @Origin" & _
        "al_Cantidad) AND (Codigo = @Original_Codigo) AND (Costo = @Original_Costo) AND (" & _
        "CostoUnitario = @Original_CostoUnitario) AND (Descripcion = @Original_Descripcio" & _
        "n) AND (Descuento = @Original_Descuento) AND (Exento = @Original_Exento) AND (Gr" & _
        "avado = @Original_Gravado) AND (Monto_Flete = @Original_Monto_Flete) AND (Orden " & _
        "= @Original_Orden) AND (OtrosCargos = @Original_OtrosCargos) AND (Porc_Descuento" & _
        " = @Original_Porc_Descuento) AND (Porc_Impuesto = @Original_Porc_Impuesto) AND (" & _
        "TotalCompra = @Original_TotalCompra) AND (impuesto = @Original_impuesto)"
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        '
        'daordencompra
        '
        Me.daordencompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.daordencompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.daordencompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daordencompra.ForeColor = System.Drawing.Color.RoyalBlue
        Me.daordencompra.Location = New System.Drawing.Point(613, 367)
        Me.daordencompra.Name = "daordencompra"
        Me.daordencompra.Size = New System.Drawing.Size(96, 13)
        Me.daordencompra.TabIndex = 50
        Me.daordencompra.Text = "Total"
        Me.daordencompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Location = New System.Drawing.Point(509, 367)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Impuesto"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE detalle_ordencompra SET Orden = @Orden, Codigo = @Codigo, Descripcion = @D" & _
        "escripcion, CostoUnitario = @CostoUnitario, Cantidad = @Cantidad, impuesto = @im" & _
        "puesto, TotalCompra = @TotalCompra, Descuento = @Descuento, Porc_Descuento = @Po" & _
        "rc_Descuento, Porc_Impuesto = @Porc_Impuesto, OtrosCargos = @OtrosCargos, Monto_" & _
        "Flete = @Monto_Flete, Costo = @Costo, Gravado = @Gravado, Exento = @Exento WHERE" & _
        " (Id = @Original_Id) AND (Cantidad = @Original_Cantidad) AND (Codigo = @Original" & _
        "_Codigo) AND (Costo = @Original_Costo) AND (CostoUnitario = @Original_CostoUnita" & _
        "rio) AND (Descripcion = @Original_Descripcion) AND (Descuento = @Original_Descue" & _
        "nto) AND (Exento = @Original_Exento) AND (Gravado = @Original_Gravado) AND (Mont" & _
        "o_Flete = @Original_Monto_Flete) AND (Orden = @Original_Orden) AND (OtrosCargos " & _
        "= @Original_OtrosCargos) AND (Porc_Descuento = @Original_Porc_Descuento) AND (Po" & _
        "rc_Impuesto = @Original_Porc_Impuesto) AND (TotalCompra = @Original_TotalCompra)" & _
        " AND (impuesto = @Original_impuesto); SELECT Id, Orden, Codigo, Descripcion, Cos" & _
        "toUnitario, Cantidad, impuesto, TotalCompra, Descuento, Porc_Descuento, Porc_Imp" & _
        "uesto, OtrosCargos, Monto_Flete, Costo, Gravado, Exento FROM detalle_ordencompra" & _
        " WHERE (Id = @Id)"
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO detalle_ordencompra(Orden, Codigo, Descripcion, CostoUnitario, Cantid" & _
        "ad, impuesto, TotalCompra, Descuento, Porc_Descuento, Porc_Impuesto, OtrosCargos" & _
        ", Monto_Flete, Costo, Gravado, Exento) VALUES (@Orden, @Codigo, @Descripcion, @C" & _
        "ostoUnitario, @Cantidad, @impuesto, @TotalCompra, @Descuento, @Porc_Descuento, @" & _
        "Porc_Impuesto, @OtrosCargos, @Monto_Flete, @Costo, @Gravado, @Exento); SELECT Id" & _
        ", Orden, Codigo, Descripcion, CostoUnitario, Cantidad, impuesto, TotalCompra, De" & _
        "scuento, Porc_Descuento, Porc_Impuesto, OtrosCargos, Monto_Flete, Costo, Gravado" & _
        ", Exento FROM detalle_ordencompra WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id, Orden, Codigo, Descripcion, CostoUnitario, Cantidad, impuesto, TotalCo" & _
        "mpra, Descuento, Porc_Descuento, Porc_Impuesto, OtrosCargos, Monto_Flete, Costo," & _
        " Gravado, Exento FROM detalle_ordencompra"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.Location = New System.Drawing.Point(301, 367)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 13)
        Me.Label29.TabIndex = 50
        Me.Label29.Text = "Subtotal"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSubExentoT
        '
        Me.TxtSubExentoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubExentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.SubTotalExento"))
        Me.TxtSubExentoT.EditValue = ""
        Me.TxtSubExentoT.Location = New System.Drawing.Point(197, 381)
        Me.TxtSubExentoT.Name = "TxtSubExentoT"
        '
        'TxtSubExentoT.Properties
        '
        Me.TxtSubExentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubExentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubExentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubExentoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubExentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubExentoT.Properties.ReadOnly = True
        Me.TxtSubExentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.TxtSubExentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSubExentoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtSubExentoT.TabIndex = 55
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.Location = New System.Drawing.Point(197, 367)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 13)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "Sub. Exento"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSubGravadoT
        '
        Me.TxtSubGravadoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubGravadoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.SubTotalGravado"))
        Me.TxtSubGravadoT.EditValue = ""
        Me.TxtSubGravadoT.Location = New System.Drawing.Point(93, 381)
        Me.TxtSubGravadoT.Name = "TxtSubGravadoT"
        '
        'TxtSubGravadoT.Properties
        '
        Me.TxtSubGravadoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubGravadoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubGravadoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubGravadoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubGravadoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubGravadoT.Properties.ReadOnly = True
        Me.TxtSubGravadoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.TxtSubGravadoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSubGravadoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtSubGravadoT.TabIndex = 55
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Location = New System.Drawing.Point(112, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 16)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Sub. Exento"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(93, 367)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Sub. Gravado"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSExcento
        '
        Me.txtSExcento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Exento"))
        Me.txtSExcento.EditValue = ""
        Me.txtSExcento.Location = New System.Drawing.Point(112, 56)
        Me.txtSExcento.Name = "txtSExcento"
        '
        'txtSExcento.Properties
        '
        Me.txtSExcento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSExcento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSExcento.Size = New System.Drawing.Size(104, 19)
        Me.txtSExcento.TabIndex = 50
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(0, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Sub Gravado"
        '
        'txtSGravado
        '
        Me.txtSGravado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Gravado"))
        Me.txtSGravado.EditValue = ""
        Me.txtSGravado.Location = New System.Drawing.Point(0, 56)
        Me.txtSGravado.Name = "txtSGravado"
        '
        'txtSGravado.Properties
        '
        Me.txtSGravado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSGravado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSGravado.Size = New System.Drawing.Size(104, 19)
        Me.txtSGravado.TabIndex = 50
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(112, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 16)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Monto descuento"
        '
        'txtmontodescuento
        '
        Me.txtmontodescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.Descuento"))
        Me.txtmontodescuento.EditValue = ""
        Me.txtmontodescuento.Location = New System.Drawing.Point(112, 16)
        Me.txtmontodescuento.Name = "txtmontodescuento"
        '
        'txtmontodescuento.Properties
        '
        Me.txtmontodescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmontodescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmontodescuento.Size = New System.Drawing.Size(120, 19)
        Me.txtmontodescuento.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Location = New System.Drawing.Point(8, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 16)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Monto impuesto"
        '
        'txtMontoImpuesto
        '
        Me.txtMontoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra.impuesto"))
        Me.txtMontoImpuesto.EditValue = ""
        Me.txtMontoImpuesto.Location = New System.Drawing.Point(-15, -3)
        Me.txtMontoImpuesto.Name = "txtMontoImpuesto"
        '
        'txtMontoImpuesto.Properties
        '
        Me.txtMontoImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoImpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoImpuesto.Size = New System.Drawing.Size(104, 19)
        Me.txtMontoImpuesto.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(608, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 14)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Tipo Cambio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(0, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 12)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Orden #"
        '
        'TxtSubtotalT
        '
        Me.TxtSubtotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubtotalT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.SubTotal"))
        Me.TxtSubtotalT.EditValue = ""
        Me.TxtSubtotalT.Location = New System.Drawing.Point(301, 381)
        Me.TxtSubtotalT.Name = "TxtSubtotalT"
        '
        'TxtSubtotalT.Properties
        '
        Me.TxtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubtotalT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubtotalT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubtotalT.Properties.ReadOnly = True
        Me.TxtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.TxtSubtotalT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSubtotalT.Size = New System.Drawing.Size(96, 19)
        Me.TxtSubtotalT.TabIndex = 55
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colCosto, Me.colGravado, Me.colExento, Me.colDescuento, Me.colimpuesto, Me.colTotalCompra, Me.colVendidos, Me.colExist_Actual})
        Me.GridView1.GroupPanelText = ""
        Me.GridView1.HorzScrollStep = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 67
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 296
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 76
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo"
        Me.colCosto.DisplayFormat.FormatString = "#,#0.00"
        Me.colCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCosto.FieldName = "Costo"
        Me.colCosto.Name = "colCosto"
        Me.colCosto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCosto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCosto.VisibleIndex = 6
        Me.colCosto.Width = 61
        '
        'colGravado
        '
        Me.colGravado.Caption = "Gravado"
        Me.colGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGravado.FieldName = "Gravado"
        Me.colGravado.Name = "colGravado"
        Me.colGravado.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colGravado.VisibleIndex = 7
        Me.colGravado.Width = 74
        '
        'colExento
        '
        Me.colExento.Caption = "Exento"
        Me.colExento.DisplayFormat.FormatString = "#,#0.00"
        Me.colExento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExento.FieldName = "Exento"
        Me.colExento.Name = "colExento"
        Me.colExento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colExento.VisibleIndex = 8
        Me.colExento.Width = 66
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Descuento"
        Me.colDescuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDescuento.VisibleIndex = 4
        Me.colDescuento.Width = 85
        '
        'colimpuesto
        '
        Me.colimpuesto.Caption = "impuesto"
        Me.colimpuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colimpuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colimpuesto.FieldName = "impuesto"
        Me.colimpuesto.Name = "colimpuesto"
        Me.colimpuesto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colimpuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colimpuesto.VisibleIndex = 5
        Me.colimpuesto.Width = 77
        '
        'colTotalCompra
        '
        Me.colTotalCompra.Caption = "TotalCompra"
        Me.colTotalCompra.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotalCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCompra.FieldName = "TotalCompra"
        Me.colTotalCompra.Name = "colTotalCompra"
        Me.colTotalCompra.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotalCompra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalCompra.VisibleIndex = 3
        Me.colTotalCompra.Width = 96
        '
        'colVendidos
        '
        Me.colVendidos.Caption = "Vendidos"
        Me.colVendidos.DisplayFormat.FormatString = "#,#0.00"
        Me.colVendidos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVendidos.FieldName = "Vendidos"
        Me.colVendidos.Name = "colVendidos"
        Me.colVendidos.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colVendidos.VisibleIndex = 9
        Me.colVendidos.Width = 78
        '
        'colExist_Actual
        '
        Me.colExist_Actual.Caption = "Exist. Actual"
        Me.colExist_Actual.DisplayFormat.FormatString = "#,#0.00"
        Me.colExist_Actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExist_Actual.FieldName = "Exist_Actual"
        Me.colExist_Actual.Name = "colExist_Actual"
        Me.colExist_Actual.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExist_Actual.VisibleIndex = 10
        Me.colExist_Actual.Width = 92
        '
        'ItemComboBox
        '
        Me.ItemComboBox.AutoHeight = False
        Me.ItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemComboBox.Name = "ItemComboBox"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "ordencompra.ordencompradetalle_ordencompra"
        Me.GridControl1.DataSource = Me.DsOrdenAutomatica
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Enabled = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 236)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemComboBox})
        Me.GridControl1.Size = New System.Drawing.Size(712, 108)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 50
        Me.GridControl1.Text = "GridControl1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtDias)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.OpContado)
        Me.GroupBox1.Controls.Add(Me.OpCredito)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(472, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 53)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pago"
        '
        'TxtDias
        '
        Me.TxtDias.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsOrdenAutomatica, "ordencompra.diascredito"))
        Me.TxtDias.EditValue = ""
        Me.TxtDias.Location = New System.Drawing.Point(117, 29)
        Me.TxtDias.Name = "TxtDias"
        '
        'TxtDias.Properties
        '
        Me.TxtDias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtDias.Size = New System.Drawing.Size(32, 17)
        Me.TxtDias.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.Location = New System.Drawing.Point(156, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 14)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "día(s)"
        '
        'OpContado
        '
        Me.OpContado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsOrdenAutomatica, "ordencompra.contado"))
        Me.OpContado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OpContado.Location = New System.Drawing.Point(30, 16)
        Me.OpContado.Name = "OpContado"
        Me.OpContado.Size = New System.Drawing.Size(80, 16)
        Me.OpContado.TabIndex = 3
        Me.OpContado.Text = "Contado"
        '
        'OpCredito
        '
        Me.OpCredito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsOrdenAutomatica, "ordencompra.credito"))
        Me.OpCredito.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OpCredito.Location = New System.Drawing.Point(30, 32)
        Me.OpCredito.Name = "OpCredito"
        Me.OpCredito.Size = New System.Drawing.Size(72, 16)
        Me.OpCredito.TabIndex = 4
        Me.OpCredito.Text = "Crédito"
        '
        'Txt_cedulaUsuario
        '
        Me.Txt_cedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_cedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsOrdenAutomatica, "ordencompra.Usuario"))
        Me.Txt_cedulaUsuario.Location = New System.Drawing.Point(16, 368)
        Me.Txt_cedulaUsuario.Name = "Txt_cedulaUsuario"
        Me.Txt_cedulaUsuario.Size = New System.Drawing.Size(0, 13)
        Me.Txt_cedulaUsuario.TabIndex = 238
        Me.Txt_cedulaUsuario.Text = ""
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(0, 350)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 16)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Observaciones"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Location = New System.Drawing.Point(405, 367)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Descuento"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;integrated security=SSPI;data source=""."";per" & _
        "sist security info=False;initial catalog=SeePOS"
        '
        'daUsuarios
        '
        Me.daUsuarios.SelectCommand = Me.SqlSelectCommand5
        Me.daUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, Perfil FROM Usuarios"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'daOrdenCompras
        '
        Me.daOrdenCompras.DeleteCommand = Me.SqlDeleteCommand3
        Me.daOrdenCompras.InsertCommand = Me.SqlInsertCommand3
        Me.daOrdenCompras.SelectCommand = Me.SqlSelectCommand6
        Me.daOrdenCompras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ordencompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Proveedor", "Proveedor"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("contado", "contado"), New System.Data.Common.DataColumnMapping("credito", "credito"), New System.Data.Common.DataColumnMapping("diascredito", "diascredito"), New System.Data.Common.DataColumnMapping("Plazo", "Plazo"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("entregar", "entregar"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal")})})
        Me.daOrdenCompras.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM ordencompra WHERE (Orden = @Original_Orden) AND (Cod_Moneda = @Origin" & _
        "al_Cod_Moneda) AND (Descuento = @Original_Descuento) AND (Fecha = @Original_Fech" & _
        "a) AND (Impuesto = @Original_Impuesto) AND (Nombre = @Original_Nombre) AND (Nomb" & _
        "reUsuario = @Original_NombreUsuario) AND (Observaciones = @Original_Observacione" & _
        "s) AND (Plazo = @Original_Plazo) AND (Proveedor = @Original_Proveedor) AND (SubT" & _
        "otal = @Original_SubTotal) AND (SubTotalExento = @Original_SubTotalExento) AND (" & _
        "SubTotalGravado = @Original_SubTotalGravado) AND (Total = @Original_Total) AND (" & _
        "Usuario = @Original_Usuario) AND (contado = @Original_contado) AND (credito = @O" & _
        "riginal_credito) AND (diascredito = @Original_diascredito) AND (entregar = @Orig" & _
        "inal_entregar)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO ordencompra (Proveedor, Nombre, Fecha, contado, credito, diascredito," & _
        " Plazo, Descuento, Impuesto, Total, Observaciones, Usuario, NombreUsuario, entre" & _
        "gar, Cod_Moneda, SubTotalGravado, SubTotalExento, SubTotal) VALUES (@Proveedor, " & _
        "@Nombre, @Fecha, @contado, @credito, @diascredito, @Plazo, @Descuento, @Impuesto" & _
        ", @Total, @Observaciones, @Usuario, @NombreUsuario, @entregar, @Cod_Moneda, @Sub" & _
        "TotalGravado, @SubTotalExento, @SubTotal); SELECT Orden, Proveedor, Nombre, Fech" & _
        "a, contado, credito, diascredito, Plazo, Descuento, Impuesto, Total, Observacion" & _
        "es, Usuario, NombreUsuario, entregar, Cod_Moneda, SubTotalGravado, SubTotalExent" & _
        "o, SubTotal FROM ordencompra WHERE (Orden = SCOPE_IDENTITY())"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Orden, Proveedor, Nombre, Fecha, contado, credito, diascredito, Plazo, Des" & _
        "cuento, Impuesto, Total, Observaciones, Usuario, NombreUsuario, entregar, Cod_Mo" & _
        "neda, SubTotalGravado, SubTotalExento, SubTotal FROM ordencompra"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE ordencompra SET Proveedor = @Proveedor, Nombre = @Nombre, Fecha = @Fecha, " & _
        "contado = @contado, credito = @credito, diascredito = @diascredito, Plazo = @Pla" & _
        "zo, Descuento = @Descuento, Impuesto = @Impuesto, Total = @Total, Observaciones " & _
        "= @Observaciones, Usuario = @Usuario, NombreUsuario = @NombreUsuario, entregar =" & _
        " @entregar, Cod_Moneda = @Cod_Moneda, SubTotalGravado = @SubTotalGravado, SubTot" & _
        "alExento = @SubTotalExento, SubTotal = @SubTotal WHERE (Orden = @Original_Orden)" & _
        "; SELECT Orden, Proveedor, Nombre, Fecha, contado, credito, diascredito, Plazo, " & _
        "Descuento, Impuesto, Total, Observaciones, Usuario, NombreUsuario, entregar, Cod" & _
        "_Moneda, SubTotalGravado, SubTotalExento, SubTotal FROM ordencompra WHERE (Orden" & _
        " = @Orden)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        '
        'daMoneda
        '
        Me.daMoneda.DeleteCommand = Me.SqlDeleteCommand5
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand5
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand7
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.daMoneda.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'daDetalleOrdenCompra
        '
        Me.daDetalleOrdenCompra.DeleteCommand = Me.SqlDeleteCommand6
        Me.daDetalleOrdenCompra.InsertCommand = Me.SqlInsertCommand6
        Me.daDetalleOrdenCompra.SelectCommand = Me.SqlSelectCommand8
        Me.daDetalleOrdenCompra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_ordencompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CostoUnitario", "CostoUnitario"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("TotalCompra", "TotalCompra"), New System.Data.Common.DataColumnMapping("Porc_Descuento", "Porc_Descuento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Porc_Impuesto", "Porc_Impuesto"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Monto_Flete", "Monto_Flete"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Gravado", "Gravado"), New System.Data.Common.DataColumnMapping("Exento", "Exento"), New System.Data.Common.DataColumnMapping("Vendidos", "Vendidos"), New System.Data.Common.DataColumnMapping("Exist_Actual", "Exist_Actual")})})
        Me.daDetalleOrdenCompra.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM detalle_ordencompra WHERE (Id = @Original_Id) AND (Cantidad = @Origin" & _
        "al_Cantidad) AND (Codigo = @Original_Codigo) AND (Costo = @Original_Costo) AND (" & _
        "CostoUnitario = @Original_CostoUnitario) AND (Descripcion = @Original_Descripcio" & _
        "n) AND (Descuento = @Original_Descuento) AND (Exento = @Original_Exento) AND (Ex" & _
        "ist_Actual = @Original_Exist_Actual) AND (Gravado = @Original_Gravado) AND (Mont" & _
        "o_Flete = @Original_Monto_Flete) AND (Orden = @Original_Orden) AND (OtrosCargos " & _
        "= @Original_OtrosCargos) AND (Porc_Descuento = @Original_Porc_Descuento) AND (Po" & _
        "rc_Impuesto = @Original_Porc_Impuesto) AND (TotalCompra = @Original_TotalCompra)" & _
        " AND (Vendidos = @Original_Vendidos) AND (impuesto = @Original_impuesto)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Actual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vendidos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendidos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO detalle_ordencompra (Orden, Codigo, Descripcion, CostoUnitario, Canti" & _
        "dad, TotalCompra, Porc_Descuento, Descuento, Porc_Impuesto, impuesto, OtrosCargo" & _
        "s, Monto_Flete, Costo, Gravado, Exento, Vendidos, Exist_Actual) VALUES (@Orden, " & _
        "@Codigo, @Descripcion, @CostoUnitario, @Cantidad, @TotalCompra, @Porc_Descuento," & _
        " @Descuento, @Porc_Impuesto, @impuesto, @OtrosCargos, @Monto_Flete, @Costo, @Gra" & _
        "vado, @Exento, @Vendidos, @Exist_Actual); SELECT Id, Orden, Codigo, Descripcion," & _
        " CostoUnitario, Cantidad, TotalCompra, Porc_Descuento, Descuento, Porc_Impuesto," & _
        " impuesto, OtrosCargos, Monto_Flete, Costo, Gravado, Exento, Vendidos, Exist_Act" & _
        "ual FROM detalle_ordencompra WHERE (Id = SCOPE_IDENTITY())"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vendidos", System.Data.SqlDbType.Float, 8, "Vendidos"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Actual", System.Data.SqlDbType.Float, 8, "Exist_Actual"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Id, Orden, Codigo, Descripcion, CostoUnitario, Cantidad, TotalCompra, Porc" & _
        "_Descuento, Descuento, Porc_Impuesto, impuesto, OtrosCargos, Monto_Flete, Costo," & _
        " Gravado, Exento, Vendidos, Exist_Actual FROM detalle_ordencompra"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE detalle_ordencompra SET Orden = @Orden, Codigo = @Codigo, Descripcion = @D" & _
        "escripcion, CostoUnitario = @CostoUnitario, Cantidad = @Cantidad, TotalCompra = " & _
        "@TotalCompra, Porc_Descuento = @Porc_Descuento, Descuento = @Descuento, Porc_Imp" & _
        "uesto = @Porc_Impuesto, impuesto = @impuesto, OtrosCargos = @OtrosCargos, Monto_" & _
        "Flete = @Monto_Flete, Costo = @Costo, Gravado = @Gravado, Exento = @Exento, Vend" & _
        "idos = @Vendidos, Exist_Actual = @Exist_Actual WHERE (Id = @Original_Id) AND (Ca" & _
        "ntidad = @Original_Cantidad) AND (Codigo = @Original_Codigo) AND (Costo = @Origi" & _
        "nal_Costo) AND (CostoUnitario = @Original_CostoUnitario) AND (Descripcion = @Ori" & _
        "ginal_Descripcion) AND (Descuento = @Original_Descuento) AND (Exento = @Original" & _
        "_Exento) AND (Exist_Actual = @Original_Exist_Actual) AND (Gravado = @Original_Gr" & _
        "avado) AND (Monto_Flete = @Original_Monto_Flete) AND (Orden = @Original_Orden) A" & _
        "ND (OtrosCargos = @Original_OtrosCargos) AND (Porc_Descuento = @Original_Porc_De" & _
        "scuento) AND (Porc_Impuesto = @Original_Porc_Impuesto) AND (TotalCompra = @Origi" & _
        "nal_TotalCompra) AND (Vendidos = @Original_Vendidos) AND (impuesto = @Original_i" & _
        "mpuesto); SELECT Id, Orden, Codigo, Descripcion, CostoUnitario, Cantidad, TotalC" & _
        "ompra, Porc_Descuento, Descuento, Porc_Impuesto, impuesto, OtrosCargos, Monto_Fl" & _
        "ete, Costo, Gravado, Exento, Vendidos, Exist_Actual FROM detalle_ordencompra WHE" & _
        "RE (Id = @Id)"
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vendidos", System.Data.SqlDbType.Float, 8, "Vendidos"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Actual", System.Data.SqlDbType.Float, 8, "Exist_Actual"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Actual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vendidos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendidos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Blue
        Me.txtClave.Location = New System.Drawing.Point(381, 461)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(36, 16)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(16, 384)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(0, 13)
        Me.txtUsuario.TabIndex = 215
        Me.txtUsuario.Text = ""
        '
        'Option_Ubicacion
        '
        Me.Option_Ubicacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Option_Ubicacion.Location = New System.Drawing.Point(5, 19)
        Me.Option_Ubicacion.Name = "Option_Ubicacion"
        Me.Option_Ubicacion.Size = New System.Drawing.Size(80, 16)
        Me.Option_Ubicacion.TabIndex = 1
        Me.Option_Ubicacion.Text = "&Ubicación"
        '
        'Option_Proveedor
        '
        Me.Option_Proveedor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Option_Proveedor.Location = New System.Drawing.Point(5, 3)
        Me.Option_Proveedor.Name = "Option_Proveedor"
        Me.Option_Proveedor.Size = New System.Drawing.Size(80, 16)
        Me.Option_Proveedor.TabIndex = 0
        Me.Option_Proveedor.Text = "&Proveedor"
        '
        'Option_Sububicacion
        '
        Me.Option_Sububicacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Option_Sububicacion.Location = New System.Drawing.Point(5, 35)
        Me.Option_Sububicacion.Name = "Option_Sububicacion"
        Me.Option_Sububicacion.Size = New System.Drawing.Size(96, 16)
        Me.Option_Sububicacion.TabIndex = 2
        Me.Option_Sububicacion.Text = "&SubUbicación"
        '
        'Fecha_Desde
        '
        Me.Fecha_Desde.EditValue = New Date(2006, 8, 22, 0, 0, 0, 0)
        Me.Fecha_Desde.Location = New System.Drawing.Point(215, 24)
        Me.Fecha_Desde.Name = "Fecha_Desde"
        '
        'Fecha_Desde.Properties
        '
        Me.Fecha_Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha_Desde.Size = New System.Drawing.Size(84, 19)
        Me.Fecha_Desde.TabIndex = 241
        '
        'Fecha_Hasta
        '
        Me.Fecha_Hasta.EditValue = New Date(2006, 8, 22, 0, 0, 0, 0)
        Me.Fecha_Hasta.Location = New System.Drawing.Point(214, 58)
        Me.Fecha_Hasta.Name = "Fecha_Hasta"
        '
        'Fecha_Hasta.Properties
        '
        Me.Fecha_Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha_Hasta.Size = New System.Drawing.Size(84, 19)
        Me.Fecha_Hasta.TabIndex = 242
        '
        'Panel_Opciones
        '
        Me.Panel_Opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Opciones.BackColor = System.Drawing.Color.LightBlue
        Me.Panel_Opciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Opciones.Controls.Add(Me.Panel1)
        Me.Panel_Opciones.Controls.Add(Me.Label34)
        Me.Panel_Opciones.Controls.Add(Me.Label_Codigo_Sububicacion)
        Me.Panel_Opciones.Controls.Add(Me.Label_cod_ubicacion)
        Me.Panel_Opciones.Controls.Add(Me.ComboBo_Ubica_Sububica)
        Me.Panel_Opciones.Controls.Add(Me.Label_Seleccione)
        Me.Panel_Opciones.Controls.Add(Me.Boton_Generar)
        Me.Panel_Opciones.Controls.Add(Me.Combo_Ubicacion)
        Me.Panel_Opciones.Controls.Add(Me.Label32)
        Me.Panel_Opciones.Controls.Add(Me.Label31)
        Me.Panel_Opciones.Controls.Add(Me.Fecha_Desde)
        Me.Panel_Opciones.Controls.Add(Me.Fecha_Hasta)
        Me.Panel_Opciones.Location = New System.Drawing.Point(160, 132)
        Me.Panel_Opciones.Name = "Panel_Opciones"
        Me.Panel_Opciones.Size = New System.Drawing.Size(400, 120)
        Me.Panel_Opciones.TabIndex = 243
        Me.Panel_Opciones.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Option_Ubicacion)
        Me.Panel1.Controls.Add(Me.Option_Proveedor)
        Me.Panel1.Controls.Add(Me.Option_Sububicacion)
        Me.Panel1.Location = New System.Drawing.Point(8, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 56)
        Me.Panel1.TabIndex = 251
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(400, 16)
        Me.Label34.TabIndex = 250
        Me.Label34.Text = "Generación de Orden"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_Codigo_Sububicacion
        '
        Me.Label_Codigo_Sububicacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsOrdenAutomatica, "SubUbicacion.Codigo"))
        Me.Label_Codigo_Sububicacion.Location = New System.Drawing.Point(400, 128)
        Me.Label_Codigo_Sububicacion.Name = "Label_Codigo_Sububicacion"
        Me.Label_Codigo_Sububicacion.Size = New System.Drawing.Size(40, 16)
        Me.Label_Codigo_Sububicacion.TabIndex = 249
        '
        'Label_cod_ubicacion
        '
        Me.Label_cod_ubicacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsOrdenAutomatica, "Ubicaciones.Codigo"))
        Me.Label_cod_ubicacion.Location = New System.Drawing.Point(400, 104)
        Me.Label_cod_ubicacion.Name = "Label_cod_ubicacion"
        Me.Label_cod_ubicacion.Size = New System.Drawing.Size(40, 16)
        Me.Label_cod_ubicacion.TabIndex = 248
        '
        'ComboBo_Ubica_Sububica
        '
        Me.ComboBo_Ubica_Sububica.DataSource = Me.DsOrdenAutomatica
        Me.ComboBo_Ubica_Sububica.DisplayMember = "SubUbicacion.Ubicaciones"
        Me.ComboBo_Ubica_Sububica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBo_Ubica_Sububica.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ComboBo_Ubica_Sububica.Location = New System.Drawing.Point(120, 88)
        Me.ComboBo_Ubica_Sububica.Name = "ComboBo_Ubica_Sububica"
        Me.ComboBo_Ubica_Sububica.Size = New System.Drawing.Size(272, 21)
        Me.ComboBo_Ubica_Sububica.TabIndex = 247
        Me.ComboBo_Ubica_Sububica.Visible = False
        '
        'Label_Seleccione
        '
        Me.Label_Seleccione.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label_Seleccione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Seleccione.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label_Seleccione.Location = New System.Drawing.Point(8, 88)
        Me.Label_Seleccione.Name = "Label_Seleccione"
        Me.Label_Seleccione.Size = New System.Drawing.Size(104, 21)
        Me.Label_Seleccione.TabIndex = 246
        Me.Label_Seleccione.Visible = False
        '
        'Boton_Generar
        '
        Me.Boton_Generar.Location = New System.Drawing.Point(312, 24)
        Me.Boton_Generar.Name = "Boton_Generar"
        Me.Boton_Generar.Size = New System.Drawing.Size(80, 56)
        Me.Boton_Generar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ActiveCaptionText)
        Me.Boton_Generar.TabIndex = 245
        Me.Boton_Generar.Text = "&Generar"
        '
        'Combo_Ubicacion
        '
        Me.Combo_Ubicacion.DataSource = Me.DsOrdenAutomatica
        Me.Combo_Ubicacion.DisplayMember = "Ubicaciones.Descripcion"
        Me.Combo_Ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Ubicacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Combo_Ubicacion.Location = New System.Drawing.Point(120, 88)
        Me.Combo_Ubicacion.Name = "Combo_Ubicacion"
        Me.Combo_Ubicacion.Size = New System.Drawing.Size(272, 21)
        Me.Combo_Ubicacion.TabIndex = 244
        Me.Combo_Ubicacion.Visible = False
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label32.Location = New System.Drawing.Point(122, 58)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 243
        Me.Label32.Text = "Hasta"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.Location = New System.Drawing.Point(123, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Desde"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(2, 463)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        '
        'ProgressBarControl1.Properties
        '
        Me.ProgressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Properties.Step = 1
        Me.ProgressBarControl1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.WindowText)
        Me.ProgressBarControl1.Size = New System.Drawing.Size(196, 16)
        Me.ProgressBarControl1.TabIndex = 251
        Me.ProgressBarControl1.TabStop = False
        Me.ProgressBarControl1.Visible = False
        '
        'Adapter_Ubicaciones
        '
        Me.Adapter_Ubicaciones.SelectCommand = Me.SqlSelectCommand10
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Codigo, Descripcion FROM Ubicaciones"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'Adapter_Ubicacion_Sububicacion
        '
        Me.Adapter_Ubicacion_Sububicacion.SelectCommand = Me.SqlSelectCommand11
        Me.Adapter_Ubicacion_Sububicacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SubUbicacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Ubicaciones", "Ubicaciones")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT SubUbicacion.Codigo, Ubicaciones.Descripcion + '/' + SubUbicacion.Descripc" & _
        "ionD AS Ubicaciones FROM SubUbicacion INNER JOIN Ubicaciones ON SubUbicacion.Cod" & _
        "_Ubicacion = Ubicaciones.Codigo"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataNavigator1.Buttons.Append.Enabled = False
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Enabled = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Enabled = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.First.Enabled = False
        Me.DataNavigator1.Buttons.First.Visible = False
        Me.DataNavigator1.Buttons.Remove.Enabled = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "ordencompra"
        Me.DataNavigator1.DataSource = Me.DsOrdenAutomatica
        Me.DataNavigator1.Location = New System.Drawing.Point(584, 459)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(112, 21)
        Me.DataNavigator1.TabIndex = 244
        Me.DataNavigator1.Text = "DataNavigator1"
        Me.DataNavigator1.Visible = False
        '
        'Panel_Ordenes_Imprimir
        '
        Me.Panel_Ordenes_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Ordenes_Imprimir.BackColor = System.Drawing.Color.LightBlue
        Me.Panel_Ordenes_Imprimir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Ordenes_Imprimir.Controls.Add(Me.ProgressBarControl2)
        Me.Panel_Ordenes_Imprimir.Controls.Add(Me.Label35)
        Me.Panel_Ordenes_Imprimir.Controls.Add(Me.CheckEdit1)
        Me.Panel_Ordenes_Imprimir.Controls.Add(Me.Boton_Imprimir)
        Me.Panel_Ordenes_Imprimir.Controls.Add(Me.CheckedListBoxControl1)
        Me.Panel_Ordenes_Imprimir.Location = New System.Drawing.Point(240, 48)
        Me.Panel_Ordenes_Imprimir.Name = "Panel_Ordenes_Imprimir"
        Me.Panel_Ordenes_Imprimir.Size = New System.Drawing.Size(240, 288)
        Me.Panel_Ordenes_Imprimir.TabIndex = 252
        Me.Panel_Ordenes_Imprimir.Visible = False
        '
        'ProgressBarControl2
        '
        Me.ProgressBarControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarControl2.EditValue = 100
        Me.ProgressBarControl2.Location = New System.Drawing.Point(0, 270)
        Me.ProgressBarControl2.Name = "ProgressBarControl2"
        '
        'ProgressBarControl2.Properties
        '
        Me.ProgressBarControl2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ProgressBarControl2.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.ProgressBarControl2.Properties.ShowTitle = True
        Me.ProgressBarControl2.Properties.Step = 1
        Me.ProgressBarControl2.Size = New System.Drawing.Size(238, 16)
        Me.ProgressBarControl2.TabIndex = 254
        Me.ProgressBarControl2.TabStop = False
        Me.ProgressBarControl2.Visible = False
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(240, 16)
        Me.Label35.TabIndex = 251
        Me.Label35.Text = "Selección de Ordenes a Imprimir"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = False
        Me.CheckEdit1.Location = New System.Drawing.Point(8, 240)
        Me.CheckEdit1.Name = "CheckEdit1"
        '
        'CheckEdit1.Properties
        '
        Me.CheckEdit1.Properties.Caption = "&Todas"
        Me.CheckEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.Blue)
        Me.CheckEdit1.Size = New System.Drawing.Size(64, 19)
        Me.CheckEdit1.TabIndex = 3
        '
        'Boton_Imprimir
        '
        Me.Boton_Imprimir.Location = New System.Drawing.Point(120, 240)
        Me.Boton_Imprimir.Name = "Boton_Imprimir"
        Me.Boton_Imprimir.Size = New System.Drawing.Size(112, 24)
        Me.Boton_Imprimir.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.Boton_Imprimir.TabIndex = 2
        Me.Boton_Imprimir.Text = "&Imprimir"
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(8, 24)
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(224, 208)
        Me.CheckedListBoxControl1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.CheckedListBoxControl1.TabIndex = 0
        Me.CheckedListBoxControl1.ToolTip = "Seleccione las Ordenes de Compra que desea imprimir"
        '
        'Text_Orden
        '
        Me.Text_Orden.BackColor = System.Drawing.Color.White
        Me.Text_Orden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsOrdenAutomatica, "ordencompra.Orden"))
        Me.Text_Orden.Location = New System.Drawing.Point(68, 12)
        Me.Text_Orden.Name = "Text_Orden"
        Me.Text_Orden.Size = New System.Drawing.Size(80, 12)
        Me.Text_Orden.TabIndex = 253
        '
        'daProveedores
        '
        Me.daProveedores.SelectCommand = Me.SqlSelectCommand9
        Me.daProveedores.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT CodigoProv, Nombre FROM Proveedores"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtSExcento)
        Me.Panel2.Controls.Add(Me.txtSGravado)
        Me.Panel2.Controls.Add(Me.txtmontodescuento)
        Me.Panel2.Controls.Add(Me.txtMontoImpuesto)
        Me.Panel2.Location = New System.Drawing.Point(624, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(56, 24)
        Me.Panel2.TabIndex = 254
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 456)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel3, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(714, 23)
        Me.StatusBar1.TabIndex = 255
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Width = 200
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel2.Width = 398
        '
        'frmOrdenCompraAutomatica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(714, 479)
        Me.Controls.Add(Me.Panel_Opciones)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Txt_cedulaUsuario)
        Me.Controls.Add(Me.Txtobservaciones)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.Panel_Ordenes_Imprimir)
        Me.Controls.Add(Me.Text_Orden)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label_Tipo_Cambio)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TxtImpuestoT)
        Me.Controls.Add(Me.TxtDescuentoT)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.daordencompra)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtSubExentoT)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtSubGravadoT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtSubtotalT)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(720, 500)
        Me.Name = "frmOrdenCompraAutomatica"
        Me.Opacity = 0.85
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Compra Automática"
        CType(Me.DsOrdenAutomatica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LookUpEdit_Proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOtros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFletes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tex_Porc_Imp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPorcDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TxtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDias_Entrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImpuestoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TxtNombre_Proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubExentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubGravadoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSExcento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSGravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmontodescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TxtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Opciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Ordenes_Imprimir.ResumeLayout(False)
        CType(Me.ProgressBarControl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        If Generando Then Exit Sub

        If Me.DsOrdenAutomatica.ordencompra.Rows.Count <> 0 Then
            If Me.TxtCodigo.Text = 0 Then Me.TxtNombre_Proveedor.Enabled = True
            Else
                Me.TxtNombre_Proveedor.Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
            End If

            If Me.DsOrdenAutomatica.ordencompra.Count > 0 Then Me.LookUpEdit_Proveedor.EditValue = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Proveedor")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub



#Region " Variable "                 'Definicion de Variable /Albert Estrada\
    Private cConexion As New Conexion
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
    Dim perfil_administrador As Boolean
    Dim MonedaCosto As Integer
    Dim MonedaOrdenCompra As Integer
    Dim ValorCompra_OrdenCompra As Double
    Dim ValorCosto As Double
    Dim Gravado As Double
    Dim Exento As Double
    Dim buscando As Boolean
#End Region

    Private Sub frmOrdenCompraAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS


            defaultvalue_orden()
            defaultvalue_detalle()

            Me.daUsuarios.Fill(Me.DsOrdenAutomatica, "Usuarios")
            Me.daMoneda.Fill(Me.DsOrdenAutomatica, "Moneda")
            Me.Adapter_Ubicaciones.Fill(Me.DsOrdenAutomatica, "Ubicaciones")
            Me.Adapter_Ubicacion_Sububicacion.Fill(Me.DsOrdenAutomatica, "SubUbicacion")
            'Me.Adapter_Ubicacion_Sububicacion.Fill(Me.DsOrdenAutomatica, "SubUbicacion")
            Me.daProveedores.Fill(Me.DsOrdenAutomatica, "Proveedores")



            Me.DsOrdenAutomatica.ordencompra.OrdenColumn.AutoIncrement = True
            Me.DsOrdenAutomatica.ordencompra.OrdenColumn.AutoIncrementSeed = -1
            Me.DsOrdenAutomatica.ordencompra.OrdenColumn.AutoIncrementStep = -1




            Me.DsOrdenAutomatica.detalle_ordencompra.IdColumn.AutoIncrement = True
            Me.DsOrdenAutomatica.detalle_ordencompra.IdColumn.AutoIncrementSeed = -1
            Me.DsOrdenAutomatica.detalle_ordencompra.IdColumn.AutoIncrementStep = -1


            Me.Fecha_Desde.EditValue = "01" & "/" & Now.Month & "/" & Now.Year
            Me.Fecha_Hasta.EditValue = Now.Date




            Me.txtClave.Focus()




        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub defaultvalue_detalle()
        Try
            Me.DsOrdenAutomatica.detalle_ordencompra.CostoUnitarioColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.CantidadColumn.DefaultValue = 1
            Me.DsOrdenAutomatica.detalle_ordencompra.impuestoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.Porc_ImpuestoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.Porc_DescuentoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.DescuentoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.TotalCompraColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.OtrosCargosColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.Monto_FleteColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.GravadoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.ExentoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.detalle_ordencompra.CostoColumn.DefaultValue = 0

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub defaultvalue_orden()
        Try
            Me.DsOrdenAutomatica.ordencompra.ObservacionesColumn.DefaultValue = ""
            Me.DsOrdenAutomatica.ordencompra.FechaColumn.DefaultValue = Now
            Me.DsOrdenAutomatica.ordencompra.contadoColumn.DefaultValue = False
            Me.DsOrdenAutomatica.ordencompra.creditoColumn.DefaultValue = True
            Me.DsOrdenAutomatica.ordencompra.diascreditoColumn.DefaultValue = 30
            Me.DsOrdenAutomatica.ordencompra.PlazoColumn.DefaultValue = 3
            Me.DsOrdenAutomatica.ordencompra.TotalColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.DescuentoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.ImpuestoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.Cod_MonedaColumn.DefaultValue = 1
            Me.DsOrdenAutomatica.ordencompra.ProveedorColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.NombreColumn.DefaultValue = ""
            Me.DsOrdenAutomatica.ordencompra.UsuarioColumn.DefaultValue = ""
            Me.DsOrdenAutomatica.ordencompra.NombreUsuarioColumn.DefaultValue = ""
            Me.DsOrdenAutomatica.ordencompra.SubTotalExentoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.SubTotalGravadoColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.SubTotalColumn.DefaultValue = 0
            Me.DsOrdenAutomatica.ordencompra.entregarColumn.DefaultValue = "ENCARGADO A DEFINIR"
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            inicializar()
        End If
    End Sub

    Private Sub Loggin_Usuario()
        Try
            If Me.BindingContext(Me.DsOrdenAutomatica.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DsOrdenAutomatica.Usuarios.Select("Clave_Interna ='" & txtClave.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub


                    'Dim tipo As String = Usua("Perfil")
                    'If tipo <> "INVENTARIO" And tipo <> "ADMINISTRADOR" And tipo <> "ADMINISTRATIVO" Then
                    'If PMU.Execute Then
                    'MsgBox("Usted no tiene permisos para realizar Ordenes de Compras", MsgBoxStyle.Exclamation)
                    'Me.txtClave.Text = ""
                    'Me.txtClave.Focus()
                    'Exit Sub
                    'End If

                ' Me.logeado = True

                txtClave.Enabled = False ' se inabilita el campo de la contraseña

                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(0).Enabled = True

                'If Usua("Perfil") = "ADMINISTRADOR" Then ' si el usuario tiene perfil de administrador
                'Me.perfil_administrador = True
                'Else
                'perfil_administrador = False
                'End If

                Me.ComboBox1.Enabled = True

                Me.Nueva_Orden_Compra()
                Me.Txt_cedulaUsuario.Text = Usua("Cedula")
                txtNombreUsuario.Text = Usua("Nombre")
                Me.Nombre_Usuario = txtNombreUsuario.Text
                Me.Cedula_Usuario = Me.Txt_cedulaUsuario.Text
                Me.ComboBox1.Focus()
                'inicializar()

            Else ' si no existe una contraseñla como esta
                MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                txtClave.Text = ""
            End If
            Else
            MsgBox("No Existen Usuarios, ingrese datos")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub consultarorden()
        Try


            If Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una Orden de Compra, si continúa se perderan los datos de la orden actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.ToolBar1.Buttons(0).Enabled = True


            Me.DsOrdenAutomatica.Vista_OrdenC_Auto_X_Proveedor.Clear()
            Me.DsOrdenAutomatica.detalle_ordencompra.Clear()
            Me.DsOrdenAutomatica.ordencompra.Clear()

            Dim identificador As Double

            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Orden, Nombre,Fecha from ordencompra Order by Fecha DESC", "Nombre", "Fecha", "Buscar Orden de Compra"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            Fx.Llenar_Tabla_Generico("SELECT * FROM ordencompra WHERE (Orden =" & identificador, Me.DsOrdenAutomatica.ordencompra)
            Fx.Llenar_Tabla_Generico("SELECT * FROM detalle_ordencompra WHERE (Orden =" & identificador & ")", Me.DsOrdenAutomatica.detalle_ordencompra)

            Me.GroupBox1.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.GroupBox4.Enabled = True
            Me.GroupBox3.Enabled = True
            Me.Txtobservaciones.Enabled = True

            Me.ComboBox1.Enabled = False

            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub


    Private Sub inicializar()
        Try
            If Me.ComboBox1.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar la Moneda en la que va a realizar la orden de compra", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.TxtCodigo_art.Enabled = False
            Me.ToolBar1.Buttons(0).Enabled = True

            Me.Txt_Descri_Articulo.Enabled = False
            Me.ComboBox1.Enabled = False

            Me.Panel_Opciones.Visible = True
            'Me.Group_Generada_por.Enabled = True
            Me.Option_Proveedor.Checked = True

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Loggin_Usuario()
        End If
    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores ", "Nombre", "Buscar Proveedor...")
                If valor <> "" Then
                    Me.TxtCodigo.Text = valor
                    Cargar_proveedor(valor)
                End If

            Case Keys.Enter
                If Me.TxtCodigo.Text <> "" Then
                    Cargar_proveedor(Me.TxtCodigo.Text)
                    Insertar_Proveedor()
                End If

        End Select

    End Sub


    Private Sub OpContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpContado.CheckedChanged
        If Me.OpContado.Checked = True Then
            Me.TxtDias.Visible = False
            Me.TxtDias.Text = 0
            Label21.Visible = False
        End If
    End Sub

    Private Sub OpCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpCredito.CheckedChanged
        If Me.OpCredito.Checked = True Then
            Me.TxtDias.Visible = True
            Me.TxtDias.Text = 0
            Label21.Visible = True
        End If
    End Sub


    Private Sub Calcular_Totales_Orden_Compra()  ' calcula el monto Total de la cotización
        Try
            Me.BindingContext(DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()

            TxtSubtotalT.Text = Math.Round(Me.colTotalCompra.SummaryItem.SummaryValue, 2)
            Me.TxtSubGravadoT.Text = Math.Round(Me.colGravado.SummaryItem.SummaryValue, 2)
            Me.TxtSubExentoT.Text = Math.Round(Me.colExento.SummaryItem.SummaryValue, 2)
            TxtDescuentoT.Text = Math.Round(Me.colDescuento.SummaryItem.SummaryValue, 2)
            TxtImpuestoT.Text = Math.Round(Me.colimpuesto.SummaryItem.SummaryValue, 2)
            TxtMonto.Text = Math.Round(CDbl(TxtSubtotalT.Text) - CDbl(Me.TxtDescuentoT.Text) + CDbl(Me.TxtImpuestoT.Text), 2)

            BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo_art.KeyPress, Txt_Descri_Articulo.KeyPress, TxtCosto.KeyPress, TxtDescuentoT.KeyPress, TxtImpuestoT.KeyPress, TxtCant.KeyPress, TxtOtros.KeyPress, TxtDescuentoT.KeyPress, TxtPorcDesc.KeyPress, Tex_Porc_Imp.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub OpContado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OpContado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.GroupBox4.Enabled = True
            Me.TxtDias_Entrega.Focus()
        End If
    End Sub

    Private Sub TxtDias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDias.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.GroupBox4.Enabled = True
            Me.TxtDias_Entrega.Focus()
        End If
    End Sub

    Private Sub TxtDias_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDias.GotFocus, TxtDias_Entrega.GotFocus, TxtFletes.GotFocus, TxtOtros.GotFocus, TxtCant.GotFocus, TxtCosto.GotFocus, TxtDescuentoT.GotFocus, TxtImpuestoT.GotFocus, TxtPrecioUnit.GotFocus
        sender.SelectAll()
    End Sub

    Private Sub TxtDias_Entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDias_Entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtEntrega.Focus()
        End If
    End Sub

    Private Sub TxtEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEntrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.GroupBox3.Enabled = True
            Me.TxtCodigo_art.Focus()
        End If
    End Sub

    Private Sub TxtCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCant.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Me.TxtOtros.Text <> "" Then
        '        Me.TxtPrecioUnit.Text = Me.TxtPrecioUnit.Text
        '        TxtCosto.Text = CDbl(Me.TxtPrecioUnit.Text) + CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text)
        '    Else
        '        Me.TxtOtros.Text = 0.0
        '    End If
        '    Calculos_Articulo()
        '    Calcular_Totales_Orden_Compra()
        'End If

        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            If Me.TxtCant.Text = "" Then Exit Sub
            meter_al_detalle()
            TxtCodigo_art.Focus()
        End If


    End Sub

    Private Sub meter_al_detalle()
        Try
            Dim resp As Integer
            If Me.TxtCant.Text = "" Or Me.TxtCant.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.TxtCant.Text = "1"
                Exit Sub
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo a la Orden?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                Me.TxtCodigo_art.Focus()
                Exit Sub
            End If

            Me.Calculos_Articulo()

            BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()

            ' Calcular_totales()
            Calcular_Totales_Orden_Compra()


            Me.GridControl1.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub


    'Function Calcular_totales()
    '    Try

    '        BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
    '        Calcular_Totales_Orden_Compra()

    '        BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()
    '        BindingContext(Me.DataSetOrden_Compras1, "ordencompra").AddNew()
    '        BindingContext(Me.DataSetOrden_Compras1, "ordencompra").CancelCurrentEdit()
    '        BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Position = BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count

    '    Catch ex As System.Exception
    '                    MsgBox(EX.Message ,MsgBoxStyle.Information ,"Atención...")
    '    End Try

    'End Function

    Private Sub TxtPrecioUni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrecioUnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtPrecioUnit.Text <> "" Then
                Me.TxtFletes.Focus()
            Else
                Me.TxtPrecioUnit.Text = 0.0
            End If
            Calcular_Totales_Orden_Compra()
        End If
    End Sub

    Private Sub TxtOtros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOtros.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtOtros.Text <> "" Then
                Me.TxtPrecioUnit.Text = Me.TxtPrecioUnit.Text
                TxtCosto.Text = CDbl(Me.TxtPrecioUnit.Text) + CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text)
            Else
                Me.TxtOtros.Text = 0.0
            End If
            Calculos_Articulo()
            Calcular_Totales_Orden_Compra()
        End If
    End Sub

    Private Sub TxtFletes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFletes.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.TxtFletes.Text <> "" Then
                Me.TxtOtros.Focus()
            Else
                Me.TxtFletes.Text = 0.0
            End If
            Calcular_Totales_Orden_Compra()
        End If
    End Sub

    Private Sub Calculos_Articulo()
        Try
            Dim DescuentoCalc As Double

            'Me.Tex_PorcDesc.Text = Me.impuesto_cliente * CDbl(Me.txtImpVenta.Text) / 100
            DescuentoCalc = (CDbl(TxtPrecioUnit.Text) * CDbl(Me.TxtCant.Text)) * (CDbl(Me.TxtPorcDesc.Text) / 100)
            Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento

            If Me.Tex_Porc_Imp.Text <> 0 Then 'si tiene impuesto de venta
                If (CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text)) > CDbl(TxtPrecioUnit.Text) Then
                    TxtFletes.Text = 0
                    TxtOtros.Text = 0
                End If

                Gravado = ((CDbl(TxtPrecioUnit.Text) - CDbl(TxtFletes.Text) - CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
                txtMontoImpuesto.Text = (Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(Tex_Porc_Imp.Text) / 100)
                txtSGravado.Text = Gravado
                Exento = 0

            Else 'si no tiene impuesto de venta
                Exento = ((CDbl(TxtPrecioUnit.Text) - CDbl(TxtFletes.Text) - CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
                Gravado = 0
                txtMontoImpuesto.Text = 0
                txtSGravado.Text = 0
                txtSExcento.Text = Exento
            End If

            Exento = Exento + ((CDbl(TxtFletes.Text) + CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
            txtSExcento.Text = Exento
            TxtTotal.Text = CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text) '+ CDbl(Me.txtmontodescuento.Text)


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        Me.TxtPrecioUnit.Focus()
    End Sub

    Private Sub TxtPorcDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPorcDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim DescuentoCalc As Double

            DescuentoCalc = (CDbl(TxtPrecioUnit.Text) * CDbl(Me.TxtCant.Text)) * (CDbl(Me.TxtPorcDesc.Text) / 100)
            Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
            Calcular_Totales_Orden_Compra()
        End If
    End Sub

    Private Sub Tex_Porc_Imp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tex_Porc_Imp.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.Tex_Porc_Imp.Text <> 0 Then 'si tiene impuesto de venta
                    If (CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text)) > CDbl(TxtPrecioUnit.Text) Then
                        TxtFletes.Text = 0
                        TxtOtros.Text = 0
                    End If

                    Gravado = ((CDbl(TxtPrecioUnit.Text) - CDbl(TxtFletes.Text) - CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
                    txtMontoImpuesto.Text = (Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(Tex_Porc_Imp.Text) / 100)
                    txtSGravado.Text = Gravado
                    Exento = 0

                Else 'si no tiene impuesto de venta
                    Exento = ((CDbl(TxtPrecioUnit.Text) - CDbl(TxtFletes.Text) - CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
                    Gravado = 0
                    txtMontoImpuesto.Text = 0
                    txtSGravado.Text = 0
                    txtSExcento.Text = Exento
                End If

                Exento = Exento + ((CDbl(TxtFletes.Text) + CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
                txtSExcento.Text = Exento
                TxtTotal.Text = CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text) '+ CDbl(Me.txtmontodescuento.Text)

            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
            Calcular_Totales_Orden_Compra()
        End If
    End Sub
    Private Sub NuevoCompraAutomatica()
        If Me.ToolBar1.Buttons(0).Text = "Cancelar" Then

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").CancelCurrentEdit()
            Me.DsOrdenAutomatica.detalle_ordencompra.Clear()
            Me.DsOrdenAutomatica.ordencompra.Clear()
            Me.dt.Clear()
            Me.GroupBox2.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.GroupBox4.Enabled = False
            Me.txtClave.Text = ""
            Me.txtClave.Enabled = True
            Me.txtNombreUsuario.Text = ""
            Me.ProgressBarControl1.Text = 0
            Me.Panel_Opciones.Visible = False
        Else
            Me.txtClave.Text = ""
            Me.txtClave.Enabled = True
            Me.txtClave.Focus()
        End If

    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevoCompraAutomatica()
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Eliminar_Orden() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()

        End Select
    End Sub

    Private Sub Eliminar_Orden()
        Dim resp As Integer
        Try 'se intenta hacer
            If BindingContext(Me.DsOrdenAutomatica, "ordencompra").Count > 0 Then   ' si hay ubicaciones
                resp = MessageBox.Show("¿Desea eliminar esta orden de compra?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    BindingContext(Me.DsOrdenAutomatica, "ordencompra").RemoveAt(Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Position)
                    BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                    MsgBox("Orden de Compra Eliminada", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("No Existen Orden de compra que eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub TxtDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDias.KeyPress, TxtDias_Entrega.KeyPress, TxtPrecioUnit.KeyPress, TxtFletes.KeyPress, TxtOtros.KeyPress, TxtCosto.KeyPress, TxtPorcDesc.KeyPress, Tex_Porc_Imp.KeyPress, TxtCant.KeyPress, TxtTotal.KeyPress, TxtCodigo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub Nueva_Orden_Compra()
        Try
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").AddNew()
            Else
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").CancelCurrentEdit()
                Me.DsOrdenAutomatica.detalle_ordencompra.Clear()
                Me.DsOrdenAutomatica.ordencompra.Clear()
                Me.DsOrdenAutomatica.Vista_OrdenC_Auto_X_Proveedor.Clear()

            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Sub Insertar_Proveedor()
        Try
            Dim func As New cFunciones
            Dim con As New Conexion
            Dim x As Integer
            Dim da As New SqlDataAdapter("Orden_Compras_Automaticas", Me.SqlConnection1.ConnectionString)

            dt.Clear()

            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.Add("@Cod_Pro", SqlDbType.Int)
            da.SelectCommand.Parameters("@Cod_Pro").Value = IIf(CDbl(Me.TxtCodigo.Text) <> 0, CDbl(Me.TxtCodigo.Text), 0)

            da.SelectCommand.Parameters.Add("@Cod_Ubica", SqlDbType.Int)
            da.SelectCommand.Parameters("@Cod_Ubica").Value = CDbl(Me.Label_cod_ubicacion.Text)

            da.SelectCommand.Parameters.Add("@Cod_Sububica", SqlDbType.Char)
            da.SelectCommand.Parameters("@Cod_Sububica").Value = Me.Label_Codigo_Sububicacion.Text

            da.SelectCommand.Parameters.Add("@Tipo", SqlDbType.Int)
            da.SelectCommand.Parameters("@Tipo").Value = 1

            da.Fill(dt)
            'Me.DataGrid1.DataSource = dt


            If dt.Rows.Count = 0 Then
                MsgBox("No existen artículos por ordenar a este proveedor", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()

            Me.ProgressBarControl1.Visible = True
            Me.ProgressBarControl1.Properties.Maximum = dt.Rows.Count - 1
            Me.ProgressBarControl1.Properties.Minimum = 0

            For x = 0 To dt.Rows.Count - 1

                If Necesario_Pedir(dt.Rows(x).Item("Codigo"), dt.Rows(x).Item("Exist_Actual")) Then

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").AddNew()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Codigo") = dt.Rows(x).Item("Codigo")
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Descripcion") = dt.Rows(x).Item("Descripcion")
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Cantidad") = Me.Cant_Pedir

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Impuesto") = dt.Rows(x).Item("Porc_Impuesto")
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Vendidos") = Vendidos
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Exist_Actual") = dt.Rows(x).Item("Exist_Actual")
                    'Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Orden") = CDbl(Me.Text_Orden.Text)


                    'Sacar el valor de conversion con respecto al ultimo costo
                    Me.Cod_Mod = dt.Rows(x).Item("MonedaCosto")
                    If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
                    Valor_Compra_Ultima_Compra = con.SlqExecuteScalar(Me.SqlConnection1, "Select ValorCompra from Moneda where CodMoneda = " & Me.Cod_Mod)
                    Me.Valor_Conversion = Valor_Compra_Ultima_Compra / CDbl(Label_Tipo_Cambio.Text)

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario") = dt.Rows(x).Item("CostoUnitario") * Me.Valor_Conversion
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()

                    Me.Calculos_Articulo()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                    Me.Cod_Mod = 0
                    Me.cod_pro = 0
                    Me.Valor_Conversion = 0
                    Me.Cant_Pedir = 0
                    Me.Vendidos = 0
                End If
                Application.DoEvents()
                Me.ProgressBarControl1.Text = x
            Next

            Me.Calcular_Totales_Orden_Compra()
            Me.ProgressBarControl1.Text = 0
            Me.ProgressBarControl1.Visible = False

            Me.ToolBar1.Buttons(2).Enabled = True
            Me.GroupBox3.Enabled = True
            Me.GroupBox4.Enabled = True
            Me.GridControl1.Enabled = True
            GroupBox2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function Necesario_Pedir(ByVal Codigo, ByVal Exitencia_Actual) As Boolean
        Try
            Dim fun As New Conexion
            Vendidos = fun.SlqExecuteScalar(fun.Conectar, "Select dbo.ArticuloCantidadVendida(" & Codigo & ",'" & Me.Fecha_Desde.Text & "','" & Me.Fecha_Hasta.Text & "')")

            If Vendidos > Exitencia_Actual Then ' si la cantidad que se ha vendido es mayor que la existencia actual de ese articulo en el inventario
                Me.Cant_Pedir = Vendidos - Exitencia_Actual
                fun.DesConectar(fun.sQlconexion)
                Return True
            Else
                fun.DesConectar(fun.sQlconexion)
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
    Private Sub Registrar()
        Try
            Me.ToolBar1.Buttons(2).Enabled = False
            Dim x As Integer
            If Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Count = 0 Then  'Si la factura no tiene detalle
                MsgBox("No se Puede Registrar una Orden sin artículos", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If

            If MessageBox.Show("¿Desea Registrar esta Orden?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If
            '   Me.ToolBar1.Buttons(3).Enabled = False


            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()


            If Me.RegistrarOrden() Then  'se registra en la base de datos then

                Me.DsOrdenAutomatica.AcceptChanges()

                Me.TxtNombre_Proveedor.Enabled = True

                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True


                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False



                Me.GroupBox3.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox1.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.Txtobservaciones.Enabled = False
                Me.Label10.Visible = False
                Me.Label11.Visible = False



                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.txtUsuario.Focus()

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                ' imprimir(CDbl(Text_Orden.Text))
                '
                Dim num_orden As Integer
                Me.Panel_Ordenes_Imprimir.Visible = True
                Dim arreglo_Checks(Me.DsOrdenAutomatica.ordencompra.Count) As DevExpress.XtraEditors.Controls.CheckedListBoxItem

                For x = 0 To Me.DsOrdenAutomatica.ordencompra.Count - 1
                    num_orden = Me.DsOrdenAutomatica.ordencompra.Rows(x).Item("Orden")
                    arreglo_Checks(x) = New DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    arreglo_Checks(x).Value = num_orden.ToString + "-" + Me.DsOrdenAutomatica.ordencompra.Rows(x).Item("Nombre")
                    Me.CheckedListBoxControl1.Items.Add(arreglo_Checks(x))
                Next x

                Me.ToolBar1.Buttons(2).Enabled = False

            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)

                Me.ToolBar1.Buttons(2).Enabled = True
                'Me.txtUsuario.Enabled = True

            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Function RegistrarOrden() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try


            Me.daOrdenCompras.InsertCommand.Transaction = Trans
            Me.daDetalleOrdenCompra.InsertCommand.Transaction = Trans

            Me.daOrdenCompras.UpdateCommand.Transaction = Trans
            Me.daDetalleOrdenCompra.UpdateCommand.Transaction = Trans

            Me.daOrdenCompras.DeleteCommand.Transaction = Trans
            Me.daDetalleOrdenCompra.DeleteCommand.Transaction = Trans

            'Me.daOrdenCompras.Update(Me.DsOrdenAutomatica, "ordencompra")
            'Me.daDetalleOrdenCompra.Update(Me.DsOrdenAutomatica, "detalle_ordencompra")


            ' Add parents first, then children
            ' Delete children first, then parents
            ' Use the Select method to return an array of rows
            '  to be updated or added
            Me.daOrdenCompras.Update(Me.DsOrdenAutomatica.ordencompra.Select("", "", _
DataViewRowState.Added Or DataViewRowState.ModifiedCurrent))


            ' Add, change or delete children

            Me.daDetalleOrdenCompra.Update(Me.DsOrdenAutomatica.detalle_ordencompra.Select("", "", _
  DataViewRowState.Added Or DataViewRowState.ModifiedCurrent))


            ' Delete any remaining parents
            Me.daOrdenCompras.Update(Me.DsOrdenAutomatica.ordencompra)
            Me.daDetalleOrdenCompra.Update(Me.DsOrdenAutomatica.detalle_ordencompra)

            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try

    End Function

    Private Sub Imprimir(ByVal orden As Integer, ByVal Nombre_Proveedor As String)
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim OrdenC_Reporte As New Reporte_Orden_Compra
            Dim visor As New frmVisorReportes
            OrdenC_Reporte.SetParameterValue(0, orden)
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, OrdenC_Reporte)
            visor.rptViewer.Visible = True
            OrdenC_Reporte = Nothing
            visor.MdiParent = Me.ParentForm
            visor.Text = orden & ": " & Nombre_Proveedor
            visor.Show()
            visor.WindowState = FormWindowState.Minimized
            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub




    Private Sub TxtNombre_Proveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre_Proveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Insertar_Proveedor()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try

        End If
    End Sub

    Private Sub TxtCant_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCant.EditValueChanged

    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Option_Ubicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Option_Ubicacion.CheckedChanged
        Try
            If Me.Option_Ubicacion.Checked = True Then
                Me.Combo_Ubicacion.Visible = True
                Me.Label_Seleccione.Visible = True
                Me.Label_Seleccione.Text = "Ubicación"

            Else
                Me.Combo_Ubicacion.Visible = False
                Me.Label_Seleccione.Visible = False
                Me.Label_Seleccione.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Option_Sububicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Option_Sububicacion.CheckedChanged
        Try
            If Me.Option_Sububicacion.Checked = True Then
                Me.ComboBo_Ubica_Sububica.Visible = True
                Me.Label_Seleccione.Visible = True
                Me.Label_Seleccione.Text = "SubUbicación"
            Else
                Me.ComboBo_Ubica_Sububica.Visible = False
                Me.Label_Seleccione.Visible = False
                Me.Label_Seleccione.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub Option_Proveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Option_Proveedor.CheckedChanged
        Try
            If Me.Option_Proveedor.Checked = True Then
                Me.Combo_Ubicacion.Visible = False
                Me.ComboBo_Ubica_Sububica.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Boton_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Generar.Click
        Try

            If Me.Option_Proveedor.Checked = True Then
                Me.GroupBox2.Enabled = True
                Me.Txtobservaciones.Enabled = True
                TxtCodigo.Focus()
                Me.Panel_Opciones.Visible = False
                Exit Sub
            End If

            If Me.Option_Ubicacion.Checked = True Then
                Me.Insertar_Por_Ubicacion_SubUbica(2)
                Exit Sub
            End If


            If Me.Option_Sububicacion.Checked = True Then
                Me.Insertar_Por_Ubicacion_SubUbica(3)
                Exit Sub
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub



    Sub Insertar_Por_Ubicacion_SubUbica(ByVal tipo As Integer)
        Try
            Dim func As New cFunciones
            Dim con As New Conexion
            Dim x As Integer

            Dim da As New SqlDataAdapter("Orden_Compras_Automaticas", Me.SqlConnection1.ConnectionString)

            dt.Clear()

            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.Add("@Cod_Pro", SqlDbType.Int)

            da.SelectCommand.Parameters("@Cod_Pro").Value = IIf(Me.TxtCodigo.Text <> 0 And Me.TxtCodigo.Text <> "", Me.TxtCodigo.Text, 0)

            da.SelectCommand.Parameters.Add("@Cod_Ubica", SqlDbType.Int)
            da.SelectCommand.Parameters("@Cod_Ubica").Value = CDbl(Me.Label_cod_ubicacion.Text)

            da.SelectCommand.Parameters.Add("@Cod_Sububica", SqlDbType.Char)
            da.SelectCommand.Parameters("@Cod_Sububica").Value = Me.Label_Codigo_Sububicacion.Text

            da.SelectCommand.Parameters.Add("@Tipo", SqlDbType.Int)
            da.SelectCommand.Parameters("@Tipo").Value = tipo

            da.Fill(dt)


            If dt.Rows.Count = 0 Then
                If tipo = 2 Then MsgBox("No existen artículos por ordenar en esta ubicacion", MsgBoxStyle.Information)
                If tipo = 3 Then MsgBox("No existen artículos por ordenar en esta Sub-ubicacion", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.Panel_Opciones.Visible = False


            Me.ProgressBarControl1.Visible = True
            Me.ProgressBarControl1.Properties.Maximum = dt.Rows.Count - 1
            Me.ProgressBarControl1.Properties.Minimum = 0


            Generando = True
            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").CancelCurrentEdit()




            For x = 0 To dt.Rows.Count - 1

                Me.StatusBarPanel3.Text = "Item " & x + 1 & " : " & dt.Rows.Count

                If Necesario_Pedir(dt.Rows(x).Item("Codigo"), dt.Rows(x).Item("Exist_Actual")) Then


                    Verificar_Orden_Compra_Proveedor(dt.Rows(x).Item("Cod_Pro"))
                    Me.LookUpEdit_Proveedor.EditValue = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Proveedor")

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").AddNew()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Codigo") = dt.Rows(x).Item("Codigo")
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Descripcion") = dt.Rows(x).Item("Descripcion")
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Cantidad") = Me.Cant_Pedir

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Impuesto") = dt.Rows(x).Item("Porc_Impuesto")
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Vendidos") = Vendidos
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Exist_Actual") = dt.Rows(x).Item("Exist_Actual")

                    'Sacar el valor de conversion con respecto al ultimo costo
                    Me.Cod_Mod = dt.Rows(x).Item("MonedaCosto")
                    If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
                    Valor_Compra_Ultima_Compra = con.SlqExecuteScalar(Me.SqlConnection1, "Select ValorCompra from Moneda where CodMoneda = " & Me.Cod_Mod)
                    Me.Valor_Conversion = Valor_Compra_Ultima_Compra / CDbl(Label_Tipo_Cambio.Text)

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario") = dt.Rows(x).Item("CostoUnitario") * Me.Valor_Conversion
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()

                    Me.Calculos_Articulo()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                    Me.Calcular_Totales_Orden_Compra()

                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").AddNew()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()

                    Me.Cod_Mod = 0
                    Me.cod_pro = 0
                    Me.Valor_Conversion = 0
                    Me.Cant_Pedir = 0
                    Me.Vendidos = 0
                End If
                Application.DoEvents()
                Me.ProgressBarControl1.Text = x

            Next

            Me.ProgressBarControl1.Text = 0
            Me.ProgressBarControl1.Visible = False


            If Me.DsOrdenAutomatica.ordencompra.Count = 0 Then
                MsgBox("De acuerdo a este criterio no se generaron ordenes de compra", MsgBoxStyle.Information)
                Me.Panel_Opciones.Visible = True
                Generando = False
                Exit Sub
            End If


            MsgBox("Se Generaron Correctamente " + Me.DsOrdenAutomatica.ordencompra.Rows.Count.ToString + " Ordedes de Compra", MsgBoxStyle.Information)


            Me.GroupBox3.Enabled = True
            Me.GroupBox4.Enabled = True
            GroupBox2.Enabled = True
            Me.Txtobservaciones.Enabled = True
            Me.GridControl1.Enabled = True

            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Generando = False
            DataNavigator1.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Sub Verificar_Orden_Compra_Proveedor(ByVal cod_pro)
        Try
            Dim pos As Integer

            dtview = Me.DsOrdenAutomatica.ordencompra.DefaultView
            dtview.Sort = "Proveedor"

            If Me.DsOrdenAutomatica.ordencompra.Rows.Count <> 0 Then

                pos = dtview.Find(cod_pro) 'Busca si ya existe una orden de compra con ese código de proveedor

                If cod_pro = 0 Then 'Si el artículo no ha sido adquirido recientemente o se borro el provedor al que fue adqurido

                    If pos <> -1 Then ' Si ya existe la orden de compra con el proveedor cero
                        Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Position = pos ' se mueve a la posicion donde está esa orden de compra
                        Exit Sub
                    Else ' si aun no existe la orden de compra con el provedor cero
                        Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                        Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").AddNew()
                        txtNombreUsuario.Text = Me.Nombre_Usuario
                        Me.Txt_cedulaUsuario.Text = Me.Cedula_Usuario
                        Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                        Recupera_Posicion()
                        Exit Sub
                    End If
                End If


                If pos <> -1 Then ' si ya existe uan orden de compra para ese proveedor
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Position = pos ' se mueve a la posicion donde está esa orden de compra
                    Exit Sub

                Else 'Si no hay una orden de compra para ese proveedor
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").AddNew()
                    ' se ponen los datos generales a la orden de compra
                    txtNombreUsuario.Text = Me.Nombre_Usuario
                    Me.Txt_cedulaUsuario.Text = Me.Cedula_Usuario
                    Me.TxtCodigo.Text = cod_pro
                    Me.Cargar_proveedor(Me.TxtCodigo.Text)
                    Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                    Recupera_Posicion()
                    Exit Sub
                End If

            Else ' Si no hay almenos una orden de compra
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").AddNew()
                ' se ponen los datos generales a la orden de compra
                txtNombreUsuario.Text = Me.Nombre_Usuario
                Me.Txt_cedulaUsuario.Text = Me.Cedula_Usuario
                Me.TxtCodigo.Text = cod_pro
                Me.Cargar_proveedor(Me.TxtCodigo.Text)
                Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                Recupera_Posicion()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Sub Recupera_Posicion()
        Try
            pos_actual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Position
            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").AddNew()
            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").CancelCurrentEdit()
            Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Position = pos_actual
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Sub Cargar_proveedor(ByVal cod As String)
        Try
            Dim func As New Conexion
            Dim Proveedor As SqlDataReader
            If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()
            Proveedor = func.GetRecorset(Me.SqlConnection1, "Select CodigoProv, Nombre, Plazo from Proveedores where CodigoProv =" & CInt(cod))

            While Proveedor.Read <> 0
                Me.TxtNombre_Proveedor.Text = Proveedor("Nombre")
                TxtDias.Text = Proveedor("Plazo")
                Me.TxtNombre_Proveedor.Enabled = False
                Me.TxtDias.Focus()

            End While
            Me.SqlConnection1.Close()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.SqlConnection1.Close()
        End Try
    End Sub






    Private Sub Ultimo_Proveedor(ByVal cod_art As Integer)
        Dim func As New Conexion
        Dim rs As SqlClient.SqlDataReader
        Dim cod As Integer
        Try


            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            rs = func.GetRecorset(Me.SqlConnection1, "SELECT MAX(dbo.DateOnly(FechaUltimaCompra)) AS Fecha, Moneda, CodigoArticulo, CodigoProveedor FROM dbo.[Articulos x Proveedor] GROUP BY Moneda, CodigoArticulo, CodigoProveedor HAVING (CodigoArticulo = " & cod_art & ") ORDER BY MAX(dbo.DateOnly(FechaUltimaCompra))  DESC")

            While rs.Read
                Me.cod_pro = rs("CodigoProveedor")
                Me.Cod_Mod = rs("Moneda")
                Exit While
            End While

            Me.SqlConnection1.Close()
            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            If Me.cod_pro <> 0 Then
                Valor_Compra_Ultima_Compra = func.SlqExecuteScalar(Me.SqlConnection1, "Select ValorCompra from Moneda where CodMoneda = " & Me.Cod_Mod)
                Me.Valor_Conversion = Valor_Compra_Ultima_Compra / CDbl(Label_Tipo_Cambio.Text)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Ariculo_Detalle()
        End If
    End Sub
    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Count > 0 Then   ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este artículo de la Orden de Compra?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").RemoveAt(Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Position)
                    BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()

                    BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                    Calcular_Totales_Orden_Compra()

                    BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                Else
                    BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Artículos para eliminar en la Orden de Compra", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProgressBarControl1.Text = Me.ProgressBarControl1.Text + 1
        If Me.ProgressBarControl1.Text = 100 Then Me.ProgressBarControl1.Text = 0
        Application.DoEvents()
    End Sub


    Private Sub Boton_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Imprimir.Click
        Me.Boton_Imprimir.Enabled = False
        Me.ProgressBarControl2.Visible = True
        Me.ProgressBarControl2.Properties.Minimum = 0
        Me.ProgressBarControl2.Properties.Maximum = Me.CheckedListBoxControl1.Items.Count
        Me.ProgressBarControl2.Text = 0

        Try
            While Me.CheckedListBoxControl1.Items.Count <> 0
                Application.DoEvents()

                If Me.CheckedListBoxControl1.Items(0).CheckState = CheckState.Checked Then
                    Me.Imprimir(CDbl(Split(CheckedListBoxControl1.Items(0).Value, "-").GetValue(0)), Split(CheckedListBoxControl1.Items(0).Value, "-").GetValue(1))
                End If
                Me.CheckedListBoxControl1.Items.RemoveAt(0)
                Me.ProgressBarControl2.Text = Me.ProgressBarControl2.Text + 1
            End While
            Me.ProgressBarControl2.Text = 0
            Me.ProgressBarControl2.Visible = False
            Me.Boton_Imprimir.Enabled = True
            Me.Panel_Ordenes_Imprimir.Visible = False
            Me.DsOrdenAutomatica.detalle_ordencompra.Clear()
            Me.DsOrdenAutomatica.ordencompra.Clear()
            Me.dt.Clear()
            Me.txtClave.Text = ""
            Me.txtClave.Enabled = True
            Me.txtClave.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Try

            Dim x As Integer
            If Me.CheckEdit1.Checked = True Then
                For x = 0 To Me.CheckedListBoxControl1.Items.Count - 1
                    Me.CheckedListBoxControl1.Items(x).CheckState = CheckState.Checked
                Next x
            Else
                For x = 0 To Me.CheckedListBoxControl1.Items.Count - 1
                    Me.CheckedListBoxControl1.Items(x).CheckState = CheckState.Unchecked
                Next x
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Txtobservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtobservaciones.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim ProveedorActual As Double
        'Dim ProveedorNuevo As Double
        'Dim OrdenActual As Double
        'Dim OrdenNueva As Double
        'Dim ItemActual As Double


        ''Ubica al proveedor actual y su informacion.
        'ProveedorActual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Proveedor")
        'ProveedorNuevo = Me.LookUpEdit_Proveedor.EditValue

        'ItemActual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Id")
        'OrdenActual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Orden")

        'MsgBox("Desea Proceder a cambiar el artículo seleccionado del proveedor " & ProveedorActual & " al proveedor " & Me.LookUpEdit_Proveedor.EditValue & "  ?", MsgBoxStyle.YesNo, "Atención...")
        ''Verifica la existencia de un una orden con el proveedor selecccionado.
        'Verificar_Orden_Compra_Proveedor(Me.LookUpEdit_Proveedor.EditValue)
        'OrdenNueva = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Orden")

        'Me.DsOrdenAutomatica.detalle_ordencompra.FindById(ItemActual).Orden = OrdenNueva
        'Me.Calcular_Totales_Orden_Compra()


        'Verificar_Orden_Compra_Proveedor(ProveedorActual)
        'Me.Calcular_Totales_Orden_Compra()
        'MsgBox("El cambio ha sido realiazado.. ", MsgBoxStyle.Information, "")

    End Sub
    Private Sub LookUpEdit_Proveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LookUpEdit_Proveedor.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                Dim ProveedorActual As Double
                Dim ProveedorNuevo As Double
                Dim OrdenActual As Double
                Dim OrdenNueva As Double
                Dim ItemActual As Double


                'Ubica al proveedor actual y su informacion.
                ProveedorActual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Proveedor")
                ProveedorNuevo = Me.LookUpEdit_Proveedor.EditValue

                ItemActual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Current("Id")
                OrdenActual = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Orden")

                If MsgBox("Desea Proceder a cambiar el artículo seleccionado del proveedor " & ProveedorActual & " al proveedor " & Me.LookUpEdit_Proveedor.EditValue & "  ?", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then

                    'Verifica la existencia de un una orden con el proveedor selecccionado. sino se crea la Orden.
                    Verificar_Orden_Compra_Proveedor(Me.LookUpEdit_Proveedor.EditValue)
                    OrdenNueva = Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Current("Orden")

                    'Al item que se encuentra en la orden de donde se extrae el item se le cambia la orden y se recalcula la nueva orden
                    Me.DsOrdenAutomatica.detalle_ordencompra.FindById(ItemActual).Orden = OrdenNueva
                    Me.Calcular_Totales_Orden_Compra()
                    Verificar_Orden_sin_Detalle()

                    Application.DoEvents()
                    ' se regresa a la orden de donde se extrajo el item y se recalcula
                    Verificar_Orden_Compra_Proveedor(ProveedorActual)
                    Me.Calcular_Totales_Orden_Compra()
                    Verificar_Orden_sin_Detalle() 'si la orden actual queda sin registros en el detalle se procede a preguntar si se es eliminada.

                    MsgBox("El cambio ha sido realiazado.. ", MsgBoxStyle.Information, "")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Sub Verificar_Orden_sin_Detalle()
        If Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra.ordencompradetalle_ordencompra").Count = 0 Then
            If MsgBox("Desea proceder a eliminar la orden actual...?, Actualmente ya no contiene items", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Atención...") = MsgBoxResult.Yes Then
                BindingContext(Me.DsOrdenAutomatica, "ordencompra").RemoveAt(Me.BindingContext(Me.DsOrdenAutomatica, "ordencompra").Position)
                BindingContext(Me.DsOrdenAutomatica, "ordencompra").EndCurrentEdit()
                MsgBox("La Orden de Compra ha sido Eliminada satisfactoriamente...", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub LookUpEdit_Proveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdit_Proveedor.EditValueChanged

    End Sub

    Private Sub TxtCodigo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.EditValueChanged

    End Sub
End Class
