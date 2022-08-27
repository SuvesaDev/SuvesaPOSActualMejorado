Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Familia
    Inherits FrmPlantilla

#Region "Variables"
    Dim NuevaConexion As String
    Dim usuario As Usuario_Logeado
    Dim strModulo As String = ""
    Public Cargando As Boolean = False
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        AddHandler Me.BindingContext(Me.DataSetFamilia1, "Familia1").PositionChanged, AddressOf Me.Position_Changed
        NuevaConexion = Conexion
        usuario = Usuario_Parametro

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
    Friend WithEvents DataSetFamilia1 As DataSetFamilia
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Txtcodigo As System.Windows.Forms.Label
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents boton_guardar_sububicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtobssub_familia As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescsub_familia As System.Windows.Forms.TextBox
    Friend WithEvents Txtcodsub_familia As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Adapter_Familias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Subfamilias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtcod_sub As System.Windows.Forms.TextBox
    Friend WithEvents txtcodfam As System.Windows.Forms.TextBox
    Friend WithEvents DataNavigator2 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents boton_guardar_Familia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents boton_nueva_subFamilia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuentaGrav As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionGra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionExe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuentaCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaExe As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Familia))
        Me.DataSetFamilia1 = New LcPymes_5._2.DataSetFamilia
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Txtcodigo = New System.Windows.Forms.Label
        Me.Txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn
        Me.boton_guardar_sububicacion = New DevExpress.XtraEditors.SimpleButton
        Me.boton_nueva_subFamilia = New DevExpress.XtraEditors.SimpleButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtobssub_familia = New System.Windows.Forms.TextBox
        Me.Txtdescsub_familia = New System.Windows.Forms.TextBox
        Me.Txtcodsub_familia = New System.Windows.Forms.TextBox
        Me.boton_guardar_Familia = New DevExpress.XtraEditors.SimpleButton
        Me.Adapter_Familias = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Subfamilias = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.txtcod_sub = New System.Windows.Forms.TextBox
        Me.txtcodfam = New System.Windows.Forms.TextBox
        Me.DataNavigator2 = New DevExpress.XtraEditors.DataNavigator
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCuentaExe = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcionCosto = New DevExpress.XtraEditors.TextEdit
        Me.txtCuentaCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDescripcionExe = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescripcionGra = New DevExpress.XtraEditors.TextEdit
        Me.txtCuentaGrav = New DevExpress.XtraEditors.TextEdit
        CType(Me.DataSetFamilia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCuentaExe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionExe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionGra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaGrav.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(354, 782)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 492)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(466, 52)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(466, 32)
        Me.TituloModulo.Text = "                      Familias/Sub-Familias"
        '
        'DataSetFamilia1
        '
        Me.DataSetFamilia1.DataSetName = "DataSetFamilia"
        Me.DataSetFamilia1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = "Familia.FamiliaSubFamilias"
        Me.DataGrid2.DataSource = Me.DataSetFamilia1
        Me.DataGrid2.Enabled = False
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(488, 176)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(264, 112)
        Me.DataGrid2.TabIndex = 117
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = "Familia"
        Me.DataGrid1.DataSource = Me.DataSetFamilia1
        Me.DataGrid1.Enabled = False
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(488, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(264, 112)
        Me.DataGrid1.TabIndex = 116
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.TxtObservaciones.Location = New System.Drawing.Point(8, 176)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(376, 32)
        Me.TxtObservaciones.TabIndex = 1
        Me.TxtObservaciones.Text = ""
        '
        'Txtcodigo
        '
        Me.Txtcodigo.BackColor = System.Drawing.Color.White
        Me.Txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodigo.ForeColor = System.Drawing.Color.Blue
        Me.Txtcodigo.Location = New System.Drawing.Point(8, 16)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(152, 13)
        Me.Txtcodigo.TabIndex = 120
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescripcion.ForeColor = System.Drawing.Color.Blue
        Me.Txtdescripcion.Location = New System.Drawing.Point(8, 48)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(456, 13)
        Me.Txtdescripcion.TabIndex = 0
        Me.Txtdescripcion.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(8, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 14)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Observaciones:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 14)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Descripción:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GridControl1)
        Me.GroupBox3.Controls.Add(Me.boton_guardar_sububicacion)
        Me.GroupBox3.Controls.Add(Me.boton_nueva_subFamilia)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Txtobssub_familia)
        Me.GroupBox3.Controls.Add(Me.Txtdescsub_familia)
        Me.GroupBox3.Controls.Add(Me.Txtcodsub_familia)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 273)
        Me.GroupBox3.TabIndex = 124
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sub-Familias"
        '
        'GridControl1
        '
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 88)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(440, 176)
        Me.GridControl1.Styles.AddReplace("Preview", New DevExpress.Utils.ViewStyleEx("Preview", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, True, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Top, Nothing, System.Drawing.Color.FromArgb(CType(191, Byte), CType(213, Byte), CType(237, Byte)), System.Drawing.Color.FromArgb(CType(79, Byte), CType(101, Byte), CType(125, Byte)), System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FooterPanel", New DevExpress.Utils.ViewStyleEx("FooterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupButton", New DevExpress.Utils.ViewStyleEx("GroupButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterCloseButton", New DevExpress.Utils.ViewStyleEx("FilterCloseButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(90, Byte), CType(90, Byte), CType(90, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("EvenRow", New DevExpress.Utils.ViewStyleEx("EvenRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.Black, System.Drawing.Color.GhostWhite, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("HideSelectionRow", New DevExpress.Utils.ViewStyleEx("HideSelectionRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FixedLine", New DevExpress.Utils.ViewStyleEx("FixedLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(9, Byte), CType(31, Byte), CType(55, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyleEx("HeaderPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupPanel", New DevExpress.Utils.ViewStyleEx("GroupPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Empty", New DevExpress.Utils.ViewStyleEx("Empty", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(151, Byte), CType(173, Byte), CType(197, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupFooter", New DevExpress.Utils.ViewStyleEx("GroupFooter", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(141, Byte), CType(163, Byte), CType(187, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupRow", New DevExpress.Utils.ViewStyleEx("GroupRow", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(79, Byte), CType(101, Byte), CType(125, Byte)), System.Drawing.Color.FromArgb(CType(193, Byte), CType(204, Byte), CType(217, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HorzLine", New DevExpress.Utils.ViewStyleEx("HorzLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.FromArgb(CType(79, Byte), CType(101, Byte), CType(125, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButton", New DevExpress.Utils.ViewStyleEx("ColumnFilterButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(151, Byte), CType(173, Byte), CType(197, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedRow", New DevExpress.Utils.ViewStyleEx("FocusedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(79, Byte), CType(101, Byte), CType(125, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(129, Byte), CType(151, Byte), CType(175, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("VertLine", New DevExpress.Utils.ViewStyleEx("VertLine", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(131, Byte), CType(153, Byte), CType(177, Byte)), System.Drawing.Color.FromArgb(CType(79, Byte), CType(101, Byte), CType(125, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedCell", New DevExpress.Utils.ViewStyleEx("FocusedCell", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("OddRow", New DevExpress.Utils.ViewStyleEx("OddRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(193, Byte), CType(204, Byte), CType(217, Byte)), System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal))
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(89, Byte), CType(111, Byte), CType(135, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Row", New DevExpress.Utils.ViewStyleEx("Row", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterPanel", New DevExpress.Utils.ViewStyleEx("FilterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("RowSeparator", New DevExpress.Utils.ViewStyleEx("RowSeparator", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(151, Byte), CType(173, Byte), CType(197, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.LightGray, System.Drawing.Color.Blue, System.Drawing.Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("DetailTip", New DevExpress.Utils.ViewStyleEx("DetailTip", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 111
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colObservaciones})
        Me.GridView1.GroupPanelText = "Agrupe de acuerdo a la columna deseada"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        '
        'colObservaciones
        '
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colObservaciones.VisibleIndex = 2
        '
        'boton_guardar_sububicacion
        '
        Me.boton_guardar_sububicacion.Location = New System.Drawing.Point(384, 40)
        Me.boton_guardar_sububicacion.Name = "boton_guardar_sububicacion"
        Me.boton_guardar_sububicacion.Size = New System.Drawing.Size(56, 24)
        Me.boton_guardar_sububicacion.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.boton_guardar_sububicacion.TabIndex = 3
        Me.boton_guardar_sububicacion.Text = "Guardar"
        '
        'boton_nueva_subFamilia
        '
        Me.boton_nueva_subFamilia.Location = New System.Drawing.Point(384, 16)
        Me.boton_nueva_subFamilia.Name = "boton_nueva_subFamilia"
        Me.boton_nueva_subFamilia.Size = New System.Drawing.Size(56, 24)
        Me.boton_nueva_subFamilia.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.boton_nueva_subFamilia.TabIndex = 0
        Me.boton_nueva_subFamilia.Text = "Nuevo"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(8, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(360, 14)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Observaciones:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(11, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Código"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(72, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 14)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Descripción"
        '
        'Txtobssub_familia
        '
        Me.Txtobssub_familia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtobssub_familia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtobssub_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobssub_familia.ForeColor = System.Drawing.Color.Blue
        Me.Txtobssub_familia.Location = New System.Drawing.Point(8, 64)
        Me.Txtobssub_familia.Multiline = True
        Me.Txtobssub_familia.Name = "Txtobssub_familia"
        Me.Txtobssub_familia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtobssub_familia.Size = New System.Drawing.Size(360, 16)
        Me.Txtobssub_familia.TabIndex = 2
        Me.Txtobssub_familia.Text = ""
        '
        'Txtdescsub_familia
        '
        Me.Txtdescsub_familia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdescsub_familia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdescsub_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescsub_familia.ForeColor = System.Drawing.Color.Blue
        Me.Txtdescsub_familia.Location = New System.Drawing.Point(72, 32)
        Me.Txtdescsub_familia.Name = "Txtdescsub_familia"
        Me.Txtdescsub_familia.Size = New System.Drawing.Size(296, 13)
        Me.Txtdescsub_familia.TabIndex = 1
        Me.Txtdescsub_familia.Text = ""
        '
        'Txtcodsub_familia
        '
        Me.Txtcodsub_familia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcodsub_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodsub_familia.ForeColor = System.Drawing.Color.Blue
        Me.Txtcodsub_familia.Location = New System.Drawing.Point(14, 32)
        Me.Txtcodsub_familia.Name = "Txtcodsub_familia"
        Me.Txtcodsub_familia.ReadOnly = True
        Me.Txtcodsub_familia.Size = New System.Drawing.Size(46, 13)
        Me.Txtcodsub_familia.TabIndex = 3
        Me.Txtcodsub_familia.Text = ""
        '
        'boton_guardar_Familia
        '
        Me.boton_guardar_Familia.Location = New System.Drawing.Point(400, 176)
        Me.boton_guardar_Familia.Name = "boton_guardar_Familia"
        Me.boton_guardar_Familia.Size = New System.Drawing.Size(56, 24)
        Me.boton_guardar_Familia.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.boton_guardar_Familia.TabIndex = 2
        Me.boton_guardar_Familia.Text = "Guardar"
        '
        'Adapter_Familias
        '
        Me.Adapter_Familias.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Familias.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Familias.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Familias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Familia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("CuentaGra", "CuentaGra"), New System.Data.Common.DataColumnMapping("DescripcionGra", "DescripcionGra"), New System.Data.Common.DataColumnMapping("CuentaExe", "CuentaExe"), New System.Data.Common.DataColumnMapping("DescripcionExe", "DescripcionExe"), New System.Data.Common.DataColumnMapping("CuentaCosto", "CuentaCosto"), New System.Data.Common.DataColumnMapping("DescripcionCosto", "DescripcionCosto")})})
        Me.Adapter_Familias.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Familia WHERE (Codigo = @Original_Codigo) AND (CuentaCosto = @Origina" & _
        "l_CuentaCosto) AND (CuentaExe = @Original_CuentaExe) AND (CuentaGra = @Original_" & _
        "CuentaGra) AND (Descripcion = @Original_Descripcion) AND (DescripcionCosto = @Or" & _
        "iginal_DescripcionCosto) AND (DescripcionExe = @Original_DescripcionExe) AND (De" & _
        "scripcionGra = @Original_DescripcionGra) AND (Observaciones = @Original_Observac" & _
        "iones)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaCosto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaExe", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaExe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaGra", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaGra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionCosto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionExe", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionExe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionGra", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionGra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=SeePos"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Familia(Codigo, Descripcion, Observaciones, CuentaGra, DescripcionGra" & _
        ", CuentaExe, DescripcionExe, CuentaCosto, DescripcionCosto) VALUES (@Codigo, @De" & _
        "scripcion, @Observaciones, @CuentaGra, @DescripcionGra, @CuentaExe, @Descripcion" & _
        "Exe, @CuentaCosto, @DescripcionCosto); SELECT Codigo, Descripcion, Observaciones" & _
        ", CuentaGra, DescripcionGra, CuentaExe, DescripcionExe, CuentaCosto, Descripcion" & _
        "Costo FROM Familia WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaGra", System.Data.SqlDbType.VarChar, 250, "CuentaGra"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionGra", System.Data.SqlDbType.VarChar, 250, "DescripcionGra"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaExe", System.Data.SqlDbType.VarChar, 250, "CuentaExe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionExe", System.Data.SqlDbType.VarChar, 250, "DescripcionExe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaCosto", System.Data.SqlDbType.VarChar, 250, "CuentaCosto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCosto", System.Data.SqlDbType.VarChar, 250, "DescripcionCosto"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Descripcion, Observaciones, CuentaGra, DescripcionGra, CuentaExe, " & _
        "DescripcionExe, CuentaCosto, DescripcionCosto FROM Familia"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Familia SET Codigo = @Codigo, Descripcion = @Descripcion, Observaciones = " & _
        "@Observaciones, CuentaGra = @CuentaGra, DescripcionGra = @DescripcionGra, Cuenta" & _
        "Exe = @CuentaExe, DescripcionExe = @DescripcionExe, CuentaCosto = @CuentaCosto, " & _
        "DescripcionCosto = @DescripcionCosto WHERE (Codigo = @Original_Codigo) AND (Cuen" & _
        "taCosto = @Original_CuentaCosto) AND (CuentaExe = @Original_CuentaExe) AND (Cuen" & _
        "taGra = @Original_CuentaGra) AND (Descripcion = @Original_Descripcion) AND (Desc" & _
        "ripcionCosto = @Original_DescripcionCosto) AND (DescripcionExe = @Original_Descr" & _
        "ipcionExe) AND (DescripcionGra = @Original_DescripcionGra) AND (Observaciones = " & _
        "@Original_Observaciones); SELECT Codigo, Descripcion, Observaciones, CuentaGra, " & _
        "DescripcionGra, CuentaExe, DescripcionExe, CuentaCosto, DescripcionCosto FROM Fa" & _
        "milia WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaGra", System.Data.SqlDbType.VarChar, 250, "CuentaGra"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionGra", System.Data.SqlDbType.VarChar, 250, "DescripcionGra"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaExe", System.Data.SqlDbType.VarChar, 250, "CuentaExe"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionExe", System.Data.SqlDbType.VarChar, 250, "DescripcionExe"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaCosto", System.Data.SqlDbType.VarChar, 250, "CuentaCosto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCosto", System.Data.SqlDbType.VarChar, 250, "DescripcionCosto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaCosto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaExe", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaExe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaGra", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaGra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionCosto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionExe", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionExe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionGra", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionGra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adapter_Subfamilias
        '
        Me.Adapter_Subfamilias.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Subfamilias.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Subfamilias.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Subfamilias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SubFamilias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoFamilia", "CodigoFamilia"), New System.Data.Common.DataColumnMapping("SubCodigo", "SubCodigo"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.Adapter_Subfamilias.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM SubFamilias WHERE (Codigo = @Original_Codigo) AND (CodigoFamilia = @O" & _
        "riginal_CodigoFamilia) AND (Descripcion = @Original_Descripcion) AND (Observacio" & _
        "nes = @Original_Observaciones) AND (SubCodigo = @Original_SubCodigo)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoFamilia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubCodigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubCodigo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO SubFamilias(CodigoFamilia, SubCodigo, Codigo, Descripcion, Observacio" & _
        "nes) VALUES (@CodigoFamilia, @SubCodigo, @Codigo, @Descripcion, @Observaciones);" & _
        " SELECT CodigoFamilia, SubCodigo, Codigo, Descripcion, Observaciones FROM SubFam" & _
        "ilias WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoFamilia", System.Data.SqlDbType.Int, 4, "CodigoFamilia"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubCodigo", System.Data.SqlDbType.Int, 4, "SubCodigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 10, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodigoFamilia, SubCodigo, Codigo, Descripcion, Observaciones FROM SubFamil" & _
        "ias"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE SubFamilias SET CodigoFamilia = @CodigoFamilia, SubCodigo = @SubCodigo, Co" & _
        "digo = @Codigo, Descripcion = @Descripcion, Observaciones = @Observaciones WHERE" & _
        " (Codigo = @Original_Codigo) AND (CodigoFamilia = @Original_CodigoFamilia) AND (" & _
        "Descripcion = @Original_Descripcion) AND (Observaciones = @Original_Observacione" & _
        "s) AND (SubCodigo = @Original_SubCodigo); SELECT CodigoFamilia, SubCodigo, Codig" & _
        "o, Descripcion, Observaciones FROM SubFamilias WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoFamilia", System.Data.SqlDbType.Int, 4, "CodigoFamilia"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubCodigo", System.Data.SqlDbType.Int, 4, "SubCodigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 10, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoFamilia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubCodigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubCodigo", System.Data.DataRowVersion.Original, Nothing))
        '
        'txtcod_sub
        '
        Me.txtcod_sub.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcod_sub.Location = New System.Drawing.Point(512, 312)
        Me.txtcod_sub.Name = "txtcod_sub"
        Me.txtcod_sub.ReadOnly = True
        Me.txtcod_sub.Size = New System.Drawing.Size(40, 13)
        Me.txtcod_sub.TabIndex = 128
        Me.txtcod_sub.Text = ""
        '
        'txtcodfam
        '
        Me.txtcodfam.Location = New System.Drawing.Point(512, 336)
        Me.txtcodfam.Name = "txtcodfam"
        Me.txtcodfam.Size = New System.Drawing.Size(40, 20)
        Me.txtcodfam.TabIndex = 129
        Me.txtcodfam.Text = ""
        '
        'DataNavigator2
        '
        Me.DataNavigator2.Buttons.Append.Visible = False
        Me.DataNavigator2.Buttons.CancelEdit.Visible = False
        Me.DataNavigator2.Buttons.EndEdit.Visible = False
        Me.DataNavigator2.Buttons.Remove.Visible = False
        Me.DataNavigator2.DataMember = "Familia1"
        Me.DataNavigator2.DataSource = Me.DataSetFamilia1
        Me.DataNavigator2.Location = New System.Drawing.Point(328, 520)
        Me.DataNavigator2.Name = "DataNavigator2"
        Me.DataNavigator2.Size = New System.Drawing.Size(134, 24)
        Me.DataNavigator2.TabIndex = 130
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(760, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(760, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 132
        Me.Button2.Text = "Button2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 14)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Venta Gravada :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCuentaExe)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionCosto)
        Me.GroupBox1.Controls.Add(Me.txtCuentaCosto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionExe)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionGra)
        Me.GroupBox1.Controls.Add(Me.txtCuentaGrav)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 88)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas Contables"
        '
        'txtCuentaExe
        '
        Me.txtCuentaExe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetFamilia1, "Familia.CuentaExe"))
        Me.txtCuentaExe.EditValue = ""
        Me.txtCuentaExe.Location = New System.Drawing.Point(112, 40)
        Me.txtCuentaExe.Name = "txtCuentaExe"
        '
        'txtCuentaExe.Properties
        '
        Me.txtCuentaExe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaExe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaExe.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCuentaExe.Size = New System.Drawing.Size(144, 17)
        Me.txtCuentaExe.TabIndex = 1
        '
        'txtDescripcionCosto
        '
        Me.txtDescripcionCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetFamilia1, "Familia.DescripcionCosto"))
        Me.txtDescripcionCosto.EditValue = ""
        Me.txtDescripcionCosto.Location = New System.Drawing.Point(264, 64)
        Me.txtDescripcionCosto.Name = "txtDescripcionCosto"
        '
        'txtDescripcionCosto.Properties
        '
        Me.txtDescripcionCosto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescripcionCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCosto.Properties.ReadOnly = True
        Me.txtDescripcionCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDescripcionCosto.Size = New System.Drawing.Size(184, 17)
        Me.txtDescripcionCosto.TabIndex = 142
        '
        'txtCuentaCosto
        '
        Me.txtCuentaCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetFamilia1, "Familia.CuentaCosto"))
        Me.txtCuentaCosto.EditValue = ""
        Me.txtCuentaCosto.Location = New System.Drawing.Point(112, 64)
        Me.txtCuentaCosto.Name = "txtCuentaCosto"
        '
        'txtCuentaCosto.Properties
        '
        Me.txtCuentaCosto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCuentaCosto.Size = New System.Drawing.Size(144, 17)
        Me.txtCuentaCosto.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 14)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Costo Venta :"
        '
        'txtDescripcionExe
        '
        Me.txtDescripcionExe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetFamilia1, "Familia.DescripcionExe"))
        Me.txtDescripcionExe.EditValue = ""
        Me.txtDescripcionExe.Location = New System.Drawing.Point(264, 40)
        Me.txtDescripcionExe.Name = "txtDescripcionExe"
        '
        'txtDescripcionExe.Properties
        '
        Me.txtDescripcionExe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescripcionExe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionExe.Properties.ReadOnly = True
        Me.txtDescripcionExe.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDescripcionExe.Size = New System.Drawing.Size(184, 17)
        Me.txtDescripcionExe.TabIndex = 139
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 14)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Venta Exenta :"
        '
        'txtDescripcionGra
        '
        Me.txtDescripcionGra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetFamilia1, "Familia.DescripcionGra"))
        Me.txtDescripcionGra.EditValue = ""
        Me.txtDescripcionGra.Location = New System.Drawing.Point(264, 16)
        Me.txtDescripcionGra.Name = "txtDescripcionGra"
        '
        'txtDescripcionGra.Properties
        '
        Me.txtDescripcionGra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescripcionGra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionGra.Properties.ReadOnly = True
        Me.txtDescripcionGra.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDescripcionGra.Size = New System.Drawing.Size(184, 17)
        Me.txtDescripcionGra.TabIndex = 136
        '
        'txtCuentaGrav
        '
        Me.txtCuentaGrav.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetFamilia1, "Familia.CuentaGra"))
        Me.txtCuentaGrav.EditValue = ""
        Me.txtCuentaGrav.Location = New System.Drawing.Point(112, 16)
        Me.txtCuentaGrav.Name = "txtCuentaGrav"
        '
        'txtCuentaGrav.Properties
        '
        Me.txtCuentaGrav.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaGrav.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaGrav.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtCuentaGrav.Size = New System.Drawing.Size(144, 17)
        Me.txtCuentaGrav.TabIndex = 0
        '
        'Familia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(466, 544)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataNavigator2)
        Me.Controls.Add(Me.txtcod_sub)
        Me.Controls.Add(Me.txtcodfam)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Txtcodigo)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.boton_guardar_Familia)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(472, 576)
        Me.MinimumSize = New System.Drawing.Size(472, 576)
        Me.Name = "Familia"
        Me.Text = "Familia"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.DataGrid1, 0)
        Me.Controls.SetChildIndex(Me.DataGrid2, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.boton_guardar_Familia, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Txtdescripcion, 0)
        Me.Controls.SetChildIndex(Me.Txtcodigo, 0)
        Me.Controls.SetChildIndex(Me.TxtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtcodfam, 0)
        Me.Controls.SetChildIndex(Me.txtcod_sub, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator2, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        CType(Me.DataSetFamilia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtCuentaExe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionExe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionGra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaGrav.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub Familia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
        strModulo = IIf(NuevaConexion = "", "SeePOS", "SeePos")

        Cargando = True
        CargarMovimiento()
        If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count > 0 Then
            CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
        End If
        Binding()
        Me.DataSetFamilia1.Familia.ObservacionesColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.DescripcionColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.CodigoColumn.DefaultValue = "0"
        Me.DataSetFamilia1.Familia.CuentaGraColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.DescripcionGraColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.CuentaExeColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.DescripcionExeColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.CuentaCostoColumn.DefaultValue = ""
        Me.DataSetFamilia1.Familia.DescripcionCostoColumn.DefaultValue = ""
        Me.DataSetFamilia1.SubFamilias.ObservacionesColumn.DefaultValue = ""
        Me.DataSetFamilia1.SubFamilias.DescripcionColumn.DefaultValue = ""
        Me.DataSetFamilia1.SubFamilias.CodigoColumn.DefaultValue = "0"
        Cargando = False
    End Sub

    Function Binding()
        Me.GridControl1.DataMember = "Familia.FamiliaSubFamilias"
        Me.GridControl1.DataSource = Me.DataSetFamilia1
        Me.Txtobssub_familia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.FamiliaSubFamilias.Observaciones"))
        Me.Txtdescsub_familia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.FamiliaSubFamilias.Descripcion"))
        Me.Txtcodsub_familia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.FamiliaSubFamilias.Codigo"))
        Me.TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.Observaciones"))
        Me.Txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.Codigo"))
        Me.Txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.Descripcion"))
        Me.txtcod_sub.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.FamiliaSubFamilias.SubCodigo"))
        Me.txtcodfam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetFamilia1, "Familia.FamiliaSubFamilias.CodigoFamilia"))
    End Function

    Function CargarMovimiento()
        Dim cx As New cFunciones
        cx.Llenar_Tabla_Generico("Select Codigo from familia", Me.DataSetFamilia1.Familia1, Me.SqlConnection1.ConnectionString)
    End Function

    Function CargarFamiliasSubfamilias(ByVal codigo As Integer)
        Dim cx As New cFunciones
        If Me.DataSetFamilia1.Familia1.Rows.Count > 0 Then
            cx.Llenar_Tabla_Generico("Select * from familia where Codigo = " & codigo, Me.DataSetFamilia1.Familia, Me.SqlConnection1.ConnectionString)
            cx.Llenar_Tabla_Generico("Select * from SubFamilias where CodigoFamilia = " & codigo, Me.DataSetFamilia1.SubFamilias, Me.SqlConnection1.ConnectionString)
        End If
    End Function

