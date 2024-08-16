Imports System.data.SqlClient
Imports System.Data

Public Class MovimientoArticulos
    Inherits FrmPlantilla

#Region "Variables"
    Private cConexion As New Conexion
    Friend WithEvents viewDatosVentas As System.Windows.Forms.DataGridView
    Friend WithEvents MovimientoArticuloVentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents viewDatosCompras As System.Windows.Forms.DataGridView
    Friend WithEvents MovimientoArticulosCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAumento As LcPymes_5._2.dsAumento
    Friend WithEvents DsAumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodArticuloDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientoArticulos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.viewDatosCompras = New System.Windows.Forms.DataGridView()
        Me.MovimientoArticulosCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMovimientoArticulos1 = New LcPymes_5._2.DsMovimientoArticulos()
        Me.GBVentas = New System.Windows.Forms.GroupBox()
        Me.viewDatosVentas = New System.Windows.Forms.DataGridView()
        Me.MovimientoArticuloVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotalCompra = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalVendido = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DsAumento = New LcPymes_5._2.dsAumento()
        Me.DsAumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodArticuloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DT_Inicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Final.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCompras.SuspendLayout()
        CType(Me.viewDatosCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoArticulosCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMovimientoArticulos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBVentas.SuspendLayout()
        CType(Me.viewDatosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoArticuloVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVendido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SqlConnection1.ConnectionString = "Data Source=guanaserver; Initial Catalog=SEEPOS; Integrated Security=true;"
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
        Me.GBCompras.Controls.Add(Me.viewDatosCompras)
        Me.GBCompras.Location = New System.Drawing.Point(8, 80)
        Me.GBCompras.Name = "GBCompras"
        Me.GBCompras.Size = New System.Drawing.Size(736, 160)
        Me.GBCompras.TabIndex = 85
        Me.GBCompras.TabStop = False
        Me.GBCompras.Text = "Compras"
        '
        'viewDatosCompras
        '
        Me.viewDatosCompras.AllowUserToAddRows = False
        Me.viewDatosCompras.AllowUserToDeleteRows = False
        Me.viewDatosCompras.AllowUserToResizeColumns = False
        Me.viewDatosCompras.AllowUserToResizeRows = False
        Me.viewDatosCompras.AutoGenerateColumns = False
        Me.viewDatosCompras.BackgroundColor = System.Drawing.Color.White
        Me.viewDatosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatosCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaDataGridViewTextBoxColumn, Me.TipoCompraDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn1, Me.CodArticuloDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn1, Me.TotalDataGridViewTextBoxColumn, Me.ImpuestoPDataGridViewTextBoxColumn, Me.IdCompraDataGridViewTextBoxColumn})
        Me.viewDatosCompras.DataSource = Me.MovimientoArticulosCompraBindingSource
        Me.viewDatosCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewDatosCompras.Location = New System.Drawing.Point(3, 16)
        Me.viewDatosCompras.MultiSelect = False
        Me.viewDatosCompras.Name = "viewDatosCompras"
        Me.viewDatosCompras.ReadOnly = True
        Me.viewDatosCompras.RowHeadersVisible = False
        Me.viewDatosCompras.RowTemplate.Height = 25
        Me.viewDatosCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatosCompras.Size = New System.Drawing.Size(730, 141)
        Me.viewDatosCompras.TabIndex = 0
        '
        'MovimientoArticulosCompraBindingSource
        '
        Me.MovimientoArticulosCompraBindingSource.DataMember = "MovimientoArticulosCompra"
        Me.MovimientoArticulosCompraBindingSource.DataSource = Me.DsMovimientoArticulos1
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
        Me.GBVentas.Controls.Add(Me.viewDatosVentas)
        Me.GBVentas.Location = New System.Drawing.Point(8, 256)
        Me.GBVentas.Name = "GBVentas"
        Me.GBVentas.Size = New System.Drawing.Size(736, 168)
        Me.GBVentas.TabIndex = 86
        Me.GBVentas.TabStop = False
        Me.GBVentas.Text = "Ventas"
        '
        'viewDatosVentas
        '
        Me.viewDatosVentas.AllowUserToAddRows = False
        Me.viewDatosVentas.AllowUserToDeleteRows = False
        Me.viewDatosVentas.AllowUserToResizeColumns = False
        Me.viewDatosVentas.AllowUserToResizeRows = False
        Me.viewDatosVentas.AutoGenerateColumns = False
        Me.viewDatosVentas.BackgroundColor = System.Drawing.Color.White
        Me.viewDatosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatosVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumFacturaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreClienteDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.CodArticuloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUnitDataGridViewTextBoxColumn, Me.ImpuestoDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.viewDatosVentas.DataSource = Me.MovimientoArticuloVentasBindingSource
        Me.viewDatosVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewDatosVentas.Location = New System.Drawing.Point(3, 16)
        Me.viewDatosVentas.MultiSelect = False
        Me.viewDatosVentas.Name = "viewDatosVentas"
        Me.viewDatosVentas.ReadOnly = True
        Me.viewDatosVentas.RowHeadersVisible = False
        Me.viewDatosVentas.RowTemplate.Height = 25
        Me.viewDatosVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatosVentas.Size = New System.Drawing.Size(730, 149)
        Me.viewDatosVentas.TabIndex = 0
        '
        'MovimientoArticuloVentasBindingSource
        '
        Me.MovimientoArticuloVentasBindingSource.DataMember = "MovimientoArticuloVentas"
        Me.MovimientoArticuloVentasBindingSource.DataSource = Me.DsMovimientoArticulos1
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
        Me.Label5.Location = New System.Drawing.Point(400, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
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
        Me.Label6.Location = New System.Drawing.Point(400, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
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
        'DsAumento
        '
        Me.DsAumento.DataSetName = "dsAumento"
        Me.DsAumento.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsAumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsAumentoBindingSource
        '
        Me.DsAumentoBindingSource.DataSource = Me.DsAumento
        Me.DsAumentoBindingSource.Position = 0
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacturaDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCompraDataGridViewTextBoxColumn
        '
        Me.TipoCompraDataGridViewTextBoxColumn.DataPropertyName = "TipoCompra"
        Me.TipoCompraDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoCompraDataGridViewTextBoxColumn.Name = "TipoCompraDataGridViewTextBoxColumn"
        Me.TipoCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCompraDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.Width = 75
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 275
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn1.Visible = False
        '
        'CodArticuloDataGridViewTextBoxColumn1
        '
        Me.CodArticuloDataGridViewTextBoxColumn1.DataPropertyName = "CodArticulo"
        Me.CodArticuloDataGridViewTextBoxColumn1.HeaderText = "CodArticulo"
        Me.CodArticuloDataGridViewTextBoxColumn1.Name = "CodArticuloDataGridViewTextBoxColumn1"
        Me.CodArticuloDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodArticuloDataGridViewTextBoxColumn1.Visible = False
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.CantidadDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn1.Width = 75
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 80
        '
        'ImpuestoPDataGridViewTextBoxColumn
        '
        Me.ImpuestoPDataGridViewTextBoxColumn.DataPropertyName = "Impuesto_P"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.ImpuestoPDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImpuestoPDataGridViewTextBoxColumn.HeaderText = "Impuesto"
        Me.ImpuestoPDataGridViewTextBoxColumn.Name = "ImpuestoPDataGridViewTextBoxColumn"
        Me.ImpuestoPDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoPDataGridViewTextBoxColumn.Width = 70
        '
        'IdCompraDataGridViewTextBoxColumn
        '
        Me.IdCompraDataGridViewTextBoxColumn.DataPropertyName = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn.HeaderText = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn.Name = "IdCompraDataGridViewTextBoxColumn"
        Me.IdCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCompraDataGridViewTextBoxColumn.Visible = False
        '
        'NumFacturaDataGridViewTextBoxColumn
        '
        Me.NumFacturaDataGridViewTextBoxColumn.DataPropertyName = "Num_Factura"
        Me.NumFacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.NumFacturaDataGridViewTextBoxColumn.Name = "NumFacturaDataGridViewTextBoxColumn"
        Me.NumFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumFacturaDataGridViewTextBoxColumn.Width = 80
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Cliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        Me.NombreClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreClienteDataGridViewTextBoxColumn.Width = 275
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Visible = False
        '
        'CodArticuloDataGridViewTextBoxColumn
        '
        Me.CodArticuloDataGridViewTextBoxColumn.DataPropertyName = "CodArticulo"
        Me.CodArticuloDataGridViewTextBoxColumn.HeaderText = "CodArticulo"
        Me.CodArticuloDataGridViewTextBoxColumn.Name = "CodArticuloDataGridViewTextBoxColumn"
        Me.CodArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodArticuloDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 75
        '
        'PrecioUnitDataGridViewTextBoxColumn
        '
        Me.PrecioUnitDataGridViewTextBoxColumn.DataPropertyName = "Precio_Unit"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.PrecioUnitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrecioUnitDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioUnitDataGridViewTextBoxColumn.Name = "PrecioUnitDataGridViewTextBoxColumn"
        Me.PrecioUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUnitDataGridViewTextBoxColumn.Width = 80
        '
        'ImpuestoDataGridViewTextBoxColumn
        '
        Me.ImpuestoDataGridViewTextBoxColumn.DataPropertyName = "Impuesto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.ImpuestoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ImpuestoDataGridViewTextBoxColumn.HeaderText = "Impuesto"
        Me.ImpuestoDataGridViewTextBoxColumn.Name = "ImpuestoDataGridViewTextBoxColumn"
        Me.ImpuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoDataGridViewTextBoxColumn.Width = 70
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
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
        CType(Me.viewDatosCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoArticulosCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMovimientoArticulos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBVentas.ResumeLayout(False)
        CType(Me.viewDatosVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoArticuloVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVendido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatosVentas.CellDoubleClick
        Try
            Dim Id As String = Me.viewDatosVentas.Item("IdDataGridViewTextBoxColumn", Me.viewDatosVentas.CurrentRow.Index).Value
            If MsgBox("Desea Abrir la factura de Venta", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Dim frm As New Facturacion
                frm.MdiParent = Me.ParentForm
                frm.Show()
                frm.AbreDesdeAfuera(Id)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub viewDatosCompras_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatosCompras.CellDoubleClick
        Try
            Dim Id As String = Me.viewDatosCompras.Item("IdCompraDataGridViewTextBoxColumn", Me.viewDatosCompras.CurrentRow.Index).Value
            If MsgBox("Desea Abrir la Compra", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Dim frm As New frmCompra(Me.usua)
                frm.MdiParent = Me.MdiParent
                frm.Show()
                frm.CargarCompradesdeAfuera(Id)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

