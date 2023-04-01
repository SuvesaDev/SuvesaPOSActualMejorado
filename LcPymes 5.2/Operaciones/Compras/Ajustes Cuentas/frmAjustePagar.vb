Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms
'Revisar : Falta poner el id del proveedor en el detalle para que trabaje bien los reportes de CXP
Public Class frmAjustePagar
    Inherits System.Windows.Forms.Form

    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim Anular As Boolean = False
    Dim TipoCambioFact As Double 'Tipo Cambio de la Factura
    Dim TipoCambio As Double
    Dim Tabla As DataTable
    Dim buscando As Boolean
    Dim descripcion As String
    Dim usua As Usuario_Logeado
    Dim NuevaConexion As String
    Dim strModulos As String = ""

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro
        NuevaConexion = Conexion

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAntGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents opNotaDebito As System.Windows.Forms.RadioButton
    Friend WithEvents opNotaCredito As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbSimbolo6 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo5 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo2 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbono As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtNum_Ajuste As System.Windows.Forms.Label
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSaldo_Ant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents txtTipoD As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolBarAnular As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsAjustePagar As DsAjustePagar
    Friend WithEvents daAjustecPagar As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daDetallecPagar As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents gridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Factura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblNajuste As System.Windows.Forms.Label
    Friend WithEvents Label_Anulado As System.Windows.Forms.Label
    Friend WithEvents Label_ID_FacturaCompra As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtDocProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6_Old As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3_oLD As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCuentaC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionC As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAjustePagar))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DsAjustePagar = New LcPymes_5._2.dsAjustePagar
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSaldoActGen = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAbonoGen = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSaldoAntGen = New DevExpress.XtraEditors.TextEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox6_Old = New System.Windows.Forms.GroupBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox3_oLD = New System.Windows.Forms.GroupBox
        Me.opNotaDebito = New System.Windows.Forms.RadioButton
        Me.opNotaCredito = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label9 = New System.Windows.Forms.Label
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescripcionC = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCuentaC = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbSimbolo6 = New System.Windows.Forms.Label
        Me.lbSimbolo5 = New System.Windows.Forms.Label
        Me.lbSimbolo2 = New System.Windows.Forms.Label
        Me.lbSimbolo1 = New System.Windows.Forms.Label
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit
        Me.txtSaldo = New DevExpress.XtraEditors.TextEdit
        Me.txtSaldoAct = New DevExpress.XtraEditors.TextEdit
        Me.txtAbono = New DevExpress.XtraEditors.TextEdit
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
        Me.Label_ID_FacturaCompra = New System.Windows.Forms.Label
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.txtNum_Ajuste = New System.Windows.Forms.Label
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSaldo_Ant = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAbono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtTipoCambio = New System.Windows.Forms.Label
        Me.txtTipoD = New System.Windows.Forms.Label
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolBarAnular = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ComboMoneda = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.daAjustecPagar = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daDetallecPagar = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.gridFacturas = New DevExpress.XtraGrid.GridControl
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Factura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.lblNajuste = New System.Windows.Forms.Label
        Me.Label_Anulado = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtDocProveedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.Label
        CType(Me.DsAjustePagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtSaldoActGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAntGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjustePagar, "Ajustescpagar.Anula"))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(520, 336)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 208
        Me.CheckBox1.Text = "Anulada"
        '
        'DsAjustePagar
        '
        Me.DsAjustePagar.DataSetName = "dsAjustePagar"
        Me.DsAjustePagar.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtSaldoActGen)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtAbonoGen)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtSaldoAntGen)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(344, 385)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 56)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(328, 16)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Saldos de la Cuenta"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoActGen
        '
        Me.txtSaldoActGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.Saldo_Act"))
        Me.txtSaldoActGen.EditValue = "0.00"
        Me.txtSaldoActGen.Location = New System.Drawing.Point(235, 32)
        Me.txtSaldoActGen.Name = "txtSaldoActGen"
        '
        'txtSaldoActGen.Properties
        '
        Me.txtSaldoActGen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldoActGen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoActGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoActGen.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSaldoActGen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoActGen.Properties.ReadOnly = True
        Me.txtSaldoActGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.Blue)
        Me.txtSaldoActGen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoActGen.Size = New System.Drawing.Size(101, 19)
        Me.txtSaldoActGen.TabIndex = 162
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(235, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 12)
        Me.Label18.TabIndex = 161
        Me.Label18.Text = "Saldo Act."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtAbonoGen
        '
        Me.txtAbonoGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.Monto"))
        Me.txtAbonoGen.EditValue = "0.00"
        Me.txtAbonoGen.Location = New System.Drawing.Point(120, 32)
        Me.txtAbonoGen.Name = "txtAbonoGen"
        '
        'txtAbonoGen.Properties
        '
        Me.txtAbonoGen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAbonoGen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtAbonoGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbonoGen.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtAbonoGen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbonoGen.Properties.ReadOnly = True
        Me.txtAbonoGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.Blue)
        Me.txtAbonoGen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAbonoGen.Size = New System.Drawing.Size(107, 19)
        Me.txtAbonoGen.TabIndex = 160
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(120, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 12)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Monto Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSaldoAntGen
        '
        Me.txtSaldoAntGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.Saldo_Prev"))
        Me.txtSaldoAntGen.EditValue = "0.00"
        Me.txtSaldoAntGen.Location = New System.Drawing.Point(8, 32)
        Me.txtSaldoAntGen.Name = "txtSaldoAntGen"
        '
        'txtSaldoAntGen.Properties
        '
        Me.txtSaldoAntGen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldoAntGen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoAntGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAntGen.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSaldoAntGen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAntGen.Properties.ReadOnly = True
        Me.txtSaldoAntGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.Blue)
        Me.txtSaldoAntGen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoAntGen.Size = New System.Drawing.Size(96, 19)
        Me.txtSaldoAntGen.TabIndex = 158
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(8, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Saldo Ant."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO detalle_ajustesccobrar(Id_AjustecCobrar, Factura, Tipo, Monto, Saldo_" & _
        "Ant, Ajuste, Ajuste_SuMoneda, Saldo_Ajustado, Observaciones, TipoNota) VALUES (@" & _
        "Id_AjustecCobrar, @Factura, @Tipo, @Monto, @Saldo_Ant, @Ajuste, @Ajuste_SuMoneda" & _
        ", @Saldo_Ajustado, @Observaciones, @TipoNota); SELECT Id_DetalleAjustecCobrar, I" & _
        "d_AjustecCobrar, Factura, Tipo, Monto, Saldo_Ant, Ajuste, Ajuste_SuMoneda, Saldo" & _
        "_Ajustado, Observaciones, TipoNota FROM detalle_ajustesccobrar WHERE (Id_Detalle" & _
        "AjustecCobrar = @@IDENTITY)"
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, "Id_AjustecCobrar"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste", System.Data.SqlDbType.Float, 8, "Ajuste"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, "Ajuste_SuMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ajustado", System.Data.SqlDbType.Float, 8, "Saldo_Ajustado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoNota", System.Data.SqlDbType.VarChar, 3, "TipoNota"))
        '
        'GroupBox6_Old
        '
        Me.GroupBox6_Old.Enabled = False
        Me.GroupBox6_Old.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6_Old.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox6_Old.Location = New System.Drawing.Point(40, 344)
        Me.GroupBox6_Old.Name = "GroupBox6_Old"
        Me.GroupBox6_Old.Size = New System.Drawing.Size(56, 24)
        Me.GroupBox6_Old.TabIndex = 195
        Me.GroupBox6_Old.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.Cod_Proveedor"))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(7, 52)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodigo.TabIndex = 158
        Me.txtCodigo.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(79, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(392, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Proveedor"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.Nombre_Proveedor"))
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(79, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(392, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'GroupBox3_oLD
        '
        Me.GroupBox3_oLD.Enabled = False
        Me.GroupBox3_oLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3_oLD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3_oLD.Location = New System.Drawing.Point(40, 312)
        Me.GroupBox3_oLD.Name = "GroupBox3_oLD"
        Me.GroupBox3_oLD.Size = New System.Drawing.Size(56, 32)
        Me.GroupBox3_oLD.TabIndex = 209
        Me.GroupBox3_oLD.TabStop = False
        '
        'opNotaDebito
        '
        Me.opNotaDebito.BackColor = System.Drawing.SystemColors.Control
        Me.opNotaDebito.Enabled = False
        Me.opNotaDebito.Location = New System.Drawing.Point(73, 16)
        Me.opNotaDebito.Name = "opNotaDebito"
        Me.opNotaDebito.Size = New System.Drawing.Size(56, 15)
        Me.opNotaDebito.TabIndex = 159
        Me.opNotaDebito.Text = "Débito"
        '
        'opNotaCredito
        '
        Me.opNotaCredito.BackColor = System.Drawing.SystemColors.Control
        Me.opNotaCredito.Enabled = False
        Me.opNotaCredito.Location = New System.Drawing.Point(0, 16)
        Me.opNotaCredito.Name = "opNotaCredito"
        Me.opNotaCredito.Size = New System.Drawing.Size(64, 15)
        Me.opNotaCredito.TabIndex = 158
        Me.opNotaCredito.Text = "Crédito"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 15)
        Me.Label19.TabIndex = 157
        Me.Label19.Text = "Tipo de Nota"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM detalle_ajustesccobrar WHERE (Id_DetalleAjustecCobrar = @Original_Id_" & _
        "DetalleAjustecCobrar) AND (Ajuste = @Original_Ajuste) AND (Ajuste_SuMoneda = @Or" & _
        "iginal_Ajuste_SuMoneda) AND (Factura = @Original_Factura) AND (Id_AjustecCobrar " & _
        "= @Original_Id_AjustecCobrar) AND (Monto = @Original_Monto) AND (Observaciones =" & _
        " @Original_Observaciones) AND (Saldo_Ajustado = @Original_Saldo_Ajustado) AND (S" & _
        "aldo_Ant = @Original_Saldo_Ant) AND (Tipo = @Original_Tipo) AND (TipoNota = @Ori" & _
        "ginal_TipoNota)"
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleAjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleAjustecCobrar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste_SuMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjustecCobrar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ajustado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ajustado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoNota", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoNota", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID_Ajuste, AjusteNo, Tipo, Cod_Cliente, Fecha, Saldo_Prev, Monto, Saldo_Ac" & _
        "t, Observaciones, Anula, Cod_Usuario, Contabilizado, Cod_Moneda, Asiento, Nombre" & _
        "_Cliente FROM ajustesccobrar"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(688, 32)
        Me.Label9.TabIndex = 191
        Me.Label9.Text = "Notas de Crédito y Débito"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM ajustesccobrar WHERE (ID_Ajuste = @Original_ID_Ajuste) AND (AjusteNo " & _
        "= @Original_AjusteNo) AND (Anula = @Original_Anula) AND (Asiento = @Original_Asi" & _
        "ento) AND (Cod_Cliente = @Original_Cod_Cliente) AND (Cod_Moneda = @Original_Cod_" & _
        "Moneda) AND (Cod_Usuario = @Original_Cod_Usuario) AND (Contabilizado = @Original" & _
        "_Contabilizado) AND (Fecha = @Original_Fecha) AND (Monto = @Original_Monto) AND " & _
        "(Nombre_Cliente = @Original_Nombre_Cliente) AND (Observaciones = @Original_Obser" & _
        "vaciones) AND (Saldo_Act = @Original_Saldo_Act) AND (Saldo_Prev = @Original_Sald" & _
        "o_Prev) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AjusteNo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AjusteNo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Act", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Prev", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Prev", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO ajustesccobrar(AjusteNo, Tipo, Cod_Cliente, Fecha, Saldo_Prev, Monto," & _
        " Saldo_Act, Observaciones, Anula, Cod_Usuario, Contabilizado, Cod_Moneda, Asient" & _
        "o, Nombre_Cliente) VALUES (@AjusteNo, @Tipo, @Cod_Cliente, @Fecha, @Saldo_Prev, " & _
        "@Monto, @Saldo_Act, @Observaciones, @Anula, @Cod_Usuario, @Contabilizado, @Cod_M" & _
        "oneda, @Asiento, @Nombre_Cliente); SELECT ID_Ajuste, AjusteNo, Tipo, Cod_Cliente" & _
        ", Fecha, Saldo_Prev, Monto, Saldo_Act, Observaciones, Anula, Cod_Usuario, Contab" & _
        "ilizado, Cod_Moneda, Asiento, Nombre_Cliente FROM ajustesccobrar WHERE (ID_Ajust" & _
        "e = @@IDENTITY)"
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AjusteNo", System.Data.SqlDbType.BigInt, 8, "AjusteNo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Prev", System.Data.SqlDbType.Float, 8, "Saldo_Prev"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Act", System.Data.SqlDbType.Float, 8, "Saldo_Act"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Usuario", System.Data.SqlDbType.VarChar, 75, "Cod_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, "Nombre_Cliente"))
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionC)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCuentaC)
        Me.GroupBox1.Controls.Add(Me.Label8)
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
        Me.GroupBox1.Controls.Add(Me.Label_ID_FacturaCompra)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(210, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 104)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcionC
        '
        Me.txtDescripcionC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.DescripcionCuentaContable"))
        Me.txtDescripcionC.Location = New System.Drawing.Point(320, 88)
        Me.txtDescripcionC.Name = "txtDescripcionC"
        Me.txtDescripcionC.ReadOnly = True
        Me.txtDescripcionC.Size = New System.Drawing.Size(144, 13)
        Me.txtDescripcionC.TabIndex = 219
        Me.txtDescripcionC.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(248, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "Descripción"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuentaC
        '
        Me.txtCuentaC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.CuentaContable"))
        Me.txtCuentaC.Location = New System.Drawing.Point(88, 88)
        Me.txtCuentaC.Name = "txtCuentaC"
        Me.txtCuentaC.Size = New System.Drawing.Size(144, 13)
        Me.txtCuentaC.TabIndex = 217
        Me.txtCuentaC.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 216
        Me.Label8.Text = "Cuenta Cont."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSimbolo6
        '
        Me.lbSimbolo6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbSimbolo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo6.Location = New System.Drawing.Point(331, 64)
        Me.lbSimbolo6.Name = "lbSimbolo6"
        Me.lbSimbolo6.Size = New System.Drawing.Size(20, 15)
        Me.lbSimbolo6.TabIndex = 180
        Me.lbSimbolo6.Text = "¢"
        Me.lbSimbolo6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo5
        '
        Me.lbSimbolo5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbSimbolo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo5.Location = New System.Drawing.Point(331, 40)
        Me.lbSimbolo5.Name = "lbSimbolo5"
        Me.lbSimbolo5.Size = New System.Drawing.Size(20, 15)
        Me.lbSimbolo5.TabIndex = 179
        Me.lbSimbolo5.Text = "¢"
        Me.lbSimbolo5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo2
        '
        Me.lbSimbolo2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbSimbolo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo2.Location = New System.Drawing.Point(329, 18)
        Me.lbSimbolo2.Name = "lbSimbolo2"
        Me.lbSimbolo2.Size = New System.Drawing.Size(20, 15)
        Me.lbSimbolo2.TabIndex = 177
        Me.lbSimbolo2.Text = "¢"
        Me.lbSimbolo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSimbolo1
        '
        Me.lbSimbolo1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbSimbolo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Moneda.Simbolo"))
        Me.lbSimbolo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbSimbolo1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSimbolo1.Location = New System.Drawing.Point(66, 65)
        Me.lbSimbolo1.Name = "lbSimbolo1"
        Me.lbSimbolo1.Size = New System.Drawing.Size(20, 16)
        Me.lbSimbolo1.TabIndex = 176
        Me.lbSimbolo1.Text = "¢"
        Me.lbSimbolo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMonto
        '
        Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.Monto"))
        Me.txtMonto.EditValue = ""
        Me.txtMonto.Location = New System.Drawing.Point(88, 65)
        Me.txtMonto.Name = "txtMonto"
        '
        'txtMonto.Properties
        '
        Me.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtMonto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.ReadOnly = True
        Me.txtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMonto.Size = New System.Drawing.Size(144, 17)
        Me.txtMonto.TabIndex = 174
        '
        'txtSaldo
        '
        Me.txtSaldo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.Saldo_Ant"))
        Me.txtSaldo.EditValue = "0.00"
        Me.txtSaldo.Location = New System.Drawing.Point(359, 18)
        Me.txtSaldo.Name = "txtSaldo"
        '
        'txtSaldo.Properties
        '
        Me.txtSaldo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldo.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSaldo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldo.Properties.ReadOnly = True
        Me.txtSaldo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldo.Size = New System.Drawing.Size(104, 17)
        Me.txtSaldo.TabIndex = 172
        '
        'txtSaldoAct
        '
        Me.txtSaldoAct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.Saldo_Ajustado"))
        Me.txtSaldoAct.EditValue = ""
        Me.txtSaldoAct.Location = New System.Drawing.Point(359, 64)
        Me.txtSaldoAct.Name = "txtSaldoAct"
        '
        'txtSaldoAct.Properties
        '
        Me.txtSaldoAct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSaldoAct.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoAct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAct.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSaldoAct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAct.Properties.ReadOnly = True
        Me.txtSaldoAct.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoAct.Size = New System.Drawing.Size(104, 17)
        Me.txtSaldoAct.TabIndex = 5
        '
        'txtAbono
        '
        Me.txtAbono.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.Ajuste"))
        Me.txtAbono.EditValue = ""
        Me.txtAbono.Location = New System.Drawing.Point(359, 40)
        Me.txtAbono.Name = "txtAbono"
        '
        'txtAbono.Properties
        '
        Me.txtAbono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAbono.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtAbono.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbono.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtAbono.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbono.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbono.Size = New System.Drawing.Size(104, 17)
        Me.txtAbono.TabIndex = 4
        '
        'dtEmitida
        '
        Me.dtEmitida.Checked = False
        Me.dtEmitida.CustomFormat = "dd/MMMM/yyyy"
        Me.dtEmitida.Enabled = False
        Me.dtEmitida.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtEmitida.Location = New System.Drawing.Point(90, 40)
        Me.dtEmitida.Name = "dtEmitida"
        Me.dtEmitida.Size = New System.Drawing.Size(142, 20)
        Me.dtEmitida.TabIndex = 1
        Me.dtEmitida.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'txtFactura
        '
        Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.Factura"))
        Me.txtFactura.Enabled = False
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.ForeColor = System.Drawing.Color.Blue
        Me.txtFactura.Location = New System.Drawing.Point(90, 18)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(142, 16)
        Me.txtFactura.TabIndex = 0
        Me.txtFactura.Text = ""
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(8, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Monto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(247, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 15)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Saldo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(247, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 15)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Saldo Actual"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(247, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 15)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Ajuste"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 14)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Fecha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, -4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 19)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Datos de la Factura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(8, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Factura No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbonoSuMoneda
        '
        Me.txtAbonoSuMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbonoSuMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbonoSuMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.Ajuste_SuMoneda"))
        Me.txtAbonoSuMoneda.Enabled = False
        Me.txtAbonoSuMoneda.ForeColor = System.Drawing.Color.Blue
        Me.txtAbonoSuMoneda.Location = New System.Drawing.Point(288, 0)
        Me.txtAbonoSuMoneda.Name = "txtAbonoSuMoneda"
        Me.txtAbonoSuMoneda.Size = New System.Drawing.Size(80, 13)
        Me.txtAbonoSuMoneda.TabIndex = 183
        Me.txtAbonoSuMoneda.Text = ""
        Me.txtAbonoSuMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_ID_FacturaCompra
        '
        Me.Label_ID_FacturaCompra.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label_ID_FacturaCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.ID_Compra"))
        Me.Label_ID_FacturaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_ID_FacturaCompra.ForeColor = System.Drawing.Color.White
        Me.Label_ID_FacturaCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_ID_FacturaCompra.Location = New System.Drawing.Point(288, 1)
        Me.Label_ID_FacturaCompra.Name = "Label_ID_FacturaCompra"
        Me.Label_ID_FacturaCompra.Size = New System.Drawing.Size(91, 12)
        Me.Label_ID_FacturaCompra.TabIndex = 215
        Me.Label_ID_FacturaCompra.Text = "0"
        Me.Label_ID_FacturaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE detalle_ajustesccobrar SET Id_AjustecCobrar = @Id_AjustecCobrar, Factura =" & _
        " @Factura, Tipo = @Tipo, Monto = @Monto, Saldo_Ant = @Saldo_Ant, Ajuste = @Ajust" & _
        "e, Ajuste_SuMoneda = @Ajuste_SuMoneda, Saldo_Ajustado = @Saldo_Ajustado, Observa" & _
        "ciones = @Observaciones, TipoNota = @TipoNota WHERE (Id_DetalleAjustecCobrar = @" & _
        "Original_Id_DetalleAjustecCobrar) AND (Ajuste = @Original_Ajuste) AND (Ajuste_Su" & _
        "Moneda = @Original_Ajuste_SuMoneda) AND (Factura = @Original_Factura) AND (Id_Aj" & _
        "ustecCobrar = @Original_Id_AjustecCobrar) AND (Monto = @Original_Monto) AND (Obs" & _
        "ervaciones = @Original_Observaciones) AND (Saldo_Ajustado = @Original_Saldo_Ajus" & _
        "tado) AND (Saldo_Ant = @Original_Saldo_Ant) AND (Tipo = @Original_Tipo) AND (Tip" & _
        "oNota = @Original_TipoNota); SELECT Id_DetalleAjustecCobrar, Id_AjustecCobrar, F" & _
        "actura, Tipo, Monto, Saldo_Ant, Ajuste, Ajuste_SuMoneda, Saldo_Ajustado, Observa" & _
        "ciones, TipoNota FROM detalle_ajustesccobrar WHERE (Id_DetalleAjustecCobrar = @I" & _
        "d_DetalleAjustecCobrar)"
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, "Id_AjustecCobrar"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste", System.Data.SqlDbType.Float, 8, "Ajuste"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, "Ajuste_SuMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ajustado", System.Data.SqlDbType.Float, 8, "Saldo_Ajustado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoNota", System.Data.SqlDbType.VarChar, 3, "TipoNota"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleAjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleAjustecCobrar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste_SuMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AjustecCobrar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjustecCobrar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ajustado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ajustado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoNota", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoNota", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_DetalleAjustecCobrar", System.Data.SqlDbType.BigInt, 8, "Id_DetalleAjustecCobrar"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE ajustesccobrar SET AjusteNo = @AjusteNo, Tipo = @Tipo, Cod_Cliente = @Cod_" & _
        "Cliente, Fecha = @Fecha, Saldo_Prev = @Saldo_Prev, Monto = @Monto, Saldo_Act = @" & _
        "Saldo_Act, Observaciones = @Observaciones, Anula = @Anula, Cod_Usuario = @Cod_Us" & _
        "uario, Contabilizado = @Contabilizado, Cod_Moneda = @Cod_Moneda, Asiento = @Asie" & _
        "nto, Nombre_Cliente = @Nombre_Cliente WHERE (ID_Ajuste = @Original_ID_Ajuste) AN" & _
        "D (AjusteNo = @Original_AjusteNo) AND (Anula = @Original_Anula) AND (Asiento = @" & _
        "Original_Asiento) AND (Cod_Cliente = @Original_Cod_Cliente) AND (Cod_Moneda = @O" & _
        "riginal_Cod_Moneda) AND (Cod_Usuario = @Original_Cod_Usuario) AND (Contabilizado" & _
        " = @Original_Contabilizado) AND (Fecha = @Original_Fecha) AND (Monto = @Original" & _
        "_Monto) AND (Nombre_Cliente = @Original_Nombre_Cliente) AND (Observaciones = @Or" & _
        "iginal_Observaciones) AND (Saldo_Act = @Original_Saldo_Act) AND (Saldo_Prev = @O" & _
        "riginal_Saldo_Prev) AND (Tipo = @Original_Tipo); SELECT ID_Ajuste, AjusteNo, Tip" & _
        "o, Cod_Cliente, Fecha, Saldo_Prev, Monto, Saldo_Act, Observaciones, Anula, Cod_U" & _
        "suario, Contabilizado, Cod_Moneda, Asiento, Nombre_Cliente FROM ajustesccobrar W" & _
        "HERE (ID_Ajuste = @ID_Ajuste)"
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AjusteNo", System.Data.SqlDbType.BigInt, 8, "AjusteNo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Prev", System.Data.SqlDbType.Float, 8, "Saldo_Prev"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Act", System.Data.SqlDbType.Float, 8, "Saldo_Act"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Usuario", System.Data.SqlDbType.VarChar, 75, "Cod_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, "Nombre_Cliente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AjusteNo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AjusteNo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Act", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Prev", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Prev", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Ajuste", System.Data.SqlDbType.BigInt, 8, "ID_Ajuste"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'txtNum_Ajuste
        '
        Me.txtNum_Ajuste.BackColor = System.Drawing.Color.White
        Me.txtNum_Ajuste.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.ID_Ajuste"))
        Me.txtNum_Ajuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNum_Ajuste.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNum_Ajuste.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNum_Ajuste.Location = New System.Drawing.Point(59, 17)
        Me.txtNum_Ajuste.Name = "txtNum_Ajuste"
        Me.txtNum_Ajuste.Size = New System.Drawing.Size(57, 12)
        Me.txtNum_Ajuste.TabIndex = 193
        Me.txtNum_Ajuste.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'colFactura
        '
        Me.colFactura.Caption = "Factura"
        Me.colFactura.FieldName = "Factura"
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFactura.VisibleIndex = 0
        Me.colFactura.Width = 88
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto Fact."
        Me.colMonto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 1
        Me.colMonto.Width = 114
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactura, Me.colMonto, Me.colSaldo_Ant, Me.colAbono, Me.colSaldo, Me.GridColumn1, Me.colCuenta})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSaldo_Ant
        '
        Me.colSaldo_Ant.Caption = "Saldo Ant."
        Me.colSaldo_Ant.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo_Ant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo_Ant.FieldName = "Saldo_Ant"
        Me.colSaldo_Ant.Name = "colSaldo_Ant"
        Me.colSaldo_Ant.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo_Ant.VisibleIndex = 2
        Me.colSaldo_Ant.Width = 114
        '
        'colAbono
        '
        Me.colAbono.Caption = "Ajuste"
        Me.colAbono.DisplayFormat.FormatString = "#,#0.00"
        Me.colAbono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAbono.FieldName = "Ajuste"
        Me.colAbono.Name = "colAbono"
        Me.colAbono.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colAbono.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colAbono.VisibleIndex = 3
        Me.colAbono.Width = 92
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo Act."
        Me.colSaldo.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo_Ajustado"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 130
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 5
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta Contable"
        Me.colCuenta.FieldName = "CuentaContable"
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.VisibleIndex = 6
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.DataMember = "Ajustescpagar.AjustescpagarDetalle_AjustescPagar"
        Me.GridControl2.DataSource = Me.DsAjustePagar
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(210, 224)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(472, 160)
        Me.GridControl2.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl2.TabIndex = 200
        Me.GridControl2.Text = "GridControl2"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_DetalleAjustecCobrar, Id_AjustecCobrar, Factura, Tipo, Monto, Saldo_Ant" & _
        ", Ajuste, Ajuste_SuMoneda, Saldo_Ajustado, Observaciones, TipoNota FROM detalle_" & _
        "ajustesccobrar"
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(263, 78)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 15)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Observaciones:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Moneda.ValorCompra"))
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(73, 449)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(96, 12)
        Me.txtTipoCambio.TabIndex = 206
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTipoD
        '
        Me.txtTipoD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTipoD.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar.TipoNota"))
        Me.txtTipoD.Enabled = False
        Me.txtTipoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoD.Location = New System.Drawing.Point(243, 449)
        Me.txtTipoD.Name = "txtTipoD"
        Me.txtTipoD.Size = New System.Drawing.Size(94, 12)
        Me.txtTipoD.TabIndex = 211
        Me.txtTipoD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.Checked = False
        Me.dtFecha.CustomFormat = "dd/MMMM/yyyy"
        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.Fecha"))
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFecha.Location = New System.Drawing.Point(591, 52)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtFecha.TabIndex = 197
        Me.dtFecha.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(591, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBarAnular
        '
        Me.ToolBarAnular.ImageIndex = 3
        Me.ToolBarAnular.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.AutoSize = False
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.Observaciones"))
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtObservaciones.Location = New System.Drawing.Point(362, 77)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(317, 30)
        Me.txtObservaciones.TabIndex = 198
        Me.txtObservaciones.Text = ""
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ComboMoneda
        '
        Me.ComboMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsAjustePagar, "Ajustescpagar.Cod_Moneda"))
        Me.ComboMoneda.DataSource = Me.DsAjustePagar
        Me.ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.Enabled = False
        Me.ComboMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboMoneda.Location = New System.Drawing.Point(487, 52)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(97, 21)
        Me.ComboMoneda.TabIndex = 196
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(487, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 15)
        Me.Label30.TabIndex = 203
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel1.Location = New System.Drawing.Point(344, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 12)
        Me.Panel1.TabIndex = 194
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
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(123, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(197, 13)
        Me.txtNombreUsuario.TabIndex = 2
        Me.txtNombreUsuario.Text = ""
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.Cod_Usuario"))
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(288, 0)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 170
        Me.txtCedulaUsuario.Text = ""
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarAnular, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 388)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(702, 58)
        Me.ToolBar1.TabIndex = 201
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=SeePos"
        '
        'daMoneda
        '
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand4
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monedas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Monedas"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'daAjustecPagar
        '
        Me.daAjustecPagar.DeleteCommand = Me.SqlDeleteCommand5
        Me.daAjustecPagar.InsertCommand = Me.SqlInsertCommand5
        Me.daAjustecPagar.SelectCommand = Me.SqlSelectCommand5
        Me.daAjustecPagar.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ajustescpagar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Ajuste", "ID_Ajuste"), New System.Data.Common.DataColumnMapping("AjusteNo", "AjusteNo"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Proveedor", "Cod_Proveedor"), New System.Data.Common.DataColumnMapping("Nombre_Proveedor", "Nombre_Proveedor"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Saldo_Prev", "Saldo_Prev"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Act", "Saldo_Act"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Cod_Usuario", "Cod_Usuario"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada")})})
        Me.daAjustecPagar.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Ajustescpagar WHERE (ID_Ajuste = @Original_ID_Ajuste) AND (AjusteNo =" & _
        " @Original_AjusteNo OR @Original_AjusteNo IS NULL AND AjusteNo IS NULL) AND (Anu" & _
        "la = @Original_Anula OR @Original_Anula IS NULL AND Anula IS NULL) AND (Asiento " & _
        "= @Original_Asiento OR @Original_Asiento IS NULL AND Asiento IS NULL) AND (Cod_M" & _
        "oneda = @Original_Cod_Moneda OR @Original_Cod_Moneda IS NULL AND Cod_Moneda IS N" & _
        "ULL) AND (Cod_Proveedor = @Original_Cod_Proveedor OR @Original_Cod_Proveedor IS " & _
        "NULL AND Cod_Proveedor IS NULL) AND (Cod_Usuario = @Original_Cod_Usuario OR @Ori" & _
        "ginal_Cod_Usuario IS NULL AND Cod_Usuario IS NULL) AND (Contabilizado = @Origina" & _
        "l_Contabilizado OR @Original_Contabilizado IS NULL AND Contabilizado IS NULL) AN" & _
        "D (Fecha = @Original_Fecha OR @Original_Fecha IS NULL AND Fecha IS NULL) AND (Fe" & _
        "chaEntrada = @Original_FechaEntrada) AND (Monto = @Original_Monto OR @Original_M" & _
        "onto IS NULL AND Monto IS NULL) AND (Nombre_Proveedor = @Original_Nombre_Proveed" & _
        "or OR @Original_Nombre_Proveedor IS NULL AND Nombre_Proveedor IS NULL) AND (Obse" & _
        "rvaciones = @Original_Observaciones OR @Original_Observaciones IS NULL AND Obser" & _
        "vaciones IS NULL) AND (Saldo_Act = @Original_Saldo_Act OR @Original_Saldo_Act IS" & _
        " NULL AND Saldo_Act IS NULL) AND (Saldo_Prev = @Original_Saldo_Prev OR @Original" & _
        "_Saldo_Prev IS NULL AND Saldo_Prev IS NULL) AND (Tipo = @Original_Tipo OR @Origi" & _
        "nal_Tipo IS NULL AND Tipo IS NULL)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AjusteNo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AjusteNo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Proveedor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Act", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Prev", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Prev", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Ajustescpagar(AjusteNo, Tipo, Cod_Proveedor, Nombre_Proveedor, Fecha," & _
        " Saldo_Prev, Monto, Saldo_Act, Observaciones, Anula, Cod_Usuario, Contabilizado," & _
        " Cod_Moneda, Asiento, FechaEntrada) VALUES (@AjusteNo, @Tipo, @Cod_Proveedor, @N" & _
        "ombre_Proveedor, @Fecha, @Saldo_Prev, @Monto, @Saldo_Act, @Observaciones, @Anula" & _
        ", @Cod_Usuario, @Contabilizado, @Cod_Moneda, @Asiento, @FechaEntrada); SELECT ID" & _
        "_Ajuste, AjusteNo, Tipo, Cod_Proveedor, Nombre_Proveedor, Fecha, Saldo_Prev, Mon" & _
        "to, Saldo_Act, Observaciones, Anula, Cod_Usuario, Contabilizado, Cod_Moneda, Asi" & _
        "ento, FechaEntrada FROM Ajustescpagar WHERE (ID_Ajuste = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AjusteNo", System.Data.SqlDbType.BigInt, 8, "AjusteNo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 10, "Tipo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Proveedor", System.Data.SqlDbType.VarChar, 50, "Nombre_Proveedor"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Prev", System.Data.SqlDbType.Float, 8, "Saldo_Prev"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Act", System.Data.SqlDbType.Float, 8, "Saldo_Act"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Usuario", System.Data.SqlDbType.VarChar, 50, "Cod_Usuario"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT ID_Ajuste, AjusteNo, Tipo, Cod_Proveedor, Nombre_Proveedor, Fecha, Saldo_P" & _
        "rev, Monto, Saldo_Act, Observaciones, Anula, Cod_Usuario, Contabilizado, Cod_Mon" & _
        "eda, Asiento, FechaEntrada FROM Ajustescpagar"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE Ajustescpagar SET AjusteNo = @AjusteNo, Tipo = @Tipo, Cod_Proveedor = @Cod" & _
        "_Proveedor, Nombre_Proveedor = @Nombre_Proveedor, Fecha = @Fecha, Saldo_Prev = @" & _
        "Saldo_Prev, Monto = @Monto, Saldo_Act = @Saldo_Act, Observaciones = @Observacion" & _
        "es, Anula = @Anula, Cod_Usuario = @Cod_Usuario, Contabilizado = @Contabilizado, " & _
        "Cod_Moneda = @Cod_Moneda, Asiento = @Asiento, FechaEntrada = @FechaEntrada WHERE" & _
        " (ID_Ajuste = @Original_ID_Ajuste) AND (AjusteNo = @Original_AjusteNo OR @Origin" & _
        "al_AjusteNo IS NULL AND AjusteNo IS NULL) AND (Anula = @Original_Anula OR @Origi" & _
        "nal_Anula IS NULL AND Anula IS NULL) AND (Asiento = @Original_Asiento OR @Origin" & _
        "al_Asiento IS NULL AND Asiento IS NULL) AND (Cod_Moneda = @Original_Cod_Moneda O" & _
        "R @Original_Cod_Moneda IS NULL AND Cod_Moneda IS NULL) AND (Cod_Proveedor = @Ori" & _
        "ginal_Cod_Proveedor OR @Original_Cod_Proveedor IS NULL AND Cod_Proveedor IS NULL" & _
        ") AND (Cod_Usuario = @Original_Cod_Usuario OR @Original_Cod_Usuario IS NULL AND " & _
        "Cod_Usuario IS NULL) AND (Contabilizado = @Original_Contabilizado OR @Original_C" & _
        "ontabilizado IS NULL AND Contabilizado IS NULL) AND (Fecha = @Original_Fecha OR " & _
        "@Original_Fecha IS NULL AND Fecha IS NULL) AND (FechaEntrada = @Original_FechaEn" & _
        "trada) AND (Monto = @Original_Monto OR @Original_Monto IS NULL AND Monto IS NULL" & _
        ") AND (Nombre_Proveedor = @Original_Nombre_Proveedor OR @Original_Nombre_Proveed" & _
        "or IS NULL AND Nombre_Proveedor IS NULL) AND (Observaciones = @Original_Observac" & _
        "iones OR @Original_Observaciones IS NULL AND Observaciones IS NULL) AND (Saldo_A" & _
        "ct = @Original_Saldo_Act OR @Original_Saldo_Act IS NULL AND Saldo_Act IS NULL) A" & _
        "ND (Saldo_Prev = @Original_Saldo_Prev OR @Original_Saldo_Prev IS NULL AND Saldo_" & _
        "Prev IS NULL) AND (Tipo = @Original_Tipo OR @Original_Tipo IS NULL AND Tipo IS N" & _
        "ULL); SELECT ID_Ajuste, AjusteNo, Tipo, Cod_Proveedor, Nombre_Proveedor, Fecha, " & _
        "Saldo_Prev, Monto, Saldo_Act, Observaciones, Anula, Cod_Usuario, Contabilizado, " & _
        "Cod_Moneda, Asiento, FechaEntrada FROM Ajustescpagar WHERE (ID_Ajuste = @ID_Ajus" & _
        "te)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AjusteNo", System.Data.SqlDbType.BigInt, 8, "AjusteNo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 10, "Tipo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Proveedor", System.Data.SqlDbType.Int, 4, "Cod_Proveedor"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Proveedor", System.Data.SqlDbType.VarChar, 50, "Nombre_Proveedor"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Prev", System.Data.SqlDbType.Float, 8, "Saldo_Prev"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Act", System.Data.SqlDbType.Float, 8, "Saldo_Act"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Usuario", System.Data.SqlDbType.VarChar, 50, "Cod_Usuario"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AjusteNo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AjusteNo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Proveedor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Proveedor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Act", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Act", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Prev", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Prev", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Ajuste", System.Data.SqlDbType.BigInt, 8, "ID_Ajuste"))
        '
        'daDetallecPagar
        '
        Me.daDetallecPagar.DeleteCommand = Me.SqlDeleteCommand4
        Me.daDetallecPagar.InsertCommand = Me.SqlInsertCommand4
        Me.daDetallecPagar.SelectCommand = Me.SqlSelectCommand6
        Me.daDetallecPagar.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Detalle_AjustescPagar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DetalleAjustecPagar", "Id_DetalleAjustecPagar"), New System.Data.Common.DataColumnMapping("Id_AjustecPagar", "Id_AjustecPagar"), New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Ant", "Saldo_Ant"), New System.Data.Common.DataColumnMapping("Ajuste", "Ajuste"), New System.Data.Common.DataColumnMapping("Ajuste_SuMoneda", "Ajuste_SuMoneda"), New System.Data.Common.DataColumnMapping("Saldo_Ajustado", "Saldo_Ajustado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("TipoNota", "TipoNota"), New System.Data.Common.DataColumnMapping("ID_Compra", "ID_Compra"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("DescripcionCuentaContable", "DescripcionCuentaContable")})})
        Me.daDetallecPagar.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Detalle_AjustescPagar WHERE (Id_DetalleAjustecPagar = @Original_Id_De" & _
        "talleAjustecPagar) AND (Ajuste = @Original_Ajuste) AND (Ajuste_SuMoneda = @Origi" & _
        "nal_Ajuste_SuMoneda) AND (CuentaContable = @Original_CuentaContable) AND (Descri" & _
        "pcionCuentaContable = @Original_DescripcionCuentaContable) AND (Factura = @Origi" & _
        "nal_Factura) AND (ID_Compra = @Original_ID_Compra) AND (Id_AjustecPagar = @Origi" & _
        "nal_Id_AjustecPagar) AND (Monto = @Original_Monto) AND (Observaciones = @Origina" & _
        "l_Observaciones) AND (Saldo_Ajustado = @Original_Saldo_Ajustado) AND (Saldo_Ant " & _
        "= @Original_Saldo_Ant) AND (Tipo = @Original_Tipo) AND (TipoNota = @Original_Tip" & _
        "oNota)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleAjustecPagar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleAjustecPagar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste_SuMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionCuentaContable", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Compra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AjustecPagar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjustecPagar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ajustado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ajustado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoNota", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoNota", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Detalle_AjustescPagar(Id_AjustecPagar, Factura, Tipo, Monto, Saldo_An" & _
        "t, Ajuste, Ajuste_SuMoneda, Saldo_Ajustado, Observaciones, TipoNota, ID_Compra, " & _
        "CuentaContable, DescripcionCuentaContable) VALUES (@Id_AjustecPagar, @Factura, @" & _
        "Tipo, @Monto, @Saldo_Ant, @Ajuste, @Ajuste_SuMoneda, @Saldo_Ajustado, @Observaci" & _
        "ones, @TipoNota, @ID_Compra, @CuentaContable, @DescripcionCuentaContable); SELEC" & _
        "T Id_DetalleAjustecPagar, Id_AjustecPagar, Factura, Tipo, Monto, Saldo_Ant, Ajus" & _
        "te, Ajuste_SuMoneda, Saldo_Ajustado, Observaciones, TipoNota, ID_Compra, CuentaC" & _
        "ontable, DescripcionCuentaContable FROM Detalle_AjustescPagar WHERE (Id_DetalleA" & _
        "justecPagar = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AjustecPagar", System.Data.SqlDbType.BigInt, 8, "Id_AjustecPagar"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste", System.Data.SqlDbType.Float, 8, "Ajuste"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, "Ajuste_SuMoneda"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ajustado", System.Data.SqlDbType.Float, 8, "Saldo_Ajustado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoNota", System.Data.SqlDbType.VarChar, 3, "TipoNota"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Compra", System.Data.SqlDbType.BigInt, 8, "ID_Compra"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 80, "CuentaContable"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCuentaContable", System.Data.SqlDbType.VarChar, 80, "DescripcionCuentaContable"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Id_DetalleAjustecPagar, Id_AjustecPagar, Factura, Tipo, Monto, Saldo_Ant, " & _
        "Ajuste, Ajuste_SuMoneda, Saldo_Ajustado, Observaciones, TipoNota, ID_Compra, Cue" & _
        "ntaContable, DescripcionCuentaContable FROM Detalle_AjustescPagar"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Detalle_AjustescPagar SET Id_AjustecPagar = @Id_AjustecPagar, Factura = @F" & _
        "actura, Tipo = @Tipo, Monto = @Monto, Saldo_Ant = @Saldo_Ant, Ajuste = @Ajuste, " & _
        "Ajuste_SuMoneda = @Ajuste_SuMoneda, Saldo_Ajustado = @Saldo_Ajustado, Observacio" & _
        "nes = @Observaciones, TipoNota = @TipoNota, ID_Compra = @ID_Compra, CuentaContab" & _
        "le = @CuentaContable, DescripcionCuentaContable = @DescripcionCuentaContable WHE" & _
        "RE (Id_DetalleAjustecPagar = @Original_Id_DetalleAjustecPagar) AND (Ajuste = @Or" & _
        "iginal_Ajuste) AND (Ajuste_SuMoneda = @Original_Ajuste_SuMoneda) AND (CuentaCont" & _
        "able = @Original_CuentaContable) AND (DescripcionCuentaContable = @Original_Desc" & _
        "ripcionCuentaContable) AND (Factura = @Original_Factura) AND (ID_Compra = @Origi" & _
        "nal_ID_Compra) AND (Id_AjustecPagar = @Original_Id_AjustecPagar) AND (Monto = @O" & _
        "riginal_Monto) AND (Observaciones = @Original_Observaciones) AND (Saldo_Ajustado" & _
        " = @Original_Saldo_Ajustado) AND (Saldo_Ant = @Original_Saldo_Ant) AND (Tipo = @" & _
        "Original_Tipo) AND (TipoNota = @Original_TipoNota); SELECT Id_DetalleAjustecPaga" & _
        "r, Id_AjustecPagar, Factura, Tipo, Monto, Saldo_Ant, Ajuste, Ajuste_SuMoneda, Sa" & _
        "ldo_Ajustado, Observaciones, TipoNota, ID_Compra, CuentaContable, DescripcionCue" & _
        "ntaContable FROM Detalle_AjustescPagar WHERE (Id_DetalleAjustecPagar = @Id_Detal" & _
        "leAjustecPagar)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AjustecPagar", System.Data.SqlDbType.BigInt, 8, "Id_AjustecPagar"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 8, "Factura"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 8, "Saldo_Ant"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste", System.Data.SqlDbType.Float, 8, "Ajuste"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, "Ajuste_SuMoneda"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo_Ajustado", System.Data.SqlDbType.Float, 8, "Saldo_Ajustado"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoNota", System.Data.SqlDbType.VarChar, 3, "TipoNota"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Compra", System.Data.SqlDbType.BigInt, 8, "ID_Compra"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 80, "CuentaContable"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCuentaContable", System.Data.SqlDbType.VarChar, 80, "DescripcionCuentaContable"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleAjustecPagar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleAjustecPagar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ajuste_SuMoneda", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ajuste_SuMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionCuentaContable", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Factura", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Factura", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Compra", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Compra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_AjustecPagar", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjustecPagar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ajustado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ajustado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo_Ant", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Ant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoNota", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoNota", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_DetalleAjustecPagar", System.Data.SqlDbType.BigInt, 8, "Id_DetalleAjustecPagar"))
        '
        'gridFacturas
        '
        Me.gridFacturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        'gridFacturas.EmbeddedNavigator
        '
        Me.gridFacturas.EmbeddedNavigator.Name = ""
        Me.gridFacturas.Location = New System.Drawing.Point(6, 120)
        Me.gridFacturas.MainView = Me.AdvBandedGridView1
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.Size = New System.Drawing.Size(200, 264)
        Me.gridFacturas.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.gridFacturas.TabIndex = 212
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
        Me.GridBand1.Width = 482
        '
        'Factura
        '
        Me.Factura.Caption = "Factura No."
        Me.Factura.FieldName = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Factura.SortIndex = 0
        Me.Factura.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.Factura.Visible = True
        Me.Factura.Width = 167
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Fecha.Visible = True
        Me.Fecha.Width = 315
        '
        'lblNajuste
        '
        Me.lblNajuste.BackColor = System.Drawing.SystemColors.Window
        Me.lblNajuste.Enabled = False
        Me.lblNajuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNajuste.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblNajuste.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNajuste.Location = New System.Drawing.Point(4, 16)
        Me.lblNajuste.Name = "lblNajuste"
        Me.lblNajuste.Size = New System.Drawing.Size(48, 12)
        Me.lblNajuste.TabIndex = 213
        Me.lblNajuste.Text = "Ajuste No."
        Me.lblNajuste.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_Anulado
        '
        Me.Label_Anulado.BackColor = System.Drawing.Color.White
        Me.Label_Anulado.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Anulado.ForeColor = System.Drawing.Color.Red
        Me.Label_Anulado.Location = New System.Drawing.Point(304, 312)
        Me.Label_Anulado.Name = "Label_Anulado"
        Me.Label_Anulado.Size = New System.Drawing.Size(249, 32)
        Me.Label_Anulado.TabIndex = 214
        Me.Label_Anulado.Text = "ANULADO"
        Me.Label_Anulado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_Anulado.Visible = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusBar1.Location = New System.Drawing.Point(0, 446)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(686, 16)
        Me.StatusBar1.TabIndex = 216
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Tipo Cambio"
        Me.StatusBarPanel1.Width = 70
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Text = "Tipo Nota"
        Me.StatusBarPanel3.Width = 70
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel5.Width = 330
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.opNotaDebito)
        Me.Panel2.Controls.Add(Me.opNotaCredito)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(7, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 35)
        Me.Panel2.TabIndex = 218
        '
        'TxtDocProveedor
        '
        Me.TxtDocProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDocProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDocProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjustePagar, "Ajustescpagar.AjusteNo"))
        Me.TxtDocProveedor.ForeColor = System.Drawing.Color.Blue
        Me.TxtDocProveedor.Location = New System.Drawing.Point(151, 95)
        Me.TxtDocProveedor.Name = "TxtDocProveedor"
        Me.TxtDocProveedor.Size = New System.Drawing.Size(104, 13)
        Me.TxtDocProveedor.TabIndex = 220
        Me.TxtDocProveedor.Text = ""
        Me.TxtDocProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(151, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Doc. Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipo.Location = New System.Drawing.Point(16, 136)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(56, 16)
        Me.txtTipo.TabIndex = 221
        Me.txtTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAjustePagar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(688, 462)
        Me.Controls.Add(Me.gridFacturas)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.TxtDocProveedor)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label_Anulado)
        Me.Controls.Add(Me.lblNajuste)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6_Old)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.txtTipoD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboMoneda)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNum_Ajuste)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3_oLD)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(696, 496)
        Me.Name = "frmAjustePagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes de Cuentas por Pagar"
        CType(Me.DsAjustePagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtSaldoActGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAntGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAjustePagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            strModulos = IIf(NuevaConexion = "", "SeePos", "SeePos")

            Me.DsAjustePagar.Ajustescpagar.ID_AjusteColumn.AutoIncrement = True
            Me.DsAjustePagar.Ajustescpagar.ID_AjusteColumn.AutoIncrementSeed = -1
            Me.DsAjustePagar.Ajustescpagar.ID_AjusteColumn.AutoIncrementStep = -1

            Me.DsAjustePagar.Detalle_AjustescPagar.Id_DetalleAjustecPagarColumn.AutoIncrement = True
            Me.DsAjustePagar.Detalle_AjustescPagar.Id_DetalleAjustecPagarColumn.AutoIncrementSeed = -1
            Me.DsAjustePagar.Detalle_AjustescPagar.Id_DetalleAjustecPagarColumn.AutoIncrementStep = -1

            Me.daMoneda.Fill(Me.DsAjustePagar, "Moneda")

            'Establecer valores por defecto AjustecPagar
            Me.DsAjustePagar.Ajustescpagar.AjusteNoColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.TipoColumn.DefaultValue = "CRE"
            Me.DsAjustePagar.Ajustescpagar.Cod_ProveedorColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.FechaColumn.DefaultValue = Now
            Me.DsAjustePagar.Ajustescpagar.Saldo_PrevColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.MontoColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.Saldo_ActColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.ObservacionesColumn.DefaultValue = ""
            Me.DsAjustePagar.Ajustescpagar.AnulaColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.Cod_UsuarioColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.ContabilizadoColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.Cod_MonedaColumn.DefaultValue = 1
            Me.DsAjustePagar.Ajustescpagar.AsientoColumn.DefaultValue = 0
            Me.DsAjustePagar.Ajustescpagar.FechaEntradaColumn.DefaultValue = Now

            'Establecer valores por defecto Detalle_AjustecPagar
            Me.DsAjustePagar.Detalle_AjustescPagar.Id_AjustecPagarColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.FacturaColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.TipoColumn.DefaultValue = "CRE"
            Me.DsAjustePagar.Detalle_AjustescPagar.MontoColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.Saldo_AntColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.AjusteColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.Ajuste_SuMonedaColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.Saldo_AjustadoColumn.DefaultValue = 0
            Me.DsAjustePagar.Detalle_AjustescPagar.ObservacionesColumn.DefaultValue = ""
            Me.DsAjustePagar.Detalle_AjustescPagar.TipoNotaColumn.DefaultValue = ""
            Me.DsAjustePagar.Detalle_AjustescPagar.ID_CompraColumn.DefaultValue = 0

            Me.DsAjustePagar.Detalle_AjustescPagar.CuentaContableColumn.DefaultValue = ""
            Me.DsAjustePagar.Detalle_AjustescPagar.DescripcionCuentaContableColumn.DefaultValue = ""



            dtFecha.Value = Date.Now
            dtEmitida.Value = Date.Now
            ToolBar1.Buttons(1).Enabled = True
            txtTipo.Text = "CRE"
            txtTipoD.Text = "CRE"
            opNotaCredito.Checked = True
            txtUsuario.Focus()
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Private Sub txtAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbono.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Function LlenarVentas(ByVal Id As Double)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim IdRec As Long
        'Dentro de un Try/Catch por si se produce un error
        Try
            Dim Fx As New cFunciones
            Fx.Llenar_Tabla_Generico("SELECT * FROM ajustescpagar WHERE ID_Ajuste = " & Id, Me.DsAjustePagar.Ajustescpagar, SqlConnection1.ConnectionString)
            Fx.Llenar_Tabla_Generico("SELECT * FROM detalle_ajustescpagar WHERE Id_AjustecPagar = " & Id, Me.DsAjustePagar.Detalle_AjustescPagar, SqlConnection1.ConnectionString)

            'IdRec = Id 'CInt(cConexion.SlqExecuteScalar(cConexion.Conectar, "Select ID_Ajuste from ajustescpagar where AjusteNo =" & Id))
            ''            cConexion.DesConectar(cConexion.Conectar)
            ''''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''Obtenemos la cadena de conexión adecuada
            'Dim sConn As String = Me.SqlConnection1.ConnectionString
            'cnnv = New SqlConnection(sConn)
            'cnnv.Open()
            ''Creamos el comando para la consulta
            'Dim cmdv As SqlCommand = New SqlCommand
            'Dim sel As String = "SELECT * FROM ajustescpagar WHERE (AjusteNo = @Id_Factura)"
            'cmdv.CommandText = sel
            'cmdv.Connection = cnnv
            'cmdv.CommandType = CommandType.Text
            'cmdv.CommandTimeout = 90
            ''Los parámetros usados en la cadena de la consulta 
            'cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            'cmdv.Parameters("@Id_Factura").Value = Id
            ''Creamos el dataAdapter y asignamos el comando de selección
            'Dim dv As New SqlDataAdapter
            'dv.SelectCommand = cmdv
            '' Llenamos la tabla
            'dv.Fill(Me.DsAjustePagar, "Ajustescpagar")
            ''''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' Creamos el comando para la consulta
            'Dim cmd As SqlCommand = New SqlCommand
            'sel = "SELECT * FROM detalle_ajustescpagar WHERE (Id_AjustecPagar = @Id_Factura)"
            'cmd.CommandText = sel
            'cmd.Connection = cnnv
            'cmd.CommandType = CommandType.Text
            'cmd.CommandTimeout = 90
            '' Los parámetros usados en la cadena de la consulta 
            'cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            'cmd.Parameters("@Id_Factura").Value = IdRec
            '' Creamos el dataAdapter y asignamos el comando de selección
            'Dim da As New SqlDataAdapter
            'da.SelectCommand = cmd
            ' Llenamos la tabla
            'da.Fill(Me.DsAjustePagar, "Detalle_AjustescPagar")

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
    Function Registrar_Abono()
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.daAjustecPagar.InsertCommand.Transaction = Trans
            Me.daAjustecPagar.UpdateCommand.Transaction = Trans
            Me.daAjustecPagar.DeleteCommand.Transaction = Trans

            Me.daDetallecPagar.InsertCommand.Transaction = Trans
            Me.daDetallecPagar.UpdateCommand.Transaction = Trans
            Me.daDetallecPagar.DeleteCommand.Transaction = Trans

            Me.daAjustecPagar.Update(Me.DsAjustePagar, "Ajustescpagar")
            Me.daDetallecPagar.Update(Me.DsAjustePagar, "Detalle_AjustescPagar")


            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
    Function Registrar()
        Dim i As Integer
        Dim Funciones As New Conexion
        Dim FactTemp As Double
        Dim Proveedor As Integer
        Try
            If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count = 0 Then
                MsgBox("No se puede registrar un ajuste sin detalle", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = False
                Exit Function
            End If

            If MessageBox.Show("¿Desea guardar el Ajuste?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                For i = 0 To Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count - 1
                    Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position = i
                    If Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Saldo_Ajustado") = 0 Then
                        FactTemp = Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
                        Proveedor = Me.BindingContext(DsAjustePagar, "Ajustescpagar").Current("Cod_Proveedor")
                        Funciones.UpdateRecords("Compras", " FacturaCancelado = 1 ", " Factura =" & FactTemp & "AND TipoCompra ='CRE' and CodigoProv =" & Proveedor, "SeePos")
                    End If
                Next i
                txtNum_Ajuste.Text = Numero_de_Ajuste()
                Me.BindingContext(DsAjustePagar, "ajustescpagar").EndCurrentEdit()
                Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").EndCurrentEdit()

                If Registrar_Abono() Then
                    Me.ToolBar1.Buttons(1).Enabled = True

                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    GroupBox1.Enabled = False
                    Me.ToolBar1.Buttons(2).Enabled = False
                    MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)

                    If MessageBox.Show("¿Desea imprimir este Ajuste?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        imprimir()
                    End If

                    txtCodigo.Enabled = False
                    txtAbono.Enabled = False
                    opNotaCredito.Enabled = False
                    opNotaDebito.Enabled = False
                    Me.txtObservaciones.Enabled = False
                    Me.TxtDocProveedor.Enabled = False


                    Me.DsAjustePagar.Detalle_AjustescPagar.Clear()
                    Me.DsAjustePagar.Ajustescpagar.Clear()

                    Me.Tabla.Clear()

                    Me.txtUsuario.Text = ""
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Focus()
                    txtNombreUsuario.Text = ""
                End If

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Sub imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Report_AjusteCPagar As New Reporte_AjusteCPagar


            Report_AjusteCPagar.SetParameterValue(0, CDbl(txtNum_Ajuste.Text))

            CrystalReportsConexion.LoadShow(Report_AjusteCPagar, MdiParent, SqlConnection1.ConnectionString)
            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Function Numero_de_Ajuste() As Double

        Dim cConexion As New Conexion
        Dim Num_Ajuste As Double
        Dim Conex As SqlConnection = SqlConnection1

        If Conex.State = ConnectionState.Open Then
            Conex.Close()
            Conex.Open()
        Else
            Conex.Open()
        End If

        Num_Ajuste = CDbl(cConexion.SlqExecuteScalar(Conex, "SELECT isnull(Max(ID_Ajuste),0) FROM Ajustescpagar"))
        Numero_de_Ajuste = Num_Ajuste + 1
        cConexion.DesConectar(cConexion.sQlconexion)
        Conex.Close()

    End Function

    Private Sub BuscarAjuste()
        Dim Fx As New cFunciones
        Dim identificador As Double

        Try
            If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Ajuste de Cuenta, si continúa se perderan los datos del Ajuste actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Me.DsAjustePagar.Detalle_AjustescPagar.Clear()
            Me.DsAjustePagar.Ajustescpagar.Clear()
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select cast(ID_Ajuste as varchar) as Numero , Nombre_Proveedor, Fecha from ajustescpagar Order by Fecha DESC", "Nombre_Proveedor", "Fecha", "Buscar Ajuste de Cuenta", Me.SqlConnection1.ConnectionString))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            Me.LlenarVentas(identificador)
            'si esta venta aun no ha sido anulada
            If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").Current("Anula") = False Then Me.ToolBar1.Buttons(3).Enabled = True

            txtCodigo.Enabled = False
            txtAbono.Enabled = False
            opNotaCredito.Enabled = False
            opNotaDebito.Enabled = False
            Me.txtObservaciones.Enabled = False
            Me.TxtDocProveedor.Enabled = False

            Me.GridControl2.Enabled = False
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub NuevoAjuste()
        Dim Fx As New cFunciones
        Dim Valor As Boolean
        Try
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'no hay un registro pendiente
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False

                Valor = Fx.VerificarBaseDatos("Contabilidad")
                If Valor Then
                    Me.Label10.Visible = True
                    Me.Label8.Visible = True
                    Me.txtCuentaC.Visible = True
                    Me.txtDescripcionC.Visible = True
                Else
                    Me.colCuenta.VisibleIndex = -1
                    Me.Label10.Visible = False
                    Me.Label8.Visible = False
                    Me.txtCuentaC.Visible = False
                    Me.txtDescripcionC.Visible = False
                End If
                If Me.txtUsuario.Text = "" Then
                    txtUsuario.Enabled = True
                    txtUsuario.Focus()
                End If
                txtCodigo.Text = "" : txtNombre.Text = "" : txtAbono.Text = ""

                'Me.ComboMoneda.Enabled = True
                txtCodigo.Enabled = True
                ComboMoneda.Enabled = False
                dtFecha.Enabled = False
                opNotaCredito.Enabled = False
                opNotaDebito.Enabled = False
                txtNum_Ajuste.Text = Numero_de_Ajuste()
            Else

                If MessageBox.Show("Desea Guardar los Cambios del Ajuste", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Registrar()
                Else
                    Me.BindingContext(Me.DsAjustePagar, "ajustescpagar").CancelCurrentEdit()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = False
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtCedulaUsuario.Text = ""
                    'Me.GroupBox6.Enabled = False


                    Me.txtObservaciones.Enabled = False
                    Me.txtAbono.Enabled = False
                    Me.ComboMoneda.Enabled = False
                    dtFecha.Enabled = False
                    Me.txtUsuario.Enabled = True
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtCedulaUsuario.Text = ""
                    txtUsuario.Focus()

                End If

            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Dim conex As SqlConnection = SqlConnection1

        If e.KeyCode = Keys.Enter Then
            If txtUsuario.Text <> "" Then
                '        rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre, AnuAjustecCobrar from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                conex.Open()
                rs = cConexion.GetRecorset(conex, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Text = ""
                    txtUsuario.Focus()
                End If

                'While rs.Read
                If rs.Read Then
                    Try
                        Me.BindingContext(Me.DsAjustePagar, "ajustescpagar").EndCurrentEdit()
                        Me.BindingContext(Me.DsAjustePagar, "ajustescpagar").AddNew()
                        txtNombreUsuario.Text = rs("Nombre")
                        txtCedulaUsuario.Text = rs("Cedula")
                        ' If rs("AnuAjustecCobrar") = 1 Then Anular = True Else Anular = False
                        txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                        Me.ToolBar1.Buttons(0).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(2).Enabled = True
                        Me.NuevoAjuste()

                        Me.txtCodigo.Focus()
                        If conex.State = ConnectionState.Closed Then
                            conex.Open()
                        End If

                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                End If
                'End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
                'conex.Close()
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If
        End If
    End Sub


    Private Sub ComboMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtFecha.Focus()
        End If
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
            rs = cConexion.GetRecorset(conex, "SELECT Codigoprov, Nombre from Proveedores where Codigoprov ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs!Codigoprov
                    txtNombre.Text = rs!nombre
                    Tabla = funciones.BuscarFacturas_Proveedor(codigo, conex.ConnectionString)
                    gridFacturas.DataSource = Tabla
                    Saldo_Cuenta_Proveedor(Tabla)
                    If Tabla.Rows.Count = 0 Then
                        MessageBox.Show("El proveedor no tiene facturas pendientes...", "Atención...", MessageBoxButtons.OK)
                        txtCodigo.Focus()
                        rs.Close()
                        Exit Sub
                    Else
                        Me.ComboMoneda.Enabled = True
                        dtFecha.Enabled = True
                        txtAbono.Enabled = True
                        Me.ComboMoneda.Focus()

                    End If
                Else
                    MsgBox("La identificación del proveedor no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigo.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.sQlconexion)
        End If
    End Sub

    Private Sub informacionfactura(ByVal Nfactura As Double, ByVal Cod_Proveedor As Integer)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim Codigo As Integer
        Dim rs As SqlDataReader
        Dim Conexion2 As New Conexion
        Dim Proveedor As New Double

        If Nfactura <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar(strModulos), "Select Factura, TipoCompra, Fecha, Vence, Cod_MonedaCompra, TotalFactura,Id_Compra from Compras where Factura = '" & Nfactura & "' and TipoCompra = 'CRE' and CodigoProv = " & Cod_Proveedor)
            While rs.Read
                Try
                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").CancelCurrentEdit()
                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").EndCurrentEdit()
                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").AddNew()
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
                Try
                    Proveedor = Me.BindingContext(DsAjustePagar, "Ajustescpagar").Current("Cod_Proveedor")
                    Codigo = rs!Cod_monedaCompra
                    TipoCambioFact = Conexion2.SlqExecuteScalar(Conexion2.Conectar(strModulos), "Select ValorCompra from Moneda Where CodMoneda =" & Codigo)
                    Conexion2.DesConectar(Conexion2.sQlconexion)
                    Me.Label_ID_FacturaCompra.Text = rs!Id_Compra
                    '                    Me.BindingContext(Me.DsAjustePagar.Detalle_AjustescPagar).Current("Id_Compra") = rs!Id_Compra

                    txtFactura.Text = rs!Factura
                    dtEmitida.Text = rs!Fecha
                    txtMonto.Text = Format((rs!TotalFactura * TipoCambioFact) / txtTipoCambio.Text, "#,#0.00")
                    txtSaldo.Text = Format(funciones.Saldo_de_Factura_Proveedor(Nfactura, (rs!TotalFactura * TipoCambioFact) / txtTipoCambio.Text, TipoCambioFact, txtTipoCambio.Text, Proveedor, strModulos), "#,#0.00")
                    txtAbono.Text = Format(CDbl(txtSaldo.Text), "#,#0.00")
                    If txtTipo.Text = "CRE" Then
                        txtSaldoAct.Text = "0.00"
                    Else
                        txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtAbono.Text), "#,#0.00")
                    End If
                    GroupBox1.Enabled = True

                    txtAbono.Focus()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End While
            Conexion2 = Nothing
            cConexion.DesConectar(cConexion.sQlconexion)
            cConexion = Nothing
        End If
    End Sub

    Function Saldo_Cuenta_Proveedor(ByVal Tabla1 As DataTable)
        Dim i As Integer
        Dim fila As DataRow
        Dim facturatemp As Double 'Factura de la cual se va a obtener el saldo
        Dim Totaltemp As Double '
        Dim SaldoCuenta As Double '
        Dim CodigoMoneda As Integer '
        Dim funciones As New cFunciones
        Dim ConexionLocal As New Conexion
        Dim rs As SqlDataReader
        Dim ValorFactura As Double 'Tipo de cambio de la factura de compra
        SaldoCuenta = 0
        For i = 0 To Tabla1.Rows.Count - 1
            fila = Tabla1.Rows(i)
            facturatemp = fila!Factura
            Totaltemp = fila!TotalFactura
            CodigoMoneda = fila!Cod_MonedaCompra
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar(strModulos), "SELECT ValorVenta from Moneda where CodMoneda =" & CodigoMoneda)
            If rs.Read Then ValorFactura = rs("ValorVenta")
            rs.Close()
            rs = Nothing

            ConexionLocal.DesConectar(ConexionLocal.sQlconexion)
            'Valor de la factura debe ser el tipo de cambio de la factura
            SaldoCuenta = SaldoCuenta + funciones.Saldo_de_Factura_Proveedor(facturatemp, ((Totaltemp * ValorFactura) / CDbl(Me.txtTipoCambio.Text)), ValorFactura, CDbl(Me.txtTipoCambio.Text), Me.txtCodigo.Text, strModulos)

        Next
        ConexionLocal = Nothing
        txtSaldoAntGen.Text = Format(SaldoCuenta, "#,#0.00")
    End Function

    Private Sub txtAbono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbono.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                'If txtCuentaC.Text = "" Then
                '    MessageBox.Show("Debe ingresar la cuenta contable", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                '    txtCuentaC.Focus()
                '    Exit Sub
                'End If
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
                    txtAbonoSuMoneda.Text = (CDbl(txtAbono.Text) / TipoCambioFact) * CDbl(Me.txtTipoCambio.Text)
                    If txtTipo.Text = "CRE" Then
                        txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) - CDbl(txtAbono.Text), "#,#0.00")
                    Else
                        txtSaldoAct.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtAbono.Text), "#,#0.00")
                    End If


                    If opNotaDebito.Checked = True Then
                        Me.txtTipo.Text = "DEB"
                        txtTipoD.Text = "DEB"
                    Else
                        Me.txtTipo.Text = "CRE"
                        txtTipoD.Text = "CRE"
                    End If
                    Me.txtCuentaC.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtAbono.Text = 0
            txtAbono.Focus()
        End Try
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
            'txtFactura.Focus()
            Me.gridFacturas.Focus()
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            'Me.txtCodigo.Text = cFunciones.BuscarDatos("SELECT Proveedores.CodigoProv, Proveedores.Nombre FROM Proveedores RIGHT OUTER JOIN compras ON Proveedores.CodigoProv = compras.CodigoProv GROUP BY Proveedores.Nombre, Proveedores.CodigoProv, compras.FacturaCancelado HAVING(compras.FacturaCancelado = 0) ORDER BY Proveedores.Nombre", "Nombre")
            'Me.txtCodigo.Text = cFunciones.BuscarDatos("SELECT Proveedores.CodigoProv, Proveedores.Nombre FROM Proveedores RIGHT OUTER JOIN  compras ON Proveedores.CodigoProv = compras.CodigoProv WHERE (compras.FacturaCancelado = 0)", "Nombre")
            Me.txtCodigo.Text = cFunciones.BuscarDatos("select codigoprov as Identificación,nombre as Nombre from proveedores", "Nombre", "Buscar...", Me.SqlConnection1.ConnectionString)

            CargarInformacionProveedor(txtCodigo.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionProveedor(txtCodigo.Text)
        End If
    End Sub

    Private Sub txtAbono_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbono.GotFocus
        txtAbono.SelectAll()
    End Sub

    Private Sub GridControl2_Enter(sender As Object, e As EventArgs) Handles GridControl2.Enter
        On Error Resume Next
        Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").CancelCurrentEdit()
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
            If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count > 0 Then   ' si hay detalle

                resp = MessageBox.Show("¿Desea eliminar esta factura del Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    FilaTabla = Tabla.NewRow
                    FilaTabla("Factura") = Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
                    Facturatem = FilaTabla("factura")
                    Fechatem = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select Fecha from Compras Where Factura =" & Facturatem)
                    Conexion2.DesConectar(Conexion2.sQlconexion)
                    FilaTabla("Fecha") = Fechatem
                    Tabla.Rows.Add(FilaTabla)

                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").RemoveAt(Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position)
                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").EndCurrentEdit()
                    Me.txtAbonoGen.Text = Format(Me.colAbono.SummaryItem.SummaryValue, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")

                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").EndCurrentEdit()

                Else
                    Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Facturas a eliminar", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
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

    Private Sub opNotaCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opNotaCredito.CheckedChanged
        If opNotaCredito.Checked = True Then
            txtTipo.Text = "CRE"
            txtTipoD.Text = "CRE"
        Else
            txtTipo.Text = "DEB"
            txtTipoD.Text = "DEB"
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : NuevoAjuste()

            Case 2 : If PMU.Find Then BuscarAjuste() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then AnularRecibo() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6
                If MessageBox.Show("¿Desea Cerrar el Módulo de Ajuste por Pagar?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Close()
                End If

        End Select
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
        Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").EndCurrentEdit()
        informacionfactura(factura, CInt(Me.txtCodigo.Text))
    End Sub

    Public Function AnularRecibo()

        Try
            Dim resp As Integer
            If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").Count > 0 Then
                If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Anular este Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").EndCurrentEdit()

                        If Registrar_Anulacion_Ajuste() Then

                            Me.DsAjustePagar.AcceptChanges()
                            MsgBox("El Ajuste ha sido anulado correctamente", MsgBoxStyle.Information)
                            Me.DsAjustePagar.Detalle_AjustescPagar.Clear()
                            Me.DsAjustePagar.Ajustescpagar.Clear()
                            Me.ToolBar1.Buttons(4).Enabled = True
                            Me.ToolBar1.Buttons(1).Enabled = True

                            Me.ToolBar1.Buttons(0).Text = "Nuevo"
                            Me.ToolBar1.Buttons(0).ImageIndex = 0
                            Me.ToolBar1.Buttons(3).Enabled = False
                            Me.ToolBar1.Buttons(2).Enabled = False
                            Me.ToolBar1.Buttons(4).Enabled = False


                            'Me.GroupBox6.Enabled = False

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

    Function Registrar_Anulacion_Ajuste() As Boolean
        Dim i As Long
        Dim Facttem As Double
        Dim Funciones As New Conexion
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.daAjustecPagar.UpdateCommand.Transaction = Trans

            Me.daAjustecPagar.Update(Me.DsAjustePagar, "Ajustescpagar")
            For i = 0 To Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count - 1
                Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position = i
                Facttem = Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
                Funciones.UpdateRecords("Compras", "FacturaCancelado = 0", "Factura =" & Facttem & "AND TIPOCOMPRA ='CRE'", strModulos)
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

    Private Sub lbSimbolo1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSimbolo1.TextChanged
        lbSimbolo2.Text = lbSimbolo1.Text : lbSimbolo5.Text = lbSimbolo1.Text : lbSimbolo6.Text = lbSimbolo1.Text
    End Sub
    Private Sub opNotaDebito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opNotaDebito.KeyDown, opNotaCredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDocProveedor.Enabled = True
            Me.TxtDocProveedor.Focus()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try

            If Me.CheckBox1.Checked = True Then
                Me.Label_Anulado.Visible = True
            Else
                Me.Label_Anulado.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub TxtDocProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDocProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader

            cnnConexion = clsConexion.Conectar("SeePos")

            sql = " SELECT COUNT(*) FROM Ajustescpagar where AjusteNo = " & Me.TxtDocProveedor.Text & " AND Cod_Proveedor=" & Me.txtCodigo.Text

            rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            If rstReader.Read() = False Then Exit Sub
            If rstReader(0) = 0 Then
                Me.txtObservaciones.Enabled = True
                Me.txtObservaciones.Focus()
            Else
                MsgBox("El número de factura ya esta registrada, favor revisar...", MsgBoxStyle.Information, "Atención ...")
                Me.TxtDocProveedor.Focus()
            End If
            clsConexion.DesConectar(cnnConexion)
        End If
    End Sub

    Private Sub txtCuentaC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaC.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cconex As New SqlClient.SqlConnection
            cconex = CConexion.Conectar("Contabilidad")
            Dim frmBuscar As New Buscar
            frmBuscar.sqlstring = "SELECT CuentaContable, Descripcion FROM cuentacontable where (Movimiento = 1) "
            frmBuscar.Text = "CuentaContable"
            frmBuscar.campo = "Descripcion"
            frmBuscar.NuevaConexion = cconex.ConnectionString
            frmBuscar.ShowDialog()
            If frmBuscar.descrip <> "" Then
                txtCuentaC.Text = frmBuscar.codigo
                txtDescripcionC.Text = frmBuscar.descrip
                descripcion = frmBuscar.descrip
                Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("CuentaContable") = frmBuscar.codigo
                Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("DescripcionCuentaContable") = frmBuscar.descrip
            Else
                MessageBox.Show("No seleccionó ninguna cuenta contable", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                txtCuentaC.Focus()
            End If
            CConexion.DesConectar(cconex)
        End If
        If e.KeyCode = Keys.Enter Then
            If Me.txtCuentaC.Text = "" Then
                MsgBox("Debe seleccionar una Cuenta Contable.....", MsgBoxStyle.Information)
                Me.txtCuentaC.Focus()
            Else
                CargarInformacionCuenta(txtCuentaC.Text)
                Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar").EndCurrentEdit()

                If opNotaDebito.Checked = True Then
                    Me.txtTipo.Text = "DEB"
                    txtTipoD.Text = "DEB"
                Else
                    Me.txtTipo.Text = "CRE"
                    txtTipoD.Text = "CRE"
                End If

                Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").EndCurrentEdit()
                Me.txtAbonoGen.Text = Format(Me.colAbono.SummaryItem.SummaryValue, "#,#0.00")

                If txtTipo.Text = "CRE" Then
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text - txtAbonoGen.Text, "#,#0.00")
                Else
                    txtSaldoActGen.Text = Format(CDbl(txtSaldoAntGen.Text) + CDbl(txtAbonoGen.Text), "#,#0.00")
                End If
                If Me.BindingContext(Me.Tabla).Current("Factura") = Me.txtFactura.Text Then
                    Me.BindingContext(Me.Tabla).RemoveAt(BindingContext(Me.Tabla).Position())
                End If
                gridFacturas.Focus()
            End If
        End If

    End Sub

    Private Sub CargarInformacionCuenta(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        Dim conex As SqlConnection = Me.SqlConnection1
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(conex, "SELECT Descripcion from CuentasContableMovimimiento where CuentaContable ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtDescripcionC.Text = rs!Descripcion
                Else
                    MsgBox("La cuenta contable no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCuentaC.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.sQlconexion)
        End If
    End Sub

    Private Sub dtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboMoneda.Enabled = False
            dtFecha.Enabled = False
            Me.opNotaCredito.Enabled = True
            Me.opNotaDebito.Enabled = True
            Me.opNotaCredito.Focus()
        End If
    End Sub

    Private Sub txtCuentaC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaC.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class
