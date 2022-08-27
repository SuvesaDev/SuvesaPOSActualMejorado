Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing

Public Class Abono_Apartados
    Inherits FrmPlantilla

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
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbSimbolo6 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo5 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo4 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo2 As System.Windows.Forms.Label
    Friend WithEvents lbSimbolo1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAnt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIntereses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtEmitida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Factura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo_Ant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntereses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaldoActGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAntGen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Ad_Abonoapartados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Ad_detalleabonoapartado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents admoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsAbonosapartados1 As DsAbonosapartados
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtAbonoB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbonoSuMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.Label
    Friend WithEvents txtNum_Recibo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBrecibo As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents gridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbanulado As System.Windows.Forms.Label
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Abono_Apartados))
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
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.DsAbonosapartados1 = New DsAbonosapartados()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.dtEmitida = New System.Windows.Forms.DateTimePicker()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIntereses = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.Label()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Factura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo_Ant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntereses = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoActGen = New DevExpress.XtraEditors.TextEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAbonoGen = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSaldoAntGen = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Ad_Abonoapartados = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Ad_detalleabonoapartado = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.admoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtNombreUsuario = New System.Windows.Forms.Label()
        Me.txtAbonoB = New DevExpress.XtraEditors.TextEdit()
        Me.txtAbonoSuMoneda = New DevExpress.XtraEditors.TextEdit()
        Me.txtCedulaUsuario = New System.Windows.Forms.Label()
        Me.txtNum_Recibo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.TBrecibo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.gridFacturas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbanulado = New System.Windows.Forms.Label()
        CType(Me.DsAbonosapartados1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntereses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtSaldoActGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAntGen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoSuMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList.Images.SetKeyName(0, "1456265011_file-empty.png")
        Me.ImageList.Images.SetKeyName(1, "1437535991_search.png")
        Me.ImageList.Images.SetKeyName(2, "1437535964_floppy.png")
        Me.ImageList.Images.SetKeyName(3, "1437535982_sign-error.png")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "1456265147_Cancel.png")
        Me.ImageList.Images.SetKeyName(7, "1438571976_shine_9.png")
        Me.ImageList.Images.SetKeyName(8, "1456265434_player_stop.png")
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 448)
        Me.ToolBar1.Size = New System.Drawing.Size(724, 85)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(314, 466)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(724, 32)
        Me.TituloModulo.Text = "Abonos  de  Apartados"
        '
        'dtFecha
        '
        Me.dtFecha.Checked = False
        Me.dtFecha.CustomFormat = "dd/MMMM/yyyy"
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(624, 72)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtFecha.TabIndex = 2
        Me.dtFecha.Value = New Date(2006, 3, 23, 0, 0, 0, 0)
        '
        'DsAbonosapartados1
        '
        Me.DsAbonosapartados1.DataSetName = "DsAbonosapartados"
        Me.DsAbonosapartados1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsAbonosapartados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Gray
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(544, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 183
        Me.Label19.Text = "Tipo Cambio"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Controls.Add(Me.dtEmitida)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIntereses)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(320, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 103)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        '
        'lbSimbolo6
        '
        Me.lbSimbolo6.BackColor = System.Drawing.Color.Transparent
        Me.lbSimbolo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbSimbolo6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.lbSimbolo5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.lbSimbolo4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.lbSimbolo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.lbSimbolo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.txtSaldoAnt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAnt.Properties.Enabled = False
        Me.txtSaldoAnt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoAnt.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoAnt.Size = New System.Drawing.Size(96, 17)
        Me.txtSaldoAnt.TabIndex = 3
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
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(192, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Saldo Previo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(5, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Fecha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(5, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Aparta. No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIntereses
        '
        Me.txtIntereses.EditValue = ""
        Me.txtIntereses.Location = New System.Drawing.Point(264, -9)
        Me.txtIntereses.Name = "txtIntereses"
        '
        '
        '
        Me.txtIntereses.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtIntereses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIntereses.Properties.Enabled = False
        Me.txtIntereses.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtIntereses.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtIntereses.Size = New System.Drawing.Size(8, 17)
        Me.txtIntereses.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(320, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(394, 16)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Datos de la Factura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(624, 56)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(96, 16)
        Me.txtTipoCambio.TabIndex = 182
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Factura.Caption = "Apartado No."
        Me.Factura.FieldName = "Id_Apartado"
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
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Fecha.Visible = True
        Me.Fecha.Width = 115
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(544, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DataSource = Me.DsAbonosapartados1.Moneda
        Me.ComboMoneda.DisplayMember = "MonedaNombre"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.Enabled = False
        Me.ComboMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboMoneda.Location = New System.Drawing.Point(624, 32)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(97, 21)
        Me.ComboMoneda.TabIndex = 1
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.Gray
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(544, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 16)
        Me.Label30.TabIndex = 179
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(536, 65)
        Me.GroupBox6.TabIndex = 175
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del cliente"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(13, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 13)
        Me.txtCodigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
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
        Me.Label2.ForeColor = System.Drawing.Color.Gray
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
        'GridControl2
        '
        Me.GridControl2.DataMember = "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle"
        Me.GridControl2.DataSource = Me.DsAbonosapartados1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 224)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(704, 184)
        Me.GridControl2.TabIndex = 184
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactura, Me.colMonto, Me.colSaldo_Ant, Me.colIntereses, Me.colAbono, Me.colSaldo})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFactura
        '
        Me.colFactura.Caption = "N.Apartado"
        Me.colFactura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFactura.FieldName = "apartado"
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
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto Apar."
        Me.colMonto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo4
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 1
        '
        'colSaldo_Ant
        '
        Me.colSaldo_Ant.Caption = "Saldo Ant."
        Me.colSaldo_Ant.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo_Ant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo_Ant.FieldName = "Saldo_Ant"
        Me.colSaldo_Ant.FilterInfo = ColumnFilterInfo5
        Me.colSaldo_Ant.Name = "colSaldo_Ant"
        Me.colSaldo_Ant.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo_Ant.VisibleIndex = 2
        '
        'colIntereses
        '
        Me.colIntereses.Caption = "Intereses"
        Me.colIntereses.DisplayFormat.FormatString = "#,#0.00"
        Me.colIntereses.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIntereses.FieldName = "Intereses"
        Me.colIntereses.FilterInfo = ColumnFilterInfo6
        Me.colIntereses.Name = "colIntereses"
        Me.colIntereses.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colIntereses.SortIndex = 0
        Me.colIntereses.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.colIntereses.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colAbono
        '
        Me.colAbono.Caption = "Abono"
        Me.colAbono.DisplayFormat.FormatString = "#,#0.00"
        Me.colAbono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAbono.FieldName = "Abono"
        Me.colAbono.FilterInfo = ColumnFilterInfo7
        Me.colAbono.Name = "colAbono"
        Me.colAbono.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colAbono.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colAbono.VisibleIndex = 3
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo Act."
        Me.colSaldo.DisplayFormat.FormatString = "#,#0.00"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.FilterInfo = ColumnFilterInfo8
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo.VisibleIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtSaldoActGen)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtAbonoGen)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtSaldoAntGen)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox2.Location = New System.Drawing.Point(478, 455)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 77)
        Me.GroupBox2.TabIndex = 185
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos de cuenta"
        '
        'txtSaldoActGen
        '
        Me.txtSaldoActGen.EditValue = "0"
        Me.txtSaldoActGen.Location = New System.Drawing.Point(113, 54)
        Me.txtSaldoActGen.Name = "txtSaldoActGen"
        '
        '
        '
        Me.txtSaldoActGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoActGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoActGen.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoActGen.Size = New System.Drawing.Size(107, 19)
        Me.txtSaldoActGen.TabIndex = 162
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(19, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 161
        Me.Label18.Text = "Saldo Act."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbonoGen
        '
        Me.txtAbonoGen.EditValue = ""
        Me.txtAbonoGen.Location = New System.Drawing.Point(113, 33)
        Me.txtAbonoGen.Name = "txtAbonoGen"
        '
        '
        '
        Me.txtAbonoGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAbonoGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbonoGen.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtAbonoGen.Size = New System.Drawing.Size(107, 19)
        Me.txtAbonoGen.TabIndex = 160
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(19, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Monto Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoAntGen
        '
        Me.txtSaldoAntGen.EditValue = "0"
        Me.txtSaldoAntGen.Location = New System.Drawing.Point(113, 13)
        Me.txtSaldoAntGen.Name = "txtSaldoAntGen"
        '
        '
        '
        Me.txtSaldoAntGen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAntGen.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSaldoAntGen.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtSaldoAntGen.Size = New System.Drawing.Size(107, 19)
        Me.txtSaldoAntGen.TabIndex = 158
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(17, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Saldo Ant."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ad_Abonoapartados
        '
        Me.Ad_Abonoapartados.DeleteCommand = Me.SqlDeleteCommand1
        Me.Ad_Abonoapartados.InsertCommand = Me.SqlInsertCommand1
        Me.Ad_Abonoapartados.SelectCommand = Me.SqlSelectCommand1
        Me.Ad_Abonoapartados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Abono_Apartados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_abonoapartado", "Id_abonoapartado"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Saldo_Cuenta", "Saldo_Cuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Actual", "Saldo_Actual"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Num_Recibo", "Num_Recibo")})})
        Me.Ad_Abonoapartados.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_abonoapartado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_abonoapartado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Recibo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Cuenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Cuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-T96OM6J\DESARROLLO;Initial Catalog=seepos;Integrated Security" & _
            "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 8, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 8, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Num_Recibo", System.Data.SqlDbType.BigInt, 8, "Num_Recibo")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_abonoapartado, Cod_Cliente, Nombre_Cliente, Saldo_Cuenta, Monto, Saldo_" & _
            "Actual, Fecha, Observaciones, Anula, Ced_Usuario, Cod_Moneda, Num_Recibo FROM Ab" & _
            "ono_Apartados"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 8, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 8, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Num_Recibo", System.Data.SqlDbType.BigInt, 8, "Num_Recibo"), New System.Data.SqlClient.SqlParameter("@Original_Id_abonoapartado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_abonoapartado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Recibo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo_Cuenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo_Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_abonoapartado", System.Data.SqlDbType.BigInt, 8, "Id_abonoapartado")})
        '
        'Ad_detalleabonoapartado
        '
        Me.Ad_detalleabonoapartado.DeleteCommand = Me.SqlDeleteCommand2
        Me.Ad_detalleabonoapartado.InsertCommand = Me.SqlInsertCommand2
        Me.Ad_detalleabonoapartado.SelectCommand = Me.SqlSelectCommand2
        Me.Ad_detalleabonoapartado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Abono_apartadosdetalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_detalleabono", "id_detalleabono"), New System.Data.Common.DataColumnMapping("Id_abonoapartado", "Id_abonoapartado"), New System.Data.Common.DataColumnMapping("apartado", "apartado"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Ant", "Saldo_Ant"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("Abono", "Abono"), New System.Data.Common.DataColumnMapping("Abono_SuMoneda", "Abono_SuMoneda"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.Ad_detalleabonoapartado.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [Abono_apartadosdetalle] WHERE (([id_detalleabono] = @Original_id_det" & _
            "alleabono))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_detalleabono", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_detalleabono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_abonoapartado", System.Data.SqlDbType.BigInt, 0, "Id_abonoapartado"), New System.Data.SqlClient.SqlParameter("@apartado", System.Data.SqlDbType.BigInt, 0, "apartado"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 0, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Float, 0, "Intereses"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 0, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 0, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 0, "Saldo")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_detalleabono, Id_abonoapartado, apartado, Monto, Saldo_Ant, Intereses, " & _
            "Abono, Abono_SuMoneda, Saldo FROM Abono_apartadosdetalle"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_abonoapartado", System.Data.SqlDbType.BigInt, 0, "Id_abonoapartado"), New System.Data.SqlClient.SqlParameter("@apartado", System.Data.SqlDbType.BigInt, 0, "apartado"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 0, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Float, 0, "Intereses"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 0, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 0, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 0, "Saldo"), New System.Data.SqlClient.SqlParameter("@Original_id_detalleabono", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_detalleabono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_detalleabono", System.Data.SqlDbType.BigInt, 8, "id_detalleabono")})
        '
        'admoneda
        '
        Me.admoneda.SelectCommand = Me.SqlSelectCommand3
        Me.admoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("cuentacontable", "cuentacontable")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo, cuentacontable " & _
            "FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 512)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 186
        Me.CheckBox1.Text = "Anulado"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(272, 512)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(176, 13)
        Me.txtNombreUsuario.TabIndex = 187
        '
        'txtAbonoB
        '
        Me.txtAbonoB.EditValue = ""
        Me.txtAbonoB.Location = New System.Drawing.Point(152, 128)
        Me.txtAbonoB.Name = "txtAbonoB"
        '
        '
        '
        Me.txtAbonoB.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbonoB.Size = New System.Drawing.Size(8, 19)
        Me.txtAbonoB.TabIndex = 188
        '
        'txtAbonoSuMoneda
        '
        Me.txtAbonoSuMoneda.EditValue = ""
        Me.txtAbonoSuMoneda.Location = New System.Drawing.Point(160, 160)
        Me.txtAbonoSuMoneda.Name = "txtAbonoSuMoneda"
        '
        '
        '
        Me.txtAbonoSuMoneda.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtAbonoSuMoneda.Size = New System.Drawing.Size(8, 19)
        Me.txtAbonoSuMoneda.TabIndex = 189
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(325, 511)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(10, 10)
        Me.txtCedulaUsuario.TabIndex = 190
        '
        'txtNum_Recibo
        '
        Me.txtNum_Recibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNum_Recibo.Enabled = False
        Me.txtNum_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum_Recibo.Location = New System.Drawing.Point(88, 16)
        Me.txtNum_Recibo.Name = "txtNum_Recibo"
        Me.txtNum_Recibo.Size = New System.Drawing.Size(72, 13)
        Me.txtNum_Recibo.TabIndex = 191
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(128, 512)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 192
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(208, 512)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
        '
        'TBrecibo
        '
        Me.TBrecibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TBrecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAbonosapartados1, "Abono_Apartados.Id_abonoapartado", True))
        Me.TBrecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBrecibo.ForeColor = System.Drawing.Color.White
        Me.TBrecibo.Location = New System.Drawing.Point(672, 8)
        Me.TBrecibo.Name = "TBrecibo"
        Me.TBrecibo.Size = New System.Drawing.Size(40, 12)
        Me.TBrecibo.TabIndex = 194
        Me.TBrecibo.Text = "000"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Recibo N°"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtObservaciones.Location = New System.Drawing.Point(104, 424)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(616, 16)
        Me.txtObservaciones.TabIndex = 196
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(0, 424)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 12)
        Me.Label29.TabIndex = 197
        Me.Label29.Text = "Observaciones:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gridFacturas
        '
        Me.gridFacturas.DataMember = Nothing
        '
        '
        '
        Me.gridFacturas.EmbeddedNavigator.Name = ""
        Me.gridFacturas.Location = New System.Drawing.Point(10, 100)
        Me.gridFacturas.MainView = Me.GridView1
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.Size = New System.Drawing.Size(304, 107)
        Me.gridFacturas.TabIndex = 198
        Me.gridFacturas.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_factura, Me.col_fecha})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_factura
        '
        Me.col_factura.Caption = "factura"
        Me.col_factura.FieldName = "Id_Apartado"
        Me.col_factura.FilterInfo = ColumnFilterInfo9
        Me.col_factura.Name = "col_factura"
        Me.col_factura.VisibleIndex = 0
        '
        'col_fecha
        '
        Me.col_fecha.Caption = "fecha"
        Me.col_fecha.FieldName = "Fecha"
        Me.col_fecha.FilterInfo = ColumnFilterInfo10
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.VisibleIndex = 1
        '
        'lbanulado
        '
        Me.lbanulado.AutoSize = True
        Me.lbanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbanulado.ForeColor = System.Drawing.Color.Red
        Me.lbanulado.Location = New System.Drawing.Point(187, 210)
        Me.lbanulado.Name = "lbanulado"
        Me.lbanulado.Size = New System.Drawing.Size(349, 73)
        Me.lbanulado.TabIndex = 199
        Me.lbanulado.Text = "ANULADO"
        Me.lbanulado.Visible = False
        '
        'Abono_Apartados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(724, 533)
        Me.Controls.Add(Me.lbanulado)
        Me.Controls.Add(Me.gridFacturas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBrecibo)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNum_Recibo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtCedulaUsuario)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboMoneda)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txtAbonoB)
        Me.Controls.Add(Me.txtAbonoSuMoneda)
        Me.Name = "Abono_Apartados"
        Me.Text = "Abono_Apartados"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.txtAbonoSuMoneda, 0)
        Me.Controls.SetChildIndex(Me.txtAbonoB, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.ComboMoneda, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtTipoCambio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.dtFecha, 0)
        Me.Controls.SetChildIndex(Me.txtCedulaUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.GridControl2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNum_Recibo, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.TBrecibo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.gridFacturas, 0)
        Me.Controls.SetChildIndex(Me.lbanulado, 0)
        CType(Me.DsAbonosapartados1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntereses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtSaldoActGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAntGen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoSuMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Binding"
    Sub binding()
        txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Abono_Apartados.Cod_Cliente"))
        txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Abono_Apartados.Nombre_Cliente"))
        txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Abono_Apartados.Observaciones"))

        txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Abono_Apartados.Ced_Usuario"))
        dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Abono_Apartados.Fecha"))
        txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Moneda.ValorVenta"))
        lbSimbolo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Moneda.Simbolo"))

        txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.Monto"))
        txtSaldo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.Saldo_Ant"))
        txtSaldoAct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.Saldo"))
        txtIntereses.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.Intereses"))
        txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.apartado"))
        txtAbonoB.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.Abono"))
        txtAbonoSuMoneda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle.Abono_SuMoneda"))
        txtSaldoActGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Saldo_Actual"))
        txtAbonoGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Monto"))
        txtSaldoAntGen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsAbonosapartados1, "Abono_Apartados.Saldo_Cuenta"))

        CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", DsAbonosapartados1, "Abono_Apartados.Anula"))
        txtNum_Recibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsAbonosapartados1, "Abono_Apartados.Num_Recibo"))
        ComboMoneda.DataSource = DsAbonosapartados1
        ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        GridControl2.DataMember = "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle"
        GridControl2.DataSource = DsAbonosapartados1
        ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DsAbonosapartados1, "Abono_Apartados.Cod_Moneda"))
    End Sub
