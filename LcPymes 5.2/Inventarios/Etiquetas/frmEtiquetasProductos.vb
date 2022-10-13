Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms
Public Class frmEtiquetasProductos
    Inherits System.Windows.Forms.Form
    Public tabla As New DataTable
    Public Automatico As Boolean
    Public Codigos(50) As Integer
    Public Cantidades(50) As Integer
    Public CodPro(50) As Integer
    Dim EtiquetasGuanavet As New rptEtiquetasGuanavetClinica
    Dim Etiquetas1 As New Etiquetas
    Dim Etiquetas2 As New EtiquetaSATOCX400_2C
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgEtiquetas As System.Windows.Forms.DataGridView
    Dim usua As Usuario_Logeado


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal f As Boolean, ByVal s() As Integer, ByVal w() As Integer, ByVal z() As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Automatico = f
        Codigos = s
        Cantidades = w
        CodPro = z
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoBarrrasCorrecto As System.Windows.Forms.TextBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents TextCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdEtiquetar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCorregir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textcod_Pro As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daArticulos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_ArticulosXProveedor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsEtiquetasArticulos1 As DsEtiquetasArticulos
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadioButtonFX As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCX As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetasProductos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonCX = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFX = New System.Windows.Forms.RadioButton()
        Me.cmdCorregir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEtiquetar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.DsEtiquetasArticulos1 = New LcPymes_5._2.DsEtiquetasArticulos()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoBarrrasCorrecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textcod_Pro = New System.Windows.Forms.TextBox()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.daArticulos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_ArticulosXProveedor = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgEtiquetas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsEtiquetasArticulos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cmdCorregir)
        Me.GroupBox1.Controls.Add(Me.cmdEtiquetar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextCantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarras)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarrrasCorrecto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Location = New System.Drawing.Point(8, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Artículos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButtonCX)
        Me.Panel1.Controls.Add(Me.RadioButtonFX)
        Me.Panel1.Location = New System.Drawing.Point(394, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 57)
        Me.Panel1.TabIndex = 138
        Me.Panel1.Visible = False
        '
        'RadioButtonCX
        '
        Me.RadioButtonCX.Enabled = False
        Me.RadioButtonCX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButtonCX.Location = New System.Drawing.Point(10, 32)
        Me.RadioButtonCX.Name = "RadioButtonCX"
        Me.RadioButtonCX.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonCX.TabIndex = 1
        Me.RadioButtonCX.Text = "Estilo CX400"
        '
        'RadioButtonFX
        '
        Me.RadioButtonFX.Checked = True
        Me.RadioButtonFX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButtonFX.Location = New System.Drawing.Point(10, 9)
        Me.RadioButtonFX.Name = "RadioButtonFX"
        Me.RadioButtonFX.Size = New System.Drawing.Size(183, 19)
        Me.RadioButtonFX.TabIndex = 0
        Me.RadioButtonFX.TabStop = True
        Me.RadioButtonFX.Text = "Zebra GC420t (3""x1.25"")"
        '
        'cmdCorregir
        '
        Me.cmdCorregir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.cmdCorregir.Location = New System.Drawing.Point(479, 129)
        Me.cmdCorregir.Name = "cmdCorregir"
        Me.cmdCorregir.Size = New System.Drawing.Size(77, 28)
        Me.cmdCorregir.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.White)
        Me.cmdCorregir.TabIndex = 69
        Me.cmdCorregir.Text = "Corregir"
        '
        'cmdEtiquetar
        '
        Me.cmdEtiquetar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.cmdEtiquetar.Location = New System.Drawing.Point(394, 129)
        Me.cmdEtiquetar.Name = "cmdEtiquetar"
        Me.cmdEtiquetar.Size = New System.Drawing.Size(76, 28)
        Me.cmdEtiquetar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.White)
        Me.cmdEtiquetar.TabIndex = 68
        Me.cmdEtiquetar.Text = "Etiquetar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(234, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Cant."
        '
        'TextCantidad
        '
        Me.TextCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextCantidad.Location = New System.Drawing.Point(234, 137)
        Me.TextCantidad.Name = "TextCantidad"
        Me.TextCantidad.Size = New System.Drawing.Size(58, 16)
        Me.TextCantidad.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Código de barras"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoBarras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEtiquetasArticulos1, "Inventario.Barras", True))
        Me.txtCodigoBarras.Enabled = False
        Me.txtCodigoBarras.Location = New System.Drawing.Point(10, 92)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(211, 16)
        Me.txtCodigoBarras.TabIndex = 61
        Me.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DsEtiquetasArticulos1
        '
        Me.DsEtiquetasArticulos1.DataSetName = "DsEtiquetasArticulos"
        Me.DsEtiquetasArticulos1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DsEtiquetasArticulos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(577, 18)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Agrege la lista de los productos a etiquetar y por ultimo presione el boton impri" & _
    "mir"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 18)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Código de barras correcto"
        '
        'txtCodigoBarrrasCorrecto
        '
        Me.txtCodigoBarrrasCorrecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoBarrrasCorrecto.Location = New System.Drawing.Point(10, 138)
        Me.txtCodigoBarrrasCorrecto.Name = "txtCodigoBarrrasCorrecto"
        Me.txtCodigoBarrrasCorrecto.Size = New System.Drawing.Size(211, 16)
        Me.txtCodigoBarrrasCorrecto.TabIndex = 59
        Me.txtCodigoBarrrasCorrecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(126, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEtiquetasArticulos1, "Inventario.Descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripcion.Location = New System.Drawing.Point(126, 46)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(403, 19)
        Me.txtDescripcion.TabIndex = 55
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEtiquetasArticulos1, "Inventario.Codigo", True))
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(10, 46)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(105, 19)
        Me.txtCodigo.TabIndex = 53
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(10, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 19)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Código"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(506, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Pro"
        '
        'Textcod_Pro
        '
        Me.Textcod_Pro.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcod_Pro.Location = New System.Drawing.Point(506, 222)
        Me.Textcod_Pro.Name = "Textcod_Pro"
        Me.Textcod_Pro.Size = New System.Drawing.Size(58, 23)
        Me.Textcod_Pro.TabIndex = 70
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Inventario"
        Me.DataNavigator1.DataSource = Me.DsEtiquetasArticulos1
        Me.DataNavigator1.Location = New System.Drawing.Point(368, 624)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(192, 28)
        Me.DataNavigator1.TabIndex = 65
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        Me.ImageList2.Images.SetKeyName(8, "")
        Me.ImageList2.Images.SetKeyName(9, "")
        Me.ImageList2.Images.SetKeyName(10, "")
        Me.ImageList2.Images.SetKeyName(11, "")
        Me.ImageList2.Images.SetKeyName(12, "")
        Me.ImageList2.Images.SetKeyName(13, "")
        Me.ImageList2.Images.SetKeyName(14, "")
        Me.ImageList2.Images.SetKeyName(15, "")
        Me.ImageList2.Images.SetKeyName(16, "")
        Me.ImageList2.Images.SetKeyName(17, "")
        Me.ImageList2.Images.SetKeyName(18, "")
        Me.ImageList2.Images.SetKeyName(19, "")
        Me.ImageList2.Images.SetKeyName(20, "")
        Me.ImageList2.Images.SetKeyName(21, "")
        Me.ImageList2.Images.SetKeyName(22, "")
        Me.ImageList2.Images.SetKeyName(23, "")
        Me.ImageList2.Images.SetKeyName(24, "")
        Me.ImageList2.Images.SetKeyName(25, "")
        Me.ImageList2.Images.SetKeyName(26, "")
        Me.ImageList2.Images.SetKeyName(27, "")
        Me.ImageList2.Images.SetKeyName(28, "")
        Me.ImageList2.Images.SetKeyName(29, "")
        Me.ImageList2.Images.SetKeyName(30, "")
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
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.BackColor = System.Drawing.Color.LightGray
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 593)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(853, 60)
        Me.ToolBar1.TabIndex = 135
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        Me.ToolBarRegistrar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Eliminar"
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Name = "ToolBarExcel"
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HAZEL;packet size=4096;integrated security=SSPI;data source=SEESER" & _
    "VER;persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'daArticulos
        '
        Me.daArticulos.SelectCommand = Me.SqlSelectCommand1
        Me.daArticulos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Barras", "Barras"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Inhabilitado", "Inhabilitado"), New System.Data.Common.DataColumnMapping("Servicio", "Servicio")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Barras, Descripcion, Inhabilitado, Servicio FROM Inventario WHERE " & _
    "(Inhabilitado = 0) AND (Servicio = 0)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Adapter_ArticulosXProveedor
        '
        Me.Adapter_ArticulosXProveedor.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_ArticulosXProveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Articulos x Proveedor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoArticulo", "CodigoArticulo"), New System.Data.Common.DataColumnMapping("CodigoProveedor", "CodigoProveedor"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.DisplayBackgroundEdge = False
        Me.rptViewer.DisplayToolbar = False
        Me.rptViewer.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rptViewer.Location = New System.Drawing.Point(610, 46)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ShowCloseButton = False
        Me.rptViewer.ShowExportButton = False
        Me.rptViewer.ShowGotoPageButton = False
        Me.rptViewer.ShowGroupTreeButton = False
        Me.rptViewer.ShowPageNavigateButtons = False
        Me.rptViewer.ShowPrintButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.ShowTextSearchButton = False
        Me.rptViewer.ShowZoomButton = False
        Me.rptViewer.Size = New System.Drawing.Size(243, 600)
        Me.rptViewer.TabIndex = 137
        Me.rptViewer.ToolPanelWidth = 240
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 35)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "SISTEMA DE ETIQUETAS"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(454, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 35)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "Visor de la etiqueta"
        '
        'dgEtiquetas
        '
        Me.dgEtiquetas.AllowUserToAddRows = False
        Me.dgEtiquetas.AllowUserToResizeColumns = False
        Me.dgEtiquetas.AllowUserToResizeRows = False
        Me.dgEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtiquetas.Location = New System.Drawing.Point(8, 247)
        Me.dgEtiquetas.Name = "dgEtiquetas"
        Me.dgEtiquetas.RowHeadersVisible = False
        Me.dgEtiquetas.RowTemplate.Height = 29
        Me.dgEtiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtiquetas.Size = New System.Drawing.Size(596, 340)
        Me.dgEtiquetas.TabIndex = 139
        '
        'frmEtiquetasProductos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(853, 653)
        Me.Controls.Add(Me.dgEtiquetas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Textcod_Pro)
        Me.Name = "frmEtiquetasProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetas de Artículos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsEtiquetasArticulos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "variables"
    Private cConexion As New Conexion
    Private sqlConexion As SqlConnection
