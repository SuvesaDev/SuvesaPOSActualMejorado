Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class AperturaCaja
    Inherits FrmPlantilla

    Dim Usua As Object
    Dim PMU As New PerfilModulo_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Usua = Usuario
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.CheckBox
    Friend WithEvents NOM As System.Windows.Forms.Label
    Friend WithEvents IDEN As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents n_t_t As System.Windows.Forms.Label
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMonto_Tope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonedaNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetAperturaCaja1 As DataSetAperturaCaja
    Friend WithEvents AdapterAperturaCaja As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterAperturaTotalTope As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterDenominacionesApertura As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterDenominacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMonedaNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDenominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbCaja As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterNumCaja As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AperturaCaja))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NOM = New System.Windows.Forms.Label()
        Me.IDEN = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCaja = New System.Windows.Forms.ComboBox()
        Me.DataSetAperturaCaja1 = New LcPymes_5._2.DataSetAperturaCaja()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMonedaNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Tope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.n_t_t = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMonedaNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDenominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterAperturaCaja = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterAperturaTotalTope = New System.Data.SqlClient.SqlDataAdapter()
        Me.AdapterUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterDenominacionesApertura = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.AdapterDenominacion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdapterNumCaja = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetAperturaCaja1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
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
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 414)
        Me.ToolBar1.Size = New System.Drawing.Size(642, 52)
        Me.ToolBar1.TabIndex = 6
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(472, 540)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(642, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Registro de Apertura de Caja"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.NOM)
        Me.GroupBox1.Controls.Add(Me.IDEN)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbCaja)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 39)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'NOM
        '
        Me.NOM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NOM.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOM.ForeColor = System.Drawing.Color.RoyalBlue
        Me.NOM.Location = New System.Drawing.Point(208, 16)
        Me.NOM.Name = "NOM"
        Me.NOM.Size = New System.Drawing.Size(288, 13)
        Me.NOM.TabIndex = 3
        Me.NOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IDEN
        '
        Me.IDEN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IDEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDEN.ForeColor = System.Drawing.Color.RoyalBlue
        Me.IDEN.Location = New System.Drawing.Point(88, 16)
        Me.IDEN.Name = "IDEN"
        Me.IDEN.Size = New System.Drawing.Size(112, 13)
        Me.IDEN.TabIndex = 4
        Me.IDEN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(598, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Datos del Cajero"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cajero(a)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCaja
        '
        Me.cmbCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCaja.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAperturaCaja1, "Cajas_Cantidad.Num_Caja", True))
        Me.cmbCaja.DataSource = Me.DataSetAperturaCaja1.Cajas_Cantidad
        Me.cmbCaja.DisplayMember = "Num_Caja"
        Me.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaja.Location = New System.Drawing.Point(544, 16)
        Me.cmbCaja.Name = "cmbCaja"
        Me.cmbCaja.Size = New System.Drawing.Size(80, 21)
        Me.cmbCaja.TabIndex = 193
        Me.cmbCaja.ValueMember = "Num_Caja"
        '
        'DataSetAperturaCaja1
        '
        Me.DataSetAperturaCaja1.DataSetName = "DataSetAperturaCaja"
        Me.DataSetAperturaCaja1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSetAperturaCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "N°Caja"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Red
        Me.RadioButton1.Location = New System.Drawing.Point(5, 470)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 13)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "Anulada"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.GridControl3)
        Me.GroupBox5.Controls.Add(Me.n_t_t)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox5.Location = New System.Drawing.Point(8, 75)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 136)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(352, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Detalle Total / Tope"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "aperturacaja.aperturacajaApertura_Total_Tope"
        Me.GridControl3.DataSource = Me.DataSetAperturaCaja1
        '
        '
        '
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(8, 16)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl3.Size = New System.Drawing.Size(344, 112)
        Me.GridControl3.TabIndex = 5
        Me.GridControl3.Text = "GridControl3"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMonedaNombre, Me.colMonto_Tope})
        Me.GridView3.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colMonedaNombre
        '
        Me.colMonedaNombre.Caption = "Moneda"
        Me.colMonedaNombre.FieldName = "MonedaNombre"
        Me.colMonedaNombre.FilterInfo = ColumnFilterInfo1
        Me.colMonedaNombre.Name = "colMonedaNombre"
        Me.colMonedaNombre.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonedaNombre.VisibleIndex = 0
        Me.colMonedaNombre.Width = 167
        '
        'colMonto_Tope
        '
        Me.colMonto_Tope.Caption = "Monto"
        Me.colMonto_Tope.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colMonto_Tope.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Tope.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Tope.FieldName = "Monto_Tope"
        Me.colMonto_Tope.FilterInfo = ColumnFilterInfo2
        Me.colMonto_Tope.Name = "colMonto_Tope"
        Me.colMonto_Tope.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Tope.VisibleIndex = 1
        Me.colMonto_Tope.Width = 171
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'n_t_t
        '
        Me.n_t_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_t_t.ForeColor = System.Drawing.SystemColors.Control
        Me.n_t_t.Location = New System.Drawing.Point(704, 8)
        Me.n_t_t.Name = "n_t_t"
        Me.n_t_t.Size = New System.Drawing.Size(24, 16)
        Me.n_t_t.TabIndex = 0
        Me.n_t_t.Text = "Label13"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(48, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GridControl1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.GridControl2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(5, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Denominacion_Moneda"
        Me.GridControl1.DataSource = Me.DataSetAperturaCaja1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 16)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(616, 152)
        Me.GridControl1.TabIndex = 19
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMonedaNombre1, Me.colCantidad, Me.colDenominacion, Me.colNumero, Me.colTotal})
        Me.GridView1.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colMonedaNombre1
        '
        Me.colMonedaNombre1.Caption = "Moneda"
        Me.colMonedaNombre1.FieldName = "Moneda"
        Me.colMonedaNombre1.FilterInfo = ColumnFilterInfo3
        Me.colMonedaNombre1.Name = "colMonedaNombre1"
        Me.colMonedaNombre1.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonedaNombre1.VisibleIndex = 0
        Me.colMonedaNombre1.Width = 129
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Tipo"
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Tipo"
        Me.colCantidad.FilterInfo = ColumnFilterInfo4
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 1
        Me.colCantidad.Width = 129
        '
        'colDenominacion
        '
        Me.colDenominacion.Caption = "Denominacion"
        Me.colDenominacion.FieldName = "Denominacion"
        Me.colDenominacion.FilterInfo = ColumnFilterInfo5
        Me.colDenominacion.Name = "colDenominacion"
        Me.colDenominacion.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDenominacion.VisibleIndex = 2
        Me.colDenominacion.Width = 110
        '
        'colNumero
        '
        Me.colNumero.Caption = "Cantidad"
        Me.colNumero.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colNumero.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNumero.FieldName = "Cantidad"
        Me.colNumero.FilterInfo = ColumnFilterInfo6
        Me.colNumero.Name = "colNumero"
        Me.colNumero.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNumero.VisibleIndex = 3
        Me.colNumero.Width = 107
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.FilterInfo = ColumnFilterInfo7
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 111
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(616, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Detalle Denominación"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl2
        '
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 232)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(648, 56)
        Me.GridControl2.TabIndex = 13
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView2.Name = "GridView2"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(79, 470)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 16)
        Me.Panel1.TabIndex = 7
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
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(120, 1)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(416, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 1)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""JORDAN-PC"";packet size=4096;integrated security=SSPI;data source=" & _
    """JORDAN-PC\SEEPOS"";persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'AdapterAperturaCaja
        '
        Me.AdapterAperturaCaja.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterAperturaCaja.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterAperturaCaja.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterAperturaCaja.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "aperturacaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Num_Caja", "Num_Caja")})})
        Me.AdapterAperturaCaja.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM aperturacaja WHERE (NApertura = @Original_NApertura)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NApertura", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.VarChar, 1, "Estado"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 8, "Num_Caja")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT NApertura, Fecha, Nombre, Estado, Observaciones, Anulado, Cedula, Num_Caja" & _
    " FROM aperturacaja"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.VarChar, 1, "Estado"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 8, "Num_Caja"), New System.Data.SqlClient.SqlParameter("@Original_NApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@NApertura", System.Data.SqlDbType.Int, 4, "NApertura")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_total_tope, NApertura, CodMoneda, Monto_Tope, MonedaNombre FROM Apertur" & _
    "a_Total_Tope"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NApertura", System.Data.SqlDbType.Int, 4, "NApertura"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Monto_Tope", System.Data.SqlDbType.Float, 8, "Monto_Tope"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NApertura", System.Data.SqlDbType.Int, 4, "NApertura"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Monto_Tope", System.Data.SqlDbType.Float, 8, "Monto_Tope"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@Original_id_total_tope", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_total_tope", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Tope", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Tope", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_total_tope", System.Data.SqlDbType.Int, 4, "id_total_tope")})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_total_tope", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_total_tope", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Tope", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Tope", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NApertura", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterAperturaTotalTope
        '
        Me.AdapterAperturaTotalTope.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterAperturaTotalTope.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterAperturaTotalTope.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterAperturaTotalTope.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Apertura_Total_Tope", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_total_tope", "id_total_tope"), New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Monto_Tope", "Monto_Tope"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        Me.AdapterAperturaTotalTope.UpdateCommand = Me.SqlUpdateCommand3
        '
        'AdapterUsuario
        '
        Me.AdapterUsuario.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna FROM Usuarios"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'AdapterDenominacionesApertura
        '
        Me.AdapterDenominacionesApertura.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterDenominacionesApertura.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterDenominacionesApertura.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterDenominacionesApertura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Apertura_Denominaciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Apertura", "Id_Apertura"), New System.Data.Common.DataColumnMapping("Id_Denominacion", "Id_Denominacion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad")})})
        Me.AdapterDenominacionesApertura.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Apertura_Denominaciones WHERE (Id = @Original_Id)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Apertura", System.Data.SqlDbType.Int, 4, "Id_Apertura"), New System.Data.SqlClient.SqlParameter("@Id_Denominacion", System.Data.SqlDbType.BigInt, 8, "Id_Denominacion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id, Id_Apertura, Id_Denominacion, Monto, Cantidad FROM Apertura_Denominaci" & _
    "ones"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Apertura", System.Data.SqlDbType.Int, 4, "Id_Apertura"), New System.Data.SqlClient.SqlParameter("@Id_Denominacion", System.Data.SqlDbType.BigInt, 8, "Id_Denominacion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAperturaCaja1, "Moneda.CodMoneda", True))
        Me.Label7.Location = New System.Drawing.Point(744, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Label7"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 466)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(642, 18)
        Me.StatusBar1.TabIndex = 186
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 75
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 550
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAperturaCaja1, "aperturacaja.NApertura", True))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 13)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "0"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdapterDenominacion
        '
        Me.AdapterDenominacion.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterDenominacion.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterDenominacion.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterDenominacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Denominacion_Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Denominacion", "Denominacion"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterDenominacion.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Denominacion_Moneda WHERE (Id = @Original_Id)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Denominacion_Moneda(CodMoneda, Denominacion, Tipo) VALUES (@CodMoneda" & _
    ", @Denominacion, @Tipo); SELECT Id, CodMoneda, Denominacion, Tipo FROM Denominac" & _
    "ion_Moneda WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Int, 4, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Id, CodMoneda, Denominacion, Tipo FROM Denominacion_Moneda"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Int, 4, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "0.00"
        Me.TextEdit2.Location = New System.Drawing.Point(504, 392)
        Me.TextEdit2.Name = "TextEdit2"
        '
        '
        '
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit2.Size = New System.Drawing.Size(128, 19)
        Me.TextEdit2.TabIndex = 190
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "0.00"
        Me.TextEdit1.Location = New System.Drawing.Point(368, 392)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit1.Size = New System.Drawing.Size(128, 19)
        Me.TextEdit1.TabIndex = 191
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtobservacion)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(392, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 136)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'txtobservacion
        '
        Me.txtobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtobservacion.Location = New System.Drawing.Point(16, 24)
        Me.txtobservacion.MaxLength = 250
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservacion.Size = New System.Drawing.Size(216, 96)
        Me.txtobservacion.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Observaciones"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(704, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label13"
        '
        'AdapterNumCaja
        '
        Me.AdapterNumCaja.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterNumCaja.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterNumCaja.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterNumCaja.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cajas_Cantidad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_Caja", "id_Caja"), New System.Data.Common.DataColumnMapping("Num_Caja", "Num_Caja"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura")})})
        Me.AdapterNumCaja.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Cajas_Cantidad WHERE (id_Caja = @Original_id_Caja)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_Caja", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_Caja", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Cajas_Cantidad(Num_Caja, Num_Apertura) VALUES (@Num_Caja, @Num_Apertu" & _
    "ra); SELECT id_Caja, Num_Caja, Num_Apertura FROM Cajas_Cantidad WHERE (id_Caja =" & _
    " @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 8, "Num_Caja"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT id_Caja, Num_Caja, Num_Apertura FROM Cajas_Cantidad WHERE (Num_Apertura = " & _
    "0)"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Cajas_Cantidad SET Num_Caja = @Num_Caja, Num_Apertura = @Num_Apertura WHER" & _
    "E (id_Caja = @Original_id_Caja); SELECT id_Caja, Num_Caja, Num_Apertura FROM Caj" & _
    "as_Cantidad WHERE (id_Caja = @id_Caja)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 8, "Num_Caja"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.BigInt, 8, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Original_id_Caja", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_Caja", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_Caja", System.Data.SqlDbType.BigInt, 8, "id_Caja")})
        '
        'AperturaCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(642, 484)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Name = "AperturaCaja"
        Me.Text = "Apertura de Caja"
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.RadioButton1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.TextEdit2, 0)
        Me.Controls.SetChildIndex(Me.TextEdit1, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetAperturaCaja1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
   
    Private Sub AperturaCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            Me.AdapterMoneda.Fill(Me.DataSetAperturaCaja1.Moneda)
            Me.AdapterUsuario.Fill(Me.DataSetAperturaCaja1.Usuarios)
            AdapterDenominacion.Fill(DataSetAperturaCaja1.Denominacion_Moneda)
            Me.AdapterNumCaja.Fill(Me.DataSetAperturaCaja1.Cajas_Cantidad)
            If Me.DataSetAperturaCaja1.Cajas_Cantidad.Count <> 0 Then
                Binding()
                ValorPorDefecto()
                Me.GroupBox5.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
                cmbCaja.Enabled = False
                PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo 
                txtUsuario.Focus()
            Else
                MsgBox("No hay mas número de Cajas disponibles! Consulte a su administrador", MsgBoxStyle.Exclamation)
                Me.GroupBox5.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
                cmbCaja.Enabled = False
            End If
        Catch ex As Exception
            If Err.Number Then
                MsgBox(ex.Message)
                MsgBox("Error al tratar de cargar el formulario, Intenete otra vez, si el problema persiste comuniqueselo al administrador de Sistema", MsgBoxStyle.Critical)
            End If
        End Try
    End Sub
#Region "Binding"
    Function Binding()
        Me.NOM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAperturaCaja1, "aperturacaja.Nombre"))
        Me.IDEN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAperturaCaja1, "aperturacaja.Cedula"))
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAperturaCaja1, "aperturacaja.Anulado"))
        Me.txtobservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAperturaCaja1, "aperturacaja.Observaciones"))
    End Function
#End Region

#Region "Valores Por Defecto"
    Function ValorPorDefecto()
        'Apertura Caja
        Me.DataSetAperturaCaja1.aperturacaja.NAperturaColumn.AutoIncrement = True
        Me.DataSetAperturaCaja1.aperturacaja.NAperturaColumn.AutoIncrementSeed = -1
        Me.DataSetAperturaCaja1.aperturacaja.NAperturaColumn.AutoIncrementStep = -1
        Me.DataSetAperturaCaja1.aperturacaja.EstadoColumn.DefaultValue = "A"
        Me.DataSetAperturaCaja1.aperturacaja.FechaColumn.DefaultValue = Now
        Me.DataSetAperturaCaja1.aperturacaja.AnuladoColumn.DefaultValue = "False"
        Me.DataSetAperturaCaja1.aperturacaja.ObservacionesColumn.DefaultValue = " "
        Me.DataSetAperturaCaja1.aperturacaja.Num_CajaColumn.DefaultValue = 0
        'Monto Tope
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.id_total_topeColumn.AutoIncrement = True
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.id_total_topeColumn.AutoIncrementSeed = -1
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.id_total_topeColumn.AutoIncrementStep = -1
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.CodMonedaColumn.DefaultValue = Me.DataSetAperturaCaja1.Moneda.Rows(0).Item("CodMoneda")
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.Monto_TopeColumn.DefaultValue = "0.00"
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.MonedaNombreColumn.DefaultValue = "COLON"

        '------------------------------------------------------------------------------------------
        ' DENOMINACIONES MONEDA - ORA
        For i As Integer = 0 To DataSetAperturaCaja1.Denominacion_Moneda.Rows.Count - 1
            DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("Total") = 0
            DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("Cantidad") = 0
            For j As Integer = 0 To DataSetAperturaCaja1.Moneda.Rows.Count - 1
                If DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("CodMoneda") = DataSetAperturaCaja1.Moneda.Rows(j).Item("CodMoneda") Then
                    DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("Moneda") = DataSetAperturaCaja1.Moneda.Rows(j).Item("MonedaNombre")
                End If
            Next
        Next
        '------------------------------------------------------------------------------------------

        'Denominaciones
        Me.DataSetAperturaCaja1.Apertura_Denominaciones.IdColumn.AutoIncrement = True
        Me.DataSetAperturaCaja1.Apertura_Denominaciones.IdColumn.AutoIncrementSeed = -1
        Me.DataSetAperturaCaja1.Apertura_Denominaciones.IdColumn.AutoIncrementStep = -1
    End Function
#End Region

#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevaApertura()
            Case 2 : If PMU.Find Then Me.BuscarAperturas() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then GuardarApertura() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Anular_Apertura() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub
#End Region

#Region "Nueva Aperura"
    Function NuevaApertura()
        Try
            Dim FrmDatos_Cajeros As New FrmDatos_Cajeros
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                FrmDatos_Cajeros.StartPosition = FormStartPosition.CenterScreen
                If FrmDatos_Cajeros.ShowDialog = DialogResult.OK Then
                    Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").AddNew()
                    Me.NOM.Text = FrmDatos_Cajeros.nombre_cajero
                    Me.IDEN.Text = FrmDatos_Cajeros.cedula_cajero
                    Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").AddNew()
                    Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").CancelCurrentEdit()

                    '------------------------------------------------------------------------------------------
                    ' TOPE MONEDA - ORA
                    For i As Integer = 0 To DataSetAperturaCaja1.Moneda.Rows.Count - 1
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").EndCurrentEdit()
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").AddNew()
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").Current("CodMoneda") = DataSetAperturaCaja1.Moneda(i).CodMoneda
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").Current("Monto_Tope") = 0
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").Current("MonedaNombre") = DataSetAperturaCaja1.Moneda(i).MonedaNombre
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").EndCurrentEdit()
                    Next
                    '------------------------------------------------------------------------------------------
                    Me.cmbCaja.Enabled = True
                    Me.GroupBox5.Enabled = True
                    Me.GroupBox2.Enabled = True
                    Me.GroupBox3.Enabled = True
                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = False
                    Me.ToolBar1.Buttons(2).Enabled = True
                    Me.ToolBar1.Buttons(3).Enabled = False
                    Me.ToolBar1.Buttons(4).Enabled = False
                    GridControl3.Focus()

                Else
                    If FrmDatos_Cajeros.DialogResult = DialogResult.Abort Then
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").CancelCurrentEdit()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
                        Me.DataSetAperturaCaja1.Apertura_Total_Tope.Clear()
                        Me.DataSetAperturaCaja1.aperturacaja.Clear()
                        Me.GroupBox5.Enabled = False
                        Me.GroupBox2.Enabled = False
                        Me.GroupBox3.Enabled = False
                    Else
                        MsgBox("Debes Seleccionar Un cajero")
                        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").CancelCurrentEdit()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
                        Me.DataSetAperturaCaja1.Apertura_Total_Tope.Clear()
                        Me.DataSetAperturaCaja1.aperturacaja.Clear()
                        Me.GroupBox5.Enabled = False
                        Me.GroupBox2.Enabled = False
                        Me.GroupBox3.Enabled = False
                    End If
                End If
            Else
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
                Me.DataSetAperturaCaja1.Apertura_Total_Tope.Clear()
                Me.DataSetAperturaCaja1.aperturacaja.Clear()
                Me.GroupBox5.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
                Exit Function
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Guardar Apertura"
    Function GuardarApertura()
        Try
            Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").Current("Num_Caja") = cmbCaja.SelectedValue
            Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").EndCurrentEdit()
            Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").EndCurrentEdit()

            If Valida() Then
                CargarDatos()
            Else
                Exit Function
            End If

            If RegistarApertura() Then
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.GroupBox2.Enabled = False
                Me.GroupBox5.Enabled = False
                Me.GroupBox3.Enabled = False
                If (MsgBox("Desea Imprimir el reporte de Apertura ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                    Imprimir()
                End If
                Me.Limpiar()

                MsgBox("Apertura de caja realizada Satisfactoriamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function Limpiar()
        Me.DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
        Me.DataSetAperturaCaja1.Apertura_Total_Tope.Clear()
        Me.DataSetAperturaCaja1.aperturacaja.Clear()
        Me.DataSetAperturaCaja1.Cajas_Cantidad.Clear()
        Me.AdapterNumCaja.Fill(Me.DataSetAperturaCaja1.Cajas_Cantidad)
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(1).Enabled = True
        Me.ToolBar1.Buttons(2).Enabled = False
        Me.ToolBar1.Buttons(3).Enabled = False
        Me.ToolBar1.Buttons(4).Enabled = False
        Me.ToolBar1.Buttons(5).Enabled = True
    End Function

    Function CargarDatos()
        Try
            Dim I As Integer
            DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
            For I = 0 To Me.DataSetAperturaCaja1.Denominacion_Moneda.Count - 1
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Denominaciones").EndCurrentEdit()
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Denominaciones").AddNew()
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Denominaciones").Current("Id_Denominacion") = Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Id")
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Denominaciones").Current("Monto") = Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Total")
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Denominaciones").Current("Cantidad") = Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Cantidad")
                Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Denominaciones").EndCurrentEdit()
            Next

        Catch ex As Exception
            MsgBox(ex.Message,MsgBoxStyle.Critical)
        End Try
    End Function

    Function RegistarApertura() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'Apertura
            Me.AdapterAperturaCaja.InsertCommand.Transaction = Trans
            Me.AdapterAperturaCaja.UpdateCommand.Transaction = Trans
            Me.AdapterAperturaCaja.DeleteCommand.Transaction = Trans
            Me.AdapterAperturaCaja.SelectCommand.Transaction = Trans
            'Denominaciones
            Me.AdapterDenominacionesApertura.InsertCommand.Transaction = Trans
            Me.AdapterDenominacionesApertura.UpdateCommand.Transaction = Trans
            Me.AdapterDenominacionesApertura.DeleteCommand.Transaction = Trans
            Me.AdapterDenominacionesApertura.SelectCommand.Transaction = Trans
            'Tope
            Me.AdapterAperturaTotalTope.InsertCommand.Transaction = Trans
            Me.AdapterAperturaTotalTope.UpdateCommand.Transaction = Trans
            Me.AdapterAperturaTotalTope.DeleteCommand.Transaction = Trans
            Me.AdapterAperturaTotalTope.SelectCommand.Transaction = Trans

            Me.AdapterAperturaCaja.Update(Me.DataSetAperturaCaja1.aperturacaja)
            Me.AdapterDenominacionesApertura.Update(Me.DataSetAperturaCaja1.Apertura_Denominaciones)
            Me.AdapterAperturaTotalTope.Update(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
            Me.DataSetAperturaCaja1.AcceptChanges()

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

#Region "Validar"
    Private Function Valida() As Boolean
        Try
            'Catidad Ingresada
            Dim tot As Decimal = 0
            'Total Detalle\Tope
            Dim dtt As Decimal = 0
            'Recorrera el DenominacionesApertura
            Dim a As DataRow
            'Recorrera el Adapter TotalTope
            Dim b As DataRow

            Dim s As String = Me.BindingContext(DataSetAperturaCaja1.aperturacaja).Current("NApertura")
            Dim id As String = ""

            'Recorrera los datos en la tabla moneda del adaptador que contiene los datos de moneda
            Dim m As DataRow

            For Each b In Me.DataSetAperturaCaja1.Tables("Apertura_Total_Tope").Rows
                If s = b("NApertura") Then
                    Dim codm As String = b("CodMoneda")
                    '==============================================================
                    For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
                        If m("CodMoneda") = codm Then
                            dtt += b("Monto_Tope") * m("ValorVenta")
                            Exit For
                        End If
                    Next
                    '==============================================================
                End If
            Next

            For Each a In Me.DataSetAperturaCaja1.Tables("Denominacion_Moneda").Rows ' "aperturacaja.aperturacajaDenominacionesAperturas")
                Dim codm As String = a("CodMoneda")
                '================================================================
                For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
                    If m("CodMoneda") = codm Then
                        tot += a("Total") * m("ValorVenta")
                        Exit For
                    End If
                Next
                '================================================================
            Next

            'Evaluo si los datos que hay en detalle total\Tope coinciden con  los de detalle de denominacion
            If tot <> dtt Then
                MsgBox("Ingrese el detalle de las denominaciones correctamente", MsgBoxStyle.Exclamation, "Mensaje")
                Return False
            End If
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
#End Region

#End Region

#Region "Imprimir Apertura"
    Function Imprimir()
        Dim Apertura_Cajas As New Apertura_Cajas
        Dim visor As New frmVisorReportes
        Dim servidor As String = Me.SqlConnection1.DataSource
        Apertura_Cajas.SetDatabaseLogon("sa", "", Me.SqlConnection1.DataSource, Me.SqlConnection1.Database)
        Apertura_Cajas.SetParameterValue(0, Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").Current("NApertura"))
        CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Apertura_Cajas)
        visor.rptViewer.Visible = True
        Apertura_Cajas = Nothing
        visor.ShowDialog()
    End Function

#End Region

#Region "Anular Apertura"
    Function Anular_Apertura()
        If MessageBox.Show("¿Desea anular la Apertura de caja?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.RadioButton1.Checked = True
            Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").Current("Estado") = "C"
            Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").EndCurrentEdit()
            RegistarApertura()
            MsgBox("Apertura Anulada", MsgBoxStyle.Information)
            Me.Limpiar()
        End If
    End Function
#End Region

#Region "BuscarApertura"
    Private Sub BuscarAperturas()
        Dim Fx As New cFunciones
        Dim Apertura As String

        Apertura = Fx.Buscar_X_Descripcion_Fecha("SELECT NApertura AS Apertura, Nombre, Fecha, num_caja as Caja FROM aperturacaja Order by NApertura Desc", "Nombre", "Fecha", "Buscar Apertura de Caja", Me.SqlConnection1.ConnectionString)
        If Apertura <> "" Then
            Me.DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
            Me.DataSetAperturaCaja1.Apertura_Total_Tope.Clear()
            Me.DataSetAperturaCaja1.aperturacaja.Clear()
            CargarApertura(Apertura)
            CargarTope(Apertura)
            CargarDenominacion(Apertura)
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.GridControl2.Enabled = False
            Me.GridControl3.Enabled = False
            Me.GridControl1.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.GroupBox5.Enabled = True
            Me.GroupBox3.Enabled = False
        End If
    End Sub

#Region "Cargar Apertura"
    Function CargarApertura(ByVal Numapertura As String)
        Dim cnn As SqlConnection = Nothing

        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = CadenaConexionSeePOS
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM aperturacaja" & _
            " where NApertura  = @Id"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.BigInt))
            cmd.Parameters("@Id").Value = Numapertura
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DataSetAperturaCaja1.aperturacaja)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

#Region "Cargar Denominaciones"
    Function CargarDenominacion(ByVal Numapertura As String)
        Dim cnn As SqlConnection = Nothing

        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = CadenaConexionSeePOS
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Apertura_Denominaciones" & _
            " where Id_Apertura  = @Id"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.BigInt))
            cmd.Parameters("@Id").Value = Numapertura
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DataSetAperturaCaja1.Apertura_Denominaciones)

            For I As Integer = 0 To Me.DataSetAperturaCaja1.Denominacion_Moneda.Count - 1
                Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Total") = Me.DataSetAperturaCaja1.Apertura_Denominaciones.Rows(I).Item("Monto")
                Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Cantidad") = Me.DataSetAperturaCaja1.Apertura_Denominaciones.Rows(I).Item("Cantidad")
            Next
            CalcularTotales()

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

#Region "Cargar Tope "
    Function CargarTope(ByVal Numapertura As String)
        Dim cnn As SqlConnection = Nothing

        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = CadenaConexionSeePOS
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Apertura_Total_Tope" & _
            " where NApertura  = @Id"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.BigInt))
            cmd.Parameters("@Id").Value = Numapertura
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

#End Region

#Region "Funciones"
    Function Recalcular_Fila(ByVal x As Integer) ', ByVal Cantidad As Integer
        Dim Denominacion, Cantidad, Total As Double '''
        If Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("CodMoneda") = 1 Then
            Denominacion = DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("Denominacion")
            Cantidad = DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("Cantidad")
            DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("Total") = Denominacion * Cantidad
        End If

        If DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("CodMoneda") = 2 Then
            Denominacion = DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("Denominacion")
            Cantidad = DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("Cantidad")
            DataSetAperturaCaja1.Denominacion_Moneda.Rows(x).Item("Total") = Denominacion * Cantidad
        End If

        CalcularTotales()
    End Function

    Function CalcularTotales()
        Dim i As Integer
        Me.TextEdit1.EditValue = 0
        Me.TextEdit2.EditValue = 0

        For i = 0 To Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows.Count - 1
            If Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("CodMoneda") = 1 Then
                Me.TextEdit1.EditValue += Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("Total")
            ElseIf Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("CodMoneda") = 2 Then
                Me.TextEdit2.EditValue += Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(i).Item("Total")
            End If
        Next
    End Function
#End Region

#Region "Controles Funciones"
    Private Sub GridControl1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyUp
        If e.KeyCode = Keys.Enter Then Me.Recalcular_Fila(Me.BindingContext(Me.DataSetAperturaCaja1, "Denominacion_Moneda").Position())
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Me.Recalcular_Fila(Me.BindingContext(Me.DataSetAperturaCaja1, "Denominacion_Moneda").Position())
    End Sub

    Private Sub RepositoryItemTextEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.EditValueChanged
        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja.aperturacajaApertura_Total_Tope").EndCurrentEdit()
    End Sub

    Private Sub RepositoryItemTextEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RepositoryItemTextEdit1.KeyPress, RepositoryItemTextEdit3.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub
#End Region

#Region "Validar Usuario"
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow
                Usuario_autorizadores = Me.DataSetAperturaCaja1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                ' Si existe el Usuario
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                    Me.txtNombreUsuario.Text = Usua("Nombre")
                    txtUsuario.Enabled = False
                    'Activar ToolBar
                    If Me.DataSetAperturaCaja1.Cajas_Cantidad.Count <> 0 Then
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarEliminar.Enabled = False
                        Me.ToolBarRegistrar.Enabled = True
                        NuevaApertura()
                    Else
                        MsgBox("No hay numeros de Cajas disponibles", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    txtUsuario.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
            End Try
        End If
    End Sub
#End Region

  
End Class