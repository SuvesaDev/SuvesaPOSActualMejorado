Imports System.Data.SqlClient
Imports system.Data
Imports System.Windows.Forms

Public Class frmOpcionesVisualizacion
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cbxUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cbxFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents LbTipoCambio As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetReporteInventario As DataSetReporteInventario
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents lblgeneral As System.Windows.Forms.Label
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblhasta As System.Windows.Forms.Label
    Friend WithEvents lbldesde As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterProveedor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterBodegas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cb_Bodegas As System.Windows.Forms.ComboBox
    Friend WithEvents lbodega As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionesVisualizacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblhasta = New System.Windows.Forms.Label()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lbodega = New System.Windows.Forms.Label()
        Me.Cb_Bodegas = New System.Windows.Forms.ComboBox()
        Me.DataSetReporteInventario = New LcPymes_5._2.DataSetReporteInventario()
        Me.codigo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.cbxMoneda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.lblgeneral = New System.Windows.Forms.Label()
        Me.cbxProveedor = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbxFamilia = New System.Windows.Forms.ComboBox()
        Me.cbxUbicacion = New System.Windows.Forms.ComboBox()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.cbxCondicion = New System.Windows.Forms.ComboBox()
        Me.LbTipoCambio = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterProveedor = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterBodegas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblhasta)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.lbodega)
        Me.GroupBox1.Controls.Add(Me.Cb_Bodegas)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMoneda)
        Me.GroupBox1.Controls.Add(Me.cbxMoneda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.lblgeneral)
        Me.GroupBox1.Controls.Add(Me.cbxProveedor)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.cbxFamilia)
        Me.GroupBox1.Controls.Add(Me.cbxUbicacion)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.cbxCondicion)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1072, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblhasta
        '
        Me.lblhasta.BackColor = System.Drawing.Color.Transparent
        Me.lblhasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhasta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblhasta.Location = New System.Drawing.Point(446, 8)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(96, 16)
        Me.lblhasta.TabIndex = 61
        Me.lblhasta.Text = "Hasta"
        Me.lblhasta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblhasta.Visible = False
        '
        'FechaFinal
        '
        Me.FechaFinal.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaFinal.Location = New System.Drawing.Point(438, 24)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(131, 20)
        Me.FechaFinal.TabIndex = 59
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        Me.FechaFinal.Visible = False
        '
        'lbodega
        '
        Me.lbodega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbodega.BackColor = System.Drawing.Color.Transparent
        Me.lbodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbodega.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbodega.Location = New System.Drawing.Point(776, 8)
        Me.lbodega.Name = "lbodega"
        Me.lbodega.Size = New System.Drawing.Size(192, 16)
        Me.lbodega.TabIndex = 66
        Me.lbodega.Text = "Bodegas"
        Me.lbodega.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbodega.Visible = False
        '
        'Cb_Bodegas
        '
        Me.Cb_Bodegas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Bodegas.DataSource = Me.DataSetReporteInventario.Bodegas
        Me.Cb_Bodegas.DisplayMember = "Nombre_Bodega"
        Me.Cb_Bodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Bodegas.ForeColor = System.Drawing.Color.Blue
        Me.Cb_Bodegas.Location = New System.Drawing.Point(776, 24)
        Me.Cb_Bodegas.Name = "Cb_Bodegas"
        Me.Cb_Bodegas.Size = New System.Drawing.Size(200, 21)
        Me.Cb_Bodegas.TabIndex = 65
        Me.Cb_Bodegas.ValueMember = "ID_Bodega"
        Me.Cb_Bodegas.Visible = False
        '
        'DataSetReporteInventario
        '
        Me.DataSetReporteInventario.DataSetName = "DataSetReporteInventario"
        Me.DataSetReporteInventario.Locale = New System.Globalization.CultureInfo("")
        Me.DataSetReporteInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'codigo
        '
        Me.codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.codigo.Items.AddRange(New Object() {"Id", "Barras"})
        Me.codigo.Location = New System.Drawing.Point(574, 24)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(96, 21)
        Me.codigo.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(566, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Codigo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMoneda
        '
        Me.lblMoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneda.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMoneda.Location = New System.Drawing.Point(679, 8)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(89, 16)
        Me.lblMoneda.TabIndex = 62
        Me.lblMoneda.Text = "Moneda"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMoneda.Visible = False
        '
        'cbxMoneda
        '
        Me.cbxMoneda.DataSource = Me.DataSetReporteInventario
        Me.cbxMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.cbxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMoneda.Location = New System.Drawing.Point(673, 24)
        Me.cbxMoneda.Name = "cbxMoneda"
        Me.cbxMoneda.Size = New System.Drawing.Size(95, 21)
        Me.cbxMoneda.TabIndex = 21
        Me.cbxMoneda.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ver Reporte Según"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"Articulos con Existencia en..", "Articulos Por Descripción", "Articulos Por Familia", "Articulos Por Ubicación", "Articulos Por Exist. Max.", "Articulos Por Exist. Min.", "Articulos Por Proveedor", "Toma Física de Inventario", "Toma Físca Por Ubicación", "Toma Física Por Categoría", "Artículos con servicios", "Artículos por Pedir", "Artículos por Pedir por Proveedor", "Listado de Precios", "Articulos Vendidos", "Control de Bodega"})
        Me.ComboBox1.Location = New System.Drawing.Point(8, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.Location = New System.Drawing.Point(984, 24)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'lbldesde
        '
        Me.lbldesde.BackColor = System.Drawing.Color.Transparent
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesde.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbldesde.Location = New System.Drawing.Point(264, 8)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(96, 16)
        Me.lbldesde.TabIndex = 60
        Me.lbldesde.Text = "Desde"
        Me.lbldesde.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbldesde.Visible = False
        '
        'lblgeneral
        '
        Me.lblgeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblgeneral.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblgeneral.Location = New System.Drawing.Point(264, 8)
        Me.lblgeneral.Name = "lblgeneral"
        Me.lblgeneral.Size = New System.Drawing.Size(256, 16)
        Me.lblgeneral.TabIndex = 22
        Me.lblgeneral.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblgeneral.Visible = False
        '
        'cbxProveedor
        '
        Me.cbxProveedor.DataSource = Me.DataSetReporteInventario.Proveedores
        Me.cbxProveedor.DisplayMember = "Nombre"
        Me.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProveedor.Enabled = False
        Me.cbxProveedor.ForeColor = System.Drawing.Color.Blue
        Me.cbxProveedor.Location = New System.Drawing.Point(264, 24)
        Me.cbxProveedor.Name = "cbxProveedor"
        Me.cbxProveedor.Size = New System.Drawing.Size(240, 21)
        Me.cbxProveedor.TabIndex = 7
        Me.cbxProveedor.ValueMember = "CodigoProv"
        Me.cbxProveedor.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripcion.Location = New System.Drawing.Point(264, 24)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(152, 20)
        Me.txtDescripcion.TabIndex = 14
        Me.txtDescripcion.Visible = False
        '
        'cbxFamilia
        '
        Me.cbxFamilia.DisplayMember = "SubFamilia"
        Me.cbxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFamilia.Enabled = False
        Me.cbxFamilia.ForeColor = System.Drawing.Color.Blue
        Me.cbxFamilia.Location = New System.Drawing.Point(264, 24)
        Me.cbxFamilia.Name = "cbxFamilia"
        Me.cbxFamilia.Size = New System.Drawing.Size(160, 21)
        Me.cbxFamilia.TabIndex = 9
        Me.cbxFamilia.Visible = False
        '
        'cbxUbicacion
        '
        Me.cbxUbicacion.DisplayMember = "Ubicacion"
        Me.cbxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUbicacion.Enabled = False
        Me.cbxUbicacion.ForeColor = System.Drawing.Color.Blue
        Me.cbxUbicacion.Location = New System.Drawing.Point(264, 24)
        Me.cbxUbicacion.Name = "cbxUbicacion"
        Me.cbxUbicacion.Size = New System.Drawing.Size(152, 21)
        Me.cbxUbicacion.TabIndex = 8
        Me.cbxUbicacion.Visible = False
        '
        'FechaInicio
        '
        Me.FechaInicio.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaInicio.Location = New System.Drawing.Point(264, 24)
        Me.FechaInicio.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.FechaInicio.MinDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(136, 20)
        Me.FechaInicio.TabIndex = 58
        Me.FechaInicio.Value = New Date(2006, 4, 10, 6, 0, 0, 0)
        Me.FechaInicio.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(328, 24)
        Me.txtCantidad.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(72, 20)
        Me.txtCantidad.TabIndex = 16
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Visible = False
        '
        'cbxCondicion
        '
        Me.cbxCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCondicion.ForeColor = System.Drawing.Color.Blue
        Me.cbxCondicion.ItemHeight = 13
        Me.cbxCondicion.Location = New System.Drawing.Point(264, 24)
        Me.cbxCondicion.Name = "cbxCondicion"
        Me.cbxCondicion.Size = New System.Drawing.Size(48, 21)
        Me.cbxCondicion.TabIndex = 10
        Me.cbxCondicion.Visible = False
        '
        'LbTipoCambio
        '
        Me.LbTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetReporteInventario, "Moneda.ValorCompra", True))
        Me.LbTipoCambio.Location = New System.Drawing.Point(616, 104)
        Me.LbTipoCambio.Name = "LbTipoCambio"
        Me.LbTipoCambio.Size = New System.Drawing.Size(100, 23)
        Me.LbTipoCambio.TabIndex = 22
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
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.AutoScroll = True
        Me.rptViewer.BackColor = System.Drawing.SystemColors.Control
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Location = New System.Drawing.Point(0, 64)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(1072, 504)
        Me.rptViewer.TabIndex = 73
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
    "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapterMoneda
        '
        Me.SqlDataAdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT MonedaNombre, ValorCompra, CodMoneda FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'AdapterProveedor
        '
        Me.AdapterProveedor.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterProveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodigoProv, Nombre FROM Proveedores"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'AdapterBodegas
        '
        Me.AdapterBodegas.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterBodegas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bodegas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Bodega", "ID_Bodega"), New System.Data.Common.DataColumnMapping("Nombre_Bodega", "Nombre_Bodega")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_Bodega, Nombre_Bodega FROM Bodegas ORDER BY Nombre_Bodega"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'frmOpcionesVisualizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1072, 566)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbTipoCambio)
        Me.Name = "frmOpcionesVisualizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
