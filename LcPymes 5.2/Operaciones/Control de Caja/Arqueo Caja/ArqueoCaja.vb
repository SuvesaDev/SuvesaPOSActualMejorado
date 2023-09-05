Imports System.data.SqlClient
Imports System.data
Imports System.Windows.Forms

Public Class ArqueoCaja
    Inherits FrmPlantilla

#Region "Variables"
    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim TipoCambioDolar As Double
    Dim Cedula As String
    Public NApertura As Long
    Friend WithEvents txtDiferenciaCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public nombre As String
#End Region

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMonedaNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDenominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDenominacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetArqueo1 As DataSetArqueo
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdapterTarjeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents AdapterEfectivo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterTarjetas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterArqueodeCaja As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterApertura As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCheques As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChequesDol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDepositosCol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArqueoCaja))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataSetArqueo1 = New LcPymes_5._2.DataSetArqueo()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMonedaNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDenominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterDenominacion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AdapterTarjeta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDepositoDolar = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDepositosCol = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtChequesDol = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCheques = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.AdapterEfectivo = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterTarjetas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterArqueodeCaja = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterApertura = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.txtDiferenciaCaja = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetArqueo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtDepositoDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepositosCol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequesDol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheques.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDiferenciaCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolBarEliminar.ImageIndex = 5
        Me.ToolBarEliminar.Text = "Editar"
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 3
        Me.ToolBarExcel.Text = "Anular"
        Me.ToolBarExcel.Visible = True
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 580)
        Me.ToolBar1.Size = New System.Drawing.Size(784, 60)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(801, 483)
        Me.DataNavigator.Size = New System.Drawing.Size(161, 24)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(784, 37)
        Me.TituloModulo.Text = "Arqueo de Caja"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(10, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 259)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desgloce Efectivo"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(269, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(249, 64)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ANULADO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Denominacion_Moneda"
        Me.GridControl1.DataSource = Me.DataSetArqueo1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(10, 18)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(739, 231)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.Text = "GridControl1"
        '
        'DataSetArqueo1
        '
        Me.DataSetArqueo1.DataSetName = "DataSetArqueo"
        Me.DataSetArqueo1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetArqueo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.colMonedaNombre1.FilterInfo = ColumnFilterInfo1
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
        Me.colCantidad.FilterInfo = ColumnFilterInfo2
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
        Me.colDenominacion.FilterInfo = ColumnFilterInfo3
        Me.colDenominacion.Name = "colDenominacion"
        Me.colDenominacion.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDenominacion.VisibleIndex = 2
        Me.colDenominacion.Width = 110
        '
        'colNumero
        '
        Me.colNumero.Caption = "Cantidad"
        Me.colNumero.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colNumero.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNumero.FieldName = "Cantidad"
        Me.colNumero.FilterInfo = ColumnFilterInfo4
        Me.colNumero.Name = "colNumero"
        Me.colNumero.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNumero.VisibleIndex = 3
        Me.colNumero.Width = 107
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.FilterInfo = ColumnFilterInfo5
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 111
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
    "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterDenominacion
        '
        Me.AdapterDenominacion.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterDenominacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Denominacion_Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Denominacion", "Denominacion"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, CodMoneda, Denominacion, Tipo FROM Denominacion_Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridControl2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(10, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 157)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tarjetas"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "TipoTarjeta"
        Me.GridControl2.DataSource = Me.DataSetArqueo1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(10, 18)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(374, 240)
        Me.GridControl2.TabIndex = 12
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn2})
        Me.GridView2.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tarjeta"
        Me.GridColumn1.FieldName = "Nombre"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo6
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 134
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Total"
        Me.GridColumn5.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.FilterInfo = ColumnFilterInfo7
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Moneda"
        Me.GridColumn2.FieldName = "Monedas"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo8
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'AdapterTarjeta
        '
        Me.AdapterTarjeta.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterTarjeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Nombre, Moneda FROM TipoTarjeta"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDepositoDolar)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtDepositosCol)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtChequesDol)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtCheques)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextEdit6)
        Me.GroupBox3.Controls.Add(Me.TextEdit4)
        Me.GroupBox3.Controls.Add(Me.TextEdit3)
        Me.GroupBox3.Controls.Add(Me.TextEdit2)
        Me.GroupBox3.Controls.Add(Me.TextEdit1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(413, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 268)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total  General"
        '
        'txtDepositoDolar
        '
        Me.txtDepositoDolar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.DepositoDol", True))
        Me.txtDepositoDolar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDepositoDolar.Location = New System.Drawing.Point(144, 212)
        Me.txtDepositoDolar.Name = "txtDepositoDolar"
        '
        '
        '
        Me.txtDepositoDolar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDepositoDolar.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDepositoDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepositoDolar.Properties.ReadOnly = True
        Me.txtDepositoDolar.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDepositoDolar.Size = New System.Drawing.Size(192, 22)
        Me.txtDepositoDolar.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(10, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Depositos Dolar"
        '
        'txtDepositosCol
        '
        Me.txtDepositosCol.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.DepositoCol", True))
        Me.txtDepositosCol.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDepositosCol.Location = New System.Drawing.Point(144, 185)
        Me.txtDepositosCol.Name = "txtDepositosCol"
        '
        '
        '
        Me.txtDepositosCol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDepositosCol.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDepositosCol.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepositosCol.Properties.ReadOnly = True
        Me.txtDepositosCol.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDepositosCol.Size = New System.Drawing.Size(192, 22)
        Me.txtDepositosCol.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(10, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 18)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Depositos Colon"
        '
        'txtChequesDol
        '
        Me.txtChequesDol.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.ChequesDol", True))
        Me.txtChequesDol.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtChequesDol.Location = New System.Drawing.Point(144, 157)
        Me.txtChequesDol.Name = "txtChequesDol"
        '
        '
        '
        Me.txtChequesDol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtChequesDol.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtChequesDol.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesDol.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtChequesDol.Size = New System.Drawing.Size(192, 22)
        Me.txtChequesDol.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(10, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Cheques Dolares"
        '
        'txtCheques
        '
        Me.txtCheques.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.Cheques", True))
        Me.txtCheques.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCheques.Location = New System.Drawing.Point(144, 129)
        Me.txtCheques.Name = "txtCheques"
        '
        '
        '
        Me.txtCheques.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCheques.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtCheques.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCheques.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtCheques.Size = New System.Drawing.Size(192, 22)
        Me.txtCheques.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(10, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Cheques Colones"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.Total", True))
        Me.TextEdit6.EditValue = "0.00"
        Me.TextEdit6.Location = New System.Drawing.Point(144, 240)
        Me.TextEdit6.Name = "TextEdit6"
        '
        '
        '
        Me.TextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit6.Size = New System.Drawing.Size(192, 22)
        Me.TextEdit6.TabIndex = 44
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.TarjetaDolares", True))
        Me.TextEdit4.EditValue = "0.00"
        Me.TextEdit4.Location = New System.Drawing.Point(144, 102)
        Me.TextEdit4.Name = "TextEdit4"
        '
        '
        '
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit4.Size = New System.Drawing.Size(192, 22)
        Me.TextEdit4.TabIndex = 42
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.TarjetaColones", True))
        Me.TextEdit3.EditValue = "0.00"
        Me.TextEdit3.Location = New System.Drawing.Point(144, 74)
        Me.TextEdit3.Name = "TextEdit3"
        '
        '
        '
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit3.Size = New System.Drawing.Size(192, 22)
        Me.TextEdit3.TabIndex = 41
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.EfectivoDolares", True))
        Me.TextEdit2.EditValue = "0.00"
        Me.TextEdit2.Location = New System.Drawing.Point(144, 46)
        Me.TextEdit2.Name = "TextEdit2"
        '
        '
        '
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit2.Size = New System.Drawing.Size(192, 22)
        Me.TextEdit2.TabIndex = 40
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetArqueo1, "ArqueoCajas.EfectivoColones", True))
        Me.TextEdit1.EditValue = "0.00"
        Me.TextEdit1.Location = New System.Drawing.Point(144, 18)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit1.Size = New System.Drawing.Size(192, 22)
        Me.TextEdit1.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(10, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tarjeta Dolares"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(10, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Sistema"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tarjeta Colones"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dolares"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Colones"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(442, 600)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 15)
        Me.Label36.TabIndex = 146
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(538, 618)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(240, 15)
        Me.txtNombreUsuario.TabIndex = 148
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.ForeColor = System.Drawing.Color.Blue
        Me.TextBox6.Location = New System.Drawing.Point(538, 600)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox6.Size = New System.Drawing.Size(240, 15)
        Me.TextBox6.TabIndex = 0
        '
        'AdapterEfectivo
        '
        Me.AdapterEfectivo.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterEfectivo.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterEfectivo.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterEfectivo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoEfectivo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Arqueo", "Id_Arqueo"), New System.Data.Common.DataColumnMapping("Id_Denominacion", "Id_Denominacion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad")})})
        Me.AdapterEfectivo.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Arqueo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Arqueo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Denominacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Arqueo", System.Data.SqlDbType.BigInt, 8, "Id_Arqueo"), New System.Data.SqlClient.SqlParameter("@Id_Denominacion", System.Data.SqlDbType.BigInt, 8, "Id_Denominacion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Int, 4, "Cantidad")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id, Id_Arqueo, Id_Denominacion, Monto, Cantidad FROM ArqueoEfectivo"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Arqueo", System.Data.SqlDbType.BigInt, 8, "Id_Arqueo"), New System.Data.SqlClient.SqlParameter("@Id_Denominacion", System.Data.SqlDbType.BigInt, 8, "Id_Denominacion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Int, 4, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Arqueo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Arqueo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Denominacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'AdapterTarjetas
        '
        Me.AdapterTarjetas.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterTarjetas.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterTarjetas.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterTarjetas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Arqueo", "Id_Arqueo"), New System.Data.Common.DataColumnMapping("Id_Tarjeta", "Id_Tarjeta"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        Me.AdapterTarjetas.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM ArqueoTarjeta WHERE (Id = @Original_Id) AND (Id_Arqueo = @Original_Id" & _
    "_Arqueo) AND (Id_Tarjeta = @Original_Id_Tarjeta) AND (Monto = @Original_Monto)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Arqueo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Arqueo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Tarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Tarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO ArqueoTarjeta(Id_Arqueo, Id_Tarjeta, Monto) VALUES (@Id_Arqueo, @Id_T" & _
    "arjeta, @Monto); SELECT Id, Id_Arqueo, Id_Tarjeta, Monto FROM ArqueoTarjeta WHER" & _
    "E (Id = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Arqueo", System.Data.SqlDbType.BigInt, 8, "Id_Arqueo"), New System.Data.SqlClient.SqlParameter("@Id_Tarjeta", System.Data.SqlDbType.Int, 4, "Id_Tarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Id, Id_Arqueo, Id_Tarjeta, Monto FROM ArqueoTarjeta"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Arqueo", System.Data.SqlDbType.BigInt, 8, "Id_Arqueo"), New System.Data.SqlClient.SqlParameter("@Id_Tarjeta", System.Data.SqlDbType.Int, 4, "Id_Tarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Arqueo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Arqueo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Tarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Tarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'AdapterArqueodeCaja
        '
        Me.AdapterArqueodeCaja.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterArqueodeCaja.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterArqueodeCaja.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterArqueodeCaja.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoCajas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("EfectivoColones", "EfectivoColones"), New System.Data.Common.DataColumnMapping("EfectivoDolares", "EfectivoDolares"), New System.Data.Common.DataColumnMapping("TarjetaColones", "TarjetaColones"), New System.Data.Common.DataColumnMapping("TarjetaDolares", "TarjetaDolares"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("IdApertura", "IdApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Cajero", "Cajero"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("TipoCambioD", "TipoCambioD"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Cheques", "Cheques"), New System.Data.Common.DataColumnMapping("ChequesDol", "ChequesDol"), New System.Data.Common.DataColumnMapping("DepositoCol", "DepositoCol"), New System.Data.Common.DataColumnMapping("DepositoDol", "DepositoDol")})})
        Me.AdapterArqueodeCaja.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajero", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cheques", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cheques", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequesDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequesDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositoCol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositoCol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositoDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositoDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambioD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambioD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EfectivoColones", System.Data.SqlDbType.Float, 8, "EfectivoColones"), New System.Data.SqlClient.SqlParameter("@EfectivoDolares", System.Data.SqlDbType.Float, 8, "EfectivoDolares"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@IdApertura", System.Data.SqlDbType.Int, 4, "IdApertura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cajero", System.Data.SqlDbType.VarChar, 100, "Cajero"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@TipoCambioD", System.Data.SqlDbType.Float, 8, "TipoCambioD"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Cheques", System.Data.SqlDbType.Float, 8, "Cheques"), New System.Data.SqlClient.SqlParameter("@ChequesDol", System.Data.SqlDbType.Float, 8, "ChequesDol"), New System.Data.SqlClient.SqlParameter("@DepositoCol", System.Data.SqlDbType.Float, 8, "DepositoCol"), New System.Data.SqlClient.SqlParameter("@DepositoDol", System.Data.SqlDbType.Float, 8, "DepositoDol")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EfectivoColones", System.Data.SqlDbType.Float, 8, "EfectivoColones"), New System.Data.SqlClient.SqlParameter("@EfectivoDolares", System.Data.SqlDbType.Float, 8, "EfectivoDolares"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@IdApertura", System.Data.SqlDbType.Int, 4, "IdApertura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cajero", System.Data.SqlDbType.VarChar, 100, "Cajero"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@TipoCambioD", System.Data.SqlDbType.Float, 8, "TipoCambioD"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Cheques", System.Data.SqlDbType.Float, 8, "Cheques"), New System.Data.SqlClient.SqlParameter("@ChequesDol", System.Data.SqlDbType.Float, 8, "ChequesDol"), New System.Data.SqlClient.SqlParameter("@DepositoCol", System.Data.SqlDbType.Float, 8, "DepositoCol"), New System.Data.SqlClient.SqlParameter("@DepositoDol", System.Data.SqlDbType.Float, 8, "DepositoDol"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajero", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cheques", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cheques", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequesDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequesDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositoCol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositoCol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositoDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositoDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambioD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambioD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'AdapterApertura
        '
        Me.AdapterApertura.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterApertura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "aperturacaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT NApertura, Fecha, Nombre, Estado, Observaciones, Anulado, Cedula FROM aper" & _
    "turacaja"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtobservacion)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox4.Location = New System.Drawing.Point(10, 480)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(393, 56)
        Me.GroupBox4.TabIndex = 149
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observaciones"
        '
        'txtobservacion
        '
        Me.txtobservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetArqueo1, "ArqueoCajas.Observaciones", True))
        Me.txtobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtobservacion.Location = New System.Drawing.Point(10, 18)
        Me.txtobservacion.MaxLength = 250
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservacion.Size = New System.Drawing.Size(374, 34)
        Me.txtobservacion.TabIndex = 0
        '
        'lblCaja
        '
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCaja.Location = New System.Drawing.Point(653, 0)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(125, 27)
        Me.lblCaja.TabIndex = 150
        Me.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiferenciaCaja
        '
        Me.txtDiferenciaCaja.EditValue = "0.00"
        Me.txtDiferenciaCaja.Location = New System.Drawing.Point(134, 550)
        Me.txtDiferenciaCaja.Name = "txtDiferenciaCaja"
        '
        '
        '
        Me.txtDiferenciaCaja.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDiferenciaCaja.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDiferenciaCaja.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiferenciaCaja.Properties.ReadOnly = True
        Me.txtDiferenciaCaja.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDiferenciaCaja.Size = New System.Drawing.Size(260, 22)
        Me.txtDiferenciaCaja.TabIndex = 54
        Me.txtDiferenciaCaja.TabStop = False
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(20, 553)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 19)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Diferencia :"
        '
        'ArqueoCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 640)
        Me.Controls.Add(Me.txtDiferenciaCaja)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ArqueoCaja"
        Me.Text = "Arqueo de Caja"
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.TextBox6, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.lblCaja, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtDiferenciaCaja, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetArqueo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txtDepositoDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepositosCol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequesDol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheques.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDiferenciaCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub ArqueoCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        AdapterMoneda.Fill(DataSetArqueo1.Moneda)
        AdapterDenominacion.Fill(DataSetArqueo1.Denominacion_Moneda)
        AdapterTarjeta.Fill(DataSetArqueo1.TipoTarjeta)
        ValoresDefecto()
        Inhabilitar()
        TextBox6.Focus()

        If IsClinica() = True Then
            txtDepositosCol.Properties.Enabled = False
            txtDepositoDolar.Properties.Enabled = False
            txtDepositosCol.Properties.ReadOnly = True
            txtDepositoDolar.Properties.ReadOnly = True
        Else
            txtDepositosCol.Properties.Enabled = True
            txtDepositoDolar.Properties.Enabled = True
            txtDepositosCol.Properties.ReadOnly = False
            txtDepositoDolar.Properties.ReadOnly = False
        End If
    End Sub

    Function ValoresDefecto()
        Dim i, j As Integer
        TextEdit1.EditValue = 0
        TextEdit2.EditValue = 0
        TextEdit3.EditValue = 0
        TextEdit4.EditValue = 0
        TextEdit6.EditValue = 0
        txtCheques.EditValue = 0

        '------------------------------------------------------------------------------------------
        ' DENOMINACIONES MONEDA - ORA
        For i = 0 To DataSetArqueo1.Denominacion_Moneda.Rows.Count - 1
            DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("Total") = 0
            DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("Cantidad") = 0
            For j = 0 To DataSetArqueo1.Moneda.Rows.Count - 1
                If DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("CodMoneda") = DataSetArqueo1.Moneda.Rows(j).Item("CodMoneda") Then
                    DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("Moneda") = DataSetArqueo1.Moneda.Rows(j).Item("MonedaNombre")
                End If
            Next
        Next
        '------------------------------------------------------------------------------------------

        '------------------------------------------------------------------------------------------
        ' TARJETAS - ORA
        For i = 0 To DataSetArqueo1.TipoTarjeta.Rows.Count - 1
            DataSetArqueo1.TipoTarjeta.Rows(i).Item("Total") = 0
            For j = 0 To DataSetArqueo1.Moneda.Rows.Count - 1
                If DataSetArqueo1.TipoTarjeta.Rows(i).Item("Moneda") = DataSetArqueo1.Moneda.Rows(j).Item("CodMoneda") Then
                    DataSetArqueo1.TipoTarjeta.Rows(i).Item("Monedas") = DataSetArqueo1.Moneda.Rows(j).Item("MonedaNombre")
                End If
                If DataSetArqueo1.Moneda.Rows(j).Item("CodMoneda") = 2 Then
                    TipoCambioDolar = DataSetArqueo1.Moneda.Rows(j).Item("ValorCompra")
                End If
            Next
        Next
        '------------------------------------------------------------------------------------------

        DataSetArqueo1.ArqueoCajas.EfectivoColonesColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.EfectivoDolaresColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.TarjetaColonesColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.TarjetaDolaresColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.ChequesColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.ChequesDolColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.DepositoColColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.DepositoDolColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.TotalColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.IdAperturaColumn.DefaultValue = "0"
        DataSetArqueo1.ArqueoCajas.ObservacionesColumn.DefaultValue = "--"
    End Function
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Me.Nuevo()
            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : Me.Editar()
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Nuevo"
    Function Nuevo()
        Label7.Visible = False
        Me.lblCaja.Text = ""
        If Me.ToolBarNuevo.Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            Try 'inicia la edicion
                Me.txtDiferenciaCaja.Text = "0.00"
                Me.BindingContext(Me.DataSetArqueo1.ArqueoCajas).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetArqueo1.ArqueoEfectivo).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetArqueo1.ArqueoTarjeta).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").AddNew()
                Me.BindingContext(Me.DataSetArqueo1, "ArqueoEfectivo").AddNew()
                Me.BindingContext(Me.DataSetArqueo1, "ArqueoTarjeta").AddNew()
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.ToolBarNuevo.ImageIndex = 8
                Me.ToolBarRegistrar.Enabled = True
                Habilitar()
                Me.CargarDepositos(Me.NApertura)
                GridControl1.Focus()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Else
            Try
                Me.BindingContext(Me.DataSetArqueo1.ArqueoEfectivo).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetArqueo1.ArqueoTarjeta).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetArqueo1.ArqueoCajas).CancelCurrentEdit()
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarRegistrar.Enabled = False
                Me.Inhabilitar()
                Me.txtDiferenciaCaja.Text = "0.00"
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region

