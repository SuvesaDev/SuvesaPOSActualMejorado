Imports System.Windows.Forms

Public Class FrmRedondeoInventario
    'Inherits System.Windows.Forms.Form
    Inherits FrmPlantilla
    Dim Usua As Object
    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario As Object)
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Usua = Usuario        
        PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu
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
    Friend WithEvents AdapterInventario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_C As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioA_IVI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioB_IVI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioC_IVI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioD_IVI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataSetRedondeoInventario1 As DataSetRedondeoInventario
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRedondeoInventario))
        Me.AdapterInventario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataSetRedondeoInventario1 = New DataSetRedondeoInventario
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIVenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_A = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_B = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_C = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecioA_IVI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecioB_IVI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecioC_IVI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecioD_IVI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRedondeoInventario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 412)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(694, 56)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.DataSource = Me.DataSetRedondeoInventario1
        Me.DataNavigator.Location = New System.Drawing.Point(556, 447)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'TituloModulo
        '
        Me.TituloModulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.None
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(694, 32)
        Me.TituloModulo.Text = "Redondeo de Precios"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'AdapterInventario
        '
        Me.AdapterInventario.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterInventario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterInventario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Barras", "Barras"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("MonedaVenta", "MonedaVenta"), New System.Data.Common.DataColumnMapping("IVenta", "IVenta"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("Precio_B", "Precio_B"), New System.Data.Common.DataColumnMapping("Precio_C", "Precio_C"), New System.Data.Common.DataColumnMapping("Precio_D", "Precio_D")})})
        Me.AdapterInventario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Inventario WHERE (Codigo = @Original_Codigo) AND (Barras = @Original_" & _
        "Barras) AND (Descripcion = @Original_Descripcion) AND (IVenta = @Original_IVenta" & _
        ") AND (MonedaVenta = @Original_MonedaVenta) AND (Precio_A = @Original_Precio_A) " & _
        "AND (Precio_B = @Original_Precio_B) AND (Precio_C = @Original_Precio_C) AND (Pre" & _
        "cio_D = @Original_Precio_D)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Barras", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_A", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_A", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_B", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_B", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_C", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_C", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_D", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_D", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;integrated security=SSPI;data source=""."";per" & _
        "sist security info=False;initial catalog=SeePOS"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Inventario(Codigo, Barras, Descripcion, MonedaVenta, IVenta, Precio_A" & _
        ", Precio_B, Precio_C, Precio_D) VALUES (@Codigo, @Barras, @Descripcion, @MonedaV" & _
        "enta, @IVenta, @Precio_A, @Precio_B, @Precio_C, @Precio_D); SELECT Codigo, Barra" & _
        "s, Descripcion, MonedaVenta, IVenta, Precio_A, Precio_B, Precio_C, Precio_D FROM" & _
        " Inventario WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 255, "Barras"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaVenta", System.Data.SqlDbType.Int, 4, "MonedaVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IVenta", System.Data.SqlDbType.Float, 8, "IVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Barras, Descripcion, MonedaVenta, IVenta, Precio_A, Precio_B, Prec" & _
        "io_C, Precio_D FROM Inventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Inventario SET Codigo = @Codigo, Barras = @Barras, Descripcion = @Descripc" & _
        "ion, MonedaVenta = @MonedaVenta, IVenta = @IVenta, Precio_A = @Precio_A, Precio_" & _
        "B = @Precio_B, Precio_C = @Precio_C, Precio_D = @Precio_D WHERE (Codigo = @Origi" & _
        "nal_Codigo) AND (Barras = @Original_Barras) AND (Descripcion = @Original_Descrip" & _
        "cion) AND (IVenta = @Original_IVenta) AND (MonedaVenta = @Original_MonedaVenta) " & _
        "AND (Precio_A = @Original_Precio_A) AND (Precio_B = @Original_Precio_B) AND (Pre" & _
        "cio_C = @Original_Precio_C) AND (Precio_D = @Original_Precio_D); SELECT Codigo, " & _
        "Barras, Descripcion, MonedaVenta, IVenta, Precio_A, Precio_B, Precio_C, Precio_D" & _
        " FROM Inventario WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 255, "Barras"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaVenta", System.Data.SqlDbType.Int, 4, "MonedaVenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IVenta", System.Data.SqlDbType.Float, 8, "IVenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Barras", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaVenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_A", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_A", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_B", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_B", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_C", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_C", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_D", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_D", System.Data.DataRowVersion.Original, Nothing))
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Inventario"
        Me.GridControl1.DataSource = Me.DataSetRedondeoInventario1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(692, 336)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 70
        Me.GridControl1.Text = "GridControl1"
        '
        'DataSetRedondeoInventario1
        '
        Me.DataSetRedondeoInventario1.DataSetName = "DataSetRedondeoInventario"
        Me.DataSetRedondeoInventario1.Locale = New System.Globalization.CultureInfo("es")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colIVenta, Me.colPrecio_A, Me.colPrecio_B, Me.colPrecio_C, Me.colPrecio_D, Me.colPrecioA_IVI, Me.colPrecioB_IVI, Me.colPrecioC_IVI, Me.colPrecioD_IVI})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 65
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 223
        '
        'colIVenta
        '
        Me.colIVenta.Caption = "IVenta"
        Me.colIVenta.FieldName = "IVenta"
        Me.colIVenta.Name = "colIVenta"
        Me.colIVenta.VisibleIndex = 2
        Me.colIVenta.Width = 62
        '
        'colPrecio_A
        '
        Me.colPrecio_A.Caption = "Precio A"
        Me.colPrecio_A.FieldName = "Precio_A"
        Me.colPrecio_A.Name = "colPrecio_A"
        Me.colPrecio_A.VisibleIndex = 3
        '
        'colPrecio_B
        '
        Me.colPrecio_B.Caption = "Precio B"
        Me.colPrecio_B.FieldName = "Precio_B"
        Me.colPrecio_B.Name = "colPrecio_B"
        Me.colPrecio_B.VisibleIndex = 4
        '
        'colPrecio_C
        '
        Me.colPrecio_C.Caption = "Precio C"
        Me.colPrecio_C.FieldName = "Precio_C"
        Me.colPrecio_C.Name = "colPrecio_C"
        Me.colPrecio_C.VisibleIndex = 5
        '
        'colPrecio_D
        '
        Me.colPrecio_D.Caption = "Precio D"
        Me.colPrecio_D.FieldName = "Precio_D"
        Me.colPrecio_D.Name = "colPrecio_D"
        Me.colPrecio_D.VisibleIndex = 6
        '
        'colPrecioA_IVI
        '
        Me.colPrecioA_IVI.Caption = "PrecioA IVI"
        Me.colPrecioA_IVI.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecioA_IVI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioA_IVI.FieldName = "Precio_A_IVI"
        Me.colPrecioA_IVI.Name = "colPrecioA_IVI"
        Me.colPrecioA_IVI.VisibleIndex = 7
        Me.colPrecioA_IVI.Width = 102
        '
        'colPrecioB_IVI
        '
        Me.colPrecioB_IVI.Caption = "PrecioB IVI"
        Me.colPrecioB_IVI.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecioB_IVI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioB_IVI.FieldName = "Precio_B_IVI"
        Me.colPrecioB_IVI.Name = "colPrecioB_IVI"
        Me.colPrecioB_IVI.VisibleIndex = 8
        Me.colPrecioB_IVI.Width = 102
        '
        'colPrecioC_IVI
        '
        Me.colPrecioC_IVI.Caption = "PrecioC IVI"
        Me.colPrecioC_IVI.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecioC_IVI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioC_IVI.FieldName = "Precio_C_IVI"
        Me.colPrecioC_IVI.Name = "colPrecioC_IVI"
        Me.colPrecioC_IVI.VisibleIndex = 9
        Me.colPrecioC_IVI.Width = 103
        '
        'colPrecioD_IVI
        '
        Me.colPrecioD_IVI.Caption = "PrecioD IVI"
        Me.colPrecioD_IVI.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecioD_IVI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioD_IVI.FieldName = "Precio_D_IVI"
        Me.colPrecioD_IVI.Name = "colPrecioD_IVI"
        Me.colPrecioD_IVI.VisibleIndex = 10
        Me.colPrecioD_IVI.Width = 103
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.Location = New System.Drawing.Point(8, 394)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 13)
        Me.TextBox1.TabIndex = 71
        Me.TextBox1.Text = "5.00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Factor de Redondeo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(392, 388)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(88, 20)
        Me.SimpleButton1.TabIndex = 73
        Me.SimpleButton1.Text = "Aplicar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "0 de 0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(392, 374)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 13)
        Me.CheckBox1.TabIndex = 75
        Me.CheckBox1.Text = "Acelerador"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(136, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Precio Base  >="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Location = New System.Drawing.Point(136, 394)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 13)
        Me.TextBox2.TabIndex = 76
        Me.TextBox2.Text = "0.00"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataSource = Me.DataSetRedondeoInventario1.Moneda
        Me.ComboBox1.DisplayMember = "MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(265, 386)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 78
        Me.ComboBox1.ValueMember = "CodMoneda"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(267, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Moneda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmRedondeoInventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(694, 468)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FrmRedondeoInventario"
        Me.Text = "FrmRedondeoInventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRedondeoInventario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim X As Integer
            For X = 0 To Me.DataSetRedondeoInventario1.Inventario.Count - 1
                With Me.DataSetRedondeoInventario1.Inventario
                    If Me.CheckBox1.Checked = False Then Me.BindingContext(Me.DataSetRedondeoInventario1, "Inventario").Position = X
                    Me.Label2.Text = X & " de " & Me.DataSetRedondeoInventario1.Inventario.Count - 1
                    If Me.CheckBox1.Checked = False Then Application.DoEvents()

                    .Rows(X).Item("Precio_A") = PrecioRedondeado(.Rows(X).Item("Precio_A"), .Rows(X).Item("Iventa"), Me.TextBox1.Text)
                    .Rows(X).Item("Precio_B") = PrecioRedondeado(.Rows(X).Item("Precio_B"), .Rows(X).Item("Iventa"), Me.TextBox1.Text)
                    .Rows(X).Item("Precio_C") = PrecioRedondeado(.Rows(X).Item("Precio_C"), .Rows(X).Item("Iventa"), Me.TextBox1.Text)
                    .Rows(X).Item("Precio_D") = PrecioRedondeado(.Rows(X).Item("Precio_D"), .Rows(X).Item("Iventa"), Me.TextBox1.Text)

                    Me.DataSetRedondeoInventario1.Inventario1.Rows(X).Item("Precio_A") = .Rows(X).Item("Precio_A")
                    Me.DataSetRedondeoInventario1.Inventario1.Rows(X).Item("Precio_B") = .Rows(X).Item("Precio_B")
                    Me.DataSetRedondeoInventario1.Inventario1.Rows(X).Item("Precio_C") = .Rows(X).Item("Precio_C")
                    Me.DataSetRedondeoInventario1.Inventario1.Rows(X).Item("Precio_D") = .Rows(X).Item("Precio_D")
                End With
            Next
            MsgBox("El Proceso ha Finalizado..", MsgBoxStyle.Information, "Atención...")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    Private Function PrecioRedondeado(ByVal PrecioBase As Double, ByVal IVenta As Double, ByVal Rnd As Integer) As Double
        Dim Diferencia As Double = PrecioBase * (1 + (IVenta / 100)) Mod Rnd
        Dim NuevoPrecioBaseIVI As Double = IIf(Diferencia > (Rnd / 2), PrecioBase * (1 + (IVenta / 100)) - Diferencia + Rnd, PrecioBase * (1 + (IVenta / 100)) - Diferencia)
        Dim NuevoPrecioBase As Double = NuevoPrecioBaseIVI / (1 + (IVenta / 100))
        Return NuevoPrecioBase
    End Function
    Private Sub Nuevos()
        Me.ToolBarNuevo.Enabled = False
        Me.DataSetRedondeoInventario1.Inventario.Clear()
        Me.DataSetRedondeoInventario1.Inventario1.Clear()
        Dim Fx As New cFunciones
        Dim Mayor As Double
        Mayor = Me.TextBox2.Text
        Fx.Llenar_Tabla_Generico("SELECT Codigo, Barras, Descripcion, MonedaVenta, IVenta, Precio_A, Precio_B, Precio_C, Precio_D FROM Inventario WHERE monedaventa = " & Me.BindingContext(Me.DataSetRedondeoInventario1.Moneda).Current("CodMoneda") & " and (Precio_A >= " & Mayor & "  OR  Precio_B >= " & Mayor & "  OR  Precio_C >= " & Mayor & "  OR  Precio_D >= " & Mayor & ")", Me.DataSetRedondeoInventario1.Inventario)
        Fx.Llenar_Tabla_Generico("SELECT Codigo, Barras, Descripcion, MonedaVenta, IVenta, Precio_A, Precio_B, Precio_C, Precio_D FROM Inventario WHERE monedaventa = " & Me.BindingContext(Me.DataSetRedondeoInventario1.Moneda).Current("CodMoneda") & " and (Precio_A >= " & Mayor & "  OR  Precio_B >= " & Mayor & "  OR  Precio_C >= " & Mayor & "  OR  Precio_D >= " & Mayor & ")", Me.DataSetRedondeoInventario1.Inventario1)
        Me.GridView1.BestFitColumns()
        Me.ToolBarNuevo.Enabled = True
        Me.ToolBarRegistrar.Enabled = True
    End Sub
    Private Sub Registrar()
        Me.ToolBar1.Enabled = False
        Try
            If MsgBox("Desea proceder a registrar los cambios de Precio en el Inventario...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
                Me.BindingContext(Me.DataSetRedondeoInventario1, "Inventario1").EndCurrentEdit()
                Me.AdapterInventario.Update(Me.DataSetRedondeoInventario1, "Inventario1")
                MsgBox("Actualización se ha realizado satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
        Me.ToolBar1.Enabled = True
        Me.ToolBarRegistrar.Enabled = False
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : If PMU.Execute Then Me.Nuevos() Else MsgBox("No tiene permiso para ejecutar esta acción...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 1 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If MessageBox.Show("¿Desea Cerrar el modulo actual..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()

        End Select
    End Sub


    Private Sub FrmRedondeoInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS
        Me.GridView1.BestFitColumns()
        Dim Fx As cFunciones
        Fx.Llenar_Tabla_Generico("Select CodMoneda,MonedaNombre from Moneda", Me.DataSetRedondeoInventario1.Moneda)
        Me.ToolBarRegistrar.Enabled = False
    End Sub
End Class
