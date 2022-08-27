Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class frmUbicacion
    Inherits System.Windows.Forms.Form

    Dim NuevaConexion As String
    Dim usua As Usuario_Logeado
    Dim strModulo As String
#Region " Windows Form Designer generated code "
    'Public Sub New(Optional ByVal Conexion As String = "")
    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        NuevaConexion = Conexion
        usua = Usuario_Parametro

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daubicaciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dasububicacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataNavigator2 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtcodigo_sububica As System.Windows.Forms.TextBox
    Friend WithEvents boton_nueva_sububicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents boton_guardar_sububicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_CodUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataSet_Ubicaciones1 As DataSet_Ubicaciones
    Friend WithEvents Text_CodUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents Text_CodSubUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents boton_guardar_ubicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUbicacion))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.DataSet_Ubicaciones1 = New DataSet_Ubicaciones
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcionD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label15 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daubicaciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.dasububicacion = New System.Data.SqlClient.SqlDataAdapter
        Me.DataNavigator2 = New DevExpress.XtraEditors.DataNavigator
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txtcodigo_sububica = New System.Windows.Forms.TextBox
        Me.boton_nueva_sububicacion = New DevExpress.XtraEditors.SimpleButton
        Me.boton_guardar_sububicacion = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Txt_CodUbicacion = New System.Windows.Forms.TextBox
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Txtcodigo = New System.Windows.Forms.TextBox
        Me.Txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Text_CodUbicacion = New System.Windows.Forms.TextBox
        Me.Text_CodSubUbicacion = New System.Windows.Forms.TextBox
        Me.boton_guardar_ubicacion = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Ubicaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Ubicaciones.UbicacionesSubUbicacion"
        Me.GridControl1.DataSource = Me.DataSet_Ubicaciones1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(6, 104)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(442, 160)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.Text = "GridControl1"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Nueva"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Eliminar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Cancelar"
        '
        'DataSet_Ubicaciones1
        '
        Me.DataSet_Ubicaciones1.DataSetName = "DataSet_Ubicaciones"
        Me.DataSet_Ubicaciones1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcionD, Me.colObservaciones})
        Me.GridView1.GroupPanelText = "Agrupe de acuerdo a la columna deseada"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
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
        Me.colCodigo.Width = 69
        '
        'colDescripcionD
        '
        Me.colDescripcionD.Caption = "Descripción"
        Me.colDescripcionD.FieldName = "DescripcionD"
        Me.colDescripcionD.Name = "colDescripcionD"
        Me.colDescripcionD.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcionD.VisibleIndex = 1
        Me.colDescripcionD.Width = 225
        '
        'colObservaciones
        '
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colObservaciones.VisibleIndex = 2
        Me.colObservaciones.Width = 134
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(472, 40)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Ubicaciones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HAZEL;packet size=4096;integrated security=SSPI;data source=SEESER" & _
        "VER;persist security info=False;initial catalog=Seepos"
        '
        'daubicaciones
        '
        Me.daubicaciones.DeleteCommand = Me.SqlDeleteCommand1
        Me.daubicaciones.InsertCommand = Me.SqlInsertCommand1
        Me.daubicaciones.SelectCommand = Me.SqlSelectCommand1
        Me.daubicaciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ubicaciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.daubicaciones.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Ubicaciones WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Ori" & _
        "ginal_Descripcion) AND (Observaciones = @Original_Observaciones)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Ubicaciones(Codigo, Descripcion, Observaciones) VALUES (@Codigo, @Des" & _
        "cripcion, @Observaciones); SELECT Codigo, Descripcion, Observaciones FROM Ubicac" & _
        "iones WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Descripcion, Observaciones FROM Ubicaciones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Ubicaciones SET Codigo = @Codigo, Descripcion = @Descripcion, Observacione" & _
        "s = @Observaciones WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Origina" & _
        "l_Descripcion) AND (Observaciones = @Original_Observaciones); SELECT Codigo, Des" & _
        "cripcion, Observaciones FROM Ubicaciones WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cod_Ubicacion, Cod_SubUbicacion, Codigo, DescripcionD, Observaciones FROM " & _
        "SubUbicacion"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO SubUbicacion(Cod_Ubicacion, Cod_SubUbicacion, Codigo, DescripcionD, O" & _
        "bservaciones) VALUES (@Cod_Ubicacion, @Cod_SubUbicacion, @Codigo, @DescripcionD," & _
        " @Observaciones); SELECT Cod_Ubicacion, Cod_SubUbicacion, Codigo, DescripcionD, " & _
        "Observaciones FROM SubUbicacion WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Ubicacion", System.Data.SqlDbType.Int, 4, "Cod_Ubicacion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_SubUbicacion", System.Data.SqlDbType.Int, 4, "Cod_SubUbicacion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 10, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionD", System.Data.SqlDbType.VarChar, 150, "DescripcionD"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE SubUbicacion SET Cod_Ubicacion = @Cod_Ubicacion, Cod_SubUbicacion = @Cod_S" & _
        "ubUbicacion, Codigo = @Codigo, DescripcionD = @DescripcionD, Observaciones = @Ob" & _
        "servaciones WHERE (Codigo = @Original_Codigo) AND (Cod_SubUbicacion = @Original_" & _
        "Cod_SubUbicacion) AND (Cod_Ubicacion = @Original_Cod_Ubicacion) AND (Descripcion" & _
        "D = @Original_DescripcionD) AND (Observaciones = @Original_Observaciones); SELEC" & _
        "T Cod_Ubicacion, Cod_SubUbicacion, Codigo, DescripcionD, Observaciones FROM SubU" & _
        "bicacion WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Ubicacion", System.Data.SqlDbType.Int, 4, "Cod_Ubicacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_SubUbicacion", System.Data.SqlDbType.Int, 4, "Cod_SubUbicacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 10, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionD", System.Data.SqlDbType.VarChar, 150, "DescripcionD"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_SubUbicacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_SubUbicacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Ubicacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Ubicacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionD", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM SubUbicacion WHERE (Codigo = @Original_Codigo) AND (Cod_SubUbicacion " & _
        "= @Original_Cod_SubUbicacion) AND (Cod_Ubicacion = @Original_Cod_Ubicacion) AND " & _
        "(DescripcionD = @Original_DescripcionD) AND (Observaciones = @Original_Observaci" & _
        "ones)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_SubUbicacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_SubUbicacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Ubicacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Ubicacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionD", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'dasububicacion
        '
        Me.dasububicacion.DeleteCommand = Me.SqlDeleteCommand2
        Me.dasububicacion.InsertCommand = Me.SqlInsertCommand2
        Me.dasububicacion.SelectCommand = Me.SqlSelectCommand2
        Me.dasububicacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SubUbicacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cod_Ubicacion", "Cod_Ubicacion"), New System.Data.Common.DataColumnMapping("Cod_SubUbicacion", "Cod_SubUbicacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("DescripcionD", "DescripcionD"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.dasububicacion.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DataNavigator2
        '
        Me.DataNavigator2.Buttons.Append.Visible = False
        Me.DataNavigator2.Buttons.CancelEdit.Visible = False
        Me.DataNavigator2.Buttons.EndEdit.Visible = False
        Me.DataNavigator2.Buttons.Remove.Visible = False
        Me.DataNavigator2.DataMember = "Ubicaciones"
        Me.DataNavigator2.DataSource = Me.DataSet_Ubicaciones1
        Me.DataNavigator2.Location = New System.Drawing.Point(320, 424)
        Me.DataNavigator2.Name = "DataNavigator2"
        Me.DataNavigator2.Size = New System.Drawing.Size(136, 24)
        Me.DataNavigator2.TabIndex = 67
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion.DescripcionD"))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(81, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(296, 13)
        Me.TextBox2.TabIndex = 69
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion.Observaciones"))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Blue
        Me.TextBox3.Location = New System.Drawing.Point(8, 66)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(368, 30)
        Me.TextBox3.TabIndex = 70
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(81, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Código"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(8, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 14)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Observaciones"
        '
        'Txtcodigo_sububica
        '
        Me.Txtcodigo_sububica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcodigo_sububica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion.Codigo"))
        Me.Txtcodigo_sububica.ForeColor = System.Drawing.Color.Blue
        Me.Txtcodigo_sububica.Location = New System.Drawing.Point(8, 32)
        Me.Txtcodigo_sububica.Name = "Txtcodigo_sububica"
        Me.Txtcodigo_sububica.ReadOnly = True
        Me.Txtcodigo_sububica.Size = New System.Drawing.Size(56, 13)
        Me.Txtcodigo_sububica.TabIndex = 68
        Me.Txtcodigo_sububica.Text = ""
        '
        'boton_nueva_sububicacion
        '
        Me.boton_nueva_sububicacion.Location = New System.Drawing.Point(391, 20)
        Me.boton_nueva_sububicacion.Name = "boton_nueva_sububicacion"
        Me.boton_nueva_sububicacion.Size = New System.Drawing.Size(56, 24)
        Me.boton_nueva_sububicacion.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.boton_nueva_sububicacion.TabIndex = 79
        Me.boton_nueva_sububicacion.Text = "Nuevo"
        '
        'boton_guardar_sububicacion
        '
        Me.boton_guardar_sububicacion.Location = New System.Drawing.Point(391, 52)
        Me.boton_guardar_sububicacion.Name = "boton_guardar_sububicacion"
        Me.boton_guardar_sububicacion.Size = New System.Drawing.Size(56, 24)
        Me.boton_guardar_sububicacion.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.boton_guardar_sububicacion.TabIndex = 80
        Me.boton_guardar_sububicacion.Text = "Agregar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.boton_nueva_sububicacion)
        Me.GroupBox3.Controls.Add(Me.boton_guardar_sububicacion)
        Me.GroupBox3.Controls.Add(Me.Txtcodigo_sububica)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.GridControl1)
        Me.GroupBox3.Controls.Add(Me.Txt_CodUbicacion)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 272)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ubicaciones Espeficicas"
        '
        'Txt_CodUbicacion
        '
        Me.Txt_CodUbicacion.Location = New System.Drawing.Point(456, 240)
        Me.Txt_CodUbicacion.Name = "Txt_CodUbicacion"
        Me.Txt_CodUbicacion.Size = New System.Drawing.Size(32, 20)
        Me.Txt_CodUbicacion.TabIndex = 83
        Me.Txt_CodUbicacion.Text = ""
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.Observaciones"))
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.TxtObservaciones.Location = New System.Drawing.Point(10, 96)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(382, 24)
        Me.TxtObservaciones.TabIndex = 1
        Me.TxtObservaciones.Text = ""
        '
        'Txtcodigo
        '
        Me.Txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.Codigo"))
        Me.Txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodigo.ForeColor = System.Drawing.Color.Blue
        Me.Txtcodigo.Location = New System.Drawing.Point(10, 56)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.ReadOnly = True
        Me.Txtcodigo.Size = New System.Drawing.Size(86, 13)
        Me.Txtcodigo.TabIndex = 0
        Me.Txtcodigo.Text = ""
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.Descripcion"))
        Me.Txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescripcion.ForeColor = System.Drawing.Color.Blue
        Me.Txtdescripcion.Location = New System.Drawing.Point(112, 57)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(352, 13)
        Me.Txtdescripcion.TabIndex = 0
        Me.Txtdescripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(112, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(10, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observaciones"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarImprimir, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 387)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(472, 59)
        Me.ToolBar1.TabIndex = 111
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
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
        'Text_CodUbicacion
        '
        Me.Text_CodUbicacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion.Cod_Ubicacion"))
        Me.Text_CodUbicacion.Location = New System.Drawing.Point(496, 96)
        Me.Text_CodUbicacion.Name = "Text_CodUbicacion"
        Me.Text_CodUbicacion.Size = New System.Drawing.Size(48, 20)
        Me.Text_CodUbicacion.TabIndex = 112
        Me.Text_CodUbicacion.Text = ""
        '
        'Text_CodSubUbicacion
        '
        Me.Text_CodSubUbicacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion.Cod_SubUbicacion"))
        Me.Text_CodSubUbicacion.Location = New System.Drawing.Point(496, 128)
        Me.Text_CodSubUbicacion.Name = "Text_CodSubUbicacion"
        Me.Text_CodSubUbicacion.Size = New System.Drawing.Size(48, 20)
        Me.Text_CodSubUbicacion.TabIndex = 113
        Me.Text_CodSubUbicacion.Text = ""
        '
        'boton_guardar_ubicacion
        '
        Me.boton_guardar_ubicacion.Location = New System.Drawing.Point(400, 96)
        Me.boton_guardar_ubicacion.Name = "boton_guardar_ubicacion"
        Me.boton_guardar_ubicacion.Size = New System.Drawing.Size(64, 24)
        Me.boton_guardar_ubicacion.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.boton_guardar_ubicacion.TabIndex = 114
        Me.boton_guardar_ubicacion.Text = "Guardar"
        '
        'frmUbicacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 446)
        Me.Controls.Add(Me.boton_guardar_ubicacion)
        Me.Controls.Add(Me.Text_CodSubUbicacion)
        Me.Controls.Add(Me.Text_CodUbicacion)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Txtcodigo)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.DataNavigator2)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 480)
        Me.MinimumSize = New System.Drawing.Size(480, 480)
        Me.Name = "frmUbicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubicaciones"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Ubicaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
    Private cod_sub As String
