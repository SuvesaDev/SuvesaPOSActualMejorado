Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmMovimientoCajaPago
    Inherits System.Windows.Forms.Form
    'Public Movimiento_Pago_Factura As New frmMovimientoCajaPagoAbono
    Dim usua

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents dafactura As System.Data.SqlClient.SqlDataAdapter
    ' Friend WithEvents Dsfactura As dsfactura
    Friend WithEvents DGFactpendiente As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colNum_Factura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombre_Cliente As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCod_Vendedor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Dsfactura21 As Dsfactura2
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMovimientoCajaPago))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.DGFactpendiente = New DevExpress.XtraGrid.GridControl
        Me.Dsfactura21 = New LcPymes_5._2.Dsfactura2
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colNum_Factura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNombre_Cliente = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCod_Vendedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTipo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Label15 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.dafactura = New System.Data.SqlClient.SqlDataAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.DGFactpendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfactura21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 415)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(736, 56)
        Me.ToolBar1.TabIndex = 30
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Actualizar"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        Me.ToolBarRegistrar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'DGFactpendiente
        '
        Me.DGFactpendiente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGFactpendiente.DataMember = "Ventas"
        Me.DGFactpendiente.DataSource = Me.Dsfactura21
        '
        'DGFactpendiente.EmbeddedNavigator
        '
        Me.DGFactpendiente.EmbeddedNavigator.Name = ""
        Me.DGFactpendiente.Location = New System.Drawing.Point(8, 32)
        Me.DGFactpendiente.MainView = Me.AdvBandedGridView1
        Me.DGFactpendiente.Name = "DGFactpendiente"
        Me.DGFactpendiente.Size = New System.Drawing.Size(720, 376)
        Me.DGFactpendiente.TabIndex = 32
        '
        'Dsfactura21
        '
        Me.Dsfactura21.DataSetName = "Dsfactura2"
        Me.Dsfactura21.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colNum_Factura, Me.colTipo, Me.colNombre_Cliente, Me.colCod_Vendedor, Me.colTotal, Me.colFecha})
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsCustomization.AllowGroup = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.colNum_Factura)
        Me.GridBand1.Columns.Add(Me.colNombre_Cliente)
        Me.GridBand1.Columns.Add(Me.colTotal)
        Me.GridBand1.Columns.Add(Me.colCod_Vendedor)
        Me.GridBand1.Columns.Add(Me.colTipo)
        Me.GridBand1.Columns.Add(Me.colFecha)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 706
        '
        'colNum_Factura
        '
        Me.colNum_Factura.Caption = "Factura"
        Me.colNum_Factura.FieldName = "Num_Factura"
        Me.colNum_Factura.Name = "colNum_Factura"
        Me.colNum_Factura.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNum_Factura.Visible = True
        Me.colNum_Factura.Width = 73
        '
        'colNombre_Cliente
        '
        Me.colNombre_Cliente.Caption = "Cliente"
        Me.colNombre_Cliente.FieldName = "Nombre_Cliente"
        Me.colNombre_Cliente.Name = "colNombre_Cliente"
        Me.colNombre_Cliente.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNombre_Cliente.Visible = True
        Me.colNombre_Cliente.Width = 209
        '
        'colTotal
        '
        Me.colTotal.Caption = "Monto"
        Me.colTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.Visible = True
        Me.colTotal.Width = 96
        '
        'colCod_Vendedor
        '
        Me.colCod_Vendedor.Caption = "Vendedor"
        Me.colCod_Vendedor.FieldName = "Vendedor"
        Me.colCod_Vendedor.Name = "colCod_Vendedor"
        Me.colCod_Vendedor.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCod_Vendedor.Visible = True
        Me.colCod_Vendedor.Width = 190
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipo.Visible = True
        Me.colTipo.Width = 68
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFecha.Visible = True
        Me.colFecha.Width = 70
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(0, -8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(736, 40)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Facturas Pendientes de Pago"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=SeePos"
        '
        'dafactura
        '
        Me.dafactura.InsertCommand = Me.SqlInsertCommand1
        Me.dafactura.SelectCommand = Me.SqlSelectCommand1
        Me.dafactura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Pago_Comision", "Pago_Comision"), New System.Data.Common.DataColumnMapping("Vendedor", "Vendedor"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("Cod_Encargado_Compra", "Cod_Encargado_Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("AsientoVenta", "AsientoVenta"), New System.Data.Common.DataColumnMapping("ContabilizadoCVenta", "ContabilizadoCVenta"), New System.Data.Common.DataColumnMapping("AsientoCosto", "AsientoCosto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Entregado", "Entregado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Moneda_Nombre", "Moneda_Nombre"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15000
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Ventas.Num_Factura, Ventas.Tipo, Ventas.Cod_Cliente, Ventas.Nombre_Cliente" & _
        ", Ventas.Orden, Ventas.Pago_Comision, ISNULL(Usuarios.Nombre, Ventas.Cedula_Usua" & _
        "rio) AS Vendedor, Ventas.SubTotal, Ventas.Descuento, Ventas.Imp_Venta, Ventas.To" & _
        "tal, Ventas.Fecha, Ventas.Vence, Ventas.Cod_Encargado_Compra, Ventas.Contabiliza" & _
        "do, Ventas.AsientoVenta, Ventas.ContabilizadoCVenta, Ventas.AsientoCosto, Ventas" & _
        ".Anulado, Ventas.PagoImpuesto, Ventas.FacturaCancelado, Ventas.Num_Apertura, Ven" & _
        "tas.Entregado, Ventas.Cod_Moneda, Ventas.Moneda_Nombre, Ventas.Id FROM Ventas LE" & _
        "FT OUTER JOIN Usuarios ON Usuarios.Cedula = Ventas.Cedula_Usuario WHERE (Ventas." & _
        "FacturaCancelado = 0) AND (Ventas.Anulado = 0) AND (Ventas.Tipo <> 'CRE') AND (V" & _
        "entas.Tipo <> 'TCR') AND (Ventas.Tipo <> 'MCR')"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Ventas(Num_Factura, Tipo, Cod_Cliente, Nombre_Cliente, Orden, Pago_Co" & _
        "mision, SubTotal, Descuento, Imp_Venta, Total, Fecha, Vence, Cod_Encargado_Compr" & _
        "a, Contabilizado, AsientoVenta, ContabilizadoCVenta, AsientoCosto, Anulado, Pago" & _
        "Impuesto, FacturaCancelado, Num_Apertura, Entregado, Cod_Moneda, Moneda_Nombre) " & _
        "VALUES (@Num_Factura, @Tipo, @Cod_Cliente, @Nombre_Cliente, @Orden, @Pago_Comisi" & _
        "on, @SubTotal, @Descuento, @Imp_Venta, @Total, @Fecha, @Vence, @Cod_Encargado_Co" & _
        "mpra, @Contabilizado, @AsientoVenta, @ContabilizadoCVenta, @AsientoCosto, @Anula" & _
        "do, @PagoImpuesto, @FacturaCancelado, @Num_Apertura, @Entregado, @Cod_Moneda, @M" & _
        "oneda_Nombre)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 8, "Num_Factura"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 1, "Pago_Comision"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 4, "Vence"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 75, "Cod_Encargado_Compra"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 8, "AsientoVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 1, "ContabilizadoCVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 8, "AsientoCosto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 4, "PagoImpuesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 1, "FacturaCancelado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 1, "Entregado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 50, "Moneda_Nombre"))
        '
        'frmMovimientoCajaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 471)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DGFactpendiente)
        Me.Controls.Add(Me.ToolBar1)
        Me.Name = "frmMovimientoCajaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento Caja de Pago"
        CType(Me.DGFactpendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfactura21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
#End Region

    Function BuscarById(ByVal columna As DataRow)
        Try
            Dim IdFactura As Long = columna!Id
            Dim Movimiento_Pago_Factura = New frmMovimientoCajaPagoAbono(usua)
            Movimiento_Pago_Factura.Factura = columna!Num_Factura
            Movimiento_Pago_Factura.fecha = "" & columna!fecha
            Movimiento_Pago_Factura.Total = columna!total
            Movimiento_Pago_Factura.Cod_Cliente = columna!Cod_Cliente

            If columna!Tipo = "TCO" Then
                Movimiento_Pago_Factura.Tipo = "FVT"
            ElseIf columna!Tipo = "MCO" Then
                Movimiento_Pago_Factura.Tipo = "FVM"
            ElseIf columna!Tipo = "PVE" Then
                Movimiento_Pago_Factura.Tipo = "FVP"
            Else
                Movimiento_Pago_Factura.Tipo = "FVC"
            End If

            Movimiento_Pago_Factura.codmod = columna!Cod_Moneda
            Movimiento_Pago_Factura.ShowDialog()

            If Movimiento_Pago_Factura.Registra Then
                Dim Cx As New Conexion

                If Movimiento_Pago_Factura.RegistrarOpcionesPago() Then ' And (Cx.UpdateRecords("Ventas", "FacturaCancelado = 1, Num_Apertura = " & Movimiento_Pago_Factura.NApertura, "Num_Factura = " & Movimiento_Pago_Factura.Factura & " and Tipo = '" & columna!Tipo & "'")) = "" Then

                    MsgBox("Factura registrada satisfactoriamente...")

                    Dim PrepagoAplicado As Decimal = Movimiento_Pago_Factura.PrepagoAplicado
                    Cx.UpdateRecords("Ventas", "FacturaCancelado = 1, Prepago = " & PrepagoAplicado & ", Num_Apertura = " & Movimiento_Pago_Factura.NApertura, " Id = " & IdFactura)

                    Movimiento_Pago_Factura.DataSet_Opciones_Pago1.Detalle_pago_caja.Clear()
                    Movimiento_Pago_Factura.DataSet_Opciones_Pago1.OpcionesDePago.Clear()

                    Me.ImprimirFactura(IdFactura, 1)

                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

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

                Case "CUPONES" 'CUPONES DE RIFAS
                    If PrinterToSelect = 7 Then
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

    Private Sub ImprimirFactura(_Id As Long, _Caja As Integer)
        Dim facturaPVE As New Reporte_FacturaPVEs
        CrystalReportsConexion.LoadReportViewer(Nothing, facturaPVE, True)

        If _Caja = 1 Or _Caja = 11 Then
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

            facturaPVE.SetParameterValue(0, False)
            facturaPVE.SetParameterValue(1, False)
            facturaPVE.SetParameterValue(2, _Id)
            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            If esTermica = True Then
                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        End If
        If _Caja = 2 Or _Caja = 12 Then
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

            facturaPVE.SetParameterValue(0, False)
            facturaPVE.SetParameterValue(1, False)
            facturaPVE.SetParameterValue(2, _Id)
            facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            If esTermica = True Then
                facturaPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        End If
    End Sub

    Private esTermica As Boolean = False
    Private Sub frmMovimientoCajaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS()

            Me.dafactura.Fill(Me.Dsfactura21, "ventas")
            Refrescar()

            Try
                If GetSetting("SeeSoft", "SeePOS", "estermica") = "" Then
                    SaveSetting("SeeSoft", "seepos", "estermica", "false")
                    esTermica = False
                Else
                    esTermica = GetSetting("SeeSoft", "SeePOS", "estermica")
                End If
            Catch ex As Exception
                SaveSetting("SeeSoft", "seepos", "estermica", "false")
                esTermica = False
            End Try

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Refrescar()
        Try
            Me.Dsfactura21.Clear()
            Me.dafactura.Fill(Me.Dsfactura21, "ventas")
            Me.BindingContext(Me.Dsfactura21, "ventas").Position = Me.BindingContext(Me.Dsfactura21, "ventas").Count
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1
                Refrescar()
            Case 7
                Me.Close()
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Refrescar()
    End Sub

    Private Sub DGFactpendiente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGFactpendiente.DoubleClick
        Try
            Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = _
                    AdvBandedGridView1.CalcHitInfo(CType(DGFactpendiente, Control).PointToClient(Control.MousePosition))
            Me.DGFactpendiente.Enabled = False
            If hi.RowHandle >= 0 Then

                BuscarById(AdvBandedGridView1.GetDataRow(hi.RowHandle))
                Me.DialogResult = DialogResult.OK

            ElseIf AdvBandedGridView1.FocusedRowHandle >= 0 Then
                BuscarById(AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle))
                Me.DialogResult = DialogResult.OK
            Else
                BuscarById(Nothing)
            End If


        Catch ex As SystemException
            MsgBox(ex.Message)

        Finally
            Refrescar()
            Me.DGFactpendiente.Enabled = True

        End Try
    End Sub

End Class
