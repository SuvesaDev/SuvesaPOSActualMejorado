Imports System.data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class frm_prestamos
    Inherits System.Windows.Forms.Form
    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim AgregandoNuevoItem As Boolean
    Dim editando As Boolean = False
    Dim destino As Boolean = False
    Dim dts_historial As New DataTable

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
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        '  AddHandler Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").PositionChanged, AddressOf Me.Position_Changed
        ' AddHandler Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CurrentChanged, AddressOf Me.Current_Changed
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCod_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Adapter_prestamo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_detalle_prestamo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPrestamos1 As LcPymes_5._2.dsPrestamos
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbempresa As System.Windows.Forms.Label
    Friend WithEvents dt_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents adapter_clientes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtCodArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_base As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lbdescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ck_anu As System.Windows.Forms.CheckBox
    Friend WithEvents lb_anu As System.Windows.Forms.Label
    Friend WithEvents lb_prestamo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbEntregado As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colmarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents op_Salida As System.Windows.Forms.RadioButton
    Friend WithEvents op_Entrada As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_destino As System.Windows.Forms.TextBox
    Friend WithEvents lbldestino As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents panelnota As System.Windows.Forms.GroupBox
    Friend WithEvents listado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_prestamos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.DsPrestamos1 = New LcPymes_5._2.dsPrestamos
        Me.Label2 = New System.Windows.Forms.Label
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmarca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCod_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_base = New DevExpress.XtraEditors.TextEdit
        Me.lbdescripcion = New System.Windows.Forms.Label
        Me.Adapter_prestamo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_detalle_prestamo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.dt_entrega = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbempresa = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lb_prestamo = New System.Windows.Forms.Label
        Me.adapter_clientes = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.txtCodArticulo = New DevExpress.XtraEditors.TextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtobservacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.lb_anu = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbldestino = New System.Windows.Forms.Label
        Me.txt_destino = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.op_Salida = New System.Windows.Forms.RadioButton
        Me.op_Entrada = New System.Windows.Forms.RadioButton
        Me.lbEntregado = New System.Windows.Forms.Label
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ck_anu = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.panelnota = New System.Windows.Forms.GroupBox
        Me.listado = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtnota = New System.Windows.Forms.TextBox
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_base.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelnota.SuspendLayout()
        CType(Me.listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen:"
        '
        'txtcodigo
        '
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.cod_empresa"))
        Me.txtcodigo.Location = New System.Drawing.Point(72, 24)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(64, 23)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.Text = ""
        '
        'DsPrestamos1
        '
        Me.DsPrestamos1.DataSetName = "dsPrestamos"
        Me.DsPrestamos1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(416, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'dt_fecha
        '
        Me.dt_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.fecha"))
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dt_fecha.Location = New System.Drawing.Point(392, 32)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(104, 23)
        Me.dt_fecha.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Prestamo.Prestamodetalle_prestamo"
        Me.GridControl1.DataSource = Me.DsPrestamos1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 208)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(680, 168)
        Me.GridControl1.Styles.AddReplace("Style1", New DevExpress.Utils.ViewStyleEx("Style1", "", New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 184
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colPrecio_Unit, Me.colInterno, Me.colmarca})
        Me.GridView1.GroupPanelText = "Detalle de Cotización"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "cod_articulo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 101
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 400
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 74
        '
        'colPrecio_Unit
        '
        Me.colPrecio_Unit.Caption = "P.Unit"
        Me.colPrecio_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Unit.FieldName = "precio"
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Unit.VisibleIndex = 3
        Me.colPrecio_Unit.Width = 100
        '
        'colInterno
        '
        Me.colInterno.Caption = "Cod interno"
        Me.colInterno.FieldName = "codigo"
        Me.colInterno.Name = "colInterno"
        Me.colInterno.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        '
        'colmarca
        '
        Me.colmarca.Caption = "Entregado"
        Me.colmarca.FieldName = "entregado"
        Me.colmarca.Name = "colmarca"
        Me.colmarca.StyleName = "Style1"
        Me.colmarca.VisibleIndex = 4
        Me.colmarca.Width = 85
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(200, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 14)
        Me.Label10.TabIndex = 200
        Me.Label10.Text = "P. Base:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo.cantidad"))
        Me.txtCantidad.EditValue = 0
        Me.txtCantidad.Location = New System.Drawing.Point(272, 176)
        Me.txtCantidad.Name = "txtCantidad"
        '
        'txtCantidad.Properties
        '
        Me.txtCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCantidad.Size = New System.Drawing.Size(56, 19)
        Me.txtCantidad.TabIndex = 198
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(272, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 14)
        Me.Label15.TabIndex = 199
        Me.Label15.Text = "Cantidad"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(16, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 14)
        Me.Label13.TabIndex = 197
        Me.Label13.Text = "Código"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCod_Articulo
        '
        Me.txtCod_Articulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCod_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo.cod_articulo"))
        Me.txtCod_Articulo.EditValue = ""
        Me.txtCod_Articulo.Location = New System.Drawing.Point(16, 176)
        Me.txtCod_Articulo.Name = "txtCod_Articulo"
        '
        'txtCod_Articulo.Properties
        '
        Me.txtCod_Articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCod_Articulo.Properties.MaxLength = 19
        Me.txtCod_Articulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCod_Articulo.Size = New System.Drawing.Size(168, 21)
        Me.txtCod_Articulo.TabIndex = 202
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txt_base
        '
        Me.txt_base.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_base.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo.precio"))
        Me.txt_base.EditValue = 0
        Me.txt_base.Location = New System.Drawing.Point(200, 176)
        Me.txt_base.Name = "txt_base"
        '
        'txt_base.Properties
        '
        Me.txt_base.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_base.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_base.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_base.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txt_base.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_base.Size = New System.Drawing.Size(56, 19)
        Me.txt_base.TabIndex = 205
        '
        'lbdescripcion
        '
        Me.lbdescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbdescripcion.BackColor = System.Drawing.Color.DimGray
        Me.lbdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo.descripcion"))
        Me.lbdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbdescripcion.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbdescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbdescripcion.Location = New System.Drawing.Point(16, 136)
        Me.lbdescripcion.Name = "lbdescripcion"
        Me.lbdescripcion.Size = New System.Drawing.Size(680, 24)
        Me.lbdescripcion.TabIndex = 206
        Me.lbdescripcion.Text = "DESCRIPCION"
        Me.lbdescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Adapter_prestamo
        '
        Me.Adapter_prestamo.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_prestamo.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_prestamo.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_prestamo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Prestamo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("cod_empresa", "cod_empresa"), New System.Data.Common.DataColumnMapping("nombre_empresa", "nombre_empresa"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("fecha_entrega", "fecha_entrega"), New System.Data.Common.DataColumnMapping("anulado", "anulado"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("Salida", "Salida"), New System.Data.Common.DataColumnMapping("Entrada", "Entrada"), New System.Data.Common.DataColumnMapping("nombre_destino", "nombre_destino"), New System.Data.Common.DataColumnMapping("cod_destino", "cod_destino"), New System.Data.Common.DataColumnMapping("observacion", "observacion"), New System.Data.Common.DataColumnMapping("nota", "nota")})})
        Me.Adapter_prestamo.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Prestamo WHERE (ID = @Original_ID) AND (Entrada = @Original_Entrada O" & _
        "R @Original_Entrada IS NULL AND Entrada IS NULL) AND (Salida = @Original_Salida " & _
        "OR @Original_Salida IS NULL AND Salida IS NULL) AND (anulado = @Original_anulado" & _
        ") AND (cod_destino = @Original_cod_destino OR @Original_cod_destino IS NULL AND " & _
        "cod_destino IS NULL) AND (cod_empresa = @Original_cod_empresa) AND (estado = @Or" & _
        "iginal_estado) AND (fecha = @Original_fecha) AND (fecha_entrega = @Original_fech" & _
        "a_entrega) AND (nombre_destino = @Original_nombre_destino OR @Original_nombre_de" & _
        "stino IS NULL AND nombre_destino IS NULL) AND (nombre_empresa = @Original_nombre" & _
        "_empresa) AND (nota = @Original_nota OR @Original_nota IS NULL AND nota IS NULL)" & _
        " AND (observacion = @Original_observacion OR @Original_observacion IS NULL AND o" & _
        "bservacion IS NULL) AND (usuario = @Original_usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Entrada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_destino", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_destino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_empresa", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_entrega", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_entrega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre_destino", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre_destino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre_empresa", System.Data.SqlDbType.NVarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre_empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.NVarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observacion", System.Data.SqlDbType.NVarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=s" & _
        "eepos"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Prestamo(cod_empresa, nombre_empresa, fecha, usuario, fecha_entrega, " & _
        "anulado, estado, Salida, Entrada, nombre_destino, cod_destino, observacion, nota" & _
        ") VALUES (@cod_empresa, @nombre_empresa, @fecha, @usuario, @fecha_entrega, @anul" & _
        "ado, @estado, @Salida, @Entrada, @nombre_destino, @cod_destino, @observacion, @n" & _
        "ota); SELECT ID, cod_empresa, nombre_empresa, fecha, usuario, fecha_entrega, anu" & _
        "lado, estado, Salida, Entrada, nombre_destino, cod_destino, observacion, nota FR" & _
        "OM Prestamo WHERE (ID = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_empresa", System.Data.SqlDbType.NVarChar, 50, "cod_empresa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre_empresa", System.Data.SqlDbType.NVarChar, 70, "nombre_empresa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.NVarChar, 50, "usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_entrega", System.Data.SqlDbType.DateTime, 8, "fecha_entrega"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anulado", System.Data.SqlDbType.Bit, 1, "anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.Bit, 1, "estado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 1, "Entrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre_destino", System.Data.SqlDbType.NVarChar, 50, "nombre_destino"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_destino", System.Data.SqlDbType.NVarChar, 50, "cod_destino"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.NVarChar, 150, "observacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.NVarChar, 150, "nota"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID, cod_empresa, nombre_empresa, fecha, usuario, fecha_entrega, anulado, e" & _
        "stado, Salida, Entrada, nombre_destino, cod_destino, observacion, nota FROM Pres" & _
        "tamo"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Prestamo SET cod_empresa = @cod_empresa, nombre_empresa = @nombre_empresa," & _
        " fecha = @fecha, usuario = @usuario, fecha_entrega = @fecha_entrega, anulado = @" & _
        "anulado, estado = @estado, Salida = @Salida, Entrada = @Entrada, nombre_destino " & _
        "= @nombre_destino, cod_destino = @cod_destino, observacion = @observacion, nota " & _
        "= @nota WHERE (ID = @Original_ID) AND (Entrada = @Original_Entrada OR @Original_" & _
        "Entrada IS NULL AND Entrada IS NULL) AND (Salida = @Original_Salida OR @Original" & _
        "_Salida IS NULL AND Salida IS NULL) AND (anulado = @Original_anulado) AND (cod_d" & _
        "estino = @Original_cod_destino OR @Original_cod_destino IS NULL AND cod_destino " & _
        "IS NULL) AND (cod_empresa = @Original_cod_empresa) AND (estado = @Original_estad" & _
        "o) AND (fecha = @Original_fecha) AND (fecha_entrega = @Original_fecha_entrega) A" & _
        "ND (nombre_destino = @Original_nombre_destino OR @Original_nombre_destino IS NUL" & _
        "L AND nombre_destino IS NULL) AND (nombre_empresa = @Original_nombre_empresa) AN" & _
        "D (nota = @Original_nota OR @Original_nota IS NULL AND nota IS NULL) AND (observ" & _
        "acion = @Original_observacion OR @Original_observacion IS NULL AND observacion I" & _
        "S NULL) AND (usuario = @Original_usuario); SELECT ID, cod_empresa, nombre_empres" & _
        "a, fecha, usuario, fecha_entrega, anulado, estado, Salida, Entrada, nombre_desti" & _
        "no, cod_destino, observacion, nota FROM Prestamo WHERE (ID = @ID)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_empresa", System.Data.SqlDbType.NVarChar, 50, "cod_empresa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre_empresa", System.Data.SqlDbType.NVarChar, 70, "nombre_empresa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.NVarChar, 50, "usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_entrega", System.Data.SqlDbType.DateTime, 8, "fecha_entrega"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anulado", System.Data.SqlDbType.Bit, 1, "anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.Bit, 1, "estado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 1, "Entrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre_destino", System.Data.SqlDbType.NVarChar, 50, "nombre_destino"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_destino", System.Data.SqlDbType.NVarChar, 50, "cod_destino"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.NVarChar, 150, "observacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.NVarChar, 150, "nota"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Entrada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_destino", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_destino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_empresa", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_entrega", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_entrega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre_destino", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre_destino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre_empresa", System.Data.SqlDbType.NVarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre_empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.NVarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observacion", System.Data.SqlDbType.NVarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.BigInt, 8, "ID"))
        '
        'Adapter_detalle_prestamo
        '
        Me.Adapter_detalle_prestamo.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_detalle_prestamo.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_detalle_prestamo.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_detalle_prestamo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_prestamo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("ID_prestamo", "ID_prestamo"), New System.Data.Common.DataColumnMapping("codigo", "codigo"), New System.Data.Common.DataColumnMapping("cod_articulo", "cod_articulo"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("entregado", "entregado")})})
        Me.Adapter_detalle_prestamo.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM detalle_prestamo WHERE (ID = @Original_ID) AND (ID_prestamo = @Origin" & _
        "al_ID_prestamo) AND (cantidad = @Original_cantidad) AND (cod_articulo = @Origina" & _
        "l_cod_articulo) AND (codigo = @Original_codigo) AND (descripcion = @Original_des" & _
        "cripcion) AND (entregado = @Original_entregado OR @Original_entregado IS NULL AN" & _
        "D entregado IS NULL) AND (precio = @Original_precio)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_prestamo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_articulo", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_articulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.NVarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_entregado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO detalle_prestamo(ID_prestamo, codigo, cod_articulo, descripcion, cant" & _
        "idad, precio, entregado) VALUES (@ID_prestamo, @codigo, @cod_articulo, @descripc" & _
        "ion, @cantidad, @precio, @entregado); SELECT ID, ID_prestamo, codigo, cod_articu" & _
        "lo, descripcion, cantidad, precio, entregado FROM detalle_prestamo WHERE (ID = @" & _
        "@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_prestamo", System.Data.SqlDbType.BigInt, 8, "ID_prestamo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codigo", System.Data.SqlDbType.BigInt, 8, "codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_articulo", System.Data.SqlDbType.NVarChar, 50, "cod_articulo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.NVarChar, 150, "descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Float, 8, "cantidad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entregado", System.Data.SqlDbType.Bit, 1, "entregado"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID, ID_prestamo, codigo, cod_articulo, descripcion, cantidad, precio, entr" & _
        "egado FROM detalle_prestamo"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE detalle_prestamo SET ID_prestamo = @ID_prestamo, codigo = @codigo, cod_art" & _
        "iculo = @cod_articulo, descripcion = @descripcion, cantidad = @cantidad, precio " & _
        "= @precio, entregado = @entregado WHERE (ID = @Original_ID) AND (ID_prestamo = @" & _
        "Original_ID_prestamo) AND (cantidad = @Original_cantidad) AND (cod_articulo = @O" & _
        "riginal_cod_articulo) AND (codigo = @Original_codigo) AND (descripcion = @Origin" & _
        "al_descripcion) AND (entregado = @Original_entregado OR @Original_entregado IS N" & _
        "ULL AND entregado IS NULL) AND (precio = @Original_precio); SELECT ID, ID_presta" & _
        "mo, codigo, cod_articulo, descripcion, cantidad, precio, entregado FROM detalle_" & _
        "prestamo WHERE (ID = @ID)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_prestamo", System.Data.SqlDbType.BigInt, 8, "ID_prestamo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codigo", System.Data.SqlDbType.BigInt, 8, "codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_articulo", System.Data.SqlDbType.NVarChar, 50, "cod_articulo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.NVarChar, 150, "descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Float, 8, "cantidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Float, 8, "precio"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entregado", System.Data.SqlDbType.Bit, 1, "entregado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_prestamo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_articulo", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_articulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.NVarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_entregado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.BigInt, 8, "ID"))
        '
        'dt_entrega
        '
        Me.dt_entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.fecha_entrega"))
        Me.dt_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dt_entrega.Location = New System.Drawing.Point(512, 32)
        Me.dt_entrega.Name = "dt_entrega"
        Me.dt_entrega.Size = New System.Drawing.Size(96, 23)
        Me.dt_entrega.TabIndex = 208
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(512, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Fecha entrega"
        '
        'lbempresa
        '
        Me.lbempresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbempresa.BackColor = System.Drawing.Color.Transparent
        Me.lbempresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.nombre_empresa"))
        Me.lbempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbempresa.ForeColor = System.Drawing.Color.Black
        Me.lbempresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbempresa.Location = New System.Drawing.Point(144, 36)
        Me.lbempresa.Name = "lbempresa"
        Me.lbempresa.Size = New System.Drawing.Size(168, 24)
        Me.lbempresa.TabIndex = 209
        Me.lbempresa.Text = "DESCRIPCION EMPRESA"
        Me.lbempresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(24, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "# Prestamo"
        '
        'lb_prestamo
        '
        Me.lb_prestamo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.ID"))
        Me.lb_prestamo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_prestamo.ForeColor = System.Drawing.Color.Red
        Me.lb_prestamo.Location = New System.Drawing.Point(144, 8)
        Me.lb_prestamo.Name = "lb_prestamo"
        Me.lb_prestamo.Size = New System.Drawing.Size(72, 24)
        Me.lb_prestamo.TabIndex = 211
        Me.lb_prestamo.Text = "0"
        '
        'adapter_clientes
        '
        Me.adapter_clientes.DeleteCommand = Me.SqlDeleteCommand3
        Me.adapter_clientes.InsertCommand = Me.SqlInsertCommand3
        Me.adapter_clientes.SelectCommand = Me.SqlSelectCommand3
        Me.adapter_clientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes_frecuentes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("esempresa", "esempresa")})})
        Me.adapter_clientes.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Clientes_frecuentes WHERE (identificacion = @Original_identificacion)" & _
        " AND (Anulado = @Original_Anulado) AND (Telefono_01 = @Original_Telefono_01) AND" & _
        " (cedula = @Original_cedula) AND (direccion = @Original_direccion) AND (e_mail =" & _
        " @Original_e_mail) AND (esempresa = @Original_esempresa OR @Original_esempresa I" & _
        "S NULL AND esempresa IS NULL) AND (fax_01 = @Original_fax_01) AND (fax_02 = @Ori" & _
        "ginal_fax_02) AND (nombre = @Original_nombre) AND (nombreusuario = @Original_nom" & _
        "breusuario) AND (observaciones = @Original_observaciones) AND (telefono_02 = @Or" & _
        "iginal_telefono_02) AND (tipoprecio = @Original_tipoprecio) AND (usuario = @Orig" & _
        "inal_usuario)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_esempresa", System.Data.SqlDbType.BigInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "esempresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Clientes_frecuentes(identificacion, cedula, nombre, observaciones, Te" & _
        "lefono_01, telefono_02, fax_01, fax_02, e_mail, direccion, tipoprecio, usuario, " & _
        "nombreusuario, Anulado, esempresa) VALUES (@identificacion, @cedula, @nombre, @o" & _
        "bservaciones, @Telefono_01, @telefono_02, @fax_01, @fax_02, @e_mail, @direccion," & _
        " @tipoprecio, @usuario, @nombreusuario, @Anulado, @esempresa); SELECT identifica" & _
        "cion, cedula, nombre, observaciones, Telefono_01, telefono_02, fax_01, fax_02, e" & _
        "_mail, direccion, tipoprecio, usuario, nombreusuario, Anulado, esempresa FROM Cl" & _
        "ientes_frecuentes WHERE (identificacion = @identificacion)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@esempresa", System.Data.SqlDbType.BigInt, 1, "esempresa"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, f" & _
        "ax_01, fax_02, e_mail, direccion, tipoprecio, usuario, nombreusuario, Anulado, e" & _
        "sempresa FROM Clientes_frecuentes"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Clientes_frecuentes SET identificacion = @identificacion, cedula = @cedula" & _
        ", nombre = @nombre, observaciones = @observaciones, Telefono_01 = @Telefono_01, " & _
        "telefono_02 = @telefono_02, fax_01 = @fax_01, fax_02 = @fax_02, e_mail = @e_mail" & _
        ", direccion = @direccion, tipoprecio = @tipoprecio, usuario = @usuario, nombreus" & _
        "uario = @nombreusuario, Anulado = @Anulado, esempresa = @esempresa WHERE (identi" & _
        "ficacion = @Original_identificacion) AND (Anulado = @Original_Anulado) AND (Tele" & _
        "fono_01 = @Original_Telefono_01) AND (cedula = @Original_cedula) AND (direccion " & _
        "= @Original_direccion) AND (e_mail = @Original_e_mail) AND (esempresa = @Origina" & _
        "l_esempresa OR @Original_esempresa IS NULL AND esempresa IS NULL) AND (fax_01 = " & _
        "@Original_fax_01) AND (fax_02 = @Original_fax_02) AND (nombre = @Original_nombre" & _
        ") AND (nombreusuario = @Original_nombreusuario) AND (observaciones = @Original_o" & _
        "bservaciones) AND (telefono_02 = @Original_telefono_02) AND (tipoprecio = @Origi" & _
        "nal_tipoprecio) AND (usuario = @Original_usuario); SELECT identificacion, cedula" & _
        ", nombre, observaciones, Telefono_01, telefono_02, fax_01, fax_02, e_mail, direc" & _
        "cion, tipoprecio, usuario, nombreusuario, Anulado, esempresa FROM Clientes_frecu" & _
        "entes WHERE (identificacion = @identificacion)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@esempresa", System.Data.SqlDbType.BigInt, 1, "esempresa"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_esempresa", System.Data.SqlDbType.BigInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "esempresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo.codigo"))
        Me.txtCodArticulo.EditValue = ""
        Me.txtCodArticulo.Location = New System.Drawing.Point(24, 224)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        '
        'txtCodArticulo.Properties
        '
        Me.txtCodArticulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCodArticulo.Properties.MaxLength = 19
        Me.txtCodArticulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCodArticulo.Size = New System.Drawing.Size(144, 19)
        Me.txtCodArticulo.TabIndex = 212
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.txtobservacion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lb_anu)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Controls.Add(Me.txt_base)
        Me.Panel1.Controls.Add(Me.lbdescripcion)
        Me.Panel1.Controls.Add(Me.txtCodArticulo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtCod_Articulo)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(16, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 424)
        Me.Panel1.TabIndex = 213
        '
        'txtobservacion
        '
        Me.txtobservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.observacion"))
        Me.txtobservacion.Location = New System.Drawing.Point(96, 384)
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(600, 23)
        Me.txtobservacion.TabIndex = 217
        Me.txtobservacion.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 216
        Me.Label7.Text = "Observación"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(568, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 23)
        Me.Button2.TabIndex = 215
        Me.Button2.Text = "Guardar selección"
        '
        'lb_anu
        '
        Me.lb_anu.BackColor = System.Drawing.Color.Transparent
        Me.lb_anu.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_anu.ForeColor = System.Drawing.Color.Red
        Me.lb_anu.Location = New System.Drawing.Point(272, 224)
        Me.lb_anu.Name = "lb_anu"
        Me.lb_anu.Size = New System.Drawing.Size(248, 56)
        Me.lb_anu.TabIndex = 214
        Me.lb_anu.Text = "ANULADO"
        Me.lb_anu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_anu.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.lbldestino)
        Me.GroupBox1.Controls.Add(Me.txt_destino)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.op_Salida)
        Me.GroupBox1.Controls.Add(Me.op_Entrada)
        Me.GroupBox1.Controls.Add(Me.dt_fecha)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dt_entrega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbempresa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 104)
        Me.GroupBox1.TabIndex = 213
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'lbldestino
        '
        Me.lbldestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldestino.BackColor = System.Drawing.Color.Transparent
        Me.lbldestino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.nombre_destino"))
        Me.lbldestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldestino.ForeColor = System.Drawing.Color.Black
        Me.lbldestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldestino.Location = New System.Drawing.Point(144, 76)
        Me.lbldestino.Name = "lbldestino"
        Me.lbldestino.Size = New System.Drawing.Size(168, 24)
        Me.lbldestino.TabIndex = 214
        Me.lbldestino.Text = "DESCRIPCION EMPRESA"
        Me.lbldestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_destino
        '
        Me.txt_destino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.cod_destino"))
        Me.txt_destino.Location = New System.Drawing.Point(72, 64)
        Me.txt_destino.Name = "txt_destino"
        Me.txt_destino.Size = New System.Drawing.Size(64, 23)
        Me.txt_destino.TabIndex = 213
        Me.txt_destino.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 212
        Me.Label5.Text = "Destino :"
        '
        'op_Salida
        '
        Me.op_Salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_Salida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.op_Salida.Location = New System.Drawing.Point(512, 72)
        Me.op_Salida.Name = "op_Salida"
        Me.op_Salida.Size = New System.Drawing.Size(80, 16)
        Me.op_Salida.TabIndex = 211
        Me.op_Salida.Text = "&Salida"
        '
        'op_Entrada
        '
        Me.op_Entrada.Checked = True
        Me.op_Entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_Entrada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.op_Entrada.Location = New System.Drawing.Point(400, 72)
        Me.op_Entrada.Name = "op_Entrada"
        Me.op_Entrada.Size = New System.Drawing.Size(80, 16)
        Me.op_Entrada.TabIndex = 210
        Me.op_Entrada.TabStop = True
        Me.op_Entrada.Text = "&Entrada"
        '
        'lbEntregado
        '
        Me.lbEntregado.BackColor = System.Drawing.Color.Transparent
        Me.lbEntregado.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntregado.ForeColor = System.Drawing.Color.Blue
        Me.lbEntregado.Location = New System.Drawing.Point(256, 8)
        Me.lbEntregado.Name = "lbEntregado"
        Me.lbEntregado.Size = New System.Drawing.Size(248, 32)
        Me.lbEntregado.TabIndex = 215
        Me.lbEntregado.Text = "ENTREGADO"
        Me.lbEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbEntregado.Visible = False
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.DeleteCommand = Me.SqlCommand1
        Me.Adapter_Usuarios.InsertCommand = Me.SqlCommand2
        Me.Adapter_Usuarios.SelectCommand = Me.SqlCommand3
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'SqlCommand2
        '
        Me.SqlCommand2.Connection = Me.SqlConnection1
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_Desc," & _
        " Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
        Me.SqlCommand3.Connection = Me.SqlConnection1
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(600, 8)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(55, 16)
        Me.txtUsuario.TabIndex = 214
        Me.txtUsuario.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(656, 8)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(628, 16)
        Me.txtNombreUsuario.TabIndex = 215
        Me.txtNombreUsuario.Text = ""
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 475)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1066, 56)
        Me.ToolBar1.TabIndex = 217
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
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
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
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
        'ck_anu
        '
        Me.ck_anu.Enabled = False
        Me.ck_anu.ForeColor = System.Drawing.Color.Red
        Me.ck_anu.Location = New System.Drawing.Point(792, 496)
        Me.ck_anu.Name = "ck_anu"
        Me.ck_anu.Size = New System.Drawing.Size(72, 24)
        Me.ck_anu.TabIndex = 218
        Me.ck_anu.Text = "Anulado"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(872, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 40)
        Me.Button1.TabIndex = 219
        Me.Button1.Text = "Marcar como entregado"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(536, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "Usuario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelnota
        '
        Me.panelnota.Controls.Add(Me.listado)
        Me.panelnota.Controls.Add(Me.txtnota)
        Me.panelnota.Location = New System.Drawing.Point(728, 32)
        Me.panelnota.Name = "panelnota"
        Me.panelnota.Size = New System.Drawing.Size(328, 432)
        Me.panelnota.TabIndex = 218
        Me.panelnota.TabStop = False
        Me.panelnota.Text = "Nota"
        '
        'listado
        '
        Me.listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'listado.EmbeddedNavigator
        '
        Me.listado.EmbeddedNavigator.Name = ""
        Me.listado.Location = New System.Drawing.Point(8, 136)
        Me.listado.MainView = Me.GridView2
        Me.listado.Name = "listado"
        Me.listado.Size = New System.Drawing.Size(312, 285)
        Me.listado.Styles.AddReplace("Style1", New DevExpress.Utils.ViewStyleEx("Style1", "", New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.listado.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.listado.TabIndex = 186
        Me.listado.Text = "GridControl1"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.GroupPanelText = "Detalle de Cotización"
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Usuario"
        Me.GridColumn1.FieldName = "usuario"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 96
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 165
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Accion"
        Me.GridColumn3.FieldName = "accion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 309
        '
        'txtnota
        '
        Me.txtnota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPrestamos1, "Prestamo.nota"))
        Me.txtnota.Location = New System.Drawing.Point(16, 24)
        Me.txtnota.MaxLength = 150
        Me.txtnota.Multiline = True
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(304, 80)
        Me.txtnota.TabIndex = 217
        Me.txtnota.Text = ""
        '
        'frm_prestamos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1066, 531)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ck_anu)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lb_prestamo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbEntregado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panelnota)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1072, 560)
        Me.Name = "frm_prestamos"
        Me.Text = "Prestamos"
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_base.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.panelnota.ResumeLayout(False)
        CType(Me.listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "variables"
    Dim PMU As New PerfilModulo_Class 'clase de seguridad 
    Dim Cedula_usuario As String
    Dim Existencia As Double
    Dim perfil_administrador As Boolean
    Dim usua
    Dim buscando As Boolean = False
    'varibles de articulos
    Dim mensaje As String ' almacena el mensaje de los descuentos
    Dim password_antiguo As String
    Dim logeado As Boolean
    Dim Id As Integer = 0
    Dim num_fact As Integer = 0
    Dim tipo_fact As String = ""
    Dim haynota As Boolean = False

#End Region

    Private Sub Reloggin_Usuario()

        Try

            If BindingContext(Me.DsPrestamos1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = DsPrestamos1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 

                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas...", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If

                    Nuevo_prestamo()

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
    Public Sub Loggin_Usuario()
        Try
            If BindingContext(Me.DsPrestamos1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DsPrestamos1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar prestamos..", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If
                    logeado = True
                    txtNombreUsuario.Text = Usua("Nombre")
                    Cedula_usuario = Usua("Cedula")

                    Me.Panel1.Enabled = True

                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                    ToolBar1.Buttons(0).Text = "Cancelar"
                    ToolBar1.Buttons(0).ImageIndex = 8
                    'ToolBar1.Buttons(3).Enabled = PMU.Delete
                    ToolBar1.Buttons(0).Enabled = True
                    ToolBar1.Buttons(1).Enabled = True
                    ToolBar1.Buttons(5).Enabled = True
                    ToolBar1.Buttons(2).Enabled = True

                    perfil_administrador = PMU.Others


                    Nuevo_prestamo()

                    Me.txtcodigo.Focus()
                    Me.txtcodigo.Text = ""
                    Me.lbempresa.Text = ""
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
    Private Sub NuevaEntrada()
        Try

            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = True

                Me.dt_entrega.Enabled = False
                Me.dt_fecha.Enabled = False

                Me.txtcodigo.Enabled = False
                Me.lbempresa.Enabled = True : Me.lbempresa.Text = ""

                'Me.txtNombreUsuario.Text = ""
                'Me.txtUsuario.Focus()
                'Me.logeado = False
                Me.DsPrestamos1.Prestamo.Clear()
                Me.DsPrestamos1.detalle_prestamo.Clear()
                Me.DsPrestamos1.Clientes_frecuentes.Clear()

            Else
                If Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Count = 0 Then 'Si la factura no tiene detalle
                    Me.BindingContext(Me.DsPrestamos1, "prestamo").CancelCurrentEdit()

                    Me.DsPrestamos1.Prestamo.Clear()
                    Me.DsPrestamos1.detalle_prestamo.Clear()
                    Me.DsPrestamos1.Clientes_frecuentes.Clear()

                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(2).Enabled = False
                    Me.ToolBar1.Buttons(3).Enabled = False

                    dts_historial.Clear()

                    Me.Button1.Visible = False
                    Me.lbEntregado.Visible = False
                    Me.lb_anu.Visible = False
                    Exit Sub
                End If

                If PMU.Update = True Then
                    Me.BindingContext(Me.DsPrestamos1, "prestamo").CancelCurrentEdit()

                    Me.DsPrestamos1.detalle_prestamo.Clear()
                    Me.DsPrestamos1.Prestamo.Clear()

                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(2).Enabled = True

                    Me.lbEntregado.Visible = False
                    Me.lb_anu.Visible = False

                    Me.logeado = False
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()

                Else
                    MsgBox("No tiene permiso para registrar datos...", MsgBoxStyle.Information, "Atención...")
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub txt_empresa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodigo.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then

            Dim cFunciones As New cFunciones
            Dim c As String
            c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes_frecuentes where anulado = 0", "Nombre")

            If c <> "" Then
                Me.txtcodigo.Text = c
            Else
                Exit Sub
            End If

            If Me.txtcodigo.Text <> "" And Me.txtcodigo.Text <> "0" Then
                sqlConexion = CConexion.Conectar
                Me.Cargar_Cliente_frecuente(CInt(txtcodigo.Text))
                CargarInformacionCliente(txtcodigo.Text)
            Else
                Exit Sub
            End If

            Me.txtCod_Articulo.Focus()

        End If
    End Sub
    Private Sub Nuevo_prestamo()
        Try
            Me.DsPrestamos1.detalle_prestamo.Clear()
            Me.DsPrestamos1.Prestamo.Clear()

            Me.BindingContext(Me.DsPrestamos1, "prestamo").EndCurrentEdit()
            Me.DsPrestamos1.Prestamo.fecha_entregaColumn.DefaultValue = Date.Now
            Me.DsPrestamos1.Prestamo.fechaColumn.DefaultValue = Date.Now
            Me.BindingContext(Me.DsPrestamos1, "prestamo").AddNew()

            editando = False

            If Me.buscando Then buscando = False ' si se estaba buscando, buscando se pone en falso

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Sub Cargar_Cliente_frecuente(ByVal Id As Integer)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''Cotizacion''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Clientes_frecuentes WHERE (identificacion = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.Int))

            cmdv.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsPrestamos1, "Clientes_frecuentes")

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub
    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim rsm As SqlDataReader
        Dim cod_mod As Integer
        Dim cambio As Double

        sqlConexion = CConexion.Conectar
        If codigo <> Nothing Then

            rss = Me.DsPrestamos1.Clientes_frecuentes.Select("Identificacion ='" & codigo & "'")

            If rss.Length <> 0 Then ' si existe un cliente con ese còdigo

                Try
                    rs = rss(0)
                    If destino = False Then
                        Me.txtcodigo.Text = rs("Identificacion")
                    Else
                        Me.txt_destino.Text = rs("Identificacion")
                    End If

                    ''''''''''''''''
                    If Me.destino = True Then
                        Me.lbldestino.Text = rs("nombre")
                    Else
                        Me.lbempresa.Text = rs("nombre")
                    End If
                    destino = False

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else ' si no se encontro el cliente

                MsgBox("No existe un cliente con ese código", MsgBoxStyle.Exclamation)
                Me.txtcodigo.Text = ""
                Me.lbempresa.Text = ""

            End If

        Else 'se dio el boton de cancelar o no se selecciono ninguno

            Me.txtcodigo.Text = ""
            Me.lbempresa.Text = ""
        End If
    End Sub

    Private Sub frm_prestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SqlConnection1.ConnectionString = CadenaConexionSeePOS

            Adapter_Usuarios.Fill(Me.DsPrestamos1, "Usuarios")

            DsPrestamos1.Prestamo.IDColumn.AutoIncrement = True
            DsPrestamos1.Prestamo.IDColumn.AutoIncrementSeed = -1
            DsPrestamos1.Prestamo.IDColumn.AutoIncrementStep = -1

            DsPrestamos1.detalle_prestamo.IDColumn.AutoIncrement = True
            DsPrestamos1.detalle_prestamo.IDColumn.AutoIncrementSeed = -1
            DsPrestamos1.detalle_prestamo.IDColumn.AutoIncrementStep = -1

            DsPrestamos1.Prestamo.nombre_empresaColumn.DefaultValue = ""
            DsPrestamos1.Prestamo.cod_empresaColumn.DefaultValue = 0
            DsPrestamos1.Prestamo.usuarioColumn.DefaultValue = usua.cedula
            DsPrestamos1.Prestamo.estadoColumn.DefaultValue = False
            DsPrestamos1.Prestamo.anuladoColumn.DefaultValue = 0
            DsPrestamos1.Prestamo.nombre_destinoColumn.DefaultValue = ""
            DsPrestamos1.Prestamo.notaColumn.DefaultValue = " "

            DsPrestamos1.detalle_prestamo.ID_prestamoColumn.DefaultValue = 0
            DsPrestamos1.detalle_prestamo.cod_articuloColumn.DefaultValue = ""
            DsPrestamos1.detalle_prestamo.codigoColumn.DefaultValue = 0
            DsPrestamos1.detalle_prestamo.descripcionColumn.DefaultValue = ""
            DsPrestamos1.detalle_prestamo.cantidadColumn.DefaultValue = 1
            DsPrestamos1.detalle_prestamo.precioColumn.DefaultValue = 0.0
            DsPrestamos1.detalle_prestamo.entregadoColumn.DefaultValue = False



            op_Entrada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPrestamos1, "prestamo.entrada"))
            Me.op_Salida.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPrestamos1, "prestamo.salida"))

            Me.DsPrestamos1.Prestamo.EntradaColumn.DefaultValue = False
            Me.DsPrestamos1.Prestamo.SalidaColumn.DefaultValue = False

            Me.ck_anu.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPrestamos1, "prestamo.Anulado"))

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtCod_Articulo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod_Articulo.EditValueChanged
        AgregandoNuevoItem = False
    End Sub
    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
            Codigo = BuscarArt.Codigo
            Exit Function
        End If
        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function
    Private Sub txtCod_Articulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod_Articulo.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then
            Try
                Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
                Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()
                Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").AddNew()

                Dim CodigoBuscador As String = BuscarF1()

                If Not IsNothing(CodigoBuscador) And CodigoBuscador <> "0" And CodigoBuscador <> "0.00" Then
                    CargarInformacionArticulo(CodigoBuscador)
                    Me.txtCantidad.Focus()
                    Me.txtCantidad.SelectAll()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        End If
    End Sub
    Private Sub CargarInformacionArticulo(ByVal codigo As String, Optional ByVal recargar As Boolean = False)
        Try
            Dim rs As SqlDataReader
            Dim Encontrado As Boolean

            If codigo <> Nothing Or codigo <> "" Then
                sqlConexion = CConexion.Conectar

                rs = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras,promo3x1, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote, Consignacion , Id_Bodega, ExistenciaBodega, bloqueado,pantalla from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_Articulo ='" & codigo & "' or (Inhabilitado = 0) and Barras = '" & codigo & "' or barras2 = '" & codigo & "' or barras3 = '" & codigo & "'")
                Encontrado = False

                While rs.Read

                    Encontrado = True
                    txtCodArticulo.Text = rs("Codigo")
                    txtCod_Articulo.Text = rs("Cod_Articulo")
                    Me.txt_base.Text = rs("PrecioBase")
                    lbdescripcion.Text = rs("descripcion")

                End While

                rs.Close()
                If Not Encontrado Then
                    Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
                    Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").AddNew()
                    Me.txtCod_Articulo.Focus()
                    CConexion.DesConectar(CConexion.sQlconexion)
                    MsgBox("No existe o está inhabilitado un artículo con este código")
                    Exit Sub
                End If


            Else ' si no se recupero ningun articulo, se termina la edicion
                Try

                    Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
                    Me.txtCod_Articulo.Focus()

                Catch ex As SystemException
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                Finally
                    CConexion.DesConectar(CConexion.sQlconexion)
                End Try
            End If
            AgregandoNuevoItem = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not logeado Then Loggin_Usuario() Else Me.Reloggin_Usuario()
        End If
    End Sub
    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            If Me.txtCantidad.Text = "" Then Exit Sub
            Agregar()
        End If
    End Sub
    Function Agregar()
        Try
            Dim resp As Integer
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Function
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo al prestamo?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
                Me.BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").AddNew()
                txtCodArticulo.Focus()
                Exit Function
            End If

            'Calcular()
            BindingContext(Me.DsPrestamos1, "Prestamo").EndCurrentEdit()
            BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()
            BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
            BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").AddNew()
            txtCodArticulo.Focus()
            Me.GridControl1.Focus()

        Catch ex As System.Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
    Sub Calcular(Optional ByVal Buscar As Boolean = False)
        'Try
        '    If BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Count > 0 Then
        '        If Buscar = False Then
        '            If CbNumero.Visible = True Then
        '                BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Current("Numero") = CbNumero.Text
        '            ElseIf CBNuevo.Checked = True Then
        '                BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Current("Numero") = txtNuevoLote.Text
        '                AgregaLote()
        '                CBNuevo.Checked = False
        '            Else
        '                BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Current("Numero") = "0"
        '            End If
        '        End If

        '        BindingContext(DsAjusteInv2, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()
        '        txtTotalEntrada.Text = Format(colTotalEntrada.SummaryItem.SummaryValue, "#,#0.00")
        '        txtTotalSalida.Text = Format(colTotalSalida.SummaryItem.SummaryValue, "#,#0.00")
        '        txtSaldoAjuste.Text = Format(CDbl(txtTotalEntrada.Text) - CDbl(txtTotalSalida.Text), "#,#0.00")

        '    Else
        '        txtTotalEntrada.Text = "0.00"
        '        txtTotalSalida.Text = "0.00"
        '        txtSaldoAjuste.Text = "0.00"
        '    End If

        '    CBNuevo.Checked = False
        '    CBNuevo.Visible = False
        '    CbNumero.Items.Clear()
        '    CbNumero.Visible = False
        '    LNumero.Visible = False

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        'End Try
    End Sub


    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Ariculo_Detalle()
        End If
    End Sub
    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Count > 0 Then   ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este artículo del prestamo?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then

                    BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").RemoveAt(BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").Position)
                    BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()
                Else
                    BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Artìculos para eliminar en el prestamo", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus
        If editando = False Then
            BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
        End If
    End Sub
    Sub guardar_historial(ByVal accion As String)
        Try
            Dim funciones As New Conexion
            Dim datos, Tipo As String

            datos = Me.lb_prestamo.Text & ",'" & Me.txtNombreUsuario.Text & "','" & Date.Now & "','" & accion & "'"
            funciones.AddNewRecord("historial_prestamos", "id_prestamo,usuario,fecha,Accion", datos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolBar1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevaEntrada()
            Case 2 : If PMU.Find Then Me.Busca_prestamos() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el Módulo de prestamos?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub
    Function imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim prestamo_reporte As New Reporteprestamos

            prestamo_reporte.SetParameterValue("prestamo", CDbl(Me.BindingContext(Me.DsPrestamos1, "prestamo").Current(Id)))
            'prestamo_reporte.PrintToPrinter(1, True, 0, 0)
            'prestamo_reporte.PrintToPrinter(1, True, 0, 0)
            CrystalReportsConexion.LoadShow(prestamo_reporte, MdiParent)

            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
    Private Sub Anular()
        Try
            If usua.Anu_Venta = False Then
                MsgBox("Usted no tiene permisos de anular", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim resp As Integer

            If Me.BindingContext(Me.DsPrestamos1, "prestamo").Count > 0 Then


                resp = MessageBox.Show("¿Desea Anular este prestamo?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then

                    Me.BindingContext(Me.DsPrestamos1, "prestamo").EndCurrentEdit()

                    If Registrar_Anulacion_prestamo() Then

                        Me.guardar_historial("ANULACION DE PRESTAMO")

                        Me.DsPrestamos1.AcceptChanges()
                        MsgBox("El prestamo ha sido anulado correctamente", MsgBoxStyle.Information)

                        Me.DsPrestamos1.detalle_prestamo.Clear()
                        Me.DsPrestamos1.Prestamo.Clear()

                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                        Me.logeado = False

                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()


                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                    End If

                Else : Exit Sub

                End If

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Function Registrar_Anulacion_prestamo() As Boolean
        Dim Cx As New Conexion
        Try
            Cx.UpdateRecords("prestamo", "Anulado = 1", "Id = " & BindingContext(Me.DsPrestamos1, "prestamo").Current("Id"), "SeePos")

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
    Function Registrar()
        Dim Funciones As New Conexion
        Try
            BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()
            Me.GridControl1.Refresh()

            If MessageBox.Show("¿Desea guardar el prestamo?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Me.BindingContext(DsPrestamos1, "Prestamo").EndCurrentEdit()
                BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").CancelCurrentEdit()
                BindingContext(DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()


                If Me.Registrar_prestamo() Then
                    If editando Then
                        Me.guardar_historial("SE EDITO EL PRESTAMO")
                    Else
                        Me.guardar_historial("NUEVO PRESTAMO")
                    End If


                    Me.ToolBar1.Buttons(4).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(2).Enabled = False
                    Me.ToolBar1.Buttons(3).Enabled = False
                    MsgBox("El prestamo se guardo Satisfactoriamente", MsgBoxStyle.Information)
                    If MessageBox.Show("¿Desea imprimir el prestamo?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        imprimir()
                    End If

                    Me.DsPrestamos1.detalle_prestamo.Clear()
                    Me.DsPrestamos1.Prestamo.Clear()

                    txtUsuario.Enabled = True
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtUsuario.Focus()
                Else
                    MsgBox("Error al Guardar el prestamo", MsgBoxStyle.Critical)
                End If
            Else
                Exit Function
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
    Function Registrar_prestamo() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.Adapter_prestamo.InsertCommand.Transaction = Trans
            Me.Adapter_prestamo.DeleteCommand.Transaction = Trans
            Me.Adapter_prestamo.UpdateCommand.Transaction = Trans
            Me.Adapter_prestamo.SelectCommand.Transaction = Trans

            Me.Adapter_detalle_prestamo.InsertCommand.Transaction = Trans
            Me.Adapter_detalle_prestamo.DeleteCommand.Transaction = Trans
            Me.Adapter_detalle_prestamo.UpdateCommand.Transaction = Trans
            Me.Adapter_detalle_prestamo.SelectCommand.Transaction = Trans


            Me.Adapter_prestamo.Update(Me.DsPrestamos1, "prestamo")
            Me.Adapter_detalle_prestamo.Update(Me.DsPrestamos1, "detalle_prestamo")

            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
    Private Sub Busca_prestamos()
        Dim Fx As New cFunciones
        Dim identificador As Double
        Dim buscando As Boolean

        Try
            If Me.BindingContext(Me.DsPrestamos1, "prestamo").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un prestamo, si continúa se perderan los datos del mismo, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Me.DsPrestamos1.detalle_prestamo.Clear()
            Me.DsPrestamos1.Prestamo.Clear()

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT Prestamo.ID,Prestamo.nombre_empresa as Empresa, Prestamo.Fecha FROM Prestamo Order by Prestamo.Fecha DESC", "empresa", "Fecha", "Buscar prestamo"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Exit Sub
            End If

            Fx.Llenar_Tabla_Generico("SELECT * FROM prestamo WHERE (id =" & identificador & " )", Me.DsPrestamos1.Prestamo)
            Fx.Llenar_Tabla_Generico("SELECT * FROM detalle_prestamo WHERE (id_prestamo =" & identificador & " )", Me.DsPrestamos1.detalle_prestamo)

            editando = True

            Try
                cFunciones.Llenar_Tabla_Generico("select * from historial_prestamos where id_prestamo = " & Me.lb_prestamo.Text, dts_historial, CadenaConexionSeePOS)
                listado.DataSource = dts_historial

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            If Me.BindingContext(Me.DsPrestamos1, "prestamo").Current("estado") = True Then
                Me.lbEntregado.Visible = True
                Panel1.Enabled = False
                Me.Button1.Visible = False
                Me.ToolBar1.Buttons(2).Enabled = False

            Else
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.lbEntregado.Visible = False
                Me.Button1.Visible = True
            End If

            Me.ck_anu.Checked = Me.BindingContext(Me.DsPrestamos1, "prestamo").Current("Anulado")
            If Me.ck_anu.Checked = True Then
                lb_anu.Visible = True
                Me.Button1.Visible = False
            Else
                lb_anu.Visible = False
            End If

            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True

            'si esta venta aun no ha sido anulada
            If Me.BindingContext(Me.DsPrestamos1, "prestamo").Current("Anulado") = True Then Me.ToolBar1.Buttons(3).Enabled = False

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim resp As Integer
        Dim nota As Integer
        If txtnota.Text = " " Or txtnota.Text.Length = 1 Then
            nota = MessageBox.Show("¿Desea Agregar una nota al prestamo?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If nota = 6 Then
                Me.txtnota.Focus()
                Exit Sub
            End If
        End If
        resp = MessageBox.Show("¿Desea Marcar el prestamo como entregado?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If resp = 6 Then
            If marcar_entregado() Then
                Me.DsPrestamos1.AcceptChanges()
                Me.lbEntregado.Visible = True
                Me.guardar_historial("SE MARCO TODO COMO ENTREGADO")

                MsgBox("El prestamo se ha Marcado como entregado", MsgBoxStyle.Information)
                Me.Panel1.Enabled = False
                Me.Button1.Visible = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Close()
            End If
        End If
    End Sub
    Function marcar_entregado() As Boolean
        Dim Cx As New Conexion
        Try
            Cx.UpdateRecords("prestamo", "estado = 1 , nota = '" & txtnota.Text & "'", "Id = " & BindingContext(Me.DsPrestamos1, "prestamo").Current("Id"), "SeePos")
            Cx.UpdateRecords("detalle_prestamo", "entregado = 1", "Id_prestamo = " & BindingContext(Me.DsPrestamos1, "prestamo").Current("Id"), "SeePos")
            For i As Integer = 0 To Me.DsPrestamos1.detalle_prestamo.Count - 1
                Cx.UpdateRecords("detalle_prestamo", "entregado = 1", "Id_prestamo = " & BindingContext(Me.DsPrestamos1, "prestamo").Current("Id"), "SeePos")
            Next
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BindingContext(Me.DsPrestamos1, "Prestamo.Prestamodetalle_prestamo").EndCurrentEdit()
    End Sub

    Private Sub txt_destino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_destino.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then

            Dim cFunciones As New cFunciones
            Dim c As String
            c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes_frecuentes where anulado = 0", "Nombre")

            If c <> "" Then
                Me.txt_destino.Text = c
            Else
                Exit Sub
            End If

            If Me.txt_destino.Text <> "" And Me.txt_destino.Text <> "0" Then
                sqlConexion = CConexion.Conectar
                Me.Cargar_Cliente_frecuente(CInt(Me.txt_destino.Text))
                destino = True
                CargarInformacionCliente(Me.txt_destino.Text)
            Else
                Exit Sub
            End If
            Me.txtCod_Articulo.Focus()
        End If
    End Sub

    Private Sub txt_destino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_destino.TextChanged

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Disposed

    End Sub

    Private Sub GridControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles GridControl1.DragDrop

    End Sub

    Private Sub txtUsuario_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.Resize

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtnota.Text <> "" Then
            haynota = True
        End If
        'panelnota.Visible = False
    End Sub
End Class