#End Region

    Private Sub frmUbicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
            strModulo = IIf(NuevaConexion = "", "SeePos", "SeePos")

            ' SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Me.daubicaciones.Fill(Me.DataSet_Ubicaciones1, "ubicaciones")
            Me.dasububicacion.Fill(Me.DataSet_Ubicaciones1, "SubUbicacion")

            Me.DataSet_Ubicaciones1.Ubicaciones.ObservacionesColumn.DefaultValue = ""
            Me.DataSet_Ubicaciones1.SubUbicacion.ObservacionesColumn.DefaultValue = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub registrar()
        Try
            Me.ToolBar1.Buttons(3).Enabled = False

            If MessageBox.Show("¿Desea Guardar los Cambios en Ubicaciones?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(3).Enabled = True
                Exit Sub
            End If

            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()

            If Me.Registrar_Ubicacion() Then 'se registra en la base de datos then

                Me.DataSet_Ubicaciones1.AcceptChanges()


                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True

                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0


                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)


                Me.ToolBar1.Buttons(3).Enabled = True

            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)

                Me.ToolBar1.Buttons(3).Enabled = True

            End If


        Catch ex As System.Exception
            Me.ToolBar1.Buttons(3).Enabled = True
            MsgBox(ex.Message)
        End Try

    End Sub

    Function Registrar_Ubicacion() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.daubicaciones.InsertCommand.Transaction = Trans
            Me.daubicaciones.UpdateCommand.Transaction = Trans
            Me.daubicaciones.DeleteCommand.Transaction = Trans
            Me.daubicaciones.SelectCommand.Transaction = Trans

            Me.dasububicacion.InsertCommand.Transaction = Trans
            Me.dasububicacion.UpdateCommand.Transaction = Trans
            Me.dasububicacion.DeleteCommand.Transaction = Trans
            Me.dasububicacion.SelectCommand.Transaction = Trans


            Me.daubicaciones.Update(Me.DataSet_Ubicaciones1, "Ubicaciones")
            Me.dasububicacion.Update(Me.DataSet_Ubicaciones1, "SubUbicacion")
            Trans.Commit()



            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0

            Return True

            Me.DataSet_Ubicaciones1.AcceptChanges()
        Catch ex As Exception
            Trans.Rollback()
            If Err.Number = 5 Then
                MsgBox("No se puede eliminar una ubicación si existen articulos ligados a SubUbicaciones" & vbCrLf & "El error al que hace referencia es el siguiente :" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
            End If


            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

    Private Sub Imprimir()
        Try
            Me.ToolBar1.Buttons(2).Enabled = False
            Dim Ubicaciones_Reporte As New Reporte_Ubicaciones

            CrystalReportsConexion.LoadShow(Ubicaciones_Reporte, MdiParent, Me.SqlConnection1.ConnectionString)
            Me.ToolBar1.Buttons(2).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


#Region "codigo sububicaciones"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_nueva_sububicacion.Click
        nueva_SubUbicacion()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar_sububicacion.Click
        Try
            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").EndCurrentEdit()

            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position = Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position - 1
            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position = Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position + 1

            Me.Registrar_Ubicacion()

            Me.boton_nueva_sububicacion.Enabled = True


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Buscar_Ubicaciones()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            valor = Fx.BuscarDatos("select Codigo as Código,descripcion as Ubicación from ubicaciones", "Descripcion", "Ubicaciones", Me.SqlConnection1.ConnectionString)

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DataSet_Ubicaciones1.Ubicaciones.DefaultView
                vista.Sort = "Codigo"
                pos = vista.Find(CDbl(valor))
                Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position = pos
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region


#Region "codigo Ubicaciones"

    Sub Nueva_Ubicacion()
        Dim fun As New Conexion
        Try

            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").AddNew()

            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            Me.Txtcodigo.Text = CDbl(fun.SlqExecuteScalar(Me.SqlConnection1, "SELECT isnull(MAX(Codigo),0) + 1 FROM Ubicaciones"))
            Me.Txtdescripcion.Focus()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Guardar_Ubicacion()
        Try
            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()
            Me.daubicaciones.Update(Me.DataSet_Ubicaciones1, "Ubicaciones")
            MessageBox.Show("La ubicación ha sido registrada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub nueva_SubUbicacion()

        Dim cod As Integer
        Dim var As String
        Try
            Dim func As New Conexion

            cod = Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").Count + 1


            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").AddNew()

            Text_CodSubUbicacion.Text = cod
            Me.Txtcodigo_sububica.Text = Me.Txtcodigo.Text + "-" + cod.ToString

            Me.Text_CodUbicacion.Text = Me.Txtcodigo.Text

            While func.SlqExecuteScalar(func.Conectar(strModulo), "SELECT Codigo FROM SubUbicacion where Codigo ='" & Me.Txtcodigo_sububica.Text & "'") <> Nothing
                cod = cod + 1
                Me.Text_CodSubUbicacion.Text = cod
                Me.Txtcodigo_sububica.Text = Me.Txtcodigo.Text + "-" + cod.ToString
            End While

            Me.boton_nueva_sububicacion.Enabled = False

            func.DesConectar(func.sQlconexion)
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Eliminar_Ubicacion()

        Dim resp As Integer
        Dim conexion As New conexion
        Try 'se intenta hacer


            If Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Count > 0 Then ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar permanentemente esta Ubicación?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)


                '******************************************************************************

                If Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").Count > 0 Then

                    'Evaluo si las subfamilias estan asociadas a un articulo 
                    Dim tabla1 As New DataTable
                    Dim cfunciones1 As New cFunciones
                    cFunciones.Llenar_Tabla_Generico("SELECT Codigo FROM Inventario WHERE SubUbicacion = '" & Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").Current("Codigo") & "'", tabla1, Me.SqlConnection1.ConnectionString)
                    If tabla1.Rows.Count > 0 Then
                        MsgBox("No se puede eliminar esta Ubicacion por que existe articulos en el inventario relacionados a esta")
                        Exit Sub
                    End If
                End If
                'Cargo el codigo de la Ubicacion al que pertenecen la ubicacion que se eliminaran
                Dim strCodigoUbicacion As String = Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Current("Codigo")
                Dim strMensaje As String = conexion.DeleteRecords("SubUbicacion", "Cod_Ubicacion =" & strCodigoUbicacion, strModulo)

                '******************************************************************************



                If resp = 6 Then
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").RemoveAt(Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position)
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()
                    Me.Registrar_Ubicacion()
                Else
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Ubicaciones que Eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Cancelar_Ubicacion()
        Try
            Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").CancelCurrentEdit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try


            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0
                    If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                        Me.ToolBar1.Buttons(0).Text = "Cancelar"
                        Me.ToolBar1.Buttons(0).ImageIndex = 8
                        Me.ToolBar1.Buttons(3).Enabled = False

                        Me.Nueva_Ubicacion()

                    Else

                        If PMU.Update Then

                            If MessageBox.Show("Desea Guardar esta Familia", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                                Me.registrar() ' se guarda en la base de datos
                            Else

                                Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").CancelCurrentEdit()
                                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                                Me.ToolBar1.Buttons(0).ImageIndex = 0
                                Me.ToolBar1.Buttons(0).Enabled = True
                                Me.ToolBar1.Buttons(1).Enabled = True
                                Me.ToolBar1.Buttons(2).Enabled = True
                                Me.ToolBar1.Buttons(3).Enabled = True
                                Me.ToolBar1.Buttons(4).Enabled = True
                                Me.boton_nueva_sububicacion.Enabled = True
                                Me.boton_guardar_sububicacion.Enabled = True
                            End If

                        Else
                            MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                        End If

                    End If

                Case 2 : If PMU.Print Then Me.Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 1 : If PMU.Find Then Me.Buscar_Ubicaciones() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 3 : If PMU.Update Then Me.registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4 : If PMU.Delete Then Eliminar_Ubicacion() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 5
                    If MessageBox.Show("¿Desea Cerrar el Módulo de Ubicaciones?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub boton_guardar_ubicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar_ubicacion.Click
        Try
            If Me.Txtdescripcion.Text <> "" Then
                Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.Registrar_Ubicacion()
                boton_nueva_sububicacion.Enabled = True
                boton_guardar_sububicacion.Enabled = True

            Else
                MsgBox("Digite la descripción", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException  'Cacha los distintos errores que se pueden dar
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown

        If e.KeyCode = Keys.Delete Then
            Dim resp As Integer
            Try
                If Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").Count > 0 Then

                    Dim tabla As New DataTable
                    Dim cfunciones As New cfunciones
                    Dim strSubUbicacion As String = Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").Current("Codigo")
                    cfunciones.Llenar_Tabla_Generico("SELECT Codigo FROM Inventario WHERE SubUbicacion = '" & strSubUbicacion & "'", tabla, Me.SqlConnection1.ConnectionString)
                    If tabla.Rows.Count > 0 Then
                        MsgBox("No se puede eliminar esta Sub-Ubicacion por que existe articulos en el inventario que pertenecen a esta")
                        Exit Sub
                    End If


                    resp = MessageBox.Show("¿Desea eliminar permanentemente esta Sububicación?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                    If resp = 6 Then
                        Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").RemoveAt(Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").Position)

                        Me.boton_nueva_sububicacion.Enabled = True

                        Me.Registrar_Ubicacion()
                    Else
                        Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones.UbicacionesSubUbicacion").CancelCurrentEdit()
                    End If
                Else
                    MsgBox("Esta Ubicación no tiene sububicaciones", MsgBoxStyle.Information)
                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        nueva_SubUbicacion()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Eliminar_Articulo_Detalle()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
    Private Sub Eliminar_Articulo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer

            If Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.Comprasarticulos_comprados").Count > 0 Then   ' si hay ubicaciones
                'resp = MessageBox.Show("¿Desea eliminar este artículo de la Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.UbicacionesSubUbicacion").RemoveAt(Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.UbicacionesSubUbicacion").Position)
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.UbicacionesSubUbicacion").EndCurrentEdit()
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.UbicacionesSubUbicacion").EndCurrentEdit()
                    'Me.Calcular_Totales_Compras()
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.UbicacionesSubUbicacion").EndCurrentEdit()
                Else
                    Me.BindingContext(Me.DataSet_Ubicaciones1, "ubicaciones.UbicacionesSubUbicacion").CancelCurrentEdit()
                End If
            Else
                MsgBox("El item seleccionado ya no existe en registros...", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

