Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms


Public Class Devoluciones_Compras
    'Inherits System.Windows.Forms.Form
    Inherits FrmPlantilla

    Dim Cedula_usuario As String
    Dim buscando As Boolean = False
    Dim Usua As Object
    Dim nProveedor As String
    Dim cProveedor As String
    Dim nuevaConexion As String
    Dim PMU As New PerfilModulo_Class
    Dim strmodulo As String = ""
    'La variable anulacion strAnulacion servira para indicar si la anulacion se realizo con exito
    'si esto sucede se inhabilitara el boton eliminar del toolbar esto para que este no pueda ser presionado mas de una vez 
    'para anular una devolucion, ya que si esto sucede se perdera la integridad de los datos en la tabla articulos_comprados por que 
    'al precionar en repetidas ocasiones el dicho boton se dispara el trigger que incide en el campo Devoluciones de la tabla articulos_comprados
    'JCGA 10/05/2007
    Dim strAnulacion As String = ""


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro
        nuevaConexion = Conexion
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
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImpVentaT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ValidText1 As ValidText.ValidText
    Friend WithEvents TextDevoluciones As System.Windows.Forms.Label
    Friend WithEvents TextCantidadOriginal As System.Windows.Forms.Label
    Friend WithEvents TextDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextPrecioUnitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextDescripcion As System.Windows.Forms.Label
    Friend WithEvents TextCodigo As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents DtVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextNumero As ValidText.ValidText
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtNum_Devo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_DevCompras1 As DataSet_DevCompras
    Friend WithEvents Adapter_DevCompras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Articulos_Compras_Dev As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Adapter_Compras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Articulos_Comprados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents colBase As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMonto_Flete As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOtrosCargos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidad1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGravado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescuento_P As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colImpuesto_P As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colImpuesto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDevoluciones As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecio_A As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecio_B As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colId_ArticuloComprados As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIdCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_Costo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto_Descuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto_Impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotalGravado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotalExcento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtExentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGravadoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand51 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterLotes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LNumer As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Devoluciones_Compras))
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
        Dim ColumnFilterInfo18 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo19 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo20 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo21 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo22 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo23 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo24 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo25 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo26 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo27 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo28 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo29 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.txtNombreUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtExentoT = New DevExpress.XtraEditors.TextEdit()
        Me.DataSet_DevCompras1 = New LcPymes_5._2.DataSet_DevCompras()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGravadoT = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtImpVentaT = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoT = New DevExpress.XtraEditors.TextEdit()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio_Costo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LNumer = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ValidText1 = New ValidText.ValidText()
        Me.TextDevoluciones = New System.Windows.Forms.Label()
        Me.TextCantidadOriginal = New System.Windows.Forms.Label()
        Me.TextDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.TextPrecioUnitario = New DevExpress.XtraEditors.TextEdit()
        Me.TextDescripcion = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextMonto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.DtVence = New System.Windows.Forms.DateTimePicker()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.ComboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNumero = New ValidText.ValidText()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtNum_Devo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_DevCompras = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Articulos_Compras_Dev = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Adapter_Compras = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand51 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Articulos_Comprados = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.colBase = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMonto_Flete = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colOtrosCargos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCosto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidad1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGravado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescuento_P = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colImpuesto_P = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colImpuesto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDevoluciones = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecio_A = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecio_B = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colId_ArticuloComprados = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIdCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterLotes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtExentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_DevCompras1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGravadoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPrecioUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 400)
        Me.ToolBar1.Size = New System.Drawing.Size(684, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(384, 424)
        Me.DataNavigator.Size = New System.Drawing.Size(158, 21)
        Me.DataNavigator.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(684, 32)
        Me.TituloModulo.Text = "Devoluciones de Compra"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(344, 461)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(352, 13)
        Me.txtNombreUsuario.TabIndex = 165
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(288, 461)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 163
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(224, 461)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 164
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtExentoT)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtGravadoT)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.txtImpVentaT)
        Me.GroupBox4.Controls.Add(Me.txtDescuentoT)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 352)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(688, 48)
        Me.GroupBox4.TabIndex = 169
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'txtExentoT
        '
        Me.txtExentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "devoluciones_Compras.SubTotalExcento", True))
        Me.txtExentoT.EditValue = "0.00"
        Me.txtExentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtExentoT.Location = New System.Drawing.Point(260, 24)
        Me.txtExentoT.Name = "txtExentoT"
        '
        '
        '
        Me.txtExentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtExentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExentoT.Properties.ReadOnly = True
        Me.txtExentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.txtExentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExentoT.Size = New System.Drawing.Size(104, 19)
        Me.txtExentoT.TabIndex = 33
        '
        'DataSet_DevCompras1
        '
        Me.DataSet_DevCompras1.DataSetName = "DataSet_DevCompras"
        Me.DataSet_DevCompras1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_DevCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(260, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Excento"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGravadoT
        '
        Me.txtGravadoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "devoluciones_Compras.SubTotalGravado", True))
        Me.txtGravadoT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "devoluciones_Compras.SubTotalGravado", True))
        Me.txtGravadoT.EditValue = "0.00"
        Me.txtGravadoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGravadoT.Location = New System.Drawing.Point(148, 24)
        Me.txtGravadoT.Name = "txtGravadoT"
        '
        '
        '
        Me.txtGravadoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtGravadoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGravadoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGravadoT.Properties.ReadOnly = True
        Me.txtGravadoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.txtGravadoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGravadoT.Size = New System.Drawing.Size(104, 19)
        Me.txtGravadoT.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(152, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Gravado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(8, -1)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(144, 16)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Totales de Devolución"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "devoluciones_Compras.Monto", True))
        Me.txtTotal.EditValue = "0.00"
        Me.txtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotal.Location = New System.Drawing.Point(580, 24)
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
        Me.txtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(104, 19)
        Me.txtTotal.TabIndex = 29
        '
        'txtImpVentaT
        '
        Me.txtImpVentaT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "devoluciones_Compras.Impuesto", True))
        Me.txtImpVentaT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "devoluciones_Compras.Impuesto", True))
        Me.txtImpVentaT.EditValue = "0.00"
        Me.txtImpVentaT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVentaT.Location = New System.Drawing.Point(476, 24)
        Me.txtImpVentaT.Name = "txtImpVentaT"
        '
        '
        '
        Me.txtImpVentaT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVentaT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.ReadOnly = True
        Me.txtImpVentaT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.txtImpVentaT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVentaT.Size = New System.Drawing.Size(104, 19)
        Me.txtImpVentaT.TabIndex = 28
        '
        'txtDescuentoT
        '
        Me.txtDescuentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "devoluciones_Compras.Descuento", True))
        Me.txtDescuentoT.EditValue = "0.00"
        Me.txtDescuentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDescuentoT.Location = New System.Drawing.Point(372, 24)
        Me.txtDescuentoT.Name = "txtDescuentoT"
        '
        '
        '
        Me.txtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtDescuentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.ReadOnly = True
        Me.txtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Transparent, System.Drawing.Color.RoyalBlue)
        Me.txtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoT.Size = New System.Drawing.Size(104, 19)
        Me.txtDescuentoT.TabIndex = 27
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(580, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Total"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(468, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imp. Venta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(372, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(104, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Descuento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.DataMember = "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos"
        Me.GridControl2.DataSource = Me.DataSet_DevCompras1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 208)
        Me.GridControl2.MainView = Me.GridView1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(680, 144)
        Me.GridControl2.TabIndex = 185
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo1, Me.colDescripcion1, Me.colCantidad, Me.colPrecio_Costo, Me.colMonto_Descuento, Me.colMonto_Impuesto, Me.colSubtotalGravado, Me.colSubTotalExcento, Me.colSubTotal})
        Me.GridView1.DetailHeight = 200
        Me.GridView1.GroupPanelText = "Detalle de Factura"
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowNewItemRow = True
        '
        'colCodigo1
        '
        Me.colCodigo1.Caption = "Codigo"
        Me.colCodigo1.FieldName = "Codigo"
        Me.colCodigo1.FilterInfo = ColumnFilterInfo1
        Me.colCodigo1.Name = "colCodigo1"
        Me.colCodigo1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo1.VisibleIndex = 0
        Me.colCodigo1.Width = 80
        '
        'colDescripcion1
        '
        Me.colDescripcion1.Caption = "Descripción"
        Me.colDescripcion1.FieldName = "Descripcion"
        Me.colDescripcion1.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion1.Name = "colDescripcion1"
        Me.colDescripcion1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion1.VisibleIndex = 1
        Me.colDescripcion1.Width = 300
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo3
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 80
        '
        'colPrecio_Costo
        '
        Me.colPrecio_Costo.Caption = "Costo"
        Me.colPrecio_Costo.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Costo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Costo.FieldName = "Precio_Costo"
        Me.colPrecio_Costo.FilterInfo = ColumnFilterInfo4
        Me.colPrecio_Costo.Name = "colPrecio_Costo"
        Me.colPrecio_Costo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Costo.VisibleIndex = 3
        Me.colPrecio_Costo.Width = 80
        '
        'colMonto_Descuento
        '
        Me.colMonto_Descuento.Caption = "Descuento"
        Me.colMonto_Descuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Descuento.FieldName = "Monto_Descuento"
        Me.colMonto_Descuento.FilterInfo = ColumnFilterInfo5
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Descuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Descuento.VisibleIndex = 4
        Me.colMonto_Descuento.Width = 85
        '
        'colMonto_Impuesto
        '
        Me.colMonto_Impuesto.Caption = "Impuesto"
        Me.colMonto_Impuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Impuesto.FieldName = "Monto_Impuesto"
        Me.colMonto_Impuesto.FilterInfo = ColumnFilterInfo6
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Impuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Impuesto.VisibleIndex = 5
        Me.colMonto_Impuesto.Width = 80
        '
        'colSubtotalGravado
        '
        Me.colSubtotalGravado.Caption = "Gravado"
        Me.colSubtotalGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubtotalGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotalGravado.FieldName = "SubtotalGravado"
        Me.colSubtotalGravado.FilterInfo = ColumnFilterInfo7
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubtotalGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubtotalGravado.VisibleIndex = 6
        Me.colSubtotalGravado.Width = 80
        '
        'colSubTotalExcento
        '
        Me.colSubTotalExcento.Caption = "Excento"
        Me.colSubTotalExcento.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotalExcento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotalExcento.FieldName = "SubTotalExcento"
        Me.colSubTotalExcento.FilterInfo = ColumnFilterInfo8
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotalExcento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotalExcento.VisibleIndex = 7
        Me.colSubTotalExcento.Width = 80
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SubTotal"
        Me.colSubTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.FilterInfo = ColumnFilterInfo9
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotal.VisibleIndex = 8
        Me.colSubTotal.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LNumer)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.GridControl1)
        Me.GroupBox2.Controls.Add(Me.SimpleButton1)
        Me.GroupBox2.Controls.Add(Me.ValidText1)
        Me.GroupBox2.Controls.Add(Me.TextDevoluciones)
        Me.GroupBox2.Controls.Add(Me.TextCantidadOriginal)
        Me.GroupBox2.Controls.Add(Me.TextDescuento)
        Me.GroupBox2.Controls.Add(Me.TextPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.TextDescripcion)
        Me.GroupBox2.Controls.Add(Me.TextCodigo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 104)
        Me.GroupBox2.TabIndex = 167
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de los Artículos Facturados"
        '
        'LNumer
        '
        Me.LNumer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNumer.BackColor = System.Drawing.SystemColors.Window
        Me.LNumer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "articulos_comprados.Lote", True))
        Me.LNumer.Location = New System.Drawing.Point(592, 16)
        Me.LNumer.Name = "LNumer"
        Me.LNumer.Size = New System.Drawing.Size(80, 13)
        Me.LNumer.TabIndex = 210
        Me.LNumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(512, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 208
        Me.Label16.Text = "Lote"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "articulos_comprados"
        Me.GridControl1.DataSource = Me.DataSet_DevCompras1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 16)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(304, 80)
        Me.GridControl1.TabIndex = 184
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colNumero})
        Me.GridView2.DetailHeight = 200
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupedColumns = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo10
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 90
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo11
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 152
        '
        'colNumero
        '
        Me.colNumero.Caption = "Lote"
        Me.colNumero.FieldName = "Lote"
        Me.colNumero.FilterInfo = ColumnFilterInfo12
        Me.colNumero.Name = "colNumero"
        Me.colNumero.VisibleIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(688, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 16)
        Me.SimpleButton1.TabIndex = 207
        Me.SimpleButton1.Text = "Devolución Total"
        Me.SimpleButton1.Visible = False
        '
        'ValidText1
        '
        Me.ValidText1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidText1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText1.FieldReference = Nothing
        Me.ValidText1.Location = New System.Drawing.Point(591, 65)
        Me.ValidText1.MaskEdit = ""
        Me.ValidText1.Name = "ValidText1"
        Me.ValidText1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText1.Required = False
        Me.ValidText1.ShowErrorIcon = False
        Me.ValidText1.Size = New System.Drawing.Size(80, 13)
        Me.ValidText1.TabIndex = 206
        Me.ValidText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValidText1.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.ValidText1.ValidText = Nothing
        '
        'TextDevoluciones
        '
        Me.TextDevoluciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDevoluciones.BackColor = System.Drawing.SystemColors.Window
        Me.TextDevoluciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "articulos_comprados.Devoluciones", True))
        Me.TextDevoluciones.Location = New System.Drawing.Point(591, 49)
        Me.TextDevoluciones.Name = "TextDevoluciones"
        Me.TextDevoluciones.Size = New System.Drawing.Size(80, 13)
        Me.TextDevoluciones.TabIndex = 205
        Me.TextDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextCantidadOriginal
        '
        Me.TextCantidadOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextCantidadOriginal.BackColor = System.Drawing.SystemColors.Window
        Me.TextCantidadOriginal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "articulos_comprados.Cantidad", True))
        Me.TextCantidadOriginal.Location = New System.Drawing.Point(591, 33)
        Me.TextCantidadOriginal.Name = "TextCantidadOriginal"
        Me.TextCantidadOriginal.Size = New System.Drawing.Size(80, 13)
        Me.TextCantidadOriginal.TabIndex = 204
        Me.TextCantidadOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextDescuento
        '
        Me.TextDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "articulos_comprados.Descuento", True))
        Me.TextDescuento.Location = New System.Drawing.Point(415, 53)
        Me.TextDescuento.Name = "TextDescuento"
        '
        '
        '
        Me.TextDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextDescuento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextDescuento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextDescuento.Properties.ReadOnly = True
        Me.TextDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextDescuento.Size = New System.Drawing.Size(88, 17)
        Me.TextDescuento.TabIndex = 203
        '
        'TextPrecioUnitario
        '
        Me.TextPrecioUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPrecioUnitario.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_DevCompras1, "articulos_comprados.Costo", True))
        Me.TextPrecioUnitario.Location = New System.Drawing.Point(415, 33)
        Me.TextPrecioUnitario.Name = "TextPrecioUnitario"
        '
        '
        '
        Me.TextPrecioUnitario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextPrecioUnitario.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextPrecioUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextPrecioUnitario.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextPrecioUnitario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextPrecioUnitario.Properties.ReadOnly = True
        Me.TextPrecioUnitario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextPrecioUnitario.Size = New System.Drawing.Size(88, 17)
        Me.TextPrecioUnitario.TabIndex = 202
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDescripcion.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "articulos_comprados.Descripcion", True))
        Me.TextDescripcion.ForeColor = System.Drawing.Color.White
        Me.TextDescripcion.Location = New System.Drawing.Point(320, 0)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(352, 13)
        Me.TextDescripcion.TabIndex = 201
        Me.TextDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextCodigo
        '
        Me.TextCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.TextCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "articulos_comprados.Codigo", True))
        Me.TextCodigo.Location = New System.Drawing.Point(415, 16)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(89, 13)
        Me.TextCodigo.TabIndex = 200
        Me.TextCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(510, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 12)
        Me.Label14.TabIndex = 199
        Me.Label14.Text = "Devolución"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(510, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 12)
        Me.Label13.TabIndex = 197
        Me.Label13.Text = "Devoluciones"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(510, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 12)
        Me.Label12.TabIndex = 195
        Me.Label12.Text = "Cant Original"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(319, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Descuento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(319, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Precio Costo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(320, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 185
        Me.Label7.Text = "Código"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_DevCompras1, "devoluciones_Compras.Anulado", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(8, 461)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 211
        Me.CheckBox1.Text = "Anulado"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextMonto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.DtVence)
        Me.GroupBox1.Controls.Add(Me.ComboTipo)
        Me.GroupBox1.Controls.Add(Me.ComboMoneda)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextNumero)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 64)
        Me.GroupBox1.TabIndex = 166
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Factura"
        '
        'TextMonto
        '
        Me.TextMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextMonto.ForeColor = System.Drawing.Color.Blue
        Me.TextMonto.Location = New System.Drawing.Point(371, 32)
        Me.TextMonto.Name = "TextMonto"
        Me.TextMonto.Size = New System.Drawing.Size(92, 20)
        Me.TextMonto.TabIndex = 16
        Me.TextMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "devoluciones_Compras.NombrePro", True))
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(166, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtNombre.TabIndex = 15
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DtVence
        '
        Me.DtVence.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtVence.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtVence.Checked = False
        Me.DtVence.CustomFormat = ""
        Me.DtVence.Enabled = False
        Me.DtVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtVence.Location = New System.Drawing.Point(475, 33)
        Me.DtVence.Name = "DtVence"
        Me.DtVence.Size = New System.Drawing.Size(92, 20)
        Me.DtVence.TabIndex = 14
        Me.DtVence.Value = New Date(2006, 3, 15, 10, 56, 38, 537)
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.Items.AddRange(New Object() {"CON", "CRE"})
        Me.ComboTipo.Location = New System.Drawing.Point(8, 31)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(80, 21)
        Me.ComboTipo.TabIndex = 13
        '
        'ComboMoneda
        '
        Me.ComboMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboMoneda.DataSource = Me.DataSet_DevCompras1
        Me.ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMoneda.Location = New System.Drawing.Point(579, 32)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(96, 21)
        Me.ComboMoneda.TabIndex = 12
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(579, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Moneda"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(475, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(368, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto Factura"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(166, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Proveedor"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(90, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextNumero
        '
        Me.TextNumero.FieldReference = Nothing
        Me.TextNumero.Location = New System.Drawing.Point(90, 32)
        Me.TextNumero.MaskEdit = ""
        Me.TextNumero.Name = "TextNumero"
        Me.TextNumero.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TextNumero.Required = False
        Me.TextNumero.ShowErrorIcon = False
        Me.TextNumero.Size = New System.Drawing.Size(72, 20)
        Me.TextNumero.TabIndex = 201
        Me.TextNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextNumero.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TextNumero.ValidText = Nothing
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
        'txtNum_Devo
        '
        Me.txtNum_Devo.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Devo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_DevCompras1, "devoluciones_Compras.Devolucion", True))
        Me.txtNum_Devo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum_Devo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtNum_Devo.Location = New System.Drawing.Point(72, 15)
        Me.txtNum_Devo.Name = "txtNum_Devo"
        Me.txtNum_Devo.Size = New System.Drawing.Size(96, 16)
        Me.txtNum_Devo.TabIndex = 210
        Me.txtNum_Devo.Text = "0"
        Me.txtNum_Devo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(4, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 211
        Me.Label11.Text = "Devol. N°"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
    "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, Perfil FROM Usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Adapter_DevCompras
        '
        Me.Adapter_DevCompras.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_DevCompras.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_DevCompras.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_DevCompras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "devoluciones_Compras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Devolucion", "Devolucion"), New System.Data.Common.DataColumnMapping("Id_Factura_Compra", "Id_Factura_Compra"), New System.Data.Common.DataColumnMapping("SaldoAnt_Fact", "SaldoAnt_Fact"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("NombrePro", "NombrePro"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada")})})
        Me.Adapter_DevCompras.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombrePro", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombrePro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnt_Fact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura_Compra", System.Data.SqlDbType.BigInt, 8, "Id_Factura_Compra"), New System.Data.SqlClient.SqlParameter("@SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, "SaldoAnt_Fact"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@NombrePro", System.Data.SqlDbType.VarChar, 255, "NombrePro"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura_Compra", System.Data.SqlDbType.BigInt, 8, "Id_Factura_Compra"), New System.Data.SqlClient.SqlParameter("@SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, "SaldoAnt_Fact"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@NombrePro", System.Data.SqlDbType.VarChar, 255, "NombrePro"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombrePro", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombrePro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnt_Fact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Devolucion", System.Data.SqlDbType.BigInt, 8, "Devolucion")})
        '
        'Adapter_Articulos_Compras_Dev
        '
        Me.Adapter_Articulos_Compras_Dev.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Articulos_Compras_Dev.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Articulos_Compras_Dev.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Articulos_Compras_Dev.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos_Compras_devueltos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Devolucion", "Devolucion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Numero", "Numero")})})
        Me.Adapter_Articulos_Compras_Dev.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Devolucion", System.Data.SqlDbType.BigInt, 8, "Devolucion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Devolucion", System.Data.SqlDbType.BigInt, 8, "Devolucion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(592, 3)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtFecha.TabIndex = 212
        '
        'Adapter_Compras
        '
        Me.Adapter_Compras.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Compras.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Compras.SelectCommand = Me.SqlSelectCommand51
        Me.Adapter_Compras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "compras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Compra", "Id_Compra"), New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("TotalFactura", "TotalFactura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("FechaIngreso", "FechaIngreso"), New System.Data.Common.DataColumnMapping("MotivoGasto", "MotivoGasto"), New System.Data.Common.DataColumnMapping("Compra", "Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Consignacion", "Consignacion"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("ContaInve", "ContaInve"), New System.Data.Common.DataColumnMapping("AsientoInve", "AsientoInve"), New System.Data.Common.DataColumnMapping("TipoCompra", "TipoCompra"), New System.Data.Common.DataColumnMapping("CedulaUsuario", "CedulaUsuario"), New System.Data.Common.DataColumnMapping("Cod_MonedaCompra", "Cod_MonedaCompra"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado")})})
        Me.Adapter_Compras.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AsientoInve", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CedulaUsuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CedulaUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Compra", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Consignacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consignacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContaInve", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContaInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MotivoGasto", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MotivoGasto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCompra", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@TotalFactura", System.Data.SqlDbType.Float, 8, "TotalFactura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 8, "Vence"), New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"), New System.Data.SqlClient.SqlParameter("@MotivoGasto", System.Data.SqlDbType.VarChar, 255, "MotivoGasto"), New System.Data.SqlClient.SqlParameter("@Compra", System.Data.SqlDbType.Bit, 1, "Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Consignacion", System.Data.SqlDbType.Bit, 1, "Consignacion"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.Float, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@ContaInve", System.Data.SqlDbType.Bit, 1, "ContaInve"), New System.Data.SqlClient.SqlParameter("@AsientoInve", System.Data.SqlDbType.Float, 8, "AsientoInve"), New System.Data.SqlClient.SqlParameter("@TipoCompra", System.Data.SqlDbType.VarChar, 3, "TipoCompra"), New System.Data.SqlClient.SqlParameter("@CedulaUsuario", System.Data.SqlDbType.VarChar, 75, "CedulaUsuario"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, "Cod_MonedaCompra"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado")})
        '
        'SqlSelectCommand51
        '
        Me.SqlSelectCommand51.CommandText = resources.GetString("SqlSelectCommand51.CommandText")
        Me.SqlSelectCommand51.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@TotalFactura", System.Data.SqlDbType.Float, 8, "TotalFactura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 8, "Vence"), New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"), New System.Data.SqlClient.SqlParameter("@MotivoGasto", System.Data.SqlDbType.VarChar, 255, "MotivoGasto"), New System.Data.SqlClient.SqlParameter("@Compra", System.Data.SqlDbType.Bit, 1, "Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Consignacion", System.Data.SqlDbType.Bit, 1, "Consignacion"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.Float, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@ContaInve", System.Data.SqlDbType.Bit, 1, "ContaInve"), New System.Data.SqlClient.SqlParameter("@AsientoInve", System.Data.SqlDbType.Float, 8, "AsientoInve"), New System.Data.SqlClient.SqlParameter("@TipoCompra", System.Data.SqlDbType.VarChar, 3, "TipoCompra"), New System.Data.SqlClient.SqlParameter("@CedulaUsuario", System.Data.SqlDbType.VarChar, 75, "CedulaUsuario"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, "Cod_MonedaCompra"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Original_Id_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AsientoInve", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CedulaUsuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CedulaUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaCompra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Compra", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Consignacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consignacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContaInve", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContaInve", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MotivoGasto", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MotivoGasto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCompra", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalFactura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalFactura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Compra", System.Data.SqlDbType.BigInt, 8, "Id_Compra")})
        '
        'Adapter_Articulos_Comprados
        '
        Me.Adapter_Articulos_Comprados.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adapter_Articulos_Comprados.InsertCommand = Me.SqlInsertCommand4
        Me.Adapter_Articulos_Comprados.SelectCommand = Me.SqlSelectCommand6
        Me.Adapter_Articulos_Comprados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos_comprados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_ArticuloComprados", "Id_ArticuloComprados"), New System.Data.Common.DataColumnMapping("IdCompra", "IdCompra"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Base", "Base"), New System.Data.Common.DataColumnMapping("Monto_Flete", "Monto_Flete"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Gravado", "Gravado"), New System.Data.Common.DataColumnMapping("Exento", "Exento"), New System.Data.Common.DataColumnMapping("Descuento_P", "Descuento_P"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto_P", "Impuesto_P"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("NuevoCostoBase", "NuevoCostoBase"), New System.Data.Common.DataColumnMapping("Lote", "Lote")})})
        Me.Adapter_Articulos_Comprados.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento_P", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento_P", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCompra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto_P", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto_P", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Lote", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NuevoCostoBase", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NuevoCostoBase", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdCompra", System.Data.SqlDbType.BigInt, 8, "IdCompra"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Base", System.Data.SqlDbType.Float, 8, "Base"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Descuento_P", System.Data.SqlDbType.Float, 8, "Descuento_P"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto_P", System.Data.SqlDbType.Float, 8, "Impuesto_P"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@NuevoCostoBase", System.Data.SqlDbType.Float, 8, "NuevoCostoBase"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdCompra", System.Data.SqlDbType.BigInt, 8, "IdCompra"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Base", System.Data.SqlDbType.Float, 8, "Base"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Descuento_P", System.Data.SqlDbType.Float, 8, "Descuento_P"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto_P", System.Data.SqlDbType.Float, 8, "Impuesto_P"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@NuevoCostoBase", System.Data.SqlDbType.Float, 8, "NuevoCostoBase"), New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote"), New System.Data.SqlClient.SqlParameter("@Original_Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento_P", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento_P", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCompra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto_P", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto_P", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Lote", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NuevoCostoBase", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NuevoCostoBase", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, "Id_ArticuloComprados")})
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(88, 461)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 16)
        Me.CheckBox2.TabIndex = 213
        Me.CheckBox2.Text = "Cancelada"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'colBase
        '
        Me.colBase.Caption = "Base"
        Me.colBase.FieldName = "Base"
        Me.colBase.FilterInfo = ColumnFilterInfo13
        Me.colBase.Name = "colBase"
        Me.colBase.Visible = True
        '
        'colMonto_Flete
        '
        Me.colMonto_Flete.Caption = "Monto_Flete"
        Me.colMonto_Flete.FieldName = "Monto_Flete"
        Me.colMonto_Flete.FilterInfo = ColumnFilterInfo14
        Me.colMonto_Flete.Name = "colMonto_Flete"
        Me.colMonto_Flete.Visible = True
        '
        'colOtrosCargos
        '
        Me.colOtrosCargos.Caption = "OtrosCargos"
        Me.colOtrosCargos.FieldName = "OtrosCargos"
        Me.colOtrosCargos.FilterInfo = ColumnFilterInfo15
        Me.colOtrosCargos.Name = "colOtrosCargos"
        Me.colOtrosCargos.Visible = True
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo"
        Me.colCosto.FieldName = "Costo"
        Me.colCosto.FilterInfo = ColumnFilterInfo16
        Me.colCosto.Name = "colCosto"
        Me.colCosto.Visible = True
        '
        'colCantidad1
        '
        Me.colCantidad1.Caption = "Cantidad"
        Me.colCantidad1.FieldName = "Cantidad"
        Me.colCantidad1.FilterInfo = ColumnFilterInfo17
        Me.colCantidad1.Name = "colCantidad1"
        Me.colCantidad1.Visible = True
        '
        'colGravado
        '
        Me.colGravado.Caption = "Gravado"
        Me.colGravado.FieldName = "Gravado"
        Me.colGravado.FilterInfo = ColumnFilterInfo18
        Me.colGravado.Name = "colGravado"
        Me.colGravado.Visible = True
        '
        'colExento
        '
        Me.colExento.Caption = "Exento"
        Me.colExento.FieldName = "Exento"
        Me.colExento.FilterInfo = ColumnFilterInfo19
        Me.colExento.Name = "colExento"
        Me.colExento.Visible = True
        '
        'colDescuento_P
        '
        Me.colDescuento_P.Caption = "Descuento_P"
        Me.colDescuento_P.FieldName = "Descuento_P"
        Me.colDescuento_P.FilterInfo = ColumnFilterInfo20
        Me.colDescuento_P.Name = "colDescuento_P"
        Me.colDescuento_P.Visible = True
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Descuento"
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.FilterInfo = ColumnFilterInfo21
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Visible = True
        '
        'colImpuesto_P
        '
        Me.colImpuesto_P.Caption = "Impuesto_P"
        Me.colImpuesto_P.FieldName = "Impuesto_P"
        Me.colImpuesto_P.FilterInfo = ColumnFilterInfo22
        Me.colImpuesto_P.Name = "colImpuesto_P"
        Me.colImpuesto_P.Visible = True
        '
        'colImpuesto
        '
        Me.colImpuesto.Caption = "Impuesto"
        Me.colImpuesto.FieldName = "Impuesto"
        Me.colImpuesto.FilterInfo = ColumnFilterInfo23
        Me.colImpuesto.Name = "colImpuesto"
        Me.colImpuesto.Visible = True
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.FilterInfo = ColumnFilterInfo24
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        '
        'colDevoluciones
        '
        Me.colDevoluciones.Caption = "Devoluciones"
        Me.colDevoluciones.FieldName = "Devoluciones"
        Me.colDevoluciones.FilterInfo = ColumnFilterInfo25
        Me.colDevoluciones.Name = "colDevoluciones"
        Me.colDevoluciones.Visible = True
        '
        'colPrecio_A
        '
        Me.colPrecio_A.Caption = "Precio_A"
        Me.colPrecio_A.FieldName = "Precio_A"
        Me.colPrecio_A.FilterInfo = ColumnFilterInfo26
        Me.colPrecio_A.Name = "colPrecio_A"
        Me.colPrecio_A.Visible = True
        '
        'colPrecio_B
        '
        Me.colPrecio_B.Caption = "Precio_B"
        Me.colPrecio_B.FieldName = "Precio_B"
        Me.colPrecio_B.FilterInfo = ColumnFilterInfo27
        Me.colPrecio_B.Name = "colPrecio_B"
        Me.colPrecio_B.Visible = True
        '
        'colId_ArticuloComprados
        '
        Me.colId_ArticuloComprados.Caption = "Id_ArticuloComprados"
        Me.colId_ArticuloComprados.FieldName = "Id_ArticuloComprados"
        Me.colId_ArticuloComprados.FilterInfo = ColumnFilterInfo28
        Me.colId_ArticuloComprados.Name = "colId_ArticuloComprados"
        Me.colId_ArticuloComprados.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colId_ArticuloComprados.Visible = True
        '
        'colIdCompra
        '
        Me.colIdCompra.Caption = "IdCompra"
        Me.colIdCompra.FieldName = "IdCompra"
        Me.colIdCompra.FilterInfo = ColumnFilterInfo29
        Me.colIdCompra.Name = "colIdCompra"
        Me.colIdCompra.Visible = True
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 452)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(684, 16)
        Me.StatusBar1.TabIndex = 214
        '
        'AdapterLotes
        '
        Me.AdapterLotes.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterLotes.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterLotes.SelectCommand = Me.SqlSelectCommand13
        Me.AdapterLotes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Inicial", "Cant_Inicial"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Fecha_Entrada", "Fecha_Entrada"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterLotes.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo")})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, Cod_Art" & _
    "iculo, Documento, Tipo FROM Lotes"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Devoluciones_Compras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(684, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtNum_Devo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GridControl2)
        Me.MaximumSize = New System.Drawing.Size(700, 507)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "Devoluciones_Compras"
        Me.Text = "Devoluciones de Compras"
        Me.Controls.SetChildIndex(Me.GridControl2, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtNum_Devo, 0)
        Me.Controls.SetChildIndex(Me.dtFecha, 0)
        Me.Controls.SetChildIndex(Me.CheckBox2, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.txtExentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_DevCompras1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGravadoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPrecioUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.BindingContext(Me.DataSet_DevCompras1.Usuarios).Count > 0 Then
                    Dim Usuario_autorizadores() As System.Data.DataRow
                    Dim Usua As System.Data.DataRow
                    Usuario_autorizadores = Me.DataSet_DevCompras1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                    If Usuario_autorizadores.Length <> 0 Then
                        Usua = Usuario_autorizadores(0)

                        txtNombreUsuario.Text = Usua("Nombre")
                        Me.Cedula_usuario = Usua("Cedula")
                        txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                        HabilitarControlesDevolucion()
                        Agregar()

                        Me.DataSet_DevCompras1.articulos_comprados.Clear()
                        Me.DataSet_DevCompras1.compras.Clear()
                        Me.DataSet_DevCompras1.articulos_Compras_devueltos.Clear()
                        Me.DataSet_DevCompras1.devoluciones_Compras.Clear()


                        Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").AddNew()
                        Me.txtNum_Devo.Text = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Devolucion")
                        dtFecha.Value = Now
                        Me.ComboTipo.Focus()
                    Else ' si no existe una contraseñla como esta
                        MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                    End If
                Else
                    MsgBox("No Existen Usuarios,ingrese datos")
                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub HabilitarControlesDevolucion()
        ComboTipo.Enabled = True
        TextNumero.Enabled = True
        dtFecha.Enabled = True
    End Sub
    Private Sub Agregar()

        Me.ToolBar1.Buttons(0).Text = "Cancelar"
        Me.ToolBar1.Buttons(0).ImageIndex = 8
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(1).Enabled = False
        Me.ToolBar1.Buttons(2).Enabled = True
        Me.ToolBar1.Buttons(3).Enabled = False
        Me.ToolBar1.Buttons(4).Enabled = False
        Me.txtUsuario.Focus()
        txtNombre.Text = ""
        TextNumero.Text = ""
        ComboTipo.Text = ""
        TextMonto.Text = ""
        DataSet_DevCompras1.articulos_Compras_devueltos.Clear()
        GridControl2.RefreshDataSource()


    End Sub


    Private Sub Devoluciones_Compras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.SqlConnection1.ConnectionString = IIf(nuevaConexion = "", CadenaConexionSeePOS, nuevaConexion)
            strmodulo = IIf(nuevaConexion = "", "SeePos", "SeePos")

            Me.DataSet_DevCompras1.articulos_comprados.Clear()
            Me.DataSet_DevCompras1.articulos_Compras_devueltos.Clear()
            Me.DataSet_DevCompras1.devoluciones_Compras.Clear()
            Me.DataSet_DevCompras1.compras.Clear()

            Me.DataSet_DevCompras1.devoluciones_Compras.DevolucionColumn.AutoIncrement = True
            Me.DataSet_DevCompras1.devoluciones_Compras.DevolucionColumn.AutoIncrementSeed = -1
            Me.DataSet_DevCompras1.devoluciones_Compras.DevolucionColumn.AutoIncrementStep = -1

            Me.DataSet_DevCompras1.articulos_Compras_devueltos.ConsecutivoColumn.AutoIncrement = True
            Me.DataSet_DevCompras1.articulos_Compras_devueltos.ConsecutivoColumn.AutoIncrementSeed = -1
            Me.DataSet_DevCompras1.articulos_Compras_devueltos.ConsecutivoColumn.AutoIncrementStep = -1

            Me.DataSet_DevCompras1.devoluciones_Compras.DevolucionColumn.AutoIncrement = True
            Me.DataSet_DevCompras1.devoluciones_Compras.DevolucionColumn.AutoIncrementSeed = -1
            Me.DataSet_DevCompras1.devoluciones_Compras.DevolucionColumn.AutoIncrementStep = -1

            Me.DataSet_DevCompras1.devoluciones_Compras.Id_Factura_CompraColumn.AutoIncrement = True
            Me.DataSet_DevCompras1.devoluciones_Compras.Id_Factura_CompraColumn.AutoIncrementSeed = -1
            Me.DataSet_DevCompras1.devoluciones_Compras.Id_Factura_CompraColumn.AutoIncrementStep = -1


            Me.DataSet_DevCompras1.devoluciones_Compras.SaldoAnt_FactColumn.DefaultValue = 0
            Me.DataSet_DevCompras1.devoluciones_Compras.FechaColumn.DefaultValue = Now
            Me.DataSet_DevCompras1.devoluciones_Compras.FechaEntradaColumn.DefaultValue = Now
            Me.DataSet_DevCompras1.devoluciones_Compras.Cedula_UsuarioColumn.DefaultValue = "0"
            Me.DataSet_DevCompras1.devoluciones_Compras.Cod_MonedaColumn.DefaultValue = "0"

            Me.Adapter_Usuarios.Fill(Me.DataSet_DevCompras1, "Usuarios")
            Me.Adapter_Moneda.Fill(Me.DataSet_DevCompras1, "Moneda")
            Me.AdapterLotes.Fill(Me.DataSet_DevCompras1, "Lotes")

            Me.valores_defecto()
            'Me.txtExentoT.DataBindings.Add(New System.Windows.Forms.Binding("text", Me.DataSet_DevCompras1, "devoluciones_Compras.Devolucion"))
            ' Me.InHabilitarControlesDetalleventas()
            Me.InHabilitarControlesDevolucion()

            txtUsuario.Focus()
            ValidText1.Enabled = False
            Me.SimpleButton1.Enabled = False
            Me.dtFecha.Value = Now

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub valores_defecto()
        Try

            Me.DataSet_DevCompras1.devoluciones_Compras.NombreProColumn.DefaultValue = ""
            Me.DataSet_DevCompras1.devoluciones_Compras.SubTotalExcentoColumn.DefaultValue = 0
            Me.DataSet_DevCompras1.devoluciones_Compras.SubTotalGravadoColumn.DefaultValue = 0
            Me.DataSet_DevCompras1.devoluciones_Compras.DescuentoColumn.DefaultValue = 0
            Me.DataSet_DevCompras1.devoluciones_Compras.ImpuestoColumn.DefaultValue = 0
            Me.DataSet_DevCompras1.devoluciones_Compras.MontoColumn.DefaultValue = 0
            Me.DataSet_DevCompras1.devoluciones_Compras.ContabilizadoColumn.DefaultValue = False
            Me.DataSet_DevCompras1.devoluciones_Compras.AnuladoColumn.DefaultValue = False

            Me.DataSet_DevCompras1.articulos_Compras_devueltos.NumeroColumn.DefaultValue = 0


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub InHabilitarControlesDevolucion()
        ComboTipo.Enabled = False
        dtFecha.Enabled = False
        TextNumero.Enabled = False
        txtNombre.Enabled = False
        TextMonto.Enabled = False
        DtVence.Enabled = False
        ComboMoneda.Enabled = False
    End Sub

    Private Sub ComboTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextNumero.Focus()
        End If
    End Sub


    Private Sub TextNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextNumero.KeyDown
        Dim Num_Fatura As String
        Dim Cfunciones As New Cfunciones
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Dim Venta As System.Data.DataTable
        Dim identificador As Double
        Dim Conex As SqlConnection
        Conex = Me.SqlConnection1

        If e.KeyCode = Keys.F1 Then
            Try
                '"SELECT Id_Compra FROM COMPRAS where FACTURA = '"& ComboTipo.text &"' AND TIPODOCOMPRA = '"TextNumero.text "'"
                'identificador = CDbl(Cfunciones.Buscar_X_Descripcion_Fecha("Select Id_Compra as Id, cast(Factura as varchar) + '-' + TipoCompra AS Factura ,Proveedores.nombre as Proveedor,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "Proveedor", "Fecha", "Buscar Factura de Compra", Conex.ConnectionString))
                identificador = CDbl(Cfunciones.Buscar_X_Descripcion_Fecha("Select Id_Compra as Id, Factura AS Factura ,Proveedores.nombre + '-' + TipoCompra as Proveedor,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "Proveedor", "Fecha", "Buscar Factura de Compra", Conex.ConnectionString, False, True))
                If Conex.State = ConnectionState.Open Then
                    Conex.Close()
                    Conex.Open()
                Else
                    Conex.Open()
                End If

                rs = cConexion.GetRecorset(Conex, "SELECT compras.TipoCompra, compras.Factura, ISNULL(Proveedores.Nombre, '') AS Proveedor FROM compras LEFT OUTER JOIN  Proveedores ON compras.CodigoProv = Proveedores.CodigoProv WHERE compras.Id_Compra = " & identificador)
                If rs.HasRows = False Then
                    MsgBox("La Factura no esta digitada", MsgBoxStyle.Information, "Atención...")
                    TextNumero.Focus()
                End If

                While rs.Read
                    Try
                        TextNumero.Text = rs("Factura")
                        ComboTipo.Text = rs("TipoCompra")
                        txtNombre.Text = rs!proveedor
                        nProveedor = rs!proveedor
                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
                Conex.Close()
                'si esta venta aun no ha sido anulada
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If

        If e.KeyCode = Keys.Enter Then
            Try

                If txtNombre.Text = "" Then

                    Dim strQuery As String = "SELECT Id_Compra FROM COMPRAS where Factura = " & TextNumero.Text & " AND TIPOCOMPRA = '" & ComboTipo.Text & "'"
                    Dim id As SqlDataReader
                    Dim idCompra As SqlDataReader
                    Dim iCompra As String = ""

                    idCompra = cConexion.GetRecorset(cConexion.Conectar(strmodulo), strQuery)
                    If idCompra.Read Then

                        iCompra = CStr(idCompra("Id_Compra"))

                    End If

                    idCompra.Close()

                    If iCompra <> "" Then

                        id = cConexion.GetRecorset(cConexion.Conectar, "SELECT compras.TipoCompra, compras.Factura, ISNULL(Proveedores.Nombre, '') AS Proveedor FROM compras LEFT OUTER JOIN  Proveedores ON compras.CodigoProv = Proveedores.CodigoProv WHERE compras.Id_Compra = " & iCompra)

                        While id.Read
                            Try
                                TextNumero.Text = id("Factura")
                                ComboTipo.Text = id("TipoCompra")
                                txtNombre.Text = id!proveedor
                                nProveedor = id!proveedor
                            Catch ex As SystemException
                                MsgBox(ex.Message)
                            End Try
                        End While
                        id.Close()

                    End If
                End If

                If ValidarBusqueda() Then
                    '<<<<<
                    If Me.txtNombre.Text = "" Then
                        If numero() Then
                            LLenarFactura(TextNumero.Text, ComboTipo.Text)
                            If Me.DataSet_DevCompras1.compras.Rows.Count > 0 Then
                                IniciarEdiconDevolucion()
                                Me.InHabilitarControlesDevolucion()
                            Else
                                MsgBox("La Factura Nª " & TextNumero.Text & "  no se encuentra registrada en el sistema o se encuentra anulada", MsgBoxStyle.Information, "Atención.......")
                            End If
                        Else
                            MessageBox.Show("La Factura digitada existe para más de un proveedor, favor especifique el proveedor presionando F1 en el campo Número", "Atención..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        End If
                    Else
                        LLenarFactura(TextNumero.Text, ComboTipo.Text)
                        If Me.DataSet_DevCompras1.compras.Rows.Count > 0 Then
                            IniciarEdiconDevolucion()
                            Me.InHabilitarControlesDevolucion()
                        Else
                            MsgBox("La Factura Nª " & TextNumero.Text & "  no se encuentra registrada en el sistema o se encuentra anulada", MsgBoxStyle.Information, "Atención.......")
                        End If
                    End If
                    '<<<<<<<<<<<<<<<
                End If


            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Function numero() As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim sel As String

        Dim Cx As New Conexion
        Dim Numero1 As String
        Dim sentence As String
        'sentence = "SELECT * FROM dbo.Deposito INNER JOIN dbo.Cuentas_bancarias ON dbo.Deposito.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria WHERE dbo.Deposito.NumeroDocumento = " & a & " And dbo.Cuentas_bancarias.Cuenta = '" & cuenta & "'"
        'SELECT compras.TipoCompra, compras.Factura, ISNULL(Proveedores.Nombre, '') AS 
        'Proveedor FROM compras LEFT OUTER JOIN  Proveedores ON compras.CodigoProv = Proveedores.CodigoProv WHERE compras.Id_Compra = " & identificador
        sentence = "SELECT count(*) from compras where TipoCompra = '" & Me.ComboTipo.SelectedItem & "' and Factura = " & Me.TextNumero.Text & ""
        Numero1 = Cx.SlqExecuteScalar(Cx.Conectar(strmodulo), sentence)
        Cx.DesConectar(Cx.sQlconexion)
        If Numero1 = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function IniciarEdiconDevolucion() As Boolean
        Try
            'DataSet_DevCompras1 - devoluciones_Compras.Devolucion

            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Id_Factura_Compra") = Me.DataSet_DevCompras1.compras.Rows(0).Item("Id_Compra")
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SaldoAnt_Fact") = Me.DataSet_DevCompras1.compras.Rows(0).Item("TotalFactura")
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Fecha") = Now
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Cedula_Usuario") = Cedula_usuario
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Cod_Moneda") = Me.DataSet_DevCompras1.compras.Rows(0).Item("Cod_MonedaCompra")

            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
            'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").AddNew()
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").AddNew()
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").CancelCurrentEdit()

            Me.LlenarVentasDetalle(Me.DataSet_DevCompras1.compras.Rows(0).Item("Id_Compra").ToString)
            'HabilitarControlesDetalleventas()
            'txtNombre.Text = Me.DataSet_DevCompras1.compras.Rows(0).Item("CodigoProv").ToString
            TextMonto.Text = Me.DataSet_DevCompras1.compras.Rows(0).Item("TotalFactura").ToString
            CheckBox2.Checked = Me.DataSet_DevCompras1.compras.Rows(0).Item("FacturaCancelado")
            DtVence.Value = Me.DataSet_DevCompras1.compras.Rows(0).Item("Fecha")
            'Aqui tengo que areglar lo de meneda 
            'ComboMoneda.text = Me.DataSet_DevCompras1.compras.Rows(0).Item("Cod_Moneda")
            'ComboMoneda.ValueMember = Me.DataSet_DevCompras1.compras.Rows(0).Item("Cod_MonedaCompra")
            If Me.DataSet_DevCompras1.compras.Rows(0).Item("TipoCompra").ToString = "CON" Then
                MsgBox("La factura fue pagada en EFECTIVO", MsgBoxStyle.Information, "Atención...")
            End If
            ValidText1.Enabled = True
            Me.SimpleButton1.Enabled = True



        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub LlenarVentasDetalle(ByVal Id As String)

        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            txtNombre.Text = nProveedor '<<<<<
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = IIf(nuevaConexion = "", GetSetting("SeeSOFT", strmodulo, "CONEXION"), nuevaConexion)
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM articulos_comprados WHERE (IdCompra = @Id_Factura) "
            '"SELECT * FROM Ventas WHERE (Tipo = @Tipo) AND (Num_Factura = @Num_Factura)"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            cmd.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla 
            da.Fill(Me.DataSet_DevCompras1, "articulos_comprados")
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Sub


    Private Function ValidarBusqueda() As Boolean

        If Me.ComboTipo.Text.Length > 0 Then

        Else
            MsgBox("Debes Seleccionar un numero de factura ", MsgBoxStyle.Information, "Atención...........")
            ComboTipo.Focus()
            Return False
        End If
        If Me.TextNumero.Text.Length > 0 Then

        Else
            MsgBox("Debes Digitar un numero de factura ", MsgBoxStyle.Information, "Atención...........")
            TextNumero.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub LLenarFactura(ByVal Num_Factura As String, ByVal Tipo As String)
        Dim cnn As SqlConnection = Nothing
        Dim rs As SqlDataReader
        Dim f As New Conexion
        Dim conex As SqlConnection = Me.SqlConnection1

        Try
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = IIf(nuevaConexion = "", GetSetting("SeeSOFT", strmodulo, "CONEXION"), nuevaConexion)

            cnn = New SqlConnection(sConn)
            cnn.Open()

            '<<<<<<
            Dim Cx As New Conexion
            Dim cod As String
            cod = Cx.SlqExecuteScalar(Cx.Conectar(strmodulo), "SELECT compras.CodigoProv FROM compras inner join Proveedores ON compras.CodigoProv=Proveedores.CodigoProv WHERE Factura = " & Num_Factura & " AND TipoCompra = '" & Tipo & "' AND Proveedores.Nombre='" & nProveedor & "'")
            Cx.DesConectar(Cx.sQlconexion)

            '<<<<<<

            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM compras inner join Proveedores ON compras.CodigoProv=Proveedores.CodigoProv WHERE (TipoCompra = @Tipo) AND (Factura = @Num_Factura) AND (Proveedores.CodigoProv= @Codig) "

            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar))
            cmd.Parameters.Add(New SqlParameter("@Num_Factura", SqlDbType.BigInt))
            cmd.Parameters.Add(New SqlParameter("@Codig", SqlDbType.BigInt))
            'cmd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar))

            cmd.Parameters("@Tipo").Value = Tipo
            cmd.Parameters("@Num_Factura").Value = Num_Factura
            cmd.Parameters("@Codig").Value = cod
            'cmd.Parameters("@Nombre").Value = nProveedor

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(Me.DataSet_DevCompras1.compras)
            Dim i As Integer = Me.DataSet_DevCompras1.compras.Count()
            'Datos de la Factura
            If conex.State = ConnectionState.Closed Then
                conex.Open()
            End If
            'rs = f.GetRecorset(f.Conectar, "SELECT compras.Factura, compras.TipoCompra, compras.TotalFactura, Proveedores.Nombre FROM compras INNER JOIN  Proveedores ON compras.CodigoProv = Proveedores.CodigoProv WHERE (compras.Factura = " & Num_Factura & ") AND (compras.TipoCompra ='" & Tipo & "')")
            rs = f.GetRecorset(conex, "SELECT compras.Factura, compras.TipoCompra, compras.TotalFactura, Proveedores.Nombre,Proveedores.CodigoProv FROM compras INNER JOIN  Proveedores ON compras.CodigoProv = Proveedores.CodigoProv WHERE (compras.Factura = " & Num_Factura & ") AND (compras.TipoCompra ='" & Tipo & "') AND Proveedores.Nombre= '" & nProveedor & "'")

            If rs.HasRows = False Then
                MsgBox("No hay datos de la factura, Pongase en contacto con SeeSoft", MsgBoxStyle.Information, "Atención...")
            End If
            While rs.Read
                Try
                    'ComboTipo.Text = rs("TipoCompra")
                    TextNumero.Text = rs("Factura")
                    txtNombre.Text = rs("Nombre")
                    nProveedor = rs("Nombre") '<<<<<<
                    cProveedor = rs("CodigoProv")

                    'TextMonto.Text = rs("TotalFactura")
                    ' ComboMoneda.SelectedItem = CDbl(rs("Cod_Moneda"))
                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()
            f.DesConectar(f.sQlconexion)

            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If

        End Try
    End Sub

    Private Sub ValidText1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidText1.TextChanged

    End Sub

    Private Sub ValidText1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ValidText1.KeyDown
        Dim resp As Integer
        Dim Cancelar As Double

        If e.KeyCode = Keys.Enter Then
            If Me.ValidText1.Text.Length > 0 Then
                Cancelar = CDbl(ValidText1.Text)

                If Cancelar > 0 Then
                    resp = MessageBox.Show("¿Desea que la información sea enviada al detalle de la Devolución?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                    If resp = 6 Then
                        IniciarEdionDetalleDevolucion()
                    End If
                Else
                    MsgBox("Debes digitar una cantidad mayor que 0", MsgBoxStyle.Information, "Atencion...")
                End If
            End If
        End If
    End Sub


    Private Function IniciarEdionDetalleDevolucion() As Boolean

        Try

            Dim Devolucion As Double = CDbl(Me.ValidText1.Text)
            Dim Devoluciones As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Devoluciones")
            Dim Cantidad As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Cantidad")
            Dim Disponible = Cantidad - Devoluciones
            Dim Codigo As Long = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Codigo")
            Dim Descripcion As String = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Descripcion")
            Dim Precio_Costo As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Costo")
            Dim Precio_Base As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Base")
            Dim Precio_Flete As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Monto_Flete")
            Dim Precio_Otros As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("OtrosCargos")
            'Dim Precio_Unit As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Precio_Unit")
            Dim Descuento As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Descuento_P")
            Dim Monto_Descuento As Double
            ' = ReglaTres(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Monto_Descuento"), Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Cantidad"), Devolucion)
            Dim Impuesto As Double = Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Impuesto_P")
            Dim Monto_Impuesto As Double
            ' =ReglaTres(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Monto_Impuesto"), Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Cantidad"), Devolucion)
            Dim SubtotalGravado As Double
            ' = ReglaTres(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("SubtotalGravado"), Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Cantidad"), Devolucion)
            Dim SubTotalExcento As Double
            '= ReglaTres(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("SubTotalExcento"), Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Cantidad"), Devolucion)
            Dim SubTotal As Double



            '*****************************************************************************************************************
            '*************************************Calculo Monto Descuento***********************************************************
            '*****************************************************************************************************************

            Monto_Descuento = (CDbl(Precio_Costo) * CDbl(Devolucion)) * (CDbl(Descuento) / 100)

            '*****************************************************************************************************************
            '*************************************Calculo Exento Gravado***********************************************************
            '*****************************************************************************************************************

            If Impuesto <> 0 Then 'si tiene impuesto de venta
                SubtotalGravado = ((CDbl(Precio_Costo) - CDbl(Precio_Flete) - CDbl(Precio_Otros)) * CDbl(Devolucion)) - Monto_Descuento
                Monto_Impuesto = SubtotalGravado * (CDbl(Impuesto) / 100)
            Else 'si no tiene impuesto de venta
                SubTotalExcento = ((CDbl(Precio_Costo) - CDbl(Precio_Flete) - CDbl(Precio_Otros)) * CDbl(Devolucion)) - Monto_Descuento
                SubtotalGravado = 0
                Monto_Impuesto = 0
            End If

            SubTotalExcento = SubTotalExcento + ((CDbl(Precio_Flete) + CDbl(Precio_Otros)) * CDbl(Devolucion))

            '*****************************************************************************************************************
            '************************************* Detalle de Devoluciones ***************************************************
            '*****************************************************************************************************************
            SubTotal = SubtotalGravado + SubTotalExcento '+ Monto_Descuento

            If (Disponible >= Devolucion) Then
                Try
                    'Actualizo el detalle de ventas
                    Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").Current("Devoluciones") += Devolucion
                    Me.BindingContext(Me.DataSet_DevCompras1, "articulos_comprados").EndCurrentEdit()
                    '********************************************************************************************************************************
                    '******************************************************DETALLE DE DEVOLUCIONES***************************************************
                    '********************************************************************************************************************************
                    'Inicio un nuevo detalle de devoluciones
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").AddNew()
                    'Asignarlos Valores  Al detalle de devolucion
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Codigo") = Codigo
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Descripcion") = Descripcion
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Cantidad") = Devolucion
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Precio_Costo") = Precio_Costo
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Precio_Base") = Precio_Base
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Precio_Flete") = Precio_Flete
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Precio_Otros") = Precio_Otros
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Descuento") = Descuento
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Monto_Descuento") = Monto_Descuento
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Impuesto") = Impuesto
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Monto_Impuesto") = Monto_Impuesto
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("SubtotalGravado") = SubtotalGravado
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("SubTotalExcento") = SubTotalExcento
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("SubTotal") = SubTotal
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Current("Numero") = Me.LNumer.Text

                    'Final un nuevo detalle de devoluciones
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").EndCurrentEdit()
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").AddNew()
                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").CancelCurrentEdit()

                    'Agregar los Subtotales al DEVOLUCIONES
                    'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Monto") += (SubTotal + Monto_Impuesto - Monto_Descuento)

                    'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalGravado") += SubtotalGravado

                    'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalExcento") += SubTotalExcento
                    'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Descuento") += Monto_Descuento
                    'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Impuesto") += Monto_Impuesto

                    CalcularMontosDevolucion()


                    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()


                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Se ha superado la venta original que registra esta factura", MsgBoxStyle.Exclamation, "Atención...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub Registrar()
        Dim REST As Integer
        Dim REST2 As Integer
        Dim NumDevo As Long
        Dim con As New Conexion

        Dim NumeroProveedor As String = "0"
        Dim frm As New frmNumeroProveedor
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            NumeroProveedor = frm.txtNumeroDocumento.Text
        Else
            Exit Sub
        End If

        If Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras.devoluciones_Comprasarticulos_Compras_devueltos").Count > 0 Then

            'NumDevo = txtNum_Devo.Text

            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()

            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            If (con.SlqExecute(SqlConnection1, "ALTER TABLE Articulos_Comprados DISABLE TRIGGER RegistrarKardexComprasIngreso_Update")) <> "" Then
                MsgBox("Error, intentelo de nuevo", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Try
                '<<<<<<<<<<<<<    
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Monto") = Math.Round(txtExentoT.EditValue + txtGravadoT.EditValue + Me.txtImpVentaT.EditValue, 2)
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Impuesto") = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Descuento") = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalExcento") = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalGravado") = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Nombrepro") = nProveedor
                Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Fecha") = dtFecha.Value
                '<<<<<<<<<<<<<<
                MsgBox("Le será devuelta la siguiente cantidad --> " & Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Monto").ToString & "<--", MsgBoxStyle.OKOnly, "SeePos")

                Me.ActualizaLote() 'Llama a la funcion para actualizar Lotes
                If RegistrarDevolucion() Then
                    NumDevo = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Devolucion")
                    Me.DataSet_DevCompras1.AcceptChanges()
                    VolverEstadonormal()
                    Limpiar()


                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update devoluciones_Compras Set NumeroProveedor = '" & NumeroProveedor & "' Where Devolucion = " & NumDevo, CommandType.Text)

                    Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = False
                    Me.ToolBar1.Buttons(3).Enabled = False
                    Me.ToolBar1.Buttons(4).Enabled = False
                    Me.ToolBar1.Buttons(5).Enabled = True
                    txtUsuario.Enabled = True
                    ValidText1.Enabled = False
                    Me.SimpleButton1.Enabled = False
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    ComboTipo.Text = ""
                    TextNumero.Text = ""
                    txtNombre.Text = ""
                    TextMonto.Text = ""
                    ComboMoneda.Text = ""

                    REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
                    If REST2 = 6 Then
                        imprimir(NumDevo)
                    End If
                    con.SlqExecute(SqlConnection1, "ALTER TABLE Articulos_Comprados ENABLE TRIGGER RegistrarKardexComprasIngreso_Update")
                    Me.SqlConnection1.Close()
                Else
                    MsgBox("Problemas al ingresar Devolución de Compras", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                con.SlqExecute(SqlConnection1, "ALTER TABLE Articulos_Comprados ENABLE TRIGGER RegistrarKardexComprasIngreso_Update")
                Me.SqlConnection1.Close()
            End Try

        Else
            MsgBox("Es necesario que almenos exista un item en el area de detalle para efctuar el registro de la devolución")
        End If
    End Sub

    Private Function RegistrarDevolucion() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            'Devoluciones 
            Me.Adapter_DevCompras.InsertCommand.Transaction = Trans
            Me.Adapter_DevCompras.UpdateCommand.Transaction = Trans
            Me.Adapter_DevCompras.DeleteCommand.Transaction = Trans

            Me.Adapter_Articulos_Compras_Dev.InsertCommand.Transaction = Trans
            Me.Adapter_Articulos_Compras_Dev.UpdateCommand.Transaction = Trans
            Me.Adapter_Articulos_Compras_Dev.DeleteCommand.Transaction = Trans

            'Compras
            Me.Adapter_Compras.InsertCommand.Transaction = Trans
            Me.Adapter_Compras.UpdateCommand.Transaction = Trans
            Me.Adapter_Compras.DeleteCommand.Transaction = Trans


            Me.Adapter_Articulos_Comprados.InsertCommand.Transaction = Trans
            Me.Adapter_Articulos_Comprados.DeleteCommand.Transaction = Trans
            Me.Adapter_Articulos_Comprados.UpdateCommand.Transaction = Trans

            'Lotes
            Me.AdapterLotes.InsertCommand.Transaction = Trans
            Me.AdapterLotes.UpdateCommand.Transaction = Trans
            Me.AdapterLotes.DeleteCommand.Transaction = Trans

            Me.Adapter_DevCompras.Update(Me.DataSet_DevCompras1, "devoluciones_Compras")
            Me.Adapter_Articulos_Compras_Dev.Update(Me.DataSet_DevCompras1, "articulos_Compras_devueltos")
            Me.AdapterLotes.Update(Me.DataSet_DevCompras1, "Lotes")


            'Me.Adapter_Compras.Update(Me.DataSet_DevCompras1.compras)
            'Me.Adapter_Articulos_Comprados.Update(Me.DataSet_DevCompras1.articulos_comprados)

            Me.DataSet_DevCompras1.AcceptChanges() '<<<<<
            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            strAnulacion = "1"
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
    Private Sub VolverEstadonormal()
        HabilitarBotones()
        'InHabilitarControlesDetalleventas()
        Me.InHabilitarControlesDevolucion()
        txtUsuario.Focus()
        ValidText1.Enabled = True
        Me.SimpleButton1.Enabled = False
        txtUsuario.Text = ""
        txtNombreUsuario.Text = ""
        ComboTipo.Text = ""
        TextNumero.Text = ""
        txtNombre.Text = ""
        TextMonto.Text = ""
        ComboMoneda.Text = ""
        ValidText1.Enabled = False
    End Sub
    Private Sub HabilitarBotones()
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(1).Enabled = True
        Me.ToolBar1.Buttons(2).Enabled = True
        Me.ToolBar1.Buttons(3).Enabled = True
        Me.ToolBar1.Buttons(4).Enabled = True
    End Sub
    Private Sub Limpiar()
        Try
            Me.DataSet_DevCompras1.articulos_comprados.Clear()
            Me.DataSet_DevCompras1.compras.Clear()
            Me.DataSet_DevCompras1.articulos_Compras_devueltos.Clear()
            Me.DataSet_DevCompras1.devoluciones_Compras.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'REVISAR: AQUI EL MENU
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
                Case 1 : If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then Agregar() Else Cancelar()
                Case 2 : If PMU.Find Then BuscarDevolucion() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4 : If PMU.Delete Then AnularDevolucion() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 5 : If PMU.Print Then
                        If txtNum_Devo.Text <> "" Then imprimir(CDbl(txtNum_Devo.Text)) Else MsgBox("No tiene datos para imprimir", MsgBoxStyle.Information, "Atención...")
                    Else
                        MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 7
                    If MessageBox.Show("¿Desea Cerrar el Módulo de Devoluciones de Compras?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub imprimir(ByVal num_devo As Double)
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Dev_Compras As New Reporte_Devoluciones_Compras
            Dev_Compras.SetParameterValue(0, CDbl(num_devo))
            CrystalReportsConexion.LoadShow(Dev_Compras, MdiParent, Me.SqlConnection1.ConnectionString)
            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Cancelar()



        'Me.DataSet_DevCompras1.articulos_comprados.RejectChanges()
        'Me.DataSet_DevCompras1.articulos_Compras_devueltos.RejectChanges()
        'Me.DataSet_DevCompras1.devoluciones_Compras.RejectChanges()

        Me.DataSet_DevCompras1.articulos_comprados.Clear()
        Me.DataSet_DevCompras1.articulos_Compras_devueltos.Clear()
        Me.DataSet_DevCompras1.devoluciones_Compras.Clear()
        Me.DataSet_DevCompras1.compras.Clear()

        Me.LimpiarVentasDetalle()
        LimpiarFactura()
        Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
        Me.ToolBar1.Buttons(0).ImageIndex = 0
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(1).Enabled = True
        Me.ToolBar1.Buttons(2).Enabled = True
        Me.ToolBar1.Buttons(3).Enabled = True
        Me.ToolBar1.Buttons(4).Enabled = True
        Me.ToolBar1.Buttons(5).Enabled = True
        txtUsuario.Enabled = True
        ValidText1.Enabled = False
        Me.SimpleButton1.Enabled = False
        txtUsuario.Text = ""
        txtNombreUsuario.Text = ""
        ComboTipo.Text = ""
        TextNumero.Text = ""
        txtNombre.Text = ""
        TextMonto.Text = ""
        ComboMoneda.Text = ""
        Me.InHabilitarControlesDevolucion()
    End Sub
    Function Registrar_Anulacion() As Boolean
        Dim i As Long
        Dim Funciones As New Conexion
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'Me.adPlanilla.InsertCommand.Transaction = Trans
            'Me.SqlUpdateCommand1.Transaction = Trans
            Adapter_DevCompras.UpdateCommand.Transaction = Trans
            'Me.adPlanilla.DeleteCommand.Transaction = Trans
            'Me.adPlanilla.SelectCommand.Transaction = Trans
            Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
            'Me.Adapter_DevCompras.Update(Me.DataSet_DevCompras1, "devoluciones_Compras")

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            strAnulacion = "1"
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Sub AnularDevolucion()
        Try
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_dev As String = Me.txtNum_Devo.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("SeePOS"), "SELECT ContaInventario FROM devoluciones_Compras WHERE Devolucion= '" & num_dev & "'")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = True Then ' se verifica si la factura seleccionada puede ser eliminada
                MessageBox.Show("La devolución seleccionada no puede ser anulada, ya fue contabilizada....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If (MsgBox("Desea Anular esta devolución de compra", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                Dim Funciones As New Conexion
                Dim j As Integer
                '<<<
                If Me.BindingContext(DataSet_DevCompras1, "devoluciones_Compras").Count <= 0 Then
                    MsgBox("No hay suficientes datos para realizar la devolucion!!", MsgBoxStyle.Exclamation, "Mensaje")
                    Exit Sub
                End If



                If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
                Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction

                For j = 0 To Me.BindingContext(DataSet_DevCompras1, "devoluciones_Compras").Count - 1
                    If Me.BindingContext(DataSet_DevCompras1, "devoluciones_Compras").Current("Devolucion") = Me.txtNum_Devo.Text Then
                        Me.BindingContext(DataSet_DevCompras1, "devoluciones_Compras").Current("Anulado") = True
                        Funciones.UpdateRecords("devoluciones_Compras", "Anulado=1", "Devolucion =" & Me.txtNum_Devo.Text, strmodulo)
                    End If
                Next
                Me.CheckBox1.Checked = True

                '                If Registrar_Anulacion() Then
                '                'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
                '                Me.DataSet_DevCompras1.devoluciones_Compras.AcceptChanges()
                '                strAnulacion = ""
                '            End If

                'If Me.RegistrarDevolucion() Then
                'strAnulacion = ""
                'End If

                'If strAnulacion = "" Then
                ToolBarEliminar.Enabled = False
                MsgBox("Devolución anulada con exito!!", MsgBoxStyle.Information, "Informacion...")
                'Else
                '    ToolBarEliminar.Enabled = True
                'End If
                '<<<

                'Me.CheckBox1.Checked = True 'aqui
                'Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
                'Me.Adapter_DevCompras.Update(Me.DataSet_DevCompras1, "devoluciones_Compras") 'aqui
            End If


        Catch ex As Exception
            MsgBox("Problemas al Anular la Devolución, intentelo de nuevo", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LimpiarFactura()
        Me.DataSet_DevCompras1.compras.Clear()
    End Sub
    Private Sub LimpiarVentasDetalle()
        Me.DataSet_DevCompras1.articulos_comprados.Clear()
    End Sub
    Private Sub BuscarDevolucion()

        Dim Fx As New cFunciones
        Dim identificador As Double


        Try
            If Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una Devolución de Compras, si continúa se perderan los datos de la Devolución de Ventas, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Me.DataSet_DevCompras1.articulos_Compras_devueltos.Clear()
            Me.DataSet_DevCompras1.devoluciones_Compras.Clear()

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT  Devolucion, NombrePro,Fecha FROM devoluciones_Compras Order by Fecha DESC", "NombrePro", "Fecha", "Buscar Devolución de Compra", Me.SqlConnection1.ConnectionString))

            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            Me.LLenar_Devoluciones(identificador)
            'si esta venta aun no ha sido anulada
            If Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Anulado") = False Then Me.ToolBar1.Buttons(3).Enabled = True
            '<<<<
            Me.txtGravadoT.Text = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalGravado")
            Me.txtExentoT.Text = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalExcento")
            Me.txtDescuentoT.Text = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Descuento")
            Me.txtImpVentaT.Text = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Impuesto")
            Me.txtTotal.Text = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Monto")
            dtFecha.Value = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Fecha")
            CheckBox1.Checked = Me.BindingContext(DataSet_DevCompras1, "devoluciones_Compras").Current("Anulado")
            If CheckBox1.Checked = True Then
                ToolBarEliminar.Enabled = False
            Else
                ToolBarEliminar.Enabled = True
            End If
            ' CheckBox2.Checked = Me.BindingContext(DataSet_DevCompras1, "Compras").Current("FacturaCancelado")
            '<<<<
            Me.GridControl2.Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = True
            'Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LLenar_Devoluciones(ByVal Id As Double)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim rs As SqlDataReader
        Dim f As New Conexion
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR DEVOLUCIONES DE COMPRAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = IIf(nuevaConexion = "", GetSetting("SeeSOFT", strmodulo, "CONEXION"), nuevaConexion)
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM devoluciones_Compras WHERE (Devolucion = @Id_Factura) "

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
            dv.Fill(Me.DataSet_DevCompras1, "devoluciones_Compras")


            '''''''''LLENAR DETALLE DE DEVOLUCIONES DE COMPRAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM articulos_Compras_devueltos WHERE (Devolucion = @Id_Factura) "

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
            da.Fill(Me.DataSet_DevCompras1, "articulos_Compras_devueltos")

            '<<<<<<
            Dim Cx As New Conexion
            Dim fact As String
            fact = Cx.SlqExecuteScalar(Cx.Conectar(strmodulo), "SELECT Id_Factura_Compra FROM devoluciones_Compras WHERE Devolucion = " & Id)
            Cx.DesConectar(Cx.sQlconexion)
            '<<<<<<


            'rs = f.GetRecorset(f.Conectar, "SELECT compras.Factura, compras.TipoCompra, compras.TotalFactura From compras  WHERE compras.Id_Compra = " & Id)
            'rs = f.GetRecorset(cnnv, "SELECT compras.Factura, compras.TipoCompra, compras.TotalFactura From compras  WHERE compras.Id_Compra = " & fact)'<<<<
            rs = f.GetRecorset(cnnv, "SELECT compras.Factura, compras.TipoCompra, compras.TotalFactura,dbo.Proveedores.Nombre From compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv WHERE compras.Id_Compra =" & fact) '<<<<
            If rs.HasRows = False Then
                MsgBox("No hay datos de la factura, Pongase en contacto con SeeSoft", MsgBoxStyle.Information, "Atención...")
            End If
            While rs.Read
                Try
                    ComboTipo.Text = rs("TipoCompra")
                    TextNumero.Text = rs("Factura")
                    txtNombre.Text = rs("Nombre")
                    TextMonto.Text = rs("TotalFactura")
                    ' ComboMoneda.SelectedItem = CDbl(rs("Cod_Moneda"))
                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()
            f.DesConectar(f.sQlconexion)


            Me.txtNum_Devo.Text = Id '<<<<<<
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

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        If Me.DataSet_DevCompras1.articulos_comprados.Count > 0 Then
            Me.ValidText1.Text = "1"
            Me.ValidText1.Focus()
        End If
    End Sub
    Private Sub CalcularMontosDevolucion()


        'txtSubtotalT.EditValue = Math.Round(Me.colSubTotal.SummaryItem.SummaryValue, 2)
        Me.txtGravadoT.EditValue = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
        txtExentoT.EditValue = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
        txtDescuentoT.EditValue = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
        txtImpVentaT.EditValue = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
        txtTotal.EditValue = Math.Round(txtExentoT.EditValue + txtGravadoT.EditValue + Me.txtImpVentaT.EditValue, 2) '- Me.txtDescuentoT.EditValue + Me.txtImpVentaT.EditValue, 2)


        txtGravadoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        txtExentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        txtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        txtImpVentaT.Properties.DisplayFormat.FormatString = "#,#0.00"
        txtTotal.Properties.DisplayFormat.FormatString = "#,#0.00"
    End Sub

    'ORA
#Region "Actualiza Lote"
    Private Sub ActualizaLote()
        Dim DrArticulos(), DrLotes() As System.Data.DataRow
        Dim DrArticulo, DrLote As System.Data.DataRow
        Dim pos, Id As Integer
        Dim vista As DataView

        Try
            If DataSet_DevCompras1.articulos_Compras_devueltos.Count > 0 Then
                DrArticulos = DataSet_DevCompras1.articulos_Compras_devueltos.Select("Numero <> '0'")

                If DrArticulos.Length <> 0 Then 'Si existe
                    For i As Integer = 0 To DrArticulos.Length - 1
                        DrArticulo = DrArticulos(i)
                        DrLotes = DataSet_DevCompras1.Lotes.Select("Numero = '" & DrArticulo("Numero") & "' And Cod_Articulo = " & DrArticulo("Codigo"))

                        If DrLotes.Length <> 0 Then 'Si existe
                            DrLote = DrLotes(0)
                            Id = DrLote("Id")
                            BindingContext(DataSet_DevCompras1, "Lotes").EndCurrentEdit()
                            vista = DataSet_DevCompras1.Lotes.DefaultView
                            vista.Sort = "Id"
                            pos = vista.Find(Id)
                            BindingContext(DataSet_DevCompras1, "Lotes").Position = pos
                            BindingContext(DataSet_DevCompras1, "Lotes").Current("Cant_Inicial") = DrLote("Cant_Inicial") - DrArticulo("Cantidad")
                            BindingContext(DataSet_DevCompras1, "Lotes").Current("Cant_Actual") = DrLote("Cant_Actual") - DrArticulo("Cantidad")
                            BindingContext(DataSet_DevCompras1, "Lotes").EndCurrentEdit()
                        End If
                    Next
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

End Class

'NOTAS :
'SAJ 04032007 ESE MODULO NO TENIA LAS SUMAS DE LA DEVOLUCION
' ADEMAS DE LOS CAMPOS DE GRAVADOS,EXCENTO,SUBTOTAL 
'SE PROCEDE PROGRAMAS DICHOS DATOS..
' NO ESTA GENERANDO EL NUMERO DE DEVOLUCION