#End Region

#Region "Load"
    Private Sub frmOpcionesVisualizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection.ConnectionString = CadenaConexionSeePOS
        cConexion = New Conexion
        sqlConexion = cConexion.Conectar
        fulldata()
        SqlDataAdapterMoneda.Fill(Me.DataSetReporteInventario, "Moneda")
        AdapterBodegas.Fill(Me.DataSetReporteInventario, "Bodegas")
        FechaInicio.Value = Now
        FechaFinal.Value = Now
        codigo.SelectedIndex = 0
    End Sub

    Private Sub fulldata()
        'Condiciones
        Me.cbxCondicion.Items.Add("<")
        Me.cbxCondicion.Items.Add(">")
        Me.cbxCondicion.Items.Add("<=")
        Me.cbxCondicion.Items.Add(">=")
        Me.cbxCondicion.Items.Add("<>")
        Me.cbxCondicion.Items.Add("=")
        'Llena moneda
    End Sub
#End Region

#Region "Mostrar"

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim Reporte As New ConsultaInventario2
        Dim SQLConexion As New Conexion
        Dim EnEspera As New DevExpress.Utils.WaitDialogForm

        Try
            SQLConexion.SQLStringConexion = Me.SqlConnection.ConnectionString
            SQLConexion.Conectar()
            Reporte.RecordSelectionFormula = ""
            EnEspera.Caption = ComboBox1.Text
            EnEspera.Text = "Reporte de Inventario"
            EnEspera.Show()

            Application.DoEvents()
            Select Case Me.ComboBox1.SelectedIndex
                Case 0
                    If Me.cbxCondicion.Text <> "" Then Reporte.RecordSelectionFormula = "not {ConsultaInventario.Consignacion} and {ConsultaInventario.servicio} = false and {ConsultaInventario.Inhabilitado} = False and {ConsultaInventario.Existencia} " & Me.cbxCondicion.Text & " " & txtCantidad.Text
                    Reporte.SetParameterValue(0, "Reporte de Artículos por Existencia " & Me.cbxCondicion.Text & "" & Me.txtCantidad.Text & " Artículos")
                    Reporte.SetParameterValue(1, Me.cbxMoneda.Text)
                    Reporte.SetParameterValue(2, Me.LbTipoCambio.Text)
                    'Reporte.SetParameterValue(3, Me.codigo.Text) 'para codigos de barra o id
                    'Reporte.SetParameterValue(4, FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Reporte)

                Case 1
                    If Me.txtDescripcion.Text <> "" Then Reporte.RecordSelectionFormula = "{ConsultaInventario.Consignacion} = false and {ConsultaInventario.servicio} = false and {ConsultaInventario.Inhabilitado} = False and {ConsultaInventario.Descripcion} like '*" & Me.txtDescripcion.Text & "*'"
                    Reporte.SetParameterValue(0, "Reporte de Artículos por Descripción " & Me.txtDescripcion.Text & "")
                    Reporte.SetParameterValue(1, Me.cbxMoneda.Text)
                    Reporte.SetParameterValue(2, Me.LbTipoCambio.Text)
                    'Reporte.SetParameterValue(3, Me.codigo.Text) 'para codigos de barra o id
                    'Reporte.SetParameterValue(4, FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Reporte)

                Case 2
                    If Me.cbxFamilia.Text <> "" Then Reporte.RecordSelectionFormula = "{ConsultaInventario.Consignacion} = false and {ConsultaInventario.servicio} = false and {ConsultaInventario.Inhabilitado} = False and {ConsultaInventario.Familia}= '" & Me.cbxFamilia.Text & "'"
                    Reporte.SetParameterValue(0, "Reporte de Artículos por Familia " & Me.cbxFamilia.Text & "")
                    Reporte.SetParameterValue(1, Me.cbxMoneda.Text)
                    Reporte.SetParameterValue(2, Me.LbTipoCambio.Text)
                    'Reporte.SetParameterValue(3, Me.codigo.Text)    'para codigos de barra o id
                    'Reporte.SetParameterValue(4, FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Reporte)

                Case 3
                    If Me.cbxUbicacion.Text <> "" Then Reporte.RecordSelectionFormula = "{ConsultaInventario.Consignacion} = false and {ConsultaInventario.servicio} = false and {ConsultaInventario.Inhabilitado} = False and {ConsultaInventario.Ubicacion} LIKE '*" & Me.cbxUbicacion.Text & "*'"
                    Reporte.SetParameterValue(0, "Reporte de Artículos por Ubicación " & Me.cbxUbicacion.Text)
                    Reporte.SetParameterValue(1, Me.cbxMoneda.Text)
                    Reporte.SetParameterValue(2, Me.LbTipoCambio.Text)
                    'Reporte.SetParameterValue(3, Me.codigo.Text)    'para codigos de barra o id
                    'Reporte.SetParameterValue(4, FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Reporte)

                Case 4
                    Reporte.RecordSelectionFormula = "{ConsultaInventario.Consignacion} = false and {ConsultaInventario.servicio} = false and {ConsultaInventario.Inhabilitado} = False and {ConsultaInventario.maxima} > 0"
                    Reporte.SetParameterValue(0, "Reporte de Artículos con Existencias Máximas")
                    Reporte.SetParameterValue(1, Me.cbxMoneda.Text)
                    Reporte.SetParameterValue(2, Me.LbTipoCambio.Text)
                    'Reporte.SetParameterValue(3, Me.codigo.Text)    'para codigos de barra o id
                    'Reporte.SetParameterValue(4, FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Reporte)

                Case 5
                    Reporte.RecordSelectionFormula = "{ConsultaInventario.Consignacion} = false and {ConsultaInventario.servicio} = false and {ConsultaInventario.Inhabilitado} = False and  {ConsultaInventario.minima} > 0"
                    Reporte.SetParameterValue(0, "Reporte de Artículos con Existencias Mínimas")
                    Reporte.SetParameterValue(1, Me.cbxMoneda.Text)
                    Reporte.SetParameterValue(2, Me.LbTipoCambio.Text)
                    'Reporte.SetParameterValue(3, Me.codigo.Text)    'para codigos de barra o id
                    'Reporte.SetParameterValue(4, FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Reporte)

                Case 6
                    Dim ReporteXproveedor As New ConsultaInventarioXProveedor
                    ReporteXproveedor.SetParameterValue(2, "Reporte de Artículos por Proveedor " & cbxProveedor.Text)
                    ReporteXproveedor.SetParameterValue(0, Me.cbxMoneda.Text)
                    ReporteXproveedor.SetParameterValue(1, CDbl(Me.LbTipoCambio.Text))
                    ReporteXproveedor.SetParameterValue(3, Me.codigo.Text)  'para codigos de barra o id
                    ReporteXproveedor.SetParameterValue(4, cbxProveedor.SelectedValue)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, ReporteXproveedor)

                Case 7
                    Dim Inventario_Toma As New Inventario_Toma_Fisica
                    Inventario_Toma.SetParameterValue(0, Me.codigo.Text) 'para codigos de barra o id
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Inventario_Toma)

                Case 8
                    Dim TomaxUbicacion As New InventarioxUbicacion
                    TomaxUbicacion.SetParameterValue(0, Me.cbxUbicacion.Text)
                    TomaxUbicacion.SetParameterValue(1, Me.codigo.Text)     'para codigos de barra o id
                    CrystalReportsConexion.LoadReportViewer(rptViewer, TomaxUbicacion)

                Case 9
                    Dim TomaxCategoria As New InventarioxCategoria
                    TomaxCategoria.SetParameterValue(0, Me.cbxFamilia.Text)
                    TomaxCategoria.SetParameterValue(1, Me.codigo.Text)     'para codigos de barra o id
                    CrystalReportsConexion.LoadReportViewer(rptViewer, TomaxCategoria)

                Case 10
                    Dim Servicios As New InventarioxServicios
                    Servicios.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                    Servicios.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                    Servicios.SetParameterValue(2, Me.codigo.Text)      'para codigos de barra o id
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Servicios)

                Case 11
                    Dim APedirGeneral As New ArticulosxPedir
                    APedirGeneral.SetParameterValue(0, Me.cbxMoneda.Text)
                    APedirGeneral.SetParameterValue(1, Me.LbTipoCambio.Text)
                    APedirGeneral.SetParameterValue(2, Me.codigo.Text)  'para codigos de barra o id
                    CrystalReportsConexion.LoadReportViewer(rptViewer, APedirGeneral)

                Case 12
                    Dim APedirXProveedor As New ArticulosxPedirxProveedor
                    APedirXProveedor.SetParameterValue(0, Me.cbxMoneda.Text)
                    APedirXProveedor.SetParameterValue(1, Me.LbTipoCambio.Text)
                    APedirXProveedor.SetParameterValue(2, Me.cbxProveedor.Text)
                    APedirXProveedor.SetParameterValue(3, Me.codigo.Text)   'para codigos de barra o id
                    APedirXProveedor.SetParameterValue(4, cbxProveedor.SelectedValue)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, APedirXProveedor)

                Case 13

                    Dim ReporteListaPrecios As New ListadoPreciosVenta
                    ReporteListaPrecios.SetParameterValue(0, Me.cbxMoneda.Text)
                    ReporteListaPrecios.SetParameterValue(1, Me.LbTipoCambio.Text)
                    ReporteListaPrecios.SetParameterValue(2, Me.codigo.Text)    'para codigos de barra o id
                    CrystalReportsConexion.LoadReportViewer(rptViewer, ReporteListaPrecios)

                Case 14
                    'HACK AQUI FALTA EL REPORTE DE ArticulosVendidos
                    Dim ArticulosVentas As New ArticulosVendidos
                    ArticulosVentas.SetParameterValue(0, Me.cbxMoneda.Text)
                    ArticulosVentas.SetParameterValue(1, Me.LbTipoCambio.Text)
                    ArticulosVentas.SetParameterValue(2, Me.codigo.Text)    'para codigos de barra o id
                    ArticulosVentas.SetParameterValue(3, Me.FechaInicio.Value)
                    ArticulosVentas.SetParameterValue(4, Me.FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, ArticulosVentas)

                Case 15
                    Dim Bodegas As New ControlBodega
                    Bodegas.SetParameterValue(0, Me.FechaInicio.Value)
                    Bodegas.SetParameterValue(1, Me.FechaFinal.Value)
                    Bodegas.SetParameterValue(2, Me.Cb_Bodegas.SelectedValue)
                    CrystalReportsConexion.LoadReportViewer(rptViewer, Bodegas)
            End Select
            rptViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            EnEspera.Close()
            cConexion.DesConectar(SQLConexion.sQlconexion)
        End Try
    End Sub
