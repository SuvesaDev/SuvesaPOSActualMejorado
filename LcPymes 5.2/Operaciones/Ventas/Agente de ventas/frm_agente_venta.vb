Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frm_agente_venta
    Inherits System.Windows.Forms.Form
    Dim strModulo As String = ""
    Dim CConexion As New Conexion
    Dim Eliminando As Boolean = False
    Dim Tipo_Accion As String = ""
    Dim usuario_autorizado As String
    Dim usua
    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim strMensaje As String = ""
    Dim sqlConexion As SqlConnection
#Region "variables"
    Dim NuevaConexion As String
    Private nuevo As Boolean = False
    Dim Cedula_Usuario As String
    Dim Nombre_Usuario As String
    Dim Abre_Credito As Boolean
    Dim Cod_agente_Buscar As Integer
    Friend WithEvents btnPD As System.Windows.Forms.Button
    Dim Perfil_Adminiistrador As Boolean
#End Region
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        NuevaConexion = Conexion
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckactivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_agentes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DtsAgentes1 As LcPymes_5._2.DtsAgentes
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Txtidentificacion As System.Windows.Forms.Label
    Friend WithEvents PanelDatosBasicos As System.Windows.Forms.Panel
    Friend WithEvents TxtID_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents listado As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_agente_venta))
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckactivo = New System.Windows.Forms.CheckBox()
        Me.DtsAgentes1 = New LcPymes_5._2.DtsAgentes()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_agentes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Txtidentificacion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.PanelDatosBasicos = New System.Windows.Forms.Panel()
        Me.TxtID_Usuario = New System.Windows.Forms.TextBox()
        Me.listado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPD = New System.Windows.Forms.Button()
        CType(Me.DtsAgentes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelDatosBasicos.SuspendLayout()
        CType(Me.listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cédula"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'ckactivo
        '
        Me.ckactivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DtsAgentes1, "agente_ventas.activo", True))
        Me.ckactivo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckactivo.Location = New System.Drawing.Point(106, 231)
        Me.ckactivo.Name = "ckactivo"
        Me.ckactivo.Size = New System.Drawing.Size(124, 27)
        Me.ckactivo.TabIndex = 6
        Me.ckactivo.Text = "Activo"
        '
        'DtsAgentes1
        '
        Me.DtsAgentes1.DataSetName = "DtsAgentes"
        Me.DtsAgentes1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DtsAgentes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtnombre
        '
        Me.txtnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAgentes1, "agente_ventas.nombre", True))
        Me.txtnombre.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(106, 55)
        Me.txtnombre.MaxLength = 150
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(412, 26)
        Me.txtnombre.TabIndex = 7
        '
        'txtcedula
        '
        Me.txtcedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAgentes1, "agente_ventas.cedula", True))
        Me.txtcedula.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(106, 92)
        Me.txtcedula.MaxLength = 10
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(163, 26)
        Me.txtcedula.TabIndex = 8
        '
        'txttelefono
        '
        Me.txttelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAgentes1, "agente_ventas.telefono", True))
        Me.txttelefono.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(106, 129)
        Me.txttelefono.MaxLength = 15
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(163, 26)
        Me.txttelefono.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAgentes1, "agente_ventas.correo", True))
        Me.txtemail.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(106, 166)
        Me.txtemail.MaxLength = 250
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(412, 26)
        Me.txtemail.TabIndex = 10
        '
        'txtdireccion
        '
        Me.txtdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAgentes1, "agente_ventas.direccion", True))
        Me.txtdireccion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(106, 203)
        Me.txtdireccion.MaxLength = 250
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(412, 26)
        Me.txtdireccion.TabIndex = 11
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 287)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(808, 65)
        Me.ToolBar1.TabIndex = 81
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
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
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""PC4-PC"";packet size=4096;integrated security=SSPI;data source="".""" & _
    ";persist security info=False;initial catalog=Northwind"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_agentes
        '
        Me.Adapter_agentes.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_agentes.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_agentes.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_agentes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agente_ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("correo", "correo"), New System.Data.Common.DataColumnMapping("activo", "activo"), New System.Data.Common.DataColumnMapping("anulado", "anulado"), New System.Data.Common.DataColumnMapping("id", "id")})})
        Me.Adapter_agentes.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM agente_ventas WHERE (id = @Original_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 50, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 150, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 250, "direccion"), New System.Data.SqlClient.SqlParameter("@correo", System.Data.SqlDbType.VarChar, 250, "correo"), New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.Bit, 1, "activo"), New System.Data.SqlClient.SqlParameter("@anulado", System.Data.SqlDbType.Bit, 1, "anulado")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cedula, nombre, telefono, direccion, correo, activo, anulado, id FROM agen" & _
    "te_ventas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 50, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 150, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 250, "direccion"), New System.Data.SqlClient.SqlParameter("@correo", System.Data.SqlDbType.VarChar, 250, "correo"), New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.Bit, 1, "activo"), New System.Data.SqlClient.SqlParameter("@anulado", System.Data.SqlDbType.Bit, 1, "anulado"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Txtidentificacion
        '
        Me.Txtidentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAgentes1, "agente_ventas.id", True))
        Me.Txtidentificacion.Location = New System.Drawing.Point(470, 65)
        Me.Txtidentificacion.Name = "Txtidentificacion"
        Me.Txtidentificacion.Size = New System.Drawing.Size(39, 18)
        Me.Txtidentificacion.TabIndex = 82
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(443, 322)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 19)
        Me.Panel1.TabIndex = 83
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(-10, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(87, 15)
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
        Me.txtNombreUsuario.Location = New System.Drawing.Point(148, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(207, 15)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(77, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(67, 15)
        Me.txtUsuario.TabIndex = 1
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Usuarios.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("cedula", "cedula")})})
        Me.Adapter_Usuarios.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Usuarios WHERE (Id_Usuario = @Original_cedula)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Usuarios(Nombre, Clave_Interna, Id_Usuario) VALUES (@Nombre, @Clave_I" & _
    "nterna, @Id_Usuario); SELECT Nombre, Clave_Interna, Id_Usuario AS cedula FROM Us" & _
    "uarios WHERE (Id_Usuario = @cedula)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "cedula"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 50, "cedula")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Nombre, Clave_Interna, Id_Usuario AS cedula FROM Usuarios"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "cedula"), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 50, "cedula")})
        '
        'PanelDatosBasicos
        '
        Me.PanelDatosBasicos.BackColor = System.Drawing.Color.PowderBlue
        Me.PanelDatosBasicos.Controls.Add(Me.btnPD)
        Me.PanelDatosBasicos.Controls.Add(Me.ckactivo)
        Me.PanelDatosBasicos.Controls.Add(Me.txtnombre)
        Me.PanelDatosBasicos.Controls.Add(Me.txtcedula)
        Me.PanelDatosBasicos.Controls.Add(Me.txttelefono)
        Me.PanelDatosBasicos.Controls.Add(Me.txtemail)
        Me.PanelDatosBasicos.Controls.Add(Me.txtdireccion)
        Me.PanelDatosBasicos.Controls.Add(Me.Label1)
        Me.PanelDatosBasicos.Controls.Add(Me.Txtidentificacion)
        Me.PanelDatosBasicos.Controls.Add(Me.Label2)
        Me.PanelDatosBasicos.Controls.Add(Me.Label3)
        Me.PanelDatosBasicos.Controls.Add(Me.Label4)
        Me.PanelDatosBasicos.Controls.Add(Me.Label6)
        Me.PanelDatosBasicos.Location = New System.Drawing.Point(10, 9)
        Me.PanelDatosBasicos.Name = "PanelDatosBasicos"
        Me.PanelDatosBasicos.Size = New System.Drawing.Size(528, 268)
        Me.PanelDatosBasicos.TabIndex = 84
        '
        'TxtID_Usuario
        '
        Me.TxtID_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtID_Usuario.Enabled = False
        Me.TxtID_Usuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtID_Usuario.Location = New System.Drawing.Point(235, 179)
        Me.TxtID_Usuario.Name = "TxtID_Usuario"
        Me.TxtID_Usuario.Size = New System.Drawing.Size(77, 15)
        Me.TxtID_Usuario.TabIndex = 85
        '
        'listado
        '
        Me.listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listado.DataMember = "agente_ventas"
        Me.listado.DataSource = Me.DtsAgentes1
        '
        '
        '
        Me.listado.EmbeddedNavigator.Name = ""
        Me.listado.Enabled = False
        Me.listado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.listado.Location = New System.Drawing.Point(547, 46)
        Me.listado.MainView = Me.GridView1
        Me.listado.Name = "listado"
        Me.listado.Size = New System.Drawing.Size(251, 230)
        Me.listado.TabIndex = 86
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo5
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 53
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre "
        Me.GridColumn2.FieldName = "nombre"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo6
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 289
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(547, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(413, 27)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "LISTADO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPD
        '
        Me.btnPD.Enabled = False
        Me.btnPD.Location = New System.Drawing.Point(415, 235)
        Me.btnPD.Name = "btnPD"
        Me.btnPD.Size = New System.Drawing.Size(103, 23)
        Me.btnPD.TabIndex = 83
        Me.btnPD.Text = "PD"
        Me.btnPD.UseVisualStyleBackColor = True
        '
        'frm_agente_venta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(808, 352)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PanelDatosBasicos)
        Me.Controls.Add(Me.TxtID_Usuario)
        Me.MaximizeBox = False
        Me.Name = "frm_agente_venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agentes de ventas"
        CType(Me.DtsAgentes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelDatosBasicos.ResumeLayout(False)
        Me.PanelDatosBasicos.PerformLayout()
        CType(Me.listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frm_agente_venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establece la conexión a la base de datos al cargar el formulario
        Try
            Me.SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
            Me.Adapter_Usuarios.Fill(Me.DtsAgentes1, "Usuarios")
            Me.Adapter_agentes.Fill(Me.DtsAgentes1, "agente_ventas")
            PanelDatosBasicos.Enabled = False
            '/*******************************************************************************
            Me.DtsAgentes1.agente_ventas.idColumn.AutoIncrement = -1
            Me.DtsAgentes1.agente_ventas.cedulaColumn.DefaultValue = 0
            Me.DtsAgentes1.agente_ventas.nombreColumn.DefaultValue = "-"
            Me.DtsAgentes1.agente_ventas.direccionColumn.DefaultValue = "-"
            Me.DtsAgentes1.agente_ventas.telefonoColumn.DefaultValue = "-"
            Me.DtsAgentes1.agente_ventas.correoColumn.DefaultValue = "-"
            Me.DtsAgentes1.agente_ventas.activoColumn.DefaultValue = False
            Me.DtsAgentes1.agente_ventas.anuladoColumn.DefaultValue = False


            strModulo = IIf(NuevaConexion = "", "SeePOS", "SeePos")
            Me.txtUsuario.Focus()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Loggin_Usuario()
        Try
            If Me.BindingContext(Me.DtsAgentes1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DtsAgentes1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    txtNombreUsuario.Text = Usua("Nombre")
                    Me.TxtID_Usuario.Text = Usua("Cedula")
                    usuario_autorizado = txtNombreUsuario.Text
                    Me.Nombre_Usuario = Usua("Nombre")
                    Me.Cedula_Usuario = Usua("Cedula")
                    strMensaje = ""

                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 

                    Me.PanelDatosBasicos.Enabled = True
                    Me.NuevosDatos(Me.DtsAgentes1, Me.DtsAgentes1.agente_ventas.ToString)

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


                    ' Txtidentificacion.Text = Label9.Text
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
    Function Nuevo_agente()
        Try
            Me.BindingContext(Me.DtsAgentes1.agente_ventas).EndCurrentEdit()
            Me.BindingContext(Me.DtsAgentes1.agente_ventas).AddNew()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function
    Function Registrar()
        Try
            Me.BindingContext(Me.DtsAgentes1.agente_ventas).EndCurrentEdit()
            Me.Adapter_agentes.Update(Me.DtsAgentes1.agente_ventas)
            MsgBox("Los datos fueron ingresados correctamente")
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try

            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0
                    If ToolBar1.Buttons(0).Text = "Nuevo" Then
                        Me.NuevosDatos(Me.DtsAgentes1, Me.DtsAgentes1.agente_ventas.ToString)
                        ToolBar1.Buttons(0).Text = "Cancelar"
                        ToolBar1.Buttons(0).ImageIndex = 8
                        Me.ToolBar1.Buttons(2).Enabled = True
                        Me.ToolBarBuscar.Enabled = False
                        Me.ToolBarImprimir.Enabled = False
                        Me.ToolBarEliminar.Enabled = False
                        Me.btnPD.Enabled = False
                        listado.Enabled = False
                    Else
                        Me.BindingContext(Me.DtsAgentes1, "agente_ventas").CancelCurrentEdit()
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarImprimir.Enabled = True
                        Me.ToolBarEliminar.Enabled = True
                        Me.btnPD.Enabled = True
                        listado.Enabled = True
                    End If

                Case 1 : If PMU.Find Then Me.Buscar_agente() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 2 : If PMU.Update Then
                        Me.RegistrarDatos(Me.Adapter_agentes, Me.DtsAgentes1, Me.DtsAgentes1.agente_ventas.ToString)
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarImprimir.Enabled = True
                        Me.ToolBarEliminar.Enabled = True
                    Else
                        MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If

                Case 3 : If PMU.Delete Then EliminaMarca() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4 : If PMU.Print Then Me.imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 6 : Me.Cerrar()

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Cerrar()
        If MsgBox("Desea Cerrar este módulo...[" & Me.Text & "]", MsgBoxStyle.YesNo, "Atención..") = MsgBoxResult.Yes Then Close()
    End Sub
    Public Sub RegistrarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal ActivarNuevo As Boolean = True, Optional ByVal VerMsg As Boolean = True, Optional ByVal RecargarAdatador As Boolean = True)
        Try
            BindingContext(DataSet, Tabla).EndCurrentEdit()
            Adaptador.Update(DataSet, Tabla)
            If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub NuevosDatos(ByRef DataSet As DataSet, ByRef Tabla As String)
        'Define dataset y tablas para crear  un nuevo campo
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8

            Try
                BindingContext(DataSet, Tabla).EndCurrentEdit()
                BindingContext(DataSet, Tabla).AddNew()
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            Me.BindingContext(DataSet, Tabla).CancelCurrentEdit()
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
        End If
    End Sub
    Sub imprimir()
        'Try
        '    'LFCHG 07122006
        '    Me.ToolBar1.Buttons(4).Enabled = False
        '    Dim Marcas_Reporte As New Reporte_Marcas
        '    CrystalReportsConexion.LoadShow(Marcas_Reporte, Me.MdiParent, Me.SqlConnection1.ConnectionString)
        '    Me.ToolBar1.Buttons(4).Enabled = True
        'Catch ex As SystemException
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub EliminaMarca()
        Try
            Dim rs As SqlDataReader
            If Me.BindingContext(Me.DtsAgentes1.agente_ventas).Count > 0 Then

                'Evaluo si las subfamilias estan asociadas a un articulo 
                Dim strCodigoagente As String = Me.BindingContext(Me.DtsAgentes1, "agente_ventas").Current("id")
                'Habro la conexion 
                sqlConexion = CConexion.Conectar(strModulo)
                'Realizo la busqueda en la base de datos
                rs = CConexion.GetRecorset(sqlConexion, "SELECT cod_agente FROM ventas WHERE cod_agente = '" & strCodigoagente & "'")
                'Evaluo si encontro registros dentro de la tabla inventario
                If rs.Read Then
                    MsgBox("No se puede eliminar este agente por que existe facturas que pertenecen a él")
                    rs.Close()
                    CConexion.DesConectar(sqlConexion)
                    Exit Sub
                End If
                'Si no encontro registros eliminara el registro actual
                Me.EliminarDatos(Me.Adapter_agentes, Me.DtsAgentes1, Me.DtsAgentes1.agente_ventas.ToString)
            End If
            rs.Close()
            CConexion.DesConectar(sqlConexion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub EliminarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal RecargarAdatador As Boolean = True)
        Dim resp As Integer

        If MsgBox("Desea eliminar el registro actual...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
            Try
                BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
                BindingContext(DataSet, Tabla).EndCurrentEdit()
                Adaptador.Update(DataSet, Tabla)
                If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
                Adaptador.Fill(DataSet, Tabla)

                MsgBox("Los datos se eliminaron satisfactoriamente", MsgBoxStyle.Information)

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then Loggin_Usuario()
    End Sub
    Private Sub Buscar_agente()
        Try
            Dim cFunciones As New cFunciones
            Me.Cod_agente_Buscar = cFunciones.BuscarDatosClientes("select id as id,nombre as Nombre from agente_ventas", "Nombre")

            If Cod_agente_Buscar = 0 Then Exit Sub
            Me.BindingContext(Me.DtsAgentes1, "agente_ventas").CancelCurrentEdit()

            If nuevo Then nuevo = False
            LlenarCliente(Cod_agente_Buscar)

            Me.CargarInformacion()
            Me.PanelDatosBasicos.Enabled = True

            strMensaje = ""

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
            Dim sel As String = "SELECT * FROM agente_ventas WHERE (id = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.Int))

            cmdv.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DtsAgentes1, "agente_ventas")

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
    Private Sub CargarInformacion()
        ' Establece el tipo de precio a mostrar en el formulario
        ' Estable si el cliente paga impuesto
        ' Establece si el cliente es empresa,  ' Establece si el cliente posee restriccion de cuenta
        Try
            'Dim tip As Integer = Me.BindingContext(Me.DtsAgentes1, "agente_ventas").Current("act")
            'Me.CbTipoPrecio.SelectedIndex = tip - 1
            'Me.Label9.Text = Me.Txtidentificacion.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Txtidentificacion.Focus()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listado.Click
        Me.BindingContext(Me.DtsAgentes1, "agente_ventas").CancelCurrentEdit()
        Me.ToolBar1.Buttons(2).Enabled = True
    End Sub

    Private Sub btnPD_Click(sender As Object, e As EventArgs) Handles btnPD.Click
        Dim frm As New frmPD
        frm.IdAgente = Me.BindingContext(Me.DtsAgentes1, "agente_ventas").Current("id")
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Delete from PrecioDiferenciado Where IdAgente = " & frm.IdAgente, CommandType.Text)
            For Each f As DataGridViewRow In frm.DataGridView1.Rows
                db.Ejecutar("insert into PrecioDiferenciado(IdAgente, CodProveedor, Proveedor, Tipo, Porcentaje) values(" & frm.IdAgente & ", " & f.Cells("cCodProveedor").Value & ", '" & f.Cells("cProveedor").Value & "', '" & f.Cells("cTipo").Value & "', " & f.Cells("cPorcentaje").Value & ")", CommandType.Text)
            Next
        End If
    End Sub

End Class
