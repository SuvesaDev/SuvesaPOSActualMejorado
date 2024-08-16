Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing

Public Class FrmDevolucionesVentas
    Inherits FrmPlantilla
    'Inherits System.Windows.Forms.Form
    Dim Cedula_usuario As String
    Dim buscando As Boolean = False
    Dim PMU As New PerfilModulo_Class
    Dim recibo_reportePVE As New ReporteDevolucionesVentas_PVE
    Dim Prerecibo_reportePVE As New ReportePreDevolucionesVentas_PVE

#Region " Variable "                 'Definicion de Variable 
    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim consignado As Boolean = False
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ComboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterDevoluciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetDevolucionVentas1 As DataSetDevolucionVentas
    Friend WithEvents AdapterDetalleVentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextMonto As System.Windows.Forms.TextBox
    Friend WithEvents TextNumero As ValidText.ValidText
    Friend WithEvents ValidText1 As ValidText.ValidText
    Friend WithEvents TextCodigo As System.Windows.Forms.Label
    Friend WithEvents TextDescripcion As System.Windows.Forms.Label
    Friend WithEvents AdapterDetalleDevolucion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterVentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterKardex As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand

    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterOpcionesPago As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtNum_Devo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    'DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ANULADA As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents GroupBox2_1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtFecha As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Id_Articulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_Flete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_Otros As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto_Descuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto_Impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotalGravado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotalExcento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents codArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Codigo_Art As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantVet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCantBod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CantVet2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CantBod2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNum_Caja As ValidText.ValidText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ckpantalla As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adapempaquetado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lbanulado As System.Windows.Forms.Label



    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDevolucionesVentas))
        Dim ColumnFilterInfo33 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo34 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo35 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo36 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo37 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo38 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo39 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo40 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo41 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo42 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo43 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo44 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo45 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo46 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo47 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo48 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.GroupBox1 = New System.Windows.Forms.Panel()
        Me.TextMonto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.DtVence = New System.Windows.Forms.DateTimePicker()
        Me.ComboMoneda = New System.Windows.Forms.ComboBox()
        Me.DataSetDevolucionVentas1 = New LcPymes_5._2.DataSetDevolucionVentas()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextNumero = New ValidText.ValidText()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNum_Caja = New ValidText.ValidText()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2_1 = New System.Windows.Forms.GroupBox()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ValidText1 = New ValidText.ValidText()
        Me.TextDescripcion = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Id_Articulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.codArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ANULADA = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.AdapterDevoluciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterDetalleVentas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterDetalleDevolucion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterVentas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterKardex = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterOpcionesPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtNum_Devo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.dtFecha = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo_Art = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio_Flete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio_Otros = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantVet = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCantBod = New DevExpress.XtraEditors.TextEdit()
        Me.CantVet2 = New DevExpress.XtraEditors.TextEdit()
        Me.CantBod2 = New DevExpress.XtraEditors.TextEdit()
        Me.ckpantalla = New System.Windows.Forms.CheckBox()
        Me.adapempaquetado = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.lbanulado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetDevolucionVentas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantVet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantBod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantVet2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantBod2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
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
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 517)
        Me.ToolBar1.Size = New System.Drawing.Size(881, 57)
        Me.ToolBar1.TabIndex = 0
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(1643, 511)
        Me.DataNavigator.Size = New System.Drawing.Size(189, 24)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(881, 37)
        Me.TituloModulo.Text = "Devoluciones del Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextMonto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.DtVence)
        Me.GroupBox1.Controls.Add(Me.ComboMoneda)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(4, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 131)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.Text = "Factura"
        '
        'TextMonto
        '
        Me.TextMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextMonto.ForeColor = System.Drawing.Color.Blue
        Me.TextMonto.Location = New System.Drawing.Point(278, 102)
        Me.TextMonto.Name = "TextMonto"
        Me.TextMonto.Size = New System.Drawing.Size(144, 23)
        Me.TextMonto.TabIndex = 16
        Me.TextMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(10, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(412, 23)
        Me.txtNombre.TabIndex = 15
        '
        'DtVence
        '
        Me.DtVence.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtVence.Checked = False
        Me.DtVence.CustomFormat = ""
        Me.DtVence.Enabled = False
        Me.DtVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtVence.Location = New System.Drawing.Point(298, 28)
        Me.DtVence.Name = "DtVence"
        Me.DtVence.Size = New System.Drawing.Size(115, 23)
        Me.DtVence.TabIndex = 14
        Me.DtVence.Value = New Date(2006, 3, 15, 10, 56, 38, 537)
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Cod_Moneda", True))
        Me.ComboMoneda.DataSource = Me.DataSetDevolucionVentas1
        Me.ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMoneda.Location = New System.Drawing.Point(77, 102)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(125, 25)
        Me.ComboMoneda.TabIndex = 12
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'DataSetDevolucionVentas1
        '
        Me.DataSetDevolucionVentas1.DataSetName = "DataSetDevolucionVentas"
        Me.DataSetDevolucionVentas1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSetDevolucionVentas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(10, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Moneda"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(298, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(211, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(10, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(412, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextNumero)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtNum_Caja)
        Me.Panel1.Controls.Add(Me.ComboTipo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 55)
        Me.Panel1.TabIndex = 223
        '
        'TextNumero
        '
        Me.TextNumero.FieldReference = Nothing
        Me.TextNumero.Location = New System.Drawing.Point(163, 28)
        Me.TextNumero.MaskEdit = ""
        Me.TextNumero.Name = "TextNumero"
        Me.TextNumero.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TextNumero.Required = False
        Me.TextNumero.ShowErrorIcon = False
        Me.TextNumero.Size = New System.Drawing.Size(123, 23)
        Me.TextNumero.TabIndex = 2
        Me.TextNumero.TabStop = False
        Me.TextNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextNumero.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TextNumero.ValidText = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(115, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 19)
        Me.Label16.TabIndex = 202
        Me.Label16.Text = "Caja"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNum_Caja
        '
        Me.txtNum_Caja.FieldReference = Nothing
        Me.txtNum_Caja.Location = New System.Drawing.Point(115, 28)
        Me.txtNum_Caja.MaskEdit = ""
        Me.txtNum_Caja.Name = "txtNum_Caja"
        Me.txtNum_Caja.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtNum_Caja.Required = False
        Me.txtNum_Caja.ShowErrorIcon = False
        Me.txtNum_Caja.Size = New System.Drawing.Size(39, 23)
        Me.txtNum_Caja.TabIndex = 1
        Me.txtNum_Caja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNum_Caja.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtNum_Caja.ValidText = Nothing
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.Items.AddRange(New Object() {"CON", "CRE", "PVE", "TCO", "TCR", "MCO", "MCR", "APA"})
        Me.ComboTipo.Location = New System.Drawing.Point(10, 28)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(96, 25)
        Me.ComboTipo.TabIndex = 0
        '
        'GroupBox2_1
        '
        Me.GroupBox2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2_1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2_1.Location = New System.Drawing.Point(1008, 277)
        Me.GroupBox2_1.Name = "GroupBox2_1"
        Me.GroupBox2_1.Size = New System.Drawing.Size(86, 175)
        Me.GroupBox2_1.TabIndex = 60
        Me.GroupBox2_1.TabStop = False
        Me.GroupBox2_1.Text = "Artículo"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "Ventas_Detalle.Devoluciones", True))
        Me.TextEdit4.EditValue = ""
        Me.TextEdit4.Location = New System.Drawing.Point(355, 225)
        Me.TextEdit4.Name = "TextEdit4"
        '
        '
        '
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.Enabled = False
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.RoyalBlue)
        Me.TextEdit4.Size = New System.Drawing.Size(77, 21)
        Me.TextEdit4.TabIndex = 211
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "Ventas_Detalle.Cantidad", True))
        Me.TextEdit3.EditValue = ""
        Me.TextEdit3.Location = New System.Drawing.Point(355, 203)
        Me.TextEdit3.Name = "TextEdit3"
        '
        '
        '
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.Enabled = False
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.RoyalBlue)
        Me.TextEdit3.Size = New System.Drawing.Size(77, 21)
        Me.TextEdit3.TabIndex = 210
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "Ventas_Detalle.Descuento", True))
        Me.TextEdit2.EditValue = ""
        Me.TextEdit2.Location = New System.Drawing.Point(125, 249)
        Me.TextEdit2.Name = "TextEdit2"
        '
        '
        '
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.Enabled = False
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.RoyalBlue)
        Me.TextEdit2.Size = New System.Drawing.Size(105, 21)
        Me.TextEdit2.TabIndex = 209
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "Ventas_Detalle.Precio_Unit", True))
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(125, 225)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Enabled = False
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.RoyalBlue)
        Me.TextEdit1.Size = New System.Drawing.Size(105, 21)
        Me.TextEdit1.TabIndex = 208
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(922, 212)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(144, 28)
        Me.SimpleButton1.TabIndex = 207
        Me.SimpleButton1.Text = "Devolución Total"
        Me.SimpleButton1.Visible = False
        '
        'ValidText1
        '
        Me.ValidText1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText1.FieldReference = Nothing
        Me.ValidText1.Location = New System.Drawing.Point(354, 249)
        Me.ValidText1.MaskEdit = ""
        Me.ValidText1.Name = "ValidText1"
        Me.ValidText1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText1.Required = False
        Me.ValidText1.ShowErrorIcon = False
        Me.ValidText1.Size = New System.Drawing.Size(77, 15)
        Me.ValidText1.TabIndex = 206
        Me.ValidText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValidText1.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.ValidText1.ValidText = Nothing
        '
        'TextDescripcion
        '
        Me.TextDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.TextDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetDevolucionVentas1, "Ventas_Detalle.Descripcion", True))
        Me.TextDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDescripcion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextDescripcion.Location = New System.Drawing.Point(10, 185)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(422, 15)
        Me.TextDescripcion.TabIndex = 201
        Me.TextDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextCodigo
        '
        Me.TextCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetDevolucionVentas1, "Ventas_Detalle.CodArticulo", True))
        Me.TextCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodigo.Location = New System.Drawing.Point(125, 203)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(105, 19)
        Me.TextCodigo.TabIndex = 200
        Me.TextCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(240, 249)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 19)
        Me.Label14.TabIndex = 199
        Me.Label14.Text = "Devolución"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(240, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 197
        Me.Label13.Text = "Devoluciones"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(240, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 19)
        Me.Label12.TabIndex = 195
        Me.Label12.Text = "Cant Original"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(10, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 19)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Descuento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(10, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 18)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Precio Unitario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(10, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 185
        Me.Label7.Text = "Código"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridControl1
        '
        Me.GridControl1.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.BackgroundImage = CType(resources.GetObject("GridControl1.BackgroundImage"), System.Drawing.Image)
        Me.GridControl1.DataMember = "Ventas_Detalle"
        Me.GridControl1.DataSource = Me.DataSetDevolucionVentas1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(442, 46)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(432, 203)
        Me.GridControl1.TabIndex = 184
        Me.GridControl1.TabStop = False
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Id_Articulo, Me.codArticulo, Me.colCodigo, Me.colDescripcion})
        Me.BandedGridView1.DetailHeight = 200
        Me.BandedGridView1.GroupPanelText = "Detalle de Factura"
        Me.BandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.OptionsView.ShowNewItemRow = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Artículo que se Pueden Devolver"
        Me.GridBand1.Columns.Add(Me.Id_Articulo)
        Me.GridBand1.Columns.Add(Me.codArticulo)
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 454
        '
        'Id_Articulo
        '
        Me.Id_Articulo.Caption = "id_venta_detalle"
        Me.Id_Articulo.FieldName = "id_venta_detalle"
        Me.Id_Articulo.FilterInfo = ColumnFilterInfo33
        Me.Id_Articulo.Name = "Id_Articulo"
        Me.Id_Articulo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Id_Articulo.SortIndex = 0
        Me.Id_Articulo.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.Id_Articulo.Visible = True
        Me.Id_Articulo.Width = 81
        '
        'codArticulo
        '
        Me.codArticulo.Caption = "Código Artículo"
        Me.codArticulo.FieldName = "CodArticulo"
        Me.codArticulo.FilterInfo = ColumnFilterInfo34
        Me.codArticulo.Name = "codArticulo"
        Me.codArticulo.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.codArticulo.Visible = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo35
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 81
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo36
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 217
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Anulado", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(912, 240)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 18)
        Me.CheckBox1.TabIndex = 211
        Me.CheckBox1.Text = "Anulado"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(941, 148)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 64)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Devolución"
        '
        'ANULADA
        '
        Me.ANULADA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ANULADA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANULADA.ForeColor = System.Drawing.Color.Gainsboro
        Me.ANULADA.Location = New System.Drawing.Point(24018, 10265)
        Me.ANULADA.Name = "ANULADA"
        Me.ANULADA.Size = New System.Drawing.Size(96, 14)
        Me.ANULADA.TabIndex = 214
        Me.ANULADA.Text = "ANULADA"
        Me.ANULADA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ANULADA.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TextEdit10)
        Me.GroupBox4.Controls.Add(Me.TextEdit9)
        Me.GroupBox4.Controls.Add(Me.TextEdit8)
        Me.GroupBox4.Controls.Add(Me.TextEdit7)
        Me.GroupBox4.Controls.Add(Me.TextEdit6)
        Me.GroupBox4.Controls.Add(Me.TextEdit5)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox4.Location = New System.Drawing.Point(7, 450)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(867, 65)
        Me.GroupBox4.TabIndex = 162
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Monto", True))
        Me.TextEdit10.EditValue = "0.00"
        Me.TextEdit10.Location = New System.Drawing.Point(710, 38)
        Me.TextEdit10.Name = "TextEdit10"
        '
        '
        '
        Me.TextEdit10.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit10.Size = New System.Drawing.Size(154, 23)
        Me.TextEdit10.TabIndex = 45
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Impuesto", True))
        Me.TextEdit9.EditValue = "0.00"
        Me.TextEdit9.Location = New System.Drawing.Point(557, 38)
        Me.TextEdit9.Name = "TextEdit9"
        '
        '
        '
        Me.TextEdit9.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit9.Size = New System.Drawing.Size(144, 23)
        Me.TextEdit9.TabIndex = 44
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Descuento", True))
        Me.TextEdit8.EditValue = "0.00"
        Me.TextEdit8.Location = New System.Drawing.Point(413, 38)
        Me.TextEdit8.Name = "TextEdit8"
        '
        '
        '
        Me.TextEdit8.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit8.Size = New System.Drawing.Size(134, 23)
        Me.TextEdit8.TabIndex = 43
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Transporte", True))
        Me.TextEdit7.EditValue = "0.00"
        Me.TextEdit7.Location = New System.Drawing.Point(269, 38)
        Me.TextEdit7.Name = "TextEdit7"
        '
        '
        '
        Me.TextEdit7.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit7.Size = New System.Drawing.Size(134, 23)
        Me.TextEdit7.TabIndex = 42
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.SubTotalExcento", True))
        Me.TextEdit6.EditValue = "0.00"
        Me.TextEdit6.Location = New System.Drawing.Point(144, 38)
        Me.TextEdit6.Name = "TextEdit6"
        '
        '
        '
        Me.TextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit6.Size = New System.Drawing.Size(115, 23)
        Me.TextEdit6.TabIndex = 41
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "devoluciones_ventas.SubTotalGravado", True))
        Me.TextEdit5.EditValue = "0.00"
        Me.TextEdit5.Location = New System.Drawing.Point(8, 38)
        Me.TextEdit5.Name = "TextEdit5"
        '
        '
        '
        Me.TextEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit5.Size = New System.Drawing.Size(126, 23)
        Me.TextEdit5.TabIndex = 40
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(8, 20)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 18)
        Me.Label45.TabIndex = 39
        Me.Label45.Text = "Sub. Gravado"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label42.Location = New System.Drawing.Point(144, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(115, 18)
        Me.Label42.TabIndex = 38
        Me.Label42.Text = "Sub. Exento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(10, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(854, 18)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Totales de Devolución"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(710, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(154, 18)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Total"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(557, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(144, 18)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imp. Venta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(413, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(134, 18)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Descuento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(269, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(134, 18)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Transporte"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(1219, 596)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(211, 15)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(1152, 596)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(67, 15)
        Me.txtUsuario.TabIndex = 1
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(1075, 596)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 15)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterUsuario
        '
        Me.AdapterUsuario.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterUsuario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterUsuario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna")})})
        Me.AdapterUsuario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Usuarios WHERE (Cedula = @Original_Cedula) AND (Clave_Entrada = @Orig" & _
    "inal_Clave_Entrada) AND (Clave_Interna = @Original_Clave_Interna) AND (Nombre = " & _
    "@Original_Nombre)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna FROM Usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.AdapterMoneda.UpdateCommand = Me.SqlUpdateCommand2
        '
        'AdapterDevoluciones
        '
        Me.AdapterDevoluciones.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterDevoluciones.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterDevoluciones.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterDevoluciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "devoluciones_ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Devolucion", "Devolucion"), New System.Data.Common.DataColumnMapping("Id_Factura", "Id_Factura"), New System.Data.Common.DataColumnMapping("SaldoAnt_Fact", "SaldoAnt_Fact"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte")})})
        Me.AdapterDevoluciones.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnt_Fact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 8, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, "SaldoAnt_Fact"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 8, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@SaldoAnt_Fact", System.Data.SqlDbType.Float, 8, "SaldoAnt_Fact"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterDetalleVentas
        '
        Me.AdapterDetalleVentas.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterDetalleVentas.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterDetalleVentas.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterDetalleVentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_venta_detalle", "id_venta_detalle"), New System.Data.Common.DataColumnMapping("Id_Factura", "Id_Factura"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("Numero_Entrega", "Numero_Entrega"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("CantVet", "CantVet"), New System.Data.Common.DataColumnMapping("CantBod", "CantBod"), New System.Data.Common.DataColumnMapping("empaquetado", "empaquetado")})})
        Me.AdapterDetalleVentas.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantBod", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantBod", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantVet", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantVet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero_Entrega", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Entrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_empaquetado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empaquetado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 8, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 8, "Numero_Entrega"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@CantVet", System.Data.SqlDbType.Float, 8, "CantVet"), New System.Data.SqlClient.SqlParameter("@CantBod", System.Data.SqlDbType.Float, 8, "CantBod"), New System.Data.SqlClient.SqlParameter("@empaquetado", System.Data.SqlDbType.Bit, 1, "empaquetado")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 8, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 8, "Numero_Entrega"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@CantVet", System.Data.SqlDbType.Float, 8, "CantVet"), New System.Data.SqlClient.SqlParameter("@CantBod", System.Data.SqlDbType.Float, 8, "CantBod"), New System.Data.SqlClient.SqlParameter("@empaquetado", System.Data.SqlDbType.Bit, 1, "empaquetado"), New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantBod", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantBod", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantVet", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantVet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodArticulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodArticulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero_Entrega", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Entrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_empaquetado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empaquetado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_venta_detalle", System.Data.SqlDbType.BigInt, 8, "id_venta_detalle")})
        '
        'AdapterDetalleDevolucion
        '
        Me.AdapterDetalleDevolucion.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterDetalleDevolucion.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterDetalleDevolucion.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterDetalleDevolucion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos_ventas_devueltos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Devolucion", "Devolucion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Id_Art_Venta", "Id_Art_Venta"), New System.Data.Common.DataColumnMapping("CantVet", "CantVet"), New System.Data.Common.DataColumnMapping("CantBod", "CantBod")})})
        Me.AdapterDetalleDevolucion.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantBod", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantBod", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantVet", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantVet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Art_Venta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Art_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Devolucion", System.Data.SqlDbType.BigInt, 8, "Devolucion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Id_Art_Venta", System.Data.SqlDbType.Int, 4, "Id_Art_Venta"), New System.Data.SqlClient.SqlParameter("@CantVet", System.Data.SqlDbType.Float, 8, "CantVet"), New System.Data.SqlClient.SqlParameter("@CantBod", System.Data.SqlDbType.Float, 8, "CantBod")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Devolucion", System.Data.SqlDbType.BigInt, 8, "Devolucion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 8, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 8, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 8, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 8, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 8, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 8, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 8, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 8, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 8, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Id_Art_Venta", System.Data.SqlDbType.Int, 4, "Id_Art_Venta"), New System.Data.SqlClient.SqlParameter("@CantVet", System.Data.SqlDbType.Float, 8, "CantVet"), New System.Data.SqlClient.SqlParameter("@CantBod", System.Data.SqlDbType.Float, 8, "CantBod"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantBod", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantBod", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CantVet", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantVet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devolucion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devolucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Art_Venta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Art_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
        '
        'AdapterVentas
        '
        Me.AdapterVentas.DeleteCommand = Me.SqlDeleteCommand6
        Me.AdapterVentas.InsertCommand = Me.SqlInsertCommand6
        Me.AdapterVentas.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterVentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Pago_Comision", "Pago_Comision"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("Cod_Encargado_Compra", "Cod_Encargado_Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("AsientoVenta", "AsientoVenta"), New System.Data.Common.DataColumnMapping("ContabilizadoCVenta", "ContabilizadoCVenta"), New System.Data.Common.DataColumnMapping("AsientoCosto", "AsientoCosto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Entregado", "Entregado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Moneda_Nombre", "Moneda_Nombre"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio")})})
        Me.AdapterVentas.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AsientoCosto", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoCosto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AsientoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsientoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Encargado_Compra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContabilizadoCVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Entregado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entregado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FacturaCancelado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FacturaCancelado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Apertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Apertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Factura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Pago_Comision", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pago_Comision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vence", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vence", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.BigInt, 8, "Num_Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 1, "Pago_Comision"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 4, "Vence"), New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, "Cod_Encargado_Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 8, "AsientoVenta"), New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, "ContabilizadoCVenta"), New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 8, "AsientoCosto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 4, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 1, "Entregado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, "Moneda_Nombre"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 15, "Telefono"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 8, "Num_Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 1, "Pago_Comision"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 4, "Vence"), New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, "Cod_Encargado_Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 8, "AsientoVenta"), New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, "ContabilizadoCVenta"), New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 8, "AsientoCosto"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 4, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 1, "Entregado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, "Moneda_Nombre"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 50, "Telefono"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Consecutivo, Codigo, Descripcion, Documento, Tipo, Fecha, Exist_Ant, Canti" & _
    "dad, Exist_Act, Costo_Unit, Costo_Mov, Cod_Proveedor, Cod_Cliente FROM Kardex"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Exist_Ant", System.Data.SqlDbType.Float, 8, "Exist_Ant"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Exist_Act", System.Data.SqlDbType.Float, 8, "Exist_Act"), New System.Data.SqlClient.SqlParameter("@Costo_Unit", System.Data.SqlDbType.Float, 8, "Costo_Unit"), New System.Data.SqlClient.SqlParameter("@Costo_Mov", System.Data.SqlDbType.Float, 8, "Costo_Mov"), New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente")})
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Exist_Ant", System.Data.SqlDbType.Float, 8, "Exist_Ant"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Exist_Act", System.Data.SqlDbType.Float, 8, "Exist_Act"), New System.Data.SqlClient.SqlParameter("@Costo_Unit", System.Data.SqlDbType.Float, 8, "Costo_Unit"), New System.Data.SqlClient.SqlParameter("@Costo_Mov", System.Data.SqlDbType.Float, 8, "Costo_Mov"), New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Proveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo_Mov", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo_Mov", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo_Unit", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exist_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Act", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exist_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Ant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM Kardex WHERE (Consecutivo = @Original_Consecutivo)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterKardex
        '
        Me.AdapterKardex.DeleteCommand = Me.SqlDeleteCommand7
        Me.AdapterKardex.InsertCommand = Me.SqlInsertCommand7
        Me.AdapterKardex.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterKardex.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Kardex", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Exist_Ant", "Exist_Ant"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Exist_Act", "Exist_Act"), New System.Data.Common.DataColumnMapping("Costo_Unit", "Costo_Unit"), New System.Data.Common.DataColumnMapping("Costo_Mov", "Costo_Mov"), New System.Data.Common.DataColumnMapping("Cod_Proveedor", "Cod_Proveedor"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente")})})
        Me.AdapterKardex.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT id, Documento, TipoDocumento, MontoPago, FormaPago, Denominacion, Usuario," & _
    " Nombre, CodMoneda, Nombremoneda, TipoCambio, Fecha, Numapertura FROM OpcionesDe" & _
    "Pago"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = resources.GetString("SqlInsertCommand8.CommandText")
        Me.SqlInsertCommand8.Connection = Me.SqlConnection1
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.Float, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 50, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Float, 8, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 75, "Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Float, 8, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Nombremoneda", System.Data.SqlDbType.VarChar, 50, "Nombremoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Numapertura", System.Data.SqlDbType.Int, 4, "Numapertura")})
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.Float, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 50, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Float, 8, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 75, "Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Float, 8, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Nombremoneda", System.Data.SqlDbType.VarChar, 50, "Nombremoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Numapertura", System.Data.SqlDbType.Int, 4, "Numapertura"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Denominacion", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombremoneda", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombremoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numapertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numapertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDocumento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = resources.GetString("SqlDeleteCommand8.CommandText")
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Denominacion", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombremoneda", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombremoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numapertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numapertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDocumento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterOpcionesPago
        '
        Me.AdapterOpcionesPago.DeleteCommand = Me.SqlDeleteCommand8
        Me.AdapterOpcionesPago.InsertCommand = Me.SqlInsertCommand8
        Me.AdapterOpcionesPago.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterOpcionesPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OpcionesDePago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("TipoDocumento", "TipoDocumento"), New System.Data.Common.DataColumnMapping("MontoPago", "MontoPago"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Denominacion", "Denominacion"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Nombremoneda", "Nombremoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Numapertura", "Numapertura")})})
        Me.AdapterOpcionesPago.UpdateCommand = Me.SqlUpdateCommand8
        '
        'txtNum_Devo
        '
        Me.txtNum_Devo.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Devo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetDevolucionVentas1, "devoluciones_ventas.Devolucion", True))
        Me.txtNum_Devo.Location = New System.Drawing.Point(96, 21)
        Me.txtNum_Devo.Name = "txtNum_Devo"
        Me.txtNum_Devo.Size = New System.Drawing.Size(67, 9)
        Me.txtNum_Devo.TabIndex = 208
        Me.txtNum_Devo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(0, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 14)
        Me.Label11.TabIndex = 209
        Me.Label11.Text = "Devol. N°"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(1434, 595)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(97, 15)
        Me.CheckBox2.TabIndex = 212
        Me.CheckBox2.Text = "Cancelada"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.BackColor = System.Drawing.SystemColors.Control
        Me.dtFecha.Enabled = False
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.ForeColor = System.Drawing.Color.Blue
        Me.dtFecha.Location = New System.Drawing.Point(715, 595)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFecha.Size = New System.Drawing.Size(115, 15)
        Me.dtFecha.TabIndex = 213
        Me.dtFecha.Text = "00/00/0000"
        Me.dtFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 574)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(881, 19)
        Me.StatusBar1.TabIndex = 214
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
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
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 300
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 244
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos"
        Me.GridControl2.DataSource = Me.DataSetDevolucionVentas1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(10, 277)
        Me.GridControl2.MainView = Me.GridView1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(864, 166)
        Me.GridControl2.TabIndex = 215
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo_Art, Me.colCodigo1, Me.colDescripcion1, Me.colCantidad, Me.colPrecio_Flete, Me.colPrecio_Otros, Me.colPrecio_Unit, Me.colMonto_Descuento, Me.colMonto_Impuesto, Me.colSubtotalGravado, Me.colSubTotalExcento, Me.colSubTotal})
        Me.GridView1.DetailHeight = 200
        Me.GridView1.GroupPanelText = "Detalle de Factura"
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowNewItemRow = True
        '
        'Codigo_Art
        '
        Me.Codigo_Art.FilterInfo = ColumnFilterInfo37
        Me.Codigo_Art.Name = "Codigo_Art"
        '
        'colCodigo1
        '
        Me.colCodigo1.Caption = "Codigo"
        Me.colCodigo1.FieldName = "Codigo"
        Me.colCodigo1.FilterInfo = ColumnFilterInfo38
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
        Me.colCodigo1.Width = 68
        '
        'colDescripcion1
        '
        Me.colDescripcion1.Caption = "Descripcion"
        Me.colDescripcion1.FieldName = "Descripcion"
        Me.colDescripcion1.FilterInfo = ColumnFilterInfo39
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
        Me.colDescripcion1.Width = 261
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant Dev"
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo40
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
        Me.colCantidad.Width = 82
        '
        'colPrecio_Flete
        '
        Me.colPrecio_Flete.Caption = "Precio Flete"
        Me.colPrecio_Flete.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Flete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Flete.FieldName = "Precio_Flete"
        Me.colPrecio_Flete.FilterInfo = ColumnFilterInfo41
        Me.colPrecio_Flete.Name = "colPrecio_Flete"
        Me.colPrecio_Flete.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Flete.VisibleIndex = 3
        Me.colPrecio_Flete.Width = 100
        '
        'colPrecio_Otros
        '
        Me.colPrecio_Otros.Caption = "Precio Otros"
        Me.colPrecio_Otros.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Otros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Otros.FieldName = "Precio_Otros"
        Me.colPrecio_Otros.FilterInfo = ColumnFilterInfo42
        Me.colPrecio_Otros.Name = "colPrecio_Otros"
        Me.colPrecio_Otros.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Otros.VisibleIndex = 4
        Me.colPrecio_Otros.Width = 98
        '
        'colPrecio_Unit
        '
        Me.colPrecio_Unit.Caption = "Precio Unit"
        Me.colPrecio_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Unit.FieldName = "Precio_Unit"
        Me.colPrecio_Unit.FilterInfo = ColumnFilterInfo43
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Unit.VisibleIndex = 5
        Me.colPrecio_Unit.Width = 92
        '
        'colMonto_Descuento
        '
        Me.colMonto_Descuento.Caption = "Monto Descuento"
        Me.colMonto_Descuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Descuento.FieldName = "Monto_Descuento"
        Me.colMonto_Descuento.FilterInfo = ColumnFilterInfo44
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Descuento.VisibleIndex = 6
        Me.colMonto_Descuento.Width = 132
        '
        'colMonto_Impuesto
        '
        Me.colMonto_Impuesto.Caption = "Monto Impuesto"
        Me.colMonto_Impuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Impuesto.FieldName = "Monto_Impuesto"
        Me.colMonto_Impuesto.FilterInfo = ColumnFilterInfo45
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Impuesto.VisibleIndex = 7
        Me.colMonto_Impuesto.Width = 103
        '
        'colSubtotalGravado
        '
        Me.colSubtotalGravado.Caption = "Sub-Total Gravado"
        Me.colSubtotalGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubtotalGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotalGravado.FieldName = "SubtotalGravado"
        Me.colSubtotalGravado.FilterInfo = ColumnFilterInfo46
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubtotalGravado.VisibleIndex = 8
        Me.colSubtotalGravado.Width = 112
        '
        'colSubTotalExcento
        '
        Me.colSubTotalExcento.Caption = "Sub-Total Excento"
        Me.colSubTotalExcento.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotalExcento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotalExcento.FieldName = "SubTotalExcento"
        Me.colSubTotalExcento.FilterInfo = ColumnFilterInfo47
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotalExcento.VisibleIndex = 9
        Me.colSubTotalExcento.Width = 113
        '
        'colSubTotal
        '
        Me.colSubTotal.FilterInfo = ColumnFilterInfo48
        Me.colSubTotal.Name = "colSubTotal"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(276, 470)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(31, 18)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton2.TabIndex = 216
        Me.SimpleButton2.Text = "..."
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(442, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 19)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = "Vete:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantVet
        '
        Me.txtCantVet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "Ventas_Detalle.CantVet", True))
        Me.txtCantVet.EditValue = ""
        Me.txtCantVet.Location = New System.Drawing.Point(490, 249)
        Me.txtCantVet.Name = "txtCantVet"
        '
        '
        '
        Me.txtCantVet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCantVet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantVet.Properties.ReadOnly = True
        Me.txtCantVet.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.RoyalBlue)
        Me.txtCantVet.Size = New System.Drawing.Size(48, 21)
        Me.txtCantVet.TabIndex = 218
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(614, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 219
        Me.Label15.Text = "Cant Bod."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantBod
        '
        Me.txtCantBod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "Ventas_Detalle.CantBod", True))
        Me.txtCantBod.EditValue = ""
        Me.txtCantBod.Location = New System.Drawing.Point(700, 249)
        Me.txtCantBod.Name = "txtCantBod"
        '
        '
        '
        Me.txtCantBod.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCantBod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantBod.Properties.ReadOnly = True
        Me.txtCantBod.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.RoyalBlue)
        Me.txtCantBod.Size = New System.Drawing.Size(49, 21)
        Me.txtCantBod.TabIndex = 220
        '
        'CantVet2
        '
        Me.CantVet2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "articulos_ventas_devueltos.CantVet", True))
        Me.CantVet2.EditValue = "0"
        Me.CantVet2.Location = New System.Drawing.Point(547, 249)
        Me.CantVet2.Name = "CantVet2"
        '
        '
        '
        Me.CantVet2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CantVet2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CantVet2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Silver, System.Drawing.Color.RoyalBlue)
        Me.CantVet2.Size = New System.Drawing.Size(48, 21)
        Me.CantVet2.TabIndex = 221
        '
        'CantBod2
        '
        Me.CantBod2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetDevolucionVentas1, "articulos_ventas_devueltos.CantBod", True))
        Me.CantBod2.EditValue = "0"
        Me.CantBod2.Location = New System.Drawing.Point(758, 249)
        Me.CantBod2.Name = "CantBod2"
        '
        '
        '
        Me.CantBod2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CantBod2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CantBod2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Silver, System.Drawing.Color.RoyalBlue)
        Me.CantBod2.Size = New System.Drawing.Size(50, 21)
        Me.CantBod2.TabIndex = 222
        '
        'ckpantalla
        '
        Me.ckpantalla.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetDevolucionVentas1, "Ventas_Detalle.empaquetado", True))
        Me.ckpantalla.Location = New System.Drawing.Point(461, 175)
        Me.ckpantalla.Name = "ckpantalla"
        Me.ckpantalla.Size = New System.Drawing.Size(125, 28)
        Me.ckpantalla.TabIndex = 223
        Me.ckpantalla.Text = "CheckBox3"
        '
        'adapempaquetado
        '
        Me.adapempaquetado.DeleteCommand = Me.SqlCommand1
        Me.adapempaquetado.InsertCommand = Me.SqlCommand2
        Me.adapempaquetado.SelectCommand = Me.SqlCommand3
        Me.adapempaquetado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.adapempaquetado.UpdateCommand = Me.SqlCommand4
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Connection = Me.SqlConnection1
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlCommand3.Connection = Me.SqlConnection1
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
        Me.SqlCommand4.Connection = Me.SqlConnection1
        Me.SqlCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'lbanulado
        '
        Me.lbanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbanulado.ForeColor = System.Drawing.Color.Red
        Me.lbanulado.Location = New System.Drawing.Point(269, 286)
        Me.lbanulado.Name = "lbanulado"
        Me.lbanulado.Size = New System.Drawing.Size(384, 74)
        Me.lbanulado.TabIndex = 224
        Me.lbanulado.Text = "Anulado"
        Me.lbanulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbanulado.Visible = False
        '
        'FrmDevolucionesVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(881, 593)
        Me.Controls.Add(Me.ANULADA)
        Me.Controls.Add(Me.lbanulado)
        Me.Controls.Add(Me.CantBod2)
        Me.Controls.Add(Me.CantVet2)
        Me.Controls.Add(Me.txtCantBod)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCantVet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.txtNum_Devo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2_1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ValidText1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextCodigo)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextDescripcion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ckpantalla)
        Me.MaximumSize = New System.Drawing.Size(899, 640)
        Me.MinimumSize = New System.Drawing.Size(899, 640)
        Me.Name = "FrmDevolucionesVentas"
        Me.Text = "Devoluciones"
        Me.Controls.SetChildIndex(Me.ckpantalla, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.TextDescripcion, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.TextEdit2, 0)
        Me.Controls.SetChildIndex(Me.TextEdit3, 0)
        Me.Controls.SetChildIndex(Me.TextEdit1, 0)
        Me.Controls.SetChildIndex(Me.TextCodigo, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.ValidText1, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TextEdit4, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2_1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtNum_Devo, 0)
        Me.Controls.SetChildIndex(Me.CheckBox2, 0)
        Me.Controls.SetChildIndex(Me.dtFecha, 0)
        Me.Controls.SetChildIndex(Me.GridControl2, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton2, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtCantVet, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txtCantBod, 0)
        Me.Controls.SetChildIndex(Me.CantVet2, 0)
        Me.Controls.SetChildIndex(Me.CantBod2, 0)
        Me.Controls.SetChildIndex(Me.lbanulado, 0)
        Me.Controls.SetChildIndex(Me.ANULADA, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSetDevolucionVentas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantVet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantBod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantVet2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantBod2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Claves Usuario "
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If IsPreDevolucion = True Then

                    If Me.BindingContext(Me.DataSetDevolucionVentas1.Usuarios).Count > 0 Then
                        Dim Usuario_autorizadores() As System.Data.DataRow
                        Dim Usua As System.Data.DataRow
                        Usuario_autorizadores = Me.DataSetDevolucionVentas1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                        If Usuario_autorizadores.Length <> 0 Then
                            Usua = Usuario_autorizadores(0)

                            PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                            'If Not PMU.Execute Then MsgBox("No tiene permiso de acceso en el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                            txtNombreUsuario.Text = Usua("Nombre")
                            Me.Cedula_usuario = Usua("Cedula")
                            txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                            HabilitarControlesDevolucion()
                            Agregar()
                            Me.txtUsuario.Enabled = False

                            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()
                            Me.DataSetDevolucionVentas1.devoluciones_ventas.Clear()
                            Me.DataSetDevolucionVentas1.Ventas_Detalle.Clear()
                            Me.DataSetDevolucionVentas1.Ventas.Clear()

                            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").CancelCurrentEdit()

                            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()
                            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").AddNew()
                            Me.ComboTipo.Focus()
                        Else ' si no existe una contraseñla como esta
                            MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                            txtUsuario.Text = ""
                        End If
                    Else
                        MsgBox("No Existen Usuarios,ingrese datos")
                    End If

                Else

                    If Me.BindingContext(Me.DataSetDevolucionVentas1.Usuarios).Count > 0 Then
                        Dim Usuario_autorizadores() As System.Data.DataRow
                        Dim Usua As System.Data.DataRow
                        Usuario_autorizadores = Me.DataSetDevolucionVentas1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                        If Usuario_autorizadores.Length <> 0 Then
                            Usua = Usuario_autorizadores(0)

                            PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                            If Not PMU.Execute Then MsgBox("No tiene permiso de acceso en el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                            txtNombreUsuario.Text = Usua("Nombre")
                            Me.Cedula_usuario = Usua("Cedula")
                            txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                            HabilitarControlesDevolucion()
                            Agregar()
                            Me.txtUsuario.Enabled = False

                            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()
                            Me.DataSetDevolucionVentas1.devoluciones_ventas.Clear()
                            Me.DataSetDevolucionVentas1.Ventas_Detalle.Clear()
                            Me.DataSetDevolucionVentas1.Ventas.Clear()

                            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").CancelCurrentEdit()

                            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()
                            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").AddNew()
                            Me.ComboTipo.Focus()
                        Else ' si no existe una contraseñla como esta
                            MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                            txtUsuario.Text = ""
                        End If
                    Else
                        MsgBox("No Existen Usuarios,ingrese datos")
                    End If

                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "Control Controles"
    Function InHabilitarControlesDevolucion()
        ComboTipo.Enabled = False
        TextNumero.Enabled = False
        txtNombre.Enabled = False
        TextMonto.Enabled = False
        DtVence.Enabled = False
        ComboMoneda.Enabled = False
    End Function
    Function HabilitarControlesDevolucion()
        ComboTipo.Enabled = True
        TextNumero.Enabled = True
        'txtNombre.Enabled = True
        'TextMonto.Enabled = True
        'DtVence.Enabled = True
        'ComboMoneda.Enabled = True
    End Function

    Function InHabilitarControlesDetalleventas()
        'TextCodigo.ReadOnly = True
        'TextDescripcion.ReadOnly = True
        'TextPrecioUnitario.ReadOnly = True
        'TextDescuento.ReadOnly = True
        'TextCantidadOriginal.ReadOnly = True
        'TextDevoluciones.ReadOnly = True
        'TextDevolucion.ReadOnly = True
    End Function
    Function HabilitarControlesDetalleventas()
        'TextDevolucion.ReadOnly = False
    End Function


    Function InhabilitarBotones()
        Me.ToolBar1.Buttons(0).Enabled = False
        Me.ToolBar1.Buttons(1).Enabled = False
        Me.ToolBar1.Buttons(2).Enabled = False
        Me.ToolBar1.Buttons(3).Enabled = False
        Me.ToolBar1.Buttons(4).Enabled = False
    End Function

    Function HabilitarBotones()
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(1).Enabled = True
        Me.ToolBar1.Buttons(2).Enabled = True
        Me.ToolBar1.Buttons(3).Enabled = True
        Me.ToolBar1.Buttons(4).Enabled = True
    End Function
#End Region

#Region "Codigo General"

    Public IsPreDevolucion As Boolean = False

    Private Sub FrmDevolucionesVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS()

            Me.AdapterOpcionesPago.InsertCommand.Connection.ConnectionString = Me.AdapterOpcionesPago.InsertCommand.Connection.ConnectionString.Replace("Taller", "SeePOS")
            Me.AdapterOpcionesPago.UpdateCommand.Connection.ConnectionString = Me.AdapterOpcionesPago.UpdateCommand.Connection.ConnectionString.Replace("Taller", "SeePOS")
            Me.AdapterOpcionesPago.DeleteCommand.Connection.ConnectionString = Me.AdapterOpcionesPago.DeleteCommand.Connection.ConnectionString.Replace("Taller", "SeePOS")

            Me.AdapterUsuario.Fill(Me.DataSetDevolucionVentas1.Usuarios)
            Me.AdapterMoneda.Fill(Me.DataSetDevolucionVentas1.Moneda)

            Me.DataSetDevolucionVentas1.devoluciones_ventas.DevolucionColumn.AutoIncrement = True
            Me.DataSetDevolucionVentas1.devoluciones_ventas.DevolucionColumn.AutoIncrementSeed = -1
            Me.DataSetDevolucionVentas1.devoluciones_ventas.DevolucionColumn.AutoIncrementStep = -1

            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.ConsecutivoColumn.AutoIncrement = True
            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.ConsecutivoColumn.AutoIncrementSeed = -1
            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.ConsecutivoColumn.AutoIncrementStep = -1

            'Valores por defecto Devoluciones de ventas
            Me.DataSetDevolucionVentas1.devoluciones_ventas.SubTotalExcentoColumn.DefaultValue = "0"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.SubTotalGravadoColumn.DefaultValue = "0"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.DescuentoColumn.DefaultValue = "0"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.ImpuestoColumn.DefaultValue = "0"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.MontoColumn.DefaultValue = "0"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.TransporteColumn.DefaultValue = "0"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.ContabilizadoColumn.DefaultValue = "FALSE"
            Me.DataSetDevolucionVentas1.devoluciones_ventas.AnuladoColumn.DefaultValue = "FALSE"
            '   InhabilitarBotones()
            InHabilitarControlesDetalleventas()
            Me.InHabilitarControlesDevolucion()
            txtUsuario.Focus()
            ValidText1.Enabled = False
            Me.SimpleButton1.Enabled = False
            ' Me.dtFecha.EditValue = Now.Date
            Me.dtFecha.Text = Now.Date
        Catch ex As SystemException
            MsgBox("Ha Habido un problema de comunicacion con el servidor por favor reinicie el formulario!", MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub


    Function BindingDetalleVentas()
        Me.TextCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetDevolucionVentas1, "Ventas_Detalle.Codigo"))
    End Function

#End Region

#Region "Codigo Devolucion"
    Function Agregar()
        Me.ANULADA.Visible = False
        Me.ToolBar1.Buttons(0).Text = "Cancelar"
        Me.ToolBar1.Buttons(0).ImageIndex = 8
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(1).Enabled = False
        Me.ToolBar1.Buttons(2).Enabled = True
        Me.ToolBar1.Buttons(3).Enabled = False
        Me.ToolBar1.Buttons(4).Enabled = False
        Me.txtUsuario.Enabled = True
        Me.txtUsuario.Focus()
    End Function

    Private Sub TextNumero_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextNumero.KeyDown
        Dim Num_Fatura As String
        Dim Cfunciones As New cFunciones
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Dim Venta As DataTable
        Dim identificador As Double
        Try
            If e.KeyCode = Keys.F1 Then

                identificador = CDbl(Cfunciones.Buscar_X_Descripcion_Fecha("Select Id, cast(num_factura as varchar) + '-' + TIPO as Factura, Nombre_Cliente as Cliente,Fecha from Ventas where Anulado = 0 Order by Fecha DESC", "Cliente", "Fecha", "Buscar Factura de Venta"))
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Tipo, Num_Factura, Num_Caja from Ventas where Id =" & identificador)
                If rs.HasRows = False Then
                    MsgBox("La Factura no esta digitada", MsgBoxStyle.Information, "Atención...")
                    TextNumero.Focus()
                End If
                While rs.Read
                    Try
                        TextNumero.Text = rs("Num_Factura")
                        ComboTipo.Text = rs("Tipo")
                        Me.Caja_Factura = rs("Num_Caja")
                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
                'si esta venta aun no ha sido anulada
            End If
            If e.KeyCode = Keys.Enter Then
                If ValidarBusqueda() Then
                    LLenarFactura(CDbl(TextNumero.Text), ComboTipo.Text, Me.txtNum_Caja.Text)
                    If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Count > 0 Then
                        If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CON" And Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = False Then
                            MsgBox("Esta factura de CONTADO no ha sido Pagada, No se puede devolver", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Anulado") = True Then
                            MsgBox("La Factura Nª " & TextNumero.Text & " ha sido anulada, no se pueden hacer devoluciones", MsgBoxStyle.Information)
                            Me.DataSetDevolucionVentas1.Ventas.Clear()
                            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()

                            Exit Sub
                        End If
                    End If
                    If Me.DataSetDevolucionVentas1.Ventas.Rows.Count > 0 Then
                        IniciarEdiconDevolucion()
                        Me.InHabilitarControlesDevolucion()
                    Else
                        MsgBox("La Factura Nª " & TextNumero.Text & "  no se encuentra registrada en el sistema ", MsgBoxStyle.Information, "Atención...")
                    End If
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Function IniciarEdiconDevolucion() As Boolean
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Id_Factura") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Id")
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("SaldoAnt_Fact") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Total")
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Fecha") = Now
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Cedula_Usuario") = Cedula_usuario
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Cod_Moneda") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Cod_Moneda")
        Me.BindingContext(Me.DataSetDevolucionVentas1.devoluciones_ventas).EndCurrentEdit()
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").AddNew()
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").CancelCurrentEdit()
        Me.LlenarVentasDetalle(Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Id").ToString)
        HabilitarControlesDetalleventas()
        txtNombre.Text = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Nombre_Cliente").ToString
        TextMonto.Text = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Total").ToString
        CheckBox2.Checked = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("FacturaCancelado")
        DtVence.Value = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Fecha")
        '   Aqui tengo que areglar lo de meneda 
        'ComboMoneda.Text = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Cod_Moneda")

        If Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Tipo").ToString = "CON" Then
            MsgBox("La factura fue pagada en EFECTIVO", MsgBoxStyle.Information, "Atención.......")
        End If
        ValidText1.Enabled = True
        Me.SimpleButton1.Enabled = True
    End Function

    Function LLenarFactura(ByVal Num_Factura As Double, ByVal Tipo As String, ByVal _Caja As String)
        Dim cnn As SqlConnection = Nothing
        Try
            Me.DataSetDevolucionVentas1.Ventas.Clear()
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Ventas WHERE (Tipo = @Tipo) AND (Num_Factura = @Num_Factura) and (Num_Caja = " & _Caja & ")"

            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar))
            cmd.Parameters.Add(New SqlParameter("@Num_Factura", SqlDbType.BigInt))
            'cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
            'cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.Int))
            cmd.Parameters("@Tipo").Value = Tipo
            cmd.Parameters("@Num_Factura").Value = Num_Factura
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(Me.DataSetDevolucionVentas1.Ventas)

            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Num_Caja from ventas where id = " & Me.DataSetDevolucionVentas1.Ventas(0).Id, dts, CadenaConexionSeePOS)
            If dts.Rows.Count > 0 Then
                Me.Caja_Factura = dts.Rows(0).Item("Num_Caja")
            End If

        Catch ex As System.Exception

        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function

    Function LimpiarFactura()
        Me.DataSetDevolucionVentas1.Ventas.Clear()
    End Function