#End Region

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Try
            Dim PrintDocument1 As New PrintDocument
            Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
            Dim PrinterInstalled As String
            'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
            For Each PrinterInstalled In PrinterSettings.InstalledPrinters
                Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                    Case "ETIQUETAS" 'FACTURACION
                        If PrinterToSelect = 0 Then
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
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Private Sub cargarinformacion(ByVal codigo As String)
        Try
            Dim articulos() As System.Data.DataRow 'almacena temporalmente los datos de un artículo
            Dim articulo As System.Data.DataRow 'almacena temporalmente los datos de un artículo
            Dim pos As Integer
            Dim vista As DataView

            articulos = Me.DsEtiquetasArticulos1.Inventario.Select("codigo = " & codigo & "And Inhabilitado = 0")

            If articulos.Length <> 0 Then

                vista = Me.DsEtiquetasArticulos1.Inventario.DefaultView
                vista.Sort = "Codigo"
                pos = vista.Find(CDbl(codigo))
                Me.BindingContext(Me.DsEtiquetasArticulos1, "Inventario").CancelCurrentEdit()
                Me.BindingContext(Me.DsEtiquetasArticulos1, "Inventario").Position = pos


            Else
                MsgBox("No existe un artículo con ese código en el inventario", MsgBoxStyle.Information)
                Me.BindingContext(Me.DsEtiquetasArticulos1, "Inventario").CancelCurrentEdit()


            End If

        Catch ex As SystemException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmEtiquetasProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            CrystalReportsConexion.LoadReportViewer(Nothing, Etiquetas1, True)
            CrystalReportsConexion.LoadReportViewer(Nothing, Etiquetas2, True)
            CrystalReportsConexion.LoadReportViewer(Nothing, EtiquetasGuanavet, True)
            cConexion = New Conexion
            sqlConexion = cConexion.Conectar
            Me.daArticulos.Fill(Me.DsEtiquetasArticulos1.Inventario)
            ' Me.Adapter_ArticulosXProveedor.Fill(Me.DsEtiquetasArticulos1.Articulos_x_Proveedor)
            crear_tabla()

            If Me.Automatico Then
                Etiquetar_Factura()
            End If

        Catch ex As SyntaxErrorException  'cacha los errores
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Etiquetar_Factura()
        Dim i As Integer

        For i = 0 To 50
            If Codigos(i) = 0 Then Exit For
            Me.txtCodigo.Text = Codigos(i)
            Me.cargarinformacion(Me.txtCodigo.Text)
            Me.Textcod_Pro.Text = Me.CodPro(i)
            Me.TextCantidad.Text = Cantidades(i)
            Me.insertar()
        Next i

    End Function

    Private Sub txtCodProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown

        Select Case e.KeyCode
            Case Keys.F1 : Me.Buscar_articulo() 'consultar()

            Case Keys.Enter
                Me.cargarinformacion(Me.txtCodigo.Text)
        End Select

    End Sub

    Sub Buscar_articulo()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            Dim BuscarArticulo As New FrmBuscarArticulo2
            BuscarArticulo.ShowDialog()
            If BuscarArticulo.Cancelado Then
                Me.txtCodigo.Focus()
                Exit Sub
            Else
                valor = BuscarArticulo.Codigo
            End If

            vista = Me.DsEtiquetasArticulos1.Inventario.DefaultView
            vista.Sort = "Codigo"
            pos = vista.Find(CDbl(valor))
            Me.BindingContext(Me.DsEtiquetasArticulos1, "Inventario").Position = pos


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub crear_tabla()
        Try
            Dim dtCodigo, dtDescripcion, dtCodProveedor, dtCantidad As System.Data.DataColumn

            dtCodigo = New System.Data.DataColumn("Codigo")
            dtDescripcion = New System.Data.DataColumn("Descripcion")
            ' dtCodProveedor = New System.Data.DataColumn("Proveedor")
            dtCantidad = New System.Data.DataColumn("Cantidad")
            tabla.Columns.Add(dtCodigo)
            tabla.Columns.Add(dtDescripcion)
            'tabla.Columns.Add(dtCodProveedor)
            tabla.Columns.Add(dtCantidad)

            tabla.Columns(0).ReadOnly = True
            tabla.Columns(1).ReadOnly = True
            tabla.Columns(2).ReadOnly = False
            '  tabla.Columns(3).ReadOnly = False
            'tabla.Columns(2).DataType = System.Int32

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub insertar()
        Dim FilaEtiquetas As DataRow
        Dim cod_prov As Integer

        Try

            If Me.TextCantidad.Text = "" Then
                MsgBox("Debe digitar una cantidad", MsgBoxStyle.Information)
                Exit Sub
            End If

            If CInt(Me.TextCantidad.Text) < 1 Then
                MsgBox("Cantidad a etiquetar incorrecta", MsgBoxStyle.Information)
                Exit Sub
            End If

            FilaEtiquetas = tabla.NewRow



            ' If Not Me.Automatico Then Me.Textcod_Pro.Text = Text_cod_Pro.Text

            'If Me.Textcod_Pro.Text = "" Then
            '    Try
            '        cod_prov = CInt(InputBox("Código del Proveedor", ""))
            '        Me.Textcod_Pro.Text = cod_prov

            '    Catch ex As SystemException
            '        MsgBox("Digite un Código de Proveedor Válido", MsgBoxStyle.Exclamation)
            '        Me.Textcod_Pro.Text = ""
            '        Exit Sub
            '    End Try

            'End If

            FilaEtiquetas!Codigo = Me.txtCodigo.Text
            FilaEtiquetas!Descripcion = Me.txtDescripcion.Text
            'FilaEtiquetas!Proveedor = Me.Textcod_Pro.Text
            FilaEtiquetas!Cantidad = CInt(Me.TextCantidad.Text)

            tabla.Rows.Add(FilaEtiquetas)

            Me.dgEtiquetas.DataSource = Nothing
            Me.dgEtiquetas.DataSource = tabla

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImprimrEtiquetasGuanavet()
        Dim i As Integer
        Dim codigo As Integer
        Dim cant As Integer
        Dim Cod_Pro As Integer

        Dim dts As New DataSetEtiquetasGuanavetClinica

        Try
            Dim vueltas As Integer = 0

            For Each fila As DataGridViewRow In Me.dgEtiquetas.Rows

                vueltas = 0
                While vueltas < CInt(fila.Cells("Cantidad").Value)

                    Dim row As DataRow = dts.DatosEtiquetasAlbaranesCompra_Crystal.NewRow
                    row!idAlbaran = 0
                    row!cantidad = 0
                    row!ImporteUnitario = 0
                    row!descripcion = fila.Cells("Descripcion").Value '***
                    row!factorConversion = 0
                    row!idArticulo = fila.Cells("Codigo").Value '***
                    row!orden = ""
                    row!PVP1 = 0 '***
                    row!Moneda = 1 '***
                    row!UnidadMedida = ""
                    row!PesoEnvase = ""

                    dts.DatosEtiquetasAlbaranesCompra_Crystal.Rows.Add(row)
                    vueltas += 1
                End While

            Next

            EtiquetasGuanavet.SetDataSource(dts)
            Me.rptViewer.ReportSource = EtiquetasGuanavet
            EtiquetasGuanavet.PrintToPrinter(cant, True, 1, 1)

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Imprimir(ByVal Etiquetas As CrystalDecisions.CrystalReports.Engine.ReportDocument)

        Dim i As Integer
        Dim codigo As Integer
        Dim fila As DataRow
        Dim cant As Integer
        Dim Cod_Pro As Integer
        Try
            For i = 0 To (tabla.Rows.Count - 1)
                fila = tabla.NewRow
                fila!codigo = tabla.Rows.Item(i)(0)
                codigo = CInt(fila!codigo)
                fila!Cantidad = tabla.Rows.Item(i)(2)
                cant = CInt(fila!Cantidad)
                'fila!Proveedor = tabla.Rows.Item(i)(2)
                'Cod_Pro = CInt(fila!Proveedor)

                Etiquetas.SetParameterValue(0, codigo)
                'Etiquetas.SetParameterValue(1, Cod_Pro)

                Me.rptViewer.ReportSource = Etiquetas
                'Me.rptViewer.PrintReport()
                Etiquetas.PrintOptions.PrinterName = Automatic_Printer_Dialog(0)

                Etiquetas.PrintToPrinter(cant, True, 1, 1)
            Next i
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub eliminar_etiqueta()
    'Dim resp As String
    'Dim posicion As Integer

    'Try 'se intenta hacer
    '        If Me.BindingContext(Me.DsEtiquetasArticulos1, "inventario").Count > 0 Then ' si hay articulos

    'resp = MessageBox.Show("¿Desea eliminar excluir este artículo para impresión de etiquetas?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

    'If resp = 6 Then
    '    Try
    '        posicion = (Me.BindingContext(Me.DsEtiquetasArticulos1, "invetario").Position) + 1

    '        Me.BindingContext(Me.DsEtiquetasArticulos1, "inventario").RemoveAt(Me.BindingContext(Me.DsEtiquetasArticulos1, "inventario").Position)

    '        Me.BindingContext(Me.DsEtiquetasArticulos1.Inventario).RemoveAt(Me.BindingContext(Me.DsEtiquetasArticulos1.Inventario).Position = posicion)

    '        Me.daArticulos.Update(Me.DsEtiquetasArticulos1.Inventario)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '                End Try
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
                Case 5
                    ImprimrEtiquetasGuanavet()
                Case 7
                    Me.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'Private Sub dgEtiquetas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEtiquetas.KeyDown
    'If e.KeyCode = Keys.Delete Then
    'If dgEtiquetas.CurrentRowIndex <> -1 Then
    'eliminar_etiqueta()
    'End If
    'End If
    'End Sub

    'Private Sub dgEtiquetas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEtiquetas.KeyUp
    'If e.KeyCode = Keys.Delete Then
    'If dgEtiquetas.CurrentRowIndex <> -1 Then
    'eliminar_etiqueta()
    'End If
    'End If
    'End Sub

    'Private Sub dgEtiquetas_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgEtiquetas.Navigate
    'If dgEtiquetas.CurrentRowIndex = -1 Then Exit Sub
    'dgEtiquetas.Select(dgEtiquetas.CurrentRowIndex)
    'End Sub

    'Private Sub dgEtiquetas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEtiquetas.CurrentCellChanged
    'If dgEtiquetas.CurrentRowIndex = -1 Then Exit Sub
    'dgEtiquetas.Select(dgEtiquetas.CurrentRowIndex)
    'End Sub

    'Private Sub dgEtiquetas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgEtiquetas.KeyPress
    'eliminar_etiqueta()
    'End Sub

    Private Sub txtCodigoBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.TextChanged
        If Me.txtCodigoBarras.Text <> "" Then
            Me.cmdEtiquetar.Enabled = True
        Else
            Me.cmdEtiquetar.Enabled = False
        End If
    End Sub


    Private Sub TextCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextCantidad.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub cmdEtiquetar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEtiquetar.Click
        Dim resp As String

        resp = MessageBox.Show("¿Desea etiquetar este artículo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If resp = 6 Then
            insertar()
        End If
        Me.TextCantidad.Text = ""
    End Sub

    Private Sub cmdCorregir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCorregir.Click
        Dim resp As String
        Dim rs As SqlDataReader
        Dim cod_barras As String

        resp = MessageBox.Show("¿Desea corregir el código de barras de este artículo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If resp = 6 Then
            cod_barras = Me.txtCodigoBarrrasCorrecto.Text
            rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT * FROM Inventario WHERE Barras = '" & cod_barras & "'")
            If rs.Read Then
                If rs!codigo = Me.txtCodigo.Text Then

                    MessageBox.Show("Este artículo ya posee el código de barras asignado", "", MessageBoxButtons.OK)

                    resp = MessageBox.Show("¿Desea etiquetar este artículo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                    If resp = 6 Then
                        insertar()
                    End If
                Else
                    MsgBox("El Código de barras ya existe", MsgBoxStyle.Exclamation)
                End If
            Else
                Try
                    Me.BindingContext(Me.DsEtiquetasArticulos1, "Inventario").EndCurrentEdit()
                    Me.daArticulos.Update(Me.DsEtiquetasArticulos1, "Inventario")

                    MsgBox("Actualización de artículo exitosa", MsgBoxStyle.Information)

                    resp = MessageBox.Show("¿Desea etiquetar este artículo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                    If resp = 6 Then
                        insertar()
                    End If

                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
                rs.Close()
            End If
        End If
    End Sub
End Class
