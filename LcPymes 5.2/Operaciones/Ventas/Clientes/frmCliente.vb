Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Frmcliente
    Inherits System.Windows.Forms.Form
    Dim CConexion As New Conexion
    Dim Eliminando As Boolean = False
    Dim Tipo_Accion As String = ""
    Dim usuario_autorizado As String
    Dim usua
    Dim PMU As New PerfilModulo_Class
    Friend WithEvents ckOrdendeCompra As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboExoneracion As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoComprobante As System.Windows.Forms.TextBox
    Friend WithEvents ckActualizado As System.Windows.Forms.CheckBox
    Friend WithEvents btnIdentificarse As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescuentoEspecial As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ckMAG As System.Windows.Forms.CheckBox
    Friend WithEvents ckNotificaRecibo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCorreoRecibo As System.Windows.Forms.TextBox
    Friend WithEvents lblAdvertenciaMoroso As System.Windows.Forms.Label
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
    Friend WithEvents ckFallecido As System.Windows.Forms.CheckBox   'Declara la variable Perfil Modulo Usuario
    Dim strMensaje As String = ""

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
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo de inicio
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txttel1 As System.Windows.Forms.TextBox
    Friend WithEvents Txttel2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtobserv As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents Ckbempresa As System.Windows.Forms.CheckBox
    Friend WithEvents Ckbexcento As System.Windows.Forms.CheckBox
    Friend WithEvents Cbcredito As System.Windows.Forms.ComboBox
    Friend WithEvents Txtfax1 As System.Windows.Forms.TextBox
    Friend WithEvents Txdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Txtfax2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txtimpuesto As ValidText.ValidText
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Txtidentificacion As ValidText.ValidText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Adapter_Clientes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_EncargadosCompras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Referencia_Bancaria As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Referencia_Comercial As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Grid_Ref_Banc As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Private WithEvents Grid_Encargado_Compras As DevExpress.XtraGrid.GridControl
    Private WithEvents Grid_Ref_Comer As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtID_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents LabelID_TipoPrecio As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMoroso As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAbrirCredito As System.Windows.Forms.CheckBox
    Friend WithEvents AdapterConsecutivo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Txtplazocredito As System.Windows.Forms.TextBox
    Friend WithEvents Txtlimitecredito As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAgente As System.Windows.Forms.ComboBox
    Friend WithEvents CbTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents PanelDatosBasicos As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxRestriccion As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxRestricciones As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetClientes1 As DataSetClientes
    Friend WithEvents colSucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Bitacora As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Tex_Accion As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_MovimientoCaja1 As DataSet_MovimientoCaja
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkbEliminaAgente As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ckSugerido As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAnular As System.Windows.Forms.CheckBox
    Friend WithEvents ck_notificacion As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcliente))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtobserv = New System.Windows.Forms.TextBox()
        Me.DataSetClientes1 = New LcPymes_5._2.DataSetClientes()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtcedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ckbempresa = New System.Windows.Forms.CheckBox()
        Me.Ckbexcento = New System.Windows.Forms.CheckBox()
        Me.Cbcredito = New System.Windows.Forms.ComboBox()
        Me.Txtidentificacion = New ValidText.ValidText()
        Me.Txtimpuesto = New ValidText.ValidText()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ckOrdendeCompra = New System.Windows.Forms.CheckBox()
        Me.Txtlimitecredito = New System.Windows.Forms.TextBox()
        Me.Txtdescuento = New System.Windows.Forms.TextBox()
        Me.Txtplazocredito = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxRestriccion = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckBoxMoroso = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnular = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAbrirCredito = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ckFallecido = New System.Windows.Forms.CheckBox()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.ckNotificaRecibo = New System.Windows.Forms.CheckBox()
        Me.txtCorreoRecibo = New System.Windows.Forms.TextBox()
        Me.ckMAG = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescuentoEspecial = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ckActualizado = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCorreoComprobante = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboExoneracion = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboTipoCliente = New System.Windows.Forms.ComboBox()
        Me.ck_notificacion = New System.Windows.Forms.CheckBox()
        Me.ckSugerido = New System.Windows.Forms.CheckBox()
        Me.chkbEliminaAgente = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtfax1 = New System.Windows.Forms.TextBox()
        Me.Txttel1 = New System.Windows.Forms.TextBox()
        Me.Txdireccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Txtfax2 = New System.Windows.Forms.TextBox()
        Me.Txttel2 = New System.Windows.Forms.TextBox()
        Me.CbTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAgente = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnIdentificarse = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Grid_Encargado_Compras = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Grid_Ref_Banc = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Grid_Ref_Comer = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTelefono1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComboBoxRestricciones = New System.Windows.Forms.ComboBox()
        Me.LabelID_TipoPrecio = New System.Windows.Forms.Label()
        Me.TxtID_Usuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Clientes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_EncargadosCompras = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Referencia_Bancaria = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Referencia_Comercial = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AdapterConsecutivo = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelDatosBasicos = New System.Windows.Forms.Panel()
        Me.lblAdvertenciaMoroso = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Bitacora = New System.Data.SqlClient.SqlDataAdapter()
        Me.Tex_Accion = New System.Windows.Forms.TextBox()
        Me.DataSet_MovimientoCaja1 = New LcPymes_5._2.DataSet_MovimientoCaja()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        CType(Me.DataSetClientes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grid_Encargado_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Grid_Ref_Banc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Grid_Ref_Comer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosBasicos.SuspendLayout()
        CType(Me.DataSet_MovimientoCaja1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(627, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observaciones:"
        '
        'Txtobserv
        '
        Me.Txtobserv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtobserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtobserv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.observaciones", True))
        Me.Txtobserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobserv.ForeColor = System.Drawing.Color.Blue
        Me.Txtobserv.Location = New System.Drawing.Point(5, 65)
        Me.Txtobserv.Name = "Txtobserv"
        Me.Txtobserv.Size = New System.Drawing.Size(627, 13)
        Me.Txtobserv.TabIndex = 5
        '
        'DataSetClientes1
        '
        Me.DataSetClientes1.DataSetName = "DataSetClientes"
        Me.DataSetClientes1.Locale = New System.Globalization.CultureInfo("")
        Me.DataSetClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txtnombre
        '
        Me.Txtnombre.AccessibleDescription = ""
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.nombre", True))
        Me.Txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombre.ForeColor = System.Drawing.Color.Blue
        Me.Txtnombre.Location = New System.Drawing.Point(5, 25)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(459, 13)
        Me.Txtnombre.TabIndex = 0
        '
        'Txtcedula
        '
        Me.Txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.cedula", True))
        Me.Txtcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcedula.ForeColor = System.Drawing.Color.Blue
        Me.Txtcedula.Location = New System.Drawing.Point(485, 25)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(147, 13)
        Me.Txtcedula.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(459, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(485, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cédula:"
        '
        'Ckbempresa
        '
        Me.Ckbempresa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Ckbempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Ckbempresa.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Ckbempresa.Location = New System.Drawing.Point(274, 60)
        Me.Ckbempresa.Name = "Ckbempresa"
        Me.Ckbempresa.Size = New System.Drawing.Size(247, 16)
        Me.Ckbempresa.TabIndex = 9
        Me.Ckbempresa.Text = "Empresa, Asociación, Compañía..."
        Me.Ckbempresa.UseVisualStyleBackColor = False
        '
        'Ckbexcento
        '
        Me.Ckbexcento.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Ckbexcento.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ckbexcento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Ckbexcento.Location = New System.Drawing.Point(643, 51)
        Me.Ckbexcento.Name = "Ckbexcento"
        Me.Ckbexcento.Size = New System.Drawing.Size(176, 16)
        Me.Ckbexcento.TabIndex = 14
        Me.Ckbexcento.Text = "Excento de Impuesto"
        Me.Ckbexcento.UseVisualStyleBackColor = False
        Me.Ckbexcento.Visible = False
        '
        'Cbcredito
        '
        Me.Cbcredito.Enabled = False
        Me.Cbcredito.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbcredito.ForeColor = System.Drawing.Color.Blue
        Me.Cbcredito.Items.AddRange(New Object() {"NO", "SI"})
        Me.Cbcredito.Location = New System.Drawing.Point(28, 35)
        Me.Cbcredito.Name = "Cbcredito"
        Me.Cbcredito.Size = New System.Drawing.Size(190, 22)
        Me.Cbcredito.TabIndex = 11
        '
        'Txtidentificacion
        '
        Me.Txtidentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtidentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.identificacion", True))
        Me.Txtidentificacion.FieldReference = Nothing
        Me.Txtidentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtidentificacion.ForeColor = System.Drawing.Color.Red
        Me.Txtidentificacion.Location = New System.Drawing.Point(677, 8)
        Me.Txtidentificacion.MaskEdit = ""
        Me.Txtidentificacion.Name = "Txtidentificacion"
        Me.Txtidentificacion.ReadOnly = True
        Me.Txtidentificacion.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.Txtidentificacion.Required = False
        Me.Txtidentificacion.ShowErrorIcon = False
        Me.Txtidentificacion.Size = New System.Drawing.Size(104, 13)
        Me.Txtidentificacion.TabIndex = 1
        Me.Txtidentificacion.Text = "00000000"
        Me.Txtidentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txtidentificacion.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.Txtidentificacion.ValidText = "#0"
        '
        'Txtimpuesto
        '
        Me.Txtimpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtimpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.impuesto", True))
        Me.Txtimpuesto.FieldReference = Nothing
        Me.Txtimpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtimpuesto.ForeColor = System.Drawing.Color.Blue
        Me.Txtimpuesto.Location = New System.Drawing.Point(715, 67)
        Me.Txtimpuesto.MaskEdit = ""
        Me.Txtimpuesto.Name = "Txtimpuesto"
        Me.Txtimpuesto.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.Txtimpuesto.Required = False
        Me.Txtimpuesto.ShowErrorIcon = False
        Me.Txtimpuesto.Size = New System.Drawing.Size(104, 13)
        Me.Txtimpuesto.TabIndex = 10
        Me.Txtimpuesto.Text = "100"
        Me.Txtimpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtimpuesto.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.Txtimpuesto.ValidText = "#0.00"
        Me.Txtimpuesto.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.ckOrdendeCompra)
        Me.GroupBox3.Controls.Add(Me.Cbcredito)
        Me.GroupBox3.Controls.Add(Me.Txtlimitecredito)
        Me.GroupBox3.Controls.Add(Me.Txtdescuento)
        Me.GroupBox3.Controls.Add(Me.Txtplazocredito)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Ckbempresa)
        Me.GroupBox3.Controls.Add(Me.CheckBoxRestriccion)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.CheckBoxMoroso)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(24, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(528, 164)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(28, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(190, 15)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Crédito"
        '
        'ckOrdendeCompra
        '
        Me.ckOrdendeCompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckOrdendeCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ckOrdendeCompra.ForeColor = System.Drawing.Color.Red
        Me.ckOrdendeCompra.Location = New System.Drawing.Point(274, 124)
        Me.ckOrdendeCompra.Name = "ckOrdendeCompra"
        Me.ckOrdendeCompra.Size = New System.Drawing.Size(247, 16)
        Me.ckOrdendeCompra.TabIndex = 13
        Me.ckOrdendeCompra.Text = "Obligar Orden de Compra"
        Me.ckOrdendeCompra.UseVisualStyleBackColor = False
        '
        'Txtlimitecredito
        '
        Me.Txtlimitecredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.max_credito", True))
        Me.Txtlimitecredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtlimitecredito.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Txtlimitecredito.Location = New System.Drawing.Point(144, 108)
        Me.Txtlimitecredito.Name = "Txtlimitecredito"
        Me.Txtlimitecredito.Size = New System.Drawing.Size(72, 20)
        Me.Txtlimitecredito.TabIndex = 2
        '
        'Txtdescuento
        '
        Me.Txtdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.descuento", True))
        Me.Txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescuento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Txtdescuento.Location = New System.Drawing.Point(146, 132)
        Me.Txtdescuento.Name = "Txtdescuento"
        Me.Txtdescuento.Size = New System.Drawing.Size(72, 20)
        Me.Txtdescuento.TabIndex = 8
        '
        'Txtplazocredito
        '
        Me.Txtplazocredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.Plazo_credito", True))
        Me.Txtplazocredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtplazocredito.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Txtplazocredito.Location = New System.Drawing.Point(146, 84)
        Me.Txtplazocredito.Name = "Txtplazocredito"
        Me.Txtplazocredito.Size = New System.Drawing.Size(72, 20)
        Me.Txtplazocredito.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetClientes1, "Clientes.CodMonedaCredito", True))
        Me.ComboBox1.DataSource = Me.DataSetClientes1.Moneda
        Me.ComboBox1.DisplayMember = "MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(125, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 22)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "CodMoneda"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Moneda.Simbolo", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(129, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "M"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(130, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "%"
        '
        'CheckBoxRestriccion
        '
        Me.CheckBoxRestriccion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxRestriccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxRestriccion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBoxRestriccion.Location = New System.Drawing.Point(274, 76)
        Me.CheckBoxRestriccion.Name = "CheckBoxRestriccion"
        Me.CheckBoxRestriccion.Size = New System.Drawing.Size(247, 16)
        Me.CheckBoxRestriccion.TabIndex = 10
        Me.CheckBoxRestriccion.Text = "Permitir la venta sin restriccion de cuenta"
        Me.CheckBoxRestriccion.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(26, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(192, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Moneda Crédito"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(26, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Plazo Crédito (Días)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(26, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Límite de Crédito"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Location = New System.Drawing.Point(26, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 20)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Límite Descuento"
        '
        'CheckBoxMoroso
        '
        Me.CheckBoxMoroso.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxMoroso.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetClientes1, "Clientes.Cliente_Moroso", True))
        Me.CheckBoxMoroso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxMoroso.ForeColor = System.Drawing.Color.Red
        Me.CheckBoxMoroso.Location = New System.Drawing.Point(274, 92)
        Me.CheckBoxMoroso.Name = "CheckBoxMoroso"
        Me.CheckBoxMoroso.Size = New System.Drawing.Size(247, 16)
        Me.CheckBoxMoroso.TabIndex = 11
        Me.CheckBoxMoroso.Text = "Cliente en estado moroso"
        Me.CheckBoxMoroso.UseVisualStyleBackColor = False
        '
        'CheckBoxAnular
        '
        Me.CheckBoxAnular.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxAnular.Enabled = False
        Me.CheckBoxAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxAnular.ForeColor = System.Drawing.Color.Red
        Me.CheckBoxAnular.Location = New System.Drawing.Point(456, 143)
        Me.CheckBoxAnular.Name = "CheckBoxAnular"
        Me.CheckBoxAnular.Size = New System.Drawing.Size(95, 16)
        Me.CheckBoxAnular.TabIndex = 12
        Me.CheckBoxAnular.Text = "Inactivado"
        Me.CheckBoxAnular.UseVisualStyleBackColor = False
        '
        'CheckBoxAbrirCredito
        '
        Me.CheckBoxAbrirCredito.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxAbrirCredito.Enabled = False
        Me.CheckBoxAbrirCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxAbrirCredito.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBoxAbrirCredito.Location = New System.Drawing.Point(48, 31)
        Me.CheckBoxAbrirCredito.Name = "CheckBoxAbrirCredito"
        Me.CheckBoxAbrirCredito.Size = New System.Drawing.Size(104, 15)
        Me.CheckBoxAbrirCredito.TabIndex = 1
        Me.CheckBoxAbrirCredito.Text = "Activar Crédito"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAbrirCredito, "Para activar crédito debe de tener habilitado en seguridad ""Opcional""")
        Me.CheckBoxAbrirCredito.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 164)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 232)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.ckFallecido)
        Me.TabPage1.Controls.Add(Me.btnCambiarEstado)
        Me.TabPage1.Controls.Add(Me.ckNotificaRecibo)
        Me.TabPage1.Controls.Add(Me.txtCorreoRecibo)
        Me.TabPage1.Controls.Add(Me.CheckBoxAnular)
        Me.TabPage1.Controls.Add(Me.ckMAG)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ckActualizado)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtCorreoComprobante)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.cboExoneracion)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.cboTipoCliente)
        Me.TabPage1.Controls.Add(Me.ck_notificacion)
        Me.TabPage1.Controls.Add(Me.ckSugerido)
        Me.TabPage1.Controls.Add(Me.chkbEliminaAgente)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Txtfax1)
        Me.TabPage1.Controls.Add(Me.Txttel1)
        Me.TabPage1.Controls.Add(Me.Txdireccion)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.Txtfax2)
        Me.TabPage1.Controls.Add(Me.Txttel2)
        Me.TabPage1.Controls.Add(Me.CbTipoPrecio)
        Me.TabPage1.Controls.Add(Me.Txtimpuesto)
        Me.TabPage1.Controls.Add(Me.Ckbexcento)
        Me.TabPage1.Controls.Add(Me.ComboBoxAgente)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(648, 204)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'ckFallecido
        '
        Me.ckFallecido.AutoSize = True
        Me.ckFallecido.ForeColor = System.Drawing.Color.Red
        Me.ckFallecido.Location = New System.Drawing.Point(288, 184)
        Me.ckFallecido.Name = "ckFallecido"
        Me.ckFallecido.Size = New System.Drawing.Size(77, 17)
        Me.ckFallecido.TabIndex = 36
        Me.ckFallecido.Text = "Fallecido"
        Me.ckFallecido.UseVisualStyleBackColor = True
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Location = New System.Drawing.Point(552, 140)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(83, 23)
        Me.btnCambiarEstado.TabIndex = 35
        Me.btnCambiarEstado.Text = "Cambiar"
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        '
        'ckNotificaRecibo
        '
        Me.ckNotificaRecibo.AutoSize = True
        Me.ckNotificaRecibo.Location = New System.Drawing.Point(456, 8)
        Me.ckNotificaRecibo.Name = "ckNotificaRecibo"
        Me.ckNotificaRecibo.Size = New System.Drawing.Size(157, 17)
        Me.ckNotificaRecibo.TabIndex = 34
        Me.ckNotificaRecibo.Text = "Envia Recibo al Correo"
        Me.ckNotificaRecibo.UseVisualStyleBackColor = True
        '
        'txtCorreoRecibo
        '
        Me.txtCorreoRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreoRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCorreoRecibo.Enabled = False
        Me.txtCorreoRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoRecibo.ForeColor = System.Drawing.Color.Blue
        Me.txtCorreoRecibo.Location = New System.Drawing.Point(456, 24)
        Me.txtCorreoRecibo.Name = "txtCorreoRecibo"
        Me.txtCorreoRecibo.Size = New System.Drawing.Size(178, 13)
        Me.txtCorreoRecibo.TabIndex = 32
        '
        'ckMAG
        '
        Me.ckMAG.AutoSize = True
        Me.ckMAG.Location = New System.Drawing.Point(456, 166)
        Me.ckMAG.Name = "ckMAG"
        Me.ckMAG.Size = New System.Drawing.Size(179, 17)
        Me.ckMAG.TabIndex = 31
        Me.ckMAG.Text = "Esta Registrado en el MAG"
        Me.ckMAG.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescuentoEspecial)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(456, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 46)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuentos Especiales"
        '
        'txtDescuentoEspecial
        '
        Me.txtDescuentoEspecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoEspecial.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescuentoEspecial.Location = New System.Drawing.Point(96, 19)
        Me.txtDescuentoEspecial.Name = "txtDescuentoEspecial"
        Me.txtDescuentoEspecial.Size = New System.Drawing.Size(62, 20)
        Me.txtDescuentoEspecial.TabIndex = 11
        Me.txtDescuentoEspecial.Text = "0.00"
        Me.txtDescuentoEspecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(76, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 20)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "%"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(10, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(146, 20)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Descuento"
        '
        'ckActualizado
        '
        Me.ckActualizado.AutoSize = True
        Me.ckActualizado.Location = New System.Drawing.Point(190, 185)
        Me.ckActualizado.Name = "ckActualizado"
        Me.ckActualizado.Size = New System.Drawing.Size(92, 17)
        Me.ckActualizado.TabIndex = 28
        Me.ckActualizado.Text = "Actualizado"
        Me.ckActualizado.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(7, 144)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(250, 18)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Correo  Facturacion Electronica"
        '
        'txtCorreoComprobante
        '
        Me.txtCorreoComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreoComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCorreoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoComprobante.ForeColor = System.Drawing.Color.Blue
        Me.txtCorreoComprobante.Location = New System.Drawing.Point(7, 168)
        Me.txtCorreoComprobante.Name = "txtCorreoComprobante"
        Me.txtCorreoComprobante.Size = New System.Drawing.Size(250, 13)
        Me.txtCorreoComprobante.TabIndex = 26
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Location = New System.Drawing.Point(643, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(176, 15)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Motivo Exoneracion"
        Me.Label22.Visible = False
        '
        'cboExoneracion
        '
        Me.cboExoneracion.DisplayMember = "1"
        Me.cboExoneracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExoneracion.DropDownWidth = 400
        Me.cboExoneracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExoneracion.ForeColor = System.Drawing.Color.Blue
        Me.cboExoneracion.Location = New System.Drawing.Point(643, 107)
        Me.cboExoneracion.Name = "cboExoneracion"
        Me.cboExoneracion.Size = New System.Drawing.Size(176, 21)
        Me.cboExoneracion.TabIndex = 24
        Me.cboExoneracion.Visible = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.Location = New System.Drawing.Point(264, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(176, 15)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Tipo Cliente"
        '
        'cboTipoCliente
        '
        Me.cboTipoCliente.DisplayMember = "1"
        Me.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCliente.ForeColor = System.Drawing.Color.Blue
        Me.cboTipoCliente.Items.AddRange(New Object() {"FISICA", "JURIDICA", "DIMEX"})
        Me.cboTipoCliente.Location = New System.Drawing.Point(264, 112)
        Me.cboTipoCliente.Name = "cboTipoCliente"
        Me.cboTipoCliente.Size = New System.Drawing.Size(176, 21)
        Me.cboTipoCliente.TabIndex = 22
        '
        'ck_notificacion
        '
        Me.ck_notificacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ck_notificacion.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetClientes1, "Clientes.notificar", True))
        Me.ck_notificacion.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_notificacion.ForeColor = System.Drawing.Color.Red
        Me.ck_notificacion.Location = New System.Drawing.Point(8, 185)
        Me.ck_notificacion.Name = "ck_notificacion"
        Me.ck_notificacion.Size = New System.Drawing.Size(176, 16)
        Me.ck_notificacion.TabIndex = 21
        Me.ck_notificacion.Text = "Notificar por correo"
        Me.ck_notificacion.UseVisualStyleBackColor = False
        '
        'ckSugerido
        '
        Me.ckSugerido.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckSugerido.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetClientes1, "Clientes.PrecioSugerido", True))
        Me.ckSugerido.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSugerido.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ckSugerido.Location = New System.Drawing.Point(456, 185)
        Me.ckSugerido.Name = "ckSugerido"
        Me.ckSugerido.Size = New System.Drawing.Size(175, 16)
        Me.ckSugerido.TabIndex = 20
        Me.ckSugerido.Text = "Imprimir Precio Sugerido"
        Me.ckSugerido.UseVisualStyleBackColor = False
        '
        'chkbEliminaAgente
        '
        Me.chkbEliminaAgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbEliminaAgente.Location = New System.Drawing.Point(364, 144)
        Me.chkbEliminaAgente.Name = "chkbEliminaAgente"
        Me.chkbEliminaAgente.Size = New System.Drawing.Size(80, 16)
        Me.chkbEliminaAgente.TabIndex = 17
        Me.chkbEliminaAgente.Text = "Sin Agente"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Location = New System.Drawing.Point(264, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Agente Asignado"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Location = New System.Drawing.Point(643, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = " %  de  I.V."
        Me.Label17.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(456, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tipo Precio"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Teléfono"
        '
        'Txtfax1
        '
        Me.Txtfax1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfax1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.fax_01", True))
        Me.Txtfax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfax1.ForeColor = System.Drawing.Color.Blue
        Me.Txtfax1.Location = New System.Drawing.Point(224, 24)
        Me.Txtfax1.Name = "Txtfax1"
        Me.Txtfax1.Size = New System.Drawing.Size(104, 13)
        Me.Txtfax1.TabIndex = 2
        '
        'Txttel1
        '
        Me.Txttel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.Telefono_01", True))
        Me.Txttel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttel1.ForeColor = System.Drawing.Color.Blue
        Me.Txttel1.Location = New System.Drawing.Point(8, 24)
        Me.Txttel1.Name = "Txttel1"
        Me.Txttel1.Size = New System.Drawing.Size(96, 13)
        Me.Txttel1.TabIndex = 0
        '
        'Txdireccion
        '
        Me.Txdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.direccion", True))
        Me.Txdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txdireccion.ForeColor = System.Drawing.Color.Blue
        Me.Txdireccion.Location = New System.Drawing.Point(8, 68)
        Me.Txdireccion.Name = "Txdireccion"
        Me.Txdireccion.Size = New System.Drawing.Size(432, 13)
        Me.Txdireccion.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(224, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Fax (es):"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(432, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Correo Cuentas por Cobrar"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.e_mail", True))
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Blue
        Me.TxtEmail.Location = New System.Drawing.Point(8, 120)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(250, 13)
        Me.TxtEmail.TabIndex = 5
        '
        'Txtfax2
        '
        Me.Txtfax2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfax2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.fax_02", True))
        Me.Txtfax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfax2.ForeColor = System.Drawing.Color.Blue
        Me.Txtfax2.Location = New System.Drawing.Point(344, 24)
        Me.Txtfax2.Name = "Txtfax2"
        Me.Txtfax2.Size = New System.Drawing.Size(96, 13)
        Me.Txtfax2.TabIndex = 3
        '
        'Txttel2
        '
        Me.Txttel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.telefono_02", True))
        Me.Txttel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttel2.ForeColor = System.Drawing.Color.Blue
        Me.Txttel2.Location = New System.Drawing.Point(120, 24)
        Me.Txttel2.Name = "Txttel2"
        Me.Txttel2.Size = New System.Drawing.Size(96, 13)
        Me.Txttel2.TabIndex = 1
        '
        'CbTipoPrecio
        '
        Me.CbTipoPrecio.DisplayMember = "1"
        Me.CbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoPrecio.ForeColor = System.Drawing.Color.Blue
        Me.CbTipoPrecio.Items.AddRange(New Object() {"PRECIO A", "PRECIO B", "PRECIO C", "PRECIO D"})
        Me.CbTipoPrecio.Location = New System.Drawing.Point(456, 64)
        Me.CbTipoPrecio.Name = "CbTipoPrecio"
        Me.CbTipoPrecio.Size = New System.Drawing.Size(176, 21)
        Me.CbTipoPrecio.TabIndex = 7
        '
        'ComboBoxAgente
        '
        Me.ComboBoxAgente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetClientes1, "Clientes.agente", True))
        Me.ComboBoxAgente.DataSource = Me.DataSetClientes1.Usuarios
        Me.ComboBoxAgente.DisplayMember = "Nombre"
        Me.ComboBoxAgente.Location = New System.Drawing.Point(264, 160)
        Me.ComboBoxAgente.Name = "ComboBoxAgente"
        Me.ComboBoxAgente.Size = New System.Drawing.Size(176, 21)
        Me.ComboBoxAgente.TabIndex = 6
        Me.ComboBoxAgente.ValueMember = "Nombre"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Transparent
        Me.TabPage5.Controls.Add(Me.btnIdentificarse)
        Me.TabPage5.Controls.Add(Me.CheckBoxAbrirCredito)
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(648, 204)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Crédito y Descuento"
        '
        'btnIdentificarse
        '
        Me.btnIdentificarse.Location = New System.Drawing.Point(50, 3)
        Me.btnIdentificarse.Name = "btnIdentificarse"
        Me.btnIdentificarse.Size = New System.Drawing.Size(190, 23)
        Me.btnIdentificarse.TabIndex = 2
        Me.btnIdentificarse.Text = "Activar opciones de Credito"
        Me.btnIdentificarse.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Grid_Encargado_Compras)
        Me.TabPage2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(648, 204)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Encargado de Compras"
        '
        'Grid_Encargado_Compras
        '
        Me.Grid_Encargado_Compras.DataMember = "Clientes.Clientesencargadocompras"
        Me.Grid_Encargado_Compras.DataSource = Me.DataSetClientes1
        '
        '
        '
        Me.Grid_Encargado_Compras.EmbeddedNavigator.Name = ""
        Me.Grid_Encargado_Compras.Location = New System.Drawing.Point(4, 5)
        Me.Grid_Encargado_Compras.MainView = Me.GridView2
        Me.Grid_Encargado_Compras.Name = "Grid_Encargado_Compras"
        Me.Grid_Encargado_Compras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.Grid_Encargado_Compras.Size = New System.Drawing.Size(640, 195)
        Me.Grid_Encargado_Compras.TabIndex = 185
        Me.Grid_Encargado_Compras.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdentificacion, Me.colNombre, Me.colTelefono})
        Me.GridView2.GroupPanelText = "Detalle de Cotización"
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowNewItemRow = True
        '
        'colIdentificacion
        '
        Me.colIdentificacion.Caption = "Identificacion"
        Me.colIdentificacion.FieldName = "Identificacion"
        Me.colIdentificacion.FilterInfo = ColumnFilterInfo1
        Me.colIdentificacion.Name = "colIdentificacion"
        Me.colIdentificacion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colIdentificacion.VisibleIndex = 0
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.FilterInfo = ColumnFilterInfo2
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNombre.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "Telefono"
        Me.colTelefono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.FilterInfo = ColumnFilterInfo3
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTelefono.VisibleIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Grid_Ref_Banc)
        Me.TabPage3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(648, 204)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Referencias Bancarias"
        '
        'Grid_Ref_Banc
        '
        Me.Grid_Ref_Banc.DataMember = "Clientes.Clientesreferenciabancaria"
        Me.Grid_Ref_Banc.DataSource = Me.DataSetClientes1
        '
        '
        '
        Me.Grid_Ref_Banc.EmbeddedNavigator.Name = ""
        Me.Grid_Ref_Banc.Location = New System.Drawing.Point(4, 3)
        Me.Grid_Ref_Banc.MainView = Me.GridView1
        Me.Grid_Ref_Banc.Name = "Grid_Ref_Banc"
        Me.Grid_Ref_Banc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.Grid_Ref_Banc.Size = New System.Drawing.Size(640, 197)
        Me.Grid_Ref_Banc.TabIndex = 184
        Me.Grid_Ref_Banc.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSucursal, Me.colBanco, Me.colCuenta, Me.colFecha})
        Me.GridView1.GroupPanelText = ""
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowNewItemRow = True
        '
        'colSucursal
        '
        Me.colSucursal.Caption = "Sucursal"
        Me.colSucursal.FieldName = "Sucursal"
        Me.colSucursal.FilterInfo = ColumnFilterInfo4
        Me.colSucursal.Name = "colSucursal"
        Me.colSucursal.VisibleIndex = 1
        Me.colSucursal.Width = 192
        '
        'colBanco
        '
        Me.colBanco.Caption = "Banco"
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.FilterInfo = ColumnFilterInfo5
        Me.colBanco.Name = "colBanco"
        Me.colBanco.VisibleIndex = 2
        Me.colBanco.Width = 208
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta"
        Me.colCuenta.FieldName = "Cuenta"
        Me.colCuenta.FilterInfo = ColumnFilterInfo6
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.VisibleIndex = 0
        Me.colCuenta.Width = 130
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.FilterInfo = ColumnFilterInfo7
        Me.colFecha.Name = "colFecha"
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 96
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Grid_Ref_Comer)
        Me.TabPage4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(648, 204)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Referencias Comerciales"
        '
        'Grid_Ref_Comer
        '
        Me.Grid_Ref_Comer.DataMember = "Clientes.Clientesreferenciacomercial"
        Me.Grid_Ref_Comer.DataSource = Me.DataSetClientes1
        '
        '
        '
        Me.Grid_Ref_Comer.EmbeddedNavigator.Name = ""
        Me.Grid_Ref_Comer.Location = New System.Drawing.Point(3, 0)
        Me.Grid_Ref_Comer.MainView = Me.GridView3
        Me.Grid_Ref_Comer.Name = "Grid_Ref_Comer"
        Me.Grid_Ref_Comer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        Me.Grid_Ref_Comer.Size = New System.Drawing.Size(640, 200)
        Me.Grid_Ref_Comer.TabIndex = 185
        Me.Grid_Ref_Comer.Text = "GridControl3"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpresa, Me.colTelefono1, Me.colMonto})
        Me.GridView3.GroupPanelText = "Detalle de Cotización"
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowNewItemRow = True
        '
        'colEmpresa
        '
        Me.colEmpresa.Caption = "Empresa"
        Me.colEmpresa.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colEmpresa.FieldName = "Empresa"
        Me.colEmpresa.FilterInfo = ColumnFilterInfo8
        Me.colEmpresa.Name = "colEmpresa"
        Me.colEmpresa.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colEmpresa.VisibleIndex = 0
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colTelefono1
        '
        Me.colTelefono1.Caption = "Telefono"
        Me.colTelefono1.FieldName = "Telefono"
        Me.colTelefono1.FilterInfo = ColumnFilterInfo9
        Me.colTelefono1.Name = "colTelefono1"
        Me.colTelefono1.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTelefono1.VisibleIndex = 1
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo10
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 2
        '
        'ComboBoxRestricciones
        '
        Me.ComboBoxRestricciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.sinrestriccion", True))
        Me.ComboBoxRestricciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRestricciones.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRestricciones.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxRestricciones.Items.AddRange(New Object() {"NO", "SI"})
        Me.ComboBoxRestricciones.Location = New System.Drawing.Point(456, 384)
        Me.ComboBoxRestricciones.Name = "ComboBoxRestricciones"
        Me.ComboBoxRestricciones.Size = New System.Drawing.Size(64, 22)
        Me.ComboBoxRestricciones.TabIndex = 59
        '
        'LabelID_TipoPrecio
        '
        Me.LabelID_TipoPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.tipoprecio", True))
        Me.LabelID_TipoPrecio.Location = New System.Drawing.Point(168, 383)
        Me.LabelID_TipoPrecio.Name = "LabelID_TipoPrecio"
        Me.LabelID_TipoPrecio.Size = New System.Drawing.Size(65, 16)
        Me.LabelID_TipoPrecio.TabIndex = 72
        Me.LabelID_TipoPrecio.Text = "0"
        '
        'TxtID_Usuario
        '
        Me.TxtID_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtID_Usuario.Enabled = False
        Me.TxtID_Usuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtID_Usuario.Location = New System.Drawing.Point(96, 383)
        Me.TxtID_Usuario.Name = "TxtID_Usuario"
        Me.TxtID_Usuario.Size = New System.Drawing.Size(64, 13)
        Me.TxtID_Usuario.TabIndex = 71
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
        Me.Label15.Location = New System.Drawing.Point(0, -5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(658, 40)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Formulario de Clientes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 400)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(648, 56)
        Me.ToolBar1.TabIndex = 71
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
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
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(354, 447)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 16)
        Me.Panel1.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(-8, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(123, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(173, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Nombre, Clave_Interna FROM Usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Adapter_Clientes
        '
        Me.Adapter_Clientes.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Clientes.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Clientes.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Clientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("abierto", "abierto"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("max_credito", "max_credito"), New System.Data.Common.DataColumnMapping("Plazo_credito", "Plazo_credito"), New System.Data.Common.DataColumnMapping("descuento", "descuento"), New System.Data.Common.DataColumnMapping("empresa", "empresa"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("sinrestriccion", "sinrestriccion"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("agente", "agente"), New System.Data.Common.DataColumnMapping("CodMonedaCredito", "CodMonedaCredito"), New System.Data.Common.DataColumnMapping("Cliente_Moroso", "Cliente_Moroso"), New System.Data.Common.DataColumnMapping("PrecioSugerido", "PrecioSugerido"), New System.Data.Common.DataColumnMapping("notificar", "notificar"), New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("IdTipoExoneracion", "IdTipoExoneracion"), New System.Data.Common.DataColumnMapping("TipoCliente", "TipoCliente")})})
        Me.Adapter_Clientes.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Clientes] WHERE (([identificacion] = @Original_identificacion))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 0, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 0, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 0, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 0, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 0, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.[Char], 0, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 0, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 0, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@Cliente_Moroso", System.Data.SqlDbType.Bit, 0, "Cliente_Moroso"), New System.Data.SqlClient.SqlParameter("@PrecioSugerido", System.Data.SqlDbType.Bit, 0, "PrecioSugerido"), New System.Data.SqlClient.SqlParameter("@notificar", System.Data.SqlDbType.Bit, 0, "notificar"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.BigInt, 0, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@IdTipoExoneracion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "IdTipoExoneracion", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TipoCliente", System.Data.SqlDbType.NVarChar, 0, "TipoCliente")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 0, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 0, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 0, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 0, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 0, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.[Char], 0, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 0, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 0, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@Cliente_Moroso", System.Data.SqlDbType.Bit, 0, "Cliente_Moroso"), New System.Data.SqlClient.SqlParameter("@PrecioSugerido", System.Data.SqlDbType.Bit, 0, "PrecioSugerido"), New System.Data.SqlClient.SqlParameter("@notificar", System.Data.SqlDbType.Bit, 0, "notificar"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.BigInt, 0, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@IdTipoExoneracion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "IdTipoExoneracion", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TipoCliente", System.Data.SqlDbType.NVarChar, 0, "TipoCliente"), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_EncargadosCompras
        '
        Me.Adapter_EncargadosCompras.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_EncargadosCompras.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_EncargadosCompras.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_EncargadosCompras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "encargadocompras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono")})})
        Me.Adapter_EncargadosCompras.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM encargadocompras WHERE (Cliente = @Original_Cliente) AND (Identificac" & _
    "ion = @Original_Identificacion) AND (Nombre = @Original_Nombre) AND (Telefono = " & _
    "@Original_Telefono)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 255, "Telefono")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Identificacion, Cliente, Nombre, Telefono FROM encargadocompras"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 255, "Telefono"), New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Referencia_Bancaria
        '
        Me.Adapter_Referencia_Bancaria.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Referencia_Bancaria.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Referencia_Bancaria.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Referencia_Bancaria.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "referenciabancaria", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Sucursal", "Sucursal"), New System.Data.Common.DataColumnMapping("Banco", "Banco"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        Me.Adapter_Referencia_Bancaria.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Sucursal", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sucursal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"), New System.Data.SqlClient.SqlParameter("@Sucursal", System.Data.SqlDbType.VarChar, 255, "Sucursal"), New System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 255, "Banco"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Cliente, Sucursal, Banco, Cuenta, Fecha, Id FROM referenciabancaria"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"), New System.Data.SqlClient.SqlParameter("@Sucursal", System.Data.SqlDbType.VarChar, 255, "Sucursal"), New System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 255, "Banco"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Sucursal", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sucursal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Adapter_Referencia_Comercial
        '
        Me.Adapter_Referencia_Comercial.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adapter_Referencia_Comercial.InsertCommand = Me.SqlInsertCommand4
        Me.Adapter_Referencia_Comercial.SelectCommand = Me.SqlSelectCommand5
        Me.Adapter_Referencia_Comercial.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "referenciacomercial", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        Me.Adapter_Referencia_Comercial.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM referenciacomercial WHERE (Id = @Original_Id) AND (Cliente = @Origina" & _
    "l_Cliente) AND (Empresa = @Original_Empresa) AND (Monto = @Original_Monto) AND (" & _
    "Telefono = @Original_Telefono)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 255, "Telefono"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Cliente, Empresa, Telefono, Monto, Id FROM referenciacomercial"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.Int, 4, "Cliente"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 255, "Telefono"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand6
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AdapterConsecutivo
        '
        Me.AdapterConsecutivo.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterConsecutivo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cliente_No", "Cliente_No")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "select MIN(consecutivo) as Cliente_No from consecutivos where consecutivo not in(" & _
    "select identificacion from Clientes)"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Table.Cliente_No", True))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(6, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "00000000"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelDatosBasicos
        '
        Me.PanelDatosBasicos.BackColor = System.Drawing.Color.Silver
        Me.PanelDatosBasicos.Controls.Add(Me.lblAdvertenciaMoroso)
        Me.PanelDatosBasicos.Controls.Add(Me.Label3)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtobserv)
        Me.PanelDatosBasicos.Controls.Add(Me.Label4)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtnombre)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtcedula)
        Me.PanelDatosBasicos.Controls.Add(Me.Label2)
        Me.PanelDatosBasicos.Location = New System.Drawing.Point(6, 32)
        Me.PanelDatosBasicos.Name = "PanelDatosBasicos"
        Me.PanelDatosBasicos.Size = New System.Drawing.Size(637, 128)
        Me.PanelDatosBasicos.TabIndex = 0
        '
        'lblAdvertenciaMoroso
        '
        Me.lblAdvertenciaMoroso.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAdvertenciaMoroso.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertenciaMoroso.ForeColor = System.Drawing.Color.Red
        Me.lblAdvertenciaMoroso.Location = New System.Drawing.Point(5, 81)
        Me.lblAdvertenciaMoroso.Name = "lblAdvertenciaMoroso"
        Me.lblAdvertenciaMoroso.Size = New System.Drawing.Size(627, 42)
        Me.lblAdvertenciaMoroso.TabIndex = 6
        Me.lblAdvertenciaMoroso.Text = "<<<<<  Cliente Moroso!!! >>>>>"
        Me.lblAdvertenciaMoroso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAdvertenciaMoroso.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(696, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Validar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(696, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 76
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Secuencia, Tabla, Campo_Clave, DescripcionCampo, Accion, Fecha, Usuario, C" & _
    "osto, VentaA, VentaB, VentaC, VentaD FROM Bitacora"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 75, "Tabla"), New System.Data.SqlClient.SqlParameter("@Campo_Clave", System.Data.SqlDbType.VarChar, 75, "Campo_Clave"), New System.Data.SqlClient.SqlParameter("@DescripcionCampo", System.Data.SqlDbType.VarChar, 250, "DescripcionCampo"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 75, "Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 150, "Usuario"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@VentaA", System.Data.SqlDbType.Float, 8, "VentaA"), New System.Data.SqlClient.SqlParameter("@VentaB", System.Data.SqlDbType.Float, 8, "VentaB"), New System.Data.SqlClient.SqlParameter("@VentaC", System.Data.SqlDbType.Float, 8, "VentaC"), New System.Data.SqlClient.SqlParameter("@VentaD", System.Data.SqlDbType.Float, 8, "VentaD")})
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 75, "Tabla"), New System.Data.SqlClient.SqlParameter("@Campo_Clave", System.Data.SqlDbType.VarChar, 75, "Campo_Clave"), New System.Data.SqlClient.SqlParameter("@DescripcionCampo", System.Data.SqlDbType.VarChar, 250, "DescripcionCampo"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 75, "Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 150, "Usuario"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@VentaA", System.Data.SqlDbType.Float, 8, "VentaA"), New System.Data.SqlClient.SqlParameter("@VentaB", System.Data.SqlDbType.Float, 8, "VentaB"), New System.Data.SqlClient.SqlParameter("@VentaC", System.Data.SqlDbType.Float, 8, "VentaC"), New System.Data.SqlClient.SqlParameter("@VentaD", System.Data.SqlDbType.Float, 8, "VentaD"), New System.Data.SqlClient.SqlParameter("@Original_Secuencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Secuencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Campo_Clave", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Campo_Clave", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionCampo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCampo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tabla", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tabla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaA", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaB", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaC", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.BigInt, 8, "Secuencia")})
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Secuencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Secuencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Campo_Clave", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Campo_Clave", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionCampo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCampo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tabla", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tabla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaA", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaB", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaC", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaD", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Bitacora
        '
        Me.Adapter_Bitacora.DeleteCommand = Me.SqlDeleteCommand5
        Me.Adapter_Bitacora.InsertCommand = Me.SqlInsertCommand5
        Me.Adapter_Bitacora.SelectCommand = Me.SqlSelectCommand8
        Me.Adapter_Bitacora.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bitacora", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Secuencia", "Secuencia"), New System.Data.Common.DataColumnMapping("Tabla", "Tabla"), New System.Data.Common.DataColumnMapping("Campo_Clave", "Campo_Clave"), New System.Data.Common.DataColumnMapping("DescripcionCampo", "DescripcionCampo"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("VentaA", "VentaA"), New System.Data.Common.DataColumnMapping("VentaB", "VentaB"), New System.Data.Common.DataColumnMapping("VentaC", "VentaC"), New System.Data.Common.DataColumnMapping("VentaD", "VentaD")})})
        Me.Adapter_Bitacora.UpdateCommand = Me.SqlUpdateCommand5
        '
        'Tex_Accion
        '
        Me.Tex_Accion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Bitacora.Accion", True))
        Me.Tex_Accion.Location = New System.Drawing.Point(496, 408)
        Me.Tex_Accion.Name = "Tex_Accion"
        Me.Tex_Accion.Size = New System.Drawing.Size(152, 20)
        Me.Tex_Accion.TabIndex = 16
        '
        'DataSet_MovimientoCaja1
        '
        Me.DataSet_MovimientoCaja1.DataSetName = "DataSet_MovimientoCaja"
        Me.DataSet_MovimientoCaja1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_MovimientoCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolTipController1
        '
        Me.ToolTipController1.Rounded = True
        Me.ToolTipController1.ShowBeak = True
        Me.ToolTipController1.Style = New DevExpress.Utils.ViewStyle("ToolTip style")
        '
        'Frmcliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 456)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelDatosBasicos)
        Me.Controls.Add(Me.Txtidentificacion)
        Me.Controls.Add(Me.TxtID_Usuario)
        Me.Controls.Add(Me.Tex_Accion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabelID_TipoPrecio)
        Me.Controls.Add(Me.ComboBoxRestricciones)
        Me.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(664, 495)
        Me.MinimumSize = New System.Drawing.Size(664, 456)
        Me.Name = "Frmcliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Clientes"
        CType(Me.DataSetClientes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Grid_Encargado_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Grid_Ref_Banc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Grid_Ref_Comer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosBasicos.ResumeLayout(False)
        Me.PanelDatosBasicos.PerformLayout()
        CType(Me.DataSet_MovimientoCaja1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "variables"

    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = False
    Dim Cedula_Usuario As String
    Dim Nombre_Usuario As String
    Dim Abre_Credito As Boolean
    Public Cod_Cliente_Buscar As Long
    Dim Perfil_Adminiistrador As Boolean


#End Region

    Private Sub BttCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub CargarInformacion()
        ' Establece el tipo de precio a mostrar en el formulario
        ' Estable si el cliente paga impuesto
        ' Establece si el cliente es empresa,  ' Establece si el cliente posee restriccion de cuenta
        Me.CheckBoxAbrirCredito.Checked = False
        Me.CheckBoxRestriccion.Checked = False
        Try
            Dim tip As Integer = Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("tipoprecio")
            Me.CbTipoPrecio.SelectedIndex = tip - 1
            Me.Ckbexcento.Checked = IIf(Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("impuesto") = 0, True, False)
            Me.Ckbempresa.Checked = IIf(Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("empresa") = "SI", True, False)
            CheckBoxRestriccion.Checked = IIf(Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("sinrestriccion") = "SI", True, False)
            CheckBoxAbrirCredito.Checked = IIf(Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("abierto") = "SI", True, False)
            Me.Label9.Text = Me.Txtidentificacion.Text
            CambiarEstadoCredito()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Txtidentificacion.Focus()
    End Sub

    Private Sub CargarTiposExoneracion()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select IdTipoExoneracion, TipoExoneracion from TipoExoneracion", dt, CadenaConexionSeePOS)
        Me.cboExoneracion.DataSource = dt
        Me.cboExoneracion.DisplayMember = "TipoExoneracion"
        Me.cboExoneracion.ValueMember = "IdTipoExoneracion"
    End Sub

    Public CadenaConexionTemp As String = ""
    Private Sub Frmadmincliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establece la conexión a la base de datos al cargar el formulario
        Try

            If Me.txtUsuario.Text <> "" Then
                Select Case Me.CadenaConexionTemp
                    Case "CRE" : SqlConnection1.ConnectionString = CadenaConexionSeePOS()
                    Case "TCR" : SqlConnection1.ConnectionString = CadenaConexionTaller()
                    Case "MCR" : SqlConnection1.ConnectionString = CadenaConexionMascotas()
                End Select
            Else
                SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            End If

            Me.Adapter_Usuarios.Fill(Me.DataSetClientes1, "Usuarios")
            Me.Adapter_Moneda.Fill(Me.DataSetClientes1, "Moneda")

            Me.DataSetClientes1.Clientes.cedulaColumn.DefaultValue = "0"

            PanelDatosBasicos.Enabled = False
            Me.TabPage1.Enabled = False
            Me.TabPage2.Enabled = False
            Me.TabPage3.Enabled = False
            Me.TabPage4.Enabled = False
            Me.TabPage5.Enabled = False


            '********************************************************************************
            'Me.Adapter_Clientes.Fill(Me.DataSetClientes1, "Clientes")
            '/*******************************************************************************
            Me.DataSetClientes1.Clientes.identificacionColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.telefono_02Column.DefaultValue = ""
            Me.DataSetClientes1.Clientes.fax_01Column.DefaultValue = ""
            Me.DataSetClientes1.Clientes.fax_02Column.DefaultValue = ""
            Me.DataSetClientes1.Clientes.e_mailColumn.DefaultValue = ""
            Me.DataSetClientes1.Clientes.abiertoColumn.DefaultValue = "NO"
            Me.DataSetClientes1.Clientes.impuestoColumn.DefaultValue = 100
            Me.DataSetClientes1.Clientes.max_creditoColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.Plazo_creditoColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.descuentoColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.empresaColumn.DefaultValue = "NO"
            Me.DataSetClientes1.Clientes.sinrestriccionColumn.DefaultValue = "NO"
            Me.DataSetClientes1.Clientes.agenteColumn.DefaultValue = ""
            Me.DataSetClientes1.Clientes.observacionesColumn.DefaultValue = ""
            Me.DataSetClientes1.Clientes.direccionColumn.DefaultValue = ""
            Me.DataSetClientes1.Clientes.CodMonedaCreditoColumn.DefaultValue = 1
            Me.DataSetClientes1.Clientes.Cliente_MorosoColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.tipoprecioColumn.DefaultValue = 1
            Me.DataSetClientes1.Clientes.PrecioSugeridoColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.notificarColumn.DefaultValue = 0
            Me.DataSetClientes1.Clientes.IdTipoExoneracionColumn.DefaultValue = 1
            Me.DataSetClientes1.Clientes.TipoClienteColumn.DefaultValue = "Cedula Fisica"

            'Valores por Default referencias bancarias
            Me.DataSetClientes1.referenciabancaria.FechaColumn.DefaultValue = Now
            Me.DataSetClientes1.referenciabancaria.SucursalColumn.DefaultValue = ""
            Me.DataSetClientes1.referenciabancaria.BancoColumn.DefaultValue = ""
            'Valores por Default encargados compra
            Me.DataSetClientes1.encargadocompras.TelefonoColumn.DefaultValue = ""
            'Valores por Default referencias comerciales
            Me.DataSetClientes1.referenciacomercial.TelefonoColumn.DefaultValue = ""
            Me.DataSetClientes1.referenciacomercial.MontoColumn.DefaultValue = 0
            'Me.CambiarEstadoCredito()
            ''''''''''''''''''''''''Valores por defecto de bitácora
            Me.DataSetClientes1.Bitacora.TablaColumn.DefaultValue = "CLIENTES"
            Me.DataSetClientes1.Bitacora.VentaAColumn.DefaultValue = 0
            Me.DataSetClientes1.Bitacora.VentaBColumn.DefaultValue = 0
            Me.DataSetClientes1.Bitacora.VentaCColumn.DefaultValue = 0
            Me.DataSetClientes1.Bitacora.VentaDColumn.DefaultValue = 0
            Me.DataSetClientes1.Bitacora.CostoColumn.DefaultValue = 0
            Me.DataSetClientes1.Bitacora.FechaColumn.DefaultValue = Date.Now
            Me.DataSetClientes1.Bitacora.Campo_ClaveColumn.DefaultValue = "IDENTIFICACION"
            Me.DataSetClientes1.Bitacora.DescripcionCampoColumn.DefaultValue = "REGISTRO DE CLIENTE"

            'CheckBoxAbrirCredito.Enabled = PMU.Others 'ASIGNA SI TIENE PERMISO PARA DAR CREDITO
            ComboBox1.Enabled = CheckBoxAbrirCredito.Enabled
            Me.CargarTiposExoneracion()

            'Me.cboExoneracion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DataSetClientes1, "Clientes.IdTipoExoneracion", True))
            'Me.cboTipoCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClientes1, "Clientes.TipoCliente", True))

            Me.txtUsuario.Focus()

            If Me.txtUsuario.Text <> "" Then
                Me.Loggin_Usuario()
                Me.Busca_Clientes(Me.Cod_Cliente_Buscar)
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

        'Txtidentificacion.Text = CDbl(cConexion.slqExecuteScalar(sqlConexion, "SELECT MAX(identificacion) FROM Clientes") + 1)
    End Sub
    Private Sub Nuevos()
        Nuevo_cliente()
    End Sub
    Function Registrar_Anulacion_cliente(ByVal Anular As Boolean) As Boolean
        Dim Cx As New Conexion
        Try
            'If Anular = True Then
            '    Cx.UpdateRecords("Clientes", "Anulado = 1", "Identificacion = " & BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion"), "SeePos")
            'Else
            '    Cx.UpdateRecords("Clientes", "Anulado = 0", "Identificacion = " & BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion"), "SeePos")
            'End If

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
    Private Sub Eliminar()
        Dim Resultado As String
        Dim rs As SqlDataReader
        Dim cant As Integer
        Try
            If Me.Txtidentificacion.Text <> "" Then

                If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()

                cant = CConexion.SlqExecuteScalar(Me.SqlConnection1, "SELECT COUNT(Id) AS Pendientes FROM Ventas  WHERE  (Cod_Cliente = " & Txtidentificacion.Text & ") AND (FacturaCancelado = 0) AND (Anulado = 0)")
                Me.SqlConnection1.Close()

                If cant > 0 Then
                    MsgBox("Este Cliente tiene " & cant.ToString & " Facturas pendientes de Pago, no puede eliminarse", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If


                If MessageBox.Show("Desea Eliminar el Cliente", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub


                ''ingreso a la bitacora
                Me.DataSetClientes1.Bitacora.FechaColumn.DefaultValue = Date.Now
                Me.DataSetClientes1.Bitacora.UsuarioColumn.DefaultValue = ""

                Me.BindingContext(Me.DataSetClientes1, "Bitacora").CancelCurrentEdit()
                Me.BindingContext(Me.DataSetClientes1, "Bitacora").EndCurrentEdit()
                Me.BindingContext(Me.DataSetClientes1, "Bitacora").AddNew()
                Me.BindingContext(Me.DataSetClientes1, "Bitacora").Current("Usuario") = Me.usua.Nombre
                Me.BindingContext(Me.DataSetClientes1, "Bitacora").Current("DescripcionCampo") = Me.Txtnombre.Text & " / " & Me.Txtidentificacion.Text
                Me.Tex_Accion.Text = "CLIENTE ELIMINADO"
                Me.BindingContext(Me.DataSetClientes1, "Bitacora").EndCurrentEdit()

                Me.BindingContext(Me.DataSetClientes1, "Clientes").RemoveAt(Me.BindingContext(Me.DataSetClientes1, "Clientes").Position)
                Me.BindingContext(Me.DataSetClientes1, "Clientes").EndCurrentEdit()

                Eliminando = True


                If Me.RegistrarCliente Then
                    MessageBox.Show("El cliente fue Eliminado Satisfactoriamente", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DataSetClientes1.encargadocompras.Clear()
                    Me.DataSetClientes1.referenciabancaria.Clear()
                    Me.DataSetClientes1.referenciacomercial.Clear()
                    Me.DataSetClientes1.Clientes.Clear()
                End If



            Else
                MessageBox.Show("No hay cliente a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Nuevo_cliente()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Ckbexcento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckbexcento.CheckedChanged
        'La exoneracion del impuesto de ventas es total
        If Me.Ckbexcento.Checked = True Then
            'Inhabilitar el control Txtimpuesto que contiene el impuesto
            Me.Txtimpuesto.Enabled = False
            Me.Txtimpuesto.Text = 0
            'La exoneracion del impuesto de ventas es parcial o inexistente
        Else
            'Habilitar el control Txtimpuesto que contiene el impuesto   
            Me.Txtimpuesto.Enabled = True
            Me.Txtimpuesto.Text = 100
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Me.Validar_nuevo()
            Case 2 : If PMU.Find Then Me.Busca_Clientes() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If MessageBox.Show("¿Desea Cerrar el Módulo de Clientes?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub
    Private Sub Imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Reporte_Clientes As New Reporte_Cliente
            Dim visor As New frmVisorReportes
            Reporte_Clientes.SetParameterValue(0, CDbl(Label9.Text))
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Reporte_Clientes)
            visor.rptViewer.Visible = True
            Reporte_Clientes = Nothing
            visor.ShowDialog()
            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Validar_nuevo()
        Try
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False
                PanelDatosBasicos.Enabled = True

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.txtUsuario.Focus()
                strMensaje = ""
            Else
                If Me.BindingContext(Me.DataSetClientes1, "Clientes").Count = 0 Then 'Si  no se ha aregadoningún cliente
                    Me.BindingContext(Me.DataSetClientes1, "Clientes").CancelCurrentEdit()
                    PanelDatosBasicos.Enabled = False
                    Me.DataSetClientes1.encargadocompras.Clear()
                    Me.DataSetClientes1.referenciabancaria.Clear()
                    Me.DataSetClientes1.referenciacomercial.Clear()
                    Me.DataSetClientes1.Clientes.Clear()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()
                    nuevo = False
                    Exit Sub
                End If

                If MessageBox.Show("Desea Guardar los datos de este Cliente", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Registrar() ' se guarda en la base de datos
                    Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True
                Else
                    Me.BindingContext(Me.DataSetClientes1, "Clientes").CancelCurrentEdit()
                    Me.DataSetClientes1.encargadocompras.Clear()
                    Me.DataSetClientes1.referenciabancaria.Clear()
                    Me.DataSetClientes1.referenciacomercial.Clear()
                    Me.DataSetClientes1.Clientes.Clear()
                    PanelDatosBasicos.Enabled = False
                    Me.TabPage1.Enabled = False
                    Me.TabPage2.Enabled = False
                    Me.TabPage3.Enabled = False
                    Me.TabPage4.Enabled = False
                    Me.TabPage5.Enabled = False
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    nuevo = False
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Ckbempresa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ckbempresa.Click
        If Me.Ckbempresa.Checked = True Then
            MessageBox.Show("El cliente en cuestión se ha definido como una Empresa, Asociación, Compañia, ... por lo que es necesario que " _
                & "se indique las referencias de las personas que son autorizadas para efectuar las compras de crédito" & vbCrLf _
                & "Cuando la opcion Empresa, Asociación, Compañia, ... esta desmarcada se indica que el cliente es una persona física por lo que no es requerido " _
                & " listar compradores ya que se establece que la persona es la que siempre efectuará las compras", "information...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Loggin_Usuario()
        Try
            If Me.BindingContext(Me.DataSetClientes1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSetClientes1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    txtNombreUsuario.Text = Usua("Nombre")
                    Me.TxtID_Usuario.Text = Usua("Cedula")
                    usuario_autorizado = txtNombreUsuario.Text
                    Me.Nombre_Usuario = Usua("Nombre")
                    Me.Cedula_Usuario = Usua("Cedula")
                    Me.DataSetClientes1.Clientes.usuarioColumn.DefaultValue = Usua("Cedula")
                    Me.DataSetClientes1.Clientes.nombreusuarioColumn.DefaultValue = Usua("Nombre")
                    strMensaje = ""

                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                    'CheckBoxAbrirCredito.Enabled = PMU.Others 'ASIGNA SI TIENE PERMISO PARA DAR CREDITO
                    ComboBox1.Enabled = CheckBoxAbrirCredito.Enabled

                    Me.PanelDatosBasicos.Enabled = True
                    Me.TabPage1.Enabled = True
                    Me.TabPage2.Enabled = True
                    Me.TabPage3.Enabled = True
                    Me.TabPage4.Enabled = True
                    Me.TabPage5.Enabled = True
                    Me.CheckBoxAbrirCredito.Checked = False
                    txtUsuario.Enabled = False 'se inabilita el campo de la contraseña
                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8
                    Me.ToolBar1.Buttons(3).Enabled = True
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = True
                    'Validar si el usuario puede o no anular una cotización
                    Abre_Credito = PMU.Others
                    Txtlimitecredito.Enabled = PMU.Others
                    Txtplazocredito.Enabled = PMU.Others
                    Txtdescuento.Enabled = PMU.Others
                    CheckBoxRestriccion.Enabled = PMU.Others
                    Cbcredito.Enabled = PMU.Others
                    Perfil_Adminiistrador = PMU.Others
                    Nuevo_cliente()
                    DataSetClientes1.Tables("Table").Clear()
                    AdapterConsecutivo.Fill(DataSetClientes1, "Table")
                    Txtidentificacion.Text = Label9.Text
                    CambiarEstadoCredito()
                    txtNombreUsuario.Text = Usua("Nombre")
                    TxtID_Usuario.Text = Usua("Cedula")
                    '---------------------------------------------------
                    ToolTipController1.AutoPopDelay = 5000
                    ToolTipController1.InitialDelay = 1000
                    ToolTipController1.ReshowDelay = 500
                    ToolTipController1.SetToolTip(chkbEliminaAgente, "Si desea eliminar el agente asignado marque esta Ninguno")
                    '---------------------------------------------------

                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    txtUsuario.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nuevo_cliente()
        Try
            '            Me.BindingContext(Me.DataSetClientes1, "Clientes").EndCurrentEdit()
            Me.BindingContext(Me.DataSetClientes1, "Clientes").AddNew()
            Me.BindingContext(Me.DataSetClientes1, "Clientes").CancelCurrentEdit()
            Me.BindingContext(Me.DataSetClientes1, "Clientes").AddNew()

            Me.nuevo = True
            Me.CbTipoPrecio.SelectedIndex = 0
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Me.ToolBar1.Buttons(3).Enabled = False

            Me.ToolBar1.Buttons(0).Enabled = True
            Me.ToolBar1.Buttons(1).Enabled = True
            Me.ToolBar1.Buttons(2).Enabled = True

            Me.Txtnombre.Focus()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then Loggin_Usuario()
    End Sub


    Private Sub Ckbempresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckbempresa.CheckedChanged
        If Me.Ckbempresa.Checked Then
            Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("Empresa") = "SI"
        Else
            Me.BindingContext(Me.DataSetClientes1, "Clientes").Current("Empresa") = "NO"
        End If
    End Sub

    Private Sub Cbtipoprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTipoPrecio.SelectedIndexChanged
        Select Case CbTipoPrecio.SelectedIndex
            Case -1 : CbTipoPrecio.SelectedIndex = 0
            Case Else : LabelID_TipoPrecio.Text = CbTipoPrecio.SelectedIndex + 1
        End Select
    End Sub

    Private Function NoDebeUsarMag(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from NoMAG where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Registrar()
        Try

            'Me.Label9.Text = Me.Txtcedula.Text

            Dim Pasa As Boolean = True

            If Len(Me.Txtnombre.Text) = 0 Then
                ErrorProvider1.SetError(Txtnombre, "Debe de Digitar el nombre del Cliente")
                Pasa = False
            Else
                ErrorProvider1.SetError(Txtnombre, "")
            End If

            If Len(Me.Txtcedula.Text) = 0 Then
                ErrorProvider1.SetError(Txtcedula, "Debe de Digitar el nombre del Cliente")
                Pasa = False
            Else
                ErrorProvider1.SetError(Txtcedula, "")
            End If

            If Len(Me.Txttel1.Text) = 0 Then
                ErrorProvider1.SetError(Txttel1, "Debe de Digitar un número de teléfono del Cliente")
                Pasa = False
            Else
                ErrorProvider1.SetError(Txttel1, "")
            End If

            If Len(Me.Txdireccion.Text) = 0 Then
                ErrorProvider1.SetError(Txdireccion, "Debe de Digitar la dirección del Cliente")
                Pasa = False
            Else
                ErrorProvider1.SetError(Txdireccion, "")
            End If

            If Pasa = False Then
                MsgBox("No se puede realizar la operacion.", MsgBoxStyle.Exclamation, "Faltan datos por Ingresar!!!")
                Exit Sub
            End If

            If MessageBox.Show("¿Desea Registrar este Cliente?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Exit Sub
            End If

            Me.DataSetClientes1.Bitacora.FechaColumn.DefaultValue = Date.Now
            Me.BindingContext(Me.DataSetClientes1, "Bitacora").EndCurrentEdit()
            Me.BindingContext(Me.DataSetClientes1, "Bitacora").AddNew()
            Me.BindingContext(Me.DataSetClientes1, "Bitacora").Current("Usuario") = Me.usuario_autorizado
            Me.BindingContext(Me.DataSetClientes1, "Bitacora").Current("DescripcionCampo") = Me.Txtnombre.Text & " / " & Me.Txtidentificacion.Text & " / CREDITO " & IIf(Me.CheckBoxAbrirCredito.Checked = True, "SI", "NO")

            'If Me.CheckBoxAnular.Checked = True Then
            '    Registrar_Anulacion_cliente(True)
            'Else
            '    Registrar_Anulacion_cliente(False)
            'End If

            If nuevo Then
                Me.DataSetClientes1.Tables("Table").Clear()
                Me.AdapterConsecutivo.Fill(Me.DataSetClientes1, "Table")
                Txtidentificacion.Text = Me.Label9.Text
                Me.Tex_Accion.Text = "CLIENTE INGRESADO"

            ElseIf Me.Eliminando Then
                Me.Tex_Accion.Text = "CLIENTE ELIMINADO"

            Else
                Me.Tex_Accion.Text = "CLIENTE ACTUALIZADO" & IIf(Me.CheckBoxRestriccion.Checked = True, " SIN RESTRI. ACTVADO", "")
            End If

            Me.BindingContext(Me.DataSetClientes1, "Bitacora").EndCurrentEdit()

            BindingContext(Me.DataSetClientes1, "Clientes").Current("nombreusuario") = txtNombreUsuario.Text
            BindingContext(Me.DataSetClientes1, "Clientes").Current("Usuario") = TxtID_Usuario.Text

            BindingContext(Me.DataSetClientes1, "Clientes").Current("IdTipoExoneracion") = Me.cboExoneracion.SelectedValue
            BindingContext(Me.DataSetClientes1, "Clientes").Current("TipoCliente") = Me.cboTipoCliente.Text
            BindingContext(Me.DataSetClientes1, "Clientes").Current("Abierto") = Me.Cbcredito.Text

            BindingContext(DataSetClientes1, "Clientes").EndCurrentEdit()
            BindingContext(DataSetClientes1, "Clientes.Clientesencargadocompras").EndCurrentEdit()
            BindingContext(DataSetClientes1, "Clientes.Clientesreferenciabancaria").EndCurrentEdit()
            BindingContext(DataSetClientes1, "Clientes.Clientesreferenciacomercial").EndCurrentEdit()

            If Me.RegistrarCliente() Then 'se registra en la base de datos then
                Try

                    If Me.NoDebeUsarMag(BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion")) = True Then
                        Me.ckMAG.Checked = False
                    End If

                    Dim db As New GestioDatos
                    db.Ejecuta("Update Clientes set EnviarRecibo = " & IIf(Me.ckNotificaRecibo.Checked = True, 1, 0) & ", Fallecido = " & IIf(Me.ckFallecido.Checked = True, 1, 0) & ", CorreoRecibo = '" & Me.txtCorreoRecibo.Text & "', MAG = " & IIf(Me.ckMAG.Checked = True, 1, 0) & ", Actualizado = " & IIf(Me.ckActualizado.Checked = True, 1, 0) & ", CorreoComprobante = '" & Me.txtCorreoComprobante.Text & "', OrdenCompra = " & IIf(Me.ckOrdendeCompra.Checked = True, 1, 0) & ", DescuentoEspecial = " & Me.txtDescuentoEspecial.Text & " Where Identificacion = '" & BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion") & "'")

                Catch ex As Exception
                End Try

                Me.DataSetClientes1.AcceptChanges()

                Me.DataSetClientes1.encargadocompras.Clear()
                Me.DataSetClientes1.referenciabancaria.Clear()
                Me.DataSetClientes1.referenciacomercial.Clear()
                Me.DataSetClientes1.Clientes.Clear()

                'Me.CheckBoxAbrirCredito.Checked = False
                'Me.CheckBoxRestriccion.Checked = False

                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True

                Me.PanelDatosBasicos.Enabled = False
                Me.TabPage1.Enabled = False
                Me.TabPage2.Enabled = False
                Me.TabPage3.Enabled = False
                Me.TabPage4.Enabled = False
                Me.TabPage5.Enabled = False

                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Focus()

                nuevo = False
                Me.ToolBar1.Buttons(2).Enabled = False
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(2).Enabled = False
                strMensaje = "ok"
                Me.chkbEliminaAgente.Checked = False

            Else
                MsgBox("Error al guardar cliente", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True

            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message)
        End Try

    End Sub

    Function RegistrarCliente() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.SqlInsertCommand1.Transaction = Trans
            Me.SqlUpdateCommand1.Transaction = Trans
            Me.SqlDeleteCommand1.Transaction = Trans

            Me.SqlInsertCommand2.Transaction = Trans
            Me.SqlUpdateCommand2.Transaction = Trans
            Me.SqlDeleteCommand2.Transaction = Trans

            Me.SqlInsertCommand3.Transaction = Trans
            Me.SqlUpdateCommand3.Transaction = Trans
            Me.SqlDeleteCommand3.Transaction = Trans

            Me.SqlInsertCommand4.Transaction = Trans
            Me.SqlUpdateCommand4.Transaction = Trans
            Me.SqlDeleteCommand4.Transaction = Trans

            Me.Adapter_Bitacora.SelectCommand.Transaction = Trans
            Me.Adapter_Bitacora.InsertCommand.Transaction = Trans
            Me.Adapter_Bitacora.DeleteCommand.Transaction = Trans
            Me.Adapter_Bitacora.UpdateCommand.Transaction = Trans

            Me.Adapter_Clientes.Update(Me.DataSetClientes1, "Clientes")
            Me.Adapter_EncargadosCompras.Update(Me.DataSetClientes1, "encargadocompras")
            Me.Adapter_Referencia_Bancaria.Update(Me.DataSetClientes1, "referenciabancaria")
            Me.Adapter_Referencia_Comercial.Update(Me.DataSetClientes1, "referenciacomercial")

            Me.Adapter_Bitacora.Update(Me.DataSetClientes1, "Bitacora")

            Me.Eliminando = False
            Me.nuevo = False
            usuario_autorizado = ""

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try

    End Function

    Private Sub Txtemail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEmail.Validating
        'If Me.TxtEmail.Text <> "" Then ' si hay algo digitado en el campo e-mail
        '    Dim parte1 As Integer
        '    Dim parte2 As Integer
        '    Dim parte3 As Integer
        '    parte1 = TxtEmail.Text.IndexOf("@") 'almacena la cantidad de caracteres hasta llegar al @
        '    parte2 = TxtEmail.Text.IndexOf(".") 'almacena la cantidad de caracteres hasta llegar al "."
        '    parte3 = TxtEmail.Text.Length ' almacena la cantidad total de caracteres de la cadena
        '    If (Not (parte1 >= 3 And parte2 >= 6 And parte3 >= 9)) Then 'si antes del @ hay menos de 3 carcteres y antes del punto hay  menos de 6 y si toda la cadena tiene menos de 9 caracteres
        '        ErrorProvider1.SetError(sender, "Digite un correo electrónico válido")
        '        e.Cancel = True
        '    Else
        '        ErrorProvider1.SetError(sender, "")
        '    End If
        'End If
    End Sub

    Private Sub Txtidentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtidentificacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then SendKeys.Send("{TAB}")

        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcedula.KeyPress

        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txttel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttel1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub


    Private Sub Txttel2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttel2.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub


    Private Sub Txtfax1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfax1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txtfax2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfax2.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub
    Private Sub Txtimpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtimpuesto.KeyPress
        ' valida que en este campo solo se digiten numeros y/o "-"
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then _
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = ".") Then e.Handled = True
    End Sub
    Private Sub Txtidentificacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtidentificacion.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Busca_Clientes()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Busca_Clientes(Optional ByVal _Identificacion As String = "")
        Try
            Dim cFunciones As New cFunciones
            If _Identificacion = "" Then
                Me.Cod_Cliente_Buscar = cFunciones.BuscarDatosClientes("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")
            Else
                Me.Cod_Cliente_Buscar = _Identificacion
            End If

            If Cod_Cliente_Buscar = 0 Then Exit Sub
            Me.BindingContext(Me.DataSetClientes1, "Clientes").CancelCurrentEdit()
            Me.DataSetClientes1.encargadocompras.Clear()
            Me.DataSetClientes1.referenciabancaria.Clear()
            Me.DataSetClientes1.referenciacomercial.Clear()
            Me.DataSetClientes1.Clientes.Clear()
            If nuevo Then nuevo = False
            LlenarCliente(Cod_Cliente_Buscar)

            Me.cboExoneracion.SelectedValue = BindingContext(Me.DataSetClientes1, "Clientes").Current("IdTipoExoneracion")
            Me.cboTipoCliente.Text = BindingContext(Me.DataSetClientes1, "Clientes").Current("TipoCliente")

            Me.CargarInformacion()
            Me.PanelDatosBasicos.Enabled = True
            Me.TabPage1.Enabled = True
            Me.TabPage2.Enabled = True
            Me.TabPage3.Enabled = True
            Me.TabPage4.Enabled = True
            Me.TabPage5.Enabled = True

            Me.Grid_Encargado_Compras.Enabled = True
            Me.Grid_Ref_Banc.Enabled = True
            Me.Grid_Ref_Comer.Enabled = True
            strMensaje = ""

            If _Identificacion = "" Then
                If usua.Abrir_Credito Then
                    'Me.ComboBox1.Enabled = True
                    Me.Txtlimitecredito.Enabled = True
                    Me.Txtplazocredito.Enabled = True

                Else
                    'Me.ComboBox1.Enabled = False
                    Me.Txtlimitecredito.Enabled = False
                    Me.Txtplazocredito.Enabled = False

                End If
            End If

            ' Me.Validar_nuevo()


            'If usua.Perfil = "ADMINISTRADOR" Then
            If PMU.Others Then
                Txtlimitecredito.Enabled = True
                Txtplazocredito.Enabled = True
                Txtdescuento.Enabled = True
                Me.CheckBoxRestriccion.Enabled = True
                'Cbcredito.Enabled = True
            Else
                Txtlimitecredito.Enabled = False
                Txtplazocredito.Enabled = False
                Txtdescuento.Enabled = False
                CheckBoxRestriccion.Enabled = False
                'Cbcredito.Enabled = False
            End If

            Me.ToolBar1.Buttons(1).Enabled = True
            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True


            ComboBox1.Enabled = False
            Txtplazocredito.Enabled = False
            Txtlimitecredito.Enabled = False
            Ckbempresa.Enabled = False
            CheckBoxRestriccion.Enabled = False
            'Cbcredito.SelectedIndex = 0
            Cbcredito.Text = "NO"
            Me.Cbcredito.Enabled = False
            Txtdescuento.Enabled = False
            Me.CheckBoxMoroso.Checked = False
            Me.Grid_Encargado_Compras.Enabled = True
            Me.ComboBox1.Enabled = False
            Me.Txtlimitecredito.Enabled = False
            Me.Txtplazocredito.Enabled = False

            Me.CargarInformacion()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Cliente_Moroso, Anulado, OrdenCompra, CorreoComprobante, Actualizado, DescuentoEspecial, MAG, EnviarRecibo, CorreoRecibo, Fallecido from Clientes where identificacion = " & Cod_Cliente_Buscar, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.ckMAG.Checked = CBool(dt.Rows(0).Item("MAG"))
                Me.ckOrdendeCompra.Checked = CBool(dt.Rows(0).Item("OrdenCompra"))
                Me.ckActualizado.Checked = CBool(dt.Rows(0).Item("Actualizado"))
                Me.txtCorreoComprobante.Text = dt.Rows(0).Item("CorreoComprobante")
                Me.txtDescuentoEspecial.Text = dt.Rows(0).Item("DescuentoEspecial")
                Me.CheckBoxAnular.Checked = dt.Rows(0).Item("Anulado")
                Me.lblAdvertenciaMoroso.Visible = CBool(dt.Rows(0).Item("Cliente_Moroso"))
                Me.ckNotificaRecibo.Checked = CBool(dt.Rows(0).Item("EnviarRecibo"))
                Me.ckFallecido.Checked = CBool(dt.Rows(0).Item("Fallecido"))
                Me.txtCorreoRecibo.Text = dt.Rows(0).Item("CorreoRecibo")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LlenarCliente(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            '''''''''LLENAR CLIENTE''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Clientes WHERE (identificacion = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.VarChar))

            cmdv.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSetClientes1, "Clientes")


            '''''''''LLENAR REFERENCIAS BANCARIAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM referenciabancaria WHERE (Cliente = @Id_Factura) "

            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.VarChar))

            cmd.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DataSetClientes1.referenciabancaria)


            '''''''''LLENAR REFERENCIAS COMERCIALES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ' Creamos el comando para la consulta
            Dim cmf As SqlCommand = New SqlCommand
            sel = "SELECT * FROM referenciacomercial WHERE (Cliente = @Id_Factura) "

            cmf.CommandText = sel
            cmf.Connection = cnnv
            cmf.CommandType = CommandType.Text
            cmf.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmf.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.VarChar))

            cmf.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dc As New SqlDataAdapter
            dc.SelectCommand = cmf
            ' Llenamos la tabla
            dc.Fill(Me.DataSetClientes1.referenciacomercial)


            '''''''''LLENAR ENCARGADOS DE COMPRAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ' Creamos el comando para la consulta
            Dim cme As SqlCommand = New SqlCommand
            sel = "SELECT * FROM encargadocompras WHERE (Cliente = @Id_Factura) "

            cme.CommandText = sel
            cme.Connection = cnnv
            cme.CommandType = CommandType.Text
            cme.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cme.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.VarChar))

            cme.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim db As New SqlDataAdapter
            db.SelectCommand = cme
            ' Llenamos la tabla
            db.Fill(Me.DataSetClientes1.encargadocompras)


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub


    Private Sub Grid_Encargado_Compras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid_Encargado_Compras.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Encargado_Compras()
        End If
    End Sub
    Private Sub Eliminar_Encargado_Compras()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesencargadocompras").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este de compras?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesencargadocompras").RemoveAt(Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesencargadocompras").Position)
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesencargadocompras").EndCurrentEdit()
                Else
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesencargadocompras").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Encargados de compra para eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Eliminar_Referencia_Bancaria()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciabancaria").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar esta Referencia Bancaria?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciabancaria").RemoveAt(Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciabancaria").Position)
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciabancaria").EndCurrentEdit()
                Else
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciabancaria").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Referencias Bancarias para eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Eliminar_Referencia_Comercial()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciacomercial").Count > 0 Then  ' si hay ubicaciones
                resp = MessageBox.Show("¿Desea eliminar esta Referencia Comercial?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciacomercial").RemoveAt(Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciacomercial").Position)
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciacomercial").EndCurrentEdit()
                Else
                    Me.BindingContext(Me.DataSetClientes1, "Clientes.Clientesreferenciacomercial").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Referencias Comerciales para eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Grid_Ref_Banc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid_Ref_Banc.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.Eliminar_Referencia_Bancaria()
        End If
    End Sub
    Private Sub Grid_Ref_Comer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid_Ref_Comer.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.Eliminar_Referencia_Comercial()
        End If
    End Sub
    Private Sub CambiarEstadoCredito()
        If Me.CheckBoxAbrirCredito.Checked = True Then
            ComboBox1.Enabled = True
            Txtplazocredito.Enabled = True
            Txtlimitecredito.Enabled = True
            Ckbempresa.Enabled = True
            CheckBoxRestriccion.Enabled = True
            Me.Cbcredito.Text = "SI"
            Me.Cbcredito.Enabled = True
            'Cbcredito.SelectedIndex = 1
            Txtdescuento.Enabled = True
            Me.CheckBoxMoroso.Enabled = True
            Me.Grid_Encargado_Compras.Enabled = True
            Me.ComboBox1.Enabled = True
            Me.Txtlimitecredito.Enabled = True
            Me.Txtplazocredito.Enabled = True
            Me.Txtplazocredito.Focus()
        Else
            ComboBox1.Enabled = False
            Txtplazocredito.Enabled = False
            Txtlimitecredito.Enabled = False
            Ckbempresa.Enabled = False
            CheckBoxRestriccion.Enabled = False
            'Cbcredito.SelectedIndex = 0
            Cbcredito.Text = "NO"
            Me.Cbcredito.Enabled = False
            Txtdescuento.Enabled = False
            Me.CheckBoxMoroso.Checked = False
            Me.Grid_Encargado_Compras.Enabled = True
            Me.ComboBox1.Enabled = False
            Me.Txtlimitecredito.Enabled = False
            Me.Txtplazocredito.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAbrirCredito.CheckedChanged
        CambiarEstadoCredito()
    End Sub
    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtnombre.KeyDown, Txtcedula.KeyDown, Txtobserv.KeyDown, Txttel1.KeyDown, Txttel2.KeyDown, Txtfax1.KeyDown, Txtfax2.KeyDown, Txdireccion.KeyDown, TxtEmail.KeyDown, ComboBoxAgente.KeyDown, Txtobserv.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                Me.ComboBoxAgente.SelectedIndex = -1
            Case Keys.Enter
                Me.Validacion_Datos()
                If sender.name = Txtobserv.Name Then
                    TabPage1.Visible = True
                    TabControl1.TabPages(0).Visible = True
                    Me.Txttel1.Focus()
                Else
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub

    Private Sub Txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txtnombre.Validating
        If Len(Me.Txtnombre.Text) = 0 Then
            ErrorProvider1.SetError(sender, "Debe de Digitar el nombre del Cliente")
            'e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub
    Private Sub Ckbrestriccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxRestriccion.CheckedChanged
        'Me.ComboBoxRestricciones.SelectedIndex = IIf(Me.CheckBoxRestriccion.Checked = True, 1, 0)
        Me.ComboBoxRestricciones.Text = IIf(Me.CheckBoxRestriccion.Checked = True, "SI", "NO")
    End Sub
    Private Sub TxtBoxNumericos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtplazocredito.KeyPress, Txtlimitecredito.KeyPress, Txtdescuento.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ComboBoxAgente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxAgente.KeyPress
        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Or Not (e.KeyChar = Convert.ToChar(Keys.Enter)) Then e.Handled = True
    End Sub

    Private Sub Grid_Ref_Banc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid_Ref_Banc.Click
        Me.BindingContext(Me.DataSetClientes1, "Clientes").EndCurrentEdit()
    End Sub
    Private Sub Validacion_Datos()
        Me.TabPage2.Enabled = False
        Me.TabPage3.Enabled = False
        Me.TabPage4.Enabled = False

        If Len(Me.Txtnombre.Text) = 0 Then
            ErrorProvider1.SetError(Txtnombre, "Debe de Digitar el nombre del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txtnombre, "")
        End If

        If Len(Me.Txtcedula.Text) = 0 Then
            ErrorProvider1.SetError(Txtcedula, "Debe de Digitar el nombre del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txtcedula, "")
        End If

        If Len(Me.Txttel1.Text) = 0 Then
            ErrorProvider1.SetError(Txttel1, "Debe de Digitar un número de teléfono del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txttel1, "")
        End If

        If Len(Me.Txtfax1.Text) = 0 Then
            ErrorProvider1.SetError(Txtfax1, "Debe de Digitar un número de Fax del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txtfax1, "")
        End If

        If Len(Me.Txdireccion.Text) = 0 Then
            ErrorProvider1.SetError(Txdireccion, "Debe de Digitar la dirección del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txdireccion, "")
        End If

        Me.TabPage2.Enabled = True
        Me.TabPage3.Enabled = True
        Me.TabPage4.Enabled = True
        Me.BindingContext(Me.DataSetClientes1, "Clientes").EndCurrentEdit()
    End Sub
    Private Sub TabPage_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles TabPage2.ChangeUICues, TabPage3.ChangeUICues, TabPage4.ChangeUICues
        Validacion_Datos()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txtplazocredito.Focus()
        End If
    End Sub

    Private Sub Txtplazocredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtplazocredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txtlimitecredito.Focus()
        End If
    End Sub

    Private Sub Txtlimitecredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtlimitecredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txtdescuento.Focus()
        End If
    End Sub

    Private Sub chkbEliminaAgente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbEliminaAgente.CheckedChanged
        If strMensaje = "" Then


            If Me.BindingContext(DataSetClientes1, "Clientes").Count > 0 Then
                If Me.chkbEliminaAgente.Checked = True Then

                    ToolTipController1.AutoPopDelay = 5000
                    ToolTipController1.InitialDelay = 1000
                    ToolTipController1.ReshowDelay = 500
                    ToolTipController1.SetToolTip(chkbEliminaAgente, "Si desea agregar un agente a este cliente desmarque esta opción")
                    Me.BindingContext(DataSetClientes1, "Clientes").Current("agente") = ""
                    Me.ComboBoxAgente.Enabled = False
                Else

                    ToolTipController1.AutoPopDelay = 5000
                    ToolTipController1.InitialDelay = 1000
                    ToolTipController1.ReshowDelay = 500
                    ToolTipController1.SetToolTip(chkbEliminaAgente, "Si desea eliminar el agente asignado marque esta Ninguno")
                    Me.BindingContext(DataSetClientes1, "Clientes").Current("agente") = Me.ComboBoxAgente.Text
                    Me.ComboBoxAgente.Enabled = True
                End If

            Else
                MsgBox("No hay suficientes datos para realizar esta operacion!!", MsgBoxStyle.Critical, "Mensaje...")

            End If
        Else

            ToolTipController1.AutoPopDelay = 5000
            ToolTipController1.InitialDelay = 1000
            ToolTipController1.ReshowDelay = 500
            ToolTipController1.SetToolTip(chkbEliminaAgente, "Si desea agregar un agente a este cliente desmarque esta opción")
            Me.BindingContext(DataSetClientes1, "Clientes").Current("agente") = Me.ComboBoxAgente.Text
            Me.ComboBoxAgente.Enabled = True
        End If
    End Sub

    Private Sub btnCartasExoneracion_Click(sender As Object, e As EventArgs)
        If BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion") > 0 Then
            Dim frm As New frmCartaExoneracion
            frm.Identificacion = BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion")
            frm.btnBuscarCliente.Enabled = False
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnIdentificarse_Click(sender As Object, e As EventArgs) Handles btnIdentificarse.Click
        Dim frm As New frmVersionCompleta
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CheckBoxAbrirCredito.Enabled = True
        Else
            Me.CheckBoxAbrirCredito.Enabled = False
        End If
    End Sub

    Private Sub ckNotificaRecibo_CheckedChanged(sender As Object, e As EventArgs) Handles ckNotificaRecibo.CheckedChanged
        If Me.ckNotificaRecibo.Checked = True Then
            Me.txtCorreoRecibo.Enabled = True
            Me.txtCorreoRecibo.Focus()
        Else
            Me.txtCorreoRecibo.Text = ""
            Me.txtCorreoRecibo.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxMoroso_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMoroso.CheckedChanged
        Me.lblAdvertenciaMoroso.Visible = Me.CheckBoxMoroso.Checked
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        Dim frm As New frmMotivoInactivarCliente
        frm.Identificacion = BindingContext(Me.DataSetClientes1, "Clientes").Current("Identificacion")
        frm.Inactivo = Me.CheckBoxAnular.Checked
        frm.ShowDialog()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Anulado from Clientes where identificacion = " & Cod_Cliente_Buscar, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.CheckBoxAnular.Checked = dt.Rows(0).Item("Anulado")
        End If
    End Sub

End Class
