Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms
'-------------------------------------------------------------------------------------
'EL REGISTRO DISPARA EL TRIGGER QUE GENERA UN CHEQUE.                                !
'-------------------------------------------------------------------------------------

Public Class Abonos_Proveedor
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim Anular As Boolean = False
    Dim VariarInteres As Boolean = False
    Dim Tabla As DataTable
    Dim buscando As Boolean
    Dim usua As Usuario_Logeado
    Dim idabono1 As Integer
    Dim NuevaConexion As String
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtAjusteFac As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cAjuste As DevExpress.XtraGrid.Columns.GridColumn
    Dim strModulo As String = ""
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        '   NuevaConexion = Conexion
        usua = Usuario_Parametro
        NuevaConexion = Conexion

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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarAnular As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents adAbonos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daDetalle_Abono As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtSaldoAct As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents gridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Factura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoSuMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoActGen As System.Windows.Forms.TextBox
    Friend WithEvents txtAbonoGen As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoAntGen As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtNum_Recibo As System.Windows.Forms.TextBox
    Friend WithEvents DataSetAbonosProveedor As DataSetAbonosProveedor
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Adapter_Cuenta_Proveedor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Proveedor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox_Datos_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents AdapterBancos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCuentasBancarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox_Datos_Abonos As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxBanco As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCuentaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCuentaBancariaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents LabelFecha As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambioD As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTipoCambioFactura As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProveedorDetalle As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIdFactura As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents TxtAbono As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo_Ant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBoxMontoLetras As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_CodBanco As System.Windows.Forms.Label
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Abonos_Proveedor))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox_Datos_Cliente = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.ComboMoneda = New System.Windows.Forms.ComboBox()
        Me.DataSetAbonosProveedor = New LcPymes_5._2.DataSetAbonosProveedor()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtNum_Recibo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarAnular = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.gridFacturas = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Factura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAjusteFac = New DevExpress.XtraEditors.CalcEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtAbono = New DevExpress.XtraEditors.CalcEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSaldoAct = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAbonoSuMoneda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxTipoCambioFactura = New System.Windows.Forms.TextBox()
        Me.TextBoxProveedorDetalle = New System.Windows.Forms.TextBox()
        Me.TextBoxIdFactura = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSaldo_Ant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cAjuste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adAbonos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daDetalle_Abono = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSaldoActGen = New System.Windows.Forms.TextBox()
        Me.txtAbonoGen = New System.Windows.Forms.TextBox()
        Me.txtSaldoAntGen = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox_Datos_Abonos = New System.Windows.Forms.GroupBox()
        Me.Label_CodBanco = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComboBoxBanco = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCuentaBancariaDestino = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCuentaBancaria = New System.Windows.Forms.ComboBox()
        Me.Adapter_Cuenta_Proveedor = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Proveedor = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AdapterBancos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterCuentasBancarias = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.txtTipoCambioD = New System.Windows.Forms.ComboBox()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.TextBoxMontoLetras = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox_Datos_Cliente.SuspendLayout()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAbonosProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtAjusteFac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Datos_Abonos.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(-3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(817, 32)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Abonos a Proveedores"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox_Datos_Cliente
        '
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label27)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.txtDescuento)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label1)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label10)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.dtFecha)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label3)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.LabelFecha)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.txtCodigo)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label37)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label5)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label2)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.txtNombre)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.ComboMoneda)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.Label30)
        Me.GroupBox_Datos_Cliente.Controls.Add(Me.txtNum_Recibo)
        Me.GroupBox_Datos_Cliente.Enabled = False
        Me.GroupBox_Datos_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Datos_Cliente.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox_Datos_Cliente.Location = New System.Drawing.Point(6, 33)
        Me.GroupBox_Datos_Cliente.Name = "GroupBox_Datos_Cliente"
        Me.GroupBox_Datos_Cliente.Size = New System.Drawing.Size(766, 55)
        Me.GroupBox_Datos_Cliente.TabIndex = 1
        Me.GroupBox_Datos_Cliente.TabStop = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(715, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 192
        Me.Label27.Text = "% Des"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescuento
        '
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(715, 32)
        Me.txtDescuento.MaxLength = 2
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(48, 20)
        Me.txtDescuento.TabIndex = 191
        Me.txtDescuento.Text = "0"
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(632, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "Tipo Cambio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.Location = New System.Drawing.Point(632, 32)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(79, 20)
        Me.txtTipoCambio.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(369, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Recibo #"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = New Date(2009, 11, 19, 0, 0, 0, 0)
        Me.dtFecha.Location = New System.Drawing.Point(439, 32)
        Me.dtFecha.Name = "dtFecha"
        '
        '
        '
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.Enabled = False
        Me.dtFecha.Size = New System.Drawing.Size(88, 23)
        Me.dtFecha.TabIndex = 187
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(439, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFecha
        '
        Me.LabelFecha.BackColor = System.Drawing.Color.RoyalBlue
        Me.LabelFecha.Enabled = False
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.Color.White
        Me.LabelFecha.Location = New System.Drawing.Point(540, -2)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(152, 16)
        Me.LabelFecha.TabIndex = 185
        Me.LabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(6, 33)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(8, -1)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(743, 16)
        Me.Label37.TabIndex = 157
        Me.Label37.Text = "Datos del Proveedor"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(70, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(70, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(293, 20)
        Me.txtNombre.TabIndex = 1
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DataSource = Me.DataSetAbonosProveedor
        Me.ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.Enabled = False
        Me.ComboMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboMoneda.Location = New System.Drawing.Point(533, 32)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(95, 21)
        Me.ComboMoneda.TabIndex = 2
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'DataSetAbonosProveedor
        '
        Me.DataSetAbonosProveedor.DataSetName = "DataSetAbonosProveedor"
        Me.DataSetAbonosProveedor.Locale = New System.Globalization.CultureInfo("es")
        Me.DataSetAbonosProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(533, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 15)
        Me.Label30.TabIndex = 164
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNum_Recibo
        '
        Me.txtNum_Recibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum_Recibo.Location = New System.Drawing.Point(369, 33)
        Me.txtNum_Recibo.Name = "txtNum_Recibo"
        Me.txtNum_Recibo.Size = New System.Drawing.Size(64, 20)
        Me.txtNum_Recibo.TabIndex = 159
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(8, 368)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(352, 16)
        Me.Label29.TabIndex = 160
        Me.Label29.Text = "Observaciones:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 385)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(352, 27)
        Me.txtObservaciones.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel1.Location = New System.Drawing.Point(479, 483)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 16)
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
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(125, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(216, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 170
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarAnular, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 441)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(775, 58)
        Me.ToolBar1.TabIndex = 7
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
        Me.ToolBarBuscar.Enabled = False
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
        'ToolBarAnular
        '
        Me.ToolBarAnular.ImageIndex = 3
        Me.ToolBarAnular.Name = "ToolBarAnular"
        Me.ToolBarAnular.Text = "Anular"
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
        'gridFacturas
        '
        '
        '
        '
        Me.gridFacturas.EmbeddedNavigator.Name = ""
        Me.gridFacturas.Location = New System.Drawing.Point(8, 99)
        Me.gridFacturas.MainView = Me.AdvBandedGridView1
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.Size = New System.Drawing.Size(176, 149)
        Me.gridFacturas.TabIndex = 168
        Me.gridFacturas.Text = "GridControl1"
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Factura, Me.Fecha})
        Me.AdvBandedGridView1.GroupPanelText = "Facturas Pendientes"
        Me.AdvBandedGridView1.IndicatorWidth = 8
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ShowGroupedColumns = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Facturas Pendiente de Pago"
        Me.GridBand1.Columns.Add(Me.Factura)
        Me.GridBand1.Columns.Add(Me.Fecha)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 165
        '
        'Factura
        '
        Me.Factura.Caption = "Factura No."
        Me.Factura.FieldName = "Factura"
        Me.Factura.FilterInfo = ColumnFilterInfo1
        Me.Factura.Name = "Factura"
        Me.Factura.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Factura.SortIndex = 0
        Me.Factura.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.Factura.Visible = True
        Me.Factura.Width = 70
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.FilterInfo = ColumnFilterInfo2
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Fecha.Visible = True
        Me.Fecha.Width = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtAjusteFac)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.TxtAbono)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSaldoAct)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAbonoSuMoneda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBoxTipoCambioFactura)
        Me.GroupBox1.Controls.Add(Me.TextBoxProveedorDetalle)
        Me.GroupBox1.Controls.Add(Me.TextBoxIdFactura)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 128)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtAjusteFac
        '
        Me.txtAjusteFac.Location = New System.Drawing.Point(352, 17)
        Me.txtAjusteFac.Name = "txtAjusteFac"
        '
        '
        '
        Me.txtAjusteFac.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAjusteFac.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAjusteFac.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAjusteFac.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAjusteFac.Size = New System.Drawing.Size(152, 21)
        Me.txtAjusteFac.TabIndex = 193
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Silver
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(239, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 16)
        Me.Label28.TabIndex = 192
        Me.Label28.Text = "Ajuste "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAbono
        '
        Me.TxtAbono.Location = New System.Drawing.Point(352, 42)
        Me.TxtAbono.Name = "TxtAbono"
        '
        '
        '
        Me.TxtAbono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtAbono.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtAbono.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtAbono.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAbono.Size = New System.Drawing.Size(152, 21)
        Me.TxtAbono.TabIndex = 191
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Silver
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(240, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 184
        Me.Label26.Text = "AB Moneda Fact"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(8, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Factura No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFactura
        '
        Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.Enabled = False
        Me.txtFactura.ForeColor = System.Drawing.Color.Blue
        Me.txtFactura.Location = New System.Drawing.Point(104, 18)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(112, 13)
        Me.txtFactura.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Silver
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(8, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 15)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Mont. Fact."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Saldo Anterior"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(496, 16)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Datos de la Factura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.MontoFactura", True))
        Me.txtMonto.Enabled = False
        Me.txtMonto.ForeColor = System.Drawing.Color.Blue
        Me.txtMonto.Location = New System.Drawing.Point(104, 37)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(112, 13)
        Me.txtMonto.TabIndex = 2
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Saldo_Ant", True))
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(104, 55)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(112, 13)
        Me.txtSaldo.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(240, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Abono"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldoAct
        '
        Me.txtSaldoAct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoAct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Saldo_Actual", True))
        Me.txtSaldoAct.Enabled = False
        Me.txtSaldoAct.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoAct.Location = New System.Drawing.Point(352, 66)
        Me.txtSaldoAct.Name = "txtSaldoAct"
        Me.txtSaldoAct.Size = New System.Drawing.Size(152, 13)
        Me.txtSaldoAct.TabIndex = 5
        Me.txtSaldoAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(239, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Saldo Actual"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAbonoSuMoneda
        '
        Me.txtAbonoSuMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbonoSuMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbonoSuMoneda.Enabled = False
        Me.txtAbonoSuMoneda.ForeColor = System.Drawing.Color.Blue
        Me.txtAbonoSuMoneda.Location = New System.Drawing.Point(352, 84)
        Me.txtAbonoSuMoneda.Name = "txtAbonoSuMoneda"
        Me.txtAbonoSuMoneda.Size = New System.Drawing.Size(152, 13)
        Me.txtAbonoSuMoneda.TabIndex = 183
        Me.txtAbonoSuMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(8, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "T.C.F"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxTipoCambioFactura
        '
        Me.TextBoxTipoCambioFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTipoCambioFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxTipoCambioFactura.Enabled = False
        Me.TextBoxTipoCambioFactura.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxTipoCambioFactura.Location = New System.Drawing.Point(104, 74)
        Me.TextBoxTipoCambioFactura.Name = "TextBoxTipoCambioFactura"
        Me.TextBoxTipoCambioFactura.Size = New System.Drawing.Size(112, 13)
        Me.TextBoxTipoCambioFactura.TabIndex = 188
        '
        'TextBoxProveedorDetalle
        '
        Me.TextBoxProveedorDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxProveedorDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxProveedorDetalle.Enabled = False
        Me.TextBoxProveedorDetalle.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxProveedorDetalle.Location = New System.Drawing.Point(104, 92)
        Me.TextBoxProveedorDetalle.Name = "TextBoxProveedorDetalle"
        Me.TextBoxProveedorDetalle.Size = New System.Drawing.Size(112, 13)
        Me.TextBoxProveedorDetalle.TabIndex = 189
        Me.TextBoxProveedorDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxIdFactura
        '
        Me.TextBoxIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIdFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxIdFactura.Enabled = False
        Me.TextBoxIdFactura.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxIdFactura.Location = New System.Drawing.Point(8, 92)
        Me.TextBoxIdFactura.Name = "TextBoxIdFactura"
        Me.TextBoxIdFactura.Size = New System.Drawing.Size(88, 13)
        Me.TextBoxIdFactura.TabIndex = 190
        Me.TextBoxIdFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoPago.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"CHEQUE", "TRANFERENCIA"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(8, 117)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxTipoPago.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.EditValue = ""
        Me.TextBox1.Location = New System.Drawing.Point(120, 117)
        Me.TextBox1.Name = "TextBox1"
        '
        '
        '
        Me.TextBox1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextBox1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextBox1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TextBox1.Size = New System.Drawing.Size(120, 19)
        Me.TextBox1.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(8, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 16)
        Me.Label20.TabIndex = 186
        Me.Label20.Text = "Tipo Pago"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(8, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 21)
        Me.Label19.TabIndex = 184
        Me.Label19.Text = "Cuenta Bancaria"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "abonocpagar.abonocpagardetalle_abonocpagar"
        Me.GridControl2.DataSource = Me.DataSetAbonosProveedor
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(6, 256)
        Me.GridControl2.MainView = Me.GridView1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(759, 104)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactura, Me.colMonto, Me.colSaldo_Ant, Me.colAbono, Me.colSaldo, Me.cAjuste})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFactura
        '
        Me.colFactura.Caption = "Factura"
        Me.colFactura.FieldName = "Factura"
        Me.colFactura.FilterInfo = ColumnFilterInfo3
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFactura.VisibleIndex = 0
        Me.colFactura.Width = 114
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto Fact."
        Me.colMonto.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colMonto.FieldName = "MontoFactura"
        Me.colMonto.FilterInfo = ColumnFilterInfo4
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 1
        Me.colMonto.Width = 111
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "#,#0.00"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colSaldo_Ant
        '
        Me.colSaldo_Ant.Caption = "Saldo Ant."
        Me.colSaldo_Ant.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colSaldo_Ant.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo_Ant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo_Ant.FieldName = "Saldo_Ant"
        Me.colSaldo_Ant.FilterInfo = ColumnFilterInfo5
        Me.colSaldo_Ant.Name = "colSaldo_Ant"
        Me.colSaldo_Ant.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo_Ant.SummaryItem.DisplayFormat = "#,#0.00"
        Me.colSaldo_Ant.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaldo_Ant.VisibleIndex = 2
        Me.colSaldo_Ant.Width = 158
        '
        'colAbono
        '
        Me.colAbono.Caption = "Abono"
        Me.colAbono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colAbono.DisplayFormat.FormatString = "#,#0.00"
        Me.colAbono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAbono.FieldName = "Abono"
        Me.colAbono.FilterInfo = ColumnFilterInfo6
        Me.colAbono.Name = "colAbono"
        Me.colAbono.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colAbono.SummaryItem.DisplayFormat = "#,#0.00"
        Me.colAbono.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colAbono.VisibleIndex = 3
        Me.colAbono.Width = 141
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo Actual"
        Me.colSaldo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colSaldo.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo_Actual"
        Me.colSaldo.FilterInfo = ColumnFilterInfo7
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo.StyleName = "Style1"
        Me.colSaldo.SummaryItem.DisplayFormat = "#,#0.00"
        Me.colSaldo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 163
        '
        'cAjuste
        '
        Me.cAjuste.Caption = "Ajuste"
        Me.cAjuste.DisplayFormat.FormatString = "#,#0.00"
        Me.cAjuste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cAjuste.FieldName = "Ajuste"
        Me.cAjuste.FilterInfo = ColumnFilterInfo8
        Me.cAjuste.MinWidth = 25
        Me.cAjuste.Name = "cAjuste"
        Me.cAjuste.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.cAjuste.VisibleIndex = 5
        '
        'adAbonos
        '
        Me.adAbonos.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAbonos.InsertCommand = Me.SqlInsertCommand1
        Me.adAbonos.SelectCommand = Me.SqlSelectCommand1
        Me.adAbonos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "abonocpagar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Abonocpagar", "Id_Abonocpagar"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("TipoDocumento", "TipoDocumento"), New System.Data.Common.DataColumnMapping("CuentaBancaria", "CuentaBancaria"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("Saldo_Cuenta", "Saldo_Cuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Actual", "Saldo_Actual"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Recibo", "Recibo"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Cod_Proveedor", "Cod_Proveedor"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("cod_Moneda", "cod_Moneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("MontoLetras", "MontoLetras"), New System.Data.Common.DataColumnMapping("CuentaDestino", "CuentaDestino"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.adAbonos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM abonocpagar WHERE (Id_Abonocpagar = @Original_Id_Abonocpagar)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Abonocpagar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Abonocpagar", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESOFT;packet size=4096;integrated security=SSPI;data source=SEES" & _
    "OFT;persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 20, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 255, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 8, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 8, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Recibo", System.Data.SqlDbType.VarChar, 255, "Recibo"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@cod_Moneda", System.Data.SqlDbType.Int, 4, "cod_Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@MontoLetras", System.Data.SqlDbType.VarChar, 350, "MontoLetras"), New System.Data.SqlClient.SqlParameter("@CuentaDestino", System.Data.SqlDbType.BigInt, 8, "CuentaDestino"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@TipoDocumento", System.Data.SqlDbType.VarChar, 20, "TipoDocumento"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 255, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 8, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 8, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Recibo", System.Data.SqlDbType.VarChar, 255, "Recibo"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 75, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@cod_Moneda", System.Data.SqlDbType.Int, 4, "cod_Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@MontoLetras", System.Data.SqlDbType.VarChar, 350, "MontoLetras"), New System.Data.SqlClient.SqlParameter("@CuentaDestino", System.Data.SqlDbType.BigInt, 8, "CuentaDestino"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Original_Id_Abonocpagar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Abonocpagar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Abonocpagar", System.Data.SqlDbType.BigInt, 8, "Id_Abonocpagar")})
        '
        'daDetalle_Abono
        '
        Me.daDetalle_Abono.DeleteCommand = Me.SqlDeleteCommand2
        Me.daDetalle_Abono.InsertCommand = Me.SqlInsertCommand2
        Me.daDetalle_Abono.SelectCommand = Me.SqlSelectCommand2
        Me.daDetalle_Abono.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_abonocpagar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle_abonocpagar", "Id_Detalle_abonocpagar"), New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("Cod_Proveedor", "Cod_Proveedor"), New System.Data.Common.DataColumnMapping("MontoFactura", "MontoFactura"), New System.Data.Common.DataColumnMapping("Saldo_Ant", "Saldo_Ant"), New System.Data.Common.DataColumnMapping("Abono", "Abono"), New System.Data.Common.DataColumnMapping("Abono_SuMoneda", "Abono_SuMoneda"), New System.Data.Common.DataColumnMapping("Saldo_Actual", "Saldo_Actual"), New System.Data.Common.DataColumnMapping("Id_Abonocpagar", "Id_Abonocpagar"), New System.Data.Common.DataColumnMapping("Id_Compra", "Id_Compra")})})
        Me.daDetalle_Abono.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM detalle_abonocpagar WHERE (Id_Detalle_abonocpagar = @Original_Id_Deta" & _
    "lle_abonocpagar)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_abonocpagar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_abonocpagar", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"), New System.Data.SqlClient.SqlParameter("@MontoFactura", System.Data.SqlDbType.Float, 8, "MontoFactura"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 8, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 8, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 8, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Id_Abonocpagar", System.Data.SqlDbType.BigInt, 8, "Id_Abonocpagar"), New System.Data.SqlClient.SqlParameter("@Id_Compra", System.Data.SqlDbType.Float, 8, "Id_Compra")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_Detalle_abonocpagar, Factura, Cod_Proveedor, MontoFactura, Saldo_Ant, A" & _
    "bono, Abono_SuMoneda, Saldo_Actual, Id_Abonocpagar, Id_Compra FROM detalle_abono" & _
    "cpagar"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"), New System.Data.SqlClient.SqlParameter("@MontoFactura", System.Data.SqlDbType.Float, 8, "MontoFactura"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 8, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 8, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 8, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Id_Abonocpagar", System.Data.SqlDbType.BigInt, 8, "Id_Abonocpagar"), New System.Data.SqlClient.SqlParameter("@Id_Compra", System.Data.SqlDbType.Float, 8, "Id_Compra"), New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_abonocpagar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_abonocpagar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Detalle_abonocpagar", System.Data.SqlDbType.Int, 4, "Id_Detalle_abonocpagar")})
        '
        'daMoneda
        '
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand7
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand3
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monedas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Monedas"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(661, 384)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Monto Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(549, 384)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 161
        Me.Label18.Text = "Saldo Act."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(421, 368)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(344, 16)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Saldos de la Cuenta"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoActGen
        '
        Me.txtSaldoActGen.BackColor = System.Drawing.SystemColors.Control
        Me.txtSaldoActGen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoActGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoActGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Saldo_Actual", True))
        Me.txtSaldoActGen.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoActGen.Location = New System.Drawing.Point(549, 400)
        Me.txtSaldoActGen.Name = "txtSaldoActGen"
        Me.txtSaldoActGen.ReadOnly = True
        Me.txtSaldoActGen.Size = New System.Drawing.Size(104, 13)
        Me.txtSaldoActGen.TabIndex = 162
        Me.txtSaldoActGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAbonoGen
        '
        Me.txtAbonoGen.BackColor = System.Drawing.SystemColors.Control
        Me.txtAbonoGen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbonoGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbonoGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Monto", True))
        Me.txtAbonoGen.ForeColor = System.Drawing.Color.Blue
        Me.txtAbonoGen.Location = New System.Drawing.Point(661, 400)
        Me.txtAbonoGen.Name = "txtAbonoGen"
        Me.txtAbonoGen.ReadOnly = True
        Me.txtAbonoGen.Size = New System.Drawing.Size(104, 13)
        Me.txtAbonoGen.TabIndex = 160
        Me.txtAbonoGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoAntGen
        '
        Me.txtSaldoAntGen.BackColor = System.Drawing.SystemColors.Control
        Me.txtSaldoAntGen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoAntGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoAntGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Saldo_Cuenta", True))
        Me.txtSaldoAntGen.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoAntGen.Location = New System.Drawing.Point(421, 400)
        Me.txtSaldoAntGen.Name = "txtSaldoAntGen"
        Me.txtSaldoAntGen.ReadOnly = True
        Me.txtSaldoAntGen.Size = New System.Drawing.Size(120, 13)
        Me.txtSaldoAntGen.TabIndex = 158
        Me.txtSaldoAntGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(421, 384)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Saldo Ant."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(775, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 16)
        Me.CheckBox1.TabIndex = 172
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(120, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 16)
        Me.Label21.TabIndex = 189
        Me.Label21.Text = "Documento"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(8, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(496, 16)
        Me.Label22.TabIndex = 184
        Me.Label22.Text = "Origen de la Forma de Pago"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox_Datos_Abonos
        '
        Me.GroupBox_Datos_Abonos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label_CodBanco)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label6)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label25)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label24)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label23)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.ComboBoxBanco)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.ComboBoxCuentaBancariaDestino)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label21)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.ComboBoxTipoPago)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.TextBox1)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label19)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label20)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.ComboBoxCuentaBancaria)
        Me.GroupBox_Datos_Abonos.Controls.Add(Me.Label22)
        Me.GroupBox_Datos_Abonos.Enabled = False
        Me.GroupBox_Datos_Abonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Datos_Abonos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox_Datos_Abonos.Location = New System.Drawing.Point(0, -8)
        Me.GroupBox_Datos_Abonos.Name = "GroupBox_Datos_Abonos"
        Me.GroupBox_Datos_Abonos.Size = New System.Drawing.Size(567, 151)
        Me.GroupBox_Datos_Abonos.TabIndex = 0
        Me.GroupBox_Datos_Abonos.TabStop = False
        '
        'Label_CodBanco
        '
        Me.Label_CodBanco.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label_CodBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CodBanco.ForeColor = System.Drawing.Color.Lime
        Me.Label_CodBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_CodBanco.Location = New System.Drawing.Point(416, 13)
        Me.Label_CodBanco.Name = "Label_CodBanco"
        Me.Label_CodBanco.Size = New System.Drawing.Size(88, 16)
        Me.Label_CodBanco.TabIndex = 196
        Me.Label_CodBanco.Text = "000000"
        Me.Label_CodBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(248, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 16)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Cuenta Destino"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(272, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(232, 16)
        Me.Label25.TabIndex = 195
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(8, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(496, 16)
        Me.Label24.TabIndex = 194
        Me.Label24.Text = "Forma de Pago a Proveedor"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(8, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(104, 18)
        Me.Label23.TabIndex = 193
        Me.Label23.Text = "Banco"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxBanco
        '
        Me.ComboBoxBanco.DataSource = Me.DataSetAbonosProveedor
        Me.ComboBoxBanco.DisplayMember = "Bancos.Descripcion"
        Me.ComboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBanco.ItemHeight = 13
        Me.ComboBoxBanco.Location = New System.Drawing.Point(112, 30)
        Me.ComboBoxBanco.Name = "ComboBoxBanco"
        Me.ComboBoxBanco.Size = New System.Drawing.Size(392, 21)
        Me.ComboBoxBanco.TabIndex = 0
        Me.ComboBoxBanco.ValueMember = "Bancos.Codigo_banco"
        '
        'ComboBoxCuentaBancariaDestino
        '
        Me.ComboBoxCuentaBancariaDestino.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAbonosProveedor, "abonocpagar.CuentaDestino", True))
        Me.ComboBoxCuentaBancariaDestino.DataSource = Me.DataSetAbonosProveedor
        Me.ComboBoxCuentaBancariaDestino.DisplayMember = "Proveedores.ProveedoresCuentas_Bancarias_Proveedor.Num_Cuenta"
        Me.ComboBoxCuentaBancariaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCuentaBancariaDestino.Enabled = False
        Me.ComboBoxCuentaBancariaDestino.Location = New System.Drawing.Point(248, 117)
        Me.ComboBoxCuentaBancariaDestino.Name = "ComboBoxCuentaBancariaDestino"
        Me.ComboBoxCuentaBancariaDestino.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxCuentaBancariaDestino.TabIndex = 4
        Me.ComboBoxCuentaBancariaDestino.ValueMember = "Cuentas_Bancarias_Proveedor.Id_Cuenta"
        '
        'ComboBoxCuentaBancaria
        '
        Me.ComboBoxCuentaBancaria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.CuentaBancaria", True))
        Me.ComboBoxCuentaBancaria.DataSource = Me.DataSetAbonosProveedor
        Me.ComboBoxCuentaBancaria.DisplayMember = "Bancos.BancosCuentas_bancarias.Cuenta"
        Me.ComboBoxCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCuentaBancaria.ItemHeight = 13
        Me.ComboBoxCuentaBancaria.Location = New System.Drawing.Point(120, 53)
        Me.ComboBoxCuentaBancaria.Name = "ComboBoxCuentaBancaria"
        Me.ComboBoxCuentaBancaria.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxCuentaBancaria.TabIndex = 1
        Me.ComboBoxCuentaBancaria.ValueMember = "Cuentas_bancarias.Id_CuentaBancaria"
        '
        'Adapter_Cuenta_Proveedor
        '
        Me.Adapter_Cuenta_Proveedor.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Cuenta_Proveedor.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Cuenta_Proveedor.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Cuenta_Proveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_Bancarias_Proveedor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Cuenta", "Id_Cuenta"), New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("TipoCuenta", "TipoCuenta"), New System.Data.Common.DataColumnMapping("Banco", "Banco"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Num_Cuenta", "Num_Cuenta"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        Me.Adapter_Cuenta_Proveedor.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Cuenta", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCuenta", System.Data.SqlDbType.VarChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@TipoCuenta", System.Data.SqlDbType.VarChar, 35, "TipoCuenta"), New System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 70, "Banco"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Num_Cuenta", System.Data.SqlDbType.VarChar, 50, "Num_Cuenta"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id_Cuenta, CodigoProv, TipoCuenta, Banco, CodMoneda, Num_Cuenta, MonedaNom" & _
    "bre FROM Cuentas_Bancarias_Proveedor"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@TipoCuenta", System.Data.SqlDbType.VarChar, 35, "TipoCuenta"), New System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 70, "Banco"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Num_Cuenta", System.Data.SqlDbType.VarChar, 50, "Num_Cuenta"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Cuenta", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCuenta", System.Data.SqlDbType.VarChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Cuenta", System.Data.SqlDbType.Int, 4, "Id_Cuenta")})
        '
        'Adapter_Proveedor
        '
        Me.Adapter_Proveedor.DeleteCommand = Me.SqlDeleteCommand6
        Me.Adapter_Proveedor.InsertCommand = Me.SqlInsertCommand6
        Me.Adapter_Proveedor.SelectCommand = Me.SqlSelectCommand5
        Me.Adapter_Proveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Contacto", "Contacto"), New System.Data.Common.DataColumnMapping("Telefono_Cont", "Telefono_Cont"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Fax1", "Fax1"), New System.Data.Common.DataColumnMapping("Fax2", "Fax2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("MontoCredito", "MontoCredito"), New System.Data.Common.DataColumnMapping("Plazo", "Plazo"), New System.Data.Common.DataColumnMapping("CostoTotal", "CostoTotal"), New System.Data.Common.DataColumnMapping("ImpIncluido", "ImpIncluido"), New System.Data.Common.DataColumnMapping("PedidosMes", "PedidosMes"), New System.Data.Common.DataColumnMapping("Utilidad_Inventario", "Utilidad_Inventario"), New System.Data.Common.DataColumnMapping("Utilidad_Fija", "Utilidad_Fija")})})
        Me.Adapter_Proveedor.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoTotal", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ImpIncluido", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ImpIncluido", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PedidosMes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PedidosMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_Cont", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_Cont", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Fija", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Fija", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Inventario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Inventario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 20, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Telefono_Cont", System.Data.SqlDbType.VarChar, 15, "Telefono_Cont"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 15, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 15, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Fax1", System.Data.SqlDbType.VarChar, 15, "Fax1"), New System.Data.SqlClient.SqlParameter("@Fax2", System.Data.SqlDbType.VarChar, 15, "Fax2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@MontoCredito", System.Data.SqlDbType.Float, 8, "MontoCredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@CostoTotal", System.Data.SqlDbType.Bit, 1, "CostoTotal"), New System.Data.SqlClient.SqlParameter("@ImpIncluido", System.Data.SqlDbType.Bit, 1, "ImpIncluido"), New System.Data.SqlClient.SqlParameter("@PedidosMes", System.Data.SqlDbType.Int, 4, "PedidosMes"), New System.Data.SqlClient.SqlParameter("@Utilidad_Inventario", System.Data.SqlDbType.Float, 8, "Utilidad_Inventario"), New System.Data.SqlClient.SqlParameter("@Utilidad_Fija", System.Data.SqlDbType.Bit, 1, "Utilidad_Fija")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodigoProv", System.Data.SqlDbType.Int, 4, "CodigoProv"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 20, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Telefono_Cont", System.Data.SqlDbType.VarChar, 15, "Telefono_Cont"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 15, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 15, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Fax1", System.Data.SqlDbType.VarChar, 15, "Fax1"), New System.Data.SqlClient.SqlParameter("@Fax2", System.Data.SqlDbType.VarChar, 15, "Fax2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@MontoCredito", System.Data.SqlDbType.Float, 8, "MontoCredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@CostoTotal", System.Data.SqlDbType.Bit, 1, "CostoTotal"), New System.Data.SqlClient.SqlParameter("@ImpIncluido", System.Data.SqlDbType.Bit, 1, "ImpIncluido"), New System.Data.SqlClient.SqlParameter("@PedidosMes", System.Data.SqlDbType.Int, 4, "PedidosMes"), New System.Data.SqlClient.SqlParameter("@Utilidad_Inventario", System.Data.SqlDbType.Float, 8, "Utilidad_Inventario"), New System.Data.SqlClient.SqlParameter("@Utilidad_Fija", System.Data.SqlDbType.Bit, 1, "Utilidad_Fija"), New System.Data.SqlClient.SqlParameter("@Original_CodigoProv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoTotal", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ImpIncluido", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ImpIncluido", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PedidosMes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PedidosMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_Cont", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_Cont", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Fija", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Fija", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Utilidad_Inventario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Utilidad_Inventario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(192, 91)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 157)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox_Datos_Abonos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(570, 131)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Abono"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(570, 131)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle  de la(s) Factura(s) a Abonar"
        '
        'AdapterBancos
        '
        Me.AdapterBancos.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterBancos.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterBancos.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterBancos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bancos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.AdapterBancos.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Bancos WHERE (Codigo_banco = @Original_Codigo_banco) AND (Descripcion" & _
    " = @Original_Descripcion)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=(local);packet size=4096;integrated security=SSPI;data source=""."";" & _
    "persist security info=False;initial catalog=Bancos"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Bancos(Descripcion) VALUES (@Descripcion); SELECT Codigo_banco, Descr" & _
    "ipcion FROM Bancos WHERE (Codigo_banco = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection2
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Codigo_banco, Descripcion FROM Bancos"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco")})
        '
        'AdapterCuentasBancarias
        '
        Me.AdapterCuentasBancarias.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterCuentasBancarias.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterCuentasBancarias.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterCuentasBancarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria")})})
        Me.AdapterCuentasBancarias.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoCuenta", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoCuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Cuenta, Codigo_banco, tipoCuenta, NombreCuenta, Cod_Moneda, Id_CuentaBanca" & _
    "ria FROM Cuentas_bancarias"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoCuenta", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria")})
        '
        'txtTipoCambioD
        '
        Me.txtTipoCambioD.DataSource = Me.DataSetAbonosProveedor
        Me.txtTipoCambioD.DisplayMember = "Moneda.ValorCompra"
        Me.txtTipoCambioD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoCambioD.Enabled = False
        Me.txtTipoCambioD.ForeColor = System.Drawing.Color.Blue
        Me.txtTipoCambioD.Location = New System.Drawing.Point(775, 64)
        Me.txtTipoCambioD.Name = "txtTipoCambioD"
        Me.txtTipoCambioD.Size = New System.Drawing.Size(80, 21)
        Me.txtTipoCambioD.TabIndex = 165
        Me.txtTipoCambioD.ValueMember = "Moneda.ValorCompra"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = "abonocpagar"
        Me.DataGrid1.DataSource = Me.DataSetAbonosProveedor
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(775, 96)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(424, 120)
        Me.DataGrid1.TabIndex = 192
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = "abonocpagar.abonocpagardetalle_abonocpagar"
        Me.DataGrid2.DataSource = Me.DataSetAbonosProveedor
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(775, 224)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(424, 96)
        Me.DataGrid2.TabIndex = 193
        '
        'TextBoxMontoLetras
        '
        Me.TextBoxMontoLetras.Enabled = False
        Me.TextBoxMontoLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMontoLetras.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxMontoLetras.Location = New System.Drawing.Point(10, 419)
        Me.TextBoxMontoLetras.Name = "TextBoxMontoLetras"
        Me.TextBoxMontoLetras.Size = New System.Drawing.Size(696, 12)
        Me.TextBoxMontoLetras.TabIndex = 194
        Me.TextBoxMontoLetras.Text = "Monto en letras"
        '
        'CheckBox2
        '
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(312, 472)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox2.TabIndex = 195
        Me.CheckBox2.Text = "Anulado"
        '
        'txtId
        '
        Me.txtId.EditValue = ""
        Me.txtId.Location = New System.Drawing.Point(64, 16)
        Me.txtId.Name = "txtId"
        '
        '
        '
        Me.txtId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtId.Properties.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(88, 17)
        Me.txtId.TabIndex = 196
        '
        'Abonos_Proveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(775, 499)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBoxMontoLetras)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GroupBox_Datos_Cliente)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.gridFacturas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTipoCambioD)
        Me.Controls.Add(Me.txtSaldoActGen)
        Me.Controls.Add(Me.txtAbonoGen)
        Me.Controls.Add(Me.txtSaldoAntGen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(791, 538)
        Me.MinimumSize = New System.Drawing.Size(791, 538)
        Me.Name = "Abonos_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abono a Proveedor"
        Me.GroupBox_Datos_Cliente.ResumeLayout(False)
        Me.GroupBox_Datos_Cliente.PerformLayout()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAbonosProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtAjusteFac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Datos_Abonos.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub frmReciboDinero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
            SqlConnection2.ConnectionString = GetSetting("SeeSOFT", "Bancos", "Conexion")
            strModulo = IIf(NuevaConexion = "", "SeePOS", "SeePos")

            Me.DataSetAbonosProveedor.abonocpagar.Id_AbonocpagarColumn.AutoIncrement = True
            Me.DataSetAbonosProveedor.abonocpagar.Id_AbonocpagarColumn.AutoIncrementSeed = -1
            Me.DataSetAbonosProveedor.abonocpagar.Id_AbonocpagarColumn.AutoIncrementStep = -1
            Me.DataSetAbonosProveedor.abonocpagar.CuentaDestinoColumn.DefaultValue = 0
            Me.DataSetAbonosProveedor.abonocpagar.FechaEntradaColumn.DefaultValue = Now
            Me.DataSetAbonosProveedor.abonocpagar.FechaColumn.DefaultValue = Now
            Me.DataSetAbonosProveedor.abonocpagar.cod_MonedaColumn.DefaultValue = 1
            Me.DataSetAbonosProveedor.abonocpagar.ObservacionesColumn.DefaultValue = "--"

            Me.DataSetAbonosProveedor.detalle_abonocpagar.Id_Detalle_abonocpagarColumn.AutoIncrement = True
            Me.DataSetAbonosProveedor.detalle_abonocpagar.Id_Detalle_abonocpagarColumn.AutoIncrementSeed = -1
            Me.DataSetAbonosProveedor.detalle_abonocpagar.Id_Detalle_abonocpagarColumn.AutoIncrementStep = -1

            'CARGA DE NUEVO los adaptadores.
            Me.daMoneda.Fill(Me.DataSetAbonosProveedor, "Moneda")
            If (Me.AdapterBancos.Fill(Me.DataSetAbonosProveedor, "Bancos")) = 0 Then
                MsgBox("No se pueden Realizar abonos porque no hay Bancos Registrados, el módulo se cerrará", MsgBoxStyle.Critical)
                Me.Close()
            Else
                Me.ComboBoxBanco.SelectedIndex = 0

            End If

            Me.AdapterCuentasBancarias.Fill(Me.DataSetAbonosProveedor, "Cuentas_bancarias")

            Me.ToolBar1.Buttons(1).Enabled = True
            Me.txtUsuario.Focus()
            Me.ToolBarImprimir.Visible = True

            Me.ComboBoxCuentaBancaria.SelectedIndex = 0

            Binding()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Sub defaulvalue()
        Me.DataSetAbonosProveedor.abonocpagar.AnuladoColumn.DefaultValue = False
        Me.DataSetAbonosProveedor.abonocpagar.Cedula_UsuarioColumn.DefaultValue = ""
        Me.DataSetAbonosProveedor.abonocpagar.cod_MonedaColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.Cod_ProveedorColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.Codigo_bancoColumn.DefaultValue = Label_CodBanco.Text
        Me.DataSetAbonosProveedor.abonocpagar.ContabilizadoColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.CuentaBancariaColumn.DefaultValue = ""
        Me.DataSetAbonosProveedor.abonocpagar.DocumentoColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.FechaColumn.DefaultValue = Now
        Me.DataSetAbonosProveedor.abonocpagar.MontoColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.ReciboColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.Saldo_ActualColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.Saldo_CuentaColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.abonocpagar.TipoCambioColumn.DefaultValue = 1
        Me.DataSetAbonosProveedor.abonocpagar.TipoDocumentoColumn.DefaultValue = "CHEQUE"
        Me.DataSetAbonosProveedor.abonocpagar.MontoLetrasColumn.DefaultValue = ""


        Me.DataSetAbonosProveedor.detalle_abonocpagar.FacturaColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.Cod_ProveedorColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.MontoFacturaColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.Saldo_AntColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.AbonoColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.Abono_SuMonedaColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.Saldo_ActualColumn.DefaultValue = 0
        Me.DataSetAbonosProveedor.detalle_abonocpagar.Id_CompraColumn.DefaultValue = 0

        Me.LabelFecha.Text = Date.Now
        Me.txtTipoCambio.Text = 1
        Me.LabelFecha.Text = Date.Now
    End Sub
#End Region

    Function IdAbono()
        Dim Cx As New Conexion
        'Dim Id_Cuenta As Integer = ComboBox1.SelectedValue
        idabono1 = Cx.SlqExecuteScalar(Cx.Conectar(strModulo), "SELECT ISNULL(MAX(Id_Abonocpagar), 0) + 1  FROM abonocpagar")
        Cx.DesConectar(Cx.sQlconexion)
        'Me.Label3.Text = idabono1
        Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Id_Abonocpagar") = idabono1
        'Me.TxtNumCheque.EditValue = NumeroCheque
    End Function


#Region "Validacion Usuario"

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown

        Try


            Dim cConexion As New Conexion
            Dim Conx As New SqlConnection
            Conx.ConnectionString = Me.SqlConnection1.ConnectionString
            Conx.Open()
            Dim rs As SqlDataReader

            If e.KeyCode = Keys.Enter Then
                If txtUsuario.Text <> "" Then

                    rs = cConexion.GetRecorset(Conx, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")

                    If rs.HasRows = False Then
                        MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                        txtUsuario.Focus()
                    End If

                    While rs.Read
                        Try
                            Me.defaulvalue()
                            Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
                            Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").AddNew()

                            txtNombreUsuario.Text = rs!Nombre
                            txtCedulaUsuario.Text = rs("Cedula")
                            'If rs("AnuRecibos") = 1 Then Anular = True Else Anular = False

                            'If rs("VariarIntereses") = True Then
                            '    VariarInteres = True
                            'Else
                            '    VariarInteres = False
                            'End If
                            txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                            Me.ToolBar1.Buttons(0).Enabled = True
                            Me.ToolBar1.Buttons(1).Enabled = True
                            Me.ToolBar1.Buttons(2).Enabled = True
                            Me.NuevoRecibo()
                            Me.txtCodigo.Focus()
                            '    ComboMoneda.Focus()
                        Catch eEndEdit As System.Data.NoNullAllowedException
                            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                        End Try
                    End While
                    rs.Close()
                    cConexion.DesConectar(cConexion.sQlconexion)
                Else
                    MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                    txtUsuario.Focus()
                End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

    Private Sub NuevoRecibo()
        Try

            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'no hay un registro pendiente
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.GroupBox_Datos_Cliente.Enabled = False
                txtObservaciones.Enabled = False

                If Me.txtUsuario.Text = "" Then
                    txtUsuario.Enabled = True
                    txtUsuario.Focus()
                End If
                txtCodigo.Text = "" : txtNombre.Text = ""
                Try
                    Me.ComboMoneda.Enabled = True
                    Me.GroupBox_Datos_Cliente.Enabled = True
                    txtObservaciones.Enabled = True
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
            Else
                Try
                    If MessageBox.Show("Desea Guardar los Cambios del Recibo de Dinero", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Me.Registrar()
                    Else
                        Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").CancelCurrentEdit()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtCedulaUsuario.Text = ""
                        Me.GroupBox_Datos_Cliente.Enabled = False
                        Me.txtObservaciones.Enabled = False
                        'txtIntereses.Enabled = False
                        TxtAbono.Enabled = False
                    End If
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Public Function getId_AbonocPagar() As Long
        Dim dt As New DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("Select isnull(max(Id_AbonocPagar),0) + 1 from Abonocpagar", dt, CadenaConexionSeePOS)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function Registrar()
        Dim cx As New Conexion
        Dim i As Integer
        Dim Funciones As New Conexion
        Dim FactTemp As Double
        Dim numero As Integer
        Dim num_cuenta As String
        Dim documento, Tipo As String
        Try

            If MessageBox.Show("¿Desea guardar el pago al proveedor?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If VerificaRecibo() = False Then
                    Exit Function
                End If

                BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").CancelCurrentEdit()
                documento = Me.TextBox1.Text
                num_cuenta = Me.ComboBoxCuentaBancaria.SelectedValue
                numero = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "Select Num_Cheque, Id_CuentaBancaria FROM Cheques where Num_Cheque = " & documento & " AND Id_CuentaBancaria=" & num_cuenta & " and tipo = '" & Me.ComboBoxTipoPago.Text & "'")

                If numero Then
                    MsgBox("El Número de Cheque ya esta ingresado, favor revisar", MsgBoxStyle.Information, "Atención ...")
                    Exit Function
                End If

                'If VerificarExistenciaDocumento(Me.TextBox1.Text, Me.ComboBoxTipoPago.Text, Me.ComboBoxCuentaBancaria.Text) = True Then
                '    MsgBox("No se puede registrar este abono por que ya ha sigo registrado.", MsgBoxStyle.Information, "Atención..")
                '    Exit Function
                'End If

                Dim trans As OBSoluciones.SQL.Transaccion
                Dim Id_AbonocPagar As Long = 0
                Dim strSQL As String = ""
                Try
                    Id_AbonocPagar = 0
                    trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)

                    For i = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
                        Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = i
                        If Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual") = 0 Then
                            FactTemp = Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura")
                            strSQL = "Update Compras set FacturaCancelado = 1 Where Factura =" & FactTemp & " and TipoCompra = 'CRE' and codigoProv = " & Me.txtCodigo.Text & ""
                            trans.Ejecutar(strSQL, CommandType.Text)
                        End If
                    Next i

                    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("CuentaBancaria") = Me.ComboBoxCuentaBancaria.Text
                    Tipo = Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoDocumento")
                    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
                    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").EndCurrentEdit()

                    strSQL = "INSERT INTO [dbo].[abonocpagar] ([Documento],[TipoDocumento],[CuentaBancaria],[Codigo_banco],[Saldo_Cuenta],[Monto],[Saldo_Actual],[Fecha],[Contabilizado],[Recibo],[Cedula_Usuario],[Cod_Proveedor],[Anulado],[cod_Moneda],[TipoCambio],[MontoLetras],[CuentaDestino],[FechaEntrada],[Observaciones]) "
                    strSQL += "VALUES (@Documento,@TipoDocumento,@CuentaBancaria,@Codigo_banco,@Saldo_Cuenta,@Monto,@Saldo_Actual,@Fecha,@Contabilizado,@Recibo,@Cedula_Usuario,@Cod_Proveedor,@Anulado,@cod_Moneda,@TipoCambio,@MontoLetras,@CuentaDestino,@FechaEntrada,@Observaciones)"

                    trans.AddParametrosSalidaInt("@Id_Abonocpagar", Id_AbonocPagar)
                    trans.SetParametro("@Documento", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Documento"))
                    trans.SetParametro("@TipoDocumento", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoDocumento"))
                    trans.SetParametro("@CuentaBancaria", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("CuentaBancaria"))
                    trans.SetParametro("@Codigo_banco", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Codigo_banco"))
                    trans.SetParametro("@Saldo_Cuenta", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Saldo_Cuenta"))
                    trans.SetParametro("@Monto", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Monto"))
                    trans.SetParametro("@Saldo_Actual", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Saldo_Actual"))
                    trans.SetParametro("@Fecha", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Fecha"))
                    trans.SetParametro("@Contabilizado", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Contabilizado"))
                    trans.SetParametro("@Recibo", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Recibo"))
                    trans.SetParametro("@Cedula_Usuario", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Cedula_Usuario"))
                    trans.SetParametro("@Cod_Proveedor", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"))
                    trans.SetParametro("@Anulado", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Anulado"))
                    trans.SetParametro("@cod_Moneda", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("cod_Moneda"))
                    trans.SetParametro("@TipoCambio", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoCambio"))
                    trans.SetParametro("@MontoLetras", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("MontoLetras"))
                    trans.SetParametro("@CuentaDestino", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("CuentaDestino"))
                    trans.SetParametro("@FechaEntrada", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("FechaEntrada"))
                    trans.SetParametro("@Observaciones", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Observaciones"))
                    trans.Ejecutar("guardar_abonocpagar", CommandType.StoredProcedure, 0, Id_AbonocPagar)

                    For index As Integer = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
                        Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = index
                        strSQL = "INSERT INTO detalle_abonocpagar (Factura, Cod_Proveedor, MontoFactura, Saldo_Ant, Abono, Abono_SuMoneda, Saldo_Actual, Id_Abonocpagar, Id_Compra) "
                        strSQL += " VALUES (@Factura, @Cod_Proveedor, @MontoFactura, @Saldo_Ant, @Abono, @Abono_SuMoneda, @Saldo_Actual, @Id_Abonocpagar, @Id_Compra)"
                        trans.SetParametro("@Factura", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura"))
                        trans.SetParametro("@Cod_Proveedor", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Cod_Proveedor"))
                        trans.SetParametro("@MontoFactura", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("MontoFactura"))
                        trans.SetParametro("@Saldo_Ant", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Ant"))
                        trans.SetParametro("@Abono", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Abono"))
                        trans.SetParametro("@Abono_SuMoneda", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Abono_SuMoneda"))
                        trans.SetParametro("@Saldo_Actual", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual"))
                        trans.SetParametro("@Id_Abonocpagar", Id_AbonocPagar)
                        trans.SetParametro("@Id_Compra", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Id_Compra"))
                        trans.Ejecutar(strSQL, CommandType.Text)
                    Next

                    trans.Commit()

                    Me.IdAjuste = 0
                    GuardarAjuste()

                    Me.DataSetAbonosProveedor.abonocpagar.AcceptChanges()
                    Me.DataSetAbonosProveedor.detalle_abonocpagar.Clear()
                    Me.DataSetAbonosProveedor.abonocpagar.Clear()

                    Me.ToolBar1.Buttons(1).Enabled = True

                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0

                    MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    Dim ConexionProve As String
                    ConexionProve = CadenaConexionSeePOS()
                    Dim abono As New Abonos_Proveedor(usua, ConexionProve)
                    abono.MdiParent = Me.MdiParent
                    abono.Show()
                    Me.Close()
                    If Tipo = "CHEQUE" Then
                        If MessageBox.Show("¿Desea imprimir el cheque?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            numero = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "Select Id_Cheque FROM Cheques where Num_Cheque = " & documento & " AND Id_CuentaBancaria=" & num_cuenta)
                            imprimir(Id_AbonocPagar)
                        End If
                    End If
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
                End Try
            Else
                Exit Function
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
    '
    Private Sub _Insertardetalle_abonocpagar()
        'BISMARK
        'rrecoro el dataset detalle_abonocpagar, e inserto 1 por 1
        Dim e As Integer
        For e = 0 To Me.DataSetAbonosProveedor.detalle_abonocpagar.Count - 1
            Dim metodo As String = "INSERTAR"
            Dim sel As String
            sel = "INSERT INTO detalle_abonocpagar " & _
            " (Factura, Cod_Proveedor, MontoFactura, Saldo_Ant, Abono, Abono_SuMoneda, Saldo_Actual, Id_Abonocpagar, Id_Compra) " & _
            " VALUES " & _
            " (@Factura, @Cod_Proveedor, @MontoFactura, @Saldo_Ant, @Abono, @Abono_SuMoneda, @Saldo_Actual, @Id_Abonocpagar, @Id_Compra)"
            Dim con As New SqlConnection(CadenaConexionSeePOS)
            Dim cmd As New SqlCommand(sel, con)
            cmd.Parameters.Add("@Factura", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Factura)
            cmd.Parameters.Add("@Cod_Proveedor", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Cod_Proveedor)
            cmd.Parameters.Add("@MontoFactura", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).MontoFactura)
            cmd.Parameters.Add("@Saldo_Ant", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Saldo_Actual)
            cmd.Parameters.Add("@Abono", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Abono)
            cmd.Parameters.Add("@Abono_SuMoneda", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Abono_SuMoneda)
            cmd.Parameters.Add("@Saldo_Actual", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Saldo_Actual)
            cmd.Parameters.Add("@Id_Abonocpagar", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Id_Abonocpagar)
            cmd.Parameters.Add("@Id_Compra", Me.DataSetAbonosProveedor.detalle_abonocpagar.Item(e).Id_Compra)
            Try
                con.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error con la operación... " & vbCrLf & "Ocurrido:  " & DateTime.Now & _
                        vbCrLf & "Error en Método: _Insertardetalle_abonocpagar" & vbCrLf & vbCrLf & ex.Message)
            End Try
            con.Close()
        Next
    End Sub

    Private Function VerificarExistenciaDocumento(ByVal Documento As String, ByVal TipoDoc As String, ByVal Cuenta As String) As Boolean
        Dim Cx As New Conexion
        Dim Status As String
        Cx.Conectar("SeePos")
        Status = Cx.SlqExecuteScalar(Cx.sQlconexion, "SELECT Id_Abonocpagar FROM abonocpagar WHERE (Documento = " & Documento & ") AND (TipoDocumento = '" & TipoDoc & "') AND (CuentaBancaria = '" & Cuenta & "') AND (ANULADO = 0)")
        Cx.DesConectar(Cx.sQlconexion)
        If Status <> "" Then Return True Else Return False
    End Function

    Private Sub BuscarRecibo()
        Dim Fx As New cFunciones
        Dim identificador As Double

        Try
            If Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Recibo de Dinero, si continúa se perderan los datos del Recibo actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.DataSetAbonosProveedor.detalle_abonocpagar.Clear()
            Me.DataSetAbonosProveedor.abonocpagar.Clear()
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT abonocpagar.Id_Abonocpagar AS Consecutivo, cast(abonocpagar.Recibo as varchar) as Recibo, ISNULL(Proveedores.Nombre, 'Proveedor Eliminado') AS Proveedor, abonocpagar.Fecha, cast(abonocpagar.Documento as varchar ) as Cheque FROM abonocpagar LEFT OUTER JOIN Proveedores ON abonocpagar.Cod_Proveedor = Proveedores.CodigoProv ORDER BY abonocpagar.Fecha DESC", "Proveedor", "Fecha", "Buscar Pagos a Proveedor", SqlConnection1.ConnectionString))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            Me.CargarInformacionProveedor(identificador)
            ' si esta venta aun no ha sido anulada
            'If Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Anula") = False Then Me.ToolBar1.Buttons(3).Enabled = True
            Me.GridControl2.Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function CargarInformacionProveedor(ByVal Id As Double)
        'Dim cnnv As SqlConnection = Nothing
        'Dim dt As New DataTable
        'Dim cConexion As New Conexion
        'Dim IdRec As Long
        'Dentro de un Try/Catch por si se produce un error
        Try


            Dim Fx As New cFunciones
            Me.DataSetAbonosProveedor.detalle_abonocpagar.Clear()
            Me.DataSetAbonosProveedor.abonocpagar.Clear()
            Me.DataSetAbonosProveedor.Cuentas_Bancarias_Proveedor.Clear()
            Me.DataSetAbonosProveedor.Proveedores.Clear()
            'Me.DataSetAbonosProveedor.Moneda.Clear()
            'Me.DataSetAbonosProveedor.Cuentas_bancarias.Clear()

            'Me.DataSetAbonosProveedor.Bancos.Clear()

            'CARGA EL ABONO SELECCIONADO
            Fx.Cargar_Tabla_Generico(Me.adAbonos, "Select * from abonocpagar where Id_Abonocpagar =" & Id, SqlConnection1.ConnectionString)
            Me.adAbonos.Fill(Me.DataSetAbonosProveedor.abonocpagar)

            Dim ii As Integer
            For ii = 0 To Me.DataSetAbonosProveedor.abonocpagar.Count - 1
                If Me.BindingContext(Me.DataSetAbonosProveedor.abonocpagar).Current("Anulado") = True Then
                    Me.CheckBox2.Checked = True
                End If
            Next

            Fx.Cargar_Tabla_Generico(Me.daDetalle_Abono, "SELECT * FROM detalle_abonocpagar WHERE Id_Abonocpagar = " & Id, SqlConnection1.ConnectionString)
            Me.daDetalle_Abono.Fill(Me.DataSetAbonosProveedor, "detalle_abonocpagar")

            Fx.Cargar_Tabla_Generico(Me.Adapter_Proveedor, "SELECT * from proveedores where codigoProv  =" & BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"), SqlConnection1.ConnectionString)
            Me.Adapter_Proveedor.Fill(Me.DataSetAbonosProveedor, "Proveedores")
            txtNombre.Text = BindingContext(DataSetAbonosProveedor, "Proveedores").Current("Nombre")

            Fx.Cargar_Tabla_Generico(Me.Adapter_Cuenta_Proveedor, "SELECT * FROM Cuentas_Bancarias_Proveedor WHERE CodigoProv = " & BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"), SqlConnection1.ConnectionString)
            Me.Adapter_Cuenta_Proveedor.Fill(Me.DataSetAbonosProveedor, "Cuentas_Bancarias_Proveedor")
            ComboBoxCuentaBancariaDestino.SelectedValue = BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("CuentaDestino")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Function

    'Anulaciones de abonos a proveedor 
    Function Registrar_Anulacion_Venta() As Boolean
        Dim i As Long
        Dim Facttem As Double
        Dim Funciones As New Conexion
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.SqlUpdateCommand1.Transaction = Trans
            Me.adAbonos.Update(Me.DataSetAbonosProveedor, "abonocpagar")
            For i = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
                Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = i

                Facttem = Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura")
                Funciones.UpdateRecords("Compras", "FacturaCancelado = 0", "Factura =" & Facttem & "and TipoCompra = 'CRE'", strModulo)

            Next i
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    Private Sub anula(ByVal _num_cheque As String)
        Try
            Dim cls As New Anulacheque
            cls.EliminarCheque(_num_cheque, True, Me.ComboBoxCuentaBancaria.Text, ComboBoxCuentaBancaria.SelectedValue)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al anular el cheque")
        End Try
    End Sub

    Function AnularRecibo()
        Try
            Dim resp As Integer
            If Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Count > 0 Then
                If Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count > 0 Then

                    If CheckBox1.Checked = True Then
                        MsgBox("El abono ya esta anulado!", MsgBoxStyle.Exclamation)
                        Exit Function
                    End If

                    resp = MessageBox.Show("¿Desea Anular este Recibo de Pago...?", strModulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()

                        If Registrar_Anulacion_Venta() Then


                            Me.DataSetAbonosProveedor.AcceptChanges()
                            MsgBox("El Recibo de Dinero ha sido anulado correctamente", MsgBoxStyle.Information)
                            '---------------------------------------
                            'anula el cheque
                            '---------------------------------------
                            anula(Me.TextBox1.Text)
                            '---------------------------------------
                            Me.DataSetAbonosProveedor.detalle_abonocpagar.Clear()
                            Me.DataSetAbonosProveedor.abonocpagar.Clear()

                            Me.ToolBar1.Buttons(4).Enabled = True
                            Me.ToolBar1.Buttons(1).Enabled = True

                            Me.ToolBar1.Buttons(0).Text = "Nuevo"
                            Me.ToolBar1.Buttons(0).ImageIndex = 0
                            Me.ToolBar1.Buttons(3).Enabled = False
                            Me.ToolBar1.Buttons(2).Enabled = False
                            Me.ToolBar1.Buttons(4).Enabled = False


                            Me.GroupBox_Datos_Cliente.Enabled = False
                            txtObservaciones.Enabled = False

                            Me.txtUsuario.Enabled = True
                            Me.txtUsuario.Text = ""
                            Me.txtNombreUsuario.Text = ""
                            Me.txtUsuario.Focus()
                        End If

                    Else : Exit Function

                    End If
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1
                If Me.ToolBar1.Buttons(0).Text = "Cancelar" Then
                    NuevoRecibo()
                Else
                    txtUsuario.Enabled = True
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtCedulaUsuario.Text = ""
                    txtUsuario.Focus()
                End If
            Case 2 : If PMU.Find Then BuscarRecibo() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then AnularRecibo() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5
                Dim numero As Integer = 0
                Dim cx As New Conexion
                Dim documento As String
                Dim num_cuenta As String

                documento = Me.TextBox1.Text
                num_cuenta = Me.ComboBoxCuentaBancaria.SelectedValue
                numero = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "Select Id_Cheque FROM Cheques where Num_Cheque = " & documento & " AND Id_CuentaBancaria=" & num_cuenta)
                imprimir(BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("Id_Abonocpagar"))
            Case 6 : Me.Close()

        End Select
    End Sub

    Function imprimir(ByVal Id As Integer)
        Try
            Dim rpt As New rptAbonocPagar
            rpt.Refresh()
            rpt.SetParameterValue(0, Id)
            rpt.SetParameterValue(1, Me.IdAjuste)
            CrystalReportsConexion.LoadShow(rpt, MdiParent, CadenaConexionSeePOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function


#Region "Clientes"
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown

        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Dim cFunciones As New cFunciones
                    Me.txtCodigo.Text = cFunciones.BuscarDatos("SELECT CodigoProv AS Identificación, Nombre AS Proveedor FROM Proveedores", "Nombre", "Busqueda de Proveedor...", Me.SqlConnection1.ConnectionString)
                Case Keys.Enter
                    If Not IsNumeric(txtCodigo.Text) Then Exit Sub
                    Me.DataSetAbonosProveedor.Cuentas_Bancarias_Proveedor.Clear()
                    Me.DataSetAbonosProveedor.Cuentas_bancarias.Clear()

                    Me.CargarInformacionProveedor(txtCodigo.Text)
                    Me.Cargar_Cuentas_Bancarias_Proveedor(txtCodigo.Text)

                    Me.DataSetAbonosProveedor.Cuentas_bancarias.Clear()
                    Me.AdapterBancos.Fill(Me.DataSetAbonosProveedor, "Bancos")
                    Me.AdapterCuentasBancarias.Fill(Me.DataSetAbonosProveedor, "Cuentas_bancarias")
                    Me.ComboMoneda.Enabled = True

            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub CargarInformacionProveedor(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        Dim conex As SqlConnection = Me.SqlConnection1

        If codigo <> Nothing Then
            If conex.State = ConnectionState.Open Then conex.Close()
            conex.Open()
            rs = cConexion.GetRecorset(conex, "SELECT CodigoProv, Nombre from proveedores where codigoProv  ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs("CodigoProv")
                    txtNombre.Text = rs("Nombre")

                    funciones.Cargar_Tabla_Generico(Me.Adapter_Proveedor, "SELECT * from proveedores where codigoProv  ='" & codigo & "'", conex.ConnectionString)
                    Me.Adapter_Proveedor.Fill(Me.DataSetAbonosProveedor, "Proveedores")
                    Tabla = funciones.BuscarFacturas_Proveedor(codigo, conex.ConnectionString)
                    gridFacturas.DataSource = Tabla
                    gridFacturas.Enabled = False
                    'Saldo_Cuenta(Tabla)

                    conex.Close()
                    If Tabla.Rows.Count = 0 Then
                        MessageBox.Show("El Proveedor no tiene facturas pendientes...", "Atención...", MessageBoxButtons.OK)
                        txtCodigo.Focus()
                        rs.Close()
                        Exit Sub
                    Else
                        If VariarInteres = True Then
                            'txtIntereses.Enabled = True
                        Else
                            'txtIntereses.Enabled = False
                        End If
                        TxtAbono.Enabled = True
                        Me.txtNum_Recibo.Focus()
                    End If

                Else
                    MsgBox("La identificación del Proveedor no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigo.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If rs.IsClosed = False Then rs.Close()
                If conex.State <> ConnectionState.Closed Then conex.Close()
                cConexion.DesConectar(cConexion.Conectar(strModulo))
            End Try
        End If
    End Sub
    Private Sub Cargar_Cuentas_Bancarias_Proveedor(ByVal Cod_Proveedor As Integer)
        Dim Fx As New cFunciones
        'Me.DataSetAbonosProveedor.Cuentas_Bancarias_Proveedor.Clear()
        Fx.Cargar_Tabla_Generico(Me.Adapter_Cuenta_Proveedor, "SELECT Id_Cuenta, CodigoProv, TipoCuenta, Banco, CodMoneda, Num_Cuenta, MonedaNombre FROM Cuentas_Bancarias_Proveedor WHERE (CodigoProv = " & Cod_Proveedor & ")", Me.SqlConnection1.ConnectionString)
        Me.Adapter_Cuenta_Proveedor.Fill(Me.DataSetAbonosProveedor, "Cuentas_Bancarias_Proveedor")

    End Sub

    Sub Binding()
        Try
            Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAbonosProveedor, "abonocpagar.Anulado"))
            Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.id_abonocpagar"))
            Me.ComboBoxBanco.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAbonosProveedor, "abonocpagar.Codigo_banco"))
            Me.ComboBoxTipoPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.TipoDocumento"))
            Me.ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAbonosProveedor, "abonocpagar.cod_Moneda"))
            Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "Bancos.BancosCuentas_bancarias.NombreCuenta"))
            Me.Label_CodBanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "Bancos.Codigo_banco"))
            Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAbonosProveedor, "abonocpagar.Fecha"))
            Me.LabelFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.FechaEntrada"))
            Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Documento"))
            Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Cedula_Usuario"))
            Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Cod_Proveedor"))
            Me.txtNum_Recibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Recibo"))
            Me.TextBoxMontoLetras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.MontoLetras"))
            txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.Observaciones"))


            Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.TipoCambio"))

            Me.TextBoxIdFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Id_Compra"))
            'Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.MontoFactura"))
            Me.TextBoxProveedorDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Cod_Proveedor"))
            'Me.txtSaldoAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Saldo_Actual"))
            Me.txtAbonoSuMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Abono_SuMoneda"))
            Me.TxtAbono.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Abono"))
            Me.txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Factura"))
            Me.txtAjusteFac.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Ajuste")) 'ojo nuevo

            'Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar.Id_Abonocpagar")) '<<<<<<<<<<
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Function Saldo_Cuenta(ByVal Tabla1 As DataTable)
        Dim i As Integer
        Dim fila As DataRow
        Dim facturatemp As Double
        Dim Totaltemp As Double
        Dim SaldoCuenta As Double
        Dim CodigoMoneda As Integer
        Dim funciones As New cFunciones
        Dim ConexionLocal As New Conexion
        Dim rs As SqlDataReader
        Dim ValorFactura As Double
        SaldoCuenta = 0
        Try
            For i = 0 To Tabla1.Rows.Count - 1
                fila = Tabla1.Rows(i)
                facturatemp = fila("Factura")
                Totaltemp = fila("TotalFactura")
                CodigoMoneda = fila("Cod_MonedaCompra")
                rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT ValorCompra from Moneda where CodMoneda =" & CodigoMoneda)
                If rs.Read Then ValorFactura = rs("ValorCompra")
                rs.Close()
                ConexionLocal.DesConectar(ConexionLocal.Conectar)
                ' SaldoCuenta = SaldoCuenta + funciones.Saldo_de_Factura_Proveedor(facturatemp, ((Totaltemp * ValorFactura) / TipoCambio), ValorFactura, TipoCambio)
            Next

            ConexionLocal.Conectar()
            SaldoCuenta = ConexionLocal.SQLExeScalar("SELECT ROUND(SUM(dbo.SaldoFacturaCompra(GETDATE(), compras.Factura, compras.CodigoProv) * Moneda.ValorCompra / 1), 2) AS Saldo FROM compras LEFT OUTER JOIN Moneda ON compras.Cod_MonedaCompra = Moneda.CodMoneda WHERE (compras.CodigoProv = 2)")


            ConexionLocal = Nothing
            txtSaldoAntGen.Text = Format(SaldoCuenta, "#,#0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function
#End Region

    Private Sub InformacionFactura(ByVal Factura As Double, ByVal Proveedor As Integer)
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try
            If Factura <> Nothing Then
                rs = cConexion.GetRecorset(cConexion.Conectar(strModulo), "SELECT compras.Factura, compras.Fecha, compras.Vence, compras.Cod_MonedaCompra, compras.TotalFactura * (Moneda.ValorCompra / " & CDbl(Me.txtTipoCambio.Text) & ") AS TotalFactura,compras.CodigoProv, compras.Id_Compra, dbo.SaldoFacturaCompra(GETDATE(), compras.Factura, compras.CodigoProv) * (Moneda.ValorCompra / " & CDbl(Me.txtTipoCambio.Text) & ") AS SaldoFactura,Moneda.ValorCompra as TipoCambioFactura FROM compras LEFT OUTER JOIN Moneda ON compras.Cod_MonedaCompra = Moneda.CodMoneda WHERE (compras.CodigoProv = " & Proveedor & ") AND (compras.TipoCompra = 'CRE') AND (compras.Factura = " & Factura & ")")

                While rs.Read
                    Try
                        ' Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
                        Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").EndCurrentEdit()
                        Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").AddNew()

                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                    Try
                        txtFactura.Text = rs!Factura
                        ' dtEmitida.Text = rs!Fecha
                        txtMonto.Text = Format(rs!TotalFactura, "#,#0.00")
                        txtSaldo.Text = Format(rs!SaldoFactura, "#,#0.00")

                        'Ojo Nuevo
                        If IsNumeric(Me.txtDescuento.Text) Then
                            If CDec(Me.txtDescuento.Text) > 0 Then
                                Dim Desc As Decimal = Me.txtDescuento.Text
                                Me.txtAjusteFac.Text = CDec(CDec(Me.txtMonto.Text) * (Desc / 100)).ToString("N2")
                            Else
                                Me.txtAjusteFac.Text = 0
                            End If
                        Else
                            Me.txtAjusteFac.Text = 0
                        End If

                        'txtSaldoAnt.Text = txtSaldo.Text
                        TxtAbono.Text = Format(CDbl(txtSaldo.Text), "#,#0.00")
                        txtSaldoAct.Text = "0.00"
                        TextBoxTipoCambioFactura.Text = rs!TipoCambioFactura
                        Me.TextBoxProveedorDetalle.Text = Proveedor
                        Me.TextBoxIdFactura.Text = rs!Id_Compra
                        Me.TabControl1.SelectedIndex = 1
                        Me.TxtAbono.Focus()
                        Me.TxtAbono.SelectAll()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                cConexion.DesConectar(cConexion.sQlconexion)
            End If

        Catch ex As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical, "Alerta...!")
        End Try
    End Sub

    Private Sub gridFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridFacturas.Click
        Try
            Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = _
                   AdvBandedGridView1.CalcHitInfo(CType(gridFacturas, Control).PointToClient(Control.MousePosition))
            Dim data As DataRow
            Dim factura As Double

            If hi.RowHandle >= 0 Then
                data = AdvBandedGridView1.GetDataRow(hi.RowHandle)
            ElseIf AdvBandedGridView1.FocusedRowHandle >= 0 Then
                data = AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle)
            Else
                data = Nothing
                Exit Sub
            End If
            factura = data("Factura")

            Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
            InformacionFactura(factura, Me.txtCodigo.Text)

        Catch ex As SyntaxErrorException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyData = Keys.Enter Then
            txtFactura.Focus()
        End If
    End Sub

    Private Sub txtAbono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAbono.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                Dim NumFactura As String = Me.txtFactura.Text
                Dim ab As Double
                If TxtAbono.Text = "" Then TxtAbono.Text = 0

                If TxtAbono.Text = 0 Then
                    MessageBox.Show("Debe de digitar un monto mayor que 0", "Atención...", MessageBoxButtons.OK)
                    TxtAbono.Text = 0.0 : TxtAbono.Focus() : TxtAbono.SelectAll() : Exit Sub
                End If

                If CDbl(TxtAbono.Text) > CDbl(txtSaldo.Text) Then
                    MessageBox.Show("No puede abonarle más de lo que adeuda, Favor revisar...", "Atención...", MessageBoxButtons.OK)
                    TxtAbono.Text = 0.0 : TxtAbono.Focus() : TxtAbono.SelectAll() : Exit Sub
                Else
                    TxtAbono.Text = CDbl(TxtAbono.Text)
                    txtAbonoSuMoneda.Text = (CDbl(TxtAbono.Text) / CDbl(Me.TextBoxTipoCambioFactura.Text)) * CDbl(Me.txtTipoCambio.Text)
                    txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) - CDbl(TxtAbono.Text), "#,#0.00")
                    Dim txtPapa As String = Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Id_Abonocpagar")
                    Dim txt As String = Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Id_Abonocpagar")
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").AddNew()
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").CancelCurrentEdit()
                    Me.txtAbonoGen.Text = Format(Me.colAbono.SummaryItem.SummaryValue, "#,#0.00")
                    ' txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")
                    'me.txtAbonoGen.Text = 
                    Dim Num2Text As New cNum2Text
                    TextBoxMontoLetras.Text = Num2Text.Numero2Letra(Me.txtAbonoGen.Text, 0, 2, "COLON", "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino).ToUpper.ToString
                    'Me.TextBoxMontoLetras.Text = Num2Text.Numero2Letra(Me.txtAbonoGen.Text, 0, 2, "", "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino).ToUpper.ToString
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()

                    If Me.BindingContext(Me.Tabla).Current("Factura") = NumFactura Then
                        Me.BindingContext(Me.Tabla).RemoveAt(BindingContext(Me.Tabla).Position())
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Error este campo se requiere un númerico", "SeePos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtAbono.Text = 0
            TxtAbono.Focus()
        End Try

    End Sub

    Private Sub txtAbono_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtAbono.SelectAll()
    End Sub

    Private Sub txtIntereses_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Delete Then
            If buscando = False Then
                Eliminar_Factura_Detalle()
            End If
        End If
    End Sub

    Private Sub Eliminar_Factura_Detalle()
        Dim resp As Integer
        Dim FilaTabla As DataRow
        Dim Conexion2 As New Conexion
        Dim Facturatem As Long
        Dim Fechatem As Date
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count > 0 Then  ' si hay ubicaciones
                resp = MessageBox.Show("¿Desea eliminar esta factura del Recibo de Dinero?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    FilaTabla = Tabla.NewRow
                    FilaTabla("Factura") = Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura")
                    Facturatem = FilaTabla("factura")
                    Fechatem = Conexion2.SlqExecuteScalar(Conexion2.Conectar(strModulo), "Select Fecha from compras Where Factura =" & Facturatem & " and CodigoProv =" & Me.txtCodigo.Text)
                    Conexion2.DesConectar(Conexion2.sQlconexion)
                    FilaTabla("Fecha") = Fechatem
                    Tabla.Rows.Add(FilaTabla)

                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").RemoveAt(Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position)
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").EndCurrentEdit()
                    Me.txtAbonoGen.Text = Format(Me.colAbono.SummaryItem.SummaryValue, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()

                    Dim Num2Text As New cNum2Text
                    TextBoxMontoLetras.Text = Num2Text.Numero2Letra(Me.txtAbonoGen.Text, 0, 2, "", "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)

                Else
                    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Facturas para eliminar del Recibo de Dinero", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Private Sub txtAbono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtNum_Recibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum_Recibo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sende5r As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoPago.SelectedIndexChanged
        'Revisar : PORQUE SE PONE BLANCO EL BANCO
        ComboBoxCuentaBancariaDestino.Text = ""
        Select Case Me.ComboBoxTipoPago.SelectedIndex
            Case 0 : ComboBoxCuentaBancariaDestino.Enabled = False : BuscarNumeroCheque()
            Case 1 : TextBox1.Text = "" : ComboBoxCuentaBancariaDestino.Enabled = True
        End Select
    End Sub

    Private Sub ComboBoxs_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxBanco.KeyDown, ComboBoxCuentaBancaria.KeyDown, ComboMoneda.KeyDown, ComboBoxTipoPago.KeyDown, ComboBoxCuentaBancariaDestino.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                Me.ComboBoxBanco.SelectedIndex = 0
                Dim Conexion As New Conexion
                Conexion.Conectar(strModulo)
                txtSaldoAntGen.Text = Conexion.SQLExeScalar("SELECT ROUND(SUM(dbo.SaldoFacturaCompra(GETDATE(), compras.Factura, compras.CodigoProv) * Moneda.ValorCompra / " & Me.txtTipoCambio.Text & "), 2) AS Saldo FROM compras LEFT OUTER JOIN Moneda ON compras.Cod_MonedaCompra = Moneda.CodMoneda WHERE (FacturaCancelado = 0) AND (TipoCompra = 'CRE') AND  (compras.CodigoProv = " & Me.txtCodigo.Text & ")")
                Conexion = Nothing
                Me.TabPage1.Visible = True
                Me.TabControl1.SelectedIndex = 0
                BuscarNumeroCheque()
            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try

            SendKeys.Send("{TAB}")
            'Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
        End If
    End Sub

#Region "VALIDACION DE CAMPOS"
    Private Function ValidacionDatos()
        ValidacionDatos = False

        If Me.ComboMoneda.Text = "" Then
            MsgBox("Debe de seleccionar una moneda....", MsgBoxStyle.Exclamation)
            Me.ComboMoneda.Focus()
            Exit Function
        End If
        ValidacionDatos = True
    End Function
#End Region

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim sql As String
        Dim cx As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim Numero As Double

        If e.KeyCode = Keys.Enter Then
            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
            cnnConexion.Open()
            Numero = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "Select Num_Cheque, Id_CuentaBancaria FROM Cheques where Num_Cheque = " & Me.TextBox1.Text & " AND Id_CuentaBancaria=" & Me.ComboBoxCuentaBancaria.SelectedValue & " and Tipo = '" & ComboBoxTipoPago.Text & "' and anulado = 0 ")
            If Numero Then
                MsgBox("El Número de Cheque ya esta ingresado, favor revisar", MsgBoxStyle.Information, "Atención ...")
            Else
                'BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Documento") = TextBox1.Text
                BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoDocumento") = ComboBoxTipoPago.Text
                'BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
                gridFacturas.Enabled = True
                If ComboBoxCuentaBancariaDestino.Enabled = True Then
                    Me.ComboBoxCuentaBancariaDestino.Focus()
                End If
            End If
            cx.DesConectar(cnnConexion)
        End If
    End Sub

    Private Sub ComboBoxCuentaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxCuentaBancaria.SelectedIndexChanged
        BuscarNumeroCheque()
    End Sub

    Private Sub BuscarNumeroCheque()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
        Dim sql, Cuenta As String
        Dim Cx As New Conexion


        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()


        If Me.ComboBoxCuentaBancaria.SelectedIndex = -1 Then Exit Sub


        Cuenta = Me.ComboBoxCuentaBancaria.Text

        'Cuenta = Me.DataSetAbonosProveedor.Cuentas_bancarias(BindingContext(DataSetAbonosProveedor.Cuentas_bancarias).Position).Cuenta

        sql = " select isnull(max(num_cheque + 1 ),1) as numero from cheques che, Cuentas_bancarias CB  " & _
                " where Che.id_cuentabancaria = CB.Id_CuentaBancaria " & _
                " and CB.Cuenta ='" & Cuenta & "' and Tipo = 'CHEQUE'"


        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Exit Sub
        'Me.TextBox1.Text = rstReader("NUMERO")
        TextBox1.Text = 0
        rstReader.Close()
        If CDbl(TextBox1.Text) = 1 Then
            TextBox1.Text = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT ChequeInicial FROM Cuentas_bancarias WHERE(Cuenta = '" & Cuenta & "')")
            Cx.DesConectar(Cx.sQlconexion)
        End If
    End Sub

    Private Sub dtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ComboMoneda.SelectedIndex = 0
            ComboMoneda.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservaciones.GotFocus
        txtObservaciones.SelectAll()
    End Sub

    Private Sub txtNum_Recibo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum_Recibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigo.Text <> "0" And txtCodigo.Text <> "" Then
                If VerificaRecibo() Then
                    dtFecha.Focus()
                Else
                    txtNum_Recibo.Focus()
                End If
            End If
        End If
    End Sub

    Private Function VerificaRecibo() As Boolean
        Dim Cx As New Conexion
        Dim id As String
        Try
            id = Cx.SlqExecuteScalar(Cx.Conectar(), "SELECT Id_Abonocpagar FROM Abonocpagar WHERE Cod_Proveedor = " & txtCodigo.Text & " AND Recibo = '" & txtNum_Recibo.Text & "'")
            If id Is Nothing Then
                Return True
            Else
                MsgBox("El número de recibo ya existe para el proveedor!", MsgBoxStyle.Critical, "LcPymes")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Cx.DesConectar(Cx.sQlconexion)
        End Try
    End Function

    Private Sub txtTipoCambioD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipoCambioD.SelectedIndexChanged
        On Error Resume Next
        Me.txtTipoCambio.Text = Me.txtTipoCambioD.Text
    End Sub

    Private Sub txtTipoCambio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If ComboMoneda.Text <> "" Then
                    Me.txtDescuento.Focus()
                Else
                    MsgBox("Debe de seleccionar una moneda ...", MsgBoxStyle.Critical)
                    ComboMoneda.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try

        End If
    End Sub

    Private IdAjuste As Long = 0
    Private Function GuardarAjuste() As Boolean
        Me.IdAjuste = 0
        Dim db As OBSoluciones.SQL.Transaccion
        Try

            Dim SaldoAnterior, MontoAjuste, SaldoActual As Decimal
            For index As Integer = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
                Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = index
                MontoAjuste += CDec(Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Ajuste"))
            Next

            If MontoAjuste > 0 Then
                db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Dim IdAjuste As Long = 0
                SaldoAnterior = Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Saldo_Actual")
                db.SetParametro("@AjusteNo", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Recibo"))
                db.SetParametro("@Tipo", "CRE")
                db.SetParametro("@Cod_Proveedor", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"))
                db.SetParametro("@Nombre_Proveedor", Me.txtNombre.Text)
                db.SetParametro("@Fecha", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Fecha"))
                '*************************************************************************************************************************************************
                SaldoActual = CDec(Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Saldo_Actual")) - MontoAjuste
                db.SetParametro("@Saldo_Prev", SaldoAnterior)
                db.SetParametro("@Monto", MontoAjuste)
                db.SetParametro("@Saldo_Act", SaldoActual)
                '*************************************************************************************************************************************************
                db.SetParametro("@Observaciones", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Observaciones"))
                db.SetParametro("@Anula", False)
                db.SetParametro("@Cod_Usuario", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Cedula_Usuario"))
                db.SetParametro("@Contabilizado", False)
                db.SetParametro("@Cod_Moneda", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("cod_Moneda"))
                db.SetParametro("@Asiento", "")
                db.SetParametro("@FechaEntrada", Date.Now)
                IdAjuste = db.EjecutarScalar("Insert Into Ajustescpagar([AjusteNo],[Tipo],[Cod_Proveedor],[Nombre_Proveedor],[Fecha],[Saldo_Prev],[Monto],[Saldo_Act],[Observaciones],[Anula],[Cod_Usuario],[Contabilizado],[Cod_Moneda],[Asiento],[FechaEntrada]) values(@AjusteNo,@Tipo,@Cod_Proveedor,@Nombre_Proveedor,@Fecha,@Saldo_Prev,@Monto,@Saldo_Act,@Observaciones,@Anula,@Cod_Usuario,@Contabilizado,@Cod_Moneda,@Asiento,@FechaEntrada); Select SCOPE_IDENTITY();", CommandType.Text)
                Dim AjusteFactura As Decimal = 0
                For index As Integer = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
                    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = index
                    AjusteFactura = CDec(Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Ajuste"))
                    If AjusteFactura > 0 Then
                        db.SetParametro("@Id_AjustecPagar", IdAjuste)
                        db.SetParametro("@Factura", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura"))
                        db.SetParametro("@Tipo", "CRE")
                        db.SetParametro("@Monto", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("MontoFactura"))
                        db.SetParametro("@Saldo_Ant", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual"))
                        db.SetParametro("@Ajuste", AjusteFactura)
                        db.SetParametro("@Ajuste_SuMoneda", AjusteFactura)
                        db.SetParametro("@Saldo_Ajustado", CDec(Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual")) - AjusteFactura)
                        db.SetParametro("@Observaciones", "")
                        db.SetParametro("@TipoNota", "CRE")
                        db.SetParametro("@ID_Compra", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Id_Compra"))
                        db.SetParametro("@CuentaContable", "1")
                        db.SetParametro("@DescripcionCuentaContable", "GENERAL")
                        db.Ejecutar("Insert Into [dbo].[Detalle_AjustescPagar]([Id_AjustecPagar],[Factura],[Tipo],[Monto],[Saldo_Ant],[Ajuste],[Ajuste_SuMoneda],[Saldo_Ajustado],[Observaciones],[TipoNota],[ID_Compra],[CuentaContable],[DescripcionCuentaContable]) Values(@Id_AjustecPagar,@Factura,@Tipo,@Monto,@Saldo_Ant,@Ajuste,@Ajuste_SuMoneda,@Saldo_Ajustado,@Observaciones,@TipoNota,@ID_Compra,@CuentaContable,@DescripcionCuentaContable)", CommandType.Text)
                    End If
                Next
                db.Commit()
                Me.IdAjuste = IdAjuste
            End If
            Return True
        Catch ex As Exception
            Me.IdAjuste = 0
            db.Rollback()
        End Try
        Return False
    End Function

    Private Sub txtDescuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescuento.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtDescuento.Text <> "" Then
            If IsNumeric(Me.txtDescuento.Text) Then
                ComboMoneda.Enabled = False
                GroupBox_Datos_Cliente.Enabled = True
                txtObservaciones.Enabled = True
                GroupBox_Datos_Abonos.Enabled = True
                ' Me.gridFacturas.Enabled = True
                TabControl1.Visible = True
                TabControl1.SelectedIndex = 0
                ComboBoxBanco.Focus()
            Else
                MsgBox("El porcentaje de descuento debe ser un valor numerico", MsgBoxStyle.Exclamation, Me.Text)
            End If
        End If
    End Sub

    Private Sub txtAjusteFac_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAjusteFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(Me.txtAjusteFac.Text) Then
                Me.TxtAbono.Focus()
            End If
        End If
    End Sub

End Class