#End Region

#Region "Ventas Detalles"
    Function LlenarVentasDetalle(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Ventas_Detalle WHERE (Id_Factura = @Id_Factura) "
            '"SELECT * FROM Ventas WHERE (Tipo = @Tipo) AND (Num_Factura = @Num_Factura)"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            'cmd.Parameters.Add(New SqlParameter("@Num_Factura", SqlDbType.BigInt))
            cmd.Parameters("@Id_Factura").Value = Id
            'cmd.Parameters("@Num_Factura").Value = Num_Factura
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DataSetDevolucionVentas1.Ventas_Detalle)
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
    End Function
    Function LimpiarVentasDetalle()
        Me.DataSetDevolucionVentas1.Ventas_Detalle.Clear()
    End Function
#End Region

#Region "BuscarFactura"
    Function BuscarFactura(ByVal Num_Factura As String, ByVal Tipo As String) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = CadenaConexionSeePOS
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Ventas WHERE (Tipo = @Tipo) AND (Num_Factura = @Num_Factura)"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar))
            cmd.Parameters.Add(New SqlParameter("@Num_Factura", SqlDbType.BigInt))
            'cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
            'cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.Int))
            cmd.Parameters("@Tipo").Value = Tipo
            cmd.Parameters("@Num_Factura").Value = Num_Factura
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(dt)
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
        '
        ' Devolvemos el objeto DataTable con los datos de la consulta
        Return dt

    End Function

