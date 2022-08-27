Imports System.Windows.Forms
Public Class frmInventarioGRID
    Inherits FrmPlantilla
    Dim CadenaWhere As String

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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataSetInventario As DataSetInventario
    Friend WithEvents AdapterInventario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBarras As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPresentaCant As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodPresentacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodMarca As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubFamilia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMinima As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPuntoMedio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaxima As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExistencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubUbicacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMonedaCosto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioBase As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFletes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOtrosCargos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIVenta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colServicio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInhabilitado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit_Presentaciones As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_Marca As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_Familias As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_Ubicaciones As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents AdapterAUbicacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterPresentacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterMarcas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterFamilia As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemLookUpEdit_Moneda As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_Consignantes As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Filtro_Inicio_del_Campo As System.Windows.Forms.RadioButton
    Friend WithEvents Filtro_Cualquier_Parte_del_Campo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInventarioGRID))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataSetInventario = New DataSetInventario
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBarras = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPresentaCant = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodPresentacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit_Presentaciones = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCodMarca = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit_Marca = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSubFamilia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit_Familias = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colMinima = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPuntoMedio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMaxima = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExistencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSubUbicacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit_Ubicaciones = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colObservaciones = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMonedaCosto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit_Moneda = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPrecioBase = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFletes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOtrosCargos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCosto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIVenta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFechaIngreso = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colServicio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInhabilitado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit_Consignantes = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.AdapterInventario = New System.Data.SqlClient.SqlDataAdapter
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterAUbicacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.AdapterPresentacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdapterMarcas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.AdapterFamilia = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Filtro_Inicio_del_Campo = New System.Windows.Forms.RadioButton
        Me.Filtro_Cualquier_Parte_del_Campo = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Presentaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Marca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Familias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Ubicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Consignantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Text = "Refrescar"
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(562, 478)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 416)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(694, 52)
        '
        'TituloModulo
        '
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(694, 32)
        Me.TituloModulo.Text = "Navegador en Inventarios"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Inventario"
        Me.GridControl1.DataSource = Me.DataSetInventario
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 32)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Moneda, Me.RepositoryItemLookUpEdit_Presentaciones, Me.RepositoryItemLookUpEdit_Marca, Me.RepositoryItemLookUpEdit_Familias, Me.RepositoryItemLookUpEdit_Ubicaciones, Me.RepositoryItemLookUpEdit_Consignantes})
        Me.GridControl1.Size = New System.Drawing.Size(696, 384)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.Text = "GridControl1"
        '
        'DataSetInventario
        '
        Me.DataSetInventario.DataSetName = "DataSetInventario"
        Me.DataSetInventario.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colBarras, Me.colDescripcion, Me.colPresentaCant, Me.colCodPresentacion, Me.colCodMarca, Me.colSubFamilia, Me.colMinima, Me.colPuntoMedio, Me.colMaxima, Me.colExistencia, Me.colSubUbicacion, Me.colMonedaCosto, Me.colPrecioBase, Me.colFletes, Me.colOtrosCargos, Me.colCosto, Me.colIVenta, Me.colFechaIngreso, Me.colServicio, Me.colInhabilitado, Me.colObservaciones})
        Me.BandedGridView1.GroupPanelText = ""
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowGroupedColumns = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Listado de Inventario"
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colBarras)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colPresentaCant)
        Me.GridBand1.Columns.Add(Me.colCodPresentacion)
        Me.GridBand1.Columns.Add(Me.colCodMarca)
        Me.GridBand1.Columns.Add(Me.colSubFamilia)
        Me.GridBand1.Columns.Add(Me.colMinima)
        Me.GridBand1.Columns.Add(Me.colPuntoMedio)
        Me.GridBand1.Columns.Add(Me.colMaxima)
        Me.GridBand1.Columns.Add(Me.colExistencia)
        Me.GridBand1.Columns.Add(Me.colSubUbicacion)
        Me.GridBand1.Columns.Add(Me.colObservaciones)
        Me.GridBand1.Columns.Add(Me.colMonedaCosto)
        Me.GridBand1.Columns.Add(Me.colPrecioBase)
        Me.GridBand1.Columns.Add(Me.colFletes)
        Me.GridBand1.Columns.Add(Me.colOtrosCargos)
        Me.GridBand1.Columns.Add(Me.colCosto)
        Me.GridBand1.Columns.Add(Me.colIVenta)
        Me.GridBand1.Columns.Add(Me.colFechaIngreso)
        Me.GridBand1.Columns.Add(Me.colServicio)
        Me.GridBand1.Columns.Add(Me.colInhabilitado)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 2585
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.MinWidth = 10
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 100
        '
        'colBarras
        '
        Me.colBarras.Caption = "Barras"
        Me.colBarras.FieldName = "Barras"
        Me.colBarras.MinWidth = 10
        Me.colBarras.Name = "colBarras"
        Me.colBarras.Visible = True
        Me.colBarras.Width = 150
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.MinWidth = 10
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 206
        '
        'colPresentaCant
        '
        Me.colPresentaCant.Caption = "Present.Cant."
        Me.colPresentaCant.FieldName = "PresentaCant"
        Me.colPresentaCant.MinWidth = 10
        Me.colPresentaCant.Name = "colPresentaCant"
        Me.colPresentaCant.Visible = True
        Me.colPresentaCant.Width = 100
        '
        'colCodPresentacion
        '
        Me.colCodPresentacion.Caption = "Presentación"
        Me.colCodPresentacion.ColumnEdit = Me.RepositoryItemLookUpEdit_Presentaciones
        Me.colCodPresentacion.FieldName = "CodPresentacion"
        Me.colCodPresentacion.MinWidth = 10
        Me.colCodPresentacion.Name = "colCodPresentacion"
        Me.colCodPresentacion.Visible = True
        Me.colCodPresentacion.Width = 150
        '
        'RepositoryItemLookUpEdit_Presentaciones
        '
        Me.RepositoryItemLookUpEdit_Presentaciones.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Presentaciones.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Presentaciones.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Presentaciones", "Presentaciones", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodPres", "CodPres", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit_Presentaciones.DataSource = Me.DataSetInventario.Presentaciones
        Me.RepositoryItemLookUpEdit_Presentaciones.DisplayMember = "Presentaciones"
        Me.RepositoryItemLookUpEdit_Presentaciones.Name = "RepositoryItemLookUpEdit_Presentaciones"
        Me.RepositoryItemLookUpEdit_Presentaciones.ValueMember = "CodPres"
        '
        'colCodMarca
        '
        Me.colCodMarca.Caption = "Marca"
        Me.colCodMarca.ColumnEdit = Me.RepositoryItemLookUpEdit_Marca
        Me.colCodMarca.FieldName = "CodMarca"
        Me.colCodMarca.MinWidth = 10
        Me.colCodMarca.Name = "colCodMarca"
        Me.colCodMarca.Visible = True
        Me.colCodMarca.Width = 100
        '
        'RepositoryItemLookUpEdit_Marca
        '
        Me.RepositoryItemLookUpEdit_Marca.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Marca.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemLookUpEdit_Marca.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Marca", "Marca", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodMarca", "CodMarca", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit_Marca.DataSource = Me.DataSetInventario.Marcas
        Me.RepositoryItemLookUpEdit_Marca.DisplayMember = "Marca"
        Me.RepositoryItemLookUpEdit_Marca.Name = "RepositoryItemLookUpEdit_Marca"
        Me.RepositoryItemLookUpEdit_Marca.ValueMember = "CodMarca"
        '
        'colSubFamilia
        '
        Me.colSubFamilia.Caption = "Familia"
        Me.colSubFamilia.ColumnEdit = Me.RepositoryItemLookUpEdit_Familias
        Me.colSubFamilia.FieldName = "SubFamilia"
        Me.colSubFamilia.MinWidth = 10
        Me.colSubFamilia.Name = "colSubFamilia"
        Me.colSubFamilia.Visible = True
        Me.colSubFamilia.Width = 100
        '
        'RepositoryItemLookUpEdit_Familias
        '
        Me.RepositoryItemLookUpEdit_Familias.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Familias.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Familias.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Familiares", "Familiares", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit_Familias.DataSource = Me.DataSetInventario.SubFamilias
        Me.RepositoryItemLookUpEdit_Familias.DisplayMember = "Familiares"
        Me.RepositoryItemLookUpEdit_Familias.Name = "RepositoryItemLookUpEdit_Familias"
        Me.RepositoryItemLookUpEdit_Familias.ValueMember = "Codigo"
        '
        'colMinima
        '
        Me.colMinima.Caption = "Minima"
        Me.colMinima.FieldName = "Minima"
        Me.colMinima.MinWidth = 10
        Me.colMinima.Name = "colMinima"
        Me.colMinima.Visible = True
        Me.colMinima.Width = 151
        '
        'colPuntoMedio
        '
        Me.colPuntoMedio.Caption = "Punto Medio"
        Me.colPuntoMedio.FieldName = "PuntoMedio"
        Me.colPuntoMedio.MinWidth = 10
        Me.colPuntoMedio.Name = "colPuntoMedio"
        Me.colPuntoMedio.Visible = True
        Me.colPuntoMedio.Width = 114
        '
        'colMaxima
        '
        Me.colMaxima.Caption = "Máxima"
        Me.colMaxima.FieldName = "Maxima"
        Me.colMaxima.MinWidth = 10
        Me.colMaxima.Name = "colMaxima"
        Me.colMaxima.Visible = True
        Me.colMaxima.Width = 127
        '
        'colExistencia
        '
        Me.colExistencia.Caption = "Existencia"
        Me.colExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExistencia.FieldName = "Existencia"
        Me.colExistencia.MinWidth = 10
        Me.colExistencia.Name = "colExistencia"
        Me.colExistencia.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExistencia.Visible = True
        Me.colExistencia.Width = 127
        '
        'colSubUbicacion
        '
        Me.colSubUbicacion.Caption = "Ubicación"
        Me.colSubUbicacion.ColumnEdit = Me.RepositoryItemLookUpEdit_Ubicaciones
        Me.colSubUbicacion.FieldName = "SubUbicacion"
        Me.colSubUbicacion.MinWidth = 10
        Me.colSubUbicacion.Name = "colSubUbicacion"
        Me.colSubUbicacion.Visible = True
        Me.colSubUbicacion.Width = 125
        '
        'RepositoryItemLookUpEdit_Ubicaciones
        '
        Me.RepositoryItemLookUpEdit_Ubicaciones.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Ubicaciones.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Ubicaciones.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ubicaciones", "Ubicaciones", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit_Ubicaciones.DataSource = Me.DataSetInventario.SubUbicacion
        Me.RepositoryItemLookUpEdit_Ubicaciones.DisplayMember = "Ubicaciones"
        Me.RepositoryItemLookUpEdit_Ubicaciones.Name = "RepositoryItemLookUpEdit_Ubicaciones"
        Me.RepositoryItemLookUpEdit_Ubicaciones.ValueMember = "Codigo"
        '
        'colObservaciones
        '
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.MinWidth = 10
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = True
        Me.colObservaciones.Width = 150
        '
        'colMonedaCosto
        '
        Me.colMonedaCosto.Caption = "Moneda Costo"
        Me.colMonedaCosto.ColumnEdit = Me.RepositoryItemLookUpEdit_Moneda
        Me.colMonedaCosto.FieldName = "MonedaCosto"
        Me.colMonedaCosto.MinWidth = 10
        Me.colMonedaCosto.Name = "colMonedaCosto"
        Me.colMonedaCosto.Visible = True
        Me.colMonedaCosto.Width = 100
        '
        'RepositoryItemLookUpEdit_Moneda
        '
        Me.RepositoryItemLookUpEdit_Moneda.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Moneda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Moneda.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MonedaNombre", "MonedaNombre", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodMoneda", "CodMoneda", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValorCompra", "ValorCompra", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit_Moneda.DataSource = Me.DataSetInventario.Moneda
        Me.RepositoryItemLookUpEdit_Moneda.DisplayMember = "MonedaNombre"
        Me.RepositoryItemLookUpEdit_Moneda.Name = "RepositoryItemLookUpEdit_Moneda"
        Me.RepositoryItemLookUpEdit_Moneda.ValueMember = "CodMoneda"
        '
        'colPrecioBase
        '
        Me.colPrecioBase.Caption = "Precio Base"
        Me.colPrecioBase.FieldName = "PrecioBase"
        Me.colPrecioBase.MinWidth = 10
        Me.colPrecioBase.Name = "colPrecioBase"
        Me.colPrecioBase.Visible = True
        Me.colPrecioBase.Width = 125
        '
        'colFletes
        '
        Me.colFletes.Caption = "Fletes"
        Me.colFletes.FieldName = "Fletes"
        Me.colFletes.MinWidth = 10
        Me.colFletes.Name = "colFletes"
        Me.colFletes.Visible = True
        Me.colFletes.Width = 125
        '
        'colOtrosCargos
        '
        Me.colOtrosCargos.Caption = "Otros Cargos"
        Me.colOtrosCargos.FieldName = "OtrosCargos"
        Me.colOtrosCargos.MinWidth = 10
        Me.colOtrosCargos.Name = "colOtrosCargos"
        Me.colOtrosCargos.Visible = True
        Me.colOtrosCargos.Width = 125
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo"
        Me.colCosto.ColumnEdit = Me.RepositoryItemLookUpEdit_Moneda
        Me.colCosto.FieldName = "Costo"
        Me.colCosto.MinWidth = 10
        Me.colCosto.Name = "colCosto"
        Me.colCosto.Visible = True
        Me.colCosto.Width = 125
        '
        'colIVenta
        '
        Me.colIVenta.Caption = "IVenta"
        Me.colIVenta.FieldName = "IVenta"
        Me.colIVenta.MinWidth = 10
        Me.colIVenta.Name = "colIVenta"
        Me.colIVenta.Visible = True
        Me.colIVenta.Width = 85
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Caption = "FechaIngreso"
        Me.colFechaIngreso.FieldName = "FechaIngreso"
        Me.colFechaIngreso.MinWidth = 10
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.Width = 100
        '
        'colServicio
        '
        Me.colServicio.Caption = "Servicio"
        Me.colServicio.FieldName = "Servicio"
        Me.colServicio.MinWidth = 10
        Me.colServicio.Name = "colServicio"
        Me.colServicio.Visible = True
        Me.colServicio.Width = 50
        '
        'colInhabilitado
        '
        Me.colInhabilitado.Caption = "Inhabilitado"
        Me.colInhabilitado.FieldName = "Inhabilitado"
        Me.colInhabilitado.MinWidth = 10
        Me.colInhabilitado.Name = "colInhabilitado"
        Me.colInhabilitado.Visible = True
        Me.colInhabilitado.Width = 50
        '
        'RepositoryItemLookUpEdit_Consignantes
        '
        Me.RepositoryItemLookUpEdit_Consignantes.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Consignantes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Consignantes.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Bodega", "Bodega", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Bodega", "ID_Bodega", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit_Consignantes.DisplayMember = "Nombre_Bodega"
        Me.RepositoryItemLookUpEdit_Consignantes.Name = "RepositoryItemLookUpEdit_Consignantes"
        Me.RepositoryItemLookUpEdit_Consignantes.ValueMember = "ID_Bodega"
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=SeePos"
        '
        'AdapterInventario
        '
        Me.AdapterInventario.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterInventario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterInventario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Barras", "Barras"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("PresentaCant", "PresentaCant"), New System.Data.Common.DataColumnMapping("CodPresentacion", "CodPresentacion"), New System.Data.Common.DataColumnMapping("CodMarca", "CodMarca"), New System.Data.Common.DataColumnMapping("SubFamilia", "SubFamilia"), New System.Data.Common.DataColumnMapping("Minima", "Minima"), New System.Data.Common.DataColumnMapping("PuntoMedio", "PuntoMedio"), New System.Data.Common.DataColumnMapping("Maxima", "Maxima"), New System.Data.Common.DataColumnMapping("Existencia", "Existencia"), New System.Data.Common.DataColumnMapping("ExistenciaBodega", "ExistenciaBodega"), New System.Data.Common.DataColumnMapping("BodegaConsignacion", "BodegaConsignacion"), New System.Data.Common.DataColumnMapping("SubUbicacion", "SubUbicacion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("MonedaCosto", "MonedaCosto"), New System.Data.Common.DataColumnMapping("PrecioBase", "PrecioBase"), New System.Data.Common.DataColumnMapping("Fletes", "Fletes"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("MonedaVenta", "MonedaVenta"), New System.Data.Common.DataColumnMapping("IVenta", "IVenta"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("Precio_B", "Precio_B"), New System.Data.Common.DataColumnMapping("Precio_C", "Precio_C"), New System.Data.Common.DataColumnMapping("Precio_D", "Precio_D"), New System.Data.Common.DataColumnMapping("Precio_Promo", "Precio_Promo"), New System.Data.Common.DataColumnMapping("Promo_Activa", "Promo_Activa"), New System.Data.Common.DataColumnMapping("Promo_Inicio", "Promo_Inicio"), New System.Data.Common.DataColumnMapping("Promo_Finaliza", "Promo_Finaliza"), New System.Data.Common.DataColumnMapping("Max_Comision", "Max_Comision"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Imagen", "Imagen"), New System.Data.Common.DataColumnMapping("FechaIngreso", "FechaIngreso"), New System.Data.Common.DataColumnMapping("Servicio", "Servicio"), New System.Data.Common.DataColumnMapping("Inhabilitado", "Inhabilitado"), New System.Data.Common.DataColumnMapping("Proveedor", "Proveedor"), New System.Data.Common.DataColumnMapping("CostoPromedio", "CostoPromedio")})})
        Me.AdapterInventario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
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
        "_Ubicacion = Ubicaciones.Codigo ORDER BY Ubicaciones.Descripcion + '/' + SubUbic" & _
        "acion.DescripcionD"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection
        '
        'AdapterPresentacion
        '
        Me.AdapterPresentacion.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterPresentacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Presentaciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Presentaciones", "Presentaciones"), New System.Data.Common.DataColumnMapping("CodPres", "CodPres")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Presentaciones, CodPres FROM Presentaciones ORDER BY Presentaciones"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection
        '
        'AdapterMarcas
        '
        Me.AdapterMarcas.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterMarcas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Marcas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMarca", "CodMarca"), New System.Data.Common.DataColumnMapping("Marca", "Marca")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT CodMarca, Marca FROM Marcas ORDER BY Marca"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection
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
        "amilia.Codigo ORDER BY Familia.Descripcion + '/' + SubFamilias.Descripcion"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.Location = New System.Drawing.Point(292, 420)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(400, 13)
        Me.TextBoxBuscar.TabIndex = 70
        Me.TextBoxBuscar.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Filtro_Inicio_del_Campo)
        Me.Panel2.Controls.Add(Me.Filtro_Cualquier_Parte_del_Campo)
        Me.Panel2.Location = New System.Drawing.Point(292, 452)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 16)
        Me.Panel2.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coincidir  -->"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Filtro_Inicio_del_Campo
        '
        Me.Filtro_Inicio_del_Campo.BackColor = System.Drawing.Color.White
        Me.Filtro_Inicio_del_Campo.Checked = True
        Me.Filtro_Inicio_del_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro_Inicio_del_Campo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Filtro_Inicio_del_Campo.Location = New System.Drawing.Point(140, 2)
        Me.Filtro_Inicio_del_Campo.Name = "Filtro_Inicio_del_Campo"
        Me.Filtro_Inicio_del_Campo.Size = New System.Drawing.Size(116, 13)
        Me.Filtro_Inicio_del_Campo.TabIndex = 0
        Me.Filtro_Inicio_del_Campo.TabStop = True
        Me.Filtro_Inicio_del_Campo.Text = "Inicio del Campo"
        '
        'Filtro_Cualquier_Parte_del_Campo
        '
        Me.Filtro_Cualquier_Parte_del_Campo.BackColor = System.Drawing.Color.White
        Me.Filtro_Cualquier_Parte_del_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro_Cualquier_Parte_del_Campo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Filtro_Cualquier_Parte_del_Campo.Location = New System.Drawing.Point(285, 0)
        Me.Filtro_Cualquier_Parte_del_Campo.Name = "Filtro_Cualquier_Parte_del_Campo"
        Me.Filtro_Cualquier_Parte_del_Campo.Size = New System.Drawing.Size(112, 16)
        Me.Filtro_Cualquier_Parte_del_Campo.TabIndex = 1
        Me.Filtro_Cualquier_Parte_del_Campo.Text = "Cualquier Parte"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Location = New System.Drawing.Point(292, 432)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 16)
        Me.Panel1.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda en -->"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton3.Location = New System.Drawing.Point(320, 0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(78, 16)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "Código II"
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(136, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descripción"
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton2.Location = New System.Drawing.Point(232, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Ubicación"
        Me.RadioButton2.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(572, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 16)
        Me.LinkLabel1.TabIndex = 73
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Auto Ajustar Columnas"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(263, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "-->"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""TOSHIBA-USER"";packet size=4096;integrated security=SSPI;data sour" & _
        "ce=""."";persist security info=False;initial catalog=SeePOS"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Barras, Descripcion, PresentaCant, CodPresentacion, CodMarca, SubF" & _
        "amilia, Minima, PuntoMedio, Maxima, Existencia, ExistenciaBodega, BodegaConsigna" & _
        "cion, SubUbicacion, Observaciones, MonedaCosto, PrecioBase, Fletes, OtrosCargos," & _
        " Costo, MonedaVenta, IVenta, Precio_A, Precio_B, Precio_C, Precio_D, Precio_Prom" & _
        "o, Promo_Activa, Promo_Inicio, Promo_Finaliza, Max_Comision, Max_Descuento, Imag" & _
        "en, FechaIngreso, Servicio, Inhabilitado, Proveedor, CostoPromedio FROM Inventar" & _
        "io"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Inventario(Codigo, Barras, Descripcion, PresentaCant, CodPresentacion" & _
        ", CodMarca, SubFamilia, Minima, PuntoMedio, Maxima, Existencia, ExistenciaBodega" & _
        ", BodegaConsignacion, SubUbicacion, Observaciones, MonedaCosto, PrecioBase, Flet" & _
        "es, OtrosCargos, Costo, MonedaVenta, IVenta, Precio_A, Precio_B, Precio_C, Preci" & _
        "o_D, Precio_Promo, Promo_Activa, Promo_Inicio, Promo_Finaliza, Max_Comision, Max" & _
        "_Descuento, Imagen, FechaIngreso, Servicio, Inhabilitado, Proveedor, CostoPromed" & _
        "io) VALUES (@Codigo, @Barras, @Descripcion, @PresentaCant, @CodPresentacion, @Co" & _
        "dMarca, @SubFamilia, @Minima, @PuntoMedio, @Maxima, @Existencia, @ExistenciaBode" & _
        "ga, @BodegaConsignacion, @SubUbicacion, @Observaciones, @MonedaCosto, @PrecioBas" & _
        "e, @Fletes, @OtrosCargos, @Costo, @MonedaVenta, @IVenta, @Precio_A, @Precio_B, @" & _
        "Precio_C, @Precio_D, @Precio_Promo, @Promo_Activa, @Promo_Inicio, @Promo_Finaliz" & _
        "a, @Max_Comision, @Max_Descuento, @Imagen, @FechaIngreso, @Servicio, @Inhabilita" & _
        "do, @Proveedor, @CostoPromedio); SELECT Codigo, Barras, Descripcion, PresentaCan" & _
        "t, CodPresentacion, CodMarca, SubFamilia, Minima, PuntoMedio, Maxima, Existencia" & _
        ", ExistenciaBodega, BodegaConsignacion, SubUbicacion, Observaciones, MonedaCosto" & _
        ", PrecioBase, Fletes, OtrosCargos, Costo, MonedaVenta, IVenta, Precio_A, Precio_" & _
        "B, Precio_C, Precio_D, Precio_Promo, Promo_Activa, Promo_Inicio, Promo_Finaliza," & _
        " Max_Comision, Max_Descuento, Imagen, FechaIngreso, Servicio, Inhabilitado, Prov" & _
        "eedor, CostoPromedio FROM Inventario WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 255, "Barras"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PresentaCant", System.Data.SqlDbType.Float, 8, "PresentaCant"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodPresentacion", System.Data.SqlDbType.Int, 4, "CodPresentacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMarca", System.Data.SqlDbType.Int, 4, "CodMarca"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Minima", System.Data.SqlDbType.Float, 8, "Minima"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PuntoMedio", System.Data.SqlDbType.Float, 8, "PuntoMedio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Maxima", System.Data.SqlDbType.Float, 8, "Maxima"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Float, 8, "Existencia"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExistenciaBodega", System.Data.SqlDbType.Float, 8, "ExistenciaBodega"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BodegaConsignacion", System.Data.SqlDbType.Int, 4, "BodegaConsignacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubUbicacion", System.Data.SqlDbType.VarChar, 10, "SubUbicacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaCosto", System.Data.SqlDbType.Int, 4, "MonedaCosto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrecioBase", System.Data.SqlDbType.Float, 8, "PrecioBase"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fletes", System.Data.SqlDbType.Float, 8, "Fletes"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaVenta", System.Data.SqlDbType.Int, 4, "MonedaVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IVenta", System.Data.SqlDbType.Float, 8, "IVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Promo", System.Data.SqlDbType.Float, 8, "Precio_Promo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Promo_Activa", System.Data.SqlDbType.Bit, 1, "Promo_Activa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Promo_Inicio", System.Data.SqlDbType.DateTime, 4, "Promo_Inicio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Promo_Finaliza", System.Data.SqlDbType.DateTime, 4, "Promo_Finaliza"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Comision", System.Data.SqlDbType.Float, 8, "Max_Comision"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imagen", System.Data.SqlDbType.VarBinary, 2147483647, "Imagen"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Servicio", System.Data.SqlDbType.Bit, 1, "Servicio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Inhabilitado", System.Data.SqlDbType.Bit, 1, "Inhabilitado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CostoPromedio", System.Data.SqlDbType.Float, 8, "CostoPromedio"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Inventario SET Codigo = @Codigo, Barras = @Barras, Descripcion = @Descripc" & _
        "ion, PresentaCant = @PresentaCant, CodPresentacion = @CodPresentacion, CodMarca " & _
        "= @CodMarca, SubFamilia = @SubFamilia, Minima = @Minima, PuntoMedio = @PuntoMedi" & _
        "o, Maxima = @Maxima, Existencia = @Existencia, ExistenciaBodega = @ExistenciaBod" & _
        "ega, BodegaConsignacion = @BodegaConsignacion, SubUbicacion = @SubUbicacion, Obs" & _
        "ervaciones = @Observaciones, MonedaCosto = @MonedaCosto, PrecioBase = @PrecioBas" & _
        "e, Fletes = @Fletes, OtrosCargos = @OtrosCargos, Costo = @Costo, MonedaVenta = @" & _
        "MonedaVenta, IVenta = @IVenta, Precio_A = @Precio_A, Precio_B = @Precio_B, Preci" & _
        "o_C = @Precio_C, Precio_D = @Precio_D, Precio_Promo = @Precio_Promo, Promo_Activ" & _
        "a = @Promo_Activa, Promo_Inicio = @Promo_Inicio, Promo_Finaliza = @Promo_Finaliz" & _
        "a, Max_Comision = @Max_Comision, Max_Descuento = @Max_Descuento, Imagen = @Image" & _
        "n, FechaIngreso = @FechaIngreso, Servicio = @Servicio, Inhabilitado = @Inhabilit" & _
        "ado, Proveedor = @Proveedor, CostoPromedio = @CostoPromedio WHERE (Codigo = @Ori" & _
        "ginal_Codigo) AND (Barras = @Original_Barras) AND (BodegaConsignacion = @Origina" & _
        "l_BodegaConsignacion) AND (CodMarca = @Original_CodMarca) AND (CodPresentacion =" & _
        " @Original_CodPresentacion) AND (Costo = @Original_Costo) AND (CostoPromedio = @" & _
        "Original_CostoPromedio) AND (Descripcion = @Original_Descripcion) AND (Existenci" & _
        "a = @Original_Existencia) AND (ExistenciaBodega = @Original_ExistenciaBodega) AN" & _
        "D (FechaIngreso = @Original_FechaIngreso) AND (Fletes = @Original_Fletes) AND (I" & _
        "Venta = @Original_IVenta) AND (Inhabilitado = @Original_Inhabilitado) AND (Max_C" & _
        "omision = @Original_Max_Comision) AND (Max_Descuento = @Original_Max_Descuento) " & _
        "AND (Maxima = @Original_Maxima) AND (Minima = @Original_Minima) AND (MonedaCosto" & _
        " = @Original_MonedaCosto) AND (MonedaVenta = @Original_MonedaVenta) AND (Observa" & _
        "ciones = @Original_Observaciones) AND (OtrosCargos = @Original_OtrosCargos) AND " & _
        "(PrecioBase = @Original_PrecioBase) AND (Precio_A = @Original_Precio_A) AND (Pre" & _
        "cio_B = @Original_Precio_B) AND (Precio_C = @Original_Precio_C) AND (Precio_D = " & _
        "@Original_Precio_D) AND (Precio_Promo = @Original_Precio_Promo) AND (PresentaCan" & _
        "t = @Original_PresentaCant) AND (Promo_Activa = @Original_Promo_Activa) AND (Pro" & _
        "mo_Finaliza = @Original_Promo_Finaliza) AND (Promo_Inicio = @Original_Promo_Inic" & _
        "io) AND (Proveedor = @Original_Proveedor) AND (PuntoMedio = @Original_PuntoMedio" & _
        ") AND (Servicio = @Original_Servicio) AND (SubFamilia = @Original_SubFamilia) AN" & _
        "D (SubUbicacion = @Original_SubUbicacion); SELECT Codigo, Barras, Descripcion, P" & _
        "resentaCant, CodPresentacion, CodMarca, SubFamilia, Minima, PuntoMedio, Maxima, " & _
        "Existencia, ExistenciaBodega, BodegaConsignacion, SubUbicacion, Observaciones, M" & _
        "onedaCosto, PrecioBase, Fletes, OtrosCargos, Costo, MonedaVenta, IVenta, Precio_" & _
        "A, Precio_B, Precio_C, Precio_D, Precio_Promo, Promo_Activa, Promo_Inicio, Promo" & _
        "_Finaliza, Max_Comision, Max_Descuento, Imagen, FechaIngreso, Servicio, Inhabili" & _
        "tado, Proveedor, CostoPromedio FROM Inventario WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 255, "Barras"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PresentaCant", System.Data.SqlDbType.Float, 8, "PresentaCant"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodPresentacion", System.Data.SqlDbType.Int, 4, "CodPresentacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMarca", System.Data.SqlDbType.Int, 4, "CodMarca"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubFamilia", System.Data.SqlDbType.VarChar, 10, "SubFamilia"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Minima", System.Data.SqlDbType.Float, 8, "Minima"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PuntoMedio", System.Data.SqlDbType.Float, 8, "PuntoMedio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Maxima", System.Data.SqlDbType.Float, 8, "Maxima"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Float, 8, "Existencia"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExistenciaBodega", System.Data.SqlDbType.Float, 8, "ExistenciaBodega"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BodegaConsignacion", System.Data.SqlDbType.Int, 4, "BodegaConsignacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubUbicacion", System.Data.SqlDbType.VarChar, 10, "SubUbicacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaCosto", System.Data.SqlDbType.Int, 4, "MonedaCosto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrecioBase", System.Data.SqlDbType.Float, 8, "PrecioBase"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fletes", System.Data.SqlDbType.Float, 8, "Fletes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaVenta", System.Data.SqlDbType.Int, 4, "MonedaVenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IVenta", System.Data.SqlDbType.Float, 8, "IVenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_Promo", System.Data.SqlDbType.Float, 8, "Precio_Promo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Promo_Activa", System.Data.SqlDbType.Bit, 1, "Promo_Activa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Promo_Inicio", System.Data.SqlDbType.DateTime, 4, "Promo_Inicio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Promo_Finaliza", System.Data.SqlDbType.DateTime, 4, "Promo_Finaliza"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Comision", System.Data.SqlDbType.Float, 8, "Max_Comision"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 8, "Max_Descuento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imagen", System.Data.SqlDbType.VarBinary, 2147483647, "Imagen"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Servicio", System.Data.SqlDbType.Bit, 1, "Servicio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Inhabilitado", System.Data.SqlDbType.Bit, 1, "Inhabilitado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CostoPromedio", System.Data.SqlDbType.Float, 8, "CostoPromedio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Barras", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BodegaConsignacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BodegaConsignacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMarca", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMarca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodPresentacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodPresentacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CostoPromedio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoPromedio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Existencia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Existencia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExistenciaBodega", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExistenciaBodega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fletes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fletes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Inhabilitado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Inhabilitado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Comision", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Comision", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Maxima", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Maxima", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Minima", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Minima", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrecioBase", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrecioBase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_A", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_A", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_B", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_B", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_C", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_C", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_D", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_D", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Promo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Promo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PresentaCant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PresentaCant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Promo_Activa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Promo_Activa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Promo_Finaliza", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Promo_Finaliza", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Promo_Inicio", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Promo_Inicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PuntoMedio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PuntoMedio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Servicio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Servicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubFamilia", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubUbicacion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubUbicacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Inventario WHERE (Codigo = @Original_Codigo) AND (Barras = @Original_" & _
        "Barras) AND (BodegaConsignacion = @Original_BodegaConsignacion) AND (CodMarca = " & _
        "@Original_CodMarca) AND (CodPresentacion = @Original_CodPresentacion) AND (Costo" & _
        " = @Original_Costo) AND (CostoPromedio = @Original_CostoPromedio) AND (Descripci" & _
        "on = @Original_Descripcion) AND (Existencia = @Original_Existencia) AND (Existen" & _
        "ciaBodega = @Original_ExistenciaBodega) AND (FechaIngreso = @Original_FechaIngre" & _
        "so) AND (Fletes = @Original_Fletes) AND (IVenta = @Original_IVenta) AND (Inhabil" & _
        "itado = @Original_Inhabilitado) AND (Max_Comision = @Original_Max_Comision) AND " & _
        "(Max_Descuento = @Original_Max_Descuento) AND (Maxima = @Original_Maxima) AND (M" & _
        "inima = @Original_Minima) AND (MonedaCosto = @Original_MonedaCosto) AND (MonedaV" & _
        "enta = @Original_MonedaVenta) AND (Observaciones = @Original_Observaciones) AND " & _
        "(OtrosCargos = @Original_OtrosCargos) AND (PrecioBase = @Original_PrecioBase) AN" & _
        "D (Precio_A = @Original_Precio_A) AND (Precio_B = @Original_Precio_B) AND (Preci" & _
        "o_C = @Original_Precio_C) AND (Precio_D = @Original_Precio_D) AND (Precio_Promo " & _
        "= @Original_Precio_Promo) AND (PresentaCant = @Original_PresentaCant) AND (Promo" & _
        "_Activa = @Original_Promo_Activa) AND (Promo_Finaliza = @Original_Promo_Finaliza" & _
        ") AND (Promo_Inicio = @Original_Promo_Inicio) AND (Proveedor = @Original_Proveed" & _
        "or) AND (PuntoMedio = @Original_PuntoMedio) AND (Servicio = @Original_Servicio) " & _
        "AND (SubFamilia = @Original_SubFamilia) AND (SubUbicacion = @Original_SubUbicaci" & _
        "on)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Barras", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BodegaConsignacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BodegaConsignacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMarca", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMarca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodPresentacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodPresentacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CostoPromedio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoPromedio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Existencia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Existencia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExistenciaBodega", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExistenciaBodega", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fletes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fletes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Inhabilitado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Inhabilitado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Comision", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Comision", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Maxima", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Maxima", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Minima", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Minima", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrecioBase", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrecioBase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_A", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_A", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_B", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_B", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_C", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_C", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_D", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_D", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_Promo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Promo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PresentaCant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PresentaCant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Promo_Activa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Promo_Activa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Promo_Finaliza", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Promo_Finaliza", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Promo_Inicio", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Promo_Inicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PuntoMedio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PuntoMedio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Servicio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Servicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubFamilia", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubUbicacion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubUbicacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmInventarioGRID
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(694, 468)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmInventarioGRID"
        Me.Text = "Inventario Rápido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.TextBoxBuscar, 0)
        Me.Controls.SetChildIndex(Me.LinkLabel1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Presentaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Marca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Familias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Ubicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Consignantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmInventarioGRID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection.ConnectionString = CadenaConexionSeePOS

        Me.AdapterMoneda.Fill(Me.DataSetInventario, "Moneda")
        Me.AdapterMarcas.Fill(Me.DataSetInventario, "Marcas")
        Me.AdapterPresentacion.Fill(Me.DataSetInventario, "Presentaciones")
        'Me.AdapterCasaConsignante.Fill(Me.DataSetInventario, "Bodegas")
        Me.AdapterAUbicacion.Fill(Me.DataSetInventario, "Sububicacion")
        Me.AdapterFamilia.Fill(Me.DataSetInventario, "SubFamilias")


        Me.AdapterInventario.Fill(Me.DataSetInventario, "Inventario")
        'Dim x As Int16
        'For x = 0 To Me.GridBand1.Columns.Count - 1
        '    Me.GridBand1.Columns(x).BestFit()
        'Next

        Me.GridBand1.Columns.View.BestFitColumns()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 3 : Me.RegistrarDatos(Me.AdapterInventario, Me.DataSetInventario, Me.DataSetInventario.Inventario.ToString)
            Case 7 : If MsgBox("Desea Cerrar este módulo...", MsgBoxStyle.YesNo, "Atención..") = MsgBoxResult.Yes Then Me.Close()
        End Select
    End Sub
    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        If TextBoxBuscar.Text.Length > 2 Then
            'Me.SqlConnection.ConnectionString = CadenaConexionSeePOS
            If Me.RadioButton1.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
            ElseIf Me.RadioButton2.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
            Else
                BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
            End If
        End If
    End Sub
    Private Sub BuscarDatos(ByVal Descripcion As String, ByVal CampoFiltro As String)
        If Me.Filtro_Inicio_del_Campo.Checked = True Then
            CadenaWhere = " WHERE " & CampoFiltro & " lIKE '" & Descripcion & "%'" '& IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
        ElseIf Me.Filtro_Cualquier_Parte_del_Campo.Checked = True Then
            CadenaWhere = " WHERE " & CampoFiltro & " lIKE '%" & Descripcion & "%'" '& IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
        Else
            CadenaWhere = "" '& IIf(Me.CheckBoxInHabilitados.Checked = True, "", " Inhabilitado = 0")
        End If
        Try
            Me.GridControl1.Enabled = False
            Me.DataSetInventario.Inventario.Clear()
            Me.AdapterInventario.SelectCommand.CommandText = "SELECT * FROM Inventario" & CadenaWhere
            Me.AdapterInventario.Fill(Me.DataSetInventario, "Inventario")
            Me.GridControl1.Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.GridControl1.Enabled = False
        Me.GridBand1.Columns.View.BestFitColumns()
        Me.GridControl1.Enabled = True
    End Sub
End Class
