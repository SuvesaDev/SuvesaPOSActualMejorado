Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmCliente_frecuente
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo de inicio
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents PanelDatosBasicos As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtobserv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtID_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Tex_Accion As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txtfax1 As System.Windows.Forms.TextBox
    Friend WithEvents Txttel1 As System.Windows.Forms.TextBox
    Friend WithEvents Txdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Txtfax2 As System.Windows.Forms.TextBox
    Friend WithEvents Txttel2 As System.Windows.Forms.TextBox
    Friend WithEvents CbTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LabelID_TipoPrecio As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRestricciones As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Clientes_fre As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetClienteFrecuente1 As LcPymes_5._2.DataSetClienteFrecuente
    Friend WithEvents Adapter_Bitacora As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Txtidentificacion As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterConsecutivo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_accion As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Ckbempresa As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCliente_frecuente))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelDatosBasicos = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txtobserv = New System.Windows.Forms.TextBox
        Me.DataSetClienteFrecuente1 = New LcPymes_5._2.DataSetClienteFrecuente
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtnombre = New System.Windows.Forms.TextBox
        Me.Txtcedula = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtID_Usuario = New System.Windows.Forms.TextBox
        Me.Tex_Accion = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Txtfax1 = New System.Windows.Forms.TextBox
        Me.Txttel1 = New System.Windows.Forms.TextBox
        Me.Txdireccion = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.Txtfax2 = New System.Windows.Forms.TextBox
        Me.Txttel2 = New System.Windows.Forms.TextBox
        Me.CbTipoPrecio = New System.Windows.Forms.ComboBox
        Me.Txtidentificacion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LabelID_TipoPrecio = New System.Windows.Forms.Label
        Me.ComboBoxRestricciones = New System.Windows.Forms.ComboBox
        Me.Adapter_Clientes_fre = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Bitacora = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.AdapterConsecutivo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.txt_accion = New System.Windows.Forms.TextBox
        Me.Ckbempresa = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.PanelDatosBasicos.SuspendLayout()
        CType(Me.DataSetClienteFrecuente1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(354, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 16)
        Me.Panel1.TabIndex = 75
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
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(123, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(173, 13)
        Me.txtNombreUsuario.TabIndex = 2
        Me.txtNombreUsuario.Text = ""
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
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 330)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(664, 56)
        Me.ToolBar1.TabIndex = 80
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PanelDatosBasicos
        '
        Me.PanelDatosBasicos.BackColor = System.Drawing.Color.Silver
        Me.PanelDatosBasicos.Controls.Add(Me.Label3)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtobserv)
        Me.PanelDatosBasicos.Controls.Add(Me.Label4)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtnombre)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtcedula)
        Me.PanelDatosBasicos.Controls.Add(Me.Label2)
        Me.PanelDatosBasicos.Location = New System.Drawing.Point(8, 48)
        Me.PanelDatosBasicos.Name = "PanelDatosBasicos"
        Me.PanelDatosBasicos.Size = New System.Drawing.Size(648, 88)
        Me.PanelDatosBasicos.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(459, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'Txtobserv
        '
        Me.Txtobserv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtobserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtobserv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.observaciones"))
        Me.Txtobserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobserv.ForeColor = System.Drawing.Color.Blue
        Me.Txtobserv.Location = New System.Drawing.Point(5, 65)
        Me.Txtobserv.Name = "Txtobserv"
        Me.Txtobserv.Size = New System.Drawing.Size(627, 13)
        Me.Txtobserv.TabIndex = 5
        Me.Txtobserv.Text = ""
        '
        'DataSetClienteFrecuente1
        '
        Me.DataSetClienteFrecuente1.DataSetName = "DataSetClienteFrecuente"
        Me.DataSetClienteFrecuente1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(485, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cédula:"
        '
        'Txtnombre
        '
        Me.Txtnombre.AccessibleDescription = ""
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.nombre"))
        Me.Txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombre.ForeColor = System.Drawing.Color.Blue
        Me.Txtnombre.Location = New System.Drawing.Point(5, 25)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(459, 13)
        Me.Txtnombre.TabIndex = 0
        Me.Txtnombre.Text = ""
        '
        'Txtcedula
        '
        Me.Txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.cedula"))
        Me.Txtcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcedula.ForeColor = System.Drawing.Color.Blue
        Me.Txtcedula.Location = New System.Drawing.Point(485, 25)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(147, 13)
        Me.Txtcedula.TabIndex = 1
        Me.Txtcedula.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(627, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observaciones:"
        '
        'TxtID_Usuario
        '
        Me.TxtID_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtID_Usuario.Enabled = False
        Me.TxtID_Usuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtID_Usuario.Location = New System.Drawing.Point(96, 386)
        Me.TxtID_Usuario.Name = "TxtID_Usuario"
        Me.TxtID_Usuario.Size = New System.Drawing.Size(64, 13)
        Me.TxtID_Usuario.TabIndex = 81
        Me.TxtID_Usuario.Text = ""
        '
        'Tex_Accion
        '
        Me.Tex_Accion.Location = New System.Drawing.Point(496, 403)
        Me.Tex_Accion.Name = "Tex_Accion"
        Me.Tex_Accion.Size = New System.Drawing.Size(152, 20)
        Me.Tex_Accion.TabIndex = 78
        Me.Tex_Accion.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 152)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 168)
        Me.TabControl1.TabIndex = 77
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Ckbempresa)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Txtfax1)
        Me.TabPage1.Controls.Add(Me.Txttel1)
        Me.TabPage1.Controls.Add(Me.Txdireccion)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.Txtfax2)
        Me.TabPage1.Controls.Add(Me.Txttel2)
        Me.TabPage1.Controls.Add(Me.CbTipoPrecio)
        Me.TabPage1.Controls.Add(Me.Txtidentificacion)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(640, 140)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(456, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tipo Precio"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Teléfono"
        '
        'Txtfax1
        '
        Me.Txtfax1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfax1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.fax_01"))
        Me.Txtfax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfax1.ForeColor = System.Drawing.Color.Blue
        Me.Txtfax1.Location = New System.Drawing.Point(224, 24)
        Me.Txtfax1.Name = "Txtfax1"
        Me.Txtfax1.Size = New System.Drawing.Size(104, 13)
        Me.Txtfax1.TabIndex = 2
        Me.Txtfax1.Text = ""
        '
        'Txttel1
        '
        Me.Txttel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.Telefono_01"))
        Me.Txttel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttel1.ForeColor = System.Drawing.Color.Blue
        Me.Txttel1.Location = New System.Drawing.Point(8, 24)
        Me.Txttel1.Name = "Txttel1"
        Me.Txttel1.Size = New System.Drawing.Size(96, 13)
        Me.Txttel1.TabIndex = 0
        Me.Txttel1.Text = ""
        '
        'Txdireccion
        '
        Me.Txdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.direccion"))
        Me.Txdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txdireccion.ForeColor = System.Drawing.Color.Blue
        Me.Txdireccion.Location = New System.Drawing.Point(8, 68)
        Me.Txdireccion.Name = "Txdireccion"
        Me.Txdireccion.Size = New System.Drawing.Size(432, 13)
        Me.Txdireccion.TabIndex = 4
        Me.Txdireccion.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(224, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Fax (es):"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(432, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(432, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Correo Electrónico"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.e_mail"))
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Blue
        Me.TxtEmail.Location = New System.Drawing.Point(8, 120)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(432, 13)
        Me.TxtEmail.TabIndex = 5
        Me.TxtEmail.Text = ""
        '
        'Txtfax2
        '
        Me.Txtfax2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfax2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.fax_02"))
        Me.Txtfax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfax2.ForeColor = System.Drawing.Color.Blue
        Me.Txtfax2.Location = New System.Drawing.Point(344, 24)
        Me.Txtfax2.Name = "Txtfax2"
        Me.Txtfax2.Size = New System.Drawing.Size(96, 13)
        Me.Txtfax2.TabIndex = 3
        Me.Txtfax2.Text = ""
        '
        'Txttel2
        '
        Me.Txttel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.telefono_02"))
        Me.Txttel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttel2.ForeColor = System.Drawing.Color.Blue
        Me.Txttel2.Location = New System.Drawing.Point(120, 24)
        Me.Txttel2.Name = "Txttel2"
        Me.Txttel2.Size = New System.Drawing.Size(96, 13)
        Me.Txttel2.TabIndex = 1
        Me.Txttel2.Text = ""
        '
        'CbTipoPrecio
        '
        Me.CbTipoPrecio.DisplayMember = "1"
        Me.CbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoPrecio.ForeColor = System.Drawing.Color.Blue
        Me.CbTipoPrecio.Items.AddRange(New Object() {"PRECIO A", "PRECIO B", "PRECIO C", "PRECIO D"})
        Me.CbTipoPrecio.Location = New System.Drawing.Point(456, 24)
        Me.CbTipoPrecio.Name = "CbTipoPrecio"
        Me.CbTipoPrecio.Size = New System.Drawing.Size(176, 21)
        Me.CbTipoPrecio.TabIndex = 7
        '
        'Txtidentificacion
        '
        Me.Txtidentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtidentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Clientes_frecuentes.identificacion"))
        Me.Txtidentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtidentificacion.ForeColor = System.Drawing.Color.Blue
        Me.Txtidentificacion.Location = New System.Drawing.Point(288, 120)
        Me.Txtidentificacion.Name = "Txtidentificacion"
        Me.Txtidentificacion.Size = New System.Drawing.Size(147, 13)
        Me.Txtidentificacion.TabIndex = 6
        Me.Txtidentificacion.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Table.Cliente_No"))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(6, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 16)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "00000000"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.SeaGreen
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(0, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(672, 40)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Clientes frecuentes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelID_TipoPrecio
        '
        Me.LabelID_TipoPrecio.Location = New System.Drawing.Point(168, 386)
        Me.LabelID_TipoPrecio.Name = "LabelID_TipoPrecio"
        Me.LabelID_TipoPrecio.Size = New System.Drawing.Size(65, 16)
        Me.LabelID_TipoPrecio.TabIndex = 82
        Me.LabelID_TipoPrecio.Text = "0"
        '
        'ComboBoxRestricciones
        '
        Me.ComboBoxRestricciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRestricciones.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRestricciones.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxRestricciones.Items.AddRange(New Object() {"NO", "SI"})
        Me.ComboBoxRestricciones.Location = New System.Drawing.Point(456, 387)
        Me.ComboBoxRestricciones.Name = "ComboBoxRestricciones"
        Me.ComboBoxRestricciones.Size = New System.Drawing.Size(64, 22)
        Me.ComboBoxRestricciones.TabIndex = 79
        '
        'Adapter_Clientes_fre
        '
        Me.Adapter_Clientes_fre.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Clientes_fre.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Clientes_fre.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Clientes_fre.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes_frecuentes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("Telefono_01", "Telefono_01"), New System.Data.Common.DataColumnMapping("telefono_02", "telefono_02"), New System.Data.Common.DataColumnMapping("fax_01", "fax_01"), New System.Data.Common.DataColumnMapping("fax_02", "fax_02"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("tipoprecio", "tipoprecio"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombreusuario", "nombreusuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("esempresa", "esempresa")})})
        Me.Adapter_Clientes_fre.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Clientes_frecuentes WHERE (identificacion = @Original_identificacion)" & _
        ""
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=s" & _
        "eepos"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Clientes_frecuentes(identificacion, cedula, nombre, observaciones, Te" & _
        "lefono_01, telefono_02, fax_01, fax_02, e_mail, direccion, tipoprecio, usuario, " & _
        "nombreusuario, Anulado, esempresa) VALUES (@identificacion, @cedula, @nombre, @o" & _
        "bservaciones, @Telefono_01, @telefono_02, @fax_01, @fax_02, @e_mail, @direccion," & _
        " @tipoprecio, @usuario, @nombreusuario, @Anulado, @esempresa); SELECT identifica" & _
        "cion, cedula, nombre, observaciones, Telefono_01, telefono_02, fax_01, fax_02, e" & _
        "_mail, direccion, tipoprecio, usuario, nombreusuario, Anulado, esempresa FROM Cl" & _
        "ientes_frecuentes WHERE (identificacion = @identificacion)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@esempresa", System.Data.SqlDbType.BigInt, 1, "esempresa"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, f" & _
        "ax_01, fax_02, e_mail, direccion, tipoprecio, usuario, nombreusuario, Anulado, e" & _
        "sempresa FROM Clientes_frecuentes"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Clientes_frecuentes SET identificacion = @identificacion, cedula = @cedula" & _
        ", nombre = @nombre, observaciones = @observaciones, Telefono_01 = @Telefono_01, " & _
        "telefono_02 = @telefono_02, fax_01 = @fax_01, fax_02 = @fax_02, e_mail = @e_mail" & _
        ", direccion = @direccion, tipoprecio = @tipoprecio, usuario = @usuario, nombreus" & _
        "uario = @nombreusuario, Anulado = @Anulado, esempresa = @esempresa WHERE (identi" & _
        "ficacion = @Original_identificacion); SELECT identificacion, cedula, nombre, obs" & _
        "ervaciones, Telefono_01, telefono_02, fax_01, fax_02, e_mail, direccion, tipopre" & _
        "cio, usuario, nombreusuario, Anulado, esempresa FROM Clientes_frecuentes WHERE (" & _
        "identificacion = @identificacion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 16, "Telefono_01"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 16, "telefono_02"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 16, "fax_01"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 16, "fax_02"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@esempresa", System.Data.SqlDbType.BigInt, 1, "esempresa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adapter_Bitacora
        '
        Me.Adapter_Bitacora.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Bitacora.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Bitacora.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Bitacora.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bitacora", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Secuencia", "Secuencia"), New System.Data.Common.DataColumnMapping("Tabla", "Tabla"), New System.Data.Common.DataColumnMapping("Campo_Clave", "Campo_Clave"), New System.Data.Common.DataColumnMapping("DescripcionCampo", "DescripcionCampo"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("VentaA", "VentaA"), New System.Data.Common.DataColumnMapping("VentaB", "VentaB"), New System.Data.Common.DataColumnMapping("VentaC", "VentaC"), New System.Data.Common.DataColumnMapping("VentaD", "VentaD")})})
        Me.Adapter_Bitacora.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Bitacora WHERE (Secuencia = @Original_Secuencia)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Secuencia", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Secuencia", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Bitacora(Tabla, Campo_Clave, DescripcionCampo, Accion, Fecha, Usuario" & _
        ", Costo, VentaA, VentaB, VentaC, VentaD) VALUES (@Tabla, @Campo_Clave, @Descripc" & _
        "ionCampo, @Accion, @Fecha, @Usuario, @Costo, @VentaA, @VentaB, @VentaC, @VentaD)" & _
        "; SELECT Secuencia, Tabla, Campo_Clave, DescripcionCampo, Accion, Fecha, Usuario" & _
        ", Costo, VentaA, VentaB, VentaC, VentaD FROM Bitacora WHERE (Secuencia = @@IDENT" & _
        "ITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 75, "Tabla"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Campo_Clave", System.Data.SqlDbType.VarChar, 75, "Campo_Clave"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCampo", System.Data.SqlDbType.VarChar, 250, "DescripcionCampo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 75, "Accion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 150, "Usuario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Real, 8, "Costo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaA", System.Data.SqlDbType.Real, 8, "VentaA"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaB", System.Data.SqlDbType.Real, 8, "VentaB"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaC", System.Data.SqlDbType.Real, 8, "VentaC"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaD", System.Data.SqlDbType.Real, 8, "VentaD"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Secuencia, Tabla, Campo_Clave, DescripcionCampo, Accion, Fecha, Usuario, C" & _
        "osto, VentaA, VentaB, VentaC, VentaD FROM Bitacora"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Bitacora SET Tabla = @Tabla, Campo_Clave = @Campo_Clave, DescripcionCampo " & _
        "= @DescripcionCampo, Accion = @Accion, Fecha = @Fecha, Usuario = @Usuario, Costo" & _
        " = @Costo, VentaA = @VentaA, VentaB = @VentaB, VentaC = @VentaC, VentaD = @Venta" & _
        "D WHERE (Secuencia = @Original_Secuencia); SELECT Secuencia, Tabla, Campo_Clave," & _
        " DescripcionCampo, Accion, Fecha, Usuario, Costo, VentaA, VentaB, VentaC, VentaD" & _
        " FROM Bitacora WHERE (Secuencia = @Secuencia)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 75, "Tabla"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Campo_Clave", System.Data.SqlDbType.VarChar, 75, "Campo_Clave"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCampo", System.Data.SqlDbType.VarChar, 250, "DescripcionCampo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 75, "Accion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 150, "Usuario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Real, 8, "Costo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaA", System.Data.SqlDbType.Real, 8, "VentaA"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaB", System.Data.SqlDbType.Real, 8, "VentaB"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaC", System.Data.SqlDbType.Real, 8, "VentaC"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VentaD", System.Data.SqlDbType.Real, 8, "VentaD"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Secuencia", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Secuencia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.Int, 8, "Secuencia"))
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("cedula", "cedula")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Usuarios(Nombre, Clave_Interna, Id_Usuario) VALUES (@Nombre, @Clave_I" & _
        "nterna, @Id_Usuario); SELECT Nombre, Clave_Interna, Id_Usuario AS cedula FROM Us" & _
        "uarios WHERE (Id_Usuario = @cedula)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "cedula"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 50, "cedula"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Nombre, Clave_Interna, Id_Usuario AS cedula FROM Usuarios"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'AdapterConsecutivo
        '
        Me.AdapterConsecutivo.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterConsecutivo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cliente_No", "Cliente_No")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT ISNULL(MAX(identificacion), 0) + 1 AS Cliente_No FROM Clientes_frecuentes " & _
        "NewIdCliente"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txt_accion
        '
        Me.txt_accion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_accion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetClienteFrecuente1, "Bitacora.Accion"))
        Me.txt_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_accion.ForeColor = System.Drawing.Color.Blue
        Me.txt_accion.Location = New System.Drawing.Point(472, 336)
        Me.txt_accion.Name = "txt_accion"
        Me.txt_accion.Size = New System.Drawing.Size(147, 13)
        Me.txt_accion.TabIndex = 13
        Me.txt_accion.Text = ""
        '
        'Ckbempresa
        '
        Me.Ckbempresa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Ckbempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Ckbempresa.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Ckbempresa.Location = New System.Drawing.Point(456, 56)
        Me.Ckbempresa.Name = "Ckbempresa"
        Me.Ckbempresa.Size = New System.Drawing.Size(168, 16)
        Me.Ckbempresa.TabIndex = 13
        Me.Ckbempresa.Text = "Empresa"
        '
        'frmCliente_frecuente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 386)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PanelDatosBasicos)
        Me.Controls.Add(Me.TxtID_Usuario)
        Me.Controls.Add(Me.Tex_Accion)
        Me.Controls.Add(Me.txt_accion)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabelID_TipoPrecio)
        Me.Controls.Add(Me.ComboBoxRestricciones)
        Me.Name = "frmCliente_frecuente"
        Me.Text = "Cliente frecuente"
        Me.Panel1.ResumeLayout(False)
        Me.PanelDatosBasicos.ResumeLayout(False)
        CType(Me.DataSetClienteFrecuente1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim CConexion As New Conexion
    Dim Eliminando As Boolean = False
    Dim Tipo_Accion As String = ""
    Dim usuario_autorizado As String
    Dim usua
    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim strMensaje As String = ""
#Region "variables"
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = False
    Dim Cedula_Usuario As String
    Dim Nombre_Usuario As String
    Dim Abre_Credito As Boolean
    Dim Cod_Cliente_Buscar As Integer
    Dim Perfil_Adminiistrador As Boolean
#End Region
    Private Sub frmCliente_frecuente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establece la conexión a la base de datos al cargar el formulario
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Me.Adapter_Usuarios.Fill(Me.DataSetClienteFrecuente1, "Usuarios")
            PanelDatosBasicos.Enabled = False
            Me.TabPage1.Enabled = False
            '********************************************************************************
            'Me.Adapter_Clientes_frecuentes.Fill(Me.DataSetClienteFrecuente1 , "Clientes_frecuentes")
            '/*******************************************************************************
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.identificacionColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.nombreColumn.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.cedulaColumn.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.Telefono_01Column.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.telefono_02Column.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.fax_01Column.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.fax_02Column.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.e_mailColumn.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.observacionesColumn.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.direccionColumn.DefaultValue = ""
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.tipoprecioColumn.DefaultValue = 1
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.AnuladoColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Clientes_frecuentes.esempresaColumn.DefaultValue = 0

            ''''''''''''''''''''''''Valores por defecto de bitácora
            Me.DataSetClienteFrecuente1.Bitacora.TablaColumn.DefaultValue = "CLIENTES FRECUENTES"
            Me.DataSetClienteFrecuente1.Bitacora.VentaAColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Bitacora.VentaBColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Bitacora.VentaCColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Bitacora.VentaDColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Bitacora.CostoColumn.DefaultValue = 0
            Me.DataSetClienteFrecuente1.Bitacora.FechaColumn.DefaultValue = Date.Now
            Me.DataSetClienteFrecuente1.Bitacora.Campo_ClaveColumn.DefaultValue = "IDENTIFICACION"
            Me.DataSetClienteFrecuente1.Bitacora.DescripcionCampoColumn.DefaultValue = "REGISTRO DE CLIENTE"

            Me.txtUsuario.Focus()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

        'Txtidentificacion.Text = CDbl(cConexion.slqExecuteScalar(sqlConexion, "SELECT MAX(identificacion) FROM Clientes_frecuentes") + 1)
    End Sub
    Private Sub CargarInformacion()
        ' Establece el tipo de precio a mostrar en el formulario
        ' Estable si el cliente paga impuesto
        ' Establece si el cliente es empresa,  ' Establece si el cliente posee restriccion de cuenta
        Try
            Dim tip As Integer = Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("tipoprecio")
            Me.CbTipoPrecio.SelectedIndex = tip - 1
            Me.Label9.Text = Me.Txtidentificacion.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Txtidentificacion.Focus()
    End Sub
    Private Sub Nuevos()
        Nuevo_cliente()
    End Sub
    Function Registrar_Anulacion_cliente(ByVal Anular As Boolean) As Boolean
        Dim Cx As New Conexion
        Try
            If Anular = True Then
                Cx.UpdateRecords("Clientes_frecuentes", "Anulado = 1", "Identificacion = " & BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("Identificacion"), "SeePos")
            Else
                Cx.UpdateRecords("Clientes_frecuentes", "Anulado = 0", "Identificacion = " & BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("Identificacion"), "SeePos")
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
    Private Sub Eliminar()
        Dim Resultado As String
        Dim rs As SqlDataReader
        Dim cant As Integer
        Try
            If Me.Txtidentificacion.Text <> "" Then

                If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()

                cant = CConexion.SlqExecuteScalar(Me.SqlConnection1, "SELECT COUNT(Id) AS Pendientes FROM Ventas  WHERE  (Cod_Cliente = " & Txtidentificacion.Text & ") AND (FacturaCancelado = 0) AND (Anulado = 0)")
                Me.SqlConnection1.Close()

                If cant > 0 Then
                    MsgBox("Este Cliente tiene " & cant.ToString & " Facturas pendientes de Pago, no puede eliminarse", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If


                If MessageBox.Show("Desea Eliminar el Cliente", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub


                ''ingreso a la bitacora
                Me.DataSetClienteFrecuente1.Bitacora.FechaColumn.DefaultValue = Date.Now
                Me.DataSetClienteFrecuente1.Bitacora.UsuarioColumn.DefaultValue = ""

                Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").CancelCurrentEdit()
                Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").EndCurrentEdit()
                Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").AddNew()
                Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").Current("Usuario") = Me.usua.Nombre
                Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").Current("DescripcionCampo") = Me.Txtnombre.Text & " / " & Me.Txtidentificacion.Text
                Me.txt_accion.Text = "CLIENTE FRECUENTE ELIMINADO"
                Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").EndCurrentEdit()

                Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").RemoveAt(Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Position)
                Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()

                Eliminando = True


                If Me.RegistrarCliente Then
                    MessageBox.Show("El cliente fue Eliminado Satisfactoriamente", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()
                End If



            Else
                MessageBox.Show("No hay cliente a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Nuevo_cliente()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Me.Validar_nuevo()
            Case 2 : If PMU.Find Then Me.Busca_Clientes_frecuentes() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If MessageBox.Show("¿Desea Cerrar el Módulo de Clientes_frecuentes?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub
    Private Sub Imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Reporte_Clientes_frecuentes As New Reporte_Cliente
            Dim visor As New frmVisorReportes
            Reporte_Clientes_frecuentes.SetParameterValue(0, CDbl(Label9.Text))
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Reporte_Clientes_frecuentes)
            visor.rptViewer.Visible = True
            Reporte_Clientes_frecuentes = Nothing
            visor.ShowDialog()
            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Validar_nuevo()
        Try
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False
                PanelDatosBasicos.Enabled = True

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.txtUsuario.Focus()
                strMensaje = ""
            Else
                If Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Count = 0 Then  'Si  no se ha aregadoningún cliente
                    Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").CancelCurrentEdit()
                    PanelDatosBasicos.Enabled = False
                    Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()
                    nuevo = False
                    Exit Sub
                End If

                If MessageBox.Show("Desea Guardar los datos de este Cliente", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Registrar() ' se guarda en la base de datos
                    Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True
                Else
                    Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").CancelCurrentEdit()
                    Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()
                    PanelDatosBasicos.Enabled = False
                    Me.TabPage1.Enabled = False
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    nuevo = False
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Loggin_Usuario()
        Try
            If Me.BindingContext(Me.DataSetClienteFrecuente1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSetClienteFrecuente1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    txtNombreUsuario.Text = Usua("Nombre")
                    Me.TxtID_Usuario.Text = Usua("Cedula")
                    usuario_autorizado = txtNombreUsuario.Text
                    Me.Nombre_Usuario = Usua("Nombre")
                    Me.Cedula_Usuario = Usua("Cedula")
                    Me.DataSetClienteFrecuente1.Clientes_frecuentes.usuarioColumn.DefaultValue = Usua("Cedula")
                    Me.DataSetClienteFrecuente1.Clientes_frecuentes.nombreusuarioColumn.DefaultValue = Usua("Nombre")
                    strMensaje = ""

                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 

                    Me.PanelDatosBasicos.Enabled = True
                    Me.TabPage1.Enabled = True

                    txtUsuario.Enabled = False 'se inabilita el campo de la contraseña
                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8
                    Me.ToolBar1.Buttons(3).Enabled = True
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = True
                    'Validar si el usuario puede o no anular una cotización
                    Abre_Credito = PMU.Others
                    Perfil_Adminiistrador = PMU.Others
                    Nuevo_cliente()
                    DataSetClienteFrecuente1.Tables("Table").Clear()
                    AdapterConsecutivo.Fill(DataSetClienteFrecuente1, "Table")
                    Txtidentificacion.Text = Label9.Text
                    txtNombreUsuario.Text = Usua("Nombre")
                    TxtID_Usuario.Text = Usua("Cedula")
                    '---------------------------------------------------

                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    txtUsuario.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nuevo_cliente()
        Try
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").AddNew()
            Me.nuevo = True
            Me.CbTipoPrecio.SelectedIndex = 0
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Me.ToolBar1.Buttons(3).Enabled = False

            Me.ToolBar1.Buttons(0).Enabled = True
            Me.ToolBar1.Buttons(1).Enabled = True
            Me.ToolBar1.Buttons(2).Enabled = True

            Me.Txtnombre.Focus()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then Loggin_Usuario()
    End Sub
    Private Sub Cbtipoprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTipoPrecio.SelectedIndexChanged
        Select Case CbTipoPrecio.SelectedIndex
            Case -1 : CbTipoPrecio.SelectedIndex = 0
            Case Else : LabelID_TipoPrecio.Text = CbTipoPrecio.SelectedIndex + 1
        End Select
    End Sub

    Private Sub Registrar()
        Try
            Me.ToolBar1.Buttons(2).Enabled = False
            Txtidentificacion.Text = Txtidentificacion.Text
            If MessageBox.Show("¿Desea Registrar este Cliente?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Exit Sub
            End If
            Me.DataSetClienteFrecuente1.Bitacora.AccionColumn.DefaultValue = "-"
            Me.DataSetClienteFrecuente1.Bitacora.FechaColumn.DefaultValue = Date.Now
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").EndCurrentEdit()
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").AddNew()
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").Current("Usuario") = Me.usuario_autorizado
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").Current("DescripcionCampo") = Me.Txtnombre.Text & " / " & Me.Txtidentificacion.Text

            'If Me.CheckBoxAnular.Checked = True Then
            '    Registrar_Anulacion_cliente(True)
            'Else
            '    Registrar_Anulacion_cliente(False)
            'End If

            If nuevo Then
                Me.DataSetClienteFrecuente1.Tables("Table").Clear()
                Me.AdapterConsecutivo.Fill(Me.DataSetClienteFrecuente1, "Table")
                Txtidentificacion.Text = Me.Label9.Text
                Me.txt_accion.Text = "CLIENTE FRECUENTE INGRESADO"

            ElseIf Me.Eliminando Then
                Me.txt_accion.Text = "CLIENTE FRECUENTE ELIMINADO"

            Else
                Me.Tex_Accion.Text = "CLIENTE FRECUENTE ACTUALIZADO"
            End If
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").EndCurrentEdit()

            BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("nombreusuario") = txtNombreUsuario.Text
            BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("Usuario") = TxtID_Usuario.Text
            BindingContext(DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()


            If Me.RegistrarCliente() Then 'se registra en la base de datos then
                Me.DataSetClienteFrecuente1.AcceptChanges()

                Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()

                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True

                Me.PanelDatosBasicos.Enabled = False
                Me.TabPage1.Enabled = False


                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False

                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Focus()

                nuevo = False
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(2).Enabled = False
                strMensaje = "ok"

            Else
                MsgBox("Error al guardar cliente", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True

            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message)
        End Try

    End Sub

    Function RegistrarCliente() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.SqlInsertCommand1.Transaction = Trans
            Me.SqlUpdateCommand1.Transaction = Trans
            Me.SqlDeleteCommand1.Transaction = Trans

            Me.SqlInsertCommand2.Transaction = Trans
            Me.SqlUpdateCommand2.Transaction = Trans
            Me.SqlDeleteCommand2.Transaction = Trans

            Me.SqlInsertCommand3.Transaction = Trans
            'Me.SqlUpdateCommand3.Transaction = Trans
            'Me.SqlDeleteCommand3.Transaction = Trans

            'Me.SqlInsertCommand4.Transaction = Trans
            'Me.SqlUpdateCommand4.Transaction = Trans
            'Me.SqlDeleteCommand4.Transaction = Trans

            Me.Adapter_Bitacora.SelectCommand.Transaction = Trans
            Me.Adapter_Bitacora.InsertCommand.Transaction = Trans
            Me.Adapter_Bitacora.DeleteCommand.Transaction = Trans
            Me.Adapter_Bitacora.UpdateCommand.Transaction = Trans

            Me.Adapter_Clientes_fre.Update(Me.DataSetClienteFrecuente1, "Clientes_frecuentes")
            Me.Adapter_Bitacora.Update(Me.DataSetClienteFrecuente1, "Bitacora")

            Me.Eliminando = False
            Me.nuevo = False
            usuario_autorizado = ""

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
    Private Sub Txtemail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEmail.Validating
        If Me.TxtEmail.Text <> "" Then ' si hay algo digitado en el campo e-mail
            Dim parte1 As Integer
            Dim parte2 As Integer
            Dim parte3 As Integer
            parte1 = TxtEmail.Text.IndexOf("@") 'almacena la cantidad de caracteres hasta llegar al @
            parte2 = TxtEmail.Text.IndexOf(".") 'almacena la cantidad de caracteres hasta llegar al "."
            parte3 = TxtEmail.Text.Length ' almacena la cantidad total de caracteres de la cadena
            If (Not (parte1 >= 3 And parte2 >= 6 And parte3 >= 9)) Then 'si antes del @ hay menos de 3 carcteres y antes del punto hay  menos de 6 y si toda la cadena tiene menos de 9 caracteres
                ErrorProvider1.SetError(sender, "Digite un correo electrónico válido")
                e.Cancel = True
            Else
                ErrorProvider1.SetError(sender, "")
            End If

        End If

    End Sub


    Private Sub Txtidentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtidentificacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then SendKeys.Send("{TAB}")

        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcedula.KeyPress

        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txttel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttel1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub


    Private Sub Txttel2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttel2.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub


    Private Sub Txtfax1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfax1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub

    Private Sub Txtfax2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfax2.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If

    End Sub
    Private Sub Txtidentificacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtidentificacion.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Busca_Clientes_frecuentes()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Busca_Clientes_frecuentes()
        Try
            Nuevos()
            Dim cFunciones As New cFunciones
            Me.Cod_Cliente_Buscar = cFunciones.BuscarDatosClientes("select identificacion as Identificación,nombre as Nombre from Clientes_frecuentes", "Nombre")

            If Cod_Cliente_Buscar = 0 Then Exit Sub
            Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").CancelCurrentEdit()

            If nuevo Then nuevo = False
            LlenarCliente(Cod_Cliente_Buscar)


            Me.CargarInformacion()
            Me.PanelDatosBasicos.Enabled = True
            Me.TabPage1.Enabled = True

            strMensaje = ""

            'If usua.Perfil = "ADMINISTRADOR" Then
            If PMU.Others Then
                'Cbcredito.Enabled = True
            Else

                'Cbcredito.Enabled = False
            End If

            Me.ToolBar1.Buttons(1).Enabled = True
            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub LlenarCliente(ByVal Id As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            '''''''''LLENAR CLIENTE''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Clientes_frecuentes WHERE (identificacion = @Id) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))

            cmdv.Parameters("@Id").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSetClienteFrecuente1, "Clientes_frecuentes")

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
    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtnombre.KeyDown, Txtcedula.KeyDown, Txtobserv.KeyDown, Txttel1.KeyDown, Txttel2.KeyDown, Txtfax1.KeyDown, Txtfax2.KeyDown, Txdireccion.KeyDown, TxtEmail.KeyDown, Txtobserv.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                'Me.ComboBoxAgente.SelectedIndex = -1
            Case Keys.Enter
                Me.Validacion_Datos()
                If sender.name = Txtobserv.Name Then
                    TabPage1.Visible = True
                    TabControl1.TabPages(0).Visible = True
                    Me.Txttel1.Focus()
                Else
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub

    Private Sub Txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txtnombre.Validating
        If Len(Me.Txtnombre.Text) = 0 Then
            ErrorProvider1.SetError(sender, "Debe de Digitar el nombre del Cliente")
            'e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Validacion_Datos()

        If Len(Me.Txtnombre.Text) = 0 Then
            ErrorProvider1.SetError(Txtnombre, "Debe de Digitar el nombre del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txtnombre, "")
        End If

        If Len(Me.Txtcedula.Text) = 0 Then
            ErrorProvider1.SetError(Txtcedula, "Debe de Digitar el nombre del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txtcedula, "")
        End If

        If Len(Me.Txttel1.Text) = 0 Then
            ErrorProvider1.SetError(Txttel1, "Debe de Digitar un número de teléfono del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txttel1, "")
        End If

        If Len(Me.Txtfax1.Text) = 0 Then
            ErrorProvider1.SetError(Txtfax1, "Debe de Digitar un número de Fax del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txtfax1, "")
        End If

        If Len(Me.Txdireccion.Text) = 0 Then
            ErrorProvider1.SetError(Txdireccion, "Debe de Digitar la dirección del Cliente")
            Exit Sub
        Else
            ErrorProvider1.SetError(Txdireccion, "")
        End If

        Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
