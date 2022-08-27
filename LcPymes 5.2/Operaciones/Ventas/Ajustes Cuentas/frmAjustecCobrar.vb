Imports System.data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class frmAjustecCobrar
    'Inherits System.Windows.Forms.Form
    Inherits FrmPlantilla

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents txtNum_Ajuste As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActGen As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoGen As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAntGen As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo_Ant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbSimbolo6 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo5 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo2 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoAct As System.Windows.Forms.TextBox
    Friend WithEvents txtAbono As System.Windows.Forms.TextBox
    Friend WithEvents dtEmitida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoSuMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents gridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Factura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    'Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    'Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarAnular As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents opNotaCredito As System.Windows.Forms.RadioButton
    Friend WithEvents opNotaDebito As System.Windows.Forms.RadioButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daAjuste As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daDetalleAjuste As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AjusteCxC1 As AjusteCxC
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtTipo As System.Windows.Forms.Label
    Friend WithEvents txtTipoD As System.Windows.Forms.Label
    Friend WithEvents Label_Id_Ajuste As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents colCuentaC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtCuentaC As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionC As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjustecCobrar))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNum_Ajuste = New System.Windows.Forms.Label
        Me.AjusteCxC1 = New LcPymes_5._2.AjusteCxC
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSaldoActGen = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAbonoGen = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSaldoAntGen = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaldo_Ant = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAbono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuentaC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescripcionC = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCuentaC = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbSimbolo6 = New System.Windows.Forms.Label
        Me.lbSimbolo5 = New System.Windows.Forms.Label
        Me.lbSimbolo2 = New System.Windows.Forms.Label
        Me.lbSimbolo1 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.txtSaldoAct = New System.Windows.Forms.TextBox
        Me.txtAbono = New System.Windows.Forms.TextBox
        Me.dtEmitida = New System.Windows.Forms.DateTimePicker
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAbonoSuMoneda = New System.Windows.Forms.TextBox
        Me.txtTipoD = New System.Windows.Forms.Label
        Me.txtTipoCambio = New System.Windows.Forms.Label
        Me.gridFacturas = New DevExpress.XtraGrid.GridControl
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Factura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.ComboMoneda = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.Label
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.opNotaDebito = New System.Windows.Forms.RadioButton
        Me.opNotaCredito = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daAjuste = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daDetalleAjuste = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.txtTipo = New System.Windows.Forms.Label
        Me.Label_Id_Ajuste = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.AjusteCxC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Text = "Anular"
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 398)
        Me.ToolBar1.Size = New System.Drawing.Size(698, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(550, 426)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(698, 32)
        Me.TituloModulo.Text = "Ajuste Cuentas x Cobrar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 12)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Ajuste N°"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNum_Ajuste
        '
        Me.txtNum_Ajuste.BackColor = System.Drawing.Color.White
        Me.txtNum_Ajuste.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.AjusteNo", True))
        Me.txtNum_Ajuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNum_Ajuste.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNum_Ajuste.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNum_Ajuste.Location = New System.Drawing.Point(92, 18)
        Me.txtNum_Ajuste.Name = "txtNum_Ajuste"
        Me.txtNum_Ajuste.Size = New System.Drawing.Size(56, 12)
        Me.txtNum_Ajuste.TabIndex = 161
        Me.txtNum_Ajuste.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AjusteCxC1
        '
        Me.AjusteCxC1.DataSetName = "AjusteCxC"
        Me.AjusteCxC1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.AjusteCxC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AjusteCxC1, "ajustesccobrar.Anula", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(1, 455)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 12)
        Me.CheckBox1.TabIndex = 187
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(478, 396)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 72)
        Me.GroupBox2.TabIndex = 186
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 16)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Saldos de la Cuenta"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoActGen
        '
        Me.txtSaldoActGen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoActGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoActGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Saldo_Act", True))
        Me.txtSaldoActGen.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoActGen.Location = New System.Drawing.Point(96, 48)
        Me.txtSaldoActGen.Name = "txtSaldoActGen"
        Me.txtSaldoActGen.Size = New System.Drawing.Size(107, 13)
        Me.txtSaldoActGen.TabIndex = 162
        Me.txtSaldoActGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 12)
        Me.Label18.TabIndex = 161
        Me.Label18.Text = "Saldo Act."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbonoGen
        '
        Me.txtAbonoGen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbonoGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbonoGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Monto", True))
        Me.txtAbonoGen.ForeColor = System.Drawing.Color.Blue
        Me.txtAbonoGen.Location = New System.Drawing.Point(96, 32)
        Me.txtAbonoGen.Name = "txtAbonoGen"
        Me.txtAbonoGen.Size = New System.Drawing.Size(107, 13)
        Me.txtAbonoGen.TabIndex = 160
        Me.txtAbonoGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(8, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 12)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Monto Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoAntGen
        '
        Me.txtSaldoAntGen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoAntGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoAntGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Saldo_Prev", True))
        Me.txtSaldoAntGen.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoAntGen.Location = New System.Drawing.Point(96, 16)
        Me.txtSaldoAntGen.Name = "txtSaldoAntGen"
        Me.txtSaldoAntGen.Size = New System.Drawing.Size(107, 13)
        Me.txtSaldoAntGen.TabIndex = 158
        Me.txtSaldoAntGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(8, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Saldo Ant."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar"
        Me.GridControl2.DataSource = Me.AjusteCxC1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 200)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(680, 168)
        Me.GridControl2.TabIndex = 179
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactura, Me.colMonto, Me.colSaldo_Ant, Me.colAbono, Me.colSaldo, Me.colCuentaC})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFactura
        '
        Me.colFactura.Caption = "Factura"
        Me.colFactura.FieldName = "Factura"
        Me.colFactura.FilterInfo = ColumnFilterInfo1
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
        Me.colFactura.Width = 97
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto Fact."
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo2
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
        Me.colMonto.Width = 123
        '
        'colSaldo_Ant
        '
        Me.colSaldo_Ant.Caption = "Saldo Ant."
        Me.colSaldo_Ant.FieldName = "Saldo_Ant"
        Me.colSaldo_Ant.FilterInfo = ColumnFilterInfo3
        Me.colSaldo_Ant.Name = "colSaldo_Ant"
        Me.colSaldo_Ant.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo_Ant.VisibleIndex = 2
        Me.colSaldo_Ant.Width = 122
        '
        'colAbono
        '
        Me.colAbono.Caption = "Abono"
        Me.colAbono.FieldName = "Ajuste"
        Me.colAbono.FilterInfo = ColumnFilterInfo4
        Me.colAbono.Name = "colAbono"
        Me.colAbono.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colAbono.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colAbono.VisibleIndex = 3
        Me.colAbono.Width = 96
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo Act."
        Me.colSaldo.FieldName = "Saldo_Ajustado"
        Me.colSaldo.FilterInfo = ColumnFilterInfo5
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 117
        '
        'colCuentaC
        '
        Me.colCuentaC.Caption = "Cuenta Contable"
        Me.colCuentaC.FieldName = "CuentaContable"
        Me.colCuentaC.FilterInfo = ColumnFilterInfo6
        Me.colCuentaC.Name = "colCuentaC"
        Me.colCuentaC.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCuentaC.VisibleIndex = 5
        Me.colCuentaC.Width = 93
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtDescripcionC)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCuentaC)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo6)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo5)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo2)
        Me.GroupBox1.Controls.Add(Me.lbSimbolo1)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtSaldoAct)
        Me.GroupBox1.Controls.Add(Me.txtAbono)
        Me.GroupBox1.Controls.Add(Me.dtEmitida)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAbonoSuMoneda)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(306, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 96)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcionC
        '
        Me.txtDescripcionC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionC.Location = New System.Drawing.Point(264, 80)
        Me.txtDescripcionC.Name = "txtDescripcionC"
        Me.txtDescripcionC.ReadOnly = True
        Me.txtDescripcionC.Size = New System.Drawing.Size(112, 13)
        Me.txtDescripcionC.TabIndex = 220
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(192, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 12)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "Descripción"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuentaC
        '
        Me.txtCuentaC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.CuentaContable", True))
        Me.txtCuentaC.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaC.Location = New System.Drawing.Point(88, 80)
        Me.txtCuentaC.Name = "txtCuentaC"
        Me.txtCuentaC.Size = New System.Drawing.Size(96, 13)
        Me.txtCuentaC.TabIndex = 185
        Me.txtCuentaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(8, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 12)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "Cuenta Cont."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSimbolo6
        '
        Me.lbSimbolo6.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo6.Location = New System.Drawing.Point(272, 48)
        Me.lbSimbolo6.Name = "lbSimbolo6"
        Me.lbSimbolo6.Size = New System.Drawing.Size(12, 12)
        Me.lbSimbolo6.TabIndex = 180
        Me.lbSimbolo6.Text = "¢"
        Me.lbSimbolo6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSimbolo5
        '
        Me.lbSimbolo5.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo5.Location = New System.Drawing.Point(272, 16)
        Me.lbSimbolo5.Name = "lbSimbolo5"
        Me.lbSimbolo5.Size = New System.Drawing.Size(12, 12)
        Me.lbSimbolo5.TabIndex = 179
        Me.lbSimbolo5.Text = "¢"
        Me.lbSimbolo5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSimbolo2
        '
        Me.lbSimbolo2.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo2.Location = New System.Drawing.Point(67, 56)
        Me.lbSimbolo2.Name = "lbSimbolo2"
        Me.lbSimbolo2.Size = New System.Drawing.Size(12, 12)
        Me.lbSimbolo2.TabIndex = 177
        Me.lbSimbolo2.Text = "¢"
        Me.lbSimbolo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSimbolo1
        '
        Me.lbSimbolo1.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo1.Location = New System.Drawing.Point(272, 32)
        Me.lbSimbolo1.Name = "lbSimbolo1"
        Me.lbSimbolo1.Size = New System.Drawing.Size(12, 12)
        Me.lbSimbolo1.TabIndex = 176
        Me.lbSimbolo1.Text = "¢"
        Me.lbSimbolo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.Monto", True))
        Me.txtMonto.Enabled = False
        Me.txtMonto.ForeColor = System.Drawing.Color.Blue
        Me.txtMonto.Location = New System.Drawing.Point(292, 32)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(84, 13)
        Me.txtMonto.TabIndex = 174
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.Saldo_Ant", True))
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(88, 56)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(96, 13)
        Me.txtSaldo.TabIndex = 172
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoAct
        '
        Me.txtSaldoAct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoAct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.Saldo_Ajustado", True))
        Me.txtSaldoAct.Enabled = False
        Me.txtSaldoAct.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoAct.Location = New System.Drawing.Point(292, 48)
        Me.txtSaldoAct.Name = "txtSaldoAct"
        Me.txtSaldoAct.Size = New System.Drawing.Size(84, 13)
        Me.txtSaldoAct.TabIndex = 5
        Me.txtSaldoAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAbono
        '
        Me.txtAbono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.Ajuste", True))
        'Me.txtAbono.Enabled = False
        Me.txtAbono.ForeColor = System.Drawing.Color.Blue
        Me.txtAbono.Location = New System.Drawing.Point(292, 16)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.Size = New System.Drawing.Size(84, 13)
        Me.txtAbono.TabIndex = 4
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtEmitida
        '
        Me.dtEmitida.Checked = False
        Me.dtEmitida.CustomFormat = "dd/MMMM/yyyy"
        Me.dtEmitida.Enabled = False
        Me.dtEmitida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEmitida.Location = New System.Drawing.Point(88, 32)
        Me.dtEmitida.Name = "dtEmitida"
        Me.dtEmitida.Size = New System.Drawing.Size(96, 20)
        Me.dtEmitida.TabIndex = 1
        Me.dtEmitida.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'txtFactura
        '
        Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.Factura", True))
        Me.txtFactura.Enabled = False
        Me.txtFactura.ForeColor = System.Drawing.Color.Blue
        Me.txtFactura.Location = New System.Drawing.Point(88, 16)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(96, 13)
        Me.txtFactura.TabIndex = 0
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(192, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 12)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Monto Factura"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 12)
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
        Me.Label12.Location = New System.Drawing.Point(192, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 12)
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
        Me.Label11.Location = New System.Drawing.Point(192, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 12)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Ajuste"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 12)
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
        Me.Label4.Size = New System.Drawing.Size(369, 19)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Datos de la Factura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Factura No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbonoSuMoneda
        '
        Me.txtAbonoSuMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbonoSuMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbonoSuMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.Ajuste_SuMoneda", True))
        Me.txtAbonoSuMoneda.Enabled = False
        Me.txtAbonoSuMoneda.ForeColor = System.Drawing.Color.Blue
        Me.txtAbonoSuMoneda.Location = New System.Drawing.Point(288, 0)
        Me.txtAbonoSuMoneda.Name = "txtAbonoSuMoneda"
        Me.txtAbonoSuMoneda.Size = New System.Drawing.Size(80, 13)
        Me.txtAbonoSuMoneda.TabIndex = 183
        Me.txtAbonoSuMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTipoD
        '
        Me.txtTipoD.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtTipoD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar.TipoNota", True))
        Me.txtTipoD.Enabled = False
        Me.txtTipoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoD.ForeColor = System.Drawing.Color.White
        Me.txtTipoD.Location = New System.Drawing.Point(624, 16)
        Me.txtTipoD.Name = "txtTipoD"
        Me.txtTipoD.Size = New System.Drawing.Size(64, 8)
        Me.txtTipoD.TabIndex = 190
        Me.txtTipoD.Text = "0"
        Me.txtTipoD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(592, 56)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(96, 12)
        Me.txtTipoCambio.TabIndex = 185
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gridFacturas
        '
        '
        '
        '
        Me.gridFacturas.EmbeddedNavigator.Name = ""
        Me.gridFacturas.Location = New System.Drawing.Point(8, 103)
        Me.gridFacturas.MainView = Me.AdvBandedGridView1
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.Size = New System.Drawing.Size(184, 89)
        Me.gridFacturas.TabIndex = 184
        Me.gridFacturas.Text = "GridControl1"
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Factura, Me.Fecha})
        Me.AdvBandedGridView1.GroupPanelText = "Facturas Pendientes"
        Me.AdvBandedGridView1.IndicatorWidth = 8
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ShowFilterPanel = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupedColumns = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Facturas Pendiente de Pago"
        Me.GridBand1.Columns.Add(Me.Factura)
        Me.GridBand1.Columns.Add(Me.Fecha)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 202
        '
        'Factura
        '
        Me.Factura.Caption = "Factura No."
        Me.Factura.FieldName = "Factura"
        Me.Factura.FilterInfo = ColumnFilterInfo7
        Me.Factura.Name = "Factura"
        Me.Factura.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Factura.SortIndex = 0
        Me.Factura.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.Factura.Visible = True
        Me.Factura.Width = 97
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.FilterInfo = ColumnFilterInfo8
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Fecha.Visible = True
        Me.Fecha.Width = 105
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(512, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtFecha
        '
        Me.dtFecha.Checked = False
        Me.dtFecha.CustomFormat = "dd/MMMM/yyyy"
        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Fecha", True))
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(592, 72)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtFecha.TabIndex = 176
        Me.dtFecha.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AjusteCxC1, "ajustesccobrar.Cod_Moneda", True))
        Me.ComboMoneda.DataSource = Me.AjusteCxC1.Moneda
        Me.ComboMoneda.DisplayMember = "MonedaNombre"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.Enabled = False
        Me.ComboMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboMoneda.Location = New System.Drawing.Point(592, 32)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(97, 21)
        Me.ComboMoneda.TabIndex = 175
        Me.ComboMoneda.ValueMember = "CodMoneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(512, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 12)
        Me.Label30.TabIndex = 182
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
        Me.Panel1.Location = New System.Drawing.Point(80, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 16)
        Me.Panel1.TabIndex = 173
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
        Me.txtNombreUsuario.Location = New System.Drawing.Point(121, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(271, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Cod_Usuario", True))
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
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Observaciones", True))
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtObservaciones.Location = New System.Drawing.Point(109, 372)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(578, 12)
        Me.txtObservaciones.TabIndex = 177
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(8, 376)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 12)
        Me.Label29.TabIndex = 181
        Me.Label29.Text = "Observaciones:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox6.Location = New System.Drawing.Point(8, 38)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(456, 56)
        Me.GroupBox6.TabIndex = 174
        Me.GroupBox6.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Cod_Cliente", True))
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
        Me.Label37.Location = New System.Drawing.Point(8, -1)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(432, 16)
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
        Me.Label5.Size = New System.Drawing.Size(368, 12)
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
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Nombre_Cliente", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(80, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(368, 13)
        Me.txtNombre.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.opNotaDebito)
        Me.GroupBox3.Controls.Add(Me.opNotaCredito)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(200, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 96)
        Me.GroupBox3.TabIndex = 188
        Me.GroupBox3.TabStop = False
        '
        'opNotaDebito
        '
        Me.opNotaDebito.Location = New System.Drawing.Point(4, 56)
        Me.opNotaDebito.Name = "opNotaDebito"
        Me.opNotaDebito.Size = New System.Drawing.Size(88, 16)
        Me.opNotaDebito.TabIndex = 159
        Me.opNotaDebito.Text = "Nota Débito"
        '
        'opNotaCredito
        '
        Me.opNotaCredito.Location = New System.Drawing.Point(4, 32)
        Me.opNotaCredito.Name = "opNotaCredito"
        Me.opNotaCredito.Size = New System.Drawing.Size(107, 16)
        Me.opNotaCredito.TabIndex = 158
        Me.opNotaCredito.Text = "Nota Crédito"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 16)
        Me.Label19.TabIndex = 157
        Me.Label19.Text = "Tipo Ajuste"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""SEESOFT-01"";packet size=4096;integrated security=SSPI;data source" & _
            "=""."";persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'daAjuste
        '
        Me.daAjuste.DeleteCommand = Me.SqlDeleteCommand1
        Me.daAjuste.InsertCommand = Me.SqlInsertCommand1
        Me.daAjuste.SelectCommand = Me.SqlSelectCommand1
        Me.daAjuste.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ajustesccobrar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Ajuste", "ID_Ajuste"), New System.Data.Common.DataColumnMapping("AjusteNo", "AjusteNo"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Saldo_Prev", "Saldo_Prev"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Act", "Saldo_Act"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Cod_Usuario", "Cod_Usuario"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente")})})
        Me.daAjuste.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AjusteNo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AjusteNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Act", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Prev", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Prev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@AjusteNo", System.Data.SqlDbType.BigInt, 8, "AjusteNo"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Saldo_Prev", System.Data.SqlDbType.Float, 8, "Saldo_Prev"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Act", System.Data.SqlDbType.Float, 8, "Saldo_Act"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Cod_Usuario", System.Data.SqlDbType.VarChar, 75, "Cod_Usuario"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, "Nombre_Cliente")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID_Ajuste, AjusteNo, Tipo, Cod_Cliente, Fecha, Saldo_Prev, Monto, Saldo_Ac" & _
            "t, Observaciones, Anula, Cod_Usuario, Contabilizado, Cod_Moneda, Asiento, Nombre" & _
            "_Cliente FROM ajustesccobrar"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@AjusteNo", System.Data.SqlDbType.BigInt, 8, "AjusteNo"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Saldo_Prev", System.Data.SqlDbType.Float, 8, "Saldo_Prev"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Act", System.Data.SqlDbType.Float, 8, "Saldo_Act"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Cod_Usuario", System.Data.SqlDbType.VarChar, 75, "Cod_Usuario"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Original_ID_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AjusteNo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AjusteNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Act", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Prev", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Prev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Ajuste", System.Data.SqlDbType.BigInt, 8, "ID_Ajuste")})
        '
        'daDetalleAjuste
        '
        Me.daDetalleAjuste.DeleteCommand = Me.SqlDeleteCommand2
        Me.daDetalleAjuste.InsertCommand = Me.SqlInsertCommand2
        Me.daDetalleAjuste.SelectCommand = Me.SqlSelectCommand2
        Me.daDetalleAjuste.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_ajustesccobrar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DetalleAjustecCobrar", "Id_DetalleAjustecCobrar"), New System.Data.Common.DataColumnMapping("Id_AjustecCobrar", "Id_AjustecCobrar"), New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Ant", "Saldo_Ant"), New System.Data.Common.DataColumnMapping("Ajuste", "Ajuste"), New System.Data.Common.DataColumnMapping("Ajuste_SuMoneda", "Ajuste_SuMoneda"), New System.Data.Common.DataColumnMapping("Saldo_Ajustado", "Saldo_Ajustado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("TipoNota", "TipoNota"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("IdCuentaC", "IdCuentaC")})})
        Me.daDetalleAjuste.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleAjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleAjustecCobrar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ajuste", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste_SuMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCuentaC", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCuentaC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjustecCobrar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ajustado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ajustado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoNota", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoNota", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, "Id_AjustecCobrar"), New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Ajuste", System.Data.SqlDbType.Float, 8, "Ajuste"), New System.Data.SqlClient.SqlParameter("@Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, "Ajuste_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo_Ajustado", System.Data.SqlDbType.Float, 8, "Saldo_Ajustado"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@TipoNota", System.Data.SqlDbType.VarChar, 3, "TipoNota"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@IdCuentaC", System.Data.SqlDbType.Int, 4, "IdCuentaC")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, "Id_AjustecCobrar"), New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Ajuste", System.Data.SqlDbType.Float, 8, "Ajuste"), New System.Data.SqlClient.SqlParameter("@Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, "Ajuste_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo_Ajustado", System.Data.SqlDbType.Float, 8, "Saldo_Ajustado"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@TipoNota", System.Data.SqlDbType.VarChar, 3, "TipoNota"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@IdCuentaC", System.Data.SqlDbType.Int, 4, "IdCuentaC"), New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleAjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleAjustecCobrar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ajuste", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste_SuMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCuentaC", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCuentaC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjustecCobrar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ajustado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ajustado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoNota", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoNota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_DetalleAjustecCobrar", System.Data.SqlDbType.BigInt, 8, "Id_DetalleAjustecCobrar")})
        '
        'daMoneda
        '
        Me.daMoneda.DeleteCommand = Me.SqlDeleteCommand3
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand3
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand3
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.daMoneda.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.Tipo", True))
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipo.Location = New System.Drawing.Point(527, 128)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(56, 16)
        Me.txtTipo.TabIndex = 189
        Me.txtTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Id_Ajuste
        '
        Me.Label_Id_Ajuste.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label_Id_Ajuste.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AjusteCxC1, "ajustesccobrar.ID_Ajuste", True))
        Me.Label_Id_Ajuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Id_Ajuste.ForeColor = System.Drawing.Color.White
        Me.Label_Id_Ajuste.Location = New System.Drawing.Point(648, 0)
        Me.Label_Id_Ajuste.Name = "Label_Id_Ajuste"
        Me.Label_Id_Ajuste.Size = New System.Drawing.Size(40, 12)
        Me.Label_Id_Ajuste.TabIndex = 193
        Me.Label_Id_Ajuste.Text = "0"
        Me.Label_Id_Ajuste.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 450)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(698, 18)
        Me.StatusBar1.TabIndex = 194
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
        Me.StatusBarPanel2.Width = 606
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(512, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 12)
        Me.Label8.TabIndex = 195
        Me.Label8.Text = "Tipo Cambio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAjustecCobrar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 468)
        Me.Controls.Add(Me.txtTipoD)
        Me.Controls.Add(Me.Label_Id_Ajuste)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.gridFacturas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.ComboMoneda)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum_Ajuste)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.StatusBar1)
        Me.Name = "frmAjustecCobrar"
        Me.Text = "CxC-Ajuste a Cuentas"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.txtTipo, 0)
        Me.Controls.SetChildIndex(Me.txtNum_Ajuste, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.ComboMoneda, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtFecha, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.gridFacturas, 0)
        Me.Controls.SetChildIndex(Me.txtTipoCambio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GridControl2, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label_Id_Ajuste, 0)
        Me.Controls.SetChildIndex(Me.txtTipoD, 0)
        CType(Me.AjusteCxC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    'Dim Anular As Boolean = False
    Dim TipoCambioFact As Double 'Tipo Cambio de la Factura
    Dim TipoCambio As Double
    Dim Tabla As DataTable
    Dim buscando As Boolean
    Dim CodigoCuenta As Integer
    Dim PMU As New PerfilModulo_Class


    Private Sub frmAjustecCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        daMoneda.Fill(AjusteCxC1, "Moneda")

        'Establecer valores por defecto AjustecCobrar
        AjusteCxC1.ajustesccobrar.AjusteNoColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.TipoColumn.DefaultValue = "CRE"
        AjusteCxC1.ajustesccobrar.Cod_ClienteColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.FechaColumn.DefaultValue = Now
        AjusteCxC1.ajustesccobrar.Saldo_PrevColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.MontoColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.Saldo_ActColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.ObservacionesColumn.DefaultValue = ""
        AjusteCxC1.ajustesccobrar.AnulaColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.Cod_UsuarioColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.ContabilizadoColumn.DefaultValue = 0
        AjusteCxC1.ajustesccobrar.Cod_MonedaColumn.DefaultValue = 1
        AjusteCxC1.ajustesccobrar.AsientoColumn.DefaultValue = 0

        'Establecer valores por defecto Detalle_AjustecCobrar
        AjusteCxC1.detalle_ajustesccobrar.Id_AjustecCobrarColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.FacturaColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.TipoColumn.DefaultValue = "CRE"
        AjusteCxC1.detalle_ajustesccobrar.MontoColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.Saldo_AntColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.AjusteColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.Ajuste_SuMonedaColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.Saldo_AjustadoColumn.DefaultValue = 0
        AjusteCxC1.detalle_ajustesccobrar.ObservacionesColumn.DefaultValue = ""
        AjusteCxC1.detalle_ajustesccobrar.TipoNotaColumn.DefaultValue = ""

        AjusteCxC1.detalle_ajustesccobrar.CuentaContableColumn.DefaultValue = "0"
        AjusteCxC1.detalle_ajustesccobrar.IdCuentaCColumn.DefaultValue = "1"



        TipoCambio = 1
        txtTipoCambio.Text = 1
        dtFecha.Value = Date.Now
        dtEmitida.Value = Date.Now
        ToolBar1.Buttons(1).Enabled = True
        txtTipo.Text = "CRE"
        txtTipoD.Text = "CRE"
        opNotaCredito.Checked = True
        txtUsuario.Focus()
    End Sub

#Region "Validacion Usuario"
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown

        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If txtUsuario.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                End If
                While rs.Read
                    Try
                        PMU = VSM(rs("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                        If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                        Me.BindingContext(Me.AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
                        Me.BindingContext(Me.AjusteCxC1, "ajustesccobrar").AddNew()
                        Me.txtNum_Ajuste.Text = Numero_de_Ajuste()
                        txtNombreUsuario.Text = rs("Nombre")
                        txtCedulaUsuario.Text = rs("Cedula")


                        'If rs("AnuAjustecCobrar") = 1 Then Anular = True Else Anular = False


                        txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                        Me.ToolBar1.Buttons(0).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(2).Enabled = True
                        Me.NuevoAjuste()
                        ComboMoneda.Focus()

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If
        End If
    End Sub
#End Region

    Private Function Numero_de_Ajuste() As Double
        Dim cConexion As New Conexion
        Dim Num_Ajuste As Double
        Num_Ajuste = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT isnull(Max(AjusteNo),0)+1 FROM ajustesccobrar"))
        cConexion.DesConectar(cConexion.sQlconexion)
        Return Num_Ajuste
    End Function

    Private Sub NuevoAjuste()
        Dim Fx As New cFunciones
        Dim Valor As Boolean
        If ToolBar1.Buttons(0).Text = "Nuevo" Then 'no hay un registro pendiente
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8
            ToolBar1.Buttons(1).Enabled = False
            ToolBar1.Buttons(3).Enabled = False

            Valor = Fx.VerificarBaseDatos("Contabilidad")
            If Valor Then
                Label10.Visible = True
                Label9.Visible = True
                txtCuentaC.Visible = True
                txtDescripcionC.Visible = True
            Else
                colCuentaC.VisibleIndex = -1
                Label10.Visible = False
                Label9.Visible = False
                txtCuentaC.Visible = False
                txtDescripcionC.Visible = False
            End If
            If txtUsuario.Text = "" Then
                txtUsuario.Enabled = True
                txtUsuario.Focus()
            End If
            txtCodigo.Text = "" : txtNombre.Text = "" : txtAbono.Text = ""
            Try
                ComboMoneda.Enabled = True
                txtNum_Ajuste.Text = Numero_de_Ajuste()

            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        Else
            Try
                If MessageBox.Show("Desea Guardar los Cambios del Ajuste", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Registrar()
                Else
                    BindingContext(AjusteCxC1, "ajustesccobrar").CancelCurrentEdit()
                    ToolBar1.Buttons(0).Text = "Nuevo"

                    AjusteCxC1.detalle_ajustesccobrar.Clear()
                    AjusteCxC1.ajustesccobrar.Clear()

                    ToolBar1.Buttons(0).ImageIndex = 0
                    ToolBar1.Buttons(1).Enabled = True

                    GroupBox6.Enabled = False
                    txtObservaciones.Enabled = False
                    txtAbono.Enabled = False

                    txtUsuario.Enabled = True
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtCedulaUsuario.Text = ""
                    txtUsuario.Focus()

                End If
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Function Registrar()
        Dim i As Integer
        Dim Funciones As New Conexion
        Dim FactTemp As Double
        Try
            If MessageBox.Show("¿Desea guardar el Ajuste?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                For i = 0 To BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count - 1
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position = i
                    If BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Saldo_Ajustado") = 0 Then
                        FactTemp = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
                        Funciones.UpdateRecords("Ventas", "FacturaCancelado = 1", "Num_Factura =" & FactTemp & "AND TIPO ='" & BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") & "'")
                    End If
                Next

                txtNum_Ajuste.Text = Numero_de_Ajuste()
                BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
                daAjuste.Update(AjusteCxC1, "ajustesccobrar")
                daDetalleAjuste.Update(AjusteCxC1, "detalle_ajustesccobrar")

                ToolBar1.Buttons(1).Enabled = True

                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                If MessageBox.Show("¿Desea imprimir este Ajuste?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Imprimir()
                End If
                txtCodigo.Enabled = False
                txtAbono.Enabled = False
                AjusteCxC1.detalle_ajustesccobrar.Clear()
                AjusteCxC1.ajustesccobrar.Clear()
                Tabla.Clear()
                txtUsuario.Text = ""
                txtUsuario.Enabled = True
                txtUsuario.Focus()
                txtNombreUsuario.Text = ""
            Else
                Exit Function
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub BuscarAjuste()
        Dim Fx As New cFunciones
        Dim identificador As Double

        Try
            If BindingContext(AjusteCxC1, "ajustesccobrar").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Ajuste de Cuenta, si continúa se perderan los datos del Ajuste actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            AjusteCxC1.detalle_ajustesccobrar.Clear()
            AjusteCxC1.ajustesccobrar.Clear()
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select ID_Ajuste, AjusteNo, Nombre_Cliente, Fecha from ajustesccobrar Order by Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Ajuste de Cuenta"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Exit Sub
            End If

            LlenarVentas(identificador)
            'si esta venta aun no ha sido anulada
            If BindingContext(AjusteCxC1, "ajustesccobrar").Current("Anula") = False Then ToolBar1.Buttons(3).Enabled = True

            GridControl2.Enabled = False
            ToolBar1.Buttons(4).Enabled = True
            ToolBar1.Buttons(0).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Function LlenarVentas(ByVal Id As Double)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion

        'Dentro de un Try/Catch por si se produce un error
        Try
            cConexion.DesConectar(cConexion.sQlconexion)
            '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM ajustesccobrar WHERE (ID_Ajuste = @Id_Factura)"
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
            dv.Fill(AjusteCxC1, "ajustesccobrar")
            '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM detalle_ajustesccobrar WHERE (Id_AjustecCobrar = @Id_Factura) "
            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            cmd.Parameters("@Id_Factura").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(AjusteCxC1.detalle_ajustesccobrar)
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
    End Function

    Function Registrar_Anulacion_Ajuste() As Boolean
        Dim i As Long
        Dim Facttem As Double
        Dim Funciones As New Conexion
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            SqlUpdateCommand1.Transaction = Trans
            daAjuste.Update(AjusteCxC1, "ajustesccobrar")
            For i = 0 To BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count - 1
                BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position = i
                Facttem = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
                Funciones.UpdateRecords("Ventas", "FacturaCancelado = 0", "Num_Factura =" & Facttem & "AND TIPO ='" & BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") & "'")
            Next
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function

    Function AnularRecibo()
        Try
            Dim resp As Integer
            If BindingContext(AjusteCxC1, "ajustesccobrar").Count > 0 Then
                If BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Anular este Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()

                        If Registrar_Anulacion_Ajuste() Then

                            AjusteCxC1.AcceptChanges()
                            MsgBox("El Ajuste ha sido anulado correctamente", MsgBoxStyle.Information)
                            AjusteCxC1.detalle_ajustesccobrar.Clear()
                            AjusteCxC1.ajustesccobrar.Clear()
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
                            txtUsuario.Focus()
                        End If

                    Else : Exit Function

                    End If
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevoAjuste()
            Case 2 : If PMU.Find Then BuscarAjuste() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then AnularRecibo() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Close()
        End Select
    End Sub
    Private Sub Imprimir()
        'PARA EL PROXIMO QUE ANDE CON ESTA VARA.. SAJ 27112007 
        'EL MODULO ANALIZA SI EXISTE  EN LA RUTA ESPECIFICADA EL REPORTE EN CUESTION, DADO EL CASO DE QUE EL REPORTE NO EXISTA CARGA EL STANDAR DEL SISTEMA

        Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        If System.IO.File.Exists(Application.StartupPath & "\Reportes\Reporte_AjusteCuenta_Personalizada.rpt") = True Then
            ReporteDocumento.Load(Application.StartupPath & "\Reportes\Reporte_AjusteCuenta_Personalizada.rpt")
        Else
            ReporteDocumento = New Reporte_AjusteCuenta
        End If
        ReporteDocumento.SetParameterValue(0, CDbl(Label_Id_Ajuste.Text))
        CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent)
    End Sub

    Private Sub ComboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboMoneda.SelectedIndexChanged
        Dim cConexion As New Conexion
        Dim Simbolo As String
        TipoCambio = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT ValorVenta FROM Moneda Where MonedaNombre = '" & ComboMoneda.Text & "'"))
        Simbolo = CStr(cConexion.SlqExecuteScalar(cConexion.Conectar, "Select Simbolo from Moneda where MonedaNombre = '" & ComboMoneda.Text & "'"))
        txtTipoCambio.Text = Format(TipoCambio, "#,#0.00")
        lbSimbolo1.Text = Simbolo : lbSimbolo2.Text = Simbolo : lbSimbolo5.Text = Simbolo
        lbSimbolo6.Text = Simbolo
        cConexion.DesConectar(cConexion.sQlconexion)
    End Sub

    Private Sub ComboMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboMoneda.Enabled = False
            GroupBox3.Enabled = True
            opNotaCredito.Focus()
        End If
    End Sub

#Region "Clientes"
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.txtCodigo.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

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
            'rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, Nombre from Clientes where Identificacion ='" & codigo & "'")
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, SUBSTRING(Nombre, 0, 40) as Nombre from Clientes where Identificacion ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs("Identificacion")
                    txtNombre.Text = rs("Nombre")
                    Tabla = funciones.BuscarFacturas(codigo)
                    gridFacturas.DataSource = Tabla
                    Saldo_Cuenta(Tabla)
                    If Tabla.Rows.Count = 0 Then
                        MessageBox.Show("El cliente no tiene facturas pendientes...", "Atención...", MessageBoxButtons.OK)
                        txtCodigo.Focus()
                        rs.Close()
                        Exit Sub
                    Else
                        txtObservaciones.Enabled = True
                        txtObservaciones.Focus()
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
        Me.txtObservaciones.Focus()
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
        For i = 0 To Tabla1.Rows.Count - 1
            fila = Tabla1.Rows(i)
            facturatemp = fila("Factura")
            Totaltemp = fila("Total")
            CodigoMoneda = fila("Cod_Moneda")
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT ValorVenta from Moneda where CodMoneda =" & CodigoMoneda)
            If rs.Read Then ValorFactura = rs("ValorVenta")
            rs.Close()
            ConexionLocal.DesConectar(ConexionLocal.Conectar)
            SaldoCuenta = SaldoCuenta + funciones.Saldo_de_Factura(facturatemp, ((Totaltemp * ValorFactura) / TipoCambio), ValorFactura, TipoCambio, fila("Tipo"), Me.txtCodigo.Text)
        Next
        ConexionLocal = Nothing
        txtSaldoAntGen.Text = Format(SaldoCuenta, "#,#0.00")
    End Function
#End Region

    Private Sub informacionfactura(ByVal factura As Double, ByVal Tipo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim Codigo As Integer
        Dim rs As SqlDataReader
        Dim Conexion2 As New Conexion

        If factura <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "Select Num_Factura, Tipo, Fecha, Vence, Cod_Moneda, Total from Ventas where cod_cliente = " & Me.txtCodigo.Text & " and (Tipo = '" & Tipo & "') and Num_Factura =" & factura & " order by Fecha")
            While rs.Read
                Try
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").CancelCurrentEdit()
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").EndCurrentEdit()
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").AddNew()
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
                Try
                    Codigo = rs("Cod_moneda")
                    TipoCambioFact = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select ValorVenta from Moneda Where CodMoneda =" & Codigo)
                    Conexion2.DesConectar(Conexion2.sQlconexion)
                    txtFactura.Text = rs("Num_Factura")
                    dtEmitida.Text = rs("Fecha")
                    txtTipo.Text = rs("Tipo")
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") = txtTipo.Text
                    txtMonto.Text = Format((rs("Total") * TipoCambioFact) / txtTipoCambio.Text, "#,#0.00")
                    txtSaldo.Text = Format(funciones.Saldo_de_Factura(factura, (rs("Total") * TipoCambioFact) / txtTipoCambio.Text, TipoCambioFact, txtTipoCambio.Text, rs("Tipo"), Me.txtCodigo.Text), "#,#0.00")
                    txtAbono.Text = Format(CDbl(txtSaldo.Text), "#,#0.00")
                    If txtTipo.Text = "CRE" Or txtTipo.Text = "TCR" Or txtTipo.Text = "MCR" Then
                        txtSaldoAct.Text = "0.00"
                    Else
                        txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtAbono.Text), "#,#0.00")
                    End If
                    txtCuentaC.Focus()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End While
            Conexion2 = Nothing
            cConexion.DesConectar(cConexion.sQlconexion)
            cConexion = Nothing
        End If
    End Sub

    Private Sub gridFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridFacturas.Click
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
        BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
        informacionfactura(factura, data("Tipo"))
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        'txtCodigo.SelectAll()
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

    Private Sub txtAbono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbono.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                Dim Factura As Long = txtFactura.Text
                Dim TipoOriginal As String = Me.txtTipo.Text

                If txtCuentaC.Text = "" Then
                    MessageBox.Show("Debe seleccionar una cuenta contable", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    txtCuentaC.Focus()
                    Exit Sub
                End If

                If txtAbono.Text = "" Then txtAbono.Text = 0
                If txtAbono.Text = 0 Then
                    MessageBox.Show("Debe de digitar un monto mayor que 0", "Atención...", MessageBoxButtons.OK)
                    txtAbono.Text = 0.0 : txtAbono.Focus() : txtAbono.SelectAll() : Exit Sub
                End If
                If CDbl(txtAbono.Text) > CDbl(txtSaldo.Text) And opNotaCredito.Checked = True Then
                    MessageBox.Show("No puede abonarle más de lo que adeuda, Favor revisar...", "Atención...", MessageBoxButtons.OK)
                    txtAbono.Text = 0.0 : txtAbono.Focus() : txtAbono.SelectAll() : Exit Sub
                Else
                    txtAbono.Text = CDbl(txtAbono.Text)
                    txtAbonoSuMoneda.Text = (CDbl(txtAbono.Text) / TipoCambioFact) * CDbl(txtTipoCambio.Text)

                    If opNotaDebito.Checked = True Then
                        txtTipo.Text = "DEB"
                        txtTipoD.Text = "DEB"
                    Else
                        txtTipo.Text = "CRE"
                        txtTipoD.Text = "CRE"
                    End If

                    If txtTipo.Text = "CRE" Or txtTipo.Text = "TCR" Or txtTipo.Text = "MCR" Then
                        txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) - CDbl(txtAbono.Text), "#,#0.00")
                    Else
                        txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtAbono.Text), "#,#0.00")
                    End If

                    'daba error cuando ejecutaba esta linea, por eso se quito (si no sirve que no estorbe)
                    If TipoOriginal = "CRE" Then
                        'cuando es seepos lo necesita
                        BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
                    ElseIf TipoOriginal = "MCR" Then
                        'cuando es mascotas no lo nesecita
                        'de hecho se cae si lo tiene por eso lo quito.
                    ElseIf TipoOriginal = "TCR" Then
                        'falta probar con taller 
                        'no tengo tiempo para hacero, favor probarlo luego.
                    End If


                    If opNotaDebito.Checked = True Then
                        txtTipoD.Text = "DEB"
                    Else
                        txtTipoD.Text = "CRE"
                    End If

                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").EndCurrentEdit()

                    txtAbonoGen.Text = Format(colAbono.SummaryItem.SummaryValue, "#,#0.00")
                    If txtTipo.Text = "CRE" Or txtTipo.Text = "TCR" Or txtTipo.Text = "MCR" Then
                        txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")
                    Else
                        txtSaldoActGen.Text = Format(CDbl(txtSaldoAntGen.Text) + CDbl(txtAbonoGen.Text), "#,#0.00")
                    End If

                    'BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
                    'Tabla.Rows.RemoveAt(AdvBandedGridView1.FocusedRowHandle)
                    Tabla.Rows.Remove((From x As DataRow In Tabla.Rows Where x.Item("Factura") = Factura Select x).FirstOrDefault)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtAbono.Text = 0
            txtAbono.Focus()
        End Try

    End Sub

    Private Sub txtAbono_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbono.GotFocus
        txtAbono.SelectAll()
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
            Eliminar_Factura_Detalle()
        End If
    End Sub

    Private Sub Eliminar_Factura_Detalle()
        Dim resp As Integer
        Dim FilaTabla As DataRow
        Dim Conexion2 As New Conexion
        Dim Facturatem As Double
        Dim Fechatem As Date

        Try 'se intenta hacer
            If BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count > 0 Then   ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar esta factura del Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    FilaTabla = Tabla.NewRow
                    FilaTabla("Factura") = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
                    Facturatem = FilaTabla("factura")
                    Fechatem = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select Fecha from Ventas Where Num_Factura =" & Facturatem)
                    Conexion2.DesConectar(Conexion2.sQlconexion)
                    FilaTabla("Fecha") = Fechatem
                    Tabla.Rows.Add(FilaTabla)

                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").RemoveAt(BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position)
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").EndCurrentEdit()
                    txtAbonoGen.Text = Format(colAbono.SummaryItem.SummaryValue, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")

                    BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()

                Else
                    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Facturas para eliminar del Recibo de Dinero", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Private Sub txtAbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbono.TextChanged

    End Sub

    Private Sub txtAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbono.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub opNotaCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opNotaCredito.CheckedChanged
        If opNotaCredito.Checked = True Then
            txtTipo.Text = "CRE"
            txtTipoD.Text = "CRE"
        Else
            txtTipo.Text = "DEB"
            txtTipoD.Text = "DEB"
        End If
    End Sub

    Private Sub opNotaDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opNotaDebito.CheckedChanged
        If opNotaDebito.Checked = True Then
            txtTipo.Text = "DEB"
            txtTipoD.Text = "DEB"
        Else
            txtTipo.Text = "CRE"
            txtTipoD.Text = "CRE"
        End If
    End Sub

    Private Sub opNotaCredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opNotaCredito.KeyDown
        If e.KeyData = Keys.Enter Then
            GroupBox6.Enabled = True
            GroupBox3.Enabled = False
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        End If
    End Sub

    Private Sub opNotaDebito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opNotaDebito.KeyDown
        If e.KeyData = Keys.Enter Then
            GroupBox6.Enabled = True
            GroupBox3.Enabled = False
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        End If
    End Sub


    Private Sub txtCuentaC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaC.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cconex As New SqlClient.SqlConnection
            cconex = CConexion.Conectar("Contabilidad")
            Dim frmBuscar As New Buscar
            frmBuscar.sqlstring = "select Id, CuentaContable from CuentaContable where Movimiento=1"
            frmBuscar.Text = "CuentaContable"
            frmBuscar.campo = "CuentaContable"
            frmBuscar.NuevaConexion = cconex.ConnectionString
            frmBuscar.ShowDialog()
            If frmBuscar.descrip <> "" Then
                txtCuentaC.Text = frmBuscar.descrip
                txtDescripcionC.Text = CConexion.SlqExecuteScalar(cconex, "Select descripcion from CuentaContable where Id=" & frmBuscar.codigo)
                BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("CuentaContable") = frmBuscar.descrip
                BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("IdCuentaC") = frmBuscar.codigo
            Else
                MessageBox.Show("No seleccionó ninguna cuenta contable", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                txtCuentaC.Focus()
            End If
            CConexion.DesConectar(cconex)
        End If
        If e.KeyCode = Keys.Enter Then
            txtAbono.Focus()
        End If
    End Sub

    Private Sub txtCuentaC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaC.TextChanged

    End Sub
End Class