#End Region

#Region "Detalle Devolucion"
    Private Sub ValidText1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ValidText1.KeyDown
        Dim resp As Integer
        Dim Cancelar As Double

        If e.KeyCode = Keys.Enter Then
            If Me.ValidText1.Text.Length > 0 Then
                Cancelar = CDbl(ValidText1.Text)
                If VerificaSiConsigna(TextCodigo.Text) = True Then
                    MessageBox.Show("Digite las cantidades a devolver!", "Devoluciones", MessageBoxButtons.OK)
                    CantBod2.Focus()
                Else
                    If Cancelar > 0 Then
                        resp = MessageBox.Show("¿Desea que la información sea enviada al detalle de la Devolución?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                        If resp = 6 Then
                            CantVet2.Text = ValidText1.Text
                            IniciarEdionDetalleDevolucion()
                        End If

                    End If
                End If
            Else
                MsgBox("Debes digitar una cantidad mayor que 0", MsgBoxStyle.Information, "Atencion...............")

            End If
        End If
    End Sub

    Private Function VerificaSiConsigna(ByVal codigo As String, Optional ByVal recargar As Boolean = False)
        Try
            Dim rs As SqlDataReader

            If codigo <> Nothing Or codigo <> "" Then
                sqlConexion = CConexion.Conectar

                'rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, (Case When Consignacion = 1 Then ExistenciaBodega Else Existencia END) AS Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "'")
                rs = CConexion.GetRecorset(sqlConexion, "SELECT consignacion from inventario WHERE (Inhabilitado = 0) and Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "'")

                While rs.Read
                    Try

                        consignado = rs("consignacion")

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        CConexion.DesConectar(CConexion.sQlconexion)
                    End Try
                End While
                rs.Close()
                Return consignado
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function




    Function IniciarEdionDetalleDevolucion() As Boolean

        Dim Devolucion As Double = CDbl(Me.ValidText1.Text)
        Dim Devoluciones As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Devoluciones")
        Dim Cantidad As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Cantidad")
        If Me.CantBod2.Text = "" Then CantBod2.Text = 0
        If Me.CantVet2.Text = "" Then CantVet2.Text = 0
        Dim CantVet As Double = CDbl(Me.CantVet2.Text)
        Dim CantBod As Double = CDbl(Me.CantBod2.Text)
        Dim Disponible = Cantidad - Devoluciones
        Dim Id_Art As String = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("id_venta_detalle")
        Dim Codigo As Long = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Codigo")
        Dim Descripcion As String = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Descripcion")
        Dim Precio_Costo As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Precio_Costo")
        Dim Precio_Base As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Precio_Base")
        Dim Precio_Flete As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Precio_Flete")
        Dim Precio_Otros As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Precio_Otros")
        Dim Precio_Unit As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Precio_Unit")
        Dim Descuento As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Descuento")
        Dim Monto_Descuento As Double
        Dim Impuesto As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Impuesto")
        Dim Monto_Impuesto As Double
        Dim SubtotalGravado As Double
        Dim SubTotalExcento As Double
        Dim SubTotal As Double

        'Diego
        'txtCantVet.Text = CantVet : txtCantBod.Text = CantBod
        '*****************************************************************************************************************
        '*************************************Calculo Monto Descuento***********************************************************
        '*****************************************************************************************************************
        Monto_Descuento = (CDbl(Precio_Unit) * CDbl(Devolucion)) * (CDbl(Descuento) / 100)

        '*****************************************************************************************************************
        '*************************************Calculo Exento Gravado***********************************************************
        '*****************************************************************************************************************

        If Impuesto <> 0 Then 'si tiene impuesto de venta
            SubtotalGravado = ((CDbl(Precio_Unit) - CDbl(Precio_Flete) - CDbl(Precio_Otros)) * CDbl(Devolucion)) '- Monto_Descuento JCGA 25 DE AGOSTO
            Monto_Impuesto = (SubtotalGravado - Monto_Descuento) * (CDbl(Impuesto) / 100)
        Else 'si no tiene impuesto de venta
            SubTotalExcento = ((CDbl(Precio_Unit) - CDbl(Precio_Flete) - CDbl(Precio_Otros)) * CDbl(Devolucion)) '- Monto_Descuento JCGA 25 DE AGOSTO
            SubtotalGravado = 0
            Monto_Impuesto = 0
        End If

        SubTotalExcento = SubTotalExcento + ((CDbl(Precio_Flete) + CDbl(Precio_Otros)) * CDbl(Devolucion))

        '*****************************************************************************************************************
        '************************************* Detalle de Devoluciones ***************************************************
        '*****************************************************************************************************************
        SubTotal = SubtotalGravado + SubTotalExcento
        'If Devolucion <> (CantVet + CantBod) Then
        '    MsgBox("Revise la Cantidad de Veterinaria y Bodega porque no suma la cantidad de la Devolución", MsgBoxStyle.Exclamation, "Atención...")
        '    Exit Function
        'End If
        If (Disponible >= Devolucion) And (Disponible >= (CantVet + CantBod)) Then
            Try
                'Actualizo el detalle de ventas y empaquetado
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("Devoluciones") += Devolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").Current("empaquetado") = 0
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas_Detalle").EndCurrentEdit()
                '********************************************************************************************************************************
                '******************************************************DETALLE DE DEVOLUCIONES***************************************************
                '********************************************************************************************************************************
                'Inicio un nuevo detalle de devoluciones
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").AddNew()
                'Asignarlos Valores  Al detalle de devolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Id_Art_Venta") = Id_Art

                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Codigo") = Codigo
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Descripcion") = Descripcion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Cantidad") = Devolucion

                'controla que Devuelta primero a la bodega y luego al inventario
                'Esto ya no porque el usuario va escoger que devuelve a cada bodega.
                'If Devolucion <= CantBod Then
                '    'si la cantidad a devolver es menor al total de los articulos en bodega entonces lo guardo en la bodega
                '    Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("CantBod") = Devolucion
                '    Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("CantVet") = txtCantVet.Text
                'Else
                '    'si la cantidad de articulos a devolver es mayor a la cantidad en bodega se deja la bodega con el numero max y se devuelve el resto a invetario
                '    Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("CantBod") = CantBod
                '    Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("CantVet") = Devolucion - CantBod
                'End If
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("CantBod") = CantBod
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("CantVet") = CantVet
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Costo") = Precio_Costo
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Base") = Precio_Base
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Flete") = Precio_Flete
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Otros") = Precio_Otros
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Unit") = Precio_Unit
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Descuento") = Descuento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Monto_Descuento") = Monto_Descuento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Impuesto") = Impuesto
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Monto_Impuesto") = Monto_Impuesto
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("SubtotalGravado") = SubtotalGravado
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("SubTotalExcento") = SubTotalExcento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("SubTotal") = SubTotal
                'Final un nuevo detalle de devoluciones
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").EndCurrentEdit()
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").AddNew()
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").CancelCurrentEdit()
                'Agregar los Subtotales al DEVOLUCIONES
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") += (SubTotal + Monto_Impuesto - Monto_Descuento)
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("SubTotalGravado") += SubtotalGravado
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("SubTotalExcento") += SubTotalExcento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Descuento") += Monto_Descuento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Impuesto") += Monto_Impuesto
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Se ha superado la venta original que registra esta factura", MsgBoxStyle.Exclamation, "Atención..............")
        End If

    End Function





    Function BuscarExistenciaActualArticulo(ByVal Codigo As String) As Double

        Return 0
    End Function





    Function ReglaTres(ByVal Monto As Double, ByVal Cantidad_Original As Double, ByVal Nueva_Cantidad As Double) As Double
        Dim Calculo As Double
        Calculo = (Monto / Cantidad_Original) * Nueva_Cantidad
        Return Calculo
    End Function
