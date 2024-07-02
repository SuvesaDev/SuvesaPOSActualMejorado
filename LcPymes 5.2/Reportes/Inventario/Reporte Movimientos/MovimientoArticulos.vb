Imports System.data.SqlClient
Imports System.Data

Public Class MovimientoArticulos
    Inherits FrmPlantilla

#Region "Variables"
    Private cConexion As New Conexion
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFactura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents AdvBandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFacturaCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTipoCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFechaCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProveedor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidadCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIdCompra As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private sqlConexion As SqlConnection
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridCompras As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdapterVentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsMovimientoArticulos1 As LcPymes_5._2.DsMovimientoArticulos
    Friend WithEvents DT_Inicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DT_Final As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BCompras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BVentas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AdapterCompras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GBCompras As System.Windows.Forms.GroupBox
    Friend WithEvents GBVentas As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalVendido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientoArticulos))
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo13 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo14 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DT_Inicio = New DevExpress.XtraEditors.DateEdit()
        Me.DT_Final = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.AdapterVentas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.BCompras = New DevExpress.XtraEditors.SimpleButton()
        Me.BVentas = New DevExpress.XtraEditors.SimpleButton()
        Me.AdapterCompras = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.GBCompras = New System.Windows.Forms.GroupBox()
        Me.GridCompras = New DevExpress.XtraGrid.GridControl()
        Me.DsMovimientoArticulos1 = New LcPymes_5._2.DsMovimientoArticulos()
        Me.GBVentas = New System.Windows.Forms.GroupBox()
        Me.GridVentas = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFactura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.txtTotalCompra = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalVendido = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.AdvBandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.colFacturaCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTipoCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFechaCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProveedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidadCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecioCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIdCompra = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.DT_Inicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Final.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCompras.SuspendLayout()
        CType(Me.GridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMovimientoArticulos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBVentas.SuspendLayout()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVendido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 456)
        Me.ToolBar1.Size = New System.Drawing.Size(754, 8)
        Me.ToolBar1.Visible = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(766, 426)
        Me.DataNavigator.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(754, 32)
        Me.TituloModulo.Text = "Movimiento de Artículos"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(504, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Hasta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(400, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DT_Inicio
        '
        Me.DT_Inicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_Inicio.EditValue = New Date(2010, 2, 25, 0, 0, 0, 0)
        Me.DT_Inicio.Location = New System.Drawing.Point(400, 56)
        Me.DT_Inicio.Name = "DT_Inicio"
        '
        '
        '
        Me.DT_Inicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DT_Inicio.Size = New System.Drawing.Size(96, 23)
        Me.DT_Inicio.TabIndex = 1
        '
        'DT_Final
        '
        Me.DT_Final.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_Final.EditValue = New Date(2010, 2, 25, 0, 0, 0, 0)
        Me.DT_Final.Location = New System.Drawing.Point(504, 56)
        Me.DT_Final.Name = "DT_Final"
        '
        '
        '
        Me.DT_Final.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DT_Final.Size = New System.Drawing.Size(96, 23)
        Me.DT_Final.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.EditValue = ""
        Me.txtCodigo.Location = New System.Drawing.Point(16, 56)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 19)
        Me.txtCodigo.TabIndex = 0
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.EditValue = ""
        Me.txtCodArticulo.Location = New System.Drawing.Point(-104, 40)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(104, 19)
        Me.txtCodArticulo.TabIndex = 80
        Me.txtCodArticulo.Visible = False
        '
        'AdapterVentas
        '
        Me.AdapterVentas.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterVentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MovimientoArticuloVentas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Num_Factura, Tipo, Nombre_Cliente, Fecha, Codigo, CodArticulo, Descripcion" & _
    ", Cantidad, Precio_Unit FROM MovimientoArticuloVentas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
    "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(144, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.EditValue = ""
        Me.txtDescripcion.Location = New System.Drawing.Point(144, 56)
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        '
        '
        Me.txtDescripcion.Properties.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(248, 19)
        Me.txtDescripcion.TabIndex = 84
        '
        'BCompras
        '
        Me.BCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCompras.Location = New System.Drawing.Point(608, 32)
        Me.BCompras.Name = "BCompras"
        Me.BCompras.Size = New System.Drawing.Size(64, 23)
        Me.BCompras.TabIndex = 3
        Me.BCompras.Text = "Compras"
        '
        'BVentas
        '
        Me.BVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BVentas.Location = New System.Drawing.Point(608, 56)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Size = New System.Drawing.Size(64, 23)
        Me.BVentas.TabIndex = 4
        Me.BVentas.Text = "Ventas"
        '
        'AdapterCompras
        '
        Me.AdapterCompras.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterCompras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MovimientoArticulosCompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("TipoCompra", "TipoCompra"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Factura, TipoCompra, Nombre, Fecha, Codigo, CodArticulo, Cantidad, Total F" & _
    "ROM MovimientoArticulosCompra"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'GBCompras
        '
        Me.GBCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBCompras.BackColor = System.Drawing.Color.Transparent
        Me.GBCompras.Controls.Add(Me.GridCompras)
        Me.GBCompras.Location = New System.Drawing.Point(8, 80)
        Me.GBCompras.Name = "GBCompras"
        Me.GBCompras.Size = New System.Drawing.Size(736, 160)
        Me.GBCompras.TabIndex = 85
        Me.GBCompras.TabStop = False
        Me.GBCompras.Text = "Compras"
        '
        'GridCompras
        '
        Me.GridCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCompras.DataMember = "MovimientoArticulosCompra"
        Me.GridCompras.DataSource = Me.DsMovimientoArticulos1
        '
        '
        '
        Me.GridCompras.EmbeddedNavigator.Name = ""
        Me.GridCompras.Location = New System.Drawing.Point(8, 16)
        Me.GridCompras.MainView = Me.AdvBandedGridView2
        Me.GridCompras.Name = "GridCompras"
        Me.GridCompras.Size = New System.Drawing.Size(720, 136)
        Me.GridCompras.TabIndex = 81
        Me.GridCompras.Text = "Compras"
        '
        'DsMovimientoArticulos1
        '
        Me.DsMovimientoArticulos1.DataSetName = "DsMovimientoArticulos"
        Me.DsMovimientoArticulos1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsMovimientoArticulos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GBVentas
        '
        Me.GBVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBVentas.BackColor = System.Drawing.Color.Transparent
        Me.GBVentas.Controls.Add(Me.GridVentas)
        Me.GBVentas.Location = New System.Drawing.Point(8, 256)
        Me.GBVentas.Name = "GBVentas"
        Me.GBVentas.Size = New System.Drawing.Size(736, 168)
        Me.GBVentas.TabIndex = 86
        Me.GBVentas.TabStop = False
        Me.GBVentas.Text = "Ventas"
        '
        'GridVentas
        '
        Me.GridVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridVentas.DataMember = "MovimientoArticuloVentas"
        Me.GridVentas.DataSource = Me.DsMovimientoArticulos1
        '
        '
        '
        Me.GridVentas.EmbeddedNavigator.Name = ""
        Me.GridVentas.Location = New System.Drawing.Point(8, 16)
        Me.GridVentas.MainView = Me.AdvBandedGridView1
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.Size = New System.Drawing.Size(720, 144)
        Me.GridVentas.TabIndex = 82
        Me.GridVentas.Text = "Ventas"
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colFactura, Me.colTipo, Me.colFecha, Me.colCliente, Me.colCantidad, Me.colPrecio, Me.colId})
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ShowGroupedColumns = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colFactura)
        Me.GridBand1.Columns.Add(Me.colTipo)
        Me.GridBand1.Columns.Add(Me.colFecha)
        Me.GridBand1.Columns.Add(Me.colCliente)
        Me.GridBand1.Columns.Add(Me.colCantidad)
        Me.GridBand1.Columns.Add(Me.colPrecio)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 706
        '
        'colFactura
        '
        Me.colFactura.Caption = "Factura"
        Me.colFactura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFactura.FieldName = "Num_Factura"
        Me.colFactura.FilterInfo = ColumnFilterInfo8
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFactura.Visible = True
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.FilterInfo = ColumnFilterInfo9
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipo.Visible = True
        Me.colTipo.Width = 55
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.FilterInfo = ColumnFilterInfo10
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFecha.Visible = True
        Me.colFecha.Width = 90
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Nombre_Cliente"
        Me.colCliente.FilterInfo = ColumnFilterInfo11
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCliente.Visible = True
        Me.colCliente.Width = 300
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo12
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 71
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.DisplayFormat.FormatString = "#,##0.00"
        Me.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio.FieldName = "Precio_Unit"
        Me.colPrecio.FilterInfo = ColumnFilterInfo13
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio.Visible = True
        Me.colPrecio.Width = 115
        '
        'colId
        '
        Me.colId.Caption = "IdFactura"
        Me.colId.FieldName = "Id"
        Me.colId.FilterInfo = ColumnFilterInfo14
        Me.colId.Name = "colId"
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.EditValue = ""
        Me.txtTotalCompra.Location = New System.Drawing.Point(568, 240)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCompra.Size = New System.Drawing.Size(72, 19)
        Me.txtTotalCompra.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(432, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Total Comprado:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalVendido
        '
        Me.txtTotalVendido.EditValue = ""
        Me.txtTotalVendido.Location = New System.Drawing.Point(568, 432)
        Me.txtTotalVendido.Name = "txtTotalVendido"
        Me.txtTotalVendido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalVendido.Size = New System.Drawing.Size(72, 19)
        Me.txtTotalVendido.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(432, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Total Vendido:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(680, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(64, 48)
        Me.SimpleButton1.TabIndex = 91
        Me.SimpleButton1.Text = "Imprimir"
        '
        'AdvBandedGridView2
        '
        Me.AdvBandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.AdvBandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colFacturaCompra, Me.colTipoCompra, Me.colFechaCompra, Me.colProveedor, Me.colCantidadCompra, Me.colPrecioCompra, Me.colIdCompra})
        Me.AdvBandedGridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", Me.colCantidadCompra, "c", "total c")})
        Me.AdvBandedGridView2.Name = "AdvBandedGridView2"
        Me.AdvBandedGridView2.OptionsView.ShowGroupedColumns = False
        Me.AdvBandedGridView2.OptionsView.ShowGroupPanel = False
        '
        'colFacturaCompra
        '
        Me.colFacturaCompra.Caption = "Factura"
        Me.colFacturaCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFacturaCompra.FieldName = "Factura"
        Me.colFacturaCompra.FilterInfo = ColumnFilterInfo1
        Me.colFacturaCompra.Name = "colFacturaCompra"
        Me.colFacturaCompra.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFacturaCompra.Visible = True
        Me.colFacturaCompra.Width = 71
        '
        'colTipoCompra
        '
        Me.colTipoCompra.Caption = "Tipo"
        Me.colTipoCompra.FieldName = "TipoCompra"
        Me.colTipoCompra.FilterInfo = ColumnFilterInfo2
        Me.colTipoCompra.Name = "colTipoCompra"
        Me.colTipoCompra.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipoCompra.Visible = True
        Me.colTipoCompra.Width = 57
        '
        'colFechaCompra
        '
        Me.colFechaCompra.Caption = "Fecha"
        Me.colFechaCompra.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFechaCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaCompra.FieldName = "Fecha"
        Me.colFechaCompra.FilterInfo = ColumnFilterInfo3
        Me.colFechaCompra.Name = "colFechaCompra"
        Me.colFechaCompra.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFechaCompra.Visible = True
        Me.colFechaCompra.Width = 65
        '
        'colProveedor
        '
        Me.colProveedor.Caption = "Proveedor"
        Me.colProveedor.FieldName = "Nombre"
        Me.colProveedor.FilterInfo = ColumnFilterInfo4
        Me.colProveedor.Name = "colProveedor"
        Me.colProveedor.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colProveedor.Visible = True
        Me.colProveedor.Width = 275
        '
        'colCantidadCompra
        '
        Me.colCantidadCompra.Caption = "Cantidad"
        Me.colCantidadCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidadCompra.FieldName = "Cantidad"
        Me.colCantidadCompra.FilterInfo = ColumnFilterInfo5
        Me.colCantidadCompra.Name = "colCantidadCompra"
        Me.colCantidadCompra.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidadCompra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCantidadCompra.SummaryItem.Tag = "total c"
        Me.colCantidadCompra.Visible = True
        Me.colCantidadCompra.Width = 66
        '
        'colPrecioCompra
        '
        Me.colPrecioCompra.Caption = "Precio"
        Me.colPrecioCompra.DisplayFormat.FormatString = "#,##0.00"
        Me.colPrecioCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioCompra.FieldName = "Total"
        Me.colPrecioCompra.FilterInfo = ColumnFilterInfo6
        Me.colPrecioCompra.Name = "colPrecioCompra"
        Me.colPrecioCompra.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecioCompra.Visible = True
        Me.colPrecioCompra.Width = 100
        '
        'colIdCompra
        '
        Me.colIdCompra.Caption = "BandedGridColumn1"
        Me.colIdCompra.FieldName = "Id_Compra"
        Me.colIdCompra.FilterInfo = ColumnFilterInfo7
        Me.colIdCompra.Name = "colIdCompra"
        Me.colIdCompra.Visible = True
        Me.colIdCompra.Width = 72
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand2"
        Me.GridBand2.Columns.Add(Me.colFacturaCompra)
        Me.GridBand2.Columns.Add(Me.colTipoCompra)
        Me.GridBand2.Columns.Add(Me.colFechaCompra)
        Me.GridBand2.Columns.Add(Me.colProveedor)
        Me.GridBand2.Columns.Add(Me.colCantidadCompra)
        Me.GridBand2.Columns.Add(Me.colPrecioCompra)
        Me.GridBand2.Columns.Add(Me.colIdCompra)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 706
        '
        'MovimientoArticulos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(754, 464)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtTotalVendido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalCompra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GBVentas)
        Me.Controls.Add(Me.GBCompras)
        Me.Controls.Add(Me.BVentas)
        Me.Controls.Add(Me.BCompras)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodArticulo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DT_Final)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "MovimientoArticulos"
        Me.Text = "Movimiento de Artículos"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.DT_Final, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtCodArticulo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.BCompras, 0)
        Me.Controls.SetChildIndex(Me.BVentas, 0)
        Me.Controls.SetChildIndex(Me.GBCompras, 0)
        Me.Controls.SetChildIndex(Me.GBVentas, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCompra, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtTotalVendido, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        CType(Me.DT_Inicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Final.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCompras.ResumeLayout(False)
        CType(Me.GridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMovimientoArticulos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBVentas.ResumeLayout(False)
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVendido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub MovimientoArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            DT_Inicio.DateTime = Now.Date
            DT_Final.DateTime = Now.Date

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Funciones"
    Public Sub MostrarVentas()
        Try
            If txtCodigo.Text = "" Or txtCodigo.Text = "0" Then
                MsgBox("Debe seleccionar un artículo!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            DsMovimientoArticulos1.MovimientoArticuloVentas.Clear()


            Dim cnnv As SqlConnection = Nothing
            Dim dt As New DataTable
            '
            ' Dentro de un Try/Catch por si se produce un error
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM MovimientoArticuloVentas WHERE (Codigo = @Codigo) AND Fecha BETWEEN '" & DT_Inicio.DateTime & "' AND '" & DT_Final.DateTime & "' order by Fecha, Num_Factura"

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.BigInt))

            cmdv.Parameters("@Codigo").Value = txtCodArticulo.Text

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(DsMovimientoArticulos1, "MovimientoArticuloVentas")

            Dim total As Double = 0
            For i As Integer = 0 To Me.DsMovimientoArticulos1.MovimientoArticuloVentas.Count - 1
                If Me.DsMovimientoArticulos1.MovimientoArticuloVentas(i).Nombre_Cliente.StartsWith("(ANULADO)") = False Then
                    total += Me.DsMovimientoArticulos1.MovimientoArticuloVentas(i).Cantidad
                End If

            Next
            txtTotalVendido.Text = total ' Me.colCantidadCompra.SummaryItem.SummaryValue
            'txtTotalVendido.Text = 'Me.colCantidad.SummaryItem.SummaryValue

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub MostrarCompras()
        Try
            If txtCodigo.Text = "" Or txtCodigo.Text = "0" Then
                MsgBox("Debe seleccionar un artículo!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            DsMovimientoArticulos1.MovimientoArticulosCompra.Clear()

            Dim cnnv As SqlConnection = Nothing
            Dim dt As New DataTable
            '
            ' Dentro de un Try/Catch por si se produce un error
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM MovimientoArticulosCompra WHERE (Codigo = @Codigo) AND Fecha BETWEEN '" & DT_Inicio.DateTime & "' AND '" & DT_Final.DateTime & "' order by fecha, Factura"

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.BigInt))

            cmdv.Parameters("@Codigo").Value = txtCodArticulo.Text

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(DsMovimientoArticulos1, "MovimientoArticulosCompra")
            Dim total As Double = 0
            For i As Integer = 0 To Me.DsMovimientoArticulos1.MovimientoArticulosCompra.Count - 1
                If Me.DsMovimientoArticulos1.MovimientoArticulosCompra(i).Nombre.StartsWith("(ANULADO)") = False Then
                    total += Me.DsMovimientoArticulos1.MovimientoArticulosCompra(i).Cantidad
                End If

            Next
            txtTotalCompra.Text = total ' Me.colCantidadCompra.SummaryItem.SummaryValue

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub consultar()
        Try
            Dim BuscarArticulo As New FrmBuscarArticulo2
            BuscarArticulo.Cod_Articulo = True
            BuscarArticulo.ShowDialog()

            If BuscarArticulo.Cancelado Then
                txtCodigo.Focus()
            Else
                CargarInformacionArticulo(BuscarArticulo.Codigo)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function CargarInformacionArticulo(ByVal codigo As String) As Boolean
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean
        Try
            If codigo <> Nothing Then
                sqlConexion = cConexion.Conectar
                rs = cConexion.GetRecorset(sqlConexion, "SELECT Codigo, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , Cod_Articulo from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "'")
                Encontrado = False

                While rs.Read
                    Try
                        Encontrado = True
                        txtCodigo.Text = rs("Cod_Articulo")
                        txtCodArticulo.Text = rs("Codigo")
                        txtDescripcion.Text = rs("Descripcion")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        cConexion.DesConectar(cConexion.sQlconexion)
                    End Try
                End While
                If rs.IsClosed = False Then rs.Close()

                If Not Encontrado Then
                    MsgBox("No existe este Articulo! O esta deshabilitado", MsgBoxStyle.Exclamation)
                    cConexion.DesConectar(cConexion.sQlconexion)
                    Return False
                End If

                Return True
            End If

        Catch ex As Exception
            If rs.IsClosed = False Then rs.Close()
            MsgBox(ex.Message)
            Return False
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
#End Region

#Region "Funciones Controles"

    Public Sub BuscarCodigoExterno()
        If CargarInformacionArticulo(txtCodigo.Text) Then
            DsMovimientoArticulos1.MovimientoArticulosCompra.Clear()
            DsMovimientoArticulos1.MovimientoArticuloVentas.Clear()
            DT_Inicio.Focus()
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then
            consultar()
        End If

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If CargarInformacionArticulo(txtCodigo.Text) Then
                DsMovimientoArticulos1.MovimientoArticulosCompra.Clear()
                DsMovimientoArticulos1.MovimientoArticuloVentas.Clear()
                DT_Inicio.Focus()
            End If
        End If
    End Sub

    Private Sub DT_Inicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DT_Inicio.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            DT_Final.Focus()
        End If
    End Sub

    Private Sub DT_Final_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DT_Final.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            BCompras.Focus()
        End If
    End Sub

    Private Sub BVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVentas.Click
        MostrarVentas()
    End Sub

    Private Sub BVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BVentas.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            MostrarVentas()
        End If
    End Sub

    Private Sub BCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCompras.Click
        MostrarCompras()
    End Sub

    Private Sub BCompras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BCompras.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            MostrarCompras()
        End If
    End Sub
#End Region

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            If Me.txtTotalCompra.Text = "" Then Me.txtTotalCompra.Text = "0"
            If Me.txtTotalVendido.Text = "" Then Me.txtTotalVendido.Text = "0"

            Dim frm As New frmVisorReportes
            Dim rpt As New rptMovimientoArticulos
            rpt.Refresh()
            rpt.Subreports(0).SetDataSource(Me.DsMovimientoArticulos1)
            rpt.Subreports(1).SetDataSource(Me.DsMovimientoArticulos1)
            rpt.SetParameterValue(0, Me.txtDescripcion.Text)
            rpt.SetParameterValue(1, Me.DT_Inicio.Text)
            rpt.SetParameterValue(2, Me.DT_Final.Text)
            rpt.SetParameterValue(3, Me.txtTotalVendido.Text)
            rpt.SetParameterValue(4, Me.txtTotalCompra.Text)
            frm.rptViewer.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public usua As Usuario_Logeado
    Private Sub GridVentas_DoubleClick(sender As Object, e As EventArgs) Handles GridVentas.DoubleClick
        Try

            Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = _
                               AdvBandedGridView1.CalcHitInfo(CType(GridVentas, Control).PointToClient(Control.MousePosition))

            If MsgBox("Desea Abrir la factura de Venta", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Dim data As DataRow
                Dim factura As String = "0"

                If hi.RowHandle >= 0 Then
                    data = AdvBandedGridView1.GetDataRow(hi.RowHandle)
                ElseIf AdvBandedGridView1.FocusedRowHandle >= 0 Then
                    data = AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle)
                Else
                    data = Nothing
                End If

                factura = data("Id")

                Dim frm As New Facturacion
                frm.MdiParent = Me.ParentForm
                frm.Show()
                frm.AbreDesdeAfuera(factura)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridCompras_DoubleClick(sender As Object, e As EventArgs) Handles GridCompras.DoubleClick
        Try
            Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = _
                               AdvBandedGridView2.CalcHitInfo(CType(GridCompras, Control).PointToClient(Control.MousePosition))

            If MsgBox("Desea Abrir la Compra", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Dim data As DataRow
                Dim factura As String = "0"

                If hi.RowHandle >= 0 Then
                    data = AdvBandedGridView2.GetDataRow(hi.RowHandle)
                ElseIf AdvBandedGridView1.FocusedRowHandle >= 0 Then
                    data = AdvBandedGridView2.GetDataRow(AdvBandedGridView2.FocusedRowHandle)
                Else
                    data = Nothing
                End If

                factura = data("Id_Compra")

                Dim frm As New frmCompra(Me.usua)
                frm.MdiParent = Me.MdiParent
                frm.Show()
                frm.CargarCompradesdeAfuera(factura)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

