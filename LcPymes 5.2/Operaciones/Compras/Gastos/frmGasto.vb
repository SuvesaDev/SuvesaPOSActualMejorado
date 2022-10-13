Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmGasto
    Inherits System.Windows.Forms.Form

    Dim Usua As New Object
    Dim idProveedor() As Integer
    Dim IdMoneda() As Integer
    Dim impuesto As Double
    Dim IdDetalle As Integer
    Dim IdGasto As Integer
    Dim Id_Usuario As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()
        InitializeComponent() 'This call is required by the Windows Form Designer.
        Usua = Usuario_Parametro
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
    Protected Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonSeparador1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImportar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonSeparador2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuentaContableDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtDetallePrecioUnidad As System.Windows.Forms.TextBox
    Friend WithEvents gridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbRecalcular As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents dtsGasto As DatasetGasto
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDetalleArticuloDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda4 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda3 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda2 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGasto))
        Me.Label46 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tlbNuevo = New System.Windows.Forms.ToolBarButton
        Me.tlbBuscar = New System.Windows.Forms.ToolBarButton
        Me.tlbRegistrar = New System.Windows.Forms.ToolBarButton
        Me.tlbEliminar = New System.Windows.Forms.ToolBarButton
        Me.tlbImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonSeparador1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImportar = New System.Windows.Forms.ToolBarButton
        Me.tlbRecalcular = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonSeparador2 = New System.Windows.Forms.ToolBarButton
        Me.tlbCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblMoneda1 = New System.Windows.Forms.Label
        Me.lblMoneda2 = New System.Windows.Forms.Label
        Me.lblMoneda3 = New System.Windows.Forms.Label
        Me.lblMoneda4 = New System.Windows.Forms.Label
        Me.txtImpuesto = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCuentaContableDescripcion = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTotalImpuesto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalDescuento = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDetalleSubTotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDetalleDescuento = New System.Windows.Forms.TextBox
        Me.txtDetallePrecioUnidad = New System.Windows.Forms.TextBox
        Me.txtDetalleArticuloDescripcion = New System.Windows.Forms.TextBox
        Me.txtDetalleCantidad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gridDetalle = New DevExpress.XtraGrid.GridControl
        Me.dtsGasto = New LcPymes_5._2.DatasetGasto
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.TxtNombreUsuario = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(0, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(832, 32)
        Me.Label46.TabIndex = 109
        Me.Label46.Text = "Registro de Gastos"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tlbNuevo, Me.tlbBuscar, Me.tlbRegistrar, Me.tlbEliminar, Me.tlbImprimir, Me.ToolBarExcel, Me.ToolBarButtonSeparador1, Me.ToolBarImportar, Me.tlbRecalcular, Me.ToolBarButtonSeparador2, Me.tlbCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(60, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 344)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1128, 61)
        Me.ToolBar1.TabIndex = 110
        '
        'tlbNuevo
        '
        Me.tlbNuevo.Enabled = False
        Me.tlbNuevo.ImageIndex = 0
        Me.tlbNuevo.Text = "Nuevo"
        '
        'tlbBuscar
        '
        Me.tlbBuscar.Enabled = False
        Me.tlbBuscar.ImageIndex = 1
        Me.tlbBuscar.Text = "Buscar"
        '
        'tlbRegistrar
        '
        Me.tlbRegistrar.Enabled = False
        Me.tlbRegistrar.ImageIndex = 2
        Me.tlbRegistrar.Text = "Registrar"
        '
        'tlbEliminar
        '
        Me.tlbEliminar.Enabled = False
        Me.tlbEliminar.ImageIndex = 3
        Me.tlbEliminar.Text = "Eliminar"
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Enabled = False
        Me.tlbImprimir.ImageIndex = 7
        Me.tlbImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarButtonSeparador1
        '
        Me.ToolBarButtonSeparador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarImportar
        '
        Me.ToolBarImportar.ImageIndex = 9
        Me.ToolBarImportar.Text = "Importar"
        Me.ToolBarImportar.Visible = False
        '
        'tlbRecalcular
        '
        Me.tlbRecalcular.Enabled = False
        Me.tlbRecalcular.ImageIndex = 10
        Me.tlbRecalcular.Text = "ReCalcular"
        Me.tlbRecalcular.Visible = False
        '
        'ToolBarButtonSeparador2
        '
        Me.ToolBarButtonSeparador2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tlbCerrar
        '
        Me.tlbCerrar.ImageIndex = 6
        Me.tlbCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(32, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Número factura:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(272, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(32, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Proveedor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label39.Location = New System.Drawing.Point(576, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(58, 15)
        Me.Label39.TabIndex = 114
        Me.Label39.Text = "Tipo:"
        '
        'cmbTipo
        '
        Me.cmbTipo.DisplayMember = "CON"
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.Blue
        Me.cmbTipo.Items.AddRange(New Object() {"CON", "CRE"})
        Me.cmbTipo.Location = New System.Drawing.Point(664, 16)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(61, 21)
        Me.cmbTipo.TabIndex = 3
        Me.cmbTipo.ValueMember = "CON"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(168, 48)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(80, 20)
        Me.txtNumeroFactura.TabIndex = 1
        Me.txtNumeroFactura.Text = ""
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(400, 48)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMoneda)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 80)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DisplayMember = "CON"
        Me.cmbMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.ForeColor = System.Drawing.Color.Blue
        Me.cmbMoneda.Location = New System.Drawing.Point(664, 48)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(104, 21)
        Me.cmbMoneda.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(576, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Moneda:"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProveedor.DisplayMember = "Proveedores.CodigoProv"
        Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.ForeColor = System.Drawing.Color.Blue
        Me.cmbProveedor.ItemHeight = 13
        Me.cmbProveedor.Location = New System.Drawing.Point(168, 16)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(392, 21)
        Me.cmbProveedor.TabIndex = 0
        Me.cmbProveedor.ValueMember = "Proveedores.CodigoProv"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMoneda1)
        Me.GroupBox2.Controls.Add(Me.lblMoneda2)
        Me.GroupBox2.Controls.Add(Me.lblMoneda3)
        Me.GroupBox2.Controls.Add(Me.lblMoneda4)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCuentaContableDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtCuentaContable)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotalDescuento)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDetalleSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtDetalleDescuento)
        Me.GroupBox2.Controls.Add(Me.txtDetallePrecioUnidad)
        Me.GroupBox2.Controls.Add(Me.txtDetalleArticuloDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtDetalleCantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.gridDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 216)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'lblMoneda1
        '
        Me.lblMoneda1.Location = New System.Drawing.Point(16, 184)
        Me.lblMoneda1.Name = "lblMoneda1"
        Me.lblMoneda1.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda1.TabIndex = 138
        Me.lblMoneda1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda2
        '
        Me.lblMoneda2.Location = New System.Drawing.Point(168, 184)
        Me.lblMoneda2.Name = "lblMoneda2"
        Me.lblMoneda2.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda2.TabIndex = 137
        Me.lblMoneda2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda3
        '
        Me.lblMoneda3.Location = New System.Drawing.Point(336, 184)
        Me.lblMoneda3.Name = "lblMoneda3"
        Me.lblMoneda3.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda3.TabIndex = 136
        Me.lblMoneda3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda4
        '
        Me.lblMoneda4.Location = New System.Drawing.Point(576, 184)
        Me.lblMoneda4.Name = "lblMoneda4"
        Me.lblMoneda4.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda4.TabIndex = 135
        Me.lblMoneda4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(360, 32)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(64, 20)
        Me.txtImpuesto.TabIndex = 8
        Me.txtImpuesto.Text = ""
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(360, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Impuesto:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaContableDescripcion
        '
        Me.txtCuentaContableDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableDescripcion.Enabled = False
        Me.txtCuentaContableDescripcion.Location = New System.Drawing.Point(640, 32)
        Me.txtCuentaContableDescripcion.Name = "txtCuentaContableDescripcion"
        Me.txtCuentaContableDescripcion.Size = New System.Drawing.Size(168, 20)
        Me.txtCuentaContableDescripcion.TabIndex = 11
        Me.txtCuentaContableDescripcion.Text = ""
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(640, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 16)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Descripción:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Location = New System.Drawing.Point(512, 32)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(120, 20)
        Me.txtCuentaContable.TabIndex = 10
        Me.txtCuentaContable.Text = ""
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(512, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Cuenta contable:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(600, 184)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 129
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(600, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalImpuesto
        '
        Me.txtTotalImpuesto.BackColor = System.Drawing.Color.White
        Me.txtTotalImpuesto.Enabled = False
        Me.txtTotalImpuesto.Location = New System.Drawing.Point(360, 184)
        Me.txtTotalImpuesto.Name = "txtTotalImpuesto"
        Me.txtTotalImpuesto.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalImpuesto.TabIndex = 127
        Me.txtTotalImpuesto.Text = ""
        Me.txtTotalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(360, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Impuesto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalDescuento
        '
        Me.txtTotalDescuento.BackColor = System.Drawing.Color.White
        Me.txtTotalDescuento.Enabled = False
        Me.txtTotalDescuento.Location = New System.Drawing.Point(192, 184)
        Me.txtTotalDescuento.Name = "txtTotalDescuento"
        Me.txtTotalDescuento.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalDescuento.TabIndex = 125
        Me.txtTotalDescuento.Text = ""
        Me.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(192, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "Descuento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDetalleSubTotal
        '
        Me.txtDetalleSubTotal.Enabled = False
        Me.txtDetalleSubTotal.Location = New System.Drawing.Point(40, 184)
        Me.txtDetalleSubTotal.Name = "txtDetalleSubTotal"
        Me.txtDetalleSubTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtDetalleSubTotal.TabIndex = 123
        Me.txtDetalleSubTotal.Text = ""
        Me.txtDetalleSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(40, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Sub total:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDetalleDescuento
        '
        Me.txtDetalleDescuento.Location = New System.Drawing.Point(432, 32)
        Me.txtDetalleDescuento.Name = "txtDetalleDescuento"
        Me.txtDetalleDescuento.Size = New System.Drawing.Size(72, 20)
        Me.txtDetalleDescuento.TabIndex = 9
        Me.txtDetalleDescuento.Text = ""
        Me.txtDetalleDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetallePrecioUnidad
        '
        Me.txtDetallePrecioUnidad.Location = New System.Drawing.Point(256, 32)
        Me.txtDetallePrecioUnidad.Name = "txtDetallePrecioUnidad"
        Me.txtDetallePrecioUnidad.Size = New System.Drawing.Size(96, 20)
        Me.txtDetallePrecioUnidad.TabIndex = 7
        Me.txtDetallePrecioUnidad.Text = ""
        Me.txtDetallePrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetalleArticuloDescripcion
        '
        Me.txtDetalleArticuloDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleArticuloDescripcion.Enabled = False
        Me.txtDetalleArticuloDescripcion.Location = New System.Drawing.Point(72, 32)
        Me.txtDetalleArticuloDescripcion.Name = "txtDetalleArticuloDescripcion"
        Me.txtDetalleArticuloDescripcion.Size = New System.Drawing.Size(176, 20)
        Me.txtDetalleArticuloDescripcion.TabIndex = 6
        Me.txtDetalleArticuloDescripcion.Text = ""
        '
        'txtDetalleCantidad
        '
        Me.txtDetalleCantidad.Location = New System.Drawing.Point(8, 32)
        Me.txtDetalleCantidad.Name = "txtDetalleCantidad"
        Me.txtDetalleCantidad.Size = New System.Drawing.Size(56, 20)
        Me.txtDetalleCantidad.TabIndex = 5
        Me.txtDetalleCantidad.Text = ""
        Me.txtDetalleCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(432, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Descuento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(256, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Precio unidad:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(72, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 16)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Descripción:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridDetalle
        '
        Me.gridDetalle.DataSource = Me.dtsGasto.GastoDetalle
        '
        'gridDetalle.EmbeddedNavigator
        '
        Me.gridDetalle.EmbeddedNavigator.Name = ""
        Me.gridDetalle.Location = New System.Drawing.Point(8, 64)
        Me.gridDetalle.MainView = Me.GridView1
        Me.gridDetalle.Name = "gridDetalle"
        Me.gridDetalle.Size = New System.Drawing.Size(800, 96)
        Me.gridDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.gridDetalle.TabIndex = 0
        Me.gridDetalle.Text = "GridControl1"
        '
        'dtsGasto
        '
        Me.dtsGasto.DataSetName = "DatasetGasto"
        Me.dtsGasto.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn8, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cantidad"
        Me.GridColumn1.FieldName = "Cantidad"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 112
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 112
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Precio unidad"
        Me.GridColumn3.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Costo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 112
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "% Des"
        Me.GridColumn4.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Descuento_P"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 108
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "% Imp"
        Me.GridColumn8.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Impuesto_p"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Sub total"
        Me.GridColumn5.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 111
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Cuenta contable"
        Me.GridColumn6.FieldName = "CuentaContable"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 111
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Descripción"
        Me.GridColumn7.FieldName = "CuentaContableDescripcion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 120
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(480, 368)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "Usuario->"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Blue
        Me.txtClave.Location = New System.Drawing.Point(560, 368)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 13)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(480, 384)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(152, 13)
        Me.TxtNombreUsuario.TabIndex = 126
        '
        'frmGasto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 406)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label46)
        Me.MaximumSize = New System.Drawing.Size(840, 440)
        Me.Name = "frmGasto"
        Me.Text = "Registro de gastos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones GUI"

    Private Sub frmGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub gridDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            EliminarDetalle()
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()
            Case 1 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : If PMU.Update Then AgregarEncabezadoBD() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Delete Then EliminarBD() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 8 : Me.CalcularTotales()

            Case 10 : Me.Close()

        End Select

       
    End Sub


    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If Me.cmbMoneda.SelectedIndex = -1 Then Exit Sub

        ObtenerFormatoMoneda(IdMoneda(Me.cmbMoneda.SelectedIndex))
    End Sub

#Region "Funciones KeyDown"

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarUsuario() = False Then
                Me.DesactivarCabezera()
                DesactivarToolBar()
                MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                Me.txtClave.Text = ""
            Else
                Me.tlbNuevo.Enabled = True
                Me.tlbBuscar.Enabled = True
                Nuevo()
            End If

        End If
    End Sub

    Private Sub txtNumeroFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroFactura.KeyDown
        If Me.cmbProveedor.SelectedIndex = -1 Then
            MsgBox("Elija primero el proveedor", MsgBoxStyle.Information)
            Me.txtNumeroFactura.Text = ""
            cmbProveedor.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            If txtNumeroFactura.Text = "" Then Exit Sub
            If ValidarFactura() = False Then
                MsgBox("El número de factura ya existe", MsgBoxStyle.Information)
                txtNumeroFactura.Text = ""
                txtNumeroFactura.Focus()
                Exit Sub
            End If
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim valor As String
            valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...", CadenaConexionSeePOS)

            If valor = "" Then
                Me.cmbProveedor.SelectedIndex = -1
            Else
                Me.BuscarProveedor(valor)

            End If
        End If
    End Sub

    Private Sub cmbMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarCabezera() = True Then
                ActivarDetalle()
                Me.txtDetalleCantidad.Focus()
            End If

        End If
    End Sub
    Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetalleCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetalleArticuloDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPrecioUnidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetallePrecioUnidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescuento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetalleDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtImpuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtImpuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCuentaContable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable()
            If ValidarDetalle() = True Then
                AgregarDetalle()
                CalcularTotales()
                Me.LimpiarDetalle()
                txtDetalleCantidad.Focus()
                IdDetalle = -1
            End If
        End If
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
    End Sub

#End Region

#End Region

#Region "Funciones Basicas"

    Private Sub AgregarDetalle()

        Dim Descuento, PrecioUnidad, TotalImpuesto As Double
        Dim Cantidad As Integer
        Descuento = Me.txtDetalleDescuento.Text
        Cantidad = Me.txtDetalleCantidad.Text
        PrecioUnidad = Me.txtDetallePrecioUnidad.Text
        impuesto = Me.txtImpuesto.Text

        Dim NuevaFila As DatasetGasto.GastoDetalleRow
        NuevaFila = Me.dtsGasto.GastoDetalle.NewGastoDetalleRow
        NuevaFila.Cantidad = Me.txtDetalleCantidad.Text
        NuevaFila.IdCompra = -1
        NuevaFila.Descuento = (Descuento / 100) * (PrecioUnidad * Cantidad)
        NuevaFila.Impuesto = (impuesto / 100) * ((PrecioUnidad * Cantidad) - NuevaFila.Descuento)
        NuevaFila.Impuesto_p = impuesto
        NuevaFila.Total = (PrecioUnidad * Cantidad) - NuevaFila.Descuento
        NuevaFila.CuentaContable = Me.txtCuentaContable.Text
        NuevaFila.Descripcion = Me.txtDetalleArticuloDescripcion.Text
        NuevaFila.CuentaContableDescripcion = Me.txtCuentaContableDescripcion.Text
        NuevaFila.Descuento_P = Descuento

        If impuesto = 0 Then
            NuevaFila.Gravado = 0
            NuevaFila.Exento = NuevaFila.Total
        Else
            NuevaFila.Gravado = NuevaFila.Total
            NuevaFila.Exento = 0
        End If

        NuevaFila.Costo = Me.txtDetallePrecioUnidad.Text
        NuevaFila.NuevoCostoBase = NuevaFila.Total / Cantidad

        dtsGasto.GastoDetalle.AddGastoDetalleRow(NuevaFila)


    End Sub

    Private Sub EliminarDetalle()

        If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim posicion As Integer
        If Me.dtsGasto.GastoDetalle.Count = 0 Then Exit Sub
        posicion = Me.BindingContext(dtsGasto.GastoDetalle).Position()
        dtsGasto.GastoDetalle.Rows.RemoveAt(posicion)
        CalcularTotales()
    End Sub

    Private Sub BuscarEncabezado(ByVal pIdGasto As Double)

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader


        sql = "SELECT Factura,CodigoProv,Fecha,TipoCompra,Cod_MonedaCompra FROM dbo.Compras  WHERE ID_Compra = " & pIdGasto

        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Sub

        Me.txtNumeroFactura.Text = rsReader("Factura")
        Me.dtpFecha.Value = rsReader("Fecha")
        If rsReader("TipoCompra") = "CON" Then
            Me.cmbTipo.SelectedIndex = 0
        Else
            Me.cmbTipo.SelectedIndex = 1
        End If

        BuscarProveedor(rsReader("CodigoProv"))
        BuscarMoneda(rsReader("Cod_MonedaCompra"))
        ObtenerFormatoMoneda(rsReader("Cod_MonedaCompra"))

        cnnConexion.Close()

        CargarGridDetalle(pIdGasto)
        CalcularTotales()

    End Sub

    Private Sub BuscarProveedor(ByVal pIdProveedor)
        Dim n As Integer


        For n = 0 To cmbProveedor.Items.Count - 1
            If idProveedor(n) = pIdProveedor Then
                Me.cmbProveedor.SelectedIndex = n
            End If
        Next

    End Sub

    Private Sub BuscarMoneda(ByVal pIdMoneda)
        Dim n As Integer


        For n = 0 To cmbMoneda.Items.Count - 1
            If IdMoneda(n) = pIdMoneda Then
                Me.cmbMoneda.SelectedIndex = n
            End If
        Next

    End Sub

    Private Function BuscarTipoCambio(ByVal pIdMoneda As Double) As Double

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader

        BuscarTipoCambio = 1
        sql = "SELECT ValorCompra FROM SeePos.dbo.Moneda  WHERE CodMoneda = " & pIdMoneda

        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Function

        BuscarTipoCambio = rsReader("ValorCompra")

        cnnConexion.Close()


    End Function

    Private Sub AgregarEncabezadoBD()

        If Me.dtsGasto.GastoDetalle.Count = 0 Then
            MsgBox("No se llenaron los item del gasto, no se pude registrar el gasto", MsgBoxStyle.Information)
            Exit Sub
        End If

        If ValidarModificarElimar() = False Then
            MsgBox("No se puede modificar la factura")
            Exit Sub
        End If

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim Grabado, exento, TotalImpuesto, TotalDescuento, Total As Double
        Dim FechaVence As Date
        Dim Plazo As Double
        Dim Cx As New Conexion
        Dim n As Integer

        TotalImpuesto = Me.txtTotalImpuesto.Text
        Total = Me.txtTotal.Text
        TotalDescuento = Me.txtTotalDescuento.Text

        For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            With dtsGasto.GastoDetalle(n)
                Grabado = Grabado + .Gravado
                exento = exento + .Exento

            End With
        Next

        Dim TipoFactura(2) As String
        TipoFactura(0) = "CON"
        TipoFactura(1) = "CRE"


        Plazo = Cx.SlqExecuteScalar(Cx.Conectar("SeePos"), "SELECT Plazo FROM Proveedores WHERE CodigoProv = " & idProveedor.GetValue(cmbProveedor.SelectedIndex))
        Cx.DesConectar(Cx.sQlconexion)
        FechaVence = Me.dtpFecha.Value.Date.AddDays(Plazo)

        If IdGasto = -1 Then
            sql = " INSERT INTO Compras (Factura,CodigoProv,SubTotalGravado,SubTotalExento,Descuento,Impuesto" & _
                " ,TotalFactura, Fecha,Vence,FechaIngreso,Gasto,TipoCompra,Cod_MonedaCompra,TipoCambio,CedulaUsuario) " & _
                " VALUES (" & txtNumeroFactura.Text & "," & idProveedor(Me.cmbProveedor.SelectedIndex) & "," & _
                Grabado & "," & exento & "," & TotalDescuento & "," & _
                TotalImpuesto & "," & Total & ",'" & Me.dtpFecha.Value.Date & "','" & _
                FechaVence & "','" & Date.Now.Date & "',1,'" & TipoFactura(Me.cmbTipo.SelectedIndex) & "'," & IdMoneda(Me.cmbMoneda.SelectedIndex) & "," & BuscarTipoCambio(IdMoneda(Me.cmbMoneda.SelectedIndex)) & " , '" & Me.Id_Usuario & "' )"
        Else
            sql = "UPDATE Compras SET Factura =" & txtNumeroFactura.Text & ",CodigoProv=" & idProveedor(Me.cmbProveedor.SelectedIndex) & "," & _
                    "SubTotalGravado=" & Grabado & ",SubTotalExento=" & exento & ",Descuento=" & TotalDescuento & "," & _
                    "Impuesto =" & TotalImpuesto & ", TotalFactura=" & Total & ",Fecha ='" & dtpFecha.Value.Date & "'," & _
                    "Vence = '" & FechaVence & "', FechaIngreso='" & dtpFecha.Value.Date & "'" & _
                    ",TipoCompra='" & TipoFactura(Me.cmbTipo.SelectedIndex) & "',Cod_MonedaCompra=" & IdMoneda(Me.cmbMoneda.SelectedIndex) & ", TipoCambio = " & BuscarTipoCambio(IdMoneda(Me.cmbMoneda.SelectedIndex)) & "  WHERE ID_Compra =" & IdGasto
        End If

        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()
        clsConexion.SlqExecute(cnnConexion, sql)

        If IdGasto = -1 Then
            sql = "Select max(id_compra) from compras where Factura = " & Me.txtNumeroFactura.Text & " and codigoprov = " & idProveedor(Me.cmbProveedor.SelectedIndex) & " and gasto = 1"
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            rstReader.Read()
            IdGasto = rstReader(0)
        End If
        cnnConexion.Close()

        AgregarDetalleBD(IdGasto)

        MsgBox("La factura de gasto ha sido registrado correctamente", MsgBoxStyle.Information)

        Me.tlbNuevo.Enabled = True
        Me.tlbBuscar.Enabled = True
        Me.tlbRegistrar.Enabled = True
        Me.tlbEliminar.Enabled = True
        Me.tlbImprimir.Enabled = True

        Me.LimpiarCabezera()
        Me.ActivarCabezera()
        Me.DesactivarDetalle()
        Me.dtsGasto.GastoDetalle.Clear()
    End Sub

    Private Sub AgregarDetalleBD(ByVal pIdGasto As Double)
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer


        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()

        sql = "DELETE FROM Articulos_Gastos WHERE IDCOMPRA = " & pIdGasto
        clsConexion.SlqExecute(cnnConexion, sql)


        For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            With dtsGasto.GastoDetalle(n)
                sql = "INSERT INTO Articulos_Gastos(IdCompra,Descripcion,Base,Costo,Cantidad,Gravado,Exento," & _
                        "Descuento_p,Descuento,Impuesto_p,Impuesto,Total,NuevoCostoBase,CuentaContable)" & _
                        " VALUES(" & pIdGasto & ",'" & .Descripcion & _
                        "'," & .Costo & "," & .Costo & "," & .Cantidad & "," & .Gravado & "," & .Exento & _
                        "," & .Descuento_P & "," & .Descuento & "," & .Impuesto_p & "," & .Impuesto & _
                        "," & .Total & "," & .NuevoCostoBase & ",'" & .CuentaContable & "')"
                clsConexion.SlqExecute(cnnConexion, sql)
            End With
        Next
        cnnConexion.Close()

    End Sub

    Private Sub EliminarBD()
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer

        If IdGasto = -1 Then Exit Sub
        If ValidarModificarElimar() = False Then
            MsgBox("No se puede eliminar la factura")
            Exit Sub
        End If

        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()


        If MessageBox.Show("¿Desea eliminar esta Factura de gasto ?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = 6 Then


            'Elimnar los detalles
            sql = "Delete from Articulos_Gastos where IdCompra=" & IdGasto
            clsConexion.SlqExecute(cnnConexion, sql)

            'Eliminar la cabezara
            sql = "DELETE FROM  Compras where id_compra =" & IdGasto
            clsConexion.SlqExecute(cnnConexion, sql)

            cnnConexion.Close()

            Me.tlbNuevo.Enabled = True
            Me.tlbBuscar.Enabled = True
            Me.tlbRegistrar.Enabled = False
            Me.tlbEliminar.Enabled = False
            Me.tlbImprimir.Enabled = False

            Me.LimpiarCabezera()
            Me.DesactivarCabezera()
        End If
    End Sub

    Private Sub Nuevo()
        Try

            Me.dtsGasto.GastoDetalle.Clear()
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.LimpiarCabezera()
                Me.ActivarCabezera()
                Me.DesactivarDetalle()

                Me.tlbNuevo.Enabled = True
                Me.tlbBuscar.Enabled = True
                Me.tlbRegistrar.Enabled = True
                Me.tlbEliminar.Enabled = False
                Me.tlbImprimir.Enabled = False
                Me.cmbProveedor.Focus()
            Else
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.LimpiarCabezera()
                Me.DesactivarCabezera()

                Me.tlbNuevo.Enabled = True
                Me.tlbBuscar.Enabled = True
                Me.tlbRegistrar.Enabled = False
                Me.tlbEliminar.Enabled = False
                Me.tlbImprimir.Enabled = False
            End If



        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Me.LimpiarCabezera()
        Me.dtsGasto.GastoDetalle.Clear()
        Try

            Dim identificador As Double
            Dim Fx As New cFunciones
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (cast(cast(Factura as decimal) as varchar) + '-' + TipoCompra) as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv WHERE Compras.Gasto = 1 Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra", CadenaConexionSeePOS))


            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                IdGasto = -1
                Exit Sub
            End If
            IdGasto = identificador

            'llenar las compras
            BuscarEncabezado(IdGasto)

            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try


        Me.tlbNuevo.Enabled = True
        Me.tlbBuscar.Enabled = True
        Me.tlbRegistrar.Enabled = True
        Me.tlbEliminar.Enabled = True
        Me.tlbImprimir.Enabled = True

        Me.ActivarCabezera()
        Me.ActivarDetalle()

    End Sub

    Private Sub Imprimir()
        If IdGasto = -1 Then Exit Sub

        Try
            Dim rptReporte As New rptGasto2
            rptReporte.SetParameterValue(0, IdGasto)
            CrystalReportsConexion.LoadShow(rptReporte, MdiParent, CadenaConexionSeePOS)

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarDetalle()
        If IdDetalle = -1 Then Exit Sub
        impuesto = Me.txtImpuesto.Text
        With Me.dtsGasto.GastoDetalle(IdDetalle)
            Dim Descuento, PrecioUnidad, TotalImpuesto As Double
            Dim Cantidad As Integer
            .Cantidad = Me.txtDetalleCantidad.Text
            .IdCompra = -1
            .Descuento = (Descuento / 100) * (PrecioUnidad * Cantidad)
            .Impuesto = (impuesto / 100) * ((PrecioUnidad * Cantidad) - .Descuento)
            .Impuesto_p = impuesto
            .Total = (PrecioUnidad * Cantidad) - .Descuento + .Impuesto
            .CuentaContable = Me.txtCuentaContable.Text
            .Descripcion = Me.txtDetalleArticuloDescripcion.Text
            .CuentaContableDescripcion = Me.txtCuentaContableDescripcion.Text
            .Descuento_P = Me.txtDetalleDescuento.Text

            If impuesto = 0 Then
                .Gravado = 0
                .Exento = .Total
            Else
                .Gravado = .Total
                .Exento = 0
            End If

            .Costo = Me.txtDetallePrecioUnidad.Text
            .NuevoCostoBase = .Total / Cantidad
        End With
        CalcularTotales()
    End Sub

    Private Sub BuscarCuentaContable()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT descripcion  FROM CuentaContable where CuentaContable = '" & Me.txtCuentaContable.Text & "' "

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then
            Me.txtCuentaContable.Text = ""
            Me.txtCuentaContableDescripcion.Text = ""
            Exit Sub
        End If

        Me.txtCuentaContableDescripcion.Text = rstReader(0)

        cnnConexion.Close()
    End Sub

    Private Sub LlamarFmrBuscarAsientoVenta()

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        Me.txtCuentaContable.Text = busca.codigo
        Me.txtCuentaContableDescripcion.Text = busca.descrip

    End Sub

    Private Sub ObtenerFormatoMoneda(ByVal pIdMoneda)

        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        sql = "SELECT Simbolo FROM Moneda where CodMoneda =" & pIdMoneda
        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Sub

        Me.lblMoneda1.Text = rstReader("Simbolo")
        Me.lblMoneda2.Text = rstReader("Simbolo")
        Me.lblMoneda3.Text = rstReader("Simbolo")
        Me.lblMoneda4.Text = rstReader("Simbolo")



        cnnConexion.Close()

    End Sub
#End Region

#Region "Funciones Validar"

    Private Function ValidarFactura() As Boolean
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion = clsConexion.Conectar("SeePos")

        sql = " SELECT COUNT(*) FROM Compras where factura = " & Me.txtNumeroFactura.Text & " AND CodigoProv=" & idProveedor(cmbProveedor.SelectedIndex)

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Exit Function
        If rstReader(0) = 0 Then
            ValidarFactura = True
        Else
            ValidarFactura = False
        End If
        clsConexion.DesConectar(cnnConexion)
    End Function

    Private Function ValidarCabezera() As Boolean

        If Me.txtNumeroFactura.Text = "" Then
            MensajeError(txtNumeroFactura, "No se han completado los datos de la cabezera")
            Exit Function
        End If

        If Me.cmbTipo.SelectedIndex = -1 Then
            MensajeError(cmbTipo, "No se han completado los datos de la cabezera")
            Exit Function
        End If

        If Me.cmbProveedor.SelectedIndex = -1 Then
            MensajeError(cmbProveedor, "No se han completado los datos de la cabezera")
            Exit Function
        End If

        If Me.cmbMoneda.SelectedIndex = -1 Then
            MensajeError(cmbMoneda, "No se han completado los datos de la cabezera")
            Exit Function
        End If
        ValidarCabezera = True

    End Function

    Private Function ValidarDetalle() As Boolean

        If Me.txtDetalleCantidad.Text = "" Then
            MensajeError(txtDetalleCantidad, "No se han completado los datos del detalle")
            Exit Function
        End If


        If Me.txtDetalleArticuloDescripcion.Text = "" Then
            MensajeError(txtDetalleArticuloDescripcion, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtDetallePrecioUnidad.Text = "" Then
            MensajeError(txtDetallePrecioUnidad, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtDetalleDescuento.Text = "" Then
            MensajeError(txtDetalleDescuento, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtImpuesto.Text = "" Then
            MensajeError(txtImpuesto, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtCuentaContable.Text = "" Then
            MensajeError(txtCuentaContable, "No se han completado los datos del detalle")
            Exit Function
        End If

        ValidarDetalle = True
    End Function

    Private Sub MensajeError(ByVal pObjeto As Object, ByVal pMensaje As String)
        MsgBox(pMensaje, MsgBoxStyle.Information)
        pObjeto.focus()
    End Sub

    Private Function ValidarUsuario() As Boolean
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader


        sql = "SELECT Nombre, Id_Usuario FROM USUARIOS WHERE Clave_interna= '" & txtClave.Text & "' AND ID_USUARIO ='" & Usua.Cedula & "'"

        cnnConexion.ConnectionString = CadenaConexionSeguridad
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Function

        Me.TxtNombreUsuario.Text = rsReader(0)
        Me.Id_Usuario = rsReader(1)
        cnnConexion.Close()

        ValidarUsuario = True
    End Function

    Private Function ValidarModificarElimar() As Boolean
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        If IdGasto = -1 Then
            ValidarModificarElimar = True
            Exit Function
        End If
        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()
        sql = " select count(*) from compras where (Contabilizado = 1 or facturacancelado = 1  " & _
        " ) AND ID_compra = " & IdGasto

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Exit Function

        If rstReader(0) = 0 Then
            ValidarModificarElimar = True
        Else
            ValidarModificarElimar = False
        End If

    End Function


#End Region

#Region "Funciones Calculos"

    Private Sub CalcularTotales()
        Dim n As Integer = 0
        Dim subtotal, descuento, impuesto As Double

        For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            With dtsGasto.GastoDetalle(n)
                impuesto = .Impuesto + impuesto
                descuento = .Descuento + descuento
                subtotal = (.Cantidad * .Costo) + subtotal

            End With
        Next
        Me.txtTotalDescuento.Text = Format(descuento, "###,##0.00")
        Me.txtTotalImpuesto.Text = Format(impuesto, "###,##0.00")
        Me.txtDetalleSubTotal.Text = Format(subtotal, "###,##0.00")
        Me.txtTotal.Text = Format(subtotal - descuento + impuesto, "###,##0.00")
    End Sub

#End Region

#Region "Funciones Cargar"

    Private Sub ActivarCabezera()
        Me.txtNumeroFactura.Enabled = True
        Me.dtpFecha.Enabled = True
        Me.cmbTipo.Enabled = True
        Me.cmbProveedor.Enabled = True
        Me.cmbMoneda.Enabled = True
    End Sub

    Private Sub DesactivarCabezera()
        Me.txtNumeroFactura.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.cmbTipo.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.cmbMoneda.Enabled = False

        DesactivarDetalle()
    End Sub

    Private Sub ActivarDetalle()
        Me.txtDetalleCantidad.Enabled = True
        Me.txtDetalleArticuloDescripcion.Enabled = True
        Me.txtDetallePrecioUnidad.Enabled = True
        Me.txtDetalleDescuento.Enabled = True
        Me.txtCuentaContable.Enabled = True
        Me.txtImpuesto.Enabled = True
    End Sub

    Private Sub DesactivarDetalle()
        Me.txtDetalleCantidad.Enabled = False
        Me.txtDetalleArticuloDescripcion.Enabled = False
        Me.txtDetallePrecioUnidad.Enabled = False
        Me.txtDetalleDescuento.Enabled = False
        Me.txtCuentaContable.Enabled = False
        Me.txtImpuesto.Enabled = False
    End Sub

    Private Sub LimpiarCabezera()
        IdGasto = -1
        Me.cmbProveedor.SelectedIndex = -1
        Me.cmbTipo.SelectedIndex = -1
        Me.cmbMoneda.SelectedIndex = -1
        Me.txtNumeroFactura.Text = ""
        Me.dtpFecha.Value = Date.Now
        Me.txtDetalleSubTotal.Text = "0"
        Me.txtTotal.Text = Format(0, "###,##0.00")
        Me.txtTotalDescuento.Text = Format(0, "###,##0.00")
        Me.txtTotalImpuesto.Text = Format(0, "###,##0.00")
        Me.lblMoneda1.Text = ""
        Me.lblMoneda2.Text = ""
        Me.lblMoneda3.Text = ""
        Me.lblMoneda4.Text = ""
        LimpiarDetalle()
    End Sub

    Private Sub LimpiarDetalle()
        Me.txtDetalleCantidad.Text = "1"
        Me.txtDetalleArticuloDescripcion.Text = ""
        Me.txtDetallePrecioUnidad.Text = "0"
        Me.txtDetalleDescuento.Text = "0"
        Me.txtCuentaContable.Text = ""
        Me.txtDetalleArticuloDescripcion.Text = ""
        Me.txtCuentaContableDescripcion.Text = ""
        Me.txtImpuesto.Text = "13"
        ' Me.dtsGasto.GastoDetalle.Clear()
    End Sub

    Private Sub DesactivarToolBar()
        Me.tlbNuevo.Enabled = False
        Me.tlbImprimir.Enabled = False
        Me.tlbEliminar.Enabled = False
        Me.tlbBuscar.Enabled = False
    End Sub

    Private Sub CargarTxtDetalle()

        If Me.dtsGasto.GastoDetalle.Count = 0 Then Exit Sub
        IdDetalle = Me.BindingContext(dtsGasto.GastoDetalle).Position()

        With dtsGasto.GastoDetalle(IdDetalle)
            Me.txtCuentaContable.Text = .CuentaContable
            Me.txtCuentaContableDescripcion.Text = .CuentaContableDescripcion
            Me.txtDetalleCantidad.Text = .Descuento_P
            impuesto = .Impuesto_p
            Me.txtImpuesto.Text = .Impuesto_p
            Me.txtDetalleArticuloDescripcion.Text = .Descripcion

        End With
    End Sub

    Private Sub CargarGridDetalle(ByVal pIdGasto)
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String
        Dim n As Integer


        sql = " SELECT A.Cantidad,A.IdCompra,A.Gravado, " & _
" A.Exento,A.Descuento,A.Impuesto,A.Total,A.CuentaContable, " & _
" A.Impuesto_p,A.NuevoCostoBase,A.Costo,A.Descuento_P ,A.Descripcion, " & _
" c.Descripcion as CuentaContableDescripcion " & _
" from Articulos_Gastos A, Contabilidad.dbo.cuentacontable C " & _
" WHERE  " & _
" C.cuentacontable  COLLATE Traditional_Spanish_CI_AS  = a.cuentacontable " & _
" and idcompra = " & pIdGasto

        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()

        Me.dtsGasto.GastoDetalle.Clear()
        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsGasto, "GastoDetalle")
    End Sub

#Region "FuncionesLLenar"

    Private Sub Cargar()
        Me.DesactivarCabezera()
        LlenarCmbProveedor()
        LlenarCmbMoneda()
        LimpiarCabezera()
    End Sub

    Private Sub LlenarCmbProveedor()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer
        sql = "SELECT CodigoProv,Nombre FROM Proveedores ORDER BY Nombre"
        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        n = 0
        Do While rstReader.Read
            cmbProveedor.Items.Add(rstReader("Nombre"))
            ReDim Preserve idProveedor(n + 1)
            idProveedor(n) = rstReader("CodigoProv")
            n = n + 1
        Loop
        cnnConexion.Close()
    End Sub

    Private Sub LlenarCmbMoneda()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer
        sql = "SELECT CodMoneda,MonedaNombre FROM Moneda "
        cnnConexion.ConnectionString = CadenaConexionSeePOS
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        n = 0
        Do While rstReader.Read
            cmbMoneda.Items.Add(rstReader("MonedaNombre"))
            ReDim Preserve idMoneda(n + 1)
            idMoneda(n) = rstReader("CodMoneda")
            n = n + 1
        Loop
        cnnConexion.Close()
    End Sub

#End Region

#End Region

   

    Private Sub txtCuentaContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContable.TextChanged

    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged

    End Sub

    Private Sub txtNumeroFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroFactura.TextChanged

    End Sub
End Class
