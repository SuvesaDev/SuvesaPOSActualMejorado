Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports System.Windows.Forms

Public Class frmReporteVentas
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daClientes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As ValidText.ValidText
    Friend WithEvents cbxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cbxCategoría As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategoría As System.Windows.Forms.Label

    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReporteVentas As DsReporteVentas
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents CBTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents ck_clientes_frecuentes As System.Windows.Forms.CheckBox
    Friend WithEvents daClientesFre As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TreeList1 As TreeView
    Friend WithEvents gpcliente As System.Windows.Forms.GroupBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detalladas")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detalladas X cliente")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Diarias")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reales")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Empleado")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Familia")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodo fiscal")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipo")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anuladas")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Taller")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detallas x rango")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas ", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contado y recuperacion")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas CON CRE")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comisiones", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General por cliente")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Venta General")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detalladas por empleado")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Devoluciones", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ganancias", New System.Windows.Forms.TreeNode() {TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de descuentos")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Descuento", New System.Windows.Forms.TreeNode() {TreeNode22})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteVentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TreeList1 = New System.Windows.Forms.TreeView()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ck_clientes_frecuentes = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbxCategoría = New System.Windows.Forms.ComboBox()
        Me.cbxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonto = New ValidText.ValidText()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboMonedas = New System.Windows.Forms.ComboBox()
        Me.DsReporteVentas = New LcPymes_5._2.DsReporteVentas()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblTipoCambio = New System.Windows.Forms.Label()
        Me.lblCategoría = New System.Windows.Forms.Label()
        Me.gpcliente = New System.Windows.Forms.GroupBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.daClientes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.daClientesFre = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsReporteVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.TreeList1)
        Me.GroupBox1.Controls.Add(Me.ck_clientes_frecuentes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboCaja)
        Me.GroupBox1.Controls.Add(Me.CBTipo)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.cbxCategoría)
        Me.GroupBox1.Controls.Add(Me.cbxEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.lblEmpleado)
        Me.GroupBox1.Controls.Add(Me.lblTipoCambio)
        Me.GroupBox1.Controls.Add(Me.lblCategoría)
        Me.GroupBox1.Controls.Add(Me.gpcliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 461)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList1.ImageIndex = 1
        Me.TreeList1.ImageList = Me.ImageList2
        Me.TreeList1.Location = New System.Drawing.Point(8, 18)
        Me.TreeList1.Name = "TreeList1"
        TreeNode1.Name = "1"
        TreeNode1.Text = "Detalladas"
        TreeNode2.Name = "2"
        TreeNode2.Text = "Detalladas X cliente"
        TreeNode3.Name = "3"
        TreeNode3.Text = "Diarias"
        TreeNode4.Name = "4"
        TreeNode4.Text = "Reales"
        TreeNode5.Name = "5"
        TreeNode5.Text = "Empleado"
        TreeNode6.Name = "6"
        TreeNode6.Text = "Familia"
        TreeNode7.Name = "7"
        TreeNode7.Text = "Periodo fiscal"
        TreeNode8.Name = "8"
        TreeNode8.Text = "Tipo"
        TreeNode9.Name = "9"
        TreeNode9.Text = "Anuladas"
        TreeNode10.Name = "10"
        TreeNode10.Text = "Taller"
        TreeNode11.Name = "11"
        TreeNode11.Text = "Detallas x rango"
        TreeNode12.Name = "Nodo0"
        TreeNode12.Text = "Ventas "
        TreeNode13.Name = "13"
        TreeNode13.Text = "Contado y recuperacion"
        TreeNode14.Name = "14"
        TreeNode14.Text = "Ventas CON CRE"
        TreeNode15.Name = "12"
        TreeNode15.Text = "Comisiones"
        TreeNode16.Name = "16"
        TreeNode16.Text = "General por cliente"
        TreeNode17.Name = "17"
        TreeNode17.Text = "Venta General"
        TreeNode18.Name = "18"
        TreeNode18.Text = "Detalladas por empleado"
        TreeNode19.Name = "15"
        TreeNode19.Text = "Devoluciones"
        TreeNode20.Name = "20"
        TreeNode20.Text = "Ventas"
        TreeNode21.Name = "19"
        TreeNode21.Text = "Ganancias"
        TreeNode22.Name = "22"
        TreeNode22.Text = "Reporte de descuentos"
        TreeNode23.Name = "21"
        TreeNode23.Text = "Descuento"
        Me.TreeList1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode15, TreeNode19, TreeNode21, TreeNode23})
        Me.TreeList1.SelectedImageIndex = 0
        Me.TreeList1.Size = New System.Drawing.Size(194, 136)
        Me.TreeList1.StateImageList = Me.ImageList1
        Me.TreeList1.TabIndex = 79
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'ck_clientes_frecuentes
        '
        Me.ck_clientes_frecuentes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ck_clientes_frecuentes.ForeColor = System.Drawing.Color.Red
        Me.ck_clientes_frecuentes.Location = New System.Drawing.Point(0, 160)
        Me.ck_clientes_frecuentes.Name = "ck_clientes_frecuentes"
        Me.ck_clientes_frecuentes.Size = New System.Drawing.Size(128, 24)
        Me.ck_clientes_frecuentes.TabIndex = 69
        Me.ck_clientes_frecuentes.Text = "Clientes frecuentes"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCaja
        '
        Me.cboCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.Items.AddRange(New Object() {"1", "2", "3", "0"})
        Me.cboCaja.Location = New System.Drawing.Point(96, 296)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(96, 21)
        Me.cboCaja.TabIndex = 67
        '
        'CBTipo
        '
        Me.CBTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipo.ForeColor = System.Drawing.Color.Blue
        Me.CBTipo.Items.AddRange(New Object() {"CON", "CRE", "PVE", "TCO", "TCR", "MCO", "MCR", "TODAS"})
        Me.CBTipo.Location = New System.Drawing.Point(8, 272)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(188, 21)
        Me.CBTipo.TabIndex = 66
        Me.CBTipo.Visible = False
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.ButtonMostrar.Image = CType(resources.GetObject("ButtonMostrar.Image"), System.Drawing.Image)
        Me.ButtonMostrar.ImageList = Me.ImageList1
        Me.ButtonMostrar.Location = New System.Drawing.Point(8, 416)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(184, 40)
        Me.ButtonMostrar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.DimGray, System.Drawing.Color.White)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar Reporte"
        '
        'cbxCategoría
        '
        Me.cbxCategoría.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategoría.Enabled = False
        Me.cbxCategoría.ForeColor = System.Drawing.Color.Blue
        Me.cbxCategoría.Location = New System.Drawing.Point(8, 272)
        Me.cbxCategoría.Name = "cbxCategoría"
        Me.cbxCategoría.Size = New System.Drawing.Size(186, 21)
        Me.cbxCategoría.TabIndex = 63
        '
        'cbxEmpleado
        '
        Me.cbxEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmpleado.Enabled = False
        Me.cbxEmpleado.ForeColor = System.Drawing.Color.Blue
        Me.cbxEmpleado.Location = New System.Drawing.Point(8, 272)
        Me.cbxEmpleado.Name = "cbxEmpleado"
        Me.cbxEmpleado.Size = New System.Drawing.Size(186, 21)
        Me.cbxEmpleado.TabIndex = 61
        Me.cbxEmpleado.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(8, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Monto >="
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.Enabled = False
        Me.txtMonto.FieldReference = Nothing
        Me.txtMonto.Location = New System.Drawing.Point(96, 392)
        Me.txtMonto.MaskEdit = ""
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtMonto.Required = False
        Me.txtMonto.ShowErrorIcon = False
        Me.txtMonto.Size = New System.Drawing.Size(96, 20)
        Me.txtMonto.TabIndex = 59
        Me.txtMonto.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.txtMonto.ValidText = Nothing
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(6, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hasta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(6, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(8, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Moneda"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonedas
        '
        Me.cboMonedas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMonedas.DataSource = Me.DsReporteVentas
        Me.cboMonedas.DisplayMember = "Moneda.MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(96, 368)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(96, 21)
        Me.cboMonedas.TabIndex = 41
        Me.cboMonedas.ValueMember = "ValorCompra"
        '
        'DsReporteVentas
        '
        Me.DsReporteVentas.DataSetName = "DsReporteVentas"
        Me.DsReporteVentas.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsReporteVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaFinal
        '
        Me.FechaFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(96, 344)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 37
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(96, 320)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 36
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmpleado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblEmpleado.Location = New System.Drawing.Point(8, 256)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(184, 16)
        Me.lblEmpleado.TabIndex = 62
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.Visible = False
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsReporteVentas, "Moneda.ValorCompra", True))
        Me.lblTipoCambio.Location = New System.Drawing.Point(624, 88)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(100, 8)
        Me.lblTipoCambio.TabIndex = 42
        '
        'lblCategoría
        '
        Me.lblCategoría.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCategoría.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCategoría.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategoría.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoría.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCategoría.Location = New System.Drawing.Point(8, 256)
        Me.lblCategoría.Name = "lblCategoría"
        Me.lblCategoría.Size = New System.Drawing.Size(188, 16)
        Me.lblCategoría.TabIndex = 64
        Me.lblCategoría.Text = "Categoría"
        Me.lblCategoría.Visible = False
        '
        'gpcliente
        '
        Me.gpcliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gpcliente.Controls.Add(Me.txtcliente)
        Me.gpcliente.Controls.Add(Me.txtnombre)
        Me.gpcliente.Controls.Add(Me.Label6)
        Me.gpcliente.Location = New System.Drawing.Point(8, 184)
        Me.gpcliente.Name = "gpcliente"
        Me.gpcliente.Size = New System.Drawing.Size(192, 72)
        Me.gpcliente.TabIndex = 81
        Me.gpcliente.TabStop = False
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(40, 16)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(144, 20)
        Me.txtcliente.TabIndex = 79
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(8, 48)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(176, 20)
        Me.txtnombre.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(0, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Cod."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'daClientes
        '
        Me.daClientes.DeleteCommand = Me.SqlDeleteCommand1
        Me.daClientes.InsertCommand = Me.SqlInsertCommand1
        Me.daClientes.SelectCommand = Me.SqlSelectCommand1
        Me.daClientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("abierto", "abierto"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("max_credito", "max_credito"), New System.Data.Common.DataColumnMapping("Plazo_credito", "Plazo_credito"), New System.Data.Common.DataColumnMapping("descuento", "descuento"), New System.Data.Common.DataColumnMapping("empresa", "empresa"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("sinrestriccion", "sinrestriccion"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("agente", "agente"), New System.Data.Common.DataColumnMapping("CodMonedaCredito", "CodMonedaCredito"), New System.Data.Common.DataColumnMapping("identificacion", "identificacion")})})
        Me.daClientes.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 0, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 0, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 0, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 0, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 0, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.[Char], 0, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 0, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 0, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Current, Nothing)})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 0, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 0, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 0, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 0, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 0, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.[Char], 0, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 0, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 0, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 0, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 0, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.[Char], 0, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 0, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.[Char], 0, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 0, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 0, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 0, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daMoneda
        '
        Me.daMoneda.DeleteCommand = Me.SqlDeleteCommand2
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.daMoneda.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(208, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(512, 461)
        Me.CrystalReportViewer1.TabIndex = 78
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'daClientesFre
        '
        Me.daClientesFre.DeleteCommand = Me.SqlDeleteCommand3
        Me.daClientesFre.InsertCommand = Me.SqlInsertCommand3
        Me.daClientesFre.SelectCommand = Me.SqlSelectCommand3
        Me.daClientesFre.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes_frecuentes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.daClientesFre.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Clientes_frecuentes WHERE (identificacion = @Original_identificacion)" &
    ""
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, f" &
    "ax_01, fax_02, e_mail, direccion, tipoprecio, usuario, nombreusuario, Anulado FR" &
    "OM Clientes_frecuentes"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'frmReporteVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DsReporteVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcliente.ResumeLayout(False)
        Me.gpcliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"

    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Dim Reporte_ID As Byte
    Dim cliente_normal As Boolean
#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        '0	-	1	Ventas Detalladas
        '1	-	2	Ventas Detalladas x Cliente
        '2	-	7	Ventas x Período Fiscal
        '3	-	3	Ventas Diarias
        '4	-	6	Ventas x Familia
        '5	-	5	Ventas x Empleado
        '6	-	21	Seguimiento x Familia
        '7	-	20	Seguimiento x Empleado
        '8	-	8	Ventas x Tipo
        '9	-	4	Ventas Reales
        '10	-	12	Comisiones de Venta
        '11	-	15	Devoluciones de Venta
        '12	-	14	Devoluciones de Empleados
        '13	-	16	Devoluciones x Empleado
        '14	-	17	Ganancias de Venta
        '15	-	12	Comisión Contado y Recuperación
        '16	-	9	Ventas Anuladas
        Dim SQLConexion As New Conexion
        Dim Tipo As String
        Try
            SQLConexion.SQLStringConexion = Me.SqlConnection1.ConnectionString  '   CadenaConexionSeePOS
            SQLConexion.Conectar()

            Select Case Reporte_ID
                Case 1 '0 Ventas Detalladas


                    If CBTipo.SelectedIndex = 7 Then
                        Dim Formula As String = ""
                        Dim Reporte As New Ventas_Detalladas_General
                        Reporte.SetParameterValue(0, "REPORTE DE VENTAS BRUTAS DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                        Reporte.SetParameterValue(1, CDbl(lblTipoCambio.Text))
                        Reporte.SetParameterValue(2, cboMonedas.Text)
                        Reporte.SetParameterValue(3, CDate(Me.FechaInicio.Value))
                        Reporte.SetParameterValue(4, CDate(Me.FechaFinal.Value))
                        Reporte.SetParameterValue(5, CInt(Me.cboCaja.SelectedItem))
                        'SUBREPORTE DEVOLUCIONES
                        Reporte.SetParameterValue("Fechainicio", CDate(Me.FechaInicio.Value))
                        Reporte.SetParameterValue("Fechafinal", CDate(Me.FechaFinal.Value))
                        'SUBREPORTE DETALLE IMPUESTOS
                        Reporte.SetParameterValue("@Desde", CDate(Me.FechaInicio.Value))
                        Reporte.SetParameterValue("@Hasta", CDate(Me.FechaFinal.Value))
                        Reporte.SetParameterValue("@Caja", Me.cboCaja.SelectedItem)
                        Reporte.SetParameterValue("@Tipo", "TODOS")

                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Reporte)
                    Else
                        If CBTipo.Text = "CRE" Then : Tipo = "CREDITO" : ElseIf CBTipo.Text = "CON" Then : Tipo = "CONTADO" : ElseIf CBTipo.Text = "PVE" Then : Tipo = "PUNTO DE VENTA" : ElseIf CBTipo.Text = "TCR" Then : Tipo = "TALLER CREDITO" : ElseIf CBTipo.Text = "TCO" Then : Tipo = "TALLER CONTADO" : ElseIf CBTipo.Text = "MCO" Then : Tipo = "MASCOTA CONTADO" : ElseIf CBTipo.Text = "MCR" Then : Tipo = "MASCOTA CREDITO" : End If
                        'If CBTipo.Text = "CRE" Then : Tipo = "CREDITO" : ElseIf CBTipo.Text = "CON" Then : Tipo = "CONTADO" : ElseIf CBTipo.Text = "PVE" Then : Tipo = "PUNTO DE VENTA" : ElseIf CBTipo.Text = "TCR" Then : Tipo = "TALLER CREDITO" : ElseIf CBTipo.Text = "TCO" Then : Tipo = "TALLER CONTADO" : End If


                        Dim Reporte As New Ventas_Detalladas_General_Tipo
                        Reporte.SetParameterValue(0, "REPORTE DE VENTAS BRUTAS DE " & Tipo & " DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' - '" & CBTipo.Text & "' PV:" & PuntoVentaActual.Nombre)
                        Reporte.SetParameterValue(1, CDbl(lblTipoCambio.Text))
                        Reporte.SetParameterValue(2, cboMonedas.Text)
                        Reporte.SetParameterValue(3, CDate(FechaInicio.Value))
                        Reporte.SetParameterValue(4, CDate(FechaFinal.Value))
                        Reporte.SetParameterValue(5, CBTipo.Text)
                        Reporte.SetParameterValue(6, CInt(Me.cboCaja.SelectedItem))
                        Reporte.SetParameterValue(7, CDbl(lblTipoCambio.Text))
                        Reporte.SetParameterValue(8, CDate(FechaInicio.Value))
                        Reporte.SetParameterValue(9, CDate(FechaFinal.Value))
                        CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, Reporte)
                    End If


                Case 2 '1 'REPORTE DE VENTAS X CLIENTE
                    'aqui
                    Dim ReportexCliente As New VentasxCliente
                    ReportexCliente.SetParameterValue(0, "REPORTE DE VENTAS DE '" & Me.txtnombre.Text & "' DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                    ReportexCliente.SetParameterValue(1, CDbl(lblTipoCambio.Text))
                    ReportexCliente.SetParameterValue(2, cboMonedas.Text)
                    ReportexCliente.SetParameterValue(3, CDate(FechaInicio.Value))
                    ReportexCliente.SetParameterValue(4, CDate(FechaFinal.Value))
                    ReportexCliente.SetParameterValue(5, Me.txtnombre.Text)
                    ReportexCliente.SetParameterValue(6, CInt(Me.cboCaja.SelectedItem))
                    ReportexCliente.SetParameterValue(7, CDbl(lblTipoCambio.Text))
                    ReportexCliente.SetParameterValue(8, CDate(Me.FechaInicio.Value))
                    ReportexCliente.SetParameterValue(9, CDate(Me.FechaFinal.Value))
                    ReportexCliente.SetParameterValue(10, Me.txtnombre.Text)
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, ReportexCliente)

                Case 3 'REPORTE DE VENTAS DIARIAS
                    Try
                        Dim RptVentaxdia As New VentasXDia2
                        RptVentaxdia.SetParameterValue(0, CStr(cboMonedas.Text))
                        RptVentaxdia.SetParameterValue(1, "REPORTE DE VENTAS DIARIAS DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                        RptVentaxdia.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                        RptVentaxdia.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                        RptVentaxdia.SetParameterValue(4, CDbl(lblTipoCambio.Text))
                        RptVentaxdia.SetParameterValue(5, CInt(Me.cboCaja.SelectedIndex + 1))
                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptVentaxdia)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try

                Case 4 '9 'REPORTE DE VENTAS REALES
                    Try
                        Dim RptVentasReales As New ReporteVentasReales
                        RptVentasReales.SetParameterValue(0, Me.FechaInicio.Value)
                        RptVentasReales.SetParameterValue(1, Me.FechaFinal.Value)
                        RptVentasReales.SetParameterValue(2, CDbl(lblTipoCambio.Text))
                        RptVentasReales.SetParameterValue(3, cboMonedas.Text)
                        RptVentasReales.SetParameterValue(4, CInt(Me.cboCaja.SelectedIndex + 1))

                        'SUBREPORTE DETALLE IMPUESTOS
                        RptVentasReales.SetParameterValue("Desde", CDate(Me.FechaInicio.Value))
                        RptVentasReales.SetParameterValue("Hasta", CDate(Me.FechaFinal.Value))
                        RptVentasReales.SetParameterValue("Tipo", Me.CBTipo.Text)

                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptVentasReales)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try

                Case 5 'REPORTE DE VENTAS X EMPLEADO
                    Try
                        Dim RptVentaxEmpleado As New VentasxEmpleado2
                        Dim rptventasxempleado_general As New VentasxEmpleado_general
                        If Me.cboCaja.Text = "0" Then
                            rptventasxempleado_general.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                            rptventasxempleado_general.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                            rptventasxempleado_general.SetParameterValue(2, "REPORTE DE VENTAS X EMPLEADO DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                            rptventasxempleado_general.SetParameterValue(3, cboMonedas.Text)
                            CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, rptventasxempleado_general)
                        Else
                            RptVentaxEmpleado.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                            RptVentaxEmpleado.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                            RptVentaxEmpleado.SetParameterValue(2, "REPORTE DE VENTAS X EMPLEADO DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                            RptVentaxEmpleado.SetParameterValue(3, cboMonedas.Text)
                            RptVentaxEmpleado.SetParameterValue(4, CInt(Me.cboCaja.SelectedItem))
                            CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptVentaxEmpleado)
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try

                Case 6 '4 'REPORTE DE VENTAS X CATEGORIA
                    Try
                        Dim RptVentaxCategoria As New VentaxCategoria2
                        RptVentaxCategoria.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                        RptVentaxCategoria.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                        RptVentaxCategoria.SetParameterValue(2, CDbl(lblTipoCambio.Text))
                        RptVentaxCategoria.SetParameterValue(3, cboMonedas.Text)
                        RptVentaxCategoria.SetParameterValue(4, "REPORTE DE VENTAS X CATEGORIA DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                        RptVentaxCategoria.SetParameterValue(5, CInt(Me.cboCaja.SelectedIndex + 1))
                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptVentaxCategoria)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try

                Case 7 '2 'REPORTE DE VENTAS FISCAL
                    If txtMonto.Text = "" Then
                        MsgBox("Debe ingresar un monto!!", MsgBoxStyle.Exclamation, "Atención...")
                        Exit Try
                    End If
                    Try
                        Dim ReporteFiscal As New VentasFiscales
                        ReporteFiscal.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        ReporteFiscal.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                        ReporteFiscal.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                        ReporteFiscal.SetParameterValue(3, cboMonedas.Text)
                        ReporteFiscal.SetParameterValue(4, CDbl(Me.txtMonto.Text))
                        ReporteFiscal.SetParameterValue(5, CInt(Me.cboCaja.SelectedIndex + 1))
                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, ReporteFiscal)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try

                Case 8 'REPORTE DE VENTAS X TIPO
                    Try
                        Dim RptVentasxTipo As New VentasxTipo2
                        RptVentasxTipo.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                        RptVentasxTipo.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                        RptVentasxTipo.SetParameterValue(2, cboMonedas.Text)
                        RptVentasxTipo.SetParameterValue(3, "REPORTE DE VENTAS X TIPO DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "' PV:" & PuntoVentaActual.Nombre)
                        RptVentasxTipo.SetParameterValue(4, CDbl(Me.lblTipoCambio.Text))
                        RptVentasxTipo.SetParameterValue(5, CInt(Me.cboCaja.SelectedIndex + 1))
                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptVentasxTipo)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try
                Case 9 'VENTAS ANULADAS
                    Try
                        Dim Reporte_Facturas_Ventas_Anuladas As New Reporte_Ventas_Anuladas
                        Reporte_Facturas_Ventas_Anuladas.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                        Reporte_Facturas_Ventas_Anuladas.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                        Reporte_Facturas_Ventas_Anuladas.SetParameterValue(2, CInt(Me.cboCaja.SelectedIndex + 1))
                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Reporte_Facturas_Ventas_Anuladas)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try

                Case 10 'VENTAS DE TALLER
                    If CBTipo.SelectedIndex = 5 Then
                        Try
                            Dim Reporte As New Ventas_Detalladas_General_Taller
                            Reporte.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                            Reporte.SetParameterValue(1, cboMonedas.Text)
                            Reporte.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                            Reporte.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                            Reporte.SetParameterValue(4, CInt(Me.cboCaja.SelectedIndex + 1))
                            CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Reporte)
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                        End Try
                    Else
                        Try
                            Dim Reporte As New Ventas_Detalladas_General_Taller_Tipo
                            Reporte.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                            Reporte.SetParameterValue(1, cboMonedas.Text)
                            Reporte.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                            Reporte.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                            Reporte.SetParameterValue(4, CBTipo.Text)
                            Reporte.SetParameterValue(5, CInt(Me.cboCaja.SelectedIndex + 1))
                            CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Reporte)
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                        End Try
                    End If

                Case 11 'Detalladas x RangoFacturas
                    Try
                        Dim Reporte As New RepVentasRangoFacturas
                        Reporte.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                        Reporte.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                        Reporte.SetParameterValue(2, Me.CBTipo.Text)
                        Reporte.SetParameterValue(3, CInt(Me.cboCaja.SelectedItem))


                        'SUBREPORTE DETALLE IMPUESTOS
                        Reporte.SetParameterValue("Desde", CDate(Me.FechaInicio.Value))
                        Reporte.SetParameterValue("Hasta", CDate(Me.FechaFinal.Value))
                        'Reporte.SetParameterValue("Tipo", Me.CBTipo.Text)

                        CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Reporte)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
                    End Try
                Case 12 '15 Comisión Contado y Recuperación
                    'Aqui: Ojo no se Actualizo
                    Dim ReporteComision_Ventas_Contado_Recuperacion As New ReporteComisiones_X_Contado_Recuperacion
                    ReporteComision_Ventas_Contado_Recuperacion.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    ReporteComision_Ventas_Contado_Recuperacion.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, ReporteComision_Ventas_Contado_Recuperacion)

                Case 13 '10 'REPORTE  DE COMISIONES GENERAL
                    'Aqui: Ojo no se Actualizo
                    Dim Comisionantes As New ReporteComisionesFinal
                    Comisionantes.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    Comisionantes.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Comisionantes)

                Case 15 ' 12 'DEVOLUCIONES GENERALES DE EMPLEADOS



                    'Aqui: Ojo no se Actualizo
                    Dim RptDevoluciones_Generales As New DevolucionesGeneralEmpleados
                    RptDevoluciones_Generales.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    RptDevoluciones_Generales.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    RptDevoluciones_Generales.SetParameterValue(2, CDbl(lblTipoCambio.Text))
                    RptDevoluciones_Generales.SetParameterValue(3, cboMonedas.Text)
                    RptDevoluciones_Generales.SetParameterValue(4, CInt(Me.cboCaja.SelectedIndex + 1))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptDevoluciones_Generales)

                Case 16 '11 'DEVOLUCIONES
                    'Aqui: Ojo no se Actualizo
                    Dim RptDevoluciones As New Devoluciones
                    RptDevoluciones.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                    RptDevoluciones.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                    RptDevoluciones.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                    RptDevoluciones.SetParameterValue(3, cboMonedas.Text)
                    RptDevoluciones.SetParameterValue(4, CInt(Me.cboCaja.SelectedItem))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptDevoluciones)

                Case 17 '13 'DEVOLUCIONES X EMPLEADO
                    'Aqui: Ojo no se Actualizo 
                    Dim RptDevolucionesxEmpleado As New DevolucionesxEmpleado
                    RptDevolucionesxEmpleado.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    RptDevolucionesxEmpleado.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    RptDevolucionesxEmpleado.SetParameterValue(2, CDbl(lblTipoCambio.Text))
                    RptDevolucionesxEmpleado.SetParameterValue(3, cboMonedas.Text)
                    RptDevolucionesxEmpleado.SetParameterValue(4, Me.cbxEmpleado.Text)
                    RptDevolucionesxEmpleado.SetParameterValue(5, CInt(Me.cboCaja.SelectedItem))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptDevolucionesxEmpleado)

                Case 20 '14 'GANANCIAS DE VENTA
                    Dim RptGanancias As New Ganancias_Ventas2
                    RptGanancias.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    RptGanancias.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    RptGanancias.SetParameterValue(2, CDbl(lblTipoCambio.Text))
                    RptGanancias.SetParameterValue(3, cboMonedas.Text)
                    RptGanancias.SetParameterValue(4, CInt(Me.cboCaja.SelectedIndex + 1))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptGanancias)



                Case 21 '7 'REPORTE DE VENTAS X SEGUIMIENTO DE EMPLEADO
                    Dim RptSeguimientoxEmpleado As New SeguimientoxEmpleado
                    'JCGA 27 DE JULIO 2007
                    'RptSeguimientoxEmpleado.SetParameterValue(0, "REPORTE DE VENTAS X SEGUIMIENTO DE EMPLEADO DESDE EL " & Me.cbxEmpleado.Text & " desde el '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                    RptSeguimientoxEmpleado.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    RptSeguimientoxEmpleado.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    RptSeguimientoxEmpleado.SetParameterValue(2, Me.cbxEmpleado.Text)
                    RptSeguimientoxEmpleado.SetParameterValue(3, CDbl(lblTipoCambio.Text))
                    RptSeguimientoxEmpleado.SetParameterValue(4, cboMonedas.Text)
                    RptSeguimientoxEmpleado.SetParameterValue(5, CInt(Me.cboCaja.SelectedIndex + 1))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptSeguimientoxEmpleado)

                Case 22 '6 'REPORTE DE VENTAS SEGUIMIENTO X CATEGORIA
                    Dim Rptdescuentos As New Ganancias_descuentos
                    Rptdescuentos.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    Rptdescuentos.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, Rptdescuentos)


                    'Dim RptSeguimientoxCategoria As New SeguimientoxCategoria
                    'RptSeguimientoxCategoria.SetParameterValue(0, "REPORTE DE VENTAS X SEGUIMIENTO DE CATEGORIA DESDE EL '" & Me.cbxCategoría.Text & "' desde el '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                    'RptSeguimientoxCategoria.SetParameterValue(1, CDbl(lblTipoCambio.Text))
                    'RptSeguimientoxCategoria.SetParameterValue(2, cboMonedas.Text)
                    'RptSeguimientoxCategoria.SetParameterValue(3, CDate(Me.FechaInicio.Value))
                    'RptSeguimientoxCategoria.SetParameterValue(4, CDate(Me.FechaFinal.Value))
                    'RptSeguimientoxCategoria.SetParameterValue(5, Me.cbxCategoría.Text)
                    'RptSeguimientoxCategoria.SetParameterValue(6, CDbl(lblTipoCambio.Text))
                    'RptSeguimientoxCategoria.SetParameterValue(7, CDate(Me.FechaInicio.Value))
                    'RptSeguimientoxCategoria.SetParameterValue(8, CDate(Me.FechaFinal.Value))
                    'RptSeguimientoxCategoria.SetParameterValue(9, Me.cbxCategoría.Text)
                    'CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, RptSeguimientoxCategoria)

            End Select

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    '    Private Sub cbxOpcionesdeVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOpcionesdeVenta.SelectedIndexChanged
    Private Sub Reporte_Seleccionado()
        '0	-	1	Ventas Detalladas
        '1	-	2	Ventas Detalladas x Cliente
        '2	-	7	Ventas x Período Fiscal
        '3	-	3	Ventas Diarias
        '4	-	6	Ventas x Familia
        '5	-	5	Ventas x Empleado
        '6	-	21	Seguimiento x Familia
        '7	-	20	Seguimiento x Empleado
        '8	-	8	Ventas x Tipo
        '9	-	4	Ventas Reales
        '10	-	12	Comisiones de Venta
        '11	-	15	Devoluciones de Venta
        '12	-	14	Devoluciones de Empleados
        '13	-	16	Devoluciones x Empleado
        '14	-	17	Ganancias de Venta
        '15	-	11	Comisión Contado y Recuperación
        '16	-	9	Ventas Anuladas
        Me.Label1.Visible = True
        Me.cboCaja.Visible = True

        CBTipo.Visible = False
        lblEmpleado.Visible = False
        lblEmpleado.Text = "Empleado"

        Select Case Reporte_ID 'Me.cbxOpcionesdeVenta.SelectedIndex
            Case 1 '0 'Ventas Detalladas
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                gpcliente.Visible = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.cbxEmpleado.Visible = False
                lblEmpleado.Visible = True
                CBTipo.Visible = True
                lblEmpleado.Text = "Tipo"
                Me.FechaInicio.Focus()


            Case 2 '1 'Ventas Detalladas x Cliente
                Dim rs As SqlDataReader
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                gpcliente.Visible = True
                Me.ck_clientes_frecuentes.Visible = True
                Me.gpcliente.Enabled = True
                Me.txtcliente.Focus()
                Me.cbxEmpleado.Enabled = False
                Me.cbxEmpleado.Visible = False


            'rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT nombre from clientes order by nombre")
            'While rs.Read
            '    Try
            '        Me.cbxCliente.Items.Add(rs!nombre)
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message)
            '    End Try
            'End While
            'rs.Close()

            Case 3 'Ventas Diarias
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                gpcliente.Enabled = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.cbxEmpleado.Enabled = False

            Case 4
                Me.CBTipo.Visible = True
                Me.lblEmpleado.Visible = False
                Me.lblEmpleado.Text = "Tipo"

                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.cbxEmpleado.Enabled = False
                Me.FechaInicio.Focus()

            Case 12 '9, 15
                'Ventas(Reales)
                'Comisión Contado y Recuperación
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.cbxEmpleado.Enabled = False
                Me.FechaInicio.Focus()



            Case 5 'Ventas x Empleado
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.gpcliente.Visible = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.lblEmpleado.Visible = False
                Me.cbxEmpleado.Enabled = False
                Me.cbxEmpleado.Visible = False


            Case 6 '4 'Ventas x Familia
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.cbxEmpleado.Enabled = False


            Case 7 '2 'Ventas x Período Fiscal
                Me.Label1.Visible = False
                Me.cboCaja.Visible = False
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = True
                Me.txtMonto.Focus()
                Me.cbxEmpleado.Enabled = False
                Me.gpcliente.Enabled = False
                Me.ck_clientes_frecuentes.Visible = False


            Case 8 'Ventas x Tipo
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.cbxEmpleado.Enabled = False
                Me.ck_clientes_frecuentes.Visible = False

            Case 10 'VENTAS DE TALLER
                lblCategoría.Visible = False
                cbxCategoría.Visible = False
                txtMonto.Enabled = False
                gpcliente.Visible = False
                lblEmpleado.Visible = True
                CBTipo.Visible = True
                lblEmpleado.Text = "Tipo"
                FechaInicio.Focus()
                Me.ck_clientes_frecuentes.Visible = False


            Case 13 '10 'REPORTE DE COMISIONES DE VENTA
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.cbxEmpleado.Enabled = False
                Me.FechaInicio.Focus()
                Me.ck_clientes_frecuentes.Visible = False


            Case 15 '12 'Devoluciones de Empleados
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.cbxEmpleado.Enabled = False
                Me.FechaInicio.Focus()
                Me.ck_clientes_frecuentes.Visible = False


            Case 16 '11 'Devoluciones de Venta
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.cbxEmpleado.Enabled = False
                Me.FechaInicio.Focus()
                Me.ck_clientes_frecuentes.Visible = False


            Case 17 '13 'Devoluciones x Empleado
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.cbxEmpleado.Enabled = True
                Me.cbxEmpleado.Visible = True
                Me.lblEmpleado.Visible = True
                Me.ck_clientes_frecuentes.Visible = False
                Me.FechaInicio.Focus()

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT distinct(nombre) from usuarios order by nombre")
                While rs.Read
                    Try
                        Me.cbxEmpleado.Items.Add(rs!nombre)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                'JCGA 31 DE JULIO 2007
                If Me.cbxEmpleado.Enabled = False Then
                    Me.cbxEmpleado.Enabled = True
                End If
                Me.gpcliente.Visible = False
                rs.Close()

            Case 18 '14 'Ganancias de Venta
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Enabled = False
                Me.cbxEmpleado.Enabled = False
                Me.cbxEmpleado.Visible = False
                Me.lblEmpleado.Visible = True
                Me.ck_clientes_frecuentes.Visible = False
                Me.FechaInicio.Focus()


            Case 21 '7 'Seguimiento x Empleado
                Dim rs As SqlDataReader
                Me.cbxEmpleado.Items.Add("---------------")
                rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT * from usuarios order by nombre")
                While rs.Read
                    Try
                        Me.cbxEmpleado.Items.Add(rs!nombre)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                rs.Close()
                Me.lblCategoría.Visible = False
                Me.cbxCategoría.Visible = False
                Me.txtMonto.Enabled = False
                Me.gpcliente.Visible = False
                Me.ck_clientes_frecuentes.Visible = False
                Me.lblEmpleado.Visible = True
                Me.cbxEmpleado.Enabled = True
                Me.cbxEmpleado.Visible = True


            Case 22 '6 'descuentos
                Me.CBTipo.Enabled = False
                Me.cboCaja.Enabled = False
                lblCategoría.Visible = False
                cbxCategoría.Visible = False
                txtMonto.Enabled = False
                gpcliente.Visible = False
                Me.ck_clientes_frecuentes.Visible = False
                lblEmpleado.Visible = True
                CBTipo.Visible = True
                lblEmpleado.Text = "Tipo"
                FechaInicio.Focus()


            'Dim rs As SqlDataReader
            'rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT * from Familia order by Descripcion")
            'While rs.Read
            '    Try
            '        Me.cbxCategoría.Items.Add(rs!Descripcion)
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message)
            '    End Try
            'End While
            'rs.Close()
            'Me.lblCategoría.Visible = True
            'Me.cbxCategoría.Enabled = True
            'Me.cbxCategoría.Visible = True
            'Me.txtMonto.Enabled = False
            'Me.gpcliente.Visible = False
            'Me.ck_clientes_frecuentes.Visible = False
            'Me.lblEmpleado.Visible = False
            'Me.cbxEmpleado.Visible = False


            Case 11 'Detalladas x Rango Fechas
                lblCategoría.Visible = False
                cbxCategoría.Visible = False
                txtMonto.Enabled = False
                gpcliente.Visible = False
                Me.ck_clientes_frecuentes.Visible = False
                lblEmpleado.Visible = True
                CBTipo.Visible = True
                lblEmpleado.Text = "Tipo"
                FechaInicio.Focus()


        End Select
    End Sub

    Private Sub frmReporteVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cConexion = New Conexion
            sqlConexion = cConexion.Conectar

            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Me.daClientes.Fill(Me.DsReporteVentas, "clientes")
            Me.daClientesFre.Fill(Me.DsReporteVentas, "clientes_frecuentes")
            Me.daMoneda.Fill(Me.DsReporteVentas, "moneda")
            Me.FechaInicio.Text = Date.Today
            Me.FechaFinal.Text = Date.Today
            Me.TreeList1.ExpandAll()
            CBTipo.SelectedIndex = 5
            cboCaja.SelectedIndex = 0
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ck_clientes_frecuentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_clientes_frecuentes.CheckedChanged

        Dim rs As SqlDataReader
        txtcliente.Text = ""
        txtnombre.Text = ""

        If Me.ck_clientes_frecuentes.Checked = True Then
            rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT nombre from clientes_frecuentes order by nombre")
        Else
            rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT nombre from clientes order by nombre")
        End If

        'While rs.Read
        '    Try
        '        Me.cbxCliente.Items.Add(rs!nombre)
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End While
        'rs.Close()
    End Sub
    Private Sub txtcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcliente.KeyDown
        If Keys.F1 Then
            Dim cFunciones As New cFunciones
            Dim c As String

            If Me.ck_clientes_frecuentes.Checked = True Then
                c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes_frecuentes where anulado = 0", "Nombre")
            Else
                c = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes where anulado = 0", "Nombre")
            End If

            If c <> "" Then
                Me.txtcliente.Text = c
            Else
                Exit Sub
            End If
            If Me.txtcliente.Text <> "" And Me.txtcliente.Text <> "0" Then
                sqlConexion = cConexion.Conectar
                CargarInformacionCliente(txtcliente.Text)
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim rsm As SqlDataReader
        Dim cod_mod As Integer
        Dim cambio As Double


        sqlConexion = cConexion.Conectar
        If codigo <> Nothing Then
            If Me.ck_clientes_frecuentes.Checked = True Then
                rss = Me.DsReporteVentas.Clientes_frecuentes.Select("Identificacion ='" & codigo & "'")
            Else
                rss = Me.DsReporteVentas.Clientes.Select("Identificacion ='" & codigo & "'")
            End If
            rs = rss(0)
            txtcliente.Text = rs("Identificacion")
            ''''''''''''''''
            txtnombre.Text = rs("nombre")
            txtnombre.Enabled = False
        Else ' si no se encontro el cliente

            MsgBox("No existe un cliente con ese código", MsgBoxStyle.Exclamation)
            Me.txtcliente.Text = ""
            Me.txtnombre.Text = ""


        End If
    End Sub

    Private Sub TreeList1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeList1.NodeMouseClick
        Reporte_ID = e.Node.Name
        Reporte_Seleccionado()
    End Sub

End Class
