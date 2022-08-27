Public Class frm_traslados_inventario
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_Descri_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodigo_art As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioUni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_Anulado As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Text_Transportista As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_Destinatario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_Destino As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCosto_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txt_Descri_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.TxtCodigo_art = New DevExpress.XtraEditors.TextEdit
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit
        Me.TxtCant = New DevExpress.XtraEditors.TextEdit
        Me.TxtPrecioUni = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label_Anulado = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Text_Transportista = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Text_Destinatario = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Text_Destino = New DevExpress.XtraEditors.TextEdit
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioUni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Text_Transportista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text_Destinatario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text_Destino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle"
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Enabled = False
        Me.GridControl1.Location = New System.Drawing.Point(36, 308)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(608, 112)
        Me.GridControl1.Styles.AddReplace("Preview", New DevExpress.Utils.ViewStyleEx("Preview", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, True, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Top, Nothing, System.Drawing.Color.FromArgb(CType(217, Byte), CType(245, Byte), CType(255, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FooterPanel", New DevExpress.Utils.ViewStyleEx("FooterPanel", "Grid", New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupButton", New DevExpress.Utils.ViewStyleEx("GroupButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterCloseButton", New DevExpress.Utils.ViewStyleEx("FilterCloseButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(125, Byte), CType(125, Byte), CType(125, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("EvenRow", New DevExpress.Utils.ViewStyleEx("EvenRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.GhostWhite, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("HideSelectionRow", New DevExpress.Utils.ViewStyleEx("HideSelectionRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FixedLine", New DevExpress.Utils.ViewStyleEx("FixedLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(15, Byte), CType(58, Byte), CType(81, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyleEx("HeaderPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupPanel", New DevExpress.Utils.ViewStyleEx("GroupPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaption, System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Empty", New DevExpress.Utils.ViewStyleEx("Empty", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupFooter", New DevExpress.Utils.ViewStyleEx("GroupFooter", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(167, Byte), CType(195, Byte), CType(210, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupRow", New DevExpress.Utils.ViewStyleEx("GroupRow", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Silver, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HorzLine", New DevExpress.Utils.ViewStyleEx("HorzLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButton", New DevExpress.Utils.ViewStyleEx("ColumnFilterButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedRow", New DevExpress.Utils.ViewStyleEx("FocusedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(135, Byte), CType(178, Byte), CType(201, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("VertLine", New DevExpress.Utils.ViewStyleEx("VertLine", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedCell", New DevExpress.Utils.ViewStyleEx("FocusedCell", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("OddRow", New DevExpress.Utils.ViewStyleEx("OddRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(206, Byte), CType(220, Byte), CType(227, Byte)), System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal))
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(95, Byte), CType(138, Byte), CType(161, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Row", New DevExpress.Utils.ViewStyleEx("Row", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterPanel", New DevExpress.Utils.ViewStyleEx("FilterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(35, Byte), CType(35, Byte), CType(35, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("RowSeparator", New DevExpress.Utils.ViewStyleEx("RowSeparator", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.LightGray, System.Drawing.Color.Blue, System.Drawing.Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("DetailTip", New DevExpress.Utils.ViewStyleEx("DetailTip", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colCosto_Unit, Me.colTotal})
        Me.GridView1.GroupPanelText = "Detalle de Cotización"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
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
        Me.colCodigo.Width = 74
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
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
        Me.colDescripcion.Width = 188
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
        Me.colCantidad.Width = 101
        '
        'colCosto_Unit
        '
        Me.colCosto_Unit.Caption = "Costo Unit."
        Me.colCosto_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colCosto_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCosto_Unit.FieldName = "Costo_Unit"
        Me.colCosto_Unit.Name = "colCosto_Unit"
        Me.colCosto_Unit.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCosto_Unit.VisibleIndex = 3
        Me.colCosto_Unit.Width = 101
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 106
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Txt_Descri_Articulo)
        Me.GroupBox3.Controls.Add(Me.TxtCodigo_art)
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.TxtCant)
        Me.GroupBox3.Controls.Add(Me.TxtPrecioUni)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label_Anulado)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(36, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(608, 97)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Articulo"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(168, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(224, 40)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "DEVUELTO"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label13.Visible = False
        '
        'Txt_Descri_Articulo
        '
        Me.Txt_Descri_Articulo.EditValue = ""
        Me.Txt_Descri_Articulo.Location = New System.Drawing.Point(110, 32)
        Me.Txt_Descri_Articulo.Name = "Txt_Descri_Articulo"
        '
        'Txt_Descri_Articulo.Properties
        '
        Me.Txt_Descri_Articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descri_Articulo.Properties.ReadOnly = True
        Me.Txt_Descri_Articulo.Size = New System.Drawing.Size(464, 19)
        Me.Txt_Descri_Articulo.TabIndex = 1
        '
        'TxtCodigo_art
        '
        Me.TxtCodigo_art.EditValue = ""
        Me.TxtCodigo_art.Location = New System.Drawing.Point(8, 32)
        Me.TxtCodigo_art.Name = "TxtCodigo_art"
        Me.TxtCodigo_art.Size = New System.Drawing.Size(80, 19)
        Me.TxtCodigo_art.TabIndex = 5
        '
        'TxtTotal
        '
        Me.TxtTotal.EditValue = ""
        Me.TxtTotal.Location = New System.Drawing.Point(192, 72)
        Me.TxtTotal.Name = "TxtTotal"
        '
        'TxtTotal.Properties
        '
        Me.TxtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtTotal.Size = New System.Drawing.Size(104, 19)
        Me.TxtTotal.TabIndex = 3
        '
        'TxtCant
        '
        Me.TxtCant.EditValue = ""
        Me.TxtCant.Location = New System.Drawing.Point(112, 72)
        Me.TxtCant.Name = "TxtCant"
        '
        'TxtCant.Properties
        '
        Me.TxtCant.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.Highlight)
        Me.TxtCant.Size = New System.Drawing.Size(64, 19)
        Me.TxtCant.TabIndex = 6
        '
        'TxtPrecioUni
        '
        Me.TxtPrecioUni.EditValue = ""
        Me.TxtPrecioUni.Location = New System.Drawing.Point(8, 70)
        Me.TxtPrecioUni.Name = "TxtPrecioUni"
        '
        'TxtPrecioUni.Properties
        '
        Me.TxtPrecioUni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUni.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtPrecioUni.Size = New System.Drawing.Size(88, 19)
        Me.TxtPrecioUni.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(110, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(464, 14)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(192, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 14)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Total"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(8, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Precio Unit"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Código"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(112, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cantidad:"
        '
        'Label_Anulado
        '
        Me.Label_Anulado.BackColor = System.Drawing.Color.White
        Me.Label_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Anulado.ForeColor = System.Drawing.Color.Red
        Me.Label_Anulado.Location = New System.Drawing.Point(384, 56)
        Me.Label_Anulado.Name = "Label_Anulado"
        Me.Label_Anulado.Size = New System.Drawing.Size(192, 40)
        Me.Label_Anulado.TabIndex = 204
        Me.Label_Anulado.Text = "ANULADO"
        Me.Label_Anulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Anulado.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Text_Transportista)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Text_Destinatario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Text_Destino)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 128)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(8, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 11)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Transportista"
        '
        'Text_Transportista
        '
        Me.Text_Transportista.EditValue = ""
        Me.Text_Transportista.Location = New System.Drawing.Point(8, 104)
        Me.Text_Transportista.Name = "Text_Transportista"
        '
        'Text_Transportista.Properties
        '
        Me.Text_Transportista.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Transportista.Size = New System.Drawing.Size(264, 19)
        Me.Text_Transportista.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(8, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 11)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Destinatario"
        '
        'Text_Destinatario
        '
        Me.Text_Destinatario.EditValue = ""
        Me.Text_Destinatario.Location = New System.Drawing.Point(8, 67)
        Me.Text_Destinatario.Name = "Text_Destinatario"
        '
        'Text_Destinatario.Properties
        '
        Me.Text_Destinatario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Destinatario.Size = New System.Drawing.Size(264, 19)
        Me.Text_Destinatario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 11)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destino"
        '
        'Text_Destino
        '
        Me.Text_Destino.EditValue = ""
        Me.Text_Destino.Location = New System.Drawing.Point(8, 27)
        Me.Text_Destino.Name = "Text_Destino"
        '
        'Text_Destino.Properties
        '
        Me.Text_Destino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Destino.Size = New System.Drawing.Size(264, 19)
        Me.Text_Destino.TabIndex = 2
        '
        'frm_traslados_inventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 497)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_traslados_inventario"
        Me.Text = "Traslado Inventario"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioUni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Text_Transportista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text_Destinatario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text_Destino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