#End Region

#Region "Combobox"
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.cbxCondicion.Visible = False
        Me.txtCantidad.Visible = False
        Me.txtDescripcion.Visible = False
        Me.cbxFamilia.Visible = False
        Me.cbxUbicacion.Visible = False
        Me.cbxProveedor.Visible = False
        Me.lblMoneda.Visible = True
        Me.cbxMoneda.Visible = True
        Me.cbxMoneda.Enabled = True
        Cb_Bodegas.Visible = False
        lbodega.Visible = False

        Select Case Me.ComboBox1.SelectedIndex
            Case 0
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = True
                Me.lblgeneral.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = True
                Me.cbxCondicion.Visible = True
                Me.txtCantidad.Visible = True

            Case 1
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = True
                Me.lblgeneral.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = True
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Descripción"
                Me.txtDescripcion.Visible = True
                Me.txtDescripcion.Enabled = True

            Case 2
                Me.cbxFamilia.DataSource = Nothing
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = True
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = True
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Familia"
                Me.cbxFamilia.Visible = True
                Me.cbxFamilia.Enabled = True
                cbxFamilia.Items.Clear()

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(sqlConexion, "SELECT distinct(descripcion) from familia")
                While rs.Read
                    Try
                        Me.cbxFamilia.Items.Add(rs!descripcion)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                rs.Close()

            Case 3
                Me.cbxUbicacion.DataSource = Nothing
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = True
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = True
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Ubicación"
                Me.cbxUbicacion.Visible = True
                Me.cbxUbicacion.Enabled = True
                cbxUbicacion.Items.Clear()

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(sqlConexion, "SELECT descripcion from ubicaciones")
                While rs.Read
                    Try
                        Me.cbxUbicacion.Items.Add(rs!descripcion)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                rs.Close()

            Case 4
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = True
                Me.lblgeneral.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = True

            Case 5
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = True
                Me.lblgeneral.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = True

            Case 6
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False
                Me.lblgeneral.Visible = False
                Me.cbxProveedor.Enabled = True
                Me.cbxProveedor.Visible = True
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Proveedor"
                DataSetReporteInventario.Proveedores.Clear()
                AdapterProveedor.Fill(DataSetReporteInventario, "Proveedores")

            Case 7
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False
                Me.lblgeneral.Visible = False
                Me.cbxCondicion.Visible = False
                Me.txtCantidad.Visible = False
                Me.txtDescripcion.Visible = False
                Me.cbxFamilia.Visible = False
                Me.cbxUbicacion.Visible = False
                Me.cbxProveedor.Visible = False

            Case 8
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False
                Me.cbxUbicacion.DataSource = Nothing
                Me.cbxCondicion.Visible = False
                Me.txtCantidad.Visible = False
                Me.txtDescripcion.Visible = False
                Me.cbxFamilia.Visible = False
                Me.cbxProveedor.Visible = False
                Me.cbxMoneda.Enabled = False
                Me.cbxUbicacion.Visible = True
                Me.cbxUbicacion.Enabled = True
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Ubicación"
                cbxUbicacion.Items.Clear()

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(sqlConexion, "SELECT descripcion from ubicaciones")
                While rs.Read
                    Try
                        Me.cbxUbicacion.Items.Add(rs!descripcion)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                rs.Close()

            Case 9
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False
                Me.cbxFamilia.DataSource = Nothing
                Me.cbxCondicion.Visible = False
                Me.txtCantidad.Visible = False
                Me.txtDescripcion.Visible = False
                Me.cbxUbicacion.Visible = False
                Me.cbxProveedor.Visible = False
                Me.cbxMoneda.Enabled = False
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Categoría"
                Me.cbxFamilia.Visible = True
                Me.cbxFamilia.Enabled = True
                cbxFamilia.Items.Clear()

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(sqlConexion, "SELECT distinct(descripcion) from familia")
                While rs.Read
                    Try
                        Me.cbxFamilia.Items.Add(rs!descripcion)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End While
                rs.Close()

            Case 10
                Me.lblgeneral.Visible = False
                Me.cbxFamilia.DataSource = Nothing
                Me.cbxCondicion.Visible = False
                Me.txtCantidad.Visible = False
                Me.txtDescripcion.Visible = False
                Me.cbxUbicacion.Visible = False
                Me.cbxProveedor.Visible = False
                Me.cbxMoneda.Enabled = False
                Me.FechaInicio.Text = Date.Today
                Me.FechaFinal.Text = Date.Today
                Me.FechaInicio.Visible = True
                Me.FechaFinal.Visible = True
                Me.lbldesde.Visible = True
                Me.lblhasta.Visible = True

            Case 11
                Me.lblMoneda.Visible = True
                Me.cbxMoneda.Visible = True
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.lblgeneral.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False

            Case 12
                Me.lblMoneda.Visible = True
                Me.cbxMoneda.Visible = True
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False
                Me.lblgeneral.Visible = True
                Me.lblgeneral.Text = "Proveedor"
                Me.cbxProveedor.Enabled = True
                Me.cbxProveedor.Visible = True
                DataSetReporteInventario.Proveedores.Clear()
                AdapterProveedor.Fill(DataSetReporteInventario, "Proveedores")

            Case 13
                Me.lblMoneda.Visible = True
                Me.cbxMoneda.Visible = True
                Me.lbldesde.Visible = False
                Me.lblhasta.Visible = False
                Me.lblgeneral.Visible = False
                Me.FechaInicio.Visible = False
                Me.FechaFinal.Visible = False

            Case 14
                Me.lblgeneral.Visible = False
                Me.lbldesde.Visible = True
                Me.lblhasta.Visible = True
                Me.FechaInicio.Visible = True
                Me.FechaFinal.Visible = True

            Case 15
                Me.lbldesde.Visible = True
                Me.lblhasta.Visible = True
                Me.lblgeneral.Visible = False
                lbodega.Visible = True
                Me.FechaInicio.Visible = True
                Me.FechaFinal.Visible = True
                Cb_Bodegas.Visible = True

        End Select
    End Sub
#End Region

    Private Sub BuscarProveedor()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...", CadenaConexionSeePOS)
            If valor = "" Then
                Exit Sub
            Else
                Me.cbxProveedor.SelectedValue = valor
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbxProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxProveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.BuscarProveedor()
        End If
    End Sub
End Class