#End Region

#Region "Variables"
    Dim tabla As DataTable
    Public tipo As String
    Dim Interes As Double
    Public Trans As SqlTransaction
    Dim TipoCambioFact As Double
    Public usua As Object
    Dim PMU As New PerfilModulo_Class
    Dim TipoCambio As Double
    Public codigoclie As Integer
    Public nombrecli As String
    Public primerabono As Boolean
    Public general As Double
    Dim FrmVuelto As New Vuelto
    Dim FacturaPVE As New Reporte_FacturaPVEs
    Dim Factura_Generica As New Factura_Generica
#End Region

#Region "Load"
    Private Sub Abono_Apartados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = GetSetting("SeeSOFT", "SeePos", "Conexion")
        admoneda.Fill(DsAbonosapartados1, "Moneda")

        valoresdefecto()
        binding()
        CrystalReportsConexion.LoadReportViewer(Nothing, FacturaPVE, True)
        If primerabono Then
            txtSaldoAntGen.Text = general
            txtCodigo.Text = codigoclie
            txtNombre.Text = nombrecli
            login2()
            ComboMoneda.Focus()
        Else
            txtCedulaUsuario.Focus()
        End If
    End Sub

    Public Sub load2()
        SqlConnection1.ConnectionString = GetSetting("SeeSOFT", "SeePos", "Conexion")
        admoneda.Fill(DsAbonosapartados1, "Moneda")
        txtTipoCambio.Text = tipo
    End Sub
