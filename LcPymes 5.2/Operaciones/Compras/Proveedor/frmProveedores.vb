Imports CrystalDecisions.CrystalReports.Engine
Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class frmProveedores
    Inherits System.Windows.Forms.Form
    Dim NuevaConexion As String
    Public CConexion1 As New Conexion
    Friend WithEvents ckActualizado As System.Windows.Forms.CheckBox
    Friend WithEvents ckInhabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents ckSerie As System.Windows.Forms.CheckBox
    Friend WithEvents ckSeguimiento As System.Windows.Forms.CheckBox
    Dim usua As Usuario_Logeado


#Region " Windows Form Designer generated code "
    'ByVal Usuario_Parametro As Object,
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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents vtxtVisitas As ValidText.ValidText
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents vtxtTelefonoCont As ValidText.ValidText
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Tex_consul As System.Windows.Forms.TextBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colTipoCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNum_Cuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonedaNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daProveedores As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_Proveedores1 As DataSet_Proveedores
    Friend WithEvents da_cuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Monedas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents da_num_prov As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ValidText1 As ValidText.ValidText
    Friend WithEvents ValidText3 As ValidText.ValidText
    Friend WithEvents vtxtCedula As ValidText.ValidText
    Friend WithEvents ValidText10 As ValidText.ValidText
    Friend WithEvents ValidText4 As ValidText.ValidText
    Friend WithEvents ValidText5 As ValidText.ValidText
    Friend WithEvents txtCodigo As ValidText.ValidText
    Friend WithEvents ValidText6 As ValidText.ValidText
    Friend WithEvents vtxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents vtxtplazo As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ValidText2 As ValidText.ValidText
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Tex_nom_moneda_prov As System.Windows.Forms.TextBox
    Friend WithEvents Tex_cod_moneda As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChecImpIncluido As System.Windows.Forms.CheckBox
    Friend WithEvents ChecCosto As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextoMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents ColProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtUtilidadFija As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckSerie = New System.Windows.Forms.CheckBox()
        Me.ckInhabilitado = New System.Windows.Forms.CheckBox()
        Me.ckActualizado = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataSet_Proveedores1 = New LcPymes_5._2.DataSet_Proveedores()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ValidText2 = New ValidText.ValidText()
        Me.ValidText6 = New ValidText.ValidText()
        Me.ValidText5 = New ValidText.ValidText()
        Me.ValidText4 = New ValidText.ValidText()
        Me.ValidText10 = New ValidText.ValidText()
        Me.vtxtCedula = New ValidText.ValidText()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vtxtVisitas = New ValidText.ValidText()
        Me.vtxtTelefonoCont = New ValidText.ValidText()
        Me.ValidText3 = New ValidText.ValidText()
        Me.ValidText1 = New ValidText.ValidText()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.vtxtMonto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.vtxtplazo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtUtilidadFija = New System.Windows.Forms.TextBox()
        Me.ChecCosto = New System.Windows.Forms.CheckBox()
        Me.ChecImpIncluido = New System.Windows.Forms.CheckBox()
        Me.Tex_consul = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextoMenu = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNum_Cuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonedaNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tex_cod_moneda = New System.Windows.Forms.TextBox()
        Me.Tex_nom_moneda_prov = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New ValidText.ValidText()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.daProveedores = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.da_cuentas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Monedas = New System.Data.SqlClient.SqlDataAdapter()
        Me.da_num_prov = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ckSeguimiento = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet_Proveedores1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formulario de Proveedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ckSeguimiento)
        Me.Panel1.Controls.Add(Me.ckSerie)
        Me.Panel1.Controls.Add(Me.ckInhabilitado)
        Me.Panel1.Controls.Add(Me.ckActualizado)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.ValidText2)
        Me.Panel1.Controls.Add(Me.ValidText6)
        Me.Panel1.Controls.Add(Me.ValidText5)
        Me.Panel1.Controls.Add(Me.ValidText4)
        Me.Panel1.Controls.Add(Me.ValidText10)
        Me.Panel1.Controls.Add(Me.vtxtCedula)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.vtxtVisitas)
        Me.Panel1.Controls.Add(Me.vtxtTelefonoCont)
        Me.Panel1.Controls.Add(Me.ValidText3)
        Me.Panel1.Controls.Add(Me.ValidText1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.vtxtMonto)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.vtxtplazo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtUtilidadFija)
        Me.Panel1.Controls.Add(Me.ChecCosto)
        Me.Panel1.Controls.Add(Me.ChecImpIncluido)
        Me.Panel1.Controls.Add(Me.Tex_consul)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 176)
        Me.Panel1.TabIndex = 1
        '
        'ckSerie
        '
        Me.ckSerie.AutoSize = True
        Me.ckSerie.Location = New System.Drawing.Point(480, 39)
        Me.ckSerie.Name = "ckSerie"
        Me.ckSerie.Size = New System.Drawing.Size(147, 17)
        Me.ckSerie.TabIndex = 158
        Me.ckSerie.Text = "Productos con Series"
        Me.ckSerie.UseVisualStyleBackColor = True
        '
        'ckInhabilitado
        '
        Me.ckInhabilitado.AutoSize = True
        Me.ckInhabilitado.Location = New System.Drawing.Point(573, 156)
        Me.ckInhabilitado.Name = "ckInhabilitado"
        Me.ckInhabilitado.Size = New System.Drawing.Size(82, 17)
        Me.ckInhabilitado.TabIndex = 157
        Me.ckInhabilitado.Text = "Inhabilitar"
        Me.ckInhabilitado.UseVisualStyleBackColor = True
        '
        'ckActualizado
        '
        Me.ckActualizado.AutoSize = True
        Me.ckActualizado.Location = New System.Drawing.Point(480, 156)
        Me.ckActualizado.Name = "ckActualizado"
        Me.ckActualizado.Size = New System.Drawing.Size(92, 17)
        Me.ckActualizado.TabIndex = 156
        Me.ckActualizado.Text = "Actualizado"
        Me.ckActualizado.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.DescripcionCuentaContable", True))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(128, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(296, 16)
        Me.Label15.TabIndex = 155
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet_Proveedores1
        '
        Me.DataSet_Proveedores1.DataSetName = "DataSet_Proveedores"
        Me.DataSet_Proveedores1.Locale = New System.Globalization.CultureInfo("es")
        Me.DataSet_Proveedores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.CuentaContable", True))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(16, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 13)
        Me.TextBox1.TabIndex = 19
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Proveedores1, "Proveedores.Utilidad_Fija", True))
        Me.CheckBox1.Location = New System.Drawing.Point(480, 122)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 16)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Utilidad Fija"
        '
        'ValidText2
        '
        Me.ValidText2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValidText2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Nombre", True))
        Me.ValidText2.FieldReference = Nothing
        Me.ValidText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidText2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText2.Location = New System.Drawing.Point(96, 8)
        Me.ValidText2.MaskEdit = ""
        Me.ValidText2.Name = "ValidText2"
        Me.ValidText2.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText2.Required = False
        Me.ValidText2.ShowErrorIcon = False
        Me.ValidText2.Size = New System.Drawing.Size(368, 13)
        Me.ValidText2.TabIndex = 1
        Me.ValidText2.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText2.ValidText = Nothing
        '
        'ValidText6
        '
        Me.ValidText6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Fax2", True))
        Me.ValidText6.FieldReference = Nothing
        Me.ValidText6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText6.Location = New System.Drawing.Point(400, 24)
        Me.ValidText6.MaskEdit = ""
        Me.ValidText6.Name = "ValidText6"
        Me.ValidText6.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText6.Required = False
        Me.ValidText6.ShowErrorIcon = False
        Me.ValidText6.Size = New System.Drawing.Size(64, 13)
        Me.ValidText6.TabIndex = 6
        Me.ValidText6.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText6.ValidText = Nothing
        '
        'ValidText5
        '
        Me.ValidText5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Fax1", True))
        Me.ValidText5.FieldReference = Nothing
        Me.ValidText5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText5.Location = New System.Drawing.Point(328, 24)
        Me.ValidText5.MaskEdit = ""
        Me.ValidText5.Name = "ValidText5"
        Me.ValidText5.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText5.Required = False
        Me.ValidText5.ShowErrorIcon = False
        Me.ValidText5.Size = New System.Drawing.Size(64, 13)
        Me.ValidText5.TabIndex = 5
        Me.ValidText5.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText5.ValidText = Nothing
        '
        'ValidText4
        '
        Me.ValidText4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Telefono2", True))
        Me.ValidText4.FieldReference = Nothing
        Me.ValidText4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText4.Location = New System.Drawing.Point(168, 24)
        Me.ValidText4.MaskEdit = ""
        Me.ValidText4.Name = "ValidText4"
        Me.ValidText4.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText4.Required = False
        Me.ValidText4.ShowErrorIcon = False
        Me.ValidText4.Size = New System.Drawing.Size(64, 13)
        Me.ValidText4.TabIndex = 4
        Me.ValidText4.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText4.ValidText = Nothing
        '
        'ValidText10
        '
        Me.ValidText10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Telefono1", True))
        Me.ValidText10.FieldReference = Nothing
        Me.ValidText10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText10.Location = New System.Drawing.Point(96, 24)
        Me.ValidText10.MaskEdit = ""
        Me.ValidText10.Name = "ValidText10"
        Me.ValidText10.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText10.Required = False
        Me.ValidText10.ShowErrorIcon = False
        Me.ValidText10.Size = New System.Drawing.Size(64, 13)
        Me.ValidText10.TabIndex = 3
        Me.ValidText10.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText10.ValidText = Nothing
        '
        'vtxtCedula
        '
        Me.vtxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vtxtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Cedula", True))
        Me.vtxtCedula.FieldReference = Nothing
        Me.vtxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vtxtCedula.ForeColor = System.Drawing.Color.RoyalBlue
        Me.vtxtCedula.Location = New System.Drawing.Point(568, 8)
        Me.vtxtCedula.MaskEdit = ""
        Me.vtxtCedula.Name = "vtxtCedula"
        Me.vtxtCedula.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.vtxtCedula.Required = False
        Me.vtxtCedula.ShowErrorIcon = True
        Me.vtxtCedula.Size = New System.Drawing.Size(112, 13)
        Me.vtxtCedula.TabIndex = 2
        Me.vtxtCedula.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.vtxtCedula.ValidText = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(480, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Visitas al Mes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(240, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Fax(s)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Teléfono(s)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(480, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Teléfono"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Contacto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(7, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(480, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Cédula"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vtxtVisitas
        '
        Me.vtxtVisitas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vtxtVisitas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.PedidosMes", True))
        Me.vtxtVisitas.FieldReference = Nothing
        Me.vtxtVisitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vtxtVisitas.ForeColor = System.Drawing.Color.RoyalBlue
        Me.vtxtVisitas.Location = New System.Drawing.Point(568, 24)
        Me.vtxtVisitas.MaskEdit = ""
        Me.vtxtVisitas.Name = "vtxtVisitas"
        Me.vtxtVisitas.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.vtxtVisitas.Required = False
        Me.vtxtVisitas.ShowErrorIcon = True
        Me.vtxtVisitas.Size = New System.Drawing.Size(112, 13)
        Me.vtxtVisitas.TabIndex = 7
        Me.vtxtVisitas.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.vtxtVisitas.ValidText = Nothing
        '
        'vtxtTelefonoCont
        '
        Me.vtxtTelefonoCont.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vtxtTelefonoCont.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Telefono_Cont", True))
        Me.vtxtTelefonoCont.FieldReference = Nothing
        Me.vtxtTelefonoCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vtxtTelefonoCont.ForeColor = System.Drawing.Color.RoyalBlue
        Me.vtxtTelefonoCont.Location = New System.Drawing.Point(568, 88)
        Me.vtxtTelefonoCont.MaskEdit = ""
        Me.vtxtTelefonoCont.Name = "vtxtTelefonoCont"
        Me.vtxtTelefonoCont.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.vtxtTelefonoCont.Required = False
        Me.vtxtTelefonoCont.ShowErrorIcon = True
        Me.vtxtTelefonoCont.Size = New System.Drawing.Size(112, 13)
        Me.vtxtTelefonoCont.TabIndex = 12
        Me.vtxtTelefonoCont.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.vtxtTelefonoCont.ValidText = ""
        '
        'ValidText3
        '
        Me.ValidText3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValidText3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Contacto", True))
        Me.ValidText3.FieldReference = Nothing
        Me.ValidText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidText3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText3.Location = New System.Drawing.Point(96, 88)
        Me.ValidText3.MaskEdit = ""
        Me.ValidText3.Name = "ValidText3"
        Me.ValidText3.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText3.Required = False
        Me.ValidText3.ShowErrorIcon = False
        Me.ValidText3.Size = New System.Drawing.Size(368, 13)
        Me.ValidText3.TabIndex = 11
        Me.ValidText3.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText3.ValidText = Nothing
        '
        'ValidText1
        '
        Me.ValidText1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidText1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Email", True))
        Me.ValidText1.FieldReference = Nothing
        Me.ValidText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidText1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ValidText1.Location = New System.Drawing.Point(96, 40)
        Me.ValidText1.MaskEdit = ""
        Me.ValidText1.Name = "ValidText1"
        Me.ValidText1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Email
        Me.ValidText1.Required = False
        Me.ValidText1.ShowErrorIcon = True
        Me.ValidText1.Size = New System.Drawing.Size(368, 13)
        Me.ValidText1.TabIndex = 8
        Me.ValidText1.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.ValidText1.ValidText = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "E-Mail"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Direccion", True))
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDireccion.Location = New System.Drawing.Point(96, 56)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDireccion.Size = New System.Drawing.Size(584, 13)
        Me.txtDireccion.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(8, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 13)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Dirección"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Observaciones", True))
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtObservaciones.Location = New System.Drawing.Point(96, 72)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(584, 13)
        Me.txtObservaciones.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(8, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Observación"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(272, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Límite de Crédito"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vtxtMonto
        '
        Me.vtxtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vtxtMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.MontoCredito", True))
        Me.vtxtMonto.ForeColor = System.Drawing.Color.RoyalBlue
        Me.vtxtMonto.Location = New System.Drawing.Point(376, 118)
        Me.vtxtMonto.Name = "vtxtMonto"
        Me.vtxtMonto.Size = New System.Drawing.Size(89, 13)
        Me.vtxtMonto.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Plazo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vtxtplazo
        '
        Me.vtxtplazo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vtxtplazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Plazo", True))
        Me.vtxtplazo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.vtxtplazo.Location = New System.Drawing.Point(96, 118)
        Me.vtxtplazo.Name = "vtxtplazo"
        Me.vtxtplazo.Size = New System.Drawing.Size(40, 13)
        Me.vtxtplazo.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(136, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "días"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtUtilidadFija
        '
        Me.TxtUtilidadFija.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUtilidadFija.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.Utilidad_Inventario", True))
        Me.TxtUtilidadFija.Enabled = False
        Me.TxtUtilidadFija.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtUtilidadFija.Location = New System.Drawing.Point(573, 118)
        Me.TxtUtilidadFija.Name = "TxtUtilidadFija"
        Me.TxtUtilidadFija.Size = New System.Drawing.Size(104, 13)
        Me.TxtUtilidadFija.TabIndex = 16
        '
        'ChecCosto
        '
        Me.ChecCosto.BackColor = System.Drawing.Color.Transparent
        Me.ChecCosto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Proveedores1, "Proveedores.CostoTotal", True))
        Me.ChecCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChecCosto.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ChecCosto.Location = New System.Drawing.Point(480, 139)
        Me.ChecCosto.Name = "ChecCosto"
        Me.ChecCosto.Size = New System.Drawing.Size(88, 16)
        Me.ChecCosto.TabIndex = 17
        Me.ChecCosto.Text = "Costo Total"
        Me.ChecCosto.UseVisualStyleBackColor = False
        '
        'ChecImpIncluido
        '
        Me.ChecImpIncluido.BackColor = System.Drawing.Color.Transparent
        Me.ChecImpIncluido.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Proveedores1, "Proveedores.ImpIncluido", True))
        Me.ChecImpIncluido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChecImpIncluido.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ChecImpIncluido.Location = New System.Drawing.Point(573, 139)
        Me.ChecImpIncluido.Name = "ChecImpIncluido"
        Me.ChecImpIncluido.Size = New System.Drawing.Size(96, 16)
        Me.ChecImpIncluido.TabIndex = 18
        Me.ChecImpIncluido.Text = "Imp. Incluido"
        Me.ChecImpIncluido.UseVisualStyleBackColor = False
        '
        'Tex_consul
        '
        Me.Tex_consul.Location = New System.Drawing.Point(216, 112)
        Me.Tex_consul.Name = "Tex_consul"
        Me.Tex_consul.Size = New System.Drawing.Size(0, 20)
        Me.Tex_consul.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(16, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(408, 16)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Cuenta Contable"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.GridControl2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 152)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Bancarios"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(8, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(664, 16)
        Me.Label22.TabIndex = 149
        Me.Label22.Text = "Datos Bancarios del Proveedor"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextoMenu
        Me.GridControl2.DataMember = "Proveedores.ProveedoresCuentas_Bancarias_Proveedor"
        Me.GridControl2.DataSource = Me.DataSet_Proveedores1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl2.Location = New System.Drawing.Point(8, 24)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTextEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(664, 160)
        Me.GridControl2.TabIndex = 140
        Me.GridControl2.Text = "GridControl2"
        Me.ToolTip.SetToolTip(Me.GridControl2, "Click Derecho para Activar el Menú Contextual... Agregar,Eliminar, Cancelar.")
        '
        'ContextoMenu
        '
        Me.ContextoMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Agregar Nuevo Registro"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Eliminar Cuenta Actual"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColProveedor, Me.colTipoCuenta, Me.colBanco, Me.colNum_Cuenta, Me.colMonedaNombre})
        Me.GridView2.GroupPanelText = ""
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowHorzLines = False
        '
        'ColProveedor
        '
        Me.ColProveedor.Caption = "Proveedor"
        Me.ColProveedor.FieldName = "CodigoProv"
        Me.ColProveedor.FilterInfo = ColumnFilterInfo5
        Me.ColProveedor.Name = "ColProveedor"
        Me.ColProveedor.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.ColProveedor.VisibleIndex = 0
        Me.ColProveedor.Width = 24
        '
        'colTipoCuenta
        '
        Me.colTipoCuenta.Caption = "Tipo"
        Me.colTipoCuenta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colTipoCuenta.FieldName = "TipoCuenta"
        Me.colTipoCuenta.FilterInfo = ColumnFilterInfo8
        Me.colTipoCuenta.Name = "colTipoCuenta"
        Me.colTipoCuenta.VisibleIndex = 1
        Me.colTipoCuenta.Width = 101
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colBanco
        '
        Me.colBanco.Caption = "Banco"
        Me.colBanco.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.FilterInfo = ColumnFilterInfo7
        Me.colBanco.Name = "colBanco"
        Me.colBanco.VisibleIndex = 2
        Me.colBanco.Width = 225
        '
        'colNum_Cuenta
        '
        Me.colNum_Cuenta.Caption = "Cuenta"
        Me.colNum_Cuenta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colNum_Cuenta.FieldName = "Num_Cuenta"
        Me.colNum_Cuenta.FilterInfo = ColumnFilterInfo2
        Me.colNum_Cuenta.Name = "colNum_Cuenta"
        Me.colNum_Cuenta.VisibleIndex = 3
        Me.colNum_Cuenta.Width = 200
        '
        'colMonedaNombre
        '
        Me.colMonedaNombre.Caption = "Moneda"
        Me.colMonedaNombre.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMonedaNombre.FieldName = "CodMoneda"
        Me.colMonedaNombre.FilterInfo = ColumnFilterInfo3
        Me.colMonedaNombre.Name = "colMonedaNombre"
        Me.colMonedaNombre.VisibleIndex = 4
        Me.colMonedaNombre.Width = 100
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodMoneda", "CodMoneda", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MonedaNombre", "MonedaNombre", 88, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValorCompra", "ValorCompra", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValorVenta", "ValorVenta", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Simbolo", "Simbolo", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MonedaCuentas_Bancarias_Proveedor", "MonedaCuentas_Bancarias_Proveedor", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.DataSet_Proveedores1.Moneda
        Me.RepositoryItemLookUpEdit1.DisplayMember = "MonedaNombre"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullString = "Seleccione la Moneda"
        Me.RepositoryItemLookUpEdit1.ValueMember = "CodMoneda"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(720, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Label9"
        '
        'Tex_cod_moneda
        '
        Me.Tex_cod_moneda.Location = New System.Drawing.Point(720, 168)
        Me.Tex_cod_moneda.Name = "Tex_cod_moneda"
        Me.Tex_cod_moneda.Size = New System.Drawing.Size(56, 22)
        Me.Tex_cod_moneda.TabIndex = 147
        '
        'Tex_nom_moneda_prov
        '
        Me.Tex_nom_moneda_prov.Location = New System.Drawing.Point(720, 144)
        Me.Tex_nom_moneda_prov.Name = "Tex_nom_moneda_prov"
        Me.Tex_nom_moneda_prov.Size = New System.Drawing.Size(56, 22)
        Me.Tex_nom_moneda_prov.TabIndex = 146
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Proveedores1, "Proveedores.CodigoProv", True))
        Me.txtCodigo.FieldReference = Nothing
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodigo.Location = New System.Drawing.Point(95, 19)
        Me.txtCodigo.MaskEdit = ""
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCodigo.Required = False
        Me.txtCodigo.ShowErrorIcon = False
        Me.txtCodigo.Size = New System.Drawing.Size(65, 13)
        Me.txtCodigo.TabIndex = 149
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.txtCodigo.ValidText = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(7, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 12)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Identificación"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Proveedores"
        Me.DataNavigator1.DataSource = Me.DataSet_Proveedores1
        Me.DataNavigator1.Location = New System.Drawing.Point(547, 416)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(134, 21)
        Me.DataNavigator1.TabIndex = 47
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESERVER;packet size=4096;integrated security=SSPI;data source=""." & _
    """;persist security info=False;initial catalog=Proveeduria"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'daProveedores
        '
        Me.daProveedores.DeleteCommand = Me.SqlDeleteCommand1
        Me.daProveedores.InsertCommand = Me.SqlInsertCommand1
        Me.daProveedores.SelectCommand = Me.SqlSelectCommand1
        Me.daProveedores.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Contacto", "Contacto"), New System.Data.Common.DataColumnMapping("Telefono_Cont", "Telefono_Cont"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Fax1", "Fax1"), New System.Data.Common.DataColumnMapping("Fax2", "Fax2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("MontoCredito", "MontoCredito"), New System.Data.Common.DataColumnMapping("Plazo", "Plazo"), New System.Data.Common.DataColumnMapping("CostoTotal", "CostoTotal"), New System.Data.Common.DataColumnMapping("ImpIncluido", "ImpIncluido"), New System.Data.Common.DataColumnMapping("PedidosMes", "PedidosMes"), New System.Data.Common.DataColumnMapping("Utilidad_Fija", "Utilidad_Fija"), New System.Data.Common.DataColumnMapping("Utilidad_Inventario", "Utilidad_Inventario"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("DescripcionCuentaContable", "DescripcionCuentaContable")})})
        Me.daProveedores.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoTotal", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ImpIncluido", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ImpIncluido", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PedidosMes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PedidosMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_Cont", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_Cont", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Fija", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Fija", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Inventario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Inventario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 20, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Telefono_Cont", System.Data.SqlDbType.VarChar, 15, "Telefono_Cont"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 15, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 15, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Fax1", System.Data.SqlDbType.VarChar, 15, "Fax1"), New System.Data.SqlClient.SqlParameter("@Fax2", System.Data.SqlDbType.VarChar, 15, "Fax2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@MontoCredito", System.Data.SqlDbType.Float, 8, "MontoCredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@CostoTotal", System.Data.SqlDbType.Bit, 1, "CostoTotal"), New System.Data.SqlClient.SqlParameter("@ImpIncluido", System.Data.SqlDbType.Bit, 1, "ImpIncluido"), New System.Data.SqlClient.SqlParameter("@PedidosMes", System.Data.SqlDbType.Int, 4, "PedidosMes"), New System.Data.SqlClient.SqlParameter("@Utilidad_Fija", System.Data.SqlDbType.Bit, 1, "Utilidad_Fija"), New System.Data.SqlClient.SqlParameter("@Utilidad_Inventario", System.Data.SqlDbType.Float, 8, "Utilidad_Inventario"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@DescripcionCuentaContable", System.Data.SqlDbType.VarChar, 250, "DescripcionCuentaContable")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 20, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Telefono_Cont", System.Data.SqlDbType.VarChar, 15, "Telefono_Cont"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 15, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 15, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Fax1", System.Data.SqlDbType.VarChar, 15, "Fax1"), New System.Data.SqlClient.SqlParameter("@Fax2", System.Data.SqlDbType.VarChar, 15, "Fax2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@MontoCredito", System.Data.SqlDbType.Float, 8, "MontoCredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@CostoTotal", System.Data.SqlDbType.Bit, 1, "CostoTotal"), New System.Data.SqlClient.SqlParameter("@ImpIncluido", System.Data.SqlDbType.Bit, 1, "ImpIncluido"), New System.Data.SqlClient.SqlParameter("@PedidosMes", System.Data.SqlDbType.Int, 4, "PedidosMes"), New System.Data.SqlClient.SqlParameter("@Utilidad_Fija", System.Data.SqlDbType.Bit, 1, "Utilidad_Fija"), New System.Data.SqlClient.SqlParameter("@Utilidad_Inventario", System.Data.SqlDbType.Float, 8, "Utilidad_Inventario"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@DescripcionCuentaContable", System.Data.SqlDbType.VarChar, 250, "DescripcionCuentaContable"), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoTotal", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ImpIncluido", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ImpIncluido", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PedidosMes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PedidosMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_Cont", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_Cont", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Fija", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Fija", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Inventario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Inventario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'da_cuentas
        '
        Me.da_cuentas.DeleteCommand = Me.SqlDeleteCommand2
        Me.da_cuentas.InsertCommand = Me.SqlInsertCommand2
        Me.da_cuentas.SelectCommand = Me.SqlSelectCommand2
        Me.da_cuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_Bancarias_Proveedor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Cuenta", "Id_Cuenta"), New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("TipoCuenta", "TipoCuenta"), New System.Data.Common.DataColumnMapping("Banco", "Banco"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Num_Cuenta", "Num_Cuenta"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        Me.da_cuentas.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Cuenta", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCuenta", System.Data.SqlDbType.VarChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@TipoCuenta", System.Data.SqlDbType.VarChar, 35, "TipoCuenta"), New System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 70, "Banco"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Num_Cuenta", System.Data.SqlDbType.VarChar, 50, "Num_Cuenta"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_Cuenta, CodigoProv, TipoCuenta, Banco, CodMoneda, Num_Cuenta, MonedaNom" & _
    "bre FROM Cuentas_Bancarias_Proveedor"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@TipoCuenta", System.Data.SqlDbType.VarChar, 35, "TipoCuenta"), New System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 70, "Banco"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Num_Cuenta", System.Data.SqlDbType.VarChar, 50, "Num_Cuenta"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Cuenta", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCuenta", System.Data.SqlDbType.VarChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Cuenta", System.Data.SqlDbType.Int, 4, "Id_Cuenta")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Monedas
        '
        Me.Adapter_Monedas.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Monedas.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Monedas.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Monedas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.Adapter_Monedas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'da_num_prov
        '
        Me.da_num_prov.SelectCommand = Me.SqlSelectCommand4
        Me.da_num_prov.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_provee", "Num_provee")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT ISNULL(MAX(CodigoProv), 0) + 1 AS Num_provee FROM Proveedores"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 379)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(688, 59)
        Me.ToolBar1.TabIndex = 74
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        '
        'ckSeguimiento
        '
        Me.ckSeguimiento.AutoSize = True
        Me.ckSeguimiento.ForeColor = System.Drawing.Color.Tomato
        Me.ckSeguimiento.Location = New System.Drawing.Point(480, 104)
        Me.ckSeguimiento.Name = "ckSeguimiento"
        Me.ckSeguimiento.Size = New System.Drawing.Size(95, 17)
        Me.ckSeguimiento.TabIndex = 159
        Me.ckSeguimiento.Text = "Seguimiento"
        Me.ckSeguimiento.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(688, 438)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Tex_nom_moneda_prov)
        Me.Controls.Add(Me.Tex_cod_moneda)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Proveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet_Proveedores1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Variable "                 'Definicion de Variable /Albert Estrada\
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
    Dim nuevo_cuenta As Boolean = False
#End Region

    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cConexion = New Conexion
        'sqlConexion = cConexion.Conectar
        SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
        'SqlConnection1.ConnectionString = CadenaConexionSeePOS

        Me.daProveedores.Fill(DataSet_Proveedores1, "Proveedores")
        Me.Adapter_Monedas.Fill(Me.DataSet_Proveedores1, "Moneda")
        Me.da_cuentas.Fill(Me.DataSet_Proveedores1, "Cuentas_Bancarias_Proveedor")
        Me.DataSet_Proveedores1.Proveedores.CostoTotalColumn.DefaultValue = False
        Me.DataSet_Proveedores1.Proveedores.ImpIncluidoColumn.DefaultValue = False
        Me.DataSet_Proveedores1.Proveedores.Telefono1Column.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.Telefono2Column.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.ContactoColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.Telefono_ContColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.DireccionColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.Fax1Column.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.Fax2Column.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.EmailColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.ObservacionesColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.Utilidad_FijaColumn.DefaultValue = False
        Me.DataSet_Proveedores1.Proveedores.CostoTotalColumn.DefaultValue = False
        Me.DataSet_Proveedores1.Proveedores.ImpIncluidoColumn.DefaultValue = False
        Me.DataSet_Proveedores1.Proveedores.Utilidad_InventarioColumn.DefaultValue = 0

        Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor.Num_CuentaColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor.TipoCuentaColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor.BancoColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor.CodMonedaColumn.DefaultValue = Me.DataSet_Proveedores1.Moneda.Rows(0).Item(0)
        Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor.MonedaNombreColumn.DefaultValue = ""

        Me.DataSet_Proveedores1.Proveedores.PedidosMesColumn.DefaultValue = "0"
        Me.DataSet_Proveedores1.Proveedores.MontoCreditoColumn.DefaultValue = "0"
        Me.DataSet_Proveedores1.Proveedores.PlazoColumn.DefaultValue = "0"
        Me.DataSet_Proveedores1.Proveedores.CodigoProvColumn.DefaultValue = "0"
        Me.DataSet_Proveedores1.Proveedores.CedulaColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.NombreColumn.DefaultValue = ""

        Me.DataSet_Proveedores1.Proveedores.CuentaContableColumn.DefaultValue = ""
        Me.DataSet_Proveedores1.Proveedores.DescripcionCuentaContableColumn.DefaultValue = ""
        
    End Sub
    Private Sub vtxtVisitas_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vtxtVisitas.SelectAll()
    End Sub
    Private Sub vtxtMonto_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vtxtMonto.SelectAll()
    End Sub

    Private Sub vtxtPlazo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vtxtplazo.SelectAll()
    End Sub

    Private Sub Nuevo_Proveedor()
        Dim Fx As New cFunciones
        Dim Valor As Boolean
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Me.ToolBar1.Buttons(3).Enabled = False

            Try
                Me.DataSet_Proveedores1.AutoNumerico.Clear()
                Me.da_num_prov.Fill(Me.DataSet_Proveedores1, "AutoNumerico")
                Me.DataSet_Proveedores1.Proveedores.CodigoProvColumn.DefaultValue = Me.BindingContext(Me.DataSet_Proveedores1, "AutoNumerico").Current("Num_provee")
                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").EndCurrentEdit()
                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").AddNew() 'agregar una fila
                Valor = Fx.VerificarBaseDatos("Contabilidad")
                If Valor Then
                    Me.Label15.Visible = True
                    Me.Label11.Visible = True
                    Me.TextBox1.Visible = True
                Else
                    Me.Label15.Visible = False
                    Me.Label11.Visible = False
                    Me.TextBox1.Visible = False
                End If
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

            Me.ValidText2.Focus()


        Else
            Try
                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = True


            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        End If
    End Sub

    Private Sub Registrar_Prov()

        If validar() Then

            Try

                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").EndCurrentEdit()
                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").EndCurrentEdit() 'termino edicion

                Me.daProveedores.Update(Me.DataSet_Proveedores1.Proveedores)  'actualizo los provedores
                Me.da_cuentas.Update(Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor)  'Actualiza las cuentas Bancarias Ingresadas

                Try

                    Dim db As New GestioDatos
                    db.Ejecuta("Update Proveedores set inhabilitado = " & IIf(Me.ckInhabilitado.Checked = True, 1, 0) & ", Seguimiento = " & IIf(Me.ckSeguimiento.Checked = True, 1, 0) & ", Actualizado = " & IIf(Me.ckActualizado.Checked = True, 1, 0) & ", Serie = " & IIf(Me.ckSerie.Checked = True, 1, 0) & " Where CodigoProv = '" & Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").Current("CodigoProv") & "'")

                Catch ex As Exception
                End Try

                Me.DataSet_Proveedores1.AcceptChanges()


                Me.ToolBar1.Buttons(3).Enabled = True 'se activa el botond e guardar
                MsgBox("Los datos se han registrado satisfactoriamente...", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                'Nuevo_Proveedor()

                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = True
            Catch ex As System.Data.NoNullAllowedException 'Cacha los distintos errores que se pueden dar
                MessageBox.Show("Algunos datos no han sido ingresados y son necesario para completar la operación, corrija el problema y vuelva a intentar", "Seepos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

            End Try
        End If
    End Sub

    Private Sub Eliminar_Prov()
        Dim resp As Integer
        Try 'se intenta hacer

            If Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").Count > 0 Then ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar permanentemente esta Proveedor?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").RemoveAt(Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").Position)
                    Me.daProveedores.Update(Me.DataSet_Proveedores1, "Proveedores")
                    Me.GridView2.OptionsView.ShowNewItemRow = False
                Else
                    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Proveedores para eliminar", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Private Sub Nueva_Cuenta_Bancaria()
        Try

            'If Me.GridView2.OptionsView.ShowNewItemRow = False Then
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").EndCurrentEdit()
            'Me.GridView2.OptionsView.ShowNewItemRow = True
            'End If
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").AddNew()
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").Current("TipoCuenta") = ""
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").Current("Banco") = ""
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").Current("Num_Cuenta") = ""
            Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").EndCurrentEdit()


        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub


    'Private Sub Registrar_cuenta_bancaria()
    '    Try
    '        Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").EndCurrentEdit()
    '        Me.da_cuentas.Update(Me.DataSet_Proveedores1, "Cuentas_Bancarias_Proveedor")


    '    Catch eEndEdit As System.Data.NoNullAllowedException
    '        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
    '    End Try
    'End Sub
    Private Sub Eliminar_cuenta_bancaria()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").Count > 0 Then ' si hay ubicaciones
                resp = MessageBox.Show("¿Desea eliminar permanentemente esta Cuenta?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").RemoveAt(Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").Position)
                    'Me.da_cuentas.Update(Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor)
                Else
                    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Cuentas para eliminar", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Private Sub txtBanco_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.Nueva_Cuenta_Bancaria()
        End If

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BindingContext(Me.DataSet_Proveedores1, "Moneda").Position = Me.ComboBox1.SelectedIndex
    End Sub



#Region " Validaciones"

    Private Sub vtxtCedula_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vtxtCedula.Validating
        If vtxtCedula.Text = "" Then
            ErrorProvider1.SetError(sender, "Digite la cédula")
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub




    Private Sub vtxtVisitas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vtxtVisitas.Validating
        If vtxtVisitas.Text = "" Then
            ErrorProvider1.SetError(sender, "Digite la cantidad de Visitas")
            'e.Cancel = True

        ElseIf vtxtVisitas.Text < 1 Then
            ErrorProvider1.SetError(sender, "Debe realizarse almenos una visita al mes")
            'e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub


    Private Sub vtxtVisitas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vtxtVisitas.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub ValidText10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub



    Private Sub ValidText9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub



    Private Sub ValidText12_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub



    Private Sub ValidText8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        '        If ComboBox1.Text = "" Then
        '        ErrorProvider1.SetError(sender, "Seleccione una moneda")
        '        Else
        '            ErrorProvider1.SetError(sender, "")
        '        End If
    End Sub



    Private Sub vtxtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub vtxtPlazo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub vtxtTelefonoCont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vtxtTelefonoCont.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub
    Private Sub vtxtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vtxtCedula.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub ValidText10_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValidText10.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub



    Private Sub ValidText4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValidText4.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub



    Private Sub ValidText5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValidText5.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub


    Private Sub ValidText6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValidText6.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub

    Private Sub txtCuenta_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try


            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0 : Nuevo_Proveedor()
                Case 1 : If PMU.Find Then Buscar_Proveedor() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 2 : If PMU.Update Then Registrar_Prov() Else MsgBox("No tiene permiso para Agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 3 : If PMU.Delete Then Eliminar_Prov() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4 : If MessageBox.Show("¿Desea Cerrar el Módulo de Proveedores?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarActualizado()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select inhabilitado, Seguimiento, Actualizado, Serie from Proveedores where CodigoProv = " & Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").Current("CodigoProv"), dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.ckInhabilitado.Checked = CBool(dt.Rows(0).Item("inhabilitado"))
            Me.ckActualizado.Checked = CBool(dt.Rows(0).Item("Actualizado"))
            Me.ckSerie.Checked = CBool(dt.Rows(0).Item("Serie"))
            Me.ckSeguimiento.Checked = CBool(dt.Rows(0).Item("Seguimiento"))
        End If
    End Sub

    Sub Buscar_Proveedor()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...", Me.SqlConnection1.ConnectionString)
            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DataSet_Proveedores1.Proveedores.DefaultView
                vista.Sort = "CodigoProv"
                pos = vista.Find(CDbl(valor))
                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").Position = pos
            End If
            Me.GridView2.OptionsView.ShowNewItemRow = False
            Me.CargarActualizado()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.Eliminar_cuenta_bancaria()
        End If
    End Sub
    Private Sub boton_cancelar_cuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").CancelCurrentEdit()
    End Sub

    Function Validar() As Boolean
        If Me.ValidText2.Text = "" Then
            MsgBox("El nombre del Proveedor es requerido", MsgBoxStyle.Exclamation, "Atención...")
            Me.ValidText2.Focus()
            Return False

        ElseIf vtxtCedula.Text = "" Then
            MsgBox("Debe de digitar el número de cédula del proveedor", MsgBoxStyle.Exclamation, "Atención...")
            Me.vtxtCedula.Focus()
            Return False

        ElseIf ValidText10.Text = "" Then
            MsgBox("Debe de digitar un número telefónico", MsgBoxStyle.Exclamation, "Atención...")
            Me.ValidText10.Focus()
            Return False
        Else : Return True
        End If
    End Function
    Private Sub txtBanco_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            If Me.nuevo_cuenta = False Then
                Me.Nueva_Cuenta_Bancaria()
                nuevo_cuenta = True
            Else
                Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").CancelCurrentEdit()
                nuevo_cuenta = False
            End If
        End If
    End Sub



    Private Sub ValidText2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ValidText2.Validating
        If ValidText2.Text = "" Then

            ErrorProvider1.SetError(sender, "Digite  el nombre del proveedor")
            'e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub
    'Private Sub ValidText1_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ValidText1.Validating
    '    If Me.ValidText1.Text <> "" Then ' si hay algo digitado en el campo e-mail
    '        Dim parte1 As Integer
    '        Dim parte2 As Integer
    '        Dim parte3 As Integer
    '        parte1 = ValidText1.Text.IndexOf("@") 'almacena la cantidad de caracteres hasta llegar al @
    '        parte2 = ValidText1.Text.IndexOf(".") 'almacena la cantidad de caracteres hasta llegar al "."
    '        parte3 = ValidText1.Text.Length ' almacena la cantidad total de caracteres de la cadena
    '        If (Not (parte1 >= 3 And parte2 >= 6 And parte3 >= 9)) Then 'si antes del @ hay menos de 3 carcteres y antes del punto hay  menos de 6 y si toda la cadena tiene menos de 9 caracteres
    '            ErrorProvider1.SetError(sender, "Digite un correo electrónico válido")
    '            e.Cancel = True
    '        Else
    '            ErrorProvider1.SetError(sender, "")
    '        End If

    '    End If
    'End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Nueva_Cuenta_Bancaria()
    End Sub


    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.Nueva_Cuenta_Bancaria()
    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Eliminar_cuenta_bancaria()
    End Sub

    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").EndCurrentEdit()
    End Sub

    Private Sub EventosDeTeclado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDireccion.KeyDown, txtObservaciones.KeyDown, vtxtplazo.KeyDown, vtxtMonto.KeyDown, TxtUtilidadFija.KeyDown, CheckBox1.KeyDown, ChecCosto.KeyDown, ChecImpIncluido.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtUtilidadFija.Enabled = True
            Me.TxtUtilidadFija.Focus()
        Else
            TxtUtilidadFija.Text = 0
            TxtUtilidadFija.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Nueva_Cuenta_Bancaria()
    End Sub

    Function CargarInformacionCuentaContable(ByVal codigo As String) As Boolean
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean
        If codigo <> Nothing Then
            sqlConexion = CConexion1.Conectar("Contabilidad")
            rs = CConexion1.GetRecorset(sqlConexion, "SELECT CuentaContable, Descripcion FROM  CuentaContable where CuentaContable = '" & codigo & "'")
            Encontrado = False
            While rs.Read
                Try
                    Encontrado = True
                    TextBox1.Text = rs("CuentaContable")
                    Label15.Text = rs("Descripcion")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion1.DesConectar(CConexion1.Conectar("Contabilidad"))
                End Try
            End While
            rs.Close()

            If Not Encontrado Then
                MsgBox("No existe Esta Cuenta Contable", MsgBoxStyle.Exclamation)
                CConexion1.DesConectar(CConexion1.Conectar("Contabilidad"))
                Return False
            End If
            CConexion1.DesConectar(CConexion1.Conectar("Contabilidad"))
            Return True
        End If
    End Function


    Private Sub TextBox1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim Id As String
            Id = Fx.BuscarDatos("SELECT CuentaContable, Descripcion FROM cuentacontable where (Movimiento = 1) ", "Descripcion", "Buscar Cuenta Contable .....", GetSetting("Seesoft", "Contabilidad", "Conexion"))

            If Id = "" Then
                Exit Sub
            End If

            TextBox1.Text = Id
            If CargarInformacionCuentaContable(Me.TextBox1.Text) Then
                Me.GroupBox2.Focus()
            Else
                Me.TextBox1.Focus()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            '''''''
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = Me.TextBox1.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then ' en caso de que la cuenta se haya digitado y no buscado, se valida su existencia
                MessageBox.Show("La cuenta digitada no esta registrada o no permite movimiento..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TextBox1.Focus()
            Else
                '
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.Label15.Text = nombre
                '
            End If
        End If
    End Sub

   
    Private Sub vtxtCedula_TextChanged(sender As Object, e As EventArgs) Handles vtxtCedula.TextChanged
        CargarActualizado()
    End Sub

End Class
