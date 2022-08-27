Imports System.Data
Imports System.Windows.Forms

Public Class AgregarPerfil
    Inherits FrmPlantilla
    Public strModulos As String
    Dim CON As Double = 0
    Dim usua As Object

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal modulos As String, ByVal Usuario_Parametro As Object)
        MyBase.New()



        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        strModulos = modulos
        AddHandler Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").CurrentChanged, AddressOf Me.CambioPosicion
        AddHandler Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").CurrentChanged, AddressOf Me.CambioPosicion
        AddHandler btnAgregaPerfil.Click, AddressOf Me.CambioPosicion
        AddHandler btnAsignarModulo.Click, AddressOf Me.CambioPosicion
        AddHandler btnEliminarModulo.Click, AddressOf Me.CambioPosicion
        AddHandler GridControl1.Click, AddressOf Me.CambioPosicion


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
    Friend WithEvents AdapterPerfil As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetPerfilUsuario1 As DataSetPerfilUsuario
    Friend WithEvents txtNombrePerfil As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregaPerfil As System.Windows.Forms.Button
    Friend WithEvents GridControlModulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdapterModulos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControlPerfilModulo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdapterPerfilModulo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents colId_Modulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion_Ejecucion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion_Actualizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion_Eliminacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion_Busqueda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion_Impresion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion_Opcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colId_modulo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModulo_Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAsignarModulo As System.Windows.Forms.Button
    Friend WithEvents btnEliminarModulo As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colNombre_Perfil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdapterPerfilUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel6 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ColumnGrupo As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AgregarPerfil))
        Me.txtNombrePerfil = New System.Windows.Forms.TextBox
        Me.btnAgregaPerfil = New System.Windows.Forms.Button
        Me.AdapterPerfil = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataSetPerfilUsuario1 = New DataSetPerfilUsuario
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNombre_Perfil = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControlModulos = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId_modulo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModulo_Nombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColumnGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AdapterModulos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GridControlPerfilModulo = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId_Modulo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colAccion_Ejecucion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colAccion_Actualizacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccion_Eliminacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccion_Busqueda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccion_Impresion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccion_Opcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GrupoLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnAsignarModulo = New System.Windows.Forms.Button
        Me.btnEliminarModulo = New System.Windows.Forms.Button
        Me.AdapterPerfilModulo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AdapterPerfilUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel6 = New System.Windows.Forms.StatusBarPanel
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPerfilUsuario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlPerfilModulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(827, 32)
        Me.TituloModulo.Text = "Crear Perfiles"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 9
        Me.ToolBarBuscar.Text = "Editar"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.DataMember = "Perfil"
        Me.DataNavigator.DataSource = Me.DataSetPerfilUsuario1
        Me.DataNavigator.Location = New System.Drawing.Point(691, 344)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'ToolBar1
        '
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 296)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(827, 52)
        '
        'txtNombrePerfil
        '
        Me.txtNombrePerfil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombrePerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombrePerfil.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNombrePerfil.Location = New System.Drawing.Point(6, 49)
        Me.txtNombrePerfil.Name = "txtNombrePerfil"
        Me.txtNombrePerfil.Size = New System.Drawing.Size(122, 13)
        Me.txtNombrePerfil.TabIndex = 70
        Me.txtNombrePerfil.Text = ""
        '
        'btnAgregaPerfil
        '
        Me.btnAgregaPerfil.Image = CType(resources.GetObject("btnAgregaPerfil.Image"), System.Drawing.Image)
        Me.btnAgregaPerfil.Location = New System.Drawing.Point(137, 46)
        Me.btnAgregaPerfil.Name = "btnAgregaPerfil"
        Me.btnAgregaPerfil.Size = New System.Drawing.Size(29, 16)
        Me.btnAgregaPerfil.TabIndex = 71
        Me.btnAgregaPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdapterPerfil
        '
        Me.AdapterPerfil.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterPerfil.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterPerfil.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterPerfil.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Perfil", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Perfil", "Id_Perfil"), New System.Data.Common.DataColumnMapping("Nombre_Perfil", "Nombre_Perfil")})})
        Me.AdapterPerfil.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Perfil WHERE (Id_Perfil = @Original_Id_Perfil) AND (Nombre_Perfil = @" & _
        "Original_Nombre_Perfil)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Perfil", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESERVER;packet size=4096;integrated security=SSPI;data source=""." & _
        """;persist security info=False;initial catalog=Seguridad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Perfil(Nombre_Perfil) VALUES (@Nombre_Perfil); SELECT Id_Perfil, Nomb" & _
        "re_Perfil FROM Perfil WHERE (Id_Perfil = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, "Nombre_Perfil"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Perfil, Nombre_Perfil FROM Perfil"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Perfil SET Nombre_Perfil = @Nombre_Perfil WHERE (Id_Perfil = @Original_Id_" & _
        "Perfil) AND (Nombre_Perfil = @Original_Nombre_Perfil); SELECT Id_Perfil, Nombre_" & _
        "Perfil FROM Perfil WHERE (Id_Perfil = @Id_Perfil)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, "Nombre_Perfil"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Perfil"
        Me.GridControl1.DataSource = Me.DataSetPerfilUsuario1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(5, 66)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(162, 223)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 89
        Me.GridControl1.Text = "GridControl1"
        '
        'DataSetPerfilUsuario1
        '
        Me.DataSetPerfilUsuario1.DataSetName = "DataSetPerfilUsuario"
        Me.DataSetPerfilUsuario1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre_Perfil})
        Me.GridView1.GroupPanelText = ""
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNombre_Perfil
        '
        Me.colNombre_Perfil.Caption = "Nombre del Perfil"
        Me.colNombre_Perfil.FieldName = "Nombre_Perfil"
        Me.colNombre_Perfil.Name = "colNombre_Perfil"
        Me.colNombre_Perfil.Options = CType((((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNombre_Perfil.VisibleIndex = 0
        '
        'GridControlModulos
        '
        Me.GridControlModulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControlModulos.DataMember = "Modulos1"
        Me.GridControlModulos.DataSource = Me.DataSetPerfilUsuario1
        '
        'GridControlModulos.EmbeddedNavigator
        '
        Me.GridControlModulos.EmbeddedNavigator.Name = ""
        Me.GridControlModulos.Location = New System.Drawing.Point(171, 67)
        Me.GridControlModulos.MainView = Me.GridView2
        Me.GridControlModulos.Name = "GridControlModulos"
        Me.GridControlModulos.Size = New System.Drawing.Size(300, 222)
        Me.GridControlModulos.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControlModulos.TabIndex = 90
        Me.GridControlModulos.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId_modulo1, Me.colModulo_Nombre, Me.ColumnGrupo})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colId_modulo1
        '
        Me.colId_modulo1.Caption = "Id"
        Me.colId_modulo1.FieldName = "Id_modulo"
        Me.colId_modulo1.Name = "colId_modulo1"
        Me.colId_modulo1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colId_modulo1.VisibleIndex = 0
        Me.colId_modulo1.Width = 38
        '
        'colModulo_Nombre
        '
        Me.colModulo_Nombre.Caption = "Modulo"
        Me.colModulo_Nombre.FieldName = "Modulo_Nombre"
        Me.colModulo_Nombre.Name = "colModulo_Nombre"
        Me.colModulo_Nombre.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colModulo_Nombre.VisibleIndex = 1
        Me.colModulo_Nombre.Width = 129
        '
        'ColumnGrupo
        '
        Me.ColumnGrupo.Caption = "Grupo"
        Me.ColumnGrupo.FieldName = "Grupo"
        Me.ColumnGrupo.GroupIndex = 0
        Me.ColumnGrupo.Name = "ColumnGrupo"
        Me.ColumnGrupo.SortIndex = 0
        Me.ColumnGrupo.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.ColumnGrupo.Width = 20
        '
        'AdapterModulos
        '
        Me.AdapterModulos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterModulos.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterModulos.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterModulos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Modulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_modulo", "Id_modulo"), New System.Data.Common.DataColumnMapping("Modulo_Nombre_Interno", "Modulo_Nombre_Interno"), New System.Data.Common.DataColumnMapping("Modulo_Nombre", "Modulo_Nombre"), New System.Data.Common.DataColumnMapping("Software", "Software"), New System.Data.Common.DataColumnMapping("Grupo", "Grupo")})})
        Me.AdapterModulos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Modulos WHERE (Id_modulo = @Original_Id_modulo) AND (Grupo = @Origina" & _
        "l_Grupo OR @Original_Grupo IS NULL AND Grupo IS NULL) AND (Modulo_Nombre = @Orig" & _
        "inal_Modulo_Nombre) AND (Modulo_Nombre_Interno = @Original_Modulo_Nombre_Interno" & _
        ") AND (Software = @Original_Software)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_modulo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Grupo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Grupo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo_Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo_Nombre_Interno", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo_Nombre_Interno", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Software", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Software", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Modulos(Modulo_Nombre_Interno, Modulo_Nombre, Software, Grupo) VALUES" & _
        " (@Modulo_Nombre_Interno, @Modulo_Nombre, @Software, @Grupo); SELECT Id_modulo, " & _
        "Modulo_Nombre_Interno, Modulo_Nombre, Software, Grupo FROM Modulos WHERE (Id_mod" & _
        "ulo = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo_Nombre_Interno", System.Data.SqlDbType.VarChar, 50, "Modulo_Nombre_Interno"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo_Nombre", System.Data.SqlDbType.VarChar, 50, "Modulo_Nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Software", System.Data.SqlDbType.Int, 4, "Software"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Grupo", System.Data.SqlDbType.VarChar, 20, "Grupo"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_modulo, Modulo_Nombre_Interno, Modulo_Nombre, Software, Grupo FROM Modu" & _
        "los"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Modulos SET Modulo_Nombre_Interno = @Modulo_Nombre_Interno, Modulo_Nombre " & _
        "= @Modulo_Nombre, Software = @Software, Grupo = @Grupo WHERE (Id_modulo = @Origi" & _
        "nal_Id_modulo) AND (Grupo = @Original_Grupo OR @Original_Grupo IS NULL AND Grupo" & _
        " IS NULL) AND (Modulo_Nombre = @Original_Modulo_Nombre) AND (Modulo_Nombre_Inter" & _
        "no = @Original_Modulo_Nombre_Interno) AND (Software = @Original_Software); SELEC" & _
        "T Id_modulo, Modulo_Nombre_Interno, Modulo_Nombre, Software, Grupo FROM Modulos " & _
        "WHERE (Id_modulo = @Id_modulo)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo_Nombre_Interno", System.Data.SqlDbType.VarChar, 50, "Modulo_Nombre_Interno"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo_Nombre", System.Data.SqlDbType.VarChar, 50, "Modulo_Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Software", System.Data.SqlDbType.Int, 4, "Software"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Grupo", System.Data.SqlDbType.VarChar, 20, "Grupo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_modulo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Grupo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Grupo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo_Nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo_Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo_Nombre_Interno", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo_Nombre_Interno", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Software", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Software", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_modulo", System.Data.SqlDbType.Int, 4, "Id_modulo"))
        '
        'GridControlPerfilModulo
        '
        Me.GridControlPerfilModulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControlPerfilModulo.DataMember = "Perfil.PerfilPerfil_x_Modulo"
        Me.GridControlPerfilModulo.DataSource = Me.DataSetPerfilUsuario1
        '
        'GridControlPerfilModulo.EmbeddedNavigator
        '
        Me.GridControlPerfilModulo.EmbeddedNavigator.Name = ""
        Me.GridControlPerfilModulo.Location = New System.Drawing.Point(496, 67)
        Me.GridControlPerfilModulo.MainView = Me.GridView3
        Me.GridControlPerfilModulo.Name = "GridControlPerfilModulo"
        Me.GridControlPerfilModulo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCheckEdit1, Me.GrupoLookUpEdit2})
        Me.GridControlPerfilModulo.Size = New System.Drawing.Size(328, 221)
        Me.GridControlPerfilModulo.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControlPerfilModulo.TabIndex = 91
        Me.GridControlPerfilModulo.Text = "GridControl3"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId_Modulo, Me.colAccion_Ejecucion, Me.colAccion_Actualizacion, Me.colAccion_Eliminacion, Me.colAccion_Busqueda, Me.colAccion_Impresion, Me.colAccion_Opcion, Me.colGrupo})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupedColumns = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colId_Modulo
        '
        Me.colId_Modulo.Caption = "Id_Modulo"
        Me.colId_Modulo.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colId_Modulo.FieldName = "Id_Modulo"
        Me.colId_Modulo.Name = "colId_Modulo"
        Me.colId_Modulo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colId_Modulo.VisibleIndex = 0
        Me.colId_Modulo.Width = 110
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modulo_Nombre", "Modulo_Nombre", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.DataSetPerfilUsuario1.Modulos
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Modulo_Nombre"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullString = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Id_modulo"
        '
        'colAccion_Ejecucion
        '
        Me.colAccion_Ejecucion.Caption = "EX"
        Me.colAccion_Ejecucion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAccion_Ejecucion.FieldName = "Accion_Ejecucion"
        Me.colAccion_Ejecucion.Name = "colAccion_Ejecucion"
        Me.colAccion_Ejecucion.VisibleIndex = 1
        Me.colAccion_Ejecucion.Width = 45
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colAccion_Actualizacion
        '
        Me.colAccion_Actualizacion.Caption = "UD"
        Me.colAccion_Actualizacion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAccion_Actualizacion.FieldName = "Accion_Actualizacion"
        Me.colAccion_Actualizacion.Name = "colAccion_Actualizacion"
        Me.colAccion_Actualizacion.VisibleIndex = 2
        Me.colAccion_Actualizacion.Width = 47
        '
        'colAccion_Eliminacion
        '
        Me.colAccion_Eliminacion.Caption = "DE"
        Me.colAccion_Eliminacion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAccion_Eliminacion.FieldName = "Accion_Eliminacion"
        Me.colAccion_Eliminacion.Name = "colAccion_Eliminacion"
        Me.colAccion_Eliminacion.VisibleIndex = 3
        Me.colAccion_Eliminacion.Width = 45
        '
        'colAccion_Busqueda
        '
        Me.colAccion_Busqueda.Caption = "FI"
        Me.colAccion_Busqueda.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAccion_Busqueda.FieldName = "Accion_Busqueda"
        Me.colAccion_Busqueda.Name = "colAccion_Busqueda"
        Me.colAccion_Busqueda.VisibleIndex = 4
        Me.colAccion_Busqueda.Width = 44
        '
        'colAccion_Impresion
        '
        Me.colAccion_Impresion.Caption = "PR"
        Me.colAccion_Impresion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAccion_Impresion.FieldName = "Accion_Impresion"
        Me.colAccion_Impresion.Name = "colAccion_Impresion"
        Me.colAccion_Impresion.VisibleIndex = 5
        Me.colAccion_Impresion.Width = 45
        '
        'colAccion_Opcion
        '
        Me.colAccion_Opcion.Caption = "OP"
        Me.colAccion_Opcion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAccion_Opcion.FieldName = "Accion_Opcion"
        Me.colAccion_Opcion.Name = "colAccion_Opcion"
        Me.colAccion_Opcion.VisibleIndex = 6
        Me.colAccion_Opcion.Width = 59
        '
        'colGrupo
        '
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Menu"
        Me.colGrupo.GroupIndex = 0
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colGrupo.SortIndex = 0
        Me.colGrupo.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        '
        'GrupoLookUpEdit2
        '
        Me.GrupoLookUpEdit2.AutoHeight = False
        Me.GrupoLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GrupoLookUpEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GrupoLookUpEdit2.DataSource = Me.DataSetPerfilUsuario1.Modulos
        Me.GrupoLookUpEdit2.DisplayMember = "Grupo"
        Me.GrupoLookUpEdit2.Name = "GrupoLookUpEdit2"
        Me.GrupoLookUpEdit2.NullString = ""
        Me.GrupoLookUpEdit2.ValueMember = "Grupo"
        '
        'btnAsignarModulo
        '
        Me.btnAsignarModulo.Location = New System.Drawing.Point(474, 70)
        Me.btnAsignarModulo.Name = "btnAsignarModulo"
        Me.btnAsignarModulo.Size = New System.Drawing.Size(18, 23)
        Me.btnAsignarModulo.TabIndex = 92
        Me.btnAsignarModulo.Text = ">"
        '
        'btnEliminarModulo
        '
        Me.btnEliminarModulo.Location = New System.Drawing.Point(474, 97)
        Me.btnEliminarModulo.Name = "btnEliminarModulo"
        Me.btnEliminarModulo.Size = New System.Drawing.Size(18, 23)
        Me.btnEliminarModulo.TabIndex = 93
        Me.btnEliminarModulo.Text = "<"
        '
        'AdapterPerfilModulo
        '
        Me.AdapterPerfilModulo.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterPerfilModulo.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterPerfilModulo.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterPerfilModulo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Perfil_x_Modulo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Perfil", "Id_Perfil"), New System.Data.Common.DataColumnMapping("Id_Modulo", "Id_Modulo"), New System.Data.Common.DataColumnMapping("Accion_Ejecucion", "Accion_Ejecucion"), New System.Data.Common.DataColumnMapping("Accion_Actualizacion", "Accion_Actualizacion"), New System.Data.Common.DataColumnMapping("Accion_Eliminacion", "Accion_Eliminacion"), New System.Data.Common.DataColumnMapping("Accion_Busqueda", "Accion_Busqueda"), New System.Data.Common.DataColumnMapping("Accion_Impresion", "Accion_Impresion"), New System.Data.Common.DataColumnMapping("Accion_Opcion", "Accion_Opcion"), New System.Data.Common.DataColumnMapping("Id_Modulo_Perfil", "Id_Modulo_Perfil"), New System.Data.Common.DataColumnMapping("Menu", "Menu")})})
        Me.AdapterPerfilModulo.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Perfil_x_Modulo WHERE (Id_Modulo_Perfil = @Original_Id_Modulo_Perfil)" & _
        " AND (Accion_Actualizacion = @Original_Accion_Actualizacion) AND (Accion_Busqued" & _
        "a = @Original_Accion_Busqueda) AND (Accion_Ejecucion = @Original_Accion_Ejecucio" & _
        "n) AND (Accion_Eliminacion = @Original_Accion_Eliminacion) AND (Accion_Impresion" & _
        " = @Original_Accion_Impresion) AND (Accion_Opcion = @Original_Accion_Opcion) AND" & _
        " (Id_Modulo = @Original_Id_Modulo) AND (Id_Perfil = @Original_Id_Perfil) AND (Me" & _
        "nu = @Original_Menu)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Modulo_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Modulo_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Actualizacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Actualizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Busqueda", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Busqueda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Ejecucion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Ejecucion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Eliminacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Eliminacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Impresion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Impresion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Opcion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Opcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Modulo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Menu", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Menu", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Perfil_x_Modulo(Id_Perfil, Id_Modulo, Accion_Ejecucion, Accion_Actual" & _
        "izacion, Accion_Eliminacion, Accion_Busqueda, Accion_Impresion, Accion_Opcion, M" & _
        "enu) VALUES (@Id_Perfil, @Id_Modulo, @Accion_Ejecucion, @Accion_Actualizacion, @" & _
        "Accion_Eliminacion, @Accion_Busqueda, @Accion_Impresion, @Accion_Opcion, @Menu);" & _
        " SELECT Id_Perfil, Id_Modulo, Accion_Ejecucion, Accion_Actualizacion, Accion_Eli" & _
        "minacion, Accion_Busqueda, Accion_Impresion, Accion_Opcion, Id_Modulo_Perfil, Me" & _
        "nu FROM Perfil_x_Modulo WHERE (Id_Modulo_Perfil = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Modulo", System.Data.SqlDbType.Int, 4, "Id_Modulo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Ejecucion", System.Data.SqlDbType.Bit, 1, "Accion_Ejecucion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Actualizacion", System.Data.SqlDbType.Bit, 1, "Accion_Actualizacion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Eliminacion", System.Data.SqlDbType.Bit, 1, "Accion_Eliminacion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Busqueda", System.Data.SqlDbType.Bit, 1, "Accion_Busqueda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Impresion", System.Data.SqlDbType.Bit, 1, "Accion_Impresion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Opcion", System.Data.SqlDbType.Bit, 1, "Accion_Opcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Menu", System.Data.SqlDbType.VarChar, 50, "Menu"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id_Perfil, Id_Modulo, Accion_Ejecucion, Accion_Actualizacion, Accion_Elimi" & _
        "nacion, Accion_Busqueda, Accion_Impresion, Accion_Opcion, Id_Modulo_Perfil, Menu" & _
        " FROM Perfil_x_Modulo"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Perfil_x_Modulo SET Id_Perfil = @Id_Perfil, Id_Modulo = @Id_Modulo, Accion" & _
        "_Ejecucion = @Accion_Ejecucion, Accion_Actualizacion = @Accion_Actualizacion, Ac" & _
        "cion_Eliminacion = @Accion_Eliminacion, Accion_Busqueda = @Accion_Busqueda, Acci" & _
        "on_Impresion = @Accion_Impresion, Accion_Opcion = @Accion_Opcion, Menu = @Menu W" & _
        "HERE (Id_Modulo_Perfil = @Original_Id_Modulo_Perfil) AND (Accion_Actualizacion =" & _
        " @Original_Accion_Actualizacion) AND (Accion_Busqueda = @Original_Accion_Busqued" & _
        "a) AND (Accion_Ejecucion = @Original_Accion_Ejecucion) AND (Accion_Eliminacion =" & _
        " @Original_Accion_Eliminacion) AND (Accion_Impresion = @Original_Accion_Impresio" & _
        "n) AND (Accion_Opcion = @Original_Accion_Opcion) AND (Id_Modulo = @Original_Id_M" & _
        "odulo) AND (Id_Perfil = @Original_Id_Perfil) AND (Menu = @Original_Menu); SELECT" & _
        " Id_Perfil, Id_Modulo, Accion_Ejecucion, Accion_Actualizacion, Accion_Eliminacio" & _
        "n, Accion_Busqueda, Accion_Impresion, Accion_Opcion, Id_Modulo_Perfil, Menu FROM" & _
        " Perfil_x_Modulo WHERE (Id_Modulo_Perfil = @Id_Modulo_Perfil)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Modulo", System.Data.SqlDbType.Int, 4, "Id_Modulo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Ejecucion", System.Data.SqlDbType.Bit, 1, "Accion_Ejecucion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Actualizacion", System.Data.SqlDbType.Bit, 1, "Accion_Actualizacion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Eliminacion", System.Data.SqlDbType.Bit, 1, "Accion_Eliminacion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Busqueda", System.Data.SqlDbType.Bit, 1, "Accion_Busqueda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Impresion", System.Data.SqlDbType.Bit, 1, "Accion_Impresion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion_Opcion", System.Data.SqlDbType.Bit, 1, "Accion_Opcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Menu", System.Data.SqlDbType.VarChar, 50, "Menu"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Modulo_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Modulo_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Actualizacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Actualizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Busqueda", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Busqueda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Ejecucion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Ejecucion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Eliminacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Eliminacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Impresion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Impresion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion_Opcion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion_Opcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Modulo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Menu", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Menu", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Modulo_Perfil", System.Data.SqlDbType.Int, 4, "Id_Modulo_Perfil"))
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(171, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 12)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Modulos no asignados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(393, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(414, 12)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Modulos asignados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdapterPerfilUsuario
        '
        Me.AdapterPerfilUsuario.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterPerfilUsuario.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterPerfilUsuario.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterPerfilUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Perfil_x_Usuario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Perfil", "Id_Perfil"), New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Id_PerUser", "Id_PerUser")})})
        Me.AdapterPerfilUsuario.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Perfil_x_Usuario WHERE (Id_PerUser = @Original_Id_PerUser) AND (Id_Pe" & _
        "rfil = @Original_Id_Perfil) AND (Id_Usuario = @Original_Id_Usuario)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PerUser", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PerUser", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Perfil_x_Usuario(Id_Perfil, Id_Usuario) VALUES (@Id_Perfil, @Id_Usuar" & _
        "io); SELECT Id_Perfil, Id_Usuario, Id_PerUser FROM Perfil_x_Usuario WHERE (Id_Pe" & _
        "rUser = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id_Perfil, Id_Usuario, Id_PerUser FROM Perfil_x_Usuario"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Perfil_x_Usuario SET Id_Perfil = @Id_Perfil, Id_Usuario = @Id_Usuario WHER" & _
        "E (Id_PerUser = @Original_Id_PerUser) AND (Id_Perfil = @Original_Id_Perfil) AND " & _
        "(Id_Usuario = @Original_Id_Usuario); SELECT Id_Perfil, Id_Usuario, Id_PerUser FR" & _
        "OM Perfil_x_Usuario WHERE (Id_PerUser = @Id_PerUser)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PerUser", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PerUser", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_PerUser", System.Data.SqlDbType.Int, 4, "Id_PerUser"))
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 348)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5, Me.StatusBarPanel6})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(827, 15)
        Me.StatusBar1.TabIndex = 102
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "EX : Ejecutar"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "UD : Actualizar"
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "DE : Eliminar"
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Text = "FI : Buscar"
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.Text = "PR : Imprimir"
        '
        'StatusBarPanel6
        '
        Me.StatusBarPanel6.Text = "OP : Opcional"
        '
        'AgregarPerfil
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(827, 363)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminarModulo)
        Me.Controls.Add(Me.btnAsignarModulo)
        Me.Controls.Add(Me.GridControlPerfilModulo)
        Me.Controls.Add(Me.GridControlModulos)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnAgregaPerfil)
        Me.Controls.Add(Me.txtNombrePerfil)
        Me.Controls.Add(Me.StatusBar1)
        Me.MaximizeBox = True
        Me.Name = "AgregarPerfil"
        Me.Text = "Crear Perfiles de Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.txtNombrePerfil, 0)
        Me.Controls.SetChildIndex(Me.btnAgregaPerfil, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControlModulos, 0)
        Me.Controls.SetChildIndex(Me.GridControlPerfilModulo, 0)
        Me.Controls.SetChildIndex(Me.btnAsignarModulo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminarModulo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPerfilUsuario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlModulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlPerfilModulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub AgregarPerfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Asigno la conexion
        Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad
        'Lleno el adaptador
        Me.AdapterPerfil.Fill(Me.DataSetPerfilUsuario1.Perfil)
        Me.AdapterModulos.Fill(Me.DataSetPerfilUsuario1.Modulos)
        Me.AdapterPerfilUsuario.Fill(Me.DataSetPerfilUsuario1.Perfil_x_Usuario)
        Me.AdapterPerfilModulo.Fill(Me.DataSetPerfilUsuario1.Perfil_x_Modulo)
        Me.ToolBar1.Buttons(4).Visible = False
        Me.ToolBar1.Buttons(3).Visible = False
        Me.ToolBar1.Buttons(2).Enabled = False
        binding()
        desactivaCampos()
    End Sub
    'Metodo que llena GridControlModulos con los datos necesarios estos son los modulo que pertenecen a Hotel o Pymes y que no estan 
    'asignados al perfil y que esta siendo seleccionado
    Private Sub CambioPosicion(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim Fx As cFunciones
            Dim X As Integer

            X = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")
            If CON = 0 Then
                Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad
                CON = 1
            End If
            Fx.Llenar_Tabla_Generico("SELECT Id_modulo, Modulo_Nombre_Interno, Modulo_Nombre,Software,Grupo FROM Modulos WHERE (NOT (Id_modulo IN  (SELECT Id_Modulo  FROM Perfil_x_Modulo  WHERE (Id_Perfil = " & X & ")  GROUP BY Id_Modulo)))AND (Software =" & strModulos & " OR software = 0 ) GROUP BY Grupo,Id_modulo,Modulo_Nombre_Interno,Modulo_Nombre,Software", Me.DataSetPerfilUsuario1.Modulos1, Me.SqlConnection1.ConnectionString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CambioPosicion2()
        Try
            Dim Fx As cFunciones
            Dim X As Integer

            X = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")
            If CON = 0 Then
                Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad
                CON = 1
            End If
            Fx.Llenar_Tabla_Generico("SELECT Id_modulo, Modulo_Nombre_Interno, Modulo_Nombre,Software FROM Modulos WHERE (NOT (Id_modulo IN  (SELECT Id_Modulo  FROM Perfil_x_Modulo  WHERE (Id_Perfil = " & X & ")  GROUP BY Id_Modulo)))AND (Software =" & strModulos & " OR software = 0 ) GROUP BY Grupo,Id_modulo,Modulo_Nombre_Interno,Modulo_Nombre,Software", Me.DataSetPerfilUsuario1.Modulos1, Me.SqlConnection1.ConnectionString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

#Region "Funciones Varias"

    Private Sub ActivaCampos()

        txtNombrePerfil.Enabled = True
        btnAgregaPerfil.Enabled = True
        GridControl1.Enabled = True
        GridControlModulos.Enabled = True
        GridControlPerfilModulo.Enabled = True
        GridControl1.Enabled = True
        btnAsignarModulo.Enabled = True
        btnEliminarModulo.Enabled = True


    End Sub

    Private Sub desactivaCampos()

        txtNombrePerfil.Enabled = False
        btnAgregaPerfil.Enabled = False
        GridControlModulos.Enabled = False
        GridControlPerfilModulo.Enabled = False
        GridControl1.Enabled = False
        btnAsignarModulo.Enabled = False
        btnEliminarModulo.Enabled = False
        DataNavigator.Enabled = True

    End Sub

    Function binding()

        Me.txtNombrePerfil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetPerfilUsuario1, "Perfil.Nombre_Perfil"))

    End Function

    Function Editar()
        Try
            If Me.ToolBarBuscar.Text = "Editar" Then

                Me.ToolBarBuscar.Text = "Cancel"
                Me.ToolBarBuscar.ImageIndex = 4
                Me.ToolBarNuevo.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                ActivaCampos()
                txtNombrePerfil.Focus()
                DataNavigator.Enabled = False

            Else

                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").CancelCurrentEdit()
                Me.ToolBarBuscar.Text = "Editar"
                Me.ToolBarBuscar.ImageIndex = 9
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.desactivaCampos()
                DataNavigator.Enabled = True

            End If

        Catch ex As Exception
            Dim mesg As String = "Problemas al Editar un Usuario." & vbCrLf & _
                                 "Intente Iniciar el formulario Otra vez, " & vbCrLf & _
                                 "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf & _
                                 "'" & ex.Message & "'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
        End Try
    End Function

#End Region

    Function Nuevo()
        Try

            If Me.ToolBarNuevo.Text = "Nuevo" Then

                Me.ToolBarNuevo.Text = "Cancel"
                Me.ToolBarNuevo.ImageIndex = 4
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True

                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").AddNew()
                ActivaCampos()
                txtNombrePerfil.Focus()
                DataNavigator.Enabled = False

            Else

                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False

                desactivaCampos()
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").CancelCurrentEdit()
                DataNavigator.Enabled = True

            End If
        Catch ex As Exception
            Dim mesg As String = "Problemas al hacer un Usuario Nuevo." & vbCrLf & _
                                 "Intente Iniciar el formulario Otra vez, " & vbCrLf & _
                                 "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf & _
                                 "'" & ex.Message & "'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
        End Try
    End Function
    Function Registra()
        Try

            'Se evalua si hay algun nombre de perfil en el text
            If txtNombrePerfil.Text <> "" Then

                'GridControlPerfilModulo()

                '' Me muevo en el dataset para actualizar los datos en él 
                'If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position = 0 Then
                '    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1

                'Else
                '    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1
                '    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position += 1

                'End If


                Me.GridControl1.Focus()
                ''Agrego los datos al origenes de datos remotos
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()

                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").AddNew()
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").CancelCurrentEdit()

                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Modulos1").EndCurrentEdit()

                Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo")
                Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1, "Perfil")
                Me.AdapterModulos.Update(Me.DataSetPerfilUsuario1, "Modulos1")

                ' Me.DataSetPerfilUsuario1.AcceptChanges()


                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarBuscar.Text = "Editar"
                Me.ToolBarBuscar.ImageIndex = 9
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarEliminar.Enabled = True
                desactivaCampos()
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)


            End If
        Catch ex As SystemException
            Dim mesg As String = "Problemas al Registrar un Usuario." & vbCrLf & _
                                 "Intente Iniciar el formulario Otra vez, " & vbCrLf & _
                                 "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf & _
                                 "'" & ex.Message & "'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
        End Try

    End Function
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Me.Nuevo()

            Case 1 : Me.Editar()

            Case 2 : If PMU.Update Or usua.cedula = "" Then Me.Registra() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Delete Or usua.cedula = "" Then Me.EliminarDatos(Me.AdapterPerfil, Me.DataSetPerfilUsuario1, Me.DataSetPerfilUsuario1.Perfil.TableName) Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub



            Case 6
                If MessageBox.Show("¿Desea Cerrar el Módulo de Usuario?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Close()
                End If

        End Select
    End Sub
    Private Sub btnAgregaPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaPerfil.Click
        subAgregarPerfil()
        Me.txtNombrePerfil.Focus()
    End Sub

    Private Sub txtNombrePerfil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombrePerfil.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnAgregaPerfil.Focus()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarModulo.Click
        'LE ASIGNA UN MODULO A UN DETERMINADO PERFIL
        subAgregarModulo()
    End Sub

    Private Sub btnEliminarModulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarModulo.Click
        eliminaModulo()
    End Sub
    Private Sub GridControlPerfilModulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControlPerfilModulo.KeyDown
        If e.KeyCode = Keys.Delete Then
            eliminaModulo()
        End If
    End Sub
    Private Sub GridControlModulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControlModulos.DoubleClick
        'Agrega un modulo a un perfil
        subAgregarModulo()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            subElimaPerfil()
        End If
    End Sub

#Region "Metodos"

    Private Sub subAgregarPerfil()
        Try
            Dim strperfi As String = Me.txtNombrePerfil.Text
            'Agrego los datos al gridControl
            Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").CancelCurrentEdit()
            Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").AddNew()
            Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Nombre_Perfil") = strperfi
            Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Metodo que eliminara un perfil del gridControl
    Sub subElimaPerfil()
        Dim prow As String
        Dim resp As Integer
        Dim id, Pxc, J As Integer

        Try
            If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").Count >= 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este modulo a este perfil?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then

                    'Metodo que eliminara los modulos asignados a un perfil
                    id = Me.BindingContext(DataSetPerfilUsuario1, "Perfil").Position

                    'Busco para ver si existen usuarios con este perfil
                    For J = 0 To Me.DataSetPerfilUsuario1.Perfil_x_Usuario.Rows.Count - 1

                        If Me.DataSetPerfilUsuario1.Perfil_x_Usuario.Rows(J).Item("Id_Perfil") = Me.DataSetPerfilUsuario1.Perfil.Rows(id).Item("Id_Perfil") Then

                            'Si hay algun usuario con este perfil asignado no se podra eliminar el perfil
                            MsgBox("Perfil asignado a usuarios no se puede eliminar", MsgBoxStyle.Information)

                            Exit Sub
                        End If
                    Next

                    'Eliminara los modulos asignados
                    subEliminaModulosAsignados()

                    'Elimino los datos del perfil
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").RemoveAt(Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position)
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()

                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").EndCurrentEdit()
                    Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1.Perfil_x_Modulo)

                    'Agrego los datos al origenes de datos remotos
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
                    Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1.Perfil)

                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Modulos1").EndCurrentEdit()
                    Me.AdapterModulos.Update(Me.DataSetPerfilUsuario1.Modulos1)


                Else
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Modulos Asignados para Eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Metodo que eliminara los modulos asignados a un perfil
    Sub subEliminaModulosAsignados()

        Dim pRow As DataRow
        Dim strIdPerfil As String = ""
        strIdPerfil = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")

        'Busco los modulos asignados a cada perfil y los elimino
        For Each pRow In DataSetPerfilUsuario1.Tables("Perfil_x_Modulo").Rows

            If pRow("Id_Perfil") = strIdPerfil Then
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").RemoveAt(Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").Position)

            End If

        Next


    End Sub
    'Elimino un modulo asignado a un perfil
    Sub eliminaModulo()
        Dim resp As Integer
        Dim id As Integer
        Try
            If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este modulo a este perfil?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    'Me.BindingContext(Me.DataSetPerfilUsuario1.Perfil_x_Modulo"Perfil.PerfilPerfil_x_Modulo"
                    Dim del As Integer = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Position
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").RemoveAt(del)
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()

                    'Me muevo en el dataset para actualizar los datos en él 
                    If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position = 0 Then
                        Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1
                    Else
                        Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position += 1
                        Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1
                    End If

                    'Agrego los datos al origenes de datos remotos
                    'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
                    'Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1.Perfil)

                    'Me.BindingContext(Me.DataSetPerfilUsuario1, "Modulos1").EndCurrentEdit()
                    'Me.AdapterModulos.Update(Me.DataSetPerfilUsuario1.Modulos1)

                    'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").EndCurrentEdit()
                    'Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1.Perfil_x_Modulo)

                    'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo")

                Else
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").CancelCurrentEdit()

                End If

            Else
                MsgBox("No Existen Modulos Asignados para Eliminar", MsgBoxStyle.Information)

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub subAgregarModulo()
        Try
            Dim resp As Integer
            resp = MessageBox.Show("¿Desea agregar este modulo a este perfil?", "Configuraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Dim IP As String = ""
                Dim IM As String = ""
                Dim strMenu As String = ""
                Dim prow As DataRow

                'Variables que almacenaran el  ID del perfil actual y del modulo actual para asignarlos en la 
                'tabla Perfil_x_Modulo
                IP = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")

                'Evaluo si hay datos en el GridControlModulos 
                If Me.BindingContext(Me.DataSetPerfilUsuario1, "Modulos1").Position = -1 Then
                    MessageBox.Show("No hay datos suficientes para realizar esta operacion")
                    btnEliminarModulo.Enabled = False
                    Exit Sub
                Else
                    btnEliminarModulo.Enabled = True
                End If



                IM = Me.BindingContext(Me.DataSetPerfilUsuario1, "Modulos1").Current("Id_Modulo")
                For Each prow In Me.DataSetPerfilUsuario1.Tables("ModuloS").Rows
                    If prow("Id_Modulo") = IM Then
                        strMenu = IIf(IsDBNull(prow("Grupo")), "NULL", prow("Grupo"))
                        Exit For
                    End If
                Next



                'carga los datos en el gridControl
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").AddNew()
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Id_Modulo") = IM
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Id_Perfil") = IP
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Ejecucion") = False
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Actualizacion") = False
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Eliminacion") = False
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Busqueda") = False
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Impresion") = False
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Opcion") = False
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Menu") = strMenu
                Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()

                'Agrego los datos al origenes de datos remotos(Base de Datos)
                Me.BindingContext(Me.DataSetPerfilUsuario1.Perfil).EndCurrentEdit()
                Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1.Perfil)

                Me.BindingContext(Me.DataSetPerfilUsuario1.Perfil_x_Modulo).EndCurrentEdit()
                Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1.Perfil_x_Modulo)

                Me.BindingContext(Me.DataSetPerfilUsuario1.Modulos1).EndCurrentEdit()
                Me.AdapterModulos.Update(Me.DataSetPerfilUsuario1.Modulos1)

                'Me muevo en el dataset para actualizar los datos en él 
                If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position = 0 Then
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1

                Else
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position += 1

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Buscara si un perfil esta asignado a un usuario
    Function buscaPerfilUsuario() As String

        Dim id As Integer
        id = Me.BindingContext(DataSetPerfilUsuario1, "Perfil").Position

        If Me.DataSetPerfilUsuario1.Perfil_x_Usuario.FindById_PerUser(Me.DataSetPerfilUsuario1.Perfil.Rows(id).Item("Id_Perfil")).Id_Perfil = "" Then

        End If

        Dim prow As DataRow
        For Each prow In DataSetPerfilUsuario1.Tables("Perfil_x_Usuario").Rows

            If prow("Id_Perfil") = Me.BindingContext(DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil") Then
                Return "No"
                Exit Function
            End If

        Next

    End Function

#End Region

    Private Sub GridControlModulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControlModulos.KeyDown
        If e.KeyCode = Keys.F1 Then
            buscarModulo()
        End If
    End Sub
    Private Sub buscarModulo()
        Try

            Dim strId_Modulo As String
            Dim strId_Perfil As String
            Dim funcion As New cFunciones
            Dim x As Integer
            Dim strMenu As String = ""
            x = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")
            '"SELECT Id_modulo, Modulo_Nombre_Interno, Modulo_Nombre,Software FROM Modulos WHERE (NOT (Id_modulo IN  (SELECT Id_Modulo  FROM Perfil_x_Modulo  WHERE (Id_Perfil = " & X & ")  GROUP BY Id_Modulo)))AND (Software =" & strModulos & " OR software = 0 )"
            strId_Modulo = funcion.BuscarDatos("SELECT Id_Modulo,Modulo_Nombre FROM Modulos", "(NOT (Id_modulo IN  (SELECT Id_Modulo  FROM Perfil_x_Modulo  WHERE (Id_Perfil = " & x & "))))AND (Software =" & strModulos & " OR software = 0 ) AND Modulo_Nombre", "Buscar Modulo ...", Me.SqlConnection1.ConnectionString)
            'strId_Modulo = funcion.BuscarDatos("SELECT Id_Modulo,Modulo_Nombre FROM Modulos", "Modulo_Nombre", "Buscar Modulo ...", Me.SqlConnection1.ConnectionString)
            If strId_Modulo <> "" And strId_Modulo <> "0" Then

                Dim resp As Integer
                resp = MessageBox.Show("¿Desea agregar este modulo a este perfil?", "Configuraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then


                    strId_Perfil = Me.BindingContext(DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")
                    '--------------------------------------------------------------------------
                    'EVALUO SI EL MODULO YA SE ENCUENTRA ASIGNADO AL PERFIL RESPECTIVO
                    Dim prow As DataRow
                    If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").Count > 0 Then

                        For Each prow In Me.DataSetPerfilUsuario1.Tables("Perfil_x_Modulo").Rows
                            If prow("Id_Perfil") <> strId_Perfil Or prow("Id_Modulo") <> strId_Modulo Then
                            Else
                                MsgBox("Este modulo ya esta asignado a este perfil", MsgBoxStyle.Critical, "Mensaje....")
                                Exit Sub
                            End If
                        Next

                    End If
                    '--------------------------------------------------------------------------

                    ' Dim prow As DataRow
                    For Each prow In Me.DataSetPerfilUsuario1.Tables("ModuloS").Rows
                        If prow("Id_Modulo") = strId_Modulo Then

                            If prow("Software") = strModulos Or prow("Software") = "0" Then
                                Exit For
                            Else
                                MsgBox("Este modulo no corresponde a su sistema", MsgBoxStyle.Critical, "Mensaje....")
                                Exit Sub
                            End If

                        End If
                    Next

                    For Each prow In Me.DataSetPerfilUsuario1.Tables("ModuloS").Rows
                        If prow("Id_Modulo") = strId_Modulo Then
                            strMenu = IIf(IsDBNull(prow("Grupo")), "NULL", prow("Grupo"))
                            Exit For
                        End If
                    Next

                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").AddNew()
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Id_Modulo") = strId_Modulo
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Id_Perfil") = strId_Perfil
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Ejecucion") = False
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Actualizacion") = False
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Eliminacion") = False
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Busqueda") = False
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Impresion") = False
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Accion_Opcion") = False
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").Current("Menu") = strMenu
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()


                    'Agrego los datos al origenes de datos remotos
                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
                    Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1.Perfil)

                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo").EndCurrentEdit()
                    Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1.Perfil_x_Modulo)

                    Me.BindingContext(Me.DataSetPerfilUsuario1, "Modulos1").EndCurrentEdit()
                    Me.AdapterModulos.Update(Me.DataSetPerfilUsuario1.Modulos1)

                    'Me muevo en el dataset para actualizar los datos en él 
                    If Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position = 0 Then
                        Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1

                    Else
                        Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position -= 1
                        Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position += 1

                    End If

                    CambioPosicion2()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class