#End Region

#Region "Logind 2"
    Sub login2()
        Try
            PMU = VSM(usua.Cedula, Name)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Buscar Apartados del cliente"
    Public Function buscarapartadosdecliente(ByVal CodigoCliente As Integer) As DataTable
        Dim dt As New DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM Apartados WHERE dbo.Saldoapartado(getdate(),id_apartado) > 0 and Id_Cliente = " & CodigoCliente & " and Anulado = 0 and Cancelado=0 ", dt)
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            'If Not cnn Is Nothing Then
            'cnn.Close()
            'End If
        End Try
        ' Devolvemos el objeto DataTable con los datos de la consulta
        Return dt

    End Function

#End Region

#Region "Grid"
    Private Sub gridFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
#End Region

#Region "Informacion apartado"

    Private Sub informacionfactura(ByVal factura As Double)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim Codigo As Integer
        Dim rs As SqlDataReader
        Dim Conexion2 As New Conexion

        Dim DiasAtraso As Double
        Dim FechaUltAbono As String

        If factura <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT  Id_Apartado, Fecha, Vence, Total FROM Apartados  where Id_Apartado=" & factura)
            While rs.Read
                Try

                    BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").CancelCurrentEdit()
                    BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").EndCurrentEdit()
                    BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").AddNew()
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
                Try
                    'Codigo = rs("Cod_moneda")
                    Codigo = 1
                    TipoCambioFact = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select ValorVenta from Moneda Where CodMoneda =" & Codigo)
                    Conexion2.DesConectar(Conexion2.Conectar)
                    Interes = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select Intereses from configuraciones")
                    Conexion2.DesConectar(Conexion2.Conectar)
                    DiasAtraso = DateDiff(DateInterval.Day, rs("Vence"), Date.Now)
                    txtFactura.Text = rs("Id_Apartado")
                    dtEmitida.Text = rs("Fecha")
                    txtMonto.Text = Format((rs("Total") * TipoCambioFact) / 1, "#,#0.00") ' txtTipoCambio.Text
                    txtSaldo.Text = Format(funciones.Saldo_deapartados(factura, (rs("Total") * 1) / 1, 1, 1), "#,#0.00") ' txtTipoCambio.Text,txtTipoCambio.Text,
                    FechaUltAbono = Conexion2.SlqExecuteScalar(Conexion2.Conectar, "Select ISNULL(MAX(Fecha), 0) from UltimoAbonoapartados where  Id_abonoapartado = " & txtFactura.Text)
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
                    txtSaldoAnt.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtIntereses.Text), "#,#0.00")
                    txtAbono.Enabled = True
                    txtAbono.Text = Format(CDbl(txtSaldoAnt.Text), "#,#0.00")
                    txtAbono.SelectAll()
                    txtAbono.Focus()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End While
            Conexion2 = Nothing
            cConexion.DesConectar(cConexion.Conectar)
            cConexion = Nothing
        End If
    End Sub