#Region "Editar"
    Private Sub Editar()
        If ToolBarEliminar.Text = "Editar" Then
            ToolBarEliminar.Text = "Cancelar"
            ToolBarEliminar.ImageIndex = 8
            ToolBarRegistrar.Text = "Actualizar"
            ToolBarRegistrar.Enabled = True
            ToolBarNuevo.Enabled = False
            ToolBarBuscar.Enabled = False
            ToolBarEliminar.Enabled = False
            Habilitar()

        Else
            ToolBarEliminar.Text = "Editar"
            ToolBarRegistrar.Text = "Registrar"
            ToolBarEliminar.ImageIndex = 5
            ToolBarRegistrar.Enabled = False
            ToolBarNuevo.Enabled = True
            ToolBarBuscar.Enabled = True
            ToolBarEliminar.Enabled = True
            Inhabilitar()
        End If
    End Sub
#End Region

#Region "Buscar"
    Private Sub Buscar()
        Try
            Dim cFunciones As New cFunciones
            Dim Id_ArqueoCaja As String = cFunciones.Buscar_X_Descripcion_Fecha("select cast(Id as varchar) as Arqueo, Cajero,Fecha from ArqueoCajas Order by Id Desc", "Cajero", "Fecha", "Arqueo Caja ....")

            If Id_ArqueoCaja = Nothing Then

            Else
                Cargar(Id_ArqueoCaja)                
                ToolBarEliminar.Enabled = True
                ToolBarExcel.Enabled = True
                ToolBarImprimir.Enabled = True
                If DataSetArqueo1.ArqueoCajas.Rows.Count > 0 Then
                    If BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Anulado") = True Then
                        Label7.Visible = True
                        Me.ToolBarExcel.Enabled = False
                        Me.ToolBarEliminar.Enabled = False
                        Me.ToolBarNuevo.Enabled = True
                    Else
                        Label7.Visible = False
                    End If
                    Inhabilitar()
                    GroupBox1.Enabled = True
                End If

                If ValidarApertura(Id_ArqueoCaja) Then
                    Me.ToolBarEliminar.Enabled = False
                    Me.ToolBarNuevo.Enabled = True
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function ValidarApertura(ByVal IdArqueo As String) As Boolean
        Try
            Dim dta As New DataTable
            Dim cf As New cFunciones
            cf.Llenar_Tabla_Generico("SELECT     dbo.aperturacaja.Estado, dbo.ArqueoCajas.Id, dbo.aperturacaja.NApertura " & _
                                    " FROM         dbo.ArqueoCajas INNER JOIN" & _
                                    " dbo.aperturacaja ON dbo.ArqueoCajas.IdApertura = dbo.aperturacaja.NApertura " & _
                                    " WHERE     (dbo.ArqueoCajas.Id = " & IdArqueo & ")", dta)
            If dta.Rows(0).Item("Estado") = "C" Then
                MsgBox("El número de Apertura " & dta.Rows(0).Item("NApertura") & " Tiene un Cierre(" & dta.Rows(0).Item("Estado") & ") hecho", MsgBoxStyle.Information, "Atención...")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Cargar(ByVal IdArqueo As String)
        Try
            Dim cFunciones As New cFunciones
            Me.DataSetArqueo1.ArqueoEfectivo.Clear()
            Me.DataSetArqueo1.ArqueoTarjeta.Clear()
            Me.DataSetArqueo1.ArqueoCajas.Clear()

            cFunciones.Llenar_Tabla_Generico("Select * from ArqueoCajas Where Id = " & IdArqueo, Me.DataSetArqueo1.ArqueoCajas)
            cFunciones.Llenar_Tabla_Generico("Select * from ArqueoTarjeta Where Id_Arqueo = " & IdArqueo, Me.DataSetArqueo1.ArqueoTarjeta)
            cFunciones.Llenar_Tabla_Generico("Select * from ArqueoEfectivo Where Id_Arqueo = " & IdArqueo, Me.DataSetArqueo1.ArqueoEfectivo)
            Me.Cargando()
            Me.txtDiferenciaCaja.Text = Me.ObtenerDiferenciaCaja(Me.DataSetArqueo1.ArqueoCajas(0).IdApertura).ToString("N2")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Cargando()
        Try
            Dim I As Integer
            For I = 0 To Me.DataSetArqueo1.Denominacion_Moneda.Count - 1
                Me.DataSetArqueo1.Denominacion_Moneda.Rows(I).Item("Total") = Me.DataSetArqueo1.ArqueoEfectivo.Rows(I).Item("Monto")
                Me.DataSetArqueo1.Denominacion_Moneda.Rows(I).Item("Cantidad") = Me.DataSetArqueo1.ArqueoEfectivo.Rows(I).Item("Cantidad")
            Next
            For I = 0 To Me.DataSetArqueo1.TipoTarjeta.Count - 1
                Me.DataSetArqueo1.TipoTarjeta.Rows(I).Item("Total") = Me.DataSetArqueo1.ArqueoTarjeta.Rows(I).Item("Monto")
            Next

            TextEdit1.EditValue = Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("EfectivoColones")
            TextEdit2.EditValue = Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("EfectivoDolares")
            TextEdit3.EditValue = Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("TarjetaColones")
            TextEdit4.EditValue = Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("TarjetaDolares")
            txtCheques.EditValue = Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Cheques")
            TextEdit6.EditValue = Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Total")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Registrar"
    Function Registrar()
        Try
            Dim resp As Integer
            If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()

            Dim myCommandArqueoTarjeta As SqlCommand = SqlConnection1.CreateCommand()
            Dim myCommandArqueoEfectivo As SqlCommand = SqlConnection1.CreateCommand()

            If Validar() Then
                resp = MsgBox("¿Deseas Guardar los cambios?", MsgBoxStyle.YesNo, "SeeSoft")
                If resp = 6 Then
                    Try
                        Me.txtDiferenciaCaja.Text = Me.ObtenerDiferenciaCaja(NApertura).ToString("N2")
                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura") = NApertura
                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Fecha") = Date.Today.ToShortDateString
                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Anulado") = 0
                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("TipoCambioD") = 0
                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Cajero") = txtNombreUsuario.Text
                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").EndCurrentEdit()
                        CargarDatos()

                        Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").EndCurrentEdit()
                        Me.AdapterEfectivo.InsertCommand.Transaction = Trans
                        Me.AdapterTarjetas.InsertCommand.Transaction = Trans
                        Me.AdapterArqueodeCaja.InsertCommand.Transaction = Trans

                        Me.AdapterEfectivo.UpdateCommand.Transaction = Trans
                        Me.AdapterTarjetas.UpdateCommand.Transaction = Trans
                        Me.AdapterArqueodeCaja.UpdateCommand.Transaction = Trans

                        If Me.ToolBarRegistrar.Text = "Actualizar" Then
                            myCommandArqueoTarjeta.CommandText = "DELETE ArqueoTarjeta WHERE Id_Arqueo = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id")
                            myCommandArqueoTarjeta.Transaction = Trans
                            myCommandArqueoTarjeta.ExecuteNonQuery()

                            myCommandArqueoEfectivo.CommandText = "DELETE arqueoEfectivo WHERE Id_Arqueo = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id")
                            myCommandArqueoEfectivo.Transaction = Trans
                            myCommandArqueoEfectivo.ExecuteNonQuery()
                        End If
                        evaluarArqueoTarjetas()
                        Me.AdapterArqueodeCaja.Update(Me.DataSetArqueo1, "ArqueoCajas")
                        Me.AdapterEfectivo.Update(Me.DataSetArqueo1, "ArqueoEfectivo")
                        Me.AdapterTarjetas.Update(Me.DataSetArqueo1, "ArqueoTarjeta")

                        myCommand1.CommandText = "UPDATE aperturacaja SET Estado = '" & "M" & "' WHERE NApertura = " & NApertura
                        myCommand1.Transaction = Trans
                        myCommand1.ExecuteNonQuery()
                        Trans.Commit()
                        Me.lblCaja.Text = ""
                        'Para boton Nuevo
                        Me.ToolBarNuevo.Text = "Nuevo"
                        Me.ToolBarNuevo.ImageIndex = 0
                        'Para boton Acualizar
                        Me.ToolBarRegistrar.Enabled = False
                        Me.ToolBarEliminar.ImageIndex = 5

                        Dim cConexion As New Conexion
                        Dim sqlConexionC As New SqlConnection
                        sqlConexionC = cConexion.Conectar
                        cConexion.SlqExecute(sqlConexionC, "Update ArqueoCajas set TipoCambioD=" & TipoCambioDolar & " where idApertura=" & NApertura)
                        cConexion.DesConectar(sqlConexionC)
                        sqlConexionC = Nothing
                        cConexion = Nothing

                        Me.Inhabilitar()
                        MsgBox("Datos Ingresados Satisfactoriamente...." & vbCrLf _
                               & "Diferencia de caja : " & Me.txtDiferenciaCaja.Text, MsgBoxStyle.Information, "Atención...")

                        'Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Id")
                        Me.RegistrarArqueoDepositos(BindingContext(DataSetArqueo1, "ArqueoCajas").Current("IdApertura"), BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id"))
                        Try
                            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                            db.Ejecutar("Update ArqueoCajas set Diferencia = " & CDec(Me.txtDiferenciaCaja.Text) & " where Id = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id"), CommandType.Text)
                        Catch ex As Exception
                        End Try

                        If (MsgBox("Desea Imprimir el reporte de Arqueo ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                            Me.Imprimir()
                        End If

                        If (MsgBox("Desea Imprimir el detale de caja ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                            Me.ImprimirDetalleCaja(NApertura)
                        End If

                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                Else
                    Me.BindingContext(Me.DataSetArqueo1.ArqueoCajas).CancelCurrentEdit()
                    Me.DataSetArqueo1.RejectChanges()
                    'Para boton Nuevo
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    'Para boton Acualizar
                    Me.ToolBarEliminar.Text = "Editar"
                    Me.ToolBarEliminar.ImageIndex = 5
                    Me.Inhabilitar()
                End If
            Else
                MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub ImprimirDetalleCaja(_IdCaja As Long)
        Try
            Dim frm As New frmVisorReportes
            Dim rpt As New rptDetallaApertura
            rpt.Refresh()
            rpt.SetParameterValue(0, _IdCaja)
            frm.rptViewer.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Sub evaluarArqueoTarjetas()
        Dim i As Integer = 0
        Dim d As Boolean = False
        For i = 0 To Me.DataSetArqueo1.TipoTarjeta.Count - 1
            If Me.DataSetArqueo1.TipoTarjeta(i).Total > Me.DataSetArqueo1.ArqueoTarjeta(i).Monto Then
                d = True
                Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").Position = i
                Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").Current("Monto") = Me.DataSetArqueo1.TipoTarjeta(i).Total
                Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").EndCurrentEdit()
            End If
        Next
        If d Then
            MsgBox("No se registro correctamente los montos de las tarjetas")
        End If
    End Sub

    Function Validar()
        Return True
    End Function

    Function CargarDatos()
        Dim I As Integer
        For I = 0 To Me.DataSetArqueo1.Denominacion_Moneda.Count - 1
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoEfectivo").AddNew()
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoEfectivo").Current("Id_Denominacion") = Me.DataSetArqueo1.Denominacion_Moneda.Rows(I).Item("Id")
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoEfectivo").Current("Monto") = Me.DataSetArqueo1.Denominacion_Moneda.Rows(I).Item("Total")
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoEfectivo").Current("Cantidad") = Me.DataSetArqueo1.Denominacion_Moneda.Rows(I).Item("Cantidad")
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoEfectivo").EndCurrentEdit()
        Next

        For I = 0 To Me.DataSetArqueo1.TipoTarjeta.Count - 1
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").AddNew()
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").Current("Id_Tarjeta") = Me.DataSetArqueo1.TipoTarjeta.Rows(I).Item("Id")
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").Current("Monto") = Me.DataSetArqueo1.TipoTarjeta.Rows(I).Item("Total")
            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas.ArqueoCajasArqueoTarjeta").EndCurrentEdit()
        Next
    End Function
#End Region

#Region "Imprimir"
    Function Imprimir()
        Try
            Dim ReporteArqueo As New ReporteArqueo
            Dim visor As New frmVisorReportes
            visor.MdiParent = Me.ParentForm
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, ReporteArqueo)
            ReporteArqueo.SetParameterValue(0, Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Id"))
            visor.Show()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Anular"
    Function Anular()
        Try
            Dim resp As Integer
            If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()
            Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()

            resp = MessageBox.Show("¿Deseas Anular el Arqueo?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "A" & "' WHERE NApertura = " & Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura")
                myCommand2.Transaction = Trans
                myCommand2.ExecuteNonQuery()

                myCommand1.CommandText = "UPDATE ArqueoCajas SET Anulado =  1 WHERE Id = " & Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Id")
                myCommand1.Transaction = Trans
                myCommand1.ExecuteNonQuery()

                Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura") = NApertura
                Trans.Commit()

                MsgBox("Datos Anulados Correctamente....", MsgBoxStyle.Information, "Atención...")
                Label7.Visible = True
                Me.Inhabilitar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Funciones"
    Function Buscar_Apertura(ByVal usuario As String) As Boolean
        Try
            Dim func As New cFunciones
            Dim i As Integer

            func.Cargar_Tabla_Generico(Me.AdapterApertura, "SELECT * FROM AperturaCaja WHERE (Anulado = 0) AND (Estado = 'A' or Estado = 'B') and cedula= '" & usuario & "' ")
            i = Me.AdapterApertura.Fill(Me.DataSetArqueo1.aperturacaja)
            Select Case i
                Case 1
                    Dim dts As New DataTable
                    NApertura = Me.DataSetArqueo1.aperturacaja.Rows(0).Item("NApertura")
                    Me.txtNombreUsuario.Text = Me.DataSetArqueo1.aperturacaja.Rows(0).Item("Nombre")
                    cFunciones.Llenar_Tabla_Generico("SELECT * FROM AperturaCaja where NApertura = " & NApertura, dts, CadenaConexionSeePOS)
                    Me.lblCaja.Text = "Caja #" & dts.Rows(0).Item("Num_Caja")
                    Return True
                Case 0
                    MsgBox(Me.nombre & " " & "No tiene una apertura de caja abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
                Case Else
                    Dim frm As New frmSeleccionaCaja
                    frm.CedulaUsuario = usuario
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        NApertura = frm.viewCajas("Napertura", frm.viewCajas.CurrentRow.Index).Value
                        Me.txtNombreUsuario.Text = frm.viewCajas("Usuario", frm.viewCajas.CurrentRow.Index).Value
                        Me.lblCaja.Text = "Caja #" & frm.viewCajas("Num_Caja", frm.viewCajas.CurrentRow.Index).Value
                        Return True
                    Else
                        MsgBox(Me.nombre & " " & "tiene mas de una caja abierta, seleccione la caja a utilizar", MsgBoxStyle.Exclamation)
                        Return False
                    End If                    
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Recalcular_Fila(ByVal x As Integer) ', ByVal Cantidad As Integer
        Dim Denominacion, Cantidad, Total As Double '''
        If Me.DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("CodMoneda") = 1 Then
            Denominacion = DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("Denominacion")
            Cantidad = DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("Cantidad")
            DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("Total") = Denominacion * Cantidad
        End If

        If DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("CodMoneda") = 2 Then
            Denominacion = DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("Denominacion")
            Cantidad = DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("Cantidad")
            DataSetArqueo1.Denominacion_Moneda.Rows(x).Item("Total") = Denominacion * Cantidad
        End If

        CalcularTotales()
    End Function

    Function CalcularTotales()
        Dim i As Integer
        Me.TextEdit1.EditValue = 0
        Me.TextEdit2.EditValue = 0

        For i = 0 To Me.DataSetArqueo1.Denominacion_Moneda.Rows.Count - 1
            If Me.DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("CodMoneda") = 1 Then
                Me.TextEdit1.EditValue += Me.DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("Total")
            ElseIf Me.DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("CodMoneda") = 2 Then
                Me.TextEdit2.EditValue += Me.DataSetArqueo1.Denominacion_Moneda.Rows(i).Item("Total")
            End If
        Next
        TotalGeneral()
    End Function

    Function Recalcular(ByVal x As Integer)
        Dim i As Double
        Me.TextEdit3.EditValue = 0
        Me.TextEdit4.EditValue = 0

        For i = 0 To Me.DataSetArqueo1.TipoTarjeta.Rows.Count - 1
            If Me.DataSetArqueo1.TipoTarjeta.Rows(i).Item("Moneda") = 1 Then
                Me.TextEdit3.EditValue += Me.DataSetArqueo1.TipoTarjeta.Rows(i).Item("Total")
            Else
                Me.TextEdit4.EditValue += Me.DataSetArqueo1.TipoTarjeta.Rows(i).Item("Total")
            End If
        Next
        TotalGeneral()
    End Function

    Function TotalGeneral()
        Dim EfectivoDolares, TarjetaDolares, ChequesDolares, DepositoDolares As Double
        Try
            EfectivoDolares = Me.TextEdit2.EditValue * TipoCambioDolar
        Catch ex As Exception
        End Try

        Try
            TarjetaDolares = Me.TextEdit4.EditValue * TipoCambioDolar
        Catch ex As Exception
        End Try

        Try
            ChequesDolares = Me.txtChequesDol.EditValue * TipoCambioDolar
        Catch ex As Exception
        End Try

        Try
            DepositoDolares = Me.txtDepositoDolar.EditValue * TipoCambioDolar
        Catch ex As Exception
        End Try

        Try
            Me.TextEdit6.EditValue = EfectivoDolares + TarjetaDolares + TextEdit1.EditValue + TextEdit3.EditValue + txtCheques.EditValue + ChequesDolares + txtDepositosCol.EditValue + DepositoDolares
        Catch ex As Exception
        End Try
    End Function
#End Region

#Region "Controles Funciones"
    Private Sub GridControl1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyUp
        If e.KeyCode = Keys.Enter Then Me.Recalcular_Fila(Me.BindingContext(Me.DataSetArqueo1, "Denominacion_Moneda").Position())
    End Sub

    Private Sub TextEdit5_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged, TextEdit2.EditValueChanged
        TotalGeneral()
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Me.Recalcular_Fila(Me.BindingContext(Me.DataSetArqueo1, "Denominacion_Moneda").Position())
    End Sub

    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Me.Recalcular(0)
    End Sub

    Private Sub txtobservacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtobservacion.GotFocus
        txtobservacion.SelectAll()
    End Sub

    Private Sub txtCheques_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCheques.EditValueChanged, txtChequesDol.EditValueChanged, txtDepositosCol.EditValueChanged, txtDepositoDolar.EditValueChanged
        TotalGeneral()
    End Sub

    Private Sub txtCheques_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheques.KeyPress, txtChequesDol.KeyPress, txtDepositosCol.KeyPress, txtDepositoDolar.KeyPress
        Try
            If Not IsNumeric(sender.text & e.KeyChar) Then
                If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                    e.Handled = True  ' esto invalida la tecla pulsada
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

#End Region

#Region "Controles"
    Function Habilitar()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        GroupBox4.Enabled = True
    End Function

    Function Inhabilitar()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
    End Function
#End Region

    Public Sub RegistrarArqueoDepositos(_IdApertura As Long, _IdArqueo As Long)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.Ejecutar("Update arqueodeposito Set IdArqueo = " & _IdArqueo & " where IdApertura = " & _IdApertura, CommandType.Text)
    End Sub


    Private Sub CargarDepositos(_IdApertura As Long)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select sum(monto) as Monto from arqueodeposito where IdApertura = " & _IdApertura & " and Moneda in('COLON','COLONES')", dt, CadenaConexionSeePOS)

        Try
            If dt.Rows.Count > 0 Then
                Me.txtDepositosCol.EditValue = CDec(dt.Rows(0).Item("Monto")).ToString("N2")
            Else
                Me.txtDepositosCol.EditValue = "0"
            End If
        Catch ex As Exception
            Me.txtDepositosCol.EditValue = "0"
        End Try

        dt = New DataTable
        cFunciones.Llenar_Tabla_Generico("select sum(monto) as Monto from arqueodeposito where IdApertura = " & _IdApertura & " and Moneda in('DOLAR','DOLARES')", dt, CadenaConexionSeePOS)
        Try
            If dt.Rows.Count > 0 Then
                Me.txtDepositoDolar.EditValue = CDec(dt.Rows(0).Item("Monto")).ToString("N2")
            Else
                Me.txtDepositoDolar.EditValue = "0"
            End If
        Catch ex As Exception
            Me.txtDepositoDolar.EditValue = "0"
        End Try
        

    End Sub

#Region "Validar Usuario"
    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        If e.KeyCode = Keys.Enter Then
            If TextBox6.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & TextBox6.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    TextBox6.Focus()
                End If
                While rs.Read
                    Try
                        PMU = VSM(rs("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                        If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
                        txtNombreUsuario.Text = rs("Nombre")
                        Cedula = rs("Cedula")
                        nombre = rs("Nombre")

                        If Not Me.Buscar_Apertura(Cedula) Then
                            Me.TextBox6.Focus()
                            Me.TextBox6.Text = ""
                            Me.txtNombreUsuario.Text = ""
                            Me.ToolBarNuevo.Enabled = False
                            Me.ToolBarRegistrar.Enabled = False
                            Me.ToolBarBuscar.Enabled = True
                        Else
                            Me.ToolBarNuevo.Enabled = True
                            Me.ToolBarRegistrar.Enabled = False
                            Me.ToolBarBuscar.Enabled = True
                        End If

                        TextBox6.Enabled = False ' se inabilita el campo de la contraseña

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                TextBox6.Focus()
            End If
        End If
    End Sub
#End Region

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Function ObtenerDiferenciaCaja(_IdAperturaCaja As Integer) As Decimal
        Dim dtOpcionesdePago As New DataTable
        Dim dtAperturaCaja As New DataTable
        Dim TotalSistema As Decimal = 0
        Dim AperturaCaja As Decimal = 0
        Try
            cFunciones.Llenar_Tabla_Generico("select att.Monto_Tope as MontoApertura from aperturacaja ap inner join Apertura_Total_Tope att on ap.NApertura = att.NApertura and att.CodMoneda = 1 where ap.NApertura = " & _IdAperturaCaja, dtAperturaCaja, CadenaConexionSeePOS)
            AperturaCaja = dtAperturaCaja.Rows(0).Item("MontoApertura")
            If dtAperturaCaja.Rows.Count > 0 Then
                cFunciones.Llenar_Tabla_Generico("select TipoDocumento, SUM(MontoPago) as MontoPago from OpcionesDePago where Numapertura = " & _IdAperturaCaja & " and FormaPago not in('ANU','PRE') group by TipoDocumento", dtOpcionesdePago, CadenaConexionSeePOS)
                If dtOpcionesdePago.Rows.Count > 0 Then
                    For Each row As DataRow In dtOpcionesdePago.Rows
                        Select Case row.Item("TipoDocumento").ToString
                            Case "CON" : TotalSistema += row("MontoPago") 'contado
                            Case "FVC" : TotalSistema += row("MontoPago") 'factura venta contado
                            Case "MCS" : TotalSistema -= row("MontoPago") 'movimiento caja salida
                            Case "ABO" : TotalSistema += row("MontoPago") 'abono cxc
                            Case "MCE" : TotalSistema += row("MontoPago") 'movimiento caja entraa
                            Case "FVP" : TotalSistema += row("MontoPago") 'factura venta punto de venta
                            Case "PVE" : TotalSistema += row("MontoPago") ' punto de venta
                            Case "DVE" : TotalSistema -= row("MontoPago") 'devolucion de venta
                        End Select
                    Next
                End If
            End If            
        Catch ex As Exception
        End Try
        Return CDec(TextEdit6.EditValue) - (TotalSistema + AperturaCaja)
    End Function

End Class
