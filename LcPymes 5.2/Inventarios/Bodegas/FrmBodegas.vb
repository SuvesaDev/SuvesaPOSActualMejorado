Imports System.Windows.Forms

Public Class FrmBodegas
    Inherits FrmPlantilla   'System.Windows.Forms.Form
    Dim Usua As Object
    Friend WithEvents ckInactiva As System.Windows.Forms.CheckBox
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapterBodegas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetBodegas As DataSetBodegas
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciaBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlDataAdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ComboBoxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapterInventario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label_Id As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBodegas))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataSetBodegas = New LcPymes_5._2.DataSetBodegas()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciaBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapterBodegas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ComboBoxMoneda = New System.Windows.Forms.ComboBox()
        Me.SqlDataAdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SqlDataAdapterInventario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Label_Id = New System.Windows.Forms.Label()
        Me.ckInactiva = New System.Windows.Forms.CheckBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 372)
        Me.ToolBar1.Size = New System.Drawing.Size(586, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.DataMember = "Bodegas"
        Me.DataNavigator.DataSource = Me.DataSetBodegas
        Me.DataNavigator.Location = New System.Drawing.Point(448, 401)
        '
        'TituloModulo
        '
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.TituloModulo.Size = New System.Drawing.Size(586, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Bodegas"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Bodegas.BodegasInventario"
        Me.GridControl1.DataSource = Me.DataSetBodegas
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridControl1.Location = New System.Drawing.Point(8, 165)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(576, 203)
        Me.GridControl1.TabIndex = 3
        '
        'DataSetBodegas
        '
        Me.DataSetBodegas.DataSetName = "DataSetBodegas"
        Me.DataSetBodegas.Locale = New System.Globalization.CultureInfo("es")
        Me.DataSetBodegas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colExistenciaBodega})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Cod_Articulo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 73
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 356
        '
        'colExistenciaBodega
        '
        Me.colExistenciaBodega.Caption = "Existencia"
        Me.colExistenciaBodega.FieldName = "ExistenciaBodega"
        Me.colExistenciaBodega.FilterInfo = ColumnFilterInfo3
        Me.colExistenciaBodega.Name = "colExistenciaBodega"
        Me.colExistenciaBodega.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExistenciaBodega.VisibleIndex = 2
        Me.colExistenciaBodega.Width = 101
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetBodegas, "Bodegas.Nombre_Bodega", True))
        Me.TextBoxBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(10, 56)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(574, 13)
        Me.TextBoxBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Nombre de la Casa consignante o Bodega"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetBodegas, "Bodegas.Observaciones", True))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(8, 93)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(574, 49)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(8, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(574, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Observaciones"
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=SeePOS;Integrated Security=True"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapterBodegas
        '
        Me.SqlDataAdapterBodegas.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapterBodegas.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapterBodegas.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapterBodegas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bodegas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Bodega", "ID_Bodega"), New System.Data.Common.DataColumnMapping("Nombre_Bodega", "Nombre_Bodega"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.SqlDataAdapterBodegas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Bodegas WHERE (ID_Bodega = @Original_ID_Bodega)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Bodega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Bodega", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ID_Bodega", System.Data.SqlDbType.Int, 4, "ID_Bodega"), New System.Data.SqlClient.SqlParameter("@Nombre_Bodega", System.Data.SqlDbType.VarChar, 100, "Nombre_Bodega"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Inactiva", System.Data.SqlDbType.Bit, 1, "Inactiva")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID_Bodega, Nombre_Bodega, Observaciones, Inactiva FROM Bodegas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ID_Bodega", System.Data.SqlDbType.Int, 4, "ID_Bodega"), New System.Data.SqlClient.SqlParameter("@Nombre_Bodega", System.Data.SqlDbType.VarChar, 100, "Nombre_Bodega"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Inactiva", System.Data.SqlDbType.Bit, 1, "Inactiva"), New System.Data.SqlClient.SqlParameter("@Original_ID_Bodega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Bodega", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ComboBoxMoneda
        '
        Me.ComboBoxMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxMoneda.DataSource = Me.DataSetBodegas
        Me.ComboBoxMoneda.DisplayMember = "Moneda.Simbolo"
        Me.ComboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMoneda.Location = New System.Drawing.Point(532, 377)
        Me.ComboBoxMoneda.Name = "ComboBoxMoneda"
        Me.ComboBoxMoneda.Size = New System.Drawing.Size(48, 21)
        Me.ComboBoxMoneda.TabIndex = 94
        '
        'SqlDataAdapterMoneda
        '
        Me.SqlDataAdapterMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapterMoneda.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(CodMoneda, ValorCompra, Simbolo) VALUES (@CodMoneda, @ValorCom" & _
    "pra, @Simbolo); SELECT CodMoneda, ValorCompra, Simbolo FROM Moneda"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, ValorCompra, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(448, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Moneda"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlDataAdapterInventario
        '
        Me.SqlDataAdapterInventario.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapterInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Id_Bodega", "Id_Bodega"), New System.Data.Common.DataColumnMapping("ExistenciaBodega", "ExistenciaBodega"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'Label_Id
        '
        Me.Label_Id.BackColor = System.Drawing.Color.White
        Me.Label_Id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetBodegas, "Bodegas.ID_Bodega", True))
        Me.Label_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Id.ForeColor = System.Drawing.Color.Blue
        Me.Label_Id.Location = New System.Drawing.Point(16, 16)
        Me.Label_Id.Name = "Label_Id"
        Me.Label_Id.Size = New System.Drawing.Size(155, 11)
        Me.Label_Id.TabIndex = 96
        Me.Label_Id.Text = "0000"
        Me.Label_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ckInactiva
        '
        Me.ckInactiva.AutoSize = True
        Me.ckInactiva.BackColor = System.Drawing.Color.Transparent
        Me.ckInactiva.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetBodegas, "Bodegas.Inactiva", True))
        Me.ckInactiva.Location = New System.Drawing.Point(10, 146)
        Me.ckInactiva.Name = "ckInactiva"
        Me.ckInactiva.Size = New System.Drawing.Size(104, 17)
        Me.ckInactiva.TabIndex = 97
        Me.ckInactiva.Text = "Bodega Inactiva"
        Me.ckInactiva.UseVisualStyleBackColor = False
        '
        'FrmBodegas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(586, 424)
        Me.Controls.Add(Me.ckInactiva)
        Me.Controls.Add(Me.Label_Id)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxMoneda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = True
        Me.Name = "FrmBodegas"
        Me.Text = "Bodegas"
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxMoneda, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBoxBuscar, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label_Id, 0)
        Me.Controls.SetChildIndex(Me.ckInactiva, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Load"
    Private Sub FrmBodegas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DataSetBodegas.Inventario.Cod_ArticuloColumn.DefaultValue = 0
            SqlConnection.ConnectionString = CadenaConexionSeePOS
            Dim X As Double
            Consecutivo()
            X = Me.SqlDataAdapterMoneda.Fill(Me.DataSetBodegas, "Moneda")
            X = Me.SqlDataAdapterBodegas.Fill(Me.DataSetBodegas, "Bodegas")
            If X <> 0 Then Me.SqlDataAdapterInventario.Fill(Me.DataSetBodegas, "Inventario")
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            'da error y recclaman
        End Try        
    End Sub
#End Region

#Region "Toobar"

    Private Function TieneRelacionados(_IdBodega As String) As Boolean
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select * from Inventario i where i.id_bodega = " & _IdBodega, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0 : NuevaEntrada()
                Case 2
                    If PMU.Update Then
                        If Me.ckInactiva.Checked = True Then
                            If Me.TieneRelacionados(Me.BindingContext(Me.DataSetBodegas, "Bodegas").Current("ID_Bodega")) = True Then
                                MsgBox("La bodega tiene productos relaccionados", MsgBoxStyle.Exclamation, "No se puede Inactivar la bodega")
                                Exit Sub
                            End If
                        End If
                        Me.RegistrarDatos(Me.SqlDataAdapterBodegas, Me.DataSetBodegas, Me.DataSetBodegas.Bodegas.ToString, True)
                        If MsgBox("Desea agregar una nueva bodega...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then NuevaEntrada()
                    Else
                        MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 3
                    If Me.GridView1.DataRowCount > 0 Then
                        MsgBox("No se puede eliminar la bodega ya que tiene articulos asignados...", MsgBoxStyle.Critical, "Atención...")
                    Else
                        If PMU.Delete Then Me.EliminarDatos(Me.SqlDataAdapterBodegas, Me.DataSetBodegas, Me.DataSetBodegas.Bodegas.ToString) Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 4
                    Try
                        If PMU.Print Then
                            Dim ReporteExistenciaBodega As New Reporte_Bodegas_Consignada
                            ReporteExistenciaBodega.SetParameterValue(0, Me.BindingContext(Me.DataSetBodegas, "Moneda").Current("ValorCompra"))
                            ReporteExistenciaBodega.SetParameterValue(1, Me.BindingContext(Me.DataSetBodegas, "Bodegas").Current("ID_Bodega"))
                            CrystalReportsConexion.LoadShow(ReporteExistenciaBodega, MdiParent)
                        Else
                            MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "")
                    End Try
                Case 6 : Me.Cerrar()
            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Nuevo"
    Private Sub NuevaEntrada()
        Me.NuevosDatos(Me.DataSetBodegas, Me.DataSetBodegas.Bodegas.ToString)
        If ToolBar1.Buttons(0).Text = "Cancelar" Then Consecutivo()
    End Sub

    Private Function Consecutivo() As Integer
        Dim ConexionX As New Conexion
        Me.Label_Id.Text = ConexionX.SlqExecuteScalar(ConexionX.Conectar, "SELECT isnull(MAX(ID_Bodega + 1),1) AS Ident FROM Bodegas")
    End Function
#End Region

#Region "Funciones Controles"
    Private Sub TextBoxBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Focus()
        End If
    End Sub
#End Region

End Class