#End Region

#Region "Cargar informacion cliente"
    Public Sub CargarInformacionCliente(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader

        ' buscartramitespendientes(codigo)


        If codigo <> Nothing Then

            rs = cConexion.GetRecorset(cConexion.Conectar, "select identificacion as Identificacion,nombre as Nombre from Clientes_frecuentes where identificacion='" & codigo & "'")

            Try
                If rs.Read Then
                    txtCodigo.Text = rs("Identificacion")
                    txtNombre.Text = rs("Nombre")
                    'DT_actual.Focus()
                    tabla = buscarapartadosdecliente(txtCodigo.Text)
                    If tabla.Rows.Count <> 0 Then
                        gridFacturas.DataSource = tabla
                        gridFacturas.Enabled = True
                        Saldo_Cuenta(tabla)
                        ComboMoneda.Focus()
                    Else
                        MsgBox("Este  Cliente no tiene apartados pendientes", MsgBoxStyle.Information, "Atención...")
                        gridFacturas.Enabled = False
                        txtCodigo.SelectAll()
                        txtCodigo.Focus()

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
#End Region

#Region "Buscar"
    Private Sub BuscarAbono()
        Dim Fx As New cFunciones
        Dim identificador As Double
        Dim buscando As Boolean
        Try
            If BindingContext(DsAbonosapartados1, "Abono_Apartados").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Recibo de Dinero, si continúa se perderan los datos del Recibo actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            DsAbonosapartados1.Abono_apartadosdetalle.Clear()
            DsAbonosapartados1.Abono_Apartados.Clear()
            ToolBarNuevo.Text = "Nuevo"
            ToolBarNuevo.ImageIndex = 0
            ToolBarRegistrar.Enabled = False
            ToolBarEliminar.Enabled = False
            ToolBarImprimir.Enabled = False

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha5C("SELECT Abono_Apartados.Id_abonoapartado, Abono_Apartados.Num_Recibo as Recibo, Abono_Apartados.Nombre_Cliente AS Nombre_Cliente, Abono_Apartados.Fecha,Abono_Apartados.Monto FROM         Moneda INNER JOIN Abono_Apartados ON Moneda.CodMoneda = Abono_Apartados.Cod_Moneda ORDER BY Abono_Apartados.Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Recibo de Dinero"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Exit Sub
            End If
            'Check_Dig_Recibo.Enabled = False
            ComboMoneda.Enabled = False
            LlenarVentas(identificador)
            If CheckBox1.Checked = True Then
                Me.lbanulado.Visible = True
            Else
                Me.lbanulado.Visible = False
            End If
            ' si esta venta aun no ha sido anulada
            If BindingContext(DsAbonosapartados1, "Abono_Apartados").Current("Anula") = False Then ToolBarEliminar.Enabled = True
            txtCodigo.Enabled = False
            GridControl2.Enabled = False
            ToolBarImprimir.Enabled = True

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
            IdRec = CInt(cConexion.SlqExecuteScalar(cConexion.Conectar, "Select Id_abonoapartado from Abono_Apartados where Id_abonoapartado =" & Id))
            cConexion.DesConectar(cConexion.Conectar)
            '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            DsAbonosapartados1.Abono_apartadosdetalle.Clear()
            DsAbonosapartados1.Abono_Apartados.Clear()
            Dim sConn As String = GetSetting("SeeSOFT", "SeePos", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Abono_Apartados WHERE (Id_abonoapartado = " & Id & ")"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            'cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            'cmdv.Parameters("@Id_Factura").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(DsAbonosapartados1, "Abono_Apartados")
            '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM Abono_apartadosdetalle WHERE (Id_abonoapartado = " & Id & ") "
            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            'cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))
            ' cmd.Parameters("@Id_Factura").Value = IdRec
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(DsAbonosapartados1.Abono_apartadosdetalle)
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

#End Region

#Region "Anular Abono"
    Private Sub AnularAbono()
        Dim Funciones As New Conexion
        Dim apartado As Integer
        apartado = BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").Current("apartado")
        Try
            Dim resp As Integer
            If BindingContext(DsAbonosapartados1, "Abono_Apartados").Count > 0 Then
                If BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Anular este Abono?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        If (Funciones.UpdateRecords("Apartados", "Cancelado = 0", "Id_Apartado =" & apartado & "")) <> "" Then
                            MsgBox("Problemas al Registrar las facturas como canceladas!", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        BindingContext(DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()

                        If registrar_Abono() Then
                            DsAbonosapartados1.AcceptChanges()
                            MsgBox("El abono de apartado ha sido anulado correctamente!", MsgBoxStyle.Information)
                            DsAbonosapartados1.Abono_apartadosdetalle.Clear()
                            DsAbonosapartados1.Abono_Apartados.Clear()
                            ToolBar1.Buttons(1).Enabled = True
                            ToolBar1.Buttons(0).Text = "Nuevo"
                            ToolBar1.Buttons(0).ImageIndex = 0
                            ToolBar1.Buttons(3).Enabled = False
                            ToolBar1.Buttons(2).Enabled = False
                            ToolBar1.Buttons(4).Enabled = False

                            txtUsuario.Enabled = True
                            txtUsuario.Text = ""
                            txtNombreUsuario.Text = ""
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
#End Region

#Region "Nuevo"
    Public Sub Nuevo_abono()
        ToolBarEliminar.Enabled = False
        ToolBarImprimir.Enabled = False
        ToolBarBuscar.Enabled = True

        If ToolBarNuevo.Text = "Cancelar" Then
            BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").CancelCurrentEdit()
            BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").EndCurrentEdit()
            BindingContext(DsAbonosapartados1, "Abono_Apartados").CancelCurrentEdit()
            BindingContext(DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()
            DsAbonosapartados1.Abono_apartadosdetalle.Clear()
            DsAbonosapartados1.Abono_Apartados.Clear()
            ToolBarNuevo.Text = "Nuevo"
            inhabilitar()
            ToolBarNuevo.ImageIndex = 0
            ToolBarRegistrar.Enabled = False
            Exit Sub
        End If
        If ToolBarNuevo.Text = "Nuevo" Then
            ToolBarNuevo.ImageIndex = 8
            ToolBarNuevo.Text = "Cancelar"
            txtCodigo.Enabled = True
            habilitar()
            ToolBarNuevo.Enabled = True
            ToolBarRegistrar.Enabled = True
            Try
                gridFacturas.DataSource = tabla
                DsAbonosapartados1.Abono_apartadosdetalle.Clear()
                DsAbonosapartados1.Abono_Apartados.Clear()
                Me.BindingContext(DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()
                Me.BindingContext(DsAbonosapartados1, "Abono_Apartados").AddNew()
                iniciar_factura()
                habilitar()
                txtNum_Recibo.Text = Numero_de_Recibo()
            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub iniciar_factura()
        Try
            Dim nom As String = Me.txtNombre.Text

            txtNombre.Text = nom

            If Me.txtCodigo.Text = "" Then
                Me.txtCodigo.Text = "0"
            End If
            If Me.BindingContext(Me.DsAbonosapartados1, "Abono_Apartados").Count = 1 Then
                Me.BindingContext(Me.DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()
            End If

            Me.ToolBar1.Buttons(2).Enabled = True 'se activa el botond e guardar
            limpiartxt()
            Me.BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").CancelCurrentEdit()
            Me.BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").EndCurrentEdit()
            Me.BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").AddNew()
            txtCodigo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Limpiar txt"
    Sub limpiartxt()
        txtAbono.Text = "0"
        txtSaldoAct.Text = ""
        txtSaldoAnt.Text = "0"
        txtSaldo.Text = ""
        txtMonto.Text = ""
        txtFactura.Text = ""
    End Sub

#End Region

#Region "Valores defecto"
    Sub valoresdefecto()
        'abonoapartados
        DsAbonosapartados1.Abono_Apartados.Id_abonoapartadoColumn.AutoIncrement = True
        DsAbonosapartados1.Abono_Apartados.Id_abonoapartadoColumn.AutoIncrementSeed = -1
        DsAbonosapartados1.Abono_Apartados.Id_abonoapartadoColumn.AutoIncrementStep = -1
        DsAbonosapartados1.Abono_Apartados.Cod_ClienteColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_Apartados.Nombre_ClienteColumn.DefaultValue = ""
        DsAbonosapartados1.Abono_Apartados.Saldo_CuentaColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_Apartados.MontoColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_Apartados.Saldo_ActualColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_Apartados.FechaColumn.DefaultValue = Now
        DsAbonosapartados1.Abono_Apartados.ObservacionesColumn.DefaultValue = ""
        DsAbonosapartados1.Abono_Apartados.AnulaColumn.DefaultValue = False
        DsAbonosapartados1.Abono_Apartados.Ced_UsuarioColumn.DefaultValue = ""
        DsAbonosapartados1.Abono_Apartados.Cod_MonedaColumn.DefaultValue = 1
        DsAbonosapartados1.Abono_Apartados.Num_ReciboColumn.DefaultValue = 0

        'abonoapartadosdetalle
        DsAbonosapartados1.Abono_apartadosdetalle.id_detalleabonoColumn.AutoIncrement = True
        DsAbonosapartados1.Abono_apartadosdetalle.id_detalleabonoColumn.AutoIncrementSeed = -1
        DsAbonosapartados1.Abono_apartadosdetalle.id_detalleabonoColumn.AutoIncrementStep = -1

        ' DsAbonosapartados1.Abono_apartadosdetalle.Id_abonoapartadoColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.apartadoColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.MontoColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.SaldoColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.Saldo_AntColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.InteresesColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.AbonoColumn.DefaultValue = 0
        DsAbonosapartados1.Abono_apartadosdetalle.Abono_SuMonedaColumn.DefaultValue = 1



    End Sub
#End Region

#Region "Controles"
    Sub habilitar()
        ComboMoneda.Enabled = True
        GroupBox1.Enabled = True
        txtCodigo.Enabled = True
        GroupBox6.Enabled = True
    End Sub
    Sub inhabilitar()
        ToolBarImprimir.Enabled = False
        ToolBarRegistrar.Enabled = False
        ToolBarEliminar.Enabled = False
        txtCodigo.Enabled = False
        GroupBox1.Enabled = False
    End Sub
#End Region

#Region "Controles"
    Private Sub txtIntereses_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIntereses.KeyDown
        Dim Temp As Double
        If e.KeyData = Keys.Enter Then
            Try
                Temp = CDbl(txtIntereses.Text)

                If txtIntereses.Text = "" Then txtIntereses.Text = "0.00"
                txtSaldoAnt.Text = Format(CDbl(txtSaldo.Text) + CDbl(txtIntereses.Text), "#,#0.00")
                txtAbono.Enabled = True
                txtAbono.Text = Format(CDbl(txtSaldoAnt.Text), "#,#0.00")
                txtAbono.Focus()
            Catch ex As Exception
                MessageBox.Show("No era un númerico, favor volver a ingresar el monto", "SeePos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIntereses.Text = 0
                txtIntereses.Focus()
            End Try
        End If
    End Sub

    Private Sub txtAbono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbono.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
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
                    BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").EndCurrentEdit()
                    int = colIntereses.SummaryItem.SummaryValue
                    ab = colAbono.SummaryItem.SummaryValue
                    txtAbonoGen.Text = Format(ab + int, "#,#0.00")
                    txtSaldoActGen.Text = Format((CDbl(txtSaldoAntGen.Text) + CDbl(colIntereses.SummaryItem.SummaryValue)) - txtAbonoGen.Text, "#,#0.00")
                    'If BindingContext(tabla).Current("Id_Apartado") = txtFactura.EditValue Then
                    '    BindingContext(tabla).RemoveAt(BindingContext(tabla).Position())
                    'End If
                    '''' preguntar a diego por q hace esto
                End If
            End If

            If e.KeyCode = Keys.F2 Then
                If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Error este campo se requiere un númerico", "SeePos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAbono.Text = 0
            txtAbono.Focus()
        End Try
    End Sub
#Region "Saldo cuenta"
    Sub Saldo_Cuenta(ByVal Tabla1 As DataTable)
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
            facturatemp = fila("Id_Apartado")
            Totaltemp = fila("Total")
            CodigoMoneda = fila("Cod_Moneda")
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT ValorVenta from Moneda where CodMoneda =" & CodigoMoneda)
            If rs.Read Then ValorFactura = rs("ValorVenta")
            rs.Close()
            ConexionLocal.DesConectar(ConexionLocal.Conectar)
            SaldoCuenta = SaldoCuenta + funciones.Saldo_deapartados(facturatemp, ((Totaltemp * ValorFactura) / TipoCambio), ValorFactura, TipoCambio)
        Next
        ConexionLocal = Nothing
        txtSaldoAntGen.Text = Format(SaldoCuenta, "#,#0.00")
    End Sub
#End Region

    Private Sub txtAbono_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAbono.MouseDown
        Try
            If Keys.KeyCode = Keys.Enter Then
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
                    BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").EndCurrentEdit()
                    int = colIntereses.SummaryItem.SummaryValue
                    ab = colAbono.SummaryItem.SummaryValue
                    txtAbonoGen.Text = Format(ab + int, "#,#0.00")
                    txtSaldoActGen.Text = Format(txtSaldoAntGen.Text + colIntereses.SummaryItem.SummaryValue - txtAbonoGen.Text, "#,#0.00")
                    If BindingContext(tabla).Current("Id_Apartado") = txtFactura.EditValue Then
                        BindingContext(tabla).RemoveAt(BindingContext(tabla).Position())
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error este campo se requiere un númerico", "SeePos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAbono.Text = 0
            txtAbono.Focus()
        End Try
    End Sub
#End Region

#Region "Registrar"

    Function _Buscar_Apertura(ByVal usuario As String) As Boolean
        Try
            Dim conex As New Conexion
            Dim i As Integer
            i = conex.SQLExeScalar("SELECT COUNT(NApertura) FROM AperturaCaja WHERE (Anulado = 0) AND (Estado = 'A') AND (Cedula = '" & usuario & "')")
            Select Case i
                Case 1
                    Return True
                Case 0
                    MsgBox(Usua.Nombre & " " & "No tiene una apertura de caja abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
                Case Else
                    MsgBox(Usua.Nombre & " " & "tiene mas de una abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Private Sub Registrar()
        Dim Funciones As New Conexion

        Try
            If PMU.Update Then  Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            If BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").Count = 0 Then
                MsgBox("Debe abonar mínimo una factura", MsgBoxStyle.Information)
                Exit Sub
            End If
            ' If _Buscar_Apertura(usua.Cedula) Then

            If MessageBox.Show("¿Desea guardar el recibo de dinero?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                BindingContext(DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()
                txtNum_Recibo.Text = Numero_de_Recibo()
                BindingContext(DsAbonosapartados1, "Abono_Apartados").Current("Ced_Usuario") = usua.Cedula
                BindingContext(DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()
                BindingContext(DsAbonosapartados1, "Abono_Apartados.Abono_Apartados_Abono_apartadosdetalle").EndCurrentEdit()

                'llamar al formulario de opciones de pago
                Dim Movimiento_Pago_Abonos As New frmMovimientoCajaPagoAbono(usua)
                Movimiento_Pago_Abonos.Factura = CDbl(txtNum_Recibo.Text)
                Movimiento_Pago_Abonos.fecha = dtFecha.Value
                Movimiento_Pago_Abonos.Total = CDbl(txtAbonoGen.Text)
                Movimiento_Pago_Abonos.Tipo = "ABA"
                Movimiento_Pago_Abonos.codmod = ComboMoneda.SelectedValue
                Movimiento_Pago_Abonos.ShowDialog()
                FrmVuelto.MontoVuelto = Movimiento_Pago_Abonos.vuelto


                If Movimiento_Pago_Abonos.Registra Then
                    If registrar_Abono() And Movimiento_Pago_Abonos.RegistrarOpcionesPago() Then
                        ToolBar1.Buttons(1).Enabled = True
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0
                        ToolBarRegistrar.Enabled = False
                        ToolBarEliminar.Enabled = False
                        ToolBarImprimir.Enabled = False
                        FrmVuelto.ShowDialog()
                        open_cashdrawer()
                        limpiartxt()
                        If MessageBox.Show("¿Desea imprimir este Abono?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            imprimir()
                        End If
                        ImprimeFacturas()
                        tabla.Clear()
                        DsAbonosapartados1.Abono_apartadosdetalle.Clear()
                        DsAbonosapartados1.Abono_Apartados.Clear()
                        If primerabono Then
                            Me.Close()
                        End If
                    Else
                        MsgBox("Problemas al registrar el abono y/o pagos, intentelo de nuevo! ", MsgBoxStyle.Critical)
                        Trans.Rollback()
                        Movimiento_Pago_Abonos.Trans.Rollback()
                        Exit Sub
                    End If
                End If
            End If
            'Else
            '    Me.txtNombreUsuario.Text = ""
            '    Me.txtUsuario.Text = ""
            '    Me.txtUsuario.Enabled = True
            'End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function registrar_Abono() As Boolean
        If SqlConnection1.State <> ConnectionState.Open Then SqlConnection1.Open()
        Trans = SqlConnection1.BeginTransaction
        Try
            Ad_Abonoapartados.InsertCommand.Transaction = Trans
            Ad_Abonoapartados.DeleteCommand.Transaction = Trans
            Ad_Abonoapartados.UpdateCommand.Transaction = Trans

            Ad_detalleabonoapartado.InsertCommand.Transaction = Trans
            Ad_detalleabonoapartado.DeleteCommand.Transaction = Trans
            Ad_detalleabonoapartado.UpdateCommand.Transaction = Trans

            Ad_Abonoapartados.Update(DsAbonosapartados1.Abono_Apartados)
            Ad_detalleabonoapartado.Update(DsAbonosapartados1.Abono_apartadosdetalle)
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            txtCodigo.Text = cFunciones.BuscarDatos("Select * FROM Cliente_cApartados", "Nombre")
            CargarInformacionCliente(txtCodigo.Text)

        End If
        If e.KeyCode = Keys.Enter Then
            If txtCodigo.Text <> "" Then
                CargarInformacionCliente(txtCodigo.Text)
            End If
        End If
    End Sub
    Private Function Numero_de_Recibo() As Double
        Dim cConexion As New Conexion
        Dim Num_Recibo As Double
        Num_Recibo = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT isnull(Max(Num_Recibo),0) FROM Abono_Apartados"))
        Numero_de_Recibo = Num_Recibo + 1
        cConexion.DesConectar(cConexion.Conectar)
    End Function

#End Region

#Region "Validacion Usuario"


    Private Sub txtUsuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

                        PMU = VSM(rs("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                        If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                        BindingContext(DsAbonosapartados1, "abonoccobrar").EndCurrentEdit()
                        BindingContext(DsAbonosapartados1, "abonoccobrar").AddNew()

                        txtNombreUsuario.Text = rs("Nombre")
                        txtCedulaUsuario.Text = rs("Cedula")
                        '  Check_Dig_Recibo.Enabled = True

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
                        Nuevo_abono()
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
#End Region

#Region "Imprimir"
    Sub imprimir()
        Dim reporteabo As New AbonoApartado
        reporteabo.PrintOptions.PrinterName = Automatic_Printer_Dialog(3) 'FACTURACION
        reporteabo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        reporteabo.SetParameterValue(0, DsAbonosapartados1.Abono_Apartados(0).Id_abonoapartado)
        CrystalReportsConexion.LoadReportViewer(Nothing, reporteabo, True)
        reporteabo.PrintToPrinter(1, True, 0, 0)
    End Sub

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION"
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
            End Select
        Next
        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If Windows.Forms.DialogResult.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        End If

    End Function

    Private Sub ImprimeFacturas()
        Try



            For i As Integer = 0 To DsAbonosapartados1.Abono_apartadosdetalle.Count - 1
                If DsAbonosapartados1.Abono_apartadosdetalle(i).Saldo = 0 Then
                    If MessageBox.Show("¿Desea imprimir la factura del Apartado " & DsAbonosapartados1.Abono_apartadosdetalle(i).apartado & " ?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                        'FacturaPVE.PrintOptions.PrinterName = Automatic_Printer_Dialog(3) 'FACTURACION
                        'FacturaPVE.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                        'FacturaPVE.SetParameterValue(0, IdFactura(DsAbonosapartados1.Abono_apartadosdetalle(i).apartado))
                        'FacturaPVE.SetParameterValue(1, 0)
                        'FacturaPVE.PrintToPrinter(1, True, 0, 0)
                        'ImprimirFactura(IdFactura(DsAbonosapartados1.Abono_apartadosdetalle(i).apartado))

                        Dim reportefactura As New Reporte_FacturaPVEs
                        reportefactura.PrintOptions.PrinterName = Automatic_Printer_Dialog(3) 'FACTURACION
                        reportefactura.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                        reportefactura.SetParameterValue(0, IdFactura(DsAbonosapartados1.Abono_apartadosdetalle(i).apartado))
                        reportefactura.SetParameterValue(1, 0)
                        CrystalReportsConexion.LoadReportViewer(Nothing, reportefactura, True)
                        reportefactura.PrintToPrinter(1, True, 0, 0)

                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ImprimirFactura(ByVal id_factura As Integer)
        'VERIFICA FORMATO DE IMPRESION - ORA
        Dim PVE As Boolean
        Try
            PVE = CBool(GetSetting("SeeSOFT", "SeePos", "FormatoPVE"))
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePos", "FormatoPVE", "True")
            PVE = True
        End Try
        Try

            If PVE Then
                imprimir(id_factura, True)

            Else
                imprimir(id_factura, False)
            End If

            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Imprimir(ByVal Id_Factura As Double, ByVal PVE As Boolean)
        Try
            Dim Sugerido As Boolean = False
            Dim NuevoSaldo As Double = 0

            If CDbl(txtCodigo.Text) <> 0 And txtCodigo.Text <> "" Then
                Dim func As New Conexion
                Sugerido = func.SQLExeScalar("SELECT ISNULL(PrecioSugerido,0) FROM Clientes WHERE Identificacion = " & CDbl(txtCodigo.Text))
            End If


            If PVE Then
                If Sugerido Then
                    'FacturaPVESug.PrintOptions.PrinterName = Automatic_Printer_Dialog(0)
                    'FacturaPVESug.SetParameterValue(0, Id_Factura)
                    'FacturaPVESug.SetParameterValue(1, Sugerido)
                    'FacturaPVESug.PrintToPrinter(1, True, 0, 0)
                Else
                    FacturaPVE.PrintOptions.PrinterName = Automatic_Printer_Dialog(3)
                    FacturaPVE.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                    FacturaPVE.SetParameterValue(0, Id_Factura)
                    FacturaPVE.SetParameterValue(1, NuevoSaldo)
                    CrystalReportsConexion.LoadReportViewer(Nothing, FacturaPVE, True)
                    FacturaPVE.PrintToPrinter(1, True, 0, 0)


                End If

            Else
                If Sugerido Then
                    'Factura_Generica.PrintOptions.PrinterName = Automatic_Printer_Dialog(0)
                    'Factura_Generica.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                    'Factura_Generica.SetParameterValue(0, Id_Factura)
                    'Factura_Generica.SetParameterValue(1, Sugerido)
                    'Factura_Generica.PrintToPrinter(1, True, 0, 0)

                Else
                    Factura_Generica.PrintOptions.PrinterName = Automatic_Printer_Dialog(3)
                    Factura_Generica.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                    Factura_Generica.SetParameterValue(0, Id_Factura)
                    Factura_Generica.SetParameterValue(1, NuevoSaldo)
                    Factura_Generica.PrintToPrinter(1, True, 0, 0)
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function IdFactura(ByVal Apartado As Double) As Integer
        Dim cConexion As New Conexion
        Try
            IdFactura = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT ISNULL(Id,0) FROM Ventas WHERE Apartado = " & Apartado))
            Return IdFactura
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cConexion.DesConectar(cConexion.Conectar)
        End Try
    End Function
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo_abono()
            Case 2 : If PMU.Find Then BuscarAbono() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then AnularAbono() Else MsgBox("No tiene permiso para anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                'Case 6 : BuscarCotizacion_importar()
                'Case 7 : ReciboDinero()
            Case 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Dispose(True) : Me.Close()
        End Select
    End Sub
#End Region

#Region "Validacion Usuario"
    Private Sub txtUsuario_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            validacion()
        End If
    End Sub
    Sub validacion()
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        If txtUsuario.Text <> "" Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
            If rs.HasRows = False Then
                MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                txtUsuario.Text = ""
                txtUsuario.Focus()
            End If
            While rs.Read
                Try
                    PMU = VSM(rs("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
                    txtNombreUsuario.Text = rs("Nombre")
                    txtCedulaUsuario.Text = rs("Cedula")
                    Nuevo_abono()
                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                    ToolBar1.Buttons(0).Enabled = True
                    ToolBar1.Buttons(1).Enabled = True

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

    End Sub
#End Region

#Region "Abrir Caja"
    Public Sub open_cashdrawer()
        Dim Puerto As String

        '------------------------------------------------------------------------------
        'VALIDA SI DESEA ABRIR CAJA O NO - ORA
        If GetSetting("SeeSoft", "SeePos", "PuertoImp") <> "NO" Then
            Dim intFileNo As Integer = FreeFile()
            FileOpen(1, "c:\escapes.txt", OpenMode.Output)
            PrintLine(1, Chr(27) & "p" & Chr(0) & Chr(25) & Chr(250))
            FileClose(1)

            '------------------------------------------------------------------------------
            'VALIDA EL PUERTO DE LA IMPRESORA - ORA
            Try
                Puerto = GetSetting("SeeSoft", "SeePos", "PuertoImp")
                If Puerto = "" Then
                    SaveSetting("SeeSoft", "SeePos", "PuertoImp", "COM1")
                    Puerto = "COM1"
                End If
            Catch ex As Exception
                SaveSetting("SeeSoft", "SeePos", "PuertoImp", "COM1")
                Puerto = "COM1"
            End Try
            '------------------------------------------------------------------------------

            Shell("print /d:" & Puerto & " c:\escapes.txt", AppWinStyle.NormalFocus)
        End If
        '------------------------------------------------------------------------------
    End Sub
#End Region

    Private Sub txtAbono_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbono.EditValueChanged

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

   
    Private Sub gridFacturas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridFacturas.Click
        Try

            'Dim hi1 As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = _
            '      GridView1.CalcHitInfo(CType(gridFacturas, Control).PointToClient(Control.MousePosition))

            Dim hi As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = _
                   GridView1.CalcHitInfo(CType(gridFacturas, Control).PointToClient(Control.MousePosition))
            Dim data As DataRow
            Dim factura As Double

            If hi.RowHandle >= 0 Then
                data = GridView1.GetDataRow(hi.RowHandle)
            ElseIf GridView1.FocusedRowHandle >= 0 Then
                data = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Else
                data = Nothing
            End If
            factura = data("Id_Apartado")
            BindingContext(DsAbonosapartados1, "Abono_Apartados").EndCurrentEdit()
            informacionfactura(factura)
        Catch ex As SyntaxErrorException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
