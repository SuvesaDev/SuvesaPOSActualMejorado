Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmReciboDinero
    'Inherits System.Windows.Forms.Form
    Inherits FrmPlantilla

#Region "Variables"
    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    'Dim Anular As Boolean = False
    'Dim VariarInteres As Boolean = False
    Dim TipoCambioFact As Double 'Tipo Cambio de la Factura
    Dim TipoCambio As Double
    Dim Tabla As New DataTable
    Dim buscando As Boolean
    Public Trans As SqlTransaction
    Dim usua
    Friend WithEvents ckFiltrarIncobrable As System.Windows.Forms.CheckBox
    Dim PMU As New PerfilModulo_Class
#End Region

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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adAbonos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsRecibos1 As dsRecibos
    Friend WithEvents daDetalle_Abono As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtSaldoAct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAnt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIntereses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtEmitida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.Label
    Friend WithEvents gridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Factura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo1 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo2 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo4 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo5 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo6 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo_Ant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntereses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAbonoSuMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbonoB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoActGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbonoGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAntGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtNum_Recibo As System.Windows.Forms.TextBox
    Friend WithEvents Check_Dig_Recibo As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label_Id_Recibo As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents CB_Cheque As System.Windows.Forms.CheckBox
    Friend WithEvents txtCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colFechaFact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labAnulado As System.Windows.Forms.Label
    Friend WithEvents cbocheque As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboDinero))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ckFiltrarIncobrable = New System.Windows.Forms.CheckBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.ComboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.Label()
        Me.txtCedulaUsuario = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gridFacturas = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Factura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.txtTipoCambio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbSimbolo3 = New System.Windows.Forms.Label()
        Me.lbSimbolo6 = New System.Windows.Forms.Label()
        Me.lbSimbolo5 = New System.Windows.Forms.Label()
        Me.lbSimbolo4 = New System.Windows.Forms.Label()
        Me.lbSimbolo2 = New System.Windows.Forms.Label()
        Me.lbSimbolo1 = New System.Windows.Forms.Label()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldo = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldoAct = New DevExpress.XtraEditors.TextEdit()
        Me.txtAbono = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldoAnt = New DevExpress.XtraEditors.TextEdit()
        Me.txtIntereses = New DevExpress.XtraEditors.TextEdit()
        Me.dtEmitida = New System.Windows.Forms.DateTimePicker()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAbonoB = New DevExpress.XtraEditors.TextEdit()
        Me.txtAbonoSuMoneda = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaFact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo_Ant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntereses = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.adAbonos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daDetalle_Abono = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSaldoActGen = New DevExpress.XtraEditors.TextEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAbonoGen = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSaldoAntGen = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtNum_Recibo = New System.Windows.Forms.TextBox()
        Me.Check_Dig_Recibo = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DsRecibos1 = New LcPymes_5._2.dsRecibos()
        Me.Label_Id_Recibo = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.CB_Cheque = New System.Windows.Forms.CheckBox()
        Me.txtCheque = New DevExpress.XtraEditors.TextEdit()
        Me.labAnulado = New System.Windows.Forms.Label()
        Me.cbocheque = New System.Windows.Forms.ComboBox()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntereses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoSuMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtSaldoActGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAntGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRecibos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 391)
        Me.ToolBar1.Size = New System.Drawing.Size(712, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(584, 428)
        Me.DataNavigator.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(712, 32)
        Me.TituloModulo.Text = "Recibo de Dinero"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(1, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Recibo N°"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.ckFiltrarIncobrable)
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox6.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'ckFiltrarIncobrable
        '
        Me.ckFiltrarIncobrable.BackColor = System.Drawing.Color.Transparent
        Me.ckFiltrarIncobrable.Location = New System.Drawing.Point(213, 16)
        Me.ckFiltrarIncobrable.Name = "ckFiltrarIncobrable"
        Me.ckFiltrarIncobrable.Size = New System.Drawing.Size(147, 15)
        Me.ckFiltrarIncobrable.TabIndex = 189
        Me.ckFiltrarIncobrable.Text = "Filtrar Incobrables"
        Me.ckFiltrarIncobrable.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(13, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 13)
        Me.txtCodigo.TabIndex = 158
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(0, -1)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(528, 16)
        Me.Label37.TabIndex = 157
        Me.Label37.Text = "Datos del Cliente"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(80, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(80, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(448, 13)
        Me.txtNombre.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(8, 379)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 12)
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
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 378)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(328, 16)
        Me.txtObservaciones.TabIndex = 4
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.Enabled = False
        Me.ComboMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboMoneda.Location = New System.Drawing.Point(624, 32)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(97, 21)
        Me.ComboMoneda.TabIndex = 2
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(544, 34)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 16)
        Me.Label30.TabIndex = 164
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel1.Location = New System.Drawing.Point(80, 459)
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
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(125, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(216, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 170
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
        'dtFecha
        '
        Me.dtFecha.Checked = False
        Me.dtFecha.CustomFormat = "dd/MMMM/yyyy"
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(624, 73)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtFecha.TabIndex = 3
        Me.dtFecha.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(544, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gridFacturas
        '
        '
        '
        '
        Me.gridFacturas.EmbeddedNavigator.Name = ""
        Me.gridFacturas.Location = New System.Drawing.Point(8, 96)
        Me.gridFacturas.MainView = Me.AdvBandedGridView1
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.Size = New System.Drawing.Size(304, 112)
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
        Me.GridBand1.Width = 210
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
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Factura.SortIndex = 0
        Me.Factura.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.Factura.Visible = True
        Me.Factura.Width = 95
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
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Fecha.Visible = True
        Me.Fecha.Width = 115
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(624, 55)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(96, 16)
        Me.txtTipoCambio.TabIndex = 169
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbSimbolo3)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo6)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo5)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo4)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo2)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo1)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtSaldoAct)
        Me.GroupBox1.Controls.Add(Me.txtAbono)
        Me.GroupBox1.Controls.Add(Me.txtSaldoAnt)
        Me.GroupBox1.Controls.Add(Me.txtIntereses)
        Me.GroupBox1.Controls.Add(Me.dtEmitida)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(327, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 103)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lbSimbolo3
        '
        Me.lbSimbolo3.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo3.Location = New System.Drawing.Point(264, 16)
        Me.lbSimbolo3.Name = "lbSimbolo3"
        Me.lbSimbolo3.Size = New System.Drawing.Size(20, 12)
        Me.lbSimbolo3.TabIndex = 181
        Me.lbSimbolo3.Text = "¢"
        Me.lbSimbolo3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo6
        '
        Me.lbSimbolo6.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo6.Location = New System.Drawing.Point(264, 76)
        Me.lbSimbolo6.Name = "lbSimbolo6"
        Me.lbSimbolo6.Size = New System.Drawing.Size(20, 12)
        Me.lbSimbolo6.TabIndex = 180
        Me.lbSimbolo6.Text = "¢"
        Me.lbSimbolo6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo5
        '
        Me.lbSimbolo5.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo5.Location = New System.Drawing.Point(264, 56)
        Me.lbSimbolo5.Name = "lbSimbolo5"
        Me.lbSimbolo5.Size = New System.Drawing.Size(20, 12)
        Me.lbSimbolo5.TabIndex = 179
        Me.lbSimbolo5.Text = "¢"
        Me.lbSimbolo5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo4
        '
        Me.lbSimbolo4.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo4.Location = New System.Drawing.Point(264, 36)
        Me.lbSimbolo4.Name = "lbSimbolo4"
        Me.lbSimbolo4.Size = New System.Drawing.Size(20, 12)
        Me.lbSimbolo4.TabIndex = 178
        Me.lbSimbolo4.Text = "¢"
        Me.lbSimbolo4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo2
        '
        Me.lbSimbolo2.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo2.Location = New System.Drawing.Point(60, 77)
        Me.lbSimbolo2.Name = "lbSimbolo2"
        Me.lbSimbolo2.Size = New System.Drawing.Size(20, 12)
        Me.lbSimbolo2.TabIndex = 177
        Me.lbSimbolo2.Text = "¢"
        Me.lbSimbolo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo1
        '
        Me.lbSimbolo1.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo1.Location = New System.Drawing.Point(60, 57)
        Me.lbSimbolo1.Name = "lbSimbolo1"
        Me.lbSimbolo1.Size = New System.Drawing.Size(20, 12)
        Me.lbSimbolo1.TabIndex = 176
        Me.lbSimbolo1.Text = "¢"
        Me.lbSimbolo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = ""
        Me.txtMonto.Location = New System.Drawing.Point(88, 56)
        Me.txtMonto.Name = "txtMonto"
        '
        '
        '
        Me.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtMonto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.Enabled = False
        Me.txtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMonto.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtMonto.Size = New System.Drawing.Size(94, 17)
        Me.txtMonto.TabIndex = 174
        '
        'txtSaldo
        '
        Me.txtSaldo.EditValue = ""
        Me.txtSaldo.Location = New System.Drawing.Point(87, 75)
        Me.txtSaldo.Name = "txtSaldo"
        '
        '
        '
        Me.txtSaldo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldo.Properties.Enabled = False
        Me.txtSaldo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldo.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldo.Size = New System.Drawing.Size(96, 17)
        Me.txtSaldo.TabIndex = 172
        '
        'txtSaldoAct
        '
        Me.txtSaldoAct.EditValue = ""
        Me.txtSaldoAct.Location = New System.Drawing.Point(292, 76)
        Me.txtSaldoAct.Name = "txtSaldoAct"
        '
        '
        '
        Me.txtSaldoAct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldoAct.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoAct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAct.Properties.Enabled = False
        Me.txtSaldoAct.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoAct.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoAct.Size = New System.Drawing.Size(96, 17)
        Me.txtSaldoAct.TabIndex = 5
        '
        'txtAbono
        '
        Me.txtAbono.EditValue = ""
        Me.txtAbono.Location = New System.Drawing.Point(292, 56)
        Me.txtAbono.Name = "txtAbono"
        '
        '
        '
        Me.txtAbono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAbono.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtAbono.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbono.Properties.Enabled = False
        Me.txtAbono.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbono.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtAbono.Size = New System.Drawing.Size(96, 17)
        Me.txtAbono.TabIndex = 4
        '
        'txtSaldoAnt
        '
        Me.txtSaldoAnt.EditValue = ""
        Me.txtSaldoAnt.Location = New System.Drawing.Point(292, 36)
        Me.txtSaldoAnt.Name = "txtSaldoAnt"
        '
        '
        '
        Me.txtSaldoAnt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldoAnt.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoAnt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAnt.Properties.Enabled = False
        Me.txtSaldoAnt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoAnt.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoAnt.Size = New System.Drawing.Size(96, 17)
        Me.txtSaldoAnt.TabIndex = 3
        '
        'txtIntereses
        '
        Me.txtIntereses.EditValue = ""
        Me.txtIntereses.Location = New System.Drawing.Point(291, 16)
        Me.txtIntereses.Name = "txtIntereses"
        '
        '
        '
        Me.txtIntereses.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtIntereses.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtIntereses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIntereses.Properties.Enabled = False
        Me.txtIntereses.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtIntereses.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtIntereses.Size = New System.Drawing.Size(96, 17)
        Me.txtIntereses.TabIndex = 2
        '
        'dtEmitida
        '
        Me.dtEmitida.Checked = False
        Me.dtEmitida.CustomFormat = "dd/MMMM/yyyy"
        Me.dtEmitida.Enabled = False
        Me.dtEmitida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEmitida.Location = New System.Drawing.Point(88, 35)
        Me.dtEmitida.Name = "dtEmitida"
        Me.dtEmitida.Size = New System.Drawing.Size(94, 20)
        Me.dtEmitida.TabIndex = 1
        Me.dtEmitida.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'txtFactura
        '
        Me.txtFactura.EditValue = ""
        Me.txtFactura.Location = New System.Drawing.Point(88, 17)
        Me.txtFactura.Name = "txtFactura"
        '
        '
        '
        Me.txtFactura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtFactura.Properties.Enabled = False
        Me.txtFactura.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtFactura.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtFactura.Size = New System.Drawing.Size(94, 17)
        Me.txtFactura.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(5, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 16)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Monto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(5, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Saldo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(192, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 16)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Saldo Actual"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(192, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Abono"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(192, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Saldo Previo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(192, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Intereses"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(5, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Fecha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, -4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(377, 19)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Datos de la Factura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(5, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Factura No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbonoB
        '
        Me.txtAbonoB.EditValue = ""
        Me.txtAbonoB.Location = New System.Drawing.Point(770, 80)
        Me.txtAbonoB.Name = "txtAbonoB"
        '
        '
        '
        Me.txtAbonoB.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbonoB.Size = New System.Drawing.Size(72, 19)
        Me.txtAbonoB.TabIndex = 182
        '
        'txtAbonoSuMoneda
        '
        Me.txtAbonoSuMoneda.EditValue = ""
        Me.txtAbonoSuMoneda.Location = New System.Drawing.Point(736, 72)
        Me.txtAbonoSuMoneda.Name = "txtAbonoSuMoneda"
        '
        '
        '
        Me.txtAbonoSuMoneda.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbonoSuMoneda.Size = New System.Drawing.Size(80, 19)
        Me.txtAbonoSuMoneda.TabIndex = 183
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "abonoccobrar.abonoccobrardetalle_abonoccobrar"
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 216)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(712, 160)
        Me.GridControl2.TabIndex = 6
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactura, Me.colFechaFact, Me.colMonto, Me.colSaldo_Ant, Me.colIntereses, Me.colAbono, Me.colSaldo})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFactura
        '
        Me.colFactura.Caption = "Factura"
        Me.colFactura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFactura.FieldName = "Factura"
        Me.colFactura.FilterInfo = ColumnFilterInfo3
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFactura.VisibleIndex = 0
        Me.colFactura.Width = 86
        '
        'colFechaFact
        '
        Me.colFechaFact.Caption = "Fecha"
        Me.colFechaFact.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFechaFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaFact.FieldName = "Fecha"
        Me.colFechaFact.FilterInfo = ColumnFilterInfo4
        Me.colFechaFact.Name = "colFechaFact"
        Me.colFechaFact.VisibleIndex = 1
        Me.colFechaFact.Width = 69
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto Fact."
        Me.colMonto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo5
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 2
        Me.colMonto.Width = 104
        '
        'colSaldo_Ant
        '
        Me.colSaldo_Ant.Caption = "Saldo Ant."
        Me.colSaldo_Ant.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo_Ant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo_Ant.FieldName = "Saldo_Ant"
        Me.colSaldo_Ant.FilterInfo = ColumnFilterInfo6
        Me.colSaldo_Ant.Name = "colSaldo_Ant"
        Me.colSaldo_Ant.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo_Ant.VisibleIndex = 3
        Me.colSaldo_Ant.Width = 104
        '
        'colIntereses
        '
        Me.colIntereses.Caption = "Intereses"
        Me.colIntereses.DisplayFormat.FormatString = "#,#0.00"
        Me.colIntereses.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIntereses.FieldName = "Intereses"
        Me.colIntereses.FilterInfo = ColumnFilterInfo7
        Me.colIntereses.Name = "colIntereses"
        Me.colIntereses.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colIntereses.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colIntereses.VisibleIndex = 4
        Me.colIntereses.Width = 104
        '
        'colAbono
        '
        Me.colAbono.Caption = "Abono"
        Me.colAbono.DisplayFormat.FormatString = "#,#0.00"
        Me.colAbono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAbono.FieldName = "Abono"
        Me.colAbono.FilterInfo = ColumnFilterInfo8
        Me.colAbono.Name = "colAbono"
        Me.colAbono.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colAbono.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colAbono.VisibleIndex = 5
        Me.colAbono.Width = 104
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo Act."
        Me.colSaldo.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.FilterInfo = ColumnFilterInfo9
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo.VisibleIndex = 6
        Me.colSaldo.Width = 135
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'adAbonos
        '
        Me.adAbonos.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAbonos.InsertCommand = Me.SqlInsertCommand1
        Me.adAbonos.SelectCommand = Me.SqlSelectCommand1
        Me.adAbonos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "abonoccobrar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Recibo", "Id_Recibo"), New System.Data.Common.DataColumnMapping("Num_Recibo", "Num_Recibo"), New System.Data.Common.DataColumnMapping("Saldo_Cuenta", "Saldo_Cuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Actual", "Saldo_Actual"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Cheque", "Cheque"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente")})})
        Me.adAbonos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Recibo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Recibo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Cuenta", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Actual", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cheque", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cheque", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Recibo", System.Data.SqlDbType.BigInt, 0, "Num_Recibo"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 0, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 0, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 0, "Anula"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 0, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 0, "Asiento"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Cheque", System.Data.SqlDbType.VarChar, 0, "Cheque"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 0, "Cod_Cliente")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Recibo", System.Data.SqlDbType.BigInt, 0, "Num_Recibo"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 0, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 0, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 0, "Anula"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 0, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 0, "Asiento"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Cheque", System.Data.SqlDbType.VarChar, 0, "Cheque"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Original_Id_Recibo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Recibo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Cuenta", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Actual", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cheque", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cheque", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.BigInt, 8, "Id_Recibo")})
        '
        'daDetalle_Abono
        '
        Me.daDetalle_Abono.DeleteCommand = Me.SqlDeleteCommand2
        Me.daDetalle_Abono.InsertCommand = Me.SqlInsertCommand2
        Me.daDetalle_Abono.SelectCommand = Me.SqlSelectCommand2
        Me.daDetalle_Abono.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_abonoccobrar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Id_Recibo", "Id_Recibo"), New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Ant", "Saldo_Ant"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("Abono", "Abono"), New System.Data.Common.DataColumnMapping("Abono_SuMoneda", "Abono_SuMoneda"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha")})})
        Me.daDetalle_Abono.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Abono", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Abono_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abono_SuMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Recibo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.BigInt, 8, "Id_Recibo"), New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Float, 8, "Intereses"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 8, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 8, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Consecutivo, Id_Recibo, Factura, Tipo, Monto, Saldo_Ant, Intereses, Abono," & _
    " Abono_SuMoneda, Saldo, Fecha FROM detalle_abonoccobrar"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.BigInt, 8, "Id_Recibo"), New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Float, 8, "Intereses"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 8, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 8, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Abono", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Abono_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abono_SuMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Recibo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
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
        'daMoneda
        '
        Me.daMoneda.DeleteCommand = Me.SqlDeleteCommand3
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand3
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand3
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.daMoneda.UpdateCommand = Me.SqlUpdateCommand3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtSaldoActGen)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtAbonoGen)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtSaldoAntGen)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(352, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 64)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 16)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Saldos de la Cuenta"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoActGen
        '
        Me.txtSaldoActGen.EditValue = ""
        Me.txtSaldoActGen.Location = New System.Drawing.Point(256, 40)
        Me.txtSaldoActGen.Name = "txtSaldoActGen"
        '
        '
        '
        Me.txtSaldoActGen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoActGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoActGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoActGen.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoActGen.Size = New System.Drawing.Size(107, 19)
        Me.txtSaldoActGen.TabIndex = 162
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(160, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 161
        Me.Label18.Text = "Saldo Act."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbonoGen
        '
        Me.txtAbonoGen.EditValue = ""
        Me.txtAbonoGen.Location = New System.Drawing.Point(256, 24)
        Me.txtAbonoGen.Name = "txtAbonoGen"
        '
        '
        '
        Me.txtAbonoGen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtAbonoGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbonoGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbonoGen.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtAbonoGen.Size = New System.Drawing.Size(107, 19)
        Me.txtAbonoGen.TabIndex = 160
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(160, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Monto Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoAntGen
        '
        Me.txtSaldoAntGen.EditValue = ""
        Me.txtSaldoAntGen.Location = New System.Drawing.Point(256, 8)
        Me.txtSaldoAntGen.Name = "txtSaldoAntGen"
        '
        '
        '
        Me.txtSaldoAntGen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoAntGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAntGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoAntGen.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoAntGen.Size = New System.Drawing.Size(107, 19)
        Me.txtSaldoAntGen.TabIndex = 158
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(160, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Saldo Ant."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox1.Location = New System.Drawing.Point(8, 458)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 172
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtNum_Recibo
        '
        Me.txtNum_Recibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNum_Recibo.Enabled = False
        Me.txtNum_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum_Recibo.Location = New System.Drawing.Point(74, 17)
        Me.txtNum_Recibo.Name = "txtNum_Recibo"
        Me.txtNum_Recibo.Size = New System.Drawing.Size(72, 13)
        Me.txtNum_Recibo.TabIndex = 159
        '
        'Check_Dig_Recibo
        '
        Me.Check_Dig_Recibo.BackColor = System.Drawing.Color.Transparent
        Me.Check_Dig_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Dig_Recibo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Check_Dig_Recibo.Location = New System.Drawing.Point(4, 32)
        Me.Check_Dig_Recibo.Name = "Check_Dig_Recibo"
        Me.Check_Dig_Recibo.Size = New System.Drawing.Size(100, 16)
        Me.Check_Dig_Recibo.TabIndex = 173
        Me.Check_Dig_Recibo.Text = "Digitar Recibo"
        Me.Check_Dig_Recibo.UseVisualStyleBackColor = False
        Me.Check_Dig_Recibo.Visible = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(544, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 174
        Me.Label19.Text = "Tipo Cambio"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DsRecibos1
        '
        Me.DsRecibos1.DataSetName = "dsRecibos"
        Me.DsRecibos1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsRecibos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label_Id_Recibo
        '
        Me.Label_Id_Recibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label_Id_Recibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRecibos1, "abonoccobrar.Id_Recibo", True))
        Me.Label_Id_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Id_Recibo.ForeColor = System.Drawing.Color.White
        Me.Label_Id_Recibo.Location = New System.Drawing.Point(680, 11)
        Me.Label_Id_Recibo.Name = "Label_Id_Recibo"
        Me.Label_Id_Recibo.Size = New System.Drawing.Size(40, 12)
        Me.Label_Id_Recibo.TabIndex = 184
        Me.Label_Id_Recibo.Text = "000"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 443)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(712, 18)
        Me.StatusBar1.TabIndex = 185
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 75
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 275
        '
        'CB_Cheque
        '
        Me.CB_Cheque.BackColor = System.Drawing.Color.Transparent
        Me.CB_Cheque.Enabled = False
        Me.CB_Cheque.Location = New System.Drawing.Point(440, 376)
        Me.CB_Cheque.Name = "CB_Cheque"
        Me.CB_Cheque.Size = New System.Drawing.Size(64, 24)
        Me.CB_Cheque.TabIndex = 186
        Me.CB_Cheque.Text = "Cheque"
        Me.CB_Cheque.UseVisualStyleBackColor = False
        '
        'txtCheque
        '
        Me.txtCheque.EditValue = ""
        Me.txtCheque.Location = New System.Drawing.Point(504, 376)
        Me.txtCheque.Name = "txtCheque"
        '
        '
        '
        Me.txtCheque.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCheque.Properties.Enabled = False
        Me.txtCheque.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCheque.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtCheque.Size = New System.Drawing.Size(120, 19)
        Me.txtCheque.TabIndex = 163
        '
        'labAnulado
        '
        Me.labAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAnulado.ForeColor = System.Drawing.Color.Red
        Me.labAnulado.Location = New System.Drawing.Point(264, 288)
        Me.labAnulado.Name = "labAnulado"
        Me.labAnulado.Size = New System.Drawing.Size(168, 24)
        Me.labAnulado.TabIndex = 187
        Me.labAnulado.Text = "ANULADO"
        Me.labAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labAnulado.Visible = False
        '
        'cbocheque
        '
        Me.cbocheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocheque.Enabled = False
        Me.cbocheque.ForeColor = System.Drawing.Color.Blue
        Me.cbocheque.Items.AddRange(New Object() {"BCR", "BNCR", "Scotiabank", "BPopular"})
        Me.cbocheque.Location = New System.Drawing.Point(624, 376)
        Me.cbocheque.Name = "cbocheque"
        Me.cbocheque.Size = New System.Drawing.Size(97, 21)
        Me.cbocheque.TabIndex = 188
        '
        'frmReciboDinero
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 461)
        Me.Controls.Add(Me.cbocheque)
        Me.Controls.Add(Me.labAnulado)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtNum_Recibo)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label_Id_Recibo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Check_Dig_Recibo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.gridFacturas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboMoneda)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAbonoSuMoneda)
        Me.Controls.Add(Me.txtAbonoB)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.CB_Cheque)
        Me.Controls.Add(Me.txtCheque)
        Me.MaximumSize = New System.Drawing.Size(728, 500)
        Me.MinimumSize = New System.Drawing.Size(728, 500)
        Me.Name = "frmReciboDinero"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.txtCheque, 0)
        Me.Controls.SetChildIndex(Me.CB_Cheque, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.txtAbonoB, 0)
        Me.Controls.SetChildIndex(Me.txtAbonoSuMoneda, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.ComboMoneda, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.gridFacturas, 0)
        Me.Controls.SetChildIndex(Me.txtTipoCambio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GridControl2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Check_Dig_Recibo, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.Label_Id_Recibo, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtFecha, 0)
        Me.Controls.SetChildIndex(Me.txtNum_Recibo, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.labAnulado, 0)
        Me.Controls.SetChildIndex(Me.cbocheque, 0)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntereses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoSuMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtSaldoActGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAntGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRecibos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub frmReciboDinero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            daMoneda.Fill(DsRecibos1, "Moneda")

            'Establecer valores por defecto Abonoccobrar
            DsRecibos1.abonoccobrar.Id_ReciboColumn.AutoIncrement = True
            DsRecibos1.abonoccobrar.Id_ReciboColumn.AutoIncrementSeed = -1
            DsRecibos1.abonoccobrar.Id_ReciboColumn.AutoIncrementStep = -1
            DsRecibos1.abonoccobrar.Num_ReciboColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.AnulaColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.Cod_ClienteColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.Saldo_ActualColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.MontoColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.Saldo_CuentaColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.FechaColumn.DefaultValue = Now
            DsRecibos1.abonoccobrar.ContabilizadoColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.AsientoColumn.DefaultValue = 0
            DsRecibos1.abonoccobrar.Cod_MonedaColumn.DefaultValue = 1
            DsRecibos1.abonoccobrar.ObservacionesColumn.DefaultValue = ""
            DsRecibos1.abonoccobrar.Nombre_ClienteColumn.DefaultValue = ""
            DsRecibos1.abonoccobrar.ChequeColumn.DefaultValue = "0"
            DsRecibos1.abonoccobrar.bancoColumn.DefaultValue = "-"


            'Establecer valores por defecto Detalla_Abonoccobrar
            DsRecibos1.detalle_abonoccobrar.ConsecutivoColumn.AutoIncrement = True
            DsRecibos1.detalle_abonoccobrar.ConsecutivoColumn.AutoIncrementSeed = -1
            DsRecibos1.detalle_abonoccobrar.ConsecutivoColumn.AutoIncrementStep = -1
            DsRecibos1.detalle_abonoccobrar.Id_ReciboColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.FacturaColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.TipoColumn.DefaultValue = "CRE"
            DsRecibos1.detalle_abonoccobrar.FechaColumn.DefaultValue = Now.Date
            DsRecibos1.detalle_abonoccobrar.MontoColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.Saldo_AntColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.InteresesColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.AbonoColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.Abono_SuMonedaColumn.DefaultValue = 0
            DsRecibos1.detalle_abonoccobrar.SaldoColumn.DefaultValue = 0
            labAnulado.Visible = False

            TipoCambio = 1
            txtTipoCambio.Text = 1
            dtFecha.Value = Date.Now
            dtEmitida.Value = Date.Now
            ToolBar1.Buttons(1).Enabled = True
            txtUsuario.Focus()
            Binding()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Binding()
        txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.Cod_Cliente"))
        txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.Nombre_Cliente"))
        txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.Observaciones"))
        Me.cbocheque.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.banco"))

        txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.Ced_Usuario"))
        dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.Fecha"))
        txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "Moneda.ValorVenta"))
        lbSimbolo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "Moneda.Simbolo"))

        txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Monto"))
        txtSaldo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Saldo_Ant"))
        txtSaldoAct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Saldo"))
        txtIntereses.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Intereses"))
        txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Factura"))
        dtEmitida.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Fecha"))
        txtAbonoB.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Abono"))
        txtAbonoSuMoneda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar.Abono_SuMoneda"))
        txtSaldoActGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.Saldo_Actual"))
        txtAbonoGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.Monto"))
        txtSaldoAntGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.Saldo_Cuenta"))
        txtCheque.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsRecibos1, "abonoccobrar.Cheque"))

        CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", DsRecibos1, "abonoccobrar.Anula"))
        txtNum_Recibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsRecibos1, "abonoccobrar.Num_Recibo"))
        ComboMoneda.DataSource = DsRecibos1
        ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        GridControl2.DataMember = "abonoccobrar.abonoccobrardetalle_abonoccobrar"
        GridControl2.DataSource = DsRecibos1
        ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DsRecibos1, "abonoccobrar.Cod_Moneda"))

    End Sub