#End Region

#Region "Familia"
    Function NuevaFamilia()
        Try
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False
                Try
                    If Me.BindingContext(Me.DataSetFamilia1, "Familia").Count = 98 Then
                        MsgBox("No pueden existir más de 99 Familias", MsgBoxStyle.Exclamation)
                        Exit Function
                    End If
                    DataNavigator2.Enabled = False
                    Me.DataSetFamilia1.SubFamilias.Clear()
                    Me.DataSetFamilia1.Familia.Clear()
                    Autonumerico()
                    Me.BindingContext(Me.DataSetFamilia1, "Familia").AddNew()
                    Txtdescripcion.Focus()
                    deshabilitar_sububicacion()
                Catch ex As SystemException
                    MsgBox(EX.Message, MsgBoxStyle.Information, "Atención...")
                End Try
            Else
                If MessageBox.Show("Desea Guardar esta Familia", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.registrar() ' se guarda en la base de datos
                Else
                    Me.BindingContext(Me.DataSetFamilia1, "Familia").CancelCurrentEdit()
                    Me.DataSetFamilia1.SubFamilias.Clear()
                    Me.DataSetFamilia1.Familia.Clear()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = True
                    Me.ToolBar1.Buttons(3).Enabled = True
                    Me.ToolBar1.Buttons(4).Enabled = True
                    Me.boton_nueva_subFamilia.Enabled = True
                    Me.boton_guardar_sububicacion.Enabled = True
                    DataNavigator2.Enabled = True
                    If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count > 0 Then
                        CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
                    End If
                End If
            End If

        Catch ex As SystemException
            MsgBox(EX.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Function Autonumerico()
        Dim fun As New Conexion
        If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
        Me.DataSetFamilia1.Familia.CodigoColumn.DefaultValue = CDbl(fun.SlqExecuteScalar(Me.SqlConnection1, "SELECT isnull(MAX(Codigo) + 1,1) FROM Familia"))
        Me.SqlConnection1.Close()
    End Function

    Function ValidarFamilia() As Boolean
        'nombtre no este vacio
        If Txtdescripcion.Text = "" Then
            MsgBox("Debes escribir la descripción de la familia!", MsgBoxStyle.Information)
            Txtdescripcion.Focus()
            Return False
        End If

        If txtCuentaGrav.Text = "" Or txtDescripcionGra.Text = "" Then
            MsgBox("Debe seleccionar la cuenta contable para las ventas gravadas de la familia!", MsgBoxStyle.Information)
            txtCuentaGrav.Focus()
            Return False
        End If

        If txtCuentaExe.Text = "" Or txtDescripcionExe.Text = "" Then
            MsgBox("Debe seleccionar la cuenta contable para las ventas exentas de la familia!", MsgBoxStyle.Information)
            txtCuentaExe.Focus()
            Return False
        End If

        If txtCuentaCosto.Text = "" Or txtDescripcionCosto.Text = "" Then
            MsgBox("Debe seleccionar la cuenta contable de costo de la familia!", MsgBoxStyle.Information)
            txtCuentaCosto.Focus()
            Return False
        End If

        If Me.ToolBarNuevo.Text = "Cancelar" Then
            Dim tabla As New DataTable
            Dim cfunciones As New cfunciones
            cfunciones.Llenar_Tabla_Generico("SELECT Codigo FROM Familia WHERE Descripcion = '" & Txtdescripcion.Text & "'", tabla, Me.SqlConnection1.ConnectionString)
            If tabla.Rows.Count > 0 Then
                MsgBox("Ya Existe una familia con ese nombre", MsgBoxStyle.Information)
                Txtdescripcion.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Sub Buscar_Familia()
        If Me.ToolBarNuevo.Text = "Cancelar" Then
            If MsgBox("Actualmente se esta creando una famila, desea cancelar esta edicion y hacer la busqueda", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.DataSetFamilia1.SubFamilias.Clear()
                Me.DataSetFamilia1.Familia.Clear()
                Me.BindingContext(Me.DataSetFamilia1, "Familia").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(0).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = True
                Me.boton_nueva_subFamilia.Enabled = True
                Me.boton_guardar_sububicacion.Enabled = True
                DataNavigator2.Enabled = True
            Else
                Exit Sub
            End If
        End If

        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            valor = Fx.BuscarDatos("Select Codigo,Descripcion From Familia", "Descripcion", "Buscar Familia...", Me.SqlConnection1.ConnectionString)
            If valor = "" Then
                Exit Sub
            Else
                Me.DataSetFamilia1.SubFamilias.Clear()
                Me.DataSetFamilia1.Familia.Clear()
                vista = Me.DataSetFamilia1.Familia1.DefaultView
                vista.Sort = "Codigo"
                pos = vista.Find(CDbl(valor))
                If pos = Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position Then
                    If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count > 0 Then
                        CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
                    End If
                Else
                    Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position = pos
                End If

                'CargarFamiliasSubfamilias(CInt(valor))
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Sub Eliminar_Familia()

        Dim resp As Integer
        If Me.ToolBarNuevo.Text = "Cancelar" Then
            MsgBox("No se puede eliminar por que se esta creando un familia", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try 'se intenta hacer
            Dim tabla As New DataTable
            Dim cfunciones As New cfunciones
            Dim conexion As New conexion
            Dim reader As SqlDataReader
            Dim conectado As SqlConnection = Me.SqlConnection1
            If Me.BindingContext(Me.DataSetFamilia1, "Familia").Count > 0 Then  ' si hay ubicaciones

                If Me.BindingContext(Me.DataSetFamilia1.SubFamilias).Count > 0 Then

                    'Evaluo si las subfamilias estan asociadas a un articulo 
                    'Dim tabla1 As New DataTable
                    'Dim cfunciones1 As New cFunciones
                    cfunciones.Llenar_Tabla_Generico("SELECT Codigo FROM Inventario WHERE SubFamilia = '" & Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Current("Codigo") & "'", tabla, Me.SqlConnection1.ConnectionString)
                    If tabla.Rows.Count > 0 Then
                        MsgBox("No se puede eliminar esta Sub-Familia por que existe articulos en el inventario que pertenecen a esta")
                        Exit Sub
                    End If
                End If
                'Cargo el codigo de la familia al que pertenecen las familias que se eliminaran
                Dim strCodigoFamilia As String = Me.BindingContext(DataSetFamilia1, "Familia").Current("Codigo")
                Dim strMensaje As String = conexion.DeleteRecords("SubFamilias", "CodigoFamilia =" & strCodigoFamilia, strModulo)

                'Si el mensaje viene en blanco indica que no hubo problemas al eliminar
                If strMensaje = "" Then


                    resp = MessageBox.Show("¿Desea eliminar permanentemente esta Familia?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        Me.BindingContext(Me.DataSetFamilia1, "Familia").RemoveAt(Me.BindingContext(Me.DataSetFamilia1, "Familia").Position)
                        Me.BindingContext(Me.DataSetFamilia1, "Familia").EndCurrentEdit()
                        Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
                        CargarFamiliaAcutal(True, )
                    End If
                Else
                    MsgBox("Problemas al eliminar  " & strMensaje, MsgBoxStyle.Information)
                End If
            Else
                MsgBox("No Existen Familias que Eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
            MsgBox("Existen articulos en el inventario que pertenecen a estas Sub-Familias, por lo tanto no se puede eliminar esta Familia", MsgBoxStyle.Information)
            If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count > 0 Then
                Me.DataSetFamilia1.SubFamilias.Clear()
                Me.DataSetFamilia1.Familia.Clear()
                CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
            End If
        End Try
    End Sub

    Function CargarFamiliaAcutal(Optional ByVal Eliminar As Boolean = False, Optional ByVal Registrar As Boolean = False)

        If Me.ToolBarNuevo.Text <> "Cancelar" Then
            If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count > 0 Or Registrar = True Then
                Dim pos As Integer
                pos = Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position
                CargarMovimiento()
                'si se llama por eliminar
                If Eliminar = True Then
                    'si solo no quedan registro
                    If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count = 0 Then

                    Else
                        'si quedan 
                        Me.DataSetFamilia1.SubFamilias.Clear()
                        Me.DataSetFamilia1.Familia.Clear()
                        CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
                    End If

                Else
                    Me.DataSetFamilia1.SubFamilias.Clear()
                    Me.DataSetFamilia1.Familia.Clear()
                    Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position = pos
                    CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
                End If
            End If
        End If
    End Function

    Sub imprimir()
        If Me.ToolBarNuevo.Text = "Cancelar" Then
            MsgBox("No se puede imprimir por que actualmente se esta creando una familia", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Me.ToolBar1.Buttons(2).Enabled = False
            Dim Familias_Reporte As New Reporte_Familias
            CrystalReportsConexion.LoadShow(Familias_Reporte, MdiParent, Me.SqlConnection1.ConnectionString)
            Me.ToolBar1.Buttons(2).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.Eliminar_SubFamilia()
        End If
    End Sub

    Private Sub boton_guardar_ubicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar_Familia.Click
        Try
            If Me.ValidarFamilia Then
                Me.BindingContext(Me.DataSetFamilia1, "Familia").EndCurrentEdit()
                boton_nueva_subFamilia.Enabled = True
                boton_guardar_sububicacion.Enabled = True
                Me.ToolBar1.Buttons(3).Enabled = True
                boton_nueva_subFamilia.Focus()
            End If
        Catch ex As SystemException  'Cacha los distintos errores que se pueden dar
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

#Region "SubFamilia"
    Sub nueva_subfamilia()
        Dim cod As Integer
        Dim var As String
        Try
            If Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Count = 99 Then
                MsgBox("No pueden existir más de 99 Subfamilias", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            '***********************************************************************************
            '***********************************************************************************

            If Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Count > 0 Then
                cod = Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Count
            Else
                cod = 0
            End If
            Me.DataSetFamilia1.SubFamilias.SubCodigoColumn.DefaultValue = cod
            '***********************************************************************************
            '***********************************************************************************
            Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").EndCurrentEdit()
            Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").AddNew()
            Me.Txtcodsub_familia.Text = Me.Txtcodigo.Text + "-" + txtcod_sub.Text
            Me.txtcodfam.Text = Me.Txtcodigo.Text
            Me.boton_nueva_subFamilia.Enabled = False
            Txtdescsub_familia.Focus()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Sub guardar_subfamilia()
        If ValidarSubfamilia() = False Then
            Exit Sub
        End If
        Try
            Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").EndCurrentEdit()
            Me.boton_nueva_subFamilia.Enabled = True
            Me.boton_nueva_subFamilia.Focus()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Sub Eliminar_SubFamilia()

        If Me.ToolBarNuevo.Text <> "Cancelar" Then

            Dim tabla As New DataTable
            Dim cfunciones As New cfunciones
            cfunciones.Llenar_Tabla_Generico("SELECT Codigo FROM Inventario WHERE SubFamilia = '" & Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Current("Codigo") & "'", tabla, Me.SqlConnection1.ConnectionString)
            If tabla.Rows.Count > 0 Then
                MsgBox("No se puede eliminar esta Sub-Familia por que existe articulos en el inventario que pertenecen a esta")
                Exit Sub
            End If
        End If

        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Count > 0 Then  ' si hay ubicaciones

                Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").RemoveAt(Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").Position)
                Me.BindingContext(Me.DataSetFamilia1, "Familia.FamiliaSubFamilias").EndCurrentEdit()

            Else
                MsgBox("No Existen SubFamilias que Eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Private Sub boton_nueva_sububicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_nueva_subFamilia.Click
        Me.nueva_subfamilia()
    End Sub

    Private Sub boton_guardar_sububicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar_sububicacion.Click
        guardar_subfamilia()
    End Sub

    Function ValidarSubfamilia() As Boolean
        If Txtdescsub_familia.Text = "" Then
            MsgBox("Debes digitar la descripción de la Sub-Familia")
            Txtdescsub_familia.Focus()
            Return False
        End If
        'Dim rows() As New DataRow
        'rows = Me.DataSetFamilia1.SubFamilias.Select("Descripcion = " & Txtdescsub_familia.Text)
        'If rows.Length > 0 Then
        '    MsgBox("Ya existe una Sub-Familia con este nombre dentro de esta Familia")
        '    Return False
        'End If
        Return True
    End Function

    Private Sub deshabilitar_sububicacion()
        Me.boton_nueva_subFamilia.Enabled = False
        Me.boton_guardar_sububicacion.Enabled = False
    End Sub
#End Region

#Region "Cambio de posicion"
    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ToolBarNuevo.Text = "Cancelar" Then
            Exit Sub
        End If
        If Cargando = False Then
            If Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count > 0 Then
                Me.DataSetFamilia1.SubFamilias.Clear()
                Me.DataSetFamilia1.Familia.Clear()
                CargarFamiliasSubfamilias(Me.BindingContext(Me.DataSetFamilia1, "Familia1").Current("Codigo"))
            End If
        End If
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try


            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
                Case 1
                    Me.NuevaFamilia()
                Case 2
                    If PMU.Find Then Buscar_Familia() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

                Case 5
                    If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 3
                    If PMU.Update Then registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4
                    If PMU.Delete Then Eliminar_Familia() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 7
                    If MessageBox.Show("¿Desea Cerrar el Módulo de Familias?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Registrar"
    Sub registrar()
        Dim pos As Integer
        If Me.ToolBarNuevo.Text = "Cancelar" Then
            If Me.ValidarFamilia = False Then
                Exit Sub
            End If
        Else
            pos = Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position
        End If
        Try
            Me.ToolBar1.Buttons(2).Enabled = False
            If MessageBox.Show("¿Desea Guardar los Cambios en Familia?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If

            Me.BindingContext(Me.DataSetFamilia1, "Familia").EndCurrentEdit()
            If Registrar_Familia() Then 'se registra en la base de datos then
                CargarMovimiento()
                If Me.ToolBarNuevo.Text = "Cancelar" Then
                    Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position = (Me.BindingContext(Me.DataSetFamilia1, "Familia1").Count - 1)
                Else
                    Me.BindingContext(Me.DataSetFamilia1, "Familia1").Position = pos
                End If
                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(2).Enabled = True
                DataNavigator2.Enabled = True

            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True
                DataNavigator2.Enabled = True
            End If
        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub

    Function Registrar_Familia() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.Adapter_Familias.InsertCommand.Transaction = Trans
            Me.Adapter_Familias.SelectCommand.Transaction = Trans
            Me.Adapter_Familias.DeleteCommand.Transaction = Trans
            Me.Adapter_Familias.UpdateCommand.Transaction = Trans
            Me.Adapter_Subfamilias.SelectCommand.Transaction = Trans
            Me.Adapter_Subfamilias.InsertCommand.Transaction = Trans
            Me.Adapter_Subfamilias.DeleteCommand.Transaction = Trans
            Me.Adapter_Subfamilias.UpdateCommand.Transaction = Trans
            Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            Trans.Commit()
            Me.DataSetFamilia1.AcceptChanges()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message & vbCrLf & "Posible Causa un error de Red, o no se puede eliminar porque la Familia esta ligada a almenos un artículo en el inventario")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
#End Region

#Region "Funciones Controles"
    Private Sub Txtdescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtdescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCuentaGrav.Focus()
        End If
    End Sub

    Private Sub txtCuentaGrav_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaGrav.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscaCuenta(txtCuentaGrav, txtDescripcionGra)
        End If

        If e.KeyCode = Keys.Enter Then
            If BuscaCuentaEnter(txtCuentaGrav, txtDescripcionGra) Then
                txtCuentaExe.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuentaExe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaExe.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscaCuenta(txtCuentaExe, txtDescripcionExe)
        End If

        If e.KeyCode = Keys.Enter Then
            If BuscaCuentaEnter(txtCuentaExe, txtDescripcionExe) Then
                txtCuentaCosto.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuentaCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaCosto.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscaCuenta(txtCuentaCosto, txtDescripcionCosto)
        End If

        If e.KeyCode = Keys.Enter Then
            If BuscaCuentaEnter(txtCuentaCosto, txtDescripcionCosto) Then
                TxtObservaciones.Focus()
            End If
        End If
    End Sub

    Private Sub TxtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            boton_guardar_Familia.Focus()
        End If
    End Sub

    Private Sub Txtdescsub_familia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtdescsub_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Txtobssub_familia.Focus()
        End If
    End Sub

    Private Sub Txtobssub_familia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtobssub_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.boton_guardar_sububicacion.Focus()
        End If
    End Sub
#End Region

#Region "Cuentas Contables"
    Function BuscaCuentaEnter(ByVal a1 As Object, ByVal a2 As Object) As Boolean
        Dim Cx As New Conexion
        Dim valida As String

        Try
            Dim num_cuenta As String = a1.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then ' en caso de que la cuenta se haya digitado y no buscado, se valida su existencia
                MessageBox.Show("La cuenta digitada no esta registrada o no permite movimiento..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                a1.Focus()
                Return False
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                a2.Text = nombre
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cx.DesConectar(Cx.sQlconexion)
        End Try
    End Function

    Private Sub BuscaCuenta(ByVal a1 As Object, ByVal a2 As Object)
        Dim cConexion As New Conexion
        Dim Fx As New cFunciones
        Dim Id As String

        Try
            Id = Fx.BuscarDatos("SELECT CuentaContable, Descripcion FROM cuentacontable where (Movimiento = 1) ", "Descripcion", "Buscar Cuenta Contable .....", GetSetting("Seesoft", "Contabilidad", "Conexion"))

            If Id = "" Then
                Exit Sub
            End If

            a1.Text = Id
            a2.Text = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "Select Descripcion from contabilidad.dbo.cuentacontable where cuentaContable='" & Id & "'")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Sub
#End Region

End Class