#End Region

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        If Me.DataSetDevolucionVentas1.Ventas_Detalle.Count > 0 Then
            Me.ValidText1.Text = "1"
            Me.ValidText1.Focus()
        End If
    End Sub

    Private Sub BuscarDevolucion()
        Dim Fx As New cFunciones
        Dim identificador As Double
        Try
            lbanulado.Visible = False
            Me.DataSetDevolucionVentas1.Ventas.Clear()
            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()
            Me.DataSetDevolucionVentas1.devoluciones_ventas.Clear()
            Me.txtUsuario.Enabled = False

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT  dbo.devoluciones_ventas.Devolucion, dbo.Ventas.Nombre_Cliente, dbo.devoluciones_ventas.Fecha FROM dbo.devoluciones_ventas INNER JOIN dbo.Ventas ON dbo.devoluciones_ventas.Id_Factura = dbo.Ventas.Id Order by dbo.devoluciones_ventas.Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Devolución de Venta"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            Me.LlenarVentas(identificador)
            Me.llenarVentasOpcionesdePago(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Id_Factura"))
            'si esta venta aun no ha sido lbanulado
            If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Anulado") = False Then
                Me.ToolBar1.Buttons(3).Enabled = True
            Else
                Me.lbanulado.Visible = True
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
            End If

            'Me.GridControl2.Enabled = False
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Function LlenarVentas(ByVal Id As Double)

        Dim cConexion As New Conexion
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim rs As SqlDataReader

        Dim IdDevolucion As Long
        'Dentro de un Try/Catch por si se produce un error
        Try
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            '*********************LLENAMOS DEVOLUCIONES DE VENTA***********************
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM devoluciones_ventas WHERE (Devolucion = @Id_Factura)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            cmdv.Parameters("@Id_Factura").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSetDevolucionVentas1, "devoluciones_ventas")

            '**********************LLENAR DETALLES DE DEVOLUCIONES**************************
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM articulos_ventas_devueltos WHERE (Devolucion = @Id_Factura) "
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
            da.Fill(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)

            'Datos de la Factura
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT  dbo.Ventas.Num_Factura, dbo.Ventas.Tipo, dbo.Ventas.Nombre_Cliente, dbo.Ventas.Total, dbo.Ventas.Cod_Moneda, dbo.devoluciones_ventas.Devolucion FROM dbo.Ventas INNER JOIN dbo.devoluciones_ventas ON dbo.Ventas.Id = dbo.devoluciones_ventas.Id_Factura where dbo.devoluciones_ventas.Devolucion =" & txtNum_Devo.Text)
            If rs.HasRows = False Then
                MsgBox("No hay datos de la factura, Pongase en contacto con SeeSoft", MsgBoxStyle.Information, "Atención...")
            End If
            While rs.Read
                Try
                    ComboTipo.Text = rs("Tipo")
                    TextNumero.Text = rs("Num_Factura")
                    txtNombre.Text = rs("Nombre_Cliente")
                    TextMonto.Text = rs("Total")
                    'ComboMoneda.SelectedItem = CDbl(rs("Cod_Moneda"))
                    'ComboMoneda.SelectedValue = CInt(rs("Cod_Moneda"))
                    'ComboMoneda.ValueMember = rs("Cod_Moneda")

                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
            End While
            rs.Close()
            cConexion.DesConectar(cConexion.sQlconexion)
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

    Function imprimir(ByVal Num_Devo As Long)
        If Me.IsPreDevolucion = True Then

            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

            Prerecibo_reportePVE.SetParameterValue(0, CDbl(Num_Devo))
            CrystalReportsConexion.LoadReportViewer(Nothing, Prerecibo_reportePVE, True, CadenaConexionSeePOS)
            Prerecibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)

            If MsgBox("Desea imprimir una copia de la devolucion", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Prerecibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If

        Else


            Dim opcaja As New frmOpcionCaja

            Dim Recibo_reporte As New ReporteDevolucionesVentas

            Dim visor As New frmVisorReportes
            If MessageBox.Show("¿Desea Imprimir en Grande?", "Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Recibo_reporte.SetParameterValue(0, CDbl(Num_Devo))
                CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Recibo_reporte)
                visor.rptViewer.Visible = True
                Recibo_reporte = Nothing
                visor.ShowDialog()
            Else
                opcaja.Text = "Elija a la caja que desea mandar la impresión"
                opcaja.ShowDialog()
                If opcaja.Caja = 1 Then
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
                    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                    recibo_reportePVE.SetParameterValue(0, CDbl(Num_Devo))
                    CrystalReportsConexion.LoadReportViewer(Nothing, recibo_reportePVE, True, CadenaConexionSeePOS)
                    recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)

                    If MsgBox("Desea imprimir una copia de la devolucion", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                        recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If

                Else
                    opcaja.Caja = 2
                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                    recibo_reportePVE.SetParameterValue(0, CDbl(Num_Devo))
                    CrystalReportsConexion.LoadReportViewer(Nothing, recibo_reportePVE, True, CadenaConexionSeePOS)
                    recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    If MsgBox("Desea imprimir una copia de la devolucion", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                        recibo_reportePVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    End If
                End If
            End If
        End If
    End Function
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
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then Agregar() Else Cancelar()
            Case 2 : If PMU.Find Then Me.BuscarDevolucion() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3
                If Me.IsPreDevolucion = False Then
                    If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Else
                    Registrar()
                    Exit Sub
                End If
            Case 4 : If PMU.Delete Then AnularDevolucion() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then imprimir(txtNum_Devo.Text) Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub
#Region "REGISTRO DE ANULACIONES DE DEVOLUCIONES"
    Function Anular_Detalle(ByVal Id As Long) As Boolean
        '--------------------------------------------------------------------------------------------
        ' SE DISPARA DESENCADENADOR QUE REGISTRA EN EL KARDEX LA ANULACION DE LA DEVOLUCION         ' 
        ' SE PROCEDE A RECORRER Y ACTUALIZAR LA EXISTENCIA DE INVENTARIO Y A REVERTIR EL CONTADOR   '
        ' DE DEVOLUCIONES DE LA TABLA DE VENTAS_DETALLE.                                            '
        ' JSA : 31102006 2350                                                                       '
        '--------------------------------------------------------------------------------------------
        Try
            Dim i As Integer
            Dim Funciones As New Conexion
            For i = 0 To Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Count - 1
                Funciones.UpdateRecords("Ventas_Detalle", "Devoluciones = Devoluciones -" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Cantidad"), "Id_Factura =" & Id & " AND id_venta_detalle =" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("id_art_venta"))
                '**************************************************************
                'JCGA 02 DE AGOSTO 2007, PARA ACTUALIZAR LOS DATOS EN EL INVENTARIO SE ESTABA TOMANDO A LA VARIABLE ID 
                'EN VEZ DEL CODIGO DEL ARTICULO.
                'dim CodigoArticulo as Long = Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Codigo")
                'Funciones.UpdateRecords("Inventario", "Existencia = Existencia -" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Cantidad"), "Codigo =" & CodigoArticulo)
                '**************************************************************
            Next
            Return True

        Catch ex As SystemException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Registrar_Anulacion_Devolucion() As Boolean
        Try
            Dim Funciones As New Conexion
            'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Anulado") = True
            'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()
            'Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1, "devoluciones_ventas")
            Funciones.UpdateRecords("devoluciones_ventas", "Anulado = 1", "Devolucion =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            Return True
        Catch ex As SystemException
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
    Function CambiosOpcionPago() As Boolean
        Dim cconexion As New Conexion
        Dim Funciones As New Conexion
        Dim sqlconexion As New System.Data.SqlClient.SqlConnection
        Dim rs As System.Data.SqlClient.SqlDataReader
        Dim Campos, Datos As String

        Try
            sqlconexion = cconexion.Conectar("SeePos")
            rs = cconexion.GetRecorset(sqlconexion, "SELECT Cedula, Nombre, NApertura  FROM AperturaCaja WHERE Estado = 'A' AND Anulado = 0 and Num_Caja = " & Caja_Factura)

            If rs.Read Then
                '***********************SI LA VENTA YA FUE PAGADA CAMBIAR OPCIONES DE PAGO**************************
                If Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("FacturaCancelado") = True Then

                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").CancelCurrentEdit()
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").AddNew()
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Documento") = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("TipoDocumento") = "DVA"
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("MontoPago") = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("FormaPago") = "EFE"
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Denominacion") = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Usuario") = rs("Cedula")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Nombre") = rs("Nombre")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("CodMoneda") = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Cod_Moneda")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Nombremoneda") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Moneda_Nombre")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("TipoCambio") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Tipo_Cambio")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Fecha") = Format(Now, "dd/MM/yyyy H:mm:ss")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Numapertura") = rs("NApertura")
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").AddNew()
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").CancelCurrentEdit()
                    Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
                    'Funciones.UpdateRecords("OpcionesDePago", "FormaPago = 'ANU'", "Documento = " & txtNum_Devo.Text & " AND TipoDocumento = 'DVE'")
                End If
                Return True
            Else
                MsgBox("No hay apertura de caja!!", MsgBoxStyle.Exclamation, "SeeSoft")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            rs.Close()
            cconexion.DesConectar(cconexion.sQlconexion)
        End Try
    End Function

    Private Sub AnularDevolucion()
        Try
            Dim id_fac As Long
            'Dim Opcion_Devolucion As New Opciones_Devolucion
            id_fac = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Id_Factura")

            Dim frm As New frmOpcionCaja
            frm.ShowDialog()
            Me.Caja_Factura = frm.Caja

            If CajaAbierta(Caja_Factura) = False Then
                MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea Anular esta Devolución de Ventas?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
                Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction

                Me.AdapterDevoluciones.UpdateCommand.Transaction = Trans
                Me.AdapterOpcionesPago.UpdateCommand.Transaction = Trans
                Me.AdapterOpcionesPago.InsertCommand.Transaction = Trans


                Try
                    If Me.Anular_Detalle(id_fac) And Registrar_Anulacion_Devolucion() And CambiosOpcionPago() Then
                        Me.DataSetDevolucionVentas1.AcceptChanges()

                        Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()
                        Me.DataSetDevolucionVentas1.devoluciones_ventas.Clear()
                        Me.DataSetDevolucionVentas1.Ventas.Clear()

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.VolverEstadonormal()
                        Me.ToolBarRegistrar.Enabled = False
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarEliminar.Enabled = False
                        Me.ToolBarImprimir.Enabled = False
                    End If
                    Trans.Commit()
                    MsgBox("La Devolución ha sido anulada satisfactoriamente...", MsgBoxStyle.Information, "Atención...")

                Catch ex As SystemException
                    Trans.Rollback()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta...")
                End Try
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Function llenarVentasOpcionesdePago(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        Try
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Ventas WHERE Id = @Id"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
            cmd.Parameters("@Id").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DataSetDevolucionVentas1.Ventas)
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
    End Function

    Private Num_Caja As Integer = 0
    Private Num_Apertura As Integer = 0

    Private Function CajaAbierta(ByVal _caja As Integer) As Boolean
        Try
            Dim Cadena As String = CadenaConexionSeePOS.ToLower.Replace("taller", "seepos")
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * from aperturacaja where estado = 'A' and anulado = 0 and num_caja = " & _caja, dts, Cadena)
            If dts.Rows.Count > 0 Then
                Me.Num_Apertura = dts.Rows(0).Item("NApertura")
                Return True
            Else
                Me.Num_Apertura = 0
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            Return False
        End Try
    End Function

    Private Caja_Factura As Integer = 0

    Private Function FacturaElectronica() As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select FacturaElectronica From configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("FacturaElectronica")
        Else
            Return False
        End If
    End Function

    Private esFirmadoContado As Boolean = False
    Public MontoDevolucion As Decimal = 0
    Private Function PasaFirmadoContado(_Id As String, _Devolucion As Decimal) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from AutorizacionVenta where Id_Factura = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim frm As New frmSaldoFirmadoContado
            frm.Id_Factura = _Id
            frm.Devolucion = _Devolucion
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If CDec(frm.txtSaldoPendiente.Text) < 0 Then
                    Me.MontoDevolucion = (CDec(frm.txtSaldoPendiente.Text) * -1)
                Else
                    Me.MontoDevolucion = 0
                End If
                Return True
            Else
                Me.MontoDevolucion = 0
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private UsuarioRecibo As String = ""
    Private NotasDevolucion As String = ""

    Private Function EncargadoRecibo() As Boolean
        Dim frm As New frmSeleccionarEncargadoDevolucion
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.UsuarioRecibo = frm.cboEncargado.Text
            Me.NotasDevolucion = frm.txtNotasDevolucion.Text
            Return True
        End If
        Me.UsuarioRecibo = ""
        Me.NotasDevolucion = ""
        Return False
    End Function

    Private OpcionDevolucion As Tipo = Tipo.Efectivo
    Private CedulaCliente As String = ""
    Private NombreCliente As String = ""
    Private CuentaCliente As String = ""
    Private CodCliente As Long = 0
    Private BanderaYaMarco As Boolean = False

    Private Sub Registrar()
        Me.BanderaYaMarco = False
        'Dim Opcion_Devolucion As New Opciones_Devolucion
        'Dim Monto_Transporte As Monto_Transporte
        'Dim MontoTrans As Double = 0
        If Me.EncargadoRecibo = False Then
            Exit Sub
        End If

        If CadenaConexionSeePOS.ToLower.IndexOf("taller") > 0 Then
            Me.AdapterOpcionesPago.InsertCommand.CommandText = Me.AdapterOpcionesPago.InsertCommand.CommandText.Replace("OpcionesDePago", "SeePOs.dbo.OpcionesDePago")
        End If

        Dim REST As Integer
        Dim REST2 As Integer
        Dim NumDevo As Long
        Dim MontoDevoluciones As Double
        Me.ToolBarEliminar.Enabled = False
        Me.MontoDevolucion = Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2)
        If Me.PasaFirmadoContado(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id"), MontoDevolucion) = False Then
            Exit Sub
        End If
        If Me.MontoDevolucion > 0 Then
            Me.esFirmadoContado = False
        Else
            Me.esFirmadoContado = True
        End If

        '**********SI HAY ARTICULOS DEVUELTOS***********
        If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count = 0 And TextEdit7.EditValue = 0 Then
            MsgBox("Es necesario que almenos exista un item en el area de detalle " & vbCrLf & "para efectuar el registro de la devolución o un monto por concepto de Transporte..")
            Exit Sub
        ElseIf Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count = 0 And TextEdit7.EditValue <> 0 Then
            If MsgBox("Desea proceder a registrar esta devolución sin haber definido detalle y solo por el monto de Transporte ...?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If

        NumDevo = txtNum_Devo.Text
        '*****************SI LA VENTA ES DE CREDITO**************
        If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CRE" Or Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "TCR" Or Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "MCR" Then
            Dim SaldoFacturaT As Double
            Dim codcliente As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("cod_cliente")
            Dim cConexion As New Conexion
            SaldoFacturaT = cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT dbo.SaldoFactura_Monto(GETDATE()," & TextNumero.Text & ",'" & ComboTipo.Text & "', " & codcliente & ", " & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Total") & ") AS Saldo")

            Dim saldo As Decimal = SaldoFacturaT - Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2)
            If saldo < 0 Then
                Me.MontoDevolucion = (saldo * -1)

                'la factura es de credito pero tiene un saldo a favor
                Dim frmOptDev As New frmOpcionDevolucion
                If frmOptDev.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.OpcionDevolucion = frmOptDev.FormaDevolucion
                    Me.CedulaCliente = frmOptDev.txtCedula.Text
                    Me.NombreCliente = frmOptDev.txtNombre.Text
                    Me.CuentaCliente = frmOptDev.txtCuenta.Text
                    Me.CodCliente = frmOptDev.CodCliente
                    If Me.OpcionDevolucion = Tipo.Efectivo Then
                        'si quiere devolver el dinero debe validar la caja
                        Dim frm As New frmOpcionCaja
                        frm.ShowDialog()
                        Me.Caja_Factura = frm.Caja
                        Me.BanderaYaMarco = True
                        '*****************************************SELECCIONA CAJA **********************************************************
                        If CajaAbierta(Caja_Factura) = False Then
                            MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
                            Exit Sub
                        End If
                    Else
                        Me.BanderaYaMarco = True
                    End If

                Else
                    Exit Sub
                End If

            Else
                Me.MontoDevolucion = 0
            End If

            cConexion.DesConectar(cConexion.sQlconexion)
            If (BindingContext(DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CRE" Or BindingContext(DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "TCR") And SaldoFacturaT = 0 Then
                MontoDevoluciones = cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT isnull(SUM(Monto),0) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id") & " AND Anulado = 0")
                cConexion.DesConectar(cConexion.sQlconexion)
            End If
            If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") = SaldoFacturaT Then
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = True
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").EndCurrentEdit()
            End If
            '******************SI LA VENTA NO ES DE CREDITO**************
        Else
            MontoDevoluciones = CConexion.SlqExecuteScalar(CConexion.Conectar, "SELECT ISNULL(SUM(Monto), 0) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id") & " AND Anulado = 0")

            If Math.Round(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Total") - Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") - MontoDevoluciones, 2) = 0 Then
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = True
                Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").EndCurrentEdit()
            End If
        End If

        Dim DevolverAlbaran As Boolean = False
        '******************** SI LA FACTURA ES DE CONTADO O ES DE CREDITO PERO YA SE PAGO ********************
        If (ComboTipo.Text <> "CRE" And ComboTipo.Text <> "TCR") Or ((ComboTipo.Text = "CRE" Or ComboTipo.Text = "TCR") And CheckBox2.Checked = True) Then
            Try

                If Me.BanderaYaMarco = False Then
                    Dim frmOptDev As New frmOpcionDevolucion
                    frmOptDev.isPreDevolucion = Me.IsPreDevolucion
                    If frmOptDev.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.OpcionDevolucion = frmOptDev.FormaDevolucion
                        Me.CedulaCliente = frmOptDev.txtCedula.Text
                        Me.NombreCliente = frmOptDev.txtNombre.Text
                        Me.CuentaCliente = frmOptDev.txtCuenta.Text
                        Me.CodCliente = frmOptDev.CodCliente
                        If Me.OpcionDevolucion = Tipo.Efectivo Then
                            Dim frm As New frmOpcionCaja
                            frm.ShowDialog()
                            Me.Caja_Factura = frm.Caja
                            '*****************************************SELECCIONA CAJA **********************************************************
                            If CajaAbierta(Caja_Factura) = False Then
                                MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
                                Exit Sub
                            End If
                        End If

                        DevolverAlbaran = frmOptDev.ckDevolverAlbaran.Checked

                    Else
                        Exit Sub
                    End If
                End If

                REST = MsgBox("Deseas devolver la siguiente cantidad --> " & Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2) & " <--", MsgBoxStyle.YesNo, "SeePos")
                '**************************************************************************************************************************
                If REST = 6 Then

                    For i As Integer = 0 To Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count - 1
                        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Position = i
                        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Devolucion") = NumDevo
                    Next
                    Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").EndCurrentEdit()

                    'validar que existan articulos por devolver
                    If Me.TieneSaldo() = False Then
                        MsgBox("Articulo ya fue devuelto.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                        Exit Sub
                    End If

                    '************************************
                    If IsClinica() = True And Me.IsPreDevolucion = True Then
                        Me.SqlInsertCommand3.CommandText = Me.SqlInsertCommand3.CommandText.Replace("devoluciones_ventas", "PreDevoluciones_Ventas")
                        Me.SqlInsertCommand5.CommandText = Me.SqlInsertCommand5.CommandText.Replace("articulos_ventas_devueltos", "PreArticulos_Ventas_Devueltos")
                    End If

                    Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1.devoluciones_ventas)
                    NumDevo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
                    '================================================================================
                    'ARTICULOS VENTAS DEVUELTOS
                    Me.AdapterDetalleDevolucion.Update(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)
                    '================================================================================

                    If Me.IsPreDevolucion = False Then
                        Try
                            '================================================================
                            'VENTAS
                            'AdapterVentas.Update(Me.DataSetDevolucionVentas1.Ventas)
                            '================================================================

                            '================================================================
                            'VENTAS DETALLE
                            AdapterDetalleVentas.Update(Me.DataSetDevolucionVentas1.Ventas_Detalle)
                            '================================================================
                        Catch ex As Exception

                        End Try
                    End If

                    If IsPreDevolucion = False Then
                        If DevolverAlbaran = True Then
                            Dim db As New GestioDatos
                            Try
                                'habilita los albaranes para volver a facturar
                                db.Ejecuta("exec usp_HabiliarAlbaran " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
                            Catch ex As Exception
                            End Try
                        End If
                    End If

                    If Me.esFirmadoContado = False Then
                        If Me.OpcionDevolucion = Tipo.Efectivo Then
                            Me.InsertarOpicion_Pago()
                        End If
                    End If

                    Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
                    Me.DataSetDevolucionVentas1.AcceptChanges()

                    Dim dbo As New GestioDatos
                    Dim Tabla As String = "devoluciones_ventas"

                    If IsClinica() = True And Me.IsPreDevolucion = True Then
                        Tabla = "PreDevoluciones_Ventas"
                    End If

                    If Me.esFirmadoContado = False Then
                        If Me.OpcionDevolucion = Tipo.Efectivo Then
                            dbo.Ejecuta("Update " & Tabla & " set Caja = " & Me.Caja_Factura & ", Num_Apertura = " & Num_Apertura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
                        End If
                    End If
                    dbo.Ejecuta("Update " & Tabla & " Set NotasDevolucion = '" & Me.NotasDevolucion & "', UsuarioRecibio = '" & Me.UsuarioRecibo & "', MontoDevolucion = " & Me.MontoDevolucion & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

                    Try
                        dbo.Ejecuta("Update " & Tabla & " Set FormaDevolucion = '" & Me.OpcionDevolucion.ToString & "', CedulaCliente = '" & Me.CedulaCliente & "', NombreCliente = '" & Me.NombreCliente & "', CuentaCliente = '" & Me.CuentaCliente & "', CodCliente = " & Me.CodCliente & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
                    Catch ex As Exception
                    End Try

                    Try
                        'If IsClinica() = True Then

                        If Me.Caja_Factura = 0 Then
                            Me.Caja_Factura = 1
                        End If

                        dbo.Ejecuta("Update " & Tabla & " set Caja = " & Me.Caja_Factura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
                        'End If
                    Catch ex As Exception
                    End Try

                    VolverEstadonormal()
                    Limpiar()
                    Me.ToolBarRegistrar.Enabled = False
                    Me.ToolBarNuevo.Enabled = False
                    Me.ToolBarBuscar.Enabled = False

                    Me.ToolBarEliminar.Enabled = False
                    Me.ToolBarImprimir.Enabled = False
                    Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    Me.ToolBar1.Buttons(0).ImageIndex = 0

                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Focus()

                    REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
                    If REST2 = 6 Then
                        imprimir(NumDevo)
                    End If
                    Exit Sub
                Else
                    Exit Sub
                End If
                Me.ToolBarEliminar.Enabled = True

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        'SI LA FACTURA ES DE CREDITO 
        If (ComboTipo.Text = "CRE" Or ComboTipo.Text = "TCR") And CheckBox2.Checked = False Then
            Try
                REST = MsgBox("Deseas devolver la siguiente cantidad --> " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString & "<--", MsgBoxStyle.YesNo, "SeePos")
                If REST = 6 Then

                    '************************************
                    Dim Tabla As String = "devoluciones_ventas"

                    If IsClinica() = True And Me.IsPreDevolucion = True Then
                        Tabla = "PreDevoluciones_Ventas"
                    End If
                    If IsClinica() = True And Me.IsPreDevolucion = True Then
                        Me.SqlInsertCommand3.CommandText = Me.SqlInsertCommand3.CommandText.Replace("devoluciones_ventas", "PreDevoluciones_Ventas")
                        Me.SqlInsertCommand5.CommandText = Me.SqlInsertCommand5.CommandText.Replace("articulos_ventas_devueltos", "PreArticulos_Ventas_Devueltos")
                    End If

                    Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1.devoluciones_ventas)
                    NumDevo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
                    AdapterDetalleDevolucion.Update(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)
                    AdapterVentas.Update(Me.DataSetDevolucionVentas1.Ventas)
                    If IsPreDevolucion = False Then
                        AdapterDetalleVentas.Update(Me.DataSetDevolucionVentas1.Ventas_Detalle)
                    End If

                    Dim dbo As New GestioDatos
                    If Me.MontoDevolucion > 0 Then
                        Me.InsertarOpicion_Pago()
                        dbo.Ejecuta("Update " & Tabla & " set Caja = " & IIf(Me.Caja_Factura = 0, 1, Me.Caja_Factura) & ", Num_Apertura = " & Num_Apertura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
                        dbo.Ejecuta("Update " & Tabla & " Set MontoDevolucion = " & Me.MontoDevolucion & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
                    End If

                    dbo.Ejecuta("Update " & Tabla & " Set NotasDevolucion = '" & Me.NotasDevolucion & "', UsuarioRecibio = '" & Me.UsuarioRecibo & "' where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

                    Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
                    Me.DataSetDevolucionVentas1.AcceptChanges()

                    VolverEstadonormal()
                    Limpiar()
                    Me.ToolBarRegistrar.Enabled = False
                    Me.ToolBarNuevo.Enabled = True
                    Me.ToolBarBuscar.Enabled = True
                    Me.ToolBarEliminar.Enabled = False
                    Me.ToolBarImprimir.Enabled = False
                    Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
                    If REST2 = 6 Then
                        imprimir(NumDevo)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        '        Else
        '        MsgBox("Es necesario que almenos exista un item en el area de detalle para efctuar el registro de la devolución")
        '       End If

    End Sub

    Private Function TieneSaldo() As Boolean
        Dim IdVentaDetalle As String = ""
        Dim Saldo As Decimal = 0
        Dim Cantidad As Decimal = 0
        Dim dt As New DataTable
        For i As Integer = 0 To Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count - 1
            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Position = i
            IdVentaDetalle = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Id_Art_Venta")
            cFunciones.Llenar_Tabla_Generico("select cantidad - devoluciones as Saldo from Ventas_Detalle where Id_Venta_Detalle = " & IdVentaDetalle, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Saldo = CDec(dt.Rows(0).Item("Saldo"))
            Else
                Saldo = 0
            End If
            Cantidad = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Cantidad")
            If Saldo < Cantidad Then
                Return False
            End If
        Next
        Return True
    End Function

    Function VolverEstadonormal()
        Me.HabilitarBotones()
        InHabilitarControlesDetalleventas()
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
    End Function

    Function Limpiar()
        Me.DataSetDevolucionVentas1.Ventas_Detalle.Clear()
        Me.DataSetDevolucionVentas1.Ventas.Clear()
        Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()
        Me.DataSetDevolucionVentas1.devoluciones_ventas.Clear()
    End Function
    Function InsertarOpicion_Pago()
        Dim cconexion As New Conexion
        Dim sqlconexion As New System.Data.SqlClient.SqlConnection
        Dim rs As System.Data.SqlClient.SqlDataReader

        Try
            sqlconexion = cconexion.ConectarUnicoParaDevoluciones("SeePos")
            rs = cconexion.GetRecorset(sqlconexion, "SELECT Cedula, Nombre, NApertura  FROM AperturaCaja WHERE Estado = 'A' AND Anulado = 0 and Num_Caja = " & Caja_Factura)
            If rs.Read Then
                'Inicio un nuevo detalle de devoluciones
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").AddNew()
                'Asignarlos Valores  Al detalle de devolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Documento") = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("TipoDocumento") = "DVE"
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("MontoPago") = Me.MontoDevolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("FormaPago") = "DVE"
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Denominacion") = Me.MontoDevolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Usuario") = rs("Cedula")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Nombre") = rs("Nombre")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("CodMoneda") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Cod_Moneda")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Nombremoneda") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Moneda_Nombre")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("TipoCambio") = Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Tipo_Cambio")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Fecha") = Format(Now, "dd/MM/yyyy H:mm:ss")
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").Current("Numapertura") = rs("NApertura")
                'Final un nuevo detalle de devoluciones
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").EndCurrentEdit()
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").AddNew()
                Me.BindingContext(Me.DataSetDevolucionVentas1, "OpcionesDePago").CancelCurrentEdit()
                Return True
            Else
                MsgBox("No hay apertura de caja!!", MsgBoxStyle.Exclamation, "SeeSoft")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            rs.Close()
            cconexion.DesConectar(cconexion.sQlconexion)
        End Try
    End Function
    'Function ActualizarInventario()
    '    Dim con As New Conexion
    '    Dim i As Integer
    '    Dim Cantidad As Double
    '    Dim Codigo As Long
    '    con.Conectar()
    '    For i = 0 To (Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count() - 1)
    '        Cantidad = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Cantidad")
    '        Codigo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Codigo")
    '        If con.UpdateRecords("Inventario", "Existencia = Existencia + " & Cantidad, "codigo = " & Codigo) <> "" Then
    '            MsgBox("error")
    '        End If
    '    Next
    '    con.DesConectar(con.Conectar)
    'End Function

    Function Cancelar()
        Me.DataSetDevolucionVentas1.Ventas_Detalle.RejectChanges()
        Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.RejectChanges()
        Me.DataSetDevolucionVentas1.devoluciones_ventas.RejectChanges()
        Me.LimpiarVentasDetalle()
        LimpiarFactura()
        Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
        Me.ToolBar1.Buttons(0).ImageIndex = 0
        Me.ToolBarBuscar.Enabled = True
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarNuevo.Enabled = True
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
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
        Me.txtUsuario.Enabled = False
    End Function

    Function ValidarBusqueda() As Boolean
        If Me.ComboTipo.Text.Length > 0 Then

        Else
            MsgBox("Debes Seleccionar un numero de factura ", MsgBoxStyle.Information, "Atención...........")
            ComboTipo.Focus()
            Return False
        End If

        If Me.txtNum_Caja.Text = "" Then
            Me.txtNum_Caja.Focus()
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

    Private Sub ComboTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim i As Integer
        If Me.DataSetDevolucionVentas1.Ventas_Detalle.Count > 0 Then
            For i = 0 To Me.DataSetDevolucionVentas1.Ventas_Detalle.Count - 1

                If Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(i).Item("Cantidad") > Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(i).Item("Devoluciones") Then
                    IniciarEdionDetalleDevolucionAutomatico(i)
                End If
            Next
        Else
            MsgBox("No se puede hacer automaticamente debido a que No hay articulos en el detalle de ventas ")
        End If

    End Sub

    Function IniciarEdionDetalleDevolucionAutomatico(ByVal Index As Integer) As Boolean
        'optengo la catidad a devolver
        Dim Devolucion As Integer = (Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Cantidad") - Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Devoluciones"))
        'optengo las devoluciones
        Dim Devoluciones As Integer = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Devoluciones")
        'optengo la cantidad
        Dim Cantidad As Integer = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Cantidad")
        'optengo la Disponibilidad
        Dim Disponible = Cantidad - Devoluciones
        'Optengo el codigo del articulo
        Dim Codigo As Long = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Codigo")
        'Optengo la descripcion del articulo
        Dim Descripcion As String = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Descripcion")
        Dim Precio_Costo As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Precio_Costo")
        Dim Precio_Base As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Precio_Base")
        Dim Precio_Flete As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Precio_Flete")
        Dim Precio_Otros As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Precio_Otros")
        Dim Precio_Unit As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Precio_Unit")
        Dim Descuento As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Descuento")

        Dim Monto_Descuento As Double
        '= ReglaTres(Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Monto_Descuento"), Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Cantidad"), Devolucion)
        Dim Impuesto As Double = Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Impuesto")
        Dim Monto_Impuesto As Double
        '= ReglaTres(Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Monto_Impuesto"), Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Cantidad"), Devolucion)
        Dim SubtotalGravado As Double
        '= ReglaTres(Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("SubtotalGravado"), Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Cantidad"), Devolucion)
        Dim SubTotalExcento As Double
        '= ReglaTres(Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("SubTotalExcento"), Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Cantidad"), Devolucion)
        Dim SubTotal As Double

        '*****************************************************************************************************************
        '*************************************Calculo Monto Descuento***********************************************************
        '*****************************************************************************************************************
        Monto_Descuento = (CDbl(Precio_Unit) * CDbl(Devolucion)) * (CDbl(Descuento) / 100)

        '*****************************************************************************************************************
        '*************************************Calculo Exento Gravado***********************************************************
        '*****************************************************************************************************************

        If Impuesto <> 0 Then 'si tiene impuesto de venta
            SubtotalGravado = ((CDbl(Precio_Unit) - CDbl(Precio_Flete) - CDbl(Precio_Otros)) * CDbl(Devolucion)) - Monto_Descuento
            Monto_Impuesto = SubtotalGravado * (CDbl(Impuesto) / 100)
        Else 'si no tiene impuesto de venta
            SubTotalExcento = ((CDbl(Precio_Unit) - CDbl(Precio_Flete) - CDbl(Precio_Otros)) * CDbl(Devolucion)) - Monto_Descuento
            SubtotalGravado = 0
            Monto_Impuesto = 0
        End If

        SubTotalExcento = SubTotalExcento + ((CDbl(Precio_Flete) + CDbl(Precio_Otros)) * CDbl(Devolucion))

        '*****************************************************************************************************************
        '************************************* Detalle de Devoluciones ***************************************************
        '*****************************************************************************************************************
        SubTotal = SubtotalGravado + SubTotalExcento

        If (Disponible >= Devolucion) Then
            Try
                'Actualizo el detalle de ventas
                Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).Item("Devoluciones") += Devolucion
                Me.DataSetDevolucionVentas1.Ventas_Detalle.Rows(Index).EndEdit()
                '********************************************************************************************************************************
                '******************************************************DETALLE DE DEVOLUCIONES***************************************************
                '********************************************************************************************************************************
                'Inicio un nuevo detalle de devoluciones
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").AddNew()
                'Asignarlos Valores  Al detalle de devolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Codigo") = Codigo
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Descripcion") = Descripcion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Cantidad") = Devolucion
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Costo") = Precio_Costo
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Base") = Precio_Base
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Flete") = Precio_Flete
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Otros") = Precio_Otros
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Precio_Unit") = Precio_Unit
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Descuento") = Descuento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Monto_Descuento") = Monto_Descuento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Impuesto") = Impuesto
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Monto_Impuesto") = Monto_Impuesto
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("SubtotalGravado") = SubtotalGravado
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("SubTotalExcento") = SubTotalExcento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("SubTotal") = SubTotal
                'Final un nuevo detalle de devoluciones
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").EndCurrentEdit()
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").AddNew()
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").CancelCurrentEdit()
                'Agregar los Subtotales al DEVOLUCIONES
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") += (SubTotal + Monto_Impuesto - Monto_Descuento)
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("SubTotalGravado") += SubtotalGravado
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("SubTotalExcento") += SubTotalExcento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Descuento") += Monto_Descuento
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Impuesto") += Monto_Impuesto
                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Se ha superado la venta original que registra esta factura", MsgBoxStyle.Exclamation, "Atención..............")
        End If
    End Function
    Private Sub TextDescripcion_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextDescripcion.MouseMove
        Me.ToolTip.SetToolTip(sender, Me.TextDescripcion.Text)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim Monto_Transporte As Monto_Transporte
        Dim MontoTrans As Double = 0
        If Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Transporte") > 0 Then
            Monto_Transporte = New Monto_Transporte(Me.DataSetDevolucionVentas1.Ventas.Rows(0).Item("Id"))
            Monto_Transporte.ShowDialog()
            If Monto_Transporte.DialogResult = DialogResult.OK Then
                MontoTrans = Monto_Transporte.Monto
                TextEdit7.EditValue = MontoTrans
            End If
        Else
            '*************SI NO HAY UN MONTO EN TRASPORTE*************
            MontoTrans = 0
        End If
        'TOTAL = GRAVADO + EXENTO + TRANSPORTE - DESCUENTO + IMPUESTO
        TextEdit10.EditValue = TextEdit5.EditValue + TextEdit6.EditValue + TextEdit7.EditValue - TextEdit8.EditValue + TextEdit9.EditValue
        'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Transporte") = MontoTrans
        'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") += MontoTrans
        Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()
    End Sub

    Private Sub CantBod2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CantBod2.KeyDown
        Dim resp As Integer
        Dim Cancelar As Double
        If e.KeyCode = Keys.Enter Then
            If Me.CantBod2.Text.Length > 0 Then
                Cancelar = CDbl(ValidText1.Text)
                If Cancelar > 0 Then
                    resp = MessageBox.Show("¿Desea que la información sea enviada al detalle de la Devolución?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    If resp = 6 Then
                        IniciarEdionDetalleDevolucion()
                    End If
                End If
            Else
                MsgBox("Debes digitar una cantidad mayor que 0", MsgBoxStyle.Information, "Atencion...............")
            End If
        End If
    End Sub

    Private Sub txtNum_Caja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum_Caja.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextNumero.Focus()
        End If
    End Sub

    Private Sub ComboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTipo.SelectedIndexChanged

    End Sub

    Private Sub txtNum_Caja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNum_Caja.TextChanged

    End Sub

    Private Sub txtNum_Caja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNum_Caja.LostFocus
        TextNumero.Select()
    End Sub
End Class