#End Region

#Region "Validacion Usuario"
    Public Sub Logeear(_Clave As String)
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If _Clave <> "" Then
            Me.txtUsuario.Text = _Clave
            If txtUsuario.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                End If
                While rs.Read
                    Try

                        PMU = VSM(rs("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                        If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                        BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()
                        BindingContext(DsRecibos1, "abonoccobrar").AddNew()

                        txtNombreUsuario.Text = rs("Nombre")
                        txtCedulaUsuario.Text = rs("Cedula")
                        Check_Dig_Recibo.Enabled = True

                        'If rs("AnuRecibos") = 1 Then Anular = True Else Anular = False
                        'If rs("VariarIntereses") = True Then
                        'VariarInteres = True
                        'Else
                        '    VariarInteres = False
                        'End If

                        txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        ToolBar1.Buttons(2).Enabled = True
                        NuevoRecibo()
                        ComboMoneda.Focus()
                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Logeear(Me.txtUsuario.Text)
        End If        
    End Sub
#End Region

    Private Function Numero_de_Recibo() As Double
        Dim cConexion As New Conexion
        Dim Num_Recibo As Double
        Num_Recibo = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT isnull(Max(Num_Recibo),0) FROM AbonoCCobrar"))
        Numero_de_Recibo = Num_Recibo + 1
        cConexion.DesConectar(cConexion.Conectar)
    End Function

    Private Sub NuevoRecibo()
        If ToolBar1.Buttons(0).Text = "Nuevo" Then 'no hay un registro pendiente
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8
            ToolBar1.Buttons(1).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBarRegistrar.Enabled = True
            labAnulado.Visible = False
            CB_Cheque.Checked = False
            If txtUsuario.Text = "" Then
                txtUsuario.Enabled = True
                txtUsuario.Focus()
            End If
            txtCodigo.Text = "" : txtNombre.Text = ""
            Try
                ComboMoneda.Enabled = True
                txtNum_Recibo.Text = Numero_de_Recibo()
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        Else
            Try
                If MessageBox.Show("Desea Guardar los Cambios del Recibo de Dinero", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Registrar()
                Else
                    BindingContext(DsRecibos1, "abonoccobrar").CancelCurrentEdit()
                    ToolBar1.Buttons(0).Text = "Nuevo"
                    ToolBar1.Buttons(0).ImageIndex = 0
                    ToolBar1.Buttons(1).Enabled = True
                    CB_Cheque.Checked = False
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtCedulaUsuario.Text = ""
                    GroupBox6.Enabled = False
                    txtObservaciones.Enabled = False
                    txtIntereses.Enabled = False
                    txtAbono.Enabled = False
                    ComboMoneda.Enabled = False
                    CB_Cheque.Enabled = False
                    cbocheque.Enabled = False
                    txtCheque.Enabled = False
                    DsRecibos1.detalle_abonoccobrar.Clear()
                    DsRecibos1.abonoccobrar.Clear()
                    Tabla.Clear()
                    ToolBarRegistrar.Enabled = False
                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub
    Private caja_factura As Integer = 0
    Private Num_Apertura As Integer = 0
    Private Function CajaAbierta(ByVal _caja As Integer) As Boolean
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * from aperturacaja where estado = 'A' and anulado = 0 and num_caja = " & _caja, dts, CadenaConexionSeePOS)
            If dts.Rows.Count > 0 Then
                Me.Num_Apertura = 0
                Me.Num_Apertura = dts.Rows(0).Item("NApertura")
                Return True
            Else
                Me.Num_Apertura = 0
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            Return False
        End Try
    End Function

    Private Sub Registrar()
        Dim AplicarenCaja3 As Boolean = False
        Dim i As Integer
        Dim Funciones As New Conexion
        Dim FactTemp As Double
        Dim NumeroFicha As String = ""
        Try

            If Me.AplicaCambioenCaja = False Then
                Dim frmcajas As New frmOpcionCajaRecibo
                frmcajas.ShowDialog()
                Me.caja_factura = frmcajas.Caja

                If CajaAbierta(caja_factura) = False Then
                    MsgBox("La caja #" & caja_factura & " no esta abierta, no se puede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
                    Exit Sub
                End If
            Else
                If MsgBox("Desea Registrar el abono en la caja 3?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    AplicarenCaja3 = True
                    caja_factura = 3
                    If CajaAbierta(caja_factura) = False Then
                        MsgBox("La caja #" & caja_factura & " no esta abierta, no se puede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
                        Exit Sub
                    End If
                Else
                    Dim frm As New frmIngresarNumerodeFicha
                    frm.IdUsuario = BindingContext(DsRecibos1, "abonoccobrar").Current("Ced_Usuario")
                    frm.txtNumero.Text = ""
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        NumeroFicha = frm.txtNumero.Text
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            If MessageBox.Show("¿Desea guardar el recibo de dinero?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").CancelCurrentEdit()
                If BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count = 0 Then
                    MsgBox("Debe abonar mínimo una factura", MsgBoxStyle.Information)
                    Exit Sub
                End If

                If Check_Dig_Recibo.Checked = False Then txtNum_Recibo.Text = Numero_de_Recibo()

                If Funciones.SlqExecuteScalar(Funciones.Conectar, "SELECT Num_Recibo FROM abonoccobrar WHERE (Num_Recibo =" & CDbl(txtNum_Recibo.Text) & ")") <> Nothing Then
                    MsgBox("No se puede Registrar, ya existe un recibo con este número de recibo", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If Me.AplicaCambioenCaja = False Or AplicarenCaja3 = True Then
                    If CB_Cheque.Checked = False Or (CB_Cheque.Checked = True And (txtCheque.Text = "0" And txtCheque.Text = "")) Then
                        Dim FormaPago As New FormaPago
                        FormaPago.ShowDialog()
                        If FormaPago.DialogResult = DialogResult.OK Then
                            If FormaPago.Cheque <> "" Then
                                CB_Cheque.Checked = True
                                txtCheque.EditValue = FormaPago.Cheque
                            Else
                                CB_Cheque.Checked = False
                            End If
                        Else
                            Exit Sub
                        End If
                    End If
                End If

                BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()
                BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()

                ''llamar al formulario de opciones de pago
                'Dim Movimiento_Pago_Abonos As New frmMovimientoCajaPagoAbono(usua)
                'Movimiento_Pago_Abonos.Factura = CDbl(txtNum_Recibo.Text)
                'Movimiento_Pago_Abonos.fecha = "" & dtFecha.Text
                'Movimiento_Pago_Abonos.Total = CDbl(txtAbonoGen.Text)
                'Movimiento_Pago_Abonos.Tipo = "ABO"
                'Movimiento_Pago_Abonos.codmod = ComboMoneda.SelectedValue
                'Movimiento_Pago_Abonos.ShowDialog()

                'If Movimiento_Pago_Abonos.Registra Then

                For i = 0 To BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count - 1
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position = i
                    If BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Saldo") = 0 Then
                        FactTemp = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
                        If (Funciones.UpdateRecords("Ventas", "FacturaCancelado = 1", "Num_Factura =" & FactTemp & " and Tipo = '" & BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") & "'")) <> "" Then
                            MsgBox("Problemas al Registrar las facturas como canceladas, reintente hacer el abono", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                Next

                If registrar_Abono(AplicarenCaja3) And Ingresar_OpcionPago(caja_factura, AplicarenCaja3) Then
                    ToolBar1.Buttons(1).Enabled = True
                    ToolBar1.Buttons(0).Text = "Nuevo"
                    ToolBar1.Buttons(0).ImageIndex = 0
                    ToolBarRegistrar.Enabled = False
                    MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    Dim dbo As New GestioDatos
                    Dim numero_recibo As Double = Me.BindingContext(DsRecibos1, "abonoccobrar").Current("id_recibo")
                    If Me.AplicaCambioenCaja = False Or AplicarenCaja3 = True Then
                        dbo.Ejecuta("Update abonoccobrar set num_caja = " & Me.caja_factura & ", Num_Apertura = " & Me.Num_Apertura & " where id_recibo = " & numero_recibo)
                        If MessageBox.Show("¿Desea imprimir este Recibo de Dinero?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            Imprimir(True)
                        End If
                    Else
                        dbo.Ejecuta("Update PreAbonocCobrar Set Ficha = " & NumeroFicha & "  where id_recibo = " & numero_recibo)
                    End If


                    Tabla.Clear()
                    DsRecibos1.detalle_abonoccobrar.Clear()
                    DsRecibos1.abonoccobrar.Clear()

                    'Dim reinicia As New frmReciboDinero
                    'reinicia.MdiParent = Me.MdiParent
                    'reinicia.Show()
                    'reinicia.Logeear(Me.txtUsuario.Text)
                    Me.Close()

                Else
                    MsgBox("Problemas al registrar el abono y/o pagos, intentelo de nuevo ", MsgBoxStyle.Critical)
                    Trans.Rollback()
                    'Movimiento_Pago_Abonos.Trans.Rollback()
                    Exit Sub
                End If

            End If
            'End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function AplicaCambioenCaja() As Boolean
        Dim dt As New DataTable
        Dim Modocaja As Boolean = False
        cFunciones.Llenar_Tabla_Generico("Select ModoCaja from Configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Modocaja = dt.Rows(0).Item("ModoCaja")
        End If
        Return Modocaja
    End Function

    Function registrar_Abono(Optional ByVal _ObligaCaja3 As Boolean = False) As Boolean

        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Trans = SqlConnection1.BeginTransaction
        Try

            If Me.AplicaCambioenCaja = True Then
                If _ObligaCaja3 = True Then
                    If adAbonos.InsertCommand.CommandText.IndexOf("PreAbonocCobrar") > 0 Then
                        adAbonos.InsertCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")
                        adAbonos.UpdateCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")
                        adAbonos.DeleteCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")

                        daDetalle_Abono.InsertCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
                        daDetalle_Abono.UpdateCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
                        daDetalle_Abono.DeleteCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
                    End If
                Else
                    If Not adAbonos.InsertCommand.CommandText.IndexOf("PreAbonocCobrar") > 0 Then
                        adAbonos.InsertCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")
                        adAbonos.UpdateCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")
                        adAbonos.DeleteCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")

                        daDetalle_Abono.InsertCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
                        daDetalle_Abono.UpdateCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
                        daDetalle_Abono.DeleteCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
                    End If
                End If                
            End If


            adAbonos.InsertCommand.Transaction = Trans
            adAbonos.DeleteCommand.Transaction = Trans
            adAbonos.UpdateCommand.Transaction = Trans

            daDetalle_Abono.InsertCommand.Transaction = Trans
            daDetalle_Abono.DeleteCommand.Transaction = Trans
            daDetalle_Abono.UpdateCommand.Transaction = Trans

            adAbonos.Update(DsRecibos1, "abonoccobrar")
            daDetalle_Abono.Update(DsRecibos1, "detalle_abonoccobrar")

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

    Private Sub BuscarRecibo()
        Dim Fx As New cFunciones
        Dim identificador As Double

        Try
            If BindingContext(DsRecibos1, "abonoccobrar").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Recibo de Dinero, si continúa se perderan los datos del Recibo actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            ToolBarRegistrar.Enabled = False
            DsRecibos1.detalle_abonoccobrar.Clear()
            DsRecibos1.abonoccobrar.Clear()
            CB_Cheque.Enabled = False
            txtCheque.Enabled = False
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha5C("SELECT abonoccobrar.Id_Recibo, abonoccobrar.Num_Recibo as Recibo , abonoccobrar.Nombre_Cliente AS Nombre_Cliente, abonoccobrar.Fecha,  abonoccobrar.Monto FROM abonoccobrar INNER JOIN  Moneda ON abonoccobrar.Cod_Moneda = Moneda.CodMoneda ORDER BY abonoccobrar.Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Recibo de Dinero"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Exit Sub
            End If
            Check_Dig_Recibo.Enabled = False
            ComboMoneda.Enabled = False
            LlenarVentas(identificador)
            ' si esta venta aun no ha sido anulada
            If BindingContext(DsRecibos1, "abonoccobrar").Current("Anula") = False Then
                ToolBar1.Buttons(3).Enabled = True
                labAnulado.Visible = False
            Else
                labAnulado.Visible = True
            End If

            If BindingContext(DsRecibos1, "abonoccobrar").Current("Cheque") <> "0" Then CB_Cheque.Checked = True Else CB_Cheque.Checked = False
            txtCheque.Enabled = False

            GridControl2.Enabled = False
            ToolBar1.Buttons(4).Enabled = True
            ToolBar1.Buttons(0).Enabled = True
            ToolBarRegistrar.Enabled = False

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarVentas(ByVal Id As Double)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim IdRec As Long
        'Dentro de un Try/Catch por si se produce un error
        Try
            IdRec = CInt(cConexion.SlqExecuteScalar(cConexion.Conectar, "Select Id_Recibo from abonoccobrar where Id_Recibo =" & Id))
            cConexion.DesConectar(cConexion.Conectar)
            '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM abonoccobrar WHERE (Id_Recibo = @Id_Factura)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            cmdv.Parameters("@Id_Factura").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(DsRecibos1, "abonoccobrar")
            '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            'Dim sConn As String = CadenaConexionSeePOS
            'cnn = New SqlConnection(sConn)
            'cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM detalle_abonoccobrar WHERE (Id_Recibo = @Id_Factura) "
            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            cmd.Parameters("@Id_Factura").Value = IdRec
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(DsRecibos1.detalle_abonoccobrar)
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

    Function Registrar_Anulacion_Venta() As Boolean
        Dim i As Long
        Dim Facttem As Double
        Dim Funciones As New Conexion
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            SqlUpdateCommand1.Transaction = Trans
            adAbonos.Update(DsRecibos1, "abonoccobrar")
            For i = 0 To BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count - 1
                BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position = i
                Facttem = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
                Funciones.UpdateRecords("Ventas", "FacturaCancelado = 0", "Num_Factura =" & Facttem & "and Tipo = '" & BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") & "'")
            Next
            Funciones.UpdateRecords("OpcionesDePago", "FormaPago = 'ANU'", "(Documento = " & txtNum_Recibo.Text & ") AND (TipoDocumento = 'ABO')")
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    Private Sub AnularRecibo()
        Try
            Dim resp As Integer
            If BindingContext(DsRecibos1, "abonoccobrar").Count > 0 Then
                If BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Anular este Recibo de Dinero?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        labAnulado.Visible = True
                        BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()

                        If Registrar_Anulacion_Venta() Then

                            DsRecibos1.AcceptChanges()
                            MsgBox("El Recibo de Dinero ha sido anulado correctamente", MsgBoxStyle.Information)
                            DsRecibos1.detalle_abonoccobrar.Clear()
                            DsRecibos1.abonoccobrar.Clear()
                            ToolBar1.Buttons(4).Enabled = True
                            ToolBar1.Buttons(1).Enabled = True

                            ToolBar1.Buttons(0).Text = "Nuevo"
                            ToolBar1.Buttons(0).ImageIndex = 0
                            ToolBar1.Buttons(3).Enabled = False
                            ToolBar1.Buttons(2).Enabled = False
                            ToolBar1.Buttons(4).Enabled = False


                            GroupBox6.Enabled = False

                            txtUsuario.Enabled = True
                            txtUsuario.Text = ""
                            txtNombreUsuario.Text = ""
                            labAnulado.Visible = False
                            txtUsuario.Focus()
                        End If

                    Else : Exit Sub

                    End If
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function FormatoRecibo() As String
        Dim formato As String = GetSetting("SeeSOFT", "SeePOS", "FormatoRecibo")
        If formato = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "FormatoRecibo", "PVE")
            formato = "PVE"
        End If
        Return formato
    End Function

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION" 'FACTURACION
                    If PrinterToSelect = 0 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CONTADO"
                    If PrinterToSelect = 1 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CREDITO"
                    If PrinterToSelect = 2 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA"
                    If PrinterToSelect = 3 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FAX"
                    If PrinterToSelect = 4 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA02"
                    If PrinterToSelect = 5 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FACTURACION02" 'FACTURACION
                    If PrinterToSelect = 6 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If

                Case "CUPONES" 'CUPONES DE RIFAS
                    If PrinterToSelect = 7 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If

            End Select
        Next

        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If PrinterDialog.ShowDialog.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        Else
            Return ""
        End If
    End Function

    Private Function GetNumCaja(_Id As String) As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Num_Caja from abonoccobrar Where Id_Recibo = " & _Id, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Num_Caja")
        Else
            Return 1
        End If
    End Function

    Public recibodineroPVE As New ReciboDineroPV
    Private Sub Imprimir(_ObligaCaja3 As Boolean)
        If Me.FormatoRecibo = "PVE" And _ObligaCaja3 = False Then
            Dim NumCaja As Integer = Me.GetNumCaja(Label_Id_Recibo.Text)

            If NumCaja = 1 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

                recibodineroPVE.SetParameterValue(0, CDbl(Label_Id_Recibo.Text))
                recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If

            If NumCaja = 2 Then
                Dim PrinterSettings1 As New Printing.PrinterSettings
                Dim PageSettings1 As New Printing.PageSettings
                PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)

                recibodineroPVE.SetParameterValue(0, CDbl(Label_Id_Recibo.Text))
                recibodineroPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            End If
        Else
            'PARA EL PROXIMO QUE ANDE CON ESTA VARA.. SAJ 27112007 
            'EL MODULO ANALIZA SI EXISTE  EN LA RUTA ESPECIFICADA EL REPORTE EN CUESTION,
            ' DADO EL CASO DE QUE EL REPORTE NO EXISTA CARGA EL STANDAR DEL SISTEMA
            Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize

            If System.IO.File.Exists(Application.StartupPath & "\Reportes\ReciboDinero_Personalizada.rpt") = True Then
                ReporteDocumento.Load(Application.StartupPath & "\Reportes\ReciboDinero_Personalizada.rpt")
            Else
                ReporteDocumento = New ReciboDinero_doble
            End If

            ReporteDocumento.SetParameterValue(0, CDbl(Label_Id_Recibo.Text))
            CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent)
        End If
    End Sub

    Private Sub ComboMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboMoneda.Enabled = False
            GroupBox6.Enabled = True
            txtCodigo.Focus()
        End If
    End Sub

#Region "Clientes"
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            txtCodigo.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

            CargarInformacionCliente(txtCodigo.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionCliente(txtCodigo.Text)
        End If
    End Sub

    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, Nombre from Clientes where Identificacion ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs("Identificacion")
                    txtNombre.Text = rs("Nombre")
                    Tabla = funciones.BuscarFacturas(codigo, Me.ckFiltrarIncobrable.Checked)
                    gridFacturas.DataSource = Tabla
                    Saldo_Cuenta(Tabla)
                    If Tabla.Rows.Count = 0 Then
                        MessageBox.Show("El cliente no tiene facturas pendientes...", "Atención...", MessageBoxButtons.OK)
                        txtCodigo.Focus()
                        rs.Close()
                        Exit Sub
                    Else
                        txtObservaciones.Enabled = True
                        CB_Cheque.Enabled = True
                        txtObservaciones.Focus()
                        txtIntereses.Enabled = PMU.Others
                        txtAbono.Enabled = True
                    End If
                Else
                    MsgBox("La identificación del Cliente no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigo.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        End If
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
        TipoCambio = txtTipoCambio.Text

        For i = 0 To Tabla1.Rows.Count - 1
            fila = Tabla1.Rows(i)
            facturatemp = fila("Factura")
            Totaltemp = fila("Total")
            CodigoMoneda = fila("Cod_Moneda")
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT ValorCompra from Moneda where CodMoneda =" & CodigoMoneda)
            If rs.Read Then ValorFactura = rs("ValorCompra")
            rs.Close()
            ConexionLocal.DesConectar(ConexionLocal.Conectar)
            SaldoCuenta = SaldoCuenta + funciones.Saldo_de_Factura(facturatemp, ((Totaltemp * ValorFactura) / TipoCambio), ValorFactura, TipoCambio, fila("Tipo"), Me.txtCodigo.Text)
        Next
        ConexionLocal = Nothing
        txtSaldoAntGen.Text = Format(SaldoCuenta, "#,#0.00")
    End Function
#End Region

    Private Sub informacionfactura(ByVal factura As Double, ByVal Tipo As String, Num_Caja As Integer)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim Codigo As Integer
        Dim rs As SqlDataReader
        Dim Conexion2 As New Conexion
        Dim Interes As Double
        Dim DiasAtraso As Double
        Dim FechaUltAbono As String

        If factura <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "Select Num_Factura, Tipo, Fecha, Vence, Cod_Moneda, Total, EnProcesoIncobrable from Ventas where Num_Caja = " & Num_Caja & " and Cod_Cliente = " & Me.txtCodigo.Text & " And Tipo = '" & Tipo & "' and Num_Factura =" & factura & " order by Fecha")
            While rs.Read
                Try
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").CancelCurrentEdit()
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").AddNew()
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
                Try

                    If rs("EnProcesoIncobrable") Then
                        MsgBox("Esta factura esta en proceso judicial" & vbCrLf _
                               & "Si puede registrar el abono.", MsgBoxStyle.Exclamation, "Advertencia!!!")
                    End If

                    Codigo = rs("Cod_moneda")
                    TipoCambioFact = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select ValorVenta from Moneda Where CodMoneda =" & Codigo)
                    Conexion2.DesConectar(Conexion2.Conectar)
                    Interes = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select Intereses from configuraciones")
                    Conexion2.DesConectar(Conexion2.Conectar)
                    DiasAtraso = DateDiff(DateInterval.Day, rs("Vence"), Date.Now)
                    txtFactura.Text = rs("Num_Factura")
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") = Tipo
                    dtEmitida.Text = rs("Fecha")
                    txtMonto.Text = Format((rs("Total") * TipoCambioFact) / txtTipoCambio.Text, "#,#0.00")
                    txtSaldo.Text = Format(funciones.Saldo_de_Factura(factura, (rs("Total") * TipoCambioFact) / txtTipoCambio.Text, TipoCambioFact, txtTipoCambio.Text, Tipo, Me.txtCodigo.Text), "#,#0.00")
                    FechaUltAbono = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select ISNULL(MAX(Fecha), 0) from UltimoRecibo where Tipo = '" & Tipo & "' and Factura = " & txtFactura.Text)
                    Conexion2.DesConectar(Conexion2.Conectar)
                    If FechaUltAbono <> "01/01/1900" Then
                        If rs("Vence") < FechaUltAbono Then
                            DiasAtraso = DateDiff(DateInterval.Day, CDate(FechaUltAbono), Date.Now)
                        End If
                    End If

                    If DiasAtraso > 0 Then
                        txtIntereses.Text = Format((DiasAtraso * (Interes / 100 / 30)) * txtSaldo.Text, "#,#0.00")
                    Else
                        txtIntereses.Text = "0.00"
                    End If

                    txtSaldoAnt.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtIntereses.Text), "#,#0.00")
                    txtAbono.Text = Format(CDbl(txtSaldoAnt.Text), "#,#0.00")
                    txtSaldoAct.Text = "0.00"
                    If txtIntereses.Enabled = True Then
                        txtIntereses.Focus()
                    Else
                        txtAbono.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End While
            Conexion2 = Nothing
            cConexion.DesConectar(cConexion.Conectar)
            cConexion = Nothing
        End If
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
            End If
            factura = data("Factura")
            BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()
            informacionfactura(factura, data("Tipo"), data("Num_Caja"))

        Catch ex As SyntaxErrorException
            MsgBox(ex.Message)
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

    Private Sub txtIntereses_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIntereses.KeyDown
        Dim Temp As Double
        If e.KeyData = Keys.Enter Then
            Try
                Temp = CDbl(txtIntereses.Text)
                If txtIntereses.Text = "" Then txtIntereses.Text = "0.00"
                txtSaldoAnt.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtIntereses.Text), "#,#0.00")
                txtAbono.Text = Format(CDbl(txtSaldoAnt.Text), "#,#0.00")
                txtAbono.Focus()
            Catch ex As Exception
                MessageBox.Show("No era un númerico, favor volver a ingresar el monto", "SeePos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIntereses.Text = 0
                txtIntereses.Focus()
            End Try
        End If
    End Sub

    Private Sub txtIntereses_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIntereses.GotFocus
        txtIntereses.SelectAll()
    End Sub

    Private Sub txtAbono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbono.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                Dim int As Double
                Dim ab As Double
                If txtAbono.Text = "" Then txtAbono.Text = 0
                If txtAbono.Text = 0 Then
                    MessageBox.Show("Debe de digitar un monto mayor que 0", "Atención...", MessageBoxButtons.OK)
                    txtAbono.Text = 0.0 : txtAbono.Focus() : txtAbono.SelectAll() : Exit Sub
                End If
                If CDbl(txtAbono.Text) > CDbl(txtSaldoAnt.Text) Then
                    MessageBox.Show("No puede abonarle más de lo que adeuda, Favor revisar...", "Atención...", MessageBoxButtons.OK)
                    txtAbono.Text = 0.0 : txtAbono.Focus() : txtAbono.SelectAll() : Exit Sub
                Else
                    txtAbono.Text = CDbl(txtAbono.Text)
                    If CDbl(txtAbono.Text) < CDbl(txtIntereses.Text) Then
                        txtAbonoB.Text = 0
                        txtIntereses.Text = txtAbono.Text
                    Else
                        txtAbonoB.Text = CDbl(txtAbono.Text) - CDbl(txtIntereses.Text)
                        txtAbonoSuMoneda.Text = (CDbl(txtAbonoB.Text) / TipoCambioFact) * CDbl(txtTipoCambio.Text)
                        txtSaldoAct.Text = Format(CDbl(txtSaldoAnt.Text) - CDbl(txtAbono.Text), "#,#0.00")
                    End If

                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Num_Caja") = "0"

                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()
                    int = colIntereses.SummaryItem.SummaryValue
                    ab = colAbono.SummaryItem.SummaryValue
                    txtAbonoGen.Text = Format(ab + int, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text + colIntereses.SummaryItem.SummaryValue - txtAbonoGen.Text, "#,#0.00")
                    If BindingContext(Tabla).Current("Factura") = txtFactura.EditValue Then
                        BindingContext(Tabla).RemoveAt(BindingContext(Tabla).Position())
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error este campo se requiere un númerico", "SeePos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAbono.Text = 0
            txtAbono.Focus()
        End Try
    End Sub

    Private Sub txtAbono_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbono.GotFocus
        txtAbono.SelectAll()
    End Sub

    Private Sub txtIntereses_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntereses.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Factura_Detalle()
        End If
    End Sub

    Private Sub Eliminar_Factura_Detalle()
        Dim resp As Integer
        Dim FilaTabla As DataRow
        Dim Conexion2 As New Conexion
        Dim Facturatem As Long
        Dim Fechatem As Date

        Try 'se intenta hacer
            If BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar esta factura del Recibo de Dinero?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    FilaTabla = Tabla.NewRow
                    FilaTabla("Factura") = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
                    FilaTabla("Tipo") = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo")
                    'Facturatem = FilaTabla("factura")
                    'Fechatem = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select Fecha from Ventas Where Num_Factura =" & Facturatem & " AND Tipo = '" & FilaTabla("Tipo") & "'")
                    'Conexion2.DesConectar(Conexion2.Conectar)
                    'FilaTabla("Fecha") = Fechatem
                    FilaTabla("Total") = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Monto")
                    FilaTabla("Fecha") = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Fecha")
                    Tabla.Rows.Add(FilaTabla)
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").RemoveAt(BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position)
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()
                    txtAbonoGen.Text = Format(colAbono.SummaryItem.SummaryValue + colIntereses.SummaryItem.SummaryValue, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")
                    BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()
                Else
                    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Facturas para eliminar del Recibo de Dinero", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Private Sub txtIntereses_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIntereses.LostFocus
        Dim Temp As Double
        Try
            Temp = CDbl(txtIntereses.Text)
        Catch ex As Exception
            txtIntereses.Text = 0
        End Try
    End Sub

    Private Sub txtAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbono.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub lbSimbolo1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSimbolo1.TextChanged
        lbSimbolo2.Text = lbSimbolo1.Text
        lbSimbolo3.Text = lbSimbolo1.Text
        lbSimbolo4.Text = lbSimbolo1.Text
        lbSimbolo5.Text = lbSimbolo1.Text
        lbSimbolo6.Text = lbSimbolo1.Text
    End Sub

    Private Sub Check_Dig_Recibo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Dig_Recibo.CheckedChanged
        If Check_Dig_Recibo.Checked = True Then
            txtNum_Recibo.Enabled = True
            txtNum_Recibo.Text = ""
            txtNum_Recibo.Focus()
        Else
            txtNum_Recibo.Enabled = False
            txtNum_Recibo.Text = Numero_de_Recibo()
        End If
    End Sub

    Private Sub txtNum_Recibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum_Recibo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1
                If ToolBar1.Buttons(0).Text = "Cancelar" Then
                    NuevoRecibo()
                Else
                    txtUsuario.Enabled = True
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtCedulaUsuario.Text = ""
                    txtUsuario.Focus()
                End If
            Case 2 : If PMU.Find Then BuscarRecibo() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then AnularRecibo() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir(False) Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6, 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Close()
        End Select
    End Sub

    Private Function Ingresar_OpcionPago(ByVal caja_factura As Integer, Optional ByVal ObligaCaja3 As Boolean = False) As Boolean

        If Me.AplicaCambioenCaja = True And ObligaCaja3 = False Then Return True

        Dim cconexion As New Conexion
        Dim Funciones As New Conexion
        Dim sqlconexion As New System.Data.SqlClient.SqlConnection
        Dim rs As System.Data.SqlClient.SqlDataReader
        Dim Campos, Datos, FormaPago As String

        Try
            sqlconexion = cconexion.Conectar("SeePos")
            rs = cconexion.GetRecorset(sqlconexion, "SELECT Cedula, Nombre, NApertura  FROM AperturaCaja WHERE Estado = 'A' AND Anulado = 0 and num_caja = " & caja_factura)

            If rs.Read Then
                If CB_Cheque.Checked And txtCheque.Text <> "0" Then
                    FormaPago = "CHE"
                Else
                    FormaPago = "EFE"
                End If
                Campos = "[Documento], [TipoDocumento], [MontoPago], [FormaPago], [Denominacion], [Usuario], [Nombre], [CodMoneda], [Nombremoneda], [TipoCambio], [Fecha], [Numapertura], [Vuelto]"
                Datos = CDbl(txtNum_Recibo.Text) & ",'ABO'," & CDbl(txtAbonoGen.Text) & ",'" & FormaPago & "'," & CDbl(txtAbonoGen.Text) & ",'" & rs("Cedula") & "','" & rs("Nombre") & "'," & ComboMoneda.SelectedValue & ",'" & ComboMoneda.Text & "'," & CDbl(txtTipoCambio.Text) & ",'" & Format(Now, "dd/MM/yyyy H:mm:ss") & "'," & rs("NApertura") & ",0"
                Funciones.AddNewRecord("OpcionesDePago", Campos, Datos)
                Return True
            Else
                MsgBox("No hay apertura de caja!!", MsgBoxStyle.Exclamation, "SeeSoft")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            rs.Close()
            cconexion.DesConectar(cconexion.sQlconexion)
        End Try
    End Function

    Private Sub CB_Cheque_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_Cheque.CheckedChanged
        txtCheque.Enabled = CB_Cheque.Checked
        Me.cbocheque.Enabled = True
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class